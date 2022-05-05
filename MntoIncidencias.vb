Public Class MntoIncidencias
    Inherits Solmicro.Expertis.Engine.UI.GridMnto

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoIncidencias))
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(465, 28)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 28)
        Me.MenuBar.Size = New System.Drawing.Size(878, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(630, 317)
        '
        'Grid
        '
        Me.Grid.ColumnAutoResize = False
        Me.Grid.DataSource = Nothing
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "IncidenciasAlquiler"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Size = New System.Drawing.Size(630, 317)
        Me.Grid.ViewName = "vAlquilerMntoIncidencias"
        '
        'MntoIncidencias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(878, 405)
        Me.EntityName = "IncidenciasAlquiler"
        Me.Name = "MntoIncidencias"
        Me.NavigationFields = "IDObraIncidenciaAlq"
        Me.ViewName = "vAlquilerMntoIncidencias"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Carga del formulario "

    Private Sub MntoIncidencias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("EnumiaAfectaFactura", Grid.Columns("AfectaFactura"))
    End Sub

#End Region

#Region " Grid "

    Private Sub Grid_AddingRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.AddingRecord, Grid.UpdatingRecord
        ValidarCamposObligatorios(e.Cancel)
        If Not e.Cancel Then
            Dim DtGrid As DataTable = Grid.DataSource
            If Not DtGrid Is Nothing AndAlso DtGrid.Rows.Count > 0 Then
                Dim DrDatos() As DataRow = DtGrid.Select("IDIncidenciasAlquiler = '" & Grid.GetValue("IDIncidenciasAlquiler") & "'")
                If DrDatos.Length > 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El identificador introducido ya existe.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub ValidarCamposObligatorios(ByRef blnCancelar As Boolean)
        blnCancelar = False
        If length(Grid.GetValue("IDIncidenciasAlquiler") & String.Empty) = 0 OrElse _
           length(Grid.GetValue("DescIncidenciasAlquiler") & String.Empty) = 0 OrElse _
           length(Grid.GetValue("AfectaFactura") & String.Empty) = 0 Then
            blnCancelar = True
            ExpertisApp.GenerateMessage("Faltan campos obligatorios por informar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region


End Class
