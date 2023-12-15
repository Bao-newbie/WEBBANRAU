using ASM_FINAL.IServices;
using ASM_FINAL.Models;

namespace ASM_FINAL.Services
{
    public class BillDetailServices : IBillDetailsServices
    {
        public ShopDBContext dBContext;
        public BillDetailServices()
        {
            dBContext = new ShopDBContext();
        }
        public bool Create(BillDetails billDetails)
        {
            try
            {
                dBContext.BillDetails.Add(billDetails);
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
                dynamic bill = dBContext.BillDetails.Find(id);
                dBContext.BillDetails.Remove(bill);
                dBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<BillDetails> GetAll()
        {
            return dBContext.BillDetails.ToList();
        }

        public BillDetails GetById(Guid id)
        {
            return dBContext.BillDetails.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(BillDetails billDetails)
        {
            try
            {
                dynamic bill = dBContext.BillDetails.Find(billDetails.Id);
                bill.SoLuong = billDetails.SoLuong;
                bill.Gia = billDetails.Gia;
                dBContext.BillDetails.Update(bill);
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
