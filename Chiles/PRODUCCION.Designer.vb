﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsSalir = New System.Windows.Forms.ToolStripLabel()
        Me.GbAbrir = New System.Windows.Forms.GroupBox()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.TxNombreDia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GbCaptura = New System.Windows.Forms.GroupBox()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DgBoteIngresado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GbAbrir.SuspendLayout()
        Me.GbCaptura.SuspendLayout()
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
        Me.DgBoteIngresado.Location = New System.Drawing.Point(12, 290)
        Me.DgBoteIngresado.MultiSelect = False
        Me.DgBoteIngresado.Name = "DgBoteIngresado"
        Me.DgBoteIngresado.ReadOnly = True
        Me.DgBoteIngresado.RowHeadersVisible = False
        Me.DgBoteIngresado.RowHeadersWidth = 40
        Me.DgBoteIngresado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBoteIngresado.Size = New System.Drawing.Size(801, 285)
        Me.DgBoteIngresado.TabIndex = 0
        '
        'NuPrecio
        '
        Me.NuPrecio.DecimalPlaces = 2
        Me.NuPrecio.Location = New System.Drawing.Point(197, 9)
        Me.NuPrecio.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NuPrecio.Name = "NuPrecio"
        Me.NuPrecio.Size = New System.Drawing.Size(125, 20)
        Me.NuPrecio.TabIndex = 0
        Me.NuPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CbProducto
        '
        Me.CbProducto.FormattingEnabled = True
        Me.CbProducto.Location = New System.Drawing.Point(197, 35)
        Me.CbProducto.Name = "CbProducto"
        Me.CbProducto.Size = New System.Drawing.Size(125, 21)
        Me.CbProducto.TabIndex = 1
        '
        'BtIniciar
        '
        Me.BtIniciar.Location = New System.Drawing.Point(6, 94)
        Me.BtIniciar.Name = "BtIniciar"
        Me.BtIniciar.Size = New System.Drawing.Size(125, 30)
        Me.BtIniciar.TabIndex = 3
        Me.BtIniciar.Text = "Abrir Produccion"
        Me.BtIniciar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Producto :"
        '
        'TxCaptura
        '
        Me.TxCaptura.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCaptura.Location = New System.Drawing.Point(6, 50)
        Me.TxCaptura.Name = "TxCaptura"
        Me.TxCaptura.Size = New System.Drawing.Size(279, 62)
        Me.TxCaptura.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(0, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CAPTURAR BOTES :"
        '
        'BtCerrar
        '
        Me.BtCerrar.Location = New System.Drawing.Point(699, 72)
        Me.BtCerrar.Name = "BtCerrar"
        Me.BtCerrar.Size = New System.Drawing.Size(114, 40)
        Me.BtCerrar.TabIndex = 1
        Me.BtCerrar.Text = "Cerrar Produccion"
        Me.BtCerrar.UseVisualStyleBackColor = True
        '
        'TxIdProduccion
        '
        Me.TxIdProduccion.Location = New System.Drawing.Point(699, 9)
        Me.TxIdProduccion.Name = "TxIdProduccion"
        Me.TxIdProduccion.Size = New System.Drawing.Size(114, 20)
        Me.TxIdProduccion.TabIndex = 0
        Me.TxIdProduccion.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsNuevo, Me.ToolStripButton2, Me.TsGuardar, Me.ToolStripSeparator2, Me.TsEliminar, Me.ToolStripSeparator3, Me.TsConsultar, Me.ToolStripSeparator1, Me.TsSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(825, 25)
        Me.ToolStrip1.TabIndex = 0
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'TsConsultar
        '
        Me.TsConsultar.Image = Global.Chiles.My.Resources.Resources.Consultar
        Me.TsConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsConsultar.Name = "TsConsultar"
        Me.TsConsultar.Size = New System.Drawing.Size(138, 22)
        Me.TsConsultar.Text = "Consulta Produccion"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TsSalir
        '
        Me.TsSalir.Image = Global.Chiles.My.Resources.Resources.Black_Icon_Package_Icon_21
        Me.TsSalir.Name = "TsSalir"
        Me.TsSalir.Size = New System.Drawing.Size(45, 22)
        Me.TsSalir.Text = "Salir"
        '
        'GbAbrir
        '
        Me.GbAbrir.Controls.Add(Me.CbEstatus)
        Me.GbAbrir.Controls.Add(Me.NuPrecio)
        Me.GbAbrir.Controls.Add(Me.CbProducto)
        Me.GbAbrir.Controls.Add(Me.TxNombreDia)
        Me.GbAbrir.Controls.Add(Me.TxIdProduccion)
        Me.GbAbrir.Controls.Add(Me.BtIniciar)
        Me.GbAbrir.Controls.Add(Me.Label1)
        Me.GbAbrir.Controls.Add(Me.Label5)
        Me.GbAbrir.Controls.Add(Me.Label4)
        Me.GbAbrir.Controls.Add(Me.Label2)
        Me.GbAbrir.Location = New System.Drawing.Point(0, 28)
        Me.GbAbrir.Name = "GbAbrir"
        Me.GbAbrir.Size = New System.Drawing.Size(825, 124)
        Me.GbAbrir.TabIndex = 1
        Me.GbAbrir.TabStop = False
        '
        'CbEstatus
        '
        Me.CbEstatus.Enabled = False
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(197, 62)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(125, 21)
        Me.CbEstatus.TabIndex = 2
        '
        'TxNombreDia
        '
        Me.TxNombreDia.Enabled = False
        Me.TxNombreDia.Location = New System.Drawing.Point(699, 59)
        Me.TxNombreDia.Name = "TxNombreDia"
        Me.TxNombreDia.Size = New System.Drawing.Size(114, 20)
        Me.TxNombreDia.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Estatus :"
        '
        'GbCaptura
        '
        Me.GbCaptura.Controls.Add(Me.BtCerrar)
        Me.GbCaptura.Controls.Add(Me.Label3)
        Me.GbCaptura.Controls.Add(Me.TxCaptura)
        Me.GbCaptura.Location = New System.Drawing.Point(0, 158)
        Me.GbCaptura.Name = "GbCaptura"
        Me.GbCaptura.Size = New System.Drawing.Size(825, 126)
        Me.GbCaptura.TabIndex = 2
        Me.GbCaptura.TabStop = False
        '
        'DtFecha
        '
        Me.DtFecha.Enabled = False
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(699, 5)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(114, 20)
        Me.DtFecha.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(631, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Dia :"
        '
        'Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 587)
        Me.Controls.Add(Me.DtFecha)
        Me.Controls.Add(Me.GbCaptura)
        Me.Controls.Add(Me.GbAbrir)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DgBoteIngresado)
        Me.MinimumSize = New System.Drawing.Size(841, 626)
        Me.Name = "Produccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Produccion"
        CType(Me.DgBoteIngresado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GbAbrir.ResumeLayout(False)
        Me.GbAbrir.PerformLayout()
        Me.GbCaptura.ResumeLayout(False)
        Me.GbCaptura.PerformLayout()
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
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TsConsultar As ToolStripButton
    Friend WithEvents GbAbrir As GroupBox
    Friend WithEvents GbCaptura As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents DtFecha As DateTimePicker
    Friend WithEvents TsSalir As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TxNombreDia As TextBox
    Friend WithEvents Label5 As Label
End Class
