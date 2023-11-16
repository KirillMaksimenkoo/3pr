using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pr
{
    public class Calcul
    {

        double a = 0;
        double b = 0;
        double c = 0;

        public Calcul(double a, double b, double c) {

            this.a = a;
            this.b = b;
            this.c = c;
        
        }

        public double F1()
        {
            if (a % 2 == 0 ||b % 2 == 0 ||c % 2 == 0) return Math.Pow((a + b + c), 3);

            else return Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3);

        }

        public double F2()
        {
            double sum = 0;
            
            if (a % 2 == 0)
            {
                while (a <= b)
                {
                    sum = sum + a;
                    a += 2;
                }
            }
            else
            {
                sum = 0;
                a += 1;
                while (a <= b)
                {
                    sum = sum + a;
                    a += 2;
                }
            }
            return sum;
                 
        }


    }
}
