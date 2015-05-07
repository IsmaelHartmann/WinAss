Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Compression
Imports System.Security.AccessControl
Imports Ionic.Utils
Imports System.Text

'Imports Microsoft.SqlServer.ConnectionInfo.dll
'Imports Microsoft.SqlServer.Smo.dll
'Imports Microsoft.SqlServer.Management.Sdk.Sfc

'In the code, before any declarations, type the following Imports statements
Imports Microsoft.SqlServer.Management.Smo

Public Class Backup

    Public objVariaveisGlobais As New VariaveisGlobais
    Public objParametros_Implem As Parametros_Implem = ParametrosBOFactory.GetFactory().GetInstance()
    Public wComando As SqlCommand
    Private wDataReader As SqlDataReader
    Public wDataSet As DataSet
    'Private Const gCryptographycKey As String = "#fas987$"

    Public Sub New()
        MyBase.New()

        'This call is required BY the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        wComando = New SqlCommand("", objVariaveisGlobais.gConexao)

    End Sub

    Private Sub Backup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim wControle As Integer
        wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
        If wControle <> 0 Then
            objVariaveisGlobais.MostraErro()
            Me.Enabled = False
            Exit Sub
        End If

        txtNomeArquivo.Text = "CTAASS"
        AlteraStatus(0)
        wComando = New SqlCommand("", objVariaveisGlobais.gConexao)

        wControle = objParametros_Implem.BuscarParametro
        If wControle <> 0 Then
            MessageBox.Show("Erro ao buscar parâmetros!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Sub AlteraStatus(ByVal pPos As Integer)
        Try
            If pPos = 0 Then
                lbl1.ForeColor = Color.LightGray
                lbl2.ForeColor = Color.LightGray
                lbl3.ForeColor = Color.LightGray
                lbl4.ForeColor = Color.LightGray
            ElseIf pPos = 1 Then
                lbl1.ForeColor = Color.Blue
                lbl2.ForeColor = Color.LightGray
                lbl3.ForeColor = Color.LightGray
                lbl4.ForeColor = Color.LightGray
            ElseIf pPos = 2 Then
                lbl1.ForeColor = Color.LightGray
                lbl2.ForeColor = Color.Blue
                lbl3.ForeColor = Color.LightGray
                lbl4.ForeColor = Color.LightGray
            ElseIf pPos = 3 Then
                lbl1.ForeColor = Color.LightGray
                lbl2.ForeColor = Color.LightGray
                lbl3.ForeColor = Color.Blue
                lbl4.ForeColor = Color.LightGray
            ElseIf pPos = 4 Then
                lbl1.ForeColor = Color.LightGray
                lbl2.ForeColor = Color.LightGray
                lbl3.ForeColor = Color.LightGray
                lbl4.ForeColor = Color.Blue
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btBKP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBKP.Click

        Me.Cursor = Cursors.WaitCursor
        If txtNomeArquivo.Text = "" Then
            MessageBox.Show("Informe um nome para o arquivo de backup", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        pbProgresso.Value = 0

        If txtLocalDestino.Text = "" Then
            MessageBox.Show("Informe um local de destino para o arquivo de backup", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Directory.Exists(txtLocalDestino.Text) = False Then
            MessageBox.Show("Local de destino inexistente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim wNomeArquivo As String = txtLocalDestino.Text & txtNomeArquivo.Text
        If File.Exists(wNomeArquivo & ".Bak'") = True Then

            Dim dr1 As DialogResult
            dr1 = MessageBox.Show("Já existe um arquivo com este nome, deseja substituí-lo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If dr1 = Windows.Forms.DialogResult.No Then

                Dim i As Integer = 1
                While File.Exists(wNomeArquivo & "(" & i & ").Bak'")
                    i += 1
                End While
                wNomeArquivo = wNomeArquivo & "(" & i & ")"

            End If

        End If

        'Dim wTransacao As SqlTransaction
        'wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "GerarBackup")
        'wComando.Transaction = wTransacao

        Dim wChaveID As New CryptographyCFF.CryptographyBO
        Dim wChaveIDCrypto As String = wChaveID.DecryptString128Bit(objParametros_Implem.SenhaServidor, VariaveisGlobais.gCryptographycKey)
        Dim wSenhaOr As String = wChaveIDCrypto

        Try
            AlteraStatus(1)
            Application.DoEvents()
            Me.Cursor = Cursors.WaitCursor
            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)

            wComando.CommandTimeout = 6 * 60 ' 6 minutos

            wComando.CommandText = "BACKUP DATABASE ""CTAASS"" to Disk = '" & objParametros_Implem.CaminhoBackup & "\" & txtNomeArquivo.Text & ".Bak' WITH  INIT," & _
            "NOUNLOAD, Name = N'COS backup',  NOSKIP ,  STATS = 10,  NOFORMAT"

            wComando.ExecuteNonQuery()
            'wTransacao.Commit()

            If objParametros_Implem.CaminhoBackup <> txtLocalDestino.Text Then


                'CRIAR PARAMETRO
                If objParametros_Implem.UsuarioServidor <> "" Then

                    Dim server As String = ""
                    If objParametros_Implem.CaminhoBackup.Contains("\") AndAlso objParametros_Implem.CaminhoBackup.Contains("\\") Then

                        Try

                            server = objParametros_Implem.CaminhoBackup.Substring(objParametros_Implem.CaminhoBackup.IndexOf("\\") + 2, _
                            objParametros_Implem.CaminhoBackup.Length - (objParametros_Implem.CaminhoBackup.IndexOf("\\") + 2))

                            server = server.Substring(0, server.IndexOf("\"))

                        Catch ex As Exception
                            server = ""
                        End Try


                    End If

                    If server <> "" Then
                        Open_Remote_Connection(server, objParametros_Implem.UsuarioServidor, wSenhaOr)
                    Else
                        MessageBox.Show("Servidor com formato de caminho errado!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                End If

                Me.Cursor = Cursors.WaitCursor

                Dim arquivos As FileInfo

                Dim DiretorioFonte As DirectoryInfo = New DirectoryInfo(objParametros_Implem.CaminhoBackup)
                Dim DiretorioDestino As DirectoryInfo = New DirectoryInfo(txtLocalDestino.Text)

                AlteraStatus(2)
                Application.DoEvents()
                Me.Cursor = Cursors.WaitCursor

                For Each arquivos In DiretorioFonte.GetFiles()
                    If arquivos.Name.ToUpper = (txtNomeArquivo.Text & ".Bak").ToUpper Then
                        arquivos.CopyTo(Path.Combine(DiretorioDestino.FullName, arquivos.Name), True)
                        'arquivos.CopyTo(Path.Combine(DiretorioDestino.FullName, txtNomeArquivo.Text & ".Bak"), True)
                        Exit For
                    End If
                    'Else
                    'If Not File.Exists(Path.Combine(DiretorioDestino.FullName, arquivos.Name)) Then
                    '    arquivos.CopyTo(Path.Combine(DiretorioDestino.FullName, arquivos.Name), False)
                    'End If
                    'End If
                Next

            End If

            wControle = IncluirHistoricoBackup()

            Dim dr1 As DialogResult = MessageBox.Show("Deseja comprimir e enviar uma cópia do Backup para o servidor FTP?" & vbCrLf & _
                                                     "(ATENÇÃO: Essa operação pode demorar alguns minutos)", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dr1 = Windows.Forms.DialogResult.Yes Then

                Dim wFileName As String = txtLocalDestino.Text & "\" & txtNomeArquivo.Text & ".Bak"
                Dim wCaminhoExe As String = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\FortalezaTec\WinASS"
                wFileName = wFileName.Replace("\\", "\")
                Dim wCaminhoZip As String = wFileName.Replace(".Bak", ".zip")
                Dim wArquivoUpload As String = txtNomeArquivo.Text & ".Bak"

                Try
                    AlteraStatus(3)
                    Application.DoEvents()
                    Me.Cursor = Cursors.WaitCursor

                    'ROTINA DE COMPACTAÇÃO DO ARQUIVO
                    Shell(wCaminhoExe & "\7za a -tzip " & wCaminhoZip & " " & wFileName, AppWinStyle.NormalFocus, True)

                Catch ex As Exception
                    VariaveisGlobais.gDescricaoUltimoErro = ex.Message
                    objVariaveisGlobais.MostraErro()
                End Try

                AlteraStatus(4)
                Application.DoEvents()
                Me.Cursor = Cursors.WaitCursor

                'ENVIA PARA FTP
                Dim wSenhaFTP As String = wChaveID.DecryptString128Bit(objParametros_Implem.SenhaFTP, VariaveisGlobais.gCryptographycKey)

                wControle = objVariaveisGlobais.UploadArquivo(wCaminhoZip, "ftp://" & objParametros_Implem.ServidorFTP & "/Bkp/BD_Clientes/" & wArquivoUpload.Replace(".Bak", ".zip"), objParametros_Implem.UsuarioFTP, wSenhaFTP, pbProgresso, lblPercentual, lblTempo)
                If wControle = 0 Then
                    MessageBox.Show("Backup e Envio realizados com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Backup realizado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.Cursor = Cursors.Default
            AlteraStatus(0)
            pbProgresso.Value = 0
            lblTempo.Text = ""
            lblPercentual.Text = ""

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            objVariaveisGlobais.gDescricaoUltimoErro = ex.Message
            objVariaveisGlobais.MostraErro()
            'wTransacao.Rollback("GerarBackup")
            'Throw ex
        End Try

    End Sub

    Private Sub Open_Remote_Connection(ByVal strComputer As String, ByVal strUsername As String, ByVal strPassword As String)
        Try
            '//====================================================================================
            '//using NET USE to open a connection to the remote computer
            '//with the specified credentials. if we dont do this first, File.Copy will fail
            '//====================================================================================
            Dim ProcessStartInfo As New System.Diagnostics.ProcessStartInfo
            ProcessStartInfo.FileName = "net"
            ProcessStartInfo.Arguments = "use \\" & strComputer & "\c$ /USER:" & strUsername & " " & strPassword
            ProcessStartInfo.WindowStyle = ProcessWindowStyle.Hidden
            System.Diagnostics.Process.Start(ProcessStartInfo)

            '//============================================================================
            '//wait 2 seconds to let the above command complete or the copy will still fail
            '//============================================================================
            System.Threading.Thread.Sleep(2000)

        Catch ex As Exception

        End Try
    End Sub

    Private Function IncluirHistoricoBackup() As Integer

        Dim wTransacao As SqlTransaction = Nothing
        Dim wControle As Integer

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "IncluirHistoricoBackup")
            wComando.Transaction = wTransacao

            wComando.CommandText = "INSERT INTO C_HistoricoBackup ( " & _
                                    " Data_Hora_Backup,                      " & _
                                    " Usuario_Backup               " & _
                                    "    ) VALUES (" & _
                                    "  '" & Date.Now & "',   " & _
                                    "  '" & VariaveisGlobais.gLoginUsuario & "')  "

            wComando.ExecuteNonQuery()

            wTransacao.Commit()
        Catch ex As Exception
            Try
                wTransacao.Rollback("IncluirHistoricoBackup")
            Catch
            End Try

            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function BuscarUltimoHistoricoBackup(ByRef pDataHoraUltimoBackup As String) As Integer

        Dim wControle As Integer
        Try

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Exit Function

            wComando.CommandText = " SELECT TOP 1 Data_Hora_Backup " & _
                                   " FROM C_HistoricoBackup " & _
                                   " ORDER BY Data_Hora_Backup DESC "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                pDataHoraUltimoBackup = NullBranco(wDataReader("Data_Hora_Backup"))
            Else
                wDataReader.Close()
                Return 1
            End If
            wDataReader.Close()

        Catch ex As Exception
            'VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Private Sub btSelecionaArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSelecionaArquivo.Click
        Dim fbFF As New FolderBrowserDialog
        fbFF.Description = "Selecione um local para salvar o arquivo do backup"
        If fbFF.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtLocalDestino.Text = fbFF.SelectedPath.ToString & IIf(fbFF.SelectedPath.ToString.Substring(Len(fbFF.SelectedPath.ToString) - 1, 1) = "\", "", "\")
        Else
            txtLocalDestino.Text = ""
        End If
    End Sub

    'Private Sub Execute(ByVal strAction As Action)
    '    Dim Filename As String

    '    Dim servername1, userid1, password1, database As String
    '    Dim StrConn As String
    '    Dim con As SqlConnection

    '    ServerName1 = cmbServerName1.Text.Trim()
    '    UserID1 = txtUserName1.Text.Trim()
    '    Password1 = txtPassword1.Text.Trim()
    '    database = cmbDataBase1.Text


    '    If cmbAuthe1.SelectedIndex = 0 Then
    '        StrConn = "Data Source=" & servername1 & ";Initial Catalog='" & cmbDataBase1.Text & "';Integrated Security=true"
    '    Else
    '        StrConn = "Data Source=" & servername1 & "; Initial Catalog=" & cmbDataBase1.Text & ";user id='" & userid1 & "';password='" & password1 & "';Integrated Security=true"
    '    End If

    '    StrConn = "Data Source=" & servername1 & ";Integrated Security=SSPI;Initial Catalog='" & cmbDataBase1.Text & "'"

    '    con = New SqlConnection(strConn)
    '    con.Open()
    '    Dim strQuery As String
    '    If strAction = Action.BackUp Then
    '        Dim objdlg As New SaveFileDialog
    '        objdlg.FileName = database
    '        objdlg.ShowDialog()
    '        Filename = objdlg.FileName
    '        strQuery = "backup database """ & database & """ to disk='" & Filename & "'"
    '    Else
    '        Dim objdlg As New OpenFileDialog
    '        objdlg.FileName = database
    '        objdlg.ShowDialog()
    '        Filename = objdlg.FileName
    '        strQuery = "RESTORE DATABASE " ' & database & '" FROM disk='" & Filename & "'"
    '    End If

    '    Dim cmd As SqlCommand
    '    cmd = New SqlCommand(strQuery, con)
    '    cmd.ExecuteNonQuery()
    'End Sub

    'Enum Action
    '    BackUp
    '    Restore
    'End Enum

    'Private Sub btnBackUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBKP.Click
    '    Execute(Action.BackUp)
    'End Sub
    'Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
    '    Execute(Action.Restore)
    'End Sub

End Class
