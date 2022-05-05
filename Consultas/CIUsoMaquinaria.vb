Public Class CIUsoMaquinaria
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.ExecuteActions.Visible = Janus.Windows.UI.InheritableBoolean.False
        txtDias.Value = DBNull.Value
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
    Friend WithEvents advIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDSubFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblSubFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advNserie As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblNserie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDias As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblDias As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEstadoActivo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEstadoActivo As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstadoActivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIUsoMaquinaria))
        Me.txtDias = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDias = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDSubFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblSubFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advNserie = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblNserie = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstadoActivo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstadoActivo = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxEstadoActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblDias)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblArticulo)
        Me.FilterPanel.Controls.Add(Me.lblTipo)
        Me.FilterPanel.Controls.Add(Me.lblFamilia)
        Me.FilterPanel.Controls.Add(Me.lblSubFamilia)
        Me.FilterPanel.Controls.Add(Me.lblNserie)
        Me.FilterPanel.Controls.Add(Me.lblEstadoActivo)
        Me.FilterPanel.Controls.Add(Me.txtDias)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.advIDArticulo)
        Me.FilterPanel.Controls.Add(Me.advIDTipo)
        Me.FilterPanel.Controls.Add(Me.advIDFamilia)
        Me.FilterPanel.Controls.Add(Me.advIDSubFamilia)
        Me.FilterPanel.Controls.Add(Me.advNserie)
        Me.FilterPanel.Controls.Add(Me.cbxEstadoActivo)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 309)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 112)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 309)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ArticuloNSerie"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.KeyField = "IDArticulo"
        Me.Grid.Size = New System.Drawing.Size(688, 309)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vAlquilerCIUsoMaquinariaFinal"
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
        Me.MainPanel.Size = New System.Drawing.Size(688, 421)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(688, 421)
        '
        'txtDias
        '
        Me.txtDias.DisabledBackColor = System.Drawing.Color.White
        Me.txtDias.Location = New System.Drawing.Point(580, 28)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtDias.Size = New System.Drawing.Size(100, 21)
        Me.txtDias.TabIndex = 6
        '
        'lblDias
        '
        Me.lblDias.Location = New System.Drawing.Point(432, 31)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(139, 13)
        Me.lblDias.TabIndex = 0
        Me.lblDias.Text = "Días de Inactividad >="
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(580, 77)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaHasta.TabIndex = 8
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(432, 81)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(143, 13)
        Me.lblFechaHasta.TabIndex = 7
        Me.lblFechaHasta.Text = "Fecha Inactividad Hasta"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(580, 53)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaDesde.TabIndex = 7
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(432, 57)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(147, 13)
        Me.lblFechaDesde.TabIndex = 9
        Me.lblFechaDesde.Text = "Fecha Inactividad Desde"
        '
        'advIDArticulo
        '
        Me.advIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticulo.EntityName = "Articulo"
        Me.advIDArticulo.Location = New System.Drawing.Point(67, 25)
        Me.advIDArticulo.Name = "advIDArticulo"
        Me.advIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.advIDArticulo.Size = New System.Drawing.Size(110, 23)
        Me.advIDArticulo.TabIndex = 0
        Me.advIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(14, 30)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 10
        Me.lblArticulo.Text = "Artículo"
        '
        'advIDTipo
        '
        Me.advIDTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTipo.EntityName = "TipoArticulo"
        Me.advIDTipo.Location = New System.Drawing.Point(67, 51)
        Me.advIDTipo.Name = "advIDTipo"
        Me.advIDTipo.SecondaryDataFields = "IDTipo"
        Me.advIDTipo.Size = New System.Drawing.Size(110, 23)
        Me.advIDTipo.TabIndex = 1
        Me.advIDTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(14, 56)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 12
        Me.lblTipo.Text = "Tipo"
        '
        'advIDFamilia
        '
        Me.advIDFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDFamilia.EntityName = "Familia"
        Me.advIDFamilia.Location = New System.Drawing.Point(67, 77)
        Me.advIDFamilia.Name = "advIDFamilia"
        Me.advIDFamilia.SecondaryDataFields = "IDFamilia"
        Me.advIDFamilia.Size = New System.Drawing.Size(110, 23)
        Me.advIDFamilia.TabIndex = 2
        Me.advIDFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(14, 82)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(47, 13)
        Me.lblFamilia.TabIndex = 14
        Me.lblFamilia.Text = "Familia"
        '
        'advIDSubFamilia
        '
        Me.advIDSubFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDSubFamilia.EntityName = "Subfamilia"
        Me.advIDSubFamilia.Location = New System.Drawing.Point(294, 25)
        Me.advIDSubFamilia.Name = "advIDSubFamilia"
        Me.advIDSubFamilia.SecondaryDataFields = "IDSubfamilia"
        Me.advIDSubFamilia.Size = New System.Drawing.Size(100, 23)
        Me.advIDSubFamilia.TabIndex = 3
        Me.advIDSubFamilia.ViewName = "tbMaestroSubfamilia"
        '
        'lblSubFamilia
        '
        Me.lblSubFamilia.Location = New System.Drawing.Point(207, 31)
        Me.lblSubFamilia.Name = "lblSubFamilia"
        Me.lblSubFamilia.Size = New System.Drawing.Size(69, 13)
        Me.lblSubFamilia.TabIndex = 16
        Me.lblSubFamilia.Text = "SubFamilia"
        '
        'advNserie
        '
        Me.advNserie.DisabledBackColor = System.Drawing.Color.White
        Me.advNserie.EntityName = "ArticuloNSerie"
        Me.advNserie.Location = New System.Drawing.Point(294, 51)
        Me.advNserie.Name = "advNserie"
        Me.advNserie.SecondaryDataFields = "NSerie"
        Me.advNserie.Size = New System.Drawing.Size(100, 23)
        Me.advNserie.TabIndex = 4
        Me.advNserie.ViewName = "tbArticuloNSerie"
        '
        'lblNserie
        '
        Me.lblNserie.Location = New System.Drawing.Point(207, 56)
        Me.lblNserie.Name = "lblNserie"
        Me.lblNserie.Size = New System.Drawing.Size(55, 13)
        Me.lblNserie.TabIndex = 18
        Me.lblNserie.Text = "Nº Serie"
        '
        'cbxEstadoActivo
        '
        cbxEstadoActivo_DesignTimeLayout.LayoutString = resources.GetString("cbxEstadoActivo_DesignTimeLayout.LayoutString")
        Me.cbxEstadoActivo.DesignTimeLayout = cbxEstadoActivo_DesignTimeLayout
        Me.cbxEstadoActivo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstadoActivo.EntityName = "MntoEstadoActivo"
        Me.cbxEstadoActivo.Location = New System.Drawing.Point(294, 77)
        Me.cbxEstadoActivo.Name = "cbxEstadoActivo"
        Me.cbxEstadoActivo.PrimaryDataFields = "IDEstadoActivo"
        Me.cbxEstadoActivo.SecondaryDataFields = "IDEstadoActivo"
        Me.cbxEstadoActivo.SelectedIndex = -1
        Me.cbxEstadoActivo.SelectedItem = Nothing
        Me.cbxEstadoActivo.Size = New System.Drawing.Size(100, 21)
        Me.cbxEstadoActivo.TabIndex = 5
        Me.cbxEstadoActivo.ViewName = "tbMntoEstadoActivo"
        '
        'lblEstadoActivo
        '
        Me.lblEstadoActivo.Location = New System.Drawing.Point(207, 81)
        Me.lblEstadoActivo.Name = "lblEstadoActivo"
        Me.lblEstadoActivo.Size = New System.Drawing.Size(84, 13)
        Me.lblEstadoActivo.TabIndex = 20
        Me.lblEstadoActivo.Text = "Estado Activo"
        '
        'CIUsoMaquinaria
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "ArticuloNSerie"
        Me.KeyField = "IDArticulo"
        Me.Name = "CIUsoMaquinaria"
        Me.ViewName = "vAlquilerCIUsoMaquinariaFinal"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxEstadoActivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CIUsoMaquinaria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            GridFormatStyle.CrearFormatos(Grid, GridFormatStyle.TipoFormato.EstadoActivo)
            LoadGridActions()
        End If
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add(cnABRRIRARTICULO, AddressOf AccionAbrirArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
        Grid.Actions.Add(cnABRRIRACTIVO, AddressOf AccionAbrirActivo, ExpertisApp.GetIcon("xActivos.ico"))
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirArticulo()
        If Length(Grid.Value("IDArticulo")) > 0 Then
            AbrirMntoArticulo(Grid.Value("IDArticulo"))
        End If
    End Sub

    Private Sub AccionAbrirActivo()
        If Length(Grid.Value("IDActivo")) > 0 Then
            AbrirMntoAbrirActivo(Grid.Value("IDActivo"))
        End If
    End Sub

#End Region

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If Length(Grid.Value("IDEstadoActivo")) > 0 Then
            e.Row.RowStyle = Grid.FormatStyles("FMT" & e.Row.DataRow("IDEstadoActivo"))
        End If
    End Sub

#Region " Query Executing "

    Private Sub CIUsoMaquinaria_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDArticulo", FilterOperator.Equal, advIDArticulo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, advIDFamilia.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, advIDTipo.Text, FilterType.String)
        e.Filter.Add("IDSubfamilia", FilterOperator.Equal, advIDSubFamilia.Text, FilterType.String)
        e.Filter.Add("NSerie", FilterOperator.Equal, advNserie.Text, FilterType.String)
        e.Filter.Add("IDEstadoActivo", FilterOperator.Equal, cbxEstadoActivo.Value, FilterType.String)
        e.Filter.Add("FechaInactividad", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaInactividad", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        e.Filter.Add("Dias", FilterOperator.GreaterThanOrEqual, txtDias.Value, FilterType.Numeric)
    End Sub

    Private Sub CIUsoMaquinaria_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        cbxFechaDesde.TextBox.Clear()
        cbxFechaHasta.TextBox.Clear()
    End Sub

#End Region

End Class
