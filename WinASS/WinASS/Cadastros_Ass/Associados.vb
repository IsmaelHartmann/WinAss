Public Class Associados
    Inherits System.Windows.Forms.Form
    Private vIncluir As Boolean
    Private vAlterar As Boolean
    Private vExcluir As Boolean
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTelefone As FzFlexBox.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDataNasc As FzFlexBox.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbSituacao As FzComboBox.FzCombobox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtInscrEst As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCPFCNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMatricula As FzFlexBox.MaskedTextBox
    Friend WithEvents txtMatriculaBRF As FzFlexBox.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
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
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbEstado As FzComboBox.FzCombobox
    Friend WithEvents cbCidade As FzComboBox.FzCombobox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCEP As FzFlexBox.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rbCPF As System.Windows.Forms.RadioButton
    Friend WithEvents rbCNPJ As System.Windows.Forms.RadioButton
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
    Friend WithEvents dtgAssociados As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents btVisualizar As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btNovo As System.Windows.Forms.Button
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
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
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbCampo As FzComboBox.FzCombobox
    Friend WithEvents gbPesquisa As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Associados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gpDados = New System.Windows.Forms.GroupBox
        Me.txtMatriculaBRF = New FzFlexBox.MaskedTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtMatricula = New FzFlexBox.MaskedTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCPFCNPJ = New System.Windows.Forms.MaskedTextBox
        Me.txtInscrEst = New System.Windows.Forms.MaskedTextBox
        Me.txtTelefone = New FzFlexBox.MaskedTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDataNasc = New FzFlexBox.MaskedTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbSituacao = New FzComboBox.FzCombobox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.rbCNPJ = New System.Windows.Forms.RadioButton
        Me.rbCPF = New System.Windows.Forms.RadioButton
        Me.txtCEP = New FzFlexBox.MaskedTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtEndereco = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbEstado = New FzComboBox.FzCombobox
        Me.cbCidade = New FzComboBox.FzCombobox
        Me.Label12 = New System.Windows.Forms.Label
        Me.btConfirmaSelecao = New System.Windows.Forms.Button
        Me.txtDataCadastro = New System.Windows.Forms.MaskedTextBox
        Me.btCancelaSelecao = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbUsuarioCadastro = New FzComboBox.FzCombobox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.dtgAssociados = New System.Windows.Forms.DataGridView
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
        CType(Me.dtgAssociados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpManutencao.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpDados
        '
        Me.gpDados.Controls.Add(Me.txtMatriculaBRF)
        Me.gpDados.Controls.Add(Me.Label15)
        Me.gpDados.Controls.Add(Me.txtMatricula)
        Me.gpDados.Controls.Add(Me.Label13)
        Me.gpDados.Controls.Add(Me.txtCPFCNPJ)
        Me.gpDados.Controls.Add(Me.txtInscrEst)
        Me.gpDados.Controls.Add(Me.txtTelefone)
        Me.gpDados.Controls.Add(Me.Label11)
        Me.gpDados.Controls.Add(Me.txtDataNasc)
        Me.gpDados.Controls.Add(Me.Label10)
        Me.gpDados.Controls.Add(Me.cbSituacao)
        Me.gpDados.Controls.Add(Me.Label9)
        Me.gpDados.Controls.Add(Me.Label8)
        Me.gpDados.Controls.Add(Me.rbCNPJ)
        Me.gpDados.Controls.Add(Me.rbCPF)
        Me.gpDados.Controls.Add(Me.txtCEP)
        Me.gpDados.Controls.Add(Me.Label14)
        Me.gpDados.Controls.Add(Me.txtEndereco)
        Me.gpDados.Controls.Add(Me.Label7)
        Me.gpDados.Controls.Add(Me.cbEstado)
        Me.gpDados.Controls.Add(Me.cbCidade)
        Me.gpDados.Controls.Add(Me.Label12)
        Me.gpDados.Controls.Add(Me.btConfirmaSelecao)
        Me.gpDados.Controls.Add(Me.txtDataCadastro)
        Me.gpDados.Controls.Add(Me.btCancelaSelecao)
        Me.gpDados.Controls.Add(Me.Label1)
        Me.gpDados.Controls.Add(Me.cbUsuarioCadastro)
        Me.gpDados.Controls.Add(Me.Label5)
        Me.gpDados.Controls.Add(Me.txtNome)
        Me.gpDados.Controls.Add(Me.txtCodigo)
        Me.gpDados.Controls.Add(Me.Label3)
        Me.gpDados.Controls.Add(Me.Label6)
        Me.gpDados.Location = New System.Drawing.Point(95, 66)
        Me.gpDados.Name = "gpDados"
        Me.gpDados.Size = New System.Drawing.Size(568, 305)
        Me.gpDados.TabIndex = 0
        Me.gpDados.TabStop = False
        Me.gpDados.Text = "Informações do Associado"
        '
        'txtMatriculaBRF
        '
        Me.txtMatriculaBRF.Flags = 0
        Me.txtMatriculaBRF.Location = New System.Drawing.Point(409, 55)
        Me.txtMatriculaBRF.Mask = "######"
        Me.txtMatriculaBRF.MaxLength = 9
        Me.txtMatriculaBRF.Name = "txtMatriculaBRF"
        Me.txtMatriculaBRF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMatriculaBRF.Size = New System.Drawing.Size(80, 20)
        Me.txtMatriculaBRF.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(308, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 20)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Matrícula BRF"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMatricula
        '
        Me.txtMatricula.Flags = 0
        Me.txtMatricula.Location = New System.Drawing.Point(124, 55)
        Me.txtMatricula.Mask = "#####/#"
        Me.txtMatricula.MaxLength = 9
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMatricula.Size = New System.Drawing.Size(80, 20)
        Me.txtMatricula.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(17, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Matrícula"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCPFCNPJ
        '
        Me.txtCPFCNPJ.Location = New System.Drawing.Point(124, 180)
        Me.txtCPFCNPJ.Mask = "###-###-###/##"
        Me.txtCPFCNPJ.Name = "txtCPFCNPJ"
        Me.txtCPFCNPJ.Size = New System.Drawing.Size(148, 20)
        Me.txtCPFCNPJ.TabIndex = 21
        '
        'txtInscrEst
        '
        Me.txtInscrEst.Location = New System.Drawing.Point(409, 180)
        Me.txtInscrEst.Mask = "###/#######"
        Me.txtInscrEst.Name = "txtInscrEst"
        Me.txtInscrEst.Size = New System.Drawing.Size(80, 20)
        Me.txtInscrEst.TabIndex = 23
        '
        'txtTelefone
        '
        Me.txtTelefone.Flags = 0
        Me.txtTelefone.Location = New System.Drawing.Point(278, 105)
        Me.txtTelefone.Mask = "(##) ####-####"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(86, 20)
        Me.txtTelefone.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(210, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Telefone"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDataNasc
        '
        Me.txtDataNasc.Flags = 0
        Me.txtDataNasc.Location = New System.Drawing.Point(124, 105)
        Me.txtDataNasc.Mask = "##/##/####"
        Me.txtDataNasc.Name = "txtDataNasc"
        Me.txtDataNasc.Size = New System.Drawing.Size(80, 20)
        Me.txtDataNasc.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(17, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Data Nascimento"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbSituacao
        '
        Me.cbSituacao.Location = New System.Drawing.Point(124, 205)
        Me.cbSituacao.Name = "cbSituacao"
        Me.cbSituacao.Size = New System.Drawing.Size(96, 22)
        Me.cbSituacao.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(17, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 20)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Situação"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(321, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Inscrição Estad."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbCNPJ
        '
        Me.rbCNPJ.AutoSize = True
        Me.rbCNPJ.Location = New System.Drawing.Point(67, 181)
        Me.rbCNPJ.Name = "rbCNPJ"
        Me.rbCNPJ.Size = New System.Drawing.Size(50, 18)
        Me.rbCNPJ.TabIndex = 20
        Me.rbCNPJ.Text = "CNPJ"
        Me.rbCNPJ.UseVisualStyleBackColor = True
        '
        'rbCPF
        '
        Me.rbCPF.AutoSize = True
        Me.rbCPF.Checked = True
        Me.rbCPF.Location = New System.Drawing.Point(17, 181)
        Me.rbCPF.Name = "rbCPF"
        Me.rbCPF.Size = New System.Drawing.Size(44, 18)
        Me.rbCPF.TabIndex = 19
        Me.rbCPF.TabStop = True
        Me.rbCPF.Text = "CPF"
        Me.rbCPF.UseVisualStyleBackColor = True
        '
        'txtCEP
        '
        Me.txtCEP.Flags = 0
        Me.txtCEP.Location = New System.Drawing.Point(409, 129)
        Me.txtCEP.Mask = "##.###-###"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(80, 20)
        Me.txtCEP.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(370, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 20)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "CEP"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(124, 156)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(365, 20)
        Me.txtEndereco.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Endereço"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbEstado
        '
        Me.cbEstado.Location = New System.Drawing.Point(124, 129)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(48, 22)
        Me.cbEstado.TabIndex = 13
        '
        'cbCidade
        '
        Me.cbCidade.Location = New System.Drawing.Point(180, 129)
        Me.cbCidade.Name = "cbCidade"
        Me.cbCidade.Size = New System.Drawing.Size(184, 22)
        Me.cbCidade.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(17, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Estado / Cidade"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btConfirmaSelecao
        '
        Me.btConfirmaSelecao.BackColor = System.Drawing.SystemColors.Control
        Me.btConfirmaSelecao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btConfirmaSelecao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConfirmaSelecao.Image = CType(resources.GetObject("btConfirmaSelecao.Image"), System.Drawing.Image)
        Me.btConfirmaSelecao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btConfirmaSelecao.Location = New System.Drawing.Point(408, 279)
        Me.btConfirmaSelecao.Name = "btConfirmaSelecao"
        Me.btConfirmaSelecao.Size = New System.Drawing.Size(74, 22)
        Me.btConfirmaSelecao.TabIndex = 30
        Me.btConfirmaSelecao.Text = "Confirma"
        Me.btConfirmaSelecao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btConfirmaSelecao.UseVisualStyleBackColor = False
        Me.btConfirmaSelecao.Visible = False
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.Enabled = False
        Me.txtDataCadastro.Location = New System.Drawing.Point(124, 249)
        Me.txtDataCadastro.Mask = "00/00/0000 90:00"
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.txtDataCadastro.Size = New System.Drawing.Size(98, 20)
        Me.txtDataCadastro.TabIndex = 27
        Me.txtDataCadastro.ValidatingType = GetType(Date)
        '
        'btCancelaSelecao
        '
        Me.btCancelaSelecao.BackColor = System.Drawing.SystemColors.Control
        Me.btCancelaSelecao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelaSelecao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelaSelecao.Image = CType(resources.GetObject("btCancelaSelecao.Image"), System.Drawing.Image)
        Me.btCancelaSelecao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCancelaSelecao.Location = New System.Drawing.Point(488, 279)
        Me.btCancelaSelecao.Name = "btCancelaSelecao"
        Me.btCancelaSelecao.Size = New System.Drawing.Size(74, 22)
        Me.btCancelaSelecao.TabIndex = 31
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
        Me.Label1.Location = New System.Drawing.Point(17, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Data Cadastro"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbUsuarioCadastro
        '
        Me.cbUsuarioCadastro.Enabled = False
        Me.cbUsuarioCadastro.Location = New System.Drawing.Point(124, 273)
        Me.cbUsuarioCadastro.Name = "cbUsuarioCadastro"
        Me.cbUsuarioCadastro.Size = New System.Drawing.Size(98, 22)
        Me.cbUsuarioCadastro.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Usuário Cadastro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(124, 81)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(240, 20)
        Me.txtNome.TabIndex = 7
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(124, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(80, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Código Associado"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nome Associado"
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
        Me.Label2.BackColor = System.Drawing.Color.MediumSpringGreen
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
        Me.Label4.BackColor = System.Drawing.Color.MediumSpringGreen
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
        Me.gbPesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.tpConsulta.Controls.Add(Me.dtgAssociados)
        Me.tpConsulta.Controls.Add(Me.gbPesquisa)
        Me.tpConsulta.Location = New System.Drawing.Point(4, 23)
        Me.tpConsulta.Name = "tpConsulta"
        Me.tpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConsulta.Size = New System.Drawing.Size(757, 445)
        Me.tpConsulta.TabIndex = 0
        Me.tpConsulta.Text = "Consulta"
        Me.tpConsulta.UseVisualStyleBackColor = True
        '
        'dtgAssociados
        '
        Me.dtgAssociados.AllowUserToAddRows = False
        Me.dtgAssociados.AllowUserToDeleteRows = False
        Me.dtgAssociados.AllowUserToOrderColumns = True
        Me.dtgAssociados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgAssociados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtgAssociados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgAssociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgAssociados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cm})
        Me.dtgAssociados.Location = New System.Drawing.Point(7, 87)
        Me.dtgAssociados.Name = "dtgAssociados"
        Me.dtgAssociados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgAssociados.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgAssociados.Size = New System.Drawing.Size(744, 335)
        Me.dtgAssociados.TabIndex = 1
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
        'Associados
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
        Me.Name = "Associados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Associados"
        Me.gpDados.ResumeLayout(False)
        Me.gpDados.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPesquisa.ResumeLayout(False)
        Me.gbPesquisa.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpConsulta.ResumeLayout(False)
        CType(Me.dtgAssociados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpManutencao.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public objAssociados_Implem As Associados_Implem = AssociadosBOFactory.GetFactory().GetInstance()
    Public obCidades_Implem As Cidades_Implem = CidadesBOFactory.GetFactory().GetInstance()

#Region " Inicializações "

    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtPesquisa.Focus()
    End Sub

    Private Sub Associados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim autoriza As Boolean
        autoriza = VerificaPrograma("Associados", VariaveisGlobais.gSetorUsuario, _
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

            objVariaveisGlobais.PreencheComboBox(cbEstado, VariaveisGlobais.gConexao, _
                "SELECT SiglaEstado FROM C_Estados WHERE isnull(Data_Hora_Exclusao,'') = '' ORDER BY SiglaEstado", "")
            cbEstado.SelectedIndex = 0

            Dim c As New System.Web.UI.WebControls.ListItem
            c.Value = "" : c.Text = " Selecione..." : cbSituacao.Items.Add(c)
            c = New System.Web.UI.WebControls.ListItem
            c.Value = "A" : c.Text = "Ativo" : cbSituacao.Items.Add(c)
            c = New System.Web.UI.WebControls.ListItem
            c.Value = "E" : c.Text = "Excluído" : cbSituacao.Items.Add(c)
            cbSituacao.SelectedIndex = 1

            LimpaTela()

            If vSelecao <> "" Then
                btCancelaSelecao.Visible = True
                btConfirmaSelecao.Visible = True
                objVariaveisGlobais.SetaComboBox(cbCampo, vSelecao)
                If dtgAssociados.Rows.Count = 1 Then
                    dtgAssociados.Rows(0).Selected = True
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

    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEstado.SelectedIndexChanged

        objVariaveisGlobais.PreencheComboBox(cbCidade, VariaveisGlobais.gConexao, _
            "SELECT CodigoCidade, NomeCidade FROM C_Cidades P " & _
            " WHERE (SELECT U.SiglaEstado FROM C_Estados U WHERE U.SiglaEstado = P.SiglaEstado AND isnull(U.Data_Hora_Exclusao,'') = '' ) ='" & cbEstado.SelectedItem.value & _
            "' AND isnull(P.Data_Hora_Exclusao,'') = '' " & _
            " ORDER BY NomeCidade", "")

    End Sub

    Private Sub CadastroAssociados_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        objAssociados_Implem = Nothing
        LimpaErros()
    End Sub

    Private Sub Associados_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F1 Then
            objLeituras.VerC_LOG(VariaveisGlobais.gBD, "C_LOG", "Ass_Associados", txtCodigo.Text)
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
        If e.KeyCode = Keys.Enter And dtgAssociados.Focused Then
            TelaAlteracaoAssociados()
            If btConfirmaSelecao.Visible = True Then
                Me.Dispose()
            Else
            End If
        End If
        If e.KeyCode = Keys.Down And txtPesquisa.Focused Then
            dtgAssociados.Focus()
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
        AdicionarAssociados()
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

    Public Function GuardaDadosAssociados() As Integer
        Try
            objAssociados_Implem.Codigo = Replace(txtCodigo.Text, "'", "''")
            objAssociados_Implem.Matricula = SoNumero(Replace(txtMatricula.Text, "'", "''"))
            objAssociados_Implem.MatriculaBRF = SoNumero(Replace(txtMatriculaBRF.Text, "'", "''"))
            objAssociados_Implem.NomeAssociado = Replace(txtNome.Text, "'", "''")
            objAssociados_Implem.CNPJ = txtCPFCNPJ.Text.Replace(".", "").Replace(",", "").Replace("/", "").Replace("-", "")
            objAssociados_Implem.InscricaoEstadual = txtInscrEst.Text.Replace("/", "").Replace(".", "").Replace("'", "''")
            objAssociados_Implem.Telefone = Replace(txtTelefone.Text, "'", "''")
            objAssociados_Implem.Cidade = cbCidade.SelectedItem.Value
            objAssociados_Implem.Endereco = Replace(txtEndereco.Text, "'", "''")
            objAssociados_Implem.Estado = cbEstado.SelectedItem.Value
            objAssociados_Implem.Situacao = cbSituacao.SelectedItem.Value
            objAssociados_Implem.CEP = txtCEP.Text
            objAssociados_Implem.Data_Nasc = txtDataNasc.Text
            objAssociados_Implem.Codigo_Usuario_Cadastro = cbUsuarioCadastro.SelectedItem.value

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Sub TelaAlteracaoAssociados()
        Try
            Dim wControle As Integer
            LimpaErros()

            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Me.Close()
            End If

            txtCodigo.Text = objAssociados_Implem.Codigo
            txtNome.Text = objAssociados_Implem.NomeAssociado
            txtCPFCNPJ.Text = objAssociados_Implem.CNPJ
            If objAssociados_Implem.CNPJ.Length = 14 Then
                rbCNPJ.Checked = True
                txtCPFCNPJ.Mask = "##.###.###/####-##"
            ElseIf objAssociados_Implem.CNPJ.Length = 11 Then
                rbCPF.Checked = True
                txtCPFCNPJ.Mask = "###.###.###/##"
            End If
            txtCPFCNPJ.Text = objAssociados_Implem.CNPJ

            txtCEP.Text = objAssociados_Implem.CEP

            txtMatricula.Mask = ""
            txtMatricula.Text = objAssociados_Implem.Matricula
            PosicionaDigito(txtMatricula)

            txtMatriculaBRF.Text = objAssociados_Implem.MatriculaBRF
            txtInscrEst.Text = objAssociados_Implem.InscricaoEstadual
            txtDataNasc.Text = objAssociados_Implem.Data_Nasc
            txtEndereco.Text = objAssociados_Implem.Endereco
            txtTelefone.Text = objAssociados_Implem.Telefone
            txtNome.Text = objAssociados_Implem.NomeAssociado
            objVariaveisGlobais.SetaComboBox(cbEstado, objAssociados_Implem.Estado)
            objVariaveisGlobais.SetaComboBox(cbCidade, objAssociados_Implem.Cidade)
            objVariaveisGlobais.SetaComboBox(cbSituacao, objAssociados_Implem.Situacao)

            txtDataCadastro.Text = ConverteDataHoraParaString(objAssociados_Implem.Data_Hora_Cadastro)
            objVariaveisGlobais.SetaComboBox(cbUsuarioCadastro, objAssociados_Implem.Codigo_Usuario_Cadastro)

            btExcluir.Enabled = vExcluir
            btAlterar.Enabled = vAlterar
            btAdicionar.Enabled = False
            btNovo.Enabled = False
            btLimpar.Enabled = True
            TabControl1.SelectedIndex = 1
            tpManutencao.Enabled = True

            Windows.Forms.Cursor.Current = Cursors.Default

            txtNome.Focus() : txtNome.SelectionLength = 0

        Catch ex As Exception

            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Me.Close()

        End Try

    End Sub

    Public Sub AdicionarAssociados()
        Try

            Dim wControle As Integer
            wControle = ValidaDados()
            If wControle <> 0 Then Exit Sub

            GuardaDadosAssociados()
            wControle = objAssociados_Implem.IncluirAssociado
            If wControle = 1 Then
                MessageBox.Show("Já existe um Associado cadastrado com este Codigo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Associado incluído com sucesso! Numero: " & _
                        objAssociados_Implem.Codigo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

            wControle = GuardaDadosAssociados()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If

            wControle = objAssociados_Implem.AlterarAssociado
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Dados do Associado modificados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

        wMensagem = MessageBox.Show("TODOS Dados relacionados a esse Associado serão permanentemente excluídos!" & vbCrLf & " Você deseja excluir este Associado? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If (wMensagem = Windows.Forms.DialogResult.Yes) Then
            objAssociados_Implem.Codigo = txtCodigo.Text
            wControle = objAssociados_Implem.ExcluirAssociado
            If wControle < 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            ElseIf wControle = 1 Then
                MsgBox("Associado Possui Movimento Ativo! ")
                Exit Sub
            End If
            MessageBox.Show("Associado excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LimpaTela()

    End Sub

#End Region

#Region " Atualização do DataGrid e do Form "

    Private Sub AtualizaAssociados()

        Dim wControle As Integer

        Dim wSQL As String = " SELECT Codigo = CAST(Codigo AS VARCHAR), " & _
                " Matricula = CAST(Matricula AS VARCHAR), Nome " & _
                "   Nome,  isnull(CONVERT(VARCHAR(10), Data_Hora_Exclusao, 103),'')," & _
                " LEFT(InscricaoEstadual, 3) + '/' + RIGHT(InscricaoEstadual, 7) AS Inscricao " & _
                " FROM Ass_Associados " & _
                " ORDER BY Nome   "

        wControle = objAssociados_Implem.MostraTabelaAssociados(dtgAssociados, wSQL)
        If wControle <> 0 Then objVariaveisGlobais.MostraErro()
        PreencheCampoPesquisa()
        FazFiltro()

    End Sub

    Private Sub PreencheCampoPesquisa()
        If cbCampo.Items.Count = 0 Then
            Dim c As New System.Web.UI.WebControls.ListItem
            For i As Integer = 0 To dtgAssociados.Columns.Count - 1
                If dtgAssociados.Columns(i).ValueType.ToString = GetType(String).ToString AndAlso dtgAssociados.Columns(i).Visible = True Then
                    c = New System.Web.UI.WebControls.ListItem
                    c.Value = dtgAssociados.Columns(i).HeaderText
                    c.Text = dtgAssociados.Columns(i).HeaderText
                    cbCampo.Items.Add(c)
                End If
            Next
            cbCampo.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtPesquisaNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.TextChanged
        FazFiltro()
    End Sub

    Private Sub cbAssociadosPesquisaEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCampo.SelectedIndexChanged
        FazFiltro()
    End Sub

    Private Sub SELECAO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles rbExato.CheckedChanged, rbComecarPor.CheckedChanged, rbConter.CheckedChanged
        FazFiltro()
    End Sub

    Function FazFiltro()
        If Not IsNothing(dtgAssociados.DataSource) Then
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
            For i As Integer = 0 To dtgAssociados.Columns.Count - 1
                If dtgAssociados.Columns(i).Name = cbCampo.Text Then
                    wValida = True
                    Exit For
                End If
            Next

            If wValida = False Then
                MsgBox("Campo pesquisa está incorreto")
                Return wValida
            End If

            wDataTable = objAssociados_Implem.wDataSet.Tables(0)
            Dim wDataView = New DataView(wDataTable, _
                     wPesquisa, _
                     "", DataViewRowState.CurrentRows)
            dtgAssociados.DataSource = wDataView
        End If
        Return True
    End Function

    Private Sub dtgAssociados_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgAssociados.MouseMove
        Try
            Dim hti As System.Windows.Forms.DataGridView.HitTestInfo
            hti = dtgAssociados.HitTest(e.X, e.Y)

            If hti.Type = System.Windows.Forms.DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 5 Then
                    Me.Cursor = System.Windows.Forms.Cursors.Hand
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand
                Else
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                End If
                If hti.ColumnIndex = 5 Then
                    ToolTip1.SetToolTip(dtgAssociados, "")
                End If
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                ToolTip1.SetToolTip(dtgAssociados, "")
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgAssociados_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgAssociados.MouseUp
        Try
            Dim hti As DataGridView.HitTestInfo = dtgAssociados.HitTest(e.X, e.Y)

            If hti.Type = DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 5 Then
                    TelaAlteracaoAssociados()
                End If
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgAssociados_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgAssociados.CurrentCellChanged
        Try
            Dim wControle As Integer
            If IsNothing(dtgAssociados.DataSource) Or IsNothing(dtgAssociados.CurrentCell) Then Exit Sub

            objAssociados_Implem.Codigo = dtgAssociados.Item(0, dtgAssociados.CurrentCell().RowIndex).Value
            wControle = objAssociados_Implem.BuscarAssociado
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            dtgAssociados.Rows(dtgAssociados.CurrentCell().RowIndex).Selected = True
            dtgAssociados.Focus()
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

        txtCodigo.Text = ""
        txtMatricula.Text = ""
        txtMatriculaBRF.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtCPFCNPJ.Text = ""
        rbCPF.Checked = True
        txtInscrEst.Text = ""
        txtCEP.Text = ""
        txtTelefone.Text = ""
        txtDataNasc.Text = ""
        cbCidade.SelectedIndex = 0
        cbEstado.SelectedItem = 0
        cbSituacao.SelectedItem = 0

        txtDataCadastro.Text = ConverteDataHoraParaString(Date.Now)
        objVariaveisGlobais.SetaComboBox(cbUsuarioCadastro, VariaveisGlobais.gCodigoUsuario)

        btAlterar.Enabled = False
        btExcluir.Enabled = False
        txtCodigo.Enabled = False

        If wNovoRegistro = False Then
            AtualizaAssociados()
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
            txtMatricula.Focus()
        End If

        LimpaErros()

    End Sub

    Private Sub btLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLimpar.Click
        LimpaTela()
    End Sub

#End Region

    Private Sub rbCNPJ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCNPJ.Click, rbCPF.Click
        If rbCPF.Checked = True Then
            txtCPFCNPJ.Text = ""
            txtCPFCNPJ.Mask = "###.###.###/##"
        ElseIf rbCNPJ.Checked = True Then
            txtCPFCNPJ.Text = ""
            txtCPFCNPJ.Mask = "##.###.###/####-##"
        End If
    End Sub

#Region " Valida da tela "

    Private Function ValidaDados()
        LimpaErros()
        Dim f As Integer
        Dim wErros As String = ""
        Dim wFoco As Integer = -1
        TabControl1.SelectedIndex = 1

        Dim e1 As New System.ComponentModel.CancelEventArgs
        txtMatricula_Validating(txtMatricula, e1)
        txtMatriculaBRF_Validating(txtMatriculaBRF, e1)
        txtNome_Validating(txtNome, e1)
        txtCPFCNPJ_Validating(txtCPFCNPJ, e1)
        txtDataNasc_Validating(txtDataNasc, e1)
        txtTelefone_Validating(txtTelefone, e1)
        txtInscrEstadual_Validating(txtInscrEst, e1)
        txtCEP_Validating(txtCEP, e1)
        cbSituacao_Validating(cbSituacao, e1)
        cbEstado_Validating(cbEstado, e1)
        cbCidade_Validating(cbCidade, e1)
       
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

        ErrorProvider1.SetError(txtMatricula, "")
        ErrorProvider1.SetError(txtNome, "")
        ErrorProvider1.SetError(txtCPFCNPJ, "")
        ErrorProvider1.SetError(txtDataNasc, "")
        ErrorProvider1.SetError(txtTelefone, "")
        ErrorProvider1.SetError(txtInscrEst, "")
        ErrorProvider1.SetError(txtCEP, "")
        ErrorProvider1.SetError(cbSituacao, "")
        ErrorProvider1.SetError(cbCidade, "")
        ErrorProvider1.SetError(cbEstado, "")
        objVariaveisGlobais.InicializaVetorErros()
    End Sub

    Private Sub txtNome_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNome.Validating
        Dim wMsgErro As String = "Digite o Nome do Associado!"

        If txtNome.Text = "" Then
            ErrorProvider1.SetError(txtNome, wMsgErro)
            VariaveisGlobais.gErroTela(0) = wMsgErro
        Else
            ErrorProvider1.SetError(txtNome, "")
            VariaveisGlobais.gErroTela(0) = ""
        End If
    End Sub

    Private Sub txtCPFCNPJ_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCPFCNPJ.Validating
        Dim wMsgErro As String = "Digite corretamente o CPF/CNPJ!"
        Dim wControle As Integer

        If UnMaskBS(txtCPFCNPJ.Text) = "" Then
            'ErrorProvider1.SetError(txtCPFCNPJ, wMsgErro)
            'VariaveisGlobais.gErroTela(1) = wMsgErro
            wMsgErro = ""
        Else
            If rbCNPJ.Checked = True Then
                If UnMaskBS(txtCPFCNPJ.Text).Length <> 14 OrElse Not IsCNPJ(txtCPFCNPJ.Text) Then
                    ErrorProvider1.SetError(txtCPFCNPJ, wMsgErro)
                    VariaveisGlobais.gErroTela(1) = wMsgErro
                Else
                    objAssociados_Implem.CNPJ = UnMaskBS(txtCPFCNPJ.Text)
                    wControle = objAssociados_Implem.VerificaExistenciaCPFCNPJ(txtCodigo.Text)
                    If wControle < 0 Then
                        objVariaveisGlobais.MostraErro()
                        Exit Sub
                    ElseIf wControle > 0 Then
                        wMsgErro = "Este CPF/CNPJ já é usado por outro associado!"
                        ErrorProvider1.SetError(txtCPFCNPJ, wMsgErro)
                        VariaveisGlobais.gErroTela(1) = wMsgErro
                    Else
                        ErrorProvider1.SetError(txtCPFCNPJ, "")
                        VariaveisGlobais.gErroTela(1) = ""
                    End If
                End If

            ElseIf rbCPF.Checked = True Then
                If UnMaskBS(txtCPFCNPJ.Text).Length <> 11 OrElse Not IsCPF(txtCPFCNPJ.Text) Then
                    ErrorProvider1.SetError(txtCPFCNPJ, wMsgErro)
                    VariaveisGlobais.gErroTela(1) = wMsgErro
                Else
                    objAssociados_Implem.CNPJ = UnMaskBS(txtCPFCNPJ.Text)
                    wControle = objAssociados_Implem.VerificaExistenciaCPFCNPJ(txtCodigo.Text)
                    If wControle < 0 Then
                        objVariaveisGlobais.MostraErro()
                        Exit Sub
                    ElseIf wControle > 0 Then
                        wMsgErro = "Este CPF/CNPJ já é usado por outro associado!"
                        ErrorProvider1.SetError(txtCPFCNPJ, wMsgErro)
                        VariaveisGlobais.gErroTela(1) = wMsgErro
                    Else
                        ErrorProvider1.SetError(txtCPFCNPJ, "")
                        VariaveisGlobais.gErroTela(1) = ""
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtDataNasc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDataNasc.Validating
        Dim wMsgErro As String = "Digite corretamente a Data de Nascimento!"

        If Not IsDate(txtDataNasc.Text) OrElse CDate(txtDataNasc.Text).Year <= "1900" Then
            ErrorProvider1.SetError(txtDataNasc, wMsgErro)
            VariaveisGlobais.gErroTela(2) = wMsgErro
        Else
            ErrorProvider1.SetError(txtDataNasc, "")
            VariaveisGlobais.gErroTela(2) = ""
        End If
    End Sub

    Private Sub txtTelefone_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTelefone.Validating
        Dim wMsgErro As String = "Digite corretamente o Telefone!"

        If txtTelefone.Text.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").Length <> 10 Then
            ErrorProvider1.SetError(txtTelefone, wMsgErro)
            VariaveisGlobais.gErroTela(3) = wMsgErro
        Else
            ErrorProvider1.SetError(txtTelefone, "")
            VariaveisGlobais.gErroTela(3) = ""
        End If
    End Sub

    Private Sub txtInscrEstadual_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtInscrEst.Validating
        Dim wMsgErro As String = "Digite corretamente a Inscrição Estadual!"
        Dim wControle As Integer

        If txtInscrEst.Text <> "" Then
            wControle = GenProc.ValidaIE(SoNumero(txtInscrEst.Text), cbEstado.SelectedItem.value)
            If wControle = 1 Then
                ErrorProvider1.SetError(txtInscrEst, wMsgErro)
                VariaveisGlobais.gErroTela(4) = wMsgErro
            ElseIf wControle = -1 Then
                ErrorProvider1.SetError(txtInscrEst, wMsgErro)
                VariaveisGlobais.gErroTela(4) = wMsgErro
            ElseIf wControle = 0 Then

                'objAssociados_Implem.CNPJ = UnMaskBS(txtInscrEst.Text)
                'wControle = objAssociados_Implem.VerificaExistenciaIE
                'If wControle < 0 Then
                '    objVariaveisGlobais.MostraErro()
                '    Exit Sub
                'ElseIf wControle > 0 Then
                '    MsgBox("Esta Inscrição Estadual já é usada por outro associado!")
                '    Exit Sub
                'Else
                ErrorProvider1.SetError(txtInscrEst, "")
                VariaveisGlobais.gErroTela(4) = ""
                'End If
            End If
        Else
            ErrorProvider1.SetError(txtInscrEst, wMsgErro)
            VariaveisGlobais.gErroTela(4) = wMsgErro
        End If
    End Sub

    Private Sub txtCEP_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCEP.Validating
        Dim wMsgErro As String = "Digite corretamente o CEP!"
        If txtCEP.Text.Replace(" ", "").Replace("-", "").Replace(".", "").Length <> 8 Then
            ErrorProvider1.SetError(txtCEP, wMsgErro)
            VariaveisGlobais.gErroTela(5) = wMsgErro
        Else
            ErrorProvider1.SetError(txtCEP, "")
            VariaveisGlobais.gErroTela(5) = ""
        End If
    End Sub

    Private Sub cbEstado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbEstado.Validating
        Dim wMsgErro As String = ""

        If cbEstado.SelectedIndex = 0 Then
            wMsgErro = "Informe o Estado !"
        ElseIf cbEstado.SelectedIndex < 0 Then
            wMsgErro = "Informe o Estado !"
        End If

        If wMsgErro <> "" Then
            ErrorProvider1.SetError(cbEstado, wMsgErro)
            VariaveisGlobais.gErroTela(6) = wMsgErro
        Else
            ErrorProvider1.SetError(cbEstado, "")
            VariaveisGlobais.gErroTela(6) = ""
        End If
    End Sub

    Private Sub cbCidade_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbCidade.Validating
        Dim wMsgErro As String = ""

        If cbCidade.SelectedIndex = 0 Then
            wMsgErro = "Informe a Cidade !"
        ElseIf cbCidade.SelectedIndex < 0 Then
            wMsgErro = "Informe a Cidade !"
        End If

        If wMsgErro <> "" Then
            ErrorProvider1.SetError(cbCidade, wMsgErro)
            VariaveisGlobais.gErroTela(7) = wMsgErro
        Else
            ErrorProvider1.SetError(cbCidade, "")
            VariaveisGlobais.gErroTela(7) = ""
        End If
    End Sub

    Private Sub cbSituacao_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbSituacao.Validating
        Dim wMsgErro As String = ""

        If cbSituacao.SelectedIndex = 0 Then
            wMsgErro = "Informe a Situação do Associado !"
        ElseIf cbSituacao.SelectedIndex < 0 Then
            wMsgErro = "Informe a Situação do Associado !"
        End If

        If wMsgErro <> "" Then
            ErrorProvider1.SetError(cbSituacao, wMsgErro)
            VariaveisGlobais.gErroTela(8) = wMsgErro
        Else
            ErrorProvider1.SetError(cbSituacao, "")
            VariaveisGlobais.gErroTela(8) = ""
        End If
    End Sub

    Private Sub txtMatricula_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMatricula.Validating
        Dim wMsgErro As String = ""
        Dim wControle As Integer
        Dim wMatricula As String = txtMatricula.Text.Replace("/", "")
        Dim wDigito As String = ""
        Dim wParametro As String = ""

        If wMatricula <> "" Then
            If Len(wMatricula) < 2 Then
                wMsgErro = "Matrícula + Digito deve ter 2 ou mais dígitos"
            Else
                wDigito = wMatricula.Substring(Len(wMatricula) - 1, 1)
                wMatricula = wMatricula.Substring(0, Len(wMatricula) - 1)

                wControle = objAssociados_Implem.VerificaExistenciaMatricula(SoNumero(wMatricula), SoNumero(txtCodigo.Text), wParametro)
                If wControle < 0 Then
                    wMsgErro = "Erro de acesso a Associados !"
                ElseIf wControle = 0 Then
                    wMsgErro = "Matrícula já existe no Associado Código: " & wParametro
                End If
            End If
        End If

        If wMsgErro <> "" Then
            ErrorProvider1.SetError(txtMatricula, wMsgErro)
            VariaveisGlobais.gErroTela(9) = wMsgErro
        Else
            ErrorProvider1.SetError(txtMatricula, "")
            VariaveisGlobais.gErroTela(9) = ""
        End If
    End Sub

    Private Sub txtMatriculaBRF_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMatriculaBRF.Validating
        Dim wMsgErro As String = ""
        Dim wControle As Integer
        Dim wParametro As String

        If txtMatricula.Text <> "" AndAlso txtMatriculaBRF.Text <> "" Then
            wMsgErro = "Informe apenas a Matrícula ou a Matrícula BRF !"
        ElseIf txtMatricula.Text = "" AndAlso txtMatriculaBRF.Text = "" Then
            'wMsgErro = "Informe apenas a Matrícula ou a Matrícula BRF !"
        ElseIf txtMatriculaBRF.Text <> "" Then

            wControle = objAssociados_Implem.VerificaExistenciaMatriculaBRF(txtMatriculaBRF.Text, (txtCodigo.Text), wParametro)
            If wControle < 0 Then
                wMsgErro = "Erro de acesso a Associados !"
            ElseIf wControle = 0 Then
                wMsgErro = "Matrícula BRF já existe no Associado Código: " & wParametro
            End If
        End If

        If wMsgErro <> "" Then
            ErrorProvider1.SetError(txtMatriculaBRF, wMsgErro)
            VariaveisGlobais.gErroTela(10) = wMsgErro
        Else
            ErrorProvider1.SetError(txtMatriculaBRF, "")
            VariaveisGlobais.gErroTela(10) = ""
        End If
    End Sub

    Private Sub txtMatricula_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMatricula.KeyUp
        PosicionaDigito(txtMatricula)
    End Sub

#End Region

#Region " Impressao "

#Region " Variaveis de Impressao "

    Dim wAlturaPapel As Integer
    Dim sdb As System.Drawing.Brush

    Dim Codigo As String
    Dim Nome As String

    Dim TotalRecords As Integer = 0
    Dim pagina As Integer = 0
    Dim dados As Integer = 0
    Dim dlg As PrintPreviewDialog

    Dim printFont1 As New Font("Courier New", 6, FontStyle.Bold, GraphicsUnit.Millimeter)
    Dim printFontP As New Font("Courier New", 2.5, FontStyle.Regular, GraphicsUnit.Millimeter)
    Dim printFont As New Font("Courier New", 3, FontStyle.Regular, GraphicsUnit.Millimeter)
    Dim printFontB As New Font("Courier New", 3, FontStyle.Bold, GraphicsUnit.Millimeter)

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
        TotalRecords = dtgAssociados.RowCount

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

            Codigo = dtgAssociados.Item(0, i).Value
            Nome = dtgAssociados.Item(1, i).Value


            e.Graphics.DrawString(Codigo, printFont, sdb, 20, yPos)
            e.Graphics.DrawString(Nome, printFont, sdb, 80, yPos)
        Next
        yPos += 20
        e.Graphics.DrawString("Total: " & TotalRecords, printFontB, sdb, 20, yPos)

        mpreview = False
    End Sub

    Private Sub MontaCabecalho(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        e.Graphics.DrawString(VariaveisGlobais.gNomeEmpresaUsuario, printFont1, sdb, 390, 25, dFac)
        e.Graphics.DrawString("Relatório de Associados", printFontB, sdb, 390, 55, dFac)
        e.Graphics.DrawImage(Drawing.Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "Application.ico"), _
         10, 10, 50, 50)

        e.Graphics.DrawString("Código", printFontB, sdb, 20, 120)
        e.Graphics.DrawString("Nome do Associado", printFontB, sdb, 80, 120)

        e.Graphics.DrawString("Emitido em " & ConverteDataParaString(Date.Now) & _
        " por " & VariaveisGlobais.gNomeUsuario & " - Pág " & pagina, printFontP, Brushes.Black, 780, wAlturaPapel - 80, dFrl)

    End Sub

#End Region

    Private Sub btConfirmaSelecao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmaSelecao.Click
        Me.Close()
    End Sub

    Private Sub btCancelaSelecao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelaSelecao.Click
        objAssociados_Implem.Codigo = ""
        Me.Close()
    End Sub

    Private Sub dtgAssociados_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgAssociados.Sorted, dtgAssociados.DataSourceChanged
        Dim Vermelho As New DataGridViewCellStyle
        Vermelho.BackColor = Color.Salmon
        Vermelho.ForeColor = Color.Black

        For r As Integer = 0 To dtgAssociados.Rows.Count - 1
            If IsDate(dtgAssociados.Item("DE", r).Value) Then
                For i As Integer = 0 To dtgAssociados.ColumnCount - 1
                    dtgAssociados.Item(i, r).Style = Vermelho
                Next
            End If
        Next r
    End Sub
End Class