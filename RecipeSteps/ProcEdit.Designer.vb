<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SaveCmdBtn = New System.Windows.Forms.Button()
        Me.ExitCmdBtn = New System.Windows.Forms.Button()
        Me.RecipeStepIDTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StepTypeTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ParamTargetTxtBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ParamUOMTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StepInstructionsTxtBox = New System.Windows.Forms.TextBox()
        Me.DeleteCmdBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SaveCmdBtn
        '
        Me.SaveCmdBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveCmdBtn.Location = New System.Drawing.Point(12, 456)
        Me.SaveCmdBtn.Name = "SaveCmdBtn"
        Me.SaveCmdBtn.Size = New System.Drawing.Size(77, 41)
        Me.SaveCmdBtn.TabIndex = 10
        Me.SaveCmdBtn.Text = "Save"
        Me.SaveCmdBtn.UseVisualStyleBackColor = True
        '
        'ExitCmdBtn
        '
        Me.ExitCmdBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitCmdBtn.Location = New System.Drawing.Point(287, 456)
        Me.ExitCmdBtn.Name = "ExitCmdBtn"
        Me.ExitCmdBtn.Size = New System.Drawing.Size(77, 41)
        Me.ExitCmdBtn.TabIndex = 11
        Me.ExitCmdBtn.Text = "Exit"
        Me.ExitCmdBtn.UseVisualStyleBackColor = True
        '
        'RecipeStepIDTxtBox
        '
        Me.RecipeStepIDTxtBox.BackColor = System.Drawing.Color.Black
        Me.RecipeStepIDTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeStepIDTxtBox.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeStepIDTxtBox.ForeColor = System.Drawing.Color.White
        Me.RecipeStepIDTxtBox.Location = New System.Drawing.Point(170, 9)
        Me.RecipeStepIDTxtBox.Name = "RecipeStepIDTxtBox"
        Me.RecipeStepIDTxtBox.ReadOnly = True
        Me.RecipeStepIDTxtBox.Size = New System.Drawing.Size(142, 32)
        Me.RecipeStepIDTxtBox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Procedure:"
        '
        'StepTypeTxtBox
        '
        Me.StepTypeTxtBox.BackColor = System.Drawing.Color.Black
        Me.StepTypeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StepTypeTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepTypeTxtBox.ForeColor = System.Drawing.Color.White
        Me.StepTypeTxtBox.Location = New System.Drawing.Point(199, 104)
        Me.StepTypeTxtBox.Name = "StepTypeTxtBox"
        Me.StepTypeTxtBox.ReadOnly = True
        Me.StepTypeTxtBox.Size = New System.Drawing.Size(100, 19)
        Me.StepTypeTxtBox.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(102, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Step Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(140, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 19)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Taget:"
        '
        'ParamTargetTxtBox
        '
        Me.ParamTargetTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParamTargetTxtBox.Location = New System.Drawing.Point(199, 129)
        Me.ParamTargetTxtBox.Name = "ParamTargetTxtBox"
        Me.ParamTargetTxtBox.Size = New System.Drawing.Size(100, 26)
        Me.ParamTargetTxtBox.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(145, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 19)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "UOM:"
        '
        'ParamUOMTxtBox
        '
        Me.ParamUOMTxtBox.BackColor = System.Drawing.Color.Black
        Me.ParamUOMTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ParamUOMTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParamUOMTxtBox.ForeColor = System.Drawing.Color.White
        Me.ParamUOMTxtBox.Location = New System.Drawing.Point(199, 161)
        Me.ParamUOMTxtBox.Name = "ParamUOMTxtBox"
        Me.ParamUOMTxtBox.ReadOnly = True
        Me.ParamUOMTxtBox.Size = New System.Drawing.Size(100, 19)
        Me.ParamUOMTxtBox.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Instructions:"
        '
        'StepInstructionsTxtBox
        '
        Me.StepInstructionsTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepInstructionsTxtBox.Location = New System.Drawing.Point(140, 296)
        Me.StepInstructionsTxtBox.Multiline = True
        Me.StepInstructionsTxtBox.Name = "StepInstructionsTxtBox"
        Me.StepInstructionsTxtBox.Size = New System.Drawing.Size(208, 114)
        Me.StepInstructionsTxtBox.TabIndex = 40
        '
        'DeleteCmdBtn
        '
        Me.DeleteCmdBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteCmdBtn.Location = New System.Drawing.Point(150, 456)
        Me.DeleteCmdBtn.Name = "DeleteCmdBtn"
        Me.DeleteCmdBtn.Size = New System.Drawing.Size(77, 41)
        Me.DeleteCmdBtn.TabIndex = 42
        Me.DeleteCmdBtn.Text = "Delete"
        Me.DeleteCmdBtn.UseVisualStyleBackColor = True
        '
        'ProcEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(376, 509)
        Me.Controls.Add(Me.DeleteCmdBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StepInstructionsTxtBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ParamUOMTxtBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ParamTargetTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StepTypeTxtBox)
        Me.Controls.Add(Me.RecipeStepIDTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitCmdBtn)
        Me.Controls.Add(Me.SaveCmdBtn)
        Me.Name = "ProcEdit"
        Me.Text = "Edit Step"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveCmdBtn As System.Windows.Forms.Button
    Friend WithEvents ExitCmdBtn As System.Windows.Forms.Button
    Friend WithEvents RecipeStepIDTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StepTypeTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ParamTargetTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ParamUOMTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StepInstructionsTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents DeleteCmdBtn As System.Windows.Forms.Button
End Class
