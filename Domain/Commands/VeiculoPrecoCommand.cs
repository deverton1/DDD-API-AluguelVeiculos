using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands
{
    public class VeiculoPrecoCommand
    {
        public int TipoVeiculo { get; set; }
        public decimal Preco { get; set; }
        public int PeriodoMaximoAluguel { get; set; }
    }
}
