Imports Solmicro.Expertis.Business.ClasesTecozam
Imports System.Windows.Forms
Imports Solmicro.Expertis.Business.Obra
Imports Solmicro.Expertis.Engine

Public Class frmCrearArticuloConNSerie
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Dim idArticulo As String
    Dim nserie As String
    Dim fechaCaducidad As String

    Public filtro As Filter
    Public fechaDoc As String
    Public idalmacenorigen As String
    Public idalmacen As String
    Public nalbaran As String



    Private Sub advArticulo_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advArticulo.SelectionChanged
        ulArticulo.Text = advArticulo.SelectedRow.Item("DescArticulo")
    End Sub


    Private Sub bAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAceptar.Click
        Try
            idArticulo = advArticulo.Text
            nserie = txtNSerie.Text
            fechaCaducidad = cBFechaCaducidad.Text


            If nserie.ToString.Length = 0 Or idArticulo.Length = 0 Or advAlmacen.Text.ToString.Length = 0 Then
                MsgBox("El articulo, el almacén y el numero de serie son datos obligatorios.")
                Exit Sub
            Else
                If (checkSiDuplicado(idArticulo, nserie) = 1) Then
                    'Hago la insercción del articulo en la tbControlArticulosNSerie
                    Dim sql As String
                    Dim almac As String
                    almac = advAlmacen.Text
                    Dim usuario As String
                    usuario = ExpertisApp.UserName
                    Dim idAutonumerico As Long
                    Dim auto As New OperarioCalendario
                    idAutonumerico = auto.Autonumerico()

                    If fechaCaducidad.ToString.Length = 0 Then
                        sql = "INSERT INTO tbControlArticulosNSerie(IDArticuloControl, IDArticulo, NSerie, IDAlmacen, UsuarioAudi, FechaCreacionAudi, FechaModificacionAudi)" & _
                        " VALUES(" & idAutonumerico & ", '" & idArticulo & "', '" & nserie & "', '" & almac & "', '" & usuario & "', '" & Today & "', '" & Today & "' )"
                        auto.Ejecutar(sql)
                    Else
                        sql = "INSERT INTO tbControlArticulosNSerie(IDArticuloControl, IDArticulo, NSerie, FechaCaducidad, IDAlmacen, UsuarioAudi, FechaCreacionAudi, FechaModificacionAudi)" & _
                        " VALUES(" & idAutonumerico & ", '" & idArticulo & "', '" & nserie & "','" & fechaCaducidad & " ', '" & almac & "', '" & usuario & "', '" & Today & "', '" & Today & "' )"
                        auto.Ejecutar(sql)
                    End If





                    'Abro la ventana y actualizo el nuevo registro con el filtro que me estoy llevando
                    Dim frmSegNSeries As New frmSeguimientoNumeroSerie
                    frmSegNSeries.filtro = filtro
                    frmSegNSeries.fechaDoc = fechaDoc
                    frmSegNSeries.idalmacen = idalmacen
                    frmSegNSeries.idalmacenorigen = idalmacenorigen
                    frmSegNSeries.nalbaran = nalbaran

                    Me.Dispose()
                    frmSegNSeries.ShowDialog()
                Else
                    MsgBox("Ya existe un activo con este número de serie.")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function checkSiDuplicado(ByVal idArticulo As String, ByVal nserie As String) As Integer
        Dim dt As New DataTable
        Dim f As New Filter
        f.Add("IDArticulo", idArticulo)
        f.Add("NSerie", nserie)
        dt = New BE.DataEngine().Filter("tbControlArticulosNSerie", f)

        If dt.Rows.Count = 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Private Sub bCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancelar.Click
        Dim frmSegNSeries As New frmSeguimientoNumeroSerie
        frmSegNSeries.filtro = filtro
        frmSegNSeries.fechaDoc = fechaDoc
        frmSegNSeries.idalmacen = idalmacen
        frmSegNSeries.idalmacenorigen = idalmacenorigen
        frmSegNSeries.nalbaran = nalbaran
        Me.Dispose()
        frmSegNSeries.ShowDialog()
    End Sub

    Private Sub advAlmacen_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advAlmacen.SelectionChanged
        UnderLineLabel1.Text = advAlmacen.SelectedRow.Item("DescAlmacen")
    End Sub
End Class