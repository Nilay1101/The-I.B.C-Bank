Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class WebForm9
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here'

        Dim Report As New ReportDocument
        Report.Load(Server.MapPath("CrystalReport1.rpt"))
        Report.SetDatabaseLogon("admin", "admin", "vb", "demo")
        CrystalReportViewer1.ReportSource = Report


    End Sub

End Class
