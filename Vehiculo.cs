using System;
namespace Carrera.Modelo
{
    class Vehiculo
    {
        public string Marca { get; set; }
        public string Color { get; set;}
        public int CantidadRuedas { get; protected set; }        

        public Vehiculo(){

        }

        public Vehiculo(string color, int cantidadRuedas)
        {            
            Color = color;
            CantidadRuedas = cantidadRuedas;
        }

        public Vehiculo(string marca, string color, int cantidadRuedas)
        {
            Marca = marca;
            Color = color;
            CantidadRuedas = cantidadRuedas;
        }

        public void Frenar()
        {
            Console.WriteLine($"Freno el vehículo: {Marca} {Color}.");
        }
    }
}