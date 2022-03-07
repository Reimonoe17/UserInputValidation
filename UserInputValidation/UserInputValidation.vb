Public Class UserInputValidation
    Sub ValidateInput()
        Dim UserAge As String

        'If AgeTextBox.Text = "" Then
        '    AccumulateMessage("Age is Required")
        '    AgeTextBox.Focus()
        'End If

        Try
            UserAge = CInt(AgeTextBox.Text)
        Catch ex As Exception
            AccumulateMessage("Age must be a Number")
            AgeTextBox.Focus()
        End Try

        If LastNameTextBox.Text = "" Then
            AccumulateMessage("Last Name is Required")
            LastNameTextBox.Focus()
        End If

        If FirstNameTextBox.Text = "" Then
            AccumulateMessage("First Name is Required")
            FirstNameTextBox.Focus()
        End If


        If AccumulateMessage() <> "" Then
            MsgBox(AccumulateMessage())
            AccumulateMessage(, True)
        End If

    End Sub

    Private Function AccumulateMessage(Optional newMessage As String = "", Optional clear As Boolean = False) As String
        Static _message As String

        Select Case clear
            Case False
                If newMessage <> "" Then
                    _message &= newMessage & vbCrLf
                End If
            Case Else
                _message = ""
        End Select
        Return _message
    End Function
    Private Sub Reset()
        'resets all forms to default
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        AgeTextBox.Text = ""
        ResultLabel.Text = "Result"
        'Clear any stored messages
        AccumulateMessage(, True)
    End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        ValidateInput()

    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Reset()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


End Class
