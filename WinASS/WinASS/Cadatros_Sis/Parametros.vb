Public Class Parametros
    Inherits System.Windows.Forms.Form
    Private vIncluir As Boolean
    Private vAlterar As Boolean
    Private objFtpClient As FTPLib.FTP = New FTPLib.FTP
    Friend WithEvents pnlGeral As System.Windows.Forms.TabControl
    Friend WithEvents tpGeral As System.Windows.Forms.TabPage
    Friend WithEvents txtValor_Vermifugo As FzNumericBox.FzNumericBox
    Friend WithEvents txtValor_Bernicida As FzNumericBox.FzNumericBox
    Friend WithEvents txtValor_Fasciolicida As FzNumericBox.FzNumericBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValor_MaodeObra As FzNumericBox.FzNumericBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtValor_Beneficio_Languiru As FzNumericBox.FzNumericBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAssistencia_Languiru As FzNumericBox.FzNumericBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCodigos_Inseminacao As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCodigos_Animais As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSenhaServidor As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuarioServidor As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtCaminhoBackup As System.Windows.Forms.TextBox
    Friend WithEvents btBackupServidor As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btTestarConexao As System.Windows.Forms.Button
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtSenhaFTP As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioFTP As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtServidorFTP As System.Windows.Forms.TextBox
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btNovo As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btAlterar As System.Windows.Forms.Button
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents btFechar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parametros))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.btNovo = New System.Windows.Forms.Button
        Me.btAlterar = New System.Windows.Forms.Button
        Me.btLimpar = New System.Windows.Forms.Button
        Me.btFechar = New System.Windows.Forms.Button
        Me.tpGeral = New System.Windows.Forms.TabPage
        Me.txtCodigos_Animais = New System.Windows.Forms.TextBox
        Me.txtCodigos_Inseminacao = New System.Windows.Forms.TextBox
        Me.txtValor_Beneficio_Languiru = New FzNumericBox.FzNumericBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAssistencia_Languiru = New FzNumericBox.FzNumericBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtValor_MaodeObra = New FzNumericBox.FzNumericBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtValor_Vermifugo = New FzNumericBox.FzNumericBox
        Me.txtValor_Bernicida = New FzNumericBox.FzNumericBox
        Me.txtValor_Fasciolicida = New FzNumericBox.FzNumericBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlGeral = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtSenhaServidor = New System.Windows.Forms.TextBox
        Me.txtUsuarioServidor = New System.Windows.Forms.TextBox
        Me.txtCaminhoBackup = New System.Windows.Forms.TextBox
        Me.btBackupServidor = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btTestarConexao = New System.Windows.Forms.Button
        Me.Label48 = New System.Windows.Forms.Label
        Me.txtSenhaFTP = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.txtUsuarioFTP = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtServidorFTP = New System.Windows.Forms.TextBox
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpGeral.SuspendLayout()
        Me.pnlGeral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(17, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(350, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "8. Códigos Animais Com Benefício Serviços Languiru (Sep.p.virgula)"
        Me.ToolTip1.SetToolTip(Me.Label8, "Separar por vírgula(,)")
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(17, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(350, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "7. Códigos Tipo Serviço Inseminação (Sep.p.virgula)"
        Me.ToolTip1.SetToolTip(Me.Label7, "Separar por vírgula(,)")
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(11, 72)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(117, 14)
        Me.Label50.TabIndex = 5
        Me.Label50.Text = "Senha Usuário"
        Me.ToolTip1.SetToolTip(Me.Label50, "Caminho de Backup do Banco de Dados no Servidor")
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(11, 49)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(117, 14)
        Me.Label49.TabIndex = 3
        Me.Label49.Text = "Usuário Servidor"
        Me.ToolTip1.SetToolTip(Me.Label49, "Caminho de Backup do Banco de Dados no Servidor")
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(11, 24)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(117, 14)
        Me.Label44.TabIndex = 0
        Me.Label44.Text = "Backup Servidor"
        Me.ToolTip1.SetToolTip(Me.Label44, "Caminho de Backup do Banco de Dados no Servidor")
        '
        'btNovo
        '
        Me.btNovo.BackColor = System.Drawing.SystemColors.Control
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.Image = Global.WinASS.My.Resources.Resources._7706_16x16
        Me.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovo.Location = New System.Drawing.Point(7, 1)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(77, 25)
        Me.btNovo.TabIndex = 0
        Me.btNovo.Text = "Editar (F2)"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btNovo.UseVisualStyleBackColor = False
        '
        'btAlterar
        '
        Me.btAlterar.BackColor = System.Drawing.SystemColors.Control
        Me.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAlterar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAlterar.Image = Global.WinASS.My.Resources.Resources._7689_16x16
        Me.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btAlterar.Location = New System.Drawing.Point(90, 1)
        Me.btAlterar.Name = "btAlterar"
        Me.btAlterar.Size = New System.Drawing.Size(86, 25)
        Me.btAlterar.TabIndex = 1
        Me.btAlterar.Text = "Alterar (F3)"
        Me.btAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAlterar.UseVisualStyleBackColor = False
        '
        'btLimpar
        '
        Me.btLimpar.BackColor = System.Drawing.SystemColors.Control
        Me.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLimpar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.Image = Global.WinASS.My.Resources.Resources._6161_16x16
        Me.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btLimpar.Location = New System.Drawing.Point(182, 1)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(86, 25)
        Me.btLimpar.TabIndex = 2
        Me.btLimpar.Text = "Limpar (F6)"
        Me.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btLimpar.UseVisualStyleBackColor = False
        '
        'btFechar
        '
        Me.btFechar.BackColor = System.Drawing.SystemColors.Control
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Image = Global.WinASS.My.Resources.Resources.porta16
        Me.btFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFechar.Location = New System.Drawing.Point(274, 1)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(95, 25)
        Me.btFechar.TabIndex = 3
        Me.btFechar.Text = "Fechar (F10)"
        Me.btFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btFechar.UseVisualStyleBackColor = False
        '
        'tpGeral
        '
        Me.tpGeral.Controls.Add(Me.txtCodigos_Animais)
        Me.tpGeral.Controls.Add(Me.Label8)
        Me.tpGeral.Controls.Add(Me.txtCodigos_Inseminacao)
        Me.tpGeral.Controls.Add(Me.Label7)
        Me.tpGeral.Controls.Add(Me.txtValor_Beneficio_Languiru)
        Me.tpGeral.Controls.Add(Me.Label6)
        Me.tpGeral.Controls.Add(Me.txtAssistencia_Languiru)
        Me.tpGeral.Controls.Add(Me.Label5)
        Me.tpGeral.Controls.Add(Me.txtValor_MaodeObra)
        Me.tpGeral.Controls.Add(Me.Label3)
        Me.tpGeral.Controls.Add(Me.txtValor_Vermifugo)
        Me.tpGeral.Controls.Add(Me.txtValor_Bernicida)
        Me.tpGeral.Controls.Add(Me.txtValor_Fasciolicida)
        Me.tpGeral.Controls.Add(Me.Label4)
        Me.tpGeral.Controls.Add(Me.Label2)
        Me.tpGeral.Controls.Add(Me.Label1)
        Me.tpGeral.Location = New System.Drawing.Point(4, 23)
        Me.tpGeral.Name = "tpGeral"
        Me.tpGeral.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGeral.Size = New System.Drawing.Size(757, 445)
        Me.tpGeral.TabIndex = 0
        Me.tpGeral.Text = "Geral"
        Me.tpGeral.UseVisualStyleBackColor = True
        '
        'txtCodigos_Animais
        '
        Me.txtCodigos_Animais.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtCodigos_Animais.Location = New System.Drawing.Point(369, 226)
        Me.txtCodigos_Animais.Name = "txtCodigos_Animais"
        Me.txtCodigos_Animais.Size = New System.Drawing.Size(73, 20)
        Me.txtCodigos_Animais.TabIndex = 16
        '
        'txtCodigos_Inseminacao
        '
        Me.txtCodigos_Inseminacao.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtCodigos_Inseminacao.Location = New System.Drawing.Point(369, 195)
        Me.txtCodigos_Inseminacao.Name = "txtCodigos_Inseminacao"
        Me.txtCodigos_Inseminacao.Size = New System.Drawing.Size(73, 20)
        Me.txtCodigos_Inseminacao.TabIndex = 13
        '
        'txtValor_Beneficio_Languiru
        '
        Me.txtValor_Beneficio_Languiru.AllowNegative = True
        Me.txtValor_Beneficio_Languiru.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtValor_Beneficio_Languiru.Location = New System.Drawing.Point(369, 164)
        Me.txtValor_Beneficio_Languiru.Name = "txtValor_Beneficio_Languiru"
        Me.txtValor_Beneficio_Languiru.NumericPrecision = 12
        Me.txtValor_Beneficio_Languiru.NumericScaleOnFocus = 2
        Me.txtValor_Beneficio_Languiru.NumericScaleOnLostFocus = 2
        Me.txtValor_Beneficio_Languiru.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValor_Beneficio_Languiru.Size = New System.Drawing.Size(73, 20)
        Me.txtValor_Beneficio_Languiru.TabIndex = 11
        Me.txtValor_Beneficio_Languiru.Text = "0,00"
        Me.txtValor_Beneficio_Languiru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValor_Beneficio_Languiru.ZeroIsValid = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(17, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(350, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "6. Valor Benefício Serviços Languiru (Sep.p.virgula)"
        '
        'txtAssistencia_Languiru
        '
        Me.txtAssistencia_Languiru.AllowNegative = True
        Me.txtAssistencia_Languiru.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtAssistencia_Languiru.Location = New System.Drawing.Point(369, 135)
        Me.txtAssistencia_Languiru.Name = "txtAssistencia_Languiru"
        Me.txtAssistencia_Languiru.NumericPrecision = 12
        Me.txtAssistencia_Languiru.NumericScaleOnFocus = 0
        Me.txtAssistencia_Languiru.NumericScaleOnLostFocus = 0
        Me.txtAssistencia_Languiru.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAssistencia_Languiru.Size = New System.Drawing.Size(73, 20)
        Me.txtAssistencia_Languiru.TabIndex = 9
        Me.txtAssistencia_Languiru.Text = "0"
        Me.txtAssistencia_Languiru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAssistencia_Languiru.ZeroIsValid = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(17, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(350, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "5. Código do Tipo Assistência Languiru (Sep.p.virgula)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtValor_MaodeObra
        '
        Me.txtValor_MaodeObra.AllowNegative = True
        Me.txtValor_MaodeObra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtValor_MaodeObra.Location = New System.Drawing.Point(369, 105)
        Me.txtValor_MaodeObra.Name = "txtValor_MaodeObra"
        Me.txtValor_MaodeObra.NumericPrecision = 12
        Me.txtValor_MaodeObra.NumericScaleOnFocus = 2
        Me.txtValor_MaodeObra.NumericScaleOnLostFocus = 2
        Me.txtValor_MaodeObra.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValor_MaodeObra.Size = New System.Drawing.Size(73, 20)
        Me.txtValor_MaodeObra.TabIndex = 7
        Me.txtValor_MaodeObra.Text = "0,00"
        Me.txtValor_MaodeObra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValor_MaodeObra.ZeroIsValid = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(17, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(350, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "4. Valor Mão de Obra"
        '
        'txtValor_Vermifugo
        '
        Me.txtValor_Vermifugo.AllowNegative = True
        Me.txtValor_Vermifugo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtValor_Vermifugo.Location = New System.Drawing.Point(369, 20)
        Me.txtValor_Vermifugo.Name = "txtValor_Vermifugo"
        Me.txtValor_Vermifugo.NumericPrecision = 12
        Me.txtValor_Vermifugo.NumericScaleOnFocus = 2
        Me.txtValor_Vermifugo.NumericScaleOnLostFocus = 2
        Me.txtValor_Vermifugo.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValor_Vermifugo.Size = New System.Drawing.Size(73, 20)
        Me.txtValor_Vermifugo.TabIndex = 1
        Me.txtValor_Vermifugo.Text = "0,00"
        Me.txtValor_Vermifugo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValor_Vermifugo.ZeroIsValid = True
        '
        'txtValor_Bernicida
        '
        Me.txtValor_Bernicida.AllowNegative = True
        Me.txtValor_Bernicida.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtValor_Bernicida.Location = New System.Drawing.Point(369, 49)
        Me.txtValor_Bernicida.Name = "txtValor_Bernicida"
        Me.txtValor_Bernicida.NumericPrecision = 12
        Me.txtValor_Bernicida.NumericScaleOnFocus = 2
        Me.txtValor_Bernicida.NumericScaleOnLostFocus = 2
        Me.txtValor_Bernicida.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValor_Bernicida.Size = New System.Drawing.Size(73, 20)
        Me.txtValor_Bernicida.TabIndex = 3
        Me.txtValor_Bernicida.Text = "0,00"
        Me.txtValor_Bernicida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValor_Bernicida.ZeroIsValid = True
        '
        'txtValor_Fasciolicida
        '
        Me.txtValor_Fasciolicida.AllowNegative = True
        Me.txtValor_Fasciolicida.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtValor_Fasciolicida.Location = New System.Drawing.Point(369, 76)
        Me.txtValor_Fasciolicida.Name = "txtValor_Fasciolicida"
        Me.txtValor_Fasciolicida.NumericPrecision = 12
        Me.txtValor_Fasciolicida.NumericScaleOnFocus = 2
        Me.txtValor_Fasciolicida.NumericScaleOnLostFocus = 2
        Me.txtValor_Fasciolicida.NumericValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValor_Fasciolicida.Size = New System.Drawing.Size(73, 20)
        Me.txtValor_Fasciolicida.TabIndex = 5
        Me.txtValor_Fasciolicida.Text = "0,00"
        Me.txtValor_Fasciolicida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValor_Fasciolicida.ZeroIsValid = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(17, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(350, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "3. Valor Fasciolicida (Por Cabeça)"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(17, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(350, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "2. Valor Bernicida (Por Cabeça) CC"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1. Valor Vermífugo (Por Cabeça)"
        '
        'pnlGeral
        '
        Me.pnlGeral.Controls.Add(Me.tpGeral)
        Me.pnlGeral.Controls.Add(Me.TabPage1)
        Me.pnlGeral.Location = New System.Drawing.Point(7, 32)
        Me.pnlGeral.Name = "pnlGeral"
        Me.pnlGeral.SelectedIndex = 0
        Me.pnlGeral.Size = New System.Drawing.Size(765, 472)
        Me.pnlGeral.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(757, 445)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Backup"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSenhaServidor)
        Me.GroupBox3.Controls.Add(Me.txtUsuarioServidor)
        Me.GroupBox3.Controls.Add(Me.Label50)
        Me.GroupBox3.Controls.Add(Me.Label49)
        Me.GroupBox3.Controls.Add(Me.Label44)
        Me.GroupBox3.Controls.Add(Me.txtCaminhoBackup)
        Me.GroupBox3.Controls.Add(Me.btBackupServidor)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(713, 115)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Backup"
        '
        'txtSenhaServidor
        '
        Me.txtSenhaServidor.Location = New System.Drawing.Point(134, 72)
        Me.txtSenhaServidor.MaxLength = 200
        Me.txtSenhaServidor.Name = "txtSenhaServidor"
        Me.txtSenhaServidor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaServidor.Size = New System.Drawing.Size(179, 20)
        Me.txtSenhaServidor.TabIndex = 6
        '
        'txtUsuarioServidor
        '
        Me.txtUsuarioServidor.Location = New System.Drawing.Point(134, 46)
        Me.txtUsuarioServidor.MaxLength = 200
        Me.txtUsuarioServidor.Name = "txtUsuarioServidor"
        Me.txtUsuarioServidor.Size = New System.Drawing.Size(179, 20)
        Me.txtUsuarioServidor.TabIndex = 4
        '
        'txtCaminhoBackup
        '
        Me.txtCaminhoBackup.Enabled = False
        Me.txtCaminhoBackup.Location = New System.Drawing.Point(134, 21)
        Me.txtCaminhoBackup.Name = "txtCaminhoBackup"
        Me.txtCaminhoBackup.ReadOnly = True
        Me.txtCaminhoBackup.Size = New System.Drawing.Size(179, 20)
        Me.txtCaminhoBackup.TabIndex = 1
        '
        'btBackupServidor
        '
        Me.btBackupServidor.FlatAppearance.BorderSize = 0
        Me.btBackupServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBackupServidor.Image = CType(resources.GetObject("btBackupServidor.Image"), System.Drawing.Image)
        Me.btBackupServidor.Location = New System.Drawing.Point(319, 21)
        Me.btBackupServidor.Name = "btBackupServidor"
        Me.btBackupServidor.Size = New System.Drawing.Size(29, 23)
        Me.btBackupServidor.TabIndex = 2
        Me.btBackupServidor.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btTestarConexao)
        Me.GroupBox2.Controls.Add(Me.Label48)
        Me.GroupBox2.Controls.Add(Me.txtSenhaFTP)
        Me.GroupBox2.Controls.Add(Me.Label47)
        Me.GroupBox2.Controls.Add(Me.txtUsuarioFTP)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtServidorFTP)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(713, 107)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FTP"
        '
        'btTestarConexao
        '
        Me.btTestarConexao.BackColor = System.Drawing.Color.Transparent
        Me.btTestarConexao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btTestarConexao.FlatAppearance.BorderSize = 0
        Me.btTestarConexao.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btTestarConexao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btTestarConexao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
        Me.btTestarConexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTestarConexao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTestarConexao.ForeColor = System.Drawing.Color.Black
        Me.btTestarConexao.Image = CType(resources.GetObject("btTestarConexao.Image"), System.Drawing.Image)
        Me.btTestarConexao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btTestarConexao.Location = New System.Drawing.Point(490, 67)
        Me.btTestarConexao.Name = "btTestarConexao"
        Me.btTestarConexao.Size = New System.Drawing.Size(134, 26)
        Me.btTestarConexao.TabIndex = 6
        Me.btTestarConexao.Text = "Testar Conexão"
        Me.btTestarConexao.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btTestarConexao.UseVisualStyleBackColor = False
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(464, 16)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(160, 14)
        Me.Label48.TabIndex = 4
        Me.Label48.Text = "3. Senha FTP"
        '
        'txtSenhaFTP
        '
        Me.txtSenhaFTP.Location = New System.Drawing.Point(467, 38)
        Me.txtSenhaFTP.Name = "txtSenhaFTP"
        Me.txtSenhaFTP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaFTP.Size = New System.Drawing.Size(157, 20)
        Me.txtSenhaFTP.TabIndex = 5
        '
        'Label47
        '
        Me.Label47.Location = New System.Drawing.Point(234, 16)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(160, 14)
        Me.Label47.TabIndex = 2
        Me.Label47.Text = "2. Usuário FTP"
        '
        'txtUsuarioFTP
        '
        Me.txtUsuarioFTP.Location = New System.Drawing.Point(237, 38)
        Me.txtUsuarioFTP.Name = "txtUsuarioFTP"
        Me.txtUsuarioFTP.Size = New System.Drawing.Size(157, 20)
        Me.txtUsuarioFTP.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(6, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(242, 14)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "1. Servidor FTP"
        '
        'txtServidorFTP
        '
        Me.txtServidorFTP.Location = New System.Drawing.Point(9, 38)
        Me.txtServidorFTP.Name = "txtServidorFTP"
        Me.txtServidorFTP.Size = New System.Drawing.Size(157, 20)
        Me.txtServidorFTP.TabIndex = 1
        '
        'Parametros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(784, 504)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.pnlGeral)
        Me.Controls.Add(Me.btAlterar)
        Me.Controls.Add(Me.btLimpar)
        Me.Controls.Add(Me.btFechar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(230, 176)
        Me.Name = "Parametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Parametros"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpGeral.ResumeLayout(False)
        Me.tpGeral.PerformLayout()
        Me.pnlGeral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public objParametros_Implem As Parametros_Implem = ParametrosBOFactory.GetFactory().GetInstance()

#Region " Inicializações "

    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btFechar.Focus()
    End Sub

    Private Sub Parametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim autoriza As Boolean
        autoriza = VerificaPrograma("Parametros", VariaveisGlobais.gSetorUsuario, _
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

            LimpaTela()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub CadastroParametros_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        objParametros_Implem = Nothing
        LimpaErros()
    End Sub

    Private Sub Parametros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F1 Then
            objLeituras.VerC_LOG(VariaveisGlobais.gBD, "C_LOG", "Parametros", "Parametros")
        End If
        If e.KeyCode = Keys.F2 Then
            btNovo.PerformClick()
        End If
        If e.KeyCode = Keys.F3 Then
            btAlterar.PerformClick()
        End If
        If e.KeyCode = Keys.F6 Then
            btLimpar.PerformClick()
        End If
        If e.KeyCode = Keys.F10 Then
            btFechar.PerformClick()
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

#Region " Adicionar/Alterar /Excluir Parametro "

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        LimpaTela(True)
        pnlGeral.Enabled = True
    End Sub

    Private Sub btAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAlterar.Click
        Alterar()
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Public Function GuardaDadosParametros() As Integer
        Try

            Dim wChaveID As New CryptographyCFF.CryptographyBO

            objParametros_Implem.Valor_Vermifugo = Replace(txtValor_Vermifugo.Text, "'", "''")
            objParametros_Implem.Valor_Bernicida = Replace(txtValor_Bernicida.Text, "'", "''")
            objParametros_Implem.Valor_Fasciolicida = Replace(txtValor_Fasciolicida.Text, "'", "''")
            objParametros_Implem.Valor_MaodeObra = Replace(txtValor_MaodeObra.Text, "'", "''")
            objParametros_Implem.Valor_Beneficio_Languiru = Replace(txtValor_Beneficio_Languiru.Text, "'", "''")
            objParametros_Implem.Assistencia_Languiru = Replace(txtAssistencia_Languiru.Text, "'", "''")
            objParametros_Implem.Codigos_Inseminacao = Replace(txtCodigos_Inseminacao.Text, "'", "''")
            objParametros_Implem.Codigos_Animais = Replace(txtCodigos_Animais.Text, "'", "''")
            objParametros_Implem.ServidorFTP = Replace(txtServidorFTP.Text, "'", "''")
            objParametros_Implem.UsuarioFTP = Replace(txtUsuarioFTP.Text, "'", "''")
            objParametros_Implem.UsuarioServidor = Replace(txtUsuarioServidor.Text, "'", "''")
            objParametros_Implem.CaminhoBackup = Replace(txtCaminhoBackup.Text, "'", "''")

            If txtSenhaFTP.Text <> "" Then
                Dim wChaveIDCrypto As String = wChaveID.EncryptString128Bit(Replace(txtSenhaFTP.Text, "'", "''"), VariaveisGlobais.gCryptographycKey)
                objParametros_Implem.SenhaFTP = wChaveIDCrypto
            Else
                objParametros_Implem.SenhaFTP = ""
            End If

            If txtSenhaServidor.Text <> "" Then
                Dim wChaveIDCrypto As String = wChaveID.EncryptString128Bit(Replace(txtSenhaServidor.Text, "'", "''"), VariaveisGlobais.gCryptographycKey)
                objParametros_Implem.SenhaServidor = wChaveIDCrypto
            Else
                objParametros_Implem.SenhaServidor = ""
            End If


        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Sub TelaAlteracaoParametros()
        Try
            Dim wChaveID As New CryptographyCFF.CryptographyBO
            Dim wChaveIDCrypto As String
            Dim wControle As Integer
            LimpaErros()

            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Me.Close()
            End If

            txtValor_Bernicida.Text = objParametros_Implem.Valor_Bernicida
            txtValor_Fasciolicida.Text = objParametros_Implem.Valor_Fasciolicida
            txtValor_Vermifugo.Text = objParametros_Implem.Valor_Vermifugo
            txtValor_MaodeObra.Text = objParametros_Implem.Valor_MaodeObra
            txtAssistencia_Languiru.Text = objParametros_Implem.Assistencia_Languiru
            txtValor_Beneficio_Languiru.Text = objParametros_Implem.Valor_Beneficio_Languiru
            txtCodigos_Inseminacao.Text = objParametros_Implem.Codigos_Inseminacao
            txtCodigos_Animais.Text = objParametros_Implem.Codigos_Animais
            txtServidorFTP.Text = objParametros_Implem.ServidorFTP
            txtUsuarioFTP.Text = objParametros_Implem.UsuarioFTP
            txtUsuarioServidor.Text = objParametros_Implem.UsuarioServidor
            txtCaminhoBackup.Text = objParametros_Implem.CaminhoBackup

            wChaveIDCrypto = wChaveID.DecryptString128Bit(objParametros_Implem.SenhaServidor, VariaveisGlobais.gCryptographycKey)
            txtSenhaServidor.Text = wChaveIDCrypto

            wChaveIDCrypto = wChaveID.DecryptString128Bit(objParametros_Implem.SenhaFTP, VariaveisGlobais.gCryptographycKey)
            txtSenhaFTP.Text = wChaveIDCrypto

            'btAlterar.Enabled = vAlterar
            'btNovo.Enabled = False
            'btLimpar.Enabled = True
            'pnlGeral.SelectedIndex = 1

            Windows.Forms.Cursor.Current = Cursors.Default

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Me.Close()
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

            wControle = GuardaDadosParametros()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If

            wControle = objParametros_Implem.AlterarParametro()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            End If
            MessageBox.Show("Dados da Parametro modificados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpaTela()

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
        Dim wControle As Integer

        Try

            If wNovoRegistro = True Then
                btLimpar.Enabled = True
                btAlterar.Enabled = True
                btFechar.Enabled = False
            Else
                btLimpar.Enabled = False
                btAlterar.Enabled = False
                btFechar.Enabled = True
            End If
            pnlGeral.Enabled = False

            wControle = objParametros_Implem.BuscarParametro()
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
            End If
            TelaAlteracaoParametros()

            LimpaErros()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
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
        pnlGeral.SelectedIndex = 1

        'txtCodigo_Parametro.Focus()
        btLimpar.Focus()

        For f = 0 To 39
            If VariaveisGlobais.gErroTela(f) <> "" Then
                If wFoco = -1 Then wFoco = f
                wErros = wErros & VariaveisGlobais.gErroTela(f) & vbCrLf
            End If
        Next f

        If wErros <> "" Then

            For f = 0 To tpGeral.Controls.Count - 1
                If tpGeral.Controls(f).TabIndex = wFoco Then
                    tpGeral.Controls(f).Focus()
                End If
            Next

            MessageBox.Show("Verifique os erros abaixo: " & vbCrLf & vbCrLf & wErros, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 1
        End If

        Return 0

    End Function

    Private Sub LimpaErros()

        'ErrorProvider1.SetError(txtId_Parametro, "")

        objVariaveisGlobais.InicializaVetorErros()

    End Sub

#End Region
  
    Private Sub btTestarConexao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTestarConexao.Click
        Try
            Dim wControle As Integer = ConectaFTP()
            If wControle = 0 Then
                MessageBox.Show("Conexão Realizada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Sucesso
            Else
                MessageBox.Show("Conexão Falhou!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Conexão Falhou!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function ConectaFTP() As Integer
        objFtpClient = New FTPLib.FTP
        Try
            objFtpClient.server = txtServidorFTP.Text
            objFtpClient.user = txtUsuarioFTP.Text
            objFtpClient.pass = txtSenhaFTP.Text

            objFtpClient.Connect()
            objFtpClient.ChangeDir(".")

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = "ConectaFTP " & txtServidorFTP.Text & " user: " & txtUsuarioFTP.Text
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try

        Return 0
    End Function

    Private Sub btBackupServidor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBackupServidor.Click
        Dim wControle As Integer
        VariaveisGlobais.gAutoriza = "MCaminhoBackupServidor"

        Dim a As New TelaSenha
        a.ShowDialog()
        a.Dispose()

        If VariaveisGlobais.gAutoriza <> "" Then

            Dim fbFF As New FolderBrowserDialog
            fbFF.Description = "Selecione o local de backup do Servidor"
            If fbFF.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtCaminhoBackup.Text = fbFF.SelectedPath.ToString & IIf(fbFF.SelectedPath.ToString.Substring(Len(fbFF.SelectedPath.ToString) - 1, 1) = "\", "", "\")
            Else
                txtCaminhoBackup.Text = ""
            End If
        End If
    End Sub
End Class