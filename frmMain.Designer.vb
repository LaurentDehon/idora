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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RCMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnLanguage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLanguageN = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLanguageF = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnThemeDark = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnThemeAbyss = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnThemeKimbie = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnThemeNoctis = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnThemeDracula = New System.Windows.Forms.ToolStripMenuItem()
        Me.DORADbDS = New DORA.DORADbDS()
        Me.BACKUPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BACKUPTableAdapter = New DORA.DORADbDSTableAdapters.BACKUPTableAdapter()
        Me.TableAdapterManager = New DORA.DORADbDSTableAdapters.TableAdapterManager()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.btnProducts = New FontAwesome.Sharp.IconButton()
        Me.btnMembers = New FontAwesome.Sharp.IconButton()
        Me.btnStats = New FontAwesome.Sharp.IconButton()
        Me.btnSearch = New FontAwesome.Sharp.IconButton()
        Me.btnCases = New FontAwesome.Sharp.IconButton()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.lblDoraCopyrights = New System.Windows.Forms.Label()
        Me.imgCRU = New System.Windows.Forms.PictureBox()
        Me.lblDoraVersion = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.btnMin = New FontAwesome.Sharp.IconButton()
        Me.btnMax = New FontAwesome.Sharp.IconButton()
        Me.pnlCenter = New System.Windows.Forms.Panel()
        Me.picHoliday = New DORA.TransparentPictureBox()
        Me.picBirthday = New DORA.TransparentPictureBox()
        Me.picDORA = New System.Windows.Forms.PictureBox()
        Me.CITIESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CITIESTableAdapter1 = New DORA.DORADbDSTableAdapters.CITIESTableAdapter()
        Me.CITIESBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CITIESTableAdapter2 = New DORA.DORADbDSTableAdapters.CITIESTableAdapter()
        Me.RCMenuCases = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnOpenOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.RCMenu.SuspendLayout()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BACKUPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        CType(Me.imgCRU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.pnlCenter.SuspendLayout()
        CType(Me.picHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBirthday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDORA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITIESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITIESBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RCMenuCases.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClockTimer
        '
        Me.ClockTimer.Interval = 1000
        '
        'RCMenu
        '
        Me.RCMenu.BackColor = System.Drawing.SystemColors.Control
        Me.RCMenu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RCMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnLanguage, Me.mnTheme})
        Me.RCMenu.Name = "RCMenu"
        Me.RCMenu.Size = New System.Drawing.Size(163, 60)
        '
        'mnLanguage
        '
        Me.mnLanguage.BackgroundImage = Global.DORA.My.Resources.Resources.globe
        Me.mnLanguage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnLanguageN, Me.mnLanguageF})
        Me.mnLanguage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mnLanguage.Image = Global.DORA.My.Resources.Resources.globe
        Me.mnLanguage.Name = "mnLanguage"
        Me.mnLanguage.Size = New System.Drawing.Size(162, 28)
        Me.mnLanguage.Text = "Language"
        '
        'mnLanguageN
        '
        Me.mnLanguageN.BackColor = System.Drawing.SystemColors.Control
        Me.mnLanguageN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mnLanguageN.Image = Global.DORA.My.Resources.Resources.n
        Me.mnLanguageN.Name = "mnLanguageN"
        Me.mnLanguageN.Size = New System.Drawing.Size(190, 28)
        Me.mnLanguageN.Text = "Nederlands"
        '
        'mnLanguageF
        '
        Me.mnLanguageF.BackColor = System.Drawing.SystemColors.Control
        Me.mnLanguageF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mnLanguageF.Image = Global.DORA.My.Resources.Resources.f
        Me.mnLanguageF.Name = "mnLanguageF"
        Me.mnLanguageF.Size = New System.Drawing.Size(190, 28)
        Me.mnLanguageF.Text = "Français"
        '
        'mnTheme
        '
        Me.mnTheme.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnThemeDark, Me.mnThemeAbyss, Me.mnThemeKimbie, Me.mnThemeNoctis, Me.mnThemeDracula})
        Me.mnTheme.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mnTheme.Image = Global.DORA.My.Resources.Resources.palette
        Me.mnTheme.Name = "mnTheme"
        Me.mnTheme.Size = New System.Drawing.Size(162, 28)
        Me.mnTheme.Text = "Theme"
        '
        'mnThemeDark
        '
        Me.mnThemeDark.Name = "mnThemeDark"
        Me.mnThemeDark.Size = New System.Drawing.Size(158, 28)
        Me.mnThemeDark.Text = "Dark"
        '
        'mnThemeAbyss
        '
        Me.mnThemeAbyss.Name = "mnThemeAbyss"
        Me.mnThemeAbyss.Size = New System.Drawing.Size(158, 28)
        Me.mnThemeAbyss.Text = "Abyss"
        '
        'mnThemeKimbie
        '
        Me.mnThemeKimbie.Name = "mnThemeKimbie"
        Me.mnThemeKimbie.Size = New System.Drawing.Size(158, 28)
        Me.mnThemeKimbie.Text = "Kimbie"
        '
        'mnThemeNoctis
        '
        Me.mnThemeNoctis.Name = "mnThemeNoctis"
        Me.mnThemeNoctis.Size = New System.Drawing.Size(158, 28)
        Me.mnThemeNoctis.Text = "Noctis"
        '
        'mnThemeDracula
        '
        Me.mnThemeDracula.Name = "mnThemeDracula"
        Me.mnThemeDracula.Size = New System.Drawing.Size(158, 28)
        Me.mnThemeDracula.Text = "Dracula"
        '
        'DORADbDS
        '
        Me.DORADbDS.DataSetName = "DORADbDS"
        Me.DORADbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BACKUPBindingSource
        '
        Me.BACKUPBindingSource.DataMember = "BACKUP"
        Me.BACKUPBindingSource.DataSource = Me.DORADbDS
        '
        'BACKUPTableAdapter
        '
        Me.BACKUPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BACKUPTableAdapter = Me.BACKUPTableAdapter
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
        Me.TableAdapterManager.SEIZURETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DORA.DORADbDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 10000
        Me.ToolTip.InitialDelay = 500
        Me.ToolTip.IsBalloon = True
        Me.ToolTip.ReshowDelay = 100
        Me.ToolTip.ShowAlways = True
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.btnExit)
        Me.pnlMenu.Controls.Add(Me.btnProducts)
        Me.pnlMenu.Controls.Add(Me.btnMembers)
        Me.pnlMenu.Controls.Add(Me.btnStats)
        Me.pnlMenu.Controls.Add(Me.btnSearch)
        Me.pnlMenu.Controls.Add(Me.btnCases)
        Me.pnlMenu.Controls.Add(Me.pnlLogo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(240, 853)
        Me.pnlMenu.TabIndex = 133
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnExit.IconColor = System.Drawing.Color.Black
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 30
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 793)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnExit.Size = New System.Drawing.Size(240, 60)
        Me.btnExit.TabIndex = 12
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnProducts
        '
        Me.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Vial
        Me.btnProducts.IconColor = System.Drawing.Color.Black
        Me.btnProducts.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProducts.IconSize = 30
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.Location = New System.Drawing.Point(0, 460)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnProducts.Size = New System.Drawing.Size(240, 60)
        Me.btnProducts.TabIndex = 10
        Me.btnProducts.TabStop = False
        Me.btnProducts.Text = "Products"
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProducts.UseVisualStyleBackColor = False
        '
        'btnMembers
        '
        Me.btnMembers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMembers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMembers.FlatAppearance.BorderSize = 0
        Me.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMembers.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembers.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.btnMembers.IconColor = System.Drawing.Color.Black
        Me.btnMembers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMembers.IconSize = 30
        Me.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMembers.Location = New System.Drawing.Point(0, 400)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnMembers.Size = New System.Drawing.Size(240, 60)
        Me.btnMembers.TabIndex = 9
        Me.btnMembers.TabStop = False
        Me.btnMembers.Text = "Members"
        Me.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMembers.UseVisualStyleBackColor = False
        '
        'btnStats
        '
        Me.btnStats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStats.FlatAppearance.BorderSize = 0
        Me.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStats.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStats.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnStats.IconColor = System.Drawing.Color.Black
        Me.btnStats.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStats.IconSize = 30
        Me.btnStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStats.Location = New System.Drawing.Point(0, 340)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnStats.Size = New System.Drawing.Size(240, 60)
        Me.btnStats.TabIndex = 8
        Me.btnStats.TabStop = False
        Me.btnStats.Text = "Stats"
        Me.btnStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnSearch.IconColor = System.Drawing.Color.Black
        Me.btnSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearch.IconSize = 30
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(0, 280)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnSearch.Size = New System.Drawing.Size(240, 60)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.TabStop = False
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnCases
        '
        Me.btnCases.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCases.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCases.FlatAppearance.BorderSize = 0
        Me.btnCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCases.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCases.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnCases.IconColor = System.Drawing.Color.Black
        Me.btnCases.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCases.IconSize = 30
        Me.btnCases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCases.Location = New System.Drawing.Point(0, 220)
        Me.btnCases.Name = "btnCases"
        Me.btnCases.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnCases.Size = New System.Drawing.Size(240, 60)
        Me.btnCases.TabIndex = 6
        Me.btnCases.TabStop = False
        Me.btnCases.Text = "Cases"
        Me.btnCases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCases.UseVisualStyleBackColor = False
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.lblDoraCopyrights)
        Me.pnlLogo.Controls.Add(Me.imgCRU)
        Me.pnlLogo.Controls.Add(Me.lblDoraVersion)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(240, 220)
        Me.pnlLogo.TabIndex = 0
        '
        'lblDoraCopyrights
        '
        Me.lblDoraCopyrights.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDoraCopyrights.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoraCopyrights.Location = New System.Drawing.Point(0, 184)
        Me.lblDoraCopyrights.Name = "lblDoraCopyrights"
        Me.lblDoraCopyrights.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDoraCopyrights.Size = New System.Drawing.Size(240, 22)
        Me.lblDoraCopyrights.TabIndex = 122
        Me.lblDoraCopyrights.Text = "© C.R.U. / DJSOC"
        Me.lblDoraCopyrights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgCRU
        '
        Me.imgCRU.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgCRU.BackgroundImage = Global.DORA.My.Resources.Resources.CRULogo
        Me.imgCRU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgCRU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgCRU.Location = New System.Drawing.Point(50, 12)
        Me.imgCRU.Name = "imgCRU"
        Me.imgCRU.Size = New System.Drawing.Size(140, 140)
        Me.imgCRU.TabIndex = 0
        Me.imgCRU.TabStop = False
        '
        'lblDoraVersion
        '
        Me.lblDoraVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDoraVersion.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoraVersion.Location = New System.Drawing.Point(0, 162)
        Me.lblDoraVersion.Name = "lblDoraVersion"
        Me.lblDoraVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDoraVersion.Size = New System.Drawing.Size(240, 22)
        Me.lblDoraVersion.TabIndex = 121
        Me.lblDoraVersion.Text = "iDORA 3.0.220502"
        Me.lblDoraVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(584, 64)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(455, 40)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHello
        '
        Me.lblHello.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(8, 64)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(294, 40)
        Me.lblHello.TabIndex = 118
        Me.lblHello.Text = "Hello"
        Me.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlTitle
        '
        Me.pnlTitle.Controls.Add(Me.lblHello)
        Me.pnlTitle.Controls.Add(Me.pnlControls)
        Me.pnlTitle.Controls.Add(Me.lblTime)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(240, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(1042, 110)
        Me.pnlTitle.TabIndex = 134
        '
        'pnlControls
        '
        Me.pnlControls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControls.Controls.Add(Me.btnClose)
        Me.pnlControls.Controls.Add(Me.btnMin)
        Me.pnlControls.Controls.Add(Me.btnMax)
        Me.pnlControls.Location = New System.Drawing.Point(936, 0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(104, 40)
        Me.pnlControls.TabIndex = 119
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnClose.IconColor = System.Drawing.Color.Black
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.IconSize = 20
        Me.btnClose.Location = New System.Drawing.Point(72, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 120
        Me.btnClose.TabStop = False
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
        Me.btnMin.ForeColor = System.Drawing.Color.Black
        Me.btnMin.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.btnMin.IconColor = System.Drawing.Color.Black
        Me.btnMin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMin.IconSize = 20
        Me.btnMin.Location = New System.Drawing.Point(8, 8)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.btnMin.Size = New System.Drawing.Size(25, 25)
        Me.btnMin.TabIndex = 12
        Me.btnMin.TabStop = False
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.ForeColor = System.Drawing.Color.Black
        Me.btnMax.IconChar = FontAwesome.Sharp.IconChar.Square
        Me.btnMax.IconColor = System.Drawing.Color.Black
        Me.btnMax.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMax.IconSize = 20
        Me.btnMax.Location = New System.Drawing.Point(40, 8)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(25, 25)
        Me.btnMax.TabIndex = 119
        Me.btnMax.TabStop = False
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'pnlCenter
        '
        Me.pnlCenter.Controls.Add(Me.picHoliday)
        Me.pnlCenter.Controls.Add(Me.picBirthday)
        Me.pnlCenter.Controls.Add(Me.picDORA)
        Me.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCenter.Location = New System.Drawing.Point(240, 110)
        Me.pnlCenter.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlCenter.Name = "pnlCenter"
        Me.pnlCenter.Size = New System.Drawing.Size(1042, 743)
        Me.pnlCenter.TabIndex = 135
        '
        'picHoliday
        '
        Me.picHoliday.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picHoliday.Location = New System.Drawing.Point(544, 0)
        Me.picHoliday.Name = "picHoliday"
        Me.picHoliday.Size = New System.Drawing.Size(500, 150)
        Me.picHoliday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHoliday.TabIndex = 3
        Me.picHoliday.TabStop = False
        '
        'picBirthday
        '
        Me.picBirthday.Location = New System.Drawing.Point(0, 0)
        Me.picBirthday.Name = "picBirthday"
        Me.picBirthday.Size = New System.Drawing.Size(426, 310)
        Me.picBirthday.TabIndex = 1
        Me.picBirthday.TabStop = False
        '
        'picDORA
        '
        Me.picDORA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picDORA.Image = CType(resources.GetObject("picDORA.Image"), System.Drawing.Image)
        Me.picDORA.Location = New System.Drawing.Point(128, 164)
        Me.picDORA.Name = "picDORA"
        Me.picDORA.Padding = New System.Windows.Forms.Padding(100)
        Me.picDORA.Size = New System.Drawing.Size(736, 368)
        Me.picDORA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDORA.TabIndex = 0
        Me.picDORA.TabStop = False
        '
        'CITIESBindingSource1
        '
        Me.CITIESBindingSource1.DataMember = "CITIES"
        Me.CITIESBindingSource1.DataSource = Me.DORADbDS
        '
        'CITIESTableAdapter1
        '
        Me.CITIESTableAdapter1.ClearBeforeFill = True
        '
        'CITIESBindingSource2
        '
        Me.CITIESBindingSource2.DataMember = "CITIES"
        Me.CITIESBindingSource2.DataSource = Me.DORADbDS
        '
        'CITIESTableAdapter2
        '
        Me.CITIESTableAdapter2.ClearBeforeFill = True
        '
        'RCMenuCases
        '
        Me.RCMenuCases.BackColor = System.Drawing.SystemColors.Control
        Me.RCMenuCases.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCMenuCases.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RCMenuCases.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnOpenOut})
        Me.RCMenuCases.Name = "RCMenu"
        Me.RCMenuCases.Size = New System.Drawing.Size(117, 32)
        '
        'mnOpenOut
        '
        Me.mnOpenOut.BackgroundImage = Global.DORA.My.Resources.Resources.globe
        Me.mnOpenOut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mnOpenOut.Image = Global.DORA.My.Resources.Resources.eye
        Me.mnOpenOut.Name = "mnOpenOut"
        Me.mnOpenOut.Size = New System.Drawing.Size(116, 28)
        Me.mnOpenOut.Text = "Out"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 853)
        Me.Controls.Add(Me.pnlCenter)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.pnlMenu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1100, 800)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.RCMenu.ResumeLayout(False)
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BACKUPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.imgCRU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlControls.ResumeLayout(False)
        Me.pnlCenter.ResumeLayout(False)
        CType(Me.picHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBirthday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDORA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITIESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITIESBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RCMenuCases.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClockTimer As Timer
    Friend WithEvents RCMenu As ContextMenuStrip
    Friend WithEvents DORADbDS As DORADbDS
    Friend WithEvents BACKUPBindingSource As BindingSource
    Friend WithEvents BACKUPTableAdapter As DORADbDSTableAdapters.BACKUPTableAdapter
    Friend WithEvents TableAdapterManager As DORADbDSTableAdapters.TableAdapterManager
    Friend WithEvents mnTheme As ToolStripMenuItem
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents imgCRU As PictureBox
    Friend WithEvents lblDoraVersion As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblHello As Label
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents btnCases As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProducts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMembers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStats As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMin As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMax As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlCenter As Panel
    Friend WithEvents pnlControls As Panel
    Friend WithEvents mnLanguage As ToolStripMenuItem
    Friend WithEvents mnLanguageN As ToolStripMenuItem
    Friend WithEvents mnLanguageF As ToolStripMenuItem
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Public WithEvents CITIESBindingSource1 As BindingSource
    Public WithEvents CITIESTableAdapter1 As DORADbDSTableAdapters.CITIESTableAdapter
    Public WithEvents CITIESBindingSource2 As BindingSource
    Public WithEvents CITIESTableAdapter2 As DORADbDSTableAdapters.CITIESTableAdapter
    Friend WithEvents mnThemeDark As ToolStripMenuItem
    Friend WithEvents mnThemeAbyss As ToolStripMenuItem
    Friend WithEvents mnThemeKimbie As ToolStripMenuItem
    Friend WithEvents mnThemeNoctis As ToolStripMenuItem
    Friend WithEvents mnThemeDracula As ToolStripMenuItem
    Friend WithEvents picDORA As PictureBox
    Friend WithEvents picBirthday As TransparentPictureBox
    Friend WithEvents picHoliday As TransparentPictureBox
    Friend WithEvents RCMenuCases As ContextMenuStrip
    Friend WithEvents mnOpenOut As ToolStripMenuItem
    Friend WithEvents lblDoraCopyrights As Label
End Class
