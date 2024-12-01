namespace ScanDesktop.Views
{
    partial class OrigenView
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
            txtOrigen = new TextBox();
            iconGuardarOrigen = new FontAwesome.Sharp.IconButton();
            iconCancelar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 137);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Lugar de Origen:";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(383, 134);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(125, 27);
            txtOrigen.TabIndex = 1;
            // 
            // iconGuardarOrigen
            // 
            iconGuardarOrigen.IconChar = FontAwesome.Sharp.IconChar.None;
            iconGuardarOrigen.IconColor = Color.Black;
            iconGuardarOrigen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconGuardarOrigen.Location = new Point(244, 229);
            iconGuardarOrigen.Name = "iconGuardarOrigen";
            iconGuardarOrigen.Size = new Size(94, 29);
            iconGuardarOrigen.TabIndex = 2;
            iconGuardarOrigen.Text = "Guardar";
            iconGuardarOrigen.UseVisualStyleBackColor = true;
            // 
            // iconCancelar
            // 
            iconCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconCancelar.IconColor = Color.Black;
            iconCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCancelar.Location = new Point(399, 229);
            iconCancelar.Name = "iconCancelar";
            iconCancelar.Size = new Size(94, 29);
            iconCancelar.TabIndex = 3;
            iconCancelar.Text = "Cancelar";
            iconCancelar.UseVisualStyleBackColor = true;
            // 
            // OrigenView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(iconCancelar);
            Controls.Add(iconGuardarOrigen);
            Controls.Add(txtOrigen);
            Controls.Add(label1);
            Name = "OrigenView";
            Text = "OrigenView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOrigen;
        private FontAwesome.Sharp.IconButton iconGuardarOrigen;
        private FontAwesome.Sharp.IconButton iconCancelar;
    }
}