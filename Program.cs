using LeandroAT1.DatasEmGeral;
using System;

namespace LeandroAT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n>>>>>>>>>>>> ATIVADADE AVALITIVA 1 <<<<<<<<<<<");

            Console.WriteLine("Dias num: "+CalculoDeData.DifEntreDatasEmDias(1,1,2020,1,2,2020));
            Console.WriteLine("Dias string: " + CalculoDeData.DifEntreDatasEmDias("01/01/2020","01/02/2020"));

            Console.WriteLine("Meses num: " + CalculoDeData.DifEntreDatasEmMeses(1, 1, 2020, 1, 2, 2020));
            Console.WriteLine("Meses string: " + CalculoDeData.DifEntreDatasEmMeses("01/01/2020", "01/02/2020"));

            Console.WriteLine("Anos num: " + CalculoDeData.DifEntreDatasEmAnos(1, 1, 1945, 1, 2, 2021));
            Console.WriteLine("Anos string: " + CalculoDeData.DifEntreDatasEmAnos("01/01/1945", "01/02/2021"));

            Console.WriteLine("Dif hoje num: " + CalculoDeData.DifDataInicialEDataDeHojeEmDias(1, 1, 2020));
            Console.WriteLine("Dif hoje string: " + CalculoDeData.DifDataInicialEDataDeHojeEmDias("01/01/2020"));

            Console.WriteLine("SomarDiasApartirDataAtual: " + CalculoDeData.SomarDiasApartirDataAtual(1));
            Console.WriteLine("SomarDiasApartirDataAtual: " + CalculoDeData.SomarDiasParaUmaData(1, 1,1,2020));

            Console.WriteLine("DifDataInicialEDataDeHojeEmMeses num: " + CalculoDeData.DifDataInicialEDataDeHojeEmMeses(1, 1, 2020));
            Console.WriteLine("DifDataInicialEDataDeHojeEmMeses string: " + CalculoDeData.DifDataInicialEDataDeHojeEmMeses("01/01/2020"));

            Console.WriteLine("DifDataInicialEDataDeHojeEmAnos num: " + CalculoDeData.DifDataInicialEDataDeHojeEmAnos(1, 1, 2009));
            Console.WriteLine("DifDataInicialEDataDeHojeEmAnos str: " + CalculoDeData.DifDataInicialEDataDeHojeEmAnos("01/01/2009"));

            Console.WriteLine("SomarDiasApartirDataAtual: " + CalculoDeData.SomarDiasApartirDataAtual(1));
            Console.WriteLine("SomarDiasParaUmaData: " + CalculoDeData.SomarDiasParaUmaData(1, 1, 1, 2020));

            Console.WriteLine("\n >>>>>> CÓGIGO OTIMIZADO <<<<<<<< \n");

            Console.WriteLine("Dias num: " + CalculoDeDataOtimizado.DifEntreDatasEmDias(1, 1, 2020, 1, 2, 2020));
            Console.WriteLine("Dias string: " + CalculoDeDataOtimizado.DifEntreDatasEmDias("01/01/2020", "01/02/2020"));

            Console.WriteLine("Meses num: " + CalculoDeDataOtimizado.DifEntreDatasEmMeses(1, 1, 2020, 1, 2, 2020));
            Console.WriteLine("Meses string: " + CalculoDeDataOtimizado.DifEntreDatasEmMeses("01/01/2020", "01/02/2020"));

            Console.WriteLine("Anos num: " + CalculoDeDataOtimizado.DifEntreDatasEmAnos(1, 1, 1945, 1, 2, 2021));
            Console.WriteLine("Anos string: " + CalculoDeDataOtimizado.DifEntreDatasEmAnos("01/01/1945", "01/02/2021"));

            Console.WriteLine("Dif hoje num: " + CalculoDeDataOtimizado.DifDataInicialEDataDeHojeEmDias(1, 1, 2020));
            Console.WriteLine("Dif hoje string: " + CalculoDeDataOtimizado.DifDataInicialEDataDeHojeEmDias("01/01/2020"));

            Console.WriteLine("SomarDiasApartirDataAtual: " + CalculoDeDataOtimizado.SomarDiasApartirDataAtual(1));
            Console.WriteLine("SomarDiasApartirDataAtual: " + CalculoDeDataOtimizado.SomarDiasParaUmaData(1, 1, 1, 2020));

            Console.WriteLine("DifDataInicialEDataDeHojeEmMeses num: " + CalculoDeDataOtimizado.DifDataInicialEDataDeHojeEmMeses(1, 1, 2020));
            Console.WriteLine("DifDataInicialEDataDeHojeEmMeses string: " + CalculoDeDataOtimizado.DifDataInicialEDataDeHojeEmMeses("01/01/2020"));

            Console.WriteLine("DifDataInicialEDataDeHojeEmAnos num: " + CalculoDeDataOtimizado.DifDataInicialEDataDeHojeEmAnos(1, 1, 2000));
            Console.WriteLine("DifDataInicialEDataDeHojeEmAnos str: " + CalculoDeDataOtimizado.DifDataInicialEDataDeHojeEmAnos("01/01/2000"));

            Console.WriteLine("SomarDiasApartirDataAtual: " + CalculoDeDataOtimizado.SomarDiasApartirDataAtual(1));
            Console.WriteLine("SomarDiasParaUmaData: " + CalculoDeDataOtimizado.SomarDiasParaUmaData(1, 1, 1, 2020));
        }
    }
}
