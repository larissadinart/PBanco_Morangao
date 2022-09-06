using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Pessoa
    {
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public String Cpf { get; set; }
        public String Genero { get; set; }
        public Endereco endereco { get; set; }

        public Pessoa()
        {
        }

        public void CadastrarPessoa()
        {
            Console.WriteLine("> Dados pessoais:\n");
            Console.WriteLine("Digite o nome: ");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Digite o telefone: ");
            this.Telefone = Console.ReadLine();
            Console.WriteLine("Digite o e-mail: ");
            this.Email = Console.ReadLine();
            Console.WriteLine("Digite o cpf: ");
            this.Cpf = Console.ReadLine();
            Console.WriteLine("Digite o gênero - Masculino/Feminino/Outros: ");
            this.Genero = Console.ReadLine();
            this.endereco = new Endereco();
        }

        public override string ToString()
        {
            return ($"{endereco.ToString()}\nNome: {Nome}\n Telefone: {Telefone} \n E-mail: {Email} \n Cpf: {Cpf} \n Gênero:{Genero}");
                
                
        }
    }


}
