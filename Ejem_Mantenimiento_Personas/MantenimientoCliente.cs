using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejem_Mantenimiento_Personas
{
    /// <summary>
    /// Formulario de mantenimiento para los clientes.
    /// </summary>
    public partial class MantenimientoCliente : Form
    {
        Conexion conenection = new Conexion();

        public MantenimientoCliente()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento llamado en la carga del formulario MantenimientoCliente.
        /// </summary>
        /// <param name="sender">Puntero al objeto que llamo el evento.</param>
        /// <param name="e">Manegadores del evento.</param>
        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {
            conenection.CargarClienteAlDataGridView(DataGridViewCliente);
            if (DataGridViewCliente.Rows.Count > 0)
            {
                LabelDatosNoEncontrados.Visible = false;
                DataGridViewCliente_CellClick(null, null);
            }
            else
            {
                LabelDatosNoEncontrados.Visible = true;
            }
            AutoReset();
        }

        //seleciona la tecla de igual
        /// <summary>
        /// Selecciona el RadioButton por defecto.
        /// </summary>
        private void AutoReset()
        {
            RadioButtonModificar.Checked = true;
            this.ActiveControl = ButtonModificar;
        }

        /// <summary>
        /// Evento click del boton Agregar. Agrega un nuevo cliente en la base de datos.
        /// </summary>
        /// <param name="sender">Puntero al objeto que llamo el evento.</param>
        /// <param name="e">Manegadores del evento.</param>
        private void Button_Agregar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Nombre = txtnombre.Text;
            cli.Apellido = txtapellidos.Text;
            cli.FechaNacimiento = dtFechaNacimiento.Text;
                
            MessageBox.Show(conenection.Insertar(cli));         
            MantenimientoCliente_Load(null, null);
        }
        /// <summary>
        /// Evento click del boton Eliminar. Elimina un cliente de la base de datos.
        /// </summary>
        /// <param name="sender">Puntero al objeto que llamo el evento.</param>
        /// <param name="e">Manegadores del evento.</param>
        private void Button_Eliminar_Click(object sender, EventArgs e)
        {
            if (conenection.ClienteRegistrado(Convert.ToInt32(txtid.Text)))
            {
                MessageBox.Show(conenection.Eliminar(Convert.ToInt32(txtid.Text)));
            }
            else
            {
                MessageBox.Show("No se puede eliminar el registro no existe");
            }
            MantenimientoCliente_Load(null, null);
        }
        /// <summary>
        /// Evento click del boton MOdificar. MOdifica el registro del cliente en la base de datos.
        /// </summary>
        /// <param name="sender">Puntero al objeto que llamo el evento.</param>
        /// <param name="e">Manegadores del evento.</param>
        private void Button_Modificar_Click(object sender, EventArgs e)
        {
            if (conenection.ClienteRegistrado(Convert.ToInt32(txtid.Text)))
            {
                Cliente cli = new Cliente
                {
                    ID = Convert.ToInt32(txtid.Text),
                    Nombre = txtnombre.Text,
                    Apellido = txtapellidos.Text,
                    FechaNacimiento = dtFechaNacimiento.Text
                };

                MessageBox.Show(conenection.Modificar(cli));
            }
            else
            {
                MessageBox.Show("No se puede eliminar el registro no existe");
            }
            MantenimientoCliente_Load(null, null);
        }
        /// <summary>
        /// Evento click del boton Salir. Cierra el formulario.
        /// </summary>
        /// <param name="sender">Puntero al objeto que llamo el evento.</param>
        /// <param name="e">Manegadores del evento.</param>
        private void Button_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Evento click del radiobutton Registrar. Limpia los controles y abilita el boton de agregar.
        /// </summary>
        /// <param name="sender">Puntero al objeto que llamo el evento.</param>
        /// <param name="e">Manegadores del evento.</param>
        private void RadioButtonRegistrar_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonRegistrar.Checked)
            {
                txtid.ResetText();
                txtnombre.ResetText();
                txtapellidos.ResetText();
            }
            EditarControles(true);
        }
        /// <summary>
        /// Evento click del radiobutton Eliminar. Refresca el data gridview y recetea los controles.
        /// </summary>
        /// <param name="sender">Puntero al objeto que llamo el evento.</param>
        /// <param name="e">Manegadores del evento.</param>
        private void RadioButtonEliminar_CheckedChanged(object sender, EventArgs e)
        {          
            DataGridViewCliente_CellClick(null, null);
            EditarControles(false);
        }
        /// <summary>
        /// Evento click del radiobutton Modificar. Refresca el data gridview y recetea los controles.
        /// </summary>
        /// <param name="sender">Puntero al objeto que llamo el evento.</param>
        /// <param name="e">Manegadores del evento.</param>
        private void RadioButtonModificar_CheckedChanged(object sender, EventArgs e)
        {         
            DataGridViewCliente_CellClick(null, null);
            EditarControles(true);
        }
        /// <summary>
        /// Ablilita y desabilita, los controles, para provcedimientos especificos.
        /// </summary>
        /// <param name="si">Determina si el controlador estará activo o no.</param>
        private void EditarControles(bool si)
        {
            txtnombre.Enabled = si;
            txtapellidos.Enabled = si;
            dtFechaNacimiento.Enabled = si;           
            if (RadioButtonRegistrar.Checked)
            {
                DataGridViewCliente.Enabled = false;
                ButtonAgregar.Enabled = true;
            }
            else
            {
                DataGridViewCliente.Enabled = true;
                ButtonAgregar.Enabled = false;
            }
            if (RadioButtonEliminar.Checked) ButtonEliminar.Enabled = true;
            else ButtonEliminar.Enabled = false;
            if (RadioButtonModificar.Checked) ButtonModificar.Enabled = true;
            else ButtonModificar.Enabled = false;
        }
        /// <summary>
        /// Evento click del DataGridView. Caraga los datos seleccionados en el DataGridView a los controladores
        /// de texto.
        /// </summary>
        /// <param name="sender">Puntero al objeto que llamo el evento.</param>
        /// <param name="e">Manegadores del evento.</param>
        private void DataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewCliente.CurrentRow != null)
            {
                txtid.Text = DataGridViewCliente.CurrentRow.Cells[0].Value.ToString();
                txtnombre.Text = DataGridViewCliente.CurrentRow.Cells[1].Value.ToString();
                txtapellidos.Text = DataGridViewCliente.CurrentRow.Cells[2].Value.ToString();
                dtFechaNacimiento.Text = DataGridViewCliente.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
