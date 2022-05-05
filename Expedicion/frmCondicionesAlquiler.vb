Public Class frmCondicionesAlquiler
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
    Friend WithEvents Frame2 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents txtDescObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtNObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCondicionesEspPortes As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents chkPortesEspRetornos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkPortesEspSalidas As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtDescObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtNObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.Frame2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkPortesEspRetornos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkPortesEspSalidas = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.txtCondicionesEspPortes = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.txtDescObra)
        Me.Frame1.Controls.Add(Me.txtNObra)
        Me.Frame1.Controls.Add(Me.lblObra)
        Me.Frame1.Location = New System.Drawing.Point(6, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(520, 48)
        Me.Frame1.TabIndex = 8
        Me.Frame1.TabStop = False
        '
        'txtDescObra
        '
        Me.txtDescObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescObra.Enabled = False
        Me.txtDescObra.Location = New System.Drawing.Point(176, 16)
        Me.txtDescObra.Name = "txtDescObra"
        Me.txtDescObra.Size = New System.Drawing.Size(336, 21)
        Me.txtDescObra.TabIndex = 2
        '
        'txtNObra
        '
        Me.txtNObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtNObra.Enabled = False
        Me.txtNObra.Location = New System.Drawing.Point(64, 16)
        Me.txtNObra.Name = "txtNObra"
        Me.txtNObra.Size = New System.Drawing.Size(108, 21)
        Me.txtNObra.TabIndex = 1
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(8, 20)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(50, 13)
        Me.lblObra.TabIndex = 4
        Me.lblObra.Text = "Alquiler"
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.chkPortesEspRetornos)
        Me.Frame2.Controls.Add(Me.chkPortesEspSalidas)
        Me.Frame2.Controls.Add(Me.txtCondicionesEspPortes)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Location = New System.Drawing.Point(6, 48)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(520, 184)
        Me.Frame2.TabIndex = 9
        Me.Frame2.TabStop = False
        '
        'chkPortesEspRetornos
        '
        Me.chkPortesEspRetornos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPortesEspRetornos.Enabled = False
        Me.chkPortesEspRetornos.Location = New System.Drawing.Point(192, 16)
        Me.chkPortesEspRetornos.Name = "chkPortesEspRetornos"
        Me.chkPortesEspRetornos.Size = New System.Drawing.Size(144, 16)
        Me.chkPortesEspRetornos.TabIndex = 4
        Me.chkPortesEspRetornos.Text = "Portes Esp. Retornos"
        '
        'chkPortesEspSalidas
        '
        Me.chkPortesEspSalidas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPortesEspSalidas.Enabled = False
        Me.chkPortesEspSalidas.Location = New System.Drawing.Point(16, 16)
        Me.chkPortesEspSalidas.Name = "chkPortesEspSalidas"
        Me.chkPortesEspSalidas.Size = New System.Drawing.Size(136, 16)
        Me.chkPortesEspSalidas.TabIndex = 3
        Me.chkPortesEspSalidas.Text = "Portes Esp. Salidas"
        '
        'txtCondicionesEspPortes
        '
        Me.txtCondicionesEspPortes.DisabledBackColor = System.Drawing.Color.White
        Me.txtCondicionesEspPortes.Enabled = False
        Me.txtCondicionesEspPortes.Location = New System.Drawing.Point(16, 60)
        Me.txtCondicionesEspPortes.Multiline = True
        Me.txtCondicionesEspPortes.Name = "txtCondicionesEspPortes"
        Me.txtCondicionesEspPortes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCondicionesEspPortes.Size = New System.Drawing.Size(496, 117)
        Me.txtCondicionesEspPortes.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Condiciones Especiales Portes"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmbAceptar.Location = New System.Drawing.Point(208, 239)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(112, 32)
        Me.cmbAceptar.TabIndex = 6
        Me.cmbAceptar.Text = "Aceptar"
        '
        'frmCondicionesAlquiler
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(528, 277)
        Me.Controls.Add(Me.cmbAceptar)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.MaximizeBox = False
        Me.Name = "frmCondicionesAlquiler"
        Me.Text = "Condiciones Especiales de Alquiler"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub AbrirFormulario(ByVal IDObra As Integer)
        If Length(IDObra) > 0 Then
            Dim dt As DataTable = New ObraCabecera().Filter(New NumberFilterItem("IDObra", IDObra))
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                txtNObra.Text = dt.Rows(0)("NObra")
                txtDescObra.Text = dt.Rows(0)("DescObra") & String.Empty

                chkPortesEspSalidas.Checked = dt.Rows(0)("PortesEspSalidas")
                chkPortesEspRetornos.Checked = dt.Rows(0)("PortesEspRetornos")
                txtCondicionesEspPortes.Text = dt.Rows(0)("CondicionesEspPortes") & String.Empty
                Me.ShowDialog()
            End If
        End If
    End Sub

End Class
