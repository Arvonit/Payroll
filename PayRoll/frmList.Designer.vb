<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnName = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstEmployees = New System.Windows.Forms.ListBox()
        Me.btnPayRate = New System.Windows.Forms.Button()
        Me.btnAge = New System.Windows.Forms.Button()
        Me.lblTotalEmployees = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(226, 267)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnName
        '
        Me.btnName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnName.Location = New System.Drawing.Point(226, 39)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(120, 23)
        Me.btnName.TabIndex = 2
        Me.btnName.Text = "Organize by Name"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.Location = New System.Drawing.Point(226, 238)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Location = New System.Drawing.Point(224, 156)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 23)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print Out Report"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalculate.Location = New System.Drawing.Point(225, 127)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(119, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate Pay"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lstEmployees
        '
        Me.lstEmployees.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstEmployees.FormattingEnabled = True
        Me.lstEmployees.Location = New System.Drawing.Point(13, 39)
        Me.lstEmployees.Name = "lstEmployees"
        Me.lstEmployees.Size = New System.Drawing.Size(207, 251)
        Me.lstEmployees.TabIndex = 8
        '
        'btnPayRate
        '
        Me.btnPayRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPayRate.Location = New System.Drawing.Point(227, 69)
        Me.btnPayRate.Name = "btnPayRate"
        Me.btnPayRate.Size = New System.Drawing.Size(118, 23)
        Me.btnPayRate.TabIndex = 9
        Me.btnPayRate.Text = "Organize by Pay Rate"
        Me.btnPayRate.UseVisualStyleBackColor = True
        '
        'btnAge
        '
        Me.btnAge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAge.Location = New System.Drawing.Point(226, 98)
        Me.btnAge.Name = "btnAge"
        Me.btnAge.Size = New System.Drawing.Size(118, 23)
        Me.btnAge.TabIndex = 10
        Me.btnAge.Text = "Organize by Age"
        Me.btnAge.UseVisualStyleBackColor = True
        '
        'lblTotalEmployees
        '
        Me.lblTotalEmployees.AutoSize = True
        Me.lblTotalEmployees.Location = New System.Drawing.Point(13, 297)
        Me.lblTotalEmployees.Name = "lblTotalEmployees"
        Me.lblTotalEmployees.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalEmployees.TabIndex = 11
        Me.lblTotalEmployees.Text = "Label1"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Location = New System.Drawing.Point(13, 13)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(0, 13)
        Me.lblDetails.TabIndex = 12
        '
        'frmList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 323)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblTotalEmployees)
        Me.Controls.Add(Me.btnAge)
        Me.Controls.Add(Me.btnPayRate)
        Me.Controls.Add(Me.lstEmployees)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnName)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmList"
        Me.Text = "Employee List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnName As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lstEmployees As ListBox
    Friend WithEvents btnPayRate As Button
    Friend WithEvents btnAge As Button
    Friend WithEvents lblTotalEmployees As Label
    Friend WithEvents lblDetails As Label
End Class
