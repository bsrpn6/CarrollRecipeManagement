Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class RecipeEdit

    'Get logged in username
    Public Shared ReadOnly Property UserName As String
        Get
            UserName = Environment.UserName
        End Get
    End Property

    'Manual events to trigger form refresh on child form close
    Private WithEvents ProcEditClose As ProcEdit
    Private WithEvents StepEditClose As StepEdit
    Private WithEvents ChooseBOMClose As ChooseBOM
    Public Event CurrentCellDirtyStateChanged As EventHandler

    'Used to tell parent form this form changed
    Private RecipeChanged As Boolean = False

    'SQL Connection
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    'DragDrop variables for moving items in DataGridViews
    Private fromIndex As Integer
    Private dragIndex As Integer
    Private dragRect As Rectangle

    'Global Recipe Information
    Dim RecipeStepID As Integer
    Dim RecipeKey As String
    Dim RecipeID As Integer
    Dim BatchType As String

    'Used in form selection
    Dim UnassignedBOMOrAll As Boolean = False
    Dim MustSelectBOMItem As Boolean
    Dim MustSelectProc As Boolean

    'Used when selecting items on DataGridViews to assign values to variables
    Dim SelectedProcedureValue As Object
    Dim SelectedProcedureTemplateIDValue As Object
    Dim SelectedUseBOMItemValue As Object
    Dim SelectedProcedure As String
    Dim SelectedProcedureTemplateID As Integer = Nothing
    Dim SelectedBOMValue As Object
    Dim SelectedBOM As String = Nothing
    Dim SelectedRecipeStepIDValue As Object
    Dim SelectedRecipeStepID As Integer
    Dim SelectedRecipeStepItemValue As Object
    Dim SelectedRecipeStepItem As String
    Dim BOMProcTemplateID As Integer

    Dim ErrorMsg As String

    'Form Open
    Public Sub New(ByVal PassedRecipeKey As String, ByVal PassedRecipeID As String)

        InitializeComponent()
        RecipeKey = PassedRecipeKey
        RecipeID = PassedRecipeID

    End Sub

    Private Sub RecipeSteps_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadProcedures()
        LoadBOM()
        LoadSteps()
        LoadProcTypes()

        RecipeKeyTxtBox.Text = RecipeKey
        CenterToScreen()

    End Sub
  
    'Initialization and Refreshes
    Public Sub LoadProcedures()

        DataGridView2.Rows.Clear()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT [StepDispType], [StepInstructions], [StepType], [TemplateID], [UseBOMItem] FROM [BatchDB].[dbo].[mtRecipeStepTemplates]"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim n As Integer

        'Concatenate the query result into a string.
        Do While myReader.Read()
            'Add row to datagrid
            n = DataGridView2.Rows.Add()

            'Populate datagrid with two columns. Third column is hidden.
            DataGridView2.Rows.Item(n).Cells(0).Value = myReader.GetString(0)

            If IsDBNull(myReader.GetValue(1)) Then
                DataGridView2.Rows.Item(n).Cells(1).Value = ""
            Else
                DataGridView2.Rows.Item(n).Cells(1).Value = myReader.GetString(1)
            End If

            If IsDBNull(myReader.GetValue(2)) Then
                DataGridView2.Rows.Item(n).Cells(2).Value = ""
            Else
                DataGridView2.Rows.Item(n).Cells(2).Value = myReader.GetString(2)
            End If

            If IsDBNull(myReader.GetValue(3)) Then
                DataGridView2.Rows.Item(n).Cells(3).Value = ""
            Else
                DataGridView2.Rows.Item(n).Cells(3).Value = myReader.GetSqlInt32(3)
            End If

            If IsDBNull(myReader.GetValue(4)) Then
                DataGridView2.Rows.Item(n).Cells(4).Value = ""
            Else
                DataGridView2.Rows.Item(n).Cells(4).Value = myReader.GetSqlBoolean(4)
            End If

        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        DataGridView2.ClearSelection()

    End Sub

    Private Sub LoadBOM()

        DataGridView3.Rows.Clear()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT [RecipeBOMItem], [RecipeBOMItemDesc], [StageItem], [SumItemQtyPct], [SumItemQtyFixed], [RecipeBOMUOM] FROM [BatchDB].[dbo].[mtRecipeBOM] WHERE [RecipeID] = " & RecipeID & " AND 1=1 "

        If UnassignedBOMOrAll Then
            myCmd.CommandText = myCmd.CommandText & " AND [SumItemQtyPct] <> 100"
        End If

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim n As Integer

        'Concatenate the query result into a string.
        Do While myReader.Read()
            'Add row to datagrid
            n = DataGridView3.Rows.Add()

            'Populate datagrid with two columns.
            DataGridView3.Rows.Item(n).Cells(0).Value = myReader.GetString(0)
            DataGridView3.Rows.Item(n).Cells(1).Value = myReader.GetString(1)
            DataGridView3.Rows.Item(n).Cells(2).Value = myReader.GetBoolean(2)
            DataGridView3.Rows.Item(n).Cells(3).Value = myReader.GetSqlSingle(3)
            DataGridView3.Rows.Item(n).Cells(4).Value = myReader.GetSqlSingle(4)
            DataGridView3.Rows.Item(n).Cells(5).Value = myReader.GetString(5)
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        DataGridView3.ClearSelection()

    End Sub

    Private Sub LoadSteps()

        DataGridView1.Rows.Clear()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT [StepNum], [StepDispType], [StepItem], [StepItemDesc], [ItemQtyPct], [ItemQtyFixed], [ParamTarget], [ParamUOM], [StepInstructions], [RecipeStepID] FROM [BatchDB].[dbo].[mtRecipeSteps] WHERE [RecipeID] = " & RecipeID & " ORDER BY [StepNum] Asc"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim n As Integer

        'Concatenate the query result into a string.
        Do While myReader.Read()
            'Add row to datagrid
            n = DataGridView1.Rows.Add()

            'Populate datagrid with two columns.
            DataGridView1.Rows.Item(n).Cells(0).Value = myReader.GetSqlInt32(0)
            DataGridView1.Rows.Item(n).Cells(1).Value = myReader.GetString(1)
            If IsDBNull(myReader.GetValue(2)) Then
                DataGridView1.Rows.Item(n).Cells(2).Value = ""
            Else
                DataGridView1.Rows.Item(n).Cells(2).Value = myReader.GetString(2)
            End If

            If IsDBNull(myReader.GetValue(3)) Then
                DataGridView1.Rows.Item(n).Cells(3).Value = ""
            Else
                DataGridView1.Rows.Item(n).Cells(3).Value = myReader.GetString(3)
            End If

            If IsDBNull(myReader.GetValue(4)) Then
                DataGridView1.Rows.Item(n).Cells(4).Value = ""
            Else
                DataGridView1.Rows.Item(n).Cells(4).Value = myReader.GetSqlSingle(4)
            End If

            If IsDBNull(myReader.GetValue(5)) Then
                DataGridView1.Rows.Item(n).Cells(5).Value = ""
            Else
                DataGridView1.Rows.Item(n).Cells(5).Value = myReader.GetSqlSingle(5)
            End If

            If IsDBNull(myReader.GetValue(6)) Then
                DataGridView1.Rows.Item(n).Cells(6).Value = ""
            Else
                DataGridView1.Rows.Item(n).Cells(6).Value = myReader.GetSqlSingle(6)
            End If

            If IsDBNull(myReader.GetValue(7)) Then
                DataGridView1.Rows.Item(n).Cells(7).Value = ""
            Else
                DataGridView1.Rows.Item(n).Cells(7).Value = myReader.GetString(7)
            End If

            DataGridView1.Rows.Item(n).Cells(8).Value = myReader.GetString(8)
            DataGridView1.Rows.Item(n).Cells(9).Value = myReader.GetSqlInt32(9)

        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        DataGridView1.ClearSelection()

    End Sub

    Private Sub LoadProcTypes()

        ProcCboBox.Items.Clear()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT [StepType] FROM [BatchDB].[dbo].[mtRecipeStepTemplates] WHERE [UseBOMItem] = 1"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim n As Integer

        'Concatenate the query result into a string.
        Do While myReader.Read()
            'Add row to datagrid
            n = ProcCboBox.Items.Add(myReader.GetString(0))
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

    End Sub

    Private Sub LoadTemplateID()
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT [TemplateID] FROM [BatchDB].[dbo].[mtRecipeStepTemplates] WHERE [StepType] = '" & ProcCboBox.Text & "'"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        'Concatenate the query result into a string.
        Do While myReader.Read()
            'Add row to datagrid
            BOMProcTemplateID = myReader.GetInt32(0)
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()
    End Sub

    'Child Forms - load child forms using appropriate parameters
    Private Sub ChooseBOM(RecipeKey, RecipeID, SelectedProcedureTemplateID)

        ChooseBOMClose = New ChooseBOM(RecipeKey, RecipeID, SelectedProcedureTemplateID)
        ChooseBOMClose.Show()

        AddHandler ChooseBOMClose.FormClosed, AddressOf ChooseBOMClosed

    End Sub

    Private Sub EditRecipeStep(RecipeKey, RecipeID, RecipeStepID)

        StepEditClose = New StepEdit(RecipeKey, RecipeID, SelectedRecipeStepID)
        StepEditClose.Show()

        AddHandler StepEditClose.FormClosed, AddressOf StepEditClosed

    End Sub

    Private Sub EditRecipeProc(RecipeKey, RecipeID, RecipeStepID)

        ProcEditClose = New ProcEdit(RecipeKey, RecipeID, SelectedRecipeStepID)
        ProcEditClose.Show()

        AddHandler ProcEditClose.FormClosed, AddressOf ProcEditClosed

    End Sub

    'Child Form Events - Used to refresh when child form initiates change
    Private Sub StepEditClosed(sender As Object, e As FormClosedEventArgs)

        If StepEditClose.FormHasChanged Then
            LoadSteps()
            UpdateBOM()
            LoadBOM()
        End If

        RemoveHandler StepEditClose.FormClosed, AddressOf StepEditClosed

    End Sub

    Private Sub ProcEditClosed(sender As Object, e As FormClosedEventArgs)

        If ProcEditClose.FormHasChanged Then
            LoadSteps()
            UpdateBOM()
            LoadBOM()
        End If

        RemoveHandler ProcEditClose.FormClosed, AddressOf ProcEditClosed

    End Sub

    Private Sub ChooseBOMClosed(sender As Object, e As FormClosedEventArgs)

        If ChooseBOMClose.FormHasChanged Then
            LoadSteps()
            UpdateBOM()
            LoadBOM()
        End If

        RemoveHandler ChooseBOMClose.FormClosed, AddressOf ChooseBOMClosed

    End Sub

    'SQL Actions - update tables
    Private Sub UpdateBOMStage()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "UPDATE [dbo].[mtRecipeBOM] SET [StageItem] = ~[StageItem] Where [RecipeID] = " & RecipeID & " AND [RecipeBOMItem] = '" & SelectedBOM & "'"

        'Open the connection.
        myConn.Open()

        myCmd.ExecuteNonQuery()

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

    End Sub

    Private Sub UpdateBOM()

        If DatabaseConnection.UpdateBOM(RecipeID) > 0 Then
            RecipeChanged = True
        End If

    End Sub

    Private Sub ActivateRev()
        If DatabaseConnection.ActivateRevision(RecipeID, UserName, 1) > 0 Then
            RecipeChanged = True
            Close()
        End If
    End Sub

    Private Sub DeleteRev()
        If DatabaseConnection.DeleteRevision(RecipeID, 1) > 0 Then
            RecipeChanged = True
            Close()
        End If
    End Sub

    'DataGridView DragDrop Actions - used to drag events from one DGV to another
    Private Sub DataGridView1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles DataGridView1.DragDrop

        Dim p As Point = DataGridView1.PointToClient(New Point(e.X, e.Y))
        dragIndex = DataGridView1.HitTest(p.X, p.Y).RowIndex

        If dragIndex > 0 Then
            RecipeStepID = CType(DataGridView1.Rows(dragIndex).Cells(9).Value.ToString, Integer)
        Else
            RecipeStepID = 0
        End If

        If MustSelectBOMItem Then
            ChooseBOM(RecipeID, RecipeStepID, SelectedProcedureTemplateID)
        ElseIf MustSelectProc Then
            If BOMProcTemplateID > 0 Then
                DatabaseConnection.RecipeStepInsert(RecipeID, RecipeStepID, BOMProcTemplateID, SelectedBOM)
            Else
                MessageBox.Show("Please select a type of procedure from the listbox.", "Error")
            End If
        Else
            DatabaseConnection.RecipeStepInsert(RecipeID, RecipeStepID, SelectedProcedureTemplateID, SelectedBOM)
        End If

        SelectedProcedureTemplateIDValue = Nothing
        SelectedProcedureTemplateID = Nothing
        SelectedBOM = Nothing
        MustSelectBOMItem = Nothing
        MustSelectProc = Nothing

        LoadSteps()
        UpdateBOM()
        LoadBOM()

    End Sub

    Private Sub DataGridView1_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles DataGridView1.DragOver

        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub DataGridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DataGridView1.MouseDown

        fromIndex = DataGridView1.HitTest(e.X, e.Y).RowIndex

        If fromIndex > -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragRect = New Rectangle(New Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize)
        Else
            dragRect = Rectangle.Empty
        End If

    End Sub

    Private Sub DataGridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DataGridView1.MouseMove

        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then

            If (dragRect <> Rectangle.Empty AndAlso Not dragRect.Contains(e.X, e.Y)) Then
                DataGridView1.DoDragDrop(DataGridView1.Rows(fromIndex), DragDropEffects.Move)
            End If

        End If

    End Sub

    Private Sub DataGridView2_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles DataGridView2.DragOver

        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub DataGridView2_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DataGridView2.MouseMove

        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then

            If (dragRect <> Rectangle.Empty AndAlso Not dragRect.Contains(e.X, e.Y)) Then
                DataGridView2.DoDragDrop(DataGridView2.Rows(fromIndex), DragDropEffects.Move)
            End If

        End If

    End Sub

    Private Sub DataGridView2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DataGridView2.MouseDown

        fromIndex = DataGridView2.HitTest(e.X, e.Y).RowIndex

        DataGridView1.ClearSelection()
        DataGridView3.ClearSelection()

        SelectedProcedureValue = DataGridView2.Rows(fromIndex).Cells(0).Value
        SelectedProcedureTemplateIDValue = DataGridView2.Rows(fromIndex).Cells(3).Value
        SelectedUseBOMItemValue = DataGridView2.Rows(fromIndex).Cells(4).Value

        If IsDBNull(SelectedProcedureValue) Then
            SelectedProcedure = "" ' blank if dbnull values
        Else
            SelectedProcedure = CType(SelectedProcedureValue, String)
        End If

        If IsDBNull(SelectedProcedureTemplateIDValue) Then
            SelectedProcedureTemplateID = "" ' blank if dbnull values
        Else
            SelectedProcedureTemplateID = CType(SelectedProcedureTemplateIDValue.ToString, Integer)
        End If

        If IsDBNull(SelectedUseBOMItemValue) Then
            MustSelectBOMItem = "" ' blank if dbnull values
        Else
            MustSelectBOMItem = CType(SelectedUseBOMItemValue.ToString, Boolean)
        End If


        If fromIndex > -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragRect = New Rectangle(New Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize)
        Else
            dragRect = Rectangle.Empty
        End If

    End Sub

    Private Sub DataGridView3_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DataGridView3.MouseDown

        fromIndex = DataGridView3.HitTest(e.X, e.Y).RowIndex

        DataGridView1.ClearSelection()
        DataGridView2.ClearSelection()

        SelectedBOMValue = DataGridView3.Rows(fromIndex).Cells(0).Value

        If IsDBNull(SelectedBOMValue) Then
            SelectedBOM = "" ' blank if dbnull values
        Else
            SelectedBOM = CType(SelectedBOMValue, String)
        End If

        MustSelectProc = True

        If fromIndex > -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragRect = New Rectangle(New Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize)
        Else
            dragRect = Rectangle.Empty
        End If

    End Sub

    Private Sub DataGridView3_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles DataGridView3.DragOver

        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub DataGridView3_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DataGridView3.MouseMove

        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then

            If (dragRect <> Rectangle.Empty AndAlso Not dragRect.Contains(e.X, e.Y)) Then
                DataGridView3.DoDragDrop(DataGridView3.Rows(fromIndex), DragDropEffects.Move)
            End If

        End If

    End Sub

    'DataGridView Focus Events - clicking within one DGV will deselect rows in another
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        DataGridView2.ClearSelection()
        DataGridView3.ClearSelection()
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        DataGridView1.ClearSelection()
        DataGridView3.ClearSelection()
    End Sub

    Private Sub DataGridView3_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        DataGridView1.ClearSelection()
        DataGridView1.ClearSelection()
    End Sub

    'DataGridView1 DoubleClick - opens a form to edit selected procedure or BOM
    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick


        SelectedRecipeStepIDValue = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        SelectedRecipeStepID = CType(SelectedRecipeStepIDValue.ToString, Integer)

        SelectedRecipeStepItemValue = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        SelectedRecipeStepItem = CType(SelectedRecipeStepItemValue.ToString, String)

        If SelectedRecipeStepItem <> Nothing Then
            EditRecipeStep(RecipeKey, RecipeID, SelectedRecipeStepID)
        Else
            EditRecipeProc(RecipeKey, RecipeID, SelectedRecipeStepID)
        End If

    End Sub

    'DataGridView Checkbox Change - updates table when item is marked staged or not
    Sub dataGridView3_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView3.CurrentCellDirtyStateChanged

        If DataGridView3.IsCurrentCellDirty Then
            UpdateBOMStage()
        End If

    End Sub

    'CboBox Changed - shows assigned vs unassigned BOM items
    Private Sub ProcCboBox_TextChanged(sender As Object, e As EventArgs) Handles ProcCboBox.TextChanged

        If ProcCboBox.Text <> Nothing Then
            LoadTemplateID()
        Else
            BOMProcTemplateID = Nothing
        End If

    End Sub

    'Buttons
    Private Sub ActivateBtn_Click(sender As Object, e As EventArgs) Handles ActivateBtn.Click
        ActivateRev()
    End Sub

    Private Sub DeleteRevCmdBtn_Click(sender As Object, e As EventArgs) Handles DeleteRevCmdBtn.Click
        If MessageBox.Show("Are you sure you wish to cancel this revision, deleting all steps?", "Confirm?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            DeleteRev()
        End If
    End Sub

    Private Sub MoveStepUpBtn_Click(sender As Object, e As EventArgs) Handles MoveStepUpBtn.Click

        Dim selectedRowCount As Integer = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
        Dim SelectedRowIndex As Integer = DataGridView1.CurrentRow.Index
        Dim SelectedRecipeStepID As Integer
        Dim SelectedRecipeStepIDAbove As Integer

        If (selectedRowCount > 0) And (SelectedRowIndex > 0) Then

            SelectedRecipeStepID = Convert.ToInt32(DataGridView1.Rows(SelectedRowIndex).Cells(9).Value.ToString)

            SelectedRecipeStepIDAbove = Convert.ToInt32(DataGridView1.Rows(SelectedRowIndex - 1).Cells(9).Value.ToString)
            DatabaseConnection.MoveStep(RecipeID, SelectedRecipeStepID, SelectedRecipeStepIDAbove)

            LoadSteps()

            If SelectedRowIndex > 0 Then
                DataGridView1.CurrentCell = DataGridView1.Rows(SelectedRowIndex - 1).Cells(0)
            End If

        End If

    End Sub

    Private Sub MoveStepDownBtn_Click(sender As Object, e As EventArgs) Handles MoveStepDownBtn.Click

        Dim selectedRowCount As Integer = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
        Dim SelectedRowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim SelectedRecipeStepID As Integer
        Dim SelectedRecipeStepIDBelow As Integer

        If (selectedRowCount > 0) And (SelectedRowIndex < DataGridView1.RowCount - 1) Then

            SelectedRecipeStepID = Convert.ToInt32(DataGridView1.Rows(SelectedRowIndex).Cells(9).Value.ToString)

            SelectedRecipeStepIDBelow = Convert.ToInt32(DataGridView1.Rows(SelectedRowIndex + 1).Cells(9).Value.ToString)
            DatabaseConnection.MoveStep(RecipeID, SelectedRecipeStepIDBelow, SelectedRecipeStepID)

            LoadSteps()

            If SelectedRowIndex + 1 < DataGridView1.RowCount - 1 Then
                DataGridView1.CurrentCell = DataGridView1.Rows(SelectedRowIndex + 1).Cells(0)
            End If

        End If

    End Sub

    Private Sub UnassignedRdoBtn_CheckedChanged(sender As Object, e As EventArgs) Handles UnassignedRdoBtn.CheckedChanged
        If UnassignedRdoBtn.Checked Then
            UnassignedBOMOrAll = True
        ElseIf AllRdoBtn.Checked Then
            UnassignedBOMOrAll = False
        End If

        LoadBOM()
    End Sub

    'Form Close - close form and alert parent of changes
    Private Sub ExitCmdBtn_Click(sender As Object, e As EventArgs) Handles ExitCmdBtn.Click

        Close()

    End Sub

    'Child Form Has Changed
    Public Property RecipeHasChanged() As Boolean

        Get
            Return RecipeChanged
        End Get

        Set(ByVal value As Boolean)
            RecipeChanged = value
        End Set

    End Property


End Class
