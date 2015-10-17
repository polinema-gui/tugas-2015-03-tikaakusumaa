<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Cmb_pola = New System.Windows.Forms.ComboBox()
        Me.TextBox_baris = New System.Windows.Forms.TextBox()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.TextBox_Hasil = New System.Windows.Forms.TextBox()
        Me.Label_Pola = New System.Windows.Forms.Label()
        Me.Label_Baris = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cmb_pola
        '
        Me.Cmb_pola.FormattingEnabled = True
        Me.Cmb_pola.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.Cmb_pola.Location = New System.Drawing.Point(70, 12)
        Me.Cmb_pola.Name = "Cmb_pola"
        Me.Cmb_pola.Size = New System.Drawing.Size(383, 21)
        Me.Cmb_pola.TabIndex = 0
        '
        'TextBox_baris
        '
        Me.TextBox_baris.Location = New System.Drawing.Point(70, 39)
        Me.TextBox_baris.Name = "TextBox_baris"
        Me.TextBox_baris.Size = New System.Drawing.Size(265, 20)
        Me.TextBox_baris.TabIndex = 1
        '
        'Button_OK
        '
        Me.Button_OK.Location = New System.Drawing.Point(367, 39)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(75, 23)
        Me.Button_OK.TabIndex = 2
        Me.Button_OK.Text = "OK"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'TextBox_Hasil
        '
        Me.TextBox_Hasil.Location = New System.Drawing.Point(12, 65)
        Me.TextBox_Hasil.Multiline = True
        Me.TextBox_Hasil.Name = "TextBox_Hasil"
        Me.TextBox_Hasil.ReadOnly = True
        Me.TextBox_Hasil.Size = New System.Drawing.Size(441, 261)
        Me.TextBox_Hasil.TabIndex = 3
        '
        'Label_Pola
        '
        Me.Label_Pola.AutoSize = True
        Me.Label_Pola.Location = New System.Drawing.Point(12, 20)
        Me.Label_Pola.Name = "Label_Pola"
        Me.Label_Pola.Size = New System.Drawing.Size(28, 13)
        Me.Label_Pola.TabIndex = 5
        Me.Label_Pola.Text = "Pola"
        '
        'Label_Baris
        '
        Me.Label_Baris.AutoSize = True
        Me.Label_Baris.Location = New System.Drawing.Point(12, 42)
        Me.Label_Baris.Name = "Label_Baris"
        Me.Label_Baris.Size = New System.Drawing.Size(30, 13)
        Me.Label_Baris.TabIndex = 6
        Me.Label_Baris.Text = "Baris"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.Label_Baris)
        Me.Controls.Add(Me.Label_Pola)
        Me.Controls.Add(Me.TextBox_Hasil)
        Me.Controls.Add(Me.Button_OK)
        Me.Controls.Add(Me.TextBox_baris)
        Me.Controls.Add(Me.Cmb_pola)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cmb_pola As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_baris As System.Windows.Forms.TextBox
    Friend WithEvents Button_OK As System.Windows.Forms.Button
    Friend WithEvents TextBox_Hasil As System.Windows.Forms.TextBox
    Friend WithEvents Label_Pola As System.Windows.Forms.Label
    Friend WithEvents Label_Baris As System.Windows.Forms.Label
End Class
