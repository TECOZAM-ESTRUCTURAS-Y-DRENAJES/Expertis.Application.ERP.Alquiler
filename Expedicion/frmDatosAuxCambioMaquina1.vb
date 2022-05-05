Public Class frmDatosAuxCambioMaquina1
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
    Friend WithEvents FraIncidencias As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents fraAsignarFechaRetorno As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblHora As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtHora As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents FraContadores As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents GridContadores As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents GridIncidencias As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridIncidencias_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosAuxCambioMaquina1))
        Dim GridContadores_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.FraIncidencias = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridIncidencias = New Solmicro.Expertis.Engine.UI.Grid
        Me.fraAsignarFechaRetorno = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblHora = New Solmicro.Expertis.Engine.UI.Label
        Me.txtHora = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FraContadores = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridContadores = New Solmicro.Expertis.Engine.UI.Grid
        Me.panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.FraIncidencias.SuspendLayout()
        CType(Me.GridIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraAsignarFechaRetorno.SuspendLayout()
        Me.FraContadores.SuspendLayout()
        CType(Me.GridContadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'FraIncidencias
        '
        Me.FraIncidencias.Controls.Add(Me.GridIncidencias)
        Me.FraIncidencias.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraIncidencias.Location = New System.Drawing.Point(0, 57)
        Me.FraIncidencias.Name = "FraIncidencias"
        Me.FraIncidencias.Size = New System.Drawing.Size(720, 193)
        Me.FraIncidencias.TabIndex = 10
        Me.FraIncidencias.TabStop = False
        Me.FraIncidencias.Text = "Asignación de Incidencias"
        '
        'GridIncidencias
        '
        Me.GridIncidencias.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDIncidenciasAlquiler", "IncidenciasAlquiler", "IDIncidenciasAlquiler", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescIncidenciasAlquiler", "DescIncidenciasAlquiler"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("AfectaFactura", "AfectaFactura")}))})
        Me.GridIncidencias.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridIncidencias_DesignTimeLayout.LayoutString = resources.GetString("GridIncidencias_DesignTimeLayout.LayoutString")
        Me.GridIncidencias.DesignTimeLayout = GridIncidencias_DesignTimeLayout
        Me.GridIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridIncidencias.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridIncidencias.EntityName = ""
        Me.GridIncidencias.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridIncidencias.Location = New System.Drawing.Point(3, 17)
        Me.GridIncidencias.Name = "GridIncidencias"
        Me.GridIncidencias.PrimaryDataFields = Nothing
        Me.GridIncidencias.SecondaryDataFields = Nothing
        Me.GridIncidencias.Size = New System.Drawing.Size(714, 173)
        Me.GridIncidencias.TabIndex = 9
        Me.GridIncidencias.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridIncidencias.ViewName = ""
        '
        'fraAsignarFechaRetorno
        '
        Me.fraAsignarFechaRetorno.Controls.Add(Me.lblHora)
        Me.fraAsignarFechaRetorno.Controls.Add(Me.txtHora)
        Me.fraAsignarFechaRetorno.Controls.Add(Me.lblFecha)
        Me.fraAsignarFechaRetorno.Controls.Add(Me.cbxFecha)
        Me.fraAsignarFechaRetorno.Dock = System.Windows.Forms.DockStyle.Top
        Me.fraAsignarFechaRetorno.Location = New System.Drawing.Point(0, 0)
        Me.fraAsignarFechaRetorno.Name = "fraAsignarFechaRetorno"
        Me.fraAsignarFechaRetorno.Size = New System.Drawing.Size(720, 57)
        Me.fraAsignarFechaRetorno.TabIndex = 9
        Me.fraAsignarFechaRetorno.TabStop = False
        Me.fraAsignarFechaRetorno.Text = "Asignación de Fechas del Retorno"
        '
        'lblHora
        '
        Me.lblHora.Location = New System.Drawing.Point(343, 28)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(104, 13)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "Hora del Retorno"
        '
        'txtHora
        '
        Me.txtHora.DisabledBackColor = System.Drawing.Color.White
        Me.txtHora.Location = New System.Drawing.Point(453, 24)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(85, 21)
        Me.txtHora.TabIndex = 8
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(112, 28)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(110, 13)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Fecha del Retorno"
        '
        'cbxFecha
        '
        Me.cbxFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFecha.Location = New System.Drawing.Point(229, 24)
        Me.cbxFecha.Name = "cbxFecha"
        Me.cbxFecha.Size = New System.Drawing.Size(92, 21)
        Me.cbxFecha.TabIndex = 7
        '
        'FraContadores
        '
        Me.FraContadores.Controls.Add(Me.GridContadores)
        Me.FraContadores.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraContadores.Location = New System.Drawing.Point(0, 250)
        Me.FraContadores.Name = "FraContadores"
        Me.FraContadores.Size = New System.Drawing.Size(720, 184)
        Me.FraContadores.TabIndex = 13
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
        Me.GridContadores.Size = New System.Drawing.Size(714, 164)
        Me.GridContadores.TabIndex = 6
        Me.GridContadores.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridContadores.ViewName = ""
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.cmbAceptar)
        Me.panel1.Controls.Add(Me.cmbCancel)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 434)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(720, 40)
        Me.panel1.TabIndex = 14
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(236, 7)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(128, 27)
        Me.cmbAceptar.TabIndex = 7
        Me.cmbAceptar.Text = "Siguiente"
        '
        'cmbCancel
        '
        Me.cmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancel.Location = New System.Drawing.Point(371, 7)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(129, 27)
        Me.cmbCancel.TabIndex = 6
        Me.cmbCancel.Text = "Cancelar"
        '
        'frmDatosAuxCambioMaquina1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(720, 474)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.FraContadores)
        Me.Controls.Add(Me.FraIncidencias)
        Me.Controls.Add(Me.fraAsignarFechaRetorno)
        Me.Name = "frmDatosAuxCambioMaquina1"
        Me.Text = "Activos a Sustituir (Retorno de Material)"
        Me.FraIncidencias.ResumeLayout(False)
        CType(Me.GridIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraAsignarFechaRetorno.ResumeLayout(False)
        Me.fraAsignarFechaRetorno.PerformLayout()
        Me.FraContadores.ResumeLayout(False)
        CType(Me.GridContadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Class DatosRetornoMaquina1
        Public dtContadores As DataTable
        Public dtIncidencias As DataTable
        Public dtmFecha As Date
        Public strHora As String
        Public Ok As DialogResult
    End Class

    Private mDtContadores, mDtIncidencias As DataTable
    Private datos As DatosRetornoMaquina1

#Region " Load "

    Public Function AbrirFormulario(ByVal dt As DataTable) As DatosRetornoMaquina1

        datos = New DatosRetornoMaquina1

        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            cbxFecha.Value = dt.Rows(0)("FechaAlquiler")
            txtHora.Text = dt.Rows(0)("HoraAlquiler")

            Dim fContador As New Filter
            Dim fIncidencias As New Filter

            LoadFiltro(dt, fContador)

            If fContador.Count > 0 Then LoadContadores(fContador)
            LoadIncidencias(dt)
        End If

        Me.ShowDialog()

        Return datos
    End Function

    Private Sub LoadFiltro(ByVal dt As DataTable, ByRef fContador As Filter)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            Dim strFiltro() As Object
            ReDim strFiltro(-1)

            For Each dr As DataRow In dt.Rows
                ReDim Preserve strFiltro(UBound(strFiltro) + 1)
                strFiltro(UBound(strFiltro)) = dr("IDLineaAlbaran")
            Next
            If strFiltro.Length > 0 Then
                fContador.Add(New InListFilterItem("IDLineaAlbaranOrigen", strFiltro, FilterType.String))
            End If
        End If
    End Sub

    Private Sub LoadContadores(ByVal fContador As Filter)
        Dim be As New be.DataEngine
        Dim dt As DataTable = be.Filter("vFrmAlquilerAsignaContadoresRetornos", fContador)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            mDtContadores = dt.Clone
            For Each dr As DataRow In dt.Rows
                Dim drNew As DataRow = mDtContadores.NewRow
                For Each dc As DataColumn In dr.Table.Columns
                    If (dc.ColumnName = "IDAlbaranOrigen" Or dc.ColumnName = "IDLineaAlbaranOrigen") Then
                        drNew(dc.ColumnName) = dr(dc.ColumnName)
                    ElseIf dc.ColumnName <> "NuevaMedida" And dc.ColumnName <> "IDAlbaran" And _
                           dc.ColumnName <> "IDLineaAlbaran" And dc.ColumnName <> "IDLineaAlbaranDeposito" And _
                           dc.ColumnName <> "CantidadAux" And dc.ColumnName <> "IDLineaAlbaranOrigen" And _
                           dc.ColumnName <> "IDAlbaranOrigen" Then
                        drNew(dc.ColumnName) = dr(dc.ColumnName)
                    End If
                Next
                If length(drNew("TablaOrigen")) > 0 Then drNew("NuevaMedida") = Nz(dr("CantidadAux"), 0)

                mDtContadores.Rows.Add(drNew)
            Next
        End If
    End Sub

    Private Sub LoadIncidencias(ByVal dt As DataTable)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            Dim strIncidenciaSustitucionAveria As String = New Parametro().IncidenciaSustitucionMaquinasAveriadas

            Dim dtIA As DataTable = New IncidenciasAlquiler().SelOnPrimaryKey(strIncidenciaSustitucionAveria)
            If Not IsNothing(dtIA) AndAlso dtIA.Rows.Count > 0 Then
                Dim OMIA As New ObraMaterialIncidenciasAlq

                mDtIncidencias = New BE.DataEngine().Filter("vFrmAlquilerAsignaIncidencias", New NoRowsFilterItem)
                mDtIncidencias.TableName = OMIA.Entity
                For Each dr As DataRow In dt.Rows
                    Dim drIncidencia As DataRow = mDtIncidencias.NewRow
                    drIncidencia("IDLineaMaterialIncidenciasAlq") = OMIA.AddNewForm.Rows(0)("IDLineaMaterialIncidenciasAlq")
                    drIncidencia("DescArticulo") = dr("DescArticulo")
                    drIncidencia("Lote") = dr("Lote")
                    drIncidencia("IDLineaMaterial") = dr("IDLineaMaterial")
                    drIncidencia("IDMaterial") = dr("IDMaterial")
                    drIncidencia("IDObra") = dr("IDObra")
                    drIncidencia("IDTrabajo") = dr("IDTrabajo")
                    drIncidencia("CodTrabajo") = dr("CodTrabajo")
                    drIncidencia("FechaIncidencia") = Nz(dr("FechaAlquiler"), dr("FechaDevolucion"))
                    drIncidencia("IDIncidenciasAlquiler") = dtIA.Rows(0)("IDIncidenciasAlquiler")
                    drIncidencia("DescIncidenciasAlquiler") = dtIA.Rows(0)("DescIncidenciasAlquiler")
                    drIncidencia("AfectaFactura") = dtIA.Rows(0)("AfectaFactura")
                    drIncidencia("PorcentajeFact") = 100
                    drIncidencia("Imprimible") = True
                    drIncidencia("AlbaranOrigen") = dr("IDAlbaran")
                    drIncidencia("NAlbaranOrigen") = dr("NAlbaran")
                    drIncidencia("FechaAlbaran") = dr("FechaAlbaran")

                    mDtIncidencias.Rows.Add(drIncidencia)
                Next
            End If
        End If
    End Sub

    Private Sub frmDatosAuxCambioMaquina1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()

        GridContadores.DataSource = mDtContadores
        GridIncidencias.DataSource = mDtIncidencias
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumiaAfectaFactura", GridIncidencias.Columns("AfectaFactura"))
    End Sub

#End Region

#Region " GridIncidencias "

    Private Sub GridIncidencias_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridIncidencias.EditingCell
        Select Case e.Column.Key
            Case "AfectaFactura"
                e.Cancel = True
        End Select
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
        Dim blnCancel As Boolean
        Dim strMessage As String = String.Empty

        If length(cbxFecha.Value) = 0 And length(txtHora.Text) = 0 Then
            strMessage = "No ha rellenado los campos Fecha y Hora. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
        ElseIf length(cbxFecha.Value) = 0 Then
            strMessage = "No ha rellenado el campo Fecha. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
        ElseIf length(txtHora.Text) = 0 Then
            strMessage = "No ha rellenado el campo Hora. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
        End If
        If Length(strMessage) > 0 Then
            If ExpertisApp.GenerateMessage(strMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                blnCancel = True
            End If
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

    Private Function ValidaIncidencias() As Boolean
        Dim blnCancel As Boolean = False
        Dim dt As DataTable = GridIncidencias.DataSource
        If Not IsNothing(dt) Then
            Dim dv As New DataView(dt.Copy)
            Dim f As New Filter
            f.Add(New IsNullFilterItem("IDIncidenciasAlquiler", True))

            dv.RowFilter = f.Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                blnCancel = True
                ExpertisApp.GenerateMessage("Todas las incidencias deben estar rellenadas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                For Each dr As DataRow In dt.Rows
                    dr("FechaIncidencia") = cbxFecha.Value
                    If dr("FechaIncidencia") < dr("FechaAlbaran") Then
                        blnCancel = True
                        ExpertisApp.GenerateMessage("La fecha introducida para el retorno es inferior a la fecha de salida de la máquina a sustituir.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit For
                    End If
                Next
                If Not blnCancel Then GridIncidencias.DataSource = dt
            End If
        End If

        Return blnCancel
    End Function

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        Dim Cancel As Boolean = ValidarCamposFechas()
        If Not Cancel Then
            Cancel = ValidaContadores()
            If Not Cancel Then
                Cancel = ValidaIncidencias()
                If Not Cancel Then
                    datos.dtmFecha = IIf(Length(cbxFecha.Value) > 0, cbxFecha.Value, Date.Today)
                    datos.strHora = IIf(Length(txtHora.Text) > 0, txtHora.Text, Date.Today.ToShortTimeString)
                    datos.dtContadores = GridContadores.DataSource
                    datos.dtIncidencias = GridIncidencias.DataSource
                    datos.Ok = DialogResult.OK
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

#End Region

End Class
