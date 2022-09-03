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
        
        public List<Funcionario> ListaFuncionarios { get; set; } = new List<Funcionario>();//***** ANALISAR SE AS LISTAS DEVEM, FOCAR AQUI
        public List<Agencia> ListaAgencias { get; set; } = new List<Agencia>();//***** ANALISAR SE AS LISTAS DEVEM, FOCAR AQUI

        public List<Cliente> ListaClientes = new List<Cliente>();//***** ANALISAR SE AS LISTAS DEVEM, FOCAR AQUI
        public List<Funcionario> ListaRequisicoesFunc { get; set; } = new List<Funcionario>();//***** ANALISAR SE AS LISTAS DEVEM, FOCAR AQUI

        public Agencia(string nome)
        {
            this.Nome = nome;
        }

        public void AddCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
            Console.WriteLine("Cliente incluído com sucesso!");
        }
        public void AddFuncionario(Funcionario funcionario)
        {
            ListaFuncionarios.Add(funcionario);
        }
        public void DelCliente(Cliente cliente)
        {
            //ListaClientes.Remove(cliente);
        }
        public void DelFuncionario(Funcionario funcionario)
        {
            ListaFuncionarios.Remove(funcionario);
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
        public void GetListReq()
        {
            foreach (var item in ListaRequisicoesFunc) Console.WriteLine(item);
        }
        public void GravarArquivo(Cliente cliente)
        {
            Console.WriteLine("Cadastrando cliente...");
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Listas\\Agencia1.txt");
                sw.WriteLine("Primeiro Cliente:" + cliente.ToString());
                sw.Flush();
                sw.Close();
                sw.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executando o Bloco de Comandos.");
            }
            Console.WriteLine("Fim do Cadastro");
            return;
        }
        public void LerArquivo()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Listas\\Agencia1.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.WriteLine("Fim da Leitura do Arquivo");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executando o Bloco de Comando - Sem Erros");
            }

            return;

        }






    }


}
