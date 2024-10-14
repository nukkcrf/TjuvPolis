using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvPolis
{
    public class City
    {
            
            public List<Person> People { get; set; } 
            private int width = 100;  // Staden (100x25)
            private int height = 25;  

            public City()
            {
                People = new List<Person>();

                // Add 30 Medborgare
                for (int i = 0; i < 30; i++)
                {
                    // Random start positions
                    Random rand = new Random();
                    int x = rand.Next(0, width);
                    int y = rand.Next(0, height);
                    People.Add(new Citizen(x, y));
                }

                // Add 20 Tjuvar
                for (int i = 0; i < 20; i++)
                {
                    Random rand = new Random();
                    int x = rand.Next(0, width);
                    int y = rand.Next(0, height);
                    People.Add(new Thief(x, y));
                }

                // Add 10 Polis
                for (int i = 0; i < 10; i++)
                {
                    Random rand = new Random();
                    int x = rand.Next(0, width);
                    int y = rand.Next(0, height);
                    People.Add(new Police(x, y));
                }
            }

        public void MovePeople()
            {
                foreach (Person person in People)
                {
                    person.Move(width, height); // add rorelse..?
                }
            }

            public void DisplayCity()
            {
               
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        bool isEmpty = true;
                        foreach (Person person in People)
                        {
                            if (person.X == x && person.Y == y)
                            {
                                if (person is Citizen)
                                    Console.Write("M");  // M  for Medborgare
                                else if (person is Thief)
                                    Console.Write("T");  // T for Thief (Tjuv)
                                else if (person is Police)
                                    Console.Write("P");  // P for Police
                                isEmpty = false;
                            }
                        }
                        if (isEmpty)
                        {
                            Console.Write(" "); // tom
                        }
                    }
                    Console.WriteLine();
                }
            }
        

    }

}
    

