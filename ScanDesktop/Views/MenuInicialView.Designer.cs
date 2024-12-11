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
            btnListaIcon = new FontAwesome.Sharp.IconMenuItem();
            btnAgregarEditarIcon = new FontAwesome.Sharp.IconMenuItem();
            iconMenuSolicitudes = new FontAwesome.Sharp.IconMenuItem();
            btnDonaciones = new FontAwesome.Sharp.IconMenuItem();
            iconMenuDonador = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            btnDetallesTraducIcon = new FontAwesome.Sharp.IconMenuItem();
            btnTraduccionIcon = new FontAwesome.Sharp.IconMenuItem();
            IconBtnEmpleados = new FontAwesome.Sharp.IconMenuItem();
            iconMenuAgregarDonacion = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnMenuIcon, iconMenuItem2, btnDonaciones, iconMenuItem4, btnTraduccionIcon, IconBtnEmpleados });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(863, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.UseWaitCursor = true;
            // 
            // btnMenuIcon
            // 
            btnMenuIcon.IconChar = FontAwesome.Sharp.IconChar.House;
            btnMenuIcon.IconColor = Color.Black;
            btnMenuIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuIcon.Name = "btnMenuIcon";
            btnMenuIcon.Size = new Size(80, 24);
            btnMenuIcon.Text = "Menu";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { btnListaIcon, btnAgregarEditarIcon, iconMenuSolicitudes });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.Book;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(105, 24);
            iconMenuItem2.Text = "Manwhas";
            // 
            // btnListaIcon
            // 
            btnListaIcon.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnListaIcon.IconColor = Color.Black;
            btnListaIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListaIcon.Name = "btnListaIcon";
            btnListaIcon.Size = new Size(191, 26);
            btnListaIcon.Text = "Listado";
            // 
            // btnAgregarEditarIcon
            // 
            btnAgregarEditarIcon.IconChar = FontAwesome.Sharp.IconChar.PenRuler;
            btnAgregarEditarIcon.IconColor = Color.Black;
            btnAgregarEditarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarEditarIcon.Name = "btnAgregarEditarIcon";
            btnAgregarEditarIcon.Size = new Size(191, 26);
            btnAgregarEditarIcon.Text = "Agregar/Editar";
            btnAgregarEditarIcon.Click += btnAgregarEditarIcon_Click;
            // 
            // iconMenuSolicitudes
            // 
            iconMenuSolicitudes.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuSolicitudes.IconColor = Color.Black;
            iconMenuSolicitudes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuSolicitudes.Name = "iconMenuSolicitudes";
            iconMenuSolicitudes.Size = new Size(191, 26);
            iconMenuSolicitudes.Text = "Solicitudes";
            iconMenuSolicitudes.Click += iconMenuSolicitudes_Click;
            // 
            // btnDonaciones
            // 
            btnDonaciones.DropDownItems.AddRange(new ToolStripItem[] { iconMenuDonador, iconMenuAgregarDonacion });
            btnDonaciones.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            btnDonaciones.IconColor = Color.Black;
            btnDonaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDonaciones.Name = "btnDonaciones";
            btnDonaciones.Size = new Size(121, 24);
            btnDonaciones.Text = "Donaciones";
            btnDonaciones.Click += btnDonaciones_Click;
            // 
            // iconMenuDonador
            // 
            iconMenuDonador.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuDonador.IconColor = Color.Black;
            iconMenuDonador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuDonador.Name = "iconMenuDonador";
            iconMenuDonador.Size = new Size(224, 26);
            iconMenuDonador.Text = "Donadores";
            iconMenuDonador.Click += iconMenuDonador_Click;
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { btnDetallesTraducIcon });
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(96, 24);
            iconMenuItem4.Text = "Reporte";
            // 
            // btnDetallesTraducIcon
            // 
            btnDetallesTraducIcon.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnDetallesTraducIcon.IconColor = Color.Black;
            btnDetallesTraducIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDetallesTraducIcon.Name = "btnDetallesTraducIcon";
            btnDetallesTraducIcon.Size = new Size(243, 26);
            btnDetallesTraducIcon.Text = "Detalles de Traduccion";
            btnDetallesTraducIcon.Click += btnDetallesTraducIcon_Click;
            // 
            // btnTraduccionIcon
            // 
            btnTraduccionIcon.IconChar = FontAwesome.Sharp.IconChar.None;
            btnTraduccionIcon.IconColor = Color.Black;
            btnTraduccionIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTraduccionIcon.Name = "btnTraduccionIcon";
            btnTraduccionIcon.Size = new Size(115, 24);
            btnTraduccionIcon.Text = "Traduccion";
            btnTraduccionIcon.Click += btnTraduccionIcon_Click;
            // 
            // IconBtnEmpleados
            // 
            IconBtnEmpleados.IconChar = FontAwesome.Sharp.IconChar.PeoplePulling;
            IconBtnEmpleados.IconColor = Color.Black;
            IconBtnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconBtnEmpleados.Name = "IconBtnEmpleados";
            IconBtnEmpleados.Size = new Size(117, 24);
            IconBtnEmpleados.Text = "Empleados";
            IconBtnEmpleados.Click += IconBtnEmpleados_Click;
            // 
            // iconMenuAgregarDonacion
            // 
            iconMenuAgregarDonacion.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuAgregarDonacion.IconColor = Color.Black;
            iconMenuAgregarDonacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuAgregarDonacion.Name = "iconMenuAgregarDonacion";
            iconMenuAgregarDonacion.Size = new Size(224, 26);
            iconMenuAgregarDonacion.Text = "Agregar Donacion";
            iconMenuAgregarDonacion.Click += iconMenuAgregarDonacion_Click;
            // 
            // MenuInicialView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private FontAwesome.Sharp.IconMenuItem btnListaIcon;
        private FontAwesome.Sharp.IconMenuItem btnAgregarEditarIcon;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem btnDetallesTraducIcon;
        private FontAwesome.Sharp.IconMenuItem btnTraduccionIcon;
        private FontAwesome.Sharp.IconMenuItem IconBtnEmpleados;
        private FontAwesome.Sharp.IconMenuItem iconMenuDonador;
        private FontAwesome.Sharp.IconMenuItem iconMenuSolicitudes;
        private FontAwesome.Sharp.IconMenuItem iconMenuAgregarDonacion;
    }
}
