<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox_matriks1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_operasi = New System.Windows.Forms.ComboBox()
        Me.TextBox_matriks2 = New System.Windows.Forms.TextBox()
        Me.TextBox_hasil = New System.Windows.Forms.TextBox()
        Me.Button_hitung = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox_matriks1
        '
        Me.TextBox_matriks1.Location = New System.Drawing.Point(63, 12)
        Me.TextBox_matriks1.Multiline = True
        Me.TextBox_matriks1.Name = "TextBox_matriks1"
        Me.TextBox_matriks1.Size = New System.Drawing.Size(366, 75)
        Me.TextBox_matriks1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Matriks 1"
        '
        'Cmb_operasi
        '
        Me.Cmb_operasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_operasi.FormattingEnabled = True
        Me.Cmb_operasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.Cmb_operasi.Location = New System.Drawing.Point(63, 93)
        Me.Cmb_operasi.Name = "Cmb_operasi"
        Me.Cmb_operasi.Size = New System.Drawing.Size(366, 21)
        Me.Cmb_operasi.TabIndex = 2
        '
        'TextBox_matriks2
        '
        Me.TextBox_matriks2.Location = New System.Drawing.Point(63, 120)
        Me.TextBox_matriks2.Multiline = True
        Me.TextBox_matriks2.Name = "TextBox_matriks2"
        Me.TextBox_matriks2.Size = New System.Drawing.Size(366, 64)
        Me.TextBox_matriks2.TabIndex = 3
        '
        'TextBox_hasil
        '
        Me.TextBox_hasil.Location = New System.Drawing.Point(63, 190)
        Me.TextBox_hasil.Multiline = True
        Me.TextBox_hasil.Name = "TextBox_hasil"
        Me.TextBox_hasil.ReadOnly = True
        Me.TextBox_hasil.Size = New System.Drawing.Size(366, 112)
        Me.TextBox_hasil.TabIndex = 4
        '
        'Button_hitung
        '
        Me.Button_hitung.Location = New System.Drawing.Point(354, 318)
        Me.Button_hitung.Name = "Button_hitung"
        Me.Button_hitung.Size = New System.Drawing.Size(75, 23)
        Me.Button_hitung.TabIndex = 5
        Me.Button_hitung.Text = "Hitung"
        Me.Button_hitung.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Operasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Matriks 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Hasil"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_hitung)
        Me.Controls.Add(Me.TextBox_hasil)
        Me.Controls.Add(Me.TextBox_matriks2)
        Me.Controls.Add(Me.Cmb_operasi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_matriks1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_matriks1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cmb_operasi As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_matriks2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_hasil As System.Windows.Forms.TextBox
    Friend WithEvents Button_hitung As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
