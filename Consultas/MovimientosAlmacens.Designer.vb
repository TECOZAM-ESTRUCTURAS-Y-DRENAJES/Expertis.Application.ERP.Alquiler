﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovimientosAlmacens
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
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovimientosAlmacens))
        Me.Grid1 = New Solmicro.Expertis.Engine.UI.Grid
        Me.Grid2 = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAlmacenSalida = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAlmacenEntrada = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSubFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaMayor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaMenor = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvAlmacenSalida = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvAlmacenEntrada = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvSubFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.CalendarBox1 = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.CalendarBox2 = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FilterPanel.Location = New System.Drawing.Point(0, 255)
        Me.FilterPanel.Size = New System.Drawing.Size(691, 112)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Grid2)
        Me.CIMntoGridPanel.Controls.Add(Me.Grid1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(691, 255)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid2, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Size = New System.Drawing.Size(691, 255)
        Me.Grid.ViewName = "vTraspasosAlmacen"
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
        Me.MainPanel.Size = New System.Drawing.Size(691, 367)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(691, 367)
        '
        'Grid1
        '
        Me.Grid1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid1.EntityName = Nothing
        Me.Grid1.Location = New System.Drawing.Point(4, 4)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.PrimaryDataFields = Nothing
        Me.Grid1.SecondaryDataFields = Nothing
        Me.Grid1.Size = New System.Drawing.Size(679, 245)
        Me.Grid1.TabIndex = 1
        Me.Grid1.ViewName = Nothing
        '
        'Grid2
        '
        Me.Grid2.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid2.EntityName = Nothing
        Me.Grid2.Location = New System.Drawing.Point(417, 136)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.PrimaryDataFields = Nothing
        Me.Grid2.SecondaryDataFields = Nothing
        Me.Grid2.Size = New System.Drawing.Size(400, 376)
        Me.Grid2.TabIndex = 2
        Me.Grid2.ViewName = Nothing
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(22, 29)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 0
        Me.lblArticulo.Text = "Articulo"
        '
        'lblAlmacenSalida
        '
        Me.lblAlmacenSalida.Location = New System.Drawing.Point(22, 57)
        Me.lblAlmacenSalida.Name = "lblAlmacenSalida"
        Me.lblAlmacenSalida.Size = New System.Drawing.Size(95, 13)
        Me.lblAlmacenSalida.TabIndex = 1
        Me.lblAlmacenSalida.Text = "Almacen Salida"
        '
        'lblAlmacenEntrada
        '
        Me.lblAlmacenEntrada.Location = New System.Drawing.Point(22, 82)
        Me.lblAlmacenEntrada.Name = "lblAlmacenEntrada"
        Me.lblAlmacenEntrada.Size = New System.Drawing.Size(104, 13)
        Me.lblAlmacenEntrada.TabIndex = 2
        Me.lblAlmacenEntrada.Text = "Almacen Entrada"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(264, 29)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 3
        Me.lblTipo.Text = "Tipo"
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(264, 57)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblFamilia.TabIndex = 4
        Me.lblFamilia.Text = "Familia"
        '
        'lblSubFamilia
        '
        Me.lblSubFamilia.Location = New System.Drawing.Point(264, 82)
        Me.lblSubFamilia.Name = "lblSubFamilia"
        Me.lblSubFamilia.Size = New System.Drawing.Size(68, 13)
        Me.lblSubFamilia.TabIndex = 5
        Me.lblSubFamilia.Text = "SubFamilia"
        '
        'lblFechaMayor
        '
        Me.lblFechaMayor.Location = New System.Drawing.Point(445, 29)
        Me.lblFechaMayor.Name = "lblFechaMayor"
        Me.lblFechaMayor.Size = New System.Drawing.Size(131, 13)
        Me.lblFechaMayor.TabIndex = 6
        Me.lblFechaMayor.Text = "Fecha Documento >="
        '
        'lblFechaMenor
        '
        Me.lblFechaMenor.Location = New System.Drawing.Point(445, 57)
        Me.lblFechaMenor.Name = "lblFechaMenor"
        Me.lblFechaMenor.Size = New System.Drawing.Size(131, 13)
        Me.lblFechaMenor.TabIndex = 7
        Me.lblFechaMenor.Text = "Fecha Documento <="
        '
        'AdvArticulo
        '
        Me.AdvArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvArticulo.EntityName = "Articulo"
        Me.AdvArticulo.Location = New System.Drawing.Point(141, 24)
        Me.AdvArticulo.Name = "AdvArticulo"
        Me.AdvArticulo.PrimaryDataFields = "IDArticulo"
        Me.AdvArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvArticulo.Size = New System.Drawing.Size(100, 23)
        Me.AdvArticulo.TabIndex = 8
        Me.AdvArticulo.ViewName = "tbMaestroArticulo"
        '
        'AdvAlmacenSalida
        '
        Me.AdvAlmacenSalida.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmacenSalida.EntityName = "Almacen"
        Me.AdvAlmacenSalida.Location = New System.Drawing.Point(141, 49)
        Me.AdvAlmacenSalida.Name = "AdvAlmacenSalida"
        Me.AdvAlmacenSalida.PrimaryDataFields = "AlmacenSalida"
        Me.AdvAlmacenSalida.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmacenSalida.Size = New System.Drawing.Size(100, 23)
        Me.AdvAlmacenSalida.TabIndex = 9
        Me.AdvAlmacenSalida.ViewName = "tbMaestroAlmacen"
        '
        'AdvAlmacenEntrada
        '
        Me.AdvAlmacenEntrada.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmacenEntrada.EntityName = "Almacen"
        Me.AdvAlmacenEntrada.Location = New System.Drawing.Point(141, 74)
        Me.AdvAlmacenEntrada.Name = "AdvAlmacenEntrada"
        Me.AdvAlmacenEntrada.PrimaryDataFields = "AlmacenEntrada"
        Me.AdvAlmacenEntrada.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmacenEntrada.Size = New System.Drawing.Size(100, 23)
        Me.AdvAlmacenEntrada.TabIndex = 10
        Me.AdvAlmacenEntrada.ViewName = "tbMaestroAlmacen"
        '
        'AdvTipo
        '
        Me.AdvTipo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipo.EntityName = "TipoArticulo"
        Me.AdvTipo.Location = New System.Drawing.Point(339, 24)
        Me.AdvTipo.Name = "AdvTipo"
        Me.AdvTipo.PrimaryDataFields = "IDTipo"
        Me.AdvTipo.SecondaryDataFields = "IDTipo"
        Me.AdvTipo.Size = New System.Drawing.Size(100, 23)
        Me.AdvTipo.TabIndex = 11
        Me.AdvTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'AdvFamilia
        '
        Me.AdvFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamilia.EntityName = "Familia"
        Me.AdvFamilia.Location = New System.Drawing.Point(339, 49)
        Me.AdvFamilia.Name = "AdvFamilia"
        Me.AdvFamilia.PrimaryDataFields = "IDFamilia"
        Me.AdvFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvFamilia.Size = New System.Drawing.Size(100, 23)
        Me.AdvFamilia.TabIndex = 12
        Me.AdvFamilia.ViewName = "tbMaestroFamilia"
        '
        'AdvSubFamilia
        '
        Me.AdvSubFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubFamilia.EntityName = "Subfamilia"
        Me.AdvSubFamilia.Location = New System.Drawing.Point(339, 74)
        Me.AdvSubFamilia.Name = "AdvSubFamilia"
        Me.AdvSubFamilia.PrimaryDataFields = "IDSubfamilia"
        Me.AdvSubFamilia.SecondaryDataFields = "IDSubfamilia"
        Me.AdvSubFamilia.Size = New System.Drawing.Size(100, 23)
        Me.AdvSubFamilia.TabIndex = 13
        Me.AdvSubFamilia.ViewName = "tbMaestroSubfamilia"
        '
        'CalendarBox1
        '
        Me.CalendarBox1.DisabledBackColor = System.Drawing.Color.White
        Me.CalendarBox1.Location = New System.Drawing.Point(583, 29)
        Me.CalendarBox1.Name = "CalendarBox1"
        Me.CalendarBox1.Size = New System.Drawing.Size(100, 21)
        Me.CalendarBox1.TabIndex = 14
        '
        'CalendarBox2
        '
        Me.CalendarBox2.DisabledBackColor = System.Drawing.Color.White
        Me.CalendarBox2.Location = New System.Drawing.Point(583, 57)
        Me.CalendarBox2.Name = "CalendarBox2"
        Me.CalendarBox2.Size = New System.Drawing.Size(100, 21)
        Me.CalendarBox2.TabIndex = 15
        '
        'MovimientosAlmacens
        '
        Me.ClientSize = New System.Drawing.Size(699, 455)
        Me.Name = "MovimientosAlmacens"
        Me.ViewName = "vTraspasosAlmacen"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid1 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Grid2 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblFechaMenor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaMayor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblSubFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlmacenEntrada As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlmacenSalida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CalendarBox2 As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents CalendarBox1 As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents AdvSubFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvAlmacenEntrada As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvAlmacenSalida As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvArticulo As Solmicro.Expertis.Engine.UI.AdvSearch

End Class
