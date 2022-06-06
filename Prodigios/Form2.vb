Public Class frmDolar

    
    Private Sub btnDolar_Click(sender As Object, e As EventArgs) Handles btnDolar.Click
       
        frmProdigios.Enabled = True
        Me.Hide()
        If txtDolar.Text = "" Then
            frmProdigios.lblDolar.Text = fileReader
        Else
            frmProdigios.lblDolar.Text = txtDolar.Text
        End If
    End Sub

 
    Private Sub frmDolar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class