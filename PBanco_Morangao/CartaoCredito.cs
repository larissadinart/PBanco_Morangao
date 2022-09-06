using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class CartaoCredito
    {
        public char HabilitarCredito { get; set; }
        public bool Habilitado { get; set; }
        public String Senha { get; set; }
        public float Limite { get; set; }
        public float Saldo { get; set; }
        public double NumCartao { get; set; }
        public DateTime VencFatura { get; set; }
        public double DigVerificador { get; set; }
        public DateTime ValidadeCartao { get; set; }


        public CartaoCredito() // rever
        {

        }
        public void BloqDesbloqCartao()
        {
            Console.WriteLine("Deseja bloquear ou desbloquear a função crédito do seu cartão?\nB-Bloquear\nD-Desbloquear");

            HabilitarCredito = char.Parse(Console.ReadLine());

            if (HabilitarCredito == 'D')
            {
                Habilitado = true;
                Console.WriteLine("Cartão desbloqueado com sucesso!");
            }
            else if (HabilitarCredito == 'B')
            {
                Habilitado = false;
                Console.WriteLine("Cartão bloqueado com sucesso!");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                BloqDesbloqCartao();
            }


        }
        public override string ToString()
        {
            return $"Número do Cartão: {NumCartao}\n\nData vencimento da fatura: {VencFatura}\n";
        }
    }
}
