<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdministration
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministration))
        Me.lblRight = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.lblBottom = New System.Windows.Forms.Label()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.dgvSeizures = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEIZUREBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DORADbDS = New DORA.DORADbDS()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.RCMenuIntervention = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnViewIntervention = New System.Windows.Forms.ToolStripMenuItem()
        Me.RCMenuCase = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnViewCase = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtSearchInv = New System.Windows.Forms.TextBox()
        Me.cmbYearInv = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dgvCheck = New System.Windows.Forms.DataGridView()
        Me.txtSeizure = New System.Windows.Forms.TextBox()
        Me.gbCheck = New System.Windows.Forms.GroupBox()
        Me.gbInventory = New System.Windows.Forms.GroupBox()
        Me.gbSeizure = New System.Windows.Forms.GroupBox()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.txtSearchSeizure = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.RCMenuSeizure = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnViewSeizure = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDeleteSeizure = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.picMin = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.RCMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RCMenuInventory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnViewInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDINTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New DORA.DORADbDSTableAdapters.TableAdapterManager()
        Me.SEIZURETableAdapter = New DORA.DORADbDSTableAdapters.SEIZURETableAdapter()
        Me.CASESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CASESTableAdapter = New DORA.DORADbDSTableAdapters.CASESTableAdapter()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSeizures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEIZUREBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RCMenuIntervention.SuspendLayout()
        Me.RCMenuCase.SuspendLayout()
        CType(Me.dgvCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCheck.SuspendLayout()
        Me.gbInventory.SuspendLayout()
        Me.gbSeizure.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RCMenuSeizure.SuspendLayout()
        CType(Me.picMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RCMenu.SuspendLayout()
        Me.RCMenuInventory.SuspendLayout()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRight
        '
        Me.lblRight.BackColor = System.Drawing.Color.Orange
        Me.lblRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblRight.Location = New System.Drawing.Point(1282, 16)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(8, 753)
        Me.lblRight.TabIndex = 129
        '
        'lblLeft
        '
        Me.lblLeft.BackColor = System.Drawing.Color.Orange
        Me.lblLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblLeft.Location = New System.Drawing.Point(0, 16)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(8, 753)
        Me.lblLeft.TabIndex = 128
        '
        'lblBottom
        '
        Me.lblBottom.BackColor = System.Drawing.Color.Orange
        Me.lblBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblBottom.Location = New System.Drawing.Point(0, 769)
        Me.lblBottom.Name = "lblBottom"
        Me.lblBottom.Size = New System.Drawing.Size(1290, 8)
        Me.lblBottom.TabIndex = 127
        '
        'lblTop
        '
        Me.lblTop.BackColor = System.Drawing.Color.Orange
        Me.lblTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTop.Location = New System.Drawing.Point(0, 0)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(1290, 16)
        Me.lblTop.TabIndex = 126
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.AllowUserToResizeColumns = False
        Me.dgvInventory.AllowUserToResizeRows = False
        Me.dgvInventory.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInventory.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventory.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInventory.Location = New System.Drawing.Point(16, 56)
        Me.dgvInventory.MultiSelect = False
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowHeadersVisible = False
        Me.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvInventory.RowTemplate.ReadOnly = True
        Me.dgvInventory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventory.Size = New System.Drawing.Size(304, 600)
        Me.dgvInventory.TabIndex = 2
        '
        'dgvSeizures
        '
        Me.dgvSeizures.AllowUserToAddRows = False
        Me.dgvSeizures.AllowUserToDeleteRows = False
        Me.dgvSeizures.AllowUserToResizeColumns = False
        Me.dgvSeizures.AllowUserToResizeRows = False
        Me.dgvSeizures.AutoGenerateColumns = False
        Me.dgvSeizures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSeizures.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvSeizures.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvSeizures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSeizures.ColumnHeadersVisible = False
        Me.dgvSeizures.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.NUM, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        Me.dgvSeizures.DataSource = Me.SEIZUREBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSeizures.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSeizures.Location = New System.Drawing.Point(16, 56)
        Me.dgvSeizures.MultiSelect = False
        Me.dgvSeizures.Name = "dgvSeizures"
        Me.dgvSeizures.ReadOnly = True
        Me.dgvSeizures.RowHeadersVisible = False
        Me.dgvSeizures.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSeizures.RowTemplate.ReadOnly = True
        Me.dgvSeizures.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSeizures.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSeizures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSeizures.Size = New System.Drawing.Size(504, 448)
        Me.dgvSeizures.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID INT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID INT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DATE INT"
        DataGridViewCellStyle2.Format = "dd/MM/yyyy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "DATE INT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'NUM
        '
        Me.NUM.DataPropertyName = "NUM"
        Me.NUM.HeaderText = "NUM"
        Me.NUM.Name = "NUM"
        Me.NUM.ReadOnly = True
        Me.NUM.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CASE NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CASE NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DESC"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DESC"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'SEIZUREBindingSource
        '
        Me.SEIZUREBindingSource.DataMember = "SEIZURE"
        Me.SEIZUREBindingSource.DataSource = Me.DORADbDS
        '
        'DORADbDS
        '
        Me.DORADbDS.DataSetName = "DORADbDS"
        Me.DORADbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(16, 24)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(304, 27)
        Me.cmbSearch.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Orange
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1224, 712)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(40, 40)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'RCMenuIntervention
        '
        Me.RCMenuIntervention.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCMenuIntervention.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnViewIntervention})
        Me.RCMenuIntervention.Name = "RCMenu"
        Me.RCMenuIntervention.Size = New System.Drawing.Size(201, 28)
        '
        'mnViewIntervention
        '
        Me.mnViewIntervention.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnViewIntervention.Name = "mnViewIntervention"
        Me.mnViewIntervention.Size = New System.Drawing.Size(200, 24)
        Me.mnViewIntervention.Text = "View Intervention"
        '
        'RCMenuCase
        '
        Me.RCMenuCase.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCMenuCase.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnViewCase})
        Me.RCMenuCase.Name = "RCMenu"
        Me.RCMenuCase.Size = New System.Drawing.Size(146, 28)
        '
        'mnViewCase
        '
        Me.mnViewCase.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnViewCase.Name = "mnViewCase"
        Me.mnViewCase.Size = New System.Drawing.Size(145, 24)
        Me.mnViewCase.Text = "View Case"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Orange
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(1128, 712)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(40, 40)
        Me.btnOk.TabIndex = 3
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'txtSearchInv
        '
        Me.txtSearchInv.Location = New System.Drawing.Point(16, 24)
        Me.txtSearchInv.Name = "txtSearchInv"
        Me.txtSearchInv.Size = New System.Drawing.Size(216, 27)
        Me.txtSearchInv.TabIndex = 0
        '
        'cmbYearInv
        '
        Me.cmbYearInv.FormattingEnabled = True
        Me.cmbYearInv.Location = New System.Drawing.Point(240, 24)
        Me.cmbYearInv.Name = "cmbYearInv"
        Me.cmbYearInv.Size = New System.Drawing.Size(80, 27)
        Me.cmbYearInv.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'dgvCheck
        '
        Me.dgvCheck.AllowUserToAddRows = False
        Me.dgvCheck.AllowUserToDeleteRows = False
        Me.dgvCheck.AllowUserToResizeColumns = False
        Me.dgvCheck.AllowUserToResizeRows = False
        Me.dgvCheck.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvCheck.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCheck.ColumnHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCheck.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCheck.Location = New System.Drawing.Point(16, 56)
        Me.dgvCheck.MultiSelect = False
        Me.dgvCheck.Name = "dgvCheck"
        Me.dgvCheck.ReadOnly = True
        Me.dgvCheck.RowHeadersVisible = False
        Me.dgvCheck.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCheck.RowTemplate.ReadOnly = True
        Me.dgvCheck.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCheck.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCheck.Size = New System.Drawing.Size(304, 600)
        Me.dgvCheck.TabIndex = 1
        '
        'txtSeizure
        '
        Me.txtSeizure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeizure.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEIZUREBindingSource, "DESC", True))
        Me.txtSeizure.Location = New System.Drawing.Point(16, 512)
        Me.txtSeizure.Multiline = True
        Me.txtSeizure.Name = "txtSeizure"
        Me.txtSeizure.Size = New System.Drawing.Size(352, 144)
        Me.txtSeizure.TabIndex = 2
        '
        'gbCheck
        '
        Me.gbCheck.Controls.Add(Me.dgvCheck)
        Me.gbCheck.Controls.Add(Me.cmbSearch)
        Me.gbCheck.Location = New System.Drawing.Point(24, 24)
        Me.gbCheck.Name = "gbCheck"
        Me.gbCheck.Size = New System.Drawing.Size(336, 672)
        Me.gbCheck.TabIndex = 0
        Me.gbCheck.TabStop = False
        Me.gbCheck.Text = "Check"
        '
        'gbInventory
        '
        Me.gbInventory.Controls.Add(Me.dgvInventory)
        Me.gbInventory.Controls.Add(Me.txtSearchInv)
        Me.gbInventory.Controls.Add(Me.cmbYearInv)
        Me.gbInventory.Location = New System.Drawing.Point(376, 24)
        Me.gbInventory.Name = "gbInventory"
        Me.gbInventory.Size = New System.Drawing.Size(336, 672)
        Me.gbInventory.TabIndex = 1
        Me.gbInventory.TabStop = False
        Me.gbInventory.Text = "Inventory Search"
        '
        'gbSeizure
        '
        Me.gbSeizure.Controls.Add(Me.pic)
        Me.gbSeizure.Controls.Add(Me.txtSearchSeizure)
        Me.gbSeizure.Controls.Add(Me.dgvSeizures)
        Me.gbSeizure.Controls.Add(Me.txtSeizure)
        Me.gbSeizure.Location = New System.Drawing.Point(728, 24)
        Me.gbSeizure.Name = "gbSeizure"
        Me.gbSeizure.Size = New System.Drawing.Size(536, 672)
        Me.gbSeizure.TabIndex = 2
        Me.gbSeizure.TabStop = False
        Me.gbSeizure.Text = "Seizure"
        '
        'pic
        '
        Me.pic.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pic.Location = New System.Drawing.Point(376, 512)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(144, 144)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic.TabIndex = 3
        Me.pic.TabStop = False
        '
        'txtSearchSeizure
        '
        Me.txtSearchSeizure.Location = New System.Drawing.Point(16, 24)
        Me.txtSearchSeizure.Name = "txtSearchSeizure"
        Me.txtSearchSeizure.Size = New System.Drawing.Size(504, 27)
        Me.txtSearchSeizure.TabIndex = 0
        '
        'Timer2
        '
        '
        'RCMenuSeizure
        '
        Me.RCMenuSeizure.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCMenuSeizure.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnViewSeizure, Me.mnDeleteSeizure})
        Me.RCMenuSeizure.Name = "RCMenu"
        Me.RCMenuSeizure.Size = New System.Drawing.Size(201, 52)
        '
        'mnViewSeizure
        '
        Me.mnViewSeizure.Name = "mnViewSeizure"
        Me.mnViewSeizure.Size = New System.Drawing.Size(200, 24)
        Me.mnViewSeizure.Text = "View Intervention"
        '
        'mnDeleteSeizure
        '
        Me.mnDeleteSeizure.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnDeleteSeizure.Name = "mnDeleteSeizure"
        Me.mnDeleteSeizure.Size = New System.Drawing.Size(200, 24)
        Me.mnDeleteSeizure.Text = "Delete Seizure"
        '
        'picMin
        '
        Me.picMin.BackColor = System.Drawing.Color.Orange
        Me.picMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMin.Location = New System.Drawing.Point(1264, 0)
        Me.picMin.Name = "picMin"
        Me.picMin.Size = New System.Drawing.Size(16, 16)
        Me.picMin.TabIndex = 150
        Me.picMin.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Orange
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1176, 712)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(40, 40)
        Me.btnSave.TabIndex = 4
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'RCMenu
        '
        Me.RCMenu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.RCMenu.Name = "RCMenu"
        Me.RCMenu.Size = New System.Drawing.Size(181, 50)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'RCMenuInventory
        '
        Me.RCMenuInventory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCMenuInventory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnViewInventory})
        Me.RCMenuInventory.Name = "RCMenu"
        Me.RCMenuInventory.Size = New System.Drawing.Size(201, 28)
        '
        'mnViewInventory
        '
        Me.mnViewInventory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnViewInventory.Name = "mnViewInventory"
        Me.mnViewInventory.Size = New System.Drawing.Size(200, 24)
        Me.mnViewInventory.Text = "View Intervention"
        '
        'IDINTDataGridViewTextBoxColumn
        '
        Me.IDINTDataGridViewTextBoxColumn.DataPropertyName = "ID INT"
        Me.IDINTDataGridViewTextBoxColumn.HeaderText = "ID INT"
        Me.IDINTDataGridViewTextBoxColumn.Name = "IDINTDataGridViewTextBoxColumn"
        Me.IDINTDataGridViewTextBoxColumn.Visible = False
        Me.IDINTDataGridViewTextBoxColumn.Width = 5
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BACKUPTableAdapter = Nothing
        Me.TableAdapterManager.CASESTableAdapter = Nothing
        Me.TableAdapterManager.CITIESTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DRUGS_INTTableAdapter = Nothing
        Me.TableAdapterManager.INTERVENTIONSTableAdapter = Nothing
        Me.TableAdapterManager.MEMBERS_INTTableAdapter = Nothing
        Me.TableAdapterManager.MEMBERSTableAdapter = Nothing
        Me.TableAdapterManager.PARTNERS_INTTableAdapter = Nothing
        Me.TableAdapterManager.PARTNERSTableAdapter = Nothing
        Me.TableAdapterManager.POLICE_UNITSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTS_INTTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTSTableAdapter = Nothing
        Me.TableAdapterManager.SEIZURETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DORA.DORADbDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SEIZURETableAdapter
        '
        Me.SEIZURETableAdapter.ClearBeforeFill = True
        '
        'CASESBindingSource
        '
        Me.CASESBindingSource.DataMember = "CASES"
        Me.CASESBindingSource.DataSource = Me.DORADbDS
        '
        'CASESTableAdapter
        '
        Me.CASESTableAdapter.ClearBeforeFill = True
        '
        'frmAdministration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1290, 777)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.picMin)
        Me.Controls.Add(Me.gbSeizure)
        Me.Controls.Add(Me.gbInventory)
        Me.Controls.Add(Me.gbCheck)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblBottom)
        Me.Controls.Add(Me.lblTop)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAdministration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdministration"
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSeizures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEIZUREBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RCMenuIntervention.ResumeLayout(False)
        Me.RCMenuCase.ResumeLayout(False)
        CType(Me.dgvCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCheck.ResumeLayout(False)
        Me.gbInventory.ResumeLayout(False)
        Me.gbInventory.PerformLayout()
        Me.gbSeizure.ResumeLayout(False)
        Me.gbSeizure.PerformLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RCMenuSeizure.ResumeLayout(False)
        CType(Me.picMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RCMenu.ResumeLayout(False)
        Me.RCMenuInventory.ResumeLayout(False)
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblRight As Label
    Friend WithEvents lblLeft As Label
    Friend WithEvents lblBottom As Label
    Friend WithEvents lblTop As Label
    Friend WithEvents DORADbDS As DORADbDS
    Friend WithEvents TableAdapterManager As DORADbDSTableAdapters.TableAdapterManager
    Friend WithEvents SEIZUREBindingSource As BindingSource
    Friend WithEvents SEIZURETableAdapter As DORADbDSTableAdapters.SEIZURETableAdapter
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents dgvSeizures As DataGridView
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents RCMenuIntervention As ContextMenuStrip
    Friend WithEvents mnViewIntervention As ToolStripMenuItem
    Friend WithEvents RCMenuCase As ContextMenuStrip
    Friend WithEvents mnViewCase As ToolStripMenuItem
    Friend WithEvents btnOk As Button
    Friend WithEvents txtSearchInv As TextBox
    Friend WithEvents cmbYearInv As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dgvCheck As DataGridView
    Friend WithEvents CASESBindingSource As BindingSource
    Friend WithEvents CASESTableAdapter As DORADbDSTableAdapters.CASESTableAdapter
    Friend WithEvents txtSeizure As TextBox
    Friend WithEvents gbCheck As GroupBox
    Friend WithEvents gbInventory As GroupBox
    Friend WithEvents gbSeizure As GroupBox
    Friend WithEvents txtSearchSeizure As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents RCMenuSeizure As ContextMenuStrip
    Friend WithEvents mnDeleteSeizure As ToolStripMenuItem
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents picMin As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents RCMenu As ContextMenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RCMenuInventory As ContextMenuStrip
    Friend WithEvents mnViewInventory As ToolStripMenuItem
    Friend WithEvents mnViewSeizure As ToolStripMenuItem
    Friend WithEvents IDINTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents pic As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents NUM As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
