namespace ScanDesktop.Views
{
    partial class DonacionView
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
            label1 = new Label();
            comboDonador = new ComboBox();
            label2 = new Label();
            comboMetodoPago = new ComboBox();
            dateTimeFecha = new DateTimePicker();
            label3 = new Label();
            panel1 = new Panel();
            btnAgregarDonacion = new FontAwesome.Sharp.IconButton();
            numericTotal = new NumericUpDown();
            label5 = new Label();
            comboEmpleado = new ComboBox();
            label4 = new Label();
            dataGridDonaciones = new DataGridView();
            btnEliminarDonacion = new FontAwesome.Sharp.IconButton();
            btnFinalizarDonacion = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDonaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Donador:";
            // 
            // comboDonador
            // 
            comboDonador.FormattingEnabled = true;
            comboDonador.Location = new Point(89, 61);
            comboDonador.Name = "comboDonador";
            comboDonador.Size = new Size(151, 28);
            comboDonador.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 69);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 2;
            label2.Text = "Metodo de Pago:";
            // 
            // comboMetodoPago
            // 
            comboMetodoPago.FormattingEnabled = true;
            comboMetodoPago.Location = new Point(483, 66);
            comboMetodoPago.Name = "comboMetodoPago";
            comboMetodoPago.Size = new Size(151, 28);
            comboMetodoPago.TabIndex = 3;
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(678, 12);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(110, 27);
            dateTimeFecha.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 17);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Fecha:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAgregarDonacion);
            panel1.Controls.Add(numericTotal);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboEmpleado);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 79);
            panel1.TabIndex = 6;
            // 
            // btnAgregarDonacion
            // 
            btnAgregarDonacion.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregarDonacion.IconColor = Color.Black;
            btnAgregarDonacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarDonacion.Location = new Point(656, 25);
            btnAgregarDonacion.Name = "btnAgregarDonacion";
            btnAgregarDonacion.Size = new Size(94, 29);
            btnAgregarDonacion.TabIndex = 7;
            btnAgregarDonacion.Text = "Agregar";
            btnAgregarDonacion.UseVisualStyleBackColor = true;
            btnAgregarDonacion.Click += btnAgregarDonacion_Click;
            // 
            // numericTotal
            // 
            numericTotal.Location = new Point(434, 22);
            numericTotal.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.Size = new Size(150, 27);
            numericTotal.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 25);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 7;
            label5.Text = "Donacion total:";
            // 
            // comboEmpleado
            // 
            comboEmpleado.FormattingEnabled = true;
            comboEmpleado.Location = new Point(89, 22);
            comboEmpleado.Name = "comboEmpleado";
            comboEmpleado.Size = new Size(151, 28);
            comboEmpleado.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 25);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 1;
            label4.Text = "Empleado:";
            // 
            // dataGridDonaciones
            // 
            dataGridDonaciones.AllowUserToAddRows = false;
            dataGridDonaciones.AllowUserToDeleteRows = false;
            dataGridDonaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDonaciones.Location = new Point(15, 205);
            dataGridDonaciones.Name = "dataGridDonaciones";
            dataGridDonaciones.ReadOnly = true;
            dataGridDonaciones.RowHeadersWidth = 51;
            dataGridDonaciones.Size = new Size(619, 188);
            dataGridDonaciones.TabIndex = 7;
            // 
            // btnEliminarDonacion
            // 
            btnEliminarDonacion.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminarDonacion.IconColor = Color.Black;
            btnEliminarDonacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarDonacion.Location = new Point(668, 240);
            btnEliminarDonacion.Name = "btnEliminarDonacion";
            btnEliminarDonacion.Size = new Size(94, 29);
            btnEliminarDonacion.TabIndex = 9;
            btnEliminarDonacion.Text = "Eliminar";
            btnEliminarDonacion.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarDonacion
            // 
            btnFinalizarDonacion.IconChar = FontAwesome.Sharp.IconChar.None;
            btnFinalizarDonacion.IconColor = Color.Black;
            btnFinalizarDonacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinalizarDonacion.Location = new Point(668, 344);
            btnFinalizarDonacion.Name = "btnFinalizarDonacion";
            btnFinalizarDonacion.Size = new Size(94, 29);
            btnFinalizarDonacion.TabIndex = 10;
            btnFinalizarDonacion.Text = "Finalizar";
            btnFinalizarDonacion.UseVisualStyleBackColor = true;
            // 
            // DonacionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFinalizarDonacion);
            Controls.Add(btnEliminarDonacion);
            Controls.Add(dataGridDonaciones);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(dateTimeFecha);
            Controls.Add(comboMetodoPago);
            Controls.Add(label2);
            Controls.Add(comboDonador);
            Controls.Add(label1);
            Name = "DonacionView";
            Text = "DonacionView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDonaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboDonador;
        private Label label2;
        private ComboBox comboMetodoPago;
        private DateTimePicker dateTimeFecha;
        private Label label3;
        private Panel panel1;
        private ComboBox comboEmpleado;
        private Label label4;
        private NumericUpDown numericTotal;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnAgregarDonacion;
        private DataGridView dataGridDonaciones;
        private FontAwesome.Sharp.IconButton btnEliminarDonacion;
        private FontAwesome.Sharp.IconButton btnFinalizarDonacion;
    }
}