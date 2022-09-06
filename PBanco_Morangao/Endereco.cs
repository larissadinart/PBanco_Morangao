using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Endereco
    {
        public string Logradouro {get;set;}
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public Endereco()
        {
            Console.WriteLine("\n>>Dados do endereço:\n ");
            Console.WriteLine("Digite o nome da rua/avenida: ");
            this.Logradouro = Console.ReadLine();
            Console.WriteLine("Digite o número: ");
            this.Numero = Console.ReadLine();
            Console.WriteLine("Digite o bairro: ");
            this.Bairro = Console.ReadLine();
            Console.WriteLine("Digite o CEP: ");
            this.Cep = Console.ReadLine();
            Console.WriteLine("Digite o complemento: ");
            this.Complemento = Console.ReadLine();
            Console.WriteLine("Digite a cidade: ");
            this.Cidade = Console.ReadLine();
        }
        public override string ToString()
        {
            return "\nLogradouro: " + Logradouro + "," + Numero + "\nBairro: " + Bairro + "\nCep: " + Cep + "\nComplemento: " + Complemento + "\nCidade: " + Cidade;
        }
    }
}
