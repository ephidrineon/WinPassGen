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
        Me.PwTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComplexCheckbox = New System.Windows.Forms.CheckBox()
        Me.PwLengthBar = New System.Windows.Forms.TrackBar()
        Me.NumbersCheckbox = New System.Windows.Forms.CheckBox()
        Me.LettersCheckbox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PwLengthBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PwTextBox
        '
        Me.PwTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PwTextBox.Font = New System.Drawing.Font("Lucida Console", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PwTextBox.Location = New System.Drawing.Point(12, 12)
        Me.PwTextBox.Margin = New System.Windows.Forms.Padding(3, 16, 3, 3)
        Me.PwTextBox.Multiline = True
        Me.PwTextBox.Name = "PwTextBox"
        Me.PwTextBox.ReadOnly = True
        Me.PwTextBox.Size = New System.Drawing.Size(625, 94)
        Me.PwTextBox.TabIndex = 0
        Me.PwTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComplexCheckbox)
        Me.GroupBox1.Controls.Add(Me.NumbersCheckbox)
        Me.GroupBox1.Controls.Add(Me.PwLengthBar)
        Me.GroupBox1.Controls.Add(Me.LettersCheckbox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 92)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'ComplexCheckbox
        '
        Me.ComplexCheckbox.AutoSize = True
        Me.ComplexCheckbox.Checked = True
        Me.ComplexCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ComplexCheckbox.Location = New System.Drawing.Point(154, 65)
        Me.ComplexCheckbox.Name = "ComplexCheckbox"
        Me.ComplexCheckbox.Size = New System.Drawing.Size(120, 17)
        Me.ComplexCheckbox.TabIndex = 5
        Me.ComplexCheckbox.Text = "Complex Characters"
        Me.ComplexCheckbox.UseVisualStyleBackColor = True
        '
        'PwLengthBar
        '
        Me.PwLengthBar.Location = New System.Drawing.Point(6, 19)
        Me.PwLengthBar.Maximum = 64
        Me.PwLengthBar.Minimum = 8
        Me.PwLengthBar.Name = "PwLengthBar"
        Me.PwLengthBar.Size = New System.Drawing.Size(612, 45)
        Me.PwLengthBar.TabIndex = 0
        Me.PwLengthBar.Value = 8
        '
        'NumbersCheckbox
        '
        Me.NumbersCheckbox.AutoSize = True
        Me.NumbersCheckbox.Checked = True
        Me.NumbersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NumbersCheckbox.Location = New System.Drawing.Point(80, 65)
        Me.NumbersCheckbox.Name = "NumbersCheckbox"
        Me.NumbersCheckbox.Size = New System.Drawing.Size(68, 17)
        Me.NumbersCheckbox.TabIndex = 4
        Me.NumbersCheckbox.Text = "Numbers"
        Me.NumbersCheckbox.UseVisualStyleBackColor = True
        '
        'LettersCheckbox
        '
        Me.LettersCheckbox.AutoSize = True
        Me.LettersCheckbox.Checked = True
        Me.LettersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LettersCheckbox.Location = New System.Drawing.Point(16, 65)
        Me.LettersCheckbox.Name = "LettersCheckbox"
        Me.LettersCheckbox.Size = New System.Drawing.Size(58, 17)
        Me.LettersCheckbox.TabIndex = 3
        Me.LettersCheckbox.Text = "Letters"
        Me.LettersCheckbox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Generate!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(598, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "8"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(217, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Copy to clipboard"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(561, 210)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(505, 65)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Insane mode"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(649, 246)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PwTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WinPwGen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PwLengthBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PwTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PwLengthBar As TrackBar
    Friend WithEvents Button1 As Button
    Friend WithEvents LettersCheckbox As CheckBox
    Friend WithEvents NumbersCheckbox As CheckBox
    Friend WithEvents ComplexCheckbox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
