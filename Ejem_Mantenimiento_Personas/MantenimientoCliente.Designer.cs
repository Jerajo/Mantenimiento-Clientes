namespace Ejem_Mantenimiento_Personas
{
    partial class MantenimientoCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonModificar = new System.Windows.Forms.RadioButton();
            this.RadioButtonEliminar = new System.Windows.Forms.RadioButton();
            this.RadioButtonRegistrar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ButtonModificar = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.ButtonAgregar = new System.Windows.Forms.Button();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.LabelDatosNoEncontrados = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonModificar);
            this.groupBox1.Controls.Add(this.RadioButtonEliminar);
            this.groupBox1.Controls.Add(this.RadioButtonRegistrar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento C# - SQL";
            // 
            // rbtModificar
            // 
            this.RadioButtonModificar.AutoSize = true;
            this.RadioButtonModificar.Location = new System.Drawing.Point(483, 25);
            this.RadioButtonModificar.Name = "rbtModificar";
            this.RadioButtonModificar.Size = new System.Drawing.Size(91, 24);
            this.RadioButtonModificar.TabIndex = 0;
            this.RadioButtonModificar.TabStop = true;
            this.RadioButtonModificar.Text = "Modificar";
            this.RadioButtonModificar.UseVisualStyleBackColor = true;
            this.RadioButtonModificar.CheckedChanged += new System.EventHandler(this.RadioButtonModificar_CheckedChanged);
            // 
            // rbtEliminar
            // 
            this.RadioButtonEliminar.AutoSize = true;
            this.RadioButtonEliminar.Location = new System.Drawing.Point(250, 25);
            this.RadioButtonEliminar.Name = "rbtEliminar";
            this.RadioButtonEliminar.Size = new System.Drawing.Size(83, 24);
            this.RadioButtonEliminar.TabIndex = 0;
            this.RadioButtonEliminar.TabStop = true;
            this.RadioButtonEliminar.Text = "Eliminar";
            this.RadioButtonEliminar.UseVisualStyleBackColor = true;
            this.RadioButtonEliminar.CheckedChanged += new System.EventHandler(this.RadioButtonEliminar_CheckedChanged);
            // 
            // rbtRegistrar
            // 
            this.RadioButtonRegistrar.AutoSize = true;
            this.RadioButtonRegistrar.Location = new System.Drawing.Point(23, 25);
            this.RadioButtonRegistrar.Name = "rbtRegistrar";
            this.RadioButtonRegistrar.Size = new System.Drawing.Size(92, 24);
            this.RadioButtonRegistrar.TabIndex = 0;
            this.RadioButtonRegistrar.TabStop = true;
            this.RadioButtonRegistrar.Text = "Registrar";
            this.RadioButtonRegistrar.UseVisualStyleBackColor = true;
            this.RadioButtonRegistrar.CheckedChanged += new System.EventHandler(this.RadioButtonRegistrar_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.ButtonModificar);
            this.groupBox2.Controls.Add(this.ButtonEliminar);
            this.groupBox2.Controls.Add(this.ButtonAgregar);
            this.groupBox2.Controls.Add(this.dtFechaNacimiento);
            this.groupBox2.Controls.Add(this.txtapellidos);
            this.groupBox2.Controls.Add(this.txtnombre);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 192);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Personales";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(553, 144);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 26);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.Button_Salir_Click);
            // 
            // btnModificar
            // 
            this.ButtonModificar.Location = new System.Drawing.Point(553, 109);
            this.ButtonModificar.Name = "btnModificar";
            this.ButtonModificar.Size = new System.Drawing.Size(88, 26);
            this.ButtonModificar.TabIndex = 3;
            this.ButtonModificar.Text = "Modificar";
            this.ButtonModificar.UseVisualStyleBackColor = true;
            this.ButtonModificar.Click += new System.EventHandler(this.Button_Modificar_Click);
            // 
            // btnEliminar
            // 
            this.ButtonEliminar.Location = new System.Drawing.Point(553, 77);
            this.ButtonEliminar.Name = "btnEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(88, 26);
            this.ButtonEliminar.TabIndex = 3;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.UseVisualStyleBackColor = true;
            this.ButtonEliminar.Click += new System.EventHandler(this.Button_Eliminar_Click);
            // 
            // btnAgregar
            // 
            this.ButtonAgregar.Location = new System.Drawing.Point(553, 43);
            this.ButtonAgregar.Name = "btnAgregar";
            this.ButtonAgregar.Size = new System.Drawing.Size(88, 26);
            this.ButtonAgregar.TabIndex = 3;
            this.ButtonAgregar.Text = "Agregar";
            this.ButtonAgregar.UseVisualStyleBackColor = true;
            this.ButtonAgregar.Click += new System.EventHandler(this.Button_Agregar_Click);
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.CustomFormat = "yyyy-MM-dd";
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(184, 146);
            this.dtFechaNacimiento.MaxDate = new System.DateTime(2007, 6, 28, 0, 0, 0, 0);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(253, 26);
            this.dtFechaNacimiento.TabIndex = 2;
            this.dtFechaNacimiento.UseWaitCursor = true;
            this.dtFechaNacimiento.Value = new System.DateTime(2007, 6, 28, 0, 0, 0, 0);
            // 
            // txtapellidos
            // 
            this.txtapellidos.BackColor = System.Drawing.Color.White;
            this.txtapellidos.Enabled = false;
            this.txtapellidos.Location = new System.Drawing.Point(92, 106);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(345, 26);
            this.txtapellidos.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(92, 74);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(345, 26);
            this.txtnombre.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(92, 42);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(345, 26);
            this.txtid.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // DataGridviewCliente
            // 
            this.DataGridViewCliente.AllowUserToAddRows = false;
            this.DataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCliente.Location = new System.Drawing.Point(13, 302);
            this.DataGridViewCliente.Name = "DataGridviewCliente";
            this.DataGridViewCliente.ReadOnly = true;
            this.DataGridViewCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewCliente.Size = new System.Drawing.Size(662, 233);
            this.DataGridViewCliente.TabIndex = 1;
            this.DataGridViewCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCliente_CellClick);
            // 
            // lblDatosNoEncontrados
            // 
            this.LabelDatosNoEncontrados.AutoSize = true;
            this.LabelDatosNoEncontrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDatosNoEncontrados.Location = new System.Drawing.Point(227, 407);
            this.LabelDatosNoEncontrados.Name = "lblDatosNoEncontrados";
            this.LabelDatosNoEncontrados.Size = new System.Drawing.Size(222, 24);
            this.LabelDatosNoEncontrados.TabIndex = 2;
            this.LabelDatosNoEncontrados.Text = "No se encontraron datos.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 547);
            this.Controls.Add(this.LabelDatosNoEncontrados);
            this.Controls.Add(this.DataGridViewCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Mantenimiento Personas";
            this.Load += new System.EventHandler(this.MantenimientoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewCliente;
        private System.Windows.Forms.RadioButton RadioButtonModificar;
        private System.Windows.Forms.RadioButton RadioButtonEliminar;
        private System.Windows.Forms.RadioButton RadioButtonRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button ButtonModificar;
        private System.Windows.Forms.Button ButtonEliminar;
        private System.Windows.Forms.Button ButtonAgregar;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label LabelDatosNoEncontrados;
    }
}

