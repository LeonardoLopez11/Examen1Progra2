using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra2
{
    public abstract class AnimalB : InterfazAnimal
    {
        public string Nombre { get; set; }
        public int TiempoVida { get; set; }
        public int CantidadProductos { get; set; }

        public AnimalB(string nombre, int tiempoVida, int cantidadProductos)
        {
            Nombre = nombre;
            TiempoVida = tiempoVida;
            CantidadProductos = cantidadProductos;
        }

        public abstract int CalcularDescendientes();

        public abstract bool Reproducir();
    }
}
