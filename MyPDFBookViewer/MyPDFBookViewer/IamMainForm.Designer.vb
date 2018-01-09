<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IamMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IamMainForm))
        Me.IamMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestBook02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestBook02ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestBook03ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IamOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.IamPDFViewer = New AxAcroPDFLib.AxAcroPDF()
        Me.IamMenuStrip.SuspendLayout()
        CType(Me.IamPDFViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IamMenuStrip
        '
        Me.IamMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.BooksToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.IamMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.IamMenuStrip.Name = "IamMenuStrip"
        Me.IamMenuStrip.Size = New System.Drawing.Size(770, 24)
        Me.IamMenuStrip.TabIndex = 0
        Me.IamMenuStrip.Text = "MenuStrip1"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenPDFToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.OpenToolStripMenuItem.Text = "File"
        '
        'OpenPDFToolStripMenuItem
        '
        Me.OpenPDFToolStripMenuItem.Name = "OpenPDFToolStripMenuItem"
        Me.OpenPDFToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenPDFToolStripMenuItem.Text = "Open PDF"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestBook02ToolStripMenuItem, Me.TestBook02ToolStripMenuItem1, Me.TestBook03ToolStripMenuItem})
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.BooksToolStripMenuItem.Text = "Books"
        '
        'TestBook02ToolStripMenuItem
        '
        Me.TestBook02ToolStripMenuItem.Name = "TestBook02ToolStripMenuItem"
        Me.TestBook02ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TestBook02ToolStripMenuItem.Text = "Test Book 01"
        '
        'TestBook02ToolStripMenuItem1
        '
        Me.TestBook02ToolStripMenuItem1.Name = "TestBook02ToolStripMenuItem1"
        Me.TestBook02ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.TestBook02ToolStripMenuItem1.Text = "Test Book 02"
        '
        'TestBook03ToolStripMenuItem
        '
        Me.TestBook03ToolStripMenuItem.Name = "TestBook03ToolStripMenuItem"
        Me.TestBook03ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TestBook03ToolStripMenuItem.Text = "Test Book 03"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'IamOpenFileDialog
        '
        Me.IamOpenFileDialog.FileName = "*.PDF"
        Me.IamOpenFileDialog.Title = "Open PDF Book"
        '
        'IamPDFViewer
        '
        Me.IamPDFViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IamPDFViewer.Enabled = True
        Me.IamPDFViewer.Location = New System.Drawing.Point(0, 27)
        Me.IamPDFViewer.Name = "IamPDFViewer"
        Me.IamPDFViewer.OcxState = CType(resources.GetObject("IamPDFViewer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.IamPDFViewer.Size = New System.Drawing.Size(770, 356)
        Me.IamPDFViewer.TabIndex = 1
        '
        'IamMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 379)
        Me.Controls.Add(Me.IamPDFViewer)
        Me.Controls.Add(Me.IamMenuStrip)
        Me.MainMenuStrip = Me.IamMenuStrip
        Me.Name = "IamMainForm"
        Me.Text = "My PDF Book Viewer"
        Me.IamMenuStrip.ResumeLayout(False)
        Me.IamMenuStrip.PerformLayout()
        CType(Me.IamPDFViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IamMenuStrip As MenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenPDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestBook02ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestBook02ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TestBook03ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IamOpenFileDialog As OpenFileDialog
    Friend WithEvents IamPDFViewer As AxAcroPDFLib.AxAcroPDF
End Class
