Public Class Form3
    Dim cekKolom As Boolean = True
    Private Sub Button_hitung_Click(sender As Object, e As EventArgs) Handles Button_hitung.Click
        Try
            Dim barisMatriks1 As Integer = TextBox_matriks1.Lines.Count
            Dim kolomMatriks1 As Integer = TextBox_matriks2.Lines.ElementAt(0).Split(" ").Length
            Dim barisMatriks2 As Integer = TextBox_matriks1.Lines.Count
            Dim kolomMatriks2 As Integer = TextBox_matriks1.Lines.ElementAt(0).Split(" ").Length
            Dim copyMatriks1(barisMatriks1, kolomMatriks1) As Integer
            Dim copyMatriks2(barisMatriks2, kolomMatriks2) As Integer
            cek(barisMatriks1, barisMatriks2, kolomMatriks1, kolomMatriks2)
            copyToArray(barisMatriks1, barisMatriks2, kolomMatriks1, kolomMatriks2, copyMatriks1, copyMatriks2)
            operasi(copyMatriks1, copyMatriks2, barisMatriks1, kolomMatriks2)
        Catch ex As Exception
            MsgBox("Masukan Bukan Angka")
        End Try
    End Sub

    Private Sub copyToArray(ByVal baris1 As Integer, baris2 As Integer, kolom1 As Integer, kolom2 As Integer, ByRef nilai1(,) As Integer, ByRef nilai2(,) As Integer)
        If (Me.cekKolom) Then
            For baris As Integer = 0 To baris1 - 1
                For kolom As Integer = 0 To kolom1 - 1
                    nilai1(baris, kolom) = TextBox_matriks1.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                    nilai2(baris, kolom) = TextBox_matriks2.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                Next
            Next
        End If
    End Sub

    Private Sub cek(ByVal baris1 As Integer, baris2 As Integer, kolom1 As Integer, kolom2 As Integer)
        Dim tmp As Boolean = True
        For baris = 0 To baris1 - 2
            If (TextBox_matriks1.Lines.ElementAt(baris).Split(" ").Length <> TextBox_matriks1.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        For baris = 0 To baris2 - 2
            If (TextBox_matriks2.Lines.ElementAt(baris).Split(" ").Length <> TextBox_matriks2.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        If (tmp = False) Then
            Me.cekKolom = False
            Convert.ToInt32(TextBox_matriks1.Text)
            Convert.ToInt32(TextBox_matriks2.Text)
            MsgBox("Matriks Tidak Valid")
        ElseIf (baris1 = baris2 And kolom1 = kolom2) Then
            Me.cekKolom = True
        Else
            Me.cekKolom = False
            MsgBox("Baris dan Kolom Semua Matriks Harus Sama")
        End If
    End Sub

    Private Sub operasi(ByVal matriks1(,) As Integer, matriks2(,) As Integer, batasBaris As Integer, batasKolom As Integer)
        Dim hasil As String = ""
        If (Me.cekKolom) Then
            Select Case Cmb_operasi.Text
                Case "Tambah"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(baris, kolom) + matriks2(baris, kolom)).ToString & vbTab
                        Next
                        hasil &= vbNewLine
                    Next
                Case "Kurang"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(baris, kolom) - matriks2(baris, kolom)).ToString & vbTab
                        Next
                        hasil &= vbNewLine
                    Next
                Case Else
                    MsgBox("Anda Belum Memilih Operasi")
            End Select
            TextBox_hasil.Text = hasil
        End If
    End Sub

    Private Sub Cmb_operasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_operasi.SelectedIndexChanged

    End Sub
End Class