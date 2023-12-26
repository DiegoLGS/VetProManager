using System;
using VeterinariaLib;

namespace VetProManager
{
    public partial class FrmVetProManager : Form
    {
        private ListaAnimales animalesActuales;
        private ListaPersonas personasActuales;
        private AdministradorBD administradorBD;

        public FrmVetProManager()
        {
            InitializeComponent();
            this.animalesActuales = new ListaAnimales();
            this.personasActuales = new ListaPersonas();
            this.administradorBD = new AdministradorBD();
        }

        private void ActualizarLista()
        {
            this.dgvPacientes.Rows.Clear();

            if (this.animalesActuales.listaAnimalesActuales.Any())
            {
                try
                {
                    foreach (Animal animal in this.animalesActuales.listaAnimalesActuales)
                    {

                        int fila = this.dgvPacientes.Rows.Add();
                        this.dgvPacientes.Rows[fila].Cells[0].Value = animal.Id;
                        this.dgvPacientes.Rows[fila].Cells[1].Value = animal.Nombre;
                        this.dgvPacientes.Rows[fila].Cells[2].Value = animal.Especie;
                        this.dgvPacientes.Rows[fila].Cells[3].Value = animal.FechaIngreso;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show($"Error al actualizar la lista: {ex.Message}", "Error al mostrar la lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Se produjo un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = this.dgvPacientes.CurrentRow;

            if (filaSeleccionada == null)
            {
                return;
            }

            int indice = filaSeleccionada.Index;
            Animal animalAEliminar = this.animalesActuales.listaAnimalesActuales[indice];

            if (MessageBox.Show("¿Estás seguro de que deseas eliminar a este animal? Estos cambios serán permanentes.", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool eliminado = this.animalesActuales - animalAEliminar;
                _ = this.administradorBD.Eliminar("animales", "id", animalAEliminar.Id);

                if (eliminado)
                {
                    this.ActualizarLista();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmPaciente formPaciente = new FrmPaciente(this.personasActuales);

            while (true)
            {
                formPaciente.ShowDialog();

                if (formPaciente.DialogResult == DialogResult.OK)
                {
                    if (formPaciente.ObtenerEstadoRdoDueñoRegistrado())
                    {
                        if (this.AgregarAnimal(formPaciente.NuevoAnimal))
                        {
                            this.ActualizarLista();
                            break;
                        }
                    }
                    else
                    {
                        if (this.AgregarDueño(formPaciente.NuevaPersona))
                        {
                            this.AgregarAnimal(formPaciente.NuevoAnimal);
                            this.ActualizarLista();
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private bool AgregarAnimal(Animal animalParaAgregar)
        {
            bool respuesta = this.animalesActuales + animalParaAgregar;

            if (respuesta)
            {
                administradorBD.AgregarBD(animalParaAgregar);
                this.animalesActuales.listaAnimalesActuales[this.animalesActuales.listaAnimalesActuales.Count - 1].Id = administradorBD.idGenerado;
            }
            else
            {
                MessageBox.Show("El animal que intentó ingresar ya existe en la lista.", "No se agregó el animal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return respuesta;
        }

        private bool AgregarDueño(Persona personaParaAgregar)
        {
            bool respuesta = this.personasActuales + personaParaAgregar;
            if (respuesta)
            {
                administradorBD.AgregarBD(personaParaAgregar);
            }
            else
            {
                MessageBox.Show($"Ya existe una persona registrada con el DNI: {personaParaAgregar.Dni}.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return respuesta;
        }

        private void btnInformacionDetallada_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = this.dgvPacientes.CurrentRow;

            if (filaSeleccionada == null)
            {
                return;
            }

            int indice = filaSeleccionada.Index;
            Animal animalSeleccionado = this.animalesActuales.listaAnimalesActuales[indice];
            MessageBox.Show(animalSeleccionado.MostrarDetallesDatos(), "Informacion detallada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerRegistroPersonas_Click(object sender, EventArgs e)
        {
            FrmRegistroPersonas formPersonasRegistradas = new FrmRegistroPersonas(this.personasActuales.listaPersonasActuales, this.animalesActuales.listaAnimalesActuales);
            formPersonasRegistradas.Show();
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = this.dgvPacientes.CurrentRow;

            if (filaSeleccionada == null)
            {
                return;
            }

            int indice = filaSeleccionada.Index;
            Animal animalSeleccionado = this.animalesActuales.listaAnimalesActuales[indice];
            FrmHistorial formHistorial = new FrmHistorial(animalSeleccionado);
            formHistorial.Show();
        }

        private void FrmVetProManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación de cierre", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = this.dgvPacientes.CurrentRow;

            if (filaSeleccionada == null)
            {
                return;
            }

            int indice = filaSeleccionada.Index;
            Animal animalSeleccionado = this.animalesActuales.listaAnimalesActuales[indice];
            Persona personaSeleccionada = null;
            int idOriginalAnimal = animalSeleccionado.Id;
            int dniOriginal = 0;
            int indicePersona = 0;


            foreach (Persona persona in this.personasActuales.listaPersonasActuales)
            {
                if (persona.Dni == animalSeleccionado.DniDelResponsable)
                {
                    personaSeleccionada = persona;
                    dniOriginal = persona.Dni;
                    indicePersona = personasActuales.listaPersonasActuales.IndexOf(persona);
                    break;
                }
            }

            FrmPaciente formAnimalSeleccionado = new FrmPaciente(this.personasActuales, animalSeleccionado, personaSeleccionada);

            while (true)
            {
                formAnimalSeleccionado.ShowDialog();

                if (formAnimalSeleccionado.DialogResult == DialogResult.OK)
                {
                    bool coincidencia;

                    coincidencia = ListaPersonas.ComprobarCoindicencia(this.personasActuales, personaSeleccionada, indicePersona);

                    if (coincidencia)
                    {
                        MessageBox.Show("El DNI ingresado coincide con el que ya tiene una persona, vuelvalo a intentar.", "Error al modificar los datos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        this.animalesActuales.listaAnimalesActuales[indice] = formAnimalSeleccionado.NuevoAnimal;
                        this.animalesActuales.listaAnimalesActuales[indice].Id = idOriginalAnimal;
                        this.personasActuales.listaPersonasActuales[indicePersona] = formAnimalSeleccionado.NuevaPersona;

                        foreach (Animal animal in this.animalesActuales.listaAnimalesActuales)
                        {
                            if (animal.DniDelResponsable == dniOriginal && animal.Id != animalSeleccionado.Id)
                            {
                                animal.NombreDelResponsable = formAnimalSeleccionado.NuevaPersona.Nombre;
                                animal.ApellidoDelResponsable = formAnimalSeleccionado.NuevaPersona.Apellido;
                                animal.DniDelResponsable = formAnimalSeleccionado.NuevaPersona.Dni;

                                Animal animalActualizado = new Animal(animal.Nombre, animal.FechaNacimiento, animal.FechaIngreso, animal.Especie, animal.Observaciones, animal.HistorialMedico, formAnimalSeleccionado.NuevaPersona.Nombre, formAnimalSeleccionado.NuevaPersona.Apellido, formAnimalSeleccionado.NuevaPersona.Dni);
                                this.administradorBD.ModificarPorId(animalActualizado, animal.Id);
                            }
                        }

                        this.administradorBD.ModificarPorId(formAnimalSeleccionado.NuevoAnimal, animalSeleccionado.Id);
                        this.administradorBD.ModificarPorId(formAnimalSeleccionado.NuevaPersona, dniOriginal);

                        this.ActualizarLista();

                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private void FrmVetProManager_Load(object sender, EventArgs e)
        {
            this.animalesActuales.listaAnimalesActuales = administradorBD.ObtenerListaAnimales();
            this.personasActuales.listaPersonasActuales = administradorBD.ObtenerListaPersonas();
            this.ActualizarLista();
        }
    }
}