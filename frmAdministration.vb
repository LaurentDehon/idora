Imports System.IO
Public Class frmAdministration
    Dim firstX As Integer
    Dim firstY As Integer
    Dim lbuttonDown As Boolean
    Dim CaseInt As Boolean
    Dim Prefix As String
    Dim dateint As Date
    Private Sub frmAdministration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fill and sort datatables
        SEIZURETableAdapter.Fill(DORADbDS.SEIZURE)
        CASESTableAdapter.Fill(DORADbDS.CASES)
        'Translate GUI
        Trad()
        'Fill comboboxes
        FillCombo()
        cmbYearInv.SelectedIndex = 0
        dgvSeizures.Columns(1).DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("en-001")
    End Sub
    Private Sub Trad()
        'Translate GUI
        If Lang = 1 Then
            Text = "Administratie"
            mnDeleteSeizure.Text = "Verwijder"
            mnViewIntervention.Text = "Interventie tonen"
            mnViewInventory.Text = "Interventie tonen"
            mnViewSeizure.Text = "Interventie tonen"
            mnViewCase.Text = "Dossier tonen"
            gbCheck.Text = "Controle"
            gbInventory.Text = "Inventaris zoeken"
            gbSeizure.Text = "Inbeslagnames"
            ToolTip.SetToolTip(btnOk, "Wijzigingen opslaan en terugkeren naar overzicht")
            ToolTip.SetToolTip(btnSave, "Wijzigingen opslaan")
            ToolTip.SetToolTip(btnCancel, "Annuleren en terugkeren naar overzicht")
            HelpToolStripMenuItem.Text = "Hulp"
        Else
            Text = "Administration"
            mnDeleteSeizure.Text = "Supprimer"
            mnViewIntervention.Text = "Visualiser l'intervention"
            mnViewInventory.Text = "Visualiser l'intervention"
            mnViewSeizure.Text = "Visualiser l'intervention"
            mnViewCase.Text = "Visualiser le dossier"
            gbCheck.Text = "Contrôle"
            gbInventory.Text = "Recherche dans les inventaires"
            gbSeizure.Text = "Saisies"
            ToolTip.SetToolTip(btnOk, "Enregistrer les modifications et retourner à la vue d'ensemble")
            ToolTip.SetToolTip(btnSave, "Enregistrer les modifications")
            ToolTip.SetToolTip(btnCancel, "Annuler et retourner à la vue d'ensemble")
            HelpToolStripMenuItem.Text = "Aide"
        End If
    End Sub
    Private Sub FillCombo()
        'Fill comboboxes
        If Lang = 1 Then
            cmbSearch.Items.Add("Geen Siena nummer")
            cmbSearch.Items.Add("GALoP e-mail niet verzonden")
            cmbSearch.Items.Add("Niet gedeponeerde Staalname")
            cmbSearch.Items.Add("Niet voltooide interventie")
            cmbSearch.Items.Add("Inventaris niet gedaan")
            cmbSearch.Items.Add("Fotodossier niet gedaan")
            cmbSearch.Items.Add("NICC verslag niet gedaan")
            cmbSearch.Items.Add("PV CRU niet gedaan")
            ToolTip.SetToolTip(btnOk, "Wijzigingen opslaan en sluiten")
            ToolTip.SetToolTip(btnSave, "Wijzigingen opslaan")
            ToolTip.SetToolTip(btnCancel, "Annuleren en sluiten")
            mnViewCase.Text = "Dossier tonen"
            mnViewIntervention.Text = "Interventie tonen"
            mnDeleteSeizure.Text = "Verwijder"
        Else
            cmbSearch.Items.Add("Pas de numéro Siena")
            cmbSearch.Items.Add("E-mail GALoP pas envoyé")
            cmbSearch.Items.Add("Échantillons pas déposés")
            cmbSearch.Items.Add("Interventions pas clôturées")
            cmbSearch.Items.Add("Inventaire pas terminé")
            cmbSearch.Items.Add("Dossier photos pas terminé")
            cmbSearch.Items.Add("Rapport INCC pas terminé")
            cmbSearch.Items.Add("PV CRU pas terminé")
            ToolTip.SetToolTip(btnOk, "Enregistrer les modification et quitter")
            ToolTip.SetToolTip(btnSave, "Enregistrer les modifications")
            ToolTip.SetToolTip(btnCancel, "Annuler et quitter")
            mnViewCase.Text = "Visualiser le dossier"
            mnViewIntervention.Text = "Visualiser l'intervention"
            mnDeleteSeizure.Text = "Supprimer"
        End If
        For i As Integer = Year(Now) To 2019 Step -1
            cmbYearInv.Items.Add(i)
        Next
    End Sub
    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged
        'Ask database depending on user's choice
        Dim con As New OleDb.OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dora_path}DORADb.accdb")
        Try
            Dim sql As String = String.Empty
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            Select Case cmbSearch.SelectedIndex
                Case 0
                    sql = String.Format("SELECT [ID], [DATE FACTS], [CASE NAME] FROM [CASES] WHERE [DATE FACTS] > #12/31/2017# AND ([SIENA NUM] Is Null Or Trim([SIENA NUM]) = '') ORDER BY [DATE FACTS] DESC")
                    CaseInt = True
                Case 1
                    sql = String.Format("SELECT [ID], [DATE FACTS], [CASE NAME] FROM [CASES] WHERE [DATE FACTS] > #12/31/2017# AND [GALOP] = False ORDER BY [DATE FACTS] DESC")
                    CaseInt = True
                Case 2
                    sql = String.Format("SELECT [ID CRU], [DATE INT], [CASE NAME] FROM [INTERVENTIONS] WHERE [SAMPLES DELIVERY DATE] Is Null AND [INTDONE] = False ORDER BY [DATE INT] DESC")
                    CaseInt = False
                Case 3
                    sql = String.Format("SELECT [ID CRU], [DATE INT], [CASE NAME] FROM [INTERVENTIONS] WHERE [INTDONE] = False ORDER BY [DATE INT] DESC")
                    CaseInt = False
                Case 4
                    sql = String.Format("SELECT [ID CRU], [DATE INT], [CASE NAME] FROM [INTERVENTIONS] WHERE [INVENTORY] = False AND [INTDONE] = False ORDER BY [DATE INT] DESC")
                    CaseInt = False
                Case 5
                    sql = String.Format("SELECT [ID CRU], [DATE INT], [CASE NAME] FROM [INTERVENTIONS] WHERE [PICTURES REPORT] = False AND [INTDONE] = False ORDER BY [DATE INT] DESC")
                    CaseInt = False
                Case 6
                    sql = String.Format("SELECT [ID CRU], [DATE INT], [CASE NAME] FROM [INTERVENTIONS] WHERE [NICC REPORT] = False AND [INTDONE] = False ORDER BY [DATE INT] DESC")
                    CaseInt = False
                Case 7
                    sql = String.Format("SELECT [ID CRU], [DATE INT], [CASE NAME] FROM [INTERVENTIONS] WHERE [CRU REPORT] = False AND [INTDONE] = False ORDER BY [DATE INT] DESC")
                    CaseInt = False
            End Select
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            dgvCheck.DataSource = dt
            dgvCheck.Columns(0).Width = 0
            dgvCheck.Columns(1).Width = 90
            dgvCheck.Columns(1).DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("en-001")
            dgvCheck.Columns(1).DefaultCellStyle.Format = "dd/MM/yyyy"
            dgvCheck.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            If Lang = 1 Then
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub dgvCheck_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCheck.CellMouseDown
        'Show right click menu depending on the case or intervention request
        If e.Button = Windows.Forms.MouseButtons.Right Then
            dgvCheck.ClearSelection()
            If e.ColumnIndex <> -1 AndAlso e.RowIndex <> -1 Then
                Dim cell = dgvCheck.Item(e.ColumnIndex, e.RowIndex)
                dgvCheck.CurrentCell = cell
                cell.Selected = True
                If CaseInt = True Then
                    dgvCheck.ContextMenuStrip = RCMenuCase
                Else
                    dgvCheck.ContextMenuStrip = RCMenuIntervention
                End If
            End If
        End If
    End Sub
    Private Sub dgvInventory_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInventory.CellMouseDown
        'Show right click menu depending on the case or intervention request
        If e.Button = Windows.Forms.MouseButtons.Right Then
            dgvInventory.ClearSelection()
            If e.ColumnIndex <> -1 AndAlso e.RowIndex <> -1 Then
                Dim cell = dgvInventory.Item(e.ColumnIndex, e.RowIndex)
                dgvInventory.CurrentCell = cell
                cell.Selected = True
                dgvInventory.ContextMenuStrip = RCMenuInventory
            End If
        End If
    End Sub
    Private Sub mnViewIntervention_Click(sender As Object, e As EventArgs) Handles mnViewIntervention.Click
        'Go to Intervention window
        'Check if another Intervention window isn't already open
        If Application.OpenForms().OfType(Of frmIntervention).Any Then
            If Lang = 1 Then
                MessageBox.Show("Een interventie is al open", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Une intervention est déjà ouvert", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{dgvCheck.Item(2, dgvCheck.CurrentRow.Index).Value}'")
            If CaseRow.Length > 0 Then
                IntLang = CaseRow(0)("LANG")
                If Not IsDBNull(CaseRow(0)("REPORT NUM")) Then ReportNum = CaseRow(0)("REPORT NUM")
                TypeOfCase = CaseRow(0)("TYPE OF CASE")
                CRUFile = CaseRow(0)("FILE NUM")
                IntNum = dgvCheck.Item(0, dgvCheck.CurrentRow.Index).Value
                Cursor = Cursors.WaitCursor
                log("ADM.", $"open intervention {IntNum}")
                frmIntervention.Show()
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
    Private Sub mnViewCase_Click(sender As Object, e As EventArgs) Handles mnViewCase.Click
        'Go to Case window
        'Check if another Case window isn't already open
        If Application.OpenForms().OfType(Of frmCases).Any Then
            If Lang = 1 Then
                MessageBox.Show("Een dossier is al open", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Un dossier est déjà ouvert", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            CaseName = dgvCheck.Item(2, dgvCheck.CurrentRow.Index).Value
            Cursor = Cursors.WaitCursor
            log("ADM.", $"open case {CaseName}")
            frmCases.Show()
            Cursor = Cursors.Default
            frmCases.CASESBindingSource.Filter = $"[CASE NAME] = '{CaseName}'"
        End If
    End Sub
    Private Sub txtSearchInv_TextChanged(sender As Object, e As EventArgs) Handles txtSearchInv.TextChanged
        'Start and stop timer
        If txtSearchInv.Text.Length > 1 Then
            Timer1.Stop()
            Timer1.Start()
        End If
    End Sub
    Private Sub cmbYearInv_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbYearInv.SelectionChangeCommitted
        'Update search
        If txtSearchInv.Text.Length > 1 Then
            txtSearchInv_TextChanged(sender, e)
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Search Inventory database
        Timer1.Stop()
        Dim INV As String = $"INV{cmbYearInv.Text}"
        Dim con As New OleDb.OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dora_path}DORAInv.accdb")
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            sql = String.Format($"SELECT DISTINCT [ID CRU], [DATE INT], [CASE NAME] FROM [;Database={dora_path}DORADb.accdb].[INTERVENTIONS] LEFT JOIN {INV} ON [INTERVENTIONS].[ID CRU] = {INV}.[IDINT] WHERE [NUM] LIKE '%{txtSearchInv.Text}%' ORDER BY [DATE INT] DESC")
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            dgvInventory.DataSource = dt
            dgvInventory.Columns(0).Width = 0
            dgvInventory.Columns(1).Width = 90
            dgvInventory.Columns(1).DefaultCellStyle.Format = "dd/MM/yyyy"
            dgvInventory.Columns(1).DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("en-001")
            dgvInventory.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            If Lang = 1 Then
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub mnViewInventory_Click(sender As Object, e As EventArgs) Handles mnViewInventory.Click
        'Go to Intervention window
        'Check if another Intervention window isn't already open
        If Application.OpenForms().OfType(Of frmIntervention).Any Then
            If Lang = 1 Then
                MessageBox.Show("Een interventie is al open", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Une intervention est déjà ouverte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{dgvInventory.Item(2, dgvInventory.CurrentRow.Index).Value}'")
            If CaseRow.Length > 0 Then
                IntLang = CaseRow(0)("LANG")
                If Not IsDBNull(CaseRow(0)("FILE NUM")) Then CRUFile = CaseRow(0)("FILE NUM")
                If Not IsDBNull(CaseRow(0)("TYPE OF CASE")) Then TypeOfCase = CaseRow(0)("TYPE OF CASE")
                If Not IsDBNull(CaseRow(0)("REPORT NUM")) Then ReportNum = CaseRow(0)("REPORT NUM")
                IntNum = dgvInventory.Item(0, dgvInventory.CurrentRow.Index).Value
                Cursor = Cursors.WaitCursor
                log("ADM.", $"open intervention {IntNum}")
                frmIntervention.Show()
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
    Private Sub txtSearchInv_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSearchInv.MouseDoubleClick
        'Reset search field
        txtSearchInv.Text = String.Empty
        Timer1.Stop()
        dgvInventory.DataSource = Nothing
    End Sub
    Private Sub txtSearchSeizure_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSeizure.TextChanged
        'Start and stop timer
        Timer2.Stop()
        Timer2.Start()
        pic.Image = Nothing
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Search Seizure datatable
        SEIZUREBindingSource.Filter = $"[DESC] LIKE '%{txtSearchSeizure.Text}%' OR [CASE NAME] LIKE '%{txtSearchSeizure.Text}%'"
    End Sub
    Private Sub txtSearchSeizure_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSearchSeizure.MouseDoubleClick
        'Reset search field
        txtSearchSeizure.Text = String.Empty
        pic.Image = Nothing
    End Sub
    Private Sub dgvSeizures_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSeizures.CellMouseDown
        'Show right click menu
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If e.ColumnIndex <> -1 AndAlso e.RowIndex <> -1 Then
                dgvSeizures.ClearSelection()
                Dim cell = dgvSeizures.Item(e.ColumnIndex, e.RowIndex)
                dgvSeizures.CurrentCell = cell
                cell.Selected = True
                dgvSeizures.ContextMenuStrip = RCMenuSeizure
            End If
        End If
    End Sub
    Private Sub mnViewSeizure_Click(sender As Object, e As EventArgs) Handles mnViewSeizure.Click
        'Go to Intervention window
        'Check if another Intervention window isn't already open
        If Application.OpenForms().OfType(Of frmIntervention).Any Then
            If Lang = 1 Then
                MessageBox.Show("Een interventie is al open", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Une intervention est déjà ouvert", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{dgvSeizures.Item(3, dgvSeizures.CurrentRow.Index).Value}'")
            If CaseRow.Length > 0 Then
                IntLang = CaseRow(0)("LANG")
                If Not IsDBNull(CaseRow(0)("REPORT NUM")) Then ReportNum = CaseRow(0)("REPORT NUM")
                TypeOfCase = CaseRow(0)("TYPE OF CASE")
                CRUFile = CaseRow(0)("FILE NUM")
                IntNum = dgvSeizures.Item(0, dgvSeizures.CurrentRow.Index).Value
                Cursor = Cursors.WaitCursor
                frmIntervention.Show()
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
    Private Sub dgvSeizures_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSeizures.SelectionChanged
        'Display image
        If dgvSeizures.Rows.Count > 0 Then
            Prefix = String.Empty
            pic.Image = Nothing
            Prefix = SEIZUREBindingSource.Current(5)
            If SEIZUREBindingSource.Current(5).ToString.Contains(".") Then
                If (Prefix).Count(Function(c) Char.IsDigit(c)) = 2 Then
                    Prefix = Prefix.Insert(Prefix.Length - 3, "00")
                    Prefix = Prefix.Insert(Prefix.Length - 1, "00")
                ElseIf (Prefix).Count(Function(c) Char.IsDigit(c)) = 3 Then
                    Dim n As String() = Split(Prefix, ".")
                    If n(1).ToString.Length = 1 Then
                        Prefix = Prefix.Insert(Prefix.Length - 4, "0")
                        Prefix = Prefix.Insert(Prefix.Length - 1, "00")
                    Else
                        Prefix = Prefix.Insert(Prefix.Length - 4, "00")
                        Prefix = Prefix.Insert(Prefix.Length - 2, "0")
                    End If
                ElseIf (Prefix).Count(Function(c) Char.IsDigit(c)) = 4 Then
                    Prefix = Prefix.Insert(Prefix.Length - 5, "0")
                    Prefix = Prefix.Insert(Prefix.Length - 2, "0")
                End If
            Else
                If (Prefix).Count(Function(c) Char.IsDigit(c)) = 1 Then
                    Prefix = Prefix.Insert(Prefix.Length - 1, "00")
                ElseIf (Prefix).Count(Function(c) Char.IsDigit(c)) = 2 Then
                    Prefix = Prefix.Insert(Prefix.Length - 2, "0")
                End If
            End If
            dateint = SEIZUREBindingSource.Current(1)
            If My.Computer.FileSystem.FileExists($"{dora_path}SEIZURES\{Prefix} ({dateint:dd-MM-yyyy}).jpg") Then
                Using Str As Stream = File.OpenRead($"{dora_path}SEIZURES\{Prefix} ({dateint:dd-MM-yyyy}).jpg")
                    pic.Image = Image.FromStream(Str)
                End Using
            End If
        End If
    End Sub
    Private Sub pic_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles pic.MouseDoubleClick
        'Display image fullscreen if exists...
        If My.Computer.FileSystem.FileExists($"{dora_path}SEIZURES\{Prefix} ({dateint:dd-MM-yyyy}).jpg") Then
            Process.Start($"{dora_path}SEIZURES\{Prefix} ({dateint:dd-MM-yyyy}).jpg")
        Else
            '...else ask user to load a new image
            Using OFD As New OpenFileDialog
                OFD.Title = "Load..."
                OFD.FileName = String.Empty
                OFD.DefaultExt = ".jpg"
                If OFD.ShowDialog() = DialogResult.OK Then
                    My.Computer.FileSystem.CopyFile(OFD.FileName, $"{dora_path}SEIZURES\{Prefix} ({dateint:dd-MM-yyyy}).jpg")
                    Using Str As Stream = File.OpenRead($"{dora_path}SEIZURES\{Prefix} ({dateint:dd-MM-yyyy}).jpg")
                        pic.Image = Image.FromStream(Str)
                    End Using
                End If
            End Using
        End If
    End Sub
    Private Sub mnDeleteSeizure_Click(sender As Object, e As EventArgs) Handles mnDeleteSeizure.Click
        'Delete seizure
        Dim i As Integer = dgvSeizures.CurrentRow.Index
        Dim Result As DialogResult
        If Lang = 1 Then
            Result = MessageBox.Show("Weet u het zeker?", "Verwijder", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Else
            Result = MessageBox.Show("Êtes-vous sûr?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If
        If Result = DialogResult.Yes Then
            If My.Computer.FileSystem.FileExists($"{dora_path}SEIZURES\{Prefix} ({dateint:dd-MM-yyyy}).jpg") Then
                My.Computer.FileSystem.DeleteFile($"{dora_path}SEIZURES\{Prefix} ({dateint:dd-MM-yyyy}).jpg")
            End If
            log("ADM.", "seizure deleted")
            SEIZUREBindingSource.RemoveCurrent()
            If i > 0 Then
                If i <> dgvSeizures.Rows.Count Then
                    dgvSeizures.Rows(i).Selected = True
                Else
                    dgvSeizures.Rows(i - 1).Selected = True
                End If
            Else
                pic.Image = Nothing
            End If
        End If
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Save changes and exit window
        Try
            Validate()
            SEIZUREBindingSource.EndEdit()
            SEIZURETableAdapter.Update(DORADbDS.SEIZURE)
            log("ADM.", "click on OK")
            Close()
        Catch ex As Exception
            If Lang = 1 Then
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Save changes
        Try
            Validate()
            SEIZUREBindingSource.EndEdit()
            SEIZURETableAdapter.Update(DORADbDS.SEIZURE)
            log("ADM.", "click on SAVE")
        Catch ex As Exception
            If Lang = 1 Then
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Discard changes and exit window
        Try
            Dim Result As DialogResult
            SEIZUREBindingSource.EndEdit()
            If DORADbDS.HasChanges Then
                If Lang = 1 Then
                    Result = MessageBox.Show($"U zult alle niet-opgeslagen wijzigingen verliezen.{Environment.NewLine}Weet u het zeker?", "Weet u het zeker?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Else
                    Result = MessageBox.Show($"Vous allez perdre tous les changements non sauvegardés.{Environment.NewLine}Voulez-vous continuer?", "Êtes-vous sûr", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                End If
                If Result = DialogResult.Yes Then
                    log("ADM.", "click on CANCEL")
                    Close()
                End If
            Else
                log("ADM.", "click on CANCEL")
                Close()
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
    End Sub
    Private Sub picMin_Click(sender As Object, e As EventArgs) Handles picMin.Click
        'Minimize window
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        'Show help
        Process.Start($"{dora_path}HELP\12__module_administration.htm")
    End Sub
    Private Sub lblTop_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTop.MouseDown
        'Grab the window
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = True
            firstX = e.X
            firstY = e.Y
        Else
            RCMenu.Show(lblTop, e.Location)
        End If
    End Sub
    Private Sub lblTop_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTop.MouseUp
        'Release the window
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = False
        End If
    End Sub
    Private Sub lblTop_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTop.MouseMove
        'Move the window
        If lbuttonDown Then
            Left = -firstX + PointToScreen(e.Location).X
            Top = PointToScreen(e.Location).Y
        End If
    End Sub

End Class