Public Class FrmTraspasoMaterial
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.Size = New Drawing.Size(444, 184)
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
    Friend WithEvents fraFechas As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents pnlBotones As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblHoraSalida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtHoraSalida As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblHoraRetorno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtHoraRetorno As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFechaSalida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaSalida As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaRetorno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaRetorno As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescObra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents pnlPrincipal As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents advIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chkFianzaObligatoria As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents pnlFianza As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents fraFianzaObligatoria As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents cbxFechaFianza As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFianza As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtFianza As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblFianza As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.fraFechas = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblHoraSalida = New Solmicro.Expertis.Engine.UI.Label
        Me.txtHoraSalida = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblHoraRetorno = New Solmicro.Expertis.Engine.UI.Label
        Me.txtHoraRetorno = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFechaSalida = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaSalida = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaRetorno = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaRetorno = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.pnlBotones = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescObra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.chkFianzaObligatoria = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.pnlPrincipal = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlFianza = New Solmicro.Expertis.Engine.UI.Panel
        Me.fraFianzaObligatoria = New Solmicro.Expertis.Engine.UI.Frame
        Me.cbxFechaFianza = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFianza = New Solmicro.Expertis.Engine.UI.Label
        Me.txtFianza = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFianza = New Solmicro.Expertis.Engine.UI.Label
        Me.fraFechas.SuspendLayout()
        Me.pnlBotones.suspendlayout()
        Me.pnlPrincipal.suspendlayout()
        Me.pnlFianza.suspendlayout()
        Me.fraFianzaObligatoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraFechas
        '
        Me.fraFechas.Controls.Add(Me.lblHoraSalida)
        Me.fraFechas.Controls.Add(Me.txtHoraSalida)
        Me.fraFechas.Controls.Add(Me.lblHoraRetorno)
        Me.fraFechas.Controls.Add(Me.txtHoraRetorno)
        Me.fraFechas.Controls.Add(Me.lblFechaSalida)
        Me.fraFechas.Controls.Add(Me.cbxFechaSalida)
        Me.fraFechas.Controls.Add(Me.lblFechaRetorno)
        Me.fraFechas.Controls.Add(Me.cbxFechaRetorno)
        Me.fraFechas.Location = New System.Drawing.Point(12, 29)
        Me.fraFechas.Name = "fraFechas"
        Me.fraFechas.Size = New System.Drawing.Size(407, 72)
        Me.fraFechas.TabIndex = 1
        Me.fraFechas.TabStop = False
        '
        'lblHoraSalida
        '
        Me.lblHoraSalida.Location = New System.Drawing.Point(235, 45)
        Me.lblHoraSalida.Name = "lblHoraSalida"
        Me.lblHoraSalida.Size = New System.Drawing.Size(73, 13)
        Me.lblHoraSalida.TabIndex = 0
        Me.lblHoraSalida.Text = "Hora Salida"
        '
        'txtHoraSalida
        '
        Me.txtHoraSalida.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraSalida.Location = New System.Drawing.Point(324, 41)
        Me.txtHoraSalida.Name = "txtHoraSalida"
        Me.txtHoraSalida.Size = New System.Drawing.Size(70, 21)
        Me.txtHoraSalida.TabIndex = 4
        '
        'lblHoraRetorno
        '
        Me.lblHoraRetorno.Location = New System.Drawing.Point(235, 21)
        Me.lblHoraRetorno.Name = "lblHoraRetorno"
        Me.lblHoraRetorno.Size = New System.Drawing.Size(83, 13)
        Me.lblHoraRetorno.TabIndex = 5
        Me.lblHoraRetorno.Text = "Hora Retorno"
        '
        'txtHoraRetorno
        '
        Me.txtHoraRetorno.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraRetorno.Location = New System.Drawing.Point(324, 17)
        Me.txtHoraRetorno.Name = "txtHoraRetorno"
        Me.txtHoraRetorno.Size = New System.Drawing.Size(70, 21)
        Me.txtHoraRetorno.TabIndex = 2
        '
        'lblFechaSalida
        '
        Me.lblFechaSalida.Location = New System.Drawing.Point(21, 45)
        Me.lblFechaSalida.Name = "lblFechaSalida"
        Me.lblFechaSalida.Size = New System.Drawing.Size(79, 13)
        Me.lblFechaSalida.TabIndex = 6
        Me.lblFechaSalida.Text = "Fecha Salida"
        '
        'cbxFechaSalida
        '
        Me.cbxFechaSalida.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaSalida.Location = New System.Drawing.Point(115, 41)
        Me.cbxFechaSalida.Name = "cbxFechaSalida"
        Me.cbxFechaSalida.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaSalida.TabIndex = 3
        '
        'lblFechaRetorno
        '
        Me.lblFechaRetorno.Location = New System.Drawing.Point(21, 21)
        Me.lblFechaRetorno.Name = "lblFechaRetorno"
        Me.lblFechaRetorno.Size = New System.Drawing.Size(89, 13)
        Me.lblFechaRetorno.TabIndex = 7
        Me.lblFechaRetorno.Text = "Fecha Retorno"
        '
        'cbxFechaRetorno
        '
        Me.cbxFechaRetorno.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaRetorno.Location = New System.Drawing.Point(115, 17)
        Me.cbxFechaRetorno.Name = "cbxFechaRetorno"
        Me.cbxFechaRetorno.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaRetorno.TabIndex = 1
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.cmbCancelar)
        Me.pnlBotones.Controls.Add(Me.CmbAceptar)
        Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBotones.Location = New System.Drawing.Point(0, 327)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(428, 43)
        Me.pnlBotones.TabIndex = 2
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(217, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 17
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(117, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 16
        Me.CmbAceptar.Text = "Aceptar"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(8, 10)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(97, 13)
        Me.lblObra.TabIndex = 11
        Me.lblObra.Text = "Alquiler Destino"
        '
        'ulDescObra
        '
        Me.ulDescObra.Location = New System.Drawing.Point(207, 6)
        Me.ulDescObra.Name = "ulDescObra"
        Me.ulDescObra.Size = New System.Drawing.Size(210, 23)
        Me.ulDescObra.TabIndex = 12
        '
        'AdvIDObra
        '
        Me.AdvIDObra.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescObra", ulDescObra), New Solmicro.Expertis.Engine.UI.ASSelectedField("IDCliente", advIDCliente)})
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(107, 6)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(95, 23)
        Me.AdvIDObra.TabIndex = 0
        '
        'advIDCliente
        '
        Me.advIDCliente.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("FianzaObligatoria", chkFianzaObligatoria)})
        Me.advIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCliente.Enabled = False
        Me.advIDCliente.EntityName = "Cliente"
        Me.advIDCliente.Location = New System.Drawing.Point(70, 62)
        Me.advIDCliente.Name = "advIDCliente"
        Me.advIDCliente.SecondaryDataFields = "IDCliente"
        Me.advIDCliente.Size = New System.Drawing.Size(95, 23)
        Me.advIDCliente.TabIndex = 13
        '
        'chkFianzaObligatoria
        '
        Me.chkFianzaObligatoria.Enabled = False
        Me.chkFianzaObligatoria.Location = New System.Drawing.Point(174, 62)
        Me.chkFianzaObligatoria.Name = "chkFianzaObligatoria"
        Me.chkFianzaObligatoria.Size = New System.Drawing.Size(229, 23)
        Me.chkFianzaObligatoria.TabIndex = 15
        Me.chkFianzaObligatoria.Text = "El Cliente tiene Fianza obligatoria"
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.fraFechas)
        Me.pnlPrincipal.Controls.Add(Me.lblObra)
        Me.pnlPrincipal.Controls.Add(Me.AdvIDObra)
        Me.pnlPrincipal.Controls.Add(Me.ulDescObra)
        Me.pnlPrincipal.Controls.Add(Me.lblCliente)
        Me.pnlPrincipal.Controls.Add(Me.chkFianzaObligatoria)
        Me.pnlPrincipal.Controls.Add(Me.advIDCliente)
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(428, 103)
        Me.pnlPrincipal.TabIndex = 0
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(16, 67)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 16
        Me.lblCliente.Text = "Cliente"
        '
        'pnlFianza
        '
        Me.pnlFianza.Controls.Add(Me.fraFianzaObligatoria)
        Me.pnlFianza.Location = New System.Drawing.Point(0, 154)
        Me.pnlFianza.Name = "pnlFianza"
        Me.pnlFianza.Size = New System.Drawing.Size(428, 62)
        Me.pnlFianza.TabIndex = 3
        Me.pnlFianza.Visible = False
        '
        'fraFianzaObligatoria
        '
        Me.fraFianzaObligatoria.Controls.Add(Me.cbxFechaFianza)
        Me.fraFianzaObligatoria.Controls.Add(Me.lblFechaFianza)
        Me.fraFianzaObligatoria.Controls.Add(Me.txtFianza)
        Me.fraFianzaObligatoria.Controls.Add(Me.lblFianza)
        Me.fraFianzaObligatoria.Location = New System.Drawing.Point(12, 6)
        Me.fraFianzaObligatoria.Name = "fraFianzaObligatoria"
        Me.fraFianzaObligatoria.Size = New System.Drawing.Size(407, 54)
        Me.fraFianzaObligatoria.TabIndex = 0
        Me.fraFianzaObligatoria.TabStop = False
        Me.fraFianzaObligatoria.Text = "El Cliente del Alquiler Destino tiene Fianza obligatoria"
        '
        'cbxFechaFianza
        '
        Me.cbxFechaFianza.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFianza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.cbxFechaFianza.Location = New System.Drawing.Point(115, 25)
        Me.cbxFechaFianza.Name = "cbxFechaFianza"
        Me.cbxFechaFianza.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaFianza.TabIndex = 7
        '
        'lblFechaFianza
        '
        Me.lblFechaFianza.Location = New System.Drawing.Point(21, 29)
        Me.lblFechaFianza.Name = "lblFechaFianza"
        Me.lblFechaFianza.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaFianza.TabIndex = 6
        Me.lblFechaFianza.Text = "Fecha Fianza"
        '
        'txtFianza
        '
        Me.txtFianza.DisabledBackColor = System.Drawing.Color.White
        Me.txtFianza.Location = New System.Drawing.Point(298, 25)
        Me.txtFianza.Name = "txtFianza"
        Me.txtFianza.Size = New System.Drawing.Size(96, 21)
        Me.txtFianza.TabIndex = 1
        '
        'lblFianza
        '
        Me.lblFianza.Location = New System.Drawing.Point(235, 29)
        Me.lblFianza.Name = "lblFianza"
        Me.lblFianza.Size = New System.Drawing.Size(43, 13)
        Me.lblFianza.TabIndex = 0
        Me.lblFianza.Text = "Fianza"
        '
        'FrmTraspasoMaterial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(428, 370)
        Me.Controls.Add(Me.pnlFianza)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.pnlBotones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTraspasoMaterial"
        Me.Text = "Traspaso de Material"
        Me.fraFechas.ResumeLayout(False)
        Me.fraFechas.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        Me.pnlFianza.ResumeLayout(False)
        Me.fraFianzaObligatoria.ResumeLayout(False)
        Me.fraFianzaObligatoria.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mblnCancel As Boolean
    Private mdtMarcados As DataTable

    Public Function AbrirTraspasoMaterial(ByVal dtMarcados As DataTable, ByVal dtmFechaRetorno As Date, ByVal strHoraRetorno As String, _
                                          ByVal dtmFechaSalida As Date, ByVal strHoraSalida As String) As DialogResult

        cbxFechaRetorno.Value = dtmFechaRetorno
        txtHoraRetorno.Text = strHoraRetorno
        cbxFechaSalida.Value = dtmFechaSalida
        txtHoraSalida.Text = strHoraSalida
        mdtMarcados = dtMarcados.Copy

        Me.ShowDialog()

        Return Me.DialogResult
    End Function

    Private Sub AdvIDObra_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDObra.SetPredefinedFilter
        e.Filter.Add("TipoMnto", enumTipoObra.tpalquiler)
    End Sub

    Private Sub AdvIDObra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles AdvIDObra.Validating
        If Length(AdvIDObra.Text) = 0 Then
            Me.Size = New Drawing.Size(444, 184)
            pnlFianza.Dock = DockStyle.None
            pnlFianza.Visible = False
        End If
    End Sub

    Private Sub txtHoraRetorno_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHoraRetorno.LostFocus
        If Length(txtHoraRetorno.Text) > 0 Then
            Dim tmHoraAlquiler As Date
            If InStr(txtHoraRetorno.Text, ":") = 0 Then
                tmHoraAlquiler = txtHoraRetorno.Text & ":0"
            Else
                tmHoraAlquiler = txtHoraRetorno.Text
            End If
            txtHoraRetorno.Text = Format(tmHoraAlquiler, "HH:mm:ss")
        End If
    End Sub

    Private Sub txtHoraSalida_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHoraSalida.LostFocus
        If Length(txtHoraSalida.Text) > 0 Then
            Dim tmHoraAlquiler As Date
            If InStr(txtHoraSalida.Text, ":") = 0 Then
                tmHoraAlquiler = txtHoraSalida.Text & ":0"
            Else
                tmHoraAlquiler = txtHoraSalida.Text
            End If
            txtHoraSalida.Text = Format(tmHoraAlquiler, "HH:mm:ss")
        End If
    End Sub

    Private Sub chkFianzaObligatoria_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFianzaObligatoria.CheckedChanged
        If chkFianzaObligatoria.Checked Then
            fraFianzaObligatoria.Text = "El Cliente " & advIDCliente.Text & " del Alquiler " & AdvIDObra.Text & " tiene Fianza obligatoria"
            fraFianzaObligatoria.ForeColor = Color.Red
            cbxFechaFianza.ForeColor = cbxFechaSalida.ForeColor
            cbxFechaFianza.Value = Date.Today

            Me.Size = New Drawing.Size(444, 245)
            pnlFianza.Dock = DockStyle.Bottom
        Else
            Me.Size = New Drawing.Size(444, 184)
            pnlFianza.Dock = DockStyle.None
        End If
        pnlFianza.Visible = chkFianzaObligatoria.Checked
    End Sub

#Region " cmbAceptar_Click "

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        mblnCancel = ValidaDatos()
        If Not mblnCancel Then
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Function ValidaDatos() As Boolean
        Dim blnCancel As Boolean

        If Length(AdvIDObra.Value) = 0 Then
            ExpertisApp.GenerateMessage("El Alquiler Destino es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            blnCancel = True
        ElseIf Length(cbxFechaSalida.Value) = 0 Then
            ExpertisApp.GenerateMessage("La Fecha y Hora de Salida son datos obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            blnCancel = True
        ElseIf Length(cbxFechaRetorno.Value) = 0 Then
            ExpertisApp.GenerateMessage("La Fecha y Hora de Retorno son datos obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            blnCancel = True
        ElseIf Length(txtHoraSalida.Text) = 0 Then
            ExpertisApp.GenerateMessage("La Fecha y Hora de Salida son datos obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            blnCancel = True
        ElseIf Length(txtHoraRetorno.Text) = 0 Then
            ExpertisApp.GenerateMessage("La Fecha y Hora de Retorno son datos obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            blnCancel = True
        ElseIf CDate(cbxFechaRetorno.Value & " " & txtHoraRetorno.Text) > CDate(cbxFechaSalida.Value & " " & txtHoraSalida.Text) Then
            ExpertisApp.GenerateMessage("La Fecha de Retorno introducida no puede ser superior a la fecha de salida del material hacia el Alquiler Destino.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            blnCancel = True
        ElseIf pnlFianza.Visible AndAlso (txtFianza.Value = 0 OrElse Length(cbxFechaFianza.Value) = 0) Then
            ExpertisApp.GenerateMessage("La Fecha Contabilización y la Fianza son datos obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            blnCancel = True
        ElseIf Not mdtMarcados Is Nothing AndAlso mdtMarcados.Rows.Count > 0 Then
            Dim Values(-1) As Object
            For Each drMarcados As DataRow In mdtMarcados.Rows
                ' Hacer la comprobación de las líneas a traspasar respecto a la fecha de retorno
                If drMarcados("FechaAlbaran") > CDate(cbxFechaRetorno.Value) Then
                    ExpertisApp.GenerateMessage("La Fecha de Retorno del material a traspasar es inferior a la fecha con la que salió el material a el Alquiler origen.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    blnCancel = True
                    Exit For
                End If
                If Nz(drMarcados("IDLineaMaterial")) > 0 Then
                    ReDim Preserve Values(UBound(Values) + 1)
                    Values(UBound(Values)) = drMarcados("IDLineaMaterial")
                End If
            Next
            '29/11/06 - Modificación de Santago Mallo ************************************************
            'Ahora se debe comprobar que no existan vencimientos facturados posteriores a la fecha de devolución
            'de las máquinas desde su obra origen.
            If Not blnCancel AndAlso Values.Length > 0 Then
                Dim f As New Filter
                f.Add(New InListFilterItem("IDLineaMaterial", Values, FilterType.Numeric))
                f.Add(New DateFilterItem("FechaVencimiento", FilterOperator.GreaterThan, cbxFechaRetorno.Value))
                Dim dtOTF As DataTable = New ObraTrabajoFacturacion().Filter(f)
                If Not dtOTF Is Nothing AndAlso dtOTF.Rows.Count > 0 Then
                    ExpertisApp.GenerateMessage("Alguna de las líneas seleccionadas para el traspaso tiene generados vencimientos posteriores a la fecha indicada para su retorno.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    blnCancel = True
                End If
            End If
            '29/11/06 - Modificación de Santago Mallo ************************************************
        End If

        Return blnCancel
    End Function

#End Region

End Class
