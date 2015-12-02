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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lstNumOccurences = New System.Windows.Forms.ListBox()
        Me.btnCountNumerals = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number:"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(100, 28)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(155, 20)
        Me.txtNum.TabIndex = 1
        '
        'lstNumOccurences
        '
        Me.lstNumOccurences.FormattingEnabled = True
        Me.lstNumOccurences.Location = New System.Drawing.Point(15, 77)
        Me.lstNumOccurences.Name = "lstNumOccurences"
        Me.lstNumOccurences.Size = New System.Drawing.Size(120, 134)
        Me.lstNumOccurences.TabIndex = 2
        '
        'btnCountNumerals
        '
        Me.btnCountNumerals.Location = New System.Drawing.Point(162, 77)
        Me.btnCountNumerals.Name = "btnCountNumerals"
        Me.btnCountNumerals.Size = New System.Drawing.Size(93, 27)
        Me.btnCountNumerals.TabIndex = 3
        Me.btnCountNumerals.Text = "Count Numerals"
        Me.btnCountNumerals.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 223)
        Me.Controls.Add(Me.btnCountNumerals)
        Me.Controls.Add(Me.lstNumOccurences)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Number Occurences"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents lstNumOccurences As System.Windows.Forms.ListBox
    Friend WithEvents btnCountNumerals As System.Windows.Forms.Button

End Class
