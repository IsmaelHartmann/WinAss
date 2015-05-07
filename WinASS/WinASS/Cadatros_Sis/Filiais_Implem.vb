Imports System.Data.SqlClient

Public Class Filiais_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    Private mCodigoEmpresa As Integer
    Private mCodigoFilial As Integer
    Private mCNPJ As String
    Private mInscricaoEstadual As String
    Private mNomeFilial As String
    Private mEndereco As String
    Private mComplemento As String
    Private mBairro As String
    Private mCodigoCidade As Integer
    Private mSiglaEstado As String
    Private mCEP As String
    Private mTelefone As String
    Private mFax As String

    Private wComando As SqlCommand
    Private wDataReader As SqlDataReader
    Public wDataSet As DataSet

#End Region

#Region " Propriedades "

    Public Property CodigoEmpresa() As Integer
        Get
            Return mCodigoEmpresa
        End Get
        Set(ByVal Value As Integer)
            mCodigoEmpresa = Value
        End Set
    End Property
    Public Property CodigoFilial() As Integer
        Get
            Return mCodigoFilial
        End Get
        Set(ByVal Value As Integer)
            mCodigoFilial = Value
        End Set
    End Property
    Public Property CNPJ() As String
        Get
            Return mCNPJ
        End Get
        Set(ByVal Value As String)
            mCNPJ = Value
        End Set
    End Property

    Public Property InscricaoEstadual() As String
        Get
            Return mInscricaoEstadual
        End Get
        Set(ByVal Value As String)
            mInscricaoEstadual = Value
        End Set
    End Property

    Public Property NomeFilial() As String
        Get
            Return mNomeFilial
        End Get
        Set(ByVal Value As String)
            mNomeFilial = Value
        End Set
    End Property
    Public Property Endereco() As String
        Get
            Return mEndereco
        End Get
        Set(ByVal Value As String)
            mEndereco = Value
        End Set
    End Property
    Public Property Complemento() As String
        Get
            Return mComplemento
        End Get
        Set(ByVal Value As String)
            mComplemento = Value
        End Set
    End Property

    Public Property Bairro() As String
        Get
            Return mBairro
        End Get
        Set(ByVal Value As String)
            mBairro = Value
        End Set
    End Property
    Public Property CodigoCidade() As Integer
        Get
            Return mCodigoCidade
        End Get
        Set(ByVal Value As Integer)
            mCodigoCidade = Value
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

    Public Property CEP() As String
        Get
            Return mCEP
        End Get
        Set(ByVal Value As String)
            mCEP = Value
        End Set
    End Property

    Public Property Telefone() As String
        Get
            Return mTelefone
        End Get
        Set(ByVal Value As String)
            mTelefone = Value
        End Set
    End Property
    Public Property Fax() As String
        Get
            Return mFax
        End Get
        Set(ByVal Value As String)
            mFax = Value
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

    Public Function VerificaExistenciaFilial() As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM C_Filiais WHERE " & _
                            " CodigoEmpresa='" & mCodigoEmpresa & "'" & _
                            " AND CodigoFilial='" & mCodigoFilial & "'" & _
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
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 1
    End Function

    Public Function BuscarFilial() As Integer
        Dim wTmp As Integer
        If mCodigoFilial = 0 Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "CadastroFiliais_Implem->BuscarFilial()"
            Return 1
        End If
        wTmp = VerificaExistenciaFilial()
        If wTmp <> 0 Then Return wTmp
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM C_Filiais  WHERE " & _
                            " CodigoEmpresa='" & mCodigoEmpresa & "'" & _
                            " AND CodigoFilial='" & mCodigoFilial & "'" & _
                             " AND isnull(Data_Hora_Exclusao,'') = '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mCodigoEmpresa = wDataReader("CodigoEmpresa")
                mCodigoFilial = wDataReader("CodigoFilial")
                mCNPJ = IIf(IsDBNull(wDataReader("CNPJ")), "", wDataReader("CNPJ"))
                mInscricaoEstadual = IIf(IsDBNull(wDataReader("InscricaoEstadual")), "", wDataReader("InscricaoEstadual"))
                mSiglaEstado = IIf(IsDBNull(wDataReader("SiglaEstado")), "", wDataReader("SiglaEstado"))
                mNomeFilial = IIf(IsDBNull(wDataReader("NomeFilial")), "", wDataReader("NomeFilial"))
                mEndereco = IIf(IsDBNull(wDataReader("Endereco")), "", wDataReader("Endereco"))
                mComplemento = IIf(IsDBNull(wDataReader("Complemento")), "", wDataReader("Complemento"))
                mBairro = IIf(IsDBNull(wDataReader("Bairro")), "", wDataReader("Bairro"))
                mCodigoCidade = wDataReader("CodigoCidade")
                mCEP = IIf(IsDBNull(wDataReader("CEP")), "", wDataReader("CEP"))
                mTelefone = IIf(IsDBNull(wDataReader("Telefone")), "", wDataReader("Telefone"))
                mFax = IIf(IsDBNull(wDataReader("Fax")), "", wDataReader("Fax"))

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

    Public Function IncluirFilial() As Integer
        If mCodigoEmpresa = 0 Or mCNPJ = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para inclusão!"
            VariaveisGlobais.gStackTraceErro = "Filiais_Implem -> IncluirFilial()"
            Return -1
        End If

        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = " SELECT isnull(max(cast(CodigoFilial as integer)),0)+1 CodigoFilial " & _
                                           " FROM C_Filiais WHERE isnumeric(CodigoFilial)<>0 "
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mCodigoFilial = wDataReader("CodigoFilial")
            Else
                mCodigoFilial = 1
            End If
            wDataReader.Close()


            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "IncluirFilial")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = "INSERT INTO C_Filiais (CodigoEmpresa,       " & _
                                           " CodigoFilial,                      " & _
                                           " CNPJ,                      " & _
                                           " InscricaoEstadual,                      " & _
                                           " NomeFilial,                      " & _
                                           " Endereco,                      " & _
                                           " Complemento,                      " & _
                                           " Bairro,                     " & _
                                           " SiglaEstado,                      " & _
                                           " CodigoCidade,                      " & _
                                           " CEP,                     " & _
                                           " Telefone,                     " & _
                                           " Fax                     " & _
                                           "    ) VALUES (" & _
                                           "  '" & mCodigoEmpresa & "',   " & _
                                           "  '" & mCodigoFilial & "',   " & _
                                           "  '" & mCNPJ & "',   " & _
                                           BrancoNull(mInscricaoEstadual) & ",   " & _
                                           BrancoNull(mNomeFilial) & ",   " & _
                                           "  '" & mEndereco & "',   " & _
                                           BrancoNull(mComplemento) & ",   " & _
                                           BrancoNull(mBairro) & ",   " & _
                                           "  '" & mSiglaEstado & "',   " & _
                                           "  '" & mCodigoCidade & "',   " & _
                                           BrancoNull(mCEP) & ", " & _
                                           BrancoNull(mTelefone) & ", " & _
                                           BrancoNull(mFax) & ") "

                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("IncluirFilial")
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

    Public Function AlterarFilial() As Integer

        Dim wControle As Integer
        If IsNothing(mCodigoEmpresa) Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para alteração!"
            VariaveisGlobais.gStackTraceErro = "Filiais_Implem->AlterarFilial()"
            Return 1
        End If

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            '**** Inicio Codigo Novo **************************************************
            Dim wSet As String = ""
            Dim wLog As String = ""

            wComando.CommandText = "SELECT * FROM C_Filiais WHERE " & _
                            " CodigoEmpresa='" & mCodigoEmpresa & "'" & _
                            " AND CodigoFilial='" & mCodigoFilial & "'"

            wDataReader = wComando.ExecuteReader
            If Not wDataReader.Read() Then
                wDataReader.Close()
                Return 1
            End If

            If mCNPJ <> wDataReader("CNPJ") Then
                wSet = wSet & ", CNPJ = '" & mCNPJ & "'"
                wLog = wLog & "|CNPJ\" & wDataReader("CNPJ")
            End If

            If BrancoNull(mInscricaoEstadual) <> BrancoNull(IIf(IsDBNull(wDataReader("InscricaoEstadual")), "", wDataReader("InscricaoEstadual"))) Then
                wSet = wSet & ", InscricaoEstadual = " & BrancoNull(mInscricaoEstadual) & ""
                wLog = wLog & "|InscricaoEstadual\" & wDataReader("InscricaoEstadual")
            End If

            If BrancoNull(mNomeFilial) <> BrancoNull(IIf(IsDBNull(wDataReader("NomeFilial")), "", wDataReader("NomeFilial"))) Then
                wSet = wSet & ", NomeFilial = '" & mNomeFilial & "'"
                wLog = wLog & "|NomeFilial\" & wDataReader("NomeFilial")
            End If

            If mEndereco <> wDataReader("Endereco") Then
                wSet = wSet & ", Endereco = '" & mEndereco & "'"
                wLog = wLog & "|Endereco\" & wDataReader("Endereco")
            End If

            If BrancoNull(mComplemento) <> BrancoNull(IIf(IsDBNull(wDataReader("Complemento")), "", wDataReader("Complemento"))) Then
                wSet = wSet & ", Complemento = " & BrancoNull(mComplemento) & " "
                wLog = wLog & "|Complemento\" & wDataReader("Complemento")
            End If

            If BrancoNull(mBairro) <> BrancoNull(IIf(IsDBNull(wDataReader("Bairro")), "", wDataReader("Bairro"))) Then
                wSet = wSet & ", Bairro = '" & mBairro & "'"
                wLog = wLog & "|Bairro\" & wDataReader("Bairro")
            End If

            If BrancoNull(mSiglaEstado) <> BrancoNull(IIf(IsDBNull(wDataReader("SiglaEstado")), "", wDataReader("SiglaEstado"))) Then
                wSet = wSet & ", SiglaEstado = '" & mSiglaEstado & "'"
                wLog = wLog & "|SiglaEstado\" & wDataReader("SiglaEstado")
            End If

            If mCodigoCidade <> wDataReader("CodigoCidade") Then
                wSet = wSet & ", CodigoCidade = '" & mCodigoCidade & "'"
                wLog = wLog & "|CodigoCidade\" & wDataReader("CodigoCidade")
            End If

            If BrancoNull(mCEP) <> BrancoNull(IIf(IsDBNull(wDataReader("CEP")), "", wDataReader("CEP"))) Then
                wSet = wSet & ", CEP =  " & BrancoNull(mCEP) & " "
                wLog = wLog & "|CEP\" & wDataReader("CEP")
            End If

            If BrancoNull(mTelefone) <> BrancoNull(IIf(IsDBNull(wDataReader("Telefone")), "", wDataReader("Telefone"))) Then
                wSet = wSet & ", Telefone =  " & BrancoNull(mTelefone) & " "
                wLog = wLog & "|Telefone\" & wDataReader("Telefone")
            End If

            If BrancoNull(mFax) <> BrancoNull(IIf(IsDBNull(wDataReader("Fax")), "", wDataReader("Fax"))) Then
                wSet = wSet & ", Fax =  " & BrancoNull(mTelefone) & " "
                wLog = wLog & "|Fax\" & wDataReader("Fax")
            End If

            wDataReader.Close()
            If Len(wSet) > 0 Then wSet = wSet.Substring(1, Len(wSet) - 1)
            If Len(wLog) > 0 Then wLog = wLog.Substring(1, Len(wLog) - 1)


            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "AlterarFilial")
            wComando.Transaction = wTransacao

            Try
                If Len(wSet) > 0 Then
                    wComando.CommandText = _
                        " UPDATE C_Filiais SET " & wSet & " WHERE " & _
                        " CodigoEmpresa='" & mCodigoEmpresa & "'" & _
                        " AND CodigoFilial='" & mCodigoFilial & "'"

                    wComando.ExecuteNonQuery()

                    Dim Log As String = "C_LOG"
                    Dim Tab As String = "C_Filiais"
                    Dim Chave As String = mCodigoEmpresa
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
                wTransacao.Rollback("AlterarFilial")
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

    Public Function ExcluirFilial() As Integer


        Dim wTmp As Integer
        Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
        Dim wDataSet As DataSet = New DataSet

        If mCodigoEmpresa = 0 Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para exclusão!"
            VariaveisGlobais.gStackTraceErro = "Filiais_Implem->ExcluirFilial()"
            Return 1

        End If

        Dim wControle As Integer
        wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
        If wControle <> 0 Then Return wControle

        wTmp = VerificaExistenciaFilial()
        If wTmp <> 0 Then Return wTmp

        Try
            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ExcluirFilial")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = " UPDATE C_Filiais  " & _
                                 " SET Codigo_Usuario_Exclusao = '" & VariaveisGlobais.gCodigoUsuario & "', " & _
                                 " Data_Hora_Exclusao = '" & Now.Date & "' " & _
                                 " WHERE CodigoEmpresa='" & mCodigoEmpresa & "'" & _
                                 " AND CodigoFilial='" & mCodigoFilial & "'"

                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("ExcluirFilial")
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

    Public Function MostraTabelaFiliais(ByRef pObjTabela As System.Windows.Forms.DataGridView, _
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

            wDataSet.Tables(0).Columns(0).ColumnName = "Empresa"
            wDataSet.Tables(0).Columns(1).ColumnName = "Filial"
            wDataSet.Tables(0).Columns(2).ColumnName = "CNPJ"
            wDataSet.Tables(0).Columns(3).ColumnName = "Nome"
            wDataSet.Tables(0).Columns(4).ColumnName = "Endereço"

            Dim wDataTable As New DataTable()
            wDataTable = wDataSet.Tables(0)

            wDataTable.Columns.Add("Altera", GetType(Image))
            Dim wicon As Image = Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "lupa.gif")
            For i As Integer = 0 To wDataTable.Rows.Count - 1
                wDataTable.Rows(i)(5) = wicon
            Next

            Dim wDataView = New DataView(wDataTable, "", "", DataViewRowState.CurrentRows)

            pObjTabela.Columns.Clear()
            pObjTabela.DataSource = wDataView

            If CDec(pObjTabela.Tag) = 0 Then pObjTabela.Tag = "1" '/ CDec(pObjTabela.Tag)
            pObjTabela.Columns(0).Width = 60 / CDec(pObjTabela.Tag) 'Emperesa
            pObjTabela.Columns(1).Width = 50 / CDec(pObjTabela.Tag) 'Filial
            pObjTabela.Columns(2).Width = 100 / CDec(pObjTabela.Tag) 'CNPJ
            pObjTabela.Columns(3).Width = 120 / CDec(pObjTabela.Tag) 'Nome
            pObjTabela.Columns(4).Width = 150 / CDec(pObjTabela.Tag) 'Endereço
            pObjTabela.Columns(5).Width = 17 / CDec(pObjTabela.Tag) 'Lupa

            pObjTabela.RowHeadersWidth = 10

            For i As Integer = 0 To 5
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


