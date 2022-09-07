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

            int opcaoConta = 0;
            pessoa = new Pessoa();
            //ContaPoupanca poupanca = new ContaPoupanca();

            Console.WriteLine("\n>>> Dados da conta: \n");
            do
            {
                Console.WriteLine("Cliente é estudante?\n1-Sim\n2-Não");
                try
                {
                    Est = int.Parse(Console.ReadLine());
                }
                catch { }
            } while (Est < 1 || Est > 2);
            if (Est == '1')
            {
                Estudante = true;
            }
            else if (Est == '2')
            {
                Estudante = false;
            }
            do
            {
                Console.WriteLine("Digite sua renda mensal em reais: ");
                try
                {
                    Renda = float.Parse(Console.ReadLine());
                }
                catch { Console.WriteLine("Valor inválido!"); }
            }while (Renda < 0 );

            do
            {
                Console.WriteLine("Digite o tipo de conta desejado:\n1-Universitária\n2-Vip\n3-Normal");
                try
                {
                    opcaoConta = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Opção inválida!");
                }
            } while (opcaoConta < 1 || opcaoConta > 3);
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


            contaCorrente = new ContaCorrente();
        }


        public override string ToString()
        {
            return ($"Nome: {this.pessoa.Nome}\nTelefone:{this.pessoa.Telefone}\nE-mail:{this.pessoa.Email}\nCPF:{this.pessoa.Cpf}\nGênero:{this.pessoa.Genero}\n\nDados do Endereço:{this.pessoa.endereco}"); //REVER ESTE METODO
        }
    }
}



