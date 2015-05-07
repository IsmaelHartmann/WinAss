Public Class MovPrefeituras
    Inherits System.Windows.Forms.Form
    Private vIncluir As Boolean
    Private vAlterar As Boolean
    Private vExcluir As Boolean
    Friend WithEvents txtValor As FzNumericBox.FzNumericBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbPrefeitura As FzComboBox.FzCombobox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo_Associado As System.Windows.Forms.TextBox
    Friend WithEvents txtNome_Associado As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtDataFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtDataInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbPesquisaTipoServico As FzComboBox.FzCombobox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtInscricaoEstadual As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCRMV As FzNumericBox.FzNumericBox
    Friend WithEvents txtNumeroTestes As FzNumericBox.FzNumericBox
    Friend WithEvents lNumeroTestes As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtValorTotal As FzNumericBox.FzNumericBox
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
    Friend WithEvents cbTipoServico As FzComboBox.FzCombobox
    Friend WithEvents cbTecnico As FzComboBox.FzCombobox
    Friend WithEvents Label10 As System.Windows.Forms.Label
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
    Friend WithEvents dtgMovPrefeituras As System.Windows.Forms.DataGridView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovPrefeituras))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gpDados = New System.Windows.Forms.GroupBox
        Me.txtValorTotal = New FzNumericBox.FzNumericBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNumeroTestes = New FzNumericBox.FzNumericBox
        Me.lNumeroTestes = New System.Windows.Forms.Label
        Me.txtCRMV = New FzNumericBox.FzNumericBox
        Me.txtInscricaoEstadual = New System.Windows.Forms.MaskedTextBox
        Me.txtCodigo_Associado = New System.Windows.Forms.TextBox
        Me.txtNome_Associado = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cbPrefeitura = New FzComboBox.FzCombobox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtValor = New FzNumericBox.FzNumericBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtData = New FzFlexBox.DateTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cbTipoServico = New FzComboBox.FzCombobox
        Me.cbTecnico = New FzComboBox.FzCombobox
        Me.Label10 = New System.Windows.Forms.Label
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
        Me.cbPesquisaTipoServico = New FzComboBox.FzCombobox
        Me.Label9 = New System.Windows.Forms.Label
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
        Me.dtgMovPrefeituras = New System.Windows.Forms.DataGridView
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
        CType(Me.dtgMovPrefeituras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpManutencao.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpDados
        '
        Me.gpDados.Controls.Add(Me.txtValorTotal)
        Me.gpDados.Controls.Add(Me.Label7)
        Me.gpDados.Controls.Add(Me.txtNumeroTestes)
        Me.gpDados.Controls.Add(Me.lNumeroTestes)
        Me.gpDados.Controls.Add(Me.txtCRMV)
        Me.gpDados.Controls.Add(Me.txtInscricaoEstadual)
        Me.gpDados.Controls.Add(Me.txtCodigo_Associado)
        Me.gpDados.Controls.Add(Me.txtNome_Associado)
        Me.gpDados.Controls.Add(Me.Label23)
        Me.gpDados.Controls.Add(Me.cbPrefeitura)
        Me.gpDados.Controls.Add(Me.Label20)
        Me.gpDados.Controls.Add(Me.txtValor)
        Me.gpDados.Controls.Add(Me.Label19)
        Me.gpDados.Controls.Add(Me.txtData)
        Me.gpDados.Controls.Add(Me.Label15)
        Me.gpDados.Controls.Add(Me.cbTipoServico)
        Me.gpDados.Controls.Add(Me.cbTecnico)
        Me.gpDados.Controls.Add(Me.Label10)
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
        Me.gpDados.Text = "Informações do Movimento da Prefeitura"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.AllowNegative = True
        Me.txtValorTotal.Enabled = False
        Me.txtValorTotal.Location = New System.Drawing.Point(134, 200)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.NumericPrecision = 8
        Me.txtValorTotal.NumericScaleOnFocus = 2
        Me.txtValorTotal.NumericScaleOnLostFocus = 2
        Me.txtValorTotal.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(82, 20)
        Me.txtValorTotal.TabIndex = 26
        Me.txtValorTotal.Text = "0"
        Me.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorTotal.ZeroIsValid = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Valor Total"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumeroTestes
        '
        Me.txtNumeroTestes.AllowNegative = True
        Me.txtNumeroTestes.Location = New System.Drawing.Point(349, 176)
        Me.txtNumeroTestes.MaxLength = 8
        Me.txtNumeroTestes.Name = "txtNumeroTestes"
        Me.txtNumeroTestes.NumericPrecision = 8
        Me.txtNumeroTestes.NumericScaleOnFocus = 0
        Me.txtNumeroTestes.NumericScaleOnLostFocus = 0
        Me.txtNumeroTestes.NumericValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtNumeroTestes.Size = New System.Drawing.Size(97, 20)
        Me.txtNumeroTestes.TabIndex = 18
        Me.txtNumeroTestes.Text = "1"
        Me.txtNumeroTestes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNumeroTestes.ZeroIsValid = False
        '
        'lNumeroTestes
        '
        Me.lNumeroTestes.BackColor = System.Drawing.Color.Transparent
        Me.lNumeroTestes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lNumeroTestes.ForeColor = System.Drawing.Color.Black
        Me.lNumeroTestes.Location = New System.Drawing.Point(222, 176)
        Me.lNumeroTestes.Name = "lNumeroTestes"
        Me.lNumeroTestes.Size = New System.Drawing.Size(121, 20)
        Me.lNumeroTestes.TabIndex = 17
        Me.lNumeroTestes.Text = "Número de testes"
        Me.lNumeroTestes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCRMV
        '
        Me.txtCRMV.AllowNegative = True
        Me.txtCRMV.Enabled = False
        Me.txtCRMV.Location = New System.Drawing.Point(135, 75)
        Me.txtCRMV.Name = "txtCRMV"
        Me.txtCRMV.NumericPrecision = 8
        Me.txtCRMV.NumericScaleOnFocus = 0
        Me.txtCRMV.NumericScaleOnLostFocus = 0
        Me.txtCRMV.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCRMV.Size = New System.Drawing.Size(81, 20)
        Me.txtCRMV.TabIndex = 5
        Me.txtCRMV.TabStop = False
        Me.txtCRMV.Text = "0"
        Me.txtCRMV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCRMV.ZeroIsValid = True
        '
        'txtInscricaoEstadual
        '
        Me.txtInscricaoEstadual.Location = New System.Drawing.Point(134, 100)
        Me.txtInscricaoEstadual.Mask = "000/000,000,0"
        Me.txtInscricaoEstadual.Name = "txtInscricaoEstadual"
        Me.txtInscricaoEstadual.ReadOnly = True
        Me.txtInscricaoEstadual.Size = New System.Drawing.Size(82, 20)
        Me.txtInscricaoEstadual.TabIndex = 8
        Me.txtInscricaoEstadual.TabStop = False
        '
        'txtCodigo_Associado
        '
        Me.txtCodigo_Associado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo_Associado.Location = New System.Drawing.Point(452, 100)
        Me.txtCodigo_Associado.Name = "txtCodigo_Associado"
        Me.txtCodigo_Associado.ReadOnly = True
        Me.txtCodigo_Associado.Size = New System.Drawing.Size(28, 20)
        Me.txtCodigo_Associado.TabIndex = 10
        Me.txtCodigo_Associado.TabStop = False
        Me.txtCodigo_Associado.Visible = False
        '
        'txtNome_Associado
        '
        Me.txtNome_Associado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome_Associado.Location = New System.Drawing.Point(222, 100)
        Me.txtNome_Associado.Name = "txtNome_Associado"
        Me.txtNome_Associado.Size = New System.Drawing.Size(224, 20)
        Me.txtNome_Associado.TabIndex = 9
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(17, 127)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(111, 20)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "Prefeitura"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbPrefeitura
        '
        Me.cbPrefeitura.Location = New System.Drawing.Point(134, 125)
        Me.cbPrefeitura.Name = "cbPrefeitura"
        Me.cbPrefeitura.Size = New System.Drawing.Size(312, 22)
        Me.cbPrefeitura.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(17, 100)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(111, 20)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Associado"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtValor
        '
        Me.txtValor.AllowNegative = True
        Me.txtValor.Location = New System.Drawing.Point(134, 176)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.NumericPrecision = 8
        Me.txtValor.NumericScaleOnFocus = 2
        Me.txtValor.NumericScaleOnLostFocus = 2
        Me.txtValor.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValor.Size = New System.Drawing.Size(82, 20)
        Me.txtValor.TabIndex = 16
        Me.txtValor.Text = "0"
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValor.ZeroIsValid = True
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(17, 176)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 20)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Valor"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtData
        '
        Me.txtData.Enabled = False
        Me.txtData.Location = New System.Drawing.Point(134, 51)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(67, 20)
        Me.txtData.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(17, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Data"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbTipoServico
        '
        Me.cbTipoServico.Location = New System.Drawing.Point(134, 151)
        Me.cbTipoServico.Name = "cbTipoServico"
        Me.cbTipoServico.Size = New System.Drawing.Size(312, 22)
        Me.cbTipoServico.TabIndex = 14
        '
        'cbTecnico
        '
        Me.cbTecnico.Location = New System.Drawing.Point(222, 75)
        Me.cbTecnico.Name = "cbTecnico"
        Me.cbTecnico.Size = New System.Drawing.Size(224, 22)
        Me.cbTecnico.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(17, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Tipo de Serviço"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btConfirmaSelecao.TabIndex = 23
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
        Me.txtDataCadastro.TabIndex = 20
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
        Me.btCancelaSelecao.TabIndex = 24
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
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Data Cadastro"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbUsuarioCadastro
        '
        Me.cbUsuarioCadastro.Enabled = False
        Me.cbUsuarioCadastro.Location = New System.Drawing.Point(134, 325)
        Me.cbUsuarioCadastro.Name = "cbUsuarioCadastro"
        Me.cbUsuarioCadastro.Size = New System.Drawing.Size(98, 22)
        Me.cbUsuarioCadastro.TabIndex = 22
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
        Me.Label5.TabIndex = 21
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
        Me.Label6.Location = New System.Drawing.Point(17, 75)
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
        Me.gbPesquisa.Size = New System.Drawing.Size(747, 77)
        Me.gbPesquisa.TabIndex = 0
        Me.gbPesquisa.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbPesquisaTipoServico)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.txtDataFim)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.txtDataInicio)
        Me.GroupBox2.Location = New System.Drawing.Point(395, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 72)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Período"
        '
        'cbPesquisaTipoServico
        '
        Me.cbPesquisaTipoServico.Location = New System.Drawing.Point(108, 44)
        Me.cbPesquisaTipoServico.Name = "cbPesquisaTipoServico"
        Me.cbPesquisaTipoServico.Size = New System.Drawing.Size(221, 22)
        Me.cbPesquisaTipoServico.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(15, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Tipo de Serviço"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.LightBlue
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(175, 17)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(50, 20)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Fim"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDataFim
        '
        Me.txtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataFim.Location = New System.Drawing.Point(231, 17)
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
        Me.GroupBox1.Size = New System.Drawing.Size(116, 72)
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
        Me.TabControl1.Size = New System.Drawing.Size(765, 469)
        Me.TabControl1.TabIndex = 8
        '
        'tpConsulta
        '
        Me.tpConsulta.Controls.Add(Me.dtgMovPrefeituras)
        Me.tpConsulta.Controls.Add(Me.gbPesquisa)
        Me.tpConsulta.Location = New System.Drawing.Point(4, 23)
        Me.tpConsulta.Name = "tpConsulta"
        Me.tpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConsulta.Size = New System.Drawing.Size(757, 442)
        Me.tpConsulta.TabIndex = 0
        Me.tpConsulta.Text = "Consulta"
        Me.tpConsulta.UseVisualStyleBackColor = True
        '
        'dtgMovPrefeituras
        '
        Me.dtgMovPrefeituras.AllowUserToAddRows = False
        Me.dtgMovPrefeituras.AllowUserToDeleteRows = False
        Me.dtgMovPrefeituras.AllowUserToOrderColumns = True
        Me.dtgMovPrefeituras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgMovPrefeituras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtgMovPrefeituras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgMovPrefeituras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMovPrefeituras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cm})
        Me.dtgMovPrefeituras.Location = New System.Drawing.Point(7, 80)
        Me.dtgMovPrefeituras.Name = "dtgMovPrefeituras"
        Me.dtgMovPrefeituras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgMovPrefeituras.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgMovPrefeituras.Size = New System.Drawing.Size(744, 356)
        Me.dtgMovPrefeituras.TabIndex = 1
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
        Me.tpManutencao.Location = New System.Drawing.Point(4, 23)
        Me.tpManutencao.Name = "tpManutencao"
        Me.tpManutencao.Padding = New System.Windows.Forms.Padding(3)
        Me.tpManutencao.Size = New System.Drawing.Size(757, 442)
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
        'MovPrefeituras
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(230, 176)
        Me.Name = "MovPrefeituras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Movimento de Prefeituras"
        Me.gpDados.ResumeLayout(False)
        Me.gpDados.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPesquisa.ResumeLayout(False)
        Me.gbPesquisa.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpConsulta.ResumeLayout(False)
        CType(Me.dtgMovPrefeituras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpManutencao.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public objMovPrefeituras_Implem As MovPrefeituras_Implem = MovPrefeiturasBOFactory.GetFactory().GetInstance()
    Public objPrefeituras_Implem As Prefeituras_Implem = PrefeiturasBOFactory.GetFactory().GetInstance()
    Public objAssociados_Implem As Associados_Implem = AssociadosBOFactory.GetFactory().GetInstance()
    Public objParametros_Implem As Parametros_Implem = ParametrosBOFactory.GetFactory().GetInstance()
    Public objTiposServico_Implem As TiposServicos_Implem = TiposServicosBOFactory.GetFactory().GetInstance()
    Public objValores_Implem As Valores_Prefeituras_TipoServico_Implem = Valores_Prefeituras_TipoServicoBOFactory.GetFactory().GetInstance()
    Public objTecnicos_Implem As Tecnicos_Implem = TecnicosBOFactory.GetFactory().GetInstance()

#Region " Inicializações "

    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtPesquisa.Focus()
    End Sub

    Private Sub MovPrefeiturass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim autoriza As Boolean
        autoriza = VerificaPrograma("MovPrefeiturass", VariaveisGlobais.gSetorUsuario, _
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

            'wControle = objVariaveisGlobais.PreencheComboBox(cbPrefeitura, VariaveisGlobais.gConexao, _
            '" SELECT CodigoCidade , NomeCidade " & _
            '" FROM C_Cidades " & _
            '" WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
            '" ORDER BY NomeCidade ", "")
            wControle = objVariaveisGlobais.PreencheComboBox(cbPrefeitura, VariaveisGlobais.gConexao, _
            " SELECT Codigo, Nome " & _
            " FROM Ass_Prefeituras " & _
            " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
            " ORDER BY Nome", "")
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

            wControle = objVariaveisGlobais.PreencheComboBox(cbPesquisaTipoServico, VariaveisGlobais.gConexao, _
           " SELECT Codigo, Descricao " & _
           " FROM Ass_TipoServico " & _
           " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
           " ORDER BY Descricao ", "")
            If wControle <> 0 Then
                MsgBox(VariaveisGlobais.gDescricaoUltimoErro)
            End If
            cbPesquisaTipoServico.SelectedIndex = 0

            txtDataInicio.Text = "01/" & Today.Month & "/" & Today.Year
            txtDataFim.Text = Date.DaysInMonth(Today.Year, Today.Month) & "/" & Today.Month & "/" & Today.Year

            LimpaTela()

            If vSelecao <> "" Then
                btCancelaSelecao.Visible = True
                btConfirmaSelecao.Visible = True
                objVariaveisGlobais.SetaComboBox(cbCampo, vSelecao)
                If dtgMovPrefeituras.Rows.Count = 1 Then
                    dtgMovPrefeituras.Rows(0).Selected = True
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

    Private Sub CadastroMovPrefeiturass_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        objMovPrefeituras_Implem = Nothing
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
            objLeituras.VerC_LOG(VariaveisGlobais.gBD, "C_LOG", "Ass_MovPrefeituras", txtIdMovimento.Text)
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
        If e.KeyCode = Keys.Enter And dtgMovPrefeituras.Focused Then
            TelaAlteracaoMovPrefeiturass()
            If btConfirmaSelecao.Visible = True Then
                Me.Dispose()
            Else
            End If
        End If
        If e.KeyCode = Keys.Down And txtPesquisa.Focused Then
            dtgMovPrefeituras.Focus()
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
        AdicionarMovPrefeituras()
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

    Public Function GuardaDadosMovPrefeiturass() As Integer
        Try
            objMovPrefeituras_Implem = New MovPrefeituras_Implem

            objMovPrefeituras_Implem.IdMovimento = txtIdMovimento.Text
            objMovPrefeituras_Implem.Data = txtData.Text
            objMovPrefeituras_Implem.Tecnico = cbTecnico.SelectedItem.value
            'objMovPrefeituras_Implem.Associado = cbAssociado.SelectedItem.value
            objMovPrefeituras_Implem.Associado = txtCodigo_Associado.Text
            objMovPrefeituras_Implem.TipoServico = cbTipoServico.SelectedItem.value
            objMovPrefeituras_Implem.Prefeitura = cbPrefeitura.SelectedItem.value
            objMovPrefeituras_Implem.Valor = txtValor.Text
            objMovPrefeituras_Implem.NumeroTestes = txtNumeroTestes.Text
            objMovPrefeituras_Implem.Codigo_Usuario_Cadastro = cbUsuarioCadastro.SelectedItem.value

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Sub TelaAlteracaoMovPrefeiturass()
        Try
            Dim wControle As Integer
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Me.Close()
            End If

            cbTipoServico.SelectedIndex = 0

            LimpaErros()

            TabControl1.SelectedIndex = 1
            tpManutencao.Enabled = True

            txtIdMovimento.Text = objMovPrefeituras_Implem.IdMovimento
            'objVariaveisGlobais.SetaComboBox(cbAssociado, objMovPrefeituras_Implem.Associado)
            objAssociados_Implem.Codigo = objMovPrefeituras_Implem.Associado
            wControle = objAssociados_Implem.BuscarAssociado()
            If wControle < 0 Then
                objVariaveisGlobais.MostraErro()
            ElseIf wControle = 1 Then
                MsgBox("Associado não encontrado no BD!")
            ElseIf wControle = 0 Then
                txtCodigo_Associado.Text = objAssociados_Implem.Codigo
                txtNome_Associado.Text = objAssociados_Implem.NomeAssociado
                txtInscricaoEstadual.Text = objAssociados_Implem.InscricaoEstadual
            End If

            txtData.Text = ConverteDataParaString(objMovPrefeituras_Implem.Data)
            objVariaveisGlobais.SetaComboBox(cbTecnico, objMovPrefeituras_Implem.Tecnico)
            objVariaveisGlobais.SetaComboBox(cbTipoServico, objMovPrefeituras_Implem.TipoServico)
            objVariaveisGlobais.SetaComboBox(cbPrefeitura, objMovPrefeituras_Implem.Prefeitura)
            txtValor.Text = CDec(objMovPrefeituras_Implem.Valor)
            txtNumeroTestes.Text = objMovPrefeituras_Implem.NumeroTestes
            'AtualizaValores()

            txtDataCadastro.Text = ConverteDataHoraParaString(objMovPrefeituras_Implem.Data_Hora_Cadastro)
            objVariaveisGlobais.SetaComboBox(cbUsuarioCadastro, objMovPrefeituras_Implem.Codigo_Usuario_Cadastro)

            btExcluir.Enabled = vExcluir
            btAlterar.Enabled = vAlterar
            btAdicionar.Enabled = False
            btNovo.Enabled = False
            'btLimpar.Enabled = True

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

    Public Sub AdicionarMovPrefeituras()
        Try

            Dim wControle As Integer
            wControle = ValidaDados()
            If wControle <> 0 Then Exit Sub

            GuardaDadosMovPrefeiturass()
            wControle = objMovPrefeituras_Implem.IncluirMovPrefeituras
            If wControle = 1 Then
                MessageBox.Show("Já existe um Movimento de Prefeitura cadastrado para este dia com este Técnico e Documento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If

            MessageBox.Show("Movimento de Prefeitura incluído com sucesso! Id: " & _
                        objMovPrefeituras_Implem.IdMovimento, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

            wControle = GuardaDadosMovPrefeiturass()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If

            wControle = objMovPrefeituras_Implem.AlterarMovPrefeituras
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Dados do Movimento da Prefeitura modificados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

        wMensagem = MessageBox.Show("TODOS Dados relacionados a esse Movimento de Prefeitura serão permanentemente excluídos!" & vbCrLf & " Você deseja excluir este Movimento de Prefeitura? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If (wMensagem = Windows.Forms.DialogResult.Yes) Then
            objMovPrefeituras_Implem.IdMovimento = txtIdMovimento.Text
            wControle = objMovPrefeituras_Implem.ExcluirMovPrefeituras
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("MovPrefeituras excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LimpaTela()

    End Sub

#End Region

#Region " Atualização do DataGrid e do Form "

    'Private Sub AtualizaMovPrefeituras()

    '    Dim wControle As Integer

    '    Dim wSQL As String = " SET DATEFORMAT DMY SELECT M.IdMovimento, M.Data, T.Nome, AA.Nome, " & _
    '                " M.Documento, " & _
    '                " TS.Descricao TipoDeServico, An.Nome Animal   " & _
    '                " FROM Ass_Tecnicos T, " & _
    '                " Ass_TipoServico TS, Ass_Associados AA, Ass_MovPrefeituras M " & _
    '                " LEFT JOIN Ass_Animais An ON M.Animal = An.Codigo " & _
    '                " WHERE M.Tecnico = T.Codigo  " & _
    '                " AND M.Associado = AA.Codigo " & _
    '                " AND M.TipoServico = TS.Codigo " & _
    '                " AND isnull(M.Data_Hora_Exclusao,'') = '' " & _
    '                " AND M.Data between '" & txtDataInicio.Value & "' AND '" & txtDataFim.Value & "' " & _
    '                " ORDER BY M.Data DESC, M.Prefeitura "
    '    '" ORDER BY T.Nome,M.Documento "

    '    wControle = objMovPrefeituras_Implem.MostraTabelaMovPrefeiturass(dtgMovPrefeiturass, wSQL)
    '    If wControle <> 0 Then objVariaveisGlobais.MostraErro()
    '    PreencheCampoPesquisa()
    '    FazFiltro()

    'End Sub

    Private Sub AtualizaMovPrefeituras()

        Dim wControle As Integer

        'Dim wPesquisaTipoServico As String
        'If cbPesquisaTipoServico.SelectedIndex > 0 Then
        '    wPesquisaTipoServico = " AND s.Codigo ='" & cbPesquisaTipoServico.SelectedItem.value & "'"
        'Else
        '    wPesquisaTipoServico = ""
        'End If

        Dim wSQL As String = " SET DATEFORMAT DMY SELECT M.IdMovimento, p.Nome, M.Data, AA.Nome, AA.Endereco, " & _
                    " LEFT(InscricaoEstadual, 3) + '/' + RIGHT(InscricaoEstadual, 7) AS Inscricao, " & _
                    " T.Nome, M.Valor, T.CRMV, M.NumeroTestes, s.Codigo " & _
                    " FROM Ass_Tecnicos T, " & _
                    " Ass_Associados AA, Ass_MovPrefeituras M, Ass_prefeituras p, Ass_TipoServico s " & _
                    " WHERE M.Tecnico = T.Codigo  " & _
                    " AND M.Associado = AA.Codigo " & _
                    " AND p.Codigo = m.Prefeitura " & _
                    " AND s.Codigo = m.TipoServico " & _
                    " AND isnull(M.Data_Hora_Exclusao,'') = '' " & _
                    " AND M.Data BETWEEN '" & txtDataInicio.Value & "' AND '" & txtDataFim.Value & "' " & _
                    " ORDER BY M.Data ASC, M.Prefeitura, IdMovimento, M.Data_Hora_Cadastro "
        '" ORDER BY T.Nome,M.Documento "

        wControle = objMovPrefeituras_Implem.MostraTabelaMovPrefeituras(dtgMovPrefeituras, wSQL)
        If wControle <> 0 Then objVariaveisGlobais.MostraErro()
        PreencheCampoPesquisa()
        FazFiltro()

    End Sub

    Private Sub PreencheCampoPesquisa()
        If cbCampo.Items.Count = 0 Then
            Dim c As New System.Web.UI.WebControls.ListItem
            For i As Integer = 0 To dtgMovPrefeituras.Columns.Count - 1
                If dtgMovPrefeituras.Columns(i).ValueType.ToString = GetType(String).ToString AndAlso dtgMovPrefeituras.Columns(i).Visible = True Then
                    c = New System.Web.UI.WebControls.ListItem
                    c.Value = dtgMovPrefeituras.Columns(i).HeaderText
                    c.Text = dtgMovPrefeituras.Columns(i).HeaderText
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
        If txtDataInicio.Text <> "" AndAlso CDate(txtDataInicio.Text) > (txtDataFim.Text) Then
            ErrorProvider1.SetError(txtDataInicio, "Data Início maior que Data Fim")
            Return False
        Else
            ErrorProvider1.SetError(txtDataInicio, "")
        End If
        If Not IsNothing(dtgMovPrefeituras.DataSource) Then
            Dim wDataTable As New DataTable
            Dim wPesquisa As String = ""

            If rbComecarPor.Checked Then
                wPesquisa = cbCampo.Text & " like '" & txtPesquisa.Text & "%'"
            ElseIf rbConter.Checked Then
                wPesquisa = cbCampo.Text & " like '%" & txtPesquisa.Text & "%'"
            ElseIf rbExato.Checked Then
                wPesquisa = cbCampo.Text & " ='" & txtPesquisa.Text & "'"
            End If

            If cbPesquisaTipoServico.SelectedIndex > 0 Then
                wPesquisa += " AND CodigoTipoServico ='" & cbPesquisaTipoServico.SelectedItem.value & "'"
            End If

            Dim wValida As Boolean
            For i As Integer = 0 To dtgMovPrefeituras.Columns.Count - 1
                If dtgMovPrefeituras.Columns(i).Name = cbCampo.Text Then
                    wValida = True
                    Exit For
                End If
            Next

            If wValida = False Then
                MsgBox("Campo pesquisa está incorreto")
                Return wValida
            End If

            wDataTable = objMovPrefeituras_Implem.wDataSet.Tables(0)
            Dim wDataView = New DataView(wDataTable, _
                     wPesquisa, _
                     "", DataViewRowState.CurrentRows)
            dtgMovPrefeituras.DataSource = wDataView
        End If
        Return True
    End Function

    Private Sub dtgMovPrefeiturass_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgMovPrefeituras.MouseMove
        Try
            Dim hti As System.Windows.Forms.DataGridView.HitTestInfo
            hti = dtgMovPrefeituras.HitTest(e.X, e.Y)

            If hti.Type = System.Windows.Forms.DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 11 Then
                    Me.Cursor = System.Windows.Forms.Cursors.Hand
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand
                Else
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                End If
                If hti.ColumnIndex = 11 Then
                    ToolTip1.SetToolTip(dtgMovPrefeituras, "")
                End If
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                ToolTip1.SetToolTip(dtgMovPrefeituras, "")
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgMovPrefeiturass_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgMovPrefeituras.MouseUp
        Try
            Dim hti As DataGridView.HitTestInfo = dtgMovPrefeituras.HitTest(e.X, e.Y)

            If hti.Type = DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 11 Then
                    TelaAlteracaoMovPrefeiturass()
                End If
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgMovPrefeiturass_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgMovPrefeituras.CurrentCellChanged
        Try
            Dim wControle As Integer
            If IsNothing(dtgMovPrefeituras.DataSource) Or IsNothing(dtgMovPrefeituras.CurrentCell) Then Exit Sub

            objMovPrefeituras_Implem.IdMovimento = dtgMovPrefeituras.Item(0, dtgMovPrefeituras.CurrentCell().RowIndex).Value
            wControle = objMovPrefeituras_Implem.BuscarMovPrefeituras
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            dtgMovPrefeituras.Rows(dtgMovPrefeituras.CurrentCell().RowIndex).Selected = True
            dtgMovPrefeituras.Focus()
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
            '  If Not IsDate(txtData.Text) Then
            txtData.Text = ConverteDataParaString(Date.Now)
            'cbTipoServico.SelectedIndex = 0
            'cbPrefeitura.SelectedIndex = 0
            ' End If

            txtNome_Associado.Text = ""
            txtInscricaoEstadual.Text = ""
            txtCodigo_Associado.Text = ""
            txtCRMV.Text = 0
            txtNumeroTestes.Text = 1
            txtNumeroTestes.Visible = False
            lNumeroTestes.Visible = False

            txtValor.Text = "0,00"

            txtData.Enabled = True

            If cbTipoServico.SelectedIndex > 0 Then
                objTiposServico_Implem.Codigo = cbTipoServico.SelectedItem.value
                wControle = objTiposServico_Implem.BuscarServico()
                If wControle < 0 Then
                    objVariaveisGlobais.MostraErro()
                ElseIf wControle > 0 Then
                    MsgBox("Tipo de Serviço nao existe!")
                    Exit Sub
                End If
            End If

            txtDataCadastro.Text = ConverteDataHoraParaString(Date.Now)
            objVariaveisGlobais.SetaComboBox(cbUsuarioCadastro, VariaveisGlobais.gCodigoUsuario)

            btAlterar.Enabled = False
            btExcluir.Enabled = False
            txtIdMovimento.Enabled = False

            If wNovoRegistro = False Then
                AtualizaMovPrefeituras()
                btNovo.Enabled = True
                btAdicionar.Enabled = False
                'btLimpar.Enabled = False
                TabControl1.SelectedIndex = 0
                tpManutencao.Enabled = False
                txtPesquisa.Focus()
            Else
                btAdicionar.Enabled = vIncluir
                'btLimpar.Enabled = True
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
        If txtIdMovimento.Text <> "" Then
            cbTecnico.SelectedIndex = 0
            cbTipoServico.SelectedIndex = 0
            cbPrefeitura.SelectedIndex = 0
        End If
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
        cbPrefeitura_Validating(cbPrefeitura, e1)
        cbTecnico_Validating(cbTecnico, e1)
        cbTipoServico_Validating(cbTipoServico, e1)

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
        ErrorProvider1.SetError(cbTecnico, "")
        ErrorProvider1.SetError(txtCodigo_Associado, "")
        ErrorProvider1.SetError(txtNome_Associado, "")
        'ErrorProvider1.SetError(cbAssociado, "")
        ErrorProvider1.SetError(cbTipoServico, "")
        ErrorProvider1.SetError(cbPrefeitura, "")

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

    Private Sub cbPrefeitura_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbPrefeitura.Validating
        Try
            Dim wMsgErro As String = ""

            If cbPrefeitura.SelectedIndex <= 0 Then
                wMsgErro = "Informe a Prefeitura !"
            End If

            If wMsgErro = "" Then
                ErrorProvider1.SetError(cbPrefeitura, "")
                VariaveisGlobais.gErroTela(6) = ""
            Else
                ErrorProvider1.SetError(cbPrefeitura, wMsgErro)
                VariaveisGlobais.gErroTela(6) = wMsgErro
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub cbTipoServico_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTipoServico.Validating
        Try
            Dim wMsgErro As String = ""

            If cbTipoServico.SelectedIndex <= 0 Then
                wMsgErro = "Informe o Tipo de Serviço !"
            End If

            If wMsgErro = "" Then
                ErrorProvider1.SetError(cbTipoServico, "")
                VariaveisGlobais.gErroTela(6) = ""
            Else
                ErrorProvider1.SetError(cbTipoServico, wMsgErro)
                VariaveisGlobais.gErroTela(6) = wMsgErro
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

    Dim Data As String
    Dim Produtor As String
    Dim Localidade As String
    Dim Inscricao As String
    Dim Tecnico As String
    Dim Valor As Decimal
    Dim CRMV As String
    Dim NTestes As String
    Dim wPos(6, 1) As String ' Matriz que armazena texto e posição

    Dim TotalRecords As Integer = 0
    Dim pagina As Integer = 0
    Dim dados As Integer = 0
    Dim dlg As PrintPreviewDialog

    Dim printFont1 As New Font("Arial", 6, FontStyle.Bold, GraphicsUnit.Millimeter)
    Dim printFontP As New Font("Arial", 2.5, FontStyle.Regular, GraphicsUnit.Millimeter)
    Dim printFont As New Font("Courier New", 3, FontStyle.Regular, GraphicsUnit.Millimeter)
    Dim printFontB As New Font("Arial", 3, FontStyle.Bold, GraphicsUnit.Millimeter)
    Dim printFontBB As New Font("Arial", 5, FontStyle.Bold, GraphicsUnit.Millimeter)

    Dim dFrl As New StringFormat
    Dim dFac As New StringFormat
    Dim mpreview As Boolean
    Dim blackPen As New Pen(Color.Black, 1)

    Dim ContadorRegistro As Integer
    Dim wValorTotal As Decimal = 0

#End Region

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click

        Try
            If dtgMovPrefeituras.RowCount < 1 Then
                MessageBox.Show("Sem registros na tabela, o relatório não ser impresso ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim wControle As Integer
            objPrefeituras_Implem.NomePrefeitura = txtPesquisa.Text
            wControle = objPrefeituras_Implem.VerificaExistenciaPrefeituraPeloNome()
            If wControle = 0 And cbCampo.SelectedIndex = 0 Then
            ElseIf wControle = 1 Or cbCampo.SelectedIndex <> 0 Then
                MessageBox.Show("Informe o nome completo da prefeitura no campo de pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf wControle = -1 Then
                Throw New Exception
            End If

            If cbPesquisaTipoServico.SelectedIndex < 1 Then
                MessageBox.Show("Informe um tipo de serviço", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If CDate(txtDataInicio.Text).Month <> CDate(txtDataFim.Text).Month Then 'Validação feita para o sistema consseguir saber qual mês colocar no cabeçalho
                MessageBox.Show("Intervalo de pesquisa das datas deve contemplar um único mês", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'FazFiltro()
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
            If dtgMovPrefeituras.RowCount < 1 Then
                MessageBox.Show("Sem registros na tabela, o relatório não ser exibido ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim wControle As Integer
            objPrefeituras_Implem.NomePrefeitura = txtPesquisa.Text
            wControle = objPrefeituras_Implem.VerificaExistenciaPrefeituraPeloNome()
            If wControle = 0 And cbCampo.SelectedIndex = 0 Then
            ElseIf wControle = 1 Or cbCampo.SelectedIndex <> 0 Then
                MessageBox.Show("Informe o nome completo da prefeitura no campo de pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf wControle = -1 Then
                Throw New Exception
            End If

            If cbPesquisaTipoServico.SelectedIndex < 1 Then
                MessageBox.Show("Informe um tipo de serviço", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If CDate(txtDataInicio.Text).Month <> CDate(txtDataFim.Text).Month Then 'Validação feita para o sistema consseguir saber qual mês colocar no cabeçalho
                MessageBox.Show("Intervalo de pesquisa das datas deve contemplar um único mês", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            wValorTotal = 0

            'FazFiltro()
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
            'MessageBox.Show("An error occurred - " + ex.Message)
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
        Handles PrintDocument1.PrintPage
        If mpreview = False Then
            ContadorRegistro = 0
            pagina = 0
            dados = 0
        End If
        TotalRecords = dtgMovPrefeituras.RowCount

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
        Try

            Dim wControle As Integer
            mpreview = True
            dFrl.FormatFlags = StringFormatFlags.DirectionRightToLeft
            dFac.Alignment = StringAlignment.Center
            pagina += 1

            Dim yPos As Integer = 130
            For i As Integer = ContadorRegistro To TotalRecords - 1
                yPos += 25
                If yPos > wAlturaPapel - 130 Then
                    e.Graphics.DrawString("Página: " & pagina, printFont, sdb, 780, 1080, dFrl)
                    e.HasMorePages = True
                    ContadorRegistro = i

                    MontaCabecalho(e)
                    e.Graphics.DrawLine(blackPen, CInt(wPos(0, 1)), 130, CInt(wPos(0, 1)), yPos) 'Linha vertical
                    e.Graphics.DrawLine(blackPen, CInt(wPos(1, 1)), 130, CInt(wPos(1, 1)), yPos) 'Linha vertical
                    e.Graphics.DrawLine(blackPen, CInt(wPos(2, 1)), 130, CInt(wPos(2, 1)), yPos) 'Linha vertical
                    e.Graphics.DrawLine(blackPen, CInt(wPos(3, 1)), 130, CInt(wPos(3, 1)), yPos) 'Linha vertical
                    e.Graphics.DrawLine(blackPen, CInt(wPos(4, 1)), 130, CInt(wPos(4, 1)), yPos) 'Linha vertical
                    e.Graphics.DrawLine(blackPen, CInt(wPos(5, 1)), 130, CInt(wPos(5, 1)), yPos) 'Linha vertical
                    e.Graphics.DrawLine(blackPen, CInt(wPos(6, 1)), 130, CInt(wPos(6, 1)), yPos) 'Linha vertical
                    e.Graphics.DrawLine(blackPen, 40, yPos, 780, yPos) 'Linha horizontal
                    Exit Sub
                End If

                wControle = SetaValores(i)
                If wControle <> 0 Then
                    Throw New Exception
                End If

                wValorTotal += Valor

                e.Graphics.DrawString(wPos(0, 0), printFont, sdb, wPos(0, 1), yPos + 5)
                e.Graphics.DrawString(wPos(1, 0), printFont, sdb, wPos(1, 1), yPos + 5)
                e.Graphics.DrawString(wPos(2, 0), printFont, sdb, wPos(2, 1), yPos + 5)
                e.Graphics.DrawString(wPos(3, 0), printFont, sdb, wPos(3, 1), yPos + 5)
                e.Graphics.DrawString(wPos(4, 0), printFont, sdb, wPos(4, 1), yPos + 5)
                e.Graphics.DrawString(wPos(5, 0), printFont, sdb, wPos(5, 1), yPos + 5)
                e.Graphics.DrawString(wPos(6, 0), printFont, sdb, wPos(6, 1), yPos + 5)

                'e.Graphics.DrawString(Data, printFont, sdb, 40, yPos)
                'e.Graphics.DrawString((Produtor & Space(21)).Substring(0, 21), printFont, sdb, 140, yPos)
                'e.Graphics.DrawString((Localidade & Space(15)).Substring(0, 15), printFont, sdb, 310, yPos)
                'e.Graphics.DrawString((Inscricao & Space(14)).Substring(0, 14), printFont, sdb, 440, yPos)
                'e.Graphics.DrawString((Tecnico & Space(18)).Substring(0, 18), printFont, sdb, 540, yPos)
                'e.Graphics.DrawString((Valor & Space(14)).Substring(0, 14), printFont, sdb, 780, yPos, dFrl)
                'e.Graphics.DrawString("R$ ", printFont, sdb, 700, yPos)
                e.Graphics.DrawLine(blackPen, 40, yPos, 780, yPos)
            Next
            yPos += 25
            e.Graphics.DrawLine(blackPen, 40, yPos, 780, yPos) 'Linha Horizontal
            e.Graphics.DrawLine(blackPen, CInt(wPos(0, 1)), 130, CInt(wPos(0, 1)), yPos) 'Linha vertical
            e.Graphics.DrawLine(blackPen, CInt(wPos(1, 1)), 130, CInt(wPos(1, 1)), yPos) 'Linha vertical
            e.Graphics.DrawLine(blackPen, CInt(wPos(2, 1)), 130, CInt(wPos(2, 1)), yPos) 'Linha vertical
            e.Graphics.DrawLine(blackPen, CInt(wPos(3, 1)), 130, CInt(wPos(3, 1)), yPos) 'Linha vertical
            e.Graphics.DrawLine(blackPen, CInt(wPos(4, 1)), 130, CInt(wPos(4, 1)), yPos) 'Linha vertical
            e.Graphics.DrawLine(blackPen, CInt(wPos(5, 1)), 130, CInt(wPos(5, 1)), yPos) 'Linha vertical
            e.Graphics.DrawLine(blackPen, CInt(wPos(6, 1)), 130, CInt(wPos(6, 1)), yPos) 'Linha vertical
            e.Graphics.DrawLine(blackPen, 40, yPos, 40, yPos + 25) 'Linha vertical
            e.Graphics.DrawLine(blackPen, 780, yPos, 780, yPos + 25) 'Linha vertical
            e.Graphics.DrawLine(blackPen, 40, yPos + 25, 780, yPos + 25) 'Linha horizontal
            e.Graphics.DrawString(("Total: " & TotalRecords).ToUpper, printFontB, sdb, 40, yPos + 5)
            If txtPesquisa.Text.ToUpper = "Teutônia".ToUpper And (cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Or cbPesquisaTipoServico.Text.ToUpper = "Corrida de Inseminação".ToUpper) Then
                If cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Then
                    e.Graphics.DrawString("R$ " & String.Format("{0,17:D }", CStr(Format(CDec(wValorTotal), "###,##0.00"))), printFontB, sdb, wPos(5, 1), yPos + 5)
                Else
                    e.Graphics.DrawString("R$ " & String.Format("{0,11:D }", CStr(Format(CDec(wValorTotal), "###,##0.00"))), printFontB, sdb, wPos(5, 1), yPos + 5)
                End If
            End If
            e.Graphics.DrawString("Página: " & pagina, printFont, sdb, 780, 1080, dFrl)

            MontaCabecalho(e)
            mpreview = False
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

#Region "Monta Cabeçalho "

    Private Function SetaValores(ByVal i As Integer) As Integer
        'Esta função verifica e seta o texto na ordem que deve ser impressa e as posições no relatório de acordo 
        'com a prefeitura escolhida

        Data = dtgMovPrefeituras.Item(2, i).Value
        Data = Data.Replace("/20", "/")
        Produtor = dtgMovPrefeituras.Item(3, i).Value
        Localidade = dtgMovPrefeituras.Item(4, i).Value
        Inscricao = NullBranco(dtgMovPrefeituras.Item(5, i).Value)
        Tecnico = dtgMovPrefeituras.Item(6, i).Value.ToString.Split(" ")(0)
        Valor = NullDecimal(dtgMovPrefeituras.Item(7, i).Value)
        CRMV = NullBranco(dtgMovPrefeituras.Item(8, i).Value)
        NTestes = NullBranco(dtgMovPrefeituras.Item(9, i).Value)

        Try
            If cbPesquisaTipoServico.Text.ToUpper = "Teste de Tuberculose".ToUpper Then
                SetaValoresTestes()
            ElseIf txtPesquisa.Text.ToUpper = "Imigrante".ToUpper And (cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Or cbPesquisaTipoServico.Text.ToUpper = "Corrida de Inseminação".ToUpper) Then
                If cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Then
                    SetaValoresImigranteVeterinario()
                Else
                    SetaValoresImigranteInseminacao()
                End If
            ElseIf txtPesquisa.Text.ToUpper = "Teutônia".ToUpper And (cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Or cbPesquisaTipoServico.Text.ToUpper = "Corrida de Inseminação".ToUpper) Then
                    If cbPesquisaTipoServico.Text.ToUpper = "Corrida de Inseminação".ToUpper Then
                        SetaValoresTeutoniaInseminacao()
                    Else
                        SetaValoresTeutoniaVeterinario()
                    End If
            ElseIf txtPesquisa.Text.ToUpper = "Poco Das Antas".ToUpper And (cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Or cbPesquisaTipoServico.Text.ToUpper = "Corrida de Inseminação".ToUpper) Then
                    SetaValoresPocoDasAntasInseminacaoEVeterinaro()
            ElseIf txtPesquisa.Text.ToUpper = "Fazenda Vilanova".ToUpper And (cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Or cbPesquisaTipoServico.Text.ToUpper = "Corrida de Inseminação".ToUpper) Then
                    SetaValoresFazendaVilaNovaInseminacaoEVeterinario()
            ElseIf txtPesquisa.Text.ToUpper = "Westfália".ToUpper And cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Then
                    SetaValoresTeutoniaWestfaliaVeterinario()
            Else
                    SetaValoresPadrao()
            End If
            Return 0
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Private Sub SetaValoresImigranteInseminacao()
        wPos(0, 0) = (Produtor & Space(37)).Substring(0, 37)
        wPos(0, 1) = 40
        wPos(1, 0) = (Localidade & Space(26)).Substring(0, 26)
        wPos(1, 1) = 320
        wPos(2, 0) = Inscricao
        wPos(2, 1) = 520
        wPos(3, 0) = Data
        wPos(3, 1) = 610
        wPos(4, 0) = (Tecnico & Space(13)).Substring(0, 13)
        wPos(4, 1) = 680
        wPos(5, 0) = ""
        wPos(5, 1) = 780
        wPos(6, 0) = ""
        wPos(6, 1) = 0
    End Sub

    Private Sub SetaValoresImigranteVeterinario()
        wPos(0, 0) = (Produtor & Space(37)).Substring(0, 37)
        wPos(0, 1) = 40
        wPos(1, 0) = (Localidade & Space(26)).Substring(0, 26)
        wPos(1, 1) = 320
        wPos(2, 0) = Inscricao
        wPos(2, 1) = 520
        wPos(3, 0) = Data
        wPos(3, 1) = 610
        wPos(4, 0) = CRMV
        wPos(4, 1) = 700
        wPos(5, 0) = ""
        wPos(5, 1) = 780
        wPos(6, 0) = ""
        wPos(6, 1) = 0
    End Sub

    Private Sub SetaValoresPocoDasAntasInseminacaoEVeterinaro()
        wPos(0, 0) = (Produtor & Space(37)).Substring(0, 37)
        wPos(0, 1) = 40
        wPos(1, 0) = (Localidade & Space(26)).Substring(0, 26)
        wPos(1, 1) = 320
        wPos(2, 0) = Inscricao
        wPos(2, 1) = 520
        wPos(3, 0) = Data
        wPos(3, 1) = 610
        wPos(4, 0) = CRMV
        wPos(4, 1) = 680
        wPos(5, 0) = ""
        wPos(5, 1) = 780
        wPos(6, 0) = ""
        wPos(6, 1) = 0
    End Sub

    Private Sub SetaValoresFazendaVilaNovaInseminacaoEVeterinario()
        wPos(0, 0) = (Produtor & Space(37)).Substring(0, 37)
        wPos(0, 1) = 40
        wPos(1, 0) = (Localidade & Space(26)).Substring(0, 26)
        wPos(1, 1) = 320
        wPos(2, 0) = Inscricao
        wPos(2, 1) = 520
        wPos(3, 0) = Data
        wPos(3, 1) = 610
        wPos(4, 0) = CRMV
        wPos(4, 1) = 680
        wPos(5, 0) = ""
        wPos(5, 1) = 780
        wPos(6, 0) = ""
        wPos(6, 1) = 0
    End Sub

    Private Sub SetaValoresTeutoniaInseminacao()
        wPos(0, 0) = Data
        wPos(0, 1) = 40
        wPos(1, 0) = (Produtor & Space(37)).Substring(0, 36) '36
        wPos(1, 1) = 105
        wPos(2, 0) = (Localidade & Space(21)).Substring(0, 21)
        wPos(2, 1) = 380
        wPos(3, 0) = Inscricao
        wPos(3, 1) = 540
        wPos(4, 0) = (Tecnico & Space(13)).Substring(0, 13)
        wPos(4, 1) = 625
        wPos(5, 0) = "R$ " & String.Format("{0,6:D }", CStr(Format(CDec(Valor), "###,##0.00")))
        wPos(5, 1) = 710
        wPos(6, 0) = ""
        wPos(6, 1) = 780
    End Sub

    Private Sub SetaValoresTeutoniaVeterinario()
        wPos(0, 0) = (Produtor & Space(39)).Substring(0, 39)
        wPos(0, 1) = 40
        wPos(1, 0) = (Localidade & Space(20)).Substring(0, 20)
        wPos(1, 1) = 330
        wPos(2, 0) = Inscricao
        wPos(2, 1) = 480
        wPos(3, 0) = Data
        wPos(3, 1) = 570
        wPos(4, 0) = CRMV
        wPos(4, 1) = 640
        wPos(5, 0) = "R$ " & String.Format("{0,9:D }", CStr(Format(CDec(Valor), "###,##0.00")))
        wPos(5, 1) = 690
        wPos(6, 0) = ""
        wPos(6, 1) = 780
    End Sub

    Private Sub SetaValoresTeutoniaWestfaliaVeterinario()
        wPos(0, 0) = (Produtor & Space(39)).Substring(0, 39)
        wPos(0, 1) = 40
        wPos(1, 0) = (Localidade & Space(20)).Substring(0, 20)
        wPos(1, 1) = 330
        wPos(2, 0) = Inscricao
        wPos(2, 1) = 480
        wPos(3, 0) = Data
        wPos(3, 1) = 570
        wPos(4, 0) = CRMV
        wPos(4, 1) = 640
        wPos(5, 0) = "R$ " & String.Format("{0,9:D }", CStr(Format(CDec(Valor), "###,##0.00")))
        wPos(5, 1) = 690
        wPos(6, 0) = ""
        wPos(6, 1) = 780
    End Sub

    Private Sub SetaValoresTestes()
        wPos(0, 0) = (Produtor & Space(40)).Substring(0, 40)
        wPos(0, 1) = 40
        wPos(1, 0) = (Localidade & Space(20)).Substring(0, 20)
        wPos(1, 1) = 350
        wPos(2, 0) = Inscricao
        wPos(2, 1) = 500
        wPos(3, 0) = Data
        wPos(3, 1) = 590
        wPos(4, 0) = CRMV
        wPos(4, 1) = 660
        wPos(5, 0) = NTestes
        wPos(5, 1) = 710
        wPos(6, 0) = ""
        wPos(6, 1) = 780
    End Sub

    Private Sub SetaValoresPadrao()
        wPos(0, 0) = Data
        wPos(0, 1) = 40
        wPos(1, 0) = (Produtor & Space(35)).Substring(0, 34)
        wPos(1, 1) = 105
        wPos(2, 0) = (Localidade & Space(21)).Substring(0, 21)
        wPos(2, 1) = 360
        wPos(3, 0) = Inscricao
        wPos(3, 1) = 520
        wPos(4, 0) = (Tecnico & Space(13)).Substring(0, 13)
        wPos(4, 1) = 610
        wPos(5, 0) = "R$ " & String.Format("{0,6:D }", CStr(Format(CDec(Valor), "###,##0.00")))
        wPos(5, 1) = 710
        wPos(6, 0) = ""
        wPos(6, 1) = 780
    End Sub

#End Region

#Region "Monta Cabeçalho "

    Private Sub MontaCabecalho(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        If cbPesquisaTipoServico.Text.ToUpper = "Teste de Tuberculose".ToUpper Then
            MontaCabecalhoTestes(e)
        ElseIf txtPesquisa.Text.ToUpper = "Imigrante".ToUpper And (cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Or cbPesquisaTipoServico.Text.ToUpper = "Corrida de Inseminação".ToUpper) Then
            If cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Then
                MontaCabecalhoImigranteVeterinario(e)
            Else
                MontaCabecalhoImigranteInseminacao(e)
            End If
        ElseIf txtPesquisa.Text.ToUpper = "Teutônia".ToUpper And (cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Or cbPesquisaTipoServico.Text.ToUpper = "Corrida de Inseminação".ToUpper) Then
                If cbPesquisaTipoServico.Text = "Corrida de inseminação".ToUpper Then
                    MontaCabecalhoTeutoniaInseminacao(e)
                ElseIf cbPesquisaTipoServico.Text = "Corrida de Veterinário".ToUpper Then
                    MontaCabecalhoTeutoniaVeterinario(e)
                End If
        ElseIf txtPesquisa.Text.ToUpper = "Poco Das Antas".ToUpper And (cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Or cbPesquisaTipoServico.Text.ToUpper = "Corrida de Inseminação".ToUpper) Then
                MontaCabecalhoPocoDasAntasInseminacaoEVeterinario(e)
        ElseIf txtPesquisa.Text.ToUpper = "Fazenda Vilanova".ToUpper And (cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Or cbPesquisaTipoServico.Text.ToUpper = "Corrida de Inseminação".ToUpper) Then
                MontaCabecalhoFazendaVilaNovaInseminacaoEVeterinarios(e)
        ElseIf txtPesquisa.Text.ToUpper = "Westfália".ToUpper And cbPesquisaTipoServico.Text.ToUpper = "Corrida de Veterinário".ToUpper Then
                MontaCabecalhoWestfaliaVeterinario(e)
        Else
                MessageBox.Show("Não existe cabeçalho configurado para essa prefeitura para este tipo de serviço." & _
                                " Foi colocado um cabeçalho padrão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                MontaCabecalhoPadrao(e)
        End If
    End Sub

    Private Sub MontaCabecalhoImigranteInseminacao(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.DrawString("Agroserv-cooperativa de serviços agropecuários ltda".ToUpper, printFontB, sdb, 390, 55, dFac)
        e.Graphics.DrawString("Prefeitura municipal de Imigrante".ToUpper, printFontB, sdb, 390, 72, dFac)

        e.Graphics.DrawString("Serviços de Inseminação".ToUpper, printFontB, sdb, 390, 89, dFac)

        e.Graphics.DrawString(("Data Inicial -").ToUpper, printFontB, sdb, 40, 106)
        e.Graphics.DrawString((txtDataInicio.Text).ToUpper, printFontB, sdb, 140, 106)
        e.Graphics.DrawString(("Final -").ToUpper, printFontB, sdb, 230, 106)
        e.Graphics.DrawString((txtDataFim.Text).ToUpper, printFontB, sdb, 280, 106)
        e.Graphics.DrawString(("Período - ").ToUpper, printFontB, sdb, 390, 106)
        e.Graphics.DrawString((MonthName(CDate(txtDataInicio.Text).Month)).ToUpper, printFontB, sdb, 470, 106)

        e.Graphics.DrawLine(blackPen, 40, 130, 780, 130) 'Linha Horizontal
        e.Graphics.DrawString("Nome".ToUpper, printFontB, sdb, CalculaCentro(0), 135, dFac)
        e.Graphics.DrawString("Localidade".ToUpper, printFontB, sdb, CalculaCentro(1), 135, dFac)
        e.Graphics.DrawString("Inscrição".ToUpper, printFontB, sdb, CalculaCentro(2), 135, dFac)
        e.Graphics.DrawString("Data".ToUpper, printFontB, sdb, CalculaCentro(3), 135, dFac)
        e.Graphics.DrawString("Inseminador".ToUpper, printFontB, sdb, CalculaCentro(4), 135, dFac)
        'e.Graphics.DrawString("Emitido em " & ConverteDataParaString(Date.Now) & _
        '" por " & VariaveisGlobais.gNomeUsuario & " - Pág " & pagina, printFontP, Brushes.Black, 780, wAlturaPapel - 80, dFrl)
    End Sub

    Private Sub MontaCabecalhoImigranteVeterinario(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.DrawString("Agroserv-cooperativa de serviços agropecuários ltda".ToUpper, printFontB, sdb, 390, 55, dFac)
        e.Graphics.DrawString("Prefeitura municipal de Imigrante".ToUpper, printFontB, sdb, 390, 72, dFac)
        e.Graphics.DrawString("Serviços de Veterinária".ToUpper, printFontB, sdb, 390, 89, dFac)

        e.Graphics.DrawString(("Data Inicial -").ToUpper, printFontB, sdb, 40, 106)
        e.Graphics.DrawString((txtDataInicio.Text).ToUpper, printFontB, sdb, 140, 106)
        e.Graphics.DrawString(("Final -").ToUpper, printFontB, sdb, 230, 106)
        e.Graphics.DrawString((txtDataFim.Text).ToUpper, printFontB, sdb, 280, 106)
        e.Graphics.DrawString(("Período - ").ToUpper, printFontB, sdb, 390, 106)
        e.Graphics.DrawString((MonthName(CDate(txtDataInicio.Text).Month)).ToUpper, printFontB, sdb, 470, 106)

        e.Graphics.DrawLine(blackPen, 40, 130, 780, 130) 'Linha Horizontal
        e.Graphics.DrawString("Nome".ToUpper, printFontB, sdb, CalculaCentro(0), 135, dFac)
        e.Graphics.DrawString("Localidade".ToUpper, printFontB, sdb, CalculaCentro(1), 135, dFac)
        e.Graphics.DrawString("Inscrição".ToUpper, printFontB, sdb, CalculaCentro(2), 135, dFac)
        e.Graphics.DrawString("Data".ToUpper, printFontB, sdb, CalculaCentro(3), 135, dFac)
        e.Graphics.DrawString("CRMV".ToUpper, printFontB, sdb, CalculaCentro(4), 135, dFac)
        'e.Graphics.DrawString("Emitido em " & ConverteDataParaString(Date.Now) & _
        '" por " & VariaveisGlobais.gNomeUsuario & " - Pág " & pagina, printFontP, Brushes.Black, 780, wAlturaPapel - 80, dFrl)
    End Sub

    Private Sub MontaCabecalhoPocoDasAntasInseminacaoEVeterinario(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.DrawString("Agroserv-cooperativa de serviços agropecuários ltda".ToUpper, printFontB, sdb, 390, 55, dFac)
        e.Graphics.DrawString("Prefeitura municipal de Poço das Antas".ToUpper, printFontB, sdb, 390, 72, dFac)
        If cbPesquisaTipoServico.Text.ToUpper = "Corrida de Inseminação".ToUpper Then
            e.Graphics.DrawString("Serviços de Inseminação".ToUpper, printFontB, sdb, 390, 89, dFac)
        Else
            e.Graphics.DrawString("Serviços Veterinários".ToUpper, printFontB, sdb, 390, 89, dFac)
        End If

        e.Graphics.DrawString(("Data Inicial: ").ToUpper, printFontB, sdb, 40, 106)
        e.Graphics.DrawString((txtDataInicio.Text).ToUpper, printFontB, sdb, 130, 106)
        e.Graphics.DrawString(("Data Final: ").ToUpper, printFontB, sdb, 250, 106)
        e.Graphics.DrawString((txtDataFim.Text).ToUpper, printFontB, sdb, 330, 106)
        e.Graphics.DrawString((MonthName(CDate(txtDataInicio.Text).Month)).ToUpper, printFontB, sdb, 470, 106)

        e.Graphics.DrawLine(blackPen, 40, 130, 780, 130) 'Linha Horizontal
        e.Graphics.DrawString("Nome".ToUpper, printFontB, sdb, CalculaCentro(0), 135, dFac)
        e.Graphics.DrawString("Localidade".ToUpper, printFontB, sdb, CalculaCentro(1), 135, dFac)
        e.Graphics.DrawString("Inscrição".ToUpper, printFontB, sdb, CalculaCentro(2), 135, dFac)
        e.Graphics.DrawString("Data".ToUpper, printFontB, sdb, CalculaCentro(3), 135, dFac)
        e.Graphics.DrawString("CRMV".ToUpper, printFontB, sdb, CalculaCentro(4), 135, dFac)
        'e.Graphics.DrawString("Emitido em " & ConverteDataParaString(Date.Now) & _
        '" por " & VariaveisGlobais.gNomeUsuario & " - Pág " & pagina, printFontP, Brushes.Black, 780, wAlturaPapel - 80, dFrl)
    End Sub

    Private Sub MontaCabecalhoFazendaVilaNovaInseminacaoEVeterinarios(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.DrawString("Agroserv-cooperativa de serviços agropecuários ltda".ToUpper, printFontB, sdb, 390, 55, dFac)
        e.Graphics.DrawString("Prefeitura municipal de Fazenda Vilanova".ToUpper, printFontB, sdb, 390, 72, dFac)
        If cbPesquisaTipoServico.Text.ToUpper = "Corrida de Inseminação".ToUpper Then
            e.Graphics.DrawString("Serviços de Inseminação".ToUpper, printFontB, sdb, 390, 89, dFac)
        Else
            e.Graphics.DrawString("Serviços Veterinários".ToUpper, printFontB, sdb, 390, 89, dFac)
        End If

        e.Graphics.DrawString(("Data Inicial: ").ToUpper, printFontB, sdb, 40, 106)
        e.Graphics.DrawString((txtDataInicio.Text).ToUpper, printFontB, sdb, 130, 106)
        e.Graphics.DrawString(("Data Final: ").ToUpper, printFontB, sdb, 250, 106)
        e.Graphics.DrawString((txtDataFim.Text).ToUpper, printFontB, sdb, 330, 106)
        e.Graphics.DrawString(("Período: ").ToUpper, printFontB, sdb, 420, 106)
        e.Graphics.DrawString((MonthName(CDate(txtDataInicio.Text).Month)).ToUpper, printFontB, sdb, 490, 106)

        e.Graphics.DrawLine(blackPen, 40, 130, 780, 130) 'Linha Horizontal
        e.Graphics.DrawString("Nome".ToUpper, printFontB, sdb, CalculaCentro(0), 135, dFac)
        e.Graphics.DrawString("Localidade".ToUpper, printFontB, sdb, CalculaCentro(1), 135, dFac)
        e.Graphics.DrawString("Inscrição".ToUpper, printFontB, sdb, CalculaCentro(2), 135, dFac)
        e.Graphics.DrawString("Data".ToUpper, printFontB, sdb, CalculaCentro(3), 135, dFac)
        e.Graphics.DrawString("CRMV".ToUpper, printFontB, sdb, CalculaCentro(4), 135, dFac)
        'e.Graphics.DrawString("Emitido em " & ConverteDataParaString(Date.Now) & _
        '" por " & VariaveisGlobais.gNomeUsuario & " - Pág " & pagina, printFontP, Brushes.Black, 780, wAlturaPapel - 80, dFrl)
    End Sub

    Private Sub MontaCabecalhoTeutoniaInseminacao(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        e.Graphics.DrawString("Prefeitura Municipal de Teutônia".ToUpper, printFontB, sdb, 390, 65, dFac)
        e.Graphics.DrawString("Convênio Agroserv(Corridas de inseminação)".ToUpper, printFontB, sdb, 390, 90, dFac)
        e.Graphics.DrawLine(blackPen, 40, 60, 780, 60) 'Linha Horizontal
        e.Graphics.DrawLine(blackPen, 40, 85, 780, 85) 'Linha Horizontal
        e.Graphics.DrawLine(blackPen, 40, 110, 780, 110) 'Linha Horizontal
        e.Graphics.DrawLine(blackPen, 40, 135, 780, 135) 'Linha Horizontal
        e.Graphics.DrawLine(blackPen, 40, 60, 40, 135) 'Linha Vertical
        e.Graphics.DrawLine(blackPen, 780, 60, 780, 135) 'Linha Vertical
        e.Graphics.DrawLine(blackPen, CInt(wPos(1, 1)), 110, CInt(wPos(1, 1)), 135) 'Linha Vertical
        e.Graphics.DrawLine(blackPen, CInt(wPos(2, 1)), 110, CInt(wPos(2, 1)), 135) 'Linha Vertical
        e.Graphics.DrawLine(blackPen, CInt(wPos(3, 1)), 110, CInt(wPos(3, 1)), 135) 'Linha Vertical
        e.Graphics.DrawLine(blackPen, CInt(wPos(4, 1)), 110, CInt(wPos(4, 1)), 135) 'Linha Vertical
        e.Graphics.DrawLine(blackPen, CInt(wPos(5, 1)), 110, CInt(wPos(5, 1)), 135) 'Linha Vertical

        e.Graphics.DrawString("Data".ToUpper, printFontB, sdb, CalculaCentro(0), 137, dFac)
        e.Graphics.DrawString("Produtor".ToUpper, printFontB, sdb, CalculaCentro(1), 137, dFac)
        e.Graphics.DrawString("Localidade".ToUpper, printFontB, sdb, CalculaCentro(2), 137, dFac)
        e.Graphics.DrawString("Inscrição".ToUpper, printFontB, sdb, CalculaCentro(3), 137, dFac)
        e.Graphics.DrawString("Inseminador".ToUpper, printFontB, sdb, CalculaCentro(4), 137, dFac)
        e.Graphics.DrawString("Valor".ToUpper, printFontB, sdb, CalculaCentro(5), 137, dFac)
    End Sub

    Private Sub MontaCabecalhoTeutoniaVeterinario(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        e.Graphics.DrawString("Teutônia".ToUpper, printFontB, sdb, 390, 90, dFac)
        e.Graphics.DrawLine(blackPen, 40, 85, 780, 85) 'Linha Horizontal
        e.Graphics.DrawLine(blackPen, 40, 110, 780, 110) 'Linha Horizontal
        e.Graphics.DrawLine(blackPen, 40, 135, 780, 135) 'Linha Horizontal
        e.Graphics.DrawLine(blackPen, 40, 85, 40, 135) 'Linha Vertical
        e.Graphics.DrawLine(blackPen, 780, 85, 780, 135) 'Linha Vertical
        e.Graphics.DrawLine(blackPen, CInt(wPos(1, 1)), 110, CInt(wPos(1, 1)), 135) 'Linha Vertical
        e.Graphics.DrawLine(blackPen, CInt(wPos(2, 1)), 110, CInt(wPos(2, 1)), 135) 'Linha Vertical
        e.Graphics.DrawLine(blackPen, CInt(wPos(3, 1)), 110, CInt(wPos(3, 1)), 135) 'Linha Vertical
        e.Graphics.DrawLine(blackPen, CInt(wPos(4, 1)), 110, CInt(wPos(4, 1)), 135) 'Linha Vertical
        e.Graphics.DrawLine(blackPen, CInt(wPos(5, 1)), 110, CInt(wPos(5, 1)), 135) 'Linha Vertical

        e.Graphics.DrawString("Associado".ToUpper, printFontB, sdb, CalculaCentro(0), 137, dFac)
        e.Graphics.DrawString("Localidade".ToUpper, printFontB, sdb, CalculaCentro(1), 137, dFac)
        e.Graphics.DrawString("Documento".ToUpper, printFontB, sdb, CalculaCentro(2), 137, dFac)
        e.Graphics.DrawString("Data".ToUpper, printFontB, sdb, CalculaCentro(3), 137, dFac)
        e.Graphics.DrawString("CRMV".ToUpper, printFontB, sdb, CalculaCentro(4), 137, dFac)
        e.Graphics.DrawString("Valor".ToUpper, printFontB, sdb, CalculaCentro(5), 137, dFac)
    End Sub

    Private Sub MontaCabecalhoWestfaliaVeterinario(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        e.Graphics.DrawString("Westfália".ToUpper, printFontB, sdb, 390, 110, dFac)
        e.Graphics.DrawLine(blackPen, 40, 130, 780, 130) 'Linha Horizontal

        e.Graphics.DrawString("Associado".ToUpper, printFontB, sdb, CalculaCentro(0), 137, dFac)
        e.Graphics.DrawString("Localidade".ToUpper, printFontB, sdb, CalculaCentro(1), 137, dFac)
        e.Graphics.DrawString("Documento".ToUpper, printFontB, sdb, CalculaCentro(2), 137, dFac)
        e.Graphics.DrawString("Data".ToUpper, printFontB, sdb, CalculaCentro(3), 137, dFac)
        e.Graphics.DrawString("CRMV".ToUpper, printFontB, sdb, CalculaCentro(4), 137, dFac)
        e.Graphics.DrawString("Valor".ToUpper, printFontB, sdb, CalculaCentro(5), 137, dFac)
    End Sub

    Private Sub MontaCabecalhoTestes(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.DrawString("Agroserv - cooperativa de serviços agropecuários ltda".ToUpper, printFontB, sdb, 390, 55, dFac)
        e.Graphics.DrawString(("Prefeitura municipal de " & txtPesquisa.Text).ToUpper, printFontB, sdb, 390, 72, dFac)

        e.Graphics.DrawString("Serviços Veterinários (Testes)".ToUpper, printFontB, sdb, 390, 89, dFac)

        e.Graphics.DrawString(("Data Inicial: " & txtDataInicio.Text).ToUpper, printFontB, sdb, 40, 106)
        e.Graphics.DrawString(("Data Final: " & txtDataFim.Text).ToUpper, printFontB, sdb, 230, 106)
        e.Graphics.DrawString((MonthName(CDate(txtDataInicio.Text).Month)).ToUpper, printFontB, sdb, 470, 106)

        e.Graphics.DrawLine(blackPen, 40, 130, 780, 130) 'Linha Horizontal

        e.Graphics.DrawString("Nome".ToUpper, printFontB, sdb, CalculaCentro(0), 137, dFac)
        e.Graphics.DrawString("Localidade".ToUpper, printFontB, sdb, CalculaCentro(1), 137, dFac)
        e.Graphics.DrawString("Inscrição".ToUpper, printFontB, sdb, CalculaCentro(2), 137, dFac)
        e.Graphics.DrawString("Data".ToUpper, printFontB, sdb, CalculaCentro(3), 137, dFac)
        e.Graphics.DrawString("CRMV".ToUpper, printFontB, sdb, CalculaCentro(4), 137, dFac)
        e.Graphics.DrawString("Nº Testes".ToUpper, printFontB, sdb, CalculaCentro(5), 137, dFac)
    End Sub

    Private Sub MontaCabecalhoPadrao(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.DrawString(("Agroserv-cooperativa de serviços agropecuários ltda").ToUpper, printFontB, sdb, 390, 55, dFac)
        e.Graphics.DrawString(("Prefeitura municipal de " & txtPesquisa.Text).ToUpper, printFontB, sdb, 390, 72, dFac)
        e.Graphics.DrawString((cbPesquisaTipoServico.Text).ToUpper, printFontB, sdb, 390, 89, dFac)

        e.Graphics.DrawString(("Data Inicial-").ToUpper, printFont, sdb, 40, 106)
        e.Graphics.DrawString((txtDataInicio.Text).ToUpper, printFontB, sdb, 135, 106)
        e.Graphics.DrawString(("Final-").ToUpper, printFont, sdb, 220, 106)
        e.Graphics.DrawString((txtDataFim.Text).ToUpper, printFontB, sdb, 270, 106)
        e.Graphics.DrawString((MonthName(CDate(txtDataInicio.Text).Month)).ToUpper, printFontB, sdb, 470, 106)

        e.Graphics.DrawString("Data".ToUpper, printFontB, sdb, CalculaCentro(0), 137, dFac)
        e.Graphics.DrawString("Produtor".ToUpper, printFontB, sdb, CalculaCentro(1), 137, dFac)
        e.Graphics.DrawString("Localidade".ToUpper, printFontB, sdb, CalculaCentro(2), 137, dFac)
        e.Graphics.DrawString("Inscrição".ToUpper, printFontB, sdb, CalculaCentro(3), 137, dFac)
        e.Graphics.DrawString("Inseminador".ToUpper, printFontB, sdb, CalculaCentro(4), 137, dFac)
        e.Graphics.DrawString("Valor".ToUpper, printFontB, sdb, CalculaCentro(5), 137, dFac)
        e.Graphics.DrawLine(blackPen, 40, 130, 780, 130)
    End Sub

#End Region

#End Region

    Private Sub txtMatricula_Associado_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If (txtInscricaoEstadual.Text <> objAssociados_Implem.Matricula AndAlso txtInscricaoEstadual.Text <> "") OrElse _
           (txtCodigo_Associado.Text <> objAssociados_Implem.Codigo AndAlso _
           txtInscricaoEstadual.Text <> "") Then

            Dim a As New Associados
            a.txtPesquisa.Text = txtInscricaoEstadual.Text
            a.vSelecao = "Matricula"
            a.ShowDialog()
            a.Dispose()
            If objAssociados_Implem.Codigo <> "" Then
                txtInscricaoEstadual.Text = objAssociados_Implem.Matricula
                txtCodigo_Associado.Text = objAssociados_Implem.Codigo
                txtNome_Associado.Text = objAssociados_Implem.NomeAssociado
            Else
                txtInscricaoEstadual.Text = ""
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
                objVariaveisGlobais.SetaComboBox(cbPrefeitura, objAssociados_Implem.Cidade)
            Else
                cbPrefeitura.SelectedIndex = 0
            End If
        ElseIf txtInscricaoEstadual.Text = "" AndAlso txtCodigo_Associado.Text = objAssociados_Implem.Codigo Then
            txtInscricaoEstadual.Text = ""
        ElseIf txtInscricaoEstadual.Text = "" Then
            txtInscricaoEstadual.Text = ""
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
                txtInscricaoEstadual.Text = objAssociados_Implem.InscricaoEstadual
                txtCodigo_Associado.Text = objAssociados_Implem.Codigo
                txtNome_Associado.Text = objAssociados_Implem.NomeAssociado
            Else
                txtInscricaoEstadual.Text = ""
                txtCodigo_Associado.Text = ""
                txtNome_Associado.Text = ""
            End If
        ElseIf txtNome_Associado.Text = "" Then
            txtInscricaoEstadual.Text = ""
            txtCodigo_Associado.Text = ""
            txtNome_Associado.Text = ""
        End If
    End Sub

    Private Sub txtDatas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDataInicio.LostFocus, txtDataFim.LostFocus

    End Sub

    Private Sub txtMatricula_Associado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'Dim e1 As New System.ComponentModel.CancelEventArgs
        'cbTipoAssistencia_Validating(cbTipoAssistencia, e)
    End Sub

    Private Sub btPesquisa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        FazFiltro()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtDataInicio_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDataInicio.Validating
        If txtDataInicio.Text <> "" AndAlso CDate(txtDataInicio.Text) > (txtDataFim.Text) Then
            ErrorProvider1.SetError(txtDataInicio, "Data Início maior que data fim")
        Else
            ErrorProvider1.SetError(txtDataInicio, "")
        End If
    End Sub

    Private Sub cbPrefeitura_cbTipoServico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPrefeitura.SelectedIndexChanged, cbTipoServico.SelectedIndexChanged
        Try
            Dim wControle As Integer
            If cbTipoServico.SelectedIndex > 0 And cbPrefeitura.SelectedIndex > 0 Then
                objValores_Implem.Cod_Tipo_Servico = cbTipoServico.SelectedItem.value
                objValores_Implem.Cod_Prefeitura = cbPrefeitura.SelectedItem.value
                wControle = objValores_Implem.BuscarValorAtual
                If wControle <> 0 Then
                    Throw New Exception
                End If
                txtValor.Text = objValores_Implem.Valor
            Else
                txtValor.Text = 0
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
        End Try
    End Sub

    Private Sub cbTipoServico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoServico.SelectedIndexChanged
        Try

            If cbTipoServico.Text.ToLower = "Teste de Tuberculose".ToLower Then
                txtNumeroTestes.Visible = True
                lNumeroTestes.Visible = True
            Else
                txtNumeroTestes.Visible = False
                lNumeroTestes.Visible = False
            End If

            txtNumeroTestes.Text = 1
            txtValorTotal.Text = CInt(txtNumeroTestes.Text) * CDec(txtValor.Text)

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
        End Try
    End Sub

    Private Sub cbTecnico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTecnico.SelectedIndexChanged
        Try

            Dim wControle As Integer
            If cbTecnico.SelectedIndex > 0 Then
                objTecnicos_Implem.Codigo = cbTecnico.SelectedItem.value
                wControle = objTecnicos_Implem.BuscarTecnico
                txtCRMV.Text = objTecnicos_Implem.CRMV
            Else
                txtCRMV.Text = ""
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
        End Try
    End Sub

    Private Sub txtValor_txtNumeroTestes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroTestes.TextChanged, txtValor.TextChanged
        txtValorTotal.Text = CInt(txtNumeroTestes.Text) * CDec(txtValor.Text)
    End Sub

    Private Function CalculaCentro(ByVal p1 As Integer) As Integer
        Try
            Dim pos As String = wPos(p1, 1) + ((wPos(p1 + 1, 1) - wPos(p1, 1)) / 2)
            Return pos
        Catch ex As Exception
            Return " "
        End Try
    End Function

    Private Sub cbPesquisaTipoServico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPesquisaTipoServico.SelectedIndexChanged
        FazFiltro()
    End Sub
End Class
