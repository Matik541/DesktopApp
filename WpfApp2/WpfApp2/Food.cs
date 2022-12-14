using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    //internal class Food <- MUSI BYĆ PUBLIC!
    public class Food
    {
        public string Name { get; set; } = "";
        public int Weight { get; set; } = 0;
        public bool Vege { get; set; } = false;

        public Food(string name, int weight, bool vege)
        {
            Name = name;
            Weight = weight;
            Vege = vege;
        }
    }
}
