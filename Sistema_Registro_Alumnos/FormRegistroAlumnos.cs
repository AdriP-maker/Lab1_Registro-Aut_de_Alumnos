using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sistema_Registro_Alumnos
{
    public partial class FormRegistroAlumnos : Form
    {
        private Operaciones operaciones;

        public FormRegistroAlumnos(Operaciones ops)
        {
            InitializeComponent();
            operaciones = ops;
            ConfigurarMenu();
        }

        private void ConfigurarMenu()
        {
            ToolStripMenuItem menuArchivo = new ToolStripMenuItem("Archivo");

            ToolStripMenuItem menuNuevo = new ToolStripMenuItem("Nuevo");
            menuNuevo.ShortcutKeys = Keys.Control | Keys.N;
            menuNuevo.Click += MenuNuevo_Click;

            ToolStripMenuItem menuGuardar = new ToolStripMenuItem("Guardar");
            menuGuardar.ShortcutKeys = Keys.Control | Keys.S;
            menuGuardar.Click += MenuGuardar_Click;

            ToolStripMenuItem menuSalir = new ToolStripMenuItem("Salir");
            menuSalir.Click += MenuSalir_Click;

            menuArchivo.DropDownItems.Add(menuNuevo);
            menuArchivo.DropDownItems.Add(menuGuardar);
            menuArchivo.DropDownItems.Add(new ToolStripSeparator());
            menuArchivo.DropDownItems.Add(menuSalir);

            ToolStripMenuItem menuAyuda = new ToolStripMenuItem("Ayuda");
            ToolStripMenuItem menuAcercaDe = new ToolStripMenuItem("Acerca de");
            menuAcercaDe.Click += MenuAcercaDe_Click;
            menuAyuda.DropDownItems.Add(menuAcercaDe);

            menuPrincipal.Items.Add(menuArchivo);
            menuPrincipal.Items.Add(menuAyuda);
        }

        private void FormRegistroAlumnos_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        // -------------------------------------------------------------
        // VALIDACIONES DE ENTRADA (KeyPress)
        // -------------------------------------------------------------

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.EsLetraEspacioOControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.EsCaracterCedulaValido(e.KeyChar, txtCedula.Text))
            {
                e.Handled = true;
            }
        }

        // -------------------------------------------------------------
        // EVENTOS DE CAMBIO
        // -------------------------------------------------------------

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = operaciones.GenerarUsuario(txtNombre.Text, txtCedula.Text);
        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = operaciones.GenerarUsuario(txtNombre.Text, txtCedula.Text);
        }

        // -------------------------------------------------------------
        // VALIDACIONES AL PERDER EL FOCO
        // -------------------------------------------------------------

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            var validacion = Validaciones.ValidarNombre(txtNombre.Text);
            if (!validacion.esValido)
            {
                e.Cancel = true;
                MessageBox.Show(validacion.mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCedula_Validating(object sender, CancelEventArgs e)
        {
            var validacion = Validaciones.ValidarCedula(txtCedula.Text);
            if (!validacion.esValido)
            {
                e.Cancel = true;
                MessageBox.Show(validacion.mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtContrasena_Validating(object sender, CancelEventArgs e)
        {
            var validacion = Validaciones.ValidarContrasena(txtContrasena.Text);
            if (!validacion.esValido)
            {
                e.Cancel = true;
                MessageBox.Show(validacion.mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // -------------------------------------------------------------
        // GUARDAR ALUMNO
        // -------------------------------------------------------------

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormularioCompleto())
            {
                return;
            }

            Alumno nuevoAlumno = new Alumno
            {
                Nombre = txtNombre.Text.Trim(),
                Cedula = txtCedula.Text.Trim(),
                Usuario = txtUsuario.Text.Trim(),
                Contrasena = txtContrasena.Text,
                Carrera = cmbCarrera.Text,
                Semestre = cmbSemestre.Text,
                Jornada = rbMatutina.Checked ? "Matutina" : "Vespertina",
                AceptoTerminos = chkTerminos.Checked,
                RecibirNotificaciones = chkNotificaciones.Checked
            };

            var resultado = operaciones.RegistrarAlumno(nuevoAlumno);

            if (resultado.exito)
            {
                ActualizarListaAlumnos();
                MessageBox.Show(resultado.mensaje, "Guardado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show(resultado.mensaje, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarFormularioCompleto()
        {
            var validacionNombre = Validaciones.ValidarNombre(txtNombre.Text);
            if (!validacionNombre.esValido)
            {
                MessageBox.Show(validacionNombre.mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            var validacionCedula = Validaciones.ValidarCedula(txtCedula.Text);
            if (!validacionCedula.esValido)
            {
                MessageBox.Show(validacionCedula.mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.Focus();
                return false;
            }

            var validacionContrasena = Validaciones.ValidarContrasena(txtContrasena.Text);
            if (!validacionContrasena.esValido)
            {
                MessageBox.Show(validacionContrasena.mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return false;
            }

            var validacionCarrera = Validaciones.ValidarComboBox(
                cmbCarrera.SelectedIndex, "una carrera");
            if (!validacionCarrera.esValido)
            {
                MessageBox.Show(validacionCarrera.mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var validacionSemestre = Validaciones.ValidarComboBox(
                cmbSemestre.SelectedIndex, "un semestre");
            if (!validacionSemestre.esValido)
            {
                MessageBox.Show(validacionSemestre.mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var validacionConfirmacion = Validaciones.ValidarConfirmacionContrasena(
                txtContrasena.Text, txtConfirmarContrasena.Text);
            if (!validacionConfirmacion.esValido)
            {
                MessageBox.Show(validacionConfirmacion.mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var validacionTerminos = Validaciones.ValidarCheckBox(
                chkTerminos.Checked, "Debe aceptar los términos y condiciones.");
            if (!validacionTerminos.esValido)
            {
                MessageBox.Show(validacionTerminos.mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ActualizarListaAlumnos()
        {
            lstAlumnos.Items.Clear();
            var alumnos = operaciones.ObtenerAlumnosComoTexto();
            foreach (var alumno in alumnos)
            {
                lstAlumnos.Items.Add(alumno);
            }
        }

        // -------------------------------------------------------------
        // LIMPIAR FORMULARIO
        // -------------------------------------------------------------

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtCedula.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtConfirmarContrasena.Clear();
            cmbCarrera.SelectedIndex = -1;
            cmbSemestre.SelectedIndex = -1;
            rbMatutina.Checked = true;
            chkTerminos.Checked = false;
            chkNotificaciones.Checked = false;
            txtNombre.Focus();
        }

        // -------------------------------------------------------------
        // ATAJOS DE TECLADO
        // -------------------------------------------------------------

        private void FormRegistroAlumnos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                BtnGuardar_Click(sender, e);
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                LimpiarFormulario();
            }
        }

        // -------------------------------------------------------------
        // EVENTOS DEL MENÚ
        // -------------------------------------------------------------

        private void MenuNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void MenuGuardar_Click(object sender, EventArgs e)
        {
            BtnGuardar_Click(sender, e);
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea salir del sistema?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MenuAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Sistema de Registro de Alumnos\nVersión 1.0\nProgramado por: Akira Kurusu",
                "Acerca de",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void gbCredenciales_Enter(object sender, EventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }
    }
}