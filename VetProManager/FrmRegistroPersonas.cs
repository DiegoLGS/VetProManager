using System.Text;
using VeterinariaLib;

namespace VetProManager
{
    public partial class FrmRegistroPersonas : Form
    {
        public FrmRegistroPersonas(List<Persona> listaPersonas, List<Animal> listaAnimales)
        {
            InitializeComponent();
            this.CargarRegistroPersonas(listaPersonas, listaAnimales);
        }

        private void CargarRegistroPersonas(List<Persona> listaPersonas, List<Animal> listaAnimales)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Persona persona in listaPersonas)
            {
                sb.AppendLine("----------------------------------------------");
                sb.Append(persona.ToString());
                sb.AppendLine($"Dueño de los siguientes animales:");

                foreach (Animal animal in listaAnimales)
                {
                    if (animal.DniDelResponsable == persona.Dni)
                    {
                        sb.AppendLine($"ID: {animal.Id} - Nombre: {animal.Nombre} - Especie: {animal.Especie}");
                    }
                }

                sb.AppendLine("----------------------------------------------");
            }

            this.txtRegistroPersonas.Text = sb.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
