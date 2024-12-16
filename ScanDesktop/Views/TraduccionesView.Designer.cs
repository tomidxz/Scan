namespace ScanDesktop.Views
{
    partial class TraduccionesView
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            comboManwhas = new ComboBox();
            label2 = new Label();
            numericCapitulo = new NumericUpDown();
            label3 = new Label();
            comboTyper = new ComboBox();
            label4 = new Label();
            comboCleaner = new ComboBox();
            label5 = new Label();
            comboTraductor = new ComboBox();
            panel1 = new Panel();
            iconBtnAgregar = new FontAwesome.Sharp.IconButton();
            dateTimeFecha = new DateTimePicker();
            label6 = new Label();
            dataGridTraducciones = new DataGridView();
            iconBtnEliminar = new FontAwesome.Sharp.IconButton();
            iconBtnFinalizar = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericCapitulo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTraducciones).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(15, 70);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 0;
            label1.Text = "Manwha:";
            // 
            // comboManwhas
            // 
            comboManwhas.FormattingEnabled = true;
            comboManwhas.Location = new Point(100, 67);
            comboManwhas.Name = "comboManwhas";
            comboManwhas.Size = new Size(151, 28);
            comboManwhas.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 2;
            label2.Text = "Capitulo traducido:";
            // 
            // numericCapitulo
            // 
            numericCapitulo.Location = new Point(165, 18);
            numericCapitulo.Maximum = new decimal(new int[] { -159383553, 46653770, 5421, 0 });
            numericCapitulo.Name = "numericCapitulo";
            numericCapitulo.Size = new Size(109, 27);
            numericCapitulo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(299, 18);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 4;
            label3.Text = "Typer:";
            // 
            // comboTyper
            // 
            comboTyper.FormattingEnabled = true;
            comboTyper.Location = new Point(365, 15);
            comboTyper.Name = "comboTyper";
            comboTyper.Size = new Size(151, 28);
            comboTyper.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(3, 66);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 6;
            label4.Text = "Cleaner:";
            // 
            // comboCleaner
            // 
            comboCleaner.FormattingEnabled = true;
            comboCleaner.Location = new Point(81, 63);
            comboCleaner.Name = "comboCleaner";
            comboCleaner.Size = new Size(151, 28);
            comboCleaner.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(299, 66);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 8;
            label5.Text = "Traductor:";
            // 
            // comboTraductor
            // 
            comboTraductor.FormattingEnabled = true;
            comboTraductor.Location = new Point(392, 65);
            comboTraductor.Name = "comboTraductor";
            comboTraductor.Size = new Size(151, 28);
            comboTraductor.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconBtnAgregar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboTraductor);
            panel1.Controls.Add(numericCapitulo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboCleaner);
            panel1.Controls.Add(comboTyper);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(15, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 125);
            panel1.TabIndex = 10;
            // 
            // iconBtnAgregar
            // 
            iconBtnAgregar.BackColor = Color.DarkSlateBlue;
            iconBtnAgregar.Font = new Font("Segoe UI", 10F);
            iconBtnAgregar.ForeColor = SystemColors.ButtonHighlight;
            iconBtnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnAgregar.IconColor = Color.Black;
            iconBtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAgregar.Location = new Point(586, 34);
            iconBtnAgregar.Name = "iconBtnAgregar";
            iconBtnAgregar.Size = new Size(112, 37);
            iconBtnAgregar.TabIndex = 10;
            iconBtnAgregar.Text = "Agregar";
            iconBtnAgregar.UseVisualStyleBackColor = false;
            iconBtnAgregar.Click += iconBtnAgregar_Click;
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(601, 68);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(134, 27);
            dateTimeFecha.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(535, 70);
            label6.Name = "label6";
            label6.Size = new Size(58, 23);
            label6.TabIndex = 10;
            label6.Text = "Fecha:";
            // 
            // dataGridTraducciones
            // 
            dataGridTraducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridTraducciones.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridTraducciones.Location = new Point(15, 266);
            dataGridTraducciones.Name = "dataGridTraducciones";
            dataGridTraducciones.RowHeadersWidth = 51;
            dataGridTraducciones.Size = new Size(604, 155);
            dataGridTraducciones.TabIndex = 12;
            // 
            // iconBtnEliminar
            // 
            iconBtnEliminar.BackColor = Color.DarkSlateBlue;
            iconBtnEliminar.Font = new Font("Segoe UI", 10F);
            iconBtnEliminar.ForeColor = SystemColors.Control;
            iconBtnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnEliminar.IconColor = Color.Black;
            iconBtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnEliminar.Location = new Point(658, 275);
            iconBtnEliminar.Name = "iconBtnEliminar";
            iconBtnEliminar.Size = new Size(102, 40);
            iconBtnEliminar.TabIndex = 13;
            iconBtnEliminar.Text = "Eliminar";
            iconBtnEliminar.UseVisualStyleBackColor = false;
            iconBtnEliminar.Click += iconBtnEliminar_Click;
            // 
            // iconBtnFinalizar
            // 
            iconBtnFinalizar.BackColor = Color.DarkSlateBlue;
            iconBtnFinalizar.Font = new Font("Segoe UI", 10F);
            iconBtnFinalizar.ForeColor = SystemColors.ControlLight;
            iconBtnFinalizar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnFinalizar.IconColor = Color.Black;
            iconBtnFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnFinalizar.Location = new Point(658, 341);
            iconBtnFinalizar.Name = "iconBtnFinalizar";
            iconBtnFinalizar.Size = new Size(102, 38);
            iconBtnFinalizar.TabIndex = 14;
            iconBtnFinalizar.Text = "Finalizar";
            iconBtnFinalizar.UseVisualStyleBackColor = false;
            iconBtnFinalizar.Click += iconBtnFinalizar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Controls.Add(label7);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 60);
            panel2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(11, 8);
            label7.Name = "label7";
            label7.Size = new Size(145, 37);
            label7.TabIndex = 0;
            label7.Text = "Traduccion";
            // 
            // TraduccionesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(iconBtnFinalizar);
            Controls.Add(iconBtnEliminar);
            Controls.Add(dataGridTraducciones);
            Controls.Add(label6);
            Controls.Add(dateTimeFecha);
            Controls.Add(panel1);
            Controls.Add(comboManwhas);
            Controls.Add(label1);
            Name = "TraduccionesView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Traducciones";
            ((System.ComponentModel.ISupportInitialize)numericCapitulo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTraducciones).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboManwhas;
        private Label label2;
        private NumericUpDown numericCapitulo;
        private Label label3;
        private ComboBox comboTyper;
        private Label label4;
        private ComboBox comboCleaner;
        private Label label5;
        private ComboBox comboTraductor;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnAgregar;
        private DateTimePicker dateTimeFecha;
        private Label label6;
        private DataGridView dataGridTraducciones;
        private FontAwesome.Sharp.IconButton iconBtnEliminar;
        private FontAwesome.Sharp.IconButton iconBtnFinalizar;
        private Panel panel2;
        private Label label7;
    }
}