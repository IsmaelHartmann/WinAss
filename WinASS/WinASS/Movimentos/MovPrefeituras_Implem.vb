Imports System.Data.SqlClient

Public Class MovPrefeituras_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    Private mIdMovimento As String
    Private mData As String
    Private mTecnico As String
    Private mPrefeitura As String
    Private mAssociado As String
    Private mTipoServico As String
    Private mValor As Decimal
    Private mNumeroTestes As Integer

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

    Public Property TipoServico() As String
        Get
            Return mTipoServico
        End Get
        Set(ByVal Value As String)
            mTipoServico = Value
        End Set
    End Property

    Public Property Valor() As Decimal
        Get
            Return mValor
        End Get
        Set(ByVal Value As Decimal)
            mValor = Value
        End Set
    End Property

    Public Property NumeroTestes() As Integer
        Get
            Return mNumeroTestes
        End Get
        Set(ByVal Value As Integer)
            mNumeroTestes = Value
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

    Public Function VerificaExistenciaMovPrefeituras() As Integer

        Dim wControle As Integer

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle


            wComando.CommandText = "SELECT * FROM Ass_MovPrefeituras WHERE " & _
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

    Public Function BuscarMovPrefeituras() As Integer

        Dim wControle As Integer

        If mIdMovimento = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Campo Incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "MovPrefeiturass_Implem->BuscarMovPrefeituras()"
            Return 1
        End If

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = _
                " SELECT * FROM Ass_MovPrefeituras " & _
                " WHERE IdMovimento = '" & mIdMovimento & "'"

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mIdMovimento = wDataReader("IdMovimento")
                mData = wDataReader("Data")
                mTecnico = wDataReader("Tecnico")
                mPrefeitura = NullBranco(wDataReader("Prefeitura"))
                mAssociado = wDataReader("Associado")
                mNumeroTestes = NullBranco(wDataReader("NumeroTestes"))
                mTipoServico = NullBranco(wDataReader("TipoServico"))
                mValor = IIf(IsDBNull(wDataReader("Valor")), 0, wDataReader("Valor"))
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

    Public Function IncluirMovPrefeituras() As Integer
        Try

            Dim wControle As Integer

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle


            wComando.CommandText = " SELECT isnull(max(cast(IdMovimento as integer)),0)+1 IdMovimento " & _
                                " FROM Ass_MovPrefeituras WHERE isnumeric(IdMovimento)<>0 "
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mIdMovimento = wDataReader("IdMovimento")
            Else
                mIdMovimento = 1
            End If
            wDataReader.Close()


            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "IncluirMovPrefeituras")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = _
                    "INSERT INTO Ass_MovPrefeituras (IdMovimento, " & _
                    " Data, " & _
                    " Tecnico, " & _
                    " Prefeitura, " & _
                    " Associado, " & _
                    " TipoServico, " & _
                    " Valor, " & _
                    " NumeroTestes, " & _
                    " Codigo_Usuario_Cadastro, " & _
                    " Data_Hora_Cadastro " & _
                    "      ) VALUES (" & _
                    " '" & IdMovimento & "'," & _
                    BrancoNull(mData) & "," & _
                    BrancoNull(mTecnico) & ", " & _
                    BrancoNull(mPrefeitura) & ", " & _
                    BrancoNull(mAssociado) & ", " & _
                    BrancoNull(mTipoServico) & ", " & _
                    ZeroNull(mValor) & ", " & _
                    ZeroNull(mNumeroTestes) & ", " & _
                    " '" & mCodigo_Usuario_Cadastro & "', " & _
                    " '" & Date.Now & "')"
                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("IncluirMovPrefeituras")
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

    Public Function AlterarMovPrefeituras() As Integer

        Dim wControle As Integer

        If mIdMovimento = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para alteração!"
            VariaveisGlobais.gStackTraceErro = "MovPrefeiturass_Implem->AlterarMovPrefeituras()"
            Return -1
        End If

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            '**** Inicio Codigo Novo **************************************************
            Dim wSet As String = ""
            Dim wLog As String = ""

            wComando.CommandText = "SELECT * FROM Ass_MovPrefeituras WHERE IdMovimento = '" & mIdMovimento & "'"

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

            If mTipoServico <> NullBranco(wDataReader("TipoServico")) Then
                wSet = wSet & ", TipoServico = '" & mTipoServico & "'"
                wLog = wLog & "|TipoServico\" & NullBranco(wDataReader("TipoServico"))
            End If

            If MoneyNull(mValor) <> MoneyNull(IIf(IsDBNull(wDataReader("Valor")), 0, wDataReader("Valor"))) Then
                wSet = wSet & ", Valor = " & MoneyNull(mValor) & ""
                wLog = wLog & "|Valor\" & wDataReader("Valor")
            End If

            If ZeroNull(mNumeroTestes) <> ZeroNull(wDataReader("NumeroTestes")) Then
                wSet = wSet & ", NumeroTestes = " & BrancoNull(mNumeroTestes) & ""
                wLog = wLog & "|NumeroTestes\" & wDataReader("NumeroTestes")
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
                           " UPDATE Ass_MovPrefeituras SET " & wSet & " WHERE " & _
                      "  IdMovimento = '" & mIdMovimento & "'"

                    wComando.ExecuteNonQuery()
                    Dim Log As String = "C_LOG"
                    Dim Tab As String = "Ass_MovPrefeituras"
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
                wTransacao.Rollback("AlterarMovPrefeituras")
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

    Public Function ExcluirMovPrefeituras() As Integer

        Try
            Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim wDataSet As DataSet = New DataSet

            If mIdMovimento = "" Then
                VariaveisGlobais.gUltimoSQL = ""
                VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para exclusão!"
                VariaveisGlobais.gStackTraceErro = "MovPrefeituras_Implem->ExcluirMovPrefeituras()"
                Return -1
            End If

            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ExcluirMovPrefeituras")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = " UPDATE Ass_MovPrefeituras SET " & _
                                    " Codigo_Usuario_Exclusao = '" & VariaveisGlobais.gCodigoUsuario & "',    " & _
                                    " Data_Hora_Exclusao = '" & Date.Now & "'    " & _
                                    " WHERE    " & _
                                    " IdMovimento = '" & mIdMovimento & "'"

                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("ExcluirMovPrefeituras")
            End Try

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function MostraTabelaMovPrefeituras(ByRef pObjTabela As System.Windows.Forms.DataGridView, _
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
            wDataSet.Tables(0).Columns(1).ColumnName = "Prefeitura"
            wDataSet.Tables(0).Columns(2).ColumnName = "Data"
            wDataSet.Tables(0).Columns(3).ColumnName = "Produtor"
            wDataSet.Tables(0).Columns(4).ColumnName = "Localidade"
            wDataSet.Tables(0).Columns(5).ColumnName = "Inscrição"
            wDataSet.Tables(0).Columns(6).ColumnName = "Inseminador"
            wDataSet.Tables(0).Columns(7).ColumnName = "Valor"
            wDataSet.Tables(0).Columns(8).ColumnName = "CRMV"
            wDataSet.Tables(0).Columns(9).ColumnName = "NTestes"
            wDataSet.Tables(0).Columns(10).ColumnName = "CodigoTipoServico"

            Dim wDataTable As New DataTable()
            wDataTable = wDataSet.Tables(0)

            wDataTable.Columns.Add("Altera", GetType(Image))
            Dim wicon As Image = Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "lupa.gif")
            For i As Integer = 0 To wDataTable.Rows.Count - 1
                wDataTable.Rows(i)(11) = wicon
            Next

            Dim wDataView = New DataView(wDataTable, "", "", DataViewRowState.CurrentRows)

            pObjTabela.Columns.Clear()
            pObjTabela.DataSource = wDataView

            If CDec(pObjTabela.Tag) = 0 Then pObjTabela.Tag = "1" '/ CDec(pObjTabela.Tag)
            pObjTabela.Columns(0).Width = 15 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(1).Width = 50 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(2).Width = 40 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            pObjTabela.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            pObjTabela.Columns(5).Width = 40 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(6).Width = 60 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(7).Width = 25 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(8).Visible = False
            pObjTabela.Columns(9).Visible = False
            pObjTabela.Columns(10).Visible = False
            pObjTabela.Columns(11).Width = 22 / CDec(pObjTabela.Tag) 'Lupa

            pObjTabela.RowHeadersWidth = 11

            For i As Integer = 0 To 11
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


