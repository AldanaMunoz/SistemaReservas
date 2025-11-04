using SistemaReservasLaboratorio.Controllers;
using SistemaReservasLaboratorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaReservasLaboratorio.Views.Reservas
{
    public partial class FormModificarReserva : Form
    {
        private ControladorReserva controlador;

        public FormModificarReserva()
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Recargar desde la base de datos
            controlador = new ControladorReserva();
            CargarReservas();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para modificar.", "Atención",
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

            using (var formEditar = new FormAltaReserva())
            {
                // Pasar datos al formulario de alta para editar
                formEditar.SetReserva(reserva);

                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    // Si se guardó en el FormAltaReserva, recargar
                    CargarReservas();
                    MessageBox.Show("Reserva modificada.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
