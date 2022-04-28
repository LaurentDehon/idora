<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMembers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMembers))
        Me.DORADbDS = New DORA.DORADbDS()
        Me.MEMBERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEMBERSTableAdapter = New DORA.DORADbDSTableAdapters.MEMBERSTableAdapter()
        Me.TableAdapterManager = New DORA.DORADbDSTableAdapters.TableAdapterManager()
        Me.dgvMembers = New System.Windows.Forms.DataGridView()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOBILE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnUndo = New FontAwesome.Sharp.IconButton()
        Me.txtSearchMembers = New System.Windows.Forms.TextBox()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'DORADbDS
        '
        Me.DORADbDS.DataSetName = "DORADbDS"
        Me.DORADbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEMBERSBindingSource
        '
        Me.MEMBERSBindingSource.DataMember = "MEMBERS"
        Me.MEMBERSBindingSource.DataSource = Me.DORADbDS
        '
        'MEMBERSTableAdapter
        '
        Me.MEMBERSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BACKUPTableAdapter = Nothing
        Me.TableAdapterManager.CASESTableAdapter = Nothing
        Me.TableAdapterManager.CITIESTableAdapter = Nothing
        Me.TableAdapterManager.DRUGS_INTTableAdapter = Nothing
        Me.TableAdapterManager.INTERVENTIONSTableAdapter = Nothing
        Me.TableAdapterManager.MEMBERS_INTTableAdapter = Nothing
        Me.TableAdapterManager.MEMBERSTableAdapter = Me.MEMBERSTableAdapter
        Me.TableAdapterManager.PARTNERS_INTTableAdapter = Nothing
        Me.TableAdapterManager.PARTNERSTableAdapter = Nothing
        Me.TableAdapterManager.POLICE_UNITSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTS_INTTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTSTableAdapter = Nothing
        Me.TableAdapterManager.SEIZURETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DORA.DORADbDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'dgvMembers
        '
        Me.dgvMembers.AllowUserToOrderColumns = True
        Me.dgvMembers.AllowUserToResizeRows = False
        Me.dgvMembers.AutoGenerateColumns = False
        Me.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvMembers.ColumnHeadersHeight = 30
        Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LASTNAMEDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.SERVICEDataGridViewTextBoxColumn, Me.PHONE, Me.MOBILE, Me.EMAIL})
        Me.dgvMembers.DataSource = Me.MEMBERSBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMembers.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMembers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMembers.EnableHeadersVisualStyles = False
        Me.dgvMembers.Location = New System.Drawing.Point(4, 59)
        Me.dgvMembers.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMembers.MultiSelect = False
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvMembers.RowHeadersVisible = False
        Me.dgvMembers.RowHeadersWidth = 51
        Me.dgvMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMembers.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMembers.RowTemplate.DividerHeight = 1
        Me.dgvMembers.RowTemplate.Height = 30
        Me.dgvMembers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMembers.Size = New System.Drawing.Size(964, 440)
        Me.dgvMembers.TabIndex = 0
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        Me.LASTNAMEDataGridViewTextBoxColumn.Width = 150
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Width = 125
        '
        'SERVICEDataGridViewTextBoxColumn
        '
        Me.SERVICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SERVICEDataGridViewTextBoxColumn.DataPropertyName = "SERVICE"
        Me.SERVICEDataGridViewTextBoxColumn.HeaderText = "SERVICE"
        Me.SERVICEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SERVICEDataGridViewTextBoxColumn.Name = "SERVICEDataGridViewTextBoxColumn"
        '
        'PHONE
        '
        Me.PHONE.DataPropertyName = "PHONE"
        Me.PHONE.HeaderText = "PHONE"
        Me.PHONE.MinimumWidth = 6
        Me.PHONE.Name = "PHONE"
        Me.PHONE.Width = 125
        '
        'MOBILE
        '
        Me.MOBILE.DataPropertyName = "MOBILE"
        Me.MOBILE.HeaderText = "MOBILE"
        Me.MOBILE.MinimumWidth = 6
        Me.MOBILE.Name = "MOBILE"
        Me.MOBILE.Width = 125
        '
        'EMAIL
        '
        Me.EMAIL.DataPropertyName = "EMAIL"
        Me.EMAIL.HeaderText = "EMAIL"
        Me.EMAIL.MinimumWidth = 6
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.Width = 125
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlTop, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvMembers, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(972, 503)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.btnSave)
        Me.pnlTop.Controls.Add(Me.btnUndo)
        Me.pnlTop.Controls.Add(Me.txtSearchMembers)
        Me.pnlTop.Controls.Add(Me.lblcount)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTop.Location = New System.Drawing.Point(3, 3)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(966, 49)
        Me.pnlTop.TabIndex = 137
        '
        'btnUndo
        '
        Me.btnUndo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUndo.FlatAppearance.BorderSize = 0
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.IconChar = FontAwesome.Sharp.IconChar.Undo
        Me.btnUndo.IconColor = System.Drawing.Color.Black
        Me.btnUndo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUndo.IconSize = 25
        Me.btnUndo.Location = New System.Drawing.Point(288, 8)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(32, 32)
        Me.btnUndo.TabIndex = 137
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'txtSearchMembers
        '
        Me.txtSearchMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchMembers.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchMembers.Location = New System.Drawing.Point(0, 8)
        Me.txtSearchMembers.Name = "txtSearchMembers"
        Me.txtSearchMembers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearchMembers.Size = New System.Drawing.Size(272, 32)
        Me.txtSearchMembers.TabIndex = 0
        '
        'lblcount
        '
        Me.lblcount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.Location = New System.Drawing.Point(696, 16)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(269, 24)
        Me.lblcount.TabIndex = 135
        Me.lblcount.Text = "Count"
        Me.lblcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSave.IconColor = System.Drawing.Color.Black
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnSave.IconSize = 25
        Me.btnSave.Location = New System.Drawing.Point(328, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(32, 32)
        Me.btnSave.TabIndex = 138
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 543)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMembers"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMembers"
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DORADbDS As DORADbDS
    Friend WithEvents MEMBERSBindingSource As BindingSource
    Friend WithEvents MEMBERSTableAdapter As DORADbDSTableAdapters.MEMBERSTableAdapter
    Friend WithEvents TableAdapterManager As DORADbDSTableAdapters.TableAdapterManager
    Friend WithEvents dgvMembers As DataGridView
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SERVICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents PHONE As DataGridViewTextBoxColumn
    Friend WithEvents MOBILE As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnUndo As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSearchMembers As TextBox
    Friend WithEvents lblcount As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
End Class
