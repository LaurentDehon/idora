Option Explicit On
Option Strict On
Imports FontAwesome.Sharp
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Data.OleDb
Public Class frmNewInt
    Dim User As String
    Dim City As String
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub frmNewInt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetColors()
        Location = My.Settings.frmNewInt_loc
        'Fill and sort datatables
        CASESTableAdapter.Fill(DORADbDS.CASES)
        CASESBindingSource.Sort = "[DATE FACTS] DESC"
        INTERVENTIONSTableAdapter.Fill(DORADbDS.INTERVENTIONS)
        INTERVENTIONSBindingSource.Sort = "[DATE FACTS] DESC"
        frmMain.CITIESBindingSource1.Filter = String.Empty
        frmMain.CITIESBindingSource2.Filter = String.Empty
        cmbCaseName.Text = CaseName
        cmbCityInt.DataSource = frmMain.CITIESBindingSource1
        cmbCityInt.DisplayMember = "CITY"
        cmbCityFacts.DataSource = frmMain.CITIESBindingSource2
        cmbCityFacts.DisplayMember = "CITY"
        cmbCityInt.SelectedIndex = -1
        cmbCityFacts.SelectedIndex = -1
        Trad()
        FillCombo()
        GetUser()
        txtDateInt.Format = DateTimePickerFormat.Custom
        txtDateInt.CustomFormat = " "
        txtDateFacts.Format = DateTimePickerFormat.Custom
        txtDateFacts.CustomFormat = " "
    End Sub
    Private Sub frmNewInt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        cmbCaseName.SelectionLength = 0
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
#Region "Dates"
    Private Sub txtDateInt_ValueChanged(sender As Object, e As EventArgs) Handles txtDateInt.ValueChanged
        'If date entered, display it
        txtDateInt.Format = DateTimePickerFormat.Custom
        txtDateInt.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub txtDateFacts_ValueChanged(sender As Object, e As EventArgs) Handles txtDateFacts.ValueChanged
        'If date entered, display it
        txtDateFacts.Format = DateTimePickerFormat.Custom
        txtDateFacts.CustomFormat = "dd/MM/yyyy"
    End Sub
#End Region
#Region "Buttons"
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Create intervention
        'Check if all required fields are filled
        If cmbCaseName.Text <> String.Empty AndAlso cmbTypeOfInt.Text <> String.Empty AndAlso cmbTypeOfPlace.Text <> String.Empty AndAlso cmbInt.Text <> String.Empty AndAlso txtAdressInt.Text <> String.Empty AndAlso cmbCityInt.Text <> String.Empty Then
            Dim NewIntRow As DataRow = DORADbDS.Tables("INTERVENTIONS").NewRow()
            Dim DateInt As Date = CDate(txtDateInt.Text)
            Try
                'Save data to datatable then to database
                NewIntRow("CASE NAME") = cmbCaseName.Text
                NewIntRow("TYPE OF INT") = cmbTypeOfInt.Text
                NewIntRow("TYPE OF PLACE") = cmbTypeOfPlace.Text
                NewIntRow("INTPL") = cmbInt.Text
                NewIntRow("DATE INT") = txtDateInt.Text
                NewIntRow("ADRESS INT") = txtAdressInt.Text
                NewIntRow("ZIP INT") = txtZipInt.Text
                NewIntRow("CITY INT") = cmbCityInt.Text
                NewIntRow("INTDONE") = False
                If cmbInt.Text = "Ter plaatse" OrElse cmbInt.Text = "Sur place" Then
                    NewIntRow("DATE FACTS") = txtDateInt.Text
                    NewIntRow("ADRESS FACTS") = txtAdressInt.Text
                    NewIntRow("ZIP FACTS") = txtZipInt.Text
                    NewIntRow("CITY FACTS") = cmbCityInt.Text
                Else
                    NewIntRow("DATE FACTS") = txtDateFacts.Text
                    NewIntRow("ADRESS FACTS") = txtAdressFacts.Text
                    NewIntRow("ZIP FACTS") = txtZipFacts.Text
                    NewIntRow("CITY FACTS") = cmbCityFacts.Text
                End If
                NewIntRow("CREATED BY") = User
                NewIntRow("CREATED ON") = Format(Now, "dd/MMM/yyyy HH:mm")
                NewIntRow("CRU ON SITE") = True
                DORADbDS.Tables("INTERVENTIONS").Rows.Add(NewIntRow)
                INTERVENTIONSTableAdapter.Update(DORADbDS.INTERVENTIONS)
                'Get ID CRU
                Dim connection As New OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dora_path}DORADb.accdb")
                Dim cmd = New OleDbCommand("SELECT MAX([ID CRU]) FROM INTERVENTIONS", connection)
                connection.Open()
                IntNum = CInt(cmd.ExecuteScalar())
                connection.Close()
                'Create the intervention folder and copy all the folders inside
                If CRUFile.Substring(0, 3) Like "CRU" AndAlso CInt(CRUFile.Substring(3, 2)) > CInt("19") Then
                    Directory.CreateDirectory($"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U.\INT {IntNum} {DateInt:dd-MM-yy} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})")
                    FileIO.FileSystem.CopyDirectory($"{dora_path}FOLDERS INT\", $"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U.\INT {IntNum} {DateInt:dd-MM-yy} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})")
                ElseIf CRUFile.Substring(1, 2) = "19" Then
                    Directory.CreateDirectory($"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}\C.R.U.\INT {IntNum} {DateInt:dd-MM-yy} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})")
                    FileIO.FileSystem.CopyDirectory($"{dora_path}FOLDERS INT\", $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}\C.R.U.\INT {IntNum} {DateInt:dd-MM-yy} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})")
                Else
                    Directory.CreateDirectory($"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}\C.R.U.\INT {IntNum} {DateInt:dd-MM-yy} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})")
                    FileIO.FileSystem.CopyDirectory($"{dora_path}FOLDERS INT\", $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}\C.R.U.\INT {IntNum} {DateInt:dd-MM-yy} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})")
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
            frmCasesInterventions.RefreshDGVs()
            My.Settings.frmNewInt_loc = Location
            log("NEWI", $"new intervention created ({cmbCaseName.Text} / {cmbTypeOfInt.Text} / {txtDateInt.Text})")
            Close()
        Else
            If Lang = 1 Then
                MessageBox.Show("Ontbrekende data", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Données manquantes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Discard changes and exit window
        My.Settings.frmNewInt_loc = Location
        Close()
    End Sub
#End Region
#Region "Miscellaneous"
    Private Sub Trad()
        'Translate GUI
        If Lang = 1 Then
            Text = "Nieuwe interventie"
            lblCaseName.Text = "Dossiernaam"
            lblTypeOfInt.Text = "Interventietype"
            lblTypeOfPlace.Text = "Plaats"
            lblInt.Text = "Interventie"
            lblDateInt.Text = "Datum interventie"
            lblAdressInt.Text = "Adres"
            lblDateFacts.Text = "Datum feiten"
            lblAdressFacts.Text = "Adres"
            ToolTip.SetToolTip(btnOk, "Creëer de interventie")
            ToolTip.SetToolTip(btnCancel, "Annuleren")
            ToolTip.SetToolTip(btnSGS, "SGS adres")
            ToolTip.SetToolTip(btnRemondis, "Remondis adres")
            ToolTip.SetToolTip(btnIntToFacts, "Kopieer de gegevens van de interventie naar de feiten")
            ToolTip.SetToolTip(btnFactsToInt, "Kopieer de gegevens van de feiten naar de interventie")
        Else
            Text = "Nouvelle intervention"
            lblCaseName.Text = "Nom de dossier"
            lblTypeOfInt.Text = "Type d'intervention"
            lblTypeOfPlace.Text = "Lieu"
            lblInt.Text = "Intervention"
            lblDateInt.Text = "Date intervention"
            lblAdressInt.Text = "Adresse"
            lblDateFacts.Text = "Date faits"
            lblAdressFacts.Text = "Adresse"
            ToolTip.SetToolTip(btnOk, "Créer l'intervention")
            ToolTip.SetToolTip(btnCancel, "Annuler")
            ToolTip.SetToolTip(btnSGS, "Adresse de SGS")
            ToolTip.SetToolTip(btnRemondis, "Adresse de Remondis")
            ToolTip.SetToolTip(btnIntToFacts, "Copier les données de l'intervention vers les faits")
            ToolTip.SetToolTip(btnFactsToInt, "Copier les données des faits vers l'intervention")
        End If
    End Sub
    Private Sub FillCombo()
        'Fill comboboxes
        If IntLang = "Nederlands" Then
            cmbTypeOfInt.Items.Add("Labo in werking")
            cmbTypeOfInt.Items.Add("Achtergelaten labo")
            cmbTypeOfInt.Items.Add("Ontmanteld labo")
            cmbTypeOfInt.Items.Add("Labo in opbouw")
            cmbTypeOfInt.Items.Add("Labo in stand-by")
            cmbTypeOfInt.Items.Add("Dumping")
            cmbTypeOfInt.Items.Add("Opslagplaats")
            cmbTypeOfInt.Items.Add("Trafic")
            cmbTypeOfInt.Items.Add("Cannabis plantage")
            cmbTypeOfInt.Items.Add("Expertise")
            cmbTypeOfInt.Items.Add("Vervolg")
            cmbTypeOfInt.Items.Add("Geen drugs")
            cmbTypeOfInt.Items.Add("Geen interventie")
            cmbTypeOfInt.Items.Add("Andere")
            cmbTypeOfPlace.Items.Add("Woning")
            cmbTypeOfPlace.Items.Add("Hoeve")
            cmbTypeOfPlace.Items.Add("Openbare weg")
            cmbTypeOfPlace.Items.Add("Private plaats")
            cmbTypeOfPlace.Items.Add("Voertuig")
            cmbTypeOfPlace.Items.Add("Loods")
            cmbTypeOfPlace.Items.Add("Natuur")
            cmbTypeOfPlace.Items.Add("SGS")
            cmbTypeOfPlace.Items.Add("Remondis")
            cmbInt.Items.Add("Ter plaatse")
            cmbInt.Items.Add("Uitgestelde")
            cmbInt.Items.Add("SGS")
            cmbInt.Items.Add("Remondis")
        Else
            cmbTypeOfInt.Items.Add("Labo en fonction")
            cmbTypeOfInt.Items.Add("Labo abandonné")
            cmbTypeOfInt.Items.Add("Labo démantelé")
            cmbTypeOfInt.Items.Add("Labo en construction")
            cmbTypeOfInt.Items.Add("Labo en stand-by")
            cmbTypeOfInt.Items.Add("Dumping")
            cmbTypeOfInt.Items.Add("Stockage")
            cmbTypeOfInt.Items.Add("Traffic")
            cmbTypeOfInt.Items.Add("Plantation de cannabis")
            cmbTypeOfInt.Items.Add("Expertise")
            cmbTypeOfInt.Items.Add("Suite")
            cmbTypeOfInt.Items.Add("Pas de drogue")
            cmbTypeOfInt.Items.Add("Pas d'intervention")
            cmbTypeOfInt.Items.Add("Autre")
            cmbTypeOfPlace.Items.Add("Habitation")
            cmbTypeOfPlace.Items.Add("Ferme")
            cmbTypeOfPlace.Items.Add("Voie publique")
            cmbTypeOfPlace.Items.Add("Lieu privé")
            cmbTypeOfPlace.Items.Add("Véhicule")
            cmbTypeOfPlace.Items.Add("Entrepôt")
            cmbTypeOfPlace.Items.Add("Nature")
            cmbTypeOfPlace.Items.Add("SGS")
            cmbTypeOfPlace.Items.Add("Remondis")
            cmbInt.Items.Add("Sur place")
            cmbInt.Items.Add("Différée")
            cmbInt.Items.Add("SGS")
            cmbInt.Items.Add("Remondis")
        End If
    End Sub
    Private Sub GetUser()
        Dim user_list() As String = SearchFile($"{dora_path}cru.txt", Environment.UserName)
        User = user_list(0)
    End Sub
    Private Sub cmbInt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbInt.SelectedIndexChanged
        'Show or hide intervention / facts panel depending on the intervention choice and auto fill adress if SGS or REMONDIS intervention
        Select Case cmbInt.SelectedIndex
            'Intervention on the spot
            Case 0
                lblDateFacts.Visible = False
                lblAdressFacts.Visible = False
                txtDateFacts.Visible = False
                txtZipFacts.Visible = False
                txtAdressFacts.Visible = False
                cmbCityFacts.Visible = False
                txtAdressInt.Text = String.Empty
                txtZipInt.Text = String.Empty
                cmbCityInt.Text = String.Empty
                btnSGS.Visible = False
                btnRemondis.Visible = False
                btnFactsToInt.Visible = False
                btnIntToFacts.Visible = False
                If Lang = 1 Then
                    lblDateInt.Text = "Datum int. / feiten"
                Else
                    lblDateInt.Text = "Date int. / faits"
                End If
                Height = 389
                pnlMain.Height = 352
                btnOk.Location = New Point(240, 312)
                btnCancel.Location = New Point(282, 312)
                For Each c As Control In Me.Controls
                    If c.Name = "pnlMain_border" Then
                        c.Size = New Size(pnlMain.Width + 2, pnlMain.Height + 2)
                        c.Location = New Point(pnlMain.Location.X - 1, pnlMain.Location.Y - 1)
                    End If
                Next
            'Intervention delayed
            Case 1
                lblDateFacts.Visible = True
                lblAdressFacts.Visible = True
                txtDateFacts.Visible = True
                txtZipFacts.Visible = True
                txtAdressFacts.Visible = True
                cmbCityFacts.Visible = True
                txtAdressFacts.Text = String.Empty
                txtZipFacts.Text = String.Empty
                cmbCityFacts.Text = String.Empty
                txtAdressInt.Text = String.Empty
                txtZipInt.Text = String.Empty
                cmbCityInt.Text = String.Empty
                btnSGS.Visible = True
                btnRemondis.Visible = True
                btnFactsToInt.Visible = True
                btnIntToFacts.Visible = True
                If Lang = 1 Then
                    lblDateInt.Text = "Datum interventie"
                Else
                    lblDateInt.Text = "Date intervention"
                End If
                Height = 553
                pnlMain.Height = 512
                btnOk.Location = New Point(240, 472)
                btnCancel.Location = New Point(282, 472)
                For Each c As Control In Me.Controls
                    If c.Name = "pnlMain_border" Then
                        c.Size = New Size(pnlMain.Width + 2, pnlMain.Height + 2)
                        c.Location = New Point(pnlMain.Location.X - 1, pnlMain.Location.Y - 1)
                    End If
                Next
            'Intervention at SGS
            Case 2
                lblDateFacts.Visible = True
                lblAdressFacts.Visible = True
                txtDateFacts.Visible = True
                txtZipFacts.Visible = True
                txtAdressFacts.Visible = True
                cmbCityFacts.Visible = True
                txtAdressFacts.Text = String.Empty
                txtZipFacts.Text = String.Empty
                cmbCityFacts.Text = String.Empty
                btnSGS.Visible = True
                btnRemondis.Visible = True
                btnFactsToInt.Visible = True
                btnIntToFacts.Visible = True
                If Lang = 1 Then
                    lblDateInt.Text = "Datum interventie"
                Else
                    lblDateInt.Text = "Date intervention"
                End If
                txtZipInt.Text = "9120"
                cmbCityInt.Text = "MELSELE"
                txtAdressInt.Text = "Keetberglaan 4"
                Height = 553
                pnlMain.Height = 512
                btnOk.Location = New Point(240, 472)
                btnCancel.Location = New Point(282, 472)
                For Each c As Control In Me.Controls
                    If c.Name = "pnlMain_border" Then
                        c.Size = New Size(pnlMain.Width + 2, pnlMain.Height + 2)
                        c.Location = New Point(pnlMain.Location.X - 1, pnlMain.Location.Y - 1)
                    End If
                Next
            'Intervention at Remondis
            Case 3
                lblDateFacts.Visible = True
                lblAdressFacts.Visible = True
                txtDateFacts.Visible = True
                txtZipFacts.Visible = True
                txtAdressFacts.Visible = True
                cmbCityFacts.Visible = True
                txtAdressFacts.Text = String.Empty
                txtZipFacts.Text = String.Empty
                cmbCityFacts.Text = String.Empty
                btnSGS.Visible = True
                btnRemondis.Visible = True
                btnFactsToInt.Visible = True
                btnIntToFacts.Visible = True
                If Lang = 1 Then
                    lblDateInt.Text = "Datum interventie"
                Else
                    lblDateInt.Text = "Date intervention"
                End If
                txtZipInt.Text = "4040"
                cmbCityInt.Text = "HERSTAL"
                txtAdressInt.Text = "Rue des Alouettes 131"
                Height = 553
                pnlMain.Height = 512
                btnOk.Location = New Point(240, 472)
                btnCancel.Location = New Point(282, 472)
                For Each c As Control In Me.Controls
                    If c.Name = "pnlMain_border" Then
                        c.Size = New Size(pnlMain.Width + 2, pnlMain.Height + 2)
                        c.Location = New Point(pnlMain.Location.X - 1, pnlMain.Location.Y - 1)
                    End If
                Next
        End Select
    End Sub
    Private Sub txtAdressInt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdressInt.KeyPress
        'Disable special characters
        If (Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-") Then
            e.Handled = True
        End If
    End Sub
    Private Sub cmbCityInt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCityInt.KeyPress
        'Capitalize city
        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
    Private Sub cmbCityInt_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCityInt.SelectionChangeCommitted
        'Update zip
        frmMain.CITIESBindingSource1.Position = frmMain.CITIESBindingSource1.Find("CITY", txtZipInt.Text)
        txtZipInt.Text = CStr(DirectCast(frmMain.CITIESBindingSource1.Current, DataRowView).Item("ZIP CODE"))
    End Sub
    Private Sub txtZipInt_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtZipInt.MouseDoubleClick
        'Reset filter
        frmMain.CITIESBindingSource1.Filter = Nothing
        txtZipInt.Text = String.Empty
    End Sub
    Private Sub txtZipInt_TextChanged(sender As Object, e As EventArgs) Handles txtZipInt.TextChanged
        'Filter city combobox with zip code
        If txtZipInt.MaskCompleted = True Then
            frmMain.CITIESBindingSource1.Filter = $"[ZIP CODE]= '{txtZipInt.Text}'"
            If frmMain.CITIESBindingSource1.Count > 0 Then
                If City <> Nothing Then
                    cmbCityInt.Text = City
                Else
                    cmbCityInt.SelectedIndex = 0
                End If
            End If
        End If
    End Sub
    Private Sub txtZipInt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZipInt.KeyPress
        'Allow only numbers
        If Asc(e.KeyChar) < 48 OrElse Asc(e.KeyChar) > 57 OrElse e.KeyChar = ControlChars.Back Then
            e.Handled = True
        Else
            City = Nothing
        End If
    End Sub
    Private Sub txtAdressFacts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdressFacts.KeyPress
        'Disable special characters
        If (Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub cmbCityFacts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCityFacts.KeyPress
        'Capitalize city
        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
    Private Sub cmbCityFacts_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCityFacts.SelectionChangeCommitted
        'Update zip
        frmMain.CITIESBindingSource2.Position = frmMain.CITIESBindingSource2.Find("CITY", txtZipFacts.Text)
        txtZipFacts.Text = CStr(DirectCast(frmMain.CITIESBindingSource2.Current, DataRowView).Item("ZIP CODE"))
    End Sub
    Private Sub txtAdressInt_Leave(sender As Object, e As EventArgs) Handles txtAdressInt.Leave
        'Capitalize first letter
        If txtAdressInt.Text <> String.Empty Then
            txtAdressInt.Text = txtAdressInt.Text.Substring(0, 1).ToUpper + txtAdressInt.Text.Substring(1)
        End If
    End Sub
    Private Sub txtAdressFacts_Leave(sender As Object, e As EventArgs) Handles txtAdressFacts.Leave
        'Capitalize first letter
        If txtAdressFacts.Text <> String.Empty Then
            txtAdressFacts.Text = txtAdressFacts.Text.Substring(0, 1).ToUpper + txtAdressFacts.Text.Substring(1)
        End If
    End Sub
    Private Sub txtZipFacts_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtZipFacts.MouseDoubleClick
        'Reset filter
        frmMain.CITIESBindingSource2.Filter = Nothing
        txtZipFacts.Text = String.Empty
    End Sub
    Private Sub txtZipFacts_TextChanged(sender As Object, e As EventArgs) Handles txtZipFacts.TextChanged
        'Filter city combobox with zip code
        If txtZipFacts.MaskCompleted = True Then
            frmMain.CITIESBindingSource2.Filter = $"[ZIP CODE]= '{txtZipFacts.Text}'"
            If frmMain.CITIESBindingSource2.Count > 0 Then
                If City <> Nothing Then
                    cmbCityFacts.Text = City
                Else
                    cmbCityFacts.SelectedIndex = 0
                End If
            End If
        End If
    End Sub
    Private Sub txtZipFacts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZipFacts.KeyPress
        'Allow only numbers
        If Asc(e.KeyChar) < 48 OrElse Asc(e.KeyChar) > 57 OrElse e.KeyChar = ControlChars.Back Then
            e.Handled = True
        Else
            City = Nothing
        End If
    End Sub
    Private Sub btnSGS_Click(sender As Object, e As EventArgs) Handles btnSGS.Click
        txtZipInt.Text = "9120"
        cmbCityInt.Text = "MELSELE"
        txtAdressInt.Text = "Keetberglaan 4"
    End Sub
    Private Sub btnRemondis_Click(sender As Object, e As EventArgs) Handles btnRemondis.Click
        txtZipInt.Text = "4040"
        cmbCityInt.Text = "HERSTAL"
        txtAdressInt.Text = "Rue des Alouettes 131"
    End Sub
    Private Sub btnIntToFacts_Click(sender As Object, e As EventArgs) Handles btnIntToFacts.Click
        If txtDateInt.CustomFormat <> " " Then
            txtDateFacts.CustomFormat = "dd/MM/yyyy"
            txtDateFacts.Value = txtDateInt.Value
        End If
        txtZipFacts.Text = txtZipInt.Text
        cmbCityFacts.Text = cmbCityInt.Text
        txtAdressFacts.Text = txtAdressInt.Text
    End Sub
    Private Sub btnFactsToInt_Click(sender As Object, e As EventArgs) Handles btnFactsToInt.Click
        If txtDateFacts.CustomFormat <> " " Then
            txtDateInt.CustomFormat = "dd/MM/yyyy"
            txtDateInt.Value = txtDateFacts.Value
        End If
        txtZipInt.Text = txtZipFacts.Text
        cmbCityInt.Text = cmbCityFacts.Text
        txtAdressInt.Text = txtAdressFacts.Text
    End Sub
    Private Sub cmbNoInput(sender As Object, e As KeyPressEventArgs) Handles cmbTypeOfPlace.KeyPress, cmbTypeOfInt.KeyPress, cmbInt.KeyPress, cmbCaseName.KeyPress
        'Disable user input
        e.KeyChar = CChar(" ")
    End Sub
    Private Sub frmNewInt_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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