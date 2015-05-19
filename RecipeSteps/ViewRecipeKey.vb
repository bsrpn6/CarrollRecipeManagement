Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class ViewRecipeKey

    'Get logged in username
    Public Shared ReadOnly Property UserName As String
        Get
            UserName = Environment.UserName
        End Get
    End Property

    'SQL Connection
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    'Global Recipe Information
    Dim RecipeKey As String
    Dim RecipeID As Integer
    Dim RecipeRev As Integer

    'Form Variables
    Dim RecipeItem As String
    Dim RecipeName As String
    Dim RecipeHeaderDescr As String
    Dim RecipeState As String
    Dim IsActive As Boolean
    Dim IsEdit As Boolean
    Dim MinSize As Integer
    Dim MaxSize As Integer
    Dim RecipeDefaultSize As Integer
    Dim UOM As String
    Dim RevCreateDate As Date
    Dim RevApproveDate As Date
    Dim RevCreateBy As String
    Dim RevApproveBy As String

    'Form Open
    Public Sub New(ByVal PassedRecipeKey As String, ByVal PassedRecipeID As String, ByVal PassedRecipeRev As Integer)
        InitializeComponent()
        RecipeKey = PassedRecipeKey
        RecipeID = PassedRecipeID
        RecipeRev = PassedRecipeRev
    End Sub

    Private Sub ViewRecipe_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadRecipe()
        LoadSteps()
        CenterToScreen()
    End Sub

    'Initialization
    Public Sub LoadRecipe()


        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT [RecipeItem], [RecipeName], [RecipeRev], [RecipeHeaderDescr], [RecipeState], [IsActive], [IsEdit], [MinSize], [MaxSize], [DefaultSize], [UOM], [RevCreateDate], [RevApproveDate], [RevCreateBy], [RevApproveBy] FROM [BatchDB].[dbo].[mtRecipeHeaders] WHERE [RecipeID] = " & RecipeID


        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        'Concatenate the query result into a string.
        Do While myReader.Read()
            RecipeItem = myReader.GetString(0)
            RecipeName = myReader.GetString(1)
            RecipeRev = myReader.GetInt32(2)
            RecipeHeaderDescr = myReader.GetString(3)

            If IsDBNull(myReader.GetValue(4)) Then
                RecipeState = ""
            Else
                RecipeState = myReader.GetString(4)
            End If

            IsActive = myReader.GetBoolean(5)
            IsEdit = myReader.GetBoolean(6)
            MinSize = myReader.GetSqlSingle(7)
            MaxSize = myReader.GetSqlSingle(8)
            RecipeDefaultSize = myReader.GetSqlSingle(9)
            UOM = myReader.GetString(10)

            If IsDBNull(myReader.GetValue(11)) Then
                RevCreateDate = ""
            Else
                RevCreateDate = myReader.GetDateTime(11)
            End If

            If IsDBNull(myReader.GetValue(12)) Then
                RevApproveDate = Nothing
            Else
                RevApproveDate = myReader.GetDateTime(12)
            End If

            If IsDBNull(myReader.GetValue(13)) Then
                RevCreateBy = Nothing
            Else
                RevCreateBy = myReader.GetString(13)
            End If

            If IsDBNull(myReader.GetValue(14)) Then
                RevApproveBy = Nothing
            Else
                RevApproveBy = myReader.GetString(14)
            End If

        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        RecipeKeyTxtBox.Text = RecipeKey & " - " & RecipeRev
        RecipeNameTxtBox.Text = RecipeName
        RecipeHeaderDescrTxtBox.Text = RecipeHeaderDescr
        RecipeStateTxtBox.Text = RecipeState
        IsActiveTxtBox.Text = IsActive
        IsEditTxtBox.Text = IsEdit
        DefaultSizeTxtBox.Text = RecipeDefaultSize & " " & UOM
        RevCreateDateTxtBox.Text = RevCreateDate
        RevApproveDateTxtBox.Text = RevApproveDate
        RevCreateByTxtBox.Text = RevCreateBy
        RevApproveByTxtBox.Text = RevApproveBy

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

    'Buttons
    Private Sub EditRecipeBtn_Click(sender As Object, e As EventArgs) Handles EditRecipeCmdBtn.Click

        If Not IsEdit Then
            CreateNewRevision()
        Else
            Dim oForm As Form
            oForm = New RecipeEdit(RecipeKey, RecipeID)
            oForm.Show()
            oForm = Nothing

        End If

    End Sub

    'Helper method
    Public Sub CreateNewRevision()

        If DatabaseConnection.CreateNewRevision(RecipeID, UserName) > 0 Then
            Close()
        End If

    End Sub

    'Close form
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Close()
    End Sub
End Class
