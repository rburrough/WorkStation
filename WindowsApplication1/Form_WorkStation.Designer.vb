<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_WorkStation
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_WorkStation))
    Me.Button_Start = New System.Windows.Forms.Button()
    Me.CheckBox_MBAM = New System.Windows.Forms.CheckBox()
    Me.CheckBox_EmsiSoft = New System.Windows.Forms.CheckBox()
    Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
    Me.ProgressBar_Main = New System.Windows.Forms.ProgressBar()
    Me.CheckBox_MSSE = New System.Windows.Forms.CheckBox()
    Me.RadioButton_NoChkdsk = New System.Windows.Forms.RadioButton()
    Me.RadioButtonChkdskF = New System.Windows.Forms.RadioButton()
    Me.RadioButtonChkdskR = New System.Windows.Forms.RadioButton()
    Me.RadioButton_ChkdskB = New System.Windows.Forms.RadioButton()
    Me.GroupBox_FileSystem = New System.Windows.Forms.GroupBox()
    Me.GroupBox_VirRemoval = New System.Windows.Forms.GroupBox()
    Me.CheckBox_CleanTempFiles = New System.Windows.Forms.CheckBox()
    Me.CheckBox_TDSSKiller = New System.Windows.Forms.CheckBox()
    Me.CheckBox_FixBootSector = New System.Windows.Forms.CheckBox()
    Me.GroupBox_UserAccounts = New System.Windows.Forms.GroupBox()
    Me.CheckBox_RecoverCOA = New System.Windows.Forms.CheckBox()
    Me.CheckBox_UnlockAccounts = New System.Windows.Forms.CheckBox()
    Me.CheckBox_FileBackup = New System.Windows.Forms.CheckBox()
    Me.CheckBox_SelectAll = New System.Windows.Forms.CheckBox()
    Me.Button3 = New System.Windows.Forms.Button()
    Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ConfigureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.GroupBox_FileSystem.SuspendLayout()
    Me.GroupBox_VirRemoval.SuspendLayout()
    Me.GroupBox_UserAccounts.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Button_Start
    '
    Me.Button_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Button_Start.Location = New System.Drawing.Point(134, 232)
    Me.Button_Start.Name = "Button_Start"
    Me.Button_Start.Size = New System.Drawing.Size(104, 28)
    Me.Button_Start.TabIndex = 0
    Me.Button_Start.Text = "Start"
    Me.Button_Start.UseVisualStyleBackColor = True
    '
    'CheckBox_MBAM
    '
    Me.CheckBox_MBAM.AutoSize = True
    Me.CheckBox_MBAM.Location = New System.Drawing.Point(7, 19)
    Me.CheckBox_MBAM.Name = "CheckBox_MBAM"
    Me.CheckBox_MBAM.Size = New System.Drawing.Size(58, 17)
    Me.CheckBox_MBAM.TabIndex = 2
    Me.CheckBox_MBAM.Text = "MBAM"
    Me.CheckBox_MBAM.UseVisualStyleBackColor = True
    '
    'CheckBox_EmsiSoft
    '
    Me.CheckBox_EmsiSoft.AutoSize = True
    Me.CheckBox_EmsiSoft.Location = New System.Drawing.Point(7, 42)
    Me.CheckBox_EmsiSoft.Name = "CheckBox_EmsiSoft"
    Me.CheckBox_EmsiSoft.Size = New System.Drawing.Size(58, 17)
    Me.CheckBox_EmsiSoft.TabIndex = 3
    Me.CheckBox_EmsiSoft.Text = "a2cmd"
    Me.CheckBox_EmsiSoft.UseVisualStyleBackColor = True
    '
    'ProgressBar_Main
    '
    Me.ProgressBar_Main.Location = New System.Drawing.Point(121, 266)
    Me.ProgressBar_Main.Maximum = 10
    Me.ProgressBar_Main.Name = "ProgressBar_Main"
    Me.ProgressBar_Main.Size = New System.Drawing.Size(127, 17)
    Me.ProgressBar_Main.Step = 1
    Me.ProgressBar_Main.TabIndex = 5
    '
    'CheckBox_MSSE
    '
    Me.CheckBox_MSSE.AutoSize = True
    Me.CheckBox_MSSE.Location = New System.Drawing.Point(7, 65)
    Me.CheckBox_MSSE.Name = "CheckBox_MSSE"
    Me.CheckBox_MSSE.Size = New System.Drawing.Size(56, 17)
    Me.CheckBox_MSSE.TabIndex = 6
    Me.CheckBox_MSSE.Text = "MSSE"
    Me.CheckBox_MSSE.UseVisualStyleBackColor = True
    '
    'RadioButton_NoChkdsk
    '
    Me.RadioButton_NoChkdsk.AutoSize = True
    Me.RadioButton_NoChkdsk.Location = New System.Drawing.Point(6, 19)
    Me.RadioButton_NoChkdsk.Name = "RadioButton_NoChkdsk"
    Me.RadioButton_NoChkdsk.Size = New System.Drawing.Size(78, 17)
    Me.RadioButton_NoChkdsk.TabIndex = 7
    Me.RadioButton_NoChkdsk.TabStop = True
    Me.RadioButton_NoChkdsk.Text = "No Chkdsk"
    Me.RadioButton_NoChkdsk.UseVisualStyleBackColor = True
    '
    'RadioButtonChkdskF
    '
    Me.RadioButtonChkdskF.AutoSize = True
    Me.RadioButtonChkdskF.Location = New System.Drawing.Point(90, 19)
    Me.RadioButtonChkdskF.Name = "RadioButtonChkdskF"
    Me.RadioButtonChkdskF.Size = New System.Drawing.Size(75, 17)
    Me.RadioButtonChkdskF.TabIndex = 8
    Me.RadioButtonChkdskF.TabStop = True
    Me.RadioButtonChkdskF.Text = "Chkdsk /F"
    Me.RadioButtonChkdskF.UseVisualStyleBackColor = True
    '
    'RadioButtonChkdskR
    '
    Me.RadioButtonChkdskR.AutoSize = True
    Me.RadioButtonChkdskR.Location = New System.Drawing.Point(7, 42)
    Me.RadioButtonChkdskR.Name = "RadioButtonChkdskR"
    Me.RadioButtonChkdskR.Size = New System.Drawing.Size(77, 17)
    Me.RadioButtonChkdskR.TabIndex = 9
    Me.RadioButtonChkdskR.TabStop = True
    Me.RadioButtonChkdskR.Text = "Chkdsk /R"
    Me.RadioButtonChkdskR.UseVisualStyleBackColor = True
    '
    'RadioButton_ChkdskB
    '
    Me.RadioButton_ChkdskB.AutoSize = True
    Me.RadioButton_ChkdskB.Location = New System.Drawing.Point(90, 42)
    Me.RadioButton_ChkdskB.Name = "RadioButton_ChkdskB"
    Me.RadioButton_ChkdskB.Size = New System.Drawing.Size(76, 17)
    Me.RadioButton_ChkdskB.TabIndex = 10
    Me.RadioButton_ChkdskB.TabStop = True
    Me.RadioButton_ChkdskB.Text = "Chkdsk /B"
    Me.RadioButton_ChkdskB.UseVisualStyleBackColor = True
    '
    'GroupBox_FileSystem
    '
    Me.GroupBox_FileSystem.Controls.Add(Me.RadioButton_NoChkdsk)
    Me.GroupBox_FileSystem.Controls.Add(Me.RadioButton_ChkdskB)
    Me.GroupBox_FileSystem.Controls.Add(Me.RadioButtonChkdskF)
    Me.GroupBox_FileSystem.Controls.Add(Me.RadioButtonChkdskR)
    Me.GroupBox_FileSystem.Location = New System.Drawing.Point(93, 133)
    Me.GroupBox_FileSystem.Name = "GroupBox_FileSystem"
    Me.GroupBox_FileSystem.Size = New System.Drawing.Size(183, 70)
    Me.GroupBox_FileSystem.TabIndex = 11
    Me.GroupBox_FileSystem.TabStop = False
    Me.GroupBox_FileSystem.Text = "File System"
    '
    'GroupBox_VirRemoval
    '
    Me.GroupBox_VirRemoval.Controls.Add(Me.CheckBox_CleanTempFiles)
    Me.GroupBox_VirRemoval.Controls.Add(Me.CheckBox_TDSSKiller)
    Me.GroupBox_VirRemoval.Controls.Add(Me.CheckBox_FixBootSector)
    Me.GroupBox_VirRemoval.Controls.Add(Me.CheckBox_MBAM)
    Me.GroupBox_VirRemoval.Controls.Add(Me.CheckBox_MSSE)
    Me.GroupBox_VirRemoval.Controls.Add(Me.CheckBox_EmsiSoft)
    Me.GroupBox_VirRemoval.Location = New System.Drawing.Point(11, 27)
    Me.GroupBox_VirRemoval.Name = "GroupBox_VirRemoval"
    Me.GroupBox_VirRemoval.Size = New System.Drawing.Size(183, 100)
    Me.GroupBox_VirRemoval.TabIndex = 12
    Me.GroupBox_VirRemoval.TabStop = False
    Me.GroupBox_VirRemoval.Text = "Virus Removal"
    '
    'CheckBox_CleanTempFiles
    '
    Me.CheckBox_CleanTempFiles.AutoSize = True
    Me.CheckBox_CleanTempFiles.Location = New System.Drawing.Point(74, 65)
    Me.CheckBox_CleanTempFiles.Name = "CheckBox_CleanTempFiles"
    Me.CheckBox_CleanTempFiles.Size = New System.Drawing.Size(107, 17)
    Me.CheckBox_CleanTempFiles.TabIndex = 10
    Me.CheckBox_CleanTempFiles.Text = "Clean Temp Files"
    Me.CheckBox_CleanTempFiles.UseVisualStyleBackColor = True
    '
    'CheckBox_TDSSKiller
    '
    Me.CheckBox_TDSSKiller.AutoSize = True
    Me.CheckBox_TDSSKiller.Location = New System.Drawing.Point(74, 19)
    Me.CheckBox_TDSSKiller.Name = "CheckBox_TDSSKiller"
    Me.CheckBox_TDSSKiller.Size = New System.Drawing.Size(77, 17)
    Me.CheckBox_TDSSKiller.TabIndex = 9
    Me.CheckBox_TDSSKiller.Text = "TDSSKiller"
    Me.CheckBox_TDSSKiller.UseVisualStyleBackColor = True
    '
    'CheckBox_FixBootSector
    '
    Me.CheckBox_FixBootSector.AutoSize = True
    Me.CheckBox_FixBootSector.Location = New System.Drawing.Point(74, 42)
    Me.CheckBox_FixBootSector.Name = "CheckBox_FixBootSector"
    Me.CheckBox_FixBootSector.Size = New System.Drawing.Size(95, 17)
    Me.CheckBox_FixBootSector.TabIndex = 8
    Me.CheckBox_FixBootSector.Text = "Fix BootSector"
    Me.CheckBox_FixBootSector.UseVisualStyleBackColor = True
    '
    'GroupBox_UserAccounts
    '
    Me.GroupBox_UserAccounts.Controls.Add(Me.CheckBox_RecoverCOA)
    Me.GroupBox_UserAccounts.Controls.Add(Me.CheckBox_UnlockAccounts)
    Me.GroupBox_UserAccounts.Controls.Add(Me.CheckBox_FileBackup)
    Me.GroupBox_UserAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox_UserAccounts.Location = New System.Drawing.Point(200, 27)
    Me.GroupBox_UserAccounts.Name = "GroupBox_UserAccounts"
    Me.GroupBox_UserAccounts.Size = New System.Drawing.Size(157, 100)
    Me.GroupBox_UserAccounts.TabIndex = 13
    Me.GroupBox_UserAccounts.TabStop = False
    Me.GroupBox_UserAccounts.Text = "User Accounts"
    '
    'CheckBox_RecoverCOA
    '
    Me.CheckBox_RecoverCOA.AutoSize = True
    Me.CheckBox_RecoverCOA.Location = New System.Drawing.Point(6, 65)
    Me.CheckBox_RecoverCOA.Name = "CheckBox_RecoverCOA"
    Me.CheckBox_RecoverCOA.Size = New System.Drawing.Size(92, 17)
    Me.CheckBox_RecoverCOA.TabIndex = 2
    Me.CheckBox_RecoverCOA.Text = "Recover COA"
    Me.CheckBox_RecoverCOA.UseVisualStyleBackColor = True
    '
    'CheckBox_UnlockAccounts
    '
    Me.CheckBox_UnlockAccounts.AutoSize = True
    Me.CheckBox_UnlockAccounts.Location = New System.Drawing.Point(6, 42)
    Me.CheckBox_UnlockAccounts.Name = "CheckBox_UnlockAccounts"
    Me.CheckBox_UnlockAccounts.Size = New System.Drawing.Size(108, 17)
    Me.CheckBox_UnlockAccounts.TabIndex = 1
    Me.CheckBox_UnlockAccounts.Text = "Unlock Accounts"
    Me.CheckBox_UnlockAccounts.UseVisualStyleBackColor = True
    '
    'CheckBox_FileBackup
    '
    Me.CheckBox_FileBackup.AutoSize = True
    Me.CheckBox_FileBackup.Location = New System.Drawing.Point(6, 19)
    Me.CheckBox_FileBackup.Name = "CheckBox_FileBackup"
    Me.CheckBox_FileBackup.Size = New System.Drawing.Size(82, 17)
    Me.CheckBox_FileBackup.TabIndex = 0
    Me.CheckBox_FileBackup.Text = "File Backup"
    Me.CheckBox_FileBackup.UseVisualStyleBackColor = True
    '
    'CheckBox_SelectAll
    '
    Me.CheckBox_SelectAll.AutoSize = True
    Me.CheckBox_SelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CheckBox_SelectAll.Location = New System.Drawing.Point(147, 209)
    Me.CheckBox_SelectAll.Name = "CheckBox_SelectAll"
    Me.CheckBox_SelectAll.Size = New System.Drawing.Size(80, 17)
    Me.CheckBox_SelectAll.TabIndex = 14
    Me.CheckBox_SelectAll.Text = "Select All"
    Me.CheckBox_SelectAll.UseVisualStyleBackColor = True
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(325, 248)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(32, 23)
    Me.Button3.TabIndex = 15
    Me.Button3.Text = "Button3"
    Me.Button3.UseVisualStyleBackColor = True
    Me.Button3.Visible = False
    '
    'BackgroundWorker1
    '
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(369, 24)
    Me.MenuStrip1.TabIndex = 18
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
    Me.FileToolStripMenuItem.Text = "File"
    '
    'ExitToolStripMenuItem
    '
    Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
    Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
    Me.ExitToolStripMenuItem.Text = "Exit"
    '
    'SettingsToolStripMenuItem
    '
    Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigureToolStripMenuItem})
    Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
    Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
    Me.SettingsToolStripMenuItem.Text = "Settings"
    '
    'ConfigureToolStripMenuItem
    '
    Me.ConfigureToolStripMenuItem.Name = "ConfigureToolStripMenuItem"
    Me.ConfigureToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
    Me.ConfigureToolStripMenuItem.Text = "Configure"
    '
    'Form_WorkStation
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(369, 289)
    Me.Controls.Add(Me.Button3)
    Me.Controls.Add(Me.CheckBox_SelectAll)
    Me.Controls.Add(Me.GroupBox_UserAccounts)
    Me.Controls.Add(Me.GroupBox_VirRemoval)
    Me.Controls.Add(Me.GroupBox_FileSystem)
    Me.Controls.Add(Me.ProgressBar_Main)
    Me.Controls.Add(Me.Button_Start)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "Form_WorkStation"
    Me.Text = "WorkStation Reloaded"
    Me.GroupBox_FileSystem.ResumeLayout(False)
    Me.GroupBox_FileSystem.PerformLayout()
    Me.GroupBox_VirRemoval.ResumeLayout(False)
    Me.GroupBox_VirRemoval.PerformLayout()
    Me.GroupBox_UserAccounts.ResumeLayout(False)
    Me.GroupBox_UserAccounts.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Button_Start As System.Windows.Forms.Button
  Friend WithEvents CheckBox_MBAM As System.Windows.Forms.CheckBox
  Friend WithEvents CheckBox_EmsiSoft As System.Windows.Forms.CheckBox
  Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
  Friend WithEvents ProgressBar_Main As System.Windows.Forms.ProgressBar
  Friend WithEvents CheckBox_MSSE As System.Windows.Forms.CheckBox
  Friend WithEvents RadioButton_NoChkdsk As System.Windows.Forms.RadioButton
  Friend WithEvents RadioButtonChkdskF As System.Windows.Forms.RadioButton
  Friend WithEvents RadioButtonChkdskR As System.Windows.Forms.RadioButton
  Friend WithEvents RadioButton_ChkdskB As System.Windows.Forms.RadioButton
  Friend WithEvents GroupBox_FileSystem As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox_VirRemoval As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox_UserAccounts As System.Windows.Forms.GroupBox
  Friend WithEvents CheckBox_RecoverCOA As System.Windows.Forms.CheckBox
  Friend WithEvents CheckBox_UnlockAccounts As System.Windows.Forms.CheckBox
  Friend WithEvents CheckBox_FileBackup As System.Windows.Forms.CheckBox
  Friend WithEvents CheckBox_FixBootSector As System.Windows.Forms.CheckBox
  Friend WithEvents CheckBox_SelectAll As System.Windows.Forms.CheckBox
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ConfigureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents CheckBox_TDSSKiller As System.Windows.Forms.CheckBox
  Friend WithEvents CheckBox_CleanTempFiles As System.Windows.Forms.CheckBox

End Class
