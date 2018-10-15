using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTichVaThietKeGiaiThuat
{
    class Program
    {
        public static float ExP(int x, int n)
        {
            float t = 1;
            float temp = 1;
            for (int i = 1; i <= n; i++)
            {
                temp = temp *x/ i;
                t = t + temp;
            }
            return t;
        }
        public static int GiaiThua(int n)
        {
            int gt = 1;
            for(int i = 1; i <= n; i++)
            {
                gt *= i;
            }
            return gt;
        }
        public static int DeQuiGiaiThua(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else return n * DeQuiGiaiThua(n - 1);
        }
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            float exp = ExP(4,5);
            Console.WriteLine(exp);
            Console.WriteLine("Giai thua:" + GiaiThua(5));
            Console.WriteLine("Giai thua de qui:"+DeQuiGiaiThua(1));
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
