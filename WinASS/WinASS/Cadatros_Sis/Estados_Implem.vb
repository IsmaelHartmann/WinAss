Imports System.Data.SqlClient

Public Class Estados_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    Private mNome As String
    Private mSiglaEstado As String
    Private mDataCadastro As String
    Private mUsuarioCadastro As String

    Private wComando As SqlCommand
    Private wDataReader As SqlDataReader
    Public wDataSet As DataSet

#End Region

#Region " Propriedades "

    Public Property Nome() As String
        Get
            Return mNome
        End Get
        Set(ByVal Value As String)
            mNome = Value
        End Set
    End Property
    Public Property SiglaEstado() As String
        Get
            Return mSiglaEstado
        End Get
        Set(ByVal Value As String)
            mSiglaEstado = Value
        End Set
    End Property
    Public Property DataCadastro() As String
        Get
            Return mDataCadastro
        End Get
        Set(ByVal Value As String)
            mDataCadastro = Value
        End Set
    End Property
    Public Property UsuarioCadastro() As String
        Get
            Return mUsuarioCadastro
        End Get
        Set(ByVal Value As String)
            mUsuarioCadastro = Value
        End Set
    End Property

#End Region

#Region " Métodos "

    Public Sub New()
        wComando = New SqlCommand("", VariaveisGlobais.gConexao)
    End Sub

    Public Sub New(ByVal pobjVariaveisGlobais As VariaveisGlobais)
        objVariaveisGlobais = pobjVariaveisGlobais
        wComando = New SqlCommand("", VariaveisGlobais.gConexao)
    End Sub

    Public Function BuscarEstado() As Integer

        If mSiglaEstado = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "CadastroEstados_Implem->BuscarEstado()"
            Return -1
        End If

        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM C_Estados WHERE SiglaEstado = '" & mSiglaEstado & "'"
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mNome = IIf(IsDBNull(wDataReader("Nome")), "", wDataReader("Nome"))
                mSiglaEstado = IIf(IsDBNull(wDataReader("SiglaEstado")), "", wDataReader("SiglaEstado"))
                mDataCadastro = IIf(IsDBNull(wDataReader("Data_Hora_Cadastro")), "", wDataReader("Data_Hora_Cadastro"))
                mUsuarioCadastro = IIf(IsDBNull(wDataReader("Codigo_Usuario_Cadastro")), "", wDataReader("Codigo_Usuario_Cadastro"))
            Else
                wDataReader.Close()
                Return 1
            End If
            wDataReader.Close()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function IncluirEstado() As Integer
        Try

            Dim wControle As Integer

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "IncluirEstado")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = "INSERT INTO C_Estados (SiglaEstado,     " & _
                                         " Nome,  " & _
                                         " Codigo_Usuario_Cadastro,  " & _
                                         " Data_Hora_Cadastro  " & _
                                         "    ) VALUES (" & _
                                         "  '" & mSiglaEstado & "',   " & _
                                         "  '" & mNome & "', " & _
                                         "  '" & mUsuarioCadastro & "', " & _
                                         "  '" & Date.Now & "' )  "
                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("IncluirEstado")
                Throw ex
            End Try

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function AlterarEstado() As Integer
        Dim wControle As Integer

        If mSiglaEstado = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para alteração!"
            VariaveisGlobais.gStackTraceErro = "Estados_Implem->AlterarEstado()"
            Return -1
        End If
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            '**** Inicio Codigo Novo **************************************************
            Dim wSet As String = ""
            Dim wLog As String = ""

            wComando.CommandText = "SELECT * FROM C_Estados WHERE SiglaEstado ='" & mSiglaEstado & "'"

            wDataReader = wComando.ExecuteReader
            If Not wDataReader.Read() Then
                wDataReader.Close()
                Return 1
            End If

            If mNome <> wDataReader("Nome") Then
                wSet = wSet & ", Nome = '" & mNome & "'"
                wLog = wLog & "|Nome\" & wDataReader("Nome")
            End If

            wDataReader.Close()
            If Len(wSet) > 0 Then wSet = wSet.Substring(1, Len(wSet) - 1)
            If Len(wLog) > 0 Then wLog = wLog.Substring(1, Len(wLog) - 1)

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "AlterarEstado")
            wComando.Transaction = wTransacao

            Try
                If Len(wSet) > 0 Then
                    wComando.CommandText = _
                          " UPDATE C_Estados SET " & wSet & " WHERE " & _
                          "  SiglaEstado = '" & mSiglaEstado & "'"

                    wComando.ExecuteNonQuery()
                    Dim Log As String = "C_LOG"
                    Dim Tab As String = "C_Estados"
                    Dim Chave As String = mSiglaEstado
                    Dim aLog As Array = wLog.Split("|")
                    Dim aReg As Array
                    Dim i As Integer
                    For i = 0 To aLog.Length.ToString - 1
                        Dim x As String = aLog(i)
                        aReg = aLog(i).Split("\")
                        objVariaveisGlobais.IncluirC_LOG(Log, Tab, Chave, aReg(0), aReg(1), VariaveisGlobais.gConexao, wComando)
                    Next
                    wTransacao.Commit()
                End If
            Catch ex As Exception
                wTransacao.Rollback("AlterarEstado")
                Throw ex
            End Try

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Private Function VerificaDependenciasEstado() As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = "SELECT * FROM C_Cidades WHERE SiglaEstado ='" & mSiglaEstado & "'" & _
                                   " AND isnull(Data_Hora_Exclusao,'') = '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                wDataReader.Close()
                VariaveisGlobais.gDescricaoUltimoErro = " Estado é usado por Cidades!"
                Return 2
            End If
            wDataReader.Close()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Private Function VerificaDependenciasEstadoFilial() As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = "SELECT * FROM C_Filiais WHERE SiglaEstado ='" & mSiglaEstado & "'" & _
                                    " AND isnull(Data_Hora_Exclusao,'') = '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                wDataReader.Close()
                VariaveisGlobais.gDescricaoUltimoErro = " Estado é usado em Filiais!"
                Return 2
            End If
            wDataReader.Close()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function ExcluirEstado() As Integer

        Try
            Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim wDataSet As DataSet = New DataSet

            If mSiglaEstado = "" Then
                VariaveisGlobais.gUltimoSQL = ""
                VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para exclusão!"
                VariaveisGlobais.gStackTraceErro = "Estados_Implem->ExcluirEstado()"
                Return -1
            End If

            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wControle = VerificaDependenciasEstado()
            If wControle <> 0 Then Return wControle

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ExcluirEstado")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = " UPDATE C_Estados SET " & _
                                    " Codigo_Usuario_Exclusao ='" & VariaveisGlobais.gCodigoUsuario & "',    " & _
                                    " Data_Hora_Exclusao ='" & Date.Now & "'    " & _
                                    " WHERE    " & _
                                    " SiglaEstado = '" & mSiglaEstado & "'"

                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("ExcluirEstado")
            End Try

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function MostraTabelaEstados(ByRef pObjTabela As System.Windows.Forms.DataGridView, _
               ByVal pSQL As String) As Integer

        Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
        wDataSet = New DataSet
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle < 0 Then
                Return wControle
            End If
            pObjTabela.DataSource = Nothing
            pObjTabela.Refresh()

            wComando.CommandText = pSQL
            wDataAdapter.SelectCommand = wComando
            wDataAdapter.Fill(wDataSet, "TABLE")
            wDataAdapter.Dispose()

            wDataSet.Tables(0).Columns(0).ColumnName = "UF"
            wDataSet.Tables(0).Columns(1).ColumnName = "Nome"

            Dim wDataTable As New DataTable()
            wDataTable = wDataSet.Tables(0)

            wDataTable.Columns.Add("Altera", GetType(Image))
            Dim wicon As Image = Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "lupa.gif")
            For i As Integer = 0 To wDataTable.Rows.Count - 1
                wDataTable.Rows(i)(2) = wicon
            Next

            Dim wDataView = New DataView(wDataTable, "", "", DataViewRowState.CurrentRows)

            pObjTabela.Columns.Clear()
            pObjTabela.DataSource = wDataView

            If CDec(pObjTabela.Tag) = 0 Then pObjTabela.Tag = "1" '/ CDec(pObjTabela.Tag)
            pObjTabela.Columns(0).Width = 80 / CDec(pObjTabela.Tag) 'Sigla Estado
            pObjTabela.Columns(1).Width = 250 / CDec(pObjTabela.Tag) 'Nome Estado
            pObjTabela.Columns(2).Width = 30 / CDec(pObjTabela.Tag) 'Lupa

            pObjTabela.RowHeadersWidth = 10

            For i As Integer = 0 To 2
                pObjTabela.Columns(i).ReadOnly = True
            Next

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

#End Region

End Class