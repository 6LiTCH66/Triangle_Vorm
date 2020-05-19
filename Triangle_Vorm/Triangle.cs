using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Vorm
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public double GetSetA 
        {
            get 
            {return a;}
            set 
            {a = value;}
        }

        public double GetSetB 
        {
            get
            {return b;}
            set
            {b = value;}
        }

        public double GetSetC 
        {
            get
            {return c;}
            set
            {c = value;}
        }

        public bool ExistTriangle 
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))
                    return false;
                else return true;
            }
        }

    }
}
