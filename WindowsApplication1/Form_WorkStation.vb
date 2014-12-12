Imports System.IO
Imports System.ComponentModel
Imports System.Text
Imports System.Diagnostics

Public Class Form_WorkStation

  Private _ProgramName As New List(Of String)
  Private _FileName As New List(Of String)
  Private _Args As New List(Of String)
  Private _FolderBrowser As New FolderBrowserDialog()
  Private _AVList As New List(Of Control)
  Public Shared _IsXP As Boolean

  ''' <summary>
  ''' Is the OS XP or is it Vista or higher?
  ''' </summary>
  ''' <value></value>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Shared ReadOnly Property IsXP As Boolean
    Get
      Return _IsXP
    End Get
  End Property

#Region "Event Handlers"

  Private Sub AddHandlerTest(ByVal sender As System.Object, ByVal e As System.EventArgs)
    MessageBox.Show("Handler added!")
  End Sub

  ''' <summary>
  ''' Calls the Executor to run the selected programs.
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub Button_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Start.Click
    BackgroundWorker1.WorkerReportsProgress = True
    BackgroundWorker1.WorkerSupportsCancellation = True

    ProgressBar_Main.Value = 0
    ProgressBar_Main.Maximum = _FileName.Count
    'If we want to do a chkdsk, increment progress bar.
    If RadioButton_ChkdskB.Checked OrElse RadioButtonChkdskF.Checked OrElse RadioButtonChkdskR.Checked Then
      ProgressBar_Main.Maximum += 1
    End If

    If CheckBox_CleanTempFiles.Checked Then
      ProgressBar_Main.Maximum += 1
    End If

    If CheckBox_FileBackup.Checked Then
      ProgressBar_Main.Maximum += 1
    End If

    Dim myValue As String

    myValue = InputBox("Please input the customer's ticket number.", "Ticket Number").Trim()
    If myValue <> String.Empty Then
      'Set the ticket number global
      _TicketNumber = myValue
      'Start the thread
      If BackgroundWorker1.IsBusy <> True Then
        ' Start the asynchronous operation.
        BackgroundWorker1.RunWorkerAsync()
      End If
    Else
      MessageBox.Show("Please enter a number.", "No Number Detected")
    End If
  End Sub

  ''' <summary>
  ''' Start background worker thread, disable form.
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, _
ByVal e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
    worker.ReportProgress(0)
    StartIt()
    worker.ReportProgress(1)
  End Sub

  ''' <summary>
  ''' Update main GUI thread.
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, _
    ByVal e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
    'MessageBox.Show(e.ProgressPercentage.ToString())
    If e.ProgressPercentage = 0 Then
      'Disable form 
      Me.Enabled = False
    ElseIf e.ProgressPercentage = 1 Then
      'Increment progress bar
      ProgressBar_Main.PerformStep()
    ElseIf e.ProgressPercentage = 2 Then
      'Report that worker is through running, enable form.
      Me.Enabled = True
      MessageBox.Show("Finished!")
    End If
  End Sub

  'Checkboxes
  ''' <summary>
  ''' MBAM
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub CheckBox_MBAM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_MBAM.Click
    If CheckBox_MBAM.Checked = True Then
      CheckedHandler("Malwarebytes", "C:\windows\Notepad.exe", "", False)
      _ProgramName.Add("Malwarebytes")
      _FileName.Add("C:\windows\Notepad.exe")
      _Args.Add("")
    Else
      _ProgramName.Remove("Malwarebytes")
      _FileName.Remove("C:\windows\Notepad.exe")
      _Args.Remove("")
    End If
  End Sub

  ''' <summary>
  ''' A2CMD
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub CheckBox_EmsiSoft_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_EmsiSoft.Click
    If CheckBox_EmsiSoft.Checked = True Then
      CheckedHandler("a2cmd", "C:\windows\system32\cmd.exe", "/c start /wait C:\windows\notepad.exe", True)
      '_ProgramName.Add("a2cmd")
      '_FileName.Add("C:\windows\system32\cmd.exe")
      '_Args.Add("/c start /wait C:\windows\notepad.exe")
    Else
      CheckedHandler("a2cmd", "C:\windows\system32\cmd.exe", "/c start /wait C:\windows\notepad.exe", False)
      '_ProgramName.Remove("a2cmd")
      '_FileName.Remove("C:\windows\system32\cmd.exe")
      '_Args.Remove("/c start /wait C:\windows\notepad.exe")
    End If
  End Sub

  ''' <summary>
  ''' MSSE
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub CheckBox_MSSE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_MSSE.Click
    If CheckBox_MSSE.Checked = True Then
      CheckedHandler("MSSE", "C:\Program Files\Microsoft Security Client\MPCMDRUN.EXE", "-Scan -ScanType 3 -file", True)
    Else
      CheckedHandler("MSSE", "C:\Program Files\Microsoft Security Client\MPCMDRUN.EXE", "-Scan -ScanType 3 -file", False)
    End If
  End Sub

  ''' <summary>
  ''' TDSSKiller
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub CheckBox_TDSSKiller_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_TDSSKiller.Click
    If CheckBox_TDSSKiller.Checked = True Then
      _ProgramName.Add("TDSSKiller")
      _FileName.Add("C:\tdsskiller.exe")
      _Args.Add(" -accepteula -accepteulaksn -dcexact -tdlfs")
    Else
      _ProgramName.Remove("TDSSKiller")
      _FileName.Remove("C:\tdsskiller.exe")
      _Args.Remove("")
    End If
  End Sub

  'Select All
  ''' <summary>
  ''' Select All
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_SelectAll.CheckedChanged
    'If Select All is checked
    If CheckBox_SelectAll.Checked = True Then

      For Each GB As Control In Me.Controls
        If TypeOf GB Is GroupBox Then
          For Each TB As Control In GB.Controls
            If TypeOf TB Is CheckBox AndAlso TB.Enabled Then
              DirectCast(TB, CheckBox).CheckState = CheckState.Checked
            End If
          Next
        End If
      Next
      RadioButtonChkdskF.Checked = True
      'If Select All is unchecked
    Else
      For Each GB As Control In Me.Controls
        If TypeOf GB Is GroupBox Then
          For Each TB As Control In GB.Controls
            If TypeOf TB Is CheckBox AndAlso TB.Enabled Then
              DirectCast(TB, CheckBox).CheckState = CheckState.Unchecked
            End If
          Next
        End If
      Next
      RadioButtonChkdskF.Checked = False
    End If
  End Sub

  ''' <summary>
  ''' Exit the application.
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
    Me.Close()
  End Sub

  ''' <summary>
  ''' Open the settings form to let the user save config info.
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub ConfigureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigureToolStripMenuItem.Click
    Dim SettingsForm As New Form_Settings()
    SettingsForm.ShowDialog()
  End Sub

#End Region

#Region "Subs"

  ''' <summary>
  ''' Constructor.
  ''' </summary>
  ''' <param name="FolderBrowser"></param>
  ''' <remarks></remarks>
  Public Sub New(ByVal FolderBrowser As FolderBrowserDialog)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.Text = "Drive " + FolderBrowser.SelectedPath

    If File.Exists(FolderBrowser.SelectedPath + "windows\system32\winver.exe") Then
      Dim WindowsVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(FolderBrowser.SelectedPath + "windows\system32\winver.exe")

      If Convert.ToDouble(WindowsVersion.FileVersion.Substring(0, 3)) < 6 Then
        _IsXP = True
      Else
        _IsXP = False
      End If
    Else
      If MessageBox.Show("No Windows version detected. Hit OK to use Vista-style filesystem, or Cancel to use XP-style.", "Select OS", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel Then
        _IsXP = True
      Else
        _IsXP = False
      End If
    End If

    VerifyFiles()
    'Dim cleaner As New Class_CleanTempFiles()
    'cleaner.CleanTemp()
    Me.MaximumSize = Me.Size
    Me.MinimumSize = Me.size
  End Sub

  ''' <summary>
  ''' Ensure that all AVs exist.
  ''' </summary>
  ''' <remarks></remarks>
  Private Sub VerifyFiles()
    'Check for MBAM
    If Not File.Exists("C:\Program Files (x86)\Malwarebytes Anti-Malware\mbam.exe") Then
      CheckBox_MBAM.Enabled = False
    End If

    'Check for EmsiSoft
    If Not File.Exists("C:\Program Files (x86)\Emsisoft Anti-Malware\a2cmd.exe") Then
      CheckBox_EmsiSoft.Enabled = False
    End If

    'Check for MSSE
    If Not File.Exists("C:\Program Files\Microsoft Security Client\Antimalware\MPCMDRUN.EXE") AndAlso Not File.Exists("C:\Program Files\Microsoft Security Client\MPCMDRUN.EXE") Then
      CheckBox_MSSE.Enabled = False
    End If

    'Check for TDSSKiller
    If Not File.Exists("C:\Tools\TDSSKiller.exe") Then
      CheckBox_TDSSKiller.Enabled = False
    End If

    'Check for third-party MBR tool?
  End Sub

  Private Sub StartIt()
    Executor(_FileName, _Args, _ProgramName)
  End Sub

  ''' <summary>
  ''' Runs the given exe with the given arguments
  ''' </summary>
  ''' <param name="FileName"></param>
  ''' <param name="Arguments"></param>
  ''' <remarks></remarks>
  Private Sub Executor(ByVal FileName As List(Of String), ByVal Arguments As List(Of String), ByVal Name As List(Of String))
    ChkDsk()

    Try
      If CheckBox_CleanTempFiles.Checked Then
        CleanTempFiles()
      End If
    Catch ex As Exception
      BackgroundWorker1.ReportProgress(1)
    End Try

    Try
      If CheckBox_FileBackup.Checked Then
        BackupFiles()
      End If
      BackgroundWorker1.ReportProgress(1)
    Catch ex As Exception
      BackgroundWorker1.ReportProgress(1)
    End Try

    For i As Integer = 0 To FileName.Count - 1

      ' Set start information.
      Dim start_info As New ProcessStartInfo(FileName(i))
      start_info.UseShellExecute = False
      start_info.CreateNoWindow = True
      If Arguments.Count > 0 Then
        start_info.Arguments = Arguments(i)
      End If

      ' Make the process and set its start information.
      Using proc As New Process

        proc.StartInfo = start_info

        ' Start the process.
        Try
          proc.Start()
          proc.WaitForExit()
        Catch ex As Exception

        End Try

      End Using
      BackgroundWorker1.ReportProgress(1)
    Next

    BackgroundWorker1.ReportProgress(2)
    'MessageBox.Show("Exit Code: " & proc.ExitCode, "Exit " & "Code", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Sub BackupFiles()
    Dim BackupObject As New Class_BackupFiles()
    BackupObject.BackUpFiles()
  End Sub

  Private Sub CleanTempFiles()
    Dim CleanTempObject As New Class_CleanTempFiles()
    CleanTempObject.CleanTemp()
  End Sub

  Private Sub ChkDsk()
    Dim start_info As New ProcessStartInfo("C:\Windows\System32\cmd.exe")
    ' Set start information.
    start_info.UseShellExecute = False
    start_info.CreateNoWindow = True

    If RadioButton_ChkdskB.Checked Then
      start_info.Arguments = "/c start /wait chkdsk " + _FolderBrowser.SelectedPath + " /B >> C:\Customers\testlog.txt"
      ExecuteChkDsk(start_info)
    ElseIf RadioButtonChkdskF.Checked Then
      start_info.Arguments = "/c start /wait chkdsk " + _FolderBrowser.SelectedPath + " /X >> C:\Customers\testlog.txt"
      ExecuteChkDsk(start_info)
    ElseIf RadioButtonChkdskR.Checked Then
      start_info.Arguments = "/c start /wait chkdsk " + _FolderBrowser.SelectedPath + " /R >> C:\Customers\testlog.txt"
      ExecuteChkDsk(start_info)
    End If

    BackgroundWorker1.ReportProgress(1)
  End Sub

  Private Sub ExecuteChkDsk(ByVal start_info As ProcessStartInfo)
    ' Make the process and set its start information.
    Using proc As New Process

      proc.StartInfo = start_info

      ' Start the process.
      Try
        proc.Start()
        proc.WaitForExit()
      Catch ex As Exception

      End Try

    End Using
    BackgroundWorker1.ReportProgress(1)
  End Sub

  Private Sub CheckedHandler(ByVal ProgramName As String, ByVal FileName As String, ByVal Args As String, ByVal ActionFlag As Boolean)
    Select Case ActionFlag
      'Checked == true. Add the program to the list. 
      Case True
        _ProgramName.Add(ProgramName)
        _FileName.Add(FileName)
        _Args.Add(Args)
      Case Else
        _ProgramName.Remove(ProgramName)
        _FileName.Remove(FileName)
        _Args.Remove(Args)
    End Select
  End Sub

#End Region

#Region "Test Junk - ignore"

  ''' <summary>
  ''' Example of downloading a file with a thread.
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    Dim thrMyThread As New System.Threading.Thread(AddressOf Downloader)
    thrMyThread.Start()
  End Sub

  ''' <summary>
  ''' Example of how to download - use in daily download script.
  ''' </summary>
  ''' <remarks></remarks>
  Private Sub Downloader()
    My.Computer.Network.DownloadFile("http://media.kaspersky.com/utilities/VirusUtilities/EN/tdsskiller.exe", "C:\tdsskiller.exe")
  End Sub

  'Private Sub RunExe()

  '  For i As Integer = 0 To _FileName.Count - 1

  '    'If CallBack IsNot Nothing Then
  '    '  CallBack(_FileName(i))
  '    'End If
  '    Dim l As Label = CType(Me.Controls("label1"), Label)

  '    'If l.InvokeRequired Then
  '    '  Dim d As New CallBackDelegate(AddressOf Form_WorkStation.CallBack)
  '    '  l.Invoke(d, New Object() {"label1", "Text"})
  '    'Else
  '    '  l.Text = "Text"c
  '    'End If

  '    ' Set start information.
  '    Dim start_info As New ProcessStartInfo(_FileName(i))
  '    start_info.UseShellExecute = False
  '    start_info.CreateNoWindow = True
  '    start_info.Arguments = _Args(i)

  '    ' Make the process and set its start information.
  '    Using proc As New Process

  '      'If FileName(i) = "C:\Windows\System32\cmd.exe" Then
  '      '  proc.StartInfo.RedirectStandardOutput = True
  '      'Else
  '      '  proc.StartInfo.RedirectStandardOutput = False
  '      'End If

  '      proc.StartInfo = start_info

  '      ' Start the process.
  '      Try
  '        'Label1.Text = proc.StandardOutput.ReadToEnd() 'streamwriter writes all the results to the richtextbox.
  '        proc.Start()
  '        proc.WaitForExit()
  '      Catch ex As Exception

  '      End Try

  '    End Using
  '  Next
  '  'MessageBox.Show("Exit Code: " & proc.ExitCode, "Exit " & "Code", MessageBoxButtons.OK, MessageBoxIcon.Information)
  'End Sub

#End Region

End Class
