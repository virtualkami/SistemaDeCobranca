using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeCobranca.Services;
using System.Globalization;

namespace SistemaDeCobranca.Entities
{
    internal class Compra
    {
        public int NumeroCompra { get; set; }
        public DateTime DataCompra { get; set; }
        public double ValorTotal { get; set; }
        public List<Financiamento> Lista { get; set; }

        public Compra(int numeroCompra, DateTime dataCompra, double valorTotal)
        {
            NumeroCompra = numeroCompra;
            DataCompra = dataCompra;
            ValorTotal = valorTotal;
            Lista = new List<Financiamento>();
        }
        public void AdicionarFinanciamento(Financiamento financiamento) { Lista.Add(financiamento); }
    }
}
