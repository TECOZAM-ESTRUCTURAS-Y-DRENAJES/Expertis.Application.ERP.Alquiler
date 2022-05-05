Public Class frmDatosAviso
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
    Friend WithEvents fraDatosAviso As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblFechaAvisoRecogida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaAvisoRecogida As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaPrevistaRetorno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaPrevistaRetorno As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblTexto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTexto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblAlbaranRecogida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtAlbaranRecogida As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblContactoObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advContactoObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTelefono As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTelefono As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbRecogidoPor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescOperario As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblMatricula As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtMatricula As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.fraDatosAviso = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTexto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFechaAvisoRecogida = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaAvisoRecogida = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaPrevistaRetorno = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaPrevistaRetorno = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblAlbaranRecogida = New Solmicro.Expertis.Engine.UI.Label
        Me.txtAlbaranRecogida = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblContactoObra = New Solmicro.Expertis.Engine.UI.Label
        Me.advContactoObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTelefono = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTelefono = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbRecogidoPor = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescOperario = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblMatricula = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMatricula = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.fraDatosAviso.SuspendLayout()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'fraDatosAviso
        '
        Me.fraDatosAviso.Controls.Add(Me.lblTexto)
        Me.fraDatosAviso.Controls.Add(Me.txtTexto)
        Me.fraDatosAviso.Controls.Add(Me.lblFechaAvisoRecogida)
        Me.fraDatosAviso.Controls.Add(Me.cbxFechaAvisoRecogida)
        Me.fraDatosAviso.Controls.Add(Me.lblFechaPrevistaRetorno)
        Me.fraDatosAviso.Controls.Add(Me.cbxFechaPrevistaRetorno)
        Me.fraDatosAviso.Controls.Add(Me.lblAlbaranRecogida)
        Me.fraDatosAviso.Controls.Add(Me.txtAlbaranRecogida)
        Me.fraDatosAviso.Controls.Add(Me.lblContactoObra)
        Me.fraDatosAviso.Controls.Add(Me.advContactoObra)
        Me.fraDatosAviso.Controls.Add(Me.lblTelefono)
        Me.fraDatosAviso.Controls.Add(Me.txtTelefono)
        Me.fraDatosAviso.Controls.Add(Me.lbRecogidoPor)
        Me.fraDatosAviso.Controls.Add(Me.ulDescOperario)
        Me.fraDatosAviso.Controls.Add(Me.advIDOperario)
        Me.fraDatosAviso.Controls.Add(Me.lblMatricula)
        Me.fraDatosAviso.Controls.Add(Me.txtMatricula)
        Me.fraDatosAviso.Location = New System.Drawing.Point(1, 1)
        Me.fraDatosAviso.Name = "fraDatosAviso"
        Me.fraDatosAviso.Size = New System.Drawing.Size(497, 386)
        Me.fraDatosAviso.TabIndex = 0
        Me.fraDatosAviso.TabStop = False
        Me.fraDatosAviso.Text = "Datos del Aviso"
        '
        'lblTexto
        '
        Me.lblTexto.Location = New System.Drawing.Point(8, 152)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(91, 13)
        Me.lblTexto.TabIndex = 0
        Me.lblTexto.Text = "Observaciones"
        '
        'txtTexto
        '
        Me.txtTexto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTexto.Location = New System.Drawing.Point(8, 168)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(481, 212)
        Me.txtTexto.TabIndex = 10
        '
        'lblFechaAvisoRecogida
        '
        Me.lblFechaAvisoRecogida.Location = New System.Drawing.Point(247, 128)
        Me.lblFechaAvisoRecogida.Name = "lblFechaAvisoRecogida"
        Me.lblFechaAvisoRecogida.Size = New System.Drawing.Size(131, 13)
        Me.lblFechaAvisoRecogida.TabIndex = 11
        Me.lblFechaAvisoRecogida.Text = "Fecha Aviso Recogida"
        '
        'cbxFechaAvisoRecogida
        '
        Me.cbxFechaAvisoRecogida.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaAvisoRecogida.Location = New System.Drawing.Point(383, 124)
        Me.cbxFechaAvisoRecogida.Name = "cbxFechaAvisoRecogida"
        Me.cbxFechaAvisoRecogida.Size = New System.Drawing.Size(106, 21)
        Me.cbxFechaAvisoRecogida.TabIndex = 9
        '
        'lblFechaPrevistaRetorno
        '
        Me.lblFechaPrevistaRetorno.Location = New System.Drawing.Point(8, 128)
        Me.lblFechaPrevistaRetorno.Name = "lblFechaPrevistaRetorno"
        Me.lblFechaPrevistaRetorno.Size = New System.Drawing.Size(123, 13)
        Me.lblFechaPrevistaRetorno.TabIndex = 12
        Me.lblFechaPrevistaRetorno.Text = "Fecha Prev. Retorno"
        '
        'cbxFechaPrevistaRetorno
        '
        Me.cbxFechaPrevistaRetorno.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaPrevistaRetorno.Location = New System.Drawing.Point(136, 124)
        Me.cbxFechaPrevistaRetorno.Name = "cbxFechaPrevistaRetorno"
        Me.cbxFechaPrevistaRetorno.Size = New System.Drawing.Size(106, 21)
        Me.cbxFechaPrevistaRetorno.TabIndex = 8
        '
        'lblAlbaranRecogida
        '
        Me.lblAlbaranRecogida.Location = New System.Drawing.Point(8, 24)
        Me.lblAlbaranRecogida.Name = "lblAlbaranRecogida"
        Me.lblAlbaranRecogida.Size = New System.Drawing.Size(125, 13)
        Me.lblAlbaranRecogida.TabIndex = 13
        Me.lblAlbaranRecogida.Text = "Albarán de Recogida"
        '
        'txtAlbaranRecogida
        '
        Me.txtAlbaranRecogida.DisabledBackColor = System.Drawing.Color.White
        Me.txtAlbaranRecogida.Location = New System.Drawing.Point(136, 24)
        Me.txtAlbaranRecogida.Name = "txtAlbaranRecogida"
        Me.txtAlbaranRecogida.Size = New System.Drawing.Size(158, 21)
        Me.txtAlbaranRecogida.TabIndex = 3
        '
        'lblContactoObra
        '
        Me.lblContactoObra.Location = New System.Drawing.Point(8, 48)
        Me.lblContactoObra.Name = "lblContactoObra"
        Me.lblContactoObra.Size = New System.Drawing.Size(105, 13)
        Me.lblContactoObra.TabIndex = 14
        Me.lblContactoObra.Text = "Contacto Alquiler"
        '
        'advContactoObra
        '
        Me.advContactoObra.DisabledBackColor = System.Drawing.Color.White
        Me.advContactoObra.EntityName = "ObraPersonaContacto"
        Me.advContactoObra.Location = New System.Drawing.Point(136, 48)
        Me.advContactoObra.Name = "advContactoObra"
        Me.advContactoObra.SecondaryDataFields = "Nombre"
        Me.advContactoObra.Size = New System.Drawing.Size(158, 23)
        Me.advContactoObra.TabIndex = 4
        '
        'lblTelefono
        '
        Me.lblTelefono.Location = New System.Drawing.Point(321, 51)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(56, 13)
        Me.lblTelefono.TabIndex = 16
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtTelefono
        '
        Me.txtTelefono.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelefono.Location = New System.Drawing.Point(382, 48)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(107, 21)
        Me.txtTelefono.TabIndex = 5
        '
        'lbRecogidoPor
        '
        Me.lbRecogidoPor.Location = New System.Drawing.Point(8, 74)
        Me.lbRecogidoPor.Name = "lbRecogidoPor"
        Me.lbRecogidoPor.Size = New System.Drawing.Size(82, 13)
        Me.lbRecogidoPor.TabIndex = 17
        Me.lbRecogidoPor.Text = "Recogido por"
        '
        'ulDescOperario
        '
        Me.ulDescOperario.Location = New System.Drawing.Point(248, 76)
        Me.ulDescOperario.Name = "ulDescOperario"
        Me.ulDescOperario.Size = New System.Drawing.Size(241, 21)
        Me.ulDescOperario.TabIndex = 18
        '
        'advIDOperario
        '
        Me.advIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperario.EntityName = "Operario"
        Me.advIDOperario.Location = New System.Drawing.Point(136, 74)
        Me.advIDOperario.Name = "advIDOperario"
        Me.advIDOperario.SecondaryDataFields = "IDOperario"
        Me.advIDOperario.Size = New System.Drawing.Size(106, 23)
        Me.advIDOperario.TabIndex = 6
        '
        'lblMatricula
        '
        Me.lblMatricula.Location = New System.Drawing.Point(8, 100)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(58, 13)
        Me.lblMatricula.TabIndex = 19
        Me.lblMatricula.Text = "Matrícula"
        '
        'txtMatricula
        '
        Me.txtMatricula.DisabledBackColor = System.Drawing.Color.White
        Me.txtMatricula.Location = New System.Drawing.Point(136, 100)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(158, 21)
        Me.txtMatricula.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 388)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 40)
        Me.Panel1.TabIndex = 231
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(241, 5)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 15
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(141, 5)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.cmbAceptar.TabIndex = 14
        Me.cmbAceptar.Text = "Aceptar"
        '
        'frmDatosAviso
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(502, 428)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.fraDatosAviso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDatosAviso"
        Me.Text = "Preparación de Aviso de Retorno"
        Me.fraDatosAviso.ResumeLayout(False)
        Me.fraDatosAviso.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mVolcar As Boolean
    Private mdt As DataTable
    Private mContador, mNAlbaran As String
    Private mIDObra As Integer
    Private mdFechaPrevista As Date

#Region " Load "

    Public Function AbrirFormMaquinas(ByVal dt As DataTable, ByVal blnVolcar As Boolean, ByVal dtFechaPrevista As Date) As DialogResult
        mdt = dt
        mVolcar = blnVolcar

        mdFechaPrevista = dtFechaPrevista

        Dim data As New AvisoRetorno.dataContadorAvisoRetorno(dt.Rows(0)("IDCentroGestion"))
        ExpertisApp.ExecuteTask(Of AvisoRetorno.dataContadorAvisoRetorno)(AddressOf AvisoRetorno.GetContadorAvisoRetorno, data)

        txtAlbaranRecogida.Text = data.NAlbaran
        mIDObra = mdt.Rows(0)("IDObra")

        Me.ShowDialog()
        Return Me.DialogResult
    End Function

    Private Sub frmDatosAviso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            If Length(mdFechaPrevista) > 0 Then
                cbxFechaPrevistaRetorno.Value = mdFechaPrevista
            End If
            cbxFechaAvisoRecogida.Value = Date.Today
        End If
    End Sub

#End Region

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Length(advIDOperario.Text) = 0 Then
            ExpertisApp.GenerateMessage("Operario es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim data As New AvisoRetorno.dataAvisoRetorno(mdt, advIDOperario.Text, txtAlbaranRecogida.Text, mContador, advContactoObra.Text, txtTelefono.Text, _
                                                          advIDOperario.Text, txtMatricula.Text, cbxFechaAvisoRecogida.Value, cbxFechaPrevistaRetorno.Value, txtTexto.Text)

            ExpertisApp.ExecuteTask(Of AvisoRetorno.dataAvisoRetorno)(AddressOf AvisoRetorno.GenerarAvisoRetorno, data)
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub advRecogidoPor_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIDOperario.SelectionChanged
        ulDescOperario.Text = e.Selected.Rows(0)("DescOperario") & String.Empty
    End Sub

    Private Sub txtAlbaranRecogida_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlbaranRecogida.Validating
        If txtAlbaranRecogida.Text <> mNAlbaran Then
            mContador = String.Empty
        End If
    End Sub

    Private Sub advContactoObra_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advContactoObra.SetPredefinedFilter
        e.Filter.Add(New NumberFilterItem("IDObra", mIDObra))
    End Sub

End Class
