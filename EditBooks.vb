Imports System.Runtime.InteropServices

Public Class EditBooks
    Dim query As String
    Dim cGrip As Integer = 10
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
        Me.Panelfondo.Region = region
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
    Private Sub PanelTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitleB.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Public Sub LoadD()
        Try
            query = "SELECT * FROM VW_BooksAndRatings"
            DataGVBooks.DataSource = Connection.SelectQuery(query)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

    Private Sub EditBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "SELECT * FROM VW_BooksAndRatings"
        DataGVBooks.DataSource = Connection.SelectQuery(query)
        LlenarAutor()
    End Sub

    Public Sub LlenarAutor()
        query = "SELECT id, Autor FROM VW_BooksAndRatings"
        CBoxAutor.DataSource = Connection.SelectQuery(query)
        CBoxAutor.DisplayMember = "Autor"
        CBoxAutor.ValueMember = "id"
    End Sub
    Private Sub DataGVBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGVBooks.CellContentClick
        Me.txtID.Text = DataGVBooks.CurrentRow.Cells(0).Value.ToString()
        Me.txtBoxTitulo.Text = DataGVBooks.CurrentRow.Cells(1).Value.ToString()
        Me.txtBoxPaginas.Text = DataGVBooks.CurrentRow.Cells(2).Value.ToString()
        Me.txtBoxMes.Text = DataGVBooks.CurrentRow.Cells(3).Value.ToString()
        Me.txtBoxDia.Text = DataGVBooks.CurrentRow.Cells(4).Value.ToString()
        Me.txtBoxAño.Text = DataGVBooks.CurrentRow.Cells(5).Value.ToString()
        Me.txtBoxEditorial.Text = DataGVBooks.CurrentRow.Cells(6).Value.ToString()
        Me.txtBoxISBN.Text = DataGVBooks.CurrentRow.Cells(7).Value.ToString()
        Me.txtBoxIdioma.Text = DataGVBooks.CurrentRow.Cells(8).Value.ToString()
        Me.txtBoxRating.Text = DataGVBooks.CurrentRow.Cells(9).Value.ToString()
        Me.txtBoxReseñas.Text = DataGVBooks.CurrentRow.Cells(10).Value.ToString()
        Me.txtBoxAutor.Text = DataGVBooks.CurrentRow.Cells(11).Value.ToString()
        Me.txtBoxR1.Text = DataGVBooks.CurrentRow.Cells(12).Value.ToString()
        Me.txtBoxR2.Text = DataGVBooks.CurrentRow.Cells(13).Value.ToString()
        Me.txtBoxR3.Text = DataGVBooks.CurrentRow.Cells(14).Value.ToString()
        Me.txtBoxR4.Text = DataGVBooks.CurrentRow.Cells(15).Value.ToString()
        Me.txtBoxR5.Text = DataGVBooks.CurrentRow.Cells(16).Value.ToString()
        Me.txtBoxRT.Text = DataGVBooks.CurrentRow.Cells(17).Value.ToString()
    End Sub

    Private Sub PBClose_Click(sender As Object, e As EventArgs) Handles PBClose.Click
        Me.Close()
    End Sub

    Private Sub PBMinimizar_Click(sender As Object, e As EventArgs) Handles PBMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Dim lx, ly, sw, sh As Integer
    Private Sub PBMax_Click(sender As Object, e As EventArgs) Handles PBMax.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        PBMax.Visible = False
        PBMin.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub PBMin_Click(sender As Object, e As EventArgs) Handles PBMin.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        PBMax.Visible = True
        PBMin.Visible = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        LoadD()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If String.IsNullOrWhiteSpace(txtBoxTitulo.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxPaginas.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxMes.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxDia.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxAño.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxEditorial.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxISBN.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxIdioma.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxRating.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxReseñas.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxAutor.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxR1.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxR2.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxR3.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxR4.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxR5.Text) OrElse
    String.IsNullOrWhiteSpace(txtBoxRT.Text) Then

            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim id As Integer = Convert.ToInt32(txtID.Text)
        Dim name As String = txtBoxTitulo.Text
        Dim pagesNumber As Integer = Convert.ToInt32(txtBoxPaginas.Text)
        Dim publishMonth As Integer = Convert.ToInt32(txtBoxMes.Text)
        Dim publishDay As Integer = Convert.ToInt32(txtBoxDia.Text)
        Dim publishYear As Integer = Convert.ToInt32(txtBoxAño.Text)
        Dim publisher As String = txtBoxEditorial.Text
        Dim isbn As String = txtBoxISBN.Text
        Dim language As String = txtBoxIdioma.Text
        Dim rating As Double = Convert.ToDouble(txtBoxRating.Text)
        Dim countsOfReview As Integer = Convert.ToInt32(txtBoxReseñas.Text)
        Dim authorId As String = txtBoxAutor.Text
        Dim idUsuarioMod As Integer = AppConfig.UserID
        Dim fechaMod As Date = DateAdd.Value.Date
        Dim ratingD1 As String = txtBoxR1.Text
        Dim ratingD2 As String = txtBoxR2.Text
        Dim ratingD3 As String = txtBoxR3.Text
        Dim ratingD4 As String = txtBoxR4.Text
        Dim ratingD5 As String = txtBoxR5.Text
        Dim ratingDTotal As String = txtBoxRT.Text
        Connection.UpdateBookWithRating(id, name, pagesNumber, publishMonth, publishDay, publishYear, publisher, isbn, language, rating, countsOfReview, authorId, idUsuarioMod, fechaMod, ratingD1, ratingD2, ratingD3, ratingD4, ratingD5, ratingDTotal)
    End Sub
    Private SelectedAutor As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        query = "SELECT * FROM VW_FichaBibliografica WHERE Autor = '" & SelectedAutor.Replace("'", "''") & "'"
        DataGVBooks.DataSource = Connection.SelectQuery(query)
    End Sub



    Private Sub Clean_Click(sender As Object, e As EventArgs) Handles Clean.Click
        Functions.CleanB(PanelMenu)
    End Sub

    Private Sub picBDelete_Click(sender As Object, e As EventArgs) Handles picBDelete.Click
        If String.IsNullOrWhiteSpace(txtID.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim id As Integer = txtID.Text

        Connection.DeleteBookAndRatings(id)
    End Sub
End Class