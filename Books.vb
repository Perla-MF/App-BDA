Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Goodreads.Connection

Public Class Books

    Dim cGrip As Integer = 10
    Dim Cmd As String
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
        Me.PanelP.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
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

    Private Sub PanelTitleB_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitleB.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PBClose_Click(sender As Object, e As EventArgs) Handles PBClose.Click
        Me.Close()
    End Sub

    Dim lx, ly, sw, sh As Integer

    Private Sub PBMin_Click(sender As Object, e As EventArgs) Handles PBMin.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        PBMax.Visible = True
        PBMin.Visible = False
    End Sub

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

    Private Sub PBMinimizar_Click(sender As Object, e As EventArgs) Handles PBMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PBAgregar_Click(sender As Object, e As EventArgs) Handles PBAgregar.Click
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
        Dim idUsuarioC As Integer = AppConfig.UserID
        Dim fechaCrea As Date = DateAdd.Value.Date
        Dim ratingD1 As String = txtBoxR1.Text
        Dim ratingD2 As String = txtBoxR2.Text
        Dim ratingD3 As String = txtBoxR3.Text
        Dim ratingD4 As String = txtBoxR4.Text
        Dim ratingD5 As String = txtBoxR5.Text
        Dim ratingDTotal As String = txtBoxRT.Text
        Connection.InsertBookWithRating(name, pagesNumber, publishMonth, publishDay, publishYear, publisher, isbn, language, rating, countsOfReview, authorId, idUsuarioC, fechaCrea, ratingD1, ratingD2, ratingD3, ratingD4, ratingD5, ratingDTotal)
        MsgBox("Libro insertado con éxito.")
    End Sub

    Private Sub PBLimpiar_Click(sender As Object, e As EventArgs) Handles PBLimpiar.Click
        Functions.CleanB(PanelI)
    End Sub
End Class