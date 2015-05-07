Public Class Programas
    Inherits System.Windows.Forms.Form
    Private vIncluir As Boolean
    Private vAlterar As Boolean
    Private vExcluir As Boolean

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
    Friend WithEvents cbUsuarioCadastro As FzComboBox.FzCombobox
    Friend WithEvents cbUsuarioCadastroLiberacao As FzComboBox.FzCombobox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpConsulta As System.Windows.Forms.TabPage
    Friend WithEvents tpManutencao As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbConter As System.Windows.Forms.RadioButton
    Friend WithEvents rbComecarPor As System.Windows.Forms.RadioButton
    Friend WithEvents rbExato As System.Windows.Forms.RadioButton
    Friend WithEvents dtgProgramas As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents btVisualizar As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btNovo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDataCadastro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbLiberacoes As System.Windows.Forms.GroupBox
    Friend WithEvents cbExcluir As FzComboBox.FzCombobox
    Friend WithEvents cbAlterar As FzComboBox.FzCombobox
    Friend WithEvents cbIncluir As FzComboBox.FzCombobox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbTipoUsuario As FzComboBox.FzCombobox
    Friend WithEvents cbSetor As FzComboBox.FzCombobox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dtgLiberacoes As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btAdicionarLiberacao As System.Windows.Forms.Button
    Friend WithEvents btAlterarLiberacao As System.Windows.Forms.Button
    Friend WithEvents btLimparLiberacao As System.Windows.Forms.Button
    Friend WithEvents btExcluirLiberacao As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDataCadastroLiberacao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Cm As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents gpDados As System.Windows.Forms.GroupBox
    Friend WithEvents btExcluir As System.Windows.Forms.Button
    Friend WithEvents btAlterar As System.Windows.Forms.Button
    Friend WithEvents btAdicionar As System.Windows.Forms.Button
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents txtPrograma As System.Windows.Forms.TextBox
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbCampo As FzComboBox.FzCombobox
    Friend WithEvents gbPesquisa As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Programas))
        Me.gpDados = New System.Windows.Forms.GroupBox
        Me.cbUsuarioCadastro = New FzComboBox.FzCombobox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDataCadastro = New System.Windows.Forms.MaskedTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDescricao = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPrograma = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
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
        Me.dtgProgramas = New System.Windows.Forms.DataGridView
        Me.Cm = New System.Windows.Forms.DataGridViewImageColumn
        Me.tpManutencao = New System.Windows.Forms.TabPage
        Me.dtgLiberacoes = New System.Windows.Forms.DataGridView
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.gbLiberacoes = New System.Windows.Forms.GroupBox
        Me.cbUsuarioCadastroLiberacao = New FzComboBox.FzCombobox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDataCadastroLiberacao = New System.Windows.Forms.MaskedTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.btAdicionarLiberacao = New System.Windows.Forms.Button
        Me.btAlterarLiberacao = New System.Windows.Forms.Button
        Me.btLimparLiberacao = New System.Windows.Forms.Button
        Me.btExcluirLiberacao = New System.Windows.Forms.Button
        Me.cbExcluir = New FzComboBox.FzCombobox
        Me.cbAlterar = New FzComboBox.FzCombobox
        Me.cbIncluir = New FzComboBox.FzCombobox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbTipoUsuario = New FzComboBox.FzCombobox
        Me.cbSetor = New FzComboBox.FzCombobox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
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
        CType(Me.dtgProgramas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpManutencao.SuspendLayout()
        CType(Me.dtgLiberacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLiberacoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpDados
        '
        Me.gpDados.Controls.Add(Me.cbUsuarioCadastro)
        Me.gpDados.Controls.Add(Me.Label6)
        Me.gpDados.Controls.Add(Me.txtDataCadastro)
        Me.gpDados.Controls.Add(Me.Label5)
        Me.gpDados.Controls.Add(Me.txtDescricao)
        Me.gpDados.Controls.Add(Me.Label1)
        Me.gpDados.Controls.Add(Me.txtPrograma)
        Me.gpDados.Controls.Add(Me.Label3)
        Me.gpDados.Location = New System.Drawing.Point(6, 6)
        Me.gpDados.Name = "gpDados"
        Me.gpDados.Size = New System.Drawing.Size(369, 191)
        Me.gpDados.TabIndex = 0
        Me.gpDados.TabStop = False
        Me.gpDados.Text = "Informações do Programa"
        '
        'cbUsuarioCadastro
        '
        Me.cbUsuarioCadastro.Enabled = False
        Me.cbUsuarioCadastro.Location = New System.Drawing.Point(151, 145)
        Me.cbUsuarioCadastro.Name = "cbUsuarioCadastro"
        Me.cbUsuarioCadastro.Size = New System.Drawing.Size(132, 22)
        Me.cbUsuarioCadastro.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Usuário"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.Enabled = False
        Me.txtDataCadastro.Location = New System.Drawing.Point(151, 121)
        Me.txtDataCadastro.Mask = "00/00/0000 90:00"
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.txtDataCadastro.Size = New System.Drawing.Size(132, 20)
        Me.txtDataCadastro.TabIndex = 5
        Me.txtDataCadastro.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Data Cadastro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(151, 54)
        Me.txtDescricao.MaxLength = 200
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(212, 61)
        Me.txtDescricao.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descrição"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrograma
        '
        Me.txtPrograma.Location = New System.Drawing.Point(151, 28)
        Me.txtPrograma.MaxLength = 50
        Me.txtPrograma.Name = "txtPrograma"
        Me.txtPrograma.Size = New System.Drawing.Size(212, 20)
        Me.txtPrograma.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Código Programa"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tpConsulta.Controls.Add(Me.dtgProgramas)
        Me.tpConsulta.Controls.Add(Me.gbPesquisa)
        Me.tpConsulta.Location = New System.Drawing.Point(4, 23)
        Me.tpConsulta.Name = "tpConsulta"
        Me.tpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConsulta.Size = New System.Drawing.Size(757, 445)
        Me.tpConsulta.TabIndex = 0
        Me.tpConsulta.Text = "Consulta"
        Me.tpConsulta.UseVisualStyleBackColor = True
        '
        'dtgProgramas
        '
        Me.dtgProgramas.AllowUserToAddRows = False
        Me.dtgProgramas.AllowUserToDeleteRows = False
        Me.dtgProgramas.AllowUserToOrderColumns = True
        Me.dtgProgramas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgProgramas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtgProgramas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgProgramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProgramas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cm})
        Me.dtgProgramas.Location = New System.Drawing.Point(7, 87)
        Me.dtgProgramas.Name = "dtgProgramas"
        Me.dtgProgramas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgProgramas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgProgramas.Size = New System.Drawing.Size(744, 335)
        Me.dtgProgramas.TabIndex = 1
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
        Me.tpManutencao.Controls.Add(Me.dtgLiberacoes)
        Me.tpManutencao.Controls.Add(Me.gbLiberacoes)
        Me.tpManutencao.Controls.Add(Me.gpDados)
        Me.tpManutencao.Location = New System.Drawing.Point(4, 22)
        Me.tpManutencao.Name = "tpManutencao"
        Me.tpManutencao.Padding = New System.Windows.Forms.Padding(3)
        Me.tpManutencao.Size = New System.Drawing.Size(757, 446)
        Me.tpManutencao.TabIndex = 1
        Me.tpManutencao.Text = "Manutenção"
        Me.tpManutencao.UseVisualStyleBackColor = True
        '
        'dtgLiberacoes
        '
        Me.dtgLiberacoes.AllowUserToAddRows = False
        Me.dtgLiberacoes.AllowUserToDeleteRows = False
        Me.dtgLiberacoes.AllowUserToOrderColumns = True
        Me.dtgLiberacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtgLiberacoes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgLiberacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLiberacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1})
        Me.dtgLiberacoes.Location = New System.Drawing.Point(381, 6)
        Me.dtgLiberacoes.Name = "dtgLiberacoes"
        Me.dtgLiberacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgLiberacoes.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgLiberacoes.Size = New System.Drawing.Size(370, 433)
        Me.dtgLiberacoes.TabIndex = 2
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Cm"
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 33
        '
        'gbLiberacoes
        '
        Me.gbLiberacoes.Controls.Add(Me.cbUsuarioCadastroLiberacao)
        Me.gbLiberacoes.Controls.Add(Me.Label11)
        Me.gbLiberacoes.Controls.Add(Me.txtDataCadastroLiberacao)
        Me.gbLiberacoes.Controls.Add(Me.Label12)
        Me.gbLiberacoes.Controls.Add(Me.btAdicionarLiberacao)
        Me.gbLiberacoes.Controls.Add(Me.btAlterarLiberacao)
        Me.gbLiberacoes.Controls.Add(Me.btLimparLiberacao)
        Me.gbLiberacoes.Controls.Add(Me.btExcluirLiberacao)
        Me.gbLiberacoes.Controls.Add(Me.cbExcluir)
        Me.gbLiberacoes.Controls.Add(Me.cbAlterar)
        Me.gbLiberacoes.Controls.Add(Me.cbIncluir)
        Me.gbLiberacoes.Controls.Add(Me.Label7)
        Me.gbLiberacoes.Controls.Add(Me.Label8)
        Me.gbLiberacoes.Controls.Add(Me.Label9)
        Me.gbLiberacoes.Controls.Add(Me.txtUsuario)
        Me.gbLiberacoes.Controls.Add(Me.Label10)
        Me.gbLiberacoes.Controls.Add(Me.cbTipoUsuario)
        Me.gbLiberacoes.Controls.Add(Me.cbSetor)
        Me.gbLiberacoes.Controls.Add(Me.Label22)
        Me.gbLiberacoes.Controls.Add(Me.Label21)
        Me.gbLiberacoes.Location = New System.Drawing.Point(6, 203)
        Me.gbLiberacoes.Name = "gbLiberacoes"
        Me.gbLiberacoes.Size = New System.Drawing.Size(370, 209)
        Me.gbLiberacoes.TabIndex = 1
        Me.gbLiberacoes.TabStop = False
        Me.gbLiberacoes.Text = "Liberações"
        '
        'cbUsuarioCadastroLiberacao
        '
        Me.cbUsuarioCadastroLiberacao.Enabled = False
        Me.cbUsuarioCadastroLiberacao.Location = New System.Drawing.Point(243, 145)
        Me.cbUsuarioCadastroLiberacao.Name = "cbUsuarioCadastroLiberacao"
        Me.cbUsuarioCadastroLiberacao.Size = New System.Drawing.Size(120, 22)
        Me.cbUsuarioCadastroLiberacao.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(151, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Usuario"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDataCadastroLiberacao
        '
        Me.txtDataCadastroLiberacao.Enabled = False
        Me.txtDataCadastroLiberacao.Location = New System.Drawing.Point(243, 121)
        Me.txtDataCadastroLiberacao.Mask = "00/00/0000 90:00"
        Me.txtDataCadastroLiberacao.Name = "txtDataCadastroLiberacao"
        Me.txtDataCadastroLiberacao.Size = New System.Drawing.Size(120, 20)
        Me.txtDataCadastroLiberacao.TabIndex = 13
        Me.txtDataCadastroLiberacao.ValidatingType = GetType(Date)
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(151, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Data Cadastro"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btAdicionarLiberacao
        '
        Me.btAdicionarLiberacao.BackColor = System.Drawing.SystemColors.Control
        Me.btAdicionarLiberacao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAdicionarLiberacao.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionarLiberacao.Image = Global.WinASS.My.Resources.Resources._7689_16x16
        Me.btAdicionarLiberacao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btAdicionarLiberacao.Location = New System.Drawing.Point(47, 173)
        Me.btAdicionarLiberacao.Name = "btAdicionarLiberacao"
        Me.btAdicionarLiberacao.Size = New System.Drawing.Size(83, 25)
        Me.btAdicionarLiberacao.TabIndex = 16
        Me.btAdicionarLiberacao.Text = "Adicionar"
        Me.btAdicionarLiberacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAdicionarLiberacao.UseVisualStyleBackColor = False
        '
        'btAlterarLiberacao
        '
        Me.btAlterarLiberacao.BackColor = System.Drawing.SystemColors.Control
        Me.btAlterarLiberacao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAlterarLiberacao.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAlterarLiberacao.Image = Global.WinASS.My.Resources.Resources._7706_16x16
        Me.btAlterarLiberacao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btAlterarLiberacao.Location = New System.Drawing.Point(136, 173)
        Me.btAlterarLiberacao.Name = "btAlterarLiberacao"
        Me.btAlterarLiberacao.Size = New System.Drawing.Size(71, 25)
        Me.btAlterarLiberacao.TabIndex = 17
        Me.btAlterarLiberacao.Text = "Alterar"
        Me.btAlterarLiberacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAlterarLiberacao.UseVisualStyleBackColor = False
        '
        'btLimparLiberacao
        '
        Me.btLimparLiberacao.BackColor = System.Drawing.SystemColors.Control
        Me.btLimparLiberacao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLimparLiberacao.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimparLiberacao.Image = Global.WinASS.My.Resources.Resources._2792_16x16
        Me.btLimparLiberacao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btLimparLiberacao.Location = New System.Drawing.Point(290, 173)
        Me.btLimparLiberacao.Name = "btLimparLiberacao"
        Me.btLimparLiberacao.Size = New System.Drawing.Size(71, 25)
        Me.btLimparLiberacao.TabIndex = 19
        Me.btLimparLiberacao.Text = "Limpar"
        Me.btLimparLiberacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btLimparLiberacao.UseVisualStyleBackColor = False
        '
        'btExcluirLiberacao
        '
        Me.btExcluirLiberacao.BackColor = System.Drawing.SystemColors.Control
        Me.btExcluirLiberacao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btExcluirLiberacao.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExcluirLiberacao.Image = Global.WinASS.My.Resources.Resources._7884_16x16
        Me.btExcluirLiberacao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btExcluirLiberacao.Location = New System.Drawing.Point(213, 173)
        Me.btExcluirLiberacao.Name = "btExcluirLiberacao"
        Me.btExcluirLiberacao.Size = New System.Drawing.Size(71, 25)
        Me.btExcluirLiberacao.TabIndex = 18
        Me.btExcluirLiberacao.Text = "Excluir"
        Me.btExcluirLiberacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btExcluirLiberacao.UseVisualStyleBackColor = False
        '
        'cbExcluir
        '
        Me.cbExcluir.Location = New System.Drawing.Point(84, 145)
        Me.cbExcluir.Name = "cbExcluir"
        Me.cbExcluir.Size = New System.Drawing.Size(64, 22)
        Me.cbExcluir.TabIndex = 11
        '
        'cbAlterar
        '
        Me.cbAlterar.Location = New System.Drawing.Point(84, 121)
        Me.cbAlterar.Name = "cbAlterar"
        Me.cbAlterar.Size = New System.Drawing.Size(64, 22)
        Me.cbAlterar.TabIndex = 9
        '
        'cbIncluir
        '
        Me.cbIncluir.Location = New System.Drawing.Point(84, 97)
        Me.cbIncluir.Name = "cbIncluir"
        Me.cbIncluir.Size = New System.Drawing.Size(64, 22)
        Me.cbIncluir.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(4, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Excluir"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(4, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Alterar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(4, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Incluir"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(84, 73)
        Me.txtUsuario.MaxLength = 50
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(280, 20)
        Me.txtUsuario.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(4, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Usuario"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbTipoUsuario
        '
        Me.cbTipoUsuario.ItemHeight = 14
        Me.cbTipoUsuario.Location = New System.Drawing.Point(84, 49)
        Me.cbTipoUsuario.Name = "cbTipoUsuario"
        Me.cbTipoUsuario.Size = New System.Drawing.Size(280, 22)
        Me.cbTipoUsuario.TabIndex = 3
        '
        'cbSetor
        '
        Me.cbSetor.Location = New System.Drawing.Point(84, 25)
        Me.cbSetor.Name = "cbSetor"
        Me.cbSetor.Size = New System.Drawing.Size(280, 22)
        Me.cbSetor.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Location = New System.Drawing.Point(4, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 20)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Setor"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Location = New System.Drawing.Point(4, 49)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 20)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Tipo Usuario"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btAdicionar.Image = Global.WinASS.My.Resources.Resources._7689_16x16
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
        Me.btAlterar.Image = Global.WinASS.My.Resources.Resources._7706_16x16
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
        Me.btLimpar.Image = Global.WinASS.My.Resources.Resources._2792_16x16
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
        Me.btExcluir.Image = Global.WinASS.My.Resources.Resources._7884_16x16
        Me.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btExcluir.Location = New System.Drawing.Point(292, 1)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(86, 25)
        Me.btExcluir.TabIndex = 4
        Me.btExcluir.Text = "Excluir (F4)"
        Me.btExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btExcluir.UseVisualStyleBackColor = False
        '
        'Programas
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
        Me.Name = "Programas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Programas"
        Me.gpDados.ResumeLayout(False)
        Me.gpDados.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPesquisa.ResumeLayout(False)
        Me.gbPesquisa.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpConsulta.ResumeLayout(False)
        CType(Me.dtgProgramas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpManutencao.ResumeLayout(False)
        CType(Me.dtgLiberacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLiberacoes.ResumeLayout(False)
        Me.gbLiberacoes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public objProgramas_Implem As Programas_Implem = ProgramasBOFactory.GetFactory().GetInstance()
    Public objProgramasLiberacoes_Implem As ProgramasLiberacoes_Implem = ProgramasLiberacoesBOFactory.GetFactory().GetInstance()
    Public objUsuarios_Implem As Usuarios_Implem = UsuariosBOFactory.GetFactory().GetInstance()

#Region " Inicializações "

    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtPesquisa.Focus()
    End Sub

    Private Sub Programas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim autoriza As Boolean
        autoriza = VerificaPrograma("Programas", VariaveisGlobais.gSetorUsuario, _
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

            objVariaveisGlobais.PreencheComboBox(cbSetor, VariaveisGlobais.gConexao, _
               "SELECT Codigo, " & _
               "CAST(Nome AS VARCHAR)+' '+CAST(Codigo AS VARCHAR(3))AS Setor " & _
               "FROM C_Setores ORDER BY Nome ", "1")
            cbSetor.SelectedIndex = 0

            objVariaveisGlobais.PreencheComboBox(cbUsuarioCadastro, VariaveisGlobais.gConexao, _
                      " SELECT CodigoUsuario, " & _
                      " CAST(Nome AS VARCHAR) Nome " & _
                      " FROM C_Usuarios " & _
                      " WHERE CodigoUsuario is not null " & _
                      " ORDER BY Nome ", "")
            cbUsuarioCadastro.SelectedIndex = 0

            objVariaveisGlobais.PreencheComboBox(cbUsuarioCadastroLiberacao, VariaveisGlobais.gConexao, _
                      " SELECT CodigoUsuario, " & _
                      " CAST(Nome AS VARCHAR) Nome " & _
                      " FROM C_Usuarios " & _
                      " WHERE CodigoUsuario is not null " & _
                      " ORDER BY Nome ", "")
            cbUsuarioCadastroLiberacao.SelectedIndex = 0


            Dim c As New System.Web.UI.WebControls.ListItem
            c.Value = "" : c.Text = " Selecione ..." : cbTipoUsuario.Items.Add(c)
            c = New System.Web.UI.WebControls.ListItem
            c.Value = "S" : c.Text = "Supervisor" : cbTipoUsuario.Items.Add(c)
            c = New System.Web.UI.WebControls.ListItem
            c.Value = "U" : c.Text = "Usuario" : cbTipoUsuario.Items.Add(c)
            cbTipoUsuario.SelectedIndex = 0

            c = New System.Web.UI.WebControls.ListItem
            c.Value = "" : c.Text = "Sim" : cbIncluir.Items.Add(c)
            c = New System.Web.UI.WebControls.ListItem
            c.Value = "N" : c.Text = "Não" : cbIncluir.Items.Add(c)
            cbIncluir.SelectedIndex = 0

            c = New System.Web.UI.WebControls.ListItem
            c.Value = "" : c.Text = "Sim" : cbAlterar.Items.Add(c)
            c = New System.Web.UI.WebControls.ListItem
            c.Value = "N" : c.Text = "Não" : cbAlterar.Items.Add(c)
            cbAlterar.SelectedIndex = 0

            c = New System.Web.UI.WebControls.ListItem
            c.Value = "" : c.Text = "Sim" : cbExcluir.Items.Add(c)
            c = New System.Web.UI.WebControls.ListItem
            c.Value = "N" : c.Text = "Não" : cbExcluir.Items.Add(c)
            cbExcluir.SelectedIndex = 0

            LimpaTela()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub CadastroProgramas_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        objProgramas_Implem = Nothing
        LimpaErros()
    End Sub

    Private Sub Programas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F1 Then
            objLeituras.VerC_LOG(VariaveisGlobais.gBD, "C_LOG", "C_Programas", txtPrograma.Text)
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

#Region " Adicionar/Alterar /Excluir Programa "

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        LimpaTela(True)
    End Sub

    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click
        AdicionarProgramas()
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

    Public Function GuardaDadosProgramas() As Integer
        Try
            objProgramas_Implem.Programa = Replace(txtPrograma.Text, "'", "''")
            objProgramas_Implem.Descricao = Replace(txtDescricao.Text, "'", "''")
            objProgramas_Implem.DataCadastro = Replace(txtDataCadastro.Text, "'", "''")
            objProgramas_Implem.UsuarioCadastro = cbUsuarioCadastro.SelectedItem.value

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Sub TelaAlteracaoProgramas()
        Try
            Dim wControle As Integer

            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Me.Close()
            End If

            txtPrograma.Text = objProgramas_Implem.Programa
            txtDescricao.Text = objProgramas_Implem.Descricao
            txtDataCadastro.Text = ConverteDataHoraParaString(objProgramas_Implem.DataCadastro)
            objVariaveisGlobais.SetaComboBox(cbUsuarioCadastro, objProgramas_Implem.UsuarioCadastro)

            btExcluir.Enabled = vExcluir
            btAlterar.Enabled = vAlterar
            btAdicionar.Enabled = False
            btNovo.Enabled = False
            btLimpar.Enabled = True
            TabControl1.SelectedIndex = 1
            tpManutencao.Enabled = True

            gbLiberacoes.Enabled = True
            LimpaTelaLiberacao()

            Windows.Forms.Cursor.Current = Cursors.Default

            txtPrograma.Focus() : txtPrograma.SelectionLength = 0

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Me.Close()
        End Try

    End Sub

    Public Sub AdicionarProgramas()
        Try

            Dim wControle As Integer
            wControle = ValidaDados()
            If wControle <> 0 Then Exit Sub

            GuardaDadosProgramas()
            wControle = objProgramas_Implem.IncluirPrograma()
            If wControle = 1 Then
                MessageBox.Show("Já existe um Programa cadastrado com este Codigo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Programa incluído com sucesso! Numero: " & _
                        objProgramas_Implem.Programa, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

            wControle = GuardaDadosProgramas()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If

            wControle = objProgramas_Implem.AlterarPrograma()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Dados do Programa modificados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'LimpaTela()

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

        wMensagem = MessageBox.Show("TODOS Dados relacionados a esse Programa serão permanentemente excluídos!" & vbCrLf & " Você deseja excluir este Programa? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If (wMensagem = Windows.Forms.DialogResult.Yes) Then
            objProgramas_Implem.Programa = txtPrograma.Text
            wControle = objProgramas_Implem.ExcluirPrograma()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Programa excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LimpaTela()

    End Sub

#End Region

#Region " Atualização do DataGrid e do Form "

    Private Sub AtualizaProgramas()

        Dim wControle As Integer

        Dim wSQL As String = " SELECT   Nome " & _
                " FROM C_Programas " & _
                " WHERE DataExclusao is null " & _
                " ORDER BY Nome   "

        wControle = objProgramas_Implem.MostraTabelaProgramas(dtgProgramas, wSQL)
        If wControle <> 0 Then objVariaveisGlobais.MostraErro()
        PreencheCampoPesquisa()
        FazFiltro()

    End Sub

    Private Sub PreencheCampoPesquisa()
        If cbCampo.Items.Count = 0 Then
            Dim c As New System.Web.UI.WebControls.ListItem
            For i As Integer = 0 To dtgProgramas.Columns.Count - 1
                If dtgProgramas.Columns(i).ValueType.ToString = GetType(String).ToString AndAlso dtgProgramas.Columns(i).Visible = True Then
                    c = New System.Web.UI.WebControls.ListItem
                    c.Value = dtgProgramas.Columns(i).HeaderText
                    c.Text = dtgProgramas.Columns(i).HeaderText
                    cbCampo.Items.Add(c)
                End If
            Next
            cbCampo.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtPesquisaNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.TextChanged
        FazFiltro()
    End Sub

    Private Sub cbProgramasPesquisaEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCampo.SelectedIndexChanged
        FazFiltro()
    End Sub

    Private Sub SELECAO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles rbExato.CheckedChanged, rbComecarPor.CheckedChanged, rbConter.CheckedChanged
        FazFiltro()
    End Sub

    Function FazFiltro()
        If Not IsNothing(dtgProgramas.DataSource) Then
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
            For i As Integer = 0 To dtgProgramas.Columns.Count - 1
                If dtgProgramas.Columns(i).Name = cbCampo.Text Then
                    wValida = True
                    Exit For
                End If
            Next

            If wValida = False Then
                MsgBox("Campo pesquisa está incorreto")
                Return wValida
            End If

            wDataTable = objProgramas_Implem.wDataSet.Tables(0)
            Dim wDataView = New DataView(wDataTable, _
                     wPesquisa, _
                     "", DataViewRowState.CurrentRows)
            dtgProgramas.DataSource = wDataView
        End If
        Return True
    End Function

    Private Sub dtgProgramas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgProgramas.MouseMove
        Try
            Dim hti As System.Windows.Forms.DataGridView.HitTestInfo
            hti = dtgProgramas.HitTest(e.X, e.Y)

            If hti.Type = System.Windows.Forms.DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 1 Then
                    Me.Cursor = System.Windows.Forms.Cursors.Hand
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand
                Else
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                End If
                If hti.ColumnIndex = 1 Then
                    ToolTip1.SetToolTip(dtgProgramas, "")
                End If
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                ToolTip1.SetToolTip(dtgProgramas, "")
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgProgramas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgProgramas.MouseUp
        Try
            Dim wControle As Integer
            Dim hti As DataGridView.HitTestInfo = dtgProgramas.HitTest(e.X, e.Y)

            If hti.Type = DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 1 Then
                    objProgramas_Implem.Programa = dtgProgramas.Item(0, hti.RowIndex).Value
                    wControle = objProgramas_Implem.BuscarPrograma
                    If wControle <> 0 Then
                        objVariaveisGlobais.MostraErro()
                        Exit Sub
                    End If
                    TelaAlteracaoProgramas()
                End If
            End If

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

        txtPrograma.Text = ""
        txtDescricao.Text = ""
        txtDataCadastro.Text = ConverteDataHoraParaString(Date.Now)
        objVariaveisGlobais.SetaComboBox(cbUsuarioCadastro, VariaveisGlobais.gCodigoUsuario)

        LimpaTelaLiberacao()
        gbLiberacoes.Enabled = False

        btAlterar.Enabled = False
        btExcluir.Enabled = False

        If wNovoRegistro = False Then
            AtualizaProgramas()
            btNovo.Enabled = True
            btAdicionar.Enabled = False
            btLimpar.Enabled = False
            TabControl1.SelectedIndex = 0
            tpManutencao.Enabled = False
            txtPesquisa.Focus()
            txtPrograma.Enabled = False
        Else
            btAdicionar.Enabled = vIncluir
            btLimpar.Enabled = True
            btNovo.Enabled = False
            TabControl1.SelectedIndex = 1
            tpManutencao.Enabled = True
            txtPrograma.Enabled = True
            txtPrograma.Focus()
        End If

        LimpaErros()

    End Sub

    Private Sub btLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLimpar.Click
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

        txtPrograma.Focus()
        btLimpar.Focus()

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

        ErrorProvider1.SetError(txtPrograma, "")
        ErrorProvider1.SetError(cbSetor, "")
        ErrorProvider1.SetError(cbTipoUsuario, "")
        ErrorProvider1.SetError(txtUsuario, "")

        objVariaveisGlobais.InicializaVetorErros()

    End Sub

    Private Sub txtPrograma_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPrograma.Validating

        Dim wMsgErro As String = "Digite o Codigo do Programa!"

        If txtPrograma.Text = "" Then
            ErrorProvider1.SetError(txtPrograma, wMsgErro)
            VariaveisGlobais.gErroTela(0) = wMsgErro
        Else
            ErrorProvider1.SetError(txtPrograma, "")
            VariaveisGlobais.gErroTela(0) = ""
        End If
    End Sub

#End Region

#Region "LIBERACOES"

#Region " Adicionar/Alterar /Excluir Programa "


    Private Sub btAdicionarLiberacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionarLiberacao.Click
        AdicionarProgramasLiberacao()
    End Sub

    Private Sub btAlterarLiberacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAlterarLiberacao.Click
        AlterarLiberacao()
    End Sub

    Private Sub btExcluirLiberacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluirLiberacao.Click
        ExcluirLiberacao()
    End Sub

    Public Function GuardaDadosProgramasLiberacao() As Integer
        Try
            objProgramasLiberacoes_Implem.NomePrograma = txtPrograma.Text
            objProgramasLiberacoes_Implem.Setor = cbSetor.SelectedItem.Value
            objProgramasLiberacoes_Implem.TipoUsuario = cbTipoUsuario.SelectedItem.Value
            objProgramasLiberacoes_Implem.Usuario = txtUsuario.Text
            objProgramasLiberacoes_Implem.Incluir = cbIncluir.SelectedItem.Value
            objProgramasLiberacoes_Implem.Alterar = cbAlterar.SelectedItem.Value
            objProgramasLiberacoes_Implem.Excluir = cbExcluir.SelectedItem.Value
            objProgramasLiberacoes_Implem.UsuarioCadastro = cbUsuarioCadastroLiberacao.SelectedItem.value

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Sub TelaAlteracaoProgramasLiberacao()
        Try
            Dim wControle As Integer

            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Me.Close()
            End If

            objVariaveisGlobais.SetaComboBox(cbTipoUsuario, objProgramasLiberacoes_Implem.TipoUsuario)
            objVariaveisGlobais.SetaComboBox(cbSetor, objProgramasLiberacoes_Implem.Setor)
            txtUsuario.Text = objProgramasLiberacoes_Implem.Usuario
            objVariaveisGlobais.SetaComboBox(cbIncluir, objProgramasLiberacoes_Implem.Incluir)
            objVariaveisGlobais.SetaComboBox(cbAlterar, objProgramasLiberacoes_Implem.Alterar)
            objVariaveisGlobais.SetaComboBox(cbExcluir, objProgramasLiberacoes_Implem.Excluir)
            objVariaveisGlobais.SetaComboBox(cbUsuarioCadastroLiberacao, objProgramasLiberacoes_Implem.UsuarioCadastro)

            txtDataCadastroLiberacao.Text = ConverteDataHoraParaString(objProgramasLiberacoes_Implem.DataCadastro)

            btExcluirLiberacao.Enabled = vExcluir
            btAlterarLiberacao.Enabled = vAlterar
            btAdicionarLiberacao.Enabled = False
            cbSetor.Enabled = False
            cbTipoUsuario.Enabled = False
            txtUsuario.Enabled = False

            Windows.Forms.Cursor.Current = Cursors.Default

            cbIncluir.Focus()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Me.Close()
        End Try

    End Sub

    Public Sub AdicionarProgramasLiberacao()
        Try

            Dim wControle As Integer
            wControle = ValidaDados()
            If wControle <> 0 Then Exit Sub

            GuardaDadosProgramasLiberacao()
            wControle = objProgramasLiberacoes_Implem.IncluirProgramaLiberacao()
            If wControle = 1 Then
                MessageBox.Show("Já existe um Registro com estes Dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Liberacao incluída com sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpaTelaLiberacao()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Public Sub AlterarLiberacao()
        Dim wControle As Integer
        Try

            wControle = ValidaDadosLiberacao()
            If wControle < 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            If wControle <> 0 Then Exit Sub

            wControle = GuardaDadosProgramasLiberacao()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If

            wControle = objProgramasLiberacoes_Implem.AlterarProgramaLiberacao()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Dados modificados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpaTelaLiberacao()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try

    End Sub

    Private Sub ExcluirLiberacao()
        Dim wMensagem As DialogResult
        Dim wControle As Integer

        wMensagem = MessageBox.Show("TODOS Dados relacionados a essa Liberacao serão permanentemente excluídos!" & vbCrLf & " Você deseja excluir este Programa? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If (wMensagem = Windows.Forms.DialogResult.Yes) Then
            objProgramasLiberacoes_Implem.NomePrograma = txtPrograma.Text
            objProgramasLiberacoes_Implem.Setor = cbSetor.SelectedItem.value
            objProgramasLiberacoes_Implem.TipoUsuario = cbTipoUsuario.SelectedItem.value
            objProgramasLiberacoes_Implem.Usuario = txtUsuario.Text
            wControle = objProgramasLiberacoes_Implem.ExcluirProgramaLiberacao
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Liberacao excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LimpaTelaLiberacao()

    End Sub

#End Region

#Region " Atualização do DataGrid Liberacao "

    Private Sub AtualizaProgramasLiberacao()

        Dim wControle As Integer

        Dim wSQL As String = _
              " SELECT  CodigoSetor, Nome, TipoUsuario, " & _
              " P.Usuario, isnull(Incluir,'S'),isnull(Alterar,'S'),isnull(Excluir,'S') " & _
              " FROM C_ProgramasLiberacoes P , C_Setores S " & _
              " WHERE NomePrograma = '" & txtPrograma.Text & "' " & _
              " AND CodigoSetor = Codigo " & _
              " AND isnull(P.DataExclusao,'') = '' " & _
              " Order By CodigoSetor, TipoUsuario "

        wControle = objProgramasLiberacoes_Implem.MostraTabelaProgramasLiberacoes(dtgLiberacoes, wSQL)
        If wControle <> 0 Then objVariaveisGlobais.MostraErro()

    End Sub

    Private Sub dtgLiberacoes_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgLiberacoes.MouseMove
        Try
            Dim hti As System.Windows.Forms.DataGridView.HitTestInfo
            hti = dtgLiberacoes.HitTest(e.X, e.Y)

            If hti.Type = System.Windows.Forms.DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 7 Then
                    Me.Cursor = System.Windows.Forms.Cursors.Hand
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand
                Else
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                End If
                If hti.ColumnIndex = 7 Then
                    ToolTip1.SetToolTip(dtgLiberacoes, "")
                End If
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                ToolTip1.SetToolTip(dtgLiberacoes, "")
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgLiberacoes_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgLiberacoes.MouseUp
        Try
            Dim wControle As Integer
            Dim hti As DataGridView.HitTestInfo = dtgLiberacoes.HitTest(e.X, e.Y)

            If hti.Type = DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 7 Then
                    objProgramasLiberacoes_Implem.NomePrograma = txtPrograma.Text
                    objProgramasLiberacoes_Implem.Setor = dtgLiberacoes.Item(0, hti.RowIndex).Value
                    objProgramasLiberacoes_Implem.TipoUsuario = dtgLiberacoes.Item(2, hti.RowIndex).Value
                    objProgramasLiberacoes_Implem.Usuario = dtgLiberacoes.Item(3, hti.RowIndex).Value

                    wControle = objProgramasLiberacoes_Implem.BuscarProgramaLiberacao
                    If wControle <> 0 Then
                        objVariaveisGlobais.MostraErro()
                        Exit Sub
                    End If
                    TelaAlteracaoProgramasLiberacao()
                End If
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

#End Region

#Region " Limpeza da tela "

    Sub LimpaTelaLiberacao()

        cbSetor.SelectedIndex = 0
        cbTipoUsuario.SelectedIndex = 0
        cbIncluir.SelectedIndex = 0
        cbAlterar.SelectedIndex = 0
        cbExcluir.SelectedIndex = 0
        txtUsuario.Text = ""
        txtDataCadastroLiberacao.Text = ConverteDataHoraParaString(Date.Now)
        objVariaveisGlobais.SetaComboBox(cbUsuarioCadastroLiberacao, VariaveisGlobais.gLoginUsuario)

        btAlterarLiberacao.Enabled = False
        btExcluirLiberacao.Enabled = False
        btAdicionarLiberacao.Enabled = vIncluir

        AtualizaProgramasLiberacao()
        cbSetor.Enabled = True
        cbTipoUsuario.Enabled = True
        txtUsuario.Enabled = True

        LimpaErros()

    End Sub

    Private Sub btLimparLiberacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLimparLiberacao.Click
        LimpaTelaLiberacao()
    End Sub

#End Region

#Region " Valida da tela "

    Private Function ValidaDadosLiberacao()
        LimpaErros()
        Dim f As Integer
        Dim wErros As String = ""
        Dim wFoco As Integer = -1

        cbSetor.Focus()
        cbTipoUsuario.Focus()
        txtUsuario.Focus()
        cbSetor.Focus()

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

    Private Sub cbSetor_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbSetor.Validating
        Dim wMsgErro As String = ""
        Try
            If (cbSetor.SelectedIndex = 0 And txtUsuario.Text = "") OrElse _
                (cbSetor.SelectedIndex <> 0 And txtUsuario.Text <> "") Then
                wMsgErro = "Selecione um Setor  (OU)  Informe o Usuário ! "
            End If

            If wMsgErro <> "" Then
                ErrorProvider1.SetError(cbSetor, wMsgErro)
                VariaveisGlobais.gErroTela(32) = wMsgErro
            Else
                ErrorProvider1.SetError(cbSetor, "")
                VariaveisGlobais.gErroTela(32) = ""
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub cbTipoUsuario_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTipoUsuario.Validating
        Dim wMsgErro As String = ""
        Try
            If (cbTipoUsuario.SelectedIndex = 0 And txtUsuario.Text = "") OrElse _
                (cbTipoUsuario.SelectedIndex <> 0 And txtUsuario.Text <> "") Then
                wMsgErro = "Selecione um Tipo Usuario (OU) Informe o Usuário ! "
            End If

            If wMsgErro <> "" Then
                ErrorProvider1.SetError(cbTipoUsuario, wMsgErro)
                VariaveisGlobais.gErroTela(33) = wMsgErro
            Else
                ErrorProvider1.SetError(cbTipoUsuario, "")
                VariaveisGlobais.gErroTela(33) = ""
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub txtUsuario_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUsuario.Validating
        Dim wMsgErro As String = ""
        Dim wControle As Integer
        Try
            If (cbTipoUsuario.SelectedIndex = 0 And txtUsuario.Text = "") OrElse _
                (cbTipoUsuario.SelectedIndex <> 0 And txtUsuario.Text <> "") Then
                wMsgErro = "Selecione um Tipo Usuario ou Informe o Usuário!"
            ElseIf cbTipoUsuario.SelectedIndex = 0 And cbSetor.SelectedIndex = 0 Then
                objUsuarios_Implem.Login = txtUsuario.Text
                wControle = objUsuarios_Implem.VerificaExistenciaUsuario
                If wControle > 0 Then
                    wMsgErro = "Usuário Inválido, não existe!"
                ElseIf wControle < 0 Then
                    objVariaveisGlobais.MostraErro()
                End If
            End If

            If wMsgErro <> "" Then
                ErrorProvider1.SetError(txtUsuario, wMsgErro)
                VariaveisGlobais.gErroTela(34) = wMsgErro
            Else
                ErrorProvider1.SetError(txtUsuario, "")
                VariaveisGlobais.gErroTela(34) = ""
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub


#End Region


#End Region

#Region " Impressao "

#Region " Variaveis de Impressao "

    Dim wAlturaPapel As Integer
    Dim sdb As System.Drawing.Brush

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
        TotalRecords = dtgProgramas.RowCount

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

            Nome = dtgProgramas.Item(0, i).Value


            e.Graphics.DrawString(Nome, printFont, sdb, 80, yPos)
        Next
        yPos += 20
        e.Graphics.DrawString("Total: " & TotalRecords, printFontB, sdb, 20, yPos)

        mpreview = False
    End Sub

    Private Sub MontaCabecalho(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        e.Graphics.DrawString(VariaveisGlobais.gNomeEmpresaUsuario, printFont1, sdb, 390, 25, dFac)
        e.Graphics.DrawString("Relatório de Programas", printFontB, sdb, 390, 55, dFac)
        e.Graphics.DrawImage(Drawing.Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "Application.ico"), _
         10, 10, 50, 50)

        e.Graphics.DrawString("Nome do Programa", printFontB, sdb, 80, 120)

        e.Graphics.DrawString("Emitido em " & ConverteDataParaString(Date.Now) & _
        " por " & VariaveisGlobais.gNomeUsuario & " - Pág " & pagina, printFontP, Brushes.Black, 780, wAlturaPapel - 80, dFrl)

    End Sub

#End Region

    
End Class