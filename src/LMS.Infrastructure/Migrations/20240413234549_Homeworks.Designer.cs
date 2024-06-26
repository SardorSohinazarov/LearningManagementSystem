﻿// <auto-generated />
using System;
using LMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LMS.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240413234549_Homeworks")]
    partial class Homeworks
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LMS.Domain.Entities.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("EndAt")
                        .HasColumnType("date");

                    b.Property<long>("FilialId")
                        .HasColumnType("bigint");

                    b.Property<TimeOnly>("LessonEndAt")
                        .HasColumnType("time");

                    b.Property<TimeOnly>("LessonStartAt")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SpecialityId")
                        .HasColumnType("bigint");

                    b.Property<DateOnly>("StartAt")
                        .HasColumnType("date");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FilialId");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1629),
                            EndAt = new DateOnly(2024, 4, 14),
                            FilialId = 1L,
                            LessonEndAt = new TimeOnly(4, 45, 48, 793).Add(TimeSpan.FromTicks(1667)),
                            LessonStartAt = new TimeOnly(4, 45, 48, 793).Add(TimeSpan.FromTicks(1655)),
                            Name = ".Net bootcamp",
                            SpecialityId = 1L,
                            StartAt = new DateOnly(2024, 4, 14),
                            UpdatedAt = new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1630)
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1671),
                            EndAt = new DateOnly(2024, 4, 14),
                            FilialId = 1L,
                            LessonEndAt = new TimeOnly(4, 45, 48, 793).Add(TimeSpan.FromTicks(1675)),
                            LessonStartAt = new TimeOnly(4, 45, 48, 793).Add(TimeSpan.FromTicks(1674)),
                            Name = ".Net bootcamp 1",
                            SpecialityId = 1L,
                            StartAt = new DateOnly(2024, 4, 14),
                            UpdatedAt = new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1672)
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1677),
                            EndAt = new DateOnly(2024, 4, 14),
                            FilialId = 1L,
                            LessonEndAt = new TimeOnly(4, 45, 48, 793).Add(TimeSpan.FromTicks(1680)),
                            LessonStartAt = new TimeOnly(4, 45, 48, 793).Add(TimeSpan.FromTicks(1679)),
                            Name = ".Net bootcamp 2",
                            SpecialityId = 1L,
                            StartAt = new DateOnly(2024, 4, 14),
                            UpdatedAt = new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1677)
                        });
                });

            modelBuilder.Entity("LMS.Domain.Entities.Filial", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Filials");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2024, 4, 13, 23, 45, 48, 793, DateTimeKind.Utc).AddTicks(1245),
                            Name = "Chilonzor",
                            UpdatedAt = new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1256)
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2024, 4, 13, 23, 45, 48, 793, DateTimeKind.Utc).AddTicks(1284),
                            Name = "Chimboy",
                            UpdatedAt = new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1284)
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2024, 4, 13, 23, 45, 48, 793, DateTimeKind.Utc).AddTicks(1285),
                            Name = "Farg'ona",
                            UpdatedAt = new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1286)
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2024, 4, 13, 23, 45, 48, 793, DateTimeKind.Utc).AddTicks(1287),
                            Name = "Xorazmiy",
                            UpdatedAt = new DateTime(2024, 4, 14, 4, 45, 48, 793, DateTimeKind.Local).AddTicks(1287)
                        });
                });

            modelBuilder.Entity("LMS.Domain.Entities.Homework", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<long>("LessonId")
                        .HasColumnType("bigint");

                    b.Property<long>("TeacherId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Homeworks");
                });

            modelBuilder.Entity("LMS.Domain.Entities.HomeworkFile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("HomeworkId")
                        .HasColumnType("bigint");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HomeworkId");

                    b.ToTable("HomeworkFile");
                });

            modelBuilder.Entity("LMS.Domain.Entities.Lesson", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("LMS.Domain.Entities.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("LMS.Domain.Entities.Speciality", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("LMS.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LMS.Domain.Entities.Course", b =>
                {
                    b.HasOne("LMS.Domain.Entities.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("FilialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LMS.Domain.Entities.Speciality", "Speciality")
                        .WithMany("Courses")
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filial");

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("LMS.Domain.Entities.Homework", b =>
                {
                    b.HasOne("LMS.Domain.Entities.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("LMS.Domain.Entities.HomeworkFile", b =>
                {
                    b.HasOne("LMS.Domain.Entities.Homework", null)
                        .WithMany("HomeworkFiles")
                        .HasForeignKey("HomeworkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LMS.Domain.Entities.Lesson", b =>
                {
                    b.HasOne("LMS.Domain.Entities.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("LMS.Domain.Entities.Course", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("LMS.Domain.Entities.Homework", b =>
                {
                    b.Navigation("HomeworkFiles");
                });

            modelBuilder.Entity("LMS.Domain.Entities.Speciality", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
