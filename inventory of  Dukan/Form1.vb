Imports System.Data.SqlClient
Public Class Form1

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\semester project\vb proj\inventory of  Dukan\inventory of  Dukan.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim cmp As New SqlCommand("select * from uslog where name=@usern and password = @passk", con)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\semester project\vb proj\inventory of  Dukan\inventory of  Dukan.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmd As New SqlCommand("select * from aslog where name=@user and password = @pass", con)

            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBox2.Text

            Dim ada As New SqlDataAdapter(cmd)

            Dim tabuu As New DataTable()

            ada.Fill(tabuu)
            'MessageBox.Show(tabuu.Rows.Count())
            If tabuu.Rows.Count() <= 0 Then
                Dim cmp As New SqlCommand("select * from uslog where name=@usern and password = @passk", con)

                cmp.Parameters.Add("@usern", SqlDbType.VarChar).Value = TextBox1.Text
                cmp.Parameters.Add("@passk", SqlDbType.VarChar).Value = TextBox2.Text

                Dim ad As New SqlDataAdapter(cmp)

                Dim tabu As New DataTable()

                ad.Fill(tabu)
                'MessageBox.Show(tabu.Rows.Count())
                If tabu.Rows.Count() <= 0 Then

                    MessageBox.Show("Username Or Password. Are Invalid")
                Else
                    Form3.Show()
                    Me.Hide()
                End If

            Else
                Me.Hide()
                Form2.Show()
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
