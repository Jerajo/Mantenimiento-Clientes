using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejem_Mantenimiento_Personas
{
    /// <summary>
    /// Classe Cliente: Modelo de datos para los clientes.
    /// </summary>
    class Cliente
    {
        private string _nombre, _apellido, _fechaNacimiento;
        /// <summary>
        /// Constructor sin parametros para la clase cliente.
        /// </summary>
        public Cliente() { }
        /// <summary>
        /// Constructor(); con parametros para la clase cliente. 
        /// </summary>
        /// <param name="nombre">String Nombre: Nombre del cliente.</param>
        /// <param name="apellido">String Apellido:  Apellido del cliente.</param>
        /// <param name="fechaNacimiento">String FechaNacimiento:  Fecha de nacimiento del cliente.</param>
        public Cliente(string nombre, string apellido, string fechaNacimiento)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNacimiento = fechaNacimiento;
        }
        /// <summary>
        /// Setter y Getter para el atributo int ID del cliente.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Setter y Getter para el atributo string Nombre del cliente.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        /// <summary>
        /// Setter y Getter para el atributo string Apellido del cliente.
        /// </summary>
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        /// <summary>
        /// Setter y Getter para el atributo string FechaNacimiento del cliente.
        /// </summary>
        public string FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
    }
}
