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
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnCenter = New System.Windows.Forms.Button()
        Me.btnPosition = New System.Windows.Forms.Button()
        Me.lblTranslator = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(12, 12)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnLeft.TabIndex = 0
        Me.btnLeft.Text = "sinister"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(93, 12)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(75, 23)
        Me.btnRight.TabIndex = 1
        Me.btnRight.Text = "dexter"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnCenter
        '
        Me.btnCenter.Location = New System.Drawing.Point(174, 12)
        Me.btnCenter.Name = "btnCenter"
        Me.btnCenter.Size = New System.Drawing.Size(75, 23)
        Me.btnCenter.TabIndex = 2
        Me.btnCenter.Text = "medium"
        Me.btnCenter.UseVisualStyleBackColor = True
        '
        'btnPosition
        '
        Me.btnPosition.Location = New System.Drawing.Point(255, 12)
        Me.btnPosition.Name = "btnPosition"
        Me.btnPosition.Size = New System.Drawing.Size(75, 23)
        Me.btnPosition.TabIndex = 3
        Me.btnPosition.Text = "catastema"
        Me.btnPosition.UseVisualStyleBackColor = True
        '
        'lblTranslator
        '
        Me.lblTranslator.Location = New System.Drawing.Point(12, 48)
        Me.lblTranslator.Name = "lblTranslator"
        Me.lblTranslator.Size = New System.Drawing.Size(318, 26)
        Me.lblTranslator.TabIndex = 4
        Me.lblTranslator.Text = "None"
        Me.lblTranslator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTranslator.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(134, 85)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 118)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTranslator)
        Me.Controls.Add(Me.btnPosition)
        Me.Controls.Add(Me.btnCenter)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Name = "Form1"
        Me.Text = "Valery Samovich"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnCenter As System.Windows.Forms.Button
    Friend WithEvents btnPosition As System.Windows.Forms.Button
    Friend WithEvents lblTranslator As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
