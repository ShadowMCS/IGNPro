<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Input = New System.Windows.Forms.ListBox()
        Me.Output = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StartChecking = New System.Windows.Forms.Button()
        Me.StopCheck = New System.Windows.Forms.Button()
        Me.Export = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.FormattingEnabled = True
        Me.Input.Location = New System.Drawing.Point(37, 41)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(143, 446)
        Me.Input.TabIndex = 1
        '
        'Output
        '
        Me.Output.FormattingEnabled = True
        Me.Output.Location = New System.Drawing.Point(433, 41)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(143, 446)
        Me.Output.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Input:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(430, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Output:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(68, 513)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Import"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StartChecking
        '
        Me.StartChecking.Location = New System.Drawing.Point(263, 538)
        Me.StartChecking.Name = "StartChecking"
        Me.StartChecking.Size = New System.Drawing.Size(96, 48)
        Me.StartChecking.TabIndex = 8
        Me.StartChecking.Text = "Start Checking"
        Me.StartChecking.UseVisualStyleBackColor = True
        '
        'StopCheck
        '
        Me.StopCheck.Location = New System.Drawing.Point(387, 538)
        Me.StopCheck.Name = "StopCheck"
        Me.StopCheck.Size = New System.Drawing.Size(96, 48)
        Me.StopCheck.TabIndex = 9
        Me.StopCheck.Text = "Stop Checking"
        Me.StopCheck.UseVisualStyleBackColor = True
        '
        'Export
        '
        Me.Export.Location = New System.Drawing.Point(636, 464)
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(75, 23)
        Me.Export.TabIndex = 10
        Me.Export.Text = "Export"
        Me.Export.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 637)
        Me.Controls.Add(Me.Export)
        Me.Controls.Add(Me.StopCheck)
        Me.Controls.Add(Me.StartChecking)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Input)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "IGNPro"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Input As ListBox
    Friend WithEvents Output As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents StartChecking As Button
    Friend WithEvents StopCheck As Button
    Friend WithEvents Export As Button
End Class
