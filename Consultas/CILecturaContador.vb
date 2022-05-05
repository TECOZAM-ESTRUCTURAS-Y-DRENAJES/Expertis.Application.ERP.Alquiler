Public Class CILecturaContador
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
    Friend WithEvents advIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDActivo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblActivo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDAlbaran As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblAlbaran As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDSubfamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblSubfamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxFechaAlbaranHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaAlbaranHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaAlbaranDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaAlbaranDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboEstadoFactura As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEstadoFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FraOperario As Solmicro.Expertis.Engine.UI.Frame
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboEstadoFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CILecturaContador))
        Me.advIDSubfamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblSubfamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDActivo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblActivo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaAlbaranHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaAlbaranHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaAlbaranDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaAlbaranDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cboEstadoFactura = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstadoFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDAlbaran = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlbaran = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.lblOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FraOperario = New Solmicro.Expertis.Engine.UI.Frame
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cboEstadoFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraOperario.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.FraOperario)
        Me.FilterPanel.Controls.Add(Me.lblSubfamilia)
        Me.FilterPanel.Controls.Add(Me.advIDSubfamilia)
        Me.FilterPanel.Controls.Add(Me.lblFamilia)
        Me.FilterPanel.Controls.Add(Me.advIDFamilia)
        Me.FilterPanel.Controls.Add(Me.lblTipo)
        Me.FilterPanel.Controls.Add(Me.advIDTipo)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.advIDCliente)
        Me.FilterPanel.Controls.Add(Me.lblObra)
        Me.FilterPanel.Controls.Add(Me.advIDObra)
        Me.FilterPanel.Controls.Add(Me.lblActivo)
        Me.FilterPanel.Controls.Add(Me.advIDActivo)
        Me.FilterPanel.Controls.Add(Me.lblFechaAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaAlbaranDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaAlbaranDesde)
        Me.FilterPanel.Controls.Add(Me.lblEstadoFactura)
        Me.FilterPanel.Controls.Add(Me.cboEstadoFactura)
        Me.FilterPanel.Controls.Add(Me.lblAlbaran)
        Me.FilterPanel.Controls.Add(Me.advIDAlbaran)
        Me.FilterPanel.Controls.Add(Me.lblContador)
        Me.FilterPanel.Controls.Add(Me.advIDContador)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 301)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 120)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 301)
        '
        'Grid
        '
        Me.Grid.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "Cantidad", 0, "CampoOrigen"), New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarcaFecha2", "Fecha", 1, "FechaAux")})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "AlbaranVentaCabecera"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.KeyField = "ClaveMarca"
        Me.Grid.Size = New System.Drawing.Size(688, 301)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vAlquilerCILecturaContador"
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
        Me.MainPanel.Size = New System.Drawing.Size(688, 421)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(688, 421)
        '
        'advIDSubfamilia
        '
        Me.advIDSubfamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDSubfamilia.EntityName = "Subfamilia"
        Me.advIDSubfamilia.Location = New System.Drawing.Point(480, 64)
        Me.advIDSubfamilia.Name = "advIDSubfamilia"
        Me.advIDSubfamilia.SecondaryDataFields = "IDSubfamilia"
        Me.advIDSubfamilia.Size = New System.Drawing.Size(80, 23)
        Me.advIDSubfamilia.TabIndex = 10
        Me.advIDSubfamilia.ViewName = "tbMaestroSubfamilia"
        '
        'lblSubfamilia
        '
        Me.lblSubfamilia.Location = New System.Drawing.Point(408, 64)
        Me.lblSubfamilia.Name = "lblSubfamilia"
        Me.lblSubfamilia.Size = New System.Drawing.Size(69, 13)
        Me.lblSubfamilia.TabIndex = 0
        Me.lblSubfamilia.Text = "SubFamilia"
        '
        'advIDFamilia
        '
        Me.advIDFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDFamilia.EntityName = "Familia"
        Me.advIDFamilia.Location = New System.Drawing.Point(480, 40)
        Me.advIDFamilia.Name = "advIDFamilia"
        Me.advIDFamilia.SecondaryDataFields = "IDFamilia"
        Me.advIDFamilia.Size = New System.Drawing.Size(80, 23)
        Me.advIDFamilia.TabIndex = 9
        Me.advIDFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(408, 40)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(47, 13)
        Me.lblFamilia.TabIndex = 11
        Me.lblFamilia.Text = "Familia"
        '
        'advIDTipo
        '
        Me.advIDTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTipo.EntityName = "TipoArticulo"
        Me.advIDTipo.Location = New System.Drawing.Point(480, 16)
        Me.advIDTipo.Name = "advIDTipo"
        Me.advIDTipo.SecondaryDataFields = "IDTipo"
        Me.advIDTipo.Size = New System.Drawing.Size(80, 23)
        Me.advIDTipo.TabIndex = 8
        Me.advIDTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(408, 16)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 13
        Me.lblTipo.Text = "Tipo"
        '
        'advIDCliente
        '
        Me.advIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCliente.EntityName = "Cliente"
        Me.advIDCliente.Location = New System.Drawing.Point(312, 88)
        Me.advIDCliente.Name = "advIDCliente"
        Me.advIDCliente.SecondaryDataFields = "IDCliente"
        Me.advIDCliente.Size = New System.Drawing.Size(80, 23)
        Me.advIDCliente.TabIndex = 7
        Me.advIDCliente.ViewName = "tbMaestroCliente"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(200, 88)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 15
        Me.lblCliente.Text = "Cliente"
        '
        'advIDObra
        '
        Me.advIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.advIDObra.DisplayField = "NObra"
        Me.advIDObra.EntityName = "ObraCabecera"
        Me.advIDObra.Location = New System.Drawing.Point(102, 16)
        Me.advIDObra.Name = "advIDObra"
        Me.advIDObra.SecondaryDataFields = "IDObra"
        Me.advIDObra.Size = New System.Drawing.Size(80, 23)
        Me.advIDObra.TabIndex = 0
        Me.advIDObra.ViewName = "tbObraCabecera"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(6, 16)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(50, 13)
        Me.lblObra.TabIndex = 0
        Me.lblObra.Text = "Alquiler"
        '
        'advIDActivo
        '
        Me.advIDActivo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDActivo.EntityName = "Activo"
        Me.advIDActivo.Location = New System.Drawing.Point(102, 88)
        Me.advIDActivo.Name = "advIDActivo"
        Me.advIDActivo.SecondaryDataFields = "IDActivo"
        Me.advIDActivo.Size = New System.Drawing.Size(80, 23)
        Me.advIDActivo.TabIndex = 3
        Me.advIDActivo.ViewName = "tbMaestroActivo"
        '
        'lblActivo
        '
        Me.lblActivo.Location = New System.Drawing.Point(6, 88)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(42, 13)
        Me.lblActivo.TabIndex = 19
        Me.lblActivo.Text = "Activo"
        '
        'cbxFechaAlbaranHasta
        '
        Me.cbxFechaAlbaranHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaAlbaranHasta.Location = New System.Drawing.Point(312, 40)
        Me.cbxFechaAlbaranHasta.Name = "cbxFechaAlbaranHasta"
        Me.cbxFechaAlbaranHasta.Size = New System.Drawing.Size(80, 21)
        Me.cbxFechaAlbaranHasta.TabIndex = 5
        '
        'lblFechaAlbaranHasta
        '
        Me.lblFechaAlbaranHasta.Location = New System.Drawing.Point(200, 40)
        Me.lblFechaAlbaranHasta.Name = "lblFechaAlbaranHasta"
        Me.lblFechaAlbaranHasta.Size = New System.Drawing.Size(110, 13)
        Me.lblFechaAlbaranHasta.TabIndex = 21
        Me.lblFechaAlbaranHasta.Text = "Fecha Albarán <="
        '
        'cbxFechaAlbaranDesde
        '
        Me.cbxFechaAlbaranDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaAlbaranDesde.Location = New System.Drawing.Point(312, 16)
        Me.cbxFechaAlbaranDesde.Name = "cbxFechaAlbaranDesde"
        Me.cbxFechaAlbaranDesde.Size = New System.Drawing.Size(80, 21)
        Me.cbxFechaAlbaranDesde.TabIndex = 4
        '
        'lblFechaAlbaranDesde
        '
        Me.lblFechaAlbaranDesde.Location = New System.Drawing.Point(200, 16)
        Me.lblFechaAlbaranDesde.Name = "lblFechaAlbaranDesde"
        Me.lblFechaAlbaranDesde.Size = New System.Drawing.Size(110, 13)
        Me.lblFechaAlbaranDesde.TabIndex = 22
        Me.lblFechaAlbaranDesde.Text = "Fecha Albarán >="
        '
        'cboEstadoFactura
        '
        cboEstadoFactura_DesignTimeLayout.LayoutString = resources.GetString("cboEstadoFactura_DesignTimeLayout.LayoutString")
        Me.cboEstadoFactura.DesignTimeLayout = cboEstadoFactura_DesignTimeLayout
        Me.cboEstadoFactura.DisabledBackColor = System.Drawing.Color.White
        Me.cboEstadoFactura.Location = New System.Drawing.Point(102, 64)
        Me.cboEstadoFactura.Name = "cboEstadoFactura"
        Me.cboEstadoFactura.SelectedIndex = -1
        Me.cboEstadoFactura.SelectedItem = Nothing
        Me.cboEstadoFactura.Size = New System.Drawing.Size(80, 21)
        Me.cboEstadoFactura.TabIndex = 2
        '
        'lblEstadoFactura
        '
        Me.lblEstadoFactura.Location = New System.Drawing.Point(6, 64)
        Me.lblEstadoFactura.Name = "lblEstadoFactura"
        Me.lblEstadoFactura.Size = New System.Drawing.Size(91, 13)
        Me.lblEstadoFactura.TabIndex = 23
        Me.lblEstadoFactura.Text = "Estado Factura"
        '
        'advIDAlbaran
        '
        Me.advIDAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.advIDAlbaran.DisplayField = "NAlbaran"
        Me.advIDAlbaran.EntityName = "AlbaranVentaCabecera"
        Me.advIDAlbaran.Location = New System.Drawing.Point(102, 40)
        Me.advIDAlbaran.Name = "advIDAlbaran"
        Me.advIDAlbaran.SecondaryDataFields = "IDAlbaran"
        Me.advIDAlbaran.Size = New System.Drawing.Size(80, 23)
        Me.advIDAlbaran.TabIndex = 1
        Me.advIDAlbaran.ViewName = "tbAlbaranVentaCabecera"
        '
        'lblAlbaran
        '
        Me.lblAlbaran.Location = New System.Drawing.Point(6, 40)
        Me.lblAlbaran.Name = "lblAlbaran"
        Me.lblAlbaran.Size = New System.Drawing.Size(51, 13)
        Me.lblAlbaran.TabIndex = 24
        Me.lblAlbaran.Text = "Albarán"
        '
        'advIDContador
        '
        Me.advIDContador.DisabledBackColor = System.Drawing.Color.White
        Me.advIDContador.EntityName = "PreventivoContador"
        Me.advIDContador.Location = New System.Drawing.Point(312, 64)
        Me.advIDContador.Name = "advIDContador"
        Me.advIDContador.SecondaryDataFields = "IDContadorPrev"
        Me.advIDContador.Size = New System.Drawing.Size(80, 23)
        Me.advIDContador.TabIndex = 6
        Me.advIDContador.ViewName = "tbPreventivoContador"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(200, 64)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 26
        Me.lblContador.Text = "Contador"
        '
        'lblOperario
        '
        Me.lblOperario.Location = New System.Drawing.Point(12, 30)
        Me.lblOperario.Name = "lblOperario"
        Me.lblOperario.Size = New System.Drawing.Size(57, 13)
        Me.lblOperario.TabIndex = 31
        Me.lblOperario.Text = "Operario"
        '
        'advIDOperario
        '
        Me.advIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperario.EntityName = "Operario"
        Me.advIDOperario.Location = New System.Drawing.Point(12, 48)
        Me.advIDOperario.Name = "advIDOperario"
        Me.advIDOperario.SecondaryDataFields = "IDOperario"
        Me.advIDOperario.Size = New System.Drawing.Size(96, 23)
        Me.advIDOperario.TabIndex = 0
        Me.advIDOperario.ViewName = "tbMaestroOperario"
        '
        'FraOperario
        '
        Me.FraOperario.Controls.Add(Me.lblOperario)
        Me.FraOperario.Controls.Add(Me.advIDOperario)
        Me.FraOperario.Location = New System.Drawing.Point(568, 0)
        Me.FraOperario.Name = "FraOperario"
        Me.FraOperario.Size = New System.Drawing.Size(119, 120)
        Me.FraOperario.TabIndex = 1
        Me.FraOperario.TabStop = False
        Me.FraOperario.Text = "Parámetros   "
        '
        'CILecturaContador
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "Cantidad", 0, "CampoOrigen"), New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarcaFecha2", "Fecha", 1, "FechaAux")})
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "AlbaranVentaCabecera"
        Me.KeyField = "ClaveMarca"
        Me.Name = "CILecturaContador"
        Me.UseCheck = True
        Me.ViewName = "vAlquilerCILecturaContador"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cboEstadoFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraOperario.ResumeLayout(False)
        Me.FraOperario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mIDAlbaran, mIDLineaAlbaran As Integer
    Private mblnOpenAlb As Boolean

    Private Const cnMNTO_EXPEDICION_ALQUILERES As String = "EXPALQ"
    Private Const cnMNTO_RETORNO_ALQUILERES As String = "RETFACTALQ"

#Region " Load "

    Private Sub CILecturaContador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadGridActions()
            LoadEnums()
            LoadToolbarActions()
            LoadParams()
            LoadFormSettings()
        End If
    End Sub

    Private Sub LoadEnums()
        cboEstadoFactura.DataSource = New EnumData("enumfvcEstado")
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Clear()
        Me.FormActions.Add("Eliminar Última Medición", AddressOf AccionEliminarUltimaMedida, ExpertisApp.GetIcon("garbage.ico"))
        Me.FormActions.Add("Actualizar Contador", AddressOf AccionActualizarContador, ExpertisApp.GetIcon("refresh.ico"))
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Clear()
        Me.Grid.Actions.Add(cnABRIRALBARANVENTA, AddressOf AccionAbrirAlbaranVenta, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            mIDAlbaran = Me.Params("IDAlbaran")
            mIDLineaAlbaran = Me.Params("IDLineaAlbaran")
            Me.Execute()
        End If
    End Sub

    Private Sub LoadFormSettings()
        Dim dt As DataTable = New Operario().Filter(New GuidFilterItem("IDUsuario", ExpertisApp.Token.UserID))
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            advIDOperario.Text = dt.Rows(0)("IDOperario")
            advIDOperario.ReadOnly = True
        End If
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub AccionEliminarUltimaMedida()
        If Grid.CheckedRecordsCount > 0 Then
            Me.Cursor = Cursors.WaitCursor

            Dim data As New PreventivoContadorHist.DatosElimUltMedida(Grid.SaveServerChecks.ToString, True)
            ExpertisApp.ExecuteTask(Of PreventivoContadorHist.DatosElimUltMedida)(AddressOf PreventivoContadorHist.EliminarUltimaMedida, data)

            Me.Cursor = Cursors.Default
            Me.UnCheckAllRecords()
            Me.Execute()
        Else
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AccionActualizarContador()
        If Length(advIDOperario.Value) > 0 Then
            If Grid.CheckedRecordsCount > 0 Then
                If ValidarFechaLecturaContador() Then
                    Dim ContadoresRetorno As DataTable = ValidarContadoresRetorno()
                    If Not IsNothing(ContadoresRetorno) AndAlso ContadoresRetorno.Rows.Count > 0 Then
                        ExpertisApp.GenerateMessage("Existen Contadores en Albaranes de Retorno para los que ya existe una medida.{0}Revise las medidas introducidas.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
                        Exit Sub
                    End If
                    Me.Cursor = Cursors.WaitCursor

                    Dim data As New PreventivoContadorHist.DatosActuaContador(Grid.SaveServerChecks.ToString, advIDOperario.Text, True)
                    Dim Errores As DataTable = ExpertisApp.ExecuteTask(Of PreventivoContadorHist.DatosActuaContador, DataTable)(AddressOf PreventivoContadorHist.ActualizarContador, data)

                    Me.Cursor = Cursors.Default
                    GenerarErrores(Errores)
                    QuitarMarcas()
                End If
            Else
                ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ExpertisApp.GenerateMessage("El Operario es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function ValidarContadoresRetorno() As DataTable
        Dim dtContMedExistentes As DataTable = Nothing
        If Not Grid Is Nothing AndAlso Me.CheckedRecordsCount > 0 Then
            dtContMedExistentes = Grid.CheckedRecords.Clone
            Dim dtGridChecked As DataTable = Grid.CheckedRecords
            For Each drRow As DataRow In dtGridChecked.Rows
                If Length(drRow("IDLineaAlbaranRetorno")) > 0 Then
                    Dim data As New PreventivoContadorHist.DatosExisteMedidaContEnFecha(drRow("IDContadorPrev"), drRow("CantidadMarcaFecha2"), drRow("IDLineaAlbaranRetorno"))
                    Dim Existe As Boolean = ExpertisApp.ExecuteTask(Of PreventivoContadorHist.DatosExisteMedidaContEnFecha, Boolean)(AddressOf PreventivoContadorHist.ExisteMedidaContadorEnFecha, data)
                    If Existe Then dtContMedExistentes.Rows.Add(drRow.ItemArray)
                End If
            Next
        End If
        Return dtContMedExistentes
    End Function

    Private Sub GenerarErrores(ByVal Errores As DataTable)
        If Not IsNothing(Errores) Then
            If Errores.Rows.Count > 1 Then
                Dim frmErrores As New frmErroresMedidasCont
                frmErrores.DataSource = Errores
                frmErrores.ShowDialog(Me)
            ElseIf Errores.Rows.Count = 1 Then
                Dim strMsg As String
                strMsg = "No ha sido posible la actualizacion de todos los contadores." & Chr(13)
                strMsg = strMsg & "" & UCase(Errores.Rows(0)("Contador")) & ": " & Errores.Rows(0)("MsgError")

                ExpertisApp.GenerateMessage(strMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub QuitarMarcas()
        Me.UnCheckAllRecords()
        Me.DeleteServerChecks()
        Me.Execute()
    End Sub

    Private Function ValidarFechaLecturaContador() As Boolean
        If Not Grid Is Nothing AndAlso Me.CheckedRecordsCount > 0 Then
            Dim dtGridChecked As DataTable = Grid.CheckedRecords
            If Not IsNothing(dtGridChecked) AndAlso dtGridChecked.Rows.Count > 0 Then
                For Each drRow As DataRow In dtGridChecked.Rows
                    If Length(drRow("CantidadMarcaFecha2")) = 0 Then
                        ExpertisApp.GenerateMessage("La Fecha de Lectura de las líneas seleccionadas es Obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return False
                    End If
                Next
            End If
        End If
        Return True
    End Function

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirAlbaranVenta()
        AbrirMntoAlbaranVenta(Grid.Value("IDAlbaran"))
    End Sub

#End Region

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Select Case e.Column.Key
            Case "CantidadMarcaFecha2"
                If Length(e.Value) > 0 AndAlso Length(Grid.Value("FechaUltimaFactura")) > 0 AndAlso (e.Value < Grid.Value("FechaUltimaFactura")) Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("La Fecha de Lectura no puede ser inferior a la Fecha de Última Factura.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
    End Sub

#Region " Query Executing "

    Private Sub CILecturaContador_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If mIDAlbaran <> 0 Then
            advIDAlbaran.Value = mIDAlbaran
            advIDAlbaran.Enabled = False
        End If
        If mIDLineaAlbaran > 0 Then
            e.Filter.Add("IDLineaAlbaran", FilterOperator.Equal, mIDLineaAlbaran, FilterType.Numeric)
        End If
        e.Filter.Add("IDActivo", FilterOperator.Equal, advIDActivo.Text, FilterType.String)
        e.Filter.Add("IDCliente", FilterOperator.Equal, advIDCliente.Text, FilterType.String)
        e.Filter.Add("IDContadorPrev", FilterOperator.Equal, advIDContador.Text, FilterType.String)
        e.Filter.Add("EstadoFactura", FilterOperator.Equal, cboEstadoFactura.Value, FilterType.Numeric)
        e.Filter.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaAlbaranDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaAlbaranHasta.Value, FilterType.DateTime)
        e.Filter.Add("IDAlbaran", FilterOperator.Equal, advIDAlbaran.Value, FilterType.Numeric)
        e.Filter.Add("IDObra", FilterOperator.Equal, advIDObra.Value, FilterType.Numeric)
        e.Filter.Add("IDTipo", FilterOperator.Equal, advIDTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, advIDFamilia.Text, FilterType.String)
        e.Filter.Add("IDSubfamilia", FilterOperator.Equal, advIDSubfamilia.Text, FilterType.String)
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)
        Me.cbxFechaAlbaranDesde.TextBox.Clear()
        Me.cbxFechaAlbaranHasta.TextBox.Clear()
    End Sub

#End Region

End Class