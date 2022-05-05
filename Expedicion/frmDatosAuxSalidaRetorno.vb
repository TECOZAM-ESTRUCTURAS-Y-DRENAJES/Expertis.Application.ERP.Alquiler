Public Class frmDatosAuxSalidaRetorno
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
    Friend WithEvents lblFwIIdAlbaran As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fraEstadoMaquinas As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents GridEstadoActivo As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents fraAsignarFechaRetornos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraAlbaran As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblFechaSalida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaSalida As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblHoraSalida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtHoraSalida As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFechaRetorno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaRetorno As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblHoraRetorno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtHoraRetorno As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FraContadores As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FraAsigConductor As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents GridContadores As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridDatos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlEstados As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtNAlbaran As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridEstadoActivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosAuxSalidaRetorno))
        Dim GridContadores_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridDatos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.FraAlbaran = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFwIIdAlbaran = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNAlbaran = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlEstados = New Solmicro.Expertis.Engine.UI.Panel
        Me.fraEstadoMaquinas = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridEstadoActivo = New Solmicro.Expertis.Engine.UI.Grid
        Me.fraAsignarFechaRetornos = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblHoraRetorno = New Solmicro.Expertis.Engine.UI.Label
        Me.txtHoraRetorno = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFechaRetorno = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaRetorno = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblHoraSalida = New Solmicro.Expertis.Engine.UI.Label
        Me.txtHoraSalida = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFechaSalida = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaSalida = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FraContadores = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridContadores = New Solmicro.Expertis.Engine.UI.Grid
        Me.panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.FraAsigConductor = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridDatos = New Solmicro.Expertis.Engine.UI.Grid
        Me.FraAlbaran.SuspendLayout()
        Me.pnlEstados.suspendlayout()
        Me.fraEstadoMaquinas.SuspendLayout()
        CType(Me.GridEstadoActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraAsignarFechaRetornos.SuspendLayout()
        Me.FraContadores.SuspendLayout()
        CType(Me.GridContadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.suspendlayout()
        Me.FraAsigConductor.SuspendLayout()
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FraAlbaran
        '
        Me.FraAlbaran.Controls.Add(Me.lblFwIIdAlbaran)
        Me.FraAlbaran.Controls.Add(Me.txtNAlbaran)
        Me.FraAlbaran.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraAlbaran.Location = New System.Drawing.Point(0, 0)
        Me.FraAlbaran.Name = "FraAlbaran"
        Me.FraAlbaran.Size = New System.Drawing.Size(736, 46)
        Me.FraAlbaran.TabIndex = 12
        Me.FraAlbaran.TabStop = False
        '
        'lblFwIIdAlbaran
        '
        Me.lblFwIIdAlbaran.Location = New System.Drawing.Point(19, 19)
        Me.lblFwIIdAlbaran.Name = "lblFwIIdAlbaran"
        Me.lblFwIIdAlbaran.Size = New System.Drawing.Size(69, 13)
        Me.lblFwIIdAlbaran.TabIndex = 0
        Me.lblFwIIdAlbaran.Text = "Nº Albarán"
        '
        'txtNAlbaran
        '
        Me.txtNAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.txtNAlbaran.Location = New System.Drawing.Point(107, 15)
        Me.txtNAlbaran.Name = "txtNAlbaran"
        Me.txtNAlbaran.Size = New System.Drawing.Size(109, 21)
        Me.txtNAlbaran.TabIndex = 1
        '
        'pnlEstados
        '
        Me.pnlEstados.Controls.Add(Me.fraEstadoMaquinas)
        Me.pnlEstados.Controls.Add(Me.fraAsignarFechaRetornos)
        Me.pnlEstados.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEstados.Location = New System.Drawing.Point(0, 46)
        Me.pnlEstados.Name = "pnlEstados"
        Me.pnlEstados.Size = New System.Drawing.Size(736, 146)
        Me.pnlEstados.TabIndex = 13
        '
        'fraEstadoMaquinas
        '
        Me.fraEstadoMaquinas.Controls.Add(Me.GridEstadoActivo)
        Me.fraEstadoMaquinas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fraEstadoMaquinas.Location = New System.Drawing.Point(216, 0)
        Me.fraEstadoMaquinas.Name = "fraEstadoMaquinas"
        Me.fraEstadoMaquinas.Size = New System.Drawing.Size(520, 146)
        Me.fraEstadoMaquinas.TabIndex = 3
        Me.fraEstadoMaquinas.TabStop = False
        Me.fraEstadoMaquinas.Text = "Asignación de Estados de los Activos"
        '
        'GridEstadoActivo
        '
        Me.GridEstadoActivo.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDEstadoActivoNew", "MntoEstadoActivo", "IDEstadoActivo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescEstadoActivo", "DescEstadoActivoNew")}))})
        Me.GridEstadoActivo.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEstadoActivo.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridEstadoActivo_DesignTimeLayout.LayoutString = resources.GetString("GridEstadoActivo_DesignTimeLayout.LayoutString")
        Me.GridEstadoActivo.DesignTimeLayout = GridEstadoActivo_DesignTimeLayout
        Me.GridEstadoActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEstadoActivo.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEstadoActivo.EntityName = Nothing
        Me.GridEstadoActivo.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridEstadoActivo.Location = New System.Drawing.Point(3, 17)
        Me.GridEstadoActivo.Name = "GridEstadoActivo"
        Me.GridEstadoActivo.PrimaryDataFields = Nothing
        Me.GridEstadoActivo.SecondaryDataFields = Nothing
        Me.GridEstadoActivo.Size = New System.Drawing.Size(514, 126)
        Me.GridEstadoActivo.TabIndex = 0
        Me.GridEstadoActivo.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridEstadoActivo.ViewName = Nothing
        '
        'fraAsignarFechaRetornos
        '
        Me.fraAsignarFechaRetornos.Controls.Add(Me.lblHoraRetorno)
        Me.fraAsignarFechaRetornos.Controls.Add(Me.txtHoraRetorno)
        Me.fraAsignarFechaRetornos.Controls.Add(Me.lblFechaRetorno)
        Me.fraAsignarFechaRetornos.Controls.Add(Me.cbxFechaRetorno)
        Me.fraAsignarFechaRetornos.Controls.Add(Me.lblHoraSalida)
        Me.fraAsignarFechaRetornos.Controls.Add(Me.txtHoraSalida)
        Me.fraAsignarFechaRetornos.Controls.Add(Me.lblFechaSalida)
        Me.fraAsignarFechaRetornos.Controls.Add(Me.cbxFechaSalida)
        Me.fraAsignarFechaRetornos.Dock = System.Windows.Forms.DockStyle.Left
        Me.fraAsignarFechaRetornos.Location = New System.Drawing.Point(0, 0)
        Me.fraAsignarFechaRetornos.Name = "fraAsignarFechaRetornos"
        Me.fraAsignarFechaRetornos.Size = New System.Drawing.Size(216, 146)
        Me.fraAsignarFechaRetornos.TabIndex = 2
        Me.fraAsignarFechaRetornos.TabStop = False
        Me.fraAsignarFechaRetornos.Text = "Asignación de Fechas de Salida y Retorno"
        '
        'lblHoraRetorno
        '
        Me.lblHoraRetorno.Location = New System.Drawing.Point(18, 112)
        Me.lblHoraRetorno.Name = "lblHoraRetorno"
        Me.lblHoraRetorno.Size = New System.Drawing.Size(83, 13)
        Me.lblHoraRetorno.TabIndex = 15
        Me.lblHoraRetorno.Text = "Hora Retorno"
        '
        'txtHoraRetorno
        '
        Me.txtHoraRetorno.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraRetorno.Location = New System.Drawing.Point(111, 108)
        Me.txtHoraRetorno.Name = "txtHoraRetorno"
        Me.txtHoraRetorno.Size = New System.Drawing.Size(90, 21)
        Me.txtHoraRetorno.TabIndex = 14
        '
        'lblFechaRetorno
        '
        Me.lblFechaRetorno.Location = New System.Drawing.Point(18, 88)
        Me.lblFechaRetorno.Name = "lblFechaRetorno"
        Me.lblFechaRetorno.Size = New System.Drawing.Size(89, 13)
        Me.lblFechaRetorno.TabIndex = 12
        Me.lblFechaRetorno.Text = "Fecha Retorno"
        '
        'cbxFechaRetorno
        '
        Me.cbxFechaRetorno.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaRetorno.Location = New System.Drawing.Point(111, 84)
        Me.cbxFechaRetorno.Name = "cbxFechaRetorno"
        Me.cbxFechaRetorno.Size = New System.Drawing.Size(89, 21)
        Me.cbxFechaRetorno.TabIndex = 13
        '
        'lblHoraSalida
        '
        Me.lblHoraSalida.Location = New System.Drawing.Point(18, 64)
        Me.lblHoraSalida.Name = "lblHoraSalida"
        Me.lblHoraSalida.Size = New System.Drawing.Size(73, 13)
        Me.lblHoraSalida.TabIndex = 11
        Me.lblHoraSalida.Text = "Hora Salida"
        '
        'txtHoraSalida
        '
        Me.txtHoraSalida.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraSalida.Location = New System.Drawing.Point(111, 60)
        Me.txtHoraSalida.Name = "txtHoraSalida"
        Me.txtHoraSalida.Size = New System.Drawing.Size(90, 21)
        Me.txtHoraSalida.TabIndex = 10
        '
        'lblFechaSalida
        '
        Me.lblFechaSalida.Location = New System.Drawing.Point(18, 39)
        Me.lblFechaSalida.Name = "lblFechaSalida"
        Me.lblFechaSalida.Size = New System.Drawing.Size(79, 13)
        Me.lblFechaSalida.TabIndex = 9
        Me.lblFechaSalida.Text = "Fecha Salida"
        '
        'cbxFechaSalida
        '
        Me.cbxFechaSalida.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaSalida.Location = New System.Drawing.Point(111, 35)
        Me.cbxFechaSalida.Name = "cbxFechaSalida"
        Me.cbxFechaSalida.Size = New System.Drawing.Size(89, 21)
        Me.cbxFechaSalida.TabIndex = 8
        '
        'FraContadores
        '
        Me.FraContadores.Controls.Add(Me.GridContadores)
        Me.FraContadores.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraContadores.Location = New System.Drawing.Point(0, 192)
        Me.FraContadores.Name = "FraContadores"
        Me.FraContadores.Size = New System.Drawing.Size(736, 184)
        Me.FraContadores.TabIndex = 16
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
        Me.GridContadores.Size = New System.Drawing.Size(730, 164)
        Me.GridContadores.TabIndex = 6
        Me.GridContadores.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridContadores.ViewName = ""
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.cmbAceptar)
        Me.panel1.Controls.Add(Me.cmbCancel)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 478)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(736, 40)
        Me.panel1.TabIndex = 15
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(236, 7)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(128, 27)
        Me.cmbAceptar.TabIndex = 7
        Me.cmbAceptar.Text = "Aceptar"
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
        'FraAsigConductor
        '
        Me.FraAsigConductor.Controls.Add(Me.GridDatos)
        Me.FraAsigConductor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraAsigConductor.Location = New System.Drawing.Point(0, 376)
        Me.FraAsigConductor.Name = "FraAsigConductor"
        Me.FraAsigConductor.Size = New System.Drawing.Size(736, 102)
        Me.FraAsigConductor.TabIndex = 17
        Me.FraAsigConductor.TabStop = False
        Me.FraAsigConductor.Text = "Asignación de Conductor"
        '
        'GridDatos
        '
        Me.GridDatos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("Conductor", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CCVenta", "IDCContable"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescConductor"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDUdVenta", "IDUdMedida"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDUdInterna", "IDUdInterna")}))})
        Me.GridDatos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridDatos_DesignTimeLayout.LayoutString = resources.GetString("GridDatos_DesignTimeLayout.LayoutString")
        Me.GridDatos.DesignTimeLayout = GridDatos_DesignTimeLayout
        Me.GridDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDatos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridDatos.EntityName = ""
        Me.GridDatos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridDatos.Location = New System.Drawing.Point(3, 17)
        Me.GridDatos.Name = "GridDatos"
        Me.GridDatos.PrimaryDataFields = ""
        Me.GridDatos.SecondaryDataFields = ""
        Me.GridDatos.Size = New System.Drawing.Size(730, 82)
        Me.GridDatos.TabIndex = 4
        Me.GridDatos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridDatos.ViewName = ""
        '
        'frmDatosAuxSalidaRetorno
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(736, 518)
        Me.Controls.Add(Me.FraAsigConductor)
        Me.Controls.Add(Me.FraContadores)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.pnlEstados)
        Me.Controls.Add(Me.FraAlbaran)
        Me.Name = "frmDatosAuxSalidaRetorno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Auxiliares de los Albaranes"
        Me.FraAlbaran.ResumeLayout(False)
        Me.FraAlbaran.PerformLayout()
        Me.pnlEstados.ResumeLayout(False)
        Me.fraEstadoMaquinas.ResumeLayout(False)
        CType(Me.GridEstadoActivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraAsignarFechaRetornos.ResumeLayout(False)
        Me.fraAsignarFechaRetornos.PerformLayout()
        Me.FraContadores.ResumeLayout(False)
        CType(Me.GridContadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.FraAsigConductor.ResumeLayout(False)
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Class DatosSalidaRetorno
        Public dtContadores As DataTable
        Public dtConductores As DataTable
        Public dtEstadoActivo As DataTable
        Public dtmFechaSalida, dtmFechaRetorno As Date
        Public strHoraSalida, strHoraRetorno, strNAlbaran As String
        Public Ok As DialogResult
    End Class

    Private mblnAsignarFecha, mblnCancel As Boolean
    Private mDtContadores, mDtConductores, mDtEstadoActivo As DataTable
    Private datos As DatosSalidaRetorno

#Region " Load "

    Public Function AbrirFormulario(ByVal dt As DataTable, ByVal dtmFecha As Date) As DatosSalidaRetorno

        datos = New DatosSalidaRetorno

        If dtmFecha <> cnMinDate Then
            cbxFechaSalida.Value = dtmFecha
            cbxFechaRetorno.Value = dtmFecha
        End If

        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            Dim fContador As New Filter
            Dim fConductor As New Filter
            Dim fEstados As New Filter

            LoadFiltros(dt, fContador, fConductor, fEstados)

            If fContador.Count > 0 Then LoadContadores(fContador)
            If fConductor.Count > 0 Then LoadConductores(fConductor)
            If fEstados.Count > 0 Then LoadEstados(fEstados)
        End If

        Me.ShowDialog()

        Return datos
    End Function

    Private Sub LoadFiltros(ByVal dt As DataTable, ByRef fContador As Filter, _
                            ByRef fConductor As Filter, ByRef fEstados As Filter)

        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            Dim strFiltro(), strFiltroConductor() As Object
            ReDim strFiltroConductor(-1)
            ReDim strFiltro(-1)

            For Each dr As DataRow In dt.Rows
                'Creamos dos filtros para los dos grid que vamos a necesitar:
                '  1. En el de conductores tengo que filtrar por aquellas líneas de material cuyos artículos necesiten llevar operario.
                '  2. En el caso de los contadores paso todas las líneas porque van a aparecer únicamente aquellas que tengan contadores.
                If dr("NecesitaOperario") Then
                    ReDim Preserve strFiltroConductor(UBound(strFiltroConductor) + 1)
                    strFiltroConductor(UBound(strFiltroConductor)) = dr("IDLineaMaterial")
                End If
                ReDim Preserve strFiltro(UBound(strFiltro) + 1)
                strFiltro(UBound(strFiltro)) = dr("IDLineaMaterial")
            Next
            If strFiltro.Length > 0 Then
                fEstados.Add(New InListFilterItem("IDLineaMaterial", strFiltro, FilterType.String))
                fContador.Add(New InListFilterItem("IDLineaMaterial", strFiltro, FilterType.String))
            End If
            If strFiltroConductor.Length > 0 Then
                fConductor.Add(New InListFilterItem("IDLineaMaterial", strFiltroConductor, FilterType.String))
            End If
        End If
    End Sub

    Private Sub LoadContadores(ByVal fContador As Filter)
        Dim be As New be.DataEngine
        Dim dt As DataTable = be.Filter("vFrmAlquilerAsignaMedidasContador", fContador)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            mDtContadores = dt.Clone
            For Each dr As DataRow In dt.Rows
                Dim drNew As DataRow = mDtContadores.NewRow
                For Each dc As DataColumn In dr.Table.Columns
                    If dc.ColumnName <> "MedidaSalida" And dc.ColumnName <> "MedidaRetorno" And _
                       dc.ColumnName <> "IDAlbaran" And dc.ColumnName <> "IDLineaAlbaran" And _
                       dc.ColumnName <> "IDLineaAlbaranDeposito" And dc.ColumnName <> "CantidadAux" _
                       And dc.ColumnName <> "IDLineaAlbaranOrigen" And dc.ColumnName <> "IDAlbaranOrigen" Then
                        drNew(dc.ColumnName) = dr(dc.ColumnName)
                    End If
                Next
                If length(drNew("TablaOrigen")) > 0 Then
                    drNew("MedidaSalida") = Nz(dr("CantidadAux"), 0)
                    drNew("MedidaRetorno") = Nz(dr("CantidadAux"), 0)
                End If

                mDtContadores.Rows.Add(drNew)
            Next
        End If
    End Sub

    Private Sub LoadConductores(ByVal fConductor As Filter)
        Dim be As New be.DataEngine
        Dim dt As DataTable = be.Filter("vFrmAlquilerAsignaConductor", fConductor)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            mDtConductores = dt.Clone
            For Each dr As DataRow In dt.Rows
                Dim drNew As DataRow = mDtConductores.NewRow
                For Each dc As DataColumn In dr.Table.Columns
                    If dc.ColumnName <> "Marca" And dc.ColumnName <> "Conductor" And _
                           dc.ColumnName <> "DescConductor" And dc.ColumnName <> "IDUDMedida" And _
                           dc.ColumnName <> "IDUDInterna" And dc.ColumnName <> "IDCContable" And _
                           dc.ColumnName <> "IDAlbaranOrigen" And dc.ColumnName <> "IDLineAlbaranOrigen" Then
                        drNew(dc.ColumnName) = dr(dc.ColumnName)
                    End If
                Next

                mDtConductores.Rows.Add(drNew)
            Next
        End If
    End Sub

    Private Sub LoadEstados(ByVal fEstados As Filter)
        'En este caso de Albaranes de salida y de retornos a la vez, vamos a poner el
        'estado de la máquina a DISPONIBLE porque en la mayoría de los casos este proceso
        'se utiliza para la inserción de bonos de trabajo de máquinas que están en el
        'el cliente. Aún así, existe la posibilidad de cambiar este estado para definr
        'el estado al que sequiere pasar.
        Dim strEstadoActivoRetorno As String = NegocioGeneral.ESTADOACTIVO_DISPONIBLE
        Dim strDescEstadoActivoRetorno As String = String.Empty

        Dim dtEA As DataTable = New MntoEstadoActivo().SelOnPrimaryKey(strEstadoActivoRetorno)
        If Not dtEA Is Nothing AndAlso dtEA.Rows.Count > 0 Then
            strDescEstadoActivoRetorno = dtEA.Rows(0)("DescEstadoActivo") & String.Empty
        End If

        Dim be As New be.DataEngine
        Dim dt As DataTable = be.Filter("vFrmAlquilerAsignaEstadoActivos", fEstados)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            mDtEstadoActivo = dt.Clone
            For Each dr As DataRow In dt.Rows
                Dim drNew As DataRow = mDtEstadoActivo.NewRow
                For Each dc As DataColumn In dr.Table.Columns
                    If dc.ColumnName = "IDEstadoActivoNew" Then
                        drNew(dc.ColumnName) = strEstadoActivoRetorno
                    ElseIf dc.ColumnName = "DescEstadoActivoNew" Then
                        drNew(dc.ColumnName) = strDescEstadoActivoRetorno
                    ElseIf dc.ColumnName <> "Marca" And dc.ColumnName <> "IDEstadoActivoNew" And _
                           dc.ColumnName <> "DescEstadoActivoNew" And dc.ColumnName <> "IDAlbaranOrigen" And _
                           dc.ColumnName <> "IDLineAlbaranOrigen" Then
                        drNew(dc.ColumnName) = dr(dc.ColumnName)
                    End If
                Next

                mDtEstadoActivo.Rows.Add(drNew)
            Next
        End If
    End Sub

    Private Sub frmDatosAuxSalidaRetorno_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridContadores.DataSource = mDtContadores
        GridDatos.DataSource = mDtConductores
        GridEstadoActivo.DataSource = mDtEstadoActivo
    End Sub

#End Region

    Private Sub txtHoraSalida_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtHoraSalida.Validating
        If length(txtHoraSalida.Text) > 0 Then
            Dim tmHoraSalida As Date
            If InStr(txtHoraSalida.Text, ":") = 0 Then
                tmHoraSalida = txtHoraSalida.Text & ":0"
            Else
                tmHoraSalida = txtHoraSalida.Text
            End If
            txtHoraSalida.Text = Format(tmHoraSalida, "HH:mm:ss")
        End If

        If length(cbxFechaSalida.Value) > 0 AndAlso length(cbxFechaRetorno.Value) > 0 Then
            If cbxFechaSalida.Value = cbxFechaRetorno.Value Then
                If length(txtHoraSalida.Text) > 0 And length(txtHoraRetorno.Text) > 0 Then
                    If txtHoraSalida.Text >= txtHoraRetorno.Text Then
                        'ExpertisApp.GenerateMessage(13282, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, ExpertisApp.Title)
                        ExpertisApp.GenerateMessage("El Albarán de Salida tiene la misma fecha que el Albarán de Retorno. La Hora de Salida tiene que ser inferior a la de Retorno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        'txtHoraSalida.Text = String.Empty
                        e.Cancel = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtHoraRetorno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtHoraRetorno.Validating
        If length(txtHoraRetorno.Text) > 0 Then
            Dim tmHoraRetorno As Date
            If InStr(txtHoraRetorno.Text, ":") = 0 Then
                tmHoraRetorno = txtHoraRetorno.Text & ":0"
            Else
                tmHoraRetorno = txtHoraRetorno.Text
            End If
            txtHoraRetorno.Text = Format(tmHoraRetorno, "HH:mm:ss")
        End If

        If length(cbxFechaSalida.Value) > 0 AndAlso length(cbxFechaRetorno.Value) > 0 Then
            If cbxFechaSalida.Value = cbxFechaRetorno.Value Then
                If length(txtHoraRetorno.Text) > 0 AndAlso length(txtHoraSalida.Text) > 0 Then
                    If txtHoraSalida.Text >= txtHoraRetorno.Text Then
                        'ExpertisApp.GenerateMessage(13282, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, ExpertisApp.Title)
                        ExpertisApp.GenerateMessage("El Albarán de Salida tiene la misma fecha que el Albarán de Retorno. La Hora de Salida tiene que ser inferior a la de Retorno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        'txtHoraRetorno.Text = String.Empty
                        e.Cancel = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cbxFechaSalida_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxFechaSalida.Validating
        If Length(cbxFechaRetorno.Value) > 0 AndAlso Length(cbxFechaSalida.Value) > 0 Then
            If cbxFechaSalida.Value > cbxFechaRetorno.Value Then
                'ExpertisApp.GenerateMessage(13281, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, ExpertisApp.Title)
                ExpertisApp.GenerateMessage("La Fecha de Retorno del Albarán debe ser mayor o igual a la Fecha de Salida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If

            If cbxFechaSalida.Value = cbxFechaRetorno.Value Then
                If Length(txtHoraSalida.Text) > 0 And Length(txtHoraRetorno.Text) > 0 Then
                    If txtHoraSalida.Text >= txtHoraRetorno.Text Then
                        'ExpertisApp.GenerateMessage(13282, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, ExpertisApp.Title)
                        ExpertisApp.GenerateMessage("El Albarán de Salida tiene la misma fecha que el Albarán de Retorno. La Hora de Salida tiene que ser inferior a la de Retorno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtHoraSalida.Text = String.Empty
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cbxFechaRetorno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxFechaRetorno.Validating
        If length(cbxFechaRetorno.Value) > 0 AndAlso length(cbxFechaSalida.Value) > 0 Then
            If cbxFechaSalida.Value > cbxFechaRetorno.Value Then
                'ExpertisApp.GenerateMessage(13281, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, ExpertisApp.Title)
                ExpertisApp.GenerateMessage("La Fecha de Retorno del Albarán debe ser mayor o igual a la Fecha de Salida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If

            If cbxFechaSalida.Value = cbxFechaRetorno.Value Then
                If length(txtHoraSalida.Text) > 0 And length(txtHoraRetorno.Text) > 0 Then
                    If txtHoraSalida.Text >= txtHoraRetorno.Text Then
                        'ExpertisApp.GenerateMessage(13282, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, ExpertisApp.Title)
                        ExpertisApp.GenerateMessage("El Albarán de Salida tiene la misma fecha que el Albarán de Retorno. La Hora de Salida tiene que ser inferior a la de Retorno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtHoraSalida.Text = String.Empty
                    End If
                End If
            End If
        End If
    End Sub

#Region " GridEstadoActivo "

    Private Sub GridEstadoActivo_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridEstadoActivo.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "IDEstadoActivoNew"
                e.Filter.Add(New BooleanFilterItem("Retornos", True))
        End Select
    End Sub

#End Region

    Private Sub GridContadores_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridContadores.EditingCell
        If e.Column.Key <> "MedidaSalida" And e.Column.Key <> "MedidaRetorno" Then e.Cancel = True
    End Sub

    Private Sub GridDatos_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridDatos.UpdatingCell
        With GridDatos
            If e.Column.Key = "Conductor" Then
                Dim art As New Articulo
                Dim dtArt As DataTable = art.SelOnPrimaryKey(e.Value)
                If IsNothing(dtArt) OrElse dtArt.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("No hay ningún Artículo con este Código", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Value = DBNull.Value
                    e.Cancel = True
                Else
                    'para asegurar que se rellenen estos campos: 
                    .Value(.Columns("IDCContable").Index) = dtArt.Rows(0)("CCVenta")
                    .Value(.Columns("IDUDMedida").Index) = dtArt.Rows(0)("IDUdVenta")
                    .Value(.Columns("IDUDInterna").Index) = dtArt.Rows(0)("IDUDInterna")
                    .Value(.Columns("DescConductor").Index) = dtArt.Rows(0)("DescArticulo")
                End If
            End If
        End With
    End Sub

#Region " cmbAceptar_Click "

    Private Function ValidarCamposFechas() As Boolean
        Dim blnCancel As Boolean
        Dim strMessage As String = String.Empty

        If (length(cbxFechaSalida.Value) = 0 And length(txtHoraSalida.Text) = 0) Or length(cbxFechaRetorno.Value) = 0 And length(txtHoraRetorno.Text) = 0 Then
            strMessage = "No ha rellenado los campos Fecha y Hora. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
        ElseIf length(cbxFechaSalida.Value) = 0 Or length(cbxFechaRetorno.Value) = 0 Then
            strMessage = "No ha rellenado el campo Fecha. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
        ElseIf length(txtHoraSalida.Text) = 0 Or length(txtHoraRetorno.Text) = 0 Then
            strMessage = "No ha rellenado el campo Hora. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
        End If
        If Length(strMessage) > 0 Then
            If ExpertisApp.GenerateMessage(strMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                blnCancel = True
            End If
        End If

        Return blnCancel
    End Function

    Private Function ValidaEstadosActivos() As Boolean
        Dim blnCancel As Boolean = False
        Dim dt As DataTable = GridEstadoActivo.DataSource
        Dim dv As New DataView(dt)
        Dim f As New Filter
        f.Add(New IsNullFilterItem("IDEstadoActivoNew", True))

        dv.RowFilter = f.Compose(New AdoFilterComposer)
        If dv.Count > 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("Todos los estados nuevos de las máquinas se deben rellenar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Return blnCancel
    End Function

    Private Function ValidaContadores() As Boolean
        Dim blnCancel As Boolean = False
        Dim dt As DataTable = GridContadores.DataSource
        Dim dv As New DataView(dt)
        Dim f As New Filter(FilterUnionOperator.Or)
        f.Add(New IsNullFilterItem("MedidaSalida", True))
        f.Add(New IsNullFilterItem("MedidaRetorno", True))

        dv.RowFilter = f.Compose(New AdoFilterComposer)
        If dv.Count > 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("Todas las medidas de los contadores deben estar rellenadas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Return blnCancel
    End Function

    Private Function GeneraConductores() As DataTable
        Dim dtConductor As DataTable = GridDatos.DataSource
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

                For Each drv As DataRowView In dvConductor
                    Dim drNewConductor As DataRow = dtConductores.NewRow
                    drNewConductor("IDLineaMaterial") = drv.Row("IDLineaMaterial")
                    drNewConductor("IDTrabajo") = drv.Row("IDTrabajo")
                    drNewConductor("CodTrabajo") = drv.Row("CodTrabajo")
                    drNewConductor("Conductor") = drv.Row("Conductor")
                    drNewConductor("DescConductor") = drv.Row("DescConductor")
                    drNewConductor("Cantidad") = 1
                    drNewConductor("IDUDMedida") = drv.Row("IDUDMedida")
                    drNewConductor("IDUdInterna") = drv.Row("IDUdInterna")
                    drNewConductor("CContable") = drv.Row("IDCContable")
                    drNewConductor("IDCliente") = drv.Row("IDCliente")
                    drNewConductor("IDMoneda") = drv.Row("IDMoneda")
                    drNewConductor("CambioA") = drv.Row("CambioA")
                    drNewConductor("CambioB") = drv.Row("CambioB")

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
            mblnCancel = ValidaEstadosActivos()
            If Not mblnCancel Then
                mblnCancel = ValidaContadores()
                If Not mblnCancel Then
                    datos.dtmFechaSalida = IIf(Length(cbxFechaSalida.Value) > 0, cbxFechaSalida.Value, Date.Today)
                    datos.strHoraSalida = IIf(Length(txtHoraSalida.Text) > 0, txtHoraSalida.Text, Date.Today.ToShortTimeString)
                    datos.dtmFechaRetorno = IIf(Length(cbxFechaRetorno.Value) > 0, cbxFechaRetorno.Value, Date.Today)
                    datos.strHoraRetorno = IIf(Length(txtHoraRetorno.Text) > 0, txtHoraRetorno.Text, Date.Today.ToShortTimeString)
                    datos.dtContadores = GridContadores.DataSource
                    datos.dtConductores = GeneraConductores()
                    datos.strNAlbaran = txtNAlbaran.Text
                    If Not mblnCancel Then
                        datos.dtEstadoActivo = GridEstadoActivo.DataSource
                        datos.Ok = DialogResult.OK
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            End If
        End If
    End Sub

#End Region

End Class
