using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Funcionario : Pessoa 
    {
        private int IdFunc { get; set; }
        private String Cargo { get; set; }
        private String NivelAcesso { get; set; }

        public Funcionario()
        {
            Console.WriteLine("Digite o ID do funcionário: \n1 - Gerência \n 2 - Outros");
            IdFunc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Cargo: ");
            Cargo = Console.ReadLine();
            if(IdFunc == 1)
            {
                NivelAcesso = "Acesso Master";
            }else if(IdFunc == 2)
            {
                NivelAcesso = "Acesso Simples";
            }
        }

        public void LerFuncionario()
        {
            Console.WriteLine($"Nome: {Nome} \nTelefone: {Telefone}\nE-mail: {Email}\nCpf: {Cpf} \nGênero: {Genero}");
        }

    }
}
