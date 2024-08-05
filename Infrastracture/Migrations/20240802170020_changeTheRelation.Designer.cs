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
    [Migration("20240802170020_changeTheRelation")]
    partial class changeTheRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.AllResults", b =>
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

                    b.Property<Guid>("ExamResultId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TestResultsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ExamResultId");

                    b.HasIndex("TestResultsId");

                    b.ToTable("AllResults");
                });

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

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExamType")
                        .HasColumnType("int");

                    b.Property<Guid?>("FiliereId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StartTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SupervisorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UnitOfFormationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("YearId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("YearType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FiliereId");

                    b.HasIndex("RoomId");

                    b.HasIndex("SupervisorId");

                    b.HasIndex("UnitOfFormationId");

                    b.HasIndex("YearId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("Domain.Entities.ExamAttendance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Attendance")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ExamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StagiaireId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("StagiaireId");

                    b.ToTable("ExamAttendances");
                });

            modelBuilder.Entity("Domain.Entities.IndividualWork", b =>
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

                    b.Property<Guid>("StagiaireId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("StagiaireId");

                    b.ToTable("IndividualWorks");
                });

            modelBuilder.Entity("Domain.Entities.IndividualWorkUOF", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Confusion")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IndividualWorkId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Note")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IndividualWorkId");

                    b.ToTable("IndividualWorkUOFs");
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Supervisors");
                });

            modelBuilder.Entity("Domain.Entities.VariantsExams", b =>
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

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamCorrection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ExamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExamStatement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsValid")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NoteMax")
                        .HasColumnType("int");

                    b.Property<Guid?>("TrainerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UnitOfFormationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("VariantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VariantType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("TrainerId");

                    b.HasIndex("UnitOfFormationId");

                    b.ToTable("VariantsExams");
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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Years");
                });

            modelBuilder.Entity("Domain.ExamResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("DateValidation")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ExamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsValid")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("PracticalNote")
                        .HasColumnType("float");

                    b.Property<Guid?>("StagiaireId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("TheoreticalNote")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("StagiaireId");

                    b.ToTable("ExamResults");
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Filieres");
                });

            modelBuilder.Entity("Domain.Stagiaire", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Stagiaires");
                });

            modelBuilder.Entity("Domain.Test", b =>
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

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Note")
                        .HasColumnType("float");

                    b.Property<string>("TestCorrection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestStatement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TrainerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UnitOfFormationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TrainerId");

                    b.HasIndex("UnitOfFormationId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("Domain.TestResults", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("DateValidation")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsValid")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Note")
                        .HasColumnType("float");

                    b.Property<Guid?>("StagiaireId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("StagiaireId");

                    b.HasIndex("TestId");

                    b.ToTable("TestResults");
                });

            modelBuilder.Entity("Domain.Trainer", b =>
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Trainer");
                });

            modelBuilder.Entity("Domain.UnitOfFormation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Confusion")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FiliereId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SemesterType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FiliereId");

                    b.ToTable("UnitsOfFormation");
                });

            modelBuilder.Entity("Domain.UnitOfFormationFiliere", b =>
                {
                    b.Property<Guid>("FiliereId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UnitFormationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FiliereId", "UnitFormationId");

                    b.HasIndex("UnitFormationId");

                    b.ToTable("UnitOfFormationFilieres");
                });

            modelBuilder.Entity("Domain.AllResults", b =>
                {
                    b.HasOne("Domain.ExamResult", "ExamResult")
                        .WithMany()
                        .HasForeignKey("ExamResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.TestResults", "TestResults")
                        .WithMany()
                        .HasForeignKey("TestResultsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExamResult");

                    b.Navigation("TestResults");
                });

            modelBuilder.Entity("Domain.Entities.Exam", b =>
                {
                    b.HasOne("Domain.Filiere", null)
                        .WithMany("Exams")
                        .HasForeignKey("FiliereId");

                    b.HasOne("Domain.Entities.Room", "Room")
                        .WithMany("Exams")
                        .HasForeignKey("RoomId");

                    b.HasOne("Domain.Entities.Supervisor", "Supervisor")
                        .WithMany("Exams")
                        .HasForeignKey("SupervisorId");

                    b.HasOne("Domain.UnitOfFormation", null)
                        .WithMany("Exams")
                        .HasForeignKey("UnitOfFormationId");

                    b.HasOne("Domain.Entities.Year", null)
                        .WithMany("Exams")
                        .HasForeignKey("YearId");

                    b.Navigation("Room");

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("Domain.Entities.ExamAttendance", b =>
                {
                    b.HasOne("Domain.Entities.Exam", "Exam")
                        .WithMany("ExamAttendances")
                        .HasForeignKey("ExamId");

                    b.HasOne("Domain.Stagiaire", "Stagiaire")
                        .WithMany("ExamAttendances")
                        .HasForeignKey("StagiaireId");

                    b.Navigation("Exam");

                    b.Navigation("Stagiaire");
                });

            modelBuilder.Entity("Domain.Entities.IndividualWork", b =>
                {
                    b.HasOne("Domain.Stagiaire", "Stagiaire")
                        .WithMany("IndividualWorks")
                        .HasForeignKey("StagiaireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stagiaire");
                });

            modelBuilder.Entity("Domain.Entities.IndividualWorkUOF", b =>
                {
                    b.HasOne("Domain.Entities.IndividualWork", "IndividualWork")
                        .WithMany("individualWorkUOFs")
                        .HasForeignKey("IndividualWorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IndividualWork");
                });

            modelBuilder.Entity("Domain.Entities.VariantsExams", b =>
                {
                    b.HasOne("Domain.Entities.Exam", "Exam")
                        .WithMany("VariantsExams")
                        .HasForeignKey("ExamId");

                    b.HasOne("Domain.Trainer", "Trainer")
                        .WithMany("VariantsExams")
                        .HasForeignKey("TrainerId");

                    b.HasOne("Domain.UnitOfFormation", "UnitOfFormation")
                        .WithMany()
                        .HasForeignKey("UnitOfFormationId");

                    b.Navigation("Exam");

                    b.Navigation("Trainer");

                    b.Navigation("UnitOfFormation");
                });

            modelBuilder.Entity("Domain.ExamResult", b =>
                {
                    b.HasOne("Domain.Entities.Exam", "Exam")
                        .WithMany("ExamResults")
                        .HasForeignKey("ExamId");

                    b.HasOne("Domain.Stagiaire", "Stagiaire")
                        .WithMany("ExamResults")
                        .HasForeignKey("StagiaireId");

                    b.Navigation("Exam");

                    b.Navigation("Stagiaire");
                });

            modelBuilder.Entity("Domain.Test", b =>
                {
                    b.HasOne("Domain.Trainer", "Trainer")
                        .WithMany("Tests")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.UnitOfFormation", "UnitOfFormation")
                        .WithMany("Tests")
                        .HasForeignKey("UnitOfFormationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");

                    b.Navigation("UnitOfFormation");
                });

            modelBuilder.Entity("Domain.TestResults", b =>
                {
                    b.HasOne("Domain.Stagiaire", "Stagiaire")
                        .WithMany("TestResults")
                        .HasForeignKey("StagiaireId");

                    b.HasOne("Domain.Test", "Test")
                        .WithMany("TestResults")
                        .HasForeignKey("TestId");

                    b.Navigation("Stagiaire");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("Domain.UnitOfFormation", b =>
                {
                    b.HasOne("Domain.Filiere", "Filiere")
                        .WithMany()
                        .HasForeignKey("FiliereId");

                    b.Navigation("Filiere");
                });

            modelBuilder.Entity("Domain.UnitOfFormationFiliere", b =>
                {
                    b.HasOne("Domain.Filiere", "Filiere")
                        .WithMany("UnitOfFormationFilieres")
                        .HasForeignKey("FiliereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.UnitOfFormation", "UnitOfFormation")
                        .WithMany("UnitOfFormationFilieres")
                        .HasForeignKey("UnitFormationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filiere");

                    b.Navigation("UnitOfFormation");
                });

            modelBuilder.Entity("Domain.Entities.Exam", b =>
                {
                    b.Navigation("ExamAttendances");

                    b.Navigation("ExamResults");

                    b.Navigation("VariantsExams");
                });

            modelBuilder.Entity("Domain.Entities.IndividualWork", b =>
                {
                    b.Navigation("individualWorkUOFs");
                });

            modelBuilder.Entity("Domain.Entities.Room", b =>
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

            modelBuilder.Entity("Domain.Filiere", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("UnitOfFormationFilieres");
                });

            modelBuilder.Entity("Domain.Stagiaire", b =>
                {
                    b.Navigation("ExamAttendances");

                    b.Navigation("ExamResults");

                    b.Navigation("IndividualWorks");

                    b.Navigation("TestResults");
                });

            modelBuilder.Entity("Domain.Test", b =>
                {
                    b.Navigation("TestResults");
                });

            modelBuilder.Entity("Domain.Trainer", b =>
                {
                    b.Navigation("Tests");

                    b.Navigation("VariantsExams");
                });

            modelBuilder.Entity("Domain.UnitOfFormation", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Tests");

                    b.Navigation("UnitOfFormationFilieres");
                });
#pragma warning restore 612, 618
        }
    }
}
