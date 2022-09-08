using System;
using System.Collections; // IList
using System.Collections.Generic; //List
using System.IO; //Utilizado para Manipulação de Arquivos

namespace PBanco_Morangao
{
    internal class Program
    {
        static int tipoAcesso = 0;
        static string senPadrao = "Admin";
        static string idPadrao = "Admin";
        static bool gerente;
        static Agencia agencia = new Agencia();
        static string status;
        static int opcaoCliente;
        static string conta, ag, banco, senha, pagamento;
        static float valor = 0;


        static void Main(string[] args)
        {
            MenuTipoAcesso();
        }
        public static void MenuTipoAcesso()
        {
            string idfunc = "";
            string senha = "";

            Console.Clear();
            do
            {
                Console.Clear();
                Console.WriteLine(">>>>>BEM VINDO AO BANCO MORANGÃO!!<<<<<");
                Console.WriteLine("\nEscolha a opção desejada: \n\n1- Sou Cliente\n2- Sou Gerente\n3- Sou Funcionário\n4- Cadastrar Func/Gerente");
                try
                {
                    tipoAcesso = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Opção inválida!");
                }
            } while (tipoAcesso < 1 || tipoAcesso > 4);

            if (tipoAcesso == 1)
            {
                Console.Clear();
                Console.WriteLine("Opção: Sou Cliente:\n");
                MenuSenhaCliente();
            }
            else if (tipoAcesso == 2)
            {
                Console.Clear();
                Console.WriteLine(">> Opção: Sou Gerente <<\n");
                Console.WriteLine("Digite o ID do Gerente: ");
                idfunc = Console.ReadLine();
                Console.WriteLine("Digite a senha de acesso: ");
                senha = Console.ReadLine();

                Funcionario funcionario = agencia.BuscarListFuncionario(idfunc, senha);

                if (funcionario != null && idfunc == funcionario.IdFunc && senha == funcionario.Senha)
                {
                    MenuAcessoGer();
                }
                else
                {
                    Console.WriteLine("Senha inválida! Tente novamente!");
                    Console.WriteLine("\nAperte enter para continuar...\n");
                    Console.ReadKey();
                    MenuTipoAcesso();
                }
            }

            else if (tipoAcesso == 3)
            {
                Console.Clear();
                Console.WriteLine(">> Opção: Sou Funcionário <<\n");
                Console.WriteLine("Digite o ID do Funcionário: ");
                idfunc = Console.ReadLine();
                Console.WriteLine("Digite a senha de acesso: ");
                senha = Console.ReadLine();

                Funcionario funcionario = agencia.BuscarListFuncionario(idfunc, senha); 

                if (funcionario != null && idfunc == funcionario.IdFunc && senha == funcionario.Senha)
                {
                    MenuAcessoFunc();
                }
                else
                {
                    Console.WriteLine("Senha inválida! Tente novamente!");
                    Console.WriteLine("\nAperte enter para continuar...\n");
                    Console.ReadKey();
                    MenuTipoAcesso();
                }
            }

            else if (tipoAcesso == 4)
            {
                Console.Clear();
                Console.WriteLine("Opção: Cadastrar Primeiro Funcionário:\n\n");
                Console.WriteLine(">>>> Para o bom andamento do sistema, recomenda-se cadastrar primeiro a função Gerente!\n\nUtilizar a ID: Admin e Senha: Admin\n\n");
                
                Console.WriteLine("Digite o ID do Administrador: ");
                idfunc = Console.ReadLine();
                Console.WriteLine("Digite a senha do administrador: ");
                senha = Console.ReadLine();

                if (idfunc == idPadrao && senha == senPadrao)
                {
                    Funcionario funcionario = new Funcionario();
                    agencia.AdcFuncLista(funcionario);
                    MenuTipoAcesso();
                }
                else
                {
                    Console.WriteLine("\nOpção inválida, tente novamente!\n");
                    MenuTipoAcesso();
                }
            }

        }

        static public void MenuAcessoFunc()
        {
            int opFunc;

            Console.Clear();
            do
            {
                Console.WriteLine("Digite a operação que deseja fazer: \n\n1- Cadastrar Cliente\n2- Voltar ao Menu Anterior");
                opFunc = int.Parse(Console.ReadLine());
            } while (opFunc < 1 || opFunc > 2);

            if (opFunc == 1)
            {
                Cliente cliente = new Cliente();

                agencia.AdcClienteAprovConta(cliente);
                agencia.BuscaListAprovContaGer();
                MenuTipoAcesso();

            }

            else if (opFunc == 2)
            {
                MenuTipoAcesso();
            }
        }


        static public void MenuAcessoGer()
        {
            int opGer = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite a operação que deseja fazer: \n\n1- Abrir Lista De Aprovações Pendentes\n2- Cadastrar Novo Funcionário\n3- Acessar Lista de Funcionários\n4- Voltar ao menu anterior\n5- Sair");
                try
                {
                    opGer = int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Opção inválida!");
                }

            } while (opGer < 1 || opGer > 5);

            if (opGer == 1)
            {
                agencia.AprovarAberturaContas();
                Console.WriteLine("Aperte enter para continuar...");
                Console.ReadKey();
                MenuTipoAcesso();
            }
            else if (opGer == 2)
            {
                Funcionario funcionario = new Funcionario();
                agencia.AdcFuncLista(funcionario);
                MenuTipoAcesso();

            }
            else if (opGer == 3)
            {
                Console.WriteLine("Opção em construção...\n\nAperte enter para continuar...");
                Console.ReadKey();
                MenuAcessoGer();


            }
            else if (opGer == 4)
            {
                MenuTipoAcesso();

            }
            else if (opGer == 5)
            {
                Environment.Exit(0);
            }



        }
        static public void MenuSenhaCliente()
        {

            Console.Clear();
            Console.WriteLine(">>>> ACESSO CLIENTE <<<<\n\n");
            Console.WriteLine("Digite o número da conta: ");
            conta = Console.ReadLine();
            Console.WriteLine("Digite a agência: ");
            ag = Console.ReadLine();
            Console.WriteLine("Digite a senha: ");
            senha = (Console.ReadLine());

            Cliente cliente = agencia.BuscarCliente(conta, ag, senha);

            if (cliente != null)
            {
                MenuAcessoCliente(cliente);
            }
            else
            {
                int volta;
                Console.WriteLine("\nConta Agência ou Senha inválidas ou não cadastradas! Tente novamente!\n\n");
                Console.WriteLine("Aperte qualquer tecla para continuar ou 0 para voltar ao menu anterior...");
                volta = int.Parse(Console.ReadLine());

                if(volta == 0)
                {
                    MenuTipoAcesso();
                }
                else
                {
                    MenuTipoAcesso();
                }
                Console.ReadKey();
            }
        }
        static public void MenuAcessoCliente(Cliente cliente)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Digite a operação que deseja fazer:\n1- Sacar\n2- Transferir\n3- Pagamentos\n4- Depositar\n5- Consultar Saldo\n6- Sair\n0- Voltar ao Menu Anterior");
                try
                {
                    opcaoCliente = int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Opção inválida!");
                }
            } while (opcaoCliente < 0 || opcaoCliente > 6);

            if (opcaoCliente == 0)
            {
                MenuTipoAcesso();
            }
            else if (opcaoCliente == 1)
            {

                Console.WriteLine(">>SAQUE<<\n");
                do
                {
                    Console.WriteLine("Digite o valor que deseja sacar: ");
                    try
                    {
                        valor = float.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                } while (valor < 0);

                cliente.contaCorrente.MovimentarSaida(valor);

                Console.ReadLine();

                MenuAcessoCliente(cliente);
            }
            else if (opcaoCliente == 2)
            {
                Console.WriteLine(">>TRANSFERÊNCIA<<\n");
                Console.WriteLine("Digite o número da conta para qual deseja transferir: ");
                conta = Console.ReadLine();
                Console.WriteLine("Digite o número da agência: ");
                banco = Console.ReadLine();
                do
                {
                    Console.WriteLine("Digite o valor para transferência: ");
                    try
                    {
                        valor = float.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                } while (valor < 0);
                cliente.contaCorrente.MovimentarSaida(valor);
                Console.ReadLine();

                MenuAcessoCliente(cliente);
            }
            else if (opcaoCliente == 3)
            {
                Console.WriteLine(">>PAGAMENTOS<<\n");
                Console.WriteLine("Digite o código de barras da conta: ");
                pagamento = Console.ReadLine();
                do
                {
                    Console.WriteLine("Digite o valor da conta: ");
                    try
                    {
                        valor = float.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                } while (valor < 0);
                cliente.contaCorrente.MovimentarSaida(valor);
                Console.ReadLine();

                MenuAcessoCliente(cliente);
            }
            else if (opcaoCliente == 4)
            {
                Console.WriteLine(">>DEPÓSITO<<\n");
                do
                {
                    Console.WriteLine("Digite o valor do depósito: ");
                    try
                    {
                        valor = float.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                } while (valor < 0);
                cliente.contaCorrente.MovimentarEntrada(valor);
                Console.WriteLine("Depósito efetuado com sucesso!");
                Console.ReadLine();

                MenuAcessoCliente(cliente);

            }
            else if (opcaoCliente == 5)
            {
                Console.WriteLine(">>CONSULTAR SALDO<<\n");
                Console.WriteLine($"Saldo: R$ {cliente.contaCorrente.Saldo}");

                MenuAcessoCliente(cliente);

            }
            else if (opcaoCliente == 6)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Cliente não localizado!");
                MenuAcessoCliente(cliente);
            }
        }
    }
}











