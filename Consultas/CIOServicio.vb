Public Class CIOServicio
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
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxFechaFinHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFinHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaInicioHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaInicioHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaFinDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFinDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaInicioDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaInicioDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxCierre As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblCierre As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxTipoFactAlquiler As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblTipoFactAlquiler As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxTipoFacturacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblTipoFacturacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCentroGestion As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCentroGestion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblDescObra As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxCierre_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIOServicio))
        Dim cbxTipoFactAlquiler_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoFacturacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cbxCierre = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblCierre = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoFactAlquiler = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTipoFactAlquiler = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoFacturacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTipoFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDescObra = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFinHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFinHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicioHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicioHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFinDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFinDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicioDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicioDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCentroGestion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.advObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTipoFactAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTipoFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblCierre)
        Me.FilterPanel.Controls.Add(Me.lblTipoFactAlquiler)
        Me.FilterPanel.Controls.Add(Me.lblTipoFacturacion)
        Me.FilterPanel.Controls.Add(Me.lblDescObra)
        Me.FilterPanel.Controls.Add(Me.lblFechaFinHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaInicioHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaFinDesde)
        Me.FilterPanel.Controls.Add(Me.lblEstado)
        Me.FilterPanel.Controls.Add(Me.lblCentroGestion)
        Me.FilterPanel.Controls.Add(Me.advObraDesde)
        Me.FilterPanel.Controls.Add(Me.advIDTrabajo)
        Me.FilterPanel.Controls.Add(Me.advObraHasta)
        Me.FilterPanel.Controls.Add(Me.cbxCierre)
        Me.FilterPanel.Controls.Add(Me.cbxTipoFactAlquiler)
        Me.FilterPanel.Controls.Add(Me.cbxTipoFacturacion)
        Me.FilterPanel.Controls.Add(Me.txtDescObra)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFinHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaInicioHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFinDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaInicioDesde)
        Me.FilterPanel.Controls.Add(Me.cbxEstado)
        Me.FilterPanel.Controls.Add(Me.advIDCentroGestion)
        Me.FilterPanel.Controls.Add(Me.lblFechaInicioDesde)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 229)
        Me.FilterPanel.Size = New System.Drawing.Size(784, 128)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(784, 229)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ObraTrabajo"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.KeyField = "IDTrabajo"
        Me.Grid.Size = New System.Drawing.Size(784, 229)
        Me.Grid.TabIndex = 13
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vAlquilerCIOrdenesServicio"
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
        Me.MainPanel.Size = New System.Drawing.Size(784, 357)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(784, 357)
        '
        'cbxCierre
        '
        cbxCierre_DesignTimeLayout.LayoutString = resources.GetString("cbxCierre_DesignTimeLayout.LayoutString")
        Me.cbxCierre.DesignTimeLayout = cbxCierre_DesignTimeLayout
        Me.cbxCierre.DisabledBackColor = System.Drawing.Color.White
        Me.cbxCierre.Location = New System.Drawing.Point(537, 50)
        Me.cbxCierre.Name = "cbxCierre"
        Me.cbxCierre.SelectedIndex = -1
        Me.cbxCierre.SelectedItem = Nothing
        Me.cbxCierre.Size = New System.Drawing.Size(86, 21)
        Me.cbxCierre.TabIndex = 9
        '
        'lblCierre
        '
        Me.lblCierre.Location = New System.Drawing.Point(429, 54)
        Me.lblCierre.Name = "lblCierre"
        Me.lblCierre.Size = New System.Drawing.Size(104, 13)
        Me.lblCierre.TabIndex = 0
        Me.lblCierre.Text = "Propuesta Cierre"
        '
        'cbxTipoFactAlquiler
        '
        cbxTipoFactAlquiler_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoFactAlquiler_DesignTimeLayout.LayoutString")
        Me.cbxTipoFactAlquiler.DesignTimeLayout = cbxTipoFactAlquiler_DesignTimeLayout
        Me.cbxTipoFactAlquiler.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoFactAlquiler.Location = New System.Drawing.Point(537, 98)
        Me.cbxTipoFactAlquiler.Name = "cbxTipoFactAlquiler"
        Me.cbxTipoFactAlquiler.SelectedIndex = -1
        Me.cbxTipoFactAlquiler.SelectedItem = Nothing
        Me.cbxTipoFactAlquiler.Size = New System.Drawing.Size(86, 21)
        Me.cbxTipoFactAlquiler.TabIndex = 11
        '
        'lblTipoFactAlquiler
        '
        Me.lblTipoFactAlquiler.Location = New System.Drawing.Point(429, 102)
        Me.lblTipoFactAlquiler.Name = "lblTipoFactAlquiler"
        Me.lblTipoFactAlquiler.Size = New System.Drawing.Size(109, 13)
        Me.lblTipoFactAlquiler.TabIndex = 12
        Me.lblTipoFactAlquiler.Text = "Tipo Fact. Alquiler"
        '
        'cbxTipoFacturacion
        '
        cbxTipoFacturacion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoFacturacion_DesignTimeLayout.LayoutString")
        Me.cbxTipoFacturacion.DesignTimeLayout = cbxTipoFacturacion_DesignTimeLayout
        Me.cbxTipoFacturacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoFacturacion.Location = New System.Drawing.Point(537, 74)
        Me.cbxTipoFacturacion.Name = "cbxTipoFacturacion"
        Me.cbxTipoFacturacion.SelectedIndex = -1
        Me.cbxTipoFacturacion.SelectedItem = Nothing
        Me.cbxTipoFacturacion.Size = New System.Drawing.Size(86, 21)
        Me.cbxTipoFacturacion.TabIndex = 10
        '
        'lblTipoFacturacion
        '
        Me.lblTipoFacturacion.Location = New System.Drawing.Point(429, 78)
        Me.lblTipoFacturacion.Name = "lblTipoFacturacion"
        Me.lblTipoFacturacion.Size = New System.Drawing.Size(100, 13)
        Me.lblTipoFacturacion.TabIndex = 14
        Me.lblTipoFacturacion.Text = "Tipo Facturación"
        '
        'txtDescObra
        '
        Me.txtDescObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescObra.Location = New System.Drawing.Point(99, 76)
        Me.txtDescObra.Name = "txtDescObra"
        Me.txtDescObra.Size = New System.Drawing.Size(136, 21)
        Me.txtDescObra.TabIndex = 2
        '
        'lblDescObra
        '
        Me.lblDescObra.Location = New System.Drawing.Point(8, 78)
        Me.lblDescObra.Name = "lblDescObra"
        Me.lblDescObra.Size = New System.Drawing.Size(86, 13)
        Me.lblDescObra.TabIndex = 15
        Me.lblDescObra.Text = "Desc. Alquiler"
        '
        'cbxFechaFinHasta
        '
        Me.cbxFechaFinHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFinHasta.Location = New System.Drawing.Point(337, 98)
        Me.cbxFechaFinHasta.Name = "cbxFechaFinHasta"
        Me.cbxFechaFinHasta.Size = New System.Drawing.Size(79, 21)
        Me.cbxFechaFinHasta.TabIndex = 7
        '
        'lblFechaFinHasta
        '
        Me.lblFechaFinHasta.Location = New System.Drawing.Point(246, 102)
        Me.lblFechaFinHasta.Name = "lblFechaFinHasta"
        Me.lblFechaFinHasta.Size = New System.Drawing.Size(73, 13)
        Me.lblFechaFinHasta.TabIndex = 18
        Me.lblFechaFinHasta.Text = "F. Fin Hasta"
        '
        'cbxFechaInicioHasta
        '
        Me.cbxFechaInicioHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicioHasta.Location = New System.Drawing.Point(337, 50)
        Me.cbxFechaInicioHasta.Name = "cbxFechaInicioHasta"
        Me.cbxFechaInicioHasta.Size = New System.Drawing.Size(79, 21)
        Me.cbxFechaInicioHasta.TabIndex = 5
        '
        'lblFechaInicioHasta
        '
        Me.lblFechaInicioHasta.Location = New System.Drawing.Point(246, 54)
        Me.lblFechaInicioHasta.Name = "lblFechaInicioHasta"
        Me.lblFechaInicioHasta.Size = New System.Drawing.Size(88, 13)
        Me.lblFechaInicioHasta.TabIndex = 19
        Me.lblFechaInicioHasta.Text = "F. Inicio Hasta"
        '
        'cbxFechaFinDesde
        '
        Me.cbxFechaFinDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFinDesde.Location = New System.Drawing.Point(337, 74)
        Me.cbxFechaFinDesde.Name = "cbxFechaFinDesde"
        Me.cbxFechaFinDesde.Size = New System.Drawing.Size(79, 21)
        Me.cbxFechaFinDesde.TabIndex = 6
        '
        'lblFechaFinDesde
        '
        Me.lblFechaFinDesde.Location = New System.Drawing.Point(246, 78)
        Me.lblFechaFinDesde.Name = "lblFechaFinDesde"
        Me.lblFechaFinDesde.Size = New System.Drawing.Size(77, 13)
        Me.lblFechaFinDesde.TabIndex = 20
        Me.lblFechaFinDesde.Text = "F. Fin Desde"
        '
        'cbxFechaInicioDesde
        '
        Me.cbxFechaInicioDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicioDesde.Location = New System.Drawing.Point(337, 26)
        Me.cbxFechaInicioDesde.Name = "cbxFechaInicioDesde"
        Me.cbxFechaInicioDesde.Size = New System.Drawing.Size(79, 21)
        Me.cbxFechaInicioDesde.TabIndex = 4
        '
        'lblFechaInicioDesde
        '
        Me.lblFechaInicioDesde.Location = New System.Drawing.Point(246, 28)
        Me.lblFechaInicioDesde.Name = "lblFechaInicioDesde"
        Me.lblFechaInicioDesde.Size = New System.Drawing.Size(92, 13)
        Me.lblFechaInicioDesde.TabIndex = 21
        Me.lblFechaInicioDesde.Text = "F. Inicio Desde"
        '
        'cbxEstado
        '
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.Location = New System.Drawing.Point(687, 24)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(86, 21)
        Me.cbxEstado.TabIndex = 12
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(638, 28)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 22
        Me.lblEstado.Text = "Estado"
        '
        'advIDCentroGestion
        '
        Me.advIDCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCentroGestion.EntityName = "CentroGestion"
        Me.advIDCentroGestion.Location = New System.Drawing.Point(537, 24)
        Me.advIDCentroGestion.Name = "advIDCentroGestion"
        Me.advIDCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.advIDCentroGestion.Size = New System.Drawing.Size(86, 23)
        Me.advIDCentroGestion.TabIndex = 8
        Me.advIDCentroGestion.ViewName = "tbMaestroCentroGestion"
        '
        'lblCentroGestion
        '
        Me.lblCentroGestion.Location = New System.Drawing.Point(429, 29)
        Me.lblCentroGestion.Name = "lblCentroGestion"
        Me.lblCentroGestion.Size = New System.Drawing.Size(93, 13)
        Me.lblCentroGestion.TabIndex = 23
        Me.lblCentroGestion.Text = "Centro Gestión"
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(8, 28)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(90, 13)
        Me.lblObraDesde.TabIndex = 39
        Me.lblObraDesde.Text = "Alquiler Desde"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(8, 102)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(70, 13)
        Me.lblTrabajo.TabIndex = 40
        Me.lblTrabajo.Text = "O. Servicio"
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(8, 54)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(86, 13)
        Me.lblObraHasta.TabIndex = 41
        Me.lblObraHasta.Text = "Alquiler Hasta"
        '
        'advObraDesde
        '
        Me.advObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advObraDesde.DisplayField = "NObra"
        Me.advObraDesde.EntityName = "ObraCabecera"
        Me.advObraDesde.Location = New System.Drawing.Point(99, 24)
        Me.advObraDesde.Name = "advObraDesde"
        Me.advObraDesde.SecondaryDataFields = "IDObra"
        Me.advObraDesde.Size = New System.Drawing.Size(104, 23)
        Me.advObraDesde.TabIndex = 0
        Me.advObraDesde.ViewName = "tbObraCabecera"
        '
        'advIDTrabajo
        '
        Me.advIDTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTrabajo.DisplayField = "CodTrabajo"
        Me.advIDTrabajo.EntityName = "ObraTrabajo"
        Me.advIDTrabajo.Location = New System.Drawing.Point(99, 100)
        Me.advIDTrabajo.Name = "advIDTrabajo"
        Me.advIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.advIDTrabajo.Size = New System.Drawing.Size(104, 23)
        Me.advIDTrabajo.TabIndex = 3
        Me.advIDTrabajo.ViewName = "tbObraTrabajo"
        '
        'advObraHasta
        '
        Me.advObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advObraHasta.DisplayField = "NObra"
        Me.advObraHasta.EntityName = "ObraCabecera"
        Me.advObraHasta.Location = New System.Drawing.Point(99, 50)
        Me.advObraHasta.Name = "advObraHasta"
        Me.advObraHasta.SecondaryDataFields = "IDObra"
        Me.advObraHasta.Size = New System.Drawing.Size(104, 23)
        Me.advObraHasta.TabIndex = 1
        Me.advObraHasta.ViewName = "tbObraCabecera"
        '
        'CIOServicio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 445)
        Me.EntityName = "ObraTrabajo"
        Me.KeyField = "IDTrabajo"
        Me.Name = "CIOServicio"
        Me.UseCheck = True
        Me.ViewName = "vAlquilerCIOrdenesServicio"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxCierre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTipoFactAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTipoFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cnMNTO_SEGUIMIENTO_ALQUILER As String = "SEGALQUI"

#Region " Load "

    Private Sub CIOServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadEnums()
            LoadToolbarActions()
            LoadGridActions()
            InitFilterCriteria()
        End If
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumotTipoFacturacion", Grid.Columns("TipoFacturacion"))
        EnumData.PopulateValueList("enumTipoFacturacionAlquiler", Grid.Columns("TipoFactAlquiler"))
        EnumData.PopulateValueList("enumotEstado", Grid.Columns("Estado"))
        cbxEstado.DataSource = New EnumData("enumotEstado")
        cbxCierre.DataSource = New EnumData("enumBoolean")
        cbxTipoFacturacion.DataSource = New EnumData("enumotTipoFacturacion")
        cbxTipoFactAlquiler.DataSource = New EnumData("enumTipoFacturacionAlquiler")
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Clear()
        Me.FormActions.Add("Cierre de Ordenes de Servicio", AddressOf AccionCierreOrdenes, ExpertisApp.GetIcon("trafficlight_red.ico"))
        Me.FormActions.Add("Reapertura de Ordenes de Servicio", AddressOf AccionReaperturaOrdenes, ExpertisApp.GetIcon("trafficlight_green.ico"))
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Clear()
        Grid.Actions.Add("Abrir Seguimiento Alquiler", AddressOf AccionGridAbrirSeguimientoAlquiler, ExpertisApp.GetIcon("xEstructuras1.ico"))
        Grid.Actions.Add(cnABRIRALQUILER, AddressOf AccionAbrirAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
        Grid.Actions.Add(cnABRIRORDENSERVICIO, AddressOf AccionAbrirOrdenServicio, ExpertisApp.GetIcon("clipboard.ico"))
    End Sub

    Private Sub InitFilterCriteria()
        cbxCierre.Value = enumBoolean.Todos
        cbxTipoFacturacion.Value = CInt(enumotTipoFacturacion.otfPorConceptos)
        cbxTipoFactAlquiler.Value = CInt(enumTipoFacturacionAlquiler.enumTFASinAlquiler)
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub AccionCierreOrdenes()
        CambiarEstado(enumotEstado.otTerminado)
    End Sub

    Private Sub AccionReaperturaOrdenes()
        CambiarEstado(enumotEstado.otPendiente)
    End Sub

    Private Sub CambiarEstado(ByVal NuevoEstado As enumotEstado)
        Dim strMensaje As String = String.Empty
        If NuevoEstado = enumotEstado.otTerminado Then
            strMensaje = "Se cerrarán las ordenes de servicio seleccionadas que tengan la marca propuesta de cierre."
        Else
            strMensaje = "Se reabrirán las órdenes de servicio seleccionadas que estén cerradas."
        End If
        Dim dtMarcados As DataTable = Grid.CheckedRecords
        If dtMarcados Is Nothing OrElse dtMarcados.Rows.Count = 0 Then
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ExpertisApp.GenerateMessage(strMensaje, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            If NuevoEstado = enumotEstado.otTerminado Then TratarDatos(dtMarcados)
            If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                Dim info As New ObraTrabajo.dataCambiarEstadoTrabajo(dtMarcados, NuevoEstado)
                ExpertisApp.ExecuteTask(Of ObraTrabajo.dataCambiarEstadoTrabajo)(AddressOf ObraTrabajo.CambiarEstadoTrabajo, info)

                Grid.UnCheckAllRecords()
                Me.Execute()
                ExpertisApp.GenerateMessage("Proceso Finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub TratarDatos(ByRef dtMarcados As DataTable)
        For Each drMarcados As DataRow In dtMarcados.Select
            If Not CBool(drMarcados("PropuestaDeCierre")) Then
                dtMarcados.Rows.Remove(drMarcados)
            End If
        Next
    End Sub

#End Region

#Region " Acciones del grid "

    Private Sub AccionAbrirAlquiler()
        AbrirMntoAlquiler(Grid.Value("IDObra"))
    End Sub

    Private Sub AccionAbrirOrdenServicio()
        AbrirOrdenServicio(Grid.Value("IDTrabajo"), Grid.Value("IDObra"))
    End Sub

    Private Sub AccionGridAbrirSeguimientoAlquiler()
        ExpertisApp.OpenForm(cnMNTO_SEGUIMIENTO_ALQUILER, New NumberFilterItem("IDObra", Grid.Value("IDObra")))
    End Sub

#End Region

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Select Case Grid.Columns(e.Column.Index).Key
            Case "TipoFacturacion", "Estado", "TipoFactAlquiler"
                e.Cancel = True
        End Select
    End Sub

#Region " QueryExecuting "

    Private Sub CIOServicio_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, advIDTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("IDCentroGestion", FilterOperator.Equal, advIDCentroGestion.Text, FilterType.String)
        e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, advObraDesde.Value, FilterType.Numeric)
        e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, advObraHasta.Value, FilterType.Numeric)
        If Length(txtDescObra.Text) > 0 Then e.Filter.Add(New LikeFilterItem("DescObra", txtDescObra.Text))

        e.Filter.Add("FechaInicio", FilterOperator.GreaterThanOrEqual, cbxFechaInicioDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaInicio", FilterOperator.LessThanOrEqual, cbxFechaInicioHasta.Value, FilterType.DateTime)
        e.Filter.Add("FechaFin", FilterOperator.GreaterThanOrEqual, cbxFechaFinDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaFin", FilterOperator.LessThanOrEqual, cbxFechaFinHasta.Value, FilterType.DateTime)

        e.Filter.Add("TipoFactAlquiler", FilterOperator.Equal, cbxTipoFactAlquiler.Value, FilterType.Numeric)
        e.Filter.Add("TipoFacturacion", FilterOperator.Equal, cbxTipoFacturacion.Value, FilterType.Numeric)
        e.Filter.Add("Estado", FilterOperator.Equal, cbxEstado.Value, FilterType.Numeric)
        If cbxCierre.Value <> enumBoolean.Todos Then
            e.Filter.Add("PropuestaDeCierre", FilterOperator.Equal, cbxCierre.Value, FilterType.Numeric)
        End If
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)

        InitFilterCriteria()
    End Sub

#End Region

End Class
