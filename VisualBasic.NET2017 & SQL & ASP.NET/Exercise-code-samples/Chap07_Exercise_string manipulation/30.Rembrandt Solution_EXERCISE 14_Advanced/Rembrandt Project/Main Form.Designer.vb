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
        Me.lbl4UsedCar = New System.Windows.Forms.Label()
        Me.lbl3NewCar = New System.Windows.Forms.Label()
        Me.lbl2PartTime = New System.Windows.Forms.Label()
        Me.lbl1FullTime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txt1ID = New System.Windows.Forms.TextBox()
        Me.txt2Sold = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl4UsedCar)
        Me.GroupBox1.Controls.Add(Me.lbl3NewCar)
        Me.GroupBox1.Controls.Add(Me.lbl2PartTime)
        Me.GroupBox1.Controls.Add(Me.lbl1FullTime)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 172)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cars sold by"
        '
        'lbl4UsedCar
        '
        Me.lbl4UsedCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl4UsedCar.Location = New System.Drawing.Point(189, 126)
        Me.lbl4UsedCar.Name = "lbl4UsedCar"
        Me.lbl4UsedCar.Size = New System.Drawing.Size(83, 23)
        Me.lbl4UsedCar.TabIndex = 7
        Me.lbl4UsedCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3NewCar
        '
        Me.lbl3NewCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3NewCar.Location = New System.Drawing.Point(189, 96)
        Me.lbl3NewCar.Name = "lbl3NewCar"
        Me.lbl3NewCar.Size = New System.Drawing.Size(83, 23)
        Me.lbl3NewCar.TabIndex = 5
        Me.lbl3NewCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2PartTime
        '
        Me.lbl2PartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2PartTime.Location = New System.Drawing.Point(189, 66)
        Me.lbl2PartTime.Name = "lbl2PartTime"
        Me.lbl2PartTime.Size = New System.Drawing.Size(83, 23)
        Me.lbl2PartTime.TabIndex = 3
        Me.lbl2PartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl1FullTime
        '
        Me.lbl1FullTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1FullTime.Location = New System.Drawing.Point(189, 36)
        Me.lbl1FullTime.Name = "lbl1FullTime"
        Me.lbl1FullTime.Size = New System.Drawing.Size(83, 23)
        Me.lbl1FullTime.TabIndex = 1
        Me.lbl1FullTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Used car employees:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "New car employees:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Part-time employees:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full-time employees:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Employee &ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "&Number sold:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(277, 38)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(81, 43)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(277, 89)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 26)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txt1ID
        '
        Me.txt1ID.Location = New System.Drawing.Point(132, 29)
        Me.txt1ID.MaxLength = 5
        Me.txt1ID.Name = "txt1ID"
        Me.txt1ID.Size = New System.Drawing.Size(67, 22)
        Me.txt1ID.TabIndex = 1
        Me.txt1ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2Sold
        '
        Me.txt2Sold.Location = New System.Drawing.Point(132, 68)
        Me.txt2Sold.Name = "txt2Sold"
        Me.txt2Sold.Size = New System.Drawing.Size(51, 22)
        Me.txt2Sold.TabIndex = 3
        Me.txt2Sold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt2Sold)
        Me.GroupBox2.Controls.Add(Me.txt1ID)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 110)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Please enter:"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(277, 141)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 26)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(391, 376)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rembrandt Auto-Mart"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txt1ID As TextBox
    Friend WithEvents txt2Sold As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl4UsedCar As Label
    Friend WithEvents lbl3NewCar As Label
    Friend WithEvents lbl2PartTime As Label
    Friend WithEvents lbl1FullTime As Label
    Friend WithEvents btnExit As Button
End Class
