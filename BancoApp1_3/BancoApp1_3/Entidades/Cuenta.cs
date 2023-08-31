using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp1_3.Entidades
{
    class Cuenta
    {
        public TipoCuenta TipoCuenta { get; set; }
        public double Saldo { get; set; }
        public string UltimoMovimiento { get; set; }
        public int CBU { get; set; }
        public Cuenta()
        {
            TipoCuenta TtipoCuenta = new TipoCuenta();
            UltimoMovimiento = string.Empty;
        }
    }
}
