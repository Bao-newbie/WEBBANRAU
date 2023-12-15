using ASM_FINAL.IServices;
using ASM_FINAL.Models;

namespace ASM_FINAL.Services
{
    public class UserServices : IUserServices
    {
        public ShopDBContext dBContext;
        public UserServices()
        {
            dBContext = new ShopDBContext();
        }
        public bool Create(User user)
        {
            try
            {
                dBContext.Users.Add(user);
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
                dynamic u = dBContext.Users.Find(id);
                dBContext.Roles.Remove(u);
                dBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<User> GetAll()
        {
            return dBContext.Users.ToList();
        }

        public User GetById(Guid id)
        {
            return dBContext.Users.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(User user)
        {
            try
            {
                dynamic u = dBContext.Users.Find(user.Id);
                u.Ten = user.Ten;
                u.MatKhau = user.MatKhau;
                u.TrangThai = user.TrangThai;
                dBContext.Users.Update(u);
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
