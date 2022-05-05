
Public Class MntoClasifObra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoClasifObra))
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
        Me.MenuBar.Size = New System.Drawing.Size(544, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(296, 269)
        '
        'Grid
        '
        Me.Grid.DataSource = Nothing
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ClasificacionObra"
        Me.Grid.Size = New System.Drawing.Size(296, 269)
        Me.Grid.ViewName = "tbMaestroClasificacionObra"
        '
        'MntoClasifObra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(544, 357)
        Me.EntityName = "ClasificacionObra"
        Me.Name = "MntoClasifObra"
        Me.ViewName = "tbMaestroClasificacionObra"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Grid_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.AddingRecord
        With Grid
            If length(.Value("IDClasificacionObra") & String.Empty) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El campo clasificación de obra es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                For Each drRow As DataRow In CType(Grid.DataSource, DataTable).Rows
                    If .Value("IDClasificacionObra") = drRow("IDClasificacionObra") Then
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("El identificador introducido ya existe.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Next
            End If
        End With
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        With Grid
            Select Case e.Column.Key
                Case "IDClasificacionObra"
                    If .Row <> Grid.newTopRowPosition Then
                        e.Cancel = True
                    End If
            End Select
        End With
    End Sub

End Class
