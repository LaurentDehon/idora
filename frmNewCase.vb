Option Explicit On
Option Strict On
Imports FontAwesome.Sharp
Imports System.Runtime.InteropServices
Imports System.IO
Public Class frmNewCase
    Dim User As String
    Dim datefilled As Boolean = False
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub frmNewCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetColors()
        Location = My.Settings.frmNewCase_loc
        'Fill and sort datatables
        POLICE_UNITSTableAdapter.Fill(DORADbDS.POLICE_UNITS)
        POLICE_UNITSBindingSource.Sort = "[POLICE UNIT NAME] ASC"
        CASESTableAdapter.Fill(DORADbDS.CASES)
        CASESBindingSource.Filter = "[FILE NUM] LIKE 'CRU*'"
        CASESBindingSource.Sort = "[FILE NUM] DESC"
        CASESBindingSource.MoveFirst()
        Trad()
        GetUser()
        cmbUnit.Text = String.Empty
        'Hide default date
        txtDateFacts.Format = DateTimePickerFormat.Custom
        txtDateFacts.CustomFormat = " "
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
#Region "Buttons"
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Create case
        'Check if case doesn't exists
        If CASESBindingSource.Find("CASE NAME", txtCaseName.Text) = -1 Then
            'Check if all required fields are filled
            If txtCaseName.Text <> String.Empty AndAlso cmbUnit.Text <> String.Empty AndAlso cmbTypeOfCase.Text <> String.Empty AndAlso cmbCMInt.Text <> String.Empty AndAlso datefilled = True AndAlso cmbLang.Text <> String.Empty Then
                'Assign a new file number
                Dim MaxFileNum As Integer = CInt(DirectCast(CASESBindingSource.Current, DataRowView).Item("FILE NUM").ToString.Substring(6).ToString) + 1
                Dim NewFileNum As String = MaxFileNum.ToString("0000")
                Dim CurYear As Integer = CInt(Now.Year.ToString.Substring(2))
                Dim NewCaseRow As DataRow = DORADbDS.Tables("CASES").NewRow()
                'Check if the folder of the right year doesn't exists
                If (Not Directory.Exists($"{files_path}{Now.Year}")) Then
                    'Create all the folders
                    Directory.CreateDirectory($"{files_path}{Now.Year}")
                    Directory.CreateDirectory($"{files_path}{Now.Year}\Dumping")
                    Directory.CreateDirectory($"{files_path}{Now.Year}\Lab")
                    Directory.CreateDirectory($"{files_path}{Now.Year}\Storage")
                    Directory.CreateDirectory($"{files_path}{Now.Year}\Traffic")
                    Directory.CreateDirectory($"{files_path}{Now.Year}\Cannabis")
                    Directory.CreateDirectory($"{files_path}{Now.Year}\No Drugs")
                    Directory.CreateDirectory($"{files_path}{Now.Year}\Unconfirmed Facts")
                    'Assign a new file number
                    NewFileNum = $"CRU{CurYear}-0001"
                Else
                    'Assign a new file number
                    NewFileNum = $"CRU{CurYear}-{NewFileNum}"
                End If
                Try
                    'Save data to datatable then to database
                    NewCaseRow("CASE NAME") = txtCaseName.Text
                    NewCaseRow("UNIT") = cmbUnit.Text
                    NewCaseRow("TYPE OF CASE") = cmbTypeOfCase.Text
                    NewCaseRow("CMINT") = cmbCMInt.Text
                    NewCaseRow("DATE FACTS") = txtDateFacts.Text
                    NewCaseRow("LANG") = cmbLang.Text
                    NewCaseRow("FILE NUM") = NewFileNum
                    NewCaseRow("CREATED BY") = User
                    NewCaseRow("CREATED ON") = Format(Now, "dd/MMM/yyyy HH:mm")
                    DORADbDS.Tables("CASES").Rows.Add(NewCaseRow)
                    CASESTableAdapter.Update(DORADbDS.CASES)
                    'Create the case folder and copy all the folders inside
                    Directory.CreateDirectory($"{files_path}{Now.Year}\{cmbTypeOfCase.Text}\{NewFileNum} - {txtCaseName.Text}")
                    FileIO.FileSystem.CopyDirectory($"{dora_path}FOLDERS CASE\", $"{files_path}{Now.Year}\{cmbTypeOfCase.Text}\{NewFileNum} - {txtCaseName.Text}")
                    If Lang = 1 Then
                        MessageBox.Show($"Dossier {txtCaseName.Text} / {NewFileNum} greëerde", "Nieuwe dossier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show($"Dossier {txtCaseName.Text} / {NewFileNum} créé", "Nouveau dossier", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                newCase = True
                My.Settings.frmNewCase_loc = Location
                log("NEWC", $"new case created ({txtCaseName.Text})")
                Close()
            Else
                If Lang = 1 Then
                    MessageBox.Show("Ontbrekende data", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Données manquantes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If Lang = 1 Then
                MessageBox.Show("Dit dossier bestaat al", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Ce dossier existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Discard changes and exit window
        My.Settings.frmNewCase_loc = Location
        Close()
    End Sub
#End Region
#Region "Miscellaneous"
    Private Sub Trad()
        'Translate GUI
        If Lang = 1 Then
            Text = "Nieuwe dossier"
            lblCaseName.Text = "Dossiernaam"
            lblUnit.Text = "Eenheid"
            lblTypeOfCase.Text = "Dossiertype"
            lblCMInt.Text = "Beheerder"
            lblDateFacts.Text = "Datum"
            lblLang.Text = "Taal"
            ToolTip.SetToolTip(btnOk, "Creëer de dossier")
            ToolTip.SetToolTip(btnCancel, "Annuleren")
        Else
            Text = "Nouveau dossier"
            lblCaseName.Text = "Nom de dossier"
            lblUnit.Text = "Unité"
            lblTypeOfCase.Text = "Type de dossier"
            lblCMInt.Text = "Gestionnaire"
            lblDateFacts.Text = "Date"
            lblLang.Text = "Langue"
            ToolTip.SetToolTip(btnOk, "Créer le  dossier")
            ToolTip.SetToolTip(btnCancel, "Annuler")
        End If
    End Sub
    Private Sub GetUser()
        Dim user_list() As String = SearchFile($"{dora_path}cru.txt", Environment.UserName)
        User = user_list(0)
        cmbCMInt.Text = User
        For Each Line As String In File.ReadLines($"{dora_path}cru.txt")
            If Line.Contains("44") Then
                cmbCMInt.Items.Add(Line.Split(CChar(";"))(0).Replace(vbTab, ""))
            End If
        Next
    End Sub
    Private Sub txtDateFacts_ValueChanged(sender As Object, e As EventArgs) Handles txtDateFacts.ValueChanged
        'If date entered, display it
        txtDateFacts.Format = DateTimePickerFormat.Custom
        txtDateFacts.CustomFormat = "dd/MM/yyyy"
        datefilled = True
    End Sub
    Private Sub cmbNoInput(sender As Object, e As KeyPressEventArgs) Handles cmbTypeOfCase.KeyPress, cmbLang.KeyPress, cmbCMInt.KeyPress
        'Disable user input
        e.KeyChar = CChar(" ")
    End Sub
    Private Sub txtCaseName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCaseName.KeyPress
        'Disable "/" char
        If e.KeyChar = "/" Then
            e.Handled = True
        End If
    End Sub
    Private Sub frmNewCase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.R) Then
            Top = CInt((Screen.PrimaryScreen.Bounds.Height - Height) / 2)
            Left = CInt((Screen.PrimaryScreen.Bounds.Width - Width) / 2)
        End If
    End Sub
    Private Sub SetColors()
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