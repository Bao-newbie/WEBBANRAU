namespace ASM_FINAL.Models
{
    public class Bill
    {
        public Guid Id { get; set; }
        public DateTime NgayTao { get; set; }
        public Guid ID_TK { get; set; }
        public int TrangThai { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<BillDetails> BillDetails { get; set; }
    }
}
