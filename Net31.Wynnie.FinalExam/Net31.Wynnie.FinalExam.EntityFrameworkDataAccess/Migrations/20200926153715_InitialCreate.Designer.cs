﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Net31.Wynnie.FinalExam.EntityFrameworkDataAccess;

namespace Net31.Wynnie.FinalExam.EntityFrameworkDataAccess.Migrations
{
    [DbContext(typeof(SimpleShopContext))]
    [Migration("20200926153715_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Net31.Wynnie.FinalExam.Pocos.CustomerPoco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Age")
                        .HasColumnName("Age")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("TimeStamp")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("TimeStamp")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Net31.Wynnie.FinalExam.Pocos.OrderPoco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasColumnName("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsShipped")
                        .HasColumnName("IsShipped")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnName("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("TimeStamp")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("TimeStamp")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Net31.Wynnie.FinalExam.Pocos.OrderProductPoco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderID")
                        .HasColumnName("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductID")
                        .HasColumnName("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("TimeStamp")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("TimeStamp")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("Net31.Wynnie.FinalExam.Pocos.ProductPoco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnName("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SerialNumber")
                        .HasColumnName("SerialNumber")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("TimeStamp")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("TimeStamp")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Net31.Wynnie.FinalExam.Pocos.OrderPoco", b =>
                {
                    b.HasOne("Net31.Wynnie.FinalExam.Pocos.CustomerPoco", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Net31.Wynnie.FinalExam.Pocos.OrderProductPoco", b =>
                {
                    b.HasOne("Net31.Wynnie.FinalExam.Pocos.OrderPoco", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Net31.Wynnie.FinalExam.Pocos.ProductPoco", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
