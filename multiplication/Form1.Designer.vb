<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MultiplicationTableListBox = New ListBox()
        MultiplicationTableButton = New Button()
        SuspendLayout()
        ' 
        ' MultiplicationTableListBox
        ' 
        MultiplicationTableListBox.FormattingEnabled = True
        MultiplicationTableListBox.ItemHeight = 15
        MultiplicationTableListBox.Location = New Point(57, 19)
        MultiplicationTableListBox.Name = "MultiplicationTableListBox"
        MultiplicationTableListBox.Size = New Size(587, 244)
        MultiplicationTableListBox.TabIndex = 0
        ' 
        ' MultiplicationTableButton
        ' 
        MultiplicationTableButton.Location = New Point(57, 278)
        MultiplicationTableButton.Name = "MultiplicationTableButton"
        MultiplicationTableButton.Size = New Size(155, 23)
        MultiplicationTableButton.TabIndex = 1
        MultiplicationTableButton.Text = "Multiplication Table"
        MultiplicationTableButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MultiplicationTableButton)
        Controls.Add(MultiplicationTableListBox)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents MultiplicationTableListBox As ListBox
    Friend WithEvents MultiplicationTableButton As Button

End Class
