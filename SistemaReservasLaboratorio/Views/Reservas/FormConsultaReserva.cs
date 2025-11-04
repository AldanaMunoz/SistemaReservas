using SistemaReservasLaboratorio.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReservasLaboratorio.Views.Reservas
{
    public partial class FormConsultaReserva : Form
    {
        private ControladorReserva controlador;
        private BindingSource reservasBinding = new BindingSource();

        public FormConsultaReserva()
        {
            InitializeComponent();
            controlador = new ControladorReserva();
            ConfigurarDataGridView();
            dgvReservas.DataSource = reservasBinding;
        }
        private void ConfigurarDataGridView()
        {
            dgvReservas.AutoGenerateColumns = false;
            dgvReservas.Columns.Clear();

            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "IdReserva",
                Width = 50
            });

            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tipo",
                DataPropertyName = "TipoReserva",
                Width = 100
            });

            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Asignatura",
                DataPropertyName = "Asignatura",
                Width = 150
            });

            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Profesor",
                DataPropertyName = "Profesor",
                Width = 150
            });

            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha Inicio",
                DataPropertyName = "FechaHoraInicio",
                Width = 150
            });

            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha Fin",
                DataPropertyName = "FechaHoraFin",
                Width = 150
            });

            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Carrera",
                DataPropertyName = "Carrera",
                Width = 120
            });
        }
        private void btnBuscarTodas_Click(object sender, EventArgs e)
        {
            try
            {
                // recreate controller to force repository reload from DB
                controlador = new ControladorReserva();
                var reservas = controlador.ObtenerTodasLasReservas() ?? new List<Models.Reserva>();
                reservasBinding.DataSource = reservas;
                dgvReservas.Refresh();
                lblResultados.Text = $"Total: {reservas.Count} reservas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reservas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscarPorFecha_Click(object sender, EventArgs e)
        {
            try
            {
                // refresh controller to ensure latest data
                controlador = new ControladorReserva();
                var reservas = controlador.BuscarReservasPorFecha(dtpFechaBusqueda.Value);
                reservasBinding.DataSource = reservas;
                dgvReservas.Refresh();
                lblResultados.Text = $"Encontradas: {reservas.Count} reservas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar reservas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscarPorProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProfesorBusqueda.Text))
                {
                    MessageBox.Show("Ingrese el nombre del profesor", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                controlador = new ControladorReserva();
                var reservas = controlador.BuscarReservasPorProfesor(txtProfesorBusqueda.Text);
                reservasBinding.DataSource = reservas;
                dgvReservas.Refresh();
                lblResultados.Text = $"Encontradas: {reservas.Count} reservas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar reservas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscarPorAsignatura_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAsignaturaBusqueda.Text))
                {
                    MessageBox.Show("Ingrese el nombre de la asignatura", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                controlador = new ControladorReserva();
                var reservas = controlador.BuscarReservasPorAsignatura(txtAsignaturaBusqueda.Text);
                reservasBinding.DataSource = reservas;
                dgvReservas.Refresh();
                lblResultados.Text = $"Encontradas: {reservas.Count} reservas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar reservas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConsultaReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
