using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejem_Mantenimiento_Personas
{
    /// <summary>
    /// Class Conexion. Gestiona la conexion y transferencia de datos a la base de datos.
    /// </summary>
    class Conexion
    {
        private SqlCommand Command;
        private SqlConnection Connection;
        private SqlDataReader DataReader;

        public Conexion()
        {
            try
            {
                this.Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Cursos\Desarrollo Profesional\Programacion en C#\C#\Practica Lavoratorio\24 Ejem_Mantenimiento_Personas\Ejem_Mantenimiento_Personas\Clientes.mdf';Integrated Security=True");
                this.Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error de conexion a la base de datos" + ex.ToString());
            }
        }
        /// <summary>
        /// Verifica la existencia de un cliente en la base de datos.
        /// </summary>
        /// <param name="id">Id del cliente que se desea verificar.</param>
        /// <returns>Retorna un bool. True si existe / False si no existe.</returns>
        public bool ClienteRegistrado(int id)
        {
            int contador = 0;
            try
            {
                this.Command = new SqlCommand("select * from TbPersonas where id=" + id + "", this.Connection);
                this.DataReader = this.Command.ExecuteReader();
                while (this.DataReader.Read()) contador++;
                this.DataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar" + ex.ToString());
            }
            return contador > 0 ? true : false;
        }

        /// <summary>
        /// Agrega un cliente a la base de datos.
        /// </summary>
        /// <param name="cli">Classe Cliente: Modelo de datos para el cliente.</param>
        /// <returns>Retorna un String. Con el mensaje de salida.</returns>
        public string Insertar(Cliente cli)
        {
            string salida = "registro insertado";
            try
            {
                this.Command = new SqlCommand($"Insert into TbPersonas (Nombre, Apellido, FechaNacimiento) values ('{cli.Nombre}','{cli.Apellido}','{cli.FechaNacimiento}')", this.Connection);
                this.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se pudo insertar el registro" + ex.ToString();
            }
            return salida;
        }

        /// <summary>
        /// Actualiza el registro del cliente, en la base de datos.
        /// </summary>
        /// <param name="cli">Classe Cliente: Modelo de datos para el cliente.</param>
        /// <returns>Retorna un String. Con el mensaje de salida.</returns>
        public string Modificar(Cliente cli)
        {
            string salida = "registro modificado";
            try
            {
                this.Command = new SqlCommand("Update TbPersonas set Nombre='" + cli.Nombre + "', Apellido='" + cli.Apellido + "', FechaNacimiento='" + cli.FechaNacimiento + "' where Id= " + cli.ID, this.Connection);
                this.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se pudo modificar el registro" + ex.ToString();
            }
            return salida;
        }
        /// <summary>
        /// Elimina el cliente seleccionado de la base de datos.
        /// </summary>
        /// <param name="id">Id del cliente que se desea verificar.</param>
        /// <returns>Retorna un String. Con el mensaje de salida.</returns>
        public string Eliminar(int id)
        {
            string salida = "registro eliminado";
            try
            {
                this.Command = new SqlCommand("Delete from TbPersonas where id = " + id, this.Connection);
                this.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se pudo insertar el registro" + ex.ToString();
            }
            return salida;
        }

        /// <summary>
        /// Carga la lista de clientes de la base de datos al DataGridView.
        /// </summary>
        /// <param name="dataDridView">DataGridView a ser rellenado por la lista de clientes de la base de datos.</param>
        public void CargarClienteAlDataGridView(DataGridView dataDridView)
        {
            // sirve para llenar el dataset
            SqlDataAdapter da = new SqlDataAdapter("select * from TbPersonas", this.Connection);
            // sirve para llenar el datagrivew
            // es una tabla de base de datos temporal
            DataSet dscliente = new DataSet();           
            da.Fill(dscliente, "TbPersonas");
            dataDridView.DataSource = dscliente;
            dataDridView.DataMember = "TbPersonas";
        }
    }
}
