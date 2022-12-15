using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeCobranca.Entities;
using System.Globalization;

namespace SistemaDeCobranca.Services
{
    interface IServicoDePagamento
    {
        double TaxaPagamento(double valor);
        double GerarParcelas(double valor, int meses);
    }
}
