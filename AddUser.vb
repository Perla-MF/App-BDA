Public Class AddUser

    Dim query As String
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "SELECT *  FROM [User]"
        DataGVUsers.DataSource = Connection.SelectQuery(query)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtUser.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim NameU As String = txtName.Text
        Dim Username As String = txtUser.Text
        Dim Password As String = txtPassword.Text

        Connection.InsertUser(NameU, Username, Password)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrWhiteSpace(txtID.Text) OrElse
   String.IsNullOrWhiteSpace(txtName.Text) OrElse
   String.IsNullOrWhiteSpace(txtUser.Text) OrElse
   String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
   String.IsNullOrWhiteSpace(txtStatus.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim UserId As Integer = txtID.Text
        Dim NameU As String = txtName.Text
        Dim Username As String = txtUser.Text
        Dim Password As String = txtPassword.Text
        Dim status As Boolean = txtStatus.Text

        Connection.UpdateUser(UserId, NameU, Username, Password, status)
    End Sub

    Public Sub LoadD()
        Try
            query = "SELECT *  FROM [User]"
            DataGVUsers.DataSource = Connection.SelectQuery(query)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        LoadD
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtID.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim id As Integer = txtID.Text

        Connection.DeleteUser(id)
    End Sub

    Private Sub DataGVUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGVUsers.CellContentClick
        Me.txtID.Text = DataGVUsers.CurrentRow.Cells(0).Value.ToString()
        Me.txtName.Text = DataGVUsers.CurrentRow.Cells(1).Value.ToString()
        Me.txtUser.Text = DataGVUsers.CurrentRow.Cells(2).Value.ToString()
        Me.txtPassword.Text = DataGVUsers.CurrentRow.Cells(3).Value.ToString()
        Me.txtStatus.Text = DataGVUsers.CurrentRow.Cells(4).Value.ToString()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Functions.CleanB(PanelMenu)
    End Sub
End Class