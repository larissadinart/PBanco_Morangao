using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Funcionario
    {
        public int IdFunc { get; set; }
        public String Cargo { get; set; }
        public String NivelAcesso { get; set; }

        public Pessoa pessoa;
        public List<Funcionario> ListaRequisicoesFunc { get; set; } = new List<Funcionario>();

        public Funcionario()
        {

        }
        public void TipoAcessoFunc()
        {
            Console.WriteLine("Digite o ID do funcionário: \n10 - Gerência \n 12 - Outros");
            IdFunc = int.Parse(Console.ReadLine());
            if(IdFunc == 10)
            {
                NivelAcesso = "Acesso Master";
                Cargo = "Gerente";
            }else if(IdFunc == 12)
            {
                NivelAcesso = "Acesso Simples";
                Cargo = "Funcionário";
            }
        }
        public void GetListReq()
        {
            foreach (var item in ListaRequisicoesFunc) Console.WriteLine(item);
        }


    }
}
