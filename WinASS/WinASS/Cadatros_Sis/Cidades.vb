Public Class Cidades
    Inherits System.Windows.Forms.Form
    Private vIncluir As Boolean
    Private vAlterar As Boolean
    Private vExcluir As Boolean
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbUsuarioCadastro As FzComboBox.FzCombobox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDataCadastro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCodigoCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpConsulta As System.Windows.Forms.TabPage
    Friend WithEvents tpManutencao As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbConter As System.Windows.Forms.RadioButton
    Friend WithEvents rbComecarPor As System.Windows.Forms.RadioButton
    Friend WithEvents rbExato As System.Windows.Forms.RadioButton
    Friend WithEvents dtgCidades As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents btVisualizar As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btNovo As System.Windows.Forms.Button
    Friend WithEvents cbSiglaEstado As FzComboBox.FzCombobox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbTipo As System.Windows.Forms.Label
    Friend WithEvents txtNomeCidade As System.Windows.Forms.TextBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cidades))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gpDados = New System.Windows.Forms.GroupBox
        Me.btConfirmaSelecao = New System.Windows.Forms.Button
        Me.txtCodigoCidade = New System.Windows.Forms.TextBox
        Me.btCancelaSelecao = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDataCadastro = New System.Windows.Forms.MaskedTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbUsuarioCadastro = New FzComboBox.FzCombobox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbSiglaEstado = New FzComboBox.FzCombobox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbTipo = New System.Windows.Forms.Label
        Me.txtNomeCidade = New System.Windows.Forms.TextBox
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
        Me.dtgCidades = New System.Windows.Forms.DataGridView
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
        CType(Me.dtgCidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpManutencao.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpDados
        '
        Me.gpDados.Controls.Add(Me.btConfirmaSelecao)
        Me.gpDados.Controls.Add(Me.txtCodigoCidade)
        Me.gpDados.Controls.Add(Me.btCancelaSelecao)
        Me.gpDados.Controls.Add(Me.Label11)
        Me.gpDados.Controls.Add(Me.txtDataCadastro)
        Me.gpDados.Controls.Add(Me.Label6)
        Me.gpDados.Controls.Add(Me.cbUsuarioCadastro)
        Me.gpDados.Controls.Add(Me.Label3)
        Me.gpDados.Controls.Add(Me.cbSiglaEstado)
        Me.gpDados.Controls.Add(Me.Label7)
        Me.gpDados.Controls.Add(Me.lbTipo)
        Me.gpDados.Controls.Add(Me.txtNomeCidade)
        Me.gpDados.Location = New System.Drawing.Point(96, 67)
        Me.gpDados.Name = "gpDados"
        Me.gpDados.Size = New System.Drawing.Size(568, 218)
        Me.gpDados.TabIndex = 0
        Me.gpDados.TabStop = False
        Me.gpDados.Text = "Informa��es da Cidade"
        '
        'btConfirmaSelecao
        '
        Me.btConfirmaSelecao.BackColor = System.Drawing.SystemColors.Control
        Me.btConfirmaSelecao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btConfirmaSelecao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConfirmaSelecao.Image = CType(resources.GetObject("btConfirmaSelecao.Image"), System.Drawing.Image)
        Me.btConfirmaSelecao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btConfirmaSelecao.Location = New System.Drawing.Point(408, 182)
        Me.btConfirmaSelecao.Name = "btConfirmaSelecao"
        Me.btConfirmaSelecao.Size = New System.Drawing.Size(74, 22)
        Me.btConfirmaSelecao.TabIndex = 10
        Me.btConfirmaSelecao.Text = "Confirma"
        Me.btConfirmaSelecao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btConfirmaSelecao.UseVisualStyleBackColor = False
        Me.btConfirmaSelecao.Visible = False
        '
        'txtCodigoCidade
        '
        Me.txtCodigoCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCidade.Location = New System.Drawing.Point(121, 32)
        Me.txtCodigoCidade.MaxLength = 50
        Me.txtCodigoCidade.Name = "txtCodigoCidade"
        Me.txtCodigoCidade.ReadOnly = True
        Me.txtCodigoCidade.Size = New System.Drawing.Size(76, 20)
        Me.txtCodigoCidade.TabIndex = 1
        '
        'btCancelaSelecao
        '
        Me.btCancelaSelecao.BackColor = System.Drawing.SystemColors.Control
        Me.btCancelaSelecao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelaSelecao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelaSelecao.Image = CType(resources.GetObject("btCancelaSelecao.Image"), System.Drawing.Image)
        Me.btCancelaSelecao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCancelaSelecao.Location = New System.Drawing.Point(488, 182)
        Me.btCancelaSelecao.Name = "btCancelaSelecao"
        Me.btCancelaSelecao.Size = New System.Drawing.Size(74, 22)
        Me.btCancelaSelecao.TabIndex = 11
        Me.btCancelaSelecao.Text = "Cancela"
        Me.btCancelaSelecao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancelaSelecao.UseVisualStyleBackColor = False
        Me.btCancelaSelecao.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "C�digo Cidade"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.Enabled = False
        Me.txtDataCadastro.Location = New System.Drawing.Point(121, 156)
        Me.txtDataCadastro.Mask = "00/00/0000 90:00"
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.txtDataCadastro.Size = New System.Drawing.Size(132, 20)
        Me.txtDataCadastro.TabIndex = 7
        Me.txtDataCadastro.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Data Cadastro"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbUsuarioCadastro
        '
        Me.cbUsuarioCadastro.Enabled = False
        Me.cbUsuarioCadastro.Location = New System.Drawing.Point(121, 180)
        Me.cbUsuarioCadastro.Name = "cbUsuarioCadastro"
        Me.cbUsuarioCadastro.Size = New System.Drawing.Size(132, 22)
        Me.cbUsuarioCadastro.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Usu�rio Cadastro"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbSiglaEstado
        '
        Me.cbSiglaEstado.Location = New System.Drawing.Point(121, 86)
        Me.cbSiglaEstado.Name = "cbSiglaEstado"
        Me.cbSiglaEstado.Size = New System.Drawing.Size(76, 22)
        Me.cbSiglaEstado.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Sigla Estado"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTipo
        '
        Me.lbTipo.BackColor = System.Drawing.Color.Transparent
        Me.lbTipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbTipo.ForeColor = System.Drawing.Color.Black
        Me.lbTipo.Location = New System.Drawing.Point(16, 58)
        Me.lbTipo.Name = "lbTipo"
        Me.lbTipo.Size = New System.Drawing.Size(99, 20)
        Me.lbTipo.TabIndex = 2
        Me.lbTipo.Text = "Nome Cidade"
        Me.lbTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNomeCidade
        '
        Me.txtNomeCidade.Location = New System.Drawing.Point(120, 58)
        Me.txtNomeCidade.MaxLength = 20
        Me.txtNomeCidade.Name = "txtNomeCidade"
        Me.txtNomeCidade.Size = New System.Drawing.Size(224, 20)
        Me.txtNomeCidade.TabIndex = 3
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
        Me.GroupBox1.Text = "Sele��o"
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
        Me.rbComecarPor.Text = "Come�ar Por"
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
        Me.tpConsulta.Controls.Add(Me.dtgCidades)
        Me.tpConsulta.Controls.Add(Me.gbPesquisa)
        Me.tpConsulta.Location = New System.Drawing.Point(4, 23)
        Me.tpConsulta.Name = "tpConsulta"
        Me.tpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConsulta.Size = New System.Drawing.Size(757, 445)
        Me.tpConsulta.TabIndex = 0
        Me.tpConsulta.Text = "Consulta"
        Me.tpConsulta.UseVisualStyleBackColor = True
        '
        'dtgCidades
        '
        Me.dtgCidades.AllowUserToAddRows = False
        Me.dtgCidades.AllowUserToDeleteRows = False
        Me.dtgCidades.AllowUserToOrderColumns = True
        Me.dtgCidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgCidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtgCidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cm})
        Me.dtgCidades.Location = New System.Drawing.Point(7, 87)
        Me.dtgCidades.Name = "dtgCidades"
        Me.dtgCidades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCidades.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgCidades.Size = New System.Drawing.Size(744, 335)
        Me.dtgCidades.TabIndex = 1
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
        Me.tpManutencao.Text = "Manuten��o"
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
        'Cidades
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
        Me.Name = "Cidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Cidades"
        Me.gpDados.ResumeLayout(False)
        Me.gpDados.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPesquisa.ResumeLayout(False)
        Me.gbPesquisa.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpConsulta.ResumeLayout(False)
        CType(Me.dtgCidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpManutencao.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public objCidades_Implem As Cidades_Implem = CidadesBOFactory.GetFactory().GetInstance()

#Region " Inicializa��es "

    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtPesquisa.Focus()
    End Sub

    Private Sub Cidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim autoriza As Boolean
        autoriza = VerificaPrograma("Cidades", VariaveisGlobais.gSetorUsuario, _
            VariaveisGlobais.gTipoUsuario, VariaveisGlobais.gLoginUsuario)
        If autoriza = False Then
            MessageBox.Show("Usu�rio n�o Autorizado ! " & Me.Name)
            Me.Enabled = False
            Exit Sub
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

            objVariaveisGlobais.PreencheComboBox(cbSiglaEstado, VariaveisGlobais.gConexao, _
                         "SELECT SiglaEstado " & _
                         "FROM C_Estados ORDER BY SiglaEstado ", "")
            cbSiglaEstado.SelectedIndex = 0

            objVariaveisGlobais.PreencheComboBox(cbUsuarioCadastro, VariaveisGlobais.gConexao, _
                      " SELECT Id_Usuario, " & _
                      " CAST(Nome AS VARCHAR) Nome " & _
                      " FROM C_Usuarios " & _
                      " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
                      " ORDER BY Nome ", "")
            cbUsuarioCadastro.SelectedIndex = 0

            LimpaTela()

            If vSelecao <> "" Then
                btCancelaSelecao.Visible = True
                btConfirmaSelecao.Visible = True
                objVariaveisGlobais.SetaComboBox(cbCampo, vSelecao)
                If dtgCidades.Rows.Count = 1 Then
                    dtgCidades.Rows(0).Selected = True
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

    Private Sub CadastroCidades_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        objCidades_Implem = Nothing
        LimpaErros()
    End Sub

    Private Sub Cidades_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F1 Then
            objLeituras.VerC_LOG(VariaveisGlobais.gBD, "C_LOG", "C_Cidades", txtCodigoCidade.Text)
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
        If e.KeyCode = Keys.Enter And dtgCidades.Focused Then
            TelaAlteracaoCidades()
            If btConfirmaSelecao.Visible = True Then
                Me.Dispose()
            Else
            End If
        End If
        If e.KeyCode = Keys.Down And txtPesquisa.Focused Then
            dtgCidades.Focus()
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

#Region " Adicionar/Alterar /Excluir Usuario "

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        LimpaTela(True)
    End Sub

    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click
        AdicionarCidades()
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

    Public Function GuardaDadosCidades() As Integer
        Try

            objCidades_Implem.NomeCidade = Replace(txtNomeCidade.Text, "'", "''")
            objCidades_Implem.SiglaEstado = cbSiglaEstado.SelectedItem.Value

            objCidades_Implem.DataCadastro = txtDataCadastro.Text
            objCidades_Implem.UsuarioCadastro = cbUsuarioCadastro.SelectedItem.value

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Sub TelaAlteracaoCidades()
        Try
            Dim wControle As Integer
            LimpaErros()

            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Me.Close()
            End If

            txtCodigoCidade.Text = objCidades_Implem.CodigoCidade
            txtNomeCidade.Text = objCidades_Implem.NomeCidade
            objVariaveisGlobais.SetaComboBox(cbSiglaEstado, objCidades_Implem.SiglaEstado)

            txtDataCadastro.Text = ConverteDataHoraParaString(objCidades_Implem.DataCadastro)
            objVariaveisGlobais.SetaComboBox(cbUsuarioCadastro, objCidades_Implem.UsuarioCadastro)

            btExcluir.Enabled = vExcluir
            btAlterar.Enabled = vAlterar
            btAdicionar.Enabled = False
            btNovo.Enabled = False
            btLimpar.Enabled = True
            TabControl1.SelectedIndex = 1
            tpManutencao.Enabled = True

            Windows.Forms.Cursor.Current = Cursors.Default

            txtNomeCidade.Focus() : txtNomeCidade.SelectionLength = 0

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Me.Close()
        End Try
    End Sub

    Public Sub AdicionarCidades()
        Try

            Dim wControle As Integer
            wControle = ValidaDados()
            If wControle <> 0 Then Exit Sub

            GuardaDadosCidades()
            wControle = objCidades_Implem.IncluirCidade
            If wControle = 1 Then
                MessageBox.Show("J� existe uma Cidade cadastrada com este Codigo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Cidade inclu�da com sucesso! Numero: " & _
                        objCidades_Implem.CodigoCidade, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

            wControle = GuardaDadosCidades()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If

            wControle = objCidades_Implem.AlterarCidade()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Dados da Cidade modificados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

        wMensagem = MessageBox.Show("TODOS Dados relacionados a essa Cidade ser�o permanentemente exclu�dos!" & vbCrLf & " Voc� deseja excluir esta Cidade? ", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If (wMensagem = Windows.Forms.DialogResult.Yes) Then
            objCidades_Implem.CodigoCidade = txtCodigoCidade.Text
            wControle = objCidades_Implem.ExcluirCidade()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Cidade exclu�da com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LimpaTela()

    End Sub

#End Region

#Region " Atualiza��o do DataGrid e do Form "

    Private Sub AtualizaCidades()

        Dim wControle As Integer

        Dim wSQL As String = " SELECT CodigoCidade, NomeCidade, SiglaEstado " & _
                             " FROM C_Cidades " & _
                             " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
                             " ORDER BY NomeCidade   "

        wControle = objCidades_Implem.MostraTabelaCidades(dtgCidades, wSQL)
        If wControle <> 0 Then objVariaveisGlobais.MostraErro()
        PreencheCampoPesquisa()
        FazFiltro()

    End Sub

    Private Sub PreencheCampoPesquisa()
        If cbCampo.Items.Count = 0 Then
            Dim c As New System.Web.UI.WebControls.ListItem
            For i As Integer = 0 To dtgCidades.Columns.Count - 1
                If dtgCidades.Columns(i).ValueType.ToString = GetType(String).ToString AndAlso dtgCidades.Columns(i).Visible = True Then
                    c = New System.Web.UI.WebControls.ListItem
                    c.Value = dtgCidades.Columns(i).HeaderText
                    c.Text = dtgCidades.Columns(i).HeaderText
                    cbCampo.Items.Add(c)
                End If
            Next
            cbCampo.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtPesquisaNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.TextChanged
        FazFiltro()
    End Sub

    Private Sub cbCidadesPesquisaEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCampo.SelectedIndexChanged
        FazFiltro()
    End Sub

    Private Sub SELECAO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles rbExato.CheckedChanged, rbComecarPor.CheckedChanged, rbConter.CheckedChanged
        FazFiltro()
    End Sub

    Function FazFiltro()
        If Not IsNothing(dtgCidades.DataSource) Then
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
            For i As Integer = 0 To dtgCidades.Columns.Count - 1
                If dtgCidades.Columns(i).Name = cbCampo.Text Then
                    wValida = True
                    Exit For
                End If
            Next

            If wValida = False Then
                MsgBox("Campo pesquisa est� incorreto")
                Return wValida
            End If

            wDataTable = objCidades_Implem.wDataSet.Tables(0)
            Dim wDataView = New DataView(wDataTable, _
                     wPesquisa, _
                     "", DataViewRowState.CurrentRows)
            dtgCidades.DataSource = wDataView
        End If
        Return True
    End Function

    Private Sub dtgCidades_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgCidades.MouseMove
        Try
            Dim hti As System.Windows.Forms.DataGridView.HitTestInfo
            hti = dtgCidades.HitTest(e.X, e.Y)

            If hti.Type = System.Windows.Forms.DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 3 Then
                    Me.Cursor = System.Windows.Forms.Cursors.Hand
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand
                Else
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                End If
                If hti.ColumnIndex = 3 Then
                    ToolTip1.SetToolTip(dtgCidades, "")
                End If
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                ToolTip1.SetToolTip(dtgCidades, "")
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgCidades_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgCidades.MouseUp
        Try
            Dim hti As DataGridView.HitTestInfo = dtgCidades.HitTest(e.X, e.Y)

            If hti.Type = DataGrid.HitTestType.Cell Then
                If hti.ColumnIndex = 3 Then
                    TelaAlteracaoCidades()
                End If
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgCidades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgCidades.CurrentCellChanged
        Try
            Dim wControle As Integer
            If IsNothing(dtgCidades.DataSource) Or IsNothing(dtgCidades.CurrentCell) Then Exit Sub

            objCidades_Implem.CodigoCidade = dtgCidades.Item(0, dtgCidades.CurrentCell().RowIndex).Value
            wControle = objCidades_Implem.BuscarCidade
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            dtgCidades.Rows(dtgCidades.CurrentCell().RowIndex).Selected = True
            dtgCidades.Focus()
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

        txtCodigoCidade.Text = ""
        txtNomeCidade.Text = ""
        cbSiglaEstado.SelectedIndex = 0

        txtDataCadastro.Text = ConverteDataHoraParaString(Date.Now)
        objVariaveisGlobais.SetaComboBox(cbUsuarioCadastro, VariaveisGlobais.gCodigoUsuario)

        btAlterar.Enabled = False
        btExcluir.Enabled = False

        If wNovoRegistro = False Then
            AtualizaCidades()
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
            txtNomeCidade.Focus()
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

        cbSiglaEstado.Focus()
        txtNomeCidade.Focus()

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

        ErrorProvider1.SetError(txtNomeCidade, "")
        ErrorProvider1.SetError(cbSiglaEstado, "")

        objVariaveisGlobais.InicializaVetorErros()

    End Sub

    Private Sub txtNomeCidade_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNomeCidade.Validating

        Dim wMsgErro As String = "Digite o nome da Cidade!"

        If txtNomeCidade.Text = "" Then
            ErrorProvider1.SetError(txtNomeCidade, wMsgErro)
            VariaveisGlobais.gErroTela(1) = wMsgErro
        Else
            ErrorProvider1.SetError(txtNomeCidade, "")
            VariaveisGlobais.gErroTela(1) = ""
        End If
    End Sub

    Private Sub cbSiglaEstado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbSiglaEstado.Validating

        Dim wMsgErro As String = "Selecione um Estado(UF)!"

        If cbSiglaEstado.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cbSiglaEstado, wMsgErro)
            VariaveisGlobais.gErroTela(2) = wMsgErro
        Else
            If cbSiglaEstado.SelectedItem.value = "" Then
                ErrorProvider1.SetError(cbSiglaEstado, wMsgErro)
                VariaveisGlobais.gErroTela(2) = wMsgErro
            Else
                ErrorProvider1.SetError(cbSiglaEstado, "")
                VariaveisGlobais.gErroTela(2) = ""
            End If
        End If
      
    End Sub

#End Region

#Region " Impressao "

#Region " Variaveis de Impressao "

    Dim wAlturaPapel As Integer
    Dim sdb As System.Drawing.Brush

    Dim Codigo As String
    Dim Nome_Cidade As String
    Dim SiglaEstado As String

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
        TotalRecords = dtgCidades.RowCount

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

            Codigo = dtgCidades.Item(0, i).Value
            Nome_Cidade = dtgCidades.Item(1, i).Value
            SiglaEstado = dtgCidades.Item(2, i).Value

            e.Graphics.DrawString(Codigo, printFont, sdb, 20, yPos)
            e.Graphics.DrawString(Mid(Nome_Cidade, 1, 32), printFont, sdb, 180, yPos)
            e.Graphics.DrawString(SiglaEstado, printFont, sdb, 440, yPos)
        Next
        yPos += 20
        e.Graphics.DrawString("Total: " & TotalRecords, printFontB, sdb, 20, yPos)

        mpreview = False
    End Sub

    Private Sub MontaCabecalho(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        'e.Graphics.DrawString(VariaveisGlobais.gNomeEmpresaUsuario, printFont1, sdb, 390, 25, dFac)
        e.Graphics.DrawString("Relat�rio de Cidades", printFontBB, sdb, 390, 55, dFac)
        e.Graphics.DrawImage(Drawing.Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "Application.ico"), _
         10, 10, 50, 50)

        e.Graphics.DrawString("C�digo", printFontB, sdb, 20, 120)
        e.Graphics.DrawString("Nome da Cidade", printFontB, sdb, 180, 120)
        e.Graphics.DrawString("UF", printFontB, sdb, 440, 120)

        e.Graphics.DrawString("Emitido em " & ConverteDataParaString(Date.Now) & _
        " por " & VariaveisGlobais.gNomeUsuario & " - P�g " & pagina, printFontP, Brushes.Black, 780, wAlturaPapel - 80, dFrl)

    End Sub

#End Region

End Class