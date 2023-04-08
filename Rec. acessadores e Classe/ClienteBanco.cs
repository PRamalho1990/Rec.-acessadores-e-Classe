using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rec.acessadores_e_Classe
{
    class ClienteBanco
    {
        private int Conta { get;  set; }
        public string Nome  { get; set; }

        public double ValorInicialdeDeposito { get; set; }


        public ClienteBanco()
        {

        }

        public ClienteBanco(int conta, string nome, double valorinicialdedeposito)
        {
            Conta += conta;
            Nome += nome;
            ValorInicialdeDeposito += valorinicialdedeposito;
        }

        

        public void AumentarValordeDeposito()
        {
             ValorInicialdeDeposito += ValorInicialdeDeposito + 200.00;
        }



        public override string ToString()
        {
            return "Dados da Conta:" +
                " Conta:" + Conta +
                " Nome: " + Nome +
                " Valor do Deposito:  R$ " + ValorInicialdeDeposito.ToString("f2", CultureInfo.InvariantCulture) + " Reais)";
        }




    }

}
