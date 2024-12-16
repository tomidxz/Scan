namespace ScanDesktop
{
    partial class MenuInicialView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            btnMenuIcon = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            btnAgregarEditarIcon = new FontAwesome.Sharp.IconMenuItem();
            iconMenuSolicitudes = new FontAwesome.Sharp.IconMenuItem();
            btnDonaciones = new FontAwesome.Sharp.IconMenuItem();
            iconMenuDonador = new FontAwesome.Sharp.IconMenuItem();
            iconMenuAgregarDonacion = new FontAwesome.Sharp.IconMenuItem();
            iconMenuHistorialD = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            btnDetallesTraducIcon = new FontAwesome.Sharp.IconMenuItem();
            btnTraduccionIcon = new FontAwesome.Sharp.IconMenuItem();
            IconBtnEmpleados = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Indigo;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnMenuIcon, iconMenuItem2, btnDonaciones, iconMenuItem4, btnTraduccionIcon, IconBtnEmpleados });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(863, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.UseWaitCursor = true;
            // 
            // btnMenuIcon
            // 
            btnMenuIcon.ForeColor = SystemColors.ButtonFace;
            btnMenuIcon.IconChar = FontAwesome.Sharp.IconChar.House;
            btnMenuIcon.IconColor = Color.White;
            btnMenuIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuIcon.Name = "btnMenuIcon";
            btnMenuIcon.Size = new Size(80, 27);
            btnMenuIcon.Text = "Menu";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.BackColor = Color.Indigo;
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { btnAgregarEditarIcon, iconMenuSolicitudes });
            iconMenuItem2.Font = new Font("Segoe UI", 10F);
            iconMenuItem2.ForeColor = SystemColors.ButtonFace;
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.Book;
            iconMenuItem2.IconColor = Color.White;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(116, 27);
            iconMenuItem2.Text = "Manwhas";
            // 
            // btnAgregarEditarIcon
            // 
            btnAgregarEditarIcon.BackColor = Color.Lavender;
            btnAgregarEditarIcon.IconChar = FontAwesome.Sharp.IconChar.PenRuler;
            btnAgregarEditarIcon.IconColor = Color.Black;
            btnAgregarEditarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarEditarIcon.Name = "btnAgregarEditarIcon";
            btnAgregarEditarIcon.Size = new Size(224, 28);
            btnAgregarEditarIcon.Text = "Agregar/Editar";
            btnAgregarEditarIcon.Click += btnAgregarEditarIcon_Click;
            // 
            // iconMenuSolicitudes
            // 
            iconMenuSolicitudes.BackColor = Color.Lavender;
            iconMenuSolicitudes.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            iconMenuSolicitudes.IconColor = Color.Black;
            iconMenuSolicitudes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuSolicitudes.Name = "iconMenuSolicitudes";
            iconMenuSolicitudes.Size = new Size(224, 28);
            iconMenuSolicitudes.Text = "Solicitudes";
            iconMenuSolicitudes.Click += iconMenuSolicitudes_Click;
            // 
            // btnDonaciones
            // 
            btnDonaciones.DropDownItems.AddRange(new ToolStripItem[] { iconMenuDonador, iconMenuAgregarDonacion, iconMenuHistorialD });
            btnDonaciones.Font = new Font("Segoe UI", 10F);
            btnDonaciones.ForeColor = SystemColors.ButtonFace;
            btnDonaciones.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            btnDonaciones.IconColor = Color.White;
            btnDonaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDonaciones.Name = "btnDonaciones";
            btnDonaciones.Size = new Size(133, 27);
            btnDonaciones.Text = "Donaciones";
            btnDonaciones.Click += btnDonaciones_Click;
            // 
            // iconMenuDonador
            // 
            iconMenuDonador.BackColor = Color.Lavender;
            iconMenuDonador.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuDonador.IconColor = Color.Black;
            iconMenuDonador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuDonador.Name = "iconMenuDonador";
            iconMenuDonador.Size = new Size(274, 28);
            iconMenuDonador.Text = "Donadores";
            iconMenuDonador.Click += iconMenuDonador_Click;
            // 
            // iconMenuAgregarDonacion
            // 
            iconMenuAgregarDonacion.BackColor = Color.Lavender;
            iconMenuAgregarDonacion.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuAgregarDonacion.IconColor = Color.Black;
            iconMenuAgregarDonacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuAgregarDonacion.Name = "iconMenuAgregarDonacion";
            iconMenuAgregarDonacion.Size = new Size(274, 28);
            iconMenuAgregarDonacion.Text = "Agregar Donacion";
            iconMenuAgregarDonacion.Click += iconMenuAgregarDonacion_Click;
            // 
            // iconMenuHistorialD
            // 
            iconMenuHistorialD.BackColor = Color.Lavender;
            iconMenuHistorialD.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuHistorialD.IconColor = Color.Black;
            iconMenuHistorialD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuHistorialD.Name = "iconMenuHistorialD";
            iconMenuHistorialD.Size = new Size(274, 28);
            iconMenuHistorialD.Text = "Historial de Donaciones";
            iconMenuHistorialD.Click += iconMenuHistorialD_Click;
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { btnDetallesTraducIcon });
            iconMenuItem4.Font = new Font("Segoe UI", 10F);
            iconMenuItem4.ForeColor = SystemColors.ButtonFace;
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            iconMenuItem4.IconColor = Color.White;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(104, 27);
            iconMenuItem4.Text = "Reporte";
            // 
            // btnDetallesTraducIcon
            // 
            btnDetallesTraducIcon.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnDetallesTraducIcon.IconColor = Color.Black;
            btnDetallesTraducIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDetallesTraducIcon.Name = "btnDetallesTraducIcon";
            btnDetallesTraducIcon.Size = new Size(266, 28);
            btnDetallesTraducIcon.Text = "Detalles de Traduccion";
            btnDetallesTraducIcon.Click += btnDetallesTraducIcon_Click;
            // 
            // btnTraduccionIcon
            // 
            btnTraduccionIcon.Font = new Font("Segoe UI", 10F);
            btnTraduccionIcon.ForeColor = SystemColors.ButtonFace;
            btnTraduccionIcon.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            btnTraduccionIcon.IconColor = Color.White;
            btnTraduccionIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTraduccionIcon.Name = "btnTraduccionIcon";
            btnTraduccionIcon.Size = new Size(127, 27);
            btnTraduccionIcon.Text = "Traduccion";
            btnTraduccionIcon.Click += btnTraduccionIcon_Click;
            // 
            // IconBtnEmpleados
            // 
            IconBtnEmpleados.Font = new Font("Segoe UI", 10F);
            IconBtnEmpleados.ForeColor = SystemColors.ButtonFace;
            IconBtnEmpleados.IconChar = FontAwesome.Sharp.IconChar.PeoplePulling;
            IconBtnEmpleados.IconColor = Color.White;
            IconBtnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconBtnEmpleados.Name = "IconBtnEmpleados";
            IconBtnEmpleados.Size = new Size(127, 27);
            IconBtnEmpleados.Text = "Empleados";
            IconBtnEmpleados.Click += IconBtnEmpleados_Click;
            // 
            // MenuInicialView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(863, 496);
            Controls.Add(menuStrip1);
            Name = "MenuInicialView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            UseWaitCursor = true;
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem btnMenuIcon;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem btnDonaciones;
        private FontAwesome.Sharp.IconMenuItem btnAgregarEditarIcon;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem btnDetallesTraducIcon;
        private FontAwesome.Sharp.IconMenuItem btnTraduccionIcon;
        private FontAwesome.Sharp.IconMenuItem IconBtnEmpleados;
        private FontAwesome.Sharp.IconMenuItem iconMenuDonador;
        private FontAwesome.Sharp.IconMenuItem iconMenuSolicitudes;
        private FontAwesome.Sharp.IconMenuItem iconMenuAgregarDonacion;
        private FontAwesome.Sharp.IconMenuItem iconMenuHistorialD;
    }
}
