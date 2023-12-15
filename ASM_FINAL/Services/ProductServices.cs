using ASM_FINAL.IServices;
using ASM_FINAL.Models;

namespace ASM_FINAL.Services
{
    public class ProductServices : IProductServices
    {
        ShopDBContext context;
        public ProductServices()
        {
            context = new ShopDBContext();
        }
        public bool Create(Product p)
        {
            try
            {
                context.Products.Add(p);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                dynamic product = context.Products.Find(id);
                context.Products.Remove(product);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Product GetById(Guid id)
        {
            return context.Products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetByName(string name)
        {
            return context.Products.Where(p => p.Ten.Contains(name)).ToList();
        }

        public bool Update(Product p)
        {
            try
            {
                dynamic product = context.Products.Find(p.Id);
                product.Ten = p.Ten;
                product.MoTa = p.MoTa;
                product.LinkAnh = p.LinkAnh;
                product.Gia = p.Gia;
                product.SoLuongTon = p.SoLuongTon;
                product.NSX = p.NSX;
                product.TrangThai = p.TrangThai;
                context.Products.Update(product);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
