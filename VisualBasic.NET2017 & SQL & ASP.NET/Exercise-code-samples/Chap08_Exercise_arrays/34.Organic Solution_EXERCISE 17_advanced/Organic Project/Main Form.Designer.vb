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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl1Ttl_US = New System.Windows.Forms.Label()
        Me.lbl2Ttl_Canada = New System.Windows.Forms.Label()
        Me.lbl3Ttl_Mexico = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl7Perc_Mexico = New System.Windows.Forms.Label()
        Me.lbl6Perc_Canada = New System.Windows.Forms.Label()
        Me.lbl5Perc_US = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl8Perc_Company = New System.Windows.Forms.Label()
        Me.lbl4Ttl_Company = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(376, 129)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 38)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "&Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(374, 179)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(374, 213)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "U.S.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Canada:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mexico:"
        '
        'lbl1Ttl_US
        '
        Me.lbl1Ttl_US.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1Ttl_US.Location = New System.Drawing.Point(78, 41)
        Me.lbl1Ttl_US.Name = "lbl1Ttl_US"
        Me.lbl1Ttl_US.Size = New System.Drawing.Size(105, 20)
        Me.lbl1Ttl_US.TabIndex = 3
        Me.lbl1Ttl_US.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2Ttl_Canada
        '
        Me.lbl2Ttl_Canada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2Ttl_Canada.Location = New System.Drawing.Point(78, 73)
        Me.lbl2Ttl_Canada.Name = "lbl2Ttl_Canada"
        Me.lbl2Ttl_Canada.Size = New System.Drawing.Size(105, 20)
        Me.lbl2Ttl_Canada.TabIndex = 6
        Me.lbl2Ttl_Canada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3Ttl_Mexico
        '
        Me.lbl3Ttl_Mexico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3Ttl_Mexico.Location = New System.Drawing.Point(78, 105)
        Me.lbl3Ttl_Mexico.Name = "lbl3Ttl_Mexico"
        Me.lbl3Ttl_Mexico.Size = New System.Drawing.Size(105, 20)
        Me.lbl3Ttl_Mexico.TabIndex = 9
        Me.lbl3Ttl_Mexico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Company sales:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(75, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total sales:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(199, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Percentage:"
        '
        'lbl7Perc_Mexico
        '
        Me.lbl7Perc_Mexico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl7Perc_Mexico.Location = New System.Drawing.Point(202, 105)
        Me.lbl7Perc_Mexico.Name = "lbl7Perc_Mexico"
        Me.lbl7Perc_Mexico.Size = New System.Drawing.Size(66, 20)
        Me.lbl7Perc_Mexico.TabIndex = 10
        Me.lbl7Perc_Mexico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6Perc_Canada
        '
        Me.lbl6Perc_Canada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl6Perc_Canada.Location = New System.Drawing.Point(202, 73)
        Me.lbl6Perc_Canada.Name = "lbl6Perc_Canada"
        Me.lbl6Perc_Canada.Size = New System.Drawing.Size(66, 20)
        Me.lbl6Perc_Canada.TabIndex = 7
        Me.lbl6Perc_Canada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl5Perc_US
        '
        Me.lbl5Perc_US.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl5Perc_US.Location = New System.Drawing.Point(202, 41)
        Me.lbl5Perc_US.Name = "lbl5Perc_US"
        Me.lbl5Perc_US.Size = New System.Drawing.Size(66, 20)
        Me.lbl5Perc_US.TabIndex = 4
        Me.lbl5Perc_US.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl5Perc_US)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl7Perc_Mexico)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl6Perc_Canada)
        Me.GroupBox1.Controls.Add(Me.lbl1Ttl_US)
        Me.GroupBox1.Controls.Add(Me.lbl2Ttl_Canada)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbl3Ttl_Mexico)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 147)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'lbl8Perc_Company
        '
        Me.lbl8Perc_Company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl8Perc_Company.Location = New System.Drawing.Point(251, 25)
        Me.lbl8Perc_Company.Name = "lbl8Perc_Company"
        Me.lbl8Perc_Company.Size = New System.Drawing.Size(66, 20)
        Me.lbl8Perc_Company.TabIndex = 2
        Me.lbl8Perc_Company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl4Ttl_Company
        '
        Me.lbl4Ttl_Company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl4Ttl_Company.Location = New System.Drawing.Point(126, 25)
        Me.lbl4Ttl_Company.Name = "lbl4Ttl_Company"
        Me.lbl4Ttl_Company.Size = New System.Drawing.Size(106, 20)
        Me.lbl4Ttl_Company.TabIndex = 1
        Me.lbl4Ttl_Company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lbl8Perc_Company)
        Me.GroupBox2.Controls.Add(Me.lbl4Ttl_Company)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 62)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnShow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(469, 252)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShow)
        Me.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Organic Market"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShow As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl1Ttl_US As Label
    Friend WithEvents lbl2Ttl_Canada As Label
    Friend WithEvents lbl3Ttl_Mexico As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl7Perc_Mexico As Label
    Friend WithEvents lbl6Perc_Canada As Label
    Friend WithEvents lbl5Perc_US As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl8Perc_Company As Label
    Friend WithEvents lbl4Ttl_Company As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
