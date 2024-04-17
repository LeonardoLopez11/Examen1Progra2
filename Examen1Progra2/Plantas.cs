using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra2
{
     class Plantas
    {
        
        public string Nombre { get; set; }
        public int TiempoVida { get; set; } 
        public decimal ValorSemilla { get; set; } 
        public decimal ValorProducto { get; set; } 

        
        public Plantas(string nombre, int tiempoVida, decimal valorSemilla, decimal valorProducto)
        {
            Nombre = nombre;
            TiempoVida = tiempoVida;
            ValorSemilla = valorSemilla;
            ValorProducto = valorProducto;
        }

       
        public int CalcularCantidadProductos()
        {
            
            int n = CantidadPrimos(TiempoVida);
            return n;
        }

        
        private int CantidadPrimos(int n)
        {
            int count = 0;
            for (int i = 2; i <= n; i++)
            {
                if (NumeroPrimo(i))
                {
                    count++;
                }
            }
            return count;
        }

        private bool NumeroPrimo(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
