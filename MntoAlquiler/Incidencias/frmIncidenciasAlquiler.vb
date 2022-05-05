Public Class frmIncidenciasAlquiler
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
    Friend WithEvents CmdMasiva As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtNObra As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncidenciasAlquiler))
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.CmdMasiva = New Solmicro.Expertis.Engine.UI.Button
        Me.txtNObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
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
        Me.Frame1.Controls.Add(Me.lblObra)
        Me.Frame1.Controls.Add(Me.CmdMasiva)
        Me.Frame1.Controls.Add(Me.txtNObra)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(720, 41)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(9, 18)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(50, 13)
        Me.lblObra.TabIndex = 5
        Me.lblObra.Text = "Alquiler"
        '
        'CmdMasiva
        '
        Me.CmdMasiva.Image = CType(resources.GetObject("CmdMasiva.Image"), System.Drawing.Image)
        Me.CmdMasiva.Location = New System.Drawing.Point(688, 11)
        Me.CmdMasiva.Name = "CmdMasiva"
        Me.CmdMasiva.Size = New System.Drawing.Size(29, 25)
        Me.CmdMasiva.TabIndex = 1
        '
        'txtNObra
        '
        Me.txtNObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtNObra.Enabled = False
        Me.txtNObra.Location = New System.Drawing.Point(65, 14)
        Me.txtNObra.Name = "txtNObra"
        Me.txtNObra.Size = New System.Drawing.Size(120, 21)
        Me.txtNObra.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(512, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Generar Incidencias Masivas"
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDIncidenciasAlquiler", "IncidenciasAlquiler", "IDIncidenciasAlquiler", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescIncidenciasAlquiler", "DescIncidenciasAlquiler"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("AfectaFactura", "AfectaFactura"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Imprimible", "Imprimible")}))})
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = "ObraIncidenciasAlq"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.Location = New System.Drawing.Point(1, 43)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid.RequeryManually = True
        Me.Grid.SecondaryDataFields = ""
        Me.Grid.Size = New System.Drawing.Size(720, 253)
        Me.Grid.TabIndex = 4
        Me.Grid.ViewName = "tbObraIncidenciasAlq"
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
        Me.Panel1.TabIndex = 7
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(365, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(120, 30)
        Me.cmbCancelar.TabIndex = 7
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(237, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(120, 30)
        Me.cmbAceptar.TabIndex = 6
        Me.cmbAceptar.Text = "Aceptar"
        '
        'frmIncidenciasAlquiler
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(722, 344)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Grid)
        Me.MaximizeBox = False
        Me.Name = "frmIncidenciasAlquiler"
        Me.Text = "Incidencias en la Facturación"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mIDObra As Integer
    Public Property IDObra() As Integer
        Get
            Return mIDObra
        End Get
        Set(ByVal Value As Integer)
            mIDObra = Value
        End Set
    End Property

    Public Property NObra() As String
        Get
            Return txtNObra.Text
        End Get
        Set(ByVal Value As String)
            txtNObra.Text = Value
        End Set
    End Property

    Private Sub frmIncidenciasAlquiler_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid.Filter.Add(New NumberFilterItem("IDObra", mIDObra))
        Grid.ReQuery()

        EnumData.PopulateValueList("EnumiaAfectaFactura", Grid.Columns("AfectaFactura"))
    End Sub

#Region " Grid "

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Select Case e.Column.Key
            Case "Texto"
                Dim frm As New FormularioTexto
                frm.Texto = e.Value & String.Empty
                frm.ShowDialog()
                If e.Value & String.Empty <> frm.Texto Then
                    Grid.SetValue("Texto", frm.Texto)
                End If
                frm = Nothing
            Case "AfectaFactura"
                e.Cancel = True
        End Select
    End Sub

    Private Sub Grid_FormattingColumns() Handles Grid.FormattingColumns
        With Grid
            .Columns("IDObra").DefaultValue = mIDObra
            .Columns("PorcentajeFact").DefaultValue = 100
        End With
    End Sub

    Private Sub CmdMasiva_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdMasiva.Click
        Dim ofrm As New frmIncidenciasMasivasAlquiler
        ofrm.AbrirIncidenciasMasivasAlquiler(mIDObra, txtNObra.Text)
        Grid.ReQuery()
    End Sub

#End Region

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.UpdateData()
        Me.Close()
    End Sub

End Class
