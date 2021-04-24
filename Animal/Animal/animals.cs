using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class animals
    {

        public int num { get; set; }
        public string name { get; set; }
        public string kindOfFood { get; set; }
        public int lifeSpan { get; set; }
        public float weight { get; set; }

        public animals()
        {

        }
        public animals(int n,string na,string k,int l,float w)
        {
            this.num = n;
            this.name = na;
            this.kindOfFood = k;
            this.lifeSpan = l;
            this.weight = w;
        }
        public override string ToString()
        {
            return "num: " + num + " name: " + name + " kindOfFood: " + kindOfFood + " lifeSpan: " + lifeSpan + " weight: ";      
        }
        public void eat()
        {
            Console.WriteLine("i eat "+ kindOfFood);
        }

        public virtual double count_eat()
        {
            return this.weight * 0.04;
        }
    }
}
