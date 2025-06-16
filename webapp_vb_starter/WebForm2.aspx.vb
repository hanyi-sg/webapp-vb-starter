Public Class WebForm2
    Inherits System.Web.UI.Page
    Protected ConnStr As String = ConfigurationManager.ConnectionStrings("strconn").ConnectionString
    Protected ioc As New iosc.iocc
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Display_Load_Data()
        End If
    End Sub
    Public Sub Display_Load_Data()
        GridView1.DataSource = ioc.GetDataTable("select * from table1", ConnStr)
        GridView1.DataBind()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("WebForm1.aspx")
    End Sub
End Class