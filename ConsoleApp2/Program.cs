using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{ 
    internal class Program
    {
    public static int sum(int a, int b)
    {
            //Console.WriteLine(a +" "+b);
        return a + b;
    }
    public static int division(int a, int b)
    {

            return a / b;

    
    }
        public static int[] swap(int a,int b)
        {
            a = a+b;
            b = a-b;
            a = a - b;

            int[] arr = { a, b };
            return arr;
        }

        public static void multiplication(int a)
        {
            for(int i = 0;i<= a; i++)
            {
                int mul = a * i;
                Console.WriteLine("{0} * {1} = {2}",a,i,mul);
            }
        }
        public static double avg(int a,int b,int c,int d)
        {
            double A = a + b + c + d;
            A /= 4;
            return A;
        }
        public static void specialMethod(int x,int y,int z)
        {
            int res1 = (x + y)*z;int res2 = x * y + y * z;
            Console.WriteLine("(x+y).z is {0} x.y+y.z is {1}",res1,res2);
        }
    static void Main(string[] args)
        {
            Console.WriteLine("Your Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("key in two values");
            int sum1 =Int32.Parse(Console.ReadLine());int sum2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sum: "+sum(sum1,sum2));
            Console.WriteLine("key in two values");
            int div1 = Convert.ToInt32(Console.ReadLine()); int div2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Division: " + division(div1, div2));
            Console.WriteLine("key in two values for swapping");
            int swap1 = Convert.ToInt32(Console.ReadLine()); int swap2 = Convert.ToInt32(Console.ReadLine());
            int[] arr = swap(swap1, swap2);
            Console.WriteLine("swapped: " + arr[0] + " " + arr[1]);
            Console.WriteLine("Multiplication Table");
            Console.WriteLine("key in a value");
            int M = Convert.ToInt32(Console.ReadLine());
            multiplication(M);
            Console.WriteLine("key in four values for average");
            int a1 = Convert.ToInt32(Console.ReadLine()); int a2 = Convert.ToInt32(Console.ReadLine()); int a3 = Convert.ToInt32(Console.ReadLine());int a4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Average:{0:00.00}",avg(a1, a2, a3, a4));
            Console.WriteLine("key in four values for special Operations");
            int t1 = Convert.ToInt32(Console.ReadLine()); int t2 = Convert.ToInt32(Console.ReadLine()); int t3 = Convert.ToInt32(Console.ReadLine()); 
            specialMethod(t1, t2, t3);

            Console.ReadKey();
        }
    }
}
