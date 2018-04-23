Public NotInheritable Class MainPage
    Inherits Page
    Public Sub New()
        Me.InitializeComponent()
    End Sub

    Private Sub ButtonInfo_Click(ByVal sender As Object, ByVal e As EventArgs)
        textEdit.EditValue = String.Empty
    End Sub
End Class
