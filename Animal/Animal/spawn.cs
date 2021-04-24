using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class spawn:animals,Interface1
    {
        public int numOfWings { get; set; }
        public spawn():base()
        {

        }
        public spawn(int n, string na, string k, int l, float w, int numOfWings) : base(n, na, k, l, w)
        {
            this.numOfWings = numOfWings;
        }

        public void fly()
        {
            Console.WriteLine("אני מממשת תעופה של : "+this.name);
        }
        public override string ToString()
        {
            return base.ToString() + " numOfWings: " + numOfWings;
        }

    }
}
