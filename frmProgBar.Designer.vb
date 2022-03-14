<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProgBar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgBar))
        Me.picMin = New System.Windows.Forms.PictureBox()
        Me.pBar = New System.Windows.Forms.ProgressBar()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        CType(Me.picMin, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pBar
        '
        Me.pBar.Location = New System.Drawing.Point(24, 24)
        Me.pBar.Margin = New System.Windows.Forms.Padding(2)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(248, 20)
        Me.pBar.TabIndex = 142
        '
        'lblPercent
        '
        Me.lblPercent.BackColor = System.Drawing.Color.Transparent
        Me.lblPercent.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(133, 56)
        Me.lblPercent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(30, 20)
        Me.lblPercent.TabIndex = 143
        Me.lblPercent.Text = "0%"
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pBar)
        Me.pnlMain.Controls.Add(Me.lblPercent)
        Me.pnlMain.Location = New System.Drawing.Point(16, 16)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(296, 96)
        Me.pnlMain.TabIndex = 144
        '
        'frmProgBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 129)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.picMin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProgBar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picMin As PictureBox
    Friend WithEvents pBar As ProgressBar
    Friend WithEvents lblPercent As Label
    Friend WithEvents pnlMain As Panel
End Class
