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
        public List<Funcionario> ListaFuncionarios { get; set; } = new List<Funcionario>();//***** ANALISAR SE AS LISTAS DEVEM, FICAR AQU

        public List<Cliente> ListaClientes { get; set; } = new List<Cliente>();

        public List<Cliente> ListaAprovacoesGerente { get; set; } = new List<Cliente>();

        public List<ContaCorrente> ListaAprovacoesEmprestimo { get; set; } = new List<ContaCorrente>();

        public Agencia()
        {

        }

        public void AdcClienteListaGerente(Cliente cliente)
        {
            ListaAprovacoesGerente.Add(cliente);
            Console.WriteLine("Cliente incluído com sucesso!");
        }
        public Cliente GetListaGerente()
        {
            foreach (var item in ListaAprovacoesGerente) if (item != null)
                    return item;
            Console.WriteLine("Não há empréstimos para aprovar!");
            return null;
        }
        public void DelCliente(Cliente cliente)
        {
            ListaClientes.Remove(cliente);
        }
        public void AddFuncionario(Funcionario funcionario)
        {
            ListaFuncionarios.Add(funcionario);
            Console.WriteLine("Cadastro realizado com sucesso!");
        } //ok
        public void AddConta(ContaCorrente conta)
        {
            ListContaCorrente.Add(conta);
            Console.WriteLine("Cadastro realizado com sucesso!");
        }//ok
        public void DelFuncionario(Funcionario funcionario)
        {
            ListaFuncionarios.Remove(funcionario);
        }//ok
        public void GetListFuncionarios()
        {
            foreach (var item in ListaFuncionarios)
                if (item != null) Console.WriteLine($"FUNCIONÁRIO: {ListaFuncionarios}\n{item}\n");
                else Console.WriteLine("Não existem funcionários cadastrados!");
        } //ok
        public void GetListConta()
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
        }//ok
        public Cliente BuscarAprovacoesContas()
        {
            foreach (var item in ListaAprovacoesGerente) if (item != null) return item;
            return null;
        }
        public void setListaAprovacaoContas(Cliente cliente)
        {
            ListaAprovacoesGerente.Add(cliente);
            Console.WriteLine("Aguardando aprovação do gerente...");
        }//ok
        public void DelListaAprovacao(Cliente cliente)
        {
            ListaAprovacoesGerente.Remove(cliente);
        }//ok
        public ContaCorrente getSolicitacaoEmprestimo()
        {
            foreach (var item in ListaAprovacoesEmprestimo) if (item != null) return item;
            Console.WriteLine("Não há empréstimos para aprovar!");
            return null;
        }//ok
        public void SetSolicitacaoEmprestimo(ContaCorrente conta)
        {
            ListaAprovacoesEmprestimo.Add(conta);
            Console.WriteLine("Aguardando aprovação...");
        }
        public void DelSolicitacaoEmprestimo(ContaCorrente conta)
        {
            ListaAprovacoesEmprestimo.Remove(conta);
        }//ok
        public void AprovarAberturaContas()
        {
            {
                Console.Clear();

                for (int i = 0; i < ListaAprovacoesGerente.Count; i++)
                {
                    Cliente cliente = ListaAprovacoesGerente[i];

                    Console.WriteLine("\n" + cliente + "\n");
                    string opcao;
                    Console.WriteLine("Deseja aprovar este cliente?\n1- Sim\n2- Não");
                    opcao = Console.ReadLine();

                    if (opcao == "1")
                    {
                       
                        ListaClientes.Add(cliente);

                        ListaAprovacoesGerente.Remove(cliente);

                        i -= 1;
                    }

                    else
                    {
                        Console.WriteLine("NÃO APROVADO.");

                        ListaAprovacoesGerente.Remove(cliente);
                    }
                }

                Console.WriteLine("Fim das solicitações!\nAperte 0 para voltar.");
                Console.ReadKey();
            }
        }
        public Cliente BuscarCliente(string conta, string agencia, string senha)
        {
            foreach (Cliente cliente in ListaClientes)
            {
                if (cliente != null && cliente.contaCorrente.NumConta == conta && cliente.contaCorrente.Ag == agencia && cliente.contaCorrente.Senha == senha)
                {
                    return cliente;
                }
            }return null;
        }
    }


}





