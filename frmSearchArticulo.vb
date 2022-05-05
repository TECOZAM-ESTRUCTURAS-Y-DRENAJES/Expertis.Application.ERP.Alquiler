Public Class frmSearchArticulo
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
    Friend WithEvents pnlLeft As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents pnlCaracteristicas As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents SplitterRight As System.Windows.Forms.Splitter
    Friend WithEvents pnlRight As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents gridFamiliaCaract As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlTop As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlCaracteristicasNSerie As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblCareacteristicasNserie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Splitter3 As System.Windows.Forms.Splitter
    Friend WithEvents Splitter4 As System.Windows.Forms.Splitter
    Friend WithEvents pnlActivos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlLabelActivos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblActivos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlGridCaractersticasNSerie As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlLabelCaractersticasNSerie As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ToolbarCmdFiltrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCmdSeparador As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCmbRefresh As System.Windows.Forms.ToolBarButton
    Friend WithEvents gridActivos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmdDelFilterCaracteristica As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuExplosionArbol As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImplosionArbol As System.Windows.Forms.MenuItem
    Friend WithEvents pnlArbol As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents TvwTipoFamilia As System.Windows.Forms.TreeView
    Friend WithEvents cmdDelFilterNSerieCaract As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents gridNSerieCaract As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlFilterArticulo As System.Windows.Forms.Panel
    Friend WithEvents lblWhereArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlFiltro As System.Windows.Forms.Panel
    Friend WithEvents cmdFilter As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents pnlArticulos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlArticulosalternativos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlGridArticulosAlternativos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmdDelFilterArtAlt As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents gridArticulosAlt As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlLabelArticulosAlternativos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblArticulosAlternativos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents pnlLabelArticulos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblArticulos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlGridArticulos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents gridArticulos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmdDelFilterArt As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchArticulo))
        Dim gridFamiliaCaract_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridArticulos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridArticulosAlt_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridActivos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridNSerieCaract_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridNSerieCaract_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage")
        Dim gridNSerieCaract_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Me.pnlLeft = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlArbol = New Solmicro.Expertis.Engine.UI.Panel
        Me.TvwTipoFamilia = New System.Windows.Forms.TreeView
        Me.SplitterRight = New System.Windows.Forms.Splitter
        Me.pnlCaracteristicas = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdDelFilterCaracteristica = New Solmicro.Expertis.Engine.UI.Button
        Me.gridFamiliaCaract = New Solmicro.Expertis.Engine.UI.Grid
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolbarCmdFiltrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCmdSeparador = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCmbRefresh = New System.Windows.Forms.ToolBarButton
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuExplosionArbol = New System.Windows.Forms.MenuItem
        Me.mnuImplosionArbol = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.pnlRight = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlArticulos = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlGridArticulos = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdDelFilterArt = New Solmicro.Expertis.Engine.UI.Button
        Me.gridArticulos = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlLabelArticulos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblArticulos = New Solmicro.Expertis.Engine.UI.Label
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.pnlArticulosalternativos = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlGridArticulosAlternativos = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdDelFilterArtAlt = New Solmicro.Expertis.Engine.UI.Button
        Me.gridArticulosAlt = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlLabelArticulosAlternativos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblArticulosAlternativos = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlFilterArticulo = New System.Windows.Forms.Panel
        Me.lblWhereArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlFiltro = New System.Windows.Forms.Panel
        Me.cmdFilter = New Solmicro.Expertis.Engine.UI.Button
        Me.Splitter3 = New System.Windows.Forms.Splitter
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlActivos = New Solmicro.Expertis.Engine.UI.Panel
        Me.gridActivos = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlLabelActivos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblActivos = New Solmicro.Expertis.Engine.UI.Label
        Me.Splitter4 = New System.Windows.Forms.Splitter
        Me.pnlCaracteristicasNSerie = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlGridCaractersticasNSerie = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdDelFilterNSerieCaract = New Solmicro.Expertis.Engine.UI.Button
        Me.gridNSerieCaract = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlLabelCaractersticasNSerie = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblCareacteristicasNserie = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlLeft.suspendlayout()
        Me.pnlArbol.suspendlayout()
        Me.pnlCaracteristicas.suspendlayout()
        CType(Me.gridFamiliaCaract, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRight.suspendlayout()
        Me.pnlTop.suspendlayout()
        Me.pnlArticulos.suspendlayout()
        Me.pnlGridArticulos.suspendlayout()
        CType(Me.gridArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLabelArticulos.suspendlayout()
        Me.pnlArticulosalternativos.suspendlayout()
        Me.pnlGridArticulosAlternativos.suspendlayout()
        CType(Me.gridArticulosAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLabelArticulosAlternativos.suspendlayout()
        Me.pnlFilterArticulo.SuspendLayout()
        Me.pnlFiltro.SuspendLayout()
        Me.pnlBottom.suspendlayout()
        Me.pnlActivos.suspendlayout()
        CType(Me.gridActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLabelActivos.suspendlayout()
        Me.pnlCaracteristicasNSerie.suspendlayout()
        Me.pnlGridCaractersticasNSerie.suspendlayout()
        CType(Me.gridNSerieCaract, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLabelCaractersticasNSerie.suspendlayout()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.pnlArbol)
        Me.pnlLeft.Controls.Add(Me.SplitterRight)
        Me.pnlLeft.Controls.Add(Me.pnlCaracteristicas)
        Me.pnlLeft.Controls.Add(Me.ToolBar1)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(247, 550)
        Me.pnlLeft.TabIndex = 0
        '
        'pnlArbol
        '
        Me.pnlArbol.Controls.Add(Me.TvwTipoFamilia)
        Me.pnlArbol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlArbol.Location = New System.Drawing.Point(0, 28)
        Me.pnlArbol.Name = "pnlArbol"
        Me.pnlArbol.Size = New System.Drawing.Size(247, 357)
        Me.pnlArbol.TabIndex = 4
        '
        'TvwTipoFamilia
        '
        Me.TvwTipoFamilia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TvwTipoFamilia.Location = New System.Drawing.Point(0, 0)
        Me.TvwTipoFamilia.Name = "TvwTipoFamilia"
        Me.TvwTipoFamilia.Size = New System.Drawing.Size(247, 357)
        Me.TvwTipoFamilia.TabIndex = 46
        '
        'SplitterRight
        '
        Me.SplitterRight.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitterRight.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitterRight.Location = New System.Drawing.Point(0, 385)
        Me.SplitterRight.Name = "SplitterRight"
        Me.SplitterRight.Size = New System.Drawing.Size(247, 5)
        Me.SplitterRight.TabIndex = 3
        Me.SplitterRight.TabStop = False
        '
        'pnlCaracteristicas
        '
        Me.pnlCaracteristicas.Controls.Add(Me.cmdDelFilterCaracteristica)
        Me.pnlCaracteristicas.Controls.Add(Me.gridFamiliaCaract)
        Me.pnlCaracteristicas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlCaracteristicas.Location = New System.Drawing.Point(0, 390)
        Me.pnlCaracteristicas.Name = "pnlCaracteristicas"
        Me.pnlCaracteristicas.Size = New System.Drawing.Size(247, 160)
        Me.pnlCaracteristicas.TabIndex = 2
        '
        'cmdDelFilterCaracteristica
        '
        Me.cmdDelFilterCaracteristica.Image = CType(resources.GetObject("cmdDelFilterCaracteristica.Image"), System.Drawing.Image)
        Me.cmdDelFilterCaracteristica.Location = New System.Drawing.Point(0, 0)
        Me.cmdDelFilterCaracteristica.Name = "cmdDelFilterCaracteristica"
        Me.cmdDelFilterCaracteristica.Size = New System.Drawing.Size(19, 22)
        Me.cmdDelFilterCaracteristica.TabIndex = 55
        '
        'gridFamiliaCaract
        '
        Me.gridFamiliaCaract.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("Valor", "CaracteristicaValor", "IdValor")})
        Me.gridFamiliaCaract.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridFamiliaCaract_DesignTimeLayout.LayoutString = resources.GetString("gridFamiliaCaract_DesignTimeLayout.LayoutString")
        Me.gridFamiliaCaract.DesignTimeLayout = gridFamiliaCaract_DesignTimeLayout
        Me.gridFamiliaCaract.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridFamiliaCaract.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.gridFamiliaCaract.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.gridFamiliaCaract.EntityName = ""
        Me.gridFamiliaCaract.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.gridFamiliaCaract.Location = New System.Drawing.Point(0, 0)
        Me.gridFamiliaCaract.Name = "gridFamiliaCaract"
        Me.gridFamiliaCaract.PrimaryDataFields = ""
        Me.gridFamiliaCaract.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.gridFamiliaCaract.RequeryManually = True
        Me.gridFamiliaCaract.SecondaryDataFields = ""
        Me.gridFamiliaCaract.Size = New System.Drawing.Size(247, 160)
        Me.gridFamiliaCaract.TabIndex = 47
        Me.gridFamiliaCaract.ViewName = "vFrmSearchFamiliaCaracteristica"
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolbarCmdFiltrar, Me.ToolBarCmdSeparador, Me.ToolBarCmbRefresh})
        Me.ToolBar1.ContextMenu = Me.ContextMenu1
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(247, 28)
        Me.ToolBar1.TabIndex = 0
        '
        'ToolbarCmdFiltrar
        '
        Me.ToolbarCmdFiltrar.ImageIndex = 0
        Me.ToolbarCmdFiltrar.Name = "ToolbarCmdFiltrar"
        '
        'ToolBarCmdSeparador
        '
        Me.ToolBarCmdSeparador.Name = "ToolBarCmdSeparador"
        Me.ToolBarCmdSeparador.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarCmbRefresh
        '
        Me.ToolBarCmbRefresh.DropDownMenu = Me.ContextMenu1
        Me.ToolBarCmbRefresh.ImageIndex = 1
        Me.ToolBarCmbRefresh.Name = "ToolBarCmbRefresh"
        Me.ToolBarCmbRefresh.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExplosionArbol, Me.mnuImplosionArbol})
        '
        'mnuExplosionArbol
        '
        Me.mnuExplosionArbol.Index = 0
        Me.mnuExplosionArbol.Text = "Explosión árbol"
        '
        'mnuImplosionArbol
        '
        Me.mnuImplosionArbol.Index = 1
        Me.mnuImplosionArbol.Text = "Implosión árbol"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(247, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 550)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'pnlRight
        '
        Me.pnlRight.Controls.Add(Me.pnlTop)
        Me.pnlRight.Controls.Add(Me.Splitter3)
        Me.pnlRight.Controls.Add(Me.pnlBottom)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(252, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(574, 550)
        Me.pnlRight.TabIndex = 4
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.pnlArticulos)
        Me.pnlTop.Controls.Add(Me.pnlFilterArticulo)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(574, 361)
        Me.pnlTop.TabIndex = 5
        '
        'pnlArticulos
        '
        Me.pnlArticulos.Controls.Add(Me.pnlGridArticulos)
        Me.pnlArticulos.Controls.Add(Me.pnlLabelArticulos)
        Me.pnlArticulos.Controls.Add(Me.Splitter2)
        Me.pnlArticulos.Controls.Add(Me.pnlArticulosalternativos)
        Me.pnlArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlArticulos.Location = New System.Drawing.Point(0, 0)
        Me.pnlArticulos.Name = "pnlArticulos"
        Me.pnlArticulos.Size = New System.Drawing.Size(574, 332)
        Me.pnlArticulos.TabIndex = 8
        '
        'pnlGridArticulos
        '
        Me.pnlGridArticulos.Controls.Add(Me.cmdDelFilterArt)
        Me.pnlGridArticulos.Controls.Add(Me.gridArticulos)
        Me.pnlGridArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGridArticulos.Location = New System.Drawing.Point(0, 25)
        Me.pnlGridArticulos.Name = "pnlGridArticulos"
        Me.pnlGridArticulos.Size = New System.Drawing.Size(284, 307)
        Me.pnlGridArticulos.TabIndex = 57
        '
        'cmdDelFilterArt
        '
        Me.cmdDelFilterArt.Image = CType(resources.GetObject("cmdDelFilterArt.Image"), System.Drawing.Image)
        Me.cmdDelFilterArt.Location = New System.Drawing.Point(0, 0)
        Me.cmdDelFilterArt.Name = "cmdDelFilterArt"
        Me.cmdDelFilterArt.Size = New System.Drawing.Size(19, 22)
        Me.cmdDelFilterArt.TabIndex = 56
        '
        'gridArticulos
        '
        Me.gridArticulos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridArticulos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridArticulos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridArticulos_DesignTimeLayout.LayoutString = resources.GetString("gridArticulos_DesignTimeLayout.LayoutString")
        Me.gridArticulos.DesignTimeLayout = gridArticulos_DesignTimeLayout
        Me.gridArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridArticulos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.gridArticulos.EntityName = ""
        Me.gridArticulos.Location = New System.Drawing.Point(0, 0)
        Me.gridArticulos.Name = "gridArticulos"
        Me.gridArticulos.PrimaryDataFields = ""
        Me.gridArticulos.SecondaryDataFields = ""
        Me.gridArticulos.Size = New System.Drawing.Size(284, 307)
        Me.gridArticulos.TabIndex = 55
        Me.gridArticulos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.gridArticulos.ViewName = "vFrmSearchArticulos"
        '
        'pnlLabelArticulos
        '
        Me.pnlLabelArticulos.Controls.Add(Me.lblArticulos)
        Me.pnlLabelArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabelArticulos.Location = New System.Drawing.Point(0, 0)
        Me.pnlLabelArticulos.Name = "pnlLabelArticulos"
        Me.pnlLabelArticulos.Size = New System.Drawing.Size(284, 25)
        Me.pnlLabelArticulos.TabIndex = 56
        '
        'lblArticulos
        '
        Me.lblArticulos.Location = New System.Drawing.Point(3, 5)
        Me.lblArticulos.Name = "lblArticulos"
        Me.lblArticulos.Size = New System.Drawing.Size(56, 13)
        Me.lblArticulos.TabIndex = 0
        Me.lblArticulos.Text = "Articulos"
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter2.Location = New System.Drawing.Point(284, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(5, 332)
        Me.Splitter2.TabIndex = 55
        Me.Splitter2.TabStop = False
        '
        'pnlArticulosalternativos
        '
        Me.pnlArticulosalternativos.Controls.Add(Me.pnlGridArticulosAlternativos)
        Me.pnlArticulosalternativos.Controls.Add(Me.pnlLabelArticulosAlternativos)
        Me.pnlArticulosalternativos.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlArticulosalternativos.Location = New System.Drawing.Point(289, 0)
        Me.pnlArticulosalternativos.Name = "pnlArticulosalternativos"
        Me.pnlArticulosalternativos.Size = New System.Drawing.Size(285, 332)
        Me.pnlArticulosalternativos.TabIndex = 54
        '
        'pnlGridArticulosAlternativos
        '
        Me.pnlGridArticulosAlternativos.Controls.Add(Me.cmdDelFilterArtAlt)
        Me.pnlGridArticulosAlternativos.Controls.Add(Me.gridArticulosAlt)
        Me.pnlGridArticulosAlternativos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGridArticulosAlternativos.Location = New System.Drawing.Point(0, 25)
        Me.pnlGridArticulosAlternativos.Name = "pnlGridArticulosAlternativos"
        Me.pnlGridArticulosAlternativos.Size = New System.Drawing.Size(285, 307)
        Me.pnlGridArticulosAlternativos.TabIndex = 54
        '
        'cmdDelFilterArtAlt
        '
        Me.cmdDelFilterArtAlt.Image = CType(resources.GetObject("cmdDelFilterArtAlt.Image"), System.Drawing.Image)
        Me.cmdDelFilterArtAlt.Location = New System.Drawing.Point(0, 0)
        Me.cmdDelFilterArtAlt.Name = "cmdDelFilterArtAlt"
        Me.cmdDelFilterArtAlt.Size = New System.Drawing.Size(19, 22)
        Me.cmdDelFilterArtAlt.TabIndex = 55
        '
        'gridArticulosAlt
        '
        Me.gridArticulosAlt.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridArticulosAlt.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridArticulosAlt_DesignTimeLayout.LayoutString = resources.GetString("gridArticulosAlt_DesignTimeLayout.LayoutString")
        Me.gridArticulosAlt.DesignTimeLayout = gridArticulosAlt_DesignTimeLayout
        Me.gridArticulosAlt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridArticulosAlt.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.gridArticulosAlt.EntityName = "ArticuloAlternativo"
        Me.gridArticulosAlt.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.gridArticulosAlt.Location = New System.Drawing.Point(0, 0)
        Me.gridArticulosAlt.Name = "gridArticulosAlt"
        Me.gridArticulosAlt.PrimaryDataFields = "IDArticuloAlternativo"
        Me.gridArticulosAlt.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.gridArticulosAlt.RequeryManually = True
        Me.gridArticulosAlt.SecondaryDataFields = "IDArticuloAlternativo"
        Me.gridArticulosAlt.Size = New System.Drawing.Size(285, 307)
        Me.gridArticulosAlt.TabIndex = 54
        Me.gridArticulosAlt.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.gridArticulosAlt.ViewName = "vFrmSearchArticuloAlternativo"
        '
        'pnlLabelArticulosAlternativos
        '
        Me.pnlLabelArticulosAlternativos.Controls.Add(Me.lblArticulosAlternativos)
        Me.pnlLabelArticulosAlternativos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabelArticulosAlternativos.Location = New System.Drawing.Point(0, 0)
        Me.pnlLabelArticulosAlternativos.Name = "pnlLabelArticulosAlternativos"
        Me.pnlLabelArticulosAlternativos.Size = New System.Drawing.Size(285, 25)
        Me.pnlLabelArticulosAlternativos.TabIndex = 1
        '
        'lblArticulosAlternativos
        '
        Me.lblArticulosAlternativos.Location = New System.Drawing.Point(3, 5)
        Me.lblArticulosAlternativos.Name = "lblArticulosAlternativos"
        Me.lblArticulosAlternativos.Size = New System.Drawing.Size(127, 13)
        Me.lblArticulosAlternativos.TabIndex = 0
        Me.lblArticulosAlternativos.Text = "Articulos alternativos"
        '
        'pnlFilterArticulo
        '
        Me.pnlFilterArticulo.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.pnlFilterArticulo.Controls.Add(Me.lblWhereArticulo)
        Me.pnlFilterArticulo.Controls.Add(Me.pnlFiltro)
        Me.pnlFilterArticulo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFilterArticulo.Location = New System.Drawing.Point(0, 332)
        Me.pnlFilterArticulo.Name = "pnlFilterArticulo"
        Me.pnlFilterArticulo.Size = New System.Drawing.Size(574, 29)
        Me.pnlFilterArticulo.TabIndex = 7
        '
        'lblWhereArticulo
        '
        Me.lblWhereArticulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWhereArticulo.Location = New System.Drawing.Point(32, 0)
        Me.lblWhereArticulo.Name = "lblWhereArticulo"
        Me.lblWhereArticulo.Size = New System.Drawing.Size(0, 13)
        Me.lblWhereArticulo.TabIndex = 59
        Me.lblWhereArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlFiltro
        '
        Me.pnlFiltro.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.pnlFiltro.Controls.Add(Me.cmdFilter)
        Me.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFiltro.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltro.Name = "pnlFiltro"
        Me.pnlFiltro.Size = New System.Drawing.Size(32, 29)
        Me.pnlFiltro.TabIndex = 3
        '
        'cmdFilter
        '
        Me.cmdFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdFilter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFilter.Image = CType(resources.GetObject("cmdFilter.Image"), System.Drawing.Image)
        Me.cmdFilter.Location = New System.Drawing.Point(4, 4)
        Me.cmdFilter.Name = "cmdFilter"
        Me.cmdFilter.Size = New System.Drawing.Size(22, 22)
        Me.cmdFilter.TabIndex = 59
        '
        'Splitter3
        '
        Me.Splitter3.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.Splitter3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter3.Location = New System.Drawing.Point(0, 361)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(574, 5)
        Me.Splitter3.TabIndex = 4
        Me.Splitter3.TabStop = False
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.pnlActivos)
        Me.pnlBottom.Controls.Add(Me.Splitter4)
        Me.pnlBottom.Controls.Add(Me.pnlCaracteristicasNSerie)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 366)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(574, 184)
        Me.pnlBottom.TabIndex = 1
        '
        'pnlActivos
        '
        Me.pnlActivos.Controls.Add(Me.gridActivos)
        Me.pnlActivos.Controls.Add(Me.pnlLabelActivos)
        Me.pnlActivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlActivos.Location = New System.Drawing.Point(0, 0)
        Me.pnlActivos.Name = "pnlActivos"
        Me.pnlActivos.Size = New System.Drawing.Size(281, 184)
        Me.pnlActivos.TabIndex = 8
        '
        'gridActivos
        '
        Me.gridActivos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridActivos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridActivos_DesignTimeLayout.LayoutString = resources.GetString("gridActivos_DesignTimeLayout.LayoutString")
        Me.gridActivos.DesignTimeLayout = gridActivos_DesignTimeLayout
        Me.gridActivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridActivos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.gridActivos.EntityName = "Activo"
        Me.gridActivos.Location = New System.Drawing.Point(0, 25)
        Me.gridActivos.Name = "gridActivos"
        Me.gridActivos.PrimaryDataFields = "IDActivo"
        Me.gridActivos.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.gridActivos.RequeryManually = True
        Me.gridActivos.SecondaryDataFields = "IDActivo"
        Me.gridActivos.Size = New System.Drawing.Size(281, 159)
        Me.gridActivos.TabIndex = 57
        Me.gridActivos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.gridActivos.ViewName = "vfrmSearchArticuloActivos"
        '
        'pnlLabelActivos
        '
        Me.pnlLabelActivos.Controls.Add(Me.lblActivos)
        Me.pnlLabelActivos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabelActivos.Location = New System.Drawing.Point(0, 0)
        Me.pnlLabelActivos.Name = "pnlLabelActivos"
        Me.pnlLabelActivos.Size = New System.Drawing.Size(281, 25)
        Me.pnlLabelActivos.TabIndex = 8
        '
        'lblActivos
        '
        Me.lblActivos.Location = New System.Drawing.Point(3, 5)
        Me.lblActivos.Name = "lblActivos"
        Me.lblActivos.Size = New System.Drawing.Size(48, 13)
        Me.lblActivos.TabIndex = 0
        Me.lblActivos.Text = "Activos"
        '
        'Splitter4
        '
        Me.Splitter4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter4.Location = New System.Drawing.Point(281, 0)
        Me.Splitter4.Name = "Splitter4"
        Me.Splitter4.Size = New System.Drawing.Size(5, 184)
        Me.Splitter4.TabIndex = 6
        Me.Splitter4.TabStop = False
        '
        'pnlCaracteristicasNSerie
        '
        Me.pnlCaracteristicasNSerie.Controls.Add(Me.pnlGridCaractersticasNSerie)
        Me.pnlCaracteristicasNSerie.Controls.Add(Me.pnlLabelCaractersticasNSerie)
        Me.pnlCaracteristicasNSerie.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlCaracteristicasNSerie.Location = New System.Drawing.Point(286, 0)
        Me.pnlCaracteristicasNSerie.Name = "pnlCaracteristicasNSerie"
        Me.pnlCaracteristicasNSerie.Size = New System.Drawing.Size(288, 184)
        Me.pnlCaracteristicasNSerie.TabIndex = 0
        '
        'pnlGridCaractersticasNSerie
        '
        Me.pnlGridCaractersticasNSerie.Controls.Add(Me.cmdDelFilterNSerieCaract)
        Me.pnlGridCaractersticasNSerie.Controls.Add(Me.gridNSerieCaract)
        Me.pnlGridCaractersticasNSerie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGridCaractersticasNSerie.Location = New System.Drawing.Point(0, 25)
        Me.pnlGridCaractersticasNSerie.Name = "pnlGridCaractersticasNSerie"
        Me.pnlGridCaractersticasNSerie.Size = New System.Drawing.Size(288, 159)
        Me.pnlGridCaractersticasNSerie.TabIndex = 3
        '
        'cmdDelFilterNSerieCaract
        '
        Me.cmdDelFilterNSerieCaract.Image = CType(resources.GetObject("cmdDelFilterNSerieCaract.Image"), System.Drawing.Image)
        Me.cmdDelFilterNSerieCaract.Location = New System.Drawing.Point(0, 0)
        Me.cmdDelFilterNSerieCaract.Name = "cmdDelFilterNSerieCaract"
        Me.cmdDelFilterNSerieCaract.Size = New System.Drawing.Size(19, 22)
        Me.cmdDelFilterNSerieCaract.TabIndex = 64
        '
        'gridNSerieCaract
        '
        Me.gridNSerieCaract.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("Valor", "CaracteristicaValor", "IdValor", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IdValor", "Valor")}), "")})
        Me.gridNSerieCaract.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridNSerieCaract_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("gridNSerieCaract_DesignTimeLayout_Reference_0.Instance"), Object)
        gridNSerieCaract_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("gridNSerieCaract_DesignTimeLayout_Reference_1.Instance"), Object)
        gridNSerieCaract_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {gridNSerieCaract_DesignTimeLayout_Reference_0, gridNSerieCaract_DesignTimeLayout_Reference_1})
        gridNSerieCaract_DesignTimeLayout.LayoutString = resources.GetString("gridNSerieCaract_DesignTimeLayout.LayoutString")
        Me.gridNSerieCaract.DesignTimeLayout = gridNSerieCaract_DesignTimeLayout
        Me.gridNSerieCaract.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridNSerieCaract.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.gridNSerieCaract.EntityName = ""
        Me.gridNSerieCaract.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridNSerieCaract.Location = New System.Drawing.Point(0, 0)
        Me.gridNSerieCaract.Name = "gridNSerieCaract"
        Me.gridNSerieCaract.PrimaryDataFields = ""
        Me.gridNSerieCaract.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.gridNSerieCaract.RequeryManually = True
        Me.gridNSerieCaract.SecondaryDataFields = ""
        Me.gridNSerieCaract.Size = New System.Drawing.Size(288, 159)
        Me.gridNSerieCaract.TabIndex = 63
        Me.gridNSerieCaract.ViewName = "vfrmSearchNSerieCaract"
        '
        'pnlLabelCaractersticasNSerie
        '
        Me.pnlLabelCaractersticasNSerie.Controls.Add(Me.lblCareacteristicasNserie)
        Me.pnlLabelCaractersticasNSerie.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabelCaractersticasNSerie.Location = New System.Drawing.Point(0, 0)
        Me.pnlLabelCaractersticasNSerie.Name = "pnlLabelCaractersticasNSerie"
        Me.pnlLabelCaractersticasNSerie.Size = New System.Drawing.Size(288, 25)
        Me.pnlLabelCaractersticasNSerie.TabIndex = 2
        '
        'lblCareacteristicasNserie
        '
        Me.lblCareacteristicasNserie.Location = New System.Drawing.Point(3, 5)
        Me.lblCareacteristicasNserie.Name = "lblCareacteristicasNserie"
        Me.lblCareacteristicasNserie.Size = New System.Drawing.Size(144, 13)
        Me.lblCareacteristicasNserie.TabIndex = 0
        Me.lblCareacteristicasNserie.Text = "Características Nº Serie"
        '
        'frmSearchArticulo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(826, 550)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnlLeft)
        Me.Name = "frmSearchArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de artículos"
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlArbol.ResumeLayout(False)
        Me.pnlCaracteristicas.ResumeLayout(False)
        CType(Me.gridFamiliaCaract, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlArticulos.ResumeLayout(False)
        Me.pnlGridArticulos.ResumeLayout(False)
        CType(Me.gridArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLabelArticulos.ResumeLayout(False)
        Me.pnlLabelArticulos.PerformLayout()
        Me.pnlArticulosalternativos.ResumeLayout(False)
        Me.pnlGridArticulosAlternativos.ResumeLayout(False)
        CType(Me.gridArticulosAlt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLabelArticulosAlternativos.ResumeLayout(False)
        Me.pnlLabelArticulosAlternativos.PerformLayout()
        Me.pnlFilterArticulo.ResumeLayout(False)
        Me.pnlFilterArticulo.PerformLayout()
        Me.pnlFiltro.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlActivos.ResumeLayout(False)
        CType(Me.gridActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLabelActivos.ResumeLayout(False)
        Me.pnlLabelActivos.PerformLayout()
        Me.pnlCaracteristicasNSerie.ResumeLayout(False)
        Me.pnlGridCaractersticasNSerie.ResumeLayout(False)
        CType(Me.gridNSerieCaract, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLabelCaractersticasNSerie.ResumeLayout(False)
        Me.pnlLabelCaractersticasNSerie.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mstrIDArticulo, mstrNSerie, mstrIdEstadoActivo As String
    Private mblnDisponible As Boolean
    Private mdtTA, mdtFam, mdtSubFam As DataTable
    Private mstrIDTipo, mstrIDFamilia, mstrIDSubFamilia, mstrIDArtSelected, mstrIDArtAltSelected As String
    Private fWhere As Filter

#Region " Load "

    Public Sub AbrirForm(ByRef strIDArticulo As String, Optional ByRef strNSerie As String = "", _
                         Optional ByRef blnDisponible As Boolean = False, _
                         Optional ByRef strIDEstadoActivo As String = "")

        Me.ShowDialog()
        strIDArticulo = mstrIDArticulo
        strNSerie = mstrNSerie
        blnDisponible = mblnDisponible
        strIDEstadoActivo = mstrIdEstadoActivo
    End Sub

    Private Sub frmSearchArticulo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fWhere = New Filter
        LoadEstilos()
        LoadArbol()
        LoadEnums()
        LoadGridActions()
    End Sub

    Private Sub LoadEstilos()
        Dim dtEstados As DataTable = New MntoEstadoActivo().Filter()
        If Not IsNothing(dtEstados) AndAlso dtEstados.Rows.Count > 0 Then
            GridFormatStyle.CrearFormatos(gridActivos, dtEstados, GridFormatStyle.TipoFormato.EstadoActivo, True)
        End If
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumOperadores", gridFamiliaCaract.Columns("Operador"))
        EnumData.PopulateValueList("enumOperandos", gridFamiliaCaract.Columns("Operando"))
        EnumData.PopulateValueList("enumOperadores", gridNSerieCaract.Columns("Operador"))
        EnumData.PopulateValueList("enumOperandos", gridNSerieCaract.Columns("Operando"))
    End Sub

    Private Sub LoadGridActions()
        gridArticulos.Actions.Add("Documentos Relacionados", AddressOf AbrirDocumentosAsociados, ExpertisApp.GetIcon("document_view.ico"))
        gridArticulosAlt.Actions.Add("Documentos Relacionados", AddressOf AbrirDocumentosAsociados, ExpertisApp.GetIcon("document_view.ico"))
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case e.Button.ImageIndex
            Case 0
                LoadArticulos()
                lblWhereArticulo.Text = String.Empty
                mstrIDArtAltSelected = String.Empty
                mstrIDArtSelected = String.Empty
                GeneraWhere()
                FiltrarCaractNSerie()
                ResetCaracteristica(gridNSerieCaract)
        End Select
    End Sub

    Private Sub LoadArticulos()
        Dim strOperando As String = String.Empty
        Dim f As New Filter
        Dim strFiltro As String = String.Empty

        If length(mstrIDTipo) > 0 Then f.Add("IDTipo", FilterOperator.Equal, mstrIDTipo, FilterType.String)
        If length(mstrIDFamilia) > 0 Then f.Add("IDFamilia", FilterOperator.Equal, mstrIDFamilia, FilterType.String)

        If f.Count > 0 Then strFiltro = f.Compose(New AdoFilterComposer)

        If gridFamiliaCaract.RowCount > 0 Then
            If Not IsNothing(gridFamiliaCaract.DataSource) Then
                gridFamiliaCaract.UpdateData()
                Dim dvCalculo As DataView = CType(gridFamiliaCaract.DataSource, DataTable).Copy.DefaultView
                dvCalculo.RowFilter = f.Compose(New AdoFilterComposer)
                strOperando = "AND"
                For Each drv As DataRowView In dvCalculo
                    If Length(drv("Valor")) > 0 Then
                        If Length(strFiltro) > 0 Then strFiltro = strFiltro & " " & strOperando & " "
                        strFiltro = strFiltro & "(IDCaracteristica = '" & (drv("IDCaracteristica") & "'")
                        strFiltro = strFiltro & " AND " & GeneraSQL(drv("Valor"), "Valor", Nz(drv("Operador"), enumOperadores.oIgual)) & ")"
                        If Length(drv("Operando")) > 0 Then
                            If drv("Operando") = enumOperandos.oOR Then
                                strOperando = "OR"
                            Else
                                strOperando = "AND"
                            End If
                        Else
                            strOperando = "OR"
                        End If
                    End If
                Next
            End If
        End If

        f.Clear()
        If Length(strFiltro) > 0 Then
            Dim dt As DataTable = New BE.DataEngine().Filter("vSearchArticuloOrdenesAlquiler", "", strFiltro)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                f.UnionOperator = FilterUnionOperator.Or
                For Each dr As DataRow In dt.Rows
                    f.Add(New StringFilterItem("IDArticulo", dr("IDArticulo")))
                Next
            Else
                f.Add(New NoRowsFilterItem)
            End If
        End If

        gridArticulos.DataSource = New BE.DataEngine().Filter("vfrmSearchArticulos", f)
        gridActivos.DataSource = Nothing
    End Sub

    Private Sub mnuExplosionArbol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExplosionArbol.Click
        TvwTipoFamilia.ExpandAll()
    End Sub

    Private Sub mnuImplosionArbol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImplosionArbol.Click
        TvwTipoFamilia.CollapseAll()
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AbrirDocumentosAsociados()
        Dim dtPK As New DataTable
        dtPK.Rows.Add("IDArticulo", GetType(String))
        Dim drArticulo As DataRow = dtPK.NewRow
        drArticulo("IDArticulo") = IIf(gridArticulos.Focused, gridArticulos.Value("IDArticulo"), gridArticulosAlt.Value("IDArticuloAlternativo"))

        Dim GD As New clsDocusRelacionadosGD
        GD.DocumentosRelacionados(GetType(Articulo).Name, dtPK)
    End Sub

#End Region

#Region " Arbol "

    Private Sub LoadArbol()
        Dim ndNodoTipo As TreeNode
        Dim ndNodoFamilia As TreeNode
        Dim ndNodoSubFamilia As TreeNode
        Dim strWhere As String
        Dim strText As String
        TvwTipoFamilia.Visible = False
        TvwTipoFamilia.Nodes.Clear()
        TvwTipoFamilia.Visible = True

        RefreshTreeView()

        TvwTipoFamilia.ImageList = ImageList1
        If IsNothing(mdtTA) Then RefreshTreeView()

        If Not IsNothing(mdtTA) AndAlso mdtTA.Rows.Count > 0 Then
            For Each drTA As DataRow In mdtTA.Rows
                strText = drTA("IDTipo") & " -> " & drTA("DescTipo")
                ndNodoTipo = TvwTipoFamilia.Nodes.Add(strText)
                ndNodoTipo.Tag = New TagTipo(drTA("IDTipo"))
                ndNodoTipo.ImageIndex = 2
                ndNodoTipo.SelectedImageIndex = 2
                strWhere = "IDTipo='" & drTA("IDTipo") & "'"
                If Not IsNothing(mdtFam) AndAlso mdtFam.Rows.Count > 0 Then
                    Dim dvFam As DataView = mdtFam.DefaultView
                    dvFam.RowFilter = strWhere
                    If dvFam.Count > 0 Then
                        For Each drvFam As DataRowView In dvFam
                            strText = drvFam("IDFamilia") & " - " & drvFam("DescFamilia")
                            ndNodoFamilia = ndNodoTipo.Nodes.Add(strText)
                            ndNodoFamilia.Tag = New TagTipoFamilia(drvFam("IDTipo"), drvFam("IDFamilia"))
                            ndNodoFamilia.ImageIndex = 3
                            ndNodoFamilia.SelectedImageIndex = 3
                            strWhere = "IDTipo='" & drTA("IDTipo") & "' AND IDFamilia= '" & drvFam("IDFamilia") & "'"
                            If Not IsNothing(mdtSubFam) AndAlso mdtSubFam.Rows.Count > 0 Then
                                Dim dvSubFam As DataView = mdtSubFam.DefaultView
                                dvSubFam.RowFilter = strWhere
                                If dvSubFam.Count > 0 Then
                                    For Each drvSubFam As DataRowView In dvSubFam
                                        strText = drvSubFam("IDSubfamilia") & " - " & drvSubFam("DescSubfamilia")
                                        ndNodoSubFamilia = ndNodoFamilia.Nodes.Add(strText)
                                        ndNodoSubFamilia.Tag = New TagTipoSubFamilia(drvSubFam("IDTipo"), drvSubFam("IDFamilia"), drvSubFam("IDSubfamilia"))
                                        ndNodoSubFamilia.ImageIndex = 4
                                        ndNodoSubFamilia.SelectedImageIndex = 4
                                    Next
                                End If
                            End If
                        Next
                    End If
                End If
            Next
        End If
        TvwTipoFamilia.Refresh()
    End Sub

    Private Sub RefreshTreeView()
        mdtTA = New TipoArticulo().Filter("IDTipo,DescTipo", , "IDTipo")
        mdtFam = New Familia().Filter("IDTipo,IDFamilia,DescFamilia", , "IDFamilia")
        mdtSubFam = New Subfamilia().Filter("IDTipo,IDFamilia,IDSubfamilia,DescSubfamilia", , "IDSubfamilia")
    End Sub

    Private Sub TvwTipoFamilia_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TvwTipoFamilia.AfterSelect
        e.Node.EnsureVisible()
        If TypeOf e.Node.Tag Is TagTipo Then
            mstrIDTipo = CType(e.Node.Tag, TagTipo).IDTipo
            mstrIDFamilia = String.Empty
            mstrIDSubFamilia = String.Empty
        ElseIf TypeOf e.Node.Tag Is TagTipoFamilia Then
            mstrIDTipo = CType(e.Node.Tag, TagTipoFamilia).IDTipo
            mstrIDFamilia = CType(e.Node.Tag, TagTipoFamilia).IDFamilia
            mstrIDSubFamilia = String.Empty
        ElseIf TypeOf e.Node.Tag Is TagTipoSubFamilia Then
            mstrIDTipo = CType(e.Node.Tag, TagTipoSubFamilia).IDTipo
            mstrIDFamilia = CType(e.Node.Tag, TagTipoSubFamilia).IDFamilia
            mstrIDSubFamilia = CType(e.Node.Tag, TagTipoSubFamilia).IDSubFamilia
        End If

        FiltrarCaracteristicas()
        ResetCaracteristica(gridFamiliaCaract)
    End Sub

#End Region

#Region " Grid Familia Caracteristica "

    Private Sub cmdDelFilterCaracteristica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelFilterCaracteristica.Click
        FiltrarCaracteristicas()
        ResetCaracteristica(gridFamiliaCaract)
    End Sub

    Private Sub gridFamiliaCaract_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridFamiliaCaract.GotFocus
        With gridFamiliaCaract
            .Columns("Operador").DefaultValue = CInt(enumOperadores.oIgual)
            If Length(mstrIDTipo) > 0 Then .Columns("IDTipo").DefaultValue = mstrIDTipo
            If Length(mstrIDFamilia) > 0 Then .Columns("IDFamilia").DefaultValue = mstrIDFamilia
        End With
    End Sub

    Private Sub gridFamiliaCaract_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles gridFamiliaCaract.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "Valor"
                e.Filter.Add("IDCaracteristica", FilterOperator.Equal, gridFamiliaCaract.GetValue("IDCaracteristica"), FilterType.String)
        End Select
    End Sub

    Private Sub gridFamiliaCaract_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles gridFamiliaCaract.UpdatingCell
        With gridFamiliaCaract
            Select Case e.Column.Key
                Case "Valor"
                    Dim f As New Filter
                    f.Add(New StringFilterItem("IDCaracteristica", .Value("IDCaracteristica")))
                    f.Add(New StringFilterItem("IDValor", e.Value))

                    Dim dt As DataTable = New BE.DataEngine().Filter("vFrmSearchArticuloValorCaracteristica", f)
                    If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                        .Value("TipoDato") = dt.Rows(0)("TipoDato")
                    Else
                        e.Cancel = True
                    End If
                    If e.Cancel Then ExpertisApp.GenerateMessage("El valor {0} no existe para la característica {1}.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, .Value(e.Column.Key), .Value(.Columns("IDCaracteristica").Index))
            End Select
        End With
    End Sub

    Private Sub gridFamiliaCaract_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gridFamiliaCaract.UpdatingRecord
        With gridFamiliaCaract
            .Value("IDTipo") = mstrIDTipo
            .Value("IDFamilia") = mstrIDFamilia
            If .Value("TipoDato") = enumTipoDato.Numerico Then
                If Not IsNumeric(.Value("Valor")) Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Esta característica sólo admite valores numéricos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End With
    End Sub

#End Region

#Region " Grid Articulos "

    Private Sub cmdDelFilterArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelFilterArt.Click
        mstrIDArtSelected = String.Empty
        GeneraWhere()
        FiltrarCaractNSerie()
    End Sub

    Private Sub gridArticulos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridArticulos.Click
        If Not gridArticulos Is Nothing AndAlso gridArticulos.RowCount > 0 Then
            mstrIDArtSelected = gridArticulos.Value("IDArticulo")
            mstrIDArtAltSelected = String.Empty
            GeneraWhere()
            Dim f As New Filter
            f.Add(New StringFilterItem("IDArticulo", gridArticulos.Value("IDArticulo")))
            gridArticulosAlt.ReQuery(f)
            FiltrarCaractNSerie()
            ResetCaracteristica(gridNSerieCaract)
        End If
    End Sub

    Private Sub gridArticulos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridArticulos.DoubleClick
        If gridArticulos.RowCount > 0 Then
            mstrIDArticulo = gridArticulos.Value("IDArticulo")
            mstrNSerie = String.Empty
            mblnDisponible = False
            mstrIdEstadoActivo = String.Empty
            Me.Close()
        End If
    End Sub

#End Region

    Private Sub cmdFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        Dim Filtro As String = lblWhereArticulo.Text

        If gridNSerieCaract.RowCount > 0 Then
            Filtro = String.Empty
            Dim dv As DataView = CType(gridNSerieCaract.DataSource, DataTable).DefaultView
            Dim strOperando As String = "AND"

            For Each drv As DataRowView In dv
                If Length(drv("Valor")) > 0 Then
                    If Length(Filtro) > 0 Then Filtro = Filtro & " " & strOperando & " "
                    Filtro = Filtro & "(IDCaracteristica = '" & (drv("IDCaracteristica") & "'")
                    Filtro = Filtro & " AND " & GeneraSQL(drv("Valor"), "Valor", Nz(drv("Operador"), enumOperadores.oIgual)) & ")"
                    If Length(drv("Operando")) > 0 Then
                        If drv("Operando") = enumOperandos.oOR Then
                            strOperando = "OR"
                        Else
                            strOperando = "AND"
                        End If
                    Else
                        strOperando = "OR"
                    End If
                End If
            Next

            If Length(Filtro) > 0 Then
                Dim dtAC As DataTable = New ActivoCaracteristica().Filter("IDActivo", Filtro)
                Filtro = String.Empty
                Dim FiltroOR As New Filter
                Dim Values(-1) As Object
                For Each drAC As DataRow In dtAC.Rows
                    ReDim Preserve Values(UBound(Values) + 1)
                    Values(UBound(Values)) = drAC("IDActivo")
                Next

                If Values.Length > 0 Then
                    FiltroOR.Add(New InListFilterItem("IDActivo", Values, FilterType.String))
                    Filtro = lblWhereArticulo.Text & " AND " & FiltroOR.Compose(New AdoFilterComposer)
                Else
                    Filtro = "1=2"
                End If
            End If
        End If

        gridActivos.DataSource = New BE.DataEngine().Filter("vfrmSearchArticuloActivos", "", Filtro)
    End Sub

#Region " Grid Articulos Alternativos "

    Private Sub cmdDelFilterArtAlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelFilterArtAlt.Click
        mstrIDArtAltSelected = String.Empty
        GeneraWhere()
        FiltrarCaractNSerie()
    End Sub

    Private Sub gridArticulosAlt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridArticulosAlt.Click
        If Not gridArticulosAlt Is Nothing AndAlso gridArticulosAlt.RowCount > 0 Then
            mstrIDArtAltSelected = gridArticulosAlt.Value("IDArticuloAlternativo")
            GeneraWhere()

            FiltrarCaractNSerie()
        End If
    End Sub

    Private Sub gridArticulosAlt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridArticulosAlt.DoubleClick
        If gridArticulosAlt.RowCount > 0 Then
            mstrIDArticulo = gridArticulosAlt.Value("IDArticuloAlternativo")
            mstrNSerie = String.Empty
            mblnDisponible = False
            mstrIdEstadoActivo = String.Empty
            Me.Close()
        End If
    End Sub

#End Region

#Region " Grid Activos "

    Private Sub gridActivos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridActivos.DoubleClick
        With gridActivos
            If gridActivos.RowCount > 0 Then
                mstrIDArticulo = .Value("IDArticulo") & String.Empty
                mstrNSerie = .Value("NSerie") & String.Empty
                mblnDisponible = Nz(.Value("Disponible"), False)
                mstrIdEstadoActivo = .Value("IDEstadoActivo") & String.Empty
                Me.Close()
            End If
        End With
    End Sub

    Private Sub gridActivos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles gridActivos.FormattingRow
        e.Row.RowStyle = gridActivos.FormatStyles("FMT" & e.Row.DataRow("IDEstadoActivo"))
    End Sub

#End Region

#Region " Grid NSerie Caracteristica "

    Private Sub cmdDelFilterNSerieCaract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelFilterNSerieCaract.Click
        FiltrarCaractNSerie()
        ResetCaracteristica(gridNSerieCaract)
    End Sub

    Private Sub gridNSerieCaract_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridNSerieCaract.GotFocus
        With gridNSerieCaract
            .Columns("Operador").DefaultValue = CInt(enumOperadores.oIgual)
            If Length(mstrIDArtSelected) > 0 Then
                .Columns("IDArticulo").DefaultValue = mstrIDArtSelected
            ElseIf Length(mstrIDArtAltSelected) > 0 Then
                .Columns("IDArticulo").DefaultValue = mstrIDArtAltSelected
            End If
        End With
    End Sub

    Private Sub gridNSerieCaract_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles gridNSerieCaract.UpdatingCell
        With gridNSerieCaract
            Select Case e.Column.Key
                Case "Valor"
                    Dim f As New Filter
                    f.Add(New StringFilterItem("IDCaracteristica", .Value("IDCaracteristica")))
                    f.Add(New StringFilterItem("IDValor", e.Value))

                    Dim dt As DataTable = New BE.DataEngine().Filter("vFrmSearchArticuloValorCaracteristica", f)
                    If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                        .Value("TipoDato") = dt.Rows(0)("TipoDato")
                    Else
                        e.Cancel = True
                    End If
                    If e.Cancel Then ExpertisApp.GenerateMessage("'El valor {0} no existe para la característica {1}.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, .Value(e.Column.Key), .Value("IDCaracteristica"))
            End Select
        End With
    End Sub

    Private Sub gridNSerieCaract_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gridNSerieCaract.UpdatingRecord
        With gridNSerieCaract
            .Value("IDArticulo") = mstrIDArtSelected
            If .Value("TipoDato") = enumTipoDato.Numerico Then
                If Not IsNumeric(.Value("Valor")) Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Esta característica sólo admite valores numéricos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End With
    End Sub

    Private Sub gridNSerieCaract_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles gridNSerieCaract.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "Valor"
                e.Filter.Add("IDCaracteristica", FilterOperator.Equal, gridNSerieCaract.GetValue("IDCaracteristica"), FilterType.String)
        End Select
    End Sub

#End Region

    Private Function GeneraSQL(ByVal strValor As String, ByVal strCampo As String, ByVal intOperador As Integer) As String
        Dim f As New Filter
        Select Case intOperador
            Case enumOperadores.oIgual
                f.Add(strCampo, FilterOperator.Equal, strValor)
            Case enumOperadores.oLike
                f.Add(New LikeFilterItem(strCampo, strValor))
            Case enumOperadores.oMayor
                f.Add(strCampo, FilterOperator.GreaterThan, strValor)
            Case enumOperadores.oMayorIgual
                f.Add(strCampo, FilterOperator.GreaterThanOrEqual, strValor)
            Case enumOperadores.oMenor
                f.Add(strCampo, FilterOperator.LessThan, strValor)
            Case enumOperadores.oMenorIgual
                f.Add(strCampo, FilterOperator.LessThanOrEqual, strValor)
            Case enumOperadores.oNoLike
                f.Add(New LikeFilterItem(strCampo, strValor, False))
        End Select

        Return f.Compose(New AdoFilterComposer)
    End Function

    Private Sub FiltrarCaracteristicas()
        Dim f As New Filter
        f.Add(New StringFilterItem("IDTipo", mstrIDTipo))
        If Length(mstrIDFamilia) > 0 Then f.Add(New StringFilterItem("IDFamilia", mstrIDFamilia))
        gridFamiliaCaract.ReQuery(f)
    End Sub

    Private Sub FiltrarCaractNSerie()
        If fWhere.Count = 0 Then fWhere.Add(New NoRowsFilterItem)
        gridNSerieCaract.ReQuery(fWhere)
    End Sub

    Private Sub ResetCaracteristica(ByVal Grid As GridEX)
        Dim dt As DataTable = Grid.DataSource
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Select
                dr("Valor") = String.Empty
                dr("Operador") = CInt(enumOperadores.oIgual)
                dr("Operando") = String.Empty
            Next
        End If
    End Sub

    Private Sub GeneraWhere()
        Dim f As New Filter
        Dim f2 As New Filter
        If Length(mstrIDArtSelected) > 0 And Length(mstrIDArtAltSelected) > 0 Then
            f.UnionOperator = FilterUnionOperator.Or
            f.Add(New StringFilterItem("IDArticulo", mstrIDArtSelected))
            f.Add(New StringFilterItem("IDArticulo", mstrIDArtAltSelected))
        ElseIf Length(mstrIDArtSelected) > 0 Then
            f.Add(New StringFilterItem("IDArticulo", mstrIDArtSelected))
        ElseIf Length(mstrIDArtAltSelected) > 0 Then
            f.Add(New StringFilterItem("IDArticulo", mstrIDArtAltSelected))
        Else
            f2.Add(New NoRowsFilterItem)
        End If
        fWhere.Clear()
        fWhere.Add(f)
        lblWhereArticulo.Text = fWhere.Compose(New AdoFilterComposer)
        fWhere.Add(f2)
    End Sub

#Region " TAG "

    Private Class TagTipo
        Public IDTipo As String

        Public Sub New(ByVal IDTipo As String)
            Me.IDTipo = IDTipo
        End Sub
    End Class

    Private Class TagTipoFamilia
        Public IDTipo, IDFamilia As String

        Public Sub New(ByVal IDTipo As String, Optional ByVal IDFamilia As String = "")
            Me.IDTipo = IDTipo
            Me.IDFamilia = IDFamilia
        End Sub
    End Class

    Private Class TagTipoSubFamilia
        Public IDTipo, IDFamilia, IDSubFamilia As String

        Public Sub New(ByVal IDTipo As String, Optional ByVal IDFamilia As String = "", Optional ByVal IDSubFamilia As String = "")
            Me.IDTipo = IDTipo
            Me.IDFamilia = IDFamilia
            Me.IDSubFamilia = IDSubFamilia
        End Sub
    End Class

#End Region

End Class