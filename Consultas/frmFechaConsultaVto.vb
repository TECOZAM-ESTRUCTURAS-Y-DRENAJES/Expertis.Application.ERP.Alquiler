Public Class frmFechaConsultaVto
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
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.cbxFecha)
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(344, 63)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Fecha para la previsión del cálculo de la facturación"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(94, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha"
        '
        'cbxFecha
        '
        Me.cbxFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFecha.Location = New System.Drawing.Point(143, 32)
        Me.cbxFecha.Name = "cbxFecha"
        Me.cbxFecha.Size = New System.Drawing.Size(104, 21)
        Me.cbxFecha.TabIndex = 3
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(176, 72)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(104, 29)
        Me.cmbCancelar.TabIndex = 9
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(64, 72)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(104, 29)
        Me.cmbAceptar.TabIndex = 8
        Me.cmbAceptar.Text = "Aceptar"
        '
        'frmFechaConsultaVto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(344, 106)
        Me.Controls.Add(Me.cmbCancelar)
        Me.Controls.Add(Me.cmbAceptar)
        Me.Controls.Add(Me.Frame1)
        Me.MaximizeBox = False
        Me.Name = "frmFechaConsultaVto"
        Me.Text = "Fecha Consulta de Previsión"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFechaConsultaVto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbxFecha.Value = Today
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Length(cbxFecha.Value) > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            ExpertisApp.GenerateMessage("La Fecha es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class
