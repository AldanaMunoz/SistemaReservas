using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReservasLaboratorio.Views.Mostreo_Reportes
{
    public partial class FormRegistros : Form
    {
        public FormRegistros()
        {
            InitializeComponent();

        }
        private void ExportarDataGridViewATexto(DataGridView dgv, string rutaArchivo)
        {
            StringBuilder sb = new StringBuilder();

            // Escribir encabezados
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                sb.Append(dgv.Columns[i].HeaderText);
                if (i < dgv.Columns.Count - 1)
                    sb.Append("\t"); // Separador de tabulación
            }
            sb.AppendLine();

            // Línea separadora
            sb.AppendLine(new string('-', 80));

            // Escribir filas
            foreach (DataGridViewRow row in dgv.Rows)
            {
                // Omitir la fila nueva vacía
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        if (row.Cells[i].Value != null)
                            sb.Append(row.Cells[i].Value.ToString());

                        if (i < dgv.Columns.Count - 1)
                            sb.Append("\t");
                    }
                    sb.AppendLine();
                }
            }

            // Guardar el archivo
            File.WriteAllText(rutaArchivo, sb.ToString(), Encoding.UTF8);
        }

        private void btn_crearTXT_Click(object sender, EventArgs e)
        {
           FormRegistros formulario = new FormRegistros();
            // Configurar el cuadro de diálogo para guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog.Title = "Guardar archivo de texto";
            saveFileDialog.FileName = "datos_reserva.txt";
            saveFileDialog2.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog2.Title = "Guardar archivo de texto";
            saveFileDialog2.FileName = "datos_laboratorio.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportarDataGridViewATexto(formulario.dgv_registroreserva, saveFileDialog.FileName);
                    MessageBox.Show("Datos exportados exitosamente a:\n" + saveFileDialog.FileName,
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExportarDataGridViewATexto(formulario.dgv_registrolaboratorio, saveFileDialog2.FileName);
                    MessageBox.Show("Datos exportados exitosamente a:\n" + saveFileDialog2.FileName,
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }// invocar mostreoArchivoTXT
        }
    }
}
