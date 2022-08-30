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
            if(agencia == 1)
            {
                Console.WriteLine("Agência escolhida: Morango Do Nordeste.");
                Console.WriteLine("\nEscolha a opção desejada: \n\n1-Cadastrar cliente\n2-Já Sou Cliente");
                opcao = int.Parse(Console.ReadLine());
                if(opcao == 1)
                {
                    Console.WriteLine("Opção: Cadastrar Cliente");
                }
            }else if(agencia == 2)
            {
                Console.WriteLine("Agência escolhida: Torta De Morango.");
                Console.WriteLine("\nEscolha a opção desejada: \n\n1-Já sou cliente\n2-Cadastrar Cliente");
                opcao = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("\nOpção inválida, tente novamente!\n");
                MenuInicial();
            }
        }
    }
}
