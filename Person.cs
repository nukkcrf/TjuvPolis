using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvPolis
{
    public class Person
    {
        public int X { get; set; }  // Position x och y 
        public int Y { get; set; }  
        public int XDirection { get; set; } //rorelse x och y
        public int YDirection { get; set; }
        public List<string> Inventory { get; set; }
        public Person(int x, int y)
        {
            X = x; Y = y;
            Random rand = new Random();

            X = rand.Next(0,100); // staden storlek 100,25
            Y = rand.Next(0,25);
            XDirection = rand.Next(-1, 2);
            YDirection = rand.Next(-1, 2);

        }

        public void Move()
        {
            // Random byta position

            X += XDirection;
            Y += YDirection;

             // Rorelse vanster ,hoger
             // upp och ner
        }
    }

}

