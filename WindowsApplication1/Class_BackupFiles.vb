Imports System.IO

Public Class Class_BackupFiles
  Private _XPDirectoryList As New List(Of String)
  Private _VistaDirectoryList As New List(Of String)

  ''' <summary>
  ''' Default constructor. Populates list of directories to backup. 
  ''' </summary>
  ''' <remarks></remarks>
  Public Sub New()
    If Form_WorkStation.IsXP Then
      'Add XP directories
      For Each UserName As String In Directory.GetDirectories(Form_Startup.SelectedDrive + "Documents and Settings")
        'Exclude bogus usernames
        If UserName.Substring(26) <> "All Users" _
          AndAlso UserName.Substring(26) <> "LocalService" _
          AndAlso UserName.Substring(26) <> "Default User" _
          AndAlso UserName.Substring(26) <> "NetworkService" Then

          If Directory.Exists(UserName + "\My Documents\") Then
            _XPDirectoryList.Add(UserName + "\My Documents\")
          End If

          If Directory.Exists(UserName + "\Favorites\") Then
            _XPDirectoryList.Add(UserName + "\Favorites\")
          End If

          If Directory.Exists(UserName + "\Desktop\") Then
            _XPDirectoryList.Add(UserName + "\Desktop\")
          End If
        End If
      Next

      If Directory.Exists(Form_Startup.SelectedDrive + "\All Users\Documents") Then
        _XPDirectoryList.Add(Form_Startup.SelectedDrive + "\All Users\Documents")
      End If

      If Directory.Exists(Form_Startup.SelectedDrive + "\All Users\Pictures") Then
        _XPDirectoryList.Add(Form_Startup.SelectedDrive + "\All Users\Pictures")
      End If
    Else
      'Add Vista+ directories
      For Each UserName As String In Directory.GetDirectories(Form_Startup.SelectedDrive + "Users")
        'Exclude bogus usernames
        If UserName.Substring(9) <> "All Users" _
          AndAlso UserName.Substring(9) <> "Default" _
          AndAlso UserName.Substring(9) <> "Default User" _
          AndAlso UserName.Substring(9) <> "Public" Then

          If Directory.Exists(UserName + "\Favorites") Then
            _VistaDirectoryList.Add(UserName + "\Favorites")
          End If

          If Directory.Exists(UserName + "\Contacts") Then
            _VistaDirectoryList.Add(UserName + "\Contacts")
          End If

          If Directory.Exists(UserName + "\Pictures") Then
            _VistaDirectoryList.Add(UserName + "\Pictures")
          End If

          If Directory.Exists(UserName + "\Documents") Then
            _VistaDirectoryList.Add(UserName + "\Documents")
          End If

          If Directory.Exists(UserName + "\Music") Then
            _VistaDirectoryList.Add(UserName + "\Music")
          End If

          If Directory.Exists(UserName + "\Desktop") Then
            _VistaDirectoryList.Add(UserName + "\Desktop")
          End If

          If Directory.Exists(UserName + "\Downloads") Then
            _VistaDirectoryList.Add(UserName + "\Downloads")
          End If

          If Directory.Exists(UserName + "\Videos") Then
            _VistaDirectoryList.Add(UserName + "\Videos")
          End If

          If Directory.Exists(UserName + "\Saved Games") Then
            'If Directory.GetFiles("C:\").Count > 0 OrElse Directory.GetDirectories("C:\").Count > 0 Then
            _VistaDirectoryList.Add(UserName + "\Saved Games")
            'End If
          End If
        End If
      Next

      If Directory.Exists(Form_Startup.SelectedDrive + "Users\Public\Documents") Then
        _VistaDirectoryList.Add(Form_Startup.SelectedDrive + "Users\Public\Documents")
      End If

      If Directory.Exists(Form_Startup.SelectedDrive + "Users\Public\Pictures") Then
        _VistaDirectoryList.Add(Form_Startup.SelectedDrive + "Users\Public\Pictures")
      End If
    End If
  End Sub

  Public Function BackUpFiles() As Boolean
    Dim Result As Boolean = True
    Dim DirectoryList As New List(Of String)

    If Form_WorkStation.IsXP Then
      'Copy XP directories
      DirectoryList = _XPDirectoryList
      For Each Dir As String In DirectoryList
        Dim DirNameArray() As String = Dir.Split("\"c)
        Try
          Dim DirInfo As New DirectoryInfo(Dir)
          'Copy subdirectories
          For Each SubDirectory As DirectoryInfo In DirInfo.GetDirectories()
            Try
              My.Computer.FileSystem.CopyDirectory(SubDirectory.FullName, _BackupLocation + "\" + _TicketNumber + "\" + DirNameArray(DirNameArray.Count - 3) + "\" + DirNameArray(DirNameArray.Count - 2) + "\" + SubDirectory.Name, True)
            Catch ex As Exception

            End Try
          Next
          'Copy files in the directory itself
          For Each FilePath As FileInfo In DirInfo.GetFiles()
            Try
              My.Computer.FileSystem.CopyFile(FilePath.FullName, _BackupLocation + "\" + _TicketNumber + "\" + DirNameArray(DirNameArray.Count - 3) + "\" + DirNameArray(DirNameArray.Count - 2) + "\" + FilePath.Name, True)
            Catch ex As Exception

            End Try
          Next
        Catch ex As Exception

        End Try
      Next
    Else
      'Copy Vista directories
      DirectoryList = _VistaDirectoryList
      For Each Dir As String In DirectoryList
        Dim DirNameArray() As String = Dir.Split("\"c)
        Try
          Dim DirInfo As New DirectoryInfo(Dir)
          'Copy subdirectories
          For Each SubDirectory As DirectoryInfo In DirInfo.GetDirectories()
            Try
              My.Computer.FileSystem.CopyDirectory(SubDirectory.FullName, _BackupLocation + "\" + _TicketNumber + "\" + DirNameArray(DirNameArray.Count - 2) + "\" + DirNameArray(DirNameArray.Count - 1) + "\" + SubDirectory.Name, True)
            Catch ex As Exception

            End Try
          Next
          'Copy files in the directory itself
          For Each FilePath As FileInfo In DirInfo.GetFiles()
            Try
              My.Computer.FileSystem.CopyFile(FilePath.FullName, _BackupLocation + "\" + _TicketNumber + "\" + DirNameArray(DirNameArray.Count - 2) + "\" + DirNameArray(DirNameArray.Count - 1) + "\" + FilePath.Name, True)
            Catch ex As Exception

            End Try
          Next
        Catch ex As Exception

        End Try
      Next
    End If



    Return Result
  End Function

  'Public Function BackUpFiles() As Boolean
  '  Dim Result As Boolean = True
  '  Dim DirectoryList As New List(Of String)

  '  If Form_WorkStation.IsXP Then
  '    'Copy XP directories
  '    DirectoryList = _XPDirectoryList
  '    For Each Dir As String In DirectoryList
  '      Dim DirNameArray() As String = Dir.Split("\"c)
  '      Try
  '        My.Computer.FileSystem.CopyDirectory(Dir, _BackupLocation + "\" + _TicketNumber + "\" + DirNameArray(DirNameArray.Count - 3) + "\" + DirNameArray(DirNameArray.Count - 2), True)
  '      Catch ex As Exception

  '      End Try
  '    Next
  '  Else
  '    'Copy Vista directories
  '    DirectoryList = _VistaDirectoryList
  '    For Each Dir As String In DirectoryList
  '      Dim DirNameArray() As String = Dir.Split("\"c)
  '      Try
  '        My.Computer.FileSystem.CopyDirectory(Dir, _BackupLocation + "\" + _TicketNumber + "\" + DirNameArray(DirNameArray.Count - 2) + "\" + DirNameArray(DirNameArray.Count - 1), True)
  '      Catch ex As Exception

  '      End Try
  '    Next
  '  End If



  '  Return Result
  'End Function

End Class
