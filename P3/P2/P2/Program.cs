using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se da o secventa de n numere. " +
                "Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
            int n = int.Parse(Console.ReadLine());
            int nrn = 0;
            int nr0 = 0;
            int nrp = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i < 0) nrn++;
                if (i == 0) nr0++;
                if (i % 2 == 0) nrp++;
            }
            Console.WriteLine("numere negative:" + " " + nrn + "," +
                               "numere egale cu zero:" + " " + nr0 + "," + 
                               "numere pare:" + " " +nrp);
            Console.ReadKey();
           

        }
    }
}
