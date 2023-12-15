using ASM_FINAL.Models;

namespace ASM_FINAL.IServices
{
    public interface IBillServices
    {
        public bool Create(Bill bill);
        public bool Update(Bill bill);
        public bool Delete(Guid id);
        public Bill GetById(Guid id);
        public List<Bill> GetAll();
    }
}
