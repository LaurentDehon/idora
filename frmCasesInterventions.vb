Option Explicit On
Option Strict On
Imports System.Reflection
Imports System.Globalization
Imports System.IO
Imports FontAwesome.Sharp
Imports System.Runtime.InteropServices
Public Class frmCasesInterventions
    Dim DateInt As Date
    Dim TypeOfInt As String
    Dim AdressInt As String
    Dim CityInt As String
    Dim user_list() As String
    Dim selectionChanged As Boolean
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub frmCasesInterventions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetColors()
        'Fill and sort datatables
        CASESTableAdapter.Fill(DORADbDS.CASES)
        CASESBindingSource.Sort = "[DATE FACTS] DESC, [ID] DESC"
        INTERVENTIONSTableAdapter.Fill(DORADbDS.INTERVENTIONS)
        INTERVENTIONSBindingSource.Sort = "[DATE INT] DESC, [ID CRU] DESC"
        Trad()
        FillCombo()
        HideMenus()
        fsw.Path = $"{dora_path}SYSTEM"
        'Display first element of search comboboxes
        cmbSearchCases.SelectedIndex = 0
        cmbSearchInterventions.SelectedIndex = 0
        'Set format of dates in datagridviews
        dgvCases.Columns(1).DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-001")
        dgvInterventions.Columns(1).DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-001")
        'Enable double buffer for datagridviews
        EnableDoubleBuffered(dgvCases, True)
        EnableDoubleBuffered(dgvInterventions, True)
        'Load user data
        user_list = UserToList($"{dora_path}cru.txt", user)
        CreateUsersBoxes()
        CheckDatFiles()
    End Sub
#Region "Drag & move"
    Private Sub pnlTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvCases.MouseDown, dgvInterventions.MouseDown
        'Handle right click menu and move window
        If opened_out = True Then
            ReleaseCapture()
            SendMessage(Handle, &H112&, &HF012&, 0)
        End If
    End Sub
    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
#End Region
#Region "Cases Datagridview"
    Private Sub dgvCases_Resize(sender As Object, e As EventArgs) Handles dgvCases.Resize
        dgvCases.Columns(0).Width = CInt((dgvCases.Width / 100) * 35)
        dgvCases.Columns(1).Width = CInt((dgvCases.Width / 100) * 35)
    End Sub
    Private Sub dgvCases_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCases.SelectionChanged
        'Filter the interventions datagridview or empty the datagridview if no case is found on search
        If CASESBindingSource.Count > 0 Then
            CaseName = CStr(DirectCast(CASESBindingSource.Current, DataRowView).Item("CASE NAME"))
            INTERVENTIONSBindingSource.Filter = $"[CASE NAME] = '{CaseName}'"
        Else
            ResetInterventionsFilter()
        End If
        INTERVENTIONSBindingSource.Sort = "[DATE INT] DESC, [ID CRU] DESC"
        selectionChanged = True
        log("CASE", $"select case {CaseName}")
    End Sub
    Private Sub dgvCases_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCases.CellClick
        CheckDatFiles()
        If Not selectionChanged Then
            dgvCases.ClearSelection()
            selectionChanged = True
            ResetInterventionsFilter()
        Else
            selectionChanged = False
        End If
    End Sub
    Private Sub dgvCases_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCases.CellMouseDoubleClick
        ID = CInt(DirectCast(CASESBindingSource.Current, DataRowView).Item("ID"))
        Cursor = Cursors.WaitCursor
        frmCases.Show()
        Cursor = Cursors.Default
    End Sub
#End Region
#Region "Cases Right Click Menu"
    Private Sub dgvCases_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCases.CellMouseDown
        'Show right click menu
        If e.Button = Windows.Forms.MouseButtons.Right Then
            dgvCases.ClearSelection()
            If e.ColumnIndex <> -1 AndAlso e.RowIndex <> -1 Then
                Dim cell = dgvCases.Item(e.ColumnIndex, e.RowIndex)
                dgvCases.CurrentCell = cell
                cell.Selected = True
                dgvCases_SelectionChanged(sender, e)
                dgvCases.ContextMenuStrip = RCMenuCases
                log("CASE", $"right click on case {CaseName}")
            End If
        End If
    End Sub
    Private Sub mnViewCase_Click(sender As Object, e As EventArgs) Handles mnViewCase.Click
        ID = CInt(DirectCast(CASESBindingSource.Current, DataRowView).Item("ID"))
        Cursor = Cursors.WaitCursor
        frmCases.Show()
        Cursor = Cursors.Default
    End Sub
    Private Sub mnNewCase_Click(sender As Object, e As EventArgs) Handles mnNewCase.Click
        'Go to New Case window
        Cursor = Cursors.WaitCursor
        log("CASE", "click on NEW CASE")
        frmNewCase.Show()
        Cursor = Cursors.Default
    End Sub
    Private Sub mnOpenCaseFolder_Click(sender As Object, e As EventArgs) Handles mnOpenCaseFolder.Click
        'Open case folder
        CaseName = CStr(dgvCases.Item(1, dgvCases.CurrentRow.Index).Value)
        Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{CaseName}'")
        If CaseRow.Length > 0 Then
            CRUFile = CStr(CaseRow(0)("FILE NUM"))
            TypeOfCase = CStr(CaseRow(0)("TYPE OF CASE"))
        Else
            If Lang = 1 Then
                MessageBox.Show("Onmogelijk om deze interventie te vinden", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Impossible de trouver cette intervention", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        log("CASE", $"open folder of case {CaseName}")
        If CRUFile.Substring(0, 3) Like "CRU" AndAlso CInt(CRUFile.Substring(3, 2)) > CInt("19") Then
            Process.Start("explorer.exe", $"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}")
        ElseIf CRUFile.Substring(1, 2) = "19" Then
            Process.Start("explorer.exe", $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}")
        Else
            Process.Start("explorer.exe", $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}")
        End If
    End Sub
    Private Sub mnDeleteCase_Click(sender As Object, e As EventArgs) Handles mnDeleteCase.Click
        'Delete case
        CaseName = CStr(dgvCases.Item(1, dgvCases.CurrentRow.Index).Value)
        Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{CaseName}'")
        If CaseRow.Length > 0 Then
            CRUFile = CStr(CaseRow(0)("FILE NUM"))
            TypeOfCase = CStr(CaseRow(0)("TYPE OF CASE"))
        Else
            If Lang = 1 Then
                MessageBox.Show("Onmogelijk om deze interventie te vinden", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Impossible de trouver cette intervention", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Dim Result As DialogResult
        If Lang = 1 Then
            Result = MessageBox.Show("Weet u het zeker? Deze operatie is onomkeerbaar", "Verwijder dossier", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Else
            Result = MessageBox.Show("Êtes-vous sûr? Cette opération est irréversible", "Supprimer dossier", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If
        If Result = DialogResult.Yes Then
            Dim IntsToDelete As DataRow() = DORADbDS.Tables("INTERVENTIONS").Select($"[CASE NAME] = '{CaseName}'")
            Try
                'Delete the folder
                If CRUFile.Substring(0, 3) Like "CRU" AndAlso CInt(CRUFile.Substring(3, 2)) > CInt("19") Then
                    Directory.Delete($"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}", True)
                ElseIf CRUFile.Substring(1, 2) = "19" Then
                    Directory.Delete($"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}", True)
                Else
                    Directory.Delete($"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}", True)
                End If
            Catch ex As Exception
                If Lang = 1 Then
                    MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show(ex.ToString, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show(ex.ToString, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try
            'Delete the corresponding interventions
            For Each Row As DataRow In IntsToDelete
                log("CASE", $"delete 1 intervention in case {CaseName}")
                Row.Delete()
            Next
            INTERVENTIONSTableAdapter.Update(DORADbDS.INTERVENTIONS)
            log("CASE", $"delete case {CaseName}")
            CASESBindingSource.RemoveCurrent()
            CASESTableAdapter.Update(DORADbDS.CASES)
        End If
    End Sub
    Private Sub mnNewInt_Click(sender As Object, e As EventArgs) Handles mnNewInt.Click
        'Go to New Intervention window
        log("CASE", $"click on NEW INTERVENTION for case {CaseName}")
        'Pass data to create new intervention
        IntLang = CStr(DirectCast(CASESBindingSource.Current, DataRowView).Item("LANG"))
        CRUFile = CStr(DirectCast(CASESBindingSource.Current, DataRowView).Item("FILE NUM"))
        TypeOfCase = CStr(DirectCast(CASESBindingSource.Current, DataRowView).Item("TYPE OF CASE"))
        Cursor = Cursors.WaitCursor
        frmNewInt.Show()
        Cursor = Cursors.Default
    End Sub
#End Region
#Region "Interventions Datagridview"
    Private Sub dgvInterventions_Resize(sender As Object, e As EventArgs) Handles dgvInterventions.Resize
        dgvInterventions.Columns(1).Width = 120
        dgvInterventions.Columns(2).Width = CInt(((dgvInterventions.Width - 150) / 100) * 30)
        dgvInterventions.Columns(3).Width = CInt(((dgvInterventions.Width - 150) / 100) * 20)
        dgvInterventions.Columns(4).Width = CInt(((dgvInterventions.Width - 150) / 100) * 25)
        dgvInterventions.Columns(5).Width = CInt(((dgvInterventions.Width - 150) / 100) * 23)
        dgvInterventions.Columns(11).Width = 30
        dgvInterventions.Columns(11).DefaultCellStyle.NullValue = Nothing
    End Sub
    Private Sub dgvInterventions_SelectionChanged(sender As Object, e As EventArgs) Handles dgvInterventions.SelectionChanged
        Dim index As Integer
        Dim col As Color
        If dgvInterventions.SelectedRows.Count > 0 Then
            index = dgvInterventions.SelectedRows(0).Index
            col = dgvInterventions.Item(11, index).Style.BackColor
            dgvInterventions.Item(11, index).Style.SelectionBackColor = col
        End If
    End Sub
    Private Sub dgvInterventions_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvInterventions.RowPrePaint
        If CBool(dgvInterventions.Item(10, e.RowIndex).Value) = True Then
            dgvInterventions.Item(11, e.RowIndex).Style.BackColor = Color.DarkGreen
        Else
            If CBool(dgvInterventions.Item(6, e.RowIndex).Value) = True AndAlso CBool(dgvInterventions.Item(7, e.RowIndex).Value) = True AndAlso CBool(dgvInterventions.Item(8, e.RowIndex).Value) = True Then
                dgvInterventions.Item(11, e.RowIndex).Style.BackColor = Color.DarkOrange
            Else
                dgvInterventions.Item(11, e.RowIndex).Style.BackColor = Color.DarkRed
            End If
        End If
    End Sub
    Private Sub dgvInterventions_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInterventions.CellMouseDoubleClick
        'View intervention details
        'Check if another intervention window isn't open
        If Application.OpenForms().OfType(Of frmIntervention).Any Then
            If Lang = 1 Then
                MessageBox.Show("Een interventie is al open", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Une intervention est déjà ouverte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            'Pass data and open intervention window
            IntNum = CInt(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("ID CRU"))
            CaseName = CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CASE NAME"))
            TypeOfInt = CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT"))
            DateInt = CDate(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE INT"))
            AdressInt = CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("ADRESS INT"))
            CityInt = CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CITY INT"))
            Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{dgvInterventions.Item(2, dgvInterventions.CurrentRow.Index).Value}'")
            If CaseRow.Length > 0 Then
                IntLang = CStr(CaseRow(0)("LANG"))
                If Not IsDBNull(CaseRow(0)("FILE NUM")) Then CRUFile = CStr(CaseRow(0)("FILE NUM"))
                If Not IsDBNull(CaseRow(0)("TYPE OF CASE")) Then TypeOfCase = CStr(CaseRow(0)("TYPE OF CASE"))
                If Not IsDBNull(CaseRow(0)("REPORT NUM")) Then ReportNum = CStr(CaseRow(0)("REPORT NUM"))
                FirstRow = dgvInterventions.FirstDisplayedScrollingRowIndex
                SelRow = dgvInterventions.CurrentRow.Index
                Cursor = Cursors.WaitCursor
                log("CASE", $"open intervention {IntNum}")
                frmIntervention.Show()
                If CRUFile.Substring(0, 3) Like "CRU" AndAlso CInt(CRUFile.Substring(3, 2)) > CInt("19") Then
                    PathInt = $"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})"
                ElseIf CRUFile.Substring(1, 2) = "19" Then
                    PathInt = $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}\C.R.U"
                Else
                    PathInt = $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}\C.R.U"
                End If
                'Create int dat file
                File.Create($"{dora_path}SYSTEM\INT,,{IntNum},,{user}.dat").Dispose()
                Cursor = Cursors.Default
            Else
                If Lang = 1 Then
                    MessageBox.Show("Onmogelijk om deze interventie te openen", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Impossible d'ouvrir cette intervention", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
#End Region
#Region "Interventions Right Click Menu"
    Private Sub dgvInterventions_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInterventions.CellMouseDown
        'Show right click menu
        If e.Button = Windows.Forms.MouseButtons.Right Then
            dgvInterventions.ClearSelection()
            If e.ColumnIndex <> -1 AndAlso e.RowIndex <> -1 Then
                Dim cell = dgvInterventions.Item(e.ColumnIndex, e.RowIndex)
                dgvInterventions.CurrentCell = cell
                cell.Selected = True
                dgvInterventions.ContextMenuStrip = RCMenuInterventions
                IntNum = CInt(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("ID CRU"))
                CaseName = CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CASE NAME"))
                TypeOfInt = CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT"))
                DateInt = CDate(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE INT"))
                AdressInt = CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("ADRESS INT"))
                CityInt = CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CITY INT"))
                log("CASE", $"right click on intervention {IntNum}")
            End If
        End If
    End Sub
    Private Sub mnViewIntervention_Click(sender As Object, e As EventArgs) Handles mnViewIntervention.Click
        'View intervention details
        'Check if another intervention window isn't open
        If Application.OpenForms().OfType(Of frmIntervention).Any Then
            If Lang = 1 Then
                MessageBox.Show("Een interventie is al open", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Une intervention est déjà ouverte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            'Pass data and open intervention window
            IntNum = CInt(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("ID CRU"))
            CaseName = CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CASE NAME"))
            TypeOfInt = CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT"))
            DateInt = CDate(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE INT"))
            AdressInt = CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("ADRESS INT"))
            CityInt = CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CITY INT"))
            Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{dgvInterventions.Item(2, dgvInterventions.CurrentRow.Index).Value}'")
            If CaseRow.Length > 0 Then
                IntLang = CStr(CaseRow(0)("LANG"))
                If Not IsDBNull(CaseRow(0)("FILE NUM")) Then CRUFile = CStr(CaseRow(0)("FILE NUM"))
                If Not IsDBNull(CaseRow(0)("TYPE OF CASE")) Then TypeOfCase = CStr(CaseRow(0)("TYPE OF CASE"))
                If Not IsDBNull(CaseRow(0)("REPORT NUM")) Then ReportNum = CStr(CaseRow(0)("REPORT NUM"))
                FirstRow = dgvInterventions.FirstDisplayedScrollingRowIndex
                SelRow = dgvInterventions.CurrentRow.Index
                Cursor = Cursors.WaitCursor
                log("CASE", $"open intervention {IntNum}")
                frmIntervention.Show()
                If CRUFile.Substring(0, 3) Like "CRU" AndAlso CInt(CRUFile.Substring(3, 2)) > CInt("19") Then
                    PathInt = $"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})"
                ElseIf CRUFile.Substring(1, 2) = "19" Then
                    PathInt = $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}\C.R.U"
                Else
                    PathInt = $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}\C.R.U"
                End If
                'Create int dat file
                File.Create($"{dora_path}SYSTEM\INT,,{IntNum},,{user}.dat").Dispose()
                Cursor = Cursors.Default
            Else
                If Lang = 1 Then
                    MessageBox.Show("Onmogelijk om deze interventie te openen", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Impossible d'ouvrir cette intervention", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
    Private Sub mnReassignIntervention_Click(sender As Object, e As EventArgs) Handles mnReassignIntervention.Click
        'Reassign intervention
        Dim IntRow() As DataRow = DORADbDS.Tables("INTERVENTIONS").Select($"[ID CRU] = {IntNum}")
        CaseName = CStr(IntRow(0)("CASE NAME"))
        Dim OCaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{CaseName}'")
        OCRUFile = CStr(OCaseRow(0)("FILE NUM"))
        OTypeOfCase = CStr(OCaseRow(0)("TYPE OF CASE"))
        log("CASE", "click on REASSIGN INTERVENTION")
        frmReInt.Show()
    End Sub
    Private Sub mnOpenIntFolder_Click(sender As Object, e As EventArgs) Handles mnOpenIntFolder.Click
        'Open intervention folder, inside the case folder
        Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{CaseName}'")
        If CaseRow.Length > 0 Then
            CRUFile = CStr(CaseRow(0)("FILE NUM"))
            TypeOfCase = CStr(CaseRow(0)("TYPE OF CASE"))
        Else
            If Lang = 1 Then
                MessageBox.Show("Onmogelijk om deze interventie te openen", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Impossible d'ouvrir cette intervention", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        log("CASE", $"open folder of intervention {IntNum}")
        If CRUFile.Substring(0, 3) Like "CRU" AndAlso CInt(CRUFile.Substring(3, 2)) > CInt("19") Then
            Process.Start("explorer.exe", $"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})")
        ElseIf CRUFile.Substring(1, 2) = "19" Then
            If Directory.Exists($"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}\C.R.U") Then
                Process.Start("explorer.exe", $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}\C.R.U")
            Else
                Process.Start("explorer.exe", $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}")
            End If
        Else
            If Directory.Exists($"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}\C.R.U") Then
                Process.Start("explorer.exe", $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}\C.R.U")
            Else
                Process.Start("explorer.exe", $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}")
            End If
        End If
    End Sub
    Private Sub mnCreateIntFolder_Click(sender As Object, e As EventArgs) Handles mnCreateIntFolder.Click
        'Create intervention folder, inside the case folder
        Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{CaseName}'")
        If CaseRow.Length > 0 Then
            CRUFile = CStr(CaseRow(0)("FILE NUM"))
            TypeOfCase = CStr(CaseRow(0)("TYPE OF CASE"))
        Else
            If Lang = 1 Then
                MessageBox.Show("Onmogelijk om deze interventie te openen", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Impossible d'ouvrir cette intervention", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        If CRUFile.Contains("CRU") Then
            If Not Directory.Exists($"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})") Then
                'Create the intervention folder and copy all the folders inside
                If Directory.Exists($"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}") Then
                    Directory.CreateDirectory($"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})")
                    FileIO.FileSystem.CopyDirectory($"{dora_path}FOLDERS INT\", $"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})\")
                Else
                    If Lang = 1 Then
                        MessageBox.Show("De dossier map bestaat niet", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Le répertoire du dossier n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                If Lang = 1 Then
                    MessageBox.Show("De map van deze interventie bestaat al", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Le répertoire de cette intervention existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If Lang = 1 Then
                MessageBox.Show("Het dossier is te oud", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Le dossier est trop vieux", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub mnDeleteInt_Click(sender As Object, e As EventArgs) Handles mnDeleteInt.Click
        'Delete intervention
        Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{CaseName}'")
        If CaseRow.Length > 0 Then
            CRUFile = CStr(CaseRow(0)("FILE NUM"))
            TypeOfCase = CStr(CaseRow(0)("TYPE OF CASE"))
        Else
            If Lang = 1 Then
                MessageBox.Show("Onmogelijk om deze interventie te vinden", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Impossible de trouver cette intervention", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Dim Result As DialogResult
        If Lang = 1 Then
            Result = MessageBox.Show("Weet u het zeker? Deze operatie is onomkeerbaar", "Verwijder interventie", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Else
            Result = MessageBox.Show("Êtes-vous sûr? Cette opération est irréversible", "Supprimer intervention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If
        If Result = DialogResult.Yes Then
            Try
                'Delete the folder
                If CRUFile.Substring(0, 3) Like "CRU" AndAlso CInt(CRUFile.Substring(3, 2)) > CInt("19") Then
                    Directory.Delete($"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})", True)
                ElseIf CRUFile.Substring(1, 2) = "19" Then
                    Directory.Delete($"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}\C.R.U\INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})", True)
                Else
                    Directory.Delete($"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}\C.R.U\INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})", True)
                End If
            Catch ex As Exception
                If Lang = 1 Then
                    MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show(ex.ToString, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show(ex.ToString, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Finally
                log("CASE", $"delete intervention {IntNum}")
                INTERVENTIONSBindingSource.RemoveCurrent()
                INTERVENTIONSTableAdapter.Update(DORADbDS.INTERVENTIONS)
            End Try
        End If
    End Sub
    Private Sub mnUpdateIntFolder_Click(sender As Object, e As EventArgs) Handles mnUpdateIntFolder.Click
        If Directory.Exists($"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})") Then
            FileIO.FileSystem.RenameDirectory($"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})", $"INT {IntNum} {DateInt:dd-MM-yy} - {CityInt} - {AdressInt} ({TypeOfInt})")
        End If
    End Sub
#End Region
#Region "Searches"
    Private Sub CasesTimer_Tick(sender As Object, e As EventArgs) Handles CasesTimer.Tick
        'Search cases
        CasesTimer.Stop()
        CasesFilter()
        'Reset right click menu
        dgvCases.ContextMenuStrip = Nothing
    End Sub
    Private Sub CasesFilter()
        If txtSearchCases.Text <> String.Empty Then
            Select Case cmbSearchCases.Text
                Case "Dossiernaam", "Nom de dossier"
                    CASESBindingSource.Filter = $"[CASE NAME] LIKE '%{txtSearchCases.Text}%'"
                Case "Eenheid", "Unité"
                    CASESBindingSource.Filter = $"[UNIT] LIKE '%{txtSearchCases.Text}%'"
                Case "Dossiertype", "Type de dossier"
                    CASESBindingSource.Filter = $"[TYPE OF CASE] LIKE '%{txtSearchCases.Text}%'"
                Case "Fiche nummer", "Numéro de fiche"
                    CASESBindingSource.Filter = $"[FILE NUM] LIKE '%{txtSearchCases.Text}%'"
                Case "Beheerder", "Gestionnaire"
                    CASESBindingSource.Filter = $"[CMINT] LIKE '%{txtSearchCases.Text}%'"
                Case "Aanvankelijk PV", "PV initial"
                    CASESBindingSource.Filter = $"[REPORT NUM] LIKE '%{txtSearchCases.Text}%'"
                Case "Siena nummer", "Numéro Siena"
                    CASESBindingSource.Filter = $"[SIENA NUM] LIKE '%{txtSearchCases.Text}%'"
            End Select
            log("CASE", $"perform a case search on {txtSearchCases.Text}")
        End If
    End Sub
    Private Sub txtSearchCases_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSearchCases.MouseDoubleClick
        'Remove cases filter and update count
        txtSearchCases.Text = String.Empty
        cmbSearchCases.SelectedIndex = 0
        CASESBindingSource.Filter = String.Empty
        'Check for case dat files
        Dim files As String() = Directory.GetFiles($"{dora_path}SYSTEM", "*.dat")
        For Each f In files
            Dim parts As String() = Split(Path.GetFileNameWithoutExtension(f), ",,")
            If parts(0) = "CAS" Then
                Dim i As Integer = CASESBindingSource.Find("CASE NAME", parts(1))
                If i > -1 Then
                    user_list = UserToList($"{dora_path}cru.txt", parts(2))
                    dgvCases.Rows(i).DefaultCellStyle.BackColor = Color.FromName(user_list(3))
                End If
            End If
        Next
    End Sub
    Private Sub txtSearchCases_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCases.TextChanged
        'Reset search field
        CasesTimer.Stop()
        CasesTimer.Start()
    End Sub
    Private Sub cmbSearchCases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchCases.SelectedIndexChanged
        CasesTimer.Stop()
        CasesTimer.Start()
    End Sub
    Private Sub InterventionsTimer_Tick(sender As Object, e As EventArgs) Handles InterventionsTimer.Tick
        'Search interventions
        InterventionsTimer.Stop()
        InterventionsFilter()
        'Reset right click menu
        dgvInterventions.ContextMenuStrip = Nothing
    End Sub
    Private Sub InterventionsFilter()
        If txtSearchInterventions.Text <> String.Empty Then
            Select Case cmbSearchInterventions.Text
                Case "Dossiernaam", "Nom de dossier"
                    INTERVENTIONSBindingSource.Filter = $"[CASE NAME] LIKE '%{txtSearchInterventions.Text}%'"
                Case "Interventietype", "Type d'intervention"
                    INTERVENTIONSBindingSource.Filter = $"[TYPE OF INT] LIKE '%{txtSearchInterventions.Text}%'"
                Case "Plaats", "Lieu"
                    INTERVENTIONSBindingSource.Filter = $"[TYPE OF PLACE] LIKE '%{txtSearchInterventions.Text}%'"
                Case "Feiten adres", "Adresse des faits"
                    INTERVENTIONSBindingSource.Filter = $"[ADRESS FACTS] LIKE '%{txtSearchInterventions.Text}%'"
                Case "Feiten gemeente", "Commune des faits"
                    INTERVENTIONSBindingSource.Filter = $"[CITY FACTS] LIKE '%{txtSearchInterventions.Text}%'"
                Case "Interventie adress", "Adresse de l'intervention"
                    INTERVENTIONSBindingSource.Filter = $"[ADRESS INT] LIKE '%{txtSearchInterventions.Text}%'"
                Case "Interventie gemeente", "Commune de l'intervention"
                    INTERVENTIONSBindingSource.Filter = $"[CITY INT] LIKE '%{txtSearchInterventions.Text}%'"
                Case "Samenvatting", "Résumé des faits"
                    INTERVENTIONSBindingSource.Filter = $"[SUMMARY] LIKE '%{txtSearchInterventions.Text}%'"
                Case "CRU PV", "PV CRU"
                    INTERVENTIONSBindingSource.Filter = $"[CRU REPORT] LIKE '%{txtSearchInterventions.Text}%'"
            End Select
            log("CASE", $"perform an intervention search on {txtSearchInterventions.Text}")
        End If
    End Sub
    Private Sub txtSearchInterventions_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSearchInterventions.MouseDoubleClick
        'Remove interventions filter and update count
        txtSearchInterventions.Text = String.Empty
        cmbSearchInterventions.SelectedIndex = 0
        INTERVENTIONSBindingSource.Filter = String.Empty
        'Check for case dat files
        Dim files As String() = Directory.GetFiles($"{dora_path}SYSTEM", "*.dat")
        For Each f In files
            Dim parts As String() = Split(Path.GetFileNameWithoutExtension(f), ",,")
            If parts(0) = "INT" Then
                Dim i As Integer = INTERVENTIONSBindingSource.Find("ID CRU", parts(1))
                If i > -1 Then
                    user_list = UserToList($"{dora_path}cru.txt", parts(2))
                    dgvCases.Rows(i).DefaultCellStyle.BackColor = Color.FromName(user_list(3))
                End If
            End If
        Next
    End Sub
    Private Sub txtSearchInterventions_TextChanged(sender As Object, e As EventArgs) Handles txtSearchInterventions.TextChanged
        'Reset search field
        InterventionsTimer.Stop()
        InterventionsTimer.Start()
    End Sub
    Private Sub cmbSearchInterventions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchInterventions.SelectedIndexChanged
        InterventionsTimer.Stop()
        InterventionsTimer.Start()
    End Sub
#End Region
#Region "File System Watcher"
    Private Sub fsw_Created(sender As Object, e As FileSystemEventArgs) Handles fsw.Created
        'Watch for created files in DORA folder
        Dim parts As String() = Split(Path.GetFileNameWithoutExtension(e.Name), ",,")
        If parts(0) = "CAS" Then
            'case file
            If Created = True AndAlso CASESBindingSource.Count > 0 Then
                Dim i As Integer = 0
                If CASESBindingSource.DataSource IsNot Nothing Then i = CASESBindingSource.Find("CASE NAME", parts(1))
                If i > -1 Then
                    user_list = UserToList($"{dora_path}cru.txt", parts(2))
                    dgvCases.Rows(i).DefaultCellStyle.ForeColor = Color.FromName(user_list(3))
                End If
            End If
        ElseIf parts(0) = "INT" Then
            'intervention file
            If Created = True AndAlso INTERVENTIONSBindingSource.Count > 0 Then
                Dim i As Integer = 0
                If INTERVENTIONSBindingSource.DataSource IsNot Nothing Then i = INTERVENTIONSBindingSource.Find("ID CRU", parts(1))
                If i > -1 Then
                    user_list = UserToList($"{dora_path}cru.txt", parts(2))
                    dgvInterventions.Rows(i).DefaultCellStyle.ForeColor = Color.FromName(user_list(3))
                End If
            End If
        End If
    End Sub
    Private Sub fsw_Deleted(sender As Object, e As FileSystemEventArgs) Handles fsw.Deleted
        'Watch for deleted files in DORA folder
        Dim parts As String() = Split(Path.GetFileNameWithoutExtension(e.Name), ",,")
        If parts(0) = "CAS" Then
            'case file
            If Created = True AndAlso CASESBindingSource.Count > 0 Then
                Try
                    Dim i As Integer = 0
                    If CASESBindingSource.DataSource IsNot Nothing Then i = CASESBindingSource.Find("CASE NAME", parts(1))
                    dgvCases.Rows(i).DefaultCellStyle.ForeColor = theme("Font")
                    Dim files As String() = Directory.GetFiles($"{dora_path}SYSTEM", "*.dat")
                    For Each f In files
                        Dim prts As String() = Split(Path.GetFileNameWithoutExtension(e.Name), ",,")
                        prts = Split(Path.GetFileNameWithoutExtension(f), ",,")
                        If prts(0) = "CAS" AndAlso prts(1) = parts(1) Then
                            user_list = UserToList($"{dora_path}cru.txt", prts(2))
                            dgvCases.Rows(i).DefaultCellStyle.ForeColor = Color.FromName(user_list(3))
                        End If
                    Next
                Catch ex As Exception
                    Return
                End Try
            End If
        ElseIf parts(0) = "INT" Then
            'intervention file
            If Created = True AndAlso INTERVENTIONSBindingSource.Count > 0 Then
                Try
                    Dim i As Integer = 0
                    If INTERVENTIONSBindingSource.DataSource IsNot Nothing Then i = INTERVENTIONSBindingSource.Find("ID CRU", parts(1))
                    dgvInterventions.Rows(i).DefaultCellStyle.BackColor = theme("Light")
                    dgvInterventions.Rows(i).DefaultCellStyle.ForeColor = theme("Font")
                Catch ex As Exception
                    Return
                End Try
            End If
        End If
    End Sub
#End Region
#Region "Miscellaneous"
    Private Sub dgvCases_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCases.DataBindingComplete
        'Clear selection of case
        dgvCases.ClearSelection()
        ResetInterventionsFilter()
        CheckDatFiles()
    End Sub
    Private Sub dgvInterventions_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvInterventions.DataBindingComplete
        'Clear selection of intervention
        dgvInterventions.ClearSelection()
        CheckDatFiles()
    End Sub
    Private Sub EnableDoubleBuffered(dgv As DataGridView, setting As Boolean)
        'Speed up scrolling of datagridviews
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, setting, Nothing)
    End Sub
    Private Sub HideMenus()
        'Hide menus for non-admin users
        If user <> "446066523" AndAlso user <> "laure" AndAlso user <> "Dzib" Then
            mnCreateIntFolder.Visible = False
            mnUpdateIntFolder.Visible = False
        End If
    End Sub
    Private Sub CreateUsersBoxes()
        'Create users boxes
        Dim j As Integer = 0
        For Each Line As String In File.ReadLines($"{dora_path}cru.txt")
            If Line.Contains("44") Then
                Line = Line.Replace(vbTab, "")
                Dim pic As New IconPictureBox With {
                    .IconChar = IconChar.UserAlt,
                    .IconColor = Color.FromName(Line.Split(CChar(";"))(3)),
                    .IconSize = 20,
                    .Size = New Size(30, 30),
                    .Text = String.Empty,
                    .Name = $"user{j + 1}",
                    .BackColor = theme("Light"),
                    .Cursor = Cursors.Hand,
                    .Location = New Point(btnRefresh.Right + 10 + j * 35, btnRefresh.Location.Y)
                }
                ToolTip.SetToolTip(pic, Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Line.Split(CChar(";"))(0).ToString))
                tbl4.ColumnStyles.Insert(0, New ColumnStyle(SizeType.Absolute, tbl4.ColumnStyles(0).Width + 40))
                tbl2.ColumnCount += 1
                tbl2.ColumnStyles.Insert(tbl2.ColumnCount - 1, New ColumnStyle(SizeType.Absolute, 40))
                tbl2.Controls.Add(pic, tbl2.ColumnCount - 1, 0)
                j += 1
            End If
        Next
    End Sub
    Public Sub CheckDatFiles()
        'Check for dat files
        Dim files As String() = Directory.GetFiles($"{dora_path}SYSTEM", "*.dat")
        For Each f In files
            Dim parts As String() = Split(Path.GetFileNameWithoutExtension(f), ",,")
            If parts(0) = "CAS" Then
                Dim i As Integer = CASESBindingSource.Find("CASE NAME", parts(1))
                If i >= 0 Then
                    user_list = UserToList($"{dora_path}cru.txt", parts(2))
                    dgvCases.Rows(i).DefaultCellStyle.ForeColor = Color.FromName(user_list(3))
                End If
            End If
            If parts(0) = "INT" Then
                Dim i As Integer = INTERVENTIONSBindingSource.Find("ID CRU", parts(1))
                If i >= 0 Then
                    user_list = UserToList($"{dora_path}cru.txt", parts(2))
                    dgvInterventions.Rows(i).DefaultCellStyle.ForeColor = Color.FromName(user_list(3))
                End If
            End If
        Next
    End Sub
    Private Sub Trad()
        'Translate GUI
        If Lang = 1 Then
            ToolTip.SetToolTip(btnAll, "Toon alle")
            ToolTip.SetToolTip(btnRefresh, "Vernieuwen")
            mnViewCase.Text = "Dossier tonen"
            mnNewCase.Text = "Nieuwe dossier"
            mnOpenCaseFolder.Text = "Map openen"
            mnDeleteCase.Text = "Verwijder dossier"
            mnNewInt.Text = "Nieuwe interventie"
            mnViewIntervention.Text = "Interventie tonen"
            mnReassignIntervention.Text = "Interventie toewijzen"
            mnOpenIntFolder.Text = "Map openen"
            mnDeleteInt.Text = "Verwijder interventie"
        Else
            ToolTip.SetToolTip(btnAll, "Montrer tout")
            ToolTip.SetToolTip(btnRefresh, "Actualiser")
            mnViewCase.Text = "Voir le dossier"
            mnNewCase.Text = "Nouveau dossier"
            mnOpenCaseFolder.Text = "Ouvrir le répertoire"
            mnDeleteCase.Text = "Supprimer le dossier"
            mnNewInt.Text = "Nouvelle intervention"
            mnViewIntervention.Text = "Voir l'intervention"
            mnReassignIntervention.Text = "Réattribuer l'intervention"
            mnOpenIntFolder.Text = "Ouvrir le répertoire"
            mnDeleteInt.Text = "Supprimer l'intervention"
        End If
    End Sub
    Private Sub FillCombo()
        'Fill comboboxes
        If Lang = 1 Then
            cmbSearchCases.Items.Add("Dossiernaam")
            cmbSearchCases.Items.Add("Eenheid")
            cmbSearchCases.Items.Add("Dossiertype")
            cmbSearchCases.Items.Add("Fiche nummer")
            cmbSearchCases.Items.Add("Beheerder")
            cmbSearchCases.Items.Add("Aanvankelijk PV")
            cmbSearchCases.Items.Add("Siena nummer")
            cmbSearchInterventions.Items.Add("Dossiernaam")
            cmbSearchInterventions.Items.Add("Interventietype")
            cmbSearchInterventions.Items.Add("Plaats")
            cmbSearchInterventions.Items.Add("Feiten adres")
            cmbSearchInterventions.Items.Add("Feiten gemeente")
            cmbSearchInterventions.Items.Add("Interventie adres")
            cmbSearchInterventions.Items.Add("Interventie gemeente")
            cmbSearchInterventions.Items.Add("Samenvatting")
            cmbSearchInterventions.Items.Add("CRU PV")
        Else
            cmbSearchCases.Items.Add("Nom de dossier")
            cmbSearchCases.Items.Add("Unité")
            cmbSearchCases.Items.Add("Type de dossier")
            cmbSearchCases.Items.Add("Numéro de fiche")
            cmbSearchCases.Items.Add("Gestionnaire")
            cmbSearchCases.Items.Add("PV initial")
            cmbSearchCases.Items.Add("Numéro Siena")
            cmbSearchInterventions.Items.Add("Nom de dossier")
            cmbSearchInterventions.Items.Add("Type d'intervention")
            cmbSearchInterventions.Items.Add("Lieu")
            cmbSearchInterventions.Items.Add("Adresse des faits")
            cmbSearchInterventions.Items.Add("Commune des faits")
            cmbSearchInterventions.Items.Add("Adresse de l'intervention")
            cmbSearchInterventions.Items.Add("Commune de l'intervention")
            cmbSearchInterventions.Items.Add("Résumé des faits")
            cmbSearchInterventions.Items.Add("PV CRU")
        End If
    End Sub
    Private Sub cmbNoInput(sender As Object, e As KeyPressEventArgs) Handles cmbSearchInterventions.KeyPress, cmbSearchCases.KeyPress
        'Make comboboxes read-only
        e.Handled = True
    End Sub
    Private Sub ResetCasesFilter()
        txtSearchCases.Text = String.Empty
        CASESBindingSource.Filter = String.Empty
    End Sub
    Private Sub ResetInterventionsFilter()
        txtSearchInterventions.Text = String.Empty
        INTERVENTIONSBindingSource.Filter = String.Empty
    End Sub
    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        dgvCases.ClearSelection()
        dgvInterventions.ClearSelection()
        ResetCasesFilter()
        ResetInterventionsFilter()
        RefreshDGVs()
        CheckDatFiles()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshDGVs()
        CheckDatFiles()
    End Sub
    Public Sub RefreshDGVs()
        'Refresh datagridviews
        Dim indexcase As Integer = -1
        Dim indexintervention As Integer = -1
        If dgvCases.SelectedRows.Count > 0 Then
            indexcase = dgvCases.CurrentRow.Index
        End If
        If dgvInterventions.SelectedRows.Count > 0 Then
            indexintervention = dgvInterventions.CurrentRow.Index
        End If
        CASESTableAdapter.Fill(DORADbDS.CASES)
        CASESBindingSource.Sort = "[DATE FACTS] DESC, [ID] DESC"
        CasesFilter()
        INTERVENTIONSTableAdapter.Fill(DORADbDS.INTERVENTIONS)
        INTERVENTIONSBindingSource.Sort = "[DATE INT] DESC, [ID CRU] DESC"
        InterventionsFilter()
        If indexcase > -1 Then
            dgvCases.Rows(indexcase).Selected = True
            INTERVENTIONSBindingSource.Filter = $"[CASE NAME] LIKE '%{dgvCases.SelectedRows(0).Cells(1).Value}%'"
        End If
        If indexintervention > -1 Then
            dgvInterventions.Rows(indexintervention).Selected = True
        End If
    End Sub
    Private Sub SetColors()
        'Set colors of controls according to choosen theme
        tblMain.BackColor = theme("Light")
        dgvCases.BackgroundColor = theme("Light")
        dgvCases.RowsDefaultCellStyle.BackColor = theme("Light")
        dgvCases.RowsDefaultCellStyle.ForeColor = theme("Font")
        dgvCases.RowsDefaultCellStyle.SelectionBackColor = theme("High")
        dgvCases.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvCases.ColumnHeadersDefaultCellStyle.BackColor = theme("Medium")
        dgvCases.ColumnHeadersDefaultCellStyle.ForeColor = theme("Font")
        dgvCases.ColumnHeadersDefaultCellStyle.SelectionBackColor = theme("Light")
        dgvCases.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black
        dgvInterventions.BackgroundColor = theme("Light")
        dgvInterventions.RowsDefaultCellStyle.BackColor = theme("Light")
        dgvInterventions.RowsDefaultCellStyle.ForeColor = theme("Font")
        dgvInterventions.RowsDefaultCellStyle.SelectionBackColor = theme("High")
        dgvInterventions.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvInterventions.ColumnHeadersDefaultCellStyle.BackColor = theme("Medium")
        dgvInterventions.ColumnHeadersDefaultCellStyle.ForeColor = theme("Font")
        dgvInterventions.ColumnHeadersDefaultCellStyle.SelectionBackColor = theme("Light")
        dgvInterventions.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black
        Dim lst_controls As New List(Of Control)
        For Each c As IconButton In FindControlRecursive(lst_controls, Me, GetType(IconButton))
            c.IconColor = theme("Font")
        Next
    End Sub
    Private Sub frmCasesInterventions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Alt AndAlso e.KeyCode = Keys.X) Then
            opened_out = False
            Close()
        End If
    End Sub
#End Region

End Class