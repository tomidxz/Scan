namespace ScanDesktop.Views
{
    partial class EmpleadosView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabEmpleados = new TabControl();
            tabListaEmpleados = new TabPage();
            iconBuscarEmpleado = new FontAwesome.Sharp.IconButton();
            txtBuscarEmpleado = new TextBox();
            label1 = new Label();
            iconEliminarEmpleado = new FontAwesome.Sharp.IconButton();
            iconEditarEmpleado = new FontAwesome.Sharp.IconButton();
            iconAgregarEmpleado = new FontAwesome.Sharp.IconButton();
            dataGridEmpleados = new DataGridView();
            tabAgregarEditarEmpleados = new TabPage();
            txtTelefonos = new TextBox();
            iconCancelar = new FontAwesome.Sharp.IconButton();
            iconGuardar = new FontAwesome.Sharp.IconButton();
            dateTimeFecha = new DateTimePicker();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            comboPuesto = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            tabEmpleados.SuspendLayout();
            tabListaEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleados).BeginInit();
            tabAgregarEditarEmpleados.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabEmpleados
            // 
            tabEmpleados.Controls.Add(tabListaEmpleados);
            tabEmpleados.Controls.Add(tabAgregarEditarEmpleados);
            tabEmpleados.Location = new Point(12, 72);
            tabEmpleados.Name = "tabEmpleados";
            tabEmpleados.SelectedIndex = 0;
            tabEmpleados.Size = new Size(856, 381);
            tabEmpleados.TabIndex = 0;
            // 
            // tabListaEmpleados
            // 
            tabListaEmpleados.BackColor = Color.MediumPurple;
            tabListaEmpleados.Controls.Add(iconBuscarEmpleado);
            tabListaEmpleados.Controls.Add(txtBuscarEmpleado);
            tabListaEmpleados.Controls.Add(label1);
            tabListaEmpleados.Controls.Add(iconEliminarEmpleado);
            tabListaEmpleados.Controls.Add(iconEditarEmpleado);
            tabListaEmpleados.Controls.Add(iconAgregarEmpleado);
            tabListaEmpleados.Controls.Add(dataGridEmpleados);
            tabListaEmpleados.Location = new Point(4, 29);
            tabListaEmpleados.Name = "tabListaEmpleados";
            tabListaEmpleados.Padding = new Padding(3);
            tabListaEmpleados.Size = new Size(848, 348);
            tabListaEmpleados.TabIndex = 0;
            tabListaEmpleados.Text = "Lista de empleados";
            // 
            // iconBuscarEmpleado
            // 
            iconBuscarEmpleado.BackColor = Color.DarkSlateBlue;
            iconBuscarEmpleado.Font = new Font("Segoe UI", 10F);
            iconBuscarEmpleado.ForeColor = SystemColors.ButtonHighlight;
            iconBuscarEmpleado.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBuscarEmpleado.IconColor = Color.Black;
            iconBuscarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBuscarEmpleado.Location = new Point(602, 10);
            iconBuscarEmpleado.Name = "iconBuscarEmpleado";
            iconBuscarEmpleado.Size = new Size(103, 38);
            iconBuscarEmpleado.TabIndex = 6;
            iconBuscarEmpleado.Text = "Buscar";
            iconBuscarEmpleado.UseVisualStyleBackColor = false;
            iconBuscarEmpleado.Click += iconBuscarEmpleado_Click;
            // 
            // txtBuscarEmpleado
            // 
            txtBuscarEmpleado.Location = new Point(76, 17);
            txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            txtBuscarEmpleado.Size = new Size(517, 27);
            txtBuscarEmpleado.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 4;
            label1.Text = "Buscar:";
            // 
            // iconEliminarEmpleado
            // 
            iconEliminarEmpleado.BackColor = Color.DarkSlateBlue;
            iconEliminarEmpleado.Font = new Font("Segoe UI", 10F);
            iconEliminarEmpleado.ForeColor = SystemColors.ButtonHighlight;
            iconEliminarEmpleado.IconChar = FontAwesome.Sharp.IconChar.None;
            iconEliminarEmpleado.IconColor = Color.Black;
            iconEliminarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEliminarEmpleado.Location = new Point(727, 222);
            iconEliminarEmpleado.Name = "iconEliminarEmpleado";
            iconEliminarEmpleado.Size = new Size(105, 47);
            iconEliminarEmpleado.TabIndex = 3;
            iconEliminarEmpleado.Text = "Eliminar";
            iconEliminarEmpleado.UseVisualStyleBackColor = false;
            iconEliminarEmpleado.Click += iconEliminarEmpleado_Click;
            // 
            // iconEditarEmpleado
            // 
            iconEditarEmpleado.BackColor = Color.DarkSlateBlue;
            iconEditarEmpleado.Font = new Font("Segoe UI", 10F);
            iconEditarEmpleado.ForeColor = SystemColors.ButtonHighlight;
            iconEditarEmpleado.IconChar = FontAwesome.Sharp.IconChar.None;
            iconEditarEmpleado.IconColor = Color.Black;
            iconEditarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEditarEmpleado.Location = new Point(727, 147);
            iconEditarEmpleado.Name = "iconEditarEmpleado";
            iconEditarEmpleado.Size = new Size(105, 42);
            iconEditarEmpleado.TabIndex = 2;
            iconEditarEmpleado.Text = "Editar";
            iconEditarEmpleado.UseVisualStyleBackColor = false;
            iconEditarEmpleado.Click += iconEditarEmpleado_Click;
            // 
            // iconAgregarEmpleado
            // 
            iconAgregarEmpleado.BackColor = Color.DarkSlateBlue;
            iconAgregarEmpleado.Font = new Font("Segoe UI", 10F);
            iconAgregarEmpleado.ForeColor = SystemColors.ButtonHighlight;
            iconAgregarEmpleado.IconChar = FontAwesome.Sharp.IconChar.None;
            iconAgregarEmpleado.IconColor = Color.Black;
            iconAgregarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAgregarEmpleado.Location = new Point(727, 76);
            iconAgregarEmpleado.Name = "iconAgregarEmpleado";
            iconAgregarEmpleado.Size = new Size(105, 41);
            iconAgregarEmpleado.TabIndex = 1;
            iconAgregarEmpleado.Text = "Agregar";
            iconAgregarEmpleado.UseVisualStyleBackColor = false;
            iconAgregarEmpleado.Click += iconAgregarEmpleado_Click;
            // 
            // dataGridEmpleados
            // 
            dataGridEmpleados.AllowUserToAddRows = false;
            dataGridEmpleados.AllowUserToDeleteRows = false;
            dataGridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpleados.Location = new Point(6, 58);
            dataGridEmpleados.Name = "dataGridEmpleados";
            dataGridEmpleados.ReadOnly = true;
            dataGridEmpleados.RowHeadersWidth = 51;
            dataGridEmpleados.Size = new Size(699, 284);
            dataGridEmpleados.TabIndex = 0;
            // 
            // tabAgregarEditarEmpleados
            // 
            tabAgregarEditarEmpleados.BackColor = Color.MediumPurple;
            tabAgregarEditarEmpleados.Controls.Add(txtTelefonos);
            tabAgregarEditarEmpleados.Controls.Add(iconCancelar);
            tabAgregarEditarEmpleados.Controls.Add(iconGuardar);
            tabAgregarEditarEmpleados.Controls.Add(dateTimeFecha);
            tabAgregarEditarEmpleados.Controls.Add(txtCorreo);
            tabAgregarEditarEmpleados.Controls.Add(txtNombre);
            tabAgregarEditarEmpleados.Controls.Add(label6);
            tabAgregarEditarEmpleados.Controls.Add(comboPuesto);
            tabAgregarEditarEmpleados.Controls.Add(label5);
            tabAgregarEditarEmpleados.Controls.Add(label4);
            tabAgregarEditarEmpleados.Controls.Add(label3);
            tabAgregarEditarEmpleados.Controls.Add(label2);
            tabAgregarEditarEmpleados.Location = new Point(4, 29);
            tabAgregarEditarEmpleados.Name = "tabAgregarEditarEmpleados";
            tabAgregarEditarEmpleados.Padding = new Padding(3);
            tabAgregarEditarEmpleados.Size = new Size(848, 348);
            tabAgregarEditarEmpleados.TabIndex = 1;
            tabAgregarEditarEmpleados.Text = "Agregar/Editar";
            // 
            // txtTelefonos
            // 
            txtTelefonos.Location = new Point(293, 75);
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.Size = new Size(125, 27);
            txtTelefonos.TabIndex = 13;
            // 
            // iconCancelar
            // 
            iconCancelar.BackColor = Color.DarkSlateBlue;
            iconCancelar.Font = new Font("Segoe UI", 10F);
            iconCancelar.ForeColor = SystemColors.ButtonFace;
            iconCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconCancelar.IconColor = Color.Black;
            iconCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCancelar.Location = new Point(652, 282);
            iconCancelar.Name = "iconCancelar";
            iconCancelar.Size = new Size(106, 40);
            iconCancelar.TabIndex = 12;
            iconCancelar.Text = "Cancelar";
            iconCancelar.UseVisualStyleBackColor = false;
            iconCancelar.Click += iconCancelar_Click;
            // 
            // iconGuardar
            // 
            iconGuardar.BackColor = Color.DarkSlateBlue;
            iconGuardar.Font = new Font("Segoe UI", 10F);
            iconGuardar.ForeColor = SystemColors.ButtonHighlight;
            iconGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconGuardar.IconColor = Color.Black;
            iconGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconGuardar.Location = new Point(523, 282);
            iconGuardar.Name = "iconGuardar";
            iconGuardar.Size = new Size(96, 40);
            iconGuardar.TabIndex = 11;
            iconGuardar.Text = "Guardar";
            iconGuardar.UseVisualStyleBackColor = false;
            iconGuardar.Click += iconGuardar_Click;
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(293, 175);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(250, 27);
            dateTimeFecha.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(293, 122);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(293, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(112, 252);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 6;
            label6.Text = "Puesto:";
            // 
            // comboPuesto
            // 
            comboPuesto.FormattingEnabled = true;
            comboPuesto.Location = new Point(293, 247);
            comboPuesto.Name = "comboPuesto";
            comboPuesto.Size = new Size(151, 28);
            comboPuesto.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(112, 178);
            label5.Name = "label5";
            label5.Size = new Size(175, 23);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(112, 123);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(112, 76);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(112, 29);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(881, 63);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(13, 9);
            label7.Name = "label7";
            label7.Size = new Size(148, 37);
            label7.TabIndex = 0;
            label7.Text = "Empleados";
            // 
            // EmpleadosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(880, 465);
            Controls.Add(panel1);
            Controls.Add(tabEmpleados);
            Name = "EmpleadosView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmpleadosView";
            tabEmpleados.ResumeLayout(false);
            tabListaEmpleados.ResumeLayout(false);
            tabListaEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleados).EndInit();
            tabAgregarEditarEmpleados.ResumeLayout(false);
            tabAgregarEditarEmpleados.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabEmpleados;
        private TabPage tabListaEmpleados;
        private TabPage tabAgregarEditarEmpleados;
        private DataGridView dataGridEmpleados;
        private FontAwesome.Sharp.IconButton iconEliminarEmpleado;
        private FontAwesome.Sharp.IconButton iconEditarEmpleado;
        private FontAwesome.Sharp.IconButton iconAgregarEmpleado;
        private TextBox txtBuscarEmpleado;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconBuscarEmpleado;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label label6;
        private ComboBox comboPuesto;
        private DateTimePicker dateTimeFecha;
        private FontAwesome.Sharp.IconButton iconCancelar;
        private FontAwesome.Sharp.IconButton iconGuardar;
        private TextBox txtTelefonos;
        private Panel panel1;
        private Label label7;
    }
}