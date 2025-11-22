//1
//using System;
//namespace ConsoleApp3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 10;
//            Random random = new Random();
//            int[] numbers = new int[n];
//            Console.WriteLine("Array of numbers");
//            for(int i = 0; i< n; i++)
//            {
//                numbers[i] = random.Next(-10,10);
//                Console.Write(numbers[i] + "\t");
//            }
//            string result = num(numbers, n);
//            Console.WriteLine("Result: " + result);
//        }

//        static string num(int[] numbers, int n)
//        {
//            string str = "";
//            for (int i = 0; i< n; i++)
//            {
//                str += numbers[i];
//                if(i!=numbers.Length-1)
//                {
//                    str += ',';
//                }
//            }
//            return str;

//        }
//    }
//}
//1(more effective)
//using System;
//using System.Text;
//namespace ConsoleApp3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 11;
//            Random random = new Random();
//            int[] numbers = new int[n];
//            Console.WriteLine("Array of numbers");
//            for(int i = 0; i < n; i++)
//            {
//                numbers[i] = random.Next(-20,20);
//                Console.WriteLine(numbers[i]);
//            }
//            string result = str(numbers, n);
//            Console.WriteLine("Result: " + result);


//        }

//        static string str(int[] numbers, int n)
//        {
//            StringBuilder sb = new StringBuilder();
//            for(int i = 0; i< n; i++)
//            {
//                sb.Append(numbers[i]);
//                if (i != numbers.Length - 1)
//                {
//                    sb.Append(", ");
//                }
//            }
//            string s = sb.ToString();
//            return s;
//        }

//    }
//}

//2
//using System;
//using System.Text;
//namespace ConsoleApp3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Text:");
//            string pattern = Console.ReadLine();
//            Console.Write("Input n:");
//            int n = int.Parse(Console.ReadLine());
//            string repeat = Repeat(pattern, n);
//            Console.WriteLine("Result:" + repeat);


//        }

//        static string Repeat(string pattern, int n)
//        {
//            StringBuilder sb = new StringBuilder(n * pattern.Length);
//            for(int i = 0; i<n; i++)
//            {
//                sb.Append(pattern);

//            }
//            string result = sb.ToString();
//            return result;
//        }
//    }
//}
//3
//using System;
//namespace ConsoleApp3
//{
//    struct Rectangle
//    {
//        public double Width;
//        public double Height;

//        public Rectangle(double width, double height)
//        {
//            Width = width;
//            Height = height;
//        }
//        public double Area()
//        {
//            return Width * Height;
//        }
//    }

//    struct Triangle
//    {
//        public double Base;
//        public double Height;

//        public Triangle(double base_, double height)
//        {
//            Base = base_;
//            Height = height;
//        }

//        public double Area()
//        {
//            return Height * Base / 2.0;
//        }



//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Rectangle rectangle = new Rectangle(4, 12);
//                Triangle triangle = new Triangle(5,15);
//                Console.WriteLine("Rectangle area: " + rectangle.Area());
//                Console.WriteLine("Triangle area: " + triangle.Area());

//            }
//        }
//    }
//}
//4
using System;
namespace ConsoleApp3
{
    struct Point
    {
        public int X;
        public int Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Random random = new Random();
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i].X = random.Next(-10, 10);
                points[i].Y = random.Next(-10, 10);
            }
            Console.WriteLine("Array without sorting:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"( {points[i].X},{points[i].Y})");
            }
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if (points[j].X > points[j + 1].X ||( points[j].X == points[j+1].X && points[j].Y > points[j + 1].Y))
                    {
                        Point p = points[j];
                        points[j] = points[j + 1];
                        points[j + 1] = p;
                    }
                }
            }
            Console.WriteLine("\nSorted array:");
            for(int i = 0;i < n; i++)
            {
                Console.WriteLine($"( {points[i].X},{points[i].Y})");
            }
        }
    }
}
