Imports System.Data.SqlClient

Public Class Tecnicos_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    Private mCodigo As String
    Private mCRMV As String
    Private mNomeTecnico As String
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

    Public Property CRMV() As String
        Get
            Return mCRMV
        End Get
        Set(ByVal Value As String)
            mCRMV = Value
        End Set
    End Property


    Public Property NomeTecnico() As String
        Get
            Return mNomeTecnico
        End Get
        Set(ByVal Value As String)
            mNomeTecnico = Value
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

    Public Function VerificaExistenciaTecnico() As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM Ass_Tecnicos WHERE Codigo='" & mCodigo & "'" & _
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

    Public Function BuscarTecnico() As Integer

        Dim wTmp As Integer
        If mCodigo = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "CadastroTecnicos_Implem->BuscarTecnico()"
            Return -1
        End If

        wTmp = VerificaExistenciaTecnico()
        If wTmp <> 0 Then Return wTmp
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM Ass_Tecnicos WHERE Codigo='" & mCodigo & "'"
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mCodigo = wDataReader("Codigo")
                mCRMV = IIf(IsDBNull(wDataReader("CRMV")), "", wDataReader("CRMV"))
                mNomeTecnico = IIf(IsDBNull(wDataReader("Nome")), "", wDataReader("Nome"))
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

    Public Function IncluirTecnico() As Integer
        Try

            Dim wControle As Integer

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle


            wComando.CommandText = " SELECT isnull(max(cast(Codigo as integer)),0)+1 Codigo " & _
                                " FROM Ass_Tecnicos WHERE isnumeric(Codigo)<>0 "
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mCodigo = wDataReader("Codigo")
            Else
                mCodigo = 1
            End If
            wDataReader.Close()


            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "IncluirTecnico")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = " INSERT INTO Ass_Tecnicos (Codigo,  " & _
                        "                CRMV,                       " & _
                        "                Nome,                       " & _
                        "                Codigo_Usuario_Cadastro,  " & _
                        "                Data_Hora_Cadastro  " & _
                        "                 ) VALUES (" & _
                        "                      '" & mCodigo & "',               " & _
                        "                      '" & mCRMV & "',           " & _
                        "                      '" & mNomeTecnico & "',           " & _
                        "                      '" & mCodigo_Usuario_Cadastro & "', " & _
                        "                      '" & Date.Now & "' )  "
                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("IncluirTecnico")
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

    Public Function AlterarTecnico() As Integer

        Dim wControle As Integer


        If mCodigo = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para alteração!"
            VariaveisGlobais.gStackTraceErro = "Tecnicos_Implem->AlterarTecnico()"
            Return -1
        End If

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            '**** Inicio Codigo Novo **************************************************
            Dim wSet As String = ""
            Dim wLog As String = ""

            wComando.CommandText = "SELECT * FROM Ass_Tecnicos WHERE Codigo='" & mCodigo & "'"

            wDataReader = wComando.ExecuteReader
            If Not wDataReader.Read() Then
                wDataReader.Close()
                Return 1
            End If

            If mNomeTecnico <> NullBranco(wDataReader("Nome")) Then
                wSet = wSet & ", Nome = '" & mNomeTecnico & "'"
                wLog = wLog & "|Nome\" & NullBranco(wDataReader("Nome"))
            End If

            If mCRMV <> NullBranco(wDataReader("CRMV")) Then
                wSet = wSet & ", CRMV = '" & mCRMV & "'"
                wLog = wLog & "|CRMV\" & NullBranco(wDataReader("CRMV"))
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
                           " UPDATE Ass_Tecnicos SET " & wSet & " WHERE " & _
                      "  Codigo='" & mCodigo & "'"

                    wComando.ExecuteNonQuery()
                    Dim Log As String = "C_LOG"
                    Dim Tab As String = "Ass_Tecnicos"
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
                wTransacao.Rollback("AlterarTecnicos")
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

    Public Function ExcluirTecnico() As Integer

        Try
            Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim wDataSet As DataSet = New DataSet

            If mCodigo = "" Then
                VariaveisGlobais.gUltimoSQL = ""
                VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para exclusão!"
                VariaveisGlobais.gStackTraceErro = "Tecnicos_Implem->ExcluirTecnico()"
                Return -1
            End If

            Dim wControle As Integer
            wControle = VerificaDependenciaTecnico(mCodigo)
            If wControle <> 0 Then Return wControle

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ExcluirTecnico")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = " UPDATE Ass_Tecnicos SET " & _
                                    " Codigo_Usuario_Exclusao = '" & VariaveisGlobais.gCodigoUsuario & "',    " & _
                                    " Data_Hora_Exclusao = '" & Date.Now & "'    " & _
                                    " WHERE    " & _
                                    " Codigo='" & mCodigo & "'"

                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("ExcluirTecnico")
            End Try

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function VerificaDependenciaTecnico(ByVal pCodigo As String) As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM Ass_Movimento " & _
                                   " WHERE Tecnico ='" & pCodigo & "'" & _
                                   " AND isnull(Data_Hora_Exclusao,'') = '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                wDataReader.Close()
                VariaveisGlobais.gDescricaoUltimoErro = " Técnico é usado em Movimentos!"
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

    Public Function MostraTabelaTecnicos(ByRef pObjTabela As System.Windows.Forms.DataGridView, _
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
            pObjTabela.Columns(0).Width = 50 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(1).Width = 300 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(2).Width = 17 / CDec(pObjTabela.Tag)

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


