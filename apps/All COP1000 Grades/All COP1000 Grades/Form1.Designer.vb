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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstTutorials = New System.Windows.Forms.ListBox()
        Me.lstTests = New System.Windows.Forms.ListBox()
        Me.lstProjects = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bntEnterScores
        '
        Me.bntEnterScores.Location = New System.Drawing.Point(12, 224)
        Me.bntEnterScores.Name = "bntEnterScores"
        Me.bntEnterScores.Size = New System.Drawing.Size(124, 25)
        Me.bntEnterScores.TabIndex = 0
        Me.bntEnterScores.Text = "Enter Scores"
        Me.bntEnterScores.UseVisualStyleBackColor = True
        '
        'btnSaveScores
        '
        Me.btnSaveScores.Location = New System.Drawing.Point(272, 224)
        Me.btnSaveScores.Name = "btnSaveScores"
        Me.btnSaveScores.Size = New System.Drawing.Size(124, 25)
        Me.btnSaveScores.TabIndex = 1
        Me.btnSaveScores.Text = "Save Scores to File"
        Me.btnSaveScores.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(402, 224)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 25)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLoadGrades
        '
        Me.btnLoadGrades.Location = New System.Drawing.Point(142, 224)
        Me.btnLoadGrades.Name = "btnLoadGrades"
        Me.btnLoadGrades.Size = New System.Drawing.Size(124, 25)
        Me.btnLoadGrades.TabIndex = 3
        Me.btnLoadGrades.Text = "Load Grades from File"
        Me.btnLoadGrades.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lstProjects)
        Me.GroupBox1.Controls.Add(Me.lstTutorials)
        Me.GroupBox1.Controls.Add(Me.lstTests)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 202)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Scores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Projects:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tutorials:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tests:"
        '
        'lstTutorials
        '
        Me.lstTutorials.FormattingEnabled = True
        Me.lstTutorials.Location = New System.Drawing.Point(102, 43)
        Me.lstTutorials.Name = "lstTutorials"
        Me.lstTutorials.Size = New System.Drawing.Size(85, 147)
        Me.lstTutorials.TabIndex = 1
        '
        'lstTests
        '
        Me.lstTests.FormattingEnabled = True
        Me.lstTests.Location = New System.Drawing.Point(11, 43)
        Me.lstTests.Name = "lstTests"
        Me.lstTests.Size = New System.Drawing.Size(85, 147)
        Me.lstTests.TabIndex = 0
        '
        'lstProjects
        '
        Me.lstProjects.FormattingEnabled = True
        Me.lstProjects.Location = New System.Drawing.Point(193, 43)
        Me.lstProjects.Name = "lstProjects"
        Me.lstProjects.Size = New System.Drawing.Size(85, 147)
        Me.lstProjects.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLoadGrades)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSaveScores)
        Me.Controls.Add(Me.bntEnterScores)
        Me.Name = "Form1"
        Me.Text = "Valery Samovich's All COP1000 Grades"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bntEnterScores As System.Windows.Forms.Button
    Friend WithEvents btnSaveScores As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnLoadGrades As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstTutorials As System.Windows.Forms.ListBox
    Friend WithEvents lstTests As System.Windows.Forms.ListBox
    Friend WithEvents lstProjects As System.Windows.Forms.ListBox

End Class
