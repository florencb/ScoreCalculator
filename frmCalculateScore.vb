Public Class frmCalculateScore
    Dim score As Integer
    Dim sum As Integer
    Dim counts As Integer
    Dim average As Decimal


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim score As Integer = CInt(txtScore.Text)
        sum += score
        counts = counts + 1

        txtTotal.Text = sum.ToString
        txtCount.Text = counts.ToString
        average = CDec(sum / counts)
        txtAverage.Text = (Math.Round(average, 0, MidpointRounding.AwayFromZero).ToString)



        txtScore.Select()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        score = 0
        sum = 0
        counts = 0
        average = 0

        txtAverage.Text = ""
        txtCount.Text = ""
        txtScore.Text = ""
        txtTotal.Text = ""


        For Each txt As Control In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = String.Empty
            End If
        Next

        txtScore.Select()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

