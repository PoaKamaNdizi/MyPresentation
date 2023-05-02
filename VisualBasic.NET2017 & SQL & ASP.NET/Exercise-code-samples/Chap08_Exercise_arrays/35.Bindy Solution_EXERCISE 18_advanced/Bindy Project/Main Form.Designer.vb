<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lst1_ID = New System.Windows.Forms.ListBox()
        Me.lst2_Color = New System.Windows.Forms.ListBox()
        Me.txtEnterThePrice = New System.Windows.Forms.TextBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lst0_Show = New System.Windows.Forms.ListBox()
        Me.rad1_ID = New System.Windows.Forms.RadioButton()
        Me.rad2_Color = New System.Windows.Forms.RadioButton()
        Me.rad3_EnterThePrice = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lst1_ID
        '
        Me.lst1_ID.FormattingEnabled = True
        Me.lst1_ID.ItemHeight = 15
        Me.lst1_ID.Location = New System.Drawing.Point(42, 44)
        Me.lst1_ID.Name = "lst1_ID"
        Me.lst1_ID.Size = New System.Drawing.Size(32, 154)
        Me.lst1_ID.TabIndex = 2
        '
        'lst2_Color
        '
        Me.lst2_Color.Enabled = False
        Me.lst2_Color.FormattingEnabled = True
        Me.lst2_Color.ItemHeight = 15
        Me.lst2_Color.Location = New System.Drawing.Point(163, 44)
        Me.lst2_Color.Name = "lst2_Color"
        Me.lst2_Color.Size = New System.Drawing.Size(45, 64)
        Me.lst2_Color.TabIndex = 5
        '
        'txtEnterThePrice
        '
        Me.txtEnterThePrice.Enabled = False
        Me.txtEnterThePrice.Location = New System.Drawing.Point(298, 44)
        Me.txtEnterThePrice.Name = "txtEnterThePrice"
        Me.txtEnterThePrice.Size = New System.Drawing.Size(49, 22)
        Me.txtEnterThePrice.TabIndex = 8
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(274, 122)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 35)
        Me.btnShow.TabIndex = 9
        Me.btnShow.Text = "&Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(272, 175)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lst0_Show
        '
        Me.lst0_Show.FormattingEnabled = True
        Me.lst0_Show.ItemHeight = 15
        Me.lst0_Show.Location = New System.Drawing.Point(404, 56)
        Me.lst0_Show.Name = "lst0_Show"
        Me.lst0_Show.Size = New System.Drawing.Size(163, 154)
        Me.lst0_Show.TabIndex = 12
        '
        'rad1_ID
        '
        Me.rad1_ID.AutoSize = True
        Me.rad1_ID.Checked = True
        Me.rad1_ID.Location = New System.Drawing.Point(14, 19)
        Me.rad1_ID.Name = "rad1_ID"
        Me.rad1_ID.Size = New System.Drawing.Size(82, 19)
        Me.rad1_ID.TabIndex = 0
        Me.rad1_ID.TabStop = True
        Me.rad1_ID.Text = "Select ID:"
        Me.rad1_ID.UseVisualStyleBackColor = True
        '
        'rad2_Color
        '
        Me.rad2_Color.AutoSize = True
        Me.rad2_Color.Location = New System.Drawing.Point(133, 19)
        Me.rad2_Color.Name = "rad2_Color"
        Me.rad2_Color.Size = New System.Drawing.Size(100, 19)
        Me.rad2_Color.TabIndex = 3
        Me.rad2_Color.TabStop = True
        Me.rad2_Color.Text = "Select Color:"
        Me.rad2_Color.UseVisualStyleBackColor = True
        '
        'rad3_EnterThePrice
        '
        Me.rad3_EnterThePrice.AutoSize = True
        Me.rad3_EnterThePrice.Location = New System.Drawing.Point(272, 19)
        Me.rad3_EnterThePrice.Name = "rad3_EnterThePrice"
        Me.rad3_EnterThePrice.Size = New System.Drawing.Size(92, 19)
        Me.rad3_EnterThePrice.TabIndex = 6
        Me.rad3_EnterThePrice.TabStop = True
        Me.rad3_EnterThePrice.Text = "Enter price:"
        Me.rad3_EnterThePrice.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Your search:"
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"101   Blue      $4.99", "102   Red       $4.99", "103   Blue      $10.49", "104   Red       $10.49", "105   White    $6.79", "106   Red       $6.79", "107   Blue      $6.79", "108   Black    $21.99", "109   White    $21.99", "110   Blue      $21.99"})
        Me.ListBox1.Location = New System.Drawing.Point(626, 56)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(134, 154)
        Me.ListBox1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "ID:        Color:       Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(673, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "info:"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnShow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 234)
        Me.Controls.Add(Me.rad1_ID)
        Me.Controls.Add(Me.lst1_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lst2_Color)
        Me.Controls.Add(Me.rad2_Color)
        Me.Controls.Add(Me.rad3_EnterThePrice)
        Me.Controls.Add(Me.lst0_Show)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtEnterThePrice)
        Me.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bindy Enterprise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst1_ID As ListBox
    Friend WithEvents lst2_Color As ListBox
    Friend WithEvents txtEnterThePrice As TextBox
    Friend WithEvents btnShow As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lst0_Show As ListBox
    Friend WithEvents rad1_ID As RadioButton
    Friend WithEvents rad2_Color As RadioButton
    Friend WithEvents rad3_EnterThePrice As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
