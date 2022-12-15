using System.Globalization;
using SistemaDeCobranca.Entities;
using SistemaDeCobranca.Services;
namespace SistemaDeCobranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { Console.WriteLine("          Informe os dados da compra");
                Console.WriteLine();
                Console.Write("Compra Número: ");int numeroCompra = int.Parse(Console.ReadLine());
                Console.Write("Data: ");DateTime dataCompra = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
                Console.Write("Valor: ");double valorTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Parcelas: ");int meses = int.Parse(Console.ReadLine());
                
                Compra compra=new Compra(numeroCompra,dataCompra,valorTotal);
                ServicoDeCompra servicoDeCompra = new ServicoDeCompra(new ServicoPayPal());
                servicoDeCompra.GerarCompra(compra,meses);
                Console.WriteLine();
                Console.WriteLine("Financiamento:");

                foreach (Financiamento financiamento in compra.Lista) { Console.WriteLine(financiamento); }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}