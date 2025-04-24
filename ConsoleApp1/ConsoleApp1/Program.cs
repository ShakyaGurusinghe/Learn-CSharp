using System;

namespace ConsoleApp1{
    class Program
    {

        static void Main(String [] args){
            //Hello World
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            //creating a shape
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");
            Console.WriteLine();


            //creating an object
            Variables v = new Variables();
            v.ShowDetails();

            DataTypes dt = new DataTypes();
            dt.printDataTypes();

            WorkingWithString wws = new WorkingWithString();
            wws.usesOfStrings();
            
        }
    }

}