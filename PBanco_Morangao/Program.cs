using System;
using System.Collections; // IList
using System.Collections.Generic; //List
using System.IO; //Utilizado para Manipulação de Arquivos

namespace PBanco_Morangao
{
    internal class Program
    {
        static int agencia, tipoAcesso = 0;
        static string nomeAgencia = "";
        static double senhaGer = 654321, senhaG = 0;
        static double senhaFun = 123456, senhaF = 0;
        static bool gerente;

        private static Agencia agencia1 = new Agencia("Morango do Nordeste");
        private static Agencia agencia2 = new Agencia("Morango do Sudeste");

        static void Main(string[] args)
        {
            MenuAgencia();
        }
        static public void MenuAgencia()
        {

            Console.WriteLine("Bem vindo ao Banco Morangão!");
            Console.WriteLine("\nDigite a agência desejada: \n\n1 - Morango Do Nordeste\n2 - Morango Do Sudeste \n");
            try
            {
                agencia = int.Parse(Console.ReadLine());
            }
            catch
            {
            }
            Console.WriteLine();
            if (agencia == 1)
            {
                nomeAgencia = "Morango Do Nordeste";
                MenuTipoAcesso();
            }
            else if (agencia == 2)
            {
                nomeAgencia = "Morango Do Sudeste";
                MenuTipoAcesso();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nOpção inválida, tente novamente!\n");
                MenuAgencia();
            }
        } //ESTÁ PRONTO!
        public static void MenuTipoAcesso()
        {
            Console.WriteLine($"Agência escolhida: {nomeAgencia}");
            Console.WriteLine("\nEscolha a opção desejada: \n\n1-Sou Cliente\n2-Sou Funcionário\n3-Sou Gerente\n0-Voltar para tela anterior");
            try
            {
                tipoAcesso = int.Parse(Console.ReadLine());
            }
            catch
            {
            }
            Console.WriteLine(); //PQ?
            if (tipoAcesso == 1)
            {
                Console.Clear();
                Console.WriteLine("Opção: Sou Cliente:"); //chamar metodos cliente
            }
            else if (tipoAcesso == 2)
            {
                Console.Clear();
                Console.WriteLine("Opção: Sou Funcionário:");
                gerente = false;
                MenuSenhaFuncGer();

                //Como salvar esse objeto na lista de clientes?
                //enviar requisição da abertura para funcionário/gerente

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
                MenuAgencia();
            }
            else
            {
                Console.WriteLine("\nOpção inválida, tente novamente!\n");
                MenuAgencia();
            }
        }



        public static void MenuSenhaFuncGer()
        {

            if (gerente == true)
            {
                Console.Clear();
                Console.WriteLine("Digite a senha de acesso: ");
                senhaG = int.Parse(Console.ReadLine());

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
        static public void MenuAcessoFunc() //CHAMAR METODO PARA GUARDAR CLIENTE EM ARQUIVO TXT
        {
            int opFunc;

            Console.WriteLine("Digite a opção que deseja fazer: \n1- Cadastrar Cliente\n2- Verificar Requisições Pendentes");
            opFunc = int.Parse(Console.ReadLine());

            if (opFunc == 1)
            {
                Cliente cliente = new Cliente();
                cliente.CadastrarCliente();
                if (agencia == 1)
                {
                    agencia1.AddCliente(cliente);
                    agencia1.GravarArquivo(cliente);
                    MenuTipoAcesso();
                }
                else if (agencia == 2)
                {
                    agencia2.AddCliente(cliente);
                    agencia2.GravarArquivo(cliente);
                    MenuTipoAcesso();
                }
                else if (opFunc == 2)
                {
                    agencia1.LerArquivo(); //REVER ESTE METODO

                    MenuTipoAcesso();

                }
            }

        }

   

    }
}





////private static void MenuAgenciaCliente(int numAgencia)
////{
////    Agencia agenciaEscolhida;
////    if (numAgencia == 1)
////    {
////        agenciaEscolhida = agencia1;
////    }
////    else if (numAgencia == 2)
////    {
////        agenciaEscolhida = agencia2;
////    }
////    else
////    {
////        return;//rever para colocar mensagem de erro
////    }

////    /*
////     * Selecionada a agência, digitar a conta corrente e senha?
////        MENUS PARA
////        //sacar
////        //depositar
////        //transferir
////        //pagar conta 
////        //solicitar emprestimo
////     */
////}


//static public void JaSouCliente()
//{
//    string login;
//    string senha;

//    Console.WriteLine("Olá, digite o número da conta: ");
//    login = Console.ReadLine();
//    Console.WriteLine("Digite sua senha: ");
//    senha = Console.ReadLine();

//    //validar login e senha
//    //fazer  saques transf e etc


