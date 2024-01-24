using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public class CartaoViewModel
    {
        public string NomeProprietario { get; set; }
        public long Numero { get; set; }
        public int CVV { get; set; }
        public DateTime DataValidacao { get; set; }
    }
}
