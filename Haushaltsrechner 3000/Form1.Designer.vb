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
        CmdEnd = New Button()
        LblHauptanzeige = New Label()
        CmdSpeichern = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' CmdEnd
        ' 
        CmdEnd.Location = New Point(607, 307)
        CmdEnd.Margin = New Padding(3, 2, 3, 2)
        CmdEnd.Name = "CmdEnd"
        CmdEnd.Size = New Size(82, 22)
        CmdEnd.TabIndex = 0
        CmdEnd.Text = "Beenden"
        CmdEnd.UseVisualStyleBackColor = True
        ' 
        ' LblHauptanzeige
        ' 
        LblHauptanzeige.AutoSize = True
        LblHauptanzeige.Font = New Font("Comic Sans MS", 24F, FontStyle.Bold)
        LblHauptanzeige.Location = New Point(152, 7)
        LblHauptanzeige.Name = "LblHauptanzeige"
        LblHauptanzeige.Size = New Size(383, 45)
        LblHauptanzeige.TabIndex = 1
        LblHauptanzeige.Text = "Haushaltsrechner 3000"
        LblHauptanzeige.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CmdSpeichern
        ' 
        CmdSpeichern.Location = New Point(8, 308)
        CmdSpeichern.Name = "CmdSpeichern"
        CmdSpeichern.Size = New Size(75, 23)
        CmdSpeichern.TabIndex = 2
        CmdSpeichern.Text = "Speichern"
        CmdSpeichern.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 3
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 4
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 5
        Label3.Text = "Label3"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(69, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(69, 94)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(69, 123)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CmdSpeichern)
        Controls.Add(LblHauptanzeige)
        Controls.Add(CmdEnd)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CmdEnd As Button
    Friend WithEvents LblHauptanzeige As Label
    Friend WithEvents CmdSpeichern As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
