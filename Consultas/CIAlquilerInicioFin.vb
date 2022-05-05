Public Class CIAlquilerInicioFin
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
    Friend WithEvents advIDTipoAlbaran As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulDescTipoAlbaran As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaActualizacionMasiva As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents pnlActualizacionMasivaFechaAlquiler As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblTipoAlbaran As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIAlquilerInicioFin))
        Me.advIDTipoAlbaran = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescTipoAlbaran = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaActualizacionMasiva = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblTipoAlbaran = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlActualizacionMasivaFechaAlquiler = New Solmicro.Expertis.Engine.UI.Panel
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.pnlActualizacionMasivaFechaAlquiler.suspendlayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblTipoAlbaran)
        Me.FilterPanel.Controls.Add(Me.ulDescTipoAlbaran)
        Me.FilterPanel.Controls.Add(Me.advIDTipoAlbaran)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 283)
        Me.FilterPanel.Size = New System.Drawing.Size(648, 66)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.pnlActualizacionMasivaFechaAlquiler)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(648, 283)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.pnlActualizacionMasivaFechaAlquiler, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "AlbaranVentaLinea"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDLineaAlbaran"
        Me.Grid.Location = New System.Drawing.Point(0, 35)
        Me.Grid.Size = New System.Drawing.Size(648, 248)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vAlquilerCIAlquilerInicioFin"
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
        Me.Toolbar.Size = New System.Drawing.Size(391, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(648, 349)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(648, 349)
        '
        'advIDTipoAlbaran
        '
        Me.advIDTipoAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTipoAlbaran.EntityName = "TipoAlbaran"
        Me.advIDTipoAlbaran.Location = New System.Drawing.Point(115, 26)
        Me.advIDTipoAlbaran.Name = "advIDTipoAlbaran"
        Me.advIDTipoAlbaran.PrimaryDataFields = "IDTipoAlbaran"
        Me.advIDTipoAlbaran.SecondaryDataFields = "IDTipoAlbaran"
        Me.advIDTipoAlbaran.Size = New System.Drawing.Size(85, 23)
        Me.advIDTipoAlbaran.TabIndex = 2
        Me.advIDTipoAlbaran.ViewName = "tbMaestroTipoAlbaran"
        '
        'ulDescTipoAlbaran
        '
        Me.TryDataBinding(ulDescTipoAlbaran, New System.Windows.Forms.Binding("Text", Me.advIDTipoAlbaran, "DescTipoAlbaran", True))
        Me.ulDescTipoAlbaran.Location = New System.Drawing.Point(206, 26)
        Me.ulDescTipoAlbaran.Name = "ulDescTipoAlbaran"
        Me.ulDescTipoAlbaran.Size = New System.Drawing.Size(212, 23)
        Me.ulDescTipoAlbaran.TabIndex = 5
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(15, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(162, 13)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "Fecha actualización masiva"
        '
        'cbxFechaActualizacionMasiva
        '
        Me.cbxFechaActualizacionMasiva.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaActualizacionMasiva.Location = New System.Drawing.Point(181, 5)
        Me.cbxFechaActualizacionMasiva.Name = "cbxFechaActualizacionMasiva"
        Me.cbxFechaActualizacionMasiva.Size = New System.Drawing.Size(93, 21)
        Me.cbxFechaActualizacionMasiva.TabIndex = 6
        '
        'lblTipoAlbaran
        '
        Me.lblTipoAlbaran.Location = New System.Drawing.Point(30, 31)
        Me.lblTipoAlbaran.Name = "lblTipoAlbaran"
        Me.lblTipoAlbaran.Size = New System.Drawing.Size(79, 13)
        Me.lblTipoAlbaran.TabIndex = 7
        Me.lblTipoAlbaran.Text = "Tipo Albarán"
        '
        'pnlActualizacionMasivaFechaAlquiler
        '
        Me.pnlActualizacionMasivaFechaAlquiler.Controls.Add(Me.lblFecha)
        Me.pnlActualizacionMasivaFechaAlquiler.Controls.Add(Me.cbxFechaActualizacionMasiva)
        Me.pnlActualizacionMasivaFechaAlquiler.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlActualizacionMasivaFechaAlquiler.Location = New System.Drawing.Point(0, 0)
        Me.pnlActualizacionMasivaFechaAlquiler.Name = "pnlActualizacionMasivaFechaAlquiler"
        Me.pnlActualizacionMasivaFechaAlquiler.Size = New System.Drawing.Size(648, 35)
        Me.pnlActualizacionMasivaFechaAlquiler.TabIndex = 1
        '
        'CIAlquilerInicioFin
        '
        Me.AllowUpdate = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(656, 437)
        Me.EntityName = "AlbaranVentaLinea"
        Me.KeyField = "IDLineaAlbaran"
        Me.Name = "CIAlquilerInicioFin"
        Me.UseCheck = True
        Me.ViewName = "vAlquilerCIAlquilerInicioFin"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.pnlActualizacionMasivaFechaAlquiler.ResumeLayout(False)
        Me.pnlActualizacionMasivaFechaAlquiler.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mTipoAlbaranDeposito, mTipoAlbaranRetornoAlquiler As String

#Region " Load "

    Private Sub CIAlquilerInicioFin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadToolbarActions()
            LoadGridActions()
        End If
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Clear()
        Me.FormActions.Add("Actualizar Fechas Alquiler", AddressOf AccionActualizarFechasAlquiler, ExpertisApp.GetIcon("calendar.ico"))
        Me.FormActions.Add("Recalcular Fechas de Retorno de Días Mínimos", AddressOf AccionRecalcularFechaRetorno, ExpertisApp.GetIcon("date-time_preferences.ico"))
    End Sub

    Private Sub LoadERPData()
        Dim p As New Parametro
        mTipoAlbaranDeposito = p.TipoAlbaranDeDeposito
        mTipoAlbaranRetornoAlquiler = p.TipoAlbaranRetornoAlquiler
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add(cnABRRIRARTICULO, AddressOf AccionAbrirArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
        Grid.Actions.Add(cnABRIRALBARANVENTA, AddressOf AccionAbrirAlbaranVenta, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub AccionActualizarFechasAlquiler()
        If Length(cbxFechaActualizacionMasiva.Value) > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            If dtMarcados Is Nothing OrElse dtMarcados.Rows.Count = 0 Then
                ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Me.Cursor = Cursors.WaitCursor

                Dim f As New Filter
                f.Add(New DateFilterItem("FechaMaxima", FilterOperator.GreaterThan, cbxFechaActualizacionMasiva.Value))
                f.Add(New IsNullFilterItem("FechaMaxima", False))

                Dim dtActualizar As DataTable = dtMarcados.Copy
                For Each drMarcados As DataRow In dtActualizar.Select(f.Compose(New AdoFilterComposer))
                    dtActualizar.Rows.Remove(drMarcados)
                Next

                Dim blnCancel As Boolean
                If dtActualizar.Rows.Count <> dtMarcados.Rows.Count Then
                    If ExpertisApp.GenerateMessage("No se tendrán en cuenta las líneas cuya Fecha de Último Vencimiento sea superior a la Fecha de Alquiler.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                        blnCancel = True
                    End If
                End If

                If Not blnCancel Then
                    If Not dtActualizar Is Nothing AndAlso dtActualizar.Rows.Count > 0 Then
                        Dim IDLineaAlbaran(-1) As Object
                        For Each drMarcados As DataRow In dtActualizar.Select
                            ReDim Preserve IDLineaAlbaran(UBound(IDLineaAlbaran) + 1)
                            IDLineaAlbaran(UBound(IDLineaAlbaran)) = drMarcados("IDLineaAlbaran")
                        Next
                        Dim data As New GeneralAlquiler.DatosActualizarFechaAlquilerAlbaran(IDLineaAlbaran, cbxFechaActualizacionMasiva.Value)
                        ExpertisApp.ExecuteTask(Of GeneralAlquiler.DatosActualizarFechaAlquilerAlbaran)(AddressOf GeneralAlquiler.ActualizarFechasAlquiler, data)

                        ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Me.Cursor = Cursors.Default
                Grid.UnCheckAllRecords()
                Me.Execute()
            End If
        Else
            ExpertisApp.GenerateMessage("Debe indicar una fecha para poder realizar la actualización.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Sub AccionRecalcularFechaRetorno()
        Dim dtMarcados As DataTable = Me.CheckedRecords
        If dtMarcados Is Nothing OrElse dtMarcados.Rows.Count = 0 Then
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.Cursor = Cursors.WaitCursor

            RecalculoFechaRetorno(dtMarcados, mTipoAlbaranDeposito)

            Me.Cursor = Cursors.Default
            Grid.UnCheckAllRecords()
            Me.Execute()
        End If
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirArticulo()
        AbrirMntoArticulo(Grid.Value("IDArticulo"))
    End Sub

    Private Sub AccionAbrirAlbaranVenta()
        AbrirMntoAlbaranVenta(Grid.Value("IDAlbaran"))
    End Sub

#End Region

#Region " Grid "

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If e.Row.Cells("FechaAlbaran").Value = e.Row.Cells("FechaAlquiler").Value Then
                e.Row.RowStyle = Grid.FormatStyles("FmtFechasIguales")
            End If
        End If
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        With Grid
            Select Case e.Column.Key
                Case "FechaAlquiler"
                    If .Value("FechaAlquiler") < .Value("FechaMaxima") Then
                        e.Cancel = True
                    End If
            End Select
        End With
    End Sub

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        With Grid
            Select Case e.Column.Key
                Case "HoraAlquiler"
                    If Length(.Value(e.Column.Key)) > 0 Then
                        If Not InStr(1, .Value(e.Column.Key), ":") > 0 Then
                            If (.Value(e.Column.Key)) < 24 Then
                                .Value(e.Column.Key) = .Value(e.Column.Key) & ":00"
                            Else
                                .Value(e.Column.Key) = "00:00"
                            End If
                        End If
                    End If
                Case "FechaAlquiler"
                    If Not Nz(.Value("FechaAlquiler"), cnMinDate) > Nz(.Value("FechaMaxima"), cnMinDate) Then
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("La Fecha de Alquiler debe ser superior a la Fecha del Último Vencimiento de la Línea.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select
        End With
    End Sub

#End Region

#Region " Consulta interactiva  "

    Private Sub CIAlquilerInicioFin_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDTipoAlbaran", FilterOperator.Equal, advIDTipoAlbaran.Text, FilterType.String)
        e.Filter.Add(New InListFilterItem("IDTipoAlbaran", New String() {mTipoAlbaranDeposito, mTipoAlbaranRetornoAlquiler}, FilterType.String, True))
    End Sub

#End Region

    Private Sub advIDTipoAlbaran_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advIDTipoAlbaran.SetPredefinedFilter
        Dim objFilterOR As New Filter(FilterUnionOperator.Or)
        objFilterOR.Add(New StringFilterItem("IDTipoAlbaran", mTipoAlbaranDeposito))
        objFilterOR.Add(New StringFilterItem("IDTipoAlbaran", mTipoAlbaranRetornoAlquiler))
        e.Filter.Add(objFilterOR)
    End Sub

End Class
