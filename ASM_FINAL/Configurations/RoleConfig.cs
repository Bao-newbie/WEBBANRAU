using ASM_FINAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_FINAL.Configurations
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(p => p.MoTa).IsUnicode(true).IsFixedLength().HasMaxLength(1000);
            builder.Property(p => p.Ten).IsUnicode(true).IsFixedLength().HasMaxLength(100);
            builder.Property(p => p.TrangThai).HasColumnType("int");
        }
    }
}