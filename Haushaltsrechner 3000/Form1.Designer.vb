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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
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
End Class
