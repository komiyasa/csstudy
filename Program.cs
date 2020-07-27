using System;

namespace CSSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Mycar car = new Mycar();
            Console.WriteLine(car.num);
            Console.WriteLine(car.name);

        }
    }

    class Mycar
    {
        public int num = 6;
        public string name = "komiyasa"; 
    }
}
