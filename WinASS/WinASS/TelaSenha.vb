Imports System.Data.SqlClient

Public Class TelaSenha
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents btConfirmar As System.Windows.Forms.Button
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAutoriza As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaSenha))
        Me.btConfirmar = New System.Windows.Forms.Button
        Me.btCancelar = New System.Windows.Forms.Button
        Me.txtSenha = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAutoriza = New System.Windows.Forms.TextBox
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btConfirmar
        '
        Me.btConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btConfirmar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConfirmar.ForeColor = System.Drawing.Color.Black
        Me.btConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btConfirmar.Location = New System.Drawing.Point(122, 113)
        Me.btConfirmar.Name = "btConfirmar"
        Me.btConfirmar.Size = New System.Drawing.Size(72, 26)
        Me.btConfirmar.TabIndex = 6
        Me.btConfirmar.Text = "Confirmar"
        Me.btConfirmar.UseVisualStyleBackColor = False
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.Black
        Me.btCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btCancelar.Location = New System.Drawing.Point(218, 113)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(72, 26)
        Me.btCancelar.TabIndex = 7
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(175, 77)
        Me.txtSenha.MaxLength = 30
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(168, 20)
        Me.txtSenha.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(63, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuário"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(63, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Senha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(175, 53)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(168, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(63, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Autoriza Programa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAutoriza
        '
        Me.txtAutoriza.BackColor = System.Drawing.Color.LightGray
        Me.txtAutoriza.Enabled = False
        Me.txtAutoriza.Location = New System.Drawing.Point(175, 29)
        Me.txtAutoriza.MaxLength = 20
        Me.txtAutoriza.Name = "txtAutoriza"
        Me.txtAutoriza.Size = New System.Drawing.Size(168, 20)
        Me.txtAutoriza.TabIndex = 1
        '
        'TelaSenha
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(436, 165)
        Me.Controls.Add(Me.txtAutoriza)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btConfirmar)
        Me.Controls.Add(Me.btCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TelaSenha"
        Me.Opacity = 0.85
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Senha Supervisor"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim wComando As SqlCommand = New SqlCommand("", VariaveisGlobais.gConexao)
    Dim wDataReader As SqlDataReader

    Dim wSetorUsuario As Integer
    Dim wFilialUsuario As Integer
    Dim wTipoUsuario As String
    Dim wLoginUsuario As String
    Dim wSituacao As String

#Region " Inicializações "

    Private Sub TelaSenha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsuario.Text = VariaveisGlobais.gLoginUsuario
        txtAutoriza.Text = VariaveisGlobais.gAutoriza
        VariaveisGlobais.gAutoriza = ""

    End Sub

#End Region

#Region " Cancelar/Confirmar "

    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        VariaveisGlobais.gAutoriza = ""
        LimpaErros()
        Fechar()
    End Sub
    Public Function Fechar() As Integer
        Me.Close()
    End Function

    Private Sub btConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmar.Click
        Dim wControle As Integer

        wControle = ValidaDados()
        If wControle <> 0 Then Exit Sub

        wControle = VerificaSenha(txtUsuario.Text, txtSenha.Text)
        Select Case wControle
            Case Is < 0
                objVariaveisGlobais.MostraErro()
                Exit Sub
            Case Is = 0
                Dim autoriza As Boolean
                autoriza = VerificaPrograma(txtAutoriza.Text, wSetorUsuario, _
                    wTipoUsuario, wLoginUsuario)
                If autoriza = True Then
                    VariaveisGlobais.gAutoriza = txtUsuario.Text
                    Fechar()
                Else
                    MessageBox.Show("Usuário Não Autorizado ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Case Is = 2
                MessageBox.Show("Usuário Bloqueado ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Case Is > 0
                MessageBox.Show("Usuário Não Existe ou Senha Inválida ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
        End Select
    End Sub

    Public Function VerificaSenha(ByVal pLogin As String, ByVal pSenha As String) As Integer
        Dim wComando As SqlCommand = New SqlCommand("", VariaveisGlobais.gConexao)
        Dim wDataReader As SqlDataReader

        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = "SELECT * FROM C_Usuarios WHERE " & _
                                   "     Login='" & pLogin & "' AND " & _
                                   "     Senha='" & pSenha & "'"

            wDataReader = wComando.ExecuteReader

            If wDataReader.Read() Then
                wLoginUsuario = pLogin
                wTipoUsuario = IIf(IsDBNull(wDataReader("Tipo")), "", wDataReader("Tipo"))
                wSetorUsuario = IIf(IsDBNull(wDataReader("Setor")), "", wDataReader("Setor"))
                wSituacao = IIf(IsDBNull(wDataReader("Situacao")), "", wDataReader("Situacao"))
                wDataReader.Close()
                If wSituacao = "B" Then
                    Return 2
                Else
                    Return 0
                End If
            End If
            wDataReader.Close()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 1
    End Function

#End Region

#Region " Valida da tela "

    Private Function ValidaDados() As Integer
        LimpaErros()


        Dim wErros As String = ""
        Dim wFoco As Integer = -1
        '___________________________________________________________
        '
        '   Valida Campos
        '___________________________________________________________
        txtUsuario.Focus()
        txtSenha.Focus()
        txtUsuario.Focus()

        For f As Integer = 0 To 39
            If VariaveisGlobais.gErroTela(f) <> "" Then
                If wFoco = -1 Then wFoco = f
                wErros = wErros & VariaveisGlobais.gErroTela(f) & vbCrLf
            End If
        Next f
        If wErros <> "" Then
            MessageBox.Show("Verifique os erros abaixo: " & vbCrLf & vbCrLf & wErros, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 1
        End If
        Return 0
    End Function

    Private Sub LimpaErros()
        '___________________________________________________________
        '
        '   Limpa os erros
        '___________________________________________________________

        ErrorProvider1.SetError(txtUsuario, "")
        ErrorProvider1.SetError(txtSenha, "")

        objVariaveisGlobais.InicializaVetorErros()

    End Sub

    Private Sub txtUsuario_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUsuario.Validating
        '___________________________________________________________
        '   Valida Campo
        '___________________________________________________________

        Dim wMsgErro As String = "Digite o login do usuário!"

        If txtUsuario.Text = "" Then
            ErrorProvider1.SetError(txtUsuario, wMsgErro)
            VariaveisGlobais.gErroTela(0) = wMsgErro
        Else
            ErrorProvider1.SetError(txtUsuario, "")
            VariaveisGlobais.gErroTela(0) = ""
        End If

    End Sub
    Private Sub txtSenha_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSenha.Validating


        Dim wMsgErro As String = "Digite a senha do usuário!"

        If txtSenha.Text = "" Then
            ErrorProvider1.SetError(txtSenha, wMsgErro)
            VariaveisGlobais.gErroTela(1) = wMsgErro
        Else
            ErrorProvider1.SetError(txtSenha, "")
            VariaveisGlobais.gErroTela(1) = ""
        End If

    End Sub

#End Region

#Region " Enter para Senha "

    Private Sub txtUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress

        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtSenha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSenha.KeyPress

        If e.KeyChar = Chr(13) Then
            btConfirmar.PerformClick()
        End If

    End Sub

#End Region
    Private Sub MyBase_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        Dim wControle As Integer
        wControle = objVariaveisGlobais.FechaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
        If wControle <> 0 Then
            objVariaveisGlobais.MostraErro()
        End If
    End Sub
End Class
