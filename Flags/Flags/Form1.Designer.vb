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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.picItaly = New System.Windows.Forms.PictureBox()
        Me.picBrazil = New System.Windows.Forms.PictureBox()
        Me.picAustralia = New System.Windows.Forms.PictureBox()
        Me.picUK = New System.Windows.Forms.PictureBox()
        Me.picCanada = New System.Windows.Forms.PictureBox()
        Me.picUSA = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picItaly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrazil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAustralia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCanada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUSA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(70, 193)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 44
        Me.btnExit.Text = "Exit"
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(19, 161)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(176, 20)
        Me.lblMessage.TabIndex = 43
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picItaly
        '
        Me.picItaly.Image = CType(resources.GetObject("picItaly.Image"), System.Drawing.Image)
        Me.picItaly.Location = New System.Drawing.Point(139, 121)
        Me.picItaly.Name = "picItaly"
        Me.picItaly.Size = New System.Drawing.Size(32, 32)
        Me.picItaly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picItaly.TabIndex = 42
        Me.picItaly.TabStop = False
        '
        'picBrazil
        '
        Me.picBrazil.Image = CType(resources.GetObject("picBrazil.Image"), System.Drawing.Image)
        Me.picBrazil.Location = New System.Drawing.Point(139, 81)
        Me.picBrazil.Name = "picBrazil"
        Me.picBrazil.Size = New System.Drawing.Size(32, 32)
        Me.picBrazil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrazil.TabIndex = 41
        Me.picBrazil.TabStop = False
        '
        'picAustralia
        '
        Me.picAustralia.Image = CType(resources.GetObject("picAustralia.Image"), System.Drawing.Image)
        Me.picAustralia.Location = New System.Drawing.Point(139, 41)
        Me.picAustralia.Name = "picAustralia"
        Me.picAustralia.Size = New System.Drawing.Size(32, 32)
        Me.picAustralia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAustralia.TabIndex = 40
        Me.picAustralia.TabStop = False
        '
        'picUK
        '
        Me.picUK.Image = CType(resources.GetObject("picUK.Image"), System.Drawing.Image)
        Me.picUK.Location = New System.Drawing.Point(43, 121)
        Me.picUK.Name = "picUK"
        Me.picUK.Size = New System.Drawing.Size(32, 32)
        Me.picUK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUK.TabIndex = 39
        Me.picUK.TabStop = False
        '
        'picCanada
        '
        Me.picCanada.Image = CType(resources.GetObject("picCanada.Image"), System.Drawing.Image)
        Me.picCanada.Location = New System.Drawing.Point(43, 81)
        Me.picCanada.Name = "picCanada"
        Me.picCanada.Size = New System.Drawing.Size(32, 32)
        Me.picCanada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCanada.TabIndex = 38
        Me.picCanada.TabStop = False
        '
        'picUSA
        '
        Me.picUSA.Image = CType(resources.GetObject("picUSA.Image"), System.Drawing.Image)
        Me.picUSA.Location = New System.Drawing.Point(43, 41)
        Me.picUSA.Name = "picUSA"
        Me.picUSA.Size = New System.Drawing.Size(32, 32)
        Me.picUSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUSA.TabIndex = 37
        Me.picUSA.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Click a Flag to Learn Its Country"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 224)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.picItaly)
        Me.Controls.Add(Me.picBrazil)
        Me.Controls.Add(Me.picAustralia)
        Me.Controls.Add(Me.picUK)
        Me.Controls.Add(Me.picCanada)
        Me.Controls.Add(Me.picUSA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Flags"
        CType(Me.picItaly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrazil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAustralia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCanada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUSA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents picItaly As System.Windows.Forms.PictureBox
    Friend WithEvents picBrazil As System.Windows.Forms.PictureBox
    Friend WithEvents picAustralia As System.Windows.Forms.PictureBox
    Friend WithEvents picUK As System.Windows.Forms.PictureBox
    Friend WithEvents picCanada As System.Windows.Forms.PictureBox
    Friend WithEvents picUSA As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
