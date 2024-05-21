Public Class Functions
    Public Shared Sub CleanB(P As Panel)
        For Each TB As TextBox In P.Controls.OfType(Of TextBox)
            TB.Clear()
        Next
    End Sub
End Class
