// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherStatistics.Server.Data;

#nullable disable

namespace WeatherStatistics.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221002221950_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("WeatherStatistics.Shared.CityWStat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AvgTemperature")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CStatus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurTemperature")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<int>("MaxTemperature")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinTemperature")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CityWStats");
                });
#pragma warning restore 612, 618
        }
    }
}
