Imports Janus.Windows.UI
Public Class CIAvisos
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
    Friend WithEvents lblFwiAlbaranHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents PicTotales As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlParametrosRetorno As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblcbxFechaPrevista As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaPrevista As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents chkVolcarQPte As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents advObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbladvObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbladvObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advAlbaranDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbladvAlbaranDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advAlbaranHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbladvAlbaranHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advLote As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbladvLote As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advCodtrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbladvCodtrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIdCLiente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbladvIdCLiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDAlmacenDeposito As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbladvIDAlmacenDeposito As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbladvIDArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaPrevistaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblcbxFechaPrevistaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaPrevistaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblcbxFechaPrevistaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaAvisoHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblcbxFechaAvisoHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaAvisoDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblcbxFechaAvisoDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblcbxFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblcbxFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboConAvisoRetorno As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblcboConAvisoRetorno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboCGestion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblcboCGestion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblnbxQPendiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lbltxtNAlbaranRecogida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNAlbaranRecogida As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtPendiente As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboConAvisoRetorno_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIAvisos))
        Dim cboCGestion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.lbltxtNAlbaranRecogida = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNAlbaranRecogida = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cbxFechaPrevistaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblcbxFechaPrevistaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaPrevistaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblcbxFechaPrevistaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaAvisoHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblcbxFechaAvisoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaAvisoDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblcbxFechaAvisoDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cboConAvisoRetorno = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblcboConAvisoRetorno = New Solmicro.Expertis.Engine.UI.Label
        Me.advLote = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvLote = New Solmicro.Expertis.Engine.UI.Label
        Me.cboCGestion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblcboCGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.advCodtrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvCodtrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIdCLiente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvIdCLiente = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDAlmacenDeposito = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvIDAlmacenDeposito = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPendiente = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblnbxQPendiente = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvIDArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.advObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.advObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblcbxFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblcbxFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.advAlbaranDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbladvAlbaranDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.advAlbaranHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.PicTotales = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlParametrosRetorno = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblcbxFechaPrevista = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaPrevista = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.chkVolcarQPte = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lbladvAlbaranHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cboConAvisoRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlParametrosRetorno.suspendlayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lbladvAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.lbltxtNAlbaranRecogida)
        Me.FilterPanel.Controls.Add(Me.lblcbxFechaPrevistaHasta)
        Me.FilterPanel.Controls.Add(Me.lblcbxFechaPrevistaDesde)
        Me.FilterPanel.Controls.Add(Me.lblcbxFechaAvisoHasta)
        Me.FilterPanel.Controls.Add(Me.lblcbxFechaAvisoDesde)
        Me.FilterPanel.Controls.Add(Me.lblcboConAvisoRetorno)
        Me.FilterPanel.Controls.Add(Me.lbladvLote)
        Me.FilterPanel.Controls.Add(Me.lblcboCGestion)
        Me.FilterPanel.Controls.Add(Me.lbladvCodtrabajo)
        Me.FilterPanel.Controls.Add(Me.lbladvIdCLiente)
        Me.FilterPanel.Controls.Add(Me.lbladvIDAlmacenDeposito)
        Me.FilterPanel.Controls.Add(Me.lblnbxQPendiente)
        Me.FilterPanel.Controls.Add(Me.lbladvIDArticulo)
        Me.FilterPanel.Controls.Add(Me.lbladvObraDesde)
        Me.FilterPanel.Controls.Add(Me.lbladvObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblcbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblcbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lbladvAlbaranDesde)
        Me.FilterPanel.Controls.Add(Me.txtNAlbaranRecogida)
        Me.FilterPanel.Controls.Add(Me.cbxFechaPrevistaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaPrevistaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaAvisoHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaAvisoDesde)
        Me.FilterPanel.Controls.Add(Me.cboConAvisoRetorno)
        Me.FilterPanel.Controls.Add(Me.advLote)
        Me.FilterPanel.Controls.Add(Me.cboCGestion)
        Me.FilterPanel.Controls.Add(Me.advCodtrabajo)
        Me.FilterPanel.Controls.Add(Me.advIdCLiente)
        Me.FilterPanel.Controls.Add(Me.advIDAlmacenDeposito)
        Me.FilterPanel.Controls.Add(Me.txtPendiente)
        Me.FilterPanel.Controls.Add(Me.advIDArticulo)
        Me.FilterPanel.Controls.Add(Me.advObraDesde)
        Me.FilterPanel.Controls.Add(Me.advObraHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.advAlbaranDesde)
        Me.FilterPanel.Controls.Add(Me.advAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.PicTotales)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 263)
        Me.FilterPanel.Size = New System.Drawing.Size(784, 158)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.pnlParametrosRetorno)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(784, 263)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.pnlParametrosRetorno, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.Grid.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "C. Devolución", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "QPendiente"), New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarcaFecha2", "Fecha Prevista Retorno", Solmicro.Expertis.Engine.UI.CheckFieldType.DateTime, "")})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "AlbaranVentaLinea"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.FrozenColumns = 8
        Me.Grid.KeyField = "IDLineaAlbaran"
        Me.Grid.Location = New System.Drawing.Point(0, 32)
        Me.Grid.Size = New System.Drawing.Size(784, 231)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vAlquilerCIAvisosRetorno"
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
        Me.MainPanel.Size = New System.Drawing.Size(784, 421)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(784, 421)
        '
        'lbltxtNAlbaranRecogida
        '
        Me.lbltxtNAlbaranRecogida.Location = New System.Drawing.Point(568, 79)
        Me.lbltxtNAlbaranRecogida.Name = "lbltxtNAlbaranRecogida"
        Me.lbltxtNAlbaranRecogida.Size = New System.Drawing.Size(125, 13)
        Me.lbltxtNAlbaranRecogida.TabIndex = 0
        Me.lbltxtNAlbaranRecogida.Text = "Nº Albarán Recogida"
        '
        'txtNAlbaranRecogida
        '
        Me.txtNAlbaranRecogida.DisabledBackColor = System.Drawing.Color.White
        Me.txtNAlbaranRecogida.Location = New System.Drawing.Point(696, 75)
        Me.txtNAlbaranRecogida.Name = "txtNAlbaranRecogida"
        Me.txtNAlbaranRecogida.Size = New System.Drawing.Size(79, 21)
        Me.txtNAlbaranRecogida.TabIndex = 19
        '
        'cbxFechaPrevistaHasta
        '
        Me.cbxFechaPrevistaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaPrevistaHasta.Location = New System.Drawing.Point(267, 101)
        Me.cbxFechaPrevistaHasta.Name = "cbxFechaPrevistaHasta"
        Me.cbxFechaPrevistaHasta.Size = New System.Drawing.Size(94, 21)
        Me.cbxFechaPrevistaHasta.TabIndex = 9
        '
        'lblcbxFechaPrevistaHasta
        '
        Me.lblcbxFechaPrevistaHasta.Location = New System.Drawing.Point(214, 106)
        Me.lblcbxFechaPrevistaHasta.Name = "lblcbxFechaPrevistaHasta"
        Me.lblcbxFechaPrevistaHasta.Size = New System.Drawing.Size(48, 13)
        Me.lblcbxFechaPrevistaHasta.TabIndex = 24
        Me.lblcbxFechaPrevistaHasta.Text = "- Hasta"
        '
        'cbxFechaPrevistaDesde
        '
        Me.cbxFechaPrevistaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaPrevistaDesde.Location = New System.Drawing.Point(113, 101)
        Me.cbxFechaPrevistaDesde.Name = "cbxFechaPrevistaDesde"
        Me.cbxFechaPrevistaDesde.Size = New System.Drawing.Size(94, 21)
        Me.cbxFechaPrevistaDesde.TabIndex = 8
        '
        'lblcbxFechaPrevistaDesde
        '
        Me.lblcbxFechaPrevistaDesde.Location = New System.Drawing.Point(5, 105)
        Me.lblcbxFechaPrevistaDesde.Name = "lblcbxFechaPrevistaDesde"
        Me.lblcbxFechaPrevistaDesde.Size = New System.Drawing.Size(88, 13)
        Me.lblcbxFechaPrevistaDesde.TabIndex = 25
        Me.lblcbxFechaPrevistaDesde.Text = "F. Prev. Desde"
        '
        'cbxFechaAvisoHasta
        '
        Me.cbxFechaAvisoHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaAvisoHasta.Location = New System.Drawing.Point(267, 127)
        Me.cbxFechaAvisoHasta.Name = "cbxFechaAvisoHasta"
        Me.cbxFechaAvisoHasta.Size = New System.Drawing.Size(94, 21)
        Me.cbxFechaAvisoHasta.TabIndex = 11
        '
        'lblcbxFechaAvisoHasta
        '
        Me.lblcbxFechaAvisoHasta.Location = New System.Drawing.Point(214, 132)
        Me.lblcbxFechaAvisoHasta.Name = "lblcbxFechaAvisoHasta"
        Me.lblcbxFechaAvisoHasta.Size = New System.Drawing.Size(48, 13)
        Me.lblcbxFechaAvisoHasta.TabIndex = 26
        Me.lblcbxFechaAvisoHasta.Text = "- Hasta"
        '
        'cbxFechaAvisoDesde
        '
        Me.cbxFechaAvisoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaAvisoDesde.Location = New System.Drawing.Point(113, 127)
        Me.cbxFechaAvisoDesde.Name = "cbxFechaAvisoDesde"
        Me.cbxFechaAvisoDesde.Size = New System.Drawing.Size(94, 21)
        Me.cbxFechaAvisoDesde.TabIndex = 10
        '
        'lblcbxFechaAvisoDesde
        '
        Me.lblcbxFechaAvisoDesde.Location = New System.Drawing.Point(5, 131)
        Me.lblcbxFechaAvisoDesde.Name = "lblcbxFechaAvisoDesde"
        Me.lblcbxFechaAvisoDesde.Size = New System.Drawing.Size(90, 13)
        Me.lblcbxFechaAvisoDesde.TabIndex = 27
        Me.lblcbxFechaAvisoDesde.Text = "F. Aviso Desde"
        '
        'cboConAvisoRetorno
        '
        cboConAvisoRetorno_DesignTimeLayout.LayoutString = resources.GetString("cboConAvisoRetorno_DesignTimeLayout.LayoutString")
        Me.cboConAvisoRetorno.DesignTimeLayout = cboConAvisoRetorno_DesignTimeLayout
        Me.cboConAvisoRetorno.DisabledBackColor = System.Drawing.Color.White
        Me.cboConAvisoRetorno.Location = New System.Drawing.Point(696, 49)
        Me.cboConAvisoRetorno.Name = "cboConAvisoRetorno"
        Me.cboConAvisoRetorno.SelectedIndex = -1
        Me.cboConAvisoRetorno.SelectedItem = Nothing
        Me.cboConAvisoRetorno.Size = New System.Drawing.Size(79, 21)
        Me.cboConAvisoRetorno.TabIndex = 18
        '
        'lblcboConAvisoRetorno
        '
        Me.lblcboConAvisoRetorno.Location = New System.Drawing.Point(568, 53)
        Me.lblcboConAvisoRetorno.Name = "lblcboConAvisoRetorno"
        Me.lblcboConAvisoRetorno.Size = New System.Drawing.Size(114, 13)
        Me.lblcboConAvisoRetorno.TabIndex = 28
        Me.lblcboConAvisoRetorno.Text = "Con Aviso Retorno"
        '
        'advLote
        '
        Me.advLote.DisabledBackColor = System.Drawing.Color.White
        Me.advLote.EntityName = "ArticuloNSerie"
        Me.advLote.Location = New System.Drawing.Point(464, 127)
        Me.advLote.Name = "advLote"
        Me.advLote.PrimaryDataFields = "NSerie"
        Me.advLote.SecondaryDataFields = "NSerie"
        Me.advLote.Size = New System.Drawing.Size(94, 23)
        Me.advLote.TabIndex = 16
        Me.advLote.ViewName = "tbArticuloNSerie"
        '
        'lbladvLote
        '
        Me.lbladvLote.Location = New System.Drawing.Point(372, 132)
        Me.lbladvLote.Name = "lbladvLote"
        Me.lbladvLote.Size = New System.Drawing.Size(55, 13)
        Me.lbladvLote.TabIndex = 29
        Me.lbladvLote.Text = "Nº Serie"
        '
        'cboCGestion
        '
        cboCGestion_DesignTimeLayout.LayoutString = resources.GetString("cboCGestion_DesignTimeLayout.LayoutString")
        Me.cboCGestion.DesignTimeLayout = cboCGestion_DesignTimeLayout
        Me.cboCGestion.DisabledBackColor = System.Drawing.Color.White
        Me.cboCGestion.EntityName = "CentroGestion"
        Me.cboCGestion.Location = New System.Drawing.Point(696, 23)
        Me.cboCGestion.Name = "cboCGestion"
        Me.cboCGestion.PrimaryDataFields = "IDCentroGestion"
        Me.cboCGestion.SecondaryDataFields = "IDCentroGestion"
        Me.cboCGestion.SelectedIndex = -1
        Me.cboCGestion.SelectedItem = Nothing
        Me.cboCGestion.Size = New System.Drawing.Size(79, 21)
        Me.cboCGestion.TabIndex = 17
        Me.cboCGestion.ViewName = "tbMaestroCentroGestion"
        '
        'lblcboCGestion
        '
        Me.lblcboCGestion.Location = New System.Drawing.Point(568, 27)
        Me.lblcboCGestion.Name = "lblcboCGestion"
        Me.lblcboCGestion.Size = New System.Drawing.Size(93, 13)
        Me.lblcboCGestion.TabIndex = 31
        Me.lblcboCGestion.Text = "Centro Gestión"
        '
        'advCodtrabajo
        '
        Me.advCodtrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.advCodtrabajo.DisplayField = "CodTrabajo"
        Me.advCodtrabajo.EntityName = "ObraTrabajo"
        Me.advCodtrabajo.Location = New System.Drawing.Point(464, 23)
        Me.advCodtrabajo.Name = "advCodtrabajo"
        Me.advCodtrabajo.SecondaryDataFields = "IDTrabajo"
        Me.advCodtrabajo.Size = New System.Drawing.Size(94, 23)
        Me.advCodtrabajo.TabIndex = 12
        Me.advCodtrabajo.ViewName = "tbObraTrabajo"
        '
        'lbladvCodtrabajo
        '
        Me.lbladvCodtrabajo.Location = New System.Drawing.Point(372, 27)
        Me.lbladvCodtrabajo.Name = "lbladvCodtrabajo"
        Me.lbladvCodtrabajo.Size = New System.Drawing.Size(70, 13)
        Me.lbladvCodtrabajo.TabIndex = 32
        Me.lbladvCodtrabajo.Text = "O. Servicio"
        '
        'advIdCLiente
        '
        Me.advIdCLiente.DisabledBackColor = System.Drawing.Color.White
        Me.advIdCLiente.EntityName = "Cliente"
        Me.advIdCLiente.Location = New System.Drawing.Point(464, 49)
        Me.advIdCLiente.Name = "advIdCLiente"
        Me.advIdCLiente.PrimaryDataFields = "IDCliente"
        Me.advIdCLiente.SecondaryDataFields = "IDCliente"
        Me.advIdCLiente.Size = New System.Drawing.Size(94, 23)
        Me.advIdCLiente.TabIndex = 13
        Me.advIdCLiente.ViewName = "tbMaestroCliente"
        '
        'lbladvIdCLiente
        '
        Me.lbladvIdCLiente.Location = New System.Drawing.Point(372, 53)
        Me.lbladvIdCLiente.Name = "lbladvIdCLiente"
        Me.lbladvIdCLiente.Size = New System.Drawing.Size(47, 13)
        Me.lbladvIdCLiente.TabIndex = 34
        Me.lbladvIdCLiente.Text = "Cliente"
        '
        'advIDAlmacenDeposito
        '
        Me.advIDAlmacenDeposito.DisabledBackColor = System.Drawing.Color.White
        Me.advIDAlmacenDeposito.EntityName = "Almacen"
        Me.advIDAlmacenDeposito.Location = New System.Drawing.Point(464, 101)
        Me.advIDAlmacenDeposito.Name = "advIDAlmacenDeposito"
        Me.advIDAlmacenDeposito.PrimaryDataFields = "IDAlmacen"
        Me.advIDAlmacenDeposito.SecondaryDataFields = "IDAlmacen"
        Me.advIDAlmacenDeposito.Size = New System.Drawing.Size(94, 23)
        Me.advIDAlmacenDeposito.TabIndex = 15
        Me.advIDAlmacenDeposito.ViewName = "tbMaestroAlmacen"
        '
        'lbladvIDAlmacenDeposito
        '
        Me.lbladvIDAlmacenDeposito.Location = New System.Drawing.Point(372, 105)
        Me.lbladvIDAlmacenDeposito.Name = "lbladvIDAlmacenDeposito"
        Me.lbladvIDAlmacenDeposito.Size = New System.Drawing.Size(87, 13)
        Me.lbladvIDAlmacenDeposito.TabIndex = 36
        Me.lbladvIDAlmacenDeposito.Text = "Alm. Depósito"
        '
        'txtPendiente
        '
        Me.txtPendiente.DisabledBackColor = System.Drawing.Color.White
        Me.txtPendiente.Location = New System.Drawing.Point(696, 101)
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.Size = New System.Drawing.Size(79, 21)
        Me.txtPendiente.TabIndex = 20
        '
        'lblnbxQPendiente
        '
        Me.lblnbxQPendiente.Location = New System.Drawing.Point(568, 105)
        Me.lblnbxQPendiente.Name = "lblnbxQPendiente"
        Me.lblnbxQPendiente.Size = New System.Drawing.Size(102, 13)
        Me.lblnbxQPendiente.TabIndex = 38
        Me.lblnbxQPendiente.Text = "C. Pendiente >="
        '
        'advIDArticulo
        '
        Me.advIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticulo.EntityName = "Articulo"
        Me.advIDArticulo.Location = New System.Drawing.Point(464, 75)
        Me.advIDArticulo.Name = "advIDArticulo"
        Me.advIDArticulo.PrimaryDataFields = "IDArticulo"
        Me.advIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.advIDArticulo.Size = New System.Drawing.Size(94, 23)
        Me.advIDArticulo.TabIndex = 14
        Me.advIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'lbladvIDArticulo
        '
        Me.lbladvIDArticulo.Location = New System.Drawing.Point(372, 79)
        Me.lbladvIDArticulo.Name = "lbladvIDArticulo"
        Me.lbladvIDArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lbladvIDArticulo.TabIndex = 39
        Me.lbladvIDArticulo.Text = "Artículo"
        '
        'advObraDesde
        '
        Me.advObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advObraDesde.DisplayField = "NObra"
        Me.advObraDesde.EntityName = "ObraCabecera"
        Me.advObraDesde.Location = New System.Drawing.Point(113, 23)
        Me.advObraDesde.Name = "advObraDesde"
        Me.advObraDesde.SecondaryDataFields = "IDObra"
        Me.advObraDesde.Size = New System.Drawing.Size(94, 23)
        Me.advObraDesde.TabIndex = 2
        Me.advObraDesde.ViewName = "tbObraCabecera"
        '
        'lbladvObraDesde
        '
        Me.lbladvObraDesde.Location = New System.Drawing.Point(5, 27)
        Me.lbladvObraDesde.Name = "lbladvObraDesde"
        Me.lbladvObraDesde.Size = New System.Drawing.Size(90, 13)
        Me.lbladvObraDesde.TabIndex = 41
        Me.lbladvObraDesde.Text = "Alquiler Desde"
        '
        'advObraHasta
        '
        Me.advObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advObraHasta.DisplayField = "NObra"
        Me.advObraHasta.EntityName = "ObraCabecera"
        Me.advObraHasta.Location = New System.Drawing.Point(267, 23)
        Me.advObraHasta.Name = "advObraHasta"
        Me.advObraHasta.SecondaryDataFields = "IDObra"
        Me.advObraHasta.Size = New System.Drawing.Size(94, 23)
        Me.advObraHasta.TabIndex = 3
        Me.advObraHasta.ViewName = "tbObraCabecera"
        '
        'lbladvObraHasta
        '
        Me.lbladvObraHasta.Location = New System.Drawing.Point(214, 27)
        Me.lbladvObraHasta.Name = "lbladvObraHasta"
        Me.lbladvObraHasta.Size = New System.Drawing.Size(48, 13)
        Me.lbladvObraHasta.TabIndex = 43
        Me.lbladvObraHasta.Text = "- Hasta"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(113, 75)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(94, 21)
        Me.cbxFechaDesde.TabIndex = 6
        '
        'lblcbxFechaDesde
        '
        Me.lblcbxFechaDesde.Location = New System.Drawing.Point(5, 79)
        Me.lblcbxFechaDesde.Name = "lblcbxFechaDesde"
        Me.lblcbxFechaDesde.Size = New System.Drawing.Size(103, 13)
        Me.lblcbxFechaDesde.TabIndex = 45
        Me.lblcbxFechaDesde.Text = "F. Albarán Desde"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(267, 75)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(94, 21)
        Me.cbxFechaHasta.TabIndex = 7
        '
        'lblcbxFechaHasta
        '
        Me.lblcbxFechaHasta.Location = New System.Drawing.Point(214, 79)
        Me.lblcbxFechaHasta.Name = "lblcbxFechaHasta"
        Me.lblcbxFechaHasta.Size = New System.Drawing.Size(48, 13)
        Me.lblcbxFechaHasta.TabIndex = 46
        Me.lblcbxFechaHasta.Text = "- Hasta"
        '
        'advAlbaranDesde
        '
        Me.advAlbaranDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advAlbaranDesde.DisplayField = "NAlbaran"
        Me.advAlbaranDesde.EntityName = "AlbaranVentaCabecera"
        Me.advAlbaranDesde.Location = New System.Drawing.Point(113, 49)
        Me.advAlbaranDesde.Name = "advAlbaranDesde"
        Me.advAlbaranDesde.SecondaryDataFields = "IDAlbaran"
        Me.advAlbaranDesde.Size = New System.Drawing.Size(94, 23)
        Me.advAlbaranDesde.TabIndex = 4
        Me.advAlbaranDesde.ViewName = "tbAlbaranVentaCabecera"
        '
        'lbladvAlbaranDesde
        '
        Me.lbladvAlbaranDesde.Location = New System.Drawing.Point(5, 53)
        Me.lbladvAlbaranDesde.Name = "lbladvAlbaranDesde"
        Me.lbladvAlbaranDesde.Size = New System.Drawing.Size(91, 13)
        Me.lbladvAlbaranDesde.TabIndex = 47
        Me.lbladvAlbaranDesde.Text = "Albarán Desde"
        '
        'advAlbaranHasta
        '
        Me.advAlbaranHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advAlbaranHasta.DisplayField = "NAlbaran"
        Me.advAlbaranHasta.EntityName = "AlbaranVentaCabecera"
        Me.advAlbaranHasta.Location = New System.Drawing.Point(267, 49)
        Me.advAlbaranHasta.Name = "advAlbaranHasta"
        Me.advAlbaranHasta.SecondaryDataFields = "IDAlbaran"
        Me.advAlbaranHasta.Size = New System.Drawing.Size(94, 23)
        Me.advAlbaranHasta.TabIndex = 5
        Me.advAlbaranHasta.ViewName = "tbAlbaranVentaCabecera"
        '
        'PicTotales
        '
        Me.PicTotales.Location = New System.Drawing.Point(541, 348)
        Me.PicTotales.Name = "PicTotales"
        Me.PicTotales.Size = New System.Drawing.Size(164, 107)
        Me.PicTotales.TabIndex = 52
        '
        'pnlParametrosRetorno
        '
        Me.pnlParametrosRetorno.Controls.Add(Me.lblcbxFechaPrevista)
        Me.pnlParametrosRetorno.Controls.Add(Me.cbxFechaPrevista)
        Me.pnlParametrosRetorno.Controls.Add(Me.chkVolcarQPte)
        Me.pnlParametrosRetorno.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlParametrosRetorno.Location = New System.Drawing.Point(0, 0)
        Me.pnlParametrosRetorno.Name = "pnlParametrosRetorno"
        Me.pnlParametrosRetorno.Size = New System.Drawing.Size(784, 32)
        Me.pnlParametrosRetorno.TabIndex = 1
        '
        'lblcbxFechaPrevista
        '
        Me.lblcbxFechaPrevista.Location = New System.Drawing.Point(12, 10)
        Me.lblcbxFechaPrevista.Name = "lblcbxFechaPrevista"
        Me.lblcbxFechaPrevista.Size = New System.Drawing.Size(139, 13)
        Me.lblcbxFechaPrevista.TabIndex = 54
        Me.lblcbxFechaPrevista.Text = "Fecha Prevista Retorno"
        '
        'cbxFechaPrevista
        '
        Me.cbxFechaPrevista.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaPrevista.Location = New System.Drawing.Point(160, 6)
        Me.cbxFechaPrevista.Name = "cbxFechaPrevista"
        Me.cbxFechaPrevista.Size = New System.Drawing.Size(96, 21)
        Me.cbxFechaPrevista.TabIndex = 0
        '
        'chkVolcarQPte
        '
        Me.chkVolcarQPte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVolcarQPte.Location = New System.Drawing.Point(592, 6)
        Me.chkVolcarQPte.Name = "chkVolcarQPte"
        Me.chkVolcarQPte.Size = New System.Drawing.Size(184, 19)
        Me.chkVolcarQPte.TabIndex = 1
        Me.chkVolcarQPte.Text = "Volcar cantidad Pendiente"
        '
        'lbladvAlbaranHasta
        '
        Me.lbladvAlbaranHasta.Location = New System.Drawing.Point(214, 53)
        Me.lbladvAlbaranHasta.Name = "lbladvAlbaranHasta"
        Me.lbladvAlbaranHasta.Size = New System.Drawing.Size(48, 13)
        Me.lbladvAlbaranHasta.TabIndex = 53
        Me.lbladvAlbaranHasta.Text = "- Hasta"
        '
        'CIAvisos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "C. Devolución", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "QPendiente"), New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarcaFecha2", "Fecha Prevista Retorno", Solmicro.Expertis.Engine.UI.CheckFieldType.DateTime, "")})
        Me.ClientSize = New System.Drawing.Size(792, 509)
        Me.EntityName = "AlbaranVentaLinea"
        Me.KeyField = "IDLineaAlbaran"
        Me.Name = "CIAvisos"
        Me.UseCheck = True
        Me.ViewName = "vAlquilerCIAvisosRetorno"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cboConAvisoRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCGestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlParametrosRetorno.ResumeLayout(False)
        Me.pnlParametrosRetorno.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mobjLote As Lote
    Private mblnCalculando, mblnParticion, mblnAlmacenVacio, mblnFechaVacia As Boolean
    Private mTipoAlbaranDeposito, mstrCentroGestion As String

#Region " Load "

    Private Sub CIAvisos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadEnums()
            LoadToolbarActions()
            LoadGridActions()
            LoadDefaultValues()
            LoadFormParams()
        End If
    End Sub

    Private Sub LoadERPData()
        mTipoAlbaranDeposito = New Parametro().TipoAlbaranDeDeposito
    End Sub

    Private Sub LoadEnums()
        cboConAvisoRetorno.DataSource = New EnumData("enumBoolean")
        cboConAvisoRetorno.Value = enumBoolean.Todos
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Clear()
        Me.FormActions.Add("Preparar Aviso de Recogida", AddressOf AccionPrepararAvisoRecogida, ExpertisApp.GetIcon("document_attachment.ico"))
        Me.FormActions.Add("Eliminar Aviso de Recogida", AddressOf AccionEliminarAvisoRecogida, ExpertisApp.GetIcon("garbage.ico"))
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Clear()
        Me.Grid.AddSeparator()
        Me.Grid.Actions.Add(cnABRIRALBARANVENTA, AddressOf AccionAbrirAlbaranVenta, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
        Me.Grid.Actions.Add(cnABRIRALQUILER, AddressOf AccionAbrirAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
        Me.Grid.Actions.Add("Abrir Informe", AddressOf AccionGridAbrirInforme, ExpertisApp.GetIcon("printer.ico"))
    End Sub

    Private Sub InitFilterCriteria()
        txtPendiente.Value = 1
        cboConAvisoRetorno.Value = enumBoolean.Todos
        cboCGestion.Value = mstrCentroGestion
    End Sub

    Private Sub LoadDefaultValues()
        Dim CentroGestionInfo As New UsuarioCentroGestion.UsuarioCentroGestionInfo
        ExpertisApp.ExecuteTask(Of UsuarioCentroGestion.UsuarioCentroGestionInfo, UsuarioCentroGestion.UsuarioCentroGestionInfo)(AddressOf UsuarioCentroGestion.ObtenerUsuarioCentroGestion, CentroGestionInfo)
        mstrCentroGestion = CentroGestionInfo.IDCentroGestion
        cboCGestion.Value = CentroGestionInfo.IDCentroGestion

        InitFilterCriteria()
    End Sub

    Private Sub LoadFormParams()
        If Not IsNothing(Me.Params) AndAlso CType(Me.Params, Hashtable).Count > 0 Then
            If Length(Me.Params("IDObra")) > 0 Then
                advObraDesde.Text = Me.Params("NObra")
                advObraDesde.Value = Me.Params("IDObra")
                advObraHasta.Text = Me.Params("NObra")
                advObraHasta.Value = Me.Params("IDObra")
                If Length(Me.Params("CodTrabajo")) > 0 Then
                    advCodtrabajo.Value = Me.Params("IDTrabajo")
                    advCodtrabajo.Text = Me.Params("CodTrabajo")
                End If
                Me.Execute()
            End If
        End If
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub AccionEliminarAvisoRecogida()
        Dim IDOperario As String = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf Operario.ObtenerIDOperarioUsuario, Nothing)
        If Length(IDOperario) = 0 Then
            ExpertisApp.GenerateMessage("El Operario es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Grid.CheckedRecordsCount Then
            Dim dtGrid As DataTable = Grid.CheckedRecords
            If ExpertisApp.GenerateMessage("Se borrarán los campos relacionados con el Aviso de Retorno. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                Dim IDLineaAlbaran(-1) As Object
                For Each drOM As DataRow In dtGrid.Select
                    ReDim Preserve IDLineaAlbaran(UBound(IDLineaAlbaran) + 1)
                    IDLineaAlbaran(UBound(IDLineaAlbaran)) = drOM("IDLineaAlbaran")
                Next
                Dim data As New AvisoRetorno.dataBorrarAvisoRetorno(IDLineaAlbaran, IDOperario)
                ExpertisApp.ExecuteTask(Of AvisoRetorno.dataBorrarAvisoRetorno)(AddressOf AvisoRetorno.BorrarAvisoRetorno, data)

                Me.Cursor = Cursors.Default
            End If
            UnCheckAllRecords()
            Me.Execute()
        Else
            ExpertisApp.GenerateMessage("No hay registros marcados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub AccionPrepararAvisoRecogida()
        If Grid.CheckedRecordsCount Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            Dim IDObra As Integer = dtMarcados.Rows(0)("IDObra")
            Dim IDCentroGestion As String = dtMarcados.Rows(0)("IDCentroGestion")

            For Each dr As DataRow In dtMarcados.Rows
                If IDObra <> dr("IDObra") Then
                    ExpertisApp.GenerateMessage("Las líneas seleccionadas no pertenecen al mismo Alquiler. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf IDCentroGestion <> dr("IDCentroGestion") Then
                    ExpertisApp.GenerateMessage("Las líneas seleccionadas no pertenecen al mismo Centro de Gestión. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf Length(dr("CantidadMarca1")) = 0 Then
                    ExpertisApp.GenerateMessage("Hay líneas sin introducir su cantidad. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf Length(dr("FechaAlquiler")) = 0 Then
                    ExpertisApp.GenerateMessage("Hay líneas sin fecha de aviso de recogida. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Next

            Dim dtFecha As Date
            If Length(cbxFechaPrevista.Value) > 0 Then
                dtFecha = cbxFechaPrevista.Value
            Else
                For Each dr As DataRow In dtMarcados.Rows
                    If Length(dr("FechaAlquiler")) > 0 Then
                        dtFecha = dr("FechaAlquiler")
                        Exit For
                    End If
                Next
            End If
            Dim frm As New frmDatosAviso
            If frm.AbrirFormMaquinas(dtMarcados, chkVolcarQPte.Checked, dtFecha) = DialogResult.OK Then
                Dim oReport As New Report("IMPRETORNO")
                oReport.DataSource = dtMarcados
                ExpertisApp.OpenReport(oReport)
            End If

            UnCheckAllRecords()
            Me.Execute()
        Else
            ExpertisApp.GenerateMessage("No hay registros marcados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region " Grid Actins "

    Private Sub AccionAbrirAlbaranVenta()
        AbrirMntoAlbaranVenta(Grid.Value("IDAlbaran"))
    End Sub

    Private Sub AccionAbrirAlquiler()
        AbrirMntoAlquiler(Grid.Value("IDObra"))
    End Sub

    Private Sub AccionGridAbrirInforme()
        If Grid.CheckedRecordsCount Then
            'Dim FiltroReport As New Filter
            'Dim Values(-1) As Object
            Dim dtGrid As DataTable = Grid.CheckedRecords

            Dim lngIDObra As Integer = dtGrid.Rows(0)("IDObra")
            Dim strIDCentroGestion As String = dtGrid.Rows(0)("IDCentroGestion")

            For Each dr As DataRow In dtGrid.Rows
                If lngIDObra <> dr("IDObra") Then
                    ExpertisApp.GenerateMessage("Las líneas seleccionadas no pertenecen a la misma obra. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf strIDCentroGestion <> dr("IDCentroGestion") Then
                    ExpertisApp.GenerateMessage("Las líneas seleccionadas no pertenecen al mismo centro de gestión. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf Length(dr("CantidadMarca1")) = 0 Then
                    ExpertisApp.GenerateMessage("Hay líneas sin introducir su cantidad. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf Length(dr("FechaAlquiler")) = 0 Then
                    ExpertisApp.GenerateMessage("Hay líneas sin fecha de aviso de recogida. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                'ReDim Preserve Values(UBound(Values) + 1)
                'Values(UBound(Values)) = dr("IDLineaAlbaran")
            Next

            'If Values.Length > 0 Then
            'FiltroReport.Add(New InListFilterItem("IDLineaAlbaran", Values, FilterType.Numeric))
            Dim oReport As New Report("IMPRETORNO")
            'oReport.RecordSelectionFormula = FiltroReport.Compose(New CrystalFilterComposer(oReport.Alias))
            oReport.DataSource = dtGrid
            ExpertisApp.OpenReport(oReport)
            'End If
            UnCheckAllRecords()
        Else
            ExpertisApp.GenerateMessage("No hay registros marcados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region " Grid "

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Select Case e.Column.Key
            Case "CantidadMarca1"
                If Length(e.Value) > 0 AndAlso IsNumeric(e.Value) Then
                    If e.Value > Grid.Value("QPendiente") Then
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("La C. Devolución no puede ser superior a la C. Pendiente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        With Grid
            Select Case e.Column.Key
                Case "NoFacturarDiasMinimos"
                    If Not .Value("FacturarDiasMinimos") Then
                        e.Cancel = True
                    End If
            End Select
        End With
    End Sub

    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(Grid) AndAlso Grid.RowCount > 0 Then
                Grid.UiCommandManager1.Commands(cnABRIRALBARANVENTA).Visible = InheritableBoolean.False
                Grid.UiCommandManager1.Commands(cnABRIRALQUILER).Visible = InheritableBoolean.False
                If Length(Grid.Value("IDAlbaran")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIRALBARANVENTA).Visible = InheritableBoolean.True
                End If
                If Length(Grid.Value("IDObra")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIRALQUILER).Visible = InheritableBoolean.True
                End If
            End If
        End If
    End Sub

#End Region

#Region " Execute Query "

    Private Sub CIAvisos_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        Dim blnFiltrar As Boolean = False
        If Length(advObraDesde.Value) = 0 AndAlso Length(advObraHasta.Value) = 0 AndAlso _
           Length(cbxFechaDesde.Value) = 0 AndAlso Length(cbxFechaHasta.Value) = 0 AndAlso _
           Length(advAlbaranDesde.Value) = 0 AndAlso Length(advAlbaranHasta.Value) = 0 AndAlso _
           Length(advIDAlmacenDeposito.Text) = 0 AndAlso Length(advLote.Text) = 0 AndAlso _
           Length(cbxFechaAvisoDesde.Value) = 0 AndAlso Length(cbxFechaAvisoHasta.Value) = 0 AndAlso _
           Length(advIdCLiente.Text) = 0 AndAlso Length(advCodtrabajo.Value) = 0 AndAlso _
           Length(advIDArticulo.Text) = 0 AndAlso Length(txtNAlbaranRecogida.Text) = 0 AndAlso _
           Length(cbxFechaPrevistaDesde.Value) = 0 AndAlso Length(cbxFechaPrevistaHasta.Value) = 0 Then
            Dim strMensaje As String = "Se va a lanzar la consulta sin aplicar ningún filtro. " & _
                                       "Esto puede que retarde la obtención de información. ¿Desea continuar?"
            If ExpertisApp.GenerateMessage(strMensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                blnFiltrar = True
            End If
        Else
            blnFiltrar = True
        End If

        If blnFiltrar Then
            e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, advObraDesde.Value, FilterType.Numeric)
            e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, advObraHasta.Value, FilterType.Numeric)
            e.Filter.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
            e.Filter.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
            e.Filter.Add("IDAlbaran", FilterOperator.GreaterThanOrEqual, advAlbaranDesde.Value, FilterType.Numeric)
            e.Filter.Add("IDAlbaran", FilterOperator.LessThanOrEqual, advAlbaranHasta.Value, FilterType.Numeric)
            e.Filter.Add("IDAlmacenDeposito", FilterOperator.Equal, advIDAlmacenDeposito.Text, FilterType.String)
            e.Filter.Add("Lote", FilterOperator.Equal, advLote.Text, FilterType.String) '//Nº Máquina
            e.Filter.Add("ARFechaAvisoRecogida", FilterOperator.GreaterThanOrEqual, cbxFechaAvisoDesde.Value, FilterType.DateTime)
            e.Filter.Add("ARFechaAvisoRecogida", FilterOperator.LessThanOrEqual, cbxFechaAvisoHasta.Value, FilterType.DateTime)
            e.Filter.Add("IDTrabajo", FilterOperator.Equal, advCodtrabajo.Value, FilterType.Numeric)
            e.Filter.Add("IDCliente", FilterOperator.Equal, advIdCLiente.Text, FilterType.String)
            e.Filter.Add("IDArticulo", FilterOperator.Equal, advIDArticulo.Text, FilterType.String)
            e.Filter.Add("QPendiente", FilterOperator.GreaterThanOrEqual, txtPendiente.Value, FilterType.Numeric)
            e.Filter.Add("ARFechaPrevistaRetorno", FilterOperator.GreaterThanOrEqual, cbxFechaPrevistaDesde.Value, FilterType.DateTime)
            e.Filter.Add("ARFechaPrevistaRetorno", FilterOperator.LessThanOrEqual, cbxFechaPrevistaHasta.Value, FilterType.DateTime)
            e.Filter.Add("IDCentroGestion", FilterOperator.Equal, cboCGestion.Value, FilterType.String)
            If cboConAvisoRetorno.Value <> enumBoolean.Todos Then
                e.Filter.Add("Aviso", FilterOperator.Equal, cboConAvisoRetorno.Value, FilterType.Boolean)
            End If
            e.Filter.Add("ARNalbaranRecogida", FilterOperator.Equal, txtNAlbaranRecogida.Text, FilterType.String)
            e.Filter.Add("IDTipoAlbaran", FilterOperator.Equal, mTipoAlbaranDeposito, FilterType.String)
            e.Filter.Add("TipoFactAlquiler", FilterOperator.NotEqual, enumTipoFacturacionAlquiler.enumTFASinAlquiler, FilterType.Numeric)
        Else
            e.Cancel = True
        End If
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)

        cbxFechaDesde.TextBox.Clear()
        cbxFechaHasta.TextBox.Clear()
        cbxFechaAvisoDesde.TextBox.Clear()
        cbxFechaAvisoHasta.TextBox.Clear()
        cbxFechaPrevistaDesde.TextBox.Clear()
        cbxFechaPrevistaHasta.TextBox.Clear()

        InitFilterCriteria()
    End Sub

#End Region

    Private Sub advIDAlmacenDeposito_SetPredefinedFilter(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advIDAlmacenDeposito.SetPredefinedFilter
        e.Filter.Add(New BooleanFilterItem("Deposito", enumBoolean.Si))
    End Sub

#Region " Reports "

    '    Private Function CriteriosConsultaCrystal(ByRef strFiltro As String, ByVal strReportName As String) As Long
    '        Dim FwCriterio As clsFilterCriteriaWrapper     'Objeto constructor del filtros
    '        Dim intCuentaArg As Integer
    '        On Error GoTo TratarError

    '        CriteriosConsultaCrystal = False

    '        strFiltro = vbNullString
    '        intCuentaArg = 0

    '        FwCriterio = New clsFilterCriteriaWrapper

    '        FwCriterio.Alias = strReportName

    '        With FwCriterio
    '            .Alias = strReportName

    '            .NumericoMayorIgual(FwiObraDesde.Value, "IdObra", strFiltro, intCuentaArg)
    '            .NumericoMenorIgual(FwiObraHasta.Value, "IdObra", strFiltro, intCuentaArg)
    '            .Texto(FwiIDArticulo.Value, "IDArticulo", strFiltro, intCuentaArg)
    '            .Texto(FwiIdCLiente.Value, "IDCliente", strFiltro, intCuentaArg)
    '            .NumericoMayorIgual(FwiAlbaranDesde.Value, "IdAlbaran", strFiltro, intCuentaArg)
    '            .NumericoMenorIgual(FwiAlbaranHasta.Value, "IdAlbaran", strFiltro, intCuentaArg)
    '            .FechaMayorIgual(FwiFechaDesde.Value, "FechaAlbaran", strFiltro, intCuentaArg)
    '            .FechaMenorIgual(FwiFechaHasta.Value, "FechaAlbaran", strFiltro, intCuentaArg)
    '            .Texto(mstrAlbDeposito, "IDTipoAlbaran", strFiltro, intCuentaArg)
    '            .Texto(FwiIDAlmacenDeposito.Value, "IDAlmacenDeposito", strFiltro, intCuentaArg)
    '            .NumericoMayorIgual(FwiQPendiente.Value, "QPendiente", strFiltro, intCuentaArg)
    '            .NumericoDistinto(enumTipoFacturacionAlquiler.enumTFASinAlquiler, "TipoFactAlquiler", strFiltro, intCuentaArg)
    '            .Texto(FwICodtrabajo.Value, "Codtrabajo", strFiltro, intCuentaArg)
    '            .Texto(FwICGestion.Value, "IdCentroGestion", strFiltro, intCuentaArg)
    '            .Texto(FwILote.Value, "lote", strFiltro, intCuentaArg)
    '            If FwiConAvisoRetorno.Value = enumBoolean.No Then
    '                .NumericoIgual(0, "Aviso", strFiltro, intCuentaArg)
    '            ElseIf FwiConAvisoRetorno.Value = enumBoolean.Si Then
    '                .NumericoIgual(1, "Aviso", strFiltro, intCuentaArg)
    '            End If
    '            .Texto(FwiNAlbaranRecogida.Value, "ARNalbaranRecogida", strFiltro, intCuentaArg)
    '            .FechaMayorIgual(FwiFechaAvisoDesde.Value, "ARFechaAvisoRecogida", strFiltro, intCuentaArg)
    '            .FechaMenorIgual(FwiFechaAvisoHasta.Value, "ARFechaAvisoRecogida", strFiltro, intCuentaArg)
    '            .FechaMayorIgual(FwiFechaPrevistaDesde.Value, "ARFechaPrevistaRetorno", strFiltro, intCuentaArg)
    '            .FechaMenorIgual(FwiFechaPrevistaHasta.Value, "ARFechaPrevistaRetorno", strFiltro, intCuentaArg)


    '        End With
    '        FwCriterio = Nothing


    '        CriteriosConsultaCrystal = True

    'Fin:
    '        On Error Resume Next
    '        FwCriterio = Nothing
    '        Exit Function
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Function

    '    Private Sub Me_SetReportSelectionCriteria() Handles MyBase.SetReportSelectionCriteria
    '        Dim strFiltro As String
    '        Dim strRestriccion As String

    '        Select Case strReportName
    '            Case "VGAMRptAlbaranRecogida"
    '                '            CriteriosConsultaCrystal strFiltro, strReportName
    '                '            strReportSelectionCriteria = strFiltro
    '        End Select

    '    End Sub

#End Region

#Region " Checkeo de los registros "

    Private Sub CIAvisos_CheckingRecord(ByVal sender As Object, ByVal e As Engine.UI.CheckingEventArgs) Handles MyBase.CheckingRecord
        If e.CheckState = CheckStates.UnChecked Then '//Si estamos marcando
            Dim dFechaPrevistaRetorno As Date = Nz(Me.cbxFechaPrevista.Value, Today)
            If Not IsDBNull(e.Row.DataRow("FechaAlquiler")) AndAlso dFechaPrevistaRetorno >= e.Row.DataRow("FechaAlquiler") Then
                e.Row.DataRow("CantidadMarcaFecha2") = dFechaPrevistaRetorno
            Else
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

    Private Sub CIAvisos_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles Me.BusinessCalling
        e.Cancel = True
    End Sub

End Class
