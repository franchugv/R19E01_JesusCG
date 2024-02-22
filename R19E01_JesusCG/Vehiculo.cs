using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R19E01_JesusCG
{
    /// <summary>
    /// Definición de la Enumeración para el Tipo de Vehículo
    /// </summary>
    public enum TipoVehiculo : byte { Turismo, Furgoneta, Camion };

    /// <summary>
    /// Definición de la Enumeración para el Combustible
    /// </summary>
    public enum TipoCombustible : byte { Diesel, Gasolina, Hibrido, Electrico };

    public enum Estados : byte { Nuevo, Ocasion, SegundaMano };

    public class Vehiculo
    {
        // CONSTANTES
        //const string TIPOS_VEHICULOS = "Turismo Furgoneta Camión";
        //const string COMBUSTIBLES = "Diésel Gasolina Híbrido Eléctrico";
        //const string ESTADOS = "Nuevo Ocasión Segunda Mano";
        const int LONG_MAX_MARCA = 20;
        const int LONG_MIN_MARCA = 3;
        const int LONG_MAX_MODELO = 25;
        const int LONG_MIN_MODELO = 4;
        const float PRECIO_MIN = 1000.0f;
        const float PRECIO_MAX = 100000.0f;
        const int ANTIGUEDAD_MAX = 10;
        const float DESCUENTO = 0.1f;

        // MIEMBROS
        private string _marca;
        private string _modelo;
        //private string _tipo;
        private TipoVehiculo _tipo;
        //private string _combustible;
        private TipoCombustible _combustible;
        //private string _estado;
        private Estados _estado;
        private float _precio;
        private DateTime _matriculacion;

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto: Inicializa los miembros de la clase
        /// </summary>
        public Vehiculo()
        {
            _marca = "Desconocido";
            _modelo = "Desconocido";
            //_tipo = "Turismo";
            _tipo = TipoVehiculo.Turismo;
            //_combustible = "Diésel";
            _combustible = TipoCombustible.Diesel;
            _estado = Estados.Nuevo;
            _precio = 0;
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="marca">Marca del vehículo</param>
        /// <param name="modelo">Modelo del vehiculo</param>
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            //_tipo = "Turismo";
            _tipo = TipoVehiculo.Turismo;
            //_combustible = "Diésel";
            _combustible = TipoCombustible.Diesel;
            _estado = Estados.Nuevo;
            _precio = 0;
        }
        #endregion

        #region PROPIEDADES

        /// <summary>
        /// Marca del vehículo
        /// </summary>
        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                // Comprobación de requisitos de la cadena
                try
                {
                    ValidarCadena(value, LONG_MIN_MARCA, LONG_MAX_MARCA);
                }
                catch (Exception error)
                {
                    throw new Exception("Marca: " + error.Message);
                }

                _marca = value;
            }
        }

        /// <summary>
        /// Modelo del vehículo
        /// </summary>
        public string Modelo
        {
            get
            {
                return _modelo;
            }
            set
            {
                // Comprobación de requisitos de la cadena
                try
                {
                    ValidarCadena(value, LONG_MIN_MODELO, LONG_MAX_MODELO);
                }
                catch(Exception error)
                {
                    throw new Exception("Modelo: " + error.Message);
                }

                _modelo = value;
            }
        }

        /// <summary>
        /// Precio del vehículo al contado
        /// </summary>
        public float PrecioContado
        {
            get
            {
                return _precio;
            }
            set
            {
                // Validación del Precio
                ValidarPrecio(value);

                _precio = value;
            }
        }

        /// <summary>
        /// Precio del vehículo financiado
        /// </summary>
        public float PrecioFinanciado
        {
            get
            {
                return CalcularPrecioFinanciado();
            }
        }

        /// <summary>
        /// Tipo de vehículo
        /// </summary>
        public TipoVehiculo TVehiculo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }

        /// <summary>
        /// Tipo de combustible del vehículo
        /// </summary>
        public TipoCombustible Combustible
        {
            get { return _combustible; }
            set
            {
                _combustible = value;
            }
        }

        /// <summary>
        /// Estado del vehículo
        /// </summary>
        public Estados Estado
        {
            get { return _estado; }
            set
            {
                _estado = value;

            }
        }

        /// <summary>
        /// Fecha de matriculación del vehículo
        /// </summary>
        public DateTime Matriculacion
        {
            get
            {
                return _matriculacion;
            }
            set
            {
                
                // Comprobación de la Fecha
                if (EdadVehiculo(value) > ANTIGUEDAD_MAX) throw new Exception($"El vehículo supera los {ANTIGUEDAD_MAX} años de antigüedad");

                _matriculacion = value;
            }
        }

        #endregion

        #region MÉTODOS

        /// <summary>
        /// Cálculo del precio financiado del Vehículo
        /// </summary>
        /// <returns>Precio Financiado</returns>
        private float CalcularPrecioFinanciado()
        {
            // VARIABLES LOCALES
            float precioF = 0;

            // PROCESO
            precioF = PrecioContado * (1 - DESCUENTO);

            // SALIDA - Método
            return precioF;
        }

        /// <summary>
        /// Validación de las cadenas de entrada
        /// </summary>
        /// <param name="cadena">Cadena a validar</param>
        /// <param name="tamMin">Longitud mínima</param>
        /// <param name="tamMax">Longitud máxima</param>
        /// <exception cref="Exception">Errores de Validación</exception>
        private void ValidarCadena(string cadena, int tamMin, int tamMax)
        {
            // Excepción personalizada
            if (String.IsNullOrEmpty(cadena)) throw new CadenaVaciaException("");
            if (cadena.Length < tamMin) throw new Exception($"Longitud inferior a {tamMin} caracteres");
            if (cadena.Length > tamMax) throw new Exception($"Longitud superior a {tamMax} caracteres");

            // TODO: Comprobación de si tiene caracteres especiales
            
        }

        /// <summary>
        /// Validación del precio del vehículo
        /// </summary>
        /// <param name="valor">Precio del coche</param>
        /// <exception cref="Exception">Errores del precio del coche</exception>
        private void ValidarPrecio(float valor)
        {
            if (valor < PRECIO_MIN) throw new Exception($"El precio del vehículo tiene que ser superior a {PRECIO_MIN} Euros");
            if (valor > PRECIO_MAX) throw new Exception($"El precio del vehículo tiene que ser inferior a {PRECIO_MAX} Euros");
        }

        /// <summary>
        /// Cálculo de la Edad de un Vehículo
        /// </summary>
        /// <param name="fecha">Fecha de Matriculación</param>
        /// <returns>Edad del vehículo</returns>
        private int EdadVehiculo(DateTime fecha)
        {
            // VARIABLES
            int edad = 0;
            DateTime fechaActual = DateTime.Now;

            // PROCESO
            // Comprobación de Fecha en el Futuro
            if (fecha > fechaActual) throw new Exception("La fecha de matriculación no puede ser posterior a la fecha actual");

            edad = fechaActual.Year - fecha.Year;   // Obtención del número de años

            // Comprobación de si se ha llegado a cumplir ese año
            if (fechaActual.Month < fecha.Month) edad--;    // Meses
            if ((fechaActual.Month == fecha.Month) && (fechaActual.Day < fecha.Day)) edad--;  // Días

            // SALIDA
            return edad;
        }

        #endregion

        public override string ToString()
        {
            string cadena = "";

            cadena = $"Marca: {Marca}\t Modelo: {Modelo}\n";
            cadena += $"Tipo de Vehículo {TVehiculo}  Combustible: {Combustible}\n";
            cadena += $"Estado: {Estado}\n";
            cadena += $"Precio Contado: {PrecioContado}\t Precio Fincanciado: {PrecioFinanciado}\n";
            
          
            return cadena;
        }

    }



    // EXCEPCIONES PERSONALIZADAS PARA LA CLASE VEHÍCULO
    public class CadenaVaciaException : Exception
    {
        // Constructores para la clase

        public CadenaVaciaException() : base("Cadena Vacía"){}
        // Constructor por parametro
        public CadenaVaciaException(string mensaje) : base(mensaje){}
    }

}
