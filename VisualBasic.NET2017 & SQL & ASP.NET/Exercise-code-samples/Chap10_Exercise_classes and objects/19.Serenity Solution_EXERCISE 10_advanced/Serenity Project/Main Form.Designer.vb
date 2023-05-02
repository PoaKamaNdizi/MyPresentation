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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt1Number = New System.Windows.Forms.TextBox()
        Me.txt2Date = New System.Windows.Forms.TextBox()
        Me.txt3Amount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt4Name = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSaved = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Check &number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Check &date (mm/dd/yyyy):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Check &amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Payable to::"
        '
        'txt1Number
        '
        Me.txt1Number.Location = New System.Drawing.Point(15, 35)
        Me.txt1Number.Name = "txt1Number"
        Me.txt1Number.Size = New System.Drawing.Size(102, 22)
        Me.txt1Number.TabIndex = 1
        Me.txt1Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2Date
        '
        Me.txt2Date.Location = New System.Drawing.Point(146, 35)
        Me.txt2Date.MaxLength = 10
        Me.txt2Date.Name = "txt2Date"
        Me.txt2Date.Size = New System.Drawing.Size(102, 22)
        Me.txt2Date.TabIndex = 3
        Me.txt2Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3Amount
        '
        Me.txt3Amount.Location = New System.Drawing.Point(334, 35)
        Me.txt3Amount.Name = "txt3Amount"
        Me.txt3Amount.Size = New System.Drawing.Size(102, 22)
        Me.txt3Amount.TabIndex = 5
        Me.txt3Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(317, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "$"
        '
        'txt4Name
        '
        Me.txt4Name.Location = New System.Drawing.Point(15, 95)
        Me.txt4Name.Name = "txt4Name"
        Me.txt4Name.Size = New System.Drawing.Size(421, 22)
        Me.txt4Name.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(269, 133)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 36)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(361, 133)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 36)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSaved
        '
        Me.lblSaved.AutoSize = True
        Me.lblSaved.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSaved.ForeColor = System.Drawing.Color.Red
        Me.lblSaved.Location = New System.Drawing.Point(12, 144)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(225, 15)
        Me.lblSaved.TabIndex = 11
        Me.lblSaved.Text = "Your informations has been saved."
        Me.lblSaved.Visible = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(454, 181)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txt4Name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt3Amount)
        Me.Controls.Add(Me.txt2Date)
        Me.Controls.Add(Me.txt1Number)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serenity Photos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt1Number As TextBox
    Friend WithEvents txt2Date As TextBox
    Friend WithEvents txt3Amount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt4Name As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSaved As Label
End Class
