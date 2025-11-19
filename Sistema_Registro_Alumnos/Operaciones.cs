using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Registro_Alumnos
{
    public class Operaciones
    {
        // Códigos de acceso para login
        private const string CODIGO_ADMINISTRADOR = "ADMIN123";
        private const string CODIGO_PROFESOR = "PROF456";
        private const int MAX_INTENTOS = 3;

        // Almacenamiento de alumnos
        private List<Alumno> alumnos;

        // Control de intentos de login
        private int intentosLogin;

        public Operaciones()
        {
            alumnos = new List<Alumno>();
            intentosLogin = 0;
        }

        // -------------------------------------------------------------
        // OPERACIONES DE LOGIN
        // -------------------------------------------------------------

        public (bool exitoso, string mensaje, string tipoUsuario, bool debeBloquear)
            ProcesarLogin(string codigo)
        {
            if (string.IsNullOrEmpty(codigo))
            {
                return (false, "Por favor ingrese un código de acceso.", "", false);
            }

            var validacion = Validaciones.ValidarCodigoAcceso(
                codigo, CODIGO_ADMINISTRADOR, CODIGO_PROFESOR);

            if (validacion.esValido)
            {
                intentosLogin = 0;
                string mensaje = $"¡Bienvenido {validacion.tipoUsuario}!\n\nAcceso concedido al sistema.";
                return (true, mensaje, validacion.tipoUsuario, false);
            }

            // Código incorrecto
            intentosLogin++;
            int intentosRestantes = MAX_INTENTOS - intentosLogin;

            if (intentosLogin >= MAX_INTENTOS)
            {
                string mensaje = "Ha excedido el número máximo de intentos.\n\nEl programa se cerrará por seguridad.";
                return (false, mensaje, "", true);
            }

            string mensajeError = $"Código incorrecto.\n\nIntentos restantes: {intentosRestantes}";
            return (false, mensajeError, "", false);
        }

        public string ObtenerInformacionAyudaLogin()
        {
            return "CÓDIGOS DE ACCESO VÁLIDOS:\n\n" +
                   "• Administrador: ADMIN123\n" +
                   "• Profesor: PROF456\n\n" +
                   "Nota: Los códigos distinguen entre mayúsculas y minúsculas.\n" +
                   $"Tiene {MAX_INTENTOS} intentos antes de que el sistema se cierre.";
        }

        // -------------------------------------------------------------
        // OPERACIONES DE ALUMNO
        // -------------------------------------------------------------

        public string GenerarUsuario(string nombre, string cedula)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(cedula))
            {
                return string.Empty;
            }

            string inicial = nombre.Substring(0, 1).ToLower();
            return inicial + cedula;
        }

        public bool ExisteCedula(string cedula)
        {
            return alumnos.Any(a => a.Cedula == cedula);
        }

        public bool ExisteUsuario(string usuario)
        {
            return alumnos.Any(a => a.Usuario == usuario);
        }

        public (bool exito, string mensaje) RegistrarAlumno(Alumno alumno)
        {
            // Validar duplicados
            if (ExisteCedula(alumno.Cedula))
            {
                return (false, "Ya existe un alumno con esta cédula.");
            }

            if (ExisteUsuario(alumno.Usuario))
            {
                return (false, "El usuario generado ya existe.");
            }

            // Registrar alumno
            alumnos.Add(alumno);
            return (true, "Alumno registrado exitosamente.");
        }

        public List<string> ObtenerAlumnosComoTexto()
        {
            return alumnos.Select(a => a.ToString()).ToList();
        }

        public int ContarAlumnos()
        {
            return alumnos.Count;
        }
    }

    // -------------------------------------------------------------
    // MODELO DE ALUMNO
    // -------------------------------------------------------------

    public class Alumno
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Carrera { get; set; }
        public string Semestre { get; set; }
        public string Jornada { get; set; }
        public bool AceptoTerminos { get; set; }
        public bool RecibirNotificaciones { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Alumno()
        {
            FechaRegistro = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Nombre} | {Cedula} | {Carrera} | Sem {Semestre} | {Jornada} | Usuario: {Usuario}";
        }
    }
}
