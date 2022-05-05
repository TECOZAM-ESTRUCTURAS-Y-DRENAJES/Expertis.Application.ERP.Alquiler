Public Class CIDispAlquileres
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
    Friend WithEvents advIDCentroGestion As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCentroGestion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advNSerie As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblNSerie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxDeposito As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblDeposito As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDSubFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblSubFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxGestionLotes As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblGestionLotes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxGestionNserie As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblGestionNserie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPendiente As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPendiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmdSearchArticulo As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxDeposito_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxGestionLotes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxGestionNserie_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIDispAlquileres))
        Me.advIDCentroGestion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.advNSerie = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblNSerie = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxDeposito = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblDeposito = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDSubFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblSubFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxGestionLotes = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblGestionLotes = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxGestionNserie = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblGestionNserie = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPendiente = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPendiente = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.cmdSearchArticulo = New Solmicro.Expertis.Engine.UI.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxGestionLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxGestionNserie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.cmdSearchArticulo)
        Me.FilterPanel.Controls.Add(Me.lblCentroGestion)
        Me.FilterPanel.Controls.Add(Me.lblAlmacen)
        Me.FilterPanel.Controls.Add(Me.lblNSerie)
        Me.FilterPanel.Controls.Add(Me.lblDeposito)
        Me.FilterPanel.Controls.Add(Me.lblSubFamilia)
        Me.FilterPanel.Controls.Add(Me.lblGestionLotes)
        Me.FilterPanel.Controls.Add(Me.lblGestionNserie)
        Me.FilterPanel.Controls.Add(Me.lblFamilia)
        Me.FilterPanel.Controls.Add(Me.lblTipo)
        Me.FilterPanel.Controls.Add(Me.lblPendiente)
        Me.FilterPanel.Controls.Add(Me.lblArticulo)
        Me.FilterPanel.Controls.Add(Me.advIDCentroGestion)
        Me.FilterPanel.Controls.Add(Me.advIDAlmacen)
        Me.FilterPanel.Controls.Add(Me.advNSerie)
        Me.FilterPanel.Controls.Add(Me.cbxDeposito)
        Me.FilterPanel.Controls.Add(Me.advIDSubFamilia)
        Me.FilterPanel.Controls.Add(Me.cbxGestionLotes)
        Me.FilterPanel.Controls.Add(Me.cbxGestionNserie)
        Me.FilterPanel.Controls.Add(Me.advIDFamilia)
        Me.FilterPanel.Controls.Add(Me.advIDTipo)
        Me.FilterPanel.Controls.Add(Me.txtPendiente)
        Me.FilterPanel.Controls.Add(Me.advIDArticulo)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 177)
        Me.FilterPanel.Size = New System.Drawing.Size(735, 116)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(735, 177)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "PedidoVentaLinea"
        Me.Grid.KeyField = "IDLineaPedido"
        Me.Grid.Size = New System.Drawing.Size(735, 177)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "VAlquilerCIDisponibilidadAlquiler"
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
        Me.MainPanel.Size = New System.Drawing.Size(735, 293)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(735, 293)
        '
        'advIDCentroGestion
        '
        Me.advIDCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCentroGestion.EntityName = "CentroGestion"
        Me.advIDCentroGestion.Location = New System.Drawing.Point(445, 56)
        Me.advIDCentroGestion.Name = "advIDCentroGestion"
        Me.advIDCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.advIDCentroGestion.Size = New System.Drawing.Size(84, 23)
        Me.advIDCentroGestion.TabIndex = 8
        Me.advIDCentroGestion.ViewName = "tbMaestroCentroGestion"
        '
        'lblCentroGestion
        '
        Me.lblCentroGestion.Location = New System.Drawing.Point(373, 60)
        Me.lblCentroGestion.Name = "lblCentroGestion"
        Me.lblCentroGestion.Size = New System.Drawing.Size(67, 13)
        Me.lblCentroGestion.TabIndex = 0
        Me.lblCentroGestion.Text = "C. Gestión"
        '
        'advIDAlmacen
        '
        Me.advIDAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advIDAlmacen.EntityName = "Almacen"
        Me.advIDAlmacen.Location = New System.Drawing.Point(445, 30)
        Me.advIDAlmacen.Name = "advIDAlmacen"
        Me.advIDAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.Size = New System.Drawing.Size(84, 23)
        Me.advIDAlmacen.TabIndex = 7
        Me.advIDAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(373, 34)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblAlmacen.TabIndex = 8
        Me.lblAlmacen.Text = "Almacén"
        '
        'advNSerie
        '
        Me.advNSerie.DisabledBackColor = System.Drawing.Color.White
        Me.advNSerie.EntityName = "ArticuloNSerie"
        Me.advNSerie.Location = New System.Drawing.Point(445, 82)
        Me.advNSerie.Name = "advNSerie"
        Me.advNSerie.SecondaryDataFields = "NSerie"
        Me.advNSerie.Size = New System.Drawing.Size(84, 23)
        Me.advNSerie.TabIndex = 9
        Me.advNSerie.ViewName = "tbArticuloNSerie"
        '
        'lblNSerie
        '
        Me.lblNSerie.Location = New System.Drawing.Point(373, 87)
        Me.lblNSerie.Name = "lblNSerie"
        Me.lblNSerie.Size = New System.Drawing.Size(55, 13)
        Me.lblNSerie.TabIndex = 10
        Me.lblNSerie.Text = "Nº Serie"
        '
        'cbxDeposito
        '
        cbxDeposito_DesignTimeLayout.LayoutString = resources.GetString("cbxDeposito_DesignTimeLayout.LayoutString")
        Me.cbxDeposito.DesignTimeLayout = cbxDeposito_DesignTimeLayout
        Me.cbxDeposito.DisabledBackColor = System.Drawing.Color.White
        Me.cbxDeposito.Location = New System.Drawing.Point(85, 82)
        Me.cbxDeposito.Name = "cbxDeposito"
        Me.cbxDeposito.SelectedIndex = -1
        Me.cbxDeposito.SelectedItem = Nothing
        Me.cbxDeposito.Size = New System.Drawing.Size(102, 21)
        Me.cbxDeposito.TabIndex = 3
        '
        'lblDeposito
        '
        Me.lblDeposito.Location = New System.Drawing.Point(6, 82)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(57, 13)
        Me.lblDeposito.TabIndex = 12
        Me.lblDeposito.Text = "Depósito"
        '
        'advIDSubFamilia
        '
        Me.advIDSubFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDSubFamilia.EntityName = "Subfamilia"
        Me.advIDSubFamilia.Location = New System.Drawing.Point(289, 82)
        Me.advIDSubFamilia.Name = "advIDSubFamilia"
        Me.advIDSubFamilia.SecondaryDataFields = "IDSubfamilia"
        Me.advIDSubFamilia.Size = New System.Drawing.Size(67, 23)
        Me.advIDSubFamilia.TabIndex = 6
        Me.advIDSubFamilia.ViewName = "tbMaestroSubfamilia"
        '
        'lblSubFamilia
        '
        Me.lblSubFamilia.Location = New System.Drawing.Point(219, 86)
        Me.lblSubFamilia.Name = "lblSubFamilia"
        Me.lblSubFamilia.Size = New System.Drawing.Size(68, 13)
        Me.lblSubFamilia.TabIndex = 13
        Me.lblSubFamilia.Text = "SubFamilia"
        '
        'cbxGestionLotes
        '
        cbxGestionLotes_DesignTimeLayout.LayoutString = resources.GetString("cbxGestionLotes_DesignTimeLayout.LayoutString")
        Me.cbxGestionLotes.DesignTimeLayout = cbxGestionLotes_DesignTimeLayout
        Me.cbxGestionLotes.DisabledBackColor = System.Drawing.Color.White
        Me.cbxGestionLotes.Location = New System.Drawing.Point(650, 56)
        Me.cbxGestionLotes.Name = "cbxGestionLotes"
        Me.cbxGestionLotes.SelectedIndex = -1
        Me.cbxGestionLotes.SelectedItem = Nothing
        Me.cbxGestionLotes.Size = New System.Drawing.Size(74, 21)
        Me.cbxGestionLotes.TabIndex = 11
        '
        'lblGestionLotes
        '
        Me.lblGestionLotes.Location = New System.Drawing.Point(545, 60)
        Me.lblGestionLotes.Name = "lblGestionLotes"
        Me.lblGestionLotes.Size = New System.Drawing.Size(84, 13)
        Me.lblGestionLotes.TabIndex = 15
        Me.lblGestionLotes.Text = "Gestión Lotes"
        '
        'cbxGestionNserie
        '
        cbxGestionNserie_DesignTimeLayout.LayoutString = resources.GetString("cbxGestionNserie_DesignTimeLayout.LayoutString")
        Me.cbxGestionNserie.DesignTimeLayout = cbxGestionNserie_DesignTimeLayout
        Me.cbxGestionNserie.DisabledBackColor = System.Drawing.Color.White
        Me.cbxGestionNserie.Location = New System.Drawing.Point(650, 30)
        Me.cbxGestionNserie.Name = "cbxGestionNserie"
        Me.cbxGestionNserie.SelectedIndex = -1
        Me.cbxGestionNserie.SelectedItem = Nothing
        Me.cbxGestionNserie.Size = New System.Drawing.Size(74, 21)
        Me.cbxGestionNserie.TabIndex = 10
        '
        'lblGestionNserie
        '
        Me.lblGestionNserie.Location = New System.Drawing.Point(545, 34)
        Me.lblGestionNserie.Name = "lblGestionNserie"
        Me.lblGestionNserie.Size = New System.Drawing.Size(102, 13)
        Me.lblGestionNserie.TabIndex = 16
        Me.lblGestionNserie.Text = "Gestión Nº Serie"
        '
        'advIDFamilia
        '
        Me.advIDFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDFamilia.EntityName = "Familia"
        Me.advIDFamilia.Location = New System.Drawing.Point(289, 56)
        Me.advIDFamilia.Name = "advIDFamilia"
        Me.advIDFamilia.SecondaryDataFields = "IDFamilia"
        Me.advIDFamilia.Size = New System.Drawing.Size(67, 23)
        Me.advIDFamilia.TabIndex = 5
        Me.advIDFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(219, 61)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblFamilia.TabIndex = 17
        Me.lblFamilia.Text = "Familia"
        '
        'advIDTipo
        '
        Me.advIDTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTipo.EntityName = "TipoArticulo"
        Me.advIDTipo.Location = New System.Drawing.Point(289, 30)
        Me.advIDTipo.Name = "advIDTipo"
        Me.advIDTipo.SecondaryDataFields = "IDTipo"
        Me.advIDTipo.Size = New System.Drawing.Size(67, 23)
        Me.advIDTipo.TabIndex = 4
        Me.advIDTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(219, 35)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 19
        Me.lblTipo.Text = "Tipo"
        '
        'txtPendiente
        '
        Me.txtPendiente.DisabledBackColor = System.Drawing.Color.White
        Me.txtPendiente.Location = New System.Drawing.Point(85, 57)
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtPendiente.Size = New System.Drawing.Size(102, 21)
        Me.txtPendiente.TabIndex = 2
        '
        'lblPendiente
        '
        Me.lblPendiente.Location = New System.Drawing.Point(6, 56)
        Me.lblPendiente.Name = "lblPendiente"
        Me.lblPendiente.Size = New System.Drawing.Size(76, 13)
        Me.lblPendiente.TabIndex = 21
        Me.lblPendiente.Text = "Pendiente >"
        '
        'advIDArticulo
        '
        Me.advIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticulo.EntityName = "Articulo"
        Me.advIDArticulo.Location = New System.Drawing.Point(85, 30)
        Me.advIDArticulo.Name = "advIDArticulo"
        Me.advIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.advIDArticulo.Size = New System.Drawing.Size(102, 23)
        Me.advIDArticulo.TabIndex = 0
        Me.advIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(6, 30)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 22
        Me.lblArticulo.Text = "Artículo"
        '
        'cmdSearchArticulo
        '
        Me.cmdSearchArticulo.ImageIndex = 0
        Me.cmdSearchArticulo.ImageList = Me.ImageList1
        Me.cmdSearchArticulo.Location = New System.Drawing.Point(188, 30)
        Me.cmdSearchArticulo.Name = "cmdSearchArticulo"
        Me.cmdSearchArticulo.Size = New System.Drawing.Size(23, 23)
        Me.cmdSearchArticulo.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "xArticulos.ico")
        '
        'CIDispAlquileres
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(743, 381)
        Me.EntityName = "PedidoVentaLinea"
        Me.KeyField = "IDLineaPedido"
        Me.Name = "CIDispAlquileres"
        Me.ViewName = "VAlquilerCIDisponibilidadAlquiler"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxGestionLotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxGestionNserie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private f As Filter
    Private cnMNTO_DISPONIBILIDAD_ALQUILERES As String = "DISPALQ"

#Region " Load "

    Private Sub CIDispAlquileres_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitFilterCriteria()
        LoadParams()
        LoadEnum()
        LoadGridActions()
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            Dim ht As Hashtable = Me.Params
            If ht.ContainsKey("Filtro") Then
                f = ht("Filtro")
                Me.Execute()
            End If
        End If
    End Sub

    Private Sub LoadEnum()
        cbxGestionNserie.DataSource = New EnumData("enumBoolean")
        cbxGestionLotes.DataSource = New EnumData("EnumBoolean")
        cbxDeposito.DataSource = New EnumData("EnumBoolean")
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add("Abrir Disponibilidad", AddressOf AccionDisponibilidadAlquiler, ExpertisApp.GetIcon("xDisponibilidad.ico"))
    End Sub

    Private Sub InitFilterCriteria()
        cbxGestionNserie.Value = enumBoolean.Todos
        cbxGestionLotes.Value = enumBoolean.Todos
        cbxDeposito.Value = enumBoolean.No
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AccionDisponibilidadAlquiler()
        If Length(Grid.Value("IdArticulo")) > 0 Then
            If ExpertisApp.IsFormOpen(cnMNTO_DISPONIBILIDAD_ALQUILERES) Then ExpertisApp.CloseForm(cnMNTO_DISPONIBILIDAD_ALQUILERES)
            Dim htParams As New Hashtable
            htParams.Add("IDArticulo", Grid.Value("IDArticulo"))
            htParams.Add("IDAlmacen", Grid.Value("IDAlmacen"))
            ExpertisApp.OpenForm(cnMNTO_DISPONIBILIDAD_ALQUILERES, , htParams)
        End If
    End Sub

#End Region

#Region " QueryExecute "

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)

        InitFilterCriteria()

    End Sub

    Private Sub CIDispAlquileres_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If Not IsNothing(f) Then e.Filter.Add(f)
        e.Filter.Add("IDArticulo", FilterOperator.Equal, advIDArticulo.Text, FilterType.String)
        e.Filter.Add("QPendienteObra", FilterOperator.GreaterThan, txtPendiente.Text, FilterType.Numeric)
        e.Filter.Add("IDTipo", FilterOperator.Equal, advIDTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, advIDFamilia.Text, FilterType.String)
        e.Filter.Add("IdSubfamilia", FilterOperator.Equal, advIDSubFamilia.Text, FilterType.String)
        If cbxDeposito.Value <> enumBoolean.Todos Then
            e.Filter.Add("Deposito", FilterOperator.Equal, cbxDeposito.Value, FilterType.Numeric)
        End If
        If cbxGestionNserie.Value <> enumBoolean.Todos Then
            e.Filter.Add("NSerieObligatorio", FilterOperator.Equal, cbxGestionNserie.Value, FilterType.Numeric)
        End If
        If cbxGestionLotes.Value <> enumBoolean.Todos Then
            e.Filter.Add("GestionStockPorLotes", FilterOperator.Equal, cbxGestionLotes.Value, FilterType.Numeric)
        End If
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, advIDAlmacen.Text, FilterType.String)
        e.Filter.Add("IDCentroGestion", FilterOperator.Equal, advIDCentroGestion.Text, FilterType.String)
    End Sub

#End Region

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If e.Row.Cells("Disponible").Value < 0 Then
                e.Row.RowStyle = Grid.FormatStyles("DisponibilidadNegativaFormatStyle")
            End If
        End If
    End Sub

    Private Sub advNSerie_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advNSerie.SelectionChanged
        If Length(e.Selected.Rows(0)("IDArticulo")) > 0 Then advIDArticulo.Text = e.Selected.Rows(0)("IDArticulo")
    End Sub

    Private Sub cmdSearchArticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchArticulo.Click
        Dim IDArticulo As String = Me.advIDArticulo.Text
        Dim NSerie As String = Me.advNSerie.Text
        Dim frm As New frmSearchArticulo
        frm.AbrirForm(IDArticulo, NSerie)
        advIDArticulo.Value = IDArticulo
        advNSerie.Value = NSerie
    End Sub

    Private Sub CIDispAlquileres_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        f = Nothing
    End Sub

End Class
