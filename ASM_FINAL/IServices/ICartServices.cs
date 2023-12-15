using ASM_FINAL.Models;

namespace ASM_FINAL.IServices
{
    public interface ICartServices
    {
        public bool Create(Cart cart);
        public bool Update(Cart cart);
        public bool Delete(Guid id);
        public List<Cart> GetAll();
        public Cart GetById(Guid id);
    }
}
