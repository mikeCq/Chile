Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class REPORTELIQUIDACION
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private Sub REPORTELIQUIDACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cnn.Open()
            Dim da1 As New SqlCommand("sp_ReporteLiquidacionDetalle", cnn)
            Dim Ruta1 As String = "C:\RPTCH\RPT\RptLiquidacionDetalle.rpt"
            da1.CommandType = CommandType.StoredProcedure
            Dim NombreCampo As New SqlClient.SqlParameter()
            NombreCampo.ParameterName = "@IdProduccion"
            NombreCampo.SqlDbType = SqlDbType.Int
            NombreCampo.Value = LIQUIDACIONES.codigoProduccion
            da1.Parameters.Add(NombreCampo)
            Dim dasp_ReporteBoletaEntrada1 As New SqlClient.SqlDataAdapter()
            dasp_ReporteBoletaEntrada1.SelectCommand = da1
            Dim ds1 As New DataTable
            dasp_ReporteBoletaEntrada1.Fill(ds1)

            Dim CrReport1 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' Asigno el reporte 
            CrReport1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport1.Load(Ruta1)
            CrReport1.SetDataSource(ds1)

            CrLiquidacion.ReportSource = CrReport1
            cnn.Close()
            cargaSubInforme()
        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
        End Try

    End Sub
    Private Sub cargaSubInforme()

        Try
            cnn.Open()
            Dim da As New SqlCommand("sp_ReporteLiquidacionTotal", cnn)
            Dim Ruta As String = "C:\RPTCH\RPT\RptLiquidacionTotal.rpt"
            da.CommandType = CommandType.StoredProcedure
            Dim NombreCampo As New SqlClient.SqlParameter()
            NombreCampo.ParameterName = "@IdProduccion"
            NombreCampo.SqlDbType = SqlDbType.Int
            NombreCampo.Value = LIQUIDACIONES.codigoProduccion
            da.Parameters.Add(NombreCampo)
            Dim dasp_ReporteBoletaEntrada As New SqlClient.SqlDataAdapter()
            dasp_ReporteBoletaEntrada.SelectCommand = da
            Dim ds As New DataTable
            dasp_ReporteBoletaEntrada.Fill(ds)

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' Asigno el reporte 
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Ruta)
            CrReport.SetDataSource(ds)

            CrLiquidacion.ReportSource = CrReport
            cnn.Close()

        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
        End Try
    End Sub

End Class