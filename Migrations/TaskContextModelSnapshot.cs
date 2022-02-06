﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6.Models;

namespace Mission6.Migrations
{
    [DbContext(typeof(TaskContext))]
    partial class TaskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission6.Models.TaskForm", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Important")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TaskName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Urgent")
                        .HasColumnType("INTEGER");

                    b.HasKey("TaskID");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            TaskID = 1,
                            Category = "Church",
                            Completed = false,
                            DueDate = new DateTime(2022, 2, 5, 17, 1, 33, 860, DateTimeKind.Local).AddTicks(4202),
                            Important = false,
                            TaskName = "Read Scriptures",
                            Urgent = true
                        },
                        new
                        {
                            TaskID = 2,
                            Category = "School",
                            Completed = false,
                            DueDate = new DateTime(2022, 2, 5, 17, 1, 33, 871, DateTimeKind.Local).AddTicks(1207),
                            Important = true,
                            TaskName = "404 Homework",
                            Urgent = false
                        },
                        new
                        {
                            TaskID = 3,
                            Category = "Home",
                            Completed = false,
                            DueDate = new DateTime(2022, 2, 5, 17, 1, 33, 871, DateTimeKind.Local).AddTicks(1294),
                            Important = false,
                            TaskName = "Clean Dishes",
                            Urgent = false
                        },
                        new
                        {
                            TaskID = 4,
                            Category = "Work",
                            Completed = false,
                            DueDate = new DateTime(2022, 2, 5, 17, 1, 33, 871, DateTimeKind.Local).AddTicks(1301),
                            Important = true,
                            TaskName = "Submit Time Correction",
                            Urgent = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
