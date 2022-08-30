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
            double senhaf;
            double senhag;
            int tipoAcesso = 0;

            Console.WriteLine("Bem vindo ao banco Morangão!\n");
            Console.WriteLine("Digite o seu tipo de acesso: \n1-Cliente\n2-Funcionário\n3-Gerente\n");
            try
            {
                tipoAcesso = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Opção inválida!");
            }
            if (tipoAcesso == 1)
            {
                Console.WriteLine("\nTipo De Acesso: Cliente.\n");
                Console.Clear();
                MenuAcessoCliente();

            }
            else if (tipoAcesso == 2)
            {
                Console.Clear();
                Console.WriteLine("\nTipo De Acesso: Funcionário.");
                SenhaFunc();
                
                //Menu de funcionarios
            }else if(tipoAcesso == 3)
            {
                Console.Clear();
                Console.WriteLine("\nTipo De Acesso: Gerente.");
                SenhaGer();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nOpção inválida! Tente novamente!\n");
                MenuTipoDeAcesso();
            }
        }
        static public void MenuAcessoCliente()
        {
            Pessoa pes1 = new Pessoa();

            int agencia = 0;
            int opcaoCliente =0;
            string nomeAgencia = "";

            Console.WriteLine("\nDigite a agência desejada: \n\n1 - Morango Do Nordeste\n2 - Torta De Morango \n");
            try
            {
                agencia = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Opção inválida!");
            }
            Console.WriteLine();
            if (agencia == 1)
            {
                nomeAgencia = "Morango Do Nordeste";
            }
            else if (agencia == 2)
            {
                nomeAgencia = "Torta De Morango";
            }
            else
            {
                Console.WriteLine("\nOpção inválida, tente novamente!\n");
                MenuAcessoCliente();   
            }
            Console.WriteLine($"Agência escolhida: {nomeAgencia}");
            Console.WriteLine("\nEscolha a opção desejada: \n\n1-Já Sou Cliente\n0-Voltar Ao Menu Anterior");
            try
            {
                opcaoCliente = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\nOpção inválida, tente novamente!\n");
            }
            Console.WriteLine();
            if (opcaoCliente == 1)
            {
                Console.Clear();
                Console.WriteLine("Opção: Já Sou Cliente:");
                //opções de conta - ja sou cliente
            }
            else if (opcaoCliente == 0)
            {
                Console.Clear();
                MenuAcessoCliente();
            }
            else
            {
                Console.WriteLine("\nOpção inválida, tente novamente!\n");
                MenuAcessoCliente();
            }
        }
        static public void SenhaFunc()
        {
            double senhaFunc = 123456;
            double senhaF;
            Console.Clear();
            Console.WriteLine("Digite a senha de acesso: ");
            senhaF = int.Parse(Console.ReadLine());
            if (senhaF != senhaFunc)
            {
                Console.WriteLine("Senha inválida! Tente novamente!");
                SenhaFunc();
            }
            else
            {
                //menu funcionario
            }
        }
        static public void SenhaGer()
        {
            double senhaG;
            double senhaGerente = 654321;

            Console.WriteLine("Digite a senha de acesso: ");
            senhaG = int.Parse(Console.ReadLine());
            if (senhaG != senhaGerente)
            {
                Console.WriteLine("Senha inválida! Tente novamente!");
                SenhaGer();
            }
            else
            {
                //menu funcionario
            }
        }


    }
}
