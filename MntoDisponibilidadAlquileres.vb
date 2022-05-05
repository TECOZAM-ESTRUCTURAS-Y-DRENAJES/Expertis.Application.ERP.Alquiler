Public Class MntoDisponibilidadAlquileres
    Inherits Solmicro.Expertis.Engine.UI.CIMntoBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
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
    Friend WithEvents topPanel As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraInfoResumen As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents nbxDispReal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblDispReal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxMantenimiento As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblMantenimiento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxPdteServir As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPdteServir As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxNoDisponible As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblNoDisponible As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxEnCurso As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblEnCurso As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxEnDeposito As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblEnDeposito As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxDispTeorico As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblDispTeorico As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulAlmacen As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents TabConsultas As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents TabPageStockActual As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageNoMaquina As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPagePedPendServir As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageDispAlternativas As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grxStockActual As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents grxStockDeposito As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents AdvIDAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents grxNSerie As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageDispComponentes As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pnlEstructura As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents grxDispComponentes As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblEstructura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvEstructura As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents grxPedPendServir As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageCompras As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grxPedidoCompra As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlFiltroAlbaranes As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents grxAlbaranesCompraPdtes As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageAlbPdteActualizar As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageDispNoMaquinas As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grxDispNumMaquinas As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents grxAlternativas As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents AdvProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulblProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim grxStockActual_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoDisponibilidadAlquileres))
        Dim grxStockDeposito_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grxNSerie_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grxPedPendServir_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grxPedidoCompra_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grxAlbaranesCompraPdtes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grxDispNumMaquinas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grxDispComponentes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grxAlternativas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.topPanel = New Solmicro.Expertis.Engine.UI.Panel
        Me.AdvIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FraInfoResumen = New Solmicro.Expertis.Engine.UI.Frame
        Me.nbxDispReal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDispReal = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxMantenimiento = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMantenimiento = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxPdteServir = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPdteServir = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxNoDisponible = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblNoDisponible = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxEnCurso = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblEnCurso = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxEnDeposito = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblEnDeposito = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxDispTeorico = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDispTeorico = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.ulAlmacen = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.ulArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.TabConsultas = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageStockActual = New Janus.Windows.UI.Tab.UITabPage
        Me.grxStockActual = New Solmicro.Expertis.Engine.UI.Grid
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.grxStockDeposito = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageNoMaquina = New Janus.Windows.UI.Tab.UITabPage
        Me.grxNSerie = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPagePedPendServir = New Janus.Windows.UI.Tab.UITabPage
        Me.grxPedPendServir = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageCompras = New Janus.Windows.UI.Tab.UITabPage
        Me.grxPedidoCompra = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageAlbPdteActualizar = New Janus.Windows.UI.Tab.UITabPage
        Me.grxAlbaranesCompraPdtes = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlFiltroAlbaranes = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.ulblProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TabPageDispNoMaquinas = New Janus.Windows.UI.Tab.UITabPage
        Me.grxDispNumMaquinas = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageDispComponentes = New Janus.Windows.UI.Tab.UITabPage
        Me.grxDispComponentes = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlEstructura = New Solmicro.Expertis.Engine.UI.Panel
        Me.AdvEstructura = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblEstructura = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPageDispAlternativas = New Janus.Windows.UI.Tab.UITabPage
        Me.grxAlternativas = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.topPanel.suspendlayout()
        Me.FraInfoResumen.SuspendLayout()
        CType(Me.TabConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConsultas.SuspendLayout()
        Me.TabPageStockActual.SuspendLayout()
        CType(Me.grxStockActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage1.SuspendLayout()
        CType(Me.grxStockDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageNoMaquina.SuspendLayout()
        CType(Me.grxNSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePedPendServir.SuspendLayout()
        CType(Me.grxPedPendServir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCompras.SuspendLayout()
        CType(Me.grxPedidoCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAlbPdteActualizar.SuspendLayout()
        CType(Me.grxAlbaranesCompraPdtes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFiltroAlbaranes.suspendlayout()
        Me.TabPageDispNoMaquinas.SuspendLayout()
        CType(Me.grxDispNumMaquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDispComponentes.SuspendLayout()
        CType(Me.grxDispComponentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEstructura.suspendlayout()
        Me.TabPageDispAlternativas.SuspendLayout()
        CType(Me.grxAlternativas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ExecuteQuery
        '
        Me.ExecuteQuery.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(298, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TabConsultas)
        Me.MainPanel.Controls.Add(Me.topPanel)
        Me.MainPanel.Size = New System.Drawing.Size(760, 405)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(760, 405)
        '
        'topPanel
        '
        Me.topPanel.Controls.Add(Me.AdvIDArticulo)
        Me.topPanel.Controls.Add(Me.AdvIDAlmacen)
        Me.topPanel.Controls.Add(Me.FraInfoResumen)
        Me.topPanel.Controls.Add(Me.ulAlmacen)
        Me.topPanel.Controls.Add(Me.lblAlmacen)
        Me.topPanel.Controls.Add(Me.lblArticulo)
        Me.topPanel.Controls.Add(Me.ulArticulo)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(760, 132)
        Me.topPanel.TabIndex = 1
        '
        'AdvIDArticulo
        '
        Me.AdvIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDArticulo.EntityName = "Articulo"
        Me.AdvIDArticulo.Location = New System.Drawing.Point(72, 6)
        Me.AdvIDArticulo.Name = "AdvIDArticulo"
        Me.AdvIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvIDArticulo.Size = New System.Drawing.Size(120, 23)
        Me.AdvIDArticulo.TabIndex = 8
        Me.AdvIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'AdvIDAlmacen
        '
        Me.AdvIDAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDAlmacen.EntityName = "Almacen"
        Me.AdvIDAlmacen.Location = New System.Drawing.Point(72, 32)
        Me.AdvIDAlmacen.Name = "AdvIDAlmacen"
        Me.AdvIDAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.AdvIDAlmacen.Size = New System.Drawing.Size(120, 23)
        Me.AdvIDAlmacen.TabIndex = 7
        Me.AdvIDAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'FraInfoResumen
        '
        Me.FraInfoResumen.Controls.Add(Me.nbxDispReal)
        Me.FraInfoResumen.Controls.Add(Me.lblDispReal)
        Me.FraInfoResumen.Controls.Add(Me.nbxMantenimiento)
        Me.FraInfoResumen.Controls.Add(Me.lblMantenimiento)
        Me.FraInfoResumen.Controls.Add(Me.nbxPdteServir)
        Me.FraInfoResumen.Controls.Add(Me.lblPdteServir)
        Me.FraInfoResumen.Controls.Add(Me.nbxNoDisponible)
        Me.FraInfoResumen.Controls.Add(Me.lblNoDisponible)
        Me.FraInfoResumen.Controls.Add(Me.nbxEnCurso)
        Me.FraInfoResumen.Controls.Add(Me.lblEnCurso)
        Me.FraInfoResumen.Controls.Add(Me.nbxEnDeposito)
        Me.FraInfoResumen.Controls.Add(Me.lblEnDeposito)
        Me.FraInfoResumen.Controls.Add(Me.nbxDispTeorico)
        Me.FraInfoResumen.Controls.Add(Me.lblDispTeorico)
        Me.FraInfoResumen.Controls.Add(Me.nbxTotal)
        Me.FraInfoResumen.Controls.Add(Me.lblTotal)
        Me.FraInfoResumen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraInfoResumen.Location = New System.Drawing.Point(0, 60)
        Me.FraInfoResumen.Name = "FraInfoResumen"
        Me.FraInfoResumen.Size = New System.Drawing.Size(760, 72)
        Me.FraInfoResumen.TabIndex = 6
        Me.FraInfoResumen.TabStop = False
        Me.FraInfoResumen.Text = "Información Resumida"
        '
        'nbxDispReal
        '
        Me.nbxDispReal.DisabledBackColor = System.Drawing.Color.White
        Me.nbxDispReal.Enabled = False
        Me.nbxDispReal.Location = New System.Drawing.Point(661, 42)
        Me.nbxDispReal.Name = "nbxDispReal"
        Me.nbxDispReal.ReadOnly = True
        Me.nbxDispReal.Size = New System.Drawing.Size(93, 21)
        Me.nbxDispReal.TabIndex = 15
        '
        'lblDispReal
        '
        Me.lblDispReal.Location = New System.Drawing.Point(569, 46)
        Me.lblDispReal.Name = "lblDispReal"
        Me.lblDispReal.Size = New System.Drawing.Size(95, 13)
        Me.lblDispReal.TabIndex = 14
        Me.lblDispReal.Text = "Disponible Real"
        '
        'nbxMantenimiento
        '
        Me.nbxMantenimiento.DisabledBackColor = System.Drawing.Color.White
        Me.nbxMantenimiento.Enabled = False
        Me.nbxMantenimiento.Location = New System.Drawing.Point(661, 18)
        Me.nbxMantenimiento.Name = "nbxMantenimiento"
        Me.nbxMantenimiento.ReadOnly = True
        Me.nbxMantenimiento.Size = New System.Drawing.Size(93, 21)
        Me.nbxMantenimiento.TabIndex = 13
        '
        'lblMantenimiento
        '
        Me.lblMantenimiento.Location = New System.Drawing.Point(569, 22)
        Me.lblMantenimiento.Name = "lblMantenimiento"
        Me.lblMantenimiento.Size = New System.Drawing.Size(90, 13)
        Me.lblMantenimiento.TabIndex = 12
        Me.lblMantenimiento.Text = "Mantenimiento"
        '
        'nbxPdteServir
        '
        Me.nbxPdteServir.DisabledBackColor = System.Drawing.Color.White
        Me.nbxPdteServir.Enabled = False
        Me.nbxPdteServir.Location = New System.Drawing.Point(471, 42)
        Me.nbxPdteServir.Name = "nbxPdteServir"
        Me.nbxPdteServir.ReadOnly = True
        Me.nbxPdteServir.Size = New System.Drawing.Size(93, 21)
        Me.nbxPdteServir.TabIndex = 11
        '
        'lblPdteServir
        '
        Me.lblPdteServir.Location = New System.Drawing.Point(391, 46)
        Me.lblPdteServir.Name = "lblPdteServir"
        Me.lblPdteServir.Size = New System.Drawing.Size(75, 13)
        Me.lblPdteServir.TabIndex = 10
        Me.lblPdteServir.Text = "Pdte. Servir"
        '
        'nbxNoDisponible
        '
        Me.nbxNoDisponible.DisabledBackColor = System.Drawing.Color.White
        Me.nbxNoDisponible.Enabled = False
        Me.nbxNoDisponible.Location = New System.Drawing.Point(471, 18)
        Me.nbxNoDisponible.Name = "nbxNoDisponible"
        Me.nbxNoDisponible.ReadOnly = True
        Me.nbxNoDisponible.Size = New System.Drawing.Size(93, 21)
        Me.nbxNoDisponible.TabIndex = 9
        '
        'lblNoDisponible
        '
        Me.lblNoDisponible.Location = New System.Drawing.Point(391, 22)
        Me.lblNoDisponible.Name = "lblNoDisponible"
        Me.lblNoDisponible.Size = New System.Drawing.Size(83, 13)
        Me.lblNoDisponible.TabIndex = 8
        Me.lblNoDisponible.Text = "No disponible"
        '
        'nbxEnCurso
        '
        Me.nbxEnCurso.DisabledBackColor = System.Drawing.Color.White
        Me.nbxEnCurso.Enabled = False
        Me.nbxEnCurso.Location = New System.Drawing.Point(290, 42)
        Me.nbxEnCurso.Name = "nbxEnCurso"
        Me.nbxEnCurso.ReadOnly = True
        Me.nbxEnCurso.Size = New System.Drawing.Size(97, 21)
        Me.nbxEnCurso.TabIndex = 7
        '
        'lblEnCurso
        '
        Me.lblEnCurso.Location = New System.Drawing.Point(218, 46)
        Me.lblEnCurso.Name = "lblEnCurso"
        Me.lblEnCurso.Size = New System.Drawing.Size(59, 13)
        Me.lblEnCurso.TabIndex = 6
        Me.lblEnCurso.Text = "En Curso"
        '
        'nbxEnDeposito
        '
        Me.nbxEnDeposito.DisabledBackColor = System.Drawing.Color.White
        Me.nbxEnDeposito.Enabled = False
        Me.nbxEnDeposito.Location = New System.Drawing.Point(290, 18)
        Me.nbxEnDeposito.Name = "nbxEnDeposito"
        Me.nbxEnDeposito.ReadOnly = True
        Me.nbxEnDeposito.Size = New System.Drawing.Size(97, 21)
        Me.nbxEnDeposito.TabIndex = 5
        '
        'lblEnDeposito
        '
        Me.lblEnDeposito.Location = New System.Drawing.Point(218, 22)
        Me.lblEnDeposito.Name = "lblEnDeposito"
        Me.lblEnDeposito.Size = New System.Drawing.Size(75, 13)
        Me.lblEnDeposito.TabIndex = 4
        Me.lblEnDeposito.Text = "En Depósito"
        '
        'nbxDispTeorico
        '
        Me.nbxDispTeorico.DisabledBackColor = System.Drawing.Color.White
        Me.nbxDispTeorico.Enabled = False
        Me.nbxDispTeorico.Location = New System.Drawing.Point(116, 42)
        Me.nbxDispTeorico.Name = "nbxDispTeorico"
        Me.nbxDispTeorico.ReadOnly = True
        Me.nbxDispTeorico.Size = New System.Drawing.Size(97, 21)
        Me.nbxDispTeorico.TabIndex = 3
        '
        'lblDispTeorico
        '
        Me.lblDispTeorico.Location = New System.Drawing.Point(5, 46)
        Me.lblDispTeorico.Name = "lblDispTeorico"
        Me.lblDispTeorico.Size = New System.Drawing.Size(111, 13)
        Me.lblDispTeorico.TabIndex = 2
        Me.lblDispTeorico.Text = "Disponible Teórico"
        '
        'nbxTotal
        '
        Me.nbxTotal.DisabledBackColor = System.Drawing.Color.White
        Me.nbxTotal.Enabled = False
        Me.nbxTotal.Location = New System.Drawing.Point(116, 18)
        Me.nbxTotal.Name = "nbxTotal"
        Me.nbxTotal.ReadOnly = True
        Me.nbxTotal.Size = New System.Drawing.Size(97, 21)
        Me.nbxTotal.TabIndex = 1
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(5, 22)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total"
        '
        'ulAlmacen
        '
        Me.TryDataBinding(ulAlmacen, New System.Windows.Forms.Binding("Text", Me.AdvIDAlmacen, "DescAlmacen", True))
        Me.ulAlmacen.Location = New System.Drawing.Point(196, 34)
        Me.ulAlmacen.Name = "ulAlmacen"
        Me.ulAlmacen.Size = New System.Drawing.Size(556, 21)
        Me.ulAlmacen.TabIndex = 5
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(8, 39)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblAlmacen.TabIndex = 3
        Me.lblAlmacen.Text = "Almacén"
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(8, 12)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 1
        Me.lblArticulo.Text = "Artículo"
        '
        'ulArticulo
        '
        Me.TryDataBinding(ulArticulo, New System.Windows.Forms.Binding("Text", Me.AdvIDArticulo, "DescArticulo", True))
        Me.ulArticulo.Location = New System.Drawing.Point(196, 8)
        Me.ulArticulo.Name = "ulArticulo"
        Me.ulArticulo.Size = New System.Drawing.Size(556, 21)
        Me.ulArticulo.TabIndex = 0
        '
        'TabConsultas
        '
        Me.TabConsultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabConsultas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabConsultas.Location = New System.Drawing.Point(0, 132)
        Me.TabConsultas.Name = "TabConsultas"
        Me.TabConsultas.Size = New System.Drawing.Size(760, 273)
        Me.TabConsultas.TabIndex = 5
        Me.TabConsultas.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageStockActual, Me.UiTabPage1, Me.TabPageNoMaquina, Me.TabPagePedPendServir, Me.TabPageCompras, Me.TabPageAlbPdteActualizar, Me.TabPageDispNoMaquinas, Me.TabPageDispComponentes, Me.TabPageDispAlternativas})
        Me.TabConsultas.Text = "Disp.de Lotes"
        Me.TabConsultas.UseThemes = True
        '
        'TabPageStockActual
        '
        Me.TabPageStockActual.Controls.Add(Me.grxStockActual)
        Me.TabPageStockActual.Key = "StockActual"
        Me.TabPageStockActual.Location = New System.Drawing.Point(1, 21)
        Me.TabPageStockActual.Name = "TabPageStockActual"
        Me.TabPageStockActual.Size = New System.Drawing.Size(758, 251)
        Me.TabPageStockActual.TabStop = True
        Me.TabPageStockActual.Text = "Stock Actual"
        '
        'grxStockActual
        '
        Me.grxStockActual.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxStockActual.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxStockActual.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxStockActual.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grxStockActual_DesignTimeLayout.LayoutString = resources.GetString("grxStockActual_DesignTimeLayout.LayoutString")
        Me.grxStockActual.DesignTimeLayout = grxStockActual_DesignTimeLayout
        Me.grxStockActual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grxStockActual.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.grxStockActual.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grxStockActual.EntityName = ""
        Me.grxStockActual.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.grxStockActual.Location = New System.Drawing.Point(0, 0)
        Me.grxStockActual.Name = "grxStockActual"
        Me.grxStockActual.PrimaryDataFields = ""
        Me.grxStockActual.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxStockActual.SecondaryDataFields = ""
        Me.grxStockActual.Size = New System.Drawing.Size(758, 251)
        Me.grxStockActual.TabIndex = 21
        Me.grxStockActual.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grxStockActual.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grxStockActual.ViewName = "vAlquilerCIDisponibilidadAlquiler"
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.grxStockDeposito)
        Me.UiTabPage1.Key = "StockDeposito"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(758, 251)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Stock Depósito"
        '
        'grxStockDeposito
        '
        Me.grxStockDeposito.AcceptsEscape = False
        Me.grxStockDeposito.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxStockDeposito.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxStockDeposito.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxStockDeposito.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grxStockDeposito_DesignTimeLayout.LayoutString = resources.GetString("grxStockDeposito_DesignTimeLayout.LayoutString")
        Me.grxStockDeposito.DesignTimeLayout = grxStockDeposito_DesignTimeLayout
        Me.grxStockDeposito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grxStockDeposito.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.grxStockDeposito.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grxStockDeposito.EntityName = ""
        Me.grxStockDeposito.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.grxStockDeposito.Location = New System.Drawing.Point(0, 0)
        Me.grxStockDeposito.Name = "grxStockDeposito"
        Me.grxStockDeposito.PrimaryDataFields = ""
        Me.grxStockDeposito.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxStockDeposito.SecondaryDataFields = ""
        Me.grxStockDeposito.Size = New System.Drawing.Size(758, 251)
        Me.grxStockDeposito.TabIndex = 19
        Me.grxStockDeposito.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grxStockDeposito.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grxStockDeposito.ViewName = "vAlquilerCIDisponibilidadAlquiler"
        '
        'TabPageNoMaquina
        '
        Me.TabPageNoMaquina.Controls.Add(Me.grxNSerie)
        Me.TabPageNoMaquina.Key = "NoMaquina"
        Me.TabPageNoMaquina.Location = New System.Drawing.Point(1, 21)
        Me.TabPageNoMaquina.Name = "TabPageNoMaquina"
        Me.TabPageNoMaquina.Size = New System.Drawing.Size(758, 251)
        Me.TabPageNoMaquina.TabStop = True
        Me.TabPageNoMaquina.Text = "Nº Serie"
        Me.TabPageNoMaquina.Visible = False
        '
        'grxNSerie
        '
        Me.grxNSerie.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxNSerie.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxNSerie.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        grxNSerie_DesignTimeLayout.LayoutString = resources.GetString("grxNSerie_DesignTimeLayout.LayoutString")
        Me.grxNSerie.DesignTimeLayout = grxNSerie_DesignTimeLayout
        Me.grxNSerie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grxNSerie.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grxNSerie.EntityName = Nothing
        Me.grxNSerie.Location = New System.Drawing.Point(0, 0)
        Me.grxNSerie.Name = "grxNSerie"
        Me.grxNSerie.PrimaryDataFields = Nothing
        Me.grxNSerie.SecondaryDataFields = Nothing
        Me.grxNSerie.Size = New System.Drawing.Size(758, 251)
        Me.grxNSerie.TabIndex = 3
        Me.grxNSerie.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grxNSerie.ViewName = "vFrmDesgloseNumeroDeSerie"
        '
        'TabPagePedPendServir
        '
        Me.TabPagePedPendServir.Controls.Add(Me.grxPedPendServir)
        Me.TabPagePedPendServir.Key = "PedPendientesServir"
        Me.TabPagePedPendServir.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePedPendServir.Name = "TabPagePedPendServir"
        Me.TabPagePedPendServir.Size = New System.Drawing.Size(758, 251)
        Me.TabPagePedPendServir.TabStop = True
        Me.TabPagePedPendServir.Text = "Ped. Pend. Servir"
        Me.TabPagePedPendServir.Visible = False
        '
        'grxPedPendServir
        '
        Me.grxPedPendServir.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxPedPendServir.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxPedPendServir.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        grxPedPendServir_DesignTimeLayout.LayoutString = resources.GetString("grxPedPendServir_DesignTimeLayout.LayoutString")
        Me.grxPedPendServir.DesignTimeLayout = grxPedPendServir_DesignTimeLayout
        Me.grxPedPendServir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grxPedPendServir.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.grxPedPendServir.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grxPedPendServir.EntityName = Nothing
        Me.grxPedPendServir.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.grxPedPendServir.Location = New System.Drawing.Point(0, 0)
        Me.grxPedPendServir.Name = "grxPedPendServir"
        Me.grxPedPendServir.PrimaryDataFields = Nothing
        Me.grxPedPendServir.SecondaryDataFields = Nothing
        Me.grxPedPendServir.Size = New System.Drawing.Size(758, 251)
        Me.grxPedPendServir.TabIndex = 0
        Me.grxPedPendServir.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grxPedPendServir.ViewName = "VFrmMntoDispObraPendiente"
        '
        'TabPageCompras
        '
        Me.TabPageCompras.Controls.Add(Me.grxPedidoCompra)
        Me.TabPageCompras.Key = "Compras"
        Me.TabPageCompras.Location = New System.Drawing.Point(1, 21)
        Me.TabPageCompras.Name = "TabPageCompras"
        Me.TabPageCompras.Size = New System.Drawing.Size(758, 251)
        Me.TabPageCompras.TabStop = True
        Me.TabPageCompras.Text = "Compras"
        Me.TabPageCompras.Visible = False
        '
        'grxPedidoCompra
        '
        Me.grxPedidoCompra.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxPedidoCompra.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxPedidoCompra.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        grxPedidoCompra_DesignTimeLayout.LayoutString = resources.GetString("grxPedidoCompra_DesignTimeLayout.LayoutString")
        Me.grxPedidoCompra.DesignTimeLayout = grxPedidoCompra_DesignTimeLayout
        Me.grxPedidoCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grxPedidoCompra.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.grxPedidoCompra.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grxPedidoCompra.EntityName = Nothing
        Me.grxPedidoCompra.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grxPedidoCompra.Location = New System.Drawing.Point(0, 0)
        Me.grxPedidoCompra.Name = "grxPedidoCompra"
        Me.grxPedidoCompra.PrimaryDataFields = Nothing
        Me.grxPedidoCompra.SecondaryDataFields = Nothing
        Me.grxPedidoCompra.Size = New System.Drawing.Size(758, 251)
        Me.grxPedidoCompra.TabIndex = 0
        Me.grxPedidoCompra.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grxPedidoCompra.ViewName = "VCtlCIDisponibilidadPedidoCompra"
        '
        'TabPageAlbPdteActualizar
        '
        Me.TabPageAlbPdteActualizar.Controls.Add(Me.grxAlbaranesCompraPdtes)
        Me.TabPageAlbPdteActualizar.Controls.Add(Me.pnlFiltroAlbaranes)
        Me.TabPageAlbPdteActualizar.Key = "AlbPdteActualizar"
        Me.TabPageAlbPdteActualizar.Location = New System.Drawing.Point(1, 21)
        Me.TabPageAlbPdteActualizar.Name = "TabPageAlbPdteActualizar"
        Me.TabPageAlbPdteActualizar.Size = New System.Drawing.Size(758, 251)
        Me.TabPageAlbPdteActualizar.TabStop = True
        Me.TabPageAlbPdteActualizar.Text = "Alb. Pend. Actualizar"
        Me.TabPageAlbPdteActualizar.Visible = False
        '
        'grxAlbaranesCompraPdtes
        '
        Me.grxAlbaranesCompraPdtes.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxAlbaranesCompraPdtes.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxAlbaranesCompraPdtes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        grxAlbaranesCompraPdtes_DesignTimeLayout.LayoutString = resources.GetString("grxAlbaranesCompraPdtes_DesignTimeLayout.LayoutString")
        Me.grxAlbaranesCompraPdtes.DesignTimeLayout = grxAlbaranesCompraPdtes_DesignTimeLayout
        Me.grxAlbaranesCompraPdtes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grxAlbaranesCompraPdtes.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grxAlbaranesCompraPdtes.EntityName = Nothing
        Me.grxAlbaranesCompraPdtes.Location = New System.Drawing.Point(0, 0)
        Me.grxAlbaranesCompraPdtes.Name = "grxAlbaranesCompraPdtes"
        Me.grxAlbaranesCompraPdtes.PrimaryDataFields = Nothing
        Me.grxAlbaranesCompraPdtes.SecondaryDataFields = Nothing
        Me.grxAlbaranesCompraPdtes.Size = New System.Drawing.Size(758, 195)
        Me.grxAlbaranesCompraPdtes.TabIndex = 1
        Me.grxAlbaranesCompraPdtes.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grxAlbaranesCompraPdtes.ViewName = "VFrmCIAlbaranCompraPdte"
        '
        'pnlFiltroAlbaranes
        '
        Me.pnlFiltroAlbaranes.Controls.Add(Me.cbxFechaHasta)
        Me.pnlFiltroAlbaranes.Controls.Add(Me.cbxFechaDesde)
        Me.pnlFiltroAlbaranes.Controls.Add(Me.lblFechaHasta)
        Me.pnlFiltroAlbaranes.Controls.Add(Me.lblFechaDesde)
        Me.pnlFiltroAlbaranes.Controls.Add(Me.ulblProveedor)
        Me.pnlFiltroAlbaranes.Controls.Add(Me.lblProveedor)
        Me.pnlFiltroAlbaranes.Controls.Add(Me.AdvProveedor)
        Me.pnlFiltroAlbaranes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFiltroAlbaranes.Location = New System.Drawing.Point(0, 195)
        Me.pnlFiltroAlbaranes.Name = "pnlFiltroAlbaranes"
        Me.pnlFiltroAlbaranes.Size = New System.Drawing.Size(758, 56)
        Me.pnlFiltroAlbaranes.TabIndex = 0
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(629, 31)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(120, 21)
        Me.cbxFechaHasta.TabIndex = 6
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(629, 5)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(120, 21)
        Me.cbxFechaDesde.TabIndex = 5
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(547, 33)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 4
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(547, 7)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 3
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'ulblProveedor
        '
        Me.TryDataBinding(ulblProveedor, New System.Windows.Forms.Binding("Text", Me.AdvProveedor, "DescProveedor", True))
        Me.ulblProveedor.Location = New System.Drawing.Point(187, 14)
        Me.ulblProveedor.Name = "ulblProveedor"
        Me.ulblProveedor.Size = New System.Drawing.Size(296, 24)
        Me.ulblProveedor.TabIndex = 2
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(8, 18)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblProveedor.TabIndex = 1
        Me.lblProveedor.Text = "Proveedor"
        '
        'AdvProveedor
        '
        Me.AdvProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvProveedor.EntityName = "Proveedor"
        Me.AdvProveedor.Location = New System.Drawing.Point(74, 16)
        Me.AdvProveedor.Name = "AdvProveedor"
        Me.AdvProveedor.SecondaryDataFields = "IDProveedor"
        Me.AdvProveedor.Size = New System.Drawing.Size(112, 23)
        Me.AdvProveedor.TabIndex = 0
        Me.AdvProveedor.ViewName = "tbMaestroProveedor"
        '
        'TabPageDispNoMaquinas
        '
        Me.TabPageDispNoMaquinas.Controls.Add(Me.grxDispNumMaquinas)
        Me.TabPageDispNoMaquinas.Key = "DispNoMaquinas"
        Me.TabPageDispNoMaquinas.Location = New System.Drawing.Point(1, 21)
        Me.TabPageDispNoMaquinas.Name = "TabPageDispNoMaquinas"
        Me.TabPageDispNoMaquinas.Size = New System.Drawing.Size(758, 251)
        Me.TabPageDispNoMaquinas.TabStop = True
        Me.TabPageDispNoMaquinas.Text = "Disp. de Activos"
        Me.TabPageDispNoMaquinas.Visible = False
        '
        'grxDispNumMaquinas
        '
        Me.grxDispNumMaquinas.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxDispNumMaquinas.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxDispNumMaquinas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        grxDispNumMaquinas_DesignTimeLayout.LayoutString = resources.GetString("grxDispNumMaquinas_DesignTimeLayout.LayoutString")
        Me.grxDispNumMaquinas.DesignTimeLayout = grxDispNumMaquinas_DesignTimeLayout
        Me.grxDispNumMaquinas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grxDispNumMaquinas.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.grxDispNumMaquinas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grxDispNumMaquinas.EntityName = Nothing
        Me.grxDispNumMaquinas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grxDispNumMaquinas.Location = New System.Drawing.Point(0, 0)
        Me.grxDispNumMaquinas.Name = "grxDispNumMaquinas"
        Me.grxDispNumMaquinas.PrimaryDataFields = Nothing
        Me.grxDispNumMaquinas.SecondaryDataFields = Nothing
        Me.grxDispNumMaquinas.Size = New System.Drawing.Size(758, 251)
        Me.grxDispNumMaquinas.TabIndex = 0
        Me.grxDispNumMaquinas.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grxDispNumMaquinas.ViewName = "VfrmMntoDisponibilidadLotes"
        '
        'TabPageDispComponentes
        '
        Me.TabPageDispComponentes.Controls.Add(Me.grxDispComponentes)
        Me.TabPageDispComponentes.Controls.Add(Me.pnlEstructura)
        Me.TabPageDispComponentes.Key = "DispComponentes"
        Me.TabPageDispComponentes.Location = New System.Drawing.Point(1, 21)
        Me.TabPageDispComponentes.Name = "TabPageDispComponentes"
        Me.TabPageDispComponentes.Size = New System.Drawing.Size(758, 251)
        Me.TabPageDispComponentes.TabStop = True
        Me.TabPageDispComponentes.Text = "Disp. Componentes"
        '
        'grxDispComponentes
        '
        Me.grxDispComponentes.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxDispComponentes.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxDispComponentes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        grxDispComponentes_DesignTimeLayout.LayoutString = resources.GetString("grxDispComponentes_DesignTimeLayout.LayoutString")
        Me.grxDispComponentes.DesignTimeLayout = grxDispComponentes_DesignTimeLayout
        Me.grxDispComponentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grxDispComponentes.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.grxDispComponentes.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grxDispComponentes.EntityName = Nothing
        Me.grxDispComponentes.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.grxDispComponentes.Location = New System.Drawing.Point(0, 40)
        Me.grxDispComponentes.Name = "grxDispComponentes"
        Me.grxDispComponentes.PrimaryDataFields = Nothing
        Me.grxDispComponentes.SecondaryDataFields = Nothing
        Me.grxDispComponentes.Size = New System.Drawing.Size(758, 211)
        Me.grxDispComponentes.TabIndex = 6
        Me.grxDispComponentes.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grxDispComponentes.ViewName = "vCTLCIDisponibilidadEstructuras"
        '
        'pnlEstructura
        '
        Me.pnlEstructura.Controls.Add(Me.AdvEstructura)
        Me.pnlEstructura.Controls.Add(Me.lblEstructura)
        Me.pnlEstructura.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEstructura.Location = New System.Drawing.Point(0, 0)
        Me.pnlEstructura.Name = "pnlEstructura"
        Me.pnlEstructura.Size = New System.Drawing.Size(758, 40)
        Me.pnlEstructura.TabIndex = 5
        '
        'AdvEstructura
        '
        Me.AdvEstructura.DisabledBackColor = System.Drawing.Color.White
        Me.AdvEstructura.EntityName = "ArticuloEstructura"
        Me.AdvEstructura.Location = New System.Drawing.Point(79, 8)
        Me.AdvEstructura.Name = "AdvEstructura"
        Me.AdvEstructura.SecondaryDataFields = "IDEstructura"
        Me.AdvEstructura.Size = New System.Drawing.Size(112, 23)
        Me.AdvEstructura.TabIndex = 6
        Me.AdvEstructura.ViewName = "cmbArticuloEstructura"
        '
        'lblEstructura
        '
        Me.lblEstructura.Location = New System.Drawing.Point(8, 8)
        Me.lblEstructura.Name = "lblEstructura"
        Me.lblEstructura.Size = New System.Drawing.Size(65, 13)
        Me.lblEstructura.TabIndex = 4
        Me.lblEstructura.Text = "Estructura"
        '
        'TabPageDispAlternativas
        '
        Me.TabPageDispAlternativas.Controls.Add(Me.grxAlternativas)
        Me.TabPageDispAlternativas.Key = "DispAlternativas"
        Me.TabPageDispAlternativas.Location = New System.Drawing.Point(1, 21)
        Me.TabPageDispAlternativas.Name = "TabPageDispAlternativas"
        Me.TabPageDispAlternativas.Size = New System.Drawing.Size(758, 251)
        Me.TabPageDispAlternativas.TabStop = True
        Me.TabPageDispAlternativas.Text = "Disp. Alternativas"
        Me.TabPageDispAlternativas.Visible = False
        '
        'grxAlternativas
        '
        Me.grxAlternativas.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxAlternativas.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grxAlternativas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        grxAlternativas_DesignTimeLayout.LayoutString = resources.GetString("grxAlternativas_DesignTimeLayout.LayoutString")
        Me.grxAlternativas.DesignTimeLayout = grxAlternativas_DesignTimeLayout
        Me.grxAlternativas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grxAlternativas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grxAlternativas.EntityName = Nothing
        Me.grxAlternativas.Location = New System.Drawing.Point(0, 0)
        Me.grxAlternativas.Name = "grxAlternativas"
        Me.grxAlternativas.PrimaryDataFields = Nothing
        Me.grxAlternativas.SecondaryDataFields = Nothing
        Me.grxAlternativas.Size = New System.Drawing.Size(758, 251)
        Me.grxAlternativas.TabIndex = 0
        Me.grxAlternativas.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grxAlternativas.ViewName = "VCtlCIDisponibilidadAlternativas"
        '
        'MntoDisponibilidadAlquileres
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(768, 493)
        Me.EntityName = ""
        Me.Name = "MntoDisponibilidadAlquileres"
        Me.Text = "MntoDisponibilidadAlquileres"
        Me.ViewName = "vAlquilerCIDisponibilidadAlquiler"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.topPanel.ResumeLayout(False)
        Me.topPanel.PerformLayout()
        Me.FraInfoResumen.ResumeLayout(False)
        Me.FraInfoResumen.PerformLayout()
        CType(Me.TabConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConsultas.ResumeLayout(False)
        Me.TabPageStockActual.ResumeLayout(False)
        CType(Me.grxStockActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage1.ResumeLayout(False)
        CType(Me.grxStockDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageNoMaquina.ResumeLayout(False)
        CType(Me.grxNSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePedPendServir.ResumeLayout(False)
        CType(Me.grxPedPendServir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCompras.ResumeLayout(False)
        CType(Me.grxPedidoCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAlbPdteActualizar.ResumeLayout(False)
        CType(Me.grxAlbaranesCompraPdtes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFiltroAlbaranes.ResumeLayout(False)
        Me.pnlFiltroAlbaranes.PerformLayout()
        Me.TabPageDispNoMaquinas.ResumeLayout(False)
        CType(Me.grxDispNumMaquinas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDispComponentes.ResumeLayout(False)
        CType(Me.grxDispComponentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEstructura.ResumeLayout(False)
        Me.pnlEstructura.PerformLayout()
        Me.TabPageDispAlternativas.ResumeLayout(False)
        CType(Me.grxAlternativas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mblnExecuteQuery As Boolean
    Private mstrAlmacenPredeterminado As String

#Region " Carga del formulario "

    Private Sub MntoDisponibilidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadEnums()
            LoadERPData()
            LoadGridStyles()
            LoadFormActions()
            LoadGridActions()
            mblnExecuteQuery = True
            LoadParams()
        End If
    End Sub

    Private Sub LoadERPData()
        mstrAlmacenPredeterminado = New Parametro().AlmacenPredeterminado
    End Sub

    Private Sub LoadFormActions()
        Me.FormActions.Clear()
        Me.FormActions.Add("Calcular Resumen", AddressOf AccionCalcularResumen)

        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.True
    End Sub

    Private Sub LoadGridActions()
        grxNSerie.Actions.Add(cnABRRIRACTIVO, AddressOf AccionGridAbrirActivo)

        grxPedPendServir.Actions.Add(cnABRIRORDENSERVICIO, AddressOf AccionGridAbrirOrdenServicio)
        grxPedPendServir.Actions.Add(cnABRIRALQUILER, AddressOf AccionGridAbrirObra)

        grxPedidoCompra.Actions.Add("Abrir Pedido", AddressOf AccionGridAbrirPedidoCompra)

        grxAlbaranesCompraPdtes.Actions.Add("Abrir Albarán Compra", AddressOf AccionGridAbrirAlbaranCompra)

        grxDispComponentes.Actions.Add("Abrir Componente", AddressOf AccionGridAbrirComponente)

        grxAlternativas.Actions.Add("Abrir Artículo Alternativo", AddressOf AccionGridAbrirArticuloAlternativo)
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            Dim HtParam As Hashtable = Me.Params
            If HtParam.ContainsKey("IDArticulo") AndAlso Length(HtParam("IDArticulo")) > 0 Then
                AdvIDArticulo.Text = HtParam("IDArticulo")
            End If
            If HtParam.ContainsKey("IDAlmacen") AndAlso Length(HtParam("IDAlmacen")) > 0 Then
                AdvIDAlmacen.Text = HtParam("IDAlmacen")
            End If
            AccionCalcularResumen()
        End If
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumpclEstado", grxPedidoCompra.Columns("Estado"))
    End Sub

    Private Sub LoadGridStyles()
        Dim dtEstados As DataTable = New MntoEstadoActivo().Filter()
        If Not IsNothing(dtEstados) AndAlso dtEstados.Rows.Count > 0 Then
            GridFormatStyle.CrearFormatos(grxNSerie, dtEstados, GridFormatStyle.TipoFormato.EstadoActivo, True)
        End If
    End Sub

#End Region

#Region " Toolbar Actions "

    Public Sub AccionCalcularResumen()
        If Length(AdvIDArticulo.Text) = 0 Then
            ExpertisApp.GenerateMessage("Es necesario introducir un artículo.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AdvIDArticulo.Focus()
        Else
            Me.Cursor = Cursors.WaitCursor
            Dim Disponibilidad As dataDisponibilidadArticuloAlquiler = ExpertisApp.ExecuteTask(Of String, dataDisponibilidadArticuloAlquiler)(AddressOf ArticuloAlmacen.CalcularResumenDisponibilidadAlquiler, AdvIDArticulo.Text)
            nbxTotal.Value = Disponibilidad.StockTotal
            nbxEnDeposito.Value = Disponibilidad.StockTotalDeposito
            nbxNoDisponible.Value = Disponibilidad.StockNoDisponible
            nbxMantenimiento.Value = Disponibilidad.EnMantenimiento
            nbxDispTeorico.Value = Disponibilidad.DisponibleTeorico
            nbxPdteServir.Value = Disponibilidad.PendienteEnObra
            nbxEnCurso.Value = Disponibilidad.PedidoCompraPendiente + Disponibilidad.PendienteActualizarCompra
            nbxDispReal.Value = Disponibilidad.DisponibleReal
            Me.Execute()
            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region " Grid Actions "

    Private Const cnMNTO_ACTIVO As String = "MACT"
    Private Const cnMNTO_OBRA_ALQ As String = "OBALQUILER"
    Private Const cnMNTO_ORDEN_SERVICIO_ALQ As String = "MGEOTRALQ"
    Private Const cnMNTO_ALBARAN_COMPRA As String = "MALBC"
    Private Const cnMNTO_PEDIDO_COMPRA As String = "MPEDC"
    Private Const cnMNTO_ARTICULO As String = "MARTICULO"

    Private Sub AccionGridAbrirActivo()
        With grxNSerie
            If Length(.Value("IDActivo")) > 0 Then
                'If ExpertisApp.IsFormOpen(cnMNTO_ACTIVO) Then ExpertisApp.CloseForm(cnMNTO_ACTIVO)
                ExpertisApp.OpenForm(cnMNTO_ACTIVO, New StringFilterItem("IDActivo", .Value("IDActivo")))
            End If
        End With
    End Sub

    Private Sub AccionGridAbrirObra()
        With grxPedPendServir
            If Length(.Value("IDObra")) > 0 Then
                'If ExpertisApp.IsFormOpen(cnMNTO_OBRA_ALQ) Then ExpertisApp.CloseForm(cnMNTO_OBRA_ALQ)
                ExpertisApp.OpenForm(cnMNTO_OBRA_ALQ, New NumberFilterItem("IDObra", .Value("IDObra")))
            End If
        End With
    End Sub

    Private Sub AccionGridAbrirOrdenServicio()
        With grxPedPendServir
            If Length(.Value("IDTrabajo")) > 0 Then
                'If ExpertisApp.IsFormOpen(cnMNTO_ORDEN_SERVICIO_ALQ) Then ExpertisApp.CloseForm(cnMNTO_ORDEN_SERVICIO_ALQ)
                ExpertisApp.OpenForm(cnMNTO_ORDEN_SERVICIO_ALQ, New NumberFilterItem("IDTrabajo", .Value("IDTrabajo")))
            End If
        End With
    End Sub

    Private Sub AccionGridAbrirPedidoCompra()
        With grxPedidoCompra
            If Length(.Value("IDPedido")) > 0 Then
                'If ExpertisApp.IsFormOpen(cnMNTO_PEDIDO_COMPRA) Then ExpertisApp.CloseForm(cnMNTO_PEDIDO_COMPRA)
                ExpertisApp.OpenForm(cnMNTO_PEDIDO_COMPRA, New NumberFilterItem("IDPedido", .Value("IDPedido")))
            End If
        End With
    End Sub

    Private Sub AccionGridAbrirAlbaranCompra()
        With grxAlbaranesCompraPdtes
            If Length(.Value("IDAlbaran")) > 0 Then
                'If ExpertisApp.IsFormOpen(cnMNTO_ALBARAN_COMPRA) Then ExpertisApp.CloseForm(cnMNTO_ALBARAN_COMPRA)
                ExpertisApp.OpenForm(cnMNTO_ALBARAN_COMPRA, New NumberFilterItem("IDAlbaran", .Value("IDAlbaran")))
            End If
        End With
    End Sub

    Private Sub AccionGridAbrirComponente()
        With grxDispComponentes
            '.Actions.Add("Abrir Componente", AddressOf AccionGridAbrirComponente)
            If Length(.Value("IDComponente")) > 0 Then
                'If ExpertisApp.IsFormOpen(cnMNTO_ARTICULO) Then ExpertisApp.CloseForm(cnMNTO_ARTICULO)
                ExpertisApp.OpenForm(cnMNTO_ARTICULO, New StringFilterItem("IDArticulo", .Value("IDComponente")))
            End If
        End With
    End Sub

    Private Sub AccionGridAbrirArticuloAlternativo()
        With grxAlternativas
            If Length(.Value("IDArticuloAlternativo")) > 0 Then
                'If ExpertisApp.IsFormOpen(cnMNTO_ARTICULO) Then ExpertisApp.CloseForm(cnMNTO_ARTICULO)
                ExpertisApp.OpenForm(cnMNTO_ARTICULO, New StringFilterItem("IDArticulo", .Value("IDArticuloAlternativo")))
            End If
        End With
    End Sub

#End Region

#Region " Formateo Grids "

    Private Sub grxNSerie_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles grxNSerie.FormattingRow
        If Length(e.Row.Cells("IDEstadoActivo").Value) > 0 Then
            e.Row.RowStyle = grxNSerie.FormatStyles("FMT" & e.Row.Cells("IDEstadoActivo").Value)
        End If
    End Sub

#End Region

#Region " Tab "

    Private Sub TabConsultas_SelectedTabChanged(ByVal sender As Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles TabConsultas.SelectedTabChanged
        Select Case TabConsultas.SelectedTab.Key
            Case "StockActual"
                Me.CIPrimaryObject = Me.grxStockActual
            Case "StockDeposito"
                Me.CIPrimaryObject = Me.grxStockDeposito
            Case "NoMaquina"
                Me.CIPrimaryObject = Me.grxNSerie
            Case "PedPendientesServir"
                Me.CIPrimaryObject = Me.grxPedPendServir
            Case "Compras"
                Me.CIPrimaryObject = Me.grxPedidoCompra
            Case "AlbPdteActualizar"
                Me.CIPrimaryObject = Me.grxAlbaranesCompraPdtes
            Case "DispNoMaquinas"
                Me.CIPrimaryObject = Me.grxDispNumMaquinas
            Case "DispComponentes"
                Me.CIPrimaryObject = Me.grxDispComponentes
            Case "DispAlternativas"
                Me.CIPrimaryObject = Me.grxAlternativas
        End Select
    End Sub

#End Region

#Region " Consulta Interactiva, Filtros.... "

    Private Sub MntoDisponibilidadAlquileres_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        '//Con mblnExecuteQuery controlamos que sólo se ejecute la consulta cuando tenemos la pantalla cargada.
        If Not mblnExecuteQuery Then e.Cancel = True : Exit Sub
        If Length(AdvIDArticulo.Text) = 0 Then
            e.Cancel = True
            Exit Sub
        End If

        Dim strCampoArticulo As String = "IDArticulo"
        Select Case TabConsultas.SelectedTab.Key
            Case "PedPendientesServir"
                strCampoArticulo = "IDMaterial"
        End Select

        e.Filter.Add(New StringFilterItem(strCampoArticulo, AdvIDArticulo.Text))
        If Length(AdvIDAlmacen.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDAlmacen", AdvIDAlmacen.Text))
        End If

        Dim objFilterOR As New Filter(FilterUnionOperator.Or)
        Dim objFilter As New Filter
        Select Case TabConsultas.SelectedTab.Key
            Case "StockActual"
                e.Filter.Add(New BooleanFilterItem("Deposito", False))
            Case "StockDeposito"
                e.Filter.Add(New BooleanFilterItem("Deposito", True))
                objFilterOR.Add(New NumberFilterItem("QPteCompra", FilterOperator.NotEqual, 0))
                objFilter.Add(New NumberFilterItem("QPteCompra", 0))
                objFilter.Add(New NumberFilterItem("StockFisico", 0))
                objFilterOR.Add(objFilter)
                e.Filter.Add(objFilterOR)
                e.Filter.Add(New NumberFilterItem("QPendienteObra", FilterOperator.NotEqual, 0))
            Case "AlbPdteActualizar"
                If Length(AdvProveedor.Text) > 0 Then
                    e.Filter.Add(New StringFilterItem("IDProveedor", AdvProveedor.Text))
                End If
                If Length(cbxFechaDesde.Value) > 0 Then
                    e.Filter.Add(New DateFilterItem("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value))
                End If
                If Length(cbxFechaHasta.Value) > 0 Then
                    e.Filter.Add(New DateFilterItem("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value))
                End If
            Case "DispComponentes"
                If Length(AdvEstructura.Text) > 0 Then
                    e.Filter.Add(New StringFilterItem("IDEstructura", AdvEstructura.Text))
                End If
        End Select
    End Sub

    Private Sub MntoDisponibilidadAlquileres_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        AdvIDArticulo.Text = Nothing
        AdvIDAlmacen.Text = Nothing
        AdvEstructura.Text = Nothing

        AdvProveedor.Value = Nothing
        cbxFechaDesde.Value = Nothing
        cbxFechaHasta.Value = Nothing

        nbxTotal.Value = 0
        nbxEnDeposito.Value = 0
        nbxNoDisponible.Value = 0
        nbxMantenimiento.Value = 0
        nbxDispTeorico.Value = 0
        nbxPdteServir.Value = 0
        nbxEnCurso.Value = 0
        nbxDispReal.Value = 0
    End Sub

    Private Sub AdvIDArticulo_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDArticulo.SelectionChanged
        AlmacenPredeterminadoArticulo()
        EstructuraPrincipal()
        AccionCalcularResumen()
    End Sub
    Private Sub AlmacenPredeterminadoArticulo()
        If Length(AdvIDArticulo.Text) > 0 Then
            Dim data As New DataArtAlm(AdvIDArticulo.Text)
            AdvIDAlmacen.Text = ExpertisApp.ExecuteTask(Of DataArtAlm, String)(AddressOf ArticuloAlmacen.AlmacenPredeterminadoArticulo, data)
            If Length(AdvIDAlmacen.Text) = 0 Then
                AdvIDAlmacen.Text = mstrAlmacenPredeterminado
            End If
        Else
            AdvIDAlmacen.Text = mstrAlmacenPredeterminado
        End If
    End Sub

    Private Sub AdvIDAlmacen_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDAlmacen.SelectionChanged
        Me.Execute()
    End Sub

    Private Sub AdvEstructura_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvEstructura.SetPredefinedFilter
        If Length(AdvIDArticulo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDArticulo", AdvIDArticulo.Text))
        Else
            e.Filter.Add(New StringFilterItem("IDArticulo", String.Empty))
        End If
    End Sub

    Private Sub AdvEstructura_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvEstructura.SelectionChanged
        Me.Execute()
    End Sub

    Private Sub AdvIDAlmacen_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvIDAlmacen.Validated
        If Length(AdvIDAlmacen.Text) = 0 Then
            '//Si quitamos el alamcen filtramos.
            Me.Execute()
        End If
    End Sub

    Private Sub EstructuraPrincipal()
        Dim f As New Filter
        If Length(AdvIDArticulo.Text) > 0 Then
            f.Add(New StringFilterItem("IDArticulo", AdvIDArticulo.Text))
        Else
            f.Add(New StringFilterItem("IDArticulo", String.Empty))
        End If
        f.Add(New BooleanFilterItem("Principal", True))
        Dim dtPrincipal As DataTable = New BE.DataEngine().Filter(AdvEstructura.ViewName, f)
        If Not IsNothing(dtPrincipal) AndAlso dtPrincipal.Rows.Count > 0 Then
            AdvEstructura.Text = dtPrincipal.Rows(0)("IDEstructura")
        Else
            AdvEstructura.Text = Nothing
        End If
    End Sub

#End Region

End Class
