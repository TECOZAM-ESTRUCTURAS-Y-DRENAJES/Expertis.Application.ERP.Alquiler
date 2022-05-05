Public Class CIImpresionAR
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtCantidadDesde.Value = System.DBNull.Value
        txtCantidadHasta.Value = System.DBNull.Value
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
    Friend WithEvents advContacto As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaPrevistaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaPrevistaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaPrevistaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaPrevistaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCantidadHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblCantidadHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCantidadDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblCantidadDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtAlbaranHasta As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblAlbaranHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtAlbaranDesde As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblAlbaranDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblContacto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIdCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIImpresionAR))
        Me.advContacto = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblContacto = New Solmicro.Expertis.Engine.UI.Label
        Me.advObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.advObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaPrevistaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaPrevistaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaPrevistaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaPrevistaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCantidadHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCantidadHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCantidadDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCantidadDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.txtAlbaranHasta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblAlbaranHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtAlbaranDesde = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblAlbaranDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.advIdCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
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
        Me.FilterPanel.Controls.Add(Me.lblContacto)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaPrevistaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaPrevistaDesde)
        Me.FilterPanel.Controls.Add(Me.lblCantidadHasta)
        Me.FilterPanel.Controls.Add(Me.lblAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.advContacto)
        Me.FilterPanel.Controls.Add(Me.advObraHasta)
        Me.FilterPanel.Controls.Add(Me.advObraDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaPrevistaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaPrevistaDesde)
        Me.FilterPanel.Controls.Add(Me.txtCantidadHasta)
        Me.FilterPanel.Controls.Add(Me.txtCantidadDesde)
        Me.FilterPanel.Controls.Add(Me.txtAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.txtAlbaranDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.advIdCliente)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblCantidadDesde)
        Me.FilterPanel.Controls.Add(Me.lblAlbaranDesde)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 309)
        Me.FilterPanel.Size = New System.Drawing.Size(826, 112)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(826, 309)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "AlbaranVentaLinea"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.KeyField = "IDLineaAlbaran"
        Me.Grid.Size = New System.Drawing.Size(826, 309)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vAlquilerCIAvisosRetorno"
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
        Me.Toolbar.Size = New System.Drawing.Size(297, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(826, 421)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(826, 421)
        '
        'advContacto
        '
        Me.advContacto.DisabledBackColor = System.Drawing.Color.White
        Me.advContacto.EntityName = "ObraPersonaContacto"
        Me.advContacto.Location = New System.Drawing.Point(712, 77)
        Me.advContacto.Name = "advContacto"
        Me.advContacto.SecondaryDataFields = "Nombre"
        Me.advContacto.Size = New System.Drawing.Size(101, 23)
        Me.advContacto.TabIndex = 11
        Me.advContacto.ViewName = "TbObraPersonaContacto"
        '
        'lblContacto
        '
        Me.lblContacto.Location = New System.Drawing.Point(595, 77)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(62, 13)
        Me.lblContacto.TabIndex = 0
        Me.lblContacto.Text = "Contacto "
        '
        'advObraHasta
        '
        Me.advObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advObraHasta.DisplayField = "NObra"
        Me.advObraHasta.EntityName = "ObraCabecera"
        Me.advObraHasta.Location = New System.Drawing.Point(281, 49)
        Me.advObraHasta.Name = "advObraHasta"
        Me.advObraHasta.SecondaryDataFields = "IDObra"
        Me.advObraHasta.Size = New System.Drawing.Size(101, 23)
        Me.advObraHasta.TabIndex = 3
        Me.advObraHasta.ViewName = "tbObraCabecera"
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(229, 54)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(48, 13)
        Me.lblObraHasta.TabIndex = 13
        Me.lblObraHasta.Text = "- Hasta"
        '
        'advObraDesde
        '
        Me.advObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advObraDesde.DisplayField = "NObra"
        Me.advObraDesde.EntityName = "ObraCabecera"
        Me.advObraDesde.Location = New System.Drawing.Point(125, 49)
        Me.advObraDesde.Name = "advObraDesde"
        Me.advObraDesde.SecondaryDataFields = "IDObra"
        Me.advObraDesde.Size = New System.Drawing.Size(101, 23)
        Me.advObraDesde.TabIndex = 2
        Me.advObraDesde.ViewName = "tbObraCabecera"
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(8, 54)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(90, 13)
        Me.lblObraDesde.TabIndex = 15
        Me.lblObraDesde.Text = "Alquiler Desde"
        '
        'cbxFechaPrevistaHasta
        '
        Me.cbxFechaPrevistaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaPrevistaHasta.Location = New System.Drawing.Point(712, 51)
        Me.cbxFechaPrevistaHasta.Name = "cbxFechaPrevistaHasta"
        Me.cbxFechaPrevistaHasta.Size = New System.Drawing.Size(101, 21)
        Me.cbxFechaPrevistaHasta.TabIndex = 10
        '
        'lblFechaPrevistaHasta
        '
        Me.lblFechaPrevistaHasta.Location = New System.Drawing.Point(595, 54)
        Me.lblFechaPrevistaHasta.Name = "lblFechaPrevistaHasta"
        Me.lblFechaPrevistaHasta.Size = New System.Drawing.Size(110, 13)
        Me.lblFechaPrevistaHasta.TabIndex = 17
        Me.lblFechaPrevistaHasta.Text = "Fecha Prev. Hasta"
        '
        'cbxFechaPrevistaDesde
        '
        Me.cbxFechaPrevistaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaPrevistaDesde.Location = New System.Drawing.Point(712, 26)
        Me.cbxFechaPrevistaDesde.Name = "cbxFechaPrevistaDesde"
        Me.cbxFechaPrevistaDesde.Size = New System.Drawing.Size(101, 21)
        Me.cbxFechaPrevistaDesde.TabIndex = 9
        '
        'lblFechaPrevistaDesde
        '
        Me.lblFechaPrevistaDesde.Location = New System.Drawing.Point(595, 29)
        Me.lblFechaPrevistaDesde.Name = "lblFechaPrevistaDesde"
        Me.lblFechaPrevistaDesde.Size = New System.Drawing.Size(114, 13)
        Me.lblFechaPrevistaDesde.TabIndex = 18
        Me.lblFechaPrevistaDesde.Text = "Fecha Prev. Desde"
        '
        'txtCantidadHasta
        '
        Me.txtCantidadHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtCantidadHasta.Location = New System.Drawing.Point(281, 75)
        Me.txtCantidadHasta.Name = "txtCantidadHasta"
        Me.txtCantidadHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtCantidadHasta.Size = New System.Drawing.Size(101, 21)
        Me.txtCantidadHasta.TabIndex = 5
        '
        'lblCantidadHasta
        '
        Me.lblCantidadHasta.Location = New System.Drawing.Point(229, 77)
        Me.lblCantidadHasta.Name = "lblCantidadHasta"
        Me.lblCantidadHasta.Size = New System.Drawing.Size(48, 13)
        Me.lblCantidadHasta.TabIndex = 19
        Me.lblCantidadHasta.Text = "- Hasta"
        '
        'txtCantidadDesde
        '
        Me.txtCantidadDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtCantidadDesde.Location = New System.Drawing.Point(125, 75)
        Me.txtCantidadDesde.Name = "txtCantidadDesde"
        Me.txtCantidadDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtCantidadDesde.Size = New System.Drawing.Size(101, 21)
        Me.txtCantidadDesde.TabIndex = 4
        '
        'lblCantidadDesde
        '
        Me.lblCantidadDesde.Location = New System.Drawing.Point(8, 77)
        Me.lblCantidadDesde.Name = "lblCantidadDesde"
        Me.lblCantidadDesde.Size = New System.Drawing.Size(98, 13)
        Me.lblCantidadDesde.TabIndex = 20
        Me.lblCantidadDesde.Text = "Cantidad Desde"
        '
        'txtAlbaranHasta
        '
        Me.txtAlbaranHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtAlbaranHasta.Location = New System.Drawing.Point(281, 25)
        Me.txtAlbaranHasta.Name = "txtAlbaranHasta"
        Me.txtAlbaranHasta.Size = New System.Drawing.Size(101, 21)
        Me.txtAlbaranHasta.TabIndex = 1
        '
        'lblAlbaranHasta
        '
        Me.lblAlbaranHasta.Location = New System.Drawing.Point(229, 29)
        Me.lblAlbaranHasta.Name = "lblAlbaranHasta"
        Me.lblAlbaranHasta.Size = New System.Drawing.Size(48, 13)
        Me.lblAlbaranHasta.TabIndex = 21
        Me.lblAlbaranHasta.Text = "- Hasta"
        '
        'txtAlbaranDesde
        '
        Me.txtAlbaranDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtAlbaranDesde.Location = New System.Drawing.Point(125, 25)
        Me.txtAlbaranDesde.Name = "txtAlbaranDesde"
        Me.txtAlbaranDesde.Size = New System.Drawing.Size(101, 21)
        Me.txtAlbaranDesde.TabIndex = 0
        '
        'lblAlbaranDesde
        '
        Me.lblAlbaranDesde.Location = New System.Drawing.Point(8, 29)
        Me.lblAlbaranDesde.Name = "lblAlbaranDesde"
        Me.lblAlbaranDesde.Size = New System.Drawing.Size(118, 13)
        Me.lblAlbaranDesde.TabIndex = 22
        Me.lblAlbaranDesde.Text = "Alb. Retorno Desde"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(481, 50)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(101, 21)
        Me.cbxFechaHasta.TabIndex = 7
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(395, 54)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 23
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(481, 25)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(101, 21)
        Me.cbxFechaDesde.TabIndex = 6
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(395, 29)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 24
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'advIdCliente
        '
        Me.advIdCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advIdCliente.EntityName = "Cliente"
        Me.advIdCliente.Location = New System.Drawing.Point(481, 75)
        Me.advIdCliente.Name = "advIdCliente"
        Me.advIdCliente.SecondaryDataFields = "IDCliente"
        Me.advIdCliente.Size = New System.Drawing.Size(101, 23)
        Me.advIdCliente.TabIndex = 8
        Me.advIdCliente.ViewName = "tbMaestroCliente"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(395, 76)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 25
        Me.lblCliente.Text = "Cliente"
        '
        'CIImpresionAR
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(834, 509)
        Me.EntityName = "AlbaranVentaLinea"
        Me.KeyField = "IDLineaAlbaran"
        Me.Name = "CIImpresionAR"
        Me.UseCheck = True
        Me.ViewName = "vAlquilerCIAvisosRetorno"
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

#Region " Load "

    Private Sub CIImpresionAR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGridActions()
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add(cnABRIRALQUILER, AddressOf AccionAbrirAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

#End Region

#Region " Grid Actins "

    Private Sub AccionAbrirAlquiler()
        AbrirMntoAlquiler(Grid.Value("IDObra"))
    End Sub

#End Region

#Region " QueryExecuting "

    Private Sub CIImpresionAR_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDCliente", FilterOperator.Equal, advIdCliente.Text, FilterType.String)
        e.Filter.Add("ARContactoObra", FilterOperator.Equal, advContacto.Text, FilterType.String)
        e.Filter.Add("ARNAlbaranRecogida", FilterOperator.GreaterThanOrEqual, txtAlbaranDesde.Text, FilterType.String)
        e.Filter.Add("ARNAlbaranRecogida", FilterOperator.LessThanOrEqual, txtAlbaranHasta.Text, FilterType.String)
        e.Filter.Add("ARFechaAvisoRecogida", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("ARFechaAvisoRecogida", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        e.Filter.Add("ARFechaPrevistaRetorno", FilterOperator.GreaterThanOrEqual, cbxFechaPrevistaDesde.Value, FilterType.DateTime)
        e.Filter.Add("ARFechaPrevistaRetorno", FilterOperator.LessThanOrEqual, cbxFechaPrevistaHasta.Value, FilterType.DateTime)
        e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, advObraDesde.Value, FilterType.Numeric)
        e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, advObraHasta.Value, FilterType.Numeric)
        e.Filter.Add("ARQAvisoRetorno", FilterOperator.GreaterThanOrEqual, txtCantidadDesde.Value, FilterType.Numeric)
        e.Filter.Add("ARQAvisoRetorno", FilterOperator.LessThanOrEqual, txtCantidadHasta.Value, FilterType.Numeric)
        e.Filter.Add("Aviso", FilterOperator.Equal, 1, FilterType.Numeric)
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)

        cbxFechaDesde.TextBox.Clear()
        cbxFechaHasta.TextBox.Clear()
        cbxFechaPrevistaDesde.TextBox.Clear()
        cbxFechaPrevistaHasta.TextBox.Clear()
    End Sub

#End Region

    Private Sub CIImpresionAR_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        If e.Alias = "IMPRETORNO" Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                e.DataSource = dtMarcados
            Else
                e.Cancel = True
                ExpertisApp.GenerateMessage("No hay registros que mostrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

End Class
