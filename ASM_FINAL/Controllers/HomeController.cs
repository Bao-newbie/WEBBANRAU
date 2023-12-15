using ASM_FINAL.IServices;
using ASM_FINAL.Models;
using ASM_FINAL.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASM_FINAL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductServices productServices;
        ShopDBContext dBContext=new ShopDBContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            productServices = new ProductServices();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ShowAll()
        {
            List<Product> products = productServices.GetAll();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product, IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", imageFile.FileName);
                var stream = new FileStream(path, FileMode.Create);
                imageFile.CopyTo(stream);
                product.MoTa = imageFile.FileName;
            }
            if (productServices.Create(product))
            {
                return RedirectToAction("ShowAll");
            }
            else return BadRequest();
        }
        public IActionResult Cart(Guid id)
        {
            var product = productServices.GetById(id);
            var sp = SessionServices.GetObjFromSession(HttpContext.Session, "Cart");
            if (sp.Count == 0)
            {
                if (product.SoLuongTon == 0)
                {
                    ModelState.AddModelError("", "hết hàng");
                    return RedirectToAction("ShowAll");
                }
                product.SoLuongTon = 1;
                sp.Add(product);
                SessionServices.SetObjToSession(HttpContext.Session, "Cart", sp);
            }
            else
            {
                if (SessionServices.CheckObjInList(id, sp))
                {
                    foreach (var item in sp)
                    {
                        if (item.Id == id)
                        {
                            item.SoLuongTon++ ;
                            if (item.SoLuongTon > product.SoLuongTon)
                            {
                                item.SoLuongTon--;
                                ModelState.AddModelError("", "số lượng quá giới hạn");
                            }
                            product.SoLuongTon--;
                            break;
                        }
                    }
                    SessionServices.SetObjToSession(HttpContext.Session, "Cart", sp);
                }
                else
                {
                    product.SoLuongTon = 1;
                    sp.Add(product);
                    SessionServices.SetObjToSession(HttpContext.Session, "Cart", sp);
                }
            }
            return RedirectToAction("ShowAll");
        }

        public IActionResult ShowCart()
        {
            var products = SessionServices.GetObjFromSession(HttpContext.Session, "Cart");
            return View(products);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var product = productServices.GetById(id);
            return View(product);
        }
        public IActionResult Edit(Product sp)
        {
            if (productServices.Update(sp))
            {
                return RedirectToAction("ShowAll");
            }
            else return BadRequest();
        }
        public IActionResult Details(Guid id)
        {
            var products = productServices.GetById(id);
            return View(products);
        }
        public IActionResult Delete(Guid id)
        {
            if (productServices.Delete(id))
            {
                return RedirectToAction("ShowAll");
            }
            else return BadRequest();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}