Public Class frmSeguimientoNumeroSerie

    Public dt As DataTable
    Public filtro As Filter

    'Datos 
    Public fechaDoc As String
    Public idalmacenorigen As String
    Public idalmacen As String
    Public nalbaran As String

    Private Sub frmSeguimientoNumeroSerie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tbArticulos As New DataTable
        tbArticulos = New BE.DataEngine().Filter("vControlArticulosNSerie", filtro)
        Grid2.DataSource = tbArticulos
    End Sub


    Private Sub Grid2_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid2.EditingCell
        With Grid2
            Select Case e.Column.Key
                Case "IDArticulo", "DescArticulo", "NSerie", "IDAlmacen", "FechaEnvio", "FechaCaducidad"
                    e.Cancel = True
            End Select
        End With
    End Sub


    Private Sub bCreaArticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCreaArticulo.Click
        Dim frm As New frmCrearArticuloConNSerie
        frm.filtro = filtro
        frm.fechaDoc = fechaDoc
        frm.idalmacen = idalmacen
        frm.nalbaran = nalbaran
        frm.idalmacenorigen = idalmacenorigen
        Me.Dispose()
        frm.ShowDialog()
    End Sub


    Private Sub bActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bActualizar.Click
        'Guardo la tabla del Grid donde haya X modifico la FechaEnvio e IDAlmacen
        Dim dtSinFiltrar As New DataTable
        dtSinFiltrar = Grid2.DataSource

        Dim dt As New DataTable
        Dim cont As Integer = 0
        'Recorre la tabla y me quedo con la de X
        For i As Integer = 0 To dtSinFiltrar.Columns.Count - 1
            dt.Columns.Add(dtSinFiltrar.Columns(i).ColumnName)
        Next

        For Each dr As DataRow In dtSinFiltrar.Rows
            If dtSinFiltrar.Rows(cont)("Confirmacion").ToString = "X" Then
                dt.Rows.Add(dtSinFiltrar.Rows(cont).ItemArray)
            End If
            cont += 1
        Next
        Dim sqlact As String
        Dim sqlins As String
        'Realiza la actualización recorriendo la nueva tabla
        Dim aux As New Business.ClasesTecozam.MetodosAuxiliares
        Dim fecha As Date
        fecha = Today
        For Each dr As DataRow In dt.Rows
            'Actualizo el articulo con su numero de serie
            sqlact = "UPDATE tbControlArticulosNSerie SET FechaEnvio ='" & Nz(fechaDoc, fecha) & "', IDAlmacen = '" & idalmacen & "', FechaModificacionAudi = '" & Today & "', UsuarioAudi = '" & ExpertisApp.Token.UserName.ToString & "' WHERE IDArticulo = '" & dr("IDArticulo") & "' and NSerie = '" & dr("NSerie") & "'"
            aux.EjecutarSql(sqlact)
            'Inserto el movimiento en tbhistoricoActivos
            sqlins = "INSERT INTO tbHistoricoActivos(IDLineaMovimiento, NAlbaran, IDAlmacenOrigen, IDAlmacenDestino, IDArticulo, NSerie, FechaEnvio, UsuarioAudi, FechaCreacionAudi, FechaModificacionAudi)" & _
                    " VALUES('" & aux.devuelveAutonumeri & "', '" & nalbaran & "', '" & idalmacenorigen & "','" & idalmacen & "', '" & dr("IDArticulo") & "', '" & dr("NSerie") & "', '" & fechaDoc & "', '" & ExpertisApp.Token.UserName.ToString & "', '" & Today & "', '" & Today & "')"
            aux.EjecutarSql(sqlins)
        Next

        MessageBox.Show("Se han actualizado los articulos con su número de serie correctamente.", "Proceso confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Dispose()
    End Sub

End Class