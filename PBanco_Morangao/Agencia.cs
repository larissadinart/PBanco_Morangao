using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Agencia
    {
        public String nome { get; set; }
        
        public List<Funcionario> ListaFuncionarios { get; set; } = new List<Funcionario>();
        public List<Agencia> ListaAgencias { get; set; } = new List<Agencia>();

        public List<Cliente> ListaClientes = new List<Cliente>();

        public Agencia(string nome)
        {
            this.nome = nome;
        }

        public void AddCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }
        public void AddFuncionario(Funcionario funcionario)
        {
            ListaFuncionarios.Add(funcionario);
        }
        public void AddAgencia(Agencia agencia)
        {
            ListaAgencias.Add(agencia);
        }

        public void DelCliente(Cliente cliente)
        {
            //ListaClientes.Remove(cliente);
        }
        public void DelFuncionario(Funcionario funcionario)
        {
            ListaFuncionarios.Remove(funcionario);
        }
        public void DelAgencia(Agencia agencia)
        {
            ListaAgencias.Remove(agencia);
        }
        public void GetListClientes()
        {
            foreach (var item in ListaAgencias)Console.WriteLine(item);
        }
        public void GetListFuncionarios()
        {
            foreach (var item in ListaFuncionarios) Console.WriteLine(item);
        }
        public void GetListAgencias()
        {
            foreach (var item in ListaAgencias) Console.WriteLine(item);
        }






    }


}
