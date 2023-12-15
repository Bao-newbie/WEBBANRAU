namespace ASM_FINAL.Models
{
    public class Role
    {
        public Guid ID { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
