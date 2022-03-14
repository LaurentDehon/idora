<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReInt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReInt))
        Me.picMin = New System.Windows.Forms.PictureBox()
        Me.cmbCaseName = New System.Windows.Forms.ComboBox()
        Me.CASESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DORADbDS = New DORA.DORADbDS()
        Me.CASESTableAdapter = New DORA.DORADbDSTableAdapters.CASESTableAdapter()
        Me.TableAdapterManager = New DORA.DORADbDSTableAdapters.TableAdapterManager()
        Me.INTERVENTIONSTableAdapter = New DORA.DORADbDSTableAdapters.INTERVENTIONSTableAdapter()
        Me.INTERVENTIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnOk = New FontAwesome.Sharp.IconButton()
        Me.btnCancel = New FontAwesome.Sharp.IconButton()
        Me.pnlMain = New System.Windows.Forms.Panel()
        CType(Me.picMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'picMin
        '
        Me.picMin.BackColor = System.Drawing.Color.Orange
        Me.picMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMin.Location = New System.Drawing.Point(202, -390)
        Me.picMin.Margin = New System.Windows.Forms.Padding(2)
        Me.picMin.Name = "picMin"
        Me.picMin.Size = New System.Drawing.Size(11, 10)
        Me.picMin.TabIndex = 141
        Me.picMin.TabStop = False
        '
        'cmbCaseName
        '
        Me.cmbCaseName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCaseName.DataSource = Me.CASESBindingSource
        Me.cmbCaseName.DisplayMember = "CASE NAME"
        Me.cmbCaseName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCaseName.FormattingEnabled = True
        Me.cmbCaseName.Location = New System.Drawing.Point(40, 16)
        Me.cmbCaseName.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCaseName.Name = "cmbCaseName"
        Me.cmbCaseName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCaseName.Size = New System.Drawing.Size(200, 32)
        Me.cmbCaseName.TabIndex = 142
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
        'INTERVENTIONSBindingSource
        '
        Me.INTERVENTIONSBindingSource.DataMember = "INTERVENTIONS"
        Me.INTERVENTIONSBindingSource.DataSource = Me.DORADbDS
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
        Me.btnOk.Location = New System.Drawing.Point(104, 58)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(30, 30)
        Me.btnOk.TabIndex = 143
        Me.btnOk.UseVisualStyleBackColor = True
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
        Me.btnCancel.Location = New System.Drawing.Point(152, 58)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.btnCancel.Size = New System.Drawing.Size(30, 30)
        Me.btnCancel.TabIndex = 144
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.cmbCaseName)
        Me.pnlMain.Controls.Add(Me.btnCancel)
        Me.pnlMain.Controls.Add(Me.btnOk)
        Me.pnlMain.Location = New System.Drawing.Point(16, 16)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(280, 96)
        Me.pnlMain.TabIndex = 145
        '
        'frmReInt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 131)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.picMin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReInt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.picMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CASESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DORADbDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTERVENTIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picMin As PictureBox
    Friend WithEvents cmbCaseName As ComboBox
    Friend WithEvents DORADbDS As DORADbDS
    Friend WithEvents CASESBindingSource As BindingSource
    Friend WithEvents CASESTableAdapter As DORADbDSTableAdapters.CASESTableAdapter
    Friend WithEvents TableAdapterManager As DORADbDSTableAdapters.TableAdapterManager
    Friend WithEvents INTERVENTIONSTableAdapter As DORADbDSTableAdapters.INTERVENTIONSTableAdapter
    Friend WithEvents INTERVENTIONSBindingSource As BindingSource
    Friend WithEvents btnOk As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlMain As Panel
End Class
