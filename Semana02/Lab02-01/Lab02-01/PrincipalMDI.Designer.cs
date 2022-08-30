namespace Lab02_01
{
    partial class PrincipalMDI
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
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mantenimiento,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Mantenimiento
            // 
            this.Mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuProductos,
            this.mnuCategorias,
            this.mnuProveedores,
            this.mnuClientes});
            this.Mantenimiento.Name = "Mantenimiento";
            this.Mantenimiento.Size = new System.Drawing.Size(101, 20);
            this.Mantenimiento.Text = "Mantenimiento";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.registrarCompraToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeVentaToolStripMenuItem,
            this.reporteDeComprasToolStripMenuItem,
            this.inventarioDeProductosToolStripMenuItem,
            this.reporteDeProveedoresToolStripMenuItem,
            this.reporteDeUsuariosToolStripMenuItem,
            this.reportesDeClientesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelSistemaToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuProductos
            // 
            this.mnuProductos.Name = "mnuProductos";
            this.mnuProductos.Size = new System.Drawing.Size(180, 22);
            this.mnuProductos.Text = "Productos";
            // 
            // mnuCategorias
            // 
            this.mnuCategorias.Name = "mnuCategorias";
            this.mnuCategorias.Size = new System.Drawing.Size(180, 22);
            this.mnuCategorias.Text = "Categorias";
            // 
            // mnuProveedores
            // 
            this.mnuProveedores.Name = "mnuProveedores";
            this.mnuProveedores.Size = new System.Drawing.Size(180, 22);
            this.mnuProveedores.Text = "Proveedores";
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(180, 22);
            this.mnuClientes.Text = "Clientes";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarToolStripMenuItem.Text = "Registrar Venta";
            // 
            // registrarCompraToolStripMenuItem
            // 
            this.registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            this.registrarCompraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarCompraToolStripMenuItem.Text = "Registrar Compra";
            // 
            // reporteDeVentaToolStripMenuItem
            // 
            this.reporteDeVentaToolStripMenuItem.Name = "reporteDeVentaToolStripMenuItem";
            this.reporteDeVentaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.reporteDeVentaToolStripMenuItem.Text = "Reporte de Venta";
            // 
            // reporteDeComprasToolStripMenuItem
            // 
            this.reporteDeComprasToolStripMenuItem.Name = "reporteDeComprasToolStripMenuItem";
            this.reporteDeComprasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.reporteDeComprasToolStripMenuItem.Text = "Reporte de Compras";
            // 
            // inventarioDeProductosToolStripMenuItem
            // 
            this.inventarioDeProductosToolStripMenuItem.Name = "inventarioDeProductosToolStripMenuItem";
            this.inventarioDeProductosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.inventarioDeProductosToolStripMenuItem.Text = "Inventario de Productos";
            // 
            // reporteDeProveedoresToolStripMenuItem
            // 
            this.reporteDeProveedoresToolStripMenuItem.Name = "reporteDeProveedoresToolStripMenuItem";
            this.reporteDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.reporteDeProveedoresToolStripMenuItem.Text = "Reporte de Proveedores";
            // 
            // reporteDeUsuariosToolStripMenuItem
            // 
            this.reporteDeUsuariosToolStripMenuItem.Name = "reporteDeUsuariosToolStripMenuItem";
            this.reporteDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.reporteDeUsuariosToolStripMenuItem.Text = "Reporte de Usuarios";
            // 
            // reportesDeClientesToolStripMenuItem
            // 
            this.reportesDeClientesToolStripMenuItem.Name = "reportesDeClientesToolStripMenuItem";
            this.reportesDeClientesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.reportesDeClientesToolStripMenuItem.Text = "Reportes de Clientes";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}