using SistemaReservasLaboratorio.Controllers;
using SistemaReservasLaboratorio.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaReservasLaboratorio.Models;

namespace SistemaReservasLaboratorio.Views.Laboratorios
{
    public partial class FormAltaLaboratorio : Form
    {
        private ControladorLaboratorio controlador;
        private int editingLaboratorioId = 0; // 0 = nuevo

        public FormAltaLaboratorio()
        {
            InitializeComponent();
            controlador = new ControladorLaboratorio();
        }

        public void SetLaboratorio(Laboratorio lab)
        {
            if (lab == null) return;
            editingLaboratorioId = lab.IdLaboratorio;
            nudNumeroAsignado.Value = lab.NumeroAsignado;
            txtUbicacionPiso.Text = lab.UbicacionPiso;
            nudCapacidadPuestos.Value = lab.CapacidadPuestos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                int numeroAsignado = (int)nudNumeroAsignado.Value;
                string ubicacionPiso = txtUbicacionPiso.Text.Trim();
                int capacidadPuestos = (int)nudCapacidadPuestos.Value;

                if (editingLaboratorioId > 0)
                {
                    controlador.ModificarLaboratorio(editingLaboratorioId, numeroAsignado, ubicacionPiso, capacidadPuestos);
                    MessageBox.Show("Laboratorio modificado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    controlador.AgregarLaboratorio(numeroAsignado, ubicacionPiso, capacidadPuestos);
                    MessageBox.Show("Laboratorio guardado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Indicar al llamador que se guardó correctamente
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (LaboratorioException ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar laboratorio: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarCampos()
        {
            if (nudNumeroAsignado.Value <= 0)
            {
                MessageBox.Show("El número asignado debe ser mayor a cero", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudNumeroAsignado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUbicacionPiso.Text))
            {
                MessageBox.Show("Debe ingresar la ubicación/piso", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUbicacionPiso.Focus();
                return false;
            }

            if (nudCapacidadPuestos.Value <= 0)
            {
                MessageBox.Show("La capacidad debe ser mayor a cero", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudCapacidadPuestos.Focus();
                return false;
            }

            return true;
        }
        private void LimpiarCampos()
        {
            nudNumeroAsignado.Value = 1;
            txtUbicacionPiso.Clear();
            nudCapacidadPuestos.Value = 1;
            editingLaboratorioId = 0;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormAltaLaboratorio_Load(object sender, EventArgs e)
        {

        }
    }
}
