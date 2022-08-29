Imports Solmicro.Expertis.Business.Negocio

Public Class FrmAddOrden
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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlCliente As System.Windows.Forms.Panel
    Friend WithEvents lblClienteOT As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescClienteOT As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.CounterTextBox
    Friend WithEvents FraDireccionEnvio As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtPedidoCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtTextoCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDireccion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblOrdenServicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaOrden As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaOrden As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaPrevistaRetorno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaPrevistaRetorno As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaEntrega As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblCIF As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDireccion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblProvincia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtProvincia As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCP As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCP As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblPoblacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPoblacion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTextoCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chkFianzaObligatoria As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblFianza As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTexto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTexto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTextoPublico As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTextoPublico As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblPersonaContacto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxIDPersona As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblPedidoCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCIF As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtFianza As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents cmbSearchIDDireccion As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents AdvCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cbxIDPersona_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddOrden))
        Me.lblOrdenServicio = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlCliente = New System.Windows.Forms.Panel
        Me.lblClienteOT = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescClienteOT = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.lblFechaOrden = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaOrden = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaPrevistaRetorno = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaPrevistaRetorno = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaEntrega = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FraDireccionEnvio = New Solmicro.Expertis.Engine.UI.Frame
        Me.cmbSearchIDDireccion = New Solmicro.Expertis.Engine.UI.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblCIF = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCIF = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDireccion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDireccion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblProvincia = New Solmicro.Expertis.Engine.UI.Label
        Me.txtProvincia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCP = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCP = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblPoblacion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPoblacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTextoCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTextoCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.chkFianzaObligatoria = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblFianza = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTexto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTextoPublico = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTextoPublico = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblPersonaContacto = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDPersona = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblPedidoCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPedidoCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtFianza = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Panel1.suspendlayout()
        Me.pnlCliente.SuspendLayout()
        Me.FraDireccionEnvio.SuspendLayout()
        CType(Me.cbxIDPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOrdenServicio
        '
        Me.lblOrdenServicio.Location = New System.Drawing.Point(9, 36)
        Me.lblOrdenServicio.Name = "lblOrdenServicio"
        Me.lblOrdenServicio.Size = New System.Drawing.Size(96, 13)
        Me.lblOrdenServicio.TabIndex = 227
        Me.lblOrdenServicio.Text = "Orden  Servicio"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 419)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 42)
        Me.Panel1.TabIndex = 230
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(280, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 13
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(180, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 12
        Me.CmbAceptar.Text = "Aceptar"
        '
        'pnlCliente
        '
        Me.pnlCliente.BackColor = System.Drawing.SystemColors.Info
        Me.pnlCliente.Controls.Add(Me.lblClienteOT)
        Me.pnlCliente.Controls.Add(Me.ulDescClienteOT)
        Me.pnlCliente.Controls.Add(Me.AdvCliente)
        Me.pnlCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCliente.Location = New System.Drawing.Point(0, 0)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Size = New System.Drawing.Size(554, 29)
        Me.pnlCliente.TabIndex = 240
        '
        'lblClienteOT
        '
        Me.lblClienteOT.Location = New System.Drawing.Point(8, 8)
        Me.lblClienteOT.Name = "lblClienteOT"
        Me.lblClienteOT.Size = New System.Drawing.Size(47, 13)
        Me.lblClienteOT.TabIndex = 97
        Me.lblClienteOT.Text = "Cliente"
        '
        'ulDescClienteOT
        '
        Me.ulDescClienteOT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ulDescClienteOT.Location = New System.Drawing.Point(173, 3)
        Me.ulDescClienteOT.Name = "ulDescClienteOT"
        Me.ulDescClienteOT.Size = New System.Drawing.Size(374, 23)
        Me.ulDescClienteOT.TabIndex = 98
        '
        'AdvCliente
        '
        Me.AdvCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvCliente.Enabled = False
        Me.AdvCliente.Location = New System.Drawing.Point(55, 3)
        Me.AdvCliente.Name = "AdvCliente"
        Me.AdvCliente.Size = New System.Drawing.Size(114, 23)
        Me.AdvCliente.TabIndex = 96
        '
        'txtCodTrabajo
        '
        Me.TryDataBinding(txtCodTrabajo, New System.Windows.Forms.Binding("Text", Me, "CodTrabajo", True))
        Me.txtCodTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodTrabajo.Location = New System.Drawing.Point(108, 36)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(135, 23)
        Me.txtCodTrabajo.TabIndex = 0
        '
        'lblFechaOrden
        '
        Me.lblFechaOrden.Location = New System.Drawing.Point(9, 61)
        Me.lblFechaOrden.Name = "lblFechaOrden"
        Me.lblFechaOrden.Size = New System.Drawing.Size(95, 13)
        Me.lblFechaOrden.TabIndex = 245
        Me.lblFechaOrden.Text = "Fecha Orden S."
        '
        'cbxFechaOrden
        '
        Me.cbxFechaOrden.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaOrden.Location = New System.Drawing.Point(108, 61)
        Me.cbxFechaOrden.Name = "cbxFechaOrden"
        Me.cbxFechaOrden.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaOrden.TabIndex = 1
        '
        'lblFechaPrevistaRetorno
        '
        Me.lblFechaPrevistaRetorno.AutoSize = False
        Me.lblFechaPrevistaRetorno.Location = New System.Drawing.Point(9, 107)
        Me.lblFechaPrevistaRetorno.Name = "lblFechaPrevistaRetorno"
        Me.lblFechaPrevistaRetorno.Size = New System.Drawing.Size(95, 28)
        Me.lblFechaPrevistaRetorno.TabIndex = 246
        Me.lblFechaPrevistaRetorno.Text = "Fecha Prev. Retorno"
        '
        'cbxFechaPrevistaRetorno
        '
        Me.TryDataBinding(cbxFechaPrevistaRetorno, New System.Windows.Forms.Binding("BindableValue", Me, "FechaPrevistaEntrega", True))
        Me.cbxFechaPrevistaRetorno.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaPrevistaRetorno.Location = New System.Drawing.Point(108, 111)
        Me.cbxFechaPrevistaRetorno.Name = "cbxFechaPrevistaRetorno"
        Me.cbxFechaPrevistaRetorno.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaPrevistaRetorno.TabIndex = 3
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(9, 86)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(88, 13)
        Me.lblFecha.TabIndex = 247
        Me.lblFecha.Text = "Fecha Entrega"
        '
        'cbxFechaEntrega
        '
        Me.cbxFechaEntrega.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaEntrega.Location = New System.Drawing.Point(108, 86)
        Me.cbxFechaEntrega.Name = "cbxFechaEntrega"
        Me.cbxFechaEntrega.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaEntrega.TabIndex = 2
        '
        'FraDireccionEnvio
        '
        Me.FraDireccionEnvio.Controls.Add(Me.cmbSearchIDDireccion)
        Me.FraDireccionEnvio.Controls.Add(Me.lblCIF)
        Me.FraDireccionEnvio.Controls.Add(Me.txtCIF)
        Me.FraDireccionEnvio.Controls.Add(Me.lblDireccion)
        Me.FraDireccionEnvio.Controls.Add(Me.txtDireccion)
        Me.FraDireccionEnvio.Controls.Add(Me.lblProvincia)
        Me.FraDireccionEnvio.Controls.Add(Me.txtProvincia)
        Me.FraDireccionEnvio.Controls.Add(Me.lblCP)
        Me.FraDireccionEnvio.Controls.Add(Me.txtCP)
        Me.FraDireccionEnvio.Controls.Add(Me.lblPoblacion)
        Me.FraDireccionEnvio.Controls.Add(Me.txtPoblacion)
        Me.FraDireccionEnvio.Location = New System.Drawing.Point(247, 30)
        Me.FraDireccionEnvio.Name = "FraDireccionEnvio"
        Me.FraDireccionEnvio.Size = New System.Drawing.Size(302, 123)
        Me.FraDireccionEnvio.TabIndex = 248
        Me.FraDireccionEnvio.TabStop = False
        Me.FraDireccionEnvio.Text = "Dirección Envío"
        '
        'cmbSearchIDDireccion
        '
        Me.cmbSearchIDDireccion.ImageIndex = 0
        Me.cmbSearchIDDireccion.ImageList = Me.ImageList1
        Me.cmbSearchIDDireccion.Location = New System.Drawing.Point(6, 16)
        Me.cmbSearchIDDireccion.Name = "cmbSearchIDDireccion"
        Me.cmbSearchIDDireccion.Size = New System.Drawing.Size(21, 21)
        Me.cmbSearchIDDireccion.TabIndex = 4
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'lblCIF
        '
        Me.lblCIF.Location = New System.Drawing.Point(169, 93)
        Me.lblCIF.Name = "lblCIF"
        Me.lblCIF.Size = New System.Drawing.Size(26, 13)
        Me.lblCIF.TabIndex = 0
        Me.lblCIF.Text = "NIF"
        '
        'txtCIF
        '
        Me.txtCIF.DisabledBackColor = System.Drawing.Color.White
        Me.txtCIF.Enabled = False
        Me.txtCIF.Location = New System.Drawing.Point(198, 93)
        Me.txtCIF.Name = "txtCIF"
        Me.txtCIF.Size = New System.Drawing.Size(96, 21)
        Me.txtCIF.TabIndex = 19
        '
        'lblDireccion
        '
        Me.lblDireccion.Location = New System.Drawing.Point(33, 18)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(60, 13)
        Me.lblDireccion.TabIndex = 21
        Me.lblDireccion.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(97, 18)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(197, 21)
        Me.txtDireccion.TabIndex = 15
        '
        'lblProvincia
        '
        Me.lblProvincia.Location = New System.Drawing.Point(33, 68)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(59, 13)
        Me.lblProvincia.TabIndex = 22
        Me.lblProvincia.Text = "Provincia"
        '
        'txtProvincia
        '
        Me.txtProvincia.DisabledBackColor = System.Drawing.Color.White
        Me.txtProvincia.Enabled = False
        Me.txtProvincia.Location = New System.Drawing.Point(97, 68)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(197, 21)
        Me.txtProvincia.TabIndex = 17
        '
        'lblCP
        '
        Me.lblCP.Location = New System.Drawing.Point(33, 93)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(29, 13)
        Me.lblCP.TabIndex = 23
        Me.lblCP.Text = "C.P."
        '
        'txtCP
        '
        Me.txtCP.DisabledBackColor = System.Drawing.Color.White
        Me.txtCP.Enabled = False
        Me.txtCP.Location = New System.Drawing.Point(97, 93)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(66, 21)
        Me.txtCP.TabIndex = 18
        '
        'lblPoblacion
        '
        Me.lblPoblacion.Location = New System.Drawing.Point(33, 43)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(61, 13)
        Me.lblPoblacion.TabIndex = 24
        Me.lblPoblacion.Text = "Población"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtPoblacion.Enabled = False
        Me.txtPoblacion.Location = New System.Drawing.Point(97, 43)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(197, 21)
        Me.txtPoblacion.TabIndex = 16
        '
        'lblTextoCliente
        '
        Me.lblTextoCliente.Location = New System.Drawing.Point(9, 319)
        Me.lblTextoCliente.Name = "lblTextoCliente"
        Me.lblTextoCliente.Size = New System.Drawing.Size(218, 13)
        Me.lblTextoCliente.TabIndex = 250
        Me.lblTextoCliente.Text = "Observaciones Generales del Cliente"
        '
        'txtTextoCliente
        '
        Me.txtTextoCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtTextoCliente.Enabled = False
        Me.txtTextoCliente.Location = New System.Drawing.Point(9, 338)
        Me.txtTextoCliente.Multiline = True
        Me.txtTextoCliente.Name = "txtTextoCliente"
        Me.txtTextoCliente.Size = New System.Drawing.Size(288, 77)
        Me.txtTextoCliente.TabIndex = 8
        Me.txtTextoCliente.TabStop = False
        '
        'chkFianzaObligatoria
        '
        Me.chkFianzaObligatoria.Enabled = False
        Me.chkFianzaObligatoria.Location = New System.Drawing.Point(308, 368)
        Me.chkFianzaObligatoria.Name = "chkFianzaObligatoria"
        Me.chkFianzaObligatoria.Size = New System.Drawing.Size(151, 19)
        Me.chkFianzaObligatoria.TabIndex = 10
        Me.chkFianzaObligatoria.TabStop = False
        Me.chkFianzaObligatoria.Text = "Fianza Obligatoria"
        '
        'lblFianza
        '
        Me.lblFianza.Location = New System.Drawing.Point(308, 392)
        Me.lblFianza.Name = "lblFianza"
        Me.lblFianza.Size = New System.Drawing.Size(43, 13)
        Me.lblFianza.TabIndex = 257
        Me.lblFianza.Text = "Fianza"
        '
        'lblTexto
        '
        Me.lblTexto.Location = New System.Drawing.Point(9, 229)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(120, 13)
        Me.lblTexto.TabIndex = 258
        Me.lblTexto.Text = "Comentario Interno"
        '
        'txtTexto
        '
        Me.TryDataBinding(txtTexto, New System.Windows.Forms.Binding("Text", Me, "Texto", True))
        Me.txtTexto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTexto.Location = New System.Drawing.Point(9, 248)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(263, 65)
        Me.txtTexto.TabIndex = 6
        '
        'lblTextoPublico
        '
        Me.lblTextoPublico.Location = New System.Drawing.Point(276, 229)
        Me.lblTextoPublico.Name = "lblTextoPublico"
        Me.lblTextoPublico.Size = New System.Drawing.Size(122, 13)
        Me.lblTextoPublico.TabIndex = 259
        Me.lblTextoPublico.Text = "Comentario Externo"
        '
        'txtTextoPublico
        '
        Me.TryDataBinding(txtTextoPublico, New System.Windows.Forms.Binding("Text", Me, "TextoPublico", True))
        Me.txtTextoPublico.DisabledBackColor = System.Drawing.Color.White
        Me.txtTextoPublico.Location = New System.Drawing.Point(276, 248)
        Me.txtTextoPublico.Multiline = True
        Me.txtTextoPublico.Name = "txtTextoPublico"
        Me.txtTextoPublico.Size = New System.Drawing.Size(271, 65)
        Me.txtTextoPublico.TabIndex = 7
        '
        'lblPersonaContacto
        '
        Me.lblPersonaContacto.AutoSize = False
        Me.lblPersonaContacto.Location = New System.Drawing.Point(308, 335)
        Me.lblPersonaContacto.Name = "lblPersonaContacto"
        Me.lblPersonaContacto.Size = New System.Drawing.Size(62, 28)
        Me.lblPersonaContacto.TabIndex = 260
        Me.lblPersonaContacto.Text = "Persona Contacto"
        Me.lblPersonaContacto.Visible = False
        '
        'cbxIDPersona
        '
        Me.TryDataBinding(cbxIDPersona, New System.Windows.Forms.Binding("Value", Me, "IDPersona", True))
        cbxIDPersona_DesignTimeLayout.LayoutString = resources.GetString("cbxIDPersona_DesignTimeLayout.LayoutString")
        Me.cbxIDPersona.DesignTimeLayout = cbxIDPersona_DesignTimeLayout
        Me.cbxIDPersona.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDPersona.Location = New System.Drawing.Point(371, 336)
        Me.cbxIDPersona.Name = "cbxIDPersona"
        Me.cbxIDPersona.SelectedIndex = -1
        Me.cbxIDPersona.SelectedItem = Nothing
        Me.cbxIDPersona.Size = New System.Drawing.Size(174, 21)
        Me.cbxIDPersona.TabIndex = 9
        Me.cbxIDPersona.Visible = False
        '
        'lblPedidoCliente
        '
        Me.lblPedidoCliente.Location = New System.Drawing.Point(9, 139)
        Me.lblPedidoCliente.Name = "lblPedidoCliente"
        Me.lblPedidoCliente.Size = New System.Drawing.Size(89, 13)
        Me.lblPedidoCliente.TabIndex = 261
        Me.lblPedidoCliente.Text = "Pedido Cliente"
        '
        'txtPedidoCliente
        '
        Me.TryDataBinding(txtPedidoCliente, New System.Windows.Forms.Binding("Text", Me, "PedidoCliente", True))
        Me.txtPedidoCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtPedidoCliente.Location = New System.Drawing.Point(9, 159)
        Me.txtPedidoCliente.Multiline = True
        Me.txtPedidoCliente.Name = "txtPedidoCliente"
        Me.txtPedidoCliente.Size = New System.Drawing.Size(539, 65)
        Me.txtPedidoCliente.TabIndex = 5
        '
        'txtFianza
        '
        Me.TryDataBinding(txtFianza, New System.Windows.Forms.Binding("Value", Me, "Fianza", True))
        Me.txtFianza.DisabledBackColor = System.Drawing.Color.White
        Me.txtFianza.Enabled = False
        Me.txtFianza.Location = New System.Drawing.Point(371, 392)
        Me.txtFianza.Name = "txtFianza"
        Me.txtFianza.Size = New System.Drawing.Size(94, 21)
        Me.txtFianza.TabIndex = 11
        Me.txtFianza.TabStop = False
        '
        'FrmAddOrden
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(554, 461)
        Me.Controls.Add(Me.txtFianza)
        Me.Controls.Add(Me.lblTextoCliente)
        Me.Controls.Add(Me.lblFianza)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.lblTextoPublico)
        Me.Controls.Add(Me.lblPedidoCliente)
        Me.Controls.Add(Me.lblFechaOrden)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblOrdenServicio)
        Me.Controls.Add(Me.txtTextoCliente)
        Me.Controls.Add(Me.chkFianzaObligatoria)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.txtTextoPublico)
        Me.Controls.Add(Me.lblPersonaContacto)
        Me.Controls.Add(Me.cbxIDPersona)
        Me.Controls.Add(Me.txtPedidoCliente)
        Me.Controls.Add(Me.FraDireccionEnvio)
        Me.Controls.Add(Me.cbxFechaOrden)
        Me.Controls.Add(Me.lblFechaPrevistaRetorno)
        Me.Controls.Add(Me.cbxFechaPrevistaRetorno)
        Me.Controls.Add(Me.cbxFechaEntrega)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.Controls.Add(Me.pnlCliente)
        Me.Controls.Add(Me.Panel1)
        Me.EntityName = "ObraTrabajo"
        Me.Name = "FrmAddOrden"
        Me.NavigationFields = "IDTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Ordenes de Servicio"
        Me.ViewName = "tbObraTrabajo"
        Me.Panel1.ResumeLayout(False)
        Me.pnlCliente.ResumeLayout(False)
        Me.pnlCliente.PerformLayout()
        Me.FraDireccionEnvio.ResumeLayout(False)
        Me.FraDireccionEnvio.PerformLayout()
        CType(Me.cbxIDPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim mIDObra, mIDTrabajoPadre, mIDDireccion As Integer
    Dim mIDTipoObra, mTextoCliente, mPedidoClienteAbierto, mIDCentroGestion As String
    Dim mFianzaObligatoria As Boolean

    Private WithEvents sctClienteDireccion As AdvancedSearch

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

#Region " Load "

    Public Function AbrirAltaOrden(ByVal IDObra As Integer, ByVal IDTipoObra As String, ByVal IDCliente As String, ByVal DescCliente As String, _
                                   ByVal IDDireccion As Integer, ByVal Direccion As String, ByVal Poblacion As String, ByVal Provincia As String, _
                                   ByVal CodPostal As String, ByVal CIF As String, ByVal PedidoClienteAbierto As String, ByVal TextoCliente As String, _
                                   ByVal FianzaObligatoria As Boolean, ByVal IDTrabajoPadre As Integer, ByVal IDCentroGestion As String) As DataRow

        LoadAdvancedSearchSettings()

        mIDObra = IDObra
        mIDTrabajoPadre = IDTrabajoPadre
        mIDTipoObra = IDTipoObra
        mIDDireccion = IDDireccion
        mFianzaObligatoria = FianzaObligatoria
        mPedidoClienteAbierto = PedidoClienteAbierto
        mIDCentroGestion = IDCentroGestion

        LoadPersonasContacto()

        If Length(IDCliente) > 0 Then AdvCliente.Text = IDCliente
        ulDescClienteOT.Text = DescCliente
        txtTextoCliente.Text = TextoCliente
        txtDireccion.Text = Direccion
        txtPoblacion.Text = Poblacion
        txtProvincia.Text = Provincia
        txtCP.Text = CodPostal
        txtCIF.Text = CIF

        Dim frm As New Form
        frm = Me  'Para que no traiga todos los registros
        frm.ShowDialog()

        If Me.DialogResult = DialogResult.OK Then
            Return SetTrabajo()
        Else
            Return Nothing
        End If
    End Function
    Public Function AbrirAltaOrdenHilti(ByVal IDObra As Integer, ByVal IDTipoObra As String, ByVal IDCliente As String, ByVal DescCliente As String, _
                               ByVal IDDireccion As Integer, ByVal Direccion As String, ByVal Poblacion As String, ByVal Provincia As String, _
                               ByVal CodPostal As String, ByVal CIF As String, ByVal PedidoClienteAbierto As String, ByVal TextoCliente As String, _
                               ByVal FianzaObligatoria As Boolean, ByVal IDTrabajoPadre As Integer, ByVal IDCentroGestion As String, ByVal odatos As ObraDatos) As DataRow


        mIDObra = IDObra
        mIDTrabajoPadre = IDTrabajoPadre
        mIDTipoObra = IDTipoObra
        mIDDireccion = IDDireccion
        mFianzaObligatoria = FianzaObligatoria
        mPedidoClienteAbierto = PedidoClienteAbierto
        mIDCentroGestion = IDCentroGestion
        falsoLoad(odatos)

        Return SetTrabajo()

    End Function

    Private Sub LoadAdvancedSearchSettings()
        sctClienteDireccion = New AdvancedSearch : sctClienteDireccion.EntityName = "ClienteDireccion" : sctClienteDireccion.ViewName = "tbClienteDireccion"
    End Sub

    Public Sub LoadPersonasContacto()
        cbxIDPersona.DataSource = New ObraPersonaContacto2().Filter(, , "IDPersona,Nombre")
        'cbxIDPersona.DataSource = New ObraPersonaContacto().Filter(New NumberFilterItem("IDObra", mIDObra), , "IDPersona,Nombre")
    End Sub

    Private Function SetTrabajo() As DataRow
        Dim dtTrabajo As DataTable = New BE.DataEngine().Filter("VFrmAlquilerTrabajos", New NoRowsFilterItem)

        Dim dr As DataRow = dtTrabajo.NewRow
        Dim bd As New BusinessData(dr)
        For Each dc As DataColumn In Me.CurrentData.Columns
            If bd.ContainsKey(dc.ColumnName) Then
                dr(dc.ColumnName) = Me.CurrentData.Rows(0)(dc.ColumnName)
            End If
        Next

        Return dr
    End Function

    Private Sub FrmAddOrden_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AddNew()

        Dim dt As DataTable = ExpertisApp.ExecuteTask(Of DataTable, DataTable)(AddressOf ObraTrabajo.AddNewFormAlquileres, Me.CurrentData)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            For Each col As DataColumn In dt.Columns
                If col.ColumnName <> "IDTrabajo" Then
                    Me.CurrentData.Rows(0)(col.ColumnName) = dt.Rows(0)(col.ColumnName)
                End If
            Next
        End If

        chkFianzaObligatoria.Checked = mFianzaObligatoria

        Me.CurrentData.Rows(0)("IDObra") = mIDObra
        Me.CurrentData.Rows(0)("IDTipoObra") = mIDTipoObra
        Me.CurrentData.Rows(0)("IDDireccion") = mIDDireccion
        Me.CurrentData.Rows(0)("TipoFacturacion") = CInt(enumotTipoFacturacion.otfPorConceptos)
        If Length(Me.CurrentData.Rows(0)("IDCentroGestion")) = 0 AndAlso Length(mIDCentroGestion) > 0 Then
            Me.CurrentData.Rows(0)("IDCentroGestion") = mIDCentroGestion
        End If
        If Length(mPedidoClienteAbierto) > 0 Then
            txtPedidoCliente.Text = mPedidoClienteAbierto
            txtPedidoCliente.ReadOnly = True
        End If

        If mIDTrabajoPadre > 0 Then Me.CurrentData.Rows(0)("IDTrabajoPadre") = mIDTrabajoPadre

    End Sub
    Public Sub falsoLoad(ByVal odatos As ObraDatos)
        Me.AddNew()

        Dim dt As DataTable = ExpertisApp.ExecuteTask(Of DataTable, DataTable)(AddressOf ObraTrabajo.AddNewFormAlquileres, Me.CurrentData)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            For Each col As DataColumn In dt.Columns
                If col.ColumnName <> "IDTrabajo" Then
                    Me.CurrentData.Rows(0)(col.ColumnName) = dt.Rows(0)(col.ColumnName)
                End If
            Next
        End If

        chkFianzaObligatoria.Checked = mFianzaObligatoria

        Me.CurrentData.Rows(0)("IDObra") = mIDObra
        Me.CurrentData.Rows(0)("nombreExcel") = odatos.ruta
        Me.CurrentData.Rows(0)("PedidoCliente") = "-"
        Me.CurrentData.Rows(0)("IDTipoObra") = mIDTipoObra
        Me.CurrentData.Rows(0)("IDDireccion") = mIDDireccion
        Me.CurrentData.Rows(0)("TipoFacturacion") = CInt(enumotTipoFacturacion.otfPorConceptos)
        If Length(Me.CurrentData.Rows(0)("IDCentroGestion")) = 0 AndAlso Length(mIDCentroGestion) > 0 Then
            Me.CurrentData.Rows(0)("IDCentroGestion") = mIDCentroGestion
        End If
        If Length(mPedidoClienteAbierto) > 0 Then
            txtPedidoCliente.Text = mPedidoClienteAbierto
            txtPedidoCliente.ReadOnly = True
        End If

        If mIDTrabajoPadre > 0 Then Me.CurrentData.Rows(0)("IDTrabajoPadre") = mIDTrabajoPadre

    End Sub
#End Region

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Length(txtCodTrabajo.Text) > 0 Then
            Dim Cancel As Boolean = TratarFianza()
            If Not Cancel Then
                Me.CurrentData.Rows(0)("FechaInicio") = IIf(Length(cbxFechaEntrega.Value) > 0, cbxFechaEntrega.Value, Date.Today)
                Me.CurrentData.Rows(0)("FechaOrden") = IIf(Length(cbxFechaOrden.Value) > 0, cbxFechaOrden.Value, Date.Today)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            ExpertisApp.GenerateMessage("La Orden Servicio es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function TratarFianza() As Boolean
        Dim Cancel As Boolean = False
        If chkFianzaObligatoria.Checked Then
            If Nz(txtFianza.Value, 0) = 0 Then
                If ExpertisApp.GenerateMessage("El Cliente necesita introducir una Fianza. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                    Cancel = True
                End If
            Else
                If ExpertisApp.GenerateMessage("Se contabilizará la fianza. ¿Desea continuar con el proceso?.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                    Cancel = True
                    Me.CurrentData.Rows(0)("Fianza") = 0
                End If
            End If
        End If

        Return Cancel
    End Function

    Private Sub chkFianzaObligatoria_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFianzaObligatoria.CheckedChanged
        txtFianza.Enabled = chkFianzaObligatoria.Checked()
    End Sub

#Region " SearchIDDireccion "

    Private Sub cmbSearchIDDireccion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSearchIDDireccion.Click
        sctClienteDireccion.Open()
    End Sub

    Private Sub sctClienteDireccion_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctClienteDireccion.SetPredefinedFilter
        e.Filter.Add(New NumberFilterItem("IDObra", mIDObra))
        If Length(AdvCliente.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDCliente", AdvCliente.Text))
        End If
    End Sub

    Private Sub sctClienteDireccion_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctClienteDireccion.SelectionChanged
        If Not IsNothing(e.Selected) AndAlso e.Selected.Rows.Count > 0 Then
            Me.CurrentData.Rows(0)("IDDireccion") = e.Selected.Rows(0)("IDDireccion")
        End If
    End Sub

#End Region

    Private Sub ulDescClienteOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulDescClienteOT.Click

    End Sub
End Class
