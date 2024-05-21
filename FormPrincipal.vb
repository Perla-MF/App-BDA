Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormPrincipal
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO'
    Dim cGrip As Integer = 10
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
        Me.PanelC.Region = region
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
    Private Sub PanelTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitle.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PicBClose_Click(sender As Object, e As EventArgs) Handles PicBClose.Click
        Me.Close()
    End Sub

    Dim lx, ly, sw, sh As Integer
    Private Sub PicBMaximize_Click(sender As Object, e As EventArgs) Handles PicBMaximize.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        PicBMaximize.Visible = False
        PicBR.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub picBMinimize_Click(sender As Object, e As EventArgs) Handles picBMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PicBR_Click(sender As Object, e As EventArgs) Handles PicBR.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        PicBMaximize.Visible = True
        PicBR.Visible = False
    End Sub
    Private Sub btnAddB_Click(sender As Object, e As EventArgs) Handles btnAddB.Click
        Books.Show()
    End Sub

    Private Sub BtnAddA_Click(sender As Object, e As EventArgs) Handles BtnAddA.Click
        Author.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddUser.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EditBooks.Show()
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "SELECT * FROM VW_FichaBibliografica"
        DataGVFichaB.DataSource = Connection.SelectQuery(query)
        LlenarAutor()
    End Sub

    Public Sub LlenarAutor()
        query = "SELECT DISTINCT id, Autor FROM VW_FichaBibliografica"
        CBoxAutor.DataSource = Connection.SelectQuery(query)
        CBoxAutor.DisplayMember = "Autor"
        CBoxAutor.ValueMember = "id"
    End Sub

    Public Sub LoadD()
        Try
            query = "SELECT * FROM VW_FichaBibliografica"
            DataGVFichaB.DataSource = Connection.SelectQuery(query)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

    Public Sub LoadA()
        Try
            query = "SELECT DISTINCT id, Autor FROM VW_FichaBibliografica"
            CBoxAutor.DataSource = Connection.SelectQuery(query)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LoadD()
    End Sub


    Public Shared SelectedAuthor As String
    Private Sub CBoxAutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxAutor.SelectedIndexChanged
        SelectedAuthor = CBoxAutor.Text
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        query = "SELECT * FROM VW_FichaBibliografica WHERE [Autor] = '" & SelectedAuthor.Replace("'", "''") & "'"
        DataGVFichaB.DataSource = Connection.SelectQuery(query)
    End Sub

    Private Sub Reload_Click(sender As Object, e As EventArgs) Handles Reload.Click
        LoadA()
    End Sub
End Class
