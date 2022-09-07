using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Cliente
    {

        public bool Estudante { get; set; }
        public int Est { get; set; }
        public float Renda { get; set; }
        public String TipoConta { get; set; }
        public Pessoa pessoa { get; set; }
        public Agencia ag { get; set; }
        public ContaCorrente contaCorrente { get; set; }
        public ContaPoupanca contaPoupanca { get; set; }
        public CartaoCredito cartaocredito { get; set; }

        public Cliente()
        {
            Console.WriteLine(">> Opção: Cadastrar Novo Cliente:\n");

            int opcaoConta;
            pessoa = new Pessoa();
            //ContaPoupanca poupanca = new ContaPoupanca();

            Console.WriteLine("\n>>> Dados da conta: \n");
            do
            {
                Console.WriteLine("Cliente é estudante?\n1-Sim\n2-Não");
                try
                {
                    this.Est = int.Parse(Console.ReadLine());
                }
                catch { }
            }while(this.Est < 0 || this.Est > 2);
            if (Est == '1')
            {
                Estudante = true;
            }
            else if (Est == '2')
            {
                Estudante = false;
            }
            Console.WriteLine("Digite sua renda mensal em reais: ");
            Renda = float.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Digite o tipo de conta desejado:\n1-Universitária\n2-Vip\n3-Normal");
                opcaoConta = int.Parse(Console.ReadLine());
                if (opcaoConta == 1)
                {
                    TipoConta = "Conta Universitária";
                }
                else if (opcaoConta == 2)
                {
                    TipoConta = "Conta Vip";
                }
                else if (opcaoConta == 3)
                {
                    TipoConta = "Conta Normal";
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente!");
                }
            } while (opcaoConta < 1 || opcaoConta > 3);

            contaCorrente = new ContaCorrente();
        }

        public override string ToString()
        {
            return ($"Nome: {this.pessoa.Nome}\nTelefone:{this.pessoa.Telefone}\nE-mail:{this.pessoa.Email}\nCPF:{this.pessoa.Cpf}\nGênero:{this.pessoa.Genero}\n\nDados do Endereço:{this.pessoa.endereco}"); //REVER ESTE METODO
        }
    }

}

