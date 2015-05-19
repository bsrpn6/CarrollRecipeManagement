
Imports System.Data.SqlClient

Public Class DatabaseConnection

    Public Shared Function CreateSQLConnection() As SqlConnection

        Dim ConnectionString As String
        ConnectionString = "Data Source=CarrollDev;Initial Catalog=BatchDB;User ID=wwAdmin;Password=wwAdmin"
        Return New SqlConnection(ConnectionString)

    End Function

    Public Shared Function CreateSQLDependency(myCmd As SqlCommand) As SqlDependency
        Dim ConnectionString As String
        ConnectionString = "Data Source=CarrollDev;Initial Catalog=BatchDB;User ID=wwAdmin;Password=wwAdmin"
        Return New SqlDependency(myCmd)

    End Function

    Public Shared Function ReturnConnectionString() As String
        Dim ConnectionString As String
        ConnectionString = "Data Source=CarrollDev;Initial Catalog=BatchDB;User ID=wwAdmin;Password=wwAdmin"
        Return ConnectionString
    End Function

    Public Shared Function CreateNewRevision(ByVal RecipeID As String, ByVal UserName As String) As Integer

        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "edtRecipeNewRev"
        myCmd.CommandType = CommandType.StoredProcedure

        '' @RecipeID int,
        '' @CreateBy varchar(64),
        '' @OverrideLevel int,
        '' @ErrorMsg varchar(40) OUTPUT

        myCmd.Parameters.AddWithValue("RecipeID", RecipeID)
        myCmd.Parameters.AddWithValue("CreateBy", UserName)
        myCmd.Parameters.AddWithValue("OverrideLevel", 1)
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
        End If

        myConn.Close()

        Return ReturnValue.Value
    End Function

    Public Shared Function DeleteRevision(ByVal RecipeID As Integer, ByVal OverrideLevel As Integer) As Integer

        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "edtRecipeDeleteRev"
        myCmd.CommandType = CommandType.StoredProcedure

        ''@RecipeID int,
        ''@OverrideLevel int,
        ''@ErrorMsg varchar(40) OUTPUT

        myCmd.Parameters.AddWithValue("RecipeID", RecipeID)
        myCmd.Parameters.AddWithValue("OverrideLevel", OverrideLevel)
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
        End If

        myConn.Close()

        Return ReturnValue.Value
    End Function

    Public Shared Function ActivateRevision(ByVal RecipeID As Integer, ByVal Username As String, ByVal OverrideLevel As Integer) As Integer

        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "edtRecipeActivate"
        myCmd.CommandType = CommandType.StoredProcedure

        ''@RecipeID int,
        ''@OverrideLevel int,
        ''@ErrorMsg varchar(40) OUTPUT

        myCmd.Parameters.AddWithValue("RecipeID", RecipeID)
        myCmd.Parameters.AddWithValue("ApproveBy", UserName)
        myCmd.Parameters.AddWithValue("OverrideLevel", OverrideLevel)
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
        End If

        myConn.Close()

        Return ReturnValue.Value
    End Function

    Public Shared Function MoveStep(ByVal RecipeID As String, ByVal RecipeStepID As Integer, ByVal RecipeStepIDAbove As Integer) As Integer

        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "edtRecipeStepMove"
        myCmd.CommandType = CommandType.StoredProcedure

        ''@RecipeID int,
        ''@RecipeStepID int,
        ''@RecipeStepIDAbove int,
        ''@ErrorMsg varchar(40) OUTPUT

        myCmd.Parameters.AddWithValue("RecipeID", RecipeID)
        myCmd.Parameters.AddWithValue("RecipeStepID", RecipeStepID)
        myCmd.Parameters.AddWithValue("RecipeStepIDAbove", RecipeStepIDAbove)
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
        End If

        myConn.Close()

        Return ReturnValue.Value
    End Function

    Public Shared Function RecipeStepInsert(ByVal RecipeID As Integer, ByVal RecipeStepID As Integer, ByVal TempalteID As Integer, ByVal RecipeBomItem As String) As Integer

        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand

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

        myCmd.ExecuteReader()

        If ReturnValue.Value < 0 Then
            MessageBox.Show("Error # (" & ReturnValue.Value.ToString & "): " & ErrorMsg.Value.ToString)
        End If

        'Close the reader and the database connection.
        myConn.Close()

        Return ReturnValue.Value

    End Function

    Public Shared Function UpdateBOM(ByVal RecipeID As String) As Integer
        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "edtUpdateBOM"
        myCmd.CommandType = CommandType.StoredProcedure

        ''@RecipeID int,
        ''@ErrorMsg varchar(40) OUTPUT

        myCmd.Parameters.AddWithValue("RecipeID", RecipeID)
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
        End If

        myConn.Close()

        Return ReturnValue.Value

    End Function

    Public Shared Function DeleteStep(ByVal RecipeID As Integer, ByVal RecipeStepID As Integer) As Integer
        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand

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
        End If

        myConn.Close()

        Return ReturnValue.Value
    End Function

End Class
