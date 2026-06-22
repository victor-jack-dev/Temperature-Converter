<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTemp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblTemp = New Label()
        txtTemp = New TextBox()
        lblResult = New Label()
        txtResult = New TextBox()
        rdoCtoF = New RadioButton()
        rdoFtoC = New RadioButton()
        btnConvert = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblTemp
        ' 
        lblTemp.AutoSize = True
        lblTemp.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTemp.Location = New Point(44, 24)
        lblTemp.Name = "lblTemp"
        lblTemp.Size = New Size(151, 21)
        lblTemp.TabIndex = 0
        lblTemp.Text = "Enter Temperature"
        ' 
        ' txtTemp
        ' 
        txtTemp.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtTemp.Location = New Point(221, 30)
        txtTemp.Name = "txtTemp"
        txtTemp.Size = New Size(183, 29)
        txtTemp.TabIndex = 1
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResult.Location = New Point(44, 77)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(64, 21)
        lblResult.TabIndex = 2
        lblResult.Text = "Results"
        ' 
        ' txtResult
        ' 
        txtResult.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtResult.Location = New Point(221, 75)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(183, 29)
        txtResult.TabIndex = 3
        ' 
        ' rdoCtoF
        ' 
        rdoCtoF.AutoSize = True
        rdoCtoF.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdoCtoF.Location = New Point(44, 139)
        rdoCtoF.Name = "rdoCtoF"
        rdoCtoF.Size = New Size(187, 25)
        rdoCtoF.TabIndex = 4
        rdoCtoF.TabStop = True
        rdoCtoF.Text = "Celsius to Fahrenheit"
        rdoCtoF.UseVisualStyleBackColor = True
        ' 
        ' rdoFtoC
        ' 
        rdoFtoC.AutoSize = True
        rdoFtoC.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdoFtoC.Location = New Point(44, 186)
        rdoFtoC.Name = "rdoFtoC"
        rdoFtoC.Size = New Size(187, 25)
        rdoFtoC.TabIndex = 5
        rdoFtoC.TabStop = True
        rdoFtoC.Text = "Fahrenheit to Celsius"
        rdoFtoC.UseVisualStyleBackColor = True
        ' 
        ' btnConvert
        ' 
        btnConvert.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConvert.Location = New Point(44, 241)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(93, 29)
        btnConvert.TabIndex = 6
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(610, 281)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 31)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmTemp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(688, 314)
        Controls.Add(btnExit)
        Controls.Add(btnConvert)
        Controls.Add(rdoFtoC)
        Controls.Add(rdoCtoF)
        Controls.Add(txtResult)
        Controls.Add(lblResult)
        Controls.Add(txtTemp)
        Controls.Add(lblTemp)
        Name = "frmTemp"
        Text = "Temperature Converter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTemp As Label
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents rdoCtoF As RadioButton
    Friend WithEvents rdoFtoC As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button

End Class
