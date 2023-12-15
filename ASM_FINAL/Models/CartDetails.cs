namespace ASM_FINAL.Models
{
    public class CartDetails
    {
        public Guid Id { get; set; }
        public Guid Id_TK { get; set; }
        public Guid Id_SP { get; set; }
        public int SoLuong { get; set; }
        public virtual Product Product { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
