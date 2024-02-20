<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ExitButton = New Button()
        LoadObjectButton = New Button()
        SuspendLayout()
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(518, 217)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(133, 48)
        ExitButton.TabIndex = 0
        ExitButton.Text = "EXIT"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' LoadObjectButton
        ' 
        LoadObjectButton.Location = New Point(162, 217)
        LoadObjectButton.Name = "LoadObjectButton"
        LoadObjectButton.Size = New Size(169, 48)
        LoadObjectButton.TabIndex = 1
        LoadObjectButton.Text = "Load Object Demo"
        LoadObjectButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LoadObjectButton)
        Controls.Add(ExitButton)
        Name = "Form1"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents LoadObjectButton As Button

End Class
