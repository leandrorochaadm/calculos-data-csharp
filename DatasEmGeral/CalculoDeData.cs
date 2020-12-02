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
       /* public static int DifDataInicialEDataDeHojeEmMeses() { return 0; }
        public static int DifDataInicialEDataDeHojeEmAnos() { return 0; }
        public void SomarDiasParaUmaData();
        public void SomarDiasApartirDataAtual();
       */

    }
}
