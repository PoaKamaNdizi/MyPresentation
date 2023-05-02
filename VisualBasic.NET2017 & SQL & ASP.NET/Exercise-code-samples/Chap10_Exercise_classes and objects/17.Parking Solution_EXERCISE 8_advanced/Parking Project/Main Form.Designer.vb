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
        Me.txt3Price_SquareYard = New System.Windows.Forms.TextBox()
        Me.txt2Height_Feet = New System.Windows.Forms.TextBox()
        Me.txt1Base_Feet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl2TotalCost = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl1TotalArea_SquareFeet = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt3Price_SquareYard)
        Me.GroupBox1.Controls.Add(Me.txt2Height_Feet)
        Me.GroupBox1.Controls.Add(Me.txt1Base_Feet)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please enter your values:"
        '
        'txt3Price_SquareYard
        '
        Me.txt3Price_SquareYard.Location = New System.Drawing.Point(62, 87)
        Me.txt3Price_SquareYard.Name = "txt3Price_SquareYard"
        Me.txt3Price_SquareYard.Size = New System.Drawing.Size(70, 22)
        Me.txt3Price_SquareYard.TabIndex = 5
        Me.txt3Price_SquareYard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2Height_Feet
        '
        Me.txt2Height_Feet.Location = New System.Drawing.Point(62, 59)
        Me.txt2Height_Feet.Name = "txt2Height_Feet"
        Me.txt2Height_Feet.Size = New System.Drawing.Size(70, 22)
        Me.txt2Height_Feet.TabIndex = 3
        Me.txt2Height_Feet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1Base_Feet
        '
        Me.txt1Base_Feet.Location = New System.Drawing.Point(62, 31)
        Me.txt1Base_Feet.Name = "txt1Base_Feet"
        Me.txt1Base_Feet.Size = New System.Drawing.Size(70, 22)
        Me.txt1Base_Feet.TabIndex = 1
        Me.txt1Base_Feet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(141, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "$ per square yard"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "&Cost:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "feet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "feet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Height:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Base:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(17, 157)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(169, 53)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(202, 187)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Total cost:"
        '
        'lbl2TotalCost
        '
        Me.lbl2TotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2TotalCost.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl2TotalCost.Location = New System.Drawing.Point(80, 81)
        Me.lbl2TotalCost.Name = "lbl2TotalCost"
        Me.lbl2TotalCost.Size = New System.Drawing.Size(89, 29)
        Me.lbl2TotalCost.TabIndex = 4
        Me.lbl2TotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total area:"
        '
        'lbl1TotalArea_SquareFeet
        '
        Me.lbl1TotalArea_SquareFeet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1TotalArea_SquareFeet.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl1TotalArea_SquareFeet.Location = New System.Drawing.Point(80, 34)
        Me.lbl1TotalArea_SquareFeet.Name = "lbl1TotalArea_SquareFeet"
        Me.lbl1TotalArea_SquareFeet.Size = New System.Drawing.Size(89, 29)
        Me.lbl1TotalArea_SquareFeet.TabIndex = 1
        Me.lbl1TotalArea_SquareFeet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(173, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "square feet"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl1TotalArea_SquareFeet)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lbl2TotalCost)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 131)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(294, 370)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parking lot (parallelogram shape) pavement price calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt1Base_Feet As TextBox
    Friend WithEvents txt3Price_SquareYard As TextBox
    Friend WithEvents txt2Height_Feet As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl2TotalCost As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl1TotalArea_SquareFeet As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
