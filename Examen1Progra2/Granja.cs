﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra2
{
    class Granja
    {
        public List<Plantas> Plantas { get; }
        public List<Animal> Animales { get; }
        public int ParcelasCompradas { get; private set; }
        private decimal precioParcelaBase;
        private decimal precioParcelaActual;
        public decimal Dinero { get; private set; }

        public Granja(decimal precioParcelaBase)
        {
            Plantas = new List<Plantas>();
            Animales = new List<Animal>();
            ParcelasCompradas = 0;
            this.precioParcelaBase = precioParcelaBase;
            this.precioParcelaActual = precioParcelaBase;
            Dinero = 0; 

        }

        public void IntroducirDineroInicial(decimal cantidad)
        {
            Dinero = cantidad;
            Console.WriteLine($"Se ha introducido {cantidad} monedas de dinero inicial.");
        }


        public void AgregarPlanta(Plantas planta)
        {
            Plantas.Add(planta);
        }

        
        public void AgregarAnimal(Animal animal)
        {
            Animales.Add(animal);
        }

       
        public void MostrarPlantas()
        {
            Console.WriteLine("Plantas en la granja:");
            foreach (var planta in Plantas)
            {
                Console.WriteLine($"- {planta.Nombre}. Tiempo de vida: {planta.TiempoVida}");
                if (planta.TiempoVida == 0)
                {
                    Console.WriteLine($"   (Listo para cosechar: puedes recolectar {planta.CalcularCantidadProductos()} productos)");
                }
            }
        }

        
        public void MostrarAnimales()
        {
            Console.WriteLine("Animales en la granja:");
            foreach (var animal in Animales)
            {
                Console.WriteLine($"- {animal.Nombre}. Tiempo de vida: {animal.TiempoVida}");
                if (animal.TiempoVida == 0)
                {
                    Console.WriteLine($"   (Listo para recolectar: puedes recolectar {animal.CantidadProductos} productos)");
                }
            }
        }

        
        public void ExpandirGranja()
        {
            decimal precioParcelaActual = precioParcelaBase + (ParcelasCompradas * 10);
            Console.WriteLine($"El precio de la parcela actual es: {precioParcelaActual}");
            Console.WriteLine("¿Quieres comprar una nueva parcela? (Sí/No)");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta == "si")
            {
                Console.WriteLine($"Ha comprado una nueva parcela por {precioParcelaActual} monedas.");
                ParcelasCompradas++;
            }
            else if (respuesta != "no")
            {
                Console.WriteLine("Respuesta inválida. Por favor, responda 'Sí' o 'No'.");
            }
        }
        public void PasarTurno()
        {
            Console.WriteLine("Pasar turno...");

            
            foreach (var planta in Plantas)
            {
                if (planta.TiempoVida == 0)
                {
                    Console.WriteLine($"¡Cosechaste una {planta.Nombre} y obtuviste {planta.CalcularCantidadProductos()} productos!");
                    Plantas.Remove(planta);
                    break; 
                }
                planta.TiempoVida--; 
            }

            
            foreach (var animal in Animales)
            {
                if (animal.TiempoVida == 0)
                {
                    Console.WriteLine($"¡El {animal.Nombre} ha dado {animal.CantidadProductos} productos!");
                }
                animal.TiempoVida--; 
            }

            
            MostrarPlantas();
            MostrarAnimales();
        }
    }
}
