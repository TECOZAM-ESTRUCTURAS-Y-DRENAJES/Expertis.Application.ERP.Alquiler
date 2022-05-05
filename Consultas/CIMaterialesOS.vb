Public Class CIMaterialesOS
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtPrevistaDesde.Value = System.DBNull.Value
        txtPrevistaHasta.Value = System.DBNull.Value
        txtRetornadaDesde.Value = System.DBNull.Value
        txtRetornadaHasta.Value = System.DBNull.Value
        txtEnviadaDesde.Value = System.DBNull.Value
        txtEnviadaHasta.Value = System.DBNull.Value
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
    Friend WithEvents advObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNMaquina As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblNMaquina As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboFacturable As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblFacturable As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboPlusContadores As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblPlusContadores As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboDiasMinimos As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblDiasMinimos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDMaterial As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblMaterial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboExpedible As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblExpedible As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtRetornadaHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblRetornadaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtRetornadaDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lbltxtRetornadaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtEnviadaHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblEnviadaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtEnviadaDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblEnviadaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPrevistaHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPrevistaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPrevistaDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPrevistaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboPlusContadores_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIMaterialesOS))
        Dim cboDiasMinimos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboFacturable_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboExpedible_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.txtRetornadaHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblRetornadaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRetornadaDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lbltxtRetornadaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.txtEnviadaHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblEnviadaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtEnviadaDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblEnviadaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPrevistaHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPrevistaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPrevistaDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPrevistaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cboPlusContadores = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblPlusContadores = New Solmicro.Expertis.Engine.UI.Label
        Me.cboDiasMinimos = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblDiasMinimos = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDMaterial = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.advObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNMaquina = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNMaquina = New Solmicro.Expertis.Engine.UI.Label
        Me.cboEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.advObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cboFacturable = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFacturable = New Solmicro.Expertis.Engine.UI.Label
        Me.cboExpedible = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblExpedible = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cboPlusContadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDiasMinimos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFacturable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboExpedible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblRetornadaHasta)
        Me.FilterPanel.Controls.Add(Me.lbltxtRetornadaDesde)
        Me.FilterPanel.Controls.Add(Me.lblEnviadaHasta)
        Me.FilterPanel.Controls.Add(Me.lblEnviadaDesde)
        Me.FilterPanel.Controls.Add(Me.lblPrevistaHasta)
        Me.FilterPanel.Controls.Add(Me.lblPrevistaDesde)
        Me.FilterPanel.Controls.Add(Me.lblPlusContadores)
        Me.FilterPanel.Controls.Add(Me.lblDiasMinimos)
        Me.FilterPanel.Controls.Add(Me.lblMaterial)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblNMaquina)
        Me.FilterPanel.Controls.Add(Me.lblEstado)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblFacturable)
        Me.FilterPanel.Controls.Add(Me.lblExpedible)
        Me.FilterPanel.Controls.Add(Me.txtRetornadaHasta)
        Me.FilterPanel.Controls.Add(Me.txtRetornadaDesde)
        Me.FilterPanel.Controls.Add(Me.txtEnviadaHasta)
        Me.FilterPanel.Controls.Add(Me.txtEnviadaDesde)
        Me.FilterPanel.Controls.Add(Me.txtPrevistaHasta)
        Me.FilterPanel.Controls.Add(Me.txtPrevistaDesde)
        Me.FilterPanel.Controls.Add(Me.cboPlusContadores)
        Me.FilterPanel.Controls.Add(Me.cboDiasMinimos)
        Me.FilterPanel.Controls.Add(Me.advIDMaterial)
        Me.FilterPanel.Controls.Add(Me.advObraDesde)
        Me.FilterPanel.Controls.Add(Me.advIDTrabajo)
        Me.FilterPanel.Controls.Add(Me.txtNMaquina)
        Me.FilterPanel.Controls.Add(Me.cboEstado)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.advObraHasta)
        Me.FilterPanel.Controls.Add(Me.cboFacturable)
        Me.FilterPanel.Controls.Add(Me.cboExpedible)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 252)
        Me.FilterPanel.Size = New System.Drawing.Size(917, 169)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(917, 252)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraMaterial"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.KeyField = "IDLineaMaterial"
        Me.Grid.Size = New System.Drawing.Size(917, 252)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vAlquilerCIMaterialesOS"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(222, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(917, 421)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(917, 421)
        '
        'txtRetornadaHasta
        '
        Me.txtRetornadaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtRetornadaHasta.Location = New System.Drawing.Point(805, 57)
        Me.txtRetornadaHasta.Name = "txtRetornadaHasta"
        Me.txtRetornadaHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtRetornadaHasta.Size = New System.Drawing.Size(103, 21)
        Me.txtRetornadaHasta.TabIndex = 15
        '
        'lblRetornadaHasta
        '
        Me.lblRetornadaHasta.Location = New System.Drawing.Point(700, 60)
        Me.lblRetornadaHasta.Name = "lblRetornadaHasta"
        Me.lblRetornadaHasta.Size = New System.Drawing.Size(105, 13)
        Me.lblRetornadaHasta.TabIndex = 0
        Me.lblRetornadaHasta.Text = "C. Retornada <="
        '
        'txtRetornadaDesde
        '
        Me.txtRetornadaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtRetornadaDesde.Location = New System.Drawing.Point(805, 32)
        Me.txtRetornadaDesde.Name = "txtRetornadaDesde"
        Me.txtRetornadaDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtRetornadaDesde.Size = New System.Drawing.Size(103, 21)
        Me.txtRetornadaDesde.TabIndex = 14
        '
        'lbltxtRetornadaDesde
        '
        Me.lbltxtRetornadaDesde.Location = New System.Drawing.Point(700, 34)
        Me.lbltxtRetornadaDesde.Name = "lbltxtRetornadaDesde"
        Me.lbltxtRetornadaDesde.Size = New System.Drawing.Size(105, 13)
        Me.lbltxtRetornadaDesde.TabIndex = 18
        Me.lbltxtRetornadaDesde.Text = "C. Retornada >="
        '
        'txtEnviadaHasta
        '
        Me.txtEnviadaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtEnviadaHasta.Location = New System.Drawing.Point(805, 106)
        Me.txtEnviadaHasta.Name = "txtEnviadaHasta"
        Me.txtEnviadaHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtEnviadaHasta.Size = New System.Drawing.Size(103, 21)
        Me.txtEnviadaHasta.TabIndex = 17
        '
        'lblEnviadaHasta
        '
        Me.lblEnviadaHasta.Location = New System.Drawing.Point(700, 110)
        Me.lblEnviadaHasta.Name = "lblEnviadaHasta"
        Me.lblEnviadaHasta.Size = New System.Drawing.Size(91, 13)
        Me.lblEnviadaHasta.TabIndex = 19
        Me.lblEnviadaHasta.Text = "C. Enviada <="
        '
        'txtEnviadaDesde
        '
        Me.txtEnviadaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtEnviadaDesde.Location = New System.Drawing.Point(805, 82)
        Me.txtEnviadaDesde.Name = "txtEnviadaDesde"
        Me.txtEnviadaDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtEnviadaDesde.Size = New System.Drawing.Size(103, 21)
        Me.txtEnviadaDesde.TabIndex = 16
        '
        'lblEnviadaDesde
        '
        Me.lblEnviadaDesde.Location = New System.Drawing.Point(700, 85)
        Me.lblEnviadaDesde.Name = "lblEnviadaDesde"
        Me.lblEnviadaDesde.Size = New System.Drawing.Size(91, 13)
        Me.lblEnviadaDesde.TabIndex = 20
        Me.lblEnviadaDesde.Text = "C. Enviada >="
        '
        'txtPrevistaHasta
        '
        Me.txtPrevistaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtPrevistaHasta.Location = New System.Drawing.Point(581, 106)
        Me.txtPrevistaHasta.Name = "txtPrevistaHasta"
        Me.txtPrevistaHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtPrevistaHasta.Size = New System.Drawing.Size(103, 21)
        Me.txtPrevistaHasta.TabIndex = 13
        '
        'lblPrevistaHasta
        '
        Me.lblPrevistaHasta.Location = New System.Drawing.Point(488, 110)
        Me.lblPrevistaHasta.Name = "lblPrevistaHasta"
        Me.lblPrevistaHasta.Size = New System.Drawing.Size(92, 13)
        Me.lblPrevistaHasta.TabIndex = 21
        Me.lblPrevistaHasta.Text = "C. Prevista <="
        '
        'txtPrevistaDesde
        '
        Me.txtPrevistaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtPrevistaDesde.Location = New System.Drawing.Point(581, 82)
        Me.txtPrevistaDesde.Name = "txtPrevistaDesde"
        Me.txtPrevistaDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtPrevistaDesde.Size = New System.Drawing.Size(103, 21)
        Me.txtPrevistaDesde.TabIndex = 12
        '
        'lblPrevistaDesde
        '
        Me.lblPrevistaDesde.Location = New System.Drawing.Point(488, 84)
        Me.lblPrevistaDesde.Name = "lblPrevistaDesde"
        Me.lblPrevistaDesde.Size = New System.Drawing.Size(92, 13)
        Me.lblPrevistaDesde.TabIndex = 22
        Me.lblPrevistaDesde.Text = "C. Prevista >="
        '
        'cboPlusContadores
        '
        cboPlusContadores_DesignTimeLayout.LayoutString = resources.GetString("cboPlusContadores_DesignTimeLayout.LayoutString")
        Me.cboPlusContadores.DesignTimeLayout = cboPlusContadores_DesignTimeLayout
        Me.cboPlusContadores.DisabledBackColor = System.Drawing.Color.White
        Me.cboPlusContadores.Location = New System.Drawing.Point(376, 106)
        Me.cboPlusContadores.Name = "cboPlusContadores"
        Me.cboPlusContadores.SelectedIndex = -1
        Me.cboPlusContadores.SelectedItem = Nothing
        Me.cboPlusContadores.Size = New System.Drawing.Size(94, 21)
        Me.cboPlusContadores.TabIndex = 8
        '
        'lblPlusContadores
        '
        Me.lblPlusContadores.Location = New System.Drawing.Point(231, 110)
        Me.lblPlusContadores.Name = "lblPlusContadores"
        Me.lblPlusContadores.Size = New System.Drawing.Size(131, 13)
        Me.lblPlusContadores.TabIndex = 23
        Me.lblPlusContadores.Text = "Fact. Plus Contadores"
        '
        'cboDiasMinimos
        '
        cboDiasMinimos_DesignTimeLayout.LayoutString = resources.GetString("cboDiasMinimos_DesignTimeLayout.LayoutString")
        Me.cboDiasMinimos.DesignTimeLayout = cboDiasMinimos_DesignTimeLayout
        Me.cboDiasMinimos.DisabledBackColor = System.Drawing.Color.White
        Me.cboDiasMinimos.Location = New System.Drawing.Point(376, 82)
        Me.cboDiasMinimos.Name = "cboDiasMinimos"
        Me.cboDiasMinimos.SelectedIndex = -1
        Me.cboDiasMinimos.SelectedItem = Nothing
        Me.cboDiasMinimos.Size = New System.Drawing.Size(94, 21)
        Me.cboDiasMinimos.TabIndex = 7
        '
        'lblDiasMinimos
        '
        Me.lblDiasMinimos.Location = New System.Drawing.Point(231, 86)
        Me.lblDiasMinimos.Name = "lblDiasMinimos"
        Me.lblDiasMinimos.Size = New System.Drawing.Size(113, 13)
        Me.lblDiasMinimos.TabIndex = 24
        Me.lblDiasMinimos.Text = "Fact. Días Mínimos"
        '
        'advIDMaterial
        '
        Me.advIDMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.advIDMaterial.EntityName = "Articulo"
        Me.advIDMaterial.Location = New System.Drawing.Point(581, 30)
        Me.advIDMaterial.Name = "advIDMaterial"
        Me.advIDMaterial.SecondaryDataFields = "IDArticulo"
        Me.advIDMaterial.Size = New System.Drawing.Size(103, 23)
        Me.advIDMaterial.TabIndex = 10
        Me.advIDMaterial.ViewName = "tbMaestroArticulo"
        '
        'lblMaterial
        '
        Me.lblMaterial.Location = New System.Drawing.Point(488, 34)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(50, 13)
        Me.lblMaterial.TabIndex = 25
        Me.lblMaterial.Text = "Artículo"
        '
        'advObraDesde
        '
        Me.advObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advObraDesde.DisplayField = "NObra"
        Me.advObraDesde.EntityName = "ObraCabecera"
        Me.advObraDesde.Location = New System.Drawing.Point(105, 29)
        Me.advObraDesde.Name = "advObraDesde"
        Me.advObraDesde.SecondaryDataFields = "IDObra"
        Me.advObraDesde.Size = New System.Drawing.Size(109, 23)
        Me.advObraDesde.TabIndex = 0
        Me.advObraDesde.ViewName = "tbObraCabecera"
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(11, 34)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(90, 13)
        Me.lblObraDesde.TabIndex = 27
        Me.lblObraDesde.Text = "Alquiler Desde"
        '
        'advIDTrabajo
        '
        Me.advIDTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTrabajo.DisplayField = "CodTrabajo"
        Me.advIDTrabajo.EntityName = "ObraTrabajo"
        Me.advIDTrabajo.Location = New System.Drawing.Point(105, 81)
        Me.advIDTrabajo.Name = "advIDTrabajo"
        Me.advIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.advIDTrabajo.Size = New System.Drawing.Size(109, 23)
        Me.advIDTrabajo.TabIndex = 2
        Me.advIDTrabajo.ViewName = "tbObraTrabajo"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(11, 85)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(70, 13)
        Me.lblTrabajo.TabIndex = 29
        Me.lblTrabajo.Text = "O. Servicio"
        '
        'txtNMaquina
        '
        Me.txtNMaquina.DisabledBackColor = System.Drawing.Color.White
        Me.txtNMaquina.Location = New System.Drawing.Point(105, 107)
        Me.txtNMaquina.Name = "txtNMaquina"
        Me.txtNMaquina.Size = New System.Drawing.Size(109, 21)
        Me.txtNMaquina.TabIndex = 3
        '
        'lblNMaquina
        '
        Me.lblNMaquina.Location = New System.Drawing.Point(11, 110)
        Me.lblNMaquina.Name = "lblNMaquina"
        Me.lblNMaquina.Size = New System.Drawing.Size(55, 13)
        Me.lblNMaquina.TabIndex = 31
        Me.lblNMaquina.Text = "Nº Serie"
        '
        'cboEstado
        '
        cboEstado_DesignTimeLayout.LayoutString = resources.GetString("cboEstado_DesignTimeLayout.LayoutString")
        Me.cboEstado.DesignTimeLayout = cboEstado_DesignTimeLayout
        Me.cboEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cboEstado.Location = New System.Drawing.Point(581, 57)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.SelectedIndex = -1
        Me.cboEstado.SelectedItem = Nothing
        Me.cboEstado.Size = New System.Drawing.Size(103, 21)
        Me.cboEstado.TabIndex = 11
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(488, 59)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 32
        Me.lblEstado.Text = "Estado"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(376, 32)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(94, 21)
        Me.cbxFechaDesde.TabIndex = 5
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(231, 34)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(105, 13)
        Me.lblFechaDesde.TabIndex = 33
        Me.lblFechaDesde.Text = "F. Entrega Desde"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(376, 57)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(94, 21)
        Me.cbxFechaHasta.TabIndex = 6
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(231, 59)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(101, 13)
        Me.lblFechaHasta.TabIndex = 34
        Me.lblFechaHasta.Text = "F. Entrega Hasta"
        '
        'advObraHasta
        '
        Me.advObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advObraHasta.DisplayField = "NObra"
        Me.advObraHasta.EntityName = "ObraCabecera"
        Me.advObraHasta.Location = New System.Drawing.Point(105, 55)
        Me.advObraHasta.Name = "advObraHasta"
        Me.advObraHasta.SecondaryDataFields = "IDObra"
        Me.advObraHasta.Size = New System.Drawing.Size(109, 23)
        Me.advObraHasta.TabIndex = 1
        Me.advObraHasta.ViewName = "tbObraCabecera"
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(11, 59)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(86, 13)
        Me.lblObraHasta.TabIndex = 35
        Me.lblObraHasta.Text = "Alquiler Hasta"
        '
        'cboFacturable
        '
        cboFacturable_DesignTimeLayout.LayoutString = resources.GetString("cboFacturable_DesignTimeLayout.LayoutString")
        Me.cboFacturable.DesignTimeLayout = cboFacturable_DesignTimeLayout
        Me.cboFacturable.DisabledBackColor = System.Drawing.Color.White
        Me.cboFacturable.Location = New System.Drawing.Point(105, 131)
        Me.cboFacturable.Name = "cboFacturable"
        Me.cboFacturable.SelectedIndex = -1
        Me.cboFacturable.SelectedItem = Nothing
        Me.cboFacturable.Size = New System.Drawing.Size(109, 21)
        Me.cboFacturable.TabIndex = 4
        '
        'lblFacturable
        '
        Me.lblFacturable.Location = New System.Drawing.Point(11, 134)
        Me.lblFacturable.Name = "lblFacturable"
        Me.lblFacturable.Size = New System.Drawing.Size(66, 13)
        Me.lblFacturable.TabIndex = 37
        Me.lblFacturable.Text = "Facturable"
        '
        'cboExpedible
        '
        cboExpedible_DesignTimeLayout.LayoutString = resources.GetString("cboExpedible_DesignTimeLayout.LayoutString")
        Me.cboExpedible.DesignTimeLayout = cboExpedible_DesignTimeLayout
        Me.cboExpedible.DisabledBackColor = System.Drawing.Color.White
        Me.cboExpedible.Location = New System.Drawing.Point(376, 130)
        Me.cboExpedible.Name = "cboExpedible"
        Me.cboExpedible.SelectedIndex = -1
        Me.cboExpedible.SelectedItem = Nothing
        Me.cboExpedible.Size = New System.Drawing.Size(94, 21)
        Me.cboExpedible.TabIndex = 9
        '
        'lblExpedible
        '
        Me.lblExpedible.Location = New System.Drawing.Point(231, 134)
        Me.lblExpedible.Name = "lblExpedible"
        Me.lblExpedible.Size = New System.Drawing.Size(62, 13)
        Me.lblExpedible.TabIndex = 38
        Me.lblExpedible.Text = "Expedible"
        '
        'CIMaterialesOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(925, 509)
        Me.EntityName = "ObraMaterial"
        Me.KeyField = "IDLineaMaterial"
        Me.Name = "CIMaterialesOS"
        Me.ViewName = "vAlquilerCIMaterialesOS"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cboPlusContadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDiasMinimos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFacturable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboExpedible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CIMaterialesOS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadEnums()
            LoadGridActions()
            InitFilterCriteria()
        End If
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumomATipoFacturacionAlquiler", Grid.Columns("TipoFacturacion"))
        EnumData.PopulateValueList("enumTipoFacturacionAlquiler", Grid.Columns("TipoFactAlquiler"))
        EnumData.PopulateValueList("enumocEstado", Grid.Columns("Estado"))

        cboEstado.DataSource = New EnumData("enumocEstado")
        cboFacturable.DataSource = New EnumData("enumBoolean")
        cboExpedible.DataSource = New EnumData("enumBoolean")
        cboDiasMinimos.DataSource = New EnumData("enumBoolean")
        cboPlusContadores.DataSource = New EnumData("enumBoolean")
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add(cnABRIRALQUILER, AddressOf AccionAbrirAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub InitFilterCriteria()
        cboExpedible.Value = enumBoolean.Todos
        cboFacturable.Value = enumBoolean.Todos
        cboDiasMinimos.Value = enumBoolean.Todos
        cboPlusContadores.Value = enumBoolean.Todos
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirAlquiler()
        AbrirMntoAlquiler(Grid.Value("IDObra"))
    End Sub

#End Region

#Region " Query Executing "

    Private Sub CIMaterialesOS_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, advObraDesde.Value, FilterType.Numeric)
        e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, advObraHasta.Value, FilterType.Numeric)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, advIDTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("Lote", FilterOperator.Equal, txtNMaquina.Text, FilterType.String)
        If cboFacturable.Value <> enumBoolean.Todos Then
            e.Filter.Add("Facturable", FilterOperator.Equal, cboFacturable.Value, FilterType.Numeric)
        End If
        e.Filter.Add("FechaEntrega", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaEntrega", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        If cboDiasMinimos.Value <> enumBoolean.Todos Then e.Filter.Add("NoFacturarDiasMinimos", FilterOperator.Equal, cboDiasMinimos.Value, FilterType.Numeric)
        If cboPlusContadores.Value <> enumBoolean.Todos Then e.Filter.Add("NoFacturarPlusContadores", FilterOperator.Equal, cboPlusContadores.Value, FilterType.Numeric)
        If cboExpedible.Value <> enumBoolean.Todos Then
            e.Filter.Add("Expedible", FilterOperator.Equal, cboExpedible.Value, FilterType.Numeric)
        End If
        e.Filter.Add("IDMaterial", FilterOperator.Equal, advIDMaterial.Text, FilterType.String)
        e.Filter.Add("Estado", FilterOperator.Equal, cboEstado.Value, FilterType.Numeric)
        e.Filter.Add("QPrev", FilterOperator.GreaterThanOrEqual, txtPrevistaDesde.Text, FilterType.Numeric)
        e.Filter.Add("QPrev", FilterOperator.LessThanOrEqual, txtPrevistaHasta.Text, FilterType.Numeric)
        e.Filter.Add("QRetornada", FilterOperator.GreaterThanOrEqual, txtRetornadaDesde.Text, FilterType.Numeric)
        e.Filter.Add("QRetornada", FilterOperator.LessThanOrEqual, txtRetornadaHasta.Text, FilterType.Numeric)
        e.Filter.Add("QServida", FilterOperator.GreaterThanOrEqual, txtEnviadaDesde.Text, FilterType.Numeric)
        e.Filter.Add("QServida", FilterOperator.LessThanOrEqual, txtEnviadaHasta.Text, FilterType.Numeric)
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)

        InitFilterCriteria()
    End Sub

#End Region

End Class
