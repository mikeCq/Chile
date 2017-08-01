Imports System.Data
Imports System.Data.SqlClient
Public Class CONSULTAPRODUCCION
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private _codigoProduccion As Integer
    Public Property CodigoProduccion() As Integer
        Get
            Return _codigoProduccion
        End Get
        Set(ByVal value As Integer)
            _codigoProduccion = value
        End Set
    End Property
    Private Sub CONSULTAPRODUCCION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaCombos()
        DgProducciones.DataSource = ""
        DgProducciones.Columns.Clear()
    End Sub
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        cargarData()
    End Sub
    Private Sub cargarData()
        cnn.Open()
        Dim cmd As New SqlCommand("sp_LlenaDgBusquedaProduccion", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@FechaIni", DtInicial.Value))
        cmd.Parameters.Add(New SqlParameter("@FechaFin", DtFinal.Value))
        cmd.Parameters.Add(New SqlParameter("@Producto", CbProducto.Text))
        cmd.Parameters.Add(New SqlParameter("@IdEstatus", CbEstatus.SelectedValue))

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DgProducciones.DataSource = dt
        cnn.Close()
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

        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Codigo") = "0"
        dr("Descripcion") = "CERRADO"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "1"
        dr("Descripcion") = "ABIERTO"
        dt.Rows.Add(dr)

        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "Codigo"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedIndex = -1
    End Sub

    Private Sub SeleccionProducto(sender As Object, e As EventArgs) Handles DgProducciones.DoubleClick
        If DgProducciones.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgProducciones Is Nothing Then
            _codigoProduccion = CStr(DgProducciones.CurrentRow.Cells(0).Value)
            Close()
        End If
    End Sub

    Private Sub TsNuevo_Click(sender As Object, e As EventArgs) Handles TsNuevo.Click
        DtInicial.Value = "01/01/2000"
        DtFinal.Value = "01/01/2000"
        CbProducto.Text = ""
    End Sub
End Class