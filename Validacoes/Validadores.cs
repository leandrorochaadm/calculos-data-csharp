using System;
using System.Collections.Generic;
using System.Text;

namespace LeandroAT1.Validacoes
{
    class Validadores
    {
        public static bool ValidarContaBB(string agencia, string conta)
        {
            bool verificado = false;
            int digitoCont = 0;
            int total = 0;
            int peso = 9;

            if (conta.Substring(8, 1).ToUpper() == "X") digitoCont = 10;
            else digitoCont = Convert.ToInt32(conta.Substring(8, 1));

            for (int i = 0; i < 8; i++)
            {
                total = peso * Convert.ToInt32(conta.Substring(i, 1)) + total;
                peso--;
            }

            int resto = total % 11;
            int dvCont = 11 - resto;
            if (dvCont == 11) dvCont = 0;

            if (dvCont == digitoCont) verificado = true;
            else verificado = false ;

            return verificado;
        }
    }
}
