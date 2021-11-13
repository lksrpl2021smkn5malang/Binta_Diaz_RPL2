<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNum1 = New System.Windows.Forms.TextBox()
        Me.TxtNum2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.TxtAnswer = New System.Windows.Forms.TextBox()
        Me.TxtErrMsg = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number 2"
        '
        'TxtNum1
        '
        Me.TxtNum1.Location = New System.Drawing.Point(193, 61)
        Me.TxtNum1.Name = "TxtNum1"
        Me.TxtNum1.Size = New System.Drawing.Size(100, 20)
        Me.TxtNum1.TabIndex = 2
        '
        'TxtNum2
        '
        Me.TxtNum2.Location = New System.Drawing.Point(193, 100)
        Me.TxtNum2.Name = "TxtNum2"
        Me.TxtNum2.Size = New System.Drawing.Size(100, 20)
        Me.TxtNum2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number 1 / Number 2"
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(193, 202)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalculate.TabIndex = 6
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'TxtAnswer
        '
        Me.TxtAnswer.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAnswer.Location = New System.Drawing.Point(193, 144)
        Me.TxtAnswer.Name = "TxtAnswer"
        Me.TxtAnswer.Size = New System.Drawing.Size(100, 20)
        Me.TxtAnswer.TabIndex = 8
        '
        'TxtErrMsg
        '
        Me.TxtErrMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtErrMsg.Location = New System.Drawing.Point(46, 249)
        Me.TxtErrMsg.Name = "TxtErrMsg"
        Me.TxtErrMsg.Size = New System.Drawing.Size(261, 20)
        Me.TxtErrMsg.TabIndex = 9
        Me.TxtErrMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 317)
        Me.Controls.Add(Me.TxtErrMsg)
        Me.Controls.Add(Me.TxtAnswer)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNum2)
        Me.Controls.Add(Me.TxtNum1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form15"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form15"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNum1 As TextBox
    Friend WithEvents TxtNum2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents TxtAnswer As TextBox
    Friend WithEvents TxtErrMsg As TextBox
End Class
