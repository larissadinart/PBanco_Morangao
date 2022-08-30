using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Agencia
    {
        private String Ag { get; set; }
        private String Clientes { get; set; }
        private String Func { get; set; }
        protected List<Cliente>ListaClientes = new List<Cliente>();
        protected List<Funcionario> ListaFuncionarios = new List<Funcionario>();
        protected List<Agencia> ListaAgencias = new List<Agencia>();

        public Agencia(string ag, string clientes, string func)
        {
            Ag = ag;
            Clientes = clientes;
            Func = func;

        }

        public void AdicionarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            ListaFuncionarios.Add(funcionario);
        }
        public void AdicionarAgencia(Agencia agencia)
        {
            ListaAgencias.Add(agencia);
        }

        public void ExcluirCliente(Cliente cliente)
        {
            ListaClientes.Remove(cliente);
        }
        public void ExcluirFuncionario(Funcionario funcionario)
        {
            ListaFuncionarios.Remove(funcionario);
        }
        public void ExcluirAgencia(Agencia agencia)
        {
            ListaAgencias.Add(agencia);
        }







    }


}
