using SistemaReservasLaboratorio.Controllers;
using SistemaReservasLaboratorio.Models;
using System;
using System.Windows.Forms;

namespace SistemaReservasLaboratorio.Views.Reservas
{
    public partial class FormBajaReserva : Form
    {
        private ControladorReserva controlador;

        public FormBajaReserva()
        {
            InitializeComponent();
            controlador = new ControladorReserva();
            CargarReservas();
        }

        private void CargarReservas()
        {
            try
            {
                var reservas = controlador.ObtenerTodasLasReservas();
                dgvItems.DataSource = reservas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reservas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para eliminar.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var reserva = dgvItems.SelectedRows[0].DataBoundItem as Reserva;
            if (reserva == null)
            {
                MessageBox.Show("Elemento seleccionado no es una reserva válida.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = MessageBox.Show("¿Confirma eliminar la reserva seleccionada?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    controlador.EliminarReserva(reserva.IdReserva);
                    MessageBox.Show("Reserva eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarReservas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar reserva: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
