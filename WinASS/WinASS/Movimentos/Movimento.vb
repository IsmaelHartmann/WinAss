Public Class Movimento
    Inherits System.Windows.Forms.Form
    Private vIncluir As Boolean
    Private vAlterar As Boolean
    Private vExcluir As Boolean
    Friend WithEvents txtValorTotal As FzNumericBox.FzNumericBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTalao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtValorVisita As FzNumericBox.FzNumericBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbPrefeitura As FzComboBox.FzCombobox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbTipoEverminacao As FzComboBox.FzCombobox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtCabecas As FzNumericBox.FzNumericBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtValorEverminacao As FzNumericBox.FzNumericBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtValorMaodeObra As FzNumericBox.FzNumericBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo_Associado As System.Windows.Forms.TextBox
    Friend WithEvents txtNome_Associado As System.Windows.Forms.TextBox
    Friend WithEvents txtMatricula_Associado As System.Windows.Forms.TextBox
    Friend WithEvents txtValorOutros As FzNumericBox.FzNumericBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtCanhoto As FzNumericBox.FzNumericBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtDataFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtDataInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSituacao As System.Windows.Forms.TextBox
    Friend WithEvents lbSituacao As System.Windows.Forms.Label
    Friend WithEvents btPesquisa As System.Windows.Forms.Button
    Public vSelecao As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required BY the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required BY the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required BY the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cbAnimal As FzComboBox.FzCombobox
    Friend WithEvents cbTipoServico As FzComboBox.FzCombobox
    Friend WithEvents cbTipoAssistencia As FzComboBox.FzCombobox
    Friend WithEvents cbTecnico As FzComboBox.FzCombobox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtValorBeneficio As FzNumericBox.FzNumericBox
    Friend WithEvents txtNTouro As System.Windows.Forms.TextBox
    Friend WithEvents txtValorSemem As FzNumericBox.FzNumericBox
    Friend WithEvents txtValorEquipamento As FzNumericBox.FzNumericBox
    Friend WithEvents txtValorServico As FzNumericBox.FzNumericBox
    Friend WithEvents txtValorMedicamento As FzNumericBox.FzNumericBox
    Friend WithEvents txtNumeroDocumento As FzNumericBox.FzNumericBox
    Friend WithEvents txtValorConducao As FzNumericBox.FzNumericBox
    Friend WithEvents txtIdMovimento As System.Windows.Forms.TextBox
    Friend WithEvents txtData As FzFlexBox.DateTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btConfirmaSelecao As System.Windows.Forms.Button
    Friend WithEvents btCancelaSelecao As System.Windows.Forms.Button
    Friend WithEvents txtDataCadastro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbUsuarioCadastro As FzComboBox.FzCombobox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpConsulta As System.Windows.Forms.TabPage
    Friend WithEvents tpManutencao As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbConter As System.Windows.Forms.RadioButton
    Friend WithEvents rbComecarPor As System.Windows.Forms.RadioButton
    Friend WithEvents rbExato As System.Windows.Forms.RadioButton
    Friend WithEvents dtgMovimentos As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents btVisualizar As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btNovo As System.Windows.Forms.Button
    Friend WithEvents Cm As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents gpDados As System.Windows.Forms.GroupBox
    Friend WithEvents btExcluir As System.Windows.Forms.Button
    Friend WithEvents btAlterar As System.Windows.Forms.Button
    Friend WithEvents btAdicionar As System.Windows.Forms.Button
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbCampo As FzComboBox.FzCombobox
    Friend WithEvents gbPesquisa As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movimento))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gpDados = New System.Windows.Forms.GroupBox
        Me.txtSituacao = New System.Windows.Forms.TextBox
        Me.lbSituacao = New System.Windows.Forms.Label
        Me.txtCanhoto = New FzNumericBox.FzNumericBox
        Me.txtValorOutros = New FzNumericBox.FzNumericBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtCodigo_Associado = New System.Windows.Forms.TextBox
        Me.txtNome_Associado = New System.Windows.Forms.TextBox
        Me.txtMatricula_Associado = New System.Windows.Forms.TextBox
        Me.txtValorMaodeObra = New FzNumericBox.FzNumericBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cbPrefeitura = New FzComboBox.FzCombobox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtCabecas = New FzNumericBox.FzNumericBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtValorEverminacao = New FzNumericBox.FzNumericBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbTipoEverminacao = New FzComboBox.FzCombobox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtValorVisita = New FzNumericBox.FzNumericBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtTalao = New System.Windows.Forms.MaskedTextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtValorTotal = New FzNumericBox.FzNumericBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtData = New FzFlexBox.DateTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtValorBeneficio = New FzNumericBox.FzNumericBox
        Me.txtNTouro = New System.Windows.Forms.TextBox
        Me.txtValorSemem = New FzNumericBox.FzNumericBox
        Me.txtValorEquipamento = New FzNumericBox.FzNumericBox
        Me.txtValorServico = New FzNumericBox.FzNumericBox
        Me.txtValorMedicamento = New FzNumericBox.FzNumericBox
        Me.txtNumeroDocumento = New FzNumericBox.FzNumericBox
        Me.txtValorConducao = New FzNumericBox.FzNumericBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbAnimal = New FzComboBox.FzCombobox
        Me.cbTipoServico = New FzComboBox.FzCombobox
        Me.cbTipoAssistencia = New FzComboBox.FzCombobox
        Me.cbTecnico = New FzComboBox.FzCombobox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btConfirmaSelecao = New System.Windows.Forms.Button
        Me.txtDataCadastro = New System.Windows.Forms.MaskedTextBox
        Me.btCancelaSelecao = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbUsuarioCadastro = New FzComboBox.FzCombobox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtIdMovimento = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtPesquisa = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbCampo = New FzComboBox.FzCombobox
        Me.gbPesquisa = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btPesquisa = New System.Windows.Forms.Button
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtDataFim = New System.Windows.Forms.DateTimePicker
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtDataInicio = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbConter = New System.Windows.Forms.RadioButton
        Me.rbComecarPor = New System.Windows.Forms.RadioButton
        Me.rbExato = New System.Windows.Forms.RadioButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tpConsulta = New System.Windows.Forms.TabPage
        Me.dtgMovimentos = New System.Windows.Forms.DataGridView
        Me.Cm = New System.Windows.Forms.DataGridViewImageColumn
        Me.tpManutencao = New System.Windows.Forms.TabPage
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.btNovo = New System.Windows.Forms.Button
        Me.btImprimir = New System.Windows.Forms.Button
        Me.btVisualizar = New System.Windows.Forms.Button
        Me.btAdicionar = New System.Windows.Forms.Button
        Me.btAlterar = New System.Windows.Forms.Button
        Me.btLimpar = New System.Windows.Forms.Button
        Me.btFechar = New System.Windows.Forms.Button
        Me.btExcluir = New System.Windows.Forms.Button
        Me.gpDados.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPesquisa.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpConsulta.SuspendLayout()
        CType(Me.dtgMovimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpManutencao.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpDados
        '
        Me.gpDados.Controls.Add(Me.txtSituacao)
        Me.gpDados.Controls.Add(Me.lbSituacao)
        Me.gpDados.Controls.Add(Me.txtCanhoto)
        Me.gpDados.Controls.Add(Me.txtValorOutros)
        Me.gpDados.Controls.Add(Me.Label28)
        Me.gpDados.Controls.Add(Me.txtCodigo_Associado)
        Me.gpDados.Controls.Add(Me.txtNome_Associado)
        Me.gpDados.Controls.Add(Me.txtMatricula_Associado)
        Me.gpDados.Controls.Add(Me.txtValorMaodeObra)
        Me.gpDados.Controls.Add(Me.Label23)
        Me.gpDados.Controls.Add(Me.cbPrefeitura)
        Me.gpDados.Controls.Add(Me.Label27)
        Me.gpDados.Controls.Add(Me.txtCabecas)
        Me.gpDados.Controls.Add(Me.Label26)
        Me.gpDados.Controls.Add(Me.txtValorEverminacao)
        Me.gpDados.Controls.Add(Me.Label25)
        Me.gpDados.Controls.Add(Me.cbTipoEverminacao)
        Me.gpDados.Controls.Add(Me.Label24)
        Me.gpDados.Controls.Add(Me.txtValorVisita)
        Me.gpDados.Controls.Add(Me.Label22)
        Me.gpDados.Controls.Add(Me.txtTalao)
        Me.gpDados.Controls.Add(Me.Label21)
        Me.gpDados.Controls.Add(Me.Label20)
        Me.gpDados.Controls.Add(Me.txtValorTotal)
        Me.gpDados.Controls.Add(Me.Label19)
        Me.gpDados.Controls.Add(Me.txtData)
        Me.gpDados.Controls.Add(Me.Label15)
        Me.gpDados.Controls.Add(Me.txtValorBeneficio)
        Me.gpDados.Controls.Add(Me.txtNTouro)
        Me.gpDados.Controls.Add(Me.txtValorSemem)
        Me.gpDados.Controls.Add(Me.txtValorEquipamento)
        Me.gpDados.Controls.Add(Me.txtValorServico)
        Me.gpDados.Controls.Add(Me.txtValorMedicamento)
        Me.gpDados.Controls.Add(Me.txtNumeroDocumento)
        Me.gpDados.Controls.Add(Me.txtValorConducao)
        Me.gpDados.Controls.Add(Me.Label16)
        Me.gpDados.Controls.Add(Me.Label17)
        Me.gpDados.Controls.Add(Me.Label18)
        Me.gpDados.Controls.Add(Me.Label13)
        Me.gpDados.Controls.Add(Me.Label14)
        Me.gpDados.Controls.Add(Me.Label12)
        Me.gpDados.Controls.Add(Me.Label11)
        Me.gpDados.Controls.Add(Me.cbAnimal)
        Me.gpDados.Controls.Add(Me.cbTipoServico)
        Me.gpDados.Controls.Add(Me.cbTipoAssistencia)
        Me.gpDados.Controls.Add(Me.cbTecnico)
        Me.gpDados.Controls.Add(Me.Label8)
        Me.gpDados.Controls.Add(Me.Label9)
        Me.gpDados.Controls.Add(Me.Label10)
        Me.gpDados.Controls.Add(Me.Label7)
        Me.gpDados.Controls.Add(Me.btConfirmaSelecao)
        Me.gpDados.Controls.Add(Me.txtDataCadastro)
        Me.gpDados.Controls.Add(Me.btCancelaSelecao)
        Me.gpDados.Controls.Add(Me.Label1)
        Me.gpDados.Controls.Add(Me.cbUsuarioCadastro)
        Me.gpDados.Controls.Add(Me.Label5)
        Me.gpDados.Controls.Add(Me.txtIdMovimento)
        Me.gpDados.Controls.Add(Me.Label3)
        Me.gpDados.Controls.Add(Me.Label6)
        Me.gpDados.Location = New System.Drawing.Point(24, 40)
        Me.gpDados.Name = "gpDados"
        Me.gpDados.Size = New System.Drawing.Size(706, 355)
        Me.gpDados.TabIndex = 0
        Me.gpDados.TabStop = False
        Me.gpDados.Text = "Informações do Movimento"
        '
        'txtSituacao
        '
        Me.txtSituacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSituacao.Location = New System.Drawing.Point(440, 325)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.ReadOnly = True
        Me.txtSituacao.Size = New System.Drawing.Size(36, 20)
        Me.txtSituacao.TabIndex = 58
        Me.txtSituacao.TabStop = False
        Me.txtSituacao.Visible = False
        '
        'lbSituacao
        '
        Me.lbSituacao.BackColor = System.Drawing.Color.Transparent
        Me.lbSituacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSituacao.ForeColor = System.Drawing.Color.Black
        Me.lbSituacao.Location = New System.Drawing.Point(238, 325)
        Me.lbSituacao.Name = "lbSituacao"
        Me.lbSituacao.Size = New System.Drawing.Size(196, 20)
        Me.lbSituacao.TabIndex = 57
        Me.lbSituacao.Text = "Situação:"
        Me.lbSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCanhoto
        '
        Me.txtCanhoto.AllowNegative = False
        Me.txtCanhoto.Location = New System.Drawing.Point(228, 168)
        Me.txtCanhoto.Name = "txtCanhoto"
        Me.txtCanhoto.NumericPrecision = 12
        Me.txtCanhoto.NumericScaleOnFocus = 0
        Me.txtCanhoto.NumericScaleOnLostFocus = 0
        Me.txtCanhoto.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCanhoto.Size = New System.Drawing.Size(88, 20)
        Me.txtCanhoto.TabIndex = 16
        Me.txtCanhoto.Text = "0"
        Me.txtCanhoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCanhoto.ZeroIsValid = True
        '
        'txtValorOutros
        '
        Me.txtValorOutros.AllowNegative = False
        Me.txtValorOutros.Location = New System.Drawing.Point(549, 260)
        Me.txtValorOutros.Name = "txtValorOutros"
        Me.txtValorOutros.NumericPrecision = 12
        Me.txtValorOutros.NumericScaleOnFocus = 2
        Me.txtValorOutros.NumericScaleOnLostFocus = 2
        Me.txtValorOutros.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorOutros.Size = New System.Drawing.Size(72, 20)
        Me.txtValorOutros.TabIndex = 52
        Me.txtValorOutros.Text = "0"
        Me.txtValorOutros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorOutros.ZeroIsValid = True
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(440, 260)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(103, 20)
        Me.Label28.TabIndex = 51
        Me.Label28.Text = "Valor Outros"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigo_Associado
        '
        Me.txtCodigo_Associado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo_Associado.Location = New System.Drawing.Point(393, 96)
        Me.txtCodigo_Associado.Name = "txtCodigo_Associado"
        Me.txtCodigo_Associado.ReadOnly = True
        Me.txtCodigo_Associado.Size = New System.Drawing.Size(28, 20)
        Me.txtCodigo_Associado.TabIndex = 9
        Me.txtCodigo_Associado.TabStop = False
        Me.txtCodigo_Associado.Visible = False
        '
        'txtNome_Associado
        '
        Me.txtNome_Associado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome_Associado.Location = New System.Drawing.Point(212, 96)
        Me.txtNome_Associado.Name = "txtNome_Associado"
        Me.txtNome_Associado.Size = New System.Drawing.Size(175, 20)
        Me.txtNome_Associado.TabIndex = 8
        '
        'txtMatricula_Associado
        '
        Me.txtMatricula_Associado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMatricula_Associado.Location = New System.Drawing.Point(134, 96)
        Me.txtMatricula_Associado.Name = "txtMatricula_Associado"
        Me.txtMatricula_Associado.Size = New System.Drawing.Size(72, 20)
        Me.txtMatricula_Associado.TabIndex = 7
        '
        'txtValorMaodeObra
        '
        Me.txtValorMaodeObra.AllowNegative = False
        Me.txtValorMaodeObra.Location = New System.Drawing.Point(549, 26)
        Me.txtValorMaodeObra.Name = "txtValorMaodeObra"
        Me.txtValorMaodeObra.NumericPrecision = 12
        Me.txtValorMaodeObra.NumericScaleOnFocus = 2
        Me.txtValorMaodeObra.NumericScaleOnLostFocus = 2
        Me.txtValorMaodeObra.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorMaodeObra.ReadOnly = True
        Me.txtValorMaodeObra.Size = New System.Drawing.Size(72, 20)
        Me.txtValorMaodeObra.TabIndex = 32
        Me.txtValorMaodeObra.TabStop = False
        Me.txtValorMaodeObra.Text = "0"
        Me.txtValorMaodeObra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorMaodeObra.ZeroIsValid = True
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(17, 122)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(111, 20)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Prefeitura/Empresa"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbPrefeitura
        '
        Me.cbPrefeitura.Location = New System.Drawing.Point(134, 120)
        Me.cbPrefeitura.Name = "cbPrefeitura"
        Me.cbPrefeitura.Size = New System.Drawing.Size(253, 22)
        Me.cbPrefeitura.TabIndex = 11
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(440, 26)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(103, 20)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "Mão de Obra"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCabecas
        '
        Me.txtCabecas.AllowNegative = False
        Me.txtCabecas.Location = New System.Drawing.Point(346, 263)
        Me.txtCabecas.Name = "txtCabecas"
        Me.txtCabecas.NumericPrecision = 12
        Me.txtCabecas.NumericScaleOnFocus = 0
        Me.txtCabecas.NumericScaleOnLostFocus = 0
        Me.txtCabecas.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCabecas.Size = New System.Drawing.Size(41, 20)
        Me.txtCabecas.TabIndex = 26
        Me.txtCabecas.Text = "0"
        Me.txtCabecas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCabecas.ZeroIsValid = True
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(280, 263)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 20)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "Cabeças"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtValorEverminacao
        '
        Me.txtValorEverminacao.AllowNegative = False
        Me.txtValorEverminacao.Location = New System.Drawing.Point(549, 49)
        Me.txtValorEverminacao.Name = "txtValorEverminacao"
        Me.txtValorEverminacao.NumericPrecision = 12
        Me.txtValorEverminacao.NumericScaleOnFocus = 2
        Me.txtValorEverminacao.NumericScaleOnLostFocus = 2
        Me.txtValorEverminacao.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorEverminacao.ReadOnly = True
        Me.txtValorEverminacao.Size = New System.Drawing.Size(72, 20)
        Me.txtValorEverminacao.TabIndex = 34
        Me.txtValorEverminacao.TabStop = False
        Me.txtValorEverminacao.Text = "0"
        Me.txtValorEverminacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorEverminacao.ZeroIsValid = True
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(440, 49)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(103, 20)
        Me.Label25.TabIndex = 33
        Me.Label25.Text = "Valor Everminação"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbTipoEverminacao
        '
        Me.cbTipoEverminacao.Location = New System.Drawing.Point(134, 263)
        Me.cbTipoEverminacao.Name = "cbTipoEverminacao"
        Me.cbTipoEverminacao.Size = New System.Drawing.Size(140, 22)
        Me.cbTipoEverminacao.TabIndex = 24
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(17, 263)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(111, 20)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "Tipo Everminação"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtValorVisita
        '
        Me.txtValorVisita.AllowNegative = False
        Me.txtValorVisita.Location = New System.Drawing.Point(549, 72)
        Me.txtValorVisita.Name = "txtValorVisita"
        Me.txtValorVisita.NumericPrecision = 12
        Me.txtValorVisita.NumericScaleOnFocus = 2
        Me.txtValorVisita.NumericScaleOnLostFocus = 2
        Me.txtValorVisita.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorVisita.Size = New System.Drawing.Size(72, 20)
        Me.txtValorVisita.TabIndex = 36
        Me.txtValorVisita.Text = "0"
        Me.txtValorVisita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorVisita.ZeroIsValid = True
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(440, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(103, 20)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "Valor Visita"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTalao
        '
        Me.txtTalao.Location = New System.Drawing.Point(134, 146)
        Me.txtTalao.Mask = "000/000,000,0"
        Me.txtTalao.Name = "txtTalao"
        Me.txtTalao.Size = New System.Drawing.Size(88, 20)
        Me.txtTalao.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(17, 146)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 20)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Talão"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(17, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(111, 20)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Associado"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtValorTotal
        '
        Me.txtValorTotal.AllowNegative = True
        Me.txtValorTotal.Enabled = False
        Me.txtValorTotal.Location = New System.Drawing.Point(549, 289)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.NumericPrecision = 12
        Me.txtValorTotal.NumericScaleOnFocus = 2
        Me.txtValorTotal.NumericScaleOnLostFocus = 2
        Me.txtValorTotal.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(72, 20)
        Me.txtValorTotal.TabIndex = 54
        Me.txtValorTotal.TabStop = False
        Me.txtValorTotal.Text = "0"
        Me.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorTotal.ZeroIsValid = True
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(440, 289)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(103, 20)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Total Valores"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtData
        '
        Me.txtData.Enabled = False
        Me.txtData.Location = New System.Drawing.Point(134, 50)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(67, 20)
        Me.txtData.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(17, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Data"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtValorBeneficio
        '
        Me.txtValorBeneficio.AllowNegative = False
        Me.txtValorBeneficio.Location = New System.Drawing.Point(549, 236)
        Me.txtValorBeneficio.Name = "txtValorBeneficio"
        Me.txtValorBeneficio.NumericPrecision = 12
        Me.txtValorBeneficio.NumericScaleOnFocus = 2
        Me.txtValorBeneficio.NumericScaleOnLostFocus = 2
        Me.txtValorBeneficio.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorBeneficio.Size = New System.Drawing.Size(72, 20)
        Me.txtValorBeneficio.TabIndex = 50
        Me.txtValorBeneficio.Text = "0"
        Me.txtValorBeneficio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorBeneficio.ZeroIsValid = True
        '
        'txtNTouro
        '
        Me.txtNTouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNTouro.Location = New System.Drawing.Point(549, 214)
        Me.txtNTouro.Name = "txtNTouro"
        Me.txtNTouro.Size = New System.Drawing.Size(72, 20)
        Me.txtNTouro.TabIndex = 48
        '
        'txtValorSemem
        '
        Me.txtValorSemem.AllowNegative = False
        Me.txtValorSemem.Location = New System.Drawing.Point(549, 191)
        Me.txtValorSemem.Name = "txtValorSemem"
        Me.txtValorSemem.NumericPrecision = 12
        Me.txtValorSemem.NumericScaleOnFocus = 2
        Me.txtValorSemem.NumericScaleOnLostFocus = 2
        Me.txtValorSemem.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorSemem.Size = New System.Drawing.Size(72, 20)
        Me.txtValorSemem.TabIndex = 46
        Me.txtValorSemem.Text = "0"
        Me.txtValorSemem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorSemem.ZeroIsValid = True
        '
        'txtValorEquipamento
        '
        Me.txtValorEquipamento.AllowNegative = False
        Me.txtValorEquipamento.Enabled = False
        Me.txtValorEquipamento.Location = New System.Drawing.Point(549, 166)
        Me.txtValorEquipamento.Name = "txtValorEquipamento"
        Me.txtValorEquipamento.NumericPrecision = 12
        Me.txtValorEquipamento.NumericScaleOnFocus = 2
        Me.txtValorEquipamento.NumericScaleOnLostFocus = 2
        Me.txtValorEquipamento.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorEquipamento.ReadOnly = True
        Me.txtValorEquipamento.Size = New System.Drawing.Size(72, 20)
        Me.txtValorEquipamento.TabIndex = 44
        Me.txtValorEquipamento.Text = "0"
        Me.txtValorEquipamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorEquipamento.ZeroIsValid = True
        '
        'txtValorServico
        '
        Me.txtValorServico.AllowNegative = False
        Me.txtValorServico.Location = New System.Drawing.Point(549, 142)
        Me.txtValorServico.Name = "txtValorServico"
        Me.txtValorServico.NumericPrecision = 12
        Me.txtValorServico.NumericScaleOnFocus = 2
        Me.txtValorServico.NumericScaleOnLostFocus = 2
        Me.txtValorServico.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorServico.Size = New System.Drawing.Size(72, 20)
        Me.txtValorServico.TabIndex = 42
        Me.txtValorServico.Text = "0"
        Me.txtValorServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorServico.ZeroIsValid = True
        '
        'txtValorMedicamento
        '
        Me.txtValorMedicamento.AllowNegative = False
        Me.txtValorMedicamento.Location = New System.Drawing.Point(549, 119)
        Me.txtValorMedicamento.Name = "txtValorMedicamento"
        Me.txtValorMedicamento.NumericPrecision = 12
        Me.txtValorMedicamento.NumericScaleOnFocus = 2
        Me.txtValorMedicamento.NumericScaleOnLostFocus = 2
        Me.txtValorMedicamento.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorMedicamento.Size = New System.Drawing.Size(72, 20)
        Me.txtValorMedicamento.TabIndex = 40
        Me.txtValorMedicamento.Text = "0"
        Me.txtValorMedicamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorMedicamento.ZeroIsValid = True
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.AllowNegative = False
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(134, 168)
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.NumericPrecision = 12
        Me.txtNumeroDocumento.NumericScaleOnFocus = 0
        Me.txtNumeroDocumento.NumericScaleOnLostFocus = 0
        Me.txtNumeroDocumento.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(88, 20)
        Me.txtNumeroDocumento.TabIndex = 15
        Me.txtNumeroDocumento.Text = "0"
        Me.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNumeroDocumento.ZeroIsValid = True
        '
        'txtValorConducao
        '
        Me.txtValorConducao.AllowNegative = False
        Me.txtValorConducao.Location = New System.Drawing.Point(549, 95)
        Me.txtValorConducao.Name = "txtValorConducao"
        Me.txtValorConducao.NumericPrecision = 12
        Me.txtValorConducao.NumericScaleOnFocus = 2
        Me.txtValorConducao.NumericScaleOnLostFocus = 2
        Me.txtValorConducao.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorConducao.Size = New System.Drawing.Size(72, 20)
        Me.txtValorConducao.TabIndex = 38
        Me.txtValorConducao.Text = "0"
        Me.txtValorConducao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorConducao.ZeroIsValid = True
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(440, 214)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 20)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Nº Touro"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(440, 191)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 20)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Valor Semem"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(440, 236)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 20)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "Valor Benefício"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(440, 166)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 20)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Valor Equipamento"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(440, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 20)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Valor Serviço"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(440, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 20)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Valor Medicamento"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(440, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 20)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Valor Condução"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbAnimal
        '
        Me.cbAnimal.Location = New System.Drawing.Point(134, 238)
        Me.cbAnimal.Name = "cbAnimal"
        Me.cbAnimal.Size = New System.Drawing.Size(253, 22)
        Me.cbAnimal.TabIndex = 22
        '
        'cbTipoServico
        '
        Me.cbTipoServico.Location = New System.Drawing.Point(134, 215)
        Me.cbTipoServico.Name = "cbTipoServico"
        Me.cbTipoServico.Size = New System.Drawing.Size(253, 22)
        Me.cbTipoServico.TabIndex = 20
        '
        'cbTipoAssistencia
        '
        Me.cbTipoAssistencia.Location = New System.Drawing.Point(134, 191)
        Me.cbTipoAssistencia.Name = "cbTipoAssistencia"
        Me.cbTipoAssistencia.Size = New System.Drawing.Size(253, 22)
        Me.cbTipoAssistencia.TabIndex = 18
        '
        'cbTecnico
        '
        Me.cbTecnico.Location = New System.Drawing.Point(134, 71)
        Me.cbTecnico.Name = "cbTecnico"
        Me.cbTecnico.Size = New System.Drawing.Size(253, 22)
        Me.cbTecnico.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(17, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Animal"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(17, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tipo de Assistência"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(17, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Tipo de Serviço"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Documento/Canhoto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btConfirmaSelecao
        '
        Me.btConfirmaSelecao.BackColor = System.Drawing.SystemColors.Control
        Me.btConfirmaSelecao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btConfirmaSelecao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConfirmaSelecao.Image = CType(resources.GetObject("btConfirmaSelecao.Image"), System.Drawing.Image)
        Me.btConfirmaSelecao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btConfirmaSelecao.Location = New System.Drawing.Point(544, 327)
        Me.btConfirmaSelecao.Name = "btConfirmaSelecao"
        Me.btConfirmaSelecao.Size = New System.Drawing.Size(74, 22)
        Me.btConfirmaSelecao.TabIndex = 55
        Me.btConfirmaSelecao.Text = "Confirma"
        Me.btConfirmaSelecao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btConfirmaSelecao.UseVisualStyleBackColor = False
        Me.btConfirmaSelecao.Visible = False
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.Enabled = False
        Me.txtDataCadastro.Location = New System.Drawing.Point(134, 301)
        Me.txtDataCadastro.Mask = "00/00/0000 90:00"
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.txtDataCadastro.Size = New System.Drawing.Size(98, 20)
        Me.txtDataCadastro.TabIndex = 28
        Me.txtDataCadastro.TabStop = False
        Me.txtDataCadastro.ValidatingType = GetType(Date)
        '
        'btCancelaSelecao
        '
        Me.btCancelaSelecao.BackColor = System.Drawing.SystemColors.Control
        Me.btCancelaSelecao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelaSelecao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelaSelecao.Image = CType(resources.GetObject("btCancelaSelecao.Image"), System.Drawing.Image)
        Me.btCancelaSelecao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCancelaSelecao.Location = New System.Drawing.Point(624, 327)
        Me.btCancelaSelecao.Name = "btCancelaSelecao"
        Me.btCancelaSelecao.Size = New System.Drawing.Size(74, 22)
        Me.btCancelaSelecao.TabIndex = 56
        Me.btCancelaSelecao.Text = "Cancela"
        Me.btCancelaSelecao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancelaSelecao.UseVisualStyleBackColor = False
        Me.btCancelaSelecao.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Data Cadastro"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbUsuarioCadastro
        '
        Me.cbUsuarioCadastro.Enabled = False
        Me.cbUsuarioCadastro.Location = New System.Drawing.Point(134, 325)
        Me.cbUsuarioCadastro.Name = "cbUsuarioCadastro"
        Me.cbUsuarioCadastro.Size = New System.Drawing.Size(98, 22)
        Me.cbUsuarioCadastro.TabIndex = 30
        Me.cbUsuarioCadastro.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Usuario Cadastro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdMovimento
        '
        Me.txtIdMovimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdMovimento.Location = New System.Drawing.Point(56, 26)
        Me.txtIdMovimento.Name = "txtIdMovimento"
        Me.txtIdMovimento.ReadOnly = True
        Me.txtIdMovimento.Size = New System.Drawing.Size(72, 20)
        Me.txtIdMovimento.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Id"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Técnico"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BackColor = System.Drawing.Color.MintCream
        Me.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesquisa.Location = New System.Drawing.Point(92, 44)
        Me.txtPesquisa.MaxLength = 50
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(183, 20)
        Me.txtPesquisa.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pesquisar p/"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Localizar"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbCampo
        '
        Me.cbCampo.BackColor = System.Drawing.Color.MintCream
        Me.cbCampo.Location = New System.Drawing.Point(92, 13)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(183, 22)
        Me.cbCampo.TabIndex = 1
        '
        'gbPesquisa
        '
        Me.gbPesquisa.BackColor = System.Drawing.Color.SteelBlue
        Me.gbPesquisa.Controls.Add(Me.GroupBox2)
        Me.gbPesquisa.Controls.Add(Me.GroupBox1)
        Me.gbPesquisa.Controls.Add(Me.Label2)
        Me.gbPesquisa.Controls.Add(Me.cbCampo)
        Me.gbPesquisa.Controls.Add(Me.txtPesquisa)
        Me.gbPesquisa.Controls.Add(Me.Label4)
        Me.gbPesquisa.Location = New System.Drawing.Point(7, 6)
        Me.gbPesquisa.Name = "gbPesquisa"
        Me.gbPesquisa.Size = New System.Drawing.Size(744, 75)
        Me.gbPesquisa.TabIndex = 0
        Me.gbPesquisa.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btPesquisa)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.txtDataFim)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.txtDataInicio)
        Me.GroupBox2.Location = New System.Drawing.Point(403, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 75)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Período"
        '
        'btPesquisa
        '
        Me.btPesquisa.AutoSize = True
        Me.btPesquisa.BackColor = System.Drawing.SystemColors.Control
        Me.btPesquisa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPesquisa.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPesquisa.Image = Global.WinASS.My.Resources.Resources._4035_16x16
        Me.btPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPesquisa.Location = New System.Drawing.Point(175, 42)
        Me.btPesquisa.Name = "btPesquisa"
        Me.btPesquisa.Size = New System.Drawing.Size(77, 25)
        Me.btPesquisa.TabIndex = 8
        Me.btPesquisa.Text = "Pesquisar"
        Me.btPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPesquisa.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.LightBlue
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(15, 42)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(50, 20)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Fim"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDataFim
        '
        Me.txtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataFim.Location = New System.Drawing.Point(71, 42)
        Me.txtDataFim.Name = "txtDataFim"
        Me.txtDataFim.Size = New System.Drawing.Size(98, 20)
        Me.txtDataFim.TabIndex = 6
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.LightBlue
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(15, 17)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(50, 20)
        Me.Label30.TabIndex = 5
        Me.Label30.Text = "Inicio"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDataInicio
        '
        Me.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataInicio.Location = New System.Drawing.Point(71, 17)
        Me.txtDataInicio.Name = "txtDataInicio"
        Me.txtDataInicio.Size = New System.Drawing.Size(98, 20)
        Me.txtDataInicio.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbConter)
        Me.GroupBox1.Controls.Add(Me.rbComecarPor)
        Me.GroupBox1.Controls.Add(Me.rbExato)
        Me.GroupBox1.Location = New System.Drawing.Point(281, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 75)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleção"
        '
        'rbConter
        '
        Me.rbConter.AutoSize = True
        Me.rbConter.Location = New System.Drawing.Point(6, 49)
        Me.rbConter.Name = "rbConter"
        Me.rbConter.Size = New System.Drawing.Size(71, 18)
        Me.rbConter.TabIndex = 2
        Me.rbConter.Text = "Contendo"
        Me.rbConter.UseVisualStyleBackColor = True
        '
        'rbComecarPor
        '
        Me.rbComecarPor.AutoSize = True
        Me.rbComecarPor.Checked = True
        Me.rbComecarPor.Location = New System.Drawing.Point(6, 33)
        Me.rbComecarPor.Name = "rbComecarPor"
        Me.rbComecarPor.Size = New System.Drawing.Size(87, 18)
        Me.rbComecarPor.TabIndex = 1
        Me.rbComecarPor.TabStop = True
        Me.rbComecarPor.Text = "Começar Por"
        Me.rbComecarPor.UseVisualStyleBackColor = True
        '
        'rbExato
        '
        Me.rbExato.AutoSize = True
        Me.rbExato.Location = New System.Drawing.Point(6, 17)
        Me.rbExato.Name = "rbExato"
        Me.rbExato.Size = New System.Drawing.Size(52, 18)
        Me.rbExato.TabIndex = 0
        Me.rbExato.Text = "Exato"
        Me.rbExato.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpConsulta)
        Me.TabControl1.Controls.Add(Me.tpManutencao)
        Me.TabControl1.Location = New System.Drawing.Point(7, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(765, 472)
        Me.TabControl1.TabIndex = 0
        '
        'tpConsulta
        '
        Me.tpConsulta.Controls.Add(Me.dtgMovimentos)
        Me.tpConsulta.Controls.Add(Me.gbPesquisa)
        Me.tpConsulta.Location = New System.Drawing.Point(4, 23)
        Me.tpConsulta.Name = "tpConsulta"
        Me.tpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConsulta.Size = New System.Drawing.Size(757, 445)
        Me.tpConsulta.TabIndex = 0
        Me.tpConsulta.Text = "Consulta"
        Me.tpConsulta.UseVisualStyleBackColor = True
        '
        'dtgMovimentos
        '
        Me.dtgMovimentos.AllowUserToAddRows = False
        Me.dtgMovimentos.AllowUserToDeleteRows = False
        Me.dtgMovimentos.AllowUserToOrderColumns = True
        Me.dtgMovimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgMovimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtgMovimentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgMovimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMovimentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cm})
        Me.dtgMovimentos.Location = New System.Drawing.Point(7, 87)
        Me.dtgMovimentos.Name = "dtgMovimentos"
        Me.dtgMovimentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgMovimentos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgMovimentos.Size = New System.Drawing.Size(744, 335)
        Me.dtgMovimentos.TabIndex = 1
        '
        'Cm
        '
        Me.Cm.HeaderText = "Cm"
        Me.Cm.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Cm.Name = "Cm"
        Me.Cm.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'tpManutencao
        '
        Me.tpManutencao.Controls.Add(Me.gpDados)
        Me.tpManutencao.Location = New System.Drawing.Point(4, 22)
        Me.tpManutencao.Name = "tpManutencao"
        Me.tpManutencao.Padding = New System.Windows.Forms.Padding(3)
        Me.tpManutencao.Size = New System.Drawing.Size(757, 446)
        Me.tpManutencao.TabIndex = 1
        Me.tpManutencao.Text = "Manutenção"
        Me.tpManutencao.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'btNovo
        '
        Me.btNovo.BackColor = System.Drawing.SystemColors.Control
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.Image = Global.WinASS.My.Resources.Resources._7687_16x16
        Me.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovo.Location = New System.Drawing.Point(7, 1)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(77, 25)
        Me.btNovo.TabIndex = 0
        Me.btNovo.Text = "Novo (F2)"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btNovo.UseVisualStyleBackColor = False
        '
        'btImprimir
        '
        Me.btImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btImprimir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImprimir.Image = Global.WinASS.My.Resources.Resources._778_16x16
        Me.btImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btImprimir.Location = New System.Drawing.Point(696, 1)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(72, 25)
        Me.btImprimir.TabIndex = 7
        Me.btImprimir.Text = "Imprimir"
        Me.btImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btImprimir.UseVisualStyleBackColor = False
        '
        'btVisualizar
        '
        Me.btVisualizar.BackColor = System.Drawing.SystemColors.Control
        Me.btVisualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btVisualizar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVisualizar.Image = Global.WinASS.My.Resources.Resources._4035_16x16
        Me.btVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btVisualizar.Location = New System.Drawing.Point(618, 1)
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(72, 25)
        Me.btVisualizar.TabIndex = 6
        Me.btVisualizar.Text = "Ver (F9)"
        Me.btVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btVisualizar.UseVisualStyleBackColor = False
        '
        'btAdicionar
        '
        Me.btAdicionar.BackColor = System.Drawing.SystemColors.Control
        Me.btAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAdicionar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionar.Image = CType(resources.GetObject("btAdicionar.Image"), System.Drawing.Image)
        Me.btAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btAdicionar.Location = New System.Drawing.Point(90, 1)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(104, 25)
        Me.btAdicionar.TabIndex = 1
        Me.btAdicionar.Text = "Adicionar (F5)"
        Me.btAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAdicionar.UseVisualStyleBackColor = False
        '
        'btAlterar
        '
        Me.btAlterar.BackColor = System.Drawing.SystemColors.Control
        Me.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAlterar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAlterar.Image = CType(resources.GetObject("btAlterar.Image"), System.Drawing.Image)
        Me.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btAlterar.Location = New System.Drawing.Point(200, 1)
        Me.btAlterar.Name = "btAlterar"
        Me.btAlterar.Size = New System.Drawing.Size(86, 25)
        Me.btAlterar.TabIndex = 2
        Me.btAlterar.Text = "Alterar (F3)"
        Me.btAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAlterar.UseVisualStyleBackColor = False
        '
        'btLimpar
        '
        Me.btLimpar.BackColor = System.Drawing.SystemColors.Control
        Me.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLimpar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.Image = CType(resources.GetObject("btLimpar.Image"), System.Drawing.Image)
        Me.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btLimpar.Location = New System.Drawing.Point(384, 1)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(86, 25)
        Me.btLimpar.TabIndex = 4
        Me.btLimpar.Text = "Limpar (F6)"
        Me.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btLimpar.UseVisualStyleBackColor = False
        '
        'btFechar
        '
        Me.btFechar.BackColor = System.Drawing.SystemColors.Control
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFechar.Location = New System.Drawing.Point(476, 1)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(95, 25)
        Me.btFechar.TabIndex = 5
        Me.btFechar.Text = "Fechar (F10)"
        Me.btFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btFechar.UseVisualStyleBackColor = False
        '
        'btExcluir
        '
        Me.btExcluir.BackColor = System.Drawing.SystemColors.Control
        Me.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btExcluir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExcluir.Image = CType(resources.GetObject("btExcluir.Image"), System.Drawing.Image)
        Me.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btExcluir.Location = New System.Drawing.Point(292, 1)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(86, 25)
        Me.btExcluir.TabIndex = 3
        Me.btExcluir.Text = "Excluir (F4)"
        Me.btExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btExcluir.UseVisualStyleBackColor = False
        '
        'Movimento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(784, 504)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.btVisualizar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btAdicionar)
        Me.Controls.Add(Me.btAlterar)
        Me.Controls.Add(Me.btLimpar)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.btExcluir)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(230, 176)
        Me.Name = "Movimento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Movimentos"
        Me.gpDados.ResumeLayout(False)
        Me.gpDados.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPesquisa.ResumeLayout(False)
        Me.gbPesquisa.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpConsulta.ResumeLayout(False)
        CType(Me.dtgMovimentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpManutencao.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public objMovimento_Implem As Movimento_Implem = MovimentoBOFactory.GetFactory().GetInstance()
    Public objAssociados_Implem As Associados_Implem = AssociadosBOFactory.GetFactory().GetInstance()
    Public objParametros_Implem As Parametros_Implem = ParametrosBOFactory.GetFactory().GetInstance()
    Public objTiposServico_Implem As TiposServicos_Implem = TiposServicosBOFactory.GetFactory().GetInstance()


#Region " Inicializações "

    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtPesquisa.Focus()
    End Sub

    Private Sub Movimentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim autoriza As Boolean
        autoriza = VerificaPrograma("Movimentos", VariaveisGlobais.gSetorUsuario, _
            VariaveisGlobais.gTipoUsuario, VariaveisGlobais.gLoginUsuario)
        If autoriza = False Then
            MessageBox.Show("Usuário não Autorizado ! " & Me.Name)
            Me.Enabled = False
            Me.Close()
        Else
            vIncluir = VariaveisGlobais.gIncluir
            vAlterar = VariaveisGlobais.gAlterar
            vExcluir = VariaveisGlobais.gExcluir
        End If
        AjustaTela(Me)

        Try
            Dim wControle As Integer

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Me.Close()
            End If
            objVariaveisGlobais.PreencheComboBox(cbUsuarioCadastro, VariaveisGlobais.gConexao, _
                      " SELECT Id_Usuario, " & _
                      " CAST(Nome AS VARCHAR) Nome " & _
                      " FROM C_Usuarios " & _
                      " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
                      " ORDER BY Nome ", "")
            cbUsuarioCadastro.SelectedIndex = 0

            Dim c As New System.Web.UI.WebControls.ListItem
            c.Value = "" : c.Text = " Selecione..." : cbTipoEverminacao.Items.Add(c)
            c = New System.Web.UI.WebControls.ListItem
            c.Value = "1" : c.Text = "1 Vermifugo" : cbTipoEverminacao.Items.Add(c)
            c = New System.Web.UI.WebControls.ListItem
            c.Value = "2" : c.Text = "2 Bernicida" : cbTipoEverminacao.Items.Add(c)
            c = New System.Web.UI.WebControls.ListItem
            c.Value = "3" : c.Text = "3 Fasciolicida" : cbTipoEverminacao.Items.Add(c)
            c = New System.Web.UI.WebControls.ListItem
            c.Value = "4" : c.Text = "4 Vacina Leitões" : cbTipoEverminacao.Items.Add(c)
            cbTipoEverminacao.SelectedIndex = 0

            wControle = objVariaveisGlobais.PreencheComboBox(cbTecnico, VariaveisGlobais.gConexao, _
            " SELECT Codigo, Nome " & _
            " FROM Ass_Tecnicos " & _
            " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
            " ORDER BY Nome ", "")
            If wControle <> 0 Then
                MsgBox(VariaveisGlobais.gDescricaoUltimoErro)
            End If

            'wControle = objVariaveisGlobais.PreencheComboBox(cbAssociado, VariaveisGlobais.gConexao, _
            '" SELECT Codigo, CAST(SUBSTRING(Matricula,1,LEN(Matricula)-1) + ' ' + Nome AS VARCHAR(100)) FROM Ass_Associados WHERE isnull(Data_Hora_Exclusao,'') = '' ORDER BY Nome ", "")
            'If wControle <> 0 Then
            '    MsgBox(VariaveisGlobais.gDescricaoUltimoErro)
            'End If

            wControle = objVariaveisGlobais.PreencheComboBox(cbPrefeitura, VariaveisGlobais.gConexao, _
            " SELECT CodigoCidade , NomeCidade " & _
            " FROM C_Cidades " & _
            " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
            " ORDER BY NomeCidade ", "")
            If wControle <> 0 Then
                MsgBox(VariaveisGlobais.gDescricaoUltimoErro)
            End If

            wControle = objVariaveisGlobais.PreencheComboBox(cbTipoAssistencia, VariaveisGlobais.gConexao, _
            "SELECT Codigo, Descricao  " & _
            " FROM Ass_TipoAssistencia " & _
            " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
            " ORDER BY Descricao ", "")
            If wControle <> 0 Then
                MsgBox(VariaveisGlobais.gDescricaoUltimoErro)
            End If

            wControle = objVariaveisGlobais.PreencheComboBox(cbTipoServico, VariaveisGlobais.gConexao, _
            "SELECT Codigo, Descricao " & _
            " FROM Ass_TipoServico " & _
            " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
            " ORDER BY Descricao ", "")
            If wControle <> 0 Then
                MsgBox(VariaveisGlobais.gDescricaoUltimoErro)
            End If

            wControle = objVariaveisGlobais.PreencheComboBox(cbAnimal, VariaveisGlobais.gConexao, _
            " SELECT Codigo, Nome " & _
            " FROM Ass_Animais " & _
            " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
            " ORDER BY Nome ", "")
            If wControle <> 0 Then
                MsgBox(VariaveisGlobais.gDescricaoUltimoErro)
            End If
            txtDataInicio.Text = "01/" & Today.Month & "/" & Today.Year
            txtDataFim.Text = Date.DaysInMonth(Today.Year, Today.Month) & "/" & Today.Month & "/" & Today.Year

            LimpaTela()

            If vSelecao <> "" Then
                btCancelaSelecao.Visible = True
                btConfirmaSelecao.Visible = True
                objVariaveisGlobais.SetaComboBox(cbCampo, vSelecao)
                If dtgMovimentos.Rows.Count = 1 Then
                    dtgMovimentos.Rows(0).Selected = True
                    Me.Close()
                End If
            Else
                btCancelaSelecao.Visible = False
                btConfirmaSelecao.Visible = False
            End If

            wControle = objParametros_Implem.BuscarParametro
            If wControle <> 0 Then
                MsgBox("Erro ao ler Parâmetros: " & VariaveisGlobais.gDescricaoUltimoErro)
                Exit Sub
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub CadastroMovimentos_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        objMovimento_Implem = Nothing
        LimpaErros()
    End Sub

    Private Sub Tecnicos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F1 Then
            objLeituras.VerC_LOG(VariaveisGlobais.gBD, "C_LOG", "Ass_Movimento", txtIdMovimento.Text)
        End If
        If e.KeyCode = Keys.F2 Then
            btNovo.PerformClick()
        End If
        If e.KeyCode = Keys.F5 Then
            btAdicionar.PerformClick()
        End If
        If e.KeyCode = Keys.F3 Then
            btAlterar.PerformClick()
        End If
        If e.KeyCode = Keys.F4 Then
            btExcluir.PerformClick()
        End If
        If e.KeyCode = Keys.F6 Then
            btLimpar.PerformClick()
        End If
        If e.KeyCode = Keys.F10 Then
            btFechar.PerformClick()
        End If
        If e.KeyCode = Keys.F9 Then
            btVisualizar.PerformClick()
        End If
        If e.KeyCode = Keys.Enter And dtgMovimentos.Focused Then
            TelaAlteracaoMovimentos()
            If btConfirmaSelecao.Visible = True Then
                Me.Dispose()
            Else
            End If
        End If
        If e.KeyCode = Keys.Down And txtPesquisa.Focused Then
            dtgMovimentos.Focus()
        End If

        If e.KeyCode = Keys.Escape Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
    End Sub

    Private Sub MyBase_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        Dim wControle As Integer
        wControle = objVariaveisGlobais.FechaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
        If wControle <> 0 Then
            objVariaveisGlobais.MostraErro()
        End If
    End Sub

    Protected Overrides Sub OnLocationChanged(ByVal e As System.EventArgs)
        Dim p As New Point(0, 0)
        Me.Location = p
    End Sub

#End Region

#Region " Adicionar/Alterar /Excluir Empresa "

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        LimpaTela(True)
    End Sub

    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click
        AdicionarMovimento()
    End Sub

    Private Sub btAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAlterar.Click
        Alterar()
    End Sub

    Private Sub btExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluir.Click
        Excluir()
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Public Function GuardaDadosMovimentos() As Integer
        Try
            objMovimento_Implem = New Movimento_Implem

            objMovimento_Implem.IdMovimento = txtIdMovimento.Text
            objMovimento_Implem.Data = txtData.Text
            objMovimento_Implem.Tecnico = cbTecnico.SelectedItem.value
            'objMovimento_Implem.Associado = cbAssociado.SelectedItem.value
            objMovimento_Implem.Associado = txtCodigo_Associado.Text
            objMovimento_Implem.Documento = SoNumero(txtNumeroDocumento.Text)
            objMovimento_Implem.Canhoto = SoNumero(txtCanhoto.Text)
            objMovimento_Implem.TipoAssistencia = cbTipoAssistencia.SelectedItem.value
            objMovimento_Implem.TipoServico = cbTipoServico.SelectedItem.value
            objMovimento_Implem.Animal = cbAnimal.SelectedItem.value
            objMovimento_Implem.Prefeitura = cbPrefeitura.SelectedItem.value
            objMovimento_Implem.Talao = txtTalao.Text
            objMovimento_Implem.TipoEverminacao = cbTipoEverminacao.SelectedItem.value
            objMovimento_Implem.Cabecas = txtCabecas.Text
            objMovimento_Implem.Situacao = txtSituacao.Text

            objMovimento_Implem.ValorOutros = txtValorOutros.Text
            objMovimento_Implem.ValorMaodeObra = txtValorMaodeObra.Text
            objMovimento_Implem.ValorEverminacao = txtValorEverminacao.Text
            objMovimento_Implem.ValorVisita = txtValorVisita.Text
            objMovimento_Implem.ValorConducao = txtValorConducao.Text
            objMovimento_Implem.ValorMedicamento = txtValorMedicamento.Text
            objMovimento_Implem.ValorServico = txtValorServico.Text
            objMovimento_Implem.ValorEquipamento = txtValorEquipamento.Text
            objMovimento_Implem.ValorBeneficio = txtValorBeneficio.Text
            objMovimento_Implem.ValorSemem = txtValorSemem.Text
            objMovimento_Implem.NTouro = txtNTouro.Text

            objMovimento_Implem.Codigo_Usuario_Cadastro = cbUsuarioCadastro.SelectedItem.value

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Sub TelaAlteracaoMovimentos()
        Try
            Dim wControle As Integer
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Me.Close()
            End If
            cbTipoEverminacao.SelectedIndex = 0
            cbTipoServico.SelectedIndex = 0
            cbAnimal.SelectedIndex = 0

            LimpaErros()

            TabControl1.SelectedIndex = 1
            tpManutencao.Enabled = True

            txtIdMovimento.Text = objMovimento_Implem.IdMovimento
            'objVariaveisGlobais.SetaComboBox(cbAssociado, objMovimento_Implem.Associado)
            objAssociados_Implem.Codigo = objMovimento_Implem.Associado
            wControle = objAssociados_Implem.BuscarAssociado()
            If wControle < 0 Then
                objVariaveisGlobais.MostraErro()
            ElseIf wControle = 1 Then
                MsgBox("Associado não encontrado no BD!")
            ElseIf wControle = 0 Then
                txtCodigo_Associado.Text = objAssociados_Implem.Codigo
                txtNome_Associado.Text = objAssociados_Implem.NomeAssociado
                txtMatricula_Associado.Text = objAssociados_Implem.Matricula
            End If

            txtTalao.Text = objMovimento_Implem.Talao
            txtCanhoto.Text = objMovimento_Implem.Canhoto
            txtCabecas.Text = objMovimento_Implem.Cabecas
            txtSituacao.Text = objMovimento_Implem.Situacao
            If txtSituacao.Text = "L" Then
                lbSituacao.Text = "Situação: Lançado"
            ElseIf txtSituacao.Text = "E" Then
                lbSituacao.Text = "Situação: Enviado"
            ElseIf txtSituacao.Text = "C" Then
                lbSituacao.Text = "Situação: Cobrado"
            End If

            txtData.Text = ConverteDataParaString(objMovimento_Implem.Data)
            objVariaveisGlobais.SetaComboBox(cbTecnico, objMovimento_Implem.Tecnico)
            txtNumeroDocumento.Text = objMovimento_Implem.Documento
            objVariaveisGlobais.SetaComboBox(cbTipoAssistencia, objMovimento_Implem.TipoAssistencia)
            objVariaveisGlobais.SetaComboBox(cbTipoServico, objMovimento_Implem.TipoServico)
            objVariaveisGlobais.SetaComboBox(cbAnimal, objMovimento_Implem.Animal)
            objVariaveisGlobais.SetaComboBox(cbPrefeitura, objMovimento_Implem.Prefeitura)
            objVariaveisGlobais.SetaComboBox(cbTipoEverminacao, objMovimento_Implem.TipoEverminacao)

            txtValorOutros.Text = objMovimento_Implem.ValorOutros
            txtValorMaodeObra.Text = objMovimento_Implem.ValorMaodeObra
            txtValorEverminacao.Text = objMovimento_Implem.ValorEverminacao
            txtValorVisita.Text = objMovimento_Implem.ValorVisita
            txtValorConducao.Text = objMovimento_Implem.ValorConducao
            txtValorMedicamento.Text = objMovimento_Implem.ValorMedicamento
            txtValorServico.Text = objMovimento_Implem.ValorServico
            txtValorEquipamento.Text = objMovimento_Implem.ValorEquipamento
            txtValorBeneficio.Text = objMovimento_Implem.ValorBeneficio
            txtValorSemem.Text = objMovimento_Implem.ValorSemem
            txtNTouro.Text = objMovimento_Implem.NTouro

            AtualizaValores()

            txtDataCadastro.Text = ConverteDataHoraParaString(objMovimento_Implem.Data_Hora_Cadastro)
            objVariaveisGlobais.SetaComboBox(cbUsuarioCadastro, objMovimento_Implem.Codigo_Usuario_Cadastro)

            btExcluir.Enabled = vExcluir
            btAlterar.Enabled = vAlterar
            btAdicionar.Enabled = False
            btNovo.Enabled = False
            btLimpar.Enabled = True

            Windows.Forms.Cursor.Current = Cursors.Default

            txtData.Focus() : txtData.SelectionLength = 0

        Catch ex As Exception

            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Me.Close()

        End Try

    End Sub

    Public Sub AdicionarMovimento()
        Try

            Dim wControle As Integer
            wControle = ValidaDados()
            If wControle <> 0 Then Exit Sub

            GuardaDadosMovimentos()
            wControle = objMovimento_Implem.IncluirMovimento
            If wControle = 1 Then
                MessageBox.Show("Já existe um Movimento cadastrado para este dia com este Técnico e Documento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If

            MessageBox.Show("Movimento incluído com sucesso! Id Movimento: " & _
                        objMovimento_Implem.IdMovimento, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpaTela()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Public Sub Alterar()
        Dim wControle As Integer
        Try

            wControle = ValidaDados()
            If wControle < 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            If wControle <> 0 Then Exit Sub

            wControle = GuardaDadosMovimentos()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If

            wControle = objMovimento_Implem.AlterarMovimento
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Dados do Movimento modificados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpaTela()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try

    End Sub

    Private Sub Excluir()
        Dim wMensagem As DialogResult
        Dim wControle As Integer

        wMensagem = MessageBox.Show("TODOS Dados relacionados a esse Movimento serão permanentemente excluídos!" & vbCrLf & " Você deseja excluir este Movimento? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If (wMensagem = Windows.Forms.DialogResult.Yes) Then
            objMovimento_Implem.IdMovimento = txtIdMovimento.Text
            wControle = objMovimento_Implem.ExcluirMovimento
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Movimento excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LimpaTela()

    End Sub

#End Region

#Region " Atualização do DataGrid e do Form "

    Private Sub AtualizaMovimentos()

        Dim wControle As Integer

        Dim wSQL As String = " SELECT M.IdMovimento, M.Data, T.Nome, AA.Nome, " & _
                    " M.Documento, Ass.Descricao TipoDeAssistencia, " & _
                    " TS.Descricao TipoDeServico, An.Nome Animal   " & _
                    " FROM Ass_Tecnicos T,Ass_TipoAssistencia Ass, " & _
                    " Ass_TipoServico TS, Ass_Associados AA, Ass_Movimento M " & _
                    " LEFT JOIN Ass_Animais An ON M.Animal = An.Codigo " & _
                    " WHERE M.Tecnico = T.Codigo  " & _
                    " AND M.TipoAssistencia = Ass.Codigo " & _
                    " AND M.Associado = AA.Codigo " & _
                    " AND M.TipoServico = TS.Codigo " & _
                    " AND isnull(M.Data_Hora_Exclusao,'') = '' " & _
                    " AND M.Data between '" & txtDataInicio.Value & "' AND '" & txtDataFim.Value & "' " & _
                    " ORDER BY M.Data DESC, M.Prefeitura "
        '" ORDER BY T.Nome,M.Documento "

        wControle = objMovimento_Implem.MostraTabelaMovimentos(dtgMovimentos, wSQL)
        If wControle <> 0 Then objVariaveisGlobais.MostraErro()
        PreencheCampoPesquisa()
        FazFiltro()

    End Sub

    Private Sub PreencheCampoPesquisa()
        If cbCampo.Items.Count = 0 Then
            Dim c As New System.Web.UI.WebControls.ListItem
            For i As Integer = 0 To dtgMovimentos.Columns.Count - 1
                If dtgMovimentos.Columns(i).ValueType.ToString = GetType(String).ToString AndAlso dtgMovimentos.Columns(i).Visible = True Then
                    c = New System.Web.UI.WebControls.ListItem
                    c.Value = dtgMovimentos.Columns(i).HeaderText
                    c.Text = dtgMovimentos.Columns(i).HeaderText
                    cbCampo.Items.Add(c)
                End If
            Next
            cbCampo.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtPesquisaNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.TextChanged
        FazFiltro()
    End Sub

    Private Sub cbTecnicosPesquisaEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCampo.SelectedIndexChanged
        FazFiltro()
    End Sub

    Private Sub SELECAO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles rbExato.CheckedChanged, rbComecarPor.CheckedChanged, rbConter.CheckedChanged
        FazFiltro()
    End Sub

    Function FazFiltro()
        If Not IsNothing(dtgMovimentos.DataSource) Then
            Dim wDataTable As New DataTable
            Dim wPesquisa As String = ""

            If rbComecarPor.Checked Then
                wPesquisa = cbCampo.Text & " like '" & txtPesquisa.Text & "%'"
            ElseIf rbConter.Checked Then
                wPesquisa = cbCampo.Text & " like '%" & txtPesquisa.Text & "%'"
            ElseIf rbExato.Checked Then
                wPesquisa = cbCampo.Text & " ='" & txtPesquisa.Text & "'"
            End If

            Dim wValida As Boolean
            For i As Integer = 0 To dtgMovimentos.Columns.Count - 1
                If dtgMovimentos.Columns(i).Name = cbCampo.Text Then
                    wValida = True
                    Exit For
                End If
            Next

            If wValida = False Then
                MsgBox("Campo pesquisa está incorreto")
                Return wValida
            End If

            wDataTable = objMovimento_Implem.wDataSet.Tables(0)
            Dim wDataView = New DataView(wDataTable, _
                     wPesquisa, _
                     "", DataViewRowState.CurrentRows)
            dtgMovimentos.DataSource = wDataView
        End If
        Return True
    End Function

    Private Sub dtgMovimentos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgMovimentos.MouseMove
        Try
            Dim hti As System.Windows.Forms.DataGridView.HitTestInfo
            hti = dtgMovimentos.HitTest(e.X, e.Y)

            If hti.Type = System.Windows.Forms.DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 8 Then
                    Me.Cursor = System.Windows.Forms.Cursors.Hand
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand
                Else
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                End If
                If hti.ColumnIndex = 8 Then
                    ToolTip1.SetToolTip(dtgMovimentos, "")
                End If
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                ToolTip1.SetToolTip(dtgMovimentos, "")
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgMovimentos_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgMovimentos.MouseUp
        Try
            Dim hti As DataGridView.HitTestInfo = dtgMovimentos.HitTest(e.X, e.Y)

            If hti.Type = DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 8 Then
                    TelaAlteracaoMovimentos()
                End If
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgMovimentos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgMovimentos.CurrentCellChanged
        Try
            Dim wControle As Integer
            If IsNothing(dtgMovimentos.DataSource) Or IsNothing(dtgMovimentos.CurrentCell) Then Exit Sub

            objMovimento_Implem.IdMovimento = dtgMovimentos.Item(0, dtgMovimentos.CurrentCell().RowIndex).Value
            wControle = objMovimento_Implem.BuscarMovimento
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            dtgMovimentos.Rows(dtgMovimentos.CurrentCell().RowIndex).Selected = True
            dtgMovimentos.Focus()
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

#End Region

#Region " Limpeza da tela "

    Sub LimpaTela(Optional ByVal wNovoRegistro As Boolean = False)
        Try

            Dim wControle As Integer = 0
            txtIdMovimento.Text = ""
            If Not IsDate(txtData.Text) Then
                txtData.Text = ConverteDataParaString(Date.Now)
                cbTecnico.SelectedIndex = 0
                cbTipoAssistencia.SelectedIndex = 0
                cbTipoServico.SelectedIndex = 0
                cbPrefeitura.SelectedIndex = 0
                cbAnimal.SelectedIndex = 0
            End If
            txtNumeroDocumento.Text = ""
            txtNome_Associado.Text = ""
            txtMatricula_Associado.Text = ""
            txtCodigo_Associado.Text = ""
            cbTipoEverminacao.SelectedIndex = 0
            txtTalao.Text = ""
            txtCabecas.Text = ""
            txtCanhoto.Text = ""
            txtSituacao.Text = "L"
            lbSituacao.Text = "Situação: Lançado"

            txtValorOutros.Text = "0,00"
            txtValorMaodeObra.Text = "0,00"
            txtValorEverminacao.Text = "0,00"
            txtValorVisita.Text = "0,00"
            txtValorConducao.Text = "0,00"
            txtValorMedicamento.Text = "0,00"
            txtValorServico.Text = "0,00"
            txtValorEquipamento.Text = "0,00"
            txtValorBeneficio.Text = "0,00"
            txtValorSemem.Text = "0,00"
            txtNTouro.Text = ""
            txtValorTotal.Text = "0,00"

            txtData.Enabled = True
            txtNumeroDocumento.Enabled = True
            txtValorConducao.Enabled = False
            txtValorMedicamento.Enabled = False
            txtValorBeneficio.Enabled = False
            txtValorServico.Enabled = False
            txtValorEquipamento.Enabled = False
            txtValorSemem.Enabled = False
            txtValorBeneficio.Enabled = False
            txtValorBeneficio.Text = ""

            If cbTipoServico.SelectedIndex > 0 Then
                objTiposServico_Implem.Codigo = cbTipoServico.SelectedItem.value
                wControle = objTiposServico_Implem.BuscarServico()
                If wControle < 0 Then
                    objVariaveisGlobais.MostraErro()
                ElseIf wControle > 0 Then
                    MsgBox("Tipo de Serviço nao existe!")
                    Exit Sub
                End If

                txtValorVisita.Enabled = IIf(objTiposServico_Implem.IVisita = "S", True, False)
                txtValorConducao.Enabled = IIf(objTiposServico_Implem.IConducao = "S", True, False)
                txtValorBeneficio.Enabled = IIf(objTiposServico_Implem.IBeneficio = "S", True, False)
                txtValorServico.Enabled = IIf(objTiposServico_Implem.IServico = "S", True, False)
                'txtValorEquipamento.Enabled = IIf(objTiposServico_Implem.IEquipamento = "S", True, False)
                txtValorMedicamento.Enabled = IIf(objTiposServico_Implem.IMedicamento = "S", True, False)
                txtValorSemem.Enabled = IIf(objTiposServico_Implem.ISemem = "S", True, False)

                cbAnimal.Enabled = IIf(objTiposServico_Implem.IAnimal = "S", True, False)
                If cbAnimal.Enabled = False Then
                    cbAnimal.SelectedIndex = 0
                End If
            End If

            txtDataCadastro.Text = ConverteDataHoraParaString(Date.Now)
            objVariaveisGlobais.SetaComboBox(cbUsuarioCadastro, VariaveisGlobais.gCodigoUsuario)

            btAlterar.Enabled = False
            btExcluir.Enabled = False
            txtIdMovimento.Enabled = False

            If wNovoRegistro = False Then
                AtualizaMovimentos()
                btNovo.Enabled = True
                btAdicionar.Enabled = False
                btLimpar.Enabled = False
                TabControl1.SelectedIndex = 0
                tpManutencao.Enabled = False
                txtPesquisa.Focus()
            Else
                btAdicionar.Enabled = vIncluir
                btLimpar.Enabled = True
                btNovo.Enabled = False
                TabControl1.SelectedIndex = 1
                tpManutencao.Enabled = True
                txtData.Focus()
                txtData.Select(0, 0)
            End If

            LimpaErros()

        Catch ex As Exception
            MessageBox.Show("Erro no LimpaTela: " & vbCrLf + ex.Message.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLimpar.Click
        objAssociados_Implem.Codigo = ""
        objAssociados_Implem.NomeAssociado = ""
        objAssociados_Implem.Matricula = ""
        LimpaTela()
    End Sub

#End Region

#Region " Valida da tela "

    Private Function ValidaDados()
        LimpaErros()
        Dim f As Integer
        Dim wErros As String = ""
        Dim wFoco As Integer = -1
        TabControl1.SelectedIndex = 1

        Dim e1 As New System.ComponentModel.CancelEventArgs

        txtData_Validating(txtData, e1)
        txtCodigo_Associado_Validating(txtCodigo_Associado, e1)
        txtTalao_Validating(txtTalao, e1)
        txtDocumento_Validating(txtNumeroDocumento, e1)
        cbTecnico_Validating(cbTecnico, e1)
        cbTipoAssistencia_Validating(cbTipoAssistencia, e1)
        cbTipoServico_Validating(cbTipoServico, e1)
        cbAnimal_Validating(cbAnimal, e1)
        cbTipoEverminacao_Validating(cbTipoEverminacao, e1)

        For f = 0 To 39
            If VariaveisGlobais.gErroTela(f) <> "" Then
                If wFoco = -1 Then wFoco = f
                wErros = wErros & VariaveisGlobais.gErroTela(f) & vbCrLf
            End If
        Next f

        If wErros <> "" Then

            For f = 0 To gpDados.Controls.Count - 1
                If gpDados.Controls(f).TabIndex = wFoco Then
                    gpDados.Controls(f).Focus()
                End If
            Next

            MessageBox.Show("Verifique os erros abaixo: " & vbCrLf & vbCrLf & wErros, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 1
        End If

        Return 0

    End Function

    Private Sub LimpaErros()

        ErrorProvider1.SetError(txtData, "")
        ErrorProvider1.SetError(txtNumeroDocumento, "")
        ErrorProvider1.SetError(cbTipoAssistencia, "")
        ErrorProvider1.SetError(cbTecnico, "")
        ErrorProvider1.SetError(txtCodigo_Associado, "")
        'ErrorProvider1.SetError(cbAssociado, "")
        ErrorProvider1.SetError(cbTipoServico, "")
        ErrorProvider1.SetError(cbAnimal, "")
        ErrorProvider1.SetError(txtTalao, "")
        ErrorProvider1.SetError(cbTipoEverminacao, "")

        objVariaveisGlobais.InicializaVetorErros()

    End Sub

    Private Sub txtData_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtData.Validating
        Try

            Dim wMsgErro As String = ""

            If Not IsDate(txtData.Text) Then
                wMsgErro = "Data não é válida !"
            Else
                If btAdicionar.Visible OrElse btAlterar.Visible Then
                    If DateDiff(DateInterval.Month, Today, CDate(txtData.Text)) > 2 Then
                        wMsgErro = "Pode lançar no máximo 2 meses anteriores !"
                    End If
                    If DateDiff(DateInterval.Month, CDate(txtData.Text), Today) > 2 Then
                        wMsgErro = "Pode lançar no máximo 2 meses posteriores !"
                    End If
                End If
            End If

            If wMsgErro <> "" Then
                ErrorProvider1.SetError(txtData, wMsgErro)
                VariaveisGlobais.gErroTela(0) = wMsgErro
            Else
                ErrorProvider1.SetError(txtData, "")
                VariaveisGlobais.gErroTela(0) = ""
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try

    End Sub

    Private Sub cbTecnico_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTecnico.Validating
        Try
            Dim wMsgErro As String = ""

            If cbTecnico.SelectedIndex <= 0 Then
                wMsgErro = "Informe o Técnico !"
            End If
            If wMsgErro = "" Then
                ErrorProvider1.SetError(cbTecnico, "")
                VariaveisGlobais.gErroTela(1) = ""
            Else
                ErrorProvider1.SetError(cbTecnico, wMsgErro)
                VariaveisGlobais.gErroTela(1) = wMsgErro
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub txtDocumento_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumeroDocumento.Validating
        Try
            Dim wMsgErro As String = ""
            Dim wIdMovimento As String = ""
            Dim wIdTecnico As String = ""
            Dim wData As String = ""

            If CInt(txtNumeroDocumento.Text) <> 0 Then
                Dim wControle As Integer
                objMovimento_Implem.Documento = txtNumeroDocumento.Text
                objMovimento_Implem.Tecnico = cbTecnico.SelectedItem.value
                objMovimento_Implem.Data = txtData.Text

                wControle = objMovimento_Implem.VerificaExistenciaDocumento(wIdMovimento, wIdTecnico, wData)
                If wControle > 0 AndAlso wIdMovimento <> txtIdMovimento.Text AndAlso _
                    wIdTecnico = cbTecnico.SelectedItem.value Then
                    wMsgErro = "Número de Documento já existe para outro movimento deste técnico!"
                ElseIf wControle > 0 AndAlso wIdTecnico = cbTecnico.SelectedItem.value _
                        AndAlso CDate(wData).Month = CDate(txtData.Text).Month AndAlso _
                        CInt(txtIdMovimento.Text) <> wIdMovimento Then
                    wMsgErro = "Este documento já existe para este técnico neste mês!"
                ElseIf wControle < 0 Then
                    objVariaveisGlobais.MostraErro()
                End If
            ElseIf CInt(txtNumeroDocumento.Text) = 0 AndAlso CInt(txtCanhoto.Text) = 0 Then
                wMsgErro = "Número do Documento ou número do Canhoto deve ser informado!"
            End If

            If wMsgErro = "" Then
                ErrorProvider1.SetError(txtNumeroDocumento, "")
                VariaveisGlobais.gErroTela(2) = ""
            Else
                ErrorProvider1.SetError(txtNumeroDocumento, wMsgErro)
                VariaveisGlobais.gErroTela(2) = wMsgErro
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub cbTipoAssistencia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoAssistencia.SelectedIndexChanged
        VerificaBeneficio()
        AtualizaValores()
    End Sub

    Private Sub cbTipoAssistencia_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTipoAssistencia.Validating
        Try
            Dim wMsgErro As String = ""

            If cbTipoAssistencia.SelectedIndex <= 0 Then
                wMsgErro = "Informe o Tipo de Assistência !"
            ElseIf cbTipoAssistencia.SelectedItem.Value = "1" Then
                If txtMatricula_Associado.Text.Trim = "" Then
                    wMsgErro = "Tipo de Assistência deve ter matrícula !"
                End If
            End If


            If wMsgErro = "" Then
                ErrorProvider1.SetError(cbTipoAssistencia, "")
                VariaveisGlobais.gErroTela(3) = ""
            Else
                ErrorProvider1.SetError(cbTipoAssistencia, wMsgErro)
                VariaveisGlobais.gErroTela(3) = wMsgErro
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub cbTipoServico_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoServico.SelectedIndexChanged
        Dim wControle As Integer
        If cbTipoServico.SelectedIndex > 0 Then
            objTiposServico_Implem.Codigo = cbTipoServico.SelectedItem.value
            wControle = objTiposServico_Implem.BuscarServico()
            If wControle < 0 Then
                objVariaveisGlobais.MostraErro()
            ElseIf wControle > 0 Then
                MsgBox("Tipo de Serviço nao existe!")
                Exit Sub
            End If

            txtValorVisita.Enabled = IIf(objTiposServico_Implem.IVisita = "S", True, False)
            txtValorConducao.Enabled = IIf(objTiposServico_Implem.IConducao = "S", True, False)
            txtValorBeneficio.Enabled = IIf(objTiposServico_Implem.IBeneficio = "S", True, False)
            txtValorServico.Enabled = IIf(objTiposServico_Implem.IServico = "S", True, False)
            'txtValorEquipamento.Enabled = IIf(objTiposServico_Implem.IEquipamento = "S", True, False)
            txtValorMedicamento.Enabled = IIf(objTiposServico_Implem.IMedicamento = "S", True, False)
            txtValorSemem.Enabled = IIf(objTiposServico_Implem.ISemem = "S", True, False)

            cbAnimal.Enabled = IIf(objTiposServico_Implem.IAnimal = "S", True, False)
        Else
            'Bloqueia todos
            cbAnimal.Enabled = False
            txtValorVisita.Enabled = False
            txtValorConducao.Enabled = False
            txtValorBeneficio.Enabled = False
            txtValorServico.Enabled = False
            txtValorEquipamento.Enabled = False
            txtValorMedicamento.Enabled = False
            txtValorSemem.Enabled = False
        End If

        If txtValorVisita.Enabled = False Then txtValorVisita.Text = 0
        If txtValorConducao.Enabled = False Then txtValorConducao.Text = 0
        If txtValorBeneficio.Enabled = False Then txtValorBeneficio.Text = 0
        If txtValorServico.Enabled = False Then txtValorServico.Text = 0
        If txtValorEquipamento.Enabled = False Then txtValorEquipamento.Text = 0
        If txtValorMedicamento.Enabled = False Then txtValorMedicamento.Text = 0
        If txtValorSemem.Enabled = False Then txtValorSemem.Text = 0
        If cbAnimal.Enabled = False Then
            cbAnimal.SelectedIndex = 0
        End If

        VerificaBeneficio()

    End Sub

    Private Sub cbTipoServico_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTipoServico.Validating
        Try
            Dim wMsgErro As String = ""

            If cbTipoServico.SelectedIndex <= 0 Then
                wMsgErro = "Informe o Tipo de Serviço !"
            End If
            If wMsgErro = "" Then
                ErrorProvider1.SetError(cbTipoServico, "")
                VariaveisGlobais.gErroTela(4) = ""
            Else
                ErrorProvider1.SetError(cbTipoServico, wMsgErro)
                VariaveisGlobais.gErroTela(4) = wMsgErro
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub VerificaBeneficio()
        If cbAnimal.SelectedIndex >= 0 AndAlso cbTipoAssistencia.SelectedIndex >= 0 AndAlso cbTipoServico.SelectedIndex >= 0 Then
            If cbTipoAssistencia.SelectedItem.value = objParametros_Implem.Assistencia_Languiru Then
                If cbAnimal.SelectedItem.Value <> "" AndAlso objParametros_Implem.Codigos_Animais Like "*" & cbAnimal.SelectedItem.Value & "*" Then
                    If txtValorBeneficio.Enabled = True Then
                        txtValorBeneficio.Text = objParametros_Implem.Valor_Beneficio_Languiru
                    Else
                        txtValorBeneficio.Text = ""
                    End If
                Else
                    txtValorBeneficio.Text = ""
                End If
            Else
                txtValorBeneficio.Text = ""
            End If
        End If
        AtualizaValores()
    End Sub

    Private Sub cbAnimal_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAnimal.SelectedValueChanged
        VerificaBeneficio()
    End Sub

    Private Sub cbAnimal_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbAnimal.Validating
        Try
            Dim wMsgErro As String = ""

            If cbAnimal.SelectedIndex <= 0 Then
                wMsgErro = "Informe o Animal !"
            End If

            If wMsgErro = "" Then
                ErrorProvider1.SetError(cbAnimal, "")
                VariaveisGlobais.gErroTela(5) = ""
            Else
                ErrorProvider1.SetError(cbAnimal, wMsgErro)
                VariaveisGlobais.gErroTela(5) = wMsgErro
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    'Private Sub cbAssociado_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    Try
    '        Dim wMsgErro As String = ""

    '        If cbAssociado.SelectedIndex <= 0 Then
    '            wMsgErro = "Informe o Associado!"
    '        End If

    '        If wMsgErro = "" Then
    '            ErrorProvider1.SetError(cbAssociado, "")
    '            VariaveisGlobais.gErroTela(6) = ""
    '        Else
    '            ErrorProvider1.SetError(cbAssociado, wMsgErro)
    '            VariaveisGlobais.gErroTela(6) = wMsgErro
    '        End If
    '    Catch ex As Exception
    '        VariaveisGlobais.gUltimoSQL = ""
    '        VariaveisGlobais.gDescricaoUltimoErro = ex.Message
    '        VariaveisGlobais.gStackTraceErro = ex.StackTrace
    '        objVariaveisGlobais.MostraErro()
    '    End Try
    'End Sub

    Private Sub txtCodigo_Associado_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNome_Associado.Validating
        Try
            Dim wMsgErro As String = ""

            If txtNome_Associado.Text = "" Then
                wMsgErro = "Informe o Associado!"
            Else
                Dim wControle As Integer = objAssociados_Implem.VerificaExistenciaAssociado("Ex")
                If wControle < 0 Then
                    MessageBox.Show("Erro ao buscar associado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                ElseIf wControle > 0 Then
                    wMsgErro = "Associado encontra-se inativo no cadastro!"
                End If
            End If

            If wMsgErro = "" Then
                ErrorProvider1.SetError(txtNome_Associado, "")
                VariaveisGlobais.gErroTela(6) = ""
            Else
                ErrorProvider1.SetError(txtNome_Associado, wMsgErro)
                VariaveisGlobais.gErroTela(6) = wMsgErro
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub


    Private Sub cbTipoEverminacao_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTipoEverminacao.Validating
        Try
            Dim wMsgErro As String = ""

            If cbTipoEverminacao.SelectedIndex < 0 Then
                wMsgErro = "Informe o Tipo de Everminação!"
            End If

            If wMsgErro = "" Then
                ErrorProvider1.SetError(cbTipoEverminacao, "")
                VariaveisGlobais.gErroTela(7) = ""
            Else
                ErrorProvider1.SetError(cbTipoEverminacao, wMsgErro)
                VariaveisGlobais.gErroTela(7) = wMsgErro
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub txtTalao_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTalao.Validating
        Dim wMsgErro As String = "Digite corretamente a Inscrição Estadual!"

        If UnMaskBS(txtTalao.Text).Length <> 10 Then
            ErrorProvider1.SetError(txtTalao, wMsgErro)
            VariaveisGlobais.gErroTela(8) = wMsgErro
        Else
            ErrorProvider1.SetError(txtTalao, "")
            VariaveisGlobais.gErroTela(8) = ""
        End If
    End Sub

    Private Sub txtTalao_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTalao.Leave
        If SoNumero(txtTalao.Text).Length > 0 AndAlso txtCodigo_Associado.Text = "" Then
            Dim wControle As Integer
            If txtTalao.Text <> "" Then
                objAssociados_Implem.InscricaoEstadual = SoNumero(txtTalao.Text)
                wControle = objAssociados_Implem.BuscarAssociadoPorInscricaoEstadual
                If wControle < 0 Then
                    objVariaveisGlobais.MostraErro()
                ElseIf wControle > 0 Then
                    MsgBox("Não foi Possivel encontrar nenhum associado com esse Número de IE!")
                    Exit Sub
                End If

                txtCodigo_Associado.Text = objAssociados_Implem.Codigo
                txtNome_Associado.Text = objAssociados_Implem.NomeAssociado
                txtMatricula_Associado.Text = objAssociados_Implem.Matricula
                txtTalao.Text = objAssociados_Implem.InscricaoEstadual
                objVariaveisGlobais.SetaComboBox(cbPrefeitura, objAssociados_Implem.Cidade)
            Else
                txtCodigo_Associado.Text = ""
                txtNome_Associado.Text = ""
                txtMatricula_Associado.Text = ""
                txtTalao.Text = ""
                cbPrefeitura.SelectedIndex = 0
            End If
        End If
        txtNumeroDocumento.Focus()
    End Sub

    Private Sub txtDocumento_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroDocumento.LostFocus
        'If txtIdMovimento.Text <> "" AndAlso txtNumeroDocumento.Text <> "" Then
        '    Dim wControle As Integer
        '    objMovimento_Implem.IdMovimento = txtIdMovimento.Text
        '    objMovimento_Implem.Documento = txtNumeroDocumento.Text
        '    wControle = objMovimento_Implem.VerificaExistenciaMovimento()
        '    'wControle = objMovimento_Implem.BuscarDocumento()
        '    'If wControle = 0 Then
        '    'TelaAlteracaoMovimentos()
        '    'End If
        'End If
        'cbTipoAssistencia.Focus()
    End Sub

    'Private Sub cbAssociado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim wControle As Integer
    '    If cbAssociado.SelectedIndex > 0 Then
    '        objAssociados_Implem.Codigo = cbAssociado.SelectedItem.value
    '        wControle = objAssociados_Implem.BuscarAssociado
    '        If wControle < 0 Then
    '            objVariaveisGlobais.MostraErro()
    '        ElseIf wControle > 0 Then
    '            MsgBox("Associado nao existe!")
    '            Exit Sub
    '        End If

    '        txtTalao.Text = objAssociados_Implem.InscricaoEstadual
    '    Else
    '        txtTalao.Text = ""
    '    End If
    'End Sub

#End Region

#Region " Impressao "

#Region " Variaveis de Impressao "

    Dim wAlturaPapel As Integer
    Dim sdb As System.Drawing.Brush

    Dim DataMovimento As String
    Dim NomeTecnico As String
    Dim NomeAsscociado As String
    Dim Assistencia As String

    Dim TotalRecords As Integer = 0
    Dim pagina As Integer = 0
    Dim dados As Integer = 0
    Dim dlg As PrintPreviewDialog

    Dim printFont1 As New Font("Courier New", 6, FontStyle.Bold, GraphicsUnit.Millimeter)
    Dim printFontP As New Font("Courier New", 2.5, FontStyle.Regular, GraphicsUnit.Millimeter)
    Dim printFont As New Font("Courier New", 3, FontStyle.Regular, GraphicsUnit.Millimeter)
    Dim printFontB As New Font("Courier New", 3, FontStyle.Bold, GraphicsUnit.Millimeter)
    Dim printFontBB As New Font("Courier New", 5, FontStyle.Bold, GraphicsUnit.Millimeter)

    Dim dFrl As New StringFormat
    Dim dFac As New StringFormat
    Dim mpreview As Boolean

    Dim ContadorRegistro As Integer

#End Region

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click
        Try
            FazFiltro()
            Dim tf As Boolean
            tf = SetPrintDialog(wAlturaPapel, PrintDocument1)
            If tf = False Then
                Exit Sub
            End If

            mpreview = False

            PrintDocument1.Print()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click
        Try
            FazFiltro()
            Dim tf As Boolean
            tf = SetPrintDialog(wAlturaPapel, PrintDocument1)
            If tf = False Then
                Exit Sub
            End If

            Dim dlg As New PrintPreviewDialog
            dlg.PrintPreviewControl.Zoom = 1.0
            dlg.WindowState = FormWindowState.Maximized

            mpreview = False
            dlg.Document = PrintDocument1
            dlg.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("An error occurred - " + ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
        Handles PrintDocument1.PrintPage
        If mpreview = False Then
            ContadorRegistro = 0
            pagina = 0
            dados = 0
        End If
        TotalRecords = dtgMovimentos.RowCount

        Dim paginain As Integer = e.PageSettings.PrinterSettings.FromPage
        Dim paginafi As Integer = e.PageSettings.PrinterSettings.ToPage
        While pagina + 1 < paginain
            sdb = Brushes.White
            PrintDocument2_PrintPage(sender, e)
        End While
        sdb = Brushes.Black
        PrintDocument2_PrintPage(sender, e)
        If pagina + 1 > paginafi Then
            mpreview = False
            e.HasMorePages = False
        End If
    End Sub

    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        mpreview = True
        dFrl.FormatFlags = StringFormatFlags.DirectionRightToLeft
        dFac.Alignment = StringAlignment.Center
        pagina += 1

        MontaCabecalho(e)

        Dim yPos As Integer = 130
        For i As Integer = ContadorRegistro To TotalRecords - 1
            yPos += 15
            If yPos > wAlturaPapel - 130 Then
                e.HasMorePages = True
                ContadorRegistro = i
                Exit Sub
            End If

            DataMovimento = dtgMovimentos.Item(1, i).Value
            NomeTecnico = dtgMovimentos.Item(2, i).Value
            NomeAsscociado = dtgMovimentos.Item(3, i).Value
            Assistencia = dtgMovimentos.Item(5, i).Value

            e.Graphics.DrawString(DataMovimento, printFont, sdb, 10, yPos)
            e.Graphics.DrawString((NomeTecnico & Space(20)).Substring(0, 20), printFont, sdb, 100, yPos)
            e.Graphics.DrawString((NomeAsscociado & Space(20)).Substring(0, 20), printFont, sdb, 320, yPos)
            e.Graphics.DrawString((Assistencia & Space(20)).Substring(0, 20), printFont, sdb, 550, yPos)
        Next
        yPos += 20
        e.Graphics.DrawString("Total: " & TotalRecords, printFontB, sdb, 20, yPos)

        mpreview = False
    End Sub

    Private Sub MontaCabecalho(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        'e.Graphics.DrawString(VariaveisGlobais.gNomeEmpresaUsuario, printFont1, sdb, 390, 25, dFac)
        e.Graphics.DrawString("Relatório de Movimentos", printFontBB, sdb, 390, 55, dFac)
        e.Graphics.DrawImage(Drawing.Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "Application.ico"), _
         10, 10, 50, 50)

        e.Graphics.DrawString("Data", printFontB, sdb, 10, 120)
        e.Graphics.DrawString("Técnico", printFontB, sdb, 100, 120)
        e.Graphics.DrawString("Associado", printFontB, sdb, 320, 120)
        e.Graphics.DrawString("Assistência", printFontB, sdb, 550, 120)

        e.Graphics.DrawString("Emitido em " & ConverteDataParaString(Date.Now) & _
        " por " & VariaveisGlobais.gNomeUsuario & " - Pág " & pagina, printFontP, Brushes.Black, 780, wAlturaPapel - 80, dFrl)

    End Sub

#End Region

    Private Sub txtValorBeneficio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorBeneficio.LostFocus, _
                txtValorConducao.LostFocus, txtValorEquipamento.LostFocus, txtValorMedicamento.LostFocus, txtValorSemem.LostFocus, _
                txtValorServico.LostFocus, txtValorOutros.LostFocus, txtValorVisita.LostFocus
        AtualizaValores()
    End Sub

    Private Sub AtualizaValores()

        Dim xValor As Decimal = 0
        xValor = CDec(txtValorVisita.Text) + CDec(txtValorConducao.Text) + CDec(txtValorEquipamento.Text) + _
            CDec(txtValorMedicamento.Text) + CDec(txtValorSemem.Text) + CDec(txtValorServico.Text) + _
            CDec(txtValorOutros.Text) + CDec(txtValorEverminacao.Text) + CDec(txtValorMaodeObra.Text) - _
            CDec(txtValorBeneficio.Text)
        If xValor > 0 Then
            txtValorTotal.Text = xValor
        Else
            txtValorTotal.Text = "0"
        End If
    End Sub

    Private Sub txtCabecas_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCabecas.LostFocus
        txtCabecas.Enabled = True
        If cbTipoEverminacao.SelectedItem.value = "1" Then
            txtValorEverminacao.Text = objParametros_Implem.Valor_Vermifugo * txtCabecas.Text
        ElseIf cbTipoEverminacao.SelectedItem.value = "2" Then
            txtValorEverminacao.Text = objParametros_Implem.Valor_Bernicida * txtCabecas.Text
        ElseIf cbTipoEverminacao.SelectedItem.value = "3" Then
            txtValorEverminacao.Text = objParametros_Implem.Valor_Fasciolicida * txtCabecas.Text
        Else
            txtValorEverminacao.Text = 0
        End If
        txtValorMaodeObra.Text = objParametros_Implem.Valor_MaodeObra * txtCabecas.Text
        AtualizaValores()
    End Sub

    Private Sub cbEverminacao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoEverminacao.SelectedIndexChanged

        If cbTipoEverminacao.SelectedIndex <= 0 Then
            txtCabecas.ReadOnly = True
            txtCabecas.Enabled = False
            txtCabecas.Text = "0"
            txtValorEverminacao.Text = 0
            txtValorMaodeObra.Text = 0
        Else
            txtCabecas.ReadOnly = False
            txtCabecas.Enabled = True
        End If

    End Sub

    Private Sub txtMatricula_Associado_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMatricula_Associado.Leave
        If (txtMatricula_Associado.Text <> objAssociados_Implem.Matricula AndAlso txtMatricula_Associado.Text <> "") OrElse _
           (txtCodigo_Associado.Text <> objAssociados_Implem.Codigo AndAlso _
           txtMatricula_Associado.Text <> "") Then

            Dim a As New Associados
            a.txtPesquisa.Text = txtMatricula_Associado.Text
            a.vSelecao = "Matricula"
            a.ShowDialog()
            a.Dispose()
            If objAssociados_Implem.Codigo <> "" Then
                txtMatricula_Associado.Text = objAssociados_Implem.Matricula
                txtCodigo_Associado.Text = objAssociados_Implem.Codigo
                txtNome_Associado.Text = objAssociados_Implem.NomeAssociado
            Else
                txtMatricula_Associado.Text = ""
                txtCodigo_Associado.Text = ""
                txtNome_Associado.Text = ""
            End If

            Dim wControle As Integer
            If txtCodigo_Associado.Text <> "" Then
                objAssociados_Implem.Codigo = txtCodigo_Associado.Text
                wControle = objAssociados_Implem.BuscarAssociado
                If wControle < 0 Then
                    objVariaveisGlobais.MostraErro()
                ElseIf wControle > 0 Then
                    MsgBox("Não foi Possivel encontrar nenhum associado com essa Matrícula!")
                    Exit Sub
                End If

                txtTalao.Text = objAssociados_Implem.InscricaoEstadual
                objVariaveisGlobais.SetaComboBox(cbPrefeitura, objAssociados_Implem.Cidade)
            Else
                txtTalao.Text = ""
                cbPrefeitura.SelectedIndex = 0
            End If
        ElseIf txtMatricula_Associado.Text = "" AndAlso txtCodigo_Associado.Text = objAssociados_Implem.Codigo Then
            txtMatricula_Associado.Text = ""
        ElseIf txtMatricula_Associado.Text = "" Then
            txtMatricula_Associado.Text = ""
            txtCodigo_Associado.Text = ""
            txtNome_Associado.Text = ""
        End If
    End Sub

    Private Sub txtNome_Associado_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome_Associado.Leave
        If (txtNome_Associado.Text <> objAssociados_Implem.NomeAssociado AndAlso txtNome_Associado.Text <> "") OrElse _
           (txtCodigo_Associado.Text <> objAssociados_Implem.Codigo AndAlso _
           txtNome_Associado.Text <> "") Then
            Dim a As New Associados
            a.txtPesquisa.Text = txtNome_Associado.Text
            a.vSelecao = "Nome"
            a.ShowDialog()
            a.Dispose()
            If objAssociados_Implem.Codigo <> "" Then
                txtMatricula_Associado.Text = objAssociados_Implem.Matricula
                txtCodigo_Associado.Text = objAssociados_Implem.Codigo
                txtNome_Associado.Text = objAssociados_Implem.NomeAssociado
            Else
                txtMatricula_Associado.Text = ""
                txtCodigo_Associado.Text = ""
                txtNome_Associado.Text = ""
            End If

            Dim wControle As Integer
            If txtCodigo_Associado.Text <> "" Then
                objAssociados_Implem.Codigo = txtCodigo_Associado.Text
                wControle = objAssociados_Implem.BuscarAssociado
                If wControle < 0 Then
                    objVariaveisGlobais.MostraErro()
                ElseIf wControle > 0 Then
                    MsgBox("Não foi Possivel encontrar nenhum associado com essa Matrícula!")
                    Exit Sub
                End If

                txtTalao.Text = objAssociados_Implem.InscricaoEstadual
                objVariaveisGlobais.SetaComboBox(cbPrefeitura, objAssociados_Implem.Cidade)
            Else
                txtTalao.Text = ""
                cbPrefeitura.SelectedIndex = 0
            End If
        ElseIf txtNome_Associado.Text = "" Then
            txtMatricula_Associado.Text = ""
            txtCodigo_Associado.Text = ""
            txtNome_Associado.Text = ""
        End If
    End Sub

    Private Sub txtDatas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDataInicio.LostFocus, txtDataFim.LostFocus

    End Sub

    Private Sub txtMatricula_Associado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMatricula_Associado.Validating
        Dim e1 As New System.ComponentModel.CancelEventArgs
        cbTipoAssistencia_Validating(cbTipoAssistencia, e)
    End Sub

    Private Sub btPesquisa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisa.Click
        Me.Cursor = Cursors.WaitCursor
        AtualizaMovimentos()
        Me.Cursor = Cursors.Default
    End Sub
End Class
