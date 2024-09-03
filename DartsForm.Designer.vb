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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DartsForm))
        Me.DartPictureBox = New System.Windows.Forms.PictureBox()
        Me.ThrowButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DartPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DartPictureBox
        '
        Me.DartPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DartPictureBox.Image = Global.DartsProyect.My.Resources.Resources.New_Dart_Board
        Me.DartPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.DartPictureBox.Name = "DartPictureBox"
        Me.DartPictureBox.Size = New System.Drawing.Size(478, 436)
        Me.DartPictureBox.TabIndex = 0
        Me.DartPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DartPictureBox, "Displays the board for the dart game.")
        '
        'ThrowButton
        '
        Me.ThrowButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThrowButton.Location = New System.Drawing.Point(553, 364)
        Me.ThrowButton.Name = "ThrowButton"
        Me.ThrowButton.Size = New System.Drawing.Size(144, 84)
        Me.ThrowButton.TabIndex = 1
        Me.ThrowButton.Text = "Throw"
        Me.ToolTip1.SetToolTip(Me.ThrowButton, "Throws 3 aleatory ""darts"" to the net and saves the coordinates of this points.")
        Me.ThrowButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(553, 274)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(144, 84)
        Me.ResetButton.TabIndex = 2
        Me.ResetButton.Text = "Reset"
        Me.ToolTip1.SetToolTip(Me.ResetButton, "Resets the program to make a new game.")
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(553, 184)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(144, 84)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Closes the program.")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'DartsForm
        '
        Me.AcceptButton = Me.ThrowButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(721, 466)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ThrowButton)
        Me.Controls.Add(Me.DartPictureBox)
        Me.Name = "DartsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Darts Game"
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        CType(Me.DartPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DartPictureBox As PictureBox
    Friend WithEvents ThrowButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
