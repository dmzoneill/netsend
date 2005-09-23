Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myProcess As Process = New Process()

        Dim outfile As String = Application.StartupPath & "\dirOutput.txt"
        Dim sysFolder As String = System.Environment.GetFolderPath(Environment.SpecialFolder.System)
        myProcess.StartInfo.FileName = "net.exe"
        myProcess.StartInfo.Arguments = "send " & TextBox1.Text & " " & Chr(34) & RichTextBox1.Text & Chr(34)
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.Start()
        myProcess.WaitForExit(1000)
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If
        MessageBox.Show("The 'dir' command window was closed at: " & myProcess.ExitTime & "." & System.Environment.NewLine & "Exit Code: " & myProcess.ExitCode)
        myProcess.Close()
    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
   
    End Sub
End Class
