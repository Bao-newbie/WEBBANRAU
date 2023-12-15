using ASM_FINAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_FINAL.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Ten).IsUnicode(true).IsFixedLength().HasMaxLength(200);
            builder.Property(p => p.NSX).IsUnicode(true).IsFixedLength().HasMaxLength(100);
            builder.Property(p => p.MoTa).IsUnicode(true).IsFixedLength().HasMaxLength(100);
            builder.Property(p => p.LinkAnh).IsUnicode(true).IsFixedLength().HasMaxLength(1000);
        }
    }
}
