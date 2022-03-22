<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStats))
        Me.cmbDrug = New System.Windows.Forms.ComboBox()
        Me.dgvFake = New System.Windows.Forms.DataGridView()
        Me.cmbFrom = New System.Windows.Forms.ComboBox()
        Me.cmbTo = New System.Windows.Forms.ComboBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblCases = New System.Windows.Forms.Label()
        Me.lblInterventions = New System.Windows.Forms.Label()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.DORADbDS = New DORA.DORADbDS()
        Me.INTERVENTIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INTERVENTIONSTableAdapter = New DORA.DORADbDSTableAdapters.INTERVENTIONSTableAdapter()
        Me.TableAdapterManager = New DORA.DORADbDSTableAdapters.TableAdapterManager()
        Me.DRUGS_INTTableAdapter = New DORA.DORADbDSTableAdapters.DRUGS_INTTableAdapter()
        Me.DRUGS_INTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CITIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CITIESTableAdapter = New DORA.DORADbDSTableAdapters.CITIESTableAdapter()
        Me.CASESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CASESTableAdapter = New DORA.DORADbDSTableAdapters.CASESTableAdapter()
        Me.MEMBERS_INTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEMBERS_INTTableAdapter = New DORA.DORADbDSTableAdapters.MEMBERS_INTTableAdapter()
        Me.dgvFake2 = New System.Windows.Forms.DataGridView()
        Me.cmbArro = New System.Windows.Forms.ComboBox()
        Me.cmbChart = New System.Windows.Forms.ComboBox()
        Me.btnChart = New FontAwesome.Sharp.IconButton()
        Me.pnlChart = New System.Windows.Forms.Panel()
        Me.pnlIndividualStats = New System.Windows.Forms.Panel()
        Me.pnlDaysStats = New System.Windows.Forms.Panel()
        Me.pnlPeriod = New System.Windows.Forms.Panel()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.pnlLabsStats = New System.Windows.Forms.Panel()
        Me.lblStandBy = New System.Windows.Forms.Label()
        Me.lblConstruction = New System.Windows.Forms.Label()
        Me.lblDismantled = New System.Windows.Forms.Label()
        Me.lblAbandonned = New System.Windows.Forms.Label()
        Me.lblWorking = New System.Windows.Forms.Label()
        Me.lblLabs = New System.Windows.Forms.Label()
        Me.lblDumpings = New System.Windows.Forms.Label()
        Me.lblStorages = New System.Windows.Forms.Label()
        Me.pnlLastInts = New System.Windows.Forms.Panel()
        CType(Me.dgvFake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DRUGS_INTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERS_INTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFake2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlChart.SuspendLayout()
        Me.pnlDaysStats.SuspendLayout()
        Me.pnlPeriod.SuspendLayout()
        Me.pnlLabsStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbDrug
        '
        Me.cmbDrug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDrug.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDrug.FormattingEnabled = True
        Me.cmbDrug.Location = New System.Drawing.Point(192, 16)
        Me.cmbDrug.Name = "cmbDrug"
        Me.cmbDrug.Size = New System.Drawing.Size(192, 32)
        Me.cmbDrug.TabIndex = 0
        '
        'dgvFake
        '
        Me.dgvFake.AllowUserToAddRows = False
        Me.dgvFake.AllowUserToDeleteRows = False
        Me.dgvFake.AllowUserToResizeColumns = False
        Me.dgvFake.AllowUserToResizeRows = False
        Me.dgvFake.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvFake.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvFake.ColumnHeadersHeight = 29
        Me.dgvFake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFake.ColumnHeadersVisible = False
        Me.dgvFake.Location = New System.Drawing.Point(640, 544)
        Me.dgvFake.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvFake.MultiSelect = False
        Me.dgvFake.Name = "dgvFake"
        Me.dgvFake.ReadOnly = True
        Me.dgvFake.RowHeadersVisible = False
        Me.dgvFake.RowHeadersWidth = 51
        Me.dgvFake.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvFake.RowTemplate.ReadOnly = True
        Me.dgvFake.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFake.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvFake.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFake.Size = New System.Drawing.Size(264, 88)
        Me.dgvFake.TabIndex = 173
        Me.dgvFake.Visible = False
        '
        'cmbFrom
        '
        Me.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrom.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Location = New System.Drawing.Point(16, 16)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(80, 32)
        Me.cmbFrom.TabIndex = 0
        '
        'cmbTo
        '
        Me.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTo.FormattingEnabled = True
        Me.cmbTo.Location = New System.Drawing.Point(104, 16)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Size = New System.Drawing.Size(80, 32)
        Me.cmbTo.TabIndex = 1
        '
        'lblCases
        '
        Me.lblCases.AutoSize = True
        Me.lblCases.Location = New System.Drawing.Point(16, 16)
        Me.lblCases.Name = "lblCases"
        Me.lblCases.Size = New System.Drawing.Size(57, 24)
        Me.lblCases.TabIndex = 192
        Me.lblCases.Text = "Cases"
        '
        'lblInterventions
        '
        Me.lblInterventions.AutoSize = True
        Me.lblInterventions.Location = New System.Drawing.Point(16, 40)
        Me.lblInterventions.Name = "lblInterventions"
        Me.lblInterventions.Size = New System.Drawing.Size(122, 24)
        Me.lblInterventions.TabIndex = 193
        Me.lblInterventions.Text = "Interventions"
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.Location = New System.Drawing.Point(16, 64)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(87, 24)
        Me.lblOut.TabIndex = 194
        Me.lblOut.Text = "Days Out"
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
        'CITIESBindingSource
        '
        Me.CITIESBindingSource.DataMember = "CITIES"
        Me.CITIESBindingSource.DataSource = Me.DORADbDS
        '
        'CITIESTableAdapter
        '
        Me.CITIESTableAdapter.ClearBeforeFill = True
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
        'MEMBERS_INTBindingSource
        '
        Me.MEMBERS_INTBindingSource.DataMember = "MEMBERS INT"
        Me.MEMBERS_INTBindingSource.DataSource = Me.DORADbDS
        '
        'MEMBERS_INTTableAdapter
        '
        Me.MEMBERS_INTTableAdapter.ClearBeforeFill = True
        '
        'dgvFake2
        '
        Me.dgvFake2.AllowUserToAddRows = False
        Me.dgvFake2.AllowUserToDeleteRows = False
        Me.dgvFake2.AllowUserToResizeColumns = False
        Me.dgvFake2.AllowUserToResizeRows = False
        Me.dgvFake2.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvFake2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvFake2.ColumnHeadersHeight = 29
        Me.dgvFake2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFake2.ColumnHeadersVisible = False
        Me.dgvFake2.Location = New System.Drawing.Point(908, 544)
        Me.dgvFake2.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvFake2.MultiSelect = False
        Me.dgvFake2.Name = "dgvFake2"
        Me.dgvFake2.ReadOnly = True
        Me.dgvFake2.RowHeadersVisible = False
        Me.dgvFake2.RowHeadersWidth = 51
        Me.dgvFake2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvFake2.RowTemplate.ReadOnly = True
        Me.dgvFake2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFake2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvFake2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFake2.Size = New System.Drawing.Size(292, 88)
        Me.dgvFake2.TabIndex = 195
        Me.dgvFake2.Visible = False
        '
        'cmbArro
        '
        Me.cmbArro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArro.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbArro.FormattingEnabled = True
        Me.cmbArro.Location = New System.Drawing.Point(392, 16)
        Me.cmbArro.Name = "cmbArro"
        Me.cmbArro.Size = New System.Drawing.Size(192, 32)
        Me.cmbArro.TabIndex = 0
        '
        'cmbChart
        '
        Me.cmbChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChart.DropDownWidth = 550
        Me.cmbChart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChart.FormattingEnabled = True
        Me.cmbChart.Location = New System.Drawing.Point(16, 56)
        Me.cmbChart.Name = "cmbChart"
        Me.cmbChart.Size = New System.Drawing.Size(568, 32)
        Me.cmbChart.TabIndex = 0
        '
        'btnChart
        '
        Me.btnChart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChart.FlatAppearance.BorderSize = 0
        Me.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChart.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.btnChart.IconColor = System.Drawing.Color.Black
        Me.btnChart.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnChart.Location = New System.Drawing.Point(592, 16)
        Me.btnChart.Name = "btnChart"
        Me.btnChart.Size = New System.Drawing.Size(312, 72)
        Me.btnChart.TabIndex = 198
        Me.btnChart.Text = "Chart"
        Me.btnChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChart.UseVisualStyleBackColor = True
        '
        'pnlChart
        '
        Me.pnlChart.Controls.Add(Me.cmbFrom)
        Me.pnlChart.Controls.Add(Me.cmbArro)
        Me.pnlChart.Controls.Add(Me.btnChart)
        Me.pnlChart.Controls.Add(Me.cmbTo)
        Me.pnlChart.Controls.Add(Me.cmbChart)
        Me.pnlChart.Controls.Add(Me.cmbDrug)
        Me.pnlChart.Location = New System.Drawing.Point(24, 24)
        Me.pnlChart.Name = "pnlChart"
        Me.pnlChart.Size = New System.Drawing.Size(920, 104)
        Me.pnlChart.TabIndex = 199
        '
        'pnlIndividualStats
        '
        Me.pnlIndividualStats.AutoSize = True
        Me.pnlIndividualStats.Location = New System.Drawing.Point(24, 248)
        Me.pnlIndividualStats.Name = "pnlIndividualStats"
        Me.pnlIndividualStats.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlIndividualStats.Size = New System.Drawing.Size(56, 48)
        Me.pnlIndividualStats.TabIndex = 200
        '
        'pnlDaysStats
        '
        Me.pnlDaysStats.AutoSize = True
        Me.pnlDaysStats.Controls.Add(Me.lblCases)
        Me.pnlDaysStats.Controls.Add(Me.lblInterventions)
        Me.pnlDaysStats.Controls.Add(Me.lblOut)
        Me.pnlDaysStats.Location = New System.Drawing.Point(96, 248)
        Me.pnlDaysStats.Name = "pnlDaysStats"
        Me.pnlDaysStats.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlDaysStats.Size = New System.Drawing.Size(160, 104)
        Me.pnlDaysStats.TabIndex = 201
        '
        'pnlPeriod
        '
        Me.pnlPeriod.Controls.Add(Me.lblPeriod)
        Me.pnlPeriod.Location = New System.Drawing.Point(24, 168)
        Me.pnlPeriod.Name = "pnlPeriod"
        Me.pnlPeriod.Size = New System.Drawing.Size(232, 64)
        Me.pnlPeriod.TabIndex = 202
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriod.Location = New System.Drawing.Point(16, 16)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(91, 35)
        Me.lblPeriod.TabIndex = 195
        Me.lblPeriod.Text = "Period"
        '
        'pnlLabsStats
        '
        Me.pnlLabsStats.Controls.Add(Me.lblStandBy)
        Me.pnlLabsStats.Controls.Add(Me.lblConstruction)
        Me.pnlLabsStats.Controls.Add(Me.lblDismantled)
        Me.pnlLabsStats.Controls.Add(Me.lblAbandonned)
        Me.pnlLabsStats.Controls.Add(Me.lblWorking)
        Me.pnlLabsStats.Controls.Add(Me.lblLabs)
        Me.pnlLabsStats.Controls.Add(Me.lblDumpings)
        Me.pnlLabsStats.Controls.Add(Me.lblStorages)
        Me.pnlLabsStats.Location = New System.Drawing.Point(96, 368)
        Me.pnlLabsStats.Name = "pnlLabsStats"
        Me.pnlLabsStats.Size = New System.Drawing.Size(160, 224)
        Me.pnlLabsStats.TabIndex = 203
        '
        'lblStandBy
        '
        Me.lblStandBy.AutoSize = True
        Me.lblStandBy.Location = New System.Drawing.Point(16, 136)
        Me.lblStandBy.Name = "lblStandBy"
        Me.lblStandBy.Size = New System.Drawing.Size(78, 24)
        Me.lblStandBy.TabIndex = 202
        Me.lblStandBy.Text = "StandBy"
        '
        'lblConstruction
        '
        Me.lblConstruction.AutoSize = True
        Me.lblConstruction.Location = New System.Drawing.Point(16, 112)
        Me.lblConstruction.Name = "lblConstruction"
        Me.lblConstruction.Size = New System.Drawing.Size(118, 24)
        Me.lblConstruction.TabIndex = 201
        Me.lblConstruction.Text = "Construction"
        '
        'lblDismantled
        '
        Me.lblDismantled.AutoSize = True
        Me.lblDismantled.Location = New System.Drawing.Point(16, 88)
        Me.lblDismantled.Name = "lblDismantled"
        Me.lblDismantled.Size = New System.Drawing.Size(106, 24)
        Me.lblDismantled.TabIndex = 200
        Me.lblDismantled.Text = "Dismantled"
        '
        'lblAbandonned
        '
        Me.lblAbandonned.AutoSize = True
        Me.lblAbandonned.Location = New System.Drawing.Point(16, 64)
        Me.lblAbandonned.Name = "lblAbandonned"
        Me.lblAbandonned.Size = New System.Drawing.Size(119, 24)
        Me.lblAbandonned.TabIndex = 199
        Me.lblAbandonned.Text = "Abandonned"
        '
        'lblWorking
        '
        Me.lblWorking.AutoSize = True
        Me.lblWorking.Location = New System.Drawing.Point(16, 40)
        Me.lblWorking.Name = "lblWorking"
        Me.lblWorking.Size = New System.Drawing.Size(80, 24)
        Me.lblWorking.TabIndex = 198
        Me.lblWorking.Text = "Working"
        '
        'lblLabs
        '
        Me.lblLabs.AutoSize = True
        Me.lblLabs.Location = New System.Drawing.Point(16, 16)
        Me.lblLabs.Name = "lblLabs"
        Me.lblLabs.Size = New System.Drawing.Size(47, 24)
        Me.lblLabs.TabIndex = 195
        Me.lblLabs.Text = "Labs"
        '
        'lblDumpings
        '
        Me.lblDumpings.AutoSize = True
        Me.lblDumpings.Location = New System.Drawing.Point(16, 160)
        Me.lblDumpings.Name = "lblDumpings"
        Me.lblDumpings.Size = New System.Drawing.Size(94, 24)
        Me.lblDumpings.TabIndex = 196
        Me.lblDumpings.Text = "Dumpings"
        '
        'lblStorages
        '
        Me.lblStorages.AutoSize = True
        Me.lblStorages.Location = New System.Drawing.Point(16, 184)
        Me.lblStorages.Name = "lblStorages"
        Me.lblStorages.Size = New System.Drawing.Size(81, 24)
        Me.lblStorages.TabIndex = 197
        Me.lblStorages.Text = "Storages"
        '
        'pnlLastInts
        '
        Me.pnlLastInts.Location = New System.Drawing.Point(272, 248)
        Me.pnlLastInts.Name = "pnlLastInts"
        Me.pnlLastInts.Padding = New System.Windows.Forms.Padding(2)
        Me.pnlLastInts.Size = New System.Drawing.Size(176, 112)
        Me.pnlLastInts.TabIndex = 204
        '
        'frmStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 734)
        Me.Controls.Add(Me.pnlLastInts)
        Me.Controls.Add(Me.pnlLabsStats)
        Me.Controls.Add(Me.pnlPeriod)
        Me.Controls.Add(Me.pnlDaysStats)
        Me.Controls.Add(Me.pnlIndividualStats)
        Me.Controls.Add(Me.pnlChart)
        Me.Controls.Add(Me.dgvFake)
        Me.Controls.Add(Me.dgvFake2)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStats"
        CType(Me.dgvFake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DRUGS_INTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERS_INTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFake2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlChart.ResumeLayout(False)
        Me.pnlDaysStats.ResumeLayout(False)
        Me.pnlDaysStats.PerformLayout()
        Me.pnlPeriod.ResumeLayout(False)
        Me.pnlPeriod.PerformLayout()
        Me.pnlLabsStats.ResumeLayout(False)
        Me.pnlLabsStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DORADbDS As DORADbDS
    Friend WithEvents INTERVENTIONSBindingSource As BindingSource
    Friend WithEvents INTERVENTIONSTableAdapter As DORADbDSTableAdapters.INTERVENTIONSTableAdapter
    Friend WithEvents TableAdapterManager As DORADbDSTableAdapters.TableAdapterManager
    Friend WithEvents DRUGS_INTTableAdapter As DORADbDSTableAdapters.DRUGS_INTTableAdapter
    Friend WithEvents DRUGS_INTBindingSource As BindingSource
    Friend WithEvents CITIESBindingSource As BindingSource
    Friend WithEvents CITIESTableAdapter As DORADbDSTableAdapters.CITIESTableAdapter
    Friend WithEvents CASESBindingSource As BindingSource
    Friend WithEvents CASESTableAdapter As DORADbDSTableAdapters.CASESTableAdapter
    Friend WithEvents cmbDrug As ComboBox
    Friend WithEvents dgvFake As DataGridView
    Friend WithEvents cmbFrom As ComboBox
    Friend WithEvents cmbTo As ComboBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents lblCases As Label
    Friend WithEvents lblInterventions As Label
    Friend WithEvents lblOut As Label
    Friend WithEvents MEMBERS_INTBindingSource As BindingSource
    Friend WithEvents MEMBERS_INTTableAdapter As DORADbDSTableAdapters.MEMBERS_INTTableAdapter
    Friend WithEvents dgvFake2 As DataGridView
    Friend WithEvents cmbArro As ComboBox
    Friend WithEvents cmbChart As ComboBox
    Friend WithEvents btnChart As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlChart As Panel
    Friend WithEvents pnlIndividualStats As Panel
    Friend WithEvents pnlDaysStats As Panel
    Friend WithEvents pnlPeriod As Panel
    Friend WithEvents lblPeriod As Label
    Friend WithEvents pnlLabsStats As Panel
    Friend WithEvents lblLabs As Label
    Friend WithEvents lblDumpings As Label
    Friend WithEvents lblStorages As Label
    Friend WithEvents lblStandBy As Label
    Friend WithEvents lblConstruction As Label
    Friend WithEvents lblDismantled As Label
    Friend WithEvents lblAbandonned As Label
    Friend WithEvents lblWorking As Label
    Friend WithEvents pnlLastInts As Panel
End Class
