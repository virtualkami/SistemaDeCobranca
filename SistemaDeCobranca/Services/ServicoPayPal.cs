using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeCobranca.Entities;
using System.Globalization;

namespace SistemaDeCobranca.Services
{
    internal class ServicoPayPal:IServicoDePagamento
    {
        public double TaxaPagamento(double valor) { return (valor*0.02); }
        public double GerarParcelas(double valor, int meses) { return (valor*0.01*meses); }
    }
}
