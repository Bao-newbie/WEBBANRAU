using ASM_FINAL.IServices;
using ASM_FINAL.Models;

namespace ASM_FINAL.Services
{
    public class RoleServices : IRoleServices
    {
        public ShopDBContext dBContext;
        public RoleServices()
        {
            dBContext = new ShopDBContext();
        }
        public bool Create(Role role)
        {
            try
            {
                dBContext.Roles.Add(role);
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
                dynamic r = dBContext.Roles.Find(id);
                dBContext.Roles.Remove(r);
                dBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Role> GetAll()
        {
            return dBContext.Roles.ToList();
        }

        public Role GetById(Guid id)
        {
            return dBContext.Roles.FirstOrDefault(p => p.ID == id);
        }

        public bool Update(Role role)
        {
            try
            {
                dynamic r = dBContext.Roles.Find(role.ID);
                r.Ten = role.Ten;
                r.MoTa = role.MoTa;
                r.TrangThai = role.TrangThai;
                dBContext.Roles.Update(r);
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
