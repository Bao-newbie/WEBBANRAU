﻿// <auto-generated />
using System;
using ASM_FINAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASM_FINAL.Migrations
{
    [DbContext(typeof(ShopDBContext))]
    [Migration("20230412104722_ShopBanRau")]
    partial class ShopBanRau
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASM_FINAL.Models.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_TK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("date");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ID_TK");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("ASM_FINAL.Models.BillDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<Guid>("Id_HD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_SP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_HD");

                    b.HasIndex("Id_SP");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("ASM_FINAL.Models.Cart", b =>
                {
                    b.Property<Guid>("Id_TK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(true)
                        .HasColumnType("nchar(1000)")
                        .IsFixedLength();

                    b.HasKey("Id_TK");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ASM_FINAL.Models.CartDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_SP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_TK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_SP");

                    b.HasIndex("Id_TK");

                    b.ToTable("CardDetails");
                });

            modelBuilder.Entity("ASM_FINAL.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<string>("LinkAnh")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(true)
                        .HasColumnType("nchar(1000)")
                        .IsFixedLength();

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength();

                    b.Property<string>("NSX")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength();

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nchar(200)")
                        .IsFixedLength();

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ASM_FINAL.Models.Role", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(true)
                        .HasColumnType("nchar(1000)")
                        .IsFixedLength();

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength();

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ASM_FINAL.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_role")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ID_role");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ASM_FINAL.Models.Bill", b =>
                {
                    b.HasOne("ASM_FINAL.Models.User", "User")
                        .WithMany("Bills")
                        .HasForeignKey("ID_TK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASM_FINAL.Models.BillDetails", b =>
                {
                    b.HasOne("ASM_FINAL.Models.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("Id_HD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HD");

                    b.HasOne("ASM_FINAL.Models.Product", "Product")
                        .WithMany("BillDetails")
                        .HasForeignKey("Id_SP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SP");

                    b.Navigation("Bill");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ASM_FINAL.Models.CartDetails", b =>
                {
                    b.HasOne("ASM_FINAL.Models.Product", "Product")
                        .WithMany("CardDetails")
                        .HasForeignKey("Id_SP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM_FINAL.Models.Cart", "Cart")
                        .WithMany("CardDetails")
                        .HasForeignKey("Id_TK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ASM_FINAL.Models.User", b =>
                {
                    b.HasOne("ASM_FINAL.Models.Role", "Roles")
                        .WithMany("Users")
                        .HasForeignKey("ID_role")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM_FINAL.Models.Cart", "Carts")
                        .WithOne("User")
                        .HasForeignKey("ASM_FINAL.Models.User", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carts");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("ASM_FINAL.Models.Bill", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("ASM_FINAL.Models.Cart", b =>
                {
                    b.Navigation("CardDetails");

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("ASM_FINAL.Models.Product", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("CardDetails");
                });

            modelBuilder.Entity("ASM_FINAL.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ASM_FINAL.Models.User", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
