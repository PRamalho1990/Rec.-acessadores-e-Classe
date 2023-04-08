using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rec.acessadores_e_Classe
{
    class Program
    {
        static void Main(string[] args)

            
        {
            ClienteBanco conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Hávera depósito inicial? S/N: ");
            char resposta = char.Parse(Console.ReadLine());

            


            
            


            if (resposta== 'S')


            {
                Console.WriteLine("Entre com o Valor inicial do Deposíto: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Valor do Deposito:  R$  " + saldo .ToString("F2", CultureInfo.InvariantCulture)  + " Reais ");
                Console.WriteLine();
              

                conta = new ClienteBanco(numero,nome,saldo);

                Console.WriteLine("Dados da Conta: " + conta);

            }

            else 
            {
                conta = new ClienteBanco(numero, nome);

                Console.WriteLine(conta);

            }


            Console.Write("Entre com outro valor: ");
            double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o Valor do Saque: ");
            double saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            conta.Saque(saque);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine(conta);

            Console.ReadKey();

            
            




           









            
            
            
            

            

            Console.ReadKey();
        }
    }
}
