Imports System.Data
Imports System.Data.SqlClient
Public Class FInicio
    Dim connection As SqlConnection = Nothing

    Private Sub FInicio_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load


      
    End Sub

    Private Sub ProduccionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProduccionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ChilesDBData)

    End Sub

    Private Sub txtnumarticulo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyData
            'Case Keys.Enter
            '    SumaBotesTextBox.Text = CantidadBotesTextBox.Text * PrecioTextBox.Text
            'Case Keys.Tab
            '    SumaBotesTextBox.Text = CantidadBotesTextBox.Text * PrecioTextBox.Text
        End Select

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        PRODUCTOS.ShowDialog()
    End Sub

    Private Sub EstablecerPrecioDiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstablecerPrecioDiarioToolStripMenuItem.Click
        Produccion.ShowDialog()
    End Sub

    Private Sub LiquidacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiquidacionesToolStripMenuItem.Click
        LIQUIDACIONES.ShowDialog()
    End Sub
End Class
