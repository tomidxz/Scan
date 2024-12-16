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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            tabControlManwha.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridManwhas).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCapManwha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePortada).BeginInit();
            SuspendLayout();
            // 
            // tabControlManwha
            // 
            tabControlManwha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlManwha.Controls.Add(tabPageLista);
            tabControlManwha.Controls.Add(tabPageAgregarEditar);
            tabControlManwha.Location = new Point(13, 33);
            tabControlManwha.Name = "tabControlManwha";
            tabControlManwha.SelectedIndex = 0;
            tabControlManwha.Size = new Size(761, 426);
            tabControlManwha.TabIndex = 0;
            // 
            // tabPageLista
            // 
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
            tabPageLista.Size = new Size(753, 393);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // btnEliminarIcon
            // 
            btnEliminarIcon.Anchor = AnchorStyles.Right;
            btnEliminarIcon.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            btnEliminarIcon.IconColor = Color.Black;
            btnEliminarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarIcon.IconSize = 30;
            btnEliminarIcon.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarIcon.Location = new Point(626, 213);
            btnEliminarIcon.Name = "btnEliminarIcon";
            btnEliminarIcon.Size = new Size(103, 36);
            btnEliminarIcon.TabIndex = 6;
            btnEliminarIcon.Text = "Eliminar";
            btnEliminarIcon.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarIcon.UseVisualStyleBackColor = true;
            btnEliminarIcon.Click += btnEliminarIcon_Click;
            // 
            // btnEditarIcon
            // 
            btnEditarIcon.Anchor = AnchorStyles.Right;
            btnEditarIcon.IconChar = FontAwesome.Sharp.IconChar.FileCircleQuestion;
            btnEditarIcon.IconColor = Color.Black;
            btnEditarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarIcon.IconSize = 30;
            btnEditarIcon.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarIcon.Location = new Point(626, 145);
            btnEditarIcon.Name = "btnEditarIcon";
            btnEditarIcon.Size = new Size(103, 36);
            btnEditarIcon.TabIndex = 5;
            btnEditarIcon.Text = "Editar";
            btnEditarIcon.TextAlign = ContentAlignment.MiddleRight;
            btnEditarIcon.UseVisualStyleBackColor = true;
            btnEditarIcon.Click += btnEditarIcon_Click;
            // 
            // btnAgregarIcon
            // 
            btnAgregarIcon.Anchor = AnchorStyles.Right;
            btnAgregarIcon.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregarIcon.IconColor = Color.Black;
            btnAgregarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarIcon.IconSize = 30;
            btnAgregarIcon.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarIcon.Location = new Point(626, 78);
            btnAgregarIcon.Name = "btnAgregarIcon";
            btnAgregarIcon.Size = new Size(103, 36);
            btnAgregarIcon.TabIndex = 4;
            btnAgregarIcon.Text = "Agregar";
            btnAgregarIcon.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarIcon.UseVisualStyleBackColor = true;
            btnAgregarIcon.Click += btnAgregarIcon_Click;
            // 
            // btnBuscarIcon
            // 
            btnBuscarIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarIcon.IconColor = Color.Black;
            btnBuscarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarIcon.IconSize = 30;
            btnBuscarIcon.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarIcon.Location = new Point(496, 6);
            btnBuscarIcon.Name = "btnBuscarIcon";
            btnBuscarIcon.Size = new Size(111, 34);
            btnBuscarIcon.TabIndex = 3;
            btnBuscarIcon.Text = "Buscar";
            btnBuscarIcon.UseVisualStyleBackColor = true;
            btnBuscarIcon.Click += btnBuscarIcon_Click;
            // 
            // txtBuscarManwha
            // 
            txtBuscarManwha.Location = new Point(67, 11);
            txtBuscarManwha.Name = "txtBuscarManwha";
            txtBuscarManwha.Size = new Size(423, 27);
            txtBuscarManwha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // dataGridManwhas
            // 
            dataGridManwhas.AllowUserToAddRows = false;
            dataGridManwhas.AllowUserToDeleteRows = false;
            dataGridManwhas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridManwhas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridManwhas.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridManwhas.Location = new Point(3, 50);
            dataGridManwhas.Name = "dataGridManwhas";
            dataGridManwhas.ReadOnly = true;
            dataGridManwhas.RowHeadersWidth = 51;
            dataGridManwhas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridManwhas.Size = new Size(602, 306);
            dataGridManwhas.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
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
            tabPageAgregarEditar.Size = new Size(753, 393);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 30;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(624, 349);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 38);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            btnConfirmar.IconColor = Color.Black;
            btnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmar.IconSize = 30;
            btnConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.Location = new Point(488, 349);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 38);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // checkBoxPopular
            // 
            checkBoxPopular.Anchor = AnchorStyles.Right;
            checkBoxPopular.AutoSize = true;
            checkBoxPopular.Location = new Point(382, 314);
            checkBoxPopular.Name = "checkBoxPopular";
            checkBoxPopular.Size = new Size(18, 17);
            checkBoxPopular.TabIndex = 10;
            checkBoxPopular.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            txtUrl.Anchor = AnchorStyles.Right;
            txtUrl.Location = new Point(382, 267);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(249, 27);
            txtUrl.TabIndex = 9;
            // 
            // numericCapManwha
            // 
            numericCapManwha.Anchor = AnchorStyles.Right;
            numericCapManwha.Location = new Point(368, 68);
            numericCapManwha.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            numericCapManwha.Name = "numericCapManwha";
            numericCapManwha.Size = new Size(150, 27);
            numericCapManwha.TabIndex = 8;
            // 
            // txtSinopsisManwha
            // 
            txtSinopsisManwha.Anchor = AnchorStyles.Right;
            txtSinopsisManwha.Location = new Point(368, 123);
            txtSinopsisManwha.Multiline = true;
            txtSinopsisManwha.Name = "txtSinopsisManwha";
            txtSinopsisManwha.Size = new Size(263, 125);
            txtSinopsisManwha.TabIndex = 7;
            // 
            // txtNombreManwha
            // 
            txtNombreManwha.Anchor = AnchorStyles.Right;
            txtNombreManwha.Location = new Point(368, 17);
            txtNombreManwha.Name = "txtNombreManwha";
            txtNombreManwha.Size = new Size(140, 27);
            txtNombreManwha.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(299, 311);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 5;
            label6.Text = "Popular:";
            // 
            // picturePortada
            // 
            picturePortada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picturePortada.Location = new Point(21, 17);
            picturePortada.Name = "picturePortada";
            picturePortada.Size = new Size(250, 353);
            picturePortada.SizeMode = PictureBoxSizeMode.Zoom;
            picturePortada.TabIndex = 4;
            picturePortada.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(295, 270);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 3;
            label5.Text = "ImagenUrl:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(295, 123);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 2;
            label4.Text = "Sinopsis:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(295, 70);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 1;
            label3.Text = "Capitulos:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(295, 20);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // ManwhaAgregarEditarView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 475);
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
    }
}