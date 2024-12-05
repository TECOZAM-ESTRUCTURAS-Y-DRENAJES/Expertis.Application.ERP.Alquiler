Imports System.Text

Module General

#Region " Abrir formularios "

    Public Const cnABRIRALBARANVENTA As String = "Abrir Albarán Venta Alquiler"
    Public Const cnABRIRALQUILER As String = "Abrir Alquiler"
    Public Const cnABRIRORDENSERVICIO As String = "Abrir O. Servicio"
    Public Const cnABRRIRARTICULO As String = "Abrir Artículo"
    Public Const cnABRRIRACTIVO As String = "Abrir Activo"
    Public Const cnABRIRCLIENTE As String = "Abrir Cliente"
    Public Const cnCALENDARIO As String = "Ver Calendario Alquiler"

    Public Sub AbrirMntoFacturasVenta(ByVal IDFactura As Integer)
        ExpertisApp.OpenForm("MFACTV", New NumberFilterItem("IDFactura", IDFactura))
    End Sub

    Public Sub AbrirMntoAlquiler(ByVal IDObra As Integer)
        ExpertisApp.OpenForm("OBALQUILER", New NumberFilterItem("IDObra", IDObra))
    End Sub

    Public Sub AbrirOrdenServicio(ByVal IDTrabajo As Integer, ByVal IDObra As Integer)
        Dim HT As New Hashtable
        HT("VerTrabajo") = True
        HT("IDTrabajo") = IDTrabajo
        ExpertisApp.OpenForm("OBALQUILER", New NumberFilterItem("IDObra", IDObra), HT)
    End Sub

    Public Sub AbrirMntoAlbaranVenta(ByVal IDAlbaran As Integer)
        ExpertisApp.OpenForm("MALBALQ", New NumberFilterItem("IDAlbaran", IDAlbaran))
    End Sub

    Public Sub AbrirMntoArticulo(ByVal IDMaterial As String)
        ExpertisApp.OpenForm("MARTICULO", New StringFilterItem("IDArticulo", IDMaterial))
    End Sub

    Public Sub AbrirMntoAbrirActivo(ByVal IDActivo As String)
        ExpertisApp.OpenForm("MACT", New StringFilterItem("IDActivo", IDActivo))
    End Sub

    Public Sub AbrirMntoCliente(ByVal IDCliente As String)
        ExpertisApp.OpenForm("MCLIENTE", New StringFilterItem("IDCliente", IDCliente))
    End Sub

    Public Sub AbrirMntoCalendarioAlquiler(ByVal IDObra As Integer)
        ExpertisApp.OpenForm("CALOBRAALQ", New NumberFilterItem("IDObra", IDObra))
    End Sub

#End Region

#Region " Genera Albarán "
    Private Delegate Function EnviarCorreoPrueba(ByVal data As SmtpServerInfo) As LogProcess

    Public Enum enumTipoAlbaran
        Albaran = 0
        AlbaranSalidaRetorno = 1
    End Enum

    Public Sub GenerarAlbaran(ByVal drTrabajos As DataRow, ByVal oCursor As Cursor, _
                              Optional ByVal Tipo As enumTipoAlbaran = enumTipoAlbaran.Albaran)

        If Not IsNothing(drTrabajos) Then
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDTrabajo", drTrabajos("IDTrabajo")))
            f.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, enumomEstado.omServido))
            f.Add(New StringFilterItem("IDEstadoActivo", FilterOperator.NotEqual, NegocioGeneral.ESTADOACTIVO_RESERVADA))
            f.Add(New NumberFilterItem("Disponible", 0))

            Dim de As New BE.DataEngine
            Dim dtActivos As DataTable = de.Filter("vAlquilerExpedicionSituacionActivos", f, , "Estado")
            If Not IsNothing(dtActivos) AndAlso dtActivos.Rows.Count > 0 Then
                Dim strMaquinasError As String = String.Empty
                For Each drActivos As DataRow In dtActivos.Rows
                    If Len(strMaquinasError) > 0 Then strMaquinasError = strMaquinasError & ","
                    strMaquinasError = strMaquinasError & drActivos("IDActivo")
                Next
                If dtActivos.Rows.Count > 1 Then
                    ExpertisApp.GenerateMessage("No se puede realizar el proceso porque los activos | no están. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, strMaquinasError)
                Else
                    ExpertisApp.GenerateMessage("No se puede realizar el proceso porque el activo | no está.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, strMaquinasError)
                End If
            Else
                f.Clear()
                f.Add(New NumberFilterItem("IDTrabajo", drTrabajos("IDTrabajo")))
                f.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, enumomEstado.omServido))
                f.Add(New NumberFilterItem("TipoFacturacion", enumomATipoFacturacionAlquiler.omAPorExpedicion))
                Dim dtNSerie As DataTable = de.Filter("vAlquilerExpedicionNSerieObligatorio", f)
                Dim blnCancel As Boolean
                If Not IsNothing(dtNSerie) AndAlso dtNSerie.Rows.Count > 0 Then
                    If ExpertisApp.GenerateMessage("Hay Activos cuyo Tipo Facturación sea Por Expedición.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                        blnCancel = True
                    End If
                End If
                If Not blnCancel Then
                    If ExpertisApp.GenerateMessage("Se va a generar el Albarán de la Orden de Servicio. ¿Desea Continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        f.Clear()
                        f.Add(New NumberFilterItem("IDTrabajo", drTrabajos("IDTrabajo")))
                        f.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, enumomEstado.omServido))
                        Dim filterOR As New Filter(FilterUnionOperator.Or)

                        Dim dtExpedir As DataTable = de.Filter("vAlquilerCIExpedirMateriales", f)
                        'David Velasco 14/06/22
                        'Recorro la tabla y si hay alguna fila que tenga de cantidad 0, exit sub
                        Dim conta As Integer = 0
                        Try
                            For Each dr As DataRow In dtExpedir.Rows
                                If dtExpedir.Rows(conta)("QAlbaran") = 0 Then
                                    MsgBox("El articulo " & dtExpedir.Rows(conta)("IDMaterial").ToString & " tiene de cantidad 0. Modificalo para generar albaran.")
                                    Exit Sub
                                End If
                                conta += 1
                            Next
                        Catch ex As Exception

                        End Try
                        'David Velasco 14/06/22
                        If Not IsNothing(dtExpedir) AndAlso dtExpedir.Rows.Count > 0 Then
                            If Tipo = enumTipoAlbaran.Albaran Then
                                GenerarAlbaranSalida(dtExpedir, drTrabajos("IDTrabajo"), oCursor)
                            Else
                                GenerarAlbaranSalidaRetorno(dtExpedir, drTrabajos("IDTrabajo"), oCursor)
                            End If
                        Else
                            ExpertisApp.GenerateMessage("No hay líneas para generar el Albarán.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub GenerarAlbaranSalida(ByVal dtExpedir As DataTable, ByVal IDTrabajo As Integer, ByVal oCursor As Cursor)
        Dim frmAC As New frmDatosAuxExpedicion
        Dim d As New frmDatosAuxExpedicion.DatosContadorConductor
        d = frmAC.AbrirFormulario(dtExpedir, True)
        If d.Ok = DialogResult.OK Then
            Dim dtContadores As DataTable = d.dtContadores
            Dim dtConductores As DataTable = d.dtConductores
            Dim dtmFecha As Date = d.dtmFechaInicio
            Dim strHora As String = d.strHoraInicio

            Dim aExpedir(-1) As CrearAlbaranVentaInfo
            aExpedir = ValidaLineasMaterial(dtExpedir, IDTrabajo, dtmFecha, strHora)
            If Not IsNothing(aExpedir) AndAlso aExpedir.Length > 0 Then
                Dim dc As Contador.DefaultCounter = ExpertisApp.ExecuteTask(Of String, Contador.DefaultCounter)(AddressOf Contador.GetDefaultCounterValue, GetType(AlbaranVentaCabecera).Name)

                Dim data As New DataPrcAlbaranar(aExpedir, dc.CounterID, , New Parametro().TipoAlbaranDeDeposito, enumTipoExpedicion.teAlquiler)
                Dim Propuesta As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                If Not IsNothing(Propuesta) Then
                    If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                        Dim frm As New frmAlbaranProvisional
                        Dim dr As DialogResult = frm.AbrirFormulario(Propuesta.PropuestaAlbaranes)
                        If dr = DialogResult.OK Then
                            oCursor = Cursors.WaitCursor

                            Dim datosAct As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                            datosAct.Conductores = dtConductores
                            datosAct.Contadores = dtContadores
                            datosAct.Retornos = False

                            Dim rslt As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquiler), datosAct)

                            'David Velasco 24/01/23
                            'Realiza cambios de los activos en los almacenes con fecha + historico de movimientos
                            Dim nalbaran As String
                            nalbaran = rslt.PropuestaAlbaranes.Rows(0)("NAlbaran")
                            seguimientoActivos(dtExpedir, nalbaran)

                            'David V. 14/02/2023
                            'Pregunta yes no si mandar un correo a miguel/raquel/david
                            'Si esta por debajo del stock minimo
                            mandaCorreoStockMinimo(dtExpedir)


                            TratarLog(rslt.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True, rslt.StockUpdateData)
                            oCursor = Cursors.Default
                        Else
                            ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        TratarLog(Propuesta.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                    End If
                Else
                    ExpertisApp.GenerateMessage("No se ha podido generar el Albarán.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

    Public Sub mandaCorreoStockMinimo(ByVal dtMovimientos As DataTable)
        Dim bandera As Boolean = False
        Dim dtArtStockAlmacen As New DataTable
        Dim dtArticulo As New DataTable
        Dim f As New Filter
        Dim builder As New StringBuilder

        For Each dr As DataRow In dtMovimientos.Rows
            f.Add("IDArticulo", FilterOperator.Equal, dr("IDMaterial"))
            dtArticulo = New BE.DataEngine().Filter("tbMaestroArticulo", f)
            f.Add("IDAlmacen", FilterOperator.Equal, dr("IDAlmacen"))
            dtArtStockAlmacen = New BE.DataEngine().Filter("tbMaestroArticuloAlmacen", f)

            'Si el stock - cantidad es menor o igual que stockminimo, mandar correo
            'Lo meto en un try porque la mayoria de articulos tiene el stockminimo a null
            Try
                If CDbl(dtArtStockAlmacen.Rows(0)("StockFisico")) < CDbl(dtArticulo.Rows(0)("StockMinimo")) Then
                    bandera = True
                    builder.AppendLine("El articulo " & dr("IDMaterial") & "= " & dtArticulo.Rows(0)("DescArticulo") & " está por debajo del stock minimo fijado.")
                End If
            Catch ex As Exception
            End Try
            f.Clear()
            dtArtStockAlmacen.Clear()
            dtArticulo.Clear()
        Next

        If bandera = True Then
            enviarCorreoStockMinimo(builder.ToString)
            'MsgBox(builder.ToString)
        End If
    End Sub
    Public Sub enviarCorreoStockMinimo(ByVal cuerpoCorreo As String)
        Dim ParamInfo As New Business.General.SmtpServerInfo
        ParamInfo.SmtpServerName = "smtp.tecozam.com"
        ParamInfo.SmtpServerPort = "587"
        ParamInfo.UseSSL = False
        ParamInfo.UserMail = "jaime.moran@tecozam.com"
        ParamInfo.Cuerpo = cuerpoCorreo
        ParamInfo.UserName = "jaime.moran@tecozam.com"
        ParamInfo.UserPassword = "MoJai.4321"
        Dim StrMsg As String = "El envío artículos con stocks mínimo se está realizando."
        Dim StrNomForm As String = "Enviando correo..."
        Dim oFrmProc As New ERP.CommonClasses.FrmProgresoProceso


        Dim StartDelegate As New EnviarCorreoPrueba(AddressOf Correos.EnviarMailTest)
        Dim LogPrc As LogProcess = oFrmProc.Start(StartDelegate, New Object() {ParamInfo}, StrMsg, StrNomForm)

        'If Not LogPrc Is Nothing AndAlso (LogPrc.CreatedElements.Length > 0 OrElse LogPrc.Errors.Length > 0) Then
        '    Correos.TratarMailLog(LogPrc)
        'End If

    End Sub
    Public Sub seguimientoActivos(ByVal dtExpedir As DataTable, ByVal nalbaran As String)
        Dim fechaDocumento As String
        Dim idAlmacenOrigen As String
        Dim idAlmacenDestino As String

        fechaDocumento = dtExpedir.Rows(0)("FechaEntrega")
        idAlmacenDestino = dtExpedir.Rows(0)("IDAlmacenDestino")
        idAlmacenOrigen = dtExpedir.Rows(0)("IDAlmacen")
        'Seguimiento articulos con nº serie
        Dim tbArticulos As DataTable
        Dim f As New Filter(FilterUnionOperator.Or)
        For Each fila As DataRow In dtExpedir.Rows
            f.Add("IDArticulo", fila("IDMaterial"))
        Next

        tbArticulos = New BE.DataEngine().Filter("vControlArticulosNSerie", f)
        If tbArticulos.Rows.Count <> 0 Then

            Dim frmSegNSeries As New frmSeguimientoNumeroSerie
            frmSegNSeries.filtro = f
            frmSegNSeries.fechaDoc = fechaDocumento
            frmSegNSeries.idalmacen = idAlmacenDestino
            frmSegNSeries.idalmacenorigen = idAlmacenOrigen
            frmSegNSeries.nalbaran = nalbaran
            frmSegNSeries.ShowDialog()
        End If
    End Sub
    Public Function AlbaranesGenerados(ByVal log As LogProcess) As Integer()
        Dim Ns(-1) As Integer
        Dim FirstID As String = String.Empty
        For Each e As CreateElement In log.CreatedElements
            ReDim Preserve Ns(UBound(Ns) + 1)
            Ns(UBound(Ns)) = e.IDElement
        Next

        Return Ns
    End Function

    Public Function ListadoAlbaranesGenerados(ByVal log As LogProcess) As String
        Dim Albaranes As String = String.Empty
        For Each Element As CreateElement In log.CreatedElements
            If Albaranes.Length > 0 Then Albaranes &= ", "
            Albaranes &= Element.NElement
        Next

        Return Albaranes
    End Function

    Private Sub GenerarAlbaranSalidaRetorno(ByVal dtExpedir As DataTable, ByVal IDTrabajo As Integer, ByVal oCursor As Cursor)
        Dim dtmFechaEntrega As Date
        If Not ControlFechasEntrega(dtExpedir, dtmFechaEntrega) Then
            Dim frmDatosAux As New frmDatosAuxSalidaRetorno
            Dim d As New frmDatosAuxSalidaRetorno.DatosSalidaRetorno
            d = frmDatosAux.AbrirFormulario(dtExpedir, dtmFechaEntrega)
            If d.Ok = DialogResult.OK Then
                Dim dtContadores As DataTable = d.dtContadores
                Dim dtConductores As DataTable = d.dtConductores
                Dim dtEstadoActivo As DataTable = d.dtEstadoActivo
                Dim dtmFechaSalida As Date = d.dtmFechaSalida
                Dim strHoraSalida As String = d.strHoraSalida
                Dim dtmFechaRetorno As Date = d.dtmFechaRetorno
                Dim strHoraRetorno As String = d.strHoraRetorno

                Dim aExpedir(-1) As CrearAlbaranVentaInfo
                aExpedir = ValidaLineasMaterial(dtExpedir, IDTrabajo, dtmFechaSalida, strHoraSalida)
                If Not IsNothing(aExpedir) AndAlso aExpedir.Length > 0 Then
                    Dim dc As Contador.DefaultCounter = ExpertisApp.ExecuteTask(Of String, Contador.DefaultCounter)(AddressOf Contador.GetDefaultCounterValue, GetType(AlbaranVentaCabecera).Name)

                    Dim p As New Parametro
                    Dim data As New DataPrcAlbaranar(aExpedir, dc.CounterID, , p.TipoAlbaranDeDeposito, enumTipoExpedicion.teAlquiler)
                    Dim Propuesta As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)
                    If Not IsNothing(Propuesta) Then
                        If Not Propuesta.PropuestaAlbaranes Is Nothing AndAlso Propuesta.PropuestaAlbaranes.Rows.Count > 0 Then
                            Dim frm As New frmAlbaranProvisional
                            Dim dr As DialogResult = frm.AbrirFormulario(Propuesta.PropuestaAlbaranes)
                            If dr = DialogResult.OK Then
                                oCursor = Cursors.WaitCursor

                                Dim datosAct As New dataPrcActualizarAlbaranAlquiler(Propuesta)
                                datosAct.Conductores = dtConductores
                                datosAct.Contadores = dtContadores
                                datosAct.Retornos = False
                                datosAct.SalidaRetornos = True

                                Dim rslt As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquiler), datosAct)
                                Dim Albaranes() As Integer = AlbaranesGenerados(rslt.CreateData)
                                If Albaranes.Length > 0 Then
                                    Dim aRetornar(-1) As CrearAlbaranVentaInfo
                                    aRetornar = DatosARetornar(Albaranes, dtmFechaRetorno, strHoraRetorno, d.dtEstadoActivo)
                                    If Not IsNothing(aRetornar) AndAlso aRetornar.Length > 0 Then
                                        oCursor = Cursors.WaitCursor
                                        data = New DataPrcAlbaranar(aRetornar, dc.CounterID, , P.TipoAlbaranRetornoAlquiler, enumTipoExpedicion.teAlquiler)
                                        Propuesta = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarAlquiler), data)

                                        datosAct = New dataPrcActualizarAlbaranAlquiler(Propuesta)
                                        datosAct.Contadores = dtContadores
                                        datosAct.Retornos = True
                                        datosAct.SalidaRetornos = True

                                        Dim rsltRetorno As ResultAlbaranAlquiler = New BE.DataEngine().RunProcess(GetType(PrcActualizarAlbaranAlquiler), datosAct)
                                        Dim rstAlbaranes As ResultAlbaranAlquiler = UnirResults(rslt, rsltRetorno)

                                        Albaranes = AlbaranesGenerados(rstAlbaranes.CreateData)

                                        Dim IDAlbaran(Albaranes.Length - 1) As Object
                                        Albaranes.CopyTo(IDAlbaran, 0)

                                        Dim AbrirAlbaran As Boolean = True
                                        Dim dtOT As DataTable = New MntoOT().Filter(New InListFilterItem("IDAlbaranRetorno", IDAlbaran, FilterType.Numeric), , "IDOT, NROT")
                                        If Not dtOT Is Nothing AndAlso dtOT.Rows.Count > 0 Then
                                            Dim NROTs As String = String.Empty
                                            Dim IDOT As Integer = dtOT.Rows(0)("IDOT")
                                            For Each drOT As DataRow In dtOT.Rows
                                                If Len(NROTs) > 0 Then NROTs = NROTs & " ,"
                                                NROTs = NROTs & drOT("NROT")
                                            Next

                                            Dim NAlbaranes As String = ListadoAlbaranesGenerados(rstAlbaranes.CreateData)
                                            If ExpertisApp.GenerateMessage("Se han generado las Ordenes de Trabajo: " & NROTs & ". Se han generado los Albaranes :" & NAlbaranes & ". ¿Desea abrir el mantenimiento de las Ordenes de Trabajo?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                                AbrirAlbaran = False
                                                ExpertisApp.OpenForm("MNTOOT", New NumberFilterItem("IDOT", IDOT))
                                            End If
                                        End If
                                        If AbrirAlbaran Then
                                            TratarLog(rstAlbaranes.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True, rslt.StockUpdateData)
                                        End If
                                    End If
                                Else
                                    TratarLog(rslt.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True, rslt.StockUpdateData)
                                End If

                                oCursor = Cursors.Default
                            Else
                                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            TratarLog(Propuesta.CreateData, enumTipoDocumentoCreado.AlbaranVentaAlquiler, True, True)
                        End If
                    End If
                Else
                    ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Public Function UnirResults(ByVal r1 As ResultAlbaranAlquiler, ByVal r2 As ResultAlbaranAlquiler) As ResultAlbaranAlquiler
        If Not r2 Is Nothing Then
            If r2.CreateData.CreatedElements.Length > 0 Then
                For Each e As CreateElement In r2.CreateData.CreatedElements
                    ReDim Preserve r1.CreateData.CreatedElements(r1.CreateData.CreatedElements.Length)
                    r1.CreateData.CreatedElements(r1.CreateData.CreatedElements.Length - 1) = New CreateElement
                    r1.CreateData.CreatedElements(r1.CreateData.CreatedElements.Length - 1).IDElement = e.IDElement
                    r1.CreateData.CreatedElements(r1.CreateData.CreatedElements.Length - 1).NElement = e.NElement
                Next
            End If
            If r2.StockUpdateData.Length > 0 Then
                For Each stock As StockUpdateData In r2.StockUpdateData
                    ReDim Preserve r1.StockUpdateData(UBound(r1.StockUpdateData) + 1)
                    r1.StockUpdateData(UBound(r1.StockUpdateData)) = stock
                Next
            End If
        End If

        Return r1
    End Function

    Private Function DatosARetornar(ByVal intIDAlbaran() As Integer, _
                                    Optional ByVal dtmFechaRetorno As Date = cnMinDate, _
                                    Optional ByVal strHoraRetorno As String = "", _
                                    Optional ByVal dtEstadoActivo As DataTable = Nothing) As CrearAlbaranVentaInfo()

        Dim aExpedir(-1) As CrearAlbaranVentaInfo

        Dim IDAlbaran(intIDAlbaran.Length - 1) As Object
        intIDAlbaran.CopyTo(IDAlbaran, 0)

        Dim f As New Filter
        f.Add(New InListFilterItem("IDAlbaran", IDAlbaran, FilterType.Numeric))
        f.Add(New NumberFilterItem("TipoFactAlquiler", FilterOperator.NotEqual, enumTipoFacturacionAlquiler.enumTFASinAlquiler))
        Dim dtMarcados As DataTable = New BE.DataEngine().Filter("vAlquilerCIRetornoAutomatico", f, , "IDObra DESC, FechaAlbaran DESC")
        For Each drMarcados As DataRow In dtMarcados.Select
            If Length(drMarcados("IDAlmacenDeposito")) > 0 AndAlso Length(drMarcados("FechaAlbaran")) > 0 AndAlso Nz(drMarcados("QServida"), 0) <> 0 AndAlso dtmFechaRetorno <> cnMinDate Then
                Dim datosExp As New CrearAlbaranVentaInfo
                datosExp.IDLinea = drMarcados("IDLineaAlbaran")
                datosExp.IDLineaMaterial = drMarcados("IDLineaMaterial")
                datosExp.Cantidad = drMarcados("QServida")
                datosExp.IDCliente = drMarcados("IDCliente")
                datosExp.FechaAlquiler = dtmFechaRetorno
                If Length(strHoraRetorno) > 0 Then
                    datosExp.HoraAlquiler = strHoraRetorno
                Else
                    datosExp.HoraAlquiler = Date.Today.ToShortTimeString
                End If
                datosExp.FechaPrevistaRetorno = Nz(drMarcados("FechaPrevistaRetorno"), cnMinDate)

                If Not IsNothing(dtEstadoActivo) AndAlso dtEstadoActivo.Rows.Count > 0 Then
                    Dim dvEstadoActivo As New DataView(dtEstadoActivo.Copy)
                    dvEstadoActivo.RowFilter = "IDLineaMaterial =" & drMarcados("IDLineaMaterial")
                    If dvEstadoActivo.Count > 0 Then
                        datosExp.IDEstadoActivo = dvEstadoActivo(0).Row("IDEstadoActivoNew")
                    End If
                End If

                ReDim Preserve aExpedir(UBound(aExpedir) + 1)
                aExpedir(UBound(aExpedir)) = datosExp
            End If
        Next

        Return aExpedir
    End Function

    Private Function ControlFechasEntrega(ByVal dt As DataTable, ByRef dtFecha As Date) As Boolean
        Dim dtmFechaEntrega As Date
        If dtmFechaEntrega <> dtFecha Then
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Select("", "FechaEntrega")
                    If dtmFechaEntrega <> dr("FechaEntrega") Then
                        dtmFechaEntrega = dr("FechaEntrega")
                        ControlFechasEntrega = True
                        Exit Function
                    End If
                Next
                dtFecha = dtmFechaEntrega
            End If
        End If
    End Function

    Private Function ValidaLineasMaterial(ByVal dtExpedir As DataTable, ByVal IDTrabajo As Integer, ByVal Fecha As Date, ByVal strHora As String) As CrearAlbaranVentaInfo()
        If Not IsNothing(dtExpedir) AndAlso dtExpedir.Rows.Count > 0 Then
            Dim blnCancel, blnSiguiente As Boolean
            Dim strIDOperario As String = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf Operario.ObtenerIDOperarioUsuario, Nothing)
            If Length(strIDOperario) = 0 Then
                ExpertisApp.GenerateMessage("Proceso cancelado. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim dvExpedir As New DataView(dtExpedir)
                dvExpedir.RowFilter = "IDTrabajo = " & IDTrabajo & " And Estado <> " & enumomEstado.omServido & " AND ('" & Fecha & "' > FechaMaxima OR FechaMaxima IS NULL) AND Expedible=1"
                If dvExpedir.Count <> dtExpedir.Rows.Count Then
                    If ExpertisApp.GenerateMessage("No se tendrán en cuenta las líneas cuya Fecha de Último Vencimiento sea superior a la Fecha de Alquiler.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                        blnCancel = True
                    End If
                End If
                Dim intPos As Integer
                If Not blnCancel AndAlso dvExpedir.Count > 0 Then
                    'Validación de campos necesarios para la expedición.
                    Dim strCamposVacios As String = String.Empty
                    For Each selectedRow As DataRowView In dvExpedir
                        For Each dc As DataColumn In dvExpedir.Table.Columns
                            If dc.ColumnName = "IDUDMedida" Or dc.ColumnName = "IDAlmacen" Or dc.ColumnName = "IDFormaPago" Or _
                               dc.ColumnName = "IDCondicionPago" Or dc.ColumnName = "IDTipoIva" Or dc.ColumnName = "IDMoneda" Then
                                If Length(selectedRow.Row(dc.ColumnName)) = 0 Then
                                    If Length(strCamposVacios) > 0 Then strCamposVacios = strCamposVacios & ","
                                    strCamposVacios = strCamposVacios & dc.ColumnName
                                End If
                            End If
                        Next
                        If Length(strCamposVacios) > 0 Then
                            ExpertisApp.GenerateMessage("No es posible lanzar el proceso por falta de información en las líneas. Existen los siguientes campos sin información : |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, strCamposVacios)
                            blnCancel = True
                            Exit For
                        End If
                        If selectedRow.Row("QAlbaran") <= 0 Then
                            ExpertisApp.GenerateMessage("No es posible realizar el proceso. Los materiales asociados a la orden de servicio han sido expedidos en su totalidad. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            blnSiguiente = True
                        Else
                            intPos = intPos + 1
                        End If
                        If Not blnSiguiente AndAlso selectedRow.Row("NSerieObligatorio") And Length(selectedRow.Row("Serie")) = 0 Then
                            ExpertisApp.GenerateMessage("No es posible generar el albarán. Falta asignar el número de serie a algunos materiales. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            blnCancel = True
                            Exit For
                        End If
                        blnSiguiente = False
                    Next
                    If Not blnCancel Then
                        If intPos > 0 And intPos < dtExpedir.Rows.Count Then
                            ExpertisApp.GenerateMessage("No se tendrán en cuenta las líneas asociadas a la orden con materiales expedidos en su totalidad.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        Dim aExpedir(-1) As CrearAlbaranVentaInfo
                        For Each selectedRow As DataRowView In dvExpedir
                            If selectedRow.Row("QAlbaran") > 0 Then
                                Dim datosExp As New CrearAlbaranVentaInfo
                                datosExp.IDLinea = selectedRow.Row("IDLineaMaterial")
                                datosExp.Cantidad = selectedRow.Row("QAlbaran")
                                datosExp.IDCliente = selectedRow.Row("IDCliente")
                                datosExp.FechaAlquiler = Fecha
                                datosExp.HoraAlquiler = strHora

                                ReDim Preserve aExpedir(UBound(aExpedir) + 1)
                                aExpedir(UBound(aExpedir)) = datosExp
                            End If
                        Next

                        Return aExpedir
                    End If
                End If
            End If
        End If

        Return Nothing
    End Function

#End Region

#Region " Fianzas "

    Public Sub ADDFianza(ByVal dtTrabajo As DataTable)
        Dim dblFianza As Double
        Dim dtmFechaFianza As Date = Nz(dtTrabajo.Rows(0)("FechaOrden"), Date.Today)

        Dim frm As New frmFianza
        Dim dr As DialogResult = frm.AbrirAltaFianzas(dtmFechaFianza, dblFianza)
        If dr = DialogResult.OK Then
            Dim data As New FianzaAlquiler.dataADDFianza(dtTrabajo, dblFianza, dtmFechaFianza)
            ExpertisApp.ExecuteTask(Of FianzaAlquiler.dataADDFianza)(AddressOf FianzaAlquiler.ADDFianza, data)
            ExpertisApp.GenerateMessage("La contabilización se realizó correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ExpertisApp.GenerateMessage("Fianza cancelada.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub DeleteFianza(ByVal dtTrabajo As DataTable)
        ExpertisApp.ExecuteTask(Of DataTable)(AddressOf FianzaAlquiler.DeleteFianza, dtTrabajo)
        ExpertisApp.GenerateMessage("Fianza borrada.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region

    Public Sub RecalculoFechaRetorno(ByVal dtMarcados As DataTable, ByVal IDTipoAlbaran As String)
        If dtMarcados Is Nothing OrElse dtMarcados.Rows.Count = 0 Then
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim f As New Filter
            f.Add(New StringFilterItem("IDTipoAlbaran", IDTipoAlbaran))
            f.Add(New BooleanFilterItem("FacturarDiasMinimos", True))

            Dim IDLineaAlbaran(-1) As Object
            For Each drMarcados As DataRow In dtMarcados.Select(f.Compose(New AdoFilterComposer))
                ReDim Preserve IDLineaAlbaran(UBound(IDLineaAlbaran) + 1)
                IDLineaAlbaran(UBound(IDLineaAlbaran)) = drMarcados("IDLineaAlbaran")
            Next
            If IDLineaAlbaran.Length > 0 Then
                ExpertisApp.ExecuteTask(Of Object())(AddressOf GeneralAlquiler.RecalcularFechaAlquiler, IDLineaAlbaran)
                ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

#Region " Transferencias de Almacén "

    Public Function RealizarTransferencias(ByVal dtTransferencias As DataTable) As DataTable
        If Not IsNothing(dtTransferencias) AndAlso dtTransferencias.Rows.Count > 0 Then
            For Each drRowTransferencia As DataRow In dtTransferencias.Select
                If drRowTransferencia("RealizarTransferencia") AndAlso length(drRowTransferencia("IDAlmacenOrigen")) > 0 AndAlso length(drRowTransferencia("IDAlmacenDestino")) > 0 Then
                    Dim data As New ProcesoStocks.DataTransferenciaOrdenServicio(drRowTransferencia("IDArticulo"), drRowTransferencia("NSerie") & String.empty, _
                                                                                 drRowTransferencia("IDAlmacenOrigen"), drRowTransferencia("IDAlmacenDestino"))

                    Dim Log As StockUpdateData() = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataTransferenciaOrdenServicio, StockUpdateData())(AddressOf ProcesoStocks.TransferenciaOrdenServicio, data)

                    If Not IsNothing(Log) AndAlso Log.Length > 0 Then
                        Dim blnActualizacionesPendientes As Boolean = False
                        For iAct As Integer = 0 To Log.Length - 1
                            If Log(iAct).Estado <> EstadoStock.Actualizado Then
                                blnActualizacionesPendientes = True
                                Exit For
                            End If
                        Next

                        If Not blnActualizacionesPendientes Then
                            drRowTransferencia("TransferenciaRealizada") = True
                            drRowTransferencia("Log") = System.DBNull.Value
                        Else
                            drRowTransferencia("TransferenciaRealizada") = False
                            drRowTransferencia("Log") = Log
                        End If
                    End If
                End If
            Next
        End If
        Return dtTransferencias
    End Function

    Public Sub MostrarTransferenciasNoRealizadas(ByVal dtLogs As DataTable)
        Dim ArrayLogs() As StockUpdateData = Nothing

        If Not IsNothing(dtLogs) AndAlso dtLogs.Rows.Count > 0 Then
            Dim f As New Filter
            f.Add(New BooleanFilterItem("TransferenciaRealizada", False))
            For Each drLog As DataRow In dtLogs.Select(f.Compose(New AdoFilterComposer))
                If Not IsNothing(drLog("Log")) AndAlso CType(drLog("Log"), Array).Length > 0 Then
                    For i As Integer = 0 To CType(drLog("Log"), Array).Length - 1
                        If IsNothing(ArrayLogs) Then
                            ArrayLogs = Array.CreateInstance(GetType(StockUpdateData), 1)
                        Else
                            ReDim Preserve ArrayLogs(ArrayLogs.Length)
                        End If
                        ArrayLogs.SetValue(drLog("Log")(i), ArrayLogs.Length - 1)
                    Next i
                End If
            Next drLog
        End If

        If Not IsNothing(ArrayLogs) AndAlso ArrayLogs.Length > 0 Then
            If ExpertisApp.GenerateMessage("Algunos registros no han podido ser actualizados. ¿Dese ver el detalle.?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim frm As New DetalleActualizacionStock
                frm.DataSource = ArrayLogs
                frm.ShowDialog()
            End If
        End If
    End Sub

    Public Sub TratamientoTransferencias(ByRef dtTransferencias As DataTable, ByRef blnCancel As Boolean, ByRef blnTransferenciasNoRealizadas As Boolean)
        blnTransferenciasNoRealizadas = False
        Dim frmMostrarTransferencias As New frmTransferenciasAlmacen
        frmMostrarTransferencias.Transferencias = dtTransferencias
        If frmMostrarTransferencias.ShowDialog = DialogResult.OK Then
            dtTransferencias = frmMostrarTransferencias.Transferencias

            Dim f As New Filter
            f.Add(New BooleanFilterItem("RealizarTransferencia", True))
            Dim dvTransMarcadas As DataView = New DataView(dtTransferencias, f.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
            If Not IsNothing(dvTransMarcadas) AndAlso dvTransMarcadas.Count > 0 Then
                dtTransferencias = RealizarTransferencias(dtTransferencias)
                Dim objFilterTransOK As New Filter
                objFilterTransOK.Add("TransferenciaRealizada", True)
                Dim dvTransferenciasOK As New DataView(dtTransferencias, objFilterTransOK.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
                If Not IsNothing(dvTransferenciasOK) AndAlso dvTransferenciasOK.Count = dtTransferencias.Rows.Count Then
                    ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    blnTransferenciasNoRealizadas = True
                    MostrarTransferenciasNoRealizadas(dtTransferencias)
                End If
            End If
        Else
            blnCancel = True
        End If

        If Not blnCancel AndAlso Not blnTransferenciasNoRealizadas Then
            dtTransferencias.Rows.Clear()
        End If
    End Sub

#End Region

    Public Function ValidarTrabajoTerminado(ByVal IDTrabajo As Integer, ByVal IDTipoAlbaran As String) As Boolean
        Dim DE As New BE.DataEngine
        Dim f As New Filter
        f.Add(New NumberFilterItem("IDTrabajo", IDTrabajo))
        Dim dtTT As DataTable = DE.Filter("vAlquilerCIPropuestaCierreEstadoEnvios", f, "IDTrabajo")
        If Not IsNothing(dtTT) AndAlso dtTT.Rows.Count > 0 Then
            Return False
        Else
            f.Add(New NumberFilterItem("IDTipoAlbaran", IDTipoAlbaran))
            f.Add(New NumberFilterItem("Qpendiente", FilterOperator.GreaterThanOrEqual, 1))
            Dim dtRetorno As DataTable = DE.Filter("vAlquilerCIPropuestaCierreEstadoRetornos", f, "IDTrabajo")
            If Not IsNothing(dtRetorno) AndAlso dtRetorno.Rows.Count > 0 Then
                Return False
            End If
        End If
        Return True
    End Function

End Module

Public Class TransferenciasAlmacenCollection
    Private mTransferencias As DataTable

    Private Function CrearDTTransferencias() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("IDLineaMaterial", GetType(Integer))
        dt.Columns.Add("IDArticulo", GetType(String))
        dt.Columns.Add("NSerie", GetType(String))
        dt.Columns.Add("IDAlmacenOrigen", GetType(String))
        dt.Columns.Add("IDAlmacenDestino", GetType(String))
        dt.Columns.Add("RealizarTransferencia", GetType(Boolean))
        dt.Columns.Add("TransferenciaRealizada", GetType(Boolean))
        dt.Columns.Add("Log", GetType(StockUpdateData))

        Return dt
    End Function

    Public Function AddTransferencia(ByVal intIDLineaMaterial As Integer, ByVal strIDArticulo As String, ByVal strNSerie As String, ByVal strIDAlmacenOrigen As String, ByVal strIDAlmacenDestino As String, ByVal blnRealizarTransferencia As Boolean) As DataTable
        If IsNothing(mTransferencias) Then mTransferencias = CrearDTTransferencias()
        Dim Cancel As Boolean = False
        If mTransferencias.Rows.Count > 0 Then
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDLineaMaterial", intIDLineaMaterial))
            f.Add(New StringFilterItem("IDArticulo", strIDArticulo))
            f.Add(New StringFilterItem("NSerie", strNSerie))
            f.Add(New StringFilterItem("IDAlmacenOrigen", strIDAlmacenOrigen))
            f.Add(New StringFilterItem("IDAlmacenDestino", strIDAlmacenDestino))
            Dim dr() As DataRow = mTransferencias.Select(f.Compose(New AdoFilterComposer))
            Cancel = (dr.Length > 0)
        End If
        If Not Cancel Then
            Dim drNew As DataRow = mTransferencias.NewRow
            drNew("IDLineaMaterial") = intIDLineaMaterial
            drNew("IDArticulo") = strIDArticulo
            drNew("NSerie") = strNSerie
            drNew("IDAlmacenOrigen") = strIDAlmacenOrigen
            drNew("IDAlmacenDestino") = strIDAlmacenDestino
            drNew("RealizarTransferencia") = blnRealizarTransferencia
            drNew("TransferenciaRealizada") = True
            mTransferencias.Rows.Add(drNew)
        End If

        Return mTransferencias
    End Function

    Public Function DeleteTransferencia(ByVal intIDLineaMaterial As Integer) As DataTable
        Dim objFilter As New Filter
        objFilter.Add(New NumberFilterItem("IDLineaMaterial", intIDLineaMaterial))
        Dim drRowDelete() As DataRow = mTransferencias.Select(objFilter.Compose(New AdoFilterComposer))
        If Not IsNothing(drRowDelete) AndAlso drRowDelete.Length > 0 Then
            For i As Integer = 0 To drRowDelete.Length - 1
                mTransferencias.Rows.Remove(drRowDelete(i))
            Next i
        End If

        Return mTransferencias
    End Function

End Class
