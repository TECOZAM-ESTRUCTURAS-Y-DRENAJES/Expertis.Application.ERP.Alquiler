Public Class FrmIncidenciasAlquilerMat
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
    Friend WithEvents lblFwIDescMaterial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmdMasiva As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblGenerarIncidenciasMasivas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescMaterial As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblMaterial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIDMaterial As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIncidenciasAlquilerMat))
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.cmdMasiva = New Solmicro.Expertis.Engine.UI.Button
        Me.lblGenerarIncidenciasMasivas = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwIDescMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescMaterial = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDMaterial = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.cmdMasiva)
        Me.Frame1.Controls.Add(Me.lblGenerarIncidenciasMasivas)
        Me.Frame1.Controls.Add(Me.lblFwIDescMaterial)
        Me.Frame1.Controls.Add(Me.txtDescMaterial)
        Me.Frame1.Controls.Add(Me.lblMaterial)
        Me.Frame1.Controls.Add(Me.txtIDMaterial)
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(720, 41)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'cmdMasiva
        '
        Me.cmdMasiva.Image = CType(resources.GetObject("cmdMasiva.Image"), System.Drawing.Image)
        Me.cmdMasiva.Location = New System.Drawing.Point(688, 12)
        Me.cmdMasiva.Name = "cmdMasiva"
        Me.cmdMasiva.Size = New System.Drawing.Size(29, 25)
        Me.cmdMasiva.TabIndex = 10
        '
        'lblGenerarIncidenciasMasivas
        '
        Me.lblGenerarIncidenciasMasivas.Location = New System.Drawing.Point(512, 17)
        Me.lblGenerarIncidenciasMasivas.Name = "lblGenerarIncidenciasMasivas"
        Me.lblGenerarIncidenciasMasivas.Size = New System.Drawing.Size(171, 13)
        Me.lblGenerarIncidenciasMasivas.TabIndex = 6
        Me.lblGenerarIncidenciasMasivas.Text = "Generar Incidencias Masivas"
        '
        'lblFwIDescMaterial
        '
        Me.lblFwIDescMaterial.Location = New System.Drawing.Point(128, 13)
        Me.lblFwIDescMaterial.Name = "lblFwIDescMaterial"
        Me.lblFwIDescMaterial.Size = New System.Drawing.Size(0, 13)
        Me.lblFwIDescMaterial.TabIndex = 7
        '
        'txtDescMaterial
        '
        Me.txtDescMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescMaterial.Enabled = False
        Me.txtDescMaterial.Location = New System.Drawing.Point(176, 15)
        Me.txtDescMaterial.Name = "txtDescMaterial"
        Me.txtDescMaterial.Size = New System.Drawing.Size(328, 21)
        Me.txtDescMaterial.TabIndex = 3
        '
        'lblMaterial
        '
        Me.lblMaterial.Location = New System.Drawing.Point(5, 19)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(52, 13)
        Me.lblMaterial.TabIndex = 8
        Me.lblMaterial.Text = "Material"
        '
        'txtIDMaterial
        '
        Me.txtIDMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDMaterial.Enabled = False
        Me.txtIDMaterial.Location = New System.Drawing.Point(61, 15)
        Me.txtIDMaterial.Name = "txtIDMaterial"
        Me.txtIDMaterial.Size = New System.Drawing.Size(111, 21)
        Me.txtIDMaterial.TabIndex = 2
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDIncidenciasAlquiler", "IncidenciasAlquiler", "IDIncidenciasAlquiler", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescIncidenciasAlquiler", "DescIncidenciasAlquiler"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("AfectaFactura", "AfectaFactura"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Imprimible", "Imprimible")}))})
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = "ObraMaterialIncidenciasAlq"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.Location = New System.Drawing.Point(1, 43)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid.RequeryManually = True
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(720, 253)
        Me.Grid.TabIndex = 0
        Me.Grid.ViewName = "vFrmAlquilerIncidenciasObraMaterial"
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
        Me.Panel1.Size = New System.Drawing.Size(722, 48)
        Me.Panel1.TabIndex = 9
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(365, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(120, 30)
        Me.cmbCancelar.TabIndex = 9
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(237, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(120, 30)
        Me.cmbAceptar.TabIndex = 8
        Me.cmbAceptar.Text = "Aceptar"
        '
        'FrmIncidenciasAlquilerMat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(722, 344)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Grid)
        Me.MaximizeBox = False
        Me.Name = "FrmIncidenciasAlquilerMat"
        Me.Text = "Incidencias por Material"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public mIDLineaMaterial, mIDObra, mIDTrabajo As Integer
    Public mIDMaterial, mDescMaterial, mCodTrabajo As String
    Public blnSoloLectura As Boolean

    Private Sub FrmIncidenciasAlquilerMat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As New Filter
        f.Add(New NumberFilterItem("IdlineaMaterial", mIDLineaMaterial))
        Grid.ReQuery(f)
        If blnSoloLectura Then
            Grid.AllowAddNew = Janus.Windows.UI.InheritableBoolean.False
            Grid.AllowDelete = Janus.Windows.UI.InheritableBoolean.False
            cmdMasiva.Enabled = False
        End If

        EnumData.PopulateValueList("EnumiaAfectaFactura", Grid.Columns("AfectaFactura"))
        txtIDMaterial.Text = mIDMaterial
        txtDescMaterial.Text = mDescMaterial
    End Sub

#Region " Grid "

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        With Grid
            If blnSoloLectura Then
                e.Cancel = True
                If e.Column.Key = "IDIncidenciasAlquiler" Then
                    .Columns("IDIncidenciasAlquiler").ButtonStyle = ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "IDIncidenciasAlquiler"
                        .Columns("IDIncidenciasAlquiler").ButtonStyle = ButtonStyle.Image
                    Case "AfectaFactura"
                        e.Cancel = True
                End Select
            End If
        End With
    End Sub

    Private Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
        With Grid
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Texto"
                                Dim frm As New FormularioTexto
                                frm.SoloLectura = blnSoloLectura
                                frm.Texto = .Value("Texto") & String.Empty
                                frm.ShowDialog()
                                If .Value("Texto") & String.Empty <> frm.Texto Then
                                    .SetValue("Texto", frm.Texto)
                                End If
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub Grid_RecordUpdated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.RecordUpdated
        'Nota.-El "refresh" es necesario por la actualización de la marca "Predeterminada" que se modifica en negocio
        Grid.Refresh()
    End Sub

    Private Sub Grid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.GotFocus
        With Grid
            .Columns("IdMaterial").DefaultValue = mIDMaterial
            .Columns("IdLineaMaterial").DefaultValue = mIDLineaMaterial
            .Columns("IDTrabajo").DefaultValue = mIDTrabajo
            .Columns("IDObra").DefaultValue = mIDObra
            .Columns("CodTrabajo").DefaultValue = mCodTrabajo
            .Columns("PorcentajeFact").DefaultValue = 100
        End With
    End Sub

#End Region

    Private Sub cmdMasiva_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdMasiva.Click
        If length(mIDLineaMaterial) > 0 Then
            Dim f As New FrmIncidenciasMasivasMat
            f.AbrirIncidenciasMasivasMateriales(mIDObra, mIDTrabajo, mCodTrabajo, Nothing, False, False, _
                                                txtIDMaterial.Text, txtDescMaterial.Text, False, mIDLineaMaterial)
        End If
        Grid.ReQuery()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.UpdateData()
        Me.Close()
    End Sub

End Class
