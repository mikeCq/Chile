<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FInicio
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
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.TxIdProduccion = New System.Windows.Forms.TextBox()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxPrecio = New System.Windows.Forms.TextBox()
        Me.TxCantidadBotes = New System.Windows.Forms.TextBox()
        Me.TxResultado = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProduccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstablecerPrecioDiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChilesDBData = New Chiles.ChilesDBData()
        Me.ProduccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionTableAdapter = New Chiles.ChilesDBDataTableAdapters.ProduccionTableAdapter()
        Me.TableAdapterManager = New Chiles.ChilesDBDataTableAdapters.TableAdapterManager()
        Me.CatalogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ChilesDBData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(90, 329)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(67, 13)
        Label1.TabIndex = 10
        Label1.Text = "Suma Botes:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(90, 302)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(82, 13)
        Label2.TabIndex = 8
        Label2.Text = "Cantidad Botes:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(90, 275)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(40, 13)
        Label3.TabIndex = 6
        Label3.Text = "Precio:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(90, 247)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(40, 13)
        Label4.TabIndex = 4
        Label4.Text = "Fecha:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(90, 221)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(76, 13)
        Label5.TabIndex = 2
        Label5.Text = "Id Produccion:"
        '
        'TxIdProduccion
        '
        Me.TxIdProduccion.Location = New System.Drawing.Point(178, 218)
        Me.TxIdProduccion.Name = "TxIdProduccion"
        Me.TxIdProduccion.Size = New System.Drawing.Size(200, 20)
        Me.TxIdProduccion.TabIndex = 12
        '
        'DtFecha
        '
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(178, 245)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtFecha.TabIndex = 13
        '
        'TxPrecio
        '
        Me.TxPrecio.Location = New System.Drawing.Point(178, 272)
        Me.TxPrecio.Name = "TxPrecio"
        Me.TxPrecio.Size = New System.Drawing.Size(200, 20)
        Me.TxPrecio.TabIndex = 14
        '
        'TxCantidadBotes
        '
        Me.TxCantidadBotes.Location = New System.Drawing.Point(178, 299)
        Me.TxCantidadBotes.Name = "TxCantidadBotes"
        Me.TxCantidadBotes.Size = New System.Drawing.Size(200, 20)
        Me.TxCantidadBotes.TabIndex = 15
        '
        'TxResultado
        '
        Me.TxResultado.Location = New System.Drawing.Point(178, 326)
        Me.TxResultado.Name = "TxResultado"
        Me.TxResultado.Size = New System.Drawing.Size(200, 20)
        Me.TxResultado.TabIndex = 16
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogosToolStripMenuItem, Me.ProduccionToolStripMenuItem, Me.UtilidadesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProduccionToolStripMenuItem
        '
        Me.ProduccionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstablecerPrecioDiarioToolStripMenuItem})
        Me.ProduccionToolStripMenuItem.Name = "ProduccionToolStripMenuItem"
        Me.ProduccionToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProduccionToolStripMenuItem.Text = "Procesos"
        '
        'EstablecerPrecioDiarioToolStripMenuItem
        '
        Me.EstablecerPrecioDiarioToolStripMenuItem.Name = "EstablecerPrecioDiarioToolStripMenuItem"
        Me.EstablecerPrecioDiarioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EstablecerPrecioDiarioToolStripMenuItem.Text = "Produccion"
        '
        'UtilidadesToolStripMenuItem
        '
        Me.UtilidadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem})
        Me.UtilidadesToolStripMenuItem.Name = "UtilidadesToolStripMenuItem"
        Me.UtilidadesToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.UtilidadesToolStripMenuItem.Text = "Utilidades"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ChilesDBData
        '
        Me.ChilesDBData.DataSetName = "ChilesDBData"
        Me.ChilesDBData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProduccionBindingSource
        '
        Me.ProduccionBindingSource.DataMember = "Produccion"
        Me.ProduccionBindingSource.DataSource = Me.ChilesDBData
        '
        'ProduccionTableAdapter
        '
        Me.ProduccionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProduccionTableAdapter = Me.ProduccionTableAdapter
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Chiles.ChilesDBDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CatalogosToolStripMenuItem
        '
        Me.CatalogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem})
        Me.CatalogosToolStripMenuItem.Name = "CatalogosToolStripMenuItem"
        Me.CatalogosToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.CatalogosToolStripMenuItem.Text = "Catalogos"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'FInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 669)
        Me.Controls.Add(Me.TxResultado)
        Me.Controls.Add(Me.TxCantidadBotes)
        Me.Controls.Add(Me.TxPrecio)
        Me.Controls.Add(Me.DtFecha)
        Me.Controls.Add(Me.TxIdProduccion)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FInicio"
        Me.Text = "Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ChilesDBData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChilesDBData As ChilesDBData
    Friend WithEvents ProduccionBindingSource As BindingSource
    Friend WithEvents ProduccionTableAdapter As ChilesDBDataTableAdapters.ProduccionTableAdapter
    Friend WithEvents TableAdapterManager As ChilesDBDataTableAdapters.TableAdapterManager
    Friend WithEvents TxIdProduccion As TextBox
    Friend WithEvents DtFecha As DateTimePicker
    Friend WithEvents TxPrecio As TextBox
    Friend WithEvents TxCantidadBotes As TextBox
    Friend WithEvents TxResultado As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProduccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstablecerPrecioDiarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
End Class
