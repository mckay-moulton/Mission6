using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class TaskForm
    {
        // Relationship and table for Tasks
        [Key]
        [Required]
        public int TaskID {get;set;}
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }  
        public bool Urgent { get; set; }
        public bool Important { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public bool Completed { get; set; }

    }
}
