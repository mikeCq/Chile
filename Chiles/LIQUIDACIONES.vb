Imports System.Data
Imports System.Data.SqlClient
Public Class LIQUIDACIONES
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Dim DtBotes As New DataTable
    Private Sub LIQUIDACIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
        llenaCombos()
        llenaDg()
    End Sub
    Private Sub TsNuevo_Click(sender As Object, e As EventArgs) Handles TsNuevo.Click
        Nuevo()
    End Sub
    Private Sub llenaDg()
        Dim cmd As New SqlCommand("sp_LlenarDgProduccionesLiquidacion", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add(New SqlClient.SqlParameter("@IdProduccion", codigoSeleccionado))
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DgProducciones.DataSource = dt
        FormatoDgProducciones()
    End Sub
    Private Sub FormatoDgProducciones()
        If DgProducciones.Columns("ChCol") Is Nothing Then
            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = ""
            checkBoxColumn.Width = 40
            checkBoxColumn.Name = "ChCol"
            DgProducciones.Columns.Insert(0, checkBoxColumn)
        End If
        DgProducciones.Columns("idproduccion").Visible = False
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

        dr = dt.NewRow()
        dr("Codigo") = "2"
        dr("Descripcion") = "LIQUIDADO"
        dt.Rows.Add(dr)

        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "Codigo"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedIndex = 1
    End Sub
    Private Sub TsConsultar_Click(sender As Object, e As EventArgs) Handles TsConsultar.Click
        'Try
        '    Dim consultaLiquidacion As New ConsultaLiquidaciones
        '    consultaLiquidacion.ShowDialog()
        ' limpiarcampos()
        'Dim codigoSeleccionado As Object = consultaLiquidacion.CodigoProduccion
        '    If codigoSeleccionado <> Nothing Then
        '        Dim cmd As New SqlCommand("sp_LlenarDgProduccionesLiquidacion", cnn)

        '        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add(New SqlClient.SqlParameter("@IdProduccion", codigoSeleccionado))

        'Dim da As New SqlClient.SqlDataAdapter(cmd)
        '        Dim dt As New DataTable

        '        da.Fill(dt)
        '        DgProducciones.DataSource = dt

        'Dim row As DataRow = dt.Rows(0)
        'TxIdProduccion.Text = row("IdProduccion")
        'DtFecha.Value = row("Fecha")
        'TxCantidadBotes.Text = row("CantidadBotes")
        'NuPrecio.Value = row("SumaBotes")
        'CbProducto.Text = CStr(row("Producto"))
        'CbEstatus.SelectedValue = row("IdEstatus")

        'CargaBotes(TxIdProduccion.Text)
        'End If
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'Finally
        'GbAbrir.Enabled = False
        'GbCaptura.Enabled = True
        'End Try
    End Sub
    Private Sub CargaBotes(ByVal CodigoProducccion As Integer)
        Dim resultado As Boolean = False
        Try
            cnn.Open()
            Dim cmd As New SqlCommand("sp_LlenaDgBotes", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@IdProduccion", CodigoProducccion))
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DgBotesIngresados.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Nuevo()
        TxIdProduccion.Text = ""
        TxCantidadBotes.Text = ""
        DtFecha.Value = Now
        NuPrecio.Value = 0
        CbEstatus.SelectedValue = -1
        CbProducto.Text = ""
        DgBotesIngresados.DataSource = ""
        DgBotesIngresados.Columns.Clear()
    End Sub

    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles BtAgregar.Click
        Agregar()
    End Sub
    Private Sub Agregar()
        DgBotesIngresados.Columns.Clear()
        DgBotesIngresados.DataSource = Nothing
        DtBotes.Clear()
        Dim Total As Integer = 0
        'propiedadesDataProdSelec()
        Dim Contador As Integer
        For Contador = 0 To DgProducciones.RowCount - 1
            If DgProducciones.Rows(Contador).Cells("ChCol").Value = True Then
                Try
                    ' Creo el DataTable que llenaremos con Fill
                    cnn.Open()
                    Dim cmd As New SqlCommand("sp_LlenaDgBotes", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlParameter("@IdProduccion", DgProducciones.Rows(Contador).Cells("IdProduccion").Value))
                    ' Llenamos el DataTable donde traemos el producto
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(DtBotes)
                    Total = Total + DgProducciones.Rows(Contador).Cells("cantidadbotes").Value
                Catch ex As Exception
                    MsgBox("Problemas al conectar con al base de datos ")
                Finally
                    cnn.Close()
                End Try
                'DgSeleccionLiquidaciones.Rows.Add(DgEntradasLiq.Rows(Contador).Cells("IdInventario").Value.ToString(), DgEntradasLiq.Rows(Contador).Cells("numeroBoleta").Value, DgEntradasLiq.Rows(Contador).Cells("Id_cliente").Value.ToString(), DgEntradasLiq.Rows(Contador).Cells("Fecha_Pesaje").Value, DgEntradasLiq.Rows(Contador).Cells("grupoGrano").Value.ToString(), DgEntradasLiq.Rows(Contador).Cells("Neto").Value, DgEntradasLiq.Rows(Contador).Cells("Deducciones").Value, DgEntradasLiq.Rows(Contador).Cells("Total").Value)
            End If
        Next Contador
        DgBotesIngresados.DataSource = DtBotes
        TbTotal.Text = Total
    End Sub
    Private Sub consultaproducto(ByVal bb As String, ByVal dgv As DataGridView)

    End Sub
    Private Sub TsGuardar_Click(sender As Object, e As EventArgs) Handles TsGuardar.Click
        Dim Contador As Integer
        For Contador = 0 To DgProducciones.RowCount - 1
            If DgProducciones.Rows(Contador).Cells("ChCol").Value = True Then
                Try
                    'Cambiar el estado
                    cnn.Open()
                    cmd = New SqlCommand("sp_InsProduccion", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlParameter("@IdProduccion", DgProducciones.Rows(Contador).Cells("IdProduccion").Value))
                    cmd.Parameters.Add(New SqlParameter("@Fecha", DgProducciones.Rows(Contador).Cells("fecha").Value))
                    cmd.Parameters.Add(New SqlParameter("@Precio", DgProducciones.Rows(Contador).Cells("precio").Value))
                    cmd.Parameters.Add(New SqlParameter("@CantidadBotes", DgProducciones.Rows(Contador).Cells("cantidadbotes").Value))
                    cmd.Parameters.Add(New SqlParameter("@SumaBotes", DgProducciones.Rows(Contador).Cells("sumabotes").Value))
                    cmd.Parameters.Add(New SqlParameter("@Producto", DgProducciones.Rows(Contador).Cells("producto").Value))
                    cmd.Parameters.Add(New SqlParameter("@IdEstatus", 3))
                    cmd.ExecuteNonQuery()
                    llenaDg()
                Catch ex As Exception
                    MsgBox("Problemas al conectar con al base de datos ")
                Finally
                    cnn.Close()
                End Try
            End If
        Next Contador
    End Sub
    Private Sub DgProducciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgProducciones.CellContentClick
        Dim Contador As Integer
        For Contador = 0 To DgProducciones.RowCount - 1
            If DgProducciones.Rows(Contador).Selected Then
                If DgProducciones.Rows(Contador).Cells("ChCol").Value = False Then
                    DgProducciones.Rows(Contador).Cells("ChCol").Value = True
                ElseIf DgProducciones.Rows(Contador).Cells("ChCol").Value = True Then
                    DgProducciones.Rows(Contador).Cells("ChCol").Value = False
                End If
            End If
        Next Contador
    End Sub
End Class