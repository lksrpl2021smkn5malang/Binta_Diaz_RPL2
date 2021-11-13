<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblHeight = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LblWeight = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LblBMI = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblHeight
        '
        Me.LblHeight.AutoSize = True
        Me.LblHeight.Location = New System.Drawing.Point(26, 35)
        Me.LblHeight.Name = "LblHeight"
        Me.LblHeight.Size = New System.Drawing.Size(58, 13)
        Me.LblHeight.TabIndex = 0
        Me.LblHeight.Text = "Height(cm)"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(129, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(129, 71)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'LblWeight
        '
        Me.LblWeight.AutoSize = True
        Me.LblWeight.Location = New System.Drawing.Point(26, 74)
        Me.LblWeight.Name = "LblWeight"
        Me.LblWeight.Size = New System.Drawing.Size(60, 13)
        Me.LblWeight.TabIndex = 2
        Me.LblWeight.Text = "Weight(Kg)"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(129, 110)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'LblBMI
        '
        Me.LblBMI.AutoSize = True
        Me.LblBMI.Location = New System.Drawing.Point(26, 113)
        Me.LblBMI.Name = "LblBMI"
        Me.LblBMI.Size = New System.Drawing.Size(35, 13)
        Me.LblBMI.TabIndex = 4
        Me.LblBMI.Text = "BMI ="
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(103, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LblBMI)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LblWeight)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblHeight)
        Me.Name = "Form9"
        Me.Text = "Function(BMI Calculate)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHeight As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LblWeight As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LblBMI As Label
    Friend WithEvents Button1 As Button
End Class
