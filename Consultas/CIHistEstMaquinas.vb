Public Class CIHistEstMaquinas
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.ExecuteActions.Visible = Janus.Windows.UI.InheritableBoolean.False
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
    Friend WithEvents advIDActivo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblActivo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEstadoActivo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEstadoActivo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDSubFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblSubFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTexto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTexto As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstadoActivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIHistEstMaquinas))
        Me.advIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDActivo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblActivo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstadoActivo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstadoActivo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDSubFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblSubFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTexto = New Solmicro.Expertis.Engine.UI.Label
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
        Me.FilterPanel.Controls.Add(Me.lblArticulo)
        Me.FilterPanel.Controls.Add(Me.advIDArticulo)
        Me.FilterPanel.Controls.Add(Me.lblActivo)
        Me.FilterPanel.Controls.Add(Me.advIDActivo)
        Me.FilterPanel.Controls.Add(Me.lblOperario)
        Me.FilterPanel.Controls.Add(Me.advIDOperario)
        Me.FilterPanel.Controls.Add(Me.lblEstadoActivo)
        Me.FilterPanel.Controls.Add(Me.cbxEstadoActivo)
        Me.FilterPanel.Controls.Add(Me.lblTipo)
        Me.FilterPanel.Controls.Add(Me.advIDTipo)
        Me.FilterPanel.Controls.Add(Me.lblFamilia)
        Me.FilterPanel.Controls.Add(Me.advIDFamilia)
        Me.FilterPanel.Controls.Add(Me.lblSubFamilia)
        Me.FilterPanel.Controls.Add(Me.advIDSubFamilia)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblTexto)
        Me.FilterPanel.Controls.Add(Me.txtTexto)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 305)
        Me.FilterPanel.Size = New System.Drawing.Size(744, 116)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(744, 305)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Activo"
        Me.Grid.Size = New System.Drawing.Size(744, 305)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vAlquilerCIHistoricoEstadoMaquinas"
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
        Me.MainPanel.Size = New System.Drawing.Size(744, 421)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(744, 421)
        '
        'advIDArticulo
        '
        Me.advIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticulo.EntityName = "Articulo"
        Me.advIDArticulo.Location = New System.Drawing.Point(75, 25)
        Me.advIDArticulo.Name = "advIDArticulo"
        Me.advIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.advIDArticulo.Size = New System.Drawing.Size(117, 23)
        Me.advIDArticulo.TabIndex = 0
        Me.advIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(8, 30)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 0
        Me.lblArticulo.Text = "Artículo"
        '
        'advIDActivo
        '
        Me.advIDActivo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDActivo.EntityName = "Activo"
        Me.advIDActivo.Location = New System.Drawing.Point(75, 51)
        Me.advIDActivo.Name = "advIDActivo"
        Me.advIDActivo.SecondaryDataFields = "IDActivo"
        Me.advIDActivo.Size = New System.Drawing.Size(117, 23)
        Me.advIDActivo.TabIndex = 1
        Me.advIDActivo.ViewName = "tbMaestroActivo"
        '
        'lblActivo
        '
        Me.lblActivo.Location = New System.Drawing.Point(8, 55)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(42, 13)
        Me.lblActivo.TabIndex = 11
        Me.lblActivo.Text = "Activo"
        '
        'advIDOperario
        '
        Me.advIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperario.EntityName = "Operario"
        Me.advIDOperario.Location = New System.Drawing.Point(75, 77)
        Me.advIDOperario.Name = "advIDOperario"
        Me.advIDOperario.SecondaryDataFields = "IDOperario"
        Me.advIDOperario.Size = New System.Drawing.Size(118, 23)
        Me.advIDOperario.TabIndex = 2
        Me.advIDOperario.ViewName = "tbMaestroOperario"
        '
        'lblOperario
        '
        Me.lblOperario.Location = New System.Drawing.Point(8, 81)
        Me.lblOperario.Name = "lblOperario"
        Me.lblOperario.Size = New System.Drawing.Size(57, 13)
        Me.lblOperario.TabIndex = 13
        Me.lblOperario.Text = "Operario"
        '
        'cbxEstadoActivo
        '
        cbxEstadoActivo_DesignTimeLayout.LayoutString = resources.GetString("cbxEstadoActivo_DesignTimeLayout.LayoutString")
        Me.cbxEstadoActivo.DesignTimeLayout = cbxEstadoActivo_DesignTimeLayout
        Me.cbxEstadoActivo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstadoActivo.EntityName = "MntoEstadoActivo"
        Me.cbxEstadoActivo.Location = New System.Drawing.Point(648, 27)
        Me.cbxEstadoActivo.Name = "cbxEstadoActivo"
        Me.cbxEstadoActivo.PrimaryDataFields = "IDEstadoActivo"
        Me.cbxEstadoActivo.SecondaryDataFields = "IDEstadoActivo"
        Me.cbxEstadoActivo.SelectedIndex = -1
        Me.cbxEstadoActivo.SelectedItem = Nothing
        Me.cbxEstadoActivo.Size = New System.Drawing.Size(86, 21)
        Me.cbxEstadoActivo.TabIndex = 9
        Me.cbxEstadoActivo.ViewName = "tbMntoEstadoActivo"
        '
        'lblEstadoActivo
        '
        Me.lblEstadoActivo.Location = New System.Drawing.Point(559, 32)
        Me.lblEstadoActivo.Name = "lblEstadoActivo"
        Me.lblEstadoActivo.Size = New System.Drawing.Size(84, 13)
        Me.lblEstadoActivo.TabIndex = 15
        Me.lblEstadoActivo.Text = "Estado Activo"
        '
        'advIDTipo
        '
        Me.advIDTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTipo.EntityName = "TipoArticulo"
        Me.advIDTipo.Location = New System.Drawing.Point(277, 25)
        Me.advIDTipo.Name = "advIDTipo"
        Me.advIDTipo.SecondaryDataFields = "IDTipo"
        Me.advIDTipo.Size = New System.Drawing.Size(83, 23)
        Me.advIDTipo.TabIndex = 3
        Me.advIDTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(205, 30)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 17
        Me.lblTipo.Text = "Tipo"
        '
        'advIDFamilia
        '
        Me.advIDFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDFamilia.EntityName = "Familia"
        Me.advIDFamilia.Location = New System.Drawing.Point(277, 51)
        Me.advIDFamilia.Name = "advIDFamilia"
        Me.advIDFamilia.SecondaryDataFields = "IDFamilia"
        Me.advIDFamilia.Size = New System.Drawing.Size(83, 23)
        Me.advIDFamilia.TabIndex = 4
        Me.advIDFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(205, 55)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblFamilia.TabIndex = 19
        Me.lblFamilia.Text = "Familia"
        '
        'advIDSubFamilia
        '
        Me.advIDSubFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDSubFamilia.EntityName = "Subfamilia"
        Me.advIDSubFamilia.Location = New System.Drawing.Point(277, 77)
        Me.advIDSubFamilia.Name = "advIDSubFamilia"
        Me.advIDSubFamilia.SecondaryDataFields = "IDSubfamilia"
        Me.advIDSubFamilia.Size = New System.Drawing.Size(83, 23)
        Me.advIDSubFamilia.TabIndex = 5
        Me.advIDSubFamilia.ViewName = "tbMaestroSubfamilia"
        '
        'lblSubFamilia
        '
        Me.lblSubFamilia.Location = New System.Drawing.Point(205, 81)
        Me.lblSubFamilia.Name = "lblSubFamilia"
        Me.lblSubFamilia.Size = New System.Drawing.Size(68, 13)
        Me.lblSubFamilia.TabIndex = 21
        Me.lblSubFamilia.Text = "SubFamilia"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(458, 27)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(86, 21)
        Me.cbxFechaDesde.TabIndex = 6
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(376, 32)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 23
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(458, 52)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(86, 21)
        Me.cbxFechaHasta.TabIndex = 7
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(376, 56)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 24
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'txtTexto
        '
        Me.txtTexto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTexto.Location = New System.Drawing.Point(458, 77)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(276, 21)
        Me.txtTexto.TabIndex = 8
        '
        'lblTexto
        '
        Me.lblTexto.Location = New System.Drawing.Point(376, 82)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(38, 13)
        Me.lblTexto.TabIndex = 25
        Me.lblTexto.Text = "Texto"
        '
        'CIHistEstMaquinas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(752, 509)
        Me.EntityName = "Activo"
        Me.Name = "CIHistEstMaquinas"
        Me.ShowIcon = False
        Me.ViewName = "vAlquilerCIHistoricoEstadoMaquinas"
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

    Private Sub CIHistEstMaquinas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If Length(Grid.Value("IDArticulo")) > 0 Then AbrirMntoArticulo(Grid.Value("IDArticulo"))
    End Sub

    Private Sub AccionAbrirActivo()
        If Length(Grid.Value("IDActivo")) > 0 Then AbrirMntoAbrirActivo(Grid.Value("IDActivo"))
    End Sub

#End Region

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If Length(e.Row.DataRow("IDEstadoActivo")) > 0 Then
            e.Row.RowStyle = Grid.FormatStyles("FMT" & e.Row.DataRow("IDEstadoActivo"))
        End If
    End Sub

#Region " Query Executing "

    Private Sub CIHistEstMaquinas_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        Dim blnFiltrar As Boolean
        If Length(advIDArticulo.Text) = 0 AndAlso Length(advIDActivo.Text) = 0 AndAlso Length(advIDOperario.Text) = 0 AndAlso _
           Length(cbxFechaDesde.Value) = 0 AndAlso Length(cbxFechaHasta.Value) = 0 AndAlso Length(cbxEstadoActivo.Value) = 0 AndAlso _
           Length(txtTexto.Text) = 0 AndAlso Length(advIDTipo.Text) = 0 AndAlso Length(advIDFamilia.Text) = 0 AndAlso Length(advIDSubFamilia.Text) = 0 Then
            If ExpertisApp.GenerateMessage("Se va a lanzar la Consulta Interactiva sin aplicar ningún filtro. Esto puede que retarde la obtención de información. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                blnFiltrar = True
            Else
                blnFiltrar = False
            End If
        Else
            blnFiltrar = True
        End If

        If blnFiltrar Then
            Me.Cursor = Cursors.WaitCursor
            e.Filter.Add("IDArticulo", FilterOperator.Equal, advIDArticulo.Text, FilterType.String)
            e.Filter.Add("IDActivo", FilterOperator.Equal, advIDActivo.Text, FilterType.String)
            e.Filter.Add("IDOperario", FilterOperator.Equal, advIDOperario.Text, FilterType.String)
            e.Filter.Add("IDTipo", FilterOperator.Equal, advIDTipo.Text, FilterType.String)
            e.Filter.Add("IDFamilia", FilterOperator.Equal, advIDFamilia.Text, FilterType.String)
            e.Filter.Add("IDSubFamilia", FilterOperator.Equal, advIDSubFamilia.Text, FilterType.String)
            If Length(txtTexto.Text) Then e.Filter.Add(New LikeFilterItem("Texto", txtTexto.Text, True))
            e.Filter.Add("FechaEstado", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
            e.Filter.Add("FechaEstado", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
            e.Filter.Add("IDEstadoActivo", FilterOperator.Equal, cbxEstadoActivo.Value, FilterType.Numeric)
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub CIHistEstMaquinas_QueryExecuted(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        Me.Cursor = Cursors.Default
        If Not IsNothing(Grid.DataSource) AndAlso Grid.RowCount = 0 Then
            ExpertisApp.GenerateMessage("Ningún conjunto de registros se ajusta a los criterios de selección.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CIHistEstMaquinas_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        cbxFechaDesde.TextBox.Clear()
        cbxFechaHasta.TextBox.Clear()
    End Sub

#End Region

    Private Sub advIDFamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advIDFamilia.SetPredefinedFilter
        If Length(advIDTipo.Text) > 0 Then
            e.Filter.Add("IDTipo", FilterOperator.Equal, advIDTipo.Text, FilterType.String)
        End If
    End Sub

    Private Sub advIDSubFamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advIDSubFamilia.SetPredefinedFilter
        If Length(advIDTipo.Text) > 0 Then
            e.Filter.Add("IDTipo", FilterOperator.Equal, advIDTipo.Text, FilterType.String)
        End If

        If Length(advIDFamilia.Text) > 0 Then
            e.Filter.Add("IDFamilia", FilterOperator.Equal, advIDFamilia.Text, FilterType.String)
        End If
    End Sub

    Private Sub advIDFamilia_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIDFamilia.SelectionChanged
        advIDSubFamilia.Text = String.Empty
    End Sub

    Private Sub advIDTipo_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIDTipo.SelectionChanged
        advIDFamilia.Text = String.Empty
        advIDSubFamilia.Text = String.Empty
    End Sub

    Private Sub cbxFechaHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaDesde.ValueChanged, cbxFechaHasta.ValueChanged
        If Length(cbxFechaDesde.Value) > 0 AndAlso Length(cbxFechaHasta.Value) > 0 Then
            If cbxFechaDesde.Value > cbxFechaHasta.Value Then
                ExpertisApp.GenerateMessage("La Fecha Hasta no puede ser más pequeña que la Fecha Desde.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbxFechaHasta.Value = System.DBNull.Value
                cbxFechaHasta.Focus()
            End If
        End If
    End Sub

End Class
