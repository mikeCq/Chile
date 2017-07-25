Public Class FInicio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ChilesDBData.Produccion' Puede moverla o quitarla según sea necesario.
        Me.ProduccionTableAdapter.Fill(Me.ChilesDBData.Produccion)

    End Sub

    Private Sub ProduccionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProduccionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProduccionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ChilesDBData)

    End Sub
End Class
