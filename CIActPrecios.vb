Public Class CIActPrecios
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
    Friend WithEvents lblFwQPendiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiFechaultRetorno As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFwiFechaultRetorno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiFechaUltVto As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFwiFechaUltVto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblAlquiler As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiIdArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFwiIdArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiIdCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFwiIdCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwITipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFwITipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwIFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtQPendiente As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblFwIFamilia As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIActPrecios))
        Me.lblFwQPendiente = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaultRetorno = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFwiFechaultRetorno = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaUltVto = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFwiFechaUltVto = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlquiler = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiIdArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwiIdArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiIdCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwiIdCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.FwITipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwITipo = New Solmicro.Expertis.Engine.UI.Label
        Me.FwIFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwIFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.txtQPendiente = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.txtQPendiente)
        Me.FilterPanel.Controls.Add(Me.lblFwQPendiente)
        Me.FilterPanel.Controls.Add(Me.lblFwiFechaultRetorno)
        Me.FilterPanel.Controls.Add(Me.lblFwiFechaUltVto)
        Me.FilterPanel.Controls.Add(Me.lblAlquiler)
        Me.FilterPanel.Controls.Add(Me.lblFwiIdArticulo)
        Me.FilterPanel.Controls.Add(Me.lblFwiIdCliente)
        Me.FilterPanel.Controls.Add(Me.lblFwITipo)
        Me.FilterPanel.Controls.Add(Me.lblFwIFamilia)
        Me.FilterPanel.Controls.Add(Me.FwiFechaultRetorno)
        Me.FilterPanel.Controls.Add(Me.FwiFechaUltVto)
        Me.FilterPanel.Controls.Add(Me.FwiObra)
        Me.FilterPanel.Controls.Add(Me.FwiIdArticulo)
        Me.FilterPanel.Controls.Add(Me.FwiIdCliente)
        Me.FilterPanel.Controls.Add(Me.FwITipo)
        Me.FilterPanel.Controls.Add(Me.FwIFamilia)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 316)
        Me.FilterPanel.Size = New System.Drawing.Size(679, 105)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(679, 316)
        '
        'Grid
        '
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ObraMaterial"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.FrozenColumns = 2
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.KeyField = "IdLineaMaterial"
        Me.Grid.Size = New System.Drawing.Size(679, 316)
        Me.Grid.TabIndex = 8
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vAlquilerCIActPrecios"
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
        Me.MainPanel.Size = New System.Drawing.Size(679, 421)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(679, 421)
        '
        'lblFwQPendiente
        '
        Me.lblFwQPendiente.Location = New System.Drawing.Point(198, 78)
        Me.lblFwQPendiente.Name = "lblFwQPendiente"
        Me.lblFwQPendiente.Size = New System.Drawing.Size(85, 13)
        Me.lblFwQPendiente.TabIndex = 0
        Me.lblFwQPendiente.Text = "Pendiente >="
        '
        'FwiFechaultRetorno
        '
        Me.FwiFechaultRetorno.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaultRetorno.Location = New System.Drawing.Point(563, 49)
        Me.FwiFechaultRetorno.Name = "FwiFechaultRetorno"
        Me.FwiFechaultRetorno.Size = New System.Drawing.Size(98, 21)
        Me.FwiFechaultRetorno.TabIndex = 7
        '
        'lblFwiFechaultRetorno
        '
        Me.lblFwiFechaultRetorno.Location = New System.Drawing.Point(411, 53)
        Me.lblFwiFechaultRetorno.Name = "lblFwiFechaultRetorno"
        Me.lblFwiFechaultRetorno.Size = New System.Drawing.Size(151, 13)
        Me.lblFwiFechaultRetorno.TabIndex = 10
        Me.lblFwiFechaultRetorno.Text = "Fecha Ultimo Retorno >="
        '
        'FwiFechaUltVto
        '
        Me.FwiFechaUltVto.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaUltVto.Location = New System.Drawing.Point(563, 23)
        Me.FwiFechaUltVto.Name = "FwiFechaUltVto"
        Me.FwiFechaUltVto.Size = New System.Drawing.Size(98, 21)
        Me.FwiFechaUltVto.TabIndex = 6
        '
        'lblFwiFechaUltVto
        '
        Me.lblFwiFechaUltVto.Location = New System.Drawing.Point(411, 28)
        Me.lblFwiFechaUltVto.Name = "lblFwiFechaUltVto"
        Me.lblFwiFechaUltVto.Size = New System.Drawing.Size(129, 13)
        Me.lblFwiFechaUltVto.TabIndex = 11
        Me.lblFwiFechaUltVto.Text = "Fecha Ultimo Vto. <="
        '
        'FwiObra
        '
        Me.FwiObra.DisabledBackColor = System.Drawing.Color.White
        Me.FwiObra.DisplayField = "NObra"
        Me.FwiObra.EntityName = "ObraCabecera"
        Me.FwiObra.Location = New System.Drawing.Point(72, 23)
        Me.FwiObra.Name = "FwiObra"
        Me.FwiObra.PrimaryDataFields = "IDObra"
        Me.FwiObra.SecondaryDataFields = "IDObra"
        Me.FwiObra.Size = New System.Drawing.Size(105, 23)
        Me.FwiObra.TabIndex = 0
        Me.FwiObra.ViewName = "tbObraCabecera"
        '
        'lblAlquiler
        '
        Me.lblAlquiler.Location = New System.Drawing.Point(16, 28)
        Me.lblAlquiler.Name = "lblAlquiler"
        Me.lblAlquiler.Size = New System.Drawing.Size(50, 13)
        Me.lblAlquiler.TabIndex = 12
        Me.lblAlquiler.Text = "Alquiler"
        '
        'FwiIdArticulo
        '
        Me.FwiIdArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIdArticulo.EntityName = "Articulo"
        Me.FwiIdArticulo.Location = New System.Drawing.Point(72, 75)
        Me.FwiIdArticulo.Name = "FwiIdArticulo"
        Me.FwiIdArticulo.PrimaryDataFields = "IDArticulo"
        Me.FwiIdArticulo.SecondaryDataFields = "IDArticulo"
        Me.FwiIdArticulo.Size = New System.Drawing.Size(105, 23)
        Me.FwiIdArticulo.TabIndex = 2
        Me.FwiIdArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblFwiIdArticulo
        '
        Me.lblFwiIdArticulo.Location = New System.Drawing.Point(16, 79)
        Me.lblFwiIdArticulo.Name = "lblFwiIdArticulo"
        Me.lblFwiIdArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblFwiIdArticulo.TabIndex = 14
        Me.lblFwiIdArticulo.Text = "Artículo"
        '
        'FwiIdCliente
        '
        Me.FwiIdCliente.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIdCliente.EntityName = "Cliente"
        Me.FwiIdCliente.Location = New System.Drawing.Point(72, 49)
        Me.FwiIdCliente.Name = "FwiIdCliente"
        Me.FwiIdCliente.PrimaryDataFields = "IDCliente"
        Me.FwiIdCliente.SecondaryDataFields = "IDCliente"
        Me.FwiIdCliente.Size = New System.Drawing.Size(105, 23)
        Me.FwiIdCliente.TabIndex = 1
        Me.FwiIdCliente.ViewName = "tbMaestroCliente"
        '
        'lblFwiIdCliente
        '
        Me.lblFwiIdCliente.Location = New System.Drawing.Point(16, 54)
        Me.lblFwiIdCliente.Name = "lblFwiIdCliente"
        Me.lblFwiIdCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblFwiIdCliente.TabIndex = 16
        Me.lblFwiIdCliente.Text = "Cliente"
        '
        'FwITipo
        '
        Me.FwITipo.DisabledBackColor = System.Drawing.Color.White
        Me.FwITipo.EntityName = "TipoArticulo"
        Me.FwITipo.Location = New System.Drawing.Point(286, 23)
        Me.FwITipo.Name = "FwITipo"
        Me.FwITipo.PrimaryDataFields = "IDTipo"
        Me.FwITipo.SecondaryDataFields = "IDTipo"
        Me.FwITipo.Size = New System.Drawing.Size(100, 23)
        Me.FwITipo.TabIndex = 3
        Me.FwITipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblFwITipo
        '
        Me.lblFwITipo.Location = New System.Drawing.Point(198, 28)
        Me.lblFwITipo.Name = "lblFwITipo"
        Me.lblFwITipo.Size = New System.Drawing.Size(31, 13)
        Me.lblFwITipo.TabIndex = 18
        Me.lblFwITipo.Text = "Tipo"
        '
        'FwIFamilia
        '
        Me.FwIFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.FwIFamilia.EntityName = "Familia"
        Me.FwIFamilia.Location = New System.Drawing.Point(286, 49)
        Me.FwIFamilia.Name = "FwIFamilia"
        Me.FwIFamilia.PrimaryDataFields = "IDFamilia"
        Me.FwIFamilia.SecondaryDataFields = "IDFamilia"
        Me.FwIFamilia.Size = New System.Drawing.Size(100, 23)
        Me.FwIFamilia.TabIndex = 4
        Me.FwIFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblFwIFamilia
        '
        Me.lblFwIFamilia.Location = New System.Drawing.Point(198, 54)
        Me.lblFwIFamilia.Name = "lblFwIFamilia"
        Me.lblFwIFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblFwIFamilia.TabIndex = 20
        Me.lblFwIFamilia.Text = "Familia"
        '
        'txtQPendiente
        '
        Me.txtQPendiente.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPendiente.Location = New System.Drawing.Point(286, 75)
        Me.txtQPendiente.Name = "txtQPendiente"
        Me.txtQPendiente.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtQPendiente.Size = New System.Drawing.Size(100, 21)
        Me.txtQPendiente.TabIndex = 21
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "warning.ico")
        '
        'CIActPrecios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(687, 509)
        Me.EntityName = "ObraMaterial"
        Me.KeyField = "IdLineaMaterial"
        Me.Name = "CIActPrecios"
        Me.ShowInTaskbar = True
        Me.UseCheck = True
        Me.ViewName = "vAlquilerCIActPrecios"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const StrFormatStyle As String = "Variaciones"
    Private mblnRevision As Boolean
    Private mintWarningIconIndex As Integer

#Region " Load "

    Private Sub CIActPrecios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadFormActions()
            LoadGridActions()
            LoadDefaultValues()

            ActivarFetch(True)
        End If
    End Sub

    Private Sub LoadFormActions()
        Me.FormActions.Clear()
        Me.FormActions.Add("Revisión de precios", AddressOf AccionRevisionDePrecios)
        Me.FormActions.Add("Actualización de precios", AddressOf AccionActualizacionDePrecios)
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Clear()
        Me.Grid.Actions.Add("Abrir Alquiler", AddressOf AccionGridAbrirObra)
        Me.Grid.Actions.Add("Abrir O.Servicio", AddressOf AccionGridAbrirOServicio)
    End Sub

    Private Sub LoadDefaultValues()
        txtQPendiente.Value = 0
    End Sub

    Private Sub ActivarFetch(ByVal blnActivar As Boolean)
        With Grid
            If blnActivar Or mblnRevision = False Then
                .Columns("PrecioPrevmatA").EditType = EditType.NoEdit
                .Columns("Dto1").EditType = EditType.NoEdit
                .Columns("Dto2").EditType = EditType.NoEdit
                .Columns("Dto3").EditType = EditType.NoEdit
                .Columns("Warning").Visible = False
            Else
                .Columns("Warning").Visible = True
                .Columns("PrecioPrevmatA").EditType = Janus.Windows.GridEX.EditType.TextBox
                .Columns("Dto1").EditType = Janus.Windows.GridEX.EditType.TextBox
                .Columns("Dto2").EditType = Janus.Windows.GridEX.EditType.TextBox
                .Columns("Dto3").EditType = Janus.Windows.GridEX.EditType.TextBox
            End If
        End With
    End Sub

#End Region

#Region " Acciones del formulario "

    Private Sub AccionActualizacionDePrecios()
        'TODO 
        'If Not Grid.DataSource Is Nothing Then
        '    If Grid.CheckedRecordsCount > 0 Then
        '        If mblnRevision Then
        '            If VerificarCambios() Then
        '                If ExpertisApp.GenerateMessage("Se va a proceder a  la Actualización de Precios .¿Desea Continuar?.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
        '                    Me.Cursor = Cursors.WaitCursor
        '                    Grid.Update()
        '                    Dim dt As DataTable = leerGrid(Grid.CheckedRecords)
        '                    If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
        '                        If New ObraMaterial().ActualizacionDePrecios(dt) Then
        '                            ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                            mblnRevision = False
        '                        Else
        '                            ExpertisApp.GenerateMessage("Error en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                        End If
        '                    End If
        '                    Me.Cursor = Cursors.Default
        '                    ActivarFetch(False)
        '                    Grid.Refresh()
        '                End If
        '            End If
        '        Else
        '            ExpertisApp.GenerateMessage("No se puede lanzar la actualización sin haber revisado previamente los precios.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End If
        '    End If
        'End If
    End Sub

    Private Function leerGrid(ByVal dt As DataTable) As DataTable
        Dim dtPrecios As New DataTable
        With dt
            dtPrecios.Columns.Add("IdLineaMaterial", .Columns("IdLineaMaterial").DataType)
            dtPrecios.Columns.Add("PrecioPrevMatA", .Columns("PrecioPrevMatA").DataType)
            dtPrecios.Columns.Add("Dto1", .Columns("Dto1").DataType)
            dtPrecios.Columns.Add("Dto2", .Columns("Dto2").DataType)
            dtPrecios.Columns.Add("Dto3", .Columns("Dto3").DataType)
            dtPrecios.Columns.Add("SeguimientoTarifa", .Columns("SeguimientoTarifa").DataType)

            For Each dr As DataRow In .Rows
                'Campos para Identificar Cambios
                If dr("cantidadMarca1") = 1 Or dr("CantidadMarca2") = 1 Or _
                dr("CantidadMarca3") = 1 Or dr("CantidadMarca4") = 1 Or _
                dr("CantidadMarca5") = 1 Then
                    Dim drPrecios As DataRow = dtPrecios.NewRow
                    drPrecios("IdLineaMaterial") = dr("IdLineaMaterial")
                    drPrecios("PrecioPrevMatA") = dr("PrecioPrevMatA")
                    drPrecios("Dto1") = dr("Dto1")
                    drPrecios("Dto2") = dr("Dto2")
                    drPrecios("Dto3") = dr("Dto3")
                    drPrecios("SeguimientoTarifa") = dr("SeguimientoTarifa") & String.Empty
                    dtPrecios.Rows.Add(drPrecios)
                End If
            Next
        End With

        leerGrid = dtPrecios

    End Function

    Private Function VerificarCambios() As Boolean

        Dim dt As DataTable = Grid.CheckedRecords
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows
                If Nz(dr("cantidadMarca1"), 0) = 1 Or Nz(dr("CantidadMarca2"), 0) = 1 Or _
                Nz(dr("CantidadMarca3"), 0) = 1 Or Nz(dr("CantidadMarca4"), 0) = 1 Or _
                Nz(dr("CantidadMarca5"), 0) = 1 Then
                    VerificarCambios = True
                    Exit Function
                End If
            Next
        End If
    End Function

    Private Sub AccionRevisionDePrecios()
        'TODO 
        'Dim intIDObra, intUdValoracion As Integer
        'Dim strIdMaterial As String
        'Dim strCliente, strIdMoneda, strSeguimientoTarifa As String
        'Dim dblCantidad As Double
        'Dim dblDto1 As Double
        'Dim dblDto2 As Double
        'Dim dblDto3 As Double
        'Dim dblPrecio As Double
        'Dim strIdMonedaNew As String
        'Dim dtFechainicio As Date

        'If Not IsNothing(Grid.DataSource) Then
        '    If Grid.CheckedRecordsCount > 0 Then
        '        Me.Cursor = Cursors.WaitCursor
        '        For Each dr As DataRow In Grid.CheckedRecords.Select
        '            intIDObra = dr("IdObra")
        '            strIdMaterial = dr("IdMaterial") & String.Empty
        '            strCliente = dr("IDCliente") & String.Empty
        '            dblCantidad = dr("QPrev")
        '            dtFechainicio = dr("FechaInicioOs") & String.Empty

        '            dblPrecio = dr("PrecioInicial")
        '            dblDto1 = dr("Dto1Inicial")
        '            dblDto2 = dr("Dto2Inicial")
        '            dblDto2 = dr("Dto3Inicial")

        '            Dim oOTInfo As New ObtenerTarifaInfo
        '            Dim FwnOTF As New ObraTarifaAlquiler
        '            oOTInfo = FwnOTF.ObtenerTarifa(intIDObra, strIdMaterial, strCliente, dblCantidad, _
        '            strIdMoneda, dtFechainicio)
        '            dblPrecio = oOTInfo.Precio
        '            dblDto1 = oOTInfo.Dto2
        '            dblDto2 = oOTInfo.Dto2
        '            dblDto3 = oOTInfo.Dto3
        '            intUdValoracion = oOTInfo.UdValoracion
        '            strIdMonedaNew = oOTInfo.IdMonedaNew
        '            strSeguimientoTarifa = oOTInfo.SeguimientoTarifa

        '            dr("cantidadMarca1") = IIf(dr("PrecioInicial") <> dblPrecio, 1, 0)
        '            dr("CantidadMarca2") = IIf(dr("Dto1Inicial") <> dblDto1, 1, 0)
        '            dr("CantidadMarca3") = IIf(dr("Dto2Inicial") <> dblDto2, 1, 0)
        '            dr("CantidadMarca4") = IIf(dr("Dto3Inicial") <> dblDto3, 1, 0)
        '            dr("CantidadMarca5") = IIf(dr("SeguimientoInicial") & String.Empty <> strSeguimientoTarifa, 1, 0)

        '            If dr("cantidadMarca1") = 1 Or dr("CantidadMarca2") = 1 Or _
        '            dr("CantidadMarca3") = 1 Or dr("CantidadMarca4") = 1 Or _
        '            dr("CantidadMarca5") = 1 Then
        '                dr("UsuarioAudi") = "Change"
        '            End If

        '            dr("PrecioPrevMatA") = dblPrecio
        '            dr("Dto1") = dblDto1
        '            dr("Dto2") = dblDto2
        '            dr("Dto3") = dblDto3
        '            dr("SeguimientoTarifa") = strSeguimientoTarifa
        '        Next

        '        mblnRevision = True
        '        ActivarFetch(False)
        '        Me.Execute()

        '        Me.Cursor = Cursors.Default
        '        ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'End If
    End Sub

#End Region

#Region " Acciones del grid "

    Private Sub AccionGridAbrirObra()
        AbrirMntoAlquiler(Nz(Grid.Value("IDObra"), 0))
    End Sub

    Private Sub AccionGridAbrirOServicio()
        With Grid
            If Length(.Value("IDTrabajo")) > 0 Then
                ExpertisApp.OpenForm("MGEOTRALQ", New NumberFilterItem("IDTrabajo", .Value("IDTrabajo")))
            End If
        End With
    End Sub

#End Region

#Region " Grid "

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        With Grid
            Select Case e.Column.Key
                Case "PrecioPrevMatA"
                    If Nz(.Value(e.Column.Key), 0) <> Nz(.Value("PrecioInicial"), 0) Then
                        .Value("CantidadMarca1") = 1
                    Else
                        .Value("CantidadMarca1") = 0
                    End If
                Case "Dto1"
                    If Nz(.Value(e.Column.Key), 0) <> Nz(.Value("Dto1Inicial"), 0) Then
                        .Value("CantidadMarca2") = 1
                    Else
                        .Value("CantidadMarca2") = 0
                    End If
                Case "Dto2"
                    If Nz(.Value(e.Column.Key), 0) <> Nz(.Value("Dto2Inicial"), 0) Then
                        .Value("CantidadMarca3") = 1
                    Else
                        .Value("CantidadMarca3") = 0
                    End If
                Case "Dto3"
                    If Nz(.Value(e.Column.Key), 0) <> Nz(.Value("Dto3Inicial"), 0) Then
                        .Value("CantidadMarca4") = 1
                    Else
                        .Value("CantidadMarca4") = 0
                    End If
            End Select
        End With
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        'With Grid
        '    .Datasource.Bookmark = RowBookmark
        '    If .Datasource.Fields("cantidadMarca1").Value = 1 Or .Datasource.Fields("CantidadMarca2").Value = 1 Or _
        '    .Datasource.Fields("CantidadMarca3").Value = 1 Or .Datasource.Fields("CantidadMarca4").Value = 1 Or _
        '    .Datasource.Fields("CantidadMarca5").Value = 1 Then
        '        IconIndex = mintWarningIconIndex
        '    End If
        'End With

        With Grid
            'Control de cambios a nivel de Revision de Precios utilizando los campos Marca
            If e.Row.DataRow("CantidadMarca1") = 1 Then
                e.Row.Cells("PrecioPrevMatA").FormatStyle = Grid.FormatStyles(StrFormatStyle)
                e.Row.Cells("Warning").ImageIndex = 0
            End If
            If e.Row.DataRow("CantidadMarca2") = 1 Then
                e.Row.Cells("Dto1").FormatStyle = Grid.FormatStyles(StrFormatStyle)
                e.Row.Cells("Warning").ImageIndex = 0
            End If
            If e.Row.DataRow("CantidadMarca3") = 1 Then
                e.Row.Cells("Dto2").FormatStyle = Grid.FormatStyles(StrFormatStyle)
                e.Row.Cells("Warning").ImageIndex = 0
            End If
            If e.Row.DataRow("CantidadMarca4") = 1 Then
                e.Row.Cells("Dto3").FormatStyle = Grid.FormatStyles(StrFormatStyle)
                e.Row.Cells("Warning").ImageIndex = 0
            End If
            If e.Row.DataRow("CantidadMarca5") = 1 Then
                e.Row.Cells("SeguimientoTarifa").FormatStyle = Grid.FormatStyles(StrFormatStyle)
                e.Row.Cells("Warning").ImageIndex = 0
            End If
        End With

    End Sub

    Private Sub Grid_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnButtonClick
        With Grid
            Select Case e.Column.Key
                Case "SeguimientoTarifa", "SeguimientoInicial"
                    CargarSeguimientoTarifa(.Value(e.Column.Key) & String.Empty, .Columns(e.Column.Key).Caption)
            End Select
        End With
    End Sub

    Private Sub CargarSeguimientoTarifa(ByVal strTexto As String, ByVal strLabel As String)
        Dim frm As New FormularioTexto
        frm.Text = strLabel
        frm.SoloLectura = True
        frm.Texto = strTexto
        frm.ShowDialog()
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        With Grid
            Select Case e.Column.Key
                Case "SeguimientoTarifa", "SeguimientoInicial"
                    e.Cancel = True
                    .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Ellipsis
            End Select
        End With
    End Sub


#End Region

    Private Sub FwiFechaUltVto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiFechaUltVto.LostFocus
        FwiFechaultRetorno.Value = FwiFechaUltVto.Value
    End Sub

    Private Sub CIActPrecios_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDMaterial", FilterOperator.Equal, FwiIdArticulo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, FwIFamilia.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, FwITipo.Text, FilterType.String)
        e.Filter.Add("IDObra", FilterOperator.Equal, FwiObra.Value, FilterType.Numeric)
        e.Filter.Add("FechaUltimoVencimiento", FilterOperator.LessThanOrEqual, FwiFechaUltVto.Value, FilterType.DateTime)
        e.Filter.Add("FechaUltimoRetorno", FilterOperator.GreaterThanOrEqual, FwiFechaultRetorno.Value, FilterType.DateTime)
        e.Filter.Add("IDCliente", FilterOperator.Equal, FwiIdCliente.Text, FilterType.String)
        e.Filter.Add("PendienteDevolver", FilterOperator.Equal, txtQPendiente.Value, FilterType.Numeric)

        'Grid.Filter = e.Filter.InnerFilter
        'Grid.Refresh()
    End Sub

    Private Sub CIActPrecios_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        FwiFechaUltVto.Value = System.DBNull.Value
        FwiFechaultRetorno.Value = System.DBNull.Value
    End Sub

End Class
