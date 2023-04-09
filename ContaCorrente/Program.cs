
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace ContaCorrente
{

    internal partial class Program
    {
        static void Main(string[] args)
        {
            var conta1 = new ContaCorrente("Alisson Scopel", 2000, 2500, false , 1);
            var conta2 = new ContaCorrente("Gustavo Ramos", 1000 , 1500, true , 2);

            conta1.Saque(500);

            conta1.Deposito(300);          

            conta1.Saque(200);

            conta2.Tranferencia(200, conta1);

            conta2.Saque(500);

            Console.WriteLine("Conta 2 Extrato:\n");
            Console.WriteLine("Valor inicial 1000");
            conta2.ExibirExtrato();
            Console.WriteLine("Valor Final: " + conta2.VisualizarSaldo());

            Console.WriteLine("-----------------------------------------------------------------------------\n");
            
            Console.WriteLine("Conta 1 Extrato: \n");
            Console.WriteLine("Valor inicial 2000");
            conta1.ExibirExtrato();
            Console.WriteLine("Valor Final: " + conta1.VisualizarSaldo());
        }
    }
}