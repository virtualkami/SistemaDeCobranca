using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeCobranca.Entities;
using System.Globalization;

namespace SistemaDeCobranca.Services
{
    internal class ServicoDeCompra
    {
        
        private IServicoDePagamento _servicoDePagamento;
        public ServicoDeCompra(IServicoDePagamento servicoDePagamento) { _servicoDePagamento = servicoDePagamento; }
        
        public void GerarCompra(Compra compra, int meses) {
            double valorParcela = compra.ValorTotal / meses;
            for (int i = 1; i <= meses; i++) { 
                DateTime data = compra.DataCompra.AddMonths(i);
                double atualizaParcela = valorParcela + _servicoDePagamento.GerarParcelas(valorParcela,i);
                double parcelaTotal = atualizaParcela + _servicoDePagamento.TaxaPagamento(atualizaParcela);
                compra.AdicionarFinanciamento(new Financiamento(data, parcelaTotal));
            }
        }
    }
}
