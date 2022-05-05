Public Class frmHistMedidas
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
    Friend WithEvents grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtContadorPrevio As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescContador As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistMedidas))
        Me.grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtContadorPrevio = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescContador = New Solmicro.Expertis.Engine.UI.TextBox
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        grid_DesignTimeLayout.LayoutString = resources.GetString("grid_DesignTimeLayout.LayoutString")
        Me.grid.DesignTimeLayout = grid_DesignTimeLayout
        Me.grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grid.EntityName = "PreventivoContadorHist"
        Me.grid.Location = New System.Drawing.Point(8, 40)
        Me.grid.Name = "grid"
        Me.grid.PrimaryDataFields = ""
        Me.grid.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.grid.RequeryManually = True
        Me.grid.SecondaryDataFields = ""
        Me.grid.Size = New System.Drawing.Size(649, 224)
        Me.grid.TabIndex = 0
        Me.grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grid.ViewName = "vAlquilerfrmHistMedidasContadores"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(272, 272)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(128, 32)
        Me.cmbAceptar.TabIndex = 1
        Me.cmbAceptar.Text = "Aceptar"
        '
        'txtContadorPrevio
        '
        Me.txtContadorPrevio.DisabledBackColor = System.Drawing.Color.White
        Me.txtContadorPrevio.Location = New System.Drawing.Point(110, 12)
        Me.txtContadorPrevio.Name = "txtContadorPrevio"
        Me.txtContadorPrevio.Size = New System.Drawing.Size(144, 21)
        Me.txtContadorPrevio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contador Prev."
        '
        'txtDescContador
        '
        Me.txtDescContador.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescContador.Enabled = False
        Me.txtDescContador.Location = New System.Drawing.Point(257, 12)
        Me.txtDescContador.Name = "txtDescContador"
        Me.txtDescContador.Size = New System.Drawing.Size(400, 21)
        Me.txtDescContador.TabIndex = 4
        '
        'frmHistMedidas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(664, 309)
        Me.Controls.Add(Me.txtDescContador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtContadorPrevio)
        Me.Controls.Add(Me.cmbAceptar)
        Me.MaximizeBox = False
        Me.Name = "frmHistMedidas"
        Me.Text = "Histórico Medidas"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades y Variables"

    Private mLineaAlbaran As Integer
    Private mIDContadorPrev As String

    Public WriteOnly Property IDLineaAlbaran() As Integer
        Set(ByVal Value As Integer)
            mLineaAlbaran = Value
        End Set
    End Property

    Public WriteOnly Property IDContador() As String
        Set(ByVal Value As String)
            mIDContadorPrev = Value
        End Set
    End Property

#End Region

    Private Sub frmHistMedidas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As New Filter
        f.Add("IDLineaAlbaran", FilterOperator.Equal, mLineaAlbaran)
        f.Add("IDContadorPrev", FilterOperator.Equal, mIDContadorPrev)
        grid.ReQuery(f)

        If length(mIDContadorPrev) > 0 Then
            txtContadorPrevio.Text = mIDContadorPrev
            Dim dtCont As DataTable = New PreventivoContador().SelOnPrimaryKey(mIDContadorPrev)
            If Not IsNothing(dtCont) AndAlso dtCont.Rows.Count > 0 Then txtDescContador.Text = dtCont.Rows(0)("DescContadorPrev") & String.Empty
        End If
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.UpdateData()
        Me.Close()
    End Sub
End Class
