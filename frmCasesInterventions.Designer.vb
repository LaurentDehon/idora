<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCasesInterventions
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCasesInterventions))
        Me.cmbSearchCases = New System.Windows.Forms.ComboBox()
        Me.txtSearchCases = New System.Windows.Forms.TextBox()
        Me.dgvCases = New System.Windows.Forms.DataGridView()
        Me.DATEFACTSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CASENAMEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CASESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DORADbDS = New DORA.DORADbDS()
        Me.cmbSearchInterventions = New System.Windows.Forms.ComboBox()
        Me.txtSearchInterventions = New System.Windows.Forms.TextBox()
        Me.dgvInterventions = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.INVENTORY = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.INTDONE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewImageColumn()
        Me.INTERVENTIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CasesTimer = New System.Windows.Forms.Timer(Me.components)
        Me.InterventionsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.fsw = New System.IO.FileSystemWatcher()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.RCMenuInterventions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnViewIntervention = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnOpenIntFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnReassignIntervention = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDeleteInt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCreateIntFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnUpdateIntFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.RCMenuCases = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnViewCase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnNewCase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnOpenCaseFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDeleteCase = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnNewInt = New System.Windows.Forms.ToolStripMenuItem()
        Me.CASESTableAdapter = New DORA.DORADbDSTableAdapters.CASESTableAdapter()
        Me.TableAdapterManager = New DORA.DORADbDSTableAdapters.TableAdapterManager()
        Me.INTERVENTIONSTableAdapter = New DORA.DORADbDSTableAdapters.INTERVENTIONSTableAdapter()
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tbl4 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbl3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbl2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAll = New FontAwesome.Sharp.IconButton()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.tbl1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DATEINTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CASENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TYPEOFINTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADRESSINTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CITYINTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInterventions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fsw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RCMenuInterventions.SuspendLayout()
        Me.RCMenuCases.SuspendLayout()
        Me.tblMain.SuspendLayout()
        Me.tbl4.SuspendLayout()
        Me.tbl3.SuspendLayout()
        Me.tbl2.SuspendLayout()
        Me.tbl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbSearchCases
        '
        Me.cmbSearchCases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSearchCases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchCases.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchCases.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbSearchCases.FormattingEnabled = True
        Me.cmbSearchCases.Location = New System.Drawing.Point(338, 4)
        Me.cmbSearchCases.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSearchCases.Name = "cmbSearchCases"
        Me.cmbSearchCases.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSearchCases.Size = New System.Drawing.Size(192, 32)
        Me.cmbSearchCases.TabIndex = 7
        '
        'txtSearchCases
        '
        Me.txtSearchCases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchCases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchCases.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCases.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSearchCases.Location = New System.Drawing.Point(4, 4)
        Me.txtSearchCases.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchCases.Name = "txtSearchCases"
        Me.txtSearchCases.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearchCases.Size = New System.Drawing.Size(326, 32)
        Me.txtSearchCases.TabIndex = 0
        '
        'dgvCases
        '
        Me.dgvCases.AllowUserToAddRows = False
        Me.dgvCases.AllowUserToDeleteRows = False
        Me.dgvCases.AllowUserToResizeRows = False
        Me.dgvCases.AutoGenerateColumns = False
        Me.dgvCases.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCases.ColumnHeadersHeight = 29
        Me.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCases.ColumnHeadersVisible = False
        Me.dgvCases.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DATEFACTSDataGridViewTextBoxColumn1, Me.CASENAMEDataGridViewTextBoxColumn1})
        Me.dgvCases.DataSource = Me.CASESBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCases.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCases.Location = New System.Drawing.Point(4, 49)
        Me.dgvCases.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCases.MultiSelect = False
        Me.dgvCases.Name = "dgvCases"
        Me.dgvCases.ReadOnly = True
        Me.dgvCases.RowHeadersVisible = False
        Me.dgvCases.RowHeadersWidth = 51
        Me.dgvCases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.dgvCases.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCases.RowTemplate.Height = 30
        Me.dgvCases.RowTemplate.ReadOnly = True
        Me.dgvCases.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCases.Size = New System.Drawing.Size(532, 1027)
        Me.dgvCases.TabIndex = 10
        '
        'DATEFACTSDataGridViewTextBoxColumn1
        '
        Me.DATEFACTSDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DATEFACTSDataGridViewTextBoxColumn1.DataPropertyName = "DATE FACTS"
        DataGridViewCellStyle8.Format = "dd/MM/yyyy"
        Me.DATEFACTSDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DATEFACTSDataGridViewTextBoxColumn1.HeaderText = "DATE FACTS"
        Me.DATEFACTSDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DATEFACTSDataGridViewTextBoxColumn1.Name = "DATEFACTSDataGridViewTextBoxColumn1"
        Me.DATEFACTSDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DATEFACTSDataGridViewTextBoxColumn1.Width = 6
        '
        'CASENAMEDataGridViewTextBoxColumn1
        '
        Me.CASENAMEDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CASENAMEDataGridViewTextBoxColumn1.DataPropertyName = "CASE NAME"
        Me.CASENAMEDataGridViewTextBoxColumn1.HeaderText = "CASE NAME"
        Me.CASENAMEDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.CASENAMEDataGridViewTextBoxColumn1.Name = "CASENAMEDataGridViewTextBoxColumn1"
        Me.CASENAMEDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CASESBindingSource
        '
        Me.CASESBindingSource.DataMember = "CASES"
        Me.CASESBindingSource.DataSource = Me.DORADbDS
        '
        'DORADbDS
        '
        Me.DORADbDS.DataSetName = "DORADbDS"
        Me.DORADbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbSearchInterventions
        '
        Me.cmbSearchInterventions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchInterventions.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchInterventions.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbSearchInterventions.FormattingEnabled = True
        Me.cmbSearchInterventions.Location = New System.Drawing.Point(1092, 4)
        Me.cmbSearchInterventions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSearchInterventions.Name = "cmbSearchInterventions"
        Me.cmbSearchInterventions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSearchInterventions.Size = New System.Drawing.Size(192, 32)
        Me.cmbSearchInterventions.TabIndex = 9
        '
        'txtSearchInterventions
        '
        Me.txtSearchInterventions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchInterventions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchInterventions.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchInterventions.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSearchInterventions.Location = New System.Drawing.Point(4, 4)
        Me.txtSearchInterventions.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchInterventions.Name = "txtSearchInterventions"
        Me.txtSearchInterventions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearchInterventions.Size = New System.Drawing.Size(1080, 32)
        Me.txtSearchInterventions.TabIndex = 1
        '
        'dgvInterventions
        '
        Me.dgvInterventions.AllowUserToAddRows = False
        Me.dgvInterventions.AllowUserToDeleteRows = False
        Me.dgvInterventions.AllowUserToResizeRows = False
        Me.dgvInterventions.AutoGenerateColumns = False
        Me.dgvInterventions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInterventions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInterventions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvInterventions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInterventions.ColumnHeadersVisible = False
        Me.dgvInterventions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1, Me.INVENTORY, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.INTDONE, Me.STATUS})
        Me.dgvInterventions.DataSource = Me.INTERVENTIONSBindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInterventions.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvInterventions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInterventions.Location = New System.Drawing.Point(544, 49)
        Me.dgvInterventions.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvInterventions.MultiSelect = False
        Me.dgvInterventions.Name = "dgvInterventions"
        Me.dgvInterventions.ReadOnly = True
        Me.dgvInterventions.RowHeadersVisible = False
        Me.dgvInterventions.RowHeadersWidth = 51
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.dgvInterventions.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvInterventions.RowTemplate.Height = 30
        Me.dgvInterventions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInterventions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvInterventions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInterventions.Size = New System.Drawing.Size(1372, 1027)
        Me.dgvInterventions.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID CRU"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID CRU"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DATE INT"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DATE INT"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CASE NAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CASE NAME"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TYPE OF INT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TYPE OF INT"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ADRESS INT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ADRESS INT"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CITY INT"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CITY INT"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "CRU REPORT"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "CRU REPORT"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'INVENTORY
        '
        Me.INVENTORY.DataPropertyName = "INVENTORY"
        Me.INVENTORY.HeaderText = "INVENTORY"
        Me.INVENTORY.MinimumWidth = 6
        Me.INVENTORY.Name = "INVENTORY"
        Me.INVENTORY.ReadOnly = True
        Me.INVENTORY.Visible = False
        Me.INVENTORY.Width = 125
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "PICTURES REPORT"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "PICTURES REPORT"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Visible = False
        Me.DataGridViewCheckBoxColumn2.Width = 125
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "NICC REPORT"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "NICC REPORT"
        Me.DataGridViewCheckBoxColumn3.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Visible = False
        Me.DataGridViewCheckBoxColumn3.Width = 125
        '
        'INTDONE
        '
        Me.INTDONE.DataPropertyName = "INTDONE"
        Me.INTDONE.HeaderText = "INTDONE"
        Me.INTDONE.MinimumWidth = 6
        Me.INTDONE.Name = "INTDONE"
        Me.INTDONE.ReadOnly = True
        Me.INTDONE.Visible = False
        Me.INTDONE.Width = 125
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.MinimumWidth = 30
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        Me.STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.STATUS.Width = 30
        '
        'INTERVENTIONSBindingSource
        '
        Me.INTERVENTIONSBindingSource.DataMember = "INTERVENTIONS"
        Me.INTERVENTIONSBindingSource.DataSource = Me.DORADbDS
        '
        'CasesTimer
        '
        Me.CasesTimer.Interval = 500
        '
        'InterventionsTimer
        '
        Me.InterventionsTimer.Interval = 500
        '
        'fsw
        '
        Me.fsw.EnableRaisingEvents = True
        Me.fsw.Filter = "*.dat"
        Me.fsw.Path = "G:\DJSOC\DRUGS\CRU\DORA\SYSTEM"
        Me.fsw.SynchronizingObject = Me
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 10000
        Me.ToolTip.InitialDelay = 500
        Me.ToolTip.IsBalloon = True
        Me.ToolTip.ReshowDelay = 100
        Me.ToolTip.ShowAlways = True
        '
        'RCMenuInterventions
        '
        Me.RCMenuInterventions.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCMenuInterventions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RCMenuInterventions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnViewIntervention, Me.mnOpenIntFolder, Me.mnReassignIntervention, Me.mnDeleteInt, Me.mnCreateIntFolder, Me.mnUpdateIntFolder})
        Me.RCMenuInterventions.Name = "RCMenu"
        Me.RCMenuInterventions.Size = New System.Drawing.Size(276, 172)
        '
        'mnViewIntervention
        '
        Me.mnViewIntervention.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnViewIntervention.Image = Global.DORA.My.Resources.Resources.eye
        Me.mnViewIntervention.Name = "mnViewIntervention"
        Me.mnViewIntervention.Size = New System.Drawing.Size(275, 28)
        Me.mnViewIntervention.Text = "View Intervention"
        '
        'mnOpenIntFolder
        '
        Me.mnOpenIntFolder.Image = Global.DORA.My.Resources.Resources.folder_open
        Me.mnOpenIntFolder.Name = "mnOpenIntFolder"
        Me.mnOpenIntFolder.Size = New System.Drawing.Size(275, 28)
        Me.mnOpenIntFolder.Text = "Open Folder"
        '
        'mnReassignIntervention
        '
        Me.mnReassignIntervention.Image = Global.DORA.My.Resources.Resources.circle_right
        Me.mnReassignIntervention.Name = "mnReassignIntervention"
        Me.mnReassignIntervention.Size = New System.Drawing.Size(275, 28)
        Me.mnReassignIntervention.Text = "Reassign Intervention"
        '
        'mnDeleteInt
        '
        Me.mnDeleteInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnDeleteInt.Image = Global.DORA.My.Resources.Resources.circle_minus
        Me.mnDeleteInt.Name = "mnDeleteInt"
        Me.mnDeleteInt.Size = New System.Drawing.Size(275, 28)
        Me.mnDeleteInt.Text = "Delete"
        '
        'mnCreateIntFolder
        '
        Me.mnCreateIntFolder.Image = CType(resources.GetObject("mnCreateIntFolder.Image"), System.Drawing.Image)
        Me.mnCreateIntFolder.Name = "mnCreateIntFolder"
        Me.mnCreateIntFolder.Size = New System.Drawing.Size(275, 28)
        Me.mnCreateIntFolder.Text = "ADMIN: Create Folder"
        '
        'mnUpdateIntFolder
        '
        Me.mnUpdateIntFolder.Image = CType(resources.GetObject("mnUpdateIntFolder.Image"), System.Drawing.Image)
        Me.mnUpdateIntFolder.Name = "mnUpdateIntFolder"
        Me.mnUpdateIntFolder.Size = New System.Drawing.Size(275, 28)
        Me.mnUpdateIntFolder.Text = "ADMIN: Update Folder"
        '
        'RCMenuCases
        '
        Me.RCMenuCases.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCMenuCases.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RCMenuCases.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnViewCase, Me.mnOpenCaseFolder, Me.mnDeleteCase, Me.ToolStripSeparator1, Me.mnNewCase, Me.mnNewInt})
        Me.RCMenuCases.Name = "RCMenu"
        Me.RCMenuCases.Size = New System.Drawing.Size(232, 150)
        '
        'mnViewCase
        '
        Me.mnViewCase.Image = Global.DORA.My.Resources.Resources.eye
        Me.mnViewCase.Name = "mnViewCase"
        Me.mnViewCase.Size = New System.Drawing.Size(231, 28)
        Me.mnViewCase.Text = "View Case"
        '
        'mnNewCase
        '
        Me.mnNewCase.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnNewCase.Image = Global.DORA.My.Resources.Resources.circle_plus
        Me.mnNewCase.Name = "mnNewCase"
        Me.mnNewCase.Size = New System.Drawing.Size(231, 28)
        Me.mnNewCase.Text = "New Case"
        '
        'mnOpenCaseFolder
        '
        Me.mnOpenCaseFolder.Image = Global.DORA.My.Resources.Resources.folder_open
        Me.mnOpenCaseFolder.Name = "mnOpenCaseFolder"
        Me.mnOpenCaseFolder.Size = New System.Drawing.Size(231, 28)
        Me.mnOpenCaseFolder.Text = "Open Folder"
        '
        'mnDeleteCase
        '
        Me.mnDeleteCase.Image = Global.DORA.My.Resources.Resources.circle_minus
        Me.mnDeleteCase.Name = "mnDeleteCase"
        Me.mnDeleteCase.Size = New System.Drawing.Size(231, 28)
        Me.mnDeleteCase.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(228, 6)
        '
        'mnNewInt
        '
        Me.mnNewInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnNewInt.Image = Global.DORA.My.Resources.Resources.circle_plus
        Me.mnNewInt.Name = "mnNewInt"
        Me.mnNewInt.Size = New System.Drawing.Size(231, 28)
        Me.mnNewInt.Text = "New Intervention"
        '
        'CASESTableAdapter
        '
        Me.CASESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BACKUPTableAdapter = Nothing
        Me.TableAdapterManager.CASESTableAdapter = Me.CASESTableAdapter
        Me.TableAdapterManager.CITIESTableAdapter = Nothing
        Me.TableAdapterManager.DRUGS_INTTableAdapter = Nothing
        Me.TableAdapterManager.INTERVENTIONSTableAdapter = Me.INTERVENTIONSTableAdapter
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
        'INTERVENTIONSTableAdapter
        '
        Me.INTERVENTIONSTableAdapter.ClearBeforeFill = True
        '
        'tblMain
        '
        Me.tblMain.ColumnCount = 2
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.125!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.875!))
        Me.tblMain.Controls.Add(Me.tbl4, 1, 0)
        Me.tblMain.Controls.Add(Me.dgvCases, 0, 1)
        Me.tblMain.Controls.Add(Me.tbl1, 0, 0)
        Me.tblMain.Controls.Add(Me.dgvInterventions, 1, 1)
        Me.tblMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMain.Location = New System.Drawing.Point(0, 0)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 2
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.Size = New System.Drawing.Size(1920, 1080)
        Me.tblMain.TabIndex = 14
        '
        'tbl4
        '
        Me.tbl4.ColumnCount = 2
        Me.tbl4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tbl4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbl4.Controls.Add(Me.tbl3, 1, 0)
        Me.tbl4.Controls.Add(Me.tbl2, 0, 0)
        Me.tbl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbl4.Location = New System.Drawing.Point(543, 3)
        Me.tbl4.Name = "tbl4"
        Me.tbl4.RowCount = 1
        Me.tbl4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbl4.Size = New System.Drawing.Size(1374, 39)
        Me.tbl4.TabIndex = 18
        '
        'tbl3
        '
        Me.tbl3.ColumnCount = 2
        Me.tbl3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbl3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tbl3.Controls.Add(Me.cmbSearchInterventions, 1, 0)
        Me.tbl3.Controls.Add(Me.txtSearchInterventions, 0, 0)
        Me.tbl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbl3.Location = New System.Drawing.Point(83, 3)
        Me.tbl3.Name = "tbl3"
        Me.tbl3.RowCount = 1
        Me.tbl3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbl3.Size = New System.Drawing.Size(1288, 33)
        Me.tbl3.TabIndex = 17
        '
        'tbl2
        '
        Me.tbl2.ColumnCount = 2
        Me.tbl2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tbl2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tbl2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tbl2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tbl2.Controls.Add(Me.btnAll, 0, 0)
        Me.tbl2.Controls.Add(Me.btnRefresh, 1, 0)
        Me.tbl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbl2.Location = New System.Drawing.Point(3, 3)
        Me.tbl2.Name = "tbl2"
        Me.tbl2.RowCount = 1
        Me.tbl2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbl2.Size = New System.Drawing.Size(74, 33)
        Me.tbl2.TabIndex = 16
        '
        'btnAll
        '
        Me.btnAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAll.FlatAppearance.BorderSize = 0
        Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAll.IconChar = FontAwesome.Sharp.IconChar.ListUl
        Me.btnAll.IconColor = System.Drawing.Color.Black
        Me.btnAll.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAll.IconSize = 25
        Me.btnAll.Location = New System.Drawing.Point(3, 3)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(34, 27)
        Me.btnAll.TabIndex = 12
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.SyncAlt
        Me.btnRefresh.IconColor = System.Drawing.Color.Black
        Me.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRefresh.IconSize = 25
        Me.btnRefresh.Location = New System.Drawing.Point(43, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(34, 27)
        Me.btnRefresh.TabIndex = 13
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'tbl1
        '
        Me.tbl1.ColumnCount = 2
        Me.tbl1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbl1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tbl1.Controls.Add(Me.txtSearchCases, 0, 0)
        Me.tbl1.Controls.Add(Me.cmbSearchCases, 1, 0)
        Me.tbl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbl1.Location = New System.Drawing.Point(3, 3)
        Me.tbl1.Name = "tbl1"
        Me.tbl1.RowCount = 1
        Me.tbl1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbl1.Size = New System.Drawing.Size(534, 39)
        Me.tbl1.TabIndex = 15
        '
        'DATEINTDataGridViewTextBoxColumn
        '
        Me.DATEINTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DATEINTDataGridViewTextBoxColumn.DataPropertyName = "DATE INT"
        DataGridViewCellStyle14.Format = "dd/MM/yyyy"
        Me.DATEINTDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.DATEINTDataGridViewTextBoxColumn.HeaderText = "DATE INT"
        Me.DATEINTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DATEINTDataGridViewTextBoxColumn.Name = "DATEINTDataGridViewTextBoxColumn"
        Me.DATEINTDataGridViewTextBoxColumn.Width = 125
        '
        'CASENAMEDataGridViewTextBoxColumn
        '
        Me.CASENAMEDataGridViewTextBoxColumn.DataPropertyName = "CASE NAME"
        Me.CASENAMEDataGridViewTextBoxColumn.HeaderText = "CASE NAME"
        Me.CASENAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CASENAMEDataGridViewTextBoxColumn.Name = "CASENAMEDataGridViewTextBoxColumn"
        Me.CASENAMEDataGridViewTextBoxColumn.Width = 260
        '
        'TYPEOFINTDataGridViewTextBoxColumn
        '
        Me.TYPEOFINTDataGridViewTextBoxColumn.DataPropertyName = "TYPE OF INT"
        Me.TYPEOFINTDataGridViewTextBoxColumn.HeaderText = "TYPE OF INT"
        Me.TYPEOFINTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TYPEOFINTDataGridViewTextBoxColumn.Name = "TYPEOFINTDataGridViewTextBoxColumn"
        Me.TYPEOFINTDataGridViewTextBoxColumn.Width = 200
        '
        'ADRESSINTDataGridViewTextBoxColumn
        '
        Me.ADRESSINTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.ADRESSINTDataGridViewTextBoxColumn.DataPropertyName = "ADRESS INT"
        Me.ADRESSINTDataGridViewTextBoxColumn.HeaderText = "ADRESS INT"
        Me.ADRESSINTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ADRESSINTDataGridViewTextBoxColumn.Name = "ADRESSINTDataGridViewTextBoxColumn"
        Me.ADRESSINTDataGridViewTextBoxColumn.Width = 125
        '
        'CITYINTDataGridViewTextBoxColumn
        '
        Me.CITYINTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CITYINTDataGridViewTextBoxColumn.DataPropertyName = "CITY INT"
        Me.CITYINTDataGridViewTextBoxColumn.HeaderText = "CITY INT"
        Me.CITYINTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CITYINTDataGridViewTextBoxColumn.Name = "CITYINTDataGridViewTextBoxColumn"
        '
        'frmCasesInterventions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.tblMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmCasesInterventions"
        CType(Me.dgvCases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInterventions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fsw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RCMenuInterventions.ResumeLayout(False)
        Me.RCMenuCases.ResumeLayout(False)
        Me.tblMain.ResumeLayout(False)
        Me.tbl4.ResumeLayout(False)
        Me.tbl3.ResumeLayout(False)
        Me.tbl3.PerformLayout()
        Me.tbl2.ResumeLayout(False)
        Me.tbl1.ResumeLayout(False)
        Me.tbl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbSearchCases As ComboBox
    Friend WithEvents txtSearchCases As TextBox
    Friend WithEvents dgvCases As DataGridView
    Friend WithEvents cmbSearchInterventions As ComboBox
    Friend WithEvents txtSearchInterventions As TextBox
    Friend WithEvents dgvInterventions As DataGridView
    Friend WithEvents DORADbDS As DORADbDS
    Friend WithEvents CASESBindingSource As BindingSource
    Friend WithEvents CASESTableAdapter As DORADbDSTableAdapters.CASESTableAdapter
    Friend WithEvents TableAdapterManager As DORADbDSTableAdapters.TableAdapterManager
    Friend WithEvents INTERVENTIONSTableAdapter As DORADbDSTableAdapters.INTERVENTIONSTableAdapter
    Friend WithEvents INTERVENTIONSBindingSource As BindingSource
    Friend WithEvents CasesTimer As Timer
    Friend WithEvents InterventionsTimer As Timer
    Friend WithEvents fsw As IO.FileSystemWatcher
    Friend WithEvents btnAll As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents RCMenuInterventions As ContextMenuStrip
    Friend WithEvents mnViewIntervention As ToolStripMenuItem
    Friend WithEvents mnReassignIntervention As ToolStripMenuItem
    Friend WithEvents mnOpenIntFolder As ToolStripMenuItem
    Friend WithEvents mnCreateIntFolder As ToolStripMenuItem
    Friend WithEvents mnUpdateIntFolder As ToolStripMenuItem
    Friend WithEvents mnDeleteInt As ToolStripMenuItem
    Friend WithEvents mnNewCase As ToolStripMenuItem
    Friend WithEvents mnOpenCaseFolder As ToolStripMenuItem
    Friend WithEvents mnDeleteCase As ToolStripMenuItem
    Friend WithEvents mnNewInt As ToolStripMenuItem
    Friend WithEvents RCMenuCases As ContextMenuStrip
    Friend WithEvents tblMain As TableLayoutPanel
    Friend WithEvents tbl2 As TableLayoutPanel
    Friend WithEvents tbl1 As TableLayoutPanel
    Friend WithEvents tbl4 As TableLayoutPanel
    Friend WithEvents tbl3 As TableLayoutPanel
    Friend WithEvents DATEFACTSDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CASENAMEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DATEINTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CASENAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TYPEOFINTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADRESSINTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CITYINTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents INVENTORY As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents INTDONE As DataGridViewCheckBoxColumn
    Friend WithEvents STATUS As DataGridViewImageColumn
    Friend WithEvents mnViewCase As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
