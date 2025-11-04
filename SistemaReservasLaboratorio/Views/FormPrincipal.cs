using SistemaReservasLaboratorio.Views.Laboratorios;
using SistemaReservasLaboratorio.Views.Reservas;
using SistemaReservasLaboratorio.Views.Mostreo_Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReservasLaboratorio.Views
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            ConfigurarMenu();
        }

        private void ConfigurarMenu()
        {
            this.Text = "Sistema de Reservas de Laboratorio";
            this.WindowState = FormWindowState.Maximized;
        }

        private void altaReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaReserva formAlta = new FormAltaReserva();
            formAlta.ShowDialog();
        }
        private void modificacionReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarReserva formModificar = new FormModificarReserva();
            formModificar.ShowDialog();
        }

        private void bajaReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBajaReserva formBaja = new FormBajaReserva();
            formBaja.ShowDialog();
        }

        private void consultaReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaReserva formConsulta = new FormConsultaReserva();
            formConsulta.ShowDialog();
        }
        //Gestión de Laboratorios
        private void altaLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaLaboratorio formAlta = new FormAltaLaboratorio();
            formAlta.ShowDialog();
        }

        private void modificacionLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarLaboratorio formModificar = new FormModificarLaboratorio();
            formModificar.ShowDialog();
        }

        private void bajaLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBajaLaboratorio formBaja = new FormBajaLaboratorio();
            formBaja.ShowDialog();
        }

        private void consultaLaboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaLaboratorio formConsulta = new FormConsultaLaboratorio();
            formConsulta.ShowDialog();
        }
        private void generacionReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir pantalla de mostreo de reportes
                PantallaMostreo pantalla = new PantallaMostreo();
                // Cargar datos en el formulario interno
                pantalla.CargarLaboratorios();
                pantalla.CargarReservas();
                pantalla.formulario.Text = "Mostreo de Reportes";
                pantalla.formulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir módulo de reportes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.FormIntegrantes formIntegrantes = new Views.FormIntegrantes();
            formIntegrantes.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
