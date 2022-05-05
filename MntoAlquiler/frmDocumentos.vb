Public Class frmDocumentos
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
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 245)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 40)
        Me.Panel1.TabIndex = 2
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(188, 7)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(177, 27)
        Me.cmbAceptar.TabIndex = 2
        Me.cmbAceptar.Text = "Aceptar"
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoDocumento", "DcmTipoDocumento", "IDTipoDocumento", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescTipoDocuemnto", "DescTipoDocuemnto")}), "tbDcmTipoDocumento")})
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDObraDocum""" & _
        "><Caption>IDObraDocum</Caption><DataMember>IDObraDocum</DataMember><Key>IDObraDo" & _
        "cum</Key><Position>0</Position><TextAlignment>Near</TextAlignment><Visible>False" & _
        "</Visible></Column0><Column1 ID=""IDObra""><Caption>IDObra</Caption><DataMember>ID" & _
        "Obra</DataMember><Key>IDObra</Key><Position>1</Position><TextAlignment>Near</Tex" & _
        "tAlignment><Visible>False</Visible></Column1><Column2 ID=""IDTipoDocumento""><Butt" & _
        "onStyle>Ellipsis</ButtonStyle><Caption>Tipo Documento</Caption><DataMember>IDTip" & _
        "oDocumento</DataMember><Key>IDTipoDocumento</Key><Position>2</Position><TextAlig" & _
        "nment>Near</TextAlignment><Width>123</Width></Column2><Column3 ID=""DescTipoDocue" & _
        "mnto""><Caption>Descripción del Tipo de Documento</Caption><DataMember>DescTipoDo" & _
        "cuemnto</DataMember><EditType>NoEdit</EditType><Key>DescTipoDocuemnto</Key><Posi" & _
        "tion>3</Position><TextAlignment>Near</TextAlignment><Width>300</Width></Column3>" & _
        "<Column4 ID=""ImprimibleEnAlbaran""><Caption>Imprimible en Albarán</Caption><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>ImprimibleEnAlbaran</DataMember><EditType" & _
        ">CheckBox</EditType><Key>ImprimibleEnAlbaran</Key><Position>4</Position></Column" & _
        "4></Columns><GroupCondition ID="""" /><SortKeys Collection=""true""><SortKey0 ID=""So" & _
        "rtKey0""><ColIndex>2</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutDa" & _
        "ta>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EntityName = Nothing
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid.RequeryManually = True
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(552, 245)
        Me.Grid.TabIndex = 3
        Me.Grid.ViewName = Nothing
        '
        'frmDocumentos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(552, 285)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDocumentos"
        Me.Text = "Documentación"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public mIDObra As Integer

    Private Sub frmDocumentos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Grid
            .EntityName = "ObraDocumImprimir"
            .ViewName = "vfrmObraDocumImprimir"
            .ReQuery(New NumberFilterItem("IDObra", mIDObra))
            .Columns("IDObra").DefaultValue = mIDObra
        End With
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        If Grid.newTopRowPosition Then
            Select Case e.Column.Key
                Case "IDTipoDocumento"
                    Grid.Columns(e.Column.Key).EditType = Janus.Windows.GridEX.EditType.TextBox
                    Grid.Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Ellipsis
            End Select
        End If
    End Sub

    'Private Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
    '    e.Filter.Add(New NumberFilterItem("ImprimibleEnAlbaran", 1))
    'End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.UpdateData()
        Me.Close()
    End Sub

End Class
