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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblResult = New Label()
        btnCalculate = New Button()
        txtSeverity = New TextBox()
        txtOccurrence = New TextBox()
        txtDetection = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 15)
        Label1.TabIndex = 3
        Label1.Text = "Severity"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(118, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 4
        Label2.Text = "Occurrence"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(224, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 5
        Label3.Text = "Detection"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(439, 35)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(12, 15)
        lblResult.TabIndex = 6
        lblResult.Text = "-"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(330, 27)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtSeverity
        ' 
        txtSeverity.Location = New Point(12, 27)
        txtSeverity.Name = "txtSeverity"
        txtSeverity.Size = New Size(100, 23)
        txtSeverity.TabIndex = 8
        ' 
        ' txtOccurrence
        ' 
        txtOccurrence.Location = New Point(118, 27)
        txtOccurrence.Name = "txtOccurrence"
        txtOccurrence.Size = New Size(100, 23)
        txtOccurrence.TabIndex = 9
        ' 
        ' txtDetection
        ' 
        txtDetection.Location = New Point(224, 27)
        txtDetection.Name = "txtDetection"
        txtDetection.Size = New Size(100, 23)
        txtDetection.TabIndex = 10
        ' 
        ' Form1
        ' 
        AcceptButton = btnCalculate
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(501, 91)
        Controls.Add(txtDetection)
        Controls.Add(txtOccurrence)
        Controls.Add(txtSeverity)
        Controls.Add(btnCalculate)
        Controls.Add(lblResult)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "PFMEA Action Priority"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtSeverity As TextBox
    Friend WithEvents txtOccurrence As TextBox
    Friend WithEvents txtDetection As TextBox

End Class
