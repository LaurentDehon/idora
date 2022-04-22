<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewInt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewInt))
        Me.lblDateInt = New System.Windows.Forms.Label()
        Me.lblAdressInt = New System.Windows.Forms.Label()
        Me.lblAdressFacts = New System.Windows.Forms.Label()
        Me.lblDateFacts = New System.Windows.Forms.Label()
        Me.lblTypeOfPlace = New System.Windows.Forms.Label()
        Me.cmbTypeOfPlace = New System.Windows.Forms.ComboBox()
        Me.cmbTypeOfInt = New System.Windows.Forms.ComboBox()
        Me.lblTypeOfInt = New System.Windows.Forms.Label()
        Me.lblCaseName = New System.Windows.Forms.Label()
        Me.cmbCaseName = New System.Windows.Forms.ComboBox()
        Me.CASESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DORADbDS = New DORA.DORADbDS()
        Me.INTERVENTIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INTERVENTIONSTableAdapter = New DORA.DORADbDSTableAdapters.INTERVENTIONSTableAdapter()
        Me.TableAdapterManager = New DORA.DORADbDSTableAdapters.TableAdapterManager()
        Me.lblInt = New System.Windows.Forms.Label()
        Me.cmbInt = New System.Windows.Forms.ComboBox()
        Me.txtDateInt = New System.Windows.Forms.DateTimePicker()
        Me.txtAdressInt = New System.Windows.Forms.TextBox()
        Me.cmbCityInt = New System.Windows.Forms.ComboBox()
        Me.cmbCityFacts = New System.Windows.Forms.ComboBox()
        Me.txtAdressFacts = New System.Windows.Forms.TextBox()
        Me.txtDateFacts = New System.Windows.Forms.DateTimePicker()
        Me.CASESTableAdapter = New DORA.DORADbDSTableAdapters.CASESTableAdapter()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtZipInt = New System.Windows.Forms.MaskedTextBox()
        Me.txtZipFacts = New System.Windows.Forms.MaskedTextBox()
        Me.RCMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnIntToFacts = New FontAwesome.Sharp.IconButton()
        Me.btnFactsToInt = New FontAwesome.Sharp.IconButton()
        Me.btnCancel = New FontAwesome.Sharp.IconButton()
        Me.btnOk = New FontAwesome.Sharp.IconButton()
        Me.btnRemondis = New FontAwesome.Sharp.IconButton()
        Me.btnSGS = New FontAwesome.Sharp.IconButton()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RCMenu.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDateInt
        '
        Me.lblDateInt.AutoSize = True
        Me.lblDateInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateInt.Location = New System.Drawing.Point(16, 180)
        Me.lblDateInt.Name = "lblDateInt"
        Me.lblDateInt.Size = New System.Drawing.Size(159, 24)
        Me.lblDateInt.TabIndex = 46
        Me.lblDateInt.Text = "Date Intervention"
        '
        'lblAdressInt
        '
        Me.lblAdressInt.AutoSize = True
        Me.lblAdressInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdressInt.Location = New System.Drawing.Point(16, 220)
        Me.lblAdressInt.Name = "lblAdressInt"
        Me.lblAdressInt.Size = New System.Drawing.Size(175, 24)
        Me.lblAdressInt.TabIndex = 47
        Me.lblAdressInt.Text = "Adress Intervention"
        '
        'lblAdressFacts
        '
        Me.lblAdressFacts.AutoSize = True
        Me.lblAdressFacts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdressFacts.Location = New System.Drawing.Point(16, 380)
        Me.lblAdressFacts.Name = "lblAdressFacts"
        Me.lblAdressFacts.Size = New System.Drawing.Size(112, 24)
        Me.lblAdressFacts.TabIndex = 51
        Me.lblAdressFacts.Text = "Adress Facts"
        '
        'lblDateFacts
        '
        Me.lblDateFacts.AutoSize = True
        Me.lblDateFacts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateFacts.Location = New System.Drawing.Point(16, 340)
        Me.lblDateFacts.Name = "lblDateFacts"
        Me.lblDateFacts.Size = New System.Drawing.Size(96, 24)
        Me.lblDateFacts.TabIndex = 50
        Me.lblDateFacts.Text = "Date Facts"
        '
        'lblTypeOfPlace
        '
        Me.lblTypeOfPlace.AutoSize = True
        Me.lblTypeOfPlace.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeOfPlace.Location = New System.Drawing.Point(16, 100)
        Me.lblTypeOfPlace.Name = "lblTypeOfPlace"
        Me.lblTypeOfPlace.Size = New System.Drawing.Size(123, 24)
        Me.lblTypeOfPlace.TabIndex = 42
        Me.lblTypeOfPlace.Text = "Type Of Place"
        '
        'cmbTypeOfPlace
        '
        Me.cmbTypeOfPlace.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTypeOfPlace.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypeOfPlace.FormattingEnabled = True
        Me.cmbTypeOfPlace.Location = New System.Drawing.Point(240, 96)
        Me.cmbTypeOfPlace.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTypeOfPlace.Name = "cmbTypeOfPlace"
        Me.cmbTypeOfPlace.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTypeOfPlace.Size = New System.Drawing.Size(296, 32)
        Me.cmbTypeOfPlace.TabIndex = 2
        '
        'cmbTypeOfInt
        '
        Me.cmbTypeOfInt.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTypeOfInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypeOfInt.FormattingEnabled = True
        Me.cmbTypeOfInt.Location = New System.Drawing.Point(240, 56)
        Me.cmbTypeOfInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTypeOfInt.Name = "cmbTypeOfInt"
        Me.cmbTypeOfInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTypeOfInt.Size = New System.Drawing.Size(296, 32)
        Me.cmbTypeOfInt.TabIndex = 1
        '
        'lblTypeOfInt
        '
        Me.lblTypeOfInt.AutoSize = True
        Me.lblTypeOfInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeOfInt.Location = New System.Drawing.Point(16, 60)
        Me.lblTypeOfInt.Name = "lblTypeOfInt"
        Me.lblTypeOfInt.Size = New System.Drawing.Size(183, 24)
        Me.lblTypeOfInt.TabIndex = 41
        Me.lblTypeOfInt.Text = "Type Of Intervention"
        '
        'lblCaseName
        '
        Me.lblCaseName.AutoSize = True
        Me.lblCaseName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaseName.Location = New System.Drawing.Point(16, 20)
        Me.lblCaseName.Name = "lblCaseName"
        Me.lblCaseName.Size = New System.Drawing.Size(103, 24)
        Me.lblCaseName.TabIndex = 40
        Me.lblCaseName.Text = "Case Name"
        '
        'cmbCaseName
        '
        Me.cmbCaseName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCaseName.DataSource = Me.CASESBindingSource
        Me.cmbCaseName.DisplayMember = "CASE NAME"
        Me.cmbCaseName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCaseName.FormattingEnabled = True
        Me.cmbCaseName.Location = New System.Drawing.Point(240, 16)
        Me.cmbCaseName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCaseName.Name = "cmbCaseName"
        Me.cmbCaseName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCaseName.Size = New System.Drawing.Size(296, 32)
        Me.cmbCaseName.TabIndex = 0
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
        'lblInt
        '
        Me.lblInt.AutoSize = True
        Me.lblInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInt.Location = New System.Drawing.Point(16, 140)
        Me.lblInt.Name = "lblInt"
        Me.lblInt.Size = New System.Drawing.Size(114, 24)
        Me.lblInt.TabIndex = 46
        Me.lblInt.Text = "Intervention"
        '
        'cmbInt
        '
        Me.cmbInt.BackColor = System.Drawing.SystemColors.Window
        Me.cmbInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInt.FormattingEnabled = True
        Me.cmbInt.Location = New System.Drawing.Point(240, 136)
        Me.cmbInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbInt.Name = "cmbInt"
        Me.cmbInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbInt.Size = New System.Drawing.Size(296, 32)
        Me.cmbInt.TabIndex = 3
        '
        'txtDateInt
        '
        Me.txtDateInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateInt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDateInt.Location = New System.Drawing.Point(240, 176)
        Me.txtDateInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDateInt.Name = "txtDateInt"
        Me.txtDateInt.Size = New System.Drawing.Size(296, 32)
        Me.txtDateInt.TabIndex = 4
        '
        'txtAdressInt
        '
        Me.txtAdressInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdressInt.Location = New System.Drawing.Point(240, 256)
        Me.txtAdressInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdressInt.Name = "txtAdressInt"
        Me.txtAdressInt.Size = New System.Drawing.Size(296, 32)
        Me.txtAdressInt.TabIndex = 7
        '
        'cmbCityInt
        '
        Me.cmbCityInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCityInt.FormattingEnabled = True
        Me.cmbCityInt.Location = New System.Drawing.Point(240, 216)
        Me.cmbCityInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCityInt.Name = "cmbCityInt"
        Me.cmbCityInt.Size = New System.Drawing.Size(232, 32)
        Me.cmbCityInt.TabIndex = 6
        '
        'cmbCityFacts
        '
        Me.cmbCityFacts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCityFacts.FormattingEnabled = True
        Me.cmbCityFacts.Location = New System.Drawing.Point(240, 376)
        Me.cmbCityFacts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCityFacts.Name = "cmbCityFacts"
        Me.cmbCityFacts.Size = New System.Drawing.Size(232, 32)
        Me.cmbCityFacts.TabIndex = 10
        '
        'txtAdressFacts
        '
        Me.txtAdressFacts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdressFacts.Location = New System.Drawing.Point(240, 416)
        Me.txtAdressFacts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdressFacts.Name = "txtAdressFacts"
        Me.txtAdressFacts.Size = New System.Drawing.Size(296, 32)
        Me.txtAdressFacts.TabIndex = 11
        '
        'txtDateFacts
        '
        Me.txtDateFacts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFacts.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDateFacts.Location = New System.Drawing.Point(240, 336)
        Me.txtDateFacts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDateFacts.Name = "txtDateFacts"
        Me.txtDateFacts.Size = New System.Drawing.Size(296, 32)
        Me.txtDateFacts.TabIndex = 8
        '
        'CASESTableAdapter
        '
        Me.CASESTableAdapter.ClearBeforeFill = True
        '
        'txtZipInt
        '
        Me.txtZipInt.CausesValidation = False
        Me.txtZipInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipInt.Location = New System.Drawing.Point(480, 216)
        Me.txtZipInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtZipInt.Mask = "0000"
        Me.txtZipInt.Name = "txtZipInt"
        Me.txtZipInt.Size = New System.Drawing.Size(56, 32)
        Me.txtZipInt.TabIndex = 5
        Me.txtZipInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtZipFacts
        '
        Me.txtZipFacts.CausesValidation = False
        Me.txtZipFacts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipFacts.Location = New System.Drawing.Point(480, 376)
        Me.txtZipFacts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtZipFacts.Mask = "0000"
        Me.txtZipFacts.Name = "txtZipFacts"
        Me.txtZipFacts.Size = New System.Drawing.Size(56, 32)
        Me.txtZipFacts.TabIndex = 9
        Me.txtZipFacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.btnSGS)
        Me.pnlMain.Controls.Add(Me.btnRemondis)
        Me.pnlMain.Controls.Add(Me.btnIntToFacts)
        Me.pnlMain.Controls.Add(Me.btnFactsToInt)
        Me.pnlMain.Controls.Add(Me.btnCancel)
        Me.pnlMain.Controls.Add(Me.btnOk)
        Me.pnlMain.Controls.Add(Me.lblCaseName)
        Me.pnlMain.Controls.Add(Me.lblTypeOfInt)
        Me.pnlMain.Controls.Add(Me.txtZipFacts)
        Me.pnlMain.Controls.Add(Me.cmbTypeOfInt)
        Me.pnlMain.Controls.Add(Me.txtZipInt)
        Me.pnlMain.Controls.Add(Me.cmbTypeOfPlace)
        Me.pnlMain.Controls.Add(Me.cmbCityFacts)
        Me.pnlMain.Controls.Add(Me.lblTypeOfPlace)
        Me.pnlMain.Controls.Add(Me.lblAdressFacts)
        Me.pnlMain.Controls.Add(Me.cmbCaseName)
        Me.pnlMain.Controls.Add(Me.txtAdressFacts)
        Me.pnlMain.Controls.Add(Me.cmbInt)
        Me.pnlMain.Controls.Add(Me.lblDateFacts)
        Me.pnlMain.Controls.Add(Me.lblInt)
        Me.pnlMain.Controls.Add(Me.txtDateFacts)
        Me.pnlMain.Controls.Add(Me.txtDateInt)
        Me.pnlMain.Controls.Add(Me.cmbCityInt)
        Me.pnlMain.Controls.Add(Me.lblDateInt)
        Me.pnlMain.Controls.Add(Me.lblAdressInt)
        Me.pnlMain.Controls.Add(Me.txtAdressInt)
        Me.pnlMain.Location = New System.Drawing.Point(16, 16)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(552, 512)
        Me.pnlMain.TabIndex = 52
        '
        'btnIntToFacts
        '
        Me.btnIntToFacts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntToFacts.FlatAppearance.BorderSize = 0
        Me.btnIntToFacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIntToFacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntToFacts.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown
        Me.btnIntToFacts.IconColor = System.Drawing.Color.Black
        Me.btnIntToFacts.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnIntToFacts.IconSize = 30
        Me.btnIntToFacts.Location = New System.Drawing.Point(336, 296)
        Me.btnIntToFacts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIntToFacts.Name = "btnIntToFacts"
        Me.btnIntToFacts.Padding = New System.Windows.Forms.Padding(11, 14, 11, 10)
        Me.btnIntToFacts.Size = New System.Drawing.Size(32, 32)
        Me.btnIntToFacts.TabIndex = 149
        Me.btnIntToFacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIntToFacts.UseVisualStyleBackColor = False
        '
        'btnFactsToInt
        '
        Me.btnFactsToInt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFactsToInt.FlatAppearance.BorderSize = 0
        Me.btnFactsToInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFactsToInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactsToInt.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp
        Me.btnFactsToInt.IconColor = System.Drawing.Color.Black
        Me.btnFactsToInt.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFactsToInt.IconSize = 30
        Me.btnFactsToInt.Location = New System.Drawing.Point(304, 296)
        Me.btnFactsToInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFactsToInt.Name = "btnFactsToInt"
        Me.btnFactsToInt.Padding = New System.Windows.Forms.Padding(11, 14, 11, 10)
        Me.btnFactsToInt.Size = New System.Drawing.Size(32, 32)
        Me.btnFactsToInt.TabIndex = 102
        Me.btnFactsToInt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFactsToInt.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnCancel.IconColor = System.Drawing.Color.Black
        Me.btnCancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCancel.IconSize = 30
        Me.btnCancel.Location = New System.Drawing.Point(282, 472)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(27, 20)
        Me.btnCancel.TabIndex = 148
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnOk.IconColor = System.Drawing.Color.Black
        Me.btnOk.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOk.IconSize = 30
        Me.btnOk.Location = New System.Drawing.Point(240, 472)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(27, 20)
        Me.btnOk.TabIndex = 147
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnRemondis
        '
        Me.btnRemondis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemondis.FlatAppearance.BorderSize = 0
        Me.btnRemondis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemondis.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemondis.IconChar = FontAwesome.Sharp.IconChar.Registered
        Me.btnRemondis.IconColor = System.Drawing.Color.Black
        Me.btnRemondis.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRemondis.IconSize = 30
        Me.btnRemondis.Location = New System.Drawing.Point(240, 296)
        Me.btnRemondis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemondis.Name = "btnRemondis"
        Me.btnRemondis.Padding = New System.Windows.Forms.Padding(11, 14, 11, 10)
        Me.btnRemondis.Size = New System.Drawing.Size(32, 32)
        Me.btnRemondis.TabIndex = 150
        Me.btnRemondis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemondis.UseVisualStyleBackColor = False
        '
        'btnSGS
        '
        Me.btnSGS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSGS.FlatAppearance.BorderSize = 0
        Me.btnSGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSGS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSGS.IconChar = FontAwesome.Sharp.IconChar.Speakap
        Me.btnSGS.IconColor = System.Drawing.Color.Black
        Me.btnSGS.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSGS.IconSize = 30
        Me.btnSGS.Location = New System.Drawing.Point(272, 296)
        Me.btnSGS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSGS.Name = "btnSGS"
        Me.btnSGS.Padding = New System.Windows.Forms.Padding(11, 14, 11, 10)
        Me.btnSGS.Size = New System.Drawing.Size(32, 32)
        Me.btnSGS.TabIndex = 151
        Me.btnSGS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSGS.UseVisualStyleBackColor = False
        '
        'frmNewInt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 553)
        Me.Controls.Add(Me.pnlMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewInt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Intervention"
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RCMenu.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTypeOfPlace As Label
    Friend WithEvents cmbTypeOfPlace As ComboBox
    Friend WithEvents cmbTypeOfInt As ComboBox
    Friend WithEvents lblTypeOfInt As Label
    Friend WithEvents lblCaseName As Label
    Friend WithEvents cmbCaseName As ComboBox
    Friend WithEvents DORADbDS As DORADbDS
    Friend WithEvents INTERVENTIONSBindingSource As BindingSource
    Friend WithEvents INTERVENTIONSTableAdapter As DORADbDSTableAdapters.INTERVENTIONSTableAdapter
    Friend WithEvents TableAdapterManager As DORADbDSTableAdapters.TableAdapterManager
    Friend WithEvents lblInt As Label
    Friend WithEvents cmbInt As ComboBox
    Friend WithEvents txtDateInt As DateTimePicker
    Friend WithEvents txtAdressInt As TextBox
    Friend WithEvents cmbCityInt As ComboBox
    Friend WithEvents cmbCityFacts As ComboBox
    Friend WithEvents txtAdressFacts As TextBox
    Friend WithEvents txtDateFacts As DateTimePicker
    Friend WithEvents lblDateInt As Label
    Friend WithEvents lblAdressInt As Label
    Friend WithEvents lblAdressFacts As Label
    Friend WithEvents lblDateFacts As Label
    Friend WithEvents CASESBindingSource As BindingSource
    Friend WithEvents CASESTableAdapter As DORADbDSTableAdapters.CASESTableAdapter
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents txtZipInt As MaskedTextBox
    Friend WithEvents txtZipFacts As MaskedTextBox
    Friend WithEvents RCMenu As ContextMenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOk As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFactsToInt As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIntToFacts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRemondis As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSGS As FontAwesome.Sharp.IconButton
End Class
