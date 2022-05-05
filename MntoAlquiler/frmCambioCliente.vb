Public Class frmCambioCliente
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
    Friend WithEvents fraDatosNuevos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents fraCondicionesPortes As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents advIDFormaPagoNew As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulDescFormaPagoNew As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents chkAlbaranValoradoNew As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblCampoObligatorio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDClienteBancoNew As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblClienteBancoNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescClienteBancoNew As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advIDMonedaNew As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulDescMonedaNew As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cbxTipoGeneracionSeguroNew As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents chkFacturarTasaResiduosNew As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents advIDCondicionEnvioNew As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCondicionEnvioNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescCondicionEnvioNew As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advIDDiaPagoNew As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblDiaPagoNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescDiaPagoNew As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advIDCondicionPagoNew As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulDescCondicionPagoNew As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advIDClienteNew As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulDescClienteNew As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents fraDatosActuales As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents txtIDClienteBanco As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblClienteBanco As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxTipoGeneracionSeguros As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblTipoGeneracionSeguros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chkAlbaranValorado As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkFacturarTasaResiduos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents txtIDMoneda As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblMoneda As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIDCondicionEnvio As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCondicionEnvio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIDDiaPago As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblDiaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIDCondicionPago As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCondicionPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIDFormaPago As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFormaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIDCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFwiDescCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescFormaPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulDescCondicionPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulDescDiaPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulDescCondicionEnvio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulDescMoneda As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents optPortesObra As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents optPortesCliente As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents lblClienteNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFormaPagoNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCondicionPagoNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblMonedaNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbOK As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblTipoGeneracionSeguroNew As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cbxTipoGeneracionSeguroNew_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambioCliente))
        Dim cbxTipoGeneracionSeguros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.fraDatosNuevos = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTipoGeneracionSeguroNew = New Solmicro.Expertis.Engine.UI.Label
        Me.lblMonedaNew = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCondicionPagoNew = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFormaPagoNew = New Solmicro.Expertis.Engine.UI.Label
        Me.lblClienteNew = New Solmicro.Expertis.Engine.UI.Label
        Me.fraCondicionesPortes = New Solmicro.Expertis.Engine.UI.Frame
        Me.optPortesCliente = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.optPortesObra = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.ulDescFormaPagoNew = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDFormaPagoNew = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.chkAlbaranValoradoNew = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblCampoObligatorio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblClienteBancoNew = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescClienteBancoNew = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDClienteBancoNew = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescMonedaNew = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDMonedaNew = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cbxTipoGeneracionSeguroNew = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.chkFacturarTasaResiduosNew = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblCondicionEnvioNew = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescCondicionEnvioNew = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDCondicionEnvioNew = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescCondicionPagoNew = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblDiaPagoNew = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescDiaPagoNew = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDDiaPagoNew = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDCondicionPagoNew = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescClienteNew = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDClienteNew = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.fraDatosActuales = New Solmicro.Expertis.Engine.UI.Frame
        Me.ulDescMoneda = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulDescCondicionEnvio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulDescDiaPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulDescCondicionPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulDescFormaPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblClienteBanco = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDClienteBanco = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTipoGeneracionSeguros = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoGeneracionSeguros = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.chkAlbaranValorado = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkFacturarTasaResiduos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblMoneda = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDMoneda = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCondicionEnvio = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDCondicionEnvio = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDiaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDDiaPago = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCondicionPago = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDCondicionPago = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDFormaPago = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwiDescCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cmbOK = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.fraDatosNuevos.SuspendLayout()
        Me.fraCondicionesPortes.SuspendLayout()
        CType(Me.cbxTipoGeneracionSeguroNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDatosActuales.SuspendLayout()
        CType(Me.cbxTipoGeneracionSeguros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraDatosNuevos
        '
        Me.fraDatosNuevos.Controls.Add(Me.lblTipoGeneracionSeguroNew)
        Me.fraDatosNuevos.Controls.Add(Me.lblMonedaNew)
        Me.fraDatosNuevos.Controls.Add(Me.lblCondicionPagoNew)
        Me.fraDatosNuevos.Controls.Add(Me.lblFormaPagoNew)
        Me.fraDatosNuevos.Controls.Add(Me.lblClienteNew)
        Me.fraDatosNuevos.Controls.Add(Me.fraCondicionesPortes)
        Me.fraDatosNuevos.Controls.Add(Me.ulDescFormaPagoNew)
        Me.fraDatosNuevos.Controls.Add(Me.advIDFormaPagoNew)
        Me.fraDatosNuevos.Controls.Add(Me.chkAlbaranValoradoNew)
        Me.fraDatosNuevos.Controls.Add(Me.lblCampoObligatorio)
        Me.fraDatosNuevos.Controls.Add(Me.lblClienteBancoNew)
        Me.fraDatosNuevos.Controls.Add(Me.ulDescClienteBancoNew)
        Me.fraDatosNuevos.Controls.Add(Me.advIDClienteBancoNew)
        Me.fraDatosNuevos.Controls.Add(Me.ulDescMonedaNew)
        Me.fraDatosNuevos.Controls.Add(Me.advIDMonedaNew)
        Me.fraDatosNuevos.Controls.Add(Me.cbxTipoGeneracionSeguroNew)
        Me.fraDatosNuevos.Controls.Add(Me.chkFacturarTasaResiduosNew)
        Me.fraDatosNuevos.Controls.Add(Me.lblCondicionEnvioNew)
        Me.fraDatosNuevos.Controls.Add(Me.ulDescCondicionEnvioNew)
        Me.fraDatosNuevos.Controls.Add(Me.advIDCondicionEnvioNew)
        Me.fraDatosNuevos.Controls.Add(Me.lblDiaPagoNew)
        Me.fraDatosNuevos.Controls.Add(Me.ulDescDiaPagoNew)
        Me.fraDatosNuevos.Controls.Add(Me.advIDDiaPagoNew)
        Me.fraDatosNuevos.Controls.Add(Me.ulDescCondicionPagoNew)
        Me.fraDatosNuevos.Controls.Add(Me.advIDCondicionPagoNew)
        Me.fraDatosNuevos.Controls.Add(Me.ulDescClienteNew)
        Me.fraDatosNuevos.Controls.Add(Me.advIDClienteNew)
        Me.fraDatosNuevos.Location = New System.Drawing.Point(0, 176)
        Me.fraDatosNuevos.Name = "fraDatosNuevos"
        Me.fraDatosNuevos.Size = New System.Drawing.Size(780, 229)
        Me.fraDatosNuevos.TabIndex = 13
        Me.fraDatosNuevos.TabStop = False
        Me.fraDatosNuevos.Text = "Datos nuevos"
        '
        'lblTipoGeneracionSeguroNew
        '
        Me.lblTipoGeneracionSeguroNew.Location = New System.Drawing.Point(424, 57)
        Me.lblTipoGeneracionSeguroNew.Name = "lblTipoGeneracionSeguroNew"
        Me.lblTipoGeneracionSeguroNew.Size = New System.Drawing.Size(152, 13)
        Me.lblTipoGeneracionSeguroNew.TabIndex = 47
        Me.lblTipoGeneracionSeguroNew.Text = "Tipo Importe Seguros (*)"
        '
        'lblMonedaNew
        '
        Me.lblMonedaNew.Location = New System.Drawing.Point(8, 159)
        Me.lblMonedaNew.Name = "lblMonedaNew"
        Me.lblMonedaNew.Size = New System.Drawing.Size(72, 13)
        Me.lblMonedaNew.TabIndex = 46
        Me.lblMonedaNew.Text = "Moneda (*)"
        '
        'lblCondicionPagoNew
        '
        Me.lblCondicionPagoNew.Location = New System.Drawing.Point(8, 81)
        Me.lblCondicionPagoNew.Name = "lblCondicionPagoNew"
        Me.lblCondicionPagoNew.Size = New System.Drawing.Size(133, 13)
        Me.lblCondicionPagoNew.TabIndex = 45
        Me.lblCondicionPagoNew.Text = "Condición de Pago (*)"
        '
        'lblFormaPagoNew
        '
        Me.lblFormaPagoNew.Location = New System.Drawing.Point(8, 55)
        Me.lblFormaPagoNew.Name = "lblFormaPagoNew"
        Me.lblFormaPagoNew.Size = New System.Drawing.Size(114, 13)
        Me.lblFormaPagoNew.TabIndex = 44
        Me.lblFormaPagoNew.Text = "Forma de Pago (*)"
        '
        'lblClienteNew
        '
        Me.lblClienteNew.Location = New System.Drawing.Point(8, 29)
        Me.lblClienteNew.Name = "lblClienteNew"
        Me.lblClienteNew.Size = New System.Drawing.Size(67, 13)
        Me.lblClienteNew.TabIndex = 43
        Me.lblClienteNew.Text = "Cliente (*)"
        '
        'fraCondicionesPortes
        '
        Me.fraCondicionesPortes.Controls.Add(Me.optPortesCliente)
        Me.fraCondicionesPortes.Controls.Add(Me.optPortesObra)
        Me.fraCondicionesPortes.Location = New System.Drawing.Point(424, 103)
        Me.fraCondicionesPortes.Name = "fraCondicionesPortes"
        Me.fraCondicionesPortes.Size = New System.Drawing.Size(348, 89)
        Me.fraCondicionesPortes.TabIndex = 24
        Me.fraCondicionesPortes.TabStop = False
        Me.fraCondicionesPortes.Text = "Condiciones de los Portes"
        '
        'optPortesCliente
        '
        Me.optPortesCliente.Location = New System.Drawing.Point(8, 50)
        Me.optPortesCliente.Name = "optPortesCliente"
        Me.optPortesCliente.Size = New System.Drawing.Size(320, 30)
        Me.optPortesCliente.TabIndex = 1
        Me.optPortesCliente.Text = "Cargar las condiciones especiales de portes asignadas al nuevo cliente "
        '
        'optPortesObra
        '
        Me.optPortesObra.Location = New System.Drawing.Point(8, 17)
        Me.optPortesObra.Name = "optPortesObra"
        Me.optPortesObra.Size = New System.Drawing.Size(320, 31)
        Me.optPortesObra.TabIndex = 0
        Me.optPortesObra.Text = "Mantener las condiciones de los portes dadas de alta en el Alquiler."
        '
        'ulDescFormaPagoNew
        '
        Me.ulDescFormaPagoNew.Location = New System.Drawing.Point(231, 50)
        Me.ulDescFormaPagoNew.Name = "ulDescFormaPagoNew"
        Me.ulDescFormaPagoNew.Size = New System.Drawing.Size(187, 23)
        Me.ulDescFormaPagoNew.TabIndex = 26
        '
        'advIDFormaPagoNew
        '
        Me.advIDFormaPagoNew.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescFormaPago", ulDescFormaPagoNew)})
        Me.advIDFormaPagoNew.DisabledBackColor = System.Drawing.Color.White
        Me.advIDFormaPagoNew.EntityName = "FormaPago"
        Me.advIDFormaPagoNew.Location = New System.Drawing.Point(145, 50)
        Me.advIDFormaPagoNew.Name = "advIDFormaPagoNew"
        Me.advIDFormaPagoNew.SecondaryDataFields = "IDFormaPago"
        Me.advIDFormaPagoNew.Size = New System.Drawing.Size(82, 23)
        Me.advIDFormaPagoNew.TabIndex = 1
        Me.advIDFormaPagoNew.ViewName = "tbMaestroFormaPago"
        '
        'chkAlbaranValoradoNew
        '
        Me.chkAlbaranValoradoNew.Location = New System.Drawing.Point(8, 200)
        Me.chkAlbaranValoradoNew.Name = "chkAlbaranValoradoNew"
        Me.chkAlbaranValoradoNew.Size = New System.Drawing.Size(164, 21)
        Me.chkAlbaranValoradoNew.TabIndex = 7
        Me.chkAlbaranValoradoNew.Text = "Albarán Valorado"
        '
        'lblCampoObligatorio
        '
        Me.lblCampoObligatorio.Location = New System.Drawing.Point(613, 202)
        Me.lblCampoObligatorio.Name = "lblCampoObligatorio"
        Me.lblCampoObligatorio.Size = New System.Drawing.Size(150, 13)
        Me.lblCampoObligatorio.TabIndex = 29
        Me.lblCampoObligatorio.Text = "(*) Campo obligatorio"
        '
        'lblClienteBancoNew
        '
        Me.lblClienteBancoNew.AutoSize = False
        Me.lblClienteBancoNew.Location = New System.Drawing.Point(424, 82)
        Me.lblClienteBancoNew.Name = "lblClienteBancoNew"
        Me.lblClienteBancoNew.Size = New System.Drawing.Size(86, 13)
        Me.lblClienteBancoNew.TabIndex = 30
        Me.lblClienteBancoNew.Text = "Cliente Banco"
        '
        'ulDescClienteBancoNew
        '
        Me.ulDescClienteBancoNew.Location = New System.Drawing.Point(670, 77)
        Me.ulDescClienteBancoNew.Name = "ulDescClienteBancoNew"
        Me.ulDescClienteBancoNew.Size = New System.Drawing.Size(102, 23)
        Me.ulDescClienteBancoNew.TabIndex = 31
        '
        'advIDClienteBancoNew
        '
        Me.advIDClienteBancoNew.DisabledBackColor = System.Drawing.Color.White
        Me.advIDClienteBancoNew.EntityName = "ClienteBanco"
        Me.advIDClienteBancoNew.Location = New System.Drawing.Point(580, 77)
        Me.advIDClienteBancoNew.Name = "advIDClienteBancoNew"
        Me.advIDClienteBancoNew.SecondaryDataFields = "IDClienteBanco"
        Me.advIDClienteBancoNew.Size = New System.Drawing.Size(86, 23)
        Me.advIDClienteBancoNew.TabIndex = 9
        Me.advIDClienteBancoNew.ViewName = "tbClienteBanco"
        '
        'ulDescMonedaNew
        '
        Me.ulDescMonedaNew.Location = New System.Drawing.Point(231, 154)
        Me.ulDescMonedaNew.Name = "ulDescMonedaNew"
        Me.ulDescMonedaNew.Size = New System.Drawing.Size(187, 23)
        Me.ulDescMonedaNew.TabIndex = 33
        '
        'advIDMonedaNew
        '
        Me.advIDMonedaNew.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescMoneda", ulDescMonedaNew)})
        Me.advIDMonedaNew.DisabledBackColor = System.Drawing.Color.White
        Me.advIDMonedaNew.EntityName = "Moneda"
        Me.advIDMonedaNew.Location = New System.Drawing.Point(145, 154)
        Me.advIDMonedaNew.Name = "advIDMonedaNew"
        Me.advIDMonedaNew.SecondaryDataFields = "IDMoneda"
        Me.advIDMonedaNew.Size = New System.Drawing.Size(82, 23)
        Me.advIDMonedaNew.TabIndex = 5
        Me.advIDMonedaNew.ViewName = "tbMaestroMoneda"
        '
        'cbxTipoGeneracionSeguroNew
        '
        cbxTipoGeneracionSeguroNew_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoGeneracionSeguroNew_DesignTimeLayout.LayoutString")
        Me.cbxTipoGeneracionSeguroNew.DesignTimeLayout = cbxTipoGeneracionSeguroNew_DesignTimeLayout
        Me.cbxTipoGeneracionSeguroNew.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoGeneracionSeguroNew.Location = New System.Drawing.Point(580, 53)
        Me.cbxTipoGeneracionSeguroNew.Name = "cbxTipoGeneracionSeguroNew"
        Me.cbxTipoGeneracionSeguroNew.SelectedIndex = -1
        Me.cbxTipoGeneracionSeguroNew.SelectedItem = Nothing
        Me.cbxTipoGeneracionSeguroNew.Size = New System.Drawing.Size(192, 21)
        Me.cbxTipoGeneracionSeguroNew.TabIndex = 8
        '
        'chkFacturarTasaResiduosNew
        '
        Me.chkFacturarTasaResiduosNew.Location = New System.Drawing.Point(8, 178)
        Me.chkFacturarTasaResiduosNew.Name = "chkFacturarTasaResiduosNew"
        Me.chkFacturarTasaResiduosNew.Size = New System.Drawing.Size(184, 21)
        Me.chkFacturarTasaResiduosNew.TabIndex = 6
        Me.chkFacturarTasaResiduosNew.Text = "Facturar Tasa de Residuos"
        '
        'lblCondicionEnvioNew
        '
        Me.lblCondicionEnvioNew.Location = New System.Drawing.Point(8, 133)
        Me.lblCondicionEnvioNew.Name = "lblCondicionEnvioNew"
        Me.lblCondicionEnvioNew.Size = New System.Drawing.Size(116, 13)
        Me.lblCondicionEnvioNew.TabIndex = 35
        Me.lblCondicionEnvioNew.Text = "Condición de Envio"
        '
        'ulDescCondicionEnvioNew
        '
        Me.ulDescCondicionEnvioNew.Location = New System.Drawing.Point(231, 128)
        Me.ulDescCondicionEnvioNew.Name = "ulDescCondicionEnvioNew"
        Me.ulDescCondicionEnvioNew.Size = New System.Drawing.Size(187, 23)
        Me.ulDescCondicionEnvioNew.TabIndex = 36
        '
        'advIDCondicionEnvioNew
        '
        Me.advIDCondicionEnvioNew.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCondicionEnvio", ulDescCondicionPagoNew)})
        Me.advIDCondicionEnvioNew.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCondicionEnvioNew.EntityName = "CondicionEnvio"
        Me.advIDCondicionEnvioNew.Location = New System.Drawing.Point(145, 128)
        Me.advIDCondicionEnvioNew.Name = "advIDCondicionEnvioNew"
        Me.advIDCondicionEnvioNew.SecondaryDataFields = "IDCondicionEnvio"
        Me.advIDCondicionEnvioNew.Size = New System.Drawing.Size(82, 23)
        Me.advIDCondicionEnvioNew.TabIndex = 4
        Me.advIDCondicionEnvioNew.ViewName = "tbMaestroCondicionEnvio"
        '
        'ulDescCondicionPagoNew
        '
        Me.ulDescCondicionPagoNew.Location = New System.Drawing.Point(231, 76)
        Me.ulDescCondicionPagoNew.Name = "ulDescCondicionPagoNew"
        Me.ulDescCondicionPagoNew.Size = New System.Drawing.Size(187, 23)
        Me.ulDescCondicionPagoNew.TabIndex = 40
        '
        'lblDiaPagoNew
        '
        Me.lblDiaPagoNew.AutoSize = False
        Me.lblDiaPagoNew.Location = New System.Drawing.Point(8, 107)
        Me.lblDiaPagoNew.Name = "lblDiaPagoNew"
        Me.lblDiaPagoNew.Size = New System.Drawing.Size(76, 13)
        Me.lblDiaPagoNew.TabIndex = 37
        Me.lblDiaPagoNew.Text = "Día de Pago"
        '
        'ulDescDiaPagoNew
        '
        Me.ulDescDiaPagoNew.Location = New System.Drawing.Point(231, 102)
        Me.ulDescDiaPagoNew.Name = "ulDescDiaPagoNew"
        Me.ulDescDiaPagoNew.Size = New System.Drawing.Size(187, 23)
        Me.ulDescDiaPagoNew.TabIndex = 38
        '
        'advIDDiaPagoNew
        '
        Me.advIDDiaPagoNew.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescDiaPago", ulDescDiaPagoNew)})
        Me.advIDDiaPagoNew.DisabledBackColor = System.Drawing.Color.White
        Me.advIDDiaPagoNew.EntityName = "DiaPago"
        Me.advIDDiaPagoNew.Location = New System.Drawing.Point(145, 102)
        Me.advIDDiaPagoNew.Name = "advIDDiaPagoNew"
        Me.advIDDiaPagoNew.SecondaryDataFields = "IDDiaPago"
        Me.advIDDiaPagoNew.Size = New System.Drawing.Size(82, 23)
        Me.advIDDiaPagoNew.TabIndex = 3
        Me.advIDDiaPagoNew.ViewName = "tbMaestroDiaPago"
        '
        'advIDCondicionPagoNew
        '
        Me.advIDCondicionPagoNew.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCondicionPago", ulDescCondicionPagoNew)})
        Me.advIDCondicionPagoNew.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCondicionPagoNew.EntityName = "CondicionPago"
        Me.advIDCondicionPagoNew.Location = New System.Drawing.Point(145, 76)
        Me.advIDCondicionPagoNew.Name = "advIDCondicionPagoNew"
        Me.advIDCondicionPagoNew.SecondaryDataFields = "IDCondicionPago"
        Me.advIDCondicionPagoNew.Size = New System.Drawing.Size(82, 23)
        Me.advIDCondicionPagoNew.TabIndex = 2
        Me.advIDCondicionPagoNew.ViewName = "tbMaestroCondicionPago"
        '
        'ulDescClienteNew
        '
        Me.ulDescClienteNew.Location = New System.Drawing.Point(231, 24)
        Me.ulDescClienteNew.Name = "ulDescClienteNew"
        Me.ulDescClienteNew.Size = New System.Drawing.Size(541, 23)
        Me.ulDescClienteNew.TabIndex = 42
        '
        'advIDClienteNew
        '
        Me.advIDClienteNew.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCliente", ulDescClienteNew)})
        Me.advIDClienteNew.DisabledBackColor = System.Drawing.Color.White
        Me.advIDClienteNew.EntityName = "Cliente"
        Me.advIDClienteNew.Location = New System.Drawing.Point(79, 24)
        Me.advIDClienteNew.Name = "advIDClienteNew"
        Me.advIDClienteNew.SecondaryDataFields = "IDCliente"
        Me.advIDClienteNew.Size = New System.Drawing.Size(148, 23)
        Me.advIDClienteNew.TabIndex = 0
        Me.advIDClienteNew.ViewName = "tbMaestroCliente"
        '
        'fraDatosActuales
        '
        Me.fraDatosActuales.Controls.Add(Me.ulDescMoneda)
        Me.fraDatosActuales.Controls.Add(Me.ulDescCondicionEnvio)
        Me.fraDatosActuales.Controls.Add(Me.ulDescDiaPago)
        Me.fraDatosActuales.Controls.Add(Me.ulDescCondicionPago)
        Me.fraDatosActuales.Controls.Add(Me.ulDescFormaPago)
        Me.fraDatosActuales.Controls.Add(Me.lblClienteBanco)
        Me.fraDatosActuales.Controls.Add(Me.txtIDClienteBanco)
        Me.fraDatosActuales.Controls.Add(Me.lblTipoGeneracionSeguros)
        Me.fraDatosActuales.Controls.Add(Me.cbxTipoGeneracionSeguros)
        Me.fraDatosActuales.Controls.Add(Me.chkAlbaranValorado)
        Me.fraDatosActuales.Controls.Add(Me.chkFacturarTasaResiduos)
        Me.fraDatosActuales.Controls.Add(Me.lblMoneda)
        Me.fraDatosActuales.Controls.Add(Me.txtIDMoneda)
        Me.fraDatosActuales.Controls.Add(Me.lblCondicionEnvio)
        Me.fraDatosActuales.Controls.Add(Me.txtIDCondicionEnvio)
        Me.fraDatosActuales.Controls.Add(Me.lblDiaPago)
        Me.fraDatosActuales.Controls.Add(Me.txtIDDiaPago)
        Me.fraDatosActuales.Controls.Add(Me.lblCondicionPago)
        Me.fraDatosActuales.Controls.Add(Me.txtIDCondicionPago)
        Me.fraDatosActuales.Controls.Add(Me.lblFormaPago)
        Me.fraDatosActuales.Controls.Add(Me.txtIDFormaPago)
        Me.fraDatosActuales.Controls.Add(Me.lblCliente)
        Me.fraDatosActuales.Controls.Add(Me.txtIDCliente)
        Me.fraDatosActuales.Controls.Add(Me.lblFwiDescCliente)
        Me.fraDatosActuales.Controls.Add(Me.txtDescCliente)
        Me.fraDatosActuales.Location = New System.Drawing.Point(0, 0)
        Me.fraDatosActuales.Name = "fraDatosActuales"
        Me.fraDatosActuales.Size = New System.Drawing.Size(780, 176)
        Me.fraDatosActuales.TabIndex = 0
        Me.fraDatosActuales.TabStop = False
        Me.fraDatosActuales.Text = "Datos actuales"
        '
        'ulDescMoneda
        '
        Me.ulDescMoneda.Location = New System.Drawing.Point(212, 144)
        Me.ulDescMoneda.Name = "ulDescMoneda"
        Me.ulDescMoneda.Size = New System.Drawing.Size(223, 21)
        Me.ulDescMoneda.TabIndex = 35
        '
        'ulDescCondicionEnvio
        '
        Me.ulDescCondicionEnvio.Location = New System.Drawing.Point(212, 120)
        Me.ulDescCondicionEnvio.Name = "ulDescCondicionEnvio"
        Me.ulDescCondicionEnvio.Size = New System.Drawing.Size(223, 21)
        Me.ulDescCondicionEnvio.TabIndex = 34
        '
        'ulDescDiaPago
        '
        Me.ulDescDiaPago.Location = New System.Drawing.Point(212, 96)
        Me.ulDescDiaPago.Name = "ulDescDiaPago"
        Me.ulDescDiaPago.Size = New System.Drawing.Size(223, 21)
        Me.ulDescDiaPago.TabIndex = 33
        '
        'ulDescCondicionPago
        '
        Me.ulDescCondicionPago.Location = New System.Drawing.Point(212, 72)
        Me.ulDescCondicionPago.Name = "ulDescCondicionPago"
        Me.ulDescCondicionPago.Size = New System.Drawing.Size(223, 21)
        Me.ulDescCondicionPago.TabIndex = 32
        '
        'ulDescFormaPago
        '
        Me.ulDescFormaPago.Location = New System.Drawing.Point(212, 48)
        Me.ulDescFormaPago.Name = "ulDescFormaPago"
        Me.ulDescFormaPago.Size = New System.Drawing.Size(223, 21)
        Me.ulDescFormaPago.TabIndex = 31
        '
        'lblClienteBanco
        '
        Me.lblClienteBanco.Location = New System.Drawing.Point(443, 124)
        Me.lblClienteBanco.Name = "lblClienteBanco"
        Me.lblClienteBanco.Size = New System.Drawing.Size(86, 13)
        Me.lblClienteBanco.TabIndex = 0
        Me.lblClienteBanco.Text = "Cliente Banco"
        '
        'txtIDClienteBanco
        '
        Me.txtIDClienteBanco.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDClienteBanco.Enabled = False
        Me.txtIDClienteBanco.Location = New System.Drawing.Point(580, 120)
        Me.txtIDClienteBanco.Name = "txtIDClienteBanco"
        Me.txtIDClienteBanco.Size = New System.Drawing.Size(78, 21)
        Me.txtIDClienteBanco.TabIndex = 10
        '
        'lblTipoGeneracionSeguros
        '
        Me.lblTipoGeneracionSeguros.Location = New System.Drawing.Point(443, 100)
        Me.lblTipoGeneracionSeguros.Name = "lblTipoGeneracionSeguros"
        Me.lblTipoGeneracionSeguros.Size = New System.Drawing.Size(132, 13)
        Me.lblTipoGeneracionSeguros.TabIndex = 23
        Me.lblTipoGeneracionSeguros.Text = "Tipo Importe Seguros"
        '
        'cbxTipoGeneracionSeguros
        '
        cbxTipoGeneracionSeguros_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoGeneracionSeguros_DesignTimeLayout.LayoutString")
        Me.cbxTipoGeneracionSeguros.DesignTimeLayout = cbxTipoGeneracionSeguros_DesignTimeLayout
        Me.cbxTipoGeneracionSeguros.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoGeneracionSeguros.Enabled = False
        Me.cbxTipoGeneracionSeguros.Location = New System.Drawing.Point(580, 96)
        Me.cbxTipoGeneracionSeguros.Name = "cbxTipoGeneracionSeguros"
        Me.cbxTipoGeneracionSeguros.SelectedIndex = -1
        Me.cbxTipoGeneracionSeguros.SelectedItem = Nothing
        Me.cbxTipoGeneracionSeguros.Size = New System.Drawing.Size(192, 21)
        Me.cbxTipoGeneracionSeguros.TabIndex = 9
        '
        'chkAlbaranValorado
        '
        Me.chkAlbaranValorado.Enabled = False
        Me.chkAlbaranValorado.Location = New System.Drawing.Point(443, 72)
        Me.chkAlbaranValorado.Name = "chkAlbaranValorado"
        Me.chkAlbaranValorado.Size = New System.Drawing.Size(160, 21)
        Me.chkAlbaranValorado.TabIndex = 8
        Me.chkAlbaranValorado.Text = "Albarán Valorado"
        '
        'chkFacturarTasaResiduos
        '
        Me.chkFacturarTasaResiduos.Enabled = False
        Me.chkFacturarTasaResiduos.Location = New System.Drawing.Point(443, 48)
        Me.chkFacturarTasaResiduos.Name = "chkFacturarTasaResiduos"
        Me.chkFacturarTasaResiduos.Size = New System.Drawing.Size(192, 21)
        Me.chkFacturarTasaResiduos.TabIndex = 7
        Me.chkFacturarTasaResiduos.Text = "Facturar Tasa de Residuos"
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(8, 148)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(51, 13)
        Me.lblMoneda.TabIndex = 24
        Me.lblMoneda.Text = "Moneda"
        '
        'txtIDMoneda
        '
        Me.txtIDMoneda.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDMoneda.Enabled = False
        Me.txtIDMoneda.Location = New System.Drawing.Point(126, 144)
        Me.txtIDMoneda.Name = "txtIDMoneda"
        Me.txtIDMoneda.Size = New System.Drawing.Size(82, 21)
        Me.txtIDMoneda.TabIndex = 6
        '
        'lblCondicionEnvio
        '
        Me.lblCondicionEnvio.Location = New System.Drawing.Point(8, 124)
        Me.lblCondicionEnvio.Name = "lblCondicionEnvio"
        Me.lblCondicionEnvio.Size = New System.Drawing.Size(116, 13)
        Me.lblCondicionEnvio.TabIndex = 25
        Me.lblCondicionEnvio.Text = "Condición de Envío"
        '
        'txtIDCondicionEnvio
        '
        Me.txtIDCondicionEnvio.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDCondicionEnvio.Enabled = False
        Me.txtIDCondicionEnvio.Location = New System.Drawing.Point(126, 120)
        Me.txtIDCondicionEnvio.Name = "txtIDCondicionEnvio"
        Me.txtIDCondicionEnvio.Size = New System.Drawing.Size(82, 21)
        Me.txtIDCondicionEnvio.TabIndex = 5
        '
        'lblDiaPago
        '
        Me.lblDiaPago.Location = New System.Drawing.Point(8, 100)
        Me.lblDiaPago.Name = "lblDiaPago"
        Me.lblDiaPago.Size = New System.Drawing.Size(76, 13)
        Me.lblDiaPago.TabIndex = 26
        Me.lblDiaPago.Text = "Día de Pago"
        '
        'txtIDDiaPago
        '
        Me.txtIDDiaPago.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDDiaPago.Enabled = False
        Me.txtIDDiaPago.Location = New System.Drawing.Point(126, 96)
        Me.txtIDDiaPago.Name = "txtIDDiaPago"
        Me.txtIDDiaPago.Size = New System.Drawing.Size(82, 21)
        Me.txtIDDiaPago.TabIndex = 4
        '
        'lblCondicionPago
        '
        Me.lblCondicionPago.Location = New System.Drawing.Point(8, 76)
        Me.lblCondicionPago.Name = "lblCondicionPago"
        Me.lblCondicionPago.Size = New System.Drawing.Size(113, 13)
        Me.lblCondicionPago.TabIndex = 27
        Me.lblCondicionPago.Text = "Condición de Pago"
        '
        'txtIDCondicionPago
        '
        Me.txtIDCondicionPago.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDCondicionPago.Enabled = False
        Me.txtIDCondicionPago.Location = New System.Drawing.Point(126, 72)
        Me.txtIDCondicionPago.Name = "txtIDCondicionPago"
        Me.txtIDCondicionPago.Size = New System.Drawing.Size(82, 21)
        Me.txtIDCondicionPago.TabIndex = 3
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Location = New System.Drawing.Point(8, 52)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(93, 13)
        Me.lblFormaPago.TabIndex = 28
        Me.lblFormaPago.Text = "Forma de Pago"
        '
        'txtIDFormaPago
        '
        Me.txtIDFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDFormaPago.Enabled = False
        Me.txtIDFormaPago.Location = New System.Drawing.Point(126, 48)
        Me.txtIDFormaPago.Name = "txtIDFormaPago"
        Me.txtIDFormaPago.Size = New System.Drawing.Size(82, 21)
        Me.txtIDFormaPago.TabIndex = 2
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(8, 28)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 29
        Me.lblCliente.Text = "Cliente"
        '
        'txtIDCliente
        '
        Me.txtIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDCliente.Enabled = False
        Me.txtIDCliente.Location = New System.Drawing.Point(60, 24)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(148, 21)
        Me.txtIDCliente.TabIndex = 0
        '
        'lblFwiDescCliente
        '
        Me.lblFwiDescCliente.Location = New System.Drawing.Point(168, 24)
        Me.lblFwiDescCliente.Name = "lblFwiDescCliente"
        Me.lblFwiDescCliente.Size = New System.Drawing.Size(0, 13)
        Me.lblFwiDescCliente.TabIndex = 30
        '
        'txtDescCliente
        '
        Me.txtDescCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescCliente.Enabled = False
        Me.txtDescCliente.Location = New System.Drawing.Point(212, 24)
        Me.txtDescCliente.Name = "txtDescCliente"
        Me.txtDescCliente.Size = New System.Drawing.Size(560, 21)
        Me.txtDescCliente.TabIndex = 1
        '
        'cmbOK
        '
        Me.cmbOK.Location = New System.Drawing.Point(314, 411)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(76, 29)
        Me.cmbOK.TabIndex = 16
        Me.cmbOK.Text = "Aceptar"
        '
        'cmbCancel
        '
        Me.cmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancel.Location = New System.Drawing.Point(395, 411)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(76, 29)
        Me.cmbCancel.TabIndex = 17
        Me.cmbCancel.Text = "Cancelar"
        '
        'frmCambioCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(784, 446)
        Me.Controls.Add(Me.cmbOK)
        Me.Controls.Add(Me.cmbCancel)
        Me.Controls.Add(Me.fraDatosNuevos)
        Me.Controls.Add(Me.fraDatosActuales)
        Me.MaximizeBox = False
        Me.Name = "frmCambioCliente"
        Me.Text = "Cambio de Cliente"
        Me.fraDatosNuevos.ResumeLayout(False)
        Me.fraDatosNuevos.PerformLayout()
        Me.fraCondicionesPortes.ResumeLayout(False)
        CType(Me.cbxTipoGeneracionSeguroNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDatosActuales.ResumeLayout(False)
        Me.fraDatosActuales.PerformLayout()
        CType(Me.cbxTipoGeneracionSeguros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public mIDObra As Integer

#Region " Load "

    Private Sub frmCambioCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDatos()
        LoadEnums()
        lblCampoObligatorio.ForeColor = Color.Red
    End Sub

    Private Sub LoadDatos()
        Dim dttObra As DataTable = New BE.DataEngine().Filter("vAlquilerCambioCliente", New NumberFilterItem("IDObra", mIDObra))
        If dttObra.Rows.Count > 0 Then
            txtIDCliente.Text = dttObra.Rows(0)("IDCliente") & String.Empty
            txtDescCliente.Text = dttObra.Rows(0)("DescCliente") & String.Empty

            txtIDFormaPago.Text = dttObra.Rows(0)("IDFormaPago") & String.Empty
            ulDescFormaPago.Text = dttObra.Rows(0)("DescFormaPago") & String.Empty

            txtIDCondicionPago.Text = dttObra.Rows(0)("IDCondicionPago") & String.Empty
            ulDescCondicionPago.Text = dttObra.Rows(0)("DescCondicionPago") & String.Empty

            txtIDDiaPago.Text = dttObra.Rows(0)("IDDiaPago") & String.Empty
            ulDescDiaPago.Text = dttObra.Rows(0)("DescDiaPago") & String.Empty

            txtIDCondicionEnvio.Text = dttObra.Rows(0)("IDCondicionEnvio") & String.Empty
            ulDescCondicionEnvio.Text = dttObra.Rows(0)("DescCondicionEnvio") & String.Empty

            txtIDMoneda.Text = dttObra.Rows(0)("IDMoneda") & String.Empty
            ulDescMoneda.Text = dttObra.Rows(0)("DescMoneda") & String.Empty

            chkFacturarTasaResiduos.Checked = Nz(dttObra.Rows(0)("FacturarTasaResiduos"), False)
            chkAlbaranValorado.Checked = Nz(dttObra.Rows(0)("AlbaranValorado"), False)
            If Length(dttObra.Rows(0)("TipoGeneracionSeguros")) > 0 Then cbxTipoGeneracionSeguros.Text = dttObra.Rows(0)("TipoGeneracionSeguros")
            If Length(dttObra.Rows(0)("IDClienteBanco")) > 0 Then txtIDClienteBanco.Text = dttObra.Rows(0)("IDClienteBanco")
            optPortesCliente.Checked = True
            advIDClienteBancoNew.Enabled = False
        End If
    End Sub

    Private Sub LoadEnums()
        cbxTipoGeneracionSeguroNew.DataSource = New EnumData("enumocSegurosTipoImporte")
        cbxTipoGeneracionSeguros.DataSource = New EnumData("enumocSegurosTipoImporte")
    End Sub

#End Region

    Private Sub advIDClienteBancoNew_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advIDClienteBancoNew.SetPredefinedFilter
        If Length(advIDClienteNew.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDCliente", advIDClienteNew.Text))
        End If
    End Sub

    Private Sub cmbOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Length(advIDClienteNew.Text) = 0 Or Length(advIDCondicionPagoNew.Text) = 0 Or Length(advIDFormaPagoNew.Text) = 0 Or Length(advIDMonedaNew.Text) = 0 Or Length(cbxTipoGeneracionSeguroNew.Value) = 0 Then
            ExpertisApp.GenerateMessage("Hay que rellenar todos los campos de los datos nuevos del Cliente.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ExpertisApp.GenerateMessage("Se va a cambiar el cliente en toda la estructura del Alquiler. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim data As New ObraCabecera.dataCambiarDatosCliente(mIDObra, advIDClienteNew.Text, advIDFormaPagoNew.Text, advIDCondicionPagoNew.Text, advIDDiaPagoNew.Text & String.Empty, _
                                                                 advIDCondicionEnvioNew.Text, advIDMonedaNew.Text, chkFacturarTasaResiduosNew.Checked, _
                                                                 chkAlbaranValoradoNew.Checked, cbxTipoGeneracionSeguroNew.Value, Nz(advIDClienteBancoNew.Text, -1), optPortesCliente.Checked)

            ExpertisApp.ExecuteTask(Of ObraCabecera.dataCambiarDatosCliente)(AddressOf ObraCabecera.CambiarDatosCliente, data)

            ExpertisApp.GenerateMessage("Actualización finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class
