using System;

namespace PBanco_Morangao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuInicial();

        }

        static public void MenuInicial()
        {
            int agencia;
            int opcao;
            Console.WriteLine("Bem vindo ao banco Morangão!");
            Console.WriteLine("\nDigite a agência desejada: \n\n1 - Morango Do Nordeste\n2 - Torta De Morango \n");
            agencia = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (agencia == 1)
            {
                Console.WriteLine("Agência escolhida: Morango Do Nordeste.");
                Console.WriteLine("\nEscolha a opção desejada: \n\n1-Cadastrar cliente\n2-Já Sou Cliente\n3-Voltar Ao Menu Anterior");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (opcao == 1)
                {
                    Console.WriteLine("Opção: Cadastrar Cliente.");
                    //CadastraCliente();
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Opção: Já Sou Cliente.");
                }
                else if (opcao == 3)
                {
                    MenuInicial();
                }
                else
                {
                    Console.WriteLine("\nOpção inválida, tente novamente!\n");
                }
            }
            else if (agencia == 2)
            {
                Console.WriteLine("Agência escolhida: Torta De Morango.");
                Console.WriteLine("\nEscolha a opção desejada: \n\n1-Já sou cliente\n2-Cadastrar Cliente\n3-Voltar Ao Menu Anterior");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            else if (agencia == 3)
            {
                MenuInicial();
            }
            else
            {
                Console.WriteLine("\nOpção inválida, tente novamente!\n");
                MenuInicial();
               
            }
        }
    }
}
