Option Explicit On
Option Strict On
Public Class frmProducts
    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetColors()
        'Fill datatable
        PRODUCTSTableAdapter.Fill(DORADbDS.PRODUCTS)
        PRODUCTSBindingSource.Sort = "[SHORT NAME] ASC"
        Trad()
    End Sub
#Region "Search"
    Private Sub txtSearchProducts_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProducts.TextChanged
        'Start and stop timer
        Timer1.Stop()
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Filter bindingsource
        Timer1.Stop()
        If txtSearchProducts.Text <> String.Empty Then
            PRODUCTSBindingSource.Filter = $"[SHORT NAME] LIKE '%{txtSearchProducts.Text}%' OR [FULL NAME] LIKE '%{txtSearchProducts.Text}%' OR [NOM COMPLET] LIKE '%{txtSearchProducts.Text}%' OR [VOLLEDIGE NAAM] LIKE '%{txtSearchProducts.Text}%' OR [CAS NUM] LIKE '%{txtSearchProducts.Text}%' OR [UN NUM] LIKE '%{txtSearchProducts.Text}%' OR [CATEGORY] LIKE '%{txtSearchProducts.Text}%' OR [FORM] LIKE '%{txtSearchProducts.Text}%'"
            If Lang = 1 Then
                lblcount.Text = $"{PRODUCTSBindingSource.Count} product(en)"
            Else
                lblcount.Text = $"{PRODUCTSBindingSource.Count} produit(s)"
            End If
        End If
    End Sub
    Private Sub txtSearchProducts_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSearchProducts.MouseDoubleClick
        'Reset search field
        txtSearchProducts.Text = String.Empty
        PRODUCTSBindingSource.Filter = String.Empty
    End Sub
#End Region
#Region "Miscellaneous"
    Private Sub Trad()
        'Translate GUI
        dgvProducts.Columns(0).HeaderText = "Short name (EN)"
        dgvProducts.Columns(1).HeaderText = "Full name (EN)"
        dgvProducts.Columns(2).HeaderText = "Nom complet (FR)"
        dgvProducts.Columns(3).HeaderText = "Volledige naam (NL)"
        If Lang = 1 Then
            dgvProducts.Columns(4).HeaderText = "CAS nummer"
            dgvProducts.Columns(5).HeaderText = "UN nummer"
            ToolTip.SetToolTip(btnUndo, "Ongedaan maken")
            lblcount.Text = PRODUCTSBindingSource.Count & " product(en)"
        Else
            dgvProducts.Columns(4).HeaderText = "Numéro CAS"
            dgvProducts.Columns(5).HeaderText = "Numéro UN"
            ToolTip.SetToolTip(btnUndo, "Annuler")
            lblcount.Text = PRODUCTSBindingSource.Count & " produit(s)"
        End If
    End Sub
    Private Sub dgvProducts_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProducts.CellMouseDoubleClick
        dgvProducts.BeginEdit(True)
    End Sub
    Private Sub dgvProducts_Resize(sender As Object, e As EventArgs) Handles dgvProducts.Resize
        dgvProducts.Columns(0).Width = CInt((dgvProducts.Width / 100) * 17)
        dgvProducts.Columns(1).Width = CInt((dgvProducts.Width / 100) * 20)
        dgvProducts.Columns(2).Width = CInt((dgvProducts.Width / 100) * 20)
        dgvProducts.Columns(3).Width = CInt((dgvProducts.Width / 100) * 20)
        dgvProducts.Columns(4).Width = CInt((dgvProducts.Width / 100) * 10)
        dgvProducts.Columns(5).Width = CInt((dgvProducts.Width / 100) * 10)
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        Dim first As Integer = dgvProducts.FirstDisplayedScrollingRowIndex
        Dim index As Integer = dgvProducts.SelectedRows(0).Index
        PRODUCTSTableAdapter.Fill(DORADbDS.PRODUCTS)
        dgvProducts.FirstDisplayedScrollingRowIndex = first
        dgvProducts.Rows(index).Selected = True
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles Me.Closing, btnSave.Click
        'Save changes
        Try
            Validate()
            PRODUCTSBindingSource.EndEdit()
            PRODUCTSTableAdapter.Update(DORADbDS.PRODUCTS)
            log("PROD", "click on SAVE")
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
    Private Sub SetColors()
        'Set colors of controls according to choosen theme
        dgvProducts.BackgroundColor = theme("Light")
        dgvProducts.RowsDefaultCellStyle.BackColor = theme("Light")
        dgvProducts.RowsDefaultCellStyle.ForeColor = theme("Font")
        dgvProducts.RowsDefaultCellStyle.SelectionBackColor = theme("High")
        dgvProducts.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = theme("Medium")
        dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = theme("Font")
        dgvProducts.ColumnHeadersDefaultCellStyle.SelectionBackColor = theme("Dark")
        dgvProducts.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black
        btnUndo.IconColor = theme("Font")
        btnSave.IconColor = theme("Font")
    End Sub
#End Region

End Class