using ASM_FINAL.IServices;
using ASM_FINAL.Models;

namespace ASM_FINAL.Services
{
    public class CartServices : ICartServices
    {
        public ShopDBContext dBContext;
        public CartServices()
        {
            dBContext = new ShopDBContext();
        }
        public bool Create(Cart cart)
        {
            try
            {
                dBContext.Carts.Add(cart);
                dBContext.SaveChanges();
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
                dynamic cart = dBContext.Carts.Find(id);
                dBContext.Remove(cart);
                dBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Cart> GetAll()
        {
            return dBContext.Carts.ToList();
        }

        public Cart GetById(Guid id)
        {
            return dBContext.Carts.FirstOrDefault(p => p.Id_TK == id);
        }

        public bool Update(Cart cart)
        {
            try
            {
                dynamic c = dBContext.Carts.Find(cart.Id_TK);
                c.MoTa = cart.MoTa;
                dBContext.Update(c);
                dBContext.SaveChanges(c);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
