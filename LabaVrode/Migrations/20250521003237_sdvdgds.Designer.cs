﻿// <auto-generated />
using System;
using LabaVrode.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabaVrode.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250521003237_sdvdgds")]
    partial class sdvdgds
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("LabaVrode.Data.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ключ");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("название");

                    b.HasKey("Id");

                    b.ToTable("группы");
                });

            modelBuilder.Entity("LabaVrode.Data.Marks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ключ");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ключ_студента");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ключ_предмета");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER")
                        .HasColumnName("балл");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("оценки");
                });

            modelBuilder.Entity("LabaVrode.Data.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ключ");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("TEXT")
                        .HasColumnName("дата_рождения");

                    b.Property<int?>("GroupId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ключ_группы");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT")
                        .HasColumnName("отчество");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("имя");

                    b.Property<string>("Surename")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("фамилия");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("студенты");
                });

            modelBuilder.Entity("LabaVrode.Data.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ключ");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("название");

                    b.HasKey("Id");

                    b.ToTable("предметы");
                });

            modelBuilder.Entity("LabaVrode.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Ключ");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Имя_пользователя");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Пароль");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Является_Администратором");

                    b.HasKey("Id");

                    b.ToTable("Пользователи");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "admin",
                            Password = "123",
                            isAdmin = true
                        },
                        new
                        {
                            Id = 2,
                            Login = "user1",
                            Password = "321",
                            isAdmin = false
                        });
                });

            modelBuilder.Entity("LabaVrode.Data.Marks", b =>
                {
                    b.HasOne("LabaVrode.Data.Student", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabaVrode.Data.Subject", "Subject")
                        .WithMany("Marks")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("LabaVrode.Data.Student", b =>
                {
                    b.HasOne("LabaVrode.Data.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("LabaVrode.Data.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("LabaVrode.Data.Student", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("LabaVrode.Data.Subject", b =>
                {
                    b.Navigation("Marks");
                });
#pragma warning restore 612, 618
        }
    }
}
