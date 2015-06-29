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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumberOfGuesses = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGuessNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guess a number from 1 to 100. Click ""Play"" to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "test your number with random gener" & _
    "ated number." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use ""Game Message"" to validate yuor guess."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNumberOfGuesses)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtGuessNumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 87)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Game properties"
        '
        'lblNumberOfGuesses
        '
        Me.lblNumberOfGuesses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumberOfGuesses.Location = New System.Drawing.Point(119, 50)
        Me.lblNumberOfGuesses.Name = "lblNumberOfGuesses"
        Me.lblNumberOfGuesses.Size = New System.Drawing.Size(106, 20)
        Me.lblNumberOfGuesses.TabIndex = 3
        Me.lblNumberOfGuesses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of guesses:"
        '
        'txtGuessNumber
        '
        Me.txtGuessNumber.Location = New System.Drawing.Point(119, 23)
        Me.txtGuessNumber.Name = "txtGuessNumber"
        Me.txtGuessNumber.Size = New System.Drawing.Size(106, 20)
        Me.txtGuessNumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Guess a number:"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(14, 244)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(178, 244)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblMessage)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(241, 57)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Game Message"
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(15, 23)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(210, 20)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(97, 244)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 283)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Number Guess Game"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumberOfGuesses As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGuessNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
