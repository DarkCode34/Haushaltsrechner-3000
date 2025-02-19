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
        SuspendLayout()
        ' 
        ' CmdEnd
        ' 
        CmdEnd.Location = New Point(694, 409)
        CmdEnd.Name = "CmdEnd"
        CmdEnd.Size = New Size(94, 29)
        CmdEnd.TabIndex = 0
        CmdEnd.Text = "Beenden"
        CmdEnd.UseVisualStyleBackColor = True
        ' 
        ' LblHauptanzeige
        ' 
        LblHauptanzeige.AutoSize = True
        LblHauptanzeige.Font = New Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point)
        LblHauptanzeige.Location = New Point(174, 9)
        LblHauptanzeige.Name = "LblHauptanzeige"
        LblHauptanzeige.Size = New Size(471, 55)
        LblHauptanzeige.TabIndex = 1
        LblHauptanzeige.Text = "Haushaltsrechner 3000"
        LblHauptanzeige.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LblHauptanzeige)
        Controls.Add(CmdEnd)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CmdEnd As Button
    Friend WithEvents LblHauptanzeige As Label
End Class
