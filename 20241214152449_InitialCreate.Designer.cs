
using CodeFirstBasic.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Reflection.Emit;

#nullable disable

namespace CodeFirstBasic.Migrations
{
    [DbContext(typeof(PatikaFirstDbContext))]
    [Migration("20241214152449_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("CodeFirstBasic.Models.Game", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Platform")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<decimal>("Rating")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Games");
            });

            modelBuilder.Entity("CodeFirstBasic.Models.Movie", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Genre")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<int>("ReleaseYear")
                    .HasColumnType("INTEGER");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Movies");
            });
#pragma warning restore 612, 618
        }
    }
}