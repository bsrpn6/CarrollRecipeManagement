Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class ProcEdit

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
    Dim ParamTarget As Integer
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

    'Initialize
    Private Sub LoadStep()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT [StepNum], [StepType], [StepDispType], [StepInstructions], [ParamTarget], [ParamUOM] FROM [BatchDB].[dbo].[mtRecipeSteps] WHERE [RecipeStepID] = " & RecipeStepID

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
                ParamTarget = Nothing
            Else
                ParamTarget = myReader.GetSqlSingle(4)
            End If

            If IsDBNull(myReader.GetValue(5)) Then
                ParamUOM = Nothing
            Else
                ParamUOM = myReader.GetString(5)
            End If

        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        RecipeStepIDTxtBox.Text = RecipeKey & " - " & StepNum
        StepTypeTxtBox.Text = StepType
        StepInstructionsTxtBox.Text = StepInstructions
        ParamTargetTxtBox.Text = ParamTarget
        ParamUOMTxtBox.Text = ParamUOM

    End Sub


    'Helper methods
    Private Sub UpdateRow()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "UPDATE [dbo].[mtRecipeSteps] SET [StepInstructions] = '" & StepInstructionsTxtBox.Text & "', [ParamTarget] = '" & ParamTargetTxtBox.Text & "' WHERE [RecipeStepID] = " & RecipeStepID

        'Open the connection.
        myConn.Open()

        myCmd.ExecuteNonQuery()

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

    End Sub

    Private Sub DeleteStep()
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "edtRecipeStepDelete"
        myCmd.CommandType = CommandType.StoredProcedure

        '' @RecipeID int,
        '' @RecipeStepID int,
        '' @ErrorMsg varchar(40) OUTPUT

        myCmd.Parameters.AddWithValue("RecipeID", RecipeID)
        myCmd.Parameters.AddWithValue("RecipeStepID", RecipeStepID)
        'myCmd.Parameters.AddWithValue("ErrorMsg", "NULL")
        Dim ErrorMsg As SqlParameter = myCmd.Parameters.Add("ErrorMsg", SqlDbType.VarChar)
        ErrorMsg.Direction = ParameterDirection.Output
        ErrorMsg.Size = 40

        Dim ReturnValue As SqlParameter = myCmd.Parameters.Add("ReturnVal", SqlDbType.Int)
        ReturnValue.Direction = ParameterDirection.ReturnValue

        'Open the connection.
        myConn.Open()

        myCmd.ExecuteReader()
        'myReader = myCmd.ExecuteReader()

        If ReturnValue.Value < 0 Then
            MessageBox.Show("Error # (" & ReturnValue.Value.ToString & "): " & ErrorMsg.Value.ToString)
            Return
        End If

        myConn.Close()

        FormChanged = True

        Close()
    End Sub

    'Text changed - validate and alert user
    Private Sub ParamTargetTxtBox_Leave(sender As Object, e As EventArgs) Handles ParamTargetTxtBox.Leave

        If Not IsNumeric(ParamTargetTxtBox.Text) Then
            MessageBox.Show("Value must numeric")
        End If

    End Sub

    Private Sub ParamTargetTxtBox_TextChanged(sender As Object, e As EventArgs) Handles ParamTargetTxtBox.TextChanged

        FormChanged = True

    End Sub

    Private Sub StepInstructionsTxtBox_TextChanged(sender As Object, e As EventArgs) Handles StepInstructionsTxtBox.TextChanged

        FormChanged = True

    End Sub

    
    'Buttons
    Private Sub DeleteCmdBtn_Click(sender As Object, e As EventArgs) Handles DeleteCmdBtn.Click
        DeleteStep()
    End Sub

    Private Sub SaveCmdBtn_Click(sender As Object, e As EventArgs) Handles SaveCmdBtn.Click

        If FormChanged Then
            If MessageBox.Show("Are you sure you want to save these changes?", "Save?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                UpdateRow()
            End If
        End If

        Close()

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