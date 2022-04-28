Option Explicit On
Option Strict On
Imports FontAwesome.Sharp
Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmCases
    Dim OriginalCaseName As String
    Dim OriginalTypeOfCase As String
    Dim DateInt As Date
    Dim TypeOfInt As String
    Dim AdressInt As String
    Dim CityInt As String
    Dim actualCase As String
    Public previousCase As String = String.Empty
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub frmCases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = My.Settings.frmCases_loc
        SetColors()
        'Fill and sort datatables
        POLICE_UNITSTableAdapter.Fill(DORADbDS.POLICE_UNITS)
        POLICE_UNITSBindingSource.Sort = "[POLICE UNIT NAME] ASC"
        CASESTableAdapter.Fill(DORADbDS.CASES)
        CASESBindingSource.Sort = "[DATE FACTS] DESC"
        CASESBindingSource.Filter = $"[ID] = '{ID}'"
        INTERVENTIONSTableAdapter.Fill(DORADbDS.INTERVENTIONS)
        INTERVENTIONSBindingSource.Sort = "[DATE INT] DESC"
        ControlBox = False
        Trad()
        FillCombo()
        LoadNSP()
        fsw.Path = $"{dora_path}SYSTEM"
        handleCheckboxes()
        handleRadiobuttons()
        HideControls()
        SetVisibleAndUnderlined(pnlNSPMain)
        HideDefaultDates()
        CreateDatFile()
        OriginalCaseName = txtCaseName.Text
        OriginalTypeOfCase = cmbTypeOfCase.Text
    End Sub
#Region "Tab"
    Private Sub SetVisibleAndUnderlined(control_to_show As Control)
        Dim lst_controls1 As New List(Of Control)({pnlNSPMain, pnlProactiveMain, pnlInvestigationMain, pnlJudInvestigationMain, pnlFederalizedMain})
        Dim lst_controls2 As New List(Of Control)({pnlNSPTitle, pnlProactiveTitle, pnlInvestigationTitle, pnlJudInvestigationTitle, pnlFederalizedTitle})
        For Each c In lst_controls1
            If c.Name = control_to_show.Name Then
                c.Visible = True
                lst_controls2(lst_controls1.IndexOf(c)).BackColor = theme("High")
            Else
                c.Visible = False
                lst_controls2(lst_controls1.IndexOf(c)).BackColor = theme("Light")
            End If
        Next
    End Sub
    Private Sub lblNSP_Click(sender As Object, e As EventArgs) Handles lblNSPTitle.Click
        If pnlNSPMain.Visible = False Then
            SetVisibleAndUnderlined(pnlNSPMain)
        End If
    End Sub
    Private Sub lblProactive_Click(sender As Object, e As EventArgs) Handles lblProactiveTitle.Click
        If pnlProactiveMain.Visible = False Then
            SetVisibleAndUnderlined(pnlProactiveMain)
        End If
    End Sub
    Private Sub lblInvestigation_Click(sender As Object, e As EventArgs) Handles lblInvestigationTitle.Click
        If pnlInvestigationMain.Visible = False Then
            SetVisibleAndUnderlined(pnlInvestigationMain)
        End If
    End Sub
    Private Sub lblJudInvestigation_Click(sender As Object, e As EventArgs) Handles lblJudInvestigationTitle.Click
        If pnlJudInvestigationMain.Visible = False Then
            SetVisibleAndUnderlined(pnlJudInvestigationMain)
        End If
    End Sub
    Private Sub lblFederalized_Click(sender As Object, e As EventArgs) Handles lblFederalizedTitle.Click
        If pnlFederalizedMain.Visible = False Then
            SetVisibleAndUnderlined(pnlFederalizedMain)
        End If
    End Sub
    Private Sub btnProactive_Click(sender As Object, e As EventArgs) Handles btnProactive.Click
        If chkProactive.Checked = True Then
            chkProactive.Checked = False
        Else
            chkProactive.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnInvestigation_Click(sender As Object, e As EventArgs) Handles btnInvestigation.Click
        If chkInvestigation.Checked = True Then
            chkInvestigation.Checked = False
        Else
            chkInvestigation.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnJudInvestigation_Click(sender As Object, e As EventArgs) Handles btnJudInvestigation.Click
        If chkJudInvestigation.Checked = True Then
            chkJudInvestigation.Checked = False
        Else
            chkJudInvestigation.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnFederalized_Click(sender As Object, e As EventArgs) Handles btnFederalized.Click
        If chkFederalized.Checked = True Then
            chkFederalized.Checked = False
        Else
            chkFederalized.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub LoadNSP()
        Select Case cmbNSP.Text
            Case String.Empty
                rbSyntheticP.Checked = False
                rbSyntheticT.Checked = False
                rbCannabis.Checked = False
                rbCocaïne.Checked = False
            Case "Synthetic Production"
                rbSyntheticP.Checked = True
                rbSyntheticT.Checked = False
                rbCannabis.Checked = False
                rbCocaïne.Checked = False
            Case "Synthetic Trafic"
                rbSyntheticP.Checked = False
                rbSyntheticT.Checked = True
                rbCannabis.Checked = False
                rbCocaïne.Checked = False
            Case "Cannabis"
                rbSyntheticP.Checked = False
                rbSyntheticT.Checked = False
                rbCannabis.Checked = True
                rbCocaïne.Checked = False
            Case "Cocaïne"
                rbSyntheticP.Checked = False
                rbSyntheticT.Checked = False
                rbCannabis.Checked = False
                rbCocaïne.Checked = True
        End Select
    End Sub
    Private Sub btnCannabis_Click(sender As Object, e As EventArgs) Handles btnCannabis.Click
        If rbCannabis.Checked = True Then
            ClearNPS()
        Else
            rbCannabis.Checked = True
            cmbNSP.Text = "Cannabis"
        End If
        handleRadiobuttons()
        Validate()
        CASESBindingSource.EndEdit()
        CASESTableAdapter.Update(DORADbDS.CASES)
        log("CASE", "click on CANNABIS NSP")
    End Sub
    Private Sub btnSyntheticP_Click(sender As Object, e As EventArgs) Handles btnSyntheticP.Click
        If rbSyntheticP.Checked = True Then
            ClearNPS()
        Else
            rbSyntheticP.Checked = True
            cmbNSP.Text = "Synthetic Production"
        End If
        handleRadiobuttons()
        Validate()
        CASESBindingSource.EndEdit()
        CASESTableAdapter.Update(DORADbDS.CASES)
        log("CASE", "click on SYNTHETIC PROD. NSP")
    End Sub
    Private Sub btnSyntheticT_Click(sender As Object, e As EventArgs) Handles btnSyntheticT.Click
        If rbSyntheticT.Checked = True Then
            ClearNPS()
        Else
            rbSyntheticT.Checked = True
            cmbNSP.Text = "Synthetic Trafic"
        End If
        handleRadiobuttons()
        Validate()
        CASESBindingSource.EndEdit()
        CASESTableAdapter.Update(DORADbDS.CASES)
        log("CASE", "click on SYNTHETIC TRAF. NSP")
    End Sub
    Private Sub btnCocaine_Click(sender As Object, e As EventArgs) Handles btnCocaine.Click
        If rbCocaïne.Checked = True Then
            ClearNPS()
        Else
            rbCocaïne.Checked = True
            cmbNSP.Text = "Cocaïne"
        End If
        handleRadiobuttons()
        Validate()
        CASESBindingSource.EndEdit()
        CASESTableAdapter.Update(DORADbDS.CASES)
        log("CASE", "click on COCAÏNE NSP")
    End Sub
    Private Sub ClearNPS()
        'Reset NSP field
        rbFake.Checked = True
        handleRadiobuttons()
        cmbNSP.Text = String.Empty
        Validate()
        CASESBindingSource.EndEdit()
        CASESTableAdapter.Update(DORADbDS.CASES)
        log("CASE", "clear NPS")
    End Sub
    Private Sub handleRadiobuttons()
        If rbCannabis.Checked = True Then btnCannabis.IconChar = IconChar.Check Else btnCannabis.IconChar = IconChar.Times
        If rbSyntheticP.Checked = True Then btnSyntheticP.IconChar = IconChar.Check Else btnSyntheticP.IconChar = IconChar.Times
        If rbSyntheticT.Checked = True Then btnSyntheticT.IconChar = IconChar.Check Else btnSyntheticT.IconChar = IconChar.Times
        If rbCocaïne.Checked = True Then btnCocaine.IconChar = IconChar.Check Else btnCocaine.IconChar = IconChar.Times
    End Sub
#End Region
#Region "Checkboxes"
    Private Sub handleCheckboxes()
        If chkEmbargo.Checked = True Then
            btnEmbargo.IconChar = IconChar.Check
        Else
            btnEmbargo.IconChar = IconChar.Times
        End If
        If chkBom.Checked = True Then
            btnBOM.IconChar = IconChar.Check
        Else
            btnBOM.IconChar = IconChar.Times
        End If
        If chkSienaPictures.Checked = True Then
            btnSienaPictures.IconChar = IconChar.Check
        Else
            btnSienaPictures.IconChar = IconChar.Times
        End If
        If chkProactive.Checked = True Then
            btnProactive.IconChar = IconChar.Check
        Else
            btnProactive.IconChar = IconChar.Times
        End If
        If chkInvestigation.Checked = True Then
            btnInvestigation.IconChar = IconChar.Check
        Else
            btnInvestigation.IconChar = IconChar.Times
        End If
        If chkJudInvestigation.Checked = True Then
            btnJudInvestigation.IconChar = IconChar.Check
        Else
            btnJudInvestigation.IconChar = IconChar.Times
        End If
        If chkFederalized.Checked = True Then
            btnFederalized.IconChar = IconChar.Check
        Else
            btnFederalized.IconChar = IconChar.Times
        End If
    End Sub
    Private Sub btnEmbargo_Click(sender As Object, e As EventArgs) Handles btnEmbargo.Click
        If chkEmbargo.Checked = True Then
            chkEmbargo.Checked = False
        Else
            chkEmbargo.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnBOM_Click(sender As Object, e As EventArgs) Handles btnBOM.Click
        If chkBom.Checked = True Then
            chkBom.Checked = False
        Else
            chkBom.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnSienaPictures_Click(sender As Object, e As EventArgs) Handles btnSienaPictures.Click
        If chkSienaPictures.Checked = True Then
            chkSienaPictures.Checked = False
        Else
            chkSienaPictures.Checked = True
        End If
        handleCheckboxes()
    End Sub
#End Region
#Region "Dates"
    Private Sub txtSienaDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSienaDate.KeyPress
        'Format date field
        If Asc(e.KeyChar) = 8 Then
            txtSienaDate.Format = DateTimePickerFormat.Custom
            txtSienaDate.CustomFormat = " "
            Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{CaseName}'")
            CaseRow(0)("SIENA REPORT DATE") = DBNull.Value
        End If
    End Sub
    Private Sub txtSienaPicturesDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSienaPicturesDate.KeyPress
        'Format date field
        If Asc(e.KeyChar) = 8 Then
            txtSienaPicturesDate.Format = DateTimePickerFormat.Custom
            txtSienaPicturesDate.CustomFormat = " "
            Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{CaseName}'")
            CaseRow(0)("SIENA PICTURES DATE") = DBNull.Value
        End If
    End Sub
    Private Sub txtProactiveDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProactiveDate.KeyPress
        'Format date field
        If Asc(e.KeyChar) = 8 Then
            txtProactiveDate.Format = DateTimePickerFormat.Custom
            txtProactiveDate.CustomFormat = " "
            Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{CaseName}'")
            CaseRow(0)("PROACTIVE DATE") = DBNull.Value
        End If
    End Sub
    Private Sub txtInvestigationDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInvestigationDate.KeyPress
        'Format date field
        If Asc(e.KeyChar) = 8 Then
            txtInvestigationDate.Format = DateTimePickerFormat.Custom
            txtInvestigationDate.CustomFormat = " "
            Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{CaseName}'")
            CaseRow(0)("INVESTIGATION DATE") = DBNull.Value
        End If
    End Sub
    Private Sub txtJudInvestigationDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJudInvestigationDate.KeyPress
        'Format date field
        If Asc(e.KeyChar) = 8 Then
            txtJudInvestigationDate.Format = DateTimePickerFormat.Custom
            txtJudInvestigationDate.CustomFormat = " "
            Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{CaseName}'")
            CaseRow(0)("JUD INVESTIGATION DATE") = DBNull.Value
        End If
    End Sub
    Private Sub txtFederalizedDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFederalizedDate.KeyPress
        'Format date field
        If Asc(e.KeyChar) = 8 Then
            txtFederalizedDate.Format = DateTimePickerFormat.Custom
            txtFederalizedDate.CustomFormat = " "
            Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{CaseName}'")
            CaseRow(0)("FEDERALIZED DATE") = DBNull.Value
        End If
    End Sub
    Private Sub txtDate_ValueChanged(sender As Object, e As EventArgs) Handles txtDate.ValueChanged
        'If date entered, display it
        txtDate.Format = DateTimePickerFormat.Custom
        txtDate.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub txtSienaDate_ValueChanged(sender As Object, e As EventArgs) Handles txtSienaDate.ValueChanged
        'If date entered, display it
        txtSienaDate.Format = DateTimePickerFormat.Custom
        txtSienaDate.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub txtSienaPicturesDate_ValueChanged(sender As Object, e As EventArgs) Handles txtSienaPicturesDate.ValueChanged
        'If date entered, display it
        txtSienaPicturesDate.Format = DateTimePickerFormat.Custom
        txtSienaPicturesDate.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub txtProactiveDate_ValueChanged(sender As Object, e As EventArgs) Handles txtProactiveDate.ValueChanged
        'If date entered, display it
        txtProactiveDate.Format = DateTimePickerFormat.Custom
        txtProactiveDate.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub txtInvestigationDate_ValueChanged(sender As Object, e As EventArgs) Handles txtInvestigationDate.ValueChanged
        'If date entered, display it
        txtInvestigationDate.Format = DateTimePickerFormat.Custom
        txtInvestigationDate.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub txtJudInvestigationDate_ValueChanged(sender As Object, e As EventArgs) Handles txtJudInvestigationDate.ValueChanged
        'If date entered, display it
        txtJudInvestigationDate.Format = DateTimePickerFormat.Custom
        txtJudInvestigationDate.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub txtFederalizedDate_ValueChanged(sender As Object, e As EventArgs) Handles txtFederalizedDate.ValueChanged
        'If date entered, display it
        txtFederalizedDate.Format = DateTimePickerFormat.Custom
        txtFederalizedDate.CustomFormat = "dd/MM/yyyy"
    End Sub
#End Region
#Region "Drag & move"
    Private Sub pnlTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTitle.MouseDown
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
    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        'Minimize window
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnFolder_Click(sender As Object, e As EventArgs) Handles btnFolder.Click
        'Open case folder
        Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{CaseName}'")
        If CaseRow.Length > 0 Then
            CRUFile = CaseRow(0)("FILE NUM").ToString
            TypeOfCase = CaseRow(0)("TYPE OF CASE").ToString
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
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Save changes
        If OriginalCaseName <> txtCaseName.Text Then
            'Rename directory
            If txtFileNum.Text.Substring(0, 3) Like "CRU" AndAlso CInt(txtFileNum.Text.Substring(3, 2)) >= CInt("20") Then
                Try
                    FileIO.FileSystem.RenameDirectory($"{files_path}20{txtFileNum.Text.Substring(3, 2)}\{OriginalTypeOfCase}\{txtFileNum.Text} - {OriginalCaseName}", $"{txtFileNum.Text} - {txtCaseName.Text}")
                    log("CASE", $"rename case {OriginalCaseName} to {txtCaseName.Text}")
                Catch IOex As IOException
                    If Lang = 1 Then
                        MessageBox.Show("Zorg ervoor dat er geen documenten of mappen in de te hernoemen map geopend zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Veuillez vous assurer qu'aucun document ou répertoire du dossier à renommer n'est ouvert", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    txtCaseName.Text = OriginalCaseName
                    Exit Sub
                End Try
            End If
            If OriginalCaseName <> String.Empty Then
                Dim CaseInts() As DataRow = DORADbDS.Tables("INTERVENTIONS").Select($"[CASE NAME] = '{OriginalCaseName}'")
                If CaseInts.Length > 0 Then
                    For i As Integer = 0 To CaseInts.GetUpperBound(0)
                        CaseInts(i)("CASE NAME") = txtCaseName.Text
                    Next
                End If
            End If
        End If
        If OriginalTypeOfCase <> cmbTypeOfCase.Text Then
            'Move directory
            If txtFileNum.Text.Substring(0, 3) Like "CRU" AndAlso CInt(txtFileNum.Text.Substring(3, 2)) >= CInt("20") Then
                Try
                    FileIO.FileSystem.MoveDirectory($"{files_path}20{txtFileNum.Text.Substring(3, 2)}\{OriginalTypeOfCase}\{txtFileNum.Text} - {OriginalCaseName}", $"{files_path}20{txtFileNum.Text.Substring(3, 2)}\{cmbTypeOfCase.Text}\{txtFileNum.Text} - {txtCaseName.Text}")
                    log("CASE", $"move case {txtCaseName.Text} from {OriginalTypeOfCase} to {cmbTypeOfCase.Text}")
                Catch IOex As IOException
                    If Lang = 1 Then
                        MessageBox.Show("Zorg ervoor dat er geen documenten of mappen in de te hernoemen map geopend zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Veuillez vous assurer qu'aucun document ou répertoire du dossier à renommer n'est ouvert", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    FileIO.FileSystem.MoveDirectory($"{files_path}20{txtFileNum.Text.Substring(3, 2)}\{cmbTypeOfCase.Text}\{txtFileNum.Text} - {txtCaseName.Text}", $"{files_path}20{txtFileNum.Text.Substring(3, 2)}\{OriginalTypeOfCase}\{txtFileNum.Text} - {OriginalCaseName}")
                    cmbTypeOfCase.Text = OriginalTypeOfCase
                    Exit Sub
                End Try
            End If
        End If
        OriginalTypeOfCase = cmbTypeOfCase.Text
        OriginalCaseName = txtCaseName.Text
        INTERVENTIONSBindingSource.EndEdit()
        INTERVENTIONSTableAdapter.Update(DORADbDS.INTERVENTIONS)
        CASESBindingSource.EndEdit()
        CASESTableAdapter.Update(DORADbDS.CASES)
        log("CASE", "click on SAVE")
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnExit.Click
        'Discard changes and exit window
        Dim Result As DialogResult
        CASESBindingSource.EndEdit()
        If DORADbDS.HasChanges Then
            If Lang = 1 Then
                Result = MessageBox.Show($"U zult alle niet-opgeslagen wijzigingen verliezen.{Environment.NewLine}Weet u het zeker?", "Weet u het zeker?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Else
                Result = MessageBox.Show($"Vous allez perdre tous les changements non sauvegardés.{Environment.NewLine}Voulez-vous continuer?", "Êtes-vous sûr", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If
            If Result = DialogResult.Yes Then
                My.Settings.frmCases_loc = Location
                'Delete case dat file
                If File.Exists($"{dora_path}SYSTEM\CAS,,{previousCase},,{user}.dat") Then
                    File.Delete($"{dora_path}SYSTEM\CAS,,{previousCase},,{user}.dat")
                End If
                log("CASE", "click on CANCEL")
                Close()
            End If
        Else
            My.Settings.frmCases_loc = Location
            'Delete case dat file
            If File.Exists($"{dora_path}SYSTEM\CAS,,{previousCase},,{user}.dat") Then
                File.Delete($"{dora_path}SYSTEM\CAS,,{previousCase},,{user}.dat")
            End If
            log("CASE", "click on CANCEL")
            Close()
        End If
    End Sub
#End Region
#Region "Miscellaneous"
    Public Sub Trad()
        'Translate GUI
        If Lang = 1 Then
            lblTitle.Text = $"Dossier {txtCaseName.Text} van {cmbUnit.Text}"
            lblCaseName.Text = "Dossiernaam"
            lblUnit.Text = "Eenheid"
            lblTypeOfCase.Text = "Dossiertype"
            lblCMInt.Text = "Beheerder"
            lblFileNum.Text = "CRU fiche"
            lblReportNum.Text = "Aanvankelijk PV"
            lblDate.Text = "Datum"
            lblLang.Text = "Taal"
            lblSupport.Text = "Ondersteuning"
            lblOrigin.Text = "Afkomst"
            lblRioNum.Text = "RIO nummer"
            lblOnNum.Text = "ON nummer"
            lblCMExt.Text = "Onderzoeker(s)"
            lblSienaNum.Text = "Siena nummer"
            lblSienaPictures.Text = "Foto's verzonden"
            lblon1.Text = "op"
            lblon2.Text = "op"
            lblNSPTitle.Text = "NVP"
            lblProactiveTitle.Text = "Proactief"
            lblProactive.Text = "Proactief"
            lblProactiveDate.Text = "op"
            lblInvestigationTitle.Text = "Opsporings."
            lblInvestigation.Text = "Opsporingsonderzoek"
            lblInvestigationDate.Text = "op"
            lblInvestigationMagistrate.Text = "Magistraat"
            lblJudInvestigationTitle.Text = "Gerechtelijk onder."
            lblJudInvestigation.Text = "Gerechtelijk onderzoek"
            lblJudInvestigationDate.Text = "op"
            lblJudInvestigationMagistrate.Text = "Magistraat"
            lblFederalizedTitle.Text = "Gefederaliseerd"
            lblFederalized.Text = "Gefederaliseerd"
            lblFederalizedDate.Text = "op"
            lblFederalizedMagistrate.Text = "Magistraat"
            lblSummary.Text = "Samenvatting van de feiten"
            ToolTip.SetToolTip(btnSave, "Opslaan")
            ToolTip.SetToolTip(btnFolder, "Map openen")
            ToolTip.SetToolTip(btnExit, "Verlaten")
            ToolTip.SetToolTip(txtSienaDate, "Druk op del om te verwijderen")
            ToolTip.SetToolTip(txtSienaPicturesDate, "Druk op del om te verwijderen")
            ToolTip.SetToolTip(txtProactiveDate, "Druk op del om te verwijderen")
            ToolTip.SetToolTip(txtInvestigationDate, "Druk op del om te verwijderen")
            ToolTip.SetToolTip(txtJudInvestigationDate, "Druk op del om te verwijderen")
            ToolTip.SetToolTip(txtFederalizedDate, "Druk op del om te verwijderen")
            lblCannabis.Text = "A.03.01. Cannabis - productie"
            lblSyntheticP.Text = "A.03.03. Syntetische drugs - productie"
            lblSyntheticT.Text = "A.03.04. Syntetische drugs - smokkel"
            lblCocaine.Text = "A.03.05. Cocaïne - invoer en uitvoer"
            If DirectCast(CASESBindingSource.Current, DataRowView).Item("CREATED ON") IsNot DBNull.Value AndAlso CStr(DirectCast(CASESBindingSource.Current, DataRowView).Item("CREATED BY")) <> String.Empty Then
                lblCreated.Text = $"Angemaakt door {CStr(DirectCast(CASESBindingSource.Current, DataRowView).Item("CREATED BY"))} op {Format(DirectCast(CASESBindingSource.Current, DataRowView).Item("CREATED ON"), "dd/MM/yyyy")}"
            Else
                lblCreated.Visible = False
            End If
        Else
            lblTitle.Text = $"Dossier {txtCaseName.Text} de la {cmbUnit.Text}"
            lblCaseName.Text = "Nom de dossier"
            lblUnit.Text = "Unité"
            lblTypeOfCase.Text = "Type de dossier"
            lblCMInt.Text = "Gestionnaire"
            lblFileNum.Text = "Fiche CRU"
            lblReportNum.Text = "PV initial"
            lblDate.Text = "Date"
            lblLang.Text = "Langue"
            lblSupport.Text = "Appui"
            lblOrigin.Text = "Origine"
            lblRioNum.Text = "Numéro RIO"
            lblOnNum.Text = "Numéro ON"
            lblCMExt.Text = "Enquêteur(s)"
            lblSienaNum.Text = "Numéro Siena"
            lblSienaPictures.Text = "Photos envoyées"
            lblon1.Text = "le"
            lblon2.Text = "le"
            lblNSPTitle.Text = "PNS"
            lblProactiveTitle.Text = "Proactif"
            lblProactive.Text = "Proactif"
            lblProactiveDate.Text = "le"
            lblInvestigationTitle.Text = "Information"
            lblInvestigation.Text = "Information"
            lblInvestigationDate.Text = "le"
            lblInvestigationMagistrate.Text = "Magistrat"
            lblJudInvestigationTitle.Text = "Instruction"
            lblJudInvestigation.Text = "Instruction"
            lblJudInvestigationDate.Text = "le"
            lblJudInvestigationMagistrate.Text = "Magistrat"
            lblFederalizedTitle.Text = "Fédéralisé"
            lblFederalized.Text = "Fédéralisé"
            lblFederalizedDate.Text = "le"
            lblFederalizedMagistrate.Text = "Magistrat"
            lblSummary.Text = "Résumé des faits"
            ToolTip.SetToolTip(btnSave, "Sauvegarder")
            ToolTip.SetToolTip(btnFolder, "Ouvrir le répertoire")
            ToolTip.SetToolTip(btnExit, "Quitter")
            ToolTip.SetToolTip(txtSienaDate, "Appuyez sur del pour effacer")
            ToolTip.SetToolTip(txtSienaPicturesDate, "Appuyez sur del pour effacer")
            ToolTip.SetToolTip(txtProactiveDate, "Appuyez sur del pour effacer")
            ToolTip.SetToolTip(txtInvestigationDate, "Appuyez sur del pour effacer")
            ToolTip.SetToolTip(txtJudInvestigationDate, "Appuyez sur del pour effacer")
            ToolTip.SetToolTip(txtFederalizedDate, "Appuyez sur del pour effacer")
            lblCannabis.Text = "A.03.01. Cannabis - production"
            lblSyntheticP.Text = "A.03.03. Drogues synthétiques - production"
            lblSyntheticT.Text = "A.03.04. Drogues synthétiques - trafic"
            lblCocaine.Text = "A.03.05. Cocaïne - importation et exportation"
            If DirectCast(CASESBindingSource.Current, DataRowView).Item("CREATED ON") IsNot DBNull.Value AndAlso CStr(DirectCast(CASESBindingSource.Current, DataRowView).Item("CREATED BY")) <> String.Empty Then
                lblCreated.Text = $"Créé par {CStr(DirectCast(CASESBindingSource.Current, DataRowView).Item("CREATED BY"))} le {Format(DirectCast(CASESBindingSource.Current, DataRowView).Item("CREATED ON"), "dd/MM/yyyy")}"
            Else
                lblCreated.Visible = False
            End If
        End If
    End Sub
    Public Sub FillCombo()
        'Fill comboboxes
        If cmbLang.SelectedIndex = 0 Then
            cmbSupport.Items.Add("Lokale politie")
            cmbSupport.Items.Add("Federale politie")
            cmbOrigin.Items.Add("DGJ 01 - Eigen onderzoek")
            cmbOrigin.Items.Add("DGJ 02 - Lateraal onderzoek")
            cmbOrigin.Items.Add("DGJ 03 - Federale onderzoek")
            cmbOrigin.Items.Add("DGJ 04 - Buitenland onderzoek")
        Else
            cmbSupport.Items.Add("Police locale")
            cmbSupport.Items.Add("Police fédérale")
            cmbOrigin.Items.Add("DGJ 01 - Enquête propre")
            cmbOrigin.Items.Add("DGJ 02 - Enquête latérale")
            cmbOrigin.Items.Add("DGJ 03 - Enquête fédérale")
            cmbOrigin.Items.Add("DGJ 04 - Enquête étrangère")
        End If
    End Sub
    Private Sub HideControls()
        Dim lst_controls As New List(Of Control)
        For Each c As CheckBox In FindControlRecursive(lst_controls, Me, GetType(CheckBox))
            c.Visible = False
        Next
        lst_controls = New List(Of Control)
        For Each c As RadioButton In FindControlRecursive(lst_controls, Me, GetType(RadioButton))
            c.Visible = False
        Next
        cmbNSP.Visible = False
    End Sub
    Private Sub frmCase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.R) Then
            Top = CInt((Screen.PrimaryScreen.Bounds.Height - Height) / 2)
            Left = CInt((Screen.PrimaryScreen.Bounds.Width - Width) / 2)
        End If
    End Sub
    Sub SetColors()
        'Set colors of controls according to choosen theme
        ForeColor = theme("Font")
        pnlTitle.BackColor = theme("Dark")
        pnlControls.BackColor = theme("Dark")
        pnlMenu.BackColor = theme("Medium")
        pnlLogo.BackColor = theme("Medium")
        Dim lst_controls As New List(Of Control)
        For Each c As Panel In FindControlRecursive(lst_controls, Me, GetType(Panel))
            c.ForeColor = theme("Font")
        Next
        lst_controls = New List(Of Control)
        For Each c As IconButton In FindControlRecursive(lst_controls, Me, GetType(IconButton))
            c.IconColor = theme("Font")
        Next
        lst_controls = New List(Of Control)
        For Each c As Panel In FindControlRecursive(lst_controls, pnlCenter, GetType(Panel))
            c.BackColor = theme("Medium")
        Next
        pnlCenter.BackColor = theme("Light")
        lst_controls = New List(Of Control)({lblNSPTitle, lblProactiveTitle, lblInvestigationTitle, lblJudInvestigationTitle, lblFederalizedTitle})
        For Each c As Label In lst_controls
            c.BackColor = theme("Light")
        Next
        For Each p As Panel In pnlCenter.Controls
            AddBorderToPanel(pnlCenter, p, theme("High"))
        Next
    End Sub
    Private Sub txtCaseName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCaseName.KeyPress
        'Disable "/" and "*" char
        If e.KeyChar = "/" OrElse e.KeyChar = "*" Then
            e.Handled = True
        ElseIf e.KeyChar = ChrW(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
    Private Sub cmbNoInput(sender As Object, e As KeyPressEventArgs) Handles cmbTypeOfCase.KeyPress, cmbSupport.KeyPress, cmbOrigin.KeyPress, cmbLang.KeyPress, cmbCMInt.KeyPress
        'Make comboboxes read-only
        e.Handled = True
    End Sub
    Private Sub HideDefaultDates()
        'Hide default dates
        Dim lst_controls As New List(Of DateTimePicker)({txtDate, txtSienaDate, txtSienaPicturesDate, txtProactiveDate, txtInvestigationDate, txtJudInvestigationDate, txtFederalizedDate})
        Dim lst_fields As New List(Of String)({"DATE FACTS", "SIENA REPORT DATE", "SIENA PICTURES DATE", "PROACTIVE DATE", "INVESTIGATION DATE", "JUD INVESTIGATION DATE", "FEDERALIZED DATE"})
        For i As Integer = 0 To lst_controls.Count - 1
            HideDate(CASESBindingSource, lst_controls(i), lst_fields(i))
        Next
    End Sub
    Private Sub CreateDatFile()
        'Create case dat file
        actualCase = txtCaseName.Text
        File.Create($"{dora_path}SYSTEM\CAS,,{actualCase},,{user}.dat").Dispose()
        If File.Exists($"{dora_path}SYSTEM\CAS,,{previousCase},,{user}.dat") AndAlso previousCase <> actualCase Then
            File.Delete($"{dora_path}SYSTEM\CAS,,{previousCase},,{user}.dat")
        End If
        previousCase = actualCase
    End Sub
#End Region

End Class
