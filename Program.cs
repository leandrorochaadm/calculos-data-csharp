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

            Console.WriteLine(CalculoDeData.DifEntreDatasEmMeses(1, 1, 2020, 1, 2, 2020));
            Console.WriteLine(CalculoDeData.DifEntreDatasEmMeses("01/01/2020", "01/02/2020"));

            Console.WriteLine(CalculoDeData.DifEntreDatasEmAnos(1, 1, 2020, 1, 2, 2021));
            Console.WriteLine(CalculoDeData.DifEntreDatasEmAnos("01/01/2020", "01/02/2021"));

            Console.WriteLine(CalculoDeData.DifDataInicialEDataDeHojeEmDias(1, 1, 2020));
            Console.WriteLine(CalculoDeData.DifDataInicialEDataDeHojeEmDias("01/01/2020"));

            Console.WriteLine(CalculoDeData.SomarDiasApartirDataAtual(1));
            Console.WriteLine(CalculoDeData.SomarDiasParaUmaData(1, 1,1,2020));

            Console.WriteLine("DifDataInicialEDataDeHojeEm...");

            Console.WriteLine(CalculoDeData.DifDataInicialEDataDeHojeEmDias(1, 1, 2020));
            Console.WriteLine(CalculoDeData.DifDataInicialEDataDeHojeEmDias("01/01/2020"));

            Console.WriteLine(CalculoDeData.DifDataInicialEDataDeHojeEmMeses(1, 1, 2020));
            Console.WriteLine(CalculoDeData.DifDataInicialEDataDeHojeEmMeses("01/01/2020"));

            Console.WriteLine(CalculoDeData.DifDataInicialEDataDeHojeEmAnos(1, 1, 2020));
            Console.WriteLine(CalculoDeData.DifDataInicialEDataDeHojeEmAnos("01/01/2020"));

            Console.WriteLine(CalculoDeData.SomarDiasApartirDataAtual(1));
            Console.WriteLine(CalculoDeData.SomarDiasParaUmaData(1, 1, 1, 2020));

            Console.WriteLine("otimizado");

            Console.WriteLine(CalculoDeDataOtimizado.DifEntreDatasEmDias(1, 1, 2020, 1, 2, 2020));
        }
    }
}
