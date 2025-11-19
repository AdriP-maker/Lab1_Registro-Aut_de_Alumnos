namespace Sistema_Registro_Alumnos
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Label lblIntentos;

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
            panelHeader = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            panelMain = new Panel();
            lblIntentos = new Label();
            lblAyuda = new Label();
            btnCancelar = new Button();
            btnIngresar = new Button();
            txtCodigo = new TextBox();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(500, 120);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(85, 85, 85);
            lblSubtitulo.Location = new Point(170, 76);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(158, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Control de Acceso";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(65, 105, 225);
            lblTitulo.Location = new Point(104, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(299, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Sistema de Registro";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(lblIntentos);
            panelMain.Controls.Add(lblAyuda);
            panelMain.Controls.Add(btnCancelar);
            panelMain.Controls.Add(btnIngresar);
            panelMain.Controls.Add(txtCodigo);
            panelMain.Location = new Point(50, 150);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(400, 280);
            panelMain.TabIndex = 1;
            // 
            // lblIntentos
            // 
            lblIntentos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntentos.ForeColor = Color.FromArgb(150, 150, 150);
            lblIntentos.Location = new Point(12, 10);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(385, 40);
            lblIntentos.TabIndex = 5;
            lblIntentos.Text = "Ingrese su código para acceder al sistema";
            lblIntentos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAyuda
            // 
            lblAyuda.AutoSize = true;
            lblAyuda.Cursor = Cursors.Hand;
            lblAyuda.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblAyuda.ForeColor = Color.FromArgb(65, 105, 225);
            lblAyuda.Location = new Point(145, 250);
            lblAyuda.Name = "lblAyuda";
            lblAyuda.Size = new Size(124, 20);
            lblAyuda.TabIndex = 4;
            lblAyuda.Text = "¿Necesita ayuda?";
            lblAyuda.Click += lblAyuda_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 67, 54);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(30, 195);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(340, 45);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "❌ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(76, 175, 80);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(30, 140);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(340, 45);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "🔓 Ingresar al Sistema";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI", 14F);
            txtCodigo.Location = new Point(30, 75);
            txtCodigo.MaxLength = 20;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(340, 39);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(500, 460);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de Acceso - Sistema de Registro";
            Load += FormLogin_Load;
            panelHeader.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}