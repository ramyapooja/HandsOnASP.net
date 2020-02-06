﻿// <auto-generated />
using EMARTPROJECT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMARTPROJECT.Migrations
{
    [DbContext(typeof(SellerContext))]
    [Migration("20200201085950_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMARTPROJECT.Models.Seller", b =>
                {
                    b.Property<int>("s_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GSTIN")
                        .HasColumnType("int");

                    b.Property<string>("photopath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s_email_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s_pwd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s_username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("sbank_accno")
                        .HasColumnType("bigint");

                    b.HasKey("s_id");

                    b.ToTable("Sellers");
                });
#pragma warning restore 612, 618
        }
    }
}
