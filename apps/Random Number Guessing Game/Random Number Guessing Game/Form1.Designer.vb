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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblGuesses = New System.Windows.Forms.Label()
        Me.lblRandom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guess a number from 1 to 100. Click ""Play"" to Start."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(57, 77)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(138, 77)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of guesses:"
        '
        'lblGuesses
        '
        Me.lblGuesses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGuesses.Location = New System.Drawing.Point(131, 40)
        Me.lblGuesses.Name = "lblGuesses"
        Me.lblGuesses.Size = New System.Drawing.Size(106, 23)
        Me.lblGuesses.TabIndex = 3
        Me.lblGuesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRandom
        '
        Me.lblRandom.Location = New System.Drawing.Point(219, 77)
        Me.lblRandom.Name = "lblRandom"
        Me.lblRandom.Size = New System.Drawing.Size(44, 23)
        Me.lblRandom.TabIndex = 4
        Me.lblRandom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 116)
        Me.Controls.Add(Me.lblRandom)
        Me.Controls.Add(Me.lblGuesses)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Number Guess Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblGuesses As System.Windows.Forms.Label
    Friend WithEvents lblRandom As System.Windows.Forms.Label

End Class
