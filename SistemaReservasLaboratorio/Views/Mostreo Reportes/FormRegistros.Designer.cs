namespace SistemaReservasLaboratorio.Views.Mostreo_Reportes
{
    public partial class FormRegistros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.btn_crearTXT = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dgv_registroreserva = new System.Windows.Forms.DataGridView();
            this.dgv_registrolaboratorio = new System.Windows.Forms.DataGridView();
            this.lbl_reservas = new System.Windows.Forms.Label();
            this.lbl_laboratorio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registroreserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registrolaboratorio)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crearTXT
            // 
            this.btn_crearTXT.Location = new System.Drawing.Point(734, 68);
            this.btn_crearTXT.Name = "btn_crearTXT";
            this.btn_crearTXT.Size = new System.Drawing.Size(125, 45);
            this.btn_crearTXT.TabIndex = 0;
            this.btn_crearTXT.Text = "Crear Archivo de texto";
            this.btn_crearTXT.UseVisualStyleBackColor = true;
            this.btn_crearTXT.Click += new System.EventHandler(this.btn_crearTXT_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(734, 368);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(102, 37);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Cerrar";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // dgv_registroreserva
            // 
            this.dgv_registroreserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registroreserva.Location = new System.Drawing.Point(24, 55);
            this.dgv_registroreserva.Name = "dgv_registroreserva";
            this.dgv_registroreserva.Size = new System.Drawing.Size(299, 350);
            this.dgv_registroreserva.TabIndex = 2;
            // 
            // dgv_registrolaboratorio
            // 
            this.dgv_registrolaboratorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registrolaboratorio.Location = new System.Drawing.Point(377, 55);
            this.dgv_registrolaboratorio.Name = "dgv_registrolaboratorio";
            this.dgv_registrolaboratorio.Size = new System.Drawing.Size(315, 350);
            this.dgv_registrolaboratorio.TabIndex = 3;
            // 
            // lbl_reservas
            // 
            this.lbl_reservas.AutoSize = true;
            this.lbl_reservas.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservas.Location = new System.Drawing.Point(97, 17);
            this.lbl_reservas.Name = "lbl_reservas";
            this.lbl_reservas.Size = new System.Drawing.Size(143, 35);
            this.lbl_reservas.TabIndex = 4;
            this.lbl_reservas.Text = "Reservas";
            // 
            // lbl_laboratorio
            // 
            this.lbl_laboratorio.AutoSize = true;
            this.lbl_laboratorio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_laboratorio.Font = new System.Drawing.Font("Cascadia Code", 20.25F);
            this.lbl_laboratorio.Location = new System.Drawing.Point(433, 17);
            this.lbl_laboratorio.Name = "lbl_laboratorio";
            this.lbl_laboratorio.Size = new System.Drawing.Size(207, 35);
            this.lbl_laboratorio.TabIndex = 5;
            this.lbl_laboratorio.Text = "Laboratorios";
            // 
            // FormRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 417);
            this.Controls.Add(this.lbl_laboratorio);
            this.Controls.Add(this.lbl_reservas);
            this.Controls.Add(this.dgv_registrolaboratorio);
            this.Controls.Add(this.dgv_registroreserva);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_crearTXT);
            this.Name = "FormRegistros";
            this.Text = "FormRegistros";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registroreserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registrolaboratorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crearTXT;
        private System.Windows.Forms.Button btn_salir;
        public System.Windows.Forms.DataGridView dgv_registroreserva;
        public System.Windows.Forms.DataGridView dgv_registrolaboratorio;
        private System.Windows.Forms.Label lbl_reservas;
        private System.Windows.Forms.Label lbl_laboratorio;
    }
}