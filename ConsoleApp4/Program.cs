//1
//using System;
//using System.Text;
//namespace ConsoleApp3
//{
//    struct Student
//    {
//        public string Name;
//        public int[] Scores;
//        public double Average()
//        {
//            double sum = 0;
//            for (int i = 0; i < Scores.Length; i++)
//            {
//                sum += Scores[i];
//            }
//            return sum / Scores.Length;
//        }

//        public void Print()
//        {
//            StringBuilder sb = new StringBuilder();
//            for (int i = 0; i < Scores.Length; i++)
//            {
//                sb.Append(Scores[i]);
//                if (i != Scores.Length - 1)
//                {
//                    sb.Append(", ");
//                }
//            }
//            Console.WriteLine($"Scores: {sb.ToString()}");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int MaxScores = 4;
//            Console.Write("How many students?: n = ");
//            int n = int.Parse(Console.ReadLine());
//            Student[] students = new Student[n];
//            for (int i = 0; i < students.Length; i++)
//            {
//                Console.WriteLine($"Student {i + 1}:");
//                Console.Write("Name of the student: ");
//                students[i].Name = Console.ReadLine();
//                students[i].Scores = new int[MaxScores];
//                for (int j = 0; j < MaxScores; j++)
//                {
//                    Console.Write($"Score {j + 1} ");
//                    students[i].Scores[j] = int.Parse(Console.ReadLine());
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine("\nStudents:\n");
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine($"Student {i + 1}:");
//                Console.WriteLine($"Name: {students[i].Name}");
//                Console.Write("Scores: ");
//                students[i].Print();
//                Console.WriteLine($"Average: {students[i].Average()} ->> {Math.Ceiling(students[i].Average())}\n ");
//            }

//        }
//    }
//}

//2 (with recursion)
//using System;
//namespace ConsoleApp3
//{
//    struct Matrix
//    {
//        public int[,] Mat;
//        public int N;

//        public void NewValue(int x, int y, int oldValue, int newValue)
//        {
//            if (x < 0 || x >= N || y < 0 || y >= N)
//            {
//                return;
//            }
//            if (Mat[x, y] != oldValue)
//            {
//                return;
//            }
//            Mat[x, y] = newValue;
//            NewValue(x + 1, y, oldValue, newValue);
//            NewValue(x - 1, y, oldValue, newValue);
//            NewValue(x, y + 1, oldValue, newValue);
//            NewValue(x, y - 1, oldValue, newValue);

//        }
//        public void PrintMatrix()
//        {
//            for (int i = 0; i < N; i++)
//            {
//                for (int j = 0; j < N; j++)
//                {
//                    Console.Write(Mat[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }
//        }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Matrix n = ");
//            int n = int.Parse(Console.ReadLine());
//            Matrix matrix = new Matrix();
//            matrix.N = n;
//            matrix.Mat = new int[n, n];
//            Random random = new Random();
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    matrix.Mat[i, j] = random.Next(0,2);
//                }
//            }
//            Console.WriteLine("Matrix:");
//               matrix.PrintMatrix();
//            Console.Write("\nStartX: ");
//            int startX = int.Parse(Console.ReadLine());
//            Console.Write("StartY: ");
//            int startY = int.Parse(Console.ReadLine());
//            Console.Write("New Value: ");
//            int newValue = int.Parse(Console.ReadLine());
//            int oldValue = matrix.Mat[startX, startY];

//            if (newValue != oldValue)
//            {
//                matrix.NewValue(startX, startY, oldValue, newValue);
//                Console.WriteLine("\nNew matrix: ");
//                    matrix.PrintMatrix();
//                    Console.WriteLine();
//                }
//            }
//        }
//    }
//}