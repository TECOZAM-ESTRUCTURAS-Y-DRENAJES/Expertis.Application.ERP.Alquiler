Public Class frmFacturacionProvisional
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
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbOK As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents grid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturacionProvisional))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbOK = New Solmicro.Expertis.Engine.UI.Button
        Me.grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancel)
        Me.Panel1.Controls.Add(Me.cmbOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 253)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(565, 40)
        Me.Panel1.TabIndex = 3
        '
        'cmbCancel
        '
        Me.cmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancel.Location = New System.Drawing.Point(285, 7)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(105, 27)
        Me.cmbCancel.TabIndex = 4
        Me.cmbCancel.Text = "Cancelar"
        '
        'cmbOK
        '
        Me.cmbOK.Location = New System.Drawing.Point(174, 7)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(105, 27)
        Me.cmbOK.TabIndex = 3
        Me.cmbOK.Text = "Aceptar"
        '
        'grid
        '
        Me.grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        grid_DesignTimeLayout.LayoutString = resources.GetString("grid_DesignTimeLayout.LayoutString")
        Me.grid.DesignTimeLayout = grid_DesignTimeLayout
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grid.EntityName = Nothing
        Me.grid.FrozenColumns = 3
        Me.grid.Location = New System.Drawing.Point(0, 0)
        Me.grid.Name = "grid"
        Me.grid.PrimaryDataFields = Nothing
        Me.grid.SecondaryDataFields = Nothing
        Me.grid.Size = New System.Drawing.Size(565, 253)
        Me.grid.TabIndex = 4
        Me.grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grid.ViewName = Nothing
        '
        'frmFacturacionProvisional
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(565, 293)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmFacturacionProvisional"
        Me.Text = "Datos Provisionales de Facturación"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function AbrirFormulario(ByRef dtFacturas As DataTable) As DialogResult
        grid.DataSource = dtFacturas
        Me.ShowDialog()

        Return Me.DialogResult
    End Function

    Private Sub cmbOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOK.Click
        Dim cancel As Boolean = False
        Me.DialogResult = DialogResult.None

        Dim dt As DataTable = grid.DataSource
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows
                If Length(dr("FechaFactura")) = 0 Then
                    cancel = True
                    ExpertisApp.GenerateMessage("Debe de rellenar la Fecha Factura.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    'Hay que saber si la facturación es normal o del proceso B
                    Dim IDEjercicio As String = String.Empty
                    If New NegocioGeneral().ContadorB(dr("IDContador")) Then
                        IDEjercicio = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.PredeterminadoB, dr("FechaFactura"))
                    Else
                        IDEjercicio = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, dr("FechaFactura"))
                    End If
                    If Length(IDEjercicio) > 0 Then
                        dr("IDEjercicio") = IDEjercicio
                    Else
                        ExpertisApp.GenerateMessage("No está configurado correctamente el Ejercicio de la fecha: | .|Por favor, revise los datos del ejercicio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, dr("FechaFactura"), vbNewLine)
                        Exit Sub
                    End If
                End If
            Next
            If cancel Then
                grid.Focus()
                grid.Col = grid.Columns("FechaFactura").Position
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

End Class
