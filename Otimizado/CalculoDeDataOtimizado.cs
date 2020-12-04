using System;
using System.Collections.Generic;
using System.Text;

namespace LeandroAT1.DatasEmGeral
{
    public static class CalculoDeDataOtimizado
    {

        private static TimeSpan DiferencaComEntradaInt(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);

            return dataFinal - dataInicial;
        }

        private static DateTime DataString(string dataString)
        {
            int dia, mes, ano;

            dia = Convert.ToInt32(dataString.Substring(0, 2));
            mes = Convert.ToInt32(dataString.Substring(3, 2));
            ano = Convert.ToInt32(dataString.Substring(6, 4));

            return new DateTime(ano, mes, dia);
        }

        private static TimeSpan DiferencaComEntradaString(string dataIn, string dataFin)
        {
            DateTime dataInicial = DataString(dataIn);
            DateTime dataFinal = DataString(dataFin);

            return dataFinal - dataInicial;
        }

        public static int DifEntreDatasEmDias(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            TimeSpan difereca = DiferencaComEntradaInt(diaI, mesI, anoI, diaF, mesF, anoF);
            return difereca.Days;
        }

        public static int DifEntreDatasEmDias(string dataIn, string dataFin)
        {
           TimeSpan difereca = DiferencaComEntradaString( dataIn,  dataFin);
            return difereca.Days;
        }

        public static int DifEntreDatasEmMeses(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            TimeSpan difereca = DiferencaComEntradaInt(diaI, mesI, anoI, diaF, mesF, anoF);
            return (int) (difereca.Days/30.436875);
        }

        public static int DifEntreDatasEmMeses(string dataIn, string dataFin)
        {
            TimeSpan difereca = DiferencaComEntradaString(dataIn, dataFin);
            return (int)(difereca.Days / 30.436875);
        }

        public static int DifEntreDatasEmAnos(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            TimeSpan difereca = DiferencaComEntradaInt(diaI, mesI, anoI, diaF, mesF, anoF);
            return (int)(difereca.Days / 365.2425);
        }

        public static int DifEntreDatasEmAnos(string dataIn, string dataFin)
        {
            TimeSpan difereca = DiferencaComEntradaString(dataIn, dataFin);
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
            DateTime dataInicial = DataString(dataIn);
            DateTime dataFinal = DateTime.Now;

            TimeSpan difereca = dataFinal - dataInicial;
            return difereca.Days;
        }

        public static int DifDataInicialEDataDeHojeEmMeses(int diaI, int mesI, int anoI)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = DateTime.Now;

            TimeSpan difereca = dataFinal - dataInicial;
            return (int)(difereca.Days / 30.436875);
        }

        public static int DifDataInicialEDataDeHojeEmMeses(string dataIn)
        {

            DateTime dataInicial = DataString(dataIn);
            DateTime dataFinal = DateTime.Now;

            TimeSpan difereca = dataFinal - dataInicial;
            return (int)(difereca.Days / 30.436875);
        }

        public static int DifDataInicialEDataDeHojeEmAnos(int diaI, int mesI, int anoI)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = DateTime.Now;

            TimeSpan difereca = dataFinal - dataInicial;
            return (int)(difereca.Days / 365.2425);
        }

        public static int DifDataInicialEDataDeHojeEmAnos(string dataIn)
        {
            DateTime dataInicial = DataString(dataIn);
            DateTime dataFinal = DateTime.Now;

            TimeSpan difereca = dataFinal - dataInicial;
            return (int)(difereca.Days / 365.2425);
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
    }
}
