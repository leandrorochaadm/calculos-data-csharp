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

        private static string RetirarMascaraCPF(string cpf)
        {
            if (cpf.Length > 11)
            {
                return cpf.Substring(0, 3) + cpf.Substring(4, 3) + cpf.Substring(8, 3) + cpf.Substring(12, 2);
            }
            else return cpf;
        }

        private static string RetirarMascaraCNPJ(string cnpj)
        {
            if (cnpj.Length > 14)
            {
                return cnpj.Substring(0, 2) + cnpj.Substring(3, 3) + cnpj.Substring(7, 3) + cnpj.Substring(11, 4) + cnpj.Substring(16, 2);
            }
            else return cnpj;
        }

        public static bool ValidarCPF(string cpf)
        {
            //inserindo zeros a esquerda exercicio 4
            cpf = zerosNaEsquerda(cpf,11);
            cpf = RetirarMascaraCPF(cpf);

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
            //inserindo zeros a esquerda exercicio 4
            cnpj = zerosNaEsquerda(cnpj, 14);
            cnpj = RetirarMascaraCNPJ(cnpj);
            if (!VerificaDigitosIguais(cnpj))
            {
                return VerificaDigitosValidadoresCNPJ(cnpj);
            }
            return false;
        }

        private static string zerosNaEsquerda(string conta, int quant) 
        {
            while (conta.Length < quant)
            {
                conta = "0" + conta;
            }
            return conta;
        }

        public static bool ValidarContaCitiBank(string conta)
        {
            int digitoCont = Convert.ToInt32(conta.Substring(conta.Length-1,1));
            int total = 0;
            int peso = 11;
            
           // Console.WriteLine($"conta: {conta}");
           // Console.WriteLine(digitoCont);
            conta = conta.Substring(0,conta.Length - 1);
            // Console.WriteLine($"conta: {conta}");
            conta = zerosNaEsquerda(conta,10);

           // Console.WriteLine($"conta: {conta}");


            for (int i = 0; i < 10; i++)
            {
                total += peso * Convert.ToInt32(conta.Substring(i, 1));
                peso--;
            }
            // Console.WriteLine($"soma: {total}");

            
            int resto = total % 11;
            int dvCont = 0;
            if (resto > 1)
                dvCont = 11 - resto;
                
            return dvCont==digitoCont;
        }

        public static bool ValidarContaCEF(string agencia, string conta)
        {
            if (agencia.Length > 4 || conta.Length > 12) return false;
            int digitoCont = Convert.ToInt32(conta.Substring(conta.Length - 1, 1));
            conta = conta.Substring(0, conta.Length - 1);

            agencia = zerosNaEsquerda(agencia, 4);
            conta = zerosNaEsquerda(conta, 11);
            string parte1 = agencia + conta.Substring(0, 3);
            string parte2 = conta.Substring(3, 8);
            
            int soma = 0;
            int peso = 8;
            for (int i = 0; i < 7; i++)
            {
                soma += peso * Convert.ToInt32(parte1.Substring(i, 1));
                peso--;
            }

            peso = 9;
            for (int i = 0; i < 8; i++)
            {
                soma += peso * Convert.ToInt32(parte2.Substring(i, 1));
                peso--;
            }

            int resto = (soma * 10) - ((int)(soma * 10) / 11) * 11;
            int digitoVerificador = 0;
            if (resto != 10) digitoVerificador = resto; 
   
            return digitoVerificador==digitoCont;
        }

        public static bool ValidarContaItau(string agencia, string conta)
        {
            if (agencia.Length > 4 || conta.Length > 6) return false;
            int digitoCont = Convert.ToInt32(conta.Substring(conta.Length - 1, 1));
            conta = conta.Substring(0, conta.Length - 1);

            agencia = zerosNaEsquerda(agencia, 4);
            conta = zerosNaEsquerda(conta, 5);
            string parte = agencia + conta;

            int soma = 0;
            int peso = 0;
            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0) peso = 2; else peso = 1;

                int mult = peso * Convert.ToInt32(parte.Substring(i, 1));

                if (mult > 9) 
                {
                    string multStr = mult.ToString();
                    mult = Convert.ToInt32(multStr.Substring(0, 1)) + Convert.ToInt32(multStr.Substring(1, 1));
                }
                soma += mult;
            }

            int resto = soma % 10;
            int digitoVerificador = 0;
            if (resto != 0) digitoVerificador = 10- resto;
            return digitoVerificador == digitoCont;
        }

        public static string Inverter(string cartao)
        {
            string cartaoInvertido = "";
            for (int i = cartao.Length-1; i >= 0; i--)
            {
                cartaoInvertido += cartao.Substring(i,1);
            }
            Console.WriteLine(cartaoInvertido);
            return cartaoInvertido;
        }

        public static bool ValidarCartaoCredito(string cartao)
        {
            if (cartao.Length <12 || cartao.Length>19) return false;
            int verificador = Convert.ToInt32(cartao.Substring(cartao.Length - 1, 1));
            cartao = cartao.Substring(0, cartao.Length - 1);
            Console.WriteLine(cartao);

            cartao =Inverter(cartao);

            int soma = 0;
            int peso = 0;
            for (int i = 0; i < cartao.Length; i++)
            {
                if (i % 2 == 0) peso = 2; else peso = 1;

                int mult = peso * Convert.ToInt32(cartao.Substring(i, 1));
              
                if (mult > 9)
                {
                    mult -= 9  ;
                }
               
                soma += mult;
Console.WriteLine($"cartao: {cartao.Substring(i, 1)} mult: {peso * Convert.ToInt32(cartao.Substring(i, 1))} mult9: {mult}, peso: {peso} soma: {soma}");

            }

            int resto = soma % 10;
           
            return resto==verificador;
        }
    }
}
