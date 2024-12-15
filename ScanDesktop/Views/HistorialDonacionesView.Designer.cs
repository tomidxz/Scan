namespace ScanDesktop.Views
{
    partial class HistorialDonacionesView
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridDonacionesH = new DataGridView();
            panelFiltro = new Panel();
            iconFiltrarDataGrid = new FontAwesome.Sharp.IconButton();
            dateTimeHasta = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dateTimeDesde = new DateTimePicker();
            checkBoxFiltro = new CheckBox();
            numericTotal = new NumericUpDown();
            label4 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconBtnImprimir = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDonacionesH).BeginInit();
            panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 35);
            label1.TabIndex = 1;
            label1.Text = "Historial de Donaciones";
            // 
            // dataGridDonacionesH
            // 
            dataGridDonacionesH.AllowUserToAddRows = false;
            dataGridDonacionesH.AllowUserToDeleteRows = false;
            dataGridDonacionesH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDonacionesH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDonacionesH.Location = new Point(12, 162);
            dataGridDonacionesH.Name = "dataGridDonacionesH";
            dataGridDonacionesH.ReadOnly = true;
            dataGridDonacionesH.RowHeadersWidth = 51;
            dataGridDonacionesH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDonacionesH.Size = new Size(802, 232);
            dataGridDonacionesH.TabIndex = 1;
            // 
            // panelFiltro
            // 
            panelFiltro.Controls.Add(iconFiltrarDataGrid);
            panelFiltro.Controls.Add(dateTimeHasta);
            panelFiltro.Controls.Add(label3);
            panelFiltro.Controls.Add(label2);
            panelFiltro.Controls.Add(dateTimeDesde);
            panelFiltro.Enabled = false;
            panelFiltro.Location = new Point(203, 76);
            panelFiltro.Name = "panelFiltro";
            panelFiltro.Size = new Size(611, 72);
            panelFiltro.TabIndex = 2;
            // 
            // iconFiltrarDataGrid
            // 
            iconFiltrarDataGrid.IconChar = FontAwesome.Sharp.IconChar.None;
            iconFiltrarDataGrid.IconColor = Color.Black;
            iconFiltrarDataGrid.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconFiltrarDataGrid.Location = new Point(497, 18);
            iconFiltrarDataGrid.Name = "iconFiltrarDataGrid";
            iconFiltrarDataGrid.Size = new Size(94, 29);
            iconFiltrarDataGrid.TabIndex = 4;
            iconFiltrarDataGrid.Text = "Filtrar";
            iconFiltrarDataGrid.UseVisualStyleBackColor = true;
            iconFiltrarDataGrid.Click += iconFiltrarDataGrid_Click;
            // 
            // dateTimeHasta
            // 
            dateTimeHasta.Format = DateTimePickerFormat.Short;
            dateTimeHasta.Location = new Point(330, 20);
            dateTimeHasta.Name = "dateTimeHasta";
            dateTimeHasta.Size = new Size(123, 27);
            dateTimeHasta.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 23);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Hasta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 23);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Desde:";
            // 
            // dateTimeDesde
            // 
            dateTimeDesde.Format = DateTimePickerFormat.Short;
            dateTimeDesde.Location = new Point(86, 20);
            dateTimeDesde.Name = "dateTimeDesde";
            dateTimeDesde.Size = new Size(123, 27);
            dateTimeDesde.TabIndex = 0;
            // 
            // checkBoxFiltro
            // 
            checkBoxFiltro.AutoSize = true;
            checkBoxFiltro.Location = new Point(43, 99);
            checkBoxFiltro.Name = "checkBoxFiltro";
            checkBoxFiltro.Size = new Size(115, 24);
            checkBoxFiltro.TabIndex = 3;
            checkBoxFiltro.Text = "Activar Filtro";
            checkBoxFiltro.UseVisualStyleBackColor = true;
            checkBoxFiltro.CheckedChanged += checkBoxFiltro_CheckedChanged;
            // 
            // numericTotal
            // 
            numericTotal.Enabled = false;
            numericTotal.Location = new Point(444, 416);
            numericTotal.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.Size = new Size(150, 27);
            numericTotal.TabIndex = 4;
            numericTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 422);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 5;
            label4.Text = "Total:";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(655, 414);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(159, 41);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "Imprimir todo";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconBtnImprimir
            // 
            iconBtnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnImprimir.IconColor = Color.Black;
            iconBtnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnImprimir.Location = new Point(57, 417);
            iconBtnImprimir.Name = "iconBtnImprimir";
            iconBtnImprimir.Size = new Size(138, 38);
            iconBtnImprimir.TabIndex = 7;
            iconBtnImprimir.Text = "Imprimir";
            iconBtnImprimir.UseVisualStyleBackColor = true;
            iconBtnImprimir.Click += iconBtnImprimir_Click;
            // 
            // HistorialDonacionesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 467);
            Controls.Add(iconBtnImprimir);
            Controls.Add(iconButton1);
            Controls.Add(label4);
            Controls.Add(numericTotal);
            Controls.Add(checkBoxFiltro);
            Controls.Add(panelFiltro);
            Controls.Add(dataGridDonacionesH);
            Controls.Add(panel1);
            Name = "HistorialDonacionesView";
            Text = "HistorialDonacionesView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDonacionesH).EndInit();
            panelFiltro.ResumeLayout(false);
            panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridDonacionesH;
        private Panel panelFiltro;
        private CheckBox checkBoxFiltro;
        private DateTimePicker dateTimeHasta;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimeDesde;
        private FontAwesome.Sharp.IconButton iconFiltrarDataGrid;
        private NumericUpDown numericTotal;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconBtnImprimir;
    }
}