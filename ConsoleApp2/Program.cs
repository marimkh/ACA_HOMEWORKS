////1
///using System;
//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();
//            int[] numbers = new int[15];
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                numbers[i] = random.Next(-100, 100);
//                Console.WriteLine(numbers[i]);
//            }
//            int max = Maximum(numbers);
//            int min = Minimum(numbers);
//            Console.WriteLine("The maximum value of an array: " + max);
//            Console.WriteLine("The minimum value of an array: " + min);

//        }
//            static int Maximum(int[] numbers)
//            {
//                int max = numbers[0];
//                for (int i = 1; i < numbers.Length; i++)
//                {
//                    if (numbers[i] > max)
//                    {
//                        max = numbers[i];
//                    }
//                }
//            return max;
//            }
//            static int Minimum(int[] numbers)
//            {
//                int min = numbers[0];
//                for(int i = 1; i < numbers.Length; i++)
//                {
//                   if(numbers[i] < min)
//                   {
//                       min = numbers[i];
//                   }
//            }
//            return min;
//        }


//    }
//}

//2
//using System;
//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();
//            int[] array = new int[19];
//            for (int i = 0; i < array.Length; i++)
//            {
//                array[i] = random.Next(0, 20);
//                Console.WriteLine(array[i]);
//            }
//            int[] frequency = Frequency(array);
//            Console.WriteLine("Result: ");
//            for (int j = 0; j < frequency.Length; j++)
//            {
//                Console.WriteLine(j + " - " + frequency[j]);
//            }
//        }

//        static int[] Frequency(int[] array)
//        {
//            int maxValue = array[0];
//            for (int i = 1; i < array.Length; i++)
//            {
//                if (array[i] > maxValue)
//                    maxValue = array[i];
//            }

//            int[] count = new int[maxValue + 1];
//            for (int i = 0; i < array.Length; i++)
//            {
//                int value = array[i];
//                count[value]++;
//            }


//            return count;
//        }

//    }
//}

//3
//using System;
//namespace ConsoleApp2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();
//            int[,] matrix = new int[4, 4];
//            for (int i = 0; i < 4; i++)
//            {
//                for (int j = 0; j < 4; j++)
//                {
//                    matrix[i, j] = random.Next(-50, 50);
//                    Console.Write(matrix[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }
//            double result1 = sum1(matrix);
//            double result2 = sum2(matrix);
//            double division = result1 / result2;
//            Console.WriteLine("Sum of the main diagonal " + result1);
//            Console.WriteLine("Sum of the secondary diagonal " + result2);
//            Console.WriteLine("Division of sums " + division);


//        }
//        static int sum1(int[,] matrix)
//        {
//            int sum1 = 0;
//            for (int i = 0; i < 4; i++)
//            {
//                for (int j = 0; j < 4; j++)
//                {
//                    if (i == j)
//                    {
//                        sum1 += matrix[i, j];
//                    }
//                }
//            }
//            return sum1;
//        }
//        static int sum2(int[,] matrix)
//        {

//            int sum2 = 0;
//            for (int i = 0; i < 4; i++)
//            {
//                for (int j = 0; j < 4; j++)
//                {                            
//                        sum2 += matrix[i, 4 - 1 - i];                   
//                }
//            }
//            return sum2;

//        }
//    }
//}

//4
//using System;
//namespace ConsoleApp2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();
//            int n = 3;
//            int[,] matrix = new int[n, n];
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    matrix[i, j] = random.Next(-20, 20);
//                    Console.Write(matrix[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }
//            int result = sum(matrix, n);
//            Console.WriteLine("Sum: " + result);
//        }

//        static int sum(int[,] matrix,int n)
//        {
//            int sum = 0;
//            for (int i = 0; i < n; i++)
//            {
//                for(int j = 0; j < n; j++)
//                {
//                    if(i+j> n - 1)
//                    {
//                        sum += matrix[i, j];
//                    }
//                }
//            }
//            return sum;
//        }
//    }
//}

//5
//using System;
//namespace ConsoleApp2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Input n: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("Input m: ");
//            int m = int.Parse(Console.ReadLine());
//            Random random = new Random();
//            int[,] matrix = new int[n, m];
//            Console.WriteLine("nxm matrix");
//            for(int i = 0; i < n; i++)
//            {
//                for(int j = 0; j<m; j++)
//                {
//                    matrix[i, j] = random.Next(-15, 15);
//                    Console.Write(matrix[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine("Input i: ");
//            int row = int.Parse(Console.ReadLine());
//            Console.WriteLine("Input j: ");
//            int col = int.Parse(Console.ReadLine());
//            int result = sum(matrix,n,m,row,col);
//            Console.WriteLine(result);
//        }

//        static int sum(int[,] matrix,int n,int m,int row,int col)
//        {
//            int sum = 0;
//            Console.WriteLine("Neighbors: ");
//            for (int i = 0; i < n; i++)
//            {
//                for(int j = 0; j < m; j++)
//                {
//                    if (Math.Abs(i-row) <=1 && Math.Abs(j-col)<=1 && !(i == row && j == col))
//                    {
//                        Console.Write(matrix[i, j] + "\t");
//                        sum += matrix[i, j];
//                    }
//                }
//            }
//            Console.WriteLine("Sum of the neighbors: ");
//            return sum;
//        }
//    }
//}

