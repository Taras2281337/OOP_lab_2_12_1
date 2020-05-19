using System;

namespace OOP_lab_2_12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Червоний.");
                    break;
                case 2:
                    Console.WriteLine("Помаранчевий.");
                    break;
                case 3:
                    Console.WriteLine("Жовтий.");
                    break;
                case 4:
                    Console.WriteLine("Залений.");
                    break;
                case 5:
                    Console.WriteLine("Блакитний.");
                    break;
                case 6:
                    Console.WriteLine("Синiй.");
                    break;
                case 7:
                    Console.WriteLine("Фiолетовий.");
                    break;
            }
        }
    }
}
