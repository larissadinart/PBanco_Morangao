using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Cliente : Pessoa
    {
        bool Habilitado;
        char Habilitar;
        bool Estudante;
        char Est;
        float Renda;
        String TipoConta;

        public void CadastraCliente()
        {
            Console.WriteLine("Habilitar cliente?\nS-Sim\n N-Não");
            Habilitar = char.Parse(Console.ReadLine());
            if (Habilitar == 'S') {
                Habilitado = true;
            }else if(Habilitar == 'N')
            {
                Habilitado = false;
            }
            Console.WriteLine("Cliente é estudante?\nS-Sim\n N-Não");
            Est = char.Parse(Console.ReadLine());
            if (Habilitar == 'S')
            {
                Habilitado = true;
            }
            else if (Habilitar == 'N')
            {
                Habilitado = false;
            }
            Console.WriteLine("Digite sua renda mensal: ");
            Renda = float.Parse(Console.ReadLine());

            if(Renda >= 10000)
            {
                TipoConta = "Conta Vip";
            }else if(Renda >= 20000 && Renda < 10000)
            {
                TipoConta = "Conta Normal";
            }
            else if(Renda < 2000)
            {
                TipoConta = "Conta Universitária";
            }
        }

    }
}
