<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Startup
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Startup))
    Me.Button_ChooseDrive = New System.Windows.Forms.Button()
    Me.Label_SelectDrive = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'Button_ChooseDrive
    '
    Me.Button_ChooseDrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Button_ChooseDrive.Location = New System.Drawing.Point(90, 40)
    Me.Button_ChooseDrive.Name = "Button_ChooseDrive"
    Me.Button_ChooseDrive.Size = New System.Drawing.Size(104, 23)
    Me.Button_ChooseDrive.TabIndex = 6
    Me.Button_ChooseDrive.Text = "Choose Drive"
    Me.Button_ChooseDrive.UseVisualStyleBackColor = True
    '
    'Label_SelectDrive
    '
    Me.Label_SelectDrive.AutoSize = True
    Me.Label_SelectDrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label_SelectDrive.ForeColor = System.Drawing.Color.Red
    Me.Label_SelectDrive.Location = New System.Drawing.Point(10, 3)
    Me.Label_SelectDrive.Name = "Label_SelectDrive"
    Me.Label_SelectDrive.Size = New System.Drawing.Size(264, 31)
    Me.Label_SelectDrive.TabIndex = 5
    Me.Label_SelectDrive.Text = "Please select a drive"
    '
    'Form_Startup
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(284, 72)
    Me.Controls.Add(Me.Button_ChooseDrive)
    Me.Controls.Add(Me.Label_SelectDrive)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximumSize = New System.Drawing.Size(300, 110)
    Me.MinimumSize = New System.Drawing.Size(300, 110)
    Me.Name = "Form_Startup"
    Me.Text = "Select Drive"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Button_ChooseDrive As System.Windows.Forms.Button
  Friend WithEvents Label_SelectDrive As System.Windows.Forms.Label
End Class
