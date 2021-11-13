<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Me.BtnGo = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnForward = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.TxtURL = New System.Windows.Forms.TextBox()
        Me.MyWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'BtnGo
        '
        Me.BtnGo.Location = New System.Drawing.Point(674, 44)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(75, 23)
        Me.BtnGo.TabIndex = 0
        Me.BtnGo.Text = "Go"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(674, 89)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnHome
        '
        Me.BtnHome.Location = New System.Drawing.Point(674, 135)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(75, 23)
        Me.BtnHome.TabIndex = 2
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(674, 178)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 3
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnForward
        '
        Me.BtnForward.Location = New System.Drawing.Point(674, 221)
        Me.BtnForward.Name = "BtnForward"
        Me.BtnForward.Size = New System.Drawing.Size(75, 23)
        Me.BtnForward.TabIndex = 4
        Me.BtnForward.Text = "Forward"
        Me.BtnForward.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(674, 267)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.BtnRefresh.TabIndex = 5
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'TxtURL
        '
        Me.TxtURL.Location = New System.Drawing.Point(64, 45)
        Me.TxtURL.Name = "TxtURL"
        Me.TxtURL.Size = New System.Drawing.Size(568, 20)
        Me.TxtURL.TabIndex = 6
        '
        'MyWebBrowser
        '
        Me.MyWebBrowser.Location = New System.Drawing.Point(64, 87)
        Me.MyWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.MyWebBrowser.Name = "MyWebBrowser"
        Me.MyWebBrowser.Size = New System.Drawing.Size(568, 310)
        Me.MyWebBrowser.TabIndex = 7
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(821, 421)
        Me.Controls.Add(Me.MyWebBrowser)
        Me.Controls.Add(Me.TxtURL)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnForward)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnGo)
        Me.Name = "Form14"
        Me.Text = "My Browser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGo As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnForward As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents TxtURL As TextBox
    Friend WithEvents MyWebBrowser As WebBrowser
End Class
