Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class StepEdit

    'SQL Connection
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    'Form Variables
    Dim RecipeKey As String
    Dim RecipeID As Integer
    Dim RecipeStepID As Integer
    Dim StepNum As Integer
    Dim StepType As String
    Dim StepDispType As String
    Dim StepInstructions As String
    Dim StepItem As String
    Dim StepItemDesc As String
    Dim ItemQtyPct As Integer
    Dim ItemQtyFixed As Integer
    Dim ParamTarget As Integer
    Dim ParamHiDev As Integer
    Dim ParamHiHiDev As Integer
    Dim ParamLoDev As Integer
    Dim ParamLoLoDev As Integer
    Dim ParamUOM As String

    'Used to tell parent form item has changed and alert user if changes need saved
    Dim FormChanged As Boolean = False

    'Open Form
    Public Sub New(ByVal PassedRecipeKey As String, ByVal PassedRecipeID As String, ByVal PassedRecipeStepID As Integer)

        InitializeComponent()
        RecipeKey = PassedRecipeKey
        RecipeID = PassedRecipeID
        RecipeStepID = PassedRecipeStepID

    End Sub

    Private Sub StepEdit_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadStep()
        FormChanged = False
        CenterToScreen()

    End Sub

    'Initialize Form
    Private Sub LoadStep()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT [StepNum], [StepType], [StepDispType], [StepInstructions], [StepItem], [StepItemDesc], [ItemQtyPct], [ItemQtyFixed], [ParamTarget], [ParamHiDev], [ParamHiHiDev], [ParamLoDev], [ParamLoLoDev], [ParamUOM] FROM [BatchDB].[dbo].[mtRecipeSteps] WHERE [RecipeStepID] = " & RecipeStepID

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        'Concatenate the query result into a string.
        Do While myReader.Read()

            StepNum = myReader.GetInt32(0)
            StepType = myReader.GetString(1)
            StepDispType = myReader.GetString(2)
            StepInstructions = myReader.GetString(3)

            If IsDBNull(myReader.GetValue(4)) Then
                StepItem = Nothing
            Else
                StepItem = myReader.GetString(4)
            End If

            If IsDBNull(myReader.GetValue(5)) Then
                StepItemDesc = Nothing
            Else
                StepItemDesc = myReader.GetString(5)
            End If

            If IsDBNull(myReader.GetValue(6)) Then
                ItemQtyPct = Nothing
            Else
                ItemQtyPct = myReader.GetSqlSingle(6)
            End If

            If IsDBNull(myReader.GetValue(7)) Then
                ItemQtyFixed = Nothing
            Else
                ItemQtyFixed = myReader.GetSqlSingle(7)
            End If

            If IsDBNull(myReader.GetValue(8)) Then
                ParamTarget = Nothing
            Else
                ParamTarget = myReader.GetSqlSingle(8)
            End If

            If IsDBNull(myReader.GetValue(9)) Then
                ParamHiDev = Nothing
            Else
                ParamHiDev = myReader.GetSqlSingle(9)
            End If

            If IsDBNull(myReader.GetValue(10)) Then
                ParamHiHiDev = Nothing
            Else
                ParamHiHiDev = myReader.GetSqlSingle(10)
            End If

            If IsDBNull(myReader.GetValue(11)) Then
                ParamLoDev = Nothing
            Else
                ParamLoDev = myReader.GetSqlSingle(11)
            End If

            If IsDBNull(myReader.GetValue(12)) Then
                ParamLoLoDev = Nothing
            Else
                ParamLoLoDev = myReader.GetSqlSingle(12)
            End If

            If IsDBNull(myReader.GetValue(13)) Then
                ParamUOM = Nothing
            Else
                ParamUOM = myReader.GetString(13)
            End If

        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        RecipeStepIDTxtBox.Text = RecipeKey & " - " & StepNum
        StepTypeTxtBox.Text = StepType
        StepInstructionsTxtBox.Text = StepInstructions
        StepItemTxtBox.Text = StepItem
        StepItemDescTxtBox.Text = StepItemDesc
        ItemQtyPctTxtBox.Text = ItemQtyPct
        ItemQtyFixedTxtBox.Text = ItemQtyFixed
        ParamTargetTxtBox.Text = ParamTarget
        ParamUOMTxtBox.Text = ParamUOM

    End Sub

    'Text has changed - validate and alert
    Private Sub ItemQtyPctTxtBox_Leave(sender As Object, e As EventArgs) Handles ItemQtyPctTxtBox.Leave

        If ((ItemQtyFixedTxtBox.Text < 0) Or (ItemQtyFixedTxtBox.Text > 100)) Then
            MessageBox.Show("Value must be between '0' and '100'")
        End If

    End Sub

    Private Sub ItemQtyPctTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemQtyPctTxtBox.TextChanged

        FormChanged = True

    End Sub

    Private Sub ItemQtyFixedTxtBox_Leave(sender As Object, e As EventArgs) Handles ItemQtyFixedTxtBox.Leave

        If Not IsNumeric(ItemQtyFixedTxtBox.Text) Then
            MessageBox.Show("Value must numeric")
        End If

    End Sub

    Private Sub ItemQtyFixedTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ItemQtyFixedTxtBox.TextChanged

        FormChanged = True
    End Sub

    Private Sub ParamTargetTxtBox_Leave(sender As Object, e As EventArgs) Handles ParamTargetTxtBox.Leave

        If Not IsNumeric(ParamTargetTxtBox.Text) Then
            MessageBox.Show("Value must numeric")
        End If

    End Sub

    Private Sub StepInstructionsTxtBox_TextChanged(sender As Object, e As EventArgs) Handles StepInstructionsTxtBox.TextChanged

        FormChanged = True

    End Sub

    'Helper Methods
    Private Sub DeleteStep()

        If DatabaseConnection.DeleteStep(RecipeID, RecipeStepID) > 0 Then
            FormChanged = True
            Close()
        End If

    End Sub

    Private Sub UpdateRow()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "UPDATE [dbo].[mtRecipeSteps] SET [StepInstructions] = '" & StepInstructionsTxtBox.Text & "', [ItemQtyPct] = '" & ItemQtyPctTxtBox.Text & "', [ItemQtyFixed] = '" & ItemQtyFixedTxtBox.Text & "', [ParamTarget] = '" & ParamTargetTxtBox.Text & "' WHERE [RecipeStepID] = " & RecipeStepID

        'Open the connection.
        myConn.Open()

        myCmd.ExecuteNonQuery()

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

    End Sub

    'Buttons
    Private Sub SaveCmdBtn_Click(sender As Object, e As EventArgs) Handles SaveCmdBtn.Click

        If FormChanged Then
            If MessageBox.Show("Are you sure you want to save these changes?", "Save?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                UpdateRow()
            End If
        End If

        Close()

    End Sub

    Private Sub DeleteCmdBtn_Click(sender As Object, e As EventArgs) Handles DeleteCmdBtn.Click

        DeleteStep()

    End Sub

    'Close Form
    Private Sub ExitCmdBtn_Click(sender As Object, e As EventArgs) Handles ExitCmdBtn.Click

        If FormChanged Then
            If MessageBox.Show("Changes have been made. Do you wish to save?", "Save?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                UpdateRow()
            End If
        Else
            FormChanged = False
        End If

        Close()

    End Sub

    Public Property FormHasChanged() As Boolean

        Get
            Return FormChanged
        End Get

        Set(ByVal value As Boolean)
            FormChanged = value
        End Set

    End Property

End Class