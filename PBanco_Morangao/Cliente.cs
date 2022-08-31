using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Cliente
    {
        public bool Habilitado { get; set; }
        public char Habilitar { get; set; }
        public bool Estudante { get; set; }
        public char Est { get; set; }
        public float Renda { get; set; }
        public String TipoConta { get; set; }
        public ContaCorrente contaCorrente { get; set; }
        public Pessoa pessoa { get; set; }
        public Agencia ag { get; set; }
        public Cliente(Pessoa pessoa)
        {
            this.pessoa = pessoa;
        }

        public Cliente()
        {
            int opcaoConta;

            pessoa = new Pessoa();

            Console.WriteLine("Cliente é estudante?\nS-Sim\n N-Não");
            this.Est = char.Parse(Console.ReadLine());
            if (Habilitar == 'S')
            {
                Habilitado = true;
            }
            else if (Habilitar == 'N')
            {
                Habilitado = false;
            }
            Console.WriteLine("Digite sua renda mensal em reais: ");
            this.Renda = float.Parse(Console.ReadLine());

            if (Renda >= 10000)
            {
                this.TipoConta = "Conta Vip";
                Console.WriteLine($"Conta recomendada: {TipoConta}");
            }
            else if (Renda >= 20000 && Renda < 10000)
            {
                this.TipoConta = "Conta Normal";
                Console.WriteLine($"Conta recomendada: {TipoConta}");
            }
            else if (Renda < 2000)
            {
                this.TipoConta = "Conta Universitária";
                Console.WriteLine($"Conta recomendada: {TipoConta}");
            }
            Console.WriteLine("Digite 1 para aceitar o tipo de conta e 2 para alterar: ");
            opcaoConta = int.Parse(Console.ReadLine());
            if (opcaoConta == 1)
            {
                this.TipoConta = TipoConta;
            }
            else if (opcaoConta == 2)
            {
                Console.WriteLine("Digite o tipo de conta desejada:");
                this.TipoConta = Console.ReadLine();
                Console.WriteLine($"Opção escolhida: {TipoConta}");
            }
            Console.WriteLine("Habilitar cliente?\nS-Sim\nN-Não");
            Habilitar = char.Parse(Console.ReadLine());
            if (Habilitar == 'S')
            {
                this.Habilitado = true;
            }
            else if (Habilitar == 'N')
            {
                this.Habilitado = false;
            }
        }
        void LerCliente()
        {

        }
    }

}

