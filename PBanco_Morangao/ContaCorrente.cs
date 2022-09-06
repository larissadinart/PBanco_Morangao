using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class ContaCorrente
    {
        public string Ag { get; set; }
        public String Senha { get; set; }
        public string NumConta { get; set; }
        public float Saldo { get; set; }
        public float Limite { get; set; }
        public float Total { get; set; }
        public CartaoCredito Cartao { get; set; }
        public Pessoa pessoa { get; set; }
        public ContaPoupanca Poup { get; set; }
        public String TipoConta { get; set; }
        public Cliente cliente { get; set; }
        public List<ContaCorrente> Extrato { get; set; } = new List<ContaCorrente>();
        public ContaCorrente()

        {

        }
        public void CadastrarContaCorrente()
        {

            Random contac = new Random();

            int senha, opcao;
            float saldo, limite = 0;
            this.NumConta = contac.Next();//VERIFICAR COMO GERAR APENAS 6 NUMEROS
            this.Ag = contac.Next(); //VERIFICAR COMO GERAR APENAS 2 NUMEROS
            this.Senha = Senha;
            this.Limite = limite;

            Console.Clear();
            Console.WriteLine("Cadastre uma senha de 6 dígitos: ");
            senha = int.Parse(Console.ReadLine());
            Console.WriteLine("Gostaria de fazer o primeiro depósito?\n1-Sim\n2-Não ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o valor do depósito: ");
                    saldo = float.Parse(Console.ReadLine());
                    this.Saldo = saldo;
                    limite = (saldo / 2);
                    this.Total = saldo + limite; //apenas 2 zeros após a virgula
                    Console.WriteLine($"\n>>>>>DADOS DA CONTA:<<<<<\n\nAgência: {Ag} \nConta: {this.NumConta}\nLimite: R$ {limite}\nSaldo: R$ {Saldo}\nTotal: R$ {Total}");
                    break;

                case 2:
                    Console.WriteLine($"\n>>>>>DADOS DA CONTA:<<<<<\n\nAgência: {Ag} \nConta: {this.NumConta}\nLimite: R$ {limite}\nSaldo: R$ {Saldo}\nTotal: R$ {Total}");
                    break;
            }
            Console.ReadKey();
        }
        public void MovimentarSaida(float valor)
        {
            float total = Saldo + Limite;

            if (Saldo + Limite < valor)
            {
                Console.WriteLine("Valor do saque maior do que valor disponível!");
            }
            else
            {
                total = total - valor;//rever este clculo!!!
                Console.WriteLine("Saque feito com sucesso!");
            }
        }


        public void MovimentarEntrada(float valor)
        {
            Saldo = Saldo + valor;
        }
        public void SolicitarEmprestimo(float valor) //montar este metodo
        {

        }
        public bool PedirSenha()
        {
            string senha;

            Console.Write("Digite sua senha: ");
            senha = Console.ReadLine();
            if (Senha == senha)
                return true;
            else
                return false;
        }
        public void getExtrato()
        {
            Console.WriteLine("\n>>>EXTRATO<<<");
            foreach (var item in Extrato) Console.WriteLine(item);
        }

    }
}

