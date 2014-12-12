Imports System.IO
Imports System.Security

Public Class Class_CleanTempFiles
  Private _XPDirectoryList As New List(Of String)
  Private _VistaDirectoryList As New List(Of String)

  ''' <summary>
  ''' Default constructor. Populates list of directories to clean.
  ''' </summary>
  ''' <remarks></remarks>
  Public Sub New()

    If Form_WorkStation.IsXP Then
      For Each UserName As String In Directory.GetDirectories(Form_Startup.SelectedDrive + "Documents and Settings")
        'Exclude bogus usernames
        If UserName.Substring(9) <> "All Users" _
          AndAlso UserName.Substring(9) <> "LocalService" _
          AndAlso UserName.Substring(9) <> "Default User" _
          AndAlso UserName.Substring(9) <> "NetworkService" Then

          If Directory.Exists(UserName + "\Local Settings\temp") Then
            _XPDirectoryList.Add(UserName + "\Local Settings\temp")
          End If

          If Directory.Exists(UserName + "\Local Settings\Temporary Internet Files\Content.IE5") Then
            _XPDirectoryList.Add(UserName + "\Local Settings\Temporary Internet Files\Content.IE5")
          End If

          If Directory.Exists(UserName + "\Application Data\Sun\Java\Deployment\cache\") Then
            _XPDirectoryList.Add(UserName + "\Application Data\Sun\Java\Deployment\cache\")
          End If
        End If
      Next

      If Directory.Exists(Form_Startup.SelectedDrive + "Temp") Then
        _XPDirectoryList.Add(Form_Startup.SelectedDrive + "Temp")
      End If

      If Directory.Exists(Form_Startup.SelectedDrive + "Windows\Temp") Then
        _XPDirectoryList.Add(Form_Startup.SelectedDrive + "Windows\Temp")
      End If
    Else
      For Each UserName As String In Directory.GetDirectories(Form_Startup.SelectedDrive + "Users")
        'Exclude bogus usernames
        If UserName.Substring(9) <> "All Users" _
          AndAlso UserName.Substring(9) <> "Default" _
          AndAlso UserName.Substring(9) <> "Default User" _
          AndAlso UserName.Substring(9) <> "Public" Then

          If Directory.Exists(UserName + "\appdata\local\temp") Then
            _VistaDirectoryList.Add(UserName + "\appdata\local\temp")
          End If

        End If
      Next

      If Directory.Exists(Form_Startup.SelectedDrive + "temp") Then
        _VistaDirectoryList.Add(Form_Startup.SelectedDrive + "temp")
      End If

      If Directory.Exists(Form_Startup.SelectedDrive + "Windows\temp") Then
        _VistaDirectoryList.Add(Form_Startup.SelectedDrive + "Windows\temp")
      End If
    End If

  End Sub

  ''' <summary>
  ''' Delete temp files in specified directories. 
  ''' </summary>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function CleanTemp() As Boolean
    Dim Result As Boolean = True
    Dim DirectoryList As New List(Of String)

    If Form_WorkStation.IsXP Then
      DirectoryList = _XPDirectoryList
    Else
      DirectoryList = _VistaDirectoryList
    End If

    Try
      For Each TempDirectory As String In DirectoryList

        Dim TempDirectoryInfo As New DirectoryInfo(TempDirectory)
        'Delete subdirectories
        If TempDirectoryInfo.GetDirectories.Count > 0 Then
          For Each oDir As DirectoryInfo In TempDirectoryInfo.GetDirectories
            Try
              oDir.Delete(True)
            Catch ex As Exception
            End Try
          Next

        End If
        'Delete files in temp folder
          For Each FilePath As String In Directory.GetFiles(TempDirectory)
            Try
              File.Delete(FilePath)
            Catch ex As Exception
          End Try
          Next

      Next
    Catch ex As Exception
      Result = False
    End Try

    Return Result
  End Function

End Class
