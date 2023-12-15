using ASM_FINAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_FINAL.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Ten).HasColumnType("varchar(256)");
            builder.Property(p => p.MatKhau).HasColumnType("varchar(256)");
            builder.HasOne(p => p.Roles).WithMany(p => p.Users).HasForeignKey(p => p.ID_role);
            builder.Property(p => p.TrangThai).HasColumnType("int");
        }
    }
}