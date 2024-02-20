Public Class Form2

    Private Sub GaramondRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GaramondRadioButton.CheckedChanged
        If GaramondRadioButton.Checked Then
            SampleTestTextBox.Font = New Font("Garamond", SampleTestTextBox.Font.Size)
        End If
    End Sub

    Private Sub MagnetoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MagnetoRadioButton.CheckedChanged
        If MagnetoRadioButton.Checked Then
            SampleTestTextBox.Font = New Font("Magneto", SampleTestTextBox.Font.Size)
        End If
    End Sub

    Private Sub TahomaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TahomaRadioButton.CheckedChanged
        If TahomaRadioButton.Checked Then
            SampleTestTextBox.Font = New Font("Tahoma", SampleTestTextBox.Font.Size)
        End If
    End Sub

    Private Sub ItalicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicCheckBox.CheckedChanged
        Dim fontstyle As FontStyle = FontStyle.Regular
        If ItalicCheckBox.Checked Then
            fontstyle = fontstyle Or FontStyle.Italic
        End If
        If BoldCheckBox.Checked Then
            fontstyle = fontstyle Or FontStyle.Bold
        End If
        If BoldItalicCheckBox.Checked Then
            fontstyle = fontstyle Or FontStyle.Bold Or FontStyle.Italic
        End If
        SampleTestTextBox.Font = New Font(SampleTestTextBox.Font, fontstyle)
    End Sub
    Private Sub BoldCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldCheckBox.CheckedChanged
        Dim fontstyle As FontStyle = FontStyle.Regular
        If ItalicCheckBox.Checked Then
            fontstyle = fontstyle Or FontStyle.Italic
        End If
        If BoldCheckBox.Checked Then
            fontstyle = fontstyle Or FontStyle.Bold
        End If
        If BoldItalicCheckBox.Checked Then
            fontstyle = fontstyle Or FontStyle.Bold Or FontStyle.Italic
        End If
        SampleTestTextBox.Font = New Font(SampleTestTextBox.Font, fontstyle)
    End Sub
    Private Sub BoldItalicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldItalicCheckBox.CheckedChanged
        Dim fontstyle As FontStyle = FontStyle.Regular
        If ItalicCheckBox.Checked Then
            fontstyle = fontstyle Or FontStyle.Italic
        End If
        If BoldCheckBox.Checked Then
            fontstyle = fontstyle Or FontStyle.Bold
        End If
        If BoldItalicCheckBox.Checked Then
            fontstyle = fontstyle Or FontStyle.Bold Or FontStyle.Italic
        End If
        SampleTestTextBox.Font = New Font(SampleTestTextBox.Font, fontstyle)
    End Sub

    Private Sub LoadPictureButton_Click(sender As Object, e As EventArgs) Handles LoadPictureButton.Click
        Dim OpeningFileDialog As New OpenFileDialog()
        OpeningFileDialog.Filter = "Image Files|*.jpeg;*.jpg;*.png;*.gif;|All Files|*.*"
        If OpeningFileDialog.ShowDialog() = DialogResult.OK Then
            Dim SelectedImage As Image = Image.FromFile(
                OpeningFileDialog.FileName)
            PicBox.Image = SelectedImage
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        If GreenRadioButton.Checked Then
            SampleTestTextBox.ForeColor = Color.Green
        End If
    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        If BlueRadioButton.Checked Then
            SampleTestTextBox.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub RedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RedRadioButton.CheckedChanged
        If RedRadioButton.Checked Then
            SampleTestTextBox.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class