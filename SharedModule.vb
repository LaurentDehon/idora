Module SharedModule
    Public IntNum As Integer
    Public Lang As Integer
    Public IntLang As String
    Public ID As Integer
    Public CaseName As String
    Public CRUFile As String
    Public TypeOfCase As String
    Public ReportNum As String
    Public InvYear As Integer
    Public FirstRow As Integer
    Public SelRow As Integer
    Public OCRUFile As String
    Public OTypeOfCase As String
    Public PathInt As String
    Public user As String
    Public newCase As Boolean = False
    Public CPDate As Date
    Public CPCity As String
    Public CPZip As Integer
    Public CPAdress As String
    Public dora_path As String
    Public files_path As String
    Public theme As Dictionary(Of String, Color)
    'Public themes As New List(Of Tuple(Of String, String))({("test", "test")})
    Public Sub log(m As String, s As String)
        If IO.Directory.Exists(dora_path) Then
            Dim objWriter As New IO.StreamWriter($"{dora_path}SYSTEM\log-{user}-{Now.Year}.txt", IO.FileMode.Append)
            objWriter.Write($"{Now.ToString("dd/MM/yyyy HH:mm:ss")}{vbTab}{m}{vbTab}{user}{vbTab}{s}{Environment.NewLine}")
            objWriter.Close()
        End If
    End Sub
    Public Function SearchFile(strFilePath As String, strSearchTerm As String) As String()
        Dim fs As New IO.StreamReader(strFilePath)
        Dim currentLine As String
        Dim searchResult As String = String.Empty
        Do While fs.EndOfStream = False
            currentLine = fs.ReadLine
            If currentLine.IndexOf(strSearchTerm) > -1 Then
                searchResult = currentLine
                Exit Do
            End If
        Loop
        searchResult = searchResult.Replace(vbTab, "")
        Return searchResult.Split(";")
    End Function
    Public Function InventoryNum3Digits(prefix As String) As String
        If prefix.ToString.Contains(".") Then
            If (prefix).Count(Function(c) Char.IsDigit(c)) = 2 Then
                prefix = prefix.Insert(prefix.Length - 3, "00")
                prefix = prefix.Insert(prefix.Length - 1, "00")
            ElseIf (prefix).Count(Function(c) Char.IsDigit(c)) = 3 Then
                Dim n As String() = Split(prefix, ".")
                If n(1).ToString.Length = 1 Then
                    prefix = prefix.Insert(prefix.Length - 4, "0")
                    prefix = prefix.Insert(prefix.Length - 1, "00")
                Else
                    prefix = prefix.Insert(prefix.Length - 4, "00")
                    prefix = prefix.Insert(prefix.Length - 2, "0")
                End If
            ElseIf (prefix).Count(Function(c) Char.IsDigit(c)) = 4 Then
                prefix = prefix.Insert(prefix.Length - 5, "0")
                prefix = prefix.Insert(prefix.Length - 2, "0")
            End If
        Else
            If (prefix).Count(Function(c) Char.IsDigit(c)) = 1 Then
                prefix = prefix.Insert(prefix.Length - 1, "00")
            ElseIf (prefix).Count(Function(c) Char.IsDigit(c)) = 2 Then
                prefix = prefix.Insert(prefix.Length - 2, "0")
            End If
        End If
        Return prefix
    End Function
    Public Function UserToList(strFilePath As String, user As String) As String()
        Dim fs As New IO.StreamReader(strFilePath)
        Dim currentLine As String
        Dim searchResult As String = String.Empty
        Do While fs.EndOfStream = False
            currentLine = fs.ReadLine
            If currentLine.Contains(user) Then
                searchResult = currentLine
                Exit Do
            End If
        Loop
        searchResult = searchResult.Replace(" ", "")
        searchResult = searchResult.Replace(vbTab, "")
        Return searchResult.Split(";")
    End Function
    Public Sub HideDate(bs As BindingSource, c As DateTimePicker, field As String)
        If DirectCast(bs.Current, DataRowView).Item(field) Is DBNull.Value Then
            c.Format = DateTimePickerFormat.Custom
            c.CustomFormat = " "
        End If
    End Sub
    Public Function FindControlRecursive(list As List(Of Control), parent As Control, ctrlType As Type) As List(Of Control)
        If parent Is Nothing Then Return list
        If parent.GetType Is ctrlType Then
            list.Add(parent)
        End If
        For Each child As Control In parent.Controls
            FindControlRecursive(list, child, ctrlType)
        Next
        Return list
    End Function
    Public Sub AddBorderToPanel(p As Control, c As Control, col As Color)
        Dim bp As New Panel With {
            .BackColor = col,
            .Size = New Size(c.Width + 2, c.Height + 2),
            .Location = New Point(c.Location.X - 1, c.Location.Y - 1),
            .Name = $"{c.Name}_border"
        }
        p.Controls.Add(bp)
        c.BringToFront()
    End Sub
    Public Sub CheckBirthday()
        user = Environment.UserName
        Dim user_list() As String = SearchFile($"{dora_path}cru.txt", user)
        Dim dt As Date = Convert.ToDateTime(user_list(1))
        If Date.Now.Month = dt.Month AndAlso Date.Now.Day = dt.Day Then
            With frmMain.picBirthday
                .Image = My.Resources.birthday
                .SizeMode = PictureBoxSizeMode.Zoom
                .MaximumSize = New Size(600, 400)
                frmMain.pnlCenter.Controls.Add(frmMain.picBirthday)
                frmMain.picBirthday.BringToFront()
            End With
        End If
    End Sub
    Function GetEasterDate(year As Integer)
        Dim y As Integer = year
        Dim d As Integer = (((255 - 11 * (y Mod 19)) - 21) Mod 30) + 21
        Dim easter_date = New DateTime(y, 3, 1)
        easter_date = easter_date.AddDays(+d + (d > 48) + 6 - ((y + y \ 4 + d + (d > 48) + 1) Mod 7))
        Return (easter_date)
    End Function
    Public Sub CheckHolidays()
        If Now.Month = 1 AndAlso (Now.Day >= 1 AndAlso Now.Day <= 3) Then
            frmMain.picTopRight.Image = My.Resources.new_year
            Exit Sub
        End If
        If Now.Month = 2 AndAlso Now.Day = 14 Then
            Exit Sub
        End If
        If Now.Month = 3 AndAlso Now.Day = 17 Then
            Exit Sub
        End If
        If Now.Month = 3 AndAlso Now.Day = 18 Then
            frmMain.picBottomLeft.Image = My.Resources.spring
            Exit Sub
        End If
        If Now.Month = 4 AndAlso Now.Day = 1 Then
            Exit Sub
        End If
        Dim easter As Date = GetEasterDate(Now.Year)
        If Now.Date >= easter.AddDays(-5) AndAlso Now.Date <= easter.AddDays(5) Then
            Exit Sub
        End If
        If Now.Month = 6 AndAlso Now.Day = 21 Then
            Exit Sub
        End If
        If Now.Month = 9 AndAlso Now.Day = 21 Then
            Exit Sub
        End If
        If (Now.Month = 10 AndAlso Now.Day = 31) OrElse (Now.Month = 11 AndAlso Now.Day = 1) Then
            Exit Sub
        End If
        If Now.Month = 12 AndAlso Now.Day = 6 Then
            Exit Sub
        End If
        If Now.Month = 12 AndAlso Now.Day = 21 Then
            Exit Sub
        End If
        If Now.Month = 12 AndAlso (Now.Day >= 23 AndAlso Now.Day <= 27) Then
            Exit Sub
        End If
        If Now.Month = 12 AndAlso (Now.Day >= 29 AndAlso Now.Day <= 31) Then
            Exit Sub
        End If
    End Sub
End Module
Public Structure RGBColors
    Public Shared btn_color1 As Color = Color.CornflowerBlue
    Public Shared btn_color2 As Color = Color.Yellow
    Public Shared btn_color3 As Color = Color.LightCoral
    Public Shared btn_color4 As Color = Color.Cyan
    Public Shared btn_color5 As Color = Color.HotPink
    Public Shared btn_color6 As Color = Color.Orange
    'Theme Dark
    Public Shared TH1_Light As Color = Color.FromArgb(51, 51, 51)
    Public Shared TH1_Medium As Color = Color.FromArgb(37, 37, 38)
    Public Shared TH1_Dark As Color = Color.FromArgb(30, 30, 30)
    Public Shared TH1_Font As Color = Color.Gainsboro
    Public Shared TH1_High As Color = Color.Orange
    'Theme Abyss
    Public Shared TH2_Light As Color = Color.FromArgb(5, 19, 54)
    Public Shared TH2_Medium As Color = Color.FromArgb(6, 6, 33)
    Public Shared TH2_Dark As Color = Color.FromArgb(0, 12, 24)
    Public Shared TH2_Font As Color = Color.Silver
    Public Shared TH2_High As Color = Color.MediumPurple
    'Theme Kimbie
    Public Shared TH3_Light As Color = Color.FromArgb(69, 57, 40)
    Public Shared TH3_Medium As Color = Color.FromArgb(54, 39, 18)
    Public Shared TH3_Dark As Color = Color.FromArgb(34, 26, 15)
    Public Shared TH3_Font As Color = Color.Gainsboro
    Public Shared TH3_High As Color = Color.Gold
    'Theme Noctis
    Public Shared TH4_Light As Color = Color.FromArgb(17, 72, 79)
    Public Shared TH4_Medium As Color = Color.FromArgb(5, 37, 41)
    Public Shared TH4_Dark As Color = Color.FromArgb(4, 29, 32)
    Public Shared TH4_Font As Color = Color.Gainsboro
    Public Shared TH4_High As Color = Color.Salmon
    'Theme Dracula
    Public Shared TH5_Light As Color = Color.FromArgb(52, 55, 70)
    Public Shared TH5_Medium As Color = Color.FromArgb(33, 34, 44)
    Public Shared TH5_Dark As Color = Color.FromArgb(40, 42, 54)
    Public Shared TH5_Font As Color = Color.FromArgb(144, 155, 190)
    Public Shared TH5_High As Color = Color.LightBlue
End Structure