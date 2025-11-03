namespace SistemaReservasLaboratorio.Views
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónDeReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeLaboratoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónDeLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeLaboratoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generaciónDeReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrantesDelDesarrolloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeReservasToolStripMenuItem,
            this.gestiónDeLaboratoriosToolStripMenuItem,
            this.generaciónDeReportesToolStripMenuItem,
            this.integrantesDelDesarrolloToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gestiónDeReservasToolStripMenuItem
            // 
            this.gestiónDeReservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeReservaToolStripMenuItem,
            this.modificaciónDeReservaToolStripMenuItem,
            this.bajaDeReservaToolStripMenuItem,
            this.consultaDeReservasToolStripMenuItem});
            this.gestiónDeReservasToolStripMenuItem.Name = "gestiónDeReservasToolStripMenuItem";
            this.gestiónDeReservasToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.gestiónDeReservasToolStripMenuItem.Text = "Gestión de Reservas";
            // 
            // altaDeReservaToolStripMenuItem
            // 
            this.altaDeReservaToolStripMenuItem.Name = "altaDeReservaToolStripMenuItem";
            this.altaDeReservaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.altaDeReservaToolStripMenuItem.Text = "Alta de Reserva";
            this.altaDeReservaToolStripMenuItem.Click += new System.EventHandler(this.altaReservaToolStripMenuItem_Click);
            // 
            // modificaciónDeReservaToolStripMenuItem
            // 
            this.modificaciónDeReservaToolStripMenuItem.Name = "modificaciónDeReservaToolStripMenuItem";
            this.modificaciónDeReservaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.modificaciónDeReservaToolStripMenuItem.Text = "Modificación de Reserva";
            this.modificaciónDeReservaToolStripMenuItem.Click += new System.EventHandler(this.modificacionReservaToolStripMenuItem_Click);
            // 
            // bajaDeReservaToolStripMenuItem
            // 
            this.bajaDeReservaToolStripMenuItem.Name = "bajaDeReservaToolStripMenuItem";
            this.bajaDeReservaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.bajaDeReservaToolStripMenuItem.Text = "Baja de Reserva";
            this.bajaDeReservaToolStripMenuItem.Click += new System.EventHandler(this.bajaReservaToolStripMenuItem_Click);
            // 
            // consultaDeReservasToolStripMenuItem
            // 
            this.consultaDeReservasToolStripMenuItem.Name = "consultaDeReservasToolStripMenuItem";
            this.consultaDeReservasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.consultaDeReservasToolStripMenuItem.Text = "Consulta de Reservas";
            this.consultaDeReservasToolStripMenuItem.Click += new System.EventHandler(this.consultaReservasToolStripMenuItem_Click);
            // 
            // gestiónDeLaboratoriosToolStripMenuItem
            // 
            this.gestiónDeLaboratoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeLaboratorioToolStripMenuItem,
            this.modificaciónDeLaboratorioToolStripMenuItem,
            this.bajaDeLaboratorioToolStripMenuItem,
            this.consultaDeLaboratoriosToolStripMenuItem});
            this.gestiónDeLaboratoriosToolStripMenuItem.Name = "gestiónDeLaboratoriosToolStripMenuItem";
            this.gestiónDeLaboratoriosToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.gestiónDeLaboratoriosToolStripMenuItem.Text = "Gestión de Laboratorios";
            // 
            // altaDeLaboratorioToolStripMenuItem
            // 
            this.altaDeLaboratorioToolStripMenuItem.Name = "altaDeLaboratorioToolStripMenuItem";
            this.altaDeLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.altaDeLaboratorioToolStripMenuItem.Text = "Alta de Laboratorio";
            this.altaDeLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.altaLaboratorioToolStripMenuItem_Click);
            // 
            // modificaciónDeLaboratorioToolStripMenuItem
            // 
            this.modificaciónDeLaboratorioToolStripMenuItem.Name = "modificaciónDeLaboratorioToolStripMenuItem";
            this.modificaciónDeLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.modificaciónDeLaboratorioToolStripMenuItem.Text = "Modificación de Laboratorio";
            this.modificaciónDeLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.modificacionLaboratorioToolStripMenuItem_Click);
            // 
            // bajaDeLaboratorioToolStripMenuItem
            // 
            this.bajaDeLaboratorioToolStripMenuItem.Name = "bajaDeLaboratorioToolStripMenuItem";
            this.bajaDeLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.bajaDeLaboratorioToolStripMenuItem.Text = "Baja de Laboratorio";
            this.bajaDeLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.bajaLaboratorioToolStripMenuItem_Click);
            // 
            // consultaDeLaboratoriosToolStripMenuItem
            // 
            this.consultaDeLaboratoriosToolStripMenuItem.Name = "consultaDeLaboratoriosToolStripMenuItem";
            this.consultaDeLaboratoriosToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.consultaDeLaboratoriosToolStripMenuItem.Text = "Consulta de Laboratorios";
            this.consultaDeLaboratoriosToolStripMenuItem.Click += new System.EventHandler(this.consultaLaboratoriosToolStripMenuItem_Click);
            // 
            // generaciónDeReportesToolStripMenuItem
            // 
            this.generaciónDeReportesToolStripMenuItem.Name = "generaciónDeReportesToolStripMenuItem";
            this.generaciónDeReportesToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.generaciónDeReportesToolStripMenuItem.Text = "Generación de Reportes";
            this.generaciónDeReportesToolStripMenuItem.Click += new System.EventHandler(this.generacionReportesToolStripMenuItem_Click);
            // 
            // integrantesDelDesarrolloToolStripMenuItem
            // 
            this.integrantesDelDesarrolloToolStripMenuItem.Name = "integrantesDelDesarrolloToolStripMenuItem";
            this.integrantesDelDesarrolloToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.integrantesDelDesarrolloToolStripMenuItem.Text = "Integrantes del Desarrollo";
            this.integrantesDelDesarrolloToolStripMenuItem.Click += new System.EventHandler(this.integrantesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónDeReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeLaboratoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónDeLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeLaboratoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generaciónDeReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrantesDelDesarrolloToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

