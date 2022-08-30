using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Pessoa
    {
        private String Nome { get; set; }
        private String Telefone { get; set; }

        private Endereco endereco;
        private String Email { get; set; }
        private String Cpf { get; set; }
        private String Genero { get; set; }

        public Pessoa()
        {
            Console.WriteLine("Digite o nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o telefone: ");
            Telefone = Console.ReadLine();
            Console.WriteLine("Digite o e-mail: ");
            Email = Console.ReadLine();
            Console.WriteLine("Digite o cpf: ");
            Cpf = Console.ReadLine();
            Console.WriteLine("Digite o gênero - Masculino/Feminino/Outros: ");
            Genero = Console.ReadLine();
            Console.WriteLine("Dados do endereço: ");
            endereco = new Endereco();

        }
        public void LerPessoa()
        {
            Console.WriteLine($"Nome: {Nome}\n Telefone: {Telefone} \n E-mail: {Email} \n Cpf: {Cpf} \n Gênero:{Genero}");
        }
    }


}
