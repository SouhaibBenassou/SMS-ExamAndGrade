﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastracture.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240714194057_initii")]
    partial class initii
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Exam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FiliereId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SemesterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<Guid>("SupervisorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UnitOfFormationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("YearId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("YearOfStudyId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FiliereId");

                    b.HasIndex("RoomId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("SupervisorId");

                    b.HasIndex("UnitOfFormationId");

                    b.HasIndex("YearId");

                    b.HasIndex("YearOfStudyId");

                    b.ToTable("Exams");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f9daf367-47f6-4677-9aaf-cbf09704ee43"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8908),
                            Duration = new TimeSpan(0, 0, 0, 0, 0),
                            ExamDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FiliereId = new Guid("723b06b8-cca1-4d8b-96ef-f5ce5ccb96a4"),
                            IsDeleted = false,
                            RoomId = new Guid("686c756d-9891-4047-9c18-7e198d67f2b1"),
                            SemesterId = new Guid("b8ba9a2c-1d55-4245-a3fe-0a07fbe589b9"),
                            StartTime = new TimeSpan(0, 0, 0, 0, 0),
                            SupervisorId = new Guid("1a1b8644-9b79-4062-a378-1afcbf72caf4"),
                            UnitOfFormationId = new Guid("6bf06c26-18a5-4168-bf47-ae0c2a11de88"),
                            YearId = new Guid("f591d45f-0900-4a52-ad35-874d61790720"),
                            YearOfStudyId = new Guid("ac02626c-55a6-484d-86da-4770144a76fd")
                        },
                        new
                        {
                            Id = new Guid("1aaf8797-8f33-4a0b-a4e9-7bda99104345"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8918),
                            Duration = new TimeSpan(0, 0, 0, 0, 0),
                            ExamDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FiliereId = new Guid("cac8ec54-4883-4880-bfc6-c99ebc30a44d"),
                            IsDeleted = false,
                            RoomId = new Guid("7e59257a-0ffb-451a-98a4-cc706c8abee3"),
                            SemesterId = new Guid("296ad516-265c-4853-a4e7-44c4ce099677"),
                            StartTime = new TimeSpan(0, 0, 0, 0, 0),
                            SupervisorId = new Guid("6328e90e-3d32-45f3-b391-1beaa367cef7"),
                            UnitOfFormationId = new Guid("9c6d916b-06c4-464d-b5c7-fe6339382f9d"),
                            YearId = new Guid("b8871638-912e-44f9-b03d-86705fae0b4a"),
                            YearOfStudyId = new Guid("d1f1303e-9cef-4ad2-ba20-d32bd4852774")
                        });
                });

            modelBuilder.Entity("Domain.Entities.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("686c756d-9891-4047-9c18-7e198d67f2b1"),
                            Capacity = 30,
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8866),
                            IsDeleted = false,
                            RoomName = "Room A",
                            RoomType = 1
                        },
                        new
                        {
                            Id = new Guid("7e59257a-0ffb-451a-98a4-cc706c8abee3"),
                            Capacity = 25,
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8868),
                            IsDeleted = false,
                            RoomName = "Room B",
                            RoomType = 0
                        });
                });

            modelBuilder.Entity("Domain.Entities.Semester", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SemesterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Semesters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b8ba9a2c-1d55-4245-a3fe-0a07fbe589b9"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8775),
                            IsDeleted = false,
                            SemesterName = "Fall"
                        },
                        new
                        {
                            Id = new Guid("296ad516-265c-4853-a4e7-44c4ce099677"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8778),
                            IsDeleted = false,
                            SemesterName = "Spring"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Supervisor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Supervisors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a1b8644-9b79-4062-a378-1afcbf72caf4"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8885),
                            FirstName = "John",
                            IsDeleted = false,
                            LastName = "Smith",
                            Title = "Professor"
                        },
                        new
                        {
                            Id = new Guid("6328e90e-3d32-45f3-b391-1beaa367cef7"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8888),
                            FirstName = "Emily",
                            IsDeleted = false,
                            LastName = "Johnson",
                            Title = "Associate Professor"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Year", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("YearName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Years");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f591d45f-0900-4a52-ad35-874d61790720"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8635),
                            IsDeleted = false,
                            YearName = "2024"
                        },
                        new
                        {
                            Id = new Guid("b8871638-912e-44f9-b03d-86705fae0b4a"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8638),
                            IsDeleted = false,
                            YearName = "2025"
                        });
                });

            modelBuilder.Entity("Domain.Entities.YearOfStudy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("YearsOfStudy");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ac02626c-55a6-484d-86da-4770144a76fd"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8799),
                            IsDeleted = false,
                            Year = "First Year"
                        },
                        new
                        {
                            Id = new Guid("d1f1303e-9cef-4ad2-ba20-d32bd4852774"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8800),
                            IsDeleted = false,
                            Year = "Second Year"
                        });
                });

            modelBuilder.Entity("Domain.Filiere", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FiliereName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Filieres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("723b06b8-cca1-4d8b-96ef-f5ce5ccb96a4"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8821),
                            FiliereName = "Computer Science",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("cac8ec54-4883-4880-bfc6-c99ebc30a44d"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8823),
                            FiliereName = "Mechanical Engineering",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Domain.UnitOfFormation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("UnitsOfFormation");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6bf06c26-18a5-4168-bf47-ae0c2a11de88"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8845),
                            IsDeleted = false,
                            UnitName = "Programming 101"
                        },
                        new
                        {
                            Id = new Guid("9c6d916b-06c4-464d-b5c7-fe6339382f9d"),
                            CreatedAt = new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8847),
                            IsDeleted = false,
                            UnitName = "Thermodynamics"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Exam", b =>
                {
                    b.HasOne("Domain.Filiere", "Filiere")
                        .WithMany("Exams")
                        .HasForeignKey("FiliereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Room", "Room")
                        .WithMany("Exams")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Semester", "Semester")
                        .WithMany("Exams")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Supervisor", "Supervisor")
                        .WithMany("Exams")
                        .HasForeignKey("SupervisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.UnitOfFormation", "UnitOfFormation")
                        .WithMany("Exams")
                        .HasForeignKey("UnitOfFormationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Year", "Year")
                        .WithMany("Exams")
                        .HasForeignKey("YearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.YearOfStudy", "YearOfStudy")
                        .WithMany("Exams")
                        .HasForeignKey("YearOfStudyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filiere");

                    b.Navigation("Room");

                    b.Navigation("Semester");

                    b.Navigation("Supervisor");

                    b.Navigation("UnitOfFormation");

                    b.Navigation("Year");

                    b.Navigation("YearOfStudy");
                });

            modelBuilder.Entity("Domain.Entities.Room", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("Domain.Entities.Semester", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("Domain.Entities.Supervisor", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("Domain.Entities.Year", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("Domain.Entities.YearOfStudy", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("Domain.Filiere", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("Domain.UnitOfFormation", b =>
                {
                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}