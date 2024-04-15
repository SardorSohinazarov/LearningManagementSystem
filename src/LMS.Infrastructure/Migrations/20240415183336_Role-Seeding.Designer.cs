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
    [Migration("20240415183336_Role-Seeding")]
    partial class RoleSeeding
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
                            CreatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8547),
                            EndAt = new DateOnly(2024, 4, 15),
                            FilialId = 1L,
                            LessonEndAt = new TimeOnly(23, 33, 35, 481).Add(TimeSpan.FromTicks(8563)),
                            LessonStartAt = new TimeOnly(23, 33, 35, 481).Add(TimeSpan.FromTicks(8557)),
                            Name = ".Net bootcamp",
                            SpecialityId = 1L,
                            StartAt = new DateOnly(2024, 4, 15),
                            UpdatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8547)
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8567),
                            EndAt = new DateOnly(2024, 4, 15),
                            FilialId = 1L,
                            LessonEndAt = new TimeOnly(23, 33, 35, 481).Add(TimeSpan.FromTicks(8569)),
                            LessonStartAt = new TimeOnly(23, 33, 35, 481).Add(TimeSpan.FromTicks(8569)),
                            Name = ".Net bootcamp 1",
                            SpecialityId = 1L,
                            StartAt = new DateOnly(2024, 4, 15),
                            UpdatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8567)
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8585),
                            EndAt = new DateOnly(2024, 4, 15),
                            FilialId = 1L,
                            LessonEndAt = new TimeOnly(23, 33, 35, 481).Add(TimeSpan.FromTicks(8589)),
                            LessonStartAt = new TimeOnly(23, 33, 35, 481).Add(TimeSpan.FromTicks(8588)),
                            Name = ".Net bootcamp 2",
                            SpecialityId = 1L,
                            StartAt = new DateOnly(2024, 4, 15),
                            UpdatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8586)
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
                            CreatedAt = new DateTime(2024, 4, 15, 18, 33, 35, 481, DateTimeKind.Utc).AddTicks(8328),
                            Name = "Chilonzor",
                            UpdatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8329)
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2024, 4, 15, 18, 33, 35, 481, DateTimeKind.Utc).AddTicks(8332),
                            Name = "Chimboy",
                            UpdatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8332)
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2024, 4, 15, 18, 33, 35, 481, DateTimeKind.Utc).AddTicks(8334),
                            Name = "Farg'ona",
                            UpdatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8334)
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2024, 4, 15, 18, 33, 35, 481, DateTimeKind.Utc).AddTicks(8336),
                            Name = "Xorazmiy",
                            UpdatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8336)
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

                    b.ToTable("HomeworkFiles");
                });

            modelBuilder.Entity("LMS.Domain.Entities.HomeworkStudent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("HomeworkId")
                        .HasColumnType("bigint");

                    b.Property<long>("StudentId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("HomeworkId");

                    b.HasIndex("StudentId");

                    b.ToTable("HomeworkStudents");
                });

            modelBuilder.Entity("LMS.Domain.Entities.HomeworkStudentFile", b =>
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

                    b.Property<long>("HomeworkStudentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HomeworkStudentId");

                    b.ToTable("HomeworkStudentFiles");
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

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8704),
                            Name = "Asistent",
                            UpdatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8705)
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8707),
                            Name = "Teacher",
                            UpdatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8707)
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8709),
                            Name = "Admin",
                            UpdatedAt = new DateTime(2024, 4, 15, 23, 33, 35, 481, DateTimeKind.Local).AddTicks(8709)
                        });
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

            modelBuilder.Entity("LMS.Domain.Entities.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LMS.Domain.Entities.Teacher", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("LMS.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("BirthDate")
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

                    b.HasIndex("RoleId");

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

            modelBuilder.Entity("LMS.Domain.Entities.HomeworkStudent", b =>
                {
                    b.HasOne("LMS.Domain.Entities.Homework", "Homework")
                        .WithMany()
                        .HasForeignKey("HomeworkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LMS.Domain.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Homework");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("LMS.Domain.Entities.HomeworkStudentFile", b =>
                {
                    b.HasOne("LMS.Domain.Entities.HomeworkStudent", "HomeworkStudent")
                        .WithMany("HomeworkStudentFiles")
                        .HasForeignKey("HomeworkStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HomeworkStudent");
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

            modelBuilder.Entity("LMS.Domain.Entities.Student", b =>
                {
                    b.HasOne("LMS.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LMS.Domain.Entities.Teacher", b =>
                {
                    b.HasOne("LMS.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LMS.Domain.Entities.User", b =>
                {
                    b.HasOne("LMS.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("LMS.Domain.Entities.Course", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("LMS.Domain.Entities.Homework", b =>
                {
                    b.Navigation("HomeworkFiles");
                });

            modelBuilder.Entity("LMS.Domain.Entities.HomeworkStudent", b =>
                {
                    b.Navigation("HomeworkStudentFiles");
                });

            modelBuilder.Entity("LMS.Domain.Entities.Speciality", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
