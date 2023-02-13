﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainnePortal.Models.User;

#nullable disable

namespace TrainnePortal.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230202110954_Mainbatch")]
    partial class Mainbatch
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrainnePortal.Models.User.BatchList", b =>
                {
                    b.Property<int>("S_NO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("S_NO"));

                    b.Property<int>("BatchId")
                        .HasColumnType("int");

                    b.Property<string>("Batchname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCheck")
                        .HasColumnType("bit");

                    b.HasKey("S_NO");

                    b.ToTable("BatchList");
                });

            modelBuilder.Entity("TrainnePortal.Models.User.BatchModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<int>("batchId")
                        .HasColumnType("int");

                    b.Property<string>("batchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("course")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BatchDetails");
                });

            modelBuilder.Entity("TrainnePortal.Models.User.OverView", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Course1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.ToTable("OverView");
                });

            modelBuilder.Entity("TrainnePortal.Models.User.Registration", b =>
                {
                    b.Property<int>("EmployeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DOJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsChecked")
                        .HasColumnType("bit");

                    b.Property<string>("birthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("college")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("father_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobile_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passOutYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pincode")
                        .HasColumnType("int");

                    b.HasKey("EmployeId");

                    b.ToTable("TrainneDetails");
                });
#pragma warning restore 612, 618
        }
    }
}