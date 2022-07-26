Imports iTextSharp.text.pdf.draw
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports Newtonsoft.Json
Imports System.IO
Public Class Form1
    Dim Read As String = "C:\Users\SherylMejia\Documents\PDF Resume Creator\PDF Resume Creator\Resume.json"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim Display As DialogResult = MessageBox.Show("Confirm if you want to load JSON File", "Resume Generator", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If Display = DialogResult.OK Then
            richtxbxDisplay.Text = File.ReadAllText(Read)
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim Create As DialogResult = MessageBox.Show("Confirm if you want to Generate your Resume", "Resume Generator", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If Create = DialogResult.OK Then
            Dim Path As String = "C:\Users\SherylMejia\Documents\PDF Resume Creator\PDF Resume Creator\Resume.json"
            Dim Reader As String = File.ReadAllText(Path)
            Dim Data As Result = JsonConvert.DeserializeObject(Of Result)(Reader)
            Dim Generate As Document = New Document()
            PdfWriter.GetInstance(Generate, New FileStream("C:\Users\SherylMejia\Documents\PDF Resume Creator\PDF Resume Creator\FURTON_ROCHEL.pdf", FileMode.Create))
            Dim Line As LineSeparator = New LineSeparator(3.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
            Dim Space As New Paragraph(" ")
            Dim F1 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 20, iTextSharp.text.Font.BOLD)
            Dim F2 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 14, iTextSharp.text.Font.BOLD)
            Dim F3 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 13, iTextSharp.text.Font.BOLD)
            Dim F4 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 12, iTextSharp.text.Font.NORMAL)
            Dim Image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(Data.Image)
            Image.ScalePercent(13.0F)
            Image.SetAbsolutePosition(Generate.PageSize.Width - 30.0F - 133.0F, Generate.PageSize.Height - 30.0F - 100.0F)

            Dim Name As New Paragraph(Data.FullName & vbLf, F1)
            Dim Prof As New Paragraph(Data.Profession & vbLf, F4)
            Dim Phone As New Paragraph(Data.Phone & vbLf, F4)
            Dim Email As New Paragraph(Data.Email & vbLf, F4)
            Dim H1 As New Paragraph(Data.Header1 & vbLf, F2)
            Dim Quali As New Paragraph(Data.Qualifications & vbLf, F4)
            Dim H2 As New Paragraph(Data.Header2 & vbLf, F2)
            Dim Pos As New Paragraph(Data.Position & vbLf, F4)
            Dim Com As New Paragraph(Data.Company & vbLf, F4)
            Dim Job As New Paragraph(Data.JobDescription & vbLf, F4)
            Dim H3 As New Paragraph(Data.Header3 & vbLf, F2)
            Dim SH1 As New Paragraph(Data.SubHeader1 & vbLf, F3)
            Dim S1 As New Paragraph(Data.Skill1 & vbLf, F4)
            Dim S2 As New Paragraph(Data.Skill2 & vbLf, F4)
            Dim S3 As New Paragraph(Data.Skill3 & vbLf, F4)
            Dim S4 As New Paragraph(Data.Skill4 & vbLf, F4)
            Dim SH2 As New Paragraph(Data.SubHeader2 & vbLf, F3)
            Dim S5 As New Paragraph(Data.Skill5 & vbLf, F4)
            Dim S6 As New Paragraph(Data.Skill6 & vbLf, F4)
            Dim SH3 As New Paragraph(Data.SubHeader3 & vbLf, F3)
            Dim S7 As New Paragraph(Data.Skill7 & vbLf, F4)
            Dim S8 As New Paragraph(Data.Skill8 & vbLf, F4)
            Dim H4 As New Paragraph(Data.Header4 & vbLf, F2)
            Dim Course As New Paragraph(Data.Course & vbLf, F4)
            Dim School As New Paragraph(Data.School & vbLf, F4)
            Dim Year As New Paragraph(Data.Year & vbLf, F4)

            Name.Alignment = Element.ALIGN_JUSTIFIED
            Prof.Alignment = Element.ALIGN_JUSTIFIED
            Phone.Alignment = Element.ALIGN_JUSTIFIED
            Email.Alignment = Element.ALIGN_JUSTIFIED
            H1.Alignment = Element.ALIGN_JUSTIFIED
            Quali.Alignment = Element.ALIGN_JUSTIFIED
            H2.Alignment = Element.ALIGN_JUSTIFIED
            Pos.Alignment = Element.ALIGN_JUSTIFIED
            Com.Alignment = Element.ALIGN_JUSTIFIED
            Job.Alignment = Element.ALIGN_JUSTIFIED
            H3.Alignment = Element.ALIGN_JUSTIFIED
            SH1.Alignment = Element.ALIGN_JUSTIFIED
            S1.Alignment = Element.ALIGN_JUSTIFIED
            S2.Alignment = Element.ALIGN_JUSTIFIED
            S3.Alignment = Element.ALIGN_JUSTIFIED
            S4.Alignment = Element.ALIGN_JUSTIFIED
            SH2.Alignment = Element.ALIGN_JUSTIFIED
            S5.Alignment = Element.ALIGN_JUSTIFIED
            S6.Alignment = Element.ALIGN_JUSTIFIED
            SH3.Alignment = Element.ALIGN_JUSTIFIED
            S7.Alignment = Element.ALIGN_JUSTIFIED
            S8.Alignment = Element.ALIGN_JUSTIFIED
            H4.Alignment = Element.ALIGN_JUSTIFIED
            Course.Alignment = Element.ALIGN_JUSTIFIED
            School.Alignment = Element.ALIGN_JUSTIFIED
            Year.Alignment = Element.ALIGN_JUSTIFIED

            Generate.Open()
            Generate.Add(Image)
            Generate.Add(Name)
            Generate.Add(Prof)
            Generate.Add(Phone)
            Generate.Add(Email)
            Generate.Add(Space)
            Generate.Add(Line)
            Generate.Add(H1)
            Generate.Add(Space)
            Generate.Add(Quali)
            Generate.Add(Space)
            Generate.Add(Line)
            Generate.Add(H2)
            Generate.Add(Space)
            Generate.Add(Pos)
            Generate.Add(Com)
            Generate.Add(Job)
            Generate.Add(Space)
            Generate.Add(Line)
            Generate.Add(H3)
            Generate.Add(Space)
            Generate.Add(SH1)
            Generate.Add(S1)
            Generate.Add(S2)
            Generate.Add(S3)
            Generate.Add(S4)
            Generate.Add(SH2)
            Generate.Add(S5)
            Generate.Add(S6)
            Generate.Add(SH3)
            Generate.Add(S7)
            Generate.Add(S8)
            Generate.Add(Space)
            Generate.Add(Line)
            Generate.Add(H4)
            Generate.Add(Space)
            Generate.Add(Course)
            Generate.Add(School)
            Generate.Add(Year)
            Generate.Close()
            richtxbxDisplay.Text = " "
            MessageBox.Show("Successfully created Resume!", "Resume Generator")
        End If
    End Sub

    Public Class Result
        Public Property Image As String
        Public Property FullName As String
        Public Property Profession As String
        Public Property Phone As String
        Public Property Email As String
        Public Property Header1 As String
        Public Property Qualifications As String
        Public Property Header2 As String
        Public Property Position As String
        Public Property Company As String
        Public Property JobDescription As String
        Public Property Header3 As String
        Public Property SubHeader1 As String
        Public Property Skill1 As String
        Public Property Skill2 As String
        Public Property Skill3 As String
        Public Property Skill4 As String
        Public Property SubHeader2 As String
        Public Property Skill5 As String
        Public Property Skill6 As String
        Public Property SubHeader3 As String
        Public Property Skill7 As String
        Public Property Skill8 As String
        Public Property Header4 As String
        Public Property Course As String
        Public Property School As String
        Public Property Year As String
    End Class

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult = MessageBox.Show("Confirm if you want to exit", "Resume Generator", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If iExit = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub
End Class
