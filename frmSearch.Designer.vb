<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.lblCount = New System.Windows.Forms.Label()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.DORADbDS = New DORA.DORADbDS()
        Me.cmbCMInt = New System.Windows.Forms.ComboBox()
        Me.cmbDrug = New System.Windows.Forms.ComboBox()
        Me.cmbTypeOfPlace = New System.Windows.Forms.ComboBox()
        Me.cmbTypeOfInt = New System.Windows.Forms.ComboBox()
        Me.cmbArro = New System.Windows.Forms.ComboBox()
        Me.cmbFrom = New System.Windows.Forms.ComboBox()
        Me.cmbTo = New System.Windows.Forms.ComboBox()
        Me.INTERVENTIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INTERVENTIONSTableAdapter = New DORA.DORADbDSTableAdapters.INTERVENTIONSTableAdapter()
        Me.TableAdapterManager = New DORA.DORADbDSTableAdapters.TableAdapterManager()
        Me.DRUGS_INTTableAdapter = New DORA.DORADbDSTableAdapters.DRUGS_INTTableAdapter()
        Me.DRUGS_INTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CASESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CASESTableAdapter = New DORA.DORADbDSTableAdapters.CASESTableAdapter()
        Me.RCMenuStats = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnViewIntervention = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExportList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnNL = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnFR = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnEN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.fsw = New System.IO.FileSystemWatcher()
        Me.MainTable = New System.Windows.Forms.TableLayoutPanel()
        Me.SearchTable = New System.Windows.Forms.TableLayoutPanel()
        Me.lblText = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.lblDates = New System.Windows.Forms.Label()
        Me.lblIntervention = New System.Windows.Forms.Label()
        Me.lblPlace = New System.Windows.Forms.Label()
        Me.lblDrug = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblArro = New System.Windows.Forms.Label()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.btnSearch = New FontAwesome.Sharp.IconButton()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.btnDown = New FontAwesome.Sharp.IconButton()
        Me.btnUp = New FontAwesome.Sharp.IconButton()
        Me.lblManager = New System.Windows.Forms.Label()
        Me.btnAddFilters = New FontAwesome.Sharp.IconButton()
        Me.dgvStats = New System.Windows.Forms.DataGridView()
        Me.RCMenuHeader = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnAllInts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDateInt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAdressInt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnZipInt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCityInt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAllFacts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDateFacts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAdressFacts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnZipFacts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCityFacts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAllSamples = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSamplesT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSamplesN = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSamplesD = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSamplesC = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAllCRUReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCRUReportN = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCRUReportD = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAllNICCReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnNICCReportN = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnNICCReportD = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnNICCReportC = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAllCase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnUnit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnFileNum = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnReportNum = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnRIONum = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnONNum = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSIENANum = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnNSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCMExt = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnInterventionDone = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCRUOnSite = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DRUGS_INTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RCMenuStats.SuspendLayout()
        CType(Me.fsw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTable.SuspendLayout()
        Me.SearchTable.SuspendLayout()
        CType(Me.dgvStats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RCMenuHeader.SuspendLayout()
        Me.FilterMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblCount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(4, 828)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(61, 30)
        Me.lblCount.TabIndex = 179
        Me.lblCount.Text = "Count"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCity
        '
        Me.cmbCity.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCity.DropDownHeight = 300
        Me.cmbCity.DropDownWidth = 220
        Me.cmbCity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.IntegralHeight = False
        Me.cmbCity.Location = New System.Drawing.Point(594, 32)
        Me.cmbCity.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCity.Size = New System.Drawing.Size(152, 32)
        Me.cmbCity.TabIndex = 0
        '
        'DORADbDS
        '
        Me.DORADbDS.DataSetName = "DORADbDS"
        Me.DORADbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbCMInt
        '
        Me.cmbCMInt.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCMInt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCMInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCMInt.FormattingEnabled = True
        Me.cmbCMInt.Location = New System.Drawing.Point(914, 32)
        Me.cmbCMInt.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbCMInt.Name = "cmbCMInt"
        Me.cmbCMInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCMInt.Size = New System.Drawing.Size(152, 32)
        Me.cmbCMInt.TabIndex = 0
        '
        'cmbDrug
        '
        Me.cmbDrug.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDrug.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDrug.FormattingEnabled = True
        Me.cmbDrug.Location = New System.Drawing.Point(434, 32)
        Me.cmbDrug.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbDrug.Name = "cmbDrug"
        Me.cmbDrug.Size = New System.Drawing.Size(152, 32)
        Me.cmbDrug.TabIndex = 0
        '
        'cmbTypeOfPlace
        '
        Me.cmbTypeOfPlace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTypeOfPlace.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypeOfPlace.FormattingEnabled = True
        Me.cmbTypeOfPlace.Location = New System.Drawing.Point(304, 32)
        Me.cmbTypeOfPlace.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbTypeOfPlace.Name = "cmbTypeOfPlace"
        Me.cmbTypeOfPlace.Size = New System.Drawing.Size(122, 32)
        Me.cmbTypeOfPlace.TabIndex = 0
        '
        'cmbTypeOfInt
        '
        Me.cmbTypeOfInt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTypeOfInt.DropDownHeight = 300
        Me.cmbTypeOfInt.DropDownWidth = 190
        Me.cmbTypeOfInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypeOfInt.FormattingEnabled = True
        Me.cmbTypeOfInt.IntegralHeight = False
        Me.cmbTypeOfInt.Location = New System.Drawing.Point(144, 32)
        Me.cmbTypeOfInt.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbTypeOfInt.Name = "cmbTypeOfInt"
        Me.cmbTypeOfInt.Size = New System.Drawing.Size(152, 32)
        Me.cmbTypeOfInt.TabIndex = 0
        '
        'cmbArro
        '
        Me.cmbArro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbArro.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbArro.FormattingEnabled = True
        Me.cmbArro.Location = New System.Drawing.Point(754, 32)
        Me.cmbArro.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbArro.Name = "cmbArro"
        Me.cmbArro.Size = New System.Drawing.Size(152, 32)
        Me.cmbArro.TabIndex = 0
        '
        'cmbFrom
        '
        Me.cmbFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrom.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Location = New System.Drawing.Point(4, 32)
        Me.cmbFrom.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(62, 32)
        Me.cmbFrom.TabIndex = 0
        '
        'cmbTo
        '
        Me.cmbTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTo.FormattingEnabled = True
        Me.cmbTo.Location = New System.Drawing.Point(74, 32)
        Me.cmbTo.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Size = New System.Drawing.Size(62, 32)
        Me.cmbTo.TabIndex = 1
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BACKUPTableAdapter = Nothing
        Me.TableAdapterManager.CASESTableAdapter = Nothing
        Me.TableAdapterManager.CITIESTableAdapter = Nothing
        Me.TableAdapterManager.DRUGS_INTTableAdapter = Me.DRUGS_INTTableAdapter
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
        'DRUGS_INTTableAdapter
        '
        Me.DRUGS_INTTableAdapter.ClearBeforeFill = True
        '
        'DRUGS_INTBindingSource
        '
        Me.DRUGS_INTBindingSource.DataMember = "DRUGS INT"
        Me.DRUGS_INTBindingSource.DataSource = Me.DORADbDS
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
        'RCMenuStats
        '
        Me.RCMenuStats.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCMenuStats.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RCMenuStats.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnViewIntervention, Me.mnExportList})
        Me.RCMenuStats.Name = "RCMenu"
        Me.RCMenuStats.Size = New System.Drawing.Size(236, 60)
        '
        'mnViewIntervention
        '
        Me.mnViewIntervention.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnViewIntervention.Image = Global.DORA.My.Resources.Resources.eye
        Me.mnViewIntervention.Name = "mnViewIntervention"
        Me.mnViewIntervention.Size = New System.Drawing.Size(235, 28)
        Me.mnViewIntervention.Text = "View Intervention"
        '
        'mnExportList
        '
        Me.mnExportList.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnNL, Me.mnFR, Me.mnEN})
        Me.mnExportList.Image = Global.DORA.My.Resources.Resources.circle_right
        Me.mnExportList.Name = "mnExportList"
        Me.mnExportList.Size = New System.Drawing.Size(235, 28)
        Me.mnExportList.Text = "Export List"
        '
        'mnNL
        '
        Me.mnNL.Image = Global.DORA.My.Resources.Resources.n
        Me.mnNL.Name = "mnNL"
        Me.mnNL.Size = New System.Drawing.Size(190, 28)
        Me.mnNL.Text = "Nederlands"
        '
        'mnFR
        '
        Me.mnFR.Image = Global.DORA.My.Resources.Resources.f
        Me.mnFR.Name = "mnFR"
        Me.mnFR.Size = New System.Drawing.Size(190, 28)
        Me.mnFR.Text = "Français"
        '
        'mnEN
        '
        Me.mnEN.Image = Global.DORA.My.Resources.Resources.e
        Me.mnEN.Name = "mnEN"
        Me.mnEN.Size = New System.Drawing.Size(190, 28)
        Me.mnEN.Text = "English"
        '
        'fsw
        '
        Me.fsw.EnableRaisingEvents = True
        Me.fsw.Filter = "*.dat"
        Me.fsw.Path = "G:\DJSOC\DRUGS\CRU\DORA\SYSTEM"
        Me.fsw.SynchronizingObject = Me
        '
        'MainTable
        '
        Me.MainTable.ColumnCount = 1
        Me.MainTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTable.Controls.Add(Me.SearchTable, 0, 0)
        Me.MainTable.Controls.Add(Me.lblCount, 0, 2)
        Me.MainTable.Controls.Add(Me.dgvStats, 0, 1)
        Me.MainTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTable.Location = New System.Drawing.Point(0, 0)
        Me.MainTable.Margin = New System.Windows.Forms.Padding(4)
        Me.MainTable.Name = "MainTable"
        Me.MainTable.RowCount = 4
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MainTable.Size = New System.Drawing.Size(1680, 878)
        Me.MainTable.TabIndex = 199
        '
        'SearchTable
        '
        Me.SearchTable.ColumnCount = 15
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.SearchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SearchTable.Controls.Add(Me.lblText, 9, 0)
        Me.SearchTable.Controls.Add(Me.txtFind, 9, 1)
        Me.SearchTable.Controls.Add(Me.lblDates, 0, 0)
        Me.SearchTable.Controls.Add(Me.cmbFrom, 0, 1)
        Me.SearchTable.Controls.Add(Me.cmbTo, 1, 1)
        Me.SearchTable.Controls.Add(Me.lblIntervention, 2, 0)
        Me.SearchTable.Controls.Add(Me.cmbTypeOfInt, 2, 1)
        Me.SearchTable.Controls.Add(Me.cmbCMInt, 7, 1)
        Me.SearchTable.Controls.Add(Me.lblPlace, 3, 0)
        Me.SearchTable.Controls.Add(Me.cmbArro, 6, 1)
        Me.SearchTable.Controls.Add(Me.lblDrug, 4, 0)
        Me.SearchTable.Controls.Add(Me.cmbCity, 5, 1)
        Me.SearchTable.Controls.Add(Me.lblCity, 5, 0)
        Me.SearchTable.Controls.Add(Me.cmbDrug, 4, 1)
        Me.SearchTable.Controls.Add(Me.lblArro, 6, 0)
        Me.SearchTable.Controls.Add(Me.cmbTypeOfPlace, 3, 1)
        Me.SearchTable.Controls.Add(Me.btnRefresh, 11, 1)
        Me.SearchTable.Controls.Add(Me.btnSearch, 10, 1)
        Me.SearchTable.Controls.Add(Me.lblCounter, 14, 1)
        Me.SearchTable.Controls.Add(Me.btnDown, 12, 1)
        Me.SearchTable.Controls.Add(Me.btnUp, 13, 1)
        Me.SearchTable.Controls.Add(Me.lblManager, 7, 0)
        Me.SearchTable.Controls.Add(Me.btnAddFilters, 8, 1)
        Me.SearchTable.Location = New System.Drawing.Point(4, 4)
        Me.SearchTable.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchTable.Name = "SearchTable"
        Me.SearchTable.RowCount = 2
        Me.SearchTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.SearchTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.SearchTable.Size = New System.Drawing.Size(1672, 67)
        Me.SearchTable.TabIndex = 201
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(1114, 0)
        Me.lblText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.lblText.Size = New System.Drawing.Size(40, 28)
        Me.lblText.TabIndex = 212
        Me.lblText.Text = "Text"
        '
        'txtFind
        '
        Me.txtFind.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFind.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtFind.Location = New System.Drawing.Point(1112, 32)
        Me.txtFind.Margin = New System.Windows.Forms.Padding(2, 2, 2, 4)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFind.Size = New System.Drawing.Size(116, 32)
        Me.txtFind.TabIndex = 208
        '
        'lblDates
        '
        Me.lblDates.AutoSize = True
        Me.lblDates.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDates.Location = New System.Drawing.Point(4, 0)
        Me.lblDates.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDates.Name = "lblDates"
        Me.lblDates.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.lblDates.Size = New System.Drawing.Size(51, 28)
        Me.lblDates.TabIndex = 200
        Me.lblDates.Text = "Dates"
        '
        'lblIntervention
        '
        Me.lblIntervention.AutoSize = True
        Me.lblIntervention.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntervention.Location = New System.Drawing.Point(144, 0)
        Me.lblIntervention.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIntervention.Name = "lblIntervention"
        Me.lblIntervention.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.lblIntervention.Size = New System.Drawing.Size(99, 28)
        Me.lblIntervention.TabIndex = 202
        Me.lblIntervention.Text = "Intervention"
        '
        'lblPlace
        '
        Me.lblPlace.AutoSize = True
        Me.lblPlace.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlace.Location = New System.Drawing.Point(304, 0)
        Me.lblPlace.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlace.Name = "lblPlace"
        Me.lblPlace.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.lblPlace.Size = New System.Drawing.Size(47, 28)
        Me.lblPlace.TabIndex = 203
        Me.lblPlace.Text = "Place"
        '
        'lblDrug
        '
        Me.lblDrug.AutoSize = True
        Me.lblDrug.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrug.Location = New System.Drawing.Point(434, 0)
        Me.lblDrug.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDrug.Name = "lblDrug"
        Me.lblDrug.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.lblDrug.Size = New System.Drawing.Size(44, 28)
        Me.lblDrug.TabIndex = 204
        Me.lblDrug.Text = "Drug"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(594, 0)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.lblCity.Size = New System.Drawing.Size(37, 28)
        Me.lblCity.TabIndex = 205
        Me.lblCity.Text = "City"
        '
        'lblArro
        '
        Me.lblArro.AutoSize = True
        Me.lblArro.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArro.Location = New System.Drawing.Point(754, 0)
        Me.lblArro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArro.Name = "lblArro"
        Me.lblArro.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.lblArro.Size = New System.Drawing.Size(41, 28)
        Me.lblArro.TabIndex = 206
        Me.lblArro.Text = "Arro"
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
        Me.btnRefresh.Location = New System.Drawing.Point(1274, 30)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 18)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(32, 32)
        Me.btnRefresh.TabIndex = 200
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnSearch.IconColor = System.Drawing.Color.Black
        Me.btnSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearch.IconSize = 25
        Me.btnSearch.Location = New System.Drawing.Point(1234, 30)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 32)
        Me.btnSearch.TabIndex = 200
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(1353, 30)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Padding = New System.Windows.Forms.Padding(5, 3, 0, 0)
        Me.lblCounter.Size = New System.Drawing.Size(83, 27)
        Me.lblCounter.TabIndex = 209
        Me.lblCounter.Text = "Counter"
        Me.lblCounter.Visible = False
        '
        'btnDown
        '
        Me.btnDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDown.FlatAppearance.BorderSize = 0
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.IconChar = FontAwesome.Sharp.IconChar.ChevronDown
        Me.btnDown.IconColor = System.Drawing.Color.Black
        Me.btnDown.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDown.IconSize = 20
        Me.btnDown.Location = New System.Drawing.Point(1310, 30)
        Me.btnDown.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnDown.Size = New System.Drawing.Size(20, 32)
        Me.btnDown.TabIndex = 210
        Me.btnDown.UseVisualStyleBackColor = True
        Me.btnDown.Visible = False
        '
        'btnUp
        '
        Me.btnUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUp.FlatAppearance.BorderSize = 0
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.IconChar = FontAwesome.Sharp.IconChar.ChevronUp
        Me.btnUp.IconColor = System.Drawing.Color.Black
        Me.btnUp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUp.IconSize = 20
        Me.btnUp.Location = New System.Drawing.Point(1330, 30)
        Me.btnUp.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnUp.Size = New System.Drawing.Size(20, 32)
        Me.btnUp.TabIndex = 211
        Me.btnUp.UseVisualStyleBackColor = True
        Me.btnUp.Visible = False
        '
        'lblManager
        '
        Me.lblManager.AutoSize = True
        Me.lblManager.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManager.Location = New System.Drawing.Point(914, 0)
        Me.lblManager.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManager.Name = "lblManager"
        Me.lblManager.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.lblManager.Size = New System.Drawing.Size(73, 28)
        Me.lblManager.TabIndex = 207
        Me.lblManager.Text = "Manager"
        '
        'btnAddFilters
        '
        Me.btnAddFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddFilters.FlatAppearance.BorderSize = 0
        Me.btnAddFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFilters.IconChar = FontAwesome.Sharp.IconChar.Filter
        Me.btnAddFilters.IconColor = System.Drawing.Color.Black
        Me.btnAddFilters.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddFilters.IconSize = 25
        Me.btnAddFilters.Location = New System.Drawing.Point(1074, 30)
        Me.btnAddFilters.Margin = New System.Windows.Forms.Padding(4, 0, 4, 18)
        Me.btnAddFilters.Name = "btnAddFilters"
        Me.btnAddFilters.Size = New System.Drawing.Size(32, 32)
        Me.btnAddFilters.TabIndex = 213
        Me.btnAddFilters.UseVisualStyleBackColor = True
        '
        'dgvStats
        '
        Me.dgvStats.AllowUserToAddRows = False
        Me.dgvStats.AllowUserToDeleteRows = False
        Me.dgvStats.AllowUserToResizeRows = False
        Me.dgvStats.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvStats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStats.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStats.ColumnHeadersHeight = 29
        Me.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStats.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStats.EnableHeadersVisualStyles = False
        Me.dgvStats.Location = New System.Drawing.Point(5, 80)
        Me.dgvStats.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvStats.MultiSelect = False
        Me.dgvStats.Name = "dgvStats"
        Me.dgvStats.ReadOnly = True
        Me.dgvStats.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStats.RowHeadersVisible = False
        Me.dgvStats.RowHeadersWidth = 51
        Me.dgvStats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.dgvStats.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStats.RowTemplate.Height = 30
        Me.dgvStats.RowTemplate.ReadOnly = True
        Me.dgvStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStats.Size = New System.Drawing.Size(1670, 743)
        Me.dgvStats.TabIndex = 200
        '
        'RCMenuHeader
        '
        Me.RCMenuHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCMenuHeader.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RCMenuHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAllInts, Me.mnAllFacts, Me.mnAllSamples, Me.mnAllCRUReport, Me.mnAllNICCReport, Me.mnAllCase})
        Me.RCMenuHeader.Name = "RCMenu"
        Me.RCMenuHeader.ShowCheckMargin = True
        Me.RCMenuHeader.ShowImageMargin = False
        Me.RCMenuHeader.Size = New System.Drawing.Size(200, 172)
        '
        'mnAllInts
        '
        Me.mnAllInts.Checked = True
        Me.mnAllInts.CheckOnClick = True
        Me.mnAllInts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnAllInts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnDateInt, Me.mnAdressInt, Me.mnZipInt, Me.mnCityInt})
        Me.mnAllInts.Name = "mnAllInts"
        Me.mnAllInts.Size = New System.Drawing.Size(199, 28)
        Me.mnAllInts.Text = "AllInts"
        '
        'mnDateInt
        '
        Me.mnDateInt.Checked = True
        Me.mnDateInt.CheckOnClick = True
        Me.mnDateInt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnDateInt.Name = "mnDateInt"
        Me.mnDateInt.Size = New System.Drawing.Size(173, 28)
        Me.mnDateInt.Text = "DateInt"
        '
        'mnAdressInt
        '
        Me.mnAdressInt.Checked = True
        Me.mnAdressInt.CheckOnClick = True
        Me.mnAdressInt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnAdressInt.Name = "mnAdressInt"
        Me.mnAdressInt.Size = New System.Drawing.Size(173, 28)
        Me.mnAdressInt.Text = "AdressInt"
        '
        'mnZipInt
        '
        Me.mnZipInt.Checked = True
        Me.mnZipInt.CheckOnClick = True
        Me.mnZipInt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnZipInt.Name = "mnZipInt"
        Me.mnZipInt.Size = New System.Drawing.Size(173, 28)
        Me.mnZipInt.Text = "ZipInt"
        '
        'mnCityInt
        '
        Me.mnCityInt.Checked = True
        Me.mnCityInt.CheckOnClick = True
        Me.mnCityInt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnCityInt.Name = "mnCityInt"
        Me.mnCityInt.Size = New System.Drawing.Size(173, 28)
        Me.mnCityInt.Text = "CityInt"
        '
        'mnAllFacts
        '
        Me.mnAllFacts.Checked = True
        Me.mnAllFacts.CheckOnClick = True
        Me.mnAllFacts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnAllFacts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnDateFacts, Me.mnAdressFacts, Me.mnZipFacts, Me.mnCityFacts})
        Me.mnAllFacts.Name = "mnAllFacts"
        Me.mnAllFacts.Size = New System.Drawing.Size(199, 28)
        Me.mnAllFacts.Text = "AllFacts"
        '
        'mnDateFacts
        '
        Me.mnDateFacts.Checked = True
        Me.mnDateFacts.CheckOnClick = True
        Me.mnDateFacts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnDateFacts.Name = "mnDateFacts"
        Me.mnDateFacts.Size = New System.Drawing.Size(191, 28)
        Me.mnDateFacts.Text = "DateFacts"
        '
        'mnAdressFacts
        '
        Me.mnAdressFacts.Checked = True
        Me.mnAdressFacts.CheckOnClick = True
        Me.mnAdressFacts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnAdressFacts.Name = "mnAdressFacts"
        Me.mnAdressFacts.Size = New System.Drawing.Size(191, 28)
        Me.mnAdressFacts.Text = "AdressFacts"
        '
        'mnZipFacts
        '
        Me.mnZipFacts.Checked = True
        Me.mnZipFacts.CheckOnClick = True
        Me.mnZipFacts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnZipFacts.Name = "mnZipFacts"
        Me.mnZipFacts.Size = New System.Drawing.Size(191, 28)
        Me.mnZipFacts.Text = "ZipFacts"
        '
        'mnCityFacts
        '
        Me.mnCityFacts.Checked = True
        Me.mnCityFacts.CheckOnClick = True
        Me.mnCityFacts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnCityFacts.Name = "mnCityFacts"
        Me.mnCityFacts.Size = New System.Drawing.Size(191, 28)
        Me.mnCityFacts.Text = "CityFacts"
        '
        'mnAllSamples
        '
        Me.mnAllSamples.Checked = True
        Me.mnAllSamples.CheckOnClick = True
        Me.mnAllSamples.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnAllSamples.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnSamplesT, Me.mnSamplesN, Me.mnSamplesD, Me.mnSamplesC})
        Me.mnAllSamples.Name = "mnAllSamples"
        Me.mnAllSamples.Size = New System.Drawing.Size(199, 28)
        Me.mnAllSamples.Text = "AllSamples"
        '
        'mnSamplesT
        '
        Me.mnSamplesT.Checked = True
        Me.mnSamplesT.CheckOnClick = True
        Me.mnSamplesT.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnSamplesT.Name = "mnSamplesT"
        Me.mnSamplesT.Size = New System.Drawing.Size(176, 28)
        Me.mnSamplesT.Text = "SamplesT"
        '
        'mnSamplesN
        '
        Me.mnSamplesN.Checked = True
        Me.mnSamplesN.CheckOnClick = True
        Me.mnSamplesN.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnSamplesN.Name = "mnSamplesN"
        Me.mnSamplesN.Size = New System.Drawing.Size(176, 28)
        Me.mnSamplesN.Text = "SamplesN"
        '
        'mnSamplesD
        '
        Me.mnSamplesD.Checked = True
        Me.mnSamplesD.CheckOnClick = True
        Me.mnSamplesD.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnSamplesD.Name = "mnSamplesD"
        Me.mnSamplesD.Size = New System.Drawing.Size(176, 28)
        Me.mnSamplesD.Text = "SamplesD"
        '
        'mnSamplesC
        '
        Me.mnSamplesC.Checked = True
        Me.mnSamplesC.CheckOnClick = True
        Me.mnSamplesC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnSamplesC.Name = "mnSamplesC"
        Me.mnSamplesC.Size = New System.Drawing.Size(176, 28)
        Me.mnSamplesC.Text = "SamplesC"
        '
        'mnAllCRUReport
        '
        Me.mnAllCRUReport.Checked = True
        Me.mnAllCRUReport.CheckOnClick = True
        Me.mnAllCRUReport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnAllCRUReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnCRUReportN, Me.mnCRUReportD})
        Me.mnAllCRUReport.Name = "mnAllCRUReport"
        Me.mnAllCRUReport.Size = New System.Drawing.Size(199, 28)
        Me.mnAllCRUReport.Text = "AllCRUReport"
        '
        'mnCRUReportN
        '
        Me.mnCRUReportN.Checked = True
        Me.mnCRUReportN.CheckOnClick = True
        Me.mnCRUReportN.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnCRUReportN.Name = "mnCRUReportN"
        Me.mnCRUReportN.Size = New System.Drawing.Size(199, 28)
        Me.mnCRUReportN.Text = "CRUReportN"
        '
        'mnCRUReportD
        '
        Me.mnCRUReportD.Checked = True
        Me.mnCRUReportD.CheckOnClick = True
        Me.mnCRUReportD.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnCRUReportD.Name = "mnCRUReportD"
        Me.mnCRUReportD.Size = New System.Drawing.Size(199, 28)
        Me.mnCRUReportD.Text = "CRUReportD"
        '
        'mnAllNICCReport
        '
        Me.mnAllNICCReport.Checked = True
        Me.mnAllNICCReport.CheckOnClick = True
        Me.mnAllNICCReport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnAllNICCReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnNICCReportN, Me.mnNICCReportD, Me.mnNICCReportC})
        Me.mnAllNICCReport.Name = "mnAllNICCReport"
        Me.mnAllNICCReport.Size = New System.Drawing.Size(199, 28)
        Me.mnAllNICCReport.Text = "AllNICCReport"
        '
        'mnNICCReportN
        '
        Me.mnNICCReportN.Checked = True
        Me.mnNICCReportN.CheckOnClick = True
        Me.mnNICCReportN.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnNICCReportN.Name = "mnNICCReportN"
        Me.mnNICCReportN.Size = New System.Drawing.Size(204, 28)
        Me.mnNICCReportN.Text = "NICCReportN"
        '
        'mnNICCReportD
        '
        Me.mnNICCReportD.Checked = True
        Me.mnNICCReportD.CheckOnClick = True
        Me.mnNICCReportD.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnNICCReportD.Name = "mnNICCReportD"
        Me.mnNICCReportD.Size = New System.Drawing.Size(204, 28)
        Me.mnNICCReportD.Text = "NICCReportD"
        '
        'mnNICCReportC
        '
        Me.mnNICCReportC.Checked = True
        Me.mnNICCReportC.CheckOnClick = True
        Me.mnNICCReportC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnNICCReportC.Name = "mnNICCReportC"
        Me.mnNICCReportC.Size = New System.Drawing.Size(204, 28)
        Me.mnNICCReportC.Text = "NICCReportC"
        '
        'mnAllCase
        '
        Me.mnAllCase.Checked = True
        Me.mnAllCase.CheckOnClick = True
        Me.mnAllCase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnAllCase.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnUnit, Me.mnFileNum, Me.mnReportNum, Me.mnRIONum, Me.mnONNum, Me.mnSIENANum, Me.mnNSP, Me.mnLang, Me.mnCMExt})
        Me.mnAllCase.Name = "mnAllCase"
        Me.mnAllCase.Size = New System.Drawing.Size(199, 28)
        Me.mnAllCase.Text = "AllCase"
        '
        'mnUnit
        '
        Me.mnUnit.Checked = True
        Me.mnUnit.CheckOnClick = True
        Me.mnUnit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnUnit.Name = "mnUnit"
        Me.mnUnit.Size = New System.Drawing.Size(191, 28)
        Me.mnUnit.Text = "Unit"
        '
        'mnFileNum
        '
        Me.mnFileNum.Checked = True
        Me.mnFileNum.CheckOnClick = True
        Me.mnFileNum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnFileNum.Name = "mnFileNum"
        Me.mnFileNum.Size = New System.Drawing.Size(191, 28)
        Me.mnFileNum.Text = "FileNum"
        '
        'mnReportNum
        '
        Me.mnReportNum.Checked = True
        Me.mnReportNum.CheckOnClick = True
        Me.mnReportNum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnReportNum.Name = "mnReportNum"
        Me.mnReportNum.Size = New System.Drawing.Size(191, 28)
        Me.mnReportNum.Text = "ReportNum"
        '
        'mnRIONum
        '
        Me.mnRIONum.Checked = True
        Me.mnRIONum.CheckOnClick = True
        Me.mnRIONum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnRIONum.Name = "mnRIONum"
        Me.mnRIONum.Size = New System.Drawing.Size(191, 28)
        Me.mnRIONum.Text = "RIONum"
        '
        'mnONNum
        '
        Me.mnONNum.Checked = True
        Me.mnONNum.CheckOnClick = True
        Me.mnONNum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnONNum.Name = "mnONNum"
        Me.mnONNum.Size = New System.Drawing.Size(191, 28)
        Me.mnONNum.Text = "ONNum"
        '
        'mnSIENANum
        '
        Me.mnSIENANum.Checked = True
        Me.mnSIENANum.CheckOnClick = True
        Me.mnSIENANum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnSIENANum.Name = "mnSIENANum"
        Me.mnSIENANum.Size = New System.Drawing.Size(191, 28)
        Me.mnSIENANum.Text = "SIENANum"
        '
        'mnNSP
        '
        Me.mnNSP.Checked = True
        Me.mnNSP.CheckOnClick = True
        Me.mnNSP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnNSP.Name = "mnNSP"
        Me.mnNSP.Size = New System.Drawing.Size(191, 28)
        Me.mnNSP.Text = "NSP"
        '
        'mnLang
        '
        Me.mnLang.Checked = True
        Me.mnLang.CheckOnClick = True
        Me.mnLang.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnLang.Name = "mnLang"
        Me.mnLang.Size = New System.Drawing.Size(191, 28)
        Me.mnLang.Text = "Lang"
        '
        'mnCMExt
        '
        Me.mnCMExt.Checked = True
        Me.mnCMExt.CheckOnClick = True
        Me.mnCMExt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnCMExt.Name = "mnCMExt"
        Me.mnCMExt.Size = New System.Drawing.Size(191, 28)
        Me.mnCMExt.Text = "CMExt"
        '
        'FilterMenu
        '
        Me.FilterMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FilterMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnInterventionDone, Me.mnCRUOnSite})
        Me.FilterMenu.Name = "FilterMenu"
        Me.FilterMenu.Size = New System.Drawing.Size(237, 60)
        '
        'mnInterventionDone
        '
        Me.mnInterventionDone.CheckOnClick = True
        Me.mnInterventionDone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnInterventionDone.Name = "mnInterventionDone"
        Me.mnInterventionDone.Size = New System.Drawing.Size(236, 28)
        Me.mnInterventionDone.Text = "InterventionsDone"
        '
        'mnCRUOnSite
        '
        Me.mnCRUOnSite.CheckOnClick = True
        Me.mnCRUOnSite.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnCRUOnSite.Name = "mnCRUOnSite"
        Me.mnCRUOnSite.Size = New System.Drawing.Size(236, 28)
        Me.mnCRUOnSite.Text = "CRUOnSite"
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1680, 878)
        Me.Controls.Add(Me.MainTable)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSearch"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DRUGS_INTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RCMenuStats.ResumeLayout(False)
        CType(Me.fsw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainTable.ResumeLayout(False)
        Me.MainTable.PerformLayout()
        Me.SearchTable.ResumeLayout(False)
        Me.SearchTable.PerformLayout()
        CType(Me.dgvStats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RCMenuHeader.ResumeLayout(False)
        Me.FilterMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCount As Label
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents cmbCMInt As ComboBox
    Friend WithEvents cmbDrug As ComboBox
    Friend WithEvents cmbTypeOfPlace As ComboBox
    Friend WithEvents cmbTypeOfInt As ComboBox
    Friend WithEvents cmbArro As ComboBox
    Friend WithEvents cmbFrom As ComboBox
    Friend WithEvents cmbTo As ComboBox
    Friend WithEvents DORADbDS As DORADbDS
    Friend WithEvents INTERVENTIONSBindingSource As BindingSource
    Friend WithEvents INTERVENTIONSTableAdapter As DORADbDSTableAdapters.INTERVENTIONSTableAdapter
    Friend WithEvents TableAdapterManager As DORADbDSTableAdapters.TableAdapterManager
    Friend WithEvents DRUGS_INTTableAdapter As DORADbDSTableAdapters.DRUGS_INTTableAdapter
    Friend WithEvents DRUGS_INTBindingSource As BindingSource
    Friend WithEvents CASESBindingSource As BindingSource
    Friend WithEvents CASESTableAdapter As DORADbDSTableAdapters.CASESTableAdapter
    Friend WithEvents RCMenuStats As ContextMenuStrip
    Friend WithEvents mnViewIntervention As ToolStripMenuItem
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents mnExportList As ToolStripMenuItem
    Friend WithEvents mnNL As ToolStripMenuItem
    Friend WithEvents mnFR As ToolStripMenuItem
    Friend WithEvents mnEN As ToolStripMenuItem
    Friend WithEvents fsw As IO.FileSystemWatcher
    Friend WithEvents MainTable As TableLayoutPanel
    Friend WithEvents dgvStats As DataGridView
    Friend WithEvents SearchTable As TableLayoutPanel
    Friend WithEvents lblDates As Label
    Friend WithEvents lblIntervention As Label
    Friend WithEvents lblPlace As Label
    Friend WithEvents lblDrug As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblArro As Label
    Friend WithEvents lblManager As Label
    Friend WithEvents btnSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents RCMenuHeader As ContextMenuStrip
    Friend WithEvents mnAllInts As ToolStripMenuItem
    Friend WithEvents mnDateInt As ToolStripMenuItem
    Friend WithEvents mnAdressInt As ToolStripMenuItem
    Friend WithEvents mnZipInt As ToolStripMenuItem
    Friend WithEvents mnCityInt As ToolStripMenuItem
    Friend WithEvents mnAllFacts As ToolStripMenuItem
    Friend WithEvents mnDateFacts As ToolStripMenuItem
    Friend WithEvents mnAdressFacts As ToolStripMenuItem
    Friend WithEvents mnZipFacts As ToolStripMenuItem
    Friend WithEvents mnCityFacts As ToolStripMenuItem
    Friend WithEvents mnAllCRUReport As ToolStripMenuItem
    Friend WithEvents mnCRUReportN As ToolStripMenuItem
    Friend WithEvents mnCRUReportD As ToolStripMenuItem
    Friend WithEvents mnAllNICCReport As ToolStripMenuItem
    Friend WithEvents mnNICCReportN As ToolStripMenuItem
    Friend WithEvents mnNICCReportD As ToolStripMenuItem
    Friend WithEvents mnNICCReportC As ToolStripMenuItem
    Friend WithEvents mnAllSamples As ToolStripMenuItem
    Friend WithEvents mnSamplesT As ToolStripMenuItem
    Friend WithEvents mnSamplesN As ToolStripMenuItem
    Friend WithEvents mnSamplesD As ToolStripMenuItem
    Friend WithEvents mnSamplesC As ToolStripMenuItem
    Friend WithEvents mnAllCase As ToolStripMenuItem
    Friend WithEvents mnUnit As ToolStripMenuItem
    Friend WithEvents mnFileNum As ToolStripMenuItem
    Friend WithEvents mnReportNum As ToolStripMenuItem
    Friend WithEvents mnRIONum As ToolStripMenuItem
    Friend WithEvents mnONNum As ToolStripMenuItem
    Friend WithEvents mnSIENANum As ToolStripMenuItem
    Friend WithEvents mnNSP As ToolStripMenuItem
    Friend WithEvents mnLang As ToolStripMenuItem
    Friend WithEvents mnCMExt As ToolStripMenuItem
    Friend WithEvents txtFind As TextBox
    Friend WithEvents lblCounter As Label
    Friend WithEvents btnDown As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUp As FontAwesome.Sharp.IconButton
    Friend WithEvents lblText As Label
    Friend WithEvents btnAddFilters As FontAwesome.Sharp.IconButton
    Friend WithEvents FilterMenu As ContextMenuStrip
    Friend WithEvents mnInterventionDone As ToolStripMenuItem
    Friend WithEvents mnCRUOnSite As ToolStripMenuItem
End Class

