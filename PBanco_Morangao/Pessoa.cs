using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Pessoa
    {
        internal String Nome { get; set; }
        internal String Telefone { get; set; }
        internal String Email { get; set; }
        internal String Cpf { get; set; }
        internal String Genero { get; set; }

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
            Console.WriteLine("Digite o gênero: Masculino/Feminino/Outros");

        }
        public void LerPessoa()
        {
            Console.WriteLine($"Nome: {Nome}\n Telefone: {Telefone} \n E-mail: {Email} \n Cpf: {Cpf} \n Gênero:{Genero}");
        }
    }


}
