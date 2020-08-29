Imports system.Data.SqlClient
Public Class Form2

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vb proj\inventory of  Dukan\inventory of  Dukan\viltukidukan.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim cmp As New SqlCommand
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Hide()
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\vb proj\inventory of  Dukan\inventory of  Dukan\viltukidukan.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Label1.Hide()
        Button1.Hide()
        TextBox1.Hide()
        clearButton2.Hide()
        saveButton3.Hide()
    End Sub
    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        DataGridView1.Show()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from brandMaster  "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Dim d As SqlClient.SqlDataReader
        d = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.DataSource = dt

        DataGridView1.ReadOnly = True
        Label1.Hide()
        Button1.Hide()
        TextBox1.Hide()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        DataGridView1.Show()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from customer "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Dim d As SqlClient.SqlDataReader
        d = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.DataSource = dt

        DataGridView1.ReadOnly = False
        Label1.Hide()
        Button1.Hide()
        TextBox1.Hide()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Label1.Show()
        Button1.Show()
        TextBox1.Show()
        DataGridView1.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try


            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update aslog Set password='" + TextBox1.Text + "' where  name='admin' "
            cmd.ExecuteNonQuery()
            MessageBox.Show("password changed successfully")
            Label1.Hide()
            Button1.Hide()
            TextBox1.Hide()
        Catch ex As Exception
            MessageBox.Show("Please enter New Password")
        End Try
    End Sub

    Private Sub SellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SellToolStripMenuItem.Click
        clearButton2.Show()
        saveButton3.Show()
        DataGridView1.Show()
        'DataGridView1.Show()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select *from  itNo "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Dim d As SqlClient.SqlDataReader
        d = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.DataSource = dt

        DataGridView1.ReadOnly = False
        Label1.Hide()
        Button1.Hide()
        TextBox1.Hide()

    End Sub

    Private Sub ok(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        MessageBox.Show("rishu")
        ' cmd.CommandText = "select stock.item No, stock.name, stock.Price, itNo.itemNo from  itNo, stock where stock.Item No = itNo.itemNo "
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        'cmd.CommandText = "select *from  itNo "
        cmd.CommandText = "select stock.IteNo, stock.name, stock.Price, itNo.ItemNo from  itNo, stock where stock.IteNo = itNo.ItemNo "

        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Dim d As SqlClient.SqlDataReader
        d = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click
        Form4.Show()
        Label1.Hide()
        Button1.Hide()
        TextBox1.Hide()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub SellReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SellReportToolStripMenuItem.Click
        DataGridView1.Show()
        'DataGridView1.Show()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from sellview "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Dim d As SqlClient.SqlDataReader
        d = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.DataSource = dt

        DataGridView1.ReadOnly = True
        Label1.Hide()
        Button1.Hide()
        TextBox1.Hide()
    End Sub

    Private Sub ItemMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemMasterToolStripMenuItem.Click
        Form5.Show()
    End Sub
End Class