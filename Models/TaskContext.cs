using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext>options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<TaskForm> Tasks { get; set; }

        // seed the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID=1, CategoryName = "Home"},
                new Category { CategoryID=2, CategoryName = "School"},
                new Category { CategoryID=3, CategoryName = "Work" },
                new Category { CategoryID=4, CategoryName = "Church" }
                // Home, School, Work, Church

                );


            mb.Entity<TaskForm>().HasData(

                new TaskForm
                {
                    TaskID = 1,
                    TaskName = "Read Scriptures",
                    DueDate = DateTime.Now,
                    Urgent = true,
                    Important = false,
                    CategoryID = 4,
                    Completed = false
                },

                new TaskForm
                {
                    TaskID = 2,
                    TaskName = "404 Homework",
                    DueDate = DateTime.Now,
                    Urgent = false,
                    Important = true,
                    CategoryID = 2,
                    Completed = false
                },

                new TaskForm
                {
                    TaskID = 3,
                    TaskName = "Clean Dishes",
                    DueDate = DateTime.Now,
                    Urgent = false,
                    Important = false,
                    CategoryID = 1,
                    Completed = false
                },

                new TaskForm
                {
                    TaskID = 4,
                    TaskName = "Submit Time Correction",
                    DueDate = DateTime.Now,
                    Urgent = true,
                    Important = true,
                    CategoryID = 3,
                    Completed = false
                }
                );
        }

    }
}
