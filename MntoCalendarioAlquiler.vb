Public Class MntoCalendarioAlquiler
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

    Dim g As NeededData
    Dim g2 As NeededData

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        InicializarNeededData()
    End Sub

    Private Sub InicializarNeededData()
        Dim NOpe() As String = {"IDObra"}
        g = New NeededData("tbCalendarioObra", RelationMode.ChildMode, NOpe, NOpe)
        g.EntityName = "CalendarioObra"
        Me.AddDataItem(g)
        g2 = New NeededData("tbTipoTurno", RelationMode.NoRelation, Nothing, Nothing)
        g2.EntityName = "TipoTurno"
        Me.AddDataItem(g2)
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
    Friend WithEvents calendar As Solmicro.Expertis.Application.ERP.XCalendar.Calendar
    Friend WithEvents Panelcalendar As System.Windows.Forms.Panel
    Friend WithEvents PanelObra As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents PanelCalen As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ulDescObra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.calendar = New Solmicro.Expertis.Application.ERP.XCalendar.Calendar
        Me.Panelcalendar = New System.Windows.Forms.Panel
        Me.PanelCalen = New Solmicro.Expertis.Engine.UI.Panel
        Me.PanelObra = New Solmicro.Expertis.Engine.UI.Panel
        Me.ulDescObra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.Panelcalendar.SuspendLayout()
        Me.PanelCalen.suspendlayout()
        Me.PanelObra.suspendlayout()
        Me.SuspendLayout()
        '
        'Duplicate
        '
        Me.Duplicate.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(643, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 42)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'Delete
        '
        Me.Delete.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Cancel
        '
        '
        'Print
        '
        Me.Print.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'NewRow
        '
        Me.NewRow.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Requery
        '
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Panelcalendar)
        Me.MainPanel.Size = New System.Drawing.Size(856, 541)
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(21, 13)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(50, 13)
        Me.lblObra.TabIndex = 1
        Me.lblObra.Text = "Alquiler"
        '
        'txtNObra
        '
        Me.TryDataBinding(txtNObra, New System.Windows.Forms.Binding("Text", Me, "NObra", True))
        Me.txtNObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtNObra.Location = New System.Drawing.Point(77, 9)
        Me.txtNObra.Name = "txtNObra"
        Me.txtNObra.ReadOnly = True
        Me.txtNObra.Size = New System.Drawing.Size(120, 21)
        Me.txtNObra.TabIndex = 2
        '
        'calendar
        '
        Me.calendar.AttributeTypeFieldName = "IDTipoTurno"
        Me.calendar.ColorFieldName = "color"
        Me.calendar.Cursor = System.Windows.Forms.Cursors.Default
        Me.calendar.DateFieldName = "Fecha"
        Me.calendar.DayBorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.calendar.DayColor = System.Drawing.Color.White
        Me.calendar.DayTextForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.calendar.DayTypeFieldName = "TipoDia"
        Me.calendar.DescFieldName = "desctipoTurno"
        Me.calendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.calendar.dsAttributes = Nothing
        Me.calendar.dsCalendar = Nothing
        Me.calendar.IDFieldName = "IDTipoTurno"
        Me.calendar.KeyFieldName = "IdObra"
        Me.calendar.Location = New System.Drawing.Point(0, 0)
        Me.calendar.MonthHeaderTextForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.calendar.Name = "calendar"
        Me.calendar.NormalAttributeColor = System.Drawing.Color.White
        Me.calendar.SelectedDayColor = System.Drawing.Color.Gold
        Me.calendar.Size = New System.Drawing.Size(856, 501)
        Me.calendar.TabIndex = 3
        Me.calendar.usrAttributesText = "Turnos"
        '
        'Panelcalendar
        '
        Me.Panelcalendar.Controls.Add(Me.PanelCalen)
        Me.Panelcalendar.Controls.Add(Me.PanelObra)
        Me.Panelcalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelcalendar.Location = New System.Drawing.Point(0, 0)
        Me.Panelcalendar.Name = "Panelcalendar"
        Me.Panelcalendar.Size = New System.Drawing.Size(856, 541)
        Me.Panelcalendar.TabIndex = 4
        '
        'PanelCalen
        '
        Me.PanelCalen.Controls.Add(Me.calendar)
        Me.PanelCalen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCalen.Location = New System.Drawing.Point(0, 40)
        Me.PanelCalen.Name = "PanelCalen"
        Me.PanelCalen.Size = New System.Drawing.Size(856, 501)
        Me.PanelCalen.TabIndex = 1
        '
        'PanelObra
        '
        Me.PanelObra.Controls.Add(Me.ulDescObra)
        Me.PanelObra.Controls.Add(Me.txtNObra)
        Me.PanelObra.Controls.Add(Me.lblObra)
        Me.PanelObra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelObra.Location = New System.Drawing.Point(0, 0)
        Me.PanelObra.Name = "PanelObra"
        Me.PanelObra.Size = New System.Drawing.Size(856, 40)
        Me.PanelObra.TabIndex = 0
        '
        'ulDescObra
        '
        Me.TryDataBinding(ulDescObra, New System.Windows.Forms.Binding("Text", Me, "DescObra", True))
        Me.ulDescObra.Location = New System.Drawing.Point(200, 10)
        Me.ulDescObra.Name = "ulDescObra"
        Me.ulDescObra.Size = New System.Drawing.Size(648, 21)
        Me.ulDescObra.TabIndex = 94
        '
        'MntoCalendarioAlquiler
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(864, 614)
        Me.EntityName = "ObraCabecera"
        Me.Name = "MntoCalendarioAlquiler"
        Me.NavigationFields = "NObra"
        Me.NoEditableControls = New Solmicro.Expertis.Engine.UI.NoEditableControls(New System.Windows.Forms.Control() {Me.txtNObra})
        Me.Text = "MntoCalendarioAlquiler"
        Me.ViewName = "tbObraCabecera"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.Panelcalendar.ResumeLayout(False)
        Me.PanelCalen.ResumeLayout(False)
        Me.PanelObra.ResumeLayout(False)
        Me.PanelObra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " frmCalendarioObra Events "

    Private Sub frmCalendarioObra_Navigated(ByVal sender As Object, ByVal e As Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        Me.calendar.Visible = False
        Me.calendar.Activate = True
        If Me.calendar.dsAttributes Is Nothing Then Me.calendar.dsAttributes = g2.Data
        Me.calendar.dscalendar = g.Data
        Me.calendar.Visible = True
    End Sub

    Private Sub frmCalendarioObra_Navigating(ByVal sender As Object, ByVal e As Engine.UI.NavigatingEventArgs) Handles MyBase.Navigating
        Dim ofilter As Filter = Me.calendar.CreateMonthFilter()
        g.Filter = ofilter
    End Sub

    Private Sub frmCalendarioObra_RecordUpdating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordUpdating
        Try
            Dim oCalObra As New Solmicro.Expertis.Business.Obra.CalendarioObra
            Dim oTable As DataTable = Me.calendar.ModifiedCalendar
            If Not oTable Is Nothing And oTable.Rows.Count > 0 Then
                oCalObra.Update(Me.calendar.Modifiedcalendar)
            End If
        Catch ex As Exception
            e.Cancel = True
            ExpertisApp.GenerateMessage(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub frmCalendarioEmpresa_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordUpdated
        Dim ofilter As Filter = Me.calendar.CreateMonthFilter(True)
        Dim oCalEmpresa As New Solmicro.Expertis.Business.Obra.CalendarioObra
        g.Data = oCalEmpresa.Filter(ofilter)
        Me.calendar.Refreshcalendar(g.Data, True)
    End Sub

#End Region

#Region " Toolbar Events"
    Private Sub CargarCalendario(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles Cancel.Click, Requery.Click
        Me.calendar.dsAttributes = g2.Data
        Me.calendar.Refreshcalendar(g.Data, True)
    End Sub
#End Region

#Region " calendar Events "

    Private Sub calendar_calendarNavigated(ByVal sender As Object, ByVal e As System.EventArgs) Handles calendar.CalendarNavigated
        Dim ofilter As Filter = Me.calendar.CreateMonthFilter(True)
        Dim oCalObra As New Solmicro.Expertis.Business.Obra.CalendarioObra
        g.Data = oCalObra.Filter(ofilter)
        Me.calendar.Refreshcalendar(g.Data)
    End Sub

    Private Sub calendar_calendarChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calendar.CalendarChanged
        Me.RecordsState = RecordsState.Modified
    End Sub

#End Region

End Class
