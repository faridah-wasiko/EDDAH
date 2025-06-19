<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compute_Application
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
        Me.Number1TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Number2TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ResultsTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SubtractButton = New System.Windows.Forms.Button()
        Me.MultiplyButton = New System.Windows.Forms.Button()
        Me.DivisonButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter first name"
        '
        'Number1TextBox
        '
        Me.Number1TextBox.Location = New System.Drawing.Point(139, 41)
        Me.Number1TextBox.Name = "Number1TextBox"
        Me.Number1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Number1TextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter second name"
        '
        'Number2TextBox
        '
        Me.Number2TextBox.Location = New System.Drawing.Point(139, 97)
        Me.Number2TextBox.Name = "Number2TextBox"
        Me.Number2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Number2TextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Results"
        '
        'ResultsTextBox
        '
        Me.ResultsTextBox.Location = New System.Drawing.Point(139, 137)
        Me.ResultsTextBox.Name = "ResultsTextBox"
        Me.ResultsTextBox.ReadOnly = True
        Me.ResultsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ResultsTextBox.TabIndex = 5
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(47, 249)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 6
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'SubtractButton
        '
        Me.SubtractButton.Location = New System.Drawing.Point(188, 249)
        Me.SubtractButton.Name = "SubtractButton"
        Me.SubtractButton.Size = New System.Drawing.Size(75, 23)
        Me.SubtractButton.TabIndex = 7
        Me.SubtractButton.Text = "Subtract"
        Me.SubtractButton.UseVisualStyleBackColor = True
        '
        'MultiplyButton
        '
        Me.MultiplyButton.Location = New System.Drawing.Point(329, 249)
        Me.MultiplyButton.Name = "MultiplyButton"
        Me.MultiplyButton.Size = New System.Drawing.Size(75, 23)
        Me.MultiplyButton.TabIndex = 8
        Me.MultiplyButton.Text = "Multiply"
        Me.MultiplyButton.UseVisualStyleBackColor = True
        '
        'DivisonButton
        '
        Me.DivisonButton.Location = New System.Drawing.Point(47, 323)
        Me.DivisonButton.Name = "DivisonButton"
        Me.DivisonButton.Size = New System.Drawing.Size(75, 23)
        Me.DivisonButton.TabIndex = 9
        Me.DivisonButton.Text = "Division"
        Me.DivisonButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(188, 323)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(329, 323)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Compute_Application
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DivisonButton)
        Me.Controls.Add(Me.MultiplyButton)
        Me.Controls.Add(Me.SubtractButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ResultsTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Number2TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Number1TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Compute_Application"
        Me.Text = "Compute_Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Number1TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Number2TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ResultsTextBox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents SubtractButton As Button
    Friend WithEvents MultiplyButton As Button
    Friend WithEvents DivisonButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
End Class
