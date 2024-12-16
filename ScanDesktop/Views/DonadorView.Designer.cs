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
            txtBuscarDonador = new TextBox();
            label1 = new Label();
            iconBuscarDonador = new FontAwesome.Sharp.IconButton();
            iconEliminarDonador = new FontAwesome.Sharp.IconButton();
            iconEditarDonador = new FontAwesome.Sharp.IconButton();
            iconAgregarDonador = new FontAwesome.Sharp.IconButton();
            dataGridDonadores = new DataGridView();
            tabAgregarEditarDonador = new TabPage();
            txtTelefonoDonador = new TextBox();
            iconCancelar = new FontAwesome.Sharp.IconButton();
            iconGuardarDonador = new FontAwesome.Sharp.IconButton();
            numericTotalDonado = new NumericUpDown();
            txtPaisDonador = new TextBox();
            txtNombreDonador = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            tabDonadores.SuspendLayout();
            tabListaDonadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDonadores).BeginInit();
            tabAgregarEditarDonador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotalDonado).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabDonadores
            // 
            tabDonadores.Controls.Add(tabListaDonadores);
            tabDonadores.Controls.Add(tabAgregarEditarDonador);
            tabDonadores.Location = new Point(12, 76);
            tabDonadores.Name = "tabDonadores";
            tabDonadores.SelectedIndex = 0;
            tabDonadores.Size = new Size(776, 362);
            tabDonadores.TabIndex = 0;
            // 
            // tabListaDonadores
            // 
            tabListaDonadores.BackColor = Color.MediumPurple;
            tabListaDonadores.Controls.Add(txtBuscarDonador);
            tabListaDonadores.Controls.Add(label1);
            tabListaDonadores.Controls.Add(iconBuscarDonador);
            tabListaDonadores.Controls.Add(iconEliminarDonador);
            tabListaDonadores.Controls.Add(iconEditarDonador);
            tabListaDonadores.Controls.Add(iconAgregarDonador);
            tabListaDonadores.Controls.Add(dataGridDonadores);
            tabListaDonadores.Location = new Point(4, 29);
            tabListaDonadores.Name = "tabListaDonadores";
            tabListaDonadores.Padding = new Padding(3);
            tabListaDonadores.Size = new Size(768, 329);
            tabListaDonadores.TabIndex = 0;
            tabListaDonadores.Text = "Lista de donadores";
            // 
            // txtBuscarDonador
            // 
            txtBuscarDonador.Location = new Point(67, 16);
            txtBuscarDonador.Name = "txtBuscarDonador";
            txtBuscarDonador.Size = new Size(468, 27);
            txtBuscarDonador.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 5;
            label1.Text = "Buscar:";
            // 
            // iconBuscarDonador
            // 
            iconBuscarDonador.BackColor = Color.DarkSlateBlue;
            iconBuscarDonador.Font = new Font("Segoe UI", 10F);
            iconBuscarDonador.ForeColor = SystemColors.ButtonHighlight;
            iconBuscarDonador.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBuscarDonador.IconColor = Color.White;
            iconBuscarDonador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBuscarDonador.Location = new Point(541, 9);
            iconBuscarDonador.Name = "iconBuscarDonador";
            iconBuscarDonador.Size = new Size(94, 38);
            iconBuscarDonador.TabIndex = 4;
            iconBuscarDonador.Text = "Buscar";
            iconBuscarDonador.UseVisualStyleBackColor = false;
            iconBuscarDonador.Click += iconBuscarDonador_Click;
            // 
            // iconEliminarDonador
            // 
            iconEliminarDonador.BackColor = Color.DarkSlateBlue;
            iconEliminarDonador.Font = new Font("Segoe UI", 10F);
            iconEliminarDonador.ForeColor = SystemColors.ButtonFace;
            iconEliminarDonador.IconChar = FontAwesome.Sharp.IconChar.None;
            iconEliminarDonador.IconColor = Color.Black;
            iconEliminarDonador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEliminarDonador.Location = new Point(641, 198);
            iconEliminarDonador.Name = "iconEliminarDonador";
            iconEliminarDonador.Size = new Size(106, 36);
            iconEliminarDonador.TabIndex = 3;
            iconEliminarDonador.Text = "Eliminar";
            iconEliminarDonador.UseVisualStyleBackColor = false;
            iconEliminarDonador.Click += iconEliminarDonador_Click;
            // 
            // iconEditarDonador
            // 
            iconEditarDonador.BackColor = Color.DarkSlateBlue;
            iconEditarDonador.Font = new Font("Segoe UI", 10F);
            iconEditarDonador.ForeColor = SystemColors.ControlLight;
            iconEditarDonador.IconChar = FontAwesome.Sharp.IconChar.None;
            iconEditarDonador.IconColor = Color.Black;
            iconEditarDonador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEditarDonador.Location = new Point(641, 134);
            iconEditarDonador.Name = "iconEditarDonador";
            iconEditarDonador.Size = new Size(106, 35);
            iconEditarDonador.TabIndex = 2;
            iconEditarDonador.Text = "Editar";
            iconEditarDonador.UseVisualStyleBackColor = false;
            iconEditarDonador.Click += iconEditarDonador_Click;
            // 
            // iconAgregarDonador
            // 
            iconAgregarDonador.BackColor = Color.DarkSlateBlue;
            iconAgregarDonador.Font = new Font("Segoe UI", 10F);
            iconAgregarDonador.ForeColor = SystemColors.ButtonFace;
            iconAgregarDonador.IconChar = FontAwesome.Sharp.IconChar.None;
            iconAgregarDonador.IconColor = Color.Black;
            iconAgregarDonador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAgregarDonador.Location = new Point(641, 78);
            iconAgregarDonador.Name = "iconAgregarDonador";
            iconAgregarDonador.Size = new Size(106, 36);
            iconAgregarDonador.TabIndex = 1;
            iconAgregarDonador.Text = "Agregar";
            iconAgregarDonador.UseVisualStyleBackColor = false;
            iconAgregarDonador.Click += iconAgregarDonador_Click;
            // 
            // dataGridDonadores
            // 
            dataGridDonadores.AllowUserToAddRows = false;
            dataGridDonadores.AllowUserToDeleteRows = false;
            dataGridDonadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDonadores.Location = new Point(6, 59);
            dataGridDonadores.Name = "dataGridDonadores";
            dataGridDonadores.ReadOnly = true;
            dataGridDonadores.RowHeadersWidth = 51;
            dataGridDonadores.Size = new Size(629, 255);
            dataGridDonadores.TabIndex = 0;
            // 
            // tabAgregarEditarDonador
            // 
            tabAgregarEditarDonador.BackColor = Color.MediumPurple;
            tabAgregarEditarDonador.Controls.Add(txtTelefonoDonador);
            tabAgregarEditarDonador.Controls.Add(iconCancelar);
            tabAgregarEditarDonador.Controls.Add(iconGuardarDonador);
            tabAgregarEditarDonador.Controls.Add(numericTotalDonado);
            tabAgregarEditarDonador.Controls.Add(txtPaisDonador);
            tabAgregarEditarDonador.Controls.Add(txtNombreDonador);
            tabAgregarEditarDonador.Controls.Add(label5);
            tabAgregarEditarDonador.Controls.Add(label4);
            tabAgregarEditarDonador.Controls.Add(label3);
            tabAgregarEditarDonador.Controls.Add(label2);
            tabAgregarEditarDonador.Location = new Point(4, 29);
            tabAgregarEditarDonador.Name = "tabAgregarEditarDonador";
            tabAgregarEditarDonador.Padding = new Padding(3);
            tabAgregarEditarDonador.Size = new Size(768, 329);
            tabAgregarEditarDonador.TabIndex = 1;
            tabAgregarEditarDonador.Text = "Agregar/Editar";
            // 
            // txtTelefonoDonador
            // 
            txtTelefonoDonador.Location = new Point(333, 147);
            txtTelefonoDonador.Name = "txtTelefonoDonador";
            txtTelefonoDonador.Size = new Size(207, 27);
            txtTelefonoDonador.TabIndex = 10;
            // 
            // iconCancelar
            // 
            iconCancelar.BackColor = Color.DarkSlateBlue;
            iconCancelar.Font = new Font("Segoe UI", 10F);
            iconCancelar.ForeColor = SystemColors.ControlLightLight;
            iconCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconCancelar.IconColor = Color.Black;
            iconCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCancelar.Location = new Point(411, 275);
            iconCancelar.Name = "iconCancelar";
            iconCancelar.Size = new Size(102, 39);
            iconCancelar.TabIndex = 9;
            iconCancelar.Text = "Cancelar";
            iconCancelar.UseVisualStyleBackColor = false;
            iconCancelar.Click += iconCancelar_Click;
            // 
            // iconGuardarDonador
            // 
            iconGuardarDonador.BackColor = Color.DarkSlateBlue;
            iconGuardarDonador.Font = new Font("Segoe UI", 10F);
            iconGuardarDonador.ForeColor = SystemColors.ButtonHighlight;
            iconGuardarDonador.IconChar = FontAwesome.Sharp.IconChar.None;
            iconGuardarDonador.IconColor = Color.Black;
            iconGuardarDonador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconGuardarDonador.Location = new Point(211, 275);
            iconGuardarDonador.Name = "iconGuardarDonador";
            iconGuardarDonador.Size = new Size(103, 39);
            iconGuardarDonador.TabIndex = 8;
            iconGuardarDonador.Text = "Guardar";
            iconGuardarDonador.UseVisualStyleBackColor = false;
            iconGuardarDonador.Click += iconGuardarDonador_Click;
            // 
            // numericTotalDonado
            // 
            numericTotalDonado.Location = new Point(333, 214);
            numericTotalDonado.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            numericTotalDonado.Name = "numericTotalDonado";
            numericTotalDonado.Size = new Size(207, 27);
            numericTotalDonado.TabIndex = 7;
            // 
            // txtPaisDonador
            // 
            txtPaisDonador.Location = new Point(333, 92);
            txtPaisDonador.Name = "txtPaisDonador";
            txtPaisDonador.Size = new Size(207, 27);
            txtPaisDonador.TabIndex = 5;
            // 
            // txtNombreDonador
            // 
            txtNombreDonador.Location = new Point(333, 40);
            txtNombreDonador.Name = "txtNombreDonador";
            txtNombreDonador.Size = new Size(207, 27);
            txtNombreDonador.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(211, 214);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 3;
            label5.Text = "Total Donado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(211, 148);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 2;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(211, 93);
            label3.Name = "label3";
            label3.Size = new Size(43, 23);
            label3.TabIndex = 1;
            label3.Text = "Pais:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(211, 41);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 58);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(15, 9);
            label6.Name = "label6";
            label6.Size = new Size(147, 37);
            label6.TabIndex = 0;
            label6.Text = "Donadores";
            // 
            // DonadorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(tabDonadores);
            Name = "DonadorView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Donador";
            tabDonadores.ResumeLayout(false);
            tabListaDonadores.ResumeLayout(false);
            tabListaDonadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDonadores).EndInit();
            tabAgregarEditarDonador.ResumeLayout(false);
            tabAgregarEditarDonador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotalDonado).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private DataGridView dataGridDonadores;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private NumericUpDown numericTotalDonado;
        private TextBox txtPaisDonador;
        private TextBox txtNombreDonador;
        private FontAwesome.Sharp.IconButton iconCancelar;
        private FontAwesome.Sharp.IconButton iconGuardarDonador;
        private TextBox txtTelefonoDonador;
        private Panel panel1;
        private Label label6;
    }
}