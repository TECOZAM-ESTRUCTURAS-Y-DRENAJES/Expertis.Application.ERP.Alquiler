Public Class CIHistMaquinas
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
    Friend WithEvents advIDOServicio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblOServicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDActivo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblActivo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxTipoFactAlquiler As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblTipoFactAlquiler As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCentroGestion As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCentroGestion As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoFactAlquiler_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIHistMaquinas))
        Me.advIDOServicio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblOServicio = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDActivo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblActivo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoFactAlquiler = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTipoFactAlquiler = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCentroGestion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxTipoFactAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblOServicio)
        Me.FilterPanel.Controls.Add(Me.advIDOServicio)
        Me.FilterPanel.Controls.Add(Me.lblArticulo)
        Me.FilterPanel.Controls.Add(Me.advIDArticulo)
        Me.FilterPanel.Controls.Add(Me.lblActivo)
        Me.FilterPanel.Controls.Add(Me.advIDActivo)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.advIDObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.advIDCliente)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Controls.Add(Me.advIDObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblTipoFactAlquiler)
        Me.FilterPanel.Controls.Add(Me.cbxTipoFactAlquiler)
        Me.FilterPanel.Controls.Add(Me.lblCentroGestion)
        Me.FilterPanel.Controls.Add(Me.advIDCentroGestion)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 226)
        Me.FilterPanel.Size = New System.Drawing.Size(677, 115)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(677, 226)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Activo"
        Me.Grid.Size = New System.Drawing.Size(677, 226)
        Me.Grid.TabIndex = 8
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vAlquilerCIHistoricoMaquinas"
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
        Me.MainPanel.Size = New System.Drawing.Size(677, 341)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(677, 341)
        '
        'advIDOServicio
        '
        Me.advIDOServicio.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOServicio.DisplayField = "CodTrabajo"
        Me.advIDOServicio.EntityName = "ObraTrabajo"
        Me.advIDOServicio.Location = New System.Drawing.Point(106, 79)
        Me.advIDOServicio.Name = "advIDOServicio"
        Me.advIDOServicio.SecondaryDataFields = "IDTrabajo"
        Me.advIDOServicio.Size = New System.Drawing.Size(105, 23)
        Me.advIDOServicio.TabIndex = 2
        Me.advIDOServicio.ViewName = "tbObraTrabajo"
        '
        'lblOServicio
        '
        Me.lblOServicio.Location = New System.Drawing.Point(12, 84)
        Me.lblOServicio.Name = "lblOServicio"
        Me.lblOServicio.Size = New System.Drawing.Size(70, 13)
        Me.lblOServicio.TabIndex = 0
        Me.lblOServicio.Text = "O. Servicio"
        '
        'advIDArticulo
        '
        Me.advIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticulo.EntityName = "Articulo"
        Me.advIDArticulo.Location = New System.Drawing.Point(306, 79)
        Me.advIDArticulo.Name = "advIDArticulo"
        Me.advIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.advIDArticulo.Size = New System.Drawing.Size(105, 23)
        Me.advIDArticulo.TabIndex = 5
        Me.advIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(242, 84)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 10
        Me.lblArticulo.Text = "Artículo"
        '
        'advIDActivo
        '
        Me.advIDActivo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDActivo.EntityName = "Activo"
        Me.advIDActivo.Location = New System.Drawing.Point(306, 53)
        Me.advIDActivo.Name = "advIDActivo"
        Me.advIDActivo.SecondaryDataFields = "IDActivo"
        Me.advIDActivo.Size = New System.Drawing.Size(105, 23)
        Me.advIDActivo.TabIndex = 4
        Me.advIDActivo.ViewName = "tbMaestroActivo"
        '
        'lblActivo
        '
        Me.lblActivo.Location = New System.Drawing.Point(242, 58)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(42, 13)
        Me.lblActivo.TabIndex = 12
        Me.lblActivo.Text = "Activo"
        '
        'advIDObraDesde
        '
        Me.advIDObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advIDObraDesde.DisplayField = "NObra"
        Me.advIDObraDesde.EntityName = "ObraCabecera"
        Me.advIDObraDesde.Location = New System.Drawing.Point(106, 27)
        Me.advIDObraDesde.Name = "advIDObraDesde"
        Me.advIDObraDesde.SecondaryDataFields = "IDObra"
        Me.advIDObraDesde.Size = New System.Drawing.Size(105, 23)
        Me.advIDObraDesde.TabIndex = 0
        Me.advIDObraDesde.ViewName = "tbObraCabecera"
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(12, 31)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(90, 13)
        Me.lblObraDesde.TabIndex = 14
        Me.lblObraDesde.Text = "Alquiler Desde"
        '
        'advIDCliente
        '
        Me.advIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCliente.EntityName = "Cliente"
        Me.advIDCliente.Location = New System.Drawing.Point(306, 27)
        Me.advIDCliente.Name = "advIDCliente"
        Me.advIDCliente.SecondaryDataFields = "IDCliente"
        Me.advIDCliente.Size = New System.Drawing.Size(105, 23)
        Me.advIDCliente.TabIndex = 3
        Me.advIDCliente.ViewName = "tbMaestroCliente"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(242, 32)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 16
        Me.lblCliente.Text = "Cliente"
        '
        'advIDObraHasta
        '
        Me.advIDObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advIDObraHasta.DisplayField = "NObra"
        Me.advIDObraHasta.EntityName = "ObraCabecera"
        Me.advIDObraHasta.Location = New System.Drawing.Point(106, 53)
        Me.advIDObraHasta.Name = "advIDObraHasta"
        Me.advIDObraHasta.SecondaryDataFields = "IDObra"
        Me.advIDObraHasta.Size = New System.Drawing.Size(105, 23)
        Me.advIDObraHasta.TabIndex = 1
        Me.advIDObraHasta.ViewName = "tbObraCabecera"
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(12, 58)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(86, 13)
        Me.lblObraHasta.TabIndex = 18
        Me.lblObraHasta.Text = "Alquiler Hasta"
        '
        'cbxTipoFactAlquiler
        '
        cbxTipoFactAlquiler_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoFactAlquiler_DesignTimeLayout.LayoutString")
        Me.cbxTipoFactAlquiler.DesignTimeLayout = cbxTipoFactAlquiler_DesignTimeLayout
        Me.cbxTipoFactAlquiler.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoFactAlquiler.Location = New System.Drawing.Point(556, 28)
        Me.cbxTipoFactAlquiler.Name = "cbxTipoFactAlquiler"
        Me.cbxTipoFactAlquiler.SelectedIndex = -1
        Me.cbxTipoFactAlquiler.SelectedItem = Nothing
        Me.cbxTipoFactAlquiler.Size = New System.Drawing.Size(105, 21)
        Me.cbxTipoFactAlquiler.TabIndex = 6
        '
        'lblTipoFactAlquiler
        '
        Me.lblTipoFactAlquiler.Location = New System.Drawing.Point(445, 32)
        Me.lblTipoFactAlquiler.Name = "lblTipoFactAlquiler"
        Me.lblTipoFactAlquiler.Size = New System.Drawing.Size(109, 13)
        Me.lblTipoFactAlquiler.TabIndex = 20
        Me.lblTipoFactAlquiler.Text = "Tipo Fact. Alquiler"
        '
        'advIDCentroGestion
        '
        Me.advIDCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCentroGestion.EntityName = "CentroGestion"
        Me.advIDCentroGestion.Location = New System.Drawing.Point(556, 53)
        Me.advIDCentroGestion.Name = "advIDCentroGestion"
        Me.advIDCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.advIDCentroGestion.Size = New System.Drawing.Size(105, 23)
        Me.advIDCentroGestion.TabIndex = 7
        Me.advIDCentroGestion.ViewName = "tbMaestroCentroGestion"
        '
        'lblCentroGestion
        '
        Me.lblCentroGestion.Location = New System.Drawing.Point(445, 58)
        Me.lblCentroGestion.Name = "lblCentroGestion"
        Me.lblCentroGestion.Size = New System.Drawing.Size(93, 13)
        Me.lblCentroGestion.TabIndex = 21
        Me.lblCentroGestion.Text = "Centro Gestión"
        '
        'CIHistMaquinas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(685, 429)
        Me.EntityName = "Activo"
        Me.Name = "CIHistMaquinas"
        Me.ShowIcon = False
        Me.ViewName = "vAlquilerCIHistoricoMaquinas"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxTipoFactAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CIHistMaquinas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnum()
        LoadGridActions()
    End Sub

    Private Sub LoadEnum()
        cbxTipoFactAlquiler.DataSource = New EnumData("enumTipoFacturacionAlquiler")
        EnumData.PopulateValueList("enumomATipoFacturacionAlquiler", Grid.Columns("TipoFacturacion"))
        EnumData.PopulateValueList("enumTipoFacturacionAlquiler", Grid.Columns("TipoFactAlquiler"))
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add(cnABRRIRACTIVO, AddressOf AccionAbrirArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
        Grid.Actions.Add(cnABRRIRACTIVO, AddressOf AccionAbrirActivo, ExpertisApp.GetIcon("xActivos.ico"))
        Grid.Actions.Add(cnABRIRALBARANVENTA, AddressOf AccionAbrirAlbaranVenta, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
        Grid.Actions.Add(cnABRIRALQUILER, AddressOf AccionAbrirAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirArticulo()
        If Length(Grid.Value("IDArticulo")) > 0 Then AbrirMntoArticulo(Grid.Value("IDArticulo"))
    End Sub

    Private Sub AccionAbrirActivo()
        If Length(Grid.Value("IDActivo")) > 0 Then AbrirMntoAbrirActivo(Grid.Value("IDActivo"))
    End Sub

    Private Sub AccionAbrirAlbaranVenta()
        AbrirMntoAlbaranVenta(Grid.Value("IDAlbaran"))
    End Sub

    Private Sub AccionAbrirAlquiler()
        AbrirMntoAlquiler(Grid.Value("IDObra"))
    End Sub

#End Region

#Region " QueryExecute "

    Private Sub CIHistMaquinas_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If Length(advIDObraDesde.Value) = 0 And Length(advIDObraHasta.Value) = 0 And Length(advIDCliente.Value) = 0 And Length(advIDCentroGestion.Value) = 0 And Length(advIDActivo.Value) = 0 And Length(advIDArticulo.Value) = 0 Then
            'Cuando no hay ningún filtro metido, mostrar un mensaje indicando si quieres continuar
            'con el filtrado de todo el histórico de maquinaria.
            If ExpertisApp.GenerateMessage("Se va a lanzar la consulta interactiva sin aplicar ningún filtro. Esto puede que retarde la obtención de información. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then ' Poner mensaje de filtrado sin filtros
                e.Cancel = True
            End If
        Else
            e.Cancel = ValidarFiltros()
        End If

        If Not e.Cancel Then
            e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, advIDObraDesde.Value, FilterType.Numeric)
            e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, advIDObraHasta.Value, FilterType.Numeric)
            e.Filter.Add("IDCliente", FilterOperator.Equal, advIDCliente.Text, FilterType.String)
            e.Filter.Add("IDTrabajo", FilterOperator.Equal, advIDOServicio.Value, FilterType.Numeric)
            e.Filter.Add("IDCentroGestion", FilterOperator.Equal, advIDCentroGestion.Text, FilterType.String)
            e.Filter.Add("TipoFactAlquiler", FilterOperator.Equal, cbxTipoFactAlquiler.Value, FilterType.String)
            e.Filter.Add("IDActivo", FilterOperator.Equal, advIDActivo.Text, FilterType.String)
            e.Filter.Add("IDArticulo", FilterOperator.Equal, advIDArticulo.Text, FilterType.String)
        End If
    End Sub

    Private Function ValidarFiltros() As Boolean
        Dim strFiltrosCampos As String = String.Empty

        If (Length(advIDObraDesde.Value) > 0 And Length(advIDObraHasta.Value) = 0) Or (Length(advIDObraDesde.Value) = 0 And Length(advIDObraHasta.Value) > 0) Then
            strFiltrosCampos = strFiltrosCampos & "Alquiler"
            ValidarFiltros = True
            ExpertisApp.GenerateMessage("Para usar los filtros de | tienen que rellenarse tanto el Desde como el Hasta.", MessageBoxButtons.OK, MessageBoxIcon.Information, strFiltrosCampos)
        End If

    End Function

#End Region

    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(Grid) AndAlso Grid.RowCount > 0 Then
                Grid.UiCommandManager1.Commands(cnABRRIRACTIVO).Visible = Janus.Windows.UI.InheritableBoolean.False
                Grid.UiCommandManager1.Commands(cnABRIRALQUILER).Visible = Janus.Windows.UI.InheritableBoolean.False
                If Length(Grid.Value("IDActivo")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRRIRACTIVO).Visible = Janus.Windows.UI.InheritableBoolean.True
                End If
                If Length(Grid.Value("IDObra")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIRALQUILER).Visible = Janus.Windows.UI.InheritableBoolean.True
                End If
            End If
        End If
    End Sub

End Class
