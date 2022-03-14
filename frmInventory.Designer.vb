<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventory
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtSamples = New System.Windows.Forms.TextBox()
        Me.cmbSamplesT = New System.Windows.Forms.ComboBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgvPicsO = New System.Windows.Forms.DataGridView()
        Me.txtNumR = New System.Windows.Forms.TextBox()
        Me.txtDescR = New System.Windows.Forms.TextBox()
        Me.DORADbDS = New DORA.DORADbDS()
        Me.SEIZUREBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SEIZURETableAdapter = New DORA.DORADbDSTableAdapters.SEIZURETableAdapter()
        Me.TableAdapterManager = New DORA.DORADbDSTableAdapters.TableAdapterManager()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bgw = New System.ComponentModel.BackgroundWorker()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvPics = New System.Windows.Forms.DataGridView()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.pnlInv = New System.Windows.Forms.Panel()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.pnlPics = New System.Windows.Forms.Panel()
        Me.pnlPicsO = New System.Windows.Forms.Panel()
        Me.pnlCenter = New System.Windows.Forms.Panel()
        Me.pnlButtonsPicO = New System.Windows.Forms.Panel()
        Me.pnlButtonsPic = New System.Windows.Forms.Panel()
        Me.pnlButtonsInv = New System.Windows.Forms.Panel()
        Me.btnPicsOPanel = New FontAwesome.Sharp.IconButton()
        Me.btnPicsPanel = New FontAwesome.Sharp.IconButton()
        Me.btnPicsO = New FontAwesome.Sharp.IconButton()
        Me.btnUpPicO = New FontAwesome.Sharp.IconButton()
        Me.btnDownPicO = New FontAwesome.Sharp.IconButton()
        Me.btnDeletePicO = New FontAwesome.Sharp.IconButton()
        Me.btnRotateLO = New FontAwesome.Sharp.IconButton()
        Me.btnRotateRO = New FontAwesome.Sharp.IconButton()
        Me.btnPics = New FontAwesome.Sharp.IconButton()
        Me.btnUpPic = New FontAwesome.Sharp.IconButton()
        Me.btnDownPic = New FontAwesome.Sharp.IconButton()
        Me.btnRotateL = New FontAwesome.Sharp.IconButton()
        Me.btnRotateR = New FontAwesome.Sharp.IconButton()
        Me.btnDeletePic = New FontAwesome.Sharp.IconButton()
        Me.btnSeizure = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.btnRenumber = New FontAwesome.Sharp.IconButton()
        Me.btnAddRuimte = New FontAwesome.Sharp.IconButton()
        Me.btnUp = New FontAwesome.Sharp.IconButton()
        Me.btnAdd = New FontAwesome.Sharp.IconButton()
        Me.btnImport = New FontAwesome.Sharp.IconButton()
        Me.btnDown = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.btnMin = New FontAwesome.Sharp.IconButton()
        Me.btnPicturesGen = New FontAwesome.Sharp.IconButton()
        Me.btnInventoryGen = New FontAwesome.Sharp.IconButton()
        Me.btnPicsLow = New FontAwesome.Sharp.IconButton()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.imgCRU = New System.Windows.Forms.PictureBox()
        CType(Me.dgvPicsO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEIZUREBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        CType(Me.dgvPics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInput.SuspendLayout()
        Me.pnlInv.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPics.SuspendLayout()
        Me.pnlPicsO.SuspendLayout()
        Me.pnlCenter.SuspendLayout()
        Me.pnlButtonsPicO.SuspendLayout()
        Me.pnlButtonsPic.SuspendLayout()
        Me.pnlButtonsInv.SuspendLayout()
        CType(Me.imgCRU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNum
        '
        Me.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(8, 8)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(116, 32)
        Me.txtNum.TabIndex = 0
        '
        'txtSamples
        '
        Me.txtSamples.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSamples.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSamples.Location = New System.Drawing.Point(8, 39)
        Me.txtSamples.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSamples.Name = "txtSamples"
        Me.txtSamples.Size = New System.Drawing.Size(52, 32)
        Me.txtSamples.TabIndex = 0
        Me.txtSamples.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbSamplesT
        '
        Me.cmbSamplesT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSamplesT.FormattingEnabled = True
        Me.cmbSamplesT.Location = New System.Drawing.Point(64, 39)
        Me.cmbSamplesT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSamplesT.Name = "cmbSamplesT"
        Me.cmbSamplesT.Size = New System.Drawing.Size(60, 32)
        Me.cmbSamplesT.TabIndex = 1
        '
        'txtDesc
        '
        Me.txtDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(128, 8)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDesc.Size = New System.Drawing.Size(1000, 58)
        Me.txtDesc.TabIndex = 0
        '
        'dgvPicsO
        '
        Me.dgvPicsO.AllowDrop = True
        Me.dgvPicsO.AllowUserToAddRows = False
        Me.dgvPicsO.AllowUserToDeleteRows = False
        Me.dgvPicsO.AllowUserToResizeColumns = False
        Me.dgvPicsO.AllowUserToResizeRows = False
        Me.dgvPicsO.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPicsO.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPicsO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPicsO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvPicsO.ColumnHeadersHeight = 29
        Me.dgvPicsO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPicsO.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPicsO.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPicsO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPicsO.Location = New System.Drawing.Point(0, 0)
        Me.dgvPicsO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvPicsO.MultiSelect = False
        Me.dgvPicsO.Name = "dgvPicsO"
        Me.dgvPicsO.ReadOnly = True
        Me.dgvPicsO.RowHeadersVisible = False
        Me.dgvPicsO.RowHeadersWidth = 51
        Me.dgvPicsO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPicsO.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvPicsO.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.dgvPicsO.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPicsO.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvPicsO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPicsO.Size = New System.Drawing.Size(150, 704)
        Me.dgvPicsO.TabIndex = 0
        '
        'txtNumR
        '
        Me.txtNumR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumR.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumR.Location = New System.Drawing.Point(8, 8)
        Me.txtNumR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumR.Name = "txtNumR"
        Me.txtNumR.Size = New System.Drawing.Size(116, 32)
        Me.txtNumR.TabIndex = 0
        '
        'txtDescR
        '
        Me.txtDescR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescR.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescR.Location = New System.Drawing.Point(128, 8)
        Me.txtDescR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescR.Multiline = True
        Me.txtDescR.Name = "txtDescR"
        Me.txtDescR.Size = New System.Drawing.Size(1000, 58)
        Me.txtDescR.TabIndex = 0
        '
        'DORADbDS
        '
        Me.DORADbDS.DataSetName = "DORADbDS"
        Me.DORADbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SEIZUREBindingSource
        '
        Me.SEIZUREBindingSource.DataMember = "SEIZURE"
        Me.SEIZUREBindingSource.DataSource = Me.DORADbDS
        '
        'SEIZURETableAdapter
        '
        Me.SEIZURETableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PRODUCTSTableAdapter = Nothing
        Me.TableAdapterManager.SEIZURETableAdapter = Me.SEIZURETableAdapter
        Me.TableAdapterManager.UpdateOrder = DORA.DORADbDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Timer1
        '
        Me.Timer1.Interval = 30000
        '
        'bgw
        '
        Me.bgw.WorkerReportsProgress = True
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.btnPicturesGen)
        Me.pnlMenu.Controls.Add(Me.btnInventoryGen)
        Me.pnlMenu.Controls.Add(Me.btnPicsLow)
        Me.pnlMenu.Controls.Add(Me.btnSave)
        Me.pnlMenu.Controls.Add(Me.btnExit)
        Me.pnlMenu.Controls.Add(Me.pnlLogo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(131, 953)
        Me.pnlMenu.TabIndex = 178
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.imgCRU)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(131, 130)
        Me.pnlLogo.TabIndex = 1
        '
        'pnlTitle
        '
        Me.pnlTitle.Controls.Add(Me.pnlControls)
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(131, 0)
        Me.pnlTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(1451, 130)
        Me.pnlTitle.TabIndex = 179
        '
        'pnlControls
        '
        Me.pnlControls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControls.Controls.Add(Me.btnClose)
        Me.pnlControls.Controls.Add(Me.btnMin)
        Me.pnlControls.Location = New System.Drawing.Point(1379, 0)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(69, 39)
        Me.pnlControls.TabIndex = 136
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(72, 64)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(109, 37)
        Me.lblTitle.TabIndex = 34
        Me.lblTitle.Tag = ""
        Me.lblTitle.Text = "Dossier"
        '
        'dgvPics
        '
        Me.dgvPics.AllowDrop = True
        Me.dgvPics.AllowUserToAddRows = False
        Me.dgvPics.AllowUserToDeleteRows = False
        Me.dgvPics.AllowUserToResizeColumns = False
        Me.dgvPics.AllowUserToResizeRows = False
        Me.dgvPics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPics.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPics.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPics.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPics.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPics.ColumnHeadersHeight = 29
        Me.dgvPics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPics.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPics.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPics.Location = New System.Drawing.Point(0, 0)
        Me.dgvPics.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvPics.MultiSelect = False
        Me.dgvPics.Name = "dgvPics"
        Me.dgvPics.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPics.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPics.RowHeadersVisible = False
        Me.dgvPics.RowHeadersWidth = 51
        Me.dgvPics.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPics.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvPics.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.dgvPics.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPics.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvPics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPics.Size = New System.Drawing.Size(150, 704)
        Me.dgvPics.TabIndex = 0
        '
        'pnlInput
        '
        Me.pnlInput.Controls.Add(Me.txtDesc)
        Me.pnlInput.Controls.Add(Me.cmbSamplesT)
        Me.pnlInput.Controls.Add(Me.txtNum)
        Me.pnlInput.Controls.Add(Me.txtNumR)
        Me.pnlInput.Controls.Add(Me.txtDescR)
        Me.pnlInput.Controls.Add(Me.txtSamples)
        Me.pnlInput.Location = New System.Drawing.Point(16, 16)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(1136, 74)
        Me.pnlInput.TabIndex = 181
        '
        'pnlInv
        '
        Me.pnlInv.Controls.Add(Me.dgvInventory)
        Me.pnlInv.Location = New System.Drawing.Point(16, 104)
        Me.pnlInv.Name = "pnlInv"
        Me.pnlInv.Size = New System.Drawing.Size(1136, 704)
        Me.pnlInv.TabIndex = 184
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.AllowUserToResizeRows = False
        Me.dgvInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.ColumnHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventory.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvInventory.Location = New System.Drawing.Point(8, 8)
        Me.dgvInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventory.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvInventory.RowHeadersVisible = False
        Me.dgvInventory.RowHeadersWidth = 51
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventory.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvInventory.RowTemplate.Height = 30
        Me.dgvInventory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventory.Size = New System.Drawing.Size(1115, 688)
        Me.dgvInventory.TabIndex = 184
        '
        'pnlPics
        '
        Me.pnlPics.Controls.Add(Me.dgvPics)
        Me.pnlPics.Location = New System.Drawing.Point(1224, 104)
        Me.pnlPics.Name = "pnlPics"
        Me.pnlPics.Size = New System.Drawing.Size(150, 704)
        Me.pnlPics.TabIndex = 185
        '
        'pnlPicsO
        '
        Me.pnlPicsO.Controls.Add(Me.dgvPicsO)
        Me.pnlPicsO.Location = New System.Drawing.Point(1224, 104)
        Me.pnlPicsO.Name = "pnlPicsO"
        Me.pnlPicsO.Size = New System.Drawing.Size(150, 704)
        Me.pnlPicsO.TabIndex = 185
        '
        'pnlCenter
        '
        Me.pnlCenter.Controls.Add(Me.btnPicsOPanel)
        Me.pnlCenter.Controls.Add(Me.btnPicsPanel)
        Me.pnlCenter.Controls.Add(Me.pnlButtonsPicO)
        Me.pnlCenter.Controls.Add(Me.pnlPicsO)
        Me.pnlCenter.Controls.Add(Me.pnlButtonsPic)
        Me.pnlCenter.Controls.Add(Me.pnlButtonsInv)
        Me.pnlCenter.Controls.Add(Me.pnlInput)
        Me.pnlCenter.Controls.Add(Me.pnlInv)
        Me.pnlCenter.Controls.Add(Me.pnlPics)
        Me.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCenter.Location = New System.Drawing.Point(131, 130)
        Me.pnlCenter.Name = "pnlCenter"
        Me.pnlCenter.Size = New System.Drawing.Size(1451, 823)
        Me.pnlCenter.TabIndex = 186
        '
        'pnlButtonsPicO
        '
        Me.pnlButtonsPicO.Controls.Add(Me.btnPicsO)
        Me.pnlButtonsPicO.Controls.Add(Me.btnUpPicO)
        Me.pnlButtonsPicO.Controls.Add(Me.btnDownPicO)
        Me.pnlButtonsPicO.Controls.Add(Me.btnDeletePicO)
        Me.pnlButtonsPicO.Controls.Add(Me.btnRotateLO)
        Me.pnlButtonsPicO.Controls.Add(Me.btnRotateRO)
        Me.pnlButtonsPicO.Location = New System.Drawing.Point(1384, 104)
        Me.pnlButtonsPicO.Name = "pnlButtonsPicO"
        Me.pnlButtonsPicO.Size = New System.Drawing.Size(50, 220)
        Me.pnlButtonsPicO.TabIndex = 203
        '
        'pnlButtonsPic
        '
        Me.pnlButtonsPic.Controls.Add(Me.btnPics)
        Me.pnlButtonsPic.Controls.Add(Me.btnUpPic)
        Me.pnlButtonsPic.Controls.Add(Me.btnDownPic)
        Me.pnlButtonsPic.Controls.Add(Me.btnRotateL)
        Me.pnlButtonsPic.Controls.Add(Me.btnRotateR)
        Me.pnlButtonsPic.Controls.Add(Me.btnDeletePic)
        Me.pnlButtonsPic.Location = New System.Drawing.Point(1384, 104)
        Me.pnlButtonsPic.Name = "pnlButtonsPic"
        Me.pnlButtonsPic.Size = New System.Drawing.Size(50, 220)
        Me.pnlButtonsPic.TabIndex = 202
        '
        'pnlButtonsInv
        '
        Me.pnlButtonsInv.Controls.Add(Me.btnSeizure)
        Me.pnlButtonsInv.Controls.Add(Me.btnDelete)
        Me.pnlButtonsInv.Controls.Add(Me.btnRenumber)
        Me.pnlButtonsInv.Controls.Add(Me.btnAddRuimte)
        Me.pnlButtonsInv.Controls.Add(Me.btnUp)
        Me.pnlButtonsInv.Controls.Add(Me.btnAdd)
        Me.pnlButtonsInv.Controls.Add(Me.btnImport)
        Me.pnlButtonsInv.Controls.Add(Me.btnDown)
        Me.pnlButtonsInv.Location = New System.Drawing.Point(1160, 104)
        Me.pnlButtonsInv.Name = "pnlButtonsInv"
        Me.pnlButtonsInv.Size = New System.Drawing.Size(50, 288)
        Me.pnlButtonsInv.TabIndex = 201
        '
        'btnPicsOPanel
        '
        Me.btnPicsOPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPicsOPanel.FlatAppearance.BorderSize = 0
        Me.btnPicsOPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPicsOPanel.IconChar = FontAwesome.Sharp.IconChar.Images
        Me.btnPicsOPanel.IconColor = System.Drawing.Color.Black
        Me.btnPicsOPanel.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnPicsOPanel.IconSize = 40
        Me.btnPicsOPanel.Location = New System.Drawing.Point(1304, 48)
        Me.btnPicsOPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPicsOPanel.Name = "btnPicsOPanel"
        Me.btnPicsOPanel.Size = New System.Drawing.Size(40, 40)
        Me.btnPicsOPanel.TabIndex = 204
        Me.btnPicsOPanel.UseVisualStyleBackColor = True
        '
        'btnPicsPanel
        '
        Me.btnPicsPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPicsPanel.FlatAppearance.BorderSize = 0
        Me.btnPicsPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPicsPanel.IconChar = FontAwesome.Sharp.IconChar.Image
        Me.btnPicsPanel.IconColor = System.Drawing.Color.Black
        Me.btnPicsPanel.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnPicsPanel.IconSize = 40
        Me.btnPicsPanel.Location = New System.Drawing.Point(1256, 48)
        Me.btnPicsPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPicsPanel.Name = "btnPicsPanel"
        Me.btnPicsPanel.Size = New System.Drawing.Size(40, 40)
        Me.btnPicsPanel.TabIndex = 192
        Me.btnPicsPanel.UseVisualStyleBackColor = True
        '
        'btnPicsO
        '
        Me.btnPicsO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPicsO.FlatAppearance.BorderSize = 0
        Me.btnPicsO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPicsO.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnPicsO.IconColor = System.Drawing.Color.Black
        Me.btnPicsO.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPicsO.IconSize = 30
        Me.btnPicsO.Location = New System.Drawing.Point(10, 10)
        Me.btnPicsO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPicsO.Name = "btnPicsO"
        Me.btnPicsO.Size = New System.Drawing.Size(30, 30)
        Me.btnPicsO.TabIndex = 195
        Me.btnPicsO.UseVisualStyleBackColor = True
        '
        'btnUpPicO
        '
        Me.btnUpPicO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpPicO.FlatAppearance.BorderSize = 0
        Me.btnUpPicO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpPicO.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp
        Me.btnUpPicO.IconColor = System.Drawing.Color.Black
        Me.btnUpPicO.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnUpPicO.IconSize = 30
        Me.btnUpPicO.Location = New System.Drawing.Point(10, 44)
        Me.btnUpPicO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpPicO.Name = "btnUpPicO"
        Me.btnUpPicO.Size = New System.Drawing.Size(30, 30)
        Me.btnUpPicO.TabIndex = 197
        Me.btnUpPicO.UseVisualStyleBackColor = True
        '
        'btnDownPicO
        '
        Me.btnDownPicO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownPicO.FlatAppearance.BorderSize = 0
        Me.btnDownPicO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownPicO.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown
        Me.btnDownPicO.IconColor = System.Drawing.Color.Black
        Me.btnDownPicO.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnDownPicO.IconSize = 30
        Me.btnDownPicO.Location = New System.Drawing.Point(10, 78)
        Me.btnDownPicO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDownPicO.Name = "btnDownPicO"
        Me.btnDownPicO.Size = New System.Drawing.Size(30, 30)
        Me.btnDownPicO.TabIndex = 196
        Me.btnDownPicO.UseVisualStyleBackColor = True
        '
        'btnDeletePicO
        '
        Me.btnDeletePicO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeletePicO.FlatAppearance.BorderSize = 0
        Me.btnDeletePicO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePicO.IconChar = FontAwesome.Sharp.IconChar.MinusCircle
        Me.btnDeletePicO.IconColor = System.Drawing.Color.Black
        Me.btnDeletePicO.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnDeletePicO.IconSize = 30
        Me.btnDeletePicO.Location = New System.Drawing.Point(10, 180)
        Me.btnDeletePicO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeletePicO.Name = "btnDeletePicO"
        Me.btnDeletePicO.Size = New System.Drawing.Size(30, 30)
        Me.btnDeletePicO.TabIndex = 200
        Me.btnDeletePicO.UseVisualStyleBackColor = True
        '
        'btnRotateLO
        '
        Me.btnRotateLO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRotateLO.FlatAppearance.BorderSize = 0
        Me.btnRotateLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotateLO.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        Me.btnRotateLO.IconColor = System.Drawing.Color.Black
        Me.btnRotateLO.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnRotateLO.IconSize = 30
        Me.btnRotateLO.Location = New System.Drawing.Point(10, 112)
        Me.btnRotateLO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRotateLO.Name = "btnRotateLO"
        Me.btnRotateLO.Size = New System.Drawing.Size(30, 30)
        Me.btnRotateLO.TabIndex = 198
        Me.btnRotateLO.UseVisualStyleBackColor = True
        '
        'btnRotateRO
        '
        Me.btnRotateRO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRotateRO.FlatAppearance.BorderSize = 0
        Me.btnRotateRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotateRO.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.btnRotateRO.IconColor = System.Drawing.Color.Black
        Me.btnRotateRO.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnRotateRO.IconSize = 30
        Me.btnRotateRO.Location = New System.Drawing.Point(10, 146)
        Me.btnRotateRO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRotateRO.Name = "btnRotateRO"
        Me.btnRotateRO.Size = New System.Drawing.Size(30, 30)
        Me.btnRotateRO.TabIndex = 199
        Me.btnRotateRO.UseVisualStyleBackColor = True
        '
        'btnPics
        '
        Me.btnPics.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPics.FlatAppearance.BorderSize = 0
        Me.btnPics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPics.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnPics.IconColor = System.Drawing.Color.Black
        Me.btnPics.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPics.IconSize = 30
        Me.btnPics.Location = New System.Drawing.Point(10, 10)
        Me.btnPics.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPics.Name = "btnPics"
        Me.btnPics.Size = New System.Drawing.Size(30, 30)
        Me.btnPics.TabIndex = 189
        Me.btnPics.UseVisualStyleBackColor = True
        '
        'btnUpPic
        '
        Me.btnUpPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpPic.FlatAppearance.BorderSize = 0
        Me.btnUpPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpPic.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp
        Me.btnUpPic.IconColor = System.Drawing.Color.Black
        Me.btnUpPic.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnUpPic.IconSize = 30
        Me.btnUpPic.Location = New System.Drawing.Point(10, 44)
        Me.btnUpPic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpPic.Name = "btnUpPic"
        Me.btnUpPic.Size = New System.Drawing.Size(30, 30)
        Me.btnUpPic.TabIndex = 191
        Me.btnUpPic.UseVisualStyleBackColor = True
        '
        'btnDownPic
        '
        Me.btnDownPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownPic.FlatAppearance.BorderSize = 0
        Me.btnDownPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownPic.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown
        Me.btnDownPic.IconColor = System.Drawing.Color.Black
        Me.btnDownPic.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnDownPic.IconSize = 30
        Me.btnDownPic.Location = New System.Drawing.Point(10, 78)
        Me.btnDownPic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDownPic.Name = "btnDownPic"
        Me.btnDownPic.Size = New System.Drawing.Size(30, 30)
        Me.btnDownPic.TabIndex = 190
        Me.btnDownPic.UseVisualStyleBackColor = True
        '
        'btnRotateL
        '
        Me.btnRotateL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRotateL.FlatAppearance.BorderSize = 0
        Me.btnRotateL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotateL.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        Me.btnRotateL.IconColor = System.Drawing.Color.Black
        Me.btnRotateL.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnRotateL.IconSize = 30
        Me.btnRotateL.Location = New System.Drawing.Point(10, 112)
        Me.btnRotateL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRotateL.Name = "btnRotateL"
        Me.btnRotateL.Size = New System.Drawing.Size(30, 30)
        Me.btnRotateL.TabIndex = 192
        Me.btnRotateL.UseVisualStyleBackColor = True
        '
        'btnRotateR
        '
        Me.btnRotateR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRotateR.FlatAppearance.BorderSize = 0
        Me.btnRotateR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotateR.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.btnRotateR.IconColor = System.Drawing.Color.Black
        Me.btnRotateR.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnRotateR.IconSize = 30
        Me.btnRotateR.Location = New System.Drawing.Point(10, 146)
        Me.btnRotateR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRotateR.Name = "btnRotateR"
        Me.btnRotateR.Size = New System.Drawing.Size(30, 30)
        Me.btnRotateR.TabIndex = 193
        Me.btnRotateR.UseVisualStyleBackColor = True
        '
        'btnDeletePic
        '
        Me.btnDeletePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeletePic.FlatAppearance.BorderSize = 0
        Me.btnDeletePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePic.IconChar = FontAwesome.Sharp.IconChar.MinusCircle
        Me.btnDeletePic.IconColor = System.Drawing.Color.Black
        Me.btnDeletePic.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnDeletePic.IconSize = 30
        Me.btnDeletePic.Location = New System.Drawing.Point(10, 180)
        Me.btnDeletePic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeletePic.Name = "btnDeletePic"
        Me.btnDeletePic.Size = New System.Drawing.Size(30, 30)
        Me.btnDeletePic.TabIndex = 194
        Me.btnDeletePic.UseVisualStyleBackColor = True
        '
        'btnSeizure
        '
        Me.btnSeizure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeizure.FlatAppearance.BorderSize = 0
        Me.btnSeizure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeizure.IconChar = FontAwesome.Sharp.IconChar.HandLizard
        Me.btnSeizure.IconColor = System.Drawing.Color.Black
        Me.btnSeizure.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnSeizure.IconSize = 30
        Me.btnSeizure.Location = New System.Drawing.Point(10, 214)
        Me.btnSeizure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSeizure.Name = "btnSeizure"
        Me.btnSeizure.Size = New System.Drawing.Size(30, 30)
        Me.btnSeizure.TabIndex = 191
        Me.btnSeizure.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.MinusCircle
        Me.btnDelete.IconColor = System.Drawing.Color.Black
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnDelete.IconSize = 30
        Me.btnDelete.Location = New System.Drawing.Point(10, 146)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(30, 30)
        Me.btnDelete.TabIndex = 190
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRenumber
        '
        Me.btnRenumber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRenumber.FlatAppearance.BorderSize = 0
        Me.btnRenumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRenumber.IconChar = FontAwesome.Sharp.IconChar.SortNumericDown
        Me.btnRenumber.IconColor = System.Drawing.Color.Black
        Me.btnRenumber.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnRenumber.IconSize = 30
        Me.btnRenumber.Location = New System.Drawing.Point(10, 180)
        Me.btnRenumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRenumber.Name = "btnRenumber"
        Me.btnRenumber.Size = New System.Drawing.Size(30, 30)
        Me.btnRenumber.TabIndex = 189
        Me.btnRenumber.UseVisualStyleBackColor = True
        '
        'btnAddRuimte
        '
        Me.btnAddRuimte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddRuimte.FlatAppearance.BorderSize = 0
        Me.btnAddRuimte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRuimte.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.btnAddRuimte.IconColor = System.Drawing.Color.Black
        Me.btnAddRuimte.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnAddRuimte.IconSize = 30
        Me.btnAddRuimte.Location = New System.Drawing.Point(10, 10)
        Me.btnAddRuimte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddRuimte.Name = "btnAddRuimte"
        Me.btnAddRuimte.Size = New System.Drawing.Size(30, 30)
        Me.btnAddRuimte.TabIndex = 183
        Me.btnAddRuimte.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUp.FlatAppearance.BorderSize = 0
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp
        Me.btnUp.IconColor = System.Drawing.Color.Black
        Me.btnUp.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnUp.IconSize = 30
        Me.btnUp.Location = New System.Drawing.Point(10, 78)
        Me.btnUp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(30, 30)
        Me.btnUp.TabIndex = 187
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAdd.IconColor = System.Drawing.Color.Black
        Me.btnAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAdd.IconSize = 30
        Me.btnAdd.Location = New System.Drawing.Point(10, 44)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 30)
        Me.btnAdd.TabIndex = 185
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImport.FlatAppearance.BorderSize = 0
        Me.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport.IconChar = FontAwesome.Sharp.IconChar.FileUpload
        Me.btnImport.IconColor = System.Drawing.Color.Black
        Me.btnImport.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnImport.IconSize = 30
        Me.btnImport.Location = New System.Drawing.Point(10, 248)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(30, 30)
        Me.btnImport.TabIndex = 188
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDown.FlatAppearance.BorderSize = 0
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown
        Me.btnDown.IconColor = System.Drawing.Color.Black
        Me.btnDown.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnDown.IconSize = 30
        Me.btnDown.Location = New System.Drawing.Point(10, 112)
        Me.btnDown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(30, 30)
        Me.btnDown.TabIndex = 186
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnClose.IconColor = System.Drawing.Color.Black
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.IconSize = 20
        Me.btnClose.Location = New System.Drawing.Point(40, 10)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 120
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMin.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.btnMin.IconColor = System.Drawing.Color.Black
        Me.btnMin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMin.IconSize = 20
        Me.btnMin.Location = New System.Drawing.Point(8, 10)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.btnMin.Size = New System.Drawing.Size(25, 25)
        Me.btnMin.TabIndex = 12
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnPicturesGen
        '
        Me.btnPicturesGen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPicturesGen.FlatAppearance.BorderSize = 0
        Me.btnPicturesGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPicturesGen.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPicturesGen.IconChar = FontAwesome.Sharp.IconChar.FileImage
        Me.btnPicturesGen.IconColor = System.Drawing.Color.Black
        Me.btnPicturesGen.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnPicturesGen.IconSize = 30
        Me.btnPicturesGen.Location = New System.Drawing.Point(0, 376)
        Me.btnPicturesGen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPicturesGen.Name = "btnPicturesGen"
        Me.btnPicturesGen.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.btnPicturesGen.Size = New System.Drawing.Size(131, 60)
        Me.btnPicturesGen.TabIndex = 18
        Me.btnPicturesGen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPicturesGen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPicturesGen.UseVisualStyleBackColor = False
        '
        'btnInventoryGen
        '
        Me.btnInventoryGen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventoryGen.FlatAppearance.BorderSize = 0
        Me.btnInventoryGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventoryGen.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventoryGen.IconChar = FontAwesome.Sharp.IconChar.FileWord
        Me.btnInventoryGen.IconColor = System.Drawing.Color.Black
        Me.btnInventoryGen.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnInventoryGen.IconSize = 30
        Me.btnInventoryGen.Location = New System.Drawing.Point(0, 312)
        Me.btnInventoryGen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInventoryGen.Name = "btnInventoryGen"
        Me.btnInventoryGen.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.btnInventoryGen.Size = New System.Drawing.Size(131, 60)
        Me.btnInventoryGen.TabIndex = 17
        Me.btnInventoryGen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventoryGen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventoryGen.UseVisualStyleBackColor = False
        '
        'btnPicsLow
        '
        Me.btnPicsLow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPicsLow.FlatAppearance.BorderSize = 0
        Me.btnPicsLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPicsLow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPicsLow.IconChar = FontAwesome.Sharp.IconChar.Image
        Me.btnPicsLow.IconColor = System.Drawing.Color.Black
        Me.btnPicsLow.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnPicsLow.IconSize = 30
        Me.btnPicsLow.Location = New System.Drawing.Point(0, 250)
        Me.btnPicsLow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPicsLow.Name = "btnPicsLow"
        Me.btnPicsLow.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.btnPicsLow.Size = New System.Drawing.Size(131, 60)
        Me.btnPicsLow.TabIndex = 15
        Me.btnPicsLow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPicsLow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPicsLow.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSave.IconColor = System.Drawing.Color.Black
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnSave.IconSize = 30
        Me.btnSave.Location = New System.Drawing.Point(0, 190)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.btnSave.Size = New System.Drawing.Size(131, 60)
        Me.btnSave.TabIndex = 14
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnExit.IconColor = System.Drawing.Color.Black
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 30
        Me.btnExit.Location = New System.Drawing.Point(0, 893)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.btnExit.Size = New System.Drawing.Size(131, 60)
        Me.btnExit.TabIndex = 13
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'imgCRU
        '
        Me.imgCRU.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgCRU.BackgroundImage = Global.DORA.My.Resources.Resources.CRULogo
        Me.imgCRU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgCRU.Location = New System.Drawing.Point(11, 10)
        Me.imgCRU.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.imgCRU.Name = "imgCRU"
        Me.imgCRU.Padding = New System.Windows.Forms.Padding(5)
        Me.imgCRU.Size = New System.Drawing.Size(109, 110)
        Me.imgCRU.TabIndex = 0
        Me.imgCRU.TabStop = False
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1582, 953)
        Me.Controls.Add(Me.pnlCenter)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.pnlMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvPicsO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEIZUREBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.pnlControls.ResumeLayout(False)
        CType(Me.dgvPics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.pnlInv.ResumeLayout(False)
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPics.ResumeLayout(False)
        Me.pnlPicsO.ResumeLayout(False)
        Me.pnlCenter.ResumeLayout(False)
        Me.pnlButtonsPicO.ResumeLayout(False)
        Me.pnlButtonsPic.ResumeLayout(False)
        Me.pnlButtonsInv.ResumeLayout(False)
        CType(Me.imgCRU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtSamples As TextBox
    Friend WithEvents cmbSamplesT As ComboBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents dgvPicsO As DataGridView
    Friend WithEvents txtNumR As TextBox
    Friend WithEvents txtDescR As TextBox
    Friend WithEvents DORADbDS As DORADbDS
    Friend WithEvents SEIZUREBindingSource As BindingSource
    Friend WithEvents SEIZURETableAdapter As DORADbDSTableAdapters.SEIZURETableAdapter
    Friend WithEvents TableAdapterManager As DORADbDSTableAdapters.TableAdapterManager
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bgw As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents imgCRU As PictureBox
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents pnlControls As Panel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMin As FontAwesome.Sharp.IconButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPicturesGen As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInventoryGen As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPicsLow As FontAwesome.Sharp.IconButton
    Friend WithEvents dgvPics As DataGridView
    Friend WithEvents pnlInput As Panel
    Friend WithEvents btnAddRuimte As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlInv As Panel
    Friend WithEvents pnlPics As Panel
    Friend WithEvents pnlPicsO As Panel
    Friend WithEvents pnlCenter As Panel
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents btnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents btnImport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDown As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUp As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeletePicO As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRotateRO As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRotateLO As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDownPicO As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPicsO As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpPicO As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeletePic As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRotateR As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRotateL As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDownPic As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPics As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpPic As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlButtonsInv As Panel
    Friend WithEvents pnlButtonsPicO As Panel
    Friend WithEvents pnlButtonsPic As Panel
    Friend WithEvents btnSeizure As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRenumber As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPicsOPanel As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPicsPanel As FontAwesome.Sharp.IconButton
End Class
