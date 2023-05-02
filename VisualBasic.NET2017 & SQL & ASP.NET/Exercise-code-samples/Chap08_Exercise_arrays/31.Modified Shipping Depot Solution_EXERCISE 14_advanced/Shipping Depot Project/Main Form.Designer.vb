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
        Me.lbl6USPSPerc = New System.Windows.Forms.Label()
        Me.lbl5UPSPerc = New System.Windows.Forms.Label()
        Me.lbl4FedExPerc = New System.Windows.Forms.Label()
        Me.lbl3USPS = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl2UPS = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl1FedEx = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl0Total = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl6USPSPerc)
        Me.GroupBox1.Controls.Add(Me.lbl5UPSPerc)
        Me.GroupBox1.Controls.Add(Me.lbl4FedExPerc)
        Me.GroupBox1.Controls.Add(Me.lbl3USPS)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl2UPS)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl1FedEx)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl0Total)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 180)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'lbl6USPSPerc
        '
        Me.lbl6USPSPerc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl6USPSPerc.Location = New System.Drawing.Point(199, 131)
        Me.lbl6USPSPerc.Name = "lbl6USPSPerc"
        Me.lbl6USPSPerc.Size = New System.Drawing.Size(66, 22)
        Me.lbl6USPSPerc.TabIndex = 10
        Me.lbl6USPSPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl5UPSPerc
        '
        Me.lbl5UPSPerc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl5UPSPerc.Location = New System.Drawing.Point(199, 94)
        Me.lbl5UPSPerc.Name = "lbl5UPSPerc"
        Me.lbl5UPSPerc.Size = New System.Drawing.Size(66, 22)
        Me.lbl5UPSPerc.TabIndex = 7
        Me.lbl5UPSPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl4FedExPerc
        '
        Me.lbl4FedExPerc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl4FedExPerc.Location = New System.Drawing.Point(199, 59)
        Me.lbl4FedExPerc.Name = "lbl4FedExPerc"
        Me.lbl4FedExPerc.Size = New System.Drawing.Size(66, 22)
        Me.lbl4FedExPerc.TabIndex = 4
        Me.lbl4FedExPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3USPS
        '
        Me.lbl3USPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3USPS.Location = New System.Drawing.Point(112, 131)
        Me.lbl3USPS.Name = "lbl3USPS"
        Me.lbl3USPS.Size = New System.Drawing.Size(66, 22)
        Me.lbl3USPS.TabIndex = 9
        Me.lbl3USPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "USPS:"
        '
        'lbl2UPS
        '
        Me.lbl2UPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2UPS.Location = New System.Drawing.Point(112, 94)
        Me.lbl2UPS.Name = "lbl2UPS"
        Me.lbl2UPS.Size = New System.Drawing.Size(66, 22)
        Me.lbl2UPS.TabIndex = 6
        Me.lbl2UPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "UPS:"
        '
        'lbl1FedEx
        '
        Me.lbl1FedEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1FedEx.Location = New System.Drawing.Point(112, 59)
        Me.lbl1FedEx.Name = "lbl1FedEx"
        Me.lbl1FedEx.Size = New System.Drawing.Size(66, 22)
        Me.lbl1FedEx.TabIndex = 3
        Me.lbl1FedEx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FedEx:"
        '
        'lbl0Total
        '
        Me.lbl0Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl0Total.Location = New System.Drawing.Point(112, 22)
        Me.lbl0Total.Name = "lbl0Total"
        Me.lbl0Total.Size = New System.Drawing.Size(66, 22)
        Me.lbl0Total.TabIndex = 1
        Me.lbl0Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total shipped:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(340, 26)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(340, 63)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(340, 101)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnDisplay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(432, 209)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipping Depot"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl0Total As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl1FedEx As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl3USPS As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl2UPS As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl6USPSPerc As Label
    Friend WithEvents lbl5UPSPerc As Label
    Friend WithEvents lbl4FedExPerc As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
