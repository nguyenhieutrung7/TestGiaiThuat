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
        public static void coutPoint(PointPair x)
        {
            Console.Write("Point :a[" + x.x1 + "]" + "-a[" + x.x2 + "]  ");
        }
        public static int[] CreateRamdomArrayInteger(int n)
        {
            int[] arrayRandom = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arrayRandom[i] = random.Next(0, 100);
            }

            return arrayRandom;
        }
        public static float ExP(int x, int n)
        {
            float t = 1;
            float temp = 1;
            for (int i = 1; i <= n; i++)
            {
                temp = temp * x / i;
                t = t + temp;
            }
            return t;
        }
        public static int Factorial(int n)
        {
            int gt = 1;
            for (int i = 1; i <= n; i++)
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

        public static int[] C3_2017_2018(int[] a, int[] b)
        {
            int[] c = new int[a.Count()];
            int count = 0;
            for (int i = 0; i < a.Count(); i++)
                for (int j = 0; j < b.Count(); j++)
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
        public static int[] C3_2017_2018BienDoi(int[] a, int[] b)
        {
            int[] c = new int[a.Count()];
            int count = 0;
            Array.Sort(a);
            Array.Sort(b);
            int i = 0, j = 0;
            while (i < a.Count() && j < b.Count())
            {
                if (a[i] < b[j])
                {
                    i++;
                }
                else if (b[j] < a[i])
                {
                    j++;
                }
                else
                {
                    c[count] = a[i];
                    count++;
                    i++;
                    j++;
                }
            }
            return c;

        } 
        public static int Chapter2_1(int a,int n)
        {
            if (n == 0) return 1;
            int kq = 1;
            for(int i = 0; i < n; i++)
            {
                kq = kq * a;
            }
            return kq;
        }

        public static int Chapter2_2_a(int[] a,int x)
        {
            int kq = a[0];
            for(int i = 1; i < a.Count(); i++)
            {
                int countx = 1;
                for(int j = 1; j <= i; j++)
                {
                    countx *= x;
                }
                kq += a[i] * countx;
            }
            return kq;
        }

        public static int Chapter2_2_b(int[] a, int x)
        {
            int kq = a[0];
            int countx = 1;
            for (int i = 1; i < a.Count(); i++)
            {
                countx *= x;
                kq += a[i] * countx;
            }
            return kq;
        }

        public static PointPair Chapter2_4(int[] a, int n)
        {
            PointPair point = new PointPair();
            int min = int.MaxValue;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
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
        public static int Chapter2_4Update(int[] a, int n)
        {
            PointPair point = new PointPair();
            int min = int.MaxValue;
            int[] b = new int[n];
            Array.Copy(a, 0, b, 0, a.Count());
            Array.Sort(b);
            for (int i = 0; i < n - 1; i++)
            {
                int x = b[i] - b[i + 1];
                if (Math.Abs(x) < min)
                {
                    min = Math.Abs(x);
                    point.x1 = i;
                    point.x2 = i + 1;
                }
            }
            return min;
        }

        public static int Chapter3_1(int[] a, int l, int r)
        {
            if (l >= r)
            {
                return l;
            }
            else
            {
                int m = (l + r) / 2;
                int positionL = Chapter3_1(a, l, m);
                int positionR = Chapter3_1(a, m + 1, r);
                if (a[positionL] > a[positionR])
                    return positionL;
                else
                    return positionR;
            }

        }

        public static int Chapter3_2(int[] a, int l, int r)
        {
            if (l >= r)
            {
                return l;
            }
            else
            {
                int m = (l + r) / 2;
                int positionL = Chapter3_2(a, l, m);
                int positionR = Chapter3_2(a, m + 1, r);
                if (a[positionL] < a[positionR])
                    return positionL;
                else
                    return positionR;
            }

        }
        public static int Chapter3_3(int a, int n)
        {
            if (n == 1)
            {
                return a;
            }

            else if (n % 2 == 0)
            {
                return Chapter3_3(a, n / 2) * Chapter3_3(a, n / 2);
            }
            else
                return Chapter3_3(a, n / 2) * Chapter3_3(a, n / 2) * a;



        }
        public static int[] Chapter3_4(int[] a)
        {
            int l = 0;
            int r = a.Count() - 1;
            int[] b = new int[a.Count()];
            Array.Copy(a, 0, b, 0, a.Count() - 1);
            while (l <= r)
            {
                while (b[l] < 0 && l < r)
                {
                    l++;
                }
                while (b[r] >= 0 && r > l)
                {
                    r--;
                }
                int t = b[l];
                b[l] = b[r];
                b[r] = t;
                r--;
                l++;
            }
            return b;


        }
        public static int minC3_5(int x1,int x2,int x3)
        {
            int min = x1;
            if (x2 < min && x2 < x3)
                return x2;
            else if (x3 < min && x3 < x2)
                return x3;
            return min;
        }
        public static int Chapter3_5(int[] a,int l,int r)
        {
            if (r == l + 1)
                return Math.Abs(a[l] - a[r]);
            else
            {
                int m = (l + r) / 2;
                int d1 = Chapter3_5(a, l, m);
                int d2 = Chapter3_5(a, m + 1, r);
                return minC3_5(Math.Abs(a[m] - a[m+1]), d1, d2);
            }
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
            int[] a = CreateRamdomArrayInteger(3);
            Console.Write("Mảng ngẫu nhiên được tạo: ");
            coutArray(a);
            //Point point = new Point();
            //point = ClosestPair(a,a.Count());
            //Console.WriteLine("Vị trí cặp điểm gần nhau nhất: "+point.x1+","+point.x2);
            //int cp = ClosestPairUpdate(a,a.Count());
            //Console.WriteLine("Khoảng cách đó là: " + cp);
            //int[] b = CreateRamdomArrayInteger(15);
            //Console.Write("Mảng ngẫu nhiên được tạo: ");
            //coutArray(b);
            coutArray2(a);

            int interger1 = -4;
            int interger2 = 9;
            //coutArray2(b);
            //Console.WriteLine("Mảng giao: ");
            //int[] c = C3_2017_2018(a, b);
            //coutArray(c);
            //Console.WriteLine("Mảng giao bien doi de tri: ");
            //int[] d = C3_2017_2018BienDoi(a, b);
            //coutArray(d);
            Console.WriteLine("Chapte2/1 Voi A=" + interger1 + ", N=" + interger2 + " Ket Qua "+interger1+"^"+interger2+"=" + Chapter2_1(interger1, interger2));
            Console.Write("Chapte2/2 Ket qua phuong trinh voi mang a và x="+interger1+": "+Chapter2_2_a(a,interger1) );
            Console.WriteLine(", Ket qua phuong trinh voi mang a và x=" + interger1 + " Update: " + Chapter2_2_b(a, interger1));
            Console.WriteLine("Chapte2/4 2 cap diem ngan nhat  la: " ); coutPoint(Chapter2_4(a, a.Count()));
            Console.WriteLine("Chapte2/4_Update Khoang cach 2 cap diem ngan nhat la: "+Chapter2_4Update(a,a.Count()));

            Console.WriteLine("-------------Chuong 3-------------");
            Console.WriteLine("Chapter3/1 Diem lon nhat phan tu mang A la A[" + Chapter3_1(a, 0, a.Count() - 1) + "]");
            Console.WriteLine("Chapter3/2 Diem nho nhat phan tu mang A la A[" + Chapter3_2(a, 0, a.Count() - 1) + "]");
            Console.WriteLine("Chapter3/3 Voi A=" + interger1 + ", N=" + interger2 + " Ket Qua " + interger1 + "^" + interger2 + "=" + Chapter3_3(interger1, interger2));
            
            Console.WriteLine("Chapter3/4 Mang sau sap xep");
            
            coutArray(Chapter3_4(a));

            Console.WriteLine("Chapte3/5 Khoang cach 2 cap diem ngan nhat Chia de tri la: " + Chapter3_5(a, 0, a.Count() - 1));

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
