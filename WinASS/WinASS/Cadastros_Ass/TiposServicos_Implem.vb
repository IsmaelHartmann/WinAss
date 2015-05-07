Imports System.Data.SqlClient

Public Class TiposServicos_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    Private mCodigo As String
    Private mDescricao As String
    Private mIVisita As String
    Private mIAnimal As String
    Private mIConducao As String
    Private mIMedicamento As String
    Private mIAssistencia As String
    Private mIEquipamento As String
    Private mIBeneficio As String
    Private mIServico As String
    Private mISemem As String

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

    Public Property Descricao() As String
        Get
            Return mDescricao
        End Get
        Set(ByVal Value As String)
            mDescricao = Value
        End Set
    End Property

    Public Property IVisita() As String
        Get
            Return mIVisita
        End Get
        Set(ByVal Value As String)
            mIVisita = Value
        End Set
    End Property

    Public Property IAnimal() As String
        Get
            Return mIAnimal
        End Get
        Set(ByVal Value As String)
            mIAnimal = Value
        End Set
    End Property


    Public Property IConducao() As String
        Get
            Return mIConducao
        End Get
        Set(ByVal Value As String)
            mIConducao = Value
        End Set
    End Property

    Public Property IMedicamento() As String
        Get
            Return mIMedicamento
        End Get
        Set(ByVal Value As String)
            mIMedicamento = Value
        End Set
    End Property

    Public Property IAssistencia() As String
        Get
            Return mIAssistencia
        End Get
        Set(ByVal Value As String)
            mIAssistencia = Value
        End Set
    End Property

    Public Property IEquipamento() As String
        Get
            Return mIEquipamento
        End Get
        Set(ByVal Value As String)
            mIEquipamento = Value
        End Set
    End Property

    Public Property IBeneficio() As String
        Get
            Return mIBeneficio
        End Get
        Set(ByVal Value As String)
            mIBeneficio = Value
        End Set
    End Property

    Public Property IServico() As String
        Get
            Return mIServico
        End Get
        Set(ByVal Value As String)
            mIServico = Value
        End Set
    End Property

    Public Property ISemem() As String
        Get
            Return mISemem
        End Get
        Set(ByVal Value As String)
            mISemem = Value
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

    Public Function VerificaExistenciaServico() As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM Ass_TipoServico WHERE Codigo='" & mCodigo & "'"

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

    Public Function VerificaDependenciaServico(ByVal pCodigo As String) As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM Ass_Movimento " & _
                                   " WHERE TipoServico ='" & pCodigo & "'" & _
                                   " AND isnull(Data_Hora_Exclusao,'') = '' "
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                wDataReader.Close()
                VariaveisGlobais.gDescricaoUltimoErro = " Tipo de Servico presente em Movimentos!"
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

    Public Function BuscarServico() As Integer

        Dim wTmp As Integer
        If mCodigo = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "CadastroTiposServicos_Implem->BuscarServico()"
            Return -1
        End If

        wTmp = VerificaExistenciaServico()
        If wTmp <> 0 Then Return wTmp
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM Ass_TipoServico WHERE Codigo='" & mCodigo & "'"
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mCodigo = wDataReader("Codigo")
                mDescricao = IIf(IsDBNull(wDataReader("Descricao")), "", wDataReader("Descricao"))
                mIVisita = IIf(IsDBNull(wDataReader("IVisita")), "S", wDataReader("IVisita"))
                mIAnimal = IIf(IsDBNull(wDataReader("IAnimal")), "S", wDataReader("IAnimal"))
                mIConducao = IIf(IsDBNull(wDataReader("IConducao")), "S", wDataReader("IConducao"))
                mIMedicamento = IIf(IsDBNull(wDataReader("IMedicamento")), "S", wDataReader("IMedicamento"))
                mIServico = IIf(IsDBNull(wDataReader("IServico")), "S", wDataReader("IServico"))
                mIEquipamento = IIf(IsDBNull(wDataReader("IEquipamento")), "S", wDataReader("IEquipamento"))
                mIBeneficio = IIf(IsDBNull(wDataReader("IBeneficio")), "S", wDataReader("IBeneficio"))
                mISemem = IIf(IsDBNull(wDataReader("ISemem")), "S", wDataReader("ISemem"))
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

    Public Function IncluirServico() As Integer
        Try

            Dim wControle As Integer

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle


            wComando.CommandText = " SELECT isnull(max(cast(Codigo as integer)),0)+1 Codigo " & _
                                " FROM Ass_TipoServico WHERE isnumeric(Codigo)<>0 "
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mCodigo = wDataReader("Codigo")
            Else
                mCodigo = 1
            End If
            wDataReader.Close()

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "IncluirServico")
            wComando.Transaction = wTransacao

            Try

                If mCodigo <= 0 Then
                    Throw New Exception("Código zero é inválido !")
                End If

                wComando.CommandText = _
                    "INSERT INTO Ass_TipoServico (Codigo, " & _
                    " Descricao, " & _
                    " IVisita, " & _
                    " IAnimal, " & _
                    " IConducao, " & _
                    " IMedicamento, " & _
                    " IServico, " & _
                    " IEquipamento, " & _
                    " IBeneficio, " & _
                    " ISemem, " & _
                    " Data_Hora_Cadastro, " & _
                    " Codigo_Usuario_Cadastro " & _
                    ") VALUES (" & _
                    "'" & mCodigo & "'," & _
                    "'" & mDescricao & "'," & _
                    "'" & mIVisita & "'," & _
                    "'" & mIAnimal & "'," & _
                    "'" & mIConducao & "'," & _
                    "'" & mIMedicamento & "'," & _
                    "'" & mIServico & "'," & _
                    "'" & mIEquipamento & "'," & _
                    "'" & mIBeneficio & "'," & _
                    "'" & mISemem & "'," & _
                    "'" & ConverteDataHoraParaString(Now.Date) & "'," & _
                    "'" & VariaveisGlobais.gCodigoUsuario & "')"

                wComando.ExecuteNonQuery()

                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("IncluirServico")
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

    Public Function AlterarServico() As Integer

        Dim wControle As Integer


        If mCodigo = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para alteração!"
            VariaveisGlobais.gStackTraceErro = "TiposServicos_Implem->AlterarServico()"
            Return -1
        End If

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            '**** Inicio Codigo Novo **************************************************
            Dim wSet As String = ""
            Dim wLog As String = ""

            wComando.CommandText = "SELECT * FROM Ass_TipoServico WHERE Codigo='" & mCodigo & "'"

            wDataReader = wComando.ExecuteReader
            If Not wDataReader.Read() Then
                wDataReader.Close()
                Return 1
            End If

            If mDescricao <> wDataReader("Descricao") Then
                wSet = wSet & ", Descricao = '" & mDescricao & "'"
                wLog = wLog & "|Descricao\" & wDataReader("Descricao")
            End If

            If NullBranco(mIVisita) <> NullBranco(wDataReader("IVisita")) Then
                wSet = wSet & ", IVisita = '" & NullBranco(mIVisita) & "'"
                wLog = wLog & "|IVisita\" & wDataReader("IVisita")
            End If

            If NullBranco(mIAnimal) <> NullBranco(wDataReader("IAnimal")) Then
                wSet = wSet & ", IAnimal = '" & NullBranco(mIAnimal) & "'"
                wLog = wLog & "|IAnimal\" & wDataReader("IAnimal")
            End If

            If NullBranco(mIConducao) <> NullBranco(wDataReader("IConducao")) Then
                wSet = wSet & ", IConducao = '" & NullBranco(mIConducao) & "'"
                wLog = wLog & "|IConducao\" & wDataReader("IConducao")
            End If

            If NullBranco(mIMedicamento) <> NullBranco(wDataReader("IMedicamento")) Then
                wSet = wSet & ", IMedicamento = '" & NullBranco(mIMedicamento) & "'"
                wLog = wLog & "|IMedicamento\" & wDataReader("IMedicamento")
            End If

            If NullBranco(mIServico) <> NullBranco(wDataReader("IServico")) Then
                wSet = wSet & ", IServico = '" & NullBranco(mIServico) & "'"
                wLog = wLog & "|IServico\" & wDataReader("IServico")
            End If

            If NullBranco(mIEquipamento) <> NullBranco(wDataReader("IEquipamento")) Then
                wSet = wSet & ", IEquipamento = '" & NullBranco(mIEquipamento) & "'"
                wLog = wLog & "|IEquipamento\" & wDataReader("IEquipamento")
            End If

            If NullBranco(mIBeneficio) <> NullBranco(wDataReader("IBeneficio")) Then
                wSet = wSet & ", IBeneficio = '" & NullBranco(mIBeneficio) & "'"
                wLog = wLog & "|IBeneficio\" & wDataReader("IBeneficio")
            End If

            If NullBranco(mISemem) <> NullBranco(wDataReader("ISemem")) Then
                wSet = wSet & ", ISemem = '" & NullBranco(mISemem) & "'"
                wLog = wLog & "|ISemem\" & wDataReader("ISemem")
            End If

            wDataReader.Close()
            If Len(wSet) > 0 Then wSet = wSet.Substring(1, Len(wSet) - 1)
            If Len(wLog) > 0 Then wLog = wLog.Substring(1, Len(wLog) - 1)

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "AlterarServico")
            wComando.Transaction = wTransacao

            Try
                If Len(wSet) > 0 Then
                    wComando.CommandText = _
                           " UPDATE Ass_TipoServico SET " & wSet & " WHERE " & _
                      "  Codigo='" & mCodigo & "'"

                    wComando.ExecuteNonQuery()
                    Dim Log As String = "C_LOG"
                    Dim Tab As String = "Ass_TipoServico"
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
                wTransacao.Rollback("AlterarServico")
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

    Public Function ExcluirServico() As Integer

        Try
            Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim wDataSet As DataSet = New DataSet

            If mCodigo = "" Then
                VariaveisGlobais.gUltimoSQL = ""
                VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para exclusão!"
                VariaveisGlobais.gStackTraceErro = "Servicos_Implem->ExcluirServico()"
                Return -1
            End If

            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wControle = VerificaDependenciaServico(mCodigo)
            If wControle <> 0 Then Return wControle

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ExcluirServico")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = " UPDATE Ass_TipoServico SET " & _
                                    " Codigo_Usuario_Exclusao = '" & VariaveisGlobais.gCodigoUsuario & "',    " & _
                                    " Data_Hora_Exclusao = '" & Date.Now & "'    " & _
                                    " WHERE    " & _
                                    " Codigo='" & mCodigo & "'"
                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("ExcluirServico")
            End Try

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function MostraTabelaTiposServicos(ByRef pObjTabela As System.Windows.Forms.DataGridView, _
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
            wDataSet.Tables(0).Columns(1).ColumnName = "Descrição"
            wDataSet.Tables(0).Columns(2).ColumnName = "Visita"
            wDataSet.Tables(0).Columns(3).ColumnName = "Animal"
            wDataSet.Tables(0).Columns(4).ColumnName = "Condução"
            wDataSet.Tables(0).Columns(5).ColumnName = "Medicamento"
            wDataSet.Tables(0).Columns(6).ColumnName = "Serviço"
            wDataSet.Tables(0).Columns(7).ColumnName = "Equipamento"
            wDataSet.Tables(0).Columns(8).ColumnName = "Benefício"
            wDataSet.Tables(0).Columns(9).ColumnName = "Semem"


            Dim wDataTable As New DataTable()
            wDataTable = wDataSet.Tables(0)

            wDataTable.Columns.Add("Altera", GetType(Image))
            Dim wicon As Image = Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "lupa.gif")
            For i As Integer = 0 To wDataTable.Rows.Count - 1
                wDataTable.Rows(i)(10) = wicon
            Next

            Dim wDataView = New DataView(wDataTable, "", "", DataViewRowState.CurrentRows)

            pObjTabela.Columns.Clear()
            pObjTabela.DataSource = wDataView

            If CDec(pObjTabela.Tag) = 0 Then pObjTabela.Tag = "1" '/ CDec(pObjTabela.Tag)
            pObjTabela.Columns(0).Width = 50 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(1).Width = 120 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(2).Width = 60 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(3).Width = 60 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(4).Width = 60 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(5).Width = 60 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(6).Width = 60 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(7).Width = 60 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(8).Width = 60 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(9).Width = 60 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(10).Width = 17 / CDec(pObjTabela.Tag)

            pObjTabela.RowHeadersWidth = 10

            For i As Integer = 0 To 10
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


