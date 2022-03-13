<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_horas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cb_dsabado = New System.Windows.Forms.CheckBox()
        Me.cb_dviernes = New System.Windows.Forms.CheckBox()
        Me.cbx_idioma = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbx_pago = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.Label()
        Me.txt_carnet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carnet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idioma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dias_recibir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horas1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pago_parcial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarTablaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global._201800934_IDIOMAS.My.Resources.Resources.FONDO
        Me.GroupBox1.Controls.Add(Me.btn_salir)
        Me.GroupBox1.Controls.Add(Me.btn_calcular)
        Me.GroupBox1.Controls.Add(Me.tabla)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1050, 579)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DE DATOS:"
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(429, 513)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(165, 63)
        Me.btn_calcular.TabIndex = 9
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'tabla
        '
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.registro, Me.carnet, Me.nombre, Me.fecha1, Me.pago, Me.idioma, Me.dias_recibir, Me.horas1, Me.pago_parcial, Me.descuento1, Me.descuento2, Me.total})
        Me.tabla.Location = New System.Drawing.Point(7, 309)
        Me.tabla.Name = "tabla"
        Me.tabla.RowHeadersWidth = 62
        Me.tabla.RowTemplate.Height = 28
        Me.tabla.Size = New System.Drawing.Size(1026, 184)
        Me.tabla.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_horas)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.cbx_idioma)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(567, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(362, 252)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS CURSO:"
        '
        'txt_horas
        '
        Me.txt_horas.Location = New System.Drawing.Point(161, 90)
        Me.txt_horas.Name = "txt_horas"
        Me.txt_horas.Size = New System.Drawing.Size(180, 25)
        Me.txt_horas.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Horas a recibir:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cb_dsabado)
        Me.GroupBox4.Controls.Add(Me.cb_dviernes)
        Me.GroupBox4.Location = New System.Drawing.Point(102, 131)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(164, 105)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dias del curso:"
        '
        'cb_dsabado
        '
        Me.cb_dsabado.AutoSize = True
        Me.cb_dsabado.Location = New System.Drawing.Point(31, 75)
        Me.cb_dsabado.Name = "cb_dsabado"
        Me.cb_dsabado.Size = New System.Drawing.Size(79, 22)
        Me.cb_dsabado.TabIndex = 1
        Me.cb_dsabado.Text = "Sabado"
        Me.cb_dsabado.UseVisualStyleBackColor = True
        '
        'cb_dviernes
        '
        Me.cb_dviernes.AutoSize = True
        Me.cb_dviernes.Location = New System.Drawing.Point(31, 39)
        Me.cb_dviernes.Name = "cb_dviernes"
        Me.cb_dviernes.Size = New System.Drawing.Size(83, 22)
        Me.cb_dviernes.TabIndex = 0
        Me.cb_dviernes.Text = "Viernes"
        Me.cb_dviernes.UseVisualStyleBackColor = True
        '
        'cbx_idioma
        '
        Me.cbx_idioma.FormattingEnabled = True
        Me.cbx_idioma.Items.AddRange(New Object() {"Ingles", "Portugues", "Frances"})
        Me.cbx_idioma.Location = New System.Drawing.Point(161, 38)
        Me.cbx_idioma.Name = "cbx_idioma"
        Me.cbx_idioma.Size = New System.Drawing.Size(180, 26)
        Me.cbx_idioma.TabIndex = 10
        Me.cbx_idioma.Text = "Seleccionar idioma..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Curso:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbx_pago)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.fecha)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_nom)
        Me.GroupBox2.Controls.Add(Me.txt_nombre)
        Me.GroupBox2.Controls.Add(Me.txt_carnet)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(102, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 252)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS GENERALES:"
        '
        'cbx_pago
        '
        Me.cbx_pago.FormattingEnabled = True
        Me.cbx_pago.Items.AddRange(New Object() {"Efectivo", "Cheque"})
        Me.cbx_pago.Location = New System.Drawing.Point(174, 201)
        Me.cbx_pago.Name = "cbx_pago"
        Me.cbx_pago.Size = New System.Drawing.Size(180, 26)
        Me.cbx_pago.TabIndex = 13
        Me.cbx_pago.Text = "Seleccionar tipo pago..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Metodo de pago:"
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(174, 153)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(180, 25)
        Me.fecha.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha incripcion:"
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(174, 95)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(180, 25)
        Me.txt_nom.TabIndex = 9
        '
        'txt_nombre
        '
        Me.txt_nombre.AutoSize = True
        Me.txt_nombre.Location = New System.Drawing.Point(19, 95)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(62, 18)
        Me.txt_nombre.TabIndex = 8
        Me.txt_nombre.Text = "Nombre:"
        '
        'txt_carnet
        '
        Me.txt_carnet.Location = New System.Drawing.Point(174, 38)
        Me.txt_carnet.Name = "txt_carnet"
        Me.txt_carnet.Size = New System.Drawing.Size(180, 25)
        Me.txt_carnet.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Carnet:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 35)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1075, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'registro
        '
        Me.registro.HeaderText = "No."
        Me.registro.MinimumWidth = 8
        Me.registro.Name = "registro"
        Me.registro.Width = 150
        '
        'carnet
        '
        Me.carnet.HeaderText = "Carnet"
        Me.carnet.MinimumWidth = 8
        Me.carnet.Name = "carnet"
        Me.carnet.Width = 150
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.MinimumWidth = 8
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 150
        '
        'fecha1
        '
        Me.fecha1.HeaderText = "Fecha"
        Me.fecha1.MinimumWidth = 8
        Me.fecha1.Name = "fecha1"
        Me.fecha1.Width = 150
        '
        'pago
        '
        Me.pago.HeaderText = "Tipo Pago"
        Me.pago.MinimumWidth = 8
        Me.pago.Name = "pago"
        Me.pago.Width = 150
        '
        'idioma
        '
        Me.idioma.HeaderText = "Idioma"
        Me.idioma.MinimumWidth = 8
        Me.idioma.Name = "idioma"
        Me.idioma.Width = 150
        '
        'dias_recibir
        '
        Me.dias_recibir.HeaderText = "Dias "
        Me.dias_recibir.MinimumWidth = 8
        Me.dias_recibir.Name = "dias_recibir"
        Me.dias_recibir.Width = 150
        '
        'horas1
        '
        Me.horas1.HeaderText = "Horas"
        Me.horas1.MinimumWidth = 8
        Me.horas1.Name = "horas1"
        Me.horas1.Width = 150
        '
        'pago_parcial
        '
        Me.pago_parcial.HeaderText = "Pago Parcial"
        Me.pago_parcial.MinimumWidth = 8
        Me.pago_parcial.Name = "pago_parcial"
        Me.pago_parcial.Width = 150
        '
        'descuento1
        '
        Me.descuento1.HeaderText = "Descuento 1"
        Me.descuento1.MinimumWidth = 8
        Me.descuento1.Name = "descuento1"
        Me.descuento1.Width = 150
        '
        'descuento2
        '
        Me.descuento2.HeaderText = "Descuento 2 "
        Me.descuento2.MinimumWidth = 8
        Me.descuento2.Name = "descuento2"
        Me.descuento2.Width = 150
        '
        'total
        '
        Me.total.HeaderText = "Pago Total"
        Me.total.MinimumWidth = 8
        Me.total.Name = "total"
        Me.total.Width = 150
        '
        'MenuStrip2
        '
        Me.MenuStrip2.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.LimpiarTablaToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1075, 35)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(86, 29)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'LimpiarTablaToolStripMenuItem
        '
        Me.LimpiarTablaToolStripMenuItem.Name = "LimpiarTablaToolStripMenuItem"
        Me.LimpiarTablaToolStripMenuItem.Size = New System.Drawing.Size(131, 29)
        Me.LimpiarTablaToolStripMenuItem.Text = "Limpiar Tabla"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(868, 513)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(165, 63)
        Me.btn_salir.TabIndex = 10
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1075, 650)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Font = New System.Drawing.Font("Modern No. 20", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "SISTEMA"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_nombre As Label
    Friend WithEvents txt_carnet As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_horas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cb_dsabado As CheckBox
    Friend WithEvents cb_dviernes As CheckBox
    Friend WithEvents cbx_idioma As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_pago As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_calcular As Button
    Friend WithEvents tabla As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents registro As DataGridViewTextBoxColumn
    Friend WithEvents carnet As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents fecha1 As DataGridViewTextBoxColumn
    Friend WithEvents pago As DataGridViewTextBoxColumn
    Friend WithEvents idioma As DataGridViewTextBoxColumn
    Friend WithEvents dias_recibir As DataGridViewTextBoxColumn
    Friend WithEvents horas1 As DataGridViewTextBoxColumn
    Friend WithEvents pago_parcial As DataGridViewTextBoxColumn
    Friend WithEvents descuento1 As DataGridViewTextBoxColumn
    Friend WithEvents descuento2 As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarTablaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_salir As Button
End Class
