<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecipeSelect
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecipeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Revision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Active = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Default_Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecipeKey = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecipeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RecipeItemTxtBox = New System.Windows.Forms.TextBox()
        Me.ActiveRdoBtn = New System.Windows.Forms.RadioButton()
        Me.ViewBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.AllRdoBtn = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ExitApplicationCmdbtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.RecipeName, Me.Revision, Me.Description, Me.Active, Me.Edit, Me.Min, Me.Max, Me.Default_Size, Me.UOM, Me.RecipeKey, Me.RecipeID})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(20, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1235, 640)
        Me.DataGridView1.TabIndex = 0
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.Width = 120
        '
        'RecipeName
        '
        Me.RecipeName.HeaderText = "Recipe Name"
        Me.RecipeName.Name = "RecipeName"
        Me.RecipeName.Width = 125
        '
        'Revision
        '
        Me.Revision.HeaderText = "Revision"
        Me.Revision.Name = "Revision"
        Me.Revision.Width = 80
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Width = 560
        '
        'Active
        '
        Me.Active.HeaderText = "Active"
        Me.Active.Name = "Active"
        Me.Active.Width = 50
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.Width = 50
        '
        'Min
        '
        Me.Min.HeaderText = "Min"
        Me.Min.Name = "Min"
        Me.Min.Width = 65
        '
        'Max
        '
        Me.Max.HeaderText = "Max"
        Me.Max.Name = "Max"
        Me.Max.Width = 65
        '
        'Default_Size
        '
        Me.Default_Size.HeaderText = "Default"
        Me.Default_Size.Name = "Default_Size"
        Me.Default_Size.Width = 65
        '
        'UOM
        '
        Me.UOM.HeaderText = "UOM"
        Me.UOM.Name = "UOM"
        Me.UOM.Width = 50
        '
        'RecipeKey
        '
        Me.RecipeKey.HeaderText = "RecipeKey"
        Me.RecipeKey.Name = "RecipeKey"
        Me.RecipeKey.Visible = False
        '
        'RecipeID
        '
        Me.RecipeID.HeaderText = "RecipeID"
        Me.RecipeID.Name = "RecipeID"
        Me.RecipeID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item Filter"
        '
        'RecipeItemTxtBox
        '
        Me.RecipeItemTxtBox.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeItemTxtBox.Location = New System.Drawing.Point(172, 42)
        Me.RecipeItemTxtBox.Name = "RecipeItemTxtBox"
        Me.RecipeItemTxtBox.Size = New System.Drawing.Size(142, 39)
        Me.RecipeItemTxtBox.TabIndex = 4
        '
        'ActiveRdoBtn
        '
        Me.ActiveRdoBtn.AutoSize = True
        Me.ActiveRdoBtn.Checked = True
        Me.ActiveRdoBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveRdoBtn.ForeColor = System.Drawing.Color.White
        Me.ActiveRdoBtn.Location = New System.Drawing.Point(3, 3)
        Me.ActiveRdoBtn.Name = "ActiveRdoBtn"
        Me.ActiveRdoBtn.Size = New System.Drawing.Size(92, 28)
        Me.ActiveRdoBtn.TabIndex = 5
        Me.ActiveRdoBtn.TabStop = True
        Me.ActiveRdoBtn.Text = "Active"
        Me.ActiveRdoBtn.UseVisualStyleBackColor = True
        '
        'ViewBtn
        '
        Me.ViewBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewBtn.Location = New System.Drawing.Point(248, 768)
        Me.ViewBtn.Name = "ViewBtn"
        Me.ViewBtn.Size = New System.Drawing.Size(150, 41)
        Me.ViewBtn.TabIndex = 6
        Me.ViewBtn.Text = "View Selected"
        Me.ViewBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.Location = New System.Drawing.Point(562, 768)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(150, 41)
        Me.EditBtn.TabIndex = 7
        Me.EditBtn.Text = "Edit Revision"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'AllRdoBtn
        '
        Me.AllRdoBtn.AutoSize = True
        Me.AllRdoBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllRdoBtn.ForeColor = System.Drawing.Color.White
        Me.AllRdoBtn.Location = New System.Drawing.Point(138, 3)
        Me.AllRdoBtn.Name = "AllRdoBtn"
        Me.AllRdoBtn.Size = New System.Drawing.Size(53, 28)
        Me.AllRdoBtn.TabIndex = 8
        Me.AllRdoBtn.Text = "All"
        Me.AllRdoBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ActiveRdoBtn)
        Me.Panel1.Controls.Add(Me.AllRdoBtn)
        Me.Panel1.Location = New System.Drawing.Point(1055, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 34)
        Me.Panel1.TabIndex = 10
        '
        'ExitApplicationCmdbtn
        '
        Me.ExitApplicationCmdbtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitApplicationCmdbtn.Location = New System.Drawing.Point(876, 768)
        Me.ExitApplicationCmdbtn.Name = "ExitApplicationCmdbtn"
        Me.ExitApplicationCmdbtn.Size = New System.Drawing.Size(150, 41)
        Me.ExitApplicationCmdbtn.TabIndex = 11
        Me.ExitApplicationCmdbtn.Text = "Exit Application"
        Me.ExitApplicationCmdbtn.UseVisualStyleBackColor = True
        '
        'RecipeSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1274, 821)
        Me.Controls.Add(Me.ExitApplicationCmdbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.ViewBtn)
        Me.Controls.Add(Me.RecipeItemTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "RecipeSelect"
        Me.Text = "Work Order Recipe Creation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RecipeItemTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ActiveRdoBtn As System.Windows.Forms.RadioButton
    Friend WithEvents ViewBtn As System.Windows.Forms.Button
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents AllRdoBtn As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecipeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Revision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Active As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Edit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Min As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Max As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Default_Size As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecipeKey As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecipeID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExitApplicationCmdbtn As System.Windows.Forms.Button

End Class
