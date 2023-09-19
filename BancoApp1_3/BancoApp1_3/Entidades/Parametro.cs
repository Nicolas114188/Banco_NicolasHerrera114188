using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp1_3.Entidades
{
    class Parametro
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }
        public Parametro(string nom,object val)
        {
            Nombre = nom;
            Valor = val;
        }
    }
}
