Imports System.Data.SqlClient

Public Class ProgramasLiberacoes_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    Private mSetor As String
    Private mTipoUsuario As String
    Private mUsuario As String
    Private mNomePrograma As String
    Private mIncluir As String
    Private mAlterar As String
    Private mExcluir As String
    Private mDataCadastro As String
    Private mUsuarioCadastro As String

    Private wComando As SqlCommand
    Private wDataReader As SqlDataReader
    Public wDataSet As DataSet

#End Region

#Region " Propriedades "

    Public Property Setor() As String
        Get
            Return mSetor
        End Get
        Set(ByVal Value As String)
            mSetor = Value
        End Set
    End Property
    Public Property TipoUsuario() As String
        Get
            Return mTipoUsuario
        End Get
        Set(ByVal Value As String)
            mTipoUsuario = Value
        End Set
    End Property
    Public Property Usuario() As String
        Get
            Return mUsuario
        End Get
        Set(ByVal Value As String)
            mUsuario = Value
        End Set
    End Property
    Public Property NomePrograma() As String
        Get
            Return mNomePrograma
        End Get
        Set(ByVal Value As String)
            mNomePrograma = Value
        End Set
    End Property
    Public Property Incluir() As String
        Get
            Return mIncluir
        End Get
        Set(ByVal Value As String)
            mIncluir = Value
        End Set
    End Property
    Public Property Alterar() As String
        Get
            Return mAlterar
        End Get
        Set(ByVal Value As String)
            mAlterar = Value
        End Set
    End Property
    Public Property Excluir() As String
        Get
            Return mExcluir
        End Get
        Set(ByVal Value As String)
            mExcluir = Value
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

    Public Function VerificaExistenciaProgramaLiberacao() As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = _
                  "SELECT * FROM C_ProgramasLiberacoes " & _
                  " WHERE NomePrograma='" & mNomePrograma & "'" & _
                  " AND CodigoSetor= '" & mSetor & "'" & _
                  " AND TipoUsuario= '" & mTipoUsuario & "'" & _
                  " AND Usuario= '" & mUsuario & "'"

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

    Public Function BuscarProgramaLiberacao() As Integer
        Dim wTmp As Integer
        If mNomePrograma = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "CadastroProgramasLiberacoes_Implem->BuscarProgramaLiberacao()"
            Return -1
        End If

        wTmp = VerificaExistenciaProgramaLiberacao()
        If wTmp <> 0 Then Return wTmp
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = _
               "SELECT * FROM C_ProgramasLiberacoes " & _
               " WHERE NomePrograma='" & mNomePrograma & "'" & _
               " AND CodigoSetor= '" & mSetor & "'" & _
               " AND TipoUsuario= '" & mTipoUsuario & "'" & _
               " AND Usuario= '" & mUsuario & "'"

            wDataReader = wComando.ExecuteReader

            If wDataReader.Read() Then
                mNomePrograma = IIf(IsDBNull(wDataReader("NomePrograma")), "", wDataReader("NomePrograma"))
                mSetor = IIf(IsDBNull(wDataReader("CodigoSetor")), "", wDataReader("CodigoSetor"))
                mTipoUsuario = IIf(IsDBNull(wDataReader("TipoUsuario")), "", wDataReader("TipoUsuario"))
                mUsuario = IIf(IsDBNull(wDataReader("Usuario")), "", wDataReader("Usuario"))
                mIncluir = IIf(IsDBNull(wDataReader("Incluir")), "", wDataReader("Incluir"))
                mAlterar = IIf(IsDBNull(wDataReader("Alterar")), "", wDataReader("Alterar"))
                mExcluir = IIf(IsDBNull(wDataReader("Excluir")), "", wDataReader("Excluir"))
                mDataCadastro = IIf(IsDBNull(wDataReader("DataCadastro")), "", wDataReader("DataCadastro"))
                mUsuarioCadastro = IIf(IsDBNull(wDataReader("UsuarioCadastro")), "", wDataReader("UsuarioCadastro"))
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

    Public Function IncluirProgramaLiberacao() As Integer
        Try

            Dim wControle As Integer

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
 
            wControle = VerificaExistenciaProgramaLiberacao()
            If wControle = 0 Then Return 1
            If wControle <> 1 Then Return wControle
 
            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "IncluirProgramaLiberacao")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = "INSERT INTO C_ProgramasLiberacoes (NomePrograma, " & _
                                " CodigoSetor,      " & _
                                " TipoUsuario,      " & _
                                " Usuario,      " & _
                                " Incluir,      " & _
                                " Alterar,      " & _
                                " Excluir,      " & _
                                " DataCadastro, " & _
                                " UsuarioCadastro " & _
                                " ) VALUES ( " & _
                                " '" & mNomePrograma & "', " & _
                                " '" & mSetor & "', " & _
                                " '" & mTipoUsuario & "', " & _
                                " '" & mUsuario & "', " & _
                                BrancoNull(mIncluir) & ", " & _
                                BrancoNull(mAlterar) & ", " & _
                                BrancoNull(mExcluir) & ", " & _
                                " '" & Date.Now & "', " & _
                                " '" & mUsuarioCadastro & "' " & _
                                ")  "

                wComando.ExecuteNonQuery()

                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("IncluirProgramaLiberacao")
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
    Public Function AlterarProgramaLiberacao() As Integer

        Dim wControle As Integer


        If mNomePrograma = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para alteração!"
            VariaveisGlobais.gStackTraceErro = "ProgramasLiberacoes_Implem->AlterarProgramaLiberacao()"
            Return -1
        End If

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            '**** Inicio Codigo Novo **************************************************
            Dim wSet As String = ""
            Dim wLog As String = ""

            wComando.CommandText = "SELECT * FROM C_ProgramasLiberacoes WHERE " & _
                 " NomePrograma='" & mNomePrograma & "'" & _
                 " AND CodigoSetor= '" & mSetor & "'" & _
                 " AND TipoUsuario= '" & mTipoUsuario & "'" & _
                 " AND Usuario= '" & mUsuario & "'"

            wDataReader = wComando.ExecuteReader
            If Not wDataReader.Read() Then
                wDataReader.Close()
                Return 1
            End If
 
            If BrancoNull(mIncluir) <> BrancoNull(IIf(IsDBNull(wDataReader("Incluir")), "", wDataReader("Incluir"))) Then
                wSet = wSet & ", Incluir =  " & BrancoNull(mIncluir) & " "
                wLog = wLog & "|Incluir\" & wDataReader("Incluir")
            End If
            If BrancoNull(mAlterar) <> BrancoNull(IIf(IsDBNull(wDataReader("Alterar")), "", wDataReader("Alterar"))) Then
                wSet = wSet & ", Alterar =  " & BrancoNull(mAlterar) & " "
                wLog = wLog & "|Alterar\" & wDataReader("Alterar")
            End If
            If BrancoNull(mExcluir) <> BrancoNull(IIf(IsDBNull(wDataReader("Excluir")), "", wDataReader("Excluir"))) Then
                wSet = wSet & ", Excluir =  " & BrancoNull(mExcluir) & " "
                wLog = wLog & "|Excluir\" & wDataReader("Excluir")
            End If
 
            wDataReader.Close()
            If Len(wSet) > 0 Then wSet = wSet.Substring(1, Len(wSet) - 1)
            If Len(wLog) > 0 Then wLog = wLog.Substring(1, Len(wLog) - 1)

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "AlterarProgramaLiberacao")
            wComando.Transaction = wTransacao

            Try
                If Len(wSet) > 0 Then
                    wComando.CommandText = _
                   " UPDATE C_ProgramasLiberacoes SET " & wSet & " WHERE " & _
                       " NomePrograma='" & mNomePrograma & "'" & _
                       " AND CodigoSetor= '" & mSetor & "'" & _
                       " AND TipoUsuario= '" & mTipoUsuario & "'" & _
                       " AND Usuario= '" & mUsuario & "'"

                    wComando.ExecuteNonQuery()
                    Dim Log As String = "C_LOG"
                    Dim Tab As String = "C_ProgramasLiberacoes"
                    Dim Chave As String = mNomePrograma & "|" & mSetor & "|" & mTipoUsuario & "|" & mUsuario
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
                wTransacao.Rollback("AlterarProgramaLiberacao")
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

    Private Function VerificaDependenciasProgramaLiberacao() As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
 
            'wComando.CommandText = "SELECT * FROM C_ProgramasLiberacoes WHERE CodigoProgramaLiberacao='" & mCodigo & "'"

            'wDataReader = wComando.ExecuteReader
            'If wDataReader.Read() Then
            '    wDataReader.Close()
            '    VariaveisGlobais.gDescricaoUltimoErro = " Programas Liberações !"
            '    Return 2
            'End If
            'wDataReader.Close()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function ExcluirProgramaLiberacao() As Integer

        Try
            Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim wDataSet As DataSet = New DataSet

            If mNomePrograma = "" Then
                VariaveisGlobais.gUltimoSQL = ""
                VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para exclusão!"
                VariaveisGlobais.gStackTraceErro = "ProgramasLiberacoes_Implem->ExcluirProgramaLiberacao()"
                Return -1
            End If

            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            'wControle = VerificaDependenciasProgramaLiberacao()
            'If wControle <> 0 Then Return wControle

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ExcluirProgramaLiberacao")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = _
                                    " UPDATE C_ProgramasLiberacoes SET " & _
                                    " UsuarioExclusao='" & VariaveisGlobais.gCodigoUsuario & "',    " & _
                                    " DataExclusao='" & Date.Now & "'    " & _
                                    " WHERE    " & _
                                    " NomePrograma='" & mNomePrograma & "'" & _
                                    " AND CodigoSetor= '" & mSetor & "'" & _
                                    " AND TipoUsuario= '" & mTipoUsuario & "'" & _
                                    " AND Usuario= '" & mUsuario & "'"

                wComando.ExecuteNonQuery()

                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("ExcluirProgramaLiberacao")
            End Try

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function MostraTabelaProgramasLiberacoes(ByRef pObjTabela As System.Windows.Forms.DataGridView, _
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

            wDataSet.Tables(0).Columns(0).ColumnName = "Setor"
            wDataSet.Tables(0).Columns(1).ColumnName = "Nome Setor"
            wDataSet.Tables(0).Columns(2).ColumnName = "Tp Us"
            wDataSet.Tables(0).Columns(3).ColumnName = "Usuario"
            wDataSet.Tables(0).Columns(4).ColumnName = "In"
            wDataSet.Tables(0).Columns(5).ColumnName = "Al"
            wDataSet.Tables(0).Columns(6).ColumnName = "Ex"
 
            Dim wDataTable As New DataTable()
            wDataTable = wDataSet.Tables(0)

            wDataTable.Columns.Add("Altera", GetType(Image))
            Dim wicon As Image = Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "lupa.gif")
            For i As Integer = 0 To wDataTable.Rows.Count - 1
                wDataTable.Rows(i)(7) = wicon
            Next

            Dim wDataView = New DataView(wDataTable, "", "", DataViewRowState.CurrentRows)

            pObjTabela.Columns.Clear()
            pObjTabela.DataSource = wDataView

            If CDec(pObjTabela.Tag) = 0 Then pObjTabela.Tag = "1" '/ CDec(pObjTabela.Tag)
            pObjTabela.Columns(0).Width = 30 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(1).Width = 120 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(2).Width = 30 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(3).Width = 80 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(4).Width = 25 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(5).Width = 25 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(6).Width = 25 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(7).Width = 17 / CDec(pObjTabela.Tag)

            pObjTabela.RowHeadersWidth = 10

            For i As Integer = 0 To 7
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


