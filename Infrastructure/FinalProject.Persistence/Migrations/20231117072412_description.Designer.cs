﻿// <auto-generated />
using System;
using FinalProject.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Persistence.Migrations
{
    [DbContext(typeof(FinalProjectDbContext))]
    [Migration("20231117072412_description")]
    partial class description
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalProject.Domain.Entities.General.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 11, 17, 11, 24, 12, 129, DateTimeKind.Local).AddTicks(2250));

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MaxAge")
                        .HasColumnType("int");

                    b.Property<int>("MinAge")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Groups", (string)null);
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.General.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 11, 17, 11, 24, 12, 128, DateTimeKind.Local).AddTicks(7747));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsView")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("Messages", (string)null);
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.General.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AboutFullImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTittle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 11, 17, 11, 24, 12, 129, DateTimeKind.Local).AddTicks(182));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoImageFullPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlideBigText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlideImageFullPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlideImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlideSmallText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tittle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhyUsFullImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhyUsFullImagePath1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhyUsFullImagePath2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhyUsImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhyUsImagePath1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhyUsImagePath2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhyUsText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhyUsText1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhyUsText2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhyUsTittle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhyUsTittle1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhyUsTittle2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Youtube")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings", (string)null);
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.General.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 11, 17, 11, 24, 12, 130, DateTimeKind.Local).AddTicks(3322));

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("ImagaFullPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagaPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.General.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 11, 17, 11, 24, 12, 130, DateTimeKind.Local).AddTicks(6104));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("ImagaFullPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagaPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers", (string)null);
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.Identity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 11, 17, 11, 24, 12, 129, DateTimeKind.Local).AddTicks(5194));

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 11, 17, 11, 24, 12, 129, DateTimeKind.Local).AddTicks(7981));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HashPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.Identity.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 11, 17, 11, 24, 12, 130, DateTimeKind.Local).AddTicks(1085));

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.General.Group", b =>
                {
                    b.HasOne("FinalProject.Domain.Entities.General.Teacher", "Teacher")
                        .WithMany("Groups")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.General.Student", b =>
                {
                    b.HasOne("FinalProject.Domain.Entities.General.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.Identity.UserRole", b =>
                {
                    b.HasOne("FinalProject.Domain.Entities.Identity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Domain.Entities.Identity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.General.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.General.Teacher", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.Identity.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("FinalProject.Domain.Entities.Identity.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
