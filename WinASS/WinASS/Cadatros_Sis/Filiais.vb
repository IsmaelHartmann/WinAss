Public Class Filiais
    Inherits System.Windows.Forms.Form
    Private vIncluir As Boolean
    Private vAlterar As Boolean
    Private vExcluir As Boolean
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbFiliaisEmpresa As FzComboBox.FzCombobox
    Friend WithEvents txtTelefone As FzFlexBox.MaskedTextBox
    Friend WithEvents txtFax As FzFlexBox.MaskedTextBox
    Friend WithEvents txtCEP As FzFlexBox.MaskedTextBox
    Friend WithEvents txtCNPJ As FzFlexBox.MaskedTextBox
    Friend WithEvents cbFiliaisEstado As FzComboBox.FzCombobox
    Friend WithEvents cbFiliaisCidade As FzComboBox.FzCombobox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtInscrEst As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeFilial As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoFilial As FzNumericBox.FzNumericBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lbCNPJ As System.Windows.Forms.Label
    Friend WithEvents lbNomeFilial As System.Windows.Forms.Label
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
    Friend WithEvents dtgFiliais As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents btVisualizar As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btNovo As System.Windows.Forms.Button
    Friend WithEvents Cm As System.Windows.Forms.DataGridViewImageColumn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filiais))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gpDados = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbFiliaisEmpresa = New FzComboBox.FzCombobox
        Me.txtTelefone = New FzFlexBox.MaskedTextBox
        Me.txtFax = New FzFlexBox.MaskedTextBox
        Me.txtCEP = New FzFlexBox.MaskedTextBox
        Me.txtCNPJ = New FzFlexBox.MaskedTextBox
        Me.cbFiliaisEstado = New FzComboBox.FzCombobox
        Me.cbFiliaisCidade = New FzComboBox.FzCombobox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtInscrEst = New System.Windows.Forms.TextBox
        Me.txtNomeFilial = New System.Windows.Forms.TextBox
        Me.txtEndereco = New System.Windows.Forms.TextBox
        Me.txtComplemento = New System.Windows.Forms.TextBox
        Me.txtBairro = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtCodigoFilial = New FzNumericBox.FzNumericBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lbCNPJ = New System.Windows.Forms.Label
        Me.lbNomeFilial = New System.Windows.Forms.Label
        Me.btConfirmaSelecao = New System.Windows.Forms.Button
        Me.txtDataCadastro = New System.Windows.Forms.MaskedTextBox
        Me.btCancelaSelecao = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbUsuarioCadastro = New FzComboBox.FzCombobox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtPesquisa = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbCampo = New FzComboBox.FzCombobox
        Me.gbPesquisa = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbConter = New System.Windows.Forms.RadioButton
        Me.rbComecarPor = New System.Windows.Forms.RadioButton
        Me.rbExato = New System.Windows.Forms.RadioButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tpConsulta = New System.Windows.Forms.TabPage
        Me.dtgFiliais = New System.Windows.Forms.DataGridView
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
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpConsulta.SuspendLayout()
        CType(Me.dtgFiliais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpManutencao.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpDados
        '
        Me.gpDados.Controls.Add(Me.Label7)
        Me.gpDados.Controls.Add(Me.cbFiliaisEmpresa)
        Me.gpDados.Controls.Add(Me.txtTelefone)
        Me.gpDados.Controls.Add(Me.txtFax)
        Me.gpDados.Controls.Add(Me.txtCEP)
        Me.gpDados.Controls.Add(Me.txtCNPJ)
        Me.gpDados.Controls.Add(Me.cbFiliaisEstado)
        Me.gpDados.Controls.Add(Me.cbFiliaisCidade)
        Me.gpDados.Controls.Add(Me.Label12)
        Me.gpDados.Controls.Add(Me.txtInscrEst)
        Me.gpDados.Controls.Add(Me.txtNomeFilial)
        Me.gpDados.Controls.Add(Me.txtEndereco)
        Me.gpDados.Controls.Add(Me.txtComplemento)
        Me.gpDados.Controls.Add(Me.txtBairro)
        Me.gpDados.Controls.Add(Me.Label8)
        Me.gpDados.Controls.Add(Me.Label14)
        Me.gpDados.Controls.Add(Me.Label15)
        Me.gpDados.Controls.Add(Me.Label16)
        Me.gpDados.Controls.Add(Me.Label17)
        Me.gpDados.Controls.Add(Me.txtCodigoFilial)
        Me.gpDados.Controls.Add(Me.Label18)
        Me.gpDados.Controls.Add(Me.Label19)
        Me.gpDados.Controls.Add(Me.lbCNPJ)
        Me.gpDados.Controls.Add(Me.lbNomeFilial)
        Me.gpDados.Controls.Add(Me.btConfirmaSelecao)
        Me.gpDados.Controls.Add(Me.txtDataCadastro)
        Me.gpDados.Controls.Add(Me.btCancelaSelecao)
        Me.gpDados.Controls.Add(Me.Label1)
        Me.gpDados.Controls.Add(Me.cbUsuarioCadastro)
        Me.gpDados.Controls.Add(Me.Label5)
        Me.gpDados.Location = New System.Drawing.Point(95, 66)
        Me.gpDados.Name = "gpDados"
        Me.gpDados.Size = New System.Drawing.Size(568, 282)
        Me.gpDados.TabIndex = 0
        Me.gpDados.TabStop = False
        Me.gpDados.Text = "Informações da Filial"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(177, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "CNPJ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbFiliaisEmpresa
        '
        Me.cbFiliaisEmpresa.Location = New System.Drawing.Point(113, 35)
        Me.cbFiliaisEmpresa.Name = "cbFiliaisEmpresa"
        Me.cbFiliaisEmpresa.Size = New System.Drawing.Size(384, 22)
        Me.cbFiliaisEmpresa.TabIndex = 1
        '
        'txtTelefone
        '
        Me.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefone.Flags = 0
        Me.txtTelefone.Location = New System.Drawing.Point(113, 179)
        Me.txtTelefone.Mask = "(##) ####-####"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(96, 20)
        Me.txtTelefone.TabIndex = 22
        '
        'txtFax
        '
        Me.txtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFax.Flags = 0
        Me.txtFax.Location = New System.Drawing.Point(215, 179)
        Me.txtFax.Mask = "(##) ####-####"
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(96, 20)
        Me.txtFax.TabIndex = 23
        '
        'txtCEP
        '
        Me.txtCEP.Flags = 0
        Me.txtCEP.Location = New System.Drawing.Point(417, 155)
        Me.txtCEP.Mask = "#####-###"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(80, 20)
        Me.txtCEP.TabIndex = 20
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Flags = 0
        Me.txtCNPJ.Location = New System.Drawing.Point(225, 59)
        Me.txtCNPJ.Mask = "##.###.###/####-##"
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(128, 20)
        Me.txtCNPJ.TabIndex = 5
        '
        'cbFiliaisEstado
        '
        Me.cbFiliaisEstado.Location = New System.Drawing.Point(113, 155)
        Me.cbFiliaisEstado.Name = "cbFiliaisEstado"
        Me.cbFiliaisEstado.Size = New System.Drawing.Size(48, 22)
        Me.cbFiliaisEstado.TabIndex = 17
        '
        'cbFiliaisCidade
        '
        Me.cbFiliaisCidade.Location = New System.Drawing.Point(169, 155)
        Me.cbFiliaisCidade.Name = "cbFiliaisCidade"
        Me.cbFiliaisCidade.Size = New System.Drawing.Size(184, 22)
        Me.cbFiliaisCidade.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(18, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 20)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Estado / Cidade"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInscrEst
        '
        Me.txtInscrEst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInscrEst.Location = New System.Drawing.Point(393, 59)
        Me.txtInscrEst.Name = "txtInscrEst"
        Me.txtInscrEst.Size = New System.Drawing.Size(104, 20)
        Me.txtInscrEst.TabIndex = 7
        '
        'txtNomeFilial
        '
        Me.txtNomeFilial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeFilial.Location = New System.Drawing.Point(113, 83)
        Me.txtNomeFilial.Name = "txtNomeFilial"
        Me.txtNomeFilial.Size = New System.Drawing.Size(240, 20)
        Me.txtNomeFilial.TabIndex = 9
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(113, 107)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(384, 20)
        Me.txtEndereco.TabIndex = 11
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(113, 131)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(184, 20)
        Me.txtComplemento.TabIndex = 13
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(361, 131)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(136, 20)
        Me.txtBairro.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(18, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Telefone/Fax"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(361, 155)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 20)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "CEP"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(305, 131)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 20)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Bairro"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(18, 131)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 20)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Complemento"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(18, 107)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 20)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Endereço"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigoFilial
        '
        Me.txtCodigoFilial.AllowNegative = True
        Me.txtCodigoFilial.Location = New System.Drawing.Point(113, 59)
        Me.txtCodigoFilial.Name = "txtCodigoFilial"
        Me.txtCodigoFilial.NumericPrecision = 2
        Me.txtCodigoFilial.NumericScaleOnFocus = 0
        Me.txtCodigoFilial.NumericScaleOnLostFocus = 0
        Me.txtCodigoFilial.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodigoFilial.Size = New System.Drawing.Size(56, 20)
        Me.txtCodigoFilial.TabIndex = 3
        Me.txtCodigoFilial.Text = "0"
        Me.txtCodigoFilial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCodigoFilial.ZeroIsValid = True
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(18, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 20)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Empresa"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(18, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 20)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Código Filial"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCNPJ
        '
        Me.lbCNPJ.BackColor = System.Drawing.Color.Transparent
        Me.lbCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCNPJ.ForeColor = System.Drawing.Color.Black
        Me.lbCNPJ.Location = New System.Drawing.Point(361, 59)
        Me.lbCNPJ.Name = "lbCNPJ"
        Me.lbCNPJ.Size = New System.Drawing.Size(24, 20)
        Me.lbCNPJ.TabIndex = 6
        Me.lbCNPJ.Text = "IE"
        Me.lbCNPJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbNomeFilial
        '
        Me.lbNomeFilial.BackColor = System.Drawing.Color.Transparent
        Me.lbNomeFilial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbNomeFilial.ForeColor = System.Drawing.Color.Black
        Me.lbNomeFilial.Location = New System.Drawing.Point(18, 83)
        Me.lbNomeFilial.Name = "lbNomeFilial"
        Me.lbNomeFilial.Size = New System.Drawing.Size(89, 20)
        Me.lbNomeFilial.TabIndex = 8
        Me.lbNomeFilial.Text = "Nome Filial"
        Me.lbNomeFilial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btConfirmaSelecao
        '
        Me.btConfirmaSelecao.BackColor = System.Drawing.SystemColors.Control
        Me.btConfirmaSelecao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btConfirmaSelecao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConfirmaSelecao.Image = CType(resources.GetObject("btConfirmaSelecao.Image"), System.Drawing.Image)
        Me.btConfirmaSelecao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btConfirmaSelecao.Location = New System.Drawing.Point(408, 252)
        Me.btConfirmaSelecao.Name = "btConfirmaSelecao"
        Me.btConfirmaSelecao.Size = New System.Drawing.Size(74, 22)
        Me.btConfirmaSelecao.TabIndex = 28
        Me.btConfirmaSelecao.Text = "Confirma"
        Me.btConfirmaSelecao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btConfirmaSelecao.UseVisualStyleBackColor = False
        Me.btConfirmaSelecao.Visible = False
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.Enabled = False
        Me.txtDataCadastro.Location = New System.Drawing.Point(125, 230)
        Me.txtDataCadastro.Mask = "00/00/0000 90:00"
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.txtDataCadastro.Size = New System.Drawing.Size(98, 20)
        Me.txtDataCadastro.TabIndex = 25
        Me.txtDataCadastro.ValidatingType = GetType(Date)
        '
        'btCancelaSelecao
        '
        Me.btCancelaSelecao.BackColor = System.Drawing.SystemColors.Control
        Me.btCancelaSelecao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelaSelecao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelaSelecao.Image = CType(resources.GetObject("btCancelaSelecao.Image"), System.Drawing.Image)
        Me.btCancelaSelecao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCancelaSelecao.Location = New System.Drawing.Point(488, 252)
        Me.btCancelaSelecao.Name = "btCancelaSelecao"
        Me.btCancelaSelecao.Size = New System.Drawing.Size(74, 22)
        Me.btCancelaSelecao.TabIndex = 29
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
        Me.Label1.Location = New System.Drawing.Point(18, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Data Cadastro"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbUsuarioCadastro
        '
        Me.cbUsuarioCadastro.Enabled = False
        Me.cbUsuarioCadastro.Location = New System.Drawing.Point(125, 254)
        Me.cbUsuarioCadastro.Name = "cbUsuarioCadastro"
        Me.cbUsuarioCadastro.Size = New System.Drawing.Size(98, 22)
        Me.cbUsuarioCadastro.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(18, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Usuário Cadastro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesquisa.Location = New System.Drawing.Point(92, 44)
        Me.txtPesquisa.MaxLength = 50
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(183, 20)
        Me.txtPesquisa.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.NavajoWhite
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
        Me.Label4.BackColor = System.Drawing.Color.NavajoWhite
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
        Me.cbCampo.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cbCampo.Location = New System.Drawing.Point(92, 13)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(183, 22)
        Me.cbCampo.TabIndex = 1
        '
        'gbPesquisa
        '
        Me.gbPesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
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
        Me.tpConsulta.Controls.Add(Me.dtgFiliais)
        Me.tpConsulta.Controls.Add(Me.gbPesquisa)
        Me.tpConsulta.Location = New System.Drawing.Point(4, 23)
        Me.tpConsulta.Name = "tpConsulta"
        Me.tpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConsulta.Size = New System.Drawing.Size(757, 445)
        Me.tpConsulta.TabIndex = 0
        Me.tpConsulta.Text = "Consulta"
        Me.tpConsulta.UseVisualStyleBackColor = True
        '
        'dtgFiliais
        '
        Me.dtgFiliais.AllowUserToAddRows = False
        Me.dtgFiliais.AllowUserToDeleteRows = False
        Me.dtgFiliais.AllowUserToOrderColumns = True
        Me.dtgFiliais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgFiliais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtgFiliais.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgFiliais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgFiliais.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cm})
        Me.dtgFiliais.Location = New System.Drawing.Point(7, 87)
        Me.dtgFiliais.Name = "dtgFiliais"
        Me.dtgFiliais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgFiliais.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgFiliais.Size = New System.Drawing.Size(744, 335)
        Me.dtgFiliais.TabIndex = 1
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
        Me.btNovo.TabIndex = 1
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
        Me.btImprimir.TabIndex = 8
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
        Me.btVisualizar.TabIndex = 7
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
        Me.btAdicionar.TabIndex = 2
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
        Me.btAlterar.TabIndex = 3
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
        Me.btLimpar.TabIndex = 5
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
        Me.btFechar.TabIndex = 6
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
        Me.btExcluir.TabIndex = 4
        Me.btExcluir.Text = "Excluir (F4)"
        Me.btExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btExcluir.UseVisualStyleBackColor = False
        '
        'Filiais
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
        Me.Name = "Filiais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Filiais"
        Me.gpDados.ResumeLayout(False)
        Me.gpDados.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPesquisa.ResumeLayout(False)
        Me.gbPesquisa.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpConsulta.ResumeLayout(False)
        CType(Me.dtgFiliais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpManutencao.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public objFiliais_Implem As Filiais_Implem = FiliaisBOFactory.GetFactory().GetInstance()

#Region " Inicializações "

    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtPesquisa.Focus()
    End Sub

    Private Sub Filiais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim autoriza As Boolean
        autoriza = VerificaPrograma("Filiais", VariaveisGlobais.gSetorUsuario, _
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

            objVariaveisGlobais.PreencheComboBox(cbFiliaisEmpresa, VariaveisGlobais.gConexao, _
              "SELECT Codigo," & _
              "CAST(Codigo AS VARCHAR(3))+' '+CAST(Nome AS VARCHAR)AS Empresas " & _
              "FROM C_Empresas WHERE isnull(Data_Hora_Exclusao,'') = '' ORDER BY Codigo, Nome ", "")
            cbFiliaisEmpresa.SelectedIndex = 0

            objVariaveisGlobais.PreencheComboBox(cbFiliaisEstado, VariaveisGlobais.gConexao, _
                "SELECT SiglaEstado FROM C_Estados ORDER BY SiglaEstado", "")
            cbFiliaisEstado.SelectedIndex = 0

            LimpaTela()

            If vSelecao <> "" Then
                btCancelaSelecao.Visible = True
                btConfirmaSelecao.Visible = True
                objVariaveisGlobais.SetaComboBox(cbCampo, vSelecao)
                If dtgFiliais.Rows.Count = 1 Then
                    dtgFiliais.Rows(0).Selected = True
                    Me.Close()
                End If
            Else
                btCancelaSelecao.Visible = False
                btConfirmaSelecao.Visible = False
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub CadastroFiliais_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        objFiliais_Implem = Nothing
        LimpaErros()
    End Sub

    Private Sub Filiais_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F1 Then
            objLeituras.VerC_LOG(VariaveisGlobais.gBD, "C_LOG", "C_Filiais", txtCodigoFilial.Text)
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
        If e.KeyCode = Keys.Enter And dtgFiliais.Focused Then
            TelaAlteracaoFiliais()
            If btConfirmaSelecao.Visible = True Then
                Me.Dispose()
            Else
            End If
        End If
        If e.KeyCode = Keys.Down And txtPesquisa.Focused Then
            dtgFiliais.Focus()
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

#Region " Adicionar/Alterar /Excluir Filial "

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        LimpaTela(True)
    End Sub

    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click
        AdicionarFiliais()
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

    Public Function GuardaDadosFiliais() As Integer

        Try

            objFiliais_Implem.CodigoEmpresa = cbFiliaisEmpresa.SelectedItem.Value
            objFiliais_Implem.CodigoFilial = Replace(txtCodigoFilial.Text, "'", "''")
            objFiliais_Implem.CNPJ = txtCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "")
            objFiliais_Implem.InscricaoEstadual = Replace(txtInscrEst.Text, "'", "''")
            objFiliais_Implem.NomeFilial = Replace(txtNomeFilial.Text, "'", "''")
            objFiliais_Implem.Endereco = Replace(txtEndereco.Text, "'", "''")
            objFiliais_Implem.Complemento = Replace(txtComplemento.Text, "'", "''")
            objFiliais_Implem.Bairro = Replace(txtBairro.Text, "'", "''")
            objFiliais_Implem.CodigoCidade = cbFiliaisCidade.SelectedItem.Value
            objFiliais_Implem.SiglaEstado = cbFiliaisEstado.SelectedItem.Value
            objFiliais_Implem.CEP() = txtCEP.Text.Replace("'", "''").Replace("-", "").Replace(".", "")
            objFiliais_Implem.Telefone() = Replace(txtTelefone.Text, "'", "''")
            objFiliais_Implem.Fax() = Replace(txtFax.Text, "'", "''")

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Return -1
        End Try
        Return 0

    End Function

    Public Sub TelaAlteracaoFiliais()
        Try
            Dim wControle As Integer

            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Me.Close()
            End If

            objVariaveisGlobais.SetaComboBox(cbFiliaisEmpresa, objFiliais_Implem.CodigoEmpresa)
            txtCodigoFilial.Text = objFiliais_Implem.CodigoFilial
            txtCNPJ.Text = objFiliais_Implem.CNPJ
            txtInscrEst.Text = objFiliais_Implem.InscricaoEstadual
            txtNomeFilial.Text = objFiliais_Implem.NomeFilial
            txtEndereco.Text = objFiliais_Implem.Endereco
            txtComplemento.Text = objFiliais_Implem.Complemento
            txtBairro.Text = objFiliais_Implem.Bairro

            'Dim SiglaEstado As String = ""
            'wControle = objLeituras.BuscaSiglaEstadoNomedaCidadeGPS(objFiliais_Implem.CodigoCidade, VariaveisGlobais.gConexao, SiglaEstado, "")
            'If wControle < 0 Then
            '    objVariaveisGlobais.MostraErro()
            '    Exit Sub
            'End If
            objVariaveisGlobais.SetaComboBox(cbFiliaisEstado, objFiliais_Implem.SiglaEstado)
            objVariaveisGlobais.SetaComboBox(cbFiliaisCidade, objFiliais_Implem.CodigoCidade)

            txtCEP.Text = objFiliais_Implem.CEP
            txtTelefone.Text = objFiliais_Implem.Telefone
            txtFax.Text = objFiliais_Implem.Fax

            btExcluir.Enabled = vExcluir
            btAlterar.Enabled = vAlterar
            btAdicionar.Enabled = False
            btNovo.Enabled = False
            btLimpar.Enabled = True
            TabControl1.SelectedIndex = 1
            tpManutencao.Enabled = True

            Windows.Forms.Cursor.Current = Cursors.Default

            txtNomeFilial.Focus() : txtNomeFilial.SelectionLength = 0

        Catch ex As Exception

            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Me.Close()

        End Try

    End Sub

    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFiliaisEstado.SelectedIndexChanged
        objVariaveisGlobais.PreencheComboBox(cbFiliaisCidade, VariaveisGlobais.gConexao, _
            "SELECT CodigoCidade, NomeCidade FROM C_Cidades C " & _
            " WHERE (SELECT U.SiglaEstado FROM C_Estados U WHERE U.SiglaEstado = C.SiglaEstado) ='" & cbFiliaisEstado.SelectedItem.value & _
            "' ORDER BY NomeCidade", "")
        If cbFiliaisCidade.Items.Count > 0 Then
            cbFiliaisCidade.SelectedIndex = 0
        End If
    End Sub

    Public Sub AdicionarFiliais()
        Try

            Dim wControle As Integer
            wControle = ValidaDados()
            If wControle <> 0 Then Exit Sub

            GuardaDadosFiliais()
            wControle = objFiliais_Implem.IncluirFilial()
            If wControle = 1 Then
                MessageBox.Show("Já existe uma Filial cadastrada com este Codigo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Filial incluída com sucesso! Numero: " & _
                        objFiliais_Implem.CodigoFilial, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

            wControle = GuardaDadosFiliais()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If

            wControle = objFiliais_Implem.AlterarFilial()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Dados da Filial modificados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

        wMensagem = MessageBox.Show("TODOS Dados relacionados a essa Filial serão permanentemente excluídos!" & vbCrLf & " Você deseja excluir esta Filial? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If (wMensagem = Windows.Forms.DialogResult.Yes) Then
            objFiliais_Implem.CodigoFilial = txtCodigoFilial.Text
            wControle = objFiliais_Implem.ExcluirFilial()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Filial excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LimpaTela()

    End Sub

#End Region

#Region " Atualização do DataGrid e do Form "

    Private Sub AtualizaFiliais()

        Dim wControle As Integer

        Dim wSQL As String = _
            " SELECT CodigoEmpresa, CodigoFilial, CNPJ, " & _
            " NomeFilial, Endereco " & _
            " FROM C_Filiais " & _
            " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
            " ORDER BY CodigoEmpresa, CodigoFilial, NomeFilial "

        wControle = objFiliais_Implem.MostraTabelaFiliais(dtgFiliais, wSQL)
        If wControle <> 0 Then objVariaveisGlobais.MostraErro()
        PreencheCampoPesquisa()
        FazFiltro()

    End Sub

    Private Sub PreencheCampoPesquisa()
        If cbCampo.Items.Count = 0 Then
            Dim c As New System.Web.UI.WebControls.ListItem
            For i As Integer = 0 To dtgFiliais.Columns.Count - 1
                If dtgFiliais.Columns(i).ValueType.ToString = GetType(String).ToString AndAlso dtgFiliais.Columns(i).Visible = True Then
                    c = New System.Web.UI.WebControls.ListItem
                    c.Value = dtgFiliais.Columns(i).HeaderText
                    c.Text = dtgFiliais.Columns(i).HeaderText
                    cbCampo.Items.Add(c)
                End If
            Next
            cbCampo.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtPesquisaNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.TextChanged
        FazFiltro()
    End Sub

    Private Sub cbFiliaisPesquisaEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCampo.SelectedIndexChanged
        FazFiltro()
    End Sub

    Private Sub SELECAO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles rbExato.CheckedChanged, rbComecarPor.CheckedChanged, rbConter.CheckedChanged
        FazFiltro()
    End Sub

    Function FazFiltro()
        If Not IsNothing(dtgFiliais.DataSource) Then
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
            For i As Integer = 0 To dtgFiliais.Columns.Count - 1
                If dtgFiliais.Columns(i).Name = cbCampo.Text Then
                    wValida = True
                    Exit For
                End If
            Next

            If wValida = False Then
                MsgBox("Campo pesquisa está incorreto")
                Return wValida
            End If

            wDataTable = objFiliais_Implem.wDataSet.Tables(0)
            Dim wDataView = New DataView(wDataTable, _
                     wPesquisa, _
                     "", DataViewRowState.CurrentRows)
            dtgFiliais.DataSource = wDataView
        End If
        Return True
    End Function

    Private Sub dtgFiliais_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgFiliais.MouseMove
        Try
            Dim hti As System.Windows.Forms.DataGridView.HitTestInfo
            hti = dtgFiliais.HitTest(e.X, e.Y)

            If hti.Type = System.Windows.Forms.DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 5 Then
                    Me.Cursor = System.Windows.Forms.Cursors.Hand
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand
                Else
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                End If
                If hti.ColumnIndex = 5 Then
                    ToolTip1.SetToolTip(dtgFiliais, "")
                End If
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                ToolTip1.SetToolTip(dtgFiliais, "")
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgFiliais_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgFiliais.MouseUp
        Try
            Dim hti As DataGridView.HitTestInfo = dtgFiliais.HitTest(e.X, e.Y)

            If hti.Type = DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 5 Then
                    TelaAlteracaoFiliais()
                End If
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgFiliais_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgFiliais.CurrentCellChanged
        Try
            Dim wControle As Integer
            If IsNothing(dtgFiliais.DataSource) Or IsNothing(dtgFiliais.CurrentCell) Then Exit Sub

            objFiliais_Implem.CodigoEmpresa = dtgFiliais.Item(0, dtgFiliais.CurrentCell().RowIndex).Value
            objFiliais_Implem.CodigoFilial = dtgFiliais.Item(1, dtgFiliais.CurrentCell().RowIndex).Value
            wControle = objFiliais_Implem.BuscarFilial
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            dtgFiliais.Rows(dtgFiliais.CurrentCell().RowIndex).Selected = True
            dtgFiliais.Focus()
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


        txtCodigoFilial.Text = 0
        txtCNPJ.Text = ""
        txtInscrEst.Text = ""
        txtNomeFilial.Text = ""
        txtEndereco.Text = ""
        txtComplemento.Text = ""
        txtBairro.Text = ""
        txtCEP.Text = ""
        txtTelefone.Text = ""
        txtFax.Text = ""
        cbFiliaisCidade.SelectedIndex = 0
        cbFiliaisEstado.SelectedItem = 0

        txtDataCadastro.Text = ConverteDataHoraParaString(Date.Now)
        objVariaveisGlobais.SetaComboBox(cbUsuarioCadastro, VariaveisGlobais.gCodigoUsuario)

        btAlterar.Enabled = False
        btExcluir.Enabled = False
        txtCodigoFilial.Enabled = False

        If wNovoRegistro = False Then
            AtualizaFiliais()
            btNovo.Enabled = True
            btAdicionar.Enabled = False
            btLimpar.Enabled = False
            TabControl1.SelectedIndex = 0
            tpManutencao.Enabled = False

            txtPesquisa.Focus()
        Else
            AtualizaFiliais()
            btAdicionar.Enabled = vIncluir
            btLimpar.Enabled = True
            btNovo.Enabled = False
            TabControl1.SelectedIndex = 1
            tpManutencao.Enabled = True
        End If

        LimpaErros()

    End Sub

    Private Sub btLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLimpar.Click
        LimpaTela()
    End Sub

#End Region

#Region " Valida da tela "

    Private Function ValidaDados() As Integer
        LimpaErros()

        Dim wErros As String = ""
        Dim wFoco As Integer = -1

        cbFiliaisEmpresa.Focus()
        txtCNPJ.Focus()
        txtInscrEst.Focus()
        txtNomeFilial.Focus()
        cbFiliaisCidade.Focus()
        txtBairro.Focus()
        txtEndereco.Focus()
        txtCodigoFilial.Focus()
        txtCEP.Focus()
        txtTelefone.Focus()
        cbFiliaisCidade.Focus()
        cbFiliaisEstado.Focus()
        btLimpar.Focus()

        For f As Integer = 0 To 39
            If VariaveisGlobais.gErroTela(f) <> "" Then
                If wFoco = -1 Then wFoco = f
                wErros = wErros & VariaveisGlobais.gErroTela(f) & vbCrLf
            End If
        Next f

        If wErros <> "" Then

            For f As Integer = 0 To gpDados.Controls.Count - 1
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

        ErrorProvider1.SetError(cbFiliaisEmpresa, "")
        ErrorProvider1.SetError(txtCodigoFilial, "")
        ErrorProvider1.SetError(txtCNPJ, "")
        ErrorProvider1.SetError(txtInscrEst, "")
        ErrorProvider1.SetError(txtNomeFilial, "")
        ErrorProvider1.SetError(txtEndereco, "")
        ErrorProvider1.SetError(txtComplemento, "")
        ErrorProvider1.SetError(txtBairro, "")
        ErrorProvider1.SetError(cbFiliaisCidade, "")
        ErrorProvider1.SetError(cbFiliaisEstado, "")
        ErrorProvider1.SetError(txtCEP, "")
        ErrorProvider1.SetError(txtTelefone, "")
        ErrorProvider1.SetError(txtFax, "")

        objVariaveisGlobais.InicializaVetorErros()

    End Sub

    Private Sub cbFiliaisEmpresa_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbFiliaisEmpresa.Validating

        Dim wMsgErro As String = ""
        If cbFiliaisEmpresa.SelectedIndex < 1 Then
            wMsgErro = "Selecione uma Empresa ! "
        End If
        If wMsgErro <> "" Then
            ErrorProvider1.SetError(cbFiliaisEmpresa, wMsgErro)
            VariaveisGlobais.gErroTela(0) = wMsgErro
        Else
            ErrorProvider1.SetError(cbFiliaisEmpresa, "")
            VariaveisGlobais.gErroTela(0) = ""
        End If
    End Sub
    Private Sub txtCodigoFilial_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigoFilial.Validating


        Dim wMsgErro As String = "Digite o código da Filial!"
        If txtCodigoFilial.Text = 0 Or Not IsNumeric(txtCodigoFilial.Text) Then
            ErrorProvider1.SetError(txtCodigoFilial, wMsgErro)
            VariaveisGlobais.gErroTela(1) = wMsgErro
        Else
            ErrorProvider1.SetError(txtCodigoFilial, "")
            VariaveisGlobais.gErroTela(1) = ""
        End If
    End Sub

    Private Sub txtCNPJ_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCNPJ.Validating

        Try
            Dim wCNPJNumeros As String = txtCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim()
            Dim wMsgErro As String = "O CNPJ não está completo!"

            If wCNPJNumeros = "" Then
                wMsgErro = "O CNPJ não é válido!"
                ErrorProvider1.SetError(txtCNPJ, wMsgErro)
                VariaveisGlobais.gErroTela(3) = wMsgErro
                Exit Sub
            End If

            If wCNPJNumeros.Length <> 14 And wCNPJNumeros <> "" Then
                ErrorProvider1.SetError(txtCNPJ, wMsgErro)
                VariaveisGlobais.gErroTela(3) = wMsgErro
            Else
                If wCNPJNumeros <> "" Then
                    If ValidaCNPJ(wCNPJNumeros) = False Then
                        wMsgErro = "O CNPJ não é válido!"
                        ErrorProvider1.SetError(txtCNPJ, wMsgErro)
                        VariaveisGlobais.gErroTela(3) = wMsgErro
                        Exit Sub
                    End If
                End If
                ErrorProvider1.SetError(txtCNPJ, "")
                VariaveisGlobais.gErroTela(3) = ""
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub txtCodigoCidade_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbFiliaisCidade.Validating

        Dim wMsgErro As String = "Digite o código da Cidade!"

        If cbFiliaisCidade.SelectedIndex = 0 Then
            ErrorProvider1.SetError(cbFiliaisCidade, wMsgErro)
            VariaveisGlobais.gErroTela(4) = wMsgErro
        Else
            ErrorProvider1.SetError(cbFiliaisCidade, "")
            VariaveisGlobais.gErroTela(4) = ""
        End If
    End Sub

    Private Sub txtEndereco_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEndereco.Validating

        Dim wMsgErro As String = "Digite o endereço da Filial!"

        If txtEndereco.Text = "" Then
            ErrorProvider1.SetError(txtEndereco, wMsgErro)
            VariaveisGlobais.gErroTela(5) = wMsgErro
        Else
            ErrorProvider1.SetError(txtEndereco, "")
            VariaveisGlobais.gErroTela(5) = ""
        End If
    End Sub

    Private Sub txtInscrEstadual_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtInscrEst.Validating
        Dim wMsgErro As String = "Digite corretamente a Inscrição Estadual!"
        Dim wControle As Integer

        If txtInscrEst.Text <> "" Then
            wControle = GenProc.ValidaIE(txtInscrEst.Text, cbFiliaisEstado.SelectedItem.value)
            If wControle = 1 Then
                ErrorProvider1.SetError(txtInscrEst, wMsgErro)
                VariaveisGlobais.gErroTela(6) = wMsgErro
            ElseIf wControle = -1 Then
                ErrorProvider1.SetError(txtInscrEst, wMsgErro)
                VariaveisGlobais.gErroTela(6) = wMsgErro
            ElseIf wControle = 0 Then
                ErrorProvider1.SetError(txtInscrEst, "")
                VariaveisGlobais.gErroTela(6) = ""
            End If
        Else
            ErrorProvider1.SetError(txtInscrEst, wMsgErro)
            VariaveisGlobais.gErroTela(6) = wMsgErro
        End If
    End Sub

    Private Sub txtCEP_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCEP.Validating
        Dim wMsgErro As String = "Digite corretamente o CEP!"
        If txtCEP.Text.Replace(" ", "").Replace("-", "").Replace(".", "").Length <> 8 Then
            ErrorProvider1.SetError(txtCEP, wMsgErro)
            VariaveisGlobais.gErroTela(7) = wMsgErro
        Else
            ErrorProvider1.SetError(txtCEP, "")
            VariaveisGlobais.gErroTela(7) = ""
        End If
    End Sub

    Private Sub cbEstado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbFiliaisEstado.Validating
        Dim wMsgErro As String = ""

        If cbFiliaisEstado.SelectedIndex = 0 Then
            wMsgErro = "Informe o Estado !"
        ElseIf cbFiliaisEstado.SelectedIndex < 0 Then
            wMsgErro = "Informe o Estado !"
        End If

        If wMsgErro <> "" Then
            ErrorProvider1.SetError(cbFiliaisEstado, wMsgErro)
            VariaveisGlobais.gErroTela(8) = wMsgErro
        Else
            ErrorProvider1.SetError(cbFiliaisEstado, "")
            VariaveisGlobais.gErroTela(8) = ""
        End If
    End Sub

    Private Sub cbCidade_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbFiliaisCidade.Validating
        Dim wMsgErro As String = ""

        If cbFiliaisCidade.SelectedIndex = 0 Then
            wMsgErro = "Informe a Cidade !"
        ElseIf cbFiliaisCidade.SelectedIndex < 0 Then
            wMsgErro = "Informe a Cidade !"
        End If

        If wMsgErro <> "" Then
            ErrorProvider1.SetError(cbFiliaisCidade, wMsgErro)
            VariaveisGlobais.gErroTela(9) = wMsgErro
        Else
            ErrorProvider1.SetError(cbFiliaisCidade, "")
            VariaveisGlobais.gErroTela(9) = ""
        End If
    End Sub



#End Region

#Region " Impressao "

#Region " Variaveis de Impressao "

    Dim wAlturaPapel As Integer
    Dim sdb As System.Drawing.Brush

    Dim CodigoEmpresa As String
    Dim CodigoFilial As String
    Dim CNPJFilial As String
    Dim NomeFilial As String
    Dim EnderecoFilial As String

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
        TotalRecords = dtgFiliais.RowCount

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

            CodigoEmpresa = dtgFiliais.Item(0, i).Value
            CodigoFilial = dtgFiliais.Item(1, i).Value
            CNPJFilial = dtgFiliais.Item(2, i).Value
            NomeFilial = dtgFiliais.Item(3, i).Value
            EnderecoFilial = dtgFiliais.Item(4, i).Value

            e.Graphics.DrawString(CodigoEmpresa, printFont, sdb, 20, yPos)
            e.Graphics.DrawString(CodigoFilial, printFont, sdb, 120, yPos)
            e.Graphics.DrawString(CNPJFilial, printFont, sdb, 200, yPos)
            e.Graphics.DrawString(NomeFilial, printFont, sdb, 400, yPos)
            e.Graphics.DrawString(EnderecoFilial, printFont, sdb, 550, yPos)
        Next
        yPos += 20
        e.Graphics.DrawString("Total: " & TotalRecords, printFontB, sdb, 20, yPos)

        mpreview = False
    End Sub

    Private Sub MontaCabecalho(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        e.Graphics.DrawString(VariaveisGlobais.gFilial, printFont1, sdb, 390, 25, dFac)
        e.Graphics.DrawString("Relatório de Filiais", printFontBB, sdb, 390, 55, dFac)
        e.Graphics.DrawImage(Drawing.Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "Application.ico"), _
         10, 10, 50, 50)

        e.Graphics.DrawString("Cod.Empresa", printFontB, sdb, 20, 120)
        e.Graphics.DrawString("Cod.Filial", printFontB, sdb, 120, 120)
        e.Graphics.DrawString("CNPJ Filial", printFontB, sdb, 200, 120)
        e.Graphics.DrawString("Nome Filial", printFontB, sdb, 400, 120)
        e.Graphics.DrawString("Endereço Filial", printFontB, sdb, 550, 120)

        e.Graphics.DrawString("Emitido em " & ConverteDataParaString(Date.Now) & _
        " por " & VariaveisGlobais.gNomeUsuario & " - Pág " & pagina, printFontP, Brushes.Black, 780, wAlturaPapel - 80, dFrl)

    End Sub

#End Region

End Class