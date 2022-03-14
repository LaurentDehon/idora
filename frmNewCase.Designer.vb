<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewCase))
        Me.txtCaseName = New System.Windows.Forms.TextBox()
        Me.lblCaseName = New System.Windows.Forms.Label()
        Me.lblDateFacts = New System.Windows.Forms.Label()
        Me.cmbTypeOfCase = New System.Windows.Forms.ComboBox()
        Me.cmbLang = New System.Windows.Forms.ComboBox()
        Me.lblTypeOfCase = New System.Windows.Forms.Label()
        Me.lblLang = New System.Windows.Forms.Label()
        Me.lblCMInt = New System.Windows.Forms.Label()
        Me.cmbCMInt = New System.Windows.Forms.ComboBox()
        Me.txtDateFacts = New System.Windows.Forms.DateTimePicker()
        Me.CASESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DORADbDS = New DORA.DORADbDS()
        Me.CASESTableAdapter = New DORA.DORADbDSTableAdapters.CASESTableAdapter()
        Me.TableAdapterManager = New DORA.DORADbDSTableAdapters.TableAdapterManager()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.POLICE_UNITSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.POLICE_UNITSTableAdapter = New DORA.DORADbDSTableAdapters.POLICE_UNITSTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.RCMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCancel = New FontAwesome.Sharp.IconButton()
        Me.btnOk = New FontAwesome.Sharp.IconButton()
        Me.pnlMain = New System.Windows.Forms.Panel()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POLICE_UNITSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RCMenu.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCaseName
        '
        Me.txtCaseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaseName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCaseName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseName.Location = New System.Drawing.Point(160, 16)
        Me.txtCaseName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCaseName.Name = "txtCaseName"
        Me.txtCaseName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCaseName.Size = New System.Drawing.Size(260, 32)
        Me.txtCaseName.TabIndex = 0
        '
        'lblCaseName
        '
        Me.lblCaseName.AutoSize = True
        Me.lblCaseName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaseName.Location = New System.Drawing.Point(16, 20)
        Me.lblCaseName.Name = "lblCaseName"
        Me.lblCaseName.Size = New System.Drawing.Size(103, 24)
        Me.lblCaseName.TabIndex = 8
        Me.lblCaseName.Text = "Case Name"
        '
        'lblDateFacts
        '
        Me.lblDateFacts.AutoSize = True
        Me.lblDateFacts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateFacts.Location = New System.Drawing.Point(16, 180)
        Me.lblDateFacts.Name = "lblDateFacts"
        Me.lblDateFacts.Size = New System.Drawing.Size(96, 24)
        Me.lblDateFacts.TabIndex = 30
        Me.lblDateFacts.Text = "Date Facts"
        '
        'cmbTypeOfCase
        '
        Me.cmbTypeOfCase.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTypeOfCase.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypeOfCase.FormattingEnabled = True
        Me.cmbTypeOfCase.Items.AddRange(New Object() {"Dumping", "Lab", "Storage", "Traffic", "Cannabis", "No Drugs", "Unconfirmed"})
        Me.cmbTypeOfCase.Location = New System.Drawing.Point(160, 96)
        Me.cmbTypeOfCase.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTypeOfCase.Name = "cmbTypeOfCase"
        Me.cmbTypeOfCase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTypeOfCase.Size = New System.Drawing.Size(259, 32)
        Me.cmbTypeOfCase.TabIndex = 2
        '
        'cmbLang
        '
        Me.cmbLang.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLang.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLang.FormattingEnabled = True
        Me.cmbLang.Items.AddRange(New Object() {"Nederlands", "Français"})
        Me.cmbLang.Location = New System.Drawing.Point(160, 216)
        Me.cmbLang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbLang.Name = "cmbLang"
        Me.cmbLang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbLang.Size = New System.Drawing.Size(259, 32)
        Me.cmbLang.TabIndex = 5
        '
        'lblTypeOfCase
        '
        Me.lblTypeOfCase.AutoSize = True
        Me.lblTypeOfCase.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeOfCase.Location = New System.Drawing.Point(16, 100)
        Me.lblTypeOfCase.Name = "lblTypeOfCase"
        Me.lblTypeOfCase.Size = New System.Drawing.Size(118, 24)
        Me.lblTypeOfCase.TabIndex = 34
        Me.lblTypeOfCase.Text = "Type Of Case"
        '
        'lblLang
        '
        Me.lblLang.AutoSize = True
        Me.lblLang.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLang.Location = New System.Drawing.Point(16, 220)
        Me.lblLang.Name = "lblLang"
        Me.lblLang.Size = New System.Drawing.Size(88, 24)
        Me.lblLang.TabIndex = 33
        Me.lblLang.Text = "Language"
        '
        'lblCMInt
        '
        Me.lblCMInt.AutoSize = True
        Me.lblCMInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCMInt.Location = New System.Drawing.Point(16, 140)
        Me.lblCMInt.Name = "lblCMInt"
        Me.lblCMInt.Size = New System.Drawing.Size(128, 24)
        Me.lblCMInt.TabIndex = 36
        Me.lblCMInt.Text = "Case Manager"
        '
        'cmbCMInt
        '
        Me.cmbCMInt.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCMInt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCMInt.FormattingEnabled = True
        Me.cmbCMInt.Location = New System.Drawing.Point(160, 136)
        Me.cmbCMInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCMInt.Name = "cmbCMInt"
        Me.cmbCMInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCMInt.Size = New System.Drawing.Size(259, 32)
        Me.cmbCMInt.TabIndex = 3
        '
        'txtDateFacts
        '
        Me.txtDateFacts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFacts.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateFacts.Location = New System.Drawing.Point(160, 176)
        Me.txtDateFacts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDateFacts.Name = "txtDateFacts"
        Me.txtDateFacts.Size = New System.Drawing.Size(259, 32)
        Me.txtDateFacts.TabIndex = 4
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
        'cmbUnit
        '
        Me.cmbUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cmbUnit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CASESBindingSource, "UNIT", True))
        Me.cmbUnit.DataSource = Me.POLICE_UNITSBindingSource
        Me.cmbUnit.DisplayMember = "POLICE UNIT NAME"
        Me.cmbUnit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(160, 56)
        Me.cmbUnit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbUnit.Size = New System.Drawing.Size(259, 32)
        Me.cmbUnit.TabIndex = 1
        '
        'POLICE_UNITSBindingSource
        '
        Me.POLICE_UNITSBindingSource.DataMember = "POLICE UNITS"
        Me.POLICE_UNITSBindingSource.DataSource = Me.DORADbDS
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(16, 60)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(46, 24)
        Me.lblUnit.TabIndex = 131
        Me.lblUnit.Text = "Unit"
        '
        'POLICE_UNITSTableAdapter
        '
        Me.POLICE_UNITSTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "POLICE CODE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "POLICE CODE"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "POLICE UNIT NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "POLICE UNIT NAME"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CITY"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CITY"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
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
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnCancel.IconColor = System.Drawing.Color.Black
        Me.btnCancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCancel.IconSize = 30
        Me.btnCancel.Location = New System.Drawing.Point(222, 272)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(27, 20)
        Me.btnCancel.TabIndex = 146
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
        Me.btnOk.Location = New System.Drawing.Point(180, 272)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(27, 20)
        Me.btnOk.TabIndex = 145
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.lblCaseName)
        Me.pnlMain.Controls.Add(Me.txtCaseName)
        Me.pnlMain.Controls.Add(Me.btnCancel)
        Me.pnlMain.Controls.Add(Me.lblDateFacts)
        Me.pnlMain.Controls.Add(Me.btnOk)
        Me.pnlMain.Controls.Add(Me.lblLang)
        Me.pnlMain.Controls.Add(Me.cmbUnit)
        Me.pnlMain.Controls.Add(Me.lblTypeOfCase)
        Me.pnlMain.Controls.Add(Me.lblUnit)
        Me.pnlMain.Controls.Add(Me.cmbLang)
        Me.pnlMain.Controls.Add(Me.txtDateFacts)
        Me.pnlMain.Controls.Add(Me.cmbTypeOfCase)
        Me.pnlMain.Controls.Add(Me.lblCMInt)
        Me.pnlMain.Controls.Add(Me.cmbCMInt)
        Me.pnlMain.Location = New System.Drawing.Point(16, 16)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(432, 312)
        Me.pnlMain.TabIndex = 147
        '
        'frmNewCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 346)
        Me.Controls.Add(Me.pnlMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewCase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Case"
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POLICE_UNITSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RCMenu.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCaseName As TextBox
    Friend WithEvents lblCaseName As Label
    Friend WithEvents DORADbDS As DORADbDS
    Friend WithEvents CASESBindingSource As BindingSource
    Friend WithEvents CASESTableAdapter As DORADbDSTableAdapters.CASESTableAdapter
    Friend WithEvents TableAdapterManager As DORADbDSTableAdapters.TableAdapterManager
    Friend WithEvents lblDateFacts As Label
    Friend WithEvents cmbTypeOfCase As ComboBox
    Friend WithEvents cmbLang As ComboBox
    Friend WithEvents lblTypeOfCase As Label
    Friend WithEvents lblLang As Label
    Friend WithEvents lblCMInt As Label
    Friend WithEvents cmbCMInt As ComboBox
    Friend WithEvents txtDateFacts As DateTimePicker
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents lblUnit As Label
    Friend WithEvents POLICE_UNITSBindingSource As BindingSource
    Friend WithEvents POLICE_UNITSTableAdapter As DORADbDSTableAdapters.POLICE_UNITSTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents RCMenu As ContextMenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOk As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlMain As Panel
End Class
