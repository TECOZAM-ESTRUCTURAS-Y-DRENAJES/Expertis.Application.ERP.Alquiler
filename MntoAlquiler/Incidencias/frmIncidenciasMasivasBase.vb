Public Class frmIncidenciasMasivasBase
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
    Public WithEvents FraCabecera As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents cmbOK As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents lblFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFechaFin As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents cbxFechaInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblTipoIncidencia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advTipoIncidencia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulDescTipoIncidencia As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents chkImprimible As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblAfectaFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cboAfectaFactura As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents pnlFill As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblCadencia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents nbxCadencia As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblPorcentajeFact As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents nbxPorcentajeFact As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblObservaciones As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtObservaciones As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cboAfectaFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncidenciasMasivasBase))
        Me.FraCabecera = New Solmicro.Expertis.Engine.UI.Frame
        Me.pnlFill = New Solmicro.Expertis.Engine.UI.Panel
        Me.ulDescTipoIncidencia = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblTipoIncidencia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.chkImprimible = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblCadencia = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxCadencia = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPorcentajeFact = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxPorcentajeFact = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblAfectaFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.cboAfectaFactura = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblObservaciones = New Solmicro.Expertis.Engine.UI.Label
        Me.txtObservaciones = New Solmicro.Expertis.Engine.UI.TextBox
        Me.advTipoIncidencia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbOK = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlFill.suspendlayout()
        CType(Me.cboAfectaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.suspendlayout()
        Me.SuspendLayout()
        '
        'FraCabecera
        '
        Me.FraCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraCabecera.Location = New System.Drawing.Point(0, 0)
        Me.FraCabecera.Name = "FraCabecera"
        Me.FraCabecera.Size = New System.Drawing.Size(440, 88)
        Me.FraCabecera.TabIndex = 0
        Me.FraCabecera.TabStop = False
        '
        'pnlFill
        '
        Me.pnlFill.Controls.Add(Me.ulDescTipoIncidencia)
        Me.pnlFill.Controls.Add(Me.lblTipoIncidencia)
        Me.pnlFill.Controls.Add(Me.lblFechaInicio)
        Me.pnlFill.Controls.Add(Me.chkImprimible)
        Me.pnlFill.Controls.Add(Me.lblCadencia)
        Me.pnlFill.Controls.Add(Me.nbxCadencia)
        Me.pnlFill.Controls.Add(Me.lblPorcentajeFact)
        Me.pnlFill.Controls.Add(Me.nbxPorcentajeFact)
        Me.pnlFill.Controls.Add(Me.lblAfectaFactura)
        Me.pnlFill.Controls.Add(Me.cboAfectaFactura)
        Me.pnlFill.Controls.Add(Me.lblObservaciones)
        Me.pnlFill.Controls.Add(Me.txtObservaciones)
        Me.pnlFill.Controls.Add(Me.advTipoIncidencia)
        Me.pnlFill.Controls.Add(Me.lblFechaFin)
        Me.pnlFill.Controls.Add(Me.cbxFechaFin)
        Me.pnlFill.Controls.Add(Me.cbxFechaInicio)
        Me.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFill.Location = New System.Drawing.Point(0, 88)
        Me.pnlFill.Name = "pnlFill"
        Me.pnlFill.Size = New System.Drawing.Size(440, 277)
        Me.pnlFill.TabIndex = 1
        '
        'ulDescTipoIncidencia
        '
        Me.ulDescTipoIncidencia.Location = New System.Drawing.Point(211, 30)
        Me.ulDescTipoIncidencia.Name = "ulDescTipoIncidencia"
        Me.ulDescTipoIncidencia.Size = New System.Drawing.Size(220, 23)
        Me.ulDescTipoIncidencia.TabIndex = 37
        '
        'lblTipoIncidencia
        '
        Me.lblTipoIncidencia.Location = New System.Drawing.Point(7, 35)
        Me.lblTipoIncidencia.Name = "lblTipoIncidencia"
        Me.lblTipoIncidencia.Size = New System.Drawing.Size(93, 13)
        Me.lblTipoIncidencia.TabIndex = 36
        Me.lblTipoIncidencia.Text = "Tipo Incidencia"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(7, 11)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(75, 13)
        Me.lblFechaInicio.TabIndex = 35
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'chkImprimible
        '
        Me.chkImprimible.Location = New System.Drawing.Point(215, 85)
        Me.chkImprimible.Name = "chkImprimible"
        Me.chkImprimible.Size = New System.Drawing.Size(97, 19)
        Me.chkImprimible.TabIndex = 27
        Me.chkImprimible.Text = "Imprimible"
        '
        'lblCadencia
        '
        Me.lblCadencia.Location = New System.Drawing.Point(7, 87)
        Me.lblCadencia.Name = "lblCadencia"
        Me.lblCadencia.Size = New System.Drawing.Size(60, 13)
        Me.lblCadencia.TabIndex = 29
        Me.lblCadencia.Text = "Cadencia"
        '
        'nbxCadencia
        '
        Me.nbxCadencia.DisabledBackColor = System.Drawing.Color.White
        Me.nbxCadencia.Location = New System.Drawing.Point(104, 83)
        Me.nbxCadencia.Name = "nbxCadencia"
        Me.nbxCadencia.Size = New System.Drawing.Size(101, 21)
        Me.nbxCadencia.TabIndex = 26
        '
        'lblPorcentajeFact
        '
        Me.lblPorcentajeFact.Location = New System.Drawing.Point(7, 62)
        Me.lblPorcentajeFact.Name = "lblPorcentajeFact"
        Me.lblPorcentajeFact.Size = New System.Drawing.Size(88, 13)
        Me.lblPorcentajeFact.TabIndex = 30
        Me.lblPorcentajeFact.Text = "% Facturación"
        '
        'nbxPorcentajeFact
        '
        Me.nbxPorcentajeFact.DisabledBackColor = System.Drawing.Color.White
        Me.nbxPorcentajeFact.Location = New System.Drawing.Point(104, 58)
        Me.nbxPorcentajeFact.Name = "nbxPorcentajeFact"
        Me.nbxPorcentajeFact.Size = New System.Drawing.Size(101, 21)
        Me.nbxPorcentajeFact.TabIndex = 24
        '
        'lblAfectaFactura
        '
        Me.lblAfectaFactura.Location = New System.Drawing.Point(215, 62)
        Me.lblAfectaFactura.Name = "lblAfectaFactura"
        Me.lblAfectaFactura.Size = New System.Drawing.Size(111, 13)
        Me.lblAfectaFactura.TabIndex = 31
        Me.lblAfectaFactura.Text = "Influye en Factura"
        '
        'cboAfectaFactura
        '
        cboAfectaFactura_DesignTimeLayout.LayoutString = resources.GetString("cboAfectaFactura_DesignTimeLayout.LayoutString")
        Me.cboAfectaFactura.DesignTimeLayout = cboAfectaFactura_DesignTimeLayout
        Me.cboAfectaFactura.DisabledBackColor = System.Drawing.Color.White
        Me.cboAfectaFactura.Location = New System.Drawing.Point(330, 58)
        Me.cboAfectaFactura.Name = "cboAfectaFactura"
        Me.cboAfectaFactura.SelectedIndex = -1
        Me.cboAfectaFactura.SelectedItem = Nothing
        Me.cboAfectaFactura.Size = New System.Drawing.Size(101, 21)
        Me.cboAfectaFactura.TabIndex = 25
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(7, 110)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(91, 13)
        Me.lblObservaciones.TabIndex = 32
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.DisabledBackColor = System.Drawing.Color.White
        Me.txtObservaciones.Location = New System.Drawing.Point(10, 129)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(421, 107)
        Me.txtObservaciones.TabIndex = 28
        '
        'advTipoIncidencia
        '
        Me.advTipoIncidencia.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescIncidenciasAlquiler", ulDescTipoIncidencia), New Solmicro.Expertis.Engine.UI.ASSelectedField("Imprimible", chkImprimible), New Solmicro.Expertis.Engine.UI.ASSelectedField("AfectaFactura", cboAfectaFactura)})
        Me.advTipoIncidencia.DisabledBackColor = System.Drawing.Color.White
        Me.advTipoIncidencia.EntityName = "IncidenciasAlquiler"
        Me.advTipoIncidencia.Location = New System.Drawing.Point(104, 31)
        Me.advTipoIncidencia.Name = "advTipoIncidencia"
        Me.advTipoIncidencia.SecondaryDataFields = "IDIncidenciasAlquiler"
        Me.advTipoIncidencia.Size = New System.Drawing.Size(101, 23)
        Me.advTipoIncidencia.TabIndex = 23
        Me.advTipoIncidencia.ViewName = "tbMaestroIncidenciasAlquiler"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(215, 11)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(60, 13)
        Me.lblFechaFin.TabIndex = 34
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'cbxFechaFin
        '
        Me.cbxFechaFin.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFin.Location = New System.Drawing.Point(330, 6)
        Me.cbxFechaFin.Name = "cbxFechaFin"
        Me.cbxFechaFin.Size = New System.Drawing.Size(101, 21)
        Me.cbxFechaFin.TabIndex = 22
        '
        'cbxFechaInicio
        '
        Me.cbxFechaInicio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicio.Location = New System.Drawing.Point(104, 6)
        Me.cbxFechaInicio.Name = "cbxFechaInicio"
        Me.cbxFechaInicio.Size = New System.Drawing.Size(101, 21)
        Me.cbxFechaInicio.TabIndex = 21
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.cmbOK)
        Me.pnlBottom.Controls.Add(Me.cmbCancel)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 325)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(440, 40)
        Me.pnlBottom.TabIndex = 2
        '
        'cmbOK
        '
        Me.cmbOK.Location = New System.Drawing.Point(112, 8)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(105, 27)
        Me.cmbOK.TabIndex = 10
        Me.cmbOK.Text = "Aceptar"
        '
        'cmbCancel
        '
        Me.cmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancel.Location = New System.Drawing.Point(224, 8)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(105, 27)
        Me.cmbCancel.TabIndex = 11
        Me.cmbCancel.Text = "Cancelar"
        '
        'frmIncidenciasMasivasBase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(440, 365)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlFill)
        Me.Controls.Add(Me.FraCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmIncidenciasMasivasBase"
        Me.Text = "frmIncidenciasMasivasBase"
        Me.pnlFill.ResumeLayout(False)
        Me.pnlFill.PerformLayout()
        CType(Me.cboAfectaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mblnCancel As Boolean

#Region " Carga del formulario "

    Private Sub frmIncidenciasMasivasBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadEnums()
            LoadDefaultValues()
        End If
    End Sub

    Private Sub LoadEnums()
        cboAfectaFactura.DataSource = New EnumData("enumiaAfectaFactura")
    End Sub

    Private Sub LoadDefaultValues()
        nbxPorcentajeFact.Value = 100
        nbxCadencia.Value = 1
    End Sub

#End Region

#Region " Validaciones, ....  de controles "

    Private Sub cbxFechaFin_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxFechaFin.Validating
        e.Cancel = Not (ValidarFechas(Nz(cbxFechaInicio.Value, String.Empty), Nz(cbxFechaFin.Value, String.Empty)))
    End Sub

    Private Sub cbxFechaInicio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxFechaInicio.Validating
        e.Cancel = Not (ValidarFechas(Nz(cbxFechaInicio.Value, String.Empty), Nz(cbxFechaFin.Value, String.Empty)))
    End Sub

    Private Function ValidarFechas(ByVal strFechaDesde As String, ByVal strFechaHasta As String) As Boolean
        ValidarFechas = True
        If (length(strFechaDesde) > 0) AndAlso (length(strFechaHasta) > 0) Then
            If CDate(strFechaDesde) > CDate(strFechaHasta) Then
                ValidarFechas = False
                ExpertisApp.GenerateMessage("La Fecha Inicial ha de ser menor o igual que la Fecha Final.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf DateDiff("yyyy", CDate(strFechaDesde), CDate(strFechaHasta)) > 1 Then
                ValidarFechas = False
                ExpertisApp.GenerateMessage("No puede haber una diferencia entre fechas superior a un año.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Function

#End Region

#Region " Aceptar/Cancelar "

    Private Sub cmbOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOK.Click
        If VerificarDatos() Then
            Dim dtIncidencias As DataTable = GeneracionMasivaIncidencias()
            If Not IsNothing(dtIncidencias) AndAlso dtIncidencias.Rows.Count > 0 Then
                ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                ExpertisApp.GenerateMessage("Error en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            mblnCancel = True
        End If
    End Sub

    Protected Overridable Function GeneracionMasivaIncidencias() As DataTable
        Return Nothing
    End Function

    Protected Overridable Function VerificarDatos() As Boolean
        VerificarDatos = True
        If length(advTipoIncidencia.Text) = 0 Then
            VerificarDatos = False
            ExpertisApp.GenerateMessage("El Tipo Incidencia no existe.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf length(cbxFechaInicio.Value) = 0 Then
            VerificarDatos = False
            ExpertisApp.GenerateMessage("La Fecha Inicio es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf length(cbxFechaFin.Value) = 0 Then
            VerificarDatos = False
            ExpertisApp.GenerateMessage("Falta por informar la Fecha Final.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Not ValidarFechas(Nz(cbxFechaInicio.Value, String.Empty), Nz(cbxFechaFin.Value, String.Empty)) Then
            VerificarDatos = False
        End If
    End Function

    Private Sub cmbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancel.Click
        mblnCancel = False
        Me.Close()
    End Sub

    Private Sub frmIncidenciasMasivasBase_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub
#End Region

End Class
