namespace ScanDesktop.Views
{
    partial class ManwhaAgregarEditarView
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControlManwha = new TabControl();
            tabPageLista = new TabPage();
            btnEliminarIcon = new FontAwesome.Sharp.IconButton();
            btnEditarIcon = new FontAwesome.Sharp.IconButton();
            btnAgregarIcon = new FontAwesome.Sharp.IconButton();
            btnBuscarIcon = new FontAwesome.Sharp.IconButton();
            txtBuscarManwha = new TextBox();
            label1 = new Label();
            dataGridManwhas = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnConfirmar = new FontAwesome.Sharp.IconButton();
            checkBoxPopular = new CheckBox();
            txtUrl = new TextBox();
            numericCapManwha = new NumericUpDown();
            txtSinopsisManwha = new TextBox();
            txtNombreManwha = new TextBox();
            label6 = new Label();
            picturePortada = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            tabControlManwha.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridManwhas).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCapManwha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePortada).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlManwha
            // 
            tabControlManwha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlManwha.Controls.Add(tabPageLista);
            tabControlManwha.Controls.Add(tabPageAgregarEditar);
            tabControlManwha.Location = new Point(13, 66);
            tabControlManwha.Name = "tabControlManwha";
            tabControlManwha.SelectedIndex = 0;
            tabControlManwha.Size = new Size(761, 393);
            tabControlManwha.TabIndex = 0;
            // 
            // tabPageLista
            // 
            tabPageLista.BackColor = Color.MediumPurple;
            tabPageLista.Controls.Add(btnEliminarIcon);
            tabPageLista.Controls.Add(btnEditarIcon);
            tabPageLista.Controls.Add(btnAgregarIcon);
            tabPageLista.Controls.Add(btnBuscarIcon);
            tabPageLista.Controls.Add(txtBuscarManwha);
            tabPageLista.Controls.Add(label1);
            tabPageLista.Controls.Add(dataGridManwhas);
            tabPageLista.Location = new Point(4, 29);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(753, 360);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            // 
            // btnEliminarIcon
            // 
            btnEliminarIcon.Anchor = AnchorStyles.Right;
            btnEliminarIcon.BackColor = Color.DarkSlateBlue;
            btnEliminarIcon.Font = new Font("Segoe UI", 10F);
            btnEliminarIcon.ForeColor = SystemColors.ButtonFace;
            btnEliminarIcon.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            btnEliminarIcon.IconColor = Color.WhiteSmoke;
            btnEliminarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarIcon.IconSize = 35;
            btnEliminarIcon.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarIcon.Location = new Point(622, 213);
            btnEliminarIcon.Name = "btnEliminarIcon";
            btnEliminarIcon.Size = new Size(111, 43);
            btnEliminarIcon.TabIndex = 6;
            btnEliminarIcon.Text = "Eliminar";
            btnEliminarIcon.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarIcon.UseVisualStyleBackColor = false;
            btnEliminarIcon.Click += btnEliminarIcon_Click;
            // 
            // btnEditarIcon
            // 
            btnEditarIcon.Anchor = AnchorStyles.Right;
            btnEditarIcon.BackColor = Color.DarkSlateBlue;
            btnEditarIcon.Font = new Font("Segoe UI", 10F);
            btnEditarIcon.ForeColor = SystemColors.ButtonFace;
            btnEditarIcon.IconChar = FontAwesome.Sharp.IconChar.FileCircleQuestion;
            btnEditarIcon.IconColor = Color.White;
            btnEditarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarIcon.IconSize = 35;
            btnEditarIcon.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarIcon.Location = new Point(622, 147);
            btnEditarIcon.Name = "btnEditarIcon";
            btnEditarIcon.Size = new Size(111, 45);
            btnEditarIcon.TabIndex = 5;
            btnEditarIcon.Text = "Editar";
            btnEditarIcon.TextAlign = ContentAlignment.MiddleRight;
            btnEditarIcon.UseVisualStyleBackColor = false;
            btnEditarIcon.Click += btnEditarIcon_Click;
            // 
            // btnAgregarIcon
            // 
            btnAgregarIcon.Anchor = AnchorStyles.Right;
            btnAgregarIcon.BackColor = Color.DarkSlateBlue;
            btnAgregarIcon.Font = new Font("Segoe UI", 10F);
            btnAgregarIcon.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarIcon.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregarIcon.IconColor = Color.White;
            btnAgregarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarIcon.IconSize = 35;
            btnAgregarIcon.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarIcon.Location = new Point(622, 83);
            btnAgregarIcon.Name = "btnAgregarIcon";
            btnAgregarIcon.Size = new Size(111, 48);
            btnAgregarIcon.TabIndex = 4;
            btnAgregarIcon.Text = "Agregar";
            btnAgregarIcon.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarIcon.UseVisualStyleBackColor = false;
            btnAgregarIcon.Click += btnAgregarIcon_Click;
            // 
            // btnBuscarIcon
            // 
            btnBuscarIcon.BackColor = Color.DarkSlateBlue;
            btnBuscarIcon.Font = new Font("Segoe UI", 10F);
            btnBuscarIcon.ForeColor = SystemColors.ControlLightLight;
            btnBuscarIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarIcon.IconColor = Color.WhiteSmoke;
            btnBuscarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarIcon.IconSize = 30;
            btnBuscarIcon.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarIcon.Location = new Point(493, 6);
            btnBuscarIcon.Name = "btnBuscarIcon";
            btnBuscarIcon.Size = new Size(112, 40);
            btnBuscarIcon.TabIndex = 3;
            btnBuscarIcon.Text = "Buscar";
            btnBuscarIcon.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarIcon.UseVisualStyleBackColor = false;
            btnBuscarIcon.Click += btnBuscarIcon_Click;
            // 
            // txtBuscarManwha
            // 
            txtBuscarManwha.Location = new Point(73, 14);
            txtBuscarManwha.Name = "txtBuscarManwha";
            txtBuscarManwha.Size = new Size(414, 27);
            txtBuscarManwha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // dataGridManwhas
            // 
            dataGridManwhas.AllowUserToAddRows = false;
            dataGridManwhas.AllowUserToDeleteRows = false;
            dataGridManwhas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridManwhas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridManwhas.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridManwhas.Location = new Point(3, 62);
            dataGridManwhas.Name = "dataGridManwhas";
            dataGridManwhas.ReadOnly = true;
            dataGridManwhas.RowHeadersWidth = 51;
            dataGridManwhas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridManwhas.Size = new Size(602, 231);
            dataGridManwhas.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.BackColor = Color.MediumPurple;
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnConfirmar);
            tabPageAgregarEditar.Controls.Add(checkBoxPopular);
            tabPageAgregarEditar.Controls.Add(txtUrl);
            tabPageAgregarEditar.Controls.Add(numericCapManwha);
            tabPageAgregarEditar.Controls.Add(txtSinopsisManwha);
            tabPageAgregarEditar.Controls.Add(txtNombreManwha);
            tabPageAgregarEditar.Controls.Add(label6);
            tabPageAgregarEditar.Controls.Add(picturePortada);
            tabPageAgregarEditar.Controls.Add(label5);
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(label3);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 29);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(753, 360);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.DarkSlateBlue;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = SystemColors.ControlLight;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 35;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(573, 298);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 38);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.BackColor = Color.DarkSlateBlue;
            btnConfirmar.Font = new Font("Segoe UI", 10F);
            btnConfirmar.ForeColor = SystemColors.ButtonHighlight;
            btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            btnConfirmar.IconColor = Color.WhiteSmoke;
            btnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmar.IconSize = 35;
            btnConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.Location = new Point(440, 298);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(127, 38);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // checkBoxPopular
            // 
            checkBoxPopular.Anchor = AnchorStyles.Right;
            checkBoxPopular.AutoSize = true;
            checkBoxPopular.Location = new Point(394, 267);
            checkBoxPopular.Name = "checkBoxPopular";
            checkBoxPopular.Size = new Size(18, 17);
            checkBoxPopular.TabIndex = 10;
            checkBoxPopular.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            txtUrl.Anchor = AnchorStyles.Right;
            txtUrl.Location = new Point(394, 220);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(249, 27);
            txtUrl.TabIndex = 9;
            // 
            // numericCapManwha
            // 
            numericCapManwha.Anchor = AnchorStyles.Right;
            numericCapManwha.Location = new Point(394, 63);
            numericCapManwha.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            numericCapManwha.Name = "numericCapManwha";
            numericCapManwha.Size = new Size(150, 27);
            numericCapManwha.TabIndex = 8;
            // 
            // txtSinopsisManwha
            // 
            txtSinopsisManwha.Anchor = AnchorStyles.Right;
            txtSinopsisManwha.Location = new Point(394, 107);
            txtSinopsisManwha.Multiline = true;
            txtSinopsisManwha.Name = "txtSinopsisManwha";
            txtSinopsisManwha.Size = new Size(263, 97);
            txtSinopsisManwha.TabIndex = 7;
            // 
            // txtNombreManwha
            // 
            txtNombreManwha.Anchor = AnchorStyles.Right;
            txtNombreManwha.Location = new Point(394, 12);
            txtNombreManwha.Name = "txtNombreManwha";
            txtNombreManwha.Size = new Size(140, 27);
            txtNombreManwha.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(298, 262);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 5;
            label6.Text = "Popular:";
            // 
            // picturePortada
            // 
            picturePortada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picturePortada.Location = new Point(21, 17);
            picturePortada.Name = "picturePortada";
            picturePortada.Size = new Size(231, 319);
            picturePortada.SizeMode = PictureBoxSizeMode.Zoom;
            picturePortada.TabIndex = 4;
            picturePortada.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(294, 221);
            label5.Name = "label5";
            label5.Size = new Size(94, 23);
            label5.TabIndex = 3;
            label5.Text = "ImagenUrl:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(295, 107);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 2;
            label4.Text = "Sinopsis:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(295, 63);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 1;
            label3.Text = "Capitulos:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(295, 13);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 54);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(17, 9);
            label7.Name = "label7";
            label7.Size = new Size(232, 37);
            label7.TabIndex = 0;
            label7.Text = "Manwhas(Comics)";
            // 
            // ManwhaAgregarEditarView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(794, 475);
            Controls.Add(panel1);
            Controls.Add(tabControlManwha);
            Name = "ManwhaAgregarEditarView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManwhasView";
            tabControlManwha.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridManwhas).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericCapManwha).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePortada).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlManwha;
        private TabPage tabPageLista;
        private TabPage tabPageAgregarEditar;
        private DataGridView dataGridManwhas;
        private FontAwesome.Sharp.IconButton btnBuscarIcon;
        private TextBox txtBuscarManwha;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnEliminarIcon;
        private FontAwesome.Sharp.IconButton btnEditarIcon;
        private FontAwesome.Sharp.IconButton btnAgregarIcon;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private PictureBox picturePortada;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnConfirmar;
        private CheckBox checkBoxPopular;
        private TextBox txtUrl;
        private NumericUpDown numericCapManwha;
        private TextBox txtSinopsisManwha;
        private TextBox txtNombreManwha;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private Panel panel1;
        private Label label7;
    }
}