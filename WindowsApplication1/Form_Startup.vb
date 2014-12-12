'Force user to select a drive before allowing them to use the main WorkStation application.
Imports System.IO

Public Class Form_Startup

  Dim FolderBrowser As New FolderBrowserDialog
  Public Shared _SelectedDrive As String

  Public Shared ReadOnly Property SelectedDrive As String
    Get
      Return _SelectedDrive
    End Get
  End Property

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    'Populate global values.
    SetGlobals()
  End Sub

  ''' <summary>
  ''' Drive selector
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ChooseDrive.Click
    FolderBrowser.Description = "Select the drive you want to scan."
    FolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowser.ShowDialog()

    If FolderBrowser.SelectedPath <> "" AndAlso FolderBrowser.SelectedPath.Length < 4 Then
      _SelectedDrive = FolderBrowser.SelectedPath
      OpenWorkStation(FolderBrowser)
    Else
      MessageBox.Show("Please select the root directory of a drive")
    End If
  End Sub

  ''' <summary>
  ''' Open Form_WorkStation.vb
  ''' </summary>
  ''' <param name="SelectedDrive"></param>
  ''' <remarks></remarks>
  Private Sub OpenWorkStation(ByVal SelectedDrive As FolderBrowserDialog)
    Dim Form As New Form_WorkStation(FolderBrowser)
    Me.Enabled = False
    Me.Visible = False
    'Not sure if necessary but leaving in because drunk
    Me.Invalidate()
    Form.ShowDialog()
    Me.Close()
  End Sub

End Class