﻿Public Class frmInformeFecha

    Public blEstado As Boolean
    Public fecha1 As Date
    Public fecha2 As Date

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FechaDesde.Text = "" Or FechaHasta.Text = "" Then
            ExpertisApp.GenerateMessage("Debe indicar fechas para poder continuar o pulse Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        fecha1 = Nz(FechaDesde.Value, "01-01-1979")
        fecha2 = Nz(FechaHasta.Value, "31-12-2040")
        blEstado = False
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        blEstado = True
        Me.Close()
    End Sub
End Class