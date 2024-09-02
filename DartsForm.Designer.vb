<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DartsForm
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
        Me.DartPictureBox = New System.Windows.Forms.PictureBox()
        Me.ThrowButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.DartPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DartPictureBox
        '
        Me.DartPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DartPictureBox.Image = Global.DartsProyect.My.Resources.Resources.Dart_Net
        Me.DartPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.DartPictureBox.Name = "DartPictureBox"
        Me.DartPictureBox.Size = New System.Drawing.Size(1061, 985)
        Me.DartPictureBox.TabIndex = 0
        Me.DartPictureBox.TabStop = False
        '
        'ThrowButton
        '
        Me.ThrowButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThrowButton.Location = New System.Drawing.Point(1081, 912)
        Me.ThrowButton.Name = "ThrowButton"
        Me.ThrowButton.Size = New System.Drawing.Size(144, 84)
        Me.ThrowButton.TabIndex = 1
        Me.ThrowButton.Text = "Throw"
        Me.ThrowButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(1081, 822)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(144, 84)
        Me.ResetButton.TabIndex = 2
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(1081, 732)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(144, 84)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DartsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 1009)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ThrowButton)
        Me.Controls.Add(Me.DartPictureBox)
        Me.Name = "DartsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DartPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DartPictureBox As PictureBox
    Friend WithEvents ThrowButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents ExitButton As Button
End Class
