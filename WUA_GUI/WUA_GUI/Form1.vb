Public Class Form1
    Dim t As System.Threading.Thread

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Add.Click
        Dim temppc
        temppc = InputBox("Rechnernamen eingeben", "Add PC", "")
        DataGridView1.Rows.Add(temppc)
    End Sub

    Private Sub DataGridView1_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Cursor.Position)
        End If



    End Sub

    Private Sub DownloadAndInstallUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadAndInstallUpdatesToolStripMenuItem.Click
        Dim cell As DataGridViewCell

        For Each cell In DataGridView1.SelectedCells

            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory("C:\Update", "\\" & cell.Value.ToString & "\c$\Update")
            Process.Start("psexec.exe", "\\" & cell.Value.ToString & " -s -h C:\Update\WUA_Client.exe")

            Dim FS_updatestatus As New System.IO.FileStream("\\" & cell.Value.ToString & "\c$\Update\updatestatus.log", IO.FileMode.Open, IO.FileAccess.Read)
            Dim FSR As New System.IO.StreamReader(FS_updatestatus)
            Dim temp
            While 1

                temp = FSR.ReadLine

            End While

        Next


    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

End Class
