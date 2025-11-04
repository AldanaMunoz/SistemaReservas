using SistemaReservasLaboratorio.Controllers;
using SistemaReservasLaboratorio.Models;
using System;
using System.Windows.Forms;

namespace SistemaReservasLaboratorio.Views.Laboratorios
{
    public partial class FormModificarLaboratorio : Form
    {
        private ControladorLaboratorio controlador;

        public FormModificarLaboratorio()
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

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un laboratorio para modificar.", "Atención",
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

            // Abrir formulario de edición y pasar datos
            using (var formEditar = new FormAltaLaboratorio())
            {
                formEditar.SetLaboratorio(lab);
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    // recargar
                    MessageBox.Show("Laboratorio modificado.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLaboratorios();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
