Option Strict Off
Option Explicit On
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class Main

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

    'Global Recipe Information

    'Form Open
    Private Sub RecipeSelect_Load(sender As Object, e As EventArgs) Handles Me.Load
        CenterToScreen()
    End Sub


    'Form Close
    Private Sub ExitApplicationCmdbtn_Click(sender As Object, e As EventArgs) Handles ExitApplicationCmdbtn.Click
        Application.Exit()
    End Sub

    Private Sub EditRecipesCmdBtn_Click(sender As Object, e As EventArgs) Handles EditRecipesCmdBtn.Click
        Dim oForm As RecipeSelect
        oForm = New RecipeSelect()
        oForm.Show()
        oForm = Nothing
    End Sub
End Class
