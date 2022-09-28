Option Explicit On
Option Strict On
Imports System.Globalization
Imports System.IO
Imports Word = Microsoft.Office.Interop.Word
Imports System.Data.OleDb
Imports System.ComponentModel
Imports FontAwesome.Sharp
Imports System.Runtime.InteropServices
Public Class frmIntervention
    Dim City As String
    Public constat As String
    Dim user_list() As String
    Dim user_name As String
    Dim olddate As Date
    Dim oldtypeofint As String
    Dim oldcity As String
    Dim oldadress As String
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub frmIntervention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = My.Settings.frmIntervention_loc
        Size = New Size(2053, 1033)
        SetColors()
        'Fill, filter and sort datatables
        frmMain.CITIESBindingSource1.Sort = "[CITY] ASC"
        cmbCityInt.DisplayMember = "CITY"
        cmbCityInt.DataSource = frmMain.CITIESBindingSource1
        cmbCityFacts.DisplayMember = "CITY"
        cmbCityFacts.DataSource = frmMain.CITIESBindingSource2
        INTERVENTIONSTableAdapter.Fill(DORADbDS.INTERVENTIONS)
        INTERVENTIONSBindingSource.Filter = $"[CASE NAME] = '{CaseName}'"
        INTERVENTIONSBindingSource.Sort = "[DATE INT] DESC, [ID CRU] DESC"
        CASESTableAdapter.Fill(DORADbDS.CASES)
        DRUGS_INTTableAdapter.Fill(DORADbDS.DRUGS_INT)
        DRUGS_INTBindingSource.Filter = $"[ID INT] = '{IntNum}'"
        MEMBERSTableAdapter.Fill(DORADbDS.MEMBERS)
        MEMBERSBindingSource.Filter = "[ACTIVE] = True"
        MEMBERSBindingSource.Sort = "[LAST NAME] ASC"
        MEMBERS_INTTableAdapter.Fill(DORADbDS.MEMBERS_INT)
        MEMBERS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
        MEMBERS_INTBindingSource.Sort = "[MEMBER NAME] ASC"
        PRODUCTSTableAdapter.Fill(DORADbDS.PRODUCTS)
        PRODUCTSBindingSource.Sort = "[SHORT NAME] ASC"
        PRODUCTS_INTTableAdapter.Fill(DORADbDS.PRODUCTS_INT)
        PRODUCTS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
        PRODUCTS_INTBindingSource.Sort = "[PRODUCT NAME] ASC"
        ControlBox = False
        Dim files As String() = Directory.GetFiles($"{dora_path}SYSTEM", "*.dat")
        For Each f In files
            Dim parts As String() = Split(Path.GetFileNameWithoutExtension(f), ",,")
            If parts(0) = "INV" AndAlso CInt(parts(1)) = IntNum Then
                user_list = UserToList($"{dora_path}cru.txt", parts(2))
                btnInv.IconColor = Color.FromName(user_list(3))
            End If
        Next
        olddate = txtDateInt.Value
        oldtypeofint = cmbTypeOfInt.Text
        oldcity = cmbCityInt.Text
        oldadress = txtAdressInt.Text
        Trad()
        FillCombo()
        'Move bindingsource position on the right record
        INTERVENTIONSBindingSource.Position = INTERVENTIONSBindingSource.Find("ID CRU", IntNum)
        SetPrevNextIcons()
        'Display the title
        lblTitle.Text = $"Dossier {CaseName} ({INTERVENTIONSBindingSource.Count - INTERVENTIONSBindingSource.Position}/{INTERVENTIONSBindingSource.Count})"
        HideDefaultDates()
        InitializeDataGridViews()
        handleCheckboxes()
        HideControls()
        HandleEmptyZip()
        DisplayFolder()
        DisplayTitle()
        UpdateCreation()
    End Sub
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
#Region "Checkboxes"
    Private Sub handleCheckboxes()
        If chkCRUReport.Checked = True Then
            btnCRUReport.IconChar = IconChar.Check
        Else
            btnCRUReport.IconChar = IconChar.Times
        End If
        If chkInventory.Checked = True Then
            btnInventory.IconChar = IconChar.Check
        Else
            btnInventory.IconChar = IconChar.Times
        End If
        If chkPicturesReport.Checked = True Then
            btnPicturesReport.IconChar = IconChar.Check
        Else
            btnPicturesReport.IconChar = IconChar.Times
        End If
        If chkNICCReport.Checked = True Then
            btnNICCReport.IconChar = IconChar.Check
        Else
            btnNICCReport.IconChar = IconChar.Times
        End If
        If chkIntervention.Checked = True Then
            btnIntervention.IconChar = IconChar.Check
        Else
            btnIntervention.IconChar = IconChar.Times
        End If
        If chkCRUOnSite.Checked = True Then
            btnCRUOnSite.IconChar = IconChar.Check
        Else
            btnCRUOnSite.IconChar = IconChar.Times
        End If
        If chkSuspect.Checked = True Then
            btnSuspect.IconChar = IconChar.Check
        Else
            btnSuspect.IconChar = IconChar.Times
        End If
        If chkDischarge.Checked = True Then
            btnDischarge.IconChar = IconChar.Check
        Else
            btnDischarge.IconChar = IconChar.Times
        End If
        If chkRecipe.Checked = True Then
            btnRecipe.IconChar = IconChar.Check
        Else
            btnRecipe.IconChar = IconChar.Times
        End If
        If chkBill.Checked = True Then
            btnBill.IconChar = IconChar.Check
        Else
            btnBill.IconChar = IconChar.Times
        End If
        If chkNote.Checked = True Then
            btnNote.IconChar = IconChar.Check
        Else
            btnNote.IconChar = IconChar.Times
        End If
    End Sub
    Private Sub btnCRUReport_Click(sender As Object, e As EventArgs) Handles btnCRUReport.Click
        If chkCRUReport.Checked = True Then
            chkCRUReport.Checked = False
        Else
            chkCRUReport.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        If chkInventory.Checked = True Then
            chkInventory.Checked = False
        Else
            chkInventory.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnPicturesReport_Click(sender As Object, e As EventArgs) Handles btnPicturesReport.Click
        If chkPicturesReport.Checked = True Then
            chkPicturesReport.Checked = False
        Else
            chkPicturesReport.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnNICCReport_Click(sender As Object, e As EventArgs) Handles btnNICCReport.Click
        If chkNICCReport.Checked = True Then
            chkNICCReport.Checked = False
        Else
            chkNICCReport.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnIntervention_Click(sender As Object, e As EventArgs) Handles btnIntervention.Click
        If chkIntervention.Checked = True Then
            chkIntervention.Checked = False
        Else
            chkIntervention.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnCRUOnSite_Click(sender As Object, e As EventArgs) Handles btnCRUOnSite.Click
        If chkCRUOnSite.Checked = True Then
            chkCRUOnSite.Checked = False
        Else
            chkCRUOnSite.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnSuspect_Click(sender As Object, e As EventArgs) Handles btnSuspect.Click
        If chkSuspect.Checked = True Then
            chkSuspect.Checked = False
        Else
            chkSuspect.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnDischarge_Click(sender As Object, e As EventArgs) Handles btnDischarge.Click
        If chkDischarge.Checked = True Then
            chkDischarge.Checked = False
        Else
            chkDischarge.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnRecipe_Click(sender As Object, e As EventArgs) Handles btnRecipe.Click
        If chkRecipe.Checked = True Then
            chkRecipe.Checked = False
        Else
            chkRecipe.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        If chkBill.Checked = True Then
            chkBill.Checked = False
        Else
            chkBill.Checked = True
        End If
        handleCheckboxes()
    End Sub
    Private Sub btnNote_Click(sender As Object, e As EventArgs) Handles btnNote.Click
        If chkNote.Checked = True Then
            chkNote.Checked = False
        Else
            chkNote.Checked = True
        End If
        handleCheckboxes()
    End Sub
#End Region
#Region "DataGridViews"
    Private Sub InitializeDataGridViews()
        InitMembersInt()
        dgvMembersInt.ClearSelection()
        dgvMembersInt.Columns(0).Width = CInt(((dgvMembersInt.Width / 3) * 2) + 10)
        dgvMembersInt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        InitProductsInt()
        dgvProductsInt.ClearSelection()
        dgvProductsInt.Columns(0).Width = CInt((dgvProductsInt.Width / 2) + 35)
        dgvProductsInt.Columns(1).Width = CInt((dgvProductsInt.Width / 5) + 5)
        dgvProductsInt.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        InitDrugsInt()
        dgvProd.ClearSelection()
        dgvProd.Columns(0).Width = CInt((dgvProd.Width / 3) + 5)
        dgvProd.Columns(1).Width = CInt((dgvProd.Width / 3) + 5)
        dgvProd.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        cmbMethod.Enabled = False
        cmbStep.Enabled = False
    End Sub
    Private Sub dgvProd_MouseWheel(sender As Object, e As MouseEventArgs) Handles dgvProd.MouseWheel
        'Allow wheel mouse to scroll the datagridview
        Dim currentIndex As Integer = dgvProd.FirstDisplayedScrollingRowIndex
        Dim scrollLines As Integer = SystemInformation.MouseWheelScrollLines
        Try
            Select Case e.Delta
                Case (120)
                    dgvProd.FirstDisplayedScrollingRowIndex = Math.Max(0, currentIndex - scrollLines)
                Case (-120)
                    dgvProd.FirstDisplayedScrollingRowIndex = currentIndex + scrollLines
            End Select
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub dgvMembersInt_MouseWheel(sender As Object, e As MouseEventArgs) Handles dgvMembersInt.MouseWheel
        'Allow wheel mouse to scroll the datagridview
        Dim currentIndex As Integer = dgvMembersInt.FirstDisplayedScrollingRowIndex
        Dim scrollLines As Integer = SystemInformation.MouseWheelScrollLines
        Try
            Select Case e.Delta
                Case (120)
                    dgvMembersInt.FirstDisplayedScrollingRowIndex = Math.Max(0, currentIndex - scrollLines)
                Case (-120)
                    dgvMembersInt.FirstDisplayedScrollingRowIndex = currentIndex + scrollLines
            End Select
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub ddgvProductsInt_MouseWheel(sender As Object, e As MouseEventArgs) Handles dgvProductsInt.MouseWheel
        'Allow wheel mouse to scroll the datagridview
        Dim currentIndex As Integer = dgvProductsInt.FirstDisplayedScrollingRowIndex
        Dim scrollLines As Integer = SystemInformation.MouseWheelScrollLines
        Try
            Select Case e.Delta
                Case (120)
                    dgvProductsInt.FirstDisplayedScrollingRowIndex = Math.Max(0, currentIndex - scrollLines)
                Case (-120)
                    dgvProductsInt.FirstDisplayedScrollingRowIndex = currentIndex + scrollLines
            End Select
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub dgvMembersInt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembersInt.CellClick
        'Display selected row in textboxes and comboboxes
        cmbMemberName.Text = CStr(dgvMembersInt.Item(0, dgvMembersInt.CurrentRow.Index).Value)
        txtMemberTimeIn.Text = CStr(dgvMembersInt.Item(1, dgvMembersInt.CurrentRow.Index).Value)
        dgvProductsInt.ClearSelection()
        dgvProd.ClearSelection()
    End Sub
    Private Sub InitMembersInt()
        'Initialize textboxes and comboboxes
        cmbMemberName.Text = String.Empty
        txtMemberTimeIn.Text = String.Empty
    End Sub
    Private Sub btnAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
        'Add new record
        If cmbMemberName.Text <> String.Empty Then
            Try
                Dim NewMemberRow As DataRow = DORADbDS.Tables("MEMBERS INT").NewRow()
                NewMemberRow("ID INT") = IntNum
                NewMemberRow("MEMBER NAME") = cmbMemberName.Text
                If txtMemberTimeIn.MaskCompleted = True Then
                    NewMemberRow("TIME IN") = txtMemberTimeIn.Text
                Else
                    NewMemberRow("TIME IN") = String.Empty
                End If
                DORADbDS.Tables("MEMBERS INT").Rows.Add(NewMemberRow)
                dgvMembersInt.Refresh()
                InitMembersInt()
                dgvMembersInt.ClearSelection()
            Catch exCE As ConstraintException
                If Lang = 1 Then
                    MessageBox.Show("Deze persoon is al toegevoegd", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Cette personne a déjà été ajoutée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub btnSaveMember_Click(sender As Object, e As EventArgs) Handles btnSaveMember.Click
        'Save current record
        If cmbMemberName.Text <> String.Empty Then
            Try
                Dim MemberRow() As DataRow = DORADbDS.Tables("MEMBERS INT").Select($"[MEMBER NAME] = '{cmbMemberName.Text}' AND [ID INT] = {IntNum}")
                MemberRow(0)("MEMBER NAME") = cmbMemberName.Text
                If txtMemberTimeIn.MaskCompleted = True Then
                    MemberRow(0)("TIME IN") = txtMemberTimeIn.Text
                Else
                    MemberRow(0)("TIME IN") = String.Empty
                End If
                dgvMembersInt.Refresh()
                InitMembersInt()
            Catch exIOORE As IndexOutOfRangeException
                If Lang = 1 Then
                    MessageBox.Show("Deze persoon staat niet op de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Cette personne n'est pas dans la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub btnDeleteMember_Click(sender As Object, e As EventArgs) Handles btnDeleteMember.Click
        'Delete current record
        If cmbMemberName.Text <> String.Empty Then
            Try
                Dim MemberRow() As DataRow = DORADbDS.Tables("MEMBERS INT").Select($"[MEMBER NAME] = '{cmbMemberName.Text}' AND [ID INT] = {IntNum}")
                MemberRow(0).Delete()
                dgvMembersInt.Refresh()
                InitMembersInt()
                dgvMembersInt.ClearSelection()
            Catch exIOORE As IndexOutOfRangeException
                If Lang = 1 Then
                    MessageBox.Show("Deze persoon staat niet op de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Cette personne n'est pas dans la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub btnRefreshMembers_Click(sender As Object, e As EventArgs) Handles btnRefreshMembers.Click
        MEMBERSTableAdapter.Fill(DORADbDS.MEMBERS)
        MEMBERSBindingSource.Filter = "[ACTIVE] = True"
        MEMBERSBindingSource.Sort = "[LAST NAME] ASC"
    End Sub
    Private Sub txtProductQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProductQuantity.KeyPress
        'Disable "." char
        If e.KeyChar = "." Then
            e.KeyChar = CChar(",")
            e.Handled = False
        End If
    End Sub
    Private Sub dgvProductsInt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductsInt.CellClick
        'Display selected row in textboxes and comboboxes
        cmbProductName.Text = CStr(dgvProductsInt.Item(0, dgvProductsInt.CurrentRow.Index).Value)
        If IsDBNull(dgvProductsInt.Item(1, dgvProductsInt.CurrentRow.Index).Value) Then
            txtProductQuantity.Text = String.Empty
        Else
            txtProductQuantity.Text = CStr(dgvProductsInt.Item(1, dgvProductsInt.CurrentRow.Index).Value)
        End If
        cmbProductUnit.Text = CStr(dgvProductsInt.Item(2, dgvProductsInt.CurrentRow.Index).Value)
        dgvMembersInt.ClearSelection()
        dgvProd.ClearSelection()
    End Sub
    Private Sub InitProductsInt()
        'Initialize textboxes and comboboxes
        cmbProductName.Text = String.Empty
        txtProductQuantity.Text = String.Empty
        cmbProductUnit.Text = String.Empty
    End Sub
    Private Sub btnSearchProduct_Click(sender As Object, e As EventArgs) Handles btnSearchProduct.Click
        If cmbProductName.Text.Length > 2 Then
            PRODUCTSBindingSource.Filter = $"[SHORT NAME] LIKE '%{cmbProductName.Text}%' OR [FULL NAME] LIKE '%{cmbProductName.Text}%' OR [NOM COMPLET] LIKE '%{cmbProductName.Text}%' OR [VOLLEDIGE NAAM] LIKE '%{cmbProductName.Text}%'"
            cmbProductName.DroppedDown = True
            cmbProductName.Text = String.Empty
        End If
    End Sub
    Private Sub cmbProductName_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbProductName.KeyDown
        If cmbProductName.Text = String.Empty And e.KeyCode = Keys.Back Then
            PRODUCTSBindingSource.Filter = String.Empty
            cmbProductName.Text = String.Empty
        End If
    End Sub
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        'Add new record
        If cmbProductName.Text <> String.Empty Then
            Try
                Dim NewProductRow As DataRow = DORADbDS.Tables("PRODUCTS INT").NewRow()
                NewProductRow("ID INT") = IntNum
                NewProductRow("PRODUCT NAME") = cmbProductName.Text
                If txtProductQuantity.Text = String.Empty Then
                    NewProductRow("QUANTITY") = DBNull.Value
                Else
                    NewProductRow("QUANTITY") = txtProductQuantity.Text
                End If
                NewProductRow("UNIT") = cmbProductUnit.Text
                DORADbDS.Tables("PRODUCTS INT").Rows.Add(NewProductRow)
                dgvProductsInt.Refresh()
                InitProductsInt()
                dgvProductsInt.ClearSelection()
                PRODUCTSBindingSource.Filter = String.Empty
                cmbProductName.Text = String.Empty
            Catch exCE As ConstraintException
                If Lang = 1 Then
                    MessageBox.Show("Dit product is al toegevoegd", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Ce produit a déjà été ajouté", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch exAE As ArgumentException
                If Lang = 1 Then
                    MessageBox.Show("Formaat onjuist", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Format incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub btnSaveProduct_Click(sender As Object, e As EventArgs) Handles btnSaveProduct.Click
        'Save current record
        If cmbProductName.Text <> String.Empty Then
            Try
                Dim ProductRow() As DataRow = DORADbDS.Tables("PRODUCTS INT").Select($"[PRODUCT NAME] = '{cmbProductName.Text}' AND [ID INT] = {IntNum}")
                ProductRow(0)("PRODUCT NAME") = cmbProductName.Text
                ProductRow(0)("QUANTITY") = txtProductQuantity.Text
                ProductRow(0)("UNIT") = cmbProductUnit.Text
                dgvProductsInt.Refresh()
                InitProductsInt()
            Catch exIOORE As IndexOutOfRangeException
                If Lang = 1 Then
                    MessageBox.Show("Dit product staat niet op de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Ce produit n'est pas dans la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                If Lang = 1 Then
                    MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try
        End If
    End Sub
    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        'Delete current record
        If cmbProductName.Text <> String.Empty Then
            Try
                Dim ProductRow() As DataRow = DORADbDS.Tables("PRODUCTS INT").Select($"[PRODUCT NAME] = '{cmbProductName.Text}' AND [ID INT] = {IntNum}")
                ProductRow(0).Delete()
                dgvProductsInt.Refresh()
                InitProductsInt()
                dgvProductsInt.ClearSelection()
            Catch exIOORE As IndexOutOfRangeException
                If Lang = 1 Then
                    MessageBox.Show("Dit product staat niet op de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Ce produit n'est pas dans la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub btnRefreshProducts_Click(sender As Object, e As EventArgs) Handles btnRefreshProducts.Click
        PRODUCTSTableAdapter.Fill(DORADbDS.PRODUCTS)
        PRODUCTSBindingSource.Sort = "[SHORT NAME] ASC"
        cmbProductName.DataSource = PRODUCTSBindingSource
        cmbProductName.SelectedIndex = -1
    End Sub
    Private Sub dgvProd_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProd.CellClick
        'Display selected row in textboxes and comboboxes
        cmbDrug.Text = CStr(dgvProd.Item(0, dgvProd.CurrentRow.Index).Value)
        cmbMethod.Text = CStr(dgvProd.Item(1, dgvProd.CurrentRow.Index).Value)
        cmbStep.Text = CStr(dgvProd.Item(2, dgvProd.CurrentRow.Index).Value)
        dgvMembersInt.ClearSelection()
        dgvProductsInt.ClearSelection()
    End Sub
    Private Sub InitDrugsInt()
        'Initialize textboxes and comboboxes
        cmbDrug.Text = String.Empty
        cmbMethod.Text = String.Empty
        cmbStep.Text = String.Empty
    End Sub
    Private Sub btnAddDrug_Click(sender As Object, e As EventArgs) Handles btnAddDrug.Click
        'Add new record
        If cmbDrug.Text <> String.Empty Then
            Try
                Dim NewDrugRow As DataRow = DORADbDS.Tables("DRUGS INT").NewRow()
                NewDrugRow("ID INT") = IntNum
                NewDrugRow("DRUG") = cmbDrug.Text
                NewDrugRow("METHOD") = cmbMethod.Text
                NewDrugRow("STEP") = cmbStep.Text
                DORADbDS.Tables("DRUGS INT").Rows.Add(NewDrugRow)
                dgvProd.Refresh()
                InitDrugsInt()
                dgvProd.ClearSelection()
                dgvProd.Sort(dgvProd.Columns(0), ListSortDirection.Ascending)
            Catch exCE As ConstraintException
                If Lang = 1 Then
                    MessageBox.Show("Deze drug is al toegevoegd", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Cette drogue a déjà été ajouté", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub btnSaveDrug_Click(sender As Object, e As EventArgs) Handles btnSaveDrug.Click
        'Save current record
        If cmbDrug.Text <> String.Empty Then
            Try
                Dim DrugRow() As DataRow = DORADbDS.Tables("DRUGS INT").Select($"[ID] = '{dgvProd.Item(3, dgvProd.CurrentRow.Index).Value}'")
                DrugRow(0)("DRUG") = cmbDrug.Text
                DrugRow(0)("METHOD") = cmbMethod.Text
                DrugRow(0)("STEP") = cmbStep.Text
                dgvProd.Refresh()
                InitDrugsInt()
            Catch exIOORE As IndexOutOfRangeException
                If Lang = 1 Then
                    MessageBox.Show("Dit productie staat niet op de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Cette production n'est pas dans la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                If Lang = 1 Then
                    MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try
        End If
    End Sub
    Private Sub btnDeleteDrug_Click(sender As Object, e As EventArgs) Handles btnDeleteDrug.Click
        'Delete current record
        If cmbDrug.Text <> String.Empty Then
            Try
                Dim DrugRow() As DataRow = DORADbDS.Tables("DRUGS INT").Select($"[DRUG] = '{cmbDrug.Text}' AND [METHOD] = '{cmbMethod.Text}' AND [STEP] = '{cmbStep.Text}' AND [ID INT] = {IntNum}")
                DrugRow(0).Delete()
                dgvProd.Refresh()
                InitDrugsInt()
                dgvProd.ClearSelection()
            Catch exIOORE As IndexOutOfRangeException
                If Lang = 1 Then
                    MessageBox.Show("Deze drug staat niet op de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Cette drogue n'est pas dans la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub cmbDrug_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDrug.SelectedIndexChanged
        'Fill "Method" combobox depending on user's drug choice
        cmbMethod.Items.Clear()
        cmbMethod.Text = String.Empty
        cmbStep.Items.Clear()
        cmbStep.Text = String.Empty
        If IntLang = "Nederlands" Then
            Select Case cmbDrug.SelectedIndex
                'MDMA
                Case 0
                    cmbMethod.DropDownWidth = 160
                    cmbMethod.Enabled = True
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbMethod.Items.Add("Reductieve aminering")
                    cmbMethod.Items.Add("Druks reactie")
                    cmbMethod.Items.Add("Koude methode")
                    cmbMethod.Items.Add("Aluminium amalgaam")
                    cmbMethod.Items.Add("Andere")
                    cmbStep.Items.Add("Kristallisatie")
                    cmbStep.Items.Add("Tabletteren")
                'Amphetamine
                Case 1
                    cmbMethod.DropDownWidth = 160
                    cmbMethod.Enabled = True
                    cmbStep.Enabled = False
                    cmbStep.DropDownWidth = 128
                    cmbMethod.Items.Add("Leuckart methode")
                    cmbMethod.Items.Add("Loog methode")
                    cmbMethod.Items.Add("Reductive aminering")
                    cmbMethod.Items.Add("Andere")
                'Methamphetamine
                Case 2
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = True
                    cmbStep.Enabled = False
                    cmbStep.DropDownWidth = 128
                    cmbMethod.Items.Add("Leuckart methode")
                    cmbMethod.Items.Add("Reductieve aminering")
                    cmbMethod.Items.Add("Rode fosfor")
                    cmbMethod.Items.Add("Andere")
                'Pre-precursors
                Case 3
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = True
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbMethod.Items.Add("BMK productie")
                    cmbMethod.Items.Add("PMK productie")
                    cmbStep.Items.Add("Conversie")
                    cmbStep.Items.Add("Destillatie")
                'Cannabis
                Case 4
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Kultuur")
                    cmbStep.Items.Add("Drooging")
                    cmbStep.Items.Add("Verpakking")
                'Cocaïne
                Case 5
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Extractie")
                    cmbStep.Items.Add("Versnijding")
                    cmbStep.Items.Add("Verpakking")
                'Heroïne
                Case 6
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = False
                'NPS
                Case 7
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Mengelen")
                    cmbStep.Items.Add("Verpakking")
                'Ketamine
                Case 8
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = False
                'GHB
                Case 9
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = False
                'Other
                Case 10
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = False
            End Select
        Else
            Select Case cmbDrug.SelectedIndex
                'MDMA
                Case 0
                    cmbMethod.DropDownWidth = 160
                    cmbMethod.Enabled = True
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbMethod.Items.Add("Amination réductive")
                    cmbMethod.Items.Add("Méthode à pression")
                    cmbMethod.Items.Add("Méthode à froid")
                    cmbMethod.Items.Add("Aluminium amalgame")
                    cmbMethod.Items.Add("Autre")
                    cmbStep.Items.Add("Cristallisation")
                    cmbStep.Items.Add("Tablettage")
                'Amphetamine
                Case 1
                    cmbMethod.DropDownWidth = 160
                    cmbMethod.Enabled = True
                    cmbStep.Enabled = False
                    cmbStep.DropDownWidth = 128
                    cmbMethod.Items.Add("Méthode de Leuckart")
                    cmbMethod.Items.Add("Loog methode")
                    cmbMethod.Items.Add("Amination réductive")
                    cmbMethod.Items.Add("Autre")
                'Methamphetamine
                Case 2
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = True
                    cmbStep.Enabled = False
                    cmbStep.DropDownWidth = 128
                    cmbMethod.Items.Add("Méthode de Leuckart")
                    cmbMethod.Items.Add("Amination réductive")
                    cmbMethod.Items.Add("Phosphore rouge")
                    cmbMethod.Items.Add("Autre")
                'Pre-precursors
                Case 3
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = True
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbMethod.Items.Add("BMK production")
                    cmbMethod.Items.Add("PMK production")
                    cmbStep.Items.Add("Conversion")
                    cmbStep.Items.Add("Distillation")
                'Cannabis
                Case 4
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Culture")
                    cmbStep.Items.Add("Séchage")
                    cmbStep.Items.Add("Conditionnement")
                'Cocaïne
                Case 5
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Extraction")
                    cmbStep.Items.Add("Coupe")
                    cmbStep.Items.Add("Conditionnement")
                'Heroïne
                Case 6
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = False
                'NPS
                Case 7
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Mélange")
                    cmbStep.Items.Add("Conditionnement")
                'Ketamine
                Case 8
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = False
                'GHB
                Case 9
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = False
                'Other
                Case 10
                    cmbMethod.DropDownWidth = 136
                    cmbMethod.Enabled = False
                    cmbStep.Enabled = False
            End Select
        End If
    End Sub
    Private Sub cmbMethod_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMethod.SelectedValueChanged
        'Fill "Step" combobox depending on user's method choice
        cmbStep.Items.Clear()
        If IntLang = "Nederlands" Then
            Select Case cmbMethod.Text
                Case "Reductieve aminering", "Amination réductive"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Reactie")
                    cmbStep.Items.Add("Destillatie")
                    cmbStep.Items.Add("Kristallisatie")
                Case "Druks reactie", "Méthode à pression"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Reactie")
                    cmbStep.Items.Add("Destillatie")
                    cmbStep.Items.Add("Kristallisatie")
                    cmbStep.Items.Add("Tabletteren")
                Case "Koude methode", "Méthode à froid"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 160
                    cmbStep.Items.Add("Reactie")
                    cmbStep.Items.Add("Scheiding / Destillatie")
                    cmbStep.Items.Add("Kristallisatie")
                    cmbStep.Items.Add("Tabletteren")
                Case "Aluminium amalgaam", "Aluminium amalgame"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Reactie")
                    cmbStep.Items.Add("Scheiding")
                    cmbStep.Items.Add("Destillatie")
                    cmbStep.Items.Add("Kristallisatie")
                    cmbStep.Items.Add("Tabletteren")
                Case "Leuckart methode", "Méthode de Leuckart"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Eerste kookstap")
                    cmbStep.Items.Add("Tweede kookstap")
                    cmbStep.Items.Add("Scheiding")
                    cmbStep.Items.Add("Destillatie")
                    cmbStep.Items.Add("Kristallisatie")
                Case "Loog methode"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Eerste kookstap")
                    cmbStep.Items.Add("Tweede kookstap")
                    cmbStep.Items.Add("Destillatie")
                    cmbStep.Items.Add("Kristallisatie")
                Case "Rode fosfor", "Phosphore rouge"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 160
                    cmbStep.Items.Add("Reactie")
                    cmbStep.Items.Add("Scheiding / Destillatie")
                    cmbStep.Items.Add("Kristallisatie")
                Case "BMK productie", "BMK production"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Conversie")
                    cmbStep.Items.Add("Destillatie")
                Case "PMK productie", "PMK production"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Conversie")
                    cmbStep.Items.Add("Destillatie")
                Case "Andere", "Autre"
                    cmbStep.Enabled = False
            End Select
        Else
            Select Case cmbMethod.Text
                Case "Reductieve aminering", "Amination réductive"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Réaction")
                    cmbStep.Items.Add("Distillation")
                    cmbStep.Items.Add("Cristallisation")
                Case "Druks reactie", "Méthode à pression"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Réaction")
                    cmbStep.Items.Add("Distillation")
                    cmbStep.Items.Add("Cristallisation")
                    cmbStep.Items.Add("Tablettage")
                Case "Koude methode", "Méthode à froid"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 160
                    cmbStep.Items.Add("Réaction")
                    cmbStep.Items.Add("Séparation / Distillation")
                    cmbStep.Items.Add("Cristallisation")
                    cmbStep.Items.Add("Tablettage")
                Case "Aluminium amalgaam", "Aluminium amalgame"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Réaction")
                    cmbStep.Items.Add("Séparation")
                    cmbStep.Items.Add("Distillation")
                    cmbStep.Items.Add("Cristallisation")
                    cmbStep.Items.Add("Tablettage")
                Case "Leuckart methode", "Méthode de Leuckart"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Première cuisson")
                    cmbStep.Items.Add("Seconde cuisson")
                    cmbStep.Items.Add("Séparation")
                    cmbStep.Items.Add("Distillation")
                    cmbStep.Items.Add("Cristallisation")
                Case "Loog methode"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Première cuisson")
                    cmbStep.Items.Add("Seconde cuisson")
                    cmbStep.Items.Add("Distillation")
                    cmbStep.Items.Add("Cristallisation")
                Case "Rode fosfor", "Phosphore rouge"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 160
                    cmbStep.Items.Add("Réaction")
                    cmbStep.Items.Add("Séparation / Distillation")
                    cmbStep.Items.Add("Cristallisation")
                Case "BMK productie", "BMK production"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Conversion")
                    cmbStep.Items.Add("Distillation")
                Case "PMK productie", "PMK production"
                    cmbStep.Enabled = True
                    cmbStep.DropDownWidth = 128
                    cmbStep.Items.Add("Conversion")
                    cmbStep.Items.Add("Distillation")
                Case "Andere", "Autre"
                    cmbStep.Enabled = False
            End Select
        End If
    End Sub
#End Region
#Region "Dates"
    Private Sub btnClearDateCRU_Click(sender As Object, e As EventArgs) Handles btnClearDateCRU.Click
        'Clear date field
        txtCRUReportDate.Format = DateTimePickerFormat.Custom
        txtCRUReportDate.CustomFormat = " "
        Dim IntRow() As DataRow = DORADbDS.Tables("INTERVENTIONS").Select($"[ID CRU] = {IntNum}")
        IntRow(0)("CRU REPORT DATE") = DBNull.Value
    End Sub
    Private Sub btnClearDateNICC_Click(sender As Object, e As EventArgs) Handles btnClearDateNICC.Click
        'Clear date field
        txtNICCReportDate.Format = DateTimePickerFormat.Custom
        txtNICCReportDate.CustomFormat = " "
        Dim IntRow() As DataRow = DORADbDS.Tables("INTERVENTIONS").Select($"[ID CRU] = {IntNum}")
        IntRow(0)("NICC REPORT DATE") = DBNull.Value
    End Sub
    Private Sub btnClearDateSamples_Click(sender As Object, e As EventArgs) Handles btnClearDateSamples.Click
        'Clear date field
        txtSamplesDate.Format = DateTimePickerFormat.Custom
        txtSamplesDate.CustomFormat = " "
        Dim IntRow() As DataRow = DORADbDS.Tables("INTERVENTIONS").Select($"[ID CRU] = {IntNum}")
        IntRow(0)("SAMPLES DELIVERY DATE") = DBNull.Value
    End Sub
    Private Sub txtDate1_ValueChanged(sender As Object, e As EventArgs) Handles txtDate1.ValueChanged
        'If date entered, display it
        txtDate1.Format = DateTimePickerFormat.Custom
        txtDate1.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub txtDate2_ValueChanged(sender As Object, e As EventArgs) Handles txtDate2.ValueChanged
        'If date entered, display it
        If txtDate1.Text <> " " AndAlso txtDate2.Value >= txtDate1.Value Then
            txtDate2.Format = DateTimePickerFormat.Custom
            txtDate2.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub
    Private Sub txtDate3_ValueChanged(sender As Object, e As EventArgs) Handles txtDate3.ValueChanged
        'If date entered, display it
        If txtDate2.Text <> " " AndAlso txtDate3.Value >= txtDate2.Value Then
            txtDate3.Format = DateTimePickerFormat.Custom
            txtDate3.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub
    Private Sub btnClearDate1_Click(sender As Object, e As EventArgs) Handles btnClearDate1.Click
        'Clear date and times fields
        txtDate1.Format = DateTimePickerFormat.Custom
        txtDate1.CustomFormat = " "
        txtTime1.Text = String.Empty
        txtTime2.Text = String.Empty
        CalculateTime()
        Dim IntRow() As DataRow = DORADbDS.Tables("INTERVENTIONS").Select($"[ID CRU] = {IntNum}")
        IntRow(0)("DATE 1") = DBNull.Value
        IntRow(0)("TIME 1") = String.Empty
        IntRow(0)("TIME 2") = String.Empty
    End Sub
    Private Sub btnClearDate2_Click(sender As Object, e As EventArgs) Handles btnClearDate2.Click
        'Clear date and times fields
        txtDate2.Format = DateTimePickerFormat.Custom
        txtDate2.CustomFormat = " "
        txtTime3.Text = String.Empty
        txtTime4.Text = String.Empty
        CalculateTime()
        Dim IntRow() As DataRow = DORADbDS.Tables("INTERVENTIONS").Select($"[ID CRU] = {IntNum}")
        IntRow(0)("DATE 2") = DBNull.Value
        IntRow(0)("TIME 3") = String.Empty
        IntRow(0)("TIME 4") = String.Empty
    End Sub
    Private Sub btnClearDate3_Click(sender As Object, e As EventArgs) Handles btnClearDate3.Click
        'Clear date and times fields
        txtDate3.Format = DateTimePickerFormat.Custom
        txtDate3.CustomFormat = " "
        txtTime5.Text = String.Empty
        txtTime6.Text = String.Empty
        CalculateTime()
        Dim IntRow() As DataRow = DORADbDS.Tables("INTERVENTIONS").Select($"[ID CRU] = {IntNum}")
        IntRow(0)("DATE 3") = DBNull.Value
        IntRow(0)("TIME 5") = String.Empty
        IntRow(0)("TIME 6") = String.Empty
    End Sub
    Private Sub txtTime1_Leave(sender As Object, e As EventArgs) Handles txtTime1.Leave
        'Update time
        CalculateTime()
    End Sub
    Private Sub txtTime2_Leave(sender As Object, e As EventArgs) Handles txtTime2.Leave
        'Update time
        CalculateTime()
    End Sub
    Private Sub txtTime3_Leave(sender As Object, e As EventArgs) Handles txtTime3.Leave
        'Update time
        CalculateTime()
    End Sub
    Private Sub txtTime4_Leave(sender As Object, e As EventArgs) Handles txtTime4.Leave
        'Update time
        CalculateTime()
    End Sub
    Private Sub txtTime5_Leave(sender As Object, e As EventArgs) Handles txtTime5.Leave
        'Update time
        CalculateTime()
    End Sub
    Private Sub txtTime6_Leave(sender As Object, e As EventArgs) Handles txtTime6.Leave
        'Update time
        CalculateTime()
    End Sub
    Private Sub CalculateTime()
        'Calculate total time spent on intervention
        Try
            If txtTime1.MaskCompleted = True AndAlso txtTime2.MaskCompleted = True Then
                If txtTime3.MaskCompleted = True AndAlso txtTime4.MaskCompleted = True Then
                    If txtTime5.MaskCompleted = True AndAlso txtTime6.MaskCompleted = True Then
                        Dim date1 As Date = Date.Parse(CStr(txtDate1.Value))
                        Dim date2 As Date = Date.Parse(CStr(txtDate2.Value))
                        Dim date3 As Date = Date.Parse(CStr(txtDate3.Value))
                        Dim time1 As Date = Date.ParseExact(txtTime1.Text, "HH:mm", CultureInfo.InvariantCulture)
                        Dim time2 As Date = Date.ParseExact(txtTime2.Text, "HH:mm", CultureInfo.InvariantCulture)
                        Dim time3 As Date = Date.ParseExact(txtTime3.Text, "HH:mm", CultureInfo.InvariantCulture)
                        Dim time4 As Date = Date.ParseExact(txtTime4.Text, "HH:mm", CultureInfo.InvariantCulture)
                        Dim time5 As Date = Date.ParseExact(txtTime5.Text, "HH:mm", CultureInfo.InvariantCulture)
                        Dim time6 As Date = Date.ParseExact(txtTime6.Text, "HH:mm", CultureInfo.InvariantCulture)
                        Dim dt1 As Date = New Date(date1.Year, date1.Month, date1.Day, time1.Hour, time1.Minute, 0, 0)
                        Dim dt2 As Date = New Date(date1.Year, date1.Month, date1.Day, time2.Hour, time2.Minute, 0, 0)
                        Dim dt3 As Date = New Date(date2.Year, date2.Month, date2.Day, time3.Hour, time3.Minute, 0, 0)
                        Dim dt4 As Date = New Date(date2.Year, date2.Month, date2.Day, time4.Hour, time4.Minute, 0, 0)
                        Dim dt5 As Date = New Date(date3.Year, date3.Month, date3.Day, time5.Hour, time5.Minute, 0, 0)
                        Dim dt6 As Date = New Date(date3.Year, date3.Month, date3.Day, time6.Hour, time6.Minute, 0, 0)
                        If time2 < time1 Then
                            dt2 = dt2.AddDays(1)
                        End If
                        If time4 < time3 Then
                            dt4 = dt4.AddDays(1)
                        End If
                        If time6 < time5 Then
                            dt6 = dt6.AddDays(1)
                        End If
                        Dim dttot As TimeSpan = dt6.Subtract(dt5) + dt4.Subtract(dt3) + dt2.Subtract(dt1)
                        txtTime.Text = String.Format("{0:00}:{1:00}", Int(dttot.TotalHours), dttot.Minutes)
                    Else
                        Dim date1 As Date = Date.Parse(CStr(txtDate1.Value))
                        Dim date2 As Date = Date.Parse(CStr(txtDate2.Value))
                        Dim time1 As Date = Date.ParseExact(txtTime1.Text, "HH:mm", CultureInfo.InvariantCulture)
                        Dim time2 As Date = Date.ParseExact(txtTime2.Text, "HH:mm", CultureInfo.InvariantCulture)
                        Dim time3 As Date = Date.ParseExact(txtTime3.Text, "HH:mm", CultureInfo.InvariantCulture)
                        Dim time4 As Date = Date.ParseExact(txtTime4.Text, "HH:mm", CultureInfo.InvariantCulture)
                        Dim dt1 As Date = New Date(date1.Year, date1.Month, date1.Day, time1.Hour, time1.Minute, 0, 0)
                        Dim dt2 As Date = New Date(date1.Year, date1.Month, date1.Day, time2.Hour, time2.Minute, 0, 0)
                        Dim dt3 As Date = New Date(date2.Year, date2.Month, date2.Day, time3.Hour, time3.Minute, 0, 0)
                        Dim dt4 As Date = New Date(date2.Year, date2.Month, date2.Day, time4.Hour, time4.Minute, 0, 0)
                        If time2 < time1 Then
                            dt2 = dt2.AddDays(1)
                        End If
                        If time4 < time3 Then
                            dt4 = dt4.AddDays(1)
                        End If
                        Dim dttot As TimeSpan = dt4.Subtract(dt3) + dt2.Subtract(dt1)
                        txtTime.Text = String.Format("{0:00}:{1:00}", Int(dttot.TotalHours), dttot.Minutes)
                    End If
                Else
                    Dim date1 As Date = Date.Parse(CStr(txtDate1.Value))
                    Dim time1 As Date = Date.ParseExact(txtTime1.Text, "HH:mm", CultureInfo.InvariantCulture)
                    Dim time2 As Date = Date.ParseExact(txtTime2.Text, "HH:mm", CultureInfo.InvariantCulture)
                    Dim dt1 As Date = New Date(date1.Year, date1.Month, date1.Day, time1.Hour, time1.Minute, 0, 0)
                    Dim dt2 As Date = New Date(date1.Year, date1.Month, date1.Day, time2.Hour, time2.Minute, 0, 0)
                    If time2 < time1 Then
                        dt2 = dt2.AddDays(1)
                    End If
                    Dim dttot As TimeSpan = dt2.Subtract(dt1)
                    txtTime.Text = String.Format("{0:00}:{1:00}", Int(dttot.TotalHours), dttot.Minutes)
                End If
            Else
                txtTime.Text = String.Empty
            End If
        Catch exF As FormatException
            If Lang = 1 Then
                MessageBox.Show("Verkeerd formaat", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Format erroné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub txtTime1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTime1.KeyPress
        'Disable input if no date is entered and check if time is valid
        If txtDate1.Text = " " Then
            e.KeyChar = CChar(String.Empty)
        End If
        If txtTime1.SelectionStart = 0 Then
            If Asc(e.KeyChar) > 50 Then
                e.KeyChar = CChar(String.Empty)
            End If
        End If
        If txtTime1.SelectionStart = 1 Then
            If txtTime1.Text.Substring(0, 1) = "2" Then
                If Asc(e.KeyChar) > 51 Then
                    e.KeyChar = CChar(String.Empty)
                End If
            End If
        End If
        If txtTime1.SelectionStart = 2 Then
            If Asc(e.KeyChar) > 53 Then
                e.KeyChar = CChar(String.Empty)
            End If
        End If
        If txtTime1.SelectionStart = 4 Then
            txtTime2.Focus()
        End If
    End Sub
    Private Sub txtTime2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTime2.KeyPress
        'Disable input if no start time is entered and check if time is valid
        If txtTime1.MaskCompleted = False Then
            e.KeyChar = CChar(String.Empty)
        End If
        If txtTime2.SelectionStart = 0 Then
            If Asc(e.KeyChar) > 50 Then
                e.KeyChar = CChar(String.Empty)
            End If
        End If
        If txtTime2.SelectionStart = 1 Then
            If txtTime2.Text.Substring(0, 1) = "2" Then
                If Asc(e.KeyChar) > 51 Then
                    e.KeyChar = CChar(String.Empty)
                End If
            End If
        End If
        If txtTime2.SelectionStart = 2 Then
            If Asc(e.KeyChar) > 53 Then
                e.KeyChar = CChar(String.Empty)
            End If
        End If
    End Sub
    Private Sub txtTime3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTime3.KeyPress
        'Disable input if no date is entered and check if time is valid
        If txtDate2.Text = " " Then
            e.KeyChar = CChar(String.Empty)
        End If
        If txtTime3.SelectionStart = 0 Then
            If Asc(e.KeyChar) > 50 Then
                e.KeyChar = CChar(String.Empty)
            End If
        End If
        If txtTime3.SelectionStart = 1 Then
            If txtTime3.Text.Substring(0, 1) = "2" Then
                If Asc(e.KeyChar) > 51 Then
                    e.KeyChar = CChar(String.Empty)
                End If
            End If
        End If
        If txtTime3.SelectionStart = 2 Then
            If Asc(e.KeyChar) > 53 Then
                e.KeyChar = CChar(String.Empty)
            End If
        End If
        If txtTime3.SelectionStart = 4 Then
            txtTime4.Focus()
        End If
    End Sub
    Private Sub txtTime4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTime4.KeyPress
        'Disable input if no start time is entered and check if time is valid
        If txtTime3.MaskCompleted = False Then
            e.KeyChar = CChar(String.Empty)
        End If
        If txtTime4.SelectionStart = 0 Then
            If Asc(e.KeyChar) > 50 Then
                e.KeyChar = CChar(String.Empty)
            End If
        End If
        If txtTime4.SelectionStart = 1 Then
            If txtTime4.Text.Substring(0, 1) = "2" Then
                If Asc(e.KeyChar) > 51 Then
                    e.KeyChar = CChar(String.Empty)
                End If
            End If
        End If
        If txtTime4.SelectionStart = 2 Then
            If Asc(e.KeyChar) > 53 Then
                e.KeyChar = CChar(String.Empty)
            End If
        End If
    End Sub
    Private Sub txtTime5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTime5.KeyPress
        'Disable input if no date is entered and check if time is valid
        If txtDate3.Text = " " Then
            e.KeyChar = CChar(String.Empty)
        End If
        If txtTime5.SelectionStart = 0 Then
            If Asc(e.KeyChar) > 50 Then
                e.KeyChar = CChar(String.Empty)
            End If
        End If
        If txtTime5.SelectionStart = 1 Then
            If txtTime5.Text.Substring(0, 1) = "2" Then
                If Asc(e.KeyChar) > 51 Then
                    e.KeyChar = CChar(String.Empty)
                End If
            End If
        End If
        If txtTime5.SelectionStart = 2 Then
            If Asc(e.KeyChar) > 53 Then
                e.KeyChar = CChar(String.Empty)
            End If
        End If
        If txtTime5.SelectionStart = 4 Then
            txtTime6.Focus()
        End If
    End Sub
    Private Sub txtTime6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTime6.KeyPress
        'Disable input if no start time is entered and check if time is valid
        If txtTime5.MaskCompleted = False Then
            e.KeyChar = CChar(String.Empty)
        End If
        If txtTime6.SelectionStart = 0 Then
            If Asc(e.KeyChar) > 50 Then
                e.KeyChar = CChar(String.Empty)
            End If
        End If
        If txtTime6.SelectionStart = 1 Then
            If txtTime6.Text.Substring(0, 1) = "2" Then
                If Asc(e.KeyChar) > 51 Then
                    e.KeyChar = CChar(String.Empty)
                End If
            End If
        End If
        If txtTime6.SelectionStart = 2 Then
            If Asc(e.KeyChar) > 53 Then
                e.KeyChar = CChar(String.Empty)
            End If
        End If
    End Sub
    Private Sub txtCRUReportDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCRUReportDate.KeyPress
        'Format date field
        If Asc(e.KeyChar) = 8 Then
            txtCRUReportDate.Format = DateTimePickerFormat.Custom
            txtCRUReportDate.CustomFormat = " "
            Dim CaseRow() As DataRow = DORADbDS.Tables("INTERVENTIONS").Select($"[ID CRU] = {IntNum}")
            CaseRow(0)("CRU REPORT DATE") = DBNull.Value
        End If
    End Sub
    Private Sub txtNICCReportDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNICCReportDate.KeyPress
        'Format date field
        If Asc(e.KeyChar) = 8 Then
            txtNICCReportDate.Format = DateTimePickerFormat.Custom
            txtNICCReportDate.CustomFormat = " "
            Dim CaseRow() As DataRow = DORADbDS.Tables("INTERVENTIONS").Select($"[ID CRU] = {IntNum}")
            CaseRow(0)("NICC REPORT DATE") = DBNull.Value
        End If
    End Sub
    Private Sub txtSamplesDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSamplesDate.KeyPress
        'Format date field
        If Asc(e.KeyChar) = 8 Then
            txtSamplesDate.Format = DateTimePickerFormat.Custom
            txtSamplesDate.CustomFormat = " "
            Dim CaseRow() As DataRow = DORADbDS.Tables("INTERVENTIONS").Select($"[ID CRU] = {IntNum}")
            CaseRow(0)("SAMPLES DELIVERY DATE") = DBNull.Value
        End If
    End Sub
    Private Sub txtCRUReportDate_ValueChanged(sender As Object, e As EventArgs) Handles txtCRUReportDate.ValueChanged
        'If date entered, display it
        txtCRUReportDate.Format = DateTimePickerFormat.Custom
        txtCRUReportDate.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub txtNICCReportDate_ValueChanged(sender As Object, e As EventArgs) Handles txtNICCReportDate.ValueChanged
        'If date entered, display it
        txtNICCReportDate.Format = DateTimePickerFormat.Custom
        txtNICCReportDate.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub txtSamplesDate_ValueChanged(sender As Object, e As EventArgs) Handles txtSamplesDate.ValueChanged
        'If date entered, display it
        txtSamplesDate.Format = DateTimePickerFormat.Custom
        txtSamplesDate.CustomFormat = "dd/MM/yyyy"
    End Sub
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
#Region "Adresses"
    Private Sub HandleEmptyZip()
        'Fill zip field if empty
        If txtZipInt.Text = String.Empty Then
            Dim index As Integer = frmMain.CITIESBindingSource1.Find("CITY", cmbCityInt.Text)
            frmMain.CITIESBindingSource1.Position = index
            Dim zip As Integer = CInt(DirectCast(frmMain.CITIESBindingSource1.Current, DataRowView).Item("ZIP CODE"))
            txtZipInt.Text = CStr(zip)
        End If
        If txtZipFacts.Text = String.Empty Then
            Dim index As Integer = frmMain.CITIESBindingSource1.Find("CITY", cmbCityFacts.Text)
            frmMain.CITIESBindingSource1.Position = index
            Dim zip As Integer = CInt(DirectCast(frmMain.CITIESBindingSource1.Current, DataRowView).Item("ZIP CODE"))
            txtZipFacts.Text = CStr(zip)
        End If
    End Sub
    Private Sub txtAdressInt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdressInt.KeyPress
        'Disable special characters
        If (Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> "'") Then
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
        frmMain.CITIESBindingSource1.Position = frmMain.CITIESBindingSource1.Find("CITY", cmbCityInt.Text)
        City = CStr(DirectCast(frmMain.CITIESBindingSource1.Current, DataRowView).Item("CITY"))
        txtZipInt.Text = CStr(DirectCast(frmMain.CITIESBindingSource1.Current, DataRowView).Item("ZIP CODE"))
    End Sub
    Private Sub txtZipInt_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtZipInt.MouseDoubleClick
        'Reset filter
        frmMain.CITIESBindingSource1.Filter = Nothing
        cmbCityInt.SelectedIndex = -1
        txtZipInt.Text = String.Empty
    End Sub
    Private Sub txtZipInt_TextChanged(sender As Object, e As EventArgs) Handles txtZipInt.TextChanged
        'Filter city combobox with zip code
        If txtZipInt.MaskCompleted = True Then
            frmMain.CITIESBindingSource1.Filter = $"[ZIP CODE]= '{txtZipInt.Text}'"
            frmMain.CITIESBindingSource1.Position = frmMain.CITIESBindingSource1.Find("CITY", City)
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
        If (Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> "'") Then
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
        frmMain.CITIESBindingSource2.Position = frmMain.CITIESBindingSource2.Find("CITY", cmbCityFacts.Text)
        City = CStr(DirectCast(frmMain.CITIESBindingSource2.Current, DataRowView).Item("CITY"))
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
        cmbCityFacts.SelectedIndex = -1
        txtZipFacts.Text = String.Empty
    End Sub
    Private Sub txtZipFacts_TextChanged(sender As Object, e As EventArgs) Handles txtZipFacts.TextChanged
        'Filter city combobox with zip code
        If txtZipFacts.MaskCompleted = True Then
            frmMain.CITIESBindingSource2.Filter = $"[ZIP CODE]= '{txtZipFacts.Text}'"
            frmMain.CITIESBindingSource2.Position = frmMain.CITIESBindingSource2.Find("CITY", City)
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
    Private Sub cmbInt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbInt.SelectedIndexChanged
        'Hide or show facts adress depending on the intervention
        frmMain.CITIESBindingSource1.Filter = $"[ZIP CODE]= '{txtZipInt.Text}'"
        frmMain.CITIESBindingSource2.Filter = $"[ZIP CODE]= '{txtZipFacts.Text}'"
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
        txtDateFacts.Text = txtDateInt.Text
        cmbCityFacts.Text = cmbCityInt.Text
        txtZipFacts.Text = txtZipInt.Text
        txtAdressFacts.Text = txtAdressInt.Text
    End Sub
    Private Sub btnFactsToInt_Click(sender As Object, e As EventArgs) Handles btnFactsToInt.Click
        txtDateInt.Text = txtDateFacts.Text
        cmbCityInt.Text = cmbCityFacts.Text
        txtZipInt.Text = txtZipFacts.Text
        txtAdressInt.Text = txtAdressFacts.Text
    End Sub
#End Region
#Region "Buttons"
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        'Minimize window
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub SetPrevNextIcons()
        If INTERVENTIONSBindingSource.Position = 0 Then
            btnNextCase.Enabled = False
            btnNextCase.IconColor = Color.FromArgb(35, 35, 35)
        Else
            btnNextCase.Enabled = True
            btnNextCase.IconColor = theme("Font")
        End If
        If INTERVENTIONSBindingSource.Position = INTERVENTIONSBindingSource.Count - 1 Then
            btnPrevCase.Enabled = False
            btnPrevCase.IconColor = Color.FromArgb(35, 35, 35)
        Else
            btnPrevCase.Enabled = True
            btnPrevCase.IconColor = theme("Font")
        End If
    End Sub
    Private Sub btnPrevCase_Click(sender As Object, e As EventArgs) Handles btnPrevCase.Click
        'Go to previous intervention from the same case
        Dim Result As DialogResult
        INTERVENTIONSBindingSource.EndEdit()
        MEMBERS_INTBindingSource.EndEdit()
        PRODUCTS_INTBindingSource.EndEdit()
        DRUGS_INTBindingSource.EndEdit()
        File.Delete($"{dora_path}SYSTEM\INT,,{IntNum},,{user}.dat")
        If DORADbDS.HasChanges Then
            If Lang = 1 Then
                Result = MessageBox.Show($"U zult alle niet-opgeslagen wijzigingen verliezen.{Environment.NewLine}Weet u het zeker?", "Weet u het zeker?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Else
                Result = MessageBox.Show($"Vous allez perdre tous les changements non sauvegardés.{Environment.NewLine}Voulez-vous continuer?", "Êtes-vous sûr", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If
            If Result = DialogResult.Yes Then
                INTERVENTIONSBindingSource.MoveNext()
                lblTitle.Text = $"Dossier {CaseName} ({INTERVENTIONSBindingSource.Position + 1}/{INTERVENTIONSBindingSource.Count})"
                IntNum = CInt(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("ID CRU"))
                MEMBERS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
                PRODUCTS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
                DRUGS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
                DORADbDS.RejectChanges()
            End If
        Else
            INTERVENTIONSBindingSource.MoveNext()
            IntNum = CInt(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("ID CRU"))
            lblTitle.Text = $"Dossier {CaseName} ({INTERVENTIONSBindingSource.Count - INTERVENTIONSBindingSource.Position}/{INTERVENTIONSBindingSource.Count})"
            MEMBERS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
            PRODUCTS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
            DRUGS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
        End If
        File.Create($"{dora_path}SYSTEM\INT,,{IntNum},,{user}.dat").Dispose()
        SetPrevNextIcons()
        PathInt = $"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {txtDateInt.Value:dd-MM-yy} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})"
        'Hide default date
        HideDefaultDates()
        DisplayTitle()
        UpdateCreation()
        GetPathInt()
        DisplayFolder()
        InitializeDataGridViews()
        handleCheckboxes()
    End Sub
    Private Sub btnNextCase_Click(sender As Object, e As EventArgs) Handles btnNextCase.Click
        'Go to next intervention from the same case
        Dim Result As DialogResult
        INTERVENTIONSBindingSource.EndEdit()
        MEMBERS_INTBindingSource.EndEdit()
        PRODUCTS_INTBindingSource.EndEdit()
        DRUGS_INTBindingSource.EndEdit()
        File.Delete($"{dora_path}SYSTEM\INT,,{IntNum},,{user}.dat")
        If DORADbDS.HasChanges Then
            If Lang = 1 Then
                Result = MessageBox.Show($"U zult alle niet-opgeslagen wijzigingen verliezen.{Environment.NewLine}Weet u het zeker?", "Weet u het zeker?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Else
                Result = MessageBox.Show($"Vous allez perdre tous les changements non sauvegardés.{Environment.NewLine}Voulez-vous continuer?", "Êtes-vous sûr", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If
            If Result = DialogResult.Yes Then
                INTERVENTIONSBindingSource.MovePrevious()
                lblTitle.Text = $"Dossier {CaseName} ({INTERVENTIONSBindingSource.Position + 1}/{INTERVENTIONSBindingSource.Count})"
                IntNum = CInt(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("ID CRU"))
                MEMBERS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
                PRODUCTS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
                DRUGS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
                DORADbDS.RejectChanges()
            End If
        Else
            INTERVENTIONSBindingSource.MovePrevious()
            IntNum = CInt(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("ID CRU"))
            lblTitle.Text = $"Dossier {CaseName} ({INTERVENTIONSBindingSource.Count - INTERVENTIONSBindingSource.Position}/{INTERVENTIONSBindingSource.Count})"
            MEMBERS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
            PRODUCTS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
            DRUGS_INTBindingSource.Filter = $"[ID INT] = {IntNum}"
        End If
        File.Create($"{dora_path}SYSTEM\INT,,{IntNum},,{user}.dat").Dispose()
        SetPrevNextIcons()
        PathInt = $"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {txtDateInt.Value:dd-MM-yy} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})"
        'Hide default date
        HideDefaultDates()
        DisplayTitle()
        UpdateCreation()
        GetPathInt()
        DisplayFolder()
        InitializeDataGridViews()
        handleCheckboxes()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Save changes
        Dim dt As DateTime = Convert.ToDateTime(txtDateInt.Text)
        Dim format As String = "dd-MM-yy"
        Try
            If Directory.Exists(PathInt) Then
                If CRUFile.Substring(0, 3) Like "CRU" AndAlso CInt(CRUFile.Substring(3, 2)) >= CInt("20") Then
                    If PathInt <> $"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})" Then
                        FileIO.FileSystem.RenameDirectory(PathInt, $"INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})")
                        'FileIO.FileSystem.MoveDirectory(PathInt, $"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})")
                        PathInt = $"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})"
                    End If
                ElseIf Not Directory.Exists($"{PathInt}\FOTODOSSIER") Then
                    If CRUFile.Substring(1, 2) = "19" Then
                        If PathInt <> $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}\C.R.U\INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})" Then
                            FileIO.FileSystem.RenameDirectory(PathInt, $"INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})")
                            'FileIO.FileSystem.MoveDirectory(PathInt, $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}\C.R.U\INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})")
                            PathInt = $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}\C.R.U\INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})"
                        End If
                    Else
                        If PathInt <> $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}\C.R.U\INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})" Then
                            FileIO.FileSystem.RenameDirectory(PathInt, $"INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})")
                            'FileIO.FileSystem.MoveDirectory(PathInt, $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}\C.R.U\INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})")
                            PathInt = $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}\C.R.U\INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})"
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            If Lang = 1 Then
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show(ex.ToString, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            txtDateInt.Value = olddate
            cmbTypeOfInt.Text = oldtypeofint
            cmbCityInt.Text = oldcity
            txtAdressInt.Text = oldadress
            Exit Sub
        End Try
        If txtCRUReportNum.MaskCompleted = False Then DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CRU REPORT NUM") = String.Empty
        If txtNICCReportNum.MaskCompleted = False Then DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("NICC REPORT NUM") = String.Empty
        INTERVENTIONSBindingSource.EndEdit()
        INTERVENTIONSTableAdapter.Update(DORADbDS.INTERVENTIONS)
        MEMBERS_INTBindingSource.EndEdit()
        MEMBERS_INTTableAdapter.Update(DORADbDS.MEMBERS_INT)
        PRODUCTS_INTBindingSource.EndEdit()
        PRODUCTS_INTTableAdapter.Update(DORADbDS.PRODUCTS_INT)
        DRUGS_INTBindingSource.EndEdit()
        DRUGS_INTTableAdapter.Update(DORADbDS.DRUGS_INT)
        log("INT.", "click on SAVE")
    End Sub
    Private Sub btnFolder_Click(sender As Object, e As EventArgs) Handles btnFolder.Click
        'Open intervention folder
        Try
            Cursor = Cursors.WaitCursor
            If TypeOfCase <> Nothing And CRUFile <> Nothing Then
                If CRUFile.Substring(0, 3) Like "CRU" AndAlso CInt(CRUFile.Substring(3, 2)) > CInt("19") Then
                    Dim dt As DateTime = Convert.ToDateTime(txtDateInt.Text)
                    Dim format As String = "dd-MM-yy"
                    Process.Start("explorer.exe", $"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})")
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
            Else
                If Lang = 1 Then
                    MessageBox.Show("Map niet gevonden", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Dossier introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            Cursor = Cursors.Default
        Catch exDNF As DirectoryNotFoundException
            If Lang = 1 Then
                MessageBox.Show("Map niet gevonden", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Dossier introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub btnOpenNICCReport_Click(sender As Object, e As EventArgs) Handles btnOpenNICCReport.Click
        If Directory.Exists($"{PathInt}\RESULTAAT ANALYSE") Then
            Dim files As String() = Directory.GetFiles($"{PathInt}\RESULTAAT ANALYSE", "*.pdf")
            For Each f In files
                Process.Start(f)
            Next
        End If
    End Sub
    Private Sub btnIntReport_Click(sender As Object, e As EventArgs) Handles btnIntReport.Click
        Cursor = Cursors.WaitCursor
        Dim oWord As Word.Application = CType(CreateObject("Word.Application"), Word.Application)
        Dim oDoc As Word.Document
        oWord.Visible = False
        'Open template depending on intervention language
        If IntLang = "Nederlands" Then
            oDoc = oWord.Documents.Add($"{dora_path}IntVerslagNL.dotm")
        Else
            oDoc = oWord.Documents.Add($"{dora_path}IntRapportFR.dotm")
        End If
        If IntLang = "Nederlands" Then
            oDoc.Tables(1).Cell(1, 2).Range.Text = $"Datum: {Now.ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-001"))}"
        Else
            oDoc.Tables(1).Cell(1, 2).Range.Text = $"Date: {Now.ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-001"))}"
        End If
        oDoc.Tables(1).Cell(5, 2).Range.Text = CaseName
        oDoc.Tables(1).Cell(6, 2).Range.Text = txtDateInt.Text
        oDoc.Tables(1).Cell(7, 2).Range.Text = txtAdressInt.Text
        oDoc.Tables(1).Cell(8, 2).Range.Text = $"{txtZipInt.Text} - {cmbCityInt.Text}"
        oDoc.Tables(1).Cell(11, 2).Range.Text = cmbSamplesTakenBy.Text
        Dim lstPersonnel As String = String.Empty
        For i As Integer = 0 To dgvMembersInt.Rows.Count - 1
            lstPersonnel += CStr(dgvMembersInt.Rows(i).Cells(0).Value)
            If i < dgvMembersInt.Rows.Count - 1 Then lstPersonnel += " / "
        Next
        oDoc.Tables(1).Cell(15, 2).Range.Text = lstPersonnel
        If txtDate1.Text <> " " Then oDoc.Tables(1).Cell(16, 2).Range.Text = $"{txtDate1.Text}: {txtTime1.Text} - {txtTime2.Text}"
        If txtDate2.Text <> " " Then oDoc.Tables(1).Cell(17, 2).Range.Text = $"{txtDate2.Text}: {txtTime3.Text} - {txtTime4.Text}"
        If txtDate3.Text <> " " Then oDoc.Tables(1).Cell(18, 2).Range.Text = $"{txtDate3.Text}: {txtTime5.Text} - {txtTime6.Text}"
        oDoc.Range.Tables(2).Rows.Alignment = Word.WdRowAlignment.wdAlignRowCenter
        oDoc.Tables(2).AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitFixed)
        Cursor = Cursors.Default
        frmConstat.ShowDialog()
        oDoc.Tables(1).Cell(12, 2).Range.Text = constat
        Using OFD As New OpenFileDialog
            OFD.InitialDirectory = $"{PathInt}\FOTODOSSIER\FOTO'S\HIGH\"
            OFD.Title = "Load..."
            OFD.DefaultExt = ".jpg"
            OFD.Multiselect = True
            If OFD.ShowDialog() = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Dim numP As Integer = OFD.FileNames.Count
                Dim numLC As Integer = 2
                Dim numR As Integer = CInt((Math.Ceiling(OFD.FileNames.Count / 2) * 2))
                Dim i As Integer = 0
                For r As Integer = 1 To numR Step 2
                    If r = numR - 1 Then
                        If numP Mod 2 = 1 Then
                            numLC = 1
                            oDoc.Tables(2).Cell(r, 1).Merge(MergeTo:=oDoc.Tables(2).Cell(r, 2))
                            oDoc.Tables(2).Cell(r + 1, 1).Merge(MergeTo:=oDoc.Tables(2).Cell(r + 1, 2))
                        Else
                            numLC = 2
                        End If
                    End If
                    For c As Integer = 1 To numLC
                        oDoc.Tables(2).Cell(r, c).Range.InlineShapes.AddPicture(FileName:=OFD.FileNames(i))
                        If IntLang = "Nederlands" Then
                            oDoc.Tables(2).Cell(r + 1, c).Range.Text = $"Foto {i + 1}"
                        Else
                            oDoc.Tables(2).Cell(r + 1, c).Range.Text = $"Photo {i + 1}"
                        End If
                        i += 1
                    Next
                Next
                With oWord.ActiveDocument
                    For i = 1 To .InlineShapes.Count
                        With .InlineShapes(i)
                            .LockAspectRatio = CType(True, Microsoft.Office.Core.MsoTriState)
                            .Height = 120
                        End With
                    Next i
                End With
            End If
        End Using
        Dim FinalDoc As String = String.Empty
        Try
            If IntLang = "Nederlands" Then
                FinalDoc = $"{PathInt}\Interventieverslag.docx"
            Else
                FinalDoc = $"{PathInt}\Rapport d'intervention.docx"
            End If
            oDoc.SaveAs2(CStr(FinalDoc))
            log("INT.", "click on INTERVENTION REPORT")
        Catch exDNF As DirectoryNotFoundException
            'If folder not found, ask the user where to create the file
            If Lang = 1 Then
                MessageBox.Show("Map niet gevonden", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Dossier introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Using SFD As New SaveFileDialog
                SFD.InitialDirectory = $"{files_path}"
                SFD.Title = "Save As..."
                If IntLang = "Nederlands" Then
                    SFD.FileName = "Interventieverslag.docx"
                Else
                    SFD.FileName = "Rapport d'intervention.docx"
                End If
                SFD.DefaultExt = ".docx"
                SFD.AddExtension = True
                If SFD.ShowDialog() = DialogResult.OK Then
                    FinalDoc = SFD.FileName
                    oDoc.SaveAs2(CStr(FinalDoc))
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
        oDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges)
        Process.Start(FinalDoc)
        Cursor = Cursors.Default
    End Sub
    Private Sub btnNICC_Click(sender As Object, e As EventArgs) Handles btnNICC.Click
        Cursor = Cursors.WaitCursor
        Dim oWord As Word.Application = CType(CreateObject("Word.Application"), Word.Application)
        Dim oDoc As Word.Document
        oWord.Visible = False
        'Open template
        oDoc = oWord.Documents.Add($"{dora_path}StalenNL.docx")
        'Get number of samples
        InvYear = Year(CDate(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE INT")))
        Dim INV As String = $"INV{InvYear}"
        Dim connection As New OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dora_path}DORAInv.accdb")
        Dim cmd As New OleDbCommand($"SELECT SUM(SAMPLES) FROM {INV} WHERE [IDINT] = {IntNum}", connection)
        Dim count As Integer
        connection.Open()
        count = CInt(cmd.ExecuteScalar())
        connection.Close()
        'Fill document
        oDoc.Tables(1).Cell(1, 1).Range.Text = $"Omcirkel : {cmbTypeOfInt.Text.ToUpper}"
        oDoc.Tables(1).Cell(2, 2).Range.Text = CaseName
        oDoc.Tables(1).Cell(3, 2).Range.Text = txtDateFacts.Text
        oDoc.Tables(1).Cell(4, 2).Range.Text = $"{txtZipFacts.Text} - {cmbCityFacts.Text}{Environment.NewLine}{txtAdressFacts.Text}"
        oDoc.Tables(1).Cell(5, 2).Range.Text = txtDateInt.Text
        oDoc.Tables(1).Cell(6, 2).Range.Text = $"{txtZipInt.Text} - {cmbCityInt.Text}{Environment.NewLine}{txtAdressInt.Text}"
        oDoc.Tables(1).Cell(7, 2).Range.Text = cmbSamplesTakenBy.Text
        oDoc.Tables(1).Cell(8, 2).Range.Text = txtSamplesDate.Text
        Dim CaseRow() As DataRow = DORADbDS.Tables("CASES").Select("[CASE NAME] = '" & CaseName & "'")
        oDoc.Tables(1).Cell(9, 2).Range.Text = CaseRow(0)("REPORT NUM").ToString
        oDoc.Tables(1).Cell(10, 2).Range.Text = txtSamplesCode.Text
        oDoc.Tables(1).Cell(11, 2).Range.Text = CStr(count)
        Dim FinalDoc As String = String.Empty
        Try
            FinalDoc = $"{PathInt}\Stalen.docx"
            oDoc.SaveAs2(CStr(FinalDoc))
        Catch exDNF As DirectoryNotFoundException
            'If folder not found, ask the user where to create the file
            If Lang = 1 Then
                MessageBox.Show("Map niet gevonden", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Dossier introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Using SFD As New SaveFileDialog
                SFD.InitialDirectory = $"{files_path}"
                SFD.Title = "Save As..."
                SFD.FileName = "Stalen.docx"
                SFD.DefaultExt = ".docx"
                SFD.AddExtension = True
                If SFD.ShowDialog() = DialogResult.OK Then
                    FinalDoc = SFD.FileName
                    oDoc.SaveAs2(CStr(FinalDoc))
                    log("INT.", "click on NICC RECEIPT")
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
        oDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges)
        Process.Start(FinalDoc)
        Cursor = Cursors.Default
    End Sub
    Private Sub btnInv_Click(sender As Object, e As EventArgs) Handles btnInv.Click
        'Go to Inventory window
        Dim files As String() = Directory.GetFiles($"{dora_path}SYSTEM", "*.dat")
        For Each f In files
            Dim parts As String() = Split(Path.GetFileNameWithoutExtension(f), ",,")
            If parts(0) = "INV" AndAlso CInt(parts(1)) = IntNum Then
                user_list = UserToList($"{dora_path}cru.txt", parts(2))
                If Lang = 1 Then
                    MessageBox.Show($"Inventaris in gebruik bij {user_list(0)}", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show($"Inventaire en cours d'utilisation par {user_list(0)}", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                InvYear = Year(CDate(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("DATE INT")))
                Cursor = Cursors.WaitCursor
                log("INT.", "click on INVENTORY")
                frmInventory.Show()
                File.Create($"{dora_path}SYSTEM\INV,,{IntNum},,{user}.dat").Dispose()
                Cursor = Cursors.Default
            End If
        Next
    End Sub
    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        'Unlock inventory by deleting dat file
        Dim result As DialogResult
        If Lang = 1 Then
            result = MessageBox.Show($"U zult de inventaris ontgrendelen, wat problemen kan veroorzaken als iemand er mee bezig is.{Environment.NewLine}Weet u het zeker?", "Weet u het zeker?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Else
            result = MessageBox.Show($"Vous allez débloquer l'inventaire, ce qui peut provoquer des erreurs si quelqu'un est occupé avec cet inventaire.{Environment.NewLine}Voulez-vous continuer?", "Êtes-vous sûr", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If
        If result = DialogResult.Yes Then
            File.Delete($"{dora_path}SYSTEM\INV,,{IntNum},,{user}.dat")
            log("INT.", "click on UNLOCK INVENTORY")
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnExit.Click
        'Discard changes and exit window
        Dim Result As DialogResult
        INTERVENTIONSBindingSource.EndEdit()
        MEMBERS_INTBindingSource.EndEdit()
        PRODUCTS_INTBindingSource.EndEdit()
        DRUGS_INTBindingSource.EndEdit()
        If DORADbDS.HasChanges Then
            If Lang = 1 Then
                Result = MessageBox.Show($"U zult alle niet-opgeslagen wijzigingen verliezen.{Environment.NewLine}Weet u het zeker?", "Weet u het zeker?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Else
                Result = MessageBox.Show($"Vous allez perdre tous les changements non sauvegardés.{Environment.NewLine}Voulez-vous continuer?", "Êtes-vous sûr", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If
            If Result = DialogResult.Yes Then
                log("INT.", "click on OK")
                dgvProd.DataSource = Nothing
                dgvMembersInt.DataSource = Nothing
                dgvProductsInt.DataSource = Nothing
                Close()
            Else
                log("CASE", "click on CANCEL")
            End If
        Else
            Close()
        End If
    End Sub
    Private Sub frmIntervention_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.frmIntervention_loc = Location
        log("INT.", "click on CLOSE")
        'Delete int dat file
        If File.Exists($"{dora_path}SYSTEM\INT,,{IntNum},,{user}.dat") Then
            File.Delete($"{dora_path}SYSTEM\INT,,{IntNum},,{user}.dat")
        End If
        If Application.OpenForms().OfType(Of frmInventory).Any Then
            My.Settings.frmInventory_loc = frmInventory.Location
            If File.Exists($"{dora_path}SYSTEM\INV,,{IntNum},,{user}.dat") Then
                File.Delete($"{dora_path}SYSTEM\INV,,{IntNum},,{user}.dat")
            End If
            frmInventory.Close()
        End If
    End Sub
#End Region
#Region "Miscellaneous"
    Private Sub HideControls()
        Dim lst_controls As New List(Of Control)
        For Each c As CheckBox In FindControlRecursive(lst_controls, Me, GetType(CheckBox))
            c.Visible = False
        Next
    End Sub
    Private Sub HideDefaultDates()
        'Hide default dates
        Dim lst_controls As New List(Of DateTimePicker)({txtDate1, txtDate2, txtDate3, txtCRUReportDate, txtNICCReportDate, txtSamplesDate, txtDateInt, txtDateFacts})
        Dim lst_fields As New List(Of String)({"DATE 1", "DATE 2", "DATE 3", "CRU REPORT DATE", "NICC REPORT DATE", "SAMPLES DELIVERY DATE", "DATE INT", "DATE FACTS"})
        For i As Integer = 0 To lst_controls.Count - 1
            HideDate(INTERVENTIONSBindingSource, lst_controls(i), lst_fields(i))
        Next
    End Sub
    Private Sub DisplayTitle()
        btnPrevCase.Location = New Point(50, 60)
        lblTitle.Location = New Point(btnPrevCase.Location.X + 60, 60)
        btnNextCase.Location = New Point(lblTitle.Location.X + lblTitle.Width + 20, 60)
    End Sub
    Private Sub GetPathInt()
        If CRUFile.Substring(0, 3) Like "CRU" AndAlso CInt(CRUFile.Substring(3, 2)) > CInt("19") Then
            Dim dt As Date = Convert.ToDateTime(txtDateInt.Text)
            Dim format As String = "dd-MM-yy"
            PathInt = $"{files_path}20{CRUFile.Substring(3, 2)}\{TypeOfCase}\{CRUFile} - {CaseName}\C.R.U\INT {IntNum} {dt.ToString(format)} - {cmbCityInt.Text} - {txtAdressInt.Text} ({cmbTypeOfInt.Text})"
        ElseIf CRUFile.Substring(1, 2) = "19" Then
            If Directory.Exists($"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}\C.R.U") Then
                PathInt = $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}\C.R.U"
            Else
                PathInt = $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\2019\DISP 2019\{CRUFile}"
            End If
        Else
            If Directory.Exists($"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}\C.R.U") Then
                PathInt = $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}\C.R.U"
            Else
                PathInt = $"G:\DJSOC\DRUGS\0-Ops\A-DISP\A-Fiches\20{CRUFile.Substring(1, 2)}\DISP\{CRUFile}"
            End If
        End If
    End Sub
    Private Sub DisplayFolder()
        If Directory.Exists(PathInt) Then
            btnFolder.IconColor = theme("Font")
        Else
            btnFolder.IconColor = Color.DarkRed
            ToolTip.SetToolTip(btnFolder, PathInt)
        End If
    End Sub
    Private Sub Trad()
        'Translate GUI
        If Lang = 1 Then
            lblTypeOfInt.Text = "Interventietype"
            lblTypeOfPlace.Text = "Plaats"
            lblInt.Text = "Interventie"
            lblDateInt.Text = "Interventie"
            lblDateFacts.Text = "Feiten"
            lblInventory.Text = "Inventaris"
            lblCRUReport.Text = "CRU PV"
            lblPicturesReport.Text = "Fotodossier"
            lblNICCReport.Text = "NICC verslag"
            lblIntervention.Text = "Interventie gesloten"
            lblSamplesTaken.Text = "Genomen door"
            lblSamplesNum.Text = "SIN Nummer"
            lblSamplesDelivery.Text = "Staalnames gedeponeerd op"
            lblSamplesCode.Text = "Code"
            lblNICCConc.Text = "NICC Besluit"
            lblSummary.Text = "Samenvatting van de feiten"
            lbltotal.Text = "Totaal"
            lblProdCap.Text = "Capaciteit"
            lblCRUOnSite.Text = "CRU ter plaatse"
            lblOnSite.Text = "Ter plaatse"
            lblSuspect.Text = "Verdacht(en)"
            lblDischarge.Text = "Lozing"
            lblRecipe.Text = "Recept(en)"
            lblBill.Text = "Factuur(en)"
            lblNote.Text = "Opmerking(en)"
            ToolTip.SetToolTip(btnMin, "Minimaliseer")
            ToolTip.SetToolTip(btnClose, "Sluiten")
            ToolTip.SetToolTip(btnPrevCase, "Vorige interventie")
            ToolTip.SetToolTip(btnNextCase, "Volgende interventie")
            ToolTip.SetToolTip(btnSave, "Opslaan")
            ToolTip.SetToolTip(btnFolder, "Map openen")
            ToolTip.SetToolTip(btnOpenNICCReport, "NICC verslag openen")
            ToolTip.SetToolTip(btnIntReport, "Interventieverslag genereren")
            ToolTip.SetToolTip(btnNICC, "NICC ontvangstbevestiging genereren")
            ToolTip.SetToolTip(btnInv, "Inventaris")
            ToolTip.SetToolTip(btnUnlock, "Inventaris ontgrendelen")
            ToolTip.SetToolTip(btnExit, "Sluiten")
            ToolTip.SetToolTip(btnFactsToInt, "Kopieer de gegevens van de feiten naar de interventie")
            ToolTip.SetToolTip(btnRemondis, "Remondis adres")
            ToolTip.SetToolTip(btnSGS, "SGS adres")
            ToolTip.SetToolTip(btnIntToFacts, "Kopieer de gegevens van de interventie naar de feiten")
            ToolTip.SetToolTip(btnCRUReport, "PV gedaan")
            ToolTip.SetToolTip(btnInventory, "Inventaris gedaan")
            ToolTip.SetToolTip(btnPicturesReport, "Fotodossier gedaan")
            ToolTip.SetToolTip(btnNICCReport, "Ontvangen NICC verslag")
            ToolTip.SetToolTip(btnIntervention, "Gesloten interventie")
            ToolTip.SetToolTip(cmbDrug, "Productie")
            ToolTip.SetToolTip(cmbMethod, "Methode")
            ToolTip.SetToolTip(cmbStep, "Stap")
            ToolTip.SetToolTip(btnCRUOnSite, "Interventie van het CRU")
            ToolTip.SetToolTip(btnAddDrug, "Productietype toevoegen")
            ToolTip.SetToolTip(btnSaveDrug, "Opslaan")
            ToolTip.SetToolTip(btnDeleteDrug, "Verwijderen")
            ToolTip.SetToolTip(btnAddMember, "Personeel toevoegen")
            ToolTip.SetToolTip(btnSaveMember, "Opslaan")
            ToolTip.SetToolTip(btnDeleteMember, "Verwijderen")
            ToolTip.SetToolTip(btnRefreshMembers, "Personeellijst vernieuwen")
            ToolTip.SetToolTip(btnAddProduct, "Product toevoegen")
            ToolTip.SetToolTip(btnSaveProduct, "Opslaan")
            ToolTip.SetToolTip(btnDeleteProduct, "Verwijderen")
            ToolTip.SetToolTip(btnRefreshProducts, "Productenlijst vernieuwen")
            ToolTip.SetToolTip(cmbProductName, $"Om te zoeken tussen de producten, voer een minimum van 3 tekens in en klik dan op de zoekknop.
De lijst wordt gefilterd op basis van uw zoekcriteria en op de namen van de producten in de 3 talen.
Om het filter te resetten, plaatst u de cursor in het lege tekstveld en drukt u op 'backspace'.")
            ToolTip.SetToolTip(btnSearchProduct, "Zoeken")
        Else
            lblTypeOfInt.Text = "Type d'intervention"
            lblTypeOfPlace.Text = "Lieu"
            lblInt.Text = "Intervention"
            lblDateInt.Text = "Intervention"
            lblDateFacts.Text = "Faits"
            lblCRUReport.Text = "PV CRU"
            lblInventory.Text = "Inventaire"
            lblPicturesReport.Text = "Dossier photos"
            lblNICCReport.Text = "Rapport INCC"
            lblIntervention.Text = "Intervention clôturée"
            lblSamplesTaken.Text = "Prélevés par"
            lblSamplesNum.Text = "Numéro SIN"
            lblSamplesDelivery.Text = "Échantillons déposés le"
            lblSamplesCode.Text = "Code"
            lblNICCConc.Text = "Conclusions INCC"
            lblSummary.Text = "Résumé des faits"
            lbltotal.Text = "Total"
            lblProdCap.Text = "Capacité"
            lblCRUOnSite.Text = "Intervention du CRU"
            lblOnSite.Text = "Sur place"
            lblSuspect.Text = "Suspect(s)"
            lblDischarge.Text = "Déversement"
            lblRecipe.Text = "Recette(s)"
            lblBill.Text = "Facture(s)"
            lblNote.Text = "Note(s)"
            ToolTip.SetToolTip(btnMin, "Minimiser")
            ToolTip.SetToolTip(btnClose, "Quitter")
            ToolTip.SetToolTip(btnPrevCase, "Intervention précédente")
            ToolTip.SetToolTip(btnNextCase, "Intervention suivante")
            ToolTip.SetToolTip(btnSave, "Sauvegarder")
            ToolTip.SetToolTip(btnFolder, "Ouvrir le répertoire")
            ToolTip.SetToolTip(btnOpenNICCReport, "Ouvrir le rapport de l'INCC")
            ToolTip.SetToolTip(btnIntReport, "Générer le rapport d'intervention")
            ToolTip.SetToolTip(btnNICC, "Générer l'accusé de réception de l'INCC")
            ToolTip.SetToolTip(btnInv, "Inventaire")
            ToolTip.SetToolTip(btnUnlock, "Débloquer l'inventaire")
            ToolTip.SetToolTip(btnExit, "Quitter")
            ToolTip.SetToolTip(btnFactsToInt, "Copier les données des faits vers l'intervention")
            ToolTip.SetToolTip(btnRemondis, "Adresse de Remondis")
            ToolTip.SetToolTip(btnSGS, "Adresse de SGS")
            ToolTip.SetToolTip(btnIntToFacts, "Copier les données de l'intervention vers les faits")
            ToolTip.SetToolTip(btnCRUReport, "PV terminé")
            ToolTip.SetToolTip(btnInventory, "Inventaire terminé")
            ToolTip.SetToolTip(btnPicturesReport, "Dossier photos terminé")
            ToolTip.SetToolTip(btnNICCReport, "Rapport de l'INCC reçu")
            ToolTip.SetToolTip(btnIntervention, "Intervention clôturée")
            ToolTip.SetToolTip(cmbDrug, "Production")
            ToolTip.SetToolTip(cmbMethod, "Méthode")
            ToolTip.SetToolTip(cmbStep, "Étape")
            ToolTip.SetToolTip(btnCRUOnSite, "CRU présent sur place")
            ToolTip.SetToolTip(btnAddDrug, "Ajouter un type de production")
            ToolTip.SetToolTip(btnSaveDrug, "Sauvegarder")
            ToolTip.SetToolTip(btnDeleteDrug, "Supprimer")
            ToolTip.SetToolTip(btnAddMember, "Ajouter un membre du personnel")
            ToolTip.SetToolTip(btnSaveMember, "Sauvegarder")
            ToolTip.SetToolTip(btnDeleteMember, "Supprimer")
            ToolTip.SetToolTip(btnRefreshMembers, "Recharger la liste du personnel")
            ToolTip.SetToolTip(btnAddProduct, "Ajouter un produit")
            ToolTip.SetToolTip(btnSaveProduct, "Sauvegarder")
            ToolTip.SetToolTip(btnDeleteProduct, "Supprimer")
            ToolTip.SetToolTip(btnRefreshProducts, "Recharger la liste des produits")
            ToolTip.SetToolTip(cmbProductName, $"Pour effectuer une recherche parmi les produits, entrez minimum 3 caractères puis cliquez sur le bouton recherche.
La liste sera filtrée sur base de votre critère de recherche et sur les noms des produits dans les 3 langues.
Pour réinitialiser le filtre, placez le curseur dans le champ de texte vide et appuyez sur 'backspace'.")
            ToolTip.SetToolTip(btnSearchProduct, "Rechercher")
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
            cmbTypeOfPlace.Items.Add("Schip")
            cmbTypeOfPlace.Items.Add("Loods")
            cmbTypeOfPlace.Items.Add("Natuur")
            cmbTypeOfPlace.Items.Add("SGS")
            cmbTypeOfPlace.Items.Add("Remondis")
            cmbInt.Items.Add("Ter plaatse")
            cmbInt.Items.Add("Uitgestelde")
            cmbSamplesTakenBy.Items.Add("CRU")
            cmbSamplesTakenBy.Items.Add("NICC")
            cmbProductUnit.Items.Add("Ltr")
            cmbProductUnit.Items.Add("Kgs")
            cmbProductUnit.Items.Add("Stk")
            cmbProductUnit.Items.Add("Plt")
            cmbDrug.Items.Add("MDMA")
            cmbDrug.Items.Add("Amfetamine")
            cmbDrug.Items.Add("Metamfetamine")
            cmbDrug.Items.Add("(Pre)-Precursors")
            cmbDrug.Items.Add("Cannabis")
            cmbDrug.Items.Add("Cocaïne")
            cmbDrug.Items.Add("Heroïne")
            cmbDrug.Items.Add("NPS")
            cmbDrug.Items.Add("Ketamine")
            cmbDrug.Items.Add("GHB")
            cmbDrug.Items.Add("Andere")
            cmbDrug.Items.Add("Onbekend")
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
            cmbTypeOfPlace.Items.Add("Navire")
            cmbTypeOfPlace.Items.Add("Entrepôt")
            cmbTypeOfPlace.Items.Add("Nature")
            cmbTypeOfPlace.Items.Add("SGS")
            cmbTypeOfPlace.Items.Add("Remondis")
            cmbInt.Items.Add("Sur place")
            cmbInt.Items.Add("Différée")
            cmbSamplesTakenBy.Items.Add("CRU")
            cmbSamplesTakenBy.Items.Add("INCC")
            cmbProductUnit.Items.Add("Ltr")
            cmbProductUnit.Items.Add("Kgs")
            cmbProductUnit.Items.Add("Pcs")
            cmbProductUnit.Items.Add("Plt")
            cmbDrug.Items.Add("MDMA")
            cmbDrug.Items.Add("Amphétamine")
            cmbDrug.Items.Add("Methamphétamine")
            cmbDrug.Items.Add("(Pré)-Précurseurs")
            cmbDrug.Items.Add("Cannabis")
            cmbDrug.Items.Add("Cocaïne")
            cmbDrug.Items.Add("Héroïne")
            cmbDrug.Items.Add("NPS")
            cmbDrug.Items.Add("Kétamine")
            cmbDrug.Items.Add("GHB")
            cmbDrug.Items.Add("Autre")
            cmbDrug.Items.Add("Inconnu")
        End If
    End Sub
    Private Sub UpdateCreation()
        If Lang = 1 Then
            If DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CREATED ON") IsNot DBNull.Value AndAlso CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CREATED BY")) <> String.Empty Then
                lblCreated.Text = $"Angemaakt door {CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CREATED BY"))} op {Format(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CREATED ON"), "dd/MM/yyyy")}"
            Else
                lblCreated.Visible = False
            End If
        Else
            If DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CREATED ON") IsNot DBNull.Value AndAlso CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CREATED BY")) <> String.Empty Then
                lblCreated.Text = $"Créé par {CStr(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CREATED BY"))} le {Format(DirectCast(INTERVENTIONSBindingSource.Current, DataRowView).Item("CREATED ON"), "dd/MM/yyyy")}"
            Else
                lblCreated.Visible = False
            End If
        End If
    End Sub
    Private Sub frmIntervention_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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
        IconPictureBox1.ForeColor = theme("Font")
        IconPictureBox2.ForeColor = theme("Font")
        IconPictureBox3.ForeColor = theme("Font")
        pnlCenter.BackColor = theme("Light")
        For Each c As Control In pnlCenter.Controls
            If TypeOf c Is Panel Then
                AddBorderToPanel(pnlCenter, c, theme("High"))
            End If
        Next
        dgvProd.BackgroundColor = theme("Light")
        dgvProd.RowsDefaultCellStyle.BackColor = theme("Light")
        dgvProd.RowsDefaultCellStyle.ForeColor = theme("Font")
        dgvProd.RowsDefaultCellStyle.SelectionBackColor = theme("High")
        dgvProd.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvProd.ColumnHeadersDefaultCellStyle.BackColor = theme("Medium")
        dgvProd.ColumnHeadersDefaultCellStyle.ForeColor = theme("Font")
        dgvProd.ColumnHeadersDefaultCellStyle.SelectionBackColor = theme("Light")
        dgvProd.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black
        dgvMembersInt.BackgroundColor = theme("Light")
        dgvMembersInt.RowsDefaultCellStyle.BackColor = theme("Light")
        dgvMembersInt.RowsDefaultCellStyle.ForeColor = theme("Font")
        dgvMembersInt.RowsDefaultCellStyle.SelectionBackColor = theme("High")
        dgvMembersInt.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvMembersInt.ColumnHeadersDefaultCellStyle.BackColor = theme("Medium")
        dgvMembersInt.ColumnHeadersDefaultCellStyle.ForeColor = theme("Font")
        dgvMembersInt.ColumnHeadersDefaultCellStyle.SelectionBackColor = theme("Light")
        dgvMembersInt.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black
        dgvProductsInt.BackgroundColor = theme("Light")
        dgvProductsInt.RowsDefaultCellStyle.BackColor = theme("Light")
        dgvProductsInt.RowsDefaultCellStyle.ForeColor = theme("Font")
        dgvProductsInt.RowsDefaultCellStyle.SelectionBackColor = theme("High")
        dgvProductsInt.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvProductsInt.ColumnHeadersDefaultCellStyle.BackColor = theme("Medium")
        dgvProductsInt.ColumnHeadersDefaultCellStyle.ForeColor = theme("Font")
        dgvProductsInt.ColumnHeadersDefaultCellStyle.SelectionBackColor = theme("Light")
        dgvProductsInt.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black
    End Sub
    Private Sub cmbMemberName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbMemberName.SelectionChangeCommitted
        'Add time to member
        If txtTime.Text <> String.Empty Then
            txtMemberTimeIn.Text = txtTime.Text
        End If
    End Sub
    Private Sub cmbNoInput(sender As Object, e As KeyPressEventArgs) Handles cmbTypeOfPlace.KeyPress, cmbTypeOfInt.KeyPress, cmbStep.KeyPress, cmbProductUnit.KeyPress, cmbMethod.KeyPress, cmbMemberName.KeyPress, cmbInt.KeyPress, cmbDrug.KeyPress, txtTime.KeyPress
        'Disable user input
        If e.KeyChar <> Chr(Keys.Back) Then e.Handled = True
    End Sub
    Private Sub cmbNoInputbutErase(sender As Object, e As KeyPressEventArgs) Handles cmbProductUnit.KeyPress, cmbSamplesTakenBy.KeyPress
        'Disable user input
        If Asc(e.KeyChar) <> 8 Then e.KeyChar = CChar(String.Empty)
    End Sub
#End Region

End Class