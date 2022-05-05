Public Class FrmIncidenciasAlquilerTrabajo
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
    Friend WithEvents lblGenerarIncidenciasMasivas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIDTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDesctrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFwIDesctrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmdMasiva As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIncidenciasAlquilerTrabajo))
        Dim grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.cmdMasiva = New Solmicro.Expertis.Engine.UI.Button
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblGenerarIncidenciasMasivas = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwIDesctrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDesctrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.cmdMasiva)
        Me.Frame1.Controls.Add(Me.lblCodTrabajo)
        Me.Frame1.Controls.Add(Me.lblGenerarIncidenciasMasivas)
        Me.Frame1.Controls.Add(Me.txtIDTrabajo)
        Me.Frame1.Controls.Add(Me.lblFwIDesctrabajo)
        Me.Frame1.Controls.Add(Me.txtDesctrabajo)
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(696, 41)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'cmdMasiva
        '
        Me.cmdMasiva.Image = CType(resources.GetObject("cmdMasiva.Image"), System.Drawing.Image)
        Me.cmdMasiva.Location = New System.Drawing.Point(656, 11)
        Me.cmdMasiva.Name = "cmdMasiva"
        Me.cmdMasiva.Size = New System.Drawing.Size(29, 25)
        Me.cmdMasiva.TabIndex = 9
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(6, 17)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(92, 13)
        Me.lblCodTrabajo.TabIndex = 8
        Me.lblCodTrabajo.Text = "Orden Servicio"
        '
        'lblGenerarIncidenciasMasivas
        '
        Me.lblGenerarIncidenciasMasivas.Location = New System.Drawing.Point(483, 17)
        Me.lblGenerarIncidenciasMasivas.Name = "lblGenerarIncidenciasMasivas"
        Me.lblGenerarIncidenciasMasivas.Size = New System.Drawing.Size(171, 13)
        Me.lblGenerarIncidenciasMasivas.TabIndex = 6
        Me.lblGenerarIncidenciasMasivas.Text = "Generar Incidencias Masivas"
        '
        'FwiIdTrabajo
        '
        Me.txtIDTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDTrabajo.Enabled = False
        Me.txtIDTrabajo.Location = New System.Drawing.Point(99, 14)
        Me.txtIDTrabajo.Name = "FwiIdTrabajo"
        Me.txtIDTrabajo.Size = New System.Drawing.Size(117, 21)
        Me.txtIDTrabajo.TabIndex = 3
        '
        'lblFwIDesctrabajo
        '
        Me.lblFwIDesctrabajo.Location = New System.Drawing.Point(190, 13)
        Me.lblFwIDesctrabajo.Name = "lblFwIDesctrabajo"
        Me.lblFwIDesctrabajo.Size = New System.Drawing.Size(0, 13)
        Me.lblFwIDesctrabajo.TabIndex = 7
        '
        'txtDesctrabajo
        '
        Me.txtDesctrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDesctrabajo.Enabled = False
        Me.txtDesctrabajo.Location = New System.Drawing.Point(219, 14)
        Me.txtDesctrabajo.Name = "txtDesctrabajo"
        Me.txtDesctrabajo.Size = New System.Drawing.Size(256, 21)
        Me.txtDesctrabajo.TabIndex = 2
        '
        'grid
        '
        Me.grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDIncidenciasAlquiler", "IncidenciasAlquiler", "IDIncidenciasAlquiler", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescIncidenciasAlquiler", "DescIncidenciasAlquiler"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("AfectaFactura", "AfectaFactura"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Imprimible", "Imprimible")}))})
        grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grid_DesignTimeLayout_Reference_0.Instance"), Object)
        grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grid_DesignTimeLayout_Reference_0})
        grid_DesignTimeLayout.LayoutString = resources.GetString("grid_DesignTimeLayout.LayoutString")
        Me.grid.DesignTimeLayout = grid_DesignTimeLayout
        Me.grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grid.EntityName = "ObraTrabajoIncidenciasAlq"
        Me.grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.ImageList = Me.ImageList1
        Me.grid.Location = New System.Drawing.Point(0, 45)
        Me.grid.Name = "grid"
        Me.grid.PrimaryDataFields = Nothing
        Me.grid.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.grid.RequeryManually = True
        Me.grid.SecondaryDataFields = Nothing
        Me.grid.Size = New System.Drawing.Size(696, 251)
        Me.grid.TabIndex = 0
        Me.grid.ViewName = "tbObraTrabajoIncidenciasAlq"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_edit.ico")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 296)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 48)
        Me.Panel1.TabIndex = 8
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(352, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(120, 32)
        Me.cmbCancelar.TabIndex = 7
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(224, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(120, 32)
        Me.cmbAceptar.TabIndex = 6
        Me.cmbAceptar.Text = "Aceptar"
        '
        'FrmIncidenciasAlquilerTrabajo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 344)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.grid)
        Me.MaximizeBox = False
        Me.Name = "FrmIncidenciasAlquilerTrabajo"
        Me.Text = "Incidencias en la Facturación"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public mIDObra As Integer
    Public mIDTrabajo As Integer
    Public mCodTrabajo As String
    Public mDesctrabajo As String

    Private Sub FrmIncidenciasAlquilerTrabajo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As New Filter
        f.Add(New NumberFilterItem("IDObra", mIDObra))
        f.Add(New NumberFilterItem("IdTrabajo", mIDTrabajo))
        grid.ReQuery(f)

        EnumData.PopulateValueList("EnumiaAfectaFactura", grid.Columns("AfectaFactura"))
        txtIDTrabajo.Text = mCodTrabajo
        txtDesctrabajo.Text = mDesctrabajo
    End Sub

    Private Sub grid_DeletingRecords(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles grid.DeletingRecords
        If Length(grid.Value("IDObraIncidenciasAlq")) > 0 Then
            ExpertisApp.GenerateMessage("Esta incidencia pertenece al Alquiler, no se puede eliminar desde aquí.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles grid.EditingCell
        Select Case e.Column.Key
            Case "Texto"
                Dim frm As New FormularioTexto
                frm.Texto = e.Value & String.Empty
                frm.ShowDialog()
                If e.Value & String.Empty <> frm.Texto Then
                    grid.SetValue("Texto", frm.Texto)
                End If
            Case "AfectaFactura"
                e.Cancel = True
        End Select
    End Sub

    Private Sub grid_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.RecordUpdated
        'Nota.-El "refresh" es necesario por la actualización de la marca "Predeterminada" que se modifica en negocio
        grid.Refresh()
    End Sub

    Private Sub grid_FormattingColumns() Handles grid.FormattingColumns
        With grid
            .Columns("IDTrabajo").DefaultValue = mIDTrabajo
            .Columns("IDObra").DefaultValue = mIDObra
            .Columns("CodTrabajo").DefaultValue = mCodTrabajo
            .Columns("PorcentajeFact").DefaultValue = 100
        End With
    End Sub

    Private Sub cmdMasiva_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdMasiva.Click
        If Length(mIDTrabajo) > 0 Then
            Dim frm As New frmIncidenciasMasivasTrabajo
            frm.AbrirIncidenciasMasivasTrabajo(mIDObra, mIDTrabajo, mCodTrabajo, mDesctrabajo)
            grid.CancelData()
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDObra", mIDObra))
            f.Add(New NumberFilterItem("IdTrabajo", mIDTrabajo))
            grid.ReQuery(f)
        End If
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.UpdateData()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class
