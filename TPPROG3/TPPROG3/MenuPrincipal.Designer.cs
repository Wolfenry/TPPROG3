namespace TPPROG3
{
 partial class menu_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_principal));
            this.mnstp_principal = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNDeDNIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNDeSerieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.repuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRepuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarRepuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porIDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNDeServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstp_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnstp_principal
            // 
            this.mnstp_principal.BackColor = System.Drawing.Color.DarkGray;
            this.mnstp_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.repuestosToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mnstp_principal.Location = new System.Drawing.Point(0, 0);
            this.mnstp_principal.Name = "mnstp_principal";
            this.mnstp_principal.Size = new System.Drawing.Size(800, 24);
            this.mnstp_principal.TabIndex = 0;
            this.mnstp_principal.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.modificarDatosToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.verListadoToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // modificarDatosToolStripMenuItem
            // 
            this.modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
            this.modificarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarDatosToolStripMenuItem.Text = "Modificar Datos";
            this.modificarDatosToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreToolStripMenuItem,
            this.porNDeDNIToolStripMenuItem});
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente/s";
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.porNombreToolStripMenuItem.Text = "Por Nombre";
            // 
            // porNDeDNIToolStripMenuItem
            // 
            this.porNDeDNIToolStripMenuItem.Name = "porNDeDNIToolStripMenuItem";
            this.porNDeDNIToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.porNDeDNIToolStripMenuItem.Text = "Por N° De DNI";
            // 
            // verListadoToolStripMenuItem
            // 
            this.verListadoToolStripMenuItem.Name = "verListadoToolStripMenuItem";
            this.verListadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verListadoToolStripMenuItem.Text = "Ver Listado";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEquipoToolStripMenuItem,
            this.modificarDatosToolStripMenuItem1,
            this.buscarEquipoToolStripMenuItem,
            this.verListadoToolStripMenuItem1});
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // agregarEquipoToolStripMenuItem
            // 
            this.agregarEquipoToolStripMenuItem.Name = "agregarEquipoToolStripMenuItem";
            this.agregarEquipoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.agregarEquipoToolStripMenuItem.Text = "Agregar Equipo";
            this.agregarEquipoToolStripMenuItem.Click += new System.EventHandler(this.agregarEquipoToolStripMenuItem_Click);
            // 
            // modificarDatosToolStripMenuItem1
            // 
            this.modificarDatosToolStripMenuItem1.Name = "modificarDatosToolStripMenuItem1";
            this.modificarDatosToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.modificarDatosToolStripMenuItem1.Text = "Modificar Datos";
            this.modificarDatosToolStripMenuItem1.Click += new System.EventHandler(this.modificarDatosToolStripMenuItem1_Click);
            // 
            // buscarEquipoToolStripMenuItem
            // 
            this.buscarEquipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porIDToolStripMenuItem,
            this.porNDeSerieToolStripMenuItem});
            this.buscarEquipoToolStripMenuItem.Name = "buscarEquipoToolStripMenuItem";
            this.buscarEquipoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.buscarEquipoToolStripMenuItem.Text = "Buscar Equipo/s";
            // 
            // porIDToolStripMenuItem
            // 
            this.porIDToolStripMenuItem.Name = "porIDToolStripMenuItem";
            this.porIDToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.porIDToolStripMenuItem.Text = "Por N° De Equipo";
            this.porIDToolStripMenuItem.Click += new System.EventHandler(this.porIDToolStripMenuItem_Click);
            // 
            // porNDeSerieToolStripMenuItem
            // 
            this.porNDeSerieToolStripMenuItem.Name = "porNDeSerieToolStripMenuItem";
            this.porNDeSerieToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.porNDeSerieToolStripMenuItem.Text = "Por N° De Serie";
            this.porNDeSerieToolStripMenuItem.Click += new System.EventHandler(this.porNDeSerieToolStripMenuItem_Click);
            // 
            // verListadoToolStripMenuItem1
            // 
            this.verListadoToolStripMenuItem1.Name = "verListadoToolStripMenuItem1";
            this.verListadoToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.verListadoToolStripMenuItem1.Text = "Ver Listado";
            this.verListadoToolStripMenuItem1.Click += new System.EventHandler(this.verListadoToolStripMenuItem1_Click);
            // 
            // repuestosToolStripMenuItem
            // 
            this.repuestosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarRepuestoToolStripMenuItem,
            this.buscarRepuestoToolStripMenuItem,
            this.verListadoToolStripMenuItem2});
            this.repuestosToolStripMenuItem.Name = "repuestosToolStripMenuItem";
            this.repuestosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.repuestosToolStripMenuItem.Text = "Repuestos";
            // 
            // agregarRepuestoToolStripMenuItem
            // 
            this.agregarRepuestoToolStripMenuItem.Name = "agregarRepuestoToolStripMenuItem";
            this.agregarRepuestoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.agregarRepuestoToolStripMenuItem.Text = "Agregar Repuesto";
            // 
            // buscarRepuestoToolStripMenuItem
            // 
            this.buscarRepuestoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porIDToolStripMenuItem1,
            this.porNombreToolStripMenuItem1});
            this.buscarRepuestoToolStripMenuItem.Name = "buscarRepuestoToolStripMenuItem";
            this.buscarRepuestoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.buscarRepuestoToolStripMenuItem.Text = "Buscar Repuesto/s";
            // 
            // porIDToolStripMenuItem1
            // 
            this.porIDToolStripMenuItem1.Name = "porIDToolStripMenuItem1";
            this.porIDToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.porIDToolStripMenuItem1.Text = "Por Codigo";
            // 
            // porNombreToolStripMenuItem1
            // 
            this.porNombreToolStripMenuItem1.Name = "porNombreToolStripMenuItem1";
            this.porNombreToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.porNombreToolStripMenuItem1.Text = "Por Descripcion";
            // 
            // verListadoToolStripMenuItem2
            // 
            this.verListadoToolStripMenuItem2.Name = "verListadoToolStripMenuItem2";
            this.verListadoToolStripMenuItem2.Size = new System.Drawing.Size(171, 22);
            this.verListadoToolStripMenuItem2.Text = "Ver Listado";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarServiceToolStripMenuItem,
            this.buscarServiceToolStripMenuItem,
            this.verListadoToolStripMenuItem3});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // ingresarServiceToolStripMenuItem
            // 
            this.ingresarServiceToolStripMenuItem.Name = "ingresarServiceToolStripMenuItem";
            this.ingresarServiceToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ingresarServiceToolStripMenuItem.Text = "Ingresar Service";
            // 
            // buscarServiceToolStripMenuItem
            // 
            this.buscarServiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNDeServiceToolStripMenuItem,
            this.porClienteToolStripMenuItem,
            this.porFechaToolStripMenuItem});
            this.buscarServiceToolStripMenuItem.Name = "buscarServiceToolStripMenuItem";
            this.buscarServiceToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.buscarServiceToolStripMenuItem.Text = "Buscar Service";
            // 
            // porNDeServiceToolStripMenuItem
            // 
            this.porNDeServiceToolStripMenuItem.Name = "porNDeServiceToolStripMenuItem";
            this.porNDeServiceToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.porNDeServiceToolStripMenuItem.Text = "Por N° De Service";
            // 
            // porClienteToolStripMenuItem
            // 
            this.porClienteToolStripMenuItem.Name = "porClienteToolStripMenuItem";
            this.porClienteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.porClienteToolStripMenuItem.Text = "Por Cliente";
            // 
            // porFechaToolStripMenuItem
            // 
            this.porFechaToolStripMenuItem.Name = "porFechaToolStripMenuItem";
            this.porFechaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.porFechaToolStripMenuItem.Text = "Por Fecha";
            // 
            // verListadoToolStripMenuItem3
            // 
            this.verListadoToolStripMenuItem3.Name = "verListadoToolStripMenuItem3";
            this.verListadoToolStripMenuItem3.Size = new System.Drawing.Size(156, 22);
            this.verListadoToolStripMenuItem3.Text = "Ver Listado";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.administrarUsuariosToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            this.administrarUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.verListadoToolStripMenuItem4});
            this.administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            this.administrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.administrarUsuariosToolStripMenuItem.Text = "Administrar Usuarios";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            // 
            // verListadoToolStripMenuItem4
            // 
            this.verListadoToolStripMenuItem4.Name = "verListadoToolStripMenuItem4";
            this.verListadoToolStripMenuItem4.Size = new System.Drawing.Size(159, 22);
            this.verListadoToolStripMenuItem4.Text = "Ver Listado";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.manualDeUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca De....";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual De Usuario";
            // 
            // menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnstp_principal);
            this.MainMenuStrip = this.mnstp_principal;
            this.Name = "menu_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Core Solutions Service";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_principal_Load);
            this.mnstp_principal.ResumeLayout(false);
            this.mnstp_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.MenuStrip mnstp_principal;
  private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem modificarDatosToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem porNDeDNIToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem repuestosToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem verListadoToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem agregarEquipoToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem modificarDatosToolStripMenuItem1;
  private System.Windows.Forms.ToolStripMenuItem buscarEquipoToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem porIDToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem porNDeSerieToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem verListadoToolStripMenuItem1;
  private System.Windows.Forms.ToolStripMenuItem agregarRepuestoToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem buscarRepuestoToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem porIDToolStripMenuItem1;
  private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem1;
  private System.Windows.Forms.ToolStripMenuItem verListadoToolStripMenuItem2;
  private System.Windows.Forms.ToolStripMenuItem ingresarServiceToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem buscarServiceToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem porNDeServiceToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem porClienteToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem porFechaToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem verListadoToolStripMenuItem3;
  private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem administrarUsuariosToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem verListadoToolStripMenuItem4;
 }
}

