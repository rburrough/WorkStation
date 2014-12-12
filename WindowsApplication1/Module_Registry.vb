Imports Microsoft.Win32
Imports System.IO
Imports System.Reflection
Imports System.Xml

Namespace Functions
  Public Class Registry

    Public Shared Sub WriteRegistryKey(ByVal RootKey As Microsoft.Win32.RegistryKey, ByVal sRegistryPath As String, ByVal sRegistryKey As String, ByVal Value As Object)
      Try

        Dim RegistryKey As RegistryKey = RootKey.OpenSubKey(sRegistryPath, True)

        If (RegistryKey Is Nothing) Then
          RegistryKey = RootKey.CreateSubKey(sRegistryPath)
        End If

        If (RegistryKey IsNot Nothing) Then
          Try
            RegistryKey.SetValue(sRegistryKey, Value)
          Catch ex As Exception

          End Try
        End If
      Catch ex As Exception

      End Try
    End Sub

    Public Shared Function ReadRegistryKey(ByVal RootKey As Microsoft.Win32.RegistryKey, ByVal sRegistryPath As String, ByVal sRegistryKey As String, ByVal DefaultValue As Object) As Object
      Dim Result As Object = DefaultValue
      Try

        Dim RegistryKey As RegistryKey = RootKey.OpenSubKey(sRegistryPath, True)

        If (RegistryKey Is Nothing) Then
          RegistryKey = RootKey.CreateSubKey(sRegistryPath)
        End If

        If (RegistryKey IsNot Nothing) Then
          Try
            Result = RegistryKey.GetValue(sRegistryKey, DefaultValue)
          Catch ex As Exception

          End Try
        End If

      Catch ex As Exception

      End Try

      Return Result
    End Function

    Public Shared Function ReadRegistryOrAppConfigKey(ByVal RootKey As Microsoft.Win32.RegistryKey, ByVal sRegistryPath As String, ByVal sRegistryKey As String, ByVal DefaultValue As Object, ByVal tagName As String, ByVal moduleName As String) As Object
      Dim Result As Object = DefaultValue
      Try

        Dim RegistryKey As RegistryKey = RootKey.OpenSubKey(sRegistryPath, True)

        If (RegistryKey Is Nothing) Then
          RegistryKey = RootKey.CreateSubKey(sRegistryPath)
        End If

        If (RegistryKey IsNot Nothing) Then
          Try

            If (tagName = "printerCatalog") Then

              'Dim RegistryPath As String = "\Software\CAT2\"
              Dim ParentRegistryKey As RegistryKey = RootKey.OpenSubKey(sRegistryPath, True)

              'Loop thru registry to get printer keys, unless there is no parent key in the registry
              If (ParentRegistryKey IsNot Nothing) Then
                For Each childkey As String In ParentRegistryKey.GetSubKeyNames()
                  Result = Functions.Registry.ReadRegistryKey(RootKey, sRegistryPath + "\" + childkey, "IPAddress", Nothing)
                  If (Result IsNot Nothing AndAlso Result.ToString() <> "") Then
                    Exit For
                  End If
                Next
                ParentRegistryKey.Close()
              End If

            Else
              Result = RegistryKey.GetValue(sRegistryKey)
              If CType(Result, String) = Nothing Then
                'Check App Config File

                Dim configXml = New XmlDocument()
                configXml.XmlResolver = Nothing
                Dim path = GetConfigFilePath()
                configXml.Load(path)
                Dim nodeList = configXml.GetElementsByTagName(tagName)

                If nodeList Is Nothing Then
                  Return Nothing
                End If

                For Each node As XmlNode In nodeList
                  For Each key As XmlNode In node.ChildNodes
                    If (tagName = "appSettings") Then
                      If (key.Attributes("key").Value = sRegistryKey) Then
                        Result = key.Attributes("value").Value
                        Exit For
                      End If
                    ElseIf (tagName = "moduleCatalog") Then
                      If (key.Attributes("description").Value = moduleName) Then
                        Result = key.Attributes(sRegistryKey).Value
                        Exit For
                      End If
                    End If
                  Next
                Next


              End If
            End If
          Catch ex As Exception

          End Try
        End If

      Catch ex As Exception

      End Try

      Return Result

    End Function

    Private Shared Function GetConfigFilePath() As String
      Dim appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)
      Dim result = Path.Combine(appPath, "App.config")

      If Not File.Exists(result) Then
        result = Nothing
      End If
      Return result
    End Function

  End Class
End Namespace