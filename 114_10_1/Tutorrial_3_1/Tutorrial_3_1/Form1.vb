Public Class Form1
    ' 關閉表單
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    ' 取得星期文字
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dayOfWeek As String = dayOfWeekTextBox.Text
        ' TODO: 在這裡加入後續處理邏輯
    End Sub

    ' 週次文字變更事件
    Private Sub weekTextBox_TextChanged(sender As Object, e As EventArgs) Handles weekTextBox.TextChanged
        ' TODO: 如需處理週次變更，請在此加入程式碼
    End Sub

    ' Label5 點擊事件（如無需處理可移除）
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        ' TODO: 如需處理 Label5 點擊，請在此加入程式碼
    End Sub
End Class
