Public Class MovimientosAlmacens

    Private Sub MovimientosAlmacens_QueryExecuting(ByVal sender As System.Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvArticulo.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, AdvTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvFamilia.Text, FilterType.String)
        e.Filter.Add("IDSubfamilia", FilterOperator.Equal, AdvSubFamilia.Text, FilterType.String)
        e.Filter.Add("FechaDocumento", FilterOperator.GreaterThanOrEqual, CalendarBox1.Value, FilterType.DateTime)
        e.Filter.Add("FechaDocumento", FilterOperator.LessThanOrEqual, CalendarBox2.Value, FilterType.DateTime)

        e.Filter.Add("AlmacenEntrada", FilterOperator.Equal, AdvAlmacenEntrada.Text, FilterType.String)
        e.Filter.Add("AlmacenSalida", FilterOperator.Equal, AdvAlmacenSalida.Text, FilterType.String)
    End Sub

    Private Sub MovimientosAlmacens_SetReportDesignObjects(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Try
            'Dim vMes As Integer
            Dim Fecha1 As Date
            Dim Fecha2 As Date
            Dim cancel As Boolean

            'Abrir Informe de Beneficio
            If e.Alias = "INFCOSTES" Then
                Dim frm As New frmInformeFecha
                frm.ShowDialog()
                Fecha1 = frm.FechaDesde.Value
                Fecha2 = frm.FechaHasta.Value

                If frm.blEstado = True Then
                    MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                    Exit Sub
                End If
                GenerarCostes(CDate(Fecha1), CDate(Fecha2))
                e.Cancel = True
            End If
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub
    Private Sub GenerarCostes(ByVal Fecha1 As Date, ByVal Fecha2 As Date)
        Try
            Dim rp As New Report("INFCOSTES")
            Dim filtro As New Filter

            filtro.Add("FechaDocumento", FilterOperator.GreaterThanOrEqual, Fecha1)
            filtro.Add("FechaDocumento", FilterOperator.LessThanOrEqual, Fecha2)
            rp.Formulas("fDesde").Text = Format(Fecha1, "dd-MM-yyyy")
            rp.Formulas("fHasta").Text = Format(Fecha2, "dd-MM-yyyy")
            'Dim laborables As String
            'laborables = Work_Days(Fecha1, Fecha2)
            'rp.Formulas("laborables").Text = laborables
            rp.DataSource = New BE.DataEngine().Filter("vTraspasosAlmacen", filtro)

            ExpertisApp.OpenReport(rp)
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
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
End Class
