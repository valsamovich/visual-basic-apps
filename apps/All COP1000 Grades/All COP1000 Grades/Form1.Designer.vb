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
        Me.btnLoadScores = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstProjects = New System.Windows.Forms.ListBox()
        Me.lstTutorials = New System.Windows.Forms.ListBox()
        Me.lstTests = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPercentageGrade = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPointsEarned = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPossiblePoints = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblProjectArray = New System.Windows.Forms.Label()
        Me.lblTutorialArray = New System.Windows.Forms.Label()
        Me.lblTestArray = New System.Windows.Forms.Label()
        Me.lstArrayLoad = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bntEnterScores
        '
        Me.bntEnterScores.Location = New System.Drawing.Point(12, 408)
        Me.bntEnterScores.Name = "bntEnterScores"
        Me.bntEnterScores.Size = New System.Drawing.Size(80, 42)
        Me.bntEnterScores.TabIndex = 0
        Me.bntEnterScores.Text = "Enter Scores"
        Me.bntEnterScores.UseVisualStyleBackColor = True
        '
        'btnSaveScores
        '
        Me.btnSaveScores.Location = New System.Drawing.Point(98, 408)
        Me.btnSaveScores.Name = "btnSaveScores"
        Me.btnSaveScores.Size = New System.Drawing.Size(80, 42)
        Me.btnSaveScores.TabIndex = 1
        Me.btnSaveScores.Text = "Save Scores to File"
        Me.btnSaveScores.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(270, 408)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 42)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLoadScores
        '
        Me.btnLoadScores.Location = New System.Drawing.Point(184, 408)
        Me.btnLoadScores.Name = "btnLoadScores"
        Me.btnLoadScores.Size = New System.Drawing.Size(80, 42)
        Me.btnLoadScores.TabIndex = 3
        Me.btnLoadScores.Text = "Load Scores from File"
        Me.btnLoadScores.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lstProjects)
        Me.GroupBox1.Controls.Add(Me.lstTutorials)
        Me.GroupBox1.Controls.Add(Me.lstTests)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 202)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Projects:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tutorials:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tests:"
        '
        'lstProjects
        '
        Me.lstProjects.FormattingEnabled = True
        Me.lstProjects.Location = New System.Drawing.Point(225, 41)
        Me.lstProjects.Name = "lstProjects"
        Me.lstProjects.Size = New System.Drawing.Size(100, 147)
        Me.lstProjects.TabIndex = 2
        '
        'lstTutorials
        '
        Me.lstTutorials.FormattingEnabled = True
        Me.lstTutorials.Location = New System.Drawing.Point(119, 41)
        Me.lstTutorials.Name = "lstTutorials"
        Me.lstTutorials.Size = New System.Drawing.Size(100, 147)
        Me.lstTutorials.TabIndex = 1
        '
        'lstTests
        '
        Me.lstTests.FormattingEnabled = True
        Me.lstTests.Location = New System.Drawing.Point(13, 41)
        Me.lstTests.Name = "lstTests"
        Me.lstTests.Size = New System.Drawing.Size(100, 147)
        Me.lstTests.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Grade average calculator"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPercentageGrade)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblPointsEarned)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblPossiblePoints)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 133)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Points && Grade"
        '
        'lblPercentageGrade
        '
        Me.lblPercentageGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPercentageGrade.Location = New System.Drawing.Point(170, 91)
        Me.lblPercentageGrade.Name = "lblPercentageGrade"
        Me.lblPercentageGrade.Size = New System.Drawing.Size(100, 23)
        Me.lblPercentageGrade.TabIndex = 3
        Me.lblPercentageGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Overall grade percentage:"
        '
        'lblPointsEarned
        '
        Me.lblPointsEarned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPointsEarned.Location = New System.Drawing.Point(170, 59)
        Me.lblPointsEarned.Name = "lblPointsEarned"
        Me.lblPointsEarned.Size = New System.Drawing.Size(100, 23)
        Me.lblPointsEarned.TabIndex = 3
        Me.lblPointsEarned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total points earned:"
        '
        'lblPossiblePoints
        '
        Me.lblPossiblePoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPossiblePoints.Location = New System.Drawing.Point(170, 25)
        Me.lblPossiblePoints.Name = "lblPossiblePoints"
        Me.lblPossiblePoints.Size = New System.Drawing.Size(100, 23)
        Me.lblPossiblePoints.TabIndex = 1
        Me.lblPossiblePoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total possible points:"
        '
        'lblProjectArray
        '
        Me.lblProjectArray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProjectArray.Location = New System.Drawing.Point(237, 466)
        Me.lblProjectArray.Name = "lblProjectArray"
        Me.lblProjectArray.Size = New System.Drawing.Size(100, 23)
        Me.lblProjectArray.TabIndex = 12
        Me.lblProjectArray.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTutorialArray
        '
        Me.lblTutorialArray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTutorialArray.Location = New System.Drawing.Point(131, 466)
        Me.lblTutorialArray.Name = "lblTutorialArray"
        Me.lblTutorialArray.Size = New System.Drawing.Size(100, 23)
        Me.lblTutorialArray.TabIndex = 12
        Me.lblTutorialArray.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTestArray
        '
        Me.lblTestArray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTestArray.Location = New System.Drawing.Point(25, 466)
        Me.lblTestArray.Name = "lblTestArray"
        Me.lblTestArray.Size = New System.Drawing.Size(100, 23)
        Me.lblTestArray.TabIndex = 12
        Me.lblTestArray.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstArrayLoad
        '
        Me.lstArrayLoad.FormattingEnabled = True
        Me.lstArrayLoad.Location = New System.Drawing.Point(12, 502)
        Me.lstArrayLoad.Name = "lstArrayLoad"
        Me.lstArrayLoad.Size = New System.Drawing.Size(120, 95)
        Me.lstArrayLoad.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 613)
        Me.Controls.Add(Me.lstArrayLoad)
        Me.Controls.Add(Me.lblProjectArray)
        Me.Controls.Add(Me.lblTutorialArray)
        Me.Controls.Add(Me.lblTestArray)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLoadScores)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSaveScores)
        Me.Controls.Add(Me.bntEnterScores)
        Me.Name = "Form1"
        Me.Text = "Valery Samovich's All COP1000 Grades"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bntEnterScores As System.Windows.Forms.Button
    Friend WithEvents btnSaveScores As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnLoadScores As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstTutorials As System.Windows.Forms.ListBox
    Friend WithEvents lstTests As System.Windows.Forms.ListBox
    Friend WithEvents lstProjects As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPointsEarned As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPossiblePoints As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPercentageGrade As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblProjectArray As System.Windows.Forms.Label
    Friend WithEvents lblTutorialArray As System.Windows.Forms.Label
    Friend WithEvents lblTestArray As System.Windows.Forms.Label
    Friend WithEvents lstArrayLoad As System.Windows.Forms.ListBox

End Class
