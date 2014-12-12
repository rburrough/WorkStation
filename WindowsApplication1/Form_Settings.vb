Imports System.Xml

Public Class Form_Settings
  Private _XmlDictionary As New Dictionary(Of String, String)
  Private _SettingChanged As Boolean = False

  ''' <summary>
  ''' Default constructor - read xml data, fill out form.
  ''' </summary>
  ''' <remarks></remarks>
  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
      Try
        'Dim SettingsDoc As New XmlDocument()
        'SettingsDoc.Load("C:\WorkStation\Settings.xml")
        'TextBox_BackupLocation.Text = SettingsDoc.DocumentElement("Location").InnerText
        'CheckBox_BackupThumbnailDatabase.Checked = Convert.ToBoolean(SettingsDoc.DocumentElement("Thumbnail_Backup").InnerText)
        'CheckBox_CopyIphoneBackup.Checked = Convert.ToBoolean(SettingsDoc.DocumentElement("iPhone_Backup").InnerText)
        TextBox_BackupLocation.Text = _BackupLocation
        CheckBox_BackupThumbnailDatabase.Checked = _ThumbnailBackup
        CheckBox_CopyIphoneBackup.Checked = _iPhoneBackup
      Catch ex As Exception

      End Try
  End Sub

  ''' <summary>
  ''' Close form without saving.
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub Button_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Cancel.Click
    If _SettingChanged Then
      If MessageBox.Show("Close without saving?", "Close?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
        Me.Close()
      End If
    Else
      Me.Close()
    End If
  End Sub

  ''' <summary>
  ''' Update registry and close form.
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub Button_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save.Click
    _XmlDictionary.Clear()
    _XmlDictionary.Add("Location", TextBox_BackupLocation.Text)
    _XmlDictionary.Add("iPhone_Backup", CheckBox_CopyIphoneBackup.Checked.ToString())
    _XmlDictionary.Add("Thumbnail_Backup", CheckBox_BackupThumbnailDatabase.Checked.ToString())
    WriteXMLToFile(_XmlDictionary)
    SetGlobals()
    'Update registry
    Me.Close()
  End Sub

  ''' <summary>
  ''' Select the default backup location.
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub Button_BackupLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_BackupLocation.Click
    FolderBrowserDialog_BackupLocation.ShowDialog()
    If FolderBrowserDialog_BackupLocation.SelectedPath.Trim() <> String.Empty Then
      _SettingChanged = True
      TextBox_BackupLocation.Text = FolderBrowserDialog_BackupLocation.SelectedPath.Trim()
    End If
  End Sub

  Private Sub CheckBox_CopyIphoneBackup_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox_CopyIphoneBackup.CheckedChanged
    _SettingChanged = True
  End Sub

  Private Sub CheckBox_BackupThumbnailDatabase_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox_BackupThumbnailDatabase.CheckedChanged
    _SettingChanged = True
  End Sub

End Class