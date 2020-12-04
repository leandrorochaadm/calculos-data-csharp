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

        private static bool VerificaDigitosIguais(string cpf)
        {
            int  quantDigitosIguais = 0;
            char referencia = cpf[0];

            foreach (char d in cpf)
            {
                if( d == referencia)
                {
                    quantDigitosIguais++;
                }
                // Console.WriteLine($"d: {d}, ref: {referencia}, quantDigitosIguais {quantDigitosIguais}");
            }
            //Console.WriteLine($"são iguais: {quantDigitosIguais==11}");
            return quantDigitosIguais >= 11;
        }
        private static bool VerificaDigitosValidadoresCPF(string cpf)
        {
            int total = 0;
            int peso = 10;
            for(int i = 0; i < 9; i++)
            {
                
                total = peso * Convert.ToInt32(cpf.Substring(i, 1)) + total;
               // Console.WriteLine($" i {i}, peso {peso}, n {cpf.Substring(i, 1)},  total {total}");
                peso--;
            }

            int resto = (total * 10) % 11;
            if (resto == 10) resto = 0;
            //Console.WriteLine($"resto: {resto}");
            //Console.WriteLine($"1º verificador: {cpf.ToString().Substring(9, 1)}");
            bool primeiroVerificador = (Convert.ToInt32(cpf.ToString().Substring(9, 1)) == resto);

            //------------------

             total = 0;
             peso = 11;
            for (int i = 0; i < 10; i++)
            {
                total = peso * Convert.ToInt32(cpf.Substring(i, 1)) + total;
                //Console.WriteLine($" i {i}, peso {peso}, n {cpf.Substring(i, 1)},  total {total}");
                peso--;
            }
            resto = (total * 10) % 11;
            if (resto == 10) resto = 0;
          //  Console.WriteLine($"resto: {resto}");
          // Console.WriteLine($"2º verificador: {cpf.ToString().Substring(10, 1)}");
            bool segundoVerificador = (Convert.ToInt32(cpf.ToString().Substring(10, 1)) == resto);

            //Console.WriteLine($"digito verificadores: {primeiroVerificador && segundoVerificador}");
            return primeiroVerificador && segundoVerificador;
        }

        public static bool ValidarCPF(string cpf)
        {
            //Console.WriteLine("validar cpf");
            if (!VerificaDigitosIguais(cpf)) {
                return VerificaDigitosValidadoresCPF(cpf);
            }
            return false;
        }

        private static bool VerificaDigitosValidadoresCNPJ(string cnpj)
        {
            string cnjpOriginal = cnpj;
            int soma = 0;
            List<int> peso = new List<int> { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            for (int i = 0; i < 12; i++)
            {
                soma += peso[i] * Convert.ToInt32(cnpj.Substring(i,1));
                // Console.WriteLine($"i {i}, peso {peso[i]}, n {cnpj.Substring(i, 1)}");
            }
            int resto = soma % 11;

            int primeiroDigitoVerificador = 0;
            if (resto > 2) primeiroDigitoVerificador = 11 - resto;
            // Console.WriteLine($"1d {primeiroDigitoVerificador}");
            //---------
            cnpj = cnpj.Substring(0, 12) + primeiroDigitoVerificador.ToString();
            // Console.WriteLine(cnpj);

            soma = 0;
            peso = new List<int> { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            for (int i = 0; i < 13; i++)
            {
                soma += peso[i] * Convert.ToInt32(cnpj.Substring(i, 1));
                // Console.WriteLine($"i {i}, peso {peso[i]}, n {cnpj.Substring(i, 1)}");
            }
            resto = soma % 11;
            int segundoDigitoVerificador = 0;
            if (resto > 2) segundoDigitoVerificador = 11 - resto;
           // Console.WriteLine($"1d {segundoDigitoVerificador}");
           // Console.WriteLine($"soma: {soma}");
            cnpj += segundoDigitoVerificador.ToString();
            //Console.WriteLine(cnpj);
            return cnpj.Equals(cnjpOriginal);
        }

        public static bool ValidarCNPJ(string cnpj)
        {
            //Console.WriteLine("validar cpf");
            if (!VerificaDigitosIguais(cnpj))
            {
                return VerificaDigitosValidadoresCNPJ(cnpj);
            }
            return false;
        }

    }
}
