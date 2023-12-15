namespace ASM_FINAL.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public int MatKhau { get; set; }
        public Guid ID_role { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual Role Roles { get; set; }
        public virtual Cart Carts { get; set; }
    }
}