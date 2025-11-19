using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Registro_Alumnos
{
    public static class Validaciones
    {
        // -------------------------------------------------------------
        // VALIDACIONES DE TEXTO
        // -------------------------------------------------------------

        public static bool EsCampoVacio(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }

        public static bool EsLetraEspacioOControl(char caracter)
        {
            return char.IsLetter(caracter) ||
                   char.IsControl(caracter) ||
                   caracter == ' ';
        }

        public static bool EsCaracterCedulaValido(char caracter, string textoActual)
        {
            // Permitir dígitos
            if (char.IsDigit(caracter)) return true;

            // Permitir backspace
            if (caracter == (char)8) return true;

            // Validar guiones
            if (caracter == '-')
            {
                if (textoActual.Length == 0) return false;
                if (textoActual.EndsWith("-")) return false;
                return true;
            }

            return false;
        }

        // -------------------------------------------------------------
        // VALIDACIÓN DE NOMBRE
        // -------------------------------------------------------------

        public static (bool esValido, string mensaje) ValidarNombre(string nombre)
        {
            if (EsCampoVacio(nombre))
            {
                return (false, "El campo Nombre es obligatorio.");
            }

            return (true, string.Empty);
        }

        // -------------------------------------------------------------
        // VALIDACIÓN DE CÉDULA
        // -------------------------------------------------------------

        public static (bool esValido, string mensaje) ValidarCedula(string cedula)
        {
            if (EsCampoVacio(cedula))
            {
                return (false, "El campo Cédula es obligatorio.");
            }

            if (cedula.Length < 5)
            {
                return (false, "La cédula debe tener más caracteres.");
            }

            return (true, string.Empty);
        }

        // -------------------------------------------------------------
        // VALIDACIÓN DE CONTRASEÑA
        // -------------------------------------------------------------

        public static (bool esValido, string mensaje) ValidarContrasena(string contrasena)
        {
            if (EsCampoVacio(contrasena))
            {
                return (false, "El campo Contraseña es obligatorio.");
            }

            if (contrasena.Length < 8)
            {
                return (false, "La contraseña debe tener al menos 8 caracteres.");
            }

            return (true, string.Empty);
        }

        public static (bool esValido, string mensaje) ValidarConfirmacionContrasena(
            string contrasena, string confirmacion)
        {
            if (contrasena != confirmacion)
            {
                return (false, "Las contraseñas no coinciden.");
            }

            return (true, string.Empty);
        }

        // -------------------------------------------------------------
        // VALIDACIÓN DE COMBOS
        // -------------------------------------------------------------

        public static (bool esValido, string mensaje) ValidarComboBox(
            int indiceSeleccionado, string nombreCampo)
        {
            if (indiceSeleccionado == -1)
            {
                return (false, $"Debe seleccionar {nombreCampo}.");
            }

            return (true, string.Empty);
        }

        // -------------------------------------------------------------
        // VALIDACIÓN DE CHECKBOX
        // -------------------------------------------------------------

        public static (bool esValido, string mensaje) ValidarCheckBox(
            bool estaSeleccionado, string mensaje)
        {
            if (!estaSeleccionado)
            {
                return (false, mensaje);
            }

            return (true, string.Empty);
        }

        // -------------------------------------------------------------
        // VALIDACIÓN DE CÓDIGO DE ACCESO
        // -------------------------------------------------------------

        public static (bool esValido, string tipoUsuario) ValidarCodigoAcceso(
            string codigo, string codigoAdmin, string codigoProfesor)
        {
            if (EsCampoVacio(codigo))
            {
                return (false, string.Empty);
            }

            string codigoNormalizado = codigo.Trim().ToUpper();

            if (codigoNormalizado == codigoAdmin)
            {
                return (true, "Administrador");
            }

            if (codigoNormalizado == codigoProfesor)
            {
                return (true, "Profesor");
            }

            return (false, string.Empty);
        }
    }
    }
