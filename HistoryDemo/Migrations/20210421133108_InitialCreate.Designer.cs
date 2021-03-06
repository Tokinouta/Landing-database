// <auto-generated />
using System;
using HistoryDemo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HistoryDemo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210421133108_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("HistoryDemo.Entities.BasicInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("PathToData")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SimConfigurationId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SimInitializationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SimConfigurationId");

                    b.HasIndex("SimInitializationId");

                    b.ToTable("BasicInformations");
                });

            modelBuilder.Entity("HistoryDemo.Entities.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GuidanceConfig")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("HistoryDemo.Entities.Initialization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("InitialAttitudePhi")
                        .HasColumnType("REAL");

                    b.Property<double>("InitialAttitudePsi")
                        .HasColumnType("REAL");

                    b.Property<double>("InitialAttitudeTheta")
                        .HasColumnType("REAL");

                    b.Property<double>("InitialPositionX")
                        .HasColumnType("REAL");

                    b.Property<double>("InitialPositionY")
                        .HasColumnType("REAL");

                    b.Property<double>("InitialPositionZ")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Initializations");
                });

            modelBuilder.Entity("HistoryDemo.Entities.BasicInformation", b =>
                {
                    b.HasOne("HistoryDemo.Entities.Configuration", "SimConfiguration")
                        .WithMany()
                        .HasForeignKey("SimConfigurationId");

                    b.HasOne("HistoryDemo.Entities.Initialization", "SimInitialization")
                        .WithMany()
                        .HasForeignKey("SimInitializationId");

                    b.Navigation("SimConfiguration");

                    b.Navigation("SimInitialization");
                });
#pragma warning restore 612, 618
        }
    }
}
