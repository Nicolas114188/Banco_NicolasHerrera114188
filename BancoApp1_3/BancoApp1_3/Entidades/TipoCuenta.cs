using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp1_3.Entidades
{
    class TipoCuenta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TipoCuenta()
        {
              Nombre = string.Empty;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
