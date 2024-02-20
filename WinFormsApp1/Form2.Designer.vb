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
        ExitButton = New Button()
        DisplayTestLabel = New Label()
        SampleTestTextBox = New TextBox()
        FontLabel = New Label()
        GaramondRadioButton = New RadioButton()
        MagnetoRadioButton = New RadioButton()
        TahomaRadioButton = New RadioButton()
        FontStyleLabel = New Label()
        ItalicCheckBox = New CheckBox()
        BoldCheckBox = New CheckBox()
        BoldItalicCheckBox = New CheckBox()
        PicBox = New PictureBox()
        LoadPictureButton = New Button()
        FontColorLabel = New Label()
        GreenRadioButton = New RadioButton()
        BlueRadioButton = New RadioButton()
        RedRadioButton = New RadioButton()
        CType(PicBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(662, 386)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(90, 52)
        ExitButton.TabIndex = 0
        ExitButton.Text = "Exit"
        ExitButton.TextAlign = ContentAlignment.MiddleLeft
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' DisplayTestLabel
        ' 
        DisplayTestLabel.AutoSize = True
        DisplayTestLabel.BorderStyle = BorderStyle.FixedSingle
        DisplayTestLabel.Location = New Point(37, 45)
        DisplayTestLabel.Name = "DisplayTestLabel"
        DisplayTestLabel.Size = New Size(90, 22)
        DisplayTestLabel.TabIndex = 1
        DisplayTestLabel.Text = "Display Test"
        ' 
        ' SampleTestTextBox
        ' 
        SampleTestTextBox.Location = New Point(37, 70)
        SampleTestTextBox.Name = "SampleTestTextBox"
        SampleTestTextBox.Size = New Size(125, 27)
        SampleTestTextBox.TabIndex = 2
        SampleTestTextBox.Text = "Sample Test"
        ' 
        ' FontLabel
        ' 
        FontLabel.AutoSize = True
        FontLabel.Location = New Point(389, 47)
        FontLabel.Name = "FontLabel"
        FontLabel.Size = New Size(38, 20)
        FontLabel.TabIndex = 3
        FontLabel.Text = "Font"
        ' 
        ' GaramondRadioButton
        ' 
        GaramondRadioButton.AutoSize = True
        GaramondRadioButton.Location = New Point(346, 73)
        GaramondRadioButton.Name = "GaramondRadioButton"
        GaramondRadioButton.Size = New Size(100, 24)
        GaramondRadioButton.TabIndex = 4
        GaramondRadioButton.TabStop = True
        GaramondRadioButton.Text = "Garamond"
        GaramondRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MagnetoRadioButton
        ' 
        MagnetoRadioButton.AutoSize = True
        MagnetoRadioButton.Location = New Point(490, 71)
        MagnetoRadioButton.Name = "MagnetoRadioButton"
        MagnetoRadioButton.Size = New Size(90, 24)
        MagnetoRadioButton.TabIndex = 5
        MagnetoRadioButton.TabStop = True
        MagnetoRadioButton.Text = "Magneto"
        MagnetoRadioButton.UseVisualStyleBackColor = True
        ' 
        ' TahomaRadioButton
        ' 
        TahomaRadioButton.AutoSize = True
        TahomaRadioButton.Location = New Point(639, 73)
        TahomaRadioButton.Name = "TahomaRadioButton"
        TahomaRadioButton.Size = New Size(82, 24)
        TahomaRadioButton.TabIndex = 6
        TahomaRadioButton.TabStop = True
        TahomaRadioButton.Text = "Tahoma"
        TahomaRadioButton.UseVisualStyleBackColor = True
        ' 
        ' FontStyleLabel
        ' 
        FontStyleLabel.AutoSize = True
        FontStyleLabel.Location = New Point(409, 168)
        FontStyleLabel.Name = "FontStyleLabel"
        FontStyleLabel.Size = New Size(74, 20)
        FontStyleLabel.TabIndex = 7
        FontStyleLabel.Text = "Font Style"
        ' 
        ' ItalicCheckBox
        ' 
        ItalicCheckBox.AutoSize = True
        ItalicCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ItalicCheckBox.Location = New Point(420, 204)
        ItalicCheckBox.Name = "ItalicCheckBox"
        ItalicCheckBox.Size = New Size(63, 24)
        ItalicCheckBox.TabIndex = 8
        ItalicCheckBox.Text = "Italic"
        ItalicCheckBox.UseVisualStyleBackColor = True
        ' 
        ' BoldCheckBox
        ' 
        BoldCheckBox.AutoSize = True
        BoldCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BoldCheckBox.Location = New Point(420, 246)
        BoldCheckBox.Name = "BoldCheckBox"
        BoldCheckBox.Size = New Size(63, 24)
        BoldCheckBox.TabIndex = 9
        BoldCheckBox.Text = "Bold"
        BoldCheckBox.UseVisualStyleBackColor = True
        ' 
        ' BoldItalicCheckBox
        ' 
        BoldItalicCheckBox.AutoSize = True
        BoldItalicCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BoldItalicCheckBox.Location = New Point(420, 288)
        BoldItalicCheckBox.Name = "BoldItalicCheckBox"
        BoldItalicCheckBox.Size = New Size(105, 24)
        BoldItalicCheckBox.TabIndex = 10
        BoldItalicCheckBox.Text = "Bold Italic"
        BoldItalicCheckBox.UseVisualStyleBackColor = True
        ' 
        ' PicBox
        ' 
        PicBox.BorderStyle = BorderStyle.FixedSingle
        PicBox.Location = New Point(37, 177)
        PicBox.Name = "PicBox"
        PicBox.Size = New Size(278, 180)
        PicBox.TabIndex = 11
        PicBox.TabStop = False
        ' 
        ' LoadPictureButton
        ' 
        LoadPictureButton.Location = New Point(68, 398)
        LoadPictureButton.Name = "LoadPictureButton"
        LoadPictureButton.Size = New Size(120, 40)
        LoadPictureButton.TabIndex = 12
        LoadPictureButton.Text = "Load Picture"
        LoadPictureButton.UseVisualStyleBackColor = True
        ' 
        ' FontColorLabel
        ' 
        FontColorLabel.AutoSize = True
        FontColorLabel.Location = New Point(630, 168)
        FontColorLabel.Name = "FontColorLabel"
        FontColorLabel.Size = New Size(78, 20)
        FontColorLabel.TabIndex = 13
        FontColorLabel.Text = "Font Color"
        ' 
        ' GreenRadioButton
        ' 
        GreenRadioButton.AutoSize = True
        GreenRadioButton.Location = New Point(622, 206)
        GreenRadioButton.Name = "GreenRadioButton"
        GreenRadioButton.Size = New Size(69, 24)
        GreenRadioButton.TabIndex = 14
        GreenRadioButton.TabStop = True
        GreenRadioButton.Text = "Green"
        GreenRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BlueRadioButton
        ' 
        BlueRadioButton.AutoSize = True
        BlueRadioButton.Location = New Point(623, 255)
        BlueRadioButton.Name = "BlueRadioButton"
        BlueRadioButton.Size = New Size(59, 24)
        BlueRadioButton.TabIndex = 15
        BlueRadioButton.TabStop = True
        BlueRadioButton.Text = "Blue"
        BlueRadioButton.UseVisualStyleBackColor = True
        ' 
        ' RedRadioButton
        ' 
        RedRadioButton.AutoSize = True
        RedRadioButton.Location = New Point(626, 301)
        RedRadioButton.Name = "RedRadioButton"
        RedRadioButton.Size = New Size(56, 24)
        RedRadioButton.TabIndex = 16
        RedRadioButton.TabStop = True
        RedRadioButton.Text = "Red"
        RedRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RedRadioButton)
        Controls.Add(BlueRadioButton)
        Controls.Add(GreenRadioButton)
        Controls.Add(FontColorLabel)
        Controls.Add(LoadPictureButton)
        Controls.Add(PicBox)
        Controls.Add(BoldItalicCheckBox)
        Controls.Add(BoldCheckBox)
        Controls.Add(ItalicCheckBox)
        Controls.Add(FontStyleLabel)
        Controls.Add(TahomaRadioButton)
        Controls.Add(MagnetoRadioButton)
        Controls.Add(GaramondRadioButton)
        Controls.Add(FontLabel)
        Controls.Add(SampleTestTextBox)
        Controls.Add(DisplayTestLabel)
        Controls.Add(ExitButton)
        Name = "Form2"
        Text = "Object Demonstrations"
        CType(PicBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplayTestLabel As Label
    Friend WithEvents SampleTestTextBox As TextBox
    Friend WithEvents FontLabel As Label
    Friend WithEvents GaramondRadioButton As RadioButton
    Friend WithEvents MagnetoRadioButton As RadioButton
    Friend WithEvents TahomaRadioButton As RadioButton
    Friend WithEvents FontStyleLabel As Label
    Friend WithEvents ItalicCheckBox As CheckBox
    Friend WithEvents BoldCheckBox As CheckBox
    Friend WithEvents BoldItalicCheckBox As CheckBox
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents LoadPictureButton As Button
    Friend WithEvents FontColorLabel As Label
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents RedRadioButton As RadioButton
End Class
