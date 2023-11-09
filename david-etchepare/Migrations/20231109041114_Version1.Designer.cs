﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using david_etchepare.DataAccess;

#nullable disable

namespace david_etchepare.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20231109041114_Version1")]
    partial class Version1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("david_etchepare.Entities.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tarea_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit")
                        .HasColumnName("tarea_isCompleted");

                    b.Property<string>("TareaDescription")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("tarea_description");

                    b.Property<string>("TareaTitle")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("tarea_title");

                    b.HasKey("Id");

                    b.ToTable("Tareas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsCompleted = false,
                            TareaDescription = "Detalles de Tarea1",
                            TareaTitle = "Tarea1"
                        },
                        new
                        {
                            Id = 2,
                            IsCompleted = false,
                            TareaDescription = "Detalles de Tarea2",
                            TareaTitle = "Tarea2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
