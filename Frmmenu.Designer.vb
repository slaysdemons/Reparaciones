<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmmenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RespaldarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepararToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MóduloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaDelDiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaDeLaSemanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosEstrellaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Stsestado = New System.Windows.Forms.StatusStrip()
        Me.Tslusuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tslhora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tsleestado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.Stsestado.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.MóduloToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RespaldarToolStripMenuItem, Me.RepararToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'RespaldarToolStripMenuItem
        '
        Me.RespaldarToolStripMenuItem.Name = "RespaldarToolStripMenuItem"
        Me.RespaldarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RespaldarToolStripMenuItem.Text = "Respaldar"
        '
        'RepararToolStripMenuItem
        '
        Me.RepararToolStripMenuItem.Image = Global.Reparaciones.My.Resources.Resources._1489186740_constructgearoptimizerepairsetting_81823
        Me.RepararToolStripMenuItem.Name = "RepararToolStripMenuItem"
        Me.RepararToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RepararToolStripMenuItem.Text = "Reparar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.Reparaciones.My.Resources.Resources.salir
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MóduloToolStripMenuItem
        '
        Me.MóduloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.InventarioToolStripMenuItem})
        Me.MóduloToolStripMenuItem.Name = "MóduloToolStripMenuItem"
        Me.MóduloToolStripMenuItem.Size = New System.Drawing.Size(71, 22)
        Me.MóduloToolStripMenuItem.Text = "Módulo"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = Global.Reparaciones.My.Resources.Resources.clientes
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedorToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Image = Global.Reparaciones.My.Resources.Resources.compra
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Image = Global.Reparaciones.My.Resources.Resources.proveedor
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Image = Global.Reparaciones.My.Resources.Resources.dinero
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Image = Global.Reparaciones.My.Resources.Resources.proveedor
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Image = Global.Reparaciones.My.Resources.Resources.proveedor1
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Image = Global.Reparaciones.My.Resources.Resources.inventario
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaDelDiaToolStripMenuItem, Me.VentaDeLaSemanaToolStripMenuItem, Me.ProductosEstrellaToolStripMenuItem, Me.DevolucioToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(84, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'VentaDelDiaToolStripMenuItem
        '
        Me.VentaDelDiaToolStripMenuItem.Image = Global.Reparaciones.My.Resources.Resources.ventas_del_dia
        Me.VentaDelDiaToolStripMenuItem.Name = "VentaDelDiaToolStripMenuItem"
        Me.VentaDelDiaToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.VentaDelDiaToolStripMenuItem.Text = "ventas del día"
        '
        'VentaDeLaSemanaToolStripMenuItem
        '
        Me.VentaDeLaSemanaToolStripMenuItem.Image = Global.Reparaciones.My.Resources.Resources.ventas_del_dia
        Me.VentaDeLaSemanaToolStripMenuItem.Name = "VentaDeLaSemanaToolStripMenuItem"
        Me.VentaDeLaSemanaToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.VentaDeLaSemanaToolStripMenuItem.Text = "Venta de la semana"
        '
        'ProductosEstrellaToolStripMenuItem
        '
        Me.ProductosEstrellaToolStripMenuItem.Name = "ProductosEstrellaToolStripMenuItem"
        Me.ProductosEstrellaToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ProductosEstrellaToolStripMenuItem.Text = "Productos estrella"
        '
        'DevolucioToolStripMenuItem
        '
        Me.DevolucioToolStripMenuItem.Image = Global.Reparaciones.My.Resources.Resources.devolucion
        Me.DevolucioToolStripMenuItem.Name = "DevolucioToolStripMenuItem"
        Me.DevolucioToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.DevolucioToolStripMenuItem.Text = "Devolución de ventas"
        '
        'Stsestado
        '
        Me.Stsestado.BackColor = System.Drawing.Color.DodgerBlue
        Me.Stsestado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stsestado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tslusuario, Me.Tslhora, Me.Tsleestado})
        Me.Stsestado.Location = New System.Drawing.Point(0, 427)
        Me.Stsestado.Name = "Stsestado"
        Me.Stsestado.Size = New System.Drawing.Size(800, 23)
        Me.Stsestado.TabIndex = 1
        Me.Stsestado.Text = "StatusStrip1"
        '
        'Tslusuario
        '
        Me.Tslusuario.Name = "Tslusuario"
        Me.Tslusuario.Size = New System.Drawing.Size(106, 18)
        Me.Tslusuario.Text = "Administrador"
        '
        'Tslhora
        '
        Me.Tslhora.Name = "Tslhora"
        Me.Tslhora.Size = New System.Drawing.Size(90, 18)
        Me.Tslhora.Text = "Hora: 00:00"
        '
        'Tsleestado
        '
        Me.Tsleestado.Name = "Tsleestado"
        Me.Tsleestado.Size = New System.Drawing.Size(106, 18)
        Me.Tsleestado.Text = "Estado Online"
        '
        'Frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Reparaciones.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Stsestado)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frmmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Stsestado.ResumeLayout(False)
        Me.Stsestado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MóduloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaDelDiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaDeLaSemanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosEstrellaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevolucioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Stsestado As StatusStrip
    Friend WithEvents Tslusuario As ToolStripStatusLabel
    Friend WithEvents Tslhora As ToolStripStatusLabel
    Friend WithEvents Tsleestado As ToolStripStatusLabel
    Friend WithEvents RespaldarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RepararToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
