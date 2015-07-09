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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkLubeJob = New System.Windows.Forms.CheckBox()
        Me.chkOilChange = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkTransmissionFlush = New System.Windows.Forms.CheckBox()
        Me.chkRadiatorFlush = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkTireRotation = New System.Windows.Forms.CheckBox()
        Me.chkReplaceMuffler = New System.Windows.Forms.CheckBox()
        Me.chkInspection = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTotalFees = New System.Windows.Forms.Label()
        Me.lblTaxOnParts = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.lblServicesAndLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.chkLubeJob)
        Me.GroupBox1.Controls.Add(Me.chkOilChange)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oil Change"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(142, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "($18.00)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(143, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "($26.00)"
        '
        'chkLubeJob
        '
        Me.chkLubeJob.AutoSize = True
        Me.chkLubeJob.Location = New System.Drawing.Point(21, 42)
        Me.chkLubeJob.Name = "chkLubeJob"
        Me.chkLubeJob.Size = New System.Drawing.Size(70, 17)
        Me.chkLubeJob.TabIndex = 1
        Me.chkLubeJob.Text = "Lube Job"
        Me.chkLubeJob.UseVisualStyleBackColor = True
        '
        'chkOilChange
        '
        Me.chkOilChange.AutoSize = True
        Me.chkOilChange.Location = New System.Drawing.Point(21, 19)
        Me.chkOilChange.Name = "chkOilChange"
        Me.chkOilChange.Size = New System.Drawing.Size(78, 17)
        Me.chkOilChange.TabIndex = 0
        Me.chkOilChange.Text = "Oil Change"
        Me.chkOilChange.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.chkTransmissionFlush)
        Me.GroupBox2.Controls.Add(Me.chkRadiatorFlush)
        Me.GroupBox2.Location = New System.Drawing.Point(243, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 73)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flushes"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(144, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "($30.00)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(144, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "($80.00)"
        '
        'chkTransmissionFlush
        '
        Me.chkTransmissionFlush.AutoSize = True
        Me.chkTransmissionFlush.Location = New System.Drawing.Point(21, 42)
        Me.chkTransmissionFlush.Name = "chkTransmissionFlush"
        Me.chkTransmissionFlush.Size = New System.Drawing.Size(115, 17)
        Me.chkTransmissionFlush.TabIndex = 1
        Me.chkTransmissionFlush.Text = "Transmission Flush"
        Me.chkTransmissionFlush.UseVisualStyleBackColor = True
        '
        'chkRadiatorFlush
        '
        Me.chkRadiatorFlush.AutoSize = True
        Me.chkRadiatorFlush.Location = New System.Drawing.Point(21, 19)
        Me.chkRadiatorFlush.Name = "chkRadiatorFlush"
        Me.chkRadiatorFlush.Size = New System.Drawing.Size(94, 17)
        Me.chkRadiatorFlush.TabIndex = 0
        Me.chkRadiatorFlush.Text = "Radiator Flush"
        Me.chkRadiatorFlush.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.chkTireRotation)
        Me.GroupBox3.Controls.Add(Me.chkReplaceMuffler)
        Me.GroupBox3.Controls.Add(Me.chkInspection)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(225, 97)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Misc"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(144, 66)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "($20.00)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(144, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "($100.00)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(144, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "($15.00)"
        '
        'chkTireRotation
        '
        Me.chkTireRotation.AutoSize = True
        Me.chkTireRotation.Location = New System.Drawing.Point(21, 65)
        Me.chkTireRotation.Name = "chkTireRotation"
        Me.chkTireRotation.Size = New System.Drawing.Size(87, 17)
        Me.chkTireRotation.TabIndex = 2
        Me.chkTireRotation.Text = "Tire Rotation"
        Me.chkTireRotation.UseVisualStyleBackColor = True
        '
        'chkReplaceMuffler
        '
        Me.chkReplaceMuffler.AutoSize = True
        Me.chkReplaceMuffler.Location = New System.Drawing.Point(21, 42)
        Me.chkReplaceMuffler.Name = "chkReplaceMuffler"
        Me.chkReplaceMuffler.Size = New System.Drawing.Size(101, 17)
        Me.chkReplaceMuffler.TabIndex = 1
        Me.chkReplaceMuffler.Text = "Replace Muffler"
        Me.chkReplaceMuffler.UseVisualStyleBackColor = True
        '
        'chkInspection
        '
        Me.chkInspection.AutoSize = True
        Me.chkInspection.Location = New System.Drawing.Point(21, 19)
        Me.chkInspection.Name = "chkInspection"
        Me.chkInspection.Size = New System.Drawing.Size(75, 17)
        Me.chkInspection.TabIndex = 0
        Me.chkInspection.Text = "Inspection"
        Me.chkInspection.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtLabor)
        Me.GroupBox4.Controls.Add(Me.txtParts)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(243, 91)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(225, 97)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Parts and Labor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(133, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "($20.00 per hour)"
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(66, 54)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(60, 20)
        Me.txtLabor.TabIndex = 3
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(66, 28)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(60, 20)
        Me.txtParts.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Labor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parts"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTotalFees)
        Me.GroupBox5.Controls.Add(Me.lblTaxOnParts)
        Me.GroupBox5.Controls.Add(Me.lblParts)
        Me.GroupBox5.Controls.Add(Me.lblServicesAndLabel)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 194)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(456, 139)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Summary"
        '
        'lblTotalFees
        '
        Me.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalFees.Location = New System.Drawing.Point(221, 104)
        Me.lblTotalFees.Name = "lblTotalFees"
        Me.lblTotalFees.Size = New System.Drawing.Size(100, 20)
        Me.lblTotalFees.TabIndex = 7
        '
        'lblTaxOnParts
        '
        Me.lblTaxOnParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxOnParts.Location = New System.Drawing.Point(221, 76)
        Me.lblTaxOnParts.Name = "lblTaxOnParts"
        Me.lblTaxOnParts.Size = New System.Drawing.Size(100, 20)
        Me.lblTaxOnParts.TabIndex = 6
        '
        'lblParts
        '
        Me.lblParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblParts.Location = New System.Drawing.Point(221, 48)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(100, 20)
        Me.lblParts.TabIndex = 5
        '
        'lblServicesAndLabel
        '
        Me.lblServicesAndLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblServicesAndLabel.Location = New System.Drawing.Point(221, 20)
        Me.lblServicesAndLabel.Name = "lblServicesAndLabel"
        Me.lblServicesAndLabel.Size = New System.Drawing.Size(100, 20)
        Me.lblServicesAndLabel.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(158, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total Fees"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tax (on parts)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Parts"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Services && Labor"
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Location = New System.Drawing.Point(103, 347)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(111, 30)
        Me.btnCalculateTotal.TabIndex = 4
        Me.btnCalculateTotal.Text = "Calculate Total"
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(220, 347)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(301, 347)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 392)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Valery Samovich's Joe's Automotive"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkLubeJob As System.Windows.Forms.CheckBox
    Friend WithEvents chkOilChange As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTransmissionFlush As System.Windows.Forms.CheckBox
    Friend WithEvents chkRadiatorFlush As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTireRotation As System.Windows.Forms.CheckBox
    Friend WithEvents chkReplaceMuffler As System.Windows.Forms.CheckBox
    Friend WithEvents chkInspection As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLabor As System.Windows.Forms.TextBox
    Friend WithEvents txtParts As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalFees As System.Windows.Forms.Label
    Friend WithEvents lblTaxOnParts As System.Windows.Forms.Label
    Friend WithEvents lblParts As System.Windows.Forms.Label
    Friend WithEvents lblServicesAndLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalculateTotal As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label

End Class
