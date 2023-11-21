<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Intro
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
        btngotostoryb = New Button()
        SuspendLayout()
        ' 
        ' btngotostoryb
        ' 
        btngotostoryb.BackColor = Color.MediumPurple
        btngotostoryb.Location = New Point(1026, 630)
        btngotostoryb.Name = "btngotostoryb"
        btngotostoryb.Size = New Size(177, 71)
        btngotostoryb.TabIndex = 0
        btngotostoryb.Text = "Go to Story Book"
        btngotostoryb.UseVisualStyleBackColor = False
        ' 
        ' Intro
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1215, 722)
        Controls.Add(btngotostoryb)
        Name = "Intro"
        Text = "Intro"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btngotostoryb As Button
End Class
