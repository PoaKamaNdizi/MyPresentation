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
        Me.rad1single = New System.Windows.Forms.RadioButton()
        Me.rad2family = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk1golf = New System.Windows.Forms.CheckBox()
        Me.chk2tennis = New System.Windows.Forms.CheckBox()
        Me.chk3racq = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl1basic = New System.Windows.Forms.Label()
        Me.lbl2additional = New System.Windows.Forms.Label()
        Me.lbl3dues = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad2family)
        Me.GroupBox1.Controls.Add(Me.rad1single)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(96, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Membership"
        '
        'rad1single
        '
        Me.rad1single.AutoSize = True
        Me.rad1single.Checked = True
        Me.rad1single.Location = New System.Drawing.Point(17, 33)
        Me.rad1single.Name = "rad1single"
        Me.rad1single.Size = New System.Drawing.Size(61, 19)
        Me.rad1single.TabIndex = 0
        Me.rad1single.TabStop = True
        Me.rad1single.Text = "&Single"
        Me.rad1single.UseVisualStyleBackColor = True
        '
        'rad2family
        '
        Me.rad2family.AutoSize = True
        Me.rad2family.Location = New System.Drawing.Point(17, 70)
        Me.rad2family.Name = "rad2family"
        Me.rad2family.Size = New System.Drawing.Size(64, 19)
        Me.rad2family.TabIndex = 1
        Me.rad2family.Text = "&Family"
        Me.rad2family.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk3racq)
        Me.GroupBox2.Controls.Add(Me.chk2tennis)
        Me.GroupBox2.Controls.Add(Me.chk1golf)
        Me.GroupBox2.Location = New System.Drawing.Point(142, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(121, 149)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional"
        '
        'chk1golf
        '
        Me.chk1golf.AutoSize = True
        Me.chk1golf.Location = New System.Drawing.Point(17, 33)
        Me.chk1golf.Name = "chk1golf"
        Me.chk1golf.Size = New System.Drawing.Size(49, 19)
        Me.chk1golf.TabIndex = 0
        Me.chk1golf.Text = "&Golf"
        Me.chk1golf.UseVisualStyleBackColor = True
        '
        'chk2tennis
        '
        Me.chk2tennis.AutoSize = True
        Me.chk2tennis.Location = New System.Drawing.Point(17, 71)
        Me.chk2tennis.Name = "chk2tennis"
        Me.chk2tennis.Size = New System.Drawing.Size(63, 19)
        Me.chk2tennis.TabIndex = 1
        Me.chk2tennis.Text = "&Tennis"
        Me.chk2tennis.UseVisualStyleBackColor = True
        '
        'chk3racq
        '
        Me.chk3racq.AutoSize = True
        Me.chk3racq.Location = New System.Drawing.Point(17, 108)
        Me.chk3racq.Name = "chk3racq"
        Me.chk3racq.Size = New System.Drawing.Size(94, 19)
        Me.chk3racq.TabIndex = 2
        Me.chk3racq.Text = "&Racquetball"
        Me.chk3racq.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Basic fee:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Additional:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Monthly dues:"
        '
        'lbl1basic
        '
        Me.lbl1basic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1basic.Location = New System.Drawing.Point(12, 248)
        Me.lbl1basic.Name = "lbl1basic"
        Me.lbl1basic.Size = New System.Drawing.Size(96, 37)
        Me.lbl1basic.TabIndex = 5
        Me.lbl1basic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2additional
        '
        Me.lbl2additional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2additional.Location = New System.Drawing.Point(142, 248)
        Me.lbl2additional.Name = "lbl2additional"
        Me.lbl2additional.Size = New System.Drawing.Size(121, 37)
        Me.lbl2additional.TabIndex = 7
        Me.lbl2additional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3dues
        '
        Me.lbl3dues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3dues.Font = New System.Drawing.Font("Liberation Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl3dues.Location = New System.Drawing.Point(12, 327)
        Me.lbl3dues.Name = "lbl3dues"
        Me.lbl3dues.Size = New System.Drawing.Size(251, 37)
        Me.lbl3dues.TabIndex = 9
        Me.lbl3dues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(15, 176)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(158, 37)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(188, 176)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(277, 381)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lbl3dues)
        Me.Controls.Add(Me.lbl2additional)
        Me.Controls.Add(Me.lbl1basic)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Glasgow Health Club"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rad2family As RadioButton
    Friend WithEvents rad1single As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chk3racq As CheckBox
    Friend WithEvents chk2tennis As CheckBox
    Friend WithEvents chk1golf As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl1basic As Label
    Friend WithEvents lbl2additional As Label
    Friend WithEvents lbl3dues As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
