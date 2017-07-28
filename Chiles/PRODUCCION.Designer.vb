<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produccion
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
        Me.DgBoteIngresado = New System.Windows.Forms.DataGridView()
        Me.NuPrecio = New System.Windows.Forms.NumericUpDown()
        Me.CbProducto = New System.Windows.Forms.ComboBox()
        Me.BtIniciar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxCaptura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtCerrar = New System.Windows.Forms.Button()
        Me.TxIdProduccion = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsNuevo = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsEliminar = New System.Windows.Forms.ToolStripButton()
        CType(Me.DgBoteIngresado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgBoteIngresado
        '
        Me.DgBoteIngresado.AllowUserToAddRows = False
        Me.DgBoteIngresado.AllowUserToDeleteRows = False
        Me.DgBoteIngresado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgBoteIngresado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgBoteIngresado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgBoteIngresado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgBoteIngresado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBoteIngresado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgBoteIngresado.Location = New System.Drawing.Point(12, 325)
        Me.DgBoteIngresado.MultiSelect = False
        Me.DgBoteIngresado.Name = "DgBoteIngresado"
        Me.DgBoteIngresado.ReadOnly = True
        Me.DgBoteIngresado.RowHeadersVisible = False
        Me.DgBoteIngresado.RowHeadersWidth = 40
        Me.DgBoteIngresado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBoteIngresado.Size = New System.Drawing.Size(801, 250)
        Me.DgBoteIngresado.TabIndex = 1
        '
        'NuPrecio
        '
        Me.NuPrecio.DecimalPlaces = 2
        Me.NuPrecio.Location = New System.Drawing.Point(61, 76)
        Me.NuPrecio.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NuPrecio.Name = "NuPrecio"
        Me.NuPrecio.Size = New System.Drawing.Size(120, 20)
        Me.NuPrecio.TabIndex = 2
        Me.NuPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CbProducto
        '
        Me.CbProducto.FormattingEnabled = True
        Me.CbProducto.Location = New System.Drawing.Point(289, 75)
        Me.CbProducto.Name = "CbProducto"
        Me.CbProducto.Size = New System.Drawing.Size(125, 21)
        Me.CbProducto.TabIndex = 4
        '
        'BtIniciar
        '
        Me.BtIniciar.Location = New System.Drawing.Point(699, 64)
        Me.BtIniciar.Name = "BtIniciar"
        Me.BtIniciar.Size = New System.Drawing.Size(114, 40)
        Me.BtIniciar.TabIndex = 5
        Me.BtIniciar.Text = "Abrir Produccion"
        Me.BtIniciar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Precio :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Producto :"
        '
        'TxCaptura
        '
        Me.TxCaptura.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCaptura.Location = New System.Drawing.Point(13, 257)
        Me.TxCaptura.Name = "TxCaptura"
        Me.TxCaptura.Size = New System.Drawing.Size(279, 62)
        Me.TxCaptura.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(13, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CAPTURAR BOTES :"
        '
        'BtCerrar
        '
        Me.BtCerrar.Location = New System.Drawing.Point(699, 279)
        Me.BtCerrar.Name = "BtCerrar"
        Me.BtCerrar.Size = New System.Drawing.Size(114, 40)
        Me.BtCerrar.TabIndex = 5
        Me.BtCerrar.Text = "Cerrar Produccion"
        Me.BtCerrar.UseVisualStyleBackColor = True
        '
        'TxIdProduccion
        '
        Me.TxIdProduccion.Location = New System.Drawing.Point(61, 40)
        Me.TxIdProduccion.Name = "TxIdProduccion"
        Me.TxIdProduccion.Size = New System.Drawing.Size(120, 20)
        Me.TxIdProduccion.TabIndex = 8
        Me.TxIdProduccion.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsNuevo, Me.ToolStripButton2, Me.TsGuardar, Me.ToolStripSeparator2, Me.TsEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(825, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TsNuevo
        '
        Me.TsNuevo.Image = Global.Chiles.My.Resources.Resources.Nuevo
        Me.TsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsNuevo.Name = "TsNuevo"
        Me.TsNuevo.Size = New System.Drawing.Size(58, 22)
        Me.TsNuevo.Text = "Nuevo"
        Me.TsNuevo.ToolTipText = "Nuevo"
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
        Me.TsGuardar.Size = New System.Drawing.Size(126, 22)
        Me.TsGuardar.Text = "Guardar/Actualizar"
        Me.TsGuardar.ToolTipText = "Guardar/Actualizar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TsEliminar
        '
        Me.TsEliminar.Image = Global.Chiles.My.Resources.Resources.Eliminar
        Me.TsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsEliminar.Name = "TsEliminar"
        Me.TsEliminar.Size = New System.Drawing.Size(70, 22)
        Me.TsEliminar.Text = "Eliminar"
        Me.TsEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TsEliminar.ToolTipText = "Eliminar"
        '
        'Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 587)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TxIdProduccion)
        Me.Controls.Add(Me.TxCaptura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtCerrar)
        Me.Controls.Add(Me.BtIniciar)
        Me.Controls.Add(Me.CbProducto)
        Me.Controls.Add(Me.NuPrecio)
        Me.Controls.Add(Me.DgBoteIngresado)
        Me.MinimumSize = New System.Drawing.Size(841, 626)
        Me.Name = "Produccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Produccion"
        CType(Me.DgBoteIngresado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgBoteIngresado As DataGridView
    Friend WithEvents NuPrecio As NumericUpDown
    Friend WithEvents CbProducto As ComboBox
    Friend WithEvents BtIniciar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxCaptura As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtCerrar As Button
    Friend WithEvents TxIdProduccion As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TsNuevo As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripSeparator
    Friend WithEvents TsGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TsEliminar As ToolStripButton
End Class
