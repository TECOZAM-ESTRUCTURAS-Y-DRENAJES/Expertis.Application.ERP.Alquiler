Imports System.Collections.Generic

Public Class CIFacturacion

    Private Const cnPROPUESTACIERRE As String = "Propuesta Cierre Ordenes"
    Private Const cnCALCULARVTOS As String = "Calcular Vencimientos Alquiler"
    Private Const cnCALCULARCOSTES As String = "Movimientos de consumibles."
    Private Const cnCALCULARCOSTESRESUMEN As String = "Resumen consumibles."
    Private Const CNMOVIMIENTOSELECTROPORATIL As String = "Movimientos de electroportatil."
    Private Const CNRESUMENELECTROPORATIL As String = "Resumen electroportatil."

    Private mdtCalculo As DataTable
    Private mIDMaterial, mIDOT, mIDOTHitos, mIDVencimiento As Integer
    Private mIDCentroGestion As String

#Region " Load "

    Private Sub CIFacturacion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.RecordsState = RecordsState.Saved
    End Sub

    Private Sub CIFacturacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not DesignMode Then
            LoadEnums()
            LoadToolBarActions()
            LoadGridActions()
            LoadConfigTab()
            ActiveExecuteActions()
            ActivateControls()
            chkCalculoSeguros.Checked = True
            LoadParams()
        End If
    End Sub

    Private Sub LoadEnums()
        cbxPeriodoFacturacion.DataSource = New EnumData("enummcPeriodoFacturacion")
        cbxClienteEventual.DataSource = New EnumData("enumBoolean")
        EnumData.PopulateValueList("enumTipoFacturacionAlquiler", GridAlquiler.Columns("TipoFactAlquiler"))
        cbxTipoOT.DataSource = New EnumData("enumOTTipoLineasPrev")
        cbxEstadoOT.DataSource = New EnumData("enumavlEstadoFactura")
        EnumData.PopulateValueList("enumavlEstadoFactura", GridAlbaran.Columns("EstadoFactura"))
        EnumData.PopulateValueList("enumotEstadoFactura", GridTallerAlquiler.Columns("EstadoFactura"))
    End Sub

    Private Sub LoadToolbarActions()
        Me.AddSeparator()
        Me.FormActions.Add(cnPROPUESTACIERRE, AddressOf PropuestaCierreOrdenes, ExpertisApp.GetIcon("lock_preferences.ico"))
        Me.AddSeparator()
        Me.FormActions.Add(cnCALCULARVTOS, AddressOf CalcularVtosAlquiler, ExpertisApp.GetIcon("alarmclock_run.ico"))
        Me.AddSeparator()
        'Informes Jose Arribas
        Me.FormActions.Add(cnCALCULARCOSTES, AddressOf CalcularCostes, ExpertisApp.GetIcon("alarmclock_run.ico"))
        Me.FormActions.Add(cnCALCULARCOSTESRESUMEN, AddressOf CalcularCostesResumen, ExpertisApp.GetIcon("alarmclock_run.ico"))
        Me.AddSeparator()
        Me.FormActions.Add(CNMOVIMIENTOSELECTROPORATIL, AddressOf CalcularCostesElectroportatil, ExpertisApp.GetIcon("alarmclock_run.ico"))
        Me.FormActions.Add(CNRESUMENELECTROPORATIL, AddressOf CalcularResumenElectroportatil, ExpertisApp.GetIcon("alarmclock_run.ico"))
    End Sub

    Private Sub LoadGridActions()
        LoadGridActionsVtos()
        LoadGridActionsAlquiler()
        LoadGridActionsAlbaran()
    End Sub

    Private Sub LoadConfigTab()
        TabFacturacion.TabPages("Materiales").TabVisible = False
        TabFacturacion.TabPages("Certificacion").TabVisible = False
        GridCertificacion.Visible = False
        TabFacturacion.TabPages(TabPageAlquiler.Key).Selected = True
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            If Me.ProgramInfo.Alias = "FACTALQUILER" Then
                Dim ht As Hashtable = Me.Params
                AdvObraDesde.Value = ht("IDObra")
                AdvObraDesde.Text = ht("NObra")
                AdvObraHasta.Value = ht("IDObra")
                AdvObraHasta.Text = ht("NObra")
                AdvTrabajo.Value = ht("IDTrabajo")
                AdvTrabajo.Text = ht("CodTrabajo")

                Me.Execute()
            End If
        End If
    End Sub

#Region " Load Acciones Grids "

    Protected Overrides Sub LoadGridVtosActions1()
        GridVtos.Actions.Add("Abrir Alquiler", AddressOf AbrirAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub LoadGridActionsVtos()
        GridVtos.Actions.Add(cnABRIRALBARANVENTA, AddressOf AbrirAlbaran, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
        GridVtos.Actions.Add("Abrir Albarán Retorno", AddressOf VerAlbaranRetorno, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
    End Sub

    Private Sub LoadGridActionsAlquiler()
        GridAlquiler.Actions.Add(cnABRIRALQUILER, AddressOf AbrirAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
        GridAlquiler.Actions.Add(cnABRIRALBARANVENTA, AddressOf AbrirAlbaran, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
        GridAlquiler.Actions.Add("Abrir Albarán Retorno", AddressOf VerAlbaranRetorno, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
    End Sub

    Private Sub LoadGridActionsAlbaran()
        GridAlbaran.Actions.Add(cnABRIRALQUILER, AddressOf AbrirAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
        GridAlbaran.Actions.Add(cnABRIRALBARANVENTA, AddressOf AbrirAlbaran, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
    End Sub

#End Region

#End Region

#Region " Acciones ToolBar "

    Private Sub PropuestaCierreOrdenes()
        ExpertisApp.OpenForm("PROCIERRE")
    End Sub
    Private Sub CalcularCostes()
        Dim blnCancel As Boolean
        If Length(cbxFechaCalculo.Value) = 0 Then
            If ExpertisApp.GenerateMessage("No se ha seleccionado una Fecha de Cálculo. Por defecto se cogerá la fecha actual. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then blnCancel = True
        End If

        If Not blnCancel Then
            Dim strMessage As String = "El proceso puede tardar varios minutos. ¿Desea continuar?."
            If Length(AdvObraDesde.Value) = 0 And Length(AdvObraHasta.Value) = 0 And Length(AdvClienteDesde.Value) = 0 _
                And Length(AdvClienteHasta.Value) = 0 And Length(AdvIDCentroGestion.Value) = 0 And Length(AdvIDArticulo.Value) = 0 _
                And Length(AdvTipoArticulo.Value) = 0 And Length(AdvFamiliaArticulo.Value) = 0 Then
                strMessage = "ADVERTENCIA!!!!!! Va a ejecutar el cálculo de la facturación sin haber puesto ningún filtro. Esto ralentizará mucho el sistema y puede bloquear a otros usuarios. Desea continuar con el Proceso?"
            End If
            If ValidarFiltrosProcesoCalculo() Then
                If ExpertisApp.GenerateMessage(strMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    If Length(cbxFechaCalculo.Value) = 0 Then cbxFechaCalculo.Value = Date.Today

                    Dim f As New Filter
                    If Length(AdvObraDesde.Value) > 0 Then f.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
                    If Length(AdvObraHasta.Value) > 0 Then f.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
                    If Length(AdvClienteDesde.Value) > 0 Then f.Add("IDCliente", FilterOperator.GreaterThanOrEqual, AdvClienteDesde.Value, FilterType.String)
                    'David Velasco 27/10
                    If Length(AdvTipoArticulo.Value) > 0 Then f.Add("IDTipo", FilterOperator.Equal, AdvTipoArticulo.Value, FilterType.String)
                    If Length(AdvFamiliaArticulo.Value) > 0 Then f.Add("IDFamilia", FilterOperator.Equal, AdvFamiliaArticulo.Value, FilterType.String)
                    If Length(AdvIDArticulo.Value) > 0 Then f.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)

                    If Length(cbxFechaDesde.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
                    '21/03/22
                    'If Length(cbxFechaHasta1.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
                    If Length(cbxFechaHasta.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
                    'If Length(AdvAlqOVend.Value) > 0 Then f.Add("DescFacturacion", FilterOperator.Equal, AdvAlqOVend.Value, FilterType.String)
                    'Fin David
                    If Length(AdvClienteHasta.Value) > 0 Then f.Add("IDCliente", FilterOperator.LessThanOrEqual, AdvClienteHasta.Value, FilterType.String)
                    If Length(AdvTrabajo.Value) > 0 Then f.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
                    If Length(AdvIDCentroGestion.Value) > 0 Then f.Add("IDCentroGestion", FilterOperator.Equal, AdvIDCentroGestion.Value, FilterType.String)
                    If Length(cbxFechaCalculo.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaCalculo.Value, FilterType.DateTime)

                    Dim intDiaFacturacion As Integer
                    If Length(txtDiaFacturacion.Text) > 0 Then
                        intDiaFacturacion = txtDiaFacturacion.Text
                    End If
                    Dim FechaCalculo As Date = cbxFechaCalculo.Value
                    If chkTenerEnCuenta.Checked Then
                        FechaCalculo = New Date(FechaCalculo.Year, FechaCalculo.Month, intDiaFacturacion)
                    End If
                    Dim datosVtos As New dataConfigCalculoFacturacion(FechaCalculo, f, intDiaFacturacion, chkTenerEnCuenta.Checked, chkFacturarOrdenesCerradas.Checked, enumomACalculoRiesgoCliente.omANoCalculoRiesgo, AdvClienteDesde.Value)
                    mdtCalculo = ExpertisApp.ExecuteTask(Of dataConfigCalculoFacturacion, DataTable)(AddressOf CalculoFacturacion.GetLineasFacturacionAlquiler, datosVtos)

                    'GridAlquiler.DataSource = mdtCalculo

                    Dim rp As New Report("INFCOSTALQ")

                    'filtro.Add("Nobra", FilterOperator.Equal, obra)

                    'Tengo que meterle a cada linea en Seguimiento, la unidad
                    Dim dt As New DataTable
                    Dim dtAuxiliar As New DataTable
                    Dim contador As Integer
                    contador = 0
                    Dim filtro As New Filter

                    'Recorro linea por linea y le pongo las unidades a cada articulo
                    For Each dr As DataRow In mdtCalculo.Rows
                        filtro.Add("IDArticulo", FilterOperator.Equal, mdtCalculo.Rows(contador)("IDArticulo"))
                        dtAuxiliar = New BE.DataEngine().Filter("tbMaestroArticulo", filtro)
                        mdtCalculo.Rows(contador)("Seguimiento") = Nz(dtAuxiliar.Rows(0)("IDUdInterna"), "")
                        contador += 1
                        filtro.Clear()

                    Next
                    rp.DataSource = mdtCalculo


                    'rp.DataSource = New BE.DataEngine().Filter("vFrmCIObraFacturacion", filtro)
                    ExpertisApp.OpenReport(rp)

                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CalcularCostesResumen()
        Dim blnCancel As Boolean
        If Length(cbxFechaCalculo.Value) = 0 Then
            If ExpertisApp.GenerateMessage("No se ha seleccionado una Fecha de Cálculo. Por defecto se cogerá la fecha actual. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then blnCancel = True
        End If

        If Not blnCancel Then
            Dim strMessage As String = "El proceso puede tardar varios minutos. ¿Desea continuar?."
            If Length(AdvObraDesde.Value) = 0 And Length(AdvObraHasta.Value) = 0 And Length(AdvClienteDesde.Value) = 0 _
                And Length(AdvClienteHasta.Value) = 0 And Length(AdvIDCentroGestion.Value) = 0 And Length(AdvIDArticulo.Value) = 0 _
                And Length(AdvTipoArticulo.Value) = 0 And Length(AdvFamiliaArticulo.Value) = 0 Then
                strMessage = "ADVERTENCIA!!!!!! Va a ejecutar el cálculo de la facturación sin haber puesto ningún filtro. Esto ralentizará mucho el sistema y puede bloquear a otros usuarios. Desea continuar con el Proceso?"
            End If
            If ValidarFiltrosProcesoCalculo() Then
                If ExpertisApp.GenerateMessage(strMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    If Length(cbxFechaCalculo.Value) = 0 Then cbxFechaCalculo.Value = Date.Today

                    Dim f As New Filter
                    If Length(AdvObraDesde.Value) > 0 Then f.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
                    If Length(AdvObraHasta.Value) > 0 Then f.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
                    If Length(AdvClienteDesde.Value) > 0 Then f.Add("IDCliente", FilterOperator.GreaterThanOrEqual, AdvClienteDesde.Value, FilterType.String)
                    'David Velasco 27/10
                    If Length(AdvTipoArticulo.Value) > 0 Then f.Add("IDTipo", FilterOperator.Equal, AdvTipoArticulo.Value, FilterType.String)
                    If Length(AdvFamiliaArticulo.Value) > 0 Then f.Add("IDFamilia", FilterOperator.Equal, AdvFamiliaArticulo.Value, FilterType.String)
                    If Length(AdvIDArticulo.Value) > 0 Then f.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)

                    If Length(cbxFechaDesde.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
                    'If Length(cbxFechaHasta1.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
                    If Length(cbxFechaHasta.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
                    'If Length(AdvAlqOVend.Value) > 0 Then f.Add("DescFacturacion", FilterOperator.Equal, AdvAlqOVend.Value, FilterType.String)
                    'Fin David
                    If Length(AdvClienteHasta.Value) > 0 Then f.Add("IDCliente", FilterOperator.LessThanOrEqual, AdvClienteHasta.Value, FilterType.String)
                    If Length(AdvTrabajo.Value) > 0 Then f.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
                    If Length(AdvIDCentroGestion.Value) > 0 Then f.Add("IDCentroGestion", FilterOperator.Equal, AdvIDCentroGestion.Value, FilterType.String)
                    If Length(cbxFechaCalculo.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaCalculo.Value, FilterType.DateTime)

                    Dim intDiaFacturacion As Integer
                    If Length(txtDiaFacturacion.Text) > 0 Then
                        intDiaFacturacion = txtDiaFacturacion.Text
                    End If
                    Dim FechaCalculo As Date = cbxFechaCalculo.Value
                    If chkTenerEnCuenta.Checked Then
                        FechaCalculo = New Date(FechaCalculo.Year, FechaCalculo.Month, intDiaFacturacion)
                    End If
                    Dim datosVtos As New dataConfigCalculoFacturacion(FechaCalculo, f, intDiaFacturacion, chkTenerEnCuenta.Checked, chkFacturarOrdenesCerradas.Checked, enumomACalculoRiesgoCliente.omANoCalculoRiesgo, AdvClienteDesde.Value)
                    mdtCalculo = ExpertisApp.ExecuteTask(Of dataConfigCalculoFacturacion, DataTable)(AddressOf CalculoFacturacion.GetLineasFacturacionAlquiler, datosVtos)

                    'GridAlquiler.DataSource = mdtCalculo

                    Dim rp As New Report("INFCOSRESUMEN")
                    Dim filtro As New Filter
                    'filtro.Add("Nobra", FilterOperator.Equal, obra)
                    rp.DataSource = mdtCalculo

                    'rp.DataSource = New BE.DataEngine().Filter("vFrmCIObraFacturacion", filtro)
                    ExpertisApp.OpenReport(rp)

                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub CalcularResumenElectroportatil()
        Dim blnCancel As Boolean
        If Length(cbxFechaCalculo.Value) = 0 Then
            If ExpertisApp.GenerateMessage("No se ha seleccionado una Fecha de Cálculo. Por defecto se cogerá la fecha actual. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then blnCancel = True
        End If

        If Not blnCancel Then
            Dim strMessage As String = "El proceso puede tardar varios minutos. ¿Desea continuar?."
            If Length(AdvObraDesde.Value) = 0 And Length(AdvObraHasta.Value) = 0 And Length(AdvClienteDesde.Value) = 0 _
                And Length(AdvClienteHasta.Value) = 0 And Length(AdvIDCentroGestion.Value) = 0 And Length(AdvIDArticulo.Value) = 0 _
                And Length(AdvTipoArticulo.Value) = 0 And Length(AdvFamiliaArticulo.Value) = 0 Then
                strMessage = "ADVERTENCIA!!!!!! Va a ejecutar el cálculo de la facturación sin haber puesto ningún filtro. Esto ralentizará mucho el sistema y puede bloquear a otros usuarios. Desea continuar con el Proceso?"
            End If
            If ValidarFiltrosProcesoCalculo() Then
                If ExpertisApp.GenerateMessage(strMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    If Length(cbxFechaCalculo.Value) = 0 Then cbxFechaCalculo.Value = Date.Today

                    Dim f As New Filter
                    If Length(AdvObraDesde.Value) > 0 Then f.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
                    If Length(AdvObraHasta.Value) > 0 Then f.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
                    If Length(AdvClienteDesde.Value) > 0 Then f.Add("IDCliente", FilterOperator.GreaterThanOrEqual, AdvClienteDesde.Value, FilterType.String)
                    'David Velasco 27/10
                    If Length(AdvTipoArticulo.Value) > 0 Then f.Add("IDTipo", FilterOperator.Equal, AdvTipoArticulo.Value, FilterType.String)
                    If Length(AdvFamiliaArticulo.Value) > 0 Then f.Add("IDFamilia", FilterOperator.Equal, AdvFamiliaArticulo.Value, FilterType.String)
                    If Length(AdvIDArticulo.Value) > 0 Then f.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)

                    If Length(cbxFechaDesde.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
                    'If Length(cbxFechaHasta1.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaHasta1.Value, FilterType.DateTime)
                    If Length(cbxFechaHasta.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
                    'If Length(AdvAlqOVend.Value) > 0 Then f.Add("DescFacturacion", FilterOperator.Equal, AdvAlqOVend.Value, FilterType.String)
                    'Fin David
                    If Length(AdvClienteHasta.Value) > 0 Then f.Add("IDCliente", FilterOperator.LessThanOrEqual, AdvClienteHasta.Value, FilterType.String)
                    If Length(AdvTrabajo.Value) > 0 Then f.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
                    If Length(AdvIDCentroGestion.Value) > 0 Then f.Add("IDCentroGestion", FilterOperator.Equal, AdvIDCentroGestion.Value, FilterType.String)
                    If Length(cbxFechaCalculo.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaCalculo.Value, FilterType.DateTime)

                    Dim intDiaFacturacion As Integer
                    If Length(txtDiaFacturacion.Text) > 0 Then
                        intDiaFacturacion = txtDiaFacturacion.Text
                    End If
                    Dim FechaCalculo As Date = cbxFechaCalculo.Value
                    If chkTenerEnCuenta.Checked Then
                        FechaCalculo = New Date(FechaCalculo.Year, FechaCalculo.Month, intDiaFacturacion)
                    End If
                    Dim datosVtos As New dataConfigCalculoFacturacion(FechaCalculo, f, intDiaFacturacion, chkTenerEnCuenta.Checked, chkFacturarOrdenesCerradas.Checked, enumomACalculoRiesgoCliente.omANoCalculoRiesgo, AdvClienteDesde.Value)
                    mdtCalculo = ExpertisApp.ExecuteTask(Of dataConfigCalculoFacturacion, DataTable)(AddressOf CalculoFacturacion.GetLineasFacturacionAlquiler, datosVtos)


                    Dim Fecha1 As Date
                    Dim Fecha2 As Date

                    Dim frm As New frmInformeFecha
                    frm.ShowDialog()
                    Fecha1 = frm.FechaDesde.Value
                    Fecha2 = frm.FechaHasta.Value

                    If frm.blEstado = True Then
                        MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                    Dim dt As New DataTable
                    Dim contador As Integer
                    contador = 0

                    'Formo la estructura de la tabla igual que mdtCalculo
                    For i As Integer = 0 To mdtCalculo.Columns.Count - 1
                        dt.Columns.Add(mdtCalculo.Columns(i).ColumnName)
                    Next
                    For Each dr As DataRow In mdtCalculo.Rows
                        If mdtCalculo.Rows(contador)("FechaHastaAlquiler") >= Fecha1 And mdtCalculo.Rows(contador)("FechaHastaAlquiler") <= Fecha2 Then
                            dt.Rows.Add(mdtCalculo.Rows(contador).ItemArray)
                        End If
                        contador += 1
                    Next
                    Dim dt2 As New DataTable

                    dt2 = dt

                    Dim cont As Integer
                    cont = 0
                    Dim d As Date
                    Dim dias2 As Integer

                    'For Each dr As DataRow In dt2.Rows
                    '    d = dt2.Rows(cont)("FechaHastaAlquiler")
                    '    'dia = DateAndTime.Day(d)
                    '    dias2 = Work_Days(Fecha1, d)
                    '    If (dias2 = 0) Then
                    '        dias2 = 1
                    '    End If
                    '    dt2.Rows(cont)("Dto3") = dias2
                    '    cont += 1
                    'Next
                    For Each dr As DataRow In dt2.Rows
                        If (dt2.Rows(cont)("FechaDesdeAlquiler") > Fecha1) Then
                            d = dt2.Rows(cont)("FechaHastaAlquiler")
                            'dia = DateAndTime.Day(d)
                            dias2 = Work_Days(dt2.Rows(cont)("FechaDesdeAlquiler"), d)
                            If (dias2 = 0) Then
                                dias2 = 1
                            End If
                            dt2.Rows(cont)("Dto3") = dias2
                            cont += 1
                        Else
                            d = dt2.Rows(cont)("FechaHastaAlquiler")
                            'dia = DateAndTime.Day(d)
                            dias2 = Work_Days(Fecha1, d)
                            If (dias2 = 0) Then
                                dias2 = 1
                            End If
                            dt2.Rows(cont)("Dto3") = dias2
                            cont += 1
                        End If

                    Next

                    mdtCalculo = dt2
                    'LimpiaTabla(CDate(Fecha1), CDate(Fecha2))

                    Dim rp As New Report("INFRESELECTRO")
                    Dim filtro As New Filter
                    rp.DataSource = mdtCalculo
                    ExpertisApp.OpenReport(rp)

                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CalcularCostesElectroportatil()
        Dim blnCancel As Boolean
        If Length(cbxFechaCalculo.Value) = 0 Then
            If ExpertisApp.GenerateMessage("No se ha seleccionado una Fecha de Cálculo. Por defecto se cogerá la fecha actual. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then blnCancel = True
        End If

        If Not blnCancel Then
            Dim strMessage As String = "El proceso puede tardar varios minutos. ¿Desea continuar?."
            If Length(AdvObraDesde.Value) = 0 And Length(AdvObraHasta.Value) = 0 And Length(AdvClienteDesde.Value) = 0 _
                And Length(AdvClienteHasta.Value) = 0 And Length(AdvIDCentroGestion.Value) = 0 And Length(AdvIDArticulo.Value) = 0 _
                And Length(AdvTipoArticulo.Value) = 0 And Length(AdvFamiliaArticulo.Value) = 0 Then
                strMessage = "ADVERTENCIA!!!!!! Va a ejecutar el cálculo de la facturación sin haber puesto ningún filtro. Esto ralentizará mucho el sistema y puede bloquear a otros usuarios. Desea continuar con el Proceso?"
            End If
            If ValidarFiltrosProcesoCalculo() Then
                If ExpertisApp.GenerateMessage(strMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    If Length(cbxFechaCalculo.Value) = 0 Then cbxFechaCalculo.Value = Date.Today

                    Dim f As New Filter
                    If Length(AdvObraDesde.Value) > 0 Then f.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
                    If Length(AdvObraHasta.Value) > 0 Then f.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
                    If Length(AdvClienteDesde.Value) > 0 Then f.Add("IDCliente", FilterOperator.GreaterThanOrEqual, AdvClienteDesde.Value, FilterType.String)
                    'David Velasco 27/10
                    If Length(AdvTipoArticulo.Value) > 0 Then f.Add("IDTipo", FilterOperator.Equal, AdvTipoArticulo.Value, FilterType.String)
                    If Length(AdvFamiliaArticulo.Value) > 0 Then f.Add("IDFamilia", FilterOperator.Equal, AdvFamiliaArticulo.Value, FilterType.String)
                    If Length(AdvIDArticulo.Value) > 0 Then f.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)

                    If Length(cbxFechaDesde.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
                    'If Length(cbxFechaHasta1.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaHasta1.Value, FilterType.DateTime)
                    If Length(cbxFechaHasta.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
                    'If Length(AdvAlqOVend.Value) > 0 Then f.Add("DescFacturacion", FilterOperator.Equal, AdvAlqOVend.Value, FilterType.String)
                    'Fin David
                    If Length(AdvClienteHasta.Value) > 0 Then f.Add("IDCliente", FilterOperator.LessThanOrEqual, AdvClienteHasta.Value, FilterType.String)
                    If Length(AdvTrabajo.Value) > 0 Then f.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
                    If Length(AdvIDCentroGestion.Value) > 0 Then f.Add("IDCentroGestion", FilterOperator.Equal, AdvIDCentroGestion.Value, FilterType.String)
                    If Length(cbxFechaCalculo.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaCalculo.Value, FilterType.DateTime)

                    Dim intDiaFacturacion As Integer
                    If Length(txtDiaFacturacion.Text) > 0 Then
                        intDiaFacturacion = txtDiaFacturacion.Text
                    End If
                    Dim FechaCalculo As Date = cbxFechaCalculo.Value
                    If chkTenerEnCuenta.Checked Then
                        FechaCalculo = New Date(FechaCalculo.Year, FechaCalculo.Month, intDiaFacturacion)
                    End If
                    Dim datosVtos As New dataConfigCalculoFacturacion(FechaCalculo, f, intDiaFacturacion, chkTenerEnCuenta.Checked, chkFacturarOrdenesCerradas.Checked, enumomACalculoRiesgoCliente.omANoCalculoRiesgo, AdvClienteDesde.Value)
                    mdtCalculo = ExpertisApp.ExecuteTask(Of dataConfigCalculoFacturacion, DataTable)(AddressOf CalculoFacturacion.GetLineasFacturacionAlquiler, datosVtos)


                    Dim Fecha1 As Date
                    Dim Fecha2 As Date

                    Dim frm As New frmInformeFecha
                    frm.ShowDialog()
                    Fecha1 = frm.FechaDesde.Value
                    Fecha2 = frm.FechaHasta.Value
                    'Dim dias As Integer
                    'dias = Work_Days(Fecha1, Fecha2)
                    'MsgBox(dias)
                    If frm.blEstado = True Then
                        MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                    Dim dt As New DataTable
                    Dim contador As Integer
                    contador = 0

                    'Formo la estructura de la tabla igual que mdtCalculo
                    For i As Integer = 0 To mdtCalculo.Columns.Count - 1
                        dt.Columns.Add(mdtCalculo.Columns(i).ColumnName)
                    Next
                    For Each dr As DataRow In mdtCalculo.Rows
                        If mdtCalculo.Rows(contador)("FechaHastaAlquiler") >= Fecha1 And mdtCalculo.Rows(contador)("FechaHastaAlquiler") <= Fecha2 Then
                            dt.Rows.Add(mdtCalculo.Rows(contador).ItemArray)
                        End If
                        contador += 1
                    Next
                    Dim dt2 As New DataTable

                    dt2 = dt
                    'Este for calcula los dias habiles para cada fila  y se le asigna a la Dto3
                    Dim cont As Integer
                    cont = 0
                    Dim d As Date
                    Dim dias2 As Integer

                    For Each dr As DataRow In dt2.Rows
                        If (dt2.Rows(cont)("FechaDesdeAlquiler") > Fecha1) Then
                            d = dt2.Rows(cont)("FechaHastaAlquiler")
                            'dia = DateAndTime.Day(d)
                            dias2 = Work_Days(dt2.Rows(cont)("FechaDesdeAlquiler"), d)
                            If (dias2 = 0) Then
                                dias2 = 1
                            End If
                            dt2.Rows(cont)("Dto3") = dias2
                            cont += 1
                        Else
                            d = dt2.Rows(cont)("FechaHastaAlquiler")
                            'dia = DateAndTime.Day(d)
                            dias2 = Work_Days(Fecha1, d)
                            If (dias2 = 0) Then
                                dias2 = 1
                            End If
                            dt2.Rows(cont)("Dto3") = dias2
                            cont += 1
                        End If
                        
                    Next
                    mdtCalculo = dt2
                    'LimpiaTabla(CDate(Fecha1), CDate(Fecha2))

                    Dim rp As New Report("INFELECMOV")
                    Dim filtro As New Filter
                    rp.DataSource = mdtCalculo
                    rp.Formulas("fecha1").Text = Fecha1
                    ExpertisApp.OpenReport(rp)

                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Function Work_Days(ByVal Fecha1 As Object, ByVal Fecha2 As Object) As Integer
        ' No descuenta los Dias Festivos.
        Dim WholeWeeks As Object
        Dim DateCnt As Object
        Dim EndDays As Integer

        Fecha1 = DateValue(Fecha1)
        Fecha2 = DateValue(Fecha2)
        WholeWeeks = DateDiff("w", Fecha1, Fecha2)
        DateCnt = DateAdd("ww", WholeWeeks, Fecha1)
        EndDays = 0
        Do While DateCnt < Fecha2
            If Format(DateCnt, "ddd") <> "Sun" And _
                             Format(DateCnt, "ddd") <> "Sat" Then
                EndDays = EndDays + 1
            End If
            DateCnt = DateAdd("d", 1, DateCnt)
        Loop
        Work_Days = WholeWeeks * 5 + EndDays
    End Function

    Private Sub CalcularVtosAlquiler()
        Dim blnCancel As Boolean
        If Length(cbxFechaCalculo.Value) = 0 Then
            If ExpertisApp.GenerateMessage("No se ha seleccionado una Fecha de Cálculo. Por defecto se cogerá la fecha actual. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then blnCancel = True
        End If

        If Not blnCancel Then
            Dim strMessage As String = "El proceso puede tardar varios minutos. ¿Desea continuar?."
            If Length(AdvObraDesde.Value) = 0 And Length(AdvObraHasta.Value) = 0 And Length(AdvClienteDesde.Value) = 0 _
                And Length(AdvClienteHasta.Value) = 0 And Length(AdvIDCentroGestion.Value) = 0 And Length(AdvIDArticulo.Value) = 0 _
                And Length(AdvTipoArticulo.Value) = 0 And Length(AdvFamiliaArticulo.Value) = 0 Then
                strMessage = "ADVERTENCIA!!!!!! Va a ejecutar el cálculo de la facturación sin haber puesto ningún filtro. Esto ralentizará mucho el sistema y puede bloquear a otros usuarios. Desea continuar con el Proceso?"
            End If
            If ValidarFiltrosProcesoCalculo() Then
                If ExpertisApp.GenerateMessage(strMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    If Length(cbxFechaCalculo.Value) = 0 Then cbxFechaCalculo.Value = Date.Today

                    Dim f As New Filter
                    If Length(AdvObraDesde.Value) > 0 Then f.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
                    If Length(AdvObraHasta.Value) > 0 Then f.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
                    If Length(AdvClienteDesde.Value) > 0 Then f.Add("IDCliente", FilterOperator.GreaterThanOrEqual, AdvClienteDesde.Value, FilterType.String)
                    'David Velasco 27/10
                    If Length(AdvTipoArticulo.Value) > 0 Then f.Add("IDTipo", FilterOperator.Equal, AdvTipoArticulo.Value, FilterType.String)
                    If Length(AdvFamiliaArticulo.Value) > 0 Then f.Add("IDFamilia", FilterOperator.Equal, AdvFamiliaArticulo.Value, FilterType.String)
                    If Length(AdvIDArticulo.Value) > 0 Then f.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)

                    If Length(cbxFechaDesde.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
                    If Length(cbxFechaHasta.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
                    'If Length(AdvAlqOVend.Value) > 0 Then f.Add("DescFacturacion", FilterOperator.Equal, AdvAlqOVend.Value, FilterType.String)
                    'Fin David
                    If Length(AdvClienteHasta.Value) > 0 Then f.Add("IDCliente", FilterOperator.LessThanOrEqual, AdvClienteHasta.Value, FilterType.String)
                    If Length(AdvTrabajo.Value) > 0 Then f.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
                    If Length(AdvIDCentroGestion.Value) > 0 Then f.Add("IDCentroGestion", FilterOperator.Equal, AdvIDCentroGestion.Value, FilterType.String)
                    If Length(cbxFechaCalculo.Value) > 0 Then f.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaCalculo.Value, FilterType.DateTime)

                    Dim intDiaFacturacion As Integer
                    If Length(txtDiaFacturacion.Text) > 0 Then
                        intDiaFacturacion = txtDiaFacturacion.Text
                    End If
                    Dim FechaCalculo As Date = cbxFechaCalculo.Value
                    If chkTenerEnCuenta.Checked Then
                        FechaCalculo = New Date(FechaCalculo.Year, FechaCalculo.Month, intDiaFacturacion)
                    End If
                    Dim datosVtos As New dataConfigCalculoFacturacion(FechaCalculo, f, intDiaFacturacion, chkTenerEnCuenta.Checked, chkFacturarOrdenesCerradas.Checked, enumomACalculoRiesgoCliente.omANoCalculoRiesgo, AdvClienteDesde.Value)
                    mdtCalculo = ExpertisApp.ExecuteTask(Of dataConfigCalculoFacturacion, DataTable)(AddressOf CalculoFacturacion.GetLineasFacturacionAlquiler, datosVtos)

                    GridAlquiler.DataSource = mdtCalculo



                    Me.Cursor = Cursors.Default
                    ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function ValidarFiltrosProcesoCalculo() As Boolean
        Dim strFiltrosCampos As String = String.Empty

        Dim blnOK As Boolean = True
        If (Len(AdvObraDesde.Value) > 0 And Len(AdvObraHasta.Value) = 0) Or (Len(AdvObraDesde.Value) = 0 And Len(AdvObraHasta.Value) > 0) Then
            strFiltrosCampos = strFiltrosCampos & "Obra"
            blnOK = False
        End If
        If (Len(AdvClienteDesde.Value) > 0 And Len(AdvClienteHasta.Value) = 0) Or (Len(AdvClienteDesde.Value) = 0 And Len(AdvClienteHasta.Value) > 0) Then
            If Len(strFiltrosCampos) > 0 Then
                strFiltrosCampos = strFiltrosCampos & ", Cliente"
            Else
                strFiltrosCampos = strFiltrosCampos & "Cliente"
            End If
            blnOK = False
        End If

        If Not blnOK Then
            ExpertisApp.GenerateMessage("Para usar los filtros  tienen que rellenarse tanto el Desde como el Hasta.", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        Return blnOK
    End Function

#Region " GeneraHitosFacturacion "

    Protected Overrides Sub GeneraHitosFacturacion()
        Select Case TabFacturacion.SelectedTab.Key
            Case TabPageAlquiler.Key
                AddHitosAlquiler()
            Case TabPageTallerAlquiler.Key
                AddHitosTaller()
            Case TabPageAlbaran.Key
                AddHitosAlbaran()
            Case Else
                MyBase.GeneraHitosFacturacion()
        End Select
    End Sub

    Private Sub AddHitosAlquiler()
        If Not mdtCalculo Is Nothing AndAlso mdtCalculo.Rows.Count > 0 Then
            Dim f As New Filter
            If Length(AdvObraDesde.Value) > 0 Then f.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
            If Length(AdvObraHasta.Value) > 0 Then f.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
            If Length(AdvClienteDesde.Value) > 0 Then f.Add("IDCliente", FilterOperator.GreaterThanOrEqual, AdvClienteDesde.Value, FilterType.String)
            If Length(AdvClienteHasta.Value) > 0 Then f.Add("IDCliente", FilterOperator.LessThanOrEqual, AdvClienteHasta.Value, FilterType.String)
            If Length(AdvTrabajo.Value) > 0 Then f.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
            If Length(AdvIDCentroGestion.Value) > 0 Then f.Add("IDCentroGestion", FilterOperator.Equal, AdvIDCentroGestion.Value, FilterType.String)
            If Length(AdvIDArticulo.Value) > 0 Then f.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)
            If Length(cbxPeriodoFacturacion.Value) > 0 Then f.Add("PeriodoFacturacion", FilterOperator.Equal, cbxPeriodoFacturacion.Value, FilterType.Numeric)
            If cbxClienteEventual.Value <> enumBoolean.Todos Then
                'If length(cbxClienteEventual.Value) > 0 Then f.Add("ClienteEventual", FilterOperator.Equal, cbxClienteEventual.Value, FilterType.Boolean)
            End If

            Dim data As New ObraTrabajoFacturacion.DatosGenerarVencimientosAlquiler(mdtCalculo, f)
            ExpertisApp.ExecuteTask(Of ObraTrabajoFacturacion.DatosGenerarVencimientosAlquiler)(AddressOf ObraTrabajoFacturacion.GenerarVencimientosAlquiler, data)

            GridAlquiler.DataSource = Nothing
            mdtCalculo = Nothing
        End If
    End Sub

    Private Sub AddHitosAlbaran()
        If GridAlbaran.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = GridAlbaran.CheckedRecords
            Dim data As New ObraTrabajoFacturacion.DatosGenerarVencimientos(dtMarcados, Nz(cbxFechaVto.Value, Date.Today))
            ExpertisApp.ExecuteTask(Of ObraTrabajoFacturacion.DatosGenerarVencimientos)(AddressOf ObraTrabajoFacturacion.GenerarVencimientosAlbaran, data)
            GridAlbaran.UnCheckAllRecords()
            Me.Execute()
            ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AddHitosTaller()
        If GridTallerAlquiler.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = GridTallerAlquiler.CheckedRecords
            Dim data As New ObraTrabajoFacturacion.DatosGenerarVencimientos(dtMarcados, Nz(cbxFechaVto.Value, Date.Today))
            ExpertisApp.ExecuteTask(Of ObraTrabajoFacturacion.DatosGenerarVencimientos)(AddressOf ObraTrabajoFacturacion.GenerarVencimientosTaller, data)
            GridTallerAlquiler.UnCheckAllRecords()
            Me.Execute()
            ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

    Protected Overrides Sub DeleteHitosFacturacion()
        Dim dtMarcados As DataTable = GridVtos.CheckedRecords
        If Not dtMarcados Is Nothing Then
            Dim dr() As DataRow = dtMarcados.Select("Facturado<>0")
            If dr.Length = 0 Then
                ExpertisApp.ExecuteTask(Of String)(AddressOf ObraTrabajoFacturacion.DeleteVencimientosAlquiler, GridVtos.SaveServerChecks.ToString)
                GridVtos.UnCheckAllRecords()
                GridVtos.DeleteServerChecks()
                Me.Cursor = Cursors.Default
                ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Execute()
            Else
                ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

#Region " Facturacion "

    Protected Overrides Sub Facturacion()
        If GridVtos.CheckedRecordsCount > 0 Then
            If Not chkCondicionesCliente.Checked And Length(cbxTipoAgrupacion.Value) = 0 Then
                ExpertisApp.GenerateMessage("'Para poder facturar hay que seleccionar las Condiciones del Cliente o un tipo de agrupación.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            Else
                Dim dtMarcados As DataTable = GridVtos.CheckedRecords
                If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                    If ExpertisApp.GenerateMessage("El Cliente y el Artículo son datos necesarios para el proceso de Facturación. Aquellas líneas que no tengan estos datos, estén facturados o no tengan Fecha Vencimiento no serán incluidos en dicho proceso.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        dtMarcados = TratarLineaAFacturar(dtMarcados)
                        If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                            Dim TipoAgrupacion As Integer = IIf(Length(cbxTipoAgrupacion.Value) > 0, cbxTipoAgrupacion.Value, -1)

                            Dim DE As New BE.DataEngine
                            Dim IDVencimientos() As Object = MyBase.VencimientosAFacturar(dtMarcados)
                            Dim datos As New DataPrcFacturacionObras(IDVencimientos, AdvContador.Text, TipoAgrupacion, enumTipoFactura.tfObra, chkCalculoSeguros.Checked)
                            Dim Propuesta As ResultFacturacion = DE.RunProcess(GetType(PrcFacturacionObras), datos)
                            If Not IsNothing(Propuesta) Then
                                If Not Propuesta.PropuestaFacturas Is Nothing AndAlso Propuesta.PropuestaFacturas.Rows.Count > 0 Then
                                    Dim frm As New frmFacturacionProvisional
                                    Dim d As DialogResult = frm.AbrirFormulario(Propuesta.PropuestaFacturas)
                                    If d = DialogResult.OK Then
                                        Me.Cursor = Cursors.WaitCursor

                                        Dim datosAct As New DataPrcActualizarFactura(Propuesta, enumTipoFactura.tfObra)
                                        Dim rslt As ResultFacturacion = DE.RunProcess(GetType(PrcActualizarFactura), datosAct)
                                        TratarLog(rslt.Log, enumTipoDocumentoCreado.FacturaVenta, True, True)

                                        Me.Cursor = Cursors.Default
                                    Else
                                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                Else
                                    TratarLog(Propuesta.Log, enumTipoDocumentoCreado.FacturaVenta, True, True)
                                End If
                                GridVtos.UnCheckAllRecords()
                                Me.Execute()
                            Else
                                ExpertisApp.GenerateMessage("No se ha podido generar la Factura.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                    End If
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#End Region

#Region " Acciones Grids "

    Protected Overrides Sub AbrirObra(ByVal IDObra As Integer)
        AbrirMntoAlquiler(IDObra)
    End Sub

    Private Sub AbrirAlquiler()
        Select Case TabFacturacion.SelectedTab.Key
            Case TabPageHitos.Key
                AbrirMntoAlquiler(GridVtos.Value("IDObra"))
            Case TabPageAlquiler.Key
                AbrirMntoAlquiler(Nz(GridAlquiler.Value("IDObra"), 0))
            Case TabPageAlbaran.Key
                If GridAlbaran.Value("TipoMnto") = enumTipoObra.tpalquiler Then
                    AbrirMntoAlquiler(Nz(GridAlquiler.Value("IDObra"), 0))
                Else
                    ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", GridAlquiler.Value("IDObra")))
                End If
        End Select
    End Sub

    Private Sub AbrirAlbaran()
        Select Case TabFacturacion.SelectedTab.Key
            Case TabPageAlquiler.Key
                AbrirMntoAlbaranVenta(Nz(GridAlquiler.Value("IDAlbaran"), 0))
            Case TabPageAlbaran.Key
                AbrirMntoAlbaranVenta(Nz(GridAlbaran.Value("IDAlbaran"), 0))
            Case TabPageHitos.Key
                AbrirMntoAlbaranVenta(Nz(GridVtos.Value("IDAlbaranVentaOrigen"), 0))
        End Select
    End Sub

    Private Sub VerAlbaranRetorno()
        Select Case TabFacturacion.SelectedTab.Key
            Case TabPageAlquiler.Key
                AbrirMntoAlbaranVenta(Nz(GridAlquiler.Value("IDAlbaranRetorno"), 0))
            Case TabPageHitos.Key
                AbrirMntoAlbaranVenta(Nz(GridVtos.Value("IDAlbaranRetorno"), 0))
        End Select
    End Sub

#End Region

    Private Sub TabFacturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabFacturacion.Click
        ActiveExecuteActions()
        ActivateControls()
        Select Case TabFacturacion.SelectedTab.Key
            Case TabPageAlquiler.Key
                Me.CIPrimaryObject = GridAlquiler
                Me.RecordsState = RecordsState.Saved
            Case TabPageAlbaran.Key
                Me.CIPrimaryObject = GridAlbaran
            Case TabPageTallerAlquiler.Key
                Me.CIPrimaryObject = GridTallerAlquiler
        End Select
    End Sub

    Protected Overrides Sub ActiveExecuteActions()
        MyBase.ActiveExecuteActions()
        Me.ExecuteActions.Commands(cnPROPUESTACIERRE).Enabled = Janus.Windows.UI.InheritableBoolean.False
        Me.ExecuteActions.Commands(cnCALCULARVTOS).Enabled = Janus.Windows.UI.InheritableBoolean.False
        Select Case TabFacturacion.SelectedTab.Key
            Case TabPageAlquiler.Key
                Me.ExecuteActions.Commands(cnFACTURACIONRESPONSABLE).Enabled = Janus.Windows.UI.InheritableBoolean.True
                Me.ExecuteActions.Commands(cnGENERARVTOS).Enabled = Janus.Windows.UI.InheritableBoolean.True
                Me.ExecuteActions.Commands(cnPROPUESTACIERRE).Enabled = Janus.Windows.UI.InheritableBoolean.True
                Me.ExecuteActions.Commands(cnCALCULARVTOS).Enabled = Janus.Windows.UI.InheritableBoolean.True
            Case TabPageAlbaran.Key
                Me.ExecuteActions.Commands(cnFACTURACIONRESPONSABLE).Enabled = Janus.Windows.UI.InheritableBoolean.True
                Me.ExecuteActions.Commands(cnGENERARVTOS).Enabled = Janus.Windows.UI.InheritableBoolean.True
            Case TabPageTallerAlquiler.Key
                Me.ExecuteActions.Commands(cnFACTURACIONRESPONSABLE).Enabled = Janus.Windows.UI.InheritableBoolean.True
                Me.ExecuteActions.Commands(cnGENERARVTOS).Enabled = Janus.Windows.UI.InheritableBoolean.True
        End Select
    End Sub

    Private Sub ActivateControls()
        'chkCondicionesCliente.Location = New Point(chkCondicionesCliente.Location.X - 50, chkCondicionesCliente.Location.Y)
        pnlPeriodoFactura.Location = pnlEstado.Location
        With TabFacturacion
            lblTipoTrabajo.Visible = False : AdvTipoTrabajo.Visible = False
            lblSubTipoTrabajo.Visible = False : AdvSubTipoTrabajo.Visible = False
            AdvTrabajo.Visible = (.SelectedTab.Key <> TabPageTallerAlquiler.Key) : lblCodTrabajo.Visible = AdvTrabajo.Visible
            AdvIDCentroGestion.Visible = (.SelectedTab.Key <> TabPageTallerAlquiler.Key) : lblCentroGestion.Visible = AdvIDCentroGestion.Visible
            pnlEstadoOT.Visible = (.SelectedTab.Key = TabPageTallerAlquiler.Key)
            pnlTipoOT.Visible = pnlEstadoOT.Visible
            lblOTDesde.Visible = pnlEstadoOT.Visible : AdvOTDesde.Visible = pnlEstadoOT.Visible
            lblOTHasta.Visible = pnlEstadoOT.Visible : AdvOTHasta.Visible = pnlEstadoOT.Visible
            pnlPeriodoFactura.Visible = (.SelectedTab.Key = TabPageAlquiler.Key)
            pnlClienteEventual.Visible = (.SelectedTab.Key = TabPageAlquiler.Key)
            AdvIDArticulo.Visible = (.SelectedTab.Key <> TabPageHoras.Key Or .SelectedTab.Key = TabPageGastos.Key)
            lblArticulo.Visible = AdvIDArticulo.Visible
            pnlEstado.Visible = (Not pnlEstadoOT.Visible AndAlso Not pnlEstadoCertificacion.Visible AndAlso Not pnlPeriodoFactura.Visible)
            'Totales
            txtTotalMarcado.Visible = (.SelectedTab.Key <> TabPageAlquiler.Key) : lblTotalMarcado.Visible = txtTotalMarcado.Visible
            'Parametros
            pnlFechaVto.Visible = (.SelectedTab.Key = TabPageHoras.Key Or .SelectedTab.Key = TabPageGastos.Key Or .SelectedTab.Key = TabPageMateriales.Key Or .SelectedTab.Key = TabPageAlbaran.Key Or .SelectedTab.Key = TabPageTallerAlquiler.Key)
            pnlConfigFacturacion.Visible = Not pnlFechaVto.Visible
            pnlConfigAlquiler.Visible = (.SelectedTab.Key = TabPageAlquiler.Key)
            pnlOperario.Visible = (.SelectedTab.Key = TabPageHoras.Key Or .SelectedTab.Key = TabPageGastos.Key)
            pnlAlbaran.Visible = (.SelectedTab.Key = TabPageAlbaran.Key)
        End With
        chkCalculoSeguros.Visible = Not pnlConfigAlquiler.Visible
        chkCondicionesCliente.Visible = chkCalculoSeguros.Visible
        lblTipoAgrupacion.Visible = chkCalculoSeguros.Visible
        cbxTipoAgrupacion.Visible = chkCalculoSeguros.Visible

        If pnlConfigAlquiler.Visible And Length(cbxFechaCalculo.Value) = 0 Then cbxFechaCalculo.Value = Date.Today
    End Sub

#Region " Grids "

    Protected Overrides Sub GridVtos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs)
        If e.Row.RowType = RowType.Record Then
            Select Case CType(e.Row.Cells("TipoFactura").Value, enumotfTipoFactura)
                Case enumotfTipoFactura.otfAlquiler
                    e.Row.RowStyle = GridVtos.FormatStyles("AlquilerFormatStyle")
                Case enumotfTipoFactura.otfAlbaranes
                    e.Row.RowStyle = GridVtos.FormatStyles("AlbaranFormatStyle")
                Case enumotfTipoFactura.otfOrdenesTrabajo
                    e.Row.RowStyle = GridVtos.FormatStyles("TallerFormatStyle")
            End Select
        End If
    End Sub

    Private Sub GridVtos_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridVtos.EditingCell
        Select Case GridVtos.Columns(e.Column.Index).Key
            Case "Expertis.Check"
                mIDOTHitos = Nz(GridVtos.Value("IDOT"), 0)
                mIDVencimiento = GridVtos.Value("IDVencimiento")
                mIDMaterial = Nz(GridVtos.Value("IDLineaMaterial"), 0)
            Case "TipoFactura"
                e.Cancel = True
        End Select
    End Sub

    Private Sub GridAlquiler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridAlquiler.Click
        With GridAlquiler
            Dim hit As GridArea = .HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "Seguimiento"
                            Dim frm As New FormularioTexto
                            frm.Texto = .Value("Seguimiento") & String.Empty
                            frm.SoloLectura = True
                            frm.ShowDialog()
                    End Select
                End If
            End If
        End With
    End Sub

    Protected Sub GridVtosModGastos_RecordChecked(ByVal sender As Object, ByVal e As Engine.UI.CheckedEventArgs) Handles GridVtos.RecordChecked, GridMod.RecordChecked, GridGastos.RecordChecked
        If TabFacturacion.SelectedTab.Key = TabPageHitos.Key Then
            If Length(e.Row.DataRow("IDLineaMaterial")) > 0 Then
                If mIDMaterial = e.Row.DataRow("IDLineaMaterial") And mIDVencimiento = e.Row.DataRow("IDVencimiento") Then
                    Dim jFilter As New Janus.Windows.GridEX.GridEXFilterCondition
                    jFilter.Clear()
                    jFilter.AddCondition()
                    jFilter.Conditions(0).Column = GridVtos.Columns("IDLineaMaterial")
                    jFilter.Conditions(0).ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal
                    jFilter.Conditions(0).Value1 = e.Row.DataRow("IDLineaMaterial")

                    jFilter.AddCondition()
                    jFilter.Conditions(1).Column = GridVtos.Columns("Facturado")
                    jFilter.Conditions(1).ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal
                    jFilter.Conditions(1).Value1 = e.Row.DataRow("Facturado")

                    jFilter.AddCondition()
                    jFilter.Conditions(2).Column = GridVtos.Columns("IDVencimiento")
                    jFilter.Conditions(2).ConditionOperator = Janus.Windows.GridEX.ConditionOperator.NotEqual
                    jFilter.Conditions(2).Value1 = mIDVencimiento

                    GridVtos.FindAll(jFilter)

                    If e.CheckState = CheckStates.Checked Then
                        GridVtos.CheckRecord()
                    Else
                        GridVtos.UnCheckRecord()
                    End If

                    GridVtos.SelectedItems.Clear()
                End If
            ElseIf Length(e.Row.DataRow("IDOT")) > 0 Then
                If mIDOTHitos = e.Row.DataRow("IDOT") And mIDVencimiento = e.Row.DataRow("IDVencimiento") Then
                    Dim jFilter As New Janus.Windows.GridEX.GridEXFilterCondition
                    jFilter.Clear()

                    jFilter.AddCondition()
                    jFilter.Conditions(0).Column = GridVtos.Columns("IDOT")
                    jFilter.Conditions(0).ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal
                    jFilter.Conditions(0).Value1 = e.Row.DataRow("IDOT")

                    jFilter.AddCondition()
                    jFilter.Conditions(1).Column = GridVtos.Columns("Facturado")
                    jFilter.Conditions(1).ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal
                    jFilter.Conditions(1).Value1 = e.Row.DataRow("Facturado")

                    jFilter.AddCondition()
                    jFilter.Conditions(2).Column = GridVtos.Columns("IDVencimiento")
                    jFilter.Conditions(2).ConditionOperator = Janus.Windows.GridEX.ConditionOperator.NotEqual
                    jFilter.Conditions(2).Value1 = mIDVencimiento

                    mIDOTHitos = 0
                    GridVtos.FindAll(jFilter)
                    If e.CheckState = CheckStates.Checked Then
                        GridVtos.CheckRecord()
                    Else
                        GridVtos.UnCheckRecord()
                    End If

                    GridVtos.SelectedItems.Clear()
                End If
            End If
        End If
        mIDMaterial = 0
        mIDVencimiento = 0
        mIDOTHitos = 0
    End Sub

    Private Sub GridTaller_RecordChecked(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckedEventArgs) Handles GridTallerAlquiler.RecordChecked
        If mIDOT = e.Row.DataRow("IDOT") Then
            Dim jFilter As New Janus.Windows.GridEX.GridEXFilterCondition
            jFilter.Clear()

            jFilter.AddCondition()
            jFilter.Conditions(0).Column = GridTallerAlquiler.Columns("IDOT")
            jFilter.Conditions(0).ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal
            jFilter.Conditions(0).Value1 = e.Row.DataRow("IDOT")

            mIDOT = 0
            GridTallerAlquiler.FindAll(jFilter)
            If e.CheckState = CheckStates.Checked Then
                GridTallerAlquiler.CheckRecord()
            Else
                GridTallerAlquiler.UnCheckRecord()
            End If

            GridTallerAlquiler.SelectedItems.Clear()
        End If
    End Sub

    Private Sub GridTaller_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridTallerAlquiler.EditingCell
        Select Case GridTallerAlquiler.Columns(e.Column.Index).Key
            Case "Expertis.Check"
                mIDOT = GridTallerAlquiler.Value(GridTallerAlquiler.Columns("IDOT").Index)
        End Select
    End Sub

#End Region

#Region " QueryExecute "

    Private Sub CIFacturacion_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        cbxPeriodoFacturacion.Value = String.Empty
        chkCalculoSeguros.Checked = True
    End Sub

    Private Sub CIFacturacion_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        Select Case TabFacturacion.SelectedTab.Key
            Case TabPageAlquiler.Key
                txtTotal.Value = GridAlquiler.GetTotal(GridAlquiler.Columns("Importe"), AggregateFunction.Sum)
            Case TabPageTallerAlquiler.Key
                txtTotal.Value = GridTallerAlquiler.GetTotal(GridTallerAlquiler.Columns("Importe"), AggregateFunction.Sum)
        End Select
    End Sub

    Private Sub CIFacturacion_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If TabFacturacion.SelectedTab.Key <> TabPageAlquiler.Key Then
            e.Cancel = False
            If Length(AdvObraDesde.Value) = 0 And Length(AdvObraHasta.Value) = 0 And Length(cbxFechaDesde.Value) = 0 And Length(cbxFechaHasta.Value) = 0 And _
                Length(AdvClienteDesde.Value) = 0 And Length(AdvClienteHasta.Value) = 0 And Length(AdvIDCentroGestion.Value) = 0 Then
                If ExpertisApp.GenerateMessage("Se va a lanzar la consulta sin aplicar filtros. Esto puede que retarde la obtención de información. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    e.Cancel = True
                End If
            Else
                e.Cancel = ValidarFiltros()
            End If
        End If

        If Not e.Cancel Then
            e.Filter.InnerFilter.Clear()
            Select Case TabFacturacion.SelectedTab.Key
                Case TabPageAlquiler.Key
                    e.Cancel = True
                    Dim f As New Filter
                    If Length(AdvObraDesde.Value) > 0 Then f.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
                    If Length(AdvObraHasta.Value) > 0 Then f.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
                    If Length(AdvClienteDesde.Value) > 0 Then f.Add("IDCliente", FilterOperator.GreaterThanOrEqual, AdvClienteDesde.Value, FilterType.String)
                    If Length(AdvClienteHasta.Value) > 0 Then f.Add("IDCliente", FilterOperator.LessThanOrEqual, AdvClienteHasta.Value, FilterType.String)
                    'David
                    If Length(AdvTipoArticulo.Value) > 0 Then f.Add("IDTipo", FilterOperator.Equal, AdvTipoArticulo.Value, FilterType.String)
                    'David
                    If Length(AdvTrabajo.Value) > 0 Then f.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
                    If Length(AdvIDCentroGestion.Value) > 0 Then f.Add("IDCentroGestion", FilterOperator.Equal, AdvIDCentroGestion.Value, FilterType.String)
                    If Length(AdvIDArticulo.Value) > 0 Then f.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)
                    If Length(cbxPeriodoFacturacion.Value) > 0 Then f.Add("PeriodoFacturacion", FilterOperator.Equal, cbxPeriodoFacturacion.Value, FilterType.Numeric)
                    If cbxClienteEventual.Value <> enumBoolean.Todos AndAlso Length(cbxClienteEventual.Value) > 0 Then
                        f.Add("ClienteGenerico", FilterOperator.Equal, cbxClienteEventual.Value, FilterType.Boolean)
                    End If
                    Dim dvCalculo As New DataView(mdtCalculo)
                    dvCalculo.RowFilter = f.Compose(New AdoFilterComposer)

                    GridAlquiler.DataSource = dvCalculo
                Case TabPageTallerAlquiler.Key
                    e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
                    e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
                    e.Filter.Add("IDCliente", FilterOperator.GreaterThanOrEqual, AdvClienteDesde.Value, FilterType.String)
                    e.Filter.Add("IDCliente", FilterOperator.LessThanOrEqual, AdvClienteHasta.Value, FilterType.String)
                    e.Filter.Add("IDOT", FilterOperator.GreaterThanOrEqual, AdvOTDesde.Value, FilterType.Numeric)
                    e.Filter.Add("IDOT", FilterOperator.LessThanOrEqual, AdvOTHasta.Value, FilterType.Numeric)
                    e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)
                    e.Filter.Add("EstadoFactura", FilterOperator.Equal, cbxEstadoOT.Value, FilterType.Numeric)
                    e.Filter.Add("Tipo", FilterOperator.Equal, cbxTipoOT.Value, FilterType.Numeric)
                    e.Filter.Add("FechaCierre", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
                    e.Filter.Add("FechaCierre", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)

                    e.Filter.Add("FechaDesdeAlquiler", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
                    e.Filter.Add("FechaHastaAlquiler", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
                Case TabPageAlbaran.Key
                    e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
                    e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
                    e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
                    e.Filter.Add("IDCliente", FilterOperator.GreaterThanOrEqual, AdvClienteDesde.Value, FilterType.String)
                    e.Filter.Add("IDCliente", FilterOperator.LessThanOrEqual, AdvClienteHasta.Value, FilterType.String)
                    e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)
                    e.Filter.Add("IDCentroGestion", FilterOperator.Equal, AdvIDCentroGestion.Value, FilterType.String)
                    e.Filter.Add("IDAlbaran", FilterOperator.Equal, advIDAlbaran.Value, FilterType.Numeric)
                    e.Filter.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
                    e.Filter.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
                    If cbxEstado.Value <> enumotfEstadoCIVtos.otfvTodos Then
                        e.Filter.Add("EstadoFactura", FilterOperator.Equal, cbxEstado.Value, FilterType.Numeric)
                    End If
                Case TabPageHitos.Key, TabPageHoras.Key, TabPageGastos.Key, TabPageMateriales.Key
                    Dim f As New Filter(FilterUnionOperator.Or)
                    f.Add("TipoMnto", FilterOperator.Equal, enumTipoObra.tpalquiler, FilterType.Numeric)
                    'David 26/10
                    If Length(AdvTipoArticulo.Value) > 0 Then f.Add("IDTipo", FilterOperator.Equal, AdvTipoArticulo.Value, FilterType.String)
                    If Length(AdvFamiliaArticulo.Value) > 0 Then f.Add("IDFamilia", FilterOperator.Equal, AdvFamiliaArticulo.Value, FilterType.String)
                    If Length(AdvAlqVen.Value) > 0 Then f.Add("DescFacturacion", FilterOperator.Equal, AdvAlqVen.Value, FilterType.String)
                    'David 26/10
                    If TabFacturacion.SelectedTab.Key = TabPageHitos.Key Then
                        f.Add("TipoFactura", enumotfTipoFactura.otfAlbaranes)
                        e.Filter.Add("TipoFactura", FilterOperator.Equal, cbxTipoFactura.Value, FilterType.Numeric)
                        e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)
                    End If
                    e.Filter.Add(f)

                    e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
                    e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
                    e.Filter.Add("IDCliente", FilterOperator.GreaterThanOrEqual, AdvClienteDesde.Value, FilterType.String)
                    e.Filter.Add("IDCliente", FilterOperator.LessThanOrEqual, AdvClienteHasta.Value, FilterType.String)
                    'David Velasco 26/10
                    e.Filter.Add("IDTipo", FilterOperator.Equal, AdvTipoArticulo.Value, FilterType.String)
                    e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvFamiliaArticulo.Value, FilterType.String)
                    e.Filter.Add("DescFacturacion", FilterOperator.Equal, AdvAlqVen.Value, FilterType.String)
                    'David-Fin
                    e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
                    e.Filter.Add("IDTipoTrabajo", FilterOperator.Equal, AdvTipoTrabajo.Value, FilterType.String)
                    e.Filter.Add("IDSubTipoTrabajo", FilterOperator.Equal, AdvSubTipoTrabajo.Value, FilterType.String)
                    e.Filter.Add("IDCentroGestion", FilterOperator.Equal, AdvIDCentroGestion.Value, FilterType.String)
                    e.Filter.Add("AgrupFacturaObra", FilterOperator.Equal, cbxAgrupFactura.Value, FilterType.Numeric)
                    If cbxEstado.Value <> enumotfEstadoCIVtos.otfvTodos Then
                        e.Filter.Add(New BooleanFilterItem("Facturado", CBool(cbxEstado.Value)))
                    End If
                    e.Filter.Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
                    e.Filter.Add("FechaVencimiento", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
                    If TabFacturacion.SelectedTab.Key = TabPageHoras.Key Or TabFacturacion.SelectedTab.Key = TabPageGastos.Key Then
                        e.Filter.Add("IDOperario", FilterOperator.Equal, AdvIDOperario.Value, FilterType.Numeric)
                    End If
            End Select
        End If
    End Sub

    Private Function ValidarFiltros() As Boolean
        Dim strFiltrosCampos As String = String.Empty
        Dim blnCancel As Boolean

        If (Length(AdvObraDesde.Value) > 0 And Length(AdvObraHasta.Value) = 0) Or (Length(AdvObraDesde.Value) = 0 And Length(AdvObraHasta.Value) > 0) Then
            strFiltrosCampos = strFiltrosCampos & "Alquiler"
            blnCancel = True
        End If
        If (Length(cbxFechaDesde.Value) > 0 And Length(cbxFechaHasta.Value) = 0) Or (Length(cbxFechaDesde.Value) = 0 And Length(cbxFechaHasta.Value) > 0) Then
            If Len(strFiltrosCampos) > 0 Then strFiltrosCampos = strFiltrosCampos & ","
            strFiltrosCampos = strFiltrosCampos & "Fecha Vencimiento"
            blnCancel = True
        End If

        If (Length(AdvClienteDesde.Value) > 0 And Length(AdvClienteHasta.Value) = 0) Or (Length(AdvClienteDesde.Value) = 0 And Length(AdvClienteHasta.Value) > 0) Then
            If Len(strFiltrosCampos) > 0 Then strFiltrosCampos = strFiltrosCampos & ","
            strFiltrosCampos = strFiltrosCampos & "Cliente"
            blnCancel = True
        End If

        If blnCancel Then
            ExpertisApp.GenerateMessage("Para usar los filtros de {0} tienen que rellenarse tanto el Desde como el Hasta.", MessageBoxButtons.OK, MessageBoxIcon.Information, strFiltrosCampos)
        End If

        Return blnCancel
    End Function

#End Region

    Private Sub AdvObraDesde_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvObraDesde.SelectionChanged
        txtDiaFacturacion.Text = Nz(e.Selected.Rows(0)("DiaFacturacion"), String.Empty)
    End Sub

    Private Sub AdvObraHasta_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvObraHasta.SelectionChanged
        If Nz(AdvObraHasta.Value) <> Nz(AdvObraDesde.Value) Then txtDiaFacturacion.Text = String.Empty
    End Sub

    Private Sub cbxFechaCalculo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaCalculo.ValueChanged
        If Not chkTenerEnCuenta.Checked Then
            If CType(cbxFechaCalculo.Value, Date).Day = DateTime.DaysInMonth(Year(cbxFechaCalculo.Value), CDate(cbxFechaCalculo.Value).Month) Then
                txtDiaFacturacion.Text = String.Empty
            Else
                txtDiaFacturacion.Text = CType(cbxFechaCalculo.Value, Date).Day
            End If
        End If
    End Sub

#Region " Informes "

    Private Sub CIFacturacion_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects

        If e.Alias = "FVPROALQ" Then
            If Nz(chkCondicionesCliente.Checked, False) Then
                e.Formulas.Item("CondicionesCliente").Text = 1
            Else
                e.Formulas.Item("CondicionesCliente").Text = 0
            End If
            e.Formulas.Item("TipoAgrupacion").Text = cbxTipoAgrupacion.Value & String.Empty

            'If Len(FwITipoOrden.Value & String.Empty) > 0 Then
            '    Select Case FwITipoOrden.Value
            '        Case 1
            '            objReport.SortFields.Add("codTrabajo", crAscendingOrder)

            '        Case 2
            '            objReport.SortFields.Add("FechaDesdeAlquiler", crAscendingOrder)

            '        Case 3
            '            objReport.SortFields.Add("Desctrabajo", crAscendingOrder)
            '        Case 4
            '            objReport.SortFields.Add("IdAlbaran", crAscendingOrder)
            '        Case 5
            '            objReport.SortFields.Add("IdObra", crAscendingOrder)
            '    End Select
            'End If

            'objReport.SortFields.Add("IDVencimiento", crAscendingOrder)

        End If
    End Sub

    Private Sub CIFacturacion_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        If e.Alias = "FVPROALQ" Then
            Me.Cursor = Cursors.WaitCursor
            If GridVtos.CheckedRecordsCount > 0 Then
                Dim TipoAgrupacion As Integer = enummcAgrupFacturaObra.mcSinAgrupar
                If Not IsNothing(cbxTipoAgrupacion.Value) Then
                    TipoAgrupacion = cbxTipoAgrupacion.Value
                End If
                Dim data As New CalculoFacturacion.datosInformeFacturaProForma(GridVtos.SaveServerChecks(), chkCondicionesCliente.Checked, TipoAgrupacion)
                e.DataSource = ExpertisApp.ExecuteTask(Of CalculoFacturacion.datosInformeFacturaProForma, DataTable)(AddressOf CalculoFacturacion.ObtenerInformeFacturaProForma, data)
            Else
                e.Cancel = True
                ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CIFacturacion_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        If e.Alias = "IVTOG" Then
            e.RecordSelectionFormula = ConsultaCrystal()
        ElseIf e.Alias = "LOFAC" Then
            e.RecordSelectionFormula = ConsultaCrystal()
        End If
    End Sub

    Private Function ConsultaCrystal() As String
        Dim f As New Filter
        f.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value)
        f.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value)
        f.Add("IDCliente", FilterOperator.GreaterThanOrEqual, AdvClienteDesde.Value)
        f.Add("IDCliente", FilterOperator.LessThanOrEqual, AdvClienteHasta.Value)
        f.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value)
        f.Add("IDTipoTrabajo", FilterOperator.Equal, AdvTipoTrabajo.Value)
        f.Add("IDSubTipoTrabajo", FilterOperator.Equal, AdvSubTipoTrabajo.Value)
        f.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value)
        f.Add("IDCentroGesion", FilterOperator.Equal, AdvIDCentroGestion.Value)
        Select Case TabFacturacion.SelectedTab.Key
            Case TabPageHitos.Key, TabPageHoras.Key, TabPageGastos.Key
                f.Add("AgrupFacturaObra", FilterOperator.Equal, cbxAgrupFactura.Value)
                f.Add("TipoFactura", FilterOperator.Equal, cbxTipoFactura.Value)
                If cbxEstado.Value <> enumotfEstadoCIVtos.otfvTodos Then
                    Select Case CType(cbxEstado.Value, enumotfEstadoCIVtos)
                        Case enumotfEstadoCIVtos.otfvFacturado
                            f.Add("Facturado", FilterOperator.Equal, True)
                        Case enumotfEstadoCIVtos.otfvNoFacturado
                            f.Add("Facturado", FilterOperator.Equal, False)
                    End Select
                End If
                f.Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value)
                f.Add("FechaVencimiento", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value)
                If TabFacturacion.SelectedTab.Key = TabPageHoras.Key Or TabFacturacion.SelectedTab.Key = TabPageGastos.Key Then
                    f.Add("IDOperario", FilterOperator.Equal, AdvIDOperario.Value)
                End If
            Case TabPageCertificacion.Key
                f.Add("Estado", FilterOperator.Equal, cbxEstadoCertificacion.Value)
                f.Add("FechaInicio", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value)
                f.Add("FechaInicio", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value)
        End Select

        Return f.Compose(New AdoFilterComposer)
    End Function

#End Region

    Private Sub CIFacturacion_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ActivateControls()
    End Sub

End Class
