﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2dfrango.infra.repository.Context;

namespace _2dfrango.infra.repository.Migrations
{
    [DbContext(typeof(_2dFrangoContext))]
    partial class _2dFrangoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_2dfrango.domain.Models.Autenticacao", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("Autenticacao");
                });

            modelBuilder.Entity("_2dfrango.domain.Models.Pontuacao", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Diamantes")
                        .HasColumnType("int");

                    b.Property<int>("Moedas")
                        .HasColumnType("int");

                    b.HasKey("Email");

                    b.ToTable("Pontuacao");
                });

            modelBuilder.Entity("_2dfrango.domain.Models.Autenticacao", b =>
                {
                    b.HasOne("_2dfrango.domain.Models.Pontuacao", "Pontuacao")
                        .WithOne("Autenticacao")
                        .HasForeignKey("_2dfrango.domain.Models.Autenticacao", "Email")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
