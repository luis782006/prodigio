Public Class frmProdigios
    'Dim vDescuento As Double
    'Dim vDescuentoFinal As Double
    'Dim i As Integer
    'Dim Noches(20) As Double
    'Dim NdeNoches As Integer
    ''Dim acumulador As Decimal
    'Dim redondeoCuentaG As Double
    'Dim redondeoCuentaH As Double
   
    Private Sub frmProdigios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Bienvenidos a Prodigios Software. Tenga en cuenta que por la sencillez del programa los valores de la Tasa Cambiaria y el IVA " & _
               "estan predeterminado con la fecha actual 10/08/2014 regida en la republica de Argentina.Si desea modificarla abra el panel de ayuda o vea Opciones ")
        cxnText = Application.StartupPath & "\test.txt"
        fileReader = My.Computer.FileSystem.ReadAllText(cxnText)
        'fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\Luis\Documents\Almacen de informacion\Tutoriales Melia Recoleta\Prodigios\SolucionProdigios\Prodigios\bin\Debug\test.txt")
        lblDolar.Text = fileReader
        frmDolar.txtDolar.Text = fileReader



        Me.Show()
        txtReserva.Focus()
        Me.Height = 660
        Me.Width = 307
      
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If (txtPuntosDes.Text = "") Or (txtCantHab.Text = "") Or (txtCantNoch.Text = "") Then
            MsgBox("Por favor llene todos los campos correctamente")
            txtPuntosDes.Focus()
        Else


            i = txtNdeNoches.Text
            fechaInicio = masktextF.Text
            masktextF.Enabled = False
            Noches(i) = Val(txtTarifaXNoch.Text)
            fecha(i) = masktextF.Text
            masktextF.Text = fechaInicio.AddDays(1)
            acumulador = acumulador + (Noches(i) - vDescuentoFinal)
            rsva(i) = txtReserva.Text
            If NdeNoches <= txtCantNoch.Text Then
                NdeNoches = NdeNoches + 1
            Else
                btnIngresar.Enabled = False
            End If

            txtNdeNoches.Text = NdeNoches
            i = 1
            dgvGrilla.Rows.Clear()
            frmImprimir.dgvGrillaImprimir.Rows.Clear()

            Do While (i <= txtCantNoch.Text)
                dgvGrilla.Rows.Add(i, fecha(i), rsva(i), (Noches(i) - vDescuentoFinal))
                frmImprimir.dgvGrillaImprimir.Rows.Add(i, fecha(i), (Noches(i) - vDescuentoFinal))
                i = i + 1
            Loop


            Me.Height = 660
            'Me.Width = 575
            txtTarifaXNoch.Focus()
            txtTarifaXNoch.Text = ""
            txtCuentaGrupoXnoche.Text = vDescuentoFinal
            If txtCantNoch.Text < txtNdeNoches.Text Then
                txtNdeNoches.Enabled = False
                txtNdeNoches.Text = ""
                btnIngresar.Enabled = False
                txtTarifaXNoch.Enabled = False
                Me.Width = 665
                txtTotalCuentaHuesped.Text = (acumulador * Val(lblIVA.Text)) * Val(lblDolar.Text)
                redondeoCuentaG = Val(lblDolar.Text) * (Val(lblIVA.Text)) * (Val(vDescuentoFinal) * Val(txtCantNoch.Text))
                txtTotalCuentaGrupo.Text = redondeoCuentaG
                txtTotalNeto.Text = redondeoCuentaG + txtTotalCuentaHuesped.Text
                ''Datos para el form Imprimir
                frmImprimir.txtTotalCuentaHuesped.Text = (acumulador * Val(lblIVA.Text)) * Val(lblDolar.Text)
                redondeoCuentaG = Val(lblDolar.Text) * (Val(lblIVA.Text)) * (Val(vDescuentoFinal) * Val(txtCantNoch.Text))
                frmImprimir.txtTotalCuentaGrupo.Text = redondeoCuentaG
                frmImprimir.txtTotalNeto.Text = redondeoCuentaG + frmImprimir.txtTotalCuentaHuesped.Text
                frmImprimir.txtCuentaGrupoXnoche.Text = txtCuentaGrupoXnoche.Text
            End If

        End If


    End Sub

    Private Sub ValorDolarActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValorDolarActualToolStripMenuItem.Click
        frmDolar.Show()
        Me.Enabled = True

    End Sub

    Private Sub ValorIVAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValorIVAToolStripMenuItem.Click
        frmIVA.Show()
        Me.Enabled = True
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Height = 660
        Me.Width = 307
        txtCantHab.Text = ""
        txtCantNoch.Text = ""
        txtReserva.Text = ""
        txtPuntosDes.Text = ""
        txtTarifaXNoch.Text = ""
        dgvGrilla.Rows.Clear()
        frmImprimir.dgvGrillaImprimir.Rows.Clear()
        txtReserva.Focus()
        txtCuentaGrupoXnoche.Text = ""
        txtTotalCuentaGrupo.Text = ""
        txtTotalCuentaHuesped.Text = ""
        txtNdeNoches.Text = ""
        txtTotalNeto.Text = ""
        txtTarifaXNoch.Enabled = True
        btnIngresar.Enabled = True
        frmImprimir.txtCuentaGrupoXnoche.Text = ""
        frmImprimir.txtTotalCuentaGrupo.Text = ""
        frmImprimir.txtTotalCuentaHuesped.Text = ""
        frmImprimir.txtTotalNeto.Text = ""
        frmImprimir.lblReserva.Text = ""
        masktextF.Text = Now.Date
        masktextF.Enabled = True
        

    End Sub

    Private Sub txtCantHab_TextChanged(sender As Object, e As EventArgs) Handles txtCantHab.TextChanged
        vDescuento = Val(txtPuntosDes.Text) / Val(txtCantHab.Text)

    End Sub

    Private Sub txtCantNoch_TextChanged(sender As Object, e As EventArgs) Handles txtCantNoch.TextChanged
        vDescuentoFinal = vDescuento / Val(txtCantNoch.Text)
        'Label11.Text = Math.Round(vDescuentoFinal, 3)   Asi se redondea
        txtNdeNoches.Text = 1
        NdeNoches = 1
    End Sub



   
    Private Sub VerLaAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerLaAyudaToolStripMenuItem.Click
        frmAyuda.Show()

    End Sub

    Private Sub AcercaDeProdigiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeProdigiosToolStripMenuItem.Click
        frmAcerca.Show()

    End Sub

    Private Sub btnImprmir_Click(sender As Object, e As EventArgs) Handles btnImprmir.Click
        frmImprimir.Show()
        frmImprimir.Focus()
        frmImprimir.lblDolar.Text = lblDolar.Text
        frmImprimir.lblReserva.Text = txtReserva.Text
        frmImprimir.btnImpresion.Visible = True
        frmImprimir.btnSalirImpresion.Visible = True

    End Sub

    Private Sub txtTarifaXNoch_TextChanged(sender As Object, e As EventArgs) Handles txtTarifaXNoch.TextChanged

    End Sub
End Class
