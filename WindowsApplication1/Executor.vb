Imports System.IO

Public Class Executor

  Dim _FileName As New List(Of String)
  Dim _FileNameList As New List(Of String)
  Dim _FileNameArgs As New List(Of String)
  'Dim fbd As New FolderBrowserDialog

  Public Delegate Sub CallBackDelegate(ByVal test As String)
  Public CallBack As CallBackDelegate

  Public Sub New(ByVal FileName As List(Of String), ByVal Arguments As List(Of String), ByVal Name As List(Of String))
    _FileName = Name
    _FileNameList = FileName
    _FileNameArgs = Arguments

  End Sub

  Public Sub Fatality()

    'For i As Integer = 0 To _FileNameList.Count - 1

    '  'If CallBack IsNot Nothing Then
    '  '  CallBack(_FileName(i))
    '  'End If
    '  Dim l As Label = CType(Form_WorkStation.Controls("label1"), Label)
    '  If l.InvokeRequired Then
    '    Dim d As New CallBackDelegate(AddressOf Form_WorkStation.CallBack)
    '    l.Invoke(d, New Object() {"label1", "Text"})
    '  Else
    '    l.Text = "Text"
    '  End If
    '  ' Set start information.
    '  Dim start_info As New ProcessStartInfo(_FileNameList(i))
    '  start_info.UseShellExecute = False
    '  start_info.CreateNoWindow = True
    '  start_info.Arguments = _FileNameArgs(i)

    '  ' Make the process and set its start information.
    '  Using proc As New Process

    '    'If FileName(i) = "C:\Windows\System32\cmd.exe" Then
    '    '  proc.StartInfo.RedirectStandardOutput = True
    '    'Else
    '    '  proc.StartInfo.RedirectStandardOutput = False
    '    'End If

    '    proc.StartInfo = start_info

    '    ' Start the process.
    '    Try
    '      'Label1.Text = proc.StandardOutput.ReadToEnd() 'streamwriter writes all the results to the richtextbox.
    '      proc.Start()
    '      proc.WaitForExit()
    '    Catch ex As Exception

    '    End Try

    '  End Using
    'Next
    'MessageBox.Show("Exit Code: " & proc.ExitCode, "Exit " & "Code", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub
End Class
