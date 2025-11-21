//1
//using System;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a=12, b=131;
//            float c = (a + b) / 2f;
//            Console.WriteLine("a,b tveri mijin tvabanakany: " + c);
//        }
//    }
//    }

//2
//using System;
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            float x = 2.5f;
//            float y = -6 * x + 8;
//            Console.WriteLine("y = " + y);
//        }
//    }
//}

//3
//using System;
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int x = 9;
//            double y = 2 * Math.Pow(x, 2) - x + 4;
//            Console.WriteLine("y = " + y);

//        }
//    }
//}

//4
//using System;
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double f = 74.5;
//            double c = (f - 32) * 5 / 9;
//            Console.WriteLine(c + "°C");

//        }
//    }
//}

//5
//using System;
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 60;
//            double radian = a * Math.PI / 180;
//            double y = 2 * Math.Sin(radian);
//            Console.WriteLine("y = " + y);
//        }
//    }
//}

//6
//using System;
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int sum = 0;
//            for (int i = 1; i <= 100; i++)
//            {
//                sum += i;
//            }
//            double P = (double)sum / 100;
//            Console.WriteLine("P = " + P);
//        }
//    }
//}

//7
//using System;
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int count = 0;
//            for(int i = 1; i <= 100; i++)
//            {
//                if(i%2 != 0)
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine("count " + count);
//        }
//    }
//}

//8
//using System;
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double y = function(9, 2);
//            Console.WriteLine("y = " + y);
//        }

//        static double function(int x, int a)
//        {
//            return a * Math.Pow(x, 3) + Math.Pow(x, 1.0 / a);
//        }

//    }
//}

//9
//using System;
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int result = factorial(5); 
//            Console.WriteLine(result);
//        }

//       static int factorial(int n)
//        {
//            int f = 1;
//            for(int i = n; i > 0; i--)
//            {
//                f *= i; 
//            }
//            return f;
//        }

//    }
//}

//10
//using System;
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int result = fibonacci(6);
//            Console.WriteLine(result);
//        }

//        static int fibonacci(int n)
//        {
//            int f = 0;
//            if (n == 1)
//            {
//                return 0;
//            }
//            else if (n == 2)
//            {
//                return 1;
//            }
//            else
//            {
//                int a = 0, b = 1;
//                for (int i = 3; i <= n; i++)
//                {
//                    f = a + b;
//                    a = b;
//                    b = f;
//                }
//                return f;
//            }
//        }


//    }
//}

//11
//using System;
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool resutl = Prime(37);
//            Console.WriteLine(resutl);
//        }

//        static bool Prime(int n)
//        {
//            if (n <= 1)
//            {
//                return false;
//            }
//            else if (n == 2)
//            {
//                return true;
//            }

//            else {

//                for (int i = 2; i < n; i++)
//                {
//                    if (n % i == 0)
//                    {
//                        return false;
//                    }
//                }

//                return true;
//            }



//        }
//    }
//}

//12
//using System;
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int result = sum(56294032);
//            Console.WriteLine(result);
//        }

//        static int sum(int n)
//        {
//            int sum = 0;

//                while (n > 0)
//                {
//                    sum += n % 10;
//                    n /= 10;
//                }

//                return sum;
//            }



//        }
//}

//*
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = Increase(13456);
            Console.WriteLine(result);
        }


        static bool Increase(int n)
        {
            if (n < 10 && n >= 0)
            {
                return true;
            }
            else
            {
                int b = n % 10; 
                n /= 10;

                while (n > 0)
                {
                    int a = n % 10;
                    if(a >= b)
                    {
                        return false;
                    }
                    b = a;
                    n/= 10;
                }
                return true;
               
                
            }
        }

    }
}



