using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class TaskForm
    {
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }   /*Not sure if datetime is the way to go, if it doesn't work please change*/
        public int Quadrant { get; set; }
        public string Category { get; set; }
        public bool Completed { get; set; }

    }
}
