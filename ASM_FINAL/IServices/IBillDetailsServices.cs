using ASM_FINAL.Models;

namespace ASM_FINAL.IServices
{
    public interface IBillDetailsServices
    {
        public bool Create(BillDetails billDetails);
        public bool Update(BillDetails billDetails);
        public bool Delete(Guid id);
        public List<BillDetails> GetAll();
        public BillDetails GetById(Guid id);
    }
}
