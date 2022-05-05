Public Class frmIncidenciasMasivasTrabajo
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents txtOrdenServicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cboAfectaFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncidenciasMasivasTrabajo))
        Me.txtOrdenServicio = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraCabecera.SuspendLayout()
        Me.pnlBottom.suspendlayout()
        CType(Me.cboAfectaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFill.suspendlayout()
        Me.SuspendLayout()
        '
        'FraCabecera
        '
        Me.FraCabecera.Controls.Add(Me.txtOrdenServicio)
        Me.FraCabecera.Controls.Add(Me.txtDescTrabajo)
        Me.FraCabecera.Controls.Add(Me.txtCodTrabajo)
        Me.FraCabecera.Size = New System.Drawing.Size(440, 44)
        '
        'pnlBottom
        '
        Me.pnlBottom.Location = New System.Drawing.Point(0, 357)
        '
        'lblcbxFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(7, 14)
        '
        'lblcbxFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(215, 14)
        '
        'cbxFechaFin
        '
        Me.cbxFechaFin.Location = New System.Drawing.Point(330, 8)
        '
        'cbxFechaInicio
        '
        Me.cbxFechaInicio.Location = New System.Drawing.Point(104, 8)
        '
        'lbladvTipoIncidencia
        '
        Me.lblTipoIncidencia.Location = New System.Drawing.Point(7, 45)
        '
        'advTipoIncidencia
        '
        Me.advTipoIncidencia.Location = New System.Drawing.Point(104, 40)
        '
        'chkImprimible
        '
        Me.chkImprimible.Location = New System.Drawing.Point(215, 108)
        '
        'lblcboAfectaFactura
        '
        Me.lblAfectaFactura.Location = New System.Drawing.Point(215, 79)
        '
        'cboAfectaFactura
        '
        cboAfectaFactura_DesignTimeLayout.LayoutString = resources.GetString("cboAfectaFactura_DesignTimeLayout.LayoutString")
        Me.cboAfectaFactura.DesignTimeLayout = cboAfectaFactura_DesignTimeLayout
        Me.cboAfectaFactura.Location = New System.Drawing.Point(330, 74)
        '
        'pnlFill
        '
        Me.pnlFill.Location = New System.Drawing.Point(0, 44)
        Me.pnlFill.Size = New System.Drawing.Size(440, 353)
        '
        'lblnbxCadencia
        '
        Me.lblCadencia.Location = New System.Drawing.Point(7, 111)
        '
        'nbxCadencia
        '
        Me.nbxCadencia.Location = New System.Drawing.Point(104, 106)
        '
        'lblnbxPorcentajeFact
        '
        Me.lblPorcentajeFact.Location = New System.Drawing.Point(7, 79)
        '
        'nbxPorcentajeFact
        '
        Me.nbxPorcentajeFact.Location = New System.Drawing.Point(104, 74)
        '
        'lbltxtObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(7, 140)
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(10, 164)
        Me.txtObservaciones.Size = New System.Drawing.Size(421, 143)
        '
        'txtOrdenServicio
        '
        Me.txtOrdenServicio.Location = New System.Drawing.Point(12, 19)
        Me.txtOrdenServicio.Name = "txtOrdenServicio"
        Me.txtOrdenServicio.Size = New System.Drawing.Size(70, 13)
        Me.txtOrdenServicio.TabIndex = 10
        Me.txtOrdenServicio.Text = "O. Servicio"
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(213, 15)
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(218, 21)
        Me.txtDescTrabajo.TabIndex = 9
        '
        'txtCodTrabajo
        '
        Me.txtCodTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodTrabajo.Enabled = False
        Me.txtCodTrabajo.Location = New System.Drawing.Point(86, 15)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(124, 21)
        Me.txtCodTrabajo.TabIndex = 8
        '
        'frmIncidenciasMasivasTrabajo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(440, 397)
        Me.Name = "frmIncidenciasMasivasTrabajo"
        Me.Text = "Generación de Incidencias Masivas por Orden de Servicio"
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
    Private mIDTrabajo As Integer

#Region " Métodos sobreescritos "

    Protected Overrides Function GeneracionMasivaIncidencias() As DataTable
        Dim dataIncidencias As New IncidenciasAlquiler.dataIncidencia(mIDObra, advTipoIncidencia.Text, cbxFechaInicio.Value, cbxFechaFin.Value, Nz(nbxCadencia.Value, 1), cboAfectaFactura.Value, chkImprimible.Checked, Nz(nbxPorcentajeFact.Value, 100), txtObservaciones.Text, mIDTrabajo)
        Return ExpertisApp.ExecuteTask(Of IncidenciasAlquiler.dataIncidencia, DataTable)(AddressOf IncidenciasAlquiler.GenerarIncidencias, dataIncidencias)
    End Function

#End Region

    Public Function AbrirIncidenciasMasivasTrabajo(ByVal IDObra As Integer, ByVal IDTrabajo As Integer, ByVal CodTrabajo As String, ByVal DescTrabajo As String) As DialogResult
        mIDObra = IDObra
        mIDTrabajo = IDTrabajo
        txtCodTrabajo.Text = CodTrabajo
        txtDescTrabajo.Text = DescTrabajo

        Return Me.ShowDialog
    End Function

End Class
