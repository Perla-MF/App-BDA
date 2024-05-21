Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class Author
    Dim cGrip As Integer = 10
    Dim Cmd As String
    Dim query As String
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelFondo.Region = region
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitleB_MouseMove(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Handle, &H112&, &HF012&, 0)
    End Sub
    Dim lx, ly, sw, sh As Integer
    Private Sub picBoxClose_Click(sender As Object, e As EventArgs) Handles picBoxClose.Click
        Me.Close()
    End Sub

    Private Sub PicBoxMinimize_Click(sender As Object, e As EventArgs) Handles PicBoxMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PicBoxMin_Click(sender As Object, e As EventArgs) Handles PicBoxMin.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        PicBoxMaximize.Visible = True
        PicBoxMin.Visible = False
    End Sub

    Private Sub Author_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "SELECT id, [Name], AuthorId FROM Author"
        DataGVAuthor.DataSource = Connection.SelectQuery(query)
        LlenarAutor()
    End Sub

    Private Sub PicBoxMaximize_Click(sender As Object, e As EventArgs) Handles PicBoxMaximize.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        PicBoxMaximize.Visible = False
        PicBoxMin.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim nameAuthor As String = txtName.Text
        Dim idUsuarioC As Integer = AppConfig.UserID
        Dim fechaCrea As Date = DateAdd.Value.Date

        Connection.InsertAuthor(nameAuthor, idUsuarioC, fechaCrea)
    End Sub

    Private Sub DataGVAuthor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGVAuthor.CellContentClick
        Me.txtID.Text = DataGVAuthor.CurrentRow.Cells(0).Value.ToString()
        Me.txtName.Text = DataGVAuthor.CurrentRow.Cells(1).Value.ToString()
        Me.txtAID.Text = DataGVAuthor.CurrentRow.Cells(2).Value.ToString()
    End Sub

    Public Sub LlenarAutor()
        query = "SELECT id, [Name] FROM Author"
        CBAuthor.DataSource = Connection.SelectQuery(query)
        CBAuthor.DisplayMember = "Name"
        CBAuthor.ValueMember = "id"
    End Sub

    Public SelectedAuthor As String
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        query = "SELECT id, [Name], AuthorId FROM Author WHERE Name = '" & SelectedAuthor.Replace("'", "''") & "'"
        DataGVAuthor.DataSource = Connection.SelectQuery(query)
    End Sub

    Private Sub CBAuthor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBAuthor.SelectedIndexChanged
        SelectedAuthor = CBAuthor.Text
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim AuthorId As String = txtAID.Text
        Dim AuthorName As String = txtName.Text
        Dim idUsuarioMod As Integer = AppConfig.UserID
        Dim fechaMod As Date = DateAdd.Value.Date

        Connection.UpdateAuthor(AuthorId, AuthorName, idUsuarioMod, fechaMod)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtID.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim id As Integer = txtID.Text

        Connection.DeleteAuthor(id)
    End Sub

    Public Sub LoadD()
        Try
            query = "SELECT id, [Name], AuthorId FROM Author"
            DataGVAuthor.DataSource = Connection.SelectQuery(query)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        LoadD()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Functions.CleanB(PanelM)
    End Sub
End Class