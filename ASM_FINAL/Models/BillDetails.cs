namespace ASM_FINAL.Models
{
    public class BillDetails
    {
        public Guid Id { get; set; }
        public Guid Id_SP { get; set; }
        public Guid Id_HD { get; set; }
        public int SoLuong { get; set; }
        public int Gia { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
    }
}
