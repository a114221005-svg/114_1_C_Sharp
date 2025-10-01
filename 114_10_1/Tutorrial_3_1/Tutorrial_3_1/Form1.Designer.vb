<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        weekTextBox = New TextBox()
        dayTextBox = New TextBox()
        yearTextBox = New TextBox()
        mounthTextBox = New TextBox()
        Label5 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Label1.Location = New Point(144, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 41)
        Label1.TabIndex = 0
        Label1.Text = "星期:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Label2.Location = New Point(176, 270)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 41)
        Label2.TabIndex = 1
        Label2.Text = "年:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Label3.Location = New Point(176, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 41)
        Label3.TabIndex = 2
        Label3.Text = "日:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Label4.Location = New Point(176, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 41)
        Label4.TabIndex = 3
        Label4.Text = "月:"
        ' 
        ' weekTextBox
        ' 
        weekTextBox.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        weekTextBox.Location = New Point(363, 35)
        weekTextBox.Name = "weekTextBox"
        weekTextBox.Size = New Size(286, 38)
        weekTextBox.TabIndex = 4
        ' 
        ' dayTextBox
        ' 
        dayTextBox.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        dayTextBox.Location = New Point(363, 203)
        dayTextBox.Name = "dayTextBox"
        dayTextBox.Size = New Size(286, 38)
        dayTextBox.TabIndex = 5
        ' 
        ' yearTextBox
        ' 
        yearTextBox.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        yearTextBox.Location = New Point(363, 270)
        yearTextBox.Name = "yearTextBox"
        yearTextBox.Size = New Size(286, 38)
        yearTextBox.TabIndex = 6
        ' 
        ' mounthTextBox
        ' 
        mounthTextBox.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        mounthTextBox.Location = New Point(363, 122)
        mounthTextBox.Name = "mounthTextBox"
        mounthTextBox.Size = New Size(286, 38)
        mounthTextBox.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Location = New Point(86, 386)
        Label5.Name = "Label5"
        Label5.Size = New Size(705, 66)
        Label5.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Button1.Location = New Point(86, 516)
        Button1.Name = "Button1"
        Button1.Size = New Size(174, 56)
        Button1.TabIndex = 9
        Button1.Text = "顯示日期"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Button3.Location = New Point(349, 516)
        Button3.Name = "Button3"
        Button3.Size = New Size(174, 56)
        Button3.TabIndex = 11
        Button3.Text = "清除"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        Button4.Location = New Point(617, 516)
        Button4.Name = "Button4"
        Button4.Size = New Size(174, 56)
        Button4.TabIndex = 12
        Button4.Text = "離開"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(838, 617)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(mounthTextBox)
        Controls.Add(yearTextBox)
        Controls.Add(dayTextBox)
        Controls.Add(weekTextBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents weekTextBox As TextBox
    Friend WithEvents dayTextBox As TextBox
    Friend WithEvents yearTextBox As TextBox
    Friend WithEvents mounthTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

End Class
