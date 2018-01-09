Public Class IamMainForm
    Private Sub OpenPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPDFToolStripMenuItem.Click
        If IamOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            IamPDFViewer.src = IamOpenFileDialog.FileName
        End If
    End Sub
End Class