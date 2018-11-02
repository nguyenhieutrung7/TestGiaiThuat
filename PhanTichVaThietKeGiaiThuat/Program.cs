using PhanTichVaThietKeGiaiThuat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTichVaThietKeGiaiThuat
{
    class Program
    {
        public static void coutArray(int[] a)
        {
            for (int i = 0; i < a.Count(); i++)
            {
                Console.Write("a[" + i + "]:" + a[i] + " ");
            }
            Console.WriteLine();
        }
        public static void coutArray2(int[] a)
        {
            for (int i = 0; i < a.Count(); i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public static int[] CreateRamdomArrayInteger(int n)
        {
            int[] arrayRandom = new int[n];
            Random random = new Random();
            for(int i = 0; i < n; i++)
            {
                arrayRandom[i] = random.Next(1, 100);
            }
            
            return arrayRandom;
        }
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
        public static int Factorial(int n)
        {
            int gt = 1;
            for(int i = 1; i <= n; i++)
            {
                gt *= i;
            }
            return gt;
        }
        public static int RecursionFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else return n * RecursionFactorial(n - 1);
        }
        public static Point ClosestPair(int[] a,int n)
        {
            Point point = new Point();
            int min = int.MaxValue;
            for(int i = 0; i < n-1; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    int x = a[i] - a[j];
                    if (Math.Abs(x) < min)
                    {
                        min = Math.Abs(x);
                        point.x1 = i;
                        point.x2 = j;
                    }
                }
            }
            return point;
        }
        public static int ClosestPairUpdate(int[] a, int n)
        {
            Point point = new Point();
            int min= int.MaxValue;
            int[] b = new int[n];
            b = a;
            Array.Sort(b);
            for(int i = 0; i < n-1; i++)
            {
                int x = a[i] - a[i+1];
                if (Math.Abs(x) < min)
                {
                    min = Math.Abs(x);
                    point.x1 = i;
                    point.x2 = i+1;
                }
            }
            return min;
        }
        public static int[] C3_2017_2018(int[] a,int[] b)
        {
            int[] c = new int[a.Count()];
            int count = 0;
            for(int i=0;i<a.Count();i++)
                for(int j = 0; j < b.Count(); j++)
                {
                    if (a[i] == b[j])
                    {
                        c[count] = a[i];
                        count++;
                        break;
                    }
                }
            return c;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //float exp = ExP(4,5);
            //Console.WriteLine(exp);
            //Console.WriteLine("Giai thua:" + Factorial(5));
            //Console.WriteLine("Giai thua de qui:"+ RecursionFactorial(1));
            int[] a = CreateRamdomArrayInteger(15);
            Console.Write("Mảng ngẫu nhiên được tạo: ");
            coutArray(a);
            //Point point = new Point();
            //point = ClosestPair(a,a.Count());
            //Console.WriteLine("Vị trí cặp điểm gần nhau nhất: "+point.x1+","+point.x2);
            //int cp = ClosestPairUpdate(a,a.Count());
            //Console.WriteLine("Khoảng cách đó là: " + cp);
            int[] b = CreateRamdomArrayInteger(15);
            Console.Write("Mảng ngẫu nhiên được tạo: ");
            coutArray(b);
            coutArray2(a);
            coutArray2(b);
            Console.WriteLine("Mảng giao: ");
            int[] c = C3_2017_2018(a, b);
            coutArray(c);
            
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
