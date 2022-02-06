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

        public DbSet<TaskForm> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TaskForm>().HasData(

                new TaskForm
                {
                    TaskID = 1,
                    TaskName = "Read Scriptures",
                    DueDate = DateTime.Now,
                    Urgent = true,
                    Important = false,
                    Category = "Church",
                    Completed = false
                },

                new TaskForm
                {
                    TaskID = 2,
                    TaskName = "404 Homework",
                    DueDate = DateTime.Now,
                    Urgent = false,
                    Important = true,
                    Category = "School",
                    Completed = false
                },

                new TaskForm
                {
                    TaskID = 3,
                    TaskName = "Clean Dishes",
                    DueDate = DateTime.Now,
                    Urgent = false,
                    Important = false,
                    Category = "Home",
                    Completed = false
                },

                new TaskForm
                {
                    TaskID = 4,
                    TaskName = "Submit Time Correction",
                    DueDate = DateTime.Now,
                    Urgent = true,
                    Important = true,
                    Category = "Work",
                    Completed = false
                }
                );
        }

    }
}
