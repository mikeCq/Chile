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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstablecerPrecioDiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChilesDBData = New Chiles.ChilesDBDataSet()
        Me.ProduccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionTableAdapter = New Chiles.ChilesDBDataSetTableAdapters.ProduccionTableAdapter()
        Me.TableAdapterManager = New Chiles.ChilesDBDataSetTableAdapters.TableAdapterManager()
        Me.LiquidacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ChilesDBData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ProduccionToolStripMenuItem
        '
        Me.ProduccionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstablecerPrecioDiarioToolStripMenuItem, Me.LiquidacionesToolStripMenuItem})
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
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
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
        Me.TableAdapterManager.BotesTableAdapter = Nothing
        Me.TableAdapterManager.ProduccionTableAdapter = Me.ProduccionTableAdapter
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Chiles.ChilesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LiquidacionesToolStripMenuItem
        '
        Me.LiquidacionesToolStripMenuItem.Name = "LiquidacionesToolStripMenuItem"
        Me.LiquidacionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LiquidacionesToolStripMenuItem.Text = "Liquidaciones"
        '
        'FInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 669)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ChilesDBData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChilesDBData As ChilesDBDataSet
    Friend WithEvents ProduccionBindingSource As BindingSource
    Friend WithEvents ProduccionTableAdapter As ChilesDBDataSetTableAdapters.ProduccionTableAdapter
    Friend WithEvents TableAdapterManager As ChilesDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProduccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstablecerPrecioDiarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LiquidacionesToolStripMenuItem As ToolStripMenuItem
End Class
