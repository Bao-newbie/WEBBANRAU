using ASM_FINAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_FINAL.Configurations
{
    public class CartConfig : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(p => p.Id_TK);
            builder.Property(p => p.MoTa).IsUnicode(true).IsFixedLength().HasMaxLength(1000);
        }
    }
}
