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

        public Endereco()
        {
            Console.WriteLine("Digite o nome da rua/avenida: ");
            Logradouro = Console.ReadLine();
            Console.WriteLine("Digite o número: ");
            Numero = Console.ReadLine();
            Console.WriteLine("Digite o bairro: ");
            Bairro = Console.ReadLine();
            Console.WriteLine("Digite o CEP: ");
            Cep = Console.ReadLine();
            Console.WriteLine("Digite o complemento: ");
            Complemento = Console.ReadLine();
            Console.WriteLine("Digite a cidade: ");
            Cidade = Console.ReadLine();

        }
        public override string ToString()
        {
            return "Logradouro: " + Logradouro + "\nNº: " + Numero + "\nBairro: " + Bairro + "Cep: " + Cep + "Complemento: " + Complemento + "Cidade: " + Cidade;
        }
    }
}
