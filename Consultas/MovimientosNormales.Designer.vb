<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovimientosNormales
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovimientosNormales))
        Me.CalendarBox2 = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.CalendarBox1 = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.AdvSubFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvAlmacenEntrada = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvAlmacenSalida = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFechaMenor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaMayor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSubFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAlmacenEntrada = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAlmacenSalida = New Solmicro.Expertis.Engine.UI.Label
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.CalendarBox2)
        Me.FilterPanel.Controls.Add(Me.CalendarBox1)
        Me.FilterPanel.Controls.Add(Me.AdvSubFamilia)
        Me.FilterPanel.Controls.Add(Me.AdvFamilia)
        Me.FilterPanel.Controls.Add(Me.AdvTipo)
        Me.FilterPanel.Controls.Add(Me.AdvAlmacenEntrada)
        Me.FilterPanel.Controls.Add(Me.AdvAlmacenSalida)
        Me.FilterPanel.Controls.Add(Me.AdvArticulo)
        Me.FilterPanel.Controls.Add(Me.lblFechaMenor)
        Me.FilterPanel.Controls.Add(Me.lblFechaMayor)
        Me.FilterPanel.Controls.Add(Me.lblSubFamilia)
        Me.FilterPanel.Controls.Add(Me.lblFamilia)
        Me.FilterPanel.Controls.Add(Me.lblTipo)
        Me.FilterPanel.Controls.Add(Me.lblAlmacenEntrada)
        Me.FilterPanel.Controls.Add(Me.lblAlmacenSalida)
        Me.FilterPanel.Controls.Add(Me.lblArticulo)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 243)
        Me.FilterPanel.Size = New System.Drawing.Size(884, 119)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(884, 243)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Size = New System.Drawing.Size(884, 243)
        Me.Grid.ViewName = "vTraspasosAlmacen2"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(884, 362)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(884, 362)
        '
        'CalendarBox2
        '
        Me.CalendarBox2.DisabledBackColor = System.Drawing.Color.White
        Me.CalendarBox2.Location = New System.Drawing.Point(737, 57)
        Me.CalendarBox2.Name = "CalendarBox2"
        Me.CalendarBox2.Size = New System.Drawing.Size(100, 21)
        Me.CalendarBox2.TabIndex = 31
        '
        'CalendarBox1
        '
        Me.CalendarBox1.DisabledBackColor = System.Drawing.Color.White
        Me.CalendarBox1.Location = New System.Drawing.Point(737, 29)
        Me.CalendarBox1.Name = "CalendarBox1"
        Me.CalendarBox1.Size = New System.Drawing.Size(100, 21)
        Me.CalendarBox1.TabIndex = 30
        '
        'AdvSubFamilia
        '
        Me.AdvSubFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubFamilia.EntityName = "Subfamilia"
        Me.AdvSubFamilia.Location = New System.Drawing.Point(425, 79)
        Me.AdvSubFamilia.Name = "AdvSubFamilia"
        Me.AdvSubFamilia.PrimaryDataFields = "IDSubfamilia"
        Me.AdvSubFamilia.SecondaryDataFields = "IDSubfamilia"
        Me.AdvSubFamilia.Size = New System.Drawing.Size(100, 23)
        Me.AdvSubFamilia.TabIndex = 29
        Me.AdvSubFamilia.ViewName = "tbMaestroSubfamilia"
        '
        'AdvFamilia
        '
        Me.AdvFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamilia.EntityName = "Familia"
        Me.AdvFamilia.Location = New System.Drawing.Point(425, 54)
        Me.AdvFamilia.Name = "AdvFamilia"
        Me.AdvFamilia.PrimaryDataFields = "IDFamilia"
        Me.AdvFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvFamilia.Size = New System.Drawing.Size(100, 23)
        Me.AdvFamilia.TabIndex = 28
        Me.AdvFamilia.ViewName = "tbMaestroFamilia"
        '
        'AdvTipo
        '
        Me.AdvTipo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipo.EntityName = "TipoArticulo"
        Me.AdvTipo.Location = New System.Drawing.Point(425, 29)
        Me.AdvTipo.Name = "AdvTipo"
        Me.AdvTipo.PrimaryDataFields = "IDTipo"
        Me.AdvTipo.SecondaryDataFields = "IDTipo"
        Me.AdvTipo.Size = New System.Drawing.Size(100, 23)
        Me.AdvTipo.TabIndex = 27
        Me.AdvTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'AdvAlmacenEntrada
        '
        Me.AdvAlmacenEntrada.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmacenEntrada.EntityName = "Almacen"
        Me.AdvAlmacenEntrada.Location = New System.Drawing.Point(159, 79)
        Me.AdvAlmacenEntrada.Name = "AdvAlmacenEntrada"
        Me.AdvAlmacenEntrada.PrimaryDataFields = "AlmacenEntrada"
        Me.AdvAlmacenEntrada.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmacenEntrada.Size = New System.Drawing.Size(100, 23)
        Me.AdvAlmacenEntrada.TabIndex = 26
        Me.AdvAlmacenEntrada.ViewName = "tbMaestroAlmacen"
        '
        'AdvAlmacenSalida
        '
        Me.AdvAlmacenSalida.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmacenSalida.EntityName = "Almacen"
        Me.AdvAlmacenSalida.Location = New System.Drawing.Point(159, 54)
        Me.AdvAlmacenSalida.Name = "AdvAlmacenSalida"
        Me.AdvAlmacenSalida.PrimaryDataFields = "AlmacenSalida"
        Me.AdvAlmacenSalida.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmacenSalida.Size = New System.Drawing.Size(100, 23)
        Me.AdvAlmacenSalida.TabIndex = 25
        Me.AdvAlmacenSalida.ViewName = "tbMaestroAlmacen"
        '
        'AdvArticulo
        '
        Me.AdvArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvArticulo.EntityName = "Articulo"
        Me.AdvArticulo.Location = New System.Drawing.Point(159, 29)
        Me.AdvArticulo.Name = "AdvArticulo"
        Me.AdvArticulo.PrimaryDataFields = "IDArticulo"
        Me.AdvArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvArticulo.Size = New System.Drawing.Size(100, 23)
        Me.AdvArticulo.TabIndex = 24
        Me.AdvArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblFechaMenor
        '
        Me.lblFechaMenor.Location = New System.Drawing.Point(599, 57)
        Me.lblFechaMenor.Name = "lblFechaMenor"
        Me.lblFechaMenor.Size = New System.Drawing.Size(131, 13)
        Me.lblFechaMenor.TabIndex = 23
        Me.lblFechaMenor.Text = "Fecha Documento <="
        '
        'lblFechaMayor
        '
        Me.lblFechaMayor.Location = New System.Drawing.Point(599, 29)
        Me.lblFechaMayor.Name = "lblFechaMayor"
        Me.lblFechaMayor.Size = New System.Drawing.Size(131, 13)
        Me.lblFechaMayor.TabIndex = 22
        Me.lblFechaMayor.Text = "Fecha Documento >="
        '
        'lblSubFamilia
        '
        Me.lblSubFamilia.Location = New System.Drawing.Point(350, 87)
        Me.lblSubFamilia.Name = "lblSubFamilia"
        Me.lblSubFamilia.Size = New System.Drawing.Size(68, 13)
        Me.lblSubFamilia.TabIndex = 21
        Me.lblSubFamilia.Text = "SubFamilia"
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(350, 62)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblFamilia.TabIndex = 20
        Me.lblFamilia.Text = "Familia"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(350, 34)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 19
        Me.lblTipo.Text = "Tipo"
        '
        'lblAlmacenEntrada
        '
        Me.lblAlmacenEntrada.Location = New System.Drawing.Point(40, 87)
        Me.lblAlmacenEntrada.Name = "lblAlmacenEntrada"
        Me.lblAlmacenEntrada.Size = New System.Drawing.Size(104, 13)
        Me.lblAlmacenEntrada.TabIndex = 18
        Me.lblAlmacenEntrada.Text = "Almacen Entrada"
        '
        'lblAlmacenSalida
        '
        Me.lblAlmacenSalida.Location = New System.Drawing.Point(40, 62)
        Me.lblAlmacenSalida.Name = "lblAlmacenSalida"
        Me.lblAlmacenSalida.Size = New System.Drawing.Size(95, 13)
        Me.lblAlmacenSalida.TabIndex = 17
        Me.lblAlmacenSalida.Text = "Almacen Salida"
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(40, 34)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 16
        Me.lblArticulo.Text = "Articulo"
        '
        'MovimientosNormales
        '
        Me.ClientSize = New System.Drawing.Size(892, 450)
        Me.Name = "MovimientosNormales"
        Me.ViewName = "vTraspasosAlmacen2"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CalendarBox2 As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents CalendarBox1 As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents AdvSubFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvAlmacenEntrada As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvAlmacenSalida As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFechaMenor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaMayor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblSubFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlmacenEntrada As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlmacenSalida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label

End Class
