using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PBanco_Morangao
{
    internal class Agencia
    {
        public String Nome { get; set; }

        private List<ContaCorrente> ListContaCorrente = new List<ContaCorrente>();

        public List<Funcionario> ListFuncionarios = new List<Funcionario>();

        public List<Funcionario> ListGerentes = new List<Funcionario>();

        public List<Cliente> ListClientes = new List<Cliente>();

        public List<Cliente> ListAprovContasGer = new List<Cliente>();

        public List<ContaCorrente> ListAprovEmprGer = new List<ContaCorrente>();

        public List<ContaCorrente> ListExtrato = new List<ContaCorrente>();

        public Agencia()
        {

        }

        public void AdcClienteAprovConta(Cliente cliente)
        {
            ListAprovContasGer.Add(cliente);
            Console.WriteLine("Cliente incluído com sucesso!");
        }
        public Cliente BuscaListAprovContaGer()
        {
            foreach (var item in ListAprovContasGer) if (item != null)
                    return item;
            Console.WriteLine("Não há contas para aprovar!");
            return null;
        }
        public void RemoverClienteAgencia(Cliente cliente)
        {
            ListClientes.Remove(cliente);
            Console.WriteLine("Cliente excluído com sucesso!");
        }
        public void AdcFuncLista(Funcionario funcionario)
        {
            ListFuncionarios.Add(funcionario);
            Console.WriteLine("Cadastro realizado com sucesso!");
        }
        public void AdcCCList(ContaCorrente conta)
        {
            ListContaCorrente.Add(conta);
            Console.WriteLine("Cadastro realizado com sucesso!");
        }
        public void RemoverFuncionarioAgencia(Funcionario funcionario)
        {
            ListFuncionarios.Remove(funcionario);
        }
        public Funcionario BuscarListFuncionario(string id, string senha) //está sobrescrevendo gerente, pq?
        {
            foreach (var item in ListFuncionarios) if (item != null)
                    return item;

            return null;

        }
        public void BuscarListaContas()
        {
            foreach (var item in ListContaCorrente)
            {
                if (item != null)
                {
                    Console.WriteLine(item + "\n");
                    Console.ReadKey();
                }
                else Console.WriteLine("A lista está vazia!");
            }
        }
        public Cliente BuscarAprovacoesPendetesGer()
        {
            foreach (var item in ListAprovContasGer) if (item != null) return item;
            return null;
        }
        public void setListaAprovacaoContas(Cliente cliente)
        {
            ListAprovContasGer.Add(cliente);
            Console.WriteLine("Aguardando aprovação do gerente...");
        }
        public void DelListaAprovacao(Cliente cliente)
        {
            ListAprovContasGer.Remove(cliente);
        }
        public ContaCorrente getSolicitacaoEmprestimo()
        {
            foreach (var item in ListAprovEmprGer) if (item != null) return item;
            Console.WriteLine("Não há empréstimos para aprovar!");
            return null;
        }
        public void SetSolicitacaoEmprestimo(ContaCorrente conta)
        {
            ListAprovEmprGer.Add(conta);
            Console.WriteLine("Aguardando aprovação...");
        }
        public void DelSolicitacaoEmprestimo(ContaCorrente conta)
        {
            ListAprovEmprGer.Remove(conta);
        }
        public void AprovarAberturaContas()
        {
            {
                Console.Clear();

                if (ListAprovContasGer != null)
                {

                    for (int i = 0; i < ListAprovContasGer.Count; i++)
                    {
                        Cliente cliente = ListAprovContasGer[i];

                        Console.WriteLine($"\n{cliente}\n");
                        string opcao;
                        Console.WriteLine("Deseja aprovar este cliente?\n1- Sim\n2- Não");
                        opcao = Console.ReadLine();

                        if (opcao == "1")
                        {
                            ListClientes.Add(cliente);

                            ListAprovContasGer.Remove(cliente);

                            i -= 1;
                            Console.WriteLine("Cliente aprovado com sucesso!\n\nAperte enter para continuar...");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine("Não aprovado!");

                            ListAprovContasGer.Remove(cliente);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Não há contas pendentes de aprovação!g");
                    Console.ReadKey();
                }
                
            }
            
        }
        public Cliente BuscarCliente(string conta, string agencia, string senha)
        {
            foreach (Cliente cliente in ListClientes)
            {
                if (cliente != null && cliente.contaCorrente.NumConta == conta && cliente.contaCorrente.Ag == agencia && cliente.contaCorrente.Senha == senha)
                {
                    return cliente;
                }
                else
                {
                    Console.WriteLine("\nAinda não há clientes cadastrados na agência!\n\n");
                    Console.WriteLine("Aperte enter para continuar....");
                    Console.ReadKey();
                }
            }
            return null;
        }
        public Funcionario BuscarListaFuncionarios(string id, string senha)
        {
            foreach (Funcionario funcionario in ListFuncionarios)
            {
                if (funcionario != null && funcionario.IdFunc == id && funcionario.Senha == senha)
                {
                    return funcionario;
                }
                else { Console.WriteLine("Senha inválida! Tente novamente!"); }
                Console.ReadKey();
            }
            return null;
        }

        public void AdcGerenteLista(Funcionario funcionario)
        {
            ListGerentes.Add(funcionario);
            Console.WriteLine("Cadastro realizado com sucesso!");
        }
    }
    

}





