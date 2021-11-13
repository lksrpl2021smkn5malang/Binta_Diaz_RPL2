<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.LblPhrase = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LblExtract = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblPhrase
        '
        Me.LblPhrase.AutoSize = True
        Me.LblPhrase.Location = New System.Drawing.Point(27, 56)
        Me.LblPhrase.Name = "LblPhrase"
        Me.LblPhrase.Size = New System.Drawing.Size(80, 13)
        Me.LblPhrase.TabIndex = 0
        Me.LblPhrase.Text = "Phrase Entered"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(123, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(123, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 20)
        Me.TextBox2.TabIndex = 3
        '
        'LblExtract
        '
        Me.LblExtract.AutoSize = True
        Me.LblExtract.Location = New System.Drawing.Point(27, 82)
        Me.LblExtract.Name = "LblExtract"
        Me.LblExtract.Size = New System.Drawing.Size(88, 13)
        Me.LblExtract.TabIndex = 2
        Me.LblExtract.Text = "Phrase Extracted"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(123, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Extract"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 183)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LblExtract)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblPhrase)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPhrase As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LblExtract As Label
    Friend WithEvents Button1 As Button
End Class
