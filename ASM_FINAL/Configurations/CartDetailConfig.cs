using ASM_FINAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_FINAL.Configurations
{
    public class CartDetailConfig : IEntityTypeConfiguration<CartDetails>
    {
        public void Configure(EntityTypeBuilder<CartDetails> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(p => p.Cart).WithMany(p => p.CardDetails).HasForeignKey(p => p.Id_TK);
            builder.HasOne(p => p.Product).WithMany(p => p.CardDetails).HasForeignKey(p => p.Id_SP);
        }
    }
}
