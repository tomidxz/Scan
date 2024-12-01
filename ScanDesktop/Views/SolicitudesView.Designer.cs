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
            ((System.ComponentModel.ISupportInitialize)dataGridSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // dataGridSolicitudes
            // 
            dataGridSolicitudes.AllowUserToAddRows = false;
            dataGridSolicitudes.AllowUserToDeleteRows = false;
            dataGridSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSolicitudes.Location = new Point(12, 12);
            dataGridSolicitudes.Name = "dataGridSolicitudes";
            dataGridSolicitudes.ReadOnly = true;
            dataGridSolicitudes.RowHeadersWidth = 51;
            dataGridSolicitudes.Size = new Size(776, 387);
            dataGridSolicitudes.TabIndex = 0;
            // 
            // iconEliminarSolicitud
            // 
            iconEliminarSolicitud.IconChar = FontAwesome.Sharp.IconChar.None;
            iconEliminarSolicitud.IconColor = Color.Black;
            iconEliminarSolicitud.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEliminarSolicitud.Location = new Point(600, 409);
            iconEliminarSolicitud.Name = "iconEliminarSolicitud";
            iconEliminarSolicitud.Size = new Size(94, 29);
            iconEliminarSolicitud.TabIndex = 1;
            iconEliminarSolicitud.Text = "Eliminar";
            iconEliminarSolicitud.UseVisualStyleBackColor = true;
            iconEliminarSolicitud.Click += iconEliminarSolicitud_Click;
            // 
            // iconSalir
            // 
            iconSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSalir.IconColor = Color.Black;
            iconSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSalir.Location = new Point(110, 409);
            iconSalir.Name = "iconSalir";
            iconSalir.Size = new Size(94, 29);
            iconSalir.TabIndex = 2;
            iconSalir.Text = "Salir";
            iconSalir.UseVisualStyleBackColor = true;
            iconSalir.Click += iconSalir_Click;
            // 
            // SolicitudesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(iconSalir);
            Controls.Add(iconEliminarSolicitud);
            Controls.Add(dataGridSolicitudes);
            Name = "SolicitudesView";
            Text = "SolicitudesView";
            ((System.ComponentModel.ISupportInitialize)dataGridSolicitudes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridSolicitudes;
        private FontAwesome.Sharp.IconButton iconEliminarSolicitud;
        private FontAwesome.Sharp.IconButton iconSalir;
    }
}