using System;
using System.Collections; // IList
using System.Collections.Generic; //List
using System.IO; //Utilizado para Manipulação de Arquivos

namespace PBanco_Morangao
{
    internal class Program
    {
        static int tipoAcesso = 0;
        static double senhaGer = 654321, senhaG = 0;
        static double senhaFun = 123456, senhaF = 0;
        static bool gerente;
        static Agencia agencia = new Agencia();

        static void Main(string[] args)
        {
            MenuTipoAcesso();
        }
        public static void MenuTipoAcesso()
        {
            Console.Clear();
            Console.WriteLine(">>>>>BEM VINDO AO BANCO MORANGÃO!!<<<<<");
            Console.WriteLine("\nEscolha a opção desejada: \n\n1- Sou Cliente\n2- Sou Funcionário\n3- Sou Gerente");
            try
            {
                tipoAcesso = int.Parse(Console.ReadLine());
            }
            catch
            {
            }
            Console.WriteLine();
            if (tipoAcesso == 1)
            {
                Console.Clear();
                Console.WriteLine("Opção: Sou Cliente:");
                MenuAcessoCliente();
            }
            else if (tipoAcesso == 2)
            {
                Console.Clear();
                Console.WriteLine("Opção: Sou Funcionário:");
                gerente = false;
                MenuSenhaFuncGer();
            }
            else if (tipoAcesso == 3)
            {
                Console.Clear();
                Console.WriteLine("Opção: Sou Gerente:");
                gerente = true;
                MenuSenhaFuncGer();
            }
            else if (tipoAcesso == 0)
            {
                Console.Clear();

            }
            else
            {
                Console.WriteLine("\nOpção inválida, tente novamente!\n");

            }
        }
        static public void MenuSenhaFuncGer()
        {

            if (gerente == true)
            {
                Console.Clear();
                Console.WriteLine("Digite a senha de acesso: ");
                senhaG = int.Parse(Console.ReadLine());
                MenuAcessoGer();

                if (senhaG != senhaGer)//acesso gerente
                {
                    Console.WriteLine("Senha inválida! Tente novamente!\nAperte 0 para voltar:");
                    Console.ReadKey();
                    MenuSenhaFuncGer();
                }
                else
                {
                    //ENTRAR MENU GERENTE
                }
            }
            else if (gerente == false)//acesso funcionario
            {
                Console.Clear();
                Console.WriteLine("Digite a senha de acesso: ");
                senhaF = int.Parse(Console.ReadLine());

                if (senhaF != senhaFun)
                {
                    Console.WriteLine("Senha inválida! Tente novamente!\nAperte 0 para voltar:");
                    Console.ReadKey();
                    MenuSenhaFuncGer();
                }
                else
                {
                    MenuAcessoFunc();
                }
            }
        }
        static public void MenuAcessoFunc()
        {
            int opFunc;

            Console.Clear();
            Console.WriteLine("Digite a operação que deseja fazer: \n\n1- Cadastrar Cliente\n2- Voltar ao Menu Anterior");
            opFunc = int.Parse(Console.ReadLine());

            if (opFunc == 1)
            {
                Cliente cliente = new Cliente();

                agencia.AdcClienteListaGerente(cliente);
                agencia.GetListaGerente();
                MenuTipoAcesso();

            }

            else if (opFunc == 2)
            {
                MenuTipoAcesso();
            }
        }

        static public void MenuAcessoGer()
        {
            int opGer;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite a operação que deseja fazer: \n1- Abrir Lista De Aprovações Pendentes\n2- Sair");
                opGer = int.Parse(Console.ReadLine());
            } while (opGer < 1 || opGer > 2);

            if (opGer == 1)
            {
                agencia.AprovarAberturaContas();
                MenuTipoAcesso();
            }
            else
            {
                Environment.Exit(0);
            }


        }
        static public void MenuAcessoCliente()
        {
            int opCli;
            float saida = 0;
            int senha = 0;
            string conta, agencia;
            string banco;
            int codBarras;
            float entrada;

            ContaCorrente contacorrente = new ContaCorrente();

                Console.WriteLine("Digite o número da conta: ");
                conta = Console.ReadLine();
                Console.WriteLine("Digite a agência: ");
                agencia = Console.ReadLine();
                Console.WriteLine("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());

            Cliente cliente = agencia.BuscarCliente;


            Console.WriteLine("Digite a operação que deseja fazer:\n1-Sacar\n2-Transferir\n3-Pagamentos\n4-Depositar\n5-Sair");
            opCli = int.Parse(Console.ReadLine());


            if (opCli == 1)
            {

                Console.WriteLine(">>SAQUE<<\n");
                Console.WriteLine("Digite o valor para saque: ");
                saida = float.Parse(Console.ReadLine());
                contacorrente.MovimentarSaida(saida);
            }
            else if (opCli == 2)
            {
                Console.WriteLine(">>TRANSFERÊNCIA<<\n");
                Console.WriteLine("Digite o número da conta para qual deseja transferir: ");
                conta = Console.ReadLine();
                Console.WriteLine("Digite o número da agência: ");
                banco = Console.ReadLine();
                Console.WriteLine("Digite o valor para transferência: ");
                saida = float.Parse(Console.ReadLine());
                contacorrente.MovimentarSaida(saida);
            }
            else if (opCli == 3)
            {
                Console.WriteLine(">>PAGAMENTOS<<\n");
                Console.WriteLine("Digite o código de barras da conta: ");
                codBarras = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor da conta: ");
                saida = float.Parse(Console.ReadLine());
                contacorrente.MovimentarSaida(saida);
            }
            else if (opCli == 4)
            {
                Console.WriteLine(">>DEPÓSITO<<\n");
                Console.WriteLine("Digite o valor do depósito: ");
                entrada = float.Parse(Console.ReadLine());
                contacorrente.MovimentarEntrada(entrada);
            }
            else if (opCli == 5)
            {
                Environment.Exit(0);
            }
        }


    }
}













