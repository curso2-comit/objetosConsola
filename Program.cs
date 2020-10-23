using System;
using Carrera.Modelo;

namespace objetosConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nueva carrera!");
            Vehiculo vehiculo = new Vehiculo("Volkswagen", "Azul", 4);            
            vehiculo.Frenar();
            Console.WriteLine(vehiculo.ToString());
            // Bicicleta miBici = new Bicicleta();
            // miBici.color = "Rojo";
            // miBici.cambio = 1;
            Bicicleta miBici = new Bicicleta("Roja", 7);
            miBici.Marca = "Aurorita";
            miBici.Frenar();
            // Bicicleta otraBici = new Bicicleta();
            // otraBici.color = "Negra";
            // otraBici.cambio = 1;
            Bicicleta otraBici = new Bicicleta("Negra", 2);               
            
            //Console.WriteLine($"miBici: Color {miBici.color} Cambio actual {miBici.cambio} ");
            Console.WriteLine("miBici: " + miBici.ToString());
            //Console.WriteLine($"otraBici: Color {otraBici.color} Cambio {otraBici.cambio} ");
            Console.WriteLine("otraBici: " + otraBici.ToString());

            Bicicleta terceraBici = miBici;
            
            Console.WriteLine(terceraBici.Color);
            //Console.WriteLine($"terceraBici: Color {terceraBici.color} Cambio {terceraBici.cambio} ");
            //terceraBici.cambio++;
            terceraBici.SubirCambio();
            Console.WriteLine("terceraBici: " + otraBici.ToString());

            // Console.WriteLine($"miBici: Color {miBici.color} Cambio {miBici.cambio} ");
            // Console.WriteLine($"otraBici: Color {otraBici.color} Cambio {otraBici.cambio} ");
            // Console.WriteLine($"terceraBici: Color {terceraBici.color} Cambio {terceraBici.cambio} ");
            Console.WriteLine("miBici: " + miBici.ToString());
            Console.WriteLine("otraBici: " + otraBici.ToString());
            Console.WriteLine("terceraBici: " + otraBici.ToString());
        }
    }
}
