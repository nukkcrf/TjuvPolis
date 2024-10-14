using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvPolis
{
    public class Citizen : Person
    {
        public Citizen(int x, int y) : base(x, y)
        {
             var Inventory = new List<string>() { "Nycklar ", "Mobiltelefon ", "Pengar ", " Klocka " };


        }
    }

    public class Thief : Person
    { 

        public Thief(int x, int y) : base(x, y)
        {
            // Tjuven borjar med toma fickor
        }
    }

    public class Police : Person
    {
        public Police(int x, int y) : base(x, y)
        {
            // Police har inte beslagit varor an..
        }
    }

}

