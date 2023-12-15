namespace ASM_FINAL.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public int Gia { get; set; }
        public int SoLuongTon { get; set; }
        public int TrangThai { get; set; }
        public string NSX { get; set; }
        public string MoTa { get; set; }
        public string LinkAnh { get; set; }
        public virtual ICollection<BillDetails> BillDetails { get; set; }
        public virtual ICollection<CartDetails> CardDetails { get; set; }
    }
}
