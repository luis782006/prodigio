Public Class frmImprimir


    Private Sub frmImprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PrintForm()
        btnImpresion.Visible = False
        btnSalirImpresion.Visible = False
        Try
            Cursor = Cursors.WaitCursor
            With Me.PrintForm1
                .PrintAction = Printing.PrintAction.PrintToPreview
                .PrinterSettings.DefaultPageSettings.Landscape = True
                .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)


            End With
            Cursor = Cursors.Default


        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox("Lo sentimos al parecer la impresion no se pudo realizar cpn exito. Comuniquese con el administrador del Programa")

        End Try
    End Sub

    Private Sub btnImpresion_Click(sender As Object, e As EventArgs) Handles btnImpresion.Click
        Call PrintForm()
        Me.Hide()

    End Sub

    Private Sub btnSalirImpresion_Click(sender As Object, e As EventArgs) Handles btnSalirImpresion.Click
        Me.Hide()

    End Sub
End Class