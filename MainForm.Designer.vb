<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnCalculate = New Button()
        txtSeverity = New TextBox()
        txtOccurrence = New TextBox()
        txtDetection = New TextBox()
        Panel1 = New Panel()
        lblResult = New TextBox()
        LblDetResults = New TextBox()
        LblOccResults = New TextBox()
        LblSevResults = New TextBox()
        BtnClear = New Button()
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
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(326, 31)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(91, 23)
        btnCalculate.TabIndex = 3
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtSeverity
        ' 
        txtSeverity.Location = New Point(8, 31)
        txtSeverity.Name = "txtSeverity"
        txtSeverity.Size = New Size(100, 23)
        txtSeverity.TabIndex = 0
        ' 
        ' txtOccurrence
        ' 
        txtOccurrence.Location = New Point(114, 31)
        txtOccurrence.Name = "txtOccurrence"
        txtOccurrence.Size = New Size(100, 23)
        txtOccurrence.TabIndex = 1
        ' 
        ' txtDetection
        ' 
        txtDetection.Location = New Point(220, 31)
        txtDetection.Name = "txtDetection"
        txtDetection.Size = New Size(100, 23)
        txtDetection.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(BtnClear)
        Panel1.Controls.Add(lblResult)
        Panel1.Controls.Add(LblDetResults)
        Panel1.Controls.Add(LblOccResults)
        Panel1.Controls.Add(LblSevResults)
        Panel1.Controls.Add(btnCalculate)
        Panel1.Controls.Add(txtDetection)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtOccurrence)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtSeverity)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(421, 136)
        Panel1.TabIndex = 11
        ' 
        ' lblResult
        ' 
        lblResult.BackColor = SystemColors.Menu
        lblResult.BorderStyle = BorderStyle.None
        lblResult.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResult.Location = New Point(3, 105)
        lblResult.Name = "lblResult"
        lblResult.ReadOnly = True
        lblResult.Size = New Size(415, 26)
        lblResult.TabIndex = 10
        lblResult.TabStop = False
        lblResult.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblDetResults
        ' 
        LblDetResults.BackColor = SystemColors.Menu
        LblDetResults.BorderStyle = BorderStyle.None
        LblDetResults.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        LblDetResults.Location = New Point(220, 60)
        LblDetResults.Name = "LblDetResults"
        LblDetResults.ReadOnly = True
        LblDetResults.Size = New Size(100, 16)
        LblDetResults.TabIndex = 9
        LblDetResults.TabStop = False
        LblDetResults.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblOccResults
        ' 
        LblOccResults.BackColor = SystemColors.Menu
        LblOccResults.BorderStyle = BorderStyle.None
        LblOccResults.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        LblOccResults.Location = New Point(114, 60)
        LblOccResults.Name = "LblOccResults"
        LblOccResults.ReadOnly = True
        LblOccResults.Size = New Size(100, 16)
        LblOccResults.TabIndex = 8
        LblOccResults.TabStop = False
        LblOccResults.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblSevResults
        ' 
        LblSevResults.BackColor = SystemColors.Menu
        LblSevResults.BorderStyle = BorderStyle.None
        LblSevResults.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        LblSevResults.Location = New Point(8, 60)
        LblSevResults.Name = "LblSevResults"
        LblSevResults.ReadOnly = True
        LblSevResults.Size = New Size(100, 16)
        LblSevResults.TabIndex = 7
        LblSevResults.TabStop = False
        LblSevResults.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(8, 108)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(75, 23)
        BtnClear.TabIndex = 11
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AcceptButton = btnCalculate
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 155)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "MainForm"
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
    Friend WithEvents ToolStripStatusLabel1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtSeverity As TextBox
    Friend WithEvents txtOccurrence As TextBox
    Friend WithEvents txtDetection As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblDetResults As TextBox
    Friend WithEvents LblOccResults As TextBox
    Friend WithEvents LblSevResults As TextBox
    Friend WithEvents lblResult As TextBox
    Friend WithEvents BtnClear As Button

End Class
