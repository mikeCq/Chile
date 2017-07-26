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
        Dim IdProduccionLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim CantidadBotesLabel As System.Windows.Forms.Label
        Dim SumaBotesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FInicio))
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.ChilesDBData = New Chiles.ChilesDBData()
        Me.ProduccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionTableAdapter = New Chiles.ChilesDBDataTableAdapters.ProduccionTableAdapter()
        Me.TableAdapterManager = New Chiles.ChilesDBDataTableAdapters.TableAdapterManager()
        Me.ProduccionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProduccionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Buscar = New System.Windows.Forms.ToolStripButton()
        Me.ProduccionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProduccionTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadBotesTextBox = New System.Windows.Forms.TextBox()
        Me.SumaBotesTextBox = New System.Windows.Forms.TextBox()
        Me.TxIdProduccion = New System.Windows.Forms.TextBox()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxPrecio = New System.Windows.Forms.TextBox()
        Me.TxCantidadBotes = New System.Windows.Forms.TextBox()
        Me.TxResultado = New System.Windows.Forms.TextBox()
        IdProduccionLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CantidadBotesLabel = New System.Windows.Forms.Label()
        SumaBotesLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.ChilesDBData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProduccionBindingNavigator.SuspendLayout()
        CType(Me.ProduccionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdProduccionLabel
        '
        IdProduccionLabel.AutoSize = True
        IdProduccionLabel.Location = New System.Drawing.Point(12, 296)
        IdProduccionLabel.Name = "IdProduccionLabel"
        IdProduccionLabel.Size = New System.Drawing.Size(76, 13)
        IdProduccionLabel.TabIndex = 2
        IdProduccionLabel.Text = "Id Produccion:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(12, 323)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 4
        FechaLabel.Text = "Fecha:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(12, 348)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 6
        PrecioLabel.Text = "Precio:"
        '
        'CantidadBotesLabel
        '
        CantidadBotesLabel.AutoSize = True
        CantidadBotesLabel.Location = New System.Drawing.Point(12, 374)
        CantidadBotesLabel.Name = "CantidadBotesLabel"
        CantidadBotesLabel.Size = New System.Drawing.Size(82, 13)
        CantidadBotesLabel.TabIndex = 8
        CantidadBotesLabel.Text = "Cantidad Botes:"
        '
        'SumaBotesLabel
        '
        SumaBotesLabel.AutoSize = True
        SumaBotesLabel.Location = New System.Drawing.Point(12, 400)
        SumaBotesLabel.Name = "SumaBotesLabel"
        SumaBotesLabel.Size = New System.Drawing.Size(67, 13)
        SumaBotesLabel.TabIndex = 10
        SumaBotesLabel.Text = "Suma Botes:"
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
        Me.TableAdapterManager.UpdateOrder = Chiles.ChilesDBDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProduccionBindingNavigator
        '
        Me.ProduccionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProduccionBindingNavigator.BindingSource = Me.ProduccionBindingSource
        Me.ProduccionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProduccionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProduccionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProduccionBindingNavigatorSaveItem, Me.Buscar})
        Me.ProduccionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProduccionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProduccionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProduccionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProduccionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProduccionBindingNavigator.Name = "ProduccionBindingNavigator"
        Me.ProduccionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProduccionBindingNavigator.Size = New System.Drawing.Size(544, 25)
        Me.ProduccionBindingNavigator.TabIndex = 0
        Me.ProduccionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProduccionBindingNavigatorSaveItem
        '
        Me.ProduccionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProduccionBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProduccionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProduccionBindingNavigatorSaveItem.Name = "ProduccionBindingNavigatorSaveItem"
        Me.ProduccionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProduccionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Buscar
        '
        Me.Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Buscar.Image = CType(resources.GetObject("Buscar.Image"), System.Drawing.Image)
        Me.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(23, 22)
        Me.Buscar.Text = "ToolStripButton1"
        Me.Buscar.ToolTipText = "NvBuscar"
        '
        'ProduccionDataGridView
        '
        Me.ProduccionDataGridView.AutoGenerateColumns = False
        Me.ProduccionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ProduccionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProduccionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProduccionDataGridView.DataSource = Me.ProduccionBindingSource
        Me.ProduccionDataGridView.Location = New System.Drawing.Point(0, 437)
        Me.ProduccionDataGridView.Name = "ProduccionDataGridView"
        Me.ProduccionDataGridView.Size = New System.Drawing.Size(543, 220)
        Me.ProduccionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdProduccion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Produccion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CantidadBotes"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad De Botes"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SumaBotes"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Suma De Botes"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'IdProduccionTextBox
        '
        Me.IdProduccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "IdProduccion", True))
        Me.IdProduccionTextBox.Location = New System.Drawing.Point(100, 293)
        Me.IdProduccionTextBox.Name = "IdProduccionTextBox"
        Me.IdProduccionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdProduccionTextBox.TabIndex = 3
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProduccionBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(100, 319)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 5
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(100, 345)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PrecioTextBox.TabIndex = 7
        '
        'CantidadBotesTextBox
        '
        Me.CantidadBotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "CantidadBotes", True))
        Me.CantidadBotesTextBox.Location = New System.Drawing.Point(100, 371)
        Me.CantidadBotesTextBox.Name = "CantidadBotesTextBox"
        Me.CantidadBotesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CantidadBotesTextBox.TabIndex = 9
        '
        'SumaBotesTextBox
        '
        Me.SumaBotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduccionBindingSource, "SumaBotes", True))
        Me.SumaBotesTextBox.Location = New System.Drawing.Point(100, 397)
        Me.SumaBotesTextBox.Name = "SumaBotesTextBox"
        Me.SumaBotesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SumaBotesTextBox.TabIndex = 11
        '
        'TxIdProduccion
        '
        Me.TxIdProduccion.Location = New System.Drawing.Point(100, 50)
        Me.TxIdProduccion.Name = "TxIdProduccion"
        Me.TxIdProduccion.Size = New System.Drawing.Size(200, 20)
        Me.TxIdProduccion.TabIndex = 12
        '
        'DtFecha
        '
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(100, 77)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtFecha.TabIndex = 13
        '
        'TxPrecio
        '
        Me.TxPrecio.Location = New System.Drawing.Point(100, 104)
        Me.TxPrecio.Name = "TxPrecio"
        Me.TxPrecio.Size = New System.Drawing.Size(200, 20)
        Me.TxPrecio.TabIndex = 14
        '
        'TxCantidadBotes
        '
        Me.TxCantidadBotes.Location = New System.Drawing.Point(100, 131)
        Me.TxCantidadBotes.Name = "TxCantidadBotes"
        Me.TxCantidadBotes.Size = New System.Drawing.Size(200, 20)
        Me.TxCantidadBotes.TabIndex = 15
        '
        'TxResultado
        '
        Me.TxResultado.Location = New System.Drawing.Point(100, 158)
        Me.TxResultado.Name = "TxResultado"
        Me.TxResultado.Size = New System.Drawing.Size(200, 20)
        Me.TxResultado.TabIndex = 16
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 161)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(67, 13)
        Label1.TabIndex = 10
        Label1.Text = "Suma Botes:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 134)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(82, 13)
        Label2.TabIndex = 8
        Label2.Text = "Cantidad Botes:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(12, 107)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(40, 13)
        Label3.TabIndex = 6
        Label3.Text = "Precio:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(12, 79)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(40, 13)
        Label4.TabIndex = 4
        Label4.Text = "Fecha:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(12, 53)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(76, 13)
        Label5.TabIndex = 2
        Label5.Text = "Id Produccion:"
        '
        'FInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 669)
        Me.Controls.Add(Me.TxResultado)
        Me.Controls.Add(Me.TxCantidadBotes)
        Me.Controls.Add(Me.TxPrecio)
        Me.Controls.Add(Me.DtFecha)
        Me.Controls.Add(Me.TxIdProduccion)
        Me.Controls.Add(Label5)
        Me.Controls.Add(IdProduccionLabel)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.IdProduccionTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(CantidadBotesLabel)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.CantidadBotesTextBox)
        Me.Controls.Add(SumaBotesLabel)
        Me.Controls.Add(Me.SumaBotesTextBox)
        Me.Controls.Add(Me.ProduccionDataGridView)
        Me.Controls.Add(Me.ProduccionBindingNavigator)
        Me.Name = "FInicio"
        Me.Text = "Inicio"
        CType(Me.ChilesDBData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProduccionBindingNavigator.ResumeLayout(False)
        Me.ProduccionBindingNavigator.PerformLayout()
        CType(Me.ProduccionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChilesDBData As ChilesDBData
    Friend WithEvents ProduccionBindingSource As BindingSource
    Friend WithEvents ProduccionTableAdapter As ChilesDBDataTableAdapters.ProduccionTableAdapter
    Friend WithEvents TableAdapterManager As ChilesDBDataTableAdapters.TableAdapterManager
    Friend WithEvents ProduccionBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProduccionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProduccionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents IdProduccionTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents CantidadBotesTextBox As TextBox
    Friend WithEvents SumaBotesTextBox As TextBox
    Friend WithEvents Buscar As ToolStripButton
    Friend WithEvents TxIdProduccion As TextBox
    Friend WithEvents DtFecha As DateTimePicker
    Friend WithEvents TxPrecio As TextBox
    Friend WithEvents TxCantidadBotes As TextBox
    Friend WithEvents TxResultado As TextBox
End Class
