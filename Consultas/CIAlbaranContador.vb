Public Class CIAlbaranContador
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtMedidaRetornoDesde.Value = System.DBNull.Value
        txtMedidaRetornoHasta.Value = System.DBNull.Value
        txtMedidaEnvioDesde.Value = System.DBNull.Value
        txtMedidaEnvioHasta.Value = System.DBNull.Value
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
    Friend WithEvents txtMedidaRetornoHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblMedidaRetornoHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtMedidaRetornoDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblMedidaRetornoDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtMedidaEnvioHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblMedidaEnvioHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtMedidaEnvioDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblMedidaEnvioDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDAlbaran As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblAlbaran As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxPrincipal As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblPrincipal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDActivo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblMaquina As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advSubfamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblSubfamilia As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxPrincipal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIAlbaranContador))
        Me.txtMedidaRetornoHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMedidaRetornoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMedidaRetornoDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMedidaRetornoDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMedidaEnvioHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMedidaEnvioHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMedidaEnvioDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMedidaEnvioDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDAlbaran = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlbaran = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxPrincipal = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblPrincipal = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDActivo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblMaquina = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advSubfamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblSubfamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblMedidaRetornoHasta)
        Me.FilterPanel.Controls.Add(Me.txtMedidaRetornoHasta)
        Me.FilterPanel.Controls.Add(Me.lblMedidaRetornoDesde)
        Me.FilterPanel.Controls.Add(Me.txtMedidaRetornoDesde)
        Me.FilterPanel.Controls.Add(Me.lblMedidaEnvioHasta)
        Me.FilterPanel.Controls.Add(Me.txtMedidaEnvioHasta)
        Me.FilterPanel.Controls.Add(Me.lblMedidaEnvioDesde)
        Me.FilterPanel.Controls.Add(Me.txtMedidaEnvioDesde)
        Me.FilterPanel.Controls.Add(Me.lblContador)
        Me.FilterPanel.Controls.Add(Me.advIDContador)
        Me.FilterPanel.Controls.Add(Me.lblAlbaran)
        Me.FilterPanel.Controls.Add(Me.advIDAlbaran)
        Me.FilterPanel.Controls.Add(Me.lblPrincipal)
        Me.FilterPanel.Controls.Add(Me.cbxPrincipal)
        Me.FilterPanel.Controls.Add(Me.lblMaquina)
        Me.FilterPanel.Controls.Add(Me.advIDActivo)
        Me.FilterPanel.Controls.Add(Me.lblArticulo)
        Me.FilterPanel.Controls.Add(Me.advIDArticulo)
        Me.FilterPanel.Controls.Add(Me.lblTipo)
        Me.FilterPanel.Controls.Add(Me.advIDTipo)
        Me.FilterPanel.Controls.Add(Me.lblFamilia)
        Me.FilterPanel.Controls.Add(Me.advIDFamilia)
        Me.FilterPanel.Controls.Add(Me.lblSubfamilia)
        Me.FilterPanel.Controls.Add(Me.advSubfamilia)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 306)
        Me.FilterPanel.Size = New System.Drawing.Size(767, 115)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(767, 306)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "AlbaranVentaLinea"
        Me.Grid.KeyField = "IDLineaAlbaran"
        Me.Grid.Size = New System.Drawing.Size(767, 306)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vAlquilerCIAnalisisLineasContadores"
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
        Me.MainPanel.Size = New System.Drawing.Size(767, 421)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(767, 421)
        '
        'txtMedidaRetornoHasta
        '
        Me.txtMedidaRetornoHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtMedidaRetornoHasta.Location = New System.Drawing.Point(480, 51)
        Me.txtMedidaRetornoHasta.Name = "txtMedidaRetornoHasta"
        Me.txtMedidaRetornoHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtMedidaRetornoHasta.Size = New System.Drawing.Size(73, 21)
        Me.txtMedidaRetornoHasta.TabIndex = 7
        '
        'lblMedidaRetornoHasta
        '
        Me.lblMedidaRetornoHasta.Location = New System.Drawing.Point(338, 56)
        Me.lblMedidaRetornoHasta.Name = "lblMedidaRetornoHasta"
        Me.lblMedidaRetornoHasta.Size = New System.Drawing.Size(132, 13)
        Me.lblMedidaRetornoHasta.TabIndex = 0
        Me.lblMedidaRetornoHasta.Text = "Medida Retorno Hasta"
        '
        'txtMedidaRetornoDesde
        '
        Me.txtMedidaRetornoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtMedidaRetornoDesde.Location = New System.Drawing.Point(480, 27)
        Me.txtMedidaRetornoDesde.Name = "txtMedidaRetornoDesde"
        Me.txtMedidaRetornoDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtMedidaRetornoDesde.Size = New System.Drawing.Size(73, 21)
        Me.txtMedidaRetornoDesde.TabIndex = 6
        '
        'lblMedidaRetornoDesde
        '
        Me.lblMedidaRetornoDesde.Location = New System.Drawing.Point(338, 30)
        Me.lblMedidaRetornoDesde.Name = "lblMedidaRetornoDesde"
        Me.lblMedidaRetornoDesde.Size = New System.Drawing.Size(136, 13)
        Me.lblMedidaRetornoDesde.TabIndex = 13
        Me.lblMedidaRetornoDesde.Text = "Medida Retorno Desde"
        '
        'txtMedidaEnvioHasta
        '
        Me.txtMedidaEnvioHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtMedidaEnvioHasta.Location = New System.Drawing.Point(687, 51)
        Me.txtMedidaEnvioHasta.Name = "txtMedidaEnvioHasta"
        Me.txtMedidaEnvioHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtMedidaEnvioHasta.Size = New System.Drawing.Size(73, 21)
        Me.txtMedidaEnvioHasta.TabIndex = 10
        '
        'lblMedidaEnvioHasta
        '
        Me.lblMedidaEnvioHasta.Location = New System.Drawing.Point(561, 56)
        Me.lblMedidaEnvioHasta.Name = "lblMedidaEnvioHasta"
        Me.lblMedidaEnvioHasta.Size = New System.Drawing.Size(118, 13)
        Me.lblMedidaEnvioHasta.TabIndex = 14
        Me.lblMedidaEnvioHasta.Text = "Medida Envio Hasta"
        '
        'txtMedidaEnvioDesde
        '
        Me.txtMedidaEnvioDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtMedidaEnvioDesde.Location = New System.Drawing.Point(687, 27)
        Me.txtMedidaEnvioDesde.Name = "txtMedidaEnvioDesde"
        Me.txtMedidaEnvioDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtMedidaEnvioDesde.Size = New System.Drawing.Size(73, 21)
        Me.txtMedidaEnvioDesde.TabIndex = 9
        '
        'lblMedidaEnvioDesde
        '
        Me.lblMedidaEnvioDesde.Location = New System.Drawing.Point(561, 30)
        Me.lblMedidaEnvioDesde.Name = "lblMedidaEnvioDesde"
        Me.lblMedidaEnvioDesde.Size = New System.Drawing.Size(122, 13)
        Me.lblMedidaEnvioDesde.TabIndex = 15
        Me.lblMedidaEnvioDesde.Text = "Medida Envio Desde"
        '
        'advIDContador
        '
        Me.advIDContador.DisabledBackColor = System.Drawing.Color.White
        Me.advIDContador.EntityName = "PreventivoContador"
        Me.advIDContador.Location = New System.Drawing.Point(687, 76)
        Me.advIDContador.Name = "advIDContador"
        Me.advIDContador.SecondaryDataFields = "IDContadorPrev"
        Me.advIDContador.Size = New System.Drawing.Size(75, 23)
        Me.advIDContador.TabIndex = 11
        Me.advIDContador.ViewName = "tbPreventivoContador"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(561, 82)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 16
        Me.lblContador.Text = "Contador"
        '
        'advIDAlbaran
        '
        Me.advIDAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.advIDAlbaran.DisplayField = "NAlbaran"
        Me.advIDAlbaran.EntityName = "AlbaranVentaCabecera"
        Me.advIDAlbaran.Location = New System.Drawing.Point(63, 25)
        Me.advIDAlbaran.Name = "advIDAlbaran"
        Me.advIDAlbaran.SecondaryDataFields = "IDAlbaran"
        Me.advIDAlbaran.Size = New System.Drawing.Size(105, 23)
        Me.advIDAlbaran.TabIndex = 0
        Me.advIDAlbaran.ViewName = "tbAlbaranVentaCabecera"
        '
        'lblAlbaran
        '
        Me.lblAlbaran.Location = New System.Drawing.Point(7, 29)
        Me.lblAlbaran.Name = "lblAlbaran"
        Me.lblAlbaran.Size = New System.Drawing.Size(51, 13)
        Me.lblAlbaran.TabIndex = 18
        Me.lblAlbaran.Text = "Albarán"
        '
        'cbxPrincipal
        '
        cbxPrincipal_DesignTimeLayout.LayoutString = resources.GetString("cbxPrincipal_DesignTimeLayout.LayoutString")
        Me.cbxPrincipal.DesignTimeLayout = cbxPrincipal_DesignTimeLayout
        Me.cbxPrincipal.DisabledBackColor = System.Drawing.Color.White
        Me.cbxPrincipal.Location = New System.Drawing.Point(480, 76)
        Me.cbxPrincipal.Name = "cbxPrincipal"
        Me.cbxPrincipal.SelectedIndex = -1
        Me.cbxPrincipal.SelectedItem = Nothing
        Me.cbxPrincipal.Size = New System.Drawing.Size(73, 21)
        Me.cbxPrincipal.TabIndex = 8
        '
        'lblPrincipal
        '
        Me.lblPrincipal.Location = New System.Drawing.Point(338, 81)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(55, 13)
        Me.lblPrincipal.TabIndex = 20
        Me.lblPrincipal.Text = "Principal"
        '
        'advIDActivo
        '
        Me.advIDActivo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDActivo.EntityName = "Activo"
        Me.advIDActivo.Location = New System.Drawing.Point(63, 77)
        Me.advIDActivo.Name = "advIDActivo"
        Me.advIDActivo.SecondaryDataFields = "IDActivo"
        Me.advIDActivo.Size = New System.Drawing.Size(105, 23)
        Me.advIDActivo.TabIndex = 2
        Me.advIDActivo.ViewName = "tbMaestroActivo"
        '
        'lblMaquina
        '
        Me.lblMaquina.Location = New System.Drawing.Point(7, 81)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(42, 13)
        Me.lblMaquina.TabIndex = 21
        Me.lblMaquina.Text = "Activo"
        '
        'advIDArticulo
        '
        Me.advIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticulo.EntityName = "Articulo"
        Me.advIDArticulo.Location = New System.Drawing.Point(63, 51)
        Me.advIDArticulo.Name = "advIDArticulo"
        Me.advIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.advIDArticulo.Size = New System.Drawing.Size(105, 23)
        Me.advIDArticulo.TabIndex = 1
        Me.advIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(7, 55)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 23
        Me.lblArticulo.Text = "Articulo"
        '
        'advIDTipo
        '
        Me.advIDTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTipo.EntityName = "TipoArticulo"
        Me.advIDTipo.Location = New System.Drawing.Point(249, 25)
        Me.advIDTipo.Name = "advIDTipo"
        Me.advIDTipo.SecondaryDataFields = "IDTipo"
        Me.advIDTipo.Size = New System.Drawing.Size(80, 23)
        Me.advIDTipo.TabIndex = 3
        Me.advIDTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(176, 30)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 25
        Me.lblTipo.Text = "Tipo"
        '
        'advIDFamilia
        '
        Me.advIDFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDFamilia.EntityName = "Familia"
        Me.advIDFamilia.Location = New System.Drawing.Point(249, 51)
        Me.advIDFamilia.Name = "advIDFamilia"
        Me.advIDFamilia.SecondaryDataFields = "IDFamilia"
        Me.advIDFamilia.Size = New System.Drawing.Size(80, 23)
        Me.advIDFamilia.TabIndex = 4
        Me.advIDFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(176, 56)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(47, 13)
        Me.lblFamilia.TabIndex = 27
        Me.lblFamilia.Text = "Familia"
        '
        'advSubfamilia
        '
        Me.advSubfamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advSubfamilia.EntityName = "Subfamilia"
        Me.advSubfamilia.Location = New System.Drawing.Point(249, 77)
        Me.advSubfamilia.Name = "advSubfamilia"
        Me.advSubfamilia.SecondaryDataFields = "IDSubfamilia"
        Me.advSubfamilia.Size = New System.Drawing.Size(80, 23)
        Me.advSubfamilia.TabIndex = 5
        Me.advSubfamilia.ViewName = "tbMaestroSubfamilia"
        '
        'lblSubfamilia
        '
        Me.lblSubfamilia.Location = New System.Drawing.Point(176, 82)
        Me.lblSubfamilia.Name = "lblSubfamilia"
        Me.lblSubfamilia.Size = New System.Drawing.Size(69, 13)
        Me.lblSubfamilia.TabIndex = 29
        Me.lblSubfamilia.Text = "SubFamilia"
        '
        'CIAlbaranContador
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(775, 509)
        Me.EntityName = "AlbaranVentaLinea"
        Me.KeyField = "IDLineaAlbaran"
        Me.Name = "CIAlbaranContador"
        Me.ViewName = "vAlquilerCIAnalisisLineasContadores"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mTipoAlbaranDeposito As String

#Region " Load  "

    Private Sub CIAlbaranContador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadEnums()
            LoadGridActions()
            cbxPrincipal.Value = enumBoolean.No
        End If
    End Sub

    Private Sub LoadERPData()
        mTipoAlbaranDeposito = New Parametro().TipoAlbaranDeDeposito()
    End Sub

    Private Sub LoadEnums()
        cbxPrincipal.DataSource = New EnumData("enumBoolean")
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add(cnABRRIRARTICULO, AddressOf AccionAbrirArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
        Grid.Actions.Add(cnABRIRALBARANVENTA, AddressOf AccionAbrirAlbaranVenta, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
        Grid.Actions.Add(cnABRIRALQUILER, AddressOf AccionAbrirAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub InitFilterCriteria()
        cbxPrincipal.Value = enumBoolean.No
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirArticulo()
        AbrirMntoArticulo(Grid.Value("IDArticulo"))
    End Sub

    Private Sub AccionAbrirAlbaranVenta()
        AbrirMntoAlbaranVenta(Grid.Value("IDAlbaran"))
    End Sub

    Private Sub AccionAbrirAlquiler()
        AbrirMntoAlquiler(Grid.Value("IDObra"))
    End Sub

#End Region

#Region " Query Executing "

    Private Sub CIAlbaranContador_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDAlbaran", FilterOperator.Equal, advIDAlbaran.Value, FilterType.Numeric)
        e.Filter.Add("IDArticulo", FilterOperator.Equal, advIDArticulo.Text, FilterType.String)
        e.Filter.Add("IDActivo", FilterOperator.Equal, advIDActivo.Text, FilterType.String)
        e.Filter.Add("MedidaEnvio", FilterOperator.GreaterThanOrEqual, txtMedidaEnvioDesde.Value, FilterType.Numeric)
        e.Filter.Add("MedidaEnvio", FilterOperator.LessThanOrEqual, txtMedidaEnvioHasta.Value, FilterType.Numeric)
        e.Filter.Add("MedidaRetorno", FilterOperator.GreaterThanOrEqual, txtMedidaRetornoDesde.Value, FilterType.Numeric)
        e.Filter.Add("MedidaRetorno", FilterOperator.LessThanOrEqual, txtMedidaRetornoHasta.Value, FilterType.Numeric)
        If cbxPrincipal.Value <> enumBoolean.Todos Then
            e.Filter.Add("Principal", FilterOperator.Equal, cbxPrincipal.Value, FilterType.Numeric)
        End If
        e.Filter.Add("IDContadorPrev", FilterOperator.Equal, advIDContador.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, advIDTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, advIDFamilia.Text, FilterType.String)
        e.Filter.Add("IDSubfamilia", FilterOperator.Equal, advSubfamilia.Text, FilterType.String)
        e.Filter.Add("IDTipoAlbaran", FilterOperator.Equal, mTipoAlbaranDeposito, FilterType.String)
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)
        InitFilterCriteria()
    End Sub

#End Region

End Class
