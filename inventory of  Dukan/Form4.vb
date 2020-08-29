Imports System.Data.SqlClient
Public Class Form4
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vb proj\inventory of  Dukan\inventory of  Dukan\viltukidukan.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vb proj\inventory of  Dukan\inventory of  Dukan\viltukidukan.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmp As New SqlCommand("select * from itemMaster where name=@usern ", con)

            cmp.Parameters.Add("@usern", SqlDbType.VarChar).Value = nameTextBox.Text

            Dim ad As New SqlDataAdapter(cmp)

            Dim tabu As New DataTable()

            ad.Fill(tabu)
            'MessageBox.Show(tabu.Rows.Count())
            If tabu.Rows.Count() <= 0 Then
                MessageBox.Show(" item not found ")
                nameTextBox.Clear()
            Else
                Dim cmd As New SqlCommand("select * from brandMaster where itemName=@usern and brandName=@bn and price=@pc ", con)

                cmd.Parameters.Add("@usern", SqlDbType.VarChar).Value = nameTextBox.Text
                cmd.Parameters.Add("@bn", SqlDbType.VarChar).Value = brandTextBox.Text
                cmd.Parameters.Add("@pc", SqlDbType.Int).Value = priceTextBox.Text
                Dim a As New SqlDataAdapter(cmd)

                Dim tab As New DataTable()

                a.Fill(tab)
                'MessageBox.Show(tabu.Rows.Count())
                If tabu.Rows.Count() <= 0 Then

                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    cmd = con.CreateCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "Insert into brandMaster (itemName, brandName, price, qty, size, date) values('" + nameTextBox.Text + "', '" + brandTextBox.Text + "'," & CInt(priceTextBox.Text) & "," & CInt(qtyTextBox.Text) & ",'" + sizeTextBox.Text + "',' " + System.DateTime.Now.ToString(" yyyy-MM-dd") + "')  "
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Inserted successfully")
                Else
                    Dim s As Int32
                    DataGridView1.ClearSelection()
                    cmd = con.CreateCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select * from brandMaster where itemName ='" + nameTextBox.Text + "' and brandName = '" + brandTextBox.Text + "' "
                    cmd.ExecuteNonQuery()
                    Dim dt As New DataTable()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Dim d As SqlClient.SqlDataReader
                    d = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                    While d.Read
                        s = d.GetInt32(4) + CInt(qtyTextBox.Text)
                    End While
                    DataGridView1.ReadOnly = True
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    cmd = con.CreateCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "update brandMaster set qty= " & s & " where itemName ='" + nameTextBox.Text + "' and brandName = '" + brandTextBox.Text + "' "
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Item Added")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Please enter the values correctly")
        End Try


    End Sub
End Class