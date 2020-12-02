using LeandroAT1.DatasEmGeral;
using System;

namespace LeandroAT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dias!");
            Console.WriteLine(CalculoDeData.DifEntreDatasEmDias(1,1,2020,1,2,2020));
            Console.WriteLine(CalculoDeData.DifEntreDatasEmDias("01/01/2020","01/02/2020"));
        }
    }
}
