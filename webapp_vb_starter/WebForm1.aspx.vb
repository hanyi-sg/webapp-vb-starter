Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected ConnStr As String = ConfigurationManager.ConnectionStrings("strconn").ConnectionString
    Protected ios As New iosc.iosql
    Protected ioc As New iosc.iocc
    Protected QueryString_EditID As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        QueryString_EditID = Request.QueryString("Edit")
        If Not IsPostBack Then
            If QueryString_EditID = "" Then
                Button1.Text = "Add"
            Else
                Button1.Text = "Edit"
                Display_EditRecord(QueryString_EditID)
            End If
        End If
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim StrArr(3) As String
        StrArr(0) = TextBox1.Text
        StrArr(1) = TextBox2.Text
        StrArr(2) = TextBox3.Text
        StrArr(3) = CInt(TextBox2.Text) + CInt(TextBox3.Text)
        Select Case Button1.Text
            Case "Add"
                Dim ReturnInt As Integer = ios.AddUpdSQLDataRetInt(ConnStr, "i", "table1", "Data1,Num1,Num2,Total", StrArr)
                QueryString_EditID = ReturnInt
            Case "Edit"
                ios.AddUpdSQLDataRetInt(ConnStr, "u", "table1", "Data1,Num1,Num2,Total", StrArr, "id", QueryString_EditID)
        End Select
        Response.Redirect("WebForm2.aspx")
    End Sub
    Public Sub Display_EditRecord(ByVal EditID As String)
        Dim a() As String = ioc.DataReturnStrArrayInDb("select Data1,Num1,Num2 from table1 where ID=" & EditID, ConnStr)
        If a(0) <> "Nil" Then
            TextBox1.Text = a(0)
            TextBox2.Text = a(1)
            TextBox3.Text = a(2)
        End If
    End Sub
End Class