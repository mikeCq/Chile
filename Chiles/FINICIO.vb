Imports System.Data
Imports System.Data.SqlClient
Public Class FInicio
    Dim connection As SqlConnection = Nothing

    Private Sub FInicio_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load


        connection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MSISTEMAS\Desktop\Desarrollo\Chiles\Chiles\ChilesDB.mdf;Integrated Security=True")

        connection.Open()
        Dim sql As String = "select * from produccion"
        Dim cmd As SqlCommand = New SqlCommand(sql, connection)

        Dim r As SqlDataReader = cmd.ExecuteReader()
        While r.Read()
            Dim Id As Integer = CInt(r("IdProduccion"))
            Dim Fecha As Date = CDate(r("Fecha"))
            Dim Precio As Decimal = CDec(r("Precio"))
            Dim CantidadBotes As Decimal = CDec(r("CantidadBotes"))
            Dim SumaBotes As Decimal = CDec(r("SumaBotes"))

            TxIdProduccion.Text = Id
            DtFecha.Value = Fecha
            TxPrecio.Text = Precio
            TxCantidadBotes.Text = CantidadBotes
            TxResultado.Text = SumaBotes
        End While
        r.Close()
        connection.Close()
        sql = Nothing
        cmd = Nothing
        connection = Nothing

        'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    'TODO: esta línea de código carga datos en la tabla 'ChilesDBData.Produccion' Puede moverla o quitarla según sea necesario.
        '    Me.ProduccionTableAdapter.Fill(Me.ChilesDBData.Produccion)
    End Sub

    Private Sub ProduccionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProduccionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProduccionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ChilesDBData)

    End Sub

    Private Sub txtnumarticulo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CantidadBotesTextBox.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                SumaBotesTextBox.Text = CantidadBotesTextBox.Text * PrecioTextBox.Text
            Case Keys.Tab
                SumaBotesTextBox.Text = CantidadBotesTextBox.Text * PrecioTextBox.Text
        End Select

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click

    End Sub
End Class
