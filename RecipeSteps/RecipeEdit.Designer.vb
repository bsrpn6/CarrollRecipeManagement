<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecipeEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecipeEdit))
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ProcDispStepType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcInstructions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcStepType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcTemplateID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RecipeKeyTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ExitCmdBtn = New System.Windows.Forms.Button()
        Me.ActivateBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UnassignedRdoBtn = New System.Windows.Forms.RadioButton()
        Me.AllRdoBtn = New System.Windows.Forms.RadioButton()
        Me.ProcCboBox = New System.Windows.Forms.ComboBox()
        Me.DeleteRevCmdBtn = New System.Windows.Forms.Button()
        Me.MoveStepDownBtn = New System.Windows.Forms.PictureBox()
        Me.MoveStepUpBtn = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.MoveStepDownBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoveStepUpBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StepNum, Me.StepType, Me.Item, Me.Description, Me.Target, Me.Column6, Me.Column7, Me.Column1, Me.Instructions, Me.StepID})
        Me.DataGridView1.Location = New System.Drawing.Point(489, 94)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(745, 640)
        Me.DataGridView1.TabIndex = 0
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
        Me.StepType.Width = 90
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
        Me.Description.Width = 150
        '
        'Target
        '
        Me.Target.HeaderText = "Percent"
        Me.Target.Name = "Target"
        Me.Target.ReadOnly = True
        Me.Target.Width = 45
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fixed"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 45
        '
        'Column7
        '
        Me.Column7.HeaderText = "Target"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 45
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
        'DataGridView2
        '
        Me.DataGridView2.AllowDrop = True
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProcDispStepType, Me.ProcInstructions, Me.ProcStepType, Me.ProcTemplateID, Me.Column2})
        Me.DataGridView2.Location = New System.Drawing.Point(23, 94)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(444, 292)
        Me.DataGridView2.TabIndex = 1
        '
        'ProcDispStepType
        '
        Me.ProcDispStepType.HeaderText = "Step Type"
        Me.ProcDispStepType.Name = "ProcDispStepType"
        Me.ProcDispStepType.ReadOnly = True
        '
        'ProcInstructions
        '
        Me.ProcInstructions.HeaderText = "Instructions"
        Me.ProcInstructions.Name = "ProcInstructions"
        Me.ProcInstructions.ReadOnly = True
        Me.ProcInstructions.Width = 300
        '
        'ProcStepType
        '
        Me.ProcStepType.HeaderText = "Step Type"
        Me.ProcStepType.Name = "ProcStepType"
        Me.ProcStepType.ReadOnly = True
        Me.ProcStepType.Visible = False
        '
        'ProcTemplateID
        '
        Me.ProcTemplateID.HeaderText = "Template ID"
        Me.ProcTemplateID.Name = "ProcTemplateID"
        Me.ProcTemplateID.ReadOnly = True
        Me.ProcTemplateID.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Use BOM Item"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowDrop = True
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView3.Location = New System.Drawing.Point(23, 442)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(444, 292)
        Me.DataGridView3.TabIndex = 2
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Staged"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.Width = 40
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Percent"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fixed"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "UOM"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 40
        '
        'Column5
        '
        Me.Column5.HeaderText = "BOM ID"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
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
        Me.RecipeKeyTxtBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Procedures"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "BOM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(485, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Steps"
        '
        'ExitCmdBtn
        '
        Me.ExitCmdBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitCmdBtn.Location = New System.Drawing.Point(876, 768)
        Me.ExitCmdBtn.Name = "ExitCmdBtn"
        Me.ExitCmdBtn.Size = New System.Drawing.Size(150, 41)
        Me.ExitCmdBtn.TabIndex = 9
        Me.ExitCmdBtn.Text = "Exit"
        Me.ExitCmdBtn.UseVisualStyleBackColor = True
        '
        'ActivateBtn
        '
        Me.ActivateBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivateBtn.Location = New System.Drawing.Point(248, 768)
        Me.ActivateBtn.Name = "ActivateBtn"
        Me.ActivateBtn.Size = New System.Drawing.Size(150, 41)
        Me.ActivateBtn.TabIndex = 8
        Me.ActivateBtn.Text = "Activate"
        Me.ActivateBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UnassignedRdoBtn)
        Me.Panel1.Controls.Add(Me.AllRdoBtn)
        Me.Panel1.Location = New System.Drawing.Point(254, 405)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 34)
        Me.Panel1.TabIndex = 11
        '
        'UnassignedRdoBtn
        '
        Me.UnassignedRdoBtn.AutoSize = True
        Me.UnassignedRdoBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnassignedRdoBtn.ForeColor = System.Drawing.Color.White
        Me.UnassignedRdoBtn.Location = New System.Drawing.Point(11, 3)
        Me.UnassignedRdoBtn.Name = "UnassignedRdoBtn"
        Me.UnassignedRdoBtn.Size = New System.Drawing.Size(147, 28)
        Me.UnassignedRdoBtn.TabIndex = 5
        Me.UnassignedRdoBtn.Text = "Unassigned"
        Me.UnassignedRdoBtn.UseVisualStyleBackColor = True
        '
        'AllRdoBtn
        '
        Me.AllRdoBtn.AutoSize = True
        Me.AllRdoBtn.Checked = True
        Me.AllRdoBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllRdoBtn.ForeColor = System.Drawing.Color.White
        Me.AllRdoBtn.Location = New System.Drawing.Point(164, 3)
        Me.AllRdoBtn.Name = "AllRdoBtn"
        Me.AllRdoBtn.Size = New System.Drawing.Size(53, 28)
        Me.AllRdoBtn.TabIndex = 8
        Me.AllRdoBtn.TabStop = True
        Me.AllRdoBtn.Text = "All"
        Me.AllRdoBtn.UseVisualStyleBackColor = True
        '
        'ProcCboBox
        '
        Me.ProcCboBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcCboBox.FormattingEnabled = True
        Me.ProcCboBox.Location = New System.Drawing.Point(78, 411)
        Me.ProcCboBox.Name = "ProcCboBox"
        Me.ProcCboBox.Size = New System.Drawing.Size(161, 27)
        Me.ProcCboBox.TabIndex = 43
        '
        'DeleteRevCmdBtn
        '
        Me.DeleteRevCmdBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteRevCmdBtn.Location = New System.Drawing.Point(562, 768)
        Me.DeleteRevCmdBtn.Name = "DeleteRevCmdBtn"
        Me.DeleteRevCmdBtn.Size = New System.Drawing.Size(150, 41)
        Me.DeleteRevCmdBtn.TabIndex = 44
        Me.DeleteRevCmdBtn.Text = "Delete"
        Me.DeleteRevCmdBtn.UseVisualStyleBackColor = True
        '
        'MoveStepDownBtn
        '
        Me.MoveStepDownBtn.Image = CType(resources.GetObject("MoveStepDownBtn.Image"), System.Drawing.Image)
        Me.MoveStepDownBtn.Location = New System.Drawing.Point(1240, 170)
        Me.MoveStepDownBtn.Name = "MoveStepDownBtn"
        Me.MoveStepDownBtn.Size = New System.Drawing.Size(34, 32)
        Me.MoveStepDownBtn.TabIndex = 48
        Me.MoveStepDownBtn.TabStop = False
        '
        'MoveStepUpBtn
        '
        Me.MoveStepUpBtn.Image = CType(resources.GetObject("MoveStepUpBtn.Image"), System.Drawing.Image)
        Me.MoveStepUpBtn.Location = New System.Drawing.Point(1240, 112)
        Me.MoveStepUpBtn.Name = "MoveStepUpBtn"
        Me.MoveStepUpBtn.Size = New System.Drawing.Size(34, 32)
        Me.MoveStepUpBtn.TabIndex = 47
        Me.MoveStepUpBtn.TabStop = False
        '
        'RecipeEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1274, 821)
        Me.Controls.Add(Me.MoveStepDownBtn)
        Me.Controls.Add(Me.MoveStepUpBtn)
        Me.Controls.Add(Me.DeleteRevCmdBtn)
        Me.Controls.Add(Me.ProcCboBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ExitCmdBtn)
        Me.Controls.Add(Me.ActivateBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RecipeKeyTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RecipeEdit"
        Me.Text = "Work Order Recipe Creation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MoveStepDownBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoveStepUpBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RecipeKeyTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ExitCmdBtn As System.Windows.Forms.Button
    Friend WithEvents ActivateBtn As System.Windows.Forms.Button
    Friend WithEvents ProcDispStepType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcInstructions As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcStepType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcTemplateID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UnassignedRdoBtn As System.Windows.Forms.RadioButton
    Friend WithEvents AllRdoBtn As System.Windows.Forms.RadioButton
    Friend WithEvents ProcCboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DeleteRevCmdBtn As System.Windows.Forms.Button
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
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MoveStepDownBtn As System.Windows.Forms.PictureBox
    Friend WithEvents MoveStepUpBtn As System.Windows.Forms.PictureBox

End Class
