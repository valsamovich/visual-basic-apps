<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bntEnterScores = New System.Windows.Forms.Button()
        Me.btnSaveScores = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLoadGrades = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bntEnterScores
        '
        Me.bntEnterScores.Location = New System.Drawing.Point(12, 12)
        Me.bntEnterScores.Name = "bntEnterScores"
        Me.bntEnterScores.Size = New System.Drawing.Size(110, 25)
        Me.bntEnterScores.TabIndex = 0
        Me.bntEnterScores.Text = "Enter Scores"
        Me.bntEnterScores.UseVisualStyleBackColor = True
        '
        'btnSaveScores
        '
        Me.btnSaveScores.Location = New System.Drawing.Point(128, 12)
        Me.btnSaveScores.Name = "btnSaveScores"
        Me.btnSaveScores.Size = New System.Drawing.Size(110, 25)
        Me.btnSaveScores.TabIndex = 1
        Me.btnSaveScores.Text = "Save Scores to File"
        Me.btnSaveScores.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(374, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLoadGrades
        '
        Me.btnLoadGrades.Location = New System.Drawing.Point(244, 12)
        Me.btnLoadGrades.Name = "btnLoadGrades"
        Me.btnLoadGrades.Size = New System.Drawing.Size(124, 25)
        Me.btnLoadGrades.TabIndex = 3
        Me.btnLoadGrades.Text = "Load Grades from File"
        Me.btnLoadGrades.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 333)
        Me.Controls.Add(Me.btnLoadGrades)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSaveScores)
        Me.Controls.Add(Me.bntEnterScores)
        Me.Name = "Form1"
        Me.Text = "Valery Samovich's All COP1000 Grades"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bntEnterScores As System.Windows.Forms.Button
    Friend WithEvents btnSaveScores As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnLoadGrades As System.Windows.Forms.Button

End Class
