Imports System.IO
Imports System.Data.SqlClient

Public Class VariaveisGlobais

#Region " Globais do projeto "
    '
    ' Globais do projeto

    Public Shared gConnectionStringServer As String
    Public Shared gConnectionStringUsername As String
    Public Shared gConnectionStringPassword As String
    Public Shared gCryptographycKey As String = "#fas987$"

    Public Shared gContaReembolso As String
    Public Shared gCodigoCidade As String
    Public Shared gCodigoUsuario As String
    Public Shared gLoginUsuario As String
    Public Shared gNomeUsuario As String
    Public Shared gAutoriza As String
    Public Shared gTipoUsuario As String
    Public Shared gSetorUsuario As String
    Public Shared gNomeSetorUsuario As String
    Public Shared gNomeEmpresaUsuario As String
    Public Shared gSalarioMinimo As String

    Public Shared gIncluir As Boolean
    Public Shared gAlterar As Boolean
    Public Shared gExcluir As Boolean

    Public Shared gEmpresa As String
    Public Shared gNomeEmpresa As String
    Public Shared gFilial As String
    Public Shared gCidadeFilial As String
    Public Shared gSiglaEstado As String

    Public Shared PortaECNF As String
    Public Shared Menu As String
    Public Shared gBD As String
    Public Shared PortaComLeitor As String
    Public Shared CaminhoSNGPC As String

    Public Shared gConnectionString As String
    Public Shared gConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection

    Public Shared gUltimoSQL As String
    Public Shared gDescricaoUltimoErro As String
    Public Shared gStackTraceErro As String
    Public Shared gAppPath As String

    Public Shared gAcao As String
    Public Shared gErroTela(40) As String
    Public Shared gStatusNiu As Integer

    Public Shared gContaCaixaLocal As String
    Public Shared gPorta As String
    Public Shared gCodigoSetorLocal As String

    Public Shared gContaContasAReceber As String
    Public Shared gContaCobrancaMensalidade As String
    Public Shared gContaCobrancaTaxaCO As String
    Public Shared gContaCobrancaTaxaPF As String
    Public Shared gContaCobrancaTaxaPJ As String
    Public Shared gContaCobrancaTaxaInclusao As String
    Public Shared gContaCobrancaTaxaExclusao As String
    Public Shared gContaTaxaSegundaViaCartao As String

    Public Shared gContaCobrancaBanco As String
    Public Shared gContaTaxasBanco As String
    Public Shared gContaJurosMultaBanco As String
    Public Shared gContaDescontosConcedidos As String

    Public Shared gCodigoHistoricoRecebimentoCx As String
    Public Shared gCodigoHistoricoPagamentoCx As String
    Public Shared gCodigoHistoricoMensalidades As String
    Public Shared gCodigoHistoricoTaxaCO As String
    Public Shared gCodigoHistoricoContasAReceber As String
    Public Shared gCodigoHistoricoTaxasPF As String
    Public Shared gCodigoHistoricoTaxasPJ As String
    Public Shared gCodigoHistoricoTaxaExclusao As String
    Public Shared gCodigoHistoricoTaxaInclusao As String
    Public Shared gCodigoHistoricoSegundaViaCartao As String
    Public Shared gCodigoHistoricoSicrediJurosMulta As String
    Public Shared gCodigoHistoricoUnimed As String
    Public Shared gCodigoHistoricoSicredi As String
    Public Shared gCodigoHistoricoTaxasSicredi As String
    Public Shared gCodigoHistoricoDespesasPrestador As String
    Public Shared gCodigoHistoricoContasAPagarCredores As String
    Public Shared gCodigoHistoricoDescontosConcedidos As String

    Public objTelaPrincipal As Object

    Private Const cdoBasic = 1
    Private Const cdoAnonymous = 0
    Private Const cdoSendUsingPort = 2

    Private objConfiguration
    Private objFields
    Private objCDO

#If Debug = True Then
    Public gCaminhoImagem As String = AppPath().Replace("bin\Debug\", "") & "Imagens\"
#Else
    Public Shared gCaminhoImagem As String = AppPath() & "Imagens\"
#End If


#End Region

#Region " Funções para uso geral "

    Public Function VerificaConexaoBD(ByRef pConexao As SqlClient.SqlConnection, ByVal pConnectionString As String) As Integer
        '
        ' Verifica se conexão ao banco de dados está ativa, se não estiver abre

        If pConexao.State = ConnectionState.Open Then
            pConexao.Close()
        End If
        Try
            If pConexao.State <> ConnectionState.Open Then
                pConexao.ConnectionString = pConnectionString
                pConexao.Open()

                If pConexao.GetType.FullName = "System.Data.SqlClient.SqlConnection" Then
                    Dim wComando As SqlClient.SqlCommand = New SqlClient.SqlCommand
                    wComando.Connection = pConexao

                    wComando.CommandText = "SET DATEFORMAT dmy"
                    wComando.ExecuteNonQuery()
                End If
            End If
        Catch ex As Exception

            gUltimoSQL = ""
            gDescricaoUltimoErro = "*** ERRO DE ACESSO AO BANCO DE DADOS *** >> " & ex.Message
            gStackTraceErro = ex.StackTrace
            Return -2
        End Try
        Return 0
    End Function

    Public Function FechaConexaoBD(ByRef pConexao As SqlClient.SqlConnection, ByVal pConnectionString As String) As Integer
        '
        ' Verifica se conexão ao banco de dados está ativa, se estiver fecha
        Try
            If pConexao.State = ConnectionState.Open Then
                pConexao.Close()
            End If

            GC.Collect()

        Catch ex As Exception
            gUltimoSQL = ""
            gDescricaoUltimoErro = "*** ERRO FECHANDO AO BANCO DE DADOS *** >> " & ex.Message
            gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Sub SetaComboBox(ByRef pCombo As FzComboBox.FzCombobox, ByVal pValor As String)
        '
        ' Encontra valor no combo e seta o índice dele para este valor

        Dim wMarcou As Boolean = False
        Dim f As Integer
        Dim wItem As Web.UI.WebControls.ListItem
        For f = 0 To pCombo.Items.Count - 1
            wItem = CType(pCombo.Items(f), Web.UI.WebControls.ListItem)
            If wItem.Value = pValor Then
                pCombo.SelectedIndex = f
                wMarcou = True
                Exit For
            End If
        Next f

        If wMarcou = False Then pCombo.SelectedIndex = 0
        'pCombo.SelectedIndex = pCombo.Items.IndexOf(pCombo.Items.FindByValue(pValor))

    End Sub

    Function PreencheCheckedList(ByVal pObjCombo As Object, ByRef pConexao As SqlClient.SqlConnection, _
                          ByVal pSQL As String, ByVal pSelected As Boolean) As Integer

        pObjCombo.Items.Clear()
        pObjCombo.refresh()

        Dim wDataReader As SqlDataReader
        Dim wComando As New SqlCommand

        wComando.Connection = pConexao
        wComando.CommandType = CommandType.Text

        Try

            Dim b As New System.Web.UI.WebControls.ListItem
            'b.Value = ""
            'b.Text = " Selecione..."
            'pObjCombo.Items.Add(b)

            wComando.CommandText = pSQL
            If pSQL <> "" Then
                wDataReader = wComando.ExecuteReader()

                While wDataReader.Read()

                    If wDataReader.FieldCount = 1 Then

                        If Not (IsDBNull(wDataReader(0))) Then

                            Dim a As New System.Web.UI.WebControls.ListItem
                            A.Value = wDataReader(0)
                            A.Text = wDataReader(0)
                            A.Selected = pSelected
                            pObjCombo.Items.Add(a)

                        End If
                    Else
                        If Not (IsDBNull(wDataReader(0))) And Not (IsDBNull(wDataReader(1))) Then

                            Dim a As New System.Web.UI.WebControls.ListItem
                            A.Value = wDataReader(0)
                            A.Text = wDataReader(1)
                            A.Selected = pSelected
                            pObjCombo.Items.Add(a)

                        End If

                    End If
                End While

                wDataReader.Close()
            End If

        Catch ex As Exception
            gUltimoSQL = wComando.CommandText
            gDescricaoUltimoErro = ex.Message

            PreencheCheckedList = -1
            Exit Function
        End Try

        PreencheCheckedList = 0
    End Function

    Function PreencheComboBox(ByVal pObjCombo As Object, ByRef pConexao As SqlClient.SqlConnection, _
                            ByVal pSQL As String, ByVal pSelected As String) As Integer
        '
        ' Preenche um combobox com um comando SQL, podendo passar Codigo e Valor,
        ' Alem do Codigo a ser selecionado (pSelected)

        pObjCombo.Items.Clear()
        pObjCombo.refresh()

        Dim wDataReader As SqlDataReader
        Dim wComando As New SqlCommand

        wComando.Connection = pConexao
        wComando.CommandType = CommandType.Text

        Try
            '
            ' Coloca o valor padrao "selecione..." 

            Dim b As New System.Web.UI.WebControls.ListItem
            b.Value = ""
            b.Text = " Selecione..."
            pObjCombo.Items.Add(b)

            wComando.CommandText = pSQL
            If pSQL <> "" Then
                wDataReader = wComando.ExecuteReader()

                While wDataReader.Read()

                    If wDataReader.FieldCount = 1 Then

                        If Not (IsDBNull(wDataReader(0))) Then

                            Dim a As New System.Web.UI.WebControls.ListItem
                            A.Value = wDataReader(0)
                            A.Text = wDataReader(0)
                            pObjCombo.Items.Add(a)

                            If pSelected <> "" And A.Text = pSelected Then
                                pSelected = A.Value
                            End If
                        End If
                    Else
                        If Not (IsDBNull(wDataReader(0))) And Not (IsDBNull(wDataReader(1))) Then

                            Dim a As New System.Web.UI.WebControls.ListItem
                            A.Value = wDataReader(0)
                            A.Text = wDataReader(1)
                            pObjCombo.Items.Add(a)

                            If pSelected <> "" And A.Text = pSelected Then
                                pSelected = A.Value
                            End If
                        End If

                    End If
                End While

                wDataReader.Close()
            End If

            '
            ' Seta o valor selecionado no combobox

            If (Not (IsDBNull(pSelected))) And pSelected <> "" Then
                SetaComboBox(pObjCombo, pSelected)
            End If

        Catch ex As Exception

            gUltimoSQL = wComando.CommandText
            gDescricaoUltimoErro = ex.Message
            objVariaveisGlobais.MostraErro()
            PreencheComboBox = -1
            Exit Function

        End Try

        PreencheComboBox = 0

    End Function

    Public Sub MostraErro()
        '
        ' Mostra erro na tela e salva o erro em um arquivo de Log

        SalvaLogErro("Ultimo SQL: " & gUltimoSQL & vbCrLf & gDescricaoUltimoErro & vbCrLf & gStackTraceErro)
        MessageBox.Show("Ocorreu um erro inexperado: " & gUltimoSQL & vbCrLf & vbCrLf & gDescricaoUltimoErro & vbCrLf & gStackTraceErro & vbCrLf & vbCrLf & " O erro foi salvo em um arquivo de log e o programa tentará continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Public Sub MostraErroWeb()
        '
        ' Mostra erro na tela e salva o erro em um arquivo de Log

        SalvaLogErro("Ultimo SQL: " & gUltimoSQL & vbCrLf & gDescricaoUltimoErro & vbCrLf & gStackTraceErro)

    End Sub

    Public Sub SalvaLogErro(ByVal pDado As String)
        '
        ' Salva arquivo de Log com erros

        Dim wDado As String
        Dim wNomeArquivoLog As String

        Try
            '
            ' Busca ApP.Path e diretório de Erros

            If gAppPath = "" Or IsNothing(gAppPath) Then
                gAppPath = AppPath()
            End If

            If Not Directory.Exists(gAppPath & "Erros") Then
                Directory.CreateDirectory(gAppPath & "Erros")
            End If
            '
            ' Monta dado e nome do arquivo

            wDado = Format(Now(), "hh:mm:ss") & " - " & pDado
            wNomeArquivoLog = AppPath() & "Erros\C_" & Format(Now(), "ddMMyyyy") & ".Txt"
            '
            ' Salva arquivo
            Dim sw As New System.IO.StreamWriter(wNomeArquivoLog, True)
            sw.Write(wDado & vbCrLf & vbCrLf)
            sw.Close()

        Catch e As Exception
        Finally
            'If Not IsNothing(sw) Then sw.Close()
        End Try

    End Sub

    Public Shared Function AppPath() As String
        '
        ' Pega o ApP.Path

        Try
            Dim mAppPath As String
            mAppPath = System.Reflection.Assembly.GetExecutingAssembly.Location
            mAppPath = mAppPath.Substring(0, mAppPath.LastIndexOf("\"))
            Return mAppPath & "\"
        Catch
        End Try
        Return ""

    End Function

    Public Function AdicionaAND(ByVal pString As String)
        '
        ' Adiciona um AND no inicio da string se não tiver e se ela não for vazia

        If pString <> "" Then
            If pString.Substring(0, 4) <> " AND" Then
                Return " AND " & pString
            Else
                Return pString
            End If
        Else
            Return pString
        End If

    End Function

    Public Sub InicializaVetorErros()
        Dim f As Integer
        For f = 0 To 39
            gErroTela(f) = ""
        Next
    End Sub

#End Region

#Region " Métodos "

    Public Function IncluirC_LOG(ByVal pTabela As String, ByVal pTabela1 As String, _
        ByVal pChave As String, ByVal pCampo As String, ByVal pInfoAntigo As String, _
        ByRef pConexao As SqlClient.SqlConnection, ByVal pComando As SqlCommand) As Integer

        pComando.CommandText = "INSERT INTO " & pTabela & " ( " & _
        " Tabela, " & _
        " Chave, " & _
        " DataHora, " & _
        " Usuario, " & _
        " Campo, " & _
        " InfoAntigo " & _
        "     ) VALUES (" & _
        "    '" & pTabela1 & "', " & _
        "    '" & pChave & "', " & _
        "    '" & CDate(Date.Now) & "',       " & _
        "    '" & gLoginUsuario & "', " & _
        "    '" & pCampo & "', " & _
        "   '" & pInfoAntigo.Replace("'", "") & "')   "

        pComando.ExecuteNonQuery()

    End Function

    Public Function UploadArquivo(ByVal _FileName As String, ByVal _UploadPath As String, ByVal _FTPUser As String, _
                   ByVal _FTPPass As String, Optional ByRef pProgressBar As ProgressBar = Nothing, _
                   Optional ByRef plblPercentual As Label = Nothing, _
                   Optional ByRef plblTempo As Label = Nothing) As Integer
        Try

            Dim _FileInfo As New System.IO.FileInfo(_FileName)

            ' Create FtpWebRequest object from the Uri provided
            Dim _FtpWebRequest As System.Net.FtpWebRequest = CType(System.Net.FtpWebRequest.Create(New Uri(_UploadPath)), System.Net.FtpWebRequest)

            ' Provide the WebPermission Credintials
            _FtpWebRequest.Credentials = New System.Net.NetworkCredential(_FTPUser, _FTPPass)

            ' By default KeepAlive is true, where the control connection is not closed
            ' after a command is executed.
            _FtpWebRequest.KeepAlive = False

            ' set timeout for 20 seconds = 20000
            _FtpWebRequest.Timeout = 300000

            ' Specify the command to be executed.
            _FtpWebRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile

            ' Specify the data transfer type.
            _FtpWebRequest.UseBinary = True

            ' Notify the server about the size of the uploaded file
            _FtpWebRequest.ContentLength = _FileInfo.Length

            ' The buffer size is set to 2kb
            Dim buffLength As Integer = 2048
            Dim buff(buffLength - 1) As Byte

            ' Opens a file stream (System.IO.FileStream) to read the file to be uploaded
            Dim _FileStream As System.IO.FileStream = _FileInfo.OpenRead()

            If Not pProgressBar Is Nothing Then
                pProgressBar.Minimum = 0
                pProgressBar.Maximum = _FileInfo.Length
            End If

            Try
                ' Stream to which the file to be upload is written
                Dim _Stream As System.IO.Stream = _FtpWebRequest.GetRequestStream()

                ' Read from the file stream 2kb at a time
                Dim contentLen As Integer = _FileStream.Read(buff, 0, buffLength)

                ' Till Stream content ends
                Dim wTamanhoTotalArquivo As Integer = _FileInfo.Length
                Dim wTamanhoBaixado As Integer = 0
                Dim wDataInicio As Date = Date.Now
                Dim wPercentual As Decimal = 0
                pProgressBar.Value = 0.1
                Do While contentLen <> 0
                    ' Write Content from the file stream to the FTP Upload Stream
                    _Stream.Write(buff, 0, contentLen)
                    contentLen = _FileStream.Read(buff, 0, buffLength)
                    If Not pProgressBar Is Nothing Then
                        If pProgressBar.Value + buffLength < pProgressBar.Maximum Then
                            pProgressBar.Value += buffLength
                            wTamanhoBaixado = pProgressBar.Value
                            Try
                                wPercentual = (pProgressBar.Value * 100) / pProgressBar.Maximum
                            Catch ex As Exception
                            End Try
                            plblPercentual.Text = Math.Round(wPercentual, 2) & "%"
                            plblTempo.Text = TempoRestanteEstimado(pProgressBar, wDataInicio)
                            Application.DoEvents()
                        End If
                    End If
                Loop
                plblPercentual.Text = Math.Round(100, 2) & "%"

                ' Close the file stream and the Request Stream
                _Stream.Close()
                _Stream.Dispose()
                _FileStream.Close()
                _FileStream.Dispose()
            Catch ex As Exception
                Return 21
                MessageBox.Show(ex.Message, "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Return 0
        Catch ex As Exception
            objVariaveisGlobais.gDescricaoUltimoErro = ex.Message.ToString
            Return -1
        End Try
    End Function

#End Region

End Class

