<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crviewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(crviewer))
        Me.cryviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'cryviewer
        '
        Me.cryviewer.ActiveViewIndex = -1
        Me.cryviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cryviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cryviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cryviewer.Location = New System.Drawing.Point(0, 0)
        Me.cryviewer.Name = "cryviewer"
        Me.cryviewer.SelectionFormula = ""
        Me.cryviewer.Size = New System.Drawing.Size(531, 261)
        Me.cryviewer.TabIndex = 0
        Me.cryviewer.ViewTimeSelectionFormula = ""
        '
        'crviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 261)
        Me.Controls.Add(Me.cryviewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "crviewer"
        Me.Text = "Daily Invoice Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cryviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
