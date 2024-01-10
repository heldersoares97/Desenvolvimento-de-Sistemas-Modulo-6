﻿// <auto-generated />
using Apicompassdois.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Apicompassdois.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Apicompassdois.Model.Compass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Compass_URL")
                        .HasColumnType("longtext")
                        .HasColumnName("compass_url");

                    b.Property<string>("Destiny")
                        .HasColumnType("longtext")
                        .HasColumnName("compass_destiny");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("compass_name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("compass_price");

                    b.HasKey("Id");

                    b.ToTable("compass");
                });
#pragma warning restore 612, 618
        }
    }
}
