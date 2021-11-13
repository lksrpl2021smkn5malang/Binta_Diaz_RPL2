Public Class Form14
    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles BtnGo.Click
        MyWebBrowser.Navigate(TxtURL.Text)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        MyWebBrowser.GoSearch()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        MyWebBrowser.GoHome()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        MyWebBrowser.GoBack()
    End Sub

    Private Sub BtnForward_Click(sender As Object, e As EventArgs) Handles BtnForward.Click
        MyWebBrowser.GoForward()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        MyWebBrowser.Refresh()
    End Sub
End Class