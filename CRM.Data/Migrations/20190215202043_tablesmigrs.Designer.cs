﻿// <auto-generated />
using System;
using CRM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRM.Data.Migrations
{
    [DbContext(typeof(dbContextCRM))]
    [Migration("20190215202043_tablesmigrs")]
    partial class tablesmigrs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRM.Core.Domain.Addons.Addon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("AddonImage");

                    b.Property<string>("AddonName");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<decimal>("Price");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("Addons");
                });

            modelBuilder.Entity("CRM.Core.Domain.Customers.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Landmark");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CRM.Core.Domain.Gallerys.Gallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AltText");

                    b.Property<bool>("Deleted");

                    b.Property<byte[]>("GalleryImage");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("Gallerys");
                });

            modelBuilder.Entity("CRM.Core.Domain.Options.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted");

                    b.Property<string>("OptionName");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("CRM.Core.Domain.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddonId");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<decimal>("ProductCost");

                    b.Property<string>("ProductName");

                    b.Property<string>("ProductType");

                    b.Property<int>("ProductTypeId");

                    b.Property<byte[]>("ProductTypeImage");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("CRM.Core.Domain.ProductTypes.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<byte[]>("ProductTypeImage");

                    b.Property<string>("ProductTypeName");

                    b.Property<string>("PunchLine");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("CRM.Core.Domain.Products.Product", b =>
                {
                    b.HasOne("CRM.Core.Domain.ProductTypes.ProductType", "producttype")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
