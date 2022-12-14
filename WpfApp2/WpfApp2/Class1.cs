using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Class1
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Category { get; set; } = "";
        public int Score { get; set; }
        public bool Watched { get; set; }

        public Class1(string name, string description, string category, int score)
        {
            Name = name;
            Description = description;
            Category = category;
            Score = score;
            Watched = false;
        }
    }
}
