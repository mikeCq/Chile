Imports System.Data
Imports System.Data.SqlClient
Public Class CONSULTAPRODUCCION
    Private Sub CONSULTAPRODUCCION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click

    End Sub
    Private Sub cargarData()
        cnn.Open()
        'Dim cmd As New SqlCommand("sp_LlenaDgBotes", cnn)
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add(New SqlParameter("@IdProduccion", IIf(TxIdProduccion.Text = "", 0, TxIdProduccion.Text)))
        'Dim da As New SqlDataAdapter(cmd)
        'Dim dt As New DataTable
        'da.Fill(dt)
        'DgBoteIngresado.DataSource = dt
        cnn.Close()
    End Sub
End Class