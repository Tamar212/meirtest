using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
   public enum depth
    {
        shallow, medium, deep
    };
    class aquatic_animals:animals
    {

        public depth a { get; set; }

        public aquatic_animals():base()
        {

        }
        public aquatic_animals(int n, string na, string k, int l, float w, depth a1) :base(n, na, k, l, w)
        {
            this.a = a1;
        }
        public override double count_eat()
        {
            double temp = base.count_eat();
            double temp1 =temp* (int)a / 10;
            return temp - temp1;

        }
        public override string ToString()
        {
            return base.ToString()+" a: "+a;
        }
    }
}
