Public Class Form1
    Dim riskLevel As String
    Dim riskColor As Color = Color.Black

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vControl.Text = My.Settings.Version
        lblResult.Text = ""
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Public Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim severity, occurrence, detection As Integer

        ' Input validation
        If Not Integer.TryParse(txtSeverity.Text, severity) OrElse Not Integer.TryParse(txtOccurrence.Text, occurrence) OrElse Not Integer.TryParse(txtDetection.Text, detection) Then
            MessageBox.Show("Please enter valid numbers for Severity, Occurrence, and Detection.")
            Return
        End If

        riskLevel = ""
        riskColor = Color.Black

        ' Revised risk level calculation logic based on PFMEA table
        Select Case severity
            Case 9 To 10
                If occurrence >= 8 AndAlso detection = 1 Then
                    RiskHigh()
                ElseIf occurrence >= 4 AndAlso occurrence <= 10 AndAlso detection <= 10 Then
                    RiskHigh()
                ElseIf occurrence >= 2 AndAlso occurrence <= 3 AndAlso detection >= 1 AndAlso detection <= 10 Then
                    RiskMedium()
                Else
                    RiskLow()
                End If

            Case 7 To 8
                If occurrence >= 8 AndAlso detection >= 1 AndAlso detection <= 10 Then
                    RiskHigh()
                ElseIf occurrence >= 6 AndAlso detection = 1 Then
                    RiskHigh()
                ElseIf occurrence >= 4 AndAlso detection >= 7 Then
                    RiskHigh()
                ElseIf occurrence >= 2 AndAlso detection >= 5 Then
                    RiskMedium()
                Else
                    RiskLow()
                End If

            Case 4 To 6
                If occurrence >= 8 AndAlso detection >= 4 Then
                    RiskMedium()
                ElseIf occurrence >= 4 AndAlso detection >= 7 Then
                    RiskMedium()
                ElseIf occurrence <= 3 AndAlso detection <= 3 Then
                    RiskLow()
                Else
                    RiskLow()
                End If

            Case 2 To 3
                If occurrence >= 8 AndAlso detection >= 5 Then
                    RiskMedium()
                ElseIf occurrence <= 7 AndAlso detection <= 4 Then
                    RiskLow()
                Else
                    RiskLow()
                End If

            Case 1
                RiskLow()

            Case Else
                RiskLow()
        End Select

        ' Display the result
        lblResult.Text = riskLevel
        lblResult.ForeColor = riskColor
        txtSeverity.Text = ""
        txtOccurrence.Text = ""
        txtDetection.Text = ""
        txtSeverity.Focus()
    End Sub

    Private Sub RiskLow()
        riskLevel = "LOW"
        riskColor = Color.Green
    End Sub

    Private Sub RiskMedium()
        riskLevel = "MEDIUM"
        riskColor = Color.Orange
    End Sub

    Private Sub RiskHigh()
        riskLevel = "HIGH"
        riskColor = Color.Red
    End Sub
End Class
