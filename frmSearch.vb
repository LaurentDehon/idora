Option Explicit On
Option Strict On
Imports FontAwesome.Sharp
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Reflection
Imports System.Threading
Imports System.Runtime.InteropServices
Public Class frmSearch
    Dim DateFrom As Date
    Dim DateTo As Date
    Dim StatsDV As DataView
    Dim DateInt As Date
    Dim TypeOfInt As String
    Dim AdressInt As String
    Dim CityInt As String
    Dim user_list() As String
    Dim user_color As String
    Dim user_name As String
    Dim thread As Thread
    Dim lst_results As New List(Of List(Of Integer))
    Dim counter_sel As Integer
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Start new thread
        thread = New Thread(AddressOf LoadData)
        thread.Start()
        SetColors()
        Trad()
        FillCombo()
        GetUser()
        EnableDoubleBuffered(dgvStats, True)
        fsw.Path = $"{dora_path}SYSTEM"
        If opened_out = True Then
            Location = My.Settings.frmSearch_loc
            Size = My.Settings.frmSearch_size
        End If
        'Load user data
        user_list = UserToList($"{dora_path}cru.txt", user)
        user_name = user_list(0)
        user_color = user_list(3)
        lblCount.Visible = False
        frmMain.CITIESBindingSource1.Sort = "[CITY] ASC"
        frmMain.CITIESBindingSource2.Filter = String.Empty
        cmbCity.DataSource = frmMain.CITIESBindingSource1
        cmbCity.DisplayMember = "CITY"
        cmbCity.SelectedIndex = -1
    End Sub
    Private Sub LoadData()
        'Fill and sort datatables
        CASESTableAdapter.Fill(DORADbDS.CASES)
        DRUGS_INTTableAdapter.Fill(DORADbDS.DRUGS_INT)
        INTERVENTIONSTableAdapter.Fill(DORADbDS.INTERVENTIONS)
        INTERVENTIONSBindingSource.Sort = "[DATE INT] DESC, [ID CRU] DESC"
    End Sub
#Region "Drag & move"
    Private Sub pnlTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvStats.MouseDown, SearchTable.MouseDown
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
#Region "File System Watcher"
    Private Sub fsw_Created(sender As Object, e As FileSystemEventArgs) Handles fsw.Created
        'Watch for created files in DORA folder
        Dim parts As String() = Split(Path.GetFileNameWithoutExtension(e.Name), ",,")
        If parts(0) = "INT" Then
            If Created = True AndAlso StatsDV.Count > 0 Then
                If dgvStats.DataSource IsNot Nothing Then
                    For Each row As DataGridViewRow In dgvStats.Rows
                        If row.Cells(0).Value.ToString = parts(1) Then
                            Dim i As Integer = row.Index
                            user_list = UserToList($"{dora_path}cru.txt", parts(2))
                            dgvStats.Rows(i).DefaultCellStyle.ForeColor = Color.FromName(user_list(3))
                            Exit Sub
                        End If
                    Next
                End If
            End If
        End If
    End Sub
    Private Sub fsw_Deleted(sender As Object, e As FileSystemEventArgs) Handles fsw.Deleted
        'Watch for deleted files in DORA folder
        Dim parts As String() = Split(Path.GetFileNameWithoutExtension(e.Name), ",,")
        If parts(0) = "INT" Then
            If Created = True AndAlso StatsDV.Count > 0 Then
                Try
                    If dgvStats.DataSource IsNot Nothing Then
                        For Each row As DataGridViewRow In dgvStats.Rows
                            If row.Cells(0).Value.ToString = parts(1) Then
                                Dim i As Integer = row.Index
                                dgvStats.Rows(i).DefaultCellStyle.ForeColor = theme("Font")
                            End If
                        Next
                    End If
                Catch ex As Exception
                    Return
                End Try
            End If
        End If
    End Sub
#End Region
#Region "Search"
    Private Function memberToDs(ds As DataSet) As DataSet
        'Create Dataset and datatable
        Try
            Dim newDs As DataSet = New DataSet
            Dim IDINT As Integer = Nothing
            Dim CASENAME As String = Nothing
            Dim TYPEOFINT As String = Nothing
            Dim DATEINT As Date = Nothing
            Dim ADRESSINT As String = Nothing
            Dim ZIPINT As Integer = Nothing
            Dim CITYINT As String = Nothing
            Dim DATEFACTS As Date = Nothing
            Dim ADRESSFACTS As String = Nothing
            Dim ZIPFACTS As Integer = Nothing
            Dim CITYFACTS As String = Nothing
            Dim TYPEOFPLACE As String = Nothing
            Dim ARRO As String = Nothing
            Dim DRUG As String = Nothing
            Dim MANAGER As String = Nothing
            Dim SAMPLEST As String = Nothing
            Dim SAMPLESN As String = Nothing
            Dim SAMPLESD As String = Nothing
            Dim SAMPLESC As String = Nothing
            Dim CRUREPORTN As String = Nothing
            Dim CRUREPORTD As String = Nothing
            Dim NICCREPORTN As String = Nothing
            Dim NICCREPORTD As String = Nothing
            Dim NICCREPORTC As String = Nothing
            Dim UNIT As String = Nothing
            Dim FILENUM As String = Nothing
            Dim REPORTNUM As String = Nothing
            Dim RIONUM As String = Nothing
            Dim ONNUM As String = Nothing
            Dim SIENANUM As String = Nothing
            Dim NSP As String = Nothing
            Dim LANG As String = Nothing
            Dim CMEXT As String = Nothing
            Dim INTDONE As Boolean = Nothing
            Dim CRUONSITE As Boolean = Nothing
            Dim DrugB As Boolean
            newDs.Tables.Add("INTS")
            newDs.Tables("INTS").Columns.Add("IDINT", GetType(Int32))
            newDs.Tables("INTS").Columns.Add("CASENAME", GetType(String))
            newDs.Tables("INTS").Columns.Add("TYPEOFINT", GetType(String))
            newDs.Tables("INTS").Columns.Add("DATEINT", GetType(Date))
            newDs.Tables("INTS").Columns.Add("ADRESSINT", GetType(String))
            newDs.Tables("INTS").Columns.Add("ZIPINT", GetType(Int32))
            newDs.Tables("INTS").Columns.Add("CITYINT", GetType(String))
            newDs.Tables("INTS").Columns.Add("DATEFACTS", GetType(Date))
            newDs.Tables("INTS").Columns.Add("ADRESSFACTS", GetType(String))
            newDs.Tables("INTS").Columns.Add("ZIPFACTS", GetType(Int32))
            newDs.Tables("INTS").Columns.Add("CITYFACTS", GetType(String))
            newDs.Tables("INTS").Columns.Add("SAMPLEST", GetType(String))
            newDs.Tables("INTS").Columns.Add("SAMPLESN", GetType(String))
            newDs.Tables("INTS").Columns.Add("SAMPLESD", GetType(Date))
            newDs.Tables("INTS").Columns.Add("SAMPLESC", GetType(String))
            newDs.Tables("INTS").Columns.Add("CRUREPORTN", GetType(String))
            newDs.Tables("INTS").Columns.Add("CRUREPORTD", GetType(Date))
            newDs.Tables("INTS").Columns.Add("NICCREPORTN", GetType(String))
            newDs.Tables("INTS").Columns.Add("NICCREPORTD", GetType(Date))
            newDs.Tables("INTS").Columns.Add("NICCREPORTC", GetType(String))
            newDs.Tables("INTS").Columns.Add("UNIT", GetType(String))
            newDs.Tables("INTS").Columns.Add("FILENUM", GetType(String))
            newDs.Tables("INTS").Columns.Add("REPORTNUM", GetType(String))
            newDs.Tables("INTS").Columns.Add("RIONUM", GetType(String))
            newDs.Tables("INTS").Columns.Add("ONNUM", GetType(String))
            newDs.Tables("INTS").Columns.Add("SIENANUM", GetType(String))
            newDs.Tables("INTS").Columns.Add("NSP", GetType(String))
            newDs.Tables("INTS").Columns.Add("LANG", GetType(String))
            newDs.Tables("INTS").Columns.Add("CMEXT", GetType(String))
            newDs.Tables("INTS").Columns.Add("TYPEOFPLACE", GetType(String))
            newDs.Tables("INTS").Columns.Add("ARRO", GetType(String))
            newDs.Tables("INTS").Columns.Add("DRUG", GetType(String))
            newDs.Tables("INTS").Columns.Add("MANAGER", GetType(String))
            newDs.Tables("INTS").Columns.Add("INTDONE", GetType(Boolean))
            newDs.Tables("INTS").Columns.Add("CRUONSITE", GetType(Boolean))
            For i As Integer = 0 To ds.Tables("INTERVENTIONS").Rows.Count - 1
                IDINT = Nothing
                CASENAME = Nothing
                DATEINT = Nothing
                ADRESSINT = Nothing
                ZIPINT = Nothing
                CITYINT = Nothing
                DATEFACTS = Nothing
                ADRESSFACTS = Nothing
                ZIPFACTS = Nothing
                CITYFACTS = Nothing
                SAMPLEST = Nothing
                SAMPLESN = Nothing
                SAMPLESD = Nothing
                SAMPLESC = Nothing
                CRUREPORTN = Nothing
                CRUREPORTD = Nothing
                NICCREPORTN = Nothing
                NICCREPORTD = Nothing
                NICCREPORTC = Nothing
                TYPEOFINT = Nothing
                TYPEOFPLACE = Nothing
                ARRO = Nothing
                DRUG = Nothing
                MANAGER = Nothing
                UNIT = Nothing
                FILENUM = Nothing
                REPORTNUM = Nothing
                RIONUM = Nothing
                ONNUM = Nothing
                SIENANUM = Nothing
                NSP = Nothing
                LANG = Nothing
                CMEXT = Nothing
                INTDONE = Nothing
                CRUONSITE = Nothing
                DrugB = False
                If Not IsDBNull(ds.Tables("INTERVENTIONS").Rows(i).Item("ID CRU")) Then IDINT = CInt(ds.Tables("INTERVENTIONS").Rows(i).Item("ID CRU"))
                CASENAME = ds.Tables("INTERVENTIONS").Rows(i).Item("CASE NAME").ToString
                If Not IsDBNull(ds.Tables("INTERVENTIONS").Rows(i).Item("DATE INT")) Then DATEINT = CDate(ds.Tables("INTERVENTIONS").Rows(i).Item("DATE INT"))
                ADRESSINT = ds.Tables("INTERVENTIONS").Rows(i).Item("ADRESS INT").ToString
                If Not IsDBNull(ds.Tables("INTERVENTIONS").Rows(i).Item("ZIP INT")) Then ZIPINT = CInt(ds.Tables("INTERVENTIONS").Rows(i).Item("ZIP INT"))
                CITYINT = ds.Tables("INTERVENTIONS").Rows(i).Item("CITY INT").ToString
                If Not IsDBNull(ds.Tables("INTERVENTIONS").Rows(i).Item("DATE FACTS")) Then DATEFACTS = CDate(ds.Tables("INTERVENTIONS").Rows(i).Item("DATE FACTS"))
                ADRESSFACTS = ds.Tables("INTERVENTIONS").Rows(i).Item("ADRESS FACTS").ToString
                If Not IsDBNull(ds.Tables("INTERVENTIONS").Rows(i).Item("ZIP FACTS")) Then ZIPFACTS = CInt(ds.Tables("INTERVENTIONS").Rows(i).Item("ZIP FACTS"))
                CITYFACTS = ds.Tables("INTERVENTIONS").Rows(i).Item("CITY FACTS").ToString
                SAMPLEST = ds.Tables("INTERVENTIONS").Rows(i).Item("SAMPLES TAKEN BY").ToString
                SAMPLESN = ds.Tables("INTERVENTIONS").Rows(i).Item("SAMPLES NUM").ToString
                If Not IsDBNull(ds.Tables("INTERVENTIONS").Rows(i).Item("SAMPLES DELIVERY DATE")) Then SAMPLESD = CStr(ds.Tables("INTERVENTIONS").Rows(i).Item("SAMPLES DELIVERY DATE"))
                SAMPLESC = ds.Tables("INTERVENTIONS").Rows(i).Item("SAMPLES CODE").ToString
                CRUREPORTN = ds.Tables("INTERVENTIONS").Rows(i).Item("CRU REPORT NUM").ToString
                If Not IsDBNull(ds.Tables("INTERVENTIONS").Rows(i).Item("CRU REPORT DATE")) Then CRUREPORTD = CStr(ds.Tables("INTERVENTIONS").Rows(i).Item("CRU REPORT DATE"))
                NICCREPORTN = ds.Tables("INTERVENTIONS").Rows(i).Item("NICC REPORT NUM").ToString
                If Not IsDBNull(ds.Tables("INTERVENTIONS").Rows(i).Item("NICC REPORT DATE")) Then NICCREPORTD = CStr(ds.Tables("INTERVENTIONS").Rows(i).Item("NICC REPORT DATE"))
                NICCREPORTC = ds.Tables("INTERVENTIONS").Rows(i).Item("NICC CONC").ToString
                TYPEOFINT = ds.Tables("INTERVENTIONS").Rows(i).Item("TYPE OF INT").ToString
                TYPEOFPLACE = ds.Tables("INTERVENTIONS").Rows(i).Item("TYPE OF PLACE").ToString
                frmMain.CITIESBindingSource2.Filter = $"[ZIP CODE] = '{ZIPFACTS}' AND [CITY] = '{CITYFACTS}'"
                If frmMain.CITIESBindingSource2.Count > 0 Then
                    ARRO = CStr(CType(frmMain.CITIESBindingSource2.List(0), DataRowView).Item("ARRO"))
                End If
                Dim CaseRow = ds.Tables("CASES").Select($"[CASE NAME] = '{CASENAME}'")
                If CaseRow.Length > 0 Then
                    If Not IsDBNull(CaseRow(0).Item("CMINT")) Then MANAGER = CStr(CaseRow(0).Item("CMINT"))
                    If Not IsDBNull(CaseRow(0).Item("UNIT")) Then UNIT = CStr(CaseRow(0).Item("UNIT"))
                    If Not IsDBNull(CaseRow(0).Item("FILE NUM")) Then FILENUM = CStr(CaseRow(0).Item("FILE NUM"))
                    If Not IsDBNull(CaseRow(0).Item("REPORT NUM")) Then REPORTNUM = CStr(CaseRow(0).Item("REPORT NUM"))
                    If Not IsDBNull(CaseRow(0).Item("RIO NUM")) Then RIONUM = CStr(CaseRow(0).Item("RIO NUM"))
                    If Not IsDBNull(CaseRow(0).Item("ON NUM")) Then ONNUM = CStr(CaseRow(0).Item("ON NUM"))
                    If Not IsDBNull(CaseRow(0).Item("SIENA NUM")) Then SIENANUM = CStr(CaseRow(0).Item("SIENA NUM"))
                    If Not IsDBNull(CaseRow(0).Item("NSP")) Then NSP = CStr(CaseRow(0).Item("NSP"))
                    If Not IsDBNull(CaseRow(0).Item("LANG")) Then LANG = CStr(CaseRow(0).Item("LANG"))
                    If Not IsDBNull(CaseRow(0).Item("CMEXT1")) Then CMEXT = CStr(CaseRow(0).Item("CMEXT1"))
                End If
                INTDONE = CBool(ds.Tables("INTERVENTIONS").Rows(i).Item("INTDONE"))
                CRUONSITE = CBool(ds.Tables("INTERVENTIONS").Rows(i).Item("CRU ON SITE"))
                Dim ProdRow = ds.Tables("DRUGS INT").Select("[ID INT] = '" & IDINT & "'")
                If ProdRow.Length > 0 Then
                    For j As Integer = 0 To ProdRow.Length - 1
                        DRUG = CStr(ProdRow(j).Item("DRUG"))
                        newDs.Tables("INTS").Rows.Add(IDINT, CASENAME, TYPEOFINT, DATEINT, ADRESSINT, ZIPINT, CITYINT, DATEFACTS, ADRESSFACTS, ZIPFACTS, CITYFACTS, SAMPLEST, SAMPLESN, SAMPLESD, SAMPLESC, CRUREPORTN, CRUREPORTD, NICCREPORTN, NICCREPORTD, NICCREPORTC, UNIT, FILENUM, REPORTNUM, RIONUM, ONNUM, SIENANUM, NSP, LANG, CMEXT, TYPEOFPLACE, ARRO, DRUG, MANAGER, INTDONE, CRUONSITE)
                        DrugB = True
                    Next
                End If
                If DrugB = False Then newDs.Tables("INTS").Rows.Add(IDINT, CASENAME, TYPEOFINT, DATEINT, ADRESSINT, ZIPINT, CITYINT, DATEFACTS, ADRESSFACTS, ZIPFACTS, CITYFACTS, SAMPLEST, SAMPLESN, SAMPLESD, SAMPLESC, CRUREPORTN, CRUREPORTD, NICCREPORTN, NICCREPORTD, NICCREPORTC, UNIT, FILENUM, REPORTNUM, RIONUM, ONNUM, SIENANUM, NSP, LANG, CMEXT, TYPEOFPLACE, ARRO, DRUG, MANAGER, INTDONE, CRUONSITE)
            Next
            Return newDs
        Catch ex As Exception
            If Lang = 1 Then
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Throw
        End Try
    End Function
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search()
    End Sub
    Private Sub Search()
        'Perform search
        Cursor = Cursors.WaitCursor
        Try
            StatsDV = New DataView(memberToDs(DORADbDS).Tables("INTS"))
            Dim s As Integer = 0
            Dim r As Integer = 0
            Dim o As Integer = 0
            If dgvStats.RowCount > 0 Then
                r = dgvStats.FirstDisplayedScrollingRowIndex
            End If
            o = dgvStats.HorizontalScrollingOffset
            If dgvStats.SelectedRows.Count > 0 Then
                s = dgvStats.SelectedRows(0).Index
            End If
            Dim strFilterDate As String
            Dim strFilterCase As String = String.Empty
            Dim strFilterInt As String = String.Empty
            Dim strFilterPlace As String = String.Empty
            Dim strFilterArro As String = String.Empty
            Dim strFilterDrug As String = String.Empty
            Dim strFilterCity As String = String.Empty
            Dim strFilterManager As String = String.Empty
            Dim strFilterExtra As String = String.Empty
            DateFrom = Convert.ToDateTime("01/01/" & cmbFrom.Text)
            DateTo = Convert.ToDateTime("31/12/" & cmbTo.Text)
            strFilterDate = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}#"
            If cmbTypeOfInt.Text <> String.Empty Then
                Select Case cmbTypeOfInt.Text
                    Case "Labo's", "Labos"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*labo*')"
                    Case "Labo's in werking", "Labos en fonction"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*werking*' OR [TYPEOFINT] LIKE '*fonction*')"
                    Case "Achtergelaten labo's", "Labos abandonnés"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*achtergelaten*' OR [TYPEOFINT] LIKE '*abandonné*')"
                    Case "Ontmanteld labo's", "Labos démantelés"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*ontmanteld*' OR [TYPEOFINT] LIKE '*démantelé*')"
                    Case "Labo's in opbouw", "Labos en construction"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*opbouw*' OR [TYPEOFINT] LIKE '*construction*')"
                    Case "Labo's in stand-by", "Labos en stand-by"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*stand-by*')"
                    Case "Dumpings"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*dumping*')"
                    Case "Opslagplaats", "Stockages"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*opslagplaats*' OR [TYPEOFINT] LIKE '*stockage*')"
                    Case "Trafic", "Trafics"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*trafic*' OR [TYPEOFINT] LIKE '*traffic*')"
                    Case "Cannabis plantages", "Plantations de cannabis"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*cannabis*')"
                    Case "Expertises"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*expertise*')"
                    Case "Vervolgens", "Suites d'enquête"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*vervolg*' OR [TYPEOFINT] LIKE '*suite*')"
                    Case "Geen drugs", "Pas de drogue"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*geen drugs*' OR [TYPEOFINT] LIKE '*pas de drogue*')"
                    Case "Geen interventie", "Pas d'intervention"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*geen interventie*' OR [TYPEOFINT] LIKE '*pas d'intervention*')"
                    Case "Andere", "Autre"
                        strFilterInt = " AND ([TYPEOFINT] LIKE '*andere*' OR [TYPEOFINT] LIKE '*autre*')"
                End Select
            End If
            If cmbTypeOfPlace.Text <> String.Empty Then
                Select Case cmbTypeOfPlace.Text
                    Case "Woning", "Habitation"
                        strFilterPlace = " AND ([TYPEOFPLACE] LIKE '*woning*' OR [TYPEOFPLACE] LIKE '*habitation*')"
                    Case "Hoeve", "Ferme"
                        strFilterPlace = " AND ([TYPEOFPLACE] LIKE '*hoeve*' OR [TYPEOFPLACE] LIKE '*ferme*')"
                    Case "Openbare weg", "Voie publique"
                        strFilterPlace = " AND ([TYPEOFPLACE] LIKE '*openbare*' OR [TYPEOFPLACE] LIKE '*publique*')"
                    Case "Private plaats", "Lieu privé"
                        strFilterPlace = " AND ([TYPEOFPLACE] LIKE '*private*' OR [TYPEOFPLACE] LIKE '*privé*')"
                    Case "Voertuig", "Véhicule"
                        strFilterPlace = " AND ([TYPEOFPLACE] LIKE '*voertuig*' OR [TYPEOFPLACE] LIKE '*véhicule*')"
                    Case "Schip", "Navire"
                        strFilterPlace = " AND ([TYPEOFPLACE] LIKE '*schip*' OR [TYPEOFPLACE] LIKE '*navire*')"
                    Case "Loods", "Entrepôt"
                        strFilterPlace = " AND ([TYPEOFPLACE] LIKE '*loods*' OR [TYPEOFPLACE] LIKE '*entrepôt*')"
                    Case "Natuur", "Nature"
                        strFilterPlace = " AND ([TYPEOFPLACE] LIKE '*natuur*' OR [TYPEOFPLACE] LIKE '*nature*')"
                    Case "SGS"
                        strFilterPlace = " AND ([TYPEOFPLACE] LIKE 'SGS')"
                    Case "Remondis"
                        strFilterPlace = " AND ([TYPEOFPLACE] LIKE 'Remondis')"
                End Select
            End If
            If cmbArro.Text <> String.Empty Then
                Select Case cmbArro.Text
                    Case "Antwerpen"
                        strFilterArro = " AND ([ARRO] LIKE '*antwerpen*')"
                    Case "Limburg"
                        strFilterArro = " AND ([ARRO] LIKE '*limburg*')"
                    Case "Oost-Vlaanderen"
                        strFilterArro = " AND ([ARRO] LIKE '*oost-vlaanderen*')"
                    Case "Leuven"
                        strFilterArro = " AND ([ARRO] LIKE '*leuven*')"
                    Case "West-Vlaanderen"
                        strFilterArro = " AND ([ARRO] LIKE '*west-vlaanderen*')"
                    Case "Brussel", "Bruxelles"
                        strFilterArro = " AND ([ARRO] LIKE '*brussel*' OR [ARRO] LIKE '*bruxelles*')"
                    Case "Brabant wallon"
                        strFilterArro = " AND ([ARRO] LIKE '*brabant wallon*')"
                    Case "Hainaut"
                        strFilterArro = " AND ([ARRO] LIKE '*hainaut*')"
                    Case "Liège"
                        strFilterArro = " AND ([ARRO] LIKE '*liege*')"
                    Case "Eupen"
                        strFilterArro = " AND ([ARRO] LIKE '*eupen*')"
                    Case "Luxembourg"
                        strFilterArro = " AND ([ARRO] LIKE '*luxembourg*')"
                    Case "Namur"
                        strFilterArro = " AND ([ARRO] LIKE '*namur*')"
                End Select
            End If
            If cmbDrug.Text <> String.Empty Then
                Select Case cmbDrug.Text
                    Case "MDMA"
                        strFilterDrug = " AND ([DRUG] LIKE 'MDMA')"
                    Case "Amfetamine", "Amphétamine"
                        strFilterDrug = " AND ([DRUG] = 'Amfetamine' OR [DRUG] = 'Amphétamine')"
                    Case "Metamfetamine", "Methamphétamine"
                        strFilterDrug = " AND ([DRUG] = 'Metamfetamine' OR [DRUG] = 'Methamphétamine')"
                    Case "(Pre)-Precursors", "(Pré)-Précurseurs"
                        strFilterDrug = " AND ([DRUG] LIKE '(Pre)-Precursors' OR [DRUG] LIKE '(Pré)-Précurseurs')"
                    Case "Cannabis"
                        strFilterDrug = " AND ([DRUG] LIKE 'Cannabis')"
                    Case "Cocaïne"
                        strFilterDrug = " AND ([DRUG] LIKE 'Cocaïne')"
                    Case "Heroïne", "Héroïne"
                        strFilterDrug = " AND ([DRUG] LIKE 'Heroïne' OR [DRUG] LIKE 'Héroïne')"
                    Case "NPS"
                        strFilterDrug = " AND ([DRUG] LIKE 'NPS')"
                    Case "Ketamine", "Kétamine"
                        strFilterDrug = " AND ([DRUG] LIKE 'Ketamine' OR [DRUG] LIKE 'Kétamine')"
                End Select
            End If
            If cmbCity.Text <> String.Empty Then
                strFilterCity = $" AND ([CITYFACTS] LIKE '{cmbCity.Text}')"
            End If
            If cmbCMInt.Text <> String.Empty Then
                strFilterManager = $" AND ([MANAGER] LIKE '{cmbCMInt.Text}')"
            End If
            If mnInterventionDone.Checked = True Then
                strFilterExtra += " AND ([INTDONE] = TRUE)"
            End If
            If mnCRUOnSite.Checked = True Then
                strFilterExtra += " AND ([CRUONSITE] = TRUE)"
            End If
            'Draw datagridview columns
            dgvStats.DataSource = StatsDV
            StatsDV.RowFilter = strFilterDate + strFilterCase + strFilterInt + strFilterPlace + strFilterArro + strFilterDrug + strFilterCity + strFilterManager + strFilterExtra
            StatsDV.Sort = "[DATEINT] DESC, [IDINT] DESC"
            dgvStats.DataSource = StatsDV.ToTable(True, "IDINT", "CASENAME", "TYPEOFINT", "DATEINT", "ADRESSINT", "ZIPINT", "CITYINT", "DATEFACTS", "ADRESSFACTS", "ZIPFACTS", "CITYFACTS", "SAMPLEST", "SAMPLESN", "SAMPLESD", "SAMPLESC", "CRUREPORTN", "CRUREPORTD", "NICCREPORTN", "NICCREPORTD", "NICCREPORTC", "UNIT", "FILENUM", "REPORTNUM", "RIONUM", "ONNUM", "SIENANUM", "NSP", "LANG", "CMEXT") ', "TYPEOFPLACE", "ARRO", "DRUG", "MANAGER")
            dgvStats.Sort(dgvStats.Columns(3), ComponentModel.ListSortDirection.Descending)
            For i As Integer = 0 To 28
                dgvStats.Columns(i).SortMode = DataGridViewColumnSortMode.Programmatic
            Next
            dgvStats.Columns(0).Visible = False
            dgvStats.Columns(3).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-001")
            dgvStats.Columns(3).DefaultCellStyle.Format = "dd/MM/yyyy"
            dgvStats.Columns(3).HeaderCell.Style.ForeColor = Color.Teal
            dgvStats.Columns(4).HeaderCell.Style.ForeColor = Color.Teal
            dgvStats.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvStats.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvStats.Columns(5).HeaderCell.Style.ForeColor = Color.Teal
            dgvStats.Columns(6).HeaderCell.Style.ForeColor = Color.Teal
            dgvStats.Columns(7).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-001")
            dgvStats.Columns(7).DefaultCellStyle.Format = "dd/MM/yyyy"
            dgvStats.Columns(7).HeaderCell.Style.ForeColor = Color.DarkBlue
            dgvStats.Columns(8).HeaderCell.Style.ForeColor = Color.DarkBlue
            dgvStats.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvStats.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvStats.Columns(9).HeaderCell.Style.ForeColor = Color.DarkBlue
            dgvStats.Columns(10).HeaderCell.Style.ForeColor = Color.DarkBlue
            dgvStats.Columns(11).HeaderCell.Style.ForeColor = Color.DarkRed
            dgvStats.Columns(12).HeaderCell.Style.ForeColor = Color.DarkRed
            dgvStats.Columns(13).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-001")
            dgvStats.Columns(13).DefaultCellStyle.Format = "dd/MM/yyyy"
            dgvStats.Columns(13).HeaderCell.Style.ForeColor = Color.DarkRed
            dgvStats.Columns(14).HeaderCell.Style.ForeColor = Color.DarkRed
            dgvStats.Columns(15).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-001")
            dgvStats.Columns(15).HeaderCell.Style.ForeColor = Color.DarkOrange
            dgvStats.Columns(16).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-001")
            dgvStats.Columns(16).DefaultCellStyle.Format = "dd/MM/yyyy"
            dgvStats.Columns(16).HeaderCell.Style.ForeColor = Color.DarkOrange
            dgvStats.Columns(17).HeaderCell.Style.ForeColor = Color.DarkGreen
            dgvStats.Columns(18).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-001")
            dgvStats.Columns(18).DefaultCellStyle.Format = "dd/MM/yyyy"
            dgvStats.Columns(18).HeaderCell.Style.ForeColor = Color.DarkGreen
            dgvStats.Columns(19).HeaderCell.Style.ForeColor = Color.DarkGreen
            dgvStats.Columns(19).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            dgvStats.Columns(19).Width = 400
            dgvStats.Columns(20).HeaderCell.Style.ForeColor = Color.DarkOrchid
            dgvStats.Columns(21).HeaderCell.Style.ForeColor = Color.DarkOrchid
            dgvStats.Columns(22).HeaderCell.Style.ForeColor = Color.DarkOrchid
            dgvStats.Columns(23).HeaderCell.Style.ForeColor = Color.DarkOrchid
            dgvStats.Columns(24).HeaderCell.Style.ForeColor = Color.DarkOrchid
            dgvStats.Columns(25).HeaderCell.Style.ForeColor = Color.DarkOrchid
            dgvStats.Columns(26).HeaderCell.Style.ForeColor = Color.DarkOrchid
            dgvStats.Columns(27).HeaderCell.Style.ForeColor = Color.DarkOrchid
            dgvStats.Columns(28).HeaderCell.Style.ForeColor = Color.DarkOrchid
            'Translate columns headers
            If Lang = 1 Then
                dgvStats.Columns(1).HeaderText = "Dossiernaam"
                dgvStats.Columns(2).HeaderText = "Interventie"
                dgvStats.Columns(3).HeaderText = "Datum"
                dgvStats.Columns(4).HeaderText = "Adres"
                dgvStats.Columns(5).HeaderText = "PC"
                dgvStats.Columns(6).HeaderText = "Gemeente"
                dgvStats.Columns(7).HeaderText = "Datum"
                dgvStats.Columns(8).HeaderText = "Adres"
                dgvStats.Columns(9).HeaderText = "PC"
                dgvStats.Columns(10).HeaderText = "Gemeente"
                dgvStats.Columns(11).HeaderText = "Genomen door"
                dgvStats.Columns(12).HeaderText = "Nummer"
                dgvStats.Columns(13).HeaderText = "Datum"
                dgvStats.Columns(14).HeaderText = "Code"
                dgvStats.Columns(15).HeaderText = "Nummer"
                dgvStats.Columns(16).HeaderText = "Datum"
                dgvStats.Columns(17).HeaderText = "Nummer"
                dgvStats.Columns(18).HeaderText = "Datum"
                dgvStats.Columns(19).HeaderText = "Besluit"
                dgvStats.Columns(20).HeaderText = "Eenheid"
                dgvStats.Columns(21).HeaderText = "CRU fiche"
                dgvStats.Columns(22).HeaderText = "Aanvankelijk PV"
                dgvStats.Columns(23).HeaderText = "RIO num."
                dgvStats.Columns(24).HeaderText = "ON num."
                dgvStats.Columns(25).HeaderText = "SIENA num."
                dgvStats.Columns(26).HeaderText = "NVP"
                dgvStats.Columns(27).HeaderText = "Taal"
                dgvStats.Columns(28).HeaderText = "Onderzoeker"
            Else
                dgvStats.Columns(1).HeaderText = "Nom de dossier"
                dgvStats.Columns(2).HeaderText = "Intervention"
                dgvStats.Columns(3).HeaderText = "Date"
                dgvStats.Columns(4).HeaderText = "Adresse"
                dgvStats.Columns(5).HeaderText = "CP"
                dgvStats.Columns(6).HeaderText = "Commune"
                dgvStats.Columns(7).HeaderText = "Date"
                dgvStats.Columns(8).HeaderText = "Adresse"
                dgvStats.Columns(9).HeaderText = "CP"
                dgvStats.Columns(10).HeaderText = "Commune"
                dgvStats.Columns(11).HeaderText = "Prélevés par"
                dgvStats.Columns(12).HeaderText = "Numéro"
                dgvStats.Columns(13).HeaderText = "Date"
                dgvStats.Columns(14).HeaderText = "Code"
                dgvStats.Columns(15).HeaderText = "Numéro"
                dgvStats.Columns(16).HeaderText = "Date"
                dgvStats.Columns(17).HeaderText = "Numéro"
                dgvStats.Columns(18).HeaderText = "Date"
                dgvStats.Columns(19).HeaderText = "Conclusions"
                dgvStats.Columns(20).HeaderText = "Unité"
                dgvStats.Columns(21).HeaderText = "Fiche CRU"
                dgvStats.Columns(22).HeaderText = "PV initial"
                dgvStats.Columns(23).HeaderText = "Num. RIO"
                dgvStats.Columns(24).HeaderText = "Num. ON"
                dgvStats.Columns(25).HeaderText = "Num. SIENA"
                dgvStats.Columns(26).HeaderText = "PNS"
                dgvStats.Columns(27).HeaderText = "Langue"
                dgvStats.Columns(28).HeaderText = "Enquêteur"
            End If
            lblCount.Visible = True
            If Lang = 1 Then
                lblCount.Text = $"{dgvStats.RowCount} interventie(s)"
            Else
                lblCount.Text = $"{dgvStats.RowCount} intervention(s)"
            End If
            lst_results.Clear()
            If txtFind.Text <> String.Empty Then
                For i As Integer = 0 To dgvStats.RowCount - 1
                    For j As Integer = 0 To dgvStats.ColumnCount - 1
                        If dgvStats.Rows(i).Cells(j).Value.ToString.ToLower.Contains(txtFind.Text.ToLower) Then
                            If dgvStats.Columns(j).Visible = True Then
                                dgvStats.Rows(i).Cells(j).Style.BackColor = Color.LightGoldenrodYellow
                                dgvStats.Rows(i).Cells(j).Style.ForeColor = Color.Black
                                Dim temp As New List(Of Integer)({i, j})
                                lst_results.Add(temp)
                            End If
                        End If
                    Next
                Next
                lblCounter.Visible = True
                If Lang = 1 Then
                    If lst_results.Count > 1 Then
                        btnDown.Visible = True
                        btnUp.Visible = True
                        btnUp.Enabled = False
                        btnUp.IconColor = Color.FromArgb(35, 35, 35)
                        lblCounter.Text = $"1 / {lst_results.Count} resultaten"
                    End If
                    If lst_results.Count = 1 Then lblCounter.Text = $"1 / 1 resultaat"
                    If lst_results.Count = 0 Then lblCounter.Text = $"Geen resultaat"
                Else
                    If lst_results.Count > 1 Then
                        btnDown.Visible = True
                        btnUp.Visible = True
                        btnUp.Enabled = False
                        btnUp.IconColor = Color.FromArgb(35, 35, 35)
                        lblCounter.Text = $"1 / {lst_results.Count} résultats"
                    End If
                    If lst_results.Count = 1 Then lblCounter.Text = $"1 / 1 résultat"
                    If lst_results.Count = 0 Then lblCounter.Text = $"Pas de résultat"
                End If
                counter_sel = 1
                If lst_results.Count > 0 Then
                    If lst_results(counter_sel - 1)(0) > 5 Then
                        dgvStats.FirstDisplayedScrollingRowIndex = lst_results(counter_sel - 1)(0) - 5
                    Else
                        dgvStats.FirstDisplayedScrollingRowIndex = 1
                    End If
                    If lst_results(counter_sel - 1)(1) > 5 Then
                        Dim x As Integer = 0
                        While dgvStats.Columns(lst_results(counter_sel - 1)(1) - 5 - x).Visible = False
                            x += 1
                        End While
                        dgvStats.FirstDisplayedScrollingColumnIndex = lst_results(counter_sel - 1)(1) - 5 - x
                    Else
                        dgvStats.FirstDisplayedScrollingColumnIndex = 1
                    End If
                    dgvStats.Rows(lst_results(counter_sel - 1)(0)).Cells(lst_results(counter_sel - 1)(1)).Style.BackColor = Color.Yellow
                End If
            End If
            If lst_results.Count = 0 AndAlso dgvStats.Rows.Count > 0 Then
                dgvStats.FirstDisplayedScrollingRowIndex = r
                dgvStats.Rows(s).Selected = True
                dgvStats.HorizontalScrollingOffset = o
            End If
            HandleHeaders()
            'Check for dat files
            Dim files As String() = Directory.GetFiles($"{dora_path}SYSTEM", "*.dat")
            For Each f In files
                Dim parts As String() = Split(Path.GetFileNameWithoutExtension(f), ",,")
                If parts(0) = "INT" Then
                    If dgvStats.DataSource IsNot Nothing Then
                        For Each row As DataGridViewRow In dgvStats.Rows
                            If row.Cells(0).Value Is parts(1) Then
                                Dim i As Integer = row.Index
                                user_list = UserToList($"{dora_path}cru.txt", parts(2))
                                dgvStats.Rows(i).DefaultCellStyle.BackColor = Color.FromName(user_list(3))
                            End If
                        Next
                    End If
                End If
            Next
            Cursor = Cursors.Default
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
    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        counter_sel += 1
        btnUp.Enabled = True
        btnUp.IconColor = theme("Font")
        If lst_results(counter_sel - 1)(0) > 5 Then
            dgvStats.FirstDisplayedScrollingRowIndex = lst_results(counter_sel - 1)(0) - 5
        Else
            dgvStats.FirstDisplayedScrollingRowIndex = 1
        End If
        If lst_results(counter_sel - 1)(1) > 5 Then
            dgvStats.FirstDisplayedScrollingColumnIndex = lst_results(counter_sel - 1)(1) - 5
        Else
            dgvStats.FirstDisplayedScrollingColumnIndex = 1
        End If
        dgvStats.Rows(lst_results(counter_sel - 1)(0)).Cells(lst_results(counter_sel - 1)(1)).Style.BackColor = Color.Yellow
        dgvStats.Rows(lst_results(counter_sel - 2)(0)).Cells(lst_results(counter_sel - 2)(1)).Style.BackColor = Color.LightGoldenrodYellow
        If Lang = 1 Then
            lblCounter.Text = $"{counter_sel} / {lst_results.Count} resultaten"
        Else
            lblCounter.Text = $"{counter_sel} / {lst_results.Count} résultats"
        End If
        If counter_sel = lst_results.Count Then
            btnDown.Enabled = False
            btnDown.IconColor = Color.FromArgb(35, 35, 35)
        Else
            btnDown.Enabled = True
            btnDown.IconColor = theme("Font")
        End If
    End Sub
    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        counter_sel -= 1
        btnDown.Enabled = True
        btnDown.IconColor = theme("Font")
        If lst_results(counter_sel - 1)(0) > 5 Then
            dgvStats.FirstDisplayedScrollingRowIndex = lst_results(counter_sel - 1)(0) - 5
        Else
            dgvStats.FirstDisplayedScrollingRowIndex = 1
        End If
        If lst_results(counter_sel - 1)(1) > 5 Then
            dgvStats.FirstDisplayedScrollingColumnIndex = lst_results(counter_sel - 1)(1) - 5
        Else
            dgvStats.FirstDisplayedScrollingColumnIndex = 1
        End If
        dgvStats.Rows(lst_results(counter_sel - 1)(0)).Cells(lst_results(counter_sel - 1)(1)).Style.BackColor = Color.Yellow
        dgvStats.Rows(lst_results(counter_sel)(0)).Cells(lst_results(counter_sel)(1)).Style.BackColor = Color.LightGoldenrodYellow
        If Lang = 1 Then
            lblCounter.Text = $"{counter_sel} / {lst_results.Count} resultaten"
        Else
            lblCounter.Text = $"{counter_sel} / {lst_results.Count} résultats"
        End If
        If counter_sel = 1 Then
            btnUp.Enabled = False
            btnUp.IconColor = Color.FromArgb(35, 35, 35)
        Else
            btnUp.Enabled = True
            btnUp.IconColor = theme("Font")
        End If
    End Sub
#End Region
#Region "Context Menus"
    Private Sub btnAddFilters_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAddFilters.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            FilterMenu.Show(CType(sender, Control), e.Location)
        End If
    End Sub
    Private Sub FilterMenu_Closing(sender As Object, e As ToolStripDropDownClosingEventArgs) Handles FilterMenu.Closing
        If e.CloseReason = ToolStripDropDownCloseReason.ItemClicked Then
            e.Cancel = True
        End If
    End Sub
    Private Sub dgvStats_CellMouseDown(sender As Object, e As MouseEventArgs) Handles dgvStats.MouseDown
        'Show right click menu
        If e.Button = Windows.Forms.MouseButtons.Right Then
            dgvStats.ClearSelection()
            Dim ht As DataGridView.HitTestInfo
            ht = dgvStats.HitTest(e.X, e.Y)
            If ht.Type = DataGridViewHitTestType.Cell Then
                Dim cell = dgvStats.Item(ht.ColumnIndex, ht.RowIndex)
                dgvStats.CurrentCell = cell
                cell.Selected = True
                dgvStats.ContextMenuStrip = RCMenuStats
            ElseIf ht.Type = DataGridViewHitTestType.ColumnHeader Then
                dgvStats.ContextMenuStrip = RCMenuHeader
            End If
        Else
            Dim off As Integer = dgvStats.HorizontalScrollingOffset
            Dim ht As DataGridView.HitTestInfo
            ht = dgvStats.HitTest(e.X, e.Y)
            If ht.Type = DataGridViewHitTestType.ColumnHeader Then
                If dgvStats.SortOrder = SortOrder.Ascending Then
                    dgvStats.Sort(dgvStats.Columns(ht.ColumnIndex), ComponentModel.ListSortDirection.Descending)
                Else
                    dgvStats.Sort(dgvStats.Columns(ht.ColumnIndex), ComponentModel.ListSortDirection.Ascending)
                End If
                dgvStats.HorizontalScrollingOffset = off
                End If
            End If
    End Sub
    Private Sub HandleHeaders()
        'Show or hide intervention related columns
        If mnDateInt.Checked = True Then dgvStats.Columns(3).Visible = True Else dgvStats.Columns(3).Visible = False
        If mnAdressInt.Checked = True Then dgvStats.Columns(4).Visible = True Else dgvStats.Columns(4).Visible = False
        If mnZipInt.Checked = True Then dgvStats.Columns(5).Visible = True Else dgvStats.Columns(5).Visible = False
        If mnCityInt.Checked = True Then dgvStats.Columns(6).Visible = True Else dgvStats.Columns(6).Visible = False
        'Check or uncheck category if all or none of the columns are shown
        If mnDateInt.Checked = True AndAlso mnAdressInt.Checked = True AndAlso mnZipInt.Checked = True AndAlso mnCityInt.Checked = True Then mnAllInts.Checked = True
        If mnDateInt.Checked = False AndAlso mnAdressInt.Checked = False AndAlso mnZipInt.Checked = False AndAlso mnCityInt.Checked = False Then mnAllInts.Checked = False
        'Show or hide facts related columns
        If mnDateFacts.Checked = True Then dgvStats.Columns(7).Visible = True Else dgvStats.Columns(7).Visible = False
        If mnAdressFacts.Checked = True Then dgvStats.Columns(8).Visible = True Else dgvStats.Columns(8).Visible = False
        If mnZipFacts.Checked = True Then dgvStats.Columns(9).Visible = True Else dgvStats.Columns(9).Visible = False
        If mnCityFacts.Checked = True Then dgvStats.Columns(10).Visible = True Else dgvStats.Columns(10).Visible = False
        'Check or uncheck category if all or none of the columns are shown
        If mnDateFacts.Checked = True AndAlso mnAdressFacts.Checked = True AndAlso mnZipFacts.Checked = True AndAlso mnCityFacts.Checked = True Then mnAllFacts.Checked = True
        If mnDateFacts.Checked = False AndAlso mnAdressFacts.Checked = False AndAlso mnZipFacts.Checked = False AndAlso mnCityFacts.Checked = False Then mnAllFacts.Checked = False
        'Show or hide samples related columns
        If mnSamplesT.Checked = True Then dgvStats.Columns(11).Visible = True Else dgvStats.Columns(11).Visible = False
        If mnSamplesN.Checked = True Then dgvStats.Columns(12).Visible = True Else dgvStats.Columns(12).Visible = False
        If mnSamplesD.Checked = True Then dgvStats.Columns(13).Visible = True Else dgvStats.Columns(13).Visible = False
        If mnSamplesC.Checked = True Then dgvStats.Columns(14).Visible = True Else dgvStats.Columns(14).Visible = False
        'Check or uncheck category if all or none of the columns are shown
        If mnSamplesT.Checked = True AndAlso mnSamplesN.Checked = True AndAlso mnSamplesD.Checked = True AndAlso mnSamplesC.Checked = True Then mnAllSamples.Checked = True
        If mnSamplesT.Checked = False AndAlso mnSamplesN.Checked = False AndAlso mnSamplesD.Checked = False AndAlso mnSamplesC.Checked = False Then mnAllSamples.Checked = False
        'Show or hide CRU Report related columns
        If mnCRUReportN.Checked = True Then dgvStats.Columns(15).Visible = True Else dgvStats.Columns(15).Visible = False
        If mnCRUReportD.Checked = True Then dgvStats.Columns(16).Visible = True Else dgvStats.Columns(16).Visible = False
        'Check or uncheck category if all or none of the columns are shown
        If mnCRUReportN.Checked = True AndAlso mnCRUReportD.Checked = True Then mnAllCRUReport.Checked = True
        If mnCRUReportN.Checked = False AndAlso mnCRUReportD.Checked = False Then mnAllCRUReport.Checked = False
        'Show or hide NICC Report related columns
        If mnNICCReportN.Checked = True Then dgvStats.Columns(17).Visible = True Else dgvStats.Columns(17).Visible = False
        If mnNICCReportD.Checked = True Then dgvStats.Columns(18).Visible = True Else dgvStats.Columns(18).Visible = False
        If mnNICCReportC.Checked = True Then dgvStats.Columns(19).Visible = True Else dgvStats.Columns(19).Visible = False
        'Check or uncheck category if all or none of the columns are shown
        If mnNICCReportN.Checked = True AndAlso mnNICCReportD.Checked = True AndAlso mnNICCReportC.Checked = True Then mnAllNICCReport.Checked = True
        If mnNICCReportN.Checked = False AndAlso mnNICCReportD.Checked = False AndAlso mnNICCReportC.Checked = False Then mnAllNICCReport.Checked = False
        'Show or hide case related columns
        If mnUnit.Checked = True Then dgvStats.Columns(20).Visible = True Else dgvStats.Columns(20).Visible = False
        If mnFileNum.Checked = True Then dgvStats.Columns(21).Visible = True Else dgvStats.Columns(21).Visible = False
        If mnReportNum.Checked = True Then dgvStats.Columns(22).Visible = True Else dgvStats.Columns(22).Visible = False
        If mnRIONum.Checked = True Then dgvStats.Columns(23).Visible = True Else dgvStats.Columns(23).Visible = False
        If mnONNum.Checked = True Then dgvStats.Columns(24).Visible = True Else dgvStats.Columns(24).Visible = False
        If mnSIENANum.Checked = True Then dgvStats.Columns(25).Visible = True Else dgvStats.Columns(25).Visible = False
        If mnNSP.Checked = True Then dgvStats.Columns(26).Visible = True Else dgvStats.Columns(26).Visible = False
        If mnLang.Checked = True Then dgvStats.Columns(27).Visible = True Else dgvStats.Columns(27).Visible = False
        If mnCMExt.Checked = True Then dgvStats.Columns(28).Visible = True Else dgvStats.Columns(28).Visible = False
        'Check or uncheck category if all or none of the columns are shown
        If mnUnit.Checked = True AndAlso mnFileNum.Checked = True AndAlso mnReportNum.Checked = True AndAlso mnRIONum.Checked = True AndAlso mnONNum.Checked = True AndAlso mnSIENANum.Checked = True AndAlso mnNSP.Checked = True AndAlso mnLang.Checked = True AndAlso mnCMExt.Checked = True Then mnAllCase.Checked = True
        If mnUnit.Checked = False AndAlso mnFileNum.Checked = False AndAlso mnReportNum.Checked = False AndAlso mnRIONum.Checked = False AndAlso mnONNum.Checked = False AndAlso mnSIENANum.Checked = False AndAlso mnNSP.Checked = False AndAlso mnLang.Checked = False AndAlso mnCMExt.Checked = False Then mnAllCase.Checked = False
    End Sub
    Private Sub RCMenuHeader_Closing(sender As Object, e As ToolStripDropDownClosingEventArgs) Handles RCMenuHeader.Closing
        If e.CloseReason = ToolStripDropDownCloseReason.ItemClicked Then
            e.Cancel = True
        End If
    End Sub
    Private Sub mnAllInts_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnAllInts.DropDownItemClicked
        mnAllInts.DropDown.AutoClose = False
    End Sub
    Private Sub mnDateInt_Click(sender As Object, e As EventArgs) Handles mnDateInt.Click
        HandleHeaders()
    End Sub
    Private Sub mnAdressInt_Click(sender As Object, e As EventArgs) Handles mnAdressInt.Click
        HandleHeaders()
    End Sub
    Private Sub mnZipInt_Click(sender As Object, e As EventArgs) Handles mnZipInt.Click
        HandleHeaders()
    End Sub
    Private Sub mnCityInt_Click(sender As Object, e As EventArgs) Handles mnCityInt.Click
        HandleHeaders()
    End Sub
    Private Sub mnAllInts_MouseLeave(sender As Object, e As EventArgs) Handles mnDateInt.MouseLeave, mnAdressInt.MouseLeave, mnZipInt.MouseMove, mnCityInt.MouseLeave
        mnAllInts.DropDown.AutoClose = True
    End Sub
    Private Sub mnAllInts_Click(sender As Object, e As EventArgs) Handles mnAllInts.Click
        If mnAllInts.Checked = True Then
            mnDateInt.Checked = True
            mnAdressInt.Checked = True
            mnZipInt.Checked = True
            mnCityInt.Checked = True
        Else
            mnDateInt.Checked = False
            mnAdressInt.Checked = False
            mnZipInt.Checked = False
            mnCityInt.Checked = False
        End If
        HandleHeaders()
    End Sub
    Private Sub mnAllFacts_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnAllFacts.DropDownItemClicked
        mnAllFacts.DropDown.AutoClose = False
    End Sub
    Private Sub mnDateFacts_Click(sender As Object, e As EventArgs) Handles mnDateFacts.Click
        HandleHeaders()
    End Sub
    Private Sub mnAdressFacts_Click(sender As Object, e As EventArgs) Handles mnAdressFacts.Click
        HandleHeaders()
    End Sub
    Private Sub mnZipFacts_Click(sender As Object, e As EventArgs) Handles mnZipFacts.Click
        HandleHeaders()
    End Sub
    Private Sub mnCityFacts_Click(sender As Object, e As EventArgs) Handles mnCityFacts.Click
        HandleHeaders()
    End Sub
    Private Sub mnAllFacts_MouseLeave(sender As Object, e As EventArgs) Handles mnDateFacts.MouseLeave, mnAdressFacts.MouseLeave, mnZipFacts.MouseMove, mnCityFacts.MouseLeave
        mnAllFacts.DropDown.AutoClose = True
    End Sub
    Private Sub mnAllFacts_Click(sender As Object, e As EventArgs) Handles mnAllFacts.Click
        If mnAllFacts.Checked = True Then
            mnDateFacts.Checked = True
            mnAdressFacts.Checked = True
            mnZipFacts.Checked = True
            mnCityFacts.Checked = True
        Else
            mnDateFacts.Checked = False
            mnAdressFacts.Checked = False
            mnZipFacts.Checked = False
            mnCityFacts.Checked = False
        End If
        HandleHeaders()
    End Sub
    Private Sub mnAllSamples_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnAllSamples.DropDownItemClicked
        mnAllSamples.DropDown.AutoClose = False
    End Sub
    Private Sub mnSamplesT_Click(sender As Object, e As EventArgs) Handles mnSamplesT.Click
        HandleHeaders()
    End Sub
    Private Sub mnSamplesN_Click(sender As Object, e As EventArgs) Handles mnSamplesN.Click
        HandleHeaders()
    End Sub
    Private Sub mnSamplesD_Click(sender As Object, e As EventArgs) Handles mnSamplesD.Click
        HandleHeaders()
    End Sub
    Private Sub mnSamplesC_Click(sender As Object, e As EventArgs) Handles mnSamplesC.Click
        HandleHeaders()
    End Sub
    Private Sub mnAllSamples_MouseLeave(sender As Object, e As EventArgs) Handles mnSamplesT.MouseLeave, mnSamplesN.MouseLeave, mnSamplesD.MouseLeave, mnSamplesC.MouseMove
        mnAllSamples.DropDown.AutoClose = True
    End Sub
    Private Sub mnAllSamples_Click(sender As Object, e As EventArgs) Handles mnAllSamples.Click
        If mnAllSamples.Checked = True Then
            mnSamplesT.Checked = True
            mnSamplesN.Checked = True
            mnSamplesD.Checked = True
            mnSamplesC.Checked = True
        Else
            mnSamplesT.Checked = False
            mnSamplesN.Checked = False
            mnSamplesD.Checked = False
            mnSamplesC.Checked = False
        End If
        HandleHeaders()
    End Sub
    Private Sub mnAllCRUReport_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnAllCRUReport.DropDownItemClicked
        mnAllCRUReport.DropDown.AutoClose = False
    End Sub
    Private Sub mnCRUReportN_Click(sender As Object, e As EventArgs) Handles mnCRUReportN.Click
        HandleHeaders()
    End Sub
    Private Sub mnCRUReportD_Click(sender As Object, e As EventArgs) Handles mnCRUReportD.Click
        HandleHeaders()
    End Sub

    Private Sub mnAllCRUReport_MouseLeave(sender As Object, e As EventArgs) Handles mnCRUReportN.MouseLeave, mnCRUReportD.MouseLeave
        mnAllCRUReport.DropDown.AutoClose = True
    End Sub
    Private Sub mnAllCRUReport_Click(sender As Object, e As EventArgs) Handles mnAllCRUReport.Click
        If mnAllCRUReport.Checked = True Then
            mnCRUReportN.Checked = True
            mnCRUReportD.Checked = True
        Else
            mnCRUReportN.Checked = False
            mnCRUReportD.Checked = False
        End If
        HandleHeaders()
    End Sub
    Private Sub mnAllNICCReport_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnAllNICCReport.DropDownItemClicked
        mnAllNICCReport.DropDown.AutoClose = False
    End Sub
    Private Sub mnNICCReportN_Click(sender As Object, e As EventArgs) Handles mnNICCReportN.Click
        HandleHeaders()
    End Sub
    Private Sub mnNICCReportD_Click(sender As Object, e As EventArgs) Handles mnNICCReportD.Click
        HandleHeaders()
    End Sub
    Private Sub mnNICCReportC_Click(sender As Object, e As EventArgs) Handles mnNICCReportC.Click
        HandleHeaders()
    End Sub
    Private Sub mnAllNICCReport_MouseLeave(sender As Object, e As EventArgs) Handles mnNICCReportN.MouseLeave, mnNICCReportD.MouseLeave, mnNICCReportC.MouseLeave
        mnAllNICCReport.DropDown.AutoClose = True
    End Sub
    Private Sub mnAllNICCReport_Click(sender As Object, e As EventArgs) Handles mnAllNICCReport.Click
        If mnAllNICCReport.Checked = True Then
            mnNICCReportN.Checked = True
            mnNICCReportD.Checked = True
            mnNICCReportC.Checked = True
        Else
            mnNICCReportN.Checked = False
            mnNICCReportD.Checked = False
            mnNICCReportC.Checked = False
        End If
        HandleHeaders()
    End Sub
    Private Sub mnAllCase_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnAllCase.DropDownItemClicked
        mnAllCase.DropDown.AutoClose = False
    End Sub
    Private Sub mnUnit_Click(sender As Object, e As EventArgs) Handles mnUnit.Click
        HandleHeaders()
    End Sub
    Private Sub mnFileNum_Click(sender As Object, e As EventArgs) Handles mnFileNum.Click
        HandleHeaders()
    End Sub
    Private Sub mnReportNum_Click(sender As Object, e As EventArgs) Handles mnReportNum.Click
        HandleHeaders()
    End Sub
    Private Sub mnRIONum_Click(sender As Object, e As EventArgs) Handles mnRIONum.Click
        HandleHeaders()
    End Sub
    Private Sub mnONNum_Click(sender As Object, e As EventArgs) Handles mnONNum.Click
        HandleHeaders()
    End Sub
    Private Sub mnSIENANum_Click(sender As Object, e As EventArgs) Handles mnSIENANum.Click
        HandleHeaders()
    End Sub
    Private Sub mnNSP_Click(sender As Object, e As EventArgs) Handles mnNSP.Click
        HandleHeaders()
    End Sub
    Private Sub mnLang_Click(sender As Object, e As EventArgs) Handles mnLang.Click
        HandleHeaders()
    End Sub
    Private Sub mnCMExt_Click(sender As Object, e As EventArgs) Handles mnCMExt.Click
        HandleHeaders()
    End Sub
    Private Sub mnAllCase_MouseLeave(sender As Object, e As EventArgs) Handles mnUnit.MouseLeave, mnFileNum.MouseLeave, mnReportNum.MouseMove, mnRIONum.MouseLeave, mnONNum.MouseLeave, mnSIENANum.MouseLeave, mnNSP.MouseLeave, mnLang.MouseLeave, mnCMExt.MouseLeave
        mnAllCase.DropDown.AutoClose = True
    End Sub
    Private Sub mnAllCase_Click(sender As Object, e As EventArgs) Handles mnAllCase.Click
        If mnAllCase.Checked = True Then
            mnUnit.Checked = True
            mnFileNum.Checked = True
            mnReportNum.Checked = True
            mnRIONum.Checked = True
            mnONNum.Checked = True
            mnSIENANum.Checked = True
            mnNSP.Checked = True
            mnLang.Checked = True
            mnCMExt.Checked = True
        Else
            mnUnit.Checked = False
            mnFileNum.Checked = False
            mnReportNum.Checked = False
            mnRIONum.Checked = False
            mnONNum.Checked = False
            mnSIENANum.Checked = False
            mnNSP.Checked = False
            mnLang.Checked = False
            mnCMExt.Checked = False
        End If
        HandleHeaders()
    End Sub
    Private Sub mnViewIntervention_Click(sender As Object, e As EventArgs) Handles mnViewIntervention.Click, dgvStats.DoubleClick
        'Go to Intervention window
        If Application.OpenForms().OfType(Of frmIntervention).Any Then
            If Lang = 1 Then
                MessageBox.Show("Een interventie is al open", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Une intervention est déjà ouverte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select($"[CASE NAME] = '{dgvStats.Item(1, dgvStats.CurrentRow.Index).Value}'")
            If CaseRow.Length > 0 Then
                IntLang = CStr(CaseRow(0)("LANG"))
                If Not IsDBNull(CaseRow(0)("FILE NUM")) Then CRUFile = CStr(CaseRow(0)("FILE NUM"))
                If Not IsDBNull(CaseRow(0)("TYPE OF CASE")) Then TypeOfCase = CStr(CaseRow(0)("TYPE OF CASE"))
                If Not IsDBNull(CaseRow(0)("REPORT NUM")) Then ReportNum = CStr(CaseRow(0)("REPORT NUM"))
                IntNum = CInt(dgvStats.Item(0, dgvStats.CurrentRow.Index).Value)
                CaseName = CStr(dgvStats.Item(1, dgvStats.CurrentRow.Index).Value)
                TypeOfInt = CStr(dgvStats.Item(2, dgvStats.CurrentRow.Index).Value)
                DateInt = CDate(dgvStats.Item(3, dgvStats.CurrentRow.Index).Value)
                AdressInt = CStr(dgvStats.Item(4, dgvStats.CurrentRow.Index).Value)
                CityInt = CStr(dgvStats.Item(6, dgvStats.CurrentRow.Index).Value)
                Cursor = Cursors.WaitCursor
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
    Private Sub mnNL_Click(sender As Object, e As EventArgs) Handles mnNL.Click
        Dim list As String() = {"DOSSIERNAAM", "INTERVENTIE", "DATUM INT.", "ADRES INT.", "PC INT.", "GEMEENTE INT.", "DATUM FEITEN", "ADRES FEITEN", "PC FEITEN", "GEMEENTE FEITEN", "STAAL. GENOMEN DOOR", "STAAL. NUMMER", "STAAL. AFLEVERING DATUM", "STAAL. CODE", "CRU PV NUM.", "CRU PV DATUM", "NICC VERSLAG NUM.", "NICC VERSLAG DATUM", "NICC BESLUIT", "EENHEID", "CRU FICHE", "AANVANKELIJK PV", "RIO NUM.", "ON NUM.", "SIENA NUM.", "NVP", "TAAL", "ONDERZOEKER"}
        Export(list)
    End Sub
    Private Sub mnFR_Click(sender As Object, e As EventArgs) Handles mnFR.Click
        Dim list As String() = {"NOM DE DOSSIER", "INTERVENTION", "DATE INT.", "ADRESSE INT.", "CP INT.", "COMMUNE INT.", "DATE FAITS", "ADRESSE FAITS", "CP FAITS", "COMMUNE FAITS", "ECHANT. PRIS PAR", "NUMÉRO ECHANT.", "DATE DE DEPÔT ECHANT.", "CODE ECHANT.", "NUMÉRO PV CRU", "DATE PV CRU", "NUM. RAPPORT INCC", "DATE RAPPORT INCC", "CONCLUSIONS INCC", "UNITÉ", "FICHE CRU", "PV INITIAL", "NUM. RIO", "NUM. ON", "NUM. SIENA", "PNS", "LANGUE", "ENQUÊTEUR"}
        Export(list)
    End Sub
    Private Sub mnEN_Click(sender As Object, e As EventArgs) Handles mnEN.Click
        Dim list As String() = {"CASE NAME", "INTERVENTION", "DATE INT.", "ADRESS INT.", "ZIP INT.", "CITY INT.", "DATE FACTS", "ADRESS FACTS", "ZIP FACTS", "CITY FACTS", "SAMPLES TAKEN BY", "SAMPLES NUM.", "SAMPLES DELIVERY DATE", "SAMPLES CODE", "CRU REPORT NUM.", "CRU REPORT DATE", "NICC REPORT NUM.", "NICC REPORT DATE", "NICC CONCLUSIONS", "UNIT", "CRU FILE NUM.", "INITIAL REPORT", "RIO NUM.", "ON NUM.", "SIENA NUM.", "NSP", "LANGUAGE", "INVESTIGATOR"}
        Export(list)
    End Sub
    Private Sub Export(list As String())
        'Export datagridview to excel
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim alpha As String = "ABCDEFGHIJKLMNOPQRS"
        Cursor = Cursors.WaitCursor
        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add
        xlWorkSheet = CType(xlApp.ActiveSheet, Excel.Worksheet)
        Dim k As Integer
        xlWorkSheet.Range(xlWorkSheet.Rows(1), xlWorkSheet.Rows(1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xlWorkSheet.Range(xlWorkSheet.Rows(1), xlWorkSheet.Rows(1)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Rows(1), xlWorkSheet.Rows(1)).Interior.Color = Color.LightBlue
        For i As Integer = 0 To dgvStats.RowCount - 1
            k = 1
            For j As Integer = 0 To dgvStats.ColumnCount - 1
                If dgvStats.Columns(j).Visible = True Then
                    xlWorkSheet.Cells(i + 2, k) = dgvStats(j, i).Value
                    xlWorkSheet.Range(xlWorkSheet.Cells(i + 2, k), xlWorkSheet.Cells(i + 2, k)).BorderAround2()
                    k += 1
                End If
            Next
        Next
        k = 1
        For Each col As DataGridViewColumn In dgvStats.Columns
            If dgvStats.Columns(col.Index).Visible = True Then
                Select Case col.Index
                    Case 1
                        xlWorkSheet.Cells(1, k) = list(0)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 2
                        xlWorkSheet.Cells(1, k) = list(1)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 3
                        xlWorkSheet.Cells(1, k) = list(2)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).NumberFormat = "dd/MM/yyyy"
                    Case 4
                        xlWorkSheet.Cells(1, k) = list(3)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 5
                        xlWorkSheet.Cells(1, k) = list(4)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    Case 6
                        xlWorkSheet.Cells(1, k) = list(5)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 7
                        xlWorkSheet.Cells(1, k) = list(6)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).NumberFormat = "dd/MM/yyyy"
                    Case 8
                        xlWorkSheet.Cells(1, k) = list(7)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 9
                        xlWorkSheet.Cells(1, k) = list(8)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    Case 10
                        xlWorkSheet.Cells(1, k) = list(9)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 11
                        xlWorkSheet.Cells(1, k) = list(10)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    Case 12
                        xlWorkSheet.Cells(1, k) = list(11)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    Case 13
                        xlWorkSheet.Cells(1, k) = list(12)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).NumberFormat = "dd/MM/yyyy"
                    Case 14
                        xlWorkSheet.Cells(1, k) = list(13)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    Case 15
                        xlWorkSheet.Cells(1, k) = list(14)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    Case 16
                        xlWorkSheet.Cells(1, k) = list(15)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).NumberFormat = "dd/MM/yyyy"
                    Case 17
                        xlWorkSheet.Cells(1, k) = list(16)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    Case 18
                        xlWorkSheet.Cells(1, k) = list(17)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).NumberFormat = "dd/MM/yyyy"
                    Case 19
                        xlWorkSheet.Cells(1, k) = list(18)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 20
                        xlWorkSheet.Cells(1, k) = list(19)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 21
                        xlWorkSheet.Cells(1, k) = list(20)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 22
                        xlWorkSheet.Cells(1, k) = list(21)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 23
                        xlWorkSheet.Cells(1, k) = list(22)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 24
                        xlWorkSheet.Cells(1, k) = list(23)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 25
                        xlWorkSheet.Cells(1, k) = list(24)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 26
                        xlWorkSheet.Cells(1, k) = list(25)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 27
                        xlWorkSheet.Cells(1, k) = list(26)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                    Case 28
                        xlWorkSheet.Cells(1, k) = list(27)
                        xlWorkSheet.Range(xlWorkSheet.Columns(k), xlWorkSheet.Columns(k)).AutoFit()
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, k), xlWorkSheet.Cells(1, k)).BorderAround2()
                End Select
                k += 1
            End If
        Next
        Cursor = Cursors.Default
        Dim savePath As String = Nothing
        Using SFD As New SaveFileDialog
            With SFD
                .RestoreDirectory = True
                .FileName = "List.xlsx"
                .Filter = "Excel XLS Files(*.xlsx)|*.xlsx"
                If .ShowDialog = DialogResult.OK Then
                    savePath = .FileName
                End If
            End With
        End Using
        If savePath IsNot Nothing AndAlso savePath.Trim <> "" Then
            If File.Exists(savePath) Then File.Delete(savePath)
            xlWorkBook.SaveAs(savePath, Excel.XlFileFormat.xlWorkbookDefault)
            xlWorkBook.Close(SaveChanges:=False)
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            Process.Start(savePath)
        Else
            xlWorkBook.Close(SaveChanges:=False)
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
        End If
    End Sub
    Private Sub releaseObject(obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
#End Region
#Region "Miscellaneous"
    Private Sub Trad()
        'Translate GUI
        If Lang = 1 Then
            lblDates.Text = "Datum"
            lblIntervention.Text = "Interventie"
            lblPlace.Text = "Plaats"
            lblDrug.Text = "Productie"
            lblCity.Text = "Gemeente"
            lblArro.Text = "Arrondissement"
            lblManager.Text = "Beheerder"
            lblText.Text = "Vrij tekst"
            mnViewIntervention.Text = "Interventie tonen"
            mnExportList.Text = "Lijst exporteren"
            mnAllInts.Text = "Interventie"
            mnDateInt.Text = "Datum"
            mnAdressInt.Text = "Adres"
            mnZipInt.Text = "Postcode"
            mnCityInt.Text = "Gemeente"
            mnAllFacts.Text = "Feiten"
            mnDateFacts.Text = "Datum"
            mnAdressFacts.Text = "Adres"
            mnZipFacts.Text = "Postcode"
            mnCityFacts.Text = "Gemeente"
            mnAllSamples.Text = "Staalname"
            mnSamplesT.Text = "Genomen door"
            mnSamplesN.Text = "Nummer"
            mnSamplesD.Text = "Datum"
            mnSamplesC.Text = "Code"
            mnAllCRUReport.Text = "CRU PV"
            mnCRUReportN.Text = "Nummer"
            mnCRUReportD.Text = "Datum"
            mnAllNICCReport.Text = "NICC verslag"
            mnNICCReportN.Text = "Nummer"
            mnNICCReportD.Text = "Datum"
            mnNICCReportC.Text = "Besluit"
            mnAllCase.Text = "Dossier"
            mnUnit.Text = "Eenheid"
            mnFileNum.Text = "CRU fiche"
            mnReportNum.Text = "Aanvankelijk PV"
            mnRIONum.Text = "RIO nummer"
            mnONNum.Text = "ON nummer"
            mnSIENANum.Text = "SIENA nummer"
            mnNSP.Text = "NVP"
            mnLang.Text = "Taal"
            mnCMExt.Text = "Onderzoeker"
            mnInterventionDone.Text = "Interventies gesloten"
            mnCRUOnSite.Text = "CRU ter plaatse"
            ToolTip.SetToolTip(btnAddFilters, "Extra filters")
        Else
            lblDates.Text = "Dates"
            lblIntervention.Text = "Intervention"
            lblPlace.Text = "Lieu"
            lblDrug.Text = "Production"
            lblCity.Text = "Commune"
            lblArro.Text = "Arrondissement"
            lblManager.Text = "Gestionnaire"
            lblText.Text = "Texte libre"
            mnViewIntervention.Text = "Visualiser l'intervention"
            mnExportList.Text = "Exporter liste"
            mnAllInts.Text = "Intervention"
            mnDateInt.Text = "Date"
            mnAdressInt.Text = "Adresse"
            mnZipInt.Text = "Code postal"
            mnCityInt.Text = "Commune"
            mnAllFacts.Text = "Faits"
            mnDateFacts.Text = "Date"
            mnAdressFacts.Text = "Adresse"
            mnZipFacts.Text = "Code postal"
            mnCityFacts.Text = "Commune"
            mnAllSamples.Text = "Échantillons"
            mnSamplesT.Text = "Prélevés par"
            mnSamplesN.Text = "Numéro"
            mnSamplesD.Text = "Date"
            mnSamplesC.Text = "Code"
            mnAllCRUReport.Text = "PV CRU"
            mnCRUReportN.Text = "Numéro"
            mnCRUReportD.Text = "Date"
            mnAllNICCReport.Text = "Rapport INCC"
            mnNICCReportN.Text = "Numéro"
            mnNICCReportD.Text = "Date"
            mnNICCReportC.Text = "Conclusions"
            mnAllCase.Text = "Dossier"
            mnUnit.Text = "Unité"
            mnFileNum.Text = "Fiche CRU"
            mnReportNum.Text = "PV initial"
            mnRIONum.Text = "Numéro RIO"
            mnONNum.Text = "Numéro ON"
            mnSIENANum.Text = "Numéro SIENA"
            mnNSP.Text = "PNS"
            mnLang.Text = "Langue"
            mnCMExt.Text = "Enquêteur"
            mnInterventionDone.Text = "Interventions clôturées"
            mnCRUOnSite.Text = "CRU sur place"
            ToolTip.SetToolTip(btnAddFilters, "Filtres supplémentaires")
        End If
    End Sub
    Private Sub FillCombo()
        'Fill comboboxes
        If Lang = 1 Then
            cmbTypeOfInt.Items.Add("Labo's")
            cmbTypeOfInt.Items.Add("Labo's in werking")
            cmbTypeOfInt.Items.Add("Achtergelaten labo's")
            cmbTypeOfInt.Items.Add("Ontmanteld labo's")
            cmbTypeOfInt.Items.Add("Labo's in opbouw")
            cmbTypeOfInt.Items.Add("Labo's in stand-by")
            cmbTypeOfInt.Items.Add("Dumpings")
            cmbTypeOfInt.Items.Add("Opslagplaats")
            cmbTypeOfInt.Items.Add("Trafic")
            cmbTypeOfInt.Items.Add("Cannabis plantages")
            cmbTypeOfInt.Items.Add("Expertise")
            cmbTypeOfInt.Items.Add("Vervolgens")
            cmbTypeOfInt.Items.Add("Geen drugs")
            cmbTypeOfInt.Items.Add("Geen interventie")
            cmbTypeOfInt.Items.Add("Andere")
            cmbTypeOfInt.DropDownWidth = 160
            cmbTypeOfPlace.Items.Add("Woning")
            cmbTypeOfPlace.Items.Add("Hoeve")
            cmbTypeOfPlace.Items.Add("Openbare weg")
            cmbTypeOfPlace.Items.Add("Private plaats")
            cmbTypeOfPlace.Items.Add("Voertuig")
            cmbTypeOfPlace.Items.Add("Schip")
            cmbTypeOfPlace.Items.Add("Loods")
            cmbTypeOfPlace.Items.Add("Natuur")
            cmbTypeOfPlace.Items.Add("SGS")
            cmbTypeOfPlace.Items.Add("Remondis")
            cmbArro.Items.Add("Antwerpen")
            cmbArro.Items.Add("Limburg")
            cmbArro.Items.Add("Oost-Vlaanderen")
            cmbArro.Items.Add("Leuven")
            cmbArro.Items.Add("West-Vlaanderen")
            cmbArro.Items.Add("Brussel")
            cmbArro.Items.Add("Brabant wallon")
            cmbArro.Items.Add("Hainaut")
            cmbArro.Items.Add("Liège")
            cmbArro.Items.Add("Eupen")
            cmbArro.Items.Add("Luxembourg")
            cmbArro.Items.Add("Namur")
            cmbDrug.Items.Add("MDMA")
            cmbDrug.Items.Add("Amfetamine")
            cmbDrug.Items.Add("Metamfetamine")
            cmbDrug.Items.Add("(Pre)-Precursors")
            cmbDrug.Items.Add("Cannabis")
            cmbDrug.Items.Add("Cocaïne")
            cmbDrug.Items.Add("Heroïne")
            cmbDrug.Items.Add("NPS")
            cmbDrug.Items.Add("Ketamine")
        Else
            cmbTypeOfInt.Items.Add("Labos")
            cmbTypeOfInt.Items.Add("Labos en fonction")
            cmbTypeOfInt.Items.Add("Labos abandonnés")
            cmbTypeOfInt.Items.Add("Labos démantelés")
            cmbTypeOfInt.Items.Add("Labos en construction")
            cmbTypeOfInt.Items.Add("Labos en stand-by")
            cmbTypeOfInt.Items.Add("Dumpings")
            cmbTypeOfInt.Items.Add("Stockages")
            cmbTypeOfInt.Items.Add("Trafics")
            cmbTypeOfInt.Items.Add("Plantations de cannabis")
            cmbTypeOfInt.Items.Add("Expertises")
            cmbTypeOfInt.Items.Add("Suites d'enquête")
            cmbTypeOfInt.Items.Add("Pas de drogue")
            cmbTypeOfInt.Items.Add("Pas d'intervention")
            cmbTypeOfInt.Items.Add("Autre")
            cmbTypeOfInt.DropDownWidth = 170
            cmbTypeOfPlace.Items.Add("Habitation")
            cmbTypeOfPlace.Items.Add("Ferme")
            cmbTypeOfPlace.Items.Add("Voie publique")
            cmbTypeOfPlace.Items.Add("Lieu privé")
            cmbTypeOfPlace.Items.Add("Véhicule")
            cmbTypeOfPlace.Items.Add("Navire")
            cmbTypeOfPlace.Items.Add("Entrpôt")
            cmbTypeOfPlace.Items.Add("Nature")
            cmbTypeOfPlace.Items.Add("SGS")
            cmbTypeOfPlace.Items.Add("Remondis")
            cmbArro.Items.Add("Antwerpen")
            cmbArro.Items.Add("Limburg")
            cmbArro.Items.Add("Oost-Vlaanderen")
            cmbArro.Items.Add("Leuven")
            cmbArro.Items.Add("West-Vlaanderen")
            cmbArro.Items.Add("Bruxelles")
            cmbArro.Items.Add("Brabant wallon")
            cmbArro.Items.Add("Hainaut")
            cmbArro.Items.Add("Liège")
            cmbArro.Items.Add("Eupen")
            cmbArro.Items.Add("Luxembourg")
            cmbArro.Items.Add("Namur")
            cmbDrug.Items.Add("MDMA")
            cmbDrug.Items.Add("Amphétamine")
            cmbDrug.Items.Add("Methamphétamine")
            cmbDrug.Items.Add("(Pré)-Précurseurs")
            cmbDrug.Items.Add("Cannabis")
            cmbDrug.Items.Add("Cocaïne")
            cmbDrug.Items.Add("Héroïne")
            cmbDrug.Items.Add("NPS")
            cmbDrug.Items.Add("Kétamine")
        End If
        For i As Integer = Year(Now) To 2014 Step -1
            cmbFrom.Items.Add(i)
        Next
        cmbFrom.SelectedIndex = 0
        cmbTo.Text = CStr(Year(Now))
        cmbFrom.SelectedIndex = 1
        cmbCity.DropDownHeight = 40 * cmbCity.ItemHeight
    End Sub
    Private Sub SetColors()
        'Set colors of controls according to choosen theme
        MainTable.BackColor = theme("Light")
        dgvStats.BackgroundColor = theme("Light")
        dgvStats.RowsDefaultCellStyle.BackColor = theme("Light")
        dgvStats.RowsDefaultCellStyle.ForeColor = theme("Font")
        dgvStats.RowsDefaultCellStyle.SelectionBackColor = theme("High")
        dgvStats.ColumnHeadersDefaultCellStyle.BackColor = theme("Font")
        dgvStats.ColumnHeadersDefaultCellStyle.SelectionBackColor = theme("Font")
        dgvStats.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 12, FontStyle.Bold)
        dgvStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dim lst_controls As New List(Of Control)
        For Each c As IconButton In FindControlRecursive(lst_controls, Me, GetType(IconButton))
            c.IconColor = theme("Font")
        Next
        lst_controls = New List(Of Control)
        For Each c As Label In FindControlRecursive(lst_controls, Me, GetType(Label))
            c.ForeColor = theme("Font")
        Next
        mnAllInts.ForeColor = Color.Teal
        mnDateInt.ForeColor = Color.Teal
        mnAdressInt.ForeColor = Color.Teal
        mnZipInt.ForeColor = Color.Teal
        mnCityInt.ForeColor = Color.Teal
        mnAllFacts.ForeColor = Color.DarkBlue
        mnDateFacts.ForeColor = Color.DarkBlue
        mnAdressFacts.ForeColor = Color.DarkBlue
        mnZipFacts.ForeColor = Color.DarkBlue
        mnCityFacts.ForeColor = Color.DarkBlue
        mnAllSamples.ForeColor = Color.DarkRed
        mnSamplesT.ForeColor = Color.DarkRed
        mnSamplesN.ForeColor = Color.DarkRed
        mnSamplesD.ForeColor = Color.DarkRed
        mnSamplesC.ForeColor = Color.DarkRed
        mnAllCRUReport.ForeColor = Color.DarkOrange
        mnCRUReportN.ForeColor = Color.DarkOrange
        mnCRUReportD.ForeColor = Color.DarkOrange
        mnAllNICCReport.ForeColor = Color.DarkGreen
        mnNICCReportN.ForeColor = Color.DarkGreen
        mnNICCReportD.ForeColor = Color.DarkGreen
        mnNICCReportC.ForeColor = Color.DarkGreen
        mnAllCase.ForeColor = Color.DarkOrchid
        mnUnit.ForeColor = Color.DarkOrchid
        mnFileNum.ForeColor = Color.DarkOrchid
        mnReportNum.ForeColor = Color.DarkOrchid
        mnRIONum.ForeColor = Color.DarkOrchid
        mnONNum.ForeColor = Color.DarkOrchid
        mnSIENANum.ForeColor = Color.DarkOrchid
        mnNSP.ForeColor = Color.DarkOrchid
        mnLang.ForeColor = Color.DarkOrchid
        mnCMExt.ForeColor = Color.DarkOrchid
    End Sub
    Private Sub EnableDoubleBuffered(dgv As DataGridView, setting As Boolean)
        'Speed up scrolling of datagridviews
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, setting, Nothing)
    End Sub
    Private Sub GetUser()
        Dim user_list() As String = SearchFile($"{dora_path}cru.txt", Environment.UserName)
        user = user_list(0)
        cmbCMInt.Text = user
        For Each Line As String In File.ReadLines($"{dora_path}cru.txt")
            If Line.Contains("44") Then
                cmbCMInt.Items.Add(Line.Split(CChar(";"))(0).Replace(vbTab, ""))
            End If
        Next
        cmbCMInt.Text = String.Empty
    End Sub
    Public Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If dgvStats.SelectedRows.Count > 0 Then
            Dim i As Integer = INTERVENTIONSBindingSource.Position
            Dim j = dgvStats.FirstDisplayedScrollingRowIndex
            INTERVENTIONSTableAdapter.Fill(DORADbDS.INTERVENTIONS)
            btnSearch_Click(sender, e)
            dgvStats.Rows(i).Selected = True
            If dgvStats.Rows.Count > 0 Then dgvStats.FirstDisplayedScrollingRowIndex = j
        End If
    End Sub
    Private Sub cmbFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFrom.SelectedIndexChanged
        'Fill comboboxes depending on user's choice
        cmbTo.Items.Clear()
        For i As Integer = Year(Now) To CInt(Int(cmbFrom.Text)) Step -1
            cmbTo.Items.Add(i)
        Next
        cmbTo.SelectedIndex = 0
    End Sub
    Private Sub cmbCMInt_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles cmbCMInt.MouseDoubleClick
        Dim c As ComboBox = CType(sender, ComboBox)
        c.Text = String.Empty
    End Sub
    Private Sub cmbNoInput(sender As Object, e As KeyPressEventArgs) Handles cmbFrom.KeyPress, cmbTo.KeyPress
        'Make comboboxes read-only
        e.Handled = True
    End Sub
    Private Sub txtFind_MouseDoubleClick(sender As Object, e As EventArgs) Handles txtFind.MouseDoubleClick
        txtFind.Text = String.Empty
        For i As Integer = 0 To dgvStats.RowCount - 1
            For j As Integer = 0 To dgvStats.ColumnCount - 1
                dgvStats.Rows(i).Cells(j).Style.BackColor = theme("Light")
                dgvStats.Rows(i).Cells(j).Style.ForeColor = theme("Font")
            Next
        Next
        lblCounter.Visible = False
        btnDown.Visible = False
        btnUp.Visible = False
    End Sub
    Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFind.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Search()
        End If
    End Sub
    Private Sub frmSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Alt AndAlso e.KeyCode = Keys.X) Then
            opened_out = False
            Close()
        End If
    End Sub
    Private Sub frmSearch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If opened_out = True Then
            My.Settings.frmSearch_loc = Location
            My.Settings.frmSearch_size = Size
        End If
    End Sub
#End Region

End Class