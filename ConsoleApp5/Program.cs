//1
//using System;
//namespace ConsoleApp5
//{
//    class Message
//    {
//        public virtual void Print()
//        {
//            Console.WriteLine("Generic message");
//        }
//    }

//    class ErrorMessage : Message
//    {
//        public override void Print()
//        {
//            Console.WriteLine("Error occurred!");
//        }
//    }


//    class SuccesMessage : Message
//    {
//        public override void Print()
//        {

//            Console.WriteLine("Operation successful!");
//        }

//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Message _message = new Message();
//                _message = new ErrorMessage();
//                _message.Print();
//                _message = new SuccesMessage();
//                _message.Print();
//            }
//        }
//    }
//}

//2
using System;
namespace ConsoleApp5
{
    class Animal
    {
        public string Name { get; set; }
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }
    class Cow : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Moo!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animal = new Animal[3];
            animal[0] = new Dog() { Name = "Dog" };
            animal[1] = new Cat() { Name = "Cat" };
            animal[2] = new Cat() { Name = "Cow" };

            for(int i = 0; i < 3; i++){
                Console.Write(animal[i].Name +" - ");
                animal[i].Speak();
            }
        }
    }
}