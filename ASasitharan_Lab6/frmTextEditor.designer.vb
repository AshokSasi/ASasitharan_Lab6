<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
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
        Me.components = New System.ComponentModel.Container()
        Me.txtTextEditor = New System.Windows.Forms.RichTextBox()
        Me.textEditorToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtTextEditor
        '
        Me.txtTextEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTextEditor.Location = New System.Drawing.Point(0, 0)
        Me.txtTextEditor.Name = "txtTextEditor"
        Me.txtTextEditor.Size = New System.Drawing.Size(800, 450)
        Me.txtTextEditor.TabIndex = 2
        Me.txtTextEditor.Text = ""
        Me.textEditorToolTips.SetToolTip(Me.txtTextEditor, "Enter text here.")
        '
        'TextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTextEditor)
        Me.Name = "TextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTextEditor As RichTextBox
    Friend WithEvents textEditorToolTips As ToolTip
End Class
