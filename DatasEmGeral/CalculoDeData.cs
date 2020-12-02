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
       /* public static int DifDataInicialEDataDeHojeEmMeses() { return 0; }
        public static int DifDataInicialEDataDeHojeEmAnos() { return 0; }
        public void SomarDiasParaUmaData();
        public void SomarDiasApartirDataAtual();
       */

    }
}
