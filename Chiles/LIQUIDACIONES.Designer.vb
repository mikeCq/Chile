<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LIQUIDACIONES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LIQUIDACIONES))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsConsultar = New System.Windows.Forms.ToolStripButton()
        Me.TxIdProduccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxCantidadBotes = New System.Windows.Forms.TextBox()
        Me.NuPrecio = New System.Windows.Forms.NumericUpDown()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GbLiquidacion = New System.Windows.Forms.GroupBox()
        Me.CbProducto = New System.Windows.Forms.ComboBox()
        Me.DgBotesIngresados = New System.Windows.Forms.DataGridView()
        Me.DgProducciones = New System.Windows.Forms.DataGridView()
        Me.BtAgregar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbTotal = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.NuPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbLiquidacion.SuspendLayout()
        CType(Me.DgBotesIngresados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgProducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsNuevo, Me.ToolStripButton2, Me.TsGuardar, Me.ToolStripButton4, Me.TsImprimir, Me.ToolStripSeparator1, Me.TsConsultar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1041, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TsNuevo
        '
        Me.TsNuevo.Image = Global.Chiles.My.Resources.Resources.Nuevo
        Me.TsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsNuevo.Name = "TsNuevo"
        Me.TsNuevo.Size = New System.Drawing.Size(62, 22)
        Me.TsNuevo.Text = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(6, 25)
        '
        'TsGuardar
        '
        Me.TsGuardar.Image = Global.Chiles.My.Resources.Resources.Guardar
        Me.TsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsGuardar.Name = "TsGuardar"
        Me.TsGuardar.Size = New System.Drawing.Size(69, 22)
        Me.TsGuardar.Text = "Guardar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(6, 25)
        '
        'TsImprimir
        '
        Me.TsImprimir.Image = CType(resources.GetObject("TsImprimir.Image"), System.Drawing.Image)
        Me.TsImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsImprimir.Name = "TsImprimir"
        Me.TsImprimir.Size = New System.Drawing.Size(73, 22)
        Me.TsImprimir.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TsConsultar
        '
        Me.TsConsultar.Image = Global.Chiles.My.Resources.Resources.Consultar
        Me.TsConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsConsultar.Name = "TsConsultar"
        Me.TsConsultar.Size = New System.Drawing.Size(78, 22)
        Me.TsConsultar.Text = "Consultar"
        '
        'TxIdProduccion
        '
        Me.TxIdProduccion.Location = New System.Drawing.Point(74, 12)
        Me.TxIdProduccion.Name = "TxIdProduccion"
        Me.TxIdProduccion.Size = New System.Drawing.Size(121, 20)
        Me.TxIdProduccion.TabIndex = 1
        Me.TxIdProduccion.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'DtFecha
        '
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(74, 50)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(121, 20)
        Me.DtFecha.TabIndex = 3
        '
        'TxCantidadBotes
        '
        Me.TxCantidadBotes.Location = New System.Drawing.Point(478, 16)
        Me.TxCantidadBotes.Name = "TxCantidadBotes"
        Me.TxCantidadBotes.Size = New System.Drawing.Size(121, 20)
        Me.TxCantidadBotes.TabIndex = 4
        '
        'NuPrecio
        '
        Me.NuPrecio.DecimalPlaces = 2
        Me.NuPrecio.Location = New System.Drawing.Point(274, 16)
        Me.NuPrecio.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NuPrecio.Name = "NuPrecio"
        Me.NuPrecio.Size = New System.Drawing.Size(114, 20)
        Me.NuPrecio.TabIndex = 5
        Me.NuPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(668, 15)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Precio :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(405, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Botes :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(819, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Producto :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(614, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Estatus :"
        '
        'GbLiquidacion
        '
        Me.GbLiquidacion.Controls.Add(Me.CbProducto)
        Me.GbLiquidacion.Controls.Add(Me.Label5)
        Me.GbLiquidacion.Controls.Add(Me.Label6)
        Me.GbLiquidacion.Controls.Add(Me.TxIdProduccion)
        Me.GbLiquidacion.Controls.Add(Me.Label2)
        Me.GbLiquidacion.Controls.Add(Me.Label4)
        Me.GbLiquidacion.Controls.Add(Me.DtFecha)
        Me.GbLiquidacion.Controls.Add(Me.Label3)
        Me.GbLiquidacion.Controls.Add(Me.TxCantidadBotes)
        Me.GbLiquidacion.Controls.Add(Me.NuPrecio)
        Me.GbLiquidacion.Controls.Add(Me.CbEstatus)
        Me.GbLiquidacion.Location = New System.Drawing.Point(0, 28)
        Me.GbLiquidacion.Name = "GbLiquidacion"
        Me.GbLiquidacion.Size = New System.Drawing.Size(1041, 75)
        Me.GbLiquidacion.TabIndex = 10
        Me.GbLiquidacion.TabStop = False
        '
        'CbProducto
        '
        Me.CbProducto.FormattingEnabled = True
        Me.CbProducto.Location = New System.Drawing.Point(881, 16)
        Me.CbProducto.Name = "CbProducto"
        Me.CbProducto.Size = New System.Drawing.Size(121, 21)
        Me.CbProducto.TabIndex = 6
        '
        'DgBotesIngresados
        '
        Me.DgBotesIngresados.AllowUserToAddRows = False
        Me.DgBotesIngresados.AllowUserToDeleteRows = False
        Me.DgBotesIngresados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgBotesIngresados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgBotesIngresados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgBotesIngresados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgBotesIngresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBotesIngresados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgBotesIngresados.Location = New System.Drawing.Point(0, 323)
        Me.DgBotesIngresados.MultiSelect = False
        Me.DgBotesIngresados.Name = "DgBotesIngresados"
        Me.DgBotesIngresados.ReadOnly = True
        Me.DgBotesIngresados.RowHeadersVisible = False
        Me.DgBotesIngresados.RowHeadersWidth = 40
        Me.DgBotesIngresados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBotesIngresados.Size = New System.Drawing.Size(1041, 333)
        Me.DgBotesIngresados.TabIndex = 11
        '
        'DgProducciones
        '
        Me.DgProducciones.AllowUserToAddRows = False
        Me.DgProducciones.AllowUserToDeleteRows = False
        Me.DgProducciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgProducciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgProducciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgProducciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgProducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgProducciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgProducciones.Location = New System.Drawing.Point(0, 109)
        Me.DgProducciones.Name = "DgProducciones"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgProducciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgProducciones.RowHeadersVisible = False
        Me.DgProducciones.RowHeadersWidth = 40
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgProducciones.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DgProducciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgProducciones.Size = New System.Drawing.Size(1041, 158)
        Me.DgProducciones.TabIndex = 13
        '
        'BtAgregar
        '
        Me.BtAgregar.Location = New System.Drawing.Point(0, 273)
        Me.BtAgregar.Name = "BtAgregar"
        Me.BtAgregar.Size = New System.Drawing.Size(124, 44)
        Me.BtAgregar.TabIndex = 14
        Me.BtAgregar.Text = "Agregar Botes"
        Me.BtAgregar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(810, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "TOTAL DE BOTES"
        '
        'TbTotal
        '
        Me.TbTotal.Location = New System.Drawing.Point(929, 282)
        Me.TbTotal.Name = "TbTotal"
        Me.TbTotal.Size = New System.Drawing.Size(112, 20)
        Me.TbTotal.TabIndex = 16
        '
        'LIQUIDACIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 659)
        Me.Controls.Add(Me.TbTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtAgregar)
        Me.Controls.Add(Me.DgProducciones)
        Me.Controls.Add(Me.DgBotesIngresados)
        Me.Controls.Add(Me.GbLiquidacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "LIQUIDACIONES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LIQUIDACIONES"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.NuPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbLiquidacion.ResumeLayout(False)
        Me.GbLiquidacion.PerformLayout()
        CType(Me.DgBotesIngresados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgProducciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TsNuevo As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripSeparator
    Friend WithEvents TsGuardar As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripSeparator
    Friend WithEvents TsConsultar As ToolStripButton
    Friend WithEvents TsImprimir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TxIdProduccion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DtFecha As DateTimePicker
    Friend WithEvents TxCantidadBotes As TextBox
    Friend WithEvents NuPrecio As NumericUpDown
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GbLiquidacion As GroupBox
    Friend WithEvents CbProducto As ComboBox
    Friend WithEvents DgBotesIngresados As DataGridView
    Friend WithEvents DgProducciones As DataGridView
    Friend WithEvents BtAgregar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TbTotal As TextBox
End Class
