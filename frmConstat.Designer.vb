<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConstat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConstat))
        Me.txtConstat = New System.Windows.Forms.TextBox()
        Me.lblConstat = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnOk = New FontAwesome.Sharp.IconButton()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtConstat
        '
        Me.txtConstat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConstat.Location = New System.Drawing.Point(16, 64)
        Me.txtConstat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConstat.Multiline = True
        Me.txtConstat.Name = "txtConstat"
        Me.txtConstat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConstat.Size = New System.Drawing.Size(504, 216)
        Me.txtConstat.TabIndex = 142
        '
        'lblConstat
        '
        Me.lblConstat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblConstat.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConstat.Location = New System.Drawing.Point(160, 16)
        Me.lblConstat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConstat.Name = "lblConstat"
        Me.lblConstat.Size = New System.Drawing.Size(244, 33)
        Me.lblConstat.TabIndex = 145
        Me.lblConstat.Text = "Constat"
        Me.lblConstat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.btnOk)
        Me.pnlMain.Controls.Add(Me.lblConstat)
        Me.pnlMain.Controls.Add(Me.txtConstat)
        Me.pnlMain.Location = New System.Drawing.Point(16, 16)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(536, 320)
        Me.pnlMain.TabIndex = 146
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
        Me.btnOk.Location = New System.Drawing.Point(253, 288)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(27, 20)
        Me.btnOk.TabIndex = 148
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmConstat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 351)
        Me.Controls.Add(Me.pnlMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConstat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtConstat As TextBox
    Friend WithEvents lblConstat As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnOk As FontAwesome.Sharp.IconButton
End Class
