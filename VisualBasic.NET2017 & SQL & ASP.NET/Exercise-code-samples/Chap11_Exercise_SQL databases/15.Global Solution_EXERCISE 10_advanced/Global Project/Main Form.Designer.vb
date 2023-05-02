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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GlobalDataSet = New Global_Project.GlobalDataSet()
        Me.SalespeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalespeopleTableAdapter = New Global_Project.GlobalDataSetTableAdapters.SalespeopleTableAdapter()
        Me.TableAdapterManager = New Global_Project.GlobalDataSetTableAdapters.TableAdapterManager()
        Me.SalesIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GlobalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalespeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalesIdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.SalesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SalespeopleBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(344, 131)
        Me.DataGridView1.TabIndex = 0
        '
        'GlobalDataSet
        '
        Me.GlobalDataSet.DataSetName = "GlobalDataSet"
        Me.GlobalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalespeopleBindingSource
        '
        Me.SalespeopleBindingSource.DataMember = "Salespeople"
        Me.SalespeopleBindingSource.DataSource = Me.GlobalDataSet
        '
        'SalespeopleTableAdapter
        '
        Me.SalespeopleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Global_Project.GlobalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalesIdDataGridViewTextBoxColumn
        '
        Me.SalesIdDataGridViewTextBoxColumn.DataPropertyName = "SalesId"
        Me.SalesIdDataGridViewTextBoxColumn.HeaderText = "SalesId"
        Me.SalesIdDataGridViewTextBoxColumn.Name = "SalesIdDataGridViewTextBoxColumn"
        Me.SalesIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalesDataGridViewTextBoxColumn
        '
        Me.SalesDataGridViewTextBoxColumn.DataPropertyName = "Sales"
        DataGridViewCellStyle1.Format = "C0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.SalesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.SalesDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.SalesDataGridViewTextBoxColumn.HeaderText = "Sales"
        Me.SalesDataGridViewTextBoxColumn.Name = "SalesDataGridViewTextBoxColumn"
        Me.SalesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 131)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Liberation Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Global Sales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GlobalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalespeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GlobalDataSet As GlobalDataSet
    Friend WithEvents SalespeopleBindingSource As BindingSource
    Friend WithEvents SalespeopleTableAdapter As GlobalDataSetTableAdapters.SalespeopleTableAdapter
    Friend WithEvents TableAdapterManager As GlobalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
