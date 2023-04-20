Public Class MntoAlbaranVenta
    Inherits Solmicro.Expertis.Application.ERP.AlbaranVenta.MntoAlbaranVenta

#Region "Código generado por el diseñador"

    Public Sub New()
        MyBase.New()
        InitializeComponent()
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
    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblUbicacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TabPagePicContadores As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents gridMedidas As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmbUbicacionMaterial As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblNAlquiler As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNAlquiler As Solmicro.Expertis.Engine.UI.AdvSearch

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cmbDetalles_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoAlbaranVenta))
        Dim FwiEmpresaDAA_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim FwiEmpresaNotaTransporte_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbCentroCoste_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbResponsable_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridLineaAlbaran_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbCentroGestion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridMedidas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbUbicacionMaterial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.lblUbicacion = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPagePicContadores = New Janus.Windows.UI.Tab.UITabPage
        Me.gridMedidas = New Solmicro.Expertis.Engine.UI.Grid
        Me.cmbUbicacionMaterial = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblNAlquiler = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNAlquiler = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TabPageEnvios.SuspendLayout()
        Me.pnlEnviosTop.suspendlayout()
        Me.FraCondEnvio.SuspendLayout()
        Me.FraPesos.SuspendLayout()
        Me.FraEDI.SuspendLayout()
        Me.FraDocumentos.SuspendLayout()
        Me.FraDirCliente.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.fraTPV.SuspendLayout()
        Me.FraAlbaran.SuspendLayout()
        Me.FraTipoAlbaran.SuspendLayout()
        Me.FraCliente.SuspendLayout()
        Me.PnlCondEconomicas.SuspendLayout()
        Me.FrmValorAlb.SuspendLayout()
        Me.FrmCondicEcon.SuspendLayout()
        Me.TabPageAnotaciones.SuspendLayout()
        Me.FraGastos.SuspendLayout()
        CType(Me.PnlRiesgo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmCentros.SuspendLayout()
        Me.FrmDAA.SuspendLayout()
        CType(Me.FwiEmpresaDAA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmNotaTransporte.SuspendLayout()
        CType(Me.FwiEmpresaNotaTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraDistribuidor.SuspendLayout()
        Me.FraAbonoDistrib.SuspendLayout()
        Me.FrmDatosAnexoDAA.SuspendLayout()
        CType(Me.TabAlbaranes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAlbaranes.SuspendLayout()
        CType(Me.CmbCentroCoste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicLineas.SuspendLayout()
        Me.TabPagePicDatosEconomicos.SuspendLayout()
        Me.TabPagePicSeguimiento.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCabecera.suspendlayout()
        CType(Me.CmbResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTotales.suspendlayout()
        CType(Me.GridLineaAlbaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmResEcon.SuspendLayout()
        Me.FrmFactGeneradas.SuspendLayout()
        Me.pnlSeguimiento.suspendlayout()
        Me.FrmAlbComp.SuspendLayout()
        Me.TabPagePicVarios.SuspendLayout()
        CType(Me.LineDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFactGeneradas.suspendlayout()
        Me.PnlEnvios.suspendlayout()
        Me.PnlVarios.suspendlayout()
        CType(Me.CmbCentroGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.TabPagePicContadores.SuspendLayout()
        CType(Me.gridMedidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUbicacionMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MLotes
        '
        Me.MLotes.Location = New System.Drawing.Point(182, 182)
        Me.MLotes.Text = "Lotes"
        '
        'fraTPV
        '
        Me.fraTPV.Location = New System.Drawing.Point(6, 47)
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(452, 113)
        '
        'AdvObra
        '
        Me.AdvObra.Location = New System.Drawing.Point(545, 110)
        Me.AdvObra.Size = New System.Drawing.Size(186, 23)
        '
        'ULblDescCliente
        '
        Me.ULblDescCliente.Location = New System.Drawing.Point(259, 12)
        Me.ULblDescCliente.Size = New System.Drawing.Size(243, 21)
        '
        'LblDireccion
        '
        Me.LblDireccion.Location = New System.Drawing.Point(8, 66)
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(107, 62)
        Me.TxtDireccion.Size = New System.Drawing.Size(541, 21)
        '
        'TxtPoblacion
        '
        Me.TxtPoblacion.Location = New System.Drawing.Point(107, 86)
        Me.TxtPoblacion.Size = New System.Drawing.Size(272, 21)
        '
        'LblRazonSocial
        '
        Me.LblRazonSocial.Location = New System.Drawing.Point(8, 41)
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(107, 38)
        Me.TxtRazonSocial.Size = New System.Drawing.Size(624, 21)
        '
        'TxtProvincia
        '
        Me.TxtProvincia.Location = New System.Drawing.Point(383, 86)
        Me.TxtProvincia.Size = New System.Drawing.Size(175, 21)
        '
        'TxtCodPostal
        '
        Me.TxtCodPostal.Location = New System.Drawing.Point(652, 62)
        Me.TxtCodPostal.Size = New System.Drawing.Size(79, 21)
        '
        'LblCliente
        '
        Me.LblCliente.Location = New System.Drawing.Point(8, 16)
        '
        'AdvIDCliente
        '
        Me.AdvIDCliente.Location = New System.Drawing.Point(107, 12)
        Me.AdvIDCliente.Size = New System.Drawing.Size(145, 23)
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(563, 86)
        Me.txtPais.Size = New System.Drawing.Size(169, 21)
        '
        'lblCIF
        '
        Me.lblCIF.Location = New System.Drawing.Point(510, 17)
        '
        'txtCIF
        '
        Me.txtCIF.Location = New System.Drawing.Point(606, 14)
        Me.txtCIF.Size = New System.Drawing.Size(126, 21)
        '
        'FraTipoAlbaran
        '
        Me.FraTipoAlbaran.Location = New System.Drawing.Point(862, 0)
        '
        'FraCliente
        '
        Me.FraCliente.Size = New System.Drawing.Size(739, 167)
        '
        'ulAbreviaturaMoneda
        '
        Me.ulAbreviaturaMoneda.Location = New System.Drawing.Point(984, 5)
        Me.ulAbreviaturaMoneda.Size = New System.Drawing.Size(39, 21)
        '
        'PnlCondEconomicas
        '
        Me.PnlCondEconomicas.Size = New System.Drawing.Size(394, 349)
        '
        'FraGastos
        '
        Me.FraGastos.Location = New System.Drawing.Point(6, 94)
        '
        'PnlRiesgo
        '
        Me.ToolTipMensajes.SetToolTip(Me.PnlRiesgo, "Este Cliente ha superado el Riesgo")
        '
        'cmbDetalles
        '
        cmbDetalles_DesignTimeLayout.LayoutString = resources.GetString("cmbDetalles_DesignTimeLayout.LayoutString")
        Me.cmbDetalles.DesignTimeLayout = cmbDetalles_DesignTimeLayout
        '
        'FwiEmpresaDAA
        '
        FwiEmpresaDAA_DesignTimeLayout.LayoutString = resources.GetString("FwiEmpresaDAA_DesignTimeLayout.LayoutString")
        Me.FwiEmpresaDAA.DesignTimeLayout = FwiEmpresaDAA_DesignTimeLayout
        '
        'FwiEmpresaNotaTransporte
        '
        FwiEmpresaNotaTransporte_DesignTimeLayout.LayoutString = resources.GetString("FwiEmpresaNotaTransporte_DesignTimeLayout.LayoutString")
        Me.FwiEmpresaNotaTransporte.DesignTimeLayout = FwiEmpresaNotaTransporte_DesignTimeLayout
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(330, 142)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 143)
        '
        'MSeries
        '
        Me.MSeries.Location = New System.Drawing.Point(208, 208)
        '
        'TabAlbaranes
        '
        Me.TabAlbaranes.Size = New System.Drawing.Size(1032, 384)
        Me.TabAlbaranes.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPagePicContadores})
        Me.TabAlbaranes.Controls.SetChildIndex(Me.TabPageAnotaciones, 0)
        Me.TabAlbaranes.Controls.SetChildIndex(Me.TabPageEnvios, 0)
        Me.TabAlbaranes.Controls.SetChildIndex(Me.TabPagePicVarios, 0)
        Me.TabAlbaranes.Controls.SetChildIndex(Me.TabPagePicContadores, 0)
        Me.TabAlbaranes.Controls.SetChildIndex(Me.TabPagePicSeguimiento, 0)
        Me.TabAlbaranes.Controls.SetChildIndex(Me.TabPagePicDatosEconomicos, 0)
        Me.TabAlbaranes.Controls.SetChildIndex(Me.TabPagePicLineas, 0)
        '
        'CmbCentroCoste
        '
        CmbCentroCoste_DesignTimeLayout.LayoutString = resources.GetString("CmbCentroCoste_DesignTimeLayout.LayoutString")
        Me.CmbCentroCoste.DesignTimeLayout = CmbCentroCoste_DesignTimeLayout
        Me.CmbCentroCoste.DisplayMember = ""
        Me.CmbCentroCoste.ValueMember = ""
        '
        'TabPagePicLineas
        '
        Me.TabPagePicLineas.Size = New System.Drawing.Size(1030, 362)
        '
        'TabPagePicDatosEconomicos
        '
        Me.TabPagePicDatosEconomicos.Size = New System.Drawing.Size(878, 349)
        '
        'TabPagePicSeguimiento
        '
        Me.TabPagePicSeguimiento.Size = New System.Drawing.Size(878, 349)
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Location = New System.Drawing.Point(231, 120)
        '
        'PnlCabecera
        '
        Me.PnlCabecera.Size = New System.Drawing.Size(1032, 167)
        '
        'LblProveedorServicios
        '
        Me.LblProveedorServicios.Location = New System.Drawing.Point(6, 84)
        '
        'LblTelefono
        '
        Me.LblTelefono.Location = New System.Drawing.Point(8, 113)
        '
        'CmbResponsable
        '
        CmbResponsable_DesignTimeLayout.LayoutString = resources.GetString("CmbResponsable_DesignTimeLayout.LayoutString")
        Me.CmbResponsable.DesignTimeLayout = CmbResponsable_DesignTimeLayout
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(107, 110)
        Me.TxtTelefono.Size = New System.Drawing.Size(135, 21)
        '
        'LblFax
        '
        Me.LblFax.Location = New System.Drawing.Point(269, 113)
        '
        'TxtFax
        '
        Me.TxtFax.Location = New System.Drawing.Point(310, 110)
        Me.TxtFax.Size = New System.Drawing.Size(135, 21)
        '
        'AdvProveedorServicios
        '
        Me.AdvProveedorServicios.Location = New System.Drawing.Point(8, 92)
        Me.AdvProveedorServicios.Size = New System.Drawing.Size(38, 23)
        '
        'ULblProveedorServicios
        '
        Me.ULblProveedorServicios.Location = New System.Drawing.Point(48, 87)
        Me.ULblProveedorServicios.Size = New System.Drawing.Size(35, 23)
        '
        'PnlTotales
        '
        Me.PnlTotales.Location = New System.Drawing.Point(0, 330)
        Me.PnlTotales.Size = New System.Drawing.Size(1030, 32)
        '
        'LblImporteTotal
        '
        Me.LblImporteTotal.Location = New System.Drawing.Point(739, 9)
        '
        'NtbImporteTotal
        '
        Me.NtbImporteTotal.Location = New System.Drawing.Point(842, 5)
        Me.NtbImporteTotal.Size = New System.Drawing.Size(134, 21)
        '
        'GridLineaAlbaran
        '
        GridLineaAlbaran_DesignTimeLayout.LayoutString = resources.GetString("GridLineaAlbaran_DesignTimeLayout.LayoutString")
        Me.GridLineaAlbaran.DesignTimeLayout = GridLineaAlbaran_DesignTimeLayout
        Me.GridLineaAlbaran.Size = New System.Drawing.Size(1030, 330)
        '
        'FrmResEcon
        '
        Me.FrmResEcon.Size = New System.Drawing.Size(484, 349)
        '
        'LblDtoAlb
        '
        Me.LblDtoAlb.Location = New System.Drawing.Point(15, 50)
        '
        'LblProntoPago
        '
        Me.LblProntoPago.Location = New System.Drawing.Point(15, 69)
        '
        'LblPorcenRecFinan
        '
        Me.LblPorcenRecFinan.Location = New System.Drawing.Point(175, 112)
        '
        'LblPorcenDtoAlb
        '
        Me.LblPorcenDtoAlb.Location = New System.Drawing.Point(175, 50)
        '
        'LblPorcenProntoPago
        '
        Me.LblPorcenProntoPago.Location = New System.Drawing.Point(175, 69)
        '
        'LblRecFinan
        '
        Me.LblRecFinan.Location = New System.Drawing.Point(15, 112)
        '
        'NtbDtoAlbaran
        '
        Me.NtbDtoAlbaran.Location = New System.Drawing.Point(103, 50)
        '
        'NtbRecFinan
        '
        Me.NtbRecFinan.Location = New System.Drawing.Point(103, 112)
        '
        'NtbDtoProntoPago
        '
        Me.NtbDtoProntoPago.Location = New System.Drawing.Point(103, 69)
        '
        'NtbImpRecFinan
        '
        Me.NtbImpRecFinan.Location = New System.Drawing.Point(351, 112)
        '
        'NtbIVA
        '
        Me.NtbIVA.Location = New System.Drawing.Point(351, 74)
        '
        'NtbRE
        '
        Me.NtbRE.Location = New System.Drawing.Point(351, 93)
        '
        'NtbImporteAlbaran
        '
        Me.NtbImporteAlbaran.Location = New System.Drawing.Point(351, 136)
        '
        'NtbImpTotalLineasRes
        '
        Me.NtbImpTotalLineasRes.Location = New System.Drawing.Point(351, 32)
        '
        'NtbBaseImponible
        '
        Me.NtbBaseImponible.Location = New System.Drawing.Point(351, 56)
        '
        'FrmFactGeneradas
        '
        Me.FrmFactGeneradas.Size = New System.Drawing.Size(382, 349)
        '
        'TabPagePicVarios
        '
        Me.TabPagePicVarios.Size = New System.Drawing.Size(878, 349)
        '
        'LblDescMonedaA
        '
        Me.LblDescMonedaA.Location = New System.Drawing.Point(605, 198)
        '
        'LineDescuentos
        '
        Me.LineDescuentos.Location = New System.Drawing.Point(231, 50)
        '
        'PnlFactGeneradas
        '
        Me.PnlFactGeneradas.Size = New System.Drawing.Size(382, 349)
        '
        'PnlEnvios
        '
        Me.PnlEnvios.Size = New System.Drawing.Size(496, 349)
        '
        'PnlVarios
        '
        Me.PnlVarios.Size = New System.Drawing.Size(878, 349)
        '
        'CmbCentroGestion
        '
        CmbCentroGestion_DesignTimeLayout.LayoutString = resources.GetString("CmbCentroGestion_DesignTimeLayout.LayoutString")
        Me.CmbCentroGestion.DesignTimeLayout = CmbCentroGestion_DesignTimeLayout
        '
        'LblImpTotal
        '
        Me.LblImpTotal.Location = New System.Drawing.Point(231, 136)
        '
        'LblImpRecFinan
        '
        Me.LblImpRecFinan.Location = New System.Drawing.Point(231, 112)
        '
        'LblIVA
        '
        Me.LblIVA.Location = New System.Drawing.Point(231, 74)
        '
        'LblRE
        '
        Me.LblRE.Location = New System.Drawing.Point(231, 93)
        '
        'LblImpLineasSeg
        '
        Me.LblImpLineasSeg.Location = New System.Drawing.Point(231, 32)
        '
        'LblBaseImponible
        '
        Me.LblBaseImponible.Location = New System.Drawing.Point(231, 56)
        '
        'TvFacturasGeneradas
        '
        Me.TvFacturasGeneradas.LineColor = System.Drawing.Color.Black
        Me.TvFacturasGeneradas.Size = New System.Drawing.Size(376, 329)
        '
        'ImgList
        '
        Me.ImgList.ImageStream = CType(resources.GetObject("ImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgList.Images.SetKeyName(0, "")
        Me.ImgList.Images.SetKeyName(1, "note_edit.ico")
        Me.ImgList.Images.SetKeyName(2, "users4.ico")
        Me.ImgList.Images.SetKeyName(3, "folders.ico")
        Me.ImgList.Images.SetKeyName(4, "cubes_yellow.ico")
        Me.ImgList.Images.SetKeyName(5, "BarCode.ico")
        '
        'ToolBar
        '
        Me.ToolBar.Location = New System.Drawing.Point(22, 26)
        '
        'MenuBar
        '
        Me.MenuBar.Size = New System.Drawing.Size(1040, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(1032, 551)
        '
        'lblUbicacion
        '
        Me.lblUbicacion.Location = New System.Drawing.Point(528, 112)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(58, 17)
        Me.lblUbicacion.TabIndex = 121
        Me.lblUbicacion.Text = "Ubicación"
        '
        'TabPagePicContadores
        '
        Me.TabPagePicContadores.Controls.Add(Me.gridMedidas)
        Me.TabPagePicContadores.Key = "Lectura"
        Me.TabPagePicContadores.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicContadores.Name = "TabPagePicContadores"
        Me.TabPagePicContadores.Size = New System.Drawing.Size(878, 349)
        Me.TabPagePicContadores.TabStop = True
        Me.TabPagePicContadores.Text = "Lectura de Contadores"
        '
        'gridMedidas
        '
        Me.gridMedidas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridMedidas_DesignTimeLayout.LayoutString = resources.GetString("gridMedidas_DesignTimeLayout.LayoutString")
        Me.gridMedidas.DesignTimeLayout = gridMedidas_DesignTimeLayout
        Me.gridMedidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridMedidas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.gridMedidas.EntityName = "AlbaranVentaLinea"
        Me.gridMedidas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridMedidas.Location = New System.Drawing.Point(0, 0)
        Me.gridMedidas.Name = "gridMedidas"
        Me.gridMedidas.PrimaryDataFields = "IDAlbaran"
        Me.gridMedidas.RequeryManually = True
        Me.gridMedidas.SecondaryDataFields = "IDAlbaran"
        Me.gridMedidas.Size = New System.Drawing.Size(878, 349)
        Me.gridMedidas.TabIndex = 0
        Me.gridMedidas.ViewName = "vAlquilerMntoAlbaranLecturaContadores"
        '
        'cmbUbicacionMaterial
        '
        Me.TryDataBinding(cmbUbicacionMaterial, New System.Windows.Forms.Binding("Value", Me, "UbicacionMaterial", True))
        cmbUbicacionMaterial_DesignTimeLayout.LayoutString = resources.GetString("cmbUbicacionMaterial_DesignTimeLayout.LayoutString")
        Me.cmbUbicacionMaterial.DesignTimeLayout = cmbUbicacionMaterial_DesignTimeLayout
        Me.cmbUbicacionMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.cmbUbicacionMaterial.DisplayMember = "Value"
        Me.cmbUbicacionMaterial.Location = New System.Drawing.Point(600, 112)
        Me.cmbUbicacionMaterial.Name = "cmbUbicacionMaterial"
        Me.cmbUbicacionMaterial.PrimaryDataFields = "Estado"
        Me.cmbUbicacionMaterial.SecondaryDataFields = "Value"
        Me.cmbUbicacionMaterial.SelectedIndex = -1
        Me.cmbUbicacionMaterial.SelectedItem = Nothing
        Me.cmbUbicacionMaterial.Size = New System.Drawing.Size(88, 21)
        Me.cmbUbicacionMaterial.TabIndex = 12
        '
        'lblNAlquiler
        '
        Me.lblNAlquiler.Location = New System.Drawing.Point(506, 83)
        Me.lblNAlquiler.Name = "lblNAlquiler"
        Me.lblNAlquiler.Size = New System.Drawing.Size(66, 17)
        Me.lblNAlquiler.TabIndex = 133
        Me.lblNAlquiler.Text = "Nº Alquiler"
        '
        'txtNAlquiler
        '
        Me.txtNAlquiler.DisabledBackColor = System.Drawing.Color.White
        Me.txtNAlquiler.DisplayField = "NObra"
        Me.txtNAlquiler.Enabled = False
        Me.txtNAlquiler.EntityName = "ObraCabecera"
        Me.txtNAlquiler.Location = New System.Drawing.Point(576, 80)
        Me.txtNAlquiler.Name = "txtNAlquiler"
        Me.txtNAlquiler.PrimaryDataFields = "IDObra"
        Me.txtNAlquiler.SecondaryDataFields = "IDObra"
        Me.txtNAlquiler.Size = New System.Drawing.Size(112, 23)
        Me.txtNAlquiler.TabIndex = 66
        Me.txtNAlquiler.TabStop = False
        '
        'MntoAlbaranVenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1040, 637)
        Me.Name = "MntoAlbaranVenta"
        Me.TabPageEnvios.ResumeLayout(False)
        Me.pnlEnviosTop.ResumeLayout(False)
        Me.FraCondEnvio.ResumeLayout(False)
        Me.FraCondEnvio.PerformLayout()
        Me.FraPesos.ResumeLayout(False)
        Me.FraPesos.PerformLayout()
        Me.FraEDI.ResumeLayout(False)
        Me.FraEDI.PerformLayout()
        Me.FraDocumentos.ResumeLayout(False)
        Me.FraDocumentos.PerformLayout()
        Me.FraDirCliente.ResumeLayout(False)
        Me.FraDirCliente.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.fraTPV.ResumeLayout(False)
        Me.fraTPV.PerformLayout()
        Me.FraAlbaran.ResumeLayout(False)
        Me.FraAlbaran.PerformLayout()
        Me.FraTipoAlbaran.ResumeLayout(False)
        Me.FraTipoAlbaran.PerformLayout()
        Me.FraCliente.ResumeLayout(False)
        Me.FraCliente.PerformLayout()
        Me.PnlCondEconomicas.ResumeLayout(False)
        Me.FrmValorAlb.ResumeLayout(False)
        Me.FrmValorAlb.PerformLayout()
        Me.FrmCondicEcon.ResumeLayout(False)
        Me.FrmCondicEcon.PerformLayout()
        Me.TabPageAnotaciones.ResumeLayout(False)
        Me.TabPageAnotaciones.PerformLayout()
        Me.FraGastos.ResumeLayout(False)
        Me.FraGastos.PerformLayout()
        CType(Me.PnlRiesgo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmCentros.ResumeLayout(False)
        Me.FrmCentros.PerformLayout()
        Me.FrmDAA.ResumeLayout(False)
        Me.FrmDAA.PerformLayout()
        CType(Me.FwiEmpresaDAA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmNotaTransporte.ResumeLayout(False)
        Me.FrmNotaTransporte.PerformLayout()
        CType(Me.FwiEmpresaNotaTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraDistribuidor.ResumeLayout(False)
        Me.FraDistribuidor.PerformLayout()
        Me.FraAbonoDistrib.ResumeLayout(False)
        Me.FraAbonoDistrib.PerformLayout()
        Me.FrmDatosAnexoDAA.ResumeLayout(False)
        Me.FrmDatosAnexoDAA.PerformLayout()
        CType(Me.TabAlbaranes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAlbaranes.ResumeLayout(False)
        CType(Me.CmbCentroCoste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicLineas.ResumeLayout(False)
        Me.TabPagePicLineas.PerformLayout()
        Me.TabPagePicDatosEconomicos.ResumeLayout(False)
        Me.TabPagePicSeguimiento.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCabecera.ResumeLayout(False)
        CType(Me.CmbResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTotales.ResumeLayout(False)
        Me.PnlTotales.PerformLayout()
        CType(Me.GridLineaAlbaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmResEcon.ResumeLayout(False)
        Me.FrmResEcon.PerformLayout()
        Me.FrmFactGeneradas.ResumeLayout(False)
        Me.pnlSeguimiento.ResumeLayout(False)
        Me.FrmAlbComp.ResumeLayout(False)
        Me.FrmAlbComp.PerformLayout()
        Me.TabPagePicVarios.ResumeLayout(False)
        CType(Me.LineDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFactGeneradas.ResumeLayout(False)
        Me.PnlEnvios.ResumeLayout(False)
        Me.PnlVarios.ResumeLayout(False)
        CType(Me.CmbCentroGestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.TabPagePicContadores.ResumeLayout(False)
        CType(Me.gridMedidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUbicacionMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mIDContador, mIDTipoAlbaranRetornoAlquiler, mIDTipoAlbaranDeposito As String

    Private Enum TipoMensaje
        OK = 0
        CantidadVacia = -1
        CantidadNegativa = -2
        CantidadVaciaOnegativa = -3
        LoteObligatorio = -4
        AlmacenDeposito = -5
        FechaVacia = -6
        SinOperario = -8
    End Enum

#Region " Load "

    Private Sub MntoAlbaranVenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadEnums()
            LoadGridActions()
            LoadParametros()

            lblObra.Visible = False
            AdvObra.Visible = False
        End If
    End Sub

    Private Sub LoadEnums()
        cmbUbicacionMaterial.DataSource = New EnumData("enumavUbicacionMat")
    End Sub

    Private Sub LoadGridActions()
        GridLineaAlbaran.Actions.Add("Condiciones de Portes", AddressOf AccionCondicionesPortes)
    End Sub

    Private Sub LoadParametros()
        Dim p As New Parametro
        mIDTipoAlbaranRetornoAlquiler = p.TipoAlbaranRetornoAlquiler()
        mIDTipoAlbaranDeposito = p.TipoAlbaranDeDeposito

        mIDContador = ExpertisApp.ExecuteTask(Of ContadorEntidad, String)(AddressOf CentroGestion.GetContadorPredeterminadoCGestionUsuario, CentroGestion.ContadorEntidad.AlbaranVenta)
    End Sub

    Protected Overrides Sub LoadToolbarActions()
        MyBase.LoadToolbarActions()
        Me.FormActions.Add("Retornar Albarán", AddressOf GenerarAlbaranRetorno, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
        Me.FormActions.Add("Imprimir Documentacion Asociada (Alquiler)", AddressOf ImprimirDocumentacionAsociada, ExpertisApp.GetIcon("printer2.ico"))
    End Sub

#End Region

#Region " GridActions "

    Private Sub AccionCondicionesPortes()
        With GridLineaAlbaran
            If Length(.Value("IDObra")) > 0 Then
                Dim frm As New frmCondicionesAlquiler
                frm.AbrirFormulario(.Value("IDObra"))
            End If
        End With
    End Sub

#End Region

#Region " ToolbarActions "

#Region " GenerarAlbaranRetorno "

    Private Sub GenerarAlbaranRetorno()
        Dim Cancel As Boolean = False
        If GridLineaAlbaran.RowCount() > 0 Then
            Dim frm As New frmAsignaFechaHora
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim dtFechaRetorno As Date = frm.Fecha
                Dim dtHoraRetorno As Date = frm.Hora

                Dim dtRetornos As DataTable = New BE.DataEngine().Filter("vAlquilerCIRetornos", New NumberFilterItem("IDAlbaran", CurrentRow("IDAlbaran")), , "IDObra DESC, FechaAlbaran DESC")
                If Not IsNothing(dtRetornos) AndAlso dtRetornos.Rows.Count > 0 Then
                    Dim dt As DataTable = Nothing
                    Dim logMensaje As Integer = LeerGridAlbaran(dt, dtRetornos, dtFechaRetorno, dtHoraRetorno)
                    If TratamientoMensajesLeerGrid(logMensaje) Then
                        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                            Me.Cursor = Cursors.WaitCursor
                            Dim IDTipoAlbaran As String = New Parametro().TipoAlbaranRetornoAlquiler
                            Dim strEstadoActivoRetorno As String = New Parametro().EstadoActivoRetornosPorDefecto
                            Dim aExpedir() As CrearAlbaranVentaInfo = DatosExpedir(dt, dtFechaRetorno, dtHoraRetorno, strEstadoActivoRetorno)

                            Dim data As New DataPrcAlbaranar(aExpedir, mIDContador, , IDTipoAlbaran, enumTipoExpedicion.teAlquiler)
                            Dim Propuesta As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                            If Not IsNothing(Propuesta) Then
                                If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                                    Dim frmPropuesta As New frmAlbaranProvisional
                                    Dim dr As DialogResult = frmPropuesta.AbrirFormulario(Propuesta.PropuestaAlbaranes)
                                    If dr = DialogResult.OK Then
                                        Me.Cursor = Cursors.WaitCursor

                                        Dim datosAct As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                                        Dim rslt As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquiler), datosAct)
                                        TratarLog(rslt.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True, rslt.StockUpdateData)

                                        ActivaRetornoAlbaran()

                                        Me.Cursor = Cursors.Default
                                    Else
                                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                Else
                                    TratarLog(Propuesta.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                                End If
                            Else
                                ExpertisApp.GenerateMessage("No se ha podido generar el Albarán.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        Else
                            ExpertisApp.GenerateMessage("No hay lineas a procesar. Las líneas seleccionadas tienen cantidad cero.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        Cancel = True
                    End If
                Else
                    Cancel = True
                End If
            Else
                Cancel = True
            End If
        End If
        If Cancel Then ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function LeerGridAlbaran(ByRef dt As DataTable, ByVal dtRetornos As DataTable, ByVal dtFecharetorno As Date, ByVal dtHoraRetorno As Date) As Integer
        Dim blnAlmacenVacio As Boolean
        Dim blnFechavacia As Boolean

        Dim IDOperario As String = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf Operario.ObtenerIDOperarioUsuario, Nothing)

        If Length(IDOperario) = 0 Then
            LeerGridAlbaran = TipoMensaje.SinOperario
            Exit Function
        End If

        dt = New DataTable
        Dim dr As DataRow
        dt.Columns.Add(New DataColumn("IDLineaAlbaran", GetType(Integer)))
        dt.Columns.Add(New DataColumn("IDObra", GetType(Integer)))
        dt.Columns.Add(New DataColumn("QAlbaran", GetType(Double)))
        dt.Columns.Add(New DataColumn("QInterna", GetType(Double)))
        dt.Columns.Add(New DataColumn("IDAlbaran", GetType(Integer)))
        dt.Columns.Add(New DataColumn("IDAlmacenDeposito", GetType(String)))
        dt.Columns.Add(New DataColumn("IDAlmacen", GetType(String)))
        dt.Columns.Add(New DataColumn("IDCliente", GetType(String)))
        dt.Columns.Add(New DataColumn("IDMoneda", GetType(String)))
        dt.Columns.Add(New DataColumn("IDFormaPago", GetType(String)))
        dt.Columns.Add(New DataColumn("IDCondicionPago", GetType(String)))
        dt.Columns.Add(New DataColumn("IDFormaEnvio", GetType(String)))
        dt.Columns.Add(New DataColumn("IDCondicionEnvio", GetType(String)))
        dt.Columns.Add(New DataColumn("IDDireccion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("IDLineaMaterial", GetType(Integer)))
        dt.Columns.Add(New DataColumn("Serie", GetType(String)))
        dt.Columns.Add(New DataColumn("SerieIndividual", GetType(String)))
        dt.Columns.Add(New DataColumn("Lote", GetType(String)))
        dt.Columns.Add(New DataColumn("Fecha", GetType(Date)))
        dt.Columns.Add(New DataColumn("FechaPrevistaRetorno", GetType(Date)))
        dt.Columns.Add(New DataColumn("FechaAlquiler", GetType(Date)))
        dt.Columns.Add(New DataColumn("HoraAlquiler", GetType(Date)))
        dt.Columns.Add(New DataColumn("IDUdMedida", GetType(String)))
        dt.Columns.Add(New DataColumn("IDUdInterna", GetType(String)))
        dt.Columns.Add(New DataColumn("NumeroPedido", GetType(String)))
        dt.Columns.Add(New DataColumn("IDOperario", GetType(String)))
        dt.Columns.Add(New DataColumn("IDEstadoActivo", GetType(String)))
        dt.Columns.Add(New DataColumn("IDDireccionOT", GetType(Integer)))
        dt.Columns.Add(New DataColumn("IDCentroGestion", GetType(String)))
        dt.Columns.Add(New DataColumn("IDTrabajo", GetType(Integer)))
        dt.Columns.Add(New DataColumn("NoFacturarDiasMinimos", GetType(Integer)))
        dt.Columns.Add(New DataColumn("TextoPublico", GetType(String)))

        If dtRetornos.Rows.Count > 0 Then
            LeerGridAlbaran = TipoMensaje.OK
            For Each drRetornos As DataRow In dtRetornos.Rows

                If Length(drRetornos("IDAlmacenDeposito")) = 0 Then
                    LeerGridAlbaran = TipoMensaje.AlmacenDeposito
                    blnAlmacenVacio = True
                Else
                    If Length(drRetornos("FechaAlbaran")) > 0 And Length(dtFecharetorno) > 0 Then
                        If Length(drRetornos("Qinterna")) > 0 Then
                            If drRetornos("Qinterna") <> 0 Then
                                'Puede ser Positivo o Negativo
                                If drRetornos("Qinterna") < 0 Then
                                    If LeerGridAlbaran = TipoMensaje.OK Then
                                        LeerGridAlbaran = TipoMensaje.CantidadNegativa
                                    ElseIf LeerGridAlbaran = TipoMensaje.CantidadVacia Then
                                        LeerGridAlbaran = TipoMensaje.CantidadVaciaOnegativa
                                    End If
                                End If

                                dr = dt.NewRow
                                dr("IDLineaAlbaran") = drRetornos("IDLineaAlbaran")
                                If Length(drRetornos("IDObra")) > 0 Then dr("IDObra") = drRetornos("IDObra")
                                'A partir de ahora, esta QAlbaran que aparece aquí, siempre hace referencia  a la QInterna
                                dr("QAlbaran") = drRetornos("Qinterna")
                                dr("IDAlbaran") = drRetornos("IDAlbaran")
                                dr("IDCliente") = drRetornos("IDCliente")
                                dr("IDMoneda") = drRetornos("IDMoneda")
                                dr("fecha") = dtFecharetorno
                                dr("FechaAlquiler") = dtFecharetorno
                                dr("HoraAlquiler") = dtHoraRetorno
                                dr("TextoPublico") = drRetornos("TextoPublico")
                                dr("NoFacturarDiasMinimos") = Nz(drRetornos("NoFacturarDiasMinimos"), 0)
                                dr("IDAlmacen") = drRetornos("IDAlmacen")

                                If Length(drRetornos("FechaPrevistaRetorno")) > 0 Then
                                    dr("FechaPrevistaRetorno") = drRetornos("FechaPrevistaRetorno")
                                End If
                                dr("NumeroPedido") = drRetornos("PedidoCliente")
                                'Son dos campos necesarios para AlbaranVentaLinea
                                dr("IDUDMedida") = drRetornos("IDUDMedida")
                                dr("IDUDInterna") = drRetornos("IDUDInterna")
                                dr("IDAlmacenDeposito") = drRetornos("IDAlmacenDeposito")
                                dr("IDFormaPago") = drRetornos("IDFormaPago")
                                dr("IdCondicionPago") = drRetornos("IdCondicionPago")
                                dr("IDFormaEnvio") = drRetornos("IDFormaEnvio")
                                dr("IdCondicionEnvio") = drRetornos("IdCondicionEnvio")
                                dr("IdDireccion") = drRetornos("IdDireccion")

                                dr("IdLineaMaterial") = drRetornos("IdLineaMaterial")
                                '///Gestion numeros de serie
                                If drRetornos("NSerieObligatorio") Then
                                    If Length(drRetornos("Lote")) > 0 Then
                                        dr("Serie") = drRetornos("Lote")
                                        dr("IdOperario") = drRetornos("IdOperario")
                                        dr("IDEstadoActivo") = drRetornos("IDEstadoActivo")
                                    Else
                                        ExpertisApp.GenerateMessage("El Nº de Serie es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Function
                                    End If
                                Else
                                    dr("Serie") = String.Empty
                                End If
                                dr("IdCentroGestion") = drRetornos("IdCentroGestion")
                                dr("IdDireccionOT") = drRetornos("IdDireccionOT")
                                dr("IdTrabajo") = drRetornos("IdTrabajo")

                                dt.Rows.Add(dr)
                                If LeerGridAlbaran = TipoMensaje.OK Then
                                    LeerGridAlbaran = TipoMensaje.CantidadVacia
                                ElseIf LeerGridAlbaran = TipoMensaje.CantidadNegativa Then
                                    LeerGridAlbaran = TipoMensaje.CantidadVaciaOnegativa
                                End If
                            End If
                        Else
                            LeerGridAlbaran = TipoMensaje.FechaVacia
                            blnFechavacia = True
                        End If
                    End If
                End If
            Next
        End If
    End Function

    Private Function TratamientoMensajesLeerGrid(ByVal tipo As TipoMensaje) As Boolean
        If tipo = TipoMensaje.OK Then
            TratamientoMensajesLeerGrid = True
        Else
            Select Case tipo
                Case TipoMensaje.FechaVacia
                    If ExpertisApp.GenerateMessage("Aquellas líneas que no tengan una Fecha Albarán y una Fecha Devolución no seran incluidos en el proceso de Generación de Albaranes de Consumo. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        TratamientoMensajesLeerGrid = True
                    Else
                        TratamientoMensajesLeerGrid = False
                    End If
                Case TipoMensaje.AlmacenDeposito
                    If ExpertisApp.GenerateMessage("Aquellas líneas que no tengan un Almacén Depósito no seran incluidos en el proceso de Generación de Albaranes de Consumo. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        TratamientoMensajesLeerGrid = True
                    Else
                        TratamientoMensajesLeerGrid = False
                    End If
                Case TipoMensaje.CantidadVacia
                    TratamientoMensajesLeerGrid = True
                Case TipoMensaje.CantidadVaciaOnegativa
                    If ExpertisApp.GenerateMessage("Los registros que no tengan una cantidad distinta de cero no generaran Albaranes. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        TratamientoMensajesLeerGrid = True
                        If ExpertisApp.GenerateMessage("Tiene cantidades negativas. ¿Es correcto?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            TratamientoMensajesLeerGrid = True
                        Else
                            TratamientoMensajesLeerGrid = False
                        End If
                    Else
                        TratamientoMensajesLeerGrid = False
                    End If
                Case TipoMensaje.CantidadNegativa
                    If ExpertisApp.GenerateMessage("Tiene cantidades negativas. ¿Es correcto?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        TratamientoMensajesLeerGrid = True
                    Else
                        TratamientoMensajesLeerGrid = False
                    End If
                Case TipoMensaje.LoteObligatorio
                    TratamientoMensajesLeerGrid = False
                    ExpertisApp.GenerateMessage("El Lote es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Case TipoMensaje.SinOperario
                    TratamientoMensajesLeerGrid = False
                    ExpertisApp.GenerateMessage("Proceso cancelado.| Es necesario asignar un Operario al Usuario,póngase en contacto con el departamento de informática.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, vbNewLine)
            End Select
        End If
    End Function

    Private Function DatosExpedir(ByVal dt As DataTable, ByVal dtFechaRetorno As Date, ByVal dtHoraRetorno As Date, ByVal IDEstadoActivo As String) As CrearAlbaranVentaInfo()
        Dim aExpedir(-1) As CrearAlbaranVentaInfo
        For Each selectedRow As DataRow In dt.Rows
            Dim datosExp As New CrearAlbaranVentaInfo
            datosExp.IDLinea = selectedRow("IDLineaAlbaran")
            datosExp.IDLineaMaterial = Nz(selectedRow("IDLineaMaterial"), 0)
            datosExp.Cantidad = selectedRow("QAlbaran")
            datosExp.IDCliente = selectedRow("IDCliente")

            If Length(IDEstadoActivo) > 0 Then
                datosExp.IDEstadoActivo = IDEstadoActivo
            End If

            If Length(dtFechaRetorno) > 0 Then
                datosExp.FechaAlquiler = dtFechaRetorno
            Else
                datosExp.FechaAlquiler = Date.Today
            End If
            If Length(dtHoraRetorno) > 0 Then
                datosExp.HoraAlquiler = dtHoraRetorno
            Else
                datosExp.HoraAlquiler = Date.Today.ToShortTimeString
            End If

            ReDim Preserve aExpedir(UBound(aExpedir) + 1)
            aExpedir(UBound(aExpedir)) = datosExp
        Next

        Return aExpedir
    End Function

    Private Sub ActivaRetornoAlbaran()
        Me.ExecuteActions.Commands("Retornar Albarán").Enabled = Janus.Windows.GridEX.InheritableBoolean.False
        If mIDTipoAlbaranDeposito = AdvTipoAlbaran.Value Then
            Dim dtPdte As DataTable = New BE.DataEngine().Filter("vAlquilerCIRetornos", New NumberFilterItem("IDAlbaran", Me.CurrentRow("IDAlbaran")), , "IDObra DESC, FechaAlbaran DESC")
            If Not IsNothing(dtPdte) AndAlso dtPdte.Rows.Count > 0 Then
                Me.ExecuteActions.Commands("Retornar Albarán").Enabled = Janus.Windows.GridEX.InheritableBoolean.True
            End If
        End If
    End Sub

    'Private Sub CargarLecturaContadores(ByVal dt As DataTable)
    '    Dim strAlbaran As String = dt.Rows(0)("IDAlbaran")
    '    Dim fltMnto As IFilter
    '    fltMnto = New StringFilterItem("IDAlbaran", FilterOperator.Equal, strAlbaran)
    '    If ExpertisApp.IsFormOpen("LCALB") Then ExpertisApp.CloseForm("LCALB")
    '    ExpertisApp.OpenForm("LCALB", fltMnto)
    'End Sub

    'Private Sub CargarAsignacionConductores(ByVal dt As DataTable)
    '    Dim frm As New frmAsignaConductor
    '    frm.mdtConductores = dt
    '    frm.ShowDialog()
    'End Sub

#End Region

#Region " ImprimirDocumentacionAsociada "

    Private Sub ImprimirDocumentacionAsociada()
        Dim blnError As Boolean = True
        Dim IDObra As Integer

        Dim dtAVL As DataTable = New AlbaranVentaLinea().Filter(New NumberFilterItem("IDAlbaran", Me.CurrentRow("IDAlbaran")))
        If Not IsNothing(dtAVL) AndAlso dtAVL.Rows.Count > 0 Then
            Dim ValuesArt(-1) As Object
            Dim ValuesAct(-1) As Object
            For Each drAVL As DataRow In dtAVL.Rows
                ReDim Preserve ValuesArt(UBound(ValuesArt) + 1)
                ValuesArt(UBound(ValuesArt)) = drAVL("IDArticulo")
                If Length(drAVL("Lote")) > 0 Then
                    ReDim Preserve ValuesAct(UBound(ValuesAct) + 1)
                    ValuesAct(UBound(ValuesAct)) = drAVL("Lote")
                End If
                If Length(drAVL("IDObra")) > 0 Then IDObra = drAVL("IDObra")
            Next
            Dim BEDataEngine As New BE.DataEngine
            Dim filtroDocumentacion As New Filter
            filtroDocumentacion.Add("Entidad", FilterOperator.Equal, "Articulo")
            filtroDocumentacion.Add("Campo1", FilterOperator.Equal, "IDArticulo")
            filtroDocumentacion.Add(New InListFilterItem("Valor1", ValuesArt, FilterType.String))
            filtroDocumentacion.Add(New BooleanFilterItem("ImprimibleEnAlbaran", True))
            Dim dtArt As DataTable = BEDataEngine.Filter("vAlquilerMntoAlbaranVentaDocumentacionAsociada", filtroDocumentacion)
            Dim dtAct As DataTable = Nothing
            If ValuesAct.Length > 0 Then
                Dim filtroDocumentacionAct As New Filter
                filtroDocumentacionAct.Add("Entidad", FilterOperator.Equal, "Activo")
                filtroDocumentacionAct.Add("Campo1", FilterOperator.Equal, "IDActivo")
                filtroDocumentacionAct.Add(New InListFilterItem("Valor1", ValuesAct, FilterType.String))
                filtroDocumentacionAct.Add(New BooleanFilterItem("ImprimibleEnAlbaran", True))
                dtAct = BEDataEngine.Filter("vAlquilerMntoAlbaranVentaDocumentacionAsociada", filtroDocumentacionAct)
            End If
            If Length(IDObra) > 0 Then
                Dim dtODI As DataTable = New ObraDocumImprimir().Filter(New NumberFilterItem("IDObra", IDObra))
                If Not IsNothing(dtODI) AndAlso dtODI.Rows.Count > 0 Then
                    Dim ValuesDoc(-1) As Object
                    If Not dtArt Is Nothing AndAlso dtArt.Rows.Count > 0 Then
                        For Each drArt As DataRow In dtArt.Rows
                            For Each drODI As DataRow In dtODI.Rows
                                If drODI("IDTipoDocumento") = drArt("IDTipoDocumento") Then
                                    ReDim Preserve ValuesDoc(UBound(ValuesDoc) + 1)
                                    ValuesDoc(UBound(ValuesDoc)) = drArt("IDDocumento")
                                    Exit For
                                End If
                            Next
                        Next
                    End If
                    If Not dtAct Is Nothing AndAlso dtAct.Rows.Count > 0 Then
                        For Each drAct As DataRow In dtAct.Rows
                            For Each drODI As DataRow In dtODI.Rows
                                If drODI("IDTipoDocumento") = drAct("IDTipoDocumento") Then
                                    ReDim Preserve ValuesDoc(UBound(ValuesDoc) + 1)
                                    ValuesDoc(UBound(ValuesDoc)) = drAct("IDDocumento")
                                    Exit For
                                End If
                            Next
                        Next
                    End If

                    If ValuesDoc.Length > 0 Then
                        Dim dtDocumento As DataTable = New DcmMaestroDocumento().Filter(New InListFilterItem("IDDocumento", ValuesDoc, FilterType.String))
                        If Not dtDocumento Is Nothing AndAlso dtDocumento.Rows.Count > 0 Then
                            blnError = False
                            ImprimirDocumentos(dtDocumento)
                        End If
                    End If
                End If
            End If
        End If
        If blnError Then ExpertisApp.GenerateMessage("No hay Documentos que mostrar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ImprimirDocumentos(ByVal dt As DataTable)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            Dim myProcess As New System.Diagnostics.Process

            For Each dr As DataRow In dt.Rows
                Try
                    myProcess.StartInfo.FileName = dr("URLDestino")
                    myProcess.StartInfo.Verb = "Print"
                    myProcess.StartInfo.CreateNoWindow = True
                    myProcess.Start()
                Catch e As System.IO.FileNotFoundException
                    ExpertisApp.GenerateMessage("Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch e1 As System.IO.DirectoryNotFoundException
                    ExpertisApp.GenerateMessage("Directorio no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch e2 As System.IO.FileLoadException
                    ExpertisApp.GenerateMessage("Error en la carga del archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
        End If
    End Sub

    'Private Function ObtenerArchivo(ByVal strURL As String) As String
    '    Dim lngPos As Long
    '    Dim lngPosAnt As Long

    '    lngPos = 1
    '    Do While lngPos <> 0
    '        lngPosAnt = lngPos
    '        lngPos = InStr(lngPos + 1, strURL, "\", vbTextCompare)
    '    Loop
    '    ObtenerArchivo = Mid$(strURL, lngPosAnt + 1, Len(strURL) - lngPosAnt)
    'End Function

#End Region

#End Region

    Private Sub MntoAlbaranVenta_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        ActivaRetornoAlbaran()
        ActualizarGrid()
        txtNAlquiler.Enabled = False
    End Sub

    Private Sub ActualizarGrid()
        Dim blnRetornado As Boolean = False
        If Length(Me.CurrentRow("IDAlbaran")) > 0 Then
            Dim AVL As New AlbaranVentaLinea
            ''Comprobacion de si ha sido retornado
            Dim dtAVL As DataTable = AVL.Filter(New NumberFilterItem("IDAlbaranDeposito", Me.CurrentRow("IDAlbaran")))
            If Not IsNothing(dtAVL) AndAlso dtAVL.Rows.Count > 0 Then
                blnRetornado = True
            End If

            Dim dtAlbaran As DataTable = AVL.Filter(New NumberFilterItem("IDAlbaran", Me.CurrentRow("IDAlbaran")))
            If Not IsNothing(dtAlbaran) AndAlso dtAlbaran.Rows.Count > 0 Then
                Dim Field As String = String.Empty
                If AdvTipoAlbaran.Text = mIDTipoAlbaranRetornoAlquiler Then
                    Field = "IDLineaAlbaranDeposito"
                Else
                    Field = "IDLineaAlbaran"
                End If

                Dim Values(-1) As Object
                For Each dr As DataRow In dtAlbaran.Rows
                    If Length(dr(Field)) > 0 Then
                        ReDim Preserve Values(UBound(Values) + 1)
                        Values(UBound(Values)) = dr(Field)
                    End If
                Next

                Dim f As New Filter
                If Values.Length > 0 Then
                    f.Add(New InListFilterItem("IDLineaAlbaran", Values, FilterType.String))
                    If AdvTipoAlbaran.Text = mIDTipoAlbaranRetornoAlquiler Or blnRetornado = True Then
                        f.Add(New IsNullFilterItem("MedidaRetorno", False))
                    End If
                Else
                    f.Add(New NoRowsFilterItem)
                End If

                gridMedidas.ReQuery(f)
            End If
        End If
    End Sub

#Region " Pestaña Líneas "

    Private Sub GridLineaAlbaran_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridLineaAlbaran.EditingCell
        Dim blnLineaComponente As Boolean
        With GridLineaAlbaran
            If Me.CurrentRow("estado") <> enumavcEstadoFactura.avcFacturado Then
                If GridLineaAlbaran.Row <> Grid.newTopRowPosition Then
                    If .Value("EstadoFactura") = enumavlEstadoFactura.avlFacturado Then
                        e.Cancel = (e.Column.Key <> "IDPedido" And e.Column.Key <> "DescRefCliente")
                    Else
                        blnLineaComponente = (Length(.Value("IDLineaPadre")) > 0 And .Value("TipoLineaAlbaran") = enumavlTipoLineaAlbaran.avlComponente)
                    End If
                End If
                If Not blnLineaComponente Then
                    Select Case e.Column.Key
                        Case "PedidoCliente"
                            If MBlnGestionAlquileres Then
                                If Length(AdvTipoAlbaran.Value) > 0 AndAlso AdvTipoAlbaran.Value = mIDTipoAlbaranRetornoAlquiler Then
                                    e.Cancel = True
                                End If
                            End If
                        Case "QServida", "Factor"
                            If Nz(.GetValue("NSerieObligatorio"), False) Then
                                If .Row <> Grid.newTopRowPosition Then
                                    e.Cancel = (Length(.Value("IDLineaMaterial")) > 0)
                                End If
                            ElseIf .GetValue("Lotes") > 0 Then
                                e.Cancel = True
                            Else
                                If .Row <> Grid.newTopRowPosition Then
                                    e.Cancel = (Length(.Value("IDLineaMaterial")) > 0)
                                End If
                            End If
                        Case "FechaAlquiler", "HoraAlquiler"
                            If .Value("FechaAlquiler") < Nz(.Value("FechaMaxima"), cnMinDate) Then
                                e.Cancel = True
                            Else
                                If e.Column.Key = "FechaAlquiler" Then
                                    e.Column.EditType = EditType.CalendarCombo
                                Else
                                    e.Column.EditType = EditType.TextBox
                                End If
                            End If
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub GridLineaAlbaran_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridLineaAlbaran.UpdatingCell
        Dim dblQInterna As Double
        With GridLineaAlbaran
            Select Case e.Column.Index
                Case .Columns("QServida").Index, .Columns("QInterna").Index, .Columns("Factor").Index
                    If .Row <> Grid.newTopRowPosition Then
                        If .Value(.Columns("NSerieObligatorio").Index) Then

                            If e.Column.Index = .Columns("QServida").Index Or e.Column.Index = .Columns("Factor").Index Then
                                If IsNumeric(.Value(.Columns("QServida").Index)) And IsNumeric(.Value(.Columns("Factor").Index)) Then
                                    dblQInterna = .Value(.Columns("QServida").Index) * .Value(.Columns("Factor").Index)
                                    If dblQInterna <> 1 Then
                                        e.Cancel = True
                                        ExpertisApp.GenerateMessage("La | no es válida.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, .Columns("QInterna").Caption)
                                    End If
                                End If
                            Else
                                If .Value(.Columns("QInterna").Index) <> 1 Then
                                    e.Cancel = True
                                    ExpertisApp.GenerateMessage("La | no es válida.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, .Columns("QInterna").Caption)
                                End If
                            End If
                        End If
                    End If
                Case .Columns("HoraAlquiler").Index
                    If Length(.Value(.Columns("HoraAlquiler").Index)) = 0 Then
                        If .Value(.Columns("TipoFactAlquiler").Index) <> enumTipoFacturacionAlquiler.enumTFASinAlquiler Then
                            ExpertisApp.GenerateMessage("La hora de alquiler debe tener valor.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            e.Cancel = True
                        End If
                    End If
            End Select
        End With
    End Sub

    Private Sub GridLineaAlbaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLineaAlbaran.Click
        Dim c As GridEXColumn = GridLineaAlbaran.ColumnFromPoint()
        If Not IsNothing(c) Then
            Dim hit As GridArea
            hit = GridLineaAlbaran.HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Select Case c.Key
                    Case "BotonAviso"
                        If Me.RecordsState = RecordsState.Saved Then
                            AbrirAvisoRetorno()
                        End If
                    Case "BotonContadores"
                        If Me.RecordsState = RecordsState.Saved Then
                            AbrirLecturaContadores()
                        End If
                End Select
            End If
        End If
    End Sub

    Private Sub AbrirAvisoRetorno()
        Dim frm As New frmAvisos
        With GridLineaAlbaran
            frm.NAlbaran = .Value("ARNalbaranRecogida") & String.Empty
            frm.Contacto = .Value("ARContactoObra") & String.Empty
            frm.Matricula = .Value("ARMatricula") & String.Empty
            frm.Cantidad = Nz(.Value("ARQAvisoRetorno"), 0)
            If Length(.Value("ARRecogidoPor")) > 0 Then
                frm.RecibidoPor = .Value("ARRecogidoPor")

                Dim dtOperario As DataTable = New Operario().Filter(New StringFilterItem("IDOperario", .Value("ARRecogidoPor")))
                If Not IsNothing(dtOperario) AndAlso dtOperario.Rows.Count > 0 Then
                    frm.Descripcion = dtOperario.Rows(0)("DescOperario") & String.Empty
                End If
            End If

            frm.Telefono = .Value("ARTelefono") & String.Empty
            frm.IDLineaAlbaran = .Value("IDLineaAlbaran") & String.Empty
            If Length(.Value("ARFechaPrevistaRetorno")) > 0 Then
                frm.FechaPrevista = GridLineaAlbaran.Value("ARFechaPrevistaRetorno")
            End If
            If Length(.Value("ARFechaAvisoRecogida")) > 0 Then
                frm.FechaAviso = GridLineaAlbaran.Value("ARFechaAvisoRecogida")
            End If
            frm.Texto = .Value("ARTexto") & String.Empty
            frm.AbrirFormulario()
        End With
    End Sub

    Private Sub AbrirLecturaContadores()
        With GridLineaAlbaran
            If Length(.Value("Lote")) > 0 And Length(.Value("IDArticulo")) > 0 Then
                If .Value("NserieObligatorio") Then
                    Dim f As New Filter
                    f.Add(New StringFilterItem("NSerie", .Value("Lote")))
                    f.Add(New StringFilterItem("IDArticulo", .Value("IDArticulo")))
                    Dim dtActivo As DataTable = New BE.DataEngine().Filter("vAlquilerMntoAlbaranVentaActivoContadores", f)
                    If Not dtActivo Is Nothing AndAlso dtActivo.Rows.Count > 0 Then
                        Dim H As New Hashtable
                        H.Add("IDLineaAlbaran", .Value("IDLineaAlbaran"))
                        H.Add("IDAlbaran", Me.CurrentRow("IDAlbaran"))

                        ExpertisApp.OpenForm("LCALB", , H)
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub GridLineaAlbaran_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridLineaAlbaran.FormattingRow
        If Not IsDBNull(e.Row.Cells("Lote").Value) And Not IsDBNull(e.Row.Cells("IdArticulo").Value) Then
            If Nz(e.Row.Cells("NSerieObligatorio").Value, False) Then
                Dim f As New Filter
                f.Add(New StringFilterItem("NSerie", e.Row.Cells("Lote").Value))
                f.Add(New StringFilterItem("IDArticulo", e.Row.Cells("IDArticulo").Value))
                Dim dtActivo As DataTable = New Solmicro.Expertis.Engine.BE.DataEngine().Filter("vAlquilerMntoAlbaranVentaActivoContadores", f)
                If Not IsNothing(dtActivo) AndAlso dtActivo.Rows.Count > 0 Then
                    e.Row.RowStyle = GridLineaAlbaran.FormatStyles("ContadoresAsociados")
                End If
            End If
        End If
    End Sub

#End Region

    Private Sub gridMedidas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridMedidas.Click
        Dim c As GridEXColumn = gridMedidas.ColumnFromPoint()
        If Not IsNothing(c) Then
            Dim hit As GridArea = gridMedidas.HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Select Case c.Key
                    Case "Medidas"
                        Dim frm As New frmHistMedidas
                        frm.IDLineaAlbaran = gridMedidas.Value("IDLineaALbaran")
                        frm.IDContador = gridMedidas.Value("IDCOntadorPrev")
                        frm.ShowDialog()
                        Me.Requery.InvokeOnClick()
                End Select
            End If
        End If
    End Sub

#Region "Funciones privadas y heredadas"

    Protected Overrides Function Proveedor() As Boolean
        If Length(cmbUbicacionMaterial.Value) = 0 Then
            ExpertisApp.GenerateMessage("Falta indicar proveedor de servicios para el albarán de servicios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return True
        Else
            Return False
        End If
    End Function

    'Private Sub MntoAlbaranVenta_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
    '    Select Case e.EntityName
    '        Case GridLineaAlbaran.EntityName
    '            e.Data.Context("AVLGAM") = True
    '    End Select
    'End Sub

#End Region

#Region " Reports "

    Private Sub MntoAlbaranVenta_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        If e.Alias.ToLower = "avgam" Or e.Alias.ToLower = "impavg" Then
            Dim FwnCliente As New Cliente
            Dim Dt As DataTable = FwnCliente.Filter(New FilterItem("IDCliente", FilterOperator.Equal, AdvIDCliente.Text, FilterType.String))
            If Not Dt Is Nothing AndAlso Dt.Rows.Count > 0 Then e.AuxiliarTableSettings.CopiesDefaultvalue = Dt.Rows(0)("NumeroCopiasAlbaranes")
        End If
    End Sub

    Private Sub MntoAlbaranVenta_SetReportOptions(ByVal sender As Object, ByVal e As Engine.UI.ReportExportOptionsEventArgs) Handles MyBase.SetReportExportOptions
        If e.Alias.ToLower = "avgam" Or e.Alias.ToLower = "impavg" Then
            e.Options.PromptUser = False
        End If
    End Sub

#End Region

End Class
