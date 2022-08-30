using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Cartao_Credito
    {
        char Habilitar;
        bool Habilitado;
        String Senha;
        float Limite;
        float Saldo;
        double NumCartao;
        DateTime VencCartao;
        double DigVerificador;
        DateTime ValidadeCartao;


        public void BloqDesbloqCartao()
        {
            Console.WriteLine("Deseja bloquear ou desbloquear a função crédito do seu cartão?\nB-Bloquear\nD-Desbloquear");
            Habilitar = char.Parse(Console.ReadLine());

            if(Habilitar == 'D')
            {
                Habilitado = true;
                Console.WriteLine("Cartão desbloqueado com sucesso!");
            }else if(Habilitar == 'B')
            {
                Habilitado = false;
                Console.WriteLine("Cartão bloqueado com sucesso!");
            }

            //metodo para criar cartão de credito
        }
    }
}
