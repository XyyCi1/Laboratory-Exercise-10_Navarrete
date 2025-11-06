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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.input = New System.Windows.Forms.TextBox()
        Me.ShowList = New System.Windows.Forms.Button()
        Me.ClearList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(319, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add to list"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(306, 154)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(100, 20)
        Me.input.TabIndex = 1
        '
        'ShowList
        '
        Me.ShowList.Location = New System.Drawing.Point(319, 242)
        Me.ShowList.Name = "ShowList"
        Me.ShowList.Size = New System.Drawing.Size(75, 23)
        Me.ShowList.TabIndex = 2
        Me.ShowList.Text = "Show list"
        Me.ShowList.UseVisualStyleBackColor = True
        '
        'ClearList
        '
        Me.ClearList.Location = New System.Drawing.Point(437, 228)
        Me.ClearList.Name = "ClearList"
        Me.ClearList.Size = New System.Drawing.Size(75, 23)
        Me.ClearList.TabIndex = 3
        Me.ClearList.Text = "Clear List"
        Me.ClearList.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ClearList)
        Me.Controls.Add(Me.ShowList)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents input As TextBox
    Friend WithEvents ShowList As Button
    Friend WithEvents ClearList As Button
End Class
