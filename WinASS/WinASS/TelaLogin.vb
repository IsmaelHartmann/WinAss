Imports System.Data.SqlClient

Public Class TelaLogin


    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.


    Dim wComando = New System.Data.SqlClient.SqlCommand("", VariaveisGlobais.gConexao)
    Dim wDataReader As SqlDataReader


#Region " Inicializações "

    Private Sub TelaLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'AjustaTela(Me, True)
            txtUsuario.Text = SystemInformation.UserName

        Catch ex As Exception

            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Me.Close()

        End Try

    End Sub

#End Region

#Region " Cancelar/Confirmar "

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
      
        Dim wDialogResult As DialogResult = MessageBox.Show("Você realmente deseja sair do sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If wDialogResult = Windows.Forms.DialogResult.Yes Then End

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim wControle As Integer
        wControle = ValidaDados()

        If wControle <> 0 Then Exit Sub
        wControle = VerificaLogin(txtUsuario.Text, txtSenha.Text)

        Select Case wControle
            ' Erro de sistema
            Case Is < 0
                objVariaveisGlobais.MostraErro()
                Exit Sub
                ' Login OK
            Case Is = 0
                Me.Close()
            Case Is = 1
                MessageBox.Show("Verifique seu login e sua senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Case Is = 2
                MessageBox.Show("Usuario Bloqueado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
        End Select

    End Sub

    Public Function VerificaLogin(ByVal pLogin As String, ByVal pSenha As String) As Integer

        Dim wComando As SqlCommand = New SqlCommand("", VariaveisGlobais.gConexao)
        Dim wDataReader As SqlDataReader

        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = " SELECT U.*,S.Nome NomeSetor    " & _
                                  "     FROM  C_Usuarios U,C_Setores S  WHERE " & _
                                  "     Login='" & pLogin & "' AND " & _
                                  "     Senha='" & pSenha & "' AND " & _
                                  "     U.Setor=S.Codigo "
            wDataReader = wComando.ExecuteReader

            If wDataReader.Read() Then
                VariaveisGlobais.gLoginUsuario = pLogin
                VariaveisGlobais.gCodigoUsuario = wDataReader("Id_Usuario")
                VariaveisGlobais.gTipoUsuario = wDataReader("Tipo")
                VariaveisGlobais.gNomeUsuario = wDataReader("Nome")
                VariaveisGlobais.gSetorUsuario = wDataReader("Setor")
                VariaveisGlobais.gNomeSetorUsuario = wDataReader("NomeSetor")
                VariaveisGlobais.gNomeEmpresaUsuario = "ASS"

                If wDataReader("Situacao") = "B" Then
                    wDataReader.Close()
                    Return 2
                End If
                wDataReader.Close()
                Return 0
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

    Private Function ValidaDados()

        Dim f As Integer
        Dim wErros As String = ""
        Dim wFoco As Integer = -1
        
        txtUsuario.Focus()
        txtSenha.Focus()
        txtUsuario.Focus()

        For f = 0 To 39
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
        '
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
        '___________________________________________________________
        '
        '   Valida Campo
        '___________________________________________________________

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

#Region " Enter para login "

    Private Sub TelaLogin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles MyBase.KeyPress

        If e.KeyChar = Chr(13) Then
            e.Handled = True
            If Me.txtSenha.Focused Then
                OK.PerformClick()
            Else
                MyBase.SelectNextControl(MyBase.ActiveControl, True, True, True, True)
            End If
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
