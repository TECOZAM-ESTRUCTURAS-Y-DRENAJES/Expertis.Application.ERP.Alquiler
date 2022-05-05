<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIFacturacion
    Inherits Solmicro.Expertis.Application.ERP.Obras.CIFacturacion

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cbxAgrupFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstadoCertificacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVtos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMod_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridGastos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCertificacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoAgrupacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxAño_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMateriales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxClienteEventual_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstadoOT_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoOT_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxPeriodoFacturacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIFacturacion))
        Dim GridAlquiler_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridAlquiler_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridTallerAlquiler_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridAlbaran_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.pnlConfigAlquiler = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxFechaCalculo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaCalculo = New Solmicro.Expertis.Engine.UI.Label
        Me.chkFacturarOrdenesCerradas = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkTenerEnCuenta = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.txtDiaFacturacion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDiaFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.chkCalculoSeguros = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.pnlClienteEventual = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblClienteEventual = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxClienteEventual = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.pnlEstadoOT = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxEstadoOT = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstadoOT = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlTipoOT = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxTipoOT = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTipoOT = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvOTHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblOTHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvOTDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblOTDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlPeriodoFactura = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxPeriodoFacturacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblPeriodoFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPageAlquiler = New Janus.Windows.UI.Tab.UITabPage
        Me.GridAlquiler = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPageTallerAlquiler = New Janus.Windows.UI.Tab.UITabPage
        Me.GridTallerAlquiler = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageAlbaran = New Janus.Windows.UI.Tab.UITabPage
        Me.GridAlbaran = New Solmicro.Expertis.Engine.UI.Grid
        Me.advIDAlbaran = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlbaran = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlAlbaran = New Solmicro.Expertis.Engine.UI.Panel
        Me.Tipo = New Solmicro.Expertis.Engine.UI.Label
        Me.Familia = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTipoArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvFamiliaArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        CType(Me.cbxAgrupFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTipoFactura.suspendlayout()
        CType(Me.cbxTipoFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEstadoCertificacion.suspendlayout()
        CType(Me.cbxEstadoCertificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOperario.suspendlayout()
        Me.pnlEstado.suspendlayout()
        Me.pnlCriteriosSeleccion.suspendlayout()
        Me.Panel1.suspendlayout()
        CType(Me.TabFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFacturacion.SuspendLayout()
        Me.TabPageHitos.SuspendLayout()
        CType(Me.GridVtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageHoras.SuspendLayout()
        CType(Me.GridMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageGastos.SuspendLayout()
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCertificacion.SuspendLayout()
        CType(Me.GridCertificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTipoAgrupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFechaVto.suspendlayout()
        Me.pnlConfigFacturacion.suspendlayout()
        Me.TabPageMateriales.SuspendLayout()
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotales.suspendlayout()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.pnlConfigAlquiler.suspendlayout()
        Me.pnlClienteEventual.suspendlayout()
        CType(Me.cbxClienteEventual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEstadoOT.suspendlayout()
        CType(Me.cbxEstadoOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTipoOT.suspendlayout()
        CType(Me.cbxTipoOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPeriodoFactura.suspendlayout()
        CType(Me.cbxPeriodoFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAlquiler.SuspendLayout()
        CType(Me.GridAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageTallerAlquiler.SuspendLayout()
        CType(Me.GridTallerAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAlbaran.SuspendLayout()
        CType(Me.GridAlbaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAlbaran.suspendlayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.pnlAlbaran)
        Me.FilterPanel.Controls.Add(Me.pnlPeriodoFactura)
        Me.FilterPanel.Controls.Add(Me.pnlEstadoOT)
        Me.FilterPanel.Controls.Add(Me.pnlClienteEventual)
        Me.FilterPanel.Controls.Add(Me.lblOTHasta)
        Me.FilterPanel.Controls.Add(Me.pnlTipoOT)
        Me.FilterPanel.Controls.Add(Me.AdvTipoArticulo)
        Me.FilterPanel.Controls.Add(Me.Tipo)
        Me.FilterPanel.Controls.Add(Me.lblOTDesde)
        Me.FilterPanel.Controls.Add(Me.AdvFamiliaArticulo)
        Me.FilterPanel.Controls.Add(Me.Familia)
        Me.FilterPanel.Controls.Add(Me.AdvOTHasta)
        Me.FilterPanel.Controls.Add(Me.AdvOTDesde)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvClienteDesde, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvAlqVen, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblAlqOVen, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvIDArticulo, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblArticulo, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvOTDesde, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvOTHasta, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvTrabajo, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblFechaHasta, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.Familia, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.cbxFechaDesde, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblSubTipoTrabajo, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvFamiliaArticulo, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblOTDesde, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.Tipo, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblTipoTrabajo, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvObraHasta, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblTipoFactura, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.pnlOperario, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.pnlTipoFactura, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvSubTipoTrabajo, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvTipoArticulo, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvTipoTrabajo, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.pnlTipoOT, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblOTHasta, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblFechaDesde, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.pnlClienteEventual, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.pnlEstadoOT, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.pnlPeriodoFactura, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.pnlAlbaran, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblObraHasta, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvObraDesde, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblObraDesde, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblClienteDesde, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvClienteHasta, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblClienteHasta, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.AdvIDCentroGestion, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblCentroGestion, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.cbxFechaHasta, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.cbxAgrupFactura, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblAgrupFactura, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.pnlEstado, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.pnlEstadoCertificacion, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.lblCodTrabajo, 0)
        '
        'lblTipoTrabajo
        '
        Me.lblTipoTrabajo.Location = New System.Drawing.Point(208, 54)
        '
        'lblSubTipoTrabajo
        '
        Me.lblSubTipoTrabajo.Location = New System.Drawing.Point(225, 79)
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Size = New System.Drawing.Size(67, 13)
        Me.lblObraDesde.Text = "Alquiler D."
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Size = New System.Drawing.Size(66, 13)
        Me.lblObraHasta.Text = "Alquiler H."
        '
        'AdvObraHasta
        '
        Me.AdvObraHasta.Location = New System.Drawing.Point(83, 49)
        '
        'AdvTipoTrabajo
        '
        Me.AdvTipoTrabajo.Visible = True
        '
        'AdvSubTipoTrabajo
        '
        Me.AdvSubTipoTrabajo.Location = New System.Drawing.Point(274, 74)
        '
        'AdvObraDesde
        '
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(387, 79)
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(387, 53)
        '
        'AdvIDArticulo
        '
        Me.AdvIDArticulo.Location = New System.Drawing.Point(463, 74)
        Me.AdvIDArticulo.Visible = True
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(387, 31)
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.Location = New System.Drawing.Point(463, 24)
        Me.cbxFechaDesde.Visible = True
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.Visible = True
        '
        'cbxAgrupFactura
        '
        cbxAgrupFactura_DesignTimeLayout.LayoutString = resources.GetString("cbxAgrupFactura_DesignTimeLayout.LayoutString")
        Me.cbxAgrupFactura.DesignTimeLayout = cbxAgrupFactura_DesignTimeLayout
        '
        'cbxEstado
        '
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        '
        'pnlTipoFactura
        '
        Me.pnlTipoFactura.Location = New System.Drawing.Point(594, 101)
        Me.pnlTipoFactura.Size = New System.Drawing.Size(173, 25)
        '
        'lblTipoFactura
        '
        Me.lblTipoFactura.Location = New System.Drawing.Point(589, 79)
        '
        'cbxTipoFactura
        '
        cbxTipoFactura_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoFactura_DesignTimeLayout.LayoutString")
        Me.cbxTipoFactura.DesignTimeLayout = cbxTipoFactura_DesignTimeLayout
        Me.cbxTipoFactura.Location = New System.Drawing.Point(75, 3)
        Me.cbxTipoFactura.Size = New System.Drawing.Size(91, 21)
        '
        'pnlEstadoCertificacion
        '
        Me.pnlEstadoCertificacion.Size = New System.Drawing.Size(187, 25)
        '
        'cbxEstadoCertificacion
        '
        cbxEstadoCertificacion_DesignTimeLayout.LayoutString = resources.GetString("cbxEstadoCertificacion_DesignTimeLayout.LayoutString")
        Me.cbxEstadoCertificacion.DesignTimeLayout = cbxEstadoCertificacion_DesignTimeLayout
        Me.cbxEstadoCertificacion.Location = New System.Drawing.Point(69, 1)
        Me.cbxEstadoCertificacion.Size = New System.Drawing.Size(114, 21)
        '
        'pnlOperario
        '
        Me.pnlOperario.Location = New System.Drawing.Point(594, 101)
        Me.pnlOperario.Size = New System.Drawing.Size(186, 25)
        '
        'lblOperario
        '
        Me.lblOperario.Location = New System.Drawing.Point(3, 6)
        '
        'AdvIDOperario
        '
        Me.AdvIDOperario.Size = New System.Drawing.Size(100, 23)
        '
        'pnlCriteriosSeleccion
        '
        Me.pnlCriteriosSeleccion.Location = New System.Drawing.Point(0, 383)
        '
        'AdvClienteDesde
        '
        Me.AdvClienteDesde.Location = New System.Drawing.Point(82, 74)
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Size = New System.Drawing.Size(70, 13)
        Me.lblCodTrabajo.Text = "O. Servicio"
        '
        'Panel1
        '
        Me.Panel1.Size = New System.Drawing.Size(775, 35)
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(8, 11)
        '
        'TabFacturacion
        '
        Me.TabFacturacion.Location = New System.Drawing.Point(0, 63)
        Me.TabFacturacion.Size = New System.Drawing.Size(775, 291)
        Me.TabFacturacion.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageAlquiler, Me.TabPageAlbaran, Me.TabPageTallerAlquiler})
        Me.TabFacturacion.Controls.SetChildIndex(Me.TabPageTaller, 0)
        Me.TabFacturacion.Controls.SetChildIndex(Me.TabPageMateriales, 0)
        Me.TabFacturacion.Controls.SetChildIndex(Me.TabPageAlbaran, 0)
        Me.TabFacturacion.Controls.SetChildIndex(Me.TabPageTallerAlquiler, 0)
        Me.TabFacturacion.Controls.SetChildIndex(Me.TabPageAlquiler, 0)
        Me.TabFacturacion.Controls.SetChildIndex(Me.TabPageCertificacion, 0)
        Me.TabFacturacion.Controls.SetChildIndex(Me.TabPageGastos, 0)
        Me.TabFacturacion.Controls.SetChildIndex(Me.TabPageHoras, 0)
        Me.TabFacturacion.Controls.SetChildIndex(Me.TabPageHitos, 0)
        '
        'TabPageHitos
        '
        Me.TabPageHitos.Size = New System.Drawing.Size(773, 269)
        '
        'GridVtos
        '
        Me.GridVtos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperario", "Operario", "IDOperario"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCliente", "Cliente", "IDCliente", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCliente", "DescCliente")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipo", Nothing, "IDTipo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFamilia", Nothing, "IDFamilia"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("DescFacturacion", Nothing, "DescFacturacion")})
        GridVtos_DesignTimeLayout.LayoutString = resources.GetString("GridVtos_DesignTimeLayout.LayoutString")
        Me.GridVtos.DesignTimeLayout = GridVtos_DesignTimeLayout
        Me.GridVtos.Size = New System.Drawing.Size(773, 269)
        '
        'TabPageHoras
        '
        Me.TabPageHoras.Size = New System.Drawing.Size(773, 269)
        '
        'GridMod
        '
        GridMod_DesignTimeLayout.LayoutString = resources.GetString("GridMod_DesignTimeLayout.LayoutString")
        Me.GridMod.DesignTimeLayout = GridMod_DesignTimeLayout
        Me.GridMod.Size = New System.Drawing.Size(773, 269)
        '
        'TabPageGastos
        '
        Me.TabPageGastos.Size = New System.Drawing.Size(773, 269)
        '
        'GridGastos
        '
        GridGastos_DesignTimeLayout.LayoutString = resources.GetString("GridGastos_DesignTimeLayout.LayoutString")
        Me.GridGastos.DesignTimeLayout = GridGastos_DesignTimeLayout
        Me.GridGastos.Size = New System.Drawing.Size(773, 269)
        '
        'TabPageCertificacion
        '
        Me.TabPageCertificacion.Size = New System.Drawing.Size(773, 269)
        '
        'GridCertificacion
        '
        GridCertificacion_DesignTimeLayout.LayoutString = resources.GetString("GridCertificacion_DesignTimeLayout.LayoutString")
        Me.GridCertificacion.DesignTimeLayout = GridCertificacion_DesignTimeLayout
        Me.GridCertificacion.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridCertificacion.Size = New System.Drawing.Size(773, 269)
        '
        'lblTipoAgrupacion
        '
        Me.lblTipoAgrupacion.Location = New System.Drawing.Point(300, 11)
        '
        'cbxTipoAgrupacion
        '
        cbxTipoAgrupacion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoAgrupacion_DesignTimeLayout.LayoutString")
        Me.cbxTipoAgrupacion.DesignTimeLayout = cbxTipoAgrupacion_DesignTimeLayout
        Me.cbxTipoAgrupacion.Location = New System.Drawing.Point(373, 8)
        '
        'chkCondicionesCliente
        '
        Me.chkCondicionesCliente.Location = New System.Drawing.Point(160, 9)
        '
        'cbxAño
        '
        cbxAño_DesignTimeLayout.LayoutString = resources.GetString("cbxAño_DesignTimeLayout.LayoutString")
        Me.cbxAño.DesignTimeLayout = cbxAño_DesignTimeLayout
        Me.cbxAño.Location = New System.Drawing.Point(675, 9)
        '
        'lblAño
        '
        Me.lblAño.Location = New System.Drawing.Point(638, 11)
        '
        'pnlConfigFacturacion
        '
        Me.pnlConfigFacturacion.Controls.Add(Me.chkCalculoSeguros)
        Me.pnlConfigFacturacion.Size = New System.Drawing.Size(635, 34)
        Me.pnlConfigFacturacion.Controls.SetChildIndex(Me.chkCalculoSeguros, 0)
        Me.pnlConfigFacturacion.Controls.SetChildIndex(Me.lblTipoAgrupacion, 0)
        Me.pnlConfigFacturacion.Controls.SetChildIndex(Me.cbxTipoAgrupacion, 0)
        Me.pnlConfigFacturacion.Controls.SetChildIndex(Me.chkCondicionesCliente, 0)
        Me.pnlConfigFacturacion.Controls.SetChildIndex(Me.AdvContador, 0)
        Me.pnlConfigFacturacion.Controls.SetChildIndex(Me.lblContador, 0)
        '
        'TabPageMateriales
        '
        Me.TabPageMateriales.Size = New System.Drawing.Size(773, 269)
        '
        'GridMateriales
        '
        GridMateriales_DesignTimeLayout.LayoutString = resources.GetString("GridMateriales_DesignTimeLayout.LayoutString")
        Me.GridMateriales.DesignTimeLayout = GridMateriales_DesignTimeLayout
        Me.GridMateriales.Size = New System.Drawing.Size(773, 269)
        '
        'TabPageTaller
        '
        Me.TabPageTaller.TabVisible = False
        '
        'pnlTotales
        '
        Me.pnlTotales.Location = New System.Drawing.Point(0, 354)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.pnlConfigAlquiler)
        Me.MainPanel.Size = New System.Drawing.Size(775, 512)
        Me.MainPanel.Controls.SetChildIndex(Me.pnlCriteriosSeleccion, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.pnlConfigAlquiler, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.pnlTotales, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.TabFacturacion, 0)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(775, 512)
        '
        'pnlConfigAlquiler
        '
        Me.pnlConfigAlquiler.Controls.Add(Me.cbxFechaCalculo)
        Me.pnlConfigAlquiler.Controls.Add(Me.lblFechaCalculo)
        Me.pnlConfigAlquiler.Controls.Add(Me.chkFacturarOrdenesCerradas)
        Me.pnlConfigAlquiler.Controls.Add(Me.chkTenerEnCuenta)
        Me.pnlConfigAlquiler.Controls.Add(Me.txtDiaFacturacion)
        Me.pnlConfigAlquiler.Controls.Add(Me.lblDiaFacturacion)
        Me.pnlConfigAlquiler.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigAlquiler.Location = New System.Drawing.Point(0, 35)
        Me.pnlConfigAlquiler.Name = "pnlConfigAlquiler"
        Me.pnlConfigAlquiler.Size = New System.Drawing.Size(775, 28)
        Me.pnlConfigAlquiler.TabIndex = 30
        '
        'cbxFechaCalculo
        '
        Me.cbxFechaCalculo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaCalculo.Location = New System.Drawing.Point(682, 0)
        Me.cbxFechaCalculo.Name = "cbxFechaCalculo"
        Me.cbxFechaCalculo.Size = New System.Drawing.Size(87, 21)
        Me.cbxFechaCalculo.TabIndex = 8
        '
        'lblFechaCalculo
        '
        Me.lblFechaCalculo.Location = New System.Drawing.Point(591, 4)
        Me.lblFechaCalculo.Name = "lblFechaCalculo"
        Me.lblFechaCalculo.Size = New System.Drawing.Size(86, 13)
        Me.lblFechaCalculo.TabIndex = 118
        Me.lblFechaCalculo.Text = "Fecha Cálculo"
        '
        'chkFacturarOrdenesCerradas
        '
        Me.chkFacturarOrdenesCerradas.Location = New System.Drawing.Point(384, -1)
        Me.chkFacturarOrdenesCerradas.Name = "chkFacturarOrdenesCerradas"
        Me.chkFacturarOrdenesCerradas.Size = New System.Drawing.Size(178, 23)
        Me.chkFacturarOrdenesCerradas.TabIndex = 7
        Me.chkFacturarOrdenesCerradas.Text = "Facturar órdenes cerradas"
        '
        'chkTenerEnCuenta
        '
        Me.chkTenerEnCuenta.Location = New System.Drawing.Point(210, 0)
        Me.chkTenerEnCuenta.Name = "chkTenerEnCuenta"
        Me.chkTenerEnCuenta.Size = New System.Drawing.Size(156, 23)
        Me.chkTenerEnCuenta.TabIndex = 6
        Me.chkTenerEnCuenta.Text = "Tener en cuenta día"
        '
        'txtDiaFacturacion
        '
        Me.txtDiaFacturacion.DecimalDigits = 0
        Me.txtDiaFacturacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDiaFacturacion.Location = New System.Drawing.Point(107, 0)
        Me.txtDiaFacturacion.Name = "txtDiaFacturacion"
        Me.txtDiaFacturacion.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtDiaFacturacion.Size = New System.Drawing.Size(52, 21)
        Me.txtDiaFacturacion.TabIndex = 5
        '
        'lblDiaFacturacion
        '
        Me.lblDiaFacturacion.Location = New System.Drawing.Point(7, 3)
        Me.lblDiaFacturacion.Name = "lblDiaFacturacion"
        Me.lblDiaFacturacion.Size = New System.Drawing.Size(94, 13)
        Me.lblDiaFacturacion.TabIndex = 0
        Me.lblDiaFacturacion.Text = "Día Facturación"
        '
        'chkCalculoSeguros
        '
        Me.chkCalculoSeguros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkCalculoSeguros.AutoSize = True
        Me.chkCalculoSeguros.Location = New System.Drawing.Point(517, 9)
        Me.chkCalculoSeguros.Name = "chkCalculoSeguros"
        Me.chkCalculoSeguros.Size = New System.Drawing.Size(119, 18)
        Me.chkCalculoSeguros.TabIndex = 115
        Me.chkCalculoSeguros.Text = "Calcular Seguros"
        '
        'pnlClienteEventual
        '
        Me.pnlClienteEventual.Controls.Add(Me.lblClienteEventual)
        Me.pnlClienteEventual.Controls.Add(Me.cbxClienteEventual)
        Me.pnlClienteEventual.Location = New System.Drawing.Point(588, 46)
        Me.pnlClienteEventual.Name = "pnlClienteEventual"
        Me.pnlClienteEventual.Size = New System.Drawing.Size(178, 25)
        Me.pnlClienteEventual.TabIndex = 125
        Me.pnlClienteEventual.Visible = False
        '
        'lblClienteEventual
        '
        Me.lblClienteEventual.AutoSize = False
        Me.lblClienteEventual.Location = New System.Drawing.Point(2, 1)
        Me.lblClienteEventual.Name = "lblClienteEventual"
        Me.lblClienteEventual.Size = New System.Drawing.Size(63, 24)
        Me.lblClienteEventual.TabIndex = 116
        Me.lblClienteEventual.Text = "Cliente Eventual"
        '
        'cbxClienteEventual
        '
        cbxClienteEventual_DesignTimeLayout.LayoutString = resources.GetString("cbxClienteEventual_DesignTimeLayout.LayoutString")
        Me.cbxClienteEventual.DesignTimeLayout = cbxClienteEventual_DesignTimeLayout
        Me.cbxClienteEventual.DisabledBackColor = System.Drawing.Color.White
        Me.cbxClienteEventual.Location = New System.Drawing.Point(77, 2)
        Me.cbxClienteEventual.Name = "cbxClienteEventual"
        Me.cbxClienteEventual.SelectedIndex = -1
        Me.cbxClienteEventual.SelectedItem = Nothing
        Me.cbxClienteEventual.Size = New System.Drawing.Size(99, 21)
        Me.cbxClienteEventual.TabIndex = 28
        '
        'pnlEstadoOT
        '
        Me.pnlEstadoOT.Controls.Add(Me.cbxEstadoOT)
        Me.pnlEstadoOT.Controls.Add(Me.lblEstadoOT)
        Me.pnlEstadoOT.Location = New System.Drawing.Point(588, 21)
        Me.pnlEstadoOT.Name = "pnlEstadoOT"
        Me.pnlEstadoOT.Size = New System.Drawing.Size(178, 25)
        Me.pnlEstadoOT.TabIndex = 127
        '
        'cbxEstadoOT
        '
        cbxEstadoOT_DesignTimeLayout.LayoutString = resources.GetString("cbxEstadoOT_DesignTimeLayout.LayoutString")
        Me.cbxEstadoOT.DesignTimeLayout = cbxEstadoOT_DesignTimeLayout
        Me.cbxEstadoOT.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstadoOT.Location = New System.Drawing.Point(77, 2)
        Me.cbxEstadoOT.Name = "cbxEstadoOT"
        Me.cbxEstadoOT.SelectedIndex = -1
        Me.cbxEstadoOT.SelectedItem = Nothing
        Me.cbxEstadoOT.Size = New System.Drawing.Size(99, 21)
        Me.cbxEstadoOT.TabIndex = 27
        '
        'lblEstadoOT
        '
        Me.lblEstadoOT.Location = New System.Drawing.Point(2, 2)
        Me.lblEstadoOT.Name = "lblEstadoOT"
        Me.lblEstadoOT.Size = New System.Drawing.Size(45, 13)
        Me.lblEstadoOT.TabIndex = 116
        Me.lblEstadoOT.Text = "Estado"
        '
        'pnlTipoOT
        '
        Me.pnlTipoOT.Controls.Add(Me.cbxTipoOT)
        Me.pnlTipoOT.Controls.Add(Me.lblTipoOT)
        Me.pnlTipoOT.Location = New System.Drawing.Point(588, 46)
        Me.pnlTipoOT.Name = "pnlTipoOT"
        Me.pnlTipoOT.Size = New System.Drawing.Size(178, 25)
        Me.pnlTipoOT.TabIndex = 128
        Me.pnlTipoOT.Visible = False
        '
        'cbxTipoOT
        '
        cbxTipoOT_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoOT_DesignTimeLayout.LayoutString")
        Me.cbxTipoOT.DesignTimeLayout = cbxTipoOT_DesignTimeLayout
        Me.cbxTipoOT.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoOT.Location = New System.Drawing.Point(77, 2)
        Me.cbxTipoOT.Name = "cbxTipoOT"
        Me.cbxTipoOT.SelectedIndex = -1
        Me.cbxTipoOT.SelectedItem = Nothing
        Me.cbxTipoOT.Size = New System.Drawing.Size(99, 21)
        Me.cbxTipoOT.TabIndex = 26
        '
        'lblTipoOT
        '
        Me.lblTipoOT.Location = New System.Drawing.Point(2, 2)
        Me.lblTipoOT.Name = "lblTipoOT"
        Me.lblTipoOT.Size = New System.Drawing.Size(31, 13)
        Me.lblTipoOT.TabIndex = 116
        Me.lblTipoOT.Text = "Tipo"
        '
        'AdvOTHasta
        '
        Me.AdvOTHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvOTHasta.DisplayField = "NROT"
        Me.AdvOTHasta.EntityName = "MntoOT"
        Me.AdvOTHasta.Location = New System.Drawing.Point(274, 23)
        Me.AdvOTHasta.Name = "AdvOTHasta"
        Me.AdvOTHasta.SecondaryDataFields = "IDOT"
        Me.AdvOTHasta.Size = New System.Drawing.Size(99, 23)
        Me.AdvOTHasta.TabIndex = 133
        Me.AdvOTHasta.ViewName = "tbMntoOT"
        '
        'lblOTHasta
        '
        Me.lblOTHasta.Location = New System.Drawing.Point(208, 23)
        Me.lblOTHasta.Name = "lblOTHasta"
        Me.lblOTHasta.Size = New System.Drawing.Size(41, 13)
        Me.lblOTHasta.TabIndex = 135
        Me.lblOTHasta.Text = "OT. H."
        '
        'AdvOTDesde
        '
        Me.AdvOTDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvOTDesde.DisplayField = "NROT"
        Me.AdvOTDesde.EntityName = "MntoOT"
        Me.AdvOTDesde.Location = New System.Drawing.Point(275, 48)
        Me.AdvOTDesde.Name = "AdvOTDesde"
        Me.AdvOTDesde.SecondaryDataFields = "IDOT"
        Me.AdvOTDesde.Size = New System.Drawing.Size(99, 23)
        Me.AdvOTDesde.TabIndex = 132
        Me.AdvOTDesde.ViewName = "tbMntoOT"
        '
        'lblOTDesde
        '
        Me.lblOTDesde.Location = New System.Drawing.Point(240, 54)
        Me.lblOTDesde.Name = "lblOTDesde"
        Me.lblOTDesde.Size = New System.Drawing.Size(38, 13)
        Me.lblOTDesde.TabIndex = 134
        Me.lblOTDesde.Text = "OT. D"
        '
        'pnlPeriodoFactura
        '
        Me.pnlPeriodoFactura.Controls.Add(Me.cbxPeriodoFacturacion)
        Me.pnlPeriodoFactura.Controls.Add(Me.lblPeriodoFacturacion)
        Me.pnlPeriodoFactura.Location = New System.Drawing.Point(588, 21)
        Me.pnlPeriodoFactura.Name = "pnlPeriodoFactura"
        Me.pnlPeriodoFactura.Size = New System.Drawing.Size(178, 25)
        Me.pnlPeriodoFactura.TabIndex = 136
        Me.pnlPeriodoFactura.Visible = False
        '
        'cbxPeriodoFacturacion
        '
        cbxPeriodoFacturacion_DesignTimeLayout.LayoutString = resources.GetString("cbxPeriodoFacturacion_DesignTimeLayout.LayoutString")
        Me.cbxPeriodoFacturacion.DesignTimeLayout = cbxPeriodoFacturacion_DesignTimeLayout
        Me.cbxPeriodoFacturacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxPeriodoFacturacion.Location = New System.Drawing.Point(77, 2)
        Me.cbxPeriodoFacturacion.Name = "cbxPeriodoFacturacion"
        Me.cbxPeriodoFacturacion.SelectedIndex = -1
        Me.cbxPeriodoFacturacion.SelectedItem = Nothing
        Me.cbxPeriodoFacturacion.Size = New System.Drawing.Size(99, 21)
        Me.cbxPeriodoFacturacion.TabIndex = 25
        '
        'lblPeriodoFacturacion
        '
        Me.lblPeriodoFacturacion.AutoSize = False
        Me.lblPeriodoFacturacion.Location = New System.Drawing.Point(2, 1)
        Me.lblPeriodoFacturacion.Name = "lblPeriodoFacturacion"
        Me.lblPeriodoFacturacion.Size = New System.Drawing.Size(65, 24)
        Me.lblPeriodoFacturacion.TabIndex = 110
        Me.lblPeriodoFacturacion.Text = "Periodo Factura"
        '
        'TabPageAlquiler
        '
        Me.TabPageAlquiler.Controls.Add(Me.GridAlquiler)
        Me.TabPageAlquiler.Key = "Alquiler"
        Me.TabPageAlquiler.Location = New System.Drawing.Point(1, 21)
        Me.TabPageAlquiler.Name = "TabPageAlquiler"
        Me.TabPageAlquiler.Size = New System.Drawing.Size(773, 269)
        Me.TabPageAlquiler.TabStop = True
        Me.TabPageAlquiler.Text = "Alquiler"
        '
        'GridAlquiler
        '
        Me.GridAlquiler.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridAlquiler_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridAlquiler_DesignTimeLayout_Reference_0.Instance"), Object)
        GridAlquiler_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridAlquiler_DesignTimeLayout_Reference_0})
        GridAlquiler_DesignTimeLayout.LayoutString = resources.GetString("GridAlquiler_DesignTimeLayout.LayoutString")
        Me.GridAlquiler.DesignTimeLayout = GridAlquiler_DesignTimeLayout
        Me.GridAlquiler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAlquiler.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridAlquiler.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridAlquiler.EntityName = Nothing
        Me.GridAlquiler.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridAlquiler.ImageList = Me.ImageList1
        Me.GridAlquiler.Location = New System.Drawing.Point(0, 0)
        Me.GridAlquiler.Name = "GridAlquiler"
        Me.GridAlquiler.PrimaryDataFields = Nothing
        Me.GridAlquiler.SecondaryDataFields = Nothing
        Me.GridAlquiler.Size = New System.Drawing.Size(773, 269)
        Me.GridAlquiler.TabIndex = 4
        Me.GridAlquiler.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridAlquiler.ViewName = Nothing
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_edit.ico")
        '
        'TabPageTallerAlquiler
        '
        Me.TabPageTallerAlquiler.Controls.Add(Me.GridTallerAlquiler)
        Me.TabPageTallerAlquiler.Key = "TallerAlquiler"
        Me.TabPageTallerAlquiler.Location = New System.Drawing.Point(1, 21)
        Me.TabPageTallerAlquiler.Name = "TabPageTallerAlquiler"
        Me.TabPageTallerAlquiler.Size = New System.Drawing.Size(773, 246)
        Me.TabPageTallerAlquiler.TabStop = True
        Me.TabPageTallerAlquiler.Text = "Taller"
        '
        'GridTallerAlquiler
        '
        Me.GridTallerAlquiler.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridTallerAlquiler.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridTallerAlquiler.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridTallerAlquiler_DesignTimeLayout.LayoutString = resources.GetString("GridTallerAlquiler_DesignTimeLayout.LayoutString")
        Me.GridTallerAlquiler.DesignTimeLayout = GridTallerAlquiler_DesignTimeLayout
        Me.GridTallerAlquiler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTallerAlquiler.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridTallerAlquiler.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridTallerAlquiler.EntityName = "MntoOTControlLinea"
        Me.GridTallerAlquiler.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridTallerAlquiler.KeyField = "IDMntoOTControl"
        Me.GridTallerAlquiler.Location = New System.Drawing.Point(0, 0)
        Me.GridTallerAlquiler.Name = "GridTallerAlquiler"
        Me.GridTallerAlquiler.PrimaryDataFields = Nothing
        Me.GridTallerAlquiler.RequeryManually = True
        Me.GridTallerAlquiler.SecondaryDataFields = Nothing
        Me.GridTallerAlquiler.Size = New System.Drawing.Size(773, 246)
        Me.GridTallerAlquiler.TabIndex = 1
        Me.GridTallerAlquiler.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridTallerAlquiler.UseCheck = True
        Me.GridTallerAlquiler.ViewName = "vAlquilerCIObraFacturacionOT"
        '
        'TabPageAlbaran
        '
        Me.TabPageAlbaran.Controls.Add(Me.GridAlbaran)
        Me.TabPageAlbaran.Key = "Albaran"
        Me.TabPageAlbaran.Location = New System.Drawing.Point(1, 21)
        Me.TabPageAlbaran.Name = "TabPageAlbaran"
        Me.TabPageAlbaran.Size = New System.Drawing.Size(773, 246)
        Me.TabPageAlbaran.TabStop = True
        Me.TabPageAlbaran.Text = "Albaranes"
        '
        'GridAlbaran
        '
        Me.GridAlbaran.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridAlbaran.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridAlbaran.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridAlbaran_DesignTimeLayout.LayoutString = resources.GetString("GridAlbaran_DesignTimeLayout.LayoutString")
        Me.GridAlbaran.DesignTimeLayout = GridAlbaran_DesignTimeLayout
        Me.GridAlbaran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAlbaran.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridAlbaran.EntityName = "AlbaranVentaLinea"
        Me.GridAlbaran.KeyField = "IDLineaAlbaran"
        Me.GridAlbaran.Location = New System.Drawing.Point(0, 0)
        Me.GridAlbaran.Name = "GridAlbaran"
        Me.GridAlbaran.PrimaryDataFields = ""
        Me.GridAlbaran.RequeryManually = True
        Me.GridAlbaran.SecondaryDataFields = ""
        Me.GridAlbaran.Size = New System.Drawing.Size(773, 246)
        Me.GridAlbaran.TabIndex = 0
        Me.GridAlbaran.UseCheck = True
        Me.GridAlbaran.ViewName = "vAlquilerCIObraFacturacionAlbaranes"
        '
        'advIDAlbaran
        '
        Me.advIDAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.advIDAlbaran.EntityName = "AlbaranVentaCabecera"
        Me.advIDAlbaran.Location = New System.Drawing.Point(77, 2)
        Me.advIDAlbaran.Name = "advIDAlbaran"
        Me.advIDAlbaran.SecondaryDataFields = "IDAlbaran"
        Me.advIDAlbaran.Size = New System.Drawing.Size(99, 23)
        Me.advIDAlbaran.TabIndex = 137
        '
        'lblAlbaran
        '
        Me.lblAlbaran.Location = New System.Drawing.Point(2, 7)
        Me.lblAlbaran.Name = "lblAlbaran"
        Me.lblAlbaran.Size = New System.Drawing.Size(51, 13)
        Me.lblAlbaran.TabIndex = 138
        Me.lblAlbaran.Text = "Albarán"
        '
        'pnlAlbaran
        '
        Me.pnlAlbaran.Controls.Add(Me.advIDAlbaran)
        Me.pnlAlbaran.Controls.Add(Me.lblAlbaran)
        Me.pnlAlbaran.Location = New System.Drawing.Point(580, 46)
        Me.pnlAlbaran.Name = "pnlAlbaran"
        Me.pnlAlbaran.Size = New System.Drawing.Size(186, 25)
        Me.pnlAlbaran.TabIndex = 139
        '
        'Tipo
        '
        Me.Tipo.Location = New System.Drawing.Point(208, 54)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Size = New System.Drawing.Size(52, 13)
        Me.Tipo.TabIndex = 140
        Me.Tipo.Text = "Tipo Art"
        '
        'Familia
        '
        Me.Familia.Location = New System.Drawing.Point(207, 80)
        Me.Familia.Name = "Familia"
        Me.Familia.Size = New System.Drawing.Size(67, 13)
        Me.Familia.TabIndex = 141
        Me.Familia.Text = "Familia Art"
        '
        'AdvTipoArticulo
        '
        Me.AdvTipoArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoArticulo.EntityName = "TipoArticulo"
        Me.AdvTipoArticulo.Location = New System.Drawing.Point(275, 48)
        Me.AdvTipoArticulo.Name = "AdvTipoArticulo"
        Me.AdvTipoArticulo.SecondaryDataFields = "IDTipo"
        Me.AdvTipoArticulo.Size = New System.Drawing.Size(100, 23)
        Me.AdvTipoArticulo.TabIndex = 142
        Me.AdvTipoArticulo.ViewName = "tbMaestroTipoArticulo"
        '
        'AdvFamiliaArticulo
        '
        Me.AdvFamiliaArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamiliaArticulo.EntityName = "Familia"
        Me.AdvFamiliaArticulo.Location = New System.Drawing.Point(274, 74)
        Me.AdvFamiliaArticulo.Name = "AdvFamiliaArticulo"
        Me.AdvFamiliaArticulo.SecondaryDataFields = "IDFamilia"
        Me.AdvFamiliaArticulo.Size = New System.Drawing.Size(100, 23)
        Me.AdvFamiliaArticulo.TabIndex = 143
        Me.AdvFamiliaArticulo.ViewName = "tbMaestroFamilia"
        '
        'CIFacturacion
        '
        Me.ClientSize = New System.Drawing.Size(783, 600)
        Me.Name = "CIFacturacion"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        CType(Me.cbxAgrupFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTipoFactura.ResumeLayout(False)
        Me.pnlTipoFactura.PerformLayout()
        CType(Me.cbxTipoFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEstadoCertificacion.ResumeLayout(False)
        Me.pnlEstadoCertificacion.PerformLayout()
        CType(Me.cbxEstadoCertificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOperario.ResumeLayout(False)
        Me.pnlOperario.PerformLayout()
        Me.pnlEstado.ResumeLayout(False)
        Me.pnlEstado.PerformLayout()
        Me.pnlCriteriosSeleccion.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TabFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFacturacion.ResumeLayout(False)
        Me.TabPageHitos.ResumeLayout(False)
        CType(Me.GridVtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageHoras.ResumeLayout(False)
        CType(Me.GridMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageGastos.ResumeLayout(False)
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCertificacion.ResumeLayout(False)
        CType(Me.GridCertificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTipoAgrupacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFechaVto.ResumeLayout(False)
        Me.pnlFechaVto.PerformLayout()
        Me.pnlConfigFacturacion.ResumeLayout(False)
        Me.pnlConfigFacturacion.PerformLayout()
        Me.TabPageMateriales.ResumeLayout(False)
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotales.ResumeLayout(False)
        Me.pnlTotales.PerformLayout()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.pnlConfigAlquiler.ResumeLayout(False)
        Me.pnlConfigAlquiler.PerformLayout()
        Me.pnlClienteEventual.ResumeLayout(False)
        Me.pnlClienteEventual.PerformLayout()
        CType(Me.cbxClienteEventual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEstadoOT.ResumeLayout(False)
        Me.pnlEstadoOT.PerformLayout()
        CType(Me.cbxEstadoOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTipoOT.ResumeLayout(False)
        Me.pnlTipoOT.PerformLayout()
        CType(Me.cbxTipoOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPeriodoFactura.ResumeLayout(False)
        Me.pnlPeriodoFactura.PerformLayout()
        CType(Me.cbxPeriodoFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAlquiler.ResumeLayout(False)
        CType(Me.GridAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageTallerAlquiler.ResumeLayout(False)
        CType(Me.GridTallerAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAlbaran.ResumeLayout(False)
        CType(Me.GridAlbaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAlbaran.ResumeLayout(False)
        Me.pnlAlbaran.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlConfigAlquiler As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cbxFechaCalculo As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaCalculo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chkFacturarOrdenesCerradas As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkTenerEnCuenta As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents txtDiaFacturacion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblDiaFacturacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chkCalculoSeguros As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents pnlClienteEventual As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblClienteEventual As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxClienteEventual As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents pnlEstadoOT As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents cbxEstadoOT As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblEstadoOT As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlTipoOT As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents cbxTipoOT As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblTipoOT As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvOTHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblOTHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvOTDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblOTDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxPeriodoFacturacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblPeriodoFacturacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TabPageAlquiler As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageTallerAlquiler As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridAlquiler As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridTallerAlquiler As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents pnlPeriodoFactura As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents TabPageAlbaran As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridAlbaran As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents advIDAlbaran As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents pnlAlbaran As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblAlbaran As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvFamiliaArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTipoArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Familia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Tipo As Solmicro.Expertis.Engine.UI.Label

End Class
