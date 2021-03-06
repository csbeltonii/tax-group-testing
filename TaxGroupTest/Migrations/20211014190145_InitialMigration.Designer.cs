// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaxGroupTest.Data;

namespace TaxGroupTest.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20211014190145_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaxGroupTest.Models.TaxGroup", b =>
                {
                    b.Property<int>("TaxGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaxGroupId");

                    b.ToTable("TaxGroups");
                });

            modelBuilder.Entity("TaxGroupTest.Models.TaxGrouping", b =>
                {
                    b.Property<int>("TaxId")
                        .HasColumnType("int");

                    b.Property<int>("TaxGroupId")
                        .HasColumnType("int");

                    b.HasKey("TaxId", "TaxGroupId");

                    b.HasIndex("TaxGroupId");

                    b.ToTable("TaxGroupings");
                });

            modelBuilder.Entity("TaxGroupTest.Models.TaxRate", b =>
                {
                    b.Property<int>("TaxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TaxMinimum")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TaxId");

                    b.ToTable("TaxRates");
                });

            modelBuilder.Entity("TaxGroupTest.Models.TaxGrouping", b =>
                {
                    b.HasOne("TaxGroupTest.Models.TaxGroup", "TaxGroup")
                        .WithMany("Rates")
                        .HasForeignKey("TaxGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaxGroupTest.Models.TaxRate", "TaxRate")
                        .WithMany("Groups")
                        .HasForeignKey("TaxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaxGroup");

                    b.Navigation("TaxRate");
                });

            modelBuilder.Entity("TaxGroupTest.Models.TaxGroup", b =>
                {
                    b.Navigation("Rates");
                });

            modelBuilder.Entity("TaxGroupTest.Models.TaxRate", b =>
                {
                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
