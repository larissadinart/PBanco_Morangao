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
        protected List<string>ListaClientes = new List<string>();

        public Agencia(string ag, string clientes, string func)
        {
            Ag = ag;
            Clientes = clientes;
            Func = func;

        }

        //criar lista Clientes
        //criar lista Funcionarios
        //criar lista Agências
        //Adc cliente a lista
        //Excluir cliente da lista
        //Adc func a lista
        //Excluir func da lista



    }


}
