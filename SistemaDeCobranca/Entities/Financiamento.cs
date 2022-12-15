using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeCobranca.Services;
using System.Globalization;

namespace SistemaDeCobranca.Entities
{
    internal class Financiamento
    {
        public DateTime DataDeVencimento { get; set; }
        public double Valor { get; set; }
        public Financiamento(DateTime dataDeVencimento, double valor)
        {
            DataDeVencimento = dataDeVencimento;
            Valor = valor;
        }
        public override string ToString()
        {
            return DataDeVencimento.ToString("dd/MM/yyyy")+" - " + Valor.ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
