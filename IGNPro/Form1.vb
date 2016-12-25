Imports System.Net
Imports System.IO
Public Class Form1
    Dim i As Integer
    Dim mcThread As System.Threading.Thread
    Dim isRunning As Boolean
    Dim namesChecked As Integer
    Dim SF As New SaveFileDialog


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using FD As New OpenFileDialog()
            FD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            If FD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Input.Items.Clear()
                Input.Items.AddRange(IO.File.ReadAllLines(FD.FileName))
            End If
        End Using
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles StartChecking.Click
        mcThread = New System.Threading.Thread(AddressOf StartCheck)
        mcThread.Start()
    End Sub

    Private Sub StartCheck()


        Output.Items.Clear()
        StartChecking.Enabled = False
        StopCheck.Enabled = True
        isRunning = True
        Dim index As Integer = 0
        namesChecked = 1
        For i = 0 To Input.Items.Count - 1



            Dim name As String = CStr(Input.Items(i))


            Dim Request As HttpWebRequest = CType(WebRequest.Create("https://api.mojang.com/users/profiles/minecraft/" + name), HttpWebRequest)

            Dim Response As HttpWebResponse = CType(Request.GetResponse(), HttpWebResponse)



            If Response.StatusCode = HttpStatusCode.NoContent Then
                If name.Length >= 3 And name.Length <= 16 Then
                    Output.Items.Add(name)
                End If
            Else

            End If
            mcThread.Sleep(1200)
            Response.Close()

        Next
        MessageBox.Show("Finished!")
        StartChecking.Enabled = True
        StopCheck.Enabled = False
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        isRunning = False
        Control.CheckForIllegalCrossThreadCalls = False
        StopCheck.Enabled = False
    End Sub

    Private Sub Output_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Output.SelectedIndexChanged

    End Sub

    Private Sub StopCheck_Click(sender As Object, e As EventArgs) Handles StopCheck.Click
        i = Input.Items.Count
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        SF.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If SF.ShowDialog() = DialogResult.OK Then
            Using writer = New StreamWriter(SF.FileName)
                For Each o As Object In Output.Items
                    writer.WriteLine(o)
                Next
            End Using
        End If

    End Sub
End Class
