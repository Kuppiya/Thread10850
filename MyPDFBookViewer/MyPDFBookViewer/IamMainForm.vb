Imports System.IO

Public Class IamMainForm

    Private Sub IamOpenFileFromResources(IamFileName As String)
        Dim IamResourceManager As Resources.ResourceManager
        IamResourceManager = New Resources.ResourceManager("MyPDFBookViewer.Resources", System.Reflection.Assembly.GetExecutingAssembly)
        Dim IamFileStream As New FileStream(".IamTemporaryFile", FileMode.Create)
        Dim IamBinaryWriter As New BinaryWriter(IamFileStream)
        IamBinaryWriter.Write(IamResourceManager.GetObject(IamFileName))
        IamBinaryWriter.Close()
        IamFileStream.Close()
        Dim IamApplicationPath As String = Application.StartupPath()
        IamPDFViewer.src = IamApplicationPath + "\.IamTemporaryFile"
    End Sub


    Private Sub OpenPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPDFToolStripMenuItem.Click
        If IamOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            IamPDFViewer.src = IamOpenFileDialog.FileName
        End If
    End Sub

    Private Sub TestBook02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestBook02ToolStripMenuItem.Click
        IamOpenFileFromResources("Internet")
    End Sub

    Private Sub TestBook02ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TestBook02ToolStripMenuItem1.Click
        IamOpenFileFromResources("Internet_For_Beginners_Part_1")
    End Sub

    Private Sub TestBook03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestBook03ToolStripMenuItem.Click
        IamOpenFileFromResources("Open_Source_Software_Notice")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        IamOpenFileFromResources("MIT_License")
    End Sub
End Class