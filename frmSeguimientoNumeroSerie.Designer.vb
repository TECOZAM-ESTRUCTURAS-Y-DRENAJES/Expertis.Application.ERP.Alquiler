<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguimientoNumeroSerie
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeguimientoNumeroSerie))
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Grid2 = New Solmicro.Expertis.Engine.UI.Grid
        Me.bCreaArticulo = New Solmicro.Expertis.Engine.UI.Button
        Me.bActualizar = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(30, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Activos"
        '
        'Grid2
        '
        Me.Grid2.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid2.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid2.ColumnAutoResize = True
        Grid2_DesignTimeLayout.LayoutString = resources.GetString("Grid2_DesignTimeLayout.LayoutString")
        Me.Grid2.DesignTimeLayout = Grid2_DesignTimeLayout
        Me.Grid2.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid2.EntityName = "ControlArticuloNSerie"
        Me.Grid2.Location = New System.Drawing.Point(33, 64)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.PrimaryDataFields = Nothing
        Me.Grid2.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid2.SecondaryDataFields = Nothing
        Me.Grid2.Size = New System.Drawing.Size(787, 330)
        Me.Grid2.TabIndex = 15
        Me.Grid2.ViewName = "vControlArticulosNSerie"
        '
        'bCreaArticulo
        '
        Me.bCreaArticulo.Icon = CType(resources.GetObject("bCreaArticulo.Icon"), System.Drawing.Icon)
        Me.bCreaArticulo.Location = New System.Drawing.Point(33, 434)
        Me.bCreaArticulo.Name = "bCreaArticulo"
        Me.bCreaArticulo.Size = New System.Drawing.Size(196, 23)
        Me.bCreaArticulo.TabIndex = 16
        Me.bCreaArticulo.Text = "Crear articulo con nº serie"
        '
        'bActualizar
        '
        Me.bActualizar.Icon = CType(resources.GetObject("bActualizar.Icon"), System.Drawing.Icon)
        Me.bActualizar.Location = New System.Drawing.Point(561, 434)
        Me.bActualizar.Name = "bActualizar"
        Me.bActualizar.Size = New System.Drawing.Size(259, 23)
        Me.bActualizar.TabIndex = 17
        Me.bActualizar.Text = "Realizar Movimientos Nº Serie"
        '
        'frmSeguimientoNumeroSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 469)
        Me.Controls.Add(Me.bActualizar)
        Me.Controls.Add(Me.bCreaArticulo)
        Me.Controls.Add(Me.Grid2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSeguimientoNumeroSerie"
        Me.Text = "Seguimiento NúmeroSerie"
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Grid1 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Grid2 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents bCreaArticulo As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents bActualizar As Solmicro.Expertis.Engine.UI.Button
End Class
