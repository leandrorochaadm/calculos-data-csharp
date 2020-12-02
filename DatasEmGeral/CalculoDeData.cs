using System;
using System.Collections.Generic;
using System.Text;

namespace LeandroAT1.DatasEmGeral
{
    public static class CalculoDeData
    {
        public static int DifEntreDatasEmDias(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);

            TimeSpan difereca = dataFinal - dataInicial;
            return difereca.Days;
        }

        public static int DifEntreDatasEmDias(string dataIn, string dataFin)
        {
            int diaI, mesI, anoI, diaF, mesF, anoF;

            //data inicial
            diaI = Convert.ToInt32(dataIn.Substring(0, 2));
            mesI = Convert.ToInt32(dataIn.Substring(3, 2));
            anoI = Convert.ToInt32(dataIn.Substring(6, 4));
            
            //data final
            diaF = Convert.ToInt32(dataFin.Substring(0, 2));
            mesF = Convert.ToInt32(dataFin.Substring(3, 2));
            anoF = Convert.ToInt32(dataFin.Substring(6, 4));

            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);

            TimeSpan difereca = dataFinal - dataInicial;
            return difereca.Days;
        }

        public static int DifEntreDatasEmMeses(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);

            TimeSpan difereca = dataFinal - dataInicial;
            return (int) (difereca.Days/30.436875);
        }

        public static int DifEntreDatasEmMeses(string dataIn, string dataFin)
        {
            int diaI, mesI, anoI, diaF, mesF, anoF;

            //data inicial
            diaI = Convert.ToInt32(dataIn.Substring(0, 2));
            mesI = Convert.ToInt32(dataIn.Substring(3, 2));
            anoI = Convert.ToInt32(dataIn.Substring(6, 4));

            //data final
            diaF = Convert.ToInt32(dataFin.Substring(0, 2));
            mesF = Convert.ToInt32(dataFin.Substring(3, 2));
            anoF = Convert.ToInt32(dataFin.Substring(6, 4));

            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);

            TimeSpan difereca = dataFinal - dataInicial;
            return (int)(difereca.Days / 30.436875);
        }

        public static int DifEntreDatasEmAnos(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);

            TimeSpan difereca = dataFinal - dataInicial;
            return (int)(difereca.Days / 365.2425);
        }

        public static int DifEntreDatasEmAnos(string dataIn, string dataFin)
        {
            int diaI, mesI, anoI, diaF, mesF, anoF;

            //data inicial
            diaI = Convert.ToInt32(dataIn.Substring(0, 2));
            mesI = Convert.ToInt32(dataIn.Substring(3, 2));
            anoI = Convert.ToInt32(dataIn.Substring(6, 4));

            //data final
            diaF = Convert.ToInt32(dataFin.Substring(0, 2));
            mesF = Convert.ToInt32(dataFin.Substring(3, 2));
            anoF = Convert.ToInt32(dataFin.Substring(6, 4));

            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);

            TimeSpan difereca = dataFinal - dataInicial;
            return (int)(difereca.Days / 365.2425);
        }

        public static int DifDataInicialEDataDeHojeEmDias(int diaI, int mesI, int anoI) 
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = DateTime.Now;

            TimeSpan difereca = dataFinal - dataInicial;
            return difereca.Days;
        }

        public static int DifDataInicialEDataDeHojeEmDias(string dataIn)
        {
            int diaI, mesI, anoI;

            //data inicial
            diaI = Convert.ToInt32(dataIn.Substring(0, 2));
            mesI = Convert.ToInt32(dataIn.Substring(3, 2));
            anoI = Convert.ToInt32(dataIn.Substring(6, 4));

            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = DateTime.Now;

            TimeSpan difereca = dataFinal - dataInicial;
            return difereca.Days;
        }

        public static DateTime SomarDiasParaUmaData(int qtdDias, int dia, int mes, int ano)
        {
            DateTime dataFutura = new DateTime(ano, mes, dia) ;
            return dataFutura.AddDays(qtdDias);
        }

        public static DateTime SomarDiasApartirDataAtual(int qtdDias)
        {
            DateTime dataFutura = DateTime.Now;
            return dataFutura.AddDays(qtdDias);
        }

        /* public static int DifDataInicialEDataDeHojeEmMeses() { return 0; }
         public static int DifDataInicialEDataDeHojeEmAnos() { return 0; }
         public void SomarDiasParaUmaData();
         public void SomarDiasApartirDataAtual();
        */

    }
}
