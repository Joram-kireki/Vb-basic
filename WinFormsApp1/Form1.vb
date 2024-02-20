Imports System.Windows.Forms
Public Class Form1
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LoadObjectButton_Click(sender As Object, e As EventArgs) Handles LoadObjectButton.Click
        Dim ObjectDemo As New Form2()
        ObjectDemo.Show()
    End Sub

    Private FormTooltip As New ToolTip()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormTooltip.SetToolTip(LoadObjectButton, "Displays the 'Object Demonstrations' form")
        FormTooltip.SetToolTip(ExitButton, "Terminates the application")
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.BackColor = Color.Red
        Me.WindowState = FormWindowState.Maximized

    End Sub
End Class
