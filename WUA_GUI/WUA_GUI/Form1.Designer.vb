<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Host = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Updatestatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Installstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Downloadforschritt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstallationsforschrittAktuell = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstallationsforschrittGesamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DownloadAndInstallUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Host, Me.Updatestatus, Me.Installstatus, Me.Downloadforschritt, Me.InstallationsforschrittAktuell, Me.InstallationsforschrittGesamt})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1316, 413)
        Me.DataGridView1.TabIndex = 0
        '
        'Host
        '
        Me.Host.HeaderText = "Host"
        Me.Host.Name = "Host"
        '
        'Updatestatus
        '
        Me.Updatestatus.HeaderText = "Updatestatus"
        Me.Updatestatus.Name = "Updatestatus"
        '
        'Installstatus
        '
        Me.Installstatus.HeaderText = "Installstatus"
        Me.Installstatus.Name = "Installstatus"
        '
        'Downloadforschritt
        '
        Me.Downloadforschritt.HeaderText = "Downloadforschritt"
        Me.Downloadforschritt.Name = "Downloadforschritt"
        '
        'InstallationsforschrittAktuell
        '
        Me.InstallationsforschrittAktuell.HeaderText = "InstallationsforschrittAktuell"
        Me.InstallationsforschrittAktuell.Name = "InstallationsforschrittAktuell"
        '
        'InstallationsforschrittGesamt
        '
        Me.InstallationsforschrittGesamt.HeaderText = "InstallationsforschrittGesamt"
        Me.InstallationsforschrittGesamt.Name = "InstallationsforschrittGesamt"
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(18, 49)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(74, 25)
        Me.Button_Add.TabIndex = 1
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadAndInstallUpdatesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(229, 26)
        '
        'DownloadAndInstallUpdatesToolStripMenuItem
        '
        Me.DownloadAndInstallUpdatesToolStripMenuItem.Name = "DownloadAndInstallUpdatesToolStripMenuItem"
        Me.DownloadAndInstallUpdatesToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.DownloadAndInstallUpdatesToolStripMenuItem.Text = "Download and Install Updates"
        '
        'BackgroundWorker1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 508)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Host As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Updatestatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Installstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Downloadforschritt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallationsforschrittAktuell As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallationsforschrittGesamt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button_Add As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Public WithEvents DownloadAndInstallUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
