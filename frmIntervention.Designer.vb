<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIntervention
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntervention))
        Me.lblSamplesNum = New System.Windows.Forms.Label()
        Me.lblSamplesTaken = New System.Windows.Forms.Label()
        Me.INTERVENTIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DORADbDS = New DORA.DORADbDS()
        Me.INTERVENTIONSTableAdapter = New DORA.DORADbDSTableAdapters.INTERVENTIONSTableAdapter()
        Me.TableAdapterManager = New DORA.DORADbDSTableAdapters.TableAdapterManager()
        Me.txtAdressInt = New System.Windows.Forms.TextBox()
        Me.cmbCityInt = New System.Windows.Forms.ComboBox()
        Me.txtDateInt = New System.Windows.Forms.DateTimePicker()
        Me.txtDateFacts = New System.Windows.Forms.DateTimePicker()
        Me.cmbCityFacts = New System.Windows.Forms.ComboBox()
        Me.txtAdressFacts = New System.Windows.Forms.TextBox()
        Me.cmbInt = New System.Windows.Forms.ComboBox()
        Me.cmbTypeOfPlace = New System.Windows.Forms.ComboBox()
        Me.cmbTypeOfInt = New System.Windows.Forms.ComboBox()
        Me.chkInventory = New System.Windows.Forms.CheckBox()
        Me.chkPicturesReport = New System.Windows.Forms.CheckBox()
        Me.chkNICCReport = New System.Windows.Forms.CheckBox()
        Me.chkCRUReport = New System.Windows.Forms.CheckBox()
        Me.txtCRUReportDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbSamplesTakenBy = New System.Windows.Forms.ComboBox()
        Me.txtSamplesNum = New System.Windows.Forms.TextBox()
        Me.MEMBERS_INTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEMBERS_INTTableAdapter = New DORA.DORADbDSTableAdapters.MEMBERS_INTTableAdapter()
        Me.txtCRUReportNum = New System.Windows.Forms.MaskedTextBox()
        Me.PRODUCTS_INTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTS_INTTableAdapter = New DORA.DORADbDSTableAdapters.PRODUCTS_INTTableAdapter()
        Me.dgvMembersInt = New System.Windows.Forms.DataGridView()
        Me.MEMBERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIMEINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvProductsInt = New System.Windows.Forms.DataGridView()
        Me.PRODUCTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbMemberName = New System.Windows.Forms.ComboBox()
        Me.MEMBERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtProductQuantity = New System.Windows.Forms.TextBox()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.PRODUCTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbProductUnit = New System.Windows.Forms.ComboBox()
        Me.PRODUCTSTableAdapter = New DORA.DORADbDSTableAdapters.PRODUCTSTableAdapter()
        Me.MEMBERSTableAdapter = New DORA.DORADbDSTableAdapters.MEMBERSTableAdapter()
        Me.txtMemberTimeIn = New System.Windows.Forms.MaskedTextBox()
        Me.txtDate1 = New System.Windows.Forms.DateTimePicker()
        Me.txtTime2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtDate2 = New System.Windows.Forms.DateTimePicker()
        Me.txtTime3 = New System.Windows.Forms.MaskedTextBox()
        Me.txtTime4 = New System.Windows.Forms.MaskedTextBox()
        Me.txtDate3 = New System.Windows.Forms.DateTimePicker()
        Me.txtTime5 = New System.Windows.Forms.MaskedTextBox()
        Me.txtTime6 = New System.Windows.Forms.MaskedTextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtSummary = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSamplesDate = New System.Windows.Forms.DateTimePicker()
        Me.lblTypeOfInt = New System.Windows.Forms.Label()
        Me.lblTypeOfPlace = New System.Windows.Forms.Label()
        Me.lblInt = New System.Windows.Forms.Label()
        Me.txtZipInt = New System.Windows.Forms.MaskedTextBox()
        Me.lblDateInt = New System.Windows.Forms.Label()
        Me.txtZipFacts = New System.Windows.Forms.MaskedTextBox()
        Me.lblDateFacts = New System.Windows.Forms.Label()
        Me.txtNICCReportNum = New System.Windows.Forms.MaskedTextBox()
        Me.chkIntervention = New System.Windows.Forms.CheckBox()
        Me.txtNICCReportDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSamplesCode = New System.Windows.Forms.Label()
        Me.txtSamplesCode = New System.Windows.Forms.TextBox()
        Me.lblSamplesDelivery = New System.Windows.Forms.Label()
        Me.lblNICCConc = New System.Windows.Forms.Label()
        Me.txtNICCConc = New System.Windows.Forms.TextBox()
        Me.txtTime1 = New System.Windows.Forms.MaskedTextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblProdCap = New System.Windows.Forms.Label()
        Me.txtProdCap = New System.Windows.Forms.TextBox()
        Me.cmbStep = New System.Windows.Forms.ComboBox()
        Me.cmbMethod = New System.Windows.Forms.ComboBox()
        Me.cmbDrug = New System.Windows.Forms.ComboBox()
        Me.dgvProd = New System.Windows.Forms.DataGridView()
        Me.DRUGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.METHODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STEPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRUGS_INTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DRUGS_INTTableAdapter = New DORA.DORADbDSTableAdapters.DRUGS_INTTableAdapter()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.RCMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CASESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CASESTableAdapter = New DORA.DORADbDSTableAdapters.CASESTableAdapter()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.btnNextCase = New FontAwesome.Sharp.IconButton()
        Me.btnPrevCase = New FontAwesome.Sharp.IconButton()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.btnMin = New FontAwesome.Sharp.IconButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnUnlock = New FontAwesome.Sharp.IconButton()
        Me.btnInv = New FontAwesome.Sharp.IconButton()
        Me.btnNICC = New FontAwesome.Sharp.IconButton()
        Me.btnIntReport = New FontAwesome.Sharp.IconButton()
        Me.btnFolder = New FontAwesome.Sharp.IconButton()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.imgCRU = New System.Windows.Forms.PictureBox()
        Me.pnlCenter = New System.Windows.Forms.Panel()
        Me.pnlDrug = New System.Windows.Forms.Panel()
        Me.btnDeleteDrug = New FontAwesome.Sharp.IconButton()
        Me.btnSaveDrug = New FontAwesome.Sharp.IconButton()
        Me.btnAddDrug = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearchProduct = New FontAwesome.Sharp.IconButton()
        Me.btnDeleteProduct = New FontAwesome.Sharp.IconButton()
        Me.btnSaveProduct = New FontAwesome.Sharp.IconButton()
        Me.btnAddProduct = New FontAwesome.Sharp.IconButton()
        Me.pnlMembers = New System.Windows.Forms.Panel()
        Me.btnDeleteMember = New FontAwesome.Sharp.IconButton()
        Me.btnSaveMember = New FontAwesome.Sharp.IconButton()
        Me.btnAddMember = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.pnlSamples = New System.Windows.Forms.Panel()
        Me.btnClearDateSamples = New FontAwesome.Sharp.IconButton()
        Me.pnlReports = New System.Windows.Forms.Panel()
        Me.btnClearDateNICC = New FontAwesome.Sharp.IconButton()
        Me.lblIntervention = New System.Windows.Forms.Label()
        Me.btnClearDateCRU = New FontAwesome.Sharp.IconButton()
        Me.lblPicturesReport = New System.Windows.Forms.Label()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.lblNICCReport = New System.Windows.Forms.Label()
        Me.lblCRUReport = New System.Windows.Forms.Label()
        Me.btnNICCReport = New FontAwesome.Sharp.IconButton()
        Me.btnIntervention = New FontAwesome.Sharp.IconButton()
        Me.btnPicturesReport = New FontAwesome.Sharp.IconButton()
        Me.btnInventory = New FontAwesome.Sharp.IconButton()
        Me.btnCRUReport = New FontAwesome.Sharp.IconButton()
        Me.pnlTime = New System.Windows.Forms.Panel()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.btnClearDate3 = New FontAwesome.Sharp.IconButton()
        Me.btnClearDate2 = New FontAwesome.Sharp.IconButton()
        Me.btnClearDate1 = New FontAwesome.Sharp.IconButton()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlIntervention = New System.Windows.Forms.Panel()
        Me.btnRemondis = New System.Windows.Forms.Button()
        Me.btnSGS = New System.Windows.Forms.Button()
        Me.btnIntToFacts = New FontAwesome.Sharp.IconButton()
        Me.pnlFacts = New System.Windows.Forms.Panel()
        Me.btnFactsToInt = New FontAwesome.Sharp.IconButton()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERS_INTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTS_INTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMembersInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductsInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DRUGS_INTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RCMenu.SuspendLayout()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        CType(Me.imgCRU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCenter.SuspendLayout()
        Me.pnlDrug.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlMembers.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlSummary.SuspendLayout()
        Me.pnlSamples.SuspendLayout()
        Me.pnlReports.SuspendLayout()
        Me.pnlTime.SuspendLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlIntervention.SuspendLayout()
        Me.pnlFacts.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSamplesNum
        '
        Me.lblSamplesNum.AutoSize = True
        Me.lblSamplesNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSamplesNum.Location = New System.Drawing.Point(16, 100)
        Me.lblSamplesNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSamplesNum.Name = "lblSamplesNum"
        Me.lblSamplesNum.Size = New System.Drawing.Size(78, 24)
        Me.lblSamplesNum.TabIndex = 53
        Me.lblSamplesNum.Text = "Number"
        '
        'lblSamplesTaken
        '
        Me.lblSamplesTaken.AutoSize = True
        Me.lblSamplesTaken.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSamplesTaken.Location = New System.Drawing.Point(16, 60)
        Me.lblSamplesTaken.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSamplesTaken.Name = "lblSamplesTaken"
        Me.lblSamplesTaken.Size = New System.Drawing.Size(83, 24)
        Me.lblSamplesTaken.TabIndex = 91
        Me.lblSamplesTaken.Text = "Taken by"
        '
        'INTERVENTIONSBindingSource
        '
        Me.INTERVENTIONSBindingSource.DataMember = "INTERVENTIONS"
        Me.INTERVENTIONSBindingSource.DataSource = Me.DORADbDS
        '
        'DORADbDS
        '
        Me.DORADbDS.DataSetName = "DORADbDS"
        Me.DORADbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INTERVENTIONSTableAdapter
        '
        Me.INTERVENTIONSTableAdapter.ClearBeforeFill = True
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
        'txtAdressInt
        '
        Me.txtAdressInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdressInt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "ADRESS INT", True))
        Me.txtAdressInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdressInt.Location = New System.Drawing.Point(21, 96)
        Me.txtAdressInt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdressInt.Name = "txtAdressInt"
        Me.txtAdressInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAdressInt.Size = New System.Drawing.Size(394, 32)
        Me.txtAdressInt.TabIndex = 3
        '
        'cmbCityInt
        '
        Me.cmbCityInt.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCityInt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "CITY INT", True))
        Me.cmbCityInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCityInt.FormattingEnabled = True
        Me.cmbCityInt.Location = New System.Drawing.Point(21, 57)
        Me.cmbCityInt.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCityInt.Name = "cmbCityInt"
        Me.cmbCityInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCityInt.Size = New System.Drawing.Size(329, 32)
        Me.cmbCityInt.TabIndex = 1
        '
        'txtDateInt
        '
        Me.txtDateInt.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INTERVENTIONSBindingSource, "DATE INT", True))
        Me.txtDateInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateInt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateInt.Location = New System.Drawing.Point(256, 16)
        Me.txtDateInt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateInt.Name = "txtDateInt"
        Me.txtDateInt.Size = New System.Drawing.Size(160, 32)
        Me.txtDateInt.TabIndex = 0
        '
        'txtDateFacts
        '
        Me.txtDateFacts.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INTERVENTIONSBindingSource, "DATE FACTS", True))
        Me.txtDateFacts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFacts.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateFacts.Location = New System.Drawing.Point(256, 16)
        Me.txtDateFacts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateFacts.Name = "txtDateFacts"
        Me.txtDateFacts.Size = New System.Drawing.Size(160, 32)
        Me.txtDateFacts.TabIndex = 0
        '
        'cmbCityFacts
        '
        Me.cmbCityFacts.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCityFacts.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "CITY FACTS", True))
        Me.cmbCityFacts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCityFacts.FormattingEnabled = True
        Me.cmbCityFacts.Location = New System.Drawing.Point(21, 57)
        Me.cmbCityFacts.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCityFacts.Name = "cmbCityFacts"
        Me.cmbCityFacts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCityFacts.Size = New System.Drawing.Size(329, 32)
        Me.cmbCityFacts.TabIndex = 1
        '
        'txtAdressFacts
        '
        Me.txtAdressFacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdressFacts.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "ADRESS FACTS", True))
        Me.txtAdressFacts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdressFacts.Location = New System.Drawing.Point(21, 96)
        Me.txtAdressFacts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdressFacts.Name = "txtAdressFacts"
        Me.txtAdressFacts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAdressFacts.Size = New System.Drawing.Size(394, 32)
        Me.txtAdressFacts.TabIndex = 3
        '
        'cmbInt
        '
        Me.cmbInt.BackColor = System.Drawing.SystemColors.Window
        Me.cmbInt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "INTPL", True))
        Me.cmbInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInt.FormattingEnabled = True
        Me.cmbInt.Location = New System.Drawing.Point(208, 96)
        Me.cmbInt.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbInt.Name = "cmbInt"
        Me.cmbInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbInt.Size = New System.Drawing.Size(208, 32)
        Me.cmbInt.TabIndex = 2
        '
        'cmbTypeOfPlace
        '
        Me.cmbTypeOfPlace.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTypeOfPlace.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "TYPE OF PLACE", True))
        Me.cmbTypeOfPlace.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypeOfPlace.FormattingEnabled = True
        Me.cmbTypeOfPlace.Location = New System.Drawing.Point(208, 57)
        Me.cmbTypeOfPlace.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTypeOfPlace.Name = "cmbTypeOfPlace"
        Me.cmbTypeOfPlace.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTypeOfPlace.Size = New System.Drawing.Size(208, 32)
        Me.cmbTypeOfPlace.TabIndex = 1
        '
        'cmbTypeOfInt
        '
        Me.cmbTypeOfInt.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTypeOfInt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "TYPE OF INT", True))
        Me.cmbTypeOfInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypeOfInt.FormattingEnabled = True
        Me.cmbTypeOfInt.Location = New System.Drawing.Point(208, 16)
        Me.cmbTypeOfInt.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTypeOfInt.Name = "cmbTypeOfInt"
        Me.cmbTypeOfInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTypeOfInt.Size = New System.Drawing.Size(208, 32)
        Me.cmbTypeOfInt.TabIndex = 0
        '
        'chkInventory
        '
        Me.chkInventory.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.INTERVENTIONSBindingSource, "INVENTORY", True))
        Me.chkInventory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInventory.Location = New System.Drawing.Point(1195, 42)
        Me.chkInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.chkInventory.Name = "chkInventory"
        Me.chkInventory.Size = New System.Drawing.Size(136, 22)
        Me.chkInventory.TabIndex = 6
        Me.chkInventory.Text = "Inventory"
        Me.chkInventory.UseVisualStyleBackColor = True
        '
        'chkPicturesReport
        '
        Me.chkPicturesReport.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.INTERVENTIONSBindingSource, "PICTURES REPORT", True))
        Me.chkPicturesReport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPicturesReport.Location = New System.Drawing.Point(1195, 71)
        Me.chkPicturesReport.Margin = New System.Windows.Forms.Padding(4)
        Me.chkPicturesReport.Name = "chkPicturesReport"
        Me.chkPicturesReport.Size = New System.Drawing.Size(160, 22)
        Me.chkPicturesReport.TabIndex = 7
        Me.chkPicturesReport.Text = "PicturesReport"
        Me.chkPicturesReport.UseVisualStyleBackColor = True
        '
        'chkNICCReport
        '
        Me.chkNICCReport.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.INTERVENTIONSBindingSource, "NICC REPORT", True))
        Me.chkNICCReport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNICCReport.Location = New System.Drawing.Point(1387, 12)
        Me.chkNICCReport.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNICCReport.Name = "chkNICCReport"
        Me.chkNICCReport.Size = New System.Drawing.Size(136, 22)
        Me.chkNICCReport.TabIndex = 3
        Me.chkNICCReport.Text = "NICCReport"
        Me.chkNICCReport.UseVisualStyleBackColor = True
        '
        'chkCRUReport
        '
        Me.chkCRUReport.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.INTERVENTIONSBindingSource, "CRU REPORT", True))
        Me.chkCRUReport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCRUReport.Location = New System.Drawing.Point(1195, 12)
        Me.chkCRUReport.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCRUReport.Name = "chkCRUReport"
        Me.chkCRUReport.Size = New System.Drawing.Size(136, 22)
        Me.chkCRUReport.TabIndex = 0
        Me.chkCRUReport.Text = "CRUReport"
        Me.chkCRUReport.UseVisualStyleBackColor = True
        '
        'txtCRUReportDate
        '
        Me.txtCRUReportDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INTERVENTIONSBindingSource, "CRU REPORT DATE", True))
        Me.txtCRUReportDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCRUReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtCRUReportDate.Location = New System.Drawing.Point(352, 16)
        Me.txtCRUReportDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCRUReportDate.Name = "txtCRUReportDate"
        Me.txtCRUReportDate.Size = New System.Drawing.Size(152, 32)
        Me.txtCRUReportDate.TabIndex = 2
        '
        'cmbSamplesTakenBy
        '
        Me.cmbSamplesTakenBy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "SAMPLES TAKEN BY", True))
        Me.cmbSamplesTakenBy.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSamplesTakenBy.FormattingEnabled = True
        Me.cmbSamplesTakenBy.Location = New System.Drawing.Point(184, 57)
        Me.cmbSamplesTakenBy.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSamplesTakenBy.Name = "cmbSamplesTakenBy"
        Me.cmbSamplesTakenBy.Size = New System.Drawing.Size(88, 32)
        Me.cmbSamplesTakenBy.TabIndex = 0
        '
        'txtSamplesNum
        '
        Me.txtSamplesNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSamplesNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "SAMPLES NUM", True))
        Me.txtSamplesNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSamplesNum.Location = New System.Drawing.Point(184, 96)
        Me.txtSamplesNum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSamplesNum.Name = "txtSamplesNum"
        Me.txtSamplesNum.Size = New System.Drawing.Size(320, 32)
        Me.txtSamplesNum.TabIndex = 1
        '
        'MEMBERS_INTBindingSource
        '
        Me.MEMBERS_INTBindingSource.DataMember = "MEMBERS INT"
        Me.MEMBERS_INTBindingSource.DataSource = Me.DORADbDS
        '
        'MEMBERS_INTTableAdapter
        '
        Me.MEMBERS_INTTableAdapter.ClearBeforeFill = True
        '
        'txtCRUReportNum
        '
        Me.txtCRUReportNum.Culture = New System.Globalization.CultureInfo("en-001")
        Me.txtCRUReportNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "CRU REPORT NUM", True))
        Me.txtCRUReportNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCRUReportNum.Location = New System.Drawing.Point(216, 16)
        Me.txtCRUReportNum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCRUReportNum.Mask = "000000/\2\000"
        Me.txtCRUReportNum.Name = "txtCRUReportNum"
        Me.txtCRUReportNum.Size = New System.Drawing.Size(128, 32)
        Me.txtCRUReportNum.TabIndex = 1
        '
        'PRODUCTS_INTBindingSource
        '
        Me.PRODUCTS_INTBindingSource.DataMember = "PRODUCTS INT"
        Me.PRODUCTS_INTBindingSource.DataSource = Me.DORADbDS
        '
        'PRODUCTS_INTTableAdapter
        '
        Me.PRODUCTS_INTTableAdapter.ClearBeforeFill = True
        '
        'dgvMembersInt
        '
        Me.dgvMembersInt.AllowUserToAddRows = False
        Me.dgvMembersInt.AllowUserToDeleteRows = False
        Me.dgvMembersInt.AllowUserToResizeColumns = False
        Me.dgvMembersInt.AllowUserToResizeRows = False
        Me.dgvMembersInt.AutoGenerateColumns = False
        Me.dgvMembersInt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMembersInt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvMembersInt.ColumnHeadersHeight = 29
        Me.dgvMembersInt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMembersInt.ColumnHeadersVisible = False
        Me.dgvMembersInt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MEMBERNAMEDataGridViewTextBoxColumn, Me.TIMEINDataGridViewTextBoxColumn})
        Me.dgvMembersInt.DataSource = Me.MEMBERS_INTBindingSource
        Me.dgvMembersInt.Location = New System.Drawing.Point(21, 89)
        Me.dgvMembersInt.Margin = New System.Windows.Forms.Padding(0, 4, 4, 4)
        Me.dgvMembersInt.MultiSelect = False
        Me.dgvMembersInt.Name = "dgvMembersInt"
        Me.dgvMembersInt.ReadOnly = True
        Me.dgvMembersInt.RowHeadersVisible = False
        Me.dgvMembersInt.RowHeadersWidth = 51
        Me.dgvMembersInt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.dgvMembersInt.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMembersInt.RowTemplate.Height = 30
        Me.dgvMembersInt.RowTemplate.ReadOnly = True
        Me.dgvMembersInt.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMembersInt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvMembersInt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMembersInt.Size = New System.Drawing.Size(277, 364)
        Me.dgvMembersInt.TabIndex = 2
        '
        'MEMBERNAMEDataGridViewTextBoxColumn
        '
        Me.MEMBERNAMEDataGridViewTextBoxColumn.DataPropertyName = "MEMBER NAME"
        Me.MEMBERNAMEDataGridViewTextBoxColumn.HeaderText = "MEMBER NAME"
        Me.MEMBERNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MEMBERNAMEDataGridViewTextBoxColumn.Name = "MEMBERNAMEDataGridViewTextBoxColumn"
        Me.MEMBERNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.MEMBERNAMEDataGridViewTextBoxColumn.Width = 155
        '
        'TIMEINDataGridViewTextBoxColumn
        '
        Me.TIMEINDataGridViewTextBoxColumn.DataPropertyName = "TIME IN"
        Me.TIMEINDataGridViewTextBoxColumn.HeaderText = "TIME IN"
        Me.TIMEINDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TIMEINDataGridViewTextBoxColumn.Name = "TIMEINDataGridViewTextBoxColumn"
        Me.TIMEINDataGridViewTextBoxColumn.ReadOnly = True
        Me.TIMEINDataGridViewTextBoxColumn.Width = 125
        '
        'dgvProductsInt
        '
        Me.dgvProductsInt.AllowUserToAddRows = False
        Me.dgvProductsInt.AllowUserToDeleteRows = False
        Me.dgvProductsInt.AllowUserToResizeColumns = False
        Me.dgvProductsInt.AllowUserToResizeRows = False
        Me.dgvProductsInt.AutoGenerateColumns = False
        Me.dgvProductsInt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProductsInt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvProductsInt.ColumnHeadersHeight = 29
        Me.dgvProductsInt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProductsInt.ColumnHeadersVisible = False
        Me.dgvProductsInt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODUCTNAMEDataGridViewTextBoxColumn, Me.QUANTITYDataGridViewTextBoxColumn, Me.UNITDataGridViewTextBoxColumn})
        Me.dgvProductsInt.DataSource = Me.PRODUCTS_INTBindingSource
        Me.dgvProductsInt.Location = New System.Drawing.Point(21, 89)
        Me.dgvProductsInt.Margin = New System.Windows.Forms.Padding(0, 4, 4, 4)
        Me.dgvProductsInt.MultiSelect = False
        Me.dgvProductsInt.Name = "dgvProductsInt"
        Me.dgvProductsInt.ReadOnly = True
        Me.dgvProductsInt.RowHeadersVisible = False
        Me.dgvProductsInt.RowHeadersWidth = 51
        Me.dgvProductsInt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.dgvProductsInt.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductsInt.RowTemplate.Height = 30
        Me.dgvProductsInt.RowTemplate.ReadOnly = True
        Me.dgvProductsInt.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductsInt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvProductsInt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductsInt.Size = New System.Drawing.Size(448, 364)
        Me.dgvProductsInt.TabIndex = 3
        '
        'PRODUCTNAMEDataGridViewTextBoxColumn
        '
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT NAME"
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT NAME"
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.Name = "PRODUCTNAMEDataGridViewTextBoxColumn"
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.Width = 235
        '
        'QUANTITYDataGridViewTextBoxColumn
        '
        Me.QUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QUANTITYDataGridViewTextBoxColumn.Name = "QUANTITYDataGridViewTextBoxColumn"
        Me.QUANTITYDataGridViewTextBoxColumn.ReadOnly = True
        Me.QUANTITYDataGridViewTextBoxColumn.Width = 85
        '
        'UNITDataGridViewTextBoxColumn
        '
        Me.UNITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UNITDataGridViewTextBoxColumn.DataPropertyName = "UNIT"
        Me.UNITDataGridViewTextBoxColumn.HeaderText = "UNIT"
        Me.UNITDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UNITDataGridViewTextBoxColumn.Name = "UNITDataGridViewTextBoxColumn"
        Me.UNITDataGridViewTextBoxColumn.ReadOnly = True
        '
        'cmbMemberName
        '
        Me.cmbMemberName.DataSource = Me.MEMBERSBindingSource
        Me.cmbMemberName.DisplayMember = "LAST NAME"
        Me.cmbMemberName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMemberName.FormattingEnabled = True
        Me.cmbMemberName.Location = New System.Drawing.Point(21, 49)
        Me.cmbMemberName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMemberName.Name = "cmbMemberName"
        Me.cmbMemberName.Size = New System.Drawing.Size(191, 32)
        Me.cmbMemberName.TabIndex = 0
        '
        'MEMBERSBindingSource
        '
        Me.MEMBERSBindingSource.DataMember = "MEMBERS"
        Me.MEMBERSBindingSource.DataSource = Me.DORADbDS
        '
        'txtProductQuantity
        '
        Me.txtProductQuantity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductQuantity.Location = New System.Drawing.Point(299, 49)
        Me.txtProductQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductQuantity.Name = "txtProductQuantity"
        Me.txtProductQuantity.Size = New System.Drawing.Size(84, 32)
        Me.txtProductQuantity.TabIndex = 1
        '
        'cmbProductName
        '
        Me.cmbProductName.DataSource = Me.PRODUCTSBindingSource
        Me.cmbProductName.DisplayMember = "SHORT NAME"
        Me.cmbProductName.DropDownWidth = 280
        Me.cmbProductName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(21, 49)
        Me.cmbProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(223, 32)
        Me.cmbProductName.TabIndex = 0
        '
        'PRODUCTSBindingSource
        '
        Me.PRODUCTSBindingSource.DataMember = "PRODUCTS"
        Me.PRODUCTSBindingSource.DataSource = Me.DORADbDS
        '
        'cmbProductUnit
        '
        Me.cmbProductUnit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductUnit.FormattingEnabled = True
        Me.cmbProductUnit.Location = New System.Drawing.Point(395, 49)
        Me.cmbProductUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProductUnit.Name = "cmbProductUnit"
        Me.cmbProductUnit.Size = New System.Drawing.Size(73, 32)
        Me.cmbProductUnit.TabIndex = 2
        '
        'PRODUCTSTableAdapter
        '
        Me.PRODUCTSTableAdapter.ClearBeforeFill = True
        '
        'MEMBERSTableAdapter
        '
        Me.MEMBERSTableAdapter.ClearBeforeFill = True
        '
        'txtMemberTimeIn
        '
        Me.txtMemberTimeIn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberTimeIn.Location = New System.Drawing.Point(224, 49)
        Me.txtMemberTimeIn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMemberTimeIn.Mask = "00:00"
        Me.txtMemberTimeIn.Name = "txtMemberTimeIn"
        Me.txtMemberTimeIn.Size = New System.Drawing.Size(73, 32)
        Me.txtMemberTimeIn.TabIndex = 1
        Me.txtMemberTimeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDate1
        '
        Me.txtDate1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INTERVENTIONSBindingSource, "DATE 1", True))
        Me.txtDate1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate1.Location = New System.Drawing.Point(21, 20)
        Me.txtDate1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.Size = New System.Drawing.Size(184, 32)
        Me.txtDate1.TabIndex = 0
        '
        'txtTime2
        '
        Me.txtTime2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "TIME 2", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "t"))
        Me.txtTime2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime2.Location = New System.Drawing.Point(427, 20)
        Me.txtTime2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTime2.Mask = "00:00"
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.Size = New System.Drawing.Size(84, 32)
        Me.txtTime2.TabIndex = 2
        Me.txtTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDate2
        '
        Me.txtDate2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INTERVENTIONSBindingSource, "DATE 2", True))
        Me.txtDate2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate2.Location = New System.Drawing.Point(21, 59)
        Me.txtDate2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.Size = New System.Drawing.Size(184, 32)
        Me.txtDate2.TabIndex = 3
        '
        'txtTime3
        '
        Me.txtTime3.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "TIME 3", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "t"))
        Me.txtTime3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime3.Location = New System.Drawing.Point(267, 60)
        Me.txtTime3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTime3.Mask = "00:00"
        Me.txtTime3.Name = "txtTime3"
        Me.txtTime3.Size = New System.Drawing.Size(84, 32)
        Me.txtTime3.TabIndex = 4
        Me.txtTime3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTime4
        '
        Me.txtTime4.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "TIME 4", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "t"))
        Me.txtTime4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime4.Location = New System.Drawing.Point(427, 60)
        Me.txtTime4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTime4.Mask = "00:00"
        Me.txtTime4.Name = "txtTime4"
        Me.txtTime4.Size = New System.Drawing.Size(84, 32)
        Me.txtTime4.TabIndex = 5
        Me.txtTime4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDate3
        '
        Me.txtDate3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INTERVENTIONSBindingSource, "DATE 3", True))
        Me.txtDate3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate3.Location = New System.Drawing.Point(21, 98)
        Me.txtDate3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDate3.Name = "txtDate3"
        Me.txtDate3.Size = New System.Drawing.Size(184, 32)
        Me.txtDate3.TabIndex = 6
        '
        'txtTime5
        '
        Me.txtTime5.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "TIME 5", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "t"))
        Me.txtTime5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime5.Location = New System.Drawing.Point(267, 100)
        Me.txtTime5.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTime5.Mask = "00:00"
        Me.txtTime5.Name = "txtTime5"
        Me.txtTime5.Size = New System.Drawing.Size(84, 32)
        Me.txtTime5.TabIndex = 7
        Me.txtTime5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTime6
        '
        Me.txtTime6.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "TIME 6", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "t"))
        Me.txtTime6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime6.Location = New System.Drawing.Point(427, 100)
        Me.txtTime6.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTime6.Mask = "00:00"
        Me.txtTime6.Name = "txtTime6"
        Me.txtTime6.Size = New System.Drawing.Size(84, 32)
        Me.txtTime6.TabIndex = 8
        Me.txtTime6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "TIME", True))
        Me.txtTime.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(405, 148)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(105, 32)
        Me.txtTime.TabIndex = 81
        Me.txtTime.TabStop = False
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSummary
        '
        Me.txtSummary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "SUMMARY", True))
        Me.txtSummary.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSummary.Location = New System.Drawing.Point(21, 39)
        Me.txtSummary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSummary.Multiline = True
        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSummary.Size = New System.Drawing.Size(383, 265)
        Me.txtSummary.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID INT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID INT"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'txtSamplesDate
        '
        Me.txtSamplesDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INTERVENTIONSBindingSource, "SAMPLES DELIVERY DATE", True))
        Me.txtSamplesDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSamplesDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtSamplesDate.Location = New System.Drawing.Point(336, 16)
        Me.txtSamplesDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSamplesDate.Name = "txtSamplesDate"
        Me.txtSamplesDate.Size = New System.Drawing.Size(168, 32)
        Me.txtSamplesDate.TabIndex = 2
        '
        'lblTypeOfInt
        '
        Me.lblTypeOfInt.AutoSize = True
        Me.lblTypeOfInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeOfInt.Location = New System.Drawing.Point(16, 21)
        Me.lblTypeOfInt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTypeOfInt.Name = "lblTypeOfInt"
        Me.lblTypeOfInt.Size = New System.Drawing.Size(183, 24)
        Me.lblTypeOfInt.TabIndex = 94
        Me.lblTypeOfInt.Text = "Type Of Intervention"
        '
        'lblTypeOfPlace
        '
        Me.lblTypeOfPlace.AutoSize = True
        Me.lblTypeOfPlace.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeOfPlace.Location = New System.Drawing.Point(16, 62)
        Me.lblTypeOfPlace.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTypeOfPlace.Name = "lblTypeOfPlace"
        Me.lblTypeOfPlace.Size = New System.Drawing.Size(123, 24)
        Me.lblTypeOfPlace.TabIndex = 95
        Me.lblTypeOfPlace.Text = "Type Of Place"
        '
        'lblInt
        '
        Me.lblInt.AutoSize = True
        Me.lblInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInt.Location = New System.Drawing.Point(16, 101)
        Me.lblInt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInt.Name = "lblInt"
        Me.lblInt.Size = New System.Drawing.Size(114, 24)
        Me.lblInt.TabIndex = 96
        Me.lblInt.Text = "Intervention"
        '
        'txtZipInt
        '
        Me.txtZipInt.CausesValidation = False
        Me.txtZipInt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "ZIP INT", True))
        Me.txtZipInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipInt.Location = New System.Drawing.Point(363, 57)
        Me.txtZipInt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtZipInt.Mask = "0000"
        Me.txtZipInt.Name = "txtZipInt"
        Me.txtZipInt.Size = New System.Drawing.Size(53, 32)
        Me.txtZipInt.TabIndex = 2
        Me.txtZipInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDateInt
        '
        Me.lblDateInt.AutoSize = True
        Me.lblDateInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateInt.Location = New System.Drawing.Point(21, 20)
        Me.lblDateInt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateInt.Name = "lblDateInt"
        Me.lblDateInt.Size = New System.Drawing.Size(50, 24)
        Me.lblDateInt.TabIndex = 98
        Me.lblDateInt.Text = "Date"
        '
        'txtZipFacts
        '
        Me.txtZipFacts.CausesValidation = False
        Me.txtZipFacts.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "ZIP FACTS", True))
        Me.txtZipFacts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipFacts.Location = New System.Drawing.Point(363, 57)
        Me.txtZipFacts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtZipFacts.Mask = "0000"
        Me.txtZipFacts.Name = "txtZipFacts"
        Me.txtZipFacts.Size = New System.Drawing.Size(53, 32)
        Me.txtZipFacts.TabIndex = 2
        Me.txtZipFacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDateFacts
        '
        Me.lblDateFacts.AutoSize = True
        Me.lblDateFacts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateFacts.Location = New System.Drawing.Point(21, 20)
        Me.lblDateFacts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateFacts.Name = "lblDateFacts"
        Me.lblDateFacts.Size = New System.Drawing.Size(50, 24)
        Me.lblDateFacts.TabIndex = 98
        Me.lblDateFacts.Text = "Date"
        '
        'txtNICCReportNum
        '
        Me.txtNICCReportNum.Culture = New System.Globalization.CultureInfo("en-001")
        Me.txtNICCReportNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "NICC REPORT NUM", True))
        Me.txtNICCReportNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNICCReportNum.Location = New System.Drawing.Point(216, 114)
        Me.txtNICCReportNum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNICCReportNum.Mask = "DRU0000000"
        Me.txtNICCReportNum.Name = "txtNICCReportNum"
        Me.txtNICCReportNum.Size = New System.Drawing.Size(128, 32)
        Me.txtNICCReportNum.TabIndex = 120
        '
        'chkIntervention
        '
        Me.chkIntervention.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.INTERVENTIONSBindingSource, "INTDONE", True))
        Me.chkIntervention.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIntervention.Location = New System.Drawing.Point(1387, 42)
        Me.chkIntervention.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIntervention.Name = "chkIntervention"
        Me.chkIntervention.Size = New System.Drawing.Size(160, 22)
        Me.chkIntervention.TabIndex = 8
        Me.chkIntervention.Text = "Intervention"
        Me.chkIntervention.UseVisualStyleBackColor = True
        '
        'txtNICCReportDate
        '
        Me.txtNICCReportDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INTERVENTIONSBindingSource, "NICC REPORT DATE", True))
        Me.txtNICCReportDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNICCReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtNICCReportDate.Location = New System.Drawing.Point(352, 114)
        Me.txtNICCReportDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNICCReportDate.Name = "txtNICCReportDate"
        Me.txtNICCReportDate.Size = New System.Drawing.Size(152, 32)
        Me.txtNICCReportDate.TabIndex = 5
        '
        'lblSamplesCode
        '
        Me.lblSamplesCode.AutoSize = True
        Me.lblSamplesCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSamplesCode.Location = New System.Drawing.Point(280, 60)
        Me.lblSamplesCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSamplesCode.Name = "lblSamplesCode"
        Me.lblSamplesCode.Size = New System.Drawing.Size(53, 24)
        Me.lblSamplesCode.TabIndex = 96
        Me.lblSamplesCode.Text = "Code"
        '
        'txtSamplesCode
        '
        Me.txtSamplesCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSamplesCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "SAMPLES CODE", True))
        Me.txtSamplesCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSamplesCode.Location = New System.Drawing.Point(336, 57)
        Me.txtSamplesCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSamplesCode.Name = "txtSamplesCode"
        Me.txtSamplesCode.Size = New System.Drawing.Size(168, 32)
        Me.txtSamplesCode.TabIndex = 95
        '
        'lblSamplesDelivery
        '
        Me.lblSamplesDelivery.AutoSize = True
        Me.lblSamplesDelivery.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSamplesDelivery.Location = New System.Drawing.Point(16, 20)
        Me.lblSamplesDelivery.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSamplesDelivery.Name = "lblSamplesDelivery"
        Me.lblSamplesDelivery.Size = New System.Drawing.Size(117, 24)
        Me.lblSamplesDelivery.TabIndex = 94
        Me.lblSamplesDelivery.Text = "Delivered on"
        '
        'lblNICCConc
        '
        Me.lblNICCConc.AutoSize = True
        Me.lblNICCConc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNICCConc.Location = New System.Drawing.Point(21, 10)
        Me.lblNICCConc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNICCConc.Name = "lblNICCConc"
        Me.lblNICCConc.Size = New System.Drawing.Size(155, 24)
        Me.lblNICCConc.TabIndex = 97
        Me.lblNICCConc.Text = "NICC Conclusions"
        '
        'txtNICCConc
        '
        Me.txtNICCConc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "NICC CONC", True))
        Me.txtNICCConc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNICCConc.Location = New System.Drawing.Point(21, 39)
        Me.txtNICCConc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNICCConc.Multiline = True
        Me.txtNICCConc.Name = "txtNICCConc"
        Me.txtNICCConc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNICCConc.Size = New System.Drawing.Size(511, 166)
        Me.txtNICCConc.TabIndex = 1
        '
        'txtTime1
        '
        Me.txtTime1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "TIME 1", True))
        Me.txtTime1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime1.Location = New System.Drawing.Point(267, 20)
        Me.txtTime1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTime1.Mask = "00:00"
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.Size = New System.Drawing.Size(84, 32)
        Me.txtTime1.TabIndex = 1
        Me.txtTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(333, 153)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(51, 24)
        Me.lbltotal.TabIndex = 115
        Me.lbltotal.Text = "Total"
        '
        'lblProdCap
        '
        Me.lblProdCap.AutoSize = True
        Me.lblProdCap.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdCap.Location = New System.Drawing.Point(512, 289)
        Me.lblProdCap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProdCap.Name = "lblProdCap"
        Me.lblProdCap.Size = New System.Drawing.Size(81, 24)
        Me.lblProdCap.TabIndex = 119
        Me.lblProdCap.Text = "Capacity"
        Me.lblProdCap.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtProdCap
        '
        Me.txtProdCap.BackColor = System.Drawing.SystemColors.Window
        Me.txtProdCap.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INTERVENTIONSBindingSource, "PRODCAP", True))
        Me.txtProdCap.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdCap.Location = New System.Drawing.Point(608, 286)
        Me.txtProdCap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProdCap.Name = "txtProdCap"
        Me.txtProdCap.Size = New System.Drawing.Size(201, 32)
        Me.txtProdCap.TabIndex = 118
        Me.txtProdCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbStep
        '
        Me.cmbStep.DropDownWidth = 128
        Me.cmbStep.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStep.FormattingEnabled = True
        Me.cmbStep.Location = New System.Drawing.Point(555, 49)
        Me.cmbStep.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStep.Name = "cmbStep"
        Me.cmbStep.Size = New System.Drawing.Size(255, 32)
        Me.cmbStep.TabIndex = 2
        '
        'cmbMethod
        '
        Me.cmbMethod.DropDownWidth = 136
        Me.cmbMethod.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMethod.FormattingEnabled = True
        Me.cmbMethod.Location = New System.Drawing.Point(288, 49)
        Me.cmbMethod.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMethod.Name = "cmbMethod"
        Me.cmbMethod.Size = New System.Drawing.Size(259, 32)
        Me.cmbMethod.TabIndex = 1
        '
        'cmbDrug
        '
        Me.cmbDrug.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDrug.FormattingEnabled = True
        Me.cmbDrug.Location = New System.Drawing.Point(21, 49)
        Me.cmbDrug.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDrug.Name = "cmbDrug"
        Me.cmbDrug.Size = New System.Drawing.Size(259, 32)
        Me.cmbDrug.TabIndex = 0
        '
        'dgvProd
        '
        Me.dgvProd.AllowUserToAddRows = False
        Me.dgvProd.AllowUserToDeleteRows = False
        Me.dgvProd.AllowUserToResizeColumns = False
        Me.dgvProd.AllowUserToResizeRows = False
        Me.dgvProd.AutoGenerateColumns = False
        Me.dgvProd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvProd.ColumnHeadersHeight = 29
        Me.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProd.ColumnHeadersVisible = False
        Me.dgvProd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DRUGDataGridViewTextBoxColumn, Me.METHODDataGridViewTextBoxColumn, Me.STEPDataGridViewTextBoxColumn, Me.ID})
        Me.dgvProd.DataSource = Me.DRUGS_INTBindingSource
        Me.dgvProd.Location = New System.Drawing.Point(21, 89)
        Me.dgvProd.Margin = New System.Windows.Forms.Padding(0, 4, 4, 4)
        Me.dgvProd.MultiSelect = False
        Me.dgvProd.Name = "dgvProd"
        Me.dgvProd.ReadOnly = True
        Me.dgvProd.RowHeadersVisible = False
        Me.dgvProd.RowHeadersWidth = 51
        Me.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.dgvProd.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProd.RowTemplate.Height = 30
        Me.dgvProd.RowTemplate.ReadOnly = True
        Me.dgvProd.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProd.Size = New System.Drawing.Size(789, 187)
        Me.dgvProd.TabIndex = 3
        '
        'DRUGDataGridViewTextBoxColumn
        '
        Me.DRUGDataGridViewTextBoxColumn.DataPropertyName = "DRUG"
        Me.DRUGDataGridViewTextBoxColumn.HeaderText = "DRUG"
        Me.DRUGDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DRUGDataGridViewTextBoxColumn.Name = "DRUGDataGridViewTextBoxColumn"
        Me.DRUGDataGridViewTextBoxColumn.ReadOnly = True
        Me.DRUGDataGridViewTextBoxColumn.Width = 205
        '
        'METHODDataGridViewTextBoxColumn
        '
        Me.METHODDataGridViewTextBoxColumn.DataPropertyName = "METHOD"
        Me.METHODDataGridViewTextBoxColumn.HeaderText = "METHOD"
        Me.METHODDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.METHODDataGridViewTextBoxColumn.Name = "METHODDataGridViewTextBoxColumn"
        Me.METHODDataGridViewTextBoxColumn.ReadOnly = True
        Me.METHODDataGridViewTextBoxColumn.Width = 255
        '
        'STEPDataGridViewTextBoxColumn
        '
        Me.STEPDataGridViewTextBoxColumn.DataPropertyName = "STEP"
        Me.STEPDataGridViewTextBoxColumn.HeaderText = "STEP"
        Me.STEPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.STEPDataGridViewTextBoxColumn.Name = "STEPDataGridViewTextBoxColumn"
        Me.STEPDataGridViewTextBoxColumn.ReadOnly = True
        Me.STEPDataGridViewTextBoxColumn.Width = 215
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 125
        '
        'DRUGS_INTBindingSource
        '
        Me.DRUGS_INTBindingSource.DataMember = "DRUGS INT"
        Me.DRUGS_INTBindingSource.DataSource = Me.DORADbDS
        '
        'DRUGS_INTTableAdapter
        '
        Me.DRUGS_INTTableAdapter.ClearBeforeFill = True
        '
        'RCMenu
        '
        Me.RCMenu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RCMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.RCMenu.Name = "RCMenu"
        Me.RCMenu.Size = New System.Drawing.Size(120, 32)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(119, 28)
        Me.HelpToolStripMenuItem.Text = "Help"
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
        'pnlTitle
        '
        Me.pnlTitle.Controls.Add(Me.btnNextCase)
        Me.pnlTitle.Controls.Add(Me.btnPrevCase)
        Me.pnlTitle.Controls.Add(Me.pnlControls)
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.chkCRUReport)
        Me.pnlTitle.Controls.Add(Me.chkInventory)
        Me.pnlTitle.Controls.Add(Me.chkPicturesReport)
        Me.pnlTitle.Controls.Add(Me.chkNICCReport)
        Me.pnlTitle.Controls.Add(Me.chkIntervention)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(131, 0)
        Me.pnlTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(1793, 130)
        Me.pnlTitle.TabIndex = 140
        '
        'btnNextCase
        '
        Me.btnNextCase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextCase.FlatAppearance.BorderSize = 0
        Me.btnNextCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextCase.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextCase.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.btnNextCase.IconColor = System.Drawing.Color.Black
        Me.btnNextCase.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNextCase.IconSize = 40
        Me.btnNextCase.Location = New System.Drawing.Point(208, 57)
        Me.btnNextCase.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNextCase.Name = "btnNextCase"
        Me.btnNextCase.Padding = New System.Windows.Forms.Padding(11, 20, 11, 10)
        Me.btnNextCase.Size = New System.Drawing.Size(40, 39)
        Me.btnNextCase.TabIndex = 139
        Me.btnNextCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNextCase.UseVisualStyleBackColor = False
        '
        'btnPrevCase
        '
        Me.btnPrevCase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevCase.FlatAppearance.BorderSize = 0
        Me.btnPrevCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevCase.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevCase.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        Me.btnPrevCase.IconColor = System.Drawing.Color.Black
        Me.btnPrevCase.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrevCase.IconSize = 40
        Me.btnPrevCase.Location = New System.Drawing.Point(56, 57)
        Me.btnPrevCase.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrevCase.Name = "btnPrevCase"
        Me.btnPrevCase.Padding = New System.Windows.Forms.Padding(11, 20, 11, 10)
        Me.btnPrevCase.Size = New System.Drawing.Size(40, 39)
        Me.btnPrevCase.TabIndex = 103
        Me.btnPrevCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrevCase.UseVisualStyleBackColor = False
        '
        'pnlControls
        '
        Me.pnlControls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControls.Controls.Add(Me.btnClose)
        Me.pnlControls.Controls.Add(Me.btnMin)
        Me.pnlControls.Location = New System.Drawing.Point(1717, 0)
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(96, 57)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(109, 37)
        Me.lblTitle.TabIndex = 34
        Me.lblTitle.Tag = ""
        Me.lblTitle.Text = "Dossier"
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.btnUnlock)
        Me.pnlMenu.Controls.Add(Me.btnInv)
        Me.pnlMenu.Controls.Add(Me.btnNICC)
        Me.pnlMenu.Controls.Add(Me.btnIntReport)
        Me.pnlMenu.Controls.Add(Me.btnFolder)
        Me.pnlMenu.Controls.Add(Me.btnSave)
        Me.pnlMenu.Controls.Add(Me.btnExit)
        Me.pnlMenu.Controls.Add(Me.pnlLogo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(131, 986)
        Me.pnlMenu.TabIndex = 139
        '
        'btnUnlock
        '
        Me.btnUnlock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnlock.FlatAppearance.BorderSize = 0
        Me.btnUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnlock.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt
        Me.btnUnlock.IconColor = System.Drawing.Color.Black
        Me.btnUnlock.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnUnlock.IconSize = 30
        Me.btnUnlock.Location = New System.Drawing.Point(0, 497)
        Me.btnUnlock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(131, 60)
        Me.btnUnlock.TabIndex = 19
        Me.btnUnlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnlock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUnlock.UseVisualStyleBackColor = False
        '
        'btnInv
        '
        Me.btnInv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInv.FlatAppearance.BorderSize = 0
        Me.btnInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInv.IconChar = FontAwesome.Sharp.IconChar.ListOl
        Me.btnInv.IconColor = System.Drawing.Color.Black
        Me.btnInv.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnInv.IconSize = 30
        Me.btnInv.Location = New System.Drawing.Point(0, 441)
        Me.btnInv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInv.Name = "btnInv"
        Me.btnInv.Size = New System.Drawing.Size(131, 60)
        Me.btnInv.TabIndex = 18
        Me.btnInv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInv.UseVisualStyleBackColor = False
        '
        'btnNICC
        '
        Me.btnNICC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNICC.FlatAppearance.BorderSize = 0
        Me.btnNICC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNICC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNICC.IconChar = FontAwesome.Sharp.IconChar.FileWord
        Me.btnNICC.IconColor = System.Drawing.Color.Black
        Me.btnNICC.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnNICC.IconSize = 30
        Me.btnNICC.Location = New System.Drawing.Point(0, 377)
        Me.btnNICC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNICC.Name = "btnNICC"
        Me.btnNICC.Size = New System.Drawing.Size(131, 60)
        Me.btnNICC.TabIndex = 17
        Me.btnNICC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNICC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNICC.UseVisualStyleBackColor = False
        '
        'btnIntReport
        '
        Me.btnIntReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntReport.FlatAppearance.BorderSize = 0
        Me.btnIntReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIntReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntReport.IconChar = FontAwesome.Sharp.IconChar.FilePdf
        Me.btnIntReport.IconColor = System.Drawing.Color.Black
        Me.btnIntReport.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnIntReport.IconSize = 30
        Me.btnIntReport.Location = New System.Drawing.Point(0, 313)
        Me.btnIntReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIntReport.Name = "btnIntReport"
        Me.btnIntReport.Size = New System.Drawing.Size(131, 60)
        Me.btnIntReport.TabIndex = 16
        Me.btnIntReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIntReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIntReport.UseVisualStyleBackColor = False
        '
        'btnFolder
        '
        Me.btnFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFolder.FlatAppearance.BorderSize = 0
        Me.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFolder.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        Me.btnFolder.IconColor = System.Drawing.Color.Black
        Me.btnFolder.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnFolder.IconSize = 30
        Me.btnFolder.Location = New System.Drawing.Point(0, 250)
        Me.btnFolder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFolder.Name = "btnFolder"
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
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSave.IconColor = System.Drawing.Color.Black
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnSave.IconSize = 30
        Me.btnSave.Location = New System.Drawing.Point(0, 190)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
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
        Me.btnExit.Location = New System.Drawing.Point(0, 926)
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
        'pnlCenter
        '
        Me.pnlCenter.Controls.Add(Me.pnlDrug)
        Me.pnlCenter.Controls.Add(Me.Panel1)
        Me.pnlCenter.Controls.Add(Me.pnlMembers)
        Me.pnlCenter.Controls.Add(Me.Panel2)
        Me.pnlCenter.Controls.Add(Me.pnlSummary)
        Me.pnlCenter.Controls.Add(Me.pnlSamples)
        Me.pnlCenter.Controls.Add(Me.pnlReports)
        Me.pnlCenter.Controls.Add(Me.pnlTime)
        Me.pnlCenter.Controls.Add(Me.pnlIntervention)
        Me.pnlCenter.Controls.Add(Me.pnlFacts)
        Me.pnlCenter.Controls.Add(Me.pnlDetails)
        Me.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlCenter.Location = New System.Drawing.Point(131, 130)
        Me.pnlCenter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlCenter.Name = "pnlCenter"
        Me.pnlCenter.Size = New System.Drawing.Size(1793, 856)
        Me.pnlCenter.TabIndex = 141
        '
        'pnlDrug
        '
        Me.pnlDrug.Controls.Add(Me.btnDeleteDrug)
        Me.pnlDrug.Controls.Add(Me.btnSaveDrug)
        Me.pnlDrug.Controls.Add(Me.btnAddDrug)
        Me.pnlDrug.Controls.Add(Me.cmbDrug)
        Me.pnlDrug.Controls.Add(Me.lblProdCap)
        Me.pnlDrug.Controls.Add(Me.cmbMethod)
        Me.pnlDrug.Controls.Add(Me.cmbStep)
        Me.pnlDrug.Controls.Add(Me.txtProdCap)
        Me.pnlDrug.Controls.Add(Me.dgvProd)
        Me.pnlDrug.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDrug.Location = New System.Drawing.Point(1056, 17)
        Me.pnlDrug.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlDrug.Name = "pnlDrug"
        Me.pnlDrug.Size = New System.Drawing.Size(832, 337)
        Me.pnlDrug.TabIndex = 143
        '
        'btnDeleteDrug
        '
        Me.btnDeleteDrug.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteDrug.FlatAppearance.BorderSize = 0
        Me.btnDeleteDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteDrug.IconChar = FontAwesome.Sharp.IconChar.MinusSquare
        Me.btnDeleteDrug.IconColor = System.Drawing.Color.Black
        Me.btnDeleteDrug.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDeleteDrug.IconSize = 25
        Me.btnDeleteDrug.Location = New System.Drawing.Point(85, 20)
        Me.btnDeleteDrug.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteDrug.Name = "btnDeleteDrug"
        Me.btnDeleteDrug.Size = New System.Drawing.Size(25, 25)
        Me.btnDeleteDrug.TabIndex = 153
        Me.btnDeleteDrug.UseVisualStyleBackColor = True
        '
        'btnSaveDrug
        '
        Me.btnSaveDrug.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveDrug.FlatAppearance.BorderSize = 0
        Me.btnSaveDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveDrug.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSaveDrug.IconColor = System.Drawing.Color.Black
        Me.btnSaveDrug.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSaveDrug.IconSize = 25
        Me.btnSaveDrug.Location = New System.Drawing.Point(53, 20)
        Me.btnSaveDrug.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveDrug.Name = "btnSaveDrug"
        Me.btnSaveDrug.Size = New System.Drawing.Size(25, 25)
        Me.btnSaveDrug.TabIndex = 152
        Me.btnSaveDrug.UseVisualStyleBackColor = True
        '
        'btnAddDrug
        '
        Me.btnAddDrug.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddDrug.FlatAppearance.BorderSize = 0
        Me.btnAddDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDrug.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.btnAddDrug.IconColor = System.Drawing.Color.Black
        Me.btnAddDrug.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddDrug.IconSize = 25
        Me.btnAddDrug.Location = New System.Drawing.Point(21, 20)
        Me.btnAddDrug.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddDrug.Name = "btnAddDrug"
        Me.btnAddDrug.Size = New System.Drawing.Size(25, 25)
        Me.btnAddDrug.TabIndex = 151
        Me.btnAddDrug.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSearchProduct)
        Me.Panel1.Controls.Add(Me.txtProductQuantity)
        Me.Panel1.Controls.Add(Me.cmbProductUnit)
        Me.Panel1.Controls.Add(Me.dgvProductsInt)
        Me.Panel1.Controls.Add(Me.btnDeleteProduct)
        Me.Panel1.Controls.Add(Me.cmbProductName)
        Me.Panel1.Controls.Add(Me.btnSaveProduct)
        Me.Panel1.Controls.Add(Me.btnAddProduct)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1397, 374)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 473)
        Me.Panel1.TabIndex = 145
        '
        'btnSearchProduct
        '
        Me.btnSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchProduct.FlatAppearance.BorderSize = 0
        Me.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchProduct.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnSearchProduct.IconColor = System.Drawing.Color.Black
        Me.btnSearchProduct.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearchProduct.IconSize = 25
        Me.btnSearchProduct.Location = New System.Drawing.Point(256, 49)
        Me.btnSearchProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearchProduct.Name = "btnSearchProduct"
        Me.btnSearchProduct.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.btnSearchProduct.Size = New System.Drawing.Size(32, 32)
        Me.btnSearchProduct.TabIndex = 160
        Me.btnSearchProduct.UseVisualStyleBackColor = True
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteProduct.FlatAppearance.BorderSize = 0
        Me.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteProduct.IconChar = FontAwesome.Sharp.IconChar.MinusSquare
        Me.btnDeleteProduct.IconColor = System.Drawing.Color.Black
        Me.btnDeleteProduct.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDeleteProduct.IconSize = 25
        Me.btnDeleteProduct.Location = New System.Drawing.Point(85, 20)
        Me.btnDeleteProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(25, 25)
        Me.btnDeleteProduct.TabIndex = 159
        Me.btnDeleteProduct.UseVisualStyleBackColor = True
        '
        'btnSaveProduct
        '
        Me.btnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveProduct.FlatAppearance.BorderSize = 0
        Me.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveProduct.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSaveProduct.IconColor = System.Drawing.Color.Black
        Me.btnSaveProduct.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSaveProduct.IconSize = 25
        Me.btnSaveProduct.Location = New System.Drawing.Point(53, 20)
        Me.btnSaveProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveProduct.Name = "btnSaveProduct"
        Me.btnSaveProduct.Size = New System.Drawing.Size(25, 25)
        Me.btnSaveProduct.TabIndex = 158
        Me.btnSaveProduct.UseVisualStyleBackColor = True
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProduct.FlatAppearance.BorderSize = 0
        Me.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProduct.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.btnAddProduct.IconColor = System.Drawing.Color.Black
        Me.btnAddProduct.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddProduct.IconSize = 25
        Me.btnAddProduct.Location = New System.Drawing.Point(21, 20)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(25, 25)
        Me.btnAddProduct.TabIndex = 157
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'pnlMembers
        '
        Me.pnlMembers.Controls.Add(Me.btnDeleteMember)
        Me.pnlMembers.Controls.Add(Me.btnSaveMember)
        Me.pnlMembers.Controls.Add(Me.btnAddMember)
        Me.pnlMembers.Controls.Add(Me.dgvMembersInt)
        Me.pnlMembers.Controls.Add(Me.cmbMemberName)
        Me.pnlMembers.Controls.Add(Me.txtMemberTimeIn)
        Me.pnlMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlMembers.Location = New System.Drawing.Point(1056, 374)
        Me.pnlMembers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlMembers.Name = "pnlMembers"
        Me.pnlMembers.Size = New System.Drawing.Size(320, 473)
        Me.pnlMembers.TabIndex = 144
        '
        'btnDeleteMember
        '
        Me.btnDeleteMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteMember.FlatAppearance.BorderSize = 0
        Me.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteMember.IconChar = FontAwesome.Sharp.IconChar.MinusSquare
        Me.btnDeleteMember.IconColor = System.Drawing.Color.Black
        Me.btnDeleteMember.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDeleteMember.IconSize = 25
        Me.btnDeleteMember.Location = New System.Drawing.Point(85, 20)
        Me.btnDeleteMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteMember.Name = "btnDeleteMember"
        Me.btnDeleteMember.Size = New System.Drawing.Size(25, 25)
        Me.btnDeleteMember.TabIndex = 156
        Me.btnDeleteMember.UseVisualStyleBackColor = True
        '
        'btnSaveMember
        '
        Me.btnSaveMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveMember.FlatAppearance.BorderSize = 0
        Me.btnSaveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveMember.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSaveMember.IconColor = System.Drawing.Color.Black
        Me.btnSaveMember.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSaveMember.IconSize = 25
        Me.btnSaveMember.Location = New System.Drawing.Point(53, 20)
        Me.btnSaveMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveMember.Name = "btnSaveMember"
        Me.btnSaveMember.Size = New System.Drawing.Size(25, 25)
        Me.btnSaveMember.TabIndex = 155
        Me.btnSaveMember.UseVisualStyleBackColor = True
        '
        'btnAddMember
        '
        Me.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddMember.FlatAppearance.BorderSize = 0
        Me.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMember.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.btnAddMember.IconColor = System.Drawing.Color.Black
        Me.btnAddMember.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddMember.IconSize = 25
        Me.btnAddMember.Location = New System.Drawing.Point(21, 20)
        Me.btnAddMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(25, 25)
        Me.btnAddMember.TabIndex = 154
        Me.btnAddMember.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblNICCConc)
        Me.Panel2.Controls.Add(Me.txtNICCConc)
        Me.Panel2.Location = New System.Drawing.Point(480, 620)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(552, 226)
        Me.Panel2.TabIndex = 146
        '
        'pnlSummary
        '
        Me.pnlSummary.Controls.Add(Me.lblSummary)
        Me.pnlSummary.Controls.Add(Me.txtSummary)
        Me.pnlSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSummary.Location = New System.Drawing.Point(21, 522)
        Me.pnlSummary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSummary.Name = "pnlSummary"
        Me.pnlSummary.Size = New System.Drawing.Size(437, 325)
        Me.pnlSummary.TabIndex = 142
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.Location = New System.Drawing.Point(21, 10)
        Me.lblSummary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(88, 24)
        Me.lblSummary.TabIndex = 152
        Me.lblSummary.Text = "Summary"
        '
        'pnlSamples
        '
        Me.pnlSamples.Controls.Add(Me.btnClearDateSamples)
        Me.pnlSamples.Controls.Add(Me.txtSamplesNum)
        Me.pnlSamples.Controls.Add(Me.lblSamplesNum)
        Me.pnlSamples.Controls.Add(Me.lblSamplesTaken)
        Me.pnlSamples.Controls.Add(Me.txtSamplesCode)
        Me.pnlSamples.Controls.Add(Me.lblSamplesCode)
        Me.pnlSamples.Controls.Add(Me.txtSamplesDate)
        Me.pnlSamples.Controls.Add(Me.lblSamplesDelivery)
        Me.pnlSamples.Controls.Add(Me.cmbSamplesTakenBy)
        Me.pnlSamples.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSamples.Location = New System.Drawing.Point(480, 236)
        Me.pnlSamples.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSamples.Name = "pnlSamples"
        Me.pnlSamples.Size = New System.Drawing.Size(555, 148)
        Me.pnlSamples.TabIndex = 141
        '
        'btnClearDateSamples
        '
        Me.btnClearDateSamples.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearDateSamples.FlatAppearance.BorderSize = 0
        Me.btnClearDateSamples.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearDateSamples.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnClearDateSamples.IconColor = System.Drawing.Color.Black
        Me.btnClearDateSamples.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClearDateSamples.IconSize = 25
        Me.btnClearDateSamples.Location = New System.Drawing.Point(512, 20)
        Me.btnClearDateSamples.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearDateSamples.Name = "btnClearDateSamples"
        Me.btnClearDateSamples.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnClearDateSamples.Size = New System.Drawing.Size(25, 25)
        Me.btnClearDateSamples.TabIndex = 151
        Me.btnClearDateSamples.UseVisualStyleBackColor = True
        '
        'pnlReports
        '
        Me.pnlReports.Controls.Add(Me.btnClearDateNICC)
        Me.pnlReports.Controls.Add(Me.lblIntervention)
        Me.pnlReports.Controls.Add(Me.btnClearDateCRU)
        Me.pnlReports.Controls.Add(Me.lblPicturesReport)
        Me.pnlReports.Controls.Add(Me.lblInventory)
        Me.pnlReports.Controls.Add(Me.lblNICCReport)
        Me.pnlReports.Controls.Add(Me.lblCRUReport)
        Me.pnlReports.Controls.Add(Me.txtNICCReportNum)
        Me.pnlReports.Controls.Add(Me.txtNICCReportDate)
        Me.pnlReports.Controls.Add(Me.btnNICCReport)
        Me.pnlReports.Controls.Add(Me.btnIntervention)
        Me.pnlReports.Controls.Add(Me.btnPicturesReport)
        Me.pnlReports.Controls.Add(Me.btnInventory)
        Me.pnlReports.Controls.Add(Me.btnCRUReport)
        Me.pnlReports.Controls.Add(Me.txtCRUReportDate)
        Me.pnlReports.Controls.Add(Me.txtCRUReportNum)
        Me.pnlReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlReports.Location = New System.Drawing.Point(480, 20)
        Me.pnlReports.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlReports.Name = "pnlReports"
        Me.pnlReports.Size = New System.Drawing.Size(555, 197)
        Me.pnlReports.TabIndex = 140
        '
        'btnClearDateNICC
        '
        Me.btnClearDateNICC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearDateNICC.FlatAppearance.BorderSize = 0
        Me.btnClearDateNICC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearDateNICC.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnClearDateNICC.IconColor = System.Drawing.Color.Black
        Me.btnClearDateNICC.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClearDateNICC.IconSize = 25
        Me.btnClearDateNICC.Location = New System.Drawing.Point(512, 119)
        Me.btnClearDateNICC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearDateNICC.Name = "btnClearDateNICC"
        Me.btnClearDateNICC.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnClearDateNICC.Size = New System.Drawing.Size(25, 25)
        Me.btnClearDateNICC.TabIndex = 150
        Me.btnClearDateNICC.UseVisualStyleBackColor = True
        '
        'lblIntervention
        '
        Me.lblIntervention.AutoSize = True
        Me.lblIntervention.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntervention.Location = New System.Drawing.Point(48, 153)
        Me.lblIntervention.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIntervention.Name = "lblIntervention"
        Me.lblIntervention.Size = New System.Drawing.Size(114, 24)
        Me.lblIntervention.TabIndex = 148
        Me.lblIntervention.Text = "Intervention"
        '
        'btnClearDateCRU
        '
        Me.btnClearDateCRU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearDateCRU.FlatAppearance.BorderSize = 0
        Me.btnClearDateCRU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearDateCRU.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnClearDateCRU.IconColor = System.Drawing.Color.Black
        Me.btnClearDateCRU.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClearDateCRU.IconSize = 25
        Me.btnClearDateCRU.Location = New System.Drawing.Point(512, 20)
        Me.btnClearDateCRU.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearDateCRU.Name = "btnClearDateCRU"
        Me.btnClearDateCRU.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnClearDateCRU.Size = New System.Drawing.Size(25, 25)
        Me.btnClearDateCRU.TabIndex = 149
        Me.btnClearDateCRU.UseVisualStyleBackColor = True
        '
        'lblPicturesReport
        '
        Me.lblPicturesReport.AutoSize = True
        Me.lblPicturesReport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPicturesReport.Location = New System.Drawing.Point(48, 86)
        Me.lblPicturesReport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPicturesReport.Name = "lblPicturesReport"
        Me.lblPicturesReport.Size = New System.Drawing.Size(139, 24)
        Me.lblPicturesReport.TabIndex = 147
        Me.lblPicturesReport.Text = "Pictures Report"
        '
        'lblInventory
        '
        Me.lblInventory.AutoSize = True
        Me.lblInventory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventory.Location = New System.Drawing.Point(48, 53)
        Me.lblInventory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(90, 24)
        Me.lblInventory.TabIndex = 146
        Me.lblInventory.Text = "Inventory"
        '
        'lblNICCReport
        '
        Me.lblNICCReport.AutoSize = True
        Me.lblNICCReport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNICCReport.Location = New System.Drawing.Point(48, 119)
        Me.lblNICCReport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNICCReport.Name = "lblNICCReport"
        Me.lblNICCReport.Size = New System.Drawing.Size(112, 24)
        Me.lblNICCReport.TabIndex = 145
        Me.lblNICCReport.Text = "NICC Report"
        '
        'lblCRUReport
        '
        Me.lblCRUReport.AutoSize = True
        Me.lblCRUReport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCRUReport.Location = New System.Drawing.Point(48, 20)
        Me.lblCRUReport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCRUReport.Name = "lblCRUReport"
        Me.lblCRUReport.Size = New System.Drawing.Size(107, 24)
        Me.lblCRUReport.TabIndex = 144
        Me.lblCRUReport.Text = "CRU Report"
        '
        'btnNICCReport
        '
        Me.btnNICCReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNICCReport.FlatAppearance.BorderSize = 0
        Me.btnNICCReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNICCReport.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnNICCReport.IconColor = System.Drawing.Color.Black
        Me.btnNICCReport.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNICCReport.IconSize = 25
        Me.btnNICCReport.Location = New System.Drawing.Point(16, 119)
        Me.btnNICCReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNICCReport.Name = "btnNICCReport"
        Me.btnNICCReport.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnNICCReport.Size = New System.Drawing.Size(25, 25)
        Me.btnNICCReport.TabIndex = 140
        Me.btnNICCReport.UseVisualStyleBackColor = True
        '
        'btnIntervention
        '
        Me.btnIntervention.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntervention.FlatAppearance.BorderSize = 0
        Me.btnIntervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIntervention.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnIntervention.IconColor = System.Drawing.Color.Black
        Me.btnIntervention.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnIntervention.IconSize = 25
        Me.btnIntervention.Location = New System.Drawing.Point(16, 153)
        Me.btnIntervention.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIntervention.Name = "btnIntervention"
        Me.btnIntervention.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnIntervention.Size = New System.Drawing.Size(25, 25)
        Me.btnIntervention.TabIndex = 143
        Me.btnIntervention.UseVisualStyleBackColor = True
        '
        'btnPicturesReport
        '
        Me.btnPicturesReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPicturesReport.FlatAppearance.BorderSize = 0
        Me.btnPicturesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPicturesReport.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnPicturesReport.IconColor = System.Drawing.Color.Black
        Me.btnPicturesReport.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPicturesReport.IconSize = 25
        Me.btnPicturesReport.Location = New System.Drawing.Point(16, 86)
        Me.btnPicturesReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPicturesReport.Name = "btnPicturesReport"
        Me.btnPicturesReport.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnPicturesReport.Size = New System.Drawing.Size(25, 25)
        Me.btnPicturesReport.TabIndex = 142
        Me.btnPicturesReport.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnInventory.IconColor = System.Drawing.Color.Black
        Me.btnInventory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInventory.IconSize = 25
        Me.btnInventory.Location = New System.Drawing.Point(16, 53)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnInventory.Size = New System.Drawing.Size(25, 25)
        Me.btnInventory.TabIndex = 141
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnCRUReport
        '
        Me.btnCRUReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCRUReport.FlatAppearance.BorderSize = 0
        Me.btnCRUReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCRUReport.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnCRUReport.IconColor = System.Drawing.Color.Black
        Me.btnCRUReport.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCRUReport.IconSize = 25
        Me.btnCRUReport.Location = New System.Drawing.Point(16, 20)
        Me.btnCRUReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCRUReport.Name = "btnCRUReport"
        Me.btnCRUReport.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnCRUReport.Size = New System.Drawing.Size(25, 25)
        Me.btnCRUReport.TabIndex = 139
        Me.btnCRUReport.UseVisualStyleBackColor = True
        '
        'pnlTime
        '
        Me.pnlTime.Controls.Add(Me.IconPictureBox3)
        Me.pnlTime.Controls.Add(Me.IconPictureBox2)
        Me.pnlTime.Controls.Add(Me.btnClearDate3)
        Me.pnlTime.Controls.Add(Me.btnClearDate2)
        Me.pnlTime.Controls.Add(Me.btnClearDate1)
        Me.pnlTime.Controls.Add(Me.IconPictureBox1)
        Me.pnlTime.Controls.Add(Me.txtDate1)
        Me.pnlTime.Controls.Add(Me.txtTime)
        Me.pnlTime.Controls.Add(Me.txtTime6)
        Me.pnlTime.Controls.Add(Me.txtTime1)
        Me.pnlTime.Controls.Add(Me.txtTime5)
        Me.pnlTime.Controls.Add(Me.txtDate3)
        Me.pnlTime.Controls.Add(Me.txtTime4)
        Me.pnlTime.Controls.Add(Me.txtTime3)
        Me.pnlTime.Controls.Add(Me.lbltotal)
        Me.pnlTime.Controls.Add(Me.txtDate2)
        Me.pnlTime.Controls.Add(Me.txtTime2)
        Me.pnlTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTime.Location = New System.Drawing.Point(480, 404)
        Me.pnlTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTime.Name = "pnlTime"
        Me.pnlTime.Size = New System.Drawing.Size(555, 197)
        Me.pnlTime.TabIndex = 101
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.IconPictureBox3.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.Location = New System.Drawing.Point(373, 100)
        Me.IconPictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.IconPictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconPictureBox3.TabIndex = 141
        Me.IconPictureBox3.TabStop = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.IconPictureBox2.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.Location = New System.Drawing.Point(373, 60)
        Me.IconPictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.IconPictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconPictureBox2.TabIndex = 140
        Me.IconPictureBox2.TabStop = False
        '
        'btnClearDate3
        '
        Me.btnClearDate3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearDate3.FlatAppearance.BorderSize = 0
        Me.btnClearDate3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearDate3.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnClearDate3.IconColor = System.Drawing.Color.Black
        Me.btnClearDate3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClearDate3.IconSize = 25
        Me.btnClearDate3.Location = New System.Drawing.Point(213, 102)
        Me.btnClearDate3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearDate3.Name = "btnClearDate3"
        Me.btnClearDate3.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnClearDate3.Size = New System.Drawing.Size(25, 25)
        Me.btnClearDate3.TabIndex = 139
        Me.btnClearDate3.UseVisualStyleBackColor = True
        '
        'btnClearDate2
        '
        Me.btnClearDate2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearDate2.FlatAppearance.BorderSize = 0
        Me.btnClearDate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearDate2.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnClearDate2.IconColor = System.Drawing.Color.Black
        Me.btnClearDate2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClearDate2.IconSize = 25
        Me.btnClearDate2.Location = New System.Drawing.Point(213, 63)
        Me.btnClearDate2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearDate2.Name = "btnClearDate2"
        Me.btnClearDate2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnClearDate2.Size = New System.Drawing.Size(25, 25)
        Me.btnClearDate2.TabIndex = 138
        Me.btnClearDate2.UseVisualStyleBackColor = True
        '
        'btnClearDate1
        '
        Me.btnClearDate1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearDate1.FlatAppearance.BorderSize = 0
        Me.btnClearDate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearDate1.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnClearDate1.IconColor = System.Drawing.Color.Black
        Me.btnClearDate1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClearDate1.IconSize = 25
        Me.btnClearDate1.Location = New System.Drawing.Point(213, 23)
        Me.btnClearDate1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearDate1.Name = "btnClearDate1"
        Me.btnClearDate1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.btnClearDate1.Size = New System.Drawing.Size(25, 25)
        Me.btnClearDate1.TabIndex = 137
        Me.btnClearDate1.UseVisualStyleBackColor = True
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.Location = New System.Drawing.Point(373, 20)
        Me.IconPictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconPictureBox1.TabIndex = 102
        Me.IconPictureBox1.TabStop = False
        '
        'pnlIntervention
        '
        Me.pnlIntervention.Controls.Add(Me.btnRemondis)
        Me.pnlIntervention.Controls.Add(Me.btnSGS)
        Me.pnlIntervention.Controls.Add(Me.btnIntToFacts)
        Me.pnlIntervention.Controls.Add(Me.lblDateInt)
        Me.pnlIntervention.Controls.Add(Me.txtZipInt)
        Me.pnlIntervention.Controls.Add(Me.txtDateInt)
        Me.pnlIntervention.Controls.Add(Me.txtAdressInt)
        Me.pnlIntervention.Controls.Add(Me.cmbCityInt)
        Me.pnlIntervention.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlIntervention.Location = New System.Drawing.Point(21, 354)
        Me.pnlIntervention.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlIntervention.Name = "pnlIntervention"
        Me.pnlIntervention.Size = New System.Drawing.Size(437, 148)
        Me.pnlIntervention.TabIndex = 100
        '
        'btnRemondis
        '
        Me.btnRemondis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemondis.FlatAppearance.BorderSize = 0
        Me.btnRemondis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemondis.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemondis.Location = New System.Drawing.Point(144, 16)
        Me.btnRemondis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemondis.Name = "btnRemondis"
        Me.btnRemondis.Size = New System.Drawing.Size(32, 32)
        Me.btnRemondis.TabIndex = 102
        Me.btnRemondis.Text = "R"
        Me.btnRemondis.UseVisualStyleBackColor = True
        '
        'btnSGS
        '
        Me.btnSGS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSGS.FlatAppearance.BorderSize = 0
        Me.btnSGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSGS.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSGS.Location = New System.Drawing.Point(176, 16)
        Me.btnSGS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSGS.Name = "btnSGS"
        Me.btnSGS.Size = New System.Drawing.Size(32, 32)
        Me.btnSGS.TabIndex = 101
        Me.btnSGS.Text = "S"
        Me.btnSGS.UseVisualStyleBackColor = True
        '
        'btnIntToFacts
        '
        Me.btnIntToFacts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntToFacts.FlatAppearance.BorderSize = 0
        Me.btnIntToFacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIntToFacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntToFacts.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp
        Me.btnIntToFacts.IconColor = System.Drawing.Color.Black
        Me.btnIntToFacts.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnIntToFacts.IconSize = 30
        Me.btnIntToFacts.Location = New System.Drawing.Point(216, 16)
        Me.btnIntToFacts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIntToFacts.Name = "btnIntToFacts"
        Me.btnIntToFacts.Padding = New System.Windows.Forms.Padding(11, 14, 11, 10)
        Me.btnIntToFacts.Size = New System.Drawing.Size(32, 32)
        Me.btnIntToFacts.TabIndex = 16
        Me.btnIntToFacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIntToFacts.UseVisualStyleBackColor = False
        '
        'pnlFacts
        '
        Me.pnlFacts.Controls.Add(Me.btnFactsToInt)
        Me.pnlFacts.Controls.Add(Me.lblDateFacts)
        Me.pnlFacts.Controls.Add(Me.txtZipFacts)
        Me.pnlFacts.Controls.Add(Me.txtDateFacts)
        Me.pnlFacts.Controls.Add(Me.txtAdressFacts)
        Me.pnlFacts.Controls.Add(Me.cmbCityFacts)
        Me.pnlFacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlFacts.Location = New System.Drawing.Point(21, 187)
        Me.pnlFacts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlFacts.Name = "pnlFacts"
        Me.pnlFacts.Size = New System.Drawing.Size(437, 148)
        Me.pnlFacts.TabIndex = 98
        '
        'btnFactsToInt
        '
        Me.btnFactsToInt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFactsToInt.FlatAppearance.BorderSize = 0
        Me.btnFactsToInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFactsToInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactsToInt.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown
        Me.btnFactsToInt.IconColor = System.Drawing.Color.Black
        Me.btnFactsToInt.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFactsToInt.IconSize = 30
        Me.btnFactsToInt.Location = New System.Drawing.Point(216, 16)
        Me.btnFactsToInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFactsToInt.Name = "btnFactsToInt"
        Me.btnFactsToInt.Padding = New System.Windows.Forms.Padding(11, 14, 11, 10)
        Me.btnFactsToInt.Size = New System.Drawing.Size(32, 32)
        Me.btnFactsToInt.TabIndex = 101
        Me.btnFactsToInt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFactsToInt.UseVisualStyleBackColor = False
        '
        'pnlDetails
        '
        Me.pnlDetails.Controls.Add(Me.lblTypeOfInt)
        Me.pnlDetails.Controls.Add(Me.cmbTypeOfInt)
        Me.pnlDetails.Controls.Add(Me.lblInt)
        Me.pnlDetails.Controls.Add(Me.cmbInt)
        Me.pnlDetails.Controls.Add(Me.lblTypeOfPlace)
        Me.pnlDetails.Controls.Add(Me.cmbTypeOfPlace)
        Me.pnlDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDetails.Location = New System.Drawing.Point(21, 20)
        Me.pnlDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(437, 148)
        Me.pnlDetails.TabIndex = 97
        '
        'frmIntervention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 986)
        Me.Controls.Add(Me.pnlCenter)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.pnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(2053, 1033)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1918, 1028)
        Me.Name = "frmIntervention"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERS_INTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTS_INTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMembersInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductsInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DRUGS_INTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RCMenu.ResumeLayout(False)
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.imgCRU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCenter.ResumeLayout(False)
        Me.pnlDrug.ResumeLayout(False)
        Me.pnlDrug.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlMembers.ResumeLayout(False)
        Me.pnlMembers.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlSummary.ResumeLayout(False)
        Me.pnlSummary.PerformLayout()
        Me.pnlSamples.ResumeLayout(False)
        Me.pnlSamples.PerformLayout()
        Me.pnlReports.ResumeLayout(False)
        Me.pnlReports.PerformLayout()
        Me.pnlTime.ResumeLayout(False)
        Me.pnlTime.PerformLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlIntervention.ResumeLayout(False)
        Me.pnlIntervention.PerformLayout()
        Me.pnlFacts.ResumeLayout(False)
        Me.pnlFacts.PerformLayout()
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DORADbDS As DORADbDS
    Friend WithEvents INTERVENTIONSBindingSource As BindingSource
    Friend WithEvents INTERVENTIONSTableAdapter As DORADbDSTableAdapters.INTERVENTIONSTableAdapter
    Friend WithEvents TableAdapterManager As DORADbDSTableAdapters.TableAdapterManager
    Friend WithEvents txtAdressInt As TextBox
    Friend WithEvents cmbCityInt As ComboBox
    Friend WithEvents txtDateInt As DateTimePicker
    Friend WithEvents txtDateFacts As DateTimePicker
    Friend WithEvents cmbCityFacts As ComboBox
    Friend WithEvents txtAdressFacts As TextBox
    Friend WithEvents cmbInt As ComboBox
    Friend WithEvents cmbTypeOfPlace As ComboBox
    Friend WithEvents cmbTypeOfInt As ComboBox
    Friend WithEvents chkInventory As CheckBox
    Friend WithEvents chkPicturesReport As CheckBox
    Friend WithEvents chkNICCReport As CheckBox
    Friend WithEvents chkCRUReport As CheckBox
    Friend WithEvents txtCRUReportDate As DateTimePicker
    Friend WithEvents cmbSamplesTakenBy As ComboBox
    Friend WithEvents txtSamplesNum As TextBox
    Friend WithEvents MEMBERS_INTBindingSource As BindingSource
    Friend WithEvents MEMBERS_INTTableAdapter As DORADbDSTableAdapters.MEMBERS_INTTableAdapter
    Friend WithEvents txtCRUReportNum As MaskedTextBox
    Friend WithEvents PRODUCTS_INTBindingSource As BindingSource
    Friend WithEvents PRODUCTS_INTTableAdapter As DORADbDSTableAdapters.PRODUCTS_INTTableAdapter
    Friend WithEvents dgvMembersInt As DataGridView
    Friend WithEvents dgvProductsInt As DataGridView
    Friend WithEvents cmbMemberName As ComboBox
    Friend WithEvents txtProductQuantity As TextBox
    Friend WithEvents cmbProductName As ComboBox
    Friend WithEvents cmbProductUnit As ComboBox
    Friend WithEvents PRODUCTSBindingSource As BindingSource
    Friend WithEvents PRODUCTSTableAdapter As DORADbDSTableAdapters.PRODUCTSTableAdapter
    Friend WithEvents MEMBERSBindingSource As BindingSource
    Friend WithEvents MEMBERSTableAdapter As DORADbDSTableAdapters.MEMBERSTableAdapter
    Friend WithEvents txtMemberTimeIn As MaskedTextBox
    Friend WithEvents txtDate1 As DateTimePicker
    Friend WithEvents txtTime2 As MaskedTextBox
    Friend WithEvents txtDate2 As DateTimePicker
    Friend WithEvents txtTime3 As MaskedTextBox
    Friend WithEvents txtTime4 As MaskedTextBox
    Friend WithEvents txtDate3 As DateTimePicker
    Friend WithEvents txtTime5 As MaskedTextBox
    Friend WithEvents txtTime6 As MaskedTextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtSummary As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MEMBERNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIMEINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtSamplesDate As DateTimePicker
    Friend WithEvents lblTypeOfInt As Label
    Friend WithEvents lblTypeOfPlace As Label
    Friend WithEvents lblInt As Label
    Friend WithEvents lblDateInt As Label
    Friend WithEvents lblDateFacts As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents DRUGS_INTBindingSource As BindingSource
    Friend WithEvents DRUGS_INTTableAdapter As DORADbDSTableAdapters.DRUGS_INTTableAdapter
    Friend WithEvents dgvProd As DataGridView
    Friend WithEvents cmbStep As ComboBox
    Friend WithEvents cmbMethod As ComboBox
    Friend WithEvents cmbDrug As ComboBox
    Friend WithEvents lblSamplesTaken As Label
    Friend WithEvents lblSamplesNum As Label
    Friend WithEvents lblSamplesDelivery As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents txtZipInt As MaskedTextBox
    Friend WithEvents txtZipFacts As MaskedTextBox
    Friend WithEvents RCMenu As ContextMenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents chkIntervention As CheckBox
    Friend WithEvents txtNICCReportDate As DateTimePicker
    Friend WithEvents txtTime1 As MaskedTextBox
    Friend WithEvents lblSamplesCode As Label
    Friend WithEvents txtSamplesCode As TextBox
    Friend WithEvents txtNICCConc As TextBox
    Friend WithEvents lblProdCap As Label
    Friend WithEvents txtProdCap As TextBox
    Friend WithEvents lblNICCConc As Label
    Friend WithEvents CASESBindingSource As BindingSource
    Friend WithEvents CASESTableAdapter As DORADbDSTableAdapters.CASESTableAdapter
    Friend WithEvents txtNICCReportNum As MaskedTextBox
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents pnlControls As Panel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMin As FontAwesome.Sharp.IconButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnFolder As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents imgCRU As PictureBox
    Friend WithEvents pnlCenter As Panel
    Friend WithEvents pnlDetails As Panel
    Friend WithEvents pnlIntervention As Panel
    Friend WithEvents pnlFacts As Panel
    Friend WithEvents btnSGS As Button
    Friend WithEvents btnIntToFacts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFactsToInt As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRemondis As Button
    Friend WithEvents pnlTime As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnClearDate1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClearDate3 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClearDate2 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCRUReport As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlReports As Panel
    Friend WithEvents btnIntervention As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents btnNICCReport As FontAwesome.Sharp.IconButton
    Friend WithEvents lblIntervention As Label
    Friend WithEvents lblPicturesReport As Label
    Friend WithEvents lblInventory As Label
    Friend WithEvents lblNICCReport As Label
    Friend WithEvents lblCRUReport As Label
    Friend WithEvents btnClearDateNICC As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClearDateCRU As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlSamples As Panel
    Friend WithEvents btnClearDateSamples As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlSummary As Panel
    Friend WithEvents lblSummary As Label
    Friend WithEvents btnUnlock As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInv As FontAwesome.Sharp.IconButton
    Friend WithEvents btnNICC As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIntReport As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlDrug As Panel
    Friend WithEvents pnlMembers As Panel
    Friend WithEvents btnSearchProduct As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeleteProduct As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveProduct As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddProduct As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeleteMember As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveMember As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddMember As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeleteDrug As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveDrug As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddDrug As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPrevCase As FontAwesome.Sharp.IconButton
    Friend WithEvents btnNextCase As FontAwesome.Sharp.IconButton
    Friend WithEvents PRODUCTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DRUGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents METHODDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STEPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPicturesReport As FontAwesome.Sharp.IconButton
End Class
