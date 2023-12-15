namespace ASM_FINAL.Models
{
    public class Cart
    {
        public Guid Id_TK { get; set; }
        public string MoTa { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CartDetails> CardDetails { get; set; }
    }
}
