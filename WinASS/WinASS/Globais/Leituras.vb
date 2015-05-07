Imports System.Web
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.GlobalizatioN.DateTimeFormatInfo

Public Class Leituras

#Region " Leituras para uso geral "

    Public Function VerificaSeFeriado(ByVal pEstado As String, ByVal pCidade As String, _
           ByVal pData As String, ByRef pNome As String) As Integer
        Dim wControle As Integer
        Dim wDataReader As SqlDataReader
        Dim wComando As New SqlCommand
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.Connection = VariaveisGlobais.gConexao
            wComando.CommandType = CommandType.Text
            pData = ConverteDataParaString(pData)
            wComando.CommandText = _
                " SET DATEFORMAT DMY " & _
                " SELECT Nome " & _
                " FROM C_Feriados "
            If pData.Substring(0, 5) = "29/02" Then
                wComando.CommandText += " WHERE (Data='" & pData & "' )"
            Else
                wComando.CommandText += " WHERE (Data='" & pData & "' or Data='" & pData.Substring(0, 6) & "9998" & "')"
            End If
            wComando.CommandText += " AND ((SiglaEstado='' AND CodigoCidade=0) " & _
                " OR  (SiglaEstado='" & pEstado & "' AND CodigoCidade=0) " & _
                " OR  (SiglaEstado='" & pEstado & "' AND CodigoCidade=" & pCidade & ") )"

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                pNome = wDataReader("Nome")
                wDataReader.Close()
            Else
                wDataReader.Close()
                Return 1
            End If
            Return 0

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 1
    End Function

    Public Function BuscarProximoDiaUtil(ByRef pDataAtual As String, _
           ByVal pEstado As String, ByVal pCidade As Integer, _
           Optional ByVal pFreCli As Array = Nothing, _
           Optional ByRef pTeveFeriadoQRecebeCli As String = "", _
           Optional ByVal pFreTrans As Array = Nothing, _
           Optional ByRef pTeveFeriadoQRecebeTrans As String = "") As Integer

        Try
            Dim wControle As Integer
            Dim wLoop As Integer = 0
            pDataAtual = DateAdd(DateInterval.Day, 1, CDate(pDataAtual))

            Dim i As Integer
            Dim wDiaSem As String
            Dim wDiaSemn As String() = "SEG|TER|QUA|QUI|SEX".Split("|")

            While wLoop = 0
                If CurrentInfo.GetDayName(CDate(pDataAtual).DayOfWeek).ToUpper = "SÁBADO" Then
                    pDataAtual = DateAdd(DateInterval.Day, 2, CDate(pDataAtual))
                ElseIf CurrentInfo.GetDayName(CDate(pDataAtual).DayOfWeek).ToUpper = "DOMINGO" Then
                    pDataAtual = DateAdd(DateInterval.Day, 1, CDate(pDataAtual))
                Else
                    wControle = VerificaSeFeriado(pEstado, pCidade, pDataAtual, "")
                    If wControle = 0 Then
                        'É feriado
                        If Not IsNothing(pFreCli) AndAlso pTeveFeriadoQRecebeCli = "N" Then
                            wDiaSem = CurrentInfo.GetDayName(CDate(pDataAtual).DayOfWeek).Substring(0, 3).ToUpper
                            i = Array.IndexOf(wDiaSemn, wDiaSem)
                            If pFreCli(i) = "S" Then
                                pTeveFeriadoQRecebeCli = "S"
                            End If
                        End If
                        If Not IsNothing(pFreTrans) AndAlso pTeveFeriadoQRecebeTrans = "N" Then
                            wDiaSem = CurrentInfo.GetDayName(CDate(pDataAtual).DayOfWeek).Substring(0, 3).ToUpper
                            i = Array.IndexOf(wDiaSemn, wDiaSem)
                            If pFreTrans(i) = "S" Then
                                pTeveFeriadoQRecebeTrans = "S"
                            End If
                        End If
                        pDataAtual = DateAdd(DateInterval.Day, 1, CDate(pDataAtual))
                    Else
                        Exit While
                    End If
                End If
            End While

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 1
    End Function

    Public Function BuscaParametros(ByRef pConexao As SqlClient.SqlConnection) As Integer

        Dim wDataReader As SqlDataReader
        Dim wComando As New SqlCommand
        Try
            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.Connection = pConexao
            wComando.CommandType = CommandType.Text
            wComando.CommandText = _
                "SELECT * FROM C_Parametros"

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
               
                wDataReader.Close()
                Return 0
            End If
            wDataReader.Close()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = "Leituras->BuscaEmpresaBase()"
            Return -1
            Exit Function
        End Try
        Return 1
    End Function

    Public Function BuscaSiglaEstadoNomedaCidade(ByVal pCodigoCidade As String, ByRef pConexao As SqlClient.SqlConnection, ByRef pSiglaEstado As String, ByRef pNomeCidade As String) As Integer
        If pCodigoCidade = "" Then
            Return 1
        End If
        Dim wDataReader As SqlDataReader
        Dim wComando As New SqlCommand


        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.Connection = pConexao
            wComando.CommandType = CommandType.Text

            wComando.CommandText = "SELECT SiglaEstado,NomeCidade FROM C_Cidades WHERE " & _
                                    " CodigoCidade=" & pCodigoCidade

            wDataReader = wComando.ExecuteReader

            If wDataReader.Read() Then
                pSiglaEstado = IIf(IsDBNull(wDataReader("SiglaEstado")), 0, wDataReader("SiglaEstado"))
                pNomeCidade = IIf(IsDBNull(wDataReader("NomeCidade")), 0, wDataReader("NomeCidade"))
                wDataReader.Close()
                Return 0
            End If
            wDataReader.Close()

        Catch ex As Exception

            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = "Leituras->BuscaSiglaEstadoNomedaCidade()"
            Return -1
            Exit Function

        End Try
        Return 1
    End Function

    Public Function BuscaSiglaEstado_e_CidadeFilial(ByVal pCodigoEmpresa As String, ByVal pCodigoFilial As String, ByRef pConexao As SqlClient.SqlConnection, ByRef pSiglaEstado As String, ByRef pNomeFilial As String, ByRef pCNPJ As String, ByRef pIE As String) As Integer

        Dim wDataReader As SqlDataReader
        Dim wComando As New SqlCommand
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.Connection = pConexao
            wComando.CommandType = CommandType.Text

            wComando.CommandText = "SELECT C.NomeCidade, C.SiglaEstado, F.CNPJ, F.InscricaoEstadual " & _
            " FROM C_Filiais F, C_Cidades C WHERE F.CodigoEmpresa= " & pCodigoEmpresa & _
            " AND F.CodigoFilial = " & pCodigoFilial & " AND F.CodigoCidade = C.CodigoCidade  "

            wDataReader = wComando.ExecuteReader

            If wDataReader.Read() Then
                pSiglaEstado = IIf(IsDBNull(wDataReader("SiglaEstado")), 0, wDataReader("SiglaEstado"))
                pNomeFilial = IIf(IsDBNull(wDataReader("NomeCidade")), 0, wDataReader("NomeCidade"))
                pCNPJ = IIf(IsDBNull(wDataReader("CNPJ")), 0, wDataReader("CNPJ"))
                pIE = IIf(IsDBNull(wDataReader("InscricaoEstadual")), 0, wDataReader("InscricaoEstadual"))
                wDataReader.Close()
                Return 0
            End If
            wDataReader.Close()

        Catch ex As Exception

            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = "Leituras->BuscaSiglaEstadoNomedaFilial()"
            Return -1
            Exit Function

        End Try
        Return 1
    End Function

    Public Function BuscaNomeEmpresa(ByRef pConexao As SqlClient.SqlConnection, ByVal pCodigoEmpresa As String, ByRef pNomeEmpresa As String) As Integer

        Dim wDataReader As SqlDataReader
        Dim wComando As New SqlCommand
        Try
            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.Connection = pConexao
            wComando.CommandType = CommandType.Text
            wComando.CommandText = " SELECT Nome FROM C_Empresas WHERE " & _
                                   " Codigo=" & pCodigoEmpresa

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                pNomeEmpresa = IIf(IsDBNull(wDataReader("Nome")), "", wDataReader("Nome"))
                wDataReader.Close()
                Return 0
            End If
            wDataReader.Close()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = "Leituras->BuscaNomeEmpresa()"
            Return -1
            Exit Function
        End Try
        Return 1
    End Function

    Public Function BuscaNomeFilial_e_SiglaEstado(ByRef pConexao As SqlClient.SqlConnection, ByVal pCodigoEmpresa As String, ByVal pCodigoFilial As String, ByRef pNomeFilial As String) As Integer

        Dim wDataReader As SqlDataReader
        Dim wComando As New SqlCommand
        Try
            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.Connection = pConexao
            wComando.CommandType = CommandType.Text
            wComando.CommandText = "SELECT NomeFilial " & _
                                    " FROM C_Filiais F " & _
                                    " WHERE CodigoEmpresa=" & pCodigoEmpresa & _
                                    "  AND  CodigoFilial=" & pCodigoFilial
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                pNomeFilial = IIf(IsDBNull(wDataReader("NomeFilial")), 0, wDataReader("NomeFilial"))
                wDataReader.Close()
                Return 0
            End If
            wDataReader.Close()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = "Leituras->BuscaNomeFilial()"
            Return -1
            Exit Function
        End Try
        Return 1
    End Function

    Public Function VerificaExistenciaFilial(ByRef pConexao As SqlClient.SqlConnection, ByVal pEmpresa As String, ByVal pFilial As String) As Integer
        Dim wDataReader As SqlDataReader
        Dim wComando As New SqlCommand
        Try
            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.Connection = pConexao
            wComando.CommandType = CommandType.Text
            wComando.CommandText = "SELECT * FROM C_Filiais WHERE " & _
                                   " CodigoEmpresa='" & pEmpresa & "' " & _
                                   " AND CodigoFilial='" & pFilial & "'" & _
                             " AND isnull(Data_Hora_Exclusao,'') = '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                wDataReader.Close()
                Return 0
            End If
            wDataReader.Close()

        Catch ex As Exception

            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = "Leituras->VerificaExistenciaFilial()"
            Return -1
        End Try
        Return 1
    End Function

    Public Function VerificaExistenciaEmpresa(ByRef pConexao As SqlClient.SqlConnection, ByVal pEmpresa As String) As Integer
        Dim wDataReader As SqlDataReader
        Dim wComando As New SqlCommand
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.Connection = pConexao
            wComando.CommandType = CommandType.Text
            wComando.CommandText = "SELECT * FROM C_Empresas WHERE " & _
                                   " Codigo='" & pEmpresa & "'" & _
                             " AND isnull(Data_Hora_Exclusao,'') = '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                wDataReader.Close()
                Return 0
            End If
            wDataReader.Close()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = "Leituras->VerificaExistenciaEmpresa()"
            Return -1
        End Try
        Return 1
    End Function

    Public Function BuscarEstado(ByVal pSiglaEstado As String, ByRef pConexao As SqlClient.SqlConnection, ByRef pNomeEstado As String) As Integer
        Dim wControle As Integer
        Dim wDataReader As SqlDataReader
        Dim wComando As New SqlCommand

        Try
            wComando.Connection = pConexao
            wComando.CommandType = CommandType.Text

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = "SELECT * FROM C_Estados WHERE SiglaEstado='" & pSiglaEstado & "'"
            wDataReader = wComando.ExecuteReader

            If wDataReader.Read() Then
                pNomeEstado = IIf(IsDBNull(wDataReader("Nome")), "", wDataReader("Nome"))
                wDataReader.Close()
                Return 0
            End If
            wDataReader.Close()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = "Leituras->BuscarEstado()"
            Return -1
            Exit Function
        End Try
        Return 1
    End Function

    Public Function BuscarSetor(ByVal pSetor As String, ByRef pConexao As SqlClient.SqlConnection, ByRef pNomeSetor As String) As Integer
        Dim wControle As Integer
        Dim wDataReader As SqlDataReader
        Dim wComando As New SqlCommand

        Try
            wComando.Connection = pConexao
            wComando.CommandType = CommandType.Text

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = "SELECT * FROM C_Setores WHERE Codigo='" & pSetor & "'"
            wDataReader = wComando.ExecuteReader

            If wDataReader.Read() Then
                pNomeSetor = IIf(IsDBNull(wDataReader("Nome")), "", wDataReader("Nome"))
                wDataReader.Close()
                Return 0
            End If
            wDataReader.Close()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = "Leituras->BuscarEstado()"
            Return -1
            Exit Function
        End Try
        Return 1
    End Function

    Public Sub VerC_LOG(ByVal pBanco As String, ByVal pTabela As String, ByVal pTabela1 As String, ByVal pChave As String)
        pChave = pChave.Trim
        If pChave <> "" Then
            If pChave.Substring(Len(pChave) - 1, 1) <> "|" Then
                Dim objConsultaLog_Implem As ConsultaLog_Implem = ConsultaLogBOFactory.GetFactory().GetInstance()


                objConsultaLog_Implem.Banco = pBanco
                objConsultaLog_Implem.Tabela = pTabela
                objConsultaLog_Implem.Tabela1 = pTabela1
                objConsultaLog_Implem.Chave = pChave

                Dim a As New ConsultaLog
                a.ShowDialog()
                a.Dispose()
            End If
        End If
    End Sub

    Public Function BuscarDadosFilial(ByRef pConexao As SqlClient.SqlConnection, _
        ByVal pEmpresa As String, ByVal pFilial As String, _
        ByRef pCNPJ As String, ByRef pInscricaoEstadual As String, ByRef pNomeFilial As String, _
        ByRef pEndereco As String, ByRef pComplemento As String, ByRef pBairro As String, _
        ByRef pSiglaEstado As String, ByRef pCodigoCidade As String, ByRef pCEP As String, _
        ByRef pNomeCidade As String, ByRef pTelefone As String, ByRef pFax As String, _
        ByRef pDataJunta As String, ByRef pNumeroJunta As String, Optional ByRef pDataEstoque As String = "") As Integer

        Dim wDataReader As SqlDataReader
        Dim wComando As New SqlCommand
        Try
            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.Connection = pConexao
            wComando.CommandType = CommandType.Text
            wComando.CommandText = _
                        "   SELECT *, C.NomeCidade " & _
                        "   FROM C_Filiais F, C_Cidades C" & _
                        "   WHERE CodigoEmpresa = " & pEmpresa & _
                        "   AND CodigoFilial = " & pFilial & _
                        "   AND F.CodigoCidade = C.CodigoCidade "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                pCNPJ = IIf(IsDBNull(wDataReader("CNPJ")), "", wDataReader("CNPJ"))
                pInscricaoEstadual = IIf(IsDBNull(wDataReader("InscricaoEstadual")), "", wDataReader("InscricaoEstadual"))
                pNomeFilial = IIf(IsDBNull(wDataReader("NomeFilial")), "", wDataReader("NomeFilial"))
                pEndereco = IIf(IsDBNull(wDataReader("Endereco")), "", wDataReader("Endereco"))
                pComplemento = IIf(IsDBNull(wDataReader("Complemento")), "", wDataReader("Complemento"))
                pBairro = IIf(IsDBNull(wDataReader("Bairro")), "", wDataReader("Bairro"))
                pSiglaEstado = IIf(IsDBNull(wDataReader("SiglaEstado")), "", wDataReader("SiglaEstado"))
                pCodigoCidade = IIf(IsDBNull(wDataReader("CodigoCidade")), "", wDataReader("CodigoCidade"))
                pCEP = IIf(IsDBNull(wDataReader("CEP")), "", wDataReader("CEP"))
                pNomeCidade = IIf(IsDBNull(wDataReader("NomeCidade")), "", wDataReader("NomeCidade"))
                pTelefone = IIf(IsDBNull(wDataReader("Telefone")), "", wDataReader("Telefone"))
                pFax = IIf(IsDBNull(wDataReader("Fax")), "", wDataReader("Fax"))
                pDataJunta = IIf(IsDBNull(wDataReader("DataJunta")), "", wDataReader("DataJunta"))
                pNumeroJunta = IIf(IsDBNull(wDataReader("NumeroJunta")), "", wDataReader("NumeroJunta"))
                pDataEstoque = IIf(IsDBNull(wDataReader("DataEstoque")), "", wDataReader("DataEstoque"))
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


    'Public Function VerificaProdutoEstoque(ByVal pIdProduto As String, Optional ByVal pComando As SqlCommand = Nothing) As Boolean
    '    Dim wDataReader1 As SqlDataReader
    '    If IsNothing(pComando) Then

    '        Dim wComando As New SqlCommand
    '        Try
    '            Dim wControle As Integer
    '            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
    '            If wControle <> 0 Then Return wControle

    '            wComando.Connection = VariaveisGlobais.gConexao
    '            wComando.CommandType = CommandType.Text
    '            wComando.CommandText = " SELECT Top 1 * FROM CES_MovProdutos WHERE " & _
    '                                   " Produto='" & pIdProduto & "' "

    '            wDataReader1 = wComando.ExecuteReader
    '            If wDataReader1.Read() Then
    '                wDataReader1.Close()
    '                Return True
    '            End If
    '            wDataReader1.Close()

    '        Catch ex As Exception
    '            VariaveisGlobais.gUltimoSQL = wComando.CommandText
    '            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
    '            VariaveisGlobais.gStackTraceErro = "Leituras->VerificaProdutoEstoque()"
    '            Return False
    '        End Try
    '        Return False
    '    Else

    '        pComando.CommandText = " SELECT Top 1 * FROM CES_MovProdutos WHERE " & _
    '                                              " Produto='" & pIdProduto & "' "

    '        wDataReader1 = pComando.ExecuteReader
    '        If wDataReader1.Read() Then
    '            wDataReader1.Close()
    '            Return True
    '        End If
    '        wDataReader1.Close()
    '        Return False
    '    End If
    'End Function



#End Region

End Class


