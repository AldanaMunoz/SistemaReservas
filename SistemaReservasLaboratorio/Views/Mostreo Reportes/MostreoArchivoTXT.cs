using SistemaReservasLaboratorio.Controllers;
using SistemaReservasLaboratorio.Exceptions;
using SistemaReservasLaboratorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReservasLaboratorio.Views.Mostreo_Reportes
{
    internal class MostreoArchivoTXT // Metodo deberia de mostrar toda la info en un texto .txt
    {
        /*private void cargardatosejemplo()
        {
            configurar columnas del datagridview
            datagridview1.columns.add("id", "id");
            datagridview1.columns.add("nombre", "nombre");
            datagridview1.columns.add("edad", "edad");
            datagridview1.columns.add("ciudad", "ciudad");

            agregar datos de ejemplo
            datagridview1.rows.add("1", "juan pérez", "30", "buenos aires");
            datagridview1.rows.add("2", "maría gonzález", "25", "rosario");
            datagridview1.rows.add("3", "carlos lópez", "35", "córdoba");
            datagridview1.rows.add("4", "ana martínez", "28", "mendoza");
        }
        */

        public FormRegistros formulario = new FormRegistros();

        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Configurar el cuadro de diálogo para guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog.Title = "Guardar archivo de texto";
            saveFileDialog.FileName = "datos_exportados.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportarDataGridViewATexto(formulario.dgv_registroreserva, saveFileDialog.FileName);
                    MessageBox.Show("Datos exportados exitosamente a:\n" + saveFileDialog.FileName,
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        // Método alternativo: Exportar con formato CSV
        private void ExportarACSV(DataGridView dgv, string rutaArchivo)
        {
            StringBuilder sb = new StringBuilder();

            // Escribir encabezados
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                sb.Append(dgv.Columns[i].HeaderText);
                if (i < dgv.Columns.Count - 1)
                    sb.Append(",");
            }
            sb.AppendLine();

            // Escribir filas
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        string valor = row.Cells[i].Value?.ToString() ?? "";

                        // Si el valor contiene comas, envolverlo en comillas
                        if (valor.Contains(","))
                            valor = "\"" + valor + "\"";

                        sb.Append(valor);

                        if (i < dgv.Columns.Count - 1)
                            sb.Append(",");
                    }
                    sb.AppendLine();
                }
            }

            File.WriteAllText(rutaArchivo, sb.ToString(), Encoding.UTF8);
        }
    }
}
