<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewRecipeKey
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EditRecipeCmdBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.RecipeKeyTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RecipeNameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RecipeHeaderDescrTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IsEditTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IsActiveTxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RecipeStateTxtBox = New System.Windows.Forms.TextBox()
        Me.DefaultSizeTxtBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RevApproveDateTxtBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RevCreateDateTxtBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RevCreateByTxtBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RevApproveByTxtBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StepNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StepType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Target = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Instructions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StepID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Recipe Key:"
        '
        'EditRecipeCmdBtn
        '
        Me.EditRecipeCmdBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditRecipeCmdBtn.Location = New System.Drawing.Point(175, 768)
        Me.EditRecipeCmdBtn.Name = "EditRecipeCmdBtn"
        Me.EditRecipeCmdBtn.Size = New System.Drawing.Size(150, 41)
        Me.EditRecipeCmdBtn.TabIndex = 6
        Me.EditRecipeCmdBtn.Text = "Edit Revision"
        Me.EditRecipeCmdBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Location = New System.Drawing.Point(479, 768)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(150, 41)
        Me.ExitBtn.TabIndex = 7
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'RecipeKeyTxtBox
        '
        Me.RecipeKeyTxtBox.BackColor = System.Drawing.Color.Black
        Me.RecipeKeyTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeKeyTxtBox.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeKeyTxtBox.ForeColor = System.Drawing.Color.White
        Me.RecipeKeyTxtBox.Location = New System.Drawing.Point(196, 18)
        Me.RecipeKeyTxtBox.Name = "RecipeKeyTxtBox"
        Me.RecipeKeyTxtBox.ReadOnly = True
        Me.RecipeKeyTxtBox.Size = New System.Drawing.Size(142, 32)
        Me.RecipeKeyTxtBox.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Recipe Name:"
        '
        'RecipeNameTxtBox
        '
        Me.RecipeNameTxtBox.BackColor = System.Drawing.Color.Black
        Me.RecipeNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeNameTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeNameTxtBox.ForeColor = System.Drawing.Color.White
        Me.RecipeNameTxtBox.Location = New System.Drawing.Point(159, 66)
        Me.RecipeNameTxtBox.Name = "RecipeNameTxtBox"
        Me.RecipeNameTxtBox.ReadOnly = True
        Me.RecipeNameTxtBox.Size = New System.Drawing.Size(106, 19)
        Me.RecipeNameTxtBox.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(285, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Description:"
        '
        'RecipeHeaderDescrTxtBox
        '
        Me.RecipeHeaderDescrTxtBox.BackColor = System.Drawing.Color.Black
        Me.RecipeHeaderDescrTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeHeaderDescrTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeHeaderDescrTxtBox.ForeColor = System.Drawing.Color.White
        Me.RecipeHeaderDescrTxtBox.Location = New System.Drawing.Point(394, 66)
        Me.RecipeHeaderDescrTxtBox.Name = "RecipeHeaderDescrTxtBox"
        Me.RecipeHeaderDescrTxtBox.ReadOnly = True
        Me.RecipeHeaderDescrTxtBox.Size = New System.Drawing.Size(373, 19)
        Me.RecipeHeaderDescrTxtBox.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(663, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 19)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Is Edit:"
        '
        'IsEditTxtBox
        '
        Me.IsEditTxtBox.BackColor = System.Drawing.Color.Black
        Me.IsEditTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IsEditTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsEditTxtBox.ForeColor = System.Drawing.Color.White
        Me.IsEditTxtBox.Location = New System.Drawing.Point(731, 28)
        Me.IsEditTxtBox.Name = "IsEditTxtBox"
        Me.IsEditTxtBox.ReadOnly = True
        Me.IsEditTxtBox.Size = New System.Drawing.Size(55, 19)
        Me.IsEditTxtBox.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(520, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Is Active:"
        '
        'IsActiveTxtBox
        '
        Me.IsActiveTxtBox.BackColor = System.Drawing.Color.Black
        Me.IsActiveTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IsActiveTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsActiveTxtBox.ForeColor = System.Drawing.Color.White
        Me.IsActiveTxtBox.Location = New System.Drawing.Point(604, 28)
        Me.IsActiveTxtBox.Name = "IsActiveTxtBox"
        Me.IsActiveTxtBox.ReadOnly = True
        Me.IsActiveTxtBox.Size = New System.Drawing.Size(55, 19)
        Me.IsActiveTxtBox.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(42, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Recipe State:"
        '
        'RecipeStateTxtBox
        '
        Me.RecipeStateTxtBox.BackColor = System.Drawing.Color.Black
        Me.RecipeStateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeStateTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeStateTxtBox.ForeColor = System.Drawing.Color.White
        Me.RecipeStateTxtBox.Location = New System.Drawing.Point(159, 106)
        Me.RecipeStateTxtBox.Name = "RecipeStateTxtBox"
        Me.RecipeStateTxtBox.ReadOnly = True
        Me.RecipeStateTxtBox.Size = New System.Drawing.Size(151, 19)
        Me.RecipeStateTxtBox.TabIndex = 24
        '
        'DefaultSizeTxtBox
        '
        Me.DefaultSizeTxtBox.BackColor = System.Drawing.Color.Black
        Me.DefaultSizeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DefaultSizeTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultSizeTxtBox.ForeColor = System.Drawing.Color.White
        Me.DefaultSizeTxtBox.Location = New System.Drawing.Point(159, 131)
        Me.DefaultSizeTxtBox.Name = "DefaultSizeTxtBox"
        Me.DefaultSizeTxtBox.ReadOnly = True
        Me.DefaultSizeTxtBox.Size = New System.Drawing.Size(151, 19)
        Me.DefaultSizeTxtBox.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(47, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Default Size:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(308, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 19)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Rev Approve Date:"
        '
        'RevApproveDateTxtBox
        '
        Me.RevApproveDateTxtBox.BackColor = System.Drawing.Color.Black
        Me.RevApproveDateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RevApproveDateTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RevApproveDateTxtBox.ForeColor = System.Drawing.Color.White
        Me.RevApproveDateTxtBox.Location = New System.Drawing.Point(466, 131)
        Me.RevApproveDateTxtBox.Name = "RevApproveDateTxtBox"
        Me.RevApproveDateTxtBox.ReadOnly = True
        Me.RevApproveDateTxtBox.Size = New System.Drawing.Size(222, 19)
        Me.RevApproveDateTxtBox.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(312, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 19)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Rev Created Date:"
        '
        'RevCreateDateTxtBox
        '
        Me.RevCreateDateTxtBox.BackColor = System.Drawing.Color.Black
        Me.RevCreateDateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RevCreateDateTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RevCreateDateTxtBox.ForeColor = System.Drawing.Color.White
        Me.RevCreateDateTxtBox.Location = New System.Drawing.Point(466, 106)
        Me.RevCreateDateTxtBox.Name = "RevCreateDateTxtBox"
        Me.RevCreateDateTxtBox.ReadOnly = True
        Me.RevCreateDateTxtBox.Size = New System.Drawing.Size(222, 19)
        Me.RevCreateDateTxtBox.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(53, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 19)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Created By:"
        '
        'RevCreateByTxtBox
        '
        Me.RevCreateByTxtBox.BackColor = System.Drawing.Color.Black
        Me.RevCreateByTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RevCreateByTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RevCreateByTxtBox.ForeColor = System.Drawing.Color.White
        Me.RevCreateByTxtBox.Location = New System.Drawing.Point(159, 156)
        Me.RevCreateByTxtBox.Name = "RevCreateByTxtBox"
        Me.RevCreateByTxtBox.ReadOnly = True
        Me.RevCreateByTxtBox.Size = New System.Drawing.Size(151, 19)
        Me.RevCreateByTxtBox.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(345, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 19)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Approved By:"
        '
        'RevApproveByTxtBox
        '
        Me.RevApproveByTxtBox.BackColor = System.Drawing.Color.Black
        Me.RevApproveByTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RevApproveByTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RevApproveByTxtBox.ForeColor = System.Drawing.Color.White
        Me.RevApproveByTxtBox.Location = New System.Drawing.Point(466, 156)
        Me.RevApproveByTxtBox.Name = "RevApproveByTxtBox"
        Me.RevApproveByTxtBox.ReadOnly = True
        Me.RevApproveByTxtBox.Size = New System.Drawing.Size(151, 19)
        Me.RevApproveByTxtBox.TabIndex = 34
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StepNum, Me.StepType, Me.Item, Me.Description, Me.Target, Me.Column6, Me.Column7, Me.Column1, Me.Instructions, Me.StepID})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(36, 196)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(733, 550)
        Me.DataGridView1.TabIndex = 36
        '
        'StepNum
        '
        Me.StepNum.HeaderText = "Step"
        Me.StepNum.Name = "StepNum"
        Me.StepNum.ReadOnly = True
        Me.StepNum.Width = 50
        '
        'StepType
        '
        Me.StepType.HeaderText = "Type"
        Me.StepType.Name = "StepType"
        Me.StepType.ReadOnly = True
        Me.StepType.Width = 70
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 70
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 160
        '
        'Target
        '
        Me.Target.HeaderText = "Percent"
        Me.Target.Name = "Target"
        Me.Target.ReadOnly = True
        Me.Target.Width = 60
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fixed"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 60
        '
        'Column7
        '
        Me.Column7.HeaderText = "Target"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 55
        '
        'Column1
        '
        Me.Column1.HeaderText = "UOM"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Instructions
        '
        Me.Instructions.HeaderText = "Instructions"
        Me.Instructions.Name = "Instructions"
        Me.Instructions.ReadOnly = True
        Me.Instructions.Width = 155
        '
        'StepID
        '
        Me.StepID.HeaderText = "Step ID"
        Me.StepID.Name = "StepID"
        Me.StepID.ReadOnly = True
        Me.StepID.Visible = False
        '
        'ViewRecipeKey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(804, 821)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.RevApproveByTxtBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.RevCreateByTxtBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RevApproveDateTxtBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RevCreateDateTxtBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DefaultSizeTxtBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RecipeStateTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IsEditTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IsActiveTxtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RecipeHeaderDescrTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RecipeNameTxtBox)
        Me.Controls.Add(Me.RecipeKeyTxtBox)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.EditRecipeCmdBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewRecipeKey"
        Me.Text = "Work Order Recipe Creation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EditRecipeCmdBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents RecipeKeyTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RecipeNameTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RecipeHeaderDescrTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IsEditTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IsActiveTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RecipeStateTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents DefaultSizeTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RevApproveDateTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RevCreateDateTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RevCreateByTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RevApproveByTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StepNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StepType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Target As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Instructions As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StepID As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
