using System;
using System.Text.RegularExpressions;
using VeterinariaLib;

namespace VetProManager
{
    public partial class FrmPaciente : Form
    {
        private Animal nuevoAnimal;
        private Persona nuevaPersona;
        private ListaPersonas personasExistentes;
        private AdministradorBD administradorBD;

        public FrmPaciente(ListaPersonas personasExistentes)
        {
            InitializeComponent();
            this.personasExistentes = personasExistentes;
            this.administradorBD = new AdministradorBD();
        }

        public FrmPaciente(ListaPersonas personasExistentes, Animal animalSeleccionado, Persona personaSeleccionada) : this(personasExistentes)
        {
            this.rdoDueñoNoRegistrado.Checked = true;
            this.rdoDueñoNoRegistrado.Enabled = false;
            this.rdoDueñoRegistrado.Enabled = false;
            this.txtNombreDueño.Text = personaSeleccionada.Nombre;
            this.txtApellidoDueño.Text = personaSeleccionada.Apellido;
            this.txtNumeroContacto.Text = personaSeleccionada.NumeroContacto;
            this.txtDniDueño.Text = personaSeleccionada.Dni.ToString();
            this.txtNombrePaciente.Text = animalSeleccionado.Nombre;
            this.txtEspecie.Text = animalSeleccionado.Especie;
            this.dtpFechaNacimiento.Value = animalSeleccionado.FechaNacimiento;
            this.txtObservaciones.Text = animalSeleccionado.Observaciones;
            this.txtHistorial.Text = animalSeleccionado.HistorialMedico;
        }

        public Animal NuevoAnimal { get { return this.nuevoAnimal; } set { this.nuevoAnimal = value; } }

        public Persona NuevaPersona { get { return this.nuevaPersona; } set { this.nuevaPersona = value; } }

        public bool ObtenerEstadoRdoDueñoRegistrado()
        {
            return this.rdoDueñoRegistrado.Checked;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ComprobarCamposFormulario() && ComprobarExistenciaDueño())
            {
                this.nuevoAnimal = new Animal(this.txtNombrePaciente.Text, this.dtpFechaNacimiento.Value.Date, DateTime.Now, this.txtEspecie.Text, this.txtObservaciones.Text, this.txtHistorial.Text, this.NuevaPersona.Nombre, this.NuevaPersona.Apellido, this.NuevaPersona.Dni);

                this.DialogResult = DialogResult.OK;
            }
        }

        private bool ComprobarExistenciaDueño()
        {
            bool respuesta = true;

            if (this.rdoDueñoNoRegistrado.Checked)
            {
                this.NuevaPersona = new Persona(this.txtNombreDueño.Text, this.txtApellidoDueño.Text, int.Parse(this.txtDniDueño.Text), this.txtNumeroContacto.Text);
            }
            else
            {
                bool personaEncontrada = false;

                foreach (Persona persona in this.personasExistentes.listaPersonasActuales)
                {
                    if (persona.Dni == int.Parse(this.txtDniDueño.Text))
                    {
                        personaEncontrada = true;
                        this.NuevaPersona = new Persona(persona.Nombre, persona.Apellido, persona.Dni, persona.NumeroContacto);
                        break;
                    }
                }

                if (!personaEncontrada)
                {
                    MessageBox.Show($"No existe una persona registrada con el DNI: {this.txtDniDueño.Text}.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                respuesta = personaEncontrada;
            }

            return respuesta;
        }

        private bool ComprobarCamposFormulario()
        {
            bool datosObligatoriosCargados = true;
            bool nombreDueñoValido = true;
            bool apellidoDueñoValido = true;
            bool numeroDeContactoValido = true;
            bool dniDueñoValido = true;
            bool nombrePacienteValido = true;
            bool especiePacienteValido = true;
            bool observacionValido = true;
            bool historialMedicoValido = true;

            if (this.rdoDueñoNoRegistrado.Checked)
            {
                if (this.txtNombreDueño.Text == "" || this.txtApellidoDueño.Text == "" || this.txtNumeroContacto.Text == "")
                {
                    datosObligatoriosCargados = false;
                    MessageBox.Show("Verifique que los campos no esten vacíos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    nombreDueñoValido = ComprobarTexto(this.txtNombreDueño.Text, 30, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", "solo debe contener letras y no debe contener números ni símbolos.");
                    apellidoDueñoValido = ComprobarTexto(this.txtApellidoDueño.Text, 30, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", "solo debe contener letras y no debe contener números ni símbolos.");
                    numeroDeContactoValido = ComprobarTexto(this.txtNumeroContacto.Text, 16, @"^[0-9+-]+$", "solo debe contener números y símbolos como '+' o '-'.");
                }
            }

            if (this.txtDniDueño.Text == "" || this.txtNombrePaciente.Text == "" || this.txtEspecie.Text == "")
            {
                datosObligatoriosCargados = false;
                MessageBox.Show("Verifique que los campos no esten vacíos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dniDueñoValido = ComprobarTexto(this.txtDniDueño.Text, 8, @"^[0-9]+$", "solo debe contener números.");
                nombrePacienteValido = ComprobarTexto(this.txtNombrePaciente.Text, 20, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", "solo debe contener letras y no debe contener números ni símbolos.");
                especiePacienteValido = ComprobarTexto(this.txtEspecie.Text, 20, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", "solo debe contener letras y no debe contener números ni símbolos.");
                observacionValido = ComprobarTexto(this.txtObservaciones.Text, 100, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", "tiene caracteres inválidos.");
                historialMedicoValido = ComprobarTexto(this.txtHistorial.Text, 3000, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", "tiene caracteres inválidos.");
            }

            return datosObligatoriosCargados && nombreDueñoValido && apellidoDueñoValido && numeroDeContactoValido && dniDueñoValido && nombrePacienteValido && especiePacienteValido && observacionValido && historialMedicoValido;
        }

        private bool ComprobarTexto(string texto, int longitudPermitida, string patron, string avisoFalla)
        {
            bool resultado = false;

            if (texto.Length > longitudPermitida)
            {
                MessageBox.Show($"El valor ingresado '{texto}' puede tener un máximo de {longitudPermitida} caracteres.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!Regex.IsMatch(texto, patron) && texto != "")
                {
                    MessageBox.Show($"El valor ingresado '{texto}' {avisoFalla}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        private void rdoDueñoNoRegistrado_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNombreDueño.Enabled = true;
            this.txtApellidoDueño.Enabled = true;
            this.txtNumeroContacto.Enabled = true;
            this.txtDniDueño.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            this.txtDniDueño.AutoCompleteMode = AutoCompleteMode.None;
            this.txtDniDueño.AutoCompleteSource = AutoCompleteSource.None;
        }

        private void rdoDueñoRegistrado_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNombreDueño.Enabled = false;
            this.txtApellidoDueño.Enabled = false;
            this.txtNumeroContacto.Enabled = false;

            AutoCompleteStringCollection fuenteAutocompletado = new AutoCompleteStringCollection();

            foreach (Persona persona in this.personasExistentes.listaPersonasActuales)
            {
                fuenteAutocompletado.Add(persona.Dni.ToString());
            }

            this.txtDniDueño.AutoCompleteCustomSource = fuenteAutocompletado;
            this.txtDniDueño.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtDniDueño.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
