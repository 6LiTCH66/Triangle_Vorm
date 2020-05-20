using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Vorm
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double d;

        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
            d = 0;
        }
        public Triangle(double A, double B, double C, double D)
        {
            a = A;
            b = B;
            c = C;
            d = D;
        }
        public string outputA() 
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b); 
        }
        public string outputC() 
        {
            return Convert.ToString(c);
        }
        public double Perimeter() 
        {
            double p = 0;
            p = a + b + c; 
            return p; 
        }
        public double SemiPerimeter()
        {
            double p = 0;
            p = (a + b + c) / 2;
            return p;
        }

        public double Surface() 
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
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
        public double GetSetD
        {
            get
            { return d; }
            set
            { d = value; }
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
