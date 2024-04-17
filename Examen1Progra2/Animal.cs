using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra2
{
     class Animal : AnimalB
    {
        private int cantidadAnimales;

        public Animal(string nombre, int tiempoVida, int cantidadProductos)
            : base(nombre, tiempoVida, cantidadProductos)
        {
            this.cantidadAnimales = 1; // Inicialmente tenemos un animal
        }

        public override int CalcularDescendientes()
        {
            
            return Fibonacci(TiempoVida);
        }

        private int Fibonacci(int n)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public override bool Reproducir()
        {
            
            if (cantidadAnimales >= 2)
            {
                
                cantidadAnimales += CalcularDescendientes();
                return true; 
            }
            else
            {
                return false; 
            }
        }
    }
}
