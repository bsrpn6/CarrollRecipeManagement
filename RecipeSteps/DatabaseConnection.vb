
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
            Return Nothing
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

End Class
