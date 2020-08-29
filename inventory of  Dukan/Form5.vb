Imports System.Data.SqlClient
Public Class Form5
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vb proj\inventory of  Dukan\inventory of  Dukan\viltukidukan.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into itemMaster values ('" + TextBox1.Text + "')"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Please enter new item name")
        End Try
    End Sub
End Class