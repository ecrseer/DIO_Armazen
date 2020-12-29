﻿// <auto-generated />
using DIO_Armazen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DIO_Armazen.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201228175520_addedProductQtd")]
    partial class addedProductQtd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DIO_Armazen.Models.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("qtd")
                        .HasColumnType("int");

                    b.Property<int>("utilitarioId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("utilitarioId");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("DIO_Armazen.Models.Utilitario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Utilitarios");
                });

            modelBuilder.Entity("DIO_Armazen.Models.Produto", b =>
                {
                    b.HasOne("DIO_Armazen.Models.Utilitario", "utilitario")
                        .WithMany()
                        .HasForeignKey("utilitarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("utilitario");
                });
#pragma warning restore 612, 618
        }
    }
}