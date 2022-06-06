Public Class frmIVA

 
    Private Sub btnIVA_Click(sender As Object, e As EventArgs) Handles btnIVA.Click
        frmProdigios.Enabled = True
        Me.Hide()

        If txtIVA.Text = "" Then
            frmProdigios.lblIVA.Text = 1.21
        Else
            frmProdigios.lblIVA.Text = txtIVA.Text
        End If
    End Sub
End Class