using System;

namespace StringAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajalt tema eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("Sisestage oma eesnimi:");
            string firstName = Console.ReadLine();

            //int firstNameLenght = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sumbolit");
        }
    }
}
