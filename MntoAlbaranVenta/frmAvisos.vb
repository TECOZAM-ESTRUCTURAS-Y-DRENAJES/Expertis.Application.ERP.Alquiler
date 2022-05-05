Public Class frmAvisos
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
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label5 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label6 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label7 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label8 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiAlbaranRecogida As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FwiContactoObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FwiRecogidoPor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FwiFechaAviso As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FwiQAvisoRetorno As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FwiTelefono As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FwiMatricula As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FwiFechaAlbaran As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label9 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiARTexto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FwiDescripcionRecogidoPor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents jngAvisos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmbCerrar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngAvisos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAvisos))
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.FwiDescripcionRecogidoPor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label9 = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiARTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwiFechaAlbaran = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwiMatricula = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwiTelefono = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwiQAvisoRetorno = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwiFechaAviso = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwiRecogidoPor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwiContactoObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwiAlbaranRecogida = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label8 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label7 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label6 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label5 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCerrar = New Solmicro.Expertis.Engine.UI.Button
        Me.jngAvisos = New Solmicro.Expertis.Engine.UI.Grid
        Me.Frame1.SuspendLayout()
        Me.Panel1.suspendlayout()
        CType(Me.jngAvisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.FwiDescripcionRecogidoPor)
        Me.Frame1.Controls.Add(Me.Label9)
        Me.Frame1.Controls.Add(Me.fwiARTexto)
        Me.Frame1.Controls.Add(Me.FwiFechaAlbaran)
        Me.Frame1.Controls.Add(Me.FwiMatricula)
        Me.Frame1.Controls.Add(Me.FwiTelefono)
        Me.Frame1.Controls.Add(Me.FwiQAvisoRetorno)
        Me.Frame1.Controls.Add(Me.FwiFechaAviso)
        Me.Frame1.Controls.Add(Me.FwiRecogidoPor)
        Me.Frame1.Controls.Add(Me.FwiContactoObra)
        Me.Frame1.Controls.Add(Me.FwiAlbaranRecogida)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(632, 256)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Datos del Aviso Actual"
        '
        'FwiDescripcionRecogidoPor
        '
        Me.FwiDescripcionRecogidoPor.DisabledBackColor = System.Drawing.Color.White
        Me.FwiDescripcionRecogidoPor.Enabled = False
        Me.FwiDescripcionRecogidoPor.Location = New System.Drawing.Point(221, 72)
        Me.FwiDescripcionRecogidoPor.Name = "FwiDescripcionRecogidoPor"
        Me.FwiDescripcionRecogidoPor.Size = New System.Drawing.Size(132, 21)
        Me.FwiDescripcionRecogidoPor.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Observaciones"
        '
        'fwiARTexto
        '
        Me.fwiARTexto.DisabledBackColor = System.Drawing.Color.White
        Me.fwiARTexto.Enabled = False
        Me.fwiARTexto.Location = New System.Drawing.Point(8, 144)
        Me.fwiARTexto.Multiline = True
        Me.fwiARTexto.Name = "fwiARTexto"
        Me.fwiARTexto.Size = New System.Drawing.Size(616, 104)
        Me.fwiARTexto.TabIndex = 9
        '
        'FwiFechaAlbaran
        '
        Me.FwiFechaAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaAlbaran.Enabled = False
        Me.FwiFechaAlbaran.Location = New System.Drawing.Point(528, 96)
        Me.FwiFechaAlbaran.Name = "FwiFechaAlbaran"
        Me.FwiFechaAlbaran.Size = New System.Drawing.Size(96, 21)
        Me.FwiFechaAlbaran.TabIndex = 8
        '
        'FwiMatricula
        '
        Me.FwiMatricula.DisabledBackColor = System.Drawing.Color.White
        Me.FwiMatricula.Enabled = False
        Me.FwiMatricula.Location = New System.Drawing.Point(424, 72)
        Me.FwiMatricula.Name = "FwiMatricula"
        Me.FwiMatricula.Size = New System.Drawing.Size(200, 21)
        Me.FwiMatricula.TabIndex = 7
        '
        'FwiTelefono
        '
        Me.FwiTelefono.DisabledBackColor = System.Drawing.Color.White
        Me.FwiTelefono.Enabled = False
        Me.FwiTelefono.Location = New System.Drawing.Point(520, 48)
        Me.FwiTelefono.Name = "FwiTelefono"
        Me.FwiTelefono.Size = New System.Drawing.Size(104, 21)
        Me.FwiTelefono.TabIndex = 6
        '
        'FwiQAvisoRetorno
        '
        Me.FwiQAvisoRetorno.DisabledBackColor = System.Drawing.Color.White
        Me.FwiQAvisoRetorno.Enabled = False
        Me.FwiQAvisoRetorno.Location = New System.Drawing.Point(520, 24)
        Me.FwiQAvisoRetorno.Name = "FwiQAvisoRetorno"
        Me.FwiQAvisoRetorno.Size = New System.Drawing.Size(104, 21)
        Me.FwiQAvisoRetorno.TabIndex = 5
        '
        'FwiFechaAviso
        '
        Me.FwiFechaAviso.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaAviso.Enabled = False
        Me.FwiFechaAviso.Location = New System.Drawing.Point(137, 96)
        Me.FwiFechaAviso.Name = "FwiFechaAviso"
        Me.FwiFechaAviso.Size = New System.Drawing.Size(80, 21)
        Me.FwiFechaAviso.TabIndex = 4
        '
        'FwiRecogidoPor
        '
        Me.FwiRecogidoPor.DisabledBackColor = System.Drawing.Color.White
        Me.FwiRecogidoPor.Enabled = False
        Me.FwiRecogidoPor.Location = New System.Drawing.Point(137, 72)
        Me.FwiRecogidoPor.Name = "FwiRecogidoPor"
        Me.FwiRecogidoPor.Size = New System.Drawing.Size(80, 21)
        Me.FwiRecogidoPor.TabIndex = 3
        '
        'FwiContactoObra
        '
        Me.FwiContactoObra.DisabledBackColor = System.Drawing.Color.White
        Me.FwiContactoObra.Enabled = False
        Me.FwiContactoObra.Location = New System.Drawing.Point(137, 48)
        Me.FwiContactoObra.Name = "FwiContactoObra"
        Me.FwiContactoObra.Size = New System.Drawing.Size(136, 21)
        Me.FwiContactoObra.TabIndex = 2
        '
        'FwiAlbaranRecogida
        '
        Me.FwiAlbaranRecogida.DisabledBackColor = System.Drawing.Color.White
        Me.FwiAlbaranRecogida.Enabled = False
        Me.FwiAlbaranRecogida.Location = New System.Drawing.Point(137, 24)
        Me.FwiAlbaranRecogida.Name = "FwiAlbaranRecogida"
        Me.FwiAlbaranRecogida.Size = New System.Drawing.Size(96, 21)
        Me.FwiAlbaranRecogida.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(360, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fecha Albarán de Recogida"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(360, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Matrícula"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(416, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Teléfono"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(416, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad Aviso"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Aviso Recogida"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Recogido por"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contacto Alquiler"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Albarán de Recogida"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 421)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 40)
        Me.Panel1.TabIndex = 3
        '
        'cmbCerrar
        '
        Me.cmbCerrar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmbCerrar.Location = New System.Drawing.Point(264, 4)
        Me.cmbCerrar.Name = "cmbCerrar"
        Me.cmbCerrar.Size = New System.Drawing.Size(104, 32)
        Me.cmbCerrar.TabIndex = 3
        Me.cmbCerrar.Text = "Cerrar"
        '
        'jngAvisos
        '
        Me.jngAvisos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngAvisos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngAvisos_DesignTimeLayout.LayoutString = resources.GetString("jngAvisos_DesignTimeLayout.LayoutString")
        Me.jngAvisos.DesignTimeLayout = jngAvisos_DesignTimeLayout
        Me.jngAvisos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngAvisos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngAvisos.EntityName = "HistoricoAvisoRetorno"
        Me.jngAvisos.Location = New System.Drawing.Point(0, 256)
        Me.jngAvisos.Name = "jngAvisos"
        Me.jngAvisos.PrimaryDataFields = Nothing
        Me.jngAvisos.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.jngAvisos.SecondaryDataFields = Nothing
        Me.jngAvisos.Size = New System.Drawing.Size(632, 165)
        Me.jngAvisos.TabIndex = 4
        Me.jngAvisos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngAvisos.ViewName = "vAlquilerfrmAvisosRetorno"
        '
        'frmAvisos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(632, 461)
        Me.Controls.Add(Me.jngAvisos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Frame1)
        Me.MaximizeBox = False
        Me.Name = "frmAvisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avisos de Retornos "
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.jngAvisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables y Propiedades"
    Private strAlbaran As String
    Private strContacto As String
    Private strMatricula As String
    Private strRecibidoPor As String
    Private strTelefono As String
    Private lngCantidad As Integer
    Private lngIDLineaAlbaran As Integer
    Private dteFechaAviso As String
    Private dteFechaPrevista As String
    Private strDescripcion As String
    Private strTexto As String

    Public WriteOnly Property NAlbaran() As String
        Set(ByVal Value As String)
            strAlbaran = Value
        End Set
    End Property

    Public WriteOnly Property Contacto() As String
        Set(ByVal Value As String)
            strContacto = Value
        End Set
    End Property

    Public WriteOnly Property Matricula() As String
        Set(ByVal Value As String)
            strMatricula = Value
        End Set
    End Property

    Public WriteOnly Property RecibidoPor() As String
        Set(ByVal Value As String)
            strRecibidoPor = Value
        End Set
    End Property

    Public WriteOnly Property Telefono() As String
        Set(ByVal Value As String)
            strTelefono = Value
        End Set
    End Property

    Public WriteOnly Property Cantidad() As Integer
        Set(ByVal Value As Integer)
            lngCantidad = Value
        End Set
    End Property

    Public WriteOnly Property IDLineaAlbaran() As Integer
        Set(ByVal Value As Integer)
            lngIDLineaAlbaran = Value
        End Set
    End Property

    Public WriteOnly Property FechaAviso() As Date
        Set(ByVal Value As Date)
            dteFechaAviso = Value
        End Set
    End Property

    Public WriteOnly Property FechaPrevista() As Date
        Set(ByVal Value As Date)
            dteFechaPrevista = Value
        End Set
    End Property

    Public WriteOnly Property Descripcion() As String
        Set(ByVal Value As String)
            strDescripcion = Value
        End Set
    End Property

    Public WriteOnly Property Texto() As String
        Set(ByVal Value As String)
            strTexto = Value
        End Set
    End Property

#End Region

    Private Sub cmbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCerrar.Click
        Me.Close()
    End Sub

    Public Sub AbrirFormulario()

        Dim filtro As New Filter
        filtro.Add("IDLineaAlbaran", FilterOperator.Equal, lngIDLineaAlbaran)
        jngAvisos.Filter = filtro

        FwiAlbaranRecogida.Text = strAlbaran
        FwiContactoObra.Text = strContacto
        FwiTelefono.Text = strTelefono
        FwiMatricula.Text = strMatricula
        FwiRecogidoPor.Text = strRecibidoPor
        If length(strDescripcion) > 0 Then
            FwiDescripcionRecogidoPor.Text = strDescripcion
        End If
        If Length(FwiAlbaranRecogida.Text) = 0 And Length(FwiContactoObra.Text) = 0 And Length(FwiTelefono.Text) = 0 _
         And Length(FwiMatricula.Text) = 0 And Length(FwiRecogidoPor.Text) = 0 And lngCantidad = 0 Then
            FwiQAvisoRetorno.Text = String.Empty
        Else
            FwiQAvisoRetorno.Text = lngCantidad
        End If
        FwiFechaAviso.Text = dteFechaAviso
        FwiFechaAlbaran.Text = dteFechaPrevista
        fwiARTexto.Text = strTexto

        Me.ShowDialog()
    End Sub

End Class
