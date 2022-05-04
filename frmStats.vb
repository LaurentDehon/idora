Option Explicit On
Option Strict On
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Public Class frmStats
    Dim DateFrom As Date
    Dim DateTo As Date
    Dim hours As String
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub frmStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetColors()
        Trad()
        FillCombo()
        InitializeComboboxes()
        'Fill and sort datatables
        CASESTableAdapter.Fill(DORADbDS.CASES)
        CITIESTableAdapter.Fill(DORADbDS.CITIES)
        DRUGS_INTTableAdapter.Fill(DORADbDS.DRUGS_INT)
        MEMBERS_INTTableAdapter.Fill(DORADbDS.MEMBERS_INT)
        INTERVENTIONSTableAdapter.Fill(DORADbDS.INTERVENTIONS)
        INTERVENTIONSBindingSource.Sort = "[DATE INT] DESC, [ID CRU] DESC"
        LoadStats()
    End Sub
#Region "Stats"
    Private Sub CountIndividualStats()
        Dim StatsDV2 As New DataView(memberToDs2(DORADbDS).Tables("MEMBERS"))
        Dim count As Integer
        Dim dttot As TimeSpan
        Dim dtspan As TimeSpan
        Dim space As Integer = 16
        Dim j As Integer = 0
        For Each Line As String In File.ReadLines($"{dora_path}cru.txt")
            If Line.Contains("44") Then
                StatsDV2.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([MEMBERNAME] LIKE '*{Line.Split(CChar(";"))(0).Split(CChar(" "))(1)}*')"
                count = StatsDV2.Count
                For i As Integer = 0 To StatsDV2.Count - 1
                    If Not String.IsNullOrEmpty(CStr(StatsDV2(i)(3))) Then
                        dtspan = TimeSpan.Parse(CStr(StatsDV2(i)(3)))
                        dttot += dtspan
                    End If
                Next
                Dim IntText As String
                If Lang = 1 Then
                    IntText = $"{Line.Split(CChar(";"))(0)}: {count} interventies{Environment.NewLine}  ↪  {String.Format("{0:00}:{1:00}", Int(dttot.TotalHours), dttot.Minutes)} {hours}"
                Else
                    IntText = $"{Line.Split(CChar(";"))(0)}: {count} interventions{Environment.NewLine}  ↪  {String.Format("{0:00}:{1:00}", Int(dttot.TotalHours), dttot.Minutes)} {hours}"
                End If
                Dim lblInt As New Label With {
                .Text = IntText,
                .AutoSize = True,
                .Location = New Point(16, j * 55 + space)
                }
                pnlIndividualStats.Controls.Add(lblInt)
                j += 1
                dttot = TimeSpan.Zero
            End If
        Next
    End Sub
    Private Sub CountGroupStats()
        Dim lst_labs As New List(Of Integer)({0, 0, 0})
        Dim lst_type_of_labs As New List(Of Integer)({0, 0, 0, 0, 0})
        Dim countdays As Integer = 0
        INTERVENTIONSBindingSource.MoveFirst()
        For i As Integer = 0 To INTERVENTIONSBindingSource.Count - 1
            'Count days stats
            Dim Date1 As Date
            Dim Date2 As Date
            Dim Date3 As Date
            If CBool(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CRU ON SITE")) = True Then countdays += 1
            If DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE 1") IsNot DBNull.Value Then Date1 = CDate(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE 1"))
            If DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE 2") IsNot DBNull.Value Then Date2 = CDate(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE 2"))
            If DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE 3") IsNot DBNull.Value Then Date3 = CDate(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE 3"))
            If DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE 2") IsNot DBNull.Value AndAlso Date2.Date > Date1.Date Then
                countdays += 1
                If DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE 3") IsNot DBNull.Value AndAlso Date3.Date > Date2.Date Then
                    countdays += 1
                End If
            End If
            'Count labs / dumpings / storages
            If CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT")).ToLower.Contains("labo") Then
                lst_labs(0) += 1
                If CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT")).ToLower.Contains("fonction") OrElse CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT")).ToLower.Contains("werking") Then
                    lst_type_of_labs(0) += 1
                ElseIf CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT")).ToLower.Contains("abandonné") OrElse CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT")).ToLower.Contains("achtergelaten") Then
                    lst_type_of_labs(1) += 1
                ElseIf CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT")).ToLower.Contains("démantelé") OrElse CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT")).ToLower.Contains("ontmanteld") Then
                    lst_type_of_labs(2) += 1
                ElseIf CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT")).ToLower.Contains("construction") OrElse CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT")).ToLower.Contains("opbouw") Then
                    lst_type_of_labs(3) += 1
                ElseIf CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT")).ToLower.Contains("stand-by") Then
                    lst_type_of_labs(4) += 1
                End If
            ElseIf CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT")).ToLower.Contains("dumping") Then
                lst_labs(1) += 1
            ElseIf CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT")).ToLower.Contains("stockage") OrElse CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("TYPE OF INT")).ToLower.Contains("opslagplaats") Then
                lst_labs(2) += 1
            End If
            INTERVENTIONSBindingSource.MoveNext()
        Next
        'Display
        If Lang = 1 Then
            lblCases.Text = $"{CASESBindingSource.Count} dossiers"
            lblInterventions.Text = $" ↪  {INTERVENTIONSBindingSource.Count} interventies"
            lblOut.Text = $"      ↪  {countdays} dagen op de grond"
            lblLabs.Text = $"{lst_labs(0)} labo's"
            lblWorking.Text = $" ↪  {lst_type_of_labs(0)} in werking"
            lblAbandonned.Text = $" ↪  {lst_type_of_labs(1)} achtergelaten"
            lblDismantled.Text = $" ↪  {lst_type_of_labs(2)} ontmanteld"
            lblConstruction.Text = $" ↪  {lst_type_of_labs(3)} in opbouw"
            lblStandBy.Text = $" ↪  {lst_type_of_labs(4)} in stand-by"
            lblDumpings.Text = $"{lst_labs(1)} dumpings"
            lblStorages.Text = $"{lst_labs(2)} opslagplaats"
        Else
            lblCases.Text = $"{CASESBindingSource.Count} dossiers"
            lblInterventions.Text = $" ↪  {INTERVENTIONSBindingSource.Count} interventions"
            lblOut.Text = $"      ↪  {countdays} jours sur le terrain"
            lblLabs.Text = $"{lst_labs(0)} labos"
            lblWorking.Text = $" ↪  {lst_type_of_labs(0)} en fonction"
            lblAbandonned.Text = $" ↪  {lst_type_of_labs(1)} abandonnés"
            lblDismantled.Text = $" ↪  {lst_type_of_labs(2)} démantelés"
            lblConstruction.Text = $" ↪  {lst_type_of_labs(3)} en construction"
            lblStandBy.Text = $" ↪  {lst_type_of_labs(4)} en stand-by"
            lblDumpings.Text = $"{lst_labs(1)} dumpings"
            lblStorages.Text = $"{lst_labs(2)} stockages"
        End If
    End Sub
    Private Sub LoadStats()
        'Build stats for each member and number of days out
        DateFrom = Convert.ToDateTime("01/01/" & cmbFrom.Text)
        DateTo = Convert.ToDateTime("31/12/" & cmbTo.Text)
        CASESBindingSource.Filter = $"[DATE FACTS] >= #{DateFrom:MM/dd/yyyy}# AND [DATE FACTS] <= #{DateTo:MM/dd/yyyy}#"
        INTERVENTIONSBindingSource.Filter = $"[DATE INT] >= #{DateFrom:MM/dd/yyyy}# AND [DATE INT] <= #{DateTo:MM/dd/yyyy}# AND [TYPE OF INT] NOT LIKE '*interventie*' AND [TYPE OF INT] NOT LIKE '*intervention*'"
        'Remove labels
        For i As Integer = pnlIndividualStats.Controls.Count - 1 To 0 Step -1
            If TypeOf pnlIndividualStats.Controls(i) Is Label Then
                pnlIndividualStats.Controls.RemoveAt(i)
            End If
        Next
        For i As Integer = pnlLastInts.Controls.Count - 1 To 0 Step -1
            If TypeOf pnlLastInts.Controls(i) Is Label Then
                pnlLastInts.Controls.RemoveAt(i)
            End If
        Next
        'Set title
        If Lang = 1 Then
            lblPeriod.Text = $"Diverse statistieken over de periode {cmbFrom.Text} - {cmbTo.Text}"
        Else
            lblPeriod.Text = $"Statistiques diverses pour la période {cmbFrom.Text} - {cmbTo.Text}"
        End If
        CountIndividualStats()
        CountGroupStats()
        'Position pnlDaysStats
        pnlDaysStats.Location = New Point(pnlIndividualStats.Location.X + pnlIndividualStats.Width + 16, pnlIndividualStats.Location.Y)
        'Setup last ints
        Dim biggest As Integer = 0
        If INTERVENTIONSBindingSource.Count > 0 Then
            INTERVENTIONSBindingSource.MoveFirst()
            Dim j As Integer = 0
            For i As Integer = 0 To 4
                Dim lblInt As New Label With {
                .Text = $"{CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CASE NAME"))}{Environment.NewLine} ↪  {CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE INT"))} - {CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CITY INT"))}",
                .AutoSize = True,
                .Location = New Point(16, j * 55 + 16)
                }
                pnlLastInts.Controls.Add(lblInt)
                If lblInt.Width > biggest Then biggest = lblInt.Width
                j += 1
                INTERVENTIONSBindingSource.MoveNext()
            Next
        End If
        'Position & resize pnlLastInts
        pnlLastInts.Location = New Point(pnlDaysStats.Location.X + pnlDaysStats.Width + 16, pnlDaysStats.Location.Y)
        pnlLastInts.Width = biggest + 32
        pnlLastInts.Height = 55 * 5 + 32
        'Position & resize pnlLabsStats
        pnlLabsStats.Location = New Point(pnlDaysStats.Location.X, pnlDaysStats.Location.Y + pnlDaysStats.Height + 16)
        pnlLabsStats.Width = pnlDaysStats.Width
        'Resize pnlPeriod & position lblPeriod
        pnlPeriod.Width = pnlIndividualStats.Width + pnlDaysStats.Width + pnlLastInts.Width + 32
        lblPeriod.Left = (pnlPeriod.Width \ 2) - (lblPeriod.Width \ 2)
        lblPeriod.Top = (pnlPeriod.Height \ 2) - (lblPeriod.Height \ 2)
        'Resize pnlChart
        pnlChart.Width = pnlPeriod.Width
        btnChart.Width = pnlChart.Width - cmbChart.Width - 48
        'Reposition & resize borders
        For Each c As Control In Controls
            If c.Name = "pnlIndividualStats_border" Then
                c.Size = New Size(pnlIndividualStats.Width + 2, pnlIndividualStats.Height + 2)
                c.Location = New Point(pnlIndividualStats.Location.X - 1, pnlIndividualStats.Location.Y - 1)
            End If
            If c.Name = "pnlDaysStats_border" Then
                c.Size = New Size(pnlDaysStats.Width + 2, pnlDaysStats.Height + 2)
                c.Location = New Point(pnlDaysStats.Location.X - 1, pnlDaysStats.Location.Y - 1)
            End If
            If c.Name = "pnlLabsStats_border" Then
                c.Size = New Size(pnlLabsStats.Width + 2, pnlLabsStats.Height + 2)
                c.Location = New Point(pnlLabsStats.Location.X - 1, pnlLabsStats.Location.Y - 1)
            End If
            If c.Name = "pnlPeriod_border" Then
                c.Size = New Size(pnlPeriod.Width + 2, pnlPeriod.Height + 2)
                c.Location = New Point(pnlPeriod.Location.X - 1, pnlPeriod.Location.Y - 1)
            End If
            If c.Name = "pnlLastInts_border" Then
                c.Size = New Size(pnlLastInts.Width + 2, pnlLastInts.Height + 2)
                c.Location = New Point(pnlLastInts.Location.X - 1, pnlLastInts.Location.Y - 1)
            End If
            If c.Name = "pnlChart_border" Then
                c.Size = New Size(pnlChart.Width + 2, pnlChart.Height + 2)
                c.Location = New Point(pnlChart.Location.X - 1, pnlChart.Location.Y - 1)
            End If
        Next
        For Each c As Control In pnlChart.Controls
            If c.Name = "btnChart_border" Then
                c.Size = New Size(btnChart.Width + 2, btnChart.Height + 2)
                c.Location = New Point(btnChart.Location.X - 1, btnChart.Location.Y - 1)
            End If
        Next
        'Reset filters
        INTERVENTIONSBindingSource.Filter = String.Empty
        CASESBindingSource.Filter = String.Empty
    End Sub
    Private Function memberToDs2(ds As DataSet) As DataSet
        'Create Dataset and datatable for individual stats
        Try
            Dim newDs As New DataSet
            Dim IDINT As Integer = Nothing
            Dim DATEINT As Date = Nothing
            Dim MEMBERNAME As String = Nothing
            Dim TIMEIN As String = Nothing
            newDs.Tables.Add("MEMBERS")
            newDs.Tables("MEMBERS").Columns.Add("IDINT", GetType(Int32))
            newDs.Tables("MEMBERS").Columns.Add("DATEINT", GetType(Date))
            newDs.Tables("MEMBERS").Columns.Add("MEMBERNAME", GetType(String))
            newDs.Tables("MEMBERS").Columns.Add("TIMEIN", GetType(String))
            For i As Integer = 0 To ds.Tables("MEMBERS INT").Rows.Count - 1
                IDINT = Nothing
                DATEINT = Nothing
                MEMBERNAME = Nothing
                TIMEIN = Nothing
                IDINT = CInt(ds.Tables("MEMBERS INT").Rows(i).Item(1))
                Dim IntRow = ds.Tables("INTERVENTIONS").Select($"[ID CRU] = {IDINT}")
                DATEINT = CDate(IntRow(0).Item("DATE INT"))
                MEMBERNAME = ds.Tables("MEMBERS INT").Rows(i).Item(2).ToString
                TIMEIN = ds.Tables("MEMBERS INT").Rows(i).Item(3).ToString
                newDs.Tables("MEMBERS").Rows.Add(IDINT, DATEINT, MEMBERNAME, TIMEIN)
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
#End Region
#Region "Chart"
    Private Function memberToDs(ds As DataSet) As DataSet
        'Create Dataset and datatable for charts
        Try
            Dim newDs As DataSet = New DataSet
            Dim IDINT As Integer = Nothing
            Dim DATEINT As Date = Nothing
            Dim CASENAME As String = Nothing
            Dim TYPEOFINT As String = Nothing
            Dim TYPEOFPLACE As String = Nothing
            Dim CITY As String = Nothing
            Dim ARRO As String = Nothing
            Dim DRUG As String = Nothing
            Dim MANAGER As String = Nothing
            Dim DrugB As Boolean
            newDs.Tables.Add("INTS")
            newDs.Tables("INTS").Columns.Add("IDINT", GetType(Int32))
            newDs.Tables("INTS").Columns.Add("DATEINT", GetType(Date))
            newDs.Tables("INTS").Columns.Add("CASENAME", GetType(String))
            newDs.Tables("INTS").Columns.Add("TYPEOFINT", GetType(String))
            newDs.Tables("INTS").Columns.Add("TYPEOFPLACE", GetType(String))
            newDs.Tables("INTS").Columns.Add("CITY", GetType(String))
            newDs.Tables("INTS").Columns.Add("ARRO", GetType(String))
            newDs.Tables("INTS").Columns.Add("DRUG", GetType(String))
            newDs.Tables("INTS").Columns.Add("MANAGER", GetType(String))
            For i As Integer = 0 To ds.Tables("INTERVENTIONS").Rows.Count - 1
                IDINT = Nothing
                DATEINT = Nothing
                CASENAME = Nothing
                TYPEOFINT = Nothing
                TYPEOFPLACE = Nothing
                CITY = Nothing
                ARRO = Nothing
                DRUG = Nothing
                MANAGER = Nothing
                DrugB = False
                IDINT = CInt(ds.Tables("INTERVENTIONS").Rows(i).Item(0))
                DATEINT = CDate(ds.Tables("INTERVENTIONS").Rows(i).Item(2))
                CASENAME = ds.Tables("INTERVENTIONS").Rows(i).Item(1).ToString
                TYPEOFINT = ds.Tables("INTERVENTIONS").Rows(i).Item(3).ToString
                TYPEOFPLACE = ds.Tables("INTERVENTIONS").Rows(i).Item(4).ToString
                CITY = ds.Tables("INTERVENTIONS").Rows(i).Item("CITY FACTS").ToString
                Dim CityRow = ds.Tables("CITIES").Select($"[CITY] = '{CITY}'")
                If CityRow.Length > 0 Then
                    If CityRow(0).Item("ARRO") Is "LIEGE" Then
                        ARRO = "Liège"
                    Else
                        ARRO = CityRow(0).Item("ARRO").ToString
                    End If
                End If
                Dim ProdRow = ds.Tables("DRUGS INT").Select($"[ID INT] = {IDINT}")
                If ProdRow.Length > 0 Then
                    For j As Integer = 0 To ProdRow.Length - 1
                        DRUG = CStr(ProdRow(j).Item("DRUG"))
                        newDs.Tables("INTS").Rows.Add(IDINT, DATEINT, CASENAME, TYPEOFINT, TYPEOFPLACE, CITY, ARRO, DRUG, MANAGER)
                        DrugB = True
                    Next
                End If
                Dim ManagerRow = ds.Tables("CASES").Select($"[CASE NAME] = '{CASENAME}'")
                If ManagerRow.Length > 0 Then
                    If Not IsDBNull(ManagerRow(0).Item("CMINT")) Then
                        MANAGER = CStr(ManagerRow(0).Item("CMINT"))
                    End If
                End If
                If DrugB = False Then newDs.Tables("INTS").Rows.Add(IDINT, DATEINT, CASENAME, TYPEOFINT, TYPEOFPLACE, CITY, ARRO, DRUG, MANAGER)
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
    Private Sub btnChart_Click(sender As Object, e As EventArgs) Handles btnChart.Click
        Dim xlApp = New Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim chartPage As Excel.Chart
        Dim xlCharts As Excel.ChartObjects
        Dim myChart As Excel.ChartObject
        Dim chartRange As Excel.Range
        Dim start_year As Integer = CInt(Int(cmbFrom.Text))
        Dim end_year As Integer = CInt(Int(cmbTo.Text))
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Add
        xlWorkSheet = CType(xlApp.ActiveSheet, Excel.Worksheet)
        xlApp.WindowState = Excel.XlWindowState.xlMaximized
        xlCharts = CType(xlWorkSheet.ChartObjects, Excel.ChartObjects)
        myChart = xlCharts.Add(200, 50, 800, 500)
        chartPage = myChart.Chart
        Select Case cmbChart.SelectedIndex
            Case 0
                Dim lst_series As New List(Of String)({"Production sites", "Dumpings", "Storages"})
                Dim i, j As Integer
                Dim prod As New List(Of Integer)
                Dim dump As New List(Of Integer)
                Dim stor As New List(Of Integer)
                Dim StatsDV As New DataView(memberToDs(DORADbDS).Tables("INTS"))
                For i = start_year To end_year
                    DateFrom = Convert.ToDateTime("01/01/" & i)
                    DateTo = Convert.ToDateTime("31/12/" & i)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*labo*')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    prod.Add(dgvFake.Rows.Count)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*dumping*')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    dump.Add(dgvFake.Rows.Count)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*opslagplaats*' OR [TYPEOFINT] LIKE '*stockage*')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    stor.Add(dgvFake.Rows.Count)
                Next
                j = 2
                For i = 0 To lst_series.Count - 1
                    xlWorkSheet.Cells(1, j) = lst_series(i)
                    j += 1
                Next
                j = 2
                For i = start_year To end_year
                    xlWorkSheet.Cells(j, 1) = i
                    xlWorkSheet.Cells(j, 2) = prod(j - 2)
                    xlWorkSheet.Cells(j, 3) = dump(j - 2)
                    xlWorkSheet.Cells(j, 4) = stor(j - 2)
                    j += 1
                Next
                chartRange = xlWorkSheet.Range("A1", $"D{end_year - start_year + 2}")
                chartPage.SetSourceData(Source:=chartRange, Excel.XlRowCol.xlColumns)
                chartPage.ChartType = Excel.XlChartType.xlColumnClustered
                chartPage.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowValue)
            Case 1
                Dim drugNL As New List(Of String)({"MDMA", "Amfetamine", "Metamfetamine", "(Pre)-Precursors", "Cocaïne", "Heroïne", "NPS", "Ketamine"})
                Dim drugFR As New List(Of String)({"MDMA", "Amphétamine", "Methamphétamine", "(Pré)-Précurseurs", "Cocaïne", "Héroïne", "NPS", "Kétamine"})
                Dim lst_series As New List(Of String)({"Production sites", "Dumpings", "Storages"})
                Dim i, j As Integer
                Dim prod As New List(Of Integer)
                Dim dump As New List(Of Integer)
                Dim stor As New List(Of Integer)
                Dim StatsDV As New DataView(memberToDs(DORADbDS).Tables("INTS"))
                For i = start_year To end_year
                    DateFrom = Convert.ToDateTime("01/01/" & i)
                    DateTo = Convert.ToDateTime("31/12/" & i)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*labo*') AND ([DRUG] = '{drugFR(cmbDrug.SelectedIndex)}' OR [DRUG] = '{drugNL(cmbDrug.SelectedIndex)}')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    prod.Add(dgvFake.Rows.Count)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*dumping*') AND ([DRUG] = '{drugFR(cmbDrug.SelectedIndex)}' OR [DRUG] = '{drugNL(cmbDrug.SelectedIndex)}')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    dump.Add(dgvFake.Rows.Count)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*opslagplaats*' OR [TYPEOFINT] LIKE '*stockage*') AND ([DRUG] = '{drugFR(cmbDrug.SelectedIndex)}' OR [DRUG] = '{drugNL(cmbDrug.SelectedIndex)}')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    stor.Add(dgvFake.Rows.Count)
                Next
                j = 2
                For i = 0 To lst_series.Count - 1
                    xlWorkSheet.Cells(1, j) = lst_series(i)
                    j += 1
                Next
                j = 2
                For i = start_year To end_year
                    xlWorkSheet.Cells(j, 1) = i
                    xlWorkSheet.Cells(j, 2) = prod(j - 2)
                    xlWorkSheet.Cells(j, 3) = dump(j - 2)
                    xlWorkSheet.Cells(j, 4) = stor(j - 2)
                    j += 1
                Next
                chartRange = xlWorkSheet.Range("A1", $"D{end_year - start_year + 2}")
                chartPage.SetSourceData(Source:=chartRange, Excel.XlRowCol.xlColumns)
                chartPage.ChartType = Excel.XlChartType.xlColumnClustered
                chartPage.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowValue)
            Case 2
                Dim lst_series As New List(Of String)({"Production sites", "Dumpings", "Storages"})
                Dim i, j As Integer
                Dim prod As New List(Of Integer)
                Dim dump As New List(Of Integer)
                Dim stor As New List(Of Integer)
                Dim StatsDV As New DataView(memberToDs(DORADbDS).Tables("INTS"))
                Dim arroF, arroN As String
                Dim arro As String = CStr(cmbArro.SelectedItem)
                If arro = "Bruxelles" OrElse arro = "Brussel" Then
                    arroF = "Bruxelles"
                    arroN = "Brussel"
                Else
                    arroF = arro
                    arroN = arro
                End If
                For i = start_year To end_year
                    DateFrom = Convert.ToDateTime("01/01/" & i)
                    DateTo = Convert.ToDateTime("31/12/" & i)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*labo*') AND ([ARRO] LIKE '*{arroF}*' OR [ARRO] LIKE '*{arroN}*')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    prod.Add(dgvFake.Rows.Count)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*dumping*') AND ([ARRO] LIKE '*{arroF}*' OR [ARRO] LIKE '*{arroN}*')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    dump.Add(dgvFake.Rows.Count)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*opslagplaats*' OR [TYPEOFINT] LIKE '*stockage*') AND ([ARRO] LIKE '*{arroF}*' OR [ARRO] LIKE '*{arroN}*')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    stor.Add(dgvFake.Rows.Count)
                Next
                j = 2
                For i = 0 To lst_series.Count - 1
                    xlWorkSheet.Cells(1, j) = lst_series(i)
                    j += 1
                Next
                j = 2
                For i = start_year To end_year
                    xlWorkSheet.Cells(j, 1) = i
                    xlWorkSheet.Cells(j, 2) = prod(j - 2)
                    xlWorkSheet.Cells(j, 3) = dump(j - 2)
                    xlWorkSheet.Cells(j, 4) = stor(j - 2)
                    j += 1
                Next
                chartRange = xlWorkSheet.Range("A1", $"D{end_year - start_year + 2}")
                chartPage.SetSourceData(Source:=chartRange, Excel.XlRowCol.xlColumns)
                chartPage.ChartType = Excel.XlChartType.xlColumnClustered
                chartPage.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowValue)
            Case 3
                Dim lst_series As New List(Of String)({"Production sites", "Dumpings", "Storages"})
                Dim lst_provincesC As New List(Of String)({"ANT", "LIM", "OVL", "LEU", "WVL", "BRU", "BW", "HAI", "LI", "EUP", "LUX", "NAM"})
                Dim lst_provincesN As New List(Of String)({"Antwerpen", "Limburg", "Oost-Vlaanderen", "Leuven", "West-Vlaanderen", "Bru", "Brabant wallon", "Hainaut", "Liège", "Eupen", "Luxembourg", "Namur"})
                Dim i, j As Integer
                Dim prod As New List(Of Integer)
                Dim dump As New List(Of Integer)
                Dim stor As New List(Of Integer)
                Dim StatsDV As New DataView(memberToDs(DORADbDS).Tables("INTS"))
                For i = 0 To lst_provincesC.Count - 1
                    DateFrom = Convert.ToDateTime("01/01/" & start_year)
                    DateTo = Convert.ToDateTime("31/12/" & end_year)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*labo*') AND ([ARRO] LIKE '*{lst_provincesN(i)}*')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    prod.Add(dgvFake.Rows.Count)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*dumping*') AND ([ARRO] LIKE '*{lst_provincesN(i)}*')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    dump.Add(dgvFake.Rows.Count)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*opslagplaats*' OR [TYPEOFINT] LIKE '*stockage*') AND ([ARRO] LIKE '*{lst_provincesN(i)}*')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    stor.Add(dgvFake.Rows.Count)
                Next
                j = 2
                For i = 0 To lst_series.Count - 1
                    xlWorkSheet.Cells(1, j) = lst_series(i)
                    j += 1
                Next
                j = 2
                For i = 0 To lst_provincesC.Count - 1
                    xlWorkSheet.Cells(j, 1) = lst_provincesC(i)
                    xlWorkSheet.Cells(j, 2) = prod(j - 2)
                    xlWorkSheet.Cells(j, 3) = dump(j - 2)
                    xlWorkSheet.Cells(j, 4) = stor(j - 2)
                    j += 1
                Next
                chartRange = xlWorkSheet.Range("A1", $"D{lst_provincesC.Count + 1}")
                chartPage.SetSourceData(Source:=chartRange, Excel.XlRowCol.xlColumns)
                chartPage.ChartType = Excel.XlChartType.xlColumnClustered
                chartPage.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowValue)
            Case 4
                Dim j As Integer = 2
                Dim dict_drug As Dictionary(Of String, Integer) = prods_to_dict("labo", "labo", start_year, end_year)
                For Each item In dict_drug
                    xlWorkSheet.Cells(j, 1) = item.Key
                    xlWorkSheet.Cells(j, 2) = item.Value
                    j += 1
                Next
                chartRange = xlWorkSheet.Range("A1", $"B{dict_drug.Count + 1}")
                chartPage.SetSourceData(Source:=chartRange, Excel.XlRowCol.xlColumns)
                chartPage.ChartType = Excel.XlChartType.xl3DPie
                chartPage.SetElement(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelOutSideEnd)
                chartPage.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowLabel)
                chartPage.Elevation = 45
            Case 5
                Dim j As Integer = 2
                Dim dict_drug As Dictionary(Of String, Integer) = prods_to_dict("dumping", "dumping", start_year, end_year)
                For Each item In dict_drug
                    xlWorkSheet.Cells(j, 1) = item.Key
                    xlWorkSheet.Cells(j, 2) = item.Value
                    j += 1
                Next
                chartRange = xlWorkSheet.Range("A1", $"B{dict_drug.Count + 1}")
                chartPage.SetSourceData(Source:=chartRange, Excel.XlRowCol.xlColumns)
                chartPage.ChartType = Excel.XlChartType.xl3DPie
                chartPage.SetElement(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelOutSideEnd)
                chartPage.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowLabel)
                chartPage.Elevation = 45
            Case 6
                Dim j As Integer = 2
                Dim dict_drug As Dictionary(Of String, Integer) = prods_to_dict("stockage", "opslagplaats", start_year, end_year)
                For Each item In dict_drug
                    xlWorkSheet.Cells(j, 1) = item.Key
                    xlWorkSheet.Cells(j, 2) = item.Value
                    j += 1
                Next
                chartRange = xlWorkSheet.Range("A1", $"B{dict_drug.Count + 1}")
                chartPage.SetSourceData(Source:=chartRange, Excel.XlRowCol.xlColumns)
                chartPage.ChartType = Excel.XlChartType.xl3DPie
                chartPage.SetElement(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelOutSideEnd)
                chartPage.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowLabel)
                chartPage.Elevation = 45
            Case 7
                Dim i, j, k As Integer
                Dim lst_count As New List(Of Integer)
                Dim StatsDV As New DataView(memberToDs(DORADbDS).Tables("INTS"))
                Dim arro, arroF, arroN As String
                For i = 0 To cmbArro.Items.Count - 1
                    arro = CStr(cmbArro.Items(i))
                    If arro = "Bruxelles" OrElse arro = "Brussel" Then
                        arroF = "Bruxelles"
                        arroN = "Brussel"
                    Else
                        arroF = arro
                        arroN = arro
                    End If
                    DateFrom = Convert.ToDateTime("01/01/" & start_year)
                    DateTo = Convert.ToDateTime("31/12/" & end_year)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*labo*') AND ([ARRO] LIKE '*{arroF}*' OR [ARRO] LIKE '*{arroN}*')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    lst_count.Add(dgvFake.Rows.Count)
                Next
                j = 2
                k = 2
                For i = 0 To cmbArro.Items.Count - 1
                    If lst_count(j - 2) <> 0 Then
                        xlWorkSheet.Cells(k, 1) = cmbArro.Items(i)
                        xlWorkSheet.Cells(k, 2) = lst_count(j - 2)
                        k += 1
                    End If
                    j += 1
                Next
                chartRange = xlWorkSheet.Range($"A1", $"B{k - 1}")
                chartPage.SetSourceData(Source:=chartRange, Excel.XlRowCol.xlColumns)
                chartPage.ChartType = Excel.XlChartType.xl3DPie
                chartPage.SetElement(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelOutSideEnd)
                chartPage.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowLabel)
                chartPage.Elevation = 45
            Case 8
                Dim i, j, k As Integer
                Dim lst_count As New List(Of Integer)
                Dim StatsDV As New DataView(memberToDs(DORADbDS).Tables("INTS"))
                Dim arro, arroF, arroN As String
                For i = 0 To cmbArro.Items.Count - 1
                    arro = CStr(cmbArro.Items(i))
                    If arro = "Bruxelles" OrElse arro = "Brussel" Then
                        arroF = "Bruxelles"
                        arroN = "Brussel"
                    Else
                        arroF = arro
                        arroN = arro
                    End If
                    DateFrom = Convert.ToDateTime("01/01/" & start_year)
                    DateTo = Convert.ToDateTime("31/12/" & end_year)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*dumping*') AND ([ARRO] LIKE '*{arroF}*' OR [ARRO] LIKE '*{arroN}*')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    lst_count.Add(dgvFake.Rows.Count)
                Next
                j = 2
                k = 2
                For i = 0 To cmbArro.Items.Count - 1
                    If lst_count(j - 2) <> 0 Then
                        xlWorkSheet.Cells(k, 1) = cmbArro.Items(i)
                        xlWorkSheet.Cells(k, 2) = lst_count(j - 2)
                        k += 1
                    End If
                    j += 1
                Next
                chartRange = xlWorkSheet.Range($"A1", $"B{k - 1}")
                chartPage.SetSourceData(Source:=chartRange, Excel.XlRowCol.xlColumns)
                chartPage.ChartType = Excel.XlChartType.xl3DPie
                chartPage.SetElement(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelOutSideEnd)
                chartPage.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowLabel)
                chartPage.Elevation = 45
            Case 9
                Dim i, j, k As Integer
                Dim lst_count As New List(Of Integer)
                Dim StatsDV As New DataView(memberToDs(DORADbDS).Tables("INTS"))
                Dim arro, arroF, arroN As String
                For i = 0 To cmbArro.Items.Count - 1
                    arro = CStr(cmbArro.Items(i))
                    If arro = "Bruxelles" OrElse arro = "Brussel" Then
                        arroF = "Bruxelles"
                        arroN = "Brussel"
                    Else
                        arroF = arro
                        arroN = arro
                    End If
                    DateFrom = Convert.ToDateTime("01/01/" & start_year)
                    DateTo = Convert.ToDateTime("31/12/" & end_year)
                    StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([TYPEOFINT] LIKE '*opslagplaats*' OR [TYPEOFINT] LIKE '*stockage*') AND ([ARRO] LIKE '*{arroF}*' OR [ARRO] LIKE '*{arroN}*')"
                    dgvFake.DataSource = StatsDV.ToTable(True, "IDINT", "DATEINT", "CASENAME", "TYPEOFINT", "CITY")
                    lst_count.Add(dgvFake.Rows.Count)
                Next
                j = 2
                k = 2
                For i = 0 To cmbArro.Items.Count - 1
                    If lst_count(j - 2) <> 0 Then
                        xlWorkSheet.Cells(k, 1) = cmbArro.Items(i)
                        xlWorkSheet.Cells(k, 2) = lst_count(j - 2)
                        k += 1
                    End If
                    j += 1
                Next
                chartRange = xlWorkSheet.Range($"A1", $"B{k - 1}")
                chartPage.SetSourceData(Source:=chartRange, Excel.XlRowCol.xlColumns)
                chartPage.ChartType = Excel.XlChartType.xl3DPie
                chartPage.SetElement(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelOutSideEnd)
                chartPage.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowLabel)
                chartPage.Elevation = 45
        End Select
    End Sub
    Private Function prods_to_dict(int_fr As String, int_nl As String, start_year As Integer, end_year As Integer) As Dictionary(Of String, Integer)
        Dim i As Integer
        Dim StatsDV As New DataView(memberToDs(DORADbDS).Tables("INTS"))
        DateFrom = Convert.ToDateTime("01/01/" & start_year)
        DateTo = Convert.ToDateTime("31/12/" & end_year)
        StatsDV.RowFilter = $"[DATEINT] >= #{DateFrom:MM/dd/yyyy}# AND [DATEINT] <= #{DateTo:MM/dd/yyyy}# AND ([DRUG] IS NOT NULL) AND ([TYPEOFINT] LIKE '*{int_fr}*' OR [TYPEOFINT] LIKE '*{int_nl}*')"
        Dim lst_ints As New List(Of String)
        Dim lst_drug As New List(Of String)
        'Create 2 parallel lists for IDINT and DRUG
        For Each rowView As DataRowView In StatsDV
            Dim row As DataRow = rowView.Row
            lst_ints.Add(CStr(row.Item("IDINT")))
            lst_drug.Add(CStr(row.Item("DRUG")))
        Next
        'Remove duplicates
        Dim sResult As String = ""
        Dim temp_list As New List(Of Tuple(Of Integer, String))
        For i = lst_ints.Count - 1 To 0 Step -1
            Dim temp_tuple As Tuple(Of Integer, String) = New Tuple(Of Integer, String)(CInt(lst_ints(i)), lst_drug(i))
            If temp_list.Contains(temp_tuple) Then
                lst_ints.RemoveAt(i)
                lst_drug.RemoveAt(i)
            Else
                temp_list.Add(temp_tuple)
            End If
        Next
        'Group drugs by int
        For i = lst_ints.Count - 1 To 0 Step -1
            While i >= 1 AndAlso lst_ints(i) = lst_ints(i - 1)
                lst_drug(i - 1) &= $" {lst_drug(i)}"
                lst_ints.RemoveAt(i)
                lst_drug.RemoveAt(i)
                i -= 1
            End While
        Next
        'Replace texts and sort drugs
        For i = lst_drug.Count - 1 To 0 Step -1
            Dim s As String = lst_drug(i)
            s = s.Replace("Amfetamine", "AMPH")
            s = s.Replace("Amphétamine", "AMPH")
            s = s.Replace("Metamfetamine", "METH")
            s = s.Replace("Methamphétamine", "METH")
            s = s.Replace("(Pre)-Precursors", "PRE")
            s = s.Replace("(Pré)-Précurseurs", "PRE")
            s = s.Replace("Ketamine", "KET")
            s = s.Replace("Kétamine", "KET")
            s = s.Replace("Heroïne", "HERO")
            s = s.Replace("Héroïne", "HERO")
            s = s.Replace("Cocaïne", "COKE")
            Dim temp As List(Of String) = s.Split(CChar(" ")).ToList
            temp.Sort()
            Dim str As String = temp(0)
            For k As Integer = 1 To temp.Count - 1
                str += $" {temp(k)}"
            Next
            lst_drug(i) = str
        Next
        'Count numbers of occurences
        Dim dict_drug As New Dictionary(Of String, Integer)
        Dim grouped_drugs = lst_drug.GroupBy(Function(x) x)
        If grouped_drugs IsNot Nothing AndAlso grouped_drugs.Count > 0 Then
            For Each drug In grouped_drugs
                dict_drug.Add(drug.Key, drug.Count)
            Next
        End If
        Return dict_drug
    End Function
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
            btnChart.Text = "Grafische"
            hours = "uren"
        Else
            btnChart.Text = "Graphique"
            hours = "heures"
        End If
    End Sub
    Private Sub FillCombo()
        'Fill comboboxes
        If Lang = 1 Then
            cmbDrug.Items.Add("MDMA")
            cmbDrug.Items.Add("Amfetamine")
            cmbDrug.Items.Add("Metamfetamine")
            cmbDrug.Items.Add("(Pre)-Precursors")
            cmbDrug.Items.Add("Cocaïne")
            cmbDrug.Items.Add("Heroïne")
            cmbDrug.Items.Add("NPS")
            cmbDrug.Items.Add("Ketamine")
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
            cmbChart.Items.Add("Interventies per jaar")
            cmbChart.Items.Add("Interventies per jaar voor een soort productie")
            cmbChart.Items.Add("Interventies per jaar voor een gerechtelijk arrondissement")
            cmbChart.Items.Add("Interventies per gerechtelijk arrondissement")
            cmbChart.Items.Add("Verdeling van de productielocaties naar productietype")
            cmbChart.Items.Add("Verdeling van de dumpings naar productietype")
            cmbChart.Items.Add("Verdeling van de opslagplaats naar productietype")
            cmbChart.Items.Add("Verdeling van de productielocaties naar gerechtelijk arrondissement")
            cmbChart.Items.Add("Verdeling van de dumpings naar gerechtelijk arrondissement")
            cmbChart.Items.Add("Verdeling van de opslagplaats naar gerechtelijk arrondissement")
        Else
            cmbDrug.Items.Add("MDMA")
            cmbDrug.Items.Add("Amphétamine")
            cmbDrug.Items.Add("Methamphétamine")
            cmbDrug.Items.Add("(Pré)-Précurseurs")
            cmbDrug.Items.Add("Cocaïne")
            cmbDrug.Items.Add("Héroïne")
            cmbDrug.Items.Add("NPS")
            cmbDrug.Items.Add("Kétamine")
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
            cmbChart.Items.Add("Interventions par années")
            cmbChart.Items.Add("Interventions par années pour un type de production")
            cmbChart.Items.Add("Interventions par années pour un arrondissement judiciaire")
            cmbChart.Items.Add("Interventions par arrondissements judiciaires")
            cmbChart.Items.Add("Répartition des sites de production par type de production")
            cmbChart.Items.Add("Répartition des dumpings par type de production")
            cmbChart.Items.Add("Répartition des stockages par type de production")
            cmbChart.Items.Add("Répartition des sites de production par arrondissements judiciaires")
            cmbChart.Items.Add("Répartition des dumpings par arrondissements judiciaires")
            cmbChart.Items.Add("Répartition des stockages par arrondissements judiciaires")
        End If
        'Fill years comboboxes from 2014 to current year
        For i As Integer = Year(Now) To 2014 Step -1
            cmbFrom.Items.Add(i)
        Next
        cmbFrom.SelectedIndex = 0
        cmbTo.Text = CStr(Year(Now))
        cmbFrom.SelectedIndex = 1
    End Sub
    Private Sub InitializeComboboxes()
        cmbDrug.SelectedIndex = 0
        cmbArro.SelectedIndex = 0
        cmbChart.SelectedIndex = 0
        cmbDrug.Enabled = False
        cmbArro.Enabled = False
    End Sub
    Private Sub cmbChart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChart.SelectionChangeCommitted
        Select Case cmbChart.SelectedIndex
            Case 1
                cmbDrug.Enabled = True
                cmbArro.Enabled = False
            Case 2
                cmbDrug.Enabled = False
                cmbArro.Enabled = True
            Case Else
                cmbDrug.Enabled = False
                cmbArro.Enabled = False
        End Select
    End Sub
    Private Sub cmbFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFrom.SelectedIndexChanged
        'Fill comboboxes depending on user's choice
        cmbTo.Items.Clear()
        For i As Integer = Year(Now) To CInt(cmbFrom.Text) Step -1
            cmbTo.Items.Add(i)
        Next
        cmbTo.SelectedIndex = 0
        'Update stats
        LoadStats()
    End Sub
    Private Sub cmbTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTo.SelectedIndexChanged
        'Update Stats
        LoadStats()
    End Sub
    Private Sub cmbNoInput(sender As Object, e As KeyPressEventArgs) Handles cmbChart.KeyPress, cmbDrug.KeyPress, cmbArro.KeyPress, cmbFrom.KeyPress, cmbTo.KeyPress
        'Disable user input
        e.Handled = True
    End Sub
    Private Sub SetColors()
        'Set colors of controls according to choosen theme
        Dim lst_controls As New List(Of Control)
        For Each c As Label In FindControlRecursive(lst_controls, Me, GetType(Label))
            c.BackColor = theme("Medium")
            c.ForeColor = theme("Font")
        Next
        lst_controls = New List(Of Control)
        For Each c As Panel In FindControlRecursive(lst_controls, Me, GetType(Panel))
            c.BackColor = theme("Medium")
            c.ForeColor = theme("Font")
        Next
        btnChart.IconColor = theme("Font")
        btnChart.ForeColor = theme("Font")
        For Each p As Control In Controls
            If TypeOf (p) Is Panel Then
                AddBorderToPanel(Me, p, theme("High"))
            End If
        Next
        btnChart.BackColor = theme("Light")
        AddBorderToPanel(pnlChart, btnChart, theme("High"))
    End Sub
#End Region

End Class