namespace ScanDesktop.Views
{
    partial class DonadorView
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
            tabDonadores = new TabControl();
            tabListaDonadores = new TabPage();
            tabAgregarEditarDonador = new TabPage();
            dataGridView1 = new DataGridView();
            iconAgregarDonador = new FontAwesome.Sharp.IconButton();
            iconEditarDonador = new FontAwesome.Sharp.IconButton();
            iconEliminarDonador = new FontAwesome.Sharp.IconButton();
            iconBuscarDonador = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txtBuscarDonador = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            iconGuardarDonador = new FontAwesome.Sharp.IconButton();
            iconCancelar = new FontAwesome.Sharp.IconButton();
            tabDonadores.SuspendLayout();
            tabListaDonadores.SuspendLayout();
            tabAgregarEditarDonador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // tabDonadores
            // 
            tabDonadores.Controls.Add(tabListaDonadores);
            tabDonadores.Controls.Add(tabAgregarEditarDonador);
            tabDonadores.Location = new Point(12, 32);
            tabDonadores.Name = "tabDonadores";
            tabDonadores.SelectedIndex = 0;
            tabDonadores.Size = new Size(776, 406);
            tabDonadores.TabIndex = 0;
            // 
            // tabListaDonadores
            // 
            tabListaDonadores.Controls.Add(txtBuscarDonador);
            tabListaDonadores.Controls.Add(label1);
            tabListaDonadores.Controls.Add(iconBuscarDonador);
            tabListaDonadores.Controls.Add(iconEliminarDonador);
            tabListaDonadores.Controls.Add(iconEditarDonador);
            tabListaDonadores.Controls.Add(iconAgregarDonador);
            tabListaDonadores.Controls.Add(dataGridView1);
            tabListaDonadores.Location = new Point(4, 29);
            tabListaDonadores.Name = "tabListaDonadores";
            tabListaDonadores.Padding = new Padding(3);
            tabListaDonadores.Size = new Size(768, 373);
            tabListaDonadores.TabIndex = 0;
            tabListaDonadores.Text = "Lista de donadores";
            tabListaDonadores.UseVisualStyleBackColor = true;
            // 
            // tabAgregarEditarDonador
            // 
            tabAgregarEditarDonador.Controls.Add(iconCancelar);
            tabAgregarEditarDonador.Controls.Add(iconGuardarDonador);
            tabAgregarEditarDonador.Controls.Add(numericUpDown2);
            tabAgregarEditarDonador.Controls.Add(numericUpDown1);
            tabAgregarEditarDonador.Controls.Add(textBox2);
            tabAgregarEditarDonador.Controls.Add(textBox1);
            tabAgregarEditarDonador.Controls.Add(label5);
            tabAgregarEditarDonador.Controls.Add(label4);
            tabAgregarEditarDonador.Controls.Add(label3);
            tabAgregarEditarDonador.Controls.Add(label2);
            tabAgregarEditarDonador.Location = new Point(4, 29);
            tabAgregarEditarDonador.Name = "tabAgregarEditarDonador";
            tabAgregarEditarDonador.Padding = new Padding(3);
            tabAgregarEditarDonador.Size = new Size(768, 373);
            tabAgregarEditarDonador.TabIndex = 1;
            tabAgregarEditarDonador.Text = "Agregar/Editar";
            tabAgregarEditarDonador.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(629, 289);
            dataGridView1.TabIndex = 0;
            // 
            // iconAgregarDonador
            // 
            iconAgregarDonador.IconChar = FontAwesome.Sharp.IconChar.None;
            iconAgregarDonador.IconColor = Color.Black;
            iconAgregarDonador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAgregarDonador.Location = new Point(653, 85);
            iconAgregarDonador.Name = "iconAgregarDonador";
            iconAgregarDonador.Size = new Size(94, 29);
            iconAgregarDonador.TabIndex = 1;
            iconAgregarDonador.Text = "Agregar";
            iconAgregarDonador.UseVisualStyleBackColor = true;
            // 
            // iconEditarDonador
            // 
            iconEditarDonador.IconChar = FontAwesome.Sharp.IconChar.None;
            iconEditarDonador.IconColor = Color.Black;
            iconEditarDonador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEditarDonador.Location = new Point(653, 151);
            iconEditarDonador.Name = "iconEditarDonador";
            iconEditarDonador.Size = new Size(94, 29);
            iconEditarDonador.TabIndex = 2;
            iconEditarDonador.Text = "Editar";
            iconEditarDonador.UseVisualStyleBackColor = true;
            // 
            // iconEliminarDonador
            // 
            iconEliminarDonador.IconChar = FontAwesome.Sharp.IconChar.None;
            iconEliminarDonador.IconColor = Color.Black;
            iconEliminarDonador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEliminarDonador.Location = new Point(653, 213);
            iconEliminarDonador.Name = "iconEliminarDonador";
            iconEliminarDonador.Size = new Size(94, 29);
            iconEliminarDonador.TabIndex = 3;
            iconEliminarDonador.Text = "Eliminar";
            iconEliminarDonador.UseVisualStyleBackColor = true;
            // 
            // iconBuscarDonador
            // 
            iconBuscarDonador.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBuscarDonador.IconColor = Color.Black;
            iconBuscarDonador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBuscarDonador.Location = new Point(541, 15);
            iconBuscarDonador.Name = "iconBuscarDonador";
            iconBuscarDonador.Size = new Size(94, 29);
            iconBuscarDonador.TabIndex = 4;
            iconBuscarDonador.Text = "Buscar";
            iconBuscarDonador.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 5;
            label1.Text = "Buscar:";
            // 
            // txtBuscarDonador
            // 
            txtBuscarDonador.Location = new Point(67, 16);
            txtBuscarDonador.Name = "txtBuscarDonador";
            txtBuscarDonador.Size = new Size(468, 27);
            txtBuscarDonador.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 41);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 93);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 1;
            label3.Text = "Pais:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 148);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 2;
            label4.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 214);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 3;
            label5.Text = "TotalDonado:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(296, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(296, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 27);
            textBox2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(296, 146);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(207, 27);
            numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(316, 212);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(187, 27);
            numericUpDown2.TabIndex = 7;
            // 
            // iconGuardarDonador
            // 
            iconGuardarDonador.IconChar = FontAwesome.Sharp.IconChar.None;
            iconGuardarDonador.IconColor = Color.Black;
            iconGuardarDonador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconGuardarDonador.Location = new Point(211, 309);
            iconGuardarDonador.Name = "iconGuardarDonador";
            iconGuardarDonador.Size = new Size(94, 29);
            iconGuardarDonador.TabIndex = 8;
            iconGuardarDonador.Text = "Guardar";
            iconGuardarDonador.UseVisualStyleBackColor = true;
            // 
            // iconCancelar
            // 
            iconCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconCancelar.IconColor = Color.Black;
            iconCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCancelar.Location = new Point(409, 309);
            iconCancelar.Name = "iconCancelar";
            iconCancelar.Size = new Size(94, 29);
            iconCancelar.TabIndex = 9;
            iconCancelar.Text = "Cancelar";
            iconCancelar.UseVisualStyleBackColor = true;
            // 
            // DonadorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabDonadores);
            Name = "DonadorView";
            Text = "Donador";
            tabDonadores.ResumeLayout(false);
            tabListaDonadores.ResumeLayout(false);
            tabListaDonadores.PerformLayout();
            tabAgregarEditarDonador.ResumeLayout(false);
            tabAgregarEditarDonador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabDonadores;
        private TabPage tabListaDonadores;
        private TabPage tabAgregarEditarDonador;
        private TextBox txtBuscarDonador;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconBuscarDonador;
        private FontAwesome.Sharp.IconButton iconEliminarDonador;
        private FontAwesome.Sharp.IconButton iconEditarDonador;
        private FontAwesome.Sharp.IconButton iconAgregarDonador;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconCancelar;
        private FontAwesome.Sharp.IconButton iconGuardarDonador;
    }
}