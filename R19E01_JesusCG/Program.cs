namespace R19E01_JesusCG
{
    internal class Program
    {
        /// <summary>
        /// Controlador Principal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // CONSTANTES
            const int TAMANIO = 5;

            // VARIABLES
            Vehiculo[] listaVehiculos;

            Vehiculo automovil;

            // EJEMPLO HERENCIA Y TRATAMENIENTO DE ERRORES - EXCEPCIONES

            automovil = Interfaz.LeerVehiculo();



            int opcionMenu = 0;

            // INICIALIZACIÓN
            // Instanción (Reserva de Memoria) para los cinco elementos del array
            listaVehiculos = new Vehiculo[TAMANIO];

            // Proceso: Carga de los coches en la lista
            LogicaNegocio.CargarListaVehiculos(listaVehiculos);
            
        

        }
    }
}
