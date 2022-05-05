Public Class frmFechaIncidencias
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
    Friend WithEvents cbxFechaInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFin As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1.SuspendLayout()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.lblFechaInicio)
        Me.Frame1.Controls.Add(Me.cbxFechaInicio)
        Me.Frame1.Controls.Add(Me.lblFechaFin)
        Me.Frame1.Controls.Add(Me.cbxFechaFin)
        Me.Frame1.Location = New System.Drawing.Point(-1, -5)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(377, 97)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Selección de Fechas para el listado de Incidencias del Alquiler"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(91, 47)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaInicio.TabIndex = 7
        Me.lblFechaInicio.Text = "Fecha Desde"
        '
        'cbxFechaInicio
        '
        Me.cbxFechaInicio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicio.Location = New System.Drawing.Point(179, 43)
        Me.cbxFechaInicio.Name = "cbxFechaInicio"
        Me.cbxFechaInicio.Size = New System.Drawing.Size(93, 21)
        Me.cbxFechaInicio.TabIndex = 0
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(91, 73)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(79, 13)
        Me.lblFechaFin.TabIndex = 8
        Me.lblFechaFin.Text = "Fecha hasta "
        '
        'cbxFechaFin
        '
        Me.cbxFechaFin.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFin.Location = New System.Drawing.Point(179, 70)
        Me.cbxFechaFin.Name = "cbxFechaFin"
        Me.cbxFechaFin.Size = New System.Drawing.Size(93, 21)
        Me.cbxFechaFin.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 48)
        Me.Panel1.TabIndex = 9
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(184, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(104, 32)
        Me.cmbCancelar.TabIndex = 1
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(72, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(104, 32)
        Me.cmbAceptar.TabIndex = 0
        Me.cmbAceptar.Text = "Aceptar"
        '
        'frmFechaIncidencias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(376, 140)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Frame1)
        Me.MaximizeBox = False
        Me.Name = "frmFechaIncidencias"
        Me.Text = "Selección de Fechas"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public mFiltro As Filter
    Public mIDObra As Integer

    Private Sub cbxFechaInicio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxFechaInicio.ValueChanged
        cbxFechaFin.Value = cbxFechaInicio.Value
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Dim f As New Filter
        f.Add("FechaIncidencia", FilterOperator.GreaterThanOrEqual, cbxFechaInicio.Value, FilterType.DateTime)
        f.Add("FechaIncidencia", FilterOperator.LessThanOrEqual, cbxFechaFin.Value, FilterType.DateTime)
        If mIDObra > 0 Then
            f.Add(New NumberFilterItem("IDObra", mIDObra))
        End If
        mFiltro = f
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class
