using SistemaReservasLaboratorio.Controllers;
using SistemaReservasLaboratorio.Models;
using System;
using System.Windows.Forms;

namespace SistemaReservasLaboratorio.Views.Laboratorios
{
    public partial class FormBajaLaboratorio : Form
    {
        private ControladorLaboratorio controlador;

        public FormBajaLaboratorio()
        {
            InitializeComponent();
            controlador = new ControladorLaboratorio();
            CargarLaboratorios();
        }

        private void CargarLaboratorios()
        {
            try
            {
                var labs = controlador.ObtenerTodosLosLaboratorios();
                dgvItems.DataSource = labs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar laboratorios: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un laboratorio para eliminar.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var lab = dgvItems.SelectedRows[0].DataBoundItem as Laboratorio;
            if (lab == null)
            {
                MessageBox.Show("Elemento seleccionado no es un laboratorio válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = MessageBox.Show("¿Confirma eliminar el laboratorio seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    controlador.EliminarLaboratorio(lab.IdLaboratorio);
                    MessageBox.Show("Laboratorio eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLaboratorios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar laboratorio: {ex.Message}", "Error",
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
