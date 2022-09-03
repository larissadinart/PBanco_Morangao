using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class ContaCorrente
    {
        public bool Habilitada { get; set; }
        public char Habilitar { get; set; }
        public int Ag { get; set; }
        public String Senha { get; set; }
        public double NumConta { get; set; }
        public float Saldo { get; set; }
        public float Limite { get; set; }
        public double Cartao { get; set; }
        public String TipoConta { get; set; }
        public Cliente cliente { get; set; }
        public List<ContaCorrente> Extrato { get; set; } = new List<ContaCorrente>();
        /*
         * movimentacao
         *   valor
         *   tipo
         *      pagamento, saque, transferencia, deposito
         *   data(opcional)
         */


        public ContaCorrente()
        {
            
        }
        public void MovimentarSaida(float valor)
        {
            if (Saldo+Limite < valor)
            {
                Console.WriteLine("Valor do saque maior do que valor disponível!");
                MovimentarSaida(valor);
            }
            else
            {
                if (Saldo+Limite > valor)
                {
                    Console.WriteLine("Saque feito com sucesso!");
                    Saldo = Saldo +(- valor); //VERIFICAR ESSE CALCULOO!!!!
                    Console.WriteLine($"Saldo: {Saldo}");
                }

            }
        }
        public void MovimentarEntrada(float valor)
        {
            Saldo = Saldo + valor;
            Console.WriteLine($"Deposito feito com sucesso!\nSaldo:{Saldo}");
        }
        public void SolicitarEmprestimo(float valor) //montar este metodo
        {

        }
        


    }
}
