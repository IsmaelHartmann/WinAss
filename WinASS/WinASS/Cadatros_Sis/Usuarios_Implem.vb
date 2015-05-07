Imports System.Data.SqlClient

Public Class Usuarios_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    Private mId_Usuario As String
    Private mLogin As String
    Private mSetor As String
    Private mNome As String
    Private mSenha As String
    Private mTipo As String
    Private mSituacao As String
    Private mDataCadastro As String
    Private mUsuarioCadastro As String
   
    Private wComando As SqlCommand
    Private wDataReader As SqlDataReader
    Public wDataSet As DataSet

#End Region

#Region " Propriedades "

    Public Property Id_Usuario() As String
        Get
            Return mId_Usuario
        End Get
        Set(ByVal Value As String)
            mId_Usuario = Value
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
    Public Property Setor() As String
        Get
            Return mSetor
        End Get
        Set(ByVal Value As String)
            mSetor = Value
        End Set
    End Property
    Public Property Login() As String
        Get
            Return mLogin
        End Get
        Set(ByVal Value As String)
            mLogin = Value
        End Set
    End Property
    Public Property Nome() As String
        Get
            Return mNome
        End Get
        Set(ByVal Value As String)
            mNome = Value
        End Set
    End Property

    Public Property Senha() As String
        Get
            Return mSenha
        End Get
        Set(ByVal Value As String)
            mSenha = Value
        End Set
    End Property
    Public Property Tipo() As String
        Get
            Return mTipo
        End Get
        Set(ByVal Value As String)
            mTipo = Value
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

#End Region

#Region " Métodos "

    Public Sub New()
        wComando = New SqlCommand("", VariaveisGlobais.gConexao)
    End Sub

    Public Sub New(ByVal pobjVariaveisGlobais As VariaveisGlobais)
        objVariaveisGlobais = pobjVariaveisGlobais
        wComando = New SqlCommand("", VariaveisGlobais.gConexao)
    End Sub

    Public Function VerificaExistencia_Codigo_Usuario(ByVal pCodigo As String, ByRef pId As String) As Integer
        Dim wControle As Integer
        Try
            pId = ""
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT Login FROM C_Usuarios " & _
                            " WHERE Id_Usuario ='" & pCodigo & "'" & _
                            " AND isnull(Data_Hora_Exclusao,'') = '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                pId = wDataReader("Login")
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

    Public Function VerificaExistenciaUsuario() As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM C_Usuarios WHERE Login ='" & mLogin & "'" & _
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

    Public Function BuscarUsuario() As Integer
        Dim wTmp As Integer
        If mLogin = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "CadastroUsuarios_Implem->BuscarUsuario()"
            Return -1
        End If

        wTmp = VerificaExistenciaUsuario()
        If wTmp <> 0 Then Return wTmp
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM C_Usuarios WHERE Login='" & mLogin & "'"
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mId_Usuario = wDataReader("Id_Usuario")
                mLogin = wDataReader("Login")
                mNome = IIf(IsDBNull(wDataReader("Nome")), "", wDataReader("Nome"))
                mSenha = IIf(IsDBNull(wDataReader("Senha")), "", wDataReader("Senha"))
                mTipo = IIf(IsDBNull(wDataReader("Tipo")), "N", wDataReader("Tipo"))
                mSituacao = IIf(IsDBNull(wDataReader("Situacao")), 0, wDataReader("Situacao"))
                mSetor = IIf(IsDBNull(wDataReader("Setor")), "", wDataReader("Setor"))
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

    Public Function IncluirUsuario() As Integer
        Try

            Dim wControle As Integer

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle


            wControle = VerificaExistenciaUsuario()
            If wControle = 0 Then Return 1
            If wControle <> 1 Then Return wControle

            wComando.CommandText = " SELECT isnull(max(cast(Id_Usuario as integer)),0)+1 Id_Usuario " & _
                                " FROM C_Usuarios WHERE isnumeric(Id_Usuario)<>0 "
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mId_Usuario = wDataReader("Id_Usuario")
            Else
                mId_Usuario = 1
            End If
            wDataReader.Close()


            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "IncluirUsuario")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = "INSERT INTO C_Usuarios (Id_Usuario,     " & _
                                         " Login,  " & _
                                         " Nome,                      " & _
                                         " Senha,                     " & _
                                         " Tipo,                      " & _
                                         " Setor,                      " & _
                                         " Situacao,  " & _
                                         " Codigo_Usuario_Cadastro,  " & _
                                         " Data_Hora_Cadastro  " & _
                                         "    ) VALUES (" & _
                                         "  " & mId_Usuario & ",   " & _
                                         "  '" & mLogin & "', " & _
                                         "  '" & mNome & "',   " & _
                                         "  '" & mSenha & "',   " & _
                                         "  '" & mTipo & "', " & _
                                         "  '" & mSetor & "', " & _
                                         "  '" & mSituacao & "', " & _
                                         "  '" & mUsuarioCadastro & "', " & _
                                         "  '" & Date.Now & "' )  "
                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("IncluirUsuario")
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
    Public Function AlterarUsuario() As Integer
        Dim wControle As Integer
 
        If mLogin = "" Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para alteração!"
            VariaveisGlobais.gStackTraceErro = "Usuarios_Implem->AlterarUsuario()"
            Return -1
        End If
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            '**** Inicio Codigo Novo **************************************************
            Dim wSet As String = ""
            Dim wLog As String = ""

            wComando.CommandText = "SELECT * FROM C_Usuarios WHERE Login='" & mLogin & "'"

            wDataReader = wComando.ExecuteReader
            If Not wDataReader.Read() Then
                wDataReader.Close()
                Return 1
            End If

            If mId_Usuario <> wDataReader("Id_Usuario") Then
                wSet = wSet & ", Id_Usuario = '" & mId_Usuario & "'"
                wLog = wLog & "|Id_Usuario\" & wDataReader("Id_Usuario")
            End If
            If mNome <> wDataReader("Nome") Then
                wSet = wSet & ", Nome = '" & mNome & "'"
                wLog = wLog & "|Nome\" & wDataReader("Nome")
            End If
            If mSetor <> wDataReader("Setor") Then
                wSet = wSet & ", Setor = '" & mSetor & "'"
                wLog = wLog & "|Setor\" & wDataReader("Setor")
            End If

            If mSenha <> wDataReader("Senha") Then
                wSet = wSet & ", Senha = '" & mSenha & "'"
                wLog = wLog & "|Senha\" & wDataReader("Senha")
            End If
            If mTipo <> wDataReader("Tipo") Then
                wSet = wSet & ", Tipo = '" & mTipo & "'"
                wLog = wLog & "|Tipo\" & wDataReader("Tipo")
            End If
            If mSituacao <> wDataReader("Situacao") Then
                wSet = wSet & ", Situacao = '" & mSituacao & "'"
                wLog = wLog & "|Situacao\" & wDataReader("Situacao")
            End If

            wDataReader.Close()
            If Len(wSet) > 0 Then wSet = wSet.Substring(1, Len(wSet) - 1)
            If Len(wLog) > 0 Then wLog = wLog.Substring(1, Len(wLog) - 1)

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "AlterarUsuario")
            wComando.Transaction = wTransacao

            Try
                If Len(wSet) > 0 Then
                    wComando.CommandText = _
                          " UPDATE C_Usuarios SET " & wSet & " WHERE " & _
                          "  Login='" & mLogin & "'"

                    wComando.ExecuteNonQuery()
                    Dim Log As String = "C_LOG"
                    Dim Tab As String = "C_Usuarios"
                    Dim Chave As String = mLogin
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
                wTransacao.Rollback("AlterarUsuario")
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

    Public Function ExcluirUsuario() As Integer

        Try
            Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim wDataSet As DataSet = New DataSet

            If mLogin = "" Then
                VariaveisGlobais.gUltimoSQL = ""
                VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para exclusão!"
                VariaveisGlobais.gStackTraceErro = "Usuarios_Implem->ExcluirUsuario()"
                Return -1
            End If

            Dim wControle As Integer
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ExcluirUsuario")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = " UPDATE C_Usuarios SET " & _
                                    " Codigo_Usuario_Exclusao ='" & VariaveisGlobais.gCodigoUsuario & "',    " & _
                                    " Data_Hora_Exclusao ='" & Date.Now & "'    " & _
                                    " WHERE    " & _
                                    " Login='" & mLogin & "'"

                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("ExcluirUsuario")
            End Try

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function MostraTabelaUsuarios(ByRef pObjTabela As System.Windows.Forms.DataGridView, _
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

            wDataSet.Tables(0).Columns(0).ColumnName = "Login"
            wDataSet.Tables(0).Columns(1).ColumnName = "Nome"
            wDataSet.Tables(0).Columns(2).ColumnName = "Tipo"
            wDataSet.Tables(0).Columns(3).ColumnName = "Setor"

            For f As Integer = 0 To wDataSet.Tables(0).Rows.Count - 1
                If wDataSet.Tables(0).Rows(f)(2) = "A" Then wDataSet.Tables(0).Rows(f)(2) = "Administrador"
                If wDataSet.Tables(0).Rows(f)(2) = "S" Then wDataSet.Tables(0).Rows(f)(2) = "Supervisor"
                If wDataSet.Tables(0).Rows(f)(2) = "U" Then wDataSet.Tables(0).Rows(f)(2) = "Usuario"
            Next f

            Dim wDataTable As New DataTable()
            wDataTable = wDataSet.Tables(0)

            wDataTable.Columns.Add("Altera", GetType(Image))
            Dim wicon As Image = Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "lupa.gif")
            For i As Integer = 0 To wDataTable.Rows.Count - 1
                wDataTable.Rows(i)(4) = wicon
            Next

            Dim wDataView = New DataView(wDataTable, "", "", DataViewRowState.CurrentRows)

            pObjTabela.Columns.Clear()
            pObjTabela.DataSource = wDataView

            If CDec(pObjTabela.Tag) = 0 Then pObjTabela.Tag = "1" '/ CDec(pObjTabela.Tag)
            pObjTabela.Columns(0).Width = 150 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(1).Width = 250 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(2).Width = 80 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(3).Width = 140 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(4).Width = 17 / CDec(pObjTabela.Tag)

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