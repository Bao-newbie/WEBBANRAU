using ASM_FINAL.Models;

namespace ASM_FINAL.IServices
{
    public interface IUserServices
    {
        public bool Create(User user);
        public bool Update(User user);
        public bool Delete(Guid id);
        public User GetById(Guid id);
        public List<User> GetAll();
    }
}
