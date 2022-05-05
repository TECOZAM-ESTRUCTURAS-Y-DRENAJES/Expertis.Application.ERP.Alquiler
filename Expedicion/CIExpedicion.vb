Public Class CIExpedicion
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        mLotes = New LoteStockableUserDialog
        mLotes.Text = "EXPEDICIONES"
        mLotes.ClaseMovimiento = [Shared].ClaseMovimiento.Salida
        mLotes.DataSource = Grid
        mLotes.DataSchema.Cantidad = "CantidadMarca1"
        mLotes.DataSchema.IDArticulo = "IDMaterial"

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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblCGestion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblEstadoDif As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaEntregaH As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaEntregaD As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblSubFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblLote As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblEstadoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblNSerie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lbltipoAlbaran As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblMaterial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPendiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblArticuloPorLotes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblHora As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxCGestion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxEstadoDif As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxFechaEntregaH As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaEntregaD As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents AdvTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advSubFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvLote As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxEstadoTrabajo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxNSerie As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxtipoAlbaran As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents advIDAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDMaterial As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxArticuloPorLotes As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtPendiente As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents Icons As System.Windows.Forms.ImageList
    Friend WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxHora As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cbxCGestion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIExpedicion))
        Dim cbxEstadoDif_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstadoTrabajo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxNSerie_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxtipoAlbaran_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxArticuloPorLotes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cbxCGestion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblCGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstadoDif = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstadoDif = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaEntregaH = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaEntregaH = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaEntregaD = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaEntregaD = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.advSubFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblSubFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvLote = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblLote = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstadoTrabajo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstadoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxNSerie = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblNSerie = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxtipoAlbaran = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lbltipoAlbaran = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDMaterial = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPendiente = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxArticuloPorLotes = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblArticuloPorLotes = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxHora = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblHora = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtPendiente = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxCGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEstadoDif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEstadoTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxNSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxtipoAlbaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxArticuloPorLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.AdvIDCliente)
        Me.FilterPanel.Controls.Add(Me.txtPendiente)
        Me.FilterPanel.Controls.Add(Me.lblCGestion)
        Me.FilterPanel.Controls.Add(Me.lblEstadoDif)
        Me.FilterPanel.Controls.Add(Me.lblFechaEntregaH)
        Me.FilterPanel.Controls.Add(Me.lblFechaEntregaD)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblSubFamilia)
        Me.FilterPanel.Controls.Add(Me.lblFamilia)
        Me.FilterPanel.Controls.Add(Me.lblTipo)
        Me.FilterPanel.Controls.Add(Me.lblLote)
        Me.FilterPanel.Controls.Add(Me.lblEstadoTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblNSerie)
        Me.FilterPanel.Controls.Add(Me.lbltipoAlbaran)
        Me.FilterPanel.Controls.Add(Me.lblAlmacen)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblMaterial)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.lblEstado)
        Me.FilterPanel.Controls.Add(Me.lblPendiente)
        Me.FilterPanel.Controls.Add(Me.lblArticuloPorLotes)
        Me.FilterPanel.Controls.Add(Me.cbxCGestion)
        Me.FilterPanel.Controls.Add(Me.cbxEstadoDif)
        Me.FilterPanel.Controls.Add(Me.cbxFechaEntregaH)
        Me.FilterPanel.Controls.Add(Me.cbxFechaEntregaD)
        Me.FilterPanel.Controls.Add(Me.AdvTrabajo)
        Me.FilterPanel.Controls.Add(Me.advSubFamilia)
        Me.FilterPanel.Controls.Add(Me.advFamilia)
        Me.FilterPanel.Controls.Add(Me.advTipo)
        Me.FilterPanel.Controls.Add(Me.AdvLote)
        Me.FilterPanel.Controls.Add(Me.cbxEstadoTrabajo)
        Me.FilterPanel.Controls.Add(Me.cbxNSerie)
        Me.FilterPanel.Controls.Add(Me.cbxtipoAlbaran)
        Me.FilterPanel.Controls.Add(Me.advIDAlmacen)
        Me.FilterPanel.Controls.Add(Me.AdvObraHasta)
        Me.FilterPanel.Controls.Add(Me.AdvObraDesde)
        Me.FilterPanel.Controls.Add(Me.AdvIDMaterial)
        Me.FilterPanel.Controls.Add(Me.cbxEstado)
        Me.FilterPanel.Controls.Add(Me.cbxArticuloPorLotes)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 245)
        Me.FilterPanel.Size = New System.Drawing.Size(744, 136)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Panel1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(744, 245)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Me.Grid.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "Cantidad", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "Pendiente"), New Solmicro.Expertis.Engine.UI.CheckField("FechaAlquiler", "Fecha Inicio Alquiler", Solmicro.Expertis.Engine.UI.CheckFieldType.DateTime, ""), New Solmicro.Expertis.Engine.UI.CheckField("HoraAlquiler", "Hora Alquiler", Solmicro.Expertis.Engine.UI.CheckFieldType.Char, "")})
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraMaterial"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDLineaMaterial"
        Me.Grid.Location = New System.Drawing.Point(0, 32)
        Me.Grid.Size = New System.Drawing.Size(744, 213)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vAlquilerCIExpedicion"
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
        Me.MainPanel.Size = New System.Drawing.Size(744, 381)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(744, 381)
        '
        'cbxCGestion
        '
        cbxCGestion_DesignTimeLayout.LayoutString = resources.GetString("cbxCGestion_DesignTimeLayout.LayoutString")
        Me.cbxCGestion.DesignTimeLayout = cbxCGestion_DesignTimeLayout
        Me.cbxCGestion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxCGestion.EntityName = "CentroGestion"
        Me.cbxCGestion.Location = New System.Drawing.Point(658, 41)
        Me.cbxCGestion.Name = "cbxCGestion"
        Me.cbxCGestion.PrimaryDataFields = "IDCentroGestion"
        Me.cbxCGestion.SecondaryDataFields = "IDCentroGestion"
        Me.cbxCGestion.SelectedIndex = -1
        Me.cbxCGestion.SelectedItem = Nothing
        Me.cbxCGestion.Size = New System.Drawing.Size(78, 21)
        Me.cbxCGestion.TabIndex = 16
        Me.cbxCGestion.ViewName = "tbMaestroCentroGestion"
        '
        'lblCGestion
        '
        Me.lblCGestion.Location = New System.Drawing.Point(568, 41)
        Me.lblCGestion.Name = "lblCGestion"
        Me.lblCGestion.Size = New System.Drawing.Size(67, 13)
        Me.lblCGestion.TabIndex = 0
        Me.lblCGestion.Text = "C. Gestión"
        '
        'cbxEstadoDif
        '
        cbxEstadoDif_DesignTimeLayout.LayoutString = resources.GetString("cbxEstadoDif_DesignTimeLayout.LayoutString")
        Me.cbxEstadoDif.DesignTimeLayout = cbxEstadoDif_DesignTimeLayout
        Me.cbxEstadoDif.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstadoDif.Location = New System.Drawing.Point(481, 110)
        Me.cbxEstadoDif.Name = "cbxEstadoDif"
        Me.cbxEstadoDif.SelectedIndex = -1
        Me.cbxEstadoDif.SelectedItem = Nothing
        Me.cbxEstadoDif.Size = New System.Drawing.Size(78, 21)
        Me.cbxEstadoDif.TabIndex = 14
        '
        'lblEstadoDif
        '
        Me.lblEstadoDif.Location = New System.Drawing.Point(353, 110)
        Me.lblEstadoDif.Name = "lblEstadoDif"
        Me.lblEstadoDif.Size = New System.Drawing.Size(126, 13)
        Me.lblEstadoDif.TabIndex = 17
        Me.lblEstadoDif.Text = "Estado OServicio <>"
        '
        'cbxFechaEntregaH
        '
        Me.cbxFechaEntregaH.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaEntregaH.Location = New System.Drawing.Point(658, 110)
        Me.cbxFechaEntregaH.Name = "cbxFechaEntregaH"
        Me.cbxFechaEntregaH.Size = New System.Drawing.Size(78, 21)
        Me.cbxFechaEntregaH.TabIndex = 19
        '
        'lblFechaEntregaH
        '
        Me.lblFechaEntregaH.Location = New System.Drawing.Point(568, 110)
        Me.lblFechaEntregaH.Name = "lblFechaEntregaH"
        Me.lblFechaEntregaH.Size = New System.Drawing.Size(85, 13)
        Me.lblFechaEntregaH.TabIndex = 18
        Me.lblFechaEntregaH.Text = "F. Entrega =<"
        '
        'cbxFechaEntregaD
        '
        Me.cbxFechaEntregaD.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaEntregaD.Location = New System.Drawing.Point(658, 87)
        Me.cbxFechaEntregaD.Name = "cbxFechaEntregaD"
        Me.cbxFechaEntregaD.Size = New System.Drawing.Size(78, 21)
        Me.cbxFechaEntregaD.TabIndex = 18
        '
        'lblFechaEntregaD
        '
        Me.lblFechaEntregaD.Location = New System.Drawing.Point(568, 87)
        Me.lblFechaEntregaD.Name = "lblFechaEntregaD"
        Me.lblFechaEntregaD.Size = New System.Drawing.Size(85, 13)
        Me.lblFechaEntregaD.TabIndex = 20
        Me.lblFechaEntregaD.Text = "F. Entrega >="
        '
        'AdvTrabajo
        '
        Me.AdvTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajo.DisplayField = "CodTrabajo"
        Me.AdvTrabajo.EntityName = "ObraTrabajo"
        Me.AdvTrabajo.Location = New System.Drawing.Point(75, 110)
        Me.AdvTrabajo.Name = "AdvTrabajo"
        Me.AdvTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvTrabajo.Size = New System.Drawing.Size(95, 23)
        Me.AdvTrabajo.TabIndex = 4
        Me.AdvTrabajo.ViewName = "tbObraTrabajo"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(4, 110)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(70, 13)
        Me.lblTrabajo.TabIndex = 21
        Me.lblTrabajo.Text = "O. Servicio"
        '
        'advSubFamilia
        '
        Me.advSubFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advSubFamilia.EntityName = "Subfamilia"
        Me.advSubFamilia.Location = New System.Drawing.Point(268, 110)
        Me.advSubFamilia.Name = "advSubFamilia"
        Me.advSubFamilia.SecondaryDataFields = "IDSubfamilia"
        Me.advSubFamilia.Size = New System.Drawing.Size(78, 23)
        Me.advSubFamilia.TabIndex = 9
        Me.advSubFamilia.ViewName = "tbMaestroSubfamilia"
        '
        'lblSubFamilia
        '
        Me.lblSubFamilia.Location = New System.Drawing.Point(177, 110)
        Me.lblSubFamilia.Name = "lblSubFamilia"
        Me.lblSubFamilia.Size = New System.Drawing.Size(68, 13)
        Me.lblSubFamilia.TabIndex = 23
        Me.lblSubFamilia.Text = "SubFamilia"
        '
        'advFamilia
        '
        Me.advFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advFamilia.EntityName = "Familia"
        Me.advFamilia.Location = New System.Drawing.Point(268, 87)
        Me.advFamilia.Name = "advFamilia"
        Me.advFamilia.SecondaryDataFields = "IDFamilia"
        Me.advFamilia.Size = New System.Drawing.Size(78, 23)
        Me.advFamilia.TabIndex = 8
        Me.advFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(177, 87)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblFamilia.TabIndex = 25
        Me.lblFamilia.Text = "Familia"
        '
        'advTipo
        '
        Me.advTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advTipo.EntityName = "TipoArticulo"
        Me.advTipo.Location = New System.Drawing.Point(268, 64)
        Me.advTipo.Name = "advTipo"
        Me.advTipo.SecondaryDataFields = "IDTipo"
        Me.advTipo.Size = New System.Drawing.Size(78, 23)
        Me.advTipo.TabIndex = 7
        Me.advTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(177, 64)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 27
        Me.lblTipo.Text = "Tipo"
        '
        'AdvLote
        '
        Me.AdvLote.DisabledBackColor = System.Drawing.Color.White
        Me.AdvLote.EntityName = "ArticuloNSerie"
        Me.AdvLote.Location = New System.Drawing.Point(75, 87)
        Me.AdvLote.Name = "AdvLote"
        Me.AdvLote.SecondaryDataFields = "NSerie"
        Me.AdvLote.Size = New System.Drawing.Size(95, 23)
        Me.AdvLote.TabIndex = 3
        Me.AdvLote.ViewName = "tbArticuloNSerie"
        '
        'lblLote
        '
        Me.lblLote.Location = New System.Drawing.Point(4, 87)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(59, 13)
        Me.lblLote.TabIndex = 29
        Me.lblLote.Text = "Nº. Serie"
        '
        'cbxEstadoTrabajo
        '
        cbxEstadoTrabajo_DesignTimeLayout.LayoutString = resources.GetString("cbxEstadoTrabajo_DesignTimeLayout.LayoutString")
        Me.cbxEstadoTrabajo.DesignTimeLayout = cbxEstadoTrabajo_DesignTimeLayout
        Me.cbxEstadoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstadoTrabajo.Location = New System.Drawing.Point(481, 87)
        Me.cbxEstadoTrabajo.Name = "cbxEstadoTrabajo"
        Me.cbxEstadoTrabajo.SelectedIndex = -1
        Me.cbxEstadoTrabajo.SelectedItem = Nothing
        Me.cbxEstadoTrabajo.Size = New System.Drawing.Size(78, 21)
        Me.cbxEstadoTrabajo.TabIndex = 13
        '
        'lblEstadoTrabajo
        '
        Me.lblEstadoTrabajo.Location = New System.Drawing.Point(353, 87)
        Me.lblEstadoTrabajo.Name = "lblEstadoTrabajo"
        Me.lblEstadoTrabajo.Size = New System.Drawing.Size(108, 13)
        Me.lblEstadoTrabajo.TabIndex = 31
        Me.lblEstadoTrabajo.Text = "Estado O.Servicio"
        '
        'cbxNSerie
        '
        cbxNSerie_DesignTimeLayout.LayoutString = resources.GetString("cbxNSerie_DesignTimeLayout.LayoutString")
        Me.cbxNSerie.DesignTimeLayout = cbxNSerie_DesignTimeLayout
        Me.cbxNSerie.DisabledBackColor = System.Drawing.Color.White
        Me.cbxNSerie.Location = New System.Drawing.Point(481, 41)
        Me.cbxNSerie.Name = "cbxNSerie"
        Me.cbxNSerie.SelectedIndex = -1
        Me.cbxNSerie.SelectedItem = Nothing
        Me.cbxNSerie.Size = New System.Drawing.Size(78, 21)
        Me.cbxNSerie.TabIndex = 11
        '
        'lblNSerie
        '
        Me.lblNSerie.Location = New System.Drawing.Point(353, 41)
        Me.lblNSerie.Name = "lblNSerie"
        Me.lblNSerie.Size = New System.Drawing.Size(106, 13)
        Me.lblNSerie.TabIndex = 32
        Me.lblNSerie.Text = "Gestión Nº. Serie"
        '
        'cbxtipoAlbaran
        '
        cbxtipoAlbaran_DesignTimeLayout.LayoutString = resources.GetString("cbxtipoAlbaran_DesignTimeLayout.LayoutString")
        Me.cbxtipoAlbaran.DesignTimeLayout = cbxtipoAlbaran_DesignTimeLayout
        Me.cbxtipoAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.cbxtipoAlbaran.Location = New System.Drawing.Point(658, 18)
        Me.cbxtipoAlbaran.Name = "cbxtipoAlbaran"
        Me.cbxtipoAlbaran.SelectedIndex = -1
        Me.cbxtipoAlbaran.SelectedItem = Nothing
        Me.cbxtipoAlbaran.Size = New System.Drawing.Size(78, 21)
        Me.cbxtipoAlbaran.TabIndex = 15
        '
        'lbltipoAlbaran
        '
        Me.lbltipoAlbaran.Location = New System.Drawing.Point(568, 18)
        Me.lbltipoAlbaran.Name = "lbltipoAlbaran"
        Me.lbltipoAlbaran.Size = New System.Drawing.Size(79, 13)
        Me.lbltipoAlbaran.TabIndex = 33
        Me.lbltipoAlbaran.Text = "Tipo Albarán"
        '
        'advIDAlmacen
        '
        Me.advIDAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advIDAlmacen.EntityName = "Almacen"
        Me.advIDAlmacen.Location = New System.Drawing.Point(75, 64)
        Me.advIDAlmacen.Name = "advIDAlmacen"
        Me.advIDAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.Size = New System.Drawing.Size(95, 23)
        Me.advIDAlmacen.TabIndex = 2
        Me.advIDAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(4, 64)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblAlmacen.TabIndex = 34
        Me.lblAlmacen.Text = "Almacén"
        '
        'AdvObraHasta
        '
        Me.AdvObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraHasta.DisplayField = "NObra"
        Me.AdvObraHasta.EntityName = "ObraCabecera"
        Me.AdvObraHasta.Location = New System.Drawing.Point(268, 41)
        Me.AdvObraHasta.Name = "AdvObraHasta"
        Me.AdvObraHasta.SecondaryDataFields = "IDObra"
        Me.AdvObraHasta.Size = New System.Drawing.Size(78, 23)
        Me.AdvObraHasta.TabIndex = 6
        Me.AdvObraHasta.ViewName = "tbObraCabecera"
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(177, 41)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(86, 13)
        Me.lblObraHasta.TabIndex = 36
        Me.lblObraHasta.Text = "Alquiler Hasta"
        '
        'AdvObraDesde
        '
        Me.AdvObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraDesde.DisplayField = "NObra"
        Me.AdvObraDesde.EntityName = "ObraCabecera"
        Me.AdvObraDesde.Location = New System.Drawing.Point(268, 18)
        Me.AdvObraDesde.Name = "AdvObraDesde"
        Me.AdvObraDesde.SecondaryDataFields = "IDObra"
        Me.AdvObraDesde.Size = New System.Drawing.Size(78, 23)
        Me.AdvObraDesde.TabIndex = 5
        Me.AdvObraDesde.ViewName = "tbObraCabecera"
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(177, 18)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(90, 13)
        Me.lblObraDesde.TabIndex = 38
        Me.lblObraDesde.Text = "Alquiler Desde"
        '
        'AdvIDMaterial
        '
        Me.AdvIDMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDMaterial.EntityName = "Articulo"
        Me.AdvIDMaterial.Location = New System.Drawing.Point(75, 41)
        Me.AdvIDMaterial.Name = "AdvIDMaterial"
        Me.AdvIDMaterial.SecondaryDataFields = "IDArticulo"
        Me.AdvIDMaterial.Size = New System.Drawing.Size(95, 23)
        Me.AdvIDMaterial.TabIndex = 1
        Me.AdvIDMaterial.ViewName = "tbMaestroArticulo"
        '
        'lblMaterial
        '
        Me.lblMaterial.Location = New System.Drawing.Point(4, 41)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(52, 13)
        Me.lblMaterial.TabIndex = 40
        Me.lblMaterial.Text = "Material"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(4, 18)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 42
        Me.lblCliente.Text = "Cliente"
        '
        'cbxEstado
        '
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.Location = New System.Drawing.Point(481, 64)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(78, 21)
        Me.cbxEstado.TabIndex = 12
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(353, 64)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 44
        Me.lblEstado.Text = "Estado"
        '
        'lblPendiente
        '
        Me.lblPendiente.Location = New System.Drawing.Point(568, 64)
        Me.lblPendiente.Name = "lblPendiente"
        Me.lblPendiente.Size = New System.Drawing.Size(76, 13)
        Me.lblPendiente.TabIndex = 45
        Me.lblPendiente.Text = "Pendiente >"
        '
        'cbxArticuloPorLotes
        '
        cbxArticuloPorLotes_DesignTimeLayout.LayoutString = resources.GetString("cbxArticuloPorLotes_DesignTimeLayout.LayoutString")
        Me.cbxArticuloPorLotes.DesignTimeLayout = cbxArticuloPorLotes_DesignTimeLayout
        Me.cbxArticuloPorLotes.DisabledBackColor = System.Drawing.Color.White
        Me.cbxArticuloPorLotes.Location = New System.Drawing.Point(481, 18)
        Me.cbxArticuloPorLotes.Name = "cbxArticuloPorLotes"
        Me.cbxArticuloPorLotes.SelectedIndex = -1
        Me.cbxArticuloPorLotes.SelectedItem = Nothing
        Me.cbxArticuloPorLotes.Size = New System.Drawing.Size(78, 21)
        Me.cbxArticuloPorLotes.TabIndex = 10
        '
        'lblArticuloPorLotes
        '
        Me.lblArticuloPorLotes.Location = New System.Drawing.Point(353, 18)
        Me.lblArticuloPorLotes.Name = "lblArticuloPorLotes"
        Me.lblArticuloPorLotes.Size = New System.Drawing.Size(84, 13)
        Me.lblArticuloPorLotes.TabIndex = 46
        Me.lblArticuloPorLotes.Text = "Gestión Lotes"
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
        Me.Panel1.Size = New System.Drawing.Size(744, 32)
        Me.Panel1.TabIndex = 1
        '
        'cbxHora
        '
        Me.cbxHora.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Time
        Me.cbxHora.DisabledBackColor = System.Drawing.Color.White
        Me.cbxHora.EditStyle = Janus.Windows.CalendarCombo.EditStyle.Masked
        Me.cbxHora.Location = New System.Drawing.Point(357, 7)
        Me.cbxHora.Name = "cbxHora"
        Me.cbxHora.ShowDropDown = False
        Me.cbxHora.Size = New System.Drawing.Size(65, 21)
        Me.cbxHora.TabIndex = 56
        '
        'lblHora
        '
        Me.lblHora.Location = New System.Drawing.Point(237, 11)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(116, 13)
        Me.lblHora.TabIndex = 53
        Me.lblHora.Text = "Hora Inicio Alquiler"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(11, 11)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(122, 13)
        Me.lblFecha.TabIndex = 54
        Me.lblFecha.Text = "Fecha Inicio Alquiler"
        '
        'cbxFecha
        '
        Me.cbxFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFecha.Location = New System.Drawing.Point(136, 7)
        Me.cbxFecha.Name = "cbxFecha"
        Me.cbxFecha.Size = New System.Drawing.Size(84, 21)
        Me.cbxFecha.TabIndex = 51
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(594, 11)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 55
        Me.lblContador.Text = "Contador"
        '
        'AdvContador
        '
        Me.AdvContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvContador.EntityName = "EntidadContador"
        Me.AdvContador.Location = New System.Drawing.Point(658, 5)
        Me.AdvContador.Name = "AdvContador"
        Me.AdvContador.PrimaryDataFields = "IDContador"
        Me.AdvContador.SecondaryDataFields = "IDContador"
        Me.AdvContador.Size = New System.Drawing.Size(79, 23)
        Me.AdvContador.TabIndex = 50
        Me.AdvContador.ViewName = "tbEntidadContador"
        '
        'txtPendiente
        '
        Me.txtPendiente.DisabledBackColor = System.Drawing.Color.White
        Me.txtPendiente.Location = New System.Drawing.Point(658, 64)
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtPendiente.Size = New System.Drawing.Size(78, 21)
        Me.txtPendiente.TabIndex = 47
        '
        'Icons
        '
        Me.Icons.ImageStream = CType(resources.GetObject("Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icons.TransparentColor = System.Drawing.Color.Transparent
        Me.Icons.Images.SetKeyName(0, "")
        Me.Icons.Images.SetKeyName(1, "")
        '
        'AdvIDCliente
        '
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(75, 18)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(95, 23)
        Me.AdvIDCliente.TabIndex = 0
        Me.AdvIDCliente.ViewName = "tbMaestroCliente"
        '
        'CIExpedicion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "Cantidad", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "Pendiente"), New Solmicro.Expertis.Engine.UI.CheckField("FechaAlquiler", "Fecha Inicio Alquiler", Solmicro.Expertis.Engine.UI.CheckFieldType.DateTime, ""), New Solmicro.Expertis.Engine.UI.CheckField("HoraAlquiler", "Hora Alquiler", Solmicro.Expertis.Engine.UI.CheckFieldType.Char, "")})
        Me.ClientSize = New System.Drawing.Size(752, 469)
        Me.EntityName = "ObraMaterial"
        Me.KeyField = "IDLineaMaterial"
        Me.Name = "CIExpedicion"
        Me.UseCheck = True
        Me.ViewName = "vAlquilerCIExpedicion"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxCGestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEstadoDif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEstadoTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxNSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxtipoAlbaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxArticuloPorLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mLotes As LoteStockableUserDialog

    Private Enum TipoAlbaran
        TodalasLineas = 1
        Consumos = 2
        Alquileres = 3
    End Enum

    Private Const FormatStyle As String = "consumos"

#Region " Load "

    Private Sub CIExpedicion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadERPData()
        LoadEnums()
        LoadToolbarActions()
        LoadGridActions()
        InitFilterCriteria()
    End Sub

    Private Sub LoadERPData()
        AdvContador.Text = LoadContadorPorDefecto()
        Dim CentroGestionInfo As New UsuarioCentroGestion.UsuarioCentroGestionInfo
        ExpertisApp.ExecuteTask(Of UsuarioCentroGestion.UsuarioCentroGestionInfo, UsuarioCentroGestion.UsuarioCentroGestionInfo)(AddressOf UsuarioCentroGestion.ObtenerUsuarioCentroGestion, CentroGestionInfo)
        cbxCGestion.Value = CentroGestionInfo.IDCentroGestion
    End Sub

    Private Sub LoadEnums()
        cbxEstado.DataSource = New EnumData("enumomEstado")
        cbxEstadoDif.DataSource = New EnumData("EnumOtEstado")
        cbxEstadoTrabajo.DataSource = New EnumData("EnumOtEstado")
        cbxArticuloPorLotes.DataSource = New EnumData("enumBoolean")
        cbxtipoAlbaran.DataSource = New EnumData("enumTipoAlbaran")
        cbxNSerie.DataSource = New EnumData("EnumBoolean")

        EnumData.PopulateValueList("enumomEstado", Grid.Columns("Estado"))
        EnumData.PopulateValueList("enumOtEstado", Grid.Columns("EstadoTrabajo"))
        EnumData.PopulateValueList("enumomATipoFacturacionAlquiler", Grid.Columns("TipoFacturacion"))
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Generar Albaranes", AddressOf Expedir, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
        Me.FormActions.Add("Ver Disponibilidad", AddressOf VerDisponibilidad, ExpertisApp.GetIcon("folder_view.ico"))
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add(cnABRIRALQUILER, AddressOf AccionAbrirAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
        Grid.Actions.Add(cnABRIRORDENSERVICIO, AddressOf AccionAbrirOrdenServicio, ExpertisApp.GetIcon("clipboard.ico"))
    End Sub

    Private Sub InitFilterCriteria()
        txtPendiente.Value = 0
        cbxArticuloPorLotes.Value = CInt(enumBoolean.Todos)
        cbxNSerie.Value = CInt(enumBoolean.Todos)
        cbxtipoAlbaran.Value = TipoAlbaran.TodalasLineas
        cbxEstadoDif.Value = CInt(enumotEstado.otTerminado)
    End Sub

    Public Function LoadContadorPorDefecto() As String
        Return ExpertisApp.ExecuteTask(Of CentroGestion.ContadorEntidad, String)(AddressOf CentroGestion.GetContadorPredeterminadoCGestionUsuario, CentroGestion.ContadorEntidad.AlbaranVenta)
    End Function

#End Region

#Region " Toolbar Actions "

#Region " Expedir "

    Private Sub Expedir()
        If Not IsNothing(Grid) AndAlso Grid.RowCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            If dtMarcados Is Nothing OrElse dtMarcados.Rows.Count = 0 Then
                ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                'Si en alguna de las filas el pedido que se ha hecho es mayor del stock del articulo se cancela la acción AQUÍ y no sigue-David 22/10/21.No se contempla que haya un stock negativo del articulo.
                Dim cont As Integer = 0

                For Each dr As DataRow In dtMarcados.Rows
                    If (dr("QPrev") > dr("StockFisico")) Then
                        ExpertisApp.GenerateMessage("La cantidad pedida de " & dr("DescMaterial") & " de la orden " & dr("CodTrabajo") & " es mayor que el stock disponible. No se puede generar el albarán.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        cont += 1
                    End If

                Next

                If (cont > 0) Then
                    Exit Sub
                End If
                'Hasta aquí

                Dim frmCondiciones As New frmCondicionesAlquilerMasiva
                frmCondiciones.AbrirCondicionesAlquiler(dtMarcados.Copy)

                Dim frmAC As New frmDatosAuxExpedicion
                Dim d As frmDatosAuxExpedicion.DatosContadorConductor
                d = frmAC.AbrirFormulario(dtMarcados, , , , True)
                If d.Ok = DialogResult.OK Then
                    Dim dtContadores As DataTable = d.dtContadores
                    Dim dtConductores As DataTable = d.dtConductores

                    Dim aExpedir(-1) As CrearAlbaranVentaInfo
                    aExpedir = ValidaLineasMaterial(dtMarcados)

                    If ExpertisApp.GenerateMessage("Se va a proceder a la Generación de Albaranes de las líneas seleccionadas. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Me.Cursor = Cursors.WaitCursor

                        Dim data As New DataPrcAlbaranar(aExpedir, AdvContador.Text, , New Parametro().TipoAlbaranDeDeposito, enumTipoExpedicion.teAlquiler)
                        Dim Propuesta As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                        If Not IsNothing(Propuesta) Then
                            If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                                Dim frm As New frmAlbaranProvisional
                                Dim dr As DialogResult = frm.AbrirFormulario(Propuesta.PropuestaAlbaranes)
                                If dr = DialogResult.OK Then
                                    Me.Cursor = Cursors.WaitCursor
                                    Dim datosAct As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                                    datosAct.Conductores = dtConductores
                                    datosAct.Contadores = dtContadores
                                    datosAct.Retornos = False

                                    Dim rslt As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquiler), datosAct)
                                    TratarLog(rslt.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True, rslt.StockUpdateData)
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
                End If
            End If
        End If
    End Sub

    Private Function ValidaLineasMaterial(ByVal dtExpedir As DataTable) As CrearAlbaranVentaInfo()
        If Not IsNothing(dtExpedir) AndAlso dtExpedir.Rows.Count > 0 Then
            Dim strIDOperario As String = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf Operario.ObtenerIDOperarioUsuario, Nothing)
            If Length(strIDOperario) = 0 Then
                ExpertisApp.GenerateMessage("Proceso cancelado. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim aExpedir(-1) As CrearAlbaranVentaInfo
                For Each selectedRow As DataRow In dtExpedir.Rows
                    If selectedRow("CantidadMarca1") > 0 Then
                        Dim f As New Filter
                        Dim dt As DataTable = New BE.DataEngine().Filter("vAlquilerCIFechaVencimientoAlq", f)

                        Dim datosExp As New CrearAlbaranVentaInfo
                        datosExp.IDLinea = selectedRow("IDLineaMaterial")
                        datosExp.Cantidad = selectedRow("CantidadMarca1")
                        datosExp.IDCliente = selectedRow("IDCliente")
                        If Length(selectedRow("FechaAlquiler")) > 0 Then
                            datosExp.FechaAlquiler = selectedRow("FechaAlquiler")
                        ElseIf Length(cbxFecha.Value) > 0 Then
                            datosExp.FechaAlquiler = cbxFecha.Value
                        Else
                            datosExp.FechaAlquiler = Date.Today
                        End If
                        If Length(selectedRow("HoraAlquiler")) > 0 Then
                            datosExp.HoraAlquiler = selectedRow("HoraAlquiler")
                        ElseIf Length(cbxHora.Text) > 0 Then
                            datosExp.HoraAlquiler = cbxHora.Text
                        Else
                            datosExp.HoraAlquiler = Date.Today.ToShortTimeString
                        End If
                        If selectedRow("GestionStockPorLotes") Then
                            datosExp.Lotes = mLotes.LoteCollection.GetDataTable(selectedRow("IDLineaMaterial"))
                        End If

                        ReDim Preserve aExpedir(UBound(aExpedir) + 1)
                        aExpedir(UBound(aExpedir)) = datosExp
                    End If
                Next

                Return aExpedir
            End If
        End If

        Return Nothing
    End Function

#End Region

#Region " Disponibilidad "

    Private Sub VerDisponibilidad()
        If ExpertisApp.IsFormOpen("CIDALQ") Then ExpertisApp.CloseForm("CIDALQ")
        Dim HT As New Hashtable
        HT("Filtro") = PrepararFiltro()
        ExpertisApp.OpenForm("CIDALQ", , HT)
    End Sub

    Private Function PrepararFiltro() As Filter
        If Not Grid.DataSource Is Nothing AndAlso Grid.RecordCount > 0 Then
            Dim dtGrid As DataTable = Grid.DataSource
            Dim strArticulo As String = String.Empty
            Dim dvGrid As New DataView(dtGrid)
            dvGrid.Sort = "IDMaterial"
            Dim Values(-1) As Object
            For Each drvGrid As DataRowView In dvGrid
                If strArticulo <> drvGrid.Row("IDMaterial") & String.empty Then
                    ReDim Preserve Values(UBound(Values) + 1)
                    Values(UBound(Values)) = drvGrid.Row("IDMaterial")
                End If
                strArticulo = drvGrid.Row("IDMaterial")
            Next
            If Values.Length > 0 Then
                Dim fWhere As New Filter
                fWhere.Add(New InListFilterItem("IDArticulo", Values, FilterType.String))
                Return fWhere
            End If
        End If
        Return Nothing
    End Function

#End Region

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirAlquiler()
        AbrirMntoAlquiler(Grid.Value("IDObra"))
    End Sub

    Private Sub AccionAbrirOrdenServicio()
        AbrirOrdenServicio(Grid.Value("IDTrabajo"), Grid.Value("IDObra"))
    End Sub

#End Region

#Region " Grid "

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        If Grid.GetValue("GestionStockPorLotes") Then
            Grid.Columns("CantidadMarca1").ButtonDisplayMode = CellButtonDisplayMode.CurrentRow
            Grid.Columns("CantidadMarca1").ButtonStyle = ButtonStyle.Image
            Grid.Columns("CantidadMarca1").ButtonImage = Icons.Images(0)
        End If
        Select Case e.Column.Key
            Case "FechaAlquiler", "FechaPrevistaRetorno"
                Grid.Columns(e.Column.Key).EditType = EditType.CalendarDropDown
            Case "HoraAlquiler"
                Grid.Columns("HoraAlquiler").EditType = EditType.TextBox
        End Select
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        With Grid
            If e.Row.RowType = Janus.Windows.GridEX.RowType.Record Then
                If Length(e.Row.Cells("TipoFacturacion").Value) > 0 AndAlso e.Row.Cells("TipoFacturacion").Value = enumomATipoFacturacionAlquiler.omAPorAlquiler Then
                    e.Row.RowStyle = .FormatStyles("PorAlquilerFormatStyle")
                End If
                If Length(e.Row.Cells("Lote").Value) > 0 AndAlso Length(e.Row.Cells("IDEstadoActivo").Value) > 0 AndAlso e.Row.Cells("IDEstadoActivo").Value = NegocioGeneral.ESTADOACTIVO_RESERVADA Then
                    e.Row.Cells("Warning").ImageIndex = 0
                End If
            End If
        End With
    End Sub

    Private Sub Grid_CheckingRecord(ByVal sender As Object, ByVal e As Engine.UI.CheckingEventArgs) Handles MyBase.CheckingRecord
        Dim blnCancelCheck As Boolean
        blnCancelCheck = False
        With Grid
            If e.CheckState = CheckStates.UnChecked Then
                If Length(cbxFecha.Value) > 0 AndAlso IsDate(cbxFecha.Value) Then
                    If cbxFecha.Value > Nz(.Value("FechaMaxima"), cnMinDate) Or Length(.Value("FechaMaxima")) = 0 Then
                        e.Row.Cells("FechaAlquiler").Value = cbxFecha.Value
                        If Length(cbxHora.Text) > 0 Then
                            e.Row.Cells("HoraAlquiler").Value = cbxHora.Text
                        Else
                            e.Row.Cells("HoraAlquiler").Value = Date.Today.ToShortTimeString
                        End If
                    Else
                        e.Row.Cells("FechaAlquiler").Value = System.DBNull.Value
                        e.Row.Cells("HoraAlquiler").Value = System.DBNull.Value
                        blnCancelCheck = True
                    End If
                Else
                    If Date.Today > Nz(.Value("FechaMaxima"), cnMinDate) Or Length(.Value("FechaMaxima")) = 0 Then
                        e.Row.Cells("FechaAlquiler").Value = Date.Today
                        If Length(cbxHora.Text) > 0 Then
                            e.Row.Cells("HoraAlquiler").Value = cbxHora.Text
                        Else
                            e.Row.Cells("HoraAlquiler").Value = Date.Today.ToShortTimeString
                        End If
                    Else
                        e.Row.Cells("FechaAlquiler").Value = System.DBNull.Value
                        e.Row.Cells("HoraAlquiler").Value = System.DBNull.Value
                        blnCancelCheck = True
                    End If
                End If

                If .Value("NSerieObligatorio") Then
                    If Length(.Value("Lote")) = 0 Then
                        ExpertisApp.GenerateMessage("Este materiales no tiene signado un Número de Serie.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            Else
                e.Row.Cells("FechaAlquiler").Value = System.DBNull.Value
                e.Row.Cells("HoraAlquiler").Value = System.DBNull.Value
            End If
            If blnCancelCheck Then
                ExpertisApp.GenerateMessage("La Fecha de Alquiler debe ser superior a la Fecha del Último Vencimiento de la Línea. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                blnCancelCheck = False
            End If
        End With
    End Sub

    Private Sub Grid_RecordChecked(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckedEventArgs) Handles MyBase.RecordChecked
        If e.CheckState = CheckStates.UnChecked Then
            If e.Row.Cells("GestionStockPorLotes").Value Then
                mLotes.LoteCollection.RemoveAt(Grid.Value("IDLineaMaterial"))
            End If
        End If
    End Sub

    Private Sub grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        With Grid
            Select Case e.Column.Key
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

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
        If e.KeyCode = Keys.F4 And Not e.Shift Then
            If Grid.Col = Grid.Columns("CantidadMarca1").Position Then
                If Grid.GetValue("GestionStockPorLotes") Then
                    mLotes.ShowDialog(Grid.GetValue("IDLineaMaterial"))
                End If
            End If
        End If
    End Sub

    Private Sub Grid_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnButtonClick
        If e.Column.Key = "CantidadMarca1" Then
            If Grid.GetValue("GestionStockPorLotes") Then
                mLotes.ShowDialog(Grid.GetValue("IDLineaMaterial"))
            End If
        End If
    End Sub

#End Region

#Region " Execute Query "

    Private Sub CIExpedicion_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If Length(AdvObraDesde.Value) = 0 And Length(AdvObraHasta.Value) = 0 And Length(cbxFechaEntregaD.Value) = 0 And Length(cbxFechaEntregaH.Value) = 0 And Length(cbxCGestion.Value) = 0 And _
             Length(AdvIDCliente.Text) = 0 And Length(AdvTrabajo.Value) = 0 And Length(AdvLote.Text) = 0 Then
            If ExpertisApp.GenerateMessage("Se va a lanzar la consulta sin aplicar ningún filtro. Esto puede que retarde la obtención de información. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True
            End If
        End If

        e.Filter.Add("IDCliente", FilterOperator.Equal, AdvIDCliente.Text, FilterType.String)
        e.Filter.Add("IDMaterial", FilterOperator.Equal, AdvIDMaterial.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, advTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, advFamilia.Text, FilterType.String)
        e.Filter.Add("IDSubFamilia", FilterOperator.Equal, advSubFamilia.Text, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, advIDAlmacen.Text, FilterType.String)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.String)
        e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
        e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
        e.Filter.Add("Estado", FilterOperator.Equal, cbxEstado.Value, FilterType.Numeric)
        e.Filter.Add("EstadoTrabajo", FilterOperator.Equal, cbxEstadoTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("EstadoTrabajo", FilterOperator.NotEqual, cbxEstadoDif.Value, FilterType.Numeric)
        e.Filter.Add("Pendiente", FilterOperator.GreaterThan, txtPendiente.Value, FilterType.Numeric)
        e.Filter.Add("Lote", FilterOperator.Equal, AdvLote.Text, FilterType.String)
        e.Filter.Add("FechaEntrega", FilterOperator.GreaterThanOrEqual, cbxFechaEntregaD.Value, FilterType.DateTime)
        e.Filter.Add("FechaEntrega", FilterOperator.LessThanOrEqual, cbxFechaEntregaH.Value, FilterType.DateTime)
        e.Filter.Add("IdCentroGestion", FilterOperator.Equal, cbxCGestion.Value, FilterType.String)
        If cbxArticuloPorLotes.Value <> enumBoolean.Todos Then
            e.Filter.Add("GestionStockPorLotes", FilterOperator.Equal, cbxArticuloPorLotes.Value, FilterType.Numeric)
        End If
        If cbxNSerie.Value <> enumBoolean.Todos Then
            e.Filter.Add("NSerieObligatorio", FilterOperator.Equal, cbxNSerie.Value, FilterType.Numeric)
        End If
        If cbxtipoAlbaran.Value = TipoAlbaran.Alquileres Then
            e.Filter.Add("TipoFacturacion", FilterOperator.Equal, cbxtipoAlbaran.Value, FilterType.Numeric)
        ElseIf cbxtipoAlbaran.Value = TipoAlbaran.Consumos Then
            e.Filter.Add("TipoFacturacion", FilterOperator.NotEqual, cbxtipoAlbaran.Value, FilterType.Numeric)
        End If
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)

        cbxFechaEntregaD.TextBox.Clear()
        cbxFechaEntregaH.TextBox.Clear()

        InitFilterCriteria()
    End Sub

#End Region

    Private Sub cbxFechaEntregaD_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaEntregaD.LostFocus
        cbxFechaEntregaH.Value = cbxFechaEntregaD.Value
    End Sub

    Private Sub AdvIDAlmacen_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advIDAlmacen.SetPredefinedFilter
        e.Filter.Add(New BooleanFilterItem("Activo", True))
    End Sub

    Private Sub AdvContador_SetPredefinedFilter(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvContador.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("Entidad", GetType(AlbaranVentaCabecera).Name))
    End Sub

#Region " Informes "

    'Private Sub CIExpedicion_SetReportProperties() Handles MyBase.SetReportProperties
    '    Dim intCuentaArg As Integer
    '    Dim strFiltro As String
    '    Dim fwCriterio As clsFilterCriteria

    '    If objReport.Alias = "VGamRptPreparacionEnvios" Then
    '        fwCriterio = New clsFilterCriteria
    '        With fwCriterio
    '            .WhereFormat = wfCrystal
    '            .Alias = "vGamrptPreparacionEnvios"
    '            .AddFilterItem("IDCliente", dtChar, opEqual, FwiIdCliente.Value)
    '            .AddFilterItem("IDMaterial", dtChar, opEqual, FwiIdMaterial.Value)
    '            .AddFilterItem("IDTipo", dtChar, opEqual, FwITipo.Value)
    '            .AddFilterItem("IDFamilia", dtChar, opEqual, FwIFamilia.Value)
    '            .AddFilterItem("IDSubFamilia", dtChar, opEqual, FwISubFamilia.Value)
    '            .AddFilterItem("IDAlmacen", dtChar, opEqual, FwiIdAlmacen.Value)
    '            .AddFilterItem("CodTrabajo", dtChar, opEqual, FwIIDTrabajo.Value)
    '            .AddFilterItem("IDObra", dtNumeric, opGreaterThanOrEqual, FwiObraDesde.Value)
    '            .AddFilterItem("IDObra", dtNumeric, opLessThanOrEqual, FwiObraHasta.Value)
    '            .AddFilterItem("Estado", dtNumeric, opEqual, FwiEstado.Value)
    '            .AddFilterItem("EstadoTrabajo", dtNumeric, opEqual, FwIEstadoTrabajo.Value)
    '            .AddFilterItem("EstadoTrabajo", dtNumeric, opNotEqual, FwIEstadoDif.Value)
    '            .AddFilterItem("Pendiente", dtNumeric, opGreaterThan, FwiPendiente.Value)
    '            .AddFilterItem("Lote", dtChar, opEqual, FwILote.Value)
    '            .AddFilterItem("Fechaentrega", dtDateTime, opGreaterThanOrEqual, FwIFechaEntregaD.Value)
    '            .AddFilterItem("Fechaentrega", dtDateTime, opLessThanOrEqual, FwIFechaEntregaH.Value)
    '            .AddFilterItem("IdCentroGestion", dtChar, opEqual, FwICGestion.Value)
    '            If fwiArticuloPorLotes.Value <> enumBoolean.Todos Then
    '                .AddFilterItem("GestionStockPorLotes", dtBoolean, opEqual, fwiArticuloPorLotes.Value)
    '            End If
    '            If FwINSerie.Value <> enumBoolean.Todos Then
    '                .AddFilterItem("NSerieObligatorio", dtBoolean, opEqual, FwINSerie.Value)
    '            End If
    '            If FwItipoAlbaran.Value = TipoAlbaran.Alquileres Then
    '                .AddFilterItem("TipoFacturacion", dtNumeric, opEqual, enumomATipoFacturacionAlquiler.omAPorAlquiler)
    '            ElseIf FwItipoAlbaran.Value = TipoAlbaran.Consumos Then
    '                .AddFilterItem("TipoFacturacion", dtNumeric, opNotEqual, enumomATipoFacturacionAlquiler.omAPorAlquiler)
    '            End If
    '            strFiltro = .GenerateFilterCriterias
    '            objReport.SelectionFormula = strFiltro
    '        End With
    '    End If
    'End Sub

#End Region

End Class
