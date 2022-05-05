Public Class CIArticulosAlquilados
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtStockD.Value = System.DBNull.Value

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
    Friend WithEvents txtStockH As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblStockH As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtStockD As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblStockD As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDSubFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblSubFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxArticuloPorLotes As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblArticuloPorLotes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxNSerie As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblNSerie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxArticuloPorLotes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIArticulosAlquilados))
        Dim cbxNSerie_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.txtStockH = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblStockH = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.txtStockD = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblStockD = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDSubFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblSubFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxArticuloPorLotes = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblArticuloPorLotes = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxNSerie = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblNSerie = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxArticuloPorLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxNSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblStockH)
        Me.FilterPanel.Controls.Add(Me.lblFamilia)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblAlmacen)
        Me.FilterPanel.Controls.Add(Me.lblStockD)
        Me.FilterPanel.Controls.Add(Me.lblTipo)
        Me.FilterPanel.Controls.Add(Me.lblSubFamilia)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblArticuloPorLotes)
        Me.FilterPanel.Controls.Add(Me.lblNSerie)
        Me.FilterPanel.Controls.Add(Me.lblArticulo)
        Me.FilterPanel.Controls.Add(Me.txtStockH)
        Me.FilterPanel.Controls.Add(Me.advIDFamilia)
        Me.FilterPanel.Controls.Add(Me.advIDObraHasta)
        Me.FilterPanel.Controls.Add(Me.advIDAlmacen)
        Me.FilterPanel.Controls.Add(Me.txtStockD)
        Me.FilterPanel.Controls.Add(Me.advIDTipo)
        Me.FilterPanel.Controls.Add(Me.advIDSubFamilia)
        Me.FilterPanel.Controls.Add(Me.advIDCliente)
        Me.FilterPanel.Controls.Add(Me.advIDObraDesde)
        Me.FilterPanel.Controls.Add(Me.cbxArticuloPorLotes)
        Me.FilterPanel.Controls.Add(Me.cbxNSerie)
        Me.FilterPanel.Controls.Add(Me.advIDArticulo)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 227)
        Me.FilterPanel.Size = New System.Drawing.Size(721, 118)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(721, 227)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ObraCabecera"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDObra"
        Me.Grid.Size = New System.Drawing.Size(721, 227)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vAlquilerCIConsultaMateriales"
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
        Me.MainPanel.Size = New System.Drawing.Size(721, 345)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(721, 345)
        '
        'txtStockH
        '
        Me.txtStockH.DisabledBackColor = System.Drawing.Color.White
        Me.txtStockH.Location = New System.Drawing.Point(410, 53)
        Me.txtStockH.Name = "txtStockH"
        Me.txtStockH.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtStockH.Size = New System.Drawing.Size(87, 21)
        Me.txtStockH.TabIndex = 7
        '
        'lblStockH
        '
        Me.lblStockH.Location = New System.Drawing.Point(323, 56)
        Me.lblStockH.Name = "lblStockH"
        Me.lblStockH.Size = New System.Drawing.Size(61, 13)
        Me.lblStockH.TabIndex = 0
        Me.lblStockH.Text = "Stock <>"
        '
        'advIDFamilia
        '
        Me.advIDFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDFamilia.EntityName = "Familia"
        Me.advIDFamilia.Location = New System.Drawing.Point(251, 52)
        Me.advIDFamilia.Name = "advIDFamilia"
        Me.advIDFamilia.SecondaryDataFields = "IDFamilia"
        Me.advIDFamilia.Size = New System.Drawing.Size(62, 23)
        Me.advIDFamilia.TabIndex = 4
        Me.advIDFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(179, 56)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(47, 13)
        Me.lblFamilia.TabIndex = 14
        Me.lblFamilia.Text = "Familia"
        '
        'advIDObraHasta
        '
        Me.advIDObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advIDObraHasta.DisplayField = "NObra"
        Me.advIDObraHasta.EntityName = "ObraCabecera"
        Me.advIDObraHasta.Location = New System.Drawing.Point(618, 52)
        Me.advIDObraHasta.Name = "advIDObraHasta"
        Me.advIDObraHasta.SecondaryDataFields = "IDObra"
        Me.advIDObraHasta.Size = New System.Drawing.Size(87, 23)
        Me.advIDObraHasta.TabIndex = 10
        Me.advIDObraHasta.ViewName = "tbObraCabecera"
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(511, 56)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(86, 13)
        Me.lblObraHasta.TabIndex = 16
        Me.lblObraHasta.Text = "Alquiler Hasta"
        '
        'advIDAlmacen
        '
        Me.advIDAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advIDAlmacen.EntityName = "Almacen"
        Me.advIDAlmacen.Location = New System.Drawing.Point(72, 52)
        Me.advIDAlmacen.Name = "advIDAlmacen"
        Me.advIDAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.Size = New System.Drawing.Size(96, 23)
        Me.advIDAlmacen.TabIndex = 1
        Me.advIDAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(15, 56)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblAlmacen.TabIndex = 18
        Me.lblAlmacen.Text = "Almacén"
        '
        'txtStockD
        '
        Me.txtStockD.DisabledBackColor = System.Drawing.Color.White
        Me.txtStockD.Location = New System.Drawing.Point(410, 27)
        Me.txtStockD.Name = "txtStockD"
        Me.txtStockD.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtStockD.Size = New System.Drawing.Size(87, 21)
        Me.txtStockD.TabIndex = 6
        '
        'lblStockD
        '
        Me.lblStockD.Location = New System.Drawing.Point(323, 29)
        Me.lblStockD.Name = "lblStockD"
        Me.lblStockD.Size = New System.Drawing.Size(52, 13)
        Me.lblStockD.TabIndex = 20
        Me.lblStockD.Text = "Stock >"
        '
        'advIDTipo
        '
        Me.advIDTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTipo.EntityName = "TipoArticulo"
        Me.advIDTipo.Location = New System.Drawing.Point(251, 25)
        Me.advIDTipo.Name = "advIDTipo"
        Me.advIDTipo.SecondaryDataFields = "IDTipo"
        Me.advIDTipo.Size = New System.Drawing.Size(62, 23)
        Me.advIDTipo.TabIndex = 3
        Me.advIDTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(179, 29)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 21
        Me.lblTipo.Text = "Tipo"
        '
        'advIDSubFamilia
        '
        Me.advIDSubFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDSubFamilia.EntityName = "Subfamilia"
        Me.advIDSubFamilia.Location = New System.Drawing.Point(251, 79)
        Me.advIDSubFamilia.Name = "advIDSubFamilia"
        Me.advIDSubFamilia.SecondaryDataFields = "IDSubfamilia"
        Me.advIDSubFamilia.Size = New System.Drawing.Size(61, 23)
        Me.advIDSubFamilia.TabIndex = 5
        Me.advIDSubFamilia.ViewName = "tbMaestroSubfamilia"
        '
        'lblSubFamilia
        '
        Me.lblSubFamilia.Location = New System.Drawing.Point(179, 83)
        Me.lblSubFamilia.Name = "lblSubFamilia"
        Me.lblSubFamilia.Size = New System.Drawing.Size(69, 13)
        Me.lblSubFamilia.TabIndex = 23
        Me.lblSubFamilia.Text = "SubFamilia"
        '
        'advIDCliente
        '
        Me.advIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCliente.EntityName = "Cliente"
        Me.advIDCliente.Location = New System.Drawing.Point(72, 79)
        Me.advIDCliente.Name = "advIDCliente"
        Me.advIDCliente.SecondaryDataFields = "IDCliente"
        Me.advIDCliente.Size = New System.Drawing.Size(97, 23)
        Me.advIDCliente.TabIndex = 2
        Me.advIDCliente.ViewName = "tbMaestroCliente"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(14, 84)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 25
        Me.lblCliente.Text = "Cliente"
        '
        'advIDObraDesde
        '
        Me.advIDObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advIDObraDesde.DisplayField = "NObra"
        Me.advIDObraDesde.EntityName = "ObraCabecera"
        Me.advIDObraDesde.Location = New System.Drawing.Point(618, 25)
        Me.advIDObraDesde.Name = "advIDObraDesde"
        Me.advIDObraDesde.SecondaryDataFields = "IDObra"
        Me.advIDObraDesde.Size = New System.Drawing.Size(87, 23)
        Me.advIDObraDesde.TabIndex = 9
        Me.advIDObraDesde.ViewName = "tbObraCabecera"
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(511, 29)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(90, 13)
        Me.lblObraDesde.TabIndex = 27
        Me.lblObraDesde.Text = "Alquiler Desde"
        '
        'cbxArticuloPorLotes
        '
        cbxArticuloPorLotes_DesignTimeLayout.LayoutString = resources.GetString("cbxArticuloPorLotes_DesignTimeLayout.LayoutString")
        Me.cbxArticuloPorLotes.DesignTimeLayout = cbxArticuloPorLotes_DesignTimeLayout
        Me.cbxArticuloPorLotes.DisabledBackColor = System.Drawing.Color.White
        Me.cbxArticuloPorLotes.Location = New System.Drawing.Point(410, 79)
        Me.cbxArticuloPorLotes.Name = "cbxArticuloPorLotes"
        Me.cbxArticuloPorLotes.SelectedIndex = -1
        Me.cbxArticuloPorLotes.SelectedItem = Nothing
        Me.cbxArticuloPorLotes.Size = New System.Drawing.Size(87, 21)
        Me.cbxArticuloPorLotes.TabIndex = 8
        '
        'lblArticuloPorLotes
        '
        Me.lblArticuloPorLotes.Location = New System.Drawing.Point(323, 83)
        Me.lblArticuloPorLotes.Name = "lblArticuloPorLotes"
        Me.lblArticuloPorLotes.Size = New System.Drawing.Size(84, 13)
        Me.lblArticuloPorLotes.TabIndex = 29
        Me.lblArticuloPorLotes.Text = "Gestión Lotes"
        '
        'cbxNSerie
        '
        cbxNSerie_DesignTimeLayout.LayoutString = resources.GetString("cbxNSerie_DesignTimeLayout.LayoutString")
        Me.cbxNSerie.DesignTimeLayout = cbxNSerie_DesignTimeLayout
        Me.cbxNSerie.DisabledBackColor = System.Drawing.Color.White
        Me.cbxNSerie.Location = New System.Drawing.Point(618, 79)
        Me.cbxNSerie.Name = "cbxNSerie"
        Me.cbxNSerie.SelectedIndex = -1
        Me.cbxNSerie.SelectedItem = Nothing
        Me.cbxNSerie.Size = New System.Drawing.Size(87, 21)
        Me.cbxNSerie.TabIndex = 11
        '
        'lblNSerie
        '
        Me.lblNSerie.Location = New System.Drawing.Point(511, 83)
        Me.lblNSerie.Name = "lblNSerie"
        Me.lblNSerie.Size = New System.Drawing.Size(102, 13)
        Me.lblNSerie.TabIndex = 30
        Me.lblNSerie.Text = "Gestión Nº Serie"
        '
        'advIDArticulo
        '
        Me.advIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticulo.EntityName = "Articulo"
        Me.advIDArticulo.Location = New System.Drawing.Point(72, 25)
        Me.advIDArticulo.Name = "advIDArticulo"
        Me.advIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.advIDArticulo.Size = New System.Drawing.Size(96, 23)
        Me.advIDArticulo.TabIndex = 0
        Me.advIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(15, 29)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 31
        Me.lblArticulo.Text = "Artículo"
        '
        'CIArticulosAlquilados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(729, 433)
        Me.EntityName = "ObraCabecera"
        Me.KeyField = "IDObra"
        Me.Name = "CIArticulosAlquilados"
        Me.ShowInTaskbar = True
        Me.ViewName = "vAlquilerCIConsultaMateriales"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxArticuloPorLotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxNSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CIArticulosAlquilados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadParams()
        LoadEnum()
        LoadGridActions()
        InitFilterCriteria()
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            Dim ht As Hashtable = Me.Params
            If ht.ContainsKey("IDCliente") Then
                advIDCliente.Text = ht("IDCliente")
                Me.Execute()
            End If
        End If
    End Sub

    Private Sub LoadEnum()
        cbxArticuloPorLotes.DataSource = New EnumData("enumBoolean")
        cbxNSerie.DataSource = New EnumData("EnumBoolean")
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add(cnABRRIRARTICULO, AddressOf AccionAbrirArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
        Grid.Actions.Add(cnABRIRALQUILER, AddressOf AccionAbrirAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub InitFilterCriteria()
        cbxNSerie.Value = enumBoolean.Todos
        cbxArticuloPorLotes.Value = enumBoolean.Todos
        txtStockH.Value = 0
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirArticulo()
        AbrirMntoArticulo(Grid.Value("IDArticulo"))
    End Sub

    Private Sub AccionAbrirAlquiler()
        AbrirMntoAlquiler(Grid.Value("IDObra"))
    End Sub

#End Region

    Private Sub CIArticulosAlquilados_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDCliente", FilterOperator.Equal, advIDCliente.Text, FilterType.String)
        e.Filter.Add("IDArticulo", FilterOperator.Equal, advIDArticulo.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, advIDTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, advIDFamilia.Text, FilterType.String)
        e.Filter.Add("IDSubFamilia", FilterOperator.Equal, advIDSubFamilia.Text, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, advIDAlmacen.Text, FilterType.String)
        e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, advIDObraDesde.Value, FilterType.Numeric)
        e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, advIDObraHasta.Value, FilterType.Numeric)
        e.Filter.Add("StockFisico", FilterOperator.GreaterThan, txtStockD.Value, FilterType.Numeric)
        e.Filter.Add("StockFisico", FilterOperator.NotEqual, txtStockH.Value, FilterType.Numeric)
        If cbxArticuloPorLotes.Value <> enumBoolean.Todos Then
            e.Filter.Add("GestionStockPorLotes", FilterOperator.Equal, cbxArticuloPorLotes.Value, FilterType.Numeric)
        End If
        If cbxNSerie.Value <> enumBoolean.Todos Then
            e.Filter.Add("NSerieObligatorio", FilterOperator.Equal, cbxNSerie.Value, FilterType.Numeric)
        End If
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)
        InitFilterCriteria()
    End Sub

    Private Sub CIArticulosAlquilados_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        If e.Alias = "ILAPD" Then
            If Length(advIDCliente.Text) > 0 Then e.Filter.Add("IDCliente", FilterOperator.Equal, advIDCliente.Text, FilterType.String)
            If Length(advIDArticulo.Text) > 0 Then e.Filter.Add("IdArticulo", FilterOperator.Equal, advIDArticulo.Text, FilterType.String)
            If Length(advIDTipo.Text) > 0 Then e.Filter.Add("IDTipo", FilterOperator.Equal, advIDTipo.Text, FilterType.String)
            If Length(advIDFamilia.Text) > 0 Then e.Filter.Add("IDFamilia", FilterOperator.Equal, advIDFamilia.Text, FilterType.String)
            If Length(advIDSubFamilia.Text) > 0 Then e.Filter.Add("IDSubFamilia", FilterOperator.Equal, advIDSubFamilia.Text, FilterType.String)
            If Length(advIDAlmacen.Text) > 0 Then e.Filter.Add("IDAlmacen", FilterOperator.Equal, advIDAlmacen.Text, FilterType.String)
            If Length(advIDObraDesde.Text) > 0 Then e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, advIDObraDesde.Value, FilterType.Numeric)
            If Length(advIDObraHasta.Text) > 0 Then e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, advIDObraHasta.Value, FilterType.Numeric)
            If cbxArticuloPorLotes.Value <> enumBoolean.Todos Then
                If Length(cbxArticuloPorLotes.Value) > 0 Then e.Filter.Add("GestionStockPorLotes", FilterOperator.Equal, cbxArticuloPorLotes.Value, FilterType.Boolean)
            End If
            If cbxNSerie.Value <> enumBoolean.Todos Then
                If Length(cbxNSerie.Value) > 0 Then e.Filter.Add("NSerieObligatorio", FilterOperator.Equal, cbxNSerie.Value, FilterType.Boolean)
            End If

        End If
    End Sub

End Class
