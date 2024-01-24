using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public class AlugarVeiculoVielModelInput
    {
        public int ClienteId { get; set; }
        public string PlacaVeiculo { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public CartaoViewModel Cartao {  get; set; }

    }
    
}
