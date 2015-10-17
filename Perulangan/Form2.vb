Public Class Form2
    Dim total As String = ""

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Try
            Select Case Cmb_pola.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(TextBox_baris.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(TextBox_baris.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(TextBox_baris.Text))
                Case "Hollow Inverted Pyramid"
                    hollowInvertedPyramid(Convert.ToInt32(TextBox_baris.Text))
                Case Else
                    TextBox_Hasil.Text = "Anda Belum Memilih Pola"
            End Select
        Catch ex As Exception
            TextBox_Hasil.Text = "Anda belum memilih pola"
        End Try
    End Sub

    Private Sub pyramid(ukuran As Integer)
        Dim ukuranKolom1 As Integer = ukuran
        Dim ukuranKolom2 As Integer = ukuran
        For baris As Integer = 1 To ukuran
            For kolom As Integer = 1 To ukuran * 2 - 1
                If (kolom < ukuranKolom1 Or kolom > ukuranKolom2) Then
                    Me.total &= " "
                Else
                    Me.total &= "*"
                End If
            Next
            ukuranKolom1 -= 1
            ukuranKolom2 += 1
            Me.total &= vbCrLf
        Next
        TextBox_Hasil.Text = total
        total = ""
    End Sub

    Private Sub hollowPyramid(ukuran As Integer)
        Dim ukuranKolom1 As Integer = ukuran
        Dim ukuranKolom2 As Integer = ukuran
        For baris As Integer = 1 To ukuran
            For kolom As Integer = 1 To ukuran
                If (baris < ukuran) Then
                    If (kolom = ukuranKolom1 Or kolom = ukuranKolom2) Then
                        Me.total &= "*"
                    Else
                        Me.total &= " "
                    End If
                Else
                    Me.total &= "*"
                End If
            Next
            ukuranKolom1 -= 1
            ukuranKolom2 += 1
            Me.total &= vbCrLf

        Next
        TextBox_Hasil.Text = total
        total = ""
    End Sub

    Private Sub invertedPyramid(ukuran As Integer)
        Dim ukuranKolom1 As Integer = 0
        Dim ukuranKolom2 As Integer = ukuran * 2
        For baris As Integer = 1 To ukuran
            For kolom As Integer = 1 To ukuran * 2 - 1
                If (kolom > ukuranKolom1 And kolom < ukuranKolom2) Then
                    Me.total &= "*"
                Else
                    Me.total &= " "
                End If
            Next
            Me.total &= vbCrLf
            ukuranKolom1 += 1
            ukuranKolom2 -= 1
        Next
        TextBox_Hasil.Text = total
        Me.total = ""
    End Sub

    Private Sub hollowInvertedPyramid(ukuran As Integer)
        Dim ukuranKolom1 As Integer = 1
        Dim ukuranKolom2 As Integer = ukuran * 2 - 1
        For baris As Integer = 1 To ukuran
            For kolom As Integer = 1 To ukuran * 2 - 1
                If (baris = 1) Then
                    Me.total &= "*"
                Else
                    If (kolom = ukuranKolom1 Or kolom = ukuranKolom2) Then
                        Me.total &= "*"
                    Else
                        Me.total &= " "
                    End If
                End If
            Next
            ukuranKolom1 += 1
            ukuranKolom2 -= 1
            Me.total &= vbCrLf
        Next
        TextBox_Hasil.Text = total
        Me.total = ""
    End Sub

End Class
