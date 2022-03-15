Option Explicit On
'Option Strict On
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.ComponentModel
Imports Word = Microsoft.Office.Interop.Word
Imports System.Reflection
Imports System.Data.OleDb
Imports FontAwesome.Sharp
Public Class frmInventory
    Dim INV As String = $"INV{InvYear}"
    Dim connection As New OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dora_path}DORAInv.accdb")
    Dim INVENTORYDataTable As New DataTable
    Dim INVENTORYBindingSource As New BindingSource
    Dim WithEvents INVENTORYTableAdapter As New OleDbDataAdapter($"SELECT ID, IDINT, ORDER, NUM, DESC, SAMPLES, SAMPLEST FROM {INV} WHERE IDINT = {IntNum}", connection)
    Dim picsF As String = $"{PathInt}\FOTODOSSIER\FOTO'S\"
    Dim highF As String = $"{PathInt}\FOTODOSSIER\FOTO'S\HIGH\"
    Dim lowF As String = $"{PathInt}\FOTODOSSIER\FOTO'S\LOW\"
    Dim Prefix As String
    Dim Num As String = String.Empty
    Public Del As Boolean = False
    Dim inv_count As Integer = 0
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = My.Settings.frmInventory_loc
        EnableDoubleBuffered(dgvInventory, True)
        Reorder(0)
        ControlBox = False
        Timer1.Start()
        SetColors()
        Try
            'Check if the table for this year exists, if not create it
            connection.Open()
            Dim dbSchema As DataTable = connection.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, INV, "TABLE"})
            If dbSchema.Rows.Count = 0 Then
                Dim cmd As New OleDbCommand($"CREATE TABLE [{INV}] ([ID] COUNTER, [IDINT] INTEGER, [ORDER] INTEGER, [NUM] TEXT(50), [DESC] MEMO, [SAMPLES] TEXT(50), [SAMPLEST] TEXT(50))", connection)
                cmd.ExecuteNonQuery()
            End If
            connection.Close()
            SEIZURETableAdapter.Fill(DORADbDS.SEIZURE)
            ConfigureDataAdapter()
            LoadData()
            INVENTORYBindingSource.Filter = $"[IDINT] = {IntNum}"
            INVENTORYBindingSource.Sort = "[ORDER] ASC"
            INVENTORYBindingSource.MoveFirst()
            SetupInventory()
            lblTitle.Text = $"Dossier {CaseName}"
            Trad()
            FillCombo()
            txtNum.DataBindings.Add("Text", INVENTORYBindingSource, "NUM")
            txtDesc.DataBindings.Add("Text", INVENTORYBindingSource, "DESC")
            txtSamples.DataBindings.Add("Text", INVENTORYBindingSource, "SAMPLES")
            cmbSamplesT.DataBindings.Add("Text", INVENTORYBindingSource, "SAMPLEST")
            txtNumR.DataBindings.Add("Text", INVENTORYBindingSource, "NUM")
            txtDescR.DataBindings.Add("Text", INVENTORYBindingSource, "DESC")
            ShowRoomInput()
            LoadPics()
            LoadPicsO()
            ShowPics()
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
#Region "Data"
    Private Sub ConfigureDataAdapter()
        'Create insert command
        Dim insert As New OleDbCommand($"INSERT INTO {INV} ([IDINT], [ORDER], [NUM], [DESC], [SAMPLES], [SAMPLEST]) VALUES (@IDINT, @ORDER, @NUM, @DESC, @SAMPLES, @SAMPLEST)", connection)
        With insert.Parameters
            .Add("@IDINT", OleDbType.Integer, 4, "IDINT")
            .Add("@ORDER", OleDbType.Integer, 4, "ORDER")
            .Add("@NUM", OleDbType.VarChar, 50, "NUM")
            .Add("@DESC", OleDbType.LongVarChar, 5000, "DESC")
            .Add("@SAMPLES", OleDbType.VarChar, 50, "SAMPLES")
            .Add("@SAMPLEST", OleDbType.VarChar, 50, "SAMPLEST")
        End With
        'Create update command
        Dim update As New OleDbCommand($"UPDATE {INV} SET [IDINT] = @IDINT, [ORDER] = @ORDER, [NUM] = @NUM, [DESC] = @DESC, [SAMPLES] = @SAMPLES, [SAMPLEST] = @SAMPLEST WHERE ID = @ID", connection)
        With update.Parameters
            .Add("@IDINT", OleDbType.Integer, 4, "IDINT")
            .Add("@ORDER", OleDbType.Integer, 4, "ORDER")
            .Add("@NUM", OleDbType.VarChar, 50, "NUM")
            .Add("@DESC", OleDbType.LongVarChar, 5000, "DESC")
            .Add("@SAMPLES", OleDbType.VarChar, 50, "SAMPLES")
            .Add("@SAMPLEST", OleDbType.VarChar, 50, "SAMPLEST")
            .Add("@ID", OleDbType.Integer, 4, "ID")
        End With
        'Create delete command
        Dim delete As New OleDbCommand($"DELETE FROM {INV} WHERE ID = @ID", connection)
        delete.Parameters.Add("@ID", OleDbType.Integer, 4, "ID")
        With INVENTORYTableAdapter
            .MissingSchemaAction = MissingSchemaAction.AddWithKey
            .InsertCommand = insert
            .UpdateCommand = update
            .DeleteCommand = delete
        End With
    End Sub
    Private Sub LoadData()
        INVENTORYTableAdapter.Fill(INVENTORYDataTable)
        INVENTORYBindingSource.DataSource = INVENTORYDataTable
        dgvInventory.DataSource = INVENTORYBindingSource
    End Sub
    Private Sub INVENTORYTableAdapter_RowUpdated(sender As Object, e As OleDbRowUpdatedEventArgs) Handles INVENTORYTableAdapter.RowUpdated
        If e.StatementType = StatementType.Insert Then
            Using command As New OleDbCommand("SELECT @@IDENTITY", connection)
                e.Row("ID") = CInt(command.ExecuteScalar())
            End Using
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        'Save
        Dim index = dgvInventory.FirstDisplayedScrollingRowIndex
        Try
            INVENTORYBindingSource.EndEdit()
            INVENTORYTableAdapter.Update(INVENTORYDataTable)
            log("INV.", "click on SAVE")
        Catch ex As Exception
            If Lang = 1 Then
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
        If dgvInventory.Rows.Count > 0 Then dgvInventory.FirstDisplayedScrollingRowIndex = index
    End Sub
    Private Sub BtnPicsLow_Click(sender As Object, e As EventArgs) Handles btnPicsLow.Click
        'Create or open LOW folder
        If Directory.Exists(lowF) Then
            Process.Start(lowF)
        Else
            frmProgBar.Show()
            bgw.RunWorkerAsync()
        End If
    End Sub
    Private Sub btnInventoryGen_Click(sender As Object, e As EventArgs) Handles btnInventoryGen.Click
        INVENTORYBindingSource.MoveLast()
        If CStr(DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(3)) = String.Empty Then
            INVENTORYBindingSource.RemoveCurrent()
        End If
        'Generate Inventory Word file
        Cursor = Cursors.WaitCursor
        Dim oWord As Word.Application = CType(CreateObject("Word.Application"), Word.Application)
        Dim oDoc As Word.Document
        Dim Title As Boolean = False
        'Open template depending on intervention language
        If IntLang = "Nederlands" Then
            oDoc = oWord.Documents.Add($"{dora_path}InventarisNL.dotm")
        Else
            oDoc = oWord.Documents.Add($"{dora_path}InventaireFR.dotm")
        End If
        Try
            Dim oTable As Word.Table
            Dim oPara As Word.Paragraph
            Dim oHeader As Word.Range
            oWord.Visible = False
            'Fill in headers
            For Each section As Word.Section In oDoc.Sections
                oHeader = section.Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range
                oHeader.Fields.Add(oHeader, Word.WdFieldType.wdFieldPage)
                If IntLang = "Nederlands" Then
                    oHeader.Text = $"Bijlage 1 aan proces-verbaal nr. {frmIntervention.txtCRUReportNum.Text} dd {frmIntervention.txtCRUReportDate.Text} van DJSOC/C.R.U."
                Else
                    oHeader.Text = $"Annexe 1 au procès-verbal nr. {frmIntervention.txtCRUReportNum.Text} dd {frmIntervention.txtCRUReportDate.Text} de DJSOC/C.R.U."
                End If
                oHeader.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            Next
            oWord.ActiveDocument.Tables(1).Cell(1, 2).Range.Text = ReportNum
            'Fill in the type of intervention
            Select Case frmIntervention.cmbTypeOfInt.SelectedIndex
                Case 0, 1, 2, 3, 4
                    oWord.ActiveDocument.Tables(2).Cell(2, 1).Range.Text = "Labo"
                Case 5
                    oWord.ActiveDocument.Tables(2).Cell(2, 1).Range.Text = "Dumping"
                Case 6
                    If IntLang = "Nederlands" Then
                        oWord.ActiveDocument.Tables(2).Cell(2, 1).Range.Text = "Opslagplaats"
                    Else
                        oWord.ActiveDocument.Tables(2).Cell(2, 1).Range.Text = "Stockage"
                    End If
            End Select
            'Fill in date, adress and city of intervention / facts
            If frmIntervention.cmbInt.Text <> "Ter plaatse" AndAlso frmIntervention.cmbInt.Text <> "Sur place" Then
                oDoc.Tables(2).Cell(2, 2).Range.Text = frmIntervention.txtDateFacts.Text
            Else
                oDoc.Tables(2).Cell(2, 2).Range.Text = frmIntervention.txtDateInt.Text
            End If
            oDoc.Tables(2).Cell(3, 2).Range.Text = frmIntervention.txtDateInt.Text
            oDoc.Tables(2).Cell(4, 2).Range.Text = frmIntervention.txtDateInt.Text
            If frmIntervention.cmbInt.Text <> "Ter plaatse" AndAlso frmIntervention.cmbInt.Text <> "Sur place" Then
                oDoc.Tables(2).Cell(2, 3).Range.Text = $"{frmIntervention.txtZipFacts.Text} {frmIntervention.cmbCityFacts.Text}, {frmIntervention.txtAdressFacts.Text}"
            Else
                oDoc.Tables(2).Cell(2, 3).Range.Text = $"{frmIntervention.txtZipInt.Text} {frmIntervention.cmbCityInt.Text}, {frmIntervention.txtAdressInt.Text}"
            End If
            oDoc.Tables(2).Cell(3, 3).Range.Text = $"{frmIntervention.txtZipInt.Text} {frmIntervention.cmbCityInt.Text}, {frmIntervention.txtAdressInt.Text}"
            oDoc.Tables(2).Cell(4, 3).Range.Text = $"{frmIntervention.txtZipInt.Text} {frmIntervention.cmbCityInt.Text}, {frmIntervention.txtAdressInt.Text}"
            'Cycle through the inventory datagridview
            For i As Integer = 0 To dgvInventory.Rows.Count - 1
                'Add Room title
                If dgvInventory.Rows(i).Cells(3).Value.ToString.ToUpper.Contains("RUIMTE") OrElse dgvInventory.Rows(i).Cells(3).Value.ToString.ToUpper.Contains("ZONE") Then
                    Title = True
                    oPara = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                    oPara.Range.Font.Bold = 1
                    oPara.Range.Font.Size = 16
                    If i > 0 Then oPara.Range.InsertParagraphBefore()
                    If IsDBNull(dgvInventory.Rows(i).Cells(4).Value) OrElse CStr(dgvInventory.Rows(i).Cells(4).Value) = String.Empty Then
                        oPara.Range.Text = CStr(dgvInventory.Rows(i).Cells(3).Value)
                    Else
                        oPara.Range.Text = $"{dgvInventory.Rows(i).Cells(3).Value}: {dgvInventory.Rows(i).Cells(4).Value}"
                    End If
                    oPara.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    oPara.Range.InsertParagraphAfter()
                    oPara.Range.Text = vbCrLf
                    'Add headers
                    oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 1, 3)
                    oTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
                    oTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
                    oTable.Rows.Alignment = Word.WdRowAlignment.wdAlignRowCenter
                    oTable.Cell(i + 1, 1).SetWidth(60, RulerStyle:=Word.WdRulerStyle.wdAdjustNone)
                    oTable.Cell(i + 1, 2).SetWidth(310, RulerStyle:=Word.WdRulerStyle.wdAdjustNone)
                    oTable.Cell(i + 1, 3).SetWidth(80, RulerStyle:=Word.WdRulerStyle.wdAdjustNone)
                    If IntLang = "Nederlands" Then
                        oTable.Cell(i + 1, 1).Range.Text = "NUMMER"
                        oTable.Cell(i + 1, 2).Range.Text = "BESCHRIJVING"
                        oTable.Cell(i + 1, 3).Range.Text = "STAALNAME"
                    Else
                        oTable.Cell(i + 1, 1).Range.Text = "NUMÉRO"
                        oTable.Cell(i + 1, 2).Range.Text = "DESCRIPTION"
                        oTable.Cell(i + 1, 3).Range.Text = "ÉCHANTILLONS"
                    End If
                    oTable.Range.Font.Bold = 1
                    oTable.Cell(i + 1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                    oTable.Cell(i + 1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                    oTable.Cell(i + 1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                ElseIf i = 0 Then
                    'Add headers
                    oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 1, 3)
                    oTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
                    oTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
                    oTable.Rows.Alignment = Word.WdRowAlignment.wdAlignRowCenter
                    oTable.Cell(i + 1, 1).SetWidth(60, RulerStyle:=Word.WdRulerStyle.wdAdjustNone)
                    oTable.Cell(i + 1, 2).SetWidth(310, RulerStyle:=Word.WdRulerStyle.wdAdjustNone)
                    oTable.Cell(i + 1, 3).SetWidth(80, RulerStyle:=Word.WdRulerStyle.wdAdjustNone)
                    If IntLang = "Nederlands" Then
                        oTable.Cell(i + 1, 1).Range.Text = "NUMMER"
                        oTable.Cell(i + 1, 2).Range.Text = "BESCHRIJVING"
                        oTable.Cell(i + 1, 3).Range.Text = "STAALNAME"
                    Else
                        oTable.Cell(i + 1, 1).Range.Text = "NUMÉRO"
                        oTable.Cell(i + 1, 2).Range.Text = "DESCRIPTION"
                        oTable.Cell(i + 1, 3).Range.Text = "ÉCHANTILLONS"
                    End If
                    oTable.Range.Font.Bold = 1
                    oTable.Cell(i + 1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                    oTable.Cell(i + 1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                    oTable.Cell(i + 1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                End If
                'Add object
                If Title = False Then
                    oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 1, 3)
                    oTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
                    oTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
                    oTable.Rows.Alignment = Word.WdRowAlignment.wdAlignRowCenter
                    oTable.Cell(i + 2, 1).SetWidth(60, RulerStyle:=Word.WdRulerStyle.wdAdjustNone)
                    oTable.Cell(i + 2, 2).SetWidth(310, RulerStyle:=Word.WdRulerStyle.wdAdjustNone)
                    oTable.Cell(i + 2, 3).SetWidth(80, RulerStyle:=Word.WdRulerStyle.wdAdjustNone)
                    oTable.Cell(i + 2, 1).Range.Text = CStr(dgvInventory.Rows(i).Cells(3).Value)
                    oTable.Cell(i + 2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                    oTable.Cell(i + 2, 2).Range.Text = CStr(dgvInventory.Rows(i).Cells(4).Value)
                    oTable.Cell(i + 2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    If IsDBNull(dgvInventory.Rows(i).Cells(5).Value) Then
                        oTable.Cell(i + 2, 3).Range.Text = String.Empty
                    Else
                        oTable.Cell(i + 2, 3).Range.Text = CStr(dgvInventory.Rows(i).Cells(5).Value)
                    End If
                    oTable.Cell(i + 2, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                End If
                Title = False
            Next
            For Each oCtl In oDoc.Shapes
                If oCtl.ID = 3 Then
                    oCtl.TextFrame.TextRange.Text = $"Dossier {CaseName}"
                End If
            Next
            'Save document then open it
            If IntLang = "Nederlands" Then
                Dim FinalDoc As String = $"{PathInt}\INVENTARIS\Inventaris.docx"
                oDoc.SaveAs2(CStr(FinalDoc), Word.WdSaveFormat.wdFormatDocumentDefault)
                oDoc.Close()
                Process.Start(FinalDoc)
                Cursor = Cursors.Default
            Else
                Dim FinalDoc As String = $"{PathInt}\INVENTARIS\Inventaire.docx"
                oDoc.SaveAs2(CStr(FinalDoc), Word.WdSaveFormat.wdFormatDocumentDefault)
                oDoc.Close()
                Process.Start(FinalDoc)
                Cursor = Cursors.Default
            End If
            log("INV.", "inventory generated")
        Catch RICex As Runtime.InteropServices.COMException
            If Lang = 1 Then
                MessageBox.Show("Onmogelijk om deze inventaris te wijzigingen", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Impossible d'enregistrer cet inventaire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'Ask user where to save the document then open it
            Using SFD As New SaveFileDialog
                Dim FinalDoc As String
                SFD.InitialDirectory = $"{files_path}"
                SFD.Title = "Save As..."
                If IntLang = "Nederlands" Then
                    SFD.FileName = "Inventaris"
                Else
                    SFD.FileName = "Inventaire"
                End If
                SFD.DefaultExt = ".docx"
                SFD.AddExtension = True
                If SFD.ShowDialog() = DialogResult.OK Then
                    FinalDoc = SFD.FileName
                    oDoc.SaveAs2(CStr(FinalDoc), Word.WdSaveFormat.wdFormatDocumentDefault)
                    oDoc.Close()
                    Process.Start(FinalDoc)
                End If
            End Using
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
    Private Sub btnPicturesGen_Click(sender As Object, e As EventArgs) Handles btnPicturesGen.Click
        INVENTORYBindingSource.MoveLast()
        If CStr(DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(3)) = String.Empty Then
            INVENTORYBindingSource.RemoveCurrent()
        End If
        'Generate Pictures Word file
        Cursor = Cursors.WaitCursor
        Dim oWord As Word.Application = CType(CreateObject("Word.Application"), Word.Application)
        Dim oDoc As Word.Document
        'Open template depending on intervention language
        If IntLang = "Nederlands" Then
            oDoc = oWord.Documents.Add($"{dora_path}FotodossierNL.dotm")
        Else
            oDoc = oWord.Documents.Add($"{dora_path}DossierphotosFR.dotm")
        End If
        Try
            Dim oRng As Word.Range
            Dim oTable As Word.Table
            Dim oPara As Word.Paragraph
            Dim oImage As Word.InlineShape
            Dim oHeader As Word.Range
            oWord.Visible = False
            'Fill in headers
            For Each section As Word.Section In oDoc.Sections
                oHeader = section.Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range
                oHeader.Fields.Add(oHeader, Word.WdFieldType.wdFieldPage)
                If IntLang = "Nederlands" Then
                    oHeader.Text = $"Bijlage 2 aan proces-verbaal nr. {frmIntervention.txtCRUReportNum.Text} dd {frmIntervention.txtCRUReportDate.Text} van DJSOC/C.R.U."
                Else
                    oHeader.Text = $"Annexe 2 au procès-verbal nr. {frmIntervention.txtCRUReportNum.Text} dd {frmIntervention.txtCRUReportDate.Text} de DJSOC/C.R.U."
                End If
                oHeader.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            Next
            'Cycle overzicht images in intervention folder
            oRng = oDoc.Content.Bookmarks.Item("overzicht").Range
            Prefix = "Overzicht"
            For Each imagefile As String In Directory.GetFiles(picsF)
                If imagefile.Contains(Prefix) Then
                    oImage = oRng.InlineShapes.AddPicture(imagefile)
                    oImage.Borders.Enable = 1
                    oImage.Borders.OutsideLineWidth = Word.WdLineWidth.wdLineWidth150pt
                    If oImage.Height < oImage.Width Then
                        'Landscape
                        oImage.ScaleHeight = 45
                        oImage.ScaleWidth = 45
                    Else
                        'Portrait
                        oImage.ScaleHeight = 33
                        oImage.ScaleWidth = 33
                    End If
                    oRng = oImage.Range
                    oRng.InsertAfter(vbCr)
                    oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
                End If
            Next
            For i As Integer = 0 To dgvInventory.Rows.Count - 1
                'Add Room title
                If dgvInventory.Rows(i).Cells(3).Value.ToString.ToUpper.Contains("RUIMTE") OrElse dgvInventory.Rows(i).Cells(3).Value.ToString.ToUpper.Contains("ZONE") Then
                    If i > 0 Then
                        oRng = oDoc.Bookmarks.Item("\endofdoc").Range
                        oRng.InsertBreak()
                    End If
                    oPara = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                    oPara.Style = Word.WdBuiltinStyle.wdStyleHeading2
                    oPara.Range.Font.Bold = 1
                    oPara.Range.Font.Size = 16
                    If IsDBNull(dgvInventory.Rows(i).Cells(4).Value) OrElse dgvInventory.Rows(i).Cells(4).ToString = String.Empty Then
                        oPara.Range.Text = $"{dgvInventory.Rows(i).Cells(3).Value}{Environment.NewLine}"
                    Else
                        oPara.Range.Text = $"{dgvInventory.Rows(i).Cells(3).Value}: {dgvInventory.Rows(i).Cells(4).Value}{Environment.NewLine}"
                    End If
                    oPara = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                    'Cycle current room images in intervention folder
                    Prefix = CStr(dgvInventory.Rows(i).Cells(3).Value)
                    Dim count As Integer = 1
                    For Each imagefile As String In Directory.GetFiles(picsF)
                        If imagefile.Contains(Prefix) Then
                            oPara = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                            If count > 1 Then oPara = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                            oImage = oPara.Range.InlineShapes.AddPicture(imagefile)
                            oImage.Borders.Enable = 1
                            oImage.Borders.OutsideLineWidth = Word.WdLineWidth.wdLineWidth150pt
                            If oImage.Height < oImage.Width Then
                                'Landscape
                                oImage.ScaleHeight = 45
                                oImage.ScaleWidth = 45
                            Else
                                'Portrait
                                oImage.ScaleHeight = 33
                                oImage.ScaleWidth = 33
                            End If
                            count = count + 1
                        End If
                    Next
                Else
                    'Add object
                    oRng = oDoc.Bookmarks.Item("\endofdoc").Range
                    oRng.InsertBreak()
                    oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 1, 2)
                    oTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
                    oTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
                    oTable.Rows.Alignment = Word.WdRowAlignment.wdAlignRowCenter
                    oTable.Cell(i + 1, 1).SetWidth(60, RulerStyle:=Word.WdRulerStyle.wdAdjustNone)
                    oTable.Cell(i + 1, 2).SetWidth(390, RulerStyle:=Word.WdRulerStyle.wdAdjustNone)
                    oTable.Cell(i + 1, 1).Range.Text = CStr(dgvInventory.Rows(i).Cells(3).Value)
                    oTable.Cell(i + 1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                    oTable.Cell(i + 1, 2).Range.Text = CStr(dgvInventory.Rows(i).Cells(4).Value)
                    oTable.Cell(i + 1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    oPara = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                    'Cycle current object images in intervention folder
                    Prefix = InventoryNum3Digits(CStr(dgvInventory.Rows(i).Cells(3).Value))
                    Dim count As Integer = 1
                    For Each imagefile As String In Directory.GetFiles(picsF)
                        If imagefile.Contains(Prefix) Then
                            oPara = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                            If count > 1 Then oPara = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
                            oImage = oPara.Range.InlineShapes.AddPicture(imagefile)
                            oImage.Borders.Enable = 1
                            oImage.Borders.OutsideLineWidth = Word.WdLineWidth.wdLineWidth150pt
                            If oImage.Height < oImage.Width Then
                                'Landscape
                                oImage.ScaleHeight = 45
                                oImage.ScaleWidth = 45
                            Else
                                'Portrait
                                oImage.ScaleHeight = 33
                                oImage.ScaleWidth = 33
                            End If
                            count = count + 1
                        End If
                    Next
                End If
            Next
            oPara = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
            oPara.Range.Font.Bold = 1
            oPara.Range.Font.Size = 16
            oPara.Range.Text = $"{Environment.NewLine}******************************"
            oDoc.TablesOfContents(1).Update()
            For Each oCtl In oDoc.Shapes
                If oCtl.ID = 3 Then
                    oCtl.TextFrame.TextRange.Text = $"Dossier {CaseName}"
                End If
            Next
            'Save document then open it
            If IntLang = "Nederlands" Then
                Dim FinalDoc As String = $"{PathInt}\FOTODOSSIER\Fotodossier.docx"
                oDoc.SaveAs2(CStr(FinalDoc), Word.WdSaveFormat.wdFormatDocumentDefault)
                oDoc.Close()
                Process.Start(FinalDoc)
                Cursor = Cursors.Default
            Else
                Dim FinalDoc As String = $"{PathInt}\FOTODOSSIER\Dossier photos.docx"
                oDoc.SaveAs2(CStr(FinalDoc), Word.WdSaveFormat.wdFormatDocumentDefault)
                oDoc.Close()
                Process.Start(FinalDoc)
                Cursor = Cursors.Default
            End If
            log("INV.", "pictures file generated")
        Catch RICex As Runtime.InteropServices.COMException
            If Lang = 1 Then
                MessageBox.Show("Onmogelijk om deze fotodossier te wijzigingen", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Impossible d'enregistrer ce dossier photos", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'Ask user where to save the document then open it
            Using SFD As New SaveFileDialog
                Dim FinalDoc As String
                SFD.InitialDirectory = $"{files_path}"
                SFD.Title = "Save As..."
                If IntLang = "Nederlands" Then
                    SFD.FileName = "Fotodossier"
                Else
                    SFD.FileName = "Dossier photos"
                End If
                SFD.DefaultExt = ".docx"
                SFD.AddExtension = True
                If SFD.ShowDialog() = DialogResult.OK Then
                    FinalDoc = SFD.FileName
                    oDoc.SaveAs2(CStr(FinalDoc), Word.WdSaveFormat.wdFormatDocumentDefault)
                    oDoc.Close()
                    Process.Start(FinalDoc)
                End If
            End Using
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
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnExit.Click
        My.Settings.frmInventory_loc = Location
        'Delete inv dat file
        If File.Exists($"{dora_path}SYSTEM\INV,,{IntNum},,{user}.dat") Then
            File.Delete($"{dora_path}SYSTEM\INV,,{IntNum},,{user}.dat")
        End If
        log("INV.", "click on CANCEL")
        Close()
    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        'Minimize window
        WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Input"
    Private Sub GetNum(sender As Object, e As EventArgs) Handles txtNum.Enter, txtNumR.Enter
        'Get original number, before possible modification
        If Not IsDBNull(DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(3)) Then
            Num = CStr(DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(3))
        End If
    End Sub
    Private Sub txtNum_Leave(sender As Object, e As EventArgs) Handles txtNum.Validating
        'Rename picture if the number has been changed
        Try
            If Num <> String.Empty Then
                If txtNum.Modified Then
                    Num = InventoryNum3Digits(Num)
                    Dim Prefix As String = txtNum.Text
                    Prefix = InventoryNum3Digits(Prefix)
                    For Each imagefile As String In Directory.GetFiles(picsF)
                        If imagefile.Contains(Num) Then
                            Dim NewNum As String = imagefile.Replace(Num, Prefix)
                            NewNum = Path.GetFileName(NewNum)
                            My.Computer.FileSystem.RenameFile(imagefile, NewNum)
                        End If
                    Next
                End If
            End If
            If dgvInventory.Rows.Count > 0 Then dgvInventory.SelectedRows(0).Cells(3).Value = txtNum.Text.TrimEnd(CChar(" "))
        Catch exDNF As DirectoryNotFoundException
            Return
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
    Private Sub txtNumR_Leave(sender As Object, e As EventArgs) Handles txtNumR.Validating
        'Validate NumR field
        Try
            'Check if room has been named
            If txtNumR.Text.Replace(" ", "") = "RUIMTE" OrElse txtNumR.Text.Replace(" ", "") = "ZONE" Then
                If Lang = 1 Then
                    MessageBox.Show("Geef de ruimte een naam a.u.b", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Veuillez nommer la zone s.v.p", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                txtNumR.Focus()
                txtNumR.SelectionLength = txtNumR.TextLength
                Exit Sub
            End If
            'Rename picture if the area name has been changed
            If txtNumR.Modified AndAlso Not IsDBNull(Num) AndAlso Num <> String.Empty Then
                For Each imagefile As String In Directory.GetFiles(picsF)
                    If imagefile.Contains(Num) Then
                        Dim NewNum As String = imagefile.Replace(Num, txtNumR.Text)
                        NewNum = Path.GetFileName(NewNum)
                        My.Computer.FileSystem.RenameFile(imagefile, NewNum)
                    End If
                Next
            End If
            If dgvInventory.Rows.Count > 0 Then dgvInventory.SelectedRows(0).Cells(3).Value = txtNumR.Text.TrimEnd(CChar(" "))
        Catch exDNF As DirectoryNotFoundException
            Return
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
    Private Sub txtDescR_Leave(sender As Object, e As EventArgs) Handles txtDescR.Leave
        If Not File.Exists($"{PathInt}\INVENTARIS\inv.txt") Then
            File.Create($"{PathInt}\INVENTARIS\inv.txt").Dispose()
        End If
        Using sw As StreamWriter = File.AppendText($"{PathInt}\INVENTARIS\inv.txt")
            sw.WriteLine($"{Now.ToString("dd/MM/yyyy HH:mm:ss")}{vbTab}{txtNum.Text}{vbTab}{vbTab}{txtDesc.Text}{Environment.NewLine}")
        End Using
    End Sub
    Private Sub txtDesc_Leave(sender As Object, e As EventArgs) Handles txtDesc.Leave
        If Not File.Exists($"{PathInt}\INVENTARIS\inv.txt") Then
            File.Create($"{PathInt}\INVENTARIS\inv.txt").Dispose()
        End If
        Using sw As StreamWriter = File.AppendText($"{PathInt}\INVENTARIS\inv.txt")
            sw.WriteLine($"{Now.ToString("dd/MM/yyyy HH:mm:ss")}{vbTab}{txtNum.Text}{vbTab}{vbTab}{txtDesc.Text}{Environment.NewLine}")
        End Using
        inv_count += 1
        If inv_count Mod 5 = 0 Then
            btnSave_Click(sender, e)
        End If
    End Sub
    Private Sub txtSamples_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSamples.KeyPress
        'Allow only numbers in samples textbox
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 OrElse Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtSamples_Leave(sender As Object, e As EventArgs) Handles txtSamples.Leave
        If txtSamples.Text <> String.Empty OrElse Not IsDBNull(txtSamples.Text) Then
            cmbSamplesT.Text = frmIntervention.cmbSamplesTakenBy.Text
        End If
    End Sub
    Private Sub txtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum.KeyPress
        'Allow only letters, numbers, dots, spaces and backspaces
        If (Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> ControlChars.Back) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If
        'Uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub
    Private Sub txtNumR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumR.KeyPress
        'Allow only letters, numbers, spaces and backspaces
        If (Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If
        'Uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub
#End Region
#Region "Datagridview Inventory"
    Private Sub SetupInventory()
        'Setup datagridview
        dgvInventory.Columns(0).Visible = False
        dgvInventory.Columns(1).Visible = False
        dgvInventory.Columns(2).Visible = False
        dgvInventory.Columns(3).Width = 120
        dgvInventory.Columns(4).Width = 880
        dgvInventory.Columns(5).Width = 40
        dgvInventory.Columns(6).Width = 60
    End Sub
    Private Sub frmInventory_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.Add) Then
            AddObject()
        ElseIf (e.Control AndAlso e.KeyCode = Keys.Multiply) Then
            AddRoom()
        ElseIf (e.Control AndAlso e.KeyCode = Keys.R) Then
            Top = CInt((Screen.PrimaryScreen.Bounds.Height - Height) / 2)
            Left = CInt((Screen.PrimaryScreen.Bounds.Width - Width) / 2)
        End If
    End Sub
    Private Sub MoveCurrentRow(otherRowIndex As Integer)
        'Swap rows
        Dim currentRow = DirectCast(INVENTORYBindingSource.Current, DataRowView)
        Dim otherRow = DirectCast(INVENTORYBindingSource.Item(otherRowIndex), DataRowView)
        Dim temp = CInt(currentRow("ORDER"))
        INVENTORYBindingSource.SuspendBinding()
        currentRow("ORDER") = CInt(otherRow("ORDER"))
        otherRow("ORDER") = temp
        INVENTORYBindingSource.ResumeBinding()
    End Sub
    Function CheckNum(StringToCheck As String) As Boolean
        Dim letter As Boolean = False
        Dim number As Boolean = False
        For i = 0 To StringToCheck.Length - 1
            If Char.IsLetter(StringToCheck.Chars(i)) Then
                letter = True
            ElseIf Char.IsNumber(StringToCheck.Chars(i)) Then
                number = True
            End If
        Next
        If letter = True AndAlso number = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Reorder(index As Integer)
        For i As Integer = index To INVENTORYBindingSource.Count - 1
            DirectCast(INVENTORYBindingSource.List(i), DataRowView).Item(2) = i
        Next
    End Sub

    Private Sub ReorderInv()
        INVENTORYBindingSource.Position = 0
        For i As Integer = 0 To INVENTORYBindingSource.Count - 1
            DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(2) = i
            INVENTORYBindingSource.MoveNext()
        Next
        INVENTORYBindingSource.Position = 0
    End Sub
    Private Sub dgvInventory_SelectionChanged(sender As Object, e As EventArgs) Handles dgvInventory.SelectionChanged
        'Hide or show the right panel depending on the selection on the inventory datagridview
        Try
            If Del = False AndAlso dgvInventory.Rows.Count > 0 Then
                Dim i As Integer = dgvInventory.CurrentRow.Index
                If dgvInventory.Rows(i).Cells(3).Value.ToString.ToUpper.Contains("RUIMTE") OrElse dgvInventory.Rows(i).Cells(3).Value.ToString.ToUpper.Contains("ZONE") Then
                    ShowRoomInput()
                    LoadPics()
                Else
                    ShowItemInput()
                    LoadPics()
                End If
                btnUp.Enabled = True
                btnDown.Enabled = True
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
    Private Sub dgvInventory_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvInventory.RowPrePaint
        'Draw room
        If dgvInventory.Rows(e.RowIndex).Cells(3).Value.ToString.ToUpper.Contains("RUIMTE") OrElse dgvInventory.Rows(e.RowIndex).Cells(3).Value.ToString.ToUpper.Contains("ZONE") Then
            dgvInventory.Rows(e.RowIndex).DefaultCellStyle.Font = New Font("Calibri", 12, FontStyle.Bold)
        End If
    End Sub
    Private Sub dgvInventory_Click(sender As Object, e As EventArgs) Handles dgvInventory.Click
        'Disable up and down buttons if first row is selected
        If dgvInventory.SelectedRows.Count > 1 Then
            btnUp.Enabled = False
            btnDown.Enabled = False
        Else
            btnUp.Enabled = True
            btnDown.Enabled = True
        End If
    End Sub
    Private Sub btnAddRuimte_Click(sender As Object, e As EventArgs) Handles btnAddRuimte.Click
        AddRoom()
    End Sub
    Private Sub AddRoom()
        'Add a new room
        Try
            Dim index As Integer = INVENTORYBindingSource.Position
            For i As Integer = INVENTORYBindingSource.Count - 1 To index + 1 Step -1
                DirectCast(INVENTORYBindingSource.List(i), DataRowView).Item(2) = CInt(DirectCast(INVENTORYBindingSource.List(i), DataRowView).Item(2)) + 1
            Next
            'Add a new entry, incrementing ID and ORDER (both red from previous entry)
            INVENTORYBindingSource.AddNew()
            DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(1) = IntNum
            DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(2) = index + 1
            dgvInventory.CurrentCell = dgvInventory(3, index + 1)
            'Show panel
            ShowRoomInput()
            'Add text to room number
            If IntLang = "Nederlands" Then
                txtNumR.Text = "RUIMTE "
            Else
                txtNumR.Text = "ZONE "
            End If
            txtNumR.SelectionStart = Len(txtNumR.Text)
            txtNumR.Focus()
            txtNumR.DeselectAll()
            dgvInventory.Rows(index + 1).Cells(3).Value = txtNumR.Text
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
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddObject()
    End Sub
    Private Sub AddObject()
        'Add a new object
        Try
            'Show panel
            ShowItemInput()
            'Check if inventory is empty, if it is not...
            If INVENTORYBindingSource.Count > 0 Then
                Dim index As Integer = INVENTORYBindingSource.Position
                dgvInventory.CurrentCell = dgvInventory(3, index)
                For i As Integer = INVENTORYBindingSource.Count - 1 To index + 1 Step -1
                    DirectCast(INVENTORYBindingSource.List(i), DataRowView).Item(2) = CInt(DirectCast(INVENTORYBindingSource.List(i), DataRowView).Item(2)) + 1
                Next
                'Add a new entry, incrementing ID and ORDER (both red from previous entry)
                INVENTORYBindingSource.AddNew()
                DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(1) = IntNum
                DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(2) = index + 1
                If index < INVENTORYBindingSource.Count - 2 Then
                    dgvInventory.CurrentCell = dgvInventory(3, index + 1)
                    dgvInventory.CurrentCell = dgvInventory(3, index + 2)
                End If
                dgvInventory.CurrentCell = dgvInventory(3, index + 1)
                Renumber()
                txtNum.Text = CStr(DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(3))
                txtDesc.Focus()
            Else
                'Add a new entry, incrementing ID (red on form load) and setting ORDER to 0
                INVENTORYBindingSource.AddNew()
                DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(1) = IntNum
                DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(2) = 0
                txtNum.Focus()
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
    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        'Move entry up in inventory datagridview
        Del = True
        Dim i As Integer = dgvInventory.CurrentCell.RowIndex
        If dgvInventory.Rows(i).Index <> 0 Then
            Dim currentCellAddress = dgvInventory.CurrentCellAddress
            'Swap current row with row above
            MoveCurrentRow(INVENTORYBindingSource.Position - 1)
            'Move the caret with the row
            dgvInventory.CurrentCell = dgvInventory.Rows(currentCellAddress.Y - 1).Cells(currentCellAddress.X)
        End If
        Del = False
    End Sub
    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        'Move entry down in inventory datagridview
        Del = True
        Dim i As Integer = dgvInventory.CurrentCell.RowIndex
        If dgvInventory.Rows(i).Index <> dgvInventory.Rows.Count - 1 Then
            Dim currentCellAddress = dgvInventory.CurrentCellAddress
            'Swap current row with row below
            MoveCurrentRow(INVENTORYBindingSource.Position + 1)
            'Move the caret with the row
            dgvInventory.CurrentCell = dgvInventory.Rows(currentCellAddress.Y + 1).Cells(currentCellAddress.X)
        End If
        Del = False
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Delete inventory entry
        Try
            Dim Result As DialogResult
            Dim i As Integer = 0
            Dim j As Integer = dgvInventory.SelectedRows.Count
            If j = 1 Then
                i = dgvInventory.CurrentRow.Index
            End If
            If Lang = 1 Then
                Result = MessageBox.Show("Weet u het zeker?", "Verwijder", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Else
                Result = MessageBox.Show("Êtes-vous sûr?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If
            If Result = DialogResult.Yes Then
                Del = True
                For Each Row As DataGridViewRow In dgvInventory.SelectedRows
                    If My.Computer.FileSystem.DirectoryExists(picsF) Then
                        Prefix = InventoryNum3Digits(dgvInventory.Rows(Row.Index).Cells(3).Value.ToString)
                        For Each imagefile As String In Directory.GetFiles(picsF)
                            If imagefile.Contains(Prefix) Then
                                File.Delete(imagefile)
                            End If
                        Next
                    End If
                    INVENTORYBindingSource.Position = Row.Index
                    INVENTORYBindingSource.RemoveCurrent()
                    i = INVENTORYBindingSource.Position
                Next
            End If
            Reorder(0)
            If dgvInventory.Rows.Count > 0 Then
                dgvInventory.CurrentCell = dgvInventory(3, dgvInventory.Rows.Count - 1)
            Else
                ShowNoInput()
            End If
            If j = 1 Then
                If dgvInventory.Rows.Count > 0 Then
                    If i = dgvInventory.Rows.Count Then
                        dgvInventory.CurrentCell = dgvInventory(3, i - 1)
                    Else
                        dgvInventory.CurrentCell = dgvInventory(3, i)
                    End If
                ElseIf dgvInventory.Rows.Count = 0 Then
                    ShowNoInput()
                End If
            Else
                dgvInventory.ClearSelection()
                If dgvInventory.Rows.Count > 0 Then
                    If i > 0 Then
                        dgvInventory.CurrentCell = dgvInventory(3, i - 1)
                    Else
                        dgvInventory.CurrentCell = dgvInventory(3, 0)
                    End If
                End If
            End If
            Del = False
            LoadPics()
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
    Private Sub btnRenumber_Click(sender As Object, e As EventArgs) Handles btnRenumber.Click
        Renumber()
    End Sub
    Private Sub Renumber()
        Dim index As Integer = dgvInventory.CurrentCell.RowIndex
        Dim indexH As Integer = 0
        Dim indexL As Integer = 0
        Dim m As Match = Regex.Match(CStr(dgvInventory.Rows(0).Cells(3).Value), "^([a-zA-Z]+)([0-9]+)$")
        Dim Room As String = m.Groups(1).Value
        If dgvInventory.Rows(index).Cells(3).Value.ToString.ToUpper.Contains("RUIMTE") OrElse dgvInventory.Rows(index).Cells(3).Value.ToString.ToUpper.Contains("ZONE") Then
            indexL = index + 1
            Room = dgvInventory.Rows(index).Cells(3).Value.ToString.Split(" ".ToCharArray)(1)
        Else
            For i As Integer = index - 1 To 0 Step -1
                If dgvInventory.Rows(i).Cells(3).Value.ToString.ToUpper.Contains("RUIMTE") OrElse dgvInventory.Rows(i).Cells(3).Value.ToString.ToUpper.Contains("ZONE") Then
                    indexL = i + 1
                    Room = dgvInventory.Rows(i).Cells(3).Value.ToString.Split(" ".ToCharArray)(1)
                    Exit For
                End If
            Next
        End If
        For i As Integer = index + 1 To dgvInventory.Rows.Count - 1
            If dgvInventory.Rows(i).Cells(3).Value.ToString.ToUpper.Contains("RUIMTE") OrElse dgvInventory.Rows(i).Cells(3).Value.ToString.ToUpper.Contains("ZONE") Then
                indexH = i - 1
                Exit For
            End If
        Next
        If indexH = 0 Then indexH = dgvInventory.Rows.Count - 1
        Dim j As Integer = 1
        If dgvInventory.Rows(indexL).Cells(3).Value.ToString.Contains(".") Then
            Dim n As String() = Split(dgvInventory.Rows(indexL).Cells(3).Value.ToString, ".")
            For i As Integer = indexL To indexH
                If Not String.IsNullOrEmpty(dgvInventory.Rows(i).Cells(3).Value.ToString) Then
                    If CStr(dgvInventory.Rows(i).Cells(3).Value) <> n(0) + "." + j.ToString Then
                        Dim oldname As String = InventoryNum3Digits(CStr(dgvInventory.Rows(i).Cells(3).Value))
                        Dim newname As String = InventoryNum3Digits(n(0) + "." + j.ToString)
                        For Each imagefile As String In Directory.GetFiles(picsF)
                            If imagefile.Contains(oldname) Then
                                Dim NewNum As String = imagefile.Replace(oldname, newname)
                                NewNum = Path.GetFileName(NewNum)
                                My.Computer.FileSystem.RenameFile(imagefile, NewNum)
                            End If
                        Next
                    End If
                End If
                dgvInventory.Rows(i).Cells(3).Value = n(0) + "." + j.ToString
                j += 1
            Next
        Else
            For i As Integer = indexL To indexH
                If Not String.IsNullOrEmpty(dgvInventory.Rows(i).Cells(3).Value.ToString) Then
                    If CStr(dgvInventory.Rows(i).Cells(3).Value) <> Room + j.ToString Then
                        Dim oldname As String = InventoryNum3Digits(CStr(dgvInventory.Rows(i).Cells(3).Value))
                        Dim newname As String = InventoryNum3Digits(Room + j.ToString)
                        For Each imagefile As String In Directory.GetFiles(picsF)
                            If imagefile.Contains(oldname) Then
                                Dim NewNum As String = imagefile.Replace(oldname, newname)
                                Try
                                    My.Computer.FileSystem.RenameFile(imagefile, Path.GetFileName(NewNum))
                                Catch ex As IOException
                                    My.Computer.FileSystem.RenameFile(NewNum, "temp.jpg")
                                    MsgBox($"{NewNum} -> temp.jpg")
                                    My.Computer.FileSystem.RenameFile(imagefile, Path.GetFileName(NewNum))
                                    MsgBox($"{imagefile} -> {Path.GetFileName(NewNum)}")
                                    My.Computer.FileSystem.RenameFile($"{picsF}\temp.jpg", Path.GetFileName(imagefile))
                                    MsgBox($"{picsF}\temp.jpg -> {Path.GetFileName(imagefile)}")
                                End Try
                            End If
                        Next
                    End If
                End If
                dgvInventory.Rows(i).Cells(3).Value = Room + j.ToString
                j += 1
            Next
        End If
    End Sub
    Private Sub btnSeizure_Click(sender As Object, e As EventArgs) Handles btnSeizure.Click
        'Add object to seizures
        If Not dgvInventory.CurrentRow.Cells(3).Value.ToString.Contains("RUIMTE") AndAlso Not dgvInventory.CurrentRow.Cells(3).Value.ToString.Contains("ZONE") Then
            Dim NewSeizureRow As DataRow = DORADbDS.Tables("SEIZURE").NewRow()
            Try
                NewSeizureRow("DATE INT") = frmIntervention.txtDateInt.Text
                NewSeizureRow("ID INT") = IntNum
                NewSeizureRow("CASE NAME") = CaseName
                NewSeizureRow("DESC") = dgvInventory.CurrentRow.Cells(4).Value.ToString
                NewSeizureRow("NUM") = dgvInventory.CurrentRow.Cells(3).Value.ToString
                DORADbDS.Tables("SEIZURE").Rows.Add(NewSeizureRow)
                SEIZURETableAdapter.Update(DORADbDS.SEIZURE)
                'Copy image
                If INVENTORYBindingSource.Count <> 0 Then
                    Prefix = InventoryNum3Digits(CStr(DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(3)))
                    'Cycle all images in intervention folder
                    For Each imagefile As String In Directory.GetFiles(picsF)
                        If imagefile.Contains(Prefix) Then
                            My.Computer.FileSystem.CopyFile($"{picsF}\{Prefix}-01.jpg", $"{dora_path}SEIZURES\{Prefix} ({frmIntervention.txtDateInt.Value:dd-MM-yyyy}).jpg")
                            Exit For
                        End If
                    Next
                End If
                If Lang = 1 Then
                    MessageBox.Show("Opgenomen item", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Saisie enregistrée", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        End If
    End Sub
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        'Import an inventory made in word template
        Using OFD As New OpenFileDialog
            OFD.InitialDirectory = "C:\Mes Documents\"
            OFD.Title = "Load..."
            OFD.FileName = String.Empty
            OFD.DefaultExt = ".docx"
            If OFD.ShowDialog() = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Dim oWord As New Word.Application
                oWord.Visible = False
                Dim oDoc As Word.Document
                oDoc = oWord.Documents.Open(CStr(OFD.FileName), [ReadOnly]:=True)
                Dim j As Integer = 0
                If INVENTORYBindingSource.Count > 0 Then
                    'Count number of records in inventory.docx
                    Dim count As Integer = 0
                    For i As Integer = 0 To oDoc.Tables(1).Rows.Count
                        If oDoc.Tables(1).Cell(i + 2, 1).Range.Text <> Chr(13) & Chr(7) Then
                            count += 1
                        End If
                    Next
                    'Renumber inventory
                    If dgvInventory.CurrentRow.Index = 0 Then
                        INVENTORYBindingSource.Position = INVENTORYBindingSource.Count - 1
                        For i As Integer = INVENTORYBindingSource.Count - 1 To 0 Step -1
                            DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(2) = i + count + 1
                            INVENTORYBindingSource.MovePrevious()
                        Next
                    Else
                        j = dgvInventory.CurrentRow.Index + 1
                        INVENTORYBindingSource.Position = INVENTORYBindingSource.Count - 1
                        For i As Integer = dgvInventory.Rows.Count - 1 To j Step -1
                            DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(2) = i + count + 1
                            INVENTORYBindingSource.MovePrevious()
                        Next
                    End If
                End If
                'Insert inventory
                For i As Integer = 0 To oDoc.Tables(1).Rows.Count
                    If oDoc.Tables(1).Cell(i + 2, 1).Range.Text <> Chr(13) & Chr(7) Then
                        INVENTORYBindingSource.AddNew()
                        DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(1) = IntNum
                        DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(2) = i + j
                        DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(3) = UCase(oDoc.Tables(1).Cell(i + 2, 1).Range.Text.Substring(0, oDoc.Tables(1).Cell(i + 2, 1).Range.Text.Length - 2))
                        DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(4) = oDoc.Tables(1).Cell(i + 2, 2).Range.Text.Substring(0, oDoc.Tables(1).Cell(i + 2, 2).Range.Text.Length - 2)
                        DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(5) = oDoc.Tables(1).Cell(i + 2, 3).Range.Text.Substring(0, oDoc.Tables(1).Cell(i + 2, 3).Range.Text.Length - 2)
                        'DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(6) = frmIntervention.cmbSamplesTakenBy.Text
                    Else
                        oDoc.Close()
                        oWord.Application.Quit(False)
                        Marshal.ReleaseComObject(oDoc)
                        Marshal.ReleaseComObject(oWord)
                        GC.Collect()
                        Cursor = Cursors.Default
                        Exit Sub
                    End If
                Next
                oDoc.Close()
                oWord.Application.Quit(False)
                Marshal.ReleaseComObject(oDoc)
                Marshal.ReleaseComObject(oWord)
                GC.Collect()
                Cursor = Cursors.Default
                log("INV.", "inventory imported")
            End If
        End Using
    End Sub
#End Region
#Region "Datagridviews Pictures"
    Private Sub ShowPics() Handles btnPicsPanel.Click
        btnPicsPanel.IconColor = theme("High")
        btnPicsOPanel.IconColor = Color.DimGray
        pnlPics.Show()
        pnlButtonsPic.Show()
        pnlPicsO.Hide()
        pnlButtonsPicO.Hide()
    End Sub

    Private Sub ShowPicsO() Handles btnPicsOPanel.Click
        btnPicsOPanel.IconColor = theme("High")
        btnPicsPanel.IconColor = Color.DimGray
        pnlPicsO.Show()
        pnlButtonsPicO.Show()
        pnlPics.Hide()
        pnlButtonsPic.Hide()
    End Sub
    Public Function ScaleImage(OldImage As Image, TargetWidth As Integer, TargetHeight As Integer) As Image
        'Resize image keeping ratio
        Dim NewHeight As Integer = TargetHeight
        Dim NewWidth As Integer = CInt(NewHeight / OldImage.Height * OldImage.Width)
        If NewWidth > TargetWidth Then
            NewWidth = TargetWidth
            NewHeight = CInt(NewWidth / OldImage.Width * OldImage.Height)
        End If
        Return New Bitmap(OldImage, NewWidth, NewHeight)
    End Function
    Public Function ScaleImageLandscape(InputImage As Image) As Image
        'Scale landscape image
        Return New Bitmap(InputImage, New Size(1280, 853))
    End Function
    Public Function ScaleImagePortrait(InputImage As Image) As Image
        'Scale portrait image
        Return New Bitmap(InputImage, New Size(853, 1280))
    End Function
    Private Const OrientationId As Integer = &H112
    Public Enum ExifOrientations As Byte
        'Image orientation
        Unknown = 0
        TopLeft = 1
        TopRight = 2
        BottomRight = 3
        BottomLeft = 4
        LeftTop = 5
        RightTop = 6
        RightBottom = 7
        LeftBottom = 8
    End Enum
    Public Function ImageOrientation(img As Image) As ExifOrientations
        'Get the index of the orientation property
        Dim orientation_index As Integer = Array.IndexOf(img.PropertyIdList, OrientationId)
        'If there is no such property, return Unknown
        If (orientation_index < 0) Then Return ExifOrientations.Unknown
        'Return the orientation value
        Return DirectCast(img.GetPropertyItem(OrientationId).Value(0), ExifOrientations)
    End Function
    Private Sub dgvPics_MouseWheel(sender As Object, e As MouseEventArgs) Handles dgvPics.MouseWheel
        'Allow wheel mouse to scroll the pcitures list
        Dim currentIndex As Integer = dgvPics.FirstDisplayedScrollingRowIndex
        Dim scrollLines As Integer = SystemInformation.MouseWheelScrollLines
        Try
            Select Case e.Delta
                Case (120)
                    dgvPics.FirstDisplayedScrollingRowIndex = Math.Max(0, currentIndex - scrollLines)
                Case (-120)
                    dgvPics.FirstDisplayedScrollingRowIndex = currentIndex + scrollLines
            End Select
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub dgvPicsO_MouseWheel(sender As Object, e As MouseEventArgs) Handles dgvPicsO.MouseWheel
        'Allow wheel mouse to scroll the pcitures list
        Dim currentIndex As Integer = dgvPicsO.FirstDisplayedScrollingRowIndex
        Dim scrollLines As Integer = SystemInformation.MouseWheelScrollLines
        Try
            Select Case e.Delta
                Case (120)
                    dgvPicsO.FirstDisplayedScrollingRowIndex = Math.Max(0, currentIndex - scrollLines)
                Case (-120)
                    dgvPicsO.FirstDisplayedScrollingRowIndex = currentIndex + scrollLines
            End Select
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub dgvPics_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPics.CellFormatting
        'Display a tooltip with image name
        dgvPics.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = CStr(dgvPics.Rows(e.RowIndex).Cells(0).Value)
    End Sub
    Private Sub dgvPicsO_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPicsO.CellFormatting
        'Display a tooltip with image name
        dgvPicsO.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = CStr(dgvPicsO.Rows(e.RowIndex).Cells(0).Value)
    End Sub
    Private Sub dgvPics_DragEnter(sender As Object, e As DragEventArgs) Handles dgvPics.DragEnter
        'Enter drag & drop
        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    Private Sub dgvPicsO_DragEnter(sender As Object, e As DragEventArgs) Handles dgvPicsO.DragEnter
        'Enter drag & drop
        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    Private Sub dgvPics_DragDrop(sender As Object, e As DragEventArgs) Handles dgvPics.DragDrop
        'Drag & drop image
        Dim DroppedFiles() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        Dim i As Integer = 1
        Cursor = Cursors.WaitCursor
        Prefix = InventoryNum3Digits(CStr(DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(3)))
        For Each path In DroppedFiles
            Dim pic As Image = Image.FromFile(path)
            'Check if image already exists
            While File.Exists($"{picsF}{Prefix}-{i:D2}.jpg")
                'if yes, increment i
                i = i + 1
            End While
            'Resize & rotate image
            Dim OriginalImg As Image = pic
            Dim ResizedImg As Image
            Select Case CInt(ImageOrientation(OriginalImg))
                Case 0, 1
                    If OriginalImg.Width < OriginalImg.Height Then
                        ResizedImg = ScaleImagePortrait(OriginalImg)
                        ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                    Else
                        ResizedImg = ScaleImageLandscape(OriginalImg)
                        ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                    End If
                Case 6
                    OriginalImg.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    ResizedImg = ScaleImagePortrait(OriginalImg)
                    ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                Case 8
                    OriginalImg.RotateFlip(RotateFlipType.Rotate270FlipNone)
                    ResizedImg = ScaleImagePortrait(OriginalImg)
                    ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
            End Select
        Next
        'Reload images in the datagridview
        LoadPics()
        dgvPics.FirstDisplayedScrollingRowIndex = dgvPics.RowCount - 1
        dgvPics.Rows(dgvPics.RowCount - 1).Selected = True
        Cursor = Cursors.Default
    End Sub

    Private Sub dgvPicsO_DragDrop(sender As Object, e As DragEventArgs) Handles dgvPicsO.DragDrop
        'Drag & drop image
        Dim DroppedFiles() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        Dim i As Integer = 1
        Cursor = Cursors.WaitCursor
        Prefix = "Overzicht"
        For Each path In DroppedFiles
            Dim pic As Image = Image.FromFile(path)
            'Check if image already exists
            While File.Exists($"{picsF}{Prefix}-{i:D2}.jpg")
                'if yes, increment i
                i = i + 1
            End While
            'Resize & rotate image
            Dim OriginalImg As Image = pic
            Dim ResizedImg As Image
            Select Case CInt(ImageOrientation(OriginalImg))
                Case 0, 1
                    If OriginalImg.Width < OriginalImg.Height Then
                        ResizedImg = ScaleImagePortrait(OriginalImg)
                        ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                    Else
                        ResizedImg = ScaleImageLandscape(OriginalImg)
                        ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                    End If
                Case 6
                    OriginalImg.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    ResizedImg = ScaleImagePortrait(OriginalImg)
                    ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                Case 8
                    OriginalImg.RotateFlip(RotateFlipType.Rotate270FlipNone)
                    ResizedImg = ScaleImagePortrait(OriginalImg)
                    ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
            End Select
        Next
        'Reload images in the datagridview
        LoadPicsO()
        dgvPicsO.FirstDisplayedScrollingRowIndex = dgvPicsO.RowCount - 1
        dgvPicsO.Rows(dgvPicsO.RowCount - 1).Selected = True
        Cursor = Cursors.Default
    End Sub
    Private Sub btnPics_Click(sender As Object, e As EventArgs) Handles btnPics.Click
        'Add images to currently selected entry in inventory datagridview
        Try
            Prefix = InventoryNum3Digits(CStr(DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(3)))
            'Open file dialog
            Using OFD As New OpenFileDialog
                OFD.InitialDirectory = $"{highF}"
                OFD.Title = "Select pictures..."
                OFD.FileName = String.Empty
                OFD.DefaultExt = ".jpg .jpeg"
                OFD.Multiselect = True
                If OFD.ShowDialog() = DialogResult.OK Then
                    Dim i As Integer = 1
                    For Each pic As String In OFD.FileNames
                        'Check if image already exists
                        While File.Exists($"{picsF}{Prefix}-{i:D2}.jpg")
                            'if yes, increment i
                            i = i + 1
                        End While
                        'Resize & rotate image
                        Dim OriginalImg As Image = Image.FromFile(pic)
                        Dim ResizedImg As Image
                        Select Case CInt(ImageOrientation(OriginalImg))
                            Case 0, 1
                                If OriginalImg.Width < OriginalImg.Height Then
                                    ResizedImg = ScaleImagePortrait(OriginalImg)
                                    ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                                Else
                                    ResizedImg = ScaleImageLandscape(OriginalImg)
                                    ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                                End If
                            Case 6
                                OriginalImg.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                ResizedImg = ScaleImagePortrait(OriginalImg)
                                ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                            Case 8
                                OriginalImg.RotateFlip(RotateFlipType.Rotate270FlipNone)
                                ResizedImg = ScaleImagePortrait(OriginalImg)
                                ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                        End Select
                    Next
                End If
                'Reload images in the datagridview
                LoadPics()
                dgvPics.FirstDisplayedScrollingRowIndex = dgvPics.RowCount - 1
                dgvPics.Rows(dgvPics.RowCount - 1).Selected = True
            End Using
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
    Private Sub btnPicsO_Click(sender As Object, e As EventArgs) Handles btnPicsO.Click
        'Add Overzicht images in inventory datagridview
        Try
            Prefix = "Overzicht"
            'Open file dialog
            Using OFD As New OpenFileDialog
                OFD.InitialDirectory = $"{highF}"
                OFD.Title = "Select pictures..."
                OFD.FileName = String.Empty
                OFD.DefaultExt = ".jpg .jpeg"
                OFD.Multiselect = True
                If OFD.ShowDialog() = DialogResult.OK Then
                    Dim i As Integer = 1
                    For Each pic As String In OFD.FileNames
                        'Check if image already exists
                        While File.Exists($"{picsF}{Prefix}-{i:D2}.jpg")
                            'if yes, increment i
                            i = i + 1
                        End While
                        'Resize & rotate image
                        Dim OriginalImg As Image = Image.FromFile(pic)
                        Dim ResizedImg As Image
                        Select Case CInt(ImageOrientation(OriginalImg))
                            Case 1
                                If OriginalImg.Width < OriginalImg.Height Then
                                    ResizedImg = ScaleImagePortrait(OriginalImg)
                                    ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                                Else
                                    ResizedImg = ScaleImageLandscape(OriginalImg)
                                    ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                                End If
                            Case 6
                                OriginalImg.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                ResizedImg = ScaleImagePortrait(OriginalImg)
                                ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                            Case 8
                                OriginalImg.RotateFlip(RotateFlipType.Rotate270FlipNone)
                                ResizedImg = ScaleImagePortrait(OriginalImg)
                                ResizedImg.Save($"{picsF}{Prefix}-{i:D2}.jpg", Imaging.ImageFormat.Jpeg)
                        End Select
                    Next
                End If
                'Reload images in the datagridview
                LoadPicsO()
                dgvPicsO.FirstDisplayedScrollingRowIndex = dgvPicsO.RowCount - 1
                dgvPicsO.Rows(dgvPicsO.RowCount - 1).Selected = True
            End Using
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
    Private Sub LoadPics()
        'Load images in the datagridview
        Try
            'Clear datagridview
            dgvPics.Rows.Clear()
            dgvPics.Columns.Clear()
            'Setup datagridview
            Dim col1 As New DataGridViewTextBoxColumn
            Dim colimg As New DataGridViewImageColumn
            col1.Width = 5
            colimg.ImageLayout = DataGridViewImageCellLayout.Zoom
            colimg.Width = 150
            dgvPics.Columns.Add(col1)
            dgvPics.Columns.Add(colimg)
            dgvPics.Columns(0).Visible = False
            dgvPics.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPics.DefaultCellStyle.SelectionBackColor = Color.Orange
            If INVENTORYBindingSource.Count <> 0 Then
                Prefix = InventoryNum3Digits(CStr(DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(3)))
                Dim i As Integer = 0
                'Cycle all images in intervention folder
                For Each imagefile As String In Directory.GetFiles(picsF)
                    If imagefile.Contains(Prefix) Then
                        dgvPics.Rows.Add()
                        dgvPics.Rows(i).Cells(0).Value = Path.GetFileName(imagefile)
                        Dim pic As Image
                        Using str As Stream = File.OpenRead(imagefile)
                            pic = Image.FromStream(str)
                        End Using
                        'Resize it and display in datagridview
                        dgvPics.Rows(i).Cells(1).Value = ScaleImage(pic, 140, 140)
                        i = i + 1
                    End If
                Next
                If dgvPics.RowCount > 0 Then
                    dgvPics.Sort(dgvPics.Columns(0), ListSortDirection.Ascending)
                    dgvPics.Rows(0).Cells(1).Selected = True
                End If
            End If
        Catch exDNF As DirectoryNotFoundException
            Return
        Catch exICE As InvalidCastException
            Return
        Catch exDBCE As DBConcurrencyException
            Return
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
    Private Sub LoadPicsO()
        'Load images in the datagridview
        Try
            'Clear datagridview
            dgvPicsO.Rows.Clear()
            dgvPicsO.Columns.Clear()
            'Setup datagridview
            Dim col1 As New DataGridViewTextBoxColumn
            Dim colimg As New DataGridViewImageColumn
            col1.Width = 5
            colimg.ImageLayout = DataGridViewImageCellLayout.Zoom
            colimg.Width = 150
            dgvPicsO.Columns.Add(col1)
            dgvPicsO.Columns.Add(colimg)
            dgvPicsO.Columns(0).Visible = False
            dgvPicsO.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPicsO.DefaultCellStyle.SelectionBackColor = Color.Orange
            Prefix = "Overzicht"
            Dim i As Integer = 0
            'Cycle all images in intervention folder
            For Each imagefile As String In Directory.GetFiles(picsF)
                If imagefile.Contains(Prefix) Then
                    dgvPicsO.Rows.Add()
                    dgvPicsO.Rows(i).Cells(0).Value = Path.GetFileName(imagefile)
                    Dim pic As Image
                    Using str As Stream = File.OpenRead(imagefile)
                        pic = Image.FromStream(str)
                    End Using
                    'Resize it and display in datagridview
                    dgvPicsO.Rows(i).Cells(1).Value = ScaleImage(pic, 140, 140)
                    i = i + 1
                End If
            Next
            If dgvPicsO.RowCount > 0 Then
                dgvPicsO.Sort(dgvPicsO.Columns(0), ListSortDirection.Ascending)
                dgvPicsO.Rows(0).Cells(1).Selected = True
            End If
        Catch exDNF As DirectoryNotFoundException
            Return
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
    Private Sub btnUpPic_Click(sender As Object, e As EventArgs) Handles btnUpPic.Click
        'Move image up
        Try
            If dgvPics.SelectedCells.Item(1).RowIndex > 0 Then
                Dim i As Integer = dgvPics.SelectedCells.Item(1).RowIndex
                Dim oldpos As String = CStr(dgvPics.Rows(i).Cells(0).Value)
                Dim newpos As String = CStr(dgvPics.Rows(i - 1).Cells(0).Value)
                My.Computer.FileSystem.RenameFile($"{picsF}{oldpos}", "temp.jpg")
                My.Computer.FileSystem.RenameFile($"{picsF}{newpos}", oldpos)
                My.Computer.FileSystem.RenameFile($"{picsF}temp.jpg", newpos)
                LoadPics()
                dgvPics.ClearSelection()
                dgvPics.Rows(i - 1).Cells(1).Selected = True
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
    Private Sub btnUpPicO_Click(sender As Object, e As EventArgs) Handles btnUpPicO.Click
        'Move image up
        Try
            If dgvPicsO.SelectedCells.Item(1).RowIndex > 0 Then
                Dim i As Integer = dgvPicsO.SelectedCells.Item(1).RowIndex
                Dim oldpos As String = CStr(dgvPicsO.Rows(i).Cells(0).Value)
                Dim newpos As String = CStr(dgvPicsO.Rows(i - 1).Cells(0).Value)
                My.Computer.FileSystem.RenameFile($"{picsF}{oldpos}", "temp.jpg")
                My.Computer.FileSystem.RenameFile($"{picsF}{newpos}", oldpos)
                My.Computer.FileSystem.RenameFile($"{picsF}temp.jpg", newpos)
                LoadPicsO()
                dgvPicsO.ClearSelection()
                dgvPicsO.Rows(i - 1).Cells(1).Selected = True
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
    Private Sub btnDownPic_Click(sender As Object, e As EventArgs) Handles btnDownPic.Click
        'Move image down
        Try
            If dgvPics.SelectedCells.Item(1).RowIndex < dgvPics.Rows.Count - 1 Then
                Dim i As Integer = dgvPics.SelectedCells.Item(1).RowIndex
                Dim oldpos As String = CStr(dgvPics.Rows(i).Cells(0).Value)
                Dim newpos As String = CStr(dgvPics.Rows(i + 1).Cells(0).Value)
                My.Computer.FileSystem.RenameFile($"{picsF}{oldpos}", "temp.jpg")
                My.Computer.FileSystem.RenameFile($"{picsF}{newpos}", oldpos)
                My.Computer.FileSystem.RenameFile($"{picsF}temp.jpg", newpos)
                LoadPics()
                dgvPics.Rows(i + 1).Cells(1).Selected = True
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
    Private Sub btnDownPicO_Click(sender As Object, e As EventArgs) Handles btnDownPicO.Click
        'Move image down
        Try
            If dgvPicsO.SelectedCells.Item(1).RowIndex < dgvPicsO.Rows.Count - 1 Then
                Dim i As Integer = dgvPicsO.SelectedCells.Item(1).RowIndex
                Dim oldpos As String = CStr(dgvPicsO.Rows(i).Cells(0).Value)
                Dim newpos As String = CStr(dgvPicsO.Rows(i + 1).Cells(0).Value)
                My.Computer.FileSystem.RenameFile($"{picsF}{oldpos}", "temp.jpg")
                My.Computer.FileSystem.RenameFile($"{picsF}{newpos}", oldpos)
                My.Computer.FileSystem.RenameFile($"{picsF}temp.jpg", newpos)
                LoadPicsO()
                dgvPicsO.Rows(i + 1).Cells(1).Selected = True
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
    Private Sub btnDeletePic_Click(sender As Object, e As EventArgs) Handles btnDeletePic.Click
        'Delete image
        Dim i As Integer = dgvPics.SelectedCells.Item(1).RowIndex
        File.Delete(picsF & CStr(dgvPics.Rows(i).Cells(0).Value))
        dgvPics.Rows.RemoveAt(i)
    End Sub
    Private Sub btnDeletePicO_Click(sender As Object, e As EventArgs) Handles btnDeletePicO.Click
        'Delete image
        Dim i As Integer = dgvPicsO.SelectedCells.Item(1).RowIndex
        File.Delete(picsF & CStr(dgvPicsO.Rows(i).Cells(0).Value))
        dgvPicsO.Rows.RemoveAt(i)
    End Sub
    Private Sub btnRotateL_Click(sender As Object, e As EventArgs) Handles btnRotateL.Click
        'Rotate left
        Dim row As Integer = dgvPics.SelectedCells.Item(1).RowIndex
        Dim pic As Image = Image.FromFile(picsF & CStr(dgvPics.Rows(row).Cells(0).Value))
        Dim j = dgvPics.FirstDisplayedScrollingRowIndex
        pic.RotateFlip(RotateFlipType.Rotate270FlipNone)
        pic.Save(picsF & CStr(dgvPics.Rows(row).Cells(0).Value))
        LoadPics()
        dgvPics.Rows(row).Cells(1).Selected = True
        If dgvPics.Rows.Count > 0 Then dgvPics.FirstDisplayedScrollingRowIndex = j
    End Sub
    Private Sub btnRotateLO_Click(sender As Object, e As EventArgs) Handles btnRotateLO.Click
        'Rotate left
        Dim row As Integer = dgvPicsO.SelectedCells.Item(1).RowIndex
        Dim pic As Image = Image.FromFile(picsF & CStr(dgvPicsO.Rows(row).Cells(0).Value))
        Dim j = dgvPicsO.FirstDisplayedScrollingRowIndex
        pic.RotateFlip(RotateFlipType.Rotate270FlipNone)
        pic.Save(picsF & CStr(dgvPicsO.Rows(row).Cells(0).Value))
        LoadPicsO()
        dgvPicsO.Rows(row).Cells(1).Selected = True
        If dgvPicsO.Rows.Count > 0 Then dgvPicsO.FirstDisplayedScrollingRowIndex = j
    End Sub
    Private Sub btnRotateR_Click(sender As Object, e As EventArgs) Handles btnRotateR.Click
        'Rotate right
        Dim row As Integer = dgvPics.SelectedCells.Item(1).RowIndex
        Dim pic As Image = Image.FromFile(picsF & CStr(dgvPics.Rows(row).Cells(0).Value))
        Dim j = dgvPics.FirstDisplayedScrollingRowIndex
        pic.RotateFlip(RotateFlipType.Rotate90FlipNone)
        pic.Save(picsF & CStr(dgvPics.Rows(row).Cells(0).Value))
        LoadPics()
        dgvPics.Rows(row).Cells(1).Selected = True
        If dgvPics.Rows.Count > 0 Then dgvPics.FirstDisplayedScrollingRowIndex = j
    End Sub

    Private Sub btnRotateRO_Click(sender As Object, e As EventArgs) Handles btnRotateRO.Click
        'Rotate right
        Dim row As Integer = dgvPicsO.SelectedCells.Item(1).RowIndex
        Dim pic As Image = Image.FromFile(picsF & CStr(dgvPicsO.Rows(row).Cells(0).Value))
        Dim j = dgvPicsO.FirstDisplayedScrollingRowIndex
        pic.RotateFlip(RotateFlipType.Rotate90FlipNone)
        pic.Save(picsF & CStr(dgvPicsO.Rows(row).Cells(0).Value))
        LoadPicsO()
        dgvPicsO.Rows(row).Cells(1).Selected = True
        If dgvPicsO.Rows.Count > 0 Then dgvPicsO.FirstDisplayedScrollingRowIndex = j
    End Sub
    Private Sub dgvPics_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPics.CellDoubleClick
        'Enlarge image
        Prefix = InventoryNum3Digits(CStr(DirectCast(INVENTORYBindingSource.Current, DataRowView).Item(3)))
        Process.Start($"{picsF}{Prefix}-{dgvPics.CurrentRow.Index + 1:00}.jpg")
    End Sub
    Private Sub dgvPicsO_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPicsO.CellDoubleClick
        'Enlarge image
        Prefix = "Overzicht"
        Process.Start($"{picsF}{Prefix}-{dgvPicsO.CurrentRow.Index + 1:00}.jpg")
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
#Region "Background Worker"
    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw.DoWork
        Directory.CreateDirectory(lowF)
        Dim c As Integer = Directory.GetFiles(highF, "*.jpg", SearchOption.AllDirectories).Count()
        Dim i As Integer = 0
        For Each pic As String In Directory.GetFiles(highF, "*.jpg", SearchOption.AllDirectories)
            Try
                'Resize & rotate image
                Dim OriginalImg As Image
                Using str As Stream = File.OpenRead(pic)
                    OriginalImg = Image.FromStream(str)
                End Using
                Dim ResizedImg As Image
                Select Case CInt(ImageOrientation(OriginalImg))
                    Case 0, 1
                        If OriginalImg.Width < OriginalImg.Height Then
                            ResizedImg = ScaleImagePortrait(OriginalImg)
                            ResizedImg.Save($"{lowF}{Path.GetFileName(pic)}", Imaging.ImageFormat.Jpeg)
                        Else
                            ResizedImg = ScaleImageLandscape(OriginalImg)
                            ResizedImg.Save($"{lowF}{Path.GetFileName(pic)}", Imaging.ImageFormat.Jpeg)
                        End If
                    Case 6
                        OriginalImg.RotateFlip(RotateFlipType.Rotate90FlipNone)
                        ResizedImg = ScaleImagePortrait(OriginalImg)
                        ResizedImg.Save($"{lowF}{Path.GetFileName(pic)}", Imaging.ImageFormat.Jpeg)
                    Case 8
                        OriginalImg.RotateFlip(RotateFlipType.Rotate270FlipNone)
                        ResizedImg = ScaleImagePortrait(OriginalImg)
                        ResizedImg.Save($"{lowF}{Path.GetFileName(pic)}", Imaging.ImageFormat.Jpeg)
                End Select
                i += 1
                bgw.ReportProgress(CInt((i / c) * 100))
            Catch ex As Exception
                If Lang = 1 Then
                    MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show(ex.ToString, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show(ex.ToString, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try
        Next
    End Sub
    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw.ProgressChanged
        frmProgBar.UpdateProgress(e.ProgressPercentage)
    End Sub
    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted
        If Lang = 1 Then
            ToolTip.SetToolTip(btnPicsLow, "LOW foto's openen")
            MessageBox.Show("Gedaan", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ToolTip.SetToolTip(btnPicsLow, "Ouvrir photos LOW")
            MessageBox.Show("Terminé", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        frmProgBar.Close()
        log("INV.", "low pictures folder created")
    End Sub
#End Region
#Region "Miscellaneous"
    Private Sub Trad()
        'Translate GUI
        If Lang = 1 Then
            ToolTip.SetToolTip(btnPicsPanel, "Foto('s)")
            ToolTip.SetToolTip(btnPicsOPanel, "Overzicht Foto('s)")
            ToolTip.SetToolTip(txtNumR, "Nummer")
            ToolTip.SetToolTip(txtDescR, "Beschrijving")
            ToolTip.SetToolTip(txtNum, "Nummer")
            ToolTip.SetToolTip(txtDesc, "Beschrijving")
            ToolTip.SetToolTip(txtSamples, "Staalname")
            ToolTip.SetToolTip(cmbSamplesT, "Genomen door")
            ToolTip.SetToolTip(btnInventoryGen, "Inventaris genereren")
            ToolTip.SetToolTip(btnPicturesGen, "Fotodossier genereren")
            If Directory.Exists(lowF) Then
                ToolTip.SetToolTip(btnPicsLow, "Foto's openen")
            Else
                ToolTip.SetToolTip(btnPicsLow, "Low foto's creëer")
            End If
            ToolTip.SetToolTip(btnAdd, "Nummer toevoegen (Snelkoppeling: CTRL +)")
            ToolTip.SetToolTip(btnAddRuimte, "Ruimte toevoegen (Snelkoppeling: CTRL *)")
            ToolTip.SetToolTip(btnUp, "Naar boven")
            ToolTip.SetToolTip(btnDown, "Naar beneden")
            ToolTip.SetToolTip(btnPics, "Foto's toevoegen")
            ToolTip.SetToolTip(btnUpPic, "Naar boven")
            ToolTip.SetToolTip(btnDownPic, "Naar beneden")
            ToolTip.SetToolTip(btnDeletePic, "Verwijder")
            ToolTip.SetToolTip(btnPicsO, "Overzicht foto's toevoegen")
            ToolTip.SetToolTip(btnUpPicO, "Naar boven")
            ToolTip.SetToolTip(btnDownPicO, "Naar beneden")
            ToolTip.SetToolTip(btnDeletePicO, "Verwijder")
            ToolTip.SetToolTip(btnImport, "Inventaris importeren")
            ToolTip.SetToolTip(btnSave, "Wijzigingen opslaan")
            ToolTip.SetToolTip(btnRotateL, "Links draaien")
            ToolTip.SetToolTip(btnRotateR, "Rechts draaien")
            ToolTip.SetToolTip(btnRotateLO, "Links draaien")
            ToolTip.SetToolTip(btnRotateRO, "Rechts draaien")
            ToolTip.SetToolTip(btnRenumber, "Hernoemen")
            ToolTip.SetToolTip(btnDelete, "Verwijder")
            ToolTip.SetToolTip(btnSeizure, "Vesta")
        Else
            ToolTip.SetToolTip(btnPicsPanel, "Photo(s)")
            ToolTip.SetToolTip(btnPicsOPanel, "Photo(s) générale(s)")
            ToolTip.SetToolTip(txtNumR, "Numéro")
            ToolTip.SetToolTip(txtDescR, "Description")
            ToolTip.SetToolTip(txtNum, "Numéro")
            ToolTip.SetToolTip(txtDesc, "Description")
            ToolTip.SetToolTip(txtSamples, "Échantillons")
            ToolTip.SetToolTip(cmbSamplesT, "Prélevés par")
            ToolTip.SetToolTip(btnInventoryGen, "Générer inventaire")
            ToolTip.SetToolTip(btnPicturesGen, "Générer dossier photos")
            If Directory.Exists(lowF) Then
                ToolTip.SetToolTip(btnPicsLow, "Ouvrir photos")
            Else
                ToolTip.SetToolTip(btnPicsLow, "Créer photos LOW")
            End If
            ToolTip.SetToolTip(btnAdd, "Ajouter un numéro (Raccourci: CTRL +)")
            ToolTip.SetToolTip(btnAddRuimte, "Ajouter une zone (Raccourci: CTRL *)")
            ToolTip.SetToolTip(btnUp, "Monter")
            ToolTip.SetToolTip(btnDown, "Descendre")
            ToolTip.SetToolTip(btnPics, "Ajouter photo(s)")
            ToolTip.SetToolTip(btnUpPic, "Monter")
            ToolTip.SetToolTip(btnDownPic, "Descendre")
            ToolTip.SetToolTip(btnDeletePic, "Supprimer")
            ToolTip.SetToolTip(btnPicsO, "Ajouter photo(s)")
            ToolTip.SetToolTip(btnUpPicO, "Monter")
            ToolTip.SetToolTip(btnDownPicO, "Descendre")
            ToolTip.SetToolTip(btnDeletePicO, "Supprimer")
            ToolTip.SetToolTip(btnImport, "Importer inventaire")
            ToolTip.SetToolTip(btnSave, "Enregistrer les modifications")
            ToolTip.SetToolTip(btnRotateL, "Pivoter vers la gauche")
            ToolTip.SetToolTip(btnRotateR, "Pivoter vers la droite")
            ToolTip.SetToolTip(btnRotateLO, "Pivoter vers la gauche")
            ToolTip.SetToolTip(btnRotateRO, "Pivoter vers la droite")
            ToolTip.SetToolTip(btnRenumber, "Renuméroter")
            ToolTip.SetToolTip(btnDelete, "Supprimer")
            ToolTip.SetToolTip(btnSeizure, "Vesta")
        End If
    End Sub
    Private Sub FillCombo()
        'Fill combobox
        If IntLang = "Nederlands" Then
            cmbSamplesT.Items.Add("CRU")
            cmbSamplesT.Items.Add("NICC")
        Else
            cmbSamplesT.Items.Add("CRU")
            cmbSamplesT.Items.Add("INCC")
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Auto save
        btnSave_Click(sender, e)
    End Sub
    Private Sub ShowRoomInput()
        txtNum.Hide()
        txtDesc.Hide()
        txtSamples.Hide()
        cmbSamplesT.Hide()
        txtNumR.Show()
        txtDescR.Show()
    End Sub
    Private Sub ShowItemInput()
        txtNumR.Hide()
        txtDescR.Hide()
        txtNum.Show()
        txtDesc.Show()
        txtSamples.Show()
        cmbSamplesT.Show()
    End Sub
    Private Sub ShowNoInput()
        pnlInput.Hide()
    End Sub
    Public Sub EnableDoubleBuffered(dgv As DataGridView, setting As Boolean)
        'Speed up datagridview scrolling
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, setting, Nothing)
    End Sub
    Private Sub frmInventory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Delete inv dat file
        If File.Exists($"{dora_path}SYSTEM\INV,,{IntNum},,{user}.dat") Then
            File.Delete($"{dora_path}SYSTEM\INV,,{IntNum},,{user}.dat")
        End If
    End Sub
    Sub SetColors()
        'Set colors of controls according to choosen theme
        ForeColor = theme("Font")
        pnlTitle.BackColor = theme("Dark")
        pnlControls.BackColor = theme("Dark")
        pnlMenu.BackColor = theme("Medium")
        pnlLogo.BackColor = theme("Medium")
        dgvInventory.BackgroundColor = theme("Medium")
        dgvInventory.RowsDefaultCellStyle.BackColor = theme("Medium")
        dgvInventory.RowsDefaultCellStyle.ForeColor = theme("Font")
        dgvInventory.RowsDefaultCellStyle.SelectionBackColor = theme("High")
        dgvInventory.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvPics.BackgroundColor = theme("Light")
        dgvPics.RowsDefaultCellStyle.BackColor = theme("Light")
        dgvPics.RowsDefaultCellStyle.SelectionBackColor = theme("High")
        dgvPicsO.BackgroundColor = theme("Light")
        dgvPicsO.RowsDefaultCellStyle.BackColor = theme("Light")
        dgvPicsO.RowsDefaultCellStyle.SelectionBackColor = theme("High")
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
        For Each c As Control In pnlCenter.Controls
            If c.GetType = GetType(Panel) Then
                AddBorderToPanel(pnlCenter, c, theme("High"))
            End If
        Next
    End Sub

    Private Sub ShowPicsO(sender As Object, e As EventArgs) Handles btnPicsOPanel.Click

    End Sub

    Private Sub ShowPics(sender As Object, e As EventArgs) Handles btnPicsPanel.Click

    End Sub
#End Region

End Class