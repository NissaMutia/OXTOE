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
        Me.play = New System.Windows.Forms.Button()
        Me.about = New System.Windows.Forms.Button()
        Me.exito = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hint = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'play
        '
        Me.play.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.play.Location = New System.Drawing.Point(12, 204)
        Me.play.Name = "play"
        Me.play.Size = New System.Drawing.Size(260, 32)
        Me.play.TabIndex = 1
        Me.play.Text = "MULAI PERMAINAN"
        Me.play.UseVisualStyleBackColor = True
        '
        'about
        '
        Me.about.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.about.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.about.Location = New System.Drawing.Point(12, 280)
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(260, 32)
        Me.about.TabIndex = 2
        Me.about.Text = "TENTANG DEVELOPER"
        Me.about.UseVisualStyleBackColor = True
        '
        'exito
        '
        Me.exito.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exito.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exito.Location = New System.Drawing.Point(12, 318)
        Me.exito.Name = "exito"
        Me.exito.Size = New System.Drawing.Size(260, 32)
        Me.exito.TabIndex = 3
        Me.exito.Text = "KELUAR"
        Me.exito.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "version 1.2.3"
        '
        'hint
        '
        Me.hint.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hint.Location = New System.Drawing.Point(12, 242)
        Me.hint.Name = "hint"
        Me.hint.Size = New System.Drawing.Size(260, 32)
        Me.hint.TabIndex = 5
        Me.hint.Text = "CARA BERMAIN"
        Me.hint.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 362)
        Me.Controls.Add(Me.hint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exito)
        Me.Controls.Add(Me.about)
        Me.Controls.Add(Me.play)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OXTOE (home)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents play As System.Windows.Forms.Button
    Friend WithEvents about As System.Windows.Forms.Button
    Friend WithEvents exito As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents hint As System.Windows.Forms.Button

End Class
