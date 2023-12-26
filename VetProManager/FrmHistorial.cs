using System.Text;
using VeterinariaLib;

namespace VetProManager
{
    public partial class FrmHistorial : Form
    {
        public FrmHistorial(Animal animal)
        {
            InitializeComponent();
            this.CargarHistorial(animal);
        }

        private void CargarHistorial(Animal animal)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Observaciones: {animal.Observaciones}");
            sb.AppendLine($"Historial: {animal.HistorialMedico}");

            this.txtHistorial.Text = sb.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
