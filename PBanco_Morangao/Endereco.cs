using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Endereco
    {
        private string Logradouro {get;set;}
        private string Numero { get; set; }
        private string Bairro { get; set; }
        private string Complemento { get; set; }
        private string Cidade { get; set; }
        private string Cep { get; set; }

        public Endereco(String logradouro, String numero, String bairro, String complemento, String cidade, String cep )
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Complemento = complemento;
            Cidade = cidade;
            
        }
        public override string ToString()
        {
            return "Logradouro: " + Logradouro + "\nNº: " + Numero + "\nBairro: " + Bairro + "Cep: " + Cep + "Complemento: " + Complemento + "Cidade: " + Cidade;
        }
    }
}
