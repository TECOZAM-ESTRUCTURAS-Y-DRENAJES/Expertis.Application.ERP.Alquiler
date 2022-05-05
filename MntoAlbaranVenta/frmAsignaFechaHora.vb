Public Class frmAsignaFechaHora
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
    Friend WithEvents lblFechaRetorno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblHoraRetorno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cbxFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents txtHora As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblFechaRetorno = New Solmicro.Expertis.Engine.UI.Label
        Me.lblHoraRetorno = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.txtHora = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.SuspendLayout()
        '
        'lblFechaRetorno
        '
        Me.lblFechaRetorno.Location = New System.Drawing.Point(17, 17)
        Me.lblFechaRetorno.Name = "lblFechaRetorno"
        Me.lblFechaRetorno.Size = New System.Drawing.Size(136, 13)
        Me.lblFechaRetorno.TabIndex = 0
        Me.lblFechaRetorno.Text = "Fecha Retorno Alquiler"
        '
        'lblHoraRetorno
        '
        Me.lblHoraRetorno.Location = New System.Drawing.Point(17, 42)
        Me.lblHoraRetorno.Name = "lblHoraRetorno"
        Me.lblHoraRetorno.Size = New System.Drawing.Size(130, 13)
        Me.lblHoraRetorno.TabIndex = 1
        Me.lblHoraRetorno.Text = "Hora Retorno Alquiler"
        '
        'cbxFecha
        '
        Me.cbxFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFecha.Location = New System.Drawing.Point(161, 17)
        Me.cbxFecha.Name = "cbxFecha"
        Me.cbxFecha.Size = New System.Drawing.Size(104, 21)
        Me.cbxFecha.TabIndex = 2
        '
        'txtHora
        '
        Me.txtHora.DisabledBackColor = System.Drawing.Color.White
        Me.txtHora.Location = New System.Drawing.Point(161, 42)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(104, 21)
        Me.txtHora.TabIndex = 3
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(56, 76)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(80, 29)
        Me.cmbAceptar.TabIndex = 4
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(147, 76)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(88, 29)
        Me.cmbCancelar.TabIndex = 5
        Me.cmbCancelar.Text = "Cancelar"
        '
        'frmAsignaFechaHora
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(290, 117)
        Me.Controls.Add(Me.cmbCancelar)
        Me.Controls.Add(Me.cmbAceptar)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.cbxFecha)
        Me.Controls.Add(Me.lblHoraRetorno)
        Me.Controls.Add(Me.lblFechaRetorno)
        Me.MaximizeBox = False
        Me.Name = "frmAsignaFechaHora"
        Me.Text = "Asignación de Fecha y Hora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private dtmFecha As Date
    Public ReadOnly Property Fecha() As Date
        Get
            Return dtmFecha
        End Get
    End Property

    Private dtmHora As Date
    Public ReadOnly Property Hora() As Date
        Get
            Return dtmHora
        End Get
    End Property

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        dtmFecha = Nz(cbxFecha.Value, Date.Today)
        dtmHora = Nz(txtHora.Text, Format(Date.Now, "HH:mm:ss"))

        If ValidarCampos() Then Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Function ValidarCampos() As Boolean
        Dim strMessage As String = String.Empty
        If Length(cbxFecha.Value) = 0 And Length(txtHora.Text) = 0 Then
            strMessage = "No ha rellenado los campos Fecha y Hora. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
        ElseIf Length(cbxFecha.Value) = 0 Then
            strMessage = "No ha rellenado el campo Fecha. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
        ElseIf Length(txtHora.Text) = 0 Then
            strMessage = "No ha rellenado el campo Hora. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
        End If
        If Length(strMessage) > 0 Then
            If ExpertisApp.GenerateMessage(strMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub txtHora_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHora.Validated
        Dim tmHoraAlquiler As Date
        If Length(txtHora.Text) > 0 Then
            If InStr(txtHora.Text, ":") = 0 Then
                tmHoraAlquiler = txtHora.Text & ":0"
            Else
                tmHoraAlquiler = txtHora.Text
            End If
            txtHora.Text = Format(tmHoraAlquiler, "HH:mm:ss")
        End If
    End Sub

End Class
