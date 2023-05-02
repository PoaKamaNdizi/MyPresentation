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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OwnershipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClancyDataSet = New Clancy_Project.ClancyDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl3T = New System.Windows.Forms.Label()
        Me.lbl2F = New System.Windows.Forms.Label()
        Me.lbl1C = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StoresTableAdapter = New Clancy_Project.ClancyDataSetTableAdapters.StoresTableAdapter()
        Me.TableAdapterManager = New Clancy_Project.ClancyDataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClancyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StoreDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.SalesDataGridViewTextBoxColumn, Me.OwnershipDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StoresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(537, 200)
        Me.DataGridView1.TabIndex = 0
        '
        'StoreDataGridViewTextBoxColumn
        '
        Me.StoreDataGridViewTextBoxColumn.DataPropertyName = "Store"
        Me.StoreDataGridViewTextBoxColumn.HeaderText = "Store"
        Me.StoreDataGridViewTextBoxColumn.Name = "StoreDataGridViewTextBoxColumn"
        Me.StoreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalesDataGridViewTextBoxColumn
        '
        Me.SalesDataGridViewTextBoxColumn.DataPropertyName = "Sales"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.SalesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.SalesDataGridViewTextBoxColumn.HeaderText = "Sales"
        Me.SalesDataGridViewTextBoxColumn.Name = "SalesDataGridViewTextBoxColumn"
        Me.SalesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OwnershipDataGridViewTextBoxColumn
        '
        Me.OwnershipDataGridViewTextBoxColumn.DataPropertyName = "Ownership"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.OwnershipDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.OwnershipDataGridViewTextBoxColumn.HeaderText = "Ownership"
        Me.OwnershipDataGridViewTextBoxColumn.Name = "OwnershipDataGridViewTextBoxColumn"
        Me.OwnershipDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StoresBindingSource
        '
        Me.StoresBindingSource.DataMember = "Stores"
        Me.StoresBindingSource.DataSource = Me.ClancyDataSet
        '
        'ClancyDataSet
        '
        Me.ClancyDataSet.DataSetName = "ClancyDataSet"
        Me.ClancyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl3T)
        Me.GroupBox1.Controls.Add(Me.lbl2F)
        Me.GroupBox1.Controls.Add(Me.lbl1C)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(151, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 161)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales"
        '
        'lbl3T
        '
        Me.lbl3T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3T.Location = New System.Drawing.Point(127, 117)
        Me.lbl3T.Name = "lbl3T"
        Me.lbl3T.Size = New System.Drawing.Size(78, 22)
        Me.lbl3T.TabIndex = 4
        Me.lbl3T.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl2F
        '
        Me.lbl2F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2F.Location = New System.Drawing.Point(127, 76)
        Me.lbl2F.Name = "lbl2F"
        Me.lbl2F.Size = New System.Drawing.Size(78, 22)
        Me.lbl2F.TabIndex = 4
        Me.lbl2F.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl1C
        '
        Me.lbl1C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1C.Location = New System.Drawing.Point(127, 36)
        Me.lbl1C.Name = "lbl1C"
        Me.lbl1C.Size = New System.Drawing.Size(78, 22)
        Me.lbl1C.TabIndex = 3
        Me.lbl1C.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Franchisee:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company-owned:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(465, 251)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(86, 30)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(465, 304)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 30)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StoresTableAdapter
        '
        Me.StoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StoresTableAdapter = Me.StoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = Clancy_Project.ClancyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 410)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clancy Boutique"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClancyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl1C As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbl3T As Label
    Friend WithEvents lbl2F As Label
    Friend WithEvents ClancyDataSet As ClancyDataSet
    Friend WithEvents StoresBindingSource As BindingSource
    Friend WithEvents StoresTableAdapter As ClancyDataSetTableAdapters.StoresTableAdapter
    Friend WithEvents TableAdapterManager As ClancyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StoreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OwnershipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
