﻿namespace ScanDesktop.Views
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
            label1 = new Label();
            comboManwhas = new ComboBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            comboTyper = new ComboBox();
            label4 = new Label();
            comboCleaner = new ComboBox();
            label5 = new Label();
            comboTraductor = new ComboBox();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            iconBtnAgregar = new FontAwesome.Sharp.IconButton();
            iconBtnEditar = new FontAwesome.Sharp.IconButton();
            iconBtnEliminar = new FontAwesome.Sharp.IconButton();
            iconBtnFinalizar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Manwha:";
            // 
            // comboManwhas
            // 
            comboManwhas.FormattingEnabled = true;
            comboManwhas.Location = new Point(86, 17);
            comboManwhas.Name = "comboManwhas";
            comboManwhas.Size = new Size(151, 28);
            comboManwhas.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 2;
            label2.Text = "Capitulo traducido:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(145, 16);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(109, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 18);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
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
            label4.Location = new Point(3, 66);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 6;
            label4.Text = "Cleaner:";
            // 
            // comboCleaner
            // 
            comboCleaner.FormattingEnabled = true;
            comboCleaner.Location = new Point(74, 63);
            comboCleaner.Name = "comboCleaner";
            comboCleaner.Size = new Size(151, 28);
            comboCleaner.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(299, 66);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 8;
            label5.Text = "Traductor:";
            // 
            // comboTraductor
            // 
            comboTraductor.FormattingEnabled = true;
            comboTraductor.Location = new Point(380, 63);
            comboTraductor.Name = "comboTraductor";
            comboTraductor.Size = new Size(151, 28);
            comboTraductor.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconBtnAgregar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboTraductor);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboCleaner);
            panel1.Controls.Add(comboTyper);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 125);
            panel1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(598, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(134, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 20);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 10;
            label6.Text = "Fecha:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 212);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(604, 188);
            dataGridView1.TabIndex = 12;
            // 
            // iconBtnAgregar
            // 
            iconBtnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnAgregar.IconColor = Color.Black;
            iconBtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAgregar.Location = new Point(604, 37);
            iconBtnAgregar.Name = "iconBtnAgregar";
            iconBtnAgregar.Size = new Size(94, 29);
            iconBtnAgregar.TabIndex = 10;
            iconBtnAgregar.Text = "Agregar";
            iconBtnAgregar.UseVisualStyleBackColor = true;
            // 
            // iconBtnEditar
            // 
            iconBtnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnEditar.IconColor = Color.Black;
            iconBtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnEditar.Location = new Point(658, 212);
            iconBtnEditar.Name = "iconBtnEditar";
            iconBtnEditar.Size = new Size(94, 29);
            iconBtnEditar.TabIndex = 11;
            iconBtnEditar.Text = "Editar";
            iconBtnEditar.UseVisualStyleBackColor = true;
            // 
            // iconBtnEliminar
            // 
            iconBtnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnEliminar.IconColor = Color.Black;
            iconBtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnEliminar.Location = new Point(658, 275);
            iconBtnEliminar.Name = "iconBtnEliminar";
            iconBtnEliminar.Size = new Size(94, 29);
            iconBtnEliminar.TabIndex = 13;
            iconBtnEliminar.Text = "Eliminar";
            iconBtnEliminar.UseVisualStyleBackColor = true;
            // 
            // iconBtnFinalizar
            // 
            iconBtnFinalizar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnFinalizar.IconColor = Color.Black;
            iconBtnFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnFinalizar.Location = new Point(658, 355);
            iconBtnFinalizar.Name = "iconBtnFinalizar";
            iconBtnFinalizar.Size = new Size(94, 29);
            iconBtnFinalizar.TabIndex = 14;
            iconBtnFinalizar.Text = "Finalizar";
            iconBtnFinalizar.UseVisualStyleBackColor = true;
            // 
            // TraduccionesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(iconBtnFinalizar);
            Controls.Add(iconBtnEliminar);
            Controls.Add(iconBtnEditar);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            Controls.Add(comboManwhas);
            Controls.Add(label1);
            Name = "TraduccionesView";
            Text = "Traducciones";
            Load += Traducciones_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboManwhas;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private ComboBox comboTyper;
        private Label label4;
        private ComboBox comboCleaner;
        private Label label5;
        private ComboBox comboTraductor;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnAgregar;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconBtnEditar;
        private FontAwesome.Sharp.IconButton iconBtnEliminar;
        private FontAwesome.Sharp.IconButton iconBtnFinalizar;
    }
}