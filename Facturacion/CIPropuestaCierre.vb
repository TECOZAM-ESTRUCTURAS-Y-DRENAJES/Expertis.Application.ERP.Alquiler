Public Class CIPropuestaCierre
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

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
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblClienteDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblClienteHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCentroGestion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCentroGestion As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblClienteEventual As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaUltimaEntregaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaUltimaEntregaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDClienteDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDClienteHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxFechaUltimaEntregaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaUltimaEntregaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxClienteEventual As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxClienteEventual_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIPropuestaCierre))
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblClienteDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDClienteDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblClienteHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDClienteHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCentroGestion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblClienteEventual = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaUltimaEntregaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaUltimaEntregaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaUltimaEntregaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaUltimaEntregaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxClienteEventual = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxClienteEventual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.cbxClienteEventual)
        Me.FilterPanel.Controls.Add(Me.cbxFechaUltimaEntregaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaUltimaEntregaDesde)
        Me.FilterPanel.Controls.Add(Me.advIDTrabajo)
        Me.FilterPanel.Controls.Add(Me.advIDCentroGestion)
        Me.FilterPanel.Controls.Add(Me.advIDClienteHasta)
        Me.FilterPanel.Controls.Add(Me.advIDClienteDesde)
        Me.FilterPanel.Controls.Add(Me.advIDObraHasta)
        Me.FilterPanel.Controls.Add(Me.advIDObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblClienteDesde)
        Me.FilterPanel.Controls.Add(Me.lblClienteHasta)
        Me.FilterPanel.Controls.Add(Me.lblCentroGestion)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblClienteEventual)
        Me.FilterPanel.Controls.Add(Me.lblFechaUltimaEntregaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaUltimaEntregaHasta)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 246)
        Me.FilterPanel.Size = New System.Drawing.Size(720, 111)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(720, 246)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraCabecera"
        Me.Grid.KeyField = "IDTrabajo"
        Me.Grid.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid.Size = New System.Drawing.Size(720, 246)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vAlquilerCIPropuestaCierreOrdenes"
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
        Me.MainPanel.Size = New System.Drawing.Size(720, 357)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(720, 357)
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(8, 29)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(90, 13)
        Me.lblObraDesde.TabIndex = 0
        Me.lblObraDesde.Text = "Alquiler Desde"
        '
        'advIDObraDesde
        '
        Me.advIDObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advIDObraDesde.DisplayField = "NObra"
        Me.advIDObraDesde.EntityName = "ObraCabecera"
        Me.advIDObraDesde.Location = New System.Drawing.Point(99, 24)
        Me.advIDObraDesde.Name = "advIDObraDesde"
        Me.advIDObraDesde.SecondaryDataFields = "IDObra"
        Me.advIDObraDesde.Size = New System.Drawing.Size(128, 23)
        Me.advIDObraDesde.TabIndex = 0
        Me.advIDObraDesde.ViewName = "tbObraCabecera"
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(8, 55)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(86, 13)
        Me.lblObraHasta.TabIndex = 2
        Me.lblObraHasta.Text = "Alquiler Hasta"
        '
        'advIDObraHasta
        '
        Me.advIDObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advIDObraHasta.DisplayField = "NObra"
        Me.advIDObraHasta.EntityName = "ObraCabecera"
        Me.advIDObraHasta.Location = New System.Drawing.Point(99, 50)
        Me.advIDObraHasta.Name = "advIDObraHasta"
        Me.advIDObraHasta.SecondaryDataFields = "IDObra"
        Me.advIDObraHasta.Size = New System.Drawing.Size(128, 23)
        Me.advIDObraHasta.TabIndex = 1
        Me.advIDObraHasta.ViewName = "tbObraCabecera"
        '
        'lblClienteDesde
        '
        Me.lblClienteDesde.Location = New System.Drawing.Point(246, 29)
        Me.lblClienteDesde.Name = "lblClienteDesde"
        Me.lblClienteDesde.Size = New System.Drawing.Size(87, 13)
        Me.lblClienteDesde.TabIndex = 4
        Me.lblClienteDesde.Text = "Cliente Desde"
        '
        'advIDClienteDesde
        '
        Me.advIDClienteDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advIDClienteDesde.EntityName = "Cliente"
        Me.advIDClienteDesde.Location = New System.Drawing.Point(334, 24)
        Me.advIDClienteDesde.Name = "advIDClienteDesde"
        Me.advIDClienteDesde.SecondaryDataFields = "IDCliente"
        Me.advIDClienteDesde.Size = New System.Drawing.Size(128, 23)
        Me.advIDClienteDesde.TabIndex = 3
        Me.advIDClienteDesde.ViewName = "tbMaestroCliente"
        '
        'lblClienteHasta
        '
        Me.lblClienteHasta.Location = New System.Drawing.Point(246, 55)
        Me.lblClienteHasta.Name = "lblClienteHasta"
        Me.lblClienteHasta.Size = New System.Drawing.Size(83, 13)
        Me.lblClienteHasta.TabIndex = 6
        Me.lblClienteHasta.Text = "Cliente Hasta"
        '
        'advIDClienteHasta
        '
        Me.advIDClienteHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advIDClienteHasta.EntityName = "Cliente"
        Me.advIDClienteHasta.Location = New System.Drawing.Point(334, 50)
        Me.advIDClienteHasta.Name = "advIDClienteHasta"
        Me.advIDClienteHasta.SecondaryDataFields = "IDCliente"
        Me.advIDClienteHasta.Size = New System.Drawing.Size(128, 23)
        Me.advIDClienteHasta.TabIndex = 4
        Me.advIDClienteHasta.ViewName = "tbMaestroCliente"
        '
        'lblCentroGestion
        '
        Me.lblCentroGestion.Location = New System.Drawing.Point(246, 81)
        Me.lblCentroGestion.Name = "lblCentroGestion"
        Me.lblCentroGestion.Size = New System.Drawing.Size(67, 13)
        Me.lblCentroGestion.TabIndex = 8
        Me.lblCentroGestion.Text = "C. Gestión"
        '
        'advIDCentroGestion
        '
        Me.advIDCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCentroGestion.EntityName = "CentroGestion"
        Me.advIDCentroGestion.Location = New System.Drawing.Point(334, 76)
        Me.advIDCentroGestion.Name = "advIDCentroGestion"
        Me.advIDCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.advIDCentroGestion.Size = New System.Drawing.Size(128, 23)
        Me.advIDCentroGestion.TabIndex = 5
        Me.advIDCentroGestion.ViewName = "tbMaestroCentroGestion"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(8, 81)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(70, 13)
        Me.lblTrabajo.TabIndex = 10
        Me.lblTrabajo.Text = "O. Servicio"
        '
        'advIDTrabajo
        '
        Me.advIDTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTrabajo.DisplayField = "CodTrabajo"
        Me.advIDTrabajo.EntityName = "ObraTrabajo"
        Me.advIDTrabajo.Location = New System.Drawing.Point(99, 76)
        Me.advIDTrabajo.Name = "advIDTrabajo"
        Me.advIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.advIDTrabajo.Size = New System.Drawing.Size(128, 23)
        Me.advIDTrabajo.TabIndex = 2
        Me.advIDTrabajo.ViewName = "tbObraTrabajo"
        '
        'lblClienteEventual
        '
        Me.lblClienteEventual.Location = New System.Drawing.Point(476, 80)
        Me.lblClienteEventual.Name = "lblClienteEventual"
        Me.lblClienteEventual.Size = New System.Drawing.Size(100, 13)
        Me.lblClienteEventual.TabIndex = 12
        Me.lblClienteEventual.Text = "Cliente Eventual"
        '
        'lblFechaUltimaEntregaDesde
        '
        Me.lblFechaUltimaEntregaDesde.Location = New System.Drawing.Point(476, 29)
        Me.lblFechaUltimaEntregaDesde.Name = "lblFechaUltimaEntregaDesde"
        Me.lblFechaUltimaEntregaDesde.Size = New System.Drawing.Size(128, 13)
        Me.lblFechaUltimaEntregaDesde.TabIndex = 14
        Me.lblFechaUltimaEntregaDesde.Text = "Fecha Últ. Entrega D."
        '
        'cbxFechaUltimaEntregaDesde
        '
        Me.cbxFechaUltimaEntregaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaUltimaEntregaDesde.Location = New System.Drawing.Point(608, 26)
        Me.cbxFechaUltimaEntregaDesde.Name = "cbxFechaUltimaEntregaDesde"
        Me.cbxFechaUltimaEntregaDesde.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaUltimaEntregaDesde.TabIndex = 6
        '
        'lblFechaUltimaEntregaHasta
        '
        Me.lblFechaUltimaEntregaHasta.Location = New System.Drawing.Point(476, 55)
        Me.lblFechaUltimaEntregaHasta.Name = "lblFechaUltimaEntregaHasta"
        Me.lblFechaUltimaEntregaHasta.Size = New System.Drawing.Size(127, 13)
        Me.lblFechaUltimaEntregaHasta.TabIndex = 16
        Me.lblFechaUltimaEntregaHasta.Text = "Fecha Últ. Entrega H."
        '
        'cbxFechaUltimaEntregaHasta
        '
        Me.cbxFechaUltimaEntregaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaUltimaEntregaHasta.Location = New System.Drawing.Point(608, 51)
        Me.cbxFechaUltimaEntregaHasta.Name = "cbxFechaUltimaEntregaHasta"
        Me.cbxFechaUltimaEntregaHasta.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaUltimaEntregaHasta.TabIndex = 7
        '
        'cbxClienteEventual
        '
        Me.TryDataBinding(cbxClienteEventual, New System.Windows.Forms.Binding("Value", Me, "ClienteEventual", True))
        cbxClienteEventual_DesignTimeLayout.LayoutString = resources.GetString("cbxClienteEventual_DesignTimeLayout.LayoutString")
        Me.cbxClienteEventual.DesignTimeLayout = cbxClienteEventual_DesignTimeLayout
        Me.cbxClienteEventual.DisabledBackColor = System.Drawing.Color.White
        Me.cbxClienteEventual.Location = New System.Drawing.Point(608, 76)
        Me.cbxClienteEventual.Name = "cbxClienteEventual"
        Me.cbxClienteEventual.SelectedIndex = -1
        Me.cbxClienteEventual.SelectedItem = Nothing
        Me.cbxClienteEventual.Size = New System.Drawing.Size(97, 21)
        Me.cbxClienteEventual.TabIndex = 8
        '
        'CIPropuestaCierre
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(728, 445)
        Me.EntityName = "ObraCabecera"
        Me.KeyField = "IDTrabajo"
        Me.Name = "CIPropuestaCierre"
        Me.Text = "CIPropuestaCierre"
        Me.UseCheck = True
        Me.ViewName = "vAlquilerCIPropuestaCierreOrdenes"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxClienteEventual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MBlnCheckAll As Boolean = False
    Private MBlnExistAll As Boolean = False
    Private mTipoAlbaranDeposito As String

#Region " Load "

    Private Sub CIPropuestaCierre_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        LoadToolBarActions()
        LoadParams()
        InitFilterCriteria()
    End Sub

    Private Sub LoadEnums()
        cbxClienteEventual.DataSource = New EnumData("enumBoolean")
    End Sub

    Private Sub LoadToolBarActions()
        Me.FormActions.Add("Cerrar Ordenes", AddressOf AccionCerrarOrdenes, ExpertisApp.GetIcon("Lock.ico"))
    End Sub

    Private Sub LoadParams()
        mTipoAlbaranDeposito = New Parametro().TipoAlbaranDeDeposito
    End Sub

    Private Sub InitFilterCriteria()
        cbxClienteEventual.Value = enumBoolean.Todos
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub AccionCerrarOrdenes()
        If ExpertisApp.GenerateMessage("Se cerrarán las órdenes seleccionadas. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim dt As DataTable = Grid.CheckedRecords
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                Me.Cursor = Cursors.WaitCursor

                Dim info As New ObraTrabajo.dataCambiarEstadoTrabajo(dt, enumotEstado.otTerminado)
                ExpertisApp.ExecuteTask(Of ObraTrabajo.dataCambiarEstadoTrabajo)(AddressOf ObraTrabajo.CambiarEstadoTrabajo, info)

                Me.Cursor = Cursors.Default
                Grid.UnCheckAllRecords()
                Me.Execute()
                ExpertisApp.GenerateMessage("Proceso Finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ExpertisApp.GenerateMessage("No ha seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

#Region " QueryExecuting "

    Private Sub CIPropuestaCierre_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If Length(advIDObraDesde.Value) > 0 Then e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, advIDObraDesde.Value, FilterType.Numeric)
        If Length(advIDObraHasta.Value) > 0 Then e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, advIDObraHasta.Value, FilterType.Numeric)
        If Length(advIDClienteDesde.Value) > 0 Then e.Filter.Add("IDCliente", FilterOperator.GreaterThanOrEqual, advIDClienteDesde.Value, FilterType.String)
        If Length(advIDClienteHasta.Value) > 0 Then e.Filter.Add("IDCliente", FilterOperator.LessThanOrEqual, advIDClienteHasta.Value, FilterType.String)
        If Length(advIDTrabajo.Value) > 0 Then e.Filter.Add("IDTrabajo", FilterOperator.Equal, advIDTrabajo.Value, FilterType.Numeric)
        If Length(advIDCentroGestion.Value) > 0 Then e.Filter.Add("IDCentroGestion", FilterOperator.Equal, advIDCentroGestion.Value, FilterType.String)
        If cbxClienteEventual.Value <> enumBoolean.Todos Then
            If Length(cbxClienteEventual.Value) > 0 Then e.Filter.Add("ClienteEventual", FilterOperator.Equal, cbxClienteEventual.Value, FilterType.Boolean)
        End If
        If Length(cbxFechaUltimaEntregaDesde.Value) > 0 Then e.Filter.Add("FechaUltimaEntrega", FilterOperator.GreaterThanOrEqual, cbxFechaUltimaEntregaDesde.Value, FilterType.DateTime)
        If Length(cbxFechaUltimaEntregaHasta.Value) > 0 Then e.Filter.Add("FechaUltimaEntrega", FilterOperator.LessThanOrEqual, cbxFechaUltimaEntregaHasta.Value, FilterType.DateTime)
    End Sub

    Private Sub CIPropuestaCierre_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        cbxFechaUltimaEntregaDesde.TextBox.Clear()
        cbxFechaUltimaEntregaHasta.TextBox.Clear()
    End Sub

    Private Sub CIPropuestaCierre_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        InitFilterCriteria()
    End Sub

#End Region

    Private Sub CIPropuestaCierre_CheckingAllRecord(ByVal sender As Object, ByVal e As Engine.UI.CheckingAllEventArgs) Handles MyBase.CheckingAllRecord
        MBlnCheckAll = True
    End Sub

    Private Sub CIPropuestaCierre_AllRecordChecked(ByVal sender As Object, ByVal e As Engine.UI.AllCheckedEventArgs) Handles MyBase.AllRecordChecked
        If MBlnExistAll Then
            ExpertisApp.GenerateMessage("No se pueden cerrar algunas Ordenes de Servicio, tienen materiales pendientes de servir o de ser devueltos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        MBlnCheckAll = False
    End Sub

    Private Sub CIPropuestaCierre_CheckingRecord(ByVal sender As Object, ByVal e As Engine.UI.CheckingEventArgs) Handles MyBase.CheckingRecord
        If e.CheckState = CheckStates.UnChecked Then
            If Not ValidarTrabajoTerminado(e.Row) Then
                If Not MBlnCheckAll Then
                    ExpertisApp.GenerateMessage("No se puede cambiar el estado de la Orden de Servicio a Terminado. Existen Líneas con materiales pendientes de servir o de ser devueltos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MBlnExistAll = True
                End If
                e.Cancel = True
            End If
        End If
    End Sub

    Private Function ValidarTrabajoTerminado(ByVal e As Janus.Windows.GridEX.GridEXRow) As Boolean
        Return General.ValidarTrabajoTerminado(e.Cells("IDTrabajo").Value, mTipoAlbaranDeposito)
    End Function

End Class