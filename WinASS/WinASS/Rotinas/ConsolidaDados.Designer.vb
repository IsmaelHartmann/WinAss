<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsolidaDados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsolidaDados))
        Me.btBuscarLancamentos = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.dtgLancamentosLancados = New System.Windows.Forms.DataGridView
        Me.MX = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.dtgLancamentosEnviados = New System.Windows.Forms.DataGridView
        Me.MX1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.btBuscarLancamentosEnviados = New System.Windows.Forms.Button
        Me.txtCabecalho11 = New System.Windows.Forms.TextBox
        Me.txtCabecalho21 = New System.Windows.Forms.TextBox
        Me.btProcessarLancados = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btFechar = New System.Windows.Forms.Button
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDataInicio = New FzFlexBox.DateTextBox
        Me.txtDataFinal = New FzFlexBox.DateTextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.brBuscarLancamentosCobrados = New System.Windows.Forms.Button
        Me.btReverteLancamentosCobrados = New System.Windows.Forms.Button
        Me.btReverteLancamentosEnviados = New System.Windows.Forms.Button
        Me.clTipoAssistencia = New System.Windows.Forms.CheckedListBox
        Me.lblTipoAssistencia = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCabecalho31 = New System.Windows.Forms.TextBox
        Me.dtgLancamentosCobrados = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.btProcessarEnviados = New System.Windows.Forms.Button
        Me.pbProgresso = New System.Windows.Forms.ProgressBar
        Me.txtCabecalho10 = New System.Windows.Forms.TextBox
        Me.txtCabecalho20 = New System.Windows.Forms.TextBox
        Me.txtCabecalho30 = New System.Windows.Forms.TextBox
        Me.txtData_Envio = New FzFlexBox.DateTextBox
        Me.lbl1 = New System.Windows.Forms.Label
        Me.txtData_Cobranca = New FzFlexBox.DateTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbTipoPesquisa = New System.Windows.Forms.Label
        CType(Me.dtgLancamentosLancados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgLancamentosEnviados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgLancamentosCobrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btBuscarLancamentos
        '
        Me.btBuscarLancamentos.BackColor = System.Drawing.Color.Yellow
        Me.btBuscarLancamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBuscarLancamentos.Image = Global.WinASS.My.Resources.Resources._4035_16x16
        Me.btBuscarLancamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btBuscarLancamentos.Location = New System.Drawing.Point(260, 0)
        Me.btBuscarLancamentos.Name = "btBuscarLancamentos"
        Me.btBuscarLancamentos.Size = New System.Drawing.Size(64, 22)
        Me.btBuscarLancamentos.TabIndex = 6
        Me.btBuscarLancamentos.Text = "Lançado"
        Me.btBuscarLancamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btBuscarLancamentos, "Filtra pela Data de Lançamento.")
        Me.btBuscarLancamentos.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dtgLancamentosLancados
        '
        Me.dtgLancamentosLancados.AllowUserToAddRows = False
        Me.dtgLancamentosLancados.AllowUserToDeleteRows = False
        Me.dtgLancamentosLancados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLancamentosLancados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MX})
        Me.dtgLancamentosLancados.Location = New System.Drawing.Point(260, 106)
        Me.dtgLancamentosLancados.Name = "dtgLancamentosLancados"
        Me.dtgLancamentosLancados.ReadOnly = True
        Me.dtgLancamentosLancados.Size = New System.Drawing.Size(312, 303)
        Me.dtgLancamentosLancados.TabIndex = 11
        '
        'MX
        '
        Me.MX.HeaderText = "MX"
        Me.MX.Name = "MX"
        Me.MX.ReadOnly = True
        '
        'dtgLancamentosEnviados
        '
        Me.dtgLancamentosEnviados.AllowUserToAddRows = False
        Me.dtgLancamentosEnviados.AllowUserToDeleteRows = False
        Me.dtgLancamentosEnviados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLancamentosEnviados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MX1})
        Me.dtgLancamentosEnviados.Location = New System.Drawing.Point(590, 106)
        Me.dtgLancamentosEnviados.Name = "dtgLancamentosEnviados"
        Me.dtgLancamentosEnviados.ReadOnly = True
        Me.dtgLancamentosEnviados.Size = New System.Drawing.Size(312, 303)
        Me.dtgLancamentosEnviados.TabIndex = 12
        '
        'MX1
        '
        Me.MX1.HeaderText = "MX"
        Me.MX1.Name = "MX1"
        Me.MX1.ReadOnly = True
        '
        'btBuscarLancamentosEnviados
        '
        Me.btBuscarLancamentosEnviados.BackColor = System.Drawing.Color.LightGreen
        Me.btBuscarLancamentosEnviados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBuscarLancamentosEnviados.Image = Global.WinASS.My.Resources.Resources._4035_16x16
        Me.btBuscarLancamentosEnviados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btBuscarLancamentosEnviados.Location = New System.Drawing.Point(330, 0)
        Me.btBuscarLancamentosEnviados.Name = "btBuscarLancamentosEnviados"
        Me.btBuscarLancamentosEnviados.Size = New System.Drawing.Size(64, 22)
        Me.btBuscarLancamentosEnviados.TabIndex = 10
        Me.btBuscarLancamentosEnviados.Text = "Enviado"
        Me.btBuscarLancamentosEnviados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btBuscarLancamentosEnviados, "Filtra pela Data de Envio.")
        Me.btBuscarLancamentosEnviados.UseVisualStyleBackColor = False
        '
        'txtCabecalho11
        '
        Me.txtCabecalho11.Location = New System.Drawing.Point(330, 82)
        Me.txtCabecalho11.Name = "txtCabecalho11"
        Me.txtCabecalho11.ReadOnly = True
        Me.txtCabecalho11.Size = New System.Drawing.Size(242, 20)
        Me.txtCabecalho11.TabIndex = 5
        Me.txtCabecalho11.TabStop = False
        '
        'txtCabecalho21
        '
        Me.txtCabecalho21.Location = New System.Drawing.Point(660, 80)
        Me.txtCabecalho21.Name = "txtCabecalho21"
        Me.txtCabecalho21.ReadOnly = True
        Me.txtCabecalho21.Size = New System.Drawing.Size(242, 20)
        Me.txtCabecalho21.TabIndex = 9
        Me.txtCabecalho21.TabStop = False
        '
        'btProcessarLancados
        '
        Me.btProcessarLancados.BackColor = System.Drawing.SystemColors.Control
        Me.btProcessarLancados.Image = Global.WinASS.My.Resources.Resources._7689_16x16
        Me.btProcessarLancados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btProcessarLancados.Location = New System.Drawing.Point(436, 417)
        Me.btProcessarLancados.Name = "btProcessarLancados"
        Me.btProcessarLancados.Size = New System.Drawing.Size(94, 22)
        Me.btProcessarLancados.TabIndex = 14
        Me.btProcessarLancados.Text = "Processar"
        Me.btProcessarLancados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btProcessarLancados.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Período:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFechar
        '
        Me.btFechar.BackColor = System.Drawing.SystemColors.Control
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFechar.Location = New System.Drawing.Point(1164, 0)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(66, 22)
        Me.btFechar.TabIndex = 23
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btFechar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(142, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Até"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDataInicio
        '
        Me.txtDataInicio.Flags = 65536
        Me.txtDataInicio.Location = New System.Drawing.Point(68, 3)
        Me.txtDataInicio.Name = "txtDataInicio"
        Me.txtDataInicio.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtDataInicio.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtDataInicio.Size = New System.Drawing.Size(68, 20)
        Me.txtDataInicio.TabIndex = 24
        '
        'txtDataFinal
        '
        Me.txtDataFinal.Flags = 65536
        Me.txtDataFinal.Location = New System.Drawing.Point(175, 3)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtDataFinal.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtDataFinal.Size = New System.Drawing.Size(68, 20)
        Me.txtDataFinal.TabIndex = 25
        '
        'brBuscarLancamentosCobrados
        '
        Me.brBuscarLancamentosCobrados.BackColor = System.Drawing.Color.LightBlue
        Me.brBuscarLancamentosCobrados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.brBuscarLancamentosCobrados.Image = Global.WinASS.My.Resources.Resources._4035_16x16
        Me.brBuscarLancamentosCobrados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.brBuscarLancamentosCobrados.Location = New System.Drawing.Point(400, 0)
        Me.brBuscarLancamentosCobrados.Name = "brBuscarLancamentosCobrados"
        Me.brBuscarLancamentosCobrados.Size = New System.Drawing.Size(64, 22)
        Me.brBuscarLancamentosCobrados.TabIndex = 31
        Me.brBuscarLancamentosCobrados.Text = "Cobrado"
        Me.brBuscarLancamentosCobrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.brBuscarLancamentosCobrados, "Filtra pela data da Cobrança.")
        Me.brBuscarLancamentosCobrados.UseVisualStyleBackColor = False
        '
        'btReverteLancamentosCobrados
        '
        Me.btReverteLancamentosCobrados.BackColor = System.Drawing.SystemColors.Control
        Me.btReverteLancamentosCobrados.Image = Global.WinASS.My.Resources.Resources._7884_16x16
        Me.btReverteLancamentosCobrados.Location = New System.Drawing.Point(1193, 415)
        Me.btReverteLancamentosCobrados.Name = "btReverteLancamentosCobrados"
        Me.btReverteLancamentosCobrados.Size = New System.Drawing.Size(37, 22)
        Me.btReverteLancamentosCobrados.TabIndex = 37
        Me.btReverteLancamentosCobrados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btReverteLancamentosCobrados, "Reverte Lançamentos Cobrados")
        Me.btReverteLancamentosCobrados.UseVisualStyleBackColor = False
        '
        'btReverteLancamentosEnviados
        '
        Me.btReverteLancamentosEnviados.BackColor = System.Drawing.SystemColors.Control
        Me.btReverteLancamentosEnviados.Image = Global.WinASS.My.Resources.Resources._7884_16x16
        Me.btReverteLancamentosEnviados.Location = New System.Drawing.Point(865, 415)
        Me.btReverteLancamentosEnviados.Name = "btReverteLancamentosEnviados"
        Me.btReverteLancamentosEnviados.Size = New System.Drawing.Size(37, 22)
        Me.btReverteLancamentosEnviados.TabIndex = 38
        Me.btReverteLancamentosEnviados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btReverteLancamentosEnviados, "Reverte Lançamentos Enviados")
        Me.btReverteLancamentosEnviados.UseVisualStyleBackColor = False
        '
        'clTipoAssistencia
        '
        Me.clTipoAssistencia.CheckOnClick = True
        Me.clTipoAssistencia.FormattingEnabled = True
        Me.clTipoAssistencia.Location = New System.Drawing.Point(12, 59)
        Me.clTipoAssistencia.Name = "clTipoAssistencia"
        Me.clTipoAssistencia.Size = New System.Drawing.Size(231, 379)
        Me.clTipoAssistencia.TabIndex = 27
        '
        'lblTipoAssistencia
        '
        Me.lblTipoAssistencia.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoAssistencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipoAssistencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTipoAssistencia.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoAssistencia.ForeColor = System.Drawing.Color.Black
        Me.lblTipoAssistencia.Location = New System.Drawing.Point(12, 28)
        Me.lblTipoAssistencia.Name = "lblTipoAssistencia"
        Me.lblTipoAssistencia.Size = New System.Drawing.Size(231, 20)
        Me.lblTipoAssistencia.TabIndex = 26
        Me.lblTipoAssistencia.Text = "Tipo Assistência (Marcar/Desm.Tudo=Clique Duplo)"
        Me.lblTipoAssistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Lançado"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(590, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 18)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Enviado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(918, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 21)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Cobrado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCabecalho31
        '
        Me.txtCabecalho31.Location = New System.Drawing.Point(988, 84)
        Me.txtCabecalho31.Name = "txtCabecalho31"
        Me.txtCabecalho31.ReadOnly = True
        Me.txtCabecalho31.Size = New System.Drawing.Size(242, 20)
        Me.txtCabecalho31.TabIndex = 30
        Me.txtCabecalho31.TabStop = False
        '
        'dtgLancamentosCobrados
        '
        Me.dtgLancamentosCobrados.AllowUserToAddRows = False
        Me.dtgLancamentosCobrados.AllowUserToDeleteRows = False
        Me.dtgLancamentosCobrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLancamentosCobrados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        Me.dtgLancamentosCobrados.Location = New System.Drawing.Point(918, 106)
        Me.dtgLancamentosCobrados.Name = "dtgLancamentosCobrados"
        Me.dtgLancamentosCobrados.ReadOnly = True
        Me.dtgLancamentosCobrados.Size = New System.Drawing.Size(312, 303)
        Me.dtgLancamentosCobrados.TabIndex = 32
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "MX"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'btProcessarEnviados
        '
        Me.btProcessarEnviados.BackColor = System.Drawing.SystemColors.Control
        Me.btProcessarEnviados.Image = Global.WinASS.My.Resources.Resources._7689_16x16
        Me.btProcessarEnviados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btProcessarEnviados.Location = New System.Drawing.Point(765, 415)
        Me.btProcessarEnviados.Name = "btProcessarEnviados"
        Me.btProcessarEnviados.Size = New System.Drawing.Size(94, 22)
        Me.btProcessarEnviados.TabIndex = 34
        Me.btProcessarEnviados.Text = "Processar"
        Me.btProcessarEnviados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btProcessarEnviados.UseVisualStyleBackColor = False
        '
        'pbProgresso
        '
        Me.pbProgresso.Location = New System.Drawing.Point(12, 440)
        Me.pbProgresso.Name = "pbProgresso"
        Me.pbProgresso.Size = New System.Drawing.Size(1218, 23)
        Me.pbProgresso.TabIndex = 36
        '
        'txtCabecalho10
        '
        Me.txtCabecalho10.Location = New System.Drawing.Point(330, 59)
        Me.txtCabecalho10.Name = "txtCabecalho10"
        Me.txtCabecalho10.ReadOnly = True
        Me.txtCabecalho10.Size = New System.Drawing.Size(242, 20)
        Me.txtCabecalho10.TabIndex = 39
        Me.txtCabecalho10.TabStop = False
        '
        'txtCabecalho20
        '
        Me.txtCabecalho20.Location = New System.Drawing.Point(660, 57)
        Me.txtCabecalho20.Name = "txtCabecalho20"
        Me.txtCabecalho20.ReadOnly = True
        Me.txtCabecalho20.Size = New System.Drawing.Size(242, 20)
        Me.txtCabecalho20.TabIndex = 40
        Me.txtCabecalho20.TabStop = False
        '
        'txtCabecalho30
        '
        Me.txtCabecalho30.Location = New System.Drawing.Point(988, 59)
        Me.txtCabecalho30.Name = "txtCabecalho30"
        Me.txtCabecalho30.ReadOnly = True
        Me.txtCabecalho30.Size = New System.Drawing.Size(242, 20)
        Me.txtCabecalho30.TabIndex = 41
        Me.txtCabecalho30.TabStop = False
        '
        'txtData_Envio
        '
        Me.txtData_Envio.Flags = 65536
        Me.txtData_Envio.Location = New System.Drawing.Point(354, 417)
        Me.txtData_Envio.Name = "txtData_Envio"
        Me.txtData_Envio.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtData_Envio.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtData_Envio.Size = New System.Drawing.Size(76, 20)
        Me.txtData_Envio.TabIndex = 43
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl1.Location = New System.Drawing.Point(260, 417)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(88, 20)
        Me.lbl1.TabIndex = 42
        Me.lbl1.Text = "Data de Envio"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtData_Cobranca
        '
        Me.txtData_Cobranca.Flags = 65536
        Me.txtData_Cobranca.Location = New System.Drawing.Point(683, 415)
        Me.txtData_Cobranca.Name = "txtData_Cobranca"
        Me.txtData_Cobranca.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtData_Cobranca.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtData_Cobranca.Size = New System.Drawing.Size(76, 20)
        Me.txtData_Cobranca.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(590, 416)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Data Cobrança"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTipoPesquisa
        '
        Me.lbTipoPesquisa.BackColor = System.Drawing.Color.Gray
        Me.lbTipoPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbTipoPesquisa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbTipoPesquisa.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipoPesquisa.ForeColor = System.Drawing.Color.Black
        Me.lbTipoPesquisa.Location = New System.Drawing.Point(260, 28)
        Me.lbTipoPesquisa.Name = "lbTipoPesquisa"
        Me.lbTipoPesquisa.Size = New System.Drawing.Size(970, 20)
        Me.lbTipoPesquisa.TabIndex = 46
        Me.lbTipoPesquisa.Text = "Movimento"
        Me.lbTipoPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ConsolidaDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1239, 464)
        Me.Controls.Add(Me.lbTipoPesquisa)
        Me.Controls.Add(Me.txtData_Cobranca)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtData_Envio)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtCabecalho30)
        Me.Controls.Add(Me.txtCabecalho20)
        Me.Controls.Add(Me.txtCabecalho10)
        Me.Controls.Add(Me.btReverteLancamentosEnviados)
        Me.Controls.Add(Me.btReverteLancamentosCobrados)
        Me.Controls.Add(Me.pbProgresso)
        Me.Controls.Add(Me.btProcessarEnviados)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCabecalho31)
        Me.Controls.Add(Me.brBuscarLancamentosCobrados)
        Me.Controls.Add(Me.dtgLancamentosCobrados)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.clTipoAssistencia)
        Me.Controls.Add(Me.lblTipoAssistencia)
        Me.Controls.Add(Me.txtDataFinal)
        Me.Controls.Add(Me.txtDataInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btProcessarLancados)
        Me.Controls.Add(Me.txtCabecalho21)
        Me.Controls.Add(Me.txtCabecalho11)
        Me.Controls.Add(Me.btBuscarLancamentosEnviados)
        Me.Controls.Add(Me.dtgLancamentosEnviados)
        Me.Controls.Add(Me.dtgLancamentosLancados)
        Me.Controls.Add(Me.btBuscarLancamentos)
        Me.KeyPreview = True
        Me.Name = "ConsolidaDados"
        Me.Text = "Consolida Dados -Movimento"
        CType(Me.dtgLancamentosLancados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgLancamentosEnviados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgLancamentosCobrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btBuscarLancamentos As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dtgLancamentosLancados As System.Windows.Forms.DataGridView
    Friend WithEvents dtgLancamentosEnviados As System.Windows.Forms.DataGridView
    Friend WithEvents btBuscarLancamentosEnviados As System.Windows.Forms.Button
    Friend WithEvents txtCabecalho11 As System.Windows.Forms.TextBox
    Friend WithEvents txtCabecalho21 As System.Windows.Forms.TextBox
    Friend WithEvents btProcessarLancados As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDataInicio As FzFlexBox.DateTextBox
    Friend WithEvents txtDataFinal As FzFlexBox.DateTextBox
    Friend WithEvents MX As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents clTipoAssistencia As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblTipoAssistencia As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MX1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCabecalho31 As System.Windows.Forms.TextBox
    Friend WithEvents brBuscarLancamentosCobrados As System.Windows.Forms.Button
    Friend WithEvents dtgLancamentosCobrados As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btProcessarEnviados As System.Windows.Forms.Button
    Friend WithEvents pbProgresso As System.Windows.Forms.ProgressBar
    Friend WithEvents btReverteLancamentosCobrados As System.Windows.Forms.Button
    Friend WithEvents btReverteLancamentosEnviados As System.Windows.Forms.Button
    Friend WithEvents txtCabecalho10 As System.Windows.Forms.TextBox
    Friend WithEvents txtCabecalho20 As System.Windows.Forms.TextBox
    Friend WithEvents txtCabecalho30 As System.Windows.Forms.TextBox
    Friend WithEvents txtData_Envio As FzFlexBox.DateTextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtData_Cobranca As FzFlexBox.DateTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbTipoPesquisa As System.Windows.Forms.Label

End Class
