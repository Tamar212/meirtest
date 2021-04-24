using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "zoo";
            List<animals> listOfAnimals = new List<animals>();
            listOfAnimals.Add(new spawn(1, "aa", "a1", 67, 112, 2));
            listOfAnimals.Add(new poultry(2, "bb", "b1", 45, 200, 5, 7));
            listOfAnimals.Add(new aquatic_animals(4, "cc", "c1", 77, 99, depth.deep));
            listOfAnimals.Add(new animals(6, "dd", "d1", 89, 94));


            foreach (var x in listOfAnimals)
            {
                Console.WriteLine(x.ToString());
            }
            double count = 0;

            Console.WriteLine("enter count of food");
            count = double.Parse(Console.ReadLine());
            foreach (var x in listOfAnimals)
            {
                if (x.count_eat() > count)
                {
                    Console.WriteLine(x.name + "  eat more\n");
                }

            }
            foreach (var y in listOfAnimals)
            {
                if (y is spawn)
                {
                    spawn temp = (spawn)y;
                    if (temp.numOfWings >= 2)
                    {
                        Console.WriteLine(temp.name + " has more than 2 wings\n");
                    }
                }
            }
            List<animals> listOfAquatic_animals = new List<animals>();
            foreach (var z in listOfAnimals)
            {
                if (z is aquatic_animals)
                {
                    aquatic_animals temp = (aquatic_animals)z;
                    if (temp.a.Equals(depth.deep))
                    {
                        listOfAquatic_animals.Add(temp);
                        Console.WriteLine("listOfAquatic_animals " + temp.ToString());
                    }
                    
                }
            }
            foreach (var z in listOfAnimals)
            {
                if (z is Interface1)
                {

                    Console.WriteLine();
                    Console.WriteLine(z.name + " fly ");

                }
            }

            } 
    }
}
