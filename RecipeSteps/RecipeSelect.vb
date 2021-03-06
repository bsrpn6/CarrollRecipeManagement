﻿Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class RecipeSelect

    'Get logged in username
    Public Shared ReadOnly Property UserName As String
        Get
            UserName = Environment.UserName
        End Get
    End Property

    'Manual events to trigger form refresh on child form close
    Private WithEvents RecipeEditClose As RecipeEdit

    'SQL Connection
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    'DataGridView selection variables
    Private fromIndex As Integer
    Private dragIndex As Integer
    Private dragRect As Rectangle

    'Global Recipe Information
    Dim RecipeItem As String
    Dim SelectedRecipe As String
    Dim SelectedRecipeRev As Integer
    Dim SelectedRecipeIsEdit As Boolean
    Dim SelectedRecipeID As Integer

    'Used on form load/refresh to display active or all recipes
    Dim ActiveOrAll As Boolean = True

    'Form Open
    Private Sub RecipeSelect_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadRecipes()
        CenterToScreen()
    End Sub

    Public Sub LoadRecipes()

        DataGridView1.Rows.Clear()
        SelectedRecipe = Nothing
        SelectedRecipeRev = Nothing
        SelectedRecipeIsEdit = Nothing
        SelectedRecipeID = Nothing

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT [RecipeItem] ,[RecipeName] ,[RecipeRev] ,[RecipeHeaderDescr] ,[IsActive], [IsEdit] ,[MinSize] ,[MaxSize] ,[DefaultSize] ,[UOM] ,[RecipeKey], [RecipeID] FROM [BatchDB].[dbo].[mtRecipeHeaders] WHERE 1=1"

        If RecipeItem <> "" Then
            myCmd.CommandText = myCmd.CommandText & " AND [RecipeItem] = '" & RecipeItem & "'"
        End If

        If ActiveOrAll Then
            myCmd.CommandText = myCmd.CommandText & " AND [IsActive] = 'True'"
        End If

        myCmd.CommandText = myCmd.CommandText & "ORDER BY [RecipeKey], [RecipeRev] ASC"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()


        Dim n As Integer

        'Concatenate the query result into a string.
        Do While myReader.Read()
            'Add row to datagrid
            n = DataGridView1.Rows.Add()

            'Populate datagrid with two columns. Third column is hidden.
            DataGridView1.Rows.Item(n).Cells(0).Value = myReader.GetString(0)
            DataGridView1.Rows.Item(n).Cells(1).Value = myReader.GetString(1)
            DataGridView1.Rows.Item(n).Cells(2).Value = myReader.GetInt32(2)
            DataGridView1.Rows.Item(n).Cells(3).Value = myReader.GetString(3)
            DataGridView1.Rows.Item(n).Cells(4).Value = myReader.GetSqlBoolean(4)
            DataGridView1.Rows.Item(n).Cells(5).Value = myReader.GetSqlBoolean(5)
            DataGridView1.Rows.Item(n).Cells(6).Value = myReader.GetSqlSingle(6)
            DataGridView1.Rows.Item(n).Cells(7).Value = myReader.GetSqlSingle(7)
            DataGridView1.Rows.Item(n).Cells(8).Value = myReader.GetSqlSingle(8)
            DataGridView1.Rows.Item(n).Cells(9).Value = myReader.GetString(9)
            DataGridView1.Rows.Item(n).Cells(10).Value = myReader.GetString(10)
            DataGridView1.Rows.Item(n).Cells(11).Value = myReader.GetInt32(11)

        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        DataGridView1.ClearSelection()

    End Sub
    
    'Text box change filter view
    Private Sub RecipeItem_KeyDown(sender As Object, e As KeyEventArgs) Handles RecipeItemTxtBox.KeyDown
        If e.KeyData = Keys.Return Then
            RecipeItem = RecipeItemTxtBox.Text
            LoadRecipes()
        End If
    End Sub

    'DataGridView Item Selection
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim SelectedRecipeValue As Object
        Dim SelectedRecipeRevValue As Object
        Dim SelectedRecipeIsEditValue As Object
        Dim SelectedRecipeIDValue As Object

        SelectedRecipeValue = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        SelectedRecipeRevValue = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        SelectedRecipeIsEditValue = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        SelectedRecipeIDValue = DataGridView1.Rows(e.RowIndex).Cells(11).Value

        If IsDBNull(SelectedRecipeValue) Then
            SelectedRecipe = "" ' blank if dbnull values
        Else
            SelectedRecipe = CType(SelectedRecipeValue, String)
        End If

        If IsDBNull(SelectedRecipeRevValue) Then
            SelectedRecipeRev = "" ' blank if dbnull values
        Else
            SelectedRecipeRev = CType(SelectedRecipeRevValue, Integer)
        End If

        If IsDBNull(SelectedRecipeIsEditValue) Then
            SelectedRecipeIsEdit = "" ' blank if dbnull values
        Else
            SelectedRecipeIsEdit = CType(SelectedRecipeIsEditValue.ToString, Boolean)
        End If

        If IsDBNull(SelectedRecipeIDValue) Then
            SelectedRecipeID = "" ' blank if dbnull values
        Else
            SelectedRecipeID = CType(SelectedRecipeIDValue, Integer)
        End If
    End Sub

    'Buttons
    Private Sub ActiveRdoBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ActiveRdoBtn.CheckedChanged
        If ActiveRdoBtn.Checked Then
            ActiveOrAll = True
        ElseIf AllRdoBtn.Checked Then
            ActiveOrAll = False
        End If

        LoadRecipes()
    End Sub

    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewBtn.Click

        If SelectedRecipeID > 0 Then
            Dim oForm As ViewRecipeKey
            oForm = New ViewRecipeKey(SelectedRecipe, SelectedRecipeID, SelectedRecipeRev)
            oForm.Show()
            oForm = Nothing
        Else
            MessageBox.Show("Please make a selection.")
        End If

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click

        If SelectedRecipeID > 0 Then
            If Not SelectedRecipeIsEdit Then
                CreateNewRevision()
            Else
                RecipeEditClose = New RecipeEdit(SelectedRecipe, SelectedRecipeID)
                RecipeEditClose.Show()

                AddHandler RecipeEditClose.FormClosed, AddressOf RecipeEditClosed
            End If
        Else
            MessageBox.Show("Please make a selection.")
        End If

    End Sub

    'Helper methods
    Public Sub CreateNewRevision()

        Dim ReturnValue As Integer
        ReturnValue = DatabaseConnection.CreateNewRevision(SelectedRecipeID, UserName)


        If ReturnValue > 0 Then
            SelectedRecipeID = ReturnValue

            RecipeEditClose = New RecipeEdit(SelectedRecipe, SelectedRecipeID)
            RecipeEditClose.Show()

            AddHandler RecipeEditClose.FormClosed, AddressOf RecipeEditClosed

            LoadRecipes()
        End If

    End Sub

    'Form Close
    Private Sub ExitApplicationCmdbtn_Click(sender As Object, e As EventArgs) Handles ExitCmdbtn.Click
        Close()
    End Sub
    
    'Chid Form Has Changed
    Private Sub RecipeEditClosed(sender As Object, e As FormClosedEventArgs)

        If RecipeEditClose.RecipeHasChanged Then
            LoadRecipes()
        End If

        RemoveHandler RecipeEditClose.FormClosed, AddressOf RecipeEditClosed

    End Sub
End Class
