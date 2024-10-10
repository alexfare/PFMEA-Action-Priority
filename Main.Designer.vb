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
        Panel1 = New Panel()
        vControl = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 15)
        Label1.TabIndex = 3
        Label1.Text = "Severity"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(114, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 4
        Label2.Text = "Occurrence"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(220, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 5
        Label3.Text = "Detection"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResult.Location = New Point(165, 74)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(49, 21)
        lblResult.TabIndex = 6
        lblResult.Text = "NULL"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(326, 31)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtSeverity
        ' 
        txtSeverity.Location = New Point(8, 31)
        txtSeverity.Name = "txtSeverity"
        txtSeverity.Size = New Size(100, 23)
        txtSeverity.TabIndex = 8
        ' 
        ' txtOccurrence
        ' 
        txtOccurrence.Location = New Point(114, 31)
        txtOccurrence.Name = "txtOccurrence"
        txtOccurrence.Size = New Size(100, 23)
        txtOccurrence.TabIndex = 9
        ' 
        ' txtDetection
        ' 
        txtDetection.Location = New Point(220, 31)
        txtDetection.Name = "txtDetection"
        txtDetection.Size = New Size(100, 23)
        txtDetection.TabIndex = 10
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(vControl)
        Panel1.Controls.Add(btnCalculate)
        Panel1.Controls.Add(txtDetection)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtOccurrence)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtSeverity)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(lblResult)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(489, 110)
        Panel1.TabIndex = 11
        ' 
        ' vControl
        ' 
        vControl.AutoSize = True
        vControl.Location = New Point(430, 80)
        vControl.Name = "vControl"
        vControl.Size = New Size(53, 15)
        vControl.TabIndex = 12
        vControl.Text = "vControl"
        ' 
        ' Form1
        ' 
        AcceptButton = btnCalculate
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(507, 128)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PFMEA Action Priority"
        TopMost = True
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtSeverity As TextBox
    Friend WithEvents txtOccurrence As TextBox
    Friend WithEvents txtDetection As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents vControl As Label

End Class
