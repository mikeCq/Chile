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
            Dim daInforme As New SqlCommand("sp_ReporteLiquidacionTotal", cnn)
            Dim daSubinforme As New SqlCommand("sp_ReporteLiquidacionDetalle", cnn)
            Dim Ruta As String = "C:\RPTCH\RPT\RptLiquidacionTotal.rpt"
            daInforme.CommandType = CommandType.StoredProcedure
            Dim NombreCampo As New SqlClient.SqlParameter()
            NombreCampo.ParameterName = "@IdProduccion"
            NombreCampo.SqlDbType = SqlDbType.Int
            NombreCampo.Value = LIQUIDACIONES.codigoProduccion
            daInforme.Parameters.Add(NombreCampo)
            Dim dasp_Informe As New SqlClient.SqlDataAdapter()
            dasp_Informe.SelectCommand = daInforme
            Dim dsInforme As New DataTable
            dasp_Informe.Fill(dsInforme)

            daSubinforme.CommandType = CommandType.StoredProcedure
            Dim IdProduccion As New SqlClient.SqlParameter()
            IdProduccion.ParameterName = "@IdProduccion"
            IdProduccion.SqlDbType = SqlDbType.Int
            IdProduccion.Value = LIQUIDACIONES.codigoProduccion
            daSubinforme.Parameters.Add(IdProduccion)
            Dim dasp_Subinforme As New SqlClient.SqlDataAdapter()
            dasp_Subinforme.SelectCommand = daSubinforme
            Dim dsSubinforme As New DataTable
            dasp_Subinforme.Fill(dsSubinforme)

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' Asigno el reporte 
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

            CrReport.Load(Ruta)
            CrReport.SetDataSource(dsInforme)
            CrReport.Subreports("RptLiquidacionDetalle.rpt").SetDataSource(dsSubinforme)
            CrLiquidacion.ReportSource = CrReport
            cnn.Close()
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