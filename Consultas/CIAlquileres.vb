Public Class CIAlquileres
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtDiaFacturacion.Value = System.DBNull.Value
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
    Friend WithEvents cbxIDCentroGestion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblCentroGestion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipoAlquiler As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDiaFacturacion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblDiaFacturacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDTipoAlquiler As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDCentroGestion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIAlquileres))
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cbxIDCentroGestion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoAlquiler = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDiaFacturacion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDiaFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDTipoAlquiler = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxIDCentroGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.advIDTipoAlquiler)
        Me.FilterPanel.Controls.Add(Me.advIDObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblCentroGestion)
        Me.FilterPanel.Controls.Add(Me.lblTipoAlquiler)
        Me.FilterPanel.Controls.Add(Me.lblDiaFacturacion)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblEstado)
        Me.FilterPanel.Controls.Add(Me.cbxIDCentroGestion)
        Me.FilterPanel.Controls.Add(Me.txtDiaFacturacion)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.advIDCliente)
        Me.FilterPanel.Controls.Add(Me.advIDObraDesde)
        Me.FilterPanel.Controls.Add(Me.cbxEstado)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 194)
        Me.FilterPanel.Size = New System.Drawing.Size(654, 107)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(654, 194)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraCabecera"
        Me.Grid.KeyField = "IDObra"
        Me.Grid.Size = New System.Drawing.Size(654, 194)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vAlquilerCIConsultaAlquileres"
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
        Me.MainPanel.Size = New System.Drawing.Size(654, 301)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(654, 301)
        '
        'cbxIDCentroGestion
        '
        cbxIDCentroGestion_DesignTimeLayout.LayoutString = resources.GetString("cbxIDCentroGestion_DesignTimeLayout.LayoutString")
        Me.cbxIDCentroGestion.DesignTimeLayout = cbxIDCentroGestion_DesignTimeLayout
        Me.cbxIDCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDCentroGestion.DisplayMember = "IDCentroGestion"
        Me.cbxIDCentroGestion.EntityName = "CentroGestion"
        Me.cbxIDCentroGestion.Location = New System.Drawing.Point(332, 75)
        Me.cbxIDCentroGestion.Name = "cbxIDCentroGestion"
        Me.cbxIDCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.cbxIDCentroGestion.SelectedIndex = -1
        Me.cbxIDCentroGestion.SelectedItem = Nothing
        Me.cbxIDCentroGestion.Size = New System.Drawing.Size(105, 21)
        Me.cbxIDCentroGestion.TabIndex = 5
        Me.cbxIDCentroGestion.ValueMember = "IDCentroGestion"
        Me.cbxIDCentroGestion.ViewName = "tbMaestroCentroGestion"
        '
        'lblCentroGestion
        '
        Me.lblCentroGestion.Location = New System.Drawing.Point(231, 79)
        Me.lblCentroGestion.Name = "lblCentroGestion"
        Me.lblCentroGestion.Size = New System.Drawing.Size(93, 13)
        Me.lblCentroGestion.TabIndex = 0
        Me.lblCentroGestion.Text = "Centro Gestión"
        '
        'lblTipoAlquiler
        '
        Me.lblTipoAlquiler.Location = New System.Drawing.Point(231, 53)
        Me.lblTipoAlquiler.Name = "lblTipoAlquiler"
        Me.lblTipoAlquiler.Size = New System.Drawing.Size(78, 13)
        Me.lblTipoAlquiler.TabIndex = 6
        Me.lblTipoAlquiler.Text = "Tipo Alquiler"
        '
        'txtDiaFacturacion
        '
        Me.txtDiaFacturacion.DecimalDigits = 0
        Me.txtDiaFacturacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDiaFacturacion.Location = New System.Drawing.Point(332, 24)
        Me.txtDiaFacturacion.Name = "txtDiaFacturacion"
        Me.txtDiaFacturacion.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtDiaFacturacion.Size = New System.Drawing.Size(104, 21)
        Me.txtDiaFacturacion.TabIndex = 3
        '
        'lblDiaFacturacion
        '
        Me.lblDiaFacturacion.Location = New System.Drawing.Point(231, 27)
        Me.lblDiaFacturacion.Name = "lblDiaFacturacion"
        Me.lblDiaFacturacion.Size = New System.Drawing.Size(94, 13)
        Me.lblDiaFacturacion.TabIndex = 8
        Me.lblDiaFacturacion.Text = "Día Facturación"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(539, 50)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaHasta.TabIndex = 7
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(457, 54)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 9
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(539, 25)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaDesde.TabIndex = 6
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(457, 27)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 10
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(10, 54)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(86, 13)
        Me.lblObraHasta.TabIndex = 11
        Me.lblObraHasta.Text = "Alquiler Hasta"
        '
        'advIDCliente
        '
        Me.advIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCliente.EntityName = "Cliente"
        Me.advIDCliente.Location = New System.Drawing.Point(103, 75)
        Me.advIDCliente.Name = "advIDCliente"
        Me.advIDCliente.PrimaryDataFields = "IDCliente"
        Me.advIDCliente.SecondaryDataFields = "IDCliente"
        Me.advIDCliente.Size = New System.Drawing.Size(110, 23)
        Me.advIDCliente.TabIndex = 2
        Me.advIDCliente.ViewName = "tbMaestroCliente"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(10, 79)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 13
        Me.lblCliente.Text = "Cliente"
        '
        'advIDObraDesde
        '
        Me.advIDObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advIDObraDesde.DisplayField = "NObra"
        Me.advIDObraDesde.EntityName = "ObraCabecera"
        Me.advIDObraDesde.Location = New System.Drawing.Point(103, 23)
        Me.advIDObraDesde.Name = "advIDObraDesde"
        Me.advIDObraDesde.SecondaryDataFields = "IDObra"
        Me.advIDObraDesde.Size = New System.Drawing.Size(110, 23)
        Me.advIDObraDesde.TabIndex = 0
        Me.advIDObraDesde.ViewName = "tbObraCabecera"
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(10, 27)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(90, 13)
        Me.lblObraDesde.TabIndex = 15
        Me.lblObraDesde.Text = "Alquiler Desde"
        '
        'cbxEstado
        '
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.Location = New System.Drawing.Point(539, 75)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(100, 21)
        Me.cbxEstado.TabIndex = 8
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(457, 79)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 17
        Me.lblEstado.Text = "Estado"
        '
        'advIDObraHasta
        '
        Me.advIDObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advIDObraHasta.DisplayField = "NObra"
        Me.advIDObraHasta.EntityName = "ObraCabecera"
        Me.advIDObraHasta.Location = New System.Drawing.Point(103, 49)
        Me.advIDObraHasta.Name = "advIDObraHasta"
        Me.advIDObraHasta.SecondaryDataFields = "IDObra"
        Me.advIDObraHasta.Size = New System.Drawing.Size(110, 23)
        Me.advIDObraHasta.TabIndex = 1
        Me.advIDObraHasta.ViewName = "tbObraCabecera"
        '
        'advIDTipoAlquiler
        '
        Me.advIDTipoAlquiler.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTipoAlquiler.Enabled = False
        Me.advIDTipoAlquiler.EntityName = "ObraTipo"
        Me.advIDTipoAlquiler.Location = New System.Drawing.Point(332, 48)
        Me.advIDTipoAlquiler.Name = "advIDTipoAlquiler"
        Me.advIDTipoAlquiler.SecondaryDataFields = "IDTipoObra"
        Me.advIDTipoAlquiler.Size = New System.Drawing.Size(104, 23)
        Me.advIDTipoAlquiler.TabIndex = 4
        Me.advIDTipoAlquiler.ViewName = "tbObraTipo"
        '
        'CIAlquileres
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(662, 389)
        Me.EntityName = "ObraCabecera"
        Me.KeyField = "IDObra"
        Me.Name = "CIAlquileres"
        Me.UseCheck = True
        Me.ViewName = "vAlquilerCIConsultaAlquileres"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxIDCentroGestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mdtInforme As DataTable

#Region " Load "

    Private Sub CIAlquileres_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadEnums()
            LoadGridActions()
            LoadToolbarActions()
            LoadParams()
        End If
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            Dim ht As Hashtable = Me.Params
            advIDCliente.Text = ht("IDCliente")
            advIDObraDesde.Value = ht("IDObra")
            advIDObraDesde.Text = ht("NObra")
            advIDObraHasta.Value = ht("IDObra")
            advIDObraHasta.Text = ht("NObra")

            Me.Execute()
        End If
    End Sub

    Private Sub LoadEnums()
        cbxEstado.DataSource = New EnumData("enumocEstado")
        EnumData.PopulateValueList("enumocEstado", Grid.Columns("Estado"))
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Modificación de Días del Calendario", AddressOf AccionCambiarDias, ExpertisApp.GetIcon("calendar_up.ico"))
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add(cnABRIRALQUILER, AddressOf AccionAbrirAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
        Grid.Actions.Add(cnABRIRCLIENTE, AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
        Grid.Actions.Add("Ver Albarán Venta Detallada", AddressOf AccionAbrirEstadisticasAlbaranes, ExpertisApp.GetIcon("xEstadistica.ico"))
        Grid.Actions.Add(cnCALENDARIO, AddressOf AccionAbrirCalendario, ExpertisApp.GetIcon("calendar.ico"))
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub AccionCambiarDias()
        If Grid.RowCount > 0 AndAlso Grid.CheckedRecordsCount > 0 Then
            Dim FechaDesde, FechaHasta As Date
            Dim TipoDia As Integer
            Dim frmCambio As New frmCambioDia
            If frmCambio.AbrirCambioDia(FechaDesde, FechaHasta, TipoDia) = DialogResult.OK Then
                Dim dt As DataTable = Grid.CheckedRecords
                If dt.Rows.Count > 0 Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim data As New CalendarioObra.dataActualizarDias(dt, TipoDia, FechaDesde, FechaHasta)
                    ExpertisApp.ExecuteTask(Of CalendarioObra.dataActualizarDias)(AddressOf CalendarioObra.ActualizarDias, data)

                    Me.Cursor = Cursors.Default
                    ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UnCheckAllRecords()
                End If
            End If
        End If
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirAlquiler()
        AbrirMntoAlquiler(Grid.Value("IDObra"))
    End Sub

    Private Sub AccionAbrirCliente()
        AbrirMntoCliente(Grid.Value("IDCliente"))
    End Sub

    Private Sub AccionAbrirEstadisticasAlbaranes()
        If Length(Grid.Value("IDObra")) > 0 Then
            If ExpertisApp.IsFormOpen("EAVD") Then ExpertisApp.CloseForm("EAVD")
            Dim HT As New Hashtable
            HT("IDObra") = Grid.Value("IDObra")
            HT("NObra") = Grid.Value("NObra")
            ExpertisApp.OpenForm("EAVD", , HT)
        End If
    End Sub

    Private Sub AccionAbrirCalendario()
        If Length(Grid.Value("IDObra")) > 0 Then
            AbrirMntoCalendarioAlquiler(Grid.Value("IDObra"))
        End If
    End Sub

#End Region

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)

        cbxFechaDesde.TextBox.Clear()
        cbxFechaHasta.TextBox.Clear()
    End Sub

    Private Sub CIAlquileres_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, advIDObraDesde.Value, FilterType.Numeric)
        e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, advIDObraHasta.Value, FilterType.Numeric)
        e.Filter.Add("IDCliente", FilterOperator.Equal, advIDCliente.Text, FilterType.String)
        e.Filter.Add("FechaObra", FilterOperator.GreaterThan, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaObra", FilterOperator.LessThan, cbxFechaHasta.Value, FilterType.DateTime)
        e.Filter.Add("Estado", FilterOperator.Equal, cbxEstado.Value, FilterType.Numeric)
        e.Filter.Add("IDCentroGestion", FilterOperator.Equal, cbxIDCentroGestion.Value, FilterType.String)
        e.Filter.Add("DiaFacturacion", FilterOperator.Equal, txtDiaFacturacion.Text, FilterType.Numeric)
        e.Filter.Add("IDTipoObra", FilterOperator.Equal, advIDTipoAlquiler.Text, FilterType.String)
    End Sub

    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(Grid) AndAlso Grid.RowCount > 0 Then
                Grid.UiCommandManager1.Commands(cnABRIRCliente).Visible = Janus.Windows.UI.InheritableBoolean.False
                If Length(Grid.Value("IDCliente")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIRCLIENTE).Visible = Janus.Windows.UI.InheritableBoolean.True
                End If
            End If
        End If
    End Sub

#Region " Informes"

    Private Sub CIAlquileres_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        If e.Alias.ToUpper = "PREFACT" Then
            If Not IsNothing(mdtInforme) AndAlso mdtInforme.Rows.Count > 0 Then
                Dim dv As DataView = mdtInforme.DefaultView
                dv.Sort = "IDCliente"
                Dim dtInformeOrdenado As DataTable = mdtInforme.Clone
                Dim drIO As DataRow
                For Each drv As DataRowView In dv
                    drIO = dtInformeOrdenado.NewRow
                    drIO.ItemArray = drv.Row.ItemArray
                    dtInformeOrdenado.Rows.Add(drIO)
                Next

                ''Calculo del IVA
                'Dim data As New BusinessRuleData
                'data.ColumnName = "IDArticulo"
                'For Each dr As DataRow In dtInformeOrdenado.Rows
                '    data.Value = dr("IDArticulo")
                '    data.Current = New DataRowPropertyAccessor(dr)
                '    Dim context As New BusinessData
                '    context("IDCliente") = dr("IDCliente")
                '    data.Context = context
                '    Dim IDTipoIva As String = ExpertisApp.ExecuteTask(Of BusinessRuleData, String)(AddressOf ProcesoComercial.ObtenerIvaArticuloCliente, data)
                '    If Length(IDTipoIva) > 0 Then
                '        Dim dtTI As DataTable = New TipoIva().SelOnPrimaryKey(IDTipoIva)
                '        If Not IsNothing(dtTI) AndAlso dtTI.Rows.Count > 0 Then
                '            Dim Factor As Double = Factor = Nz(dtTI.Rows(0)("Factor"), 0)
                '            dr("ImpIVA") = Factor / 100
                '        End If
                '    End If
                'Next
                e.DataSource = dtInformeOrdenado
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub CIAlquileres_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        If e.Alias.ToUpper = "PREFACT" Then
            e.Formulas.Item("TipoAgrupacion").Text = "DesdeConsulta"
            e.Formulas.Item("CondicionesCliente").Text = 2
            ImprimirPrevisionFactura()
        End If
    End Sub

    Private Sub ImprimirPrevisionFactura()
        If Grid.CheckedRecordsCount > 0 Then
            Dim frmFecha As New frmFechaConsultaVto
            If frmFecha.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor
                Dim dtFecha As Date = frmFecha.cbxFecha.Value
                Dim IDProcess As Guid = Grid.SaveServerChecks
                Dim dt As DataTable = New BE.DataEngine().Filter("vAlquilerCIConsultaAlquileres", New GuidFilterItem("IDProcess", IDProcess))
                If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                    Dim IDObra(-1) As Object
                    For Each dr As DataRow In dt.Rows
                        ReDim Preserve IDObra(UBound(IDObra) + 1)
                        IDObra(UBound(IDObra)) = dr("IDObra")
                    Next
                    If IDObra.Length > 0 Then
                        Dim f As New Filter
                        f.Add(New InListFilterItem("IDObra", IDObra, FilterType.Numeric))

                        Dim datosVtos As New dataConfigCalculoFacturacion(dtFecha, f, 0, False, False, 1, String.Empty)
                        Dim dtVtos As DataTable = ExpertisApp.ExecuteTask(Of dataConfigCalculoFacturacion, DataTable)(AddressOf CalculoFacturacion.GetLineasFacturacionAlquiler, datosVtos)
                        If Not IsNothing(dtVtos) AndAlso dtVtos.Rows.Count > 0 Then
                            Dim infoReport As New dataInformeVtosAlquiler(dtVtos, f)
                            mdtInforme = ExpertisApp.ExecuteTask(Of dataInformeVtosAlquiler, DataTable)(AddressOf CalculoFacturacion.InformeVtosAlquiler, infoReport)
                        End If
                    End If
                End If
            End If
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub CIAlquileres_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        If e.Alias.ToUpper = "INCO" Then
            Dim frm As New frmFechaIncidencias
            frm.ShowDialog()
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim f As Filter = CriteriosConsultaCrystal()
                f.Add(frm.mFiltro)
                e.Filter.Add(f)
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Function CriteriosConsultaCrystal() As Filter
        Dim f As New Filter
        If Length(cbxFechaDesde.Value) > 0 Then f.Add("FechaObra", FilterOperator.GreaterThan, cbxFechaDesde.Value, FilterType.DateTime)
        If Length(cbxFechaHasta.Value) > 0 Then f.Add("FechaObra", FilterOperator.LessThan, cbxFechaHasta.Value, FilterType.DateTime)
        If Length(advIDObraDesde.Value) > 0 Then f.Add("IDObra", FilterOperator.GreaterThanOrEqual, advIDObraDesde.Value, FilterType.Numeric)
        If Length(advIDObraHasta.Value) > 0 Then f.Add("IDObra", FilterOperator.LessThanOrEqual, advIDObraHasta.Value, FilterType.Numeric)
        If Length(advIDCliente.Text) > 0 Then f.Add("IDCliente", FilterOperator.Equal, advIDCliente.Text, FilterType.String)
        If Length(cbxEstado.Value) > 0 Then f.Add("Estado", FilterOperator.Equal, cbxEstado.Value, FilterType.Numeric)
        If Length(cbxIDCentroGestion.Value) > 0 Then f.Add("IDCentroGestion", FilterOperator.Equal, cbxIDCentroGestion.Value, FilterType.String)
        If Length(txtDiaFacturacion.Text) > 0 Then f.Add("DiaFacturacion", FilterOperator.Equal, txtDiaFacturacion.Text, FilterType.Numeric)
        If Length(advIDTipoAlquiler.Text) > 0 Then f.Add("IDTipoObra", FilterOperator.Equal, advIDTipoAlquiler.Text, FilterType.String)

        Return f
    End Function

#End Region

End Class
