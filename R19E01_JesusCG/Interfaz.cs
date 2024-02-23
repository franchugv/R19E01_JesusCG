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


            // string mensajeError = "";
            // bool esValido;

            coche = new Vehiculo();

            // CAPTURAR MARCA
            CaptarMarca(coche);

            //CAPTAR MODELO
            CaptarModelo(coche);

            // CAPTAR PRECIO

            // esValido = CaptarPrecio(coche, ref precioCoche, ref mensajeError);
            CaptarPrecio(coche);

            return coche;

        }

        // Devuelve 4 datos 
        // private static bool CaptarPrecio(Vehiculo coche, ref float precioCoche, ref string mensajeError)
        // private static void CaptarPrecio(Vehiculo coche, ref float precioCoche, ref string mensajeError)

        private static void CaptarPrecio(Vehiculo coche)
        {
            // RECURSOS
            string mensajeError = "";
            bool esValido;
            float precioCoche = 0;

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
                    mensajeError = "ERROR:" + formato.Message;
                }
                catch (LongitudMaximaException tipo)
                {
                    esValido = false;
                    mensajeError = "ERROR:" + tipo.Message;
                }

                catch (LongitudMinimaException tipo)
                {
                    esValido = false;
                    mensajeError = "ERROR:" + tipo.Message;
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

        private static void CaptarMarca(Vehiculo coche)
        {
            // RECURSOS
            string mensajeError = "";
            bool esValido;

            // ENTRADA
            do
            {
                // RESET
                esValido = true; // Se supone que no hay errores.

                Console.Write("Introduzca la marca del vehiculo: ");
                try
                {


                    // Asignar a la propiedad objeto
                    coche.Marca = Console.ReadLine();
                }

                catch (CadenaVaciaException formato)
                {
                    esValido = false;
                    mensajeError = formato.Message;
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

        private static void CaptarModelo(Vehiculo coche)
        {
            // RECURSOS
            string mensajeError = "";
            bool esValido;

            // ENTRADA
            do
            {
                // RESET
                esValido = true; // Se supone que no hay errores.

                Console.Write("Introduzca el modelo del vehiculo: ");
                try
                {


                    // Asignar a la propiedad objeto
                    coche.Marca = Console.ReadLine();
                }
                catch (CadenaVaciaException formato)
                {
                    esValido = false;
                    mensajeError = formato.Message;
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
