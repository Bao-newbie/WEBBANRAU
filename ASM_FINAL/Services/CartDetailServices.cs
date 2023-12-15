using ASM_FINAL.IServices;
using ASM_FINAL.Models;

namespace ASM_FINAL.Services
{
    public class CartDetailServices : ICartDetailServices
    {
        public ShopDBContext dBContext;
        public CartDetailServices()
        {
            dBContext = new ShopDBContext();
        }
        public bool Create(CartDetails cartDetails)
        {
            try
            {
                dBContext.CardDetails.Add(cartDetails);
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
                dynamic card = dBContext.CardDetails.Find(id);
                dBContext.CardDetails.Remove(card);
                dBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CartDetails> GetAll()
        {
            return dBContext.CardDetails.ToList();
        }

        public CartDetails GetById(Guid id)
        {
            return dBContext.CardDetails.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(CartDetails cartDetails)
        {
            try
            {
                dynamic c = dBContext.CardDetails.Find(cartDetails.Id);
                c.SoLuong = cartDetails.SoLuong;
                dBContext.CardDetails.Update(c);
                dBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
