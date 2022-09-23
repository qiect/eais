﻿// <auto-generated />
using System;
using URLBox.EntityFrameworkCore.DbMigrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace URLBox.EntityFrameworkCore.DbMigrations.Migrations
{
    [DbContext(typeof(URLBoxDbMigrationsDbContext))]
    [Migration("20220629104449_ModifyTable")]
    partial class ModifyTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.MySql)
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("URLBox.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Des")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Icon")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Tags")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Articles", (string)null);
                });

            modelBuilder.Entity("URLBox.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tags", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
