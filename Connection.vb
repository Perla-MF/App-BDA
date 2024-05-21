Imports System.Data.SqlClient

Public Class Connection
    Shared cnx As New SqlConnection
    Public cmd As SqlClient.SqlCommand
    Public sqlread As SqlClient.SqlDataReader
    Public Query As String
    Private Shared Sub Connect()
        Try
            cnx.ConnectionString = "Data Source=localhost\SQLEXPRESS; Initial Catalog=Goodreads;Integrated Security=True"
            cnx.Open()
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos: " & ex.Message)
        End Try
    End Sub
    Private Shared Sub Disconect()
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al desconectar de la base de datos: " & ex.Message)
        End Try
    End Sub

    Public Shared Function SelectQuery(ByVal query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As DataTable
        Dim dt As New DataTable
        Try
            Connect()
            Dim cmd As New SqlCommand(query, cnx)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta: " & ex.Message)
        Finally
            Disconect()
        End Try
        Return dt
    End Function

    Public Shared Sub InsertBookWithRating(ByVal name As String, ByVal pagesNumber As Integer, ByVal publishMonth As Integer, ByVal publishDay As Integer, ByVal publishYear As Integer, ByVal publisher As String, ByVal isbn As String, ByVal language As String, ByVal rating As Double, ByVal countsOfReview As Integer, ByVal authorId As String, ByVal idUserCrea As Integer, ByVal fechaCrea As Date, ByVal ratingD1 As String, ByVal ratingD2 As String, ByVal ratingD3 As String, ByVal ratingD4 As String, ByVal ratingD5 As String, ByVal ratingDTotal As String)
        Try
            Connect()
            Dim cmd As New SqlCommand("SP_InsertBookWithRating", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Name", name)
            cmd.Parameters.AddWithValue("@pagesNumber", pagesNumber)
            cmd.Parameters.AddWithValue("@publishMonth", publishMonth)
            cmd.Parameters.AddWithValue("@publishDay", publishDay)
            cmd.Parameters.AddWithValue("@publishYear", publishYear)
            cmd.Parameters.AddWithValue("@publisher", publisher)
            cmd.Parameters.AddWithValue("@ISBN", isbn)
            cmd.Parameters.AddWithValue("@Language", language)
            cmd.Parameters.AddWithValue("@Rating", rating)
            cmd.Parameters.AddWithValue("@countsOfReview", countsOfReview)
            cmd.Parameters.AddWithValue("@AuthorName", authorId)
            cmd.Parameters.AddWithValue("@fechaCrea", fechaCrea)
            cmd.Parameters.AddWithValue("@RatingD1", ratingD1)
            cmd.Parameters.AddWithValue("@RatingD2", ratingD2)
            cmd.Parameters.AddWithValue("@RatingD3", ratingD3)
            cmd.Parameters.AddWithValue("@RatingD4", ratingD4)
            cmd.Parameters.AddWithValue("@RatingD5", ratingD5)
            cmd.Parameters.AddWithValue("@RatingDTotal", ratingDTotal)

            cmd.ExecuteNonQuery()

            MsgBox("Libro insertado con éxito")
        Catch ex As Exception
            MsgBox("Error al insertar el libro: " & ex.Message)
        Finally
            Disconect()
        End Try
    End Sub

    Public Shared Sub InsertAuthor(ByVal nameAuthor As String, ByVal idUsuarioCrea As String, ByVal fechaCrea As Date)
        Try
            Connect()
            Dim cmd As New SqlCommand("SP_InsertAuthor", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Name", nameAuthor)
            cmd.Parameters.AddWithValue("@idUserCrea", idUsuarioCrea)
            cmd.Parameters.AddWithValue("@fechaCrea", fechaCrea)

            cmd.ExecuteNonQuery()

            MsgBox("Autor insertado con éxito")
        Catch ex As Exception
            MsgBox("Error al insertar el autor " & ex.Message)
        Finally
            Disconect()
        End Try
    End Sub

    Public Shared Sub UpdateAuthor(ByVal AuthorId As Integer, ByVal AuthorName As String, ByVal idUserMod As String, ByVal fechaMod As Date)
        Try
            Connect()
            Dim cmd As New SqlCommand("SP_UpdateAuthor", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@AuthorId", AuthorId)
            cmd.Parameters.AddWithValue("@Name", AuthorName)
            cmd.Parameters.AddWithValue("@idUserMod", idUserMod)
            cmd.Parameters.AddWithValue("@fechaMod", fechaMod)

            cmd.ExecuteNonQuery()

            MsgBox("Autor editado con éxito")
        Catch ex As Exception
            MsgBox("Error al editar el autor " & ex.Message)
        Finally
            Disconect()
        End Try
    End Sub


    Public Shared Sub UpdateBookWithRating(ByVal id As Integer, ByVal name As String, ByVal pagesNumber As Integer, ByVal publishMonth As Integer, ByVal publishDay As Integer, ByVal publishYear As Integer, ByVal publisher As String, ByVal isbn As String, ByVal language As String, ByVal rating As Double, ByVal countsOfReview As Integer, ByVal authorId As String, ByVal idUserMod As Integer, ByVal fechaCrea As Date, ByVal ratingD1 As String, ByVal ratingD2 As String, ByVal ratingD3 As String, ByVal ratingD4 As String, ByVal ratingD5 As String, ByVal ratingDTotal As String)
        Try
            Connect()
            Dim cmd As New SqlCommand("SP_UpdateBookAndRating", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Bookid", id)
            cmd.Parameters.AddWithValue("@Name", name)
            cmd.Parameters.AddWithValue("@pagesNumber", pagesNumber)
            cmd.Parameters.AddWithValue("@publishMonth", publishMonth)
            cmd.Parameters.AddWithValue("@publishDay", publishDay)
            cmd.Parameters.AddWithValue("@publishYear", publishYear)
            cmd.Parameters.AddWithValue("@publisher", publisher)
            cmd.Parameters.AddWithValue("@ISBN", isbn)
            cmd.Parameters.AddWithValue("@Language", language)
            cmd.Parameters.AddWithValue("@Rating", rating)
            cmd.Parameters.AddWithValue("@countsOfReview", countsOfReview)
            cmd.Parameters.AddWithValue("@AuthorName", authorId)
            cmd.Parameters.AddWithValue("@idUserMod", idUserMod)
            cmd.Parameters.AddWithValue("@fechaMod", fechaCrea)
            cmd.Parameters.AddWithValue("@RatingD1", ratingD1)
            cmd.Parameters.AddWithValue("@RatingD2", ratingD2)
            cmd.Parameters.AddWithValue("@RatingD3", ratingD3)
            cmd.Parameters.AddWithValue("@RatingD4", ratingD4)
            cmd.Parameters.AddWithValue("@RatingD5", ratingD5)
            cmd.Parameters.AddWithValue("@RatingDTotal", ratingDTotal)

            cmd.ExecuteNonQuery()

            MsgBox("Libro editado con éxito")
        Catch ex As Exception
            MsgBox("Error al editar el libro: " & ex.Message)
        Finally
            Disconect()
        End Try
    End Sub

    Public Shared Sub DeleteAuthor(ByVal id As Integer)
        Try
            Connect()
            Dim cmd As New SqlCommand("SP_DeleteAuthor", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@AuthorId", id)

            cmd.ExecuteNonQuery()

            MsgBox("Registro eliminado con éxito")
        Catch ex As Exception
            MsgBox("Error al eliminar el registro " & ex.Message)
        Finally
            Disconect()
        End Try
    End Sub

    Public Shared Sub DeleteBookAndRatings(ByVal id As Integer)
        Try
            Connect()
            Dim cmd As New SqlCommand("SP_DeleteBookAndRatings", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@BookId", id)

            cmd.ExecuteNonQuery()

            MsgBox("Registro eliminado con éxito")
        Catch ex As Exception
            MsgBox("Error al eliminar el registro " & ex.Message)
        Finally
            Disconect()
        End Try
    End Sub


    Public Shared Sub InsertUser(ByVal NameU As String, ByVal Username As String, ByVal Password As String)
        Try
            Connect()
            Dim cmd As New SqlCommand("SP_InsertUser", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Name", NameU)
            cmd.Parameters.AddWithValue("@Username", Username)
            cmd.Parameters.AddWithValue("@Password", Password)

            cmd.ExecuteNonQuery()

            MsgBox("Usuario insertado con éxito")
        Catch ex As Exception
            MsgBox("Error al insertar el usuario " & ex.Message)
        Finally
            Disconect()
        End Try
    End Sub

    Public Shared Sub UpdateUser(ByVal UserId As Integer, ByVal NameU As String, ByVal Username As String, ByVal Password As String, ByVal status As Boolean)
        Try
            Connect()
            Dim cmd As New SqlCommand("SP_UpdateUser", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserId", UserId)
            cmd.Parameters.AddWithValue("@Name", NameU)
            cmd.Parameters.AddWithValue("@Username", Username)
            cmd.Parameters.AddWithValue("@Password", Password)
            cmd.Parameters.AddWithValue("@status", status)
            cmd.ExecuteNonQuery()

            MsgBox("Usuario editado con éxito")
        Catch ex As Exception
            MsgBox("Error al editar el registro " & ex.Message)
        Finally
            Disconect()
        End Try
    End Sub

    Public Shared Sub DeleteUser(ByVal id As Integer)
        Try
            Connect()
            Dim cmd As New SqlCommand("SP_DeleteUser", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserId", id)

            cmd.ExecuteNonQuery()

            MsgBox("Registro eliminado con éxito")
        Catch ex As Exception
            MsgBox("Error al eliminar el registro " & ex.Message)
        Finally
            Disconect()
        End Try
    End Sub

End Class
