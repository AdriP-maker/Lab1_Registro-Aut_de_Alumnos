namespace Sistema_Registro_Alumnos
{
    partial class FormRegistroAlumnos
    {
        private System.ComponentModel.IContainer components = null;

        // Controles del formulario
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.GroupBox gbCredenciales;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.RadioButton rbMatutina;
        private System.Windows.Forms.RadioButton rbVespertina;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.CheckBox chkTerminos;
        private System.Windows.Forms.CheckBox chkNotificaciones;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblJornada;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Panel panelHeader;


        // Limpiar los recursos que se esten usando
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codigo generado por el Diseñador de Windows Forms

        // Metodo necesario para admitir el Diseñador
        // No se puede modificar el contenido de este metodo con el editor de codigo
        private void InitializeComponent()
        {
            menuPrincipal = new MenuStrip();
            panelHeader = new Panel();
            lblTitulo = new Label();
            gbDatosPersonales = new GroupBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCedula = new Label();
            txtCedula = new TextBox();
            lblCarrera = new Label();
            cmbCarrera = new ComboBox();
            lblSemestre = new Label();
            cmbSemestre = new ComboBox();
            lblJornada = new Label();
            rbMatutina = new RadioButton();
            rbVespertina = new RadioButton();
            gbCredenciales = new GroupBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblConfirmar = new Label();
            txtConfirmarContrasena = new TextBox();
            chkTerminos = new CheckBox();
            chkNotificaciones = new CheckBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            lblAlumnos = new Label();
            lstAlumnos = new ListBox();
            panelHeader.SuspendLayout();
            gbDatosPersonales.SuspendLayout();
            gbCredenciales.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.BackColor = Color.FromArgb(245, 245, 250);
            menuPrincipal.ImageScalingSize = new Size(20, 20);
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Padding = new Padding(8, 3, 0, 3);
            menuPrincipal.Size = new Size(1000, 24);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "menuStrip1";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 24);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 80);
            panelHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(65, 105, 225);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1000, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Registro de Alumnos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // gbDatosPersonales
            // 
            gbDatosPersonales.BackColor = Color.White;
            gbDatosPersonales.Controls.Add(lblNombre);
            gbDatosPersonales.Controls.Add(txtNombre);
            gbDatosPersonales.Controls.Add(lblCedula);
            gbDatosPersonales.Controls.Add(txtCedula);
            gbDatosPersonales.Controls.Add(lblCarrera);
            gbDatosPersonales.Controls.Add(cmbCarrera);
            gbDatosPersonales.Controls.Add(lblSemestre);
            gbDatosPersonales.Controls.Add(cmbSemestre);
            gbDatosPersonales.Controls.Add(lblJornada);
            gbDatosPersonales.Controls.Add(rbMatutina);
            gbDatosPersonales.Controls.Add(rbVespertina);
            gbDatosPersonales.FlatStyle = FlatStyle.Flat;
            gbDatosPersonales.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbDatosPersonales.ForeColor = Color.FromArgb(51, 51, 51);
            gbDatosPersonales.Location = new Point(30, 130);
            gbDatosPersonales.Name = "gbDatosPersonales";
            gbDatosPersonales.Padding = new Padding(15);
            gbDatosPersonales.Size = new Size(460, 380);
            gbDatosPersonales.TabIndex = 2;
            gbDatosPersonales.TabStop = false;
            gbDatosPersonales.Text = "Datos Personales";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.5F);
            lblNombre.ForeColor = Color.FromArgb(85, 85, 85);
            lblNombre.Location = new Point(20, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(150, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre Completo:*";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(20, 65);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(415, 30);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += TxtNombre_TextChanged;
            txtNombre.KeyPress += TxtNombre_KeyPress;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 9.5F);
            lblCedula.ForeColor = Color.FromArgb(85, 85, 85);
            lblCedula.Location = new Point(20, 110);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(68, 21);
            lblCedula.TabIndex = 2;
            lblCedula.Text = "Cédula:*";
            // 
            // txtCedula
            // 
            txtCedula.BorderStyle = BorderStyle.FixedSingle;
            txtCedula.Font = new Font("Segoe UI", 10F);
            txtCedula.Location = new Point(20, 135);
            txtCedula.MaxLength = 15;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(200, 30);
            txtCedula.TabIndex = 3;
            txtCedula.TextChanged += TxtCedula_TextChanged;
            txtCedula.KeyPress += TxtCedula_KeyPress;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 9.5F);
            lblCarrera.ForeColor = Color.FromArgb(85, 85, 85);
            lblCarrera.Location = new Point(20, 180);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(72, 21);
            lblCarrera.TabIndex = 4;
            lblCarrera.Text = "Carrera:*";
            // 
            // cmbCarrera
            // 
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.FlatStyle = FlatStyle.Flat;
            cmbCarrera.Font = new Font("Segoe UI", 10F);
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Items.AddRange(new object[] { "Ingeniería en Sistemas", "Ingeniería Civil", "Medicina", "Derecho", "Administración", "Arquitectura" });
            cmbCarrera.Location = new Point(20, 205);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(200, 31);
            cmbCarrera.TabIndex = 5;
            // 
            // lblSemestre
            // 
            lblSemestre.AutoSize = true;
            lblSemestre.Font = new Font("Segoe UI", 9.5F);
            lblSemestre.ForeColor = Color.FromArgb(85, 85, 85);
            lblSemestre.Location = new Point(235, 180);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(85, 21);
            lblSemestre.TabIndex = 6;
            lblSemestre.Text = "Semestre:*";
            // 
            // cmbSemestre
            // 
            cmbSemestre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestre.FlatStyle = FlatStyle.Flat;
            cmbSemestre.Font = new Font("Segoe UI", 10F);
            cmbSemestre.FormattingEnabled = true;
            cmbSemestre.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbSemestre.Location = new Point(235, 205);
            cmbSemestre.Name = "cmbSemestre";
            cmbSemestre.Size = new Size(200, 31);
            cmbSemestre.TabIndex = 7;
            // 
            // lblJornada
            // 
            lblJornada.AutoSize = true;
            lblJornada.Font = new Font("Segoe UI", 9.5F);
            lblJornada.ForeColor = Color.FromArgb(85, 85, 85);
            lblJornada.Location = new Point(20, 255);
            lblJornada.Name = "lblJornada";
            lblJornada.Size = new Size(75, 21);
            lblJornada.TabIndex = 8;
            lblJornada.Text = "Jornada:*";
            // 
            // rbMatutina
            // 
            rbMatutina.AutoSize = true;
            rbMatutina.Checked = true;
            rbMatutina.Cursor = Cursors.Hand;
            rbMatutina.Font = new Font("Segoe UI", 10F);
            rbMatutina.ForeColor = Color.FromArgb(85, 85, 85);
            rbMatutina.Location = new Point(20, 285);
            rbMatutina.Name = "rbMatutina";
            rbMatutina.Size = new Size(100, 27);
            rbMatutina.TabIndex = 9;
            rbMatutina.TabStop = true;
            rbMatutina.Text = "Matutina";
            rbMatutina.UseVisualStyleBackColor = true;
            // 
            // rbVespertina
            // 
            rbVespertina.AutoSize = true;
            rbVespertina.Cursor = Cursors.Hand;
            rbVespertina.Font = new Font("Segoe UI", 10F);
            rbVespertina.ForeColor = Color.FromArgb(85, 85, 85);
            rbVespertina.Location = new Point(140, 285);
            rbVespertina.Name = "rbVespertina";
            rbVespertina.Size = new Size(111, 27);
            rbVespertina.TabIndex = 10;
            rbVespertina.Text = "Vespertina";
            rbVespertina.UseVisualStyleBackColor = true;
            // 
            // gbCredenciales
            // 
            gbCredenciales.BackColor = Color.White;
            gbCredenciales.Controls.Add(lblUsuario);
            gbCredenciales.Controls.Add(txtUsuario);
            gbCredenciales.Controls.Add(lblContrasena);
            gbCredenciales.Controls.Add(txtContrasena);
            gbCredenciales.Controls.Add(lblConfirmar);
            gbCredenciales.Controls.Add(txtConfirmarContrasena);
            gbCredenciales.Controls.Add(chkTerminos);
            gbCredenciales.Controls.Add(chkNotificaciones);
            gbCredenciales.FlatStyle = FlatStyle.Flat;
            gbCredenciales.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbCredenciales.ForeColor = Color.FromArgb(51, 51, 51);
            gbCredenciales.Location = new Point(510, 130);
            gbCredenciales.Name = "gbCredenciales";
            gbCredenciales.Padding = new Padding(15);
            gbCredenciales.Size = new Size(460, 380);
            gbCredenciales.TabIndex = 3;
            gbCredenciales.TabStop = false;
            gbCredenciales.Text = "Credenciales de Acceso";
            gbCredenciales.Enter += gbCredenciales_Enter;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.5F);
            lblUsuario.ForeColor = Color.FromArgb(85, 85, 85);
            lblUsuario.Location = new Point(20, 40);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(147, 21);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario (generado):";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(240, 240, 240);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.Location = new Point(20, 65);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(415, 30);
            txtUsuario.TabIndex = 1;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 9.5F);
            lblContrasena.ForeColor = Color.FromArgb(85, 85, 85);
            lblContrasena.Location = new Point(20, 110);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(99, 21);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "Contraseña:*";
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.Font = new Font("Segoe UI", 10F);
            txtContrasena.Location = new Point(20, 135);
            txtContrasena.MaxLength = 12;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '●';
            txtContrasena.Size = new Size(415, 30);
            txtContrasena.TabIndex = 3;
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Font = new Font("Segoe UI", 9.5F);
            lblConfirmar.ForeColor = Color.FromArgb(85, 85, 85);
            lblConfirmar.Location = new Point(20, 180);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(174, 21);
            lblConfirmar.TabIndex = 4;
            lblConfirmar.Text = "Confirmar Contraseña:*";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarContrasena.Font = new Font("Segoe UI", 10F);
            txtConfirmarContrasena.Location = new Point(20, 205);
            txtConfirmarContrasena.MaxLength = 12;
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PasswordChar = '●';
            txtConfirmarContrasena.Size = new Size(415, 30);
            txtConfirmarContrasena.TabIndex = 5;
            // 
            // chkTerminos
            // 
            chkTerminos.AutoSize = true;
            chkTerminos.Cursor = Cursors.Hand;
            chkTerminos.Font = new Font("Segoe UI", 9.5F);
            chkTerminos.ForeColor = Color.FromArgb(85, 85, 85);
            chkTerminos.Location = new Point(20, 260);
            chkTerminos.Name = "chkTerminos";
            chkTerminos.Size = new Size(275, 25);
            chkTerminos.TabIndex = 6;
            chkTerminos.Text = "Acepto los términos y condiciones*";
            chkTerminos.UseVisualStyleBackColor = true;
            // 
            // chkNotificaciones
            // 
            chkNotificaciones.AutoSize = true;
            chkNotificaciones.Cursor = Cursors.Hand;
            chkNotificaciones.Font = new Font("Segoe UI", 9.5F);
            chkNotificaciones.ForeColor = Color.FromArgb(85, 85, 85);
            chkNotificaciones.Location = new Point(20, 300);
            chkNotificaciones.Name = "chkNotificaciones";
            chkNotificaciones.Size = new Size(222, 25);
            chkNotificaciones.TabIndex = 7;
            chkNotificaciones.Text = "Deseo recibir notificaciones";
            chkNotificaciones.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(76, 175, 80);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(30, 530);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(220, 50);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar (Ctrl+S)";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += BtnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(244, 67, 54);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(270, 530);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(220, 50);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar (Esc)";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += BtnLimpiar_Click;
            // 
            // lblAlumnos
            // 
            lblAlumnos.AutoSize = true;
            lblAlumnos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAlumnos.ForeColor = Color.FromArgb(51, 51, 51);
            lblAlumnos.Location = new Point(30, 600);
            lblAlumnos.Name = "lblAlumnos";
            lblAlumnos.Size = new Size(205, 25);
            lblAlumnos.TabIndex = 6;
            lblAlumnos.Text = "Alumnos Registrados:";
            // 
            // lstAlumnos
            // 
            lstAlumnos.BackColor = Color.FromArgb(248, 249, 250);
            lstAlumnos.BorderStyle = BorderStyle.FixedSingle;
            lstAlumnos.Font = new Font("Consolas", 9.5F);
            lstAlumnos.ForeColor = Color.FromArgb(51, 51, 51);
            lstAlumnos.FormattingEnabled = true;
            lstAlumnos.ItemHeight = 19;
            lstAlumnos.Location = new Point(30, 630);
            lstAlumnos.Name = "lstAlumnos";
            lstAlumnos.Size = new Size(940, 135);
            lstAlumnos.TabIndex = 7;
            // 
            // FormRegistroAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1000, 798);
            Controls.Add(lstAlumnos);
            Controls.Add(lblAlumnos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(gbCredenciales);
            Controls.Add(gbDatosPersonales);
            Controls.Add(panelHeader);
            Controls.Add(menuPrincipal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MainMenuStrip = menuPrincipal;
            MaximizeBox = false;
            Name = "FormRegistroAlumnos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Registro de Alumnos";
            Load += FormRegistroAlumnos_Load;
            KeyDown += FormRegistroAlumnos_KeyDown;
            panelHeader.ResumeLayout(false);
            gbDatosPersonales.ResumeLayout(false);
            gbDatosPersonales.PerformLayout();
            gbCredenciales.ResumeLayout(false);
            gbCredenciales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
    }
}