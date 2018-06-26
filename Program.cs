using System;
using Exam.Properties.Controller;

namespace Exam
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProductController controller = new ProductController();
            while (true)
            {


                Console.WriteLine("1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Please enter your choice");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add product records");
                        controller.Add();
                        break;
                    case 2:
                        Console.WriteLine("Display product records");
                        controller.Display();
                        break;
                    case 3:
                        Console.WriteLine("Delete product by Id");
                        controller.Delete();
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;

                }

                Console.WriteLine("Success.");

            }
        }
    }
}