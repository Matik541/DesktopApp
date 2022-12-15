using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsExam
{
    public class ToDoObject
    {
        public string name { get; set; } = "";
        public bool isDone { get; set; } = false;
        public string date { get; set; } = "";

        public ToDoObject(string name, bool isDone, string date)
        {
            this.name = name;
            this.isDone = isDone;
            this.date = date;
        }
    }
}
