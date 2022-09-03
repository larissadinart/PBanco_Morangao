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
        public int Habilitar { get; set; }
        public bool Estudante { get; set; }
        public int Est { get; set; }
        public float Renda { get; set; }
        public String TipoConta { get; set; }
        public ContaCorrente contaCorrente { get; set; }
        public Pessoa pessoa { get; set; }
        public Agencia ag { get; set; }
        public ContaPoupanca contaPoupanca { get; set; }
        public CartaoCredito cartaocredito { get; set; }

        public Cliente()
        {
            
        }
        

        public void CadastrarCliente()
        {
            int opcaoConta;
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Opção: Cadastrar Novo Cliente:\n");

            pessoa.CadastrarPessoa();

            
            Console.WriteLine("Cliente é estudante?\n1-Sim\n2-Não"); //TRATAR ERROS NAS OPÇÕES
            this.Est = int.Parse(Console.ReadLine());
            if (Habilitar == '1')
            {
                Habilitado = true;
            }
            else if (Habilitar == '2')
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
            Console.WriteLine("Habilitar cliente?\n1-Sim\n2-Não");//TRATAR ERROS
            Habilitar = char.Parse(Console.ReadLine());
            if (Habilitar == '1')
            {
                this.Habilitado = true;
            }
            else if (Habilitar == '2')
            {
                this.Habilitado = false;
            }

            this.pessoa = pessoa;

            
        }

        public override string ToString()
        {
            return ($"{this.pessoa.Nome}"); //REVER ESTE METODO
        }
    }

}

