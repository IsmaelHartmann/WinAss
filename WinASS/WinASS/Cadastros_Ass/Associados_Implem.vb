Imports System.Data.SqlClient

Public Class Associados_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    Private mCodigo As String
    Private mMatricula As String
    Private mMatriculaBRF As String
    Private mNomeAssociado As String
    Private mCidade As Integer
    Private mEndereco As String
    Private mEstado As String
    Private mCEP As String
    Private mCNPJ As String
    Private mInscricaoEstadual As String
    Private mSituacao As String
    Private mData_Nasc As String
    Private mTelefone As String
    Private mData_Hora_Cadastro As String
    Private mCodigo_Usuario_Cadastro As String

    Private wComando As SqlCommand
    Private wDataReader As SqlDataReader
    Public wDataSet As DataSet

#End Region

#Region " Propriedades "

    Public Property Data_Hora_Cadastro() As String
        Get
            Return mData_Hora_Cadastro
        End Get
        Set(ByVal Value As String)
            mData_Hora_Cadastro = Value
        End Set
    End Property
    Public Property Codigo_Usuario_Cadastro() As String
        Get
            Return mCodigo_Usuario_Cadastro
        End Get
        Set(ByVal Value As String)
            mCodigo_Usuario_Cadastro = Value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return mCodigo
        End Get
        Set(ByVal Value As String)
            mCodigo = Value
        End Set
    End Property

    Public Property Matricula() As String
        Get
            Return mMatricula
        End Get
        Set(ByVal Value As String)
            mMatricula = Value
        End Set
    End Property

    Public Property MatriculaBRF() As String
        Get
            Return mMatriculaBRF
        End Get
        Set(ByVal Value As String)
            mMatriculaBRF = Value
        End Set
    End Property

    Public Property NomeAssociado() As String
        Get
            Return mNomeAssociado
        End Get
        Set(ByVal Value As String)
            mNomeAssociado = Value
        End Set
    End Property

    Public Property Cidade() As Integer
        Get
            Return mCidade
        End Get
        Set(ByVal Value As Integer)
            mCidade = Value
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

    Public Property Estado() As String
        Get
            Return mEstado
        End Get
        Set(ByVal Value As String)
            mEstado = Value
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

    Public Property Situacao() As String
        Get
            Return mSituacao
        End Get
        Set(ByVal Value As String)
            mSituacao = Value
        End Set
    End Property

    Public Property Data_Nasc() As String
        Get
            Return mData_Nasc
        End Get
        Set(ByVal Value As String)
            mData_Nasc = Value
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

#End Region

#Region " Métodos "

    Public Sub New()
        wComando = New SqlCommand("", VariaveisGlobais.gConexao)
    End Sub

    Public Sub New(ByVal pobjVariaveisGlobais As VariaveisGlobais)
        objVariaveisGlobais = pobjVariaveisGlobais
        wComando = New SqlCommand("", VariaveisGlobais.gConexao)
    End Sub

    Public Function VerificaExistenciaMatricula(ByVal pMatricula As String, ByVal pCodigo As String, ByRef pParametro As String) As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = _
                " SELECT Codigo FROM Ass_Associados " & _
                " WHERE CASE When ISNULL(Matricula, '') = '' Then '' Else substring(Matricula, 1, len(matricula) -1) END='" & _
                    pMatricula & "' AND Codigo <> '" & pCodigo & "'"

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                pParametro = wDataReader("Codigo")
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
    Public Function VerificaExistenciaMatriculaBRF(ByVal pMatricula As String, ByVal pCodigo As String, ByRef pParametro As String) As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = _
                " SELECT Codigo FROM Ass_Associados " & _
                " WHERE ISNULL(MatriculaBRF, '') = '" & pMatricula & "' AND Codigo <> '" & pCodigo & "'"

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                pParametro = wDataReader("Codigo")
                wDataReader.Close()
                Return 0
            End If
            wDataReader.Close()

        Catch ex As Exception
            wDataReader.Close()
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 1
    End Function
    Public Function VerificaExistenciaAssociado(Optional ByVal pSituacao As String = "") As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            If pSituacao = "" Then
                wComando.CommandText = "SELECT * FROM Ass_Associados " & _
                                   " WHERE Codigo='" & mCodigo & "' "

            ElseIf pSituacao = "Ex" Then
                wComando.CommandText = "SELECT * FROM Ass_Associados " & _
                                 " WHERE Codigo='" & mCodigo & "' " & _
                                 " AND isnull(Data_Hora_Exclusao,'') = '' "
            End If
            
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

    Public Function VerificaExistenciaCPFCNPJ(ByVal pCodigo As String) As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM Ass_Associados WHERE CNPJ='" & mCNPJ & "'" & _
                             " AND Codigo <> '" & pCodigo & "' " & _
                             " AND isnull(Data_Hora_Exclusao,'') = '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
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

    Public Function VerificaExistenciaIE() As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM Ass_Associados WHERE InscricaoEstadual ='" & mInscricaoEstadual & "'" & _
                             " AND isnull(Data_Hora_Exclusao,'') = '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
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

    Public Function BuscarAssociado() As Integer

        Dim wTmp As Integer
        If mCodigo = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "CadastroAssociados_Implem->BuscarAssociado()"
            Return -1
        End If

        wTmp = VerificaExistenciaAssociado()
        If wTmp <> 0 Then Return wTmp
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM Ass_Associados WHERE Codigo='" & mCodigo & "'"
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mCodigo = wDataReader("Codigo")
                mMatricula = IIf(IsDBNull(wDataReader("Matricula")), "", wDataReader("Matricula"))
                mMatriculaBRF = IIf(IsDBNull(wDataReader("MatriculaBRF")), "", wDataReader("MatriculaBRF"))
                mNomeAssociado = IIf(IsDBNull(wDataReader("Nome")), "", wDataReader("Nome"))
                mCidade = IIf(IsDBNull(wDataReader("Cidade")), 0, wDataReader("Cidade"))
                mEndereco = IIf(IsDBNull(wDataReader("Endereco")), "", wDataReader("Endereco"))
                mEstado = IIf(IsDBNull(wDataReader("Estado")), "", wDataReader("Estado"))
                mCEP = IIf(IsDBNull(wDataReader("CEP")), "", wDataReader("CEP"))
                mCNPJ = IIf(IsDBNull(wDataReader("CNPJ")), "", wDataReader("CNPJ"))
                mInscricaoEstadual = IIf(IsDBNull(wDataReader("InscricaoEstadual")), "", wDataReader("InscricaoEstadual"))
                mSituacao = IIf(IsDBNull(wDataReader("Situacao")), "", wDataReader("Situacao"))
                mData_Nasc = IIf(IsDBNull(wDataReader("Data_Nasc")), "", wDataReader("Data_Nasc"))
                mTelefone = IIf(IsDBNull(wDataReader("Telefone")), "", wDataReader("Telefone"))
                mData_Hora_Cadastro = IIf(IsDBNull(wDataReader("Data_Hora_Cadastro")), "", wDataReader("Data_Hora_Cadastro"))
                mCodigo_Usuario_Cadastro = IIf(IsDBNull(wDataReader("Codigo_Usuario_Cadastro")), "", wDataReader("Codigo_Usuario_Cadastro"))
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

    Public Function BuscarAssociadoPorInscricaoEstadual() As Integer

        If mInscricaoEstadual = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "CadastroAssociados_Implem->BuscarAssociado()"
            Return -1
        End If

        'wTmp = VerificaExistenciaAssociado()
        'If wTmp <> 0 Then Return wTmp
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM Ass_Associados WHERE InscricaoEstadual='" & mInscricaoEstadual & "'"
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mCodigo = wDataReader("Codigo")
                mMatricula = IIf(IsDBNull(wDataReader("Matricula")), "", wDataReader("Matricula"))
                mMatriculaBRF = IIf(IsDBNull(wDataReader("MatriculaBRF")), "", wDataReader("MatriculaBRF"))
                mNomeAssociado = IIf(IsDBNull(wDataReader("Nome")), "", wDataReader("Nome"))
                mCidade = IIf(IsDBNull(wDataReader("Cidade")), 0, wDataReader("Cidade"))
                mEndereco = IIf(IsDBNull(wDataReader("Endereco")), "", wDataReader("Endereco"))
                mEstado = IIf(IsDBNull(wDataReader("Estado")), "", wDataReader("Estado"))
                mCEP = IIf(IsDBNull(wDataReader("CEP")), "", wDataReader("CEP"))
                mCNPJ = IIf(IsDBNull(wDataReader("CNPJ")), "", wDataReader("CNPJ"))
                mInscricaoEstadual = IIf(IsDBNull(wDataReader("InscricaoEstadual")), "", wDataReader("InscricaoEstadual"))
                mSituacao = IIf(IsDBNull(wDataReader("Situacao")), "", wDataReader("Situacao"))
                mData_Nasc = IIf(IsDBNull(wDataReader("Data_Nasc")), "", wDataReader("Data_Nasc"))
                mTelefone = IIf(IsDBNull(wDataReader("Telefone")), "", wDataReader("Telefone"))
                mData_Hora_Cadastro = IIf(IsDBNull(wDataReader("Data_Hora_Cadastro")), "", wDataReader("Data_Hora_Cadastro"))
                mCodigo_Usuario_Cadastro = IIf(IsDBNull(wDataReader("Codigo_Usuario_Cadastro")), "", wDataReader("Codigo_Usuario_Cadastro"))
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

    Public Function IncluirAssociado() As Integer
        Try

            Dim wControle As Integer

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle


            wComando.CommandText = " SELECT isnull(max(cast(Codigo as integer)),0)+1 Codigo " & _
                                " FROM Ass_Associados WHERE isnumeric(Codigo)<>0 "
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mCodigo = wDataReader("Codigo")
            Else
                mCodigo = 1
            End If
            wDataReader.Close()


            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "IncluirAssociado")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = " INSERT INTO Ass_Associados (Codigo,  " & _
                        " Matricula,                       " & _
                        " MatriculaBRF,                       " & _
                        " Nome,                       " & _
                        " Cidade,                     " & _
                        " Endereco,                   " & _
                        " Estado,                       " & _
                        " CEP,                       " & _
                        " CNPJ,                       " & _
                        " InscricaoEstadual,                       " & _
                        " Situacao,                       " & _
                        " Data_Nasc,                       " & _
                        " Telefone,                       " & _
                        " Codigo_Usuario_Cadastro,  " & _
                        " Data_Hora_Cadastro  " & _
                        " ) VALUES (" & _
                        " '" & mCodigo & "',               " & _
                        " '" & mMatricula & "',               " & _
                        " '" & mMatriculaBRF & "',               " & _
                        " '" & mNomeAssociado & "',           " & _
                        " '" & mCidade & "',           " & _
                        " '" & mEndereco & "',           " & _
                        " '" & mEstado & "',           " & _
                        " '" & mCEP & "',           " & _
                        " '" & mCNPJ & "',           " & _
                        " '" & mInscricaoEstadual & "',           " & _
                        " '" & mSituacao & "',           " & _
                         " '" & mData_Nasc & "',           " & _
                         " '" & mTelefone & "',           " & _
                        " '" & mCodigo_Usuario_Cadastro & "', " & _
                        " '" & Date.Now & "' )  "
                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("IncluirAssociado")
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

    Public Function AlterarAssociado() As Integer

        Dim wControle As Integer


        If mCodigo = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para alteração!"
            VariaveisGlobais.gStackTraceErro = "Associados_Implem->AlterarAssociado()"
            Return -1
        End If

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            '**** Inicio Codigo Novo **************************************************
            Dim wSet As String = ""
            Dim wLog As String = ""

            wComando.CommandText = "SELECT * FROM Ass_Associados WHERE Codigo='" & mCodigo & "'"

            wDataReader = wComando.ExecuteReader
            If Not wDataReader.Read() Then
                wDataReader.Close()
                Return 1
            End If

            If BrancoNull(mMatricula) <> BrancoNull(IIf(IsDBNull(wDataReader("Matricula")), "", wDataReader("Matricula"))) Then
                wSet = wSet & ", Matricula = " & BrancoNull(mMatricula) & ""
                wLog = wLog & "|Matricula\" & wDataReader("Matricula")
            End If

            If BrancoNull(mMatriculaBRF) <> BrancoNull(IIf(IsDBNull(wDataReader("MatriculaBRF")), "", wDataReader("MatriculaBRF"))) Then
                wSet = wSet & ", MatriculaBRF = " & BrancoNull(mMatriculaBRF) & ""
                wLog = wLog & "|MatriculaBRF\" & wDataReader("MatriculaBRF")
            End If

            If BrancoNull(mNomeAssociado) <> BrancoNull(IIf(IsDBNull(wDataReader("Nome")), "", wDataReader("Nome"))) Then
                wSet = wSet & ", Nome = " & BrancoNull(mNomeAssociado) & ""
                wLog = wLog & "|Nome\" & wDataReader("Nome")
            End If

            If BrancoNull(mCidade) <> BrancoNull(IIf(IsDBNull(wDataReader("Cidade")), "", wDataReader("Cidade"))) Then
                wSet = wSet & ", Cidade = " & BrancoNull(mCidade) & ""
                wLog = wLog & "|Cidade\" & wDataReader("Cidade")
            End If

            If BrancoNull(mEndereco) <> BrancoNull(IIf(IsDBNull(wDataReader("Endereco")), "", wDataReader("Endereco"))) Then
                wSet = wSet & ", Endereco = " & BrancoNull(mEndereco) & ""
                wLog = wLog & "|Endereco\" & wDataReader("Endereco")
            End If

            If BrancoNull(mEstado) <> BrancoNull(IIf(IsDBNull(wDataReader("Estado")), "", wDataReader("Estado"))) Then
                wSet = wSet & ", Estado = " & BrancoNull(mEstado) & ""
                wLog = wLog & "|Estado\" & wDataReader("Estado")
            End If

            If BrancoNull(mCEP) <> BrancoNull(IIf(IsDBNull(wDataReader("CEP")), "", wDataReader("CEP"))) Then
                wSet = wSet & ", CEP = " & BrancoNull(mCEP) & ""
                wLog = wLog & "|CEP\" & wDataReader("CEP")
            End If

            If BrancoNull(mCNPJ) <> BrancoNull(IIf(IsDBNull(wDataReader("CNPJ")), "", wDataReader("CNPJ"))) Then
                wSet = wSet & ", CNPJ = " & BrancoNull(mCNPJ) & ""
                wLog = wLog & "|CNPJ\" & wDataReader("CNPJ")
            End If

            If BrancoNull(mInscricaoEstadual) <> BrancoNull(IIf(IsDBNull(wDataReader("InscricaoEstadual")), "", wDataReader("InscricaoEstadual"))) Then
                wSet = wSet & ", InscricaoEstadual = " & BrancoNull(mInscricaoEstadual) & ""
                wLog = wLog & "|InscricaoEstadual\" & wDataReader("InscricaoEstadual")
            End If

            If BrancoNull(mSituacao) <> BrancoNull(IIf(IsDBNull(wDataReader("Situacao")), "", wDataReader("Situacao"))) Then
                wSet = wSet & ", Situacao = " & BrancoNull(mSituacao) & ""
                wLog = wLog & "|Situacao\" & wDataReader("Situacao")
            End If

            If BrancoNull(mTelefone) <> BrancoNull(IIf(IsDBNull(wDataReader("Telefone")), "", wDataReader("Telefone"))) Then
                wSet = wSet & ", Telefone = " & BrancoNull(mTelefone) & ""
                wLog = wLog & "|Telefone\" & wDataReader("Telefone")
            End If

            If BrancoNull(mData_Nasc) <> BrancoNull(IIf(IsDBNull(wDataReader("Data_Nasc")), "", wDataReader("Data_Nasc"))) Then
                wSet = wSet & ", Data_Nasc = " & BrancoNull(mData_Nasc) & ""
                wLog = wLog & "|Data_Nasc\" & wDataReader("Data_Nasc")
            End If

            wDataReader.Close()
            If Len(wSet) > 0 Then wSet = wSet.Substring(1, Len(wSet) - 1)
            If Len(wLog) > 0 Then wLog = wLog.Substring(1, Len(wLog) - 1)

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "AlterarAssociado")
            wComando.Transaction = wTransacao

            Try
                If Len(wSet) > 0 Then
                    wComando.CommandText = _
                           " UPDATE Ass_Associados SET " & wSet & " WHERE " & _
                      "  Codigo='" & mCodigo & "'"

                    wComando.ExecuteNonQuery()
                    Dim Log As String = "C_LOG"
                    Dim Tab As String = "Ass_Associados"
                    Dim Chave As String = mCodigo
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
                wTransacao.Rollback("AlterarAssociados")
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

    Public Function ExcluirAssociado() As Integer

        Try
            Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim wDataSet As DataSet = New DataSet

            If mCodigo = "" Then
                VariaveisGlobais.gUltimoSQL = ""
                VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para exclusão!"
                VariaveisGlobais.gStackTraceErro = "Associados_Implem->ExcluirAssociado()"
                Return -1
            End If

            Dim wControle As Integer
            wControle = VerificaDependenciaAssociado(mCodigo)
            If wControle <> 0 Then Return wControle

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ExcluirAssociado")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = " UPDATE Ass_Associados SET " & _
                                    " Codigo_Usuario_Exclusao = '" & VariaveisGlobais.gCodigoUsuario & "',    " & _
                                    " Data_Hora_Exclusao = '" & Date.Now & "'    " & _
                                    " WHERE    " & _
                                    " Codigo='" & mCodigo & "'"

                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("ExcluirAssociado")
            End Try

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function VerificaDependenciaAssociado(ByVal pCodigo As String) As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM Ass_Movimento " & _
                                   " WHERE Associado ='" & pCodigo & "'" & _
                                   " AND isnull(Data_Hora_Exclusao,'') = '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                wDataReader.Close()
                VariaveisGlobais.gDescricaoUltimoErro = " Associado é usado em Movimentos!"
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

    Public Function MostraTabelaAssociados(ByRef pObjTabela As System.Windows.Forms.DataGridView, _
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
            wDataSet.Tables(0).Columns(1).ColumnName = "Matricula"
            wDataSet.Tables(0).Columns(2).ColumnName = "Nome"
            wDataSet.Tables(0).Columns(3).ColumnName = "DE"
            wDataSet.Tables(0).Columns(4).ColumnName = "InscricaoEstadual"

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
            pObjTabela.Columns(0).Width = 60 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(1).Width = 80 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(2).Width = 300 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(3).Width = 0
            pObjTabela.Columns(3).Visible = False
            pObjTabela.Columns(4).Width = 80 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(5).Width = 22 / CDec(pObjTabela.Tag)

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


