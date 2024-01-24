using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public class SimularVeiculoAluguelViewModel
    {
        public decimal ValorTotal { get; set; }
        public decimal ValorDiaria { get; set; }
        public ETipoVeiculo TipoVeiculo { get; set; }
        public decimal Taxas { get; set; }
        public int TotalDiasSimulado { get; set; }

    }
}
