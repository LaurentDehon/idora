<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducts))
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DORADbDS = New DORA.DORADbDS()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PRODUCTSTableAdapter = New DORA.DORADbDSTableAdapters.PRODUCTSTableAdapter()
        Me.TableAdapterManager = New DORA.DORADbDSTableAdapters.TableAdapterManager()
        Me.SHORTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnUndo = New FontAwesome.Sharp.IconButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSearchProducts = New System.Windows.Forms.TextBox()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToOrderColumns = True
        Me.dgvProducts.AllowUserToResizeRows = False
        Me.dgvProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducts.AutoGenerateColumns = False
        Me.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProducts.ColumnHeadersHeight = 30
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgvProducts.DataSource = Me.PRODUCTSBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducts.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProducts.EnableHeadersVisualStyles = False
        Me.dgvProducts.Location = New System.Drawing.Point(4, 59)
        Me.dgvProducts.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidth = 51
        Me.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProducts.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProducts.RowTemplate.DividerHeight = 1
        Me.dgvProducts.RowTemplate.Height = 30
        Me.dgvProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(964, 440)
        Me.dgvProducts.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SHORT NAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SHORT NAME"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 300
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FULL NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FULL NAME"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 320
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NOM COMPLET"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NOM COMPLET"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 320
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "VOLLEDIGE NAAM"
        Me.DataGridViewTextBoxColumn4.HeaderText = "VOLLEDIGE NAAM"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 320
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CAS NUM"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CAS NUM"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UN NUM"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UN NUM"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'PRODUCTSBindingSource
        '
        Me.PRODUCTSBindingSource.DataMember = "PRODUCTS"
        Me.PRODUCTSBindingSource.DataSource = Me.DORADbDS
        '
        'DORADbDS
        '
        Me.DORADbDS.DataSetName = "DORADbDS"
        Me.DORADbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PRODUCTSTableAdapter
        '
        Me.PRODUCTSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.MEMBERSTableAdapter = Nothing
        Me.TableAdapterManager.PARTNERS_INTTableAdapter = Nothing
        Me.TableAdapterManager.PARTNERSTableAdapter = Nothing
        Me.TableAdapterManager.POLICE_UNITSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTS_INTTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTSTableAdapter = Me.PRODUCTSTableAdapter
        Me.TableAdapterManager.SEIZURETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DORA.DORADbDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SHORTNAMEDataGridViewTextBoxColumn
        '
        Me.SHORTNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SHORTNAMEDataGridViewTextBoxColumn.DataPropertyName = "SHORT NAME"
        Me.SHORTNAMEDataGridViewTextBoxColumn.HeaderText = "SHORT NAME"
        Me.SHORTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SHORTNAMEDataGridViewTextBoxColumn.Name = "SHORTNAMEDataGridViewTextBoxColumn"
        Me.SHORTNAMEDataGridViewTextBoxColumn.Width = 125
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.txtSearchProducts)
        Me.pnlTop.Controls.Add(Me.btnUndo)
        Me.pnlTop.Controls.Add(Me.lblcount)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTop.Location = New System.Drawing.Point(3, 3)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(966, 49)
        Me.pnlTop.TabIndex = 136
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
        Me.btnUndo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(32, 32)
        Me.btnUndo.TabIndex = 137
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvProducts, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlTop, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(972, 503)
        Me.TableLayoutPanel1.TabIndex = 137
        '
        'txtSearchProducts
        '
        Me.txtSearchProducts.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearchProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchProducts.Location = New System.Drawing.Point(0, 8)
        Me.txtSearchProducts.Name = "txtSearchProducts"
        Me.txtSearchProducts.Size = New System.Drawing.Size(272, 32)
        Me.txtSearchProducts.TabIndex = 140
        '
        'frmProducts
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
        Me.Name = "frmProducts"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProducts"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents DORADbDS As DORADbDS
    Friend WithEvents PRODUCTSBindingSource As BindingSource
    Friend WithEvents PRODUCTSTableAdapter As DORADbDSTableAdapters.PRODUCTSTableAdapter
    Friend WithEvents TableAdapterManager As DORADbDSTableAdapters.TableAdapterManager
    Friend WithEvents lblcount As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents SHORTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnUndo As FontAwesome.Sharp.IconButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtSearchProducts As TextBox
End Class
