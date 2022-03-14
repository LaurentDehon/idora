Option Explicit On
Option Strict On
Imports System.Runtime.InteropServices
Public Class frmProgBar
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub frmProgBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setColors()
    End Sub
#Region "Progress"
    Public Sub UpdateProgress(pct As Integer)
        pBar.Value = pBar.Maximum
        pBar.Value = pct
        lblPercent.Text = $"{pct}%"
    End Sub
#End Region
#Region "Drag & move"
    Private Sub pnlTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, pnlMain.MouseDown
        'Handle right click menu and move window
        ReleaseCapture()
        SendMessage(Handle, &H112&, &HF012&, 0)
    End Sub
    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
#End Region
#Region "Miscellanous"
    Private Sub setColors()
        BackColor = theme("Light")
        pnlMain.BackColor = theme("Medium")
        pnlMain.ForeColor = theme("Font")
        AddBorderToPanel(Me, pnlMain, theme("High"))
    End Sub
#End Region

End Class