<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimir
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImprimir))
        Me.dgvGrillaImprimir = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalNeto = New System.Windows.Forms.TextBox()
        Me.txtTotalCuentaGrupo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalCuentaHuesped = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCuentaGrupoXnoche = New System.Windows.Forms.TextBox()
        Me.lblDolar = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnImpresion = New System.Windows.Forms.Button()
        Me.btnSalirImpresion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblReserva = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvGrillaImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGrillaImprimir
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvGrillaImprimir.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGrillaImprimir.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvGrillaImprimir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGrillaImprimir.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvGrillaImprimir.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrillaImprimir.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGrillaImprimir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Fecha, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGrillaImprimir.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGrillaImprimir.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvGrillaImprimir.Location = New System.Drawing.Point(26, 43)
        Me.dgvGrillaImprimir.Name = "dgvGrillaImprimir"
        Me.dgvGrillaImprimir.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrillaImprimir.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGrillaImprimir.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvGrillaImprimir.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvGrillaImprimir.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvGrillaImprimir.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvGrillaImprimir.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.dgvGrillaImprimir.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvGrillaImprimir.Size = New System.Drawing.Size(260, 441)
        Me.dgvGrillaImprimir.TabIndex = 21
        '
        'Column1
        '
        Me.Column1.HeaderText = "Noche"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 60
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Precio"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Cuenta huesped a pagar in house"
        '
        'txtTotalNeto
        '
        Me.txtTotalNeto.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotalNeto.Enabled = False
        Me.txtTotalNeto.Location = New System.Drawing.Point(417, 205)
        Me.txtTotalNeto.Name = "txtTotalNeto"
        Me.txtTotalNeto.Size = New System.Drawing.Size(66, 20)
        Me.txtTotalNeto.TabIndex = 28
        '
        'txtTotalCuentaGrupo
        '
        Me.txtTotalCuentaGrupo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotalCuentaGrupo.Enabled = False
        Me.txtTotalCuentaGrupo.Location = New System.Drawing.Point(417, 145)
        Me.txtTotalCuentaGrupo.Name = "txtTotalCuentaGrupo"
        Me.txtTotalCuentaGrupo.Size = New System.Drawing.Size(66, 20)
        Me.txtTotalCuentaGrupo.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(353, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Total Neto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(310, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Total Cuenta Grupo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(298, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Total Cuenta Huesped"
        '
        'txtTotalCuentaHuesped
        '
        Me.txtTotalCuentaHuesped.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotalCuentaHuesped.Enabled = False
        Me.txtTotalCuentaHuesped.Location = New System.Drawing.Point(417, 91)
        Me.txtTotalCuentaHuesped.Name = "txtTotalCuentaHuesped"
        Me.txtTotalCuentaHuesped.Size = New System.Drawing.Size(67, 20)
        Me.txtTotalCuentaHuesped.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 526)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Cuenta  Grupo  x Noche sin IVA"
        '
        'txtCuentaGrupoXnoche
        '
        Me.txtCuentaGrupoXnoche.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCuentaGrupoXnoche.Enabled = False
        Me.txtCuentaGrupoXnoche.Location = New System.Drawing.Point(192, 523)
        Me.txtCuentaGrupoXnoche.Name = "txtCuentaGrupoXnoche"
        Me.txtCuentaGrupoXnoche.Size = New System.Drawing.Size(69, 20)
        Me.txtCuentaGrupoXnoche.TabIndex = 31
        '
        'lblDolar
        '
        Me.lblDolar.AutoSize = True
        Me.lblDolar.Location = New System.Drawing.Point(418, 254)
        Me.lblDolar.Name = "lblDolar"
        Me.lblDolar.Size = New System.Drawing.Size(22, 13)
        Me.lblDolar.TabIndex = 33
        Me.lblDolar.Text = "8.3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(355, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Valor dolar"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnImpresion
        '
        Me.btnImpresion.Location = New System.Drawing.Point(337, 521)
        Me.btnImpresion.Name = "btnImpresion"
        Me.btnImpresion.Size = New System.Drawing.Size(75, 23)
        Me.btnImpresion.TabIndex = 34
        Me.btnImpresion.Text = "Imprimir"
        Me.btnImpresion.UseVisualStyleBackColor = True
        '
        'btnSalirImpresion
        '
        Me.btnSalirImpresion.Location = New System.Drawing.Point(421, 521)
        Me.btnSalirImpresion.Name = "btnSalirImpresion"
        Me.btnSalirImpresion.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirImpresion.TabIndex = 35
        Me.btnSalirImpresion.Text = "Salir"
        Me.btnSalirImpresion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(310, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "N.Rsva"
        '
        'lblReserva
        '
        Me.lblReserva.AutoSize = True
        Me.lblReserva.Location = New System.Drawing.Point(355, 50)
        Me.lblReserva.Name = "lblReserva"
        Me.lblReserva.Size = New System.Drawing.Size(47, 13)
        Me.lblReserva.TabIndex = 37
        Me.lblReserva.Text = "Reserva"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 487)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(322, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Nota: Los valores que se encuentra en la tabla, no incluyen el IVA."
        '
        'frmImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(526, 576)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblReserva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalirImpresion)
        Me.Controls.Add(Me.btnImpresion)
        Me.Controls.Add(Me.lblDolar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCuentaGrupoXnoche)
        Me.Controls.Add(Me.txtTotalNeto)
        Me.Controls.Add(Me.txtTotalCuentaGrupo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalCuentaHuesped)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvGrillaImprimir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmImprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir"
        CType(Me.dgvGrillaImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvGrillaImprimir As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalNeto As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCuentaGrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCuentaHuesped As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaGrupoXnoche As System.Windows.Forms.TextBox
    Friend WithEvents lblDolar As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnImpresion As System.Windows.Forms.Button
    Friend WithEvents btnSalirImpresion As System.Windows.Forms.Button
    Friend WithEvents lblReserva As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
