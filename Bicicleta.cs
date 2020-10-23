namespace Carrera.Modelo
{
    /// <summary>
    /// Representa a una bicicleta de la carrera
    /// </summary>
    class Bicicleta: Vehiculo
    {
        //string color; //ya lo tengo por Vehiculo
        int velocidad;
        int cambio;
        int cantidadCambios;
        private bool estaRota;

        /// <summary>
        /// Crear una nueva bicicleta 
        /// </summary>
        /// <param name="color">Color de la bici</param>
        /// <param name="cantidadCambios">Cantidad de Cambios de la bici</param>
        public Bicicleta(string color, int cantidadCambios) 
            :base(color, 2)           
        {
            // this.Color = color;  //no hace falta ponerlo acá porque se llama al constructor de la clase base
            // this.CantidadRuedas = 2;  //no hace falta ponerlo acá porque se llama al constructor de la clase base
            this.cantidadCambios = cantidadCambios;   
            this.cambio = 1;        
        }

        /// <summary>
        /// Se crea una bicicleta sin cambios y sin color
        /// </summary>
        public Bicicleta()
        {
            Color = "Sin especificar";
            CantidadRuedas = 2;
            cantidadCambios = 1;
            cambio = 1;   
            estaRota = false; //el bool inicialmente arranca en false. Esto no es necesario        
        }


        // public string Color()
        // {
        //     return this.color;
        // }
        
        // public string Color
        // {
        //     get
        //     {
        //         return this.color;
        //     }
        // }


        public void SubirCambio()
        {
            if(this.cambio < this.cantidadCambios)
            {
                this.cambio++;
            }            
        }

        public override string ToString()
        {
            return $"Color: {this.Color} Cambio actual: {this.cambio}. Velocidad: {velocidad}";
        }
    }
}