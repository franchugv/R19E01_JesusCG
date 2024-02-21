using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R19E01_JesusCG
{
    /// <summary>
    /// Métodos que facilitan el procesamiento de los datos de la Aplicación
    /// </summary>
    public static class LogicaNegocio
    {

        /// <summary>
        /// Método de Carga de la Lista de Vehículos
        /// </summary>
        /// <param name="lista">Lista de Vehículos a cargar</param>
        public static void CargarListaVehiculos(Vehiculo[] lista)
        {
            // VARIABLES
            Vehiculo coche;

            // Instanciar el objeto 1
            coche = new Vehiculo("Ferrari", "Ferr40");
            // Proporcionar el resto de los datos
            coche.TVehiculo = TipoVehiculo.Turismo;
            coche.Combustible = TipoCombustible.Gasolina;
            coche.Estado = Estados.Nuevo;
            coche.Matriculacion = new DateTime(2023, 12, 5);
            coche.PrecioContado = 80000;

            // Asignarlo al array
            lista[0] = coche;


            // Instanciar el objeto 2
            coche = new Vehiculo("Maseratti", "Murciélago");
            // Proporcionar el resto de los datos
            coche.TVehiculo = TipoVehiculo.Turismo;
            coche.Combustible = TipoCombustible.Gasolina;
            coche.Estado = Estados.Nuevo;
            coche.Matriculacion = new DateTime(2024, 1, 30);
            coche.PrecioContado = 100000;

            // Asignarlo al array
            lista[1] = coche;

            // Instanciar el objeto 3
            coche = new Vehiculo("Porsche", "Carrera");
            // Proporcionar el resto de los datos
            coche.TVehiculo = TipoVehiculo.Turismo;
            coche.Combustible = TipoCombustible.Diesel;
            coche.Estado = Estados.Nuevo;
            coche.Matriculacion = new DateTime(2020, 10, 15);
            coche.PrecioContado = 65000;

            // Asignarlo al array
            lista[2] = coche;

            // Instanciar el objeto 4
            coche = new Vehiculo("IVECO", "F4000");
            // Proporcionar el resto de los datos
            coche.TVehiculo = TipoVehiculo.Camion;
            coche.Combustible = TipoCombustible.Hibrido;
            coche.Estado = Estados.Nuevo;
            coche.Matriculacion = new DateTime(2018, 8, 8);
            coche.PrecioContado = 25000;

            // Asignarlo al array
            lista[3] = coche;

            // Instanciar el objeto 5
            coche = new Vehiculo("Mercedes", "Vito");
            // Proporcionar el resto de los datos
            coche.TVehiculo = TipoVehiculo.Furgoneta;
            coche.Combustible = TipoCombustible.Electrico;
            coche.Estado = Estados.Nuevo;
            coche.Matriculacion = new DateTime(2021, 9, 14);
            coche.PrecioContado = 12000;

            // Asignarlo al array
            lista[4] = coche;

        }
    }
}
