Public Class frmIncidenciasMasivasAlquiler
    Inherits Solmicro.Expertis.Application.ERP.Alquiler.frmIncidenciasMasivasBase

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

    Friend WithEvents lbltxtIDObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIDObra As Solmicro.Expertis.Engine.UI.TextBox
    Private Sub InitializeComponent()
        Dim cboAfectaFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncidenciasMasivasAlquiler))
        Me.lbltxtIDObra = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraCabecera.SuspendLayout()
        Me.pnlBottom.suspendlayout()
        CType(Me.cboAfectaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFill.suspendlayout()
        Me.SuspendLayout()
        '
        'FraCabecera
        '
        Me.FraCabecera.Controls.Add(Me.lbltxtIDObra)
        Me.FraCabecera.Controls.Add(Me.txtIDObra)
        Me.FraCabecera.Size = New System.Drawing.Size(440, 48)
        '
        'pnlBottom
        '
        Me.pnlBottom.Location = New System.Drawing.Point(0, 343)
        '
        'lblcbxFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(7, 13)
        '
        'lblcbxFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(215, 13)
        '
        'cbxFechaFin
        '
        Me.cbxFechaFin.Location = New System.Drawing.Point(330, 7)
        '
        'cbxFechaInicio
        '
        Me.cbxFechaInicio.Location = New System.Drawing.Point(104, 7)
        '
        'lbladvTipoIncidencia
        '
        Me.lblTipoIncidencia.Location = New System.Drawing.Point(7, 42)
        '
        'advTipoIncidencia
        '
        Me.advTipoIncidencia.Location = New System.Drawing.Point(104, 37)
        '
        'chkImprimible
        '
        Me.chkImprimible.Location = New System.Drawing.Point(215, 103)
        '
        'lblcboAfectaFactura
        '
        Me.lblAfectaFactura.Location = New System.Drawing.Point(215, 75)
        '
        'cboAfectaFactura
        '
        cboAfectaFactura_DesignTimeLayout.LayoutString = resources.GetString("cboAfectaFactura_DesignTimeLayout.LayoutString")
        Me.cboAfectaFactura.DesignTimeLayout = cboAfectaFactura_DesignTimeLayout
        Me.cboAfectaFactura.Location = New System.Drawing.Point(330, 70)
        '
        'pnlFill
        '
        Me.pnlFill.Location = New System.Drawing.Point(0, 48)
        Me.pnlFill.Size = New System.Drawing.Size(440, 335)
        '
        'lblnbxCadencia
        '
        Me.lblCadencia.Location = New System.Drawing.Point(7, 105)
        '
        'nbxCadencia
        '
        Me.nbxCadencia.Location = New System.Drawing.Point(104, 100)
        '
        'lblnbxPorcentajeFact
        '
        Me.lblPorcentajeFact.Location = New System.Drawing.Point(7, 75)
        '
        'nbxPorcentajeFact
        '
        Me.nbxPorcentajeFact.Location = New System.Drawing.Point(104, 70)
        '
        'lbltxtObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(7, 133)
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(10, 156)
        Me.txtObservaciones.Size = New System.Drawing.Size(421, 133)
        '
        'lbltxtIDObra
        '
        Me.lbltxtIDObra.Location = New System.Drawing.Point(12, 20)
        Me.lbltxtIDObra.Name = "lbltxtIDObra"
        Me.lbltxtIDObra.Size = New System.Drawing.Size(50, 13)
        Me.lbltxtIDObra.TabIndex = 3
        Me.lbltxtIDObra.Text = "Alquiler"
        '
        'txtIDObra
        '
        Me.txtIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDObra.Enabled = False
        Me.txtIDObra.Location = New System.Drawing.Point(70, 16)
        Me.txtIDObra.Name = "txtIDObra"
        Me.txtIDObra.Size = New System.Drawing.Size(112, 21)
        Me.txtIDObra.TabIndex = 2
        '
        'frmIncidenciasMasivasAlquiler
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(440, 383)
        Me.Name = "frmIncidenciasMasivasAlquiler"
        Me.Text = "Generación de Incidencias Masivas por Alquiler"
        Me.FraCabecera.ResumeLayout(False)
        Me.FraCabecera.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        CType(Me.cboAfectaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFill.ResumeLayout(False)
        Me.pnlFill.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mIDObra As Integer

#Region " Métodos sobreescritos "

    Protected Overrides Function GeneracionMasivaIncidencias() As DataTable
        Dim dataIncidencias As New IncidenciasAlquiler.dataIncidencia(mIDObra, advTipoIncidencia.Text, cbxFechaInicio.Value, cbxFechaFin.Value, Nz(nbxCadencia.Value, 1), cboAfectaFactura.Value, chkImprimible.Checked, Nz(nbxPorcentajeFact.Value, 100), txtObservaciones.Text)
        Return ExpertisApp.ExecuteTask(Of IncidenciasAlquiler.dataIncidencia, DataTable)(AddressOf IncidenciasAlquiler.GenerarIncidencias, dataIncidencias)
    End Function

#End Region

    Public Function AbrirIncidenciasMasivasAlquiler(ByVal IDObra As Integer, ByVal NObra As String) As DialogResult
        mIDObra = IDObra
        txtIDObra.Text = NObra

        Return Me.ShowDialog
    End Function

End Class
