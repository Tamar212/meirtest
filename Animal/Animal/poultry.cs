using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class poultry:animals,Interface1
    {
        public int high { get; set; }
        public int speed { get; set; }
        public poultry():base()
        {

        }
        public poultry(int n, string na, string k, int l, float w, int high, int speed) :base(n,na,k,l,w)
        {
            this.high = high;
            this.speed = speed;
        }

        public void fly()
        {
            Console.WriteLine("אני מממשת תעופה של : " + name);
        }
        public override string ToString()
        {
            return base.ToString()+ " high:"+ high+ " speed: "+ speed;
        }
    }
}
