Public Class frmDatosAuxCambioMaquina2
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
    Friend WithEvents fraAsignarFechaAlquiler As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblHora As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtHora As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraNuevosMateriales As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents GridNuevosMateriales As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents FraContadores As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents GridContadores As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents FraAsigConductor As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents GridConductores As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridNuevosMateriales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosAuxCambioMaquina2))
        Dim GridContadores_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridConductores_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.fraAsignarFechaAlquiler = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblHora = New Solmicro.Expertis.Engine.UI.Label
        Me.txtHora = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.FraNuevosMateriales = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridNuevosMateriales = New Solmicro.Expertis.Engine.UI.Grid
        Me.FraContadores = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridContadores = New Solmicro.Expertis.Engine.UI.Grid
        Me.FraAsigConductor = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridConductores = New Solmicro.Expertis.Engine.UI.Grid
        Me.fraAsignarFechaAlquiler.SuspendLayout()
        Me.panel1.suspendlayout()
        Me.FraNuevosMateriales.SuspendLayout()
        CType(Me.GridNuevosMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraContadores.SuspendLayout()
        CType(Me.GridContadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraAsigConductor.SuspendLayout()
        CType(Me.GridConductores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraAsignarFechaAlquiler
        '
        Me.fraAsignarFechaAlquiler.Controls.Add(Me.lblHora)
        Me.fraAsignarFechaAlquiler.Controls.Add(Me.txtHora)
        Me.fraAsignarFechaAlquiler.Controls.Add(Me.lblFecha)
        Me.fraAsignarFechaAlquiler.Controls.Add(Me.cbxFecha)
        Me.fraAsignarFechaAlquiler.Dock = System.Windows.Forms.DockStyle.Top
        Me.fraAsignarFechaAlquiler.Location = New System.Drawing.Point(0, 0)
        Me.fraAsignarFechaAlquiler.Name = "fraAsignarFechaAlquiler"
        Me.fraAsignarFechaAlquiler.Size = New System.Drawing.Size(648, 57)
        Me.fraAsignarFechaAlquiler.TabIndex = 11
        Me.fraAsignarFechaAlquiler.TabStop = False
        Me.fraAsignarFechaAlquiler.Text = "Asignación de Fechas del Alquiler"
        '
        'lblHora
        '
        Me.lblHora.Location = New System.Drawing.Point(323, 28)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(114, 13)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "Hora inicio Alquiler"
        '
        'txtHora
        '
        Me.txtHora.DisabledBackColor = System.Drawing.Color.White
        Me.txtHora.Location = New System.Drawing.Point(441, 24)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(85, 21)
        Me.txtHora.TabIndex = 8
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(92, 28)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(120, 13)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Fecha inicio Alquiler"
        '
        'cbxFecha
        '
        Me.cbxFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFecha.Location = New System.Drawing.Point(217, 24)
        Me.cbxFecha.Name = "cbxFecha"
        Me.cbxFecha.Size = New System.Drawing.Size(92, 21)
        Me.cbxFecha.TabIndex = 7
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.cmbAceptar)
        Me.panel1.Controls.Add(Me.cmbCancel)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 509)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(648, 40)
        Me.panel1.TabIndex = 15
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(192, 7)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(128, 27)
        Me.cmbAceptar.TabIndex = 9
        Me.cmbAceptar.Text = "Finalizar"
        '
        'cmbCancel
        '
        Me.cmbCancel.Location = New System.Drawing.Point(327, 7)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(129, 27)
        Me.cmbCancel.TabIndex = 8
        Me.cmbCancel.Text = "Cancelar"
        '
        'FraNuevosMateriales
        '
        Me.FraNuevosMateriales.Controls.Add(Me.GridNuevosMateriales)
        Me.FraNuevosMateriales.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraNuevosMateriales.Location = New System.Drawing.Point(0, 57)
        Me.FraNuevosMateriales.Name = "FraNuevosMateriales"
        Me.FraNuevosMateriales.Size = New System.Drawing.Size(648, 152)
        Me.FraNuevosMateriales.TabIndex = 16
        Me.FraNuevosMateriales.TabStop = False
        Me.FraNuevosMateriales.Text = "Nuevos Materiales"
        '
        'GridNuevosMateriales
        '
        Me.GridNuevosMateriales.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")}))})
        Me.GridNuevosMateriales.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridNuevosMateriales_DesignTimeLayout.LayoutString = resources.GetString("GridNuevosMateriales_DesignTimeLayout.LayoutString")
        Me.GridNuevosMateriales.DesignTimeLayout = GridNuevosMateriales_DesignTimeLayout
        Me.GridNuevosMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridNuevosMateriales.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridNuevosMateriales.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridNuevosMateriales.EntityName = Nothing
        Me.GridNuevosMateriales.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridNuevosMateriales.Location = New System.Drawing.Point(3, 17)
        Me.GridNuevosMateriales.Name = "GridNuevosMateriales"
        Me.GridNuevosMateriales.PrimaryDataFields = Nothing
        Me.GridNuevosMateriales.SecondaryDataFields = Nothing
        Me.GridNuevosMateriales.Size = New System.Drawing.Size(642, 132)
        Me.GridNuevosMateriales.TabIndex = 6
        Me.GridNuevosMateriales.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridNuevosMateriales.ViewName = Nothing
        '
        'FraContadores
        '
        Me.FraContadores.Controls.Add(Me.GridContadores)
        Me.FraContadores.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraContadores.Location = New System.Drawing.Point(0, 209)
        Me.FraContadores.Name = "FraContadores"
        Me.FraContadores.Size = New System.Drawing.Size(648, 184)
        Me.FraContadores.TabIndex = 17
        Me.FraContadores.TabStop = False
        Me.FraContadores.Text = "Asignación de Medidas de Contadores"
        '
        'GridContadores
        '
        Me.GridContadores.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridContadores_DesignTimeLayout.LayoutString = resources.GetString("GridContadores_DesignTimeLayout.LayoutString")
        Me.GridContadores.DesignTimeLayout = GridContadores_DesignTimeLayout
        Me.GridContadores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridContadores.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridContadores.EntityName = ""
        Me.GridContadores.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridContadores.Location = New System.Drawing.Point(3, 17)
        Me.GridContadores.Name = "GridContadores"
        Me.GridContadores.PrimaryDataFields = ""
        Me.GridContadores.SecondaryDataFields = ""
        Me.GridContadores.Size = New System.Drawing.Size(642, 164)
        Me.GridContadores.TabIndex = 6
        Me.GridContadores.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridContadores.ViewName = ""
        '
        'FraAsigConductor
        '
        Me.FraAsigConductor.Controls.Add(Me.GridConductores)
        Me.FraAsigConductor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraAsigConductor.Location = New System.Drawing.Point(0, 393)
        Me.FraAsigConductor.Name = "FraAsigConductor"
        Me.FraAsigConductor.Size = New System.Drawing.Size(648, 116)
        Me.FraAsigConductor.TabIndex = 18
        Me.FraAsigConductor.TabStop = False
        Me.FraAsigConductor.Text = "Asignación de Conductor"
        '
        'GridConductores
        '
        Me.GridConductores.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("Conductor", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescConductor")}))})
        Me.GridConductores.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridConductores_DesignTimeLayout.LayoutString = resources.GetString("GridConductores_DesignTimeLayout.LayoutString")
        Me.GridConductores.DesignTimeLayout = GridConductores_DesignTimeLayout
        Me.GridConductores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridConductores.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridConductores.EntityName = ""
        Me.GridConductores.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridConductores.Location = New System.Drawing.Point(3, 17)
        Me.GridConductores.Name = "GridConductores"
        Me.GridConductores.PrimaryDataFields = ""
        Me.GridConductores.SecondaryDataFields = ""
        Me.GridConductores.Size = New System.Drawing.Size(642, 96)
        Me.GridConductores.TabIndex = 4
        Me.GridConductores.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridConductores.ViewName = ""
        '
        'frmDatosAuxCambioMaquina2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(648, 549)
        Me.Controls.Add(Me.FraAsigConductor)
        Me.Controls.Add(Me.FraContadores)
        Me.Controls.Add(Me.FraNuevosMateriales)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.fraAsignarFechaAlquiler)
        Me.Name = "frmDatosAuxCambioMaquina2"
        Me.Text = "Activos de Sustitución (Envío de Material)"
        Me.fraAsignarFechaAlquiler.ResumeLayout(False)
        Me.fraAsignarFechaAlquiler.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.FraNuevosMateriales.ResumeLayout(False)
        CType(Me.GridNuevosMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraContadores.ResumeLayout(False)
        CType(Me.GridContadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraAsigConductor.ResumeLayout(False)
        CType(Me.GridConductores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mblnCancel As Boolean

    Public Class DatosRetornoMaquina2
        Public dtContadores As DataTable
        Public dtConductores As DataTable
        Public dtOMNew As DataTable
        Public dtmFecha As Date
        Public strHora As String
        Public Ok As DialogResult
    End Class

    Private mDtContadores, mDtConductores, mDtLineas As DataTable
    Private datos As DatosRetornoMaquina2
    Private WithEvents mNSerie As NSerieSeleccion

#Region " Load "

    Public Function AbrirFormulario(ByVal dt As DataTable, ByVal dtmFecha As Date, _
                                    ByVal strHora As String) As DatosRetornoMaquina2

        datos = New DatosRetornoMaquina2

        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            cbxFecha.Value = dtmFecha
            txtHora.Text = strHora

            LoadContadores(dt)
            LoadConductores(dt)
            LoadNuevosMateriales(dt.Copy)
        End If

        Me.ShowDialog()

        Return datos
    End Function

#Region " LoadContadores "

    Private Sub LoadFiltro(ByVal dt As DataTable, ByRef fContador As Filter)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            Dim strFiltroContador() As Object
            ReDim strFiltroContador(-1)

            For Each dr As DataRow In dt.Rows
                If length(dr("Lote")) > 0 Then
                    ReDim Preserve strFiltroContador(UBound(strFiltroContador) + 1)
                    strFiltroContador(UBound(strFiltroContador)) = dr("Lote")
                End If
            Next
            If strFiltroContador.Length > 0 Then
                If fContador Is Nothing Then fContador = New Filter
                fContador.Add(New InListFilterItem("IDActivo", strFiltroContador, FilterType.String))
            End If
        End If
    End Sub

    Private Sub LoadContadores(ByVal dt As DataTable, Optional ByVal fContador As Filter = Nothing)
        Dim dtContadores As New DataTable
        dtContadores.Columns.Add("NuevaMedida", GetType(Double))
        dtContadores.Columns.Add("IDContadorPrev", GetType(String))
        dtContadores.Columns.Add("DescContadorPrev", GetType(String))
        dtContadores.Columns.Add("IDUdMedida", GetType(String))
        dtContadores.Columns.Add("IDActivo", GetType(String))
        dtContadores.Columns.Add("IDArticulo", GetType(String))
        dtContadores.Columns.Add("DescArticulo", GetType(String))
        dtContadores.Columns.Add("IDTrabajo", GetType(Integer))
        dtContadores.Columns.Add("CodTrabajo", GetType(String))
        dtContadores.Columns.Add("IDLineaMaterial", GetType(Integer))
        dtContadores.Columns.Add("IDAlbaran", GetType(Integer))
        dtContadores.Columns.Add("IDLineaAlbaran", GetType(Integer))
        dtContadores.Columns.Add("IDLineaAlbaranDeposito", GetType(Integer))
        dtContadores.Columns.Add("Resetear", GetType(Boolean))

        LoadFiltro(dt, fContador)

        If Not IsNothing(fContador) AndAlso fContador.Count > 0 Then
            Dim de As New BE.DataEngine
            Dim dtDatos As DataTable = de.Filter("vFrmContadorSustitucion", fContador)
            If Not IsNothing(dtDatos) AndAlso dtDatos.Rows.Count > 0 Then
                Dim dtANSerie As DataTable
                Dim dv As New DataView(dt)
                For Each drDatos As DataRow In dtDatos.Rows
                    Dim drNewContador As DataRow = dtContadores.NewRow
                    drNewContador("IDContadorPrev") = drDatos("IDContadorPrev")
                    drNewContador("DescContadorPrev") = drDatos("DescContadorPrev")
                    drNewContador("Resetear") = drDatos("Resetear")
                    drNewContador("IDUdMedida") = drDatos("IDUdMedida")
                    If length(drDatos("IDActivo")) > 0 Then
                        drNewContador("IDActivo") = drDatos("IDActivo")
                        dv.RowFilter = "Lote = '" & drDatos("IDActivo") & "'" '& "' And Marca = 1"
                        If dv.Count > 0 Then
                            drNewContador("IDTrabajo") = dv(0).Row("IDTrabajo")
                            drNewContador("CodTrabajo") = dv(0).Row("CodTrabajo")
                        End If
                        dtANSerie = de.Filter("vFrmArticuloNSerie", New StringFilterItem("NSerie", drDatos("IDActivo")))
                        If Not dtANSerie Is Nothing AndAlso dtANSerie.Rows.Count > 0 Then
                            drNewContador("IDArticulo") = dtANSerie.Rows(0)("IDArticulo")
                            drNewContador("DescArticulo") = dtANSerie.Rows(0)("DescArticulo")
                        End If
                    End If
                    drNewContador("NuevaMedida") = Nz(drDatos("CantidadAux"), 0)

                    dtContadores.Rows.Add(drNewContador)
                Next
            End If
        End If

        GridContadores.DataSource = dtContadores
    End Sub

#End Region

    Private Sub LoadConductores(ByVal dt As DataTable)
        Dim dtConductores As New DataTable
        dtConductores.Columns.Add("Conductor", GetType(String))
        dtConductores.Columns.Add("DescConductor", GetType(String))
        dtConductores.Columns.Add("IDArticulo", GetType(String))
        dtConductores.Columns.Add("DescArticulo", GetType(String))
        dtConductores.Columns.Add("IDCliente", GetType(String))
        dtConductores.Columns.Add("IDTrabajo", GetType(Integer))
        dtConductores.Columns.Add("CodTrabajo", GetType(String))

        Dim dv As New DataView(dt.Copy)
        dv.RowFilter = "NecesitaOperario<>0"
        If dv.Count > 0 Then
            For Each dr As DataRowView In dv
                Dim drNewConductor As DataRow = dtConductores.NewRow
                drNewConductor("IDArticulo") = dr("IDMaterial")
                drNewConductor("DescArticulo") = dr("DescArticulo")
                drNewConductor("IDCliente") = dr("IDCliente")
                drNewConductor("IDTrabajo") = dr("IDTrabajo")
                drNewConductor("CodTrabajo") = dr("CodTrabajo")

                dtConductores.Rows.Add(drNewConductor)
            Next
        End If

        GridConductores.DataSource = dtConductores
    End Sub

    Private Sub LoadNuevosMateriales(ByVal dt As DataTable)
        For Each dr As DataRow In dt.Rows
            dr("Lote") = System.DBNull.Value
        Next
        GridNuevosMateriales.DataSource = dt
    End Sub

#End Region

#Region " GridNuevosMateriales "

    Private Sub GridNuevosMateriales_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridNuevosMateriales.ColumnButtonClick
        With GridNuevosMateriales
            Select Case e.Column.Key
                Case "Lote"
                    Dim f As New Filter
                    f.Add("Disponible", FilterOperator.Equal, True, FilterType.Boolean)
                    If length(.Value("IDArticulo")) Then
                        f.Add("IDArticulo", FilterOperator.Equal, .Value("IDArticulo"), FilterType.String)
                    End If
                    mNSerie = New NSerieSeleccion
                    mNSerie.FilterCriteria = f
                    mNSerie.ShowDialog()
            End Select
        End With
    End Sub

    Private Sub mNSerie_SeleccionSerie(ByVal Row As System.Data.DataRow) Handles mNSerie.SeleccionSerie
        If Not IsNothing(Row) Then
            With GridNuevosMateriales
                .Value("IDArticulo") = Row("IDArticulo")
                .Value("Lote") = Row("NSerie")
            End With
        End If
    End Sub

    Private Sub GridNuevosMateriales_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridNuevosMateriales.RecordUpdated
        LoadContadores(GridNuevosMateriales.DataSource)
        LoadConductores(GridNuevosMateriales.DataSource)
    End Sub

#End Region

    Private Sub GridContadores_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridContadores.UpdatingCell
        With GridContadores
            Select Case e.Column.Key
                Case "NuevaMedida"
                    If length(e.Value) AndAlso Not IsNumeric(e.Value) Then
                        ExpertisApp.GenerateMessage("El campo ha ser ser un valor numérico.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True
                    End If
            End Select
        End With
    End Sub

    Private Sub txtHora_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHora.LostFocus
        If length(txtHora.Text) > 0 Then
            Dim tmHoraAlquiler As Date
            If InStr(txtHora.Text, ":") = 0 Then
                tmHoraAlquiler = txtHora.Text & ":0"
            Else
                tmHoraAlquiler = txtHora.Text
            End If
            txtHora.Text = Format(tmHoraAlquiler, "HH:mm:ss")
        End If
    End Sub

#Region " cmbAceptar_Click "

    Private Function ValidarCamposFechas() As Boolean
        Dim strMsg As String = String.Empty

        If length(cbxFecha.Value) = 0 And length(txtHora.Text) = 0 Then
            strMsg = "No ha rellenado los campos Fecha y Hora. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
        ElseIf length(cbxFecha.Value) = 0 Then
            strMsg = "No ha rellenado el campo Fecha. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
        ElseIf length(txtHora.Text) = 0 Then
            strMsg = "No ha rellenado el campo Hora. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
        End If
        Dim blnCancel As Boolean
        If length(strMsg) > 0 Then
            If ExpertisApp.GenerateMessage(strMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                blnCancel = True
            End If
        End If

        Return blnCancel
    End Function

    Private Function ValidaNuevosMateriales() As Boolean
        Dim blnCancel As Boolean = False
        Dim dv As New DataView(CType(GridNuevosMateriales.DataSource, DataTable).Copy)
        Dim f As New Filter
        f.Add(New IsNullFilterItem("Lote", True))
        f.Add(New BooleanFilterItem("NSerieObligatorio", True))

        dv.RowFilter = f.Compose(New AdoFilterComposer)
        If dv.Count > 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("El Nº. Serie es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Return blnCancel
    End Function

    Private Function ValidaContadores() As Boolean
        Dim blnCancel As Boolean = False
        Dim dt As DataTable = GridContadores.DataSource
        Dim dv As New DataView(dt)
        Dim f As New Filter
        f.Add(New IsNullFilterItem("NuevaMedida", True))

        dv.RowFilter = f.Compose(New AdoFilterComposer)
        If dv.Count > 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("Todas las medidas de los contadores deben estar rellenadas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Return blnCancel
    End Function

    Private Function GeneraConductores() As DataTable
        Dim dtConductor As DataTable = GridConductores.DataSource
        If Not IsNothing(dtConductor) AndAlso dtConductor.Rows.Count > 0 Then
            Dim dvConductor As New DataView(dtConductor)
            Dim f As New Filter
            f.Add(New IsNullFilterItem("Conductor", False))

            dvConductor.RowFilter = f.Compose(New AdoFilterComposer)
            If dvConductor.Count > 0 Then
                Dim dtConductores As New DataTable
                dtConductores.Columns.Add("IDAlbaran", GetType(Integer))
                dtConductores.Columns.Add("IDLineaAlbaran", GetType(Integer))
                dtConductores.Columns.Add("IDLineaMaterial", GetType(Integer))
                dtConductores.Columns.Add("IDTrabajo", GetType(Integer))
                dtConductores.Columns.Add("CodTrabajo", GetType(String))
                dtConductores.Columns.Add("Conductor", GetType(String))
                dtConductores.Columns.Add("DescConductor", GetType(String))
                dtConductores.Columns.Add("Cantidad", GetType(Double))
                dtConductores.Columns.Add("IDUDMedida", GetType(String))
                dtConductores.Columns.Add("IDUdInterna", GetType(String))
                dtConductores.Columns.Add("CContable", GetType(String))
                dtConductores.Columns.Add("IDCliente", GetType(String))
                dtConductores.Columns.Add("IDMoneda", GetType(String))
                dtConductores.Columns.Add("CambioA", GetType(Double))
                dtConductores.Columns.Add("CambioB", GetType(Double))
                dtConductores.Columns.Add("IDAlbaranOrigen", GetType(Integer))
                dtConductores.Columns.Add("IDLineaAlbaranOrigen", GetType(Integer))
                dtConductores.Columns.Add("IDArticulo", GetType(String))

                Dim drNewConductor As DataRow = dtConductores.NewRow
                For Each drv As DataRowView In dvConductor
                    drNewConductor("IDTrabajo") = drv.Row("IDTrabajo")
                    drNewConductor("CodTrabajo") = drv.Row("CodTrabajo")
                    drNewConductor("Conductor") = drv.Row("Conductor")
                    drNewConductor("DescConductor") = drv.Row("DescConductor")
                    drNewConductor("Cantidad") = 1
                    drNewConductor("IDCliente") = drv.Row("IDCliente")
                    drNewConductor("IDArticulo") = drv.Row("IDArticulo")

                    dtConductores.Rows.Add(drNewConductor)
                Next

                Return dtConductores
            ElseIf ExpertisApp.GenerateMessage("No ha asignado conductores. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                mblnCancel = True
            End If
        End If
        Return Nothing
    End Function

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        mblnCancel = ValidarCamposFechas()
        If Not mblnCancel Then
            mblnCancel = ValidaNuevosMateriales()
            If Not mblnCancel Then
                mblnCancel = ValidaContadores()
                If Not mblnCancel Then
                    datos.dtmFecha = IIf(length(cbxFecha.Value) > 0, cbxFecha.Value, Date.Today)
                    datos.strHora = IIf(Length(txtHora.Text) > 0, txtHora.Text, Date.Today.ToShortTimeString)
                    datos.dtContadores = GridContadores.DataSource
                    datos.dtConductores = GeneraConductores()
                    If Not mblnCancel Then
                        datos.dtOMNew = GridNuevosMateriales.DataSource
                        datos.Ok = DialogResult.OK
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            End If
        End If
    End Sub

#End Region

End Class
