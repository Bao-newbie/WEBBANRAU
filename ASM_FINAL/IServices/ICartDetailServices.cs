using ASM_FINAL.Models;

namespace ASM_FINAL.IServices
{
    public interface ICartDetailServices
    {
        public bool Create(CartDetails cartDetails);
        public bool Update(CartDetails cartDetails);
        public bool Delete(Guid id);
        public List<CartDetails> GetAll();
        public CartDetails GetById(Guid id);
    }
}
