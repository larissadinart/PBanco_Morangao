using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Funcionario
    {
        public String IdFunc { get; set; }
        public String Cargo { get; set; }
        public Pessoa pessoaF { get; set; }
        public String Senha { get; set; }



        public Funcionario()
        {
            pessoaF = new Pessoa();
            int opcao = 0;
            Random rand = new Random();

            Console.WriteLine("\n>> Opção: Cadastrar Novo Funcionário:\n");
            do
            {
                Console.WriteLine("Escolha o cargo do novo funcionário: \n1- Funcionário\n2- Gerente ");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Opção inválida!");
                }
            } while (opcao < 1 || opcao > 2);

            if (opcao == 1)
            {
                Console.WriteLine("Cadastre uma senha para o novo funcionário: ");
                Senha = (Console.ReadLine()); 
                Cargo = "Funcionário";
                IdFunc = rand.Next(10, 99).ToString();
                Console.WriteLine("\nFuncionário Cadastrado com Sucesso!\n");
                Console.Clear();
                Console.WriteLine(">>>> DADOS DO ACESSO CRIADO: <<<<\n");
                Console.WriteLine($"Cargo: {Cargo}\nIdFunc: {IdFunc}\nSenha: {Senha}");
                Console.WriteLine("Aperte enter para continuar...");
                Console.ReadKey();
            }
            else if (opcao == 2)
            {
                Cargo = "Gerente";
                Console.WriteLine("Cadastre uma senha para o novo gerente: ");
                Senha = Console.ReadLine();
                IdFunc = rand.Next(100, 300).ToString();
                Console.Clear();
                Console.WriteLine(">>>> DADOS DO ACESSO CRIADO: <<<<\n");
                Console.WriteLine($"Cargo: {Cargo}\nIdFunc: {IdFunc}\nSenha: {Senha}");
                Console.WriteLine("\nATENÇÃO: Por favor, anote o número do ID e Senha, você precisará deles para operar o sistema.\n");
                Console.WriteLine("\nAperte enter para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Opcão inválida!\nTente Novamente!");
            }
        }

        public override string ToString()
        {
             return ($"Nome: {this.pessoaF.Nome}\nTelefone:{this.pessoaF.Telefone}\nE-mail:{this.pessoaF.Email}\nCPF:{this.pessoaF.Cpf}\nGênero:{this.pessoaF.Genero}");
        }


    }
}

