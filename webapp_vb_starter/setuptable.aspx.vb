Public Class setuptable
    Inherits System.Web.UI.Page
    Protected ConnStr As String = ConfigurationManager.ConnectionStrings("strconn").ConnectionString
    Dim ios As New iosc.iosql
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If ios.SQLCheckTableExist(“table1”, ConnStr) = False Then
            ios.createiotable(ConnStr, “table1”, ios.Ret_CreateTblStr(“table1”, "ID:id,Data1:s,Num1:i,Num2:i,Total:i"))
        End If
        Response.Redirect("WebForm1.aspx")
    End Sub
End Class