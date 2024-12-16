namespace ScanDesktop.Views
{
    partial class SolicitudesView
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
            dataGridSolicitudes = new DataGridView();
            iconEliminarSolicitud = new FontAwesome.Sharp.IconButton();
            iconSalir = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridSolicitudes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridSolicitudes
            // 
            dataGridSolicitudes.AllowUserToAddRows = false;
            dataGridSolicitudes.AllowUserToDeleteRows = false;
            dataGridSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSolicitudes.Location = new Point(12, 75);
            dataGridSolicitudes.Name = "dataGridSolicitudes";
            dataGridSolicitudes.ReadOnly = true;
            dataGridSolicitudes.RowHeadersWidth = 51;
            dataGridSolicitudes.Size = new Size(776, 310);
            dataGridSolicitudes.TabIndex = 0;
            // 
            // iconEliminarSolicitud
            // 
            iconEliminarSolicitud.BackColor = Color.DarkSlateBlue;
            iconEliminarSolicitud.Font = new Font("Segoe UI", 10F);
            iconEliminarSolicitud.ForeColor = SystemColors.ControlLightLight;
            iconEliminarSolicitud.IconChar = FontAwesome.Sharp.IconChar.None;
            iconEliminarSolicitud.IconColor = Color.Black;
            iconEliminarSolicitud.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEliminarSolicitud.Location = new Point(600, 391);
            iconEliminarSolicitud.Name = "iconEliminarSolicitud";
            iconEliminarSolicitud.Size = new Size(107, 47);
            iconEliminarSolicitud.TabIndex = 1;
            iconEliminarSolicitud.Text = "Eliminar";
            iconEliminarSolicitud.UseVisualStyleBackColor = false;
            iconEliminarSolicitud.Click += iconEliminarSolicitud_Click;
            // 
            // iconSalir
            // 
            iconSalir.BackColor = Color.DarkSlateBlue;
            iconSalir.Font = new Font("Segoe UI", 10F);
            iconSalir.ForeColor = SystemColors.ButtonHighlight;
            iconSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSalir.IconColor = Color.Black;
            iconSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSalir.Location = new Point(110, 391);
            iconSalir.Name = "iconSalir";
            iconSalir.Size = new Size(104, 47);
            iconSalir.TabIndex = 2;
            iconSalir.Text = "Salir";
            iconSalir.UseVisualStyleBackColor = false;
            iconSalir.Click += iconSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 67);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(11, 7);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 0;
            label1.Text = "Solicitudes";
            // 
            // SolicitudesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(iconSalir);
            Controls.Add(iconEliminarSolicitud);
            Controls.Add(dataGridSolicitudes);
            Name = "SolicitudesView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SolicitudesView";
            ((System.ComponentModel.ISupportInitialize)dataGridSolicitudes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridSolicitudes;
        private FontAwesome.Sharp.IconButton iconEliminarSolicitud;
        private FontAwesome.Sharp.IconButton iconSalir;
        private Panel panel1;
        private Label label1;
    }
}