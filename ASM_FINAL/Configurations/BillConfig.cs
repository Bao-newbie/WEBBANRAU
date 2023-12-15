using ASM_FINAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_FINAL.Configurations
{
    public class BillConfig : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.NgayTao).HasColumnType("date");
            builder.Property(p => p.TrangThai).HasColumnType("int");
            builder.HasOne(p => p.User).WithMany(p => p.Bills).HasForeignKey(p => p.ID_TK);
        }
    }
}
