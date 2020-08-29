<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExchangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SellReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSellsPersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveSellsPersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.clearButton2 = New System.Windows.Forms.Button()
        Me.saveButton3 = New System.Windows.Forms.Button()
        Me.ItemMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrationToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportToolStripMenuItem, Me.UserToolStripMenuItem, Me.FeedbackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.ItemMasterToolStripMenuItem})
        Me.AdministrationToolStripMenuItem.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.AdministrationToolStripMenuItem.Text = "Administration"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SellToolStripMenuItem, Me.PurchaseToolStripMenuItem, Me.ExchangeToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'SellToolStripMenuItem
        '
        Me.SellToolStripMenuItem.Name = "SellToolStripMenuItem"
        Me.SellToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SellToolStripMenuItem.Text = "Sell"
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PurchaseToolStripMenuItem.Text = "Purchase"
        '
        'ExchangeToolStripMenuItem
        '
        Me.ExchangeToolStripMenuItem.Name = "ExchangeToolStripMenuItem"
        Me.ExchangeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExchangeToolStripMenuItem.Text = "Exchange"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SellReportToolStripMenuItem, Me.PurchaseReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'SellReportToolStripMenuItem
        '
        Me.SellReportToolStripMenuItem.Name = "SellReportToolStripMenuItem"
        Me.SellReportToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.SellReportToolStripMenuItem.Text = "Sell Report"
        '
        'PurchaseReportToolStripMenuItem
        '
        Me.PurchaseReportToolStripMenuItem.Name = "PurchaseReportToolStripMenuItem"
        Me.PurchaseReportToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.PurchaseReportToolStripMenuItem.Text = "Purchase Report"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSellsPersonToolStripMenuItem, Me.RemoveSellsPersonToolStripMenuItem, Me.CurrentUserToolStripMenuItem})
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'AddSellsPersonToolStripMenuItem
        '
        Me.AddSellsPersonToolStripMenuItem.Name = "AddSellsPersonToolStripMenuItem"
        Me.AddSellsPersonToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.AddSellsPersonToolStripMenuItem.Text = "Add Sells Person"
        '
        'RemoveSellsPersonToolStripMenuItem
        '
        Me.RemoveSellsPersonToolStripMenuItem.Name = "RemoveSellsPersonToolStripMenuItem"
        Me.RemoveSellsPersonToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.RemoveSellsPersonToolStripMenuItem.Text = "Remove Sells Person"
        '
        'CurrentUserToolStripMenuItem
        '
        Me.CurrentUserToolStripMenuItem.Name = "CurrentUserToolStripMenuItem"
        Me.CurrentUserToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.CurrentUserToolStripMenuItem.Text = "Current User"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(801, 284)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(164, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(94, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Change Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'clearButton2
        '
        Me.clearButton2.Location = New System.Drawing.Point(486, 347)
        Me.clearButton2.Name = "clearButton2"
        Me.clearButton2.Size = New System.Drawing.Size(75, 23)
        Me.clearButton2.TabIndex = 5
        Me.clearButton2.Text = "Clear"
        Me.clearButton2.UseVisualStyleBackColor = True
        '
        'saveButton3
        '
        Me.saveButton3.Location = New System.Drawing.Point(597, 347)
        Me.saveButton3.Name = "saveButton3"
        Me.saveButton3.Size = New System.Drawing.Size(75, 23)
        Me.saveButton3.TabIndex = 6
        Me.saveButton3.Text = "Save"
        Me.saveButton3.UseVisualStyleBackColor = True
        '
        'ItemMasterToolStripMenuItem
        '
        Me.ItemMasterToolStripMenuItem.Name = "ItemMasterToolStripMenuItem"
        Me.ItemMasterToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ItemMasterToolStripMenuItem.Text = "Item Master"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1067, 450)
        Me.Controls.Add(Me.saveButton3)
        Me.Controls.Add(Me.clearButton2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExchangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SellReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddSellsPersonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveSellsPersonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CurrentUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents clearButton2 As Button
    Friend WithEvents saveButton3 As Button
    Friend WithEvents ItemMasterToolStripMenuItem As ToolStripMenuItem
End Class
