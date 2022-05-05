Public Class frmAsignaConductor
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
    Friend WithEvents GridDatos As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridDatos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignaConductor))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.GridDatos = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 245)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 40)
        Me.Panel1.TabIndex = 8
        '
        'cmbAceptar
        '
        Me.cmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmbAceptar.Location = New System.Drawing.Point(276, 7)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(128, 27)
        Me.cmbAceptar.TabIndex = 7
        Me.cmbAceptar.Text = "Aceptar"
        '
        'GridDatos
        '
        Me.GridDatos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridDatos_DesignTimeLayout.LayoutString = resources.GetString("GridDatos_DesignTimeLayout.LayoutString")
        Me.GridDatos.DesignTimeLayout = GridDatos_DesignTimeLayout
        Me.GridDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDatos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridDatos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridDatos.EntityName = ""
        Me.GridDatos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridDatos.Location = New System.Drawing.Point(0, 0)
        Me.GridDatos.Name = "GridDatos"
        Me.GridDatos.PrimaryDataFields = ""
        Me.GridDatos.SecondaryDataFields = ""
        Me.GridDatos.Size = New System.Drawing.Size(680, 245)
        Me.GridDatos.TabIndex = 9
        Me.GridDatos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridDatos.ViewName = ""
        '
        'frmAsignaConductor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(680, 285)
        Me.Controls.Add(Me.GridDatos)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAsignaConductor"
        Me.Text = "Asignación de Conductor"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public mdtConductores As DataTable

    Private Sub frmAsignaConductor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridDatos.DataSource = mdtConductores
    End Sub

End Class
