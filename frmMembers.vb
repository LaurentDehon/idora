Option Explicit On
Option Strict On
Public Class frmMembers
    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetColors()
        'Fill datatable
        MEMBERSTableAdapter.Fill(DORADbDS.MEMBERS)
        MEMBERSBindingSource.Sort = "[SERVICE] DESC, [LAST NAME] ASC"
        Trad()
    End Sub
#Region "Search"
    Private Sub txtSearchMembers_TextChanged(sender As Object, e As EventArgs) Handles txtSearchMembers.TextChanged
        'Start and stop timer
        Timer1.Stop()
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Filter bindingsource
        Timer1.Stop()
        If txtSearchMembers.Text <> String.Empty Then
            MEMBERSBindingSource.Filter = $"[LAST NAME] LIKE '%{txtSearchMembers.Text}%' OR [FIRST NAME] LIKE '%{txtSearchMembers.Text}%' OR [RANK] LIKE '%{txtSearchMembers.Text}%' OR [SERVICE] LIKE '%{txtSearchMembers.Text}%' OR [PHONE] LIKE '%{txtSearchMembers.Text}%' OR [MOBILE] LIKE '%{txtSearchMembers.Text}%' OR [EMAIL] LIKE '%{txtSearchMembers.Text}%'"
            If Lang = 1 Then
                lblcount.Text = $"{MEMBERSBindingSource.Count} persoon(en)"
            Else
                lblcount.Text = $"{MEMBERSBindingSource.Count} personne(s)"
            End If
        End If
    End Sub
    Private Sub txtSearchMembers_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSearchMembers.MouseDoubleClick
        'Reset search field
        txtSearchMembers.Text = String.Empty
        MEMBERSBindingSource.Filter = String.Empty
    End Sub
#End Region
#Region "Miscellaneous"
    Private Sub Trad()
        'Translate GUI
        dgvMembers.Columns(5).HeaderText = "E-mail"
        If Lang = 1 Then
            dgvMembers.Columns(0).HeaderText = "Naam"
            dgvMembers.Columns(1).HeaderText = "Voornaam"
            dgvMembers.Columns(2).HeaderText = "Dienst"
            dgvMembers.Columns(3).HeaderText = "Telefoon"
            dgvMembers.Columns(4).HeaderText = "Mobiele"
            lblcount.Text = MEMBERSBindingSource.Count & " persoon(en)"
        Else
            dgvMembers.Columns(0).HeaderText = "Nom"
            dgvMembers.Columns(1).HeaderText = "Prénom"
            dgvMembers.Columns(2).HeaderText = "Service"
            dgvMembers.Columns(3).HeaderText = "Téléphone"
            dgvMembers.Columns(4).HeaderText = "Mobile"
            lblcount.Text = MEMBERSBindingSource.Count & " personne(s)"
        End If
    End Sub
    Private Sub dgvProducts_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMembers.CellMouseDoubleClick
        dgvMembers.BeginEdit(True)
    End Sub
    Private Sub dgvMembers_Resize(sender As Object, e As EventArgs) Handles dgvMembers.Resize
        dgvMembers.Columns(0).Width = CInt((dgvMembers.Width / 100) * 15)
        dgvMembers.Columns(1).Width = CInt((dgvMembers.Width / 100) * 15)
        dgvMembers.Columns(2).Width = CInt((dgvMembers.Width / 100) * 15)
        dgvMembers.Columns(3).Width = CInt((dgvMembers.Width / 100) * 15)
        dgvMembers.Columns(4).Width = CInt((dgvMembers.Width / 100) * 15)
        dgvMembers.Columns(5).Width = CInt((dgvMembers.Width / 100) * 22)
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        Dim first As Integer = dgvMembers.FirstDisplayedScrollingRowIndex
        Dim index As Integer = dgvMembers.SelectedRows(0).Index
        MEMBERSTableAdapter.Fill(DORADbDS.MEMBERS)
        dgvMembers.FirstDisplayedScrollingRowIndex = first
        dgvMembers.Rows(index).Selected = True
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles Me.Closing
        'Save changes
        Try
            Validate()
            MEMBERSBindingSource.EndEdit()
            MEMBERSTableAdapter.Update(DORADbDS.MEMBERS)
            log("MEM.", "click on SAVE")
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
        dgvMembers.BackgroundColor = theme("Light")
        dgvMembers.RowsDefaultCellStyle.BackColor = theme("Light")
        dgvMembers.RowsDefaultCellStyle.ForeColor = theme("Font")
        dgvMembers.RowsDefaultCellStyle.SelectionBackColor = theme("High")
        dgvMembers.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvMembers.ColumnHeadersDefaultCellStyle.BackColor = theme("Medium")
        dgvMembers.ColumnHeadersDefaultCellStyle.ForeColor = theme("Font")
        dgvMembers.ColumnHeadersDefaultCellStyle.SelectionBackColor = theme("Dark")
        dgvMembers.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black
        btnUndo.IconColor = theme("Font")
    End Sub
#End Region

End Class