<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseBOM
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChooseBOM))
        Me.SaveCmdBtn = New System.Windows.Forms.Button()
        Me.ExitCmdBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ItemQtyPctTxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RecipeBOMItemDescTxtBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BOMQtyTxtBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ItemQtyFixedTxtBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BOMQtyUOMTxtBox = New System.Windows.Forms.TextBox()
        Me.BOMItemCboBox = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'SaveCmdBtn
        '
        Me.SaveCmdBtn.Location = New System.Drawing.Point(66, 244)
        Me.SaveCmdBtn.Name = "SaveCmdBtn"
        Me.SaveCmdBtn.Size = New System.Drawing.Size(119, 41)
        Me.SaveCmdBtn.TabIndex = 10
        Me.SaveCmdBtn.Text = "Save"
        Me.SaveCmdBtn.UseVisualStyleBackColor = True
        '
        'ExitCmdBtn
        '
        Me.ExitCmdBtn.Location = New System.Drawing.Point(191, 244)
        Me.ExitCmdBtn.Name = "ExitCmdBtn"
        Me.ExitCmdBtn.Size = New System.Drawing.Size(119, 41)
        Me.ExitCmdBtn.TabIndex = 11
        Me.ExitCmdBtn.Text = "Exit"
        Me.ExitCmdBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Choose BOM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(78, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "BOM Item:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(60, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Item Qty Pct:"
        '
        'ItemQtyPctTxtBox
        '
        Me.ItemQtyPctTxtBox.BackColor = System.Drawing.Color.Black
        Me.ItemQtyPctTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemQtyPctTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ItemQtyPctTxtBox.ForeColor = System.Drawing.Color.White
        Me.ItemQtyPctTxtBox.Location = New System.Drawing.Point(172, 117)
        Me.ItemQtyPctTxtBox.Name = "ItemQtyPctTxtBox"
        Me.ItemQtyPctTxtBox.ReadOnly = True
        Me.ItemQtyPctTxtBox.Size = New System.Drawing.Size(154, 19)
        Me.ItemQtyPctTxtBox.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(76, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 19)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Item Desc:"
        '
        'RecipeBOMItemDescTxtBox
        '
        Me.RecipeBOMItemDescTxtBox.BackColor = System.Drawing.Color.Black
        Me.RecipeBOMItemDescTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeBOMItemDescTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RecipeBOMItemDescTxtBox.ForeColor = System.Drawing.Color.White
        Me.RecipeBOMItemDescTxtBox.Location = New System.Drawing.Point(172, 92)
        Me.RecipeBOMItemDescTxtBox.Name = "RecipeBOMItemDescTxtBox"
        Me.RecipeBOMItemDescTxtBox.ReadOnly = True
        Me.RecipeBOMItemDescTxtBox.Size = New System.Drawing.Size(154, 19)
        Me.RecipeBOMItemDescTxtBox.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(84, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 19)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "BOM Qty:"
        '
        'BOMQtyTxtBox
        '
        Me.BOMQtyTxtBox.BackColor = System.Drawing.Color.Black
        Me.BOMQtyTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BOMQtyTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BOMQtyTxtBox.ForeColor = System.Drawing.Color.White
        Me.BOMQtyTxtBox.Location = New System.Drawing.Point(172, 169)
        Me.BOMQtyTxtBox.Name = "BOMQtyTxtBox"
        Me.BOMQtyTxtBox.ReadOnly = True
        Me.BOMQtyTxtBox.Size = New System.Drawing.Size(154, 19)
        Me.BOMQtyTxtBox.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(43, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 19)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Item Qty Fixed:"
        '
        'ItemQtyFixedTxtBox
        '
        Me.ItemQtyFixedTxtBox.BackColor = System.Drawing.Color.Black
        Me.ItemQtyFixedTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemQtyFixedTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ItemQtyFixedTxtBox.ForeColor = System.Drawing.Color.White
        Me.ItemQtyFixedTxtBox.Location = New System.Drawing.Point(172, 143)
        Me.ItemQtyFixedTxtBox.Name = "ItemQtyFixedTxtBox"
        Me.ItemQtyFixedTxtBox.ReadOnly = True
        Me.ItemQtyFixedTxtBox.Size = New System.Drawing.Size(154, 19)
        Me.ItemQtyFixedTxtBox.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(43, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 19)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "BOM Qty UOM:"
        '
        'BOMQtyUOMTxtBox
        '
        Me.BOMQtyUOMTxtBox.BackColor = System.Drawing.Color.Black
        Me.BOMQtyUOMTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BOMQtyUOMTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BOMQtyUOMTxtBox.ForeColor = System.Drawing.Color.White
        Me.BOMQtyUOMTxtBox.Location = New System.Drawing.Point(172, 195)
        Me.BOMQtyUOMTxtBox.Name = "BOMQtyUOMTxtBox"
        Me.BOMQtyUOMTxtBox.ReadOnly = True
        Me.BOMQtyUOMTxtBox.Size = New System.Drawing.Size(154, 19)
        Me.BOMQtyUOMTxtBox.TabIndex = 38
        '
        'BOMItemCboBox
        '
        Me.BOMItemCboBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BOMItemCboBox.FormattingEnabled = True
        Me.BOMItemCboBox.Location = New System.Drawing.Point(172, 57)
        Me.BOMItemCboBox.Name = "BOMItemCboBox"
        Me.BOMItemCboBox.Size = New System.Drawing.Size(161, 27)
        Me.BOMItemCboBox.TabIndex = 42
        '
        'ChooseBOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(376, 297)
        Me.Controls.Add(Me.BOMItemCboBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BOMQtyUOMTxtBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BOMQtyTxtBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ItemQtyFixedTxtBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ItemQtyPctTxtBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RecipeBOMItemDescTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitCmdBtn)
        Me.Controls.Add(Me.SaveCmdBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChooseBOM"
        Me.Text = "Edit Step"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveCmdBtn As System.Windows.Forms.Button
    Friend WithEvents ExitCmdBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ItemQtyPctTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RecipeBOMItemDescTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BOMQtyTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ItemQtyFixedTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BOMQtyUOMTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents BOMItemCboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
