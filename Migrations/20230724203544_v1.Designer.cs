﻿// <auto-generated />
using System;
using EmployeeManagementAPI.EmployeeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagementAPI.Migrations
{
    [DbContext(typeof(EmployeeDataContext))]
    [Migration("20230724203544_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManagementAPI.Models.Address", b =>
                {
                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("Surbub")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Street");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("EmployeeManagementAPI.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressStreet")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AddressStreet");

                    b.ToTable("EmployeeTable");
                });

            modelBuilder.Entity("EmployeeManagementAPI.Models.Employee", b =>
                {
                    b.HasOne("EmployeeManagementAPI.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressStreet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
