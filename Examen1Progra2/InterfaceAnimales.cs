using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra2
{
    public interface InterfazAnimal
    {
        string Nombre { get; }
        int TiempoVida { get; }
        int CantidadProductos { get; }
        int CalcularDescendientes();
        bool Reproducir();
    }
}
