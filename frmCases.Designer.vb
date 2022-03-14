<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCases))
        Me.lblRioNum = New System.Windows.Forms.Label()
        Me.lblOnNum = New System.Windows.Forms.Label()
        Me.lblSupport = New System.Windows.Forms.Label()
        Me.lblOrigin = New System.Windows.Forms.Label()
        Me.lblProactiveDate = New System.Windows.Forms.Label()
        Me.lblInvestigationDate = New System.Windows.Forms.Label()
        Me.lblInvestigationMagistrate = New System.Windows.Forms.Label()
        Me.lblJudInvestigationDate = New System.Windows.Forms.Label()
        Me.lblJudInvestigationMagistrate = New System.Windows.Forms.Label()
        Me.lblFederalizedDate = New System.Windows.Forms.Label()
        Me.lblFederalizedMagistrate = New System.Windows.Forms.Label()
        Me.DORADbDS = New DORA.DORADbDS()
        Me.CASESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CASESTableAdapter = New DORA.DORADbDSTableAdapters.CASESTableAdapter()
        Me.TableAdapterManager = New DORA.DORADbDSTableAdapters.TableAdapterManager()
        Me.INTERVENTIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INTERVENTIONSTableAdapter = New DORA.DORADbDSTableAdapters.INTERVENTIONSTableAdapter()
        Me.txtCaseName = New System.Windows.Forms.TextBox()
        Me.cmbTypeOfCase = New System.Windows.Forms.ComboBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.POLICE_UNITSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POLICE_UNITSTableAdapter = New DORA.DORADbDSTableAdapters.POLICE_UNITSTableAdapter()
        Me.cmbCMInt = New System.Windows.Forms.ComboBox()
        Me.txtFileNum = New System.Windows.Forms.TextBox()
        Me.cmbLang = New System.Windows.Forms.ComboBox()
        Me.txtReportNum = New System.Windows.Forms.MaskedTextBox()
        Me.lblReportNum = New System.Windows.Forms.Label()
        Me.lblFileNum = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblLang = New System.Windows.Forms.Label()
        Me.lblCMInt = New System.Windows.Forms.Label()
        Me.lblCMExt = New System.Windows.Forms.Label()
        Me.txtCMExt1 = New System.Windows.Forms.TextBox()
        Me.txtCMExt2 = New System.Windows.Forms.TextBox()
        Me.btnBOM = New FontAwesome.Sharp.IconButton()
        Me.chkBom = New System.Windows.Forms.CheckBox()
        Me.chkEmbargo = New System.Windows.Forms.CheckBox()
        Me.btnEmbargo = New FontAwesome.Sharp.IconButton()
        Me.lblBOM = New System.Windows.Forms.Label()
        Me.cmbSupport = New System.Windows.Forms.ComboBox()
        Me.lblEmbargo = New System.Windows.Forms.Label()
        Me.cmbOrigin = New System.Windows.Forms.ComboBox()
        Me.txtRioNum = New System.Windows.Forms.TextBox()
        Me.txtOnNum = New System.Windows.Forms.TextBox()
        Me.txtSummary = New System.Windows.Forms.TextBox()
        Me.chkInvestigation = New System.Windows.Forms.CheckBox()
        Me.txtInvestigationMagistrate = New System.Windows.Forms.TextBox()
        Me.chkJudInvestigation = New System.Windows.Forms.CheckBox()
        Me.txtJudInvestigationMagistrate = New System.Windows.Forms.TextBox()
        Me.chkFederalized = New System.Windows.Forms.CheckBox()
        Me.txtFederalizedMagistrate = New System.Windows.Forms.TextBox()
        Me.chkProactive = New System.Windows.Forms.CheckBox()
        Me.rbFake = New System.Windows.Forms.RadioButton()
        Me.rbCocaïne = New System.Windows.Forms.RadioButton()
        Me.rbCannabis = New System.Windows.Forms.RadioButton()
        Me.rbSyntheticT = New System.Windows.Forms.RadioButton()
        Me.rbSyntheticP = New System.Windows.Forms.RadioButton()
        Me.cmbNSP = New System.Windows.Forms.ComboBox()
        Me.lblSienaNum = New System.Windows.Forms.Label()
        Me.txtSienaNum = New System.Windows.Forms.TextBox()
        Me.chkSienaPictures = New System.Windows.Forms.CheckBox()
        Me.lblon2 = New System.Windows.Forms.Label()
        Me.lblon1 = New System.Windows.Forms.Label()
        Me.lblSienaPictures = New System.Windows.Forms.Label()
        Me.btnSienaPictures = New FontAwesome.Sharp.IconButton()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.picMin = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnFolder = New FontAwesome.Sharp.IconButton()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.imgCRU = New System.Windows.Forms.PictureBox()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.btnMin = New FontAwesome.Sharp.IconButton()
        Me.pnlNSPMain = New System.Windows.Forms.Panel()
        Me.lblCocaine = New System.Windows.Forms.Label()
        Me.lblSyntheticT = New System.Windows.Forms.Label()
        Me.lblSyntheticP = New System.Windows.Forms.Label()
        Me.lblCannabis = New System.Windows.Forms.Label()
        Me.btnSyntheticP = New FontAwesome.Sharp.IconButton()
        Me.btnSyntheticT = New FontAwesome.Sharp.IconButton()
        Me.btnCocaine = New FontAwesome.Sharp.IconButton()
        Me.btnCannabis = New FontAwesome.Sharp.IconButton()
        Me.pnlProactiveMain = New System.Windows.Forms.Panel()
        Me.txtProactiveDate = New System.Windows.Forms.DateTimePicker()
        Me.lblProactive = New System.Windows.Forms.Label()
        Me.btnProactive = New FontAwesome.Sharp.IconButton()
        Me.pnlInvestigationMain = New System.Windows.Forms.Panel()
        Me.txtInvestigationDate = New System.Windows.Forms.DateTimePicker()
        Me.lblInvestigation = New System.Windows.Forms.Label()
        Me.btnInvestigation = New FontAwesome.Sharp.IconButton()
        Me.lblNSPTitle = New System.Windows.Forms.Label()
        Me.lblProactiveTitle = New System.Windows.Forms.Label()
        Me.lblInvestigationTitle = New System.Windows.Forms.Label()
        Me.lblJudInvestigationTitle = New System.Windows.Forms.Label()
        Me.lblFederalizedTitle = New System.Windows.Forms.Label()
        Me.pnlNSPTitle = New System.Windows.Forms.Panel()
        Me.pnlProactiveTitle = New System.Windows.Forms.Panel()
        Me.pnlInvestigationTitle = New System.Windows.Forms.Panel()
        Me.pnlJudInvestigationTitle = New System.Windows.Forms.Panel()
        Me.pnlFederalizedTitle = New System.Windows.Forms.Panel()
        Me.pnlJudInvestigationMain = New System.Windows.Forms.Panel()
        Me.txtJudInvestigationDate = New System.Windows.Forms.DateTimePicker()
        Me.lblJudInvestigation = New System.Windows.Forms.Label()
        Me.btnJudInvestigation = New FontAwesome.Sharp.IconButton()
        Me.pnlFederalizedMain = New System.Windows.Forms.Panel()
        Me.txtFederalizedDate = New System.Windows.Forms.DateTimePicker()
        Me.lblFederalized = New System.Windows.Forms.Label()
        Me.btnFederalized = New FontAwesome.Sharp.IconButton()
        Me.pnlCenter = New System.Windows.Forms.Panel()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCaseName = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblTypeOfCase = New System.Windows.Forms.Label()
        Me.pnlTab = New System.Windows.Forms.Panel()
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.pnlSiena = New System.Windows.Forms.Panel()
        Me.txtSienaPicturesDate = New System.Windows.Forms.DateTimePicker()
        Me.txtSienaDate = New System.Windows.Forms.DateTimePicker()
        Me.fsw = New System.IO.FileSystemWatcher()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POLICE_UNITSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        CType(Me.imgCRU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.pnlNSPMain.SuspendLayout()
        Me.pnlProactiveMain.SuspendLayout()
        Me.pnlInvestigationMain.SuspendLayout()
        Me.pnlNSPTitle.SuspendLayout()
        Me.pnlProactiveTitle.SuspendLayout()
        Me.pnlInvestigationTitle.SuspendLayout()
        Me.pnlJudInvestigationTitle.SuspendLayout()
        Me.pnlFederalizedTitle.SuspendLayout()
        Me.pnlJudInvestigationMain.SuspendLayout()
        Me.pnlFederalizedMain.SuspendLayout()
        Me.pnlCenter.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        Me.pnlTab.SuspendLayout()
        Me.pnlSummary.SuspendLayout()
        Me.pnlSiena.SuspendLayout()
        CType(Me.fsw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRioNum
        '
        Me.lblRioNum.AutoSize = True
        Me.lblRioNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRioNum.Location = New System.Drawing.Point(512, 102)
        Me.lblRioNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRioNum.Name = "lblRioNum"
        Me.lblRioNum.Size = New System.Drawing.Size(85, 24)
        Me.lblRioNum.TabIndex = 29
        Me.lblRioNum.Text = "RIO Num"
        '
        'lblOnNum
        '
        Me.lblOnNum.AutoSize = True
        Me.lblOnNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnNum.Location = New System.Drawing.Point(512, 142)
        Me.lblOnNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOnNum.Name = "lblOnNum"
        Me.lblOnNum.Size = New System.Drawing.Size(82, 24)
        Me.lblOnNum.TabIndex = 30
        Me.lblOnNum.Text = "ON Num"
        '
        'lblSupport
        '
        Me.lblSupport.AutoSize = True
        Me.lblSupport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupport.Location = New System.Drawing.Point(512, 63)
        Me.lblSupport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSupport.Name = "lblSupport"
        Me.lblSupport.Size = New System.Drawing.Size(77, 24)
        Me.lblSupport.TabIndex = 31
        Me.lblSupport.Text = "Support"
        '
        'lblOrigin
        '
        Me.lblOrigin.AutoSize = True
        Me.lblOrigin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigin.Location = New System.Drawing.Point(512, 25)
        Me.lblOrigin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrigin.Name = "lblOrigin"
        Me.lblOrigin.Size = New System.Drawing.Size(102, 24)
        Me.lblOrigin.TabIndex = 32
        Me.lblOrigin.Text = "DOS Origin"
        '
        'lblProactiveDate
        '
        Me.lblProactiveDate.AutoSize = True
        Me.lblProactiveDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProactiveDate.Location = New System.Drawing.Point(13, 68)
        Me.lblProactiveDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProactiveDate.Name = "lblProactiveDate"
        Me.lblProactiveDate.Size = New System.Drawing.Size(32, 24)
        Me.lblProactiveDate.TabIndex = 43
        Me.lblProactiveDate.Text = "on"
        '
        'lblInvestigationDate
        '
        Me.lblInvestigationDate.AutoSize = True
        Me.lblInvestigationDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestigationDate.Location = New System.Drawing.Point(13, 68)
        Me.lblInvestigationDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInvestigationDate.Name = "lblInvestigationDate"
        Me.lblInvestigationDate.Size = New System.Drawing.Size(32, 24)
        Me.lblInvestigationDate.TabIndex = 44
        Me.lblInvestigationDate.Text = "on"
        '
        'lblInvestigationMagistrate
        '
        Me.lblInvestigationMagistrate.AutoSize = True
        Me.lblInvestigationMagistrate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestigationMagistrate.Location = New System.Drawing.Point(13, 108)
        Me.lblInvestigationMagistrate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInvestigationMagistrate.Name = "lblInvestigationMagistrate"
        Me.lblInvestigationMagistrate.Size = New System.Drawing.Size(100, 24)
        Me.lblInvestigationMagistrate.TabIndex = 45
        Me.lblInvestigationMagistrate.Text = "Magistrate"
        '
        'lblJudInvestigationDate
        '
        Me.lblJudInvestigationDate.AutoSize = True
        Me.lblJudInvestigationDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudInvestigationDate.Location = New System.Drawing.Point(13, 68)
        Me.lblJudInvestigationDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJudInvestigationDate.Name = "lblJudInvestigationDate"
        Me.lblJudInvestigationDate.Size = New System.Drawing.Size(32, 24)
        Me.lblJudInvestigationDate.TabIndex = 46
        Me.lblJudInvestigationDate.Text = "on"
        '
        'lblJudInvestigationMagistrate
        '
        Me.lblJudInvestigationMagistrate.AutoSize = True
        Me.lblJudInvestigationMagistrate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudInvestigationMagistrate.Location = New System.Drawing.Point(13, 108)
        Me.lblJudInvestigationMagistrate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJudInvestigationMagistrate.Name = "lblJudInvestigationMagistrate"
        Me.lblJudInvestigationMagistrate.Size = New System.Drawing.Size(100, 24)
        Me.lblJudInvestigationMagistrate.TabIndex = 47
        Me.lblJudInvestigationMagistrate.Text = "Magistrate"
        '
        'lblFederalizedDate
        '
        Me.lblFederalizedDate.AutoSize = True
        Me.lblFederalizedDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalizedDate.Location = New System.Drawing.Point(13, 68)
        Me.lblFederalizedDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFederalizedDate.Name = "lblFederalizedDate"
        Me.lblFederalizedDate.Size = New System.Drawing.Size(32, 24)
        Me.lblFederalizedDate.TabIndex = 48
        Me.lblFederalizedDate.Text = "on"
        '
        'lblFederalizedMagistrate
        '
        Me.lblFederalizedMagistrate.AutoSize = True
        Me.lblFederalizedMagistrate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalizedMagistrate.Location = New System.Drawing.Point(13, 108)
        Me.lblFederalizedMagistrate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFederalizedMagistrate.Name = "lblFederalizedMagistrate"
        Me.lblFederalizedMagistrate.Size = New System.Drawing.Size(100, 24)
        Me.lblFederalizedMagistrate.TabIndex = 49
        Me.lblFederalizedMagistrate.Text = "Magistrate"
        '
        'DORADbDS
        '
        Me.DORADbDS.DataSetName = "DORADbDS"
        Me.DORADbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BACKUPTableAdapter = Nothing
        Me.TableAdapterManager.CASESTableAdapter = Me.CASESTableAdapter
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
        'INTERVENTIONSBindingSource
        '
        Me.INTERVENTIONSBindingSource.DataMember = "INTERVENTIONS"
        Me.INTERVENTIONSBindingSource.DataSource = Me.DORADbDS
        '
        'INTERVENTIONSTableAdapter
        '
        Me.INTERVENTIONSTableAdapter.ClearBeforeFill = True
        '
        'txtCaseName
        '
        Me.txtCaseName.AcceptsReturn = True
        Me.txtCaseName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCaseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaseName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCaseName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "CASE NAME", True))
        Me.txtCaseName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCaseName.Location = New System.Drawing.Point(181, 16)
        Me.txtCaseName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCaseName.Name = "txtCaseName"
        Me.txtCaseName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCaseName.Size = New System.Drawing.Size(305, 32)
        Me.txtCaseName.TabIndex = 0
        '
        'cmbTypeOfCase
        '
        Me.cmbTypeOfCase.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTypeOfCase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "TYPE OF CASE", True))
        Me.cmbTypeOfCase.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypeOfCase.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbTypeOfCase.FormattingEnabled = True
        Me.cmbTypeOfCase.Items.AddRange(New Object() {"Dumping", "Lab", "Storage", "Traffic", "Cannabis", "No Drugs", "Unconfirmed"})
        Me.cmbTypeOfCase.Location = New System.Drawing.Point(181, 96)
        Me.cmbTypeOfCase.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTypeOfCase.Name = "cmbTypeOfCase"
        Me.cmbTypeOfCase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTypeOfCase.Size = New System.Drawing.Size(305, 32)
        Me.cmbTypeOfCase.TabIndex = 2
        '
        'cmbUnit
        '
        Me.cmbUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cmbUnit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "UNIT", True))
        Me.cmbUnit.DataSource = Me.POLICE_UNITSBindingSource
        Me.cmbUnit.DisplayMember = "POLICE UNIT NAME"
        Me.cmbUnit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(181, 57)
        Me.cmbUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbUnit.Size = New System.Drawing.Size(305, 32)
        Me.cmbUnit.TabIndex = 1
        '
        'POLICE_UNITSBindingSource
        '
        Me.POLICE_UNITSBindingSource.DataMember = "POLICE UNITS"
        Me.POLICE_UNITSBindingSource.DataSource = Me.DORADbDS
        '
        'POLICE_UNITSTableAdapter
        '
        Me.POLICE_UNITSTableAdapter.ClearBeforeFill = True
        '
        'cmbCMInt
        '
        Me.cmbCMInt.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCMInt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "CMINT", True))
        Me.cmbCMInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCMInt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbCMInt.FormattingEnabled = True
        Me.cmbCMInt.Items.AddRange(New Object() {"Étienne DANS", "Alexandre COPPE", "Charlotte MAUPIN", "Peter BELLEMANS", "Laurent DEHON"})
        Me.cmbCMInt.Location = New System.Drawing.Point(181, 295)
        Me.cmbCMInt.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCMInt.Name = "cmbCMInt"
        Me.cmbCMInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCMInt.Size = New System.Drawing.Size(305, 32)
        Me.cmbCMInt.TabIndex = 3
        '
        'txtFileNum
        '
        Me.txtFileNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtFileNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFileNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "FILE NUM", True))
        Me.txtFileNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtFileNum.Location = New System.Drawing.Point(181, 176)
        Me.txtFileNum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFileNum.Name = "txtFileNum"
        Me.txtFileNum.ReadOnly = True
        Me.txtFileNum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFileNum.Size = New System.Drawing.Size(305, 32)
        Me.txtFileNum.TabIndex = 4
        '
        'cmbLang
        '
        Me.cmbLang.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLang.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "LANG", True))
        Me.cmbLang.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLang.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbLang.FormattingEnabled = True
        Me.cmbLang.Items.AddRange(New Object() {"Nederlands", "Français"})
        Me.cmbLang.Location = New System.Drawing.Point(181, 256)
        Me.cmbLang.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLang.Name = "cmbLang"
        Me.cmbLang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbLang.Size = New System.Drawing.Size(305, 32)
        Me.cmbLang.TabIndex = 8
        '
        'txtReportNum
        '
        Me.txtReportNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtReportNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReportNum.Culture = New System.Globalization.CultureInfo("en-001")
        Me.txtReportNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "REPORT NUM", True))
        Me.txtReportNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtReportNum.Location = New System.Drawing.Point(181, 217)
        Me.txtReportNum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReportNum.Mask = ">LL.AA.AA.000000/0000"
        Me.txtReportNum.Name = "txtReportNum"
        Me.txtReportNum.Size = New System.Drawing.Size(305, 32)
        Me.txtReportNum.TabIndex = 5
        '
        'lblReportNum
        '
        Me.lblReportNum.AutoSize = True
        Me.lblReportNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportNum.Location = New System.Drawing.Point(16, 220)
        Me.lblReportNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReportNum.Name = "lblReportNum"
        Me.lblReportNum.Size = New System.Drawing.Size(112, 24)
        Me.lblReportNum.TabIndex = 14
        Me.lblReportNum.Text = "Report Num"
        '
        'lblFileNum
        '
        Me.lblFileNum.AutoSize = True
        Me.lblFileNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileNum.Location = New System.Drawing.Point(16, 180)
        Me.lblFileNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFileNum.Name = "lblFileNum"
        Me.lblFileNum.Size = New System.Drawing.Size(84, 24)
        Me.lblFileNum.TabIndex = 15
        Me.lblFileNum.Text = "File Num"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(16, 140)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(50, 24)
        Me.lblDate.TabIndex = 16
        Me.lblDate.Text = "Date"
        '
        'lblLang
        '
        Me.lblLang.AutoSize = True
        Me.lblLang.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLang.Location = New System.Drawing.Point(16, 260)
        Me.lblLang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLang.Name = "lblLang"
        Me.lblLang.Size = New System.Drawing.Size(88, 24)
        Me.lblLang.TabIndex = 17
        Me.lblLang.Text = "Language"
        '
        'lblCMInt
        '
        Me.lblCMInt.AutoSize = True
        Me.lblCMInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCMInt.Location = New System.Drawing.Point(16, 300)
        Me.lblCMInt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCMInt.Name = "lblCMInt"
        Me.lblCMInt.Size = New System.Drawing.Size(128, 24)
        Me.lblCMInt.TabIndex = 18
        Me.lblCMInt.Text = "Case Manager"
        '
        'lblCMExt
        '
        Me.lblCMExt.AutoSize = True
        Me.lblCMExt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCMExt.Location = New System.Drawing.Point(512, 254)
        Me.lblCMExt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCMExt.Name = "lblCMExt"
        Me.lblCMExt.Size = New System.Drawing.Size(128, 24)
        Me.lblCMExt.TabIndex = 22
        Me.lblCMExt.Text = "Case Manager"
        '
        'txtCMExt1
        '
        Me.txtCMExt1.BackColor = System.Drawing.SystemColors.Window
        Me.txtCMExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCMExt1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "CMEXT1", True))
        Me.txtCMExt1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCMExt1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCMExt1.Location = New System.Drawing.Point(693, 250)
        Me.txtCMExt1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCMExt1.Name = "txtCMExt1"
        Me.txtCMExt1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCMExt1.Size = New System.Drawing.Size(305, 32)
        Me.txtCMExt1.TabIndex = 12
        '
        'txtCMExt2
        '
        Me.txtCMExt2.BackColor = System.Drawing.SystemColors.Window
        Me.txtCMExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCMExt2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "CMEXT2", True))
        Me.txtCMExt2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCMExt2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCMExt2.Location = New System.Drawing.Point(693, 289)
        Me.txtCMExt2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCMExt2.Name = "txtCMExt2"
        Me.txtCMExt2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCMExt2.Size = New System.Drawing.Size(305, 32)
        Me.txtCMExt2.TabIndex = 13
        '
        'btnBOM
        '
        Me.btnBOM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBOM.FlatAppearance.BorderSize = 0
        Me.btnBOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBOM.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnBOM.IconColor = System.Drawing.Color.Black
        Me.btnBOM.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBOM.IconSize = 25
        Me.btnBOM.Location = New System.Drawing.Point(693, 215)
        Me.btnBOM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBOM.Name = "btnBOM"
        Me.btnBOM.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnBOM.Size = New System.Drawing.Size(25, 25)
        Me.btnBOM.TabIndex = 137
        Me.btnBOM.UseVisualStyleBackColor = True
        '
        'chkBom
        '
        Me.chkBom.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CASESBindingSource, "BOM", True))
        Me.chkBom.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBom.Location = New System.Drawing.Point(747, 213)
        Me.chkBom.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBom.Name = "chkBom"
        Me.chkBom.Size = New System.Drawing.Size(128, 30)
        Me.chkBom.TabIndex = 1
        Me.chkBom.Text = "BOM"
        Me.chkBom.UseVisualStyleBackColor = True
        '
        'chkEmbargo
        '
        Me.chkEmbargo.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CASESBindingSource, "EMBARGO", True))
        Me.chkEmbargo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEmbargo.Location = New System.Drawing.Point(747, 176)
        Me.chkEmbargo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEmbargo.Name = "chkEmbargo"
        Me.chkEmbargo.Size = New System.Drawing.Size(128, 30)
        Me.chkEmbargo.TabIndex = 2
        Me.chkEmbargo.Text = "Embargo"
        Me.chkEmbargo.UseVisualStyleBackColor = True
        '
        'btnEmbargo
        '
        Me.btnEmbargo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmbargo.FlatAppearance.BorderSize = 0
        Me.btnEmbargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmbargo.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnEmbargo.IconColor = System.Drawing.Color.Black
        Me.btnEmbargo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEmbargo.IconSize = 25
        Me.btnEmbargo.Location = New System.Drawing.Point(693, 177)
        Me.btnEmbargo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEmbargo.Name = "btnEmbargo"
        Me.btnEmbargo.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnEmbargo.Size = New System.Drawing.Size(25, 25)
        Me.btnEmbargo.TabIndex = 136
        Me.btnEmbargo.UseVisualStyleBackColor = True
        '
        'lblBOM
        '
        Me.lblBOM.AutoSize = True
        Me.lblBOM.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBOM.Location = New System.Drawing.Point(512, 217)
        Me.lblBOM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBOM.Name = "lblBOM"
        Me.lblBOM.Size = New System.Drawing.Size(52, 24)
        Me.lblBOM.TabIndex = 35
        Me.lblBOM.Text = "BOM"
        '
        'cmbSupport
        '
        Me.cmbSupport.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSupport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "SUPPORT", True))
        Me.cmbSupport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbSupport.FormattingEnabled = True
        Me.cmbSupport.Location = New System.Drawing.Point(693, 57)
        Me.cmbSupport.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSupport.Name = "cmbSupport"
        Me.cmbSupport.Size = New System.Drawing.Size(304, 32)
        Me.cmbSupport.TabIndex = 9
        '
        'lblEmbargo
        '
        Me.lblEmbargo.AutoSize = True
        Me.lblEmbargo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmbargo.Location = New System.Drawing.Point(512, 178)
        Me.lblEmbargo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmbargo.Name = "lblEmbargo"
        Me.lblEmbargo.Size = New System.Drawing.Size(84, 24)
        Me.lblEmbargo.TabIndex = 34
        Me.lblEmbargo.Text = "Embargo"
        '
        'cmbOrigin
        '
        Me.cmbOrigin.BackColor = System.Drawing.SystemColors.Window
        Me.cmbOrigin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "DOS ORIGIN", True))
        Me.cmbOrigin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrigin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbOrigin.FormattingEnabled = True
        Me.cmbOrigin.Location = New System.Drawing.Point(693, 16)
        Me.cmbOrigin.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbOrigin.Name = "cmbOrigin"
        Me.cmbOrigin.Size = New System.Drawing.Size(304, 32)
        Me.cmbOrigin.TabIndex = 7
        '
        'txtRioNum
        '
        Me.txtRioNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtRioNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRioNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "RIO NUM", True))
        Me.txtRioNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRioNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtRioNum.Location = New System.Drawing.Point(693, 98)
        Me.txtRioNum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRioNum.Name = "txtRioNum"
        Me.txtRioNum.Size = New System.Drawing.Size(305, 32)
        Me.txtRioNum.TabIndex = 10
        '
        'txtOnNum
        '
        Me.txtOnNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtOnNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOnNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "ON NUM", True))
        Me.txtOnNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOnNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtOnNum.Location = New System.Drawing.Point(693, 137)
        Me.txtOnNum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOnNum.Name = "txtOnNum"
        Me.txtOnNum.Size = New System.Drawing.Size(305, 32)
        Me.txtOnNum.TabIndex = 11
        '
        'txtSummary
        '
        Me.txtSummary.BackColor = System.Drawing.SystemColors.Window
        Me.txtSummary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "SUMMARY", True))
        Me.txtSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSummary.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSummary.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSummary.Location = New System.Drawing.Point(16, 16)
        Me.txtSummary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSummary.Multiline = True
        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSummary.Size = New System.Drawing.Size(280, 295)
        Me.txtSummary.TabIndex = 0
        '
        'chkInvestigation
        '
        Me.chkInvestigation.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CASESBindingSource, "INVESTIGATION", True))
        Me.chkInvestigation.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInvestigation.Location = New System.Drawing.Point(180, 20)
        Me.chkInvestigation.Margin = New System.Windows.Forms.Padding(4)
        Me.chkInvestigation.Name = "chkInvestigation"
        Me.chkInvestigation.Size = New System.Drawing.Size(149, 30)
        Me.chkInvestigation.TabIndex = 0
        Me.chkInvestigation.Text = "Investigation"
        Me.chkInvestigation.UseVisualStyleBackColor = True
        '
        'txtInvestigationMagistrate
        '
        Me.txtInvestigationMagistrate.BackColor = System.Drawing.SystemColors.Window
        Me.txtInvestigationMagistrate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "INVESTIGATION MAGISTRATE", True))
        Me.txtInvestigationMagistrate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvestigationMagistrate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtInvestigationMagistrate.Location = New System.Drawing.Point(120, 103)
        Me.txtInvestigationMagistrate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInvestigationMagistrate.Name = "txtInvestigationMagistrate"
        Me.txtInvestigationMagistrate.Size = New System.Drawing.Size(232, 32)
        Me.txtInvestigationMagistrate.TabIndex = 2
        '
        'chkJudInvestigation
        '
        Me.chkJudInvestigation.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CASESBindingSource, "JUD INVESTIGATION", True))
        Me.chkJudInvestigation.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJudInvestigation.Location = New System.Drawing.Point(211, 20)
        Me.chkJudInvestigation.Margin = New System.Windows.Forms.Padding(4)
        Me.chkJudInvestigation.Name = "chkJudInvestigation"
        Me.chkJudInvestigation.Size = New System.Drawing.Size(183, 30)
        Me.chkJudInvestigation.TabIndex = 0
        Me.chkJudInvestigation.Text = "Jud. Investigation"
        Me.chkJudInvestigation.UseVisualStyleBackColor = True
        '
        'txtJudInvestigationMagistrate
        '
        Me.txtJudInvestigationMagistrate.BackColor = System.Drawing.SystemColors.Window
        Me.txtJudInvestigationMagistrate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "JUD INVESTIGATION MAGISTRATE", True))
        Me.txtJudInvestigationMagistrate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJudInvestigationMagistrate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtJudInvestigationMagistrate.Location = New System.Drawing.Point(120, 103)
        Me.txtJudInvestigationMagistrate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJudInvestigationMagistrate.Name = "txtJudInvestigationMagistrate"
        Me.txtJudInvestigationMagistrate.Size = New System.Drawing.Size(232, 32)
        Me.txtJudInvestigationMagistrate.TabIndex = 2
        '
        'chkFederalized
        '
        Me.chkFederalized.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CASESBindingSource, "FEDERALIZED", True))
        Me.chkFederalized.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFederalized.Location = New System.Drawing.Point(211, 20)
        Me.chkFederalized.Margin = New System.Windows.Forms.Padding(4)
        Me.chkFederalized.Name = "chkFederalized"
        Me.chkFederalized.Size = New System.Drawing.Size(140, 30)
        Me.chkFederalized.TabIndex = 0
        Me.chkFederalized.Text = "Federalized"
        Me.chkFederalized.UseVisualStyleBackColor = True
        '
        'txtFederalizedMagistrate
        '
        Me.txtFederalizedMagistrate.BackColor = System.Drawing.SystemColors.Window
        Me.txtFederalizedMagistrate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "FEDERALIZED MAGISTRATE", True))
        Me.txtFederalizedMagistrate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFederalizedMagistrate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtFederalizedMagistrate.Location = New System.Drawing.Point(120, 103)
        Me.txtFederalizedMagistrate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFederalizedMagistrate.Name = "txtFederalizedMagistrate"
        Me.txtFederalizedMagistrate.Size = New System.Drawing.Size(232, 32)
        Me.txtFederalizedMagistrate.TabIndex = 2
        '
        'chkProactive
        '
        Me.chkProactive.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CASESBindingSource, "PROACTIVE", True))
        Me.chkProactive.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProactive.Location = New System.Drawing.Point(149, 20)
        Me.chkProactive.Margin = New System.Windows.Forms.Padding(4)
        Me.chkProactive.Name = "chkProactive"
        Me.chkProactive.Size = New System.Drawing.Size(131, 30)
        Me.chkProactive.TabIndex = 0
        Me.chkProactive.Text = "Proactive"
        Me.chkProactive.UseVisualStyleBackColor = True
        '
        'rbFake
        '
        Me.rbFake.AutoSize = True
        Me.rbFake.Location = New System.Drawing.Point(429, 30)
        Me.rbFake.Margin = New System.Windows.Forms.Padding(4)
        Me.rbFake.Name = "rbFake"
        Me.rbFake.Size = New System.Drawing.Size(59, 20)
        Me.rbFake.TabIndex = 89
        Me.rbFake.TabStop = True
        Me.rbFake.Text = "Fake"
        Me.rbFake.UseVisualStyleBackColor = True
        Me.rbFake.Visible = False
        '
        'rbCocaïne
        '
        Me.rbCocaïne.AutoSize = True
        Me.rbCocaïne.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCocaïne.Location = New System.Drawing.Point(509, 108)
        Me.rbCocaïne.Margin = New System.Windows.Forms.Padding(4)
        Me.rbCocaïne.Name = "rbCocaïne"
        Me.rbCocaïne.Size = New System.Drawing.Size(115, 28)
        Me.rbCocaïne.TabIndex = 3
        Me.rbCocaïne.TabStop = True
        Me.rbCocaïne.Text = "rbCocaïne"
        Me.rbCocaïne.UseVisualStyleBackColor = True
        '
        'rbCannabis
        '
        Me.rbCannabis.AutoSize = True
        Me.rbCannabis.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCannabis.Location = New System.Drawing.Point(509, 20)
        Me.rbCannabis.Margin = New System.Windows.Forms.Padding(4)
        Me.rbCannabis.Name = "rbCannabis"
        Me.rbCannabis.Size = New System.Drawing.Size(126, 28)
        Me.rbCannabis.TabIndex = 0
        Me.rbCannabis.TabStop = True
        Me.rbCannabis.Text = "rbCannabis"
        Me.rbCannabis.UseVisualStyleBackColor = True
        '
        'rbSyntheticT
        '
        Me.rbSyntheticT.AutoSize = True
        Me.rbSyntheticT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSyntheticT.Location = New System.Drawing.Point(509, 79)
        Me.rbSyntheticT.Margin = New System.Windows.Forms.Padding(4)
        Me.rbSyntheticT.Name = "rbSyntheticT"
        Me.rbSyntheticT.Size = New System.Drawing.Size(136, 28)
        Me.rbSyntheticT.TabIndex = 2
        Me.rbSyntheticT.TabStop = True
        Me.rbSyntheticT.Text = "rbSyntheticT"
        Me.rbSyntheticT.UseVisualStyleBackColor = True
        '
        'rbSyntheticP
        '
        Me.rbSyntheticP.AutoSize = True
        Me.rbSyntheticP.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSyntheticP.Location = New System.Drawing.Point(509, 49)
        Me.rbSyntheticP.Margin = New System.Windows.Forms.Padding(4)
        Me.rbSyntheticP.Name = "rbSyntheticP"
        Me.rbSyntheticP.Size = New System.Drawing.Size(137, 28)
        Me.rbSyntheticP.TabIndex = 1
        Me.rbSyntheticP.TabStop = True
        Me.rbSyntheticP.Text = "rbSyntheticP"
        Me.rbSyntheticP.UseVisualStyleBackColor = True
        '
        'cmbNSP
        '
        Me.cmbNSP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "NSP", True))
        Me.cmbNSP.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNSP.FormattingEnabled = True
        Me.cmbNSP.Location = New System.Drawing.Point(420, 60)
        Me.cmbNSP.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbNSP.Name = "cmbNSP"
        Me.cmbNSP.Size = New System.Drawing.Size(223, 32)
        Me.cmbNSP.TabIndex = 33
        '
        'lblSienaNum
        '
        Me.lblSienaNum.AutoSize = True
        Me.lblSienaNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSienaNum.Location = New System.Drawing.Point(11, 20)
        Me.lblSienaNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSienaNum.Name = "lblSienaNum"
        Me.lblSienaNum.Size = New System.Drawing.Size(50, 24)
        Me.lblSienaNum.TabIndex = 33
        Me.lblSienaNum.Text = "Num"
        '
        'txtSienaNum
        '
        Me.txtSienaNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtSienaNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "SIENA NUM", True))
        Me.txtSienaNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSienaNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSienaNum.Location = New System.Drawing.Point(199, 16)
        Me.txtSienaNum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSienaNum.Name = "txtSienaNum"
        Me.txtSienaNum.Size = New System.Drawing.Size(191, 32)
        Me.txtSienaNum.TabIndex = 0
        '
        'chkSienaPictures
        '
        Me.chkSienaPictures.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CASESBindingSource, "SIENA PICTURES SENT", True))
        Me.chkSienaPictures.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSienaPictures.Location = New System.Drawing.Point(259, 60)
        Me.chkSienaPictures.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSienaPictures.Name = "chkSienaPictures"
        Me.chkSienaPictures.Size = New System.Drawing.Size(69, 30)
        Me.chkSienaPictures.TabIndex = 2
        Me.chkSienaPictures.Text = "Pics"
        Me.chkSienaPictures.UseVisualStyleBackColor = True
        '
        'lblon2
        '
        Me.lblon2.AutoSize = True
        Me.lblon2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblon2.Location = New System.Drawing.Point(409, 60)
        Me.lblon2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblon2.Name = "lblon2"
        Me.lblon2.Size = New System.Drawing.Size(32, 24)
        Me.lblon2.TabIndex = 141
        Me.lblon2.Text = "on"
        '
        'lblon1
        '
        Me.lblon1.AutoSize = True
        Me.lblon1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblon1.Location = New System.Drawing.Point(409, 20)
        Me.lblon1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblon1.Name = "lblon1"
        Me.lblon1.Size = New System.Drawing.Size(32, 24)
        Me.lblon1.TabIndex = 140
        Me.lblon1.Text = "on"
        '
        'lblSienaPictures
        '
        Me.lblSienaPictures.AutoSize = True
        Me.lblSienaPictures.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSienaPictures.Location = New System.Drawing.Point(9, 60)
        Me.lblSienaPictures.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSienaPictures.Name = "lblSienaPictures"
        Me.lblSienaPictures.Size = New System.Drawing.Size(119, 24)
        Me.lblSienaPictures.TabIndex = 138
        Me.lblSienaPictures.Text = "Pictures Sent"
        '
        'btnSienaPictures
        '
        Me.btnSienaPictures.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSienaPictures.FlatAppearance.BorderSize = 0
        Me.btnSienaPictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSienaPictures.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnSienaPictures.IconColor = System.Drawing.Color.Black
        Me.btnSienaPictures.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSienaPictures.IconSize = 25
        Me.btnSienaPictures.Location = New System.Drawing.Point(199, 59)
        Me.btnSienaPictures.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSienaPictures.Name = "btnSienaPictures"
        Me.btnSienaPictures.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnSienaPictures.Size = New System.Drawing.Size(25, 25)
        Me.btnSienaPictures.TabIndex = 138
        Me.btnSienaPictures.UseVisualStyleBackColor = True
        '
        'picMin
        '
        Me.picMin.BackColor = System.Drawing.Color.Orange
        Me.picMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMin.Location = New System.Drawing.Point(1899, 0)
        Me.picMin.Margin = New System.Windows.Forms.Padding(4)
        Me.picMin.Name = "picMin"
        Me.picMin.Size = New System.Drawing.Size(21, 20)
        Me.picMin.TabIndex = 134
        Me.picMin.TabStop = False
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
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.btnFolder)
        Me.pnlMenu.Controls.Add(Me.btnSave)
        Me.pnlMenu.Controls.Add(Me.btnExit)
        Me.pnlMenu.Controls.Add(Me.pnlLogo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(131, 852)
        Me.pnlMenu.TabIndex = 35
        '
        'btnFolder
        '
        Me.btnFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFolder.FlatAppearance.BorderSize = 0
        Me.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFolder.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFolder.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        Me.btnFolder.IconColor = System.Drawing.Color.Black
        Me.btnFolder.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnFolder.IconSize = 30
        Me.btnFolder.Location = New System.Drawing.Point(0, 250)
        Me.btnFolder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFolder.Name = "btnFolder"
        Me.btnFolder.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.btnFolder.Size = New System.Drawing.Size(131, 60)
        Me.btnFolder.TabIndex = 15
        Me.btnFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFolder.UseVisualStyleBackColor = False
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
        Me.btnExit.Location = New System.Drawing.Point(0, 792)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.btnExit.Size = New System.Drawing.Size(131, 60)
        Me.btnExit.TabIndex = 13
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
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
        'pnlTitle
        '
        Me.pnlTitle.Controls.Add(Me.pnlControls)
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(131, 0)
        Me.pnlTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(1070, 130)
        Me.pnlTitle.TabIndex = 135
        '
        'pnlControls
        '
        Me.pnlControls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControls.Controls.Add(Me.btnClose)
        Me.pnlControls.Controls.Add(Me.btnMin)
        Me.pnlControls.Location = New System.Drawing.Point(998, 0)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(69, 39)
        Me.pnlControls.TabIndex = 136
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
        'pnlNSPMain
        '
        Me.pnlNSPMain.Controls.Add(Me.lblCocaine)
        Me.pnlNSPMain.Controls.Add(Me.cmbNSP)
        Me.pnlNSPMain.Controls.Add(Me.lblSyntheticT)
        Me.pnlNSPMain.Controls.Add(Me.lblSyntheticP)
        Me.pnlNSPMain.Controls.Add(Me.lblCannabis)
        Me.pnlNSPMain.Controls.Add(Me.btnSyntheticP)
        Me.pnlNSPMain.Controls.Add(Me.btnSyntheticT)
        Me.pnlNSPMain.Controls.Add(Me.btnCocaine)
        Me.pnlNSPMain.Controls.Add(Me.btnCannabis)
        Me.pnlNSPMain.Controls.Add(Me.rbFake)
        Me.pnlNSPMain.Controls.Add(Me.rbCannabis)
        Me.pnlNSPMain.Controls.Add(Me.rbSyntheticP)
        Me.pnlNSPMain.Controls.Add(Me.rbCocaïne)
        Me.pnlNSPMain.Controls.Add(Me.rbSyntheticT)
        Me.pnlNSPMain.Location = New System.Drawing.Point(16, 46)
        Me.pnlNSPMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlNSPMain.Name = "pnlNSPMain"
        Me.pnlNSPMain.Size = New System.Drawing.Size(660, 150)
        Me.pnlNSPMain.TabIndex = 136
        '
        'lblCocaine
        '
        Me.lblCocaine.AutoSize = True
        Me.lblCocaine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCocaine.Location = New System.Drawing.Point(51, 110)
        Me.lblCocaine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCocaine.Name = "lblCocaine"
        Me.lblCocaine.Size = New System.Drawing.Size(76, 24)
        Me.lblCocaine.TabIndex = 146
        Me.lblCocaine.Text = "Cocaine"
        '
        'lblSyntheticT
        '
        Me.lblSyntheticT.AutoSize = True
        Me.lblSyntheticT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSyntheticT.Location = New System.Drawing.Point(51, 80)
        Me.lblSyntheticT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSyntheticT.Name = "lblSyntheticT"
        Me.lblSyntheticT.Size = New System.Drawing.Size(97, 24)
        Me.lblSyntheticT.TabIndex = 145
        Me.lblSyntheticT.Text = "SyntheticT"
        '
        'lblSyntheticP
        '
        Me.lblSyntheticP.AutoSize = True
        Me.lblSyntheticP.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSyntheticP.Location = New System.Drawing.Point(51, 50)
        Me.lblSyntheticP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSyntheticP.Name = "lblSyntheticP"
        Me.lblSyntheticP.Size = New System.Drawing.Size(98, 24)
        Me.lblSyntheticP.TabIndex = 144
        Me.lblSyntheticP.Text = "SyntheticP"
        '
        'lblCannabis
        '
        Me.lblCannabis.AutoSize = True
        Me.lblCannabis.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCannabis.Location = New System.Drawing.Point(51, 20)
        Me.lblCannabis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCannabis.Name = "lblCannabis"
        Me.lblCannabis.Size = New System.Drawing.Size(87, 24)
        Me.lblCannabis.TabIndex = 138
        Me.lblCannabis.Text = "Cannabis"
        '
        'btnSyntheticP
        '
        Me.btnSyntheticP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSyntheticP.FlatAppearance.BorderSize = 0
        Me.btnSyntheticP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSyntheticP.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnSyntheticP.IconColor = System.Drawing.Color.Black
        Me.btnSyntheticP.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSyntheticP.IconSize = 25
        Me.btnSyntheticP.Location = New System.Drawing.Point(11, 49)
        Me.btnSyntheticP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSyntheticP.Name = "btnSyntheticP"
        Me.btnSyntheticP.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnSyntheticP.Size = New System.Drawing.Size(25, 25)
        Me.btnSyntheticP.TabIndex = 143
        Me.btnSyntheticP.UseVisualStyleBackColor = True
        '
        'btnSyntheticT
        '
        Me.btnSyntheticT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSyntheticT.FlatAppearance.BorderSize = 0
        Me.btnSyntheticT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSyntheticT.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnSyntheticT.IconColor = System.Drawing.Color.Black
        Me.btnSyntheticT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSyntheticT.IconSize = 25
        Me.btnSyntheticT.Location = New System.Drawing.Point(11, 79)
        Me.btnSyntheticT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSyntheticT.Name = "btnSyntheticT"
        Me.btnSyntheticT.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnSyntheticT.Size = New System.Drawing.Size(25, 25)
        Me.btnSyntheticT.TabIndex = 142
        Me.btnSyntheticT.UseVisualStyleBackColor = True
        '
        'btnCocaine
        '
        Me.btnCocaine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCocaine.FlatAppearance.BorderSize = 0
        Me.btnCocaine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCocaine.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnCocaine.IconColor = System.Drawing.Color.Black
        Me.btnCocaine.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCocaine.IconSize = 25
        Me.btnCocaine.Location = New System.Drawing.Point(11, 108)
        Me.btnCocaine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCocaine.Name = "btnCocaine"
        Me.btnCocaine.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnCocaine.Size = New System.Drawing.Size(25, 25)
        Me.btnCocaine.TabIndex = 141
        Me.btnCocaine.UseVisualStyleBackColor = True
        '
        'btnCannabis
        '
        Me.btnCannabis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCannabis.FlatAppearance.BorderSize = 0
        Me.btnCannabis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCannabis.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnCannabis.IconColor = System.Drawing.Color.Black
        Me.btnCannabis.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCannabis.IconSize = 25
        Me.btnCannabis.Location = New System.Drawing.Point(11, 18)
        Me.btnCannabis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCannabis.Name = "btnCannabis"
        Me.btnCannabis.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnCannabis.Size = New System.Drawing.Size(25, 25)
        Me.btnCannabis.TabIndex = 138
        Me.btnCannabis.UseVisualStyleBackColor = True
        '
        'pnlProactiveMain
        '
        Me.pnlProactiveMain.Controls.Add(Me.txtProactiveDate)
        Me.pnlProactiveMain.Controls.Add(Me.lblProactive)
        Me.pnlProactiveMain.Controls.Add(Me.btnProactive)
        Me.pnlProactiveMain.Controls.Add(Me.lblProactiveDate)
        Me.pnlProactiveMain.Controls.Add(Me.chkProactive)
        Me.pnlProactiveMain.Location = New System.Drawing.Point(19, 47)
        Me.pnlProactiveMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlProactiveMain.Name = "pnlProactiveMain"
        Me.pnlProactiveMain.Size = New System.Drawing.Size(660, 150)
        Me.pnlProactiveMain.TabIndex = 147
        '
        'txtProactiveDate
        '
        Me.txtProactiveDate.CalendarFont = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProactiveDate.CustomFormat = " dd/MM/yyyy"
        Me.txtProactiveDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CASESBindingSource, "PROACTIVE DATE", True))
        Me.txtProactiveDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProactiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtProactiveDate.Location = New System.Drawing.Point(56, 64)
        Me.txtProactiveDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProactiveDate.Name = "txtProactiveDate"
        Me.txtProactiveDate.Size = New System.Drawing.Size(232, 32)
        Me.txtProactiveDate.TabIndex = 143
        '
        'lblProactive
        '
        Me.lblProactive.AutoSize = True
        Me.lblProactive.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProactive.Location = New System.Drawing.Point(51, 25)
        Me.lblProactive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProactive.Name = "lblProactive"
        Me.lblProactive.Size = New System.Drawing.Size(88, 24)
        Me.lblProactive.TabIndex = 147
        Me.lblProactive.Text = "Proactive"
        '
        'btnProactive
        '
        Me.btnProactive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProactive.FlatAppearance.BorderSize = 0
        Me.btnProactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProactive.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnProactive.IconColor = System.Drawing.Color.Black
        Me.btnProactive.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProactive.IconSize = 25
        Me.btnProactive.Location = New System.Drawing.Point(13, 23)
        Me.btnProactive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProactive.Name = "btnProactive"
        Me.btnProactive.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnProactive.Size = New System.Drawing.Size(25, 25)
        Me.btnProactive.TabIndex = 147
        Me.btnProactive.UseVisualStyleBackColor = True
        '
        'pnlInvestigationMain
        '
        Me.pnlInvestigationMain.Controls.Add(Me.txtInvestigationDate)
        Me.pnlInvestigationMain.Controls.Add(Me.lblInvestigationDate)
        Me.pnlInvestigationMain.Controls.Add(Me.chkInvestigation)
        Me.pnlInvestigationMain.Controls.Add(Me.lblInvestigationMagistrate)
        Me.pnlInvestigationMain.Controls.Add(Me.lblInvestigation)
        Me.pnlInvestigationMain.Controls.Add(Me.txtInvestigationMagistrate)
        Me.pnlInvestigationMain.Controls.Add(Me.btnInvestigation)
        Me.pnlInvestigationMain.Location = New System.Drawing.Point(19, 47)
        Me.pnlInvestigationMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlInvestigationMain.Name = "pnlInvestigationMain"
        Me.pnlInvestigationMain.Size = New System.Drawing.Size(660, 150)
        Me.pnlInvestigationMain.TabIndex = 148
        '
        'txtInvestigationDate
        '
        Me.txtInvestigationDate.CalendarFont = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvestigationDate.CustomFormat = " dd/MM/yyyy"
        Me.txtInvestigationDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CASESBindingSource, "INVESTIGATION DATE", True))
        Me.txtInvestigationDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvestigationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtInvestigationDate.Location = New System.Drawing.Point(120, 64)
        Me.txtInvestigationDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInvestigationDate.Name = "txtInvestigationDate"
        Me.txtInvestigationDate.Size = New System.Drawing.Size(232, 32)
        Me.txtInvestigationDate.TabIndex = 143
        '
        'lblInvestigation
        '
        Me.lblInvestigation.AutoSize = True
        Me.lblInvestigation.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestigation.Location = New System.Drawing.Point(51, 25)
        Me.lblInvestigation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInvestigation.Name = "lblInvestigation"
        Me.lblInvestigation.Size = New System.Drawing.Size(118, 24)
        Me.lblInvestigation.TabIndex = 147
        Me.lblInvestigation.Text = "Investigation"
        '
        'btnInvestigation
        '
        Me.btnInvestigation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInvestigation.FlatAppearance.BorderSize = 0
        Me.btnInvestigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInvestigation.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnInvestigation.IconColor = System.Drawing.Color.Black
        Me.btnInvestigation.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInvestigation.IconSize = 25
        Me.btnInvestigation.Location = New System.Drawing.Point(13, 23)
        Me.btnInvestigation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInvestigation.Name = "btnInvestigation"
        Me.btnInvestigation.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnInvestigation.Size = New System.Drawing.Size(25, 25)
        Me.btnInvestigation.TabIndex = 147
        Me.btnInvestigation.UseVisualStyleBackColor = True
        '
        'lblNSPTitle
        '
        Me.lblNSPTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNSPTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNSPTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNSPTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblNSPTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNSPTitle.Name = "lblNSPTitle"
        Me.lblNSPTitle.Size = New System.Drawing.Size(51, 25)
        Me.lblNSPTitle.TabIndex = 140
        Me.lblNSPTitle.Text = "NSP"
        Me.lblNSPTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProactiveTitle
        '
        Me.lblProactiveTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblProactiveTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProactiveTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProactiveTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblProactiveTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProactiveTitle.Name = "lblProactiveTitle"
        Me.lblProactiveTitle.Size = New System.Drawing.Size(100, 25)
        Me.lblProactiveTitle.TabIndex = 141
        Me.lblProactiveTitle.Text = "Proactive"
        Me.lblProactiveTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInvestigationTitle
        '
        Me.lblInvestigationTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInvestigationTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblInvestigationTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestigationTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblInvestigationTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInvestigationTitle.Name = "lblInvestigationTitle"
        Me.lblInvestigationTitle.Size = New System.Drawing.Size(149, 25)
        Me.lblInvestigationTitle.TabIndex = 142
        Me.lblInvestigationTitle.Text = "Investigation"
        Me.lblInvestigationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJudInvestigationTitle
        '
        Me.lblJudInvestigationTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblJudInvestigationTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblJudInvestigationTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudInvestigationTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblJudInvestigationTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJudInvestigationTitle.Name = "lblJudInvestigationTitle"
        Me.lblJudInvestigationTitle.Size = New System.Drawing.Size(171, 25)
        Me.lblJudInvestigationTitle.TabIndex = 143
        Me.lblJudInvestigationTitle.Text = "Jud. Investigation"
        Me.lblJudInvestigationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFederalizedTitle
        '
        Me.lblFederalizedTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFederalizedTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFederalizedTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalizedTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblFederalizedTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFederalizedTitle.Name = "lblFederalizedTitle"
        Me.lblFederalizedTitle.Size = New System.Drawing.Size(149, 25)
        Me.lblFederalizedTitle.TabIndex = 144
        Me.lblFederalizedTitle.Text = "Federalized"
        Me.lblFederalizedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlNSPTitle
        '
        Me.pnlNSPTitle.Controls.Add(Me.lblNSPTitle)
        Me.pnlNSPTitle.Location = New System.Drawing.Point(16, 16)
        Me.pnlNSPTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlNSPTitle.Name = "pnlNSPTitle"
        Me.pnlNSPTitle.Size = New System.Drawing.Size(51, 27)
        Me.pnlNSPTitle.TabIndex = 137
        '
        'pnlProactiveTitle
        '
        Me.pnlProactiveTitle.Controls.Add(Me.lblProactiveTitle)
        Me.pnlProactiveTitle.Location = New System.Drawing.Point(76, 16)
        Me.pnlProactiveTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlProactiveTitle.Name = "pnlProactiveTitle"
        Me.pnlProactiveTitle.Size = New System.Drawing.Size(100, 27)
        Me.pnlProactiveTitle.TabIndex = 138
        '
        'pnlInvestigationTitle
        '
        Me.pnlInvestigationTitle.Controls.Add(Me.lblInvestigationTitle)
        Me.pnlInvestigationTitle.Location = New System.Drawing.Point(187, 16)
        Me.pnlInvestigationTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlInvestigationTitle.Name = "pnlInvestigationTitle"
        Me.pnlInvestigationTitle.Size = New System.Drawing.Size(149, 27)
        Me.pnlInvestigationTitle.TabIndex = 138
        '
        'pnlJudInvestigationTitle
        '
        Me.pnlJudInvestigationTitle.Controls.Add(Me.lblJudInvestigationTitle)
        Me.pnlJudInvestigationTitle.Location = New System.Drawing.Point(347, 16)
        Me.pnlJudInvestigationTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlJudInvestigationTitle.Name = "pnlJudInvestigationTitle"
        Me.pnlJudInvestigationTitle.Size = New System.Drawing.Size(171, 27)
        Me.pnlJudInvestigationTitle.TabIndex = 138
        '
        'pnlFederalizedTitle
        '
        Me.pnlFederalizedTitle.Controls.Add(Me.lblFederalizedTitle)
        Me.pnlFederalizedTitle.Location = New System.Drawing.Point(525, 16)
        Me.pnlFederalizedTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlFederalizedTitle.Name = "pnlFederalizedTitle"
        Me.pnlFederalizedTitle.Size = New System.Drawing.Size(149, 27)
        Me.pnlFederalizedTitle.TabIndex = 138
        '
        'pnlJudInvestigationMain
        '
        Me.pnlJudInvestigationMain.Controls.Add(Me.txtJudInvestigationDate)
        Me.pnlJudInvestigationMain.Controls.Add(Me.lblJudInvestigationDate)
        Me.pnlJudInvestigationMain.Controls.Add(Me.txtJudInvestigationMagistrate)
        Me.pnlJudInvestigationMain.Controls.Add(Me.lblJudInvestigationMagistrate)
        Me.pnlJudInvestigationMain.Controls.Add(Me.chkJudInvestigation)
        Me.pnlJudInvestigationMain.Controls.Add(Me.lblJudInvestigation)
        Me.pnlJudInvestigationMain.Controls.Add(Me.btnJudInvestigation)
        Me.pnlJudInvestigationMain.Location = New System.Drawing.Point(19, 47)
        Me.pnlJudInvestigationMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlJudInvestigationMain.Name = "pnlJudInvestigationMain"
        Me.pnlJudInvestigationMain.Size = New System.Drawing.Size(660, 150)
        Me.pnlJudInvestigationMain.TabIndex = 149
        '
        'txtJudInvestigationDate
        '
        Me.txtJudInvestigationDate.CalendarFont = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJudInvestigationDate.CustomFormat = " dd/MM/yyyy"
        Me.txtJudInvestigationDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CASESBindingSource, "JUD INVESTIGATION DATE", True))
        Me.txtJudInvestigationDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJudInvestigationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtJudInvestigationDate.Location = New System.Drawing.Point(120, 64)
        Me.txtJudInvestigationDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtJudInvestigationDate.Name = "txtJudInvestigationDate"
        Me.txtJudInvestigationDate.Size = New System.Drawing.Size(232, 32)
        Me.txtJudInvestigationDate.TabIndex = 143
        '
        'lblJudInvestigation
        '
        Me.lblJudInvestigation.AutoSize = True
        Me.lblJudInvestigation.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudInvestigation.Location = New System.Drawing.Point(51, 25)
        Me.lblJudInvestigation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJudInvestigation.Name = "lblJudInvestigation"
        Me.lblJudInvestigation.Size = New System.Drawing.Size(147, 24)
        Me.lblJudInvestigation.TabIndex = 147
        Me.lblJudInvestigation.Text = "JudInvestigation"
        '
        'btnJudInvestigation
        '
        Me.btnJudInvestigation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJudInvestigation.FlatAppearance.BorderSize = 0
        Me.btnJudInvestigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJudInvestigation.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnJudInvestigation.IconColor = System.Drawing.Color.Black
        Me.btnJudInvestigation.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnJudInvestigation.IconSize = 25
        Me.btnJudInvestigation.Location = New System.Drawing.Point(13, 23)
        Me.btnJudInvestigation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJudInvestigation.Name = "btnJudInvestigation"
        Me.btnJudInvestigation.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnJudInvestigation.Size = New System.Drawing.Size(25, 25)
        Me.btnJudInvestigation.TabIndex = 147
        Me.btnJudInvestigation.UseVisualStyleBackColor = True
        '
        'pnlFederalizedMain
        '
        Me.pnlFederalizedMain.Controls.Add(Me.txtFederalizedDate)
        Me.pnlFederalizedMain.Controls.Add(Me.txtFederalizedMagistrate)
        Me.pnlFederalizedMain.Controls.Add(Me.lblFederalizedMagistrate)
        Me.pnlFederalizedMain.Controls.Add(Me.chkFederalized)
        Me.pnlFederalizedMain.Controls.Add(Me.lblFederalizedDate)
        Me.pnlFederalizedMain.Controls.Add(Me.lblFederalized)
        Me.pnlFederalizedMain.Controls.Add(Me.btnFederalized)
        Me.pnlFederalizedMain.Location = New System.Drawing.Point(19, 47)
        Me.pnlFederalizedMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlFederalizedMain.Name = "pnlFederalizedMain"
        Me.pnlFederalizedMain.Size = New System.Drawing.Size(660, 150)
        Me.pnlFederalizedMain.TabIndex = 150
        '
        'txtFederalizedDate
        '
        Me.txtFederalizedDate.CalendarFont = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFederalizedDate.CustomFormat = " dd/MM/yyyy"
        Me.txtFederalizedDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CASESBindingSource, "FEDERALIZED DATE", True))
        Me.txtFederalizedDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFederalizedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFederalizedDate.Location = New System.Drawing.Point(120, 64)
        Me.txtFederalizedDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFederalizedDate.Name = "txtFederalizedDate"
        Me.txtFederalizedDate.Size = New System.Drawing.Size(232, 32)
        Me.txtFederalizedDate.TabIndex = 143
        '
        'lblFederalized
        '
        Me.lblFederalized.AutoSize = True
        Me.lblFederalized.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalized.Location = New System.Drawing.Point(51, 25)
        Me.lblFederalized.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFederalized.Name = "lblFederalized"
        Me.lblFederalized.Size = New System.Drawing.Size(106, 24)
        Me.lblFederalized.TabIndex = 147
        Me.lblFederalized.Text = "Federalized"
        '
        'btnFederalized
        '
        Me.btnFederalized.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFederalized.FlatAppearance.BorderSize = 0
        Me.btnFederalized.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFederalized.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnFederalized.IconColor = System.Drawing.Color.Black
        Me.btnFederalized.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFederalized.IconSize = 25
        Me.btnFederalized.Location = New System.Drawing.Point(13, 23)
        Me.btnFederalized.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFederalized.Name = "btnFederalized"
        Me.btnFederalized.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnFederalized.Size = New System.Drawing.Size(25, 25)
        Me.btnFederalized.TabIndex = 147
        Me.btnFederalized.UseVisualStyleBackColor = True
        '
        'pnlCenter
        '
        Me.pnlCenter.Controls.Add(Me.pnlDetails)
        Me.pnlCenter.Controls.Add(Me.pnlTab)
        Me.pnlCenter.Controls.Add(Me.pnlSummary)
        Me.pnlCenter.Controls.Add(Me.pnlSiena)
        Me.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCenter.Location = New System.Drawing.Point(131, 130)
        Me.pnlCenter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlCenter.Name = "pnlCenter"
        Me.pnlCenter.Size = New System.Drawing.Size(1070, 722)
        Me.pnlCenter.TabIndex = 153
        '
        'pnlDetails
        '
        Me.pnlDetails.Controls.Add(Me.txtDate)
        Me.pnlDetails.Controls.Add(Me.txtCaseName)
        Me.pnlDetails.Controls.Add(Me.cmbUnit)
        Me.pnlDetails.Controls.Add(Me.btnBOM)
        Me.pnlDetails.Controls.Add(Me.lblCaseName)
        Me.pnlDetails.Controls.Add(Me.chkBom)
        Me.pnlDetails.Controls.Add(Me.lblCMInt)
        Me.pnlDetails.Controls.Add(Me.chkEmbargo)
        Me.pnlDetails.Controls.Add(Me.lblLang)
        Me.pnlDetails.Controls.Add(Me.btnEmbargo)
        Me.pnlDetails.Controls.Add(Me.lblUnit)
        Me.pnlDetails.Controls.Add(Me.lblBOM)
        Me.pnlDetails.Controls.Add(Me.cmbSupport)
        Me.pnlDetails.Controls.Add(Me.lblTypeOfCase)
        Me.pnlDetails.Controls.Add(Me.lblEmbargo)
        Me.pnlDetails.Controls.Add(Me.lblReportNum)
        Me.pnlDetails.Controls.Add(Me.cmbOrigin)
        Me.pnlDetails.Controls.Add(Me.lblSupport)
        Me.pnlDetails.Controls.Add(Me.lblFileNum)
        Me.pnlDetails.Controls.Add(Me.txtCMExt2)
        Me.pnlDetails.Controls.Add(Me.lblDate)
        Me.pnlDetails.Controls.Add(Me.txtCMExt1)
        Me.pnlDetails.Controls.Add(Me.cmbLang)
        Me.pnlDetails.Controls.Add(Me.lblRioNum)
        Me.pnlDetails.Controls.Add(Me.lblCMExt)
        Me.pnlDetails.Controls.Add(Me.txtReportNum)
        Me.pnlDetails.Controls.Add(Me.txtRioNum)
        Me.pnlDetails.Controls.Add(Me.cmbTypeOfCase)
        Me.pnlDetails.Controls.Add(Me.txtOnNum)
        Me.pnlDetails.Controls.Add(Me.txtFileNum)
        Me.pnlDetails.Controls.Add(Me.lblOrigin)
        Me.pnlDetails.Controls.Add(Me.lblOnNum)
        Me.pnlDetails.Controls.Add(Me.cmbCMInt)
        Me.pnlDetails.Location = New System.Drawing.Point(24, 25)
        Me.pnlDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(1024, 345)
        Me.pnlDetails.TabIndex = 153
        '
        'txtDate
        '
        Me.txtDate.CalendarFont = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.CustomFormat = " dd/MM/yyyy"
        Me.txtDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CASESBindingSource, "DATE FACTS", True))
        Me.txtDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate.Location = New System.Drawing.Point(181, 135)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(305, 32)
        Me.txtDate.TabIndex = 16
        '
        'lblCaseName
        '
        Me.lblCaseName.AutoSize = True
        Me.lblCaseName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaseName.Location = New System.Drawing.Point(16, 22)
        Me.lblCaseName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaseName.Name = "lblCaseName"
        Me.lblCaseName.Size = New System.Drawing.Size(103, 24)
        Me.lblCaseName.TabIndex = 13
        Me.lblCaseName.Tag = "casename"
        Me.lblCaseName.Text = "Case Name"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(16, 60)
        Me.lblUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(46, 24)
        Me.lblUnit.TabIndex = 19
        Me.lblUnit.Tag = "unit"
        Me.lblUnit.Text = "Unit"
        '
        'lblTypeOfCase
        '
        Me.lblTypeOfCase.AutoSize = True
        Me.lblTypeOfCase.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeOfCase.Location = New System.Drawing.Point(16, 100)
        Me.lblTypeOfCase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTypeOfCase.Name = "lblTypeOfCase"
        Me.lblTypeOfCase.Size = New System.Drawing.Size(118, 24)
        Me.lblTypeOfCase.TabIndex = 20
        Me.lblTypeOfCase.Tag = "typeofcase"
        Me.lblTypeOfCase.Text = "Type Of Case"
        '
        'pnlTab
        '
        Me.pnlTab.Controls.Add(Me.pnlNSPTitle)
        Me.pnlTab.Controls.Add(Me.pnlProactiveMain)
        Me.pnlTab.Controls.Add(Me.pnlInvestigationMain)
        Me.pnlTab.Controls.Add(Me.pnlFederalizedMain)
        Me.pnlTab.Controls.Add(Me.pnlJudInvestigationMain)
        Me.pnlTab.Controls.Add(Me.pnlNSPMain)
        Me.pnlTab.Controls.Add(Me.pnlFederalizedTitle)
        Me.pnlTab.Controls.Add(Me.pnlJudInvestigationTitle)
        Me.pnlTab.Controls.Add(Me.pnlProactiveTitle)
        Me.pnlTab.Controls.Add(Me.pnlInvestigationTitle)
        Me.pnlTab.Location = New System.Drawing.Point(24, 512)
        Me.pnlTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTab.Name = "pnlTab"
        Me.pnlTab.Size = New System.Drawing.Size(688, 208)
        Me.pnlTab.TabIndex = 156
        '
        'pnlSummary
        '
        Me.pnlSummary.Controls.Add(Me.txtSummary)
        Me.pnlSummary.Location = New System.Drawing.Point(736, 391)
        Me.pnlSummary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSummary.Name = "pnlSummary"
        Me.pnlSummary.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlSummary.Size = New System.Drawing.Size(312, 327)
        Me.pnlSummary.TabIndex = 155
        '
        'pnlSiena
        '
        Me.pnlSiena.Controls.Add(Me.txtSienaPicturesDate)
        Me.pnlSiena.Controls.Add(Me.txtSienaDate)
        Me.pnlSiena.Controls.Add(Me.lblon2)
        Me.pnlSiena.Controls.Add(Me.lblSienaNum)
        Me.pnlSiena.Controls.Add(Me.lblon1)
        Me.pnlSiena.Controls.Add(Me.chkSienaPictures)
        Me.pnlSiena.Controls.Add(Me.lblSienaPictures)
        Me.pnlSiena.Controls.Add(Me.txtSienaNum)
        Me.pnlSiena.Controls.Add(Me.btnSienaPictures)
        Me.pnlSiena.Location = New System.Drawing.Point(24, 391)
        Me.pnlSiena.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSiena.Name = "pnlSiena"
        Me.pnlSiena.Size = New System.Drawing.Size(688, 100)
        Me.pnlSiena.TabIndex = 154
        '
        'txtSienaPicturesDate
        '
        Me.txtSienaPicturesDate.CalendarFont = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSienaPicturesDate.CustomFormat = " dd/MM/yyyy"
        Me.txtSienaPicturesDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CASESBindingSource, "SIENA PICTURES DATE", True))
        Me.txtSienaPicturesDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSienaPicturesDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtSienaPicturesDate.Location = New System.Drawing.Point(456, 57)
        Me.txtSienaPicturesDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSienaPicturesDate.Name = "txtSienaPicturesDate"
        Me.txtSienaPicturesDate.Size = New System.Drawing.Size(216, 32)
        Me.txtSienaPicturesDate.TabIndex = 142
        '
        'txtSienaDate
        '
        Me.txtSienaDate.CalendarFont = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSienaDate.CustomFormat = " dd/MM/yyyy"
        Me.txtSienaDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CASESBindingSource, "SIENA REPORT DATE", True))
        Me.txtSienaDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSienaDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtSienaDate.Location = New System.Drawing.Point(456, 16)
        Me.txtSienaDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSienaDate.Name = "txtSienaDate"
        Me.txtSienaDate.Size = New System.Drawing.Size(216, 32)
        Me.txtSienaDate.TabIndex = 138
        '
        'fsw
        '
        Me.fsw.EnableRaisingEvents = True
        Me.fsw.Filter = "*.dat"
        Me.fsw.Path = "G:\DJSOC\DRUGS\CRU\DORA\SYSTEM"
        Me.fsw.SynchronizingObject = Me
        '
        'frmCases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 852)
        Me.Controls.Add(Me.pnlCenter)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.picMin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1219, 899)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1219, 899)
        Me.Name = "frmCases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POLICE_UNITSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.imgCRU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlNSPMain.ResumeLayout(False)
        Me.pnlNSPMain.PerformLayout()
        Me.pnlProactiveMain.ResumeLayout(False)
        Me.pnlProactiveMain.PerformLayout()
        Me.pnlInvestigationMain.ResumeLayout(False)
        Me.pnlInvestigationMain.PerformLayout()
        Me.pnlNSPTitle.ResumeLayout(False)
        Me.pnlProactiveTitle.ResumeLayout(False)
        Me.pnlInvestigationTitle.ResumeLayout(False)
        Me.pnlJudInvestigationTitle.ResumeLayout(False)
        Me.pnlFederalizedTitle.ResumeLayout(False)
        Me.pnlJudInvestigationMain.ResumeLayout(False)
        Me.pnlJudInvestigationMain.PerformLayout()
        Me.pnlFederalizedMain.ResumeLayout(False)
        Me.pnlFederalizedMain.PerformLayout()
        Me.pnlCenter.ResumeLayout(False)
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.pnlTab.ResumeLayout(False)
        Me.pnlSummary.ResumeLayout(False)
        Me.pnlSummary.PerformLayout()
        Me.pnlSiena.ResumeLayout(False)
        Me.pnlSiena.PerformLayout()
        CType(Me.fsw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DORADbDS As DORADbDS
    Friend WithEvents CASESBindingSource As BindingSource
    Friend WithEvents CASESTableAdapter As DORADbDSTableAdapters.CASESTableAdapter
    Friend WithEvents TableAdapterManager As DORADbDSTableAdapters.TableAdapterManager
    Friend WithEvents INTERVENTIONSBindingSource As BindingSource
    Friend WithEvents INTERVENTIONSTableAdapter As DORADbDSTableAdapters.INTERVENTIONSTableAdapter
    Friend WithEvents txtCaseName As TextBox
    Friend WithEvents cmbTypeOfCase As ComboBox
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents POLICE_UNITSBindingSource As BindingSource
    Friend WithEvents POLICE_UNITSTableAdapter As DORADbDSTableAdapters.POLICE_UNITSTableAdapter
    Friend WithEvents cmbCMInt As ComboBox
    Friend WithEvents txtFileNum As TextBox
    Friend WithEvents cmbLang As ComboBox
    Friend WithEvents txtReportNum As MaskedTextBox
    Friend WithEvents lblReportNum As Label
    Friend WithEvents lblFileNum As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblLang As Label
    Friend WithEvents lblCMInt As Label
    Friend WithEvents lblCMExt As Label
    Friend WithEvents txtCMExt1 As TextBox
    Friend WithEvents txtCMExt2 As TextBox
    Friend WithEvents txtOnNum As TextBox
    Friend WithEvents txtRioNum As TextBox
    Friend WithEvents cmbOrigin As ComboBox
    Friend WithEvents cmbSupport As ComboBox
    Friend WithEvents chkFederalized As CheckBox
    Friend WithEvents chkJudInvestigation As CheckBox
    Friend WithEvents chkInvestigation As CheckBox
    Friend WithEvents chkProactive As CheckBox
    Friend WithEvents txtInvestigationMagistrate As TextBox
    Friend WithEvents txtJudInvestigationMagistrate As TextBox
    Friend WithEvents txtFederalizedMagistrate As TextBox
    Friend WithEvents lblRioNum As Label
    Friend WithEvents lblOnNum As Label
    Friend WithEvents lblSupport As Label
    Friend WithEvents lblOrigin As Label
    Friend WithEvents lblProactiveDate As Label
    Friend WithEvents lblInvestigationDate As Label
    Friend WithEvents lblInvestigationMagistrate As Label
    Friend WithEvents lblJudInvestigationDate As Label
    Friend WithEvents lblJudInvestigationMagistrate As Label
    Friend WithEvents lblFederalizedDate As Label
    Friend WithEvents lblFederalizedMagistrate As Label
    Friend WithEvents txtSummary As TextBox
    Friend WithEvents chkBom As CheckBox
    Friend WithEvents chkEmbargo As CheckBox
    Friend WithEvents chkSienaPictures As CheckBox
    Friend WithEvents txtSienaNum As TextBox
    Friend WithEvents lblSienaNum As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents picMin As PictureBox
    Friend WithEvents cmbNSP As ComboBox
    Friend WithEvents rbCocaïne As RadioButton
    Friend WithEvents rbCannabis As RadioButton
    Friend WithEvents rbSyntheticT As RadioButton
    Friend WithEvents rbSyntheticP As RadioButton
    Friend WithEvents rbFake As RadioButton
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents imgCRU As PictureBox
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents pnlControls As Panel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMin As FontAwesome.Sharp.IconButton
    Friend WithEvents lblBOM As Label
    Friend WithEvents lblEmbargo As Label
    Friend WithEvents btnBOM As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEmbargo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSienaPictures As FontAwesome.Sharp.IconButton
    Friend WithEvents lblSienaPictures As Label
    Friend WithEvents pnlNSPMain As Panel
    Friend WithEvents pnlFederalizedTitle As Panel
    Friend WithEvents lblFederalizedTitle As Label
    Friend WithEvents pnlJudInvestigationTitle As Panel
    Friend WithEvents lblJudInvestigationTitle As Label
    Friend WithEvents pnlInvestigationTitle As Panel
    Friend WithEvents lblInvestigationTitle As Label
    Friend WithEvents pnlProactiveTitle As Panel
    Friend WithEvents lblProactiveTitle As Label
    Friend WithEvents pnlNSPTitle As Panel
    Friend WithEvents lblNSPTitle As Label
    Friend WithEvents lblon2 As Label
    Friend WithEvents lblon1 As Label
    Friend WithEvents lblCocaine As Label
    Friend WithEvents lblSyntheticT As Label
    Friend WithEvents lblSyntheticP As Label
    Friend WithEvents lblCannabis As Label
    Friend WithEvents btnSyntheticP As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSyntheticT As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCocaine As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCannabis As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlProactiveMain As Panel
    Friend WithEvents lblProactive As Label
    Friend WithEvents btnProactive As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlInvestigationMain As Panel
    Friend WithEvents lblInvestigation As Label
    Friend WithEvents btnInvestigation As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlFederalizedMain As Panel
    Friend WithEvents lblFederalized As Label
    Friend WithEvents btnFederalized As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlJudInvestigationMain As Panel
    Friend WithEvents lblJudInvestigation As Label
    Friend WithEvents btnJudInvestigation As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFolder As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlCenter As Panel
    Friend WithEvents fsw As IO.FileSystemWatcher
    Friend WithEvents pnlDetails As Panel
    Friend WithEvents lblCaseName As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents lblTypeOfCase As Label
    Friend WithEvents pnlTab As Panel
    Friend WithEvents pnlSummary As Panel
    Friend WithEvents pnlSiena As Panel
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtJudInvestigationDate As DateTimePicker
    Friend WithEvents txtProactiveDate As DateTimePicker
    Friend WithEvents txtFederalizedDate As DateTimePicker
    Friend WithEvents txtInvestigationDate As DateTimePicker
    Friend WithEvents txtSienaPicturesDate As DateTimePicker
    Friend WithEvents txtSienaDate As DateTimePicker
End Class
