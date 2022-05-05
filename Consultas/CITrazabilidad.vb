Imports Janus.Windows.UI
Public Class CITrazabilidad
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtDescObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents TrwTrazabilidad As System.Windows.Forms.TreeView
    Friend WithEvents pnlTop As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblAlquiler As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents mnuAlbaran2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuOrdenServicio2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuArbol As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents mnuAlbaran As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuOrdenServicio As Janus.Windows.UI.CommandBars.UICommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CITrazabilidad))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblAlquiler = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TrwTrazabilidad = New System.Windows.Forms.TreeView
        Me.mnuAlbaran2 = New Janus.Windows.UI.CommandBars.UICommand("mnuAlbaran")
        Me.mnuOrdenServicio2 = New Janus.Windows.UI.CommandBars.UICommand("mnuOrdenServicio")
        Me.mnuArbol = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.mnuAlbaran = New Janus.Windows.UI.CommandBars.UICommand("mnuAlbaran")
        Me.mnuOrdenServicio = New Janus.Windows.UI.CommandBars.UICommand("mnuOrdenServicio")
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.pnlTop.suspendlayout()
        CType(Me.mnuArbol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Duplicate
        '
        Me.Duplicate.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(591, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuAlbaran2, Me.mnuOrdenServicio2})
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.mnuArbol})
        '
        'GoFirst
        '
        Me.GoFirst.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'GoPrevious
        '
        Me.GoPrevious.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'GoNext
        '
        Me.GoNext.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Delete
        '
        Me.Delete.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.Delete.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Ok
        '
        Me.Ok.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.Ok.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Cancel
        '
        Me.Cancel.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.Cancel.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Print
        '
        Me.Print.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.Print.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Search
        '
        Me.Search.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'GoLast
        '
        Me.GoLast.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'FindText
        '
        Me.FindText.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Find
        '
        Me.Find.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'NewRow
        '
        Me.NewRow.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.NewRow.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Requery
        '
        Me.Requery.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TrwTrazabilidad)
        Me.MainPanel.Controls.Add(Me.pnlTop)
        Me.MainPanel.Size = New System.Drawing.Size(595, 344)
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.txtDescObra)
        Me.pnlTop.Controls.Add(Me.lblAlquiler)
        Me.pnlTop.Controls.Add(Me.txtNObra)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(595, 31)
        Me.pnlTop.TabIndex = 6
        '
        'txtDescObra
        '
        Me.TryDataBinding(txtDescObra, New System.Windows.Forms.Binding("Text", Me, "DescObra", True))
        Me.txtDescObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescObra.Enabled = False
        Me.txtDescObra.Location = New System.Drawing.Point(199, 4)
        Me.txtDescObra.Name = "txtDescObra"
        Me.txtDescObra.Size = New System.Drawing.Size(392, 21)
        Me.txtDescObra.TabIndex = 9
        '
        'lblAlquiler
        '
        Me.lblAlquiler.Location = New System.Drawing.Point(5, 8)
        Me.lblAlquiler.Name = "lblAlquiler"
        Me.lblAlquiler.Size = New System.Drawing.Size(68, 13)
        Me.lblAlquiler.TabIndex = 8
        Me.lblAlquiler.Text = "Nº Alquiler"
        '
        'txtNObra
        '
        Me.TryDataBinding(txtNObra, New System.Windows.Forms.Binding("Text", Me, "NObra", True))
        Me.txtNObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtNObra.Enabled = False
        Me.txtNObra.Location = New System.Drawing.Point(74, 4)
        Me.txtNObra.Name = "txtNObra"
        Me.txtNObra.Size = New System.Drawing.Size(122, 21)
        Me.txtNObra.TabIndex = 7
        '
        'TrwTrazabilidad
        '
        Me.TrwTrazabilidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrwTrazabilidad.Location = New System.Drawing.Point(0, 31)
        Me.TrwTrazabilidad.Name = "TrwTrazabilidad"
        Me.TrwTrazabilidad.Size = New System.Drawing.Size(595, 313)
        Me.TrwTrazabilidad.TabIndex = 7
        '
        'mnuAlbaran2
        '
        Me.mnuAlbaran2.Icon = CType(resources.GetObject("mnuAlbaran2.Icon"), System.Drawing.Icon)
        Me.mnuAlbaran2.Key = "mnuAlbaran"
        Me.mnuAlbaran2.Name = "mnuAlbaran2"
        Me.mnuAlbaran2.Text = "Abrir Albarán"
        '
        'mnuOrdenServicio2
        '
        Me.mnuOrdenServicio2.Icon = CType(resources.GetObject("mnuOrdenServicio2.Icon"), System.Drawing.Icon)
        Me.mnuOrdenServicio2.Key = "mnuOrdenServicio"
        Me.mnuOrdenServicio2.Name = "mnuOrdenServicio2"
        Me.mnuOrdenServicio2.Text = "Abrir Orden de Servicio"
        '
        'mnuArbol
        '
        Me.mnuArbol.CommandManager = Me.UiCommandManager1
        Me.mnuArbol.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuAlbaran, Me.mnuOrdenServicio})
        Me.mnuArbol.Key = "mnuArbol"
        '
        'mnuAlbaran
        '
        Me.mnuAlbaran.Key = "mnuAlbaran"
        Me.mnuAlbaran.Name = "mnuAlbaran"
        '
        'mnuOrdenServicio
        '
        Me.mnuOrdenServicio.Key = "mnuOrdenServicio"
        Me.mnuOrdenServicio.Name = "mnuOrdenServicio"
        '
        'CITrazabilidad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(603, 417)
        Me.EntityName = "ObraCabecera"
        Me.Name = "CITrazabilidad"
        Me.NavigationFields = "NObra"
        Me.ViewName = "tbObraCabecera"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.mnuArbol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mstrTipoFacturacionDeposito, mstrTipoAlbaranPorDefecto As String
    Private mIDTrabajoParams As Integer
    Private mIDAlbaran, mIDTrabajo, IDObra As Integer

#Region " Load "

    Private Sub CITrazabilidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadToolbarActions()
            LoadERPData()
            LoadParams()
        End If
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            Dim ht As Hashtable = Me.Params
            If ht.ContainsKey("IDTrabajo") AndAlso length(ht("IDTrabajo")) > 0 Then
                mIDTrabajoParams = ht("IDTrabajo")
            End If
        End If
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Explosión árbol", AddressOf AccionExplosionArbol)
        Me.FormActions.Add("Implosión árbol", AddressOf AccionImplosionArbol)
        Me.AddSeparator()
        Me.FormActions.Add(cnABRIRALQUILER, AddressOf AccionAbrirAlquiler, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub LoadERPData()
        Dim p As New Parametro
        mstrTipoFacturacionDeposito = p.TipoAlbaranDeDeposito
        mstrTipoAlbaranPorDefecto = p.TipoAlbaranPorDefecto
        Me.FilterCriteria = New NumberFilterItem("TipoMnto", CInt(enumTipoObra.tpalquiler))
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub AccionExplosionArbol()
        TrwTrazabilidad.ExpandAll()
    End Sub

    Private Sub AccionImplosionArbol()
        TrwTrazabilidad.CollapseAll()
    End Sub

    Private Sub AccionAbrirAlquiler()
        AbrirMntoAlquiler(Me.CurrentRow("IDObra"))
    End Sub

#End Region

    Private Sub CITrazabilidad_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        If length(Me.CurrentRow("IDObra")) > 0 Then
            PintarArbol()
            mIDTrabajoParams = 0
        End If
    End Sub

    Private Sub PintarArbol()
        Dim strDescUDInterna As String = String.Empty
        Dim ndNodoTrabajo, ndNodoADeposito, ndNodoAConsumo, ndNodoAvisoRet As TreeNode

        If Not TrwTrazabilidad.Enabled Then TrwTrazabilidad.Enabled = True
        TrwTrazabilidad.ImageList = ImageList1
        TrwTrazabilidad.Nodes.Clear()

        Dim f As New Filter
        f.Add(New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")))
        If mIDTrabajoParams > 0 Then
            f.Add(New NumberFilterItem("IDTrabajo", mIDTrabajoParams))
        End If
        f.Add(New NumberFilterItem("Nivel", 0))

        Dim dtOT As DataTable = New ObraTrabajo().Filter(f, , "IDTrabajo,CodTrabajo,PedidoCliente,IDOrigen,Nivel,IDObra")
        If Not IsNothing(dtOT) AndAlso dtOT.Rows.Count > 0 Then
            Dim P As New Parametro
            Dim ALBARANCONSUMO As String = P.TipoAlbaranDeConsumo()
            Dim ALBARANRETORNO As String = P.TipoAlbaranRetornoAlquiler()

            Dim c As New BE.DataEngine
            For Each drOT As DataRow In dtOT.Rows
                f.Clear()
                f.Add(New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")))
                If Length(drOT("IDOrigen")) > 0 AndAlso drOT("IDOrigen") > 0 Then
                    f.Add(New NumberFilterItem("IDTrabajo", drOT("IDOrigen")))
                End If
                Dim f_OR As New Filter(FilterUnionOperator.Or)
                f_OR.Add(New NumberFilterItem("IDTipoAlbaran", mstrTipoFacturacionDeposito))
                f_OR.Add(New NumberFilterItem("IDTipoAlbaran", mstrTipoAlbaranPorDefecto))
                f.Add(f_OR)

                Dim dtADeposito As DataTable = c.Filter("vAlquilerCISeguimiento", f)

                Dim strTextoADeposito As String = ExpertisApp.Traslate("Albarán Depósito") & " : "
                Dim strTextoAConsumo As String = ExpertisApp.Traslate("Albarán Consumo") & " : "
                Dim strTextoARetorno As String = ExpertisApp.Traslate("Albarán Retorno") & " : "
                Dim strTextoLote As String = ExpertisApp.Traslate("Lote") & " : "

                If Not IsNothing(dtADeposito) AndAlso dtADeposito.Rows.Count > 0 Then
                    Dim strNodeText As String = drOT("CodTrabajo") & "-" & drOT("PedidoCliente")
                    ndNodoTrabajo = TrwTrazabilidad.Nodes.Add(strNodeText)
                    ndNodoTrabajo.ImageIndex = 0
                    ndNodoTrabajo.SelectedImageIndex = 0
                    ndNodoTrabajo.Tag = New TagArbol(drOT("IdTrabajo"), drOT("IDObra"))
                    ndNodoTrabajo.Expand()

                    'CARGAR LOS NODOS DE LOS ALBARANES DE SALIDA
                    For Each drADeposito As DataRow In dtADeposito.Rows
                        'Se completa el texto que se va a poner en el nodo
                        strNodeText = strTextoADeposito & drADeposito("NAlbaran") & Space(3)
                        strNodeText = strNodeText & drADeposito("FechaAlbaran") & Space(3)
                        strNodeText = strNodeText & drADeposito("IDArticulo") & Space(1)
                        strNodeText = strNodeText & "-" & Space(1) & drADeposito("DescArticulo") & Space(3)
                        strNodeText = strNodeText & drADeposito("QServida") & Space(1)
                        strNodeText = strNodeText & drADeposito("DescUdInterna") & Space(3)
                        strNodeText = strNodeText & strTextoLote & drADeposito("Lote") & Space(3)
                        strNodeText = strNodeText & ExpertisApp.Traslate("F.Alquiler: ") & drADeposito("FechaAlquiler") & Space(3)
                        strNodeText = strNodeText & Format(drADeposito("ImpTotal"), "#,##0.00") & Space(1)
                        strNodeText = strNodeText & drADeposito("Abreviatura")

                        'Se añade el nodo a la estructura de arbol
                        strDescUDInterna = drADeposito("DescUdInterna") & String.Empty
                        ndNodoADeposito = ndNodoTrabajo.Nodes.Add(strNodeText)
                        ndNodoADeposito.ImageIndex = 1
                        ndNodoADeposito.SelectedImageIndex = 1
                        ndNodoADeposito.Tag = New TagArbol(drADeposito("IDAlbaran"))
                        ndNodoADeposito.Expand()

                        'Una vez que se ha añadido el nodo a la estructura de árbol, deberemos revisar en la misma
                        'línea si existe un aviso de retorno activo.
                        If Length(drADeposito("ARNalbaranRecogida")) > 0 Then
                            strNodeText = ExpertisApp.Traslate("Aviso Retorno : ") & drADeposito("ARNalbaranRecogida") & Space(3)
                            strNodeText = strNodeText & drADeposito("NAlbaran") & Space(3)
                            strNodeText = strNodeText & ExpertisApp.Traslate("F.Aviso Retorno: ") & drADeposito("ARFechaAvisoRecogida") & Space(3)
                            strNodeText = strNodeText & ExpertisApp.Traslate("F.Prev.Retorno: ") & drADeposito("ARFechaPrevistaRetorno") & Space(3)
                            strNodeText = strNodeText & drADeposito("ARQAvisoRetorno") & Space(1)
                            strNodeText = strNodeText & strDescUDInterna & Space(3)
                            strNodeText = strNodeText & strTextoLote & drADeposito("Lote")

                            ndNodoAvisoRet = ndNodoADeposito.Nodes.Add(strNodeText)
                            ndNodoAvisoRet.ImageIndex = 3
                            ndNodoAvisoRet.SelectedImageIndex = 3
                            ndNodoAvisoRet.Tag = New TagArbol(drADeposito("IDAlbaran"))
                            ndNodoAvisoRet.Expand()
                        End If

                        'Ahora se van a analizar todos los retornos que tengan avisos de retorno.
                        Dim fAvisos As New Filter
                        If Length(drADeposito("IDLineaAlbaran")) > 0 Then
                            fAvisos.Add(New NumberFilterItem("IDLineaAlbaran", drADeposito("IDLineaAlbaran")))
                        End If
                        Dim dtAAviso As DataTable = c.Filter("vAlquilerCISeguimientoAvisos", fAvisos)
                        If Not IsNothing(dtAAviso) AndAlso dtAAviso.Rows.Count > 0 Then
                            For Each drAAviso As DataRow In dtAAviso.Rows
                                strNodeText = ExpertisApp.Traslate("Aviso Retorno : ") & drAAviso("ARNalbaranRecogida") & Space(3)
                                strNodeText = strNodeText & drAAviso("NAlbaran") & Space(3)
                                strNodeText = strNodeText & ExpertisApp.Traslate("F.Aviso Retorno: ") & drAAviso("ARFechaAvisoRecogida") & Space(3)
                                strNodeText = strNodeText & ExpertisApp.Traslate("F.Prev.Retorno: ") & drAAviso("ARFechaPrevistaRetorno") & Space(3)
                                strNodeText = strNodeText & drAAviso("ARQAvisoRetorno") & Space(1)
                                strNodeText = strNodeText & strDescUDInterna & Space(3)
                                strNodeText = strNodeText & strTextoLote & drAAviso("Lote")

                                ndNodoAvisoRet = ndNodoADeposito.Nodes.Add(strNodeText)
                                ndNodoAvisoRet.ImageIndex = 4
                                ndNodoAvisoRet.SelectedImageIndex = 4
                                ndNodoAvisoRet.Tag = New TagArbol(drAAviso("IDAlbaran"))
                                ndNodoAvisoRet.Expand()

                                If drAAviso("RetornoIDTipoAlbaran") = ALBARANCONSUMO Then
                                    strNodeText = strTextoAConsumo & drAAviso("RetornoIDAlbaran") & Space(3)
                                ElseIf drAAviso("RetornoIDTipoAlbaran") = ALBARANRETORNO Then
                                    strNodeText = strTextoARetorno & drAAviso("RetornoIDAlbaran") & Space(3)
                                End If
                                strNodeText = strNodeText & drAAviso("RetornoFechaAlbaran") & Space(3)
                                strNodeText = strNodeText & drAAviso("RetornoIDArticulo") & Space(1)
                                strNodeText = strNodeText & "-" & Space(1) & drAAviso("RetornoDescArticulo") & Space(3)
                                strNodeText = strNodeText & drAAviso("RetornoQInterna") & Space(1)
                                strNodeText = strNodeText & strDescUDInterna & Space(1) & "("
                                strNodeText = strNodeText & drAAviso("RetornoQServida") & Space(1)
                                strNodeText = strNodeText & drAAviso("RetornoDescUdMedida") & ")" & Space(3)
                                strNodeText = strNodeText & ExpertisApp.Traslate("Lote: ") & drAAviso("RetornoLote") & Space(3)
                                strNodeText = strNodeText & Format(drAAviso("RetornoImpTotal"), "#,##0.00") & Space(1)
                                strNodeText = strNodeText & drAAviso("RetornoAbreviatura")

                                ndNodoAConsumo = ndNodoAvisoRet.Nodes.Add(strNodeText)
                                ndNodoAConsumo.ImageIndex = 2
                                ndNodoAConsumo.SelectedImageIndex = 2
                                ndNodoAConsumo.Tag = New TagArbol(drAAviso("RetornoIDAlbaran"))
                                ndNodoAConsumo.Expand()
                            Next
                        End If
                        Dim fSinAvisos As New Filter
                        If Length(drADeposito("IDLineaMaterial")) > 0 Then
                            fSinAvisos.Add(New NumberFilterItem("IDLineaMaterial", drADeposito("IDLineaMaterial")))
                        End If
                        If Length(drADeposito("IDLineaAlbaran")) > 0 Then
                            fSinAvisos.Add(New NumberFilterItem("IDLineaAlbaranDeposito", drADeposito("IDLineaAlbaran")))
                        End If
                        Dim dtAConsumo As DataTable = c.Filter("vAlquilerCISeguimientoSinAvisos", fSinAvisos)
                        If Not IsNothing(dtAConsumo) AndAlso dtAConsumo.Rows.Count > 0 Then
                            For Each drAConsumo As DataRow In dtAConsumo.Rows
                                If drAConsumo("IDTipoAlbaran") = ALBARANCONSUMO Then
                                    strNodeText = strTextoAConsumo & drAConsumo("NAlbaran") & Space(3)
                                ElseIf drAConsumo("IDTipoAlbaran") = ALBARANRETORNO Then
                                    strNodeText = strTextoARetorno & drAConsumo("NAlbaran") & Space(3)
                                End If
                                strNodeText = strNodeText & drAConsumo("FechaAlbaran") & Space(3)
                                strNodeText = strNodeText & drAConsumo("IDArticulo") & Space(1)
                                strNodeText = strNodeText & "-" & Space(1) & drAConsumo("DescArticulo") & Space(3)
                                strNodeText = strNodeText & drAConsumo("QInterna") & Space(1)
                                strNodeText = strNodeText & strDescUDInterna & Space(1) & "("
                                strNodeText = strNodeText & drAConsumo("QServida") & Space(1)
                                strNodeText = strNodeText & drAConsumo("DescUdMedida") & ")" & Space(3)
                                strNodeText = strNodeText & ExpertisApp.Traslate("Lote: ") & drAConsumo("Lote") & Space(3)
                                strNodeText = strNodeText & Format(drAConsumo("ImpTotal"), "#,##0.00") & Space(1)
                                strNodeText = strNodeText & drAConsumo("Abreviatura")

                                ndNodoAConsumo = ndNodoADeposito.Nodes.Add(strNodeText)
                                ndNodoAConsumo.ImageIndex = 2
                                ndNodoAConsumo.SelectedImageIndex = 2
                                ndNodoAConsumo.Tag = New TagArbol(drAConsumo("IDAlbaran"))
                                ndNodoAConsumo.Expand()
                            Next
                        End If
                    Next
                End If
            Next
        End If

        TrwTrazabilidad.ExpandAll()
        TrwTrazabilidad.Refresh()
    End Sub

    Private Sub TrwTrazabilidad_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrwTrazabilidad.MouseDown
        If e.Button = MouseButtons.Right Then
            mIDAlbaran = -1
            mIDTrabajo = -1

            Dim n As TreeNode = TrwTrazabilidad.GetNodeAt(e.X, e.Y)
            If Not IsNothing(n) Then
                mIDAlbaran = CType(n.Tag, TagArbol).IDAlbaran
                mIDTrabajo = CType(n.Tag, TagArbol).IDTrabajo
                IDObra = CType(n.Tag, TagArbol).IDObra
            End If

            If (mIDAlbaran > 0) Then
                mnuAlbaran.Visible = InheritableBoolean.True
            Else
                mnuAlbaran.Visible = InheritableBoolean.False
            End If
            If (mIDTrabajo > 0) Then
                mnuOrdenServicio.Visible = InheritableBoolean.True
            Else
                mnuOrdenServicio.Visible = InheritableBoolean.False
            End If

            mnuArbol.Show()
        End If
    End Sub

#Region " Acciones árbol "

    Private Sub mnuAlbaran_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuAlbaran.Click
        If mIDAlbaran > 0 Then AbrirMntoAlbaranVenta(mIDAlbaran)
    End Sub

    Private Sub mnuOrdenServicio_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuOrdenServicio.Click
        If mIDTrabajo > 0 Then AbrirOrdenServicio(mIDTrabajo, IDObra)
    End Sub

#End Region

#Region " TAGs "

    Private Class TagArbol
        Public IDTrabajo, IDObra, IDAlbaran As Integer

        Public Sub New(ByVal IDAlbaran As Integer)
            Me.IDAlbaran = IDAlbaran
        End Sub
        Public Sub New(ByVal IDTrabajo As Integer, ByVal IDObra As Integer)
            Me.IDTrabajo = IDTrabajo
            Me.IDObra = IDObra
        End Sub
    End Class

#End Region

End Class
