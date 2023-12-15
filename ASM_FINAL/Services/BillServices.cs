using ASM_FINAL.IServices;
using ASM_FINAL.Models;

namespace ASM_FINAL.Services
{
    public class BillServices : IBillServices
    {
        ShopDBContext shopDBContext;
        public BillServices()
        {
            shopDBContext = new ShopDBContext();
        }
        public bool Create(Bill bill)
        {
            try
            {
                shopDBContext.Bills.Add(bill);
                shopDBContext.SaveChanges();
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
                dynamic bill = shopDBContext.Bills.Find(id);
                shopDBContext.Bills.Remove(bill);
                shopDBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Bill> GetAll()
        {
            return shopDBContext.Bills.ToList();
        }

        public Bill GetById(Guid id)
        {
            return shopDBContext.Bills.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(Bill bill)
        {
            try
            {
                dynamic b = shopDBContext.Bills.Find(bill.Id);
                bill.NgayTao = b.NgayTao;
                bill.TrangThai = b.TrangThai;
                shopDBContext.Bills.Update(b);
                shopDBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
