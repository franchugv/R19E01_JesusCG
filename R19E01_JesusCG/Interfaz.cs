using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R19E01_JesusCG
{
    /// <summary>
    /// Métodos para la Interacción Aplicación - Usuario Final
    /// </summary>
    public static class Interfaz
    {
        public static void MenuPrincipal()
        {
            // TODO: Implementación del Menú Principal
            Console.WriteLine("");
        }

        public static void MostrarListadoCompleto(Vehiculo[] lista)
        {

            Console.WriteLine("MARCA\tMODELO\tTIPO\tCOMBUSTIBLE\tESTADO");

            foreach (Vehiculo coche in lista)
            {
                Console.WriteLine($"{coche.Marca}\t{coche.Modelo}\t{coche.TVehiculo}\t{coche.Combustible}\t{coche.Estado}");

            }

            Console.Write("Pulse Enter para Continuar......");
            Console.ReadLine();
        }

        public static Vehiculo LeerVehiculo()
        {
            // RECURSOS
            Vehiculo coche;
            float precioCoche = 0;

            // string mensajeError = "";
            // bool esValido;

            coche = new Vehiculo();

            // CAPTURAR MARCA


            //CAPTAR MODELO


            // CAPTAR PRECIO

            // esValido = CaptarPrecio(coche, ref precioCoche, ref mensajeError);
            CaptarPrecio(coche, ref precioCoche);

            return coche;

        }

        // Devuelve 4 datos 
        // private static bool CaptarPrecio(Vehiculo coche, ref float precioCoche, ref string mensajeError)
        // private static void CaptarPrecio(Vehiculo coche, ref float precioCoche, ref string mensajeError)

        private static void CaptarPrecio(Vehiculo coche, ref float precioCoche)
        {
            // RECURSOS
            string mensajeError = "";
            bool esValido;

            // ENTRADA
            do
            {
                // RESET
                esValido = true; // Se supone que no hay errores.

                Console.Write("Introduzca el precio del vehiculo: ");
                try
                {
                    precioCoche = Convert.ToSingle(Console.ReadLine());

                    // Asignar a la propiedad objeto
                    coche.PrecioContado = precioCoche;
                }
                catch (FormatException formato)
                {
                    esValido = false;
                    mensajeError = "ERROR: No se ha introducido un número";
                }
                catch (OverflowException tipo)
                {
                    esValido = false;
                    mensajeError = "ERROR: Se ha sobrepasado el límite del tipo float";
                }
                catch (Exception objeto) // Todas las demás excepciones
                {
                    esValido = false;
                    mensajeError = $"ERROR: {objeto.Message}";
                }
                finally
                {
                    if (!esValido)
                    {
                        Console.WriteLine($"{mensajeError}");
                    }
                }
            } while (!esValido);
        }
    }
}
