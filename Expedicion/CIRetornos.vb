Public Class CIRetornos
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtPendiente.Value = System.DBNull.Value
    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents PicTotales As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblHora As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvAlmacenDeposito As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblAlmacenDeposito As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblCGestion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxCGestion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblNAlbaranRecogida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblConAvisoRetorno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaAvisoDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaAvisoHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaPrevistaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaPrevistaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblLote As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblOServicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCLiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblQPendiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlbaranDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlbaranHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxConAvisoRetorno As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtPendiente As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtNAlbaranRecogida As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cbxFechaAvisoDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaAvisoHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaPrevistaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaPrevistaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents AdvLote As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents AdvAlbaranDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvAlbaranHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvOServicio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxHora As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvSubfamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents AdvContador As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxConAvisoRetorno_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxCGestion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIRetornos))
        Me.txtNAlbaranRecogida = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNAlbaranRecogida = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxConAvisoRetorno = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblConAvisoRetorno = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaAvisoDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaAvisoDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaAvisoHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaAvisoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaPrevistaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaPrevistaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaPrevistaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaPrevistaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvLote = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblLote = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvOServicio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblOServicio = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCLiente = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvAlmacenDeposito = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlmacenDeposito = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQPendiente = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvAlbaranDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlbaranDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvAlbaranHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlbaranHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.PicTotales = New Solmicro.Expertis.Engine.UI.Panel
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxHora = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblHora = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtPendiente = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.cbxCGestion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvSubfamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxConAvisoRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        CType(Me.cbxCGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.AdvSubfamilia)
        Me.FilterPanel.Controls.Add(Me.AdvFamilia)
        Me.FilterPanel.Controls.Add(Me.AdvTipo)
        Me.FilterPanel.Controls.Add(Me.Label3)
        Me.FilterPanel.Controls.Add(Me.Label2)
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.cbxCGestion)
        Me.FilterPanel.Controls.Add(Me.txtPendiente)
        Me.FilterPanel.Controls.Add(Me.lblNAlbaranRecogida)
        Me.FilterPanel.Controls.Add(Me.lblConAvisoRetorno)
        Me.FilterPanel.Controls.Add(Me.lblFechaAvisoDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaAvisoHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaPrevistaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaPrevistaHasta)
        Me.FilterPanel.Controls.Add(Me.lblLote)
        Me.FilterPanel.Controls.Add(Me.lblCGestion)
        Me.FilterPanel.Controls.Add(Me.lblOServicio)
        Me.FilterPanel.Controls.Add(Me.lblCLiente)
        Me.FilterPanel.Controls.Add(Me.lblQPendiente)
        Me.FilterPanel.Controls.Add(Me.lblArticulo)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.txtNAlbaranRecogida)
        Me.FilterPanel.Controls.Add(Me.cbxConAvisoRetorno)
        Me.FilterPanel.Controls.Add(Me.cbxFechaAvisoDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaAvisoHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaPrevistaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaPrevistaHasta)
        Me.FilterPanel.Controls.Add(Me.AdvLote)
        Me.FilterPanel.Controls.Add(Me.AdvOServicio)
        Me.FilterPanel.Controls.Add(Me.AdvCliente)
        Me.FilterPanel.Controls.Add(Me.AdvAlmacenDeposito)
        Me.FilterPanel.Controls.Add(Me.AdvArticulo)
        Me.FilterPanel.Controls.Add(Me.AdvObraDesde)
        Me.FilterPanel.Controls.Add(Me.AdvObraHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.AdvAlbaranDesde)
        Me.FilterPanel.Controls.Add(Me.AdvAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.PicTotales)
        Me.FilterPanel.Controls.Add(Me.lblAlmacenDeposito)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblAlbaranDesde)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 216)
        Me.FilterPanel.Size = New System.Drawing.Size(781, 161)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Panel1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(781, 216)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Me.Grid.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "C. Devolución", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "QPendiente"), New Solmicro.Expertis.Engine.UI.CheckField("FechaAlquiler", "Fecha Fin Alquiler", Solmicro.Expertis.Engine.UI.CheckFieldType.DateTime, ""), New Solmicro.Expertis.Engine.UI.CheckField("HoraAlquiler", "Hora Fin Alquiler", Solmicro.Expertis.Engine.UI.CheckFieldType.Char, ""), New Solmicro.Expertis.Engine.UI.CheckField("FechaDevolucion", "Fecha Devolución", Solmicro.Expertis.Engine.UI.CheckFieldType.DateTime, "")})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "AlbaranVentaLinea"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDLineaAlbaran"
        Me.Grid.Location = New System.Drawing.Point(0, 32)
        Me.Grid.Size = New System.Drawing.Size(781, 184)
        Me.Grid.TabIndex = 22
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vAlquilerCIRetornos"
        '
        'CheckAll
        '
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(320, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(781, 377)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(781, 377)
        '
        'txtNAlbaranRecogida
        '
        Me.txtNAlbaranRecogida.DisabledBackColor = System.Drawing.Color.White
        Me.txtNAlbaranRecogida.Location = New System.Drawing.Point(696, 103)
        Me.txtNAlbaranRecogida.Name = "txtNAlbaranRecogida"
        Me.txtNAlbaranRecogida.Size = New System.Drawing.Size(76, 21)
        Me.txtNAlbaranRecogida.TabIndex = 18
        '
        'lblNAlbaranRecogida
        '
        Me.lblNAlbaranRecogida.Location = New System.Drawing.Point(577, 107)
        Me.lblNAlbaranRecogida.Name = "lblNAlbaranRecogida"
        Me.lblNAlbaranRecogida.Size = New System.Drawing.Size(107, 13)
        Me.lblNAlbaranRecogida.TabIndex = 0
        Me.lblNAlbaranRecogida.Text = "Albarán Recogida"
        '
        'cbxConAvisoRetorno
        '
        cbxConAvisoRetorno_DesignTimeLayout.LayoutString = resources.GetString("cbxConAvisoRetorno_DesignTimeLayout.LayoutString")
        Me.cbxConAvisoRetorno.DesignTimeLayout = cbxConAvisoRetorno_DesignTimeLayout
        Me.cbxConAvisoRetorno.DisabledBackColor = System.Drawing.Color.White
        Me.cbxConAvisoRetorno.Location = New System.Drawing.Point(696, 77)
        Me.cbxConAvisoRetorno.Name = "cbxConAvisoRetorno"
        Me.cbxConAvisoRetorno.SelectedIndex = -1
        Me.cbxConAvisoRetorno.SelectedItem = Nothing
        Me.cbxConAvisoRetorno.Size = New System.Drawing.Size(76, 21)
        Me.cbxConAvisoRetorno.TabIndex = 17
        '
        'lblConAvisoRetorno
        '
        Me.lblConAvisoRetorno.Location = New System.Drawing.Point(577, 81)
        Me.lblConAvisoRetorno.Name = "lblConAvisoRetorno"
        Me.lblConAvisoRetorno.Size = New System.Drawing.Size(114, 13)
        Me.lblConAvisoRetorno.TabIndex = 25
        Me.lblConAvisoRetorno.Text = "Con Aviso Retorno"
        '
        'cbxFechaAvisoDesde
        '
        Me.cbxFechaAvisoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaAvisoDesde.Location = New System.Drawing.Point(500, 0)
        Me.cbxFechaAvisoDesde.Name = "cbxFechaAvisoDesde"
        Me.cbxFechaAvisoDesde.Size = New System.Drawing.Size(76, 21)
        Me.cbxFechaAvisoDesde.TabIndex = 12
        Me.cbxFechaAvisoDesde.Visible = False
        '
        'lblFechaAvisoDesde
        '
        Me.lblFechaAvisoDesde.Location = New System.Drawing.Point(404, 9)
        Me.lblFechaAvisoDesde.Name = "lblFechaAvisoDesde"
        Me.lblFechaAvisoDesde.Size = New System.Drawing.Size(90, 13)
        Me.lblFechaAvisoDesde.TabIndex = 26
        Me.lblFechaAvisoDesde.Text = "F. Aviso Desde"
        Me.lblFechaAvisoDesde.Visible = False
        '
        'cbxFechaAvisoHasta
        '
        Me.cbxFechaAvisoHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaAvisoHasta.Location = New System.Drawing.Point(308, 1)
        Me.cbxFechaAvisoHasta.Name = "cbxFechaAvisoHasta"
        Me.cbxFechaAvisoHasta.Size = New System.Drawing.Size(76, 21)
        Me.cbxFechaAvisoHasta.TabIndex = 13
        Me.cbxFechaAvisoHasta.Visible = False
        '
        'lblFechaAvisoHasta
        '
        Me.lblFechaAvisoHasta.Location = New System.Drawing.Point(200, 9)
        Me.lblFechaAvisoHasta.Name = "lblFechaAvisoHasta"
        Me.lblFechaAvisoHasta.Size = New System.Drawing.Size(86, 13)
        Me.lblFechaAvisoHasta.TabIndex = 27
        Me.lblFechaAvisoHasta.Text = "F. Aviso Hasta"
        Me.lblFechaAvisoHasta.Visible = False
        '
        'cbxFechaPrevistaDesde
        '
        Me.cbxFechaPrevistaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaPrevistaDesde.Location = New System.Drawing.Point(696, 27)
        Me.cbxFechaPrevistaDesde.Name = "cbxFechaPrevistaDesde"
        Me.cbxFechaPrevistaDesde.Size = New System.Drawing.Size(76, 21)
        Me.cbxFechaPrevistaDesde.TabIndex = 15
        '
        'lblFechaPrevistaDesde
        '
        Me.lblFechaPrevistaDesde.Location = New System.Drawing.Point(577, 30)
        Me.lblFechaPrevistaDesde.Name = "lblFechaPrevistaDesde"
        Me.lblFechaPrevistaDesde.Size = New System.Drawing.Size(113, 13)
        Me.lblFechaPrevistaDesde.TabIndex = 28
        Me.lblFechaPrevistaDesde.Text = "Fecha Prev. Desde"
        '
        'cbxFechaPrevistaHasta
        '
        Me.cbxFechaPrevistaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaPrevistaHasta.Location = New System.Drawing.Point(696, 52)
        Me.cbxFechaPrevistaHasta.Name = "cbxFechaPrevistaHasta"
        Me.cbxFechaPrevistaHasta.Size = New System.Drawing.Size(76, 21)
        Me.cbxFechaPrevistaHasta.TabIndex = 16
        '
        'lblFechaPrevistaHasta
        '
        Me.lblFechaPrevistaHasta.Location = New System.Drawing.Point(577, 55)
        Me.lblFechaPrevistaHasta.Name = "lblFechaPrevistaHasta"
        Me.lblFechaPrevistaHasta.Size = New System.Drawing.Size(109, 13)
        Me.lblFechaPrevistaHasta.TabIndex = 29
        Me.lblFechaPrevistaHasta.Text = "Fecha Prev. Hasta"
        '
        'AdvLote
        '
        Me.AdvLote.DisabledBackColor = System.Drawing.Color.White
        Me.AdvLote.EntityName = "ArticuloNSerie"
        Me.AdvLote.Location = New System.Drawing.Point(92, 77)
        Me.AdvLote.Name = "AdvLote"
        Me.AdvLote.SecondaryDataFields = "NSerie"
        Me.AdvLote.Size = New System.Drawing.Size(95, 23)
        Me.AdvLote.TabIndex = 2
        '
        'lblLote
        '
        Me.lblLote.Location = New System.Drawing.Point(6, 81)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(59, 13)
        Me.lblLote.TabIndex = 30
        Me.lblLote.Text = "Nº. Serie"
        '
        'lblCGestion
        '
        Me.lblCGestion.Location = New System.Drawing.Point(577, 134)
        Me.lblCGestion.Name = "lblCGestion"
        Me.lblCGestion.Size = New System.Drawing.Size(67, 13)
        Me.lblCGestion.TabIndex = 32
        Me.lblCGestion.Text = "C. Gestión"
        '
        'AdvOServicio
        '
        Me.AdvOServicio.DisabledBackColor = System.Drawing.Color.White
        Me.AdvOServicio.DisplayField = "CodTrabajo"
        Me.AdvOServicio.EntityName = "ObraTrabajo"
        Me.AdvOServicio.Location = New System.Drawing.Point(289, 77)
        Me.AdvOServicio.Name = "AdvOServicio"
        Me.AdvOServicio.SecondaryDataFields = "IDTrabajo"
        Me.AdvOServicio.Size = New System.Drawing.Size(95, 23)
        Me.AdvOServicio.TabIndex = 7
        '
        'lblOServicio
        '
        Me.lblOServicio.Location = New System.Drawing.Point(195, 81)
        Me.lblOServicio.Name = "lblOServicio"
        Me.lblOServicio.Size = New System.Drawing.Size(70, 13)
        Me.lblOServicio.TabIndex = 33
        Me.lblOServicio.Text = "O. Servicio"
        '
        'AdvCliente
        '
        Me.AdvCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvCliente.EntityName = "Cliente"
        Me.AdvCliente.Location = New System.Drawing.Point(92, 25)
        Me.AdvCliente.Name = "AdvCliente"
        Me.AdvCliente.SecondaryDataFields = "IDCliente"
        Me.AdvCliente.Size = New System.Drawing.Size(95, 23)
        Me.AdvCliente.TabIndex = 0
        '
        'lblCLiente
        '
        Me.lblCLiente.Location = New System.Drawing.Point(6, 30)
        Me.lblCLiente.Name = "lblCLiente"
        Me.lblCLiente.Size = New System.Drawing.Size(47, 13)
        Me.lblCLiente.TabIndex = 35
        Me.lblCLiente.Text = "Cliente"
        '
        'AdvAlmacenDeposito
        '
        Me.AdvAlmacenDeposito.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmacenDeposito.EntityName = "Almacen"
        Me.AdvAlmacenDeposito.Location = New System.Drawing.Point(92, 103)
        Me.AdvAlmacenDeposito.Name = "AdvAlmacenDeposito"
        Me.AdvAlmacenDeposito.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmacenDeposito.Size = New System.Drawing.Size(95, 23)
        Me.AdvAlmacenDeposito.TabIndex = 3
        '
        'lblAlmacenDeposito
        '
        Me.lblAlmacenDeposito.Location = New System.Drawing.Point(6, 107)
        Me.lblAlmacenDeposito.Name = "lblAlmacenDeposito"
        Me.lblAlmacenDeposito.Size = New System.Drawing.Size(87, 13)
        Me.lblAlmacenDeposito.TabIndex = 37
        Me.lblAlmacenDeposito.Text = "Alm. Depósito"
        '
        'lblQPendiente
        '
        Me.lblQPendiente.Location = New System.Drawing.Point(392, 81)
        Me.lblQPendiente.Name = "lblQPendiente"
        Me.lblQPendiente.Size = New System.Drawing.Size(102, 13)
        Me.lblQPendiente.TabIndex = 39
        Me.lblQPendiente.Text = "C. Pendiente >="
        '
        'AdvArticulo
        '
        Me.AdvArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvArticulo.EntityName = "Articulo"
        Me.AdvArticulo.Location = New System.Drawing.Point(92, 51)
        Me.AdvArticulo.Name = "AdvArticulo"
        Me.AdvArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvArticulo.Size = New System.Drawing.Size(95, 23)
        Me.AdvArticulo.TabIndex = 1
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(6, 55)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 40
        Me.lblArticulo.Text = "Artículo"
        '
        'AdvObraDesde
        '
        Me.AdvObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraDesde.DisplayField = "NObra"
        Me.AdvObraDesde.EntityName = "ObraCabecera"
        Me.AdvObraDesde.Location = New System.Drawing.Point(289, 25)
        Me.AdvObraDesde.Name = "AdvObraDesde"
        Me.AdvObraDesde.SecondaryDataFields = "IDObra"
        Me.AdvObraDesde.Size = New System.Drawing.Size(95, 23)
        Me.AdvObraDesde.TabIndex = 5
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(195, 30)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(90, 13)
        Me.lblObraDesde.TabIndex = 42
        Me.lblObraDesde.Text = "Alquiler Desde"
        '
        'AdvObraHasta
        '
        Me.AdvObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraHasta.DisplayField = "NObra"
        Me.AdvObraHasta.EntityName = "ObraCabecera"
        Me.AdvObraHasta.Location = New System.Drawing.Point(289, 51)
        Me.AdvObraHasta.Name = "AdvObraHasta"
        Me.AdvObraHasta.SecondaryDataFields = "IDObra"
        Me.AdvObraHasta.Size = New System.Drawing.Size(95, 23)
        Me.AdvObraHasta.TabIndex = 6
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(195, 55)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(90, 13)
        Me.lblObraHasta.TabIndex = 44
        Me.lblObraHasta.Text = "Alquiler  Hasta"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(491, 27)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(80, 21)
        Me.cbxFechaDesde.TabIndex = 10
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(392, 30)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 46
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(491, 52)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(80, 21)
        Me.cbxFechaHasta.TabIndex = 11
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(392, 55)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 47
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'AdvAlbaranDesde
        '
        Me.AdvAlbaranDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlbaranDesde.DisplayField = "NAlbaran"
        Me.AdvAlbaranDesde.EntityName = "AlbaranVentaCabecera"
        Me.AdvAlbaranDesde.Location = New System.Drawing.Point(289, 103)
        Me.AdvAlbaranDesde.Name = "AdvAlbaranDesde"
        Me.AdvAlbaranDesde.SecondaryDataFields = "IDAlbaran"
        Me.AdvAlbaranDesde.Size = New System.Drawing.Size(95, 23)
        Me.AdvAlbaranDesde.TabIndex = 8
        '
        'lblAlbaranDesde
        '
        Me.lblAlbaranDesde.Location = New System.Drawing.Point(195, 107)
        Me.lblAlbaranDesde.Name = "lblAlbaranDesde"
        Me.lblAlbaranDesde.Size = New System.Drawing.Size(91, 13)
        Me.lblAlbaranDesde.TabIndex = 48
        Me.lblAlbaranDesde.Text = "Albarán Desde"
        '
        'AdvAlbaranHasta
        '
        Me.AdvAlbaranHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlbaranHasta.DisplayField = "NAlbaran"
        Me.AdvAlbaranHasta.EntityName = "AlbaranVentaCabecera"
        Me.AdvAlbaranHasta.Location = New System.Drawing.Point(491, 101)
        Me.AdvAlbaranHasta.Name = "AdvAlbaranHasta"
        Me.AdvAlbaranHasta.SecondaryDataFields = "IDAlbaran"
        Me.AdvAlbaranHasta.Size = New System.Drawing.Size(80, 23)
        Me.AdvAlbaranHasta.TabIndex = 9
        '
        'lblAlbaranHasta
        '
        Me.lblAlbaranHasta.Location = New System.Drawing.Point(392, 107)
        Me.lblAlbaranHasta.Name = "lblAlbaranHasta"
        Me.lblAlbaranHasta.Size = New System.Drawing.Size(87, 13)
        Me.lblAlbaranHasta.TabIndex = 50
        Me.lblAlbaranHasta.Text = "Albarán Hasta"
        '
        'PicTotales
        '
        Me.PicTotales.Location = New System.Drawing.Point(541, 348)
        Me.PicTotales.Name = "PicTotales"
        Me.PicTotales.Size = New System.Drawing.Size(164, 107)
        Me.PicTotales.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbxHora)
        Me.Panel1.Controls.Add(Me.lblHora)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.cbxFecha)
        Me.Panel1.Controls.Add(Me.lblContador)
        Me.Panel1.Controls.Add(Me.AdvContador)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 32)
        Me.Panel1.TabIndex = 0
        '
        'cbxHora
        '
        Me.cbxHora.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Time
        Me.cbxHora.DisabledBackColor = System.Drawing.Color.White
        Me.cbxHora.EditStyle = Janus.Windows.CalendarCombo.EditStyle.Masked
        Me.cbxHora.Location = New System.Drawing.Point(344, 6)
        Me.cbxHora.Name = "cbxHora"
        Me.cbxHora.ShowDropDown = False
        Me.cbxHora.Size = New System.Drawing.Size(65, 21)
        Me.cbxHora.TabIndex = 1
        '
        'lblHora
        '
        Me.lblHora.Location = New System.Drawing.Point(237, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(101, 13)
        Me.lblHora.TabIndex = 53
        Me.lblHora.Text = "Hora Fin Alquiler"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(11, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(107, 13)
        Me.lblFecha.TabIndex = 54
        Me.lblFecha.Text = "Fecha Fin Alquiler"
        '
        'cbxFecha
        '
        Me.cbxFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFecha.Location = New System.Drawing.Point(122, 6)
        Me.cbxFecha.Name = "cbxFecha"
        Me.cbxFecha.Size = New System.Drawing.Size(84, 21)
        Me.cbxFecha.TabIndex = 0
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(622, 9)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 55
        Me.lblContador.Text = "Contador"
        '
        'AdvContador
        '
        Me.AdvContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvContador.EntityName = "EntidadContador"
        Me.AdvContador.Location = New System.Drawing.Point(685, 4)
        Me.AdvContador.Name = "AdvContador"
        Me.AdvContador.PrimaryDataFields = "IDContador"
        Me.AdvContador.SecondaryDataFields = "IDContador"
        Me.AdvContador.Size = New System.Drawing.Size(89, 23)
        Me.AdvContador.TabIndex = 2
        Me.AdvContador.ViewName = "tbEntidadContador"
        '
        'txtPendiente
        '
        Me.txtPendiente.DisabledBackColor = System.Drawing.Color.White
        Me.txtPendiente.Location = New System.Drawing.Point(491, 77)
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtPendiente.Size = New System.Drawing.Size(80, 21)
        Me.txtPendiente.TabIndex = 14
        '
        'cbxCGestion
        '
        cbxCGestion_DesignTimeLayout.LayoutString = resources.GetString("cbxCGestion_DesignTimeLayout.LayoutString")
        Me.cbxCGestion.DesignTimeLayout = cbxCGestion_DesignTimeLayout
        Me.cbxCGestion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxCGestion.EntityName = "CentroGestion"
        Me.cbxCGestion.Location = New System.Drawing.Point(678, 129)
        Me.cbxCGestion.Name = "cbxCGestion"
        Me.cbxCGestion.PrimaryDataFields = "IDCentroGestion"
        Me.cbxCGestion.SecondaryDataFields = "IDCentroGestion"
        Me.cbxCGestion.SelectedIndex = -1
        Me.cbxCGestion.SelectedItem = Nothing
        Me.cbxCGestion.Size = New System.Drawing.Size(95, 21)
        Me.cbxCGestion.TabIndex = 4
        Me.cbxCGestion.ViewName = "tbMaestroCentroGestion"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(195, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Familia"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(392, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Subfamilia"
        '
        'AdvTipo
        '
        Me.AdvTipo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipo.EntityName = "Articulo"
        Me.AdvTipo.Location = New System.Drawing.Point(92, 132)
        Me.AdvTipo.Name = "AdvTipo"
        Me.AdvTipo.SecondaryDataFields = "IDTipo"
        Me.AdvTipo.Size = New System.Drawing.Size(95, 23)
        Me.AdvTipo.TabIndex = 60
        '
        'AdvFamilia
        '
        Me.AdvFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamilia.EntityName = "Articulo"
        Me.AdvFamilia.Location = New System.Drawing.Point(289, 129)
        Me.AdvFamilia.Name = "AdvFamilia"
        Me.AdvFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvFamilia.Size = New System.Drawing.Size(95, 23)
        Me.AdvFamilia.TabIndex = 61
        '
        'AdvSubfamilia
        '
        Me.AdvSubfamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubfamilia.EntityName = "Articulo"
        Me.AdvSubfamilia.Location = New System.Drawing.Point(491, 129)
        Me.AdvSubfamilia.Name = "AdvSubfamilia"
        Me.AdvSubfamilia.SecondaryDataFields = "IDSubfamilia"
        Me.AdvSubfamilia.Size = New System.Drawing.Size(79, 23)
        Me.AdvSubfamilia.TabIndex = 62
        '
        'CIRetornos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "C. Devolución", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "QPendiente"), New Solmicro.Expertis.Engine.UI.CheckField("FechaAlquiler", "Fecha Fin Alquiler", Solmicro.Expertis.Engine.UI.CheckFieldType.DateTime, ""), New Solmicro.Expertis.Engine.UI.CheckField("HoraAlquiler", "Hora Fin Alquiler", Solmicro.Expertis.Engine.UI.CheckFieldType.Char, ""), New Solmicro.Expertis.Engine.UI.CheckField("FechaDevolucion", "Fecha Devolución", Solmicro.Expertis.Engine.UI.CheckFieldType.DateTime, "")})
        Me.ClientSize = New System.Drawing.Size(789, 465)
        Me.EntityName = "AlbaranVentaLinea"
        Me.KeyField = "IDLineaAlbaran"
        Me.Name = "CIRetornos"
        Me.UseCheck = True
        Me.ViewName = "vAlquilerCIRetornos"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxConAvisoRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cbxCGestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Enum LeerGridMensajes
        OK
        CantidadVacia
        CantidadNegativa
        CantidadVaciaOnegativa
        LoteObligatorio
        AlmacenDeposito
        FechaVacia
        FechaAlquilerPosteriorARetorno
    End Enum

    Protected Enum enumTipoExpedicion
        Consumo
        Retorno
        'David V 21/02/22
        Transferencia
        'David V 21/02/22
    End Enum

    Protected mstrALBARANDEPOSITO, mIDOperario As String

#Region " Load "

    Private Sub CIRetornos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadEnums()
            LoadToolbarActions()
            LoadGridActions()
            InitFilterCriteria()
            LoadParams()
        End If
    End Sub

    Private Sub LoadERPData()
        Dim dc As Contador.DefaultCounter = ExpertisApp.ExecuteTask(Of String, Contador.DefaultCounter)(AddressOf Contador.GetDefaultCounterValue, GetType(AlbaranVentaCabecera).Name)
        AdvContador.Text = dc.CounterID
        Dim CentroGestionInfo As New UsuarioCentroGestion.UsuarioCentroGestionInfo
        ExpertisApp.ExecuteTask(Of UsuarioCentroGestion.UsuarioCentroGestionInfo, UsuarioCentroGestion.UsuarioCentroGestionInfo)(AddressOf UsuarioCentroGestion.ObtenerUsuarioCentroGestion, CentroGestionInfo)
        cbxCGestion.Value = CentroGestionInfo.IDCentroGestion
        mstrALBARANDEPOSITO = New Parametro().TipoAlbaranDeDeposito
        mIDOperario = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf Operario.ObtenerIDOperarioUsuario, Nothing)
    End Sub

    Private Sub LoadEnums()
        cbxConAvisoRetorno.DataSource = New EnumData("EnumBoolean")
        cbxConAvisoRetorno.Value = enumBoolean.Todos
        cbxHora.Text = "0:00:00"
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("1. Albarán Retorno", AddressOf ExpedirAlbaranRetorno, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
        'Me.AddSeparator()
        'Esto era albarán de consumo
        'Me.FormActions.Add("Albarán de consumo", AddressOf ExpedirAlbaranConsumo, ExpertisApp.GetIcon("xAmortContable.ico"))
        'Me.AddSeparator()
        'Me.FormActions.Add("Traspaso de Material entre Alquileres", AddressOf TraspasoMaterial, ExpertisApp.GetIcon("gear_refresh.ico"))
        'Me.FormActions.Add("Sustitución de Activo Averiado", AddressOf CambioMaquina, ExpertisApp.GetIcon("gear_replace.ico"))
        'Me.AddSeparator()
        'Me.FormActions.Add("Recalcular Fechas de Retorno de Días Mínimos", AddressOf RecalcularFechaRetorno, ExpertisApp.GetIcon("clock_refresh.ico"))
        'David Velasco 21/02/22
        Me.FormActions.Add("2. Liquidar con Movimiento de Salida.", AddressOf LiquidacionConMovimiento, ExpertisApp.GetIcon("gear_replace.ico"))
        'Me.AddSeparator()
        Me.FormActions.Add("3. Transferencia entre almacenes.", AddressOf TraspasoMaterialsin0112, ExpertisApp.GetIcon("exchange.ico"))
        'Me.FormActions.Add("GENERAR VENCIMIENTOS BUENO", AddressOf TraspasoMaterialsin011Bueno, ExpertisApp.GetIcon("gear_replace.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Liquidar sin Movimiento de Salida. Borrar.", AddressOf LiquidacionSinMovimiento, ExpertisApp.GetIcon("delete2.ico"))


    End Sub
    'David Velasco 21/02
    'Private Sub TraspasoMaterialsin011Bueno()
    '    Expedir(enumTipoExpedicion.Transferencia, False)
    'End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add(cnABRIRALBARANVENTA, AddressOf VerAlbaran, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
        Grid.Actions.Add(cnABRIRALQUILER, AddressOf VerAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
        Grid.Actions.Add(cnABRIRORDENSERVICIO, AddressOf AccionAbrirOrdenServicio, ExpertisApp.GetIcon("clipboard.ico"))
    End Sub

    Private Sub InitFilterCriteria()
        txtPendiente.Value = 1
        cbxConAvisoRetorno.Value = enumBoolean.Todos
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            Dim ht As Hashtable = Me.Params
            If ht.ContainsKey("IDCliente") AndAlso Length(ht("IDCliente")) > 0 Then
                AdvCliente.Text = ht("IDCliente")
            End If
            If ht.ContainsKey("IDObra") AndAlso Length(ht("IDObra")) > 0 Then
                AdvObraDesde.Value = ht("IDObra")
                AdvObraHasta.Value = ht("IDObra")
            End If
            If ht.ContainsKey("NObra") AndAlso Length(ht("NObra")) > 0 Then
                AdvObraDesde.Text = ht("NObra")
                AdvObraHasta.Text = ht("NObra")
            End If
            If ht.ContainsKey("IDTrabajo") AndAlso Length(ht("IDTrabajo")) > 0 Then
                AdvOServicio.Value = ht("IDTrabajo")
            End If
            If ht.ContainsKey("CodTrabajo") AndAlso Length(ht("CodTrabajo")) > 0 Then
                AdvOServicio.Text = ht("CodTrabajo")
            End If

            Me.Execute()
        End If
    End Sub

#End Region

#Region " Toolbar Actions "

#Region " Expedir "

    Private Sub ExpedirAlbaranRetorno()
        Expedir(enumTipoExpedicion.Retorno)
    End Sub

    Private Sub ExpedirAlbaranConsumo()
        Expedir(enumTipoExpedicion.Consumo)
    End Sub

    Protected Overridable Sub Expedir(ByVal tipo As enumTipoExpedicion, Optional ByVal blnTraspaso As Boolean = False)
        If Length(mIDOperario) > 0 Then
            If Length(AdvContador.Text) > 0 Then
                Dim dtMarcados As DataTable = Me.CheckedRecords
                If dtMarcados Is Nothing OrElse dtMarcados.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    'If Me.RecordsState = RecordsState.Modified Then Me.UpdateData()

                    'If ValidaFianzasObligatorias(dtMarcados.Copy) = 0 Then
                    Dim blnCancel As Boolean = False
                    Dim TraspasoInfo As New TraspasoMaquina.dataTraspasoMaquina
                    If blnTraspaso Then
                        TraspasoInfo = TratarTraspasoMaterial(dtMarcados.Copy)
                        blnCancel = TraspasoInfo Is Nothing
                    End If
                    'David Velasco 14/6/22
                    If Not blnCancel Then blnCancel = ValidaDatosAExpedir(dtMarcados, , tipo = enumTipoExpedicion.Retorno)
                    If Not blnCancel AndAlso dtMarcados.Rows.Count > 0 Then
                        Dim p As New Parametro
                        Dim IDTipoAlbaran As String = String.Empty
                        Select Case tipo
                            Case enumTipoExpedicion.Consumo
                                IDTipoAlbaran = p.TipoAlbaranDeConsumo
                                If blnTraspaso Then
                                    IDTipoAlbaran = p.TipoAlbaranRetornoAlquiler
                                End If
                            Case enumTipoExpedicion.Retorno
                                IDTipoAlbaran = p.TipoAlbaranRetornoAlquiler
                                Dim frm As New frmCondicionesAlquilerMasiva
                                frm.AbrirCondicionesAlquiler(dtMarcados.Copy)
                            Case enumTipoExpedicion.Transferencia
                                IDTipoAlbaran = p.TipoAlbaranRetornoAlquiler
                                Dim frm As New frmCondicionesAlquilerMasiva
                                frm.AbrirCondicionesAlquiler(dtMarcados.Copy)
                                Dim frmAC3 As New frmDatosAuxExpedicion
                                Dim d3 As frmDatosAuxExpedicion.DatosContadorConductor
                                d3 = frmAC3.AbrirFormulario(dtMarcados.Copy, False, True, tipo = enumTipoExpedicion.Consumo, , blnTraspaso)
                                If d3.Ok = DialogResult.OK Then
                                    Dim dtContadores As DataTable = d3.dtContadores

                                    Dim aExpedir() As CrearAlbaranVentaInfo = DatosAExpedir(dtMarcados, blnTraspaso, TraspasoInfo.FechaRetorno, _
                                                                                            TraspasoInfo.HoraRetorno, , d3.dtEstadoActivo)
                                    Me.Cursor = Cursors.WaitCursor

                                    Dim data As New DataPrcAlbaranar(aExpedir, AdvContador.Text, , IDTipoAlbaran, Business.BusinessEnum.enumTipoExpedicion.teAlquiler)
                                    Dim Propuesta As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                                    If Not IsNothing(Propuesta) Then
                                        If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                                            Dim frm2 As New frmAlbaranProvisional
                                            Dim dr As DialogResult = frm2.AbrirFormulario(Propuesta.PropuestaAlbaranes)
                                            If dr = DialogResult.OK Then
                                                Me.Cursor = Cursors.WaitCursor
                                                Dim datosAct As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                                                datosAct.Contadores = dtContadores
                                                datosAct.Avisos = dtMarcados.Copy
                                                datosAct.Retornos = False

                                                Dim rslt As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquilerSinStock), datosAct)
                                                'MsgBox("Se ha generado el vencimiento correctamente.", MsgBoxStyle.OkOnly)
                                                Me.Cursor = Cursors.Default
                                                '2ª PARTE- hacer el movimiento de un almacen a otro.
                                                'If blnTraspaso Then
                                                '    TraspasoInfo.dtRetornos = dtMarcados
                                                '    Dim rsltTraspaso As ResultAlbaranAlquiler = GenerarTraspaso(TraspasoInfo)
                                                '    rslt = UnirResults(rslt, rsltTraspaso)
                                                'ElseIf Not rslt.StockUpdateData Is Nothing AndAlso rslt.StockUpdateData.Length > 0 Then
                                                '    Dim frmStock As New DetalleActualizacionStock
                                                '    frmStock.DataSource = rslt.StockUpdateData
                                                '    frmStock.ShowDialog()
                                                'End If
                                            Else
                                                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            End If
                                        Else
                                            TratarLog(Propuesta.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                                        End If
                                        Grid.UnCheckAllRecords()
                                        Me.Execute()
                                        Me.Cursor = Cursors.Default
                                    Else
                                        ExpertisApp.GenerateMessage("No se ha podido generar el Albarán.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    End If
                                    Exit Sub
                                End If
                        End Select
                       
                        Dim frmAC As New frmDatosAuxExpedicion
                        Dim d As frmDatosAuxExpedicion.DatosContadorConductor
                        d = frmAC.AbrirFormulario(dtMarcados.Copy, False, True, tipo = enumTipoExpedicion.Consumo, , blnTraspaso)
                        If d.Ok = DialogResult.OK Then
                            Dim dtContadores As DataTable = d.dtContadores

                            Dim aExpedir() As CrearAlbaranVentaInfo = DatosAExpedir(dtMarcados, blnTraspaso, TraspasoInfo.FechaRetorno, _
                                                                                    TraspasoInfo.HoraRetorno, , d.dtEstadoActivo)
                            Me.Cursor = Cursors.WaitCursor

                            Dim data As New DataPrcAlbaranar(aExpedir, AdvContador.Text, , IDTipoAlbaran, Business.BusinessEnum.enumTipoExpedicion.teAlquiler)
                            Dim Propuesta As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                            If Not IsNothing(Propuesta) Then
                                If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                                    Dim frm As New frmAlbaranProvisional
                                    Dim dr As DialogResult = frm.AbrirFormulario(Propuesta.PropuestaAlbaranes)
                                    If dr = DialogResult.OK Then
                                        Me.Cursor = Cursors.WaitCursor
                                        Dim datosAct As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                                        datosAct.Contadores = dtContadores
                                        datosAct.Avisos = dtMarcados.Copy
                                        datosAct.Retornos = True

                                        Dim rslt As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquiler), datosAct)

                                        If blnTraspaso Then
                                            TraspasoInfo.dtRetornos = dtMarcados
                                            Dim rsltTraspaso As ResultAlbaranAlquiler = GenerarTraspaso(TraspasoInfo)
                                            rslt = UnirResults(rslt, rsltTraspaso)
                                        ElseIf Not rslt.StockUpdateData Is Nothing AndAlso rslt.StockUpdateData.Length > 0 Then
                                            Dim frmStock As New DetalleActualizacionStock
                                            frmStock.DataSource = rslt.StockUpdateData
                                            frmStock.ShowDialog()
                                        End If

                                        Me.UnCheckAllRecords()

                                        Dim Albaranes() As Integer = AlbaranesGenerados(rslt.CreateData)
                                        Dim IDAlbaran(Albaranes.Length - 1) As Object
                                        Albaranes.CopyTo(IDAlbaran, 0)

                                        Dim AbrirAlbaran As Boolean = True

                                        Dim dtOT As DataTable = New MntoOT().Filter(New InListFilterItem("IDAlbaranRetorno", IDAlbaran, FilterType.Numeric), , "IDOT,NROT")
                                        If Not dtOT Is Nothing AndAlso dtOT.Rows.Count > 0 Then
                                            Dim NROTs As String = String.Empty
                                            Dim IDOT As Integer = dtOT.Rows(0)("IDOT")
                                            For Each drOT As DataRow In dtOT.Rows
                                                If Len(NROTs) > 0 Then NROTs = NROTs & " ,"
                                                NROTs = NROTs & drOT("NROT")
                                            Next

                                            Dim NAlbaranes As String = ListadoAlbaranesGenerados(rslt.CreateData)
                                            If ExpertisApp.GenerateMessage("Se han generado las Ordenes de Trabajo: |.|Se han generado los Albaranes : |.|¿Desea abrir el mantenimiento de las Ordenes de Trabajo?,", MessageBoxButtons.YesNo, MessageBoxIcon.Information, NROTs, vbNewLine, NAlbaranes, vbNewLine) = DialogResult.Yes Then
                                                AbrirAlbaran = False
                                                ExpertisApp.OpenForm("MNTOOT", New NumberFilterItem("IDOT", IDOT))
                                            End If
                                        End If
                                        If AbrirAlbaran Then
                                            TratarLog(rslt.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                                        End If

                                        Me.Cursor = Cursors.Default
                                    Else
                                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                Else
                                    TratarLog(Propuesta.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                                End If
                                Grid.UnCheckAllRecords()
                                Me.Execute()
                            Else
                                ExpertisApp.GenerateMessage("No se ha podido generar el Albarán.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                    ElseIf dtMarcados.Rows.Count = 0 Then
                        ExpertisApp.GenerateMessage("No hay líneas que cumplan las condiciones anteriormente mencionadas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    '    Else
                    '    Dim frm As New frmOrdenesSinContabilizar
                    '    frm.AbrirOrdenesSinContabilizar(dtMarcados)
                    'End If
                End If
            Else
                ExpertisApp.GenerateMessage("El Contador es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            ExpertisApp.GenerateMessage("Proceso cancelado. Es necesario asignar un Operario al Usuario.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#Region " Tratamiento Expedición "

    Protected Function ValidaFianzasObligatorias(ByVal dtMarcados As DataTable) As Integer
        Dim f As New Filter
        f.Add(New BooleanFilterItem("FianzaObligatoria", True))
        f.Add(New BooleanFilterItem("FianzaContabilizada", False))

        Dim dv As New DataView(dtMarcados)
        dv.RowFilter = f.Compose(New AdoFilterComposer)

        Return dv.Count
    End Function

    Protected Function TratarTraspasoMaterial(ByVal dtMarcados As DataTable) As TraspasoMaquina.dataTraspasoMaquina
        Dim dtmFechaRetorno As Date = Nz(cbxFecha.Value, Date.Today)
        Dim dtmFechaSalida As Date = dtmFechaRetorno
        Dim strHoraRetorno As String = Format(Me.cbxHora.Value, "HH:mm:ss")
        Dim strHoraSalida As String = strHoraRetorno

        Dim frm As New FrmTraspasoMaterial
        Dim dr As DialogResult = frm.AbrirTraspasoMaterial(dtMarcados, dtmFechaRetorno, strHoraRetorno, dtmFechaSalida, strHoraSalida)
        If dr = Windows.Forms.DialogResult.OK Then
            'Localizar Los materiales antes de hacer el retorno para saber su situacion en el traspaso de la nueva obra
            Dim IDLineaMaterial(-1) As Object
            For Each drMarcados As DataRow In dtMarcados.Rows
                If drMarcados("IDLineaMaterial") > 0 Then
                    ReDim Preserve IDLineaMaterial(UBound(IDLineaMaterial) + 1)
                    IDLineaMaterial(UBound(IDLineaMaterial)) = drMarcados("IDLineaMaterial")
                End If
            Next

            Dim TraspasoInfo As New TraspasoMaquina.dataTraspasoMaquina
            TraspasoInfo.dtObraMaterial = New ObraMaterial().Filter(New InListFilterItem("IDLineaMaterial", IDLineaMaterial, FilterType.Numeric, True))
            TraspasoInfo.FechaRetorno = frm.cbxFechaRetorno.Value
            TraspasoInfo.HoraRetorno = frm.txtHoraRetorno.Text
            TraspasoInfo.FechaSalida = frm.cbxFechaSalida.Value
            TraspasoInfo.HoraSalida = frm.txtHoraSalida.Text
            TraspasoInfo.IDObraDestino = frm.AdvIDObra.Value
            If Length(frm.txtFianza.Value) > 0 Then TraspasoInfo.Fianza = frm.txtFianza.Value
            If Length(frm.cbxFechaFianza.Value) > 0 Then TraspasoInfo.FechaFianza = frm.cbxFechaFianza.Value

            Return TraspasoInfo
        Else
            Return Nothing
        End If
    End Function

    Protected Function ValidaDatosAExpedir(ByRef dtMarcados As DataTable, _
                                           Optional ByVal blnSinMensajes As Boolean = False, _
                                           Optional ByVal blnRetorno As Boolean = False) As Boolean

        Dim intError As LeerGridMensajes = LeerGridMensajes.OK
        Dim aExpedir(-1) As CrearAlbaranVentaInfo

        For Each drMarcados As DataRow In dtMarcados.Select
            If Length(drMarcados("FechaEnvio")) > 0 AndAlso Length(drMarcados("FechaDevolucion")) > 0 AndAlso drMarcados("FechaEnvio") > drMarcados("FechaDevolucion") Then
                intError = LeerGridMensajes.FechaAlquilerPosteriorARetorno
                dtMarcados.Rows.Remove(drMarcados)
            ElseIf Length(drMarcados("IDAlmacenDeposito")) = 0 Then
                intError = LeerGridMensajes.AlmacenDeposito
                dtMarcados.Rows.Remove(drMarcados)
            ElseIf Length(drMarcados("FechaAlbaran")) > 0 And Length(drMarcados("FechaDevolucion")) > 0 Then
                If Length(drMarcados("CantidadMarca1")) > 0 Then
                    If drMarcados("CantidadMarca1") < 0 Then
                        If intError = LeerGridMensajes.OK Then
                            intError = LeerGridMensajes.CantidadVacia
                        ElseIf intError = LeerGridMensajes.CantidadVacia Then
                            intError = LeerGridMensajes.CantidadVaciaOnegativa
                        End If
                    End If
                Else
                    intError = LeerGridMensajes.FechaVacia
                    dtMarcados.Rows.Remove(drMarcados)
                End If
            End If
        Next

        Dim blnCancel As Boolean
        If Not blnSinMensajes Then
            blnCancel = TratamientoMensajes(intError)
        End If

        Return blnCancel
    End Function

    Protected Function DatosAExpedir(ByRef dtMarcados As DataTable, _
                                     Optional ByVal blnTraspaso As Boolean = False, _
                                     Optional ByVal dtmFechaRetorno As Date = cnMinDate, _
                                     Optional ByVal strHoraRetorno As String = "", _
                                     Optional ByVal blnConsumo As Boolean = False, _
                                     Optional ByVal dtEstadoActivo As DataTable = Nothing) As CrearAlbaranVentaInfo()

        Dim intError As LeerGridMensajes = LeerGridMensajes.OK
        Dim aExpedir(-1) As CrearAlbaranVentaInfo

        For Each drMarcados As DataRow In dtMarcados.Select
            Dim datosExp As New CrearAlbaranVentaInfo
            datosExp.IDLinea = drMarcados("IDLineaAlbaran")
            datosExp.IDLineaMaterial = Nz(drMarcados("IDLineaMaterial"), 0)
            datosExp.Cantidad = drMarcados("CantidadMarca1")
            datosExp.IDCliente = drMarcados("IDCliente")
            If blnTraspaso Or blnConsumo Then
                datosExp.FechaAlquiler = dtmFechaRetorno
                datosExp.HoraAlquiler = strHoraRetorno
            Else
                If Length(drMarcados("FechaAlquiler")) > 0 Then
                    datosExp.FechaAlquiler = drMarcados("FechaAlquiler")
                ElseIf (cbxFecha.Value) <> cnMinDate Then
                    datosExp.FechaAlquiler = cbxFecha.Value
                Else
                    datosExp.FechaAlquiler = Date.Today
                End If
                If Length(drMarcados("HoraAlquiler")) > 0 Then
                    datosExp.HoraAlquiler = drMarcados("HoraAlquiler")
                ElseIf Length(cbxHora.Text) > 0 Then
                    datosExp.HoraAlquiler = cbxHora.Text
                Else
                    datosExp.HoraAlquiler = Date.Today.ToShortTimeString
                End If
                datosExp.FechaPrevistaRetorno = Nz(dtmFechaRetorno, cnMinDate)
            End If
            If Not IsNothing(dtEstadoActivo) AndAlso dtEstadoActivo.Rows.Count > 0 Then
                Dim dvEstadoActivo As New DataView(dtEstadoActivo.Copy)
                dvEstadoActivo.RowFilter = "IDLineaAlbaranOrigen =" & drMarcados("IDLineaAlbaran")
                If dvEstadoActivo.Count > 0 Then
                    datosExp.IDEstadoActivo = dvEstadoActivo(0).Row("IDEstadoActivoNew")
                End If
            End If

            ReDim Preserve aExpedir(UBound(aExpedir) + 1)
            aExpedir(UBound(aExpedir)) = datosExp
        Next

        Return aExpedir
    End Function

    Private Function TratamientoMensajes(ByVal intError As LeerGridMensajes) As Boolean
        Dim blnCancel As Boolean

        If intError = LeerGridMensajes.OK Then
            If ExpertisApp.GenerateMessage("Se va a proceder a la Generación de Albaranes de las líneas seleccionadas. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                blnCancel = True
            End If
        Else
            Select Case intError
                Case LeerGridMensajes.FechaAlquilerPosteriorARetorno
                    If ExpertisApp.GenerateMessage("Aquellas líneas que cuya Fecha Retorno sea inferior a la Fecha de Envío no serán incluidas en el proceso de Generación de Albaranes de Retorno. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                        blnCancel = True
                    End If
                Case LeerGridMensajes.FechaVacia
                    If ExpertisApp.GenerateMessage("Aquellas líneas que no tengan una Fecha Albarán y una Fecha Devolución no serán incluidas en el proceso de Generación de Albaranes de Consumo. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                        blnCancel = True
                    End If
                Case LeerGridMensajes.AlmacenDeposito
                    If ExpertisApp.GenerateMessage("Aquellas líneas que no tengan un Almacén Depósito no serán incluidas en el proceso de Generación de Albaranes de Consumo. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                        blnCancel = True
                    End If
                Case LeerGridMensajes.CantidadVacia, LeerGridMensajes.CantidadVaciaOnegativa
                    If ExpertisApp.GenerateMessage("Los registros que no tengan una cantidad distinta de cero no generarán Albaranes. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                        blnCancel = True
                        If LeerGridMensajes.CantidadVaciaOnegativa Then
                            If ExpertisApp.GenerateMessage("Tiene registros con cantidades negativas. ¿Es correcto?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                                blnCancel = True
                            End If
                        End If
                    End If
                Case LeerGridMensajes.CantidadNegativa
                    If ExpertisApp.GenerateMessage("Tiene registros con cantidades negativas. ¿Es correcto?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                        blnCancel = True
                    End If
                Case LeerGridMensajes.LoteObligatorio
                    blnCancel = True
                    ExpertisApp.GenerateMessage("El Lote es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Select
        End If

        Return blnCancel
    End Function

#End Region

#End Region

#Region " Traspaso Material "

    Private Sub TraspasoMaterial()
        Expedir(enumTipoExpedicion.Consumo, True)
    End Sub
    'David Velasco 03/08/22
    Private Sub TraspasoMaterialsin0112()
        Expedir2(enumTipoExpedicion.Transferencia, True)
    End Sub
    Protected Function GenerarTraspaso2(ByVal datosTraspaso As TraspasoMaquina.dataTraspasoMaquina) As ResultAlbaranAlquiler
        If datosTraspaso.IDObraDestino > 0 Then
            If Not IsNothing(datosTraspaso.dtObraMaterial) AndAlso datosTraspaso.dtObraMaterial.Rows.Count > 0 Then
                Dim dtOT As DataTable = ExpertisApp.ExecuteTask(Of TraspasoMaquina.dataTraspasoMaquina, DataTable)(AddressOf TraspasoMaquina.GenerarTraspasoMaquina2, datosTraspaso)
                If Not IsNothing(dtOT) AndAlso dtOT.Rows.Count > 0 Then
                    Return GenerarAlbaranDesdeTraspaso(datosTraspaso, dtOT)
                End If
            End If
        End If

        Return Nothing
    End Function

    Protected Overridable Sub Expedir2(ByVal tipo As enumTipoExpedicion, Optional ByVal blnTraspaso As Boolean = False)
        If Length(mIDOperario) > 0 Then
            If Length(AdvContador.Text) > 0 Then
                Dim dtMarcados As DataTable = Me.CheckedRecords
                If dtMarcados Is Nothing OrElse dtMarcados.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim blnCancel As Boolean = False
                    Dim TraspasoInfo As New TraspasoMaquina.dataTraspasoMaquina
                    If blnTraspaso Then
                        TraspasoInfo = TratarTraspasoMaterial(dtMarcados.Copy)
                        blnCancel = TraspasoInfo Is Nothing
                    End If
                    If Not blnCancel Then blnCancel = ValidaDatosAExpedir(dtMarcados, , tipo = enumTipoExpedicion.Retorno)
                    If Not blnCancel AndAlso dtMarcados.Rows.Count > 0 Then
                        Dim p As New Parametro
                        Dim IDTipoAlbaran As String = String.Empty
                        Select Case tipo
                            Case enumTipoExpedicion.Transferencia
                                IDTipoAlbaran = p.TipoAlbaranRetornoAlquiler
                                Dim frm As New frmCondicionesAlquilerMasiva
                                frm.AbrirCondicionesAlquiler(dtMarcados.Copy)
                                Dim frmAC3 As New frmDatosAuxExpedicion
                                Dim d3 As frmDatosAuxExpedicion.DatosContadorConductor
                                d3 = frmAC3.AbrirFormulario(dtMarcados.Copy, False, True, tipo = enumTipoExpedicion.Consumo, , blnTraspaso)
                                If d3.Ok = DialogResult.OK Then
                                    Dim dtContadores As DataTable = d3.dtContadores

                                    Dim aExpedir() As CrearAlbaranVentaInfo = DatosAExpedir(dtMarcados, blnTraspaso, TraspasoInfo.FechaRetorno, _
                                                                                            TraspasoInfo.HoraRetorno, , d3.dtEstadoActivo)
                                    Me.Cursor = Cursors.WaitCursor

                                    Dim data As New DataPrcAlbaranar(aExpedir, AdvContador.Text, , IDTipoAlbaran, Business.BusinessEnum.enumTipoExpedicion.teAlquiler)
                                    Dim Propuesta As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                                    If Not IsNothing(Propuesta) Then
                                        If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                                            Dim frm2 As New frmAlbaranProvisional
                                            Dim dr As DialogResult = frm2.AbrirFormulario(Propuesta.PropuestaAlbaranes)
                                            If dr = DialogResult.OK Then
                                                Me.Cursor = Cursors.WaitCursor
                                                Dim datosAct As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                                                datosAct.Contadores = dtContadores
                                                datosAct.Avisos = dtMarcados.Copy
                                                datosAct.Retornos = False

                                                Dim rslt As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquilerSinStock), datosAct)
                                                'MsgBox("Se ha generado el vencimiento correctamente.", MsgBoxStyle.OkOnly)
                                                Me.Cursor = Cursors.Default

                                                'CREACIÓN DE LA ORDEN DE SERVICIO
                                                'David Velasco 04/08/22
                                                TraspasoInfo.dtRetornos = dtMarcados
                                                Dim rsltTraspaso As ResultAlbaranAlquiler = GenerarTraspaso2(TraspasoInfo)
                                                rslt = UnirResults(rslt, rsltTraspaso)

                                                Dim frmStock As New DetalleActualizacionStock
                                                frmStock.DataSource = rslt.StockUpdateData
                                                frmStock.ShowDialog()
                                            Else
                                                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            End If
                                        Else
                                            TratarLog(Propuesta.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                                        End If
                                            Grid.UnCheckAllRecords()
                                            Me.Execute()
                                            Me.Cursor = Cursors.Default
                                        Else
                                            ExpertisApp.GenerateMessage("No se ha podido generar el Albarán.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                        End If
                                        Exit Sub
                                    End If
                        End Select

                        
                    ElseIf dtMarcados.Rows.Count = 0 Then
                        ExpertisApp.GenerateMessage("No hay líneas que cumplan las condiciones anteriormente mencionadas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else
                ExpertisApp.GenerateMessage("El Contador es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            ExpertisApp.GenerateMessage("Proceso cancelado. Es necesario asignar un Operario al Usuario.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'Fin David
    'David Velasco 21/02/22 - LIQUIDACIONES CON O SIN MOVIMIENTO
    Private Sub LiquidacionConMovimiento()
        ExpedirConMovimiento(enumTipoExpedicion.Transferencia, False)
    End Sub

    Protected Overridable Sub ExpedirConMovimiento(ByVal tipo As enumTipoExpedicion, Optional ByVal blnTraspaso As Boolean = False)
        If Length(mIDOperario) > 0 Then
            If Length(AdvContador.Text) > 0 Then
                Dim dtMarcados As DataTable = Me.CheckedRecords
                If dtMarcados Is Nothing OrElse dtMarcados.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    'If Me.RecordsState = RecordsState.Modified Then Me.UpdateData()

                    'If ValidaFianzasObligatorias(dtMarcados.Copy) = 0 Then
                    Dim blnCancel As Boolean = False
                    Dim TraspasoInfo As New TraspasoMaquina.dataTraspasoMaquina
                    If blnTraspaso Then
                        TraspasoInfo = TratarTraspasoMaterial(dtMarcados.Copy)
                        blnCancel = TraspasoInfo Is Nothing
                    End If
                    'David Velasco 14/6/22
                    If Not blnCancel Then blnCancel = ValidaDatosAExpedir(dtMarcados, , tipo = enumTipoExpedicion.Retorno)
                    If Not blnCancel AndAlso dtMarcados.Rows.Count > 0 Then
                        Dim p As New Parametro
                        Dim IDTipoAlbaran As String = String.Empty
                        Select Case tipo
                            Case enumTipoExpedicion.Consumo
                                IDTipoAlbaran = p.TipoAlbaranDeConsumo
                                If blnTraspaso Then
                                    IDTipoAlbaran = p.TipoAlbaranRetornoAlquiler
                                End If
                            Case enumTipoExpedicion.Retorno
                                IDTipoAlbaran = p.TipoAlbaranRetornoAlquiler
                                Dim frm As New frmCondicionesAlquilerMasiva
                                frm.AbrirCondicionesAlquiler(dtMarcados.Copy)
                            Case enumTipoExpedicion.Transferencia
                                IDTipoAlbaran = p.TipoAlbaranRetornoAlquiler
                                Dim frm As New frmCondicionesAlquilerMasiva
                                frm.AbrirCondicionesAlquiler(dtMarcados.Copy)
                                Dim frmAC3 As New frmDatosAuxExpedicion
                                Dim d3 As frmDatosAuxExpedicion.DatosContadorConductor
                                d3 = frmAC3.AbrirFormulario(dtMarcados.Copy, False, True, tipo = enumTipoExpedicion.Consumo, , blnTraspaso)
                                If d3.Ok = DialogResult.OK Then
                                    Dim dtContadores As DataTable = d3.dtContadores

                                    Dim aExpedir() As CrearAlbaranVentaInfo = DatosAExpedir(dtMarcados, blnTraspaso, TraspasoInfo.FechaRetorno, _
                                                                                            TraspasoInfo.HoraRetorno, , d3.dtEstadoActivo)
                                    Me.Cursor = Cursors.WaitCursor

                                    Dim data As New DataPrcAlbaranar(aExpedir, AdvContador.Text, , IDTipoAlbaran, Business.BusinessEnum.enumTipoExpedicion.teAlquiler)
                                    Dim Propuesta As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                                    If Not IsNothing(Propuesta) Then
                                        If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                                            Dim frm2 As New frmAlbaranProvisional
                                            Dim dr As DialogResult = frm2.AbrirFormulario(Propuesta.PropuestaAlbaranes)
                                            If dr = DialogResult.OK Then
                                                Me.Cursor = Cursors.WaitCursor
                                                Dim datosAct As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                                                datosAct.Contadores = dtContadores
                                                datosAct.Avisos = dtMarcados.Copy
                                                datosAct.Retornos = False

                                                Dim rslt As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquilerLiquidar), datosAct)
                                                'MsgBox("Se ha generado el vencimiento correctamente.", MsgBoxStyle.OkOnly)
                                                Me.Cursor = Cursors.Default
                                                '2ª PARTE- hacer el movimiento de un almacen a otro.
                                                'If blnTraspaso Then
                                                'TraspasoInfo.dtRetornos = dtMarcados
                                                'Dim rsltTraspaso As ResultAlbaranAlquiler = GenerarTraspaso(TraspasoInfo)
                                                'rslt = UnirResults(rslt, rsltTraspaso)
                                                'ElseIf Not rslt.StockUpdateData Is Nothing AndAlso rslt.StockUpdateData.Length > 0 Then
                                                Dim frmStock As New DetalleActualizacionStock
                                                frmStock.DataSource = rslt.StockUpdateData
                                                frmStock.ShowDialog()
                                                'End If
                                            Else
                                                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            End If
                                        Else
                                            TratarLog(Propuesta.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                                        End If
                                        Grid.UnCheckAllRecords()
                                        Me.Execute()
                                        Me.Cursor = Cursors.Default
                                    Else
                                        ExpertisApp.GenerateMessage("No se ha podido generar el Albarán.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    End If
                                    Exit Sub
                                End If
                        End Select

                        'Dim frmAC As New frmDatosAuxExpedicion
                        'Dim d As frmDatosAuxExpedicion.DatosContadorConductor
                        'd = frmAC.AbrirFormulario(dtMarcados.Copy, False, True, tipo = enumTipoExpedicion.Consumo, , blnTraspaso)
                        'If d.Ok = DialogResult.OK Then
                        '    Dim dtContadores As DataTable = d.dtContadores

                        '    Dim aExpedir() As CrearAlbaranVentaInfo = DatosAExpedir(dtMarcados, blnTraspaso, TraspasoInfo.FechaRetorno, _
                        '                                                            TraspasoInfo.HoraRetorno, , d.dtEstadoActivo)
                        '    Me.Cursor = Cursors.WaitCursor

                        '    Dim data As New DataPrcAlbaranar(aExpedir, AdvContador.Text, , IDTipoAlbaran, Business.BusinessEnum.enumTipoExpedicion.teAlquiler)
                        '    Dim Propuesta As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                        '    If Not IsNothing(Propuesta) Then
                        '        If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                        '            Dim frm As New frmAlbaranProvisional
                        '            Dim dr As DialogResult = frm.AbrirFormulario(Propuesta.PropuestaAlbaranes)
                        '            If dr = DialogResult.OK Then
                        '                Me.Cursor = Cursors.WaitCursor
                        '                Dim datosAct As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                        '                datosAct.Contadores = dtContadores
                        '                datosAct.Avisos = dtMarcados.Copy
                        '                datosAct.Retornos = True

                        '                Dim rslt As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquiler), datosAct)

                        '                If blnTraspaso Then
                        '                    TraspasoInfo.dtRetornos = dtMarcados
                        '                    Dim rsltTraspaso As ResultAlbaranAlquiler = GenerarTraspaso(TraspasoInfo)
                        '                    rslt = UnirResults(rslt, rsltTraspaso)
                        '                ElseIf Not rslt.StockUpdateData Is Nothing AndAlso rslt.StockUpdateData.Length > 0 Then
                        '                    Dim frmStock As New DetalleActualizacionStock
                        '                    frmStock.DataSource = rslt.StockUpdateData
                        '                    frmStock.ShowDialog()
                        '                End If

                        '                Me.UnCheckAllRecords()

                        '                Dim Albaranes() As Integer = AlbaranesGenerados(rslt.CreateData)
                        '                Dim IDAlbaran(Albaranes.Length - 1) As Object
                        '                Albaranes.CopyTo(IDAlbaran, 0)

                        '                Dim AbrirAlbaran As Boolean = True

                        '                Dim dtOT As DataTable = New MntoOT().Filter(New InListFilterItem("IDAlbaranRetorno", IDAlbaran, FilterType.Numeric), , "IDOT,NROT")
                        '                If Not dtOT Is Nothing AndAlso dtOT.Rows.Count > 0 Then
                        '                    Dim NROTs As String = String.Empty
                        '                    Dim IDOT As Integer = dtOT.Rows(0)("IDOT")
                        '                    For Each drOT As DataRow In dtOT.Rows
                        '                        If Len(NROTs) > 0 Then NROTs = NROTs & " ,"
                        '                        NROTs = NROTs & drOT("NROT")
                        '                    Next

                        '                    Dim NAlbaranes As String = ListadoAlbaranesGenerados(rslt.CreateData)
                        '                    If ExpertisApp.GenerateMessage("Se han generado las Ordenes de Trabajo: |.|Se han generado los Albaranes : |.|¿Desea abrir el mantenimiento de las Ordenes de Trabajo?,", MessageBoxButtons.YesNo, MessageBoxIcon.Information, NROTs, vbNewLine, NAlbaranes, vbNewLine) = DialogResult.Yes Then
                        '                        AbrirAlbaran = False
                        '                        ExpertisApp.OpenForm("MNTOOT", New NumberFilterItem("IDOT", IDOT))
                        '                    End If
                        '                End If
                        '                If AbrirAlbaran Then
                        '                    TratarLog(rslt.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                        '                End If

                        '                Me.Cursor = Cursors.Default
                        '            Else
                        '                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '            End If
                        '        Else
                        '            TratarLog(Propuesta.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                        '        End If
                        '        Grid.UnCheckAllRecords()
                        '        Me.Execute()
                        '    Else
                        '        ExpertisApp.GenerateMessage("No se ha podido generar el Albarán.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        '    End If
                        'End If
                    ElseIf dtMarcados.Rows.Count = 0 Then
                        ExpertisApp.GenerateMessage("No hay líneas que cumplan las condiciones anteriormente mencionadas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    '    Else
                    '    Dim frm As New frmOrdenesSinContabilizar
                    '    frm.AbrirOrdenesSinContabilizar(dtMarcados)
                    'End If
                End If
            Else
                ExpertisApp.GenerateMessage("El Contador es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            ExpertisApp.GenerateMessage("Proceso cancelado. Es necesario asignar un Operario al Usuario.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub LiquidacionSinMovimiento()
        Expedir4(enumTipoExpedicion.Transferencia, False)
    End Sub

    Protected Overridable Sub Expedir4(ByVal tipo As enumTipoExpedicion, Optional ByVal blnTraspaso As Boolean = False)
        If Length(mIDOperario) > 0 Then
            If Length(AdvContador.Text) > 0 Then
                Dim dtMarcados As DataTable = Me.CheckedRecords
                If dtMarcados Is Nothing OrElse dtMarcados.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    'If Me.RecordsState = RecordsState.Modified Then Me.UpdateData()

                    'If ValidaFianzasObligatorias(dtMarcados.Copy) = 0 Then
                    Dim blnCancel As Boolean = False
                    Dim TraspasoInfo As New TraspasoMaquina.dataTraspasoMaquina
                    If blnTraspaso Then
                        TraspasoInfo = TratarTraspasoMaterial(dtMarcados.Copy)
                        blnCancel = TraspasoInfo Is Nothing
                    End If
                    'David Velasco 14/6/22
                    If Not blnCancel Then blnCancel = ValidaDatosAExpedir(dtMarcados, , tipo = enumTipoExpedicion.Retorno)
                    If Not blnCancel AndAlso dtMarcados.Rows.Count > 0 Then
                        Dim p As New Parametro
                        Dim IDTipoAlbaran As String = String.Empty
                        Select Case tipo
                            Case enumTipoExpedicion.Consumo
                                IDTipoAlbaran = p.TipoAlbaranDeConsumo
                                If blnTraspaso Then
                                    IDTipoAlbaran = p.TipoAlbaranRetornoAlquiler
                                End If
                            Case enumTipoExpedicion.Retorno
                                IDTipoAlbaran = p.TipoAlbaranRetornoAlquiler
                                Dim frm As New frmCondicionesAlquilerMasiva
                                frm.AbrirCondicionesAlquiler(dtMarcados.Copy)
                            Case enumTipoExpedicion.Transferencia
                                IDTipoAlbaran = p.TipoAlbaranRetornoAlquiler
                                Dim frm As New frmCondicionesAlquilerMasiva
                                frm.AbrirCondicionesAlquiler(dtMarcados.Copy)
                                Dim frmAC3 As New frmDatosAuxExpedicion
                                Dim d3 As frmDatosAuxExpedicion.DatosContadorConductor
                                d3 = frmAC3.AbrirFormulario(dtMarcados.Copy, False, True, tipo = enumTipoExpedicion.Consumo, , blnTraspaso)
                                If d3.Ok = DialogResult.OK Then
                                    Dim dtContadores As DataTable = d3.dtContadores

                                    Dim aExpedir() As CrearAlbaranVentaInfo = DatosAExpedir(dtMarcados, blnTraspaso, TraspasoInfo.FechaRetorno, _
                                                                                            TraspasoInfo.HoraRetorno, , d3.dtEstadoActivo)
                                    Me.Cursor = Cursors.WaitCursor

                                    Dim data As New DataPrcAlbaranar(aExpedir, AdvContador.Text, , IDTipoAlbaran, Business.BusinessEnum.enumTipoExpedicion.teAlquiler)
                                    Dim Propuesta As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                                    If Not IsNothing(Propuesta) Then
                                        If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                                            Dim frm2 As New frmAlbaranProvisional
                                            Dim dr As DialogResult = frm2.AbrirFormulario(Propuesta.PropuestaAlbaranes)
                                            If dr = DialogResult.OK Then
                                                Me.Cursor = Cursors.WaitCursor
                                                Dim datosAct As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                                                datosAct.Contadores = dtContadores
                                                datosAct.Avisos = dtMarcados.Copy
                                                datosAct.Retornos = False

                                                Dim rslt As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquilerSinStock), datosAct)
                                                MsgBox("Se ha generado el vencimiento correctamente.", MsgBoxStyle.OkOnly)
                                                Me.Cursor = Cursors.Default
                                                '2ª PARTE- hacer el movimiento de un almacen a otro.
                                                'If blnTraspaso Then
                                                '    TraspasoInfo.dtRetornos = dtMarcados
                                                '    Dim rsltTraspaso As ResultAlbaranAlquiler = GenerarTraspaso(TraspasoInfo)
                                                '    rslt = UnirResults(rslt, rsltTraspaso)
                                                'ElseIf Not rslt.StockUpdateData Is Nothing AndAlso rslt.StockUpdateData.Length > 0 Then
                                                '    Dim frmStock As New DetalleActualizacionStock
                                                '    frmStock.DataSource = rslt.StockUpdateData
                                                '    frmStock.ShowDialog()
                                                'End If
                                            Else
                                                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            End If
                                        Else
                                            TratarLog(Propuesta.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                                        End If
                                        Grid.UnCheckAllRecords()
                                        Me.Execute()
                                        Me.Cursor = Cursors.Default
                                    Else
                                        ExpertisApp.GenerateMessage("No se ha podido generar el Albarán.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    End If
                                    Exit Sub
                                End If
                        End Select

                        Dim frmAC As New frmDatosAuxExpedicion
                        Dim d As frmDatosAuxExpedicion.DatosContadorConductor
                        d = frmAC.AbrirFormulario(dtMarcados.Copy, False, True, tipo = enumTipoExpedicion.Consumo, , blnTraspaso)
                        If d.Ok = DialogResult.OK Then
                            Dim dtContadores As DataTable = d.dtContadores

                            Dim aExpedir() As CrearAlbaranVentaInfo = DatosAExpedir(dtMarcados, blnTraspaso, TraspasoInfo.FechaRetorno, _
                                                                                    TraspasoInfo.HoraRetorno, , d.dtEstadoActivo)
                            Me.Cursor = Cursors.WaitCursor

                            Dim data As New DataPrcAlbaranar(aExpedir, AdvContador.Text, , IDTipoAlbaran, Business.BusinessEnum.enumTipoExpedicion.teAlquiler)
                            Dim Propuesta As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                            If Not IsNothing(Propuesta) Then
                                If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                                    Dim frm As New frmAlbaranProvisional
                                    Dim dr As DialogResult = frm.AbrirFormulario(Propuesta.PropuestaAlbaranes)
                                    If dr = DialogResult.OK Then
                                        Me.Cursor = Cursors.WaitCursor
                                        Dim datosAct As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                                        datosAct.Contadores = dtContadores
                                        datosAct.Avisos = dtMarcados.Copy
                                        datosAct.Retornos = True

                                        Dim rslt As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquiler), datosAct)

                                        If blnTraspaso Then
                                            TraspasoInfo.dtRetornos = dtMarcados
                                            Dim rsltTraspaso As ResultAlbaranAlquiler = GenerarTraspaso(TraspasoInfo)
                                            rslt = UnirResults(rslt, rsltTraspaso)
                                        ElseIf Not rslt.StockUpdateData Is Nothing AndAlso rslt.StockUpdateData.Length > 0 Then
                                            Dim frmStock As New DetalleActualizacionStock
                                            frmStock.DataSource = rslt.StockUpdateData
                                            frmStock.ShowDialog()
                                        End If

                                        Me.UnCheckAllRecords()

                                        Dim Albaranes() As Integer = AlbaranesGenerados(rslt.CreateData)
                                        Dim IDAlbaran(Albaranes.Length - 1) As Object
                                        Albaranes.CopyTo(IDAlbaran, 0)

                                        Dim AbrirAlbaran As Boolean = True

                                        Dim dtOT As DataTable = New MntoOT().Filter(New InListFilterItem("IDAlbaranRetorno", IDAlbaran, FilterType.Numeric), , "IDOT,NROT")
                                        If Not dtOT Is Nothing AndAlso dtOT.Rows.Count > 0 Then
                                            Dim NROTs As String = String.Empty
                                            Dim IDOT As Integer = dtOT.Rows(0)("IDOT")
                                            For Each drOT As DataRow In dtOT.Rows
                                                If Len(NROTs) > 0 Then NROTs = NROTs & " ,"
                                                NROTs = NROTs & drOT("NROT")
                                            Next

                                            Dim NAlbaranes As String = ListadoAlbaranesGenerados(rslt.CreateData)
                                            If ExpertisApp.GenerateMessage("Se han generado las Ordenes de Trabajo: |.|Se han generado los Albaranes : |.|¿Desea abrir el mantenimiento de las Ordenes de Trabajo?,", MessageBoxButtons.YesNo, MessageBoxIcon.Information, NROTs, vbNewLine, NAlbaranes, vbNewLine) = DialogResult.Yes Then
                                                AbrirAlbaran = False
                                                ExpertisApp.OpenForm("MNTOOT", New NumberFilterItem("IDOT", IDOT))
                                            End If
                                        End If
                                        If AbrirAlbaran Then
                                            TratarLog(rslt.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                                        End If

                                        Me.Cursor = Cursors.Default
                                    Else
                                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                Else
                                    TratarLog(Propuesta.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                                End If
                                Grid.UnCheckAllRecords()
                                Me.Execute()
                            Else
                                ExpertisApp.GenerateMessage("No se ha podido generar el Albarán.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                    ElseIf dtMarcados.Rows.Count = 0 Then
                        ExpertisApp.GenerateMessage("No hay líneas que cumplan las condiciones anteriormente mencionadas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    '    Else
                    '    Dim frm As New frmOrdenesSinContabilizar
                    '    frm.AbrirOrdenesSinContabilizar(dtMarcados)
                    'End If
                End If
            Else
                ExpertisApp.GenerateMessage("El Contador es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            ExpertisApp.GenerateMessage("Proceso cancelado. Es necesario asignar un Operario al Usuario.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    'Fin David

    Protected Function GenerarTraspaso(ByVal datosTraspaso As TraspasoMaquina.dataTraspasoMaquina) As ResultAlbaranAlquiler
        If datosTraspaso.IDObraDestino > 0 Then
            If Not IsNothing(datosTraspaso.dtObraMaterial) AndAlso datosTraspaso.dtObraMaterial.Rows.Count > 0 Then
                Dim dtOT As DataTable = ExpertisApp.ExecuteTask(Of TraspasoMaquina.dataTraspasoMaquina, DataTable)(AddressOf TraspasoMaquina.GenerarTraspasoMaquina, datosTraspaso)
                If Not IsNothing(dtOT) AndAlso dtOT.Rows.Count > 0 Then
                    Return GenerarAlbaranDesdeTraspaso(datosTraspaso, dtOT)
                End If
            End If
        End If

        Return Nothing
    End Function

    Public Function GenerarAlbaranDesdeTraspaso(ByVal datosTraspaso As TraspasoMaquina.dataTraspasoMaquina, ByVal dtOT As DataTable) As ResultAlbaranAlquiler
        Dim f_OR As New Filter(FilterUnionOperator.Or)
        For Each dr As DataRow In dtOT.Rows
            f_OR.Add(New NumberFilterItem("IDTrabajo", dr("IDTrabajo")))
        Next
        Dim dtOM As DataTable = New ObraMaterial().Filter(f_OR)
        If Not IsNothing(dtOM) AndAlso dtOM.Rows.Count > 0 Then
            Dim IDLineaMaterial(-1) As Object
            For Each dr As DataRow In dtOM.Rows
                ReDim Preserve IDLineaMaterial(UBound(IDLineaMaterial) + 1)
                IDLineaMaterial(UBound(IDLineaMaterial)) = dr("IDLineaMaterial")
            Next

            If IDLineaMaterial.Length > 0 Then
                Dim f As New Filter
                f.Add(New InListFilterItem("IDLineaMaterial", IDLineaMaterial, FilterType.Numeric))
                f.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, 1))
                Dim dtMarcados As DataTable = New BE.DataEngine().Filter("vAlquilerCIExpedirMateriales", f)
                If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim aExpedir() As CrearAlbaranVentaInfo= DatosAExpedirTraspaso(dtMarcados.Copy, datosTraspaso.FechaRetorno, datosTraspaso.HoraRetorno)
                    Dim data As New DataPrcAlbaranar(aExpedir, AdvContador.Text, , mstrALBARANDEPOSITO, Business.BusinessEnum.enumTipoExpedicion.teAlquiler)
                    Dim Propuesta As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                    If Not IsNothing(Propuesta) Then
                        If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                            Dim frm As New frmAlbaranProvisional
                            Dim dr As DialogResult = frm.AbrirFormulario(Propuesta.PropuestaAlbaranes)
                            If dr = DialogResult.OK Then
                                Dim datosAct As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                                Return New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquiler), datosAct)
                            Else
                                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    End If
                End If
            End If
        End If

        Return Nothing
    End Function

    Private Function DatosAExpedirTraspaso(ByRef dtMarcados As DataTable, ByVal dtmFecha As Date, ByVal strHora As String) As CrearAlbaranVentaInfo()
        Dim aExpedir(-1) As CrearAlbaranVentaInfo


        For Each drMarcados As DataRow In dtMarcados.Select
            Dim datosExp As New CrearAlbaranVentaInfo
            datosExp.IDLinea = drMarcados("IDLineaMaterial")
            datosExp.IDLineaMaterial = drMarcados("IDLineaMaterial")
            datosExp.Cantidad = drMarcados("QAlbaran")
            datosExp.IDCliente = drMarcados("IDCliente")
            datosExp.FechaAlquiler = dtmFecha
            datosExp.HoraAlquiler = strHora

            If Nz(drMarcados("NSerieObligatorio"), False) And Length(drMarcados("Serie")) > 0 Then
                If drMarcados("TipoFactAlquiler") = enumTipoFacturacionAlquiler.enumTFASinAlquiler Then
                    datosExp.IDEstadoActivo = NegocioGeneral.ESTADOACTIVO_VENDIDO
                Else
                    datosExp.IDEstadoActivo = NegocioGeneral.ESTADOACTIVO_TRABAJANDO
                End If
            End If

            ReDim Preserve aExpedir(UBound(aExpedir) + 1)
            aExpedir(UBound(aExpedir)) = datosExp
        Next

        Return aExpedir
    End Function

#End Region

#Region " Cambio Maquina "

    Private Sub CambioMaquina()
        If Length(AdvContador.Text) > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            If dtMarcados Is Nothing OrElse dtMarcados.Rows.Count = 0 Then
                ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Me.RecordsState = RecordsState.Modified Then Me.UpdateData()
                Dim p As New Parametro
                Dim strTipoAlbaranSalida As String = p.TipoAlbaranDeDeposito
                Dim strTipoAlbaranRetorno As String = p.TipoAlbaranRetornoAlquiler

                Dim blnCancel As Boolean

                DatosAExpedir(dtMarcados, blnCancel)

                If Not blnCancel Then
                    Dim adrSinNumSerie() As DataRow = dtMarcados.Select("Lote IS NULL", Nothing)
                    If Not adrSinNumSerie Is Nothing AndAlso adrSinNumSerie.Length > 0 Then
                        ExpertisApp.GenerateMessage("Existen Máquinas sin Número de Serie. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Dim frmDatos1 As New frmDatosAuxCambioMaquina1
                        Dim dMaquina1 As New frmDatosAuxCambioMaquina1.DatosRetornoMaquina1
                        dMaquina1 = frmDatos1.AbrirFormulario(dtMarcados)

                        If dMaquina1.Ok = DialogResult.OK Then
                            Dim dtContadores As DataTable = dMaquina1.dtContadores
                            Dim dtIncidencias As DataTable = dMaquina1.dtIncidencias

                            Dim frmDatos2 As New frmDatosAuxCambioMaquina2
                            Dim dMaquina2 As frmDatosAuxCambioMaquina2.DatosRetornoMaquina2
                            dMaquina2 = frmDatos2.AbrirFormulario(dtMarcados, dMaquina1.dtmFecha, dMaquina1.strHora)

                            If dMaquina2.Ok = DialogResult.OK Then
                                If dMaquina2.dtmFecha < dMaquina1.dtmFecha Then
                                    ExpertisApp.GenerateMessage("La fecha introducida para la salida del activo que sustituye al averiado, es inferior a la marcada para el retorno de esta última.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Else
                                    '********************************************************************************
                                    'Generación del Albarán de Retorno
                                    '*******************************************************************************
                                    Dim dtContadores2 As DataTable = dMaquina2.dtContadores
                                    Dim dtConductores2 As DataTable = dMaquina2.dtConductores
                                    Dim dtADDObraMaterial As DataTable = dMaquina2.dtOMNew

                                    Dim dtActivos As DataTable = Nothing
                                    Dim aExpedirRetorno() As CrearAlbaranVentaInfo = DatosAExpedirCambioMaquina(dtMarcados, dMaquina1.dtmFecha, dMaquina1.strHora, dtActivos)
                                    If aExpedirRetorno.Length > 0 Then
                                        Me.Cursor = Cursors.WaitCursor

                                        Dim data As New DataPrcAlbaranar(aExpedirRetorno, AdvContador.Text, , strTipoAlbaranRetorno, Business.BusinessEnum.enumTipoExpedicion.teAlquiler)
                                        Dim Propuesta As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                                        If Not Propuesta Is Nothing Then
                                            If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                                                Dim frm As New frmAlbaranProvisional
                                                frm.Text = "Datos Provisionales del Albarán de Retorno"
                                                If frm.AbrirFormulario(Propuesta.PropuestaAlbaranes) = Windows.Forms.DialogResult.OK Then
                                                    Me.Cursor = Cursors.WaitCursor

                                                    Dim datosAct As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                                                    datosAct.CambioMaquina = True
                                                    datosAct.Contadores = dtContadores
                                                    datosAct.Incidencias = dtIncidencias
                                                    datosAct.Activos = dtActivos
                                                    datosAct.ADDObraMaterial = dtADDObraMaterial

                                                    Dim rslt As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquiler), datosAct)

                                                    dtADDObraMaterial = datosAct.ADDObraMaterial
                                                    ActualizarDatosAlbaranSalida(dtConductores2, dtContadores2, dtMarcados, dtADDObraMaterial)
                                                    '***********************************************************************************
                                                    'Generación del albarán de salida
                                                    '***********************************************************************************
                                                    blnCancel = ValidaDatosAExpedir(dtMarcados, True)
                                                    If Not blnCancel Then
                                                        Dim aExpedirSalida() As CrearAlbaranVentaInfo = DatosAExpedir(dtMarcados, False, dMaquina2.dtmFecha, dMaquina2.strHora, True)
                                                        If aExpedirSalida.Length > 0 Then
                                                            data = New DataPrcAlbaranar(aExpedirSalida, AdvContador.Text, , strTipoAlbaranRetorno, Business.BusinessEnum.enumTipoExpedicion.teAlquilerCambioMaquina)
                                                            Propuesta = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                                                            If Not Propuesta Is Nothing Then
                                                                If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                                                                    frm.Text = "Datos Provisionales del Albarán"
                                                                    If frm.AbrirFormulario(Propuesta.PropuestaAlbaranes) = DialogResult.OK Then
                                                                        Dim datosAct2 As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                                                                        datosAct2.Contadores = dtContadores2
                                                                        datosAct2.Conductores = dtConductores2

                                                                        Dim rslt2 As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquiler), datosAct2)
                                                                        rslt = UnirResults(rslt, rslt2)
                                                                    Else
                                                                        ExpertisApp.GenerateMessage("Albarán de Salida cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                    If rslt.CreateData.CreatedElements.Length > 0 Then
                                                        TratarLog(rslt.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                                                    End If
                                                Else
                                                    ExpertisApp.GenerateMessage("Proceso cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                End If

                                                Me.Cursor = Cursors.Default
                                                Me.UnCheckAllRecords()
                                                Me.Execute()
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                Else
                    ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("El Contador es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function DatosAExpedirCambioMaquina(ByRef dtMarcados As DataTable, ByVal dtmFecha As Date, _
                                                ByVal strHora As String, ByRef dtActivos As DataTable) As CrearAlbaranVentaInfo()

        Dim aExpedir(-1) As CrearAlbaranVentaInfo
        Dim datosExp As New CrearAlbaranVentaInfo

        Dim strEstadoActivo As String = New Parametro().EstadoMaquinaAveriada

        For Each drMarcados As DataRow In dtMarcados.Select
            datosExp.IDLinea = drMarcados("IDLineaAlbaran")
            datosExp.IDLineaMaterial = drMarcados("IDLineaMaterial")
            datosExp.Cantidad = drMarcados("CantidadMarca1")
            datosExp.IDCliente = drMarcados("IDCliente")

            If dtmFecha <> cnMinDate Then
                datosExp.FechaAlquiler = dtmFecha
            Else
                datosExp.FechaAlquiler = Date.Today
            End If
            If Length(strHora) > 0 Then
                datosExp.HoraAlquiler = strHora
            Else
                datosExp.HoraAlquiler = Date.Today.ToShortTimeString
            End If

            ReDim Preserve aExpedir(UBound(aExpedir) + 1)
            aExpedir(UBound(aExpedir)) = datosExp

            If Length(drMarcados("Lote")) > 0 Then
                CambioEstadoActivo(drMarcados("Lote"), strEstadoActivo, dtActivos)
            End If
        Next

        Return aExpedir
    End Function

    Private Sub CambioEstadoActivo(ByVal strIDActivo As String, ByVal strEstadoActivo As String, ByRef dtActivos As DataTable)
        Dim a As New Activo
        If IsNothing(dtActivos) Then dtActivos = a.AddNew
        Dim dt As DataTable = a.SelOnPrimaryKey(strIDActivo)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            dt.Rows(0)("IDEstadoActivo") = strEstadoActivo

            dtActivos.ImportRow(dt.Rows(0))
        End If
    End Sub

    Private Sub ActualizarDatosAlbaranSalida(ByRef dtConductores2 As DataTable, ByRef dtContadores2 As DataTable, _
                                             ByRef dtMarcados As DataTable, ByVal dtOMaterialNew As DataTable)

        Dim strWhere As String
        For Each drOMaterialNew As DataRow In dtOMaterialNew.Rows
            strWhere = "IDArticulo='" & drOMaterialNew("IDMaterial") & "' AND IDTrabajo= " & drOMaterialNew("IDTrabajo")
            If Not IsNothing(dtConductores2) AndAlso dtConductores2.Rows.Count > 0 Then
                Dim dvConductores2 As New DataView(dtConductores2.Copy)
                dvConductores2.RowFilter = strWhere
                If dvConductores2.Count > 0 Then
                    dvConductores2(0).Row("IDLineaMaterial") = drOMaterialNew("IDLineaMaterial")
                End If
                dvConductores2.RowFilter = String.Empty
            End If
            If Not IsNothing(dtContadores2) AndAlso dtContadores2.Rows.Count > 0 Then
                Dim dvContadores2 As New DataView(dtContadores2.Copy)
                dvContadores2.RowFilter = strWhere
                If dvContadores2.Count > 0 Then
                    dvContadores2(0).Row("IDLineaMaterial") = drOMaterialNew("IDLineaMaterial")
                End If
                dvContadores2.RowFilter = String.Empty
            End If

            If Not IsNothing(dtOMaterialNew) AndAlso dtOMaterialNew.Rows.Count > 0 Then
                Dim dvOMaterialNew As New DataView(dtMarcados)
                strWhere = "IDMaterial='" & drOMaterialNew("IDMaterial") & "' AND IDTrabajo= " & drOMaterialNew("IDTrabajo")
                dvOMaterialNew.RowFilter = strWhere
                If dvOMaterialNew.Count > 0 Then
                    dvOMaterialNew(0).Row("IDLineaMaterial") = drOMaterialNew("IDLineaMaterial")
                End If
                dvOMaterialNew.RowFilter = String.Empty
            End If
        Next
    End Sub

#End Region

    Private Sub RecalcularFechaRetorno()
        Dim dtMarcados As DataTable = Me.CheckedRecords
        If dtMarcados Is Nothing OrElse dtMarcados.Rows.Count = 0 Then
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.Cursor = Cursors.WaitCursor

            RecalculoFechaRetorno(dtMarcados, mstrALBARANDEPOSITO)

            Me.Cursor = Cursors.Default
            Grid.UnCheckAllRecords()
            Me.Execute()
        End If
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub VerAlquiler()
        AbrirMntoAlquiler(Grid.Value("IDObra"))
    End Sub

    Private Sub AccionAbrirOrdenServicio()
        AbrirOrdenServicio(Grid.Value("IDTrabajo"), Grid.Value("IDObra"))
    End Sub

    Private Sub VerAlbaran()
        AbrirMntoAlbaranVenta(Nz(Grid.Value("IDAlbaran"), 0))
    End Sub

#End Region

    Private Sub AdvContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvContador.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("Entidad", GetType(AlbaranVentaCabecera).Name))
    End Sub

    Private Sub AdvAlmacenDeposito_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvAlmacenDeposito.SetPredefinedFilter
        e.Filter.Add(New BooleanFilterItem("Deposito", True))
    End Sub

#Region " Execute Query "

    Private Sub CIRetornos_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If Length(AdvObraDesde.Value) = 0 And Length(AdvObraHasta.Value) = 0 And Length(cbxFechaDesde.Value) = 0 And Length(cbxFechaHasta.Value) = 0 And Length(cbxCGestion.Value) = 0 And _
            Length(AdvAlbaranDesde.Value) = 0 And Length(AdvAlbaranHasta.Value) = 0 And Length(AdvCliente.Value) = 0 And Length(AdvOServicio.Value) = 0 And Length(AdvLote.Text) = 0 Then
            If ExpertisApp.GenerateMessage("Se va a lanzar la consulta sin aplicar ningún filtro. Esto puede que retarde la obtención de información. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True
            End If
        Else
            e.Cancel = ValidarFiltros()
        End If

        If Not e.Cancel Then

            e.Filter.Add("IDTipo", FilterOperator.Equal, AdvTipo.Text, FilterType.String)
            e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvFamilia.Text, FilterType.String)
            e.Filter.Add("IDSubfamilia", FilterOperator.Equal, AdvSubfamilia.Text, FilterType.String)

            e.Filter.Add("IDCliente", FilterOperator.Equal, AdvCliente.Text, FilterType.String)
            e.Filter.Add("IDMaterial", FilterOperator.Equal, AdvArticulo.Text, FilterType.String)
            e.Filter.Add("Lote", FilterOperator.Equal, AdvLote.Text, FilterType.String)
            e.Filter.Add("IDAlmacenDeposito", FilterOperator.Equal, AdvAlmacenDeposito.Text, FilterType.String)
            e.Filter.Add("IDCentroGestion", FilterOperator.Equal, cbxCGestion.Value, FilterType.String)
            e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
            e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
            e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvOServicio.Value, FilterType.Numeric)
            e.Filter.Add("IDAlbaran", FilterOperator.GreaterThanOrEqual, AdvAlbaranDesde.Value, FilterType.Numeric)
            e.Filter.Add("IDAlbaran", FilterOperator.LessThanOrEqual, AdvAlbaranHasta.Value, FilterType.Numeric)
            e.Filter.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
            e.Filter.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
            e.Filter.Add("ARFechaAvisoRecogida", FilterOperator.GreaterThanOrEqual, cbxFechaAvisoDesde.Value, FilterType.DateTime)
            e.Filter.Add("ARFechaAvisoRecogida", FilterOperator.LessThanOrEqual, cbxFechaAvisoHasta.Value, FilterType.DateTime)
            e.Filter.Add("ARFechaPrevistaRetorno", FilterOperator.GreaterThanOrEqual, cbxFechaPrevistaDesde.Value, FilterType.DateTime)
            e.Filter.Add("ARFechaPrevistaRetorno", FilterOperator.LessThanOrEqual, cbxFechaPrevistaHasta.Value, FilterType.DateTime)
            If cbxConAvisoRetorno.Value <> enumBoolean.Todos Then
                e.Filter.Add("Aviso", FilterOperator.Equal, cbxConAvisoRetorno.Value, FilterType.Boolean)
            End If
            e.Filter.Add("ARNAlbaranRecogida", FilterOperator.Equal, txtNAlbaranRecogida.Text, FilterType.String)
            e.Filter.Add("TipoFactAlquiler", FilterOperator.NotEqual, CInt(enumTipoFacturacionAlquiler.enumTFASinAlquiler), FilterType.Numeric)
            e.Filter.Add("IDTipoAlbaran", FilterOperator.Equal, mstrALBARANDEPOSITO, FilterType.String)
        End If
    End Sub

    Private Function ValidarFiltros() As Boolean
        Dim strFiltrosCampos As String = String.Empty
        Dim blnCancel As Boolean

        If (Length(AdvObraDesde.Value) > 0 And Length(AdvObraHasta.Value) = 0) Or (Length(AdvObraDesde.Value) = 0 And Length(AdvObraHasta.Value) > 0) Then
            strFiltrosCampos = strFiltrosCampos & "Alquiler"
            blnCancel = True
        End If
        If (Length(cbxFechaDesde.Value) > 0 And Length(cbxFechaHasta.Value) = 0) Or (Length(cbxFechaDesde.Value) = 0 And Length(cbxFechaHasta.Value) > 0) Then
            If Len(strFiltrosCampos) > 0 Then strFiltrosCampos = strFiltrosCampos & ","
            strFiltrosCampos = strFiltrosCampos & "Fecha"
            blnCancel = True
        End If
        If (Length(AdvAlbaranDesde.Value) > 0 And Length(AdvAlbaranHasta.Value) = 0) Or (Length(AdvAlbaranDesde.Value) = 0 And Length(AdvAlbaranHasta.Value) > 0) Then
            If Len(strFiltrosCampos) > 0 Then strFiltrosCampos = strFiltrosCampos & ","
            strFiltrosCampos = strFiltrosCampos & "Albarán"
            blnCancel = True
        End If

        If blnCancel Then
            ExpertisApp.GenerateMessage("Para usar los filtros de '|' tienen que rellenarse tanto el 'Desde' como el 'Hasta'.", MessageBoxButtons.OK, MessageBoxIcon.Information, strFiltrosCampos)
        End If

        Return blnCancel
    End Function

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)

        InitFilterCriteria()
    End Sub

#End Region

#Region " Grid "

    Private Sub CIRetornos_CheckingRecord(ByVal sender As Object, ByVal e As Engine.UI.CheckingEventArgs) Handles MyBase.CheckingRecord
        Dim blnCancelCheck As Boolean= False
        With Grid
            If e.CheckState = CheckStates.UnChecked Then
                If Length(cbxFecha.Value) > 0 AndAlso IsDate(cbxFecha.Value) Then
                    If cbxFecha.Value > Nz(.Value("FechaMaxima"), cnMinDate) Or Length(.Value("FechaMaxima")) = 0 Then
                        e.Row.Cells("FechaAlquiler").Value = cbxFecha.Value
                        e.Row.Cells("FechaDevolucion").Value = cbxFecha.Value
                        If Length(cbxHora.Text) > 0 Then
                            e.Row.Cells("HoraAlquiler").Value = cbxHora.Text
                        Else
                            e.Row.Cells("HoraAlquiler").Value = Date.Today.ToShortTimeString
                        End If
                    Else
                        e.Row.Cells("FechaAlquiler").Value = System.DBNull.Value
                        e.Row.Cells("HoraAlquiler").Value = System.DBNull.Value
                        e.Row.Cells("FechaDevolucion").Value = System.DBNull.Value
                        blnCancelCheck = True
                    End If
                Else
                    If Date.Today > Nz(.Value("FechaMaxima"), cnMinDate) Or Length(.Value("FechaMaxima")) = 0 Then
                        e.Row.Cells("FechaAlquiler").Value = Date.Today
                        e.Row.Cells("FechaDevolucion").Value = Date.Today
                        If Length(cbxHora.Text) > 0 Then
                            e.Row.Cells("HoraAlquiler").Value = cbxHora.Text
                        Else
                            e.Row.Cells("HoraAlquiler").Value = Date.Today.ToShortTimeString
                        End If
                    Else
                        e.Row.Cells("FechaAlquiler").Value = System.DBNull.Value
                        e.Row.Cells("HoraAlquiler").Value = System.DBNull.Value
                        e.Row.Cells("FechaDevolucion").Value = System.DBNull.Value
                        blnCancelCheck = True
                    End If
                End If

                If Not e.Row.Cells("FacturarDiasMinimos").Value Then
                    e.Row.Cells("FechaRetornoDiasMinimos").Value = System.DBNull.Value
                    e.Row.Cells("NoFacturarDiasMinimos").Value = False
                End If
            Else
                e.Row.Cells("FechaAlquiler").Value = System.DBNull.Value
                e.Row.Cells("FechaDevolucion").Value = System.DBNull.Value
                e.Row.Cells("HoraAlquiler").Value = System.DBNull.Value
            End If
            If blnCancelCheck = True Then
                ExpertisApp.GenerateMessage("La Fecha de Alquiler debe ser superior a la Fecha del Último Vencimiento de la Línea. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                blnCancelCheck = False
            End If
        End With
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.Cells("Aviso").Value Then
            e.Row.RowStyle = Grid.FormatStyles("AvisoFormatStyle")
        End If
    End Sub

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        With Grid
            Select Case e.Column.Key
                Case "CantidadMarca1"
                    If Length(e.Value) > 0 Then
                        If IsNumeric(e.Value) Then
                            If CDbl(e.Value) > CDbl(.Value("QPendiente")) Then
                                ExpertisApp.GenerateMessage("La C. Devolución no puede ser superior a la C. Pendiente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                e.Cancel = True
                            End If
                        Else
                            e.Cancel = True
                            ExpertisApp.GenerateMessage("Campo no numérico.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            .Focus()
                        End If
                    End If
                Case "FechaAlquiler", "FechaDevolucion"
                    If e.Value < .Value("FechaAlbaran") Then
                        If e.Column.Key = "FechaDevolucion" Then
                            ExpertisApp.GenerateMessage("No es posible realizar el cambio. La Fecha de Devolución es inferior a la Fecha del Albarán de Envío asociado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else
                            ExpertisApp.GenerateMessage("No es posible realizar el cambio. La Fecha de Alquiler es inferior a la Fecha del Albarán de Envío asociado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                        e.Cancel = True
                    ElseIf e.Column.Key = "FechaAlquiler" Then
                        If Length(.Value("FechaAlquiler")) > 0 Then
                            If Length(.Value("FechaMaxima")) > 0 AndAlso e.Value <= .Value("FechaMaxima") Then
                                ExpertisApp.GenerateMessage("La Fecha de Alquiler debe ser superior a la Fecha del Último Vencimiento de la Línea. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                            Else
                                .Value("FechaDevolucion") = e.Value
                            End If
                        End If
                    End If
                Case "HoraAlquiler"
                    If Length(.Value("HoraAlquiler")) > 0 Then
                        If InStr(.Value("HoraAlquiler"), ":") = 0 Then
                            Dim tmHoraAlquiler As Date = .Value("HoraAlquiler") & ":0"
                            .Value("HoraAlquiler") = tmHoraAlquiler
                        End If
                    End If
            End Select
        End With
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Select Case e.Column.Key
            Case "NoFacturarDiasMinimos"
                If Not Grid.Value("FacturarDiasMinimos") Then
                    e.Cancel = True
                End If
        End Select
    End Sub

#End Region

    Private Sub CIRetornos_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles Me.BusinessCalling
        e.Cancel = True
    End Sub

    Private Sub AdvObraDesde_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvObraDesde.Leave
        AdvObraHasta.Text = AdvObraDesde.Text
    End Sub

    Private Sub AdvAlbaranDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvAlbaranDesde.TextChanged
        AdvAlbaranHasta.Text = AdvAlbaranDesde.Text
    End Sub

End Class