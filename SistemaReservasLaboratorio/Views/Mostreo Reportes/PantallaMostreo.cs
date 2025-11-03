using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaReservasLaboratorio.Controllers;
using SistemaReservasLaboratorio.Exceptions;
using SistemaReservasLaboratorio.Models;

namespace SistemaReservasLaboratorio.Views.Mostreo_Reportes
{
    public class PantallaMostreo // Metodo deberia de mostrar toda la info en un FORM
    {
        private ControladorReserva controladorReserva = new ControladorReserva();
        private ControladorLaboratorio controladorLaboratorio = new ControladorLaboratorio();

        public FormRegistros formulario = new FormRegistros();
        public void CargarLaboratorios() //carga laboratorios
        {
            try
            {
                var laboratorios = controladorLaboratorio.ObtenerTodosLosLaboratorios();
                //formulario.dgv_registrolaboratorio.DataSource = null;
                formulario.dgv_registrolaboratorio.DataSource = laboratorios;
                //formulario.dgv_registrolaboratorio.DisplayMember = "NumeroAsignado";
                //formulario.dgv_registrolaboratorio.ValueMember = "IdLaboratorio";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar laboratorios: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarReservas()
        {
            try
            {
                var reservas = controladorReserva.ObtenerTodasLasReservas();
                //formulario.dgv_registrolaboratorio.DataSource = null;
                formulario.dgv_registroreserva.DataSource = reservas;
                //lblResultados.Text = $"Total: {reservas.Count} reservas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reservas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
