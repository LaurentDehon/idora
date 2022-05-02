Option Explicit On
Option Strict On
Imports System.IO
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class frmMain
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Private currentBtn As IconButton
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximumSize = New Size(Screen.FromControl(Me).WorkingArea.Width * 2, Screen.FromControl(Me).WorkingArea.Height)
        If My.Settings.frmMain_max = True Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
            Size = My.Settings.frmMain_size
            Location = My.Settings.frmMain_loc
        End If
        dora_path = My.Settings.dora_path
        files_path = My.Settings.files_path
        CheckPaths()
        SetTheme()
        SetColors()
        GetUser()
        CleanDatFiles()
        HandleLog()
        Trad()
        DisplayDate()
        ClockTimer.Start()
        ControlBox = False
        leftBorderBtn = New Panel With {
            .Size = New Size(7, 60)
        }
        pnlMenu.Controls.Add(leftBorderBtn)
        AddBorderToPanel(pnlCenter, picDORA, theme("High"))
        CheckBirthday()
        'CheckHolidays()
        'Fill and sort datatable
        BACKUPTableAdapter.Fill(DORADbDS.BACKUP)
        BACKUPBindingSource.Sort = "[ID] ASC"
        CITIESTableAdapter1.Fill(DORADbDS.CITIES)
        CITIESBindingSource1.Sort = "[CITY] ASC"
        CITIESTableAdapter2.Fill(DORADbDS.CITIES)
        CITIESBindingSource2.Sort = "[CITY] ASC"
        Backup()
    End Sub
#Region "Backup"
    Private Sub Backup()
        'Backup both DB files
        BACKUPBindingSource.MoveLast()
        Dim date1 As Date = Date.Now
        Dim date2 As Date = CDate(DirectCast(BACKUPBindingSource.Current, DataRowView).Item("BACKUP"))
        Dim days As Integer = (date1.Date - date2.Date).Days
        'If last backup is older than 5 days
        If days > 5 Then
            Try
                FileIO.FileSystem.CreateDirectory($"{dora_path}BACKUPS\{Format(date1, "yyyy-MM-dd")}")
                FileIO.FileSystem.CopyFile($"{dora_path}DORADb.accdb", $"{dora_path}BACKUPS\{Format(date1, "yyyy-MM-dd")}\DORADb.accdb")
                FileIO.FileSystem.CopyFile($"{dora_path}DORAInv.accdb", $"{dora_path}BACKUPS\{Format(date1, "yyyy-MM-dd")}\DORAInv.accdb")
                Dim NewBackupRow As DataRow = DORADbDS.Tables("BACKUP").NewRow()
                NewBackupRow("BACKUP") = Format(date1, "dd-MM-yyyy")
                log("MAIN", "new backup created")
                'If there are more than 4 backups
                If BACKUPBindingSource.Count > 4 Then
                    'Delete oldest backup
                    BACKUPBindingSource.MoveFirst()
                    Dim date3 As Date = CDate(DirectCast(BACKUPBindingSource.Current, DataRowView).Item("BACKUP"))
                    BACKUPBindingSource.RemoveCurrent()
                    FileIO.FileSystem.DeleteDirectory($"{dora_path}BACKUPS\{Format(date3, "yyyy-MM-dd")}", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    log("MAIN", "oldest backup deleted")
                End If
                'Create new backup
                DORADbDS.Tables("BACKUP").Rows.Add(NewBackupRow)
                BACKUPTableAdapter.Update(DORADbDS.BACKUP)
            Catch ex As Exception
                Return
            End Try
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        'Minimize window
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        'Minimize window
        Dim s As Screen = Screen.FromControl(Me)
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
            Size = New Size(Size.Width - 200, Size.Height - 200)
            My.Settings.frmMain_size = Size
            CenterToScreen()
        Else
            My.Settings.frmMain_max = True
            WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = theme("Light")
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = theme("Medium")
            currentBtn.ForeColor = theme("Font")
            currentBtn.IconColor = theme("Font")
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        Dim list_to_remove As New List(Of Control)
        For Each c As Control In Controls
            If c.GetType Is GetType(IconPictureBox) AndAlso c.Name.Substring(0, 4) Like "user" Then
                list_to_remove.Add(c)
            End If
        Next
        For i As Integer = 0 To list_to_remove.Count - 1
            Controls.Remove(list_to_remove(i))
        Next
    End Sub
    Private Sub imgCRU_Click(sender As Object, e As EventArgs) Handles imgCRU.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub
    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlCenter.Controls.Add(childForm)
        pnlCenter.Tag = childForm
        childForm.BringToFront()
        childForm.BackColor = theme("Light")
        childForm.Show()
    End Sub
    Private Sub btnCases_Click(sender As Object, e As EventArgs) Handles btnCases.Click
        ActivateButton(sender, RGBColors.btn_color1)
        OpenChildForm(New frmCasesInterventions)
        log("MAIN", "click on CASES")
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As MouseEventArgs) Handles btnSearch.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ActivateButton(sender, RGBColors.btn_color2)
            OpenChildForm(New frmSearch)
        Else
            btnSearch.ContextMenuStrip = RCMenuCases
        End If
        log("MAIN", "click on SEARCH")
    End Sub
    Private Sub mnOpenOut_Click(sender As Object, e As EventArgs) Handles mnOpenOut.Click
        If currentChildForm IsNot Nothing AndAlso currentChildForm.Name = "frmSearch" Then
            currentChildForm.Close()
        End If
        opened_out = True
        frmSearch.Show()
        frmSearch.FormBorderStyle = FormBorderStyle.Sizable
        frmSearch.ControlBox = False
        frmSearch.MinimumSize = New Size(1500, 800)
    End Sub
    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        ActivateButton(sender, RGBColors.btn_color3)
        OpenChildForm(New frmStats)
        log("MAIN", "click on STATS")
    End Sub
    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        ActivateButton(sender, RGBColors.btn_color4)
        OpenChildForm(New frmMembers)
        log("MAIN", "click on MEMBERS")
    End Sub
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        ActivateButton(sender, RGBColors.btn_color5)
        OpenChildForm(New frmProducts)
        log("MAIN", "click on PRODUCTS")
    End Sub
#End Region
#Region "Drag & move"
    Private Sub pnlTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTitle.MouseDown
        'Handle right click menu and move window
        If e.Button = Windows.Forms.MouseButtons.Right Then
            RCMenu.Show(pnlTitle, e.Location)
        Else
            ReleaseCapture()
            SendMessage(Handle, &H112&, &HF012&, 0)
        End If
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        picDORA.SendToBack()
        If pnlCenter.Width < 1000 Then
            picDORA.Width = CInt((pnlCenter.Width / 4) * 3)
            picDORA.Height = CInt(picDORA.Width / 2)
        End If
        picDORA.Left = CInt((pnlCenter.Width - picDORA.Width) / 2)
        picDORA.Top = CInt((pnlCenter.Height - picDORA.Height) / 2)
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
        For Each c As Control In pnlCenter.Controls
            If c.Name = "picDORA_border" Then
                c.Size = New Size(picDORA.Width + 2, picDORA.Height + 2)
                c.Location = New Point(picDORA.Location.X - 1, picDORA.Location.Y - 1)
                c.SendToBack()
            End If
        Next
    End Sub
#End Region
#Region "Miscellaneous"
    Public Sub Trad()
        'Translate GUI
        If Lang = 1 Then
            btnCases.Text = " Dossiers"
            btnProducts.Text = " Producten"
            btnMembers.Text = " Personeel"
            btnStats.Text = " Statistieken"
            btnSearch.Text = " Zoeken"
            btnExit.Text = " Verlaten"
            mnLanguage.Text = "Taal"
            mnTheme.Text = "Thema"
            mnOpenOut.Text = "Openen in een apart venster (Alt-X om te sluiten)"
            ToolTip.SetToolTip(imgCRU, "Terug naar de startpagina")
            ToolTip.SetToolTip(btnMin, "Minimaliseer")
            ToolTip.SetToolTip(btnMax, "Maximaliseer")
            ToolTip.SetToolTip(btnClose, "iDORA sluiten")
            ToolTip.SetToolTip(btnCases, "Dossiers module")
            ToolTip.SetToolTip(btnSearch, "Geavanceerd zoeken module")
            ToolTip.SetToolTip(btnStats, "Statistieken en grafische module")
            ToolTip.SetToolTip(btnMembers, "Personeel module")
            ToolTip.SetToolTip(btnProducts, "Producten module")
            ToolTip.SetToolTip(btnExit, "iDORA sluiten")
        Else
            btnCases.Text = " Dossiers"
            btnProducts.Text = " Produits"
            btnMembers.Text = " Personnel"
            btnStats.Text = " Statistiques"
            btnSearch.Text = " Recherche"
            btnExit.Text = " Quitter"
            mnLanguage.Text = "Langue"
            mnTheme.Text = "Theme"
            mnOpenOut.Text = "Ouvrir dans une fenêtre séparée (Alt-X pour fermer)"
            ToolTip.SetToolTip(imgCRU, "Revenir à la page d'accueil")
            ToolTip.SetToolTip(btnMin, "Minimiser")
            ToolTip.SetToolTip(btnMax, "Maximiser")
            ToolTip.SetToolTip(btnClose, "Quitter iDORA")
            ToolTip.SetToolTip(btnCases, "Module Dossiers et interventions")
            ToolTip.SetToolTip(btnSearch, "Module de recherche avancée")
            ToolTip.SetToolTip(btnStats, "Module statistiques et graphiques")
            ToolTip.SetToolTip(btnMembers, "Module Personnel")
            ToolTip.SetToolTip(btnProducts, "Module Produits")
            ToolTip.SetToolTip(btnExit, "Quitter iDORA")
        End If
    End Sub
    Private Sub CheckPaths()
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        If Not Directory.Exists(files_path) Then
            If Lang = 1 Then
                MessageBox.Show("Kan bestanden niet vinden", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Impossible de localiser les dossiers", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim fbd As New FolderBrowserDialog
            If Lang = 1 Then
                fbd.Description = "Selecteer de map met de bestanden"
            Else
                fbd.Description = "Veuillez sélectionner le répertoire contenant les dossiers"
            End If
            fbd.SelectedPath = "C:\"
            If fbd.ShowDialog() = DialogResult.OK Then
                files_path = $"{fbd.SelectedPath}\"
                My.Settings.files_path = files_path
                My.Settings.Save()
            Else
                Application.Exit()
                End
            End If
        End If
        If Not Directory.Exists(dora_path) Then
            If Lang = 1 Then
                MessageBox.Show("Kan de DORA-map niet vinden", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Impossible de localiser le répertoire DORA", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim fbd As New FolderBrowserDialog
            If Lang = 1 Then
                fbd.Description = "Selecteer de DORA-map"
            Else
                fbd.Description = "Veuillez sélectionner le répertoire DORA"
            End If
            fbd.SelectedPath = "C:\"
            If fbd.ShowDialog() = DialogResult.OK Then
                config.ConnectionStrings.ConnectionStrings("DORA.My.MySettings.DORADbConn").ConnectionString = config.ConnectionStrings.ConnectionStrings("DORA.My.MySettings.DORADbConn").ConnectionString.Replace(dora_path, fbd.SelectedPath)
                config.ConnectionStrings.ConnectionStrings("DORA.My.MySettings.DORAInvDS").ConnectionString = config.ConnectionStrings.ConnectionStrings("DORA.My.MySettings.DORAInvDS").ConnectionString.Replace(dora_path, fbd.SelectedPath)
                config.Save(ConfigurationSaveMode.Modified)
                dora_path = $"{fbd.SelectedPath}\"
                My.Settings.dora_path = dora_path
                My.Settings.Save()
            Else
                Application.Exit()
                End
            End If
        End If
        If Not File.Exists($"{config.ConnectionStrings.ConnectionStrings("DORA.My.MySettings.DORADbConn").ConnectionString.Split(CChar("="))(2)}") Then
            If Lang = 1 Then
                MessageBox.Show("Kan de hoofddatabase niet vinden", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Impossible de localiser la base de données principale", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim ofd As New OpenFileDialog
            If Lang = 1 Then
                ofd.Title = "Selecteer de hoofddatabase"
            Else
                ofd.Title = "Veuillez sélectionner la base de données principale"
            End If
            ofd.InitialDirectory = $"{dora_path}"
            If ofd.ShowDialog() = DialogResult.OK Then
                My.Settings.Item("DORADBConn") = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ofd.FileName}"
                config.ConnectionStrings.ConnectionStrings("DORA.My.MySettings.DORADbConn").ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ofd.FileName}"
                config.Save(ConfigurationSaveMode.Modified)
            Else
                Application.Exit()
                End
            End If
        End If
        If Not File.Exists($"{config.ConnectionStrings.ConnectionStrings("DORA.My.MySettings.DORADbConn").ConnectionString.Split(CChar("="))(2)}") Then
            If Lang = 1 Then
                MessageBox.Show("Kan de inventarisdatabase niet vinden", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Impossible de localiser la base de données des inventaires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim ofd As New OpenFileDialog
            If Lang = 1 Then
                ofd.Title = "Selecteer de inventarisdatabase"
            Else
                ofd.Title = "Veuillez sélectionner la base de données des inventaires"
            End If
            ofd.InitialDirectory = $"{dora_path}"
            If ofd.ShowDialog() = DialogResult.OK Then
                My.Settings.Item("DORAInvDS") = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ofd.FileName}"
                config.ConnectionStrings.ConnectionStrings("DORA.My.MySettings.DORAInvDS").ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ofd.FileName}"
                config.Save(ConfigurationSaveMode.Modified)
            Else
                Application.Exit()
                End
            End If
        End If
    End Sub
    Private Sub GetUser()
        'Select language and welcome message depending on user and date
        user = Environment.UserName
        Dim user_list() As String = SearchFile($"{dora_path}cru.txt", user)
        Try
            If My.Settings.Lang = 0 Then
                If user_list(2).ToLower = "fr" Then
                    lblHello.Text = $"Bienvenue {CultureInfo.InvariantCulture.TextInfo.ToTitleCase(user_list(0).ToLower()).Split(CChar(" "))(0)}"
                    Lang = 2
                Else
                    lblHello.Text = $"Welkom {CultureInfo.InvariantCulture.TextInfo.ToTitleCase(user_list(0).ToLower()).Split(CChar(" "))(0)}"
                    Lang = 1
                End If
            ElseIf My.Settings.Lang = 1 Then
                lblHello.Text = $"Welkom {CultureInfo.InvariantCulture.TextInfo.ToTitleCase(user_list(0).ToLower()).Split(CChar(" "))(0)}"
                Lang = 1
            ElseIf My.Settings.Lang = 2 Then
                lblHello.Text = $"Bienvenue {CultureInfo.InvariantCulture.TextInfo.ToTitleCase(user_list(0).ToLower()).Split(CChar(" "))(0)}"
                Lang = 2
            End If
            CheckBirthday()
        Catch IOORE As IndexOutOfRangeException
            If Lang = 1 Then
                MessageBox.Show("Ongeïdentificeerde gebruiker, dora zal nu afsluiten", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Utilisateur non identifié, dora va maintenant se fermer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub
    Private Sub SetTheme()
        theme = New Dictionary(Of String, Color)
        Select Case My.Settings.theme
            Case 0
                theme.Add("Light", RGBColors.TH1_Light)
                theme.Add("Medium", RGBColors.TH1_Medium)
                theme.Add("Dark", RGBColors.TH1_Dark)
                theme.Add("Font", RGBColors.TH1_Font)
                theme.Add("High", RGBColors.TH1_High)
            Case 1
                theme.Add("Light", RGBColors.TH2_Light)
                theme.Add("Medium", RGBColors.TH2_Medium)
                theme.Add("Dark", RGBColors.TH2_Dark)
                theme.Add("Font", RGBColors.TH2_Font)
                theme.Add("High", RGBColors.TH2_High)
            Case 2
                theme.Add("Light", RGBColors.TH3_Light)
                theme.Add("Medium", RGBColors.TH3_Medium)
                theme.Add("Dark", RGBColors.TH3_Dark)
                theme.Add("Font", RGBColors.TH3_Font)
                theme.Add("High", RGBColors.TH3_High)
            Case 3
                theme.Add("Light", RGBColors.TH4_Light)
                theme.Add("Medium", RGBColors.TH4_Medium)
                theme.Add("Dark", RGBColors.TH4_Dark)
                theme.Add("Font", RGBColors.TH4_Font)
                theme.Add("High", RGBColors.TH4_High)
            Case 4
                theme.Add("Light", RGBColors.TH5_Light)
                theme.Add("Medium", RGBColors.TH5_Medium)
                theme.Add("Dark", RGBColors.TH5_Dark)
                theme.Add("Font", RGBColors.TH5_Font)
                theme.Add("High", RGBColors.TH5_High)
        End Select
    End Sub
    Private Sub mnThemeDark_Click(sender As Object, e As EventArgs) Handles mnThemeDark.Click
        If Lang = 1 Then
            MessageBox.Show("iDORA moet herstarten om te veranderingen toe te passen", "Thema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("iDORA doit redémarrer pour appliquer les modifications", "Thème", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        My.Settings.theme = 0
    End Sub
    Private Sub mnThemeAbyss_Click(sender As Object, e As EventArgs) Handles mnThemeAbyss.Click
        If Lang = 1 Then
            MessageBox.Show("iDORA moet herstarten om te veranderingen toe te passen", "Thema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("iDORA doit redémarrer pour appliquer les modifications", "Thème", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        My.Settings.theme = 1
    End Sub
    Private Sub mnThemeKimbie_Click(sender As Object, e As EventArgs) Handles mnThemeKimbie.Click
        If Lang = 1 Then
            MessageBox.Show("iDORA moet herstarten om te veranderingen toe te passen", "Thema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("iDORA doit redémarrer pour appliquer les modifications", "Thème", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        My.Settings.theme = 2
    End Sub
    Private Sub mnThemeNoctis_Click(sender As Object, e As EventArgs) Handles mnThemeNoctis.Click
        If Lang = 1 Then
            MessageBox.Show("iDORA moet herstarten om te veranderingen toe te passen", "Thema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("iDORA doit redémarrer pour appliquer les modifications", "Thème", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        My.Settings.theme = 3
    End Sub
    Private Sub mnThemeDracula_Click(sender As Object, e As EventArgs) Handles mnThemeDracula.Click
        If Lang = 1 Then
            MessageBox.Show("iDORA moet herstarten om te veranderingen toe te passen", "Thema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("iDORA doit redémarrer pour appliquer les modifications", "Thème", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        My.Settings.theme = 4
    End Sub
    Private Sub mnLanguageN_Click(sender As Object, e As EventArgs) Handles mnLanguageN.Click
        If Lang = 1 Then
            MessageBox.Show("iDORA moet herstarten om te veranderingen toe te passen", "Thema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("iDORA doit redémarrer pour appliquer les modifications", "Thème", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        My.Settings.Lang = 1
        log("MAIN", "switch language to dutch")
    End Sub
    Private Sub mnLanguageF_Click(sender As Object, e As EventArgs) Handles mnLanguageF.Click
        If Lang = 1 Then
            MessageBox.Show("iDORA moet herstarten om te veranderingen toe te passen", "Thema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("iDORA doit redémarrer pour appliquer les modifications", "Thème", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        My.Settings.Lang = 2
        log("MAIN", "switch language to dutch")
    End Sub
    Private Sub DisplayDate()
        'Display date & time
        If Lang = 1 Then
            lblTime.Text = StrConv(Now.ToString("dddd d MMMM yyyy HH:mm:ss", New CultureInfo("nl-BE")), vbProperCase)
        Else
            lblTime.Text = StrConv(Now.ToString("dddd d MMMM yyyy HH:mm:ss", New CultureInfo("fr-BE")), vbProperCase)
        End If
    End Sub
    Private Sub CleanDatFiles()
        'Check for abandonned case dat files
        Dim files As String() = Directory.GetFiles($"{dora_path}SYSTEM", "*.dat")
        For Each f In files
            Dim parts As String() = Split(Path.GetFileNameWithoutExtension(f), ",,")
            If parts(2) = user Then File.Delete(f)
        Next
    End Sub
    Private Sub HandleLog()
        'Check for log file
        If Not File.Exists($"{dora_path}SYSTEM\log-{user}-{Now.Year}.txt") Then
            File.Create($"{dora_path}SYSTEM\log-{user}-{Now.Year}.txt").Dispose()
        End If
        log("MAIN", "start DORA")
    End Sub
    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        'Refresh time every second
        If Lang = 1 Then
            lblTime.Text = StrConv(Now.ToString("dddd d MMMM yyyy HH:mm:ss", New CultureInfo("nl-BE")), vbProperCase)
        Else
            lblTime.Text = StrConv(Now.ToString("dddd d MMMM yyyy HH:mm:ss", New CultureInfo("fr-BE")), vbProperCase)
        End If
    End Sub
    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.R) Then
            Top = CInt((Screen.PrimaryScreen.Bounds.Height - Height) / 2)
            Left = CInt((Screen.PrimaryScreen.Bounds.Width - Width) / 2)
        End If
    End Sub
    Private Sub SetColors()
        'Set colors of controls according to choosen theme
        ForeColor = theme("Font")
        pnlTitle.BackColor = theme("Dark")
        pnlControls.BackColor = theme("Dark")
        pnlMenu.BackColor = theme("Medium")
        pnlLogo.BackColor = theme("Medium")
        pnlCenter.BackColor = theme("Light")
        Dim lst_controls As New List(Of Control)
        For Each c As IconButton In FindControlRecursive(lst_controls, Me, GetType(IconButton))
            c.IconColor = theme("Font")
        Next
        'AddBorderToPanel(pnlCenter, picDora, theme("High"))
    End Sub
    Private Sub SaveWindow()
        If WindowState = FormWindowState.Maximized Then
            My.Settings.frmMain_max = True
        Else
            My.Settings.frmMain_max = False
        End If
        My.Settings.frmMain_loc = Location
        My.Settings.frmMain_size = Size
    End Sub
    Private Sub DeleteDatFiles()
        'Delete user's dat files
        If Directory.Exists(dora_path) Then
            Dim files As String() = Directory.GetFiles($"{dora_path}SYSTEM", "*.dat")
            For Each f In files
                Dim parts As String() = Split(Path.GetFileNameWithoutExtension(f), ",,")
                If parts(2) = user Then
                    File.Delete(f)
                End If
            Next
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnExit.Click
        SaveWindow()
        DeleteDatFiles()
        'Save every opened window positions
        If Application.OpenForms().OfType(Of frmIntervention).Any Then
            If frmIntervention.WindowState = FormWindowState.Minimized Then frmIntervention.WindowState = FormWindowState.Normal
            My.Settings.frmIntervention_loc = frmIntervention.Location
            'Delete int dat file
            If File.Exists($"{dora_path}SYSTEM\INT,,{IntNum},,{user}.dat") Then
                File.Delete($"{dora_path}SYSTEM\INT,,{IntNum},,{user}.dat")
            End If
        End If
        If Application.OpenForms().OfType(Of frmCases).Any Then
            If frmCases.WindowState = FormWindowState.Minimized Then frmCases.WindowState = FormWindowState.Normal
            My.Settings.frmCases_loc = frmCases.Location
            'Delete case dat file
            If File.Exists($"{dora_path}SYSTEM\CAS,,{frmCases.previousCase},,{user}.dat") Then
                File.Delete($"{dora_path}SYSTEM\CAS,,{frmCases.previousCase},,{user}.dat")
            End If
        End If
        If Application.OpenForms().OfType(Of frmReInt).Any Then
            If frmReInt.WindowState = FormWindowState.Minimized Then frmReInt.WindowState = FormWindowState.Normal
            My.Settings.frmReInt_loc = frmReInt.Location
        End If
        If Application.OpenForms().OfType(Of frmNewCase).Any Then
            If frmNewCase.WindowState = FormWindowState.Minimized Then frmNewCase.WindowState = FormWindowState.Normal
            My.Settings.frmNewCase_loc = frmNewCase.Location
        End If
        If Application.OpenForms().OfType(Of frmNewInt).Any Then
            If frmNewInt.WindowState = FormWindowState.Minimized Then frmNewInt.WindowState = FormWindowState.Normal
            My.Settings.frmNewInt_loc = frmNewInt.Location
        End If
        If Application.OpenForms().OfType(Of frmInventory).Any Then
            If frmInventory.WindowState = FormWindowState.Minimized Then frmInventory.WindowState = FormWindowState.Normal
            My.Settings.frmInventory_loc = Location
            'Delete inv dat file
            If File.Exists($"{dora_path}SYSTEM\INV,,{IntNum},,{user}.dat") Then
                File.Delete($"{dora_path}SYSTEM\INV,,{IntNum},,{user}.dat")
            End If
        End If
        log("MAIN", $"close DORA{Environment.NewLine}")
        Application.Exit()
    End Sub
#End Region

End Class