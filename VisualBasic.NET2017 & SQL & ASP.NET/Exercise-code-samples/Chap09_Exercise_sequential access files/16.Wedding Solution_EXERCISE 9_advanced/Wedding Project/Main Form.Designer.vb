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
        Me.lstInvited = New System.Windows.Forms.ListBox()
        Me.lstAccepted = New System.Windows.Forms.ListBox()
        Me.lstRejected = New System.Windows.Forms.ListBox()
        Me.btnAccepted = New System.Windows.Forms.Button()
        Me.btnRejected = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstInvited
        '
        Me.lstInvited.FormattingEnabled = True
        Me.lstInvited.ItemHeight = 15
        Me.lstInvited.Location = New System.Drawing.Point(16, 40)
        Me.lstInvited.Name = "lstInvited"
        Me.lstInvited.Size = New System.Drawing.Size(149, 304)
        Me.lstInvited.Sorted = True
        Me.lstInvited.TabIndex = 1
        '
        'lstAccepted
        '
        Me.lstAccepted.FormattingEnabled = True
        Me.lstAccepted.ItemHeight = 15
        Me.lstAccepted.Location = New System.Drawing.Point(320, 40)
        Me.lstAccepted.Name = "lstAccepted"
        Me.lstAccepted.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstAccepted.Size = New System.Drawing.Size(149, 364)
        Me.lstAccepted.Sorted = True
        Me.lstAccepted.TabIndex = 6
        '
        'lstRejected
        '
        Me.lstRejected.FormattingEnabled = True
        Me.lstRejected.ItemHeight = 15
        Me.lstRejected.Location = New System.Drawing.Point(499, 40)
        Me.lstRejected.Name = "lstRejected"
        Me.lstRejected.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstRejected.Size = New System.Drawing.Size(149, 364)
        Me.lstRejected.Sorted = True
        Me.lstRejected.TabIndex = 8
        '
        'btnAccepted
        '
        Me.btnAccepted.Location = New System.Drawing.Point(200, 65)
        Me.btnAccepted.Name = "btnAccepted"
        Me.btnAccepted.Size = New System.Drawing.Size(87, 27)
        Me.btnAccepted.TabIndex = 2
        Me.btnAccepted.Text = "&Accepted"
        Me.btnAccepted.UseVisualStyleBackColor = True
        '
        'btnRejected
        '
        Me.btnRejected.Location = New System.Drawing.Point(200, 112)
        Me.btnRejected.Name = "btnRejected"
        Me.btnRejected.Size = New System.Drawing.Size(87, 27)
        Me.btnRejected.TabIndex = 3
        Me.btnRejected.Text = "&Rejected"
        Me.btnRejected.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(200, 158)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 27)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Invited guests:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Accepted guests:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(499, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rejected guests:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 435)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRejected)
        Me.Controls.Add(Me.btnAccepted)
        Me.Controls.Add(Me.lstRejected)
        Me.Controls.Add(Me.lstAccepted)
        Me.Controls.Add(Me.lstInvited)
        Me.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "16. EXERCISE_9 Wedding"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstInvited As ListBox
    Friend WithEvents lstAccepted As ListBox
    Friend WithEvents lstRejected As ListBox
    Friend WithEvents btnAccepted As Button
    Friend WithEvents btnRejected As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
