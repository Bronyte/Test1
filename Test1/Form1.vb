Public Class Form1
    Private Sub Button_Run_Click(sender As Object, e As EventArgs) Handles Button_Run.Click

        'Confirm Format and catch any excpetions
        Try
            'Declaring variables and assigning inputs
            Dim FirstNumber As Double = Convert.ToDouble(TextBox_Input_first_no.Text)
            Dim SecondNumber As Double = Convert.ToDouble(TextBox_Input_sec_no.Text)

            'Declaring & initializing output
            Dim Output As String = "Largest Number = "

            'Comparing the variables:
            If FirstNumber > SecondNumber Then
                'Return Output
                TextBox_Output.Text = Output & FirstNumber
            Else
                'Return Output
                TextBox_Output.Text = Output & SecondNumber
            End If

        Catch ex As FormatException
            MessageBox.Show(ex.Message)
        End Try






    End Sub
End Class
