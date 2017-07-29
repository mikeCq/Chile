Imports System.Data
Imports System.Data.SqlClient
Public Class Produccion
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private Sub Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaCombos()
        cargarData()
    End Sub
    Private Sub llenaCombos()
        cnn.Open()
        Dim da As SqlDataAdapter
        Dim ds As DataSet

        Dim cmdllenaCbProd As SqlCommand

        cmdllenaCbProd = New SqlCommand("sp_LlenaDgProductos")
        cmdllenaCbProd.CommandType = CommandType.StoredProcedure
        cmdllenaCbProd.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbProd)
        ds = New DataSet()
        da.Fill(ds)
        CbProducto.DataSource = ds.Tables(0)
        CbProducto.DisplayMember = "Nombre"
        CbProducto.ValueMember = "IdProducto"
        CbProducto.SelectedIndex = -1
        cnn.Close()
    End Sub

    Private Sub BtIniciar_Click(sender As Object, e As EventArgs) Handles BtIniciar.Click
        Try
            cnn.Open()
            cmd = New SqlCommand("sp_InsProduccion", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@IdProduccion", 0))
            cmd.Parameters.Add(New SqlParameter("@Fecha", Now))
            cmd.Parameters.Add(New SqlParameter("@Precio", NuPrecio.Value))
            cmd.Parameters.Add(New SqlParameter("@CantidadBotes", 0))
            cmd.Parameters.Add(New SqlParameter("@SumaBotes", 0))
            cmd.Parameters.Add(New SqlParameter("@Producto", CbProducto.Text))

            cmd.Parameters("@IdProduccion").Direction = ParameterDirection.InputOutput

            cmd.ExecuteNonQuery()
            TxIdProduccion.Text = cmd.Parameters("@IdProduccion").Value

        Catch ex As Exception
        Finally
            cnn.Close()
            CargarData()
        End Try
    End Sub
    Private Sub cargarData()
        cnn.Open()
        Dim cmd As New SqlCommand("sp_LlenaDgBotes", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@IdProduccion", IIf(TxIdProduccion.Text = "", 0, TxIdProduccion.Text)))
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DgBoteIngresado.DataSource = dt
        cnn.Close()
    End Sub
    Private Sub CapturaBotes(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxCaptura.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
            e.KeyChar = ChrW(Keys.Enter)
            CambioControlPesoBruto(sender, e)
        End If
    End Sub
    Private Sub CambioControlPesoBruto(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            If TxCaptura.Text = "" Then
                MessageBox.Show("Campo de captura vacio.")
            Else
                Try
                    cnn.Open()
                    cmd = New SqlCommand("sp_InsBotes", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlParameter("@IdBotes", 0))
                    cmd.Parameters.Add(New SqlParameter("@Empleado", TxCaptura.Text))
                    cmd.Parameters.Add(New SqlParameter("@Fecha", Now))
                    cmd.Parameters.Add(New SqlParameter("@IdProduccion", TxIdProduccion.Text))

                    'cmd.Parameters("@IdProduccion").Direction = ParameterDirection.InputOutput

                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                Finally
                    cnn.Close()
                    cargarData()
                    TxCaptura.Text = ""
                    TxCaptura.Select()
                End Try
            End If
        End If
    End Sub
    Private Sub TsNuevo_Click(sender As Object, e As EventArgs) Handles TsNuevo.Click
        TxIdProduccion.Text = ""
    End Sub
End Class