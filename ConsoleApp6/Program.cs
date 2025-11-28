using System;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine(IsClosed(str));
        }

        static bool IsClosed(string str)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                {
                    stack.Push(str[i]);
                }
                else if (str[i] == ')' || str[i] == ']' || str[i] == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();


                    if (!(top == '(' && str[i] == ')') && (top == '[' && str[i] == ']') && (top == '{' && str[i] == '}'))
                    {
                        return false;
                    }
                }
            }
                return stack.Count == 0;
            


        }
    }
}