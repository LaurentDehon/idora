Option Explicit On
Option Strict On
Imports FontAwesome.Sharp
Imports System.Runtime.InteropServices
Public Class frmReInt
    Dim NCaseName As String
    Dim NCRUFile As String
    Dim NTypeOfCase As String
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub frmReInt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setColors()
        'Load window position
        Location = My.Settings.frmReInt_loc
        'Fill and sort datatables
        INTERVENTIONSTableAdapter.Fill(DORADbDS.INTERVENTIONS)
        CASESTableAdapter.Fill(DORADbDS.CASES)
        CASESBindingSource.Sort = "[DATE FACTS] DESC"
        cmbCaseName.SelectedIndex = 0
    End Sub
    Private Sub frmReInt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        cmbCaseName.SelectionLength = 0
    End Sub
#Region "Buttons"
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Save and quit
        Dim NCaseName As String = cmbCaseName.Text
        If NCaseName <> CaseName Then
            Dim IntRow() As DataRow = DORADbDS.Tables("INTERVENTIONS").Select($"[ID CRU] = {IntNum}")
            Dim TypeOfInt As String = CStr(IntRow(0)("TYPE OF INT"))
            Dim DateInt As Date = CDate(IntRow(0)("DATE INT"))
            Dim AdressInt As String = CStr(IntRow(0)("ADRESS INT"))
            Dim CityInt As String = CStr(IntRow(0)("CITY INT"))
            Dim NCaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{NCaseName}'")
            Dim NCRUFile As String = CStr(NCaseRow(0)("FILE NUM"))
            Dim NTypeOfCase As String = CStr(NCaseRow(0)("TYPE OF CASE"))
            Dim PathOInt As String = $"{files_path}20{OCRUFile.Substring(3, 2)}\{OTypeOfCase}\{OCRUFile} - {CaseName}\C.R.U.\INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})"
            If IO.Directory.Exists(PathOInt) Then
                If NCRUFile.Substring(0, 3) Like "CRU" AndAlso CInt(NCRUFile.Substring(3, 2)) >= CInt("20") Then
                    FileIO.FileSystem.MoveDirectory(PathOInt, $"{files_path}20{NCRUFile.Substring(3, 2)}\{NTypeOfCase}\{NCRUFile} - {NCaseName}\C.R.U.\INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})")
                ElseIf NCRUFile.Substring(1, 2) = "19" Then
                    FileIO.FileSystem.MoveDirectory(PathOInt, $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{NCRUFile}\C.R.U.\INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})")
                Else
                    FileIO.FileSystem.MoveDirectory(PathOInt, $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{NCRUFile.Substring(1, 2)}\DISP\{NCRUFile}\C.R.U.\INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})")
                End If
            End If
            IntRow(0)("CASE NAME") = NCaseName
            Validate()
            INTERVENTIONSBindingSource.EndEdit()
            INTERVENTIONSTableAdapter.Update(DORADbDS.INTERVENTIONS)
            frmCasesInterventions.RefreshDGVs()
            'Save window position
            My.Settings.frmReInt_loc = Location
            log("REAS", $"intervention {IntNum} moved from {CaseName} to {NCaseName}")
            Close()
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Quit without saving
        'Save window position
        My.Settings.frmReInt_loc = Location
        Close()
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
#Region "Miscellaneous"
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
    Private Sub cmbNoInput(sender As Object, e As KeyPressEventArgs) Handles cmbCaseName.KeyPress
        'Make combobox read-only
        e.Handled = True
    End Sub
#End Region

End Class