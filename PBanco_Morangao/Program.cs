using System;

namespace PBanco_Morangao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuTipoDeAcesso();

        }



        static public void MenuTipoDeAcesso()
        {
            int tipoAcesso;

            Console.WriteLine("Bem vindo ao banco Morangão!\n");
            Console.WriteLine("Digite o seu tipo de acesso: \n1-Cliente\n2-Funcionário");
            tipoAcesso = int.Parse(Console.ReadLine());

            if (tipoAcesso == 1)
            {
                Console.WriteLine("\nTipo De Acesso: Cliente.");
                Console.Clear();
                MenuAcessoCliente();

            }
            else if (tipoAcesso == 2)
            {
                Console.WriteLine("\nTipo De Acesso: Funcionário.");
                Console.Clear();
                //Menu de funcionarios
            }
            else
            {
                Console.WriteLine("\nOpção inválida! Tente novamente!");
                Console.Clear();
                MenuTipoDeAcesso();
            }
        }
        static public void MenuAcessoCliente()
        {
            Pessoa pes1 = new Pessoa();

            int agencia;
            int opcaoCliente;

            Console.WriteLine("\nDigite a agência desejada: \n\n1 - Morango Do Nordeste\n2 - Torta De Morango \n");
            agencia = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (agencia == 1)
            {
                Console.Clear();
                Console.WriteLine("Agência escolhida: Morango Do Nordeste.");
                Console.WriteLine("\nEscolha a opção desejada: \n\n1-Cadastrar cliente\n2-Já Sou Cliente\n3-Voltar Ao Menu Anterior");
                opcaoCliente = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (opcaoCliente == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Opção: Cadastrar Cliente.\n");
                    pes1.CadastrarPessoa();
                }
                else if (opcaoCliente == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Opção: Já Sou Cliente.");
                    //opções de conta - ja sou cliente
                }
                else if (opcaoCliente == 3)
                {
                    Console.Clear();
                    MenuAcessoCliente();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nOpção inválida, tente novamente!\n");
                    MenuAcessoCliente();
                }
            }
            else if (agencia == 2)
            {
                Console.WriteLine("Agência escolhida: Torta De Morango.");
                Console.WriteLine("\nEscolha a opção desejada: \n\n1-Cadastrar Cliente\n2-Já Sou Cliente\n3-Voltar Ao Menu Anterior");
                opcaoCliente = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (opcaoCliente == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Opção: Cadastrar Cliente.\n");
                    pes1.CadastrarPessoa();
                }else if(opcaoCliente == 2)
                {

                }
                else if (opcaoCliente == 3)
                {
                    MenuAcessoCliente();
                }
                else
                {
                    Console.WriteLine("\nOpção inválida, tente novamente!\n");
                    MenuAcessoCliente();

                }
            }
        }
    }
}
