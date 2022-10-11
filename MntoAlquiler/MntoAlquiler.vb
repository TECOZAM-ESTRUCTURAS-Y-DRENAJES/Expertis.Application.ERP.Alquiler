Imports Janus.Windows.UI
Public Class MntoAlquiler
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

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
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents OpenDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pnlTrabajos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraCriterios As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents rbtVerGrid As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtVerFicha As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents FraArbol As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents rbtMinimizarTree As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtMaximizarTree As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents lblEstadoDistintoDE As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEstadoDistintoDE As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents TabAlquiler As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents TabPageCabeceraAlquiler As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageOrdenes As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageCondiciones As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageRepresentantes As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageActividades As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblCentroGestion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxIDCentroGestion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents advIDClasificacionObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDObraCalendario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FraClientes As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ntbDtoComercial As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtCifCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblPoblacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPoblacion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCodPostal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCodPostal As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblProvincia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtProvincia As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblDireccion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDireccion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescCliente As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblCifCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDtoComercial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipoObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescTipoObra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents FraFechas As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblFechaAlquiler As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaAlquiler As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFin As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents AdvIDTipoObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblAlbaranValorado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblClienteGenerico As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIDObraCalendario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIDAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIDClasificacionObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FraCondEconom As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraBanco As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblIdClienteBanco As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDClienteBanco As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtDiaFacturacion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents advIDCondicionEnvio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDMoneda As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblDiaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDDiaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCondicionPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDCondicionPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFormaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDFormaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDMoneda As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIDCondicionEnvio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDiaFacturacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFacturarDiasMinimos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFacturarTasaResiduos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblNoFacturaPortes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFacturarPlusPorContadores As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescClienteBanco As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents pnlTopCabeceraAlquiler As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents chkClienteGenerico As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkAlbaranValorado As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkFacturarDiasMinimos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkFacturarTasaResiduos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkNoFacturaPortes As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkFacturarPlusPorContadores As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents pnlPortes As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtPedidoClienteAbierto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents pnlBottomCabeceraAlquiler As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlTexto As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlTopTexto As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblTexto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtTexto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDescObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents pnlCondicionesArticuloTarifasDtos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlExcesoContadores As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents pnllblSeguros As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblSeguros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlTarifasDtos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Splitter3 As System.Windows.Forms.Splitter
    Friend WithEvents pnlArticulos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlLabelArticulos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Splitter4 As System.Windows.Forms.Splitter
    Friend WithEvents Panel5 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblArticulos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDtos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridSegurosArticulos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridSeguros As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridSegurosDtos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridRepresentantes As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridActividades As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageRecursos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridRecursos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Panel3 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents GridSegurosTarifas As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblTarifas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlSeguros As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents GridSegurosExcesoContadores As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnLabellSeguros As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblFianzaObligatoria As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblOServicioFind As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Splitter5 As System.Windows.Forms.Splitter
    Friend WithEvents TabTrabajos As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents TabPageDetalleOrdenes As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pnlFichaTrabajo As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlFichaTrabajoFill As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtTextoTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTextoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlFichaTrabajoTop As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents chkTraspasada As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents FraFianzas As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraDatosCliente As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents cmbSearchIDDireccion As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FraCRM As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblAtendidoPor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTextoContacto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPersonaContacto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FraFacturacion As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblTipoFacturacionAlquiler As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxTipoFactAlquiler As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblTipoFacturacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxTipoFacturacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblImporte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImporte As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents cmbVerPedidoCliente As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblPedidoCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNivelTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblNivelTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCentroGestionTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxCentroGestionTrabajo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents FraFechasTrabajo As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblFechaOrden As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaOrdenTrabajo As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFinTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaFinTrabajo As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaInicioTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaInicioTrabajo As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblEstadoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEstadoTrabajo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblIDArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDescArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblUDMedida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblQPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxIDUDMedida As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtQPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents pnlGridTrabajo As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents GridTrabajos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlConfigVerTrabajos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblVerTrabajos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlVerTrabajosGrid As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtDescTrabajoGrid As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajoGrid As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoGrid As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents pnlCliente As System.Windows.Forms.Panel
    Friend WithEvents txtCifClienteOT As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblClienteOT As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescClienteOT As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvClienteOT As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCIFClienteOT As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TabPageArticulos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents FraPortesArticulos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents pnlFillPortesArticulos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Panel8 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblCondicionesEspPortesBloq As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlLeftPortesArticulos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents chkPortesEspRetornosBloq As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkPortesEspSalidasBloq As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblPortesEspSalidasBloq As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPortesEspRetornosBloq As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TabPageHitos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridVencimientos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlTotalesHitos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblTotalVtoA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalVtoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents pnlConfigVerHitos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblVerHitos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlVerHitos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtDescTrabajoHitos As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajoHitos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoHitos As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents TabPagePersonal As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pnlConfigVerOperarios As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblVerOperarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlVerOperarios As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtDescTrabajoOperarios As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajoOperarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoOperarios As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents chkFianzaContabilizada As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkFianzaCompensada As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblFechaContabilizacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaContabilizacion As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFianza As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtFianza As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtDtoClienteTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtDireccionTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtPoblacionClienteTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtCPClienteTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtProvinciaTrabajoCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtTextoContacto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTipoActividad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescActividad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTipoActividad As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblAsterisco As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTextoInfo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblSucursal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtSucursal As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblDC As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDC As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblNCuenta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNCuenta As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblPoblacionClienteTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCPClienteTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblProvinciaTrabajoCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDireccionTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDtoClienteTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaActividad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaActividad As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents txtTextoActividad As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtHoraActividad As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblHoraActividad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTextoExternoTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTextoExternoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvOperarioTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTipoSeguroImporte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxTipoSeguroImporte As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents chkTrabajoFacturable As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents txtPedidoCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFechaPrevEntregaTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaPrevEntregaTrabajo As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents rbtOperariosOServicio As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtHitosOServicio As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtOperariosAlquiler As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtHitosAlquiler As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorOServicio As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtMaterialAlquiler As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtMaterialOServicio As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorAlquiler As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents TabPageIncidencias As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridIncidencias As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlVerArticulos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlConfigVerArticulos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblVerMateriales As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblMaterial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvMaterial As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents pnlConfigVerIncidencias As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents rbtIncidenciasOServicio As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents lblVerIncidencias As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents rbtIncidenciasAlquiler As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents GridMaterial As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridOperariosOrdenServicio As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents txtDescTrabajoMateriales As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajoMateriales As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoMateriales As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents pnlVerIncidencias As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents chkFiltrarPorMaterial As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents pnlFiltrarPorMaterial As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbVerTextoContacto As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbDocumentacion As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblExcesoContadores As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescTrabajoIncidencias As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cmbSearchActividad As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmbPrint As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmdMasiva As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtDescSituacion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents chkPedidoClienteAbierto As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblPedidoClienteAbierto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtOServicioFind As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents AdvPersonaContacto As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents pnlLabelTarifas As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlLabelDtos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtTrabajoIncidencias As Solmicro.Expertis.Engine.UI.TextBox
    Protected WithEvents lblNumAlquiler As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents pnlImporteFacturado As Solmicro.Expertis.Engine.UI.Panel
    Protected WithEvents FraPortes As Solmicro.Expertis.Engine.UI.Frame
    Protected WithEvents lblImporteFacturado As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents pnlPortesTop As Solmicro.Expertis.Engine.UI.Panel
    Protected WithEvents chbPortesEspRetornos As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents chbPortesEspSalidas As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents lblPortesEspSalidas As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblPortesEspRetornos As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents pnlPortesBottom As Solmicro.Expertis.Engine.UI.Panel
    Protected WithEvents lblImprimibleCondPortes As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents chbImprimibleCondPortes As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents lblCondicionesEspPortes As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents txtCondicionesEspPortes As Solmicro.Expertis.Engine.UI.TextBox
    Protected WithEvents txtImpQFactA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Protected WithEvents pnlCabecera As Solmicro.Expertis.Engine.UI.Panel
    Protected WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents txtCondicionesEspPortesBloq As Solmicro.Expertis.Engine.UI.TextBox
    Protected WithEvents txtNObra As Solmicro.Expertis.Engine.UI.CounterTextBox
    Friend WithEvents MnuNuevaOrden As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuDeleteOrden As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuRetornoAvisos As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuRetornoMaterial As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuPrefacturacion As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuFacturacion As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuADDFianza As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuDeleteFianza As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuGeneraHitos As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuIncidencias As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuSeguimiento As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuAlbaran As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuSalidaRetorno As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuNuevaOrden2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuDeleteOrden2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuRetornoAvisos2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuRetornoMaterial2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuPrefacturacion2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuFacturacion2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuADDFianza2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuDeleteFianza2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuGeneraHitos2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuIncidencias2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuSeguimiento2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuAlbaran2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuSalidaRetorno2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuGuion As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuGuion2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuGuion3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuGuion4 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuGuion5 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents pnlFianzaObligatoria As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents TvwTrabajos As System.Windows.Forms.TreeView
    Friend WithEvents txtIDEmpresa As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents chbBloqueado As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblBloqueado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TextBox1 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvSearch1 As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents TextBox2 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Button1 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents bGenerarAlbaran As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents bCreaAlbaran As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents mnuAlbaran1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MenuAlquiler As Janus.Windows.UI.CommandBars.UIContextMenu
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDCentroGestion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridSegurosExcesoContadores_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridSegurosExcesoContadores_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage")
        Dim GridSegurosExcesoContadores_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim GridSegurosExcesoContadores_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Dim GridSeguros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridSeguros_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage")
        Dim GridSeguros_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim GridSeguros_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Dim GridSeguros_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column16.ButtonImage")
        Dim cbxTipoSeguroImporte_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridSegurosArticulos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridSegurosArticulos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage")
        Dim GridSegurosTarifas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridSegurosTarifas_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage")
        Dim GridSegurosDtos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridSegurosDtos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage")
        Dim GridSegurosDtos_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim cbxTipoFactAlquiler_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoFacturacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxCentroGestionTrabajo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstadoTrabajo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDUDMedida_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridTrabajos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMaterial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMaterial_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column9.ButtonImage")
        Dim GridMaterial_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column13.ButtonImage")
        Dim GridMaterial_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column16.ButtonImage")
        Dim GridMaterial_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column19.ButtonImage")
        Dim GridMaterial_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column20.ButtonImage")
        Dim GridMaterial_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column21.ButtonImage")
        Dim GridMaterial_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column22.ButtonImage")
        Dim GridMaterial_DesignTimeLayout_Reference_7 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column26.ButtonImage")
        Dim GridMaterial_DesignTimeLayout_Reference_8 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column27.ButtonImage")
        Dim GridMaterial_DesignTimeLayout_Reference_9 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column28.ButtonImage")
        Dim GridIncidencias_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridIncidencias_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim GridIncidencias_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Dim GridIncidencias_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column8.ButtonImage")
        Dim GridIncidencias_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridVencimientos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVencimientos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column11.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column13.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column14.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column15.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column16.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column22.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column26.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_7 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column38.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_8 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column41.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_9 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridOperariosOrdenServicio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridOperariosOrdenServicio_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim GridOperariosOrdenServicio_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim GridOperariosOrdenServicio_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage")
        Dim GridOperariosOrdenServicio_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cbxEstadoDistintoDE_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridRepresentantes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridRepresentantes_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage")
        Dim GridRepresentantes_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim GridRepresentantes_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Dim GridRepresentantes_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column8.ButtonImage")
        Dim GridRepresentantes_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column10.ButtonImage")
        Dim GridActividades_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridActividades_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridRecursos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridRecursos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage")
        Dim GridRecursos_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoAlquiler))
        Me.pnlCabecera = New Solmicro.Expertis.Engine.UI.Panel
        Me.AdvSearch1 = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.TextBox1 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNumAlquiler = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNObra = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Button1 = New Solmicro.Expertis.Engine.UI.Button
        Me.TabAlquiler = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageCabeceraAlquiler = New Janus.Windows.UI.Tab.UITabPage
        Me.pnlBottomCabeceraAlquiler = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlTexto = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlTopTexto = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTexto = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlPortes = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraPortes = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtCondicionesEspPortes = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlPortesBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.chbImprimibleCondPortes = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblImprimibleCondPortes = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlPortesTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblCondicionesEspPortes = New Solmicro.Expertis.Engine.UI.Label
        Me.chbPortesEspRetornos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chbPortesEspSalidas = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblPortesEspSalidas = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPortesEspRetornos = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlImporteFacturado = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtImpQFactA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImporteFacturado = New Solmicro.Expertis.Engine.UI.Label
        Me.FraCondEconom = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtPedidoClienteAbierto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.chkFacturarPlusPorContadores = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkPedidoClienteAbierto = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkNoFacturaPortes = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkFacturarTasaResiduos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkFacturarDiasMinimos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblAsterisco = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTextoInfo = New Solmicro.Expertis.Engine.UI.Label
        Me.FraBanco = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblSucursal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSucursal = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDC = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDC = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNCuenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNCuenta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ulDescClienteBanco = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblIdClienteBanco = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDClienteBanco = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtDiaFacturacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.advIDCondicionEnvio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDMoneda = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblDiaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDDiaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCondicionPago = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDCondicionPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDFormaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDMoneda = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDCondicionEnvio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDiaFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFacturarDiasMinimos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFacturarTasaResiduos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblNoFacturaPortes = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPedidoClienteAbierto = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFacturarPlusPorContadores = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlTopCabeceraAlquiler = New Solmicro.Expertis.Engine.UI.Panel
        Me.chbBloqueado = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblBloqueado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDCentroGestion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.advIDClasificacionObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDObraCalendario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.chkClienteGenerico = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkAlbaranValorado = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraClientes = New Solmicro.Expertis.Engine.UI.Frame
        Me.TextBox2 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cmbDocumentacion = New Solmicro.Expertis.Engine.UI.Button
        Me.ntbDtoComercial = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtCifCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblPoblacion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPoblacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodPostal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodPostal = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblProvincia = New Solmicro.Expertis.Engine.UI.Label
        Me.txtProvincia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDireccion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDireccion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescCliente = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCifCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDtoComercial = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDEmpresa = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTipoObra = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescTipoObra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FraFechas = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFechaAlquiler = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaAlquiler = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.AdvIDTipoObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlbaranValorado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblClienteGenerico = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDObraCalendario = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDClasificacionObra = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPageCondiciones = New Janus.Windows.UI.Tab.UITabPage
        Me.pnlSeguros = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridSegurosExcesoContadores = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnLabellSeguros = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblExcesoContadores = New Solmicro.Expertis.Engine.UI.Label
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.pnlExcesoContadores = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridSeguros = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnllblSeguros = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTipoSeguroImporte = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoSeguroImporte = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblSeguros = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlCondicionesArticuloTarifasDtos = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlArticulos = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridSegurosArticulos = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlLabelArticulos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblArticulos = New Solmicro.Expertis.Engine.UI.Label
        Me.Splitter3 = New System.Windows.Forms.Splitter
        Me.pnlTarifasDtos = New Solmicro.Expertis.Engine.UI.Panel
        Me.Panel3 = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridSegurosTarifas = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlLabelTarifas = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTarifas = New Solmicro.Expertis.Engine.UI.Label
        Me.Splitter4 = New System.Windows.Forms.Splitter
        Me.Panel5 = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridSegurosDtos = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlLabelDtos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblDtos = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPageOrdenes = New Janus.Windows.UI.Tab.UITabPage
        Me.TabTrabajos = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageDetalleOrdenes = New Janus.Windows.UI.Tab.UITabPage
        Me.pnlFichaTrabajo = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlFichaTrabajoFill = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtTextoExternoTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTextoExternoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTextoTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTextoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlFichaTrabajoTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtTextoContacto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.AdvOperarioTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvPersonaContacto = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cmbPrint = New Solmicro.Expertis.Engine.UI.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.chkTraspasada = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraFianzas = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFianza = New Solmicro.Expertis.Engine.UI.Label
        Me.txtFianza = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFechaContabilizacion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaContabilizacion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.chkFianzaCompensada = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkFianzaContabilizada = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraDatosCliente = New Solmicro.Expertis.Engine.UI.Frame
        Me.cmbSearchIDDireccion = New Solmicro.Expertis.Engine.UI.Button
        Me.txtDtoClienteTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPoblacionClienteTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPoblacionClienteTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCPClienteTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCPClienteTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblProvinciaTrabajoCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.txtProvinciaTrabajoCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDireccionTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDireccionTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDtoClienteTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.FraCRM = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtTipoActividad = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtHoraActividad = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblHoraActividad = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescActividad = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTextoActividad = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFechaActividad = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaActividad = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.txtDescSituacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTipoActividad = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbSearchActividad = New Solmicro.Expertis.Engine.UI.Button
        Me.lblAtendidoPor = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbVerTextoContacto = New Solmicro.Expertis.Engine.UI.Button
        Me.lblTextoContacto = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPersonaContacto = New Solmicro.Expertis.Engine.UI.Label
        Me.FraFacturacion = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkTrabajoFacturable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblTipoFacturacionAlquiler = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoFactAlquiler = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTipoFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoFacturacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblImporte = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImporte = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.cmbVerPedidoCliente = New Solmicro.Expertis.Engine.UI.Button
        Me.lblPedidoCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNivelTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNivelTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCentroGestionTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxCentroGestionTrabajo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FraFechasTrabajo = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFechaPrevEntregaTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaPrevEntregaTrabajo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaOrden = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaOrdenTrabajo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFinTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFinTrabajo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicioTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicioTrabajo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblEstadoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstadoTrabajo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblIDArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDescArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblUDMedida = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDUDMedida = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.txtQPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPedidoCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlGridTrabajo = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridTrabajos = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlConfigVerTrabajos = New Solmicro.Expertis.Engine.UI.Panel
        Me.rbtPorOServicio = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerTrabajos = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtPorAlquiler = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.pnlVerTrabajosGrid = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescTrabajoGrid = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoGrid = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoGrid = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlCliente = New System.Windows.Forms.Panel
        Me.txtCifClienteOT = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblClienteOT = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescClienteOT = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvClienteOT = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCIFClienteOT = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPageArticulos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMaterial = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlConfigVerArticulos = New Solmicro.Expertis.Engine.UI.Panel
        Me.rbtMaterialOServicio = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerMateriales = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtMaterialAlquiler = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.pnlVerArticulos = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescTrabajoMateriales = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoMateriales = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoMateriales = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraPortesArticulos = New Solmicro.Expertis.Engine.UI.Frame
        Me.pnlFillPortesArticulos = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtCondicionesEspPortesBloq = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Panel8 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblCondicionesEspPortesBloq = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlLeftPortesArticulos = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkPortesEspRetornosBloq = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkPortesEspSalidasBloq = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblPortesEspSalidasBloq = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPortesEspRetornosBloq = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPageIncidencias = New Janus.Windows.UI.Tab.UITabPage
        Me.GridIncidencias = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlFiltrarPorMaterial = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmdMasiva = New Solmicro.Expertis.Engine.UI.Button
        Me.lblMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvMaterial = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlConfigVerIncidencias = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkFiltrarPorMaterial = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.rbtIncidenciasOServicio = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerIncidencias = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtIncidenciasAlquiler = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.pnlVerIncidencias = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtTrabajoIncidencias = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescTrabajoIncidencias = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPageHitos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridVencimientos = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlTotalesHitos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotalVtoA = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalVtoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalA = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.pnlConfigVerHitos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblVerHitos = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtHitosOServicio = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtHitosAlquiler = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.pnlVerHitos = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescTrabajoHitos = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoHitos = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoHitos = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TabPagePersonal = New Janus.Windows.UI.Tab.UITabPage
        Me.GridOperariosOrdenServicio = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlConfigVerOperarios = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblVerOperarios = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtOperariosOServicio = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtOperariosAlquiler = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.pnlVerOperarios = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescTrabajoOperarios = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoOperarios = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoOperarios = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Splitter5 = New System.Windows.Forms.Splitter
        Me.pnlTrabajos = New Solmicro.Expertis.Engine.UI.Panel
        Me.TvwTrabajos = New System.Windows.Forms.TreeView
        Me.pnlFianzaObligatoria = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblFianzaObligatoria = New Solmicro.Expertis.Engine.UI.Label
        Me.FraArbol = New Solmicro.Expertis.Engine.UI.Frame
        Me.bCreaAlbaran = New Solmicro.Expertis.Engine.UI.Button
        Me.bGenerarAlbaran = New Solmicro.Expertis.Engine.UI.Button
        Me.txtOServicioFind = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblOServicioFind = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtMinimizarTree = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtMaximizarTree = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblEstadoDistintoDE = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstadoDistintoDE = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FraCriterios = New Solmicro.Expertis.Engine.UI.Frame
        Me.rbtVerGrid = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtVerFicha = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.TabPageRepresentantes = New Janus.Windows.UI.Tab.UITabPage
        Me.GridRepresentantes = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageActividades = New Janus.Windows.UI.Tab.UITabPage
        Me.GridActividades = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageRecursos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridRecursos = New Solmicro.Expertis.Engine.UI.Grid
        Me.OpenDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.MenuAlquiler = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.MnuNuevaOrden2 = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevaOrden")
        Me.MnuGuion = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion")
        Me.MnuDeleteOrden2 = New Janus.Windows.UI.CommandBars.UICommand("MnuDeleteOrden")
        Me.MnuGuion2 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion2")
        Me.mnuRetornoAvisos2 = New Janus.Windows.UI.CommandBars.UICommand("mnuRetornoAvisos")
        Me.mnuRetornoMaterial2 = New Janus.Windows.UI.CommandBars.UICommand("mnuRetornoMaterial")
        Me.mnuPrefacturacion2 = New Janus.Windows.UI.CommandBars.UICommand("mnuPrefacturacion")
        Me.mnuFacturacion2 = New Janus.Windows.UI.CommandBars.UICommand("mnuFacturacion")
        Me.MnuGuion3 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion3")
        Me.mnuADDFianza2 = New Janus.Windows.UI.CommandBars.UICommand("mnuADDFianza")
        Me.mnuDeleteFianza2 = New Janus.Windows.UI.CommandBars.UICommand("mnuDeleteFianza")
        Me.MnuGuion4 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion4")
        Me.mnuGeneraHitos2 = New Janus.Windows.UI.CommandBars.UICommand("mnuGeneraHitos")
        Me.mnuIncidencias2 = New Janus.Windows.UI.CommandBars.UICommand("mnuIncidencias")
        Me.mnuSeguimiento2 = New Janus.Windows.UI.CommandBars.UICommand("mnuSeguimiento")
        Me.MnuGuion5 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion5")
        Me.mnuAlbaran2 = New Janus.Windows.UI.CommandBars.UICommand("mnuAlbaran")
        Me.mnuSalidaRetorno2 = New Janus.Windows.UI.CommandBars.UICommand("mnuSalidaRetorno")
        Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.MnuNuevaOrden = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevaOrden")
        Me.MnuDeleteOrden = New Janus.Windows.UI.CommandBars.UICommand("MnuDeleteOrden")
        Me.mnuRetornoAvisos = New Janus.Windows.UI.CommandBars.UICommand("mnuRetornoAvisos")
        Me.mnuRetornoMaterial = New Janus.Windows.UI.CommandBars.UICommand("mnuRetornoMaterial")
        Me.mnuPrefacturacion = New Janus.Windows.UI.CommandBars.UICommand("mnuPrefacturacion")
        Me.mnuFacturacion = New Janus.Windows.UI.CommandBars.UICommand("mnuFacturacion")
        Me.mnuADDFianza = New Janus.Windows.UI.CommandBars.UICommand("mnuADDFianza")
        Me.mnuDeleteFianza = New Janus.Windows.UI.CommandBars.UICommand("mnuDeleteFianza")
        Me.mnuGeneraHitos = New Janus.Windows.UI.CommandBars.UICommand("mnuGeneraHitos")
        Me.mnuIncidencias = New Janus.Windows.UI.CommandBars.UICommand("mnuIncidencias")
        Me.mnuSeguimiento = New Janus.Windows.UI.CommandBars.UICommand("mnuSeguimiento")
        Me.mnuAlbaran = New Janus.Windows.UI.CommandBars.UICommand("mnuAlbaran")
        Me.mnuSalidaRetorno = New Janus.Windows.UI.CommandBars.UICommand("mnuSalidaRetorno")
        Me.mnuAlbaran1 = New Janus.Windows.UI.CommandBars.UICommand("mnuAlbaran")
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.pnlCabecera.suspendlayout()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAlquiler.SuspendLayout()
        Me.TabPageCabeceraAlquiler.SuspendLayout()
        Me.pnlBottomCabeceraAlquiler.suspendlayout()
        Me.pnlTexto.suspendlayout()
        Me.pnlTopTexto.suspendlayout()
        Me.pnlPortes.suspendlayout()
        Me.FraPortes.SuspendLayout()
        Me.pnlPortesBottom.suspendlayout()
        Me.pnlPortesTop.suspendlayout()
        Me.pnlImporteFacturado.suspendlayout()
        Me.FraCondEconom.SuspendLayout()
        Me.FraBanco.SuspendLayout()
        Me.pnlTopCabeceraAlquiler.suspendlayout()
        CType(Me.cbxIDCentroGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraClientes.SuspendLayout()
        Me.FraFechas.SuspendLayout()
        Me.TabPageCondiciones.SuspendLayout()
        Me.pnlSeguros.suspendlayout()
        CType(Me.GridSegurosExcesoContadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnLabellSeguros.suspendlayout()
        Me.pnlExcesoContadores.suspendlayout()
        CType(Me.GridSeguros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnllblSeguros.suspendlayout()
        CType(Me.cbxTipoSeguroImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCondicionesArticuloTarifasDtos.suspendlayout()
        Me.pnlArticulos.suspendlayout()
        CType(Me.GridSegurosArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLabelArticulos.suspendlayout()
        Me.pnlTarifasDtos.suspendlayout()
        Me.Panel3.suspendlayout()
        CType(Me.GridSegurosTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLabelTarifas.suspendlayout()
        Me.Panel5.suspendlayout()
        CType(Me.GridSegurosDtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLabelDtos.suspendlayout()
        Me.TabPageOrdenes.SuspendLayout()
        CType(Me.TabTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTrabajos.SuspendLayout()
        Me.TabPageDetalleOrdenes.SuspendLayout()
        Me.pnlFichaTrabajo.suspendlayout()
        Me.pnlFichaTrabajoFill.suspendlayout()
        Me.pnlFichaTrabajoTop.suspendlayout()
        Me.FraFianzas.SuspendLayout()
        Me.FraDatosCliente.SuspendLayout()
        Me.FraCRM.SuspendLayout()
        Me.FraFacturacion.SuspendLayout()
        CType(Me.cbxTipoFactAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTipoFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCentroGestionTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraFechasTrabajo.SuspendLayout()
        CType(Me.cbxEstadoTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDUDMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGridTrabajo.suspendlayout()
        CType(Me.GridTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConfigVerTrabajos.suspendlayout()
        Me.pnlVerTrabajosGrid.suspendlayout()
        Me.pnlCliente.SuspendLayout()
        Me.TabPageArticulos.SuspendLayout()
        CType(Me.GridMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConfigVerArticulos.suspendlayout()
        Me.pnlVerArticulos.suspendlayout()
        Me.FraPortesArticulos.SuspendLayout()
        Me.pnlFillPortesArticulos.suspendlayout()
        Me.Panel8.suspendlayout()
        Me.pnlLeftPortesArticulos.suspendlayout()
        Me.TabPageIncidencias.SuspendLayout()
        CType(Me.GridIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFiltrarPorMaterial.suspendlayout()
        Me.pnlConfigVerIncidencias.suspendlayout()
        Me.pnlVerIncidencias.suspendlayout()
        Me.TabPageHitos.SuspendLayout()
        CType(Me.GridVencimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalesHitos.suspendlayout()
        Me.pnlConfigVerHitos.suspendlayout()
        Me.pnlVerHitos.suspendlayout()
        Me.TabPagePersonal.SuspendLayout()
        CType(Me.GridOperariosOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConfigVerOperarios.suspendlayout()
        Me.pnlVerOperarios.suspendlayout()
        Me.pnlTrabajos.suspendlayout()
        Me.pnlFianzaObligatoria.suspendlayout()
        Me.FraArbol.SuspendLayout()
        CType(Me.cbxEstadoDistintoDE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraCriterios.SuspendLayout()
        Me.TabPageRepresentantes.SuspendLayout()
        CType(Me.GridRepresentantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageActividades.SuspendLayout()
        CType(Me.GridActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageRecursos.SuspendLayout()
        CType(Me.GridRecursos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Duplicate
        '
        Me.Duplicate.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(721, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.MnuNuevaOrden, Me.MnuDeleteOrden, Me.mnuRetornoAvisos, Me.mnuRetornoMaterial, Me.mnuPrefacturacion, Me.mnuFacturacion, Me.mnuADDFianza, Me.mnuDeleteFianza, Me.mnuGeneraHitos, Me.mnuIncidencias, Me.mnuSeguimiento, Me.mnuAlbaran, Me.mnuSalidaRetorno})
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.MenuAlquiler})
        '
        'GoFirst
        '
        Me.GoFirst.Icon = CType(resources.GetObject("GoFirst.Icon"), System.Drawing.Icon)
        '
        'GoPrevious
        '
        Me.GoPrevious.Icon = CType(resources.GetObject("GoPrevious.Icon"), System.Drawing.Icon)
        '
        'GoNext
        '
        Me.GoNext.Icon = CType(resources.GetObject("GoNext.Icon"), System.Drawing.Icon)
        '
        'Delete
        '
        Me.Delete.Icon = CType(resources.GetObject("Delete.Icon"), System.Drawing.Icon)
        Me.Delete.Text = ""
        '
        'Ok
        '
        Me.Ok.Icon = CType(resources.GetObject("Ok.Icon"), System.Drawing.Icon)
        Me.Ok.Text = ""
        '
        'Cancel
        '
        Me.Cancel.Icon = CType(resources.GetObject("Cancel.Icon"), System.Drawing.Icon)
        Me.Cancel.Text = ""
        '
        'Print
        '
        Me.Print.Icon = CType(resources.GetObject("Print.Icon"), System.Drawing.Icon)
        Me.Print.Text = ""
        '
        'Search
        '
        Me.Search.Icon = CType(resources.GetObject("Search.Icon"), System.Drawing.Icon)
        Me.Search.Text = ""
        '
        'GoLast
        '
        Me.GoLast.Icon = CType(resources.GetObject("GoLast.Icon"), System.Drawing.Icon)
        '
        'Find
        '
        Me.Find.Icon = CType(resources.GetObject("Find.Icon"), System.Drawing.Icon)
        Me.Find.Text = ""
        '
        'NewRow
        '
        Me.NewRow.Icon = CType(resources.GetObject("NewRow.Icon"), System.Drawing.Icon)
        Me.NewRow.Text = ""
        '
        'Requery
        '
        Me.Requery.Icon = CType(resources.GetObject("Requery.Icon"), System.Drawing.Icon)
        Me.Requery.Text = ""
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        Me.ExecuteActions.Text = ""
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TabAlquiler)
        Me.MainPanel.Controls.Add(Me.pnlCabecera)
        Me.MainPanel.Size = New System.Drawing.Size(784, 561)
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Controls.Add(Me.AdvSearch1)
        Me.pnlCabecera.Controls.Add(Me.Label2)
        Me.pnlCabecera.Controls.Add(Me.TextBox1)
        Me.pnlCabecera.Controls.Add(Me.txtDescObra)
        Me.pnlCabecera.Controls.Add(Me.lblNumAlquiler)
        Me.pnlCabecera.Controls.Add(Me.txtNObra)
        Me.pnlCabecera.Controls.Add(Me.lblEstado)
        Me.pnlCabecera.Controls.Add(Me.cbxEstado)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(784, 54)
        Me.pnlCabecera.TabIndex = 42
        '
        'AdvSearch1
        '
        Me.AdvSearch1.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSearch1.DisplayField = "IDPersona"
        Me.AdvSearch1.EntityName = "ObraPersonaContacto2"
        Me.AdvSearch1.Location = New System.Drawing.Point(142, 28)
        Me.AdvSearch1.Name = "AdvSearch1"
        Me.AdvSearch1.PrimaryDataFields = "DatosContacto"
        Me.AdvSearch1.SecondaryDataFields = "IDPersona"
        Me.AdvSearch1.Size = New System.Drawing.Size(123, 23)
        Me.AdvSearch1.TabIndex = 7
        Me.AdvSearch1.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Persona de contacto:"
        Me.Label2.Visible = False
        '
        'TextBox1
        '
        Me.TryDataBinding(TextBox1, New System.Windows.Forms.Binding("Text", Me, "DatosContacto", True))
        Me.TextBox1.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(280, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 21)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Visible = False
        '
        'txtDescObra
        '
        Me.TryDataBinding(txtDescObra, New System.Windows.Forms.Binding("Text", Me, "DescObra", True))
        Me.txtDescObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescObra.Location = New System.Drawing.Point(216, 4)
        Me.txtDescObra.Name = "txtDescObra"
        Me.txtDescObra.Size = New System.Drawing.Size(378, 21)
        Me.txtDescObra.TabIndex = 1
        '
        'lblNumAlquiler
        '
        Me.lblNumAlquiler.Location = New System.Drawing.Point(4, 9)
        Me.lblNumAlquiler.Name = "lblNumAlquiler"
        Me.lblNumAlquiler.Size = New System.Drawing.Size(84, 13)
        Me.lblNumAlquiler.TabIndex = 3
        Me.lblNumAlquiler.Text = "Num. Alquiler"
        '
        'txtNObra
        '
        Me.TryDataBinding(txtNObra, New System.Windows.Forms.Binding("Text", Me, "NObra", True))
        Me.txtNObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtNObra.Location = New System.Drawing.Point(89, 4)
        Me.txtNObra.Name = "txtNObra"
        Me.txtNObra.Size = New System.Drawing.Size(123, 23)
        Me.txtNObra.TabIndex = 0
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(618, 6)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 4
        Me.lblEstado.Text = "Estado"
        '
        'cbxEstado
        '
        Me.cbxEstado.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.TryDataBinding(cbxEstado, New System.Windows.Forms.Binding("Value", Me, "Estado", True))
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.DisplayMember = "Value"
        Me.cbxEstado.Location = New System.Drawing.Point(667, 5)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.PrimaryDataFields = "Estado"
        Me.cbxEstado.SecondaryDataFields = "Value"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(112, 21)
        Me.cbxEstado.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(562, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 23)
        Me.Button1.TabIndex = 241
        Me.Button1.Text = "Validar Direccion"
        Me.Button1.Visible = False
        '
        'TabAlquiler
        '
        Me.TabAlquiler.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabAlquiler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabAlquiler.Location = New System.Drawing.Point(0, 54)
        Me.TabAlquiler.Name = "TabAlquiler"
        Me.TabAlquiler.Size = New System.Drawing.Size(784, 507)
        Me.TabAlquiler.TabIndex = 3
        Me.TabAlquiler.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageCabeceraAlquiler, Me.TabPageCondiciones, Me.TabPageOrdenes, Me.TabPageRepresentantes, Me.TabPageActividades, Me.TabPageRecursos})
        Me.TabAlquiler.Text = "Seguimiento"
        Me.TabAlquiler.UseThemes = True
        '
        'TabPageCabeceraAlquiler
        '
        Me.TabPageCabeceraAlquiler.Controls.Add(Me.pnlBottomCabeceraAlquiler)
        Me.TabPageCabeceraAlquiler.Controls.Add(Me.FraCondEconom)
        Me.TabPageCabeceraAlquiler.Controls.Add(Me.pnlTopCabeceraAlquiler)
        Me.TabPageCabeceraAlquiler.Key = "Cabecera"
        Me.TabPageCabeceraAlquiler.Location = New System.Drawing.Point(1, 21)
        Me.TabPageCabeceraAlquiler.Name = "TabPageCabeceraAlquiler"
        Me.TabPageCabeceraAlquiler.Size = New System.Drawing.Size(782, 485)
        Me.TabPageCabeceraAlquiler.TabStop = True
        Me.TabPageCabeceraAlquiler.Text = "Cabecera Alquiler"
        '
        'pnlBottomCabeceraAlquiler
        '
        Me.pnlBottomCabeceraAlquiler.Controls.Add(Me.pnlTexto)
        Me.pnlBottomCabeceraAlquiler.Controls.Add(Me.pnlPortes)
        Me.pnlBottomCabeceraAlquiler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBottomCabeceraAlquiler.Location = New System.Drawing.Point(0, 317)
        Me.pnlBottomCabeceraAlquiler.Name = "pnlBottomCabeceraAlquiler"
        Me.pnlBottomCabeceraAlquiler.Size = New System.Drawing.Size(782, 168)
        Me.pnlBottomCabeceraAlquiler.TabIndex = 220
        '
        'pnlTexto
        '
        Me.pnlTexto.Controls.Add(Me.txtTexto)
        Me.pnlTexto.Controls.Add(Me.Panel2)
        Me.pnlTexto.Controls.Add(Me.Panel1)
        Me.pnlTexto.Controls.Add(Me.pnlTopTexto)
        Me.pnlTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTexto.Location = New System.Drawing.Point(0, 0)
        Me.pnlTexto.Name = "pnlTexto"
        Me.pnlTexto.Size = New System.Drawing.Size(408, 168)
        Me.pnlTexto.TabIndex = 4
        '
        'txtTexto
        '
        Me.TryDataBinding(txtTexto, New System.Windows.Forms.Binding("Text", Me, "TextoCliente", True))
        Me.txtTexto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTexto.Location = New System.Drawing.Point(9, 22)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(390, 146)
        Me.txtTexto.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(399, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(9, 146)
        Me.Panel2.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(9, 146)
        Me.Panel1.TabIndex = 7
        '
        'pnlTopTexto
        '
        Me.pnlTopTexto.Controls.Add(Me.lblTexto)
        Me.pnlTopTexto.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopTexto.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopTexto.Name = "pnlTopTexto"
        Me.pnlTopTexto.Size = New System.Drawing.Size(408, 22)
        Me.pnlTopTexto.TabIndex = 6
        '
        'lblTexto
        '
        Me.lblTexto.Location = New System.Drawing.Point(10, 3)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(38, 13)
        Me.lblTexto.TabIndex = 5
        Me.lblTexto.Text = "Texto"
        '
        'pnlPortes
        '
        Me.pnlPortes.Controls.Add(Me.FraPortes)
        Me.pnlPortes.Controls.Add(Me.pnlImporteFacturado)
        Me.pnlPortes.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlPortes.Location = New System.Drawing.Point(408, 0)
        Me.pnlPortes.Name = "pnlPortes"
        Me.pnlPortes.Size = New System.Drawing.Size(374, 168)
        Me.pnlPortes.TabIndex = 1
        '
        'FraPortes
        '
        Me.FraPortes.Controls.Add(Me.txtCondicionesEspPortes)
        Me.FraPortes.Controls.Add(Me.pnlPortesBottom)
        Me.FraPortes.Controls.Add(Me.pnlPortesTop)
        Me.FraPortes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraPortes.Location = New System.Drawing.Point(0, 0)
        Me.FraPortes.Name = "FraPortes"
        Me.FraPortes.Size = New System.Drawing.Size(374, 141)
        Me.FraPortes.TabIndex = 2
        Me.FraPortes.TabStop = False
        Me.FraPortes.Text = "Condiciones de Portes"
        '
        'txtCondicionesEspPortes
        '
        Me.TryDataBinding(txtCondicionesEspPortes, New System.Windows.Forms.Binding("Text", Me, "CondicionesEspPortes", True))
        Me.txtCondicionesEspPortes.DisabledBackColor = System.Drawing.Color.White
        Me.txtCondicionesEspPortes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCondicionesEspPortes.Location = New System.Drawing.Point(3, 63)
        Me.txtCondicionesEspPortes.Multiline = True
        Me.txtCondicionesEspPortes.Name = "txtCondicionesEspPortes"
        Me.txtCondicionesEspPortes.Size = New System.Drawing.Size(368, 51)
        Me.txtCondicionesEspPortes.TabIndex = 31
        '
        'pnlPortesBottom
        '
        Me.pnlPortesBottom.Controls.Add(Me.chbImprimibleCondPortes)
        Me.pnlPortesBottom.Controls.Add(Me.lblImprimibleCondPortes)
        Me.pnlPortesBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPortesBottom.Location = New System.Drawing.Point(3, 114)
        Me.pnlPortesBottom.Name = "pnlPortesBottom"
        Me.pnlPortesBottom.Size = New System.Drawing.Size(368, 24)
        Me.pnlPortesBottom.TabIndex = 5
        '
        'chbImprimibleCondPortes
        '
        Me.TryDataBinding(chbImprimibleCondPortes, New System.Windows.Forms.Binding("BindableValue", Me, "ImprimibleCondPortes", True))
        Me.chbImprimibleCondPortes.Location = New System.Drawing.Point(348, 1)
        Me.chbImprimibleCondPortes.Name = "chbImprimibleCondPortes"
        Me.chbImprimibleCondPortes.Size = New System.Drawing.Size(15, 23)
        Me.chbImprimibleCondPortes.TabIndex = 32
        '
        'lblImprimibleCondPortes
        '
        Me.lblImprimibleCondPortes.Location = New System.Drawing.Point(161, 5)
        Me.lblImprimibleCondPortes.Name = "lblImprimibleCondPortes"
        Me.lblImprimibleCondPortes.Size = New System.Drawing.Size(182, 13)
        Me.lblImprimibleCondPortes.TabIndex = 0
        Me.lblImprimibleCondPortes.Text = "Imprimible Condiciones Portes"
        '
        'pnlPortesTop
        '
        Me.pnlPortesTop.Controls.Add(Me.lblCondicionesEspPortes)
        Me.pnlPortesTop.Controls.Add(Me.chbPortesEspRetornos)
        Me.pnlPortesTop.Controls.Add(Me.chbPortesEspSalidas)
        Me.pnlPortesTop.Controls.Add(Me.lblPortesEspSalidas)
        Me.pnlPortesTop.Controls.Add(Me.lblPortesEspRetornos)
        Me.pnlPortesTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPortesTop.Location = New System.Drawing.Point(3, 17)
        Me.pnlPortesTop.Name = "pnlPortesTop"
        Me.pnlPortesTop.Size = New System.Drawing.Size(368, 46)
        Me.pnlPortesTop.TabIndex = 4
        '
        'lblCondicionesEspPortes
        '
        Me.lblCondicionesEspPortes.Location = New System.Drawing.Point(3, 27)
        Me.lblCondicionesEspPortes.Name = "lblCondicionesEspPortes"
        Me.lblCondicionesEspPortes.Size = New System.Drawing.Size(179, 13)
        Me.lblCondicionesEspPortes.TabIndex = 8
        Me.lblCondicionesEspPortes.Text = "Condiciones Especiales Portes"
        '
        'chbPortesEspRetornos
        '
        Me.TryDataBinding(chbPortesEspRetornos, New System.Windows.Forms.Binding("BindableValue", Me, "PortesEspRetornos", True))
        Me.chbPortesEspRetornos.Location = New System.Drawing.Point(348, 2)
        Me.chbPortesEspRetornos.Name = "chbPortesEspRetornos"
        Me.chbPortesEspRetornos.Size = New System.Drawing.Size(15, 23)
        Me.chbPortesEspRetornos.TabIndex = 30
        '
        'chbPortesEspSalidas
        '
        Me.TryDataBinding(chbPortesEspSalidas, New System.Windows.Forms.Binding("BindableValue", Me, "PortesEspSalidas", True))
        Me.chbPortesEspSalidas.Location = New System.Drawing.Point(158, 2)
        Me.chbPortesEspSalidas.Name = "chbPortesEspSalidas"
        Me.chbPortesEspSalidas.Size = New System.Drawing.Size(15, 23)
        Me.chbPortesEspSalidas.TabIndex = 29
        '
        'lblPortesEspSalidas
        '
        Me.lblPortesEspSalidas.Location = New System.Drawing.Point(5, 5)
        Me.lblPortesEspSalidas.Name = "lblPortesEspSalidas"
        Me.lblPortesEspSalidas.Size = New System.Drawing.Size(151, 13)
        Me.lblPortesEspSalidas.TabIndex = 4
        Me.lblPortesEspSalidas.Text = "Portes especiales Salidas"
        '
        'lblPortesEspRetornos
        '
        Me.lblPortesEspRetornos.Location = New System.Drawing.Point(184, 5)
        Me.lblPortesEspRetornos.Name = "lblPortesEspRetornos"
        Me.lblPortesEspRetornos.Size = New System.Drawing.Size(161, 13)
        Me.lblPortesEspRetornos.TabIndex = 6
        Me.lblPortesEspRetornos.Text = "Portes especiales Retornos"
        '
        'pnlImporteFacturado
        '
        Me.pnlImporteFacturado.Controls.Add(Me.txtImpQFactA)
        Me.pnlImporteFacturado.Controls.Add(Me.lblImporteFacturado)
        Me.pnlImporteFacturado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlImporteFacturado.Location = New System.Drawing.Point(0, 141)
        Me.pnlImporteFacturado.Name = "pnlImporteFacturado"
        Me.pnlImporteFacturado.Size = New System.Drawing.Size(374, 27)
        Me.pnlImporteFacturado.TabIndex = 1
        '
        'txtImpQFactA
        '
        Me.TryDataBinding(txtImpQFactA, New System.Windows.Forms.Binding("Value", Me, "ImpQFactA", True))
        Me.txtImpQFactA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpQFactA.Enabled = False
        Me.txtImpQFactA.Location = New System.Drawing.Point(248, 3)
        Me.txtImpQFactA.Name = "txtImpQFactA"
        Me.txtImpQFactA.Size = New System.Drawing.Size(121, 21)
        Me.txtImpQFactA.TabIndex = 1
        Me.txtImpQFactA.TabStop = False
        '
        'lblImporteFacturado
        '
        Me.lblImporteFacturado.Location = New System.Drawing.Point(132, 3)
        Me.lblImporteFacturado.Name = "lblImporteFacturado"
        Me.lblImporteFacturado.Size = New System.Drawing.Size(112, 13)
        Me.lblImporteFacturado.TabIndex = 0
        Me.lblImporteFacturado.Text = "Importe Facturado"
        '
        'FraCondEconom
        '
        Me.FraCondEconom.Controls.Add(Me.txtPedidoClienteAbierto)
        Me.FraCondEconom.Controls.Add(Me.chkFacturarPlusPorContadores)
        Me.FraCondEconom.Controls.Add(Me.chkPedidoClienteAbierto)
        Me.FraCondEconom.Controls.Add(Me.chkNoFacturaPortes)
        Me.FraCondEconom.Controls.Add(Me.chkFacturarTasaResiduos)
        Me.FraCondEconom.Controls.Add(Me.chkFacturarDiasMinimos)
        Me.FraCondEconom.Controls.Add(Me.lblAsterisco)
        Me.FraCondEconom.Controls.Add(Me.lblTextoInfo)
        Me.FraCondEconom.Controls.Add(Me.FraBanco)
        Me.FraCondEconom.Controls.Add(Me.txtDiaFacturacion)
        Me.FraCondEconom.Controls.Add(Me.advIDCondicionEnvio)
        Me.FraCondEconom.Controls.Add(Me.advIDMoneda)
        Me.FraCondEconom.Controls.Add(Me.lblDiaPago)
        Me.FraCondEconom.Controls.Add(Me.AdvIDDiaPago)
        Me.FraCondEconom.Controls.Add(Me.lblCondicionPago)
        Me.FraCondEconom.Controls.Add(Me.AdvIDCondicionPago)
        Me.FraCondEconom.Controls.Add(Me.lblFormaPago)
        Me.FraCondEconom.Controls.Add(Me.AdvIDFormaPago)
        Me.FraCondEconom.Controls.Add(Me.lblIDMoneda)
        Me.FraCondEconom.Controls.Add(Me.lblIDCondicionEnvio)
        Me.FraCondEconom.Controls.Add(Me.lblDiaFacturacion)
        Me.FraCondEconom.Controls.Add(Me.lblFacturarDiasMinimos)
        Me.FraCondEconom.Controls.Add(Me.lblFacturarTasaResiduos)
        Me.FraCondEconom.Controls.Add(Me.lblNoFacturaPortes)
        Me.FraCondEconom.Controls.Add(Me.lblPedidoClienteAbierto)
        Me.FraCondEconom.Controls.Add(Me.lblFacturarPlusPorContadores)
        Me.FraCondEconom.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraCondEconom.Location = New System.Drawing.Point(0, 171)
        Me.FraCondEconom.Name = "FraCondEconom"
        Me.FraCondEconom.Size = New System.Drawing.Size(782, 146)
        Me.FraCondEconom.TabIndex = 219
        Me.FraCondEconom.TabStop = False
        Me.FraCondEconom.Text = "Condiciones Económicas"
        '
        'txtPedidoClienteAbierto
        '
        Me.TryDataBinding(txtPedidoClienteAbierto, New System.Windows.Forms.Binding("Text", Me, "PedidoClienteAbierto", True))
        Me.txtPedidoClienteAbierto.DisabledBackColor = System.Drawing.Color.White
        Me.txtPedidoClienteAbierto.Location = New System.Drawing.Point(664, 117)
        Me.txtPedidoClienteAbierto.Name = "txtPedidoClienteAbierto"
        Me.txtPedidoClienteAbierto.Size = New System.Drawing.Size(90, 21)
        Me.txtPedidoClienteAbierto.TabIndex = 27
        Me.txtPedidoClienteAbierto.Visible = False
        '
        'chkFacturarPlusPorContadores
        '
        Me.TryDataBinding(chkFacturarPlusPorContadores, New System.Windows.Forms.Binding("BindableValue", Me, "FacturarPlusPorContadores", True))
        Me.chkFacturarPlusPorContadores.Location = New System.Drawing.Point(578, 33)
        Me.chkFacturarPlusPorContadores.Name = "chkFacturarPlusPorContadores"
        Me.chkFacturarPlusPorContadores.Size = New System.Drawing.Size(15, 23)
        Me.chkFacturarPlusPorContadores.TabIndex = 23
        '
        'chkPedidoClienteAbierto
        '
        Me.TryDataBinding(chkPedidoClienteAbierto, New System.Windows.Forms.Binding("BindableValue", Me, "ObraPedClteAbierto", True))
        Me.chkPedidoClienteAbierto.Location = New System.Drawing.Point(578, 93)
        Me.chkPedidoClienteAbierto.Name = "chkPedidoClienteAbierto"
        Me.chkPedidoClienteAbierto.Size = New System.Drawing.Size(15, 23)
        Me.chkPedidoClienteAbierto.TabIndex = 26
        '
        'chkNoFacturaPortes
        '
        Me.TryDataBinding(chkNoFacturaPortes, New System.Windows.Forms.Binding("BindableValue", Me, "NoFacturaPortes", True))
        Me.chkNoFacturaPortes.Location = New System.Drawing.Point(578, 73)
        Me.chkNoFacturaPortes.Name = "chkNoFacturaPortes"
        Me.chkNoFacturaPortes.Size = New System.Drawing.Size(15, 23)
        Me.chkNoFacturaPortes.TabIndex = 25
        '
        'chkFacturarTasaResiduos
        '
        Me.TryDataBinding(chkFacturarTasaResiduos, New System.Windows.Forms.Binding("BindableValue", Me, "FacturarTasaResiduos", True))
        Me.chkFacturarTasaResiduos.Location = New System.Drawing.Point(578, 53)
        Me.chkFacturarTasaResiduos.Name = "chkFacturarTasaResiduos"
        Me.chkFacturarTasaResiduos.Size = New System.Drawing.Size(15, 23)
        Me.chkFacturarTasaResiduos.TabIndex = 24
        '
        'chkFacturarDiasMinimos
        '
        Me.TryDataBinding(chkFacturarDiasMinimos, New System.Windows.Forms.Binding("BindableValue", Me, "FacturarDiasMinimos", True))
        Me.chkFacturarDiasMinimos.Location = New System.Drawing.Point(578, 11)
        Me.chkFacturarDiasMinimos.Name = "chkFacturarDiasMinimos"
        Me.chkFacturarDiasMinimos.Size = New System.Drawing.Size(15, 23)
        Me.chkFacturarDiasMinimos.TabIndex = 22
        '
        'lblAsterisco
        '
        Me.lblAsterisco.Location = New System.Drawing.Point(508, 22)
        Me.lblAsterisco.Name = "lblAsterisco"
        Me.lblAsterisco.Size = New System.Drawing.Size(24, 13)
        Me.lblAsterisco.TabIndex = 147
        Me.lblAsterisco.Text = "(*)"
        '
        'lblTextoInfo
        '
        Me.lblTextoInfo.Location = New System.Drawing.Point(5, 126)
        Me.lblTextoInfo.Name = "lblTextoInfo"
        Me.lblTextoInfo.Size = New System.Drawing.Size(606, 13)
        Me.lblTextoInfo.TabIndex = 146
        Me.lblTextoInfo.Text = "(*) Únicamente se debe introducir día de facturación en los Alquileres que no se " & _
            "facturen a final de mes."
        '
        'FraBanco
        '
        Me.FraBanco.Controls.Add(Me.lblSucursal)
        Me.FraBanco.Controls.Add(Me.txtSucursal)
        Me.FraBanco.Controls.Add(Me.lblDC)
        Me.FraBanco.Controls.Add(Me.txtDC)
        Me.FraBanco.Controls.Add(Me.lblNCuenta)
        Me.FraBanco.Controls.Add(Me.txtNCuenta)
        Me.FraBanco.Controls.Add(Me.ulDescClienteBanco)
        Me.FraBanco.Controls.Add(Me.lblIdClienteBanco)
        Me.FraBanco.Controls.Add(Me.AdvIDClienteBanco)
        Me.FraBanco.Location = New System.Drawing.Point(175, 47)
        Me.FraBanco.Name = "FraBanco"
        Me.FraBanco.Size = New System.Drawing.Size(392, 74)
        Me.FraBanco.TabIndex = 145
        Me.FraBanco.TabStop = False
        Me.FraBanco.Text = "Datos Banco"
        '
        'lblSucursal
        '
        Me.lblSucursal.Location = New System.Drawing.Point(9, 50)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(56, 13)
        Me.lblSucursal.TabIndex = 224
        Me.lblSucursal.Text = "Sucursal"
        '
        'txtSucursal
        '
        Me.TryDataBinding(txtSucursal, New System.Windows.Forms.Binding("Text", Me.AdvIDClienteBanco, "Sucursal", True))
        Me.txtSucursal.DisabledBackColor = System.Drawing.Color.White
        Me.txtSucursal.Enabled = False
        Me.txtSucursal.Location = New System.Drawing.Point(65, 46)
        Me.txtSucursal.MaxLength = 4
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(55, 21)
        Me.txtSucursal.TabIndex = 221
        Me.txtSucursal.TabStop = False
        '
        'lblDC
        '
        Me.lblDC.Location = New System.Drawing.Point(128, 50)
        Me.lblDC.Name = "lblDC"
        Me.lblDC.Size = New System.Drawing.Size(33, 13)
        Me.lblDC.TabIndex = 225
        Me.lblDC.Text = "D.C."
        '
        'txtDC
        '
        Me.TryDataBinding(txtDC, New System.Windows.Forms.Binding("Text", Me.AdvIDClienteBanco, "DigitoControl", True))
        Me.txtDC.DisabledBackColor = System.Drawing.Color.White
        Me.txtDC.Enabled = False
        Me.txtDC.Location = New System.Drawing.Point(165, 46)
        Me.txtDC.MaxLength = 2
        Me.txtDC.Name = "txtDC"
        Me.txtDC.Size = New System.Drawing.Size(31, 21)
        Me.txtDC.TabIndex = 222
        Me.txtDC.TabStop = False
        '
        'lblNCuenta
        '
        Me.lblNCuenta.Location = New System.Drawing.Point(208, 50)
        Me.lblNCuenta.Name = "lblNCuenta"
        Me.lblNCuenta.Size = New System.Drawing.Size(66, 13)
        Me.lblNCuenta.TabIndex = 226
        Me.lblNCuenta.Text = "Nº Cuenta"
        '
        'txtNCuenta
        '
        Me.TryDataBinding(txtNCuenta, New System.Windows.Forms.Binding("Text", Me.AdvIDClienteBanco, "NCuenta", True))
        Me.txtNCuenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtNCuenta.Enabled = False
        Me.txtNCuenta.Location = New System.Drawing.Point(275, 46)
        Me.txtNCuenta.MaxLength = 10
        Me.txtNCuenta.Name = "txtNCuenta"
        Me.txtNCuenta.Size = New System.Drawing.Size(103, 21)
        Me.txtNCuenta.TabIndex = 223
        Me.txtNCuenta.TabStop = False
        '
        'ulDescClienteBanco
        '
        Me.ulDescClienteBanco.Location = New System.Drawing.Point(157, 19)
        Me.ulDescClienteBanco.Name = "ulDescClienteBanco"
        Me.ulDescClienteBanco.Size = New System.Drawing.Size(221, 23)
        Me.ulDescClienteBanco.TabIndex = 220
        '
        'lblIdClienteBanco
        '
        Me.lblIdClienteBanco.Location = New System.Drawing.Point(9, 23)
        Me.lblIdClienteBanco.Name = "lblIdClienteBanco"
        Me.lblIdClienteBanco.Size = New System.Drawing.Size(42, 13)
        Me.lblIdClienteBanco.TabIndex = 219
        Me.lblIdClienteBanco.Text = "Banco"
        '
        'AdvIDClienteBanco
        '
        Me.TryDataBinding(AdvIDClienteBanco, New System.Windows.Forms.Binding("Text", Me, "IDClienteBanco", True))
        Me.AdvIDClienteBanco.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDClienteBanco.EntityName = "ClienteBanco"
        Me.AdvIDClienteBanco.Location = New System.Drawing.Point(65, 19)
        Me.AdvIDClienteBanco.Name = "AdvIDClienteBanco"
        Me.AdvIDClienteBanco.PrimaryDataFields = "IDClienteBanco"
        Me.AdvIDClienteBanco.SecondaryDataFields = "IDClienteBanco"
        Me.AdvIDClienteBanco.Size = New System.Drawing.Size(86, 23)
        Me.AdvIDClienteBanco.TabIndex = 21
        Me.AdvIDClienteBanco.ViewName = "tbClienteBanco"
        '
        'txtDiaFacturacion
        '
        Me.TryDataBinding(txtDiaFacturacion, New System.Windows.Forms.Binding("Text", Me, "DiaFacturacion", True))
        Me.txtDiaFacturacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDiaFacturacion.Location = New System.Drawing.Point(444, 19)
        Me.txtDiaFacturacion.Name = "txtDiaFacturacion"
        Me.txtDiaFacturacion.Size = New System.Drawing.Size(63, 21)
        Me.txtDiaFacturacion.TabIndex = 20
        Me.txtDiaFacturacion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'advIDCondicionEnvio
        '
        Me.TryDataBinding(advIDCondicionEnvio, New System.Windows.Forms.Binding("Text", Me, "IDCondicionEnvio", True))
        Me.advIDCondicionEnvio.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCondicionEnvio.EntityName = "CondicionEnvio"
        Me.advIDCondicionEnvio.Location = New System.Drawing.Point(70, 99)
        Me.advIDCondicionEnvio.Name = "advIDCondicionEnvio"
        Me.advIDCondicionEnvio.PrimaryDataFields = "IDCondicionEnvio"
        Me.advIDCondicionEnvio.SecondaryDataFields = "IDCondicionEnvio"
        Me.advIDCondicionEnvio.Size = New System.Drawing.Size(99, 23)
        Me.advIDCondicionEnvio.TabIndex = 18
        Me.advIDCondicionEnvio.ViewName = "tbMaestroCondicionEnvio"
        '
        'advIDMoneda
        '
        Me.TryDataBinding(advIDMoneda, New System.Windows.Forms.Binding("Text", Me, "IDMoneda", True))
        Me.advIDMoneda.DisabledBackColor = System.Drawing.Color.White
        Me.advIDMoneda.EntityName = "Moneda"
        Me.advIDMoneda.Location = New System.Drawing.Point(240, 19)
        Me.advIDMoneda.Name = "advIDMoneda"
        Me.advIDMoneda.PrimaryDataFields = "IDMoneda"
        Me.advIDMoneda.SecondaryDataFields = "IDMoneda"
        Me.advIDMoneda.Size = New System.Drawing.Size(93, 23)
        Me.advIDMoneda.TabIndex = 19
        '
        'lblDiaPago
        '
        Me.lblDiaPago.Location = New System.Drawing.Point(8, 78)
        Me.lblDiaPago.Name = "lblDiaPago"
        Me.lblDiaPago.Size = New System.Drawing.Size(58, 13)
        Me.lblDiaPago.TabIndex = 0
        Me.lblDiaPago.Text = "Día Pago"
        '
        'AdvIDDiaPago
        '
        Me.TryDataBinding(AdvIDDiaPago, New System.Windows.Forms.Binding("Text", Me, "IDDiaPago", True))
        Me.AdvIDDiaPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDDiaPago.EntityName = "DiaPago"
        Me.AdvIDDiaPago.Location = New System.Drawing.Point(70, 73)
        Me.AdvIDDiaPago.Name = "AdvIDDiaPago"
        Me.AdvIDDiaPago.PrimaryDataFields = "IDDiaPago"
        Me.AdvIDDiaPago.SecondaryDataFields = "IDDiaPago"
        Me.AdvIDDiaPago.Size = New System.Drawing.Size(99, 23)
        Me.AdvIDDiaPago.TabIndex = 17
        Me.AdvIDDiaPago.ViewName = "tbMaestroDiaPago"
        '
        'lblCondicionPago
        '
        Me.lblCondicionPago.Location = New System.Drawing.Point(8, 52)
        Me.lblCondicionPago.Name = "lblCondicionPago"
        Me.lblCondicionPago.Size = New System.Drawing.Size(52, 13)
        Me.lblCondicionPago.TabIndex = 136
        Me.lblCondicionPago.Text = "C. Pago"
        '
        'AdvIDCondicionPago
        '
        Me.TryDataBinding(AdvIDCondicionPago, New System.Windows.Forms.Binding("Text", Me, "IDCondicionPago", True))
        Me.AdvIDCondicionPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCondicionPago.EntityName = "CondicionPago"
        Me.AdvIDCondicionPago.Location = New System.Drawing.Point(70, 47)
        Me.AdvIDCondicionPago.Name = "AdvIDCondicionPago"
        Me.AdvIDCondicionPago.PrimaryDataFields = "IDCondicionPago"
        Me.AdvIDCondicionPago.SecondaryDataFields = "IDCondicionPago"
        Me.AdvIDCondicionPago.Size = New System.Drawing.Size(99, 23)
        Me.AdvIDCondicionPago.TabIndex = 16
        Me.AdvIDCondicionPago.ViewName = "tbMaestroCondicionPago"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Location = New System.Drawing.Point(8, 26)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(47, 13)
        Me.lblFormaPago.TabIndex = 138
        Me.lblFormaPago.Text = "F. Pago"
        '
        'AdvIDFormaPago
        '
        Me.TryDataBinding(AdvIDFormaPago, New System.Windows.Forms.Binding("Text", Me, "IDFormaPago", True))
        Me.AdvIDFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDFormaPago.EntityName = "FormaPago"
        Me.AdvIDFormaPago.Location = New System.Drawing.Point(70, 21)
        Me.AdvIDFormaPago.Name = "AdvIDFormaPago"
        Me.AdvIDFormaPago.PrimaryDataFields = "IDFormaPago"
        Me.AdvIDFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.AdvIDFormaPago.Size = New System.Drawing.Size(99, 23)
        Me.AdvIDFormaPago.TabIndex = 15
        Me.AdvIDFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'lblIDMoneda
        '
        Me.lblIDMoneda.Location = New System.Drawing.Point(184, 23)
        Me.lblIDMoneda.Name = "lblIDMoneda"
        Me.lblIDMoneda.Size = New System.Drawing.Size(51, 13)
        Me.lblIDMoneda.TabIndex = 139
        Me.lblIDMoneda.Text = "Moneda"
        '
        'lblIDCondicionEnvio
        '
        Me.lblIDCondicionEnvio.Location = New System.Drawing.Point(8, 104)
        Me.lblIDCondicionEnvio.Name = "lblIDCondicionEnvio"
        Me.lblIDCondicionEnvio.Size = New System.Drawing.Size(55, 13)
        Me.lblIDCondicionEnvio.TabIndex = 141
        Me.lblIDCondicionEnvio.Text = "C. Envío"
        '
        'lblDiaFacturacion
        '
        Me.lblDiaFacturacion.Location = New System.Drawing.Point(345, 23)
        Me.lblDiaFacturacion.Name = "lblDiaFacturacion"
        Me.lblDiaFacturacion.Size = New System.Drawing.Size(94, 13)
        Me.lblDiaFacturacion.TabIndex = 143
        Me.lblDiaFacturacion.Text = "Día Facturación"
        '
        'lblFacturarDiasMinimos
        '
        Me.lblFacturarDiasMinimos.Location = New System.Drawing.Point(595, 15)
        Me.lblFacturarDiasMinimos.Name = "lblFacturarDiasMinimos"
        Me.lblFacturarDiasMinimos.Size = New System.Drawing.Size(132, 13)
        Me.lblFacturarDiasMinimos.TabIndex = 148
        Me.lblFacturarDiasMinimos.Text = "Facturar Días Mínimos"
        '
        'lblFacturarTasaResiduos
        '
        Me.lblFacturarTasaResiduos.Location = New System.Drawing.Point(595, 56)
        Me.lblFacturarTasaResiduos.Name = "lblFacturarTasaResiduos"
        Me.lblFacturarTasaResiduos.Size = New System.Drawing.Size(138, 13)
        Me.lblFacturarTasaResiduos.TabIndex = 152
        Me.lblFacturarTasaResiduos.Text = "Facturar Tasa Residuos"
        '
        'lblNoFacturaPortes
        '
        Me.lblNoFacturaPortes.Location = New System.Drawing.Point(595, 76)
        Me.lblNoFacturaPortes.Name = "lblNoFacturaPortes"
        Me.lblNoFacturaPortes.Size = New System.Drawing.Size(112, 13)
        Me.lblNoFacturaPortes.TabIndex = 154
        Me.lblNoFacturaPortes.Text = "No Facturar Portes"
        '
        'lblPedidoClienteAbierto
        '
        Me.lblPedidoClienteAbierto.Location = New System.Drawing.Point(595, 97)
        Me.lblPedidoClienteAbierto.Name = "lblPedidoClienteAbierto"
        Me.lblPedidoClienteAbierto.Size = New System.Drawing.Size(134, 13)
        Me.lblPedidoClienteAbierto.TabIndex = 156
        Me.lblPedidoClienteAbierto.Text = "Pedido Cliente Abierto"
        '
        'lblFacturarPlusPorContadores
        '
        Me.lblFacturarPlusPorContadores.Location = New System.Drawing.Point(595, 36)
        Me.lblFacturarPlusPorContadores.Name = "lblFacturarPlusPorContadores"
        Me.lblFacturarPlusPorContadores.Size = New System.Drawing.Size(167, 13)
        Me.lblFacturarPlusPorContadores.TabIndex = 158
        Me.lblFacturarPlusPorContadores.Text = "Facturar Exceso Contadores"
        '
        'pnlTopCabeceraAlquiler
        '
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.chbBloqueado)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.lblBloqueado)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.lblCentroGestion)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.cbxIDCentroGestion)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.advIDClasificacionObra)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.advIDAlmacen)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.advIDObraCalendario)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.chkClienteGenerico)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.chkAlbaranValorado)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.FraClientes)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.lblTipoObra)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.ulDescTipoObra)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.FraFechas)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.AdvIDTipoObra)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.lblAlbaranValorado)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.lblClienteGenerico)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.lblIDObraCalendario)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.lblIDAlmacen)
        Me.pnlTopCabeceraAlquiler.Controls.Add(Me.lblIDClasificacionObra)
        Me.pnlTopCabeceraAlquiler.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopCabeceraAlquiler.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopCabeceraAlquiler.Name = "pnlTopCabeceraAlquiler"
        Me.pnlTopCabeceraAlquiler.Size = New System.Drawing.Size(782, 171)
        Me.pnlTopCabeceraAlquiler.TabIndex = 218
        '
        'chbBloqueado
        '
        Me.TryDataBinding(chbBloqueado, New System.Windows.Forms.Binding("BindableValue", Me, "Bloqueado", True))
        Me.chbBloqueado.Location = New System.Drawing.Point(758, 70)
        Me.chbBloqueado.Name = "chbBloqueado"
        Me.chbBloqueado.Size = New System.Drawing.Size(15, 15)
        Me.chbBloqueado.TabIndex = 239
        '
        'lblBloqueado
        '
        Me.lblBloqueado.Location = New System.Drawing.Point(826, 4)
        Me.lblBloqueado.Name = "lblBloqueado"
        Me.lblBloqueado.Size = New System.Drawing.Size(67, 13)
        Me.lblBloqueado.TabIndex = 240
        Me.lblBloqueado.Text = "Bloqueado"
        '
        'lblCentroGestion
        '
        Me.lblCentroGestion.Location = New System.Drawing.Point(345, 59)
        Me.lblCentroGestion.Name = "lblCentroGestion"
        Me.lblCentroGestion.Size = New System.Drawing.Size(93, 13)
        Me.lblCentroGestion.TabIndex = 238
        Me.lblCentroGestion.Text = "Centro Gestión"
        '
        'cbxIDCentroGestion
        '
        Me.TryDataBinding(cbxIDCentroGestion, New System.Windows.Forms.Binding("Value", Me, "IDCentroGestion", True))
        cbxIDCentroGestion_DesignTimeLayout.LayoutString = resources.GetString("cbxIDCentroGestion_DesignTimeLayout.LayoutString")
        Me.cbxIDCentroGestion.DesignTimeLayout = cbxIDCentroGestion_DesignTimeLayout
        Me.cbxIDCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDCentroGestion.DisplayMember = "IDCentroGestion"
        Me.cbxIDCentroGestion.EntityName = "CentroGestion"
        Me.cbxIDCentroGestion.Location = New System.Drawing.Point(472, 55)
        Me.cbxIDCentroGestion.Name = "cbxIDCentroGestion"
        Me.cbxIDCentroGestion.PrimaryDataFields = "IDCentroGestion"
        Me.cbxIDCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.cbxIDCentroGestion.SelectedIndex = -1
        Me.cbxIDCentroGestion.SelectedItem = Nothing
        Me.cbxIDCentroGestion.Size = New System.Drawing.Size(114, 21)
        Me.cbxIDCentroGestion.TabIndex = 11
        '
        'advIDClasificacionObra
        '
        Me.TryDataBinding(advIDClasificacionObra, New System.Windows.Forms.Binding("Text", Me, "IDClasificacionObra", True))
        Me.advIDClasificacionObra.DisabledBackColor = System.Drawing.Color.White
        Me.advIDClasificacionObra.EntityName = "ClasificacionObra"
        Me.advIDClasificacionObra.Location = New System.Drawing.Point(472, 29)
        Me.advIDClasificacionObra.Name = "advIDClasificacionObra"
        Me.advIDClasificacionObra.PrimaryDataFields = "IDClasificacionObra"
        Me.advIDClasificacionObra.SecondaryDataFields = "IDClasificacionObra"
        Me.advIDClasificacionObra.Size = New System.Drawing.Size(114, 23)
        Me.advIDClasificacionObra.TabIndex = 10
        '
        'advIDAlmacen
        '
        Me.TryDataBinding(advIDAlmacen, New System.Windows.Forms.Binding("Text", Me, "IDAlmacen", True))
        Me.advIDAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advIDAlmacen.EntityName = "Almacen"
        Me.advIDAlmacen.Location = New System.Drawing.Point(197, 55)
        Me.advIDAlmacen.Name = "advIDAlmacen"
        Me.advIDAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.Size = New System.Drawing.Size(114, 23)
        Me.advIDAlmacen.TabIndex = 9
        '
        'advIDObraCalendario
        '
        Me.TryDataBinding(advIDObraCalendario, New System.Windows.Forms.Binding("Value", Me, "IDObraCalendario", True))
        Me.advIDObraCalendario.DisabledBackColor = System.Drawing.Color.White
        Me.advIDObraCalendario.DisplayField = "NObra"
        Me.advIDObraCalendario.EntityName = "ObraCabecera"
        Me.advIDObraCalendario.Location = New System.Drawing.Point(197, 29)
        Me.advIDObraCalendario.Name = "advIDObraCalendario"
        Me.advIDObraCalendario.PrimaryDataFields = "IDObraCalendario"
        Me.advIDObraCalendario.SecondaryDataFields = "IDObra"
        Me.advIDObraCalendario.Size = New System.Drawing.Size(114, 23)
        Me.advIDObraCalendario.TabIndex = 8
        '
        'chkClienteGenerico
        '
        Me.TryDataBinding(chkClienteGenerico, New System.Windows.Forms.Binding("BindableValue", Me, "ClienteGenerico", True))
        Me.chkClienteGenerico.Location = New System.Drawing.Point(758, 49)
        Me.chkClienteGenerico.Name = "chkClienteGenerico"
        Me.chkClienteGenerico.Size = New System.Drawing.Size(15, 23)
        Me.chkClienteGenerico.TabIndex = 13
        '
        'chkAlbaranValorado
        '
        Me.TryDataBinding(chkAlbaranValorado, New System.Windows.Forms.Binding("BindableValue", Me, "AlbaranValorado", True))
        Me.chkAlbaranValorado.Location = New System.Drawing.Point(758, 29)
        Me.chkAlbaranValorado.Name = "chkAlbaranValorado"
        Me.chkAlbaranValorado.Size = New System.Drawing.Size(15, 23)
        Me.chkAlbaranValorado.TabIndex = 12
        '
        'FraClientes
        '
        Me.FraClientes.Controls.Add(Me.Button1)
        Me.FraClientes.Controls.Add(Me.TextBox2)
        Me.FraClientes.Controls.Add(Me.cmbDocumentacion)
        Me.FraClientes.Controls.Add(Me.ntbDtoComercial)
        Me.FraClientes.Controls.Add(Me.txtCifCliente)
        Me.FraClientes.Controls.Add(Me.lblPoblacion)
        Me.FraClientes.Controls.Add(Me.txtPoblacion)
        Me.FraClientes.Controls.Add(Me.lblCodPostal)
        Me.FraClientes.Controls.Add(Me.txtCodPostal)
        Me.FraClientes.Controls.Add(Me.lblProvincia)
        Me.FraClientes.Controls.Add(Me.txtProvincia)
        Me.FraClientes.Controls.Add(Me.lblDireccion)
        Me.FraClientes.Controls.Add(Me.txtDireccion)
        Me.FraClientes.Controls.Add(Me.lblCliente)
        Me.FraClientes.Controls.Add(Me.ulDescCliente)
        Me.FraClientes.Controls.Add(Me.AdvIDCliente)
        Me.FraClientes.Controls.Add(Me.lblCifCliente)
        Me.FraClientes.Controls.Add(Me.lblDtoComercial)
        Me.FraClientes.Controls.Add(Me.txtIDEmpresa)
        Me.FraClientes.Location = New System.Drawing.Point(106, 78)
        Me.FraClientes.Name = "FraClientes"
        Me.FraClientes.Size = New System.Drawing.Size(674, 91)
        Me.FraClientes.TabIndex = 220
        Me.FraClientes.TabStop = False
        Me.FraClientes.Text = "Datos Cliente"
        '
        'TextBox2
        '
        Me.TryDataBinding(TextBox2, New System.Windows.Forms.Binding("Text", Me, "DireccionCli", True))
        Me.TextBox2.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(234, 7)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 21)
        Me.TextBox2.TabIndex = 100
        Me.TextBox2.Visible = False
        '
        'cmbDocumentacion
        '
        Me.cmbDocumentacion.Image = Global.Solmicro.Expertis.Application.ERP.Alquiler.My.Resources.Resources.index
        Me.cmbDocumentacion.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmbDocumentacion.Location = New System.Drawing.Point(624, 42)
        Me.cmbDocumentacion.Name = "cmbDocumentacion"
        Me.cmbDocumentacion.Size = New System.Drawing.Size(43, 45)
        Me.cmbDocumentacion.TabIndex = 98
        '
        'ntbDtoComercial
        '
        Me.TryDataBinding(ntbDtoComercial, New System.Windows.Forms.Binding("Value", Me.AdvIDCliente, "DtoComercial", True))
        Me.ntbDtoComercial.DisabledBackColor = System.Drawing.Color.White
        Me.ntbDtoComercial.Enabled = False
        Me.ntbDtoComercial.Location = New System.Drawing.Point(572, 42)
        Me.ntbDtoComercial.Name = "ntbDtoComercial"
        Me.ntbDtoComercial.Size = New System.Drawing.Size(50, 21)
        Me.ntbDtoComercial.TabIndex = 97
        Me.ntbDtoComercial.TabStop = False
        '
        'txtCifCliente
        '
        Me.TryDataBinding(txtCifCliente, New System.Windows.Forms.Binding("Text", Me.AdvIDCliente, "CifCliente", True))
        Me.txtCifCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtCifCliente.Enabled = False
        Me.txtCifCliente.Location = New System.Drawing.Point(461, 18)
        Me.txtCifCliente.Name = "txtCifCliente"
        Me.txtCifCliente.Size = New System.Drawing.Size(95, 21)
        Me.txtCifCliente.TabIndex = 95
        Me.txtCifCliente.TabStop = False
        '
        'lblPoblacion
        '
        Me.lblPoblacion.Location = New System.Drawing.Point(128, 69)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(61, 13)
        Me.lblPoblacion.TabIndex = 0
        Me.lblPoblacion.Text = "Población"
        '
        'txtPoblacion
        '
        Me.TryDataBinding(txtPoblacion, New System.Windows.Forms.Binding("Text", Me, "PoblacionCli", True))
        Me.txtPoblacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtPoblacion.Enabled = False
        Me.txtPoblacion.Location = New System.Drawing.Point(189, 66)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(213, 21)
        Me.txtPoblacion.TabIndex = 88
        Me.txtPoblacion.TabStop = False
        '
        'lblCodPostal
        '
        Me.lblCodPostal.Location = New System.Drawing.Point(1, 70)
        Me.lblCodPostal.Name = "lblCodPostal"
        Me.lblCodPostal.Size = New System.Drawing.Size(33, 13)
        Me.lblCodPostal.TabIndex = 89
        Me.lblCodPostal.Text = "C. P."
        '
        'txtCodPostal
        '
        Me.TryDataBinding(txtCodPostal, New System.Windows.Forms.Binding("Text", Me, "CodPostalCli", True))
        Me.txtCodPostal.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodPostal.Enabled = False
        Me.txtCodPostal.Location = New System.Drawing.Point(60, 64)
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(54, 21)
        Me.txtCodPostal.TabIndex = 87
        Me.txtCodPostal.TabStop = False
        '
        'lblProvincia
        '
        Me.lblProvincia.Location = New System.Drawing.Point(407, 70)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(59, 13)
        Me.lblProvincia.TabIndex = 90
        Me.lblProvincia.Text = "Provincia"
        '
        'txtProvincia
        '
        Me.TryDataBinding(txtProvincia, New System.Windows.Forms.Binding("Text", Me, "ProvinciaCli", True))
        Me.txtProvincia.DisabledBackColor = System.Drawing.Color.White
        Me.txtProvincia.Enabled = False
        Me.txtProvincia.Location = New System.Drawing.Point(469, 66)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(153, 21)
        Me.txtProvincia.TabIndex = 86
        Me.txtProvincia.TabStop = False
        '
        'lblDireccion
        '
        Me.lblDireccion.Location = New System.Drawing.Point(1, 45)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(60, 13)
        Me.lblDireccion.TabIndex = 91
        Me.lblDireccion.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.TryDataBinding(txtDireccion, New System.Windows.Forms.Binding("Text", Me, "DireccionCli", True))
        Me.txtDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(60, 42)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(466, 21)
        Me.txtDireccion.TabIndex = 85
        Me.txtDireccion.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(1, 20)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 92
        Me.lblCliente.Text = "Cliente"
        '
        'ulDescCliente
        '
        Me.TryDataBinding(ulDescCliente, New System.Windows.Forms.Binding("Text", Me.AdvIDCliente, "DescCliente", True))
        Me.ulDescCliente.Location = New System.Drawing.Point(185, 16)
        Me.ulDescCliente.Name = "ulDescCliente"
        Me.ulDescCliente.Size = New System.Drawing.Size(249, 23)
        Me.ulDescCliente.TabIndex = 93
        '
        'AdvIDCliente
        '
        Me.TryDataBinding(AdvIDCliente, New System.Windows.Forms.Binding("Text", Me, "IDCliente", True))
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(60, 16)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.PrimaryDataFields = "IDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(114, 23)
        Me.AdvIDCliente.TabIndex = 14
        Me.AdvIDCliente.ViewName = "tbMaestroCliente"
        '
        'lblCifCliente
        '
        Me.lblCifCliente.Location = New System.Drawing.Point(434, 20)
        Me.lblCifCliente.Name = "lblCifCliente"
        Me.lblCifCliente.Size = New System.Drawing.Size(26, 13)
        Me.lblCifCliente.TabIndex = 94
        Me.lblCifCliente.Text = "NIF"
        '
        'lblDtoComercial
        '
        Me.lblDtoComercial.Location = New System.Drawing.Point(541, 45)
        Me.lblDtoComercial.Name = "lblDtoComercial"
        Me.lblDtoComercial.Size = New System.Drawing.Size(31, 13)
        Me.lblDtoComercial.TabIndex = 96
        Me.lblDtoComercial.Text = "Dto."
        '
        'txtIDEmpresa
        '
        Me.TryDataBinding(txtIDEmpresa, New System.Windows.Forms.Binding("Text", Me.AdvIDCliente, "IDEmpresa", True))
        Me.txtIDEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDEmpresa.Enabled = False
        Me.txtIDEmpresa.Location = New System.Drawing.Point(290, 35)
        Me.txtIDEmpresa.Name = "txtIDEmpresa"
        Me.txtIDEmpresa.Size = New System.Drawing.Size(95, 21)
        Me.txtIDEmpresa.TabIndex = 99
        Me.txtIDEmpresa.TabStop = False
        Me.txtIDEmpresa.Visible = False
        '
        'lblTipoObra
        '
        Me.lblTipoObra.Location = New System.Drawing.Point(104, 7)
        Me.lblTipoObra.Name = "lblTipoObra"
        Me.lblTipoObra.Size = New System.Drawing.Size(78, 13)
        Me.lblTipoObra.TabIndex = 221
        Me.lblTipoObra.Text = "Tipo Alquiler"
        '
        'ulDescTipoObra
        '
        Me.TryDataBinding(ulDescTipoObra, New System.Windows.Forms.Binding("Text", Me.AdvIDTipoObra, "DescTipoObra", True))
        Me.ulDescTipoObra.Location = New System.Drawing.Point(316, 3)
        Me.ulDescTipoObra.Name = "ulDescTipoObra"
        Me.ulDescTipoObra.Size = New System.Drawing.Size(133, 23)
        Me.ulDescTipoObra.TabIndex = 222
        '
        'FraFechas
        '
        Me.FraFechas.Controls.Add(Me.lblFechaAlquiler)
        Me.FraFechas.Controls.Add(Me.cbxFechaAlquiler)
        Me.FraFechas.Controls.Add(Me.lblFechaInicio)
        Me.FraFechas.Controls.Add(Me.cbxFechaInicio)
        Me.FraFechas.Controls.Add(Me.lblFechaFin)
        Me.FraFechas.Controls.Add(Me.cbxFechaFin)
        Me.FraFechas.Location = New System.Drawing.Point(1, 5)
        Me.FraFechas.Name = "FraFechas"
        Me.FraFechas.Size = New System.Drawing.Size(100, 164)
        Me.FraFechas.TabIndex = 219
        Me.FraFechas.TabStop = False
        Me.FraFechas.Text = "Fechas"
        '
        'lblFechaAlquiler
        '
        Me.lblFechaAlquiler.Location = New System.Drawing.Point(6, 19)
        Me.lblFechaAlquiler.Name = "lblFechaAlquiler"
        Me.lblFechaAlquiler.Size = New System.Drawing.Size(87, 13)
        Me.lblFechaAlquiler.TabIndex = 6
        Me.lblFechaAlquiler.Text = "Fecha Alquiler"
        '
        'cbxFechaAlquiler
        '
        Me.TryDataBinding(cbxFechaAlquiler, New System.Windows.Forms.Binding("BindableValue", Me, "FechaObra", True))
        Me.cbxFechaAlquiler.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaAlquiler.Location = New System.Drawing.Point(6, 40)
        Me.cbxFechaAlquiler.Name = "cbxFechaAlquiler"
        Me.cbxFechaAlquiler.Size = New System.Drawing.Size(87, 21)
        Me.cbxFechaAlquiler.TabIndex = 4
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(6, 65)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(75, 13)
        Me.lblFechaInicio.TabIndex = 0
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'cbxFechaInicio
        '
        Me.TryDataBinding(cbxFechaInicio, New System.Windows.Forms.Binding("BindableValue", Me, "FechaInicio", True))
        Me.cbxFechaInicio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicio.Location = New System.Drawing.Point(6, 86)
        Me.cbxFechaInicio.Name = "cbxFechaInicio"
        Me.cbxFechaInicio.Size = New System.Drawing.Size(87, 21)
        Me.cbxFechaInicio.TabIndex = 5
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(6, 112)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(60, 13)
        Me.lblFechaFin.TabIndex = 5
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'cbxFechaFin
        '
        Me.TryDataBinding(cbxFechaFin, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFin", True))
        Me.cbxFechaFin.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFin.Location = New System.Drawing.Point(6, 133)
        Me.cbxFechaFin.Name = "cbxFechaFin"
        Me.cbxFechaFin.Size = New System.Drawing.Size(87, 21)
        Me.cbxFechaFin.TabIndex = 6
        '
        'AdvIDTipoObra
        '
        Me.TryDataBinding(AdvIDTipoObra, New System.Windows.Forms.Binding("Text", Me, "IDTipoObra", True))
        Me.AdvIDTipoObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTipoObra.EntityName = "ObraTipo"
        Me.AdvIDTipoObra.Location = New System.Drawing.Point(197, 3)
        Me.AdvIDTipoObra.Name = "AdvIDTipoObra"
        Me.AdvIDTipoObra.PrimaryDataFields = "IDTipoObra"
        Me.AdvIDTipoObra.SecondaryDataFields = "IDTipoObra"
        Me.AdvIDTipoObra.Size = New System.Drawing.Size(114, 23)
        Me.AdvIDTipoObra.TabIndex = 7
        Me.AdvIDTipoObra.ViewName = "tbObraTipo"
        '
        'lblAlbaranValorado
        '
        Me.lblAlbaranValorado.Location = New System.Drawing.Point(646, 34)
        Me.lblAlbaranValorado.Name = "lblAlbaranValorado"
        Me.lblAlbaranValorado.Size = New System.Drawing.Size(105, 13)
        Me.lblAlbaranValorado.TabIndex = 223
        Me.lblAlbaranValorado.Text = "Albarán Valorado"
        '
        'lblClienteGenerico
        '
        Me.lblClienteGenerico.Location = New System.Drawing.Point(646, 54)
        Me.lblClienteGenerico.Name = "lblClienteGenerico"
        Me.lblClienteGenerico.Size = New System.Drawing.Size(102, 13)
        Me.lblClienteGenerico.TabIndex = 225
        Me.lblClienteGenerico.Text = "Cliente Genérico"
        '
        'lblIDObraCalendario
        '
        Me.lblIDObraCalendario.Location = New System.Drawing.Point(104, 34)
        Me.lblIDObraCalendario.Name = "lblIDObraCalendario"
        Me.lblIDObraCalendario.Size = New System.Drawing.Size(95, 13)
        Me.lblIDObraCalendario.TabIndex = 231
        Me.lblIDObraCalendario.Text = "Calendario Ref."
        '
        'lblIDAlmacen
        '
        Me.lblIDAlmacen.Location = New System.Drawing.Point(104, 59)
        Me.lblIDAlmacen.Name = "lblIDAlmacen"
        Me.lblIDAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblIDAlmacen.TabIndex = 233
        Me.lblIDAlmacen.Text = "Almacén"
        '
        'lblIDClasificacionObra
        '
        Me.lblIDClasificacionObra.Location = New System.Drawing.Point(345, 34)
        Me.lblIDClasificacionObra.Name = "lblIDClasificacionObra"
        Me.lblIDClasificacionObra.Size = New System.Drawing.Size(125, 13)
        Me.lblIDClasificacionObra.TabIndex = 235
        Me.lblIDClasificacionObra.Text = "Clasificación Alquiler"
        '
        'TabPageCondiciones
        '
        Me.TabPageCondiciones.Controls.Add(Me.pnlSeguros)
        Me.TabPageCondiciones.Controls.Add(Me.Splitter2)
        Me.TabPageCondiciones.Controls.Add(Me.Splitter1)
        Me.TabPageCondiciones.Controls.Add(Me.pnlExcesoContadores)
        Me.TabPageCondiciones.Controls.Add(Me.pnlCondicionesArticuloTarifasDtos)
        Me.TabPageCondiciones.Key = "Condiciones"
        Me.TabPageCondiciones.Location = New System.Drawing.Point(1, 21)
        Me.TabPageCondiciones.Name = "TabPageCondiciones"
        Me.TabPageCondiciones.Size = New System.Drawing.Size(782, 485)
        Me.TabPageCondiciones.TabStop = True
        Me.TabPageCondiciones.Text = "Condiciones Alquiler"
        Me.TabPageCondiciones.Visible = False
        '
        'pnlSeguros
        '
        Me.pnlSeguros.Controls.Add(Me.GridSegurosExcesoContadores)
        Me.pnlSeguros.Controls.Add(Me.pnLabellSeguros)
        Me.pnlSeguros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSeguros.Location = New System.Drawing.Point(0, 230)
        Me.pnlSeguros.Name = "pnlSeguros"
        Me.pnlSeguros.Size = New System.Drawing.Size(782, 108)
        Me.pnlSeguros.TabIndex = 5
        '
        'GridSegurosExcesoContadores
        '
        Me.GridSegurosExcesoContadores.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipo", "TipoArticulo", "IDTipo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescTipo", "DescTipo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFamilia", "Familia", "IDFamilia", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTipo", "IDTipo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDFamilia", "IDFamilia"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescFamilia", "DescFamilia")}))})
        GridSegurosExcesoContadores_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridSegurosExcesoContadores_DesignTimeLayout_Reference_0.Instance"), Object)
        GridSegurosExcesoContadores_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridSegurosExcesoContadores_DesignTimeLayout_Reference_1.Instance"), Object)
        GridSegurosExcesoContadores_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridSegurosExcesoContadores_DesignTimeLayout_Reference_2.Instance"), Object)
        GridSegurosExcesoContadores_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridSegurosExcesoContadores_DesignTimeLayout_Reference_0, GridSegurosExcesoContadores_DesignTimeLayout_Reference_1, GridSegurosExcesoContadores_DesignTimeLayout_Reference_2})
        GridSegurosExcesoContadores_DesignTimeLayout.LayoutString = resources.GetString("GridSegurosExcesoContadores_DesignTimeLayout.LayoutString")
        Me.GridSegurosExcesoContadores.DesignTimeLayout = GridSegurosExcesoContadores_DesignTimeLayout
        Me.GridSegurosExcesoContadores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSegurosExcesoContadores.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridSegurosExcesoContadores.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridSegurosExcesoContadores.EntityName = "ObraTarifaAlquiler"
        Me.GridSegurosExcesoContadores.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridSegurosExcesoContadores.Location = New System.Drawing.Point(0, 26)
        Me.GridSegurosExcesoContadores.Name = "GridSegurosExcesoContadores"
        Me.GridSegurosExcesoContadores.PrimaryDataFields = "IDObra"
        Me.GridSegurosExcesoContadores.SecondaryDataFields = "IDObra"
        Me.GridSegurosExcesoContadores.Size = New System.Drawing.Size(782, 82)
        Me.GridSegurosExcesoContadores.TabIndex = 36
        Me.GridSegurosExcesoContadores.ViewName = "vFrmAlquilerExcesoContadores"
        '
        'pnLabellSeguros
        '
        Me.pnLabellSeguros.Controls.Add(Me.lblExcesoContadores)
        Me.pnLabellSeguros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnLabellSeguros.Location = New System.Drawing.Point(0, 0)
        Me.pnLabellSeguros.Name = "pnLabellSeguros"
        Me.pnLabellSeguros.Size = New System.Drawing.Size(782, 26)
        Me.pnLabellSeguros.TabIndex = 0
        '
        'lblExcesoContadores
        '
        Me.lblExcesoContadores.Location = New System.Drawing.Point(8, 7)
        Me.lblExcesoContadores.Name = "lblExcesoContadores"
        Me.lblExcesoContadores.Size = New System.Drawing.Size(135, 13)
        Me.lblExcesoContadores.TabIndex = 222
        Me.lblExcesoContadores.Text = "Exceso de Contadores"
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter2.Location = New System.Drawing.Point(0, 338)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(782, 5)
        Me.Splitter2.TabIndex = 4
        Me.Splitter2.TabStop = False
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 225)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(782, 5)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'pnlExcesoContadores
        '
        Me.pnlExcesoContadores.Controls.Add(Me.GridSeguros)
        Me.pnlExcesoContadores.Controls.Add(Me.pnllblSeguros)
        Me.pnlExcesoContadores.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlExcesoContadores.Location = New System.Drawing.Point(0, 343)
        Me.pnlExcesoContadores.Name = "pnlExcesoContadores"
        Me.pnlExcesoContadores.Size = New System.Drawing.Size(782, 142)
        Me.pnlExcesoContadores.TabIndex = 1
        '
        'GridSeguros
        '
        Me.GridSeguros.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipo", "TipoArticulo", "IDTipo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescTipo", "DescTipo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFamilia", "Familia", "IDFamilia", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTipo", "IDTipo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDFamilia", "IDFamilia"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescFamilia", "DescFamilia")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticuloFactura", "Articulo", "IDArticulo")})
        GridSeguros_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridSeguros_DesignTimeLayout_Reference_0.Instance"), Object)
        GridSeguros_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridSeguros_DesignTimeLayout_Reference_1.Instance"), Object)
        GridSeguros_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridSeguros_DesignTimeLayout_Reference_2.Instance"), Object)
        GridSeguros_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("GridSeguros_DesignTimeLayout_Reference_3.Instance"), Object)
        GridSeguros_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridSeguros_DesignTimeLayout_Reference_0, GridSeguros_DesignTimeLayout_Reference_1, GridSeguros_DesignTimeLayout_Reference_2, GridSeguros_DesignTimeLayout_Reference_3})
        GridSeguros_DesignTimeLayout.LayoutString = resources.GetString("GridSeguros_DesignTimeLayout.LayoutString")
        Me.GridSeguros.DesignTimeLayout = GridSeguros_DesignTimeLayout
        Me.GridSeguros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSeguros.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridSeguros.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridSeguros.EntityName = "ObraTarifaAlquiler"
        Me.GridSeguros.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridSeguros.Location = New System.Drawing.Point(0, 33)
        Me.GridSeguros.Name = "GridSeguros"
        Me.GridSeguros.PrimaryDataFields = "IDObra"
        Me.GridSeguros.SecondaryDataFields = "IDObra"
        Me.GridSeguros.Size = New System.Drawing.Size(782, 109)
        Me.GridSeguros.TabIndex = 38
        Me.GridSeguros.ViewName = "vFrmAlquilerCondicionesPorcentaje"
        '
        'pnllblSeguros
        '
        Me.pnllblSeguros.Controls.Add(Me.lblTipoSeguroImporte)
        Me.pnllblSeguros.Controls.Add(Me.cbxTipoSeguroImporte)
        Me.pnllblSeguros.Controls.Add(Me.lblSeguros)
        Me.pnllblSeguros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnllblSeguros.Location = New System.Drawing.Point(0, 0)
        Me.pnllblSeguros.Name = "pnllblSeguros"
        Me.pnllblSeguros.Size = New System.Drawing.Size(782, 33)
        Me.pnllblSeguros.TabIndex = 1
        '
        'lblTipoSeguroImporte
        '
        Me.lblTipoSeguroImporte.Location = New System.Drawing.Point(107, 7)
        Me.lblTipoSeguroImporte.Name = "lblTipoSeguroImporte"
        Me.lblTipoSeguroImporte.Size = New System.Drawing.Size(132, 13)
        Me.lblTipoSeguroImporte.TabIndex = 224
        Me.lblTipoSeguroImporte.Text = "Tipo Importe Seguros"
        '
        'cbxTipoSeguroImporte
        '
        Me.cbxTipoSeguroImporte.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.TryDataBinding(cbxTipoSeguroImporte, New System.Windows.Forms.Binding("Value", Me, "TipoGeneracionSeguros", True))
        cbxTipoSeguroImporte_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoSeguroImporte_DesignTimeLayout.LayoutString")
        Me.cbxTipoSeguroImporte.DesignTimeLayout = cbxTipoSeguroImporte_DesignTimeLayout
        Me.cbxTipoSeguroImporte.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoSeguroImporte.DisplayMember = "Value"
        Me.cbxTipoSeguroImporte.Location = New System.Drawing.Point(245, 7)
        Me.cbxTipoSeguroImporte.Name = "cbxTipoSeguroImporte"
        Me.cbxTipoSeguroImporte.PrimaryDataFields = "Estado"
        Me.cbxTipoSeguroImporte.SecondaryDataFields = "Value"
        Me.cbxTipoSeguroImporte.SelectedIndex = -1
        Me.cbxTipoSeguroImporte.SelectedItem = Nothing
        Me.cbxTipoSeguroImporte.Size = New System.Drawing.Size(112, 21)
        Me.cbxTipoSeguroImporte.TabIndex = 37
        '
        'lblSeguros
        '
        Me.lblSeguros.Location = New System.Drawing.Point(8, 7)
        Me.lblSeguros.Name = "lblSeguros"
        Me.lblSeguros.Size = New System.Drawing.Size(54, 13)
        Me.lblSeguros.TabIndex = 222
        Me.lblSeguros.Text = "Seguros"
        '
        'pnlCondicionesArticuloTarifasDtos
        '
        Me.pnlCondicionesArticuloTarifasDtos.Controls.Add(Me.pnlArticulos)
        Me.pnlCondicionesArticuloTarifasDtos.Controls.Add(Me.Splitter3)
        Me.pnlCondicionesArticuloTarifasDtos.Controls.Add(Me.pnlTarifasDtos)
        Me.pnlCondicionesArticuloTarifasDtos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCondicionesArticuloTarifasDtos.Location = New System.Drawing.Point(0, 0)
        Me.pnlCondicionesArticuloTarifasDtos.Name = "pnlCondicionesArticuloTarifasDtos"
        Me.pnlCondicionesArticuloTarifasDtos.Size = New System.Drawing.Size(782, 225)
        Me.pnlCondicionesArticuloTarifasDtos.TabIndex = 0
        '
        'pnlArticulos
        '
        Me.pnlArticulos.Controls.Add(Me.GridSegurosArticulos)
        Me.pnlArticulos.Controls.Add(Me.pnlLabelArticulos)
        Me.pnlArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlArticulos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlArticulos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlArticulos.Location = New System.Drawing.Point(0, 0)
        Me.pnlArticulos.Name = "pnlArticulos"
        Me.pnlArticulos.Size = New System.Drawing.Size(422, 225)
        Me.pnlArticulos.TabIndex = 3
        '
        'GridSegurosArticulos
        '
        Me.GridSegurosArticulos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")}))})
        GridSegurosArticulos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridSegurosArticulos_DesignTimeLayout_Reference_0.Instance"), Object)
        GridSegurosArticulos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridSegurosArticulos_DesignTimeLayout_Reference_0})
        GridSegurosArticulos_DesignTimeLayout.LayoutString = resources.GetString("GridSegurosArticulos_DesignTimeLayout.LayoutString")
        Me.GridSegurosArticulos.DesignTimeLayout = GridSegurosArticulos_DesignTimeLayout
        Me.GridSegurosArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSegurosArticulos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridSegurosArticulos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridSegurosArticulos.EntityName = "ObraTarifaAlquiler"
        Me.GridSegurosArticulos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridSegurosArticulos.Location = New System.Drawing.Point(0, 26)
        Me.GridSegurosArticulos.Name = "GridSegurosArticulos"
        Me.GridSegurosArticulos.PrimaryDataFields = "IDObra"
        Me.GridSegurosArticulos.SecondaryDataFields = "IDObra"
        Me.GridSegurosArticulos.Size = New System.Drawing.Size(422, 199)
        Me.GridSegurosArticulos.TabIndex = 33
        Me.GridSegurosArticulos.ViewName = "vFrmAlquilerCondicionesArticulos"
        '
        'pnlLabelArticulos
        '
        Me.pnlLabelArticulos.Controls.Add(Me.lblArticulos)
        Me.pnlLabelArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabelArticulos.Location = New System.Drawing.Point(0, 0)
        Me.pnlLabelArticulos.Name = "pnlLabelArticulos"
        Me.pnlLabelArticulos.Size = New System.Drawing.Size(422, 26)
        Me.pnlLabelArticulos.TabIndex = 0
        '
        'lblArticulos
        '
        Me.lblArticulos.Location = New System.Drawing.Point(8, 7)
        Me.lblArticulos.Name = "lblArticulos"
        Me.lblArticulos.Size = New System.Drawing.Size(56, 13)
        Me.lblArticulos.TabIndex = 223
        Me.lblArticulos.Text = "Artículos"
        '
        'Splitter3
        '
        Me.Splitter3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter3.Location = New System.Drawing.Point(422, 0)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(5, 225)
        Me.Splitter3.TabIndex = 2
        Me.Splitter3.TabStop = False
        '
        'pnlTarifasDtos
        '
        Me.pnlTarifasDtos.Controls.Add(Me.Panel3)
        Me.pnlTarifasDtos.Controls.Add(Me.Splitter4)
        Me.pnlTarifasDtos.Controls.Add(Me.Panel5)
        Me.pnlTarifasDtos.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlTarifasDtos.Location = New System.Drawing.Point(427, 0)
        Me.pnlTarifasDtos.Name = "pnlTarifasDtos"
        Me.pnlTarifasDtos.Size = New System.Drawing.Size(355, 225)
        Me.pnlTarifasDtos.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GridSegurosTarifas)
        Me.Panel3.Controls.Add(Me.pnlLabelTarifas)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(355, 111)
        Me.Panel3.TabIndex = 8
        '
        'GridSegurosTarifas
        '
        Me.GridSegurosTarifas.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTarifa", "Tarifa", "IDTarifa", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescTarifa", "DescTarifa")}))})
        GridSegurosTarifas_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridSegurosTarifas_DesignTimeLayout_Reference_0.Instance"), Object)
        GridSegurosTarifas_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridSegurosTarifas_DesignTimeLayout_Reference_0})
        GridSegurosTarifas_DesignTimeLayout.LayoutString = resources.GetString("GridSegurosTarifas_DesignTimeLayout.LayoutString")
        Me.GridSegurosTarifas.DesignTimeLayout = GridSegurosTarifas_DesignTimeLayout
        Me.GridSegurosTarifas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSegurosTarifas.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridSegurosTarifas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridSegurosTarifas.EntityName = "ObraTarifaAlquiler"
        Me.GridSegurosTarifas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridSegurosTarifas.Location = New System.Drawing.Point(0, 26)
        Me.GridSegurosTarifas.Name = "GridSegurosTarifas"
        Me.GridSegurosTarifas.PrimaryDataFields = "IDObra"
        Me.GridSegurosTarifas.SecondaryDataFields = "IDObra"
        Me.GridSegurosTarifas.Size = New System.Drawing.Size(355, 85)
        Me.GridSegurosTarifas.TabIndex = 34
        Me.GridSegurosTarifas.ViewName = "VFrmAlquilerCondicionesTarifas"
        '
        'pnlLabelTarifas
        '
        Me.pnlLabelTarifas.Controls.Add(Me.lblTarifas)
        Me.pnlLabelTarifas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabelTarifas.Location = New System.Drawing.Point(0, 0)
        Me.pnlLabelTarifas.Name = "pnlLabelTarifas"
        Me.pnlLabelTarifas.Size = New System.Drawing.Size(355, 26)
        Me.pnlLabelTarifas.TabIndex = 0
        '
        'lblTarifas
        '
        Me.lblTarifas.Location = New System.Drawing.Point(8, 7)
        Me.lblTarifas.Name = "lblTarifas"
        Me.lblTarifas.Size = New System.Drawing.Size(45, 13)
        Me.lblTarifas.TabIndex = 222
        Me.lblTarifas.Text = "Tarifas"
        '
        'Splitter4
        '
        Me.Splitter4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter4.Location = New System.Drawing.Point(0, 111)
        Me.Splitter4.Name = "Splitter4"
        Me.Splitter4.Size = New System.Drawing.Size(355, 5)
        Me.Splitter4.TabIndex = 7
        Me.Splitter4.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GridSegurosDtos)
        Me.Panel5.Controls.Add(Me.pnlLabelDtos)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 116)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(355, 109)
        Me.Panel5.TabIndex = 5
        '
        'GridSegurosDtos
        '
        Me.GridSegurosDtos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipo", "TipoArticulo", "IDTipo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescTipo", "DescTipo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFamilia", "Familia", "IDFamilia", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTipo", "IDTipo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDFamilia", "IDFamilia"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescFamilia", "DescFamilia")}))})
        GridSegurosDtos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridSegurosDtos_DesignTimeLayout_Reference_0.Instance"), Object)
        GridSegurosDtos_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridSegurosDtos_DesignTimeLayout_Reference_1.Instance"), Object)
        GridSegurosDtos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridSegurosDtos_DesignTimeLayout_Reference_0, GridSegurosDtos_DesignTimeLayout_Reference_1})
        GridSegurosDtos_DesignTimeLayout.LayoutString = resources.GetString("GridSegurosDtos_DesignTimeLayout.LayoutString")
        Me.GridSegurosDtos.DesignTimeLayout = GridSegurosDtos_DesignTimeLayout
        Me.GridSegurosDtos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSegurosDtos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridSegurosDtos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridSegurosDtos.EntityName = "ObraTarifaAlquiler"
        Me.GridSegurosDtos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridSegurosDtos.Location = New System.Drawing.Point(0, 23)
        Me.GridSegurosDtos.Name = "GridSegurosDtos"
        Me.GridSegurosDtos.PrimaryDataFields = "IDObra"
        Me.GridSegurosDtos.SecondaryDataFields = "IDObra"
        Me.GridSegurosDtos.Size = New System.Drawing.Size(355, 86)
        Me.GridSegurosDtos.TabIndex = 35
        Me.GridSegurosDtos.ViewName = "vFrmAlquilerCondicionesDescuentos"
        '
        'pnlLabelDtos
        '
        Me.pnlLabelDtos.Controls.Add(Me.lblDtos)
        Me.pnlLabelDtos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabelDtos.Location = New System.Drawing.Point(0, 0)
        Me.pnlLabelDtos.Name = "pnlLabelDtos"
        Me.pnlLabelDtos.Size = New System.Drawing.Size(355, 23)
        Me.pnlLabelDtos.TabIndex = 1
        '
        'lblDtos
        '
        Me.lblDtos.Location = New System.Drawing.Point(8, 3)
        Me.lblDtos.Name = "lblDtos"
        Me.lblDtos.Size = New System.Drawing.Size(73, 13)
        Me.lblDtos.TabIndex = 222
        Me.lblDtos.Text = "Descuentos"
        '
        'TabPageOrdenes
        '
        Me.TabPageOrdenes.Controls.Add(Me.TabTrabajos)
        Me.TabPageOrdenes.Controls.Add(Me.Splitter5)
        Me.TabPageOrdenes.Controls.Add(Me.pnlTrabajos)
        Me.TabPageOrdenes.Key = "Ordenes"
        Me.TabPageOrdenes.Location = New System.Drawing.Point(1, 21)
        Me.TabPageOrdenes.Name = "TabPageOrdenes"
        Me.TabPageOrdenes.Size = New System.Drawing.Size(782, 485)
        Me.TabPageOrdenes.TabStop = True
        Me.TabPageOrdenes.Text = "Ordenes"
        Me.TabPageOrdenes.Visible = False
        '
        'TabTrabajos
        '
        Me.TabTrabajos.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabTrabajos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabTrabajos.Location = New System.Drawing.Point(262, 0)
        Me.TabTrabajos.Name = "TabTrabajos"
        Me.TabTrabajos.Size = New System.Drawing.Size(520, 485)
        Me.TabTrabajos.TabIndex = 18
        Me.TabTrabajos.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageDetalleOrdenes, Me.TabPageArticulos, Me.TabPageIncidencias, Me.TabPageHitos, Me.TabPagePersonal})
        Me.TabTrabajos.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right
        Me.TabTrabajos.UseThemes = True
        '
        'TabPageDetalleOrdenes
        '
        Me.TabPageDetalleOrdenes.Controls.Add(Me.pnlFichaTrabajo)
        Me.TabPageDetalleOrdenes.Controls.Add(Me.pnlGridTrabajo)
        Me.TabPageDetalleOrdenes.Controls.Add(Me.pnlCliente)
        Me.TabPageDetalleOrdenes.Key = "Trabajos"
        Me.TabPageDetalleOrdenes.Location = New System.Drawing.Point(1, 1)
        Me.TabPageDetalleOrdenes.Name = "TabPageDetalleOrdenes"
        Me.TabPageDetalleOrdenes.Size = New System.Drawing.Size(497, 483)
        Me.TabPageDetalleOrdenes.TabStop = True
        Me.TabPageDetalleOrdenes.Text = "Ordenes"
        '
        'pnlFichaTrabajo
        '
        Me.pnlFichaTrabajo.Controls.Add(Me.pnlFichaTrabajoFill)
        Me.pnlFichaTrabajo.Controls.Add(Me.pnlFichaTrabajoTop)
        Me.pnlFichaTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFichaTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.pnlFichaTrabajo.Name = "pnlFichaTrabajo"
        Me.pnlFichaTrabajo.Size = New System.Drawing.Size(497, 454)
        Me.pnlFichaTrabajo.TabIndex = 183
        '
        'pnlFichaTrabajoFill
        '
        Me.pnlFichaTrabajoFill.Controls.Add(Me.txtTextoExternoTrabajo)
        Me.pnlFichaTrabajoFill.Controls.Add(Me.lblTextoExternoTrabajo)
        Me.pnlFichaTrabajoFill.Controls.Add(Me.txtTextoTrabajo)
        Me.pnlFichaTrabajoFill.Controls.Add(Me.lblTextoTrabajo)
        Me.pnlFichaTrabajoFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFichaTrabajoFill.Location = New System.Drawing.Point(0, 423)
        Me.pnlFichaTrabajoFill.Name = "pnlFichaTrabajoFill"
        Me.pnlFichaTrabajoFill.Size = New System.Drawing.Size(497, 31)
        Me.pnlFichaTrabajoFill.TabIndex = 182
        '
        'txtTextoExternoTrabajo
        '
        Me.txtTextoExternoTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTextoExternoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtTextoExternoTrabajo.Location = New System.Drawing.Point(329, 4)
        Me.txtTextoExternoTrabajo.Multiline = True
        Me.txtTextoExternoTrabajo.Name = "txtTextoExternoTrabajo"
        Me.txtTextoExternoTrabajo.Size = New System.Drawing.Size(162, 22)
        Me.txtTextoExternoTrabajo.TabIndex = 77
        '
        'lblTextoExternoTrabajo
        '
        Me.lblTextoExternoTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTextoExternoTrabajo.AutoSize = False
        Me.lblTextoExternoTrabajo.Location = New System.Drawing.Point(253, 2)
        Me.lblTextoExternoTrabajo.Name = "lblTextoExternoTrabajo"
        Me.lblTextoExternoTrabajo.Size = New System.Drawing.Size(74, 28)
        Me.lblTextoExternoTrabajo.TabIndex = 76
        Me.lblTextoExternoTrabajo.Text = "Comentario externo"
        '
        'txtTextoTrabajo
        '
        Me.txtTextoTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTextoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtTextoTrabajo.Location = New System.Drawing.Point(90, 4)
        Me.txtTextoTrabajo.Multiline = True
        Me.txtTextoTrabajo.Name = "txtTextoTrabajo"
        Me.txtTextoTrabajo.Size = New System.Drawing.Size(162, 22)
        Me.txtTextoTrabajo.TabIndex = 75
        '
        'lblTextoTrabajo
        '
        Me.lblTextoTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTextoTrabajo.AutoSize = False
        Me.lblTextoTrabajo.Location = New System.Drawing.Point(2, 2)
        Me.lblTextoTrabajo.Name = "lblTextoTrabajo"
        Me.lblTextoTrabajo.Size = New System.Drawing.Size(80, 28)
        Me.lblTextoTrabajo.TabIndex = 0
        Me.lblTextoTrabajo.Text = "Comentario interno"
        '
        'pnlFichaTrabajoTop
        '
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtTextoContacto)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtCodTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.AdvOperarioTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.AdvPersonaContacto)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cmbPrint)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.chkTraspasada)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.FraFianzas)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.FraDatosCliente)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.FraCRM)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblAtendidoPor)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cmbVerTextoContacto)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblTextoContacto)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblPersonaContacto)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.FraFacturacion)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cmbVerPedidoCliente)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblPedidoCliente)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtNivelTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblNivelTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblCentroGestionTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cbxCentroGestionTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.FraFechasTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblEstadoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cbxEstadoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblIDArticulo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblDescArticulo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.AdvIDArticulo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblUDMedida)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblQPrev)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblCodTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cbxIDUDMedida)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtQPrev)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtPedidoCliente)
        Me.pnlFichaTrabajoTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFichaTrabajoTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlFichaTrabajoTop.Name = "pnlFichaTrabajoTop"
        Me.pnlFichaTrabajoTop.Size = New System.Drawing.Size(497, 423)
        Me.pnlFichaTrabajoTop.TabIndex = 178
        '
        'txtTextoContacto
        '
        Me.txtTextoContacto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTextoContacto.Location = New System.Drawing.Point(92, 242)
        Me.txtTextoContacto.Name = "txtTextoContacto"
        Me.txtTextoContacto.Size = New System.Drawing.Size(185, 21)
        Me.txtTextoContacto.TabIndex = 66
        '
        'txtCodTrabajo
        '
        Me.txtCodTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodTrabajo.Enabled = False
        Me.txtCodTrabajo.Location = New System.Drawing.Point(92, 4)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(124, 21)
        Me.txtCodTrabajo.TabIndex = 47
        '
        'AdvOperarioTrabajo
        '
        Me.AdvOperarioTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvOperarioTrabajo.EntityName = "Operario"
        Me.AdvOperarioTrabajo.Location = New System.Drawing.Point(409, 240)
        Me.AdvOperarioTrabajo.Name = "AdvOperarioTrabajo"
        Me.AdvOperarioTrabajo.PrimaryDataFields = "IDOperario"
        Me.AdvOperarioTrabajo.SecondaryDataFields = "IDOperario"
        Me.AdvOperarioTrabajo.Size = New System.Drawing.Size(81, 23)
        Me.AdvOperarioTrabajo.TabIndex = 68
        '
        'AdvPersonaContacto
        '
        Me.AdvPersonaContacto.DisabledBackColor = System.Drawing.Color.White
        Me.AdvPersonaContacto.DisplayField = "IDPersona"
        Me.AdvPersonaContacto.EntityName = "ObraPersonaContacto2"
        Me.AdvPersonaContacto.Location = New System.Drawing.Point(92, 216)
        Me.AdvPersonaContacto.Name = "AdvPersonaContacto"
        Me.AdvPersonaContacto.PrimaryDataFields = "IDPersona"
        Me.AdvPersonaContacto.SecondaryDataFields = "IDPersona"
        Me.AdvPersonaContacto.Size = New System.Drawing.Size(125, 23)
        Me.AdvPersonaContacto.TabIndex = 64
        '
        'cmbPrint
        '
        Me.cmbPrint.ImageIndex = 8
        Me.cmbPrint.ImageList = Me.ImageList1
        Me.cmbPrint.Location = New System.Drawing.Point(220, 73)
        Me.cmbPrint.Name = "cmbPrint"
        Me.cmbPrint.Size = New System.Drawing.Size(23, 23)
        Me.cmbPrint.TabIndex = 243
        Me.cmbPrint.Visible = False
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
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "clock_run.ico")
        Me.ImageList1.Images.SetKeyName(12, "xArticulos.ico")
        '
        'chkTraspasada
        '
        Me.chkTraspasada.Enabled = False
        Me.chkTraspasada.Location = New System.Drawing.Point(231, 215)
        Me.chkTraspasada.Name = "chkTraspasada"
        Me.chkTraspasada.Size = New System.Drawing.Size(95, 20)
        Me.chkTraspasada.TabIndex = 64
        Me.chkTraspasada.TabStop = False
        Me.chkTraspasada.Text = "Traspasada"
        '
        'FraFianzas
        '
        Me.FraFianzas.Controls.Add(Me.lblFianza)
        Me.FraFianzas.Controls.Add(Me.txtFianza)
        Me.FraFianzas.Controls.Add(Me.lblFechaContabilizacion)
        Me.FraFianzas.Controls.Add(Me.cbxFechaContabilizacion)
        Me.FraFianzas.Controls.Add(Me.chkFianzaCompensada)
        Me.FraFianzas.Controls.Add(Me.chkFianzaContabilizada)
        Me.FraFianzas.Location = New System.Drawing.Point(286, 263)
        Me.FraFianzas.Name = "FraFianzas"
        Me.FraFianzas.Size = New System.Drawing.Size(205, 90)
        Me.FraFianzas.TabIndex = 242
        Me.FraFianzas.TabStop = False
        Me.FraFianzas.Text = "Fianzas"
        '
        'lblFianza
        '
        Me.lblFianza.Location = New System.Drawing.Point(6, 67)
        Me.lblFianza.Name = "lblFianza"
        Me.lblFianza.Size = New System.Drawing.Size(53, 13)
        Me.lblFianza.TabIndex = 244
        Me.lblFianza.Text = "Importe"
        '
        'txtFianza
        '
        Me.txtFianza.DisabledBackColor = System.Drawing.Color.White
        Me.txtFianza.Enabled = False
        Me.txtFianza.Location = New System.Drawing.Point(96, 63)
        Me.txtFianza.Name = "txtFianza"
        Me.txtFianza.Size = New System.Drawing.Size(97, 21)
        Me.txtFianza.TabIndex = 73
        Me.txtFianza.TabStop = False
        '
        'lblFechaContabilizacion
        '
        Me.lblFechaContabilizacion.Location = New System.Drawing.Point(6, 43)
        Me.lblFechaContabilizacion.Name = "lblFechaContabilizacion"
        Me.lblFechaContabilizacion.Size = New System.Drawing.Size(89, 13)
        Me.lblFechaContabilizacion.TabIndex = 242
        Me.lblFechaContabilizacion.Text = "Fecha Contab."
        '
        'cbxFechaContabilizacion
        '
        Me.cbxFechaContabilizacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaContabilizacion.Enabled = False
        Me.cbxFechaContabilizacion.Location = New System.Drawing.Point(96, 39)
        Me.cbxFechaContabilizacion.Name = "cbxFechaContabilizacion"
        Me.cbxFechaContabilizacion.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaContabilizacion.TabIndex = 72
        Me.cbxFechaContabilizacion.TabStop = False
        '
        'chkFianzaCompensada
        '
        Me.chkFianzaCompensada.Enabled = False
        Me.chkFianzaCompensada.Location = New System.Drawing.Point(106, 15)
        Me.chkFianzaCompensada.Name = "chkFianzaCompensada"
        Me.chkFianzaCompensada.Size = New System.Drawing.Size(95, 20)
        Me.chkFianzaCompensada.TabIndex = 71
        Me.chkFianzaCompensada.TabStop = False
        Me.chkFianzaCompensada.Text = "Compensada"
        '
        'chkFianzaContabilizada
        '
        Me.chkFianzaContabilizada.Enabled = False
        Me.chkFianzaContabilizada.Location = New System.Drawing.Point(4, 15)
        Me.chkFianzaContabilizada.Name = "chkFianzaContabilizada"
        Me.chkFianzaContabilizada.Size = New System.Drawing.Size(95, 20)
        Me.chkFianzaContabilizada.TabIndex = 70
        Me.chkFianzaContabilizada.TabStop = False
        Me.chkFianzaContabilizada.Text = "Contabilizada"
        '
        'FraDatosCliente
        '
        Me.FraDatosCliente.Controls.Add(Me.cmbSearchIDDireccion)
        Me.FraDatosCliente.Controls.Add(Me.txtDtoClienteTrabajo)
        Me.FraDatosCliente.Controls.Add(Me.lblPoblacionClienteTrabajo)
        Me.FraDatosCliente.Controls.Add(Me.txtPoblacionClienteTrabajo)
        Me.FraDatosCliente.Controls.Add(Me.lblCPClienteTrabajo)
        Me.FraDatosCliente.Controls.Add(Me.txtCPClienteTrabajo)
        Me.FraDatosCliente.Controls.Add(Me.lblProvinciaTrabajoCliente)
        Me.FraDatosCliente.Controls.Add(Me.txtProvinciaTrabajoCliente)
        Me.FraDatosCliente.Controls.Add(Me.lblDireccionTrabajo)
        Me.FraDatosCliente.Controls.Add(Me.txtDireccionTrabajo)
        Me.FraDatosCliente.Controls.Add(Me.lblDtoClienteTrabajo)
        Me.FraDatosCliente.Location = New System.Drawing.Point(5, 354)
        Me.FraDatosCliente.Name = "FraDatosCliente"
        Me.FraDatosCliente.Size = New System.Drawing.Size(486, 67)
        Me.FraDatosCliente.TabIndex = 241
        Me.FraDatosCliente.TabStop = False
        Me.FraDatosCliente.Text = "Datos Cliente"
        '
        'cmbSearchIDDireccion
        '
        Me.cmbSearchIDDireccion.ImageIndex = 6
        Me.cmbSearchIDDireccion.ImageList = Me.ImageList1
        Me.cmbSearchIDDireccion.Location = New System.Drawing.Point(7, 17)
        Me.cmbSearchIDDireccion.Name = "cmbSearchIDDireccion"
        Me.cmbSearchIDDireccion.Size = New System.Drawing.Size(21, 21)
        Me.cmbSearchIDDireccion.TabIndex = 74
        '
        'txtDtoClienteTrabajo
        '
        Me.txtDtoClienteTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDtoClienteTrabajo.Enabled = False
        Me.txtDtoClienteTrabajo.Location = New System.Drawing.Point(418, 17)
        Me.txtDtoClienteTrabajo.Name = "txtDtoClienteTrabajo"
        Me.txtDtoClienteTrabajo.Size = New System.Drawing.Size(62, 21)
        Me.txtDtoClienteTrabajo.TabIndex = 107
        Me.txtDtoClienteTrabajo.TabStop = False
        '
        'lblPoblacionClienteTrabajo
        '
        Me.lblPoblacionClienteTrabajo.Location = New System.Drawing.Point(79, 45)
        Me.lblPoblacionClienteTrabajo.Name = "lblPoblacionClienteTrabajo"
        Me.lblPoblacionClienteTrabajo.Size = New System.Drawing.Size(61, 13)
        Me.lblPoblacionClienteTrabajo.TabIndex = 98
        Me.lblPoblacionClienteTrabajo.Text = "Población"
        '
        'txtPoblacionClienteTrabajo
        '
        Me.txtPoblacionClienteTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtPoblacionClienteTrabajo.Enabled = False
        Me.txtPoblacionClienteTrabajo.Location = New System.Drawing.Point(140, 41)
        Me.txtPoblacionClienteTrabajo.Name = "txtPoblacionClienteTrabajo"
        Me.txtPoblacionClienteTrabajo.Size = New System.Drawing.Size(162, 21)
        Me.txtPoblacionClienteTrabajo.TabIndex = 102
        Me.txtPoblacionClienteTrabajo.TabStop = False
        '
        'lblCPClienteTrabajo
        '
        Me.lblCPClienteTrabajo.Location = New System.Drawing.Point(7, 45)
        Me.lblCPClienteTrabajo.Name = "lblCPClienteTrabajo"
        Me.lblCPClienteTrabajo.Size = New System.Drawing.Size(29, 13)
        Me.lblCPClienteTrabajo.TabIndex = 103
        Me.lblCPClienteTrabajo.Text = "C.P."
        '
        'txtCPClienteTrabajo
        '
        Me.txtCPClienteTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCPClienteTrabajo.Enabled = False
        Me.txtCPClienteTrabajo.Location = New System.Drawing.Point(38, 41)
        Me.txtCPClienteTrabajo.Name = "txtCPClienteTrabajo"
        Me.txtCPClienteTrabajo.Size = New System.Drawing.Size(41, 21)
        Me.txtCPClienteTrabajo.TabIndex = 101
        Me.txtCPClienteTrabajo.TabStop = False
        '
        'lblProvinciaTrabajoCliente
        '
        Me.lblProvinciaTrabajoCliente.Location = New System.Drawing.Point(304, 45)
        Me.lblProvinciaTrabajoCliente.Name = "lblProvinciaTrabajoCliente"
        Me.lblProvinciaTrabajoCliente.Size = New System.Drawing.Size(59, 13)
        Me.lblProvinciaTrabajoCliente.TabIndex = 104
        Me.lblProvinciaTrabajoCliente.Text = "Provincia"
        '
        'txtProvinciaTrabajoCliente
        '
        Me.txtProvinciaTrabajoCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtProvinciaTrabajoCliente.Enabled = False
        Me.txtProvinciaTrabajoCliente.Location = New System.Drawing.Point(370, 41)
        Me.txtProvinciaTrabajoCliente.Name = "txtProvinciaTrabajoCliente"
        Me.txtProvinciaTrabajoCliente.Size = New System.Drawing.Size(110, 21)
        Me.txtProvinciaTrabajoCliente.TabIndex = 100
        Me.txtProvinciaTrabajoCliente.TabStop = False
        '
        'lblDireccionTrabajo
        '
        Me.lblDireccionTrabajo.Location = New System.Drawing.Point(31, 21)
        Me.lblDireccionTrabajo.Name = "lblDireccionTrabajo"
        Me.lblDireccionTrabajo.Size = New System.Drawing.Size(60, 13)
        Me.lblDireccionTrabajo.TabIndex = 105
        Me.lblDireccionTrabajo.Text = "Dirección"
        '
        'txtDireccionTrabajo
        '
        Me.txtDireccionTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDireccionTrabajo.Enabled = False
        Me.txtDireccionTrabajo.Location = New System.Drawing.Point(92, 17)
        Me.txtDireccionTrabajo.Name = "txtDireccionTrabajo"
        Me.txtDireccionTrabajo.Size = New System.Drawing.Size(293, 21)
        Me.txtDireccionTrabajo.TabIndex = 99
        Me.txtDireccionTrabajo.TabStop = False
        '
        'lblDtoClienteTrabajo
        '
        Me.lblDtoClienteTrabajo.Location = New System.Drawing.Point(388, 21)
        Me.lblDtoClienteTrabajo.Name = "lblDtoClienteTrabajo"
        Me.lblDtoClienteTrabajo.Size = New System.Drawing.Size(31, 13)
        Me.lblDtoClienteTrabajo.TabIndex = 106
        Me.lblDtoClienteTrabajo.Text = "Dto."
        '
        'FraCRM
        '
        Me.FraCRM.Controls.Add(Me.txtTipoActividad)
        Me.FraCRM.Controls.Add(Me.txtHoraActividad)
        Me.FraCRM.Controls.Add(Me.lblHoraActividad)
        Me.FraCRM.Controls.Add(Me.txtDescActividad)
        Me.FraCRM.Controls.Add(Me.txtTextoActividad)
        Me.FraCRM.Controls.Add(Me.lblFechaActividad)
        Me.FraCRM.Controls.Add(Me.cbxFechaActividad)
        Me.FraCRM.Controls.Add(Me.txtDescSituacion)
        Me.FraCRM.Controls.Add(Me.lblTipoActividad)
        Me.FraCRM.Controls.Add(Me.cmbSearchActividad)
        Me.FraCRM.Location = New System.Drawing.Point(5, 263)
        Me.FraCRM.Name = "FraCRM"
        Me.FraCRM.Size = New System.Drawing.Size(278, 90)
        Me.FraCRM.TabIndex = 240
        Me.FraCRM.TabStop = False
        Me.FraCRM.Text = "CRM"
        '
        'txtTipoActividad
        '
        Me.txtTipoActividad.DisabledBackColor = System.Drawing.Color.White
        Me.txtTipoActividad.Enabled = False
        Me.txtTipoActividad.Location = New System.Drawing.Point(89, 15)
        Me.txtTipoActividad.Name = "txtTipoActividad"
        Me.txtTipoActividad.Size = New System.Drawing.Size(97, 21)
        Me.txtTipoActividad.TabIndex = 240
        Me.txtTipoActividad.TabStop = False
        '
        'txtHoraActividad
        '
        Me.txtHoraActividad.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Time
        Me.txtHoraActividad.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraActividad.Enabled = False
        Me.txtHoraActividad.Location = New System.Drawing.Point(205, 39)
        Me.txtHoraActividad.Name = "txtHoraActividad"
        Me.txtHoraActividad.ShowDropDown = False
        Me.txtHoraActividad.Size = New System.Drawing.Size(67, 21)
        Me.txtHoraActividad.TabIndex = 250
        Me.txtHoraActividad.TabStop = False
        '
        'lblHoraActividad
        '
        Me.lblHoraActividad.Location = New System.Drawing.Point(168, 41)
        Me.lblHoraActividad.Name = "lblHoraActividad"
        Me.lblHoraActividad.Size = New System.Drawing.Size(34, 13)
        Me.lblHoraActividad.TabIndex = 249
        Me.lblHoraActividad.Text = "Hora"
        '
        'txtDescActividad
        '
        Me.txtDescActividad.Location = New System.Drawing.Point(31, 67)
        Me.txtDescActividad.Name = "txtDescActividad"
        Me.txtDescActividad.Size = New System.Drawing.Size(38, 13)
        Me.txtDescActividad.TabIndex = 248
        Me.txtDescActividad.Text = "Texto"
        '
        'txtTextoActividad
        '
        Me.txtTextoActividad.DisabledBackColor = System.Drawing.Color.White
        Me.txtTextoActividad.Enabled = False
        Me.txtTextoActividad.Location = New System.Drawing.Point(89, 63)
        Me.txtTextoActividad.Name = "txtTextoActividad"
        Me.txtTextoActividad.Size = New System.Drawing.Size(183, 21)
        Me.txtTextoActividad.TabIndex = 247
        Me.txtTextoActividad.TabStop = False
        '
        'lblFechaActividad
        '
        Me.lblFechaActividad.Location = New System.Drawing.Point(31, 39)
        Me.lblFechaActividad.Name = "lblFechaActividad"
        Me.lblFechaActividad.Size = New System.Drawing.Size(40, 13)
        Me.lblFechaActividad.TabIndex = 246
        Me.lblFechaActividad.Text = "Fecha"
        '
        'cbxFechaActividad
        '
        Me.cbxFechaActividad.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaActividad.Enabled = False
        Me.cbxFechaActividad.Location = New System.Drawing.Point(89, 39)
        Me.cbxFechaActividad.Name = "cbxFechaActividad"
        Me.cbxFechaActividad.Size = New System.Drawing.Size(75, 21)
        Me.cbxFechaActividad.TabIndex = 245
        Me.cbxFechaActividad.TabStop = False
        '
        'txtDescSituacion
        '
        Me.TryDataBinding(txtDescSituacion, New System.Windows.Forms.Binding("Text", Me.advIDClasificacionObra, "Apellido", True))
        Me.txtDescSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescSituacion.Enabled = False
        Me.txtDescSituacion.Location = New System.Drawing.Point(188, 15)
        Me.txtDescSituacion.Name = "txtDescSituacion"
        Me.txtDescSituacion.Size = New System.Drawing.Size(84, 21)
        Me.txtDescSituacion.TabIndex = 242
        Me.txtDescSituacion.TabStop = False
        '
        'lblTipoActividad
        '
        Me.lblTipoActividad.Location = New System.Drawing.Point(31, 20)
        Me.lblTipoActividad.Name = "lblTipoActividad"
        Me.lblTipoActividad.Size = New System.Drawing.Size(59, 13)
        Me.lblTipoActividad.TabIndex = 241
        Me.lblTipoActividad.Text = "Actividad"
        '
        'cmbSearchActividad
        '
        Me.cmbSearchActividad.ImageIndex = 6
        Me.cmbSearchActividad.ImageList = Me.ImageList1
        Me.cmbSearchActividad.Location = New System.Drawing.Point(7, 15)
        Me.cmbSearchActividad.Name = "cmbSearchActividad"
        Me.cmbSearchActividad.Size = New System.Drawing.Size(21, 21)
        Me.cmbSearchActividad.TabIndex = 69
        '
        'lblAtendidoPor
        '
        Me.lblAtendidoPor.Location = New System.Drawing.Point(329, 245)
        Me.lblAtendidoPor.Name = "lblAtendidoPor"
        Me.lblAtendidoPor.Size = New System.Drawing.Size(80, 13)
        Me.lblAtendidoPor.TabIndex = 238
        Me.lblAtendidoPor.Text = "Atendido Por"
        '
        'cmbVerTextoContacto
        '
        Me.cmbVerTextoContacto.ImageIndex = 5
        Me.cmbVerTextoContacto.ImageList = Me.ImageList1
        Me.cmbVerTextoContacto.Location = New System.Drawing.Point(303, 242)
        Me.cmbVerTextoContacto.Name = "cmbVerTextoContacto"
        Me.cmbVerTextoContacto.Size = New System.Drawing.Size(21, 21)
        Me.cmbVerTextoContacto.TabIndex = 67
        '
        'lblTextoContacto
        '
        Me.lblTextoContacto.Location = New System.Drawing.Point(2, 246)
        Me.lblTextoContacto.Name = "lblTextoContacto"
        Me.lblTextoContacto.Size = New System.Drawing.Size(93, 13)
        Me.lblTextoContacto.TabIndex = 236
        Me.lblTextoContacto.Text = "Texto Contacto"
        '
        'lblPersonaContacto
        '
        Me.lblPersonaContacto.Location = New System.Drawing.Point(2, 221)
        Me.lblPersonaContacto.Name = "lblPersonaContacto"
        Me.lblPersonaContacto.Size = New System.Drawing.Size(58, 13)
        Me.lblPersonaContacto.TabIndex = 234
        Me.lblPersonaContacto.Text = "Contacto"
        '
        'FraFacturacion
        '
        Me.FraFacturacion.Controls.Add(Me.chkTrabajoFacturable)
        Me.FraFacturacion.Controls.Add(Me.lblTipoFacturacionAlquiler)
        Me.FraFacturacion.Controls.Add(Me.cbxTipoFactAlquiler)
        Me.FraFacturacion.Controls.Add(Me.lblTipoFacturacion)
        Me.FraFacturacion.Controls.Add(Me.cbxTipoFacturacion)
        Me.FraFacturacion.Controls.Add(Me.lblImporte)
        Me.FraFacturacion.Controls.Add(Me.txtImporte)
        Me.FraFacturacion.Location = New System.Drawing.Point(5, 147)
        Me.FraFacturacion.Name = "FraFacturacion"
        Me.FraFacturacion.Size = New System.Drawing.Size(486, 66)
        Me.FraFacturacion.TabIndex = 232
        Me.FraFacturacion.TabStop = False
        Me.FraFacturacion.Text = "Facturación"
        '
        'chkTrabajoFacturable
        '
        Me.chkTrabajoFacturable.Location = New System.Drawing.Point(307, 15)
        Me.chkTrabajoFacturable.Name = "chkTrabajoFacturable"
        Me.chkTrabajoFacturable.Size = New System.Drawing.Size(95, 20)
        Me.chkTrabajoFacturable.TabIndex = 60
        Me.chkTrabajoFacturable.Text = "Facturable"
        '
        'lblTipoFacturacionAlquiler
        '
        Me.lblTipoFacturacionAlquiler.Location = New System.Drawing.Point(7, 44)
        Me.lblTipoFacturacionAlquiler.Name = "lblTipoFacturacionAlquiler"
        Me.lblTipoFacturacionAlquiler.Size = New System.Drawing.Size(78, 13)
        Me.lblTipoFacturacionAlquiler.TabIndex = 237
        Me.lblTipoFacturacionAlquiler.Text = "Tipo Alquiler"
        '
        'cbxTipoFactAlquiler
        '
        Me.cbxTipoFactAlquiler.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxTipoFactAlquiler_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoFactAlquiler_DesignTimeLayout.LayoutString")
        Me.cbxTipoFactAlquiler.DesignTimeLayout = cbxTipoFactAlquiler_DesignTimeLayout
        Me.cbxTipoFactAlquiler.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoFactAlquiler.DisplayMember = "Value"
        Me.cbxTipoFactAlquiler.Location = New System.Drawing.Point(87, 40)
        Me.cbxTipoFactAlquiler.Name = "cbxTipoFactAlquiler"
        Me.cbxTipoFactAlquiler.PrimaryDataFields = "TipoFactAlquiler"
        Me.cbxTipoFactAlquiler.SecondaryDataFields = "Value"
        Me.cbxTipoFactAlquiler.SelectedIndex = -1
        Me.cbxTipoFactAlquiler.SelectedItem = Nothing
        Me.cbxTipoFactAlquiler.Size = New System.Drawing.Size(158, 21)
        Me.cbxTipoFactAlquiler.TabIndex = 61
        '
        'lblTipoFacturacion
        '
        Me.lblTipoFacturacion.Location = New System.Drawing.Point(8, 19)
        Me.lblTipoFacturacion.Name = "lblTipoFacturacion"
        Me.lblTipoFacturacion.Size = New System.Drawing.Size(31, 13)
        Me.lblTipoFacturacion.TabIndex = 235
        Me.lblTipoFacturacion.Text = "Tipo"
        '
        'cbxTipoFacturacion
        '
        Me.cbxTipoFacturacion.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxTipoFacturacion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoFacturacion_DesignTimeLayout.LayoutString")
        Me.cbxTipoFacturacion.DesignTimeLayout = cbxTipoFacturacion_DesignTimeLayout
        Me.cbxTipoFacturacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoFacturacion.DisplayMember = "Value"
        Me.cbxTipoFacturacion.Location = New System.Drawing.Point(87, 16)
        Me.cbxTipoFacturacion.Name = "cbxTipoFacturacion"
        Me.cbxTipoFacturacion.PrimaryDataFields = "TipoFacturacion"
        Me.cbxTipoFacturacion.SecondaryDataFields = "Value"
        Me.cbxTipoFacturacion.SelectedIndex = -1
        Me.cbxTipoFacturacion.SelectedItem = Nothing
        Me.cbxTipoFacturacion.Size = New System.Drawing.Size(158, 21)
        Me.cbxTipoFacturacion.TabIndex = 59
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(305, 40)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(53, 13)
        Me.lblImporte.TabIndex = 234
        Me.lblImporte.Text = "Importe"
        '
        'txtImporte
        '
        Me.txtImporte.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporte.Location = New System.Drawing.Point(365, 40)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(114, 21)
        Me.txtImporte.TabIndex = 62
        '
        'cmbVerPedidoCliente
        '
        Me.cmbVerPedidoCliente.ImageIndex = 5
        Me.cmbVerPedidoCliente.ImageList = Me.ImageList1
        Me.cmbVerPedidoCliente.Location = New System.Drawing.Point(282, 28)
        Me.cmbVerPedidoCliente.Name = "cmbVerPedidoCliente"
        Me.cmbVerPedidoCliente.Size = New System.Drawing.Size(21, 21)
        Me.cmbVerPedidoCliente.TabIndex = 50
        '
        'lblPedidoCliente
        '
        Me.lblPedidoCliente.Location = New System.Drawing.Point(2, 29)
        Me.lblPedidoCliente.Name = "lblPedidoCliente"
        Me.lblPedidoCliente.Size = New System.Drawing.Size(89, 13)
        Me.lblPedidoCliente.TabIndex = 228
        Me.lblPedidoCliente.Text = "Pedido Cliente"
        '
        'txtNivelTrabajo
        '
        Me.txtNivelTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtNivelTrabajo.Enabled = False
        Me.txtNivelTrabajo.Location = New System.Drawing.Point(258, 4)
        Me.txtNivelTrabajo.Name = "txtNivelTrabajo"
        Me.txtNivelTrabajo.Size = New System.Drawing.Size(45, 21)
        Me.txtNivelTrabajo.TabIndex = 48
        Me.txtNivelTrabajo.TabStop = False
        Me.txtNivelTrabajo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'lblNivelTrabajo
        '
        Me.lblNivelTrabajo.Location = New System.Drawing.Point(219, 8)
        Me.lblNivelTrabajo.Name = "lblNivelTrabajo"
        Me.lblNivelTrabajo.Size = New System.Drawing.Size(35, 13)
        Me.lblNivelTrabajo.TabIndex = 227
        Me.lblNivelTrabajo.Text = "Nivel"
        '
        'lblCentroGestionTrabajo
        '
        Me.lblCentroGestionTrabajo.Location = New System.Drawing.Point(329, 220)
        Me.lblCentroGestionTrabajo.Name = "lblCentroGestionTrabajo"
        Me.lblCentroGestionTrabajo.Size = New System.Drawing.Size(67, 13)
        Me.lblCentroGestionTrabajo.TabIndex = 226
        Me.lblCentroGestionTrabajo.Text = "C. Gestión"
        '
        'cbxCentroGestionTrabajo
        '
        cbxCentroGestionTrabajo_DesignTimeLayout.LayoutString = resources.GetString("cbxCentroGestionTrabajo_DesignTimeLayout.LayoutString")
        Me.cbxCentroGestionTrabajo.DesignTimeLayout = cbxCentroGestionTrabajo_DesignTimeLayout
        Me.cbxCentroGestionTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxCentroGestionTrabajo.DisplayMember = "IDCentroGestion"
        Me.cbxCentroGestionTrabajo.EntityName = "CentroGestion"
        Me.cbxCentroGestionTrabajo.Location = New System.Drawing.Point(409, 216)
        Me.cbxCentroGestionTrabajo.Name = "cbxCentroGestionTrabajo"
        Me.cbxCentroGestionTrabajo.PrimaryDataFields = "IDCentroGestion"
        Me.cbxCentroGestionTrabajo.SecondaryDataFields = "IDCentroGestion"
        Me.cbxCentroGestionTrabajo.SelectedIndex = -1
        Me.cbxCentroGestionTrabajo.SelectedItem = Nothing
        Me.cbxCentroGestionTrabajo.Size = New System.Drawing.Size(81, 21)
        Me.cbxCentroGestionTrabajo.TabIndex = 65
        Me.cbxCentroGestionTrabajo.ValueMember = "IDCentroGestion"
        Me.cbxCentroGestionTrabajo.ViewName = "tbMaestroCentroGestion"
        '
        'FraFechasTrabajo
        '
        Me.FraFechasTrabajo.Controls.Add(Me.lblFechaPrevEntregaTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.cbxFechaPrevEntregaTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.lblFechaOrden)
        Me.FraFechasTrabajo.Controls.Add(Me.cbxFechaOrdenTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.lblFechaFinTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.cbxFechaFinTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.lblFechaInicioTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.cbxFechaInicioTrabajo)
        Me.FraFechasTrabajo.Location = New System.Drawing.Point(309, 1)
        Me.FraFechasTrabajo.Name = "FraFechasTrabajo"
        Me.FraFechasTrabajo.Size = New System.Drawing.Size(182, 121)
        Me.FraFechasTrabajo.TabIndex = 223
        Me.FraFechasTrabajo.TabStop = False
        Me.FraFechasTrabajo.Text = "Fechas"
        '
        'lblFechaPrevEntregaTrabajo
        '
        Me.lblFechaPrevEntregaTrabajo.Location = New System.Drawing.Point(6, 70)
        Me.lblFechaPrevEntregaTrabajo.Name = "lblFechaPrevEntregaTrabajo"
        Me.lblFechaPrevEntregaTrabajo.Size = New System.Drawing.Size(85, 13)
        Me.lblFechaPrevEntregaTrabajo.TabIndex = 187
        Me.lblFechaPrevEntregaTrabajo.Text = "Prev. Retorno"
        '
        'cbxFechaPrevEntregaTrabajo
        '
        Me.cbxFechaPrevEntregaTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaPrevEntregaTrabajo.Location = New System.Drawing.Point(78, 66)
        Me.cbxFechaPrevEntregaTrabajo.Name = "cbxFechaPrevEntregaTrabajo"
        Me.cbxFechaPrevEntregaTrabajo.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaPrevEntregaTrabajo.TabIndex = 54
        '
        'lblFechaOrden
        '
        Me.lblFechaOrden.Location = New System.Drawing.Point(6, 22)
        Me.lblFechaOrden.Name = "lblFechaOrden"
        Me.lblFechaOrden.Size = New System.Drawing.Size(42, 13)
        Me.lblFechaOrden.TabIndex = 188
        Me.lblFechaOrden.Text = "Orden"
        '
        'cbxFechaOrdenTrabajo
        '
        Me.cbxFechaOrdenTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaOrdenTrabajo.Location = New System.Drawing.Point(78, 18)
        Me.cbxFechaOrdenTrabajo.Name = "cbxFechaOrdenTrabajo"
        Me.cbxFechaOrdenTrabajo.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaOrdenTrabajo.TabIndex = 52
        '
        'lblFechaFinTrabajo
        '
        Me.lblFechaFinTrabajo.Location = New System.Drawing.Point(6, 94)
        Me.lblFechaFinTrabajo.Name = "lblFechaFinTrabajo"
        Me.lblFechaFinTrabajo.Size = New System.Drawing.Size(23, 13)
        Me.lblFechaFinTrabajo.TabIndex = 183
        Me.lblFechaFinTrabajo.Text = "Fin"
        '
        'cbxFechaFinTrabajo
        '
        Me.cbxFechaFinTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFinTrabajo.Location = New System.Drawing.Point(78, 90)
        Me.cbxFechaFinTrabajo.Name = "cbxFechaFinTrabajo"
        Me.cbxFechaFinTrabajo.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaFinTrabajo.TabIndex = 55
        '
        'lblFechaInicioTrabajo
        '
        Me.lblFechaInicioTrabajo.Location = New System.Drawing.Point(6, 46)
        Me.lblFechaInicioTrabajo.Name = "lblFechaInicioTrabajo"
        Me.lblFechaInicioTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblFechaInicioTrabajo.TabIndex = 184
        Me.lblFechaInicioTrabajo.Text = "Entrega"
        '
        'cbxFechaInicioTrabajo
        '
        Me.cbxFechaInicioTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicioTrabajo.Location = New System.Drawing.Point(78, 42)
        Me.cbxFechaInicioTrabajo.Name = "cbxFechaInicioTrabajo"
        Me.cbxFechaInicioTrabajo.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaInicioTrabajo.TabIndex = 53
        '
        'lblEstadoTrabajo
        '
        Me.lblEstadoTrabajo.Location = New System.Drawing.Point(327, 130)
        Me.lblEstadoTrabajo.Name = "lblEstadoTrabajo"
        Me.lblEstadoTrabajo.Size = New System.Drawing.Size(45, 13)
        Me.lblEstadoTrabajo.TabIndex = 222
        Me.lblEstadoTrabajo.Text = "Estado"
        '
        'cbxEstadoTrabajo
        '
        Me.cbxEstadoTrabajo.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxEstadoTrabajo_DesignTimeLayout.LayoutString = resources.GetString("cbxEstadoTrabajo_DesignTimeLayout.LayoutString")
        Me.cbxEstadoTrabajo.DesignTimeLayout = cbxEstadoTrabajo_DesignTimeLayout
        Me.cbxEstadoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstadoTrabajo.DisplayMember = "Value"
        Me.cbxEstadoTrabajo.Location = New System.Drawing.Point(375, 126)
        Me.cbxEstadoTrabajo.Name = "cbxEstadoTrabajo"
        Me.cbxEstadoTrabajo.PrimaryDataFields = "Estado"
        Me.cbxEstadoTrabajo.SecondaryDataFields = "Value"
        Me.cbxEstadoTrabajo.SelectedIndex = -1
        Me.cbxEstadoTrabajo.SelectedItem = Nothing
        Me.cbxEstadoTrabajo.Size = New System.Drawing.Size(115, 21)
        Me.cbxEstadoTrabajo.TabIndex = 58
        '
        'lblIDArticulo
        '
        Me.lblIDArticulo.Location = New System.Drawing.Point(2, 78)
        Me.lblIDArticulo.Name = "lblIDArticulo"
        Me.lblIDArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblIDArticulo.TabIndex = 206
        Me.lblIDArticulo.Text = "Artículo"
        '
        'lblDescArticulo
        '
        Me.lblDescArticulo.Location = New System.Drawing.Point(92, 99)
        Me.lblDescArticulo.Name = "lblDescArticulo"
        Me.lblDescArticulo.Size = New System.Drawing.Size(211, 22)
        Me.lblDescArticulo.TabIndex = 207
        '
        'AdvIDArticulo
        '
        Me.AdvIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDArticulo.EntityName = "Articulo"
        Me.AdvIDArticulo.Location = New System.Drawing.Point(92, 73)
        Me.AdvIDArticulo.Name = "AdvIDArticulo"
        Me.AdvIDArticulo.PrimaryDataFields = "IDArticulo"
        Me.AdvIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvIDArticulo.Size = New System.Drawing.Size(125, 23)
        Me.AdvIDArticulo.TabIndex = 51
        Me.AdvIDArticulo.ViewName = "TbMaestroArticulo"
        '
        'lblUDMedida
        '
        Me.lblUDMedida.Location = New System.Drawing.Point(161, 130)
        Me.lblUDMedida.Name = "lblUDMedida"
        Me.lblUDMedida.Size = New System.Drawing.Size(70, 13)
        Me.lblUDMedida.TabIndex = 195
        Me.lblUDMedida.Text = "Ud. Medida"
        '
        'lblQPrev
        '
        Me.lblQPrev.Location = New System.Drawing.Point(2, 129)
        Me.lblQPrev.Name = "lblQPrev"
        Me.lblQPrev.Size = New System.Drawing.Size(53, 13)
        Me.lblQPrev.TabIndex = 196
        Me.lblQPrev.Text = "C. Prev."
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(2, 8)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(92, 13)
        Me.lblCodTrabajo.TabIndex = 198
        Me.lblCodTrabajo.Text = "Orden Servicio"
        '
        'cbxIDUDMedida
        '
        cbxIDUDMedida_DesignTimeLayout.LayoutString = resources.GetString("cbxIDUDMedida_DesignTimeLayout.LayoutString")
        Me.cbxIDUDMedida.DesignTimeLayout = cbxIDUDMedida_DesignTimeLayout
        Me.cbxIDUDMedida.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDUDMedida.DisplayMember = "IDUdMedida"
        Me.cbxIDUDMedida.EntityName = "UdMedida"
        Me.cbxIDUDMedida.Location = New System.Drawing.Point(232, 126)
        Me.cbxIDUDMedida.Name = "cbxIDUDMedida"
        Me.cbxIDUDMedida.PrimaryDataFields = "IDUdMedida"
        Me.cbxIDUDMedida.SecondaryDataFields = "IDUdMedida"
        Me.cbxIDUDMedida.SelectedIndex = -1
        Me.cbxIDUDMedida.SelectedItem = Nothing
        Me.cbxIDUDMedida.Size = New System.Drawing.Size(87, 21)
        Me.cbxIDUDMedida.TabIndex = 57
        Me.cbxIDUDMedida.ValueMember = "IDUdMedida"
        Me.cbxIDUDMedida.ViewName = "tbMaestroUdMedida"
        '
        'txtQPrev
        '
        Me.txtQPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPrev.Location = New System.Drawing.Point(92, 126)
        Me.txtQPrev.Name = "txtQPrev"
        Me.txtQPrev.Size = New System.Drawing.Size(57, 21)
        Me.txtQPrev.TabIndex = 56
        '
        'txtPedidoCliente
        '
        Me.txtPedidoCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtPedidoCliente.Location = New System.Drawing.Point(92, 28)
        Me.txtPedidoCliente.Multiline = True
        Me.txtPedidoCliente.Name = "txtPedidoCliente"
        Me.txtPedidoCliente.Size = New System.Drawing.Size(187, 42)
        Me.txtPedidoCliente.TabIndex = 49
        '
        'pnlGridTrabajo
        '
        Me.pnlGridTrabajo.Controls.Add(Me.GridTrabajos)
        Me.pnlGridTrabajo.Controls.Add(Me.pnlConfigVerTrabajos)
        Me.pnlGridTrabajo.Controls.Add(Me.pnlVerTrabajosGrid)
        Me.pnlGridTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGridTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.pnlGridTrabajo.Name = "pnlGridTrabajo"
        Me.pnlGridTrabajo.Size = New System.Drawing.Size(497, 454)
        Me.pnlGridTrabajo.TabIndex = 182
        '
        'GridTrabajos
        '
        Me.GridTrabajos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentroGestion", "CentroGestion", "IDCentroGestion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NumeroPedido", "PedidoVentaCabecera", "IDPedido"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUdMedida", "UdMedida", "IDUdMedida"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoTrabajo", "ObraTipoTrabajo", "IDTipoTrabajo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDSubtipoTrabajo", Nothing, "IDSubtipoTrabajo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDActividad", Nothing, "IDActividad"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDDireccion", Nothing, "IDDireccion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IdOperarioOS", Nothing, "IdOperarioOS")})
        GridTrabajos_DesignTimeLayout.LayoutString = resources.GetString("GridTrabajos_DesignTimeLayout.LayoutString")
        Me.GridTrabajos.DesignTimeLayout = GridTrabajos_DesignTimeLayout
        Me.GridTrabajos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTrabajos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridTrabajos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridTrabajos.EntityName = ""
        Me.GridTrabajos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridTrabajos.FrozenColumns = 8
        Me.GridTrabajos.ImageList = Me.ImageList1
        Me.GridTrabajos.Location = New System.Drawing.Point(0, 56)
        Me.GridTrabajos.Name = "GridTrabajos"
        Me.GridTrabajos.PrimaryDataFields = Nothing
        Me.GridTrabajos.SecondaryDataFields = Nothing
        Me.GridTrabajos.Size = New System.Drawing.Size(497, 398)
        Me.GridTrabajos.TabIndex = 186
        Me.GridTrabajos.ViewName = ""
        '
        'pnlConfigVerTrabajos
        '
        Me.pnlConfigVerTrabajos.Controls.Add(Me.rbtPorOServicio)
        Me.pnlConfigVerTrabajos.Controls.Add(Me.lblVerTrabajos)
        Me.pnlConfigVerTrabajos.Controls.Add(Me.rbtPorAlquiler)
        Me.pnlConfigVerTrabajos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerTrabajos.Location = New System.Drawing.Point(0, 30)
        Me.pnlConfigVerTrabajos.Name = "pnlConfigVerTrabajos"
        Me.pnlConfigVerTrabajos.Size = New System.Drawing.Size(497, 26)
        Me.pnlConfigVerTrabajos.TabIndex = 185
        '
        'rbtPorOServicio
        '
        Me.rbtPorOServicio.Location = New System.Drawing.Point(381, 6)
        Me.rbtPorOServicio.Name = "rbtPorOServicio"
        Me.rbtPorOServicio.Size = New System.Drawing.Size(106, 12)
        Me.rbtPorOServicio.TabIndex = 11
        Me.rbtPorOServicio.Text = "por O. Servicio"
        '
        'lblVerTrabajos
        '
        Me.lblVerTrabajos.Location = New System.Drawing.Point(5, 6)
        Me.lblVerTrabajos.Name = "lblVerTrabajos"
        Me.lblVerTrabajos.Size = New System.Drawing.Size(161, 13)
        Me.lblVerTrabajos.TabIndex = 10
        Me.lblVerTrabajos.Text = "Ver los datos de las líneas:"
        '
        'rbtPorAlquiler
        '
        Me.rbtPorAlquiler.Location = New System.Drawing.Point(277, 6)
        Me.rbtPorAlquiler.Name = "rbtPorAlquiler"
        Me.rbtPorAlquiler.Size = New System.Drawing.Size(98, 12)
        Me.rbtPorAlquiler.TabIndex = 8
        Me.rbtPorAlquiler.Text = "por Alquiler"
        '
        'pnlVerTrabajosGrid
        '
        Me.pnlVerTrabajosGrid.Controls.Add(Me.txtDescTrabajoGrid)
        Me.pnlVerTrabajosGrid.Controls.Add(Me.lblTrabajoGrid)
        Me.pnlVerTrabajosGrid.Controls.Add(Me.txtTrabajoGrid)
        Me.pnlVerTrabajosGrid.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerTrabajosGrid.Location = New System.Drawing.Point(0, 0)
        Me.pnlVerTrabajosGrid.Name = "pnlVerTrabajosGrid"
        Me.pnlVerTrabajosGrid.Size = New System.Drawing.Size(497, 30)
        Me.pnlVerTrabajosGrid.TabIndex = 184
        Me.pnlVerTrabajosGrid.Visible = False
        '
        'txtDescTrabajoGrid
        '
        Me.txtDescTrabajoGrid.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoGrid.Enabled = False
        Me.txtDescTrabajoGrid.Location = New System.Drawing.Point(175, 6)
        Me.txtDescTrabajoGrid.Name = "txtDescTrabajoGrid"
        Me.txtDescTrabajoGrid.Size = New System.Drawing.Size(316, 21)
        Me.txtDescTrabajoGrid.TabIndex = 201
        Me.txtDescTrabajoGrid.TabStop = False
        '
        'lblTrabajoGrid
        '
        Me.lblTrabajoGrid.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoGrid.Name = "lblTrabajoGrid"
        Me.lblTrabajoGrid.Size = New System.Drawing.Size(70, 13)
        Me.lblTrabajoGrid.TabIndex = 200
        Me.lblTrabajoGrid.Text = "O. Servicio"
        '
        'txtTrabajoGrid
        '
        Me.txtTrabajoGrid.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoGrid.Enabled = False
        Me.txtTrabajoGrid.Location = New System.Drawing.Point(76, 6)
        Me.txtTrabajoGrid.Name = "txtTrabajoGrid"
        Me.txtTrabajoGrid.Size = New System.Drawing.Size(96, 21)
        Me.txtTrabajoGrid.TabIndex = 199
        Me.txtTrabajoGrid.TabStop = False
        '
        'pnlCliente
        '
        Me.pnlCliente.BackColor = System.Drawing.SystemColors.Info
        Me.pnlCliente.Controls.Add(Me.txtCifClienteOT)
        Me.pnlCliente.Controls.Add(Me.lblClienteOT)
        Me.pnlCliente.Controls.Add(Me.ulDescClienteOT)
        Me.pnlCliente.Controls.Add(Me.AdvClienteOT)
        Me.pnlCliente.Controls.Add(Me.lblCIFClienteOT)
        Me.pnlCliente.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlCliente.Location = New System.Drawing.Point(0, 454)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Size = New System.Drawing.Size(497, 29)
        Me.pnlCliente.TabIndex = 0
        '
        'txtCifClienteOT
        '
        Me.txtCifClienteOT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtCifClienteOT, New System.Windows.Forms.Binding("Text", Me.AdvClienteOT, "CifCliente", True))
        Me.txtCifClienteOT.DisabledBackColor = System.Drawing.Color.White
        Me.txtCifClienteOT.Enabled = False
        Me.txtCifClienteOT.Location = New System.Drawing.Point(398, 5)
        Me.txtCifClienteOT.Name = "txtCifClienteOT"
        Me.txtCifClienteOT.Size = New System.Drawing.Size(95, 21)
        Me.txtCifClienteOT.TabIndex = 100
        Me.txtCifClienteOT.TabStop = False
        '
        'lblClienteOT
        '
        Me.lblClienteOT.Location = New System.Drawing.Point(6, 8)
        Me.lblClienteOT.Name = "lblClienteOT"
        Me.lblClienteOT.Size = New System.Drawing.Size(47, 13)
        Me.lblClienteOT.TabIndex = 97
        Me.lblClienteOT.Text = "Cliente"
        '
        'ulDescClienteOT
        '
        Me.ulDescClienteOT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(ulDescClienteOT, New System.Windows.Forms.Binding("Text", Me, "TextoCliente", True))
        Me.ulDescClienteOT.Location = New System.Drawing.Point(173, 4)
        Me.ulDescClienteOT.Name = "ulDescClienteOT"
        Me.ulDescClienteOT.Size = New System.Drawing.Size(193, 21)
        Me.ulDescClienteOT.TabIndex = 98
        '
        'AdvClienteOT
        '
        Me.TryDataBinding(AdvClienteOT, New System.Windows.Forms.Binding("Text", Me, "IDCliente", True))
        Me.AdvClienteOT.DisabledBackColor = System.Drawing.Color.White
        Me.AdvClienteOT.Enabled = False
        Me.AdvClienteOT.Location = New System.Drawing.Point(55, 3)
        Me.AdvClienteOT.Name = "AdvClienteOT"
        Me.AdvClienteOT.Size = New System.Drawing.Size(114, 23)
        Me.AdvClienteOT.TabIndex = 96
        '
        'lblCIFClienteOT
        '
        Me.lblCIFClienteOT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCIFClienteOT.Location = New System.Drawing.Point(370, 9)
        Me.lblCIFClienteOT.Name = "lblCIFClienteOT"
        Me.lblCIFClienteOT.Size = New System.Drawing.Size(26, 13)
        Me.lblCIFClienteOT.TabIndex = 99
        Me.lblCIFClienteOT.Text = "NIF"
        '
        'TabPageArticulos
        '
        Me.TabPageArticulos.Controls.Add(Me.GridMaterial)
        Me.TabPageArticulos.Controls.Add(Me.pnlConfigVerArticulos)
        Me.TabPageArticulos.Controls.Add(Me.pnlVerArticulos)
        Me.TabPageArticulos.Controls.Add(Me.FraPortesArticulos)
        Me.TabPageArticulos.Key = "Articulos"
        Me.TabPageArticulos.Location = New System.Drawing.Point(1, 1)
        Me.TabPageArticulos.Name = "TabPageArticulos"
        Me.TabPageArticulos.Size = New System.Drawing.Size(497, 483)
        Me.TabPageArticulos.TabStop = True
        Me.TabPageArticulos.Text = "Artículos"
        Me.TabPageArticulos.Visible = False
        '
        'GridMaterial
        '
        Me.GridMaterial.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDProveedor", "Proveedor", "IDProveedor"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacen", "Almacen", "IDAlmacen"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUDInterna", "UDMedida", "IDUDMedida"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUDCompra", "UDMedida", "IDUDMedida"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUDVenta", "UDMedida", "IDUDMedida"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CCVenta", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CCCompra", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMaterial", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescMaterial"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDUdInterna", "IDUdInterna"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDUdCompra", "IDUdCompra"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDUdVenta", "IDUdVenta"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("TipoFactAlquiler", "TipoFactAlquiler"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDMaterialOrigen"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("QPrev", "QPrevTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Facturable", "Facturable")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMaterialOrigen", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFamilia", Nothing, "IDFamilia"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipo", Nothing, "IDTipo")})
        GridMaterial_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridMaterial_DesignTimeLayout_Reference_0.Instance"), Object)
        GridMaterial_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridMaterial_DesignTimeLayout_Reference_1.Instance"), Object)
        GridMaterial_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridMaterial_DesignTimeLayout_Reference_2.Instance"), Object)
        GridMaterial_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("GridMaterial_DesignTimeLayout_Reference_3.Instance"), Object)
        GridMaterial_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("GridMaterial_DesignTimeLayout_Reference_4.Instance"), Object)
        GridMaterial_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("GridMaterial_DesignTimeLayout_Reference_5.Instance"), Object)
        GridMaterial_DesignTimeLayout_Reference_6.Instance = CType(resources.GetObject("GridMaterial_DesignTimeLayout_Reference_6.Instance"), Object)
        GridMaterial_DesignTimeLayout_Reference_7.Instance = CType(resources.GetObject("GridMaterial_DesignTimeLayout_Reference_7.Instance"), Object)
        GridMaterial_DesignTimeLayout_Reference_8.Instance = CType(resources.GetObject("GridMaterial_DesignTimeLayout_Reference_8.Instance"), Object)
        GridMaterial_DesignTimeLayout_Reference_9.Instance = CType(resources.GetObject("GridMaterial_DesignTimeLayout_Reference_9.Instance"), Object)
        GridMaterial_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridMaterial_DesignTimeLayout_Reference_0, GridMaterial_DesignTimeLayout_Reference_1, GridMaterial_DesignTimeLayout_Reference_2, GridMaterial_DesignTimeLayout_Reference_3, GridMaterial_DesignTimeLayout_Reference_4, GridMaterial_DesignTimeLayout_Reference_5, GridMaterial_DesignTimeLayout_Reference_6, GridMaterial_DesignTimeLayout_Reference_7, GridMaterial_DesignTimeLayout_Reference_8, GridMaterial_DesignTimeLayout_Reference_9})
        GridMaterial_DesignTimeLayout.LayoutString = resources.GetString("GridMaterial_DesignTimeLayout.LayoutString")
        Me.GridMaterial.DesignTimeLayout = GridMaterial_DesignTimeLayout
        Me.GridMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMaterial.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMaterial.EntityName = "ObraMaterial"
        Me.GridMaterial.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMaterial.FrozenColumns = 10
        Me.GridMaterial.ImageList = Me.ImageList1
        Me.GridMaterial.Location = New System.Drawing.Point(0, 56)
        Me.GridMaterial.Name = "GridMaterial"
        Me.GridMaterial.PrimaryDataFields = "IDObra"
        Me.GridMaterial.SecondaryDataFields = "IDObra"
        Me.GridMaterial.Size = New System.Drawing.Size(497, 342)
        Me.GridMaterial.TabIndex = 84
        Me.GridMaterial.ViewName = "vFrmAlquilerMateriales"
        '
        'pnlConfigVerArticulos
        '
        Me.pnlConfigVerArticulos.Controls.Add(Me.rbtMaterialOServicio)
        Me.pnlConfigVerArticulos.Controls.Add(Me.lblVerMateriales)
        Me.pnlConfigVerArticulos.Controls.Add(Me.rbtMaterialAlquiler)
        Me.pnlConfigVerArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerArticulos.Location = New System.Drawing.Point(0, 30)
        Me.pnlConfigVerArticulos.Name = "pnlConfigVerArticulos"
        Me.pnlConfigVerArticulos.Size = New System.Drawing.Size(497, 26)
        Me.pnlConfigVerArticulos.TabIndex = 12
        '
        'rbtMaterialOServicio
        '
        Me.rbtMaterialOServicio.Location = New System.Drawing.Point(381, 5)
        Me.rbtMaterialOServicio.Name = "rbtMaterialOServicio"
        Me.rbtMaterialOServicio.Size = New System.Drawing.Size(106, 15)
        Me.rbtMaterialOServicio.TabIndex = 12
        Me.rbtMaterialOServicio.Text = "por O. Servicio"
        '
        'lblVerMateriales
        '
        Me.lblVerMateriales.Location = New System.Drawing.Point(5, 6)
        Me.lblVerMateriales.Name = "lblVerMateriales"
        Me.lblVerMateriales.Size = New System.Drawing.Size(161, 13)
        Me.lblVerMateriales.TabIndex = 10
        Me.lblVerMateriales.Text = "Ver los datos de las líneas:"
        '
        'rbtMaterialAlquiler
        '
        Me.rbtMaterialAlquiler.Location = New System.Drawing.Point(277, 5)
        Me.rbtMaterialAlquiler.Name = "rbtMaterialAlquiler"
        Me.rbtMaterialAlquiler.ShowFocusRectangle = False
        Me.rbtMaterialAlquiler.Size = New System.Drawing.Size(98, 15)
        Me.rbtMaterialAlquiler.TabIndex = 8
        Me.rbtMaterialAlquiler.Text = "por Alquiler"
        '
        'pnlVerArticulos
        '
        Me.pnlVerArticulos.Controls.Add(Me.txtDescTrabajoMateriales)
        Me.pnlVerArticulos.Controls.Add(Me.lblTrabajoMateriales)
        Me.pnlVerArticulos.Controls.Add(Me.txtTrabajoMateriales)
        Me.pnlVerArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerArticulos.Location = New System.Drawing.Point(0, 0)
        Me.pnlVerArticulos.Name = "pnlVerArticulos"
        Me.pnlVerArticulos.Size = New System.Drawing.Size(497, 30)
        Me.pnlVerArticulos.TabIndex = 11
        Me.pnlVerArticulos.Visible = False
        '
        'txtDescTrabajoMateriales
        '
        Me.txtDescTrabajoMateriales.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoMateriales.Enabled = False
        Me.txtDescTrabajoMateriales.Location = New System.Drawing.Point(175, 6)
        Me.txtDescTrabajoMateriales.Name = "txtDescTrabajoMateriales"
        Me.txtDescTrabajoMateriales.Size = New System.Drawing.Size(316, 21)
        Me.txtDescTrabajoMateriales.TabIndex = 201
        Me.txtDescTrabajoMateriales.TabStop = False
        '
        'lblTrabajoMateriales
        '
        Me.lblTrabajoMateriales.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoMateriales.Name = "lblTrabajoMateriales"
        Me.lblTrabajoMateriales.Size = New System.Drawing.Size(70, 13)
        Me.lblTrabajoMateriales.TabIndex = 200
        Me.lblTrabajoMateriales.Text = "O. Servicio"
        '
        'txtTrabajoMateriales
        '
        Me.txtTrabajoMateriales.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoMateriales.Enabled = False
        Me.txtTrabajoMateriales.Location = New System.Drawing.Point(76, 6)
        Me.txtTrabajoMateriales.Name = "txtTrabajoMateriales"
        Me.txtTrabajoMateriales.Size = New System.Drawing.Size(96, 21)
        Me.txtTrabajoMateriales.TabIndex = 199
        Me.txtTrabajoMateriales.TabStop = False
        '
        'FraPortesArticulos
        '
        Me.FraPortesArticulos.Controls.Add(Me.pnlFillPortesArticulos)
        Me.FraPortesArticulos.Controls.Add(Me.pnlLeftPortesArticulos)
        Me.FraPortesArticulos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraPortesArticulos.Location = New System.Drawing.Point(0, 398)
        Me.FraPortesArticulos.Name = "FraPortesArticulos"
        Me.FraPortesArticulos.Size = New System.Drawing.Size(497, 85)
        Me.FraPortesArticulos.TabIndex = 0
        Me.FraPortesArticulos.TabStop = False
        '
        'pnlFillPortesArticulos
        '
        Me.pnlFillPortesArticulos.Controls.Add(Me.txtCondicionesEspPortesBloq)
        Me.pnlFillPortesArticulos.Controls.Add(Me.Panel8)
        Me.pnlFillPortesArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFillPortesArticulos.Location = New System.Drawing.Point(194, 17)
        Me.pnlFillPortesArticulos.Name = "pnlFillPortesArticulos"
        Me.pnlFillPortesArticulos.Size = New System.Drawing.Size(300, 65)
        Me.pnlFillPortesArticulos.TabIndex = 13
        '
        'txtCondicionesEspPortesBloq
        '
        Me.TryDataBinding(txtCondicionesEspPortesBloq, New System.Windows.Forms.Binding("Text", Me, "CondicionesEspPortes", True))
        Me.txtCondicionesEspPortesBloq.DisabledBackColor = System.Drawing.Color.White
        Me.txtCondicionesEspPortesBloq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCondicionesEspPortesBloq.Enabled = False
        Me.txtCondicionesEspPortesBloq.Location = New System.Drawing.Point(0, 23)
        Me.txtCondicionesEspPortesBloq.Multiline = True
        Me.txtCondicionesEspPortesBloq.Name = "txtCondicionesEspPortesBloq"
        Me.txtCondicionesEspPortesBloq.Size = New System.Drawing.Size(300, 42)
        Me.txtCondicionesEspPortesBloq.TabIndex = 10
        Me.txtCondicionesEspPortesBloq.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.lblCondicionesEspPortesBloq)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(300, 23)
        Me.Panel8.TabIndex = 0
        '
        'lblCondicionesEspPortesBloq
        '
        Me.lblCondicionesEspPortesBloq.Location = New System.Drawing.Point(5, 5)
        Me.lblCondicionesEspPortesBloq.Name = "lblCondicionesEspPortesBloq"
        Me.lblCondicionesEspPortesBloq.Size = New System.Drawing.Size(179, 13)
        Me.lblCondicionesEspPortesBloq.TabIndex = 10
        Me.lblCondicionesEspPortesBloq.Text = "Condiciones Especiales Portes"
        '
        'pnlLeftPortesArticulos
        '
        Me.pnlLeftPortesArticulos.Controls.Add(Me.chkPortesEspRetornosBloq)
        Me.pnlLeftPortesArticulos.Controls.Add(Me.chkPortesEspSalidasBloq)
        Me.pnlLeftPortesArticulos.Controls.Add(Me.lblPortesEspSalidasBloq)
        Me.pnlLeftPortesArticulos.Controls.Add(Me.lblPortesEspRetornosBloq)
        Me.pnlLeftPortesArticulos.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftPortesArticulos.Location = New System.Drawing.Point(3, 17)
        Me.pnlLeftPortesArticulos.Name = "pnlLeftPortesArticulos"
        Me.pnlLeftPortesArticulos.Size = New System.Drawing.Size(191, 65)
        Me.pnlLeftPortesArticulos.TabIndex = 12
        '
        'chkPortesEspRetornosBloq
        '
        Me.TryDataBinding(chkPortesEspRetornosBloq, New System.Windows.Forms.Binding("BindableValue", Me, "PortesEspRetornos", True))
        Me.chkPortesEspRetornosBloq.Enabled = False
        Me.chkPortesEspRetornosBloq.Location = New System.Drawing.Point(173, 33)
        Me.chkPortesEspRetornosBloq.Name = "chkPortesEspRetornosBloq"
        Me.chkPortesEspRetornosBloq.Size = New System.Drawing.Size(15, 23)
        Me.chkPortesEspRetornosBloq.TabIndex = 15
        Me.chkPortesEspRetornosBloq.TabStop = False
        '
        'chkPortesEspSalidasBloq
        '
        Me.TryDataBinding(chkPortesEspSalidasBloq, New System.Windows.Forms.Binding("BindableValue", Me, "PortesEspSalidas", True))
        Me.chkPortesEspSalidasBloq.Enabled = False
        Me.chkPortesEspSalidasBloq.Location = New System.Drawing.Point(173, 13)
        Me.chkPortesEspSalidasBloq.Name = "chkPortesEspSalidasBloq"
        Me.chkPortesEspSalidasBloq.Size = New System.Drawing.Size(15, 23)
        Me.chkPortesEspSalidasBloq.TabIndex = 13
        Me.chkPortesEspSalidasBloq.TabStop = False
        '
        'lblPortesEspSalidasBloq
        '
        Me.lblPortesEspSalidasBloq.Location = New System.Drawing.Point(7, 16)
        Me.lblPortesEspSalidasBloq.Name = "lblPortesEspSalidasBloq"
        Me.lblPortesEspSalidasBloq.Size = New System.Drawing.Size(151, 13)
        Me.lblPortesEspSalidasBloq.TabIndex = 12
        Me.lblPortesEspSalidasBloq.Text = "Portes especiales Salidas"
        '
        'lblPortesEspRetornosBloq
        '
        Me.lblPortesEspRetornosBloq.Location = New System.Drawing.Point(7, 36)
        Me.lblPortesEspRetornosBloq.Name = "lblPortesEspRetornosBloq"
        Me.lblPortesEspRetornosBloq.Size = New System.Drawing.Size(161, 13)
        Me.lblPortesEspRetornosBloq.TabIndex = 14
        Me.lblPortesEspRetornosBloq.Text = "Portes especiales Retornos"
        '
        'TabPageIncidencias
        '
        Me.TabPageIncidencias.Controls.Add(Me.GridIncidencias)
        Me.TabPageIncidencias.Controls.Add(Me.pnlFiltrarPorMaterial)
        Me.TabPageIncidencias.Controls.Add(Me.pnlConfigVerIncidencias)
        Me.TabPageIncidencias.Controls.Add(Me.pnlVerIncidencias)
        Me.TabPageIncidencias.Key = "Incidencias"
        Me.TabPageIncidencias.Location = New System.Drawing.Point(1, 1)
        Me.TabPageIncidencias.Name = "TabPageIncidencias"
        Me.TabPageIncidencias.Size = New System.Drawing.Size(497, 508)
        Me.TabPageIncidencias.TabStop = True
        Me.TabPageIncidencias.Text = "Incidencias"
        '
        'GridIncidencias
        '
        Me.GridIncidencias.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMaterial", "ObraMaterial", "IDMaterial", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDLineaMaterial", "IDLineaMaterial")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDIncidenciasAlquiler", "IncidenciasAlquiler", "IDIncidenciasAlquiler", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("AfectaFactura", "AfectaFactura"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Imprimible", "Imprimible"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescIncidenciasAlquiler", "DescIncidenciasAlquiler")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo")}))})
        GridIncidencias_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridIncidencias_DesignTimeLayout_Reference_0.Instance"), Object)
        GridIncidencias_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridIncidencias_DesignTimeLayout_Reference_1.Instance"), Object)
        GridIncidencias_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridIncidencias_DesignTimeLayout_Reference_2.Instance"), Object)
        GridIncidencias_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("GridIncidencias_DesignTimeLayout_Reference_3.Instance"), Object)
        GridIncidencias_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridIncidencias_DesignTimeLayout_Reference_0, GridIncidencias_DesignTimeLayout_Reference_1, GridIncidencias_DesignTimeLayout_Reference_2, GridIncidencias_DesignTimeLayout_Reference_3})
        GridIncidencias_DesignTimeLayout.LayoutString = resources.GetString("GridIncidencias_DesignTimeLayout.LayoutString")
        Me.GridIncidencias.DesignTimeLayout = GridIncidencias_DesignTimeLayout
        Me.GridIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridIncidencias.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridIncidencias.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridIncidencias.EntityName = "ObraMaterialIncidenciasAlq"
        Me.GridIncidencias.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridIncidencias.FrozenColumns = 6
        Me.GridIncidencias.ImageList = Me.ImageList1
        Me.GridIncidencias.Location = New System.Drawing.Point(0, 84)
        Me.GridIncidencias.Name = "GridIncidencias"
        Me.GridIncidencias.PrimaryDataFields = "IDObra"
        Me.GridIncidencias.SecondaryDataFields = "IDObra"
        Me.GridIncidencias.Size = New System.Drawing.Size(497, 424)
        Me.GridIncidencias.TabIndex = 15
        Me.GridIncidencias.ViewName = "vFrmAlquilerMaterialIncidenciasAlq"
        '
        'pnlFiltrarPorMaterial
        '
        Me.pnlFiltrarPorMaterial.Controls.Add(Me.CmdMasiva)
        Me.pnlFiltrarPorMaterial.Controls.Add(Me.lblMaterial)
        Me.pnlFiltrarPorMaterial.Controls.Add(Me.AdvMaterial)
        Me.pnlFiltrarPorMaterial.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltrarPorMaterial.Location = New System.Drawing.Point(0, 56)
        Me.pnlFiltrarPorMaterial.Name = "pnlFiltrarPorMaterial"
        Me.pnlFiltrarPorMaterial.Size = New System.Drawing.Size(497, 28)
        Me.pnlFiltrarPorMaterial.TabIndex = 14
        '
        'CmdMasiva
        '
        Me.CmdMasiva.ImageIndex = 10
        Me.CmdMasiva.ImageList = Me.ImageList1
        Me.CmdMasiva.Location = New System.Drawing.Point(464, 0)
        Me.CmdMasiva.Name = "CmdMasiva"
        Me.CmdMasiva.Size = New System.Drawing.Size(27, 26)
        Me.CmdMasiva.TabIndex = 111
        '
        'lblMaterial
        '
        Me.lblMaterial.Location = New System.Drawing.Point(294, 3)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(52, 13)
        Me.lblMaterial.TabIndex = 85
        Me.lblMaterial.Text = "Material"
        '
        'AdvMaterial
        '
        Me.AdvMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.AdvMaterial.DisplayField = "IDMaterial"
        Me.AdvMaterial.EntityName = "ObraMaterial"
        Me.AdvMaterial.Location = New System.Drawing.Point(350, 3)
        Me.AdvMaterial.Name = "AdvMaterial"
        Me.AdvMaterial.SecondaryDataFields = "IDLineaMaterial"
        Me.AdvMaterial.Size = New System.Drawing.Size(106, 23)
        Me.AdvMaterial.TabIndex = 84
        '
        'pnlConfigVerIncidencias
        '
        Me.pnlConfigVerIncidencias.Controls.Add(Me.chkFiltrarPorMaterial)
        Me.pnlConfigVerIncidencias.Controls.Add(Me.rbtIncidenciasOServicio)
        Me.pnlConfigVerIncidencias.Controls.Add(Me.lblVerIncidencias)
        Me.pnlConfigVerIncidencias.Controls.Add(Me.rbtIncidenciasAlquiler)
        Me.pnlConfigVerIncidencias.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerIncidencias.Location = New System.Drawing.Point(0, 30)
        Me.pnlConfigVerIncidencias.Name = "pnlConfigVerIncidencias"
        Me.pnlConfigVerIncidencias.Size = New System.Drawing.Size(497, 26)
        Me.pnlConfigVerIncidencias.TabIndex = 13
        '
        'chkFiltrarPorMaterial
        '
        Me.chkFiltrarPorMaterial.Location = New System.Drawing.Point(397, 5)
        Me.chkFiltrarPorMaterial.Name = "chkFiltrarPorMaterial"
        Me.chkFiltrarPorMaterial.Size = New System.Drawing.Size(89, 15)
        Me.chkFiltrarPorMaterial.TabIndex = 13
        Me.chkFiltrarPorMaterial.Text = "Por Material"
        '
        'rbtIncidenciasOServicio
        '
        Me.rbtIncidenciasOServicio.Location = New System.Drawing.Point(282, 5)
        Me.rbtIncidenciasOServicio.Name = "rbtIncidenciasOServicio"
        Me.rbtIncidenciasOServicio.Size = New System.Drawing.Size(106, 15)
        Me.rbtIncidenciasOServicio.TabIndex = 12
        Me.rbtIncidenciasOServicio.Text = "por O.Servicio"
        '
        'lblVerIncidencias
        '
        Me.lblVerIncidencias.Location = New System.Drawing.Point(5, 6)
        Me.lblVerIncidencias.Name = "lblVerIncidencias"
        Me.lblVerIncidencias.Size = New System.Drawing.Size(141, 13)
        Me.lblVerIncidencias.TabIndex = 10
        Me.lblVerIncidencias.Text = "Ver datos de las líneas:"
        '
        'rbtIncidenciasAlquiler
        '
        Me.rbtIncidenciasAlquiler.Location = New System.Drawing.Point(188, 5)
        Me.rbtIncidenciasAlquiler.Name = "rbtIncidenciasAlquiler"
        Me.rbtIncidenciasAlquiler.Size = New System.Drawing.Size(87, 15)
        Me.rbtIncidenciasAlquiler.TabIndex = 8
        Me.rbtIncidenciasAlquiler.Text = "por Alquiler"
        '
        'pnlVerIncidencias
        '
        Me.pnlVerIncidencias.Controls.Add(Me.txtTrabajoIncidencias)
        Me.pnlVerIncidencias.Controls.Add(Me.txtDescTrabajoIncidencias)
        Me.pnlVerIncidencias.Controls.Add(Me.Label1)
        Me.pnlVerIncidencias.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerIncidencias.Location = New System.Drawing.Point(0, 0)
        Me.pnlVerIncidencias.Name = "pnlVerIncidencias"
        Me.pnlVerIncidencias.Size = New System.Drawing.Size(497, 30)
        Me.pnlVerIncidencias.TabIndex = 12
        Me.pnlVerIncidencias.Visible = False
        '
        'txtTrabajoIncidencias
        '
        Me.txtTrabajoIncidencias.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoIncidencias.Enabled = False
        Me.txtTrabajoIncidencias.Location = New System.Drawing.Point(76, 6)
        Me.txtTrabajoIncidencias.Name = "txtTrabajoIncidencias"
        Me.txtTrabajoIncidencias.Size = New System.Drawing.Size(96, 21)
        Me.txtTrabajoIncidencias.TabIndex = 204
        Me.txtTrabajoIncidencias.TabStop = False
        '
        'txtDescTrabajoIncidencias
        '
        Me.txtDescTrabajoIncidencias.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoIncidencias.Location = New System.Drawing.Point(175, 6)
        Me.txtDescTrabajoIncidencias.Name = "txtDescTrabajoIncidencias"
        Me.txtDescTrabajoIncidencias.Size = New System.Drawing.Size(316, 21)
        Me.txtDescTrabajoIncidencias.TabIndex = 203
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "O. Servicio"
        '
        'TabPageHitos
        '
        Me.TabPageHitos.Controls.Add(Me.GridVencimientos)
        Me.TabPageHitos.Controls.Add(Me.pnlTotalesHitos)
        Me.TabPageHitos.Controls.Add(Me.pnlConfigVerHitos)
        Me.TabPageHitos.Controls.Add(Me.pnlVerHitos)
        Me.TabPageHitos.Key = "Hitos"
        Me.TabPageHitos.Location = New System.Drawing.Point(1, 1)
        Me.TabPageHitos.Name = "TabPageHitos"
        Me.TabPageHitos.Size = New System.Drawing.Size(497, 508)
        Me.TabPageHitos.TabStop = True
        Me.TabPageHitos.Text = "Hitos de Facturación"
        Me.TabPageHitos.Visible = False
        '
        'GridVencimientos
        '
        Me.GridVencimientos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoIva", "TipoIva", "IDTipoIva"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDClienteBanco", "ClienteBanco", "IDClienteBanco"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCondicionPago", "CondicionPago", "IDCondicionPago"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDDiaPago", "DiaPago", "IDDiaPago"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IdLineaAlbaranVentaOrigen", "AlbaranVentaLinea", "IDLineaAlbaran", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDAlbaran", "IdAlbaranVentaOrigen"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescVencimiento"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDArticulo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDLineaMaterial", "IDLineaMaterial"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Importe", "ImpVencimientoA"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("QServida", "Qinterna"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Precio", "PrecioVto"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("TipoFactAlquiler", "TipoFactAlquiler")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDConcepto", "Concepto", "IDConcepto", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescConcepto", "DescConcepto")}))})
        Me.GridVencimientos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridVencimientos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_0.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_1.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_2.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_3.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_4.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_5.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_6.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_6.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_7.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_7.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_8.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_8.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_9.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_9.Instance"), Object)
        GridVencimientos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridVencimientos_DesignTimeLayout_Reference_0, GridVencimientos_DesignTimeLayout_Reference_1, GridVencimientos_DesignTimeLayout_Reference_2, GridVencimientos_DesignTimeLayout_Reference_3, GridVencimientos_DesignTimeLayout_Reference_4, GridVencimientos_DesignTimeLayout_Reference_5, GridVencimientos_DesignTimeLayout_Reference_6, GridVencimientos_DesignTimeLayout_Reference_7, GridVencimientos_DesignTimeLayout_Reference_8, GridVencimientos_DesignTimeLayout_Reference_9})
        GridVencimientos_DesignTimeLayout.LayoutString = resources.GetString("GridVencimientos_DesignTimeLayout.LayoutString")
        Me.GridVencimientos.DesignTimeLayout = GridVencimientos_DesignTimeLayout
        Me.GridVencimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVencimientos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridVencimientos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridVencimientos.EntityName = "ObraTrabajoFacturacion"
        Me.GridVencimientos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridVencimientos.FrozenColumns = 12
        Me.GridVencimientos.Location = New System.Drawing.Point(0, 56)
        Me.GridVencimientos.Name = "GridVencimientos"
        Me.GridVencimientos.PrimaryDataFields = "IDObra"
        Me.GridVencimientos.SecondaryDataFields = "IDObra"
        Me.GridVencimientos.Size = New System.Drawing.Size(497, 417)
        Me.GridVencimientos.TabIndex = 93
        Me.GridVencimientos.ViewName = "vFrmAlquilerTrabajoFacturacion"
        '
        'pnlTotalesHitos
        '
        Me.pnlTotalesHitos.Controls.Add(Me.lblTotalVtoA)
        Me.pnlTotalesHitos.Controls.Add(Me.txtTotalVtoA)
        Me.pnlTotalesHitos.Controls.Add(Me.lblTotalA)
        Me.pnlTotalesHitos.Controls.Add(Me.txtTotalA)
        Me.pnlTotalesHitos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotalesHitos.Location = New System.Drawing.Point(0, 473)
        Me.pnlTotalesHitos.Name = "pnlTotalesHitos"
        Me.pnlTotalesHitos.Size = New System.Drawing.Size(497, 35)
        Me.pnlTotalesHitos.TabIndex = 92
        '
        'lblTotalVtoA
        '
        Me.lblTotalVtoA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalVtoA.AutoSize = False
        Me.lblTotalVtoA.Location = New System.Drawing.Point(30, 8)
        Me.lblTotalVtoA.Name = "lblTotalVtoA"
        Me.lblTotalVtoA.Size = New System.Drawing.Size(89, 17)
        Me.lblTotalVtoA.TabIndex = 83
        Me.lblTotalVtoA.Text = "Importe Vto. A"
        '
        'txtTotalVtoA
        '
        Me.txtTotalVtoA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalVtoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalVtoA.Enabled = False
        Me.txtTotalVtoA.Location = New System.Drawing.Point(130, 8)
        Me.txtTotalVtoA.Name = "txtTotalVtoA"
        Me.txtTotalVtoA.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalVtoA.TabIndex = 85
        Me.txtTotalVtoA.TabStop = False
        '
        'lblTotalA
        '
        Me.lblTotalA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalA.AutoSize = False
        Me.lblTotalA.Location = New System.Drawing.Point(258, 8)
        Me.lblTotalA.Name = "lblTotalA"
        Me.lblTotalA.Size = New System.Drawing.Size(94, 17)
        Me.lblTotalA.TabIndex = 86
        Me.lblTotalA.Text = "Importe Total A"
        '
        'txtTotalA
        '
        Me.txtTotalA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalA.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalA.Enabled = False
        Me.txtTotalA.Location = New System.Drawing.Point(360, 8)
        Me.txtTotalA.Name = "txtTotalA"
        Me.txtTotalA.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalA.TabIndex = 84
        Me.txtTotalA.TabStop = False
        '
        'pnlConfigVerHitos
        '
        Me.pnlConfigVerHitos.Controls.Add(Me.lblVerHitos)
        Me.pnlConfigVerHitos.Controls.Add(Me.rbtHitosOServicio)
        Me.pnlConfigVerHitos.Controls.Add(Me.rbtHitosAlquiler)
        Me.pnlConfigVerHitos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerHitos.Location = New System.Drawing.Point(0, 30)
        Me.pnlConfigVerHitos.Name = "pnlConfigVerHitos"
        Me.pnlConfigVerHitos.Size = New System.Drawing.Size(497, 26)
        Me.pnlConfigVerHitos.TabIndex = 91
        '
        'lblVerHitos
        '
        Me.lblVerHitos.Location = New System.Drawing.Point(5, 6)
        Me.lblVerHitos.Name = "lblVerHitos"
        Me.lblVerHitos.Size = New System.Drawing.Size(211, 13)
        Me.lblVerHitos.TabIndex = 12
        Me.lblVerHitos.Text = "Ver los datos de las líneas de Hitos:"
        '
        'rbtHitosOServicio
        '
        Me.rbtHitosOServicio.Location = New System.Drawing.Point(381, 5)
        Me.rbtHitosOServicio.Name = "rbtHitosOServicio"
        Me.rbtHitosOServicio.Size = New System.Drawing.Size(106, 15)
        Me.rbtHitosOServicio.TabIndex = 9
        Me.rbtHitosOServicio.Text = "por O. Servicio"
        '
        'rbtHitosAlquiler
        '
        Me.rbtHitosAlquiler.Location = New System.Drawing.Point(277, 5)
        Me.rbtHitosAlquiler.Name = "rbtHitosAlquiler"
        Me.rbtHitosAlquiler.ShowFocusRectangle = False
        Me.rbtHitosAlquiler.Size = New System.Drawing.Size(98, 15)
        Me.rbtHitosAlquiler.TabIndex = 8
        Me.rbtHitosAlquiler.Text = "por Alquiler"
        '
        'pnlVerHitos
        '
        Me.pnlVerHitos.Controls.Add(Me.txtDescTrabajoHitos)
        Me.pnlVerHitos.Controls.Add(Me.lblTrabajoHitos)
        Me.pnlVerHitos.Controls.Add(Me.txtTrabajoHitos)
        Me.pnlVerHitos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerHitos.Location = New System.Drawing.Point(0, 0)
        Me.pnlVerHitos.Name = "pnlVerHitos"
        Me.pnlVerHitos.Size = New System.Drawing.Size(497, 30)
        Me.pnlVerHitos.TabIndex = 90
        Me.pnlVerHitos.Visible = False
        '
        'txtDescTrabajoHitos
        '
        Me.txtDescTrabajoHitos.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoHitos.Enabled = False
        Me.txtDescTrabajoHitos.Location = New System.Drawing.Point(175, 6)
        Me.txtDescTrabajoHitos.Name = "txtDescTrabajoHitos"
        Me.txtDescTrabajoHitos.Size = New System.Drawing.Size(316, 21)
        Me.txtDescTrabajoHitos.TabIndex = 201
        Me.txtDescTrabajoHitos.TabStop = False
        '
        'lblTrabajoHitos
        '
        Me.lblTrabajoHitos.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoHitos.Name = "lblTrabajoHitos"
        Me.lblTrabajoHitos.Size = New System.Drawing.Size(70, 13)
        Me.lblTrabajoHitos.TabIndex = 200
        Me.lblTrabajoHitos.Text = "O. Servicio"
        '
        'txtTrabajoHitos
        '
        Me.txtTrabajoHitos.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoHitos.Enabled = False
        Me.txtTrabajoHitos.Location = New System.Drawing.Point(76, 6)
        Me.txtTrabajoHitos.Name = "txtTrabajoHitos"
        Me.txtTrabajoHitos.Size = New System.Drawing.Size(96, 21)
        Me.txtTrabajoHitos.TabIndex = 199
        Me.txtTrabajoHitos.TabStop = False
        '
        'TabPagePersonal
        '
        Me.TabPagePersonal.Controls.Add(Me.GridOperariosOrdenServicio)
        Me.TabPagePersonal.Controls.Add(Me.pnlConfigVerOperarios)
        Me.TabPagePersonal.Controls.Add(Me.pnlVerOperarios)
        Me.TabPagePersonal.Key = "Personal"
        Me.TabPagePersonal.Location = New System.Drawing.Point(1, 1)
        Me.TabPagePersonal.Name = "TabPagePersonal"
        Me.TabPagePersonal.Size = New System.Drawing.Size(497, 508)
        Me.TabPagePersonal.TabStop = True
        Me.TabPagePersonal.Text = "Personal"
        Me.TabPagePersonal.Visible = False
        '
        'GridOperariosOrdenServicio
        '
        Me.GridOperariosOrdenServicio.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperario", "Operario", "IDOperario", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescOperario", "DescOperario"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDOficio", "IDOficio")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOficio", "Oficio", "IDOficio", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescOficio", "DescOficio")}))})
        GridOperariosOrdenServicio_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridOperariosOrdenServicio_DesignTimeLayout_Reference_0.Instance"), Object)
        GridOperariosOrdenServicio_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridOperariosOrdenServicio_DesignTimeLayout_Reference_1.Instance"), Object)
        GridOperariosOrdenServicio_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridOperariosOrdenServicio_DesignTimeLayout_Reference_2.Instance"), Object)
        GridOperariosOrdenServicio_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("GridOperariosOrdenServicio_DesignTimeLayout_Reference_3.Instance"), Object)
        GridOperariosOrdenServicio_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridOperariosOrdenServicio_DesignTimeLayout_Reference_0, GridOperariosOrdenServicio_DesignTimeLayout_Reference_1, GridOperariosOrdenServicio_DesignTimeLayout_Reference_2, GridOperariosOrdenServicio_DesignTimeLayout_Reference_3})
        GridOperariosOrdenServicio_DesignTimeLayout.LayoutString = resources.GetString("GridOperariosOrdenServicio_DesignTimeLayout.LayoutString")
        Me.GridOperariosOrdenServicio.DesignTimeLayout = GridOperariosOrdenServicio_DesignTimeLayout
        Me.GridOperariosOrdenServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOperariosOrdenServicio.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridOperariosOrdenServicio.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridOperariosOrdenServicio.EntityName = "ObraTrabajoOperario"
        Me.GridOperariosOrdenServicio.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridOperariosOrdenServicio.FrozenColumns = 5
        Me.GridOperariosOrdenServicio.ImageList = Me.ImageList1
        Me.GridOperariosOrdenServicio.Location = New System.Drawing.Point(0, 56)
        Me.GridOperariosOrdenServicio.Name = "GridOperariosOrdenServicio"
        Me.GridOperariosOrdenServicio.PrimaryDataFields = "IDObra"
        Me.GridOperariosOrdenServicio.SecondaryDataFields = "IDObra"
        Me.GridOperariosOrdenServicio.Size = New System.Drawing.Size(497, 452)
        Me.GridOperariosOrdenServicio.TabIndex = 96
        Me.GridOperariosOrdenServicio.ViewName = "vFrmAlquilerTrabajoOperario"
        '
        'pnlConfigVerOperarios
        '
        Me.pnlConfigVerOperarios.Controls.Add(Me.lblVerOperarios)
        Me.pnlConfigVerOperarios.Controls.Add(Me.rbtOperariosOServicio)
        Me.pnlConfigVerOperarios.Controls.Add(Me.rbtOperariosAlquiler)
        Me.pnlConfigVerOperarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerOperarios.Location = New System.Drawing.Point(0, 30)
        Me.pnlConfigVerOperarios.Name = "pnlConfigVerOperarios"
        Me.pnlConfigVerOperarios.Size = New System.Drawing.Size(497, 26)
        Me.pnlConfigVerOperarios.TabIndex = 95
        '
        'lblVerOperarios
        '
        Me.lblVerOperarios.Location = New System.Drawing.Point(3, 6)
        Me.lblVerOperarios.Name = "lblVerOperarios"
        Me.lblVerOperarios.Size = New System.Drawing.Size(239, 13)
        Me.lblVerOperarios.TabIndex = 14
        Me.lblVerOperarios.Text = "Ver los datos de las líneas de Operarios:"
        '
        'rbtOperariosOServicio
        '
        Me.rbtOperariosOServicio.Location = New System.Drawing.Point(381, 5)
        Me.rbtOperariosOServicio.Name = "rbtOperariosOServicio"
        Me.rbtOperariosOServicio.Size = New System.Drawing.Size(106, 15)
        Me.rbtOperariosOServicio.TabIndex = 9
        Me.rbtOperariosOServicio.Text = "por O. Servicio"
        '
        'rbtOperariosAlquiler
        '
        Me.rbtOperariosAlquiler.Location = New System.Drawing.Point(277, 5)
        Me.rbtOperariosAlquiler.Name = "rbtOperariosAlquiler"
        Me.rbtOperariosAlquiler.Size = New System.Drawing.Size(98, 15)
        Me.rbtOperariosAlquiler.TabIndex = 8
        Me.rbtOperariosAlquiler.Text = "por Alquiler"
        '
        'pnlVerOperarios
        '
        Me.pnlVerOperarios.Controls.Add(Me.txtDescTrabajoOperarios)
        Me.pnlVerOperarios.Controls.Add(Me.lblTrabajoOperarios)
        Me.pnlVerOperarios.Controls.Add(Me.txtTrabajoOperarios)
        Me.pnlVerOperarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerOperarios.Location = New System.Drawing.Point(0, 0)
        Me.pnlVerOperarios.Name = "pnlVerOperarios"
        Me.pnlVerOperarios.Size = New System.Drawing.Size(497, 30)
        Me.pnlVerOperarios.TabIndex = 94
        Me.pnlVerOperarios.Visible = False
        '
        'txtDescTrabajoOperarios
        '
        Me.txtDescTrabajoOperarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoOperarios.Enabled = False
        Me.txtDescTrabajoOperarios.Location = New System.Drawing.Point(175, 6)
        Me.txtDescTrabajoOperarios.Name = "txtDescTrabajoOperarios"
        Me.txtDescTrabajoOperarios.Size = New System.Drawing.Size(316, 21)
        Me.txtDescTrabajoOperarios.TabIndex = 201
        Me.txtDescTrabajoOperarios.TabStop = False
        '
        'lblTrabajoOperarios
        '
        Me.lblTrabajoOperarios.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoOperarios.Name = "lblTrabajoOperarios"
        Me.lblTrabajoOperarios.Size = New System.Drawing.Size(70, 13)
        Me.lblTrabajoOperarios.TabIndex = 200
        Me.lblTrabajoOperarios.Text = "O. Servicio"
        '
        'txtTrabajoOperarios
        '
        Me.txtTrabajoOperarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoOperarios.Enabled = False
        Me.txtTrabajoOperarios.Location = New System.Drawing.Point(76, 6)
        Me.txtTrabajoOperarios.Name = "txtTrabajoOperarios"
        Me.txtTrabajoOperarios.Size = New System.Drawing.Size(96, 21)
        Me.txtTrabajoOperarios.TabIndex = 199
        Me.txtTrabajoOperarios.TabStop = False
        '
        'Splitter5
        '
        Me.Splitter5.Location = New System.Drawing.Point(257, 0)
        Me.Splitter5.Name = "Splitter5"
        Me.Splitter5.Size = New System.Drawing.Size(5, 485)
        Me.Splitter5.TabIndex = 2
        Me.Splitter5.TabStop = False
        '
        'pnlTrabajos
        '
        Me.pnlTrabajos.Controls.Add(Me.TvwTrabajos)
        Me.pnlTrabajos.Controls.Add(Me.pnlFianzaObligatoria)
        Me.pnlTrabajos.Controls.Add(Me.FraArbol)
        Me.pnlTrabajos.Controls.Add(Me.FraCriterios)
        Me.pnlTrabajos.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTrabajos.Location = New System.Drawing.Point(0, 0)
        Me.pnlTrabajos.Name = "pnlTrabajos"
        Me.pnlTrabajos.Size = New System.Drawing.Size(257, 485)
        Me.pnlTrabajos.TabIndex = 1
        '
        'TvwTrabajos
        '
        Me.TvwTrabajos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TvwTrabajos.Location = New System.Drawing.Point(0, 93)
        Me.TvwTrabajos.Name = "TvwTrabajos"
        Me.TvwTrabajos.Size = New System.Drawing.Size(257, 334)
        Me.TvwTrabajos.TabIndex = 229
        '
        'pnlFianzaObligatoria
        '
        Me.pnlFianzaObligatoria.Controls.Add(Me.lblFianzaObligatoria)
        Me.pnlFianzaObligatoria.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFianzaObligatoria.Location = New System.Drawing.Point(0, 427)
        Me.pnlFianzaObligatoria.Name = "pnlFianzaObligatoria"
        Me.pnlFianzaObligatoria.Size = New System.Drawing.Size(257, 23)
        Me.pnlFianzaObligatoria.TabIndex = 228
        '
        'lblFianzaObligatoria
        '
        Me.lblFianzaObligatoria.Location = New System.Drawing.Point(60, 5)
        Me.lblFianzaObligatoria.Name = "lblFianzaObligatoria"
        Me.lblFianzaObligatoria.Size = New System.Drawing.Size(135, 13)
        Me.lblFianzaObligatoria.TabIndex = 225
        Me.lblFianzaObligatoria.Text = "FIANZA OBLIGATORIA"
        Me.lblFianzaObligatoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FraArbol
        '
        Me.FraArbol.Controls.Add(Me.bCreaAlbaran)
        Me.FraArbol.Controls.Add(Me.bGenerarAlbaran)
        Me.FraArbol.Controls.Add(Me.txtOServicioFind)
        Me.FraArbol.Controls.Add(Me.lblOServicioFind)
        Me.FraArbol.Controls.Add(Me.rbtMinimizarTree)
        Me.FraArbol.Controls.Add(Me.rbtMaximizarTree)
        Me.FraArbol.Controls.Add(Me.lblEstadoDistintoDE)
        Me.FraArbol.Controls.Add(Me.cbxEstadoDistintoDE)
        Me.FraArbol.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraArbol.Location = New System.Drawing.Point(0, 0)
        Me.FraArbol.Name = "FraArbol"
        Me.FraArbol.Size = New System.Drawing.Size(257, 93)
        Me.FraArbol.TabIndex = 223
        Me.FraArbol.TabStop = False
        Me.FraArbol.Text = "Criterios árbol"
        '
        'bCreaAlbaran
        '
        Me.bCreaAlbaran.Location = New System.Drawing.Point(171, 15)
        Me.bCreaAlbaran.Name = "bCreaAlbaran"
        Me.bCreaAlbaran.Size = New System.Drawing.Size(79, 20)
        Me.bCreaAlbaran.TabIndex = 229
        Me.bCreaAlbaran.Text = resources.GetString("bCreaAlbaran.Text")
        '
        'bGenerarAlbaran
        '
        Me.bGenerarAlbaran.Location = New System.Drawing.Point(88, 40)
        Me.bGenerarAlbaran.Name = "bGenerarAlbaran"
        Me.bGenerarAlbaran.Size = New System.Drawing.Size(75, 28)
        Me.bGenerarAlbaran.TabIndex = 228
        Me.bGenerarAlbaran.Text = "Albaran"
        Me.bGenerarAlbaran.Visible = False
        '
        'txtOServicioFind
        '
        Me.txtOServicioFind.DisabledBackColor = System.Drawing.Color.White
        Me.txtOServicioFind.Location = New System.Drawing.Point(81, 67)
        Me.txtOServicioFind.Name = "txtOServicioFind"
        Me.txtOServicioFind.Size = New System.Drawing.Size(170, 21)
        Me.txtOServicioFind.TabIndex = 43
        '
        'lblOServicioFind
        '
        Me.lblOServicioFind.Location = New System.Drawing.Point(7, 71)
        Me.lblOServicioFind.Name = "lblOServicioFind"
        Me.lblOServicioFind.Size = New System.Drawing.Size(70, 13)
        Me.lblOServicioFind.TabIndex = 227
        Me.lblOServicioFind.Text = "O. Servicio"
        '
        'rbtMinimizarTree
        '
        Me.rbtMinimizarTree.Location = New System.Drawing.Point(88, 19)
        Me.rbtMinimizarTree.Name = "rbtMinimizarTree"
        Me.rbtMinimizarTree.Size = New System.Drawing.Size(77, 15)
        Me.rbtMinimizarTree.TabIndex = 40
        Me.rbtMinimizarTree.Text = "Minimizar"
        '
        'rbtMaximizarTree
        '
        Me.rbtMaximizarTree.Location = New System.Drawing.Point(10, 18)
        Me.rbtMaximizarTree.Name = "rbtMaximizarTree"
        Me.rbtMaximizarTree.Size = New System.Drawing.Size(84, 16)
        Me.rbtMaximizarTree.TabIndex = 39
        Me.rbtMaximizarTree.Text = "Maximizar"
        '
        'lblEstadoDistintoDE
        '
        Me.lblEstadoDistintoDE.Location = New System.Drawing.Point(7, 47)
        Me.lblEstadoDistintoDE.Name = "lblEstadoDistintoDE"
        Me.lblEstadoDistintoDE.Size = New System.Drawing.Size(67, 13)
        Me.lblEstadoDistintoDE.TabIndex = 222
        Me.lblEstadoDistintoDE.Text = "Estado <>"
        '
        'cbxEstadoDistintoDE
        '
        Me.cbxEstadoDistintoDE.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxEstadoDistintoDE_DesignTimeLayout.LayoutString = resources.GetString("cbxEstadoDistintoDE_DesignTimeLayout.LayoutString")
        Me.cbxEstadoDistintoDE.DesignTimeLayout = cbxEstadoDistintoDE_DesignTimeLayout
        Me.cbxEstadoDistintoDE.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstadoDistintoDE.DisplayMember = "Value"
        Me.cbxEstadoDistintoDE.Location = New System.Drawing.Point(81, 43)
        Me.cbxEstadoDistintoDE.Name = "cbxEstadoDistintoDE"
        Me.cbxEstadoDistintoDE.PrimaryDataFields = "Estado"
        Me.cbxEstadoDistintoDE.SecondaryDataFields = "Value"
        Me.cbxEstadoDistintoDE.SelectedIndex = -1
        Me.cbxEstadoDistintoDE.SelectedItem = Nothing
        Me.cbxEstadoDistintoDE.Size = New System.Drawing.Size(170, 21)
        Me.cbxEstadoDistintoDE.TabIndex = 42
        '
        'FraCriterios
        '
        Me.FraCriterios.Controls.Add(Me.rbtVerGrid)
        Me.FraCriterios.Controls.Add(Me.rbtVerFicha)
        Me.FraCriterios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraCriterios.Location = New System.Drawing.Point(0, 450)
        Me.FraCriterios.Name = "FraCriterios"
        Me.FraCriterios.Size = New System.Drawing.Size(257, 35)
        Me.FraCriterios.TabIndex = 0
        Me.FraCriterios.TabStop = False
        Me.FraCriterios.Visible = False
        '
        'rbtVerGrid
        '
        Me.rbtVerGrid.Location = New System.Drawing.Point(137, 13)
        Me.rbtVerGrid.Name = "rbtVerGrid"
        Me.rbtVerGrid.Size = New System.Drawing.Size(70, 16)
        Me.rbtVerGrid.TabIndex = 46
        Me.rbtVerGrid.Text = "Ver Grid"
        '
        'rbtVerFicha
        '
        Me.rbtVerFicha.Location = New System.Drawing.Point(50, 13)
        Me.rbtVerFicha.Name = "rbtVerFicha"
        Me.rbtVerFicha.Size = New System.Drawing.Size(75, 16)
        Me.rbtVerFicha.TabIndex = 45
        Me.rbtVerFicha.Text = "Ver Ficha"
        '
        'TabPageRepresentantes
        '
        Me.TabPageRepresentantes.Controls.Add(Me.GridRepresentantes)
        Me.TabPageRepresentantes.Key = "Representantes"
        Me.TabPageRepresentantes.Location = New System.Drawing.Point(1, 21)
        Me.TabPageRepresentantes.Name = "TabPageRepresentantes"
        Me.TabPageRepresentantes.Size = New System.Drawing.Size(782, 485)
        Me.TabPageRepresentantes.TabStop = True
        Me.TabPageRepresentantes.Text = "Representantes"
        '
        'GridRepresentantes
        '
        Me.GridRepresentantes.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDRepresentante", "Representante", "IDRepresentante", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescRepresentante", "DescRepresentante")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipo", "TipoArticulo", "IDTipo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescTipo", "DescTipo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFamilia", "Familia", "IDFamilia", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTipo", "IDTipo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescFamilia", "DescFamilia")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDSubFamilia", "Subfamilia", "IDSubFamilia", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTipo", "IDTipo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDFamilia", "IDFamilia"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescSubfamilia", "DescSubfamilia")}))})
        GridRepresentantes_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridRepresentantes_DesignTimeLayout_Reference_0.Instance"), Object)
        GridRepresentantes_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridRepresentantes_DesignTimeLayout_Reference_1.Instance"), Object)
        GridRepresentantes_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridRepresentantes_DesignTimeLayout_Reference_2.Instance"), Object)
        GridRepresentantes_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("GridRepresentantes_DesignTimeLayout_Reference_3.Instance"), Object)
        GridRepresentantes_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("GridRepresentantes_DesignTimeLayout_Reference_4.Instance"), Object)
        GridRepresentantes_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridRepresentantes_DesignTimeLayout_Reference_0, GridRepresentantes_DesignTimeLayout_Reference_1, GridRepresentantes_DesignTimeLayout_Reference_2, GridRepresentantes_DesignTimeLayout_Reference_3, GridRepresentantes_DesignTimeLayout_Reference_4})
        GridRepresentantes_DesignTimeLayout.LayoutString = resources.GetString("GridRepresentantes_DesignTimeLayout.LayoutString")
        Me.GridRepresentantes.DesignTimeLayout = GridRepresentantes_DesignTimeLayout
        Me.GridRepresentantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridRepresentantes.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridRepresentantes.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridRepresentantes.EntityName = "ObraRepresentante"
        Me.GridRepresentantes.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridRepresentantes.FrozenColumns = 3
        Me.GridRepresentantes.Location = New System.Drawing.Point(0, 0)
        Me.GridRepresentantes.Name = "GridRepresentantes"
        Me.GridRepresentantes.PrimaryDataFields = "IDObra"
        Me.GridRepresentantes.SecondaryDataFields = "IDObra"
        Me.GridRepresentantes.Size = New System.Drawing.Size(782, 485)
        Me.GridRepresentantes.TabIndex = 0
        Me.GridRepresentantes.ViewName = "vFrmAlquilerRepresentantes"
        '
        'TabPageActividades
        '
        Me.TabPageActividades.Controls.Add(Me.GridActividades)
        Me.TabPageActividades.Key = "Actividades"
        Me.TabPageActividades.Location = New System.Drawing.Point(1, 21)
        Me.TabPageActividades.Name = "TabPageActividades"
        Me.TabPageActividades.Size = New System.Drawing.Size(782, 510)
        Me.TabPageActividades.TabStop = True
        Me.TabPageActividades.Text = "Actividades CRM"
        '
        'GridActividades
        '
        Me.GridActividades.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridActividades.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridActividades.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridActividades_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridActividades_DesignTimeLayout_Reference_0.Instance"), Object)
        GridActividades_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridActividades_DesignTimeLayout_Reference_0})
        GridActividades_DesignTimeLayout.LayoutString = resources.GetString("GridActividades_DesignTimeLayout.LayoutString")
        Me.GridActividades.DesignTimeLayout = GridActividades_DesignTimeLayout
        Me.GridActividades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridActividades.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridActividades.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridActividades.EntityName = "EmpresaActividad"
        Me.GridActividades.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridActividades.FrozenColumns = 5
        Me.GridActividades.ImageList = Me.ImageList1
        Me.GridActividades.Location = New System.Drawing.Point(0, 0)
        Me.GridActividades.Name = "GridActividades"
        Me.GridActividades.PrimaryDataFields = "IDObra"
        Me.GridActividades.SecondaryDataFields = "IDObra"
        Me.GridActividades.Size = New System.Drawing.Size(782, 510)
        Me.GridActividades.TabIndex = 0
        Me.GridActividades.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridActividades.ViewName = "vFrmAlquilerActividades"
        '
        'TabPageRecursos
        '
        Me.TabPageRecursos.Controls.Add(Me.GridRecursos)
        Me.TabPageRecursos.Key = "Recursos"
        Me.TabPageRecursos.Location = New System.Drawing.Point(1, 21)
        Me.TabPageRecursos.Name = "TabPageRecursos"
        Me.TabPageRecursos.Size = New System.Drawing.Size(782, 510)
        Me.TabPageRecursos.TabStop = True
        Me.TabPageRecursos.Text = "Recursos"
        '
        'GridRecursos
        '
        Me.GridRecursos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperario", "Operario", "IDOperario", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescOperario", "DescOperario"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDOficio", "IDOficio"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDCategoria", "IDCategoria"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Direccion", "Direccion"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CodPostal", "CodPostal"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Poblacion", "Poblacion"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Provincia", "Provincia"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDPais", "IDPais"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Telefono", "Telefono"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Fax", "Fax"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("EMail", "EMail")}))})
        GridRecursos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridRecursos_DesignTimeLayout_Reference_0.Instance"), Object)
        GridRecursos_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridRecursos_DesignTimeLayout_Reference_1.Instance"), Object)
        GridRecursos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridRecursos_DesignTimeLayout_Reference_0, GridRecursos_DesignTimeLayout_Reference_1})
        GridRecursos_DesignTimeLayout.LayoutString = resources.GetString("GridRecursos_DesignTimeLayout.LayoutString")
        Me.GridRecursos.DesignTimeLayout = GridRecursos_DesignTimeLayout
        Me.GridRecursos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridRecursos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridRecursos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridRecursos.EntityName = "ObraOperario"
        Me.GridRecursos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridRecursos.ImageList = Me.ImageList1
        Me.GridRecursos.Location = New System.Drawing.Point(0, 0)
        Me.GridRecursos.Name = "GridRecursos"
        Me.GridRecursos.PrimaryDataFields = "IDObra"
        Me.GridRecursos.SecondaryDataFields = "IDObra"
        Me.GridRecursos.Size = New System.Drawing.Size(782, 510)
        Me.GridRecursos.TabIndex = 54
        Me.GridRecursos.ViewName = "vFrmObraOperario"
        '
        'OpenDialog1
        '
        Me.OpenDialog1.DefaultExt = "*.doc"
        '
        'MenuAlquiler
        '
        Me.MenuAlquiler.CommandManager = Me.UiCommandManager1
        Me.MenuAlquiler.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.MnuNuevaOrden2, Me.MnuGuion, Me.MnuDeleteOrden2, Me.MnuGuion2, Me.mnuRetornoAvisos2, Me.mnuRetornoMaterial2, Me.mnuPrefacturacion2, Me.mnuFacturacion2, Me.MnuGuion3, Me.mnuADDFianza2, Me.mnuDeleteFianza2, Me.MnuGuion4, Me.mnuGeneraHitos2, Me.mnuIncidencias2, Me.mnuSeguimiento2, Me.MnuGuion5, Me.mnuAlbaran2, Me.mnuSalidaRetorno2, Me.Separator5})
        Me.MenuAlquiler.Key = "MenuAlquiler"
        '
        'MnuNuevaOrden2
        '
        Me.MnuNuevaOrden2.Icon = CType(resources.GetObject("MnuNuevaOrden2.Icon"), System.Drawing.Icon)
        Me.MnuNuevaOrden2.Key = "MnuNuevaOrden"
        Me.MnuNuevaOrden2.Name = "MnuNuevaOrden2"
        '
        'MnuGuion
        '
        Me.MnuGuion.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion.Key = "MnuGuion"
        Me.MnuGuion.Name = "MnuGuion"
        '
        'MnuDeleteOrden2
        '
        Me.MnuDeleteOrden2.Key = "MnuDeleteOrden"
        Me.MnuDeleteOrden2.Name = "MnuDeleteOrden2"
        '
        'MnuGuion2
        '
        Me.MnuGuion2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion2.Key = "MnuGuion2"
        Me.MnuGuion2.Name = "MnuGuion2"
        '
        'mnuRetornoAvisos2
        '
        Me.mnuRetornoAvisos2.Key = "mnuRetornoAvisos"
        Me.mnuRetornoAvisos2.Name = "mnuRetornoAvisos2"
        '
        'mnuRetornoMaterial2
        '
        Me.mnuRetornoMaterial2.Key = "mnuRetornoMaterial"
        Me.mnuRetornoMaterial2.Name = "mnuRetornoMaterial2"
        '
        'mnuPrefacturacion2
        '
        Me.mnuPrefacturacion2.Key = "mnuPrefacturacion"
        Me.mnuPrefacturacion2.Name = "mnuPrefacturacion2"
        '
        'mnuFacturacion2
        '
        Me.mnuFacturacion2.Icon = CType(resources.GetObject("mnuFacturacion2.Icon"), System.Drawing.Icon)
        Me.mnuFacturacion2.Key = "mnuFacturacion"
        Me.mnuFacturacion2.Name = "mnuFacturacion2"
        '
        'MnuGuion3
        '
        Me.MnuGuion3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion3.Key = "MnuGuion3"
        Me.MnuGuion3.Name = "MnuGuion3"
        '
        'mnuADDFianza2
        '
        Me.mnuADDFianza2.Key = "mnuADDFianza"
        Me.mnuADDFianza2.Name = "mnuADDFianza2"
        '
        'mnuDeleteFianza2
        '
        Me.mnuDeleteFianza2.Key = "mnuDeleteFianza"
        Me.mnuDeleteFianza2.Name = "mnuDeleteFianza2"
        '
        'MnuGuion4
        '
        Me.MnuGuion4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion4.Key = "MnuGuion4"
        Me.MnuGuion4.Name = "MnuGuion4"
        '
        'mnuGeneraHitos2
        '
        Me.mnuGeneraHitos2.Icon = CType(resources.GetObject("mnuGeneraHitos2.Icon"), System.Drawing.Icon)
        Me.mnuGeneraHitos2.Key = "mnuGeneraHitos"
        Me.mnuGeneraHitos2.Name = "mnuGeneraHitos2"
        '
        'mnuIncidencias2
        '
        Me.mnuIncidencias2.Icon = CType(resources.GetObject("mnuIncidencias2.Icon"), System.Drawing.Icon)
        Me.mnuIncidencias2.Key = "mnuIncidencias"
        Me.mnuIncidencias2.Name = "mnuIncidencias2"
        '
        'mnuSeguimiento2
        '
        Me.mnuSeguimiento2.Key = "mnuSeguimiento"
        Me.mnuSeguimiento2.Name = "mnuSeguimiento2"
        '
        'MnuGuion5
        '
        Me.MnuGuion5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion5.Key = "MnuGuion5"
        Me.MnuGuion5.Name = "MnuGuion5"
        '
        'mnuAlbaran2
        '
        Me.mnuAlbaran2.Icon = CType(resources.GetObject("mnuAlbaran2.Icon"), System.Drawing.Icon)
        Me.mnuAlbaran2.Key = "mnuAlbaran"
        Me.mnuAlbaran2.Name = "mnuAlbaran2"
        '
        'mnuSalidaRetorno2
        '
        Me.mnuSalidaRetorno2.Key = "mnuSalidaRetorno"
        Me.mnuSalidaRetorno2.Name = "mnuSalidaRetorno2"
        '
        'Separator5
        '
        Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator5.Key = "Separator"
        Me.Separator5.Name = "Separator5"
        '
        'MnuNuevaOrden
        '
        Me.MnuNuevaOrden.Icon = CType(resources.GetObject("MnuNuevaOrden.Icon"), System.Drawing.Icon)
        Me.MnuNuevaOrden.Key = "MnuNuevaOrden"
        Me.MnuNuevaOrden.Name = "MnuNuevaOrden"
        Me.MnuNuevaOrden.Text = "Nueva Orden Servicio"
        '
        'MnuDeleteOrden
        '
        Me.MnuDeleteOrden.Icon = CType(resources.GetObject("MnuDeleteOrden.Icon"), System.Drawing.Icon)
        Me.MnuDeleteOrden.Key = "MnuDeleteOrden"
        Me.MnuDeleteOrden.Name = "MnuDeleteOrden"
        Me.MnuDeleteOrden.Text = "Borrar Orden Servicio"
        '
        'mnuRetornoAvisos
        '
        Me.mnuRetornoAvisos.Image = CType(resources.GetObject("mnuRetornoAvisos.Image"), System.Drawing.Image)
        Me.mnuRetornoAvisos.Key = "mnuRetornoAvisos"
        Me.mnuRetornoAvisos.Name = "mnuRetornoAvisos"
        Me.mnuRetornoAvisos.Text = "Avisos de Retorno"
        '
        'mnuRetornoMaterial
        '
        Me.mnuRetornoMaterial.Icon = CType(resources.GetObject("mnuRetornoMaterial.Icon"), System.Drawing.Icon)
        Me.mnuRetornoMaterial.Key = "mnuRetornoMaterial"
        Me.mnuRetornoMaterial.Name = "mnuRetornoMaterial"
        Me.mnuRetornoMaterial.Text = "Retornos de Material"
        '
        'mnuPrefacturacion
        '
        Me.mnuPrefacturacion.Icon = CType(resources.GetObject("mnuPrefacturacion.Icon"), System.Drawing.Icon)
        Me.mnuPrefacturacion.Key = "mnuPrefacturacion"
        Me.mnuPrefacturacion.Name = "mnuPrefacturacion"
        Me.mnuPrefacturacion.Text = "Prefacturación"
        '
        'mnuFacturacion
        '
        Me.mnuFacturacion.Icon = CType(resources.GetObject("mnuFacturacion.Icon"), System.Drawing.Icon)
        Me.mnuFacturacion.Key = "mnuFacturacion"
        Me.mnuFacturacion.Name = "mnuFacturacion"
        Me.mnuFacturacion.Text = "Facturación"
        '
        'mnuADDFianza
        '
        Me.mnuADDFianza.Icon = CType(resources.GetObject("mnuADDFianza.Icon"), System.Drawing.Icon)
        Me.mnuADDFianza.Key = "mnuADDFianza"
        Me.mnuADDFianza.Name = "mnuADDFianza"
        Me.mnuADDFianza.Text = "Introducir Fianza"
        '
        'mnuDeleteFianza
        '
        Me.mnuDeleteFianza.Icon = CType(resources.GetObject("mnuDeleteFianza.Icon"), System.Drawing.Icon)
        Me.mnuDeleteFianza.Key = "mnuDeleteFianza"
        Me.mnuDeleteFianza.Name = "mnuDeleteFianza"
        Me.mnuDeleteFianza.Text = "Borrar Fianza"
        '
        'mnuGeneraHitos
        '
        Me.mnuGeneraHitos.Icon = CType(resources.GetObject("mnuGeneraHitos.Icon"), System.Drawing.Icon)
        Me.mnuGeneraHitos.Key = "mnuGeneraHitos"
        Me.mnuGeneraHitos.Name = "mnuGeneraHitos"
        Me.mnuGeneraHitos.Text = "Generar Hitos de Facturación"
        '
        'mnuIncidencias
        '
        Me.mnuIncidencias.Icon = CType(resources.GetObject("mnuIncidencias.Icon"), System.Drawing.Icon)
        Me.mnuIncidencias.Key = "mnuIncidencias"
        Me.mnuIncidencias.Name = "mnuIncidencias"
        Me.mnuIncidencias.Text = "Incidencias en la Facturación"
        '
        'mnuSeguimiento
        '
        Me.mnuSeguimiento.Icon = CType(resources.GetObject("mnuSeguimiento.Icon"), System.Drawing.Icon)
        Me.mnuSeguimiento.Key = "mnuSeguimiento"
        Me.mnuSeguimiento.Name = "mnuSeguimiento"
        Me.mnuSeguimiento.Text = "Seguimiento Alquiler"
        '
        'mnuAlbaran
        '
        Me.mnuAlbaran.Icon = CType(resources.GetObject("mnuAlbaran.Icon"), System.Drawing.Icon)
        Me.mnuAlbaran.Key = "mnuAlbaran"
        Me.mnuAlbaran.Name = "mnuAlbaran"
        Me.mnuAlbaran.Text = "Generar Albaranes"
        '
        'mnuSalidaRetorno
        '
        Me.mnuSalidaRetorno.Icon = CType(resources.GetObject("mnuSalidaRetorno.Icon"), System.Drawing.Icon)
        Me.mnuSalidaRetorno.Key = "mnuSalidaRetorno"
        Me.mnuSalidaRetorno.Name = "mnuSalidaRetorno"
        Me.mnuSalidaRetorno.Text = "Generar Albarán de Salida y Retorno"
        '
        'mnuAlbaran1
        '
        Me.mnuAlbaran1.Key = "mnuAlbaran"
        Me.mnuAlbaran1.Name = "mnuAlbaran1"
        '
        'MntoAlquiler
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 634)
        Me.CreateTransaction = True
        Me.EntityName = "ObraCabecera"
        Me.Name = "MntoAlquiler"
        Me.NavigationFields = "NObra"
        Me.NoEditableControls = New Solmicro.Expertis.Engine.UI.NoEditableControls(New System.Windows.Forms.Control() {Me.txtNObra})
        Me.ViewName = "frmMntoAlquiler"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAlquiler.ResumeLayout(False)
        Me.TabPageCabeceraAlquiler.ResumeLayout(False)
        Me.pnlBottomCabeceraAlquiler.ResumeLayout(False)
        Me.pnlTexto.ResumeLayout(False)
        Me.pnlTexto.PerformLayout()
        Me.pnlTopTexto.ResumeLayout(False)
        Me.pnlTopTexto.PerformLayout()
        Me.pnlPortes.ResumeLayout(False)
        Me.FraPortes.ResumeLayout(False)
        Me.FraPortes.PerformLayout()
        Me.pnlPortesBottom.ResumeLayout(False)
        Me.pnlPortesBottom.PerformLayout()
        Me.pnlPortesTop.ResumeLayout(False)
        Me.pnlPortesTop.PerformLayout()
        Me.pnlImporteFacturado.ResumeLayout(False)
        Me.pnlImporteFacturado.PerformLayout()
        Me.FraCondEconom.ResumeLayout(False)
        Me.FraCondEconom.PerformLayout()
        Me.FraBanco.ResumeLayout(False)
        Me.FraBanco.PerformLayout()
        Me.pnlTopCabeceraAlquiler.ResumeLayout(False)
        Me.pnlTopCabeceraAlquiler.PerformLayout()
        CType(Me.cbxIDCentroGestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraClientes.ResumeLayout(False)
        Me.FraClientes.PerformLayout()
        Me.FraFechas.ResumeLayout(False)
        Me.FraFechas.PerformLayout()
        Me.TabPageCondiciones.ResumeLayout(False)
        Me.pnlSeguros.ResumeLayout(False)
        CType(Me.GridSegurosExcesoContadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnLabellSeguros.ResumeLayout(False)
        Me.pnLabellSeguros.PerformLayout()
        Me.pnlExcesoContadores.ResumeLayout(False)
        CType(Me.GridSeguros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnllblSeguros.ResumeLayout(False)
        Me.pnllblSeguros.PerformLayout()
        CType(Me.cbxTipoSeguroImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCondicionesArticuloTarifasDtos.ResumeLayout(False)
        Me.pnlArticulos.ResumeLayout(False)
        CType(Me.GridSegurosArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLabelArticulos.ResumeLayout(False)
        Me.pnlLabelArticulos.PerformLayout()
        Me.pnlTarifasDtos.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridSegurosTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLabelTarifas.ResumeLayout(False)
        Me.pnlLabelTarifas.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GridSegurosDtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLabelDtos.ResumeLayout(False)
        Me.pnlLabelDtos.PerformLayout()
        Me.TabPageOrdenes.ResumeLayout(False)
        CType(Me.TabTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTrabajos.ResumeLayout(False)
        Me.TabPageDetalleOrdenes.ResumeLayout(False)
        Me.pnlFichaTrabajo.ResumeLayout(False)
        Me.pnlFichaTrabajoFill.ResumeLayout(False)
        Me.pnlFichaTrabajoFill.PerformLayout()
        Me.pnlFichaTrabajoTop.ResumeLayout(False)
        Me.pnlFichaTrabajoTop.PerformLayout()
        Me.FraFianzas.ResumeLayout(False)
        Me.FraFianzas.PerformLayout()
        Me.FraDatosCliente.ResumeLayout(False)
        Me.FraDatosCliente.PerformLayout()
        Me.FraCRM.ResumeLayout(False)
        Me.FraCRM.PerformLayout()
        Me.FraFacturacion.ResumeLayout(False)
        Me.FraFacturacion.PerformLayout()
        CType(Me.cbxTipoFactAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTipoFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCentroGestionTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraFechasTrabajo.ResumeLayout(False)
        Me.FraFechasTrabajo.PerformLayout()
        CType(Me.cbxEstadoTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDUDMedida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGridTrabajo.ResumeLayout(False)
        CType(Me.GridTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConfigVerTrabajos.ResumeLayout(False)
        Me.pnlConfigVerTrabajos.PerformLayout()
        Me.pnlVerTrabajosGrid.ResumeLayout(False)
        Me.pnlVerTrabajosGrid.PerformLayout()
        Me.pnlCliente.ResumeLayout(False)
        Me.pnlCliente.PerformLayout()
        Me.TabPageArticulos.ResumeLayout(False)
        CType(Me.GridMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConfigVerArticulos.ResumeLayout(False)
        Me.pnlConfigVerArticulos.PerformLayout()
        Me.pnlVerArticulos.ResumeLayout(False)
        Me.pnlVerArticulos.PerformLayout()
        Me.FraPortesArticulos.ResumeLayout(False)
        Me.pnlFillPortesArticulos.ResumeLayout(False)
        Me.pnlFillPortesArticulos.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.pnlLeftPortesArticulos.ResumeLayout(False)
        Me.pnlLeftPortesArticulos.PerformLayout()
        Me.TabPageIncidencias.ResumeLayout(False)
        CType(Me.GridIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFiltrarPorMaterial.ResumeLayout(False)
        Me.pnlFiltrarPorMaterial.PerformLayout()
        Me.pnlConfigVerIncidencias.ResumeLayout(False)
        Me.pnlConfigVerIncidencias.PerformLayout()
        Me.pnlVerIncidencias.ResumeLayout(False)
        Me.pnlVerIncidencias.PerformLayout()
        Me.TabPageHitos.ResumeLayout(False)
        CType(Me.GridVencimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalesHitos.ResumeLayout(False)
        Me.pnlTotalesHitos.PerformLayout()
        Me.pnlConfigVerHitos.ResumeLayout(False)
        Me.pnlConfigVerHitos.PerformLayout()
        Me.pnlVerHitos.ResumeLayout(False)
        Me.pnlVerHitos.PerformLayout()
        Me.TabPagePersonal.ResumeLayout(False)
        CType(Me.GridOperariosOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConfigVerOperarios.ResumeLayout(False)
        Me.pnlConfigVerOperarios.PerformLayout()
        Me.pnlVerOperarios.ResumeLayout(False)
        Me.pnlVerOperarios.PerformLayout()
        Me.pnlTrabajos.ResumeLayout(False)
        Me.pnlFianzaObligatoria.ResumeLayout(False)
        Me.pnlFianzaObligatoria.PerformLayout()
        Me.FraArbol.ResumeLayout(False)
        Me.FraArbol.PerformLayout()
        CType(Me.cbxEstadoDistintoDE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraCriterios.ResumeLayout(False)
        Me.TabPageRepresentantes.ResumeLayout(False)
        CType(Me.GridRepresentantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageActividades.ResumeLayout(False)
        CType(Me.GridActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageRecursos.ResumeLayout(False)
        CType(Me.GridRecursos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Nombres Acciones Toolbar "
    Private cnDIRECCIONENVIOFACTURA As String = ExpertisApp.Traslate("Dirección Envío-Factura")
    Private cnPERSONASCONTACTO As String = ExpertisApp.Traslate("Personas de Contacto")
    Private cnRIESGOCLIENTE As String = ExpertisApp.Traslate("Riesgo del Cliente")
    Private cnABRIRCLIENTE As String = ExpertisApp.Traslate("Abrir Cliente")
    Private cnSEGUIMIENTO As String = ExpertisApp.Traslate("Seguimiento Alquiler")
    Private cnINCIDENCIASFACTURACION As String = ExpertisApp.Traslate("Incidencias en la Facturación")
    Private cnAVISOSRETORNO As String = ExpertisApp.Traslate("Avisos de Retorno")
    Private cnRETORNOSMATERIAL As String = ExpertisApp.Traslate("Retornos de Material")
    Private cnPREFACTURACION As String = ExpertisApp.Traslate("Prefacturación")
    Private cnFACTURACION As String = ExpertisApp.Traslate("Facturación")
    Private cnCAMBIARCLIENTE As String = ExpertisApp.Traslate("Cambiar Cliente del Alquier")

#End Region

    Public Enum enumTipoAlbaran
        Albaran = 0
        AlbaranSalidaRetorno = 1
    End Enum

    Private objTransferencias As New TransferenciasAlmacenCollection
    Private mIDAlmacenOld As String

    Private dtTrabajos, mdtTotales, mTransferencias As DataTable
    Private drTrabajos As DataRow
    Private ndTrabajos As New ProviderNeededData

    Private mstrEjercicioActual, mIDAlmacen, mstrIdArticuloFactura, mstrAlbaranDeposito As String
    Private mblnCentroGestion, mblnCentroGestionTrabajo, blnPintarTrabajos, blnChecked As Boolean
    Private mbTransAutoAlquiler, mblnFactor, blnVerTrabajo As Boolean
    Private mdblFactor As Double
    Private mintIdLineaMaterial, mintTipoAlmAlq, intTrabajoActual As Integer
    Private blnRefreshArbol, blnRecordStateChanged As Boolean
    Private mMonedaA As MonedaInfo
    Private mMonedaB As MonedaInfo

    Private WithEvents mNSerie As NSerieSeleccion
    Private WithEvents advEmpresaActividad As AdvancedSearch
    Private WithEvents advClienteDireccion As AdvancedSearch

#Region " Binding "

    Private mDataSource As Object

    Private Sub GetDatosTrabajo(ByVal row As DataRow)
        ndTrabajos.Row = row
    End Sub

    Private MakeBinding As Boolean
    Private Sub BindingDetalleTrabajo()
        If Not MakeBinding Then
            Me.AddBinding(Me.txtCodTrabajo, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtNivelTrabajo, "Text", "Nivel")
            Me.AddBinding(Me.cbxFechaOrdenTrabajo, "BindableValue", "FechaOrden")
            Me.AddBinding(Me.cbxFechaInicioTrabajo, "BindableValue", "FechaInicio")
            Me.AddBinding(Me.cbxFechaPrevEntregaTrabajo, "BindableValue", "FechaPrevistaEntrega")
            Me.AddBinding(Me.cbxFechaFinTrabajo, "BindableValue", "FechaFin")
            Me.AddBinding(Me.txtPedidoCliente, "Text", "PedidoCliente")
            Me.AddBinding(Me.AdvIDArticulo, "Text", "IDArticulo")
            Me.AddBinding(Me.lblDescArticulo, "Text", "DescArticulo")
            Me.AddBinding(Me.txtQPrev, "Value", "QPrev")
            Me.AddBinding(Me.cbxIDUDMedida, "Text", "IDUdMedida")
            Me.AddBinding(Me.cbxEstadoTrabajo, "Value", "Estado")
            Me.AddBinding(Me.cbxTipoFacturacion, "Value", "TipoFacturacion")
            Me.AddBinding(Me.chkTrabajoFacturable, "BindableValue", "Facturable")
            Me.AddBinding(Me.cbxTipoFactAlquiler, "Value", "TipoFactAlquiler")
            Me.AddBinding(Me.txtImporte, "Value", "ImpPrevTrabajoVentaA")
            Me.AddBinding(Me.AdvPersonaContacto, "Value", "IDPersona")
            Me.AddBinding(Me.AdvPersonaContacto, "Text", "Nombre")
            Me.AddBinding(Me.chkTraspasada, "BindableValue", "Traspasada")
            Me.AddBinding(Me.cbxCentroGestionTrabajo, "Value", "IDCentroGestion")
            Me.AddBinding(Me.txtTextoContacto, "Text", "TextoContacto")

            Me.AddBinding(Me.txtTextoActividad, "Text", "TextoActividad")
            Me.AddBinding(Me.cbxFechaActividad, "BindableValue", "FechaActividad")
            Me.AddBinding(Me.txtHoraActividad, "Text", "HoraActividad")

            Me.AddBinding(Me.txtDireccionTrabajo, "Text", "Direccion")
            Me.AddBinding(Me.txtCPClienteTrabajo, "Text", "CodPostal")
            Me.AddBinding(Me.txtPoblacionClienteTrabajo, "Text", "Poblacion")
            Me.AddBinding(Me.txtProvinciaTrabajoCliente, "Text", "Provincia")

            Me.AddBinding(Me.AdvOperarioTrabajo, "Text", "IDOperarioOS")
            Me.AddBinding(Me.chkFianzaContabilizada, "BindableValue", "FianzaContabilizada")
            Me.AddBinding(Me.chkFianzaCompensada, "BindableValue", "FianzaCompensada")
            Me.AddBinding(Me.cbxFechaContabilizacion, "BindableValue", "FechaContabilizacion")
            Me.AddBinding(Me.txtFianza, "Value", "Fianza")

            Me.AddBinding(Me.txtTextoTrabajo, "Text", "Texto")
            Me.AddBinding(Me.txtTextoExternoTrabajo, "Text", "TextoPublico")
            '''''''''''''
            Me.AddBinding(Me.txtTrabajoGrid, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoGrid, "Text", "PedidoCliente")
            Me.AddBinding(Me.txtTrabajoMateriales, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoMateriales, "Text", "PedidoCliente")
            Me.AddBinding(Me.txtTrabajoIncidencias, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoIncidencias, "Text", "PedidoCliente")
            Me.AddBinding(Me.txtTrabajoHitos, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoHitos, "Text", "PedidoCliente")
            Me.AddBinding(Me.txtTrabajoOperarios, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoOperarios, "Text", "PedidoCliente")

            MakeBinding = True
        End If
    End Sub

    Private Sub AddBinding(ByVal control As Control, ByVal propertyName As String, ByVal dataMember As String)
        Dim B As Binding
        If (dataMember = "codtrabajo") Or (dataMember = "PedidoCliente") Then
            control.Enabled = False
        Else
            control.Enabled = True
        End If
        B = control.DataBindings.Add(propertyName, Me.ndTrabajos, dataMember)

    End Sub

#End Region

#Region " Load "

    Private Sub MntoAlquiler_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Me.RecordsState = RecordsState.Saved Then
            RefreshAlquiler()
        End If
    End Sub

    Private Sub RefreshAlquiler(Optional ByVal intObra As Integer = -1)
        If intObra = -1 Then intObra = Me.CurrentRow("IDObra")
        Dim oFilter As New Filter
        oFilter.Add(New NumberFilterItem("IDObra", intObra))
        Me.GotoRecord(DataProviderActions.GoFirst, oFilter)
    End Sub

    Private Sub MntoAlquiler_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.DesignMode = False Then
            LoadERPData()
            LoadNedeedData()
            LoadEnums()
            LoadMonedasInternas()
            LoadToolBarActions()
            LoadGridActions()
            LoadAdvancedSearchSettings()
            LoadFormParams()
            Configure()
        End If
    End Sub

    Private Sub LoadERPData()
        Dim p As New Parametro
        mstrIdArticuloFactura = p.ArticuloSeguroAlquiler
        mbTransAutoAlquiler = p.TransAutoAlquiler
        mstrAlbaranDeposito = p.TipoAlbaranDeDeposito
    End Sub

    Private Sub LoadNedeedData()
        'Trabajos
        ndTrabajos.Name = "Trabajos"
        ndTrabajos.EntityName = "ObraTrabajo"
        GridTrabajos.EntityName = ndTrabajos.EntityName
        Dim s(0) As String
        s(0) = "IDObra"
        ndTrabajos.PrimaryDataFields = s
        ndTrabajos.SecondaryDataFields = s
        ndTrabajos.RelationMode = RelationMode.ChildMode
        ndTrabajos.ViewName = "VFrmAlquilerTrabajos"
        GridTrabajos.ViewName = ndTrabajos.ViewName
        ndTrabajos.UpdateOrder = -1
        Me.AddDataItem(ndTrabajos)
    End Sub

    Private Sub LoadMonedasInternas()
        mMonedaA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)
    End Sub

    Private Sub LoadToolBarActions()
        Me.FormActions.Add(cnDIRECCIONENVIOFACTURA, AddressOf AccionCrearDireccionEnvio, ExpertisApp.GetIcon("find_again.ico"))
        Me.FormActions.Add(cnPERSONASCONTACTO, AddressOf AccionPersonasContacto, ExpertisApp.GetIcon("user1_add.ico"))
        Me.AddSeparator()
        Me.FormActions.Add(cnABRIRCLIENTE, AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
        Me.FormActions.Add(cnRIESGOCLIENTE, AddressOf AccionCalcularRiesgo, ExpertisApp.GetIcon("scroll_warning.ico"))
        Me.FormActions.Add(cnCAMBIARCLIENTE, AddressOf AccionCambiarCliente, ExpertisApp.GetIcon("users_back.ico"))
        Me.AddSeparator()
        Me.FormActions.Add(cnAVISOSRETORNO, AddressOf AccionAbrirAvisosRetorno, ExpertisApp.GetIcon("chest_into.ico"))
        Me.FormActions.Add(cnRETORNOSMATERIAL, AddressOf AccionRetornosMaterial, ExpertisApp.GetIcon("nut_and_bolt.ico"))
        Me.FormActions.Add(cnPREFACTURACION, AddressOf AccionPreFacturacion, ExpertisApp.GetIcon("index.ico"))
        Me.FormActions.Add(cnFACTURACION, AddressOf AccionFacturacion, ExpertisApp.GetIcon("xFacturacionProyectos.ico"))
        Me.AddSeparator()
        Me.FormActions.Add(cnSEGUIMIENTO, AddressOf AccionSeguimientoAlquiler, ExpertisApp.GetIcon("xEstructuras1.ico"))
        Me.FormActions.Add(cnINCIDENCIASFACTURACION, AddressOf AccionAbrirIncidenciasAlquiler, ExpertisApp.GetIcon("gear_preferences.ico"))
        Me.AddSeparator()
        Me.FormActions.Add(cnCALENDARIO, AddressOf VerCalendarioAlquiler, ExpertisApp.GetIcon("calendar_preferences.ico"))
        'David Velasco 26/09/22 CARGA EXCEL- ALBARAN DE SALIDa
        Me.AddSeparator()
        Me.FormActions.Add("Generar Orden de Servicio desde Excel", AddressOf GenerarAlbaranExcel, ExpertisApp.GetIcon("book_green.ico"))
    End Sub

    Private Sub LoadGridActions()
        GridVencimientos.Actions.Add("Abrir Factura Venta", AddressOf AccionAbrirFacturaVenta, ExpertisApp.GetIcon("xFacturaVenta.ico"))

        GridMaterial.Actions.Add("Abrir Vencimientos Materiales", AddressOf CargarFormVencimientos, ExpertisApp.GetIcon("clock_run.ico"))
        GridMaterial.Actions.Add("Ver Disponibilidad", AddressOf AccionVerDisponibilidad, ExpertisApp.GetIcon("help_earth.ico"))
        GridMaterial.Actions.Add("Importar Estructura", AddressOf AccionImportarEstructura, ExpertisApp.GetIcon("xEstructuras1.ico"))
    End Sub

    Private Sub LoadEnums()
        'Cabecera
        cbxEstado.DataSource = New EnumData("enumocEstado")
        'Pestaña Condiciones
        cbxTipoSeguroImporte.DataSource = New EnumData("enumocSegurosTipoImporte")
        EnumData.PopulateValueList("enumTipoFacturacionAlquiler", GridSegurosArticulos.Columns("TipoFactAlquiler"))
        EnumData.PopulateValueList("otaTipoDtos", GridSegurosDtos.Columns("TipoDato"))
        EnumData.PopulateValueList("otaTipoSeguros", GridSeguros.Columns("TipoDato"))
        EnumData.PopulateValueList("otaTipoCalcSeg", GridSeguros.Columns("TipoCalculoSeguro"))
        EnumData.PopulateValueList("TipoExcesosContadores", GridSegurosExcesoContadores.Columns("TipoDato"))
        EnumData.PopulateValueList("otaTipoCalcSeg", GridSegurosExcesoContadores.Columns("TipoCalculoSeguro"))
        'Pestaña Ordenes
        cbxEstadoDistintoDE.DataSource = New EnumData("enumotEstado")
        cbxEstadoDistintoDE.Value = CInt(enumotEstado.otTerminado)
        'Ordenes
        '''''''''''''''''''''''
        cbxEstadoTrabajo.DataSource = New EnumData("enumotEstado")
        cbxTipoFacturacion.DataSource = New EnumData("enumotTipoFacturacion")
        cbxTipoFactAlquiler.DataSource = New EnumData("enumTipoFacturacionAlquiler")

        EnumData.PopulateValueList("enumotEstado", GridTrabajos.Columns("Estado"))
        EnumData.PopulateValueList("enumotTipoFacturacion", GridTrabajos.Columns("TipoFacturacion"))
        ''''''''''''''''''''''''
        'Pestaña Incidencias
        EnumData.PopulateValueList("enumiaAfectaFactura", GridIncidencias.Columns("AfectaFactura"))
        'Pestaña Representantes
        EnumData.PopulateValueList("enumOrepComision", GridRepresentantes.Columns("Tipo"))
        'Pestaña Materiales
        EnumData.PopulateValueList("enumomEstado", GridMaterial.Columns("Estado"))
        EnumData.PopulateValueList("enumomEstadoFactura", GridMaterial.Columns("EstadoFactura"))
        EnumData.PopulateValueList("enumomATipoFacturacionAlquiler", GridMaterial.Columns("TipoFacturacion"))
        EnumData.PopulateValueList("enumTipoFacturacionAlquiler", GridMaterial.Columns("TipoFactAlquiler"))
        'Pestaña Hitos
        EnumData.PopulateValueList("enumotfTipoFactura", GridVencimientos.Columns("TipoFactura"))
    End Sub

    Private Sub LoadAdvancedSearchSettings()
        advEmpresaActividad = New AdvancedSearch : advEmpresaActividad.EntityName = "EmpresaActividad" : advEmpresaActividad.ViewName = "tbEmpresaActividad"
        advClienteDireccion = New AdvancedSearch : advClienteDireccion.EntityName = "ClienteDireccion" : advClienteDireccion.ViewName = "tbClienteDireccion"
    End Sub

    Private Sub Configure()
        lblBloqueado.Text = ExpertisApp.Traslate(lblBloqueado.Text)
        lblBloqueado.ForeColor = Color.Red
        lblFianzaObligatoria.ForeColor = Color.Red
        lblTextoInfo.ForeColor = Color.Red
        lblAsterisco.ForeColor = Color.Red
        rbtPorOServicio.Checked = True
        rbtMaterialOServicio.Checked = True
        rbtIncidenciasOServicio.Checked = True
        rbtHitosOServicio.Checked = True
        rbtOperariosOServicio.Checked = True
        rbtVerFicha.Checked = True
        rbtMaximizarTree.Checked = True
        chkFiltrarPorMaterial.Checked = True
        mblnCentroGestionTrabajo = False
        mblnCentroGestion = False
        If blnVerTrabajo Then ControlesVerTrabajo()
    End Sub

    Private Sub ControlesVerTrabajo()
        TabAlquiler.TabPages("Ordenes").Selected = True
        rbtVerFicha.Checked = True
        rbtMaximizarTree.Checked = True
    End Sub

    Private Sub LoadFormParams()
        If Not IsNothing(Me.Params) Then
            Dim ht As Hashtable = Me.Params
            Dim IDObra As Integer
            If ht.ContainsKey("IDObra") Then IDObra = ht("IDObra")
            If ht.ContainsKey("VerTrabajo") Then
                blnVerTrabajo = ht("VerTrabajo")
                intTrabajoActual = ht("IDTrabajo")
            ElseIf IDObra > 0 Then
                GotoRecord(DataProviderActions.GoFirst, New NumberFilterItem("IDObra", IDObra), Me.CurrentData)
            End If
        End If
    End Sub

#End Region

#Region " Acciones de Toolbar "
    Private Sub AccionCrearDireccionEnvio()
        If Length(AdvIDCliente.Text) > 0 Then
            Dim info As New frmAddDireccion.AddDireccionInfo
            info.strIDCliente = AdvIDCliente.Text
            info.strDescCliente = ulDescCliente.Text
            info.strCifCliente = txtCifCliente.Text
            info.TipoDireccion = enumcdTipoDireccion.cdDireccionEnvio
            info.TipoAlquiler = frmAddDireccion.enumTipoAlquiler.Alquiler
            info.intIDObra = Me.CurrentRow("IDObra")
            info.strNObra = txtNObra.Text

            Dim frm As New frmAddDireccion
            Dim intIDDireccion As Integer
            Dim strIDAlmacen As String = String.Empty
            frm.OpenAddDireccion(info, intIDDireccion, strIDAlmacen)

            If intIDDireccion > 0 Then
                Me.CurrentRow("IDDireccion") = intIDDireccion
                advIDAlmacen.Value = strIDAlmacen
                Me.RecordsState = RecordsState.Modified
            End If
        End If
    End Sub

    Private Sub AccionPersonasContacto()
        'If Length(Me.CurrentRow("IDCliente")) > 0 AndAlso Length(Me.CurrentRow("IDObra")) > 0 Then
        '    Dim frm As New CommonClasses.FrmPersonaContacto
        '    frm.AbrirPersonaContacto(CommonClasses.FrmPersonaContacto.TipoContacto.Obra, Me.CurrentRow("IDCliente"), Me.CurrentRow("IDObra"))
        'End If
        Dim frm As New frmPersonaContacto2
        frm.ShowDialog()

    End Sub

    Private Sub AccionCalcularRiesgo()
        If Nz(Me.CurrentRow("Riesgo"), False) Then
            Dim oRiesgoCliente As New Solmicro.Expertis.Application.ERP.CommonClasses.RiesgoCliente
            oRiesgoCliente.OpenForm(AdvIDCliente.Text)
        Else
            ExpertisApp.GenerateMessage("El Cliente ' " & AdvIDCliente.Text & " ' no tiene riesgo.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AccionAbrirCliente()
        If Length(AdvIDCliente.Text) > 0 Then
            Dim f As New Filter
            f.Add("IDCliente", FilterOperator.Equal, AdvIDCliente.Text, FilterType.String)
            ExpertisApp.OpenForm("MCLIENTE", f)
        End If
    End Sub

    Private Sub AccionSeguimientoAlquiler()
        Dim f As New Filter
        f.Add("IDObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
        ExpertisApp.OpenForm("SEGALQUI", f)
    End Sub

    Private Sub AccionAbrirIncidenciasAlquiler()
        Dim frm As New frmIncidenciasAlquiler
        frm.IDObra = Me.CurrentRow("IDObra")
        frm.NObra = Me.CurrentRow("NObra")
        frm.ShowDialog(Me)
        Me.Requery.InvokeOnClick()
    End Sub

    Private Sub AccionAbrirAvisosRetorno()
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        ExpertisApp.OpenForm("AVISRET", , HT)
    End Sub

    Private Sub AccionRetornosMaterial()
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        HT("NObra") = txtNObra.Text
        If ExpertisApp.IsFormOpen(ExpertisApp.FindProgram("RETFACTALQ").ProgramID) Then ExpertisApp.CloseForm(ExpertisApp.FindProgram("RETFACTALQ").ProgramID)
        ExpertisApp.OpenForm("RETFACTALQ", , HT)
    End Sub

    Private Sub AccionPreFacturacion()
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        HT("NObra") = txtNObra.Text
        ExpertisApp.OpenForm("CONSOB", , HT)
    End Sub

    Private Sub AccionFacturacion()
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        HT("NObra") = txtNObra.Text
        ExpertisApp.OpenForm("FACTALQUILER", , HT)
    End Sub

    Private Sub AccionCambiarCliente()
        Dim f As New Filter
        f.Add(New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")))
        f.Add(New BooleanFilterItem("Facturado", True))
        Dim drOTF() As DataRow = CType(GridVencimientos.DataSource, DataTable).Select(f.Compose(New AdoFilterComposer))
        If drOTF.Length > 0 Then
            ExpertisApp.GenerateMessage("No se puede cambiar el Cliente. Tiene hitos de Facturación facturados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim frmCambio As New frmCambioCliente
            frmCambio.mIDObra = Me.CurrentRow("IDObra")
            If frmCambio.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.Requery.InvokeOnClick()
            End If
        End If
    End Sub

    Private Sub VerCalendarioAlquiler()
        AbrirMntoCalendarioAlquiler(Me.CurrentRow("IDObra"))
    End Sub
    'David Velasco 26/09/22
    'NOTA: La fecha que importa a la hora de empezar a cobrar es la fecha que sale al generar albarán.
    Public Sub GenerarAlbaranExcel()
        '1. Generar la Orden de Servicio(con fecha especifica).
        Dim obra As New ObraDatos
        obra = compruebaExcel()
        If obra.ruta.ToString.Length = 0 Then
            MsgBox("Este Excel con este nombre y ubicacion ya ha sido insertado anteriormente.")
        Else
            'COMPROBACION DE QUE HAY STOCK EN EL 011. Sino te avisa
            Dim dtStock As New DataTable
            Dim f As New Filter

            For Each dr As DataRow In obra.dt.Rows
                f.Add("IDArticulo", FilterOperator.Equal, dr("IDArticulo").ToString)
                f.Add("IDAlmacen", FilterOperator.Equal, "011")
                dtStock = New BE.DataEngine().Filter("tbMaestroArticuloAlmacen", f)
                If dtStock.Rows(0)("StockFisico") >= dr("Cantidad") Then
                Else
                    ExpertisApp.GenerateMessage("El articulo " & dr("IDArticulo") & " no tiene stock suficiente para crear la orden.")
                    Exit Sub
                End If
                f.Clear()
                dtStock = Nothing
            Next
            'CREACION DE OS Y ARTICULOS DEL EXCEL
            NuevaOrdenHilti(0, obra)
            blnRefreshArbol = True
            Me.UpdateChanges()

            'PARTE DE INSERTAR

            Dim dtArti As New DataTable
            Dim filtro As New Filter

            Dim dtFami As New DataTable
            Dim filtroFami As New Filter

            'Obtengo el ultimo IDTrabajo
            Dim dtIDT As New DataTable
            Dim sql As String
            sql = "select Max(IDTrabajo) from tbObraTrabajo"
            Dim ac As New Business.ClasesTecozam.Acero
            dtIDT = ac.DevuelveTabla(sql)
            For Each dr As DataRow In obra.dt.Rows
                Dim cl As New ObraMaterial
                Dim dt As DataTable = cl.AddNewForm

                'Obtengo los datos del articulo por bbdd
                filtro.Add("IDArticulo", FilterOperator.Equal, dr("IDArticulo").ToString)
                dtArti = New BE.DataEngine().Filter("tbMaestroArticulo", filtro)

                dt.Rows(0)("IDTrabajo") = dtIDT.Rows(0)("Column1")
                dt.Rows(0)("IDObra") = Me.CurrentRow("IDObra")
                dt.Rows(0)("IDMaterial") = dr("IDArticulo")
                dt.Rows(0)("IDMaterialOrigen") = dr("IDArticulo")
                dt.Rows(0)("DescMaterial") = dtArti.Rows(0)("DescArticulo")
                dt.Rows(0)("QPrev") = dr("Cantidad")
                dt.Rows(0)("Qunidad") = dr("Cantidad")
                dt.Rows(0)("PrecioPrevMatA") = dtArti.Rows(0)("PrecioEstandarA")
                dt.Rows(0)("ImpPrevMatA") = dr("Cantidad") * dtArti.Rows(0)("PrecioEstandarA")
                dt.Rows(0)("FechaEntrega") = Date.Today
                dt.Rows(0)("Facturable") = 1
                dt.Rows(0)("Expedible") = 1
                '
                If (dtArti.Rows(0)("IDTipo") = "30" Or dtArti.Rows(0)("IDFamilia") = "2003" Or dtArti.Rows(0)("IDFamilia") = "2004" Or dtArti.Rows(0)("IDSubfamilia").ToString = "HIDRAULICA") Then
                    If (dtArti.Rows(0)("IDFamilia") <> "3031") Then
                        dt.Rows(0)("TipoFacturacion") = 3
                        dt.Rows(0)("TipoFactAlquiler") = 1
                        '.SetValue("TipoFactAlquiler", CInt(enumTipoFacturacionAlquiler.enumTFADiasNaturales))
                        '.SetValue("TipoFacturacion", CInt(enumomATipoFacturacionAlquiler.omAPorAlquiler))
                    Else
                        dt.Rows(0)("TipoFacturacion") = 2
                        dt.Rows(0)("TipoFactAlquiler") = 0
                    End If
                Else
                    dt.Rows(0)("TipoFacturacion") = 2
                    dt.Rows(0)("TipoFactAlquiler") = 0
                End If
                '
                dt.Rows(0)("Estado") = 0
                dt.Rows(0)("IDAlmacen") = "011"
                dt.Rows(0)("IDUdInterna") = dtArti.Rows(0)("IDUdInterna")
                dt.Rows(0)("IDUdVenta") = dtArti.Rows(0)("IDUdVenta")
                dt.Rows(0)("IDUdCompra") = dtArti.Rows(0)("IDUdCompra")

                'CCCompra y CCVenta
                Try
                    filtroFami.Add("IDTipo", FilterOperator.Equal, dtArti.Rows(0)("IDTipo"))
                    filtroFami.Add("IDFamilia", FilterOperator.Equal, dtArti.Rows(0)("IDFamilia"))
                    dtFami = New BE.DataEngine().Filter("tbMaestroArticulo", filtroFami)
                    dt.Rows(0)("CCCompra") = dtFami.Rows(0)("CCCompra")
                    dt.Rows(0)("CCVenta") = dtFami.Rows(0)("CCVenta")
                Catch ex As Exception
                End Try

                Try
                    cl.Update(dt)
                Catch ex As Exception
                End Try
                filtro.Clear()
            Next
            Me.UpdateChanges()
        End If



    End Sub
#End Region

#Region " Acciones Grid "

    Private Sub AccionAbrirFacturaVenta()
        If Length(GridVencimientos.Value("IDFactura")) = 0 Then
            ExpertisApp.GenerateMessage("No se puede abrir la factura. No tiene una factura asociada.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            AbrirMntoFacturasVenta(GridVencimientos.Value("IDFactura"))
        End If
    End Sub

    Private Sub AccionVerDisponibilidad()
        With GridMaterial
            If Length(.Value("IDMaterial")) > 0 AndAlso Length(.Value("IDAlmacen")) > 0 Then
                Dim f As New Filter
                f.Add("IDMaterial", FilterOperator.Equal, .Value("IDMaterial"), FilterType.String)
                f.Add("IDAlmacen", FilterOperator.Equal, .Value("IDAlmacen"), FilterType.String)
                Dim HtParam As New Hashtable
                HtParam.Add("IDArticulo", .GetValue("IDMaterial"))
                HtParam.Add("IDAlmacen", .GetValue("IDAlmacen"))
                ExpertisApp.OpenForm("DispAlq", f)
            End If
        End With
    End Sub

    Private Sub AccionImportarEstructura()
        With GridMaterial
            If Length(.Value("IDLineaMaterialPadre")) = 0 Then
                If Length(.Value("IDMaterial")) > 0 AndAlso Length(.Value("IDAlmacen")) > 0 Then
                    Dim frm As New frmImpEstructura
                    frm.IDObra = .Value("IDObra")
                    frm.IDTrabajo = .Value("IDTrabajo")
                    frm.IDArticulo = .Value("IDMaterial")
                    frm.DescArticulo = .Value("DescMaterial")
                    frm.IDLineaMaterial = .Value("IDlineaMaterial")
                    If Length(.Value("TipoFacturacion")) > 0 Then frm.TipoFacturacion = .Value("TipoFacturacion")
                    frm.Expedible = .Value("Expedible")
                    frm.Facturable = .Value("Facturable")
                    frm.QPrevTrabajo = .Value("QPrevTrabajo")
                    frm.QUnidad = .Value("QUnidad")
                    frm.FechaInicioTrabajo = Nz(drTrabajos("FechaInicio"), cnMinDate)
                    frm.FacturacionAsociadaMaquina = .Value("FacturacionAsociadaMaq")

                    frm.ShowDialog(Me)
                    Me.Requery.InvokeOnClick()
                End If
            End If
        End With
    End Sub

#End Region

#Region " Navigated "

    Private Sub MntoAlquiler_Navigating(ByVal sender As Object, ByVal e As Engine.UI.NavigatingEventArgs) Handles Me.Navigating
        Select Case e.Action
            Case DataProviderActions.GoFirst
                blnPintarTrabajos = IIf(blnRecordStateChanged, blnRefreshArbol, True)
            Case DataProviderActions.GoRecord, DataProviderActions.Refresh, DataProviderActions.GoLast, DataProviderActions.GoNext, DataProviderActions.GoPrevious
                blnPintarTrabajos = True
            Case Else
                blnPintarTrabajos = False
        End Select
        blnRecordStateChanged = False
    End Sub

    Private Sub MntoAlquiler_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        If Not IsNothing(Me.CurrentRow) Then
            GetTrabajos()
            EjercicioPredeterminado()
            ArbolTrabajos()
            BloqueosNavegando()
            If Length(CurrentRow("IDCentroGestion")) > 0 Then
                mIDAlmacen = ExpertisApp.ExecuteTask(Of String, String)(AddressOf Almacen.GetAlmacenCentroGestion, CurrentRow("IDCentroGestion"))
            End If
            ActiveExecuteActions()
            TabAlquiler_Click(TabAlquiler, New System.EventArgs)
        End If
    End Sub

    Private Sub GetTrabajos()
        dtTrabajos = ndTrabajos.Data
        If ndTrabajos.Data.Rows.Count = 0 Then
            Me.pnlFichaTrabajo.Enabled = False
            drTrabajos = Nothing
        Else
            Me.pnlFichaTrabajo.Enabled = True
            If blnVerTrabajo AndAlso intTrabajoActual > 0 Then
                drTrabajos = GetdrTrabajos(intTrabajoActual)
            Else
                Dim dv As New DataView(ndTrabajos.Data)
                dv.Sort = "Secuencia"
                If Length(cbxEstadoDistintoDE.Value) > 0 Then
                    dv.RowFilter = "Estado<>" & cbxEstadoDistintoDE.Value
                End If
                If dv.Count > 0 Then
                    drTrabajos = dv(0).Row
                Else
                    Me.pnlFichaTrabajo.Enabled = False
                    drTrabajos = Nothing
                End If
            End If
        End If
        BindingDetalleTrabajo()
    End Sub

    Private Function GetdrTrabajos(ByVal IDTrabajo As Integer) As DataRow
        Dim dv As DataView = dtTrabajos.DefaultView
        dv.RowFilter = "IDTrabajo=" & IDTrabajo
        If dv.Count > 0 Then
            Return dv(0).Row
        Else
            Return Nothing
        End If
    End Function

    Private Sub EjercicioPredeterminado()
        mstrEjercicioActual = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, Today)
    End Sub

    Private Sub BloqueosNavegando()
        BloquearInformacion(Me.MainPanel, cbxEstado.Value = enumocEstado.ocTerminado, cbxEstado, txtDireccion, ntbDtoComercial, txtCodPostal, txtPoblacion, _
                            txtProvincia, txtCifCliente, txtImpQFactA, rbtMaximizarTree, rbtMinimizarTree, cbxEstadoDistintoDE, advIDAlmacen, _
                            txtOServicioFind, rbtMaterialAlquiler, rbtMaterialOServicio, rbtIncidenciasAlquiler, rbtIncidenciasOServicio, rbtHitosAlquiler, _
                            rbtHitosOServicio, rbtOperariosAlquiler, rbtOperariosOServicio, txtCodTrabajo, txtNivelTrabajo, cmbVerPedidoCliente, cmbPrint, _
                            txtImporte, cmbSearchActividad, txtTipoActividad, txtDescSituacion, cbxFechaActividad, txtHoraActividad, txtTextoActividad, _
                            chkFianzaContabilizada, chkFianzaCompensada, cbxFechaContabilizacion, txtFianza, cmbSearchIDDireccion, txtDireccionTrabajo, _
                            txtDtoClienteTrabajo, txtCPClienteTrabajo, txtPoblacionClienteTrabajo, txtProvinciaTrabajoCliente, chkPortesEspSalidasBloq, _
                            chkPortesEspRetornosBloq, txtCondicionesEspPortesBloq, GridActividades, txtSucursal, txtDC, txtNCuenta, txtNObra, txtTrabajoMateriales, _
                            txtDescTrabajoMateriales, txtTrabajoHitos, txtDescTrabajoHitos, txtTrabajoIncidencias, txtDescTrabajoIncidencias, txtTrabajoOperarios, _
                            txtDescTrabajoOperarios, txtTotalVtoA, txtTotalA)

        lblBloqueado.Visible = Nz(Me.CurrentRow("Bloqueado"), False)
        pnlFianzaObligatoria.Visible = Nz(Me.CurrentRow("FianzaObligatoria"), False)
        txtOServicioFind.Text = String.Empty
        cbxEstadoDistintoDE.Value = enumotEstado.otTerminado
        txtNivelTrabajo.Enabled = False
    End Sub

    Private Sub ActiveExecuteActions()
        Dim blnEnabled As InheritableBoolean = InheritableBoolean.True
        If Me.CurrentRow("Estado") = enumocEstado.ocTerminado Then
            blnEnabled = InheritableBoolean.False
        End If

        Me.ExecuteActions.Commands(cnDIRECCIONENVIOFACTURA).Enabled = blnEnabled
        Me.ExecuteActions.Commands(cnPERSONASCONTACTO).Enabled = blnEnabled
        Me.ExecuteActions.Commands(cnRIESGOCLIENTE).Enabled = blnEnabled
        Me.ExecuteActions.Commands(cnINCIDENCIASFACTURACION).Enabled = blnEnabled
        Me.ExecuteActions.Commands(cnCAMBIARCLIENTE).Enabled = blnEnabled
    End Sub

#End Region

    Private Sub MntoAlquiler_RecordStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.RecordStateChanged
        blnRecordStateChanged = True
    End Sub

    Private Sub MntoAlquiler_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles MyBase.SetPredefinedFilter
        e.Filter.Add(New NumberFilterItem("TipoMnto", enumTipoObra.tpalquiler))
    End Sub

    Private Sub MntoAlquiler_RecordAdding(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordAdding
        GridTrabajos.EntityName = ""
        lblBloqueado.Visible = False
        pnlFianzaObligatoria.Visible = False
    End Sub

    Private Sub MntoAlquiler_RecordDeleting(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordDeleting
        GridTrabajos.EntityName = ""
        blnRecordStateChanged = True
        blnRefreshArbol = True
    End Sub

    Private Sub MntoAlquiler_RecordUpdating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordUpdating
        GridTrabajos.EntityName = ""
        'David Velasc 01/12
        'e.Cancel = ComprobarActualizacion()
        'David Velasco 01/12
        If Not e.Cancel Then
            'C.G. Trabajo modificado
            If mblnCentroGestionTrabajo Then
                If ExpertisApp.GenerateMessage("Este cambio actualizará el Centro de Gestión de las Ordenes y Albaranes abiertos del Alquiler.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim data As New ObraTrabajo.dataModificarCentroGestionAlbaran(CurrentRow("IDObra"), cbxCentroGestionTrabajo.Value, drTrabajos("IdTrabajo"))
                    ExpertisApp.ExecuteTask(Of ObraTrabajo.dataModificarCentroGestionAlbaran)(AddressOf ObraTrabajo.ModificarCentroGestionAlbaranes, data)
                End If
            End If
            mblnCentroGestionTrabajo = False
            'C.G. Obra modificado
            If mblnCentroGestion Then
                If ExpertisApp.GenerateMessage("Este cambio actualizará el Centro de Gestión de los Albaranes abiertos de la Orden de Servicio. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim data As New ObraTrabajo.dataModificarCentroGestionAlbaran(CurrentRow("IDObra"), cbxCentroGestionTrabajo.Value)
                    ExpertisApp.ExecuteTask(Of ObraTrabajo.dataModificarCentroGestionAlbaran)(AddressOf ObraTrabajo.ModificarCentroGestionAlbaranes, data)
                End If
            End If
            mblnCentroGestion = False
        End If

        If Not IsNothing(mTransferencias) AndAlso mTransferencias.Rows.Count > 0 Then
            Dim blnTransNoRealizadas As Boolean
            TratamientoTransferencias(mTransferencias, e.Cancel, blnTransNoRealizadas)
            If Not e.Cancel AndAlso blnTransNoRealizadas Then
                Dim blnCambiosAlmacenCancelados As Boolean
                For Each drTransferencia As DataRow In mTransferencias.Rows
                    If drTransferencia("RealizarTransferencia") AndAlso Not drTransferencia("TransferenciaRealizada") Then
                        Dim f As New Filter
                        If Length(drTransferencia("IDLineaMaterial")) > 0 AndAlso drTransferencia("IDLineaMaterial") <> 0 Then f.Add(New NumberFilterItem("IDLineaMaterial", drTransferencia("IDLineaMaterial")))
                        If Length(drTransferencia("IDArticulo")) > 0 Then f.Add(New StringFilterItem("IDMaterial", drTransferencia("IDArticulo")))
                        If Length(drTransferencia("NSerie")) > 0 Then f.Add(New StringFilterItem("Lote", drTransferencia("NSerie")))

                        CType(Me.GridMaterial.DataSource, DataView).RowFilter = f.Compose(New AdoFilterComposer)
                        For Each drv As DataRowView In CType(Me.GridMaterial.DataSource, DataView)
                            blnCambiosAlmacenCancelados = True
                            GridMaterial.GetRow(drv.Row).BeginEdit()
                            GridMaterial.GetRow(drv.Row).Cells("IDAlmacen").Value = drTransferencia("IDAlmacenOrigen")
                            GridMaterial.GetRow(drv.Row).EndEdit()
                        Next
                        CType(Me.GridMaterial.DataSource, DataView).RowFilter = Nothing
                    End If
                Next drTransferencia
                If blnCambiosAlmacenCancelados Then
                    ExpertisApp.GenerateMessage("Algunas transferencias de almacén han sido canceladas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                mTransferencias.Rows.Clear()
            End If
        End If
    End Sub

    Private Function ComprobarActualizacion() As Boolean
        Dim blnCancel As Boolean
        If Length(AdvIDCliente.Text) > 0 Then
            If Length(Me.CurrentRow("IDDireccion")) = 0 Then
                If ExpertisApp.GenerateMessage("La Dirección de Envío es Obligatoria. ¿Desea seleccionarla o dar de alta una nueva?.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                    AccionCrearDireccionEnvio()
                    If Length(Me.CurrentRow("IDDireccion")) = 0 Then blnCancel = True
                Else
                    blnCancel = True
                End If
            End If
            'If Not blnCancel Then
            '    pnlFianzaObligatoria.Visible = Me.CurrentRow("FianzaObligatoria")
            'End If
        End If

        Return blnCancel
    End Function

    Private Sub Added(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordAdded
        GridTrabajos.EntityName = ndTrabajos.EntityName
        TabAlquiler_Click(TabAlquiler, New System.EventArgs)
        blnRefreshArbol = False
    End Sub

    Private Sub UpdatedDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordUpdated, MyBase.RecordDeleted
        GridTrabajos.EntityName = ndTrabajos.EntityName
        RefreshAlquiler()
        TabAlquiler_Click(TabAlquiler, New System.EventArgs)
        blnRefreshArbol = False
    End Sub

    Private Sub TabAlquiler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabAlquiler.Click
        If Me.RecordsState <> RecordsState.Initialize Then
            Select Case TabAlquiler.SelectedTab.Key
                Case "Cabecera"
                    If Length(txtNObra.Text) > 0 And cbxEstado.Value <> enumocEstado.ocTerminado Then
                        AdvIDCliente.Enabled = (Length(Me.CurrentRow("IDDireccion")) = 0)
                        AdvIDTipoObra.Enabled = (ndTrabajos.Data.Rows.Count = 0)
                    End If
                Case "Ordenes"
                    TabTrabajos_Click(TabTrabajos, New System.EventArgs)
            End Select
        End If
    End Sub

#Region " Cancelando Modificación "

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles Cancel.Click
        If e.Command.Key = "Cancel" Then
            GridTrabajos.EntityName = ndTrabajos.EntityName
            mblnCentroGestionTrabajo = False
            mblnCentroGestion = False

            If Not IsNothing(mTransferencias) AndAlso mTransferencias.Rows.Count > 0 Then
                mTransferencias.Rows.Clear()
            End If
        End If
    End Sub

#End Region

#Region " Pestaña Cabecera "

    Private Sub cbxFechaInicio_cbxFechaFin_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaInicio.LostFocus, cbxFechaFin.LostFocus
        If Me.RecordsState <> RecordsState.[New] Then
            If Length(advIDObraCalendario.Text) > 0 AndAlso Length(cbxFechaInicio.Value) > 0 AndAlso Length(cbxFechaFin.Value) > 0 Then
                Dim data As New CalendarioObra.dataActualizarCalendario(advIDObraCalendario.Value, Me.CurrentRow("IDObra"), cbxFechaInicio.Value, cbxFechaFin.Value)
                ExpertisApp.ExecuteTask(Of CalendarioObra.dataActualizarCalendario)(AddressOf CalendarioObra.ActualizarCalendario, data)
            End If
        End If
    End Sub

    Private Sub cbxEstado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxEstado.Validating
        BloqueosNavegando()
        ActiveExecuteActions()
    End Sub

    Private Sub chkPedidoClienteAbierto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPedidoClienteAbierto.CheckedChanged
        txtPedidoClienteAbierto.Visible = chkPedidoClienteAbierto.Checked
        If Not chkPedidoClienteAbierto.Checked Then
            txtPedidoClienteAbierto.Text = String.Empty
        End If
    End Sub

    Private Sub advIDAlmacen_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advIDAlmacen.SetPredefinedFilter
        e.Filter.Add(New BooleanFilterItem("Deposito", True))
    End Sub

    Private Sub AdvIDClienteBanco_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDClienteBanco.SetPredefinedFilter
        If Length(AdvIDCliente.Text) > 0 Then e.Filter.Add(New StringFilterItem("IDCliente", AdvIDCliente.Text))
    End Sub

    Private Sub cbxIDCentroGestion_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxIDCentroGestion.Validated
        mblnCentroGestion = False
        If Me.CurrentRow.RowState = DataRowState.Modified Then
            If Length(cbxIDCentroGestion.Value) > 0 Then
                mblnCentroGestion = True
            End If
        End If
    End Sub

    Private Sub cmbDocumentacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDocumentacion.Click
        Dim frm As New frmDocumentos
        frm.mIDObra = Me.CurrentRow("IdObra")
        frm.ShowDialog(Me)
    End Sub

    Private Sub advIDObraCalendario_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles advIDObraCalendario.Validating
        If Length(advIDObraCalendario.Value) > 0 Then
            If ExpertisApp.GenerateMessage("Se va actualizar el calendario de la Obra. ¿Desea Continuar?.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Dim data As New CalendarioObra.datosCopiaCalendarioObra(Me.CurrentRow("IDObra"), cbxFechaInicio.Value, advIDObraCalendario.Value)
                ExpertisApp.ExecuteTask(Of CalendarioObra.datosCopiaCalendarioObra)(AddressOf CalendarioObra.CopiaCalendarioObra, data)
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub chkFacturarDiasMinimos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFacturarDiasMinimos.CheckedChanged
        If Not chkFacturarDiasMinimos.Checked Then
            Dim f As New Filter
            f.Add("IDObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
            f.Add("NoFacturarDiasMinimos", FilterOperator.Equal, True, FilterType.Boolean)
            Dim oOM As New ObraMaterial
            Dim dttOm As DataTable = oOM.Filter(f)
            If Not IsNothing(dttOm) AndAlso dttOm.Rows.Count > 0 Then
                ExpertisApp.GenerateMessage("Este cambio no tendrá influencia sobre los artículos que tienen la marca de 'No Facturar Días Mínimos' activada.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub chkFacturarPlusPorContadores_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFacturarPlusPorContadores.CheckedChanged
        If Not chkFacturarPlusPorContadores.Checked Then
            Dim f As New Filter
            f.Add("IDObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
            f.Add("NoFacturarPlusContadores", FilterOperator.Equal, True, FilterType.Boolean)
            Dim oOM As New ObraMaterial
            Dim dttOm As DataTable = oOM.Filter(f)
            If Not IsNothing(dttOm) AndAlso dttOm.Rows.Count > 0 Then
                ExpertisApp.GenerateMessage("Este cambio no tendrá influencia sobre los artículos que tienen la marca de 'No Facturar Plus Contadores' activada.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

#End Region

#Region " Pestaña Condiciones "

#Region " Seguros Articulos "

    Private Sub GridSegurosArticulos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSegurosArticulos.GotFocus
        With GridSegurosArticulos
            .Columns("Tipo").DefaultValue = CInt(otaTipo.otaPrecioArticulo)
            .Columns("Dto1").DefaultValue = 0
            .Columns("Dto2").DefaultValue = 0
            .Columns("Dto3").DefaultValue = 0
            .Columns("UdValoracion").DefaultValue = 1
            .Columns("Orden").DefaultValue = 0
        End With
    End Sub

    Private Sub GridSegurosArticulos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSegurosArticulos.LostFocus
        If GridSegurosArticulos.AllowAddNew = Janus.Windows.UI.InheritableBoolean.True Then
            GridSegurosArticulos.Row = -1
        End If
    End Sub

    Private Sub GridSegurosArticulos_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridSegurosArticulos.EditingCell
        With GridSegurosArticulos
            If cbxEstado.Value = enumocEstado.ocTerminado Then
                e.Cancel = True
                If e.Column.Key = "IDArticulo" Then
                    .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "IDArticulo"
                        .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image
                    Case "TipoFactAlquiler"
                        e.Cancel = True
                    Case "Dto1"
                        e.Cancel = Nz(.Value("SinDtoEnAlquiler"), False)
                End Select
            End If
        End With
    End Sub

    Private Sub GridSegurosArticulos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridSegurosArticulos.FormattingRow
        With GridSegurosArticulos
            If e.Row.RowType = RowType.Record Then
                If e.Row.Cells("Especial").Value Then
                    e.Row.RowStyle = .FormatStyles("EspecialFormatStyle")
                End If
            End If
        End With
    End Sub

    Private Sub GridSegurosArticulos_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridSegurosArticulos.AddingRecord
        With GridSegurosArticulos
            Dim dv As New DataView(CType(.DataSource, DataTable).Copy)
            Dim f As New Filter
            f.Add(New StringFilterItem("IDArticulo", .Value("IDArticulo")))
            dv.RowFilter = f.Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("Ya hay dado de alta un precio para este artículo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

#End Region

#Region " Seguros Tarifas "

    Private Sub GridSegurosTarifas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSegurosTarifas.GotFocus
        With GridSegurosTarifas
            .Columns("Tipo").DefaultValue = CInt(otaTipo.otaTarifa)
        End With
    End Sub

    Private Sub GridSegurosTarifas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSegurosTarifas.LostFocus
        If GridSegurosTarifas.AllowAddNew = Janus.Windows.UI.InheritableBoolean.True Then
            GridSegurosTarifas.Row = -1
        End If
    End Sub

    Private Sub GridSegurosTarifas_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridSegurosTarifas.EditingCell
        With GridSegurosTarifas
            If cbxEstado.Value = enumocEstado.ocTerminado Then
                e.Cancel = True
                If e.Column.Key = "IDTarifa" Then
                    .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                End If
            ElseIf e.Column.Key = "IDTarifa" Then
                .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image
            End If
        End With
    End Sub

    Private Sub GridSegurosTarifas_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridSegurosTarifas.AddingRecord
        With GridSegurosTarifas
            If Length(.GetValue("IDTarifa")) > 0 Then
                Dim dv As New DataView(CType(.DataSource, DataTable).Copy)
                Dim f As New Filter
                f.Add(New StringFilterItem("IDTarifa", .GetValue("IDTarifa")))
                dv.RowFilter = f.Compose(New AdoFilterComposer)
                If dv.Count = 0 Then
                    Dim IntOrden As Integer = CalcularOrdenTarifa()
                    GridSegurosTarifas.SetValue("Orden", IntOrden)
                Else
                    ExpertisApp.GenerateMessage("Este Contrato de Alquiler ya tiene asociada esa Tarifa.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            Else
                ExpertisApp.GenerateMessage("El ID Tarifa es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
        End With
    End Sub

    Private Function CalcularOrdenTarifa() As Integer
        Dim IntTotal As Integer
        If Length(GridSegurosTarifas.GetValue("Orden")) > 0 Then
            IntTotal = GridSegurosTarifas.GetValue("Orden")
        Else : IntTotal = GridSegurosTarifas.RowCount + 1
        End If
        Dim BlnEncontrado As Boolean = False
        Dim dv As New DataView(CType(GridSegurosTarifas.DataSource, DataTable).Copy)
        Dim f As New Filter
        While Not BlnEncontrado
            f.Clear()
            f.Add(New StringFilterItem("Orden", IntTotal))
            dv.RowFilter = f.Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                IntTotal += 1
            Else : BlnEncontrado = True
            End If
        End While
        Return IntTotal
    End Function

#End Region

#Region " Seguros Dtos "

    Private Sub GridSegurosDtos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSegurosDtos.GotFocus
        With GridSegurosDtos
            .Columns("Tipo").DefaultValue = CInt(otaTipo.otaDescuentoPorFamilia)
            .Columns("Dto1").DefaultValue = 0
            .Columns("Dto2").DefaultValue = 0
            .Columns("Dto3").DefaultValue = 0
            .Columns("Orden").DefaultValue = 0
        End With
    End Sub

    Private Sub GridSegurosDtos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSegurosDtos.LostFocus
        If GridSegurosDtos.AllowAddNew = Janus.Windows.UI.InheritableBoolean.True Then
            GridSegurosDtos.Row = -1
        End If
    End Sub

    Private Sub GridSegurosDtos_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridSegurosDtos.AdvSearchSetPredefinedFilter
        With GridSegurosDtos
            Select Case e.Key
                Case "IDFamilia"
                    If Length(.Value("IDTipo")) > 0 Then e.Filter.Add("IdTipo", FilterOperator.Equal, .Value("IDTipo"), FilterType.String)
            End Select
        End With
    End Sub

    Private Sub GridSegurosDtos_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridSegurosDtos.EditingCell
        With GridSegurosDtos
            If cbxEstado.Value = enumocEstado.ocTerminado Then
                e.Cancel = True
                If e.Column.Key = "IDTipo" OrElse e.Column.Key = "IDFamilia" Then
                    .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "IDTipo", "IDFamilia"
                        .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image
                    Case "TipoDato"
                        e.Cancel = True
                End Select
            End If
        End With
    End Sub

    Private Sub GridSegurosDtosAddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridSegurosDtos.AddingRecord
        With GridSegurosDtos
            Dim dv As New DataView(CType(.DataSource, DataTable).Copy)
            Dim f As New Filter
            Select Case CType(Nz(.Value("TipoDato"), 0), otaTipoDtos)
                Case otaTipoDtos.otaDtoGeneral
                    f.Add(New IsNullFilterItem("IDTipo", True))
                    f.Add(New IsNullFilterItem("IDFamilia", True))
                Case otaTipoDtos.otaDtoPorTipo
                    f.Add(New StringFilterItem("IDTipo", .Value("IDTipo")))
                    f.Add(New IsNullFilterItem("IDFamilia", True))
                Case otaTipoDtos.otaDtoPorTipoFamilia
                    f.Add(New StringFilterItem("IDTipo", .Value("IDTipo")))
                    f.Add(New StringFilterItem("IDFamilia", .Value("IDFamilia")))
            End Select

            dv.RowFilter = f.Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("Ya se ha dado de alta este tipo de Descuento para este Alquiler.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Length(.Value("IDFamilia")) <> 0 And Length(.Value("IdTipo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Tipo es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

#End Region

#Region " Seguros ExcesoContadores "

    Private Sub GridSegurosExcesoContadores_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSegurosExcesoContadores.GotFocus
        With GridSegurosExcesoContadores
            .Columns("Tipo").DefaultValue = CInt(otaTipo.otaExcesoContadores)
            .Columns("Orden").DefaultValue = 0
            .Columns("PorcentajeSeguro").DefaultValue = 0
            .Columns("ImporteFijo").DefaultValue = 0
            .Columns("PrecioSeguroFactAlquiler").DefaultValue = 0
            .Columns("TipoCalculoSeguro").DefaultValue = CInt(otaTipoCalcSeg.Porcentaje)
        End With
    End Sub

    Private Sub GridSegurosExcesoContadores_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSegurosExcesoContadores.LostFocus
        If GridSegurosExcesoContadores.AllowAddNew = Janus.Windows.UI.InheritableBoolean.True Then
            GridSegurosExcesoContadores.Row = -1
        End If
    End Sub

    Private Sub GridSegurosExcesoContadores_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridSegurosExcesoContadores.AdvSearchSetPredefinedFilter
        With GridSegurosExcesoContadores
            Select Case e.Key
                Case "IDFamilia"
                    If Length(.Value("IDTipo")) > 0 Then e.Filter.Add("IdTipo", FilterOperator.Equal, .Value("IDTipo"), FilterType.String)
            End Select
        End With
    End Sub

    Private Sub GridSegurosExcesoContadores_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridSegurosExcesoContadores.EditingCell
        With GridSegurosExcesoContadores
            If cbxEstado.Value = enumocEstado.ocTerminado Then
                e.Cancel = True
                If e.Column.Key = "IDArticulo" OrElse e.Column.Key = "IDTipo" OrElse e.Column.Key = "IDFamilia" Then
                    .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "IDArticulo", "IDTipo", "IDFamilia"
                        .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image
                    Case "TipoDato", "TipoCalculoSeguro"
                        e.Cancel = True
                End Select
            End If
        End With
    End Sub

    Private Sub GridSegurosExcesoContadores_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridSegurosExcesoContadores.AddingRecord
        With GridSegurosExcesoContadores
            Dim dv As New DataView(CType(.DataSource, DataTable).Copy)
            Dim f As New Filter

            Select Case CType(Nz(.Value("TipoDato"), 0), otaTipoSeguros)
                Case otaTipoSeguros.otaSegArticulo
                    f.Add(New StringFilterItem("IDArticulo", .Value("IDArticulo")))
                    f.Add(New IsNullFilterItem("IDTipo", True))
                    f.Add(New IsNullFilterItem("IDFamilia", True))
                Case otaTipoSeguros.otaSegPorTipo
                    f.Add(New StringFilterItem("IDTipo", .Value("IDTipo")))
                    f.Add(New IsNullFilterItem("IDArticulo", True))
                    f.Add(New IsNullFilterItem("IDFamilia", True))
                Case otaTipoSeguros.otaSegPorTipoFamilia
                    f.Add(New StringFilterItem("IDTipo", .Value("IDTipo")))
                    f.Add(New StringFilterItem("IDFamilia", .Value("IDFamilia")))
                    f.Add(New IsNullFilterItem("IDArticulo", True))
                Case otaTipoSeguros.otaSegGeneral
                    f.Add(New IsNullFilterItem("IDArticulo", True))
                    f.Add(New IsNullFilterItem("IDTipo", True))
                    f.Add(New IsNullFilterItem("IDFamilia", True))
            End Select

            dv.RowFilter = f.Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("Esta línea de Seguros ya existe en las Condiciones de Alquiler.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Length(.Value("IDFamilia")) <> 0 And Length(.Value("IdTipo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Tipo es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

#End Region

#Region " Seguros "

    Private Sub GridSeguros_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSeguros.GotFocus
        With GridSeguros
            .Columns("Tipo").DefaultValue = CInt(otaTipo.otaPorcentajeSeguro)
            .Columns("Orden").DefaultValue = 0
            .Columns("IdArticuloFactura").DefaultValue = mstrIdArticuloFactura
            .Columns("PorcentajeSeguro").DefaultValue = 0
            .Columns("ImporteFijo").DefaultValue = 0
            .Columns("PrecioSeguroFactAlquiler").DefaultValue = 0
            .Columns("TipoCalculoSeguro").DefaultValue = CInt(otaTipoCalcSeg.Porcentaje)
        End With
    End Sub

    Private Sub GridSeguros_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSeguros.LostFocus
        If GridSeguros.AllowAddNew = Janus.Windows.UI.InheritableBoolean.True Then
            GridSeguros.Row = -1
        End If
    End Sub

    Private Sub GridSeguros_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridSeguros.AdvSearchSetPredefinedFilter
        With GridSeguros
            Select Case e.Key
                Case "IDFamilia"
                    If Length(.Value("IDTipo")) > 0 Then e.Filter.Add(New StringFilterItem("IdTipo", FilterOperator.Equal, .Value("IDTipo")))
            End Select
        End With
    End Sub

    Private Sub GridSeguros_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridSeguros.EditingCell
        With GridSeguros
            If cbxEstado.Value = enumocEstado.ocTerminado Then
                e.Cancel = True
                If e.Column.Key = "IDArticulo" Or e.Column.Key = "IDTipo" Or e.Column.Key = "IDFamilia" Or e.Column.Key = "IDArticuloFactura" Then
                    .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "IDArticulo", "IDTipo", "IDFamilia", "IDArticuloFactura"
                        .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image
                    Case "TipoDato", "TipoCalculoSeguro"
                        e.Cancel = True
                End Select
            End If
        End With
    End Sub

    Private Sub GridSeguros_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridSeguros.AddingRecord
        With GridSeguros
            Dim dv As New DataView(CType(.DataSource, DataTable).Copy)
            Dim f As New Filter

            Select Case CType(Nz(.Value("TipoDato"), 0), otaTipoSeguros)
                Case otaTipoSeguros.otaSegArticulo
                    f.Add(New StringFilterItem("IDArticulo", .Value("IDArticulo")))
                    f.Add(New IsNullFilterItem("IDTipo", True))
                    f.Add(New IsNullFilterItem("IDFamilia", True))
                Case otaTipoSeguros.otaSegPorTipo
                    f.Add(New StringFilterItem("IDTipo", .Value("IDTipo")))
                    f.Add(New IsNullFilterItem("IDArticulo", True))
                    f.Add(New IsNullFilterItem("IDFamilia", True))
                Case otaTipoSeguros.otaSegPorTipoFamilia
                    f.Add(New StringFilterItem("IDTipo", .Value("IDTipo")))
                    f.Add(New StringFilterItem("IDFamilia", .Value("IDFamilia")))
                    f.Add(New IsNullFilterItem("IDArticulo", True))
                Case otaTipoSeguros.otaSegGeneral
                    f.Add(New IsNullFilterItem("IDArticulo", True))
                    f.Add(New IsNullFilterItem("IDTipo", True))
                    f.Add(New IsNullFilterItem("IDFamilia", True))
            End Select

            dv.RowFilter = f.Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("Esta línea de Seguros ya existe en las Condiciones de Alquiler.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Length(.Value("IDFamilia")) <> 0 And Length(.Value("IdTipo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Tipo es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

#End Region

#End Region

#Region " Pestaña Ordenes... "

    Private Sub TrabajosObraChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPorOServicio.CheckedChanged, rbtPorAlquiler.CheckedChanged
        pnlVerTrabajosGrid.Visible = rbtPorOServicio.Checked
        If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
            CheckedAll()
            TabTrabajos_Click(TabTrabajos, New System.EventArgs)
        End If
    End Sub

    Private Sub CheckedAll()
        blnChecked = True
        Select Case TabTrabajos.SelectedTab.Key
            Case "Trabajos"
                rbtMaterialOServicio.Checked = rbtPorOServicio.Checked : rbtMaterialAlquiler.Checked = Not rbtPorOServicio.Checked
                rbtIncidenciasOServicio.Checked = rbtPorOServicio.Checked : rbtIncidenciasAlquiler.Checked = Not rbtPorOServicio.Checked
                rbtHitosOServicio.Checked = rbtPorOServicio.Checked : rbtHitosAlquiler.Checked = Not rbtHitosOServicio.Checked
                rbtOperariosOServicio.Checked = rbtPorOServicio.Checked : rbtOperariosAlquiler.Checked = Not rbtOperariosOServicio.Checked
            Case "Articulos"
                rbtIncidenciasOServicio.Checked = rbtMaterialOServicio.Checked : rbtIncidenciasAlquiler.Checked = Not rbtMaterialOServicio.Checked
                rbtPorOServicio.Checked = rbtMaterialOServicio.Checked : rbtPorAlquiler.Checked = Not rbtMaterialOServicio.Checked
                rbtHitosOServicio.Checked = rbtMaterialOServicio.Checked : rbtHitosAlquiler.Checked = Not rbtMaterialOServicio.Checked
                rbtOperariosOServicio.Checked = rbtMaterialOServicio.Checked : rbtOperariosAlquiler.Checked = Not rbtMaterialOServicio.Checked
            Case "Incidencias"
                rbtPorOServicio.Checked = rbtIncidenciasOServicio.Checked : rbtMaterialAlquiler.Checked = Not rbtIncidenciasOServicio.Checked
                rbtMaterialOServicio.Checked = rbtIncidenciasOServicio.Checked : rbtMaterialAlquiler.Checked = Not rbtIncidenciasOServicio.Checked
                rbtOperariosOServicio.Checked = rbtIncidenciasOServicio.Checked : rbtOperariosAlquiler.Checked = Not rbtIncidenciasOServicio.Checked
                rbtHitosOServicio.Checked = rbtIncidenciasOServicio.Checked : rbtHitosAlquiler.Checked = Not rbtIncidenciasOServicio.Checked
            Case "Hitos"
                rbtPorOServicio.Checked = rbtHitosOServicio.Checked : rbtPorAlquiler.Checked = Not rbtPorOServicio.Checked
                rbtMaterialOServicio.Checked = rbtHitosOServicio.Checked : rbtMaterialAlquiler.Checked = Not rbtPorOServicio.Checked
                rbtIncidenciasOServicio.Checked = rbtHitosOServicio.Checked : rbtIncidenciasAlquiler.Checked = Not rbtPorOServicio.Checked
                rbtOperariosOServicio.Checked = rbtHitosOServicio.Checked : rbtOperariosAlquiler.Checked = Not rbtPorOServicio.Checked
            Case "Personal"
                rbtPorOServicio.Checked = rbtOperariosOServicio.Checked : rbtPorAlquiler.Checked = Not rbtPorOServicio.Checked
                rbtMaterialOServicio.Checked = rbtOperariosOServicio.Checked : rbtMaterialAlquiler.Checked = Not rbtPorOServicio.Checked
                rbtIncidenciasOServicio.Checked = rbtOperariosOServicio.Checked : rbtIncidenciasAlquiler.Checked = Not rbtPorOServicio.Checked
                rbtHitosOServicio.Checked = rbtOperariosOServicio.Checked : rbtHitosAlquiler.Checked = Not rbtPorOServicio.Checked
        End Select
        blnChecked = False

    End Sub

    Private Sub FiltrosArbol(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxEstadoDistintoDE.ValueChanged, txtOServicioFind.LostFocus
        If Me.RecordsState <> RecordsState.Initialize Then
            RefreshArbolTrabajos()
            If TabTrabajos.SelectedTab.Key = "Ordenes" Then FiltrarGridTrabajos()
        End If
    End Sub

    Private Sub FichaChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtVerFicha.CheckedChanged, rbtVerGrid.CheckedChanged
        pnlFichaTrabajo.Visible = rbtVerFicha.Checked
    End Sub

#Region " Arbol Trabajos "

    Private Sub rbtMaximizarTree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMaximizarTree.CheckedChanged
        TvwTrabajos.ExpandAll()
    End Sub

    Private Sub rbtMinimizarTree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMinimizarTree.CheckedChanged
        TvwTrabajos.CollapseAll()
    End Sub

    Private Sub SeleccionarNodoTrabajo(ByVal IDTrabajo As Integer)
        For Each Nd As TreeNode In Me.TvwTrabajos.Nodes
            If CType(Nd.Tag, TagTrabajo).IDTrabajo = IDTrabajo Then
                Me.TvwTrabajos.SelectedNode = Nd
                Exit For
            ElseIf Nd.Nodes.Count > 0 Then
                If GetNode(Nd, IDTrabajo) Then Exit For
            End If
        Next
    End Sub

    Private Function GetNode(ByVal NdGet As TreeNode, ByVal IDTrabajo As Integer) As Boolean
        GetNode = False
        For Each Nd As TreeNode In NdGet.Nodes
            If CType(Nd.Tag, TagTrabajo).IDTrabajo = IDTrabajo Then
                Me.TvwTrabajos.SelectedNode = Nd
                Return True
            ElseIf Nd.Nodes.Count > 0 Then
                GetNode(Nd, IDTrabajo)
            End If
        Next
    End Function

    Private Sub RefreshArbolTrabajos()
        blnPintarTrabajos = True
        ArbolTrabajos()
    End Sub

    Private Sub ArbolTrabajos()
        If blnPintarTrabajos Then
            Dim f As New Filter
            Dim dv As New DataView(dtTrabajos)
            If Length(cbxEstadoDistintoDE.Value) > 0 Then
                f.Add("Estado", FilterOperator.NotEqual, cbxEstadoDistintoDE.Value)
            End If
            If Length(txtOServicioFind.Text) > 0 Then
                f.Add(New LikeFilterItem("CodTrabajo", "*" & txtOServicioFind.Text & "*"))
            End If

            If f.Count > 0 Then
                dv.RowFilter = f.Compose(New AdoFilterComposer)
            End If

            dv.Sort = "Secuencia Desc"
            If Not IsNothing(TvwTrabajos) Then TvwTrabajos.Nodes.Clear()
            PintarTrabajos(TvwTrabajos, dv)
            blnPintarTrabajos = False
        Else
            drTrabajos = GetdrTrabajos(intTrabajoActual)
            GetDatosTrabajo(drTrabajos)
        End If
        SeleccionarNodoTrabajo(intTrabajoActual)
    End Sub

    Private Sub PintarTrabajos(ByVal tvwTreeViewObj As TreeView, ByVal dvTrabajos As DataView, _
                               Optional ByVal oNode As TreeNode = Nothing)

        If Not dvTrabajos Is Nothing AndAlso dvTrabajos.Count > 0 Then
            If Not tvwTreeViewObj.Enabled Then tvwTreeViewObj.Enabled = True
            tvwTreeViewObj.ImageList = ImageList1
            For Each drvTrabajo As DataRowView In dvTrabajos
                If IsDBNull(drvTrabajo.Row("IDTrabajoPadre")) Then
                    PintarNodoTrabajo(tvwTreeViewObj, drvTrabajo.Row, dvTrabajos.Table, oNode)
                End If
            Next
        End If
        tvwTreeViewObj.SelectedNode = tvwTreeViewObj.TopNode
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PintarNodoTrabajo(ByVal tvwTreeViewObj As TreeView, ByVal drTrabajo As DataRow, ByVal dtTrabajos As DataTable, _
                                  Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = drTrabajo("CodTrabajo") & String.Empty & " -> " & drTrabajo("PedidoCliente") & String.Empty
        If oNode Is Nothing Then
            oNode = tvwTreeViewObj.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.Tag = New TagTrabajo(drTrabajo("IDObra"), drTrabajo("IDTrabajo"))
        If Length(drTrabajo("IDTrabajoPadre")) > 0 Then oNode.ForeColor = Color.DarkBlue
        oNode.ImageIndex = 3
        oNode.SelectedImageIndex = 4
        oNode.Expand()

        If Length(drTrabajo("IDTrabajo")) > 0 Then
            'pintar sus subtrabajos
            Dim dv As DataView = dtTrabajos.DefaultView
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDTrabajoPadre", drTrabajo("IDTrabajo")))
            dv.RowFilter = f.Compose(New AdoFilterComposer)
            dv.Sort = "Secuencia Desc"
            For Each drv As DataRowView In dv
                PintarNodoTrabajo(tvwTreeViewObj, drv.Row, dtTrabajos, oNode)
            Next
        End If
        oNode = Nothing
    End Sub

    Private Sub TvwTrabajos_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TvwTrabajos.AfterSelect
        e.Node.EnsureVisible()
        If blnVerTrabajo Then
            TabTrabajos_Click(TabTrabajos, New EventArgs)
        Else
            If TypeOf e.Node.Tag Is TagTrabajo Then
                drTrabajos = GetdrTrabajos(CType(e.Node.Tag, TagTrabajo).IDTrabajo)
                GetDatosTrabajo(drTrabajos)
                TabTrabajos_Click(TabTrabajos, New EventArgs)
            End If
        End If
        intTrabajoActual = 0
        If Not drTrabajos Is Nothing Then
            intTrabajoActual = drTrabajos("IDTrabajo")
        End If
    End Sub

    Private Sub TvwTrabajos_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TvwTrabajos.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim n As TreeNode = TvwTrabajos.GetNodeAt(e.X, e.Y)
            Dim blnFianza, blnFianzaContabilizada, blnEnabled As Boolean
            If Not IsNothing(n) Then
                drTrabajos = GetdrTrabajos(CType(n.Tag, TagTrabajo).IDTrabajo)
                If Not IsNothing(drTrabajos) Then
                    Me.MenuAlquiler.Commands("MnuDeleteOrden").Text = ExpertisApp.Traslate("Eliminar Orden Servicio")
                    blnFianza = Nz(drTrabajos("Fianza"), 0)
                    blnFianzaContabilizada = Nz(drTrabajos("FianzaContabilizada"), 0)
                    blnEnabled = Not (Me.CurrentRow("Estado") = enumocEstado.ocTerminado Or drTrabajos("Estado") = enumotEstado.otTerminado)
                End If
            Else
                drTrabajos = Nothing
                blnEnabled = Me.CurrentRow("Estado") <> enumocEstado.ocTerminado
            End If

            If Me.RecordsState = RecordsState.Modified Then blnEnabled = False

            Dim ENABLED As InheritableBoolean = InheritableBoolean.False
            If blnEnabled Then ENABLED = InheritableBoolean.True

            Me.MenuAlquiler.Commands("MnuNuevaOrden").Visible = InheritableBoolean.True
            Me.MenuAlquiler.Commands("MnuNuevaOrden").Enabled = ENABLED
            Me.MenuAlquiler.Commands("MnuGuion2").Visible = InheritableBoolean.True
            Me.MenuAlquiler.Commands("mnuRetornoAvisos").Visible = InheritableBoolean.True
            Me.MenuAlquiler.Commands("mnuRetornoMaterial").Visible = InheritableBoolean.True
            Me.MenuAlquiler.Commands("mnuPrefacturacion").Visible = InheritableBoolean.True
            Me.MenuAlquiler.Commands("mnuFacturacion").Visible = InheritableBoolean.True
            If Not IsNothing(n) Then
                Me.MenuAlquiler.Commands("MnuGuion").Visible = InheritableBoolean.True
            Else
                Me.MenuAlquiler.Commands("MnuGuion").Visible = InheritableBoolean.False
            End If
            Me.MenuAlquiler.Commands("MnuDeleteOrden").Visible = Me.MenuAlquiler.Commands("MnuGuion").Visible
            Me.MenuAlquiler.Commands("MnuDeleteOrden").Enabled = ENABLED
            Me.MenuAlquiler.Commands("MnuGuion3").Visible = Me.MenuAlquiler.Commands("MnuGuion").Visible
            Me.MenuAlquiler.Commands("mnuADDFianza").Visible = Me.MenuAlquiler.Commands("MnuGuion").Visible
            If blnEnabled AndAlso Not blnFianzaContabilizada Then
                Me.MenuAlquiler.Commands("mnuADDFianza").Enabled = InheritableBoolean.True
            Else
                Me.MenuAlquiler.Commands("mnuADDFianza").Enabled = InheritableBoolean.False
            End If
            Me.MenuAlquiler.Commands("mnuDeleteFianza").Visible = Me.MenuAlquiler.Commands("MnuGuion").Visible
            If blnEnabled AndAlso blnFianzaContabilizada Then
                Me.MenuAlquiler.Commands("mnuDeleteFianza").Enabled = InheritableBoolean.True
            Else
                Me.MenuAlquiler.Commands("mnuDeleteFianza").Enabled = InheritableBoolean.False
            End If
            Me.MenuAlquiler.Commands("MnuGuion4").Visible = Me.MenuAlquiler.Commands("MnuGuion").Visible
            Me.MenuAlquiler.Commands("mnuGeneraHitos").Visible = Me.MenuAlquiler.Commands("MnuGuion").Visible
            Me.MenuAlquiler.Commands("mnuGeneraHitos").Enabled = ENABLED
            Me.MenuAlquiler.Commands("mnuSeguimiento").Visible = Me.MenuAlquiler.Commands("MnuGuion").Visible
            If Not IsNothing(n) Then
                Me.MenuAlquiler.Commands("mnuIncidencias").Visible = InheritableBoolean.True
            Else
                Me.MenuAlquiler.Commands("mnuIncidencias").Visible = InheritableBoolean.False
            End If
            Me.MenuAlquiler.Commands("MnuGuion5").Visible = Me.MenuAlquiler.Commands("MnuGuion").Visible
            Me.MenuAlquiler.Commands("mnuAlbaran").Visible = Me.MenuAlquiler.Commands("MnuGuion").Visible

            If blnEnabled Then
                If Not Nz(CurrentRow("FianzaObligatoria"), False) Or (Nz(CurrentRow("FianzaObligatoria"), False) And blnFianza) Then
                    Me.MenuAlquiler.Commands("mnuAlbaran").Enabled = InheritableBoolean.True
                Else
                    Me.MenuAlquiler.Commands("mnuAlbaran").Enabled = InheritableBoolean.False
                End If
            Else
                Me.MenuAlquiler.Commands("mnuAlbaran").Enabled = ENABLED
            End If
            Me.MenuAlquiler.Commands("mnuSalidaRetorno").Visible = Me.MenuAlquiler.Commands("MnuGuion").Visible
            Me.MenuAlquiler.Commands("mnuSalidaRetorno").Enabled = Me.MenuAlquiler.Commands("mnuAlbaran").Enabled

            MenuAlquiler.Show()
        End If
    End Sub

#Region " Acciones Arbol Trabajos "

    Private Sub NuevaOrden(ByVal IDTrabajo As Integer)
        If Length(Me.CurrentRow("IDTipoObra")) > 0 AndAlso Length(Me.CurrentRow("IDDireccion")) > 0 Then
            Dim PedidoClienteAbierto As String = String.Empty
            If chkPedidoClienteAbierto.Checked Then
                PedidoClienteAbierto = txtPedidoClienteAbierto.Text
            End If
            'PedidoClienteAbierto
            Dim frm As New FrmAddOrden
            Dim dr As DataRow = frm.AbrirAltaOrden(Me.CurrentRow("IDObra"), Me.CurrentRow("IDTipoObra"), AdvIDCliente.Text, ulDescCliente.Text, _
                                                   Me.CurrentRow("IDDireccion"), txtDireccion.Text, txtPoblacion.Text, txtProvincia.Text, _
                                                   txtCodPostal.Text, txtCifCliente.Text, "-", CurrentRow("TextoCliente") & String.Empty, _
                                                   Nz(Me.CurrentRow("FianzaObligatoria"), False), IDTrabajo, Me.CurrentRow("IDCentroGestion") & String.Empty)
            IDTrabajo = 0

            If Not IsNothing(dr) Then
                dr("Secuencia") = (ndTrabajos.Data.Rows.Count + 1) * 10
                ndTrabajos.Data.Rows.Add(dr.ItemArray)
                Me.RecordsState = RecordsState.Modified
                dtTrabajos = ndTrabajos.Data
                RefreshArbolTrabajos()
                FiltrarGridTrabajos()
            End If
        Else
            ExpertisApp.GenerateMessage("El Tipo Alquiler y la dirección del Cliente son datos necesarios para poder dar de alta Ordenes.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MnuNuevaOrden_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuNuevaOrden.Click
        If lblBloqueado.Visible Then
            ExpertisApp.GenerateMessage("El Cliente | está bloqueado.", MessageBoxButtons.OK, MessageBoxIcon.Information, Quoted(Me.AdvIDCliente.Value))
        Else
            If IsNothing(drTrabajos) Then
                NuevaOrden(0)
            Else
                NuevaOrden(drTrabajos("IDTrabajo"))
            End If
            blnRefreshArbol = True
        End If
    End Sub

    Private Sub MnuDeleteOrden_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuDeleteOrden.Click
        If ExpertisApp.GenerateMessage("Va a eliminar registros. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            ExpertisApp.ExecuteTask(Of Integer)(AddressOf ObraTrabajo.BorrarTrabajo, drTrabajos("IDTrabajo"))

            blnRefreshArbol = True
            RefreshAlquiler()

            FiltrosArbol(cbxEstadoDistintoDE, New EventArgs)
        End If
    End Sub

    Private Sub mnuRetornoAvisos_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuRetornoAvisos.Click
        Dim HT As New Hashtable
        HT.Add("IDObra", Me.CurrentRow("IDObra"))
        HT.Add("NObra", txtNObra.Text)
        If Not drTrabajos Is Nothing Then
            HT.Add("IDTrabajo", drTrabajos("IDTrabajo"))
            HT.Add("CodTrabajo", drTrabajos("CodTrabajo"))
        End If
        ExpertisApp.OpenForm("AVISRET", , HT)
    End Sub

    Private Sub mnuRetornoMaterial_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuRetornoMaterial.Click
        Dim HT As New Hashtable
        HT.Add("IDObra", Me.CurrentRow("IDObra"))
        HT.Add("NObra", txtNObra.Text)
        If Not drTrabajos Is Nothing Then
            HT.Add("IDTrabajo", drTrabajos("IDTrabajo"))
            HT.Add("CodTrabajo", drTrabajos("CodTrabajo"))
        End If
        HT.Add("IDCliente", AdvIDCliente.Text)

        If ExpertisApp.IsFormOpen(ExpertisApp.FindProgram("RETFACTALQ").ProgramID) Then ExpertisApp.CloseForm(ExpertisApp.FindProgram("RETFACTALQ").ProgramID)
        ExpertisApp.OpenForm("RETFACTALQ", , HT)
    End Sub

    Private Sub mnuPrefacturacion_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuPrefacturacion.Click
        Dim HT As New Hashtable
        HT.Add("IDObra", Me.CurrentRow("IDObra"))
        HT.Add("NObra", txtNObra.Text)
        If Not drTrabajos Is Nothing Then
            HT.Add("IDTrabajo", drTrabajos("IDTrabajo"))
            HT.Add("CodTrabajo", drTrabajos("CodTrabajo"))
        End If

        ExpertisApp.OpenForm("CONSOB", , HT)
    End Sub

    Private Sub mnuFacturacion_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuFacturacion.Click
        Dim HT As New Hashtable
        HT.Add("IDObra", Me.CurrentRow("IDObra"))
        HT.Add("NObra", txtNObra.Text)
        If Not drTrabajos Is Nothing Then
            HT.Add("IDTrabajo", drTrabajos("IDTrabajo"))
            HT.Add("CodTrabajo", drTrabajos("CodTrabajo"))
        End If

        ExpertisApp.OpenForm("FACTALQUILER", , HT)
    End Sub

    Private Sub mnuADDFianza_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuADDFianza.Click
        Dim dtTrabajo As DataTable = dtTrabajos.Clone
        dtTrabajo.ImportRow(drTrabajos)
        ADDFianza(dtTrabajo)
        RefreshAlquiler()
    End Sub

    Private Sub mnuDeleteFianza_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuDeleteFianza.Click
        Dim dtTrabajo As DataTable = dtTrabajos.Clone
        dtTrabajo.ImportRow(drTrabajos)
        DeleteFianza(dtTrabajo)
        RefreshAlquiler()
    End Sub

    Private Sub mnuGeneraHitos_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuGeneraHitos.Click
        AbrirFormVencimientosDesdeTrabajo()
    End Sub

    Private Sub AbrirFormVencimientosDesdeTrabajo(Optional ByVal blnGrid As Boolean = False)
        If blnGrid Then
            If TypeOf GridTrabajos.DataSource Is DataView Then
                drTrabajos = CType(GridTrabajos.DataSource, DataView).Table.Rows(GridTrabajos.GetRow.RowIndex)
            Else
                drTrabajos = CType(GridTrabajos.DataSource, DataTable).Rows(GridTrabajos.GetRow.RowIndex)
            End If
        End If
        If Not IsNothing(drTrabajos) Then
            If drTrabajos("Facturable") Then
                If drTrabajos("TipoFacturacion") = enumotTipoFacturacion.otfPorVencimientos Then
                    Dim frm As New FrmGeneraVencimientos
                    frm.AbrirGeneracionVencimientos(drTrabajos, Me.CurrentRow, enumottfClaseVencimiento.ottfTrabajo, Me)
                    Me.Requery.InvokeOnClick()
                Else
                    ExpertisApp.GenerateMessage("Este trabajo no es facturable por trabajos completos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                ExpertisApp.GenerateMessage("Este trabajo no es facturable.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub mnuIncidencias_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuIncidencias.Click
        If drTrabajos("IDtrabajo") Then
            Dim frm As New FrmIncidenciasAlquilerTrabajo
            frm.mDesctrabajo = drTrabajos("PedidoCliente") & String.Empty
            frm.mIDObra = Me.CurrentRow("IDObra")
            frm.mIDTrabajo = drTrabajos("IDTrabajo")
            frm.mCodTrabajo = drTrabajos("CodTrabajo") & String.Empty

            frm.ShowDialog(Me)
            Me.Requery.InvokeOnClick()
        End If
    End Sub

    Private Sub mnuSeguimiento_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuSeguimiento.Click
        Dim f As New Filter
        f.Add("IDObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
        Dim HT As New Hashtable
        HT.Add("IDTrabajo", drTrabajos("IDTrabajo"))
        ExpertisApp.OpenForm("SEGALQUI", f, HT)
    End Sub

    Private Sub mnuAlbaran_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuAlbaran.Click
        ProcesoAlbaran(General.enumTipoAlbaran.Albaran)
    End Sub

    Private Sub mnuSalidaRetorno_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuSalidaRetorno.Click
        ProcesoAlbaran(General.enumTipoAlbaran.AlbaranSalidaRetorno)
    End Sub

    Protected Overridable Sub ProcesoAlbaran(Optional ByVal Tipo As enumTipoAlbaran = enumTipoAlbaran.Albaran)
        If Length(drTrabajos("Estado")) > 0 AndAlso drTrabajos("Estado") <> enumotEstado.otTerminado Then
            If lblBloqueado.Visible Then
                ExpertisApp.GenerateMessage("El Cliente | está bloqueado.", MessageBoxButtons.OK, MessageBoxIcon.Information, Quoted(Me.AdvIDCliente.Value))
            Else
                If Me.CurrentRow("FianzaObligatoria") And Nz(drTrabajos("Fianza"), 0) = 0 Then
                    ExpertisApp.GenerateMessage("El Cliente de la obra tiene la marca de Fianza Obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If chbPortesEspSalidas.Checked AndAlso Length(txtCondicionesEspPortesBloq.Text) > 0 Then
                        ExpertisApp.GenerateMessage("Las condiciones especiales para el Alquiler | son: |", MessageBoxButtons.OK, MessageBoxIcon.Information, txtNObra.Text, txtCondicionesEspPortesBloq.Text)
                    End If
                    GenerarAlbaran(drTrabajos, Me.Cursor, Tipo)
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("No es posible generar el Albarán debido al estado de la Orden de Servicio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#End Region

    Private Sub TabTrabajos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabTrabajos.Click
        Select Case TabTrabajos.SelectedTab.Key
            Case "Trabajos"
                GetDatosTrabajo(drTrabajos)
                BloqueoEstadoOrden()
                FiltrarGridTrabajos()
                TratarTipoFacturacion()
            Case "Articulos"
                FiltrarGrid(rbtMaterialOServicio.Checked, GridMaterial)
                BloqueoTrabajoTerminado()
            Case "Incidencias"
                FiltrarGrid(rbtIncidenciasOServicio.Checked, GridIncidencias)
            Case "Hitos"
                FiltrarGrid(rbtHitosOServicio.Checked, GridVencimientos)
                TotalesHitos(GridVencimientos, New EventArgs)
            Case "Personal"
                FiltrarGrid(rbtOperariosOServicio.Checked, GridOperariosOrdenServicio)
        End Select
    End Sub

    Private Sub ChangeDefaultViewGrid(ByVal blnPorTrabajo As Boolean, ByVal GridAux As Solmicro.Expertis.Engine.UI.Grid)
        If blnPorTrabajo AndAlso Not IsNothing(drTrabajos) Then
            If Length(drTrabajos("IDTrabajo")) > 0 Then GridAux.Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
            If Length(drTrabajos("CodTrabajo")) > 0 Then GridAux.Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
            If GridAux.Name = "GridMaterial" Then
                If Length(drTrabajos("QPrev")) > 0 Then GridAux.Columns("QPrevTrabajo").DefaultValue = drTrabajos("QPrev")
            End If
        End If
    End Sub

#Region " Ficha Trabajos "

#Region " Búsqueda de Actividades y Direcciones "

    Private Sub cmbSearchActividad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSearchActividad.Click
        advEmpresaActividad.Open()
    End Sub

    Private Sub advEmpresaActividad_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advEmpresaActividad.SetPredefinedFilter
        If Length(txtIDEmpresa.Text) > 0 Then e.Filter.Add(New StringFilterItem("IDEmpresa", txtIDEmpresa.Text))
    End Sub

    Private Sub advEmpresaActividad_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advEmpresaActividad.SelectionChanged
        If Not IsNothing(e.Selected) AndAlso e.Selected.Rows.Count > 0 Then
            drTrabajos("IDActividad") = e.Selected.Rows(0)("IDActividad")
        End If
    End Sub

    Private Sub cmbSearchIDDireccion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSearchIDDireccion.Click
        advClienteDireccion.Open()
    End Sub

    Private Sub advClienteDireccion_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advClienteDireccion.SetPredefinedFilter
        e.Filter.Add(New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")))
        If Not IsNothing(Me.CurrentRow) AndAlso Length(Me.CurrentRow("IDCliente")) > 0 Then e.Filter.Add(New StringFilterItem("IDCliente", Me.CurrentRow("IDCliente")))
    End Sub

    Private Sub advClienteDireccion_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advClienteDireccion.SelectionChanged
        If Not IsNothing(e.Selected) AndAlso e.Selected.Rows.Count > 0 Then
            drTrabajos("IDDireccion") = e.Selected.Rows(0)("IDDireccion")
        End If
    End Sub

#End Region

#Region " Estado Trabajo "

    Private Sub cbxEstadoTrabajo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxEstadoTrabajo.Validating
        If Not ValidarTrabajoTerminado() Then
            e.Cancel = True
        Else
            BloqueoEstadoOrden()
            BloqueoTrabajoTerminado()
        End If
    End Sub
    Private Sub BloqueoTrabajoTerminado()
        If Nz(cbxEstadoTrabajo.Value, 0) = enumotEstado.otTerminado Then
            GridMaterial.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
            GridMaterial.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
            GridMaterial.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True
        Else
            GridMaterial.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True
            GridMaterial.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
            GridMaterial.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True
        End If
    End Sub
    Private Sub ControlesFichaSiempreEnabled()
        txtCodTrabajo.Enabled = False
        txtNivelTrabajo.Enabled = False
        chkTraspasada.Enabled = False
        txtTipoActividad.Enabled = False
        txtDescSituacion.Enabled = False
        cbxFechaActividad.Enabled = False
        txtHoraActividad.Enabled = False
        txtTextoActividad.Enabled = False
        chkFianzaContabilizada.Enabled = False
        chkFianzaCompensada.Enabled = False
        cbxFechaContabilizacion.Enabled = False
        txtFianza.Enabled = False
        txtDireccionTrabajo.Enabled = False
        txtDtoClienteTrabajo.Enabled = False
        txtCPClienteTrabajo.Enabled = False
        txtPoblacionClienteTrabajo.Enabled = False
        txtProvinciaTrabajoCliente.Enabled = False
    End Sub

    Private Sub BloqueoEstadoOrden()
        ControlesFichaSiempreEnabled()

        Dim blnEnabled As Boolean = (IsNothing(drTrabajos) Or Nz(cbxEstadoTrabajo.Value, enumotEstado.otTerminado) = enumotEstado.otTerminado Or cbxEstado.Value = enumocEstado.ocTerminado)

        BloquearInformacion(pnlFichaTrabajo, blnEnabled, txtCodTrabajo, txtNivelTrabajo, cmbVerPedidoCliente, _
                            cmbPrint, txtImporte, chkTraspasada, cmbVerTextoContacto, txtTipoActividad, _
                            txtDescSituacion, cbxFechaActividad, txtHoraActividad, txtTextoActividad, _
                            chkFianzaContabilizada, chkFianzaCompensada, cbxFechaContabilizacion, txtFianza, _
                            txtDireccionTrabajo, txtDtoClienteTrabajo, txtCPClienteTrabajo, _
                            txtPoblacionClienteTrabajo, txtProvinciaTrabajoCliente)

        AdvPersonaContacto.Enabled = Not blnEnabled AndAlso Nz(txtNivelTrabajo.Text, 0) = 0
        txtTextoContacto.Enabled = AdvPersonaContacto.Enabled
        cmbVerTextoContacto.Enabled = Nz(txtNivelTrabajo.Text, 0) = 0
        If Not blnEnabled Then txtPedidoCliente.Enabled = Not chkPedidoClienteAbierto.Checked

        If IsNothing(drTrabajos) Then
            lblDescArticulo.Text = String.Empty
            cbxFechaOrdenTrabajo.Value = System.DBNull.Value
            cbxFechaInicioTrabajo.Value = System.DBNull.Value
            cbxFechaPrevEntregaTrabajo.Value = System.DBNull.Value
            cbxFechaFinTrabajo.Value = System.DBNull.Value
            'cbxTipoFactAlquiler.Value = enumTipoFacturacionAlquiler.enumTFASinAlquiler
            cmbPrint.Enabled = False
        Else
            cmbPrint.Enabled = True
        End If
    End Sub

    Private Function ValidarTrabajoTerminado() As Boolean
        If cbxEstadoTrabajo.Value = enumotEstado.otTerminado Then
            Return General.ValidarTrabajoTerminado(drTrabajos("IDTrabajo"), mstrAlbaranDeposito)
        End If
        Return True
    End Function

#End Region

    Private Sub AdvPersonaContacto_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvPersonaContacto.SetPredefinedFilter
        'e.Filter.Add(New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")))
    End Sub

    Private Sub txtPedidoCliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPedidoCliente.TextChanged
        If Length(txtPedidoCliente.Text) > 50 AndAlso _
            txtPedidoCliente.Text <> enumotEstado.otTerminado Then
            ExpertisApp.GenerateMessage("Se ha superado el límite del campo para otros procesos.En la Generacíon de Albaranes el Pedido Cliente quedará acotado a 50 caracteres.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmbVerPedidoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVerPedidoCliente.Click
        Dim frm As New FormularioTexto
        frm.Text = lblPedidoCliente.Text
        frm.Texto = txtPedidoCliente.Text & String.Empty
        frm.SoloLectura = Not txtPedidoCliente.Enabled
        frm.ShowDialog()
        If txtPedidoCliente.Text & String.Empty <> frm.Texto Then
            txtPedidoCliente.Text = frm.Texto
        End If
    End Sub

    Private Sub cmbVerTextoContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVerTextoContacto.Click
        Dim frm As New FormularioTexto
        frm.Text = lblTextoContacto.Text
        frm.Texto = txtTextoContacto.Text & String.Empty
        frm.SoloLectura = (cbxEstadoTrabajo.Value = enumotEstado.otTerminado Or cbxEstado.Value = enumocEstado.ocTerminado)
        frm.ShowDialog()
        If txtTextoContacto.Text & String.Empty <> frm.Texto Then
            txtTextoContacto.Text = frm.Texto
        End If
    End Sub

    Private Sub cbxTipoFacturacion_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipoFacturacion.ValueChanged
        If Length(cbxTipoFacturacion.Value) > 0 Then
            If cbxTipoFacturacion.Value = enumotTipoFacturacion.otfPorAlquiler Then
                lblImporte.Text = "Precio"
            Else
                lblImporte.Text = "Importe"
            End If
        End If
        If Length(cbxEstadoTrabajo.Value) > 0 Then
            If cbxEstadoTrabajo.Value <> enumotEstado.otTerminado Then
                TratarTipoFacturacion()
            End If
        End If
    End Sub

    Public Sub TratarTipoFacturacion()
        If Length(cbxTipoFacturacion.Value) > 0 Then
            Select Case CType(cbxTipoFacturacion.Value, enumotTipoFacturacion)
                Case enumotTipoFacturacion.otfPorAlquiler
                    cbxTipoFactAlquiler.Enabled = True
                    txtImporte.Enabled = True
                Case enumotTipoFacturacion.otfPorUdsObra, enumotTipoFacturacion.otfPorVencimientos
                    cbxTipoFactAlquiler.Enabled = False
                    txtImporte.Enabled = True
                Case Else
                    cbxTipoFactAlquiler.Enabled = False
                    'cbxTipoFactAlquiler.Value = enumTipoFacturacionAlquiler.enumTFASinAlquiler
                    txtImporte.Enabled = False
            End Select
        End If
    End Sub

    Private Sub cbxCentroGestionTrabajo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxCentroGestionTrabajo.Validated
        mblnCentroGestionTrabajo = False
        If drTrabajos.RowState = DataRowState.Modified Then
            If cbxEstado.Value <> enumotEstado.otTerminado Then
                If Length(cbxCentroGestionTrabajo.Value & String.Empty) > 0 Then
                    mblnCentroGestionTrabajo = True
                End If
            End If
        End If
    End Sub

    Private Sub cmbPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrint.Click
        If Me.RecordsState = RecordsState.Saved Then
            Dim oReport As New Report("LODS")
            '''ExpertisApp.OpenReport "RptOrdenDeServicioGam.rpt", , , rptRecordset
            ExpertisApp.OpenReport(oReport)
        End If
    End Sub

#End Region

#Region " Filtrar Grid "

    Private Sub FiltrarGridTrabajos()
        Dim dv As New DataView(dtTrabajos)
        Dim f As New Filter

        If Not dtTrabajos Is Nothing AndAlso dtTrabajos.Rows.Count > 0 Then
            If Length(cbxEstadoDistintoDE.Value) > 0 Then
                f.Add("Estado", FilterOperator.NotEqual, cbxEstadoDistintoDE.Value)
            End If

            If Not IsNothing(drTrabajos) Then
                If rbtPorOServicio.Checked AndAlso Length(drTrabajos("IDTrabajo")) > 0 Then
                    'f.Add(New NumberFilterItem("IDTrabajoPadre", drTrabajos("IDTrabajo")))
                    f.Add(New NumberFilterItem("IDTrabajo", drTrabajos("IDTrabajo")))
                End If

                Dim strWhere As String = f.Compose(New AdoFilterComposer)
                dv.RowFilter = strWhere
                dv.Sort = "Secuencia, CodTrabajo"
                GridTrabajos.DataSource = dv

                If rbtPorOServicio.Checked Then
                    If Length(drTrabajos("IDTrabajo")) > 0 Then GridTrabajos.Columns("IDTrabajoPadre").DefaultValue = drTrabajos("IDTrabajo")
                    If Length(drTrabajos("CodTrabajo")) > 0 Then GridTrabajos.Columns("CodTrabajoPadre").DefaultValue = drTrabajos("CodTrabajo")
                End If
            End If
        End If
    End Sub

    Private Sub FiltrarGrid(ByVal blnPorTrabajo As Boolean, ByVal GridAux As Solmicro.Expertis.Engine.UI.Grid)
        Dim f As New Filter
        If blnPorTrabajo AndAlso Not drTrabajos Is Nothing AndAlso Length(drTrabajos("IDTrabajo")) > 0 Then
            f.Add(New NumberFilterItem("IDTrabajo", drTrabajos("IDTrabajo")))
        End If
        If TabTrabajos.SelectedTab.Key = "Incidencias" AndAlso chkFiltrarPorMaterial.Checked AndAlso Length(AdvMaterial.Text) > 0 Then
            f.Add(New StringFilterItem("IDMaterial", AdvMaterial.Text))
        End If
        Dim dv As DataView
        If TypeOf GridAux.DataSource Is DataView Then
            dv = GridAux.DataSource
        Else
            dv = CType(GridAux.DataSource, DataTable).DefaultView
        End If
        Dim strWhere As String = f.Compose(New AdoFilterComposer)
        dv.RowFilter = strWhere
        GridAux.DataSource = dv

        ChangeDefaultViewGrid(blnPorTrabajo, GridAux)
    End Sub

#End Region

#Region " SubPestaña Materiales "

    Private Sub MaterialesChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMaterialAlquiler.CheckedChanged, rbtMaterialOServicio.CheckedChanged
        pnlVerArticulos.Visible = rbtMaterialOServicio.Checked
        If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
            CheckedAll()
            FiltrarGrid(rbtMaterialOServicio.Checked, GridMaterial)
        End If
    End Sub

    Private Sub GridMaterial_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMaterial.GotFocus
        With GridMaterial
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            .Columns("IDAlmacen").DefaultValue = mIDAlmacen
            .Columns("IDTipoObra").DefaultValue = Me.CurrentRow("IDTipoObra")
            .Columns("EstadoFactura").DefaultValue = CInt(enumomEstadoFactura.omNoFacturado)
            .Columns("Estado").DefaultValue = CInt(enumomEstado.omPendiente)
            .Columns("Expedible").DefaultValue = True
            .Columns("FechaPrevistaEntrega").DefaultValue = cbxFechaPrevEntregaTrabajo.Value
            If Length(cbxTipoFactAlquiler.Value) > 0 Then
                If cbxTipoFacturacion.Value <> enumotTipoFacturacion.otfPorVencimientos Then
                    .Columns("Facturable").DefaultValue = True
                Else
                    .Columns("Facturable").DefaultValue = False
                End If
            Else
                .Columns("Facturable").DefaultValue = False
            End If
            .Columns("NoFacturarDiasMinimos").DefaultValue = 0
            .Columns("NoFacturarPlusContadores").DefaultValue = 0
            .Columns("PrecioPrevMatA").DefaultValue = 0
            .Columns("PrecioVentaA").DefaultValue = 0
            .Columns("ImpPrevMatA").DefaultValue = 0
            .Columns("ImpFactMatA").DefaultValue = 0
            .Columns("QUnidad").DefaultValue = 0
            .Columns("QPrev").DefaultValue = 0
            .Columns("Dto1").DefaultValue = 0
            .Columns("Dto2").DefaultValue = 0
            .Columns("Dto3").DefaultValue = 0
            .Columns("QServida").DefaultValue = 0
            .Columns("QFacturada").DefaultValue = 0
            .Columns("QRetornada").DefaultValue = 0
            .Columns("QPedida").DefaultValue = 0
            .Columns("QFactura").DefaultValue = 0
            .Columns("UdValoracion").DefaultValue = 1
            If rbtMaterialOServicio.Checked AndAlso Not IsNothing(drTrabajos) Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
                If Length(drTrabajos("QPrev")) > 0 Then
                    .Columns("QPrevTrabajo").DefaultValue = drTrabajos("QPrev")
                End If

                If Length(drTrabajos("Facturable")) > 0 AndAlso cbxTipoFacturacion.Value = enumotTipoFacturacion.otfPorConceptos Then
                    .Columns("Facturable").DefaultValue = drTrabajos("Facturable")
                End If
                .Columns("FechaEntrega").DefaultValue = drTrabajos("FechaInicio")
            Else
                .Columns("IDTrabajo").DefaultValue = System.DBNull.Value
                .Columns("CodTrabajo").DefaultValue = System.DBNull.Value
                .Columns("QPrevTrabajo").DefaultValue = 0
                .Columns("Facturable").DefaultValue = False
                .Columns("FechaEntrega").DefaultValue = System.DBNull.Value
            End If
        End With
    End Sub

    Private Function ValidarTipoFacturacionTrabajo(ByVal intIdTrabajo As Integer, _
                                                   ByVal intTipoFacturacion As enumotTipoFacturacion) As Boolean

        Dim blnOK As Boolean
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            Dim dv As DataView = dtTrabajos.Copy.DefaultView
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDTrabajo", intIdTrabajo))
            dv.RowFilter = f.Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                blnOK = (Nz(dv(0).Row("TipoFacturacion"), 0) = intTipoFacturacion)
            End If
        End If

        Return blnOK
    End Function

    Private Sub CargarFormVencimientos()
        With GridMaterial
            If .Row <> Grid.newTopRowPosition AndAlso .Value("Estado") = enumomEstado.omPendiente AndAlso .Value("TipoFacturacion") = enumomATipoFacturacionAlquiler.omAPorVencimientos Then
                If ValidarTipoFacturacionTrabajo(.Value("IDTrabajo"), enumotTipoFacturacion.otfPorConceptos) Then
                    If .Value("Facturable") Then
                        Dim dr As DataRow
                        If TypeOf .DataSource Is DataView Then
                            dr = CType(.DataSource, DataView).Table.Rows(.Row)
                        Else
                            dr = CType(.DataSource, DataTable).Rows(.Row)
                        End If
                        Dim frm As New FrmGeneraVencimientos
                        frm.AbrirGeneracionVencimientos(dr, Me.CurrentRow, enumottfClaseVencimiento.ottfMaterial, Me)
                    Else
                        ExpertisApp.GenerateMessage("Este Material no es facturable.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    ExpertisApp.GenerateMessage("Este Material es facturable por trabajos completos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End With
    End Sub

    Private Sub CargarSearchArticulo()
        Dim blnDisponible As Boolean
        Dim strIDArticulo As String = String.Empty
        Dim strNSerie As String = String.Empty

        Dim frm As New frmSearchArticulo
        frm.AbrirForm(strIDArticulo, strNSerie, blnDisponible)
        Dim bd As New BusinessCallData
        With GridMaterial
            If Length(strNSerie) = 0 Then
                If Length(strIDArticulo) > 0 Then
                    .Value("IDMaterial") = strIDArticulo
                    bd.NewData("IDMaterial") = .Value("IDMaterial")
                End If
            ElseIf blnDisponible Then
                If Length(strIDArticulo) > 0 Then .Value("IDMaterial") = strIDArticulo
                If Length(strNSerie) > 0 Then
                    Dim Articulo As New Articulo
                    Dim dtArticulo As DataTable = Articulo.SelOnPrimaryKey(strIDArticulo)
                    If Not IsNothing(dtArticulo) AndAlso dtArticulo.Rows.Count > 0 Then
                        If dtArticulo.Rows(0)("NSerieObligatorio") Then
                            .Value("Lote") = strNSerie
                        Else
                            .Value("Lote") = System.DBNull.Value
                            ExpertisApp.GenerateMessage("No se puede seleccionar un numero de Maquina para un Articulo que no tiene activo la gestión de números de Serie.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                        bd.NewData("Lote") = .Value("Lote")
                    End If
                End If
            Else
                ExpertisApp.GenerateMessage("La máquina | no está disponible.", MessageBoxButtons.OK, MessageBoxIcon.Information, strNSerie)
            End If

            'Al no saltar las BusinessRule, provocamos la llamada.
            If Len(strIDArticulo) > 0 Then
                For Each c As GridEXColumn In GridMaterial.Columns
                    bd.CurrentData(c.DataMember) = .Value(c.Key)
                Next

                Dim e As New BusinessCallingEventArgs(GridMaterial.EntityName, bd)
                Me.OnBusinessCalling(e)

                bd.Context = e.Data.Context
                bd.CurrentData = New ObraMaterial().BusinessRules(bd)
                For Each c As GridEXColumn In GridMaterial.Columns
                    If GridMaterial.Columns.Contains(c.DataMember) Then
                        .Value(c.Key) = bd.CurrentData(c.DataMember)
                    End If
                Next
            End If
        End With
    End Sub

    Private Sub GridMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMaterial.Click
        With GridMaterial
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Dim blnSoloLectura As Boolean = (cbxEstadoTrabajo.Value = enumotEstado.otTerminado Or cbxEstado.Value = enumocEstado.ocTerminado)
                        Select Case c.Key
                            Case "Texto"
                                Dim frm As New FormularioTexto
                                frm.Texto = .Value("Texto") & String.Empty
                                frm.SoloLectura = blnSoloLectura
                                frm.ShowDialog()
                                If .Value("Texto") & String.Empty <> frm.Texto Then
                                    .SetValue("Texto", frm.Texto)
                                End If
                            Case "Vencimiento"
                                If Not blnSoloLectura Then CargarFormVencimientos()
                            Case "SearchArticulo"
                                If Not blnSoloLectura And .Value("Estado") = enumomEstado.omPendiente Then
                                    CargarSearchArticulo()
                                End If
                            Case "Incidencias"
                                If Length(.Value("IDLineaMaterial")) > 0 AndAlso rbtMaterialOServicio.Checked AndAlso .GetValue("TipoFacturacion") = CInt(enumomATipoFacturacionAlquiler.omAPorAlquiler) Then
                                    Dim frm As New FrmIncidenciasAlquilerMat
                                    frm.blnSoloLectura = blnSoloLectura
                                    frm.mIDLineaMaterial = .Value("IDLineaMaterial")
                                    frm.mIDMaterial = .Value("IDMaterial") & String.Empty
                                    frm.mDescMaterial = .Value("DescMaterial") & String.Empty
                                    frm.mIDObra = Me.CurrentRow("IDObra")
                                    frm.mIDTrabajo = .Value("IDTrabajo")
                                    frm.mCodTrabajo = .Value("CodTrabajo") & String.Empty
                                    frm.ShowDialog(Me)
                                End If
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub GridMaterial_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridMaterial.EditingCell
        With GridMaterial
            If lblBloqueado.Visible AndAlso GridMaterial.Row = Grid.newTopRowPosition Then
                e.Cancel = True
                If .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image OrElse _
                   .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Ellipsis Then
                    '//Las B.Avanzadas quitarles el botón
                    .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "SearchArticulo"
                        Dim blnSoloLectura As Boolean = (cbxEstadoTrabajo.Value = enumotEstado.otTerminado Or cbxEstado.Value = enumocEstado.ocTerminado)
                        If Not blnSoloLectura And .Value("Estado") = enumomEstado.omPendiente Then
                            CargarSearchArticulo()
                        End If
                    Case "DescMaterial", "Lote", "DescArticulo"
                        If .Value("Estado") = enumomEstado.omPendiente Then
                            .Columns(e.Column.Key).EditType = Janus.Windows.GridEX.EditType.TextBox
                            .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Ellipsis
                        Else
                            e.Cancel = True
                            .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                        End If
                    Case "QPrev", "QUnidad", "FechaEntrega", "TipoFacturacion", "Facturable" ', "NoFacturarPlusContadores"
                        If .Value("Estado") <> enumomEstado.omPendiente Then
                            e.Cancel = True
                        End If
                    Case "IDMaterial", "IDAlmacen", "IDMaterialOrigen", "CCVenta", "CCCompra", "IDUDInterna", _
                         "CodTrabajo"
                        If .Value("Estado") = enumomEstado.omPendiente Then
                            .Columns(e.Column.Key).EditType = Janus.Windows.GridEX.EditType.TextBox
                            .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                        Else
                            e.Cancel = True
                            .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                        End If
                    Case "TipoFactAlquiler"
                        If .Value("Estado") <> enumomEstado.omPendiente Then
                            If .Value("TipoFacturacion") <> enumomATipoFacturacionAlquiler.omAPorAlquiler Then
                                e.Cancel = True
                            End If
                        End If
                    Case "SeguimientoTarifa", "Seguimiento"
                        If .Value("Estado") = enumomEstado.omPendiente Then
                            e.Cancel = True
                            .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Ellipsis
                        Else
                            e.Cancel = True
                            .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                        End If
                    Case "NoFacturarDiasMinimos"
                        If .Value("Estado") = enumomEstado.omPendiente Then
                            If Me.CurrentRow("FacturarDiasMinimos") Then
                                .Columns(e.Column.Key).EditType = Janus.Windows.GridEX.EditType.CheckBox
                            Else
                                e.Cancel = True
                            End If
                        End If
                    Case "Estado", "EstadoRetorno"
                        e.Cancel = True
                End Select
            End If
        End With

    End Sub

    Private Sub CargarNSerie()
        With GridMaterial
            Dim f As New Filter
            f.Add("Disponible", FilterOperator.Equal, 1, FilterType.Numeric)
            If Length(.Value("IDMaterial")) Then 'And Length(.Value("IDAlmacen")) > 0 Then
                f.Add("IDArticulo", FilterOperator.Equal, .Value("IDMaterial"), FilterType.String)
                'f.Add("IDAlmacen", FilterOperator.Equal, .Value("IDAlmacen"), FilterType.String)
            End If

            Dim dv As DataView
            If TypeOf .DataSource Is DataView Then
                dv = .DataSource
            Else
                dv = CType(.DataSource, DataTable).DefaultView
            End If

            For Each drRow As DataRowView In dv
                If Length(drRow.Row("Lote")) > 0 Then f.Add(New StringFilterItem("NSerie", FilterOperator.NotEqual, drRow.Row("Lote")))
            Next
            mNSerie = New NSerieSeleccion
            mNSerie.FilterCriteria = f
            mNSerie.OrdenServicio = True
            mNSerie.Articulo = .Value("IDMaterial") & String.Empty
            mNSerie.ShowDialog()
        End With
    End Sub

    Private Sub GridMaterial_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridMaterial.ColumnButtonClick
        Select Case e.Column.Key
            Case "SeguimientoTarifa", "DescMaterial", "DescArticulo"
                Dim frm As New FormularioTexto
                frm.Texto = GridMaterial.Value(e.Column.Key) & String.Empty
                frm.SoloLectura = True
                frm.ShowDialog()
            Case "Lote"
                CargarNSerie()
        End Select
    End Sub

    Private Sub GridMaterial_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMaterial.UpdatingRecord, GridMaterial.AddingRecord
        With GridMaterial

            Dim CC As New AltaPlanContable
            If Length(.Value("CCVenta")) > 0 Then
                e.Cancel = Not CC.ValidaCuentaContable(.Value("CCVenta"), mstrEjercicioActual)
            End If
            If Length(.Value("CCCompra")) > 0 Then
                e.Cancel = Not CC.ValidaCuentaContable(.Value("CCCompra"), mstrEjercicioActual)
            End If
            If Not e.Cancel Then
                If Length(.Value("CodTrabajo")) = 0 Or Length(.Value("IDMaterial")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Cod. Trabajo y el Material son datos obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, ExpertisApp.Title)
                End If
            End If
        End With
    End Sub

    Private Sub GridMaterial_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridMaterial.AdvSearchSetPredefinedFilter
        With GridMaterial
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    e.Filter.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                Case "IdUDVenta"
                    e.Filter.Add("UdMedida", FilterOperator.Equal, 1, FilterType.Numeric)
                Case "CCVenta", "CCCompra"
                    e.Filter.Add("IDEjercicio", FilterOperator.Equal, mstrEjercicioActual, FilterType.String)
                Case "IdTipoTrabajo"
                    e.Filter.Add("IdTipoObra", FilterOperator.Equal, AdvIDTipoObra.Value, FilterType.String)
                Case "IDAlmacen"
                    e.Filter.Add("Activo", FilterOperator.Equal, True, FilterType.Boolean)
                    'e.Filter.Add("Deposito", FilterOperator.Equal, False, FilterType.Boolean)
            End Select
        End With
    End Sub

    Private Sub GridMaterial_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridMaterial.FormattingRow
        With GridMaterial
            If e.Row.RowType = RowType.Record Then
                If Length(e.Row.Cells("IdLineaMaterialPadre").Value) > 0 Then
                    e.Row.RowStyle = .FormatStyles("FormatStyleComponentes")
                End If
            End If
        End With
    End Sub

    Private Sub GridMaterial_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridMaterial.UpdatingCell
        With GridMaterial
            Select Case e.Column.Key
                Case "Lote"
                    If Length(e.Value) > 0 Then
                        Dim dtActivo As DataTable = Nothing
                        Dim f As New Filter
                        f.Add(New BooleanFilterItem("Disponible", True))
                        If Length(.GetValue("IDMaterial")) > 0 Then
                            f.Add(New StringFilterItem("IDArticulo", .GetValue("IDMaterial")))
                        Else
                            dtActivo = New ArticuloNSerie().Filter(New StringFilterItem("NSerie", e.Value), , "IDArticulo, IDAlmacen")
                            If dtActivo.Rows.Count > 0 Then
                                .Value("IDMaterial") = dtActivo.Rows(0)("IDArticulo")
                            Else
                                ExpertisApp.GenerateMessage("La máquina introducida no tiene un Artículo asociado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                            End If
                        End If
                        If Not e.Cancel Then
                            f.Add("NSerie", FilterOperator.Equal, e.Value)
                            Dim dtSerie As DataTable = New BE.DataEngine().Filter("vFrmSeleccionSeries", f)
                            If dtSerie Is Nothing OrElse dtSerie.Rows.Count = 0 Then
                                ExpertisApp.GenerateMessage("La máquina introducida no está en estado disponible para el Artículo |.|Por favor, revise los datos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, .GetValue("IDMaterial"), vbNewLine)
                                e.Value = Nothing : .SetValue("Lote", Nothing)
                                e.Cancel = True
                            End If
                            If Not mTransferenciaGenerada AndAlso Not e.Cancel Then
                                If dtActivo Is Nothing Then
                                    dtActivo = New ArticuloNSerie().Filter(New StringFilterItem("NSerie", e.Value), , "IDArticulo, IDAlmacen")
                                End If
                                If dtActivo.Rows.Count > 0 Then
                                    If .Value("IDAlmacen") <> dtActivo.Rows(0)("IDAlmacen") Then
                                        mTransferencias = objTransferencias.AddTransferencia(Nz(.Value("IDLineaMaterial"), 0), dtActivo.Rows(0)("IDArticulo"), dtActivo.Rows(0)("NSerie"), dtActivo.Rows(0)("IDAlmacen"), .Value("IDAlmacen"), True)
                                        mTransferenciaGenerada = False
                                    End If
                                End If
                            End If
                        End If
                    End If
            End Select
        End With
    End Sub

    Private mTransferenciaGenerada As Boolean
    Private Sub mNSerie_SeleccionSerie(ByVal Row As System.Data.DataRow) Handles mNSerie.SeleccionSerie
        If Not IsNothing(Row) Then
            With GridMaterial
                If .Value("QUnidad") <> 1 Then
                    .Value("QPrev") = 1
                    .Value("QUnidad") = 1
                End If
                .Value("IDMaterial") = Row("IDArticulo")
                .Value("Lote") = Row("NSerie")

                If .Value("IDAlmacen") <> Row("IDAlmacen") Then
                    mTransferenciaGenerada = True
                    mTransferencias = objTransferencias.AddTransferencia(Nz(.Value("IDLineaMaterial"), 0), Row("IDArticulo"), Row("NSerie"), Row("IDAlmacen"), .Value("IDAlmacen"), True)
                End If
            End With
        End If
    End Sub

#End Region

#Region " Grid Incidencias "

    Private Sub chkFiltrarPorMaterial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrarPorMaterial.CheckedChanged
        pnlFiltrarPorMaterial.Visible = (chkFiltrarPorMaterial.Checked And rbtIncidenciasOServicio.Checked)
    End Sub

    Private Sub IncidenciasChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtIncidenciasAlquiler.CheckedChanged, rbtIncidenciasOServicio.CheckedChanged
        pnlVerIncidencias.Visible = rbtIncidenciasOServicio.Checked
        chkFiltrarPorMaterial_CheckedChanged(chkFiltrarPorMaterial, New EventArgs)
        If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
            CheckedAll()
            FiltrarGrid(rbtIncidenciasOServicio.Checked, GridIncidencias)
        End If
    End Sub

    Private Sub AdvMaterial_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvMaterial.SetPredefinedFilter
        e.Filter.Add("IDObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
        If rbtIncidenciasOServicio.Checked Then
            e.Filter.Add("IDTrabajo", FilterOperator.Equal, drTrabajos("IDTrabajo"), FilterType.Numeric)
        End If
    End Sub

    Private Sub AdvMaterial_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvMaterial.LostFocus
        FiltrarGrid(rbtIncidenciasOServicio.Checked, GridIncidencias)
    End Sub

    Private Sub GridIncidencias_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridIncidencias.GotFocus
        With GridIncidencias
            .Columns("AfectaFactura").DefaultValue = 0
            .Columns("PorcentajeFact").DefaultValue = 100
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            If rbtIncidenciasOServicio.Checked Then
                .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
            Else
                .Columns("IDTrabajo").DefaultValue = System.DBNull.Value
                .Columns("CodTrabajo").DefaultValue = System.DBNull.Value
            End If
            If Length(AdvMaterial.Value) > 0 Then
                .Columns("IdMaterial").DefaultValue = AdvMaterial.Text
            Else
                .Columns("IdMaterial").DefaultValue = System.DBNull.Value
            End If
        End With
    End Sub

    Private Sub GridIncidencias_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridIncidencias.EditingCell
        With GridIncidencias
            If cbxEstado.Value = enumocEstado.ocTerminado Then
                e.Cancel = True
                If e.Column.Key = "IDMaterial" Or e.Column.Key = "CodTrabajo" Or e.Column.Key = "IDIncidenciasAlquiler" Then
                    .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "IDMaterial", "IDIncidenciasAlquiler"
                        .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image
                    Case "CodTrabajo"
                        If .Row <> Grid.newTopRowPosition AndAlso Length(.Value("CodTrabajo")) > 0 Then
                            e.Cancel = True
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                        Else
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                        End If
                End Select
            End If
        End With
    End Sub

    Private Sub GridIncidencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridIncidencias.Click
        With GridIncidencias
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Texto"
                                Dim frm As New FormularioTexto
                                Dim blnSoloLectura As Boolean = (cbxEstadoTrabajo.Value = enumotEstado.otTerminado Or cbxEstado.Value = enumocEstado.ocTerminado)
                                frm.Texto = .Value("Texto") & String.Empty
                                frm.SoloLectura = blnSoloLectura
                                frm.ShowDialog()
                                If .Value("Texto") & String.Empty <> frm.Texto Then
                                    .SetValue("Texto", frm.Texto)
                                End If
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub GridIncidencias_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridIncidencias.AdvSearchSetPredefinedFilter
        With GridIncidencias
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    e.Filter.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                Case "IDMaterial"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    If Length(.Value("IDTrabajo")) > 0 Then e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"), FilterType.Numeric)
            End Select
        End With
    End Sub

    Private Sub CmdMasiva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdMasiva.Click
        If drTrabajos("Estado") = enumotEstado.otTerminado Then
            ExpertisApp.GenerateMessage("No se pueden generar Incidencias si la Orden está Cerrada.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim f As New FrmIncidenciasMasivasMat
            Dim dr As DialogResult = f.AbrirIncidenciasMasivasMateriales(Me.CurrentRow("IDObra"), _
                                                                         drTrabajos("IDTrabajo"), _
                                                                         drTrabajos("CodTrabajo"), _
                                                                         drTrabajos("PedidoCliente") & String.Empty, _
                                                                         True, False, AdvMaterial.Text, _
                                                                         "", True, AdvMaterial.Value)

            If dr = DialogResult.OK Then RefreshAlquiler()
        End If
    End Sub

#End Region

#Region " SubPestaña Hitos Facturacion "

    Private Sub HitosObraChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtHitosOServicio.CheckedChanged, rbtHitosAlquiler.CheckedChanged
        pnlVerHitos.Visible = rbtHitosOServicio.Checked
        If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
            CheckedAll()
            TabTrabajos_Click(TabTrabajos, New System.EventArgs)
        End If
    End Sub

    Private Sub GridVencimientos_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridVencimientos.AdvSearchSetPredefinedFilter
        With GridVencimientos
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                Case "IdLineaALbaranVentaOrigen"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    If Length(.Value("IdTrabajo")) > 0 Then
                        e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IdTrabajo"), FilterType.Numeric)
                    End If
                Case "IDClienteBanco"
                    e.Filter.Add("IdCliente", FilterOperator.Equal, AdvIDCliente.Text, FilterType.String)
            End Select
        End With
    End Sub

    Private Sub GridVencimientos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVencimientos.GotFocus
        With GridVencimientos
            .Columns("IDMoneda").DefaultValue = Me.CurrentRow("IDMoneda")
            .Columns("CambioA").DefaultValue = Me.CurrentRow("CambioA")
            .Columns("CambioB").DefaultValue = Me.CurrentRow("CambioB")
            .Columns("IDFormaPago").DefaultValue = Me.CurrentRow("IDFormaPago")
            .Columns("IDCondicionPago").DefaultValue = Me.CurrentRow("IDCondicionPago")
            .Columns("IDDiaPago").DefaultValue = Me.CurrentRow("IDDiaPago")
            .Columns("IDTipoIva").DefaultValue = Me.CurrentRow("IDTipoIva")
            .Columns("IDTipoObra").DefaultValue = Me.CurrentRow("IDTipoObra")
            .Columns("IdCLienteBanco").DefaultValue = Me.CurrentRow("IDClienteBanco")
            .Columns("QTiempo").DefaultValue = 1
            If rbtHitosOServicio.Checked AndAlso Not drTrabajos Is Nothing Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
            Else
                .Columns("IDTrabajo").DefaultValue = System.DBNull.Value
                .Columns("CodTrabajo").DefaultValue = System.DBNull.Value
            End If
        End With
    End Sub

    Private Sub GridVencimientos_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridVencimientos.EditingCell
        With GridVencimientos
            If cbxEstado.Value = enumocEstado.ocTerminado Then
                e.Cancel = True
                If e.Column.Key = "CodTrabajo" OrElse e.Column.Key = "IDFormaPago" OrElse _
                   e.Column.Key = "IDCondicionPago" OrElse e.Column.Key = "IDDiaPago" OrElse _
                   e.Column.Key = "IDArticulo" OrElse e.Column.Key = "IDTipoIva" OrElse _
                   e.Column.Key = "IDClienteBanco" OrElse e.Column.Key = "IDConcepto" OrElse _
                   e.Column.Key = "IDLineaAlbaranVentaOrigen" Then
                    .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "IDFormaPago", "IDCondicionPago", "IDDiaPago", "IDArticulo", _
                         "IDTipoIva", "IDClienteBanco", "IDConcepto", "IDLineaAlbaranVentaOrigen"
                        .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image
                    Case "CodTrabajo"
                        If .Row <> Grid.newTopRowPosition AndAlso Length(.Value("CodTrabajo")) > 0 Then
                            e.Cancel = True
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                        Else
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                        End If
                End Select
            End If
        End With
    End Sub

    Private Sub GridVencimientos_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridVencimientos.AddingRecord, GridVencimientos.UpdatingRecord
        With GridVencimientos
            If Length(.Value("CodTrabajo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)  '
            End If
        End With
    End Sub

    Private Sub GridVencimientos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridVencimientos.FormattingRow
        With GridVencimientos
            If e.Row.RowType = RowType.Record Then
                Select Case CType(e.Row.Cells("TipoFactura").Value, enumotfTipoFactura)
                    Case enumotfTipoFactura.otfHorasMOD
                        e.Row.RowStyle = .FormatStyles("MODFormatStyle")
                    Case enumotfTipoFactura.otfGastos
                        e.Row.RowStyle = .FormatStyles("GastoFormatStyle")
                    Case enumotfTipoFactura.otfAlquiler
                        e.Row.RowStyle = .FormatStyles("AlquilerFormatStyle")
                    Case enumotfTipoFactura.otfMateriales
                        e.Row.RowStyle = .FormatStyles("MaterialFormatStyle")
                End Select
            End If
        End With
    End Sub

    Private Sub GridVencimientos_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridVencimientos.ColumnButtonClick
        With GridVencimientos
            Select Case e.Column.Caption
                Case "Seguimiento"
                    Dim frm As New FormularioTexto
                    frm.Texto = .Value("Seguimiento") & String.Empty
                    Dim blnSoloLectura As Boolean = (cbxEstadoTrabajo.Value = enumotEstado.otTerminado Or cbxEstado.Value = enumocEstado.ocTerminado)
                    frm.SoloLectura = blnSoloLectura
                    frm.ShowDialog()
                    If .Value("Seguimiento") & String.Empty <> frm.Texto Then
                        .SetValue("Seguimiento", frm.Texto)
                    End If
            End Select
        End With
    End Sub

    Private Sub TotalesHitos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridVencimientos.RecordAdded, GridVencimientos.RecordUpdated, GridVencimientos.RecordsDeleted
        With GridVencimientos
            txtTotalVtoA.Value = xRound(.GetTotal(.Columns("ImpVencimientoA"), Janus.Windows.GridEX.AggregateFunction.Sum), mMonedaA.NDecimalesImporte)
            txtTotalA.Value = xRound(.GetTotal(.Columns("ImpTotalA"), Janus.Windows.GridEX.AggregateFunction.Sum), mMonedaA.NDecimalesImporte)
        End With
    End Sub

#End Region

#Region " SubPestaña Personal "

    Private Sub OperariosObraChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtOperariosOServicio.CheckedChanged, rbtOperariosAlquiler.CheckedChanged
        pnlVerOperarios.Visible = rbtOperariosOServicio.Checked
        If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
            CheckedAll()
            FiltrarGrid(rbtOperariosOServicio.Checked, GridOperariosOrdenServicio)
        End If
    End Sub

    Private Sub GridOperariosOrdenServicio_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridOperariosOrdenServicio.GotFocus
        With GridOperariosOrdenServicio
            If rbtOperariosOServicio.Checked Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
            Else
                .Columns("IDTrabajo").DefaultValue = System.DBNull.Value
                .Columns("CodTrabajo").DefaultValue = System.DBNull.Value
            End If
        End With
    End Sub

    Private Sub GridOperariosOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridOperariosOrdenServicio.Click
        With GridOperariosOrdenServicio
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Texto"
                                Dim frm As New FormularioTexto
                                Dim blnSoloLectura As Boolean = (cbxEstadoTrabajo.Value = enumotEstado.otTerminado Or cbxEstado.Value = enumocEstado.ocTerminado)
                                frm.Texto = .Value("Texto") & String.Empty
                                frm.SoloLectura = blnSoloLectura
                                frm.ShowDialog()
                                If .Value("Texto") & String.Empty <> frm.Texto Then
                                    .SetValue("Texto", frm.Texto)
                                End If
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub GridOperariosOrdenServicio_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridOperariosOrdenServicio.EditingCell
        With GridOperariosOrdenServicio
            If cbxEstado.Value = enumocEstado.ocTerminado Then
                e.Cancel = True
                If e.Column.Key = "CodTrabajo" OrElse e.Column.Key = "IDOperario" OrElse e.Column.Key = "IDOficio" Then
                    .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "IDFormaPago", "IDOperario", "IDOficio"
                        .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image
                    Case "CodTrabajo"
                        If .Row <> Grid.newTopRowPosition AndAlso Length(.Value("CodTrabajo")) > 0 Then
                            e.Cancel = True
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                        Else
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                        End If
                End Select
            End If
        End With
    End Sub

    Private Sub GridOperariosOrdenServicio_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridOperariosOrdenServicio.UpdatingRecord, GridOperariosOrdenServicio.AddingRecord
        With GridOperariosOrdenServicio
            If Length(.Value("CodTrabajo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)   '
            End If
        End With
    End Sub

    Private Sub GridOperariosOrdenServicio_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridOperariosOrdenServicio.AdvSearchSetPredefinedFilter
        With GridOperariosOrdenServicio
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
            End Select
        End With
    End Sub

#End Region

#End Region

#Region " Pestaña Representantes "

    Private Sub GridRepresentantes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridRepresentantes.GotFocus
        GridRepresentantes.Columns("Tipo").DefaultValue = CInt(enumOrepComision.OrepGeneral)
    End Sub

    Private Sub GridRepresentantes_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridRepresentantes.AdvSearchSetPredefinedFilter
        With GridRepresentantes
            Select Case e.Key
                Case "IDFamilia"
                    e.Filter.Add("IDTipo", FilterOperator.Equal, .Value("IDTipo"), FilterType.String)
                Case "IDSubFamilia"
                    e.Filter.Add("IDTipo", FilterOperator.Equal, .Value("IDTipo"), FilterType.String)
                    e.Filter.Add("IDFamilia", FilterOperator.Equal, .Value("IDFamilia"), FilterType.String)
            End Select
        End With
    End Sub

    Private Sub GridRepresentantes_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridRepresentantes.EditingCell
        With GridRepresentantes
            If cbxEstado.Value = enumocEstado.ocTerminado Then
                e.Cancel = True
                If e.Column.Key = "IDRepresentante" Or e.Column.Key = "IDArticulo" Or e.Column.Key = "IDTipo" Or e.Column.Key = "IDFamilia" Then
                    .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "IDRepresentante", "IDArticulo", "IDTipo", "IDFamilia"
                        .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image
                    Case "Tipo"
                        e.Cancel = True
                End Select
            End If
        End With
    End Sub

    Private Sub GridRepresentantes_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridRepresentantes.AddingRecord
        With GridRepresentantes
            Dim dv As New DataView(CType(.DataSource, DataTable).Copy)
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")))
            f.Add(New StringFilterItem("IDRepresentante", .Value("IDRepresentante")))
            If Length(.Value("IDArticulo")) > 0 Then
                f.Add(New StringFilterItem("IDArticulo", .Value("IDArticulo")))
            Else
                f.Add(New IsNullFilterItem("IDArticulo"))
            End If
            If Length(.Value("IDTipo")) > 0 Then
                f.Add(New StringFilterItem("IDTipo", .Value("IDTipo")))
            Else
                f.Add(New IsNullFilterItem("IDTipo"))
            End If
            If Length(.Value("IDFamilia")) > 0 Then
                f.Add(New StringFilterItem("IDFamilia", .Value("IDFamilia")))
            Else
                f.Add(New IsNullFilterItem("IDFamilia"))
            End If
            If Length(.Value("IDSubfamilia")) > 0 Then
                f.Add(New StringFilterItem("IDSubfamilia", .Value("IDSubfamilia")))
            Else
                f.Add(New IsNullFilterItem("IDSubfamilia"))
            End If

            dv.RowFilter = f.Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("La combinación de Tipo, Familia y SubFamilia ya existe para un mismo Representante.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub
#End Region

#Region " Pestaña Actividades "

    Private Sub GridActividades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridActividades.Click
        With GridActividades
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Texto"
                                Dim frm As New FormularioTexto
                                frm.Texto = .Value(c.Key) & String.Empty
                                Dim blnSoloLectura As Boolean = (cbxEstadoTrabajo.Value = enumotEstado.otTerminado Or cbxEstado.Value = enumocEstado.ocTerminado)
                                frm.SoloLectura = blnSoloLectura
                                frm.ShowDialog()
                                If .Value(c.Key) & String.Empty <> frm.Texto Then
                                    .SetValue(c.Key, frm.Texto)
                                End If
                            Case "AltaActividad"
                                'TODO: Esto está sin migrar desde la 3.1 ¿QUITAR?
                                'Dim oEmp As New Empresa.AltaActividad
                                'Dim BEDataEngine As New BE.DataEngine
                                'Dim f As New Filter

                                'f.Add("IDObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                                'f.Add("IdActividad", FilterOperator.Equal, .Value("IDActividad"), FilterType.Numeric)
                                'Dim dttEA As DataTable = BEDataEngine.Filter("VFrmMntoAlquilerActividades", f)
                                ''''¿Todavía no se ha traducido
                                ''''¿oEmp.OpenForm(dttEA)
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

#End Region

#Region " Pestaña Recursos"

    Private Sub GridRecursos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridRecursos.Click
        With GridRecursos
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Texto"
                                Dim frm As New FormularioTexto
                                Dim blnSoloLectura As Boolean = (cbxEstadoTrabajo.Value = enumotEstado.otTerminado Or cbxEstado.Value = enumocEstado.ocTerminado)
                                frm.SoloLectura = blnSoloLectura
                                frm.Texto = .Value("Texto") & String.Empty
                                frm.ShowDialog()
                                If .Value("Texto") & String.Empty <> frm.Texto Then
                                    .SetValue("Texto", frm.Texto)
                                End If
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub GridRecursos_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridRecursos.EditingCell
        With GridRecursos
            If cbxEstado.Value = enumocEstado.ocTerminado Then
                e.Cancel = True
                If e.Column.Key = "IDOperario" Then
                    .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                End If
            ElseIf e.Column.Key = "IDOperario" Then
                .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image
            End If
        End With
    End Sub

#End Region

#Region " Business Call "

    Private Sub MntoAlquiler_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context.Clear()
        e.Data.Context("IDCliente") = Me.CurrentRow("IDCliente")
        e.Data.Context("EnMonedaA") = True
        e.Data.Context("IDMoneda") = advIDMoneda.Value
        e.Data.Context("CambioA") = Me.CurrentRow("CambioA")
        e.Data.Context("CambioB") = Me.CurrentRow("CambioB")
        e.Data.Context("IDMonedaA") = mMonedaA.ID
        e.Data.Context("Fecha") = Me.CurrentRow("FechaInicio")
        e.Data.Context("TipoMnto") = CInt(enumTipoObra.tpalquiler)
        Select Case e.EntityName
            Case GridTrabajos.EntityName
                e.Data.Context("FechaIniCab") = Me.CurrentRow("FechaInicio")
                e.Data.Context("FechaFinCab") = Me.CurrentRow("FechaFin")
                e.Data.Context("NumeroLineas") = GridTrabajos.RowCount
            Case GridMaterial.EntityName
                e.Data.Context("IDEjercicio") = mstrEjercicioActual
                e.Data.Context("QPrevTrabajo") = GridMaterial.Value("QPrevTrabajo")
                '//NOTA: Esto es para la Transferencia de Almacenes
                If Not IsNothing(e.Data.CurrentData) AndAlso e.Data.CurrentData.ContainsKey("IDAlmacen") AndAlso Length(e.Data.CurrentData("IDAlmacen")) > 0 Then
                    mIDAlmacenOld = e.Data.CurrentData("IDAlmacen")
                Else
                    mIDAlmacenOld = String.Empty
                End If
            Case GridSegurosArticulos.EntityName
                e.Data.Context("IDObra") = Me.CurrentRow("IDObra")
                e.Data.Context("FechaInicio") = cbxFechaInicio.Value
        End Select
    End Sub

    Private Sub MntoAlquiler_BusinessCalled(ByVal sender As Object, ByVal e As Engine.UI.BusinessCalledEventArgs) Handles MyBase.BusinessCalled
        If Not IsNothing(e.Data) Then
            If e.Data.ContainsKey("DescBanco") Then
                ulDescClienteBanco.Text = e.Data("DescBanco") & String.Empty

            End If
        End If

        'Select Case e.EntityName
        '    Case "ObraMaterial"
        '        '//NOTA: Esto es para la Transferencia de Almacenes
        '        If Not IsNothing(e.Data) AndAlso e.Data.ContainsKey("IDAlmacen") AndAlso Length(e.Data("IDAlmacen")) > 0 Then
        '            If Length(mIDAlmacenOld) > 0 AndAlso mIDAlmacenOld <> e.Data("IDAlmacen") Then
        '                mTransferencias = objTransferencias.AddTransferencia(Nz(e.Data("IDLineaMaterial"), 0), e.Data("IDMaterial"), e.Data("Lote"), mIDAlmacenOld, e.Data("IDAlmacen"), True)
        '            End If
        '        End If
        'End Select
    End Sub

#End Region

#Region " TAGs "

    Private Class TagTrabajo
        Public IDObra, IDTrabajo As Integer

        Public Sub New(ByVal intIDObra As Integer, ByVal intIDTrabajo As Integer)
            IDObra = intIDObra
            IDTrabajo = intIDTrabajo
        End Sub
    End Class

#End Region

#Region " Informes "

    Private Sub MntoAlquiler_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        Select Case e.Alias
            Case "LODS"
                If Not IsNothing(ndTrabajos.Data) AndAlso _
                        ndTrabajos.Data.Rows.Count > 0 Then
                    Dim intIdTrabajo As Integer
                    intIdTrabajo = drTrabajos("IdTrabajo")

                    Dim Consulta As New BE.DataEngine
                    Dim f As New Filter
                    f.Add("IDObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    f.Add("IDTrabajo", FilterOperator.Equal, drTrabajos("IDTrabajo"), FilterType.Numeric)

                    Dim dttOS As DataTable = Consulta.Filter("VrptMntoOrdenServicioGam", f)
                    If Not IsNothing(dttOS) AndAlso dttOS.Rows.Count > 0 Then
                        e.DataSource = dttOS
                    End If
                    Consulta = Nothing : f = Nothing : dttOS = Nothing
                End If
        End Select
    End Sub
    '¿PROBAR
    Private Sub MntoAlquiler_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        'Select Case e.Alias
        '    Case "Inco"
        '        Dim ofrm As New FrmFechaIncidencias
        '        ofrm.intIDObra = Me.CurrentRow("IDObra")
        '        ofrm.ShowDialog(Me)
        '        If Not ofrm.blnCancel Then
        '            If Len(ofrm.mstrFiltro) > 0 Then
        '                e.Filter.Add(ofrm.mstrFiltro)
        '            End If
        '        Else
        '            e.Cancel = True
        '        End If
        '        ofrm = Nothing
        'End Select
    End Sub

#End Region

    Private Sub MntoAlquiler_RecordCanceling(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.RecordCanceling
        blnRecordStateChanged = True
        blnRefreshArbol = True
    End Sub

    'David Velasco 15/10/21
    Private Sub GridMaterial_CellUpdated(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridMaterial.CellUpdated
        With GridMaterial
            Select Case e.Column.Key
                Case "IDMaterial"
                    setPrecios()
                    'Si Articulo es de Alquiler. Tipo Factura Alquiler: Dias Naturales y  Tipo Facturacion: Por Alquiler
                    'Si no. Tipo Factura Alquiler: Sin Alquiler y  Tipo Facturacion: Por Expedición
                    Dim art As String
                    art = GridMaterial.GetValue("IDMaterial")
                    Dim articulo As New Articulo
                    Dim dt As DataTable = articulo.SelOnPrimaryKey(art)
                    Dim tipo As String = dt.Rows(0)("IDTipo")
                    Dim familia As String = dt.Rows(0)("IDFamilia")
                    Dim subfamilia As String
                    subfamilia = ""
                    Try
                        subfamilia = dt.Rows(0)("IDSubFamilia")
                    Catch ex As Exception

                    End Try

                    If (tipo = "30" Or familia = "2003" Or familia = "2004" Or subfamilia = "HIDRAULICA") Then
                        If (familia <> "3031") Then
                            .SetValue("TipoFactAlquiler", CInt(enumTipoFacturacionAlquiler.enumTFADiasNaturales))
                            .SetValue("TipoFacturacion", CInt(enumomATipoFacturacionAlquiler.omAPorAlquiler))
                        End If
                    End If
                    'If (tipo = "30" Or familia = "2003" Or familia = "2004") Then
                    '    .SetValue("TipoFactAlquiler", CInt(enumTipoFacturacionAlquiler.enumTFADiasNaturales))
                    '    .SetValue("TipoFacturacion", CInt(enumomATipoFacturacionAlquiler.omAPorAlquiler))
                    'End If
                Case "QUnidad"
                    Dim almacen As String
                    almacen = GridMaterial.GetValue("IDAlmacen")
                    Dim articulo As String
                    articulo = GridMaterial.GetValue("IDMaterial")
                    Dim articuloalm As New ArticuloAlmacen
                    GridMaterial.SetValue("StockFisico", articuloalm.getStock(almacen, articulo))
                    If (GridMaterial.GetValue("QUnidad") <= 0) Then
                        ExpertisApp.GenerateMessage("La cantidad pedida no es valida.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GridMaterial.SetValue("QUnidad", 0)
                        GridMaterial.SetValue("QPrev", 0)
                    End If
                    'Aqui iria el código por si se quiere tener en cuenta si el articulo permite stocks negativos.
                    If (GridMaterial.GetValue("QUnidad") > GridMaterial.GetValue("StockFisico")) Then
                        ExpertisApp.GenerateMessage("No hay stock suficiente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GridMaterial.SetValue("QUnidad", 0)
                        GridMaterial.SetValue("QPrev", 0)
                        setPrecios()
                        Me.UpdateChanges()
                    Else
                        setPrecios()
                    End If
                Case "Lote"
                    setPrecios()
                    'Si Articulo es de Alquiler. Tipo Factura Alquiler: Dias Naturales y  Tipo Facturacion: Por Alquiler
                    'Si no. Tipo Factura Alquiler: Sin Alquiler y  Tipo Facturacion: Por Expedición
                    Dim art As String
                    art = GridMaterial.GetValue("IDMaterial")
                    Dim articulo As New Articulo
                    Dim dt As DataTable = articulo.SelOnPrimaryKey(art)
                    Dim tipo As String = dt.Rows(0)("IDTipo")
                    Dim familia As String = dt.Rows(0)("IDFamilia")
                    Dim subfamilia As String
                    subfamilia = ""
                    Try
                        subfamilia = dt.Rows(0)("IDSubFamilia")
                    Catch ex As Exception

                    End Try

                    If (tipo = "30" Or familia = "2003" Or familia = "2004") Then
                        If (familia <> "3031") Then
                            .SetValue("TipoFactAlquiler", CInt(enumTipoFacturacionAlquiler.enumTFADiasNaturales))
                            .SetValue("TipoFacturacion", CInt(enumomATipoFacturacionAlquiler.omAPorAlquiler))
                        End If
                    End If
            End Select
        End With
    End Sub
    Private Sub setPrecios()
        Dim precioA As Double = 0
        Dim datosPrecio As New ProcesoStocks.DataPrecioMovimiento(GridMaterial.GetValue("IDMaterial"), GridMaterial.GetValue("IDAlmacen"), cnMinDate, GridMaterial.GetValue("QUnidad"), enumtpmTipoMovimiento.tpmInput)
        Dim precios As Hashtable = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataPrecioMovimiento, Hashtable)(AddressOf ProcesoStocks.PrecioMovimiento, datosPrecio)
        precioA = precios("PrecioA")
        GridMaterial.SetValue("PrecioPrevMatA", precioA)
        Dim valor As Double = 0.0
        valor = (GridMaterial.GetValue("PrecioPrevMatA") * GridMaterial.GetValue("QUnidad"))
        GridMaterial.SetValue("ImpPrevMatA", valor)
    End Sub
    'David Velasco 15/10/21

    Private Sub AdvPersonaContacto_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvPersonaContacto.SelectionChanged
        Dim texto As String = ""
        Dim dt As DataTable = New ObraPersonaContacto2().Filter(New StringFilterItem("IDPersona", AdvPersonaContacto.Text))
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            texto = dt.Rows(0)("Nombre") & " Tlf: " & dt.Rows(0)("Telefono1")
        End If

        txtTextoContacto.Text = texto
        TextBox1.Text = texto

        'Dim opc As New ObraPersonaContacto2
        'opc.DatosContacto(texto)

        'Dim frm As New FormularioTexto
        'frm.Text = lblTextoContacto.Text
        'frm.Texto = txtTextoContacto.Text & String.Empty
        'frm.SoloLectura = (cbxEstadoTrabajo.Value = enumotEstado.otTerminado Or cbxEstado.Value = enumocEstado.ocTerminado)
        'frm.ShowDialog()
        'If txtTextoContacto.Text & String.Empty <> frm.Texto Then
        '    txtTextoContacto.Text = frm.Texto
        'End If
    End Sub

    Private Sub AdvSearch1_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvSearch1.SelectionChanged
        Dim texto As String = ""
        Dim dt As DataTable = New ObraPersonaContacto2().Filter(New StringFilterItem("IDPersona", AdvSearch1.Text))
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            texto = dt.Rows(0)("Nombre") & " Tlf: " & dt.Rows(0)("Telefono1")
        End If

        TextBox1.Text = texto
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Dim direccion As String = ""
            Dim dt As DataTable = New ClienteDireccion().Filter(New StringFilterItem("IDCliente", AdvIDCliente.Text))
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                Dim contador As Integer = 0
                For Each dr As DataRow In dt.Rows
                    If dr("Envio").Equals(True) Then
                        direccion = dr("IDDireccion")
                        Me.CurrentRow("IDDireccion") = direccion
                        Me.RecordsState = RecordsState.Modified
                        MsgBox("Dirección Asignada con exito.")
                        Exit For
                    End If
                    contador += 1
                Next
            End If
        Catch ex As Exception
            MsgBox("ERROR")
        End Try

    End Sub

    Private Sub AdvIDCliente_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDCliente.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("IDCliente", 4300000000))
    End Sub

    Private Sub AdvIDCliente_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDCliente.SelectionChanged
        txtDireccion.Text = AdvIDCliente.SelectedRow.Item("Direccion")
        txtCodPostal.Text = AdvIDCliente.SelectedRow.Item("CodPostal")
        txtPoblacion.Text = AdvIDCliente.SelectedRow.Item("Poblacion")
        txtProvincia.Text = AdvIDCliente.SelectedRow.Item("Provincia")
        Dim direccion As String = ""
        Dim dt As DataTable = New ClienteDireccion().Filter(New StringFilterItem("IDCliente", AdvIDCliente.Text))
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            Dim contador As Integer = 0
            For Each dr As DataRow In dt.Rows
                If dr("Envio").Equals(True) Then
                    direccion = dr("IDDireccion")
                    Me.CurrentRow("IDDireccion") = direccion
                    Me.RecordsState = RecordsState.Modified
                    Exit For
                End If
                contador += 1
            Next
        End If
    End Sub
    'David Velasco 21/06/22 HILTI
    Private Sub bGenerarAlbaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGenerarAlbaran.Click
        'Paso 1: Crea orden de Servicio(ya checkeado que no existe ese Excel)
        creaOrdendeServicio()
        'Paso 2: Inserccion del Excel
    End Sub

    Private Sub NuevaOrdenHilti(ByVal IDTrabajo As Integer, ByVal obra As ObraDatos)
        If Length(Me.CurrentRow("IDTipoObra")) > 0 AndAlso Length(Me.CurrentRow("IDDireccion")) > 0 Then
            Dim frm As New FrmAddOrden
            Dim dr As DataRow = frm.AbrirAltaOrdenHilti(Me.CurrentRow("IDObra"), Me.CurrentRow("IDTipoObra"), AdvIDCliente.Text, ulDescCliente.Text, _
                                                   Me.CurrentRow("IDDireccion"), txtDireccion.Text, txtPoblacion.Text, txtProvincia.Text, _
                                                   txtCodPostal.Text, txtCifCliente.Text, "-", CurrentRow("TextoCliente") & String.Empty, _
                                                   Nz(Me.CurrentRow("FianzaObligatoria"), False), IDTrabajo, Me.CurrentRow("IDCentroGestion") & String.Empty, obra)
            IDTrabajo = 0

            If Not IsNothing(dr) Then
                dr("Secuencia") = (ndTrabajos.Data.Rows.Count + 1) * 10
                ndTrabajos.Data.Rows.Add(dr.ItemArray)
                Me.RecordsState = RecordsState.Modified
                dtTrabajos = ndTrabajos.Data
                RefreshArbolTrabajos()
                FiltrarGridTrabajos()
            End If
        Else
            ExpertisApp.GenerateMessage("El Tipo Alquiler y la dirección del Cliente son datos necesarios para poder dar de alta Ordenes.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Sub creaOrdendeServicio()
        Dim obra As New ObraDatos
        obra = compruebaExcel()

        If obra.ruta.ToString.Length = 0 Then
            MsgBox("Este Excel con este nombre y ubicacion ya ha sido insertado anteriormente.")
        Else
            NuevaOrdenHilti(0, obra)
            blnRefreshArbol = True
            Me.UpdateChanges()
        End If

    End Sub
    Public Function compruebaExcel() As ObraDatos
        'Paso 0: Checkear si el Excel existe
        Dim obra As New ObraDatos

        Dim openFD As New OpenFileDialog()
        openFD.Title = "Seleccionar archivos"
        openFD.Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
        openFD.Multiselect = False
        openFD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        If openFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            obra.ruta = openFD.FileName
        End If
        Dim filtro As New Filter
        filtro.Add("nombreExcel", FilterOperator.Equal, obra.ruta)
        Dim tb As New DataTable
        tb = New BE.DataEngine().Filter("VFrmAlquilerTrabajos", filtro)

        If tb.Rows.Count > 0 Then
            obra.ruta = ""
            Return obra
        Else
            'Recupero el Excel en tabla según formato
            Dim hoja As String
            Dim rango As String
            hoja = "Hoja1"
            rango = "A1:B100"
            obra.dt.Columns.Add("IDArticulo")
            obra.dt.Columns.Add("Cantidad")
            'obra.dt.Columns.Add("Almacen")
            obra.dt = ObtenerDatosExcel(obra.ruta, hoja, rango)
            Return obra
        End If
    End Function
    Public Function ObtenerDatosExcel(ByVal ruta As String, ByVal hoja As String, ByVal rango As String) As DataTable
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & ruta & "';Extended Properties=Excel 12.0;")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [" & hoja & "$" & rango & "]", MyConnection)
        'MyCommand.TableMappings.Add("Table", "Net-informations.com")
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        Dim dt As DataTable = DtSet.Tables(0)
        MyConnection.Close()

        Return dt
    End Function

    Private Sub bCreaAlbaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCreaAlbaran.Click
        NuevaOrden(0)
    End Sub
End Class
