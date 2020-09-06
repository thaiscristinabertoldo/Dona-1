﻿// <auto-generated />
using Dona.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dona.Migrations
{
    [DbContext(typeof(SQLiteDBContext))]
    [Migration("20200906022437_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("Dona.Models.Usuaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Profissao")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.ToTable("Usuarias");
                });
#pragma warning restore 612, 618
        }
    }
}