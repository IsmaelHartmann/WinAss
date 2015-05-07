<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelatorioMovimentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelatorioMovimentos))
        Me.btGeraExcel = New System.Windows.Forms.Button
        Me.btGeraArquivo = New System.Windows.Forms.Button
        Me.gpMovimentos = New System.Windows.Forms.GroupBox
        Me.cbPapel = New System.Windows.Forms.ComboBox
        Me.btGerarArquivoBRF = New System.Windows.Forms.Button
        Me.cbResumido = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbSituacaoTodos = New System.Windows.Forms.RadioButton
        Me.rbSituacaoCobrados = New System.Windows.Forms.RadioButton
        Me.rbSituacaoLancados = New System.Windows.Forms.RadioButton
        Me.rbSituacaoEnviados = New System.Windows.Forms.RadioButton
        Me.clTipoAssistencia = New System.Windows.Forms.CheckedListBox
        Me.btFechar = New System.Windows.Forms.Button
        Me.btLimpar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbDocumentos = New System.Windows.Forms.RadioButton
        Me.rbTodos = New System.Windows.Forms.RadioButton
        Me.rbCanhotos = New System.Windows.Forms.RadioButton
        Me.cbSemAnimal = New System.Windows.Forms.CheckBox
        Me.txtCodigo_Associado = New System.Windows.Forms.TextBox
        Me.txtNome_Associado = New System.Windows.Forms.TextBox
        Me.btImprimir = New System.Windows.Forms.Button
        Me.txtMatricula_Associado = New System.Windows.Forms.TextBox
        Me.btVerImpressão = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbServico = New System.Windows.Forms.RadioButton
        Me.rbAssistencia = New System.Windows.Forms.RadioButton
        Me.rbTecnico = New System.Windows.Forms.RadioButton
        Me.rbData = New System.Windows.Forms.RadioButton
        Me.cbAnimal = New FzComboBox.FzCombobox
        Me.cbTipoServico = New FzComboBox.FzCombobox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblTipoAssistencia = New System.Windows.Forms.Label
        Me.box1 = New System.Windows.Forms.GroupBox
        Me.txtDataFinal = New FzFlexBox.DateTextBox
        Me.txtDataInicio = New FzFlexBox.DateTextBox
        Me.lbDataInicial = New System.Windows.Forms.Label
        Me.lbDataFinal = New System.Windows.Forms.Label
        Me.lbTecnico = New System.Windows.Forms.Label
        Me.cbTecnico = New FzComboBox.FzCombobox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbImpressoras = New System.Windows.Forms.ComboBox
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Button1 = New System.Windows.Forms.Button
        Me.gpMovimentos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.box1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btGeraExcel
        '
        Me.btGeraExcel.BackColor = System.Drawing.SystemColors.Control
        Me.btGeraExcel.Image = CType(resources.GetObject("btGeraExcel.Image"), System.Drawing.Image)
        Me.btGeraExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btGeraExcel.Location = New System.Drawing.Point(243, 349)
        Me.btGeraExcel.Name = "btGeraExcel"
        Me.btGeraExcel.Size = New System.Drawing.Size(89, 25)
        Me.btGeraExcel.TabIndex = 1
        Me.btGeraExcel.Text = "Gerar Excel"
        Me.btGeraExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btGeraExcel.UseVisualStyleBackColor = False
        '
        'btGeraArquivo
        '
        Me.btGeraArquivo.BackColor = System.Drawing.SystemColors.Control
        Me.btGeraArquivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btGeraArquivo.Image = Global.WinASS.My.Resources.Resources._6161_16x16
        Me.btGeraArquivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btGeraArquivo.Location = New System.Drawing.Point(338, 349)
        Me.btGeraArquivo.Name = "btGeraArquivo"
        Me.btGeraArquivo.Size = New System.Drawing.Size(75, 25)
        Me.btGeraArquivo.TabIndex = 2
        Me.btGeraArquivo.Text = "Gerar Txt"
        Me.btGeraArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btGeraArquivo.UseVisualStyleBackColor = False
        '
        'gpMovimentos
        '
        Me.gpMovimentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.gpMovimentos.Controls.Add(Me.Button1)
        Me.gpMovimentos.Controls.Add(Me.cbPapel)
        Me.gpMovimentos.Controls.Add(Me.btGerarArquivoBRF)
        Me.gpMovimentos.Controls.Add(Me.cbResumido)
        Me.gpMovimentos.Controls.Add(Me.GroupBox3)
        Me.gpMovimentos.Controls.Add(Me.clTipoAssistencia)
        Me.gpMovimentos.Controls.Add(Me.btFechar)
        Me.gpMovimentos.Controls.Add(Me.btLimpar)
        Me.gpMovimentos.Controls.Add(Me.btGeraExcel)
        Me.gpMovimentos.Controls.Add(Me.GroupBox2)
        Me.gpMovimentos.Controls.Add(Me.btGeraArquivo)
        Me.gpMovimentos.Controls.Add(Me.txtCodigo_Associado)
        Me.gpMovimentos.Controls.Add(Me.txtNome_Associado)
        Me.gpMovimentos.Controls.Add(Me.btImprimir)
        Me.gpMovimentos.Controls.Add(Me.txtMatricula_Associado)
        Me.gpMovimentos.Controls.Add(Me.btVerImpressão)
        Me.gpMovimentos.Controls.Add(Me.Label5)
        Me.gpMovimentos.Controls.Add(Me.GroupBox1)
        Me.gpMovimentos.Controls.Add(Me.cbAnimal)
        Me.gpMovimentos.Controls.Add(Me.cbTipoServico)
        Me.gpMovimentos.Controls.Add(Me.Label4)
        Me.gpMovimentos.Controls.Add(Me.Label3)
        Me.gpMovimentos.Controls.Add(Me.lblTipoAssistencia)
        Me.gpMovimentos.Controls.Add(Me.box1)
        Me.gpMovimentos.Controls.Add(Me.lbTecnico)
        Me.gpMovimentos.Controls.Add(Me.cbTecnico)
        Me.gpMovimentos.Controls.Add(Me.Label1)
        Me.gpMovimentos.Controls.Add(Me.cbImpressoras)
        Me.gpMovimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpMovimentos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpMovimentos.ForeColor = System.Drawing.Color.Black
        Me.gpMovimentos.Location = New System.Drawing.Point(5, 12)
        Me.gpMovimentos.Name = "gpMovimentos"
        Me.gpMovimentos.Size = New System.Drawing.Size(787, 387)
        Me.gpMovimentos.TabIndex = 0
        Me.gpMovimentos.TabStop = False
        Me.gpMovimentos.Text = "Relatório de Movimentos"
        '
        'cbPapel
        '
        Me.cbPapel.Location = New System.Drawing.Point(397, 321)
        Me.cbPapel.Name = "cbPapel"
        Me.cbPapel.Size = New System.Drawing.Size(105, 22)
        Me.cbPapel.TabIndex = 125
        '
        'btGerarArquivoBRF
        '
        Me.btGerarArquivoBRF.BackColor = System.Drawing.SystemColors.Control
        Me.btGerarArquivoBRF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btGerarArquivoBRF.Image = Global.WinASS.My.Resources.Resources._6161_16x16
        Me.btGerarArquivoBRF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btGerarArquivoBRF.Location = New System.Drawing.Point(419, 349)
        Me.btGerarArquivoBRF.Name = "btGerarArquivoBRF"
        Me.btGerarArquivoBRF.Size = New System.Drawing.Size(96, 25)
        Me.btGerarArquivoBRF.TabIndex = 19
        Me.btGerarArquivoBRF.Text = "Gerar Txt BRF"
        Me.btGerarArquivoBRF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btGerarArquivoBRF.UseVisualStyleBackColor = False
        '
        'cbResumido
        '
        Me.cbResumido.AutoSize = True
        Me.cbResumido.Location = New System.Drawing.Point(98, 177)
        Me.cbResumido.Name = "cbResumido"
        Me.cbResumido.Size = New System.Drawing.Size(185, 18)
        Me.cbResumido.TabIndex = 13
        Me.cbResumido.Text = "Relatório resumido, só com totais"
        Me.cbResumido.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbSituacaoTodos)
        Me.GroupBox3.Controls.Add(Me.rbSituacaoCobrados)
        Me.GroupBox3.Controls.Add(Me.rbSituacaoLancados)
        Me.GroupBox3.Controls.Add(Me.rbSituacaoEnviados)
        Me.GroupBox3.Location = New System.Drawing.Point(323, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(137, 115)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Situação"
        '
        'rbSituacaoTodos
        '
        Me.rbSituacaoTodos.Checked = True
        Me.rbSituacaoTodos.Location = New System.Drawing.Point(4, 90)
        Me.rbSituacaoTodos.Name = "rbSituacaoTodos"
        Me.rbSituacaoTodos.Size = New System.Drawing.Size(72, 18)
        Me.rbSituacaoTodos.TabIndex = 3
        Me.rbSituacaoTodos.TabStop = True
        Me.rbSituacaoTodos.Text = "Todos"
        Me.rbSituacaoTodos.UseVisualStyleBackColor = True
        '
        'rbSituacaoCobrados
        '
        Me.rbSituacaoCobrados.Location = New System.Drawing.Point(4, 66)
        Me.rbSituacaoCobrados.Name = "rbSituacaoCobrados"
        Me.rbSituacaoCobrados.Size = New System.Drawing.Size(72, 18)
        Me.rbSituacaoCobrados.TabIndex = 2
        Me.rbSituacaoCobrados.Text = "Cobrados"
        Me.rbSituacaoCobrados.UseVisualStyleBackColor = True
        '
        'rbSituacaoLancados
        '
        Me.rbSituacaoLancados.Location = New System.Drawing.Point(4, 18)
        Me.rbSituacaoLancados.Name = "rbSituacaoLancados"
        Me.rbSituacaoLancados.Size = New System.Drawing.Size(72, 18)
        Me.rbSituacaoLancados.TabIndex = 0
        Me.rbSituacaoLancados.Text = "Lançados"
        Me.rbSituacaoLancados.UseVisualStyleBackColor = True
        '
        'rbSituacaoEnviados
        '
        Me.rbSituacaoEnviados.Location = New System.Drawing.Point(4, 42)
        Me.rbSituacaoEnviados.Name = "rbSituacaoEnviados"
        Me.rbSituacaoEnviados.Size = New System.Drawing.Size(72, 18)
        Me.rbSituacaoEnviados.TabIndex = 1
        Me.rbSituacaoEnviados.Text = "Enviados"
        Me.rbSituacaoEnviados.UseVisualStyleBackColor = True
        '
        'clTipoAssistencia
        '
        Me.clTipoAssistencia.CheckOnClick = True
        Me.clTipoAssistencia.FormattingEnabled = True
        Me.clTipoAssistencia.Location = New System.Drawing.Point(508, 33)
        Me.clTipoAssistencia.Name = "clTipoAssistencia"
        Me.clTipoAssistencia.Size = New System.Drawing.Size(257, 304)
        Me.clTipoAssistencia.TabIndex = 18
        '
        'btFechar
        '
        Me.btFechar.BackColor = System.Drawing.SystemColors.Control
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Image = Global.WinASS.My.Resources.Resources.porta16
        Me.btFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFechar.Location = New System.Drawing.Point(698, 349)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(67, 25)
        Me.btFechar.TabIndex = 6
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btFechar.UseVisualStyleBackColor = False
        '
        'btLimpar
        '
        Me.btLimpar.BackColor = System.Drawing.SystemColors.Control
        Me.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLimpar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.Image = CType(resources.GetObject("btLimpar.Image"), System.Drawing.Image)
        Me.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btLimpar.Location = New System.Drawing.Point(6, 349)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(64, 25)
        Me.btLimpar.TabIndex = 3
        Me.btLimpar.Text = "Limpar"
        Me.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btLimpar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbDocumentos)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbCanhotos)
        Me.GroupBox2.Controls.Add(Me.cbSemAnimal)
        Me.GroupBox2.Location = New System.Drawing.Point(168, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(149, 115)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro"
        '
        'rbDocumentos
        '
        Me.rbDocumentos.AutoSize = True
        Me.rbDocumentos.Location = New System.Drawing.Point(21, 43)
        Me.rbDocumentos.Name = "rbDocumentos"
        Me.rbDocumentos.Size = New System.Drawing.Size(101, 18)
        Me.rbDocumentos.TabIndex = 1
        Me.rbDocumentos.Text = "Só Documentos"
        Me.rbDocumentos.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(21, 19)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(54, 18)
        Me.rbTodos.TabIndex = 0
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbCanhotos
        '
        Me.rbCanhotos.AutoSize = True
        Me.rbCanhotos.Location = New System.Drawing.Point(21, 67)
        Me.rbCanhotos.Name = "rbCanhotos"
        Me.rbCanhotos.Size = New System.Drawing.Size(87, 18)
        Me.rbCanhotos.TabIndex = 2
        Me.rbCanhotos.Text = "Só Canhotos"
        Me.rbCanhotos.UseVisualStyleBackColor = True
        '
        'cbSemAnimal
        '
        Me.cbSemAnimal.AutoSize = True
        Me.cbSemAnimal.Location = New System.Drawing.Point(20, 91)
        Me.cbSemAnimal.Name = "cbSemAnimal"
        Me.cbSemAnimal.Size = New System.Drawing.Size(126, 18)
        Me.cbSemAnimal.TabIndex = 12
        Me.cbSemAnimal.Text = "Pesquisa sem animal"
        Me.cbSemAnimal.UseVisualStyleBackColor = True
        '
        'txtCodigo_Associado
        '
        Me.txtCodigo_Associado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo_Associado.Location = New System.Drawing.Point(357, 97)
        Me.txtCodigo_Associado.Name = "txtCodigo_Associado"
        Me.txtCodigo_Associado.ReadOnly = True
        Me.txtCodigo_Associado.Size = New System.Drawing.Size(72, 20)
        Me.txtCodigo_Associado.TabIndex = 5
        Me.txtCodigo_Associado.TabStop = False
        Me.txtCodigo_Associado.Visible = False
        '
        'txtNome_Associado
        '
        Me.txtNome_Associado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome_Associado.Location = New System.Drawing.Point(176, 96)
        Me.txtNome_Associado.Name = "txtNome_Associado"
        Me.txtNome_Associado.Size = New System.Drawing.Size(175, 20)
        Me.txtNome_Associado.TabIndex = 4
        '
        'btImprimir
        '
        Me.btImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btImprimir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImprimir.Image = Global.WinASS.My.Resources.Resources._778_16x16
        Me.btImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btImprimir.Location = New System.Drawing.Point(165, 349)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(72, 25)
        Me.btImprimir.TabIndex = 5
        Me.btImprimir.Text = "Imprimir"
        Me.btImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btImprimir.UseVisualStyleBackColor = False
        '
        'txtMatricula_Associado
        '
        Me.txtMatricula_Associado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMatricula_Associado.Location = New System.Drawing.Point(98, 96)
        Me.txtMatricula_Associado.Name = "txtMatricula_Associado"
        Me.txtMatricula_Associado.Size = New System.Drawing.Size(72, 20)
        Me.txtMatricula_Associado.TabIndex = 3
        '
        'btVerImpressão
        '
        Me.btVerImpressão.BackColor = System.Drawing.SystemColors.Control
        Me.btVerImpressão.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btVerImpressão.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVerImpressão.Image = Global.WinASS.My.Resources.Resources._4035_16x16
        Me.btVerImpressão.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btVerImpressão.Location = New System.Drawing.Point(76, 349)
        Me.btVerImpressão.Name = "btVerImpressão"
        Me.btVerImpressão.Size = New System.Drawing.Size(83, 25)
        Me.btVerImpressão.TabIndex = 4
        Me.btVerImpressão.Text = "Visualizar"
        Me.btVerImpressão.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btVerImpressão.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Associado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbServico)
        Me.GroupBox1.Controls.Add(Me.rbAssistencia)
        Me.GroupBox1.Controls.Add(Me.rbTecnico)
        Me.GroupBox1.Controls.Add(Me.rbData)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 115)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordem"
        '
        'rbServico
        '
        Me.rbServico.AutoSize = True
        Me.rbServico.Location = New System.Drawing.Point(4, 90)
        Me.rbServico.Name = "rbServico"
        Me.rbServico.Size = New System.Drawing.Size(62, 18)
        Me.rbServico.TabIndex = 3
        Me.rbServico.Text = "Serviço"
        Me.rbServico.UseVisualStyleBackColor = True
        '
        'rbAssistencia
        '
        Me.rbAssistencia.AutoSize = True
        Me.rbAssistencia.Location = New System.Drawing.Point(4, 66)
        Me.rbAssistencia.Name = "rbAssistencia"
        Me.rbAssistencia.Size = New System.Drawing.Size(82, 18)
        Me.rbAssistencia.TabIndex = 2
        Me.rbAssistencia.Text = "Assistencia"
        Me.rbAssistencia.UseVisualStyleBackColor = True
        '
        'rbTecnico
        '
        Me.rbTecnico.AutoSize = True
        Me.rbTecnico.Checked = True
        Me.rbTecnico.Location = New System.Drawing.Point(4, 18)
        Me.rbTecnico.Name = "rbTecnico"
        Me.rbTecnico.Size = New System.Drawing.Size(63, 18)
        Me.rbTecnico.TabIndex = 0
        Me.rbTecnico.TabStop = True
        Me.rbTecnico.Text = "Técnico"
        Me.rbTecnico.UseVisualStyleBackColor = True
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Location = New System.Drawing.Point(4, 42)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(47, 18)
        Me.rbData.TabIndex = 1
        Me.rbData.Text = "Data"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'cbAnimal
        '
        Me.cbAnimal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAnimal.ItemHeight = 14
        Me.cbAnimal.Location = New System.Drawing.Point(98, 149)
        Me.cbAnimal.Name = "cbAnimal"
        Me.cbAnimal.Size = New System.Drawing.Size(253, 22)
        Me.cbAnimal.TabIndex = 11
        '
        'cbTipoServico
        '
        Me.cbTipoServico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoServico.ItemHeight = 14
        Me.cbTipoServico.Location = New System.Drawing.Point(98, 121)
        Me.cbTipoServico.Name = "cbTipoServico"
        Me.cbTipoServico.Size = New System.Drawing.Size(253, 22)
        Me.cbTipoServico.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Animal"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tipo Serviço"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTipoAssistencia
        '
        Me.lblTipoAssistencia.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoAssistencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipoAssistencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTipoAssistencia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoAssistencia.ForeColor = System.Drawing.Color.Black
        Me.lblTipoAssistencia.Location = New System.Drawing.Point(508, 10)
        Me.lblTipoAssistencia.Name = "lblTipoAssistencia"
        Me.lblTipoAssistencia.Size = New System.Drawing.Size(257, 20)
        Me.lblTipoAssistencia.TabIndex = 6
        Me.lblTipoAssistencia.Text = "Tipo Assistência (Marcar/Desm.Tudo=Clique Duplo)"
        Me.lblTipoAssistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'box1
        '
        Me.box1.Controls.Add(Me.txtDataFinal)
        Me.box1.Controls.Add(Me.txtDataInicio)
        Me.box1.Controls.Add(Me.lbDataInicial)
        Me.box1.Controls.Add(Me.lbDataFinal)
        Me.box1.Location = New System.Drawing.Point(25, 19)
        Me.box1.Name = "box1"
        Me.box1.Size = New System.Drawing.Size(326, 46)
        Me.box1.TabIndex = 14
        Me.box1.TabStop = False
        Me.box1.Text = "Por Período"
        '
        'txtDataFinal
        '
        Me.txtDataFinal.Flags = 65536
        Me.txtDataFinal.Location = New System.Drawing.Point(231, 18)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtDataFinal.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtDataFinal.Size = New System.Drawing.Size(83, 20)
        Me.txtDataFinal.TabIndex = 3
        '
        'txtDataInicio
        '
        Me.txtDataInicio.Flags = 65536
        Me.txtDataInicio.Location = New System.Drawing.Point(74, 18)
        Me.txtDataInicio.Name = "txtDataInicio"
        Me.txtDataInicio.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtDataInicio.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtDataInicio.Size = New System.Drawing.Size(83, 20)
        Me.txtDataInicio.TabIndex = 1
        '
        'lbDataInicial
        '
        Me.lbDataInicial.BackColor = System.Drawing.Color.Transparent
        Me.lbDataInicial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDataInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataInicial.ForeColor = System.Drawing.Color.Black
        Me.lbDataInicial.Location = New System.Drawing.Point(6, 18)
        Me.lbDataInicial.Name = "lbDataInicial"
        Me.lbDataInicial.Size = New System.Drawing.Size(65, 20)
        Me.lbDataInicial.TabIndex = 0
        Me.lbDataInicial.Text = "Data Inicial"
        '
        'lbDataFinal
        '
        Me.lbDataFinal.BackColor = System.Drawing.Color.Transparent
        Me.lbDataFinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDataFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataFinal.ForeColor = System.Drawing.Color.Black
        Me.lbDataFinal.Location = New System.Drawing.Point(163, 18)
        Me.lbDataFinal.Name = "lbDataFinal"
        Me.lbDataFinal.Size = New System.Drawing.Size(65, 20)
        Me.lbDataFinal.TabIndex = 2
        Me.lbDataFinal.Text = "Data Final"
        Me.lbDataFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTecnico
        '
        Me.lbTecnico.BackColor = System.Drawing.Color.Transparent
        Me.lbTecnico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTecnico.ForeColor = System.Drawing.Color.Black
        Me.lbTecnico.Location = New System.Drawing.Point(4, 71)
        Me.lbTecnico.Name = "lbTecnico"
        Me.lbTecnico.Size = New System.Drawing.Size(88, 20)
        Me.lbTecnico.TabIndex = 0
        Me.lbTecnico.Text = "Técnico"
        Me.lbTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTecnico
        '
        Me.cbTecnico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTecnico.ItemHeight = 14
        Me.cbTecnico.Location = New System.Drawing.Point(98, 71)
        Me.cbTecnico.Name = "cbTecnico"
        Me.cbTecnico.Size = New System.Drawing.Size(253, 22)
        Me.cbTecnico.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Impressora"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbImpressoras
        '
        Me.cbImpressoras.Location = New System.Drawing.Point(79, 321)
        Me.cbImpressoras.Name = "cbImpressoras"
        Me.cbImpressoras.Size = New System.Drawing.Size(312, 22)
        Me.cbImpressoras.TabIndex = 17
        '
        'PrintDocument1
        '
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Image = Global.WinASS.My.Resources.Resources._6161_16x16
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(528, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 25)
        Me.Button1.TabIndex = 126
        Me.Button1.Text = "Gerar Txt VA"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RelatorioMovimentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(782, 411)
        Me.Controls.Add(Me.gpMovimentos)
        Me.Name = "RelatorioMovimentos"
        Me.Text = "Relatório de Movimentos"
        Me.gpMovimentos.ResumeLayout(False)
        Me.gpMovimentos.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.box1.ResumeLayout(False)
        Me.box1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btGeraExcel As System.Windows.Forms.Button
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents btGeraArquivo As System.Windows.Forms.Button
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents btVerImpressão As System.Windows.Forms.Button
    Friend WithEvents gpMovimentos As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbServico As System.Windows.Forms.RadioButton
    Friend WithEvents rbAssistencia As System.Windows.Forms.RadioButton
    Friend WithEvents rbTecnico As System.Windows.Forms.RadioButton
    Friend WithEvents rbData As System.Windows.Forms.RadioButton
    Friend WithEvents cbAnimal As FzComboBox.FzCombobox
    Friend WithEvents cbTipoServico As FzComboBox.FzCombobox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTipoAssistencia As System.Windows.Forms.Label
    Friend WithEvents box1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbDataInicial As System.Windows.Forms.Label
    Friend WithEvents lbDataFinal As System.Windows.Forms.Label
    Friend WithEvents lbTecnico As System.Windows.Forms.Label
    Friend WithEvents cbTecnico As FzComboBox.FzCombobox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbImpressoras As System.Windows.Forms.ComboBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbSemAnimal As System.Windows.Forms.CheckBox
    Friend WithEvents txtDataFinal As FzFlexBox.DateTextBox
    Friend WithEvents txtDataInicio As FzFlexBox.DateTextBox
    Friend WithEvents txtCodigo_Associado As System.Windows.Forms.TextBox
    Friend WithEvents txtNome_Associado As System.Windows.Forms.TextBox
    Friend WithEvents txtMatricula_Associado As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDocumentos As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbCanhotos As System.Windows.Forms.RadioButton
    Friend WithEvents clTipoAssistencia As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbSituacaoTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbSituacaoCobrados As System.Windows.Forms.RadioButton
    Friend WithEvents rbSituacaoLancados As System.Windows.Forms.RadioButton
    Friend WithEvents rbSituacaoEnviados As System.Windows.Forms.RadioButton
    Friend WithEvents cbResumido As System.Windows.Forms.CheckBox
    Friend WithEvents btGerarArquivoBRF As System.Windows.Forms.Button
    Friend WithEvents cbPapel As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
