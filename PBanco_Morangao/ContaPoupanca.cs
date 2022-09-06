using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class ContaPoupanca
    {
        public float Saldo { get; set; }

        public ContaPoupanca()
        {

        }

        public void CadastraPoupanca()
        {
            Random contap = new Random();

            float saldo;
            float transf = 0;
            int opcao;

            Console.WriteLine("Deseja realizar uma transferência para a Conta Poupança?\n1- Sim\n2- Não");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Console.WriteLine("Digite o valor da transferência: ");
                    transf = float.Parse(Console.ReadLine());
                    break;
                    this.Saldo = (Saldo + transf);
                    Console.WriteLine($"O valor atual da sua conta poupança é: R$ {Saldo}");
                case 2:
                    this.Saldo = (Saldo + transf);
                    Console.WriteLine($"O valor atual da sua conta poupança é: R$ {Saldo}");
                    break;
            }

            

        }

    }
}
