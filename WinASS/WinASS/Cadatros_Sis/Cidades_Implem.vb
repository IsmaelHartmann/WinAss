Imports System.Data.SqlClient

Public Class Cidades_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    Private mCodigoCidade As Integer
    Private mNomeCidade As String
    Private mSiglaEstado As String
    Private mDataCadastro As String
    Private mUsuarioCadastro As String

    Private wComando As SqlCommand
    Private wDataReader As SqlDataReader
    Public wDataSet As DataSet

#End Region

#Region " Propriedades "

    Public Property CodigoCidade() As Integer
        Get
            Return mCodigoCidade
        End Get
        Set(ByVal Value As Integer)
            mCodigoCidade = Value
        End Set
    End Property
    Public Property NomeCidade() As String
        Get
            Return mNomeCidade
        End Get
        Set(ByVal Value As String)
            mNomeCidade = Value
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

    Public Function BuscarCidade() As Integer

        If mCodigoCidade = 0 Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "CadastroCidades_Implem->BuscarCidade()"
            Return -1
        End If

        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM C_Cidades WHERE CodigoCidade = '" & mCodigoCidade & "'"
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mCodigoCidade = wDataReader("CodigoCidade")
                mNomeCidade = IIf(IsDBNull(wDataReader("NomeCidade")), "", wDataReader("NomeCidade"))
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

    Public Function IncluirCidade() As Integer
        Try

            Dim wControle As Integer

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = " SELECT isnull(max(cast(CodigoCidade as integer)),0)+1 CodigoCidade " & _
                               " FROM C_Cidades where isnumeric(CodigoCidade)<>0 "
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mCodigoCidade = wDataReader("CodigoCidade")
            Else
                mCodigoCidade = 1
            End If
            wDataReader.Close()

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "IncluirCidade")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = "INSERT INTO C_Cidades (CodigoCidade,     " & _
                                         " NomeCidade,  " & _
                                         " SiglaEstado,                      " & _
                                         " Codigo_Usuario_Cadastro,  " & _
                                         " Data_Hora_Cadastro  " & _
                                         "    ) VALUES (" & _
                                         "  " & mCodigoCidade & ",   " & _
                                         "  '" & mNomeCidade & "', " & _
                                         "  '" & mSiglaEstado & "',   " & _
                                         "  '" & mUsuarioCadastro & "', " & _
                                         "  '" & Date.Now & "' )  "
                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("IncluirCidade")
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

    Public Function AlterarCidade() As Integer
        Dim wControle As Integer

        If mCodigoCidade = 0 Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para alteração!"
            VariaveisGlobais.gStackTraceErro = "Cidades_Implem->AlterarCidade()"
            Return -1
        End If
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            '**** Inicio Codigo Novo **************************************************
            Dim wSet As String = ""
            Dim wLog As String = ""

            wComando.CommandText = "SELECT * FROM C_Cidades WHERE CodigoCidade ='" & mCodigoCidade & "'"

            wDataReader = wComando.ExecuteReader
            If Not wDataReader.Read() Then
                wDataReader.Close()
                Return 1
            End If

            If mCodigoCidade <> wDataReader("CodigoCidade") Then
                wSet = wSet & ", CodigoCidade = '" & mCodigoCidade & "'"
                wLog = wLog & "|CodigoCidade\" & wDataReader("CodigoCidade")
            End If
            If mNomeCidade <> wDataReader("NomeCidade") Then
                wSet = wSet & ", NomeCidade = '" & mNomeCidade & "'"
                wLog = wLog & "|NomeCidade\" & wDataReader("NomeCidade")
            End If
            If mSiglaEstado <> wDataReader("SiglaEstado") Then
                wSet = wSet & ", SiglaEstado = '" & mSiglaEstado & "'"
                wLog = wLog & "|SiglaEstado\" & wDataReader("SiglaEstado")
            End If

            wDataReader.Close()
            If Len(wSet) > 0 Then wSet = wSet.Substring(1, Len(wSet) - 1)
            If Len(wLog) > 0 Then wLog = wLog.Substring(1, Len(wLog) - 1)

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "AlterarCidade")
            wComando.Transaction = wTransacao

            Try
                If Len(wSet) > 0 Then
                    wComando.CommandText = _
                          " UPDATE C_Cidades SET " & wSet & " WHERE " & _
                          "  CodigoCidade = '" & mCodigoCidade & "'"

                    wComando.ExecuteNonQuery()
                    Dim Log As String = "C_LOG"
                    Dim Tab As String = "C_Cidades"
                    Dim Chave As String = mCodigoCidade
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
                wTransacao.Rollback("AlterarCidade")
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

    Private Function VerificaDependenciasCidade() As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = "SELECT * FROM C_Filiais WHERE CodigoCidade ='" & mCodigoCidade & "'" & _
                                    " AND isnull(Data_Hora_Exclusao,'') = '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                wDataReader.Close()
                VariaveisGlobais.gDescricaoUltimoErro = " A Cidade " & mNomeCidade & " está sendo usada por uma Filial!"
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

    Public Function ExcluirCidade() As Integer

        Try
            Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim wDataSet As DataSet = New DataSet

            If mCodigoCidade = 0 Then
                VariaveisGlobais.gUltimoSQL = ""
                VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para exclusão!"
                VariaveisGlobais.gStackTraceErro = "Cidades_Implem->ExcluirCidade()"
                Return -1
            End If

            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wControle = VerificaDependenciasCidade()
            If wControle <> 0 Then Return wControle

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ExcluirCidade")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = " UPDATE C_Cidades SET " & _
                                    " Codigo_Usuario_Exclusao ='" & VariaveisGlobais.gCodigoUsuario & "',    " & _
                                    " Data_Hora_Exclusao ='" & Date.Now & "'    " & _
                                    " WHERE    " & _
                                    " CodigoCidade = '" & mCodigoCidade & "'"

                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("ExcluirCidade")
            End Try

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function MostraTabelaCidades(ByRef pObjTabela As System.Windows.Forms.DataGridView, _
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

            wDataSet.Tables(0).Columns(0).ColumnName = "Código"
            wDataSet.Tables(0).Columns(1).ColumnName = "Nome"
            wDataSet.Tables(0).Columns(2).ColumnName = "UF"
        
            Dim wDataTable As New DataTable()
            wDataTable = wDataSet.Tables(0)

            wDataTable.Columns.Add("Altera", GetType(Image))
            Dim wicon As Image = Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "lupa.gif")
            For i As Integer = 0 To wDataTable.Rows.Count - 1
                wDataTable.Rows(i)(3) = wicon
            Next

            Dim wDataView = New DataView(wDataTable, "", "", DataViewRowState.CurrentRows)

            pObjTabela.Columns.Clear()
            pObjTabela.DataSource = wDataView

            If CDec(pObjTabela.Tag) = 0 Then pObjTabela.Tag = "1" '/ CDec(pObjTabela.Tag)
            pObjTabela.Columns(0).Width = 80 / CDec(pObjTabela.Tag) 'Código Cidade
            pObjTabela.Columns(1).Width = 250 / CDec(pObjTabela.Tag) 'Nome Cidade
            pObjTabela.Columns(2).Width = 30 / CDec(pObjTabela.Tag) 'Sigla Estado
            pObjTabela.Columns(3).Width = 17 / CDec(pObjTabela.Tag) 'Lupa

            pObjTabela.RowHeadersWidth = 10

            For i As Integer = 0 To 3
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