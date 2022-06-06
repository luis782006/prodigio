<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdigios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReserva = New System.Windows.Forms.TextBox()
        Me.txtPuntosDes = New System.Windows.Forms.TextBox()
        Me.txtCantHab = New System.Windows.Forms.TextBox()
        Me.txtCantNoch = New System.Windows.Forms.TextBox()
        Me.txtTarifaXNoch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCuentaGrupoXnoche = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotalNeto = New System.Windows.Forms.TextBox()
        Me.txtTotalCuentaGrupo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalCuentaHuesped = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValorDolarActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValorIVAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeProdigiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnImprmir = New System.Windows.Forms.Button()
        Me.txtNdeNoches = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDolar = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.masktextF = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de reserva"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cantidad de noches"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cantidad de hab."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Puntos de Descuento"
        '
        'txtReserva
        '
        Me.txtReserva.Location = New System.Drawing.Point(166, 78)
        Me.txtReserva.Name = "txtReserva"
        Me.txtReserva.Size = New System.Drawing.Size(100, 20)
        Me.txtReserva.TabIndex = 0
        Me.txtReserva.Tag = ""
        Me.ToolTip1.SetToolTip(Me.txtReserva, "Introduzca el numero de reserva")
        '
        'txtPuntosDes
        '
        Me.txtPuntosDes.Location = New System.Drawing.Point(172, 149)
        Me.txtPuntosDes.Name = "txtPuntosDes"
        Me.txtPuntosDes.Size = New System.Drawing.Size(100, 20)
        Me.txtPuntosDes.TabIndex = 1
        Me.txtPuntosDes.Tag = ""
        Me.ToolTip1.SetToolTip(Me.txtPuntosDes, "Introduzca la Cant de puntos de descuentos")
        '
        'txtCantHab
        '
        Me.txtCantHab.Location = New System.Drawing.Point(172, 186)
        Me.txtCantHab.Name = "txtCantHab"
        Me.txtCantHab.Size = New System.Drawing.Size(100, 20)
        Me.txtCantHab.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtCantHab, "Introduzca la Cant de Habitaciones ")
        '
        'txtCantNoch
        '
        Me.txtCantNoch.Location = New System.Drawing.Point(172, 221)
        Me.txtCantNoch.Name = "txtCantNoch"
        Me.txtCantNoch.Size = New System.Drawing.Size(100, 20)
        Me.txtCantNoch.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtCantNoch, "Introduzca la Cant Noches ")
        '
        'txtTarifaXNoch
        '
        Me.txtTarifaXNoch.Location = New System.Drawing.Point(172, 320)
        Me.txtTarifaXNoch.Name = "txtTarifaXNoch"
        Me.txtTarifaXNoch.Size = New System.Drawing.Size(100, 20)
        Me.txtTarifaXNoch.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtTarifaXNoch, "Introduzca los precios por cada noche")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tarifa neta x Noche"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(172, 356)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 6
        Me.btnIngresar.Text = "Ingresar"
        Me.ToolTip1.SetToolTip(Me.btnIngresar, "Click para ingresar los precios de la reserva")
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'dgvGrilla
        '
        Me.dgvGrilla.AllowUserToAddRows = False
        Me.dgvGrilla.AllowUserToDeleteRows = False
        Me.dgvGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Reserva, Me.Column2})
        Me.dgvGrilla.Location = New System.Drawing.Point(21, 32)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.ReadOnly = True
        Me.dgvGrilla.Size = New System.Drawing.Size(306, 414)
        Me.dgvGrilla.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.dgvGrilla, "Precios de la reserva por noches en dolar")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cuenta huesped a pagar in house"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 455)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cuenta  Grupo  x Noche"
        '
        'txtCuentaGrupoXnoche
        '
        Me.txtCuentaGrupoXnoche.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCuentaGrupoXnoche.Location = New System.Drawing.Point(156, 452)
        Me.txtCuentaGrupoXnoche.Name = "txtCuentaGrupoXnoche"
        Me.txtCuentaGrupoXnoche.ReadOnly = True
        Me.txtCuentaGrupoXnoche.Size = New System.Drawing.Size(69, 20)
        Me.txtCuentaGrupoXnoche.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtCuentaGrupoXnoche, "Precio en dolar de descuentos ")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotalNeto)
        Me.GroupBox1.Controls.Add(Me.txtTotalCuentaGrupo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtTotalCuentaHuesped)
        Me.GroupBox1.Location = New System.Drawing.Point(291, 512)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 97)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales"
        '
        'txtTotalNeto
        '
        Me.txtTotalNeto.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotalNeto.Location = New System.Drawing.Point(136, 68)
        Me.txtTotalNeto.Name = "txtTotalNeto"
        Me.txtTotalNeto.ReadOnly = True
        Me.txtTotalNeto.Size = New System.Drawing.Size(66, 20)
        Me.txtTotalNeto.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtTotalNeto, "Total neto de ambas cuenta")
        '
        'txtTotalCuentaGrupo
        '
        Me.txtTotalCuentaGrupo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotalCuentaGrupo.Location = New System.Drawing.Point(136, 44)
        Me.txtTotalCuentaGrupo.Name = "txtTotalCuentaGrupo"
        Me.txtTotalCuentaGrupo.ReadOnly = True
        Me.txtTotalCuentaGrupo.Size = New System.Drawing.Size(66, 20)
        Me.txtTotalCuentaGrupo.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtTotalCuentaGrupo, "Total cuenta grupo a facturar a la Agencia  Prodigios")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(72, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Total Neto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total Cuenta Grupo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Cuenta Huesped"
        '
        'txtTotalCuentaHuesped
        '
        Me.txtTotalCuentaHuesped.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotalCuentaHuesped.Location = New System.Drawing.Point(135, 18)
        Me.txtTotalCuentaHuesped.Name = "txtTotalCuentaHuesped"
        Me.txtTotalCuentaHuesped.ReadOnly = True
        Me.txtTotalCuentaHuesped.Size = New System.Drawing.Size(67, 20)
        Me.txtTotalCuentaHuesped.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtTotalCuentaHuesped, "Total de cuenta huesped a pagar directo al hotel")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(649, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ValorDolarActualToolStripMenuItem, Me.ValorIVAToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ValorDolarActualToolStripMenuItem
        '
        Me.ValorDolarActualToolStripMenuItem.Name = "ValorDolarActualToolStripMenuItem"
        Me.ValorDolarActualToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ValorDolarActualToolStripMenuItem.Text = "Valor Dolar Actual"
        '
        'ValorIVAToolStripMenuItem
        '
        Me.ValorIVAToolStripMenuItem.Name = "ValorIVAToolStripMenuItem"
        Me.ValorIVAToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ValorIVAToolStripMenuItem.Text = "Valor IVA"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerLaAyudaToolStripMenuItem, Me.AcercaDeProdigiosToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'VerLaAyudaToolStripMenuItem
        '
        Me.VerLaAyudaToolStripMenuItem.Name = "VerLaAyudaToolStripMenuItem"
        Me.VerLaAyudaToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.VerLaAyudaToolStripMenuItem.Text = "Ver la Ayuda"
        '
        'AcercaDeProdigiosToolStripMenuItem
        '
        Me.AcercaDeProdigiosToolStripMenuItem.Name = "AcercaDeProdigiosToolStripMenuItem"
        Me.AcercaDeProdigiosToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AcercaDeProdigiosToolStripMenuItem.Text = "Acerca de Prodigios"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(20, 587)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Click para hacer una nueva reserva")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvGrilla)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCuentaGrupoXnoche)
        Me.GroupBox2.Location = New System.Drawing.Point(291, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 479)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precios"
        '
        'btnImprmir
        '
        Me.btnImprmir.Location = New System.Drawing.Point(208, 588)
        Me.btnImprmir.Name = "btnImprmir"
        Me.btnImprmir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprmir.TabIndex = 8
        Me.btnImprmir.Text = "Imprimir"
        Me.ToolTip1.SetToolTip(Me.btnImprmir, "Imprimir precios")
        Me.btnImprmir.UseVisualStyleBackColor = True
        '
        'txtNdeNoches
        '
        Me.txtNdeNoches.Enabled = False
        Me.txtNdeNoches.Location = New System.Drawing.Point(172, 290)
        Me.txtNdeNoches.Name = "txtNdeNoches"
        Me.txtNdeNoches.Size = New System.Drawing.Size(67, 20)
        Me.txtNdeNoches.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(120, 293)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Noches"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Valor dolar"
        '
        'lblDolar
        '
        Me.lblDolar.AutoSize = True
        Me.lblDolar.Location = New System.Drawing.Point(81, 42)
        Me.lblDolar.Name = "lblDolar"
        Me.lblDolar.Size = New System.Drawing.Size(22, 13)
        Me.lblDolar.TabIndex = 1
        Me.lblDolar.Text = "8.3"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Valor IVA"
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Location = New System.Drawing.Point(81, 23)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(28, 13)
        Me.lblIVA.TabIndex = 0
        Me.lblIVA.Text = "1.21"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblDolar)
        Me.GroupBox3.Controls.Add(Me.lblIVA)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(81, 428)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(126, 71)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Valores Cambiarios"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 3000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda al Usuario"
        '
        'masktextF
        '
        Me.masktextF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.masktextF.Location = New System.Drawing.Point(171, 257)
        Me.masktextF.Name = "masktextF"
        Me.masktextF.Size = New System.Drawing.Size(98, 20)
        Me.masktextF.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.masktextF, "Ingrese fecha de inicio.Despliegue la lista")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources.noche_de_luna_icono_7290_96
        Me.PictureBox4.Location = New System.Drawing.Point(18, 212)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.WindowsApplication1.My.Resources.Resources.money2
        Me.PictureBox5.Location = New System.Drawing.Point(18, 311)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.home
        Me.PictureBox3.Location = New System.Drawing.Point(18, 174)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.percent
        Me.PictureBox2.Location = New System.Drawing.Point(18, 137)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.note_edit
        Me.PictureBox1.Location = New System.Drawing.Point(18, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(81, 260)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Fecha Check in"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Noche"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 60
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Reserva
        '
        Me.Reserva.HeaderText = "Reserva"
        Me.Reserva.Name = "Reserva"
        Me.Reserva.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Precio"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'frmProdigios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 621)
        Me.Controls.Add(Me.masktextF)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnImprmir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNdeNoches)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtCantNoch)
        Me.Controls.Add(Me.txtCantHab)
        Me.Controls.Add(Me.txtPuntosDes)
        Me.Controls.Add(Me.txtTarifaXNoch)
        Me.Controls.Add(Me.txtReserva)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmProdigios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prodrigios"
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReserva As System.Windows.Forms.TextBox
    Friend WithEvents txtPuntosDes As System.Windows.Forms.TextBox
    Friend WithEvents txtCantHab As System.Windows.Forms.TextBox
    Friend WithEvents txtCantNoch As System.Windows.Forms.TextBox
    Friend WithEvents txtTarifaXNoch As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents dgvGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaGrupoXnoche As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCuentaHuesped As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValorDolarActualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValorIVAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprmir As System.Windows.Forms.Button
    Friend WithEvents txtNdeNoches As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblDolar As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblIVA As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalCuentaGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalNeto As System.Windows.Forms.TextBox
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerLaAyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeProdigiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents masktextF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
