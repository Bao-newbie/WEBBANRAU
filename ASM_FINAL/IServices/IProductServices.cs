using ASM_FINAL.Models;

namespace ASM_FINAL.IServices
{
    public interface IProductServices
    {
        public bool Create(Product p);
        public bool Update(Product p);
        public bool Delete(Guid id);
        public List<Product> GetAll();
        public Product GetById(Guid id);
    }
}
