﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using STXAssignment.Data;

#nullable disable

namespace STXAssignment.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240509125429_initfinalDB")]
    partial class initfinalDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("STXAssignment.Controllers.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactId")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("STXAssignment.Controllers.Meeting", b =>
                {
                    b.Property<int>("MeetingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MeetingId"));

                    b.Property<string>("Agenda")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Participants")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("time(6)");

                    b.HasKey("MeetingId");

                    b.ToTable("Meeting");
                });

            modelBuilder.Entity("STXAssignment.Controllers.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("SupplierId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SupplierId");

                    b.ToTable("Suplier");
                });

            modelBuilder.Entity("STXAssignment.Controllers.TradeDetailsController+TradeDetails", b =>
                {
                    b.Property<string>("TradeId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ContractDetail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProductDetail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ShippingDetail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("TradeDate")
                        .HasColumnType("date");

                    b.Property<string>("TradeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TradeId");

                    b.ToTable("TradeDetails");
                });
#pragma warning restore 612, 618
        }
    }
}