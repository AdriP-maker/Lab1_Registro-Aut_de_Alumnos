using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Registro_Alumnos
{
    public partial class FormLogin : Form
    {
        private Operaciones operaciones;

        public FormLogin()
        {
            InitializeComponent();
            operaciones = new Operaciones();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 242, 245);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ProcesarLogin();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                ProcesarLogin();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            int cursorPos = txtCodigo.SelectionStart;
            txtCodigo.Text = txtCodigo.Text.ToUpper();
            txtCodigo.SelectionStart = cursorPos;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                operaciones.ObtenerInformacionAyudaLogin(),
                "Ayuda - Códigos de Acceso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ProcesarLogin()
        {
            var resultado = operaciones.ProcesarLogin(txtCodigo.Text);

            if (resultado.exitoso)
            {
                MessageBox.Show(
                    resultado.mensaje,
                    "Acceso Exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Hide();
                FormRegistroAlumnos formPrincipal = new FormRegistroAlumnos(operaciones);
                formPrincipal.FormClosed += (s, args) => this.Close();
                formPrincipal.Show();
            }
            else
            {
                if (resultado.debeBloquear)
                {
                    MessageBox.Show(
                        resultado.mensaje,
                        "Acceso Denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show(
                        resultado.mensaje,
                        "Error de Acceso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                }
            }
        }

        private void lblCodigo_Click(object sender, EventArgs e) { }
    }

}
