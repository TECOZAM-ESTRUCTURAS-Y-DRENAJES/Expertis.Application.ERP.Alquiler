Public Class frmFianza
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
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cbxFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFianza As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtFianza As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbxFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFianza = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtFianza = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'cbxFecha
        '
        Me.cbxFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFecha.Location = New System.Drawing.Point(144, 16)
        Me.cbxFecha.Name = "cbxFecha"
        Me.cbxFecha.Size = New System.Drawing.Size(96, 21)
        Me.cbxFecha.TabIndex = 0
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(8, 16)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(130, 13)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "Fecha de pago Fianza"
        '
        'lblFianza
        '
        Me.lblFianza.Location = New System.Drawing.Point(8, 40)
        Me.lblFianza.Name = "lblFianza"
        Me.lblFianza.Size = New System.Drawing.Size(43, 13)
        Me.lblFianza.TabIndex = 5
        Me.lblFianza.Text = "Fianza"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancel)
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 40)
        Me.Panel1.TabIndex = 6
        '
        'cmbCancel
        '
        Me.cmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancel.Location = New System.Drawing.Point(126, 7)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(92, 27)
        Me.cmbCancel.TabIndex = 3
        Me.cmbCancel.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(30, 7)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(92, 27)
        Me.cmbAceptar.TabIndex = 2
        Me.cmbAceptar.Text = "Aceptar"
        '
        'txtFianza
        '
        Me.txtFianza.DisabledBackColor = System.Drawing.Color.White
        Me.txtFianza.Location = New System.Drawing.Point(144, 40)
        Me.txtFianza.Name = "txtFianza"
        Me.txtFianza.Size = New System.Drawing.Size(96, 21)
        Me.txtFianza.TabIndex = 1
        '
        'frmFianza
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(256, 109)
        Me.Controls.Add(Me.txtFianza)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblFianza)
        Me.Controls.Add(Me.cbxFecha)
        Me.Name = "frmFianza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Fianzas"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Function AbrirAltaFianzas(ByRef dtmFechaFianza As Date, ByRef dblFianza As Double) As DialogResult
        cbxFecha.Value = dtmFechaFianza

        Me.ShowDialog()

        dtmFechaFianza = Nz(cbxFecha.Value, Now.Date)
        dblFianza = Nz(txtFianza.Value, 0)

        Return Me.DialogResult
    End Function

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        Dim Cancel As Boolean = False
        If length(cbxFecha.Value) = 0 Then
            If ExpertisApp.GenerateMessage("No ha rellenado el campo Fecha. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Cancel = True
            End If
        End If
        If Not Cancel Then Me.DialogResult = DialogResult.OK
    End Sub
 
End Class
