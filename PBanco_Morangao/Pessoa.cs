using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Pessoa
    {
        private String Nome;
        private String Telefone;
        private String Email;
        private String Cpf;
        private String Genero;

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
            Console.WriteLine("Digite o gênero: \nM-Masculino \nF-Feminino");

        }
        public void LerPessoa()
        {
            Console.WriteLine($"Nome: {Nome}\n Telefone: {Telefone} \n E-mail: {Email} \n Cpf: {Cpf} \n Gênero:{Genero}");
        }
    }


}
