Public Class frmVentaMaquinaria
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
    Friend WithEvents AdvIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulDescCliente As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvIDCentroGestion As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulDescCentroGestion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents chkGenerarAlbaran As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkGenerarFactura As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblOServicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCentroGestion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaVenta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cbxFechaVenta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentaMaquinaria))
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescCliente = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDCentroGestion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescCentroGestion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxFechaVenta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.chkGenerarAlbaran = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkGenerarFactura = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.lblOServicio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Left
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = Nothing
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(264, 244)
        Me.Grid.TabIndex = 0
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = Nothing
        '
        'AdvIDCliente
        '
        Me.AdvIDCliente.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCliente", ulDescCliente)})
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(368, 8)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IdCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(96, 23)
        Me.AdvIDCliente.TabIndex = 1
        Me.AdvIDCliente.ViewName = "tbMaestroCliente"
        '
        'ulDescCliente
        '
        Me.ulDescCliente.Location = New System.Drawing.Point(467, 8)
        Me.ulDescCliente.Name = "ulDescCliente"
        Me.ulDescCliente.Size = New System.Drawing.Size(141, 21)
        Me.ulDescCliente.TabIndex = 13
        '
        'AdvIDObra
        '
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(368, 34)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(96, 23)
        Me.AdvIDObra.TabIndex = 2
        Me.AdvIDObra.ViewName = "tbObraCabecera"
        '
        'AdvIDTrabajo
        '
        Me.AdvIDTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTrabajo.DisplayField = "CodTrabajo"
        Me.AdvIDTrabajo.EntityName = "ObraTrabajo"
        Me.AdvIDTrabajo.Location = New System.Drawing.Point(368, 60)
        Me.AdvIDTrabajo.Name = "AdvIDTrabajo"
        Me.AdvIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvIDTrabajo.Size = New System.Drawing.Size(96, 23)
        Me.AdvIDTrabajo.TabIndex = 3
        Me.AdvIDTrabajo.ViewName = "tbObraTrabajo"
        '
        'AdvIDCentroGestion
        '
        Me.AdvIDCentroGestion.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCentroGestion", ulDescCentroGestion)})
        Me.AdvIDCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCentroGestion.EntityName = "CentroGestion"
        Me.AdvIDCentroGestion.Location = New System.Drawing.Point(368, 86)
        Me.AdvIDCentroGestion.Name = "AdvIDCentroGestion"
        Me.AdvIDCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.AdvIDCentroGestion.Size = New System.Drawing.Size(96, 23)
        Me.AdvIDCentroGestion.TabIndex = 4
        Me.AdvIDCentroGestion.ViewName = "tbMaestroCentroGestion"
        '
        'ulDescCentroGestion
        '
        Me.ulDescCentroGestion.Location = New System.Drawing.Point(467, 86)
        Me.ulDescCentroGestion.Name = "ulDescCentroGestion"
        Me.ulDescCentroGestion.Size = New System.Drawing.Size(141, 21)
        Me.ulDescCentroGestion.TabIndex = 14
        '
        'cbxFechaVenta
        '
        Me.cbxFechaVenta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaVenta.Location = New System.Drawing.Point(368, 113)
        Me.cbxFechaVenta.Name = "cbxFechaVenta"
        Me.cbxFechaVenta.Size = New System.Drawing.Size(96, 21)
        Me.cbxFechaVenta.TabIndex = 5
        '
        'chkGenerarAlbaran
        '
        Me.chkGenerarAlbaran.Enabled = False
        Me.chkGenerarAlbaran.Location = New System.Drawing.Point(280, 152)
        Me.chkGenerarAlbaran.Name = "chkGenerarAlbaran"
        Me.chkGenerarAlbaran.Size = New System.Drawing.Size(152, 16)
        Me.chkGenerarAlbaran.TabIndex = 6
        Me.chkGenerarAlbaran.TabStop = False
        Me.chkGenerarAlbaran.Text = "Generar Albarán"
        '
        'chkGenerarFactura
        '
        Me.chkGenerarFactura.Location = New System.Drawing.Point(280, 176)
        Me.chkGenerarFactura.Name = "chkGenerarFactura"
        Me.chkGenerarFactura.Size = New System.Drawing.Size(144, 16)
        Me.chkGenerarFactura.TabIndex = 6
        Me.chkGenerarFactura.Text = "Generar Factura"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(272, 8)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 8
        Me.lblCliente.Text = "Cliente"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(272, 34)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(50, 13)
        Me.lblObra.TabIndex = 9
        Me.lblObra.Text = "Alquiler"
        '
        'lblOServicio
        '
        Me.lblOServicio.Location = New System.Drawing.Point(272, 60)
        Me.lblOServicio.Name = "lblOServicio"
        Me.lblOServicio.Size = New System.Drawing.Size(92, 13)
        Me.lblOServicio.TabIndex = 10
        Me.lblOServicio.Text = "Orden Servicio"
        '
        'lblCentroGestion
        '
        Me.lblCentroGestion.Location = New System.Drawing.Point(272, 86)
        Me.lblCentroGestion.Name = "lblCentroGestion"
        Me.lblCentroGestion.Size = New System.Drawing.Size(67, 13)
        Me.lblCentroGestion.TabIndex = 11
        Me.lblCentroGestion.Text = "C. Gestión"
        '
        'lblFechaVenta
        '
        Me.lblFechaVenta.Location = New System.Drawing.Point(272, 113)
        Me.lblFechaVenta.Name = "lblFechaVenta"
        Me.lblFechaVenta.Size = New System.Drawing.Size(77, 13)
        Me.lblFechaVenta.TabIndex = 12
        Me.lblFechaVenta.Text = "Fecha Venta"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(264, 204)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 40)
        Me.Panel1.TabIndex = 7
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(44, 7)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(128, 27)
        Me.cmbAceptar.TabIndex = 0
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancel
        '
        Me.cmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancel.Location = New System.Drawing.Point(179, 7)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(129, 27)
        Me.cmbCancel.TabIndex = 1
        Me.cmbCancel.Text = "Cancelar"
        '
        'frmVentaMaquinaria
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(616, 244)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ulDescCentroGestion)
        Me.Controls.Add(Me.ulDescCliente)
        Me.Controls.Add(Me.lblFechaVenta)
        Me.Controls.Add(Me.lblCentroGestion)
        Me.Controls.Add(Me.lblOServicio)
        Me.Controls.Add(Me.lblObra)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.chkGenerarFactura)
        Me.Controls.Add(Me.chkGenerarAlbaran)
        Me.Controls.Add(Me.cbxFechaVenta)
        Me.Controls.Add(Me.AdvIDCentroGestion)
        Me.Controls.Add(Me.AdvIDTrabajo)
        Me.Controls.Add(Me.AdvIDObra)
        Me.Controls.Add(Me.AdvIDCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmVentaMaquinaria"
        Me.Text = "Venta de Activos"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private datos As dataPrcAlbaranVentaMaquinaria
    Public ReadOnly Property datosVentaMaquinaria() As dataPrcAlbaranVentaMaquinaria
        Get
            Return datos
        End Get
    End Property

#Region " Load "

    Public Function AbrirVentaMaquinaria(ByVal dtMarcados As DataTable) As DialogResult
        datos = New dataPrcAlbaranVentaMaquinaria

        chkGenerarAlbaran.Checked = True
        Grid.DataSource = LoadDatos(dtMarcados)

        Me.ShowDialog()
        Return Me.DialogResult
    End Function

    Private Function LoadDatos(ByVal dtMarcados As DataTable) As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("IDActivo", GetType(String))
        dt.Columns.Add("IDAlmacen", GetType(String))
        dt.Columns.Add("Precio", GetType(Double))
        dt.Columns.Add("Dto1", GetType(Double))

        For Each drMarcados As DataRow In dtMarcados.Rows
            Dim dr As DataRow = dt.NewRow
            dr("IDActivo") = drMarcados("IDActivo")
            dr("IDAlmacen") = drMarcados("IDAlmacen")

            dt.Rows.Add(dr)
        Next
        Return dt
    End Function

    Private Sub frmVentaMaquinaria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbAceptar.Enabled = (Grid.RowCount > 0)
        Dim CentroGestionInfo As New UsuarioCentroGestion.UsuarioCentroGestionInfo
        ExpertisApp.ExecuteTask(Of Object)(AddressOf UsuarioCentroGestion.ObtenerUsuarioCentroGestion, CentroGestionInfo)
        If Length(CentroGestionInfo.IDCentroGestion) > 0 Then
            AdvIDCentroGestion.Text = CentroGestionInfo.IDCentroGestion
        End If
        chkGenerarAlbaran.Checked = True
    End Sub

#End Region

    Private Sub AdvIDCliente_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDCliente.SelectionChanged
        If Length(AdvIDCliente.Text) > 0 AndAlso Length(AdvIDObra.Value) > 0 Then
            Dim f As New Filter
            f.Add(New StringFilterItem("IDCliente", AdvIDCliente.Text))
            f.Add(New StringFilterItem("IDObra", AdvIDObra.Value))
            Dim dtObra As DataTable = New ObraCabecera().Filter(f, , "IDCliente")
            If IsNothing(dtObra) OrElse dtObra.Rows.Count = 0 Then
                ExpertisApp.GenerateMessage("El Cliente no pertenece al Alquiler.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                AdvIDCliente.Text = String.Empty
                AdvIDCliente.Focus()
            End If
        End If
    End Sub

    Private Sub AdvIDObra_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDObra.SetPredefinedFilter
        If Length(AdvIDCliente.Text) > 0 Then e.Filter.Add(New StringFilterItem("IDCliente", AdvIDCliente.Text))
    End Sub

    Private Sub AdvIDObra_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDObra.SelectionChanged
        If Length(AdvIDObra.Value) > 0 Then
            AdvIDCliente.Text = e.Selected.Rows(0)("IDCliente") & String.Empty
            AdvIDCentroGestion.Text = e.Selected.Rows(0)("IDCentroGestion") & String.Empty
            AdvIDTrabajo.Text = String.Empty
            AdvIDTrabajo.Value = System.DBNull.Value
        End If
    End Sub

    Private Sub AdvIDTrabajo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDTrabajo.SetPredefinedFilter
        If Length(AdvIDObra.Value) > 0 Then e.Filter.Add(New NumberFilterItem("IDObra", AdvIDObra.Value))
    End Sub

    Private Sub AdvIDTrabajo_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDTrabajo.SelectionChanged
        If Length(AdvIDTrabajo.Value) > 0 Then
            AdvIDObra.Value = e.Selected.Rows(0)("IDObra")
            datos.PedidoCliente = e.Selected.Rows(0)("PedidoCliente") & String.Empty
            datos.TipoFactAlquiler = e.Selected.Rows(0)("TipoFactAlquiler")
        End If
    End Sub

    Private Sub AdvIDCentroGestion_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDCentroGestion.SelectionChanged
        ulDescCentroGestion.Text = e.Selected.Rows(0)("DescCentroGestion") & String.Empty
        datos.IDContador = e.Selected.Rows(0)("IDContadorAlbaranVenta") & String.Empty
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If (Length(AdvIDCentroGestion.Text) = 0 Or Length(AdvIDObra.Value) = 0 Or Length(AdvIDCliente.Text) = 0 Or Length(cbxFechaVenta.Value) = 0) Then
            ExpertisApp.GenerateMessage("Los campos Cliente, Alquiler, C.Gestión y Fecha de Venta son obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            datos.IDCliente = AdvIDCliente.Text
            datos.IDObra = AdvIDObra.Value
            datos.NObra = AdvIDObra.Text
            datos.IDTrabajo = Nz(AdvIDTrabajo.Value, 0)
            datos.IDCentroGestion = AdvIDCentroGestion.Text
            datos.FechaVenta = cbxFechaVenta.Value
            datos.dtActivos = Grid.DataSource

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class
