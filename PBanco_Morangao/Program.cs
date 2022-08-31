using System;

namespace PBanco_Morangao
{
    internal class Program
    {
        private static Agencia agencia1 = new Agencia("Morango do Nordeste");
        private static Agencia agencia2 = new Agencia("Morango do Sudeste");

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
                MenuAcessoFunc();

                //Menu de funcionarios
            }
            else if (tipoAcesso == 3)
            {
                Console.Clear();
                Console.WriteLine("\nTipo De Acesso: Gerente.");
                MenuAcessoGer();
                //Menu gerente
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nOpção inválida! Tente novamente!\n");
                MenuTipoDeAcesso();
            }
        }

        private static void MenuAcessoGer()
        {
            if (SenhaGer())
            {
                /*
                 * Implementar regras gerente:
                 *  -aprovar conta
                 *  -aprovar emprestimo
                 * 
                 */
            }
        }

        static public void MenuAcessoCliente()
        {
            int agencia = 0;
            int opcaoCliente = 0;
            string nomeAgencia = "";

            Console.WriteLine("\nDigite a agência desejada: \n\n1 - Morango Do Nordeste\n2 - Morango Do Sudeste \n");
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
                nomeAgencia = "Morango Do Sudeste";
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
                Console.WriteLine("Opção: Já Sou Cliente:"); /**************/
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

        private static void MenuAgenciaCliente(int numAgencia)
        {
            Agencia agenciaEscolhida;
            if (numAgencia == 1)
            {
                agenciaEscolhida = agencia1;
            }
            else if (numAgencia == 2)
            {
                agenciaEscolhida = agencia2;
            }
            else
            {
                return;//rever para colocar mensagem de erro
            }

            /*
             * Selecionada a agência, digitar a conta corrente e senha?
                MENUS PARA
                //sacar
                //depositar
                //transferir
                //pagar conta 
                //solicitar emprestimo
             */
        }

        static public bool SenhaFunc()
        {
            Cliente cl1 = new Cliente();
            double senhaFun = 123456;
            double senhaF = 0;
            int op ;

            Console.Clear();
            Console.WriteLine("Digite a senha de acesso: ");
            senhaF = int.Parse(Console.ReadLine());
            while (senhaF != senhaFun)
            {
                Console.Clear();
                Console.WriteLine("Senha inválida! Tente novamente!");
                Console.WriteLine("Digite a senha de acesso: ");
                senhaF = int.Parse(Console.ReadLine());
            }
            return true;

            if(true)
            {
                Console.WriteLine("Olá, digite a operação que deseja fazer: \n1-Cadastrar Novo Cliente\n2-Listas\n3-Sair");
            }if(op == 1)
            {
                
            }
        }   

        static public bool SenhaGer()
        {
            double senhaG;
            double senhaGerente = 654321;

            Console.WriteLine("Digite a senha de acesso: ");
            senhaG = int.Parse(Console.ReadLine());
            while (senhaG != senhaGerente)
            {
                Console.WriteLine("Senha inválida! Tente novamente!");
                Console.WriteLine("Digite a senha de acesso: ");
                senhaG = int.Parse(Console.ReadLine());
            }

            return true;
        }
        static public void MenuAcessoFunc()
        {
            

            if (SenhaFunc())
            {
                int opcao;
                Console.WriteLine("Digite o que deseja fazer: \n1- Cadastrar Cliente\n2- Verificar requisições pendentes");
                /*
                 * Implementar
                 *   - cadastro cliente
                 *   - remover cliente
                 * 
                 */

            }
        }
        static public void JaSouCliente()
        {
            string login;
            string senha;

            Console.WriteLine("Olá, digite o número da conta: ");
            login = Console.ReadLine();
            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();

            //validar login e senha

        }

    }
}
