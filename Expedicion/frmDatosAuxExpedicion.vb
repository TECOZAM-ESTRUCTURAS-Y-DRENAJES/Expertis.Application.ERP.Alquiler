Public Class frmDatosAuxExpedicion
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
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblHora As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtHora As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents FraAsigConductor As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents GridDatos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridEstadoActivo As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents fraEstadoMaquinas As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents fraAsignarFechaRetornos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblHoraRetornos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtHoraRetornos As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFechaRetornos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaRetornos As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlRetornos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraContadores As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents GridContadores As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridEstadoActivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosAuxExpedicion))
        Dim GridDatos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridContadores_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.fraAsignarFechaAlquiler = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblHora = New Solmicro.Expertis.Engine.UI.Label
        Me.txtHora = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.pnlRetornos = New Solmicro.Expertis.Engine.UI.Panel
        Me.fraEstadoMaquinas = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridEstadoActivo = New Solmicro.Expertis.Engine.UI.Grid
        Me.fraAsignarFechaRetornos = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblHoraRetornos = New Solmicro.Expertis.Engine.UI.Label
        Me.txtHoraRetornos = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFechaRetornos = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaRetornos = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FraAsigConductor = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridDatos = New Solmicro.Expertis.Engine.UI.Grid
        Me.FraContadores = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridContadores = New Solmicro.Expertis.Engine.UI.Grid
        Me.fraAsignarFechaAlquiler.SuspendLayout()
        Me.panel1.suspendlayout()
        Me.pnlRetornos.suspendlayout()
        Me.fraEstadoMaquinas.SuspendLayout()
        CType(Me.GridEstadoActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraAsignarFechaRetornos.SuspendLayout()
        Me.FraAsigConductor.SuspendLayout()
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraContadores.SuspendLayout()
        CType(Me.GridContadores, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.fraAsignarFechaAlquiler.Size = New System.Drawing.Size(720, 57)
        Me.fraAsignarFechaAlquiler.TabIndex = 6
        Me.fraAsignarFechaAlquiler.TabStop = False
        Me.fraAsignarFechaAlquiler.Text = "Asignación de Fechas del Alquiler"
        '
        'lblHora
        '
        Me.lblHora.Location = New System.Drawing.Point(333, 28)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(116, 13)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "Hora Inicio Alquiler"
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
        Me.lblFecha.Location = New System.Drawing.Point(104, 28)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(122, 13)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Fecha Inicio Alquiler"
        '
        'cbxFecha
        '
        Me.cbxFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFecha.Location = New System.Drawing.Point(229, 24)
        Me.cbxFecha.Name = "cbxFecha"
        Me.cbxFecha.Size = New System.Drawing.Size(92, 21)
        Me.cbxFecha.TabIndex = 7
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.cmbAceptar)
        Me.panel1.Controls.Add(Me.cmbCancel)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 469)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(720, 40)
        Me.panel1.TabIndex = 7
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
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 57)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(720, 3)
        Me.Splitter1.TabIndex = 9
        Me.Splitter1.TabStop = False
        '
        'pnlRetornos
        '
        Me.pnlRetornos.Controls.Add(Me.fraEstadoMaquinas)
        Me.pnlRetornos.Controls.Add(Me.fraAsignarFechaRetornos)
        Me.pnlRetornos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRetornos.Location = New System.Drawing.Point(0, 60)
        Me.pnlRetornos.Name = "pnlRetornos"
        Me.pnlRetornos.Size = New System.Drawing.Size(720, 132)
        Me.pnlRetornos.TabIndex = 11
        Me.pnlRetornos.Visible = False
        '
        'fraEstadoMaquinas
        '
        Me.fraEstadoMaquinas.Controls.Add(Me.GridEstadoActivo)
        Me.fraEstadoMaquinas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fraEstadoMaquinas.Location = New System.Drawing.Point(232, 0)
        Me.fraEstadoMaquinas.Name = "fraEstadoMaquinas"
        Me.fraEstadoMaquinas.Size = New System.Drawing.Size(488, 132)
        Me.fraEstadoMaquinas.TabIndex = 3
        Me.fraEstadoMaquinas.TabStop = False
        Me.fraEstadoMaquinas.Text = "Asignación del Estado de los Activos"
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
        Me.GridEstadoActivo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEstadoActivo.Location = New System.Drawing.Point(3, 17)
        Me.GridEstadoActivo.Name = "GridEstadoActivo"
        Me.GridEstadoActivo.PrimaryDataFields = Nothing
        Me.GridEstadoActivo.SecondaryDataFields = Nothing
        Me.GridEstadoActivo.Size = New System.Drawing.Size(482, 112)
        Me.GridEstadoActivo.TabIndex = 0
        Me.GridEstadoActivo.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridEstadoActivo.ViewName = Nothing
        '
        'fraAsignarFechaRetornos
        '
        Me.fraAsignarFechaRetornos.Controls.Add(Me.lblHoraRetornos)
        Me.fraAsignarFechaRetornos.Controls.Add(Me.txtHoraRetornos)
        Me.fraAsignarFechaRetornos.Controls.Add(Me.lblFechaRetornos)
        Me.fraAsignarFechaRetornos.Controls.Add(Me.cbxFechaRetornos)
        Me.fraAsignarFechaRetornos.Dock = System.Windows.Forms.DockStyle.Left
        Me.fraAsignarFechaRetornos.Location = New System.Drawing.Point(0, 0)
        Me.fraAsignarFechaRetornos.Name = "fraAsignarFechaRetornos"
        Me.fraAsignarFechaRetornos.Size = New System.Drawing.Size(232, 132)
        Me.fraAsignarFechaRetornos.TabIndex = 2
        Me.fraAsignarFechaRetornos.TabStop = False
        Me.fraAsignarFechaRetornos.Text = "Asignación de Fechas del Alquiler"
        '
        'lblHoraRetornos
        '
        Me.lblHoraRetornos.Location = New System.Drawing.Point(11, 78)
        Me.lblHoraRetornos.Name = "lblHoraRetornos"
        Me.lblHoraRetornos.Size = New System.Drawing.Size(116, 13)
        Me.lblHoraRetornos.TabIndex = 12
        Me.lblHoraRetornos.Text = "Hora Inicio Alquiler"
        '
        'txtHoraRetornos
        '
        Me.txtHoraRetornos.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraRetornos.Location = New System.Drawing.Point(136, 78)
        Me.txtHoraRetornos.Name = "txtHoraRetornos"
        Me.txtHoraRetornos.Size = New System.Drawing.Size(85, 21)
        Me.txtHoraRetornos.TabIndex = 13
        '
        'lblFechaRetornos
        '
        Me.lblFechaRetornos.Location = New System.Drawing.Point(11, 40)
        Me.lblFechaRetornos.Name = "lblFechaRetornos"
        Me.lblFechaRetornos.Size = New System.Drawing.Size(122, 13)
        Me.lblFechaRetornos.TabIndex = 11
        Me.lblFechaRetornos.Text = "Fecha Inicio Alquiler"
        '
        'cbxFechaRetornos
        '
        Me.cbxFechaRetornos.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaRetornos.Location = New System.Drawing.Point(136, 40)
        Me.cbxFechaRetornos.Name = "cbxFechaRetornos"
        Me.cbxFechaRetornos.Size = New System.Drawing.Size(84, 21)
        Me.cbxFechaRetornos.TabIndex = 10
        '
        'FraAsigConductor
        '
        Me.FraAsigConductor.Controls.Add(Me.GridDatos)
        Me.FraAsigConductor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraAsigConductor.Location = New System.Drawing.Point(0, 341)
        Me.FraAsigConductor.Name = "FraAsigConductor"
        Me.FraAsigConductor.Size = New System.Drawing.Size(720, 128)
        Me.FraAsigConductor.TabIndex = 13
        Me.FraAsigConductor.TabStop = False
        Me.FraAsigConductor.Text = "Asignación de Conductor"
        '
        'GridDatos
        '
        Me.GridDatos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("Conductor", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescConductor"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CCVenta", "IDCContable"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDUdVenta", "IDUDMedida"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDUDInterna", "IDUDInterna")}))})
        Me.GridDatos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridDatos_DesignTimeLayout.LayoutString = resources.GetString("GridDatos_DesignTimeLayout.LayoutString")
        Me.GridDatos.DesignTimeLayout = GridDatos_DesignTimeLayout
        Me.GridDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDatos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridDatos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridDatos.EntityName = ""
        Me.GridDatos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridDatos.Location = New System.Drawing.Point(3, 17)
        Me.GridDatos.Name = "GridDatos"
        Me.GridDatos.PrimaryDataFields = ""
        Me.GridDatos.SecondaryDataFields = ""
        Me.GridDatos.Size = New System.Drawing.Size(714, 108)
        Me.GridDatos.TabIndex = 4
        Me.GridDatos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridDatos.ViewName = ""
        '
        'FraContadores
        '
        Me.FraContadores.Controls.Add(Me.GridContadores)
        Me.FraContadores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraContadores.Location = New System.Drawing.Point(0, 192)
        Me.FraContadores.Name = "FraContadores"
        Me.FraContadores.Size = New System.Drawing.Size(720, 149)
        Me.FraContadores.TabIndex = 14
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
        Me.GridContadores.Size = New System.Drawing.Size(714, 129)
        Me.GridContadores.TabIndex = 6
        Me.GridContadores.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridContadores.ViewName = ""
        '
        'frmDatosAuxExpedicion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(720, 509)
        Me.Controls.Add(Me.FraContadores)
        Me.Controls.Add(Me.FraAsigConductor)
        Me.Controls.Add(Me.pnlRetornos)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.fraAsignarFechaAlquiler)
        Me.Name = "frmDatosAuxExpedicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Auxiliares de los Albaranes"
        Me.fraAsignarFechaAlquiler.ResumeLayout(False)
        Me.fraAsignarFechaAlquiler.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.pnlRetornos.ResumeLayout(False)
        Me.fraEstadoMaquinas.ResumeLayout(False)
        CType(Me.GridEstadoActivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraAsignarFechaRetornos.ResumeLayout(False)
        Me.fraAsignarFechaRetornos.PerformLayout()
        Me.FraAsigConductor.ResumeLayout(False)
        CType(Me.GridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraContadores.ResumeLayout(False)
        CType(Me.GridContadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Class DatosContadorConductor
        Public dtContadores As DataTable
        Public dtConductores As DataTable
        Public dtEstadoActivo As DataTable
        Public dtmFechaInicio As Date
        Public strHoraInicio As String
        Public Ok As DialogResult
    End Class

    Private mblnAsignarFecha, mblnRetornos, mblnConsumos, mblnExpedicion, mblnTraspaso, mblnCancel As Boolean
    Private mDtContadores, mDtConductores, mDtEstadoActivo As DataTable
    Private datos As DatosContadorConductor

#Region " Load "

    Public Function AbrirFormulario(ByVal dt As DataTable, _
                                    Optional ByVal blnAsignarFecha As Boolean = False, _
                                    Optional ByVal blnRetornos As Boolean = False, _
                                    Optional ByVal blnConsumos As Boolean = False, _
                                    Optional ByVal blnExpedicion As Boolean = False, _
                                    Optional ByVal blnTraspaso As Boolean = False) As DatosContadorConductor

        datos = New DatosContadorConductor

        mblnAsignarFecha = blnAsignarFecha
        mblnRetornos = blnRetornos
        mblnConsumos = blnConsumos
        mblnExpedicion = blnExpedicion
        mblnTraspaso = blnTraspaso

        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            Dim fContador As New Filter
            Dim fConductor As New Filter
            Dim fEstados As New Filter

            LoadFiltros(dt, fContador, fConductor, fEstados)

            If mblnTraspaso Then
                If fEstados.Count > 0 Then LoadEstados(fEstados)
            Else
                If fContador.Count > 0 Then LoadContadores(fContador)
                If Not blnRetornos Then
                    If fConductor.Count > 0 Then LoadConductores(fConductor)
                Else
                    FraAsigConductor.Visible = False
                End If
                If blnRetornos And fEstados.Count > 0 Then LoadEstados(fEstados)
            End If
        End If
        If Not mblnTraspaso Then
            If blnAsignarFecha Or (Not IsNothing(mDtContadores) AndAlso mDtContadores.Rows.Count > 0) Or (Not IsNothing(mDtConductores) AndAlso mDtConductores.Rows.Count > 0) Or (Not IsNothing(mDtEstadoActivo) AndAlso mDtEstadoActivo.Rows.Count > 0) Then
                Me.ShowDialog()
            Else
                datos.Ok = DialogResult.OK
            End If
        Else
            datos.dtEstadoActivo = mDtEstadoActivo
            datos.Ok = DialogResult.OK
        End If

        Return datos
    End Function

    Private Sub LoadFiltros(ByVal dt As DataTable, ByRef fContador As Filter, _
                            ByRef fConductor As Filter, ByRef fEstados As Filter)

        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            Dim strCampo, strCampoIN As String
            Dim strFiltro(), strFiltroConductor() As Object
            ReDim strFiltroConductor(-1)
            ReDim strFiltro(-1)

            If mblnRetornos Then
                strCampo = "IDLineaAlbaran" : strCampoIN = "IDLineaAlbaranOrigen"
            Else
                strCampo = "IdLineaMaterial" : strCampoIN = "IdLineaMaterial"
            End If
            For Each dr As DataRow In dt.Rows
                'Creamos dos filtros para los dos grid que vamos a necesitar:
                '  1. En el de conductores tengo que filtrar por aquellas líneas de material cuyos artículos necesiten llevar operario.
                '  2. En el caso de los contadores paso todas las líneas porque van a aparecer únicamente aquellas que tengan contadores.
                If dr("NecesitaOperario") Then
                    ReDim Preserve strFiltroConductor(UBound(strFiltroConductor) + 1)
                    strFiltroConductor(UBound(strFiltroConductor)) = dr(strCampo)
                End If
                ReDim Preserve strFiltro(UBound(strFiltro) + 1)
                strFiltro(UBound(strFiltro)) = dr(strCampo)
            Next
            If strFiltro.Length > 0 Then
                fEstados.Add(New InListFilterItem(strCampoIN, strFiltro, FilterType.String))
                fContador.Add(New InListFilterItem(strCampoIN, strFiltro, FilterType.String))
            End If
            If strFiltroConductor.Length > 0 Then
                fConductor.Add(New InListFilterItem(strCampoIN, strFiltroConductor, FilterType.String))
            End If
        End If
    End Sub

    Private Sub LoadContadores(ByVal fContador As Filter)
        Dim be As New be.DataEngine
        Dim strVista As String = IIf(mblnRetornos, "vFrmAlquilerAsignaContadoresRetornos", "vFrmAlquilerAsignaContadores")
        Dim dt As DataTable = be.Filter(strVista, fContador)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            mDtContadores = dt.Clone
            For Each dr As DataRow In dt.Rows
                Dim drNew As DataRow = mDtContadores.NewRow
                For Each dc As DataColumn In dr.Table.Columns
                    If (dc.ColumnName = "IDAlbaranOrigen" Or dc.ColumnName = "IDLineaAlbaranOrigen") And mblnRetornos Then
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

    Private Sub LoadConductores(ByVal fConductor As Filter)
        Dim be As New be.DataEngine
        Dim strVista As String = "vFrmAlquilerAsignaConductor"
        Dim dt As DataTable = be.Filter(strVista, fConductor)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            mDtConductores = dt.Clone
            For Each dr As DataRow In dt.Rows
                Dim drNew As DataRow = mDtConductores.NewRow
                For Each dc As DataColumn In dr.Table.Columns
                    If (dc.ColumnName = "IDAlbaranOrigen" Or dc.ColumnName = "IDLineaAlbaranOrigen") And mblnRetornos Then
                        drNew(dc.ColumnName) = dr(dc.ColumnName)
                    ElseIf dc.ColumnName <> "Marca" And dc.ColumnName <> "Conductor" And _
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
        Dim strEstadoActivoRetorno As String = String.Empty
        Dim strDescEstadoActivoRetorno As String = String.Empty
        If mblnTraspaso Then
            strEstadoActivoRetorno = NegocioGeneral.ESTADOACTIVO_TRABAJANDO
        Else
            If mblnConsumos Then
                strEstadoActivoRetorno = NegocioGeneral.ESTADOACTIVO_VENDIDO
            Else
                strEstadoActivoRetorno = New Parametro().EstadoActivoRetornosPorDefecto
            End If
        End If

        If Len(strEstadoActivoRetorno) > 0 Then
            Dim EstadoActivo As New MntoEstadoActivo
            Dim dtEA As DataTable = EstadoActivo.SelOnPrimaryKey(strEstadoActivoRetorno)
            If Not dtEA Is Nothing AndAlso dtEA.Rows.Count > 0 Then
                strDescEstadoActivoRetorno = dtEA.Rows(0)("DescEstadoActivo") & String.Empty
            End If
        End If

        Dim be As New be.DataEngine
        Dim strVista As String = IIf(mblnRetornos, "vFrmAlquilerAsignaEstadoActivosRetornos", "vFrmAlquilerAsignaEstadoActivos")
        Dim dt As DataTable = be.Filter(strVista, fEstados)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            mDtEstadoActivo = dt.Clone
            For Each dr As DataRow In dt.Rows
                Dim drNew As DataRow = mDtEstadoActivo.NewRow
                For Each dc As DataColumn In dr.Table.Columns
                    If (dc.ColumnName = "IDAlbaranOrigen" Or dc.ColumnName = "IDLineaAlbaranOrigen") And mblnRetornos Then
                        drNew(dc.ColumnName) = dr(dc.ColumnName)
                    ElseIf dc.ColumnName = "IDEstadoActivoNew" Then
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

    Private Sub frmDatosAuxExpedicion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        pnlRetornos.Visible = mblnRetornos

        fraAsignarFechaAlquiler.Visible = Not mblnRetornos
        If mblnExpedicion Then
            fraAsignarFechaAlquiler.Visible = Not mblnExpedicion
            GridContadores.Columns("NObra").Visible = True
            GridDatos.Columns("NObra").Visible = True
            FraAsigConductor.Height = Me.Height / 2
        End If

        cbxFecha.Enabled = mblnAsignarFecha : cbxFechaRetornos.Enabled = mblnAsignarFecha
        txtHora.Enabled = mblnAsignarFecha : txtHoraRetornos.Enabled = mblnAsignarFecha

        GridContadores.DataSource = mDtContadores
        GridDatos.DataSource = mDtConductores
        GridEstadoActivo.DataSource = mDtEstadoActivo
    End Sub

#End Region

    Private Sub txtHoraRetornos_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHoraRetornos.LostFocus
        If length(txtHoraRetornos.Text) > 0 Then
            Dim tmHoraAlquiler As Date
            If InStr(txtHoraRetornos.Text, ":") = 0 Then
                tmHoraAlquiler = txtHoraRetornos.Text & ":0"
            Else
                tmHoraAlquiler = txtHoraRetornos.Text
            End If
            txtHoraRetornos.Text = Format(tmHoraAlquiler, "HH:mm:ss")
            txtHora.Text = txtHoraRetornos.Text
        End If

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

    Private Sub cbxFechaRetornos_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaRetornos.LostFocus
        cbxFecha.Value = cbxFechaRetornos.Value
    End Sub

#Region " GridEstadoActivo "

    Private Sub GridEstadoActivo_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridEstadoActivo.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "IDEstadoActivoNew"
                If mblnConsumos Then
                    e.Filter.Add(New BooleanFilterItem("Baja", True))
                Else
                    e.Filter.Add(New BooleanFilterItem("Retornos", True))
                End If
        End Select
    End Sub

#End Region

#Region " GridContadores "

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

    Private Sub GridContadores_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridContadores.EditingCell
        If e.Column.Key <> "NuevaMedida" Then e.Cancel = True
    End Sub

#End Region

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
        Dim strMsg As String = String.Empty

        If Not mblnRetornos And Not mblnExpedicion Then
            If length(cbxFecha.Value) = 0 And length(txtHora.Text) = 0 Then
                strMsg = "No ha rellenado los campos Fecha y Hora. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
            ElseIf length(cbxFecha.Value) = 0 Then
                strMsg = "No ha rellenado el campo Fecha. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
            ElseIf length(txtHora.Text) = 0 Then
                strMsg = "No ha rellenado el campo Hora. Por defecto se cogerá esta información del sistema. ¿Desea continuar.?"
            End If
            If length(strMsg) > 0 Then
                If ExpertisApp.GenerateMessage(strMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                    blnCancel = True
                End If
            End If
        End If
        Return blnCancel
    End Function

    Private Function ValidaEstadosActivos() As Boolean
        Dim blnCancel As Boolean = False
        If mblnRetornos Then
            Dim dt As DataTable = GridEstadoActivo.DataSource
            Dim dv As New DataView(dt)
            Dim f As New Filter
            f.Add(New IsNullFilterItem("IDEstadoActivoNew", True))

            dv.RowFilter = f.Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                blnCancel = True
                ExpertisApp.GenerateMessage("Todos los estados nuevos de los activos se deben rellenar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                    If mblnRetornos Then
                        drNewConductor("IDAlbaranOrigen") = drv.Row("IDAlbaranOrigen")
                        drNewConductor("IDLineaAlbaranOrigen") = drv.Row("IDLineaAlbaranOrigen")
                    End If

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
                    datos.dtmFechaInicio = IIf(Length(cbxFecha.Value) > 0, cbxFecha.Value, Date.Today)
                    datos.strHoraInicio = IIf(Length(txtHora.Text) > 0, txtHora.Text, Date.Today.ToShortTimeString)
                    datos.dtContadores = GridContadores.DataSource
                    datos.dtConductores = GeneraConductores()
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
