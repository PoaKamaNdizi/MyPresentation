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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalHours = New System.Windows.Forms.Label()
        Me.lblTotalSalaries = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad7TotalDes = New System.Windows.Forms.RadioButton()
        Me.rad6TotalAsc = New System.Windows.Forms.RadioButton()
        Me.rad5HoursWorkedDes = New System.Windows.Forms.RadioButton()
        Me.rad4HoursWorkedAsc = New System.Windows.Forms.RadioButton()
        Me.rad3PerHourDes = New System.Windows.Forms.RadioButton()
        Me.rad2PerHourAsc = New System.Windows.Forms.RadioButton()
        Me.rad1IdAsc = New System.Windows.Forms.RadioButton()
        Me.MyTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MyTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyDatabaseDataSet = New OnYourOwn_Project.MyDatabaseDataSet()
        Me.TotalSumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyTableTableAdapter = New OnYourOwn_Project.MyDatabaseDataSetTableAdapters.MyTableTableAdapter()
        Me.TableAdapterManager = New OnYourOwn_Project.MyDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TotalSumsTableAdapter = New OnYourOwn_Project.MyDatabaseDataSetTableAdapters.TotalSumsTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MyTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalSumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Hours:"
        '
        'lblTotalHours
        '
        Me.lblTotalHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalHours.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TotalSumsBindingSource, "TotalHours", True))
        Me.lblTotalHours.Location = New System.Drawing.Point(117, 228)
        Me.lblTotalHours.Name = "lblTotalHours"
        Me.lblTotalHours.Size = New System.Drawing.Size(62, 20)
        Me.lblTotalHours.TabIndex = 4
        Me.lblTotalHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalSalaries
        '
        Me.lblTotalSalaries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSalaries.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TotalSumsBindingSource, "TotalSalaries", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.lblTotalSalaries.Location = New System.Drawing.Point(312, 228)
        Me.lblTotalSalaries.Name = "lblTotalSalaries"
        Me.lblTotalSalaries.Size = New System.Drawing.Size(87, 20)
        Me.lblTotalSalaries.TabIndex = 6
        Me.lblTotalSalaries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total Salaries:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(564, 228)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(133, 35)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(707, 228)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(59, 35)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad7TotalDes)
        Me.GroupBox1.Controls.Add(Me.rad6TotalAsc)
        Me.GroupBox1.Controls.Add(Me.rad5HoursWorkedDes)
        Me.GroupBox1.Controls.Add(Me.rad4HoursWorkedAsc)
        Me.GroupBox1.Controls.Add(Me.rad3PerHourDes)
        Me.GroupBox1.Controls.Add(Me.rad2PerHourAsc)
        Me.GroupBox1.Controls.Add(Me.rad1IdAsc)
        Me.GroupBox1.Location = New System.Drawing.Point(564, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 210)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display by:"
        '
        'rad7TotalDes
        '
        Me.rad7TotalDes.AutoSize = True
        Me.rad7TotalDes.Location = New System.Drawing.Point(18, 171)
        Me.rad7TotalDes.Name = "rad7TotalDes"
        Me.rad7TotalDes.Size = New System.Drawing.Size(122, 19)
        Me.rad7TotalDes.TabIndex = 6
        Me.rad7TotalDes.Text = "Total descending"
        Me.rad7TotalDes.UseVisualStyleBackColor = True
        '
        'rad6TotalAsc
        '
        Me.rad6TotalAsc.AutoSize = True
        Me.rad6TotalAsc.Location = New System.Drawing.Point(18, 146)
        Me.rad6TotalAsc.Name = "rad6TotalAsc"
        Me.rad6TotalAsc.Size = New System.Drawing.Size(115, 19)
        Me.rad6TotalAsc.TabIndex = 5
        Me.rad6TotalAsc.Text = "Total ascending"
        Me.rad6TotalAsc.UseVisualStyleBackColor = True
        '
        'rad5HoursWorkedDes
        '
        Me.rad5HoursWorkedDes.AutoSize = True
        Me.rad5HoursWorkedDes.Location = New System.Drawing.Point(18, 121)
        Me.rad5HoursWorkedDes.Name = "rad5HoursWorkedDes"
        Me.rad5HoursWorkedDes.Size = New System.Drawing.Size(174, 19)
        Me.rad5HoursWorkedDes.TabIndex = 4
        Me.rad5HoursWorkedDes.Text = "HoursWorked descending"
        Me.rad5HoursWorkedDes.UseVisualStyleBackColor = True
        '
        'rad4HoursWorkedAsc
        '
        Me.rad4HoursWorkedAsc.AutoSize = True
        Me.rad4HoursWorkedAsc.Location = New System.Drawing.Point(18, 96)
        Me.rad4HoursWorkedAsc.Name = "rad4HoursWorkedAsc"
        Me.rad4HoursWorkedAsc.Size = New System.Drawing.Size(167, 19)
        Me.rad4HoursWorkedAsc.TabIndex = 3
        Me.rad4HoursWorkedAsc.Text = "HoursWorked ascending"
        Me.rad4HoursWorkedAsc.UseVisualStyleBackColor = True
        '
        'rad3PerHourDes
        '
        Me.rad3PerHourDes.AutoSize = True
        Me.rad3PerHourDes.Location = New System.Drawing.Point(18, 71)
        Me.rad3PerHourDes.Name = "rad3PerHourDes"
        Me.rad3PerHourDes.Size = New System.Drawing.Size(142, 19)
        Me.rad3PerHourDes.TabIndex = 2
        Me.rad3PerHourDes.Text = "PerHour descending"
        Me.rad3PerHourDes.UseVisualStyleBackColor = True
        '
        'rad2PerHourAsc
        '
        Me.rad2PerHourAsc.AutoSize = True
        Me.rad2PerHourAsc.Location = New System.Drawing.Point(18, 46)
        Me.rad2PerHourAsc.Name = "rad2PerHourAsc"
        Me.rad2PerHourAsc.Size = New System.Drawing.Size(135, 19)
        Me.rad2PerHourAsc.TabIndex = 1
        Me.rad2PerHourAsc.Text = "PerHour ascending"
        Me.rad2PerHourAsc.UseVisualStyleBackColor = True
        '
        'rad1IdAsc
        '
        Me.rad1IdAsc.AutoSize = True
        Me.rad1IdAsc.Checked = True
        Me.rad1IdAsc.Location = New System.Drawing.Point(18, 21)
        Me.rad1IdAsc.Name = "rad1IdAsc"
        Me.rad1IdAsc.Size = New System.Drawing.Size(147, 19)
        Me.rad1IdAsc.TabIndex = 0
        Me.rad1IdAsc.TabStop = True
        Me.rad1IdAsc.Text = "ID number ascending"
        Me.rad1IdAsc.UseVisualStyleBackColor = True
        '
        'MyTableDataGridView
        '
        Me.MyTableDataGridView.AllowUserToAddRows = False
        Me.MyTableDataGridView.AllowUserToDeleteRows = False
        Me.MyTableDataGridView.AllowUserToResizeColumns = False
        Me.MyTableDataGridView.AllowUserToResizeRows = False
        Me.MyTableDataGridView.AutoGenerateColumns = False
        Me.MyTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MyTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MyTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.MyTableDataGridView.DataSource = Me.MyTableBindingSource
        Me.MyTableDataGridView.Location = New System.Drawing.Point(12, 7)
        Me.MyTableDataGridView.Name = "MyTableDataGridView"
        Me.MyTableDataGridView.ReadOnly = True
        Me.MyTableDataGridView.Size = New System.Drawing.Size(535, 190)
        Me.MyTableDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 44
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 91
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PerHour"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "PerHour"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 79
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "HoursWorked"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "HoursWorked"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Total Salary"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total Salary"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'MyTableBindingSource
        '
        Me.MyTableBindingSource.DataMember = "MyTable"
        Me.MyTableBindingSource.DataSource = Me.MyDatabaseDataSet
        '
        'MyDatabaseDataSet
        '
        Me.MyDatabaseDataSet.DataSetName = "MyDatabaseDataSet"
        Me.MyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TotalSumsBindingSource
        '
        Me.TotalSumsBindingSource.DataMember = "TotalSums"
        Me.TotalSumsBindingSource.DataSource = Me.MyDatabaseDataSet
        '
        'MyTableTableAdapter
        '
        Me.MyTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MyTableTableAdapter = Me.MyTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = OnYourOwn_Project.MyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TotalSumsTableAdapter
        '
        Me.TotalSumsTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnDisplay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(781, 275)
        Me.Controls.Add(Me.MyTableDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblTotalSalaries)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotalHours)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "15.OnYourOwn Solution_EXERCISE 8"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MyTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalSumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDatabaseDataSet As MyDatabaseDataSet
    Friend WithEvents MyTableBindingSource As BindingSource
    Friend WithEvents MyTableTableAdapter As MyDatabaseDataSetTableAdapters.MyTableTableAdapter
    Friend WithEvents TableAdapterManager As MyDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalHours As Label
    Friend WithEvents lblTotalSalaries As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rad1IdAsc As RadioButton
    Friend WithEvents rad6TotalAsc As RadioButton
    Friend WithEvents rad5HoursWorkedDes As RadioButton
    Friend WithEvents rad4HoursWorkedAsc As RadioButton
    Friend WithEvents rad3PerHourDes As RadioButton
    Friend WithEvents rad2PerHourAsc As RadioButton
    Friend WithEvents rad7TotalDes As RadioButton
    Friend WithEvents MyTableDataGridView As DataGridView
    Friend WithEvents TotalSumsBindingSource As BindingSource
    Friend WithEvents TotalSumsTableAdapter As MyDatabaseDataSetTableAdapters.TotalSumsTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
