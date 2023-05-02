<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn1_DisplaySales = New System.Windows.Forms.Button()
        Me.lbl1_Sales = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lst1b_Years = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lst1a_Salespeople = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lst2c_SoldBy = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn2_SalesAndNames = New System.Windows.Forms.Button()
        Me.lbl2_Sales = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lst2b_Status = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lst2a_Years = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn1_DisplaySales)
        Me.GroupBox1.Controls.Add(Me.lbl1_Sales)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lst1b_Years)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lst1a_Salespeople)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 218)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btn1_DisplaySales
        '
        Me.btn1_DisplaySales.Location = New System.Drawing.Point(138, 168)
        Me.btn1_DisplaySales.Name = "btn1_DisplaySales"
        Me.btn1_DisplaySales.Size = New System.Drawing.Size(85, 25)
        Me.btn1_DisplaySales.TabIndex = 4
        Me.btn1_DisplaySales.Text = "&Display sales"
        Me.btn1_DisplaySales.UseVisualStyleBackColor = True
        '
        'lbl1_Sales
        '
        Me.lbl1_Sales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1_Sales.Location = New System.Drawing.Point(22, 168)
        Me.lbl1_Sales.Name = "lbl1_Sales"
        Me.lbl1_Sales.Size = New System.Drawing.Size(85, 25)
        Me.lbl1_Sales.TabIndex = 6
        Me.lbl1_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sales:"
        '
        'lst1b_Years
        '
        Me.lst1b_Years.FormattingEnabled = True
        Me.lst1b_Years.ItemHeight = 12
        Me.lst1b_Years.Location = New System.Drawing.Point(138, 41)
        Me.lst1b_Years.Name = "lst1b_Years"
        Me.lst1b_Years.Size = New System.Drawing.Size(42, 40)
        Me.lst1b_Years.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Years:"
        '
        'lst1a_Salespeople
        '
        Me.lst1a_Salespeople.FormattingEnabled = True
        Me.lst1a_Salespeople.ItemHeight = 12
        Me.lst1a_Salespeople.Location = New System.Drawing.Point(22, 41)
        Me.lst1a_Salespeople.Name = "lst1a_Salespeople"
        Me.lst1a_Salespeople.Size = New System.Drawing.Size(85, 88)
        Me.lst1a_Salespeople.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Salespeople:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lst2c_SoldBy)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btn2_SalesAndNames)
        Me.GroupBox2.Controls.Add(Me.lbl2_Sales)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lst2b_Status)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lst2a_Years)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(298, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 218)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'lst2c_SoldBy
        '
        Me.lst2c_SoldBy.FormattingEnabled = True
        Me.lst2c_SoldBy.ItemHeight = 12
        Me.lst2c_SoldBy.Location = New System.Drawing.Point(176, 41)
        Me.lst2c_SoldBy.Name = "lst2c_SoldBy"
        Me.lst2c_SoldBy.Size = New System.Drawing.Size(85, 88)
        Me.lst2c_SoldBy.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(174, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 12)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Sold &by:"
        '
        'btn2_SalesAndNames
        '
        Me.btn2_SalesAndNames.Location = New System.Drawing.Point(138, 168)
        Me.btn2_SalesAndNames.Name = "btn2_SalesAndNames"
        Me.btn2_SalesAndNames.Size = New System.Drawing.Size(123, 25)
        Me.btn2_SalesAndNames.TabIndex = 4
        Me.btn2_SalesAndNames.Text = "Sales and &names"
        Me.btn2_SalesAndNames.UseVisualStyleBackColor = True
        '
        'lbl2_Sales
        '
        Me.lbl2_Sales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2_Sales.Location = New System.Drawing.Point(22, 168)
        Me.lbl2_Sales.Name = "lbl2_Sales"
        Me.lbl2_Sales.Size = New System.Drawing.Size(85, 25)
        Me.lbl2_Sales.TabIndex = 8
        Me.lbl2_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 12)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Sales:"
        '
        'lst2b_Status
        '
        Me.lst2b_Status.FormattingEnabled = True
        Me.lst2b_Status.ItemHeight = 12
        Me.lst2b_Status.Location = New System.Drawing.Point(90, 41)
        Me.lst2b_Status.Name = "lst2b_Status"
        Me.lst2b_Status.Size = New System.Drawing.Size(56, 28)
        Me.lst2b_Status.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 12)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "S&tatus:"
        '
        'lst2a_Years
        '
        Me.lst2a_Years.FormattingEnabled = True
        Me.lst2a_Years.ItemHeight = 12
        Me.lst2a_Years.Location = New System.Drawing.Point(22, 41)
        Me.lst2a_Years.Name = "lst2a_Years"
        Me.lst2a_Years.Size = New System.Drawing.Size(42, 28)
        Me.lst2a_Years.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ye&ars:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 247)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Liberation Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "36_19. Adaline Inc."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lst1a_Salespeople As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lst1b_Years As ListBox
    Friend WithEvents lbl1_Sales As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn1_DisplaySales As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lst2a_Years As ListBox
    Friend WithEvents lst2b_Status As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lst2c_SoldBy As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn2_SalesAndNames As Button
    Friend WithEvents lbl2_Sales As Label
    Friend WithEvents Label8 As Label
End Class
