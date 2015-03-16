Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class ChooseBOM

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Dim RecipeID As Integer
    Dim RecipeStepID As Integer
    Dim RecipeTemplateID As Integer
    Dim RecipeBOMItem As String
    Dim RecipeBOMItemDesc As String
    Dim RecipeBOMUOM As String
    Dim RecipeBOMQty As Integer
    Dim SumItemQtyPct As Integer
    Dim SumItemQtyFixed As Integer

    Dim FormChanged As Boolean = False

    Public Sub New(ByVal PassedRecipeID As String, ByVal PassedRecipeStepID As String, ByVal PassedRecipeTemplateID As Integer)

        InitializeComponent()
        RecipeID = PassedRecipeID
        RecipeStepID = PassedRecipeStepID
        RecipeTemplateID = PassedRecipeTemplateID

    End Sub

    Private Sub StepEdit_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadBOM()
        FormChanged = False
        CenterToScreen()

    End Sub

    Public Property FormHasChanged() As Boolean

        Get
            Return FormChanged
        End Get

        Set(ByVal value As Boolean)
            FormChanged = value
        End Set

    End Property

    Private Sub LoadBOM()

        BOMItemCboBox.Items.Clear()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT [RecipeBOMItem] FROM [BatchDB].[dbo].[mtRecipeBOM] WHERE [RecipeID] = " & RecipeID

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim n As Integer

        'Concatenate the query result into a string.
        Do While myReader.Read()
            'Add row to datagrid
            n = BOMItemCboBox.Items.Add(myReader.GetString(0))
        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

    End Sub

    Private Sub LoadStep()

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT [RecipeBOMItemDesc], [RecipeBOMUOM], [RecipeBOMQty], [SumItemQtyPct], [SumItemQtyFixed] FROM [BatchDB].[dbo].[mtRecipeBOM] WHERE [RecipeID] = " & RecipeID & " AND RecipeBOMItem = '" & RecipeBOMItem & "'"

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        'Concatenate the query result into a string.
        Do While myReader.Read()

            RecipeBOMItemDesc = myReader.GetString(0)
            RecipeBOMUOM = myReader.GetString(1)
            RecipeBOMQty = myReader.GetSqlSingle(2)
            SumItemQtyPct = myReader.GetSqlSingle(3)
            SumItemQtyFixed = myReader.GetSqlSingle(4)

        Loop

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

        RecipeBOMItemDescTxtBox.Text = RecipeBOMItemDesc
        BOMQtyUOMTxtBox.Text = RecipeBOMUOM
        ItemQtyPctTxtBox.Text = SumItemQtyPct
        ItemQtyFixedTxtBox.Text = SumItemQtyFixed
        BOMQtyTxtBox.Text = RecipeBOMQty

    End Sub

    Private Sub RecipeStepInsert(ByVal RecipeID As Integer, ByVal RecipeStepID As Integer, ByVal TempalteID As Integer, ByVal RecipeBomItem As String)

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "edtRecipeStepInsert"
        myCmd.CommandType = CommandType.StoredProcedure


        ''@RecipeID int,
        ''@RecipeStepID int,
        ''@TemplateID int,
        ''@RecipeBOMItem varchar(16),
        ''@ErrorMsg varchar(40) OUTPUT

        myCmd.Parameters.AddWithValue("RecipeID", RecipeID)
        myCmd.Parameters.AddWithValue("RecipeStepID", RecipeStepID)

        If TempalteID = Nothing Then
            myCmd.Parameters.AddWithValue("TemplateID", DBNull.Value)
        Else
            myCmd.Parameters.AddWithValue("TemplateID", TempalteID)
        End If

        If RecipeBomItem = Nothing Then
            myCmd.Parameters.AddWithValue("RecipeBOMItem", DBNull.Value)
        Else
            myCmd.Parameters.AddWithValue("RecipeBOMItem", RecipeBomItem)
        End If

        'myCmd.Parameters.AddWithValue("ErrorMsg", "NULL")
        Dim ErrorMsg As SqlParameter = myCmd.Parameters.Add("ErrorMsg", SqlDbType.VarChar)
        ErrorMsg.Direction = ParameterDirection.Output
        ErrorMsg.Size = 40


        Dim ReturnValue As SqlParameter = myCmd.Parameters.Add("ReturnVal", SqlDbType.Int)
        ReturnValue.Direction = ParameterDirection.ReturnValue

        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        If ReturnValue.Value < 0 Then
            MessageBox.Show("Error # (" & ReturnValue.Value.ToString & "): " & ErrorMsg.Value.ToString)
            Return
        End If

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

    End Sub

    Private Sub ExitCmdBtn_Click(sender As Object, e As EventArgs) Handles ExitCmdBtn.Click

        If FormChanged Then

            If MessageBox.Show("Changes have been made. Do you wish to save?", "Save?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                RecipeStepInsert(RecipeID, RecipeStepID, RecipeTemplateID, RecipeBOMItem)
            End If

        End If

        Close()

    End Sub

    Private Sub SaveCmdBtn_Click(sender As Object, e As EventArgs) Handles SaveCmdBtn.Click

        If FormChanged Then

            If MessageBox.Show("Are you sure you want to save these changes?", "Save?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                RecipeStepInsert(RecipeID, RecipeStepID, RecipeTemplateID, RecipeBOMItem)
            End If

        End If

        Close()

    End Sub

    Private Sub BOMItemCboBox_TextChanged(sender As Object, e As EventArgs) Handles BOMItemCboBox.TextChanged

        RecipeBOMItem = BOMItemCboBox.Text
        LoadStep()
        FormChanged = True

    End Sub

End Class