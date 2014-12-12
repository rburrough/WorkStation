<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Settings
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Settings))
    Me.TextBox_BackupLocation = New System.Windows.Forms.TextBox()
    Me.Button_BackupLocation = New System.Windows.Forms.Button()
    Me.Label_BackupLocation = New System.Windows.Forms.Label()
    Me.FolderBrowserDialog_BackupLocation = New System.Windows.Forms.FolderBrowserDialog()
    Me.Button_Save = New System.Windows.Forms.Button()
    Me.Button_Cancel = New System.Windows.Forms.Button()
    Me.CheckBox_CopyIphoneBackup = New System.Windows.Forms.CheckBox()
    Me.CheckBox_BackupThumbnailDatabase = New System.Windows.Forms.CheckBox()
    Me.SuspendLayout()
    '
    'TextBox_BackupLocation
    '
    Me.TextBox_BackupLocation.Location = New System.Drawing.Point(12, 25)
    Me.TextBox_BackupLocation.Name = "TextBox_BackupLocation"
    Me.TextBox_BackupLocation.ReadOnly = True
    Me.TextBox_BackupLocation.Size = New System.Drawing.Size(219, 20)
    Me.TextBox_BackupLocation.TabIndex = 0
    '
    'Button_BackupLocation
    '
    Me.Button_BackupLocation.Location = New System.Drawing.Point(237, 25)
    Me.Button_BackupLocation.Name = "Button_BackupLocation"
    Me.Button_BackupLocation.Size = New System.Drawing.Size(35, 20)
    Me.Button_BackupLocation.TabIndex = 1
    Me.Button_BackupLocation.Text = "..."
    Me.Button_BackupLocation.UseVisualStyleBackColor = True
    '
    'Label_BackupLocation
    '
    Me.Label_BackupLocation.AutoSize = True
    Me.Label_BackupLocation.Location = New System.Drawing.Point(12, 9)
    Me.Label_BackupLocation.Name = "Label_BackupLocation"
    Me.Label_BackupLocation.Size = New System.Drawing.Size(84, 13)
    Me.Label_BackupLocation.TabIndex = 2
    Me.Label_BackupLocation.Text = "Backup location"
    '
    'Button_Save
    '
    Me.Button_Save.Location = New System.Drawing.Point(197, 227)
    Me.Button_Save.Name = "Button_Save"
    Me.Button_Save.Size = New System.Drawing.Size(75, 23)
    Me.Button_Save.TabIndex = 3
    Me.Button_Save.Text = "Save"
    Me.Button_Save.UseVisualStyleBackColor = True
    '
    'Button_Cancel
    '
    Me.Button_Cancel.Location = New System.Drawing.Point(12, 227)
    Me.Button_Cancel.Name = "Button_Cancel"
    Me.Button_Cancel.Size = New System.Drawing.Size(75, 23)
    Me.Button_Cancel.TabIndex = 4
    Me.Button_Cancel.Text = "Cancel"
    Me.Button_Cancel.UseVisualStyleBackColor = True
    '
    'CheckBox_CopyIphoneBackup
    '
    Me.CheckBox_CopyIphoneBackup.AutoSize = True
    Me.CheckBox_CopyIphoneBackup.Location = New System.Drawing.Point(12, 51)
    Me.CheckBox_CopyIphoneBackup.Name = "CheckBox_CopyIphoneBackup"
    Me.CheckBox_CopyIphoneBackup.Size = New System.Drawing.Size(126, 17)
    Me.CheckBox_CopyIphoneBackup.TabIndex = 5
    Me.CheckBox_CopyIphoneBackup.Text = "Copy iPhone Backup"
    Me.CheckBox_CopyIphoneBackup.UseVisualStyleBackColor = True
    '
    'CheckBox_BackupThumbnailDatabase
    '
    Me.CheckBox_BackupThumbnailDatabase.AutoSize = True
    Me.CheckBox_BackupThumbnailDatabase.Location = New System.Drawing.Point(12, 74)
    Me.CheckBox_BackupThumbnailDatabase.Name = "CheckBox_BackupThumbnailDatabase"
    Me.CheckBox_BackupThumbnailDatabase.Size = New System.Drawing.Size(164, 17)
    Me.CheckBox_BackupThumbnailDatabase.TabIndex = 6
    Me.CheckBox_BackupThumbnailDatabase.Text = "Backup Thumbnail Database"
    Me.CheckBox_BackupThumbnailDatabase.UseVisualStyleBackColor = True
    '
    'Form_Settings
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(284, 262)
    Me.Controls.Add(Me.CheckBox_BackupThumbnailDatabase)
    Me.Controls.Add(Me.CheckBox_CopyIphoneBackup)
    Me.Controls.Add(Me.Button_Cancel)
    Me.Controls.Add(Me.Button_Save)
    Me.Controls.Add(Me.Label_BackupLocation)
    Me.Controls.Add(Me.Button_BackupLocation)
    Me.Controls.Add(Me.TextBox_BackupLocation)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximumSize = New System.Drawing.Size(300, 300)
    Me.MinimumSize = New System.Drawing.Size(300, 300)
    Me.Name = "Form_Settings"
    Me.Text = "Settings"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TextBox_BackupLocation As System.Windows.Forms.TextBox
  Friend WithEvents Button_BackupLocation As System.Windows.Forms.Button
  Friend WithEvents Label_BackupLocation As System.Windows.Forms.Label
  Friend WithEvents FolderBrowserDialog_BackupLocation As System.Windows.Forms.FolderBrowserDialog
  Friend WithEvents Button_Save As System.Windows.Forms.Button
  Friend WithEvents Button_Cancel As System.Windows.Forms.Button
  Friend WithEvents CheckBox_CopyIphoneBackup As System.Windows.Forms.CheckBox
  Friend WithEvents CheckBox_BackupThumbnailDatabase As System.Windows.Forms.CheckBox
End Class
