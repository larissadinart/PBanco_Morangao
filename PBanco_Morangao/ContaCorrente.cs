﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class ContaCorrente
    {
        public string Status { get; set; }
        public string Ag { get; set; }
        public String Senha { get; set; }
        public string NumConta { get; set; }
        public float Saldo { get; set; }
        public float Limite { get; set; }
        public float Total { get; set; }
        public CartaoCredito Cartao { get; set; }
        public Pessoa pessoa { get; set; }
        public ContaPoupanca Poup { get; set; }
        public String TipoConta { get; set; }
        public Cliente cliente { get; set; }
        public List<ContaCorrente> Extrato { get; set; } = new List<ContaCorrente>();
        public ContaCorrente()
        {
            Random contac = new Random();

            int opcao;
            float saldo, limite = 0;
            NumConta = contac.Next(1000, 5000).ToString();
            Ag = contac.Next(01, 05).ToString();
            Senha = Senha;
            Limite = limite;
            

            Console.Clear();
            Console.WriteLine("Cadastre uma senha de 6 dígitos: ");
            Senha = Console.ReadLine();
            Console.WriteLine("Gostaria de fazer o primeiro depósito?\n1-Sim\n2-Não ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o valor do depósito: ");
                    saldo = float.Parse(Console.ReadLine());
                    Saldo = saldo;
                    Limite = (saldo / 2);
                    Status = "Aguardando aprovação.";
                    Console.WriteLine($"\n>>>>>DADOS DA CONTA:<<<<<\n\nAgência: {Ag} \nConta: {NumConta}\nLimite: R$ {Limite}\nSaldo: R$ {Saldo}\nStatus: {Status}");
                    Console.WriteLine("\nAperte enter para continuar...");
                    break;

                case 2:
                    Console.WriteLine($"\n>>>>>DADOS DA CONTA:<<<<<\n\nAgência: {Ag} \nConta: {NumConta}\nLimite: R$ {Limite}\nSaldo: R$ {Saldo}\nStatus: {Status}");
                    Console.WriteLine("\nAperte enter para continuar...");
                    break;
            }
            Console.ReadKey();
        }
        public void MovimentarSaida(float valor)
        {

            float total = Saldo + Limite;

            if (Saldo + Limite < valor)
            {
                Console.WriteLine("Valor do saque maior do que valor disponível!");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine("Transação feito com sucesso!");
                Console.WriteLine($"Saldo: {Saldo}");
            }
        }
        public void MovimentarEntrada(float valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!");
            Console.WriteLine($"Saldo: {Saldo}");
        }
        public void SolicitarEmprestimo(float valor) //montar este metodo
        {

        }
        public bool PedirSenha()
        {
            string senha;

            Console.Write("Digite sua senha: ");
            senha = Console.ReadLine();
            if (Senha == senha)
                return true;
            else
                return false;
        }
        public void getExtrato()
        {
            Console.WriteLine("\n>>>EXTRATO<<<");
            foreach (var item in Extrato) Console.WriteLine(item);
        }

    }
}

