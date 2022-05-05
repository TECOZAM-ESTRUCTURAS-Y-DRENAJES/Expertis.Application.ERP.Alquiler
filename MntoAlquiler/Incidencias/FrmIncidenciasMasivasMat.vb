Public Class FrmIncidenciasMasivasMat
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
    Friend WithEvents pnlTrabajo As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ulDescTrabajo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlArticulo As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ulDescArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label


    Private Sub InitializeComponent()
        Dim cboAfectaFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIncidenciasMasivasMat))
        Me.pnlTrabajo = New Solmicro.Expertis.Engine.UI.Panel
        Me.ulDescTrabajo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlArticulo = New Solmicro.Expertis.Engine.UI.Panel
        Me.ulDescArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.FraCabecera.SuspendLayout()
        Me.pnlBottom.suspendlayout()
        CType(Me.cboAfectaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFill.suspendlayout()
        Me.pnlTrabajo.suspendlayout()
        Me.pnlArticulo.suspendlayout()
        Me.SuspendLayout()
        '
        'FraCabecera
        '
        Me.FraCabecera.Controls.Add(Me.pnlArticulo)
        Me.FraCabecera.Controls.Add(Me.pnlTrabajo)
        Me.FraCabecera.Size = New System.Drawing.Size(474, 80)
        '
        'pnlBottom
        '
        Me.pnlBottom.Location = New System.Drawing.Point(0, 357)
        Me.pnlBottom.Size = New System.Drawing.Size(474, 40)
        '
        'cmbOK
        '
        Me.cmbOK.Location = New System.Drawing.Point(121, 8)
        Me.cmbOK.Size = New System.Drawing.Size(113, 27)
        '
        'cmbCancel
        '
        Me.cmbCancel.Location = New System.Drawing.Point(241, 8)
        Me.cmbCancel.Size = New System.Drawing.Size(113, 27)
        '
        'lblcbxFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(8, 13)
        '
        'lblcbxFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(232, 13)
        '
        'cbxFechaFin
        '
        Me.cbxFechaFin.Location = New System.Drawing.Point(356, 7)
        Me.cbxFechaFin.Size = New System.Drawing.Size(109, 21)
        '
        'cbxFechaInicio
        '
        Me.cbxFechaInicio.Location = New System.Drawing.Point(112, 7)
        Me.cbxFechaInicio.Size = New System.Drawing.Size(109, 21)
        '
        'lbladvTipoIncidencia
        '
        Me.lblTipoIncidencia.Location = New System.Drawing.Point(8, 40)
        '
        'advTipoIncidencia
        '
        Me.advTipoIncidencia.Location = New System.Drawing.Point(112, 35)
        Me.advTipoIncidencia.Size = New System.Drawing.Size(109, 23)
        '
        'chkImprimible
        '
        Me.chkImprimible.Location = New System.Drawing.Point(232, 97)
        Me.chkImprimible.Size = New System.Drawing.Size(104, 19)
        '
        'lblcboAfectaFactura
        '
        Me.lblAfectaFactura.Location = New System.Drawing.Point(232, 71)
        '
        'cboAfectaFactura
        '
        cboAfectaFactura_DesignTimeLayout.LayoutString = resources.GetString("cboAfectaFactura_DesignTimeLayout.LayoutString")
        Me.cboAfectaFactura.DesignTimeLayout = cboAfectaFactura_DesignTimeLayout
        Me.cboAfectaFactura.Location = New System.Drawing.Point(356, 66)
        Me.cboAfectaFactura.Size = New System.Drawing.Size(109, 21)
        '
        'pnlFill
        '
        Me.pnlFill.Location = New System.Drawing.Point(0, 80)
        Me.pnlFill.Size = New System.Drawing.Size(474, 317)
        '
        'lblnbxCadencia
        '
        Me.lblCadencia.Location = New System.Drawing.Point(8, 100)
        '
        'nbxCadencia
        '
        Me.nbxCadencia.Location = New System.Drawing.Point(112, 95)
        Me.nbxCadencia.Size = New System.Drawing.Size(109, 21)
        '
        'lblnbxPorcentajeFact
        '
        Me.lblPorcentajeFact.Location = New System.Drawing.Point(8, 71)
        '
        'nbxPorcentajeFact
        '
        Me.nbxPorcentajeFact.Location = New System.Drawing.Point(112, 66)
        Me.nbxPorcentajeFact.Size = New System.Drawing.Size(109, 21)
        '
        'lbltxtObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(8, 126)
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(11, 148)
        Me.txtObservaciones.Size = New System.Drawing.Size(454, 123)
        '
        'pnlTrabajo
        '
        Me.pnlTrabajo.Controls.Add(Me.ulDescTrabajo)
        Me.pnlTrabajo.Controls.Add(Me.advIDTrabajo)
        Me.pnlTrabajo.Controls.Add(Me.lblTrabajo)
        Me.pnlTrabajo.Location = New System.Drawing.Point(8, 8)
        Me.pnlTrabajo.Name = "pnlTrabajo"
        Me.pnlTrabajo.Size = New System.Drawing.Size(466, 32)
        Me.pnlTrabajo.TabIndex = 18
        '
        'ulDescTrabajo
        '
        Me.ulDescTrabajo.Location = New System.Drawing.Point(182, 6)
        Me.ulDescTrabajo.Name = "ulDescTrabajo"
        Me.ulDescTrabajo.Size = New System.Drawing.Size(274, 23)
        Me.ulDescTrabajo.TabIndex = 19
        '
        'advIDTrabajo
        '
        Me.advIDTrabajo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescTrabajo", ulDescTrabajo)})
        Me.advIDTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTrabajo.DisplayField = "CodTrabajo"
        Me.advIDTrabajo.EntityName = "ObraTrabajo"
        Me.advIDTrabajo.Location = New System.Drawing.Point(76, 6)
        Me.advIDTrabajo.Name = "advIDTrabajo"
        Me.advIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.advIDTrabajo.Size = New System.Drawing.Size(102, 23)
        Me.advIDTrabajo.TabIndex = 18
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(3, 10)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(70, 13)
        Me.lblTrabajo.TabIndex = 17
        Me.lblTrabajo.Text = "O. Servicio"
        '
        'pnlArticulo
        '
        Me.pnlArticulo.Controls.Add(Me.ulDescArticulo)
        Me.pnlArticulo.Controls.Add(Me.advIDArticulo)
        Me.pnlArticulo.Controls.Add(Me.lblArticulo)
        Me.pnlArticulo.Location = New System.Drawing.Point(8, 41)
        Me.pnlArticulo.Name = "pnlArticulo"
        Me.pnlArticulo.Size = New System.Drawing.Size(466, 36)
        Me.pnlArticulo.TabIndex = 19
        '
        'ulDescArticulo
        '
        Me.ulDescArticulo.Location = New System.Drawing.Point(182, 7)
        Me.ulDescArticulo.Name = "ulDescArticulo"
        Me.ulDescArticulo.Size = New System.Drawing.Size(274, 23)
        Me.ulDescArticulo.TabIndex = 20
        '
        'advIDArticulo
        '
        Me.advIDArticulo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescMaterial", ulDescArticulo)})
        Me.advIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticulo.DisplayField = "IDMaterial"
        Me.advIDArticulo.EntityName = "ObraMaterial"
        Me.advIDArticulo.Location = New System.Drawing.Point(76, 7)
        Me.advIDArticulo.Name = "advIDArticulo"
        Me.advIDArticulo.SecondaryDataFields = "IDLineaMaterial"
        Me.advIDArticulo.Size = New System.Drawing.Size(102, 23)
        Me.advIDArticulo.TabIndex = 19
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(3, 12)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(52, 13)
        Me.lblArticulo.TabIndex = 18
        Me.lblArticulo.Text = "Material"
        '
        'FrmIncidenciasMasivasMat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(474, 397)
        Me.Name = "FrmIncidenciasMasivasMat"
        Me.Text = "Generación de Incidencias Masivas por Material"
        Me.FraCabecera.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        CType(Me.cboAfectaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFill.ResumeLayout(False)
        Me.pnlFill.PerformLayout()
        Me.pnlTrabajo.ResumeLayout(False)
        Me.pnlTrabajo.PerformLayout()
        Me.pnlArticulo.ResumeLayout(False)
        Me.pnlArticulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mintIDObra As Integer
    Private mintIDLineaMaterial As Integer

#Region " Métodos sobreescritos "

    Protected Overrides Function GeneracionMasivaIncidencias() As DataTable
        Dim dataIncidencias As New IncidenciasAlquiler.dataIncidencia(mintIDObra, advTipoIncidencia.Text, cbxFechaInicio.Value, cbxFechaFin.Value, _
                                                                      Nz(nbxCadencia.Value, 1), cboAfectaFactura.Value, chkImprimible.Checked, _
                                                                      Nz(nbxPorcentajeFact.Value, 100), txtObservaciones.Text, advIDTrabajo.Value, _
                                                                      IIf(mintIDLineaMaterial <> 0, mintIDLineaMaterial, advIDArticulo.Value), advIDArticulo.Text)
        Return ExpertisApp.ExecuteTask(Of IncidenciasAlquiler.dataIncidencia, DataTable)(AddressOf IncidenciasAlquiler.GenerarIncidencias, dataIncidencias)
    End Function

#End Region

    Private Sub FrmIncidenciasMasivasMat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            If Not pnlTrabajo.Visible Then
                pnlArticulo.Location = New Point(pnlArticulo.Location.X, (pnlTrabajo.Location.Y + pnlArticulo.Location.Y) / 2)
            End If
        End If
    End Sub

    Public Function AbrirIncidenciasMasivasMateriales(ByVal intIDObra As Integer, ByVal intIDTrabajo As Integer, _
                                                      ByVal strCodTrabajo As String, ByVal strDescTrabajo As String, _
                                                      ByVal blnTrabajoVisible As Boolean, ByVal blnTrabajoEnabled As Boolean, _
                                                      ByVal strIDMaterial As String, ByVal strDescMaterial As String, _
                                                      ByVal blnMaterialEnabled As Boolean, _
                                                      Optional ByVal intIDLineaMaterial As Integer = 0) As DialogResult
        mintIDObra = intIDObra
        advIDTrabajo.Value = intIDTrabajo
        advIDTrabajo.Text = strCodTrabajo
        ulDescTrabajo.Text = strDescTrabajo

        pnlTrabajo.Visible = blnTrabajoVisible
        pnlTrabajo.Enabled = blnTrabajoEnabled
        advIDArticulo.Text = strIDMaterial
        ulDescArticulo.Text = strDescMaterial

        pnlArticulo.Enabled = blnMaterialEnabled
        mintIDLineaMaterial = intIDLineaMaterial

        If Not pnlArticulo.Enabled Then
            If intIDLineaMaterial = 0 Then
                ExpertisApp.GenerateMessage("Debe indicar el Material", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Function
            End If
        End If

        Dim dr As DialogResult = Me.ShowDialog
        Return dr
    End Function

    Private Sub advIDArticulo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advIDArticulo.SetPredefinedFilter
        e.Filter.Add(New NumberFilterItem("IDTrabajo", advIDTrabajo.Value))
    End Sub
End Class
