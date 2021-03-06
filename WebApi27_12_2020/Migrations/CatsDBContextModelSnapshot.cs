﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi27_12_2020.Data;

namespace WebApi27_12_2020.Migrations
{
    [DbContext(typeof(CatsDBContext))]
    partial class CatsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi27_12_2020.Model.Cat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<int>("Color");

                    b.Property<int>("Gender");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Photo");

                    b.HasKey("ID");

                    b.ToTable("Cats");

                    b.HasData(
                        new { ID = 1, Age = 5, Color = 0, Gender = 0, Name = "Tom" },
                        new { ID = 2, Age = 24, Color = 3, Gender = 0, Name = "Barsik" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
