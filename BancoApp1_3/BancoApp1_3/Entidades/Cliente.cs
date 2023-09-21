using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp1_3.Entidades
{
    class Cliente
    {
        public int NroCliente { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public List<Cuenta> Cuentas { get; set; }

        public DateTime FechaBaja { get; set; }
        public Cliente()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Cuentas = new List<Cuenta>();
        }
        public void AgregarCuenta(Cuenta cuenta)
        {
            Cuentas.Add(cuenta);
        }
        public void QuitarCuenta(int posicion)
        {
            Cuentas.RemoveAt(posicion);
        }
    }
}
