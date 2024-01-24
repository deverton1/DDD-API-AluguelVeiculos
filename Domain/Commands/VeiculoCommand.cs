using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands
{
    public class VeiculoCommand
    {
        public int VeiculoId { get; set; }
        public string Placa { get; set; }
        public int AnoFabricacao { get; set; }
        public ETipoVeiculo TipoVeiculo { get; set; }
        public string Estado { get; set; }
        public EMontadora Montadora { get; set; }
        public bool Alugado { get; set; }
    }
}
