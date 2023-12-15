using ASM_FINAL.Models;

namespace ASM_FINAL.IServices
{
    public interface IRoleServices
    {
        public bool Create(Role role);
        public bool Delete(Guid id);
        public bool Update(Role role);
        public Role GetById(Guid id);
        public List<Role> GetAll();
    }
}
