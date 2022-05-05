Public Class frmCambioDia
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
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblTipoDia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxTipoDia As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cbxTipoDia_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambioDia))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTipoDia = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoDia = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Panel1.suspendlayout()
        Me.Frame1.SuspendLayout()
        CType(Me.cbxTipoDia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 48)
        Me.Panel1.TabIndex = 6
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(237, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(112, 32)
        Me.cmbCancelar.TabIndex = 7
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(117, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(112, 32)
        Me.cmbAceptar.TabIndex = 6
        Me.cmbAceptar.Text = "Aceptar"
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.lblTipoDia)
        Me.Frame1.Controls.Add(Me.cbxTipoDia)
        Me.Frame1.Controls.Add(Me.lblFechaHasta)
        Me.Frame1.Controls.Add(Me.cbxFechaHasta)
        Me.Frame1.Controls.Add(Me.lblFechaDesde)
        Me.Frame1.Controls.Add(Me.cbxFechaDesde)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(456, 101)
        Me.Frame1.TabIndex = 7
        Me.Frame1.TabStop = False
        '
        'lblTipoDia
        '
        Me.lblTipoDia.Location = New System.Drawing.Point(128, 64)
        Me.lblTipoDia.Name = "lblTipoDia"
        Me.lblTipoDia.Size = New System.Drawing.Size(72, 13)
        Me.lblTipoDia.TabIndex = 0
        Me.lblTipoDia.Text = "Tipo de Día"
        '
        'cbxTipoDia
        '
        cbxTipoDia_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoDia_DesignTimeLayout.LayoutString")
        Me.cbxTipoDia.DesignTimeLayout = cbxTipoDia_DesignTimeLayout
        Me.cbxTipoDia.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoDia.Location = New System.Drawing.Point(200, 64)
        Me.cbxTipoDia.Name = "cbxTipoDia"
        Me.cbxTipoDia.SelectedIndex = -1
        Me.cbxTipoDia.SelectedItem = Nothing
        Me.cbxTipoDia.Size = New System.Drawing.Size(96, 21)
        Me.cbxTipoDia.TabIndex = 3
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(240, 32)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 4
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(320, 32)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaHasta.TabIndex = 2
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(48, 32)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 5
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(136, 32)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaDesde.TabIndex = 1
        '
        'frmCambioDia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(456, 149)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmCambioDia"
        Me.Text = "Modificación de los días en los Calendarios de Alquiler"
        Me.Panel1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.cbxTipoDia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mdtFechaDesde, mdtFechaHasta As Date
    Private mintTipoDia As Integer

    Public Function AbrirCambioDia(ByRef dtFechaDesde As Date, ByRef dtFechaHasta As Date, ByRef intTipoDia As Integer) As DialogResult
        cbxTipoDia.DataSource = New EnumData("TipoDiaObraEnum")

        Me.ShowDialog()

        If Me.DialogResult <> DialogResult.Cancel Then
            dtFechaDesde = cbxFechaDesde.Value
            dtFechaHasta = cbxFechaHasta.Value
            intTipoDia = cbxTipoDia.Value
        End If

        Return Me.DialogResult
    End Function

    Private Sub cbxFechaHasta_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxFechaHasta.Validated
        If Length(cbxFechaHasta.Value) > 0 AndAlso Length(cbxFechaDesde.Value) > 0 Then
            If cbxFechaHasta.Value < cbxFechaDesde.Value Then
                ExpertisApp.GenerateMessage("La Fecha Desde no puede ser menor que la Fecha Hasta.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbxFechaHasta.Value = String.Empty
                cbxFechaHasta.Focus()
            End If
        End If
    End Sub

    Private Sub cbxFechaDesde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxFechaDesde.Validated
        If Length(cbxFechaDesde.Value) > 0 Then
            cbxFechaHasta.Value = cbxFechaDesde.Value
        End If
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = DialogResult.None
        If length(cbxFechaDesde.Value) = 0 Or length(cbxFechaHasta.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe introducir las fechas para cambiar los dias.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf length(cbxTipoDia.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe introducir el tipo de dia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

End Class
