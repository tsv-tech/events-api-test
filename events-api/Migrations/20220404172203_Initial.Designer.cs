﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using events_api.Data;

#nullable disable

namespace events_api.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220404172203_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Cyrillic_General_CI_AS")
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EmployeeEvent", b =>
                {
                    b.Property<Guid>("EmployeesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("EventsId")
                        .HasColumnType("uuid");

                    b.HasKey("EmployeesId", "EventsId");

                    b.HasIndex("EventsId");

                    b.ToTable("EmployeeEvent");
                });

            modelBuilder.Entity("EventGroup", b =>
                {
                    b.Property<Guid>("EventsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("GroupsId")
                        .HasColumnType("uuid");

                    b.HasKey("EventsId", "GroupsId");

                    b.HasIndex("GroupsId");

                    b.ToTable("EventGroup");
                });

            modelBuilder.Entity("events_api.Data.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("PositionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("events_api.Data.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("DateEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("DateStart")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DocsLink")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhotosLink")
                        .HasColumnType("text");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("events_api.Data.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("QualificationId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("QualificationId");

                    b.HasIndex(new[] { "Name" }, "UQ_Name")
                        .IsUnique();

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("events_api.Data.Place", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("EventId")
                        .HasColumnType("uuid");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("StudentId");

                    b.ToTable("Place");
                });

            modelBuilder.Entity("events_api.Data.Position", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Name" }, "UQ_Name")
                        .IsUnique()
                        .HasDatabaseName("UQ_Name1");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("events_api.Data.Qualification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SpecialityId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SpecialityId");

                    b.HasIndex(new[] { "Name" }, "UQ_Name")
                        .IsUnique()
                        .HasDatabaseName("UQ_Name2");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("events_api.Data.Speciality", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Name" }, "UQ_Name")
                        .IsUnique()
                        .HasDatabaseName("UQ_Name3");

                    b.ToTable("Specialities");
                });

            modelBuilder.Entity("events_api.Data.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uuid");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EventStudent", b =>
                {
                    b.Property<Guid>("EventsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StudentsId")
                        .HasColumnType("uuid");

                    b.HasKey("EventsId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("EventStudent");
                });

            modelBuilder.Entity("EmployeeEvent", b =>
                {
                    b.HasOne("events_api.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("events_api.Data.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EventGroup", b =>
                {
                    b.HasOne("events_api.Data.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("events_api.Data.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("events_api.Data.Employee", b =>
                {
                    b.HasOne("events_api.Data.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("events_api.Data.Group", b =>
                {
                    b.HasOne("events_api.Data.Qualification", "Qualification")
                        .WithMany("Groups")
                        .HasForeignKey("QualificationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Qualification");
                });

            modelBuilder.Entity("events_api.Data.Place", b =>
                {
                    b.HasOne("events_api.Data.Event", "Event")
                        .WithMany("Places")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("events_api.Data.Student", "Student")
                        .WithMany("Places")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("events_api.Data.Qualification", b =>
                {
                    b.HasOne("events_api.Data.Speciality", "Speciality")
                        .WithMany("Qualifications")
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("events_api.Data.Student", b =>
                {
                    b.HasOne("events_api.Data.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("EventStudent", b =>
                {
                    b.HasOne("events_api.Data.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("events_api.Data.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("events_api.Data.Event", b =>
                {
                    b.Navigation("Places");
                });

            modelBuilder.Entity("events_api.Data.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("events_api.Data.Position", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("events_api.Data.Qualification", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("events_api.Data.Speciality", b =>
                {
                    b.Navigation("Qualifications");
                });

            modelBuilder.Entity("events_api.Data.Student", b =>
                {
                    b.Navigation("Places");
                });
#pragma warning restore 612, 618
        }
    }
}
