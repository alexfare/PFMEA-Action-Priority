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
                Select Case occurrence
                    Case 6 To 10
                        RiskHigh()
                    Case 4 To 5
                        Select Case detection
                            Case 2 To 10
                                RiskHigh()
                            Case 1
                                RiskMedium()
                        End Select
                    Case 2 To 3
                        Select Case detection
                            Case 7 To 10
                                RiskHigh()
                            Case 5 To 6
                                RiskMedium()
                            Case 1 To 4
                                RiskLow()
                        End Select
                    Case 1
                        RiskLow()
                End Select 'Sev 9-10

            Case 7 To 8
                Select Case occurrence
                    Case 8 To 10
                        RiskHigh()
                    Case 6 To 7
                        Select Case detection
                            Case 2 To 10
                                RiskHigh()
                            Case 1
                                RiskMedium()
                        End Select
                    Case 4 To 5
                        Select Case detection
                            Case 7 To 10
                                RiskHigh()
                            Case 1 To 6
                                RiskMedium()
                        End Select
                    Case 2 To 3
                        Select Case detection
                            Case 5 To 10
                                RiskMedium()
                            Case 1 To 4
                                RiskLow()
                        End Select
                    Case 1
                        RiskLow()
                End Select 'Sev 7-8

            Case 4 To 6
                Select Case occurrence
                    Case 8 To 10
                        Select Case detection
                            Case 5 To 10
                                RiskHigh()
                            Case 1 To 3
                                RiskMedium()
                        End Select
                    Case 6 To 7
                        Select Case detection
                            Case 2 To 10
                                RiskMedium()
                            Case 1
                                RiskLow()
                        End Select
                    Case 4 To 5
                        Select Case detection
                            Case 7 To 10
                                RiskMedium()
                            Case 1 To 6
                                RiskLow()
                        End Select
                    Case 1 To 3
                        RiskLow()
                End Select 'Sev 4-6

            Case 2 To 3
                Select Case occurrence
                    Case 8 To 10
                        Select Case detection
                            Case 5 To 10
                                RiskMedium()
                            Case 1 To 4
                                RiskLow()
                        End Select
                    Case 1 To 7
                        RiskLow()
                End Select 'Sev 2-3
            Case 1
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
