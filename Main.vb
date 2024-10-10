Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vControl.Text = My.Settings.Version
        lblResult.Text = ""
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim severity, occurrence, detection As Integer

        ' Input validation
        If Not Integer.TryParse(txtSeverity.Text, severity) OrElse Not Integer.TryParse(txtOccurrence.Text, occurrence) OrElse Not Integer.TryParse(txtDetection.Text, detection) Then
            MessageBox.Show("Please enter valid numbers for Severity, Occurrence, and Detection.")
            Return
        End If

        Dim riskLevel As String = ""
        Dim riskColor As Color = Color.Black

        ' Risk level calculation logic based on updated Action Priority matrix
        If severity = 1 Then
            riskLevel = "LOW"
            riskColor = Color.Green
        ElseIf severity >= 2 AndAlso severity <= 3 Then
            If occurrence >= 8 AndAlso occurrence <= 10 AndAlso detection >= 5 AndAlso detection <= 10 Then
                riskLevel = "MEDIUM"
                riskColor = Color.Yellow
            Else
                riskLevel = "LOW"
                riskColor = Color.Green
            End If
        ElseIf severity >= 4 AndAlso severity <= 6 Then
            If occurrence >= 4 AndAlso occurrence <= 5 Then
                If detection >= 7 AndAlso detection <= 10 Then
                    riskLevel = "MEDIUM"
                    riskColor = Color.Yellow
                Else
                    riskLevel = "LOW"
                    riskColor = Color.Green
                End If
            ElseIf occurrence >= 6 AndAlso occurrence <= 7 Then
                If detection >= 2 AndAlso detection <= 10 Then
                    riskLevel = "MEDIUM"
                    riskColor = Color.Yellow
                Else
                    riskLevel = "LOW"
                    riskColor = Color.Green
                End If
            ElseIf occurrence >= 8 AndAlso occurrence <= 10 Then
                If detection >= 1 AndAlso detection <= 3 Then
                    riskLevel = "MEDIUM"
                    riskColor = Color.Yellow
                Else
                    riskLevel = "HIGH"
                    riskColor = Color.Red
                End If
            Else
                riskLevel = "LOW"
                riskColor = Color.Green
            End If
        ElseIf severity >= 7 AndAlso severity <= 8 Then
            If occurrence = 1 Then
                riskLevel = "LOW"
                riskColor = Color.Green
            ElseIf occurrence >= 2 AndAlso occurrence <= 3 Then
                If detection >= 5 AndAlso detection <= 10 Then
                    riskLevel = "MEDIUM"
                    riskColor = Color.Yellow
                Else
                    riskLevel = "LOW"
                    riskColor = Color.Green
                End If
            ElseIf occurrence >= 4 AndAlso occurrence <= 5 Then
                If detection >= 7 AndAlso detection <= 10 Then
                    riskLevel = "HIGH"
                    riskColor = Color.Red
                Else
                    riskLevel = "MEDIUM"
                    riskColor = Color.Yellow
                End If
            ElseIf occurrence >= 6 AndAlso occurrence <= 7 Then
                If detection = 1 Then
                    riskLevel = "MEDIUM"
                    riskColor = Color.Yellow
                Else
                    riskLevel = "HIGH"
                    riskColor = Color.Red
                End If
            ElseIf occurrence >= 8 AndAlso occurrence <= 10 Then
                riskLevel = "HIGH"
                riskColor = Color.Red
            Else
                riskLevel = "LOW"
                riskColor = Color.Green
            End If
        ElseIf severity >= 9 AndAlso severity <= 10 Then
            If occurrence = 1 Then
                riskLevel = "LOW"
                riskColor = Color.Green
            ElseIf occurrence >= 2 AndAlso occurrence <= 3 Then
                If detection >= 1 AndAlso detection <= 10 Then
                    riskLevel = "MEDIUM"
                    riskColor = Color.Yellow
                End If
            ElseIf occurrence >= 4 AndAlso occurrence <= 10 Then
                If detection = 1 Then
                    riskLevel = "MEDIUM"
                    riskColor = Color.Yellow
                Else
                    riskLevel = "HIGH"
                    riskColor = Color.Red
                End If
            Else
                riskLevel = "LOW"
                riskColor = Color.Green
            End If
        End If

        ' Display the result
        lblResult.Text = riskLevel
        lblResult.ForeColor = riskColor
        txtSeverity.Text = ""
        txtOccurrence.Text = ""
        txtDetection.Text = ""
        txtSeverity.Focus()
    End Sub
End Class
