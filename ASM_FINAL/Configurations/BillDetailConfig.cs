using ASM_FINAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_FINAL.Configurations
{
    public class BillDetailConfig : IEntityTypeConfiguration<BillDetails>
    {
        public void Configure(EntityTypeBuilder<BillDetails> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(p => p.SoLuong).HasColumnType("int");
            builder.Property(p => p.Gia).HasColumnType("int");
            builder.HasOne(p => p.Bill).WithMany(p => p.BillDetails).HasForeignKey(p => p.Id_HD).HasConstraintName("FK_HD");
            builder.HasOne(p => p.Product).WithMany(p => p.BillDetails).HasForeignKey(p => p.Id_SP).HasConstraintName("FK_SP");
        }
    }
}
