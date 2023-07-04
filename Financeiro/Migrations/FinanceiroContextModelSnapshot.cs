﻿// <auto-generated />
using System;
using Financeiro.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Financeiro.Migrations
{
    [DbContext(typeof(FinanceiroContext))]
    partial class FinanceiroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("Financeiro.Model.Pagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Parcelas")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusPagamento")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoPagamento")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
