Imports System.Data.SqlClient

Public Class Movimento_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    Private mIdMovimento As String
    Private mData As String
    Private mTecnico As String
    Private mPrefeitura As String
    Private mTalao As String
    Private mAssociado As String
    Private mCanhoto As Integer
    Private mDocumento As String
    Private mTipoAssistencia As String
    Private mTipoServico As String
    Private mAnimal As String
    Private mTipoEverminacao As String
    Private mCabecas As String
    Private mSituacao As String

    Private mValorMaodeObra As Decimal
    Private mValorOutros As Decimal
    Private mValorEverminacao As Decimal
    Private mValorConducao As Decimal
    Private mValorVisita As Decimal
    Private mValorMedicamento As Decimal
    Private mValorServico As Decimal
    Private mValorEquipamento As Decimal
    Private mValorBeneficio As Decimal
    Private mValorSemem As Decimal
    Private mNTouro As String

    Private mData_Hora_Cadastro As String
    Private mCodigo_Usuario_Cadastro As String

    Private wComando As SqlCommand
    Private wDataReader As SqlDataReader
    Public wDataSet As DataSet

#End Region

#Region " Propriedades "

    Public Property IdMovimento() As String
        Get
            Return mIdMovimento
        End Get
        Set(ByVal Value As String)
            mIdMovimento = Value
        End Set
    End Property

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

    Public Property Data() As String
        Get
            Return mData
        End Get
        Set(ByVal Value As String)
            mData = Value
        End Set
    End Property

    Public Property Associado() As String
        Get
            Return mAssociado
        End Get
        Set(ByVal Value As String)
            mAssociado = Value
        End Set
    End Property

    Public Property Talao() As String
        Get
            Return mTalao
        End Get
        Set(ByVal Value As String)
            mTalao = Value
        End Set
    End Property

    Public Property Tecnico() As String
        Get
            Return mTecnico
        End Get
        Set(ByVal Value As String)
            mTecnico = Value
        End Set
    End Property

    Public Property Prefeitura() As String
        Get
            Return mPrefeitura
        End Get
        Set(ByVal Value As String)
            mPrefeitura = Value
        End Set
    End Property

    Public Property Documento() As String
        Get
            Return mDocumento
        End Get
        Set(ByVal Value As String)
            mDocumento = Value
        End Set
    End Property

    Public Property Canhoto() As Integer
        Get
            Return mCanhoto
        End Get
        Set(ByVal Value As Integer)
            mCanhoto = Value
        End Set
    End Property

    Public Property TipoAssistencia() As String
        Get
            Return mTipoAssistencia
        End Get
        Set(ByVal Value As String)
            mTipoAssistencia = Value
        End Set
    End Property

    Public Property TipoServico() As String
        Get
            Return mTipoServico
        End Get
        Set(ByVal Value As String)
            mTipoServico = Value
        End Set
    End Property

    Public Property Animal() As String
        Get
            Return mAnimal
        End Get
        Set(ByVal Value As String)
            mAnimal = Value
        End Set
    End Property

    Public Property TipoEverminacao() As String
        Get
            Return mTipoEverminacao
        End Get
        Set(ByVal Value As String)
            mTipoEverminacao = Value
        End Set
    End Property

    Public Property Cabecas() As String
        Get
            Return mCabecas
        End Get
        Set(ByVal Value As String)
            mCabecas = Value
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

    Public Property ValorMaodeObra() As Decimal
        Get
            Return mValorMaodeObra
        End Get
        Set(ByVal Value As Decimal)
            mValorMaodeObra = Value
        End Set
    End Property

    Public Property ValorOutros() As Decimal
        Get
            Return mValorOutros
        End Get
        Set(ByVal Value As Decimal)
            mValorOutros = Value
        End Set
    End Property

    Public Property ValorEverminacao() As Decimal
        Get
            Return mValorEverminacao
        End Get
        Set(ByVal Value As Decimal)
            mValorEverminacao = Value
        End Set
    End Property

    Public Property ValorVisita() As Decimal
        Get
            Return mValorVisita
        End Get
        Set(ByVal Value As Decimal)
            mValorVisita = Value
        End Set
    End Property

    Public Property ValorConducao() As Decimal
        Get
            Return mValorConducao
        End Get
        Set(ByVal Value As Decimal)
            mValorConducao = Value
        End Set
    End Property

    Public Property ValorMedicamento() As Decimal
        Get
            Return mValorMedicamento
        End Get
        Set(ByVal Value As Decimal)
            mValorMedicamento = Value
        End Set
    End Property

    Public Property ValorServico() As Decimal
        Get
            Return mValorServico
        End Get
        Set(ByVal Value As Decimal)
            mValorServico = Value
        End Set
    End Property

    Public Property ValorEquipamento() As Decimal
        Get
            Return mValorEquipamento
        End Get
        Set(ByVal Value As Decimal)
            mValorEquipamento = Value
        End Set
    End Property

    Public Property ValorBeneficio() As Decimal
        Get
            Return mValorBeneficio
        End Get
        Set(ByVal Value As Decimal)
            mValorBeneficio = Value
        End Set
    End Property

    Public Property ValorSemem() As Decimal
        Get
            Return mValorSemem
        End Get
        Set(ByVal Value As Decimal)
            mValorSemem = Value
        End Set
    End Property

    Public Property NTouro() As String
        Get
            Return mNTouro
        End Get
        Set(ByVal Value As String)
            mNTouro = Value
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

    Public Function VerificaExistenciaDocumento(ByRef pIdMovimento As String, ByRef pCodTecnico As String, ByRef pData As String) As Integer

        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = "SELECT IdMovimento, Tecnico, Data FROM Ass_Movimento " & _
                " WHERE Documento = '" & CInt(mDocumento) & "'" & _
                " AND Tecnico = '" & mTecnico & "'" & _
                " AND Data = '" & mData & "'" & _
                " AND isnull(Data_Hora_Exclusao,'') = '' "
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                pIdMovimento = wDataReader("IdMovimento")
                pCodTecnico = wDataReader("Tecnico")
                pData = wDataReader("Data")
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

    Public Function VerificaExistenciaMovimento() As Integer

        Dim wControle As Integer

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            
            wComando.CommandText = "SELECT * FROM Ass_Movimento WHERE " & _
                " Data = '" & mData & "'" & _
                " AND Tecnico ='" & mTecnico & "'" & _
                " AND Prefeitura ='" & mPrefeitura & "'" & _
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

    Public Function BuscarMovimento() As Integer

        Dim wControle As Integer

        If mIdMovimento = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Campo Incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "Movimentos_Implem->BuscarMovimento()"
            Return 1
        End If

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = _
                " SELECT * FROM Ass_Movimento " & _
                " WHERE IdMovimento = '" & mIdMovimento & "'"

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mIdMovimento = wDataReader("IdMovimento")
                mData = wDataReader("Data")
                mTecnico = wDataReader("Tecnico")
                mPrefeitura = NullBranco(wDataReader("Prefeitura"))
                mAssociado = wDataReader("Associado")
                mDocumento = IIf(IsDBNull(wDataReader("Documento")), "", wDataReader("Documento"))
                mCanhoto = IIf(IsDBNull(wDataReader("Canhoto")), 0, wDataReader("Canhoto"))
                mTipoAssistencia = IIf(IsDBNull(wDataReader("TipoAssistencia")), "", wDataReader("TipoAssistencia"))
                mTalao = IIf(IsDBNull(wDataReader("Talao")), "", wDataReader("Talao"))
                mTipoServico = IIf(IsDBNull(wDataReader("TipoServico")), "", wDataReader("TipoServico"))
                mAnimal = IIf(IsDBNull(wDataReader("Animal")), "", wDataReader("Animal"))
                mTipoEverminacao = IIf(IsDBNull(wDataReader("TipoEverminacao")), 0, wDataReader("TipoEverminacao"))
                mCabecas = IIf(IsDBNull(wDataReader("Cabecas")), 0, wDataReader("Cabecas"))
                mSituacao = IIf(IsDBNull(wDataReader("Situacao")), "", wDataReader("Situacao"))
                mValorMaodeObra = IIf(IsDBNull(wDataReader("ValorMaodeObra")), 0, wDataReader("ValorMaodeObra"))
                mValorEverminacao = IIf(IsDBNull(wDataReader("ValorEverminacao")), 0, wDataReader("ValorEverminacao"))
                mValorConducao = IIf(IsDBNull(wDataReader("ValorConducao")), 0, wDataReader("ValorConducao"))
                mValorMedicamento = IIf(IsDBNull(wDataReader("ValorMedicamento")), 0, wDataReader("ValorMedicamento"))
                mValorServico = IIf(IsDBNull(wDataReader("ValorServico")), 0, wDataReader("ValorServico"))
                mValorEquipamento = IIf(IsDBNull(wDataReader("ValorEquipamento")), 0, wDataReader("ValorEquipamento"))
                mValorBeneficio = IIf(IsDBNull(wDataReader("ValorBeneficio")), 0, wDataReader("ValorBeneficio"))
                mValorSemem = IIf(IsDBNull(wDataReader("ValorSemem")), 0, wDataReader("ValorSemem"))
                mValorOutros = IIf(IsDBNull(wDataReader("ValorOutros")), 0, wDataReader("ValorOutros"))
                mValorVisita = IIf(IsDBNull(wDataReader("ValorVisita")), 0, wDataReader("ValorVisita"))
                mNTouro = IIf(IsDBNull(wDataReader("NTouro")), "", wDataReader("NTouro"))
                mCodigo_Usuario_Cadastro = IIf(IsDBNull(wDataReader("Codigo_Usuario_Cadastro")), "", wDataReader("Codigo_Usuario_Cadastro"))
                mData_Hora_Cadastro = IIf(IsDBNull(wDataReader("Data_Hora_Cadastro")), "", wDataReader("Data_Hora_Cadastro"))

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

    Public Function BuscarDocumento() As Integer

        Dim wControle As Integer

        If mDocumento = "" OrElse mTecnico = "" OrElse mAssociado = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Campo Incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "Movimentos_Implem->BuscarDocumento()"
            Return 1
        End If

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = _
                " SELECT * FROM Ass_Movimento " & _
                " WHERE Documento = '" & mDocumento & "'" & _
                " AND Tecnico = '" & mTecnico & "' " & _
                " AND Prefeitura = '" & mPrefeitura & "' " & _
                " AND Associado = '" & mAssociado & "' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mIdMovimento = wDataReader("IdMovimento")
                mData = wDataReader("Data")
                mTecnico = wDataReader("Tecnico")
                mPrefeitura = NullBranco(wDataReader("Prefeitura"))
                mAssociado = wDataReader("Associado")
                mDocumento = IIf(IsDBNull(wDataReader("Documento")), "", wDataReader("Documento"))
                mCanhoto = IIf(IsDBNull(wDataReader("Canhoto")), 0, wDataReader("Canhoto"))
                mTipoAssistencia = IIf(IsDBNull(wDataReader("TipoAssistencia")), "", wDataReader("TipoAssistencia"))
                mTalao = IIf(IsDBNull(wDataReader("Talao")), "", wDataReader("Talao"))
                mTipoServico = IIf(IsDBNull(wDataReader("TipoServico")), "", wDataReader("TipoServico"))
                mAnimal = IIf(IsDBNull(wDataReader("Animal")), "", wDataReader("Animal"))
                mTipoEverminacao = IIf(IsDBNull(wDataReader("TipoEverminacao")), 0, wDataReader("TipoEverminacao"))
                mCabecas = IIf(IsDBNull(wDataReader("Cabecas")), 0, wDataReader("Cabecas"))
                mSituacao = IIf(IsDBNull(wDataReader("Situacao")), "", wDataReader("Situacao"))
                mValorMaodeObra = IIf(IsDBNull(wDataReader("ValorMaodeObra")), 0, wDataReader("ValorMaodeObra"))
                mValorOutros = IIf(IsDBNull(wDataReader("ValorOutros")), 0, wDataReader("ValorOutros"))
                mValorEverminacao = IIf(IsDBNull(wDataReader("ValorEverminacao")), 0, wDataReader("ValorEverminacao"))
                mValorConducao = IIf(IsDBNull(wDataReader("ValorConducao")), 0, wDataReader("ValorConducao"))
                mValorMedicamento = IIf(IsDBNull(wDataReader("ValorMedicamento")), 0, wDataReader("ValorMedicamento"))
                mValorServico = IIf(IsDBNull(wDataReader("ValorServico")), 0, wDataReader("ValorServico"))
                mValorEquipamento = IIf(IsDBNull(wDataReader("ValorEquipamento")), 0, wDataReader("ValorEquipamento"))
                mValorBeneficio = IIf(IsDBNull(wDataReader("ValorBeneficio")), 0, wDataReader("ValorBeneficio"))
                mValorSemem = IIf(IsDBNull(wDataReader("ValorSemem")), 0, wDataReader("ValorSemem"))
                mValorVisita = IIf(IsDBNull(wDataReader("ValorVisita")), 0, wDataReader("ValorVisita"))
                mNTouro = IIf(IsDBNull(wDataReader("NTouro")), "", wDataReader("NTouro"))
                mCodigo_Usuario_Cadastro = IIf(IsDBNull(wDataReader("Codigo_Usuario_Cadastro")), "", wDataReader("Codigo_Usuario_Cadastro"))
                mData_Hora_Cadastro = IIf(IsDBNull(wDataReader("Data_Hora_Cadastro")), "", wDataReader("Data_Hora_Cadastro"))

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

    Public Function IncluirMovimento() As Integer
        Try

            Dim wControle As Integer

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle


            wComando.CommandText = " SELECT isnull(max(cast(IdMovimento as integer)),0)+1 IdMovimento " & _
                                " FROM Ass_Movimento WHERE isnumeric(IdMovimento)<>0 "
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mIdMovimento = wDataReader("IdMovimento")
            Else
                mIdMovimento = 1
            End If
            wDataReader.Close()


            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "IncluirMovimento")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = _
                    "INSERT INTO Ass_Movimento (IdMovimento, " & _
                    " Data, " & _
                    " Tecnico, " & _
                    " Prefeitura, " & _
                    " Associado, " & _
                    " Documento, " & _
                    " Canhoto, " & _
                    " TipoAssistencia, " & _
                    " Animal, " & _
                    " TipoEverminacao, " & _
                    " TipoServico, " & _
                    " Cabecas, " & _
                    " Situacao, " & _
                    " ValorMaodeObra, " & _
                    " ValorOutros, " & _
                    " ValorEverminacao, " & _
                    " ValorConducao, " & _
                    " ValorMedicamento, " & _
                    " ValorServico, " & _
                    " ValorEquipamento, " & _
                    " ValorBeneficio, " & _
                    " ValorSemem, " & _
                    " ValorVisita, " & _
                    " NTouro, " & _
                    " Talao, " & _
                    " Codigo_Usuario_Cadastro, " & _
                    " Data_Hora_Cadastro " & _
                    "      ) VALUES (" & _
                    " '" & IdMovimento & "'," & _
                    " '" & mData & "'," & _
                    " '" & mTecnico & "', " & _
                    " '" & mPrefeitura & "', " & _
                    " '" & mAssociado & "', " & _
                    " '" & mDocumento & "', " & _
                    " '" & mCanhoto & "', " & _
                    " '" & mTipoAssistencia & "', " & _
                    " '" & mAnimal & "', " & _
                    " '" & mTipoEverminacao & "', " & _
                    " '" & mTipoServico & "', " & _
                    " '" & mCabecas & "', " & _
                    " " & BrancoNull(mSituacao) & ", " & _
                    " " & MoneyNull(mValorMaodeObra) & ", " & _
                    " " & MoneyNull(mValorOutros) & ", " & _
                    " " & MoneyNull(mValorEverminacao) & ", " & _
                    " " & MoneyNull(mValorConducao) & ", " & _
                    " " & MoneyNull(mValorMedicamento) & ", " & _
                    " " & MoneyNull(mValorServico) & ", " & _
                    " " & MoneyNull(mValorEquipamento) & ", " & _
                    " " & MoneyNull(mValorBeneficio) & ", " & _
                    " " & MoneyNull(mValorSemem) & ", " & _
                    " " & MoneyNull(mValorVisita) & ", " & _
                    " '" & mNTouro & "', " & _
                    " '" & mTalao & "', " & _
                    " '" & mCodigo_Usuario_Cadastro & "', " & _
                    " '" & Date.Now & "')"
                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("IncluirMovimento")
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

    Public Function AlterarMovimento() As Integer

        Dim wControle As Integer

        If mIdMovimento = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para alteração!"
            VariaveisGlobais.gStackTraceErro = "Movimentos_Implem->AlterarMovimento()"
            Return -1
        End If

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            '**** Inicio Codigo Novo **************************************************
            Dim wSet As String = ""
            Dim wLog As String = ""

            wComando.CommandText = "SELECT * FROM Ass_Movimento WHERE IdMovimento = '" & mIdMovimento & "'"

            wDataReader = wComando.ExecuteReader
            If Not wDataReader.Read() Then
                wDataReader.Close()
                Return 1
            End If

            If DataNull(mData) <> DataNull(IIf(IsDBNull(wDataReader("Data")), "Null", wDataReader("Data"))) Then
                wSet = wSet & ", Data = " & DataNull(mData)
                wLog = wLog & "|Data\" & DataNull(IIf(IsDBNull(wDataReader("Data")), "Null", wDataReader("Data")))
            End If
            If mAssociado <> NullBranco(wDataReader("Associado")) Then
                wSet = wSet & ", Associado = '" & mAssociado & "'"
                wLog = wLog & "|Associado\" & NullBranco(wDataReader("Associado"))
            End If

            If mTecnico <> NullBranco(wDataReader("Tecnico")) Then
                wSet = wSet & ", Tecnico = '" & mTecnico & "'"
                wLog = wLog & "|Tecnico\" & NullBranco(wDataReader("Tecnico"))
            End If

            If mPrefeitura <> NullBranco(wDataReader("Prefeitura")) Then
                wSet = wSet & ", Prefeitura = '" & mPrefeitura & "'"
                wLog = wLog & "|Prefeitura\" & NullBranco(wDataReader("Prefeitura"))
            End If

            If mTipoAssistencia <> NullBranco(wDataReader("TipoAssistencia")) Then
                wSet = wSet & ", TipoAssistencia = '" & mTipoAssistencia & "'"
                wLog = wLog & "|TipoAssistencia\" & NullBranco(wDataReader("TipoAssistencia"))
            End If

            If mTipoServico <> NullBranco(wDataReader("TipoServico")) Then
                wSet = wSet & ", TipoServico = '" & mTipoServico & "'"
                wLog = wLog & "|TipoServico\" & NullBranco(wDataReader("TipoServico"))
            End If

            If MoneyNull(mAnimal) <> BrancoNull(IIf(IsDBNull(wDataReader("Animal")), "", wDataReader("Animal"))) Then
                wSet = wSet & ", Animal = " & BrancoNull(mAnimal) & ""
                wLog = wLog & "|Animal\" & wDataReader("Animal")
            End If

            If mTalao <> wDataReader("Talao") Then
                wSet = wSet & ", Talao = '" & mTalao & "'"
                wLog = wLog & "|Talao\" & wDataReader("Talao")
            End If

            If BrancoNull(mDocumento) <> BrancoNull(wDataReader("Documento")) Then
                wSet = wSet & ", Documento = " & BrancoNull(mDocumento) & ""
                wLog = wLog & "|Documento\" & wDataReader("Documento")
            End If

            If ZeroNull(mCanhoto) <> ZeroNull(wDataReader("Canhoto")) Then
                wSet = wSet & ", Canhoto = " & ZeroNull(mCanhoto) & ""
                wLog = wLog & "|Canhoto\" & wDataReader("Canhoto")
            End If

            If mTipoEverminacao <> NullBranco(wDataReader("TipoEverminacao")) Then
                wSet = wSet & ", TipoEverminacao = '" & mTipoEverminacao & "'"
                wLog = wLog & "|TipoEverminacao\" & NullBranco(wDataReader("TipoEverminacao"))
            End If

            If ZeroNull(mCabecas) <> ZeroNull(wDataReader("Cabecas")) Then
                wSet = wSet & ", Cabecas = " & ZeroNull(mCabecas) & ""
                wLog = wLog & "|Cabecas\" & wDataReader("Cabecas")
            End If

            If MoneyNull(mValorMaodeObra) <> MoneyNull(IIf(IsDBNull(wDataReader("ValorMaodeObra")), 0, wDataReader("ValorMaodeObra"))) Then
                wSet = wSet & ", ValorMaodeObra = " & MoneyNull(mValorMaodeObra) & ""
                wLog = wLog & "|ValorMaodeObra\" & wDataReader("ValorMaodeObra")
            End If

            If MoneyNull(mValorOutros) <> MoneyNull(IIf(IsDBNull(wDataReader("ValorOutros")), 0, wDataReader("ValorOutros"))) Then
                wSet = wSet & ", ValorOutros = " & MoneyNull(mValorOutros) & ""
                wLog = wLog & "|ValorOutros\" & wDataReader("ValorOutros")
            End If

            If MoneyNull(mValorEverminacao) <> MoneyNull(IIf(IsDBNull(wDataReader("ValorEverminacao")), 0, wDataReader("ValorEverminacao"))) Then
                wSet = wSet & ", ValorEverminacao = " & MoneyNull(mValorEverminacao) & ""
                wLog = wLog & "|ValorEverminacao\" & wDataReader("ValorEverminacao")
            End If

            If MoneyNull(mValorConducao) <> MoneyNull(IIf(IsDBNull(wDataReader("ValorConducao")), 0, wDataReader("ValorConducao"))) Then
                wSet = wSet & ", ValorConducao = " & MoneyNull(mValorConducao) & ""
                wLog = wLog & "|ValorConducao\" & wDataReader("ValorConducao")
            End If

            If MoneyNull(mValorMedicamento) <> MoneyNull(IIf(IsDBNull(wDataReader("ValorMedicamento")), 0, wDataReader("ValorMedicamento"))) Then
                wSet = wSet & ", ValorMedicamento =  " & MoneyNull(mValorMedicamento) & ""
                wLog = wLog & "|ValorMedicamento\" & wDataReader("ValorMedicamento")
            End If

            If MoneyNull(mValorServico) <> MoneyNull(IIf(IsDBNull(wDataReader("ValorServico")), 0, wDataReader("ValorServico"))) Then
                wSet = wSet & ", ValorServico = " & MoneyNull(mValorServico) & ""
                wLog = wLog & "|ValorServico\" & wDataReader("ValorServico")
            End If

            If MoneyNull(mValorVisita) <> MoneyNull(IIf(IsDBNull(wDataReader("ValorVisita")), 0, wDataReader("ValorVisita"))) Then
                wSet = wSet & ", ValorVisita = " & MoneyNull(mValorVisita) & ""
                wLog = wLog & "|ValorVisita\" & wDataReader("ValorVisita")
            End If

            If MoneyNull(mValorEquipamento) <> MoneyNull(IIf(IsDBNull(wDataReader("ValorEquipamento")), 0, wDataReader("ValorEquipamento"))) Then
                wSet = wSet & ", ValorEquipamento = " & MoneyNull(mValorEquipamento) & ""
                wLog = wLog & "|ValorEquipamento\" & wDataReader("ValorEquipamento")
            End If

            If MoneyNull(mValorBeneficio) <> MoneyNull(IIf(IsDBNull(wDataReader("ValorBeneficio")), 0, wDataReader("ValorBeneficio"))) Then
                wSet = wSet & ", ValorBeneficio = " & MoneyNull(mValorBeneficio) & ""
                wLog = wLog & "|ValorBeneficio\" & wDataReader("ValorBeneficio")
            End If

            If MoneyNull(mValorSemem) <> MoneyNull(IIf(IsDBNull(wDataReader("ValorSemem")), 0, wDataReader("ValorSemem"))) Then
                wSet = wSet & ", ValorSemem = " & MoneyNull(mValorSemem) & ""
                wLog = wLog & "|ValorSemem\" & wDataReader("ValorSemem")
            End If

            If mNTouro <> wDataReader("NTouro") Then
                wSet = wSet & ", NTouro = '" & mNTouro & "'"
                wLog = wLog & "|NTouro\" & wDataReader("NTouro")
            End If

            wDataReader.Close()
            If Len(wSet) > 0 Then wSet = wSet.Substring(1, Len(wSet) - 1)
            If Len(wLog) > 0 Then wLog = wLog.Substring(1, Len(wLog) - 1)

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "AlterarTecnico")
            wComando.Transaction = wTransacao

            Try
                If Len(wSet) > 0 Then
                    wComando.CommandText = _
                           " UPDATE Ass_Movimento SET " & wSet & " WHERE " & _
                      "  IdMovimento = '" & mIdMovimento & "'"

                    wComando.ExecuteNonQuery()
                    Dim Log As String = "C_LOG"
                    Dim Tab As String = "Ass_Movimento"
                    Dim Chave As String = mIdMovimento
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
                wTransacao.Rollback("AlterarMovimento")
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

    Public Function ExcluirMovimento() As Integer

        Try
            Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim wDataSet As DataSet = New DataSet

            If mIdMovimento = "" Then
                VariaveisGlobais.gUltimoSQL = ""
                VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para exclusão!"
                VariaveisGlobais.gStackTraceErro = "Movimento_Implem->ExcluirMovimento()"
                Return -1
            End If

            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ExcluirMovimento")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = " UPDATE Ass_Movimento SET " & _
                                    " Codigo_Usuario_Exclusao = '" & VariaveisGlobais.gCodigoUsuario & "',    " & _
                                    " Data_Hora_Exclusao = '" & Date.Now & "'    " & _
                                    " WHERE    " & _
                                    " IdMovimento = '" & mIdMovimento & "'"

                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("ExcluirMovimento")
            End Try

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function MostraTabelaMovimentos(ByRef pObjTabela As System.Windows.Forms.DataGridView, _
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

            wDataSet.Tables(0).Columns(0).ColumnName = "IdMov"
            wDataSet.Tables(0).Columns(1).ColumnName = "Data"
            wDataSet.Tables(0).Columns(2).ColumnName = "Técnico"
            wDataSet.Tables(0).Columns(3).ColumnName = "Associado"
            wDataSet.Tables(0).Columns(4).ColumnName = "Documento"
            wDataSet.Tables(0).Columns(5).ColumnName = "Assistência"
            wDataSet.Tables(0).Columns(6).ColumnName = "Serviço"
            wDataSet.Tables(0).Columns(7).ColumnName = "Animal"
           
            Dim wDataTable As New DataTable()
            wDataTable = wDataSet.Tables(0)

            wDataTable.Columns.Add("Altera", GetType(Image))
            Dim wicon As Image = Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "lupa.gif")
            For i As Integer = 0 To wDataTable.Rows.Count - 1
                wDataTable.Rows(i)(8) = wicon
            Next

            Dim wDataView = New DataView(wDataTable, "", "", DataViewRowState.CurrentRows)

            pObjTabela.Columns.Clear()
            pObjTabela.DataSource = wDataView

            If CDec(pObjTabela.Tag) = 0 Then pObjTabela.Tag = "1" '/ CDec(pObjTabela.Tag)
            pObjTabela.Columns(0).Width = 50 / CDec(pObjTabela.Tag) 'IdMovimento
            pObjTabela.Columns(1).Width = 80 / CDec(pObjTabela.Tag) 'Data
            pObjTabela.Columns(2).Width = 100 / CDec(pObjTabela.Tag) 'Tecnico
            pObjTabela.Columns(3).Width = 100 / CDec(pObjTabela.Tag) 'Associado
            pObjTabela.Columns(4).Width = 80 / CDec(pObjTabela.Tag) 'Documento
            pObjTabela.Columns(5).Width = 80 / CDec(pObjTabela.Tag) 'Assistencia
            pObjTabela.Columns(6).Width = 80 / CDec(pObjTabela.Tag) 'Servico
            pObjTabela.Columns(7).Width = 80 / CDec(pObjTabela.Tag) 'Animal
            pObjTabela.Columns(8).Width = 17 / CDec(pObjTabela.Tag) 'Lupa

            pObjTabela.RowHeadersWidth = 10

            For i As Integer = 0 To 8
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


