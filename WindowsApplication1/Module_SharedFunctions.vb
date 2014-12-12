Imports System.Xml
Imports System.Text


Module Module_SharedFunctions
  Public _BackupLocation As String = "C:\Customers"
  Public _iPhoneBackup As Boolean = False
  Public _ThumbnailBackup As Boolean = False
  Public _TicketNumber As String

  Public Sub WriteXMLToFile(ByVal ElementInfo As Dictionary(Of String, String))
    Try
      Dim Settings As New XmlWriterSettings()
      Settings.Indent = True
      Using Writer As XmlWriter = XmlWriter.Create("C:\WorkStation\Settings.xml", Settings)
        Writer.WriteStartDocument()
        Writer.WriteStartElement("WorkStation")
        Writer.WriteElementString("Location", ElementInfo.Item("Location"))
        Writer.WriteElementString("iPhone_Backup", ElementInfo.Item("iPhone_Backup"))
        Writer.WriteElementString("Thumbnail_Backup", ElementInfo.Item("Thumbnail_Backup"))
        Writer.WriteEndElement()
        Writer.WriteEndDocument()
      End Using
    Catch ex As Exception

    End Try
  End Sub

  Public Sub SetGlobals()
    If System.IO.File.Exists("C:\WorkStation\Settings.xml") Then
      Try
        Dim SettingsDoc As New XmlDocument()
        SettingsDoc.Load("C:\WorkStation\Settings.xml")

        'Set backup location
        If SettingsDoc.DocumentElement("Location").InnerText.Trim() <> String.Empty Then
          _BackupLocation = SettingsDoc.DocumentElement("Location").InnerText
        End If

        'Create backup location
        If Not System.IO.Directory.Exists(_BackupLocation) Then
          System.IO.Directory.CreateDirectory(_BackupLocation)
        End If

        'Set Thumbnail backup boolean
        If SettingsDoc.DocumentElement("Thumbnail_Backup").InnerText.Trim() <> String.Empty Then
          _ThumbnailBackup = Convert.ToBoolean(SettingsDoc.DocumentElement("Thumbnail_Backup").InnerText)
        End If

        'Set iPhone backup boolean
        If SettingsDoc.DocumentElement("iPhone_Backup").InnerText.Trim() <> String.Empty Then
          _iPhoneBackup = Convert.ToBoolean(SettingsDoc.DocumentElement("iPhone_Backup").InnerText)
        End If

      Catch ex As Exception

      End Try
    End If
  End Sub

End Module
