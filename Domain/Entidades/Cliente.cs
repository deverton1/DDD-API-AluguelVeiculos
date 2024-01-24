using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Habilitação { get; set; }
        public string DataNascimento { get; set; }
        public string Estado { get; set; }
    }
}
