Public Class CIArticuloNSerie
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
    Friend WithEvents Grid1 As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents lblIDSubfamilia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDSubfamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblIDArticulo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblIDTipo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblIDFamilia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblIDCliente As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblNSerie As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advNSerie As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblIDEstadoActivo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDEstadoActivo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblIDAlmacen As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cmbDisponible As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cmbDeposito As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbDisponible_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbDeposito_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIArticuloNSerie))
        Me.Grid1 = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblIDArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDSubfamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDSubfamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblNSerie = New Solmicro.Expertis.Engine.UI.Label
        Me.advNSerie = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDEstadoActivo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDEstadoActivo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cmbDisponible = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cmbDeposito = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.Label2)
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.lblIDArticulo)
        Me.FilterPanel.Controls.Add(Me.lblIDTipo)
        Me.FilterPanel.Controls.Add(Me.lblIDFamilia)
        Me.FilterPanel.Controls.Add(Me.lblIDCliente)
        Me.FilterPanel.Controls.Add(Me.lblIDSubfamilia)
        Me.FilterPanel.Controls.Add(Me.lblNSerie)
        Me.FilterPanel.Controls.Add(Me.lblIDEstadoActivo)
        Me.FilterPanel.Controls.Add(Me.lblIDAlmacen)
        Me.FilterPanel.Controls.Add(Me.cmbDeposito)
        Me.FilterPanel.Controls.Add(Me.cmbDisponible)
        Me.FilterPanel.Controls.Add(Me.advIDAlmacen)
        Me.FilterPanel.Controls.Add(Me.advIDEstadoActivo)
        Me.FilterPanel.Controls.Add(Me.advNSerie)
        Me.FilterPanel.Controls.Add(Me.advIDSubfamilia)
        Me.FilterPanel.Controls.Add(Me.advIDCliente)
        Me.FilterPanel.Controls.Add(Me.advIDFamilia)
        Me.FilterPanel.Controls.Add(Me.advIDTipo)
        Me.FilterPanel.Controls.Add(Me.advIDArticulo)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 183)
        Me.FilterPanel.Size = New System.Drawing.Size(624, 135)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Grid1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(624, 183)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ArticuloNSerie"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDActivo"
        Me.Grid.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid.Size = New System.Drawing.Size(624, 183)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vAlquilerCIArticuloNSerie"
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
        Me.MainPanel.Size = New System.Drawing.Size(624, 318)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(624, 318)
        '
        'Grid1
        '
        Me.Grid1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid1.EntityName = Nothing
        Me.Grid1.Location = New System.Drawing.Point(368, 128)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.PrimaryDataFields = Nothing
        Me.Grid1.SecondaryDataFields = Nothing
        Me.Grid1.Size = New System.Drawing.Size(400, 376)
        Me.Grid1.TabIndex = 1
        Me.Grid1.ViewName = Nothing
        '
        'lblIDArticulo
        '
        Me.lblIDArticulo.Location = New System.Drawing.Point(8, 31)
        Me.lblIDArticulo.Name = "lblIDArticulo"
        Me.lblIDArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblIDArticulo.TabIndex = 0
        Me.lblIDArticulo.Text = "Artículo"
        '
        'advIDArticulo
        '
        Me.advIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticulo.EntityName = "Articulo"
        Me.advIDArticulo.Location = New System.Drawing.Point(80, 26)
        Me.advIDArticulo.Name = "advIDArticulo"
        Me.advIDArticulo.PrimaryDataFields = "IDArticulo"
        Me.advIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.advIDArticulo.Size = New System.Drawing.Size(96, 23)
        Me.advIDArticulo.TabIndex = 0
        Me.advIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblIDTipo
        '
        Me.lblIDTipo.Location = New System.Drawing.Point(8, 57)
        Me.lblIDTipo.Name = "lblIDTipo"
        Me.lblIDTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblIDTipo.TabIndex = 2
        Me.lblIDTipo.Text = "Tipo"
        '
        'advIDTipo
        '
        Me.advIDTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTipo.EntityName = "TipoArticulo"
        Me.advIDTipo.Location = New System.Drawing.Point(80, 52)
        Me.advIDTipo.Name = "advIDTipo"
        Me.advIDTipo.PrimaryDataFields = "IDTipo"
        Me.advIDTipo.SecondaryDataFields = "IDTipo"
        Me.advIDTipo.Size = New System.Drawing.Size(96, 23)
        Me.advIDTipo.TabIndex = 1
        Me.advIDTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblIDFamilia
        '
        Me.lblIDFamilia.Location = New System.Drawing.Point(8, 82)
        Me.lblIDFamilia.Name = "lblIDFamilia"
        Me.lblIDFamilia.Size = New System.Drawing.Size(47, 13)
        Me.lblIDFamilia.TabIndex = 4
        Me.lblIDFamilia.Text = "Familia"
        '
        'advIDFamilia
        '
        Me.advIDFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDFamilia.EntityName = "Familia"
        Me.advIDFamilia.Location = New System.Drawing.Point(80, 78)
        Me.advIDFamilia.Name = "advIDFamilia"
        Me.advIDFamilia.PrimaryDataFields = "IDFamilia"
        Me.advIDFamilia.SecondaryDataFields = "IDFamilia"
        Me.advIDFamilia.Size = New System.Drawing.Size(96, 23)
        Me.advIDFamilia.TabIndex = 2
        Me.advIDFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblIDCliente
        '
        Me.lblIDCliente.Location = New System.Drawing.Point(216, 31)
        Me.lblIDCliente.Name = "lblIDCliente"
        Me.lblIDCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblIDCliente.TabIndex = 6
        Me.lblIDCliente.Text = "Cliente"
        '
        'advIDCliente
        '
        Me.advIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCliente.EntityName = "Cliente"
        Me.advIDCliente.Location = New System.Drawing.Point(288, 26)
        Me.advIDCliente.Name = "advIDCliente"
        Me.advIDCliente.PrimaryDataFields = "IDCliente"
        Me.advIDCliente.SecondaryDataFields = "IDCliente"
        Me.advIDCliente.Size = New System.Drawing.Size(96, 23)
        Me.advIDCliente.TabIndex = 4
        Me.advIDCliente.ViewName = "tbMaestroCliente"
        '
        'lblIDSubfamilia
        '
        Me.lblIDSubfamilia.Location = New System.Drawing.Point(8, 109)
        Me.lblIDSubfamilia.Name = "lblIDSubfamilia"
        Me.lblIDSubfamilia.Size = New System.Drawing.Size(67, 13)
        Me.lblIDSubfamilia.TabIndex = 8
        Me.lblIDSubfamilia.Text = "Subfamilia"
        '
        'advIDSubfamilia
        '
        Me.advIDSubfamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDSubfamilia.EntityName = "SubFamilia"
        Me.advIDSubfamilia.Location = New System.Drawing.Point(80, 104)
        Me.advIDSubfamilia.Name = "advIDSubfamilia"
        Me.advIDSubfamilia.PrimaryDataFields = "IDSubfamilia"
        Me.advIDSubfamilia.SecondaryDataFields = "IDSubfamilia"
        Me.advIDSubfamilia.Size = New System.Drawing.Size(96, 23)
        Me.advIDSubfamilia.TabIndex = 3
        Me.advIDSubfamilia.ViewName = "tbMaestroSubfamilia"
        '
        'lblNSerie
        '
        Me.lblNSerie.Location = New System.Drawing.Point(216, 57)
        Me.lblNSerie.Name = "lblNSerie"
        Me.lblNSerie.Size = New System.Drawing.Size(55, 13)
        Me.lblNSerie.TabIndex = 10
        Me.lblNSerie.Text = "Nº Serie"
        '
        'advNSerie
        '
        Me.advNSerie.DisabledBackColor = System.Drawing.Color.White
        Me.advNSerie.EntityName = "ArticuloNSerie"
        Me.advNSerie.Location = New System.Drawing.Point(288, 52)
        Me.advNSerie.Name = "advNSerie"
        Me.advNSerie.PrimaryDataFields = "NSerie"
        Me.advNSerie.SecondaryDataFields = "NSerie"
        Me.advNSerie.Size = New System.Drawing.Size(96, 23)
        Me.advNSerie.TabIndex = 5
        Me.advNSerie.ViewName = "tbArticuloNserie "
        '
        'lblIDEstadoActivo
        '
        Me.lblIDEstadoActivo.Location = New System.Drawing.Point(432, 31)
        Me.lblIDEstadoActivo.Name = "lblIDEstadoActivo"
        Me.lblIDEstadoActivo.Size = New System.Drawing.Size(84, 13)
        Me.lblIDEstadoActivo.TabIndex = 12
        Me.lblIDEstadoActivo.Text = "Estado Activo"
        '
        'advIDEstadoActivo
        '
        Me.advIDEstadoActivo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDEstadoActivo.EntityName = "MntoEstadoActivo"
        Me.advIDEstadoActivo.Location = New System.Drawing.Point(520, 26)
        Me.advIDEstadoActivo.Name = "advIDEstadoActivo"
        Me.advIDEstadoActivo.PrimaryDataFields = "IDEstadoActivo"
        Me.advIDEstadoActivo.SecondaryDataFields = "IDEstadoActivo"
        Me.advIDEstadoActivo.Size = New System.Drawing.Size(96, 23)
        Me.advIDEstadoActivo.TabIndex = 7
        '
        'lblIDAlmacen
        '
        Me.lblIDAlmacen.Location = New System.Drawing.Point(432, 57)
        Me.lblIDAlmacen.Name = "lblIDAlmacen"
        Me.lblIDAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblIDAlmacen.TabIndex = 14
        Me.lblIDAlmacen.Text = "Almacén"
        '
        'advIDAlmacen
        '
        Me.advIDAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advIDAlmacen.EntityName = "Almacen"
        Me.advIDAlmacen.Location = New System.Drawing.Point(520, 52)
        Me.advIDAlmacen.Name = "advIDAlmacen"
        Me.advIDAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.Size = New System.Drawing.Size(96, 23)
        Me.advIDAlmacen.TabIndex = 8
        Me.advIDAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'cmbDisponible
        '
        cmbDisponible_DesignTimeLayout.LayoutString = resources.GetString("cmbDisponible_DesignTimeLayout.LayoutString")
        Me.cmbDisponible.DesignTimeLayout = cmbDisponible_DesignTimeLayout
        Me.cmbDisponible.DisabledBackColor = System.Drawing.Color.White
        Me.cmbDisponible.Location = New System.Drawing.Point(288, 78)
        Me.cmbDisponible.Name = "cmbDisponible"
        Me.cmbDisponible.SelectedIndex = -1
        Me.cmbDisponible.SelectedItem = Nothing
        Me.cmbDisponible.Size = New System.Drawing.Size(96, 21)
        Me.cmbDisponible.TabIndex = 6
        '
        'cmbDeposito
        '
        cmbDeposito_DesignTimeLayout.LayoutString = resources.GetString("cmbDeposito_DesignTimeLayout.LayoutString")
        Me.cmbDeposito.DesignTimeLayout = cmbDeposito_DesignTimeLayout
        Me.cmbDeposito.DisabledBackColor = System.Drawing.Color.White
        Me.cmbDeposito.Location = New System.Drawing.Point(520, 78)
        Me.cmbDeposito.Name = "cmbDeposito"
        Me.cmbDeposito.SelectedIndex = -1
        Me.cmbDeposito.SelectedItem = Nothing
        Me.cmbDeposito.Size = New System.Drawing.Size(96, 21)
        Me.cmbDeposito.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(216, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Disponible"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(432, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Depósito "
        '
        'CIArticuloNSerie
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(632, 406)
        Me.EntityName = "ArticuloNSerie"
        Me.KeyField = "IDActivo"
        Me.Name = "CIArticuloNSerie"
        Me.Text = "CIArticuloNSerie"
        Me.UseCheck = True
        Me.ViewName = "vAlquilerCIArticuloNSerie"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected mdtAux As DataTable
    Protected mblnDetalle As Boolean

#Region " Load "

    Private Sub CIArticuloNSerie_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadEnums()
            LoadGridActions()
            LoadToolbarActions()
            LoadFormatStyles()
            LoadParams()
            InitFilterCriteria()
        End If
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Venta de Activos", AddressOf AccionVentaMaquinaria, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add(cnABRRIRARTICULO, AddressOf AccionAbrirArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
        Grid.Actions.Add(cnABRRIRACTIVO, AddressOf AccionAbrirActivo, ExpertisApp.GetIcon("xActivos.ico"))
    End Sub

    Private Sub LoadFormatStyles()
        Dim dtEstados As DataTable = New MntoEstadoActivo().Filter()
        If Not IsNothing(dtEstados) AndAlso dtEstados.Rows.Count > 0 Then
            GridFormatStyle.CrearFormatos(Grid, dtEstados, GridFormatStyle.TipoFormato.EstadoActivo, False)
        End If
    End Sub

    Private Sub LoadEnums()
        cmbDeposito.DataSource = New EnumData("enumBoolean")
        cmbDisponible.DataSource = New EnumData("enumBoolean")
    End Sub

    Private Sub LoadParams()
        If Not Me.Params Is Nothing Then
            If Me.Params.ContainsKey("IDCliente") AndAlso Length(Me.Params("IDCliente")) > 0 Then
                advIDCliente.Value = Me.Params("IDCliente")
                advIDCliente.Text = Me.Params("IDCliente")
                Me.Execute()
            End If
        End If
    End Sub

    Private Sub InitFilterCriteria()
        cmbDeposito.Value = enumBoolean.Todos
        cmbDisponible.Value = enumBoolean.Todos
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub AccionVentaMaquinaria()
        Dim dtMarcados As DataTable = Me.CheckedRecords
        If dtMarcados Is Nothing OrElse dtMarcados.Rows.Count = 0 Then
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ExpertisApp.GenerateMessage("Sólo se procesarán los Activos que han sido seleccionados y cuyo estado esté marcado como Disponible.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ValidaDisponibles(dtMarcados)
            If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                Dim frm As New frmVentaMaquinaria
                If frm.AbrirVentaMaquinaria(dtMarcados) = DialogResult.OK Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim DE As New BE.DataEngine
                    Dim datosVentaMaquinaria As dataPrcAlbaranVentaMaquinaria = frm.datosVentaMaquinaria
                    Dim log As AlbaranLogProcess = DE.RunProcess(GetType(PrcCrearAlbaranVentaMaquinaria), datosVentaMaquinaria)

                    If Not log.StockUpdateData Is Nothing AndAlso log.StockUpdateData.Length > 0 Then
                        Dim frmStock As New DetalleActualizacionStock
                        frmStock.DataSource = log.StockUpdateData
                        frmStock.ShowDialog()
                    End If

                    'Dim AbrirAlbaran As Boolean = True
                    If frm.chkGenerarFactura.Checked Then
                        Dim Albaranes() As Integer = AlbaranesGenerados(log.CreateData)
                        If Albaranes.Length > 0 Then
                            Dim datos As New DataPrcFacturacionGeneral(Albaranes, Nothing, Date.Today)
                            Dim Propuesta As ResultFacturacion = DE.RunProcess(GetType(PrcFacturacionGeneral), datos)
                            Dim datosAct As New DataPrcActualizarFactura(Propuesta)
                            Propuesta = DE.RunProcess(GetType(PrcActualizarFactura), datosAct)
                            TratarLog(Propuesta.Log, enumTipoDocumentoCreado.FacturaVenta, True, True)
                        End If
                    Else
                        TratarLog(log.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                    End If

                    'If AbrirAlbaran Then TratarLog(log.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)

                    Me.Cursor = Cursors.Default
                    Me.UnCheckAllRecords()
                    Me.RetrieveData()
                Else
                    ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                ExpertisApp.GenerateMessage("No hay activos seleccionados en situación disponible.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub ValidaDisponibles(ByRef dtMarcados As DataTable)
        For Each drMarcados As DataRow In dtMarcados.Select
            If Not drMarcados("Disponible") Then
                dtMarcados.Rows.Remove(drMarcados)
            End If
        Next
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

#Region " Query Executing "

    Private Sub CIArticuloNSerie_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IdArticulo", FilterOperator.Equal, advIDArticulo.Value, FilterType.String)
        e.Filter.Add("IdFamilia", FilterOperator.Equal, advIDFamilia.Value, FilterType.String)
        e.Filter.Add("IdTIpo", FilterOperator.Equal, advIDTipo.Value, FilterType.String)
        e.Filter.Add("Idsubfamilia", FilterOperator.Equal, advIDSubfamilia.Value, FilterType.String)
        e.Filter.Add("NSerie", FilterOperator.Equal, advNSerie.Value, FilterType.String)
        e.Filter.Add("IdCliente", FilterOperator.Equal, advIDCliente.Value, FilterType.String)
        e.Filter.Add("IdEstadoActivo", FilterOperator.Equal, advIDEstadoActivo.Value, FilterType.String)
        e.Filter.Add("IdAlmacen", FilterOperator.Equal, advIDAlmacen.Value, FilterType.String)

        If cmbDisponible.Value <> enumBoolean.Todos Then
            e.Filter.Add("Disponible", FilterOperator.Equal, cmbDisponible.Value, FilterType.Numeric)
        End If
        If cmbDeposito.Value <> enumBoolean.Todos Then
            e.Filter.Add("Deposito", FilterOperator.Equal, cmbDeposito.Value, FilterType.Numeric)
        End If
    End Sub

    Private Sub CIArticuloNSerie_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        InitFilterCriteria()
    End Sub

#End Region

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If Length(e.Row.Cells("IDEstadoActivo").Value) > 0 Then
            e.Row.RowStyle = Grid.FormatStyles("FMT" & e.Row.Cells("IDEstadoActivo").Value)
        End If
    End Sub

#Region " Informes "

    Private Sub CIArticuloNSerie_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        If Not IsNothing(mdtAux) AndAlso mdtAux.Rows.Count > 0 Then e.DataSource = mdtAux
    End Sub

    Private Sub CIArticuloNSerie_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Dim blnDetalle As Boolean
        Dim dtSubRep As DataTable = Nothing
        Dim dtGrid As DataTable = Nothing

        If e.Alias = "ACTCEX" Then
            blnDetalle = False
        ElseIf e.Alias = "ACTCEXDET" Then
            blnDetalle = True
        End If
        mblnDetalle = blnDetalle
        mdtAux = Nothing

        dtGrid = Me.CheckedRecords
        If Not dtGrid Is Nothing AndAlso dtGrid.Rows.Count > 0 Then
            Dim data As New Activo.DatosCuentaExplotacion(String.Empty, Grid.SaveServerChecks().ToString, blnDetalle)
            mdtAux = ExpertisApp.ExecuteTask(Of Activo.DatosCuentaExplotacion, DataTable)(AddressOf Activo.CuentaExplotacion, data)
            If IsNothing(mdtAux) OrElse mdtAux.Rows.Count <= 1 Then
                ExpertisApp.GenerateMessage("No existen datos para generar el informe.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Cancel = True
            End If

            Me.DeleteServerChecks()

            'Pasamos el datatable a cada subinforme
            If Not IsNothing(mdtAux) AndAlso mdtAux.Rows.Count > 0 Then
                dtSubRep = mdtAux.Copy
                Dim dv1 As DataView = dtSubRep.DefaultView
                dv1.RowFilter = "Tipo=1"
                e.Subreports("CuentaExplotacionTipo1").DataSource = dv1
                dtSubRep = mdtAux.Copy
                Dim dv21 As DataView = dtSubRep.DefaultView
                dv21.RowFilter = "Tipo=21"
                e.Subreports("CuentaExplotacionTipo21").DataSource = dv21
                dtSubRep = mdtAux.Copy
                Dim dv22 As DataView = dtSubRep.DefaultView
                dv22.RowFilter = "Tipo=22"
                e.Subreports("CuentaExplotacionTipo22").DataSource = dv22
                dtSubRep = mdtAux.Copy
                Dim dv23 As DataView = dtSubRep.DefaultView
                dv23.RowFilter = "Tipo=23"
                e.Subreports("CuentaExplotacionTipo23").DataSource = dv23
                dtSubRep = mdtAux.Copy
                Dim dv24 As DataView = dtSubRep.DefaultView
                dv24.RowFilter = "Tipo=24"
                e.Subreports("CuentaExplotacionTipo24").DataSource = dv24
                dtSubRep = mdtAux.Copy
                Dim dv3 As DataView = dtSubRep.DefaultView
                dv3.RowFilter = "Tipo=3"
                e.Subreports("CuentaExplotacionTotales").DataSource = dv3
            End If
        End If
    End Sub

#End Region

End Class
