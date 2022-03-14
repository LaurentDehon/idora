Option Explicit On
Option Strict On
Imports FontAwesome.Sharp
Imports System.Runtime.InteropServices
Public Class frmConstat
    Private Sub frmConstat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setColors()
        If Lang = 1 Then
            lblConstat.Text = "Eerste bevindingen"
        Else
            lblConstat.Text = "Premières constatations"
        End If
    End Sub
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
#Region "Miscellaneous"
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        frmIntervention.constat = txtConstat.Text
        Close()
    End Sub
    Private Sub setColors()
        'Set colors of controls according to choosen theme
        BackColor = theme("Light")
        pnlMain.BackColor = theme("Medium")
        pnlMain.ForeColor = theme("Font")
        Dim lst_controls As New List(Of Control)
        For Each c As IconButton In FindControlRecursive(lst_controls, Me, GetType(IconButton))
            c.IconColor = theme("Font")
        Next
        AddBorderToPanel(Me, pnlMain, theme("High"))
    End Sub
#End Region

End Class