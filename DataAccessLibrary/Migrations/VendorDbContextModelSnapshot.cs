﻿// <auto-generated />
using System;
using DataAccessLibrary.DataAccessLayer.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLibrary.Migrations
{
    [DbContext(typeof(VendorDbContext))]
    partial class VendorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.ErrorLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackTrace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ErrorLogs");
                });

            modelBuilder.Entity("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendorId"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GstNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("VendorTypeId")
                        .HasColumnType("int");

                    b.HasKey("VendorId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("StateId");

                    b.HasIndex("VendorTypeId");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.VendorType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VendorTypes");
                });

            modelBuilder.Entity("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.City", b =>
                {
                    b.HasOne("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.State", b =>
                {
                    b.HasOne("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.Vendor", b =>
                {
                    b.HasOne("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");

                    b.HasOne("DataAccessLibrary.DataAccessLayer.Model.ServiceModels.VendorType", "VendorType")
                        .WithMany()
                        .HasForeignKey("VendorTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("State");

                    b.Navigation("VendorType");
                });
#pragma warning restore 612, 618
        }
    }
}
