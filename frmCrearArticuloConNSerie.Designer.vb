<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearArticuloConNSerie
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearArticuloConNSerie))
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblnSerie = New Solmicro.Expertis.Engine.UI.Label
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.bAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.bCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.advArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.txtNSerie = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cBFechaCaducidad = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.advAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.UnderLineLabel1 = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(20, 32)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 0
        Me.lblArticulo.Text = "Articulo"
        '
        'lblnSerie
        '
        Me.lblnSerie.Location = New System.Drawing.Point(20, 72)
        Me.lblnSerie.Name = "lblnSerie"
        Me.lblnSerie.Size = New System.Drawing.Size(55, 13)
        Me.lblnSerie.TabIndex = 1
        Me.lblnSerie.Text = "Nº Serie"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FechaCaducidad"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(144, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 3
        '
        'bAceptar
        '
        Me.bAceptar.Icon = CType(resources.GetObject("bAceptar.Icon"), System.Drawing.Icon)
        Me.bAceptar.Location = New System.Drawing.Point(386, 260)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(75, 23)
        Me.bAceptar.TabIndex = 4
        Me.bAceptar.Text = "Aceptar"
        '
        'bCancelar
        '
        Me.bCancelar.Icon = CType(resources.GetObject("bCancelar.Icon"), System.Drawing.Icon)
        Me.bCancelar.Location = New System.Drawing.Point(44, 260)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(75, 23)
        Me.bCancelar.TabIndex = 5
        Me.bCancelar.Text = "Cancelar"
        '
        'advArticulo
        '
        Me.advArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advArticulo.DisplayField = "IDArticulo"
        Me.advArticulo.EntityName = "Articulo"
        Me.advArticulo.Location = New System.Drawing.Point(151, 26)
        Me.advArticulo.Name = "advArticulo"
        Me.advArticulo.SecondaryDataFields = "IDArticulo"
        Me.advArticulo.Size = New System.Drawing.Size(100, 23)
        Me.advArticulo.TabIndex = 6
        Me.advArticulo.ViewName = "tbMaestroArticulo"
        '
        'ulArticulo
        '
        Me.ulArticulo.AutoSize = True
        Me.ulArticulo.Location = New System.Drawing.Point(268, 32)
        Me.ulArticulo.Name = "ulArticulo"
        Me.ulArticulo.Size = New System.Drawing.Size(133, 13)
        Me.ulArticulo.TabIndex = 7
        Me.ulArticulo.Text = "__________________"
        '
        'txtNSerie
        '
        Me.txtNSerie.DisabledBackColor = System.Drawing.Color.White
        Me.txtNSerie.Location = New System.Drawing.Point(151, 72)
        Me.txtNSerie.Name = "txtNSerie"
        Me.txtNSerie.Size = New System.Drawing.Size(100, 21)
        Me.txtNSerie.TabIndex = 8
        '
        'cBFechaCaducidad
        '
        Me.cBFechaCaducidad.DisabledBackColor = System.Drawing.Color.White
        Me.cBFechaCaducidad.Location = New System.Drawing.Point(151, 114)
        Me.cBFechaCaducidad.Name = "cBFechaCaducidad"
        Me.cBFechaCaducidad.Size = New System.Drawing.Size(100, 21)
        Me.cBFechaCaducidad.TabIndex = 9
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.UnderLineLabel1)
        Me.Frame1.Controls.Add(Me.advAlmacen)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.lblArticulo)
        Me.Frame1.Controls.Add(Me.cBFechaCaducidad)
        Me.Frame1.Controls.Add(Me.lblnSerie)
        Me.Frame1.Controls.Add(Me.txtNSerie)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.ulArticulo)
        Me.Frame1.Controls.Add(Me.advArticulo)
        Me.Frame1.Location = New System.Drawing.Point(44, 39)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(417, 191)
        Me.Frame1.TabIndex = 10
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Creación activo"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Almacén"
        '
        'advAlmacen
        '
        Me.advAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advAlmacen.DisplayField = "IDAlmacen"
        Me.advAlmacen.EntityName = "Almacen"
        Me.advAlmacen.Location = New System.Drawing.Point(151, 150)
        Me.advAlmacen.Name = "advAlmacen"
        Me.advAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advAlmacen.Size = New System.Drawing.Size(100, 23)
        Me.advAlmacen.TabIndex = 11
        Me.advAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'UnderLineLabel1
        '
        Me.UnderLineLabel1.AutoSize = True
        Me.UnderLineLabel1.Location = New System.Drawing.Point(268, 160)
        Me.UnderLineLabel1.Name = "UnderLineLabel1"
        Me.UnderLineLabel1.Size = New System.Drawing.Size(133, 13)
        Me.UnderLineLabel1.TabIndex = 12
        Me.UnderLineLabel1.Text = "__________________"
        '
        'frmCrearArticuloConNSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 317)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.bCancelar)
        Me.Name = "frmCrearArticuloConNSerie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crea Activo con Nº Serie"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblnSerie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents bAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents bCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents advArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents txtNSerie As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cBFechaCaducidad As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents UnderLineLabel1 As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
End Class
