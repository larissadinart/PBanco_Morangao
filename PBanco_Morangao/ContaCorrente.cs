using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class ContaCorrente
    {
        public bool Habilitada { get; set; }
        public char Habilitar { get; set; }
        public int Ag { get; set; }
        public String Senha { get; set; }
        public double NumConta { get; set; }
        public float Saldo { get; set; }
        public float Limite { get; set; }
        public double Cartao { get; set; }
        public String TipoConta { get; set; }
        public Cliente cliente { get; set; }
        public List<ContaCorrente> Extrato { get; set; } = new List<ContaCorrente>();
        /*
         * movimentacao
         *   valor
         *   tipo
         *      pagamento, saque, transferencia, deposito
         *   data(opcional)
         */


        public ContaCorrente()
        {
            
        }
        public void BuscarAgencia(int ag ,double conta, int senha)
        {

        }
        //buscar agencia e conta


    }
}
