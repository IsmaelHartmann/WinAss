Imports System.Data.SqlClient

Public Class Programas_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    Private mPrograma As String
    Private mDescricao As String
    Private mDataCadastro As String
    Private mUsuarioCadastro As String

    Private wComando As SqlCommand
    Private wDataReader As SqlDataReader
    Public wDataSet As DataSet

#End Region

#Region " Propriedades "

    Public Property Programa() As String
        Get
            Return mPrograma
        End Get
        Set(ByVal Value As String)
            mPrograma = Value
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

    Public Function VerificaExistenciaPrograma() As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM C_Programas WHERE Nome='" & mPrograma & "'"

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

    Public Function BuscarPrograma() As Integer
        Dim wTmp As Integer
        If mPrograma = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "CadastroProgramas_Implem->BuscarPrograma()"
            Return -1
        End If

        wTmp = VerificaExistenciaPrograma()
        If wTmp <> 0 Then Return wTmp
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = "SELECT * FROM C_Programas WHERE Nome ='" & mPrograma & "'"
            wDataReader = wComando.ExecuteReader

            If wDataReader.Read() Then
                mPrograma = wDataReader("Nome")
                mDataCadastro = IIf(IsDBNull(wDataReader("DataCadastro")), "", wDataReader("DataCadastro"))
                mUsuarioCadastro = IIf(IsDBNull(wDataReader("UsuarioCadastro")), "", wDataReader("UsuarioCadastro"))
                mDescricao = IIf(IsDBNull(wDataReader("Descricao")), "", wDataReader("Descricao"))
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

    Public Function IncluirPrograma() As Integer
        Try

            Dim wControle As Integer

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle


            wControle = VerificaExistenciaPrograma()
            If wControle = 0 Then Return 1
            If wControle <> 1 Then Return wControle
 
            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "IncluirPrograma")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = _
                     " INSERT INTO C_Programas (Nome, " & _
                     " Descricao, " & _
                     " DataCadastro, " & _
                     " UsuarioCadastro " & _
                     " ) VALUES (" & _
                     " '" & mPrograma & "', " & _
                     " " & BrancoNull(mDescricao) & ", " & _
                     " '" & Date.Now & "', " & _
                     " '" & mUsuarioCadastro & "' " & _
                     ")  "

                wComando.ExecuteNonQuery()

                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("IncluirPrograma")
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

    Public Function AlterarPrograma() As Integer

        Dim wControle As Integer


        If mPrograma = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para alteração!"
            VariaveisGlobais.gStackTraceErro = "Programas_Implem->AlterarPrograma()"
            Return -1
        End If

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            '**** Inicio Codigo Novo **************************************************
            Dim wSet As String = ""
            Dim wLog As String = ""

            wComando.CommandText = "SELECT * FROM C_Programas  WHERE " & _
                " Nome ='" & mPrograma & "'"

            wDataReader = wComando.ExecuteReader
            If Not wDataReader.Read() Then
                wDataReader.Close()
                Return 1
            End If


            If BrancoNull(mDescricao) <> BrancoNull(IIf(IsDBNull(wDataReader("Descricao")), "", wDataReader("Descricao"))) Then
                wSet = wSet & ", Descricao =  " & BrancoNull(mDescricao) & " "
                wLog = wLog & "|Descricao\" & wDataReader("Descricao")
            End If


            wDataReader.Close()
            If Len(wSet) > 0 Then wSet = wSet.Substring(1, Len(wSet) - 1)
            If Len(wLog) > 0 Then wLog = wLog.Substring(1, Len(wLog) - 1)

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "AlterarPrograma")
            wComando.Transaction = wTransacao

            Try
                If Len(wSet) > 0 Then
                    wComando.CommandText = _
                        " UPDATE C_Programas SET " & wSet & " WHERE " & _
                        " Nome='" & mPrograma & "'"

                    wComando.ExecuteNonQuery()
                    Dim Log As String = "C_LOG"
                    Dim Tab As String = "C_Programas"
                    Dim Chave As String = mPrograma
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
                wTransacao.Rollback("AlterarPrograma")
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

    Private Function VerificaDependenciasPrograma() As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = "SELECT * FROM C_ProgramasLiberacoes WHERE NomePrograma='" & mPrograma & "'"

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                wDataReader.Close()
                VariaveisGlobais.gDescricaoUltimoErro = " Programas Liberações !"
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

    Public Function ExcluirPrograma() As Integer

        Try
            Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim wDataSet As DataSet = New DataSet

            If mPrograma = "" Then
                VariaveisGlobais.gUltimoSQL = ""
                VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para exclusão!"
                VariaveisGlobais.gStackTraceErro = "Programas_Implem->ExcluirPrograma()"
                Return -1
            End If

            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wControle = VerificaDependenciasPrograma()
            If wControle <> 0 Then Return wControle

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ExcluirPrograma")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = " UPDATE C_Programas SET " & _
                                    " UsuarioExclusao='" & VariaveisGlobais.gCodigoUsuario & "',    " & _
                                    " DataExclusao='" & Date.Now & "'    " & _
                                    " WHERE    " & _
                                    " Nome='" & mPrograma & "'"

                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("ExcluirPrograma")
            End Try

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function MostraTabelaProgramas(ByRef pObjTabela As System.Windows.Forms.DataGridView, _
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

            wDataSet.Tables(0).Columns(0).ColumnName = "Codigo"
 
            Dim wDataTable As New DataTable()
            wDataTable = wDataSet.Tables(0)

            wDataTable.Columns.Add("Altera", GetType(Image))
            Dim wicon As Image = Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "lupa.gif")
            For i As Integer = 0 To wDataTable.Rows.Count - 1
                wDataTable.Rows(i)(1) = wicon
            Next

            Dim wDataView = New DataView(wDataTable, "", "", DataViewRowState.CurrentRows)

            pObjTabela.Columns.Clear()
            pObjTabela.DataSource = wDataView

            If CDec(pObjTabela.Tag) = 0 Then pObjTabela.Tag = "1"
            pObjTabela.Columns(0).Width = 220 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(1).Width = 17 / CDec(pObjTabela.Tag)

            pObjTabela.RowHeadersWidth = 10

            For i As Integer = 0 To 1
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


