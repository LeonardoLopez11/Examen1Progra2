using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Granja granja = new Granja(precioParcelaBase: 50); 

            
            Console.WriteLine("Introduce la cantidad de dinero inicial:");
            decimal dineroInicial;
            while (!decimal.TryParse(Console.ReadLine(), out dineroInicial) || dineroInicial < 0)
            {
                Console.WriteLine("Cantidad inválida. Por favor, introduce un valor válido:");
            }
            granja.IntroducirDineroInicial(dineroInicial);
            Plantas planta1 = new Plantas("Tomate", 5, 20, 10);
            Plantas planta2 = new Plantas("Zanahoria", 7, 15, 8);
            Animal animal1 = new Animal("Vaca", 10, 2);
            Animal animal2 = new Animal("Gallina", 8, 3);
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n--- Menú Principal ---");
                Console.WriteLine("1. Comprar una nueva parcela de tierra");
                Console.WriteLine("2. Comprar una semilla");
                Console.WriteLine("3. Comprar un animal");
                Console.WriteLine("4. Mostrar plantas en la granja");
                Console.WriteLine("5. Mostrar animales en la granja");
                Console.WriteLine("6. Pasar turno");
                Console.WriteLine("7. Salir");
                Console.WriteLine("Seleccione una opción:");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        granja.ExpandirGranja();
                        break;
                    case "2":
                        MostrarOpcionesCompra("semillas", new Plantas[] { planta1, planta2 }, granja);

                        break;
                    case "3":
                        MostrarOpcionesCompra("animales", new Animal[] { animal1, animal2 }, granja);

                        break;
                    case "4":
                        granja.MostrarPlantas();
                        break;
                    case "5":
                        granja.MostrarAnimales();
                        break;
                    case "6":
                        granja.PasarTurno();
                        break;
                    case "7":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                }

            }

        }
        static void MostrarOpcionesCompra<T>(string tipo, T[] opciones, Granja granja) where T : class
        {
            Console.WriteLine($"Opciones de compra de {tipo}:");
            for (int i = 0; i < opciones.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {opciones[i]}");
            }
            Console.WriteLine("Seleccione una opción:");
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > opciones.Length)
            {
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida:");
            }

            if (typeof(T) == typeof(Plantas))
            {
                granja.AgregarPlanta(opciones[opcion - 1] as Plantas);
            }
            else if (typeof(T) == typeof(Animal))
            {
                granja.AgregarAnimal(opciones[opcion - 1] as Animal);
            }
            Console.WriteLine($"Has comprado {tipo}: {opciones[opcion - 1]}");
        }
    }
}
