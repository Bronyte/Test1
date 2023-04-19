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
        TextBox_Input_first_no = New TextBox()
        TextBox_Input_sec_no = New TextBox()
        TextBox3 = New TextBox()
        Button_Run = New Button()
        TextBox4 = New TextBox()
        TextBox_Output = New TextBox()
        SuspendLayout()
        ' 
        ' TextBox_Input_first_no
        ' 
        TextBox_Input_first_no.Location = New Point(203, 30)
        TextBox_Input_first_no.Name = "TextBox_Input_first_no"
        TextBox_Input_first_no.Size = New Size(125, 27)
        TextBox_Input_first_no.TabIndex = 0
        ' 
        ' TextBox_Input_sec_no
        ' 
        TextBox_Input_sec_no.Location = New Point(203, 85)
        TextBox_Input_sec_no.Name = "TextBox_Input_sec_no"
        TextBox_Input_sec_no.Size = New Size(125, 27)
        TextBox_Input_sec_no.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(27, 85)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 2
        TextBox3.Text = "Second Value"
        ' 
        ' Button_Run
        ' 
        Button_Run.Location = New Point(120, 187)
        Button_Run.Name = "Button_Run"
        Button_Run.Size = New Size(94, 29)
        Button_Run.TabIndex = 3
        Button_Run.Text = "Run"
        Button_Run.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(27, 30)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 4
        TextBox4.Text = "First Value"
        ' 
        ' TextBox_Output
        ' 
        TextBox_Output.Location = New Point(27, 138)
        TextBox_Output.Name = "TextBox_Output"
        TextBox_Output.ReadOnly = True
        TextBox_Output.Size = New Size(301, 27)
        TextBox_Output.TabIndex = 5
        TextBox_Output.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(364, 228)
        Controls.Add(TextBox_Output)
        Controls.Add(TextBox4)
        Controls.Add(Button_Run)
        Controls.Add(TextBox3)
        Controls.Add(TextBox_Input_sec_no)
        Controls.Add(TextBox_Input_first_no)
        Name = "Form1"
        Text = "Largest Number"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox_Input_first_no As TextBox
    Friend WithEvents TextBox_Input_sec_no As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button_Run As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox_Output As TextBox
End Class
