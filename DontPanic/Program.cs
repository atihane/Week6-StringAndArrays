using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab koik 'o' tahed lauses "dont panic" nulliga - 0;
            //programm asendab koik 'a' tahed samas lauses numbriga 4

            string DP = "Dont panic!";

            DP = DP.Replace('o', '0');
            DP = DP.Replace('a', '4');

            Console.WriteLine(DP);
        }
    }
}
