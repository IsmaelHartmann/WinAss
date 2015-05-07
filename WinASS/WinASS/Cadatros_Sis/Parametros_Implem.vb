Imports System.Data.SqlClient

Public Class Parametros_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    Private mValor_Vermifugo As Decimal
    Private mValor_Bernicida As Decimal
    Private mValor_Fasciolicida As Decimal
    Private mValor_MaodeObra As Decimal
    Private mValor_Beneficio_Languiru As Decimal
    Private mAssistencia_Languiru As String
    Private mCodigos_Inseminacao As String
    Private mCodigos_Animais As String

    Private mCaminhoBackup As String
    Private mServidorFTP As String
    Private mUsuarioFTP As String
    Private mSenhaFTP As String
    Private mUsuarioServidor As String
    Private mSenhaServidor As String

    Private wComando As SqlCommand
    Private wDataReader As SqlDataReader
    Public wDataSet As DataSet

#End Region

#Region " Propriedades "

    Public Property CaminhoBackup() As String
        Get
            Return mCaminhoBackup
        End Get
        Set(ByVal Value As String)
            mCaminhoBackup = Value
        End Set
    End Property

    Public Property ServidorFTP() As String
        Get
            Return mServidorFTP
        End Get
        Set(ByVal Value As String)
            mServidorFTP = Value
        End Set
    End Property

    Public Property UsuarioFTP() As String
        Get
            Return mUsuarioFTP
        End Get
        Set(ByVal Value As String)
            mUsuarioFTP = Value
        End Set
    End Property

    Public Property SenhaFTP() As String
        Get
            Return mSenhaFTP
        End Get
        Set(ByVal Value As String)
            mSenhaFTP = Value
        End Set
    End Property

    Public Property UsuarioServidor() As String
        Get
            Return mUsuarioServidor
        End Get
        Set(ByVal Value As String)
            mUsuarioServidor = Value
        End Set
    End Property

    Public Property SenhaServidor() As String
        Get
            Return mSenhaServidor
        End Get
        Set(ByVal Value As String)
            mSenhaServidor = Value
        End Set
    End Property

    Public Property Valor_Vermifugo() As Decimal
        Get
            Return mValor_Vermifugo
        End Get
        Set(ByVal Value As Decimal)
            mValor_Vermifugo = Value
        End Set
    End Property

    Public Property Valor_Beneficio_Languiru() As Decimal
        Get
            Return mValor_Beneficio_Languiru
        End Get
        Set(ByVal Value As Decimal)
            mValor_Beneficio_Languiru = Value
        End Set
    End Property

    Public Property Assistencia_Languiru() As String
        Get
            Return mAssistencia_Languiru
        End Get
        Set(ByVal Value As String)
            mAssistencia_Languiru = Value
        End Set
    End Property

    Public Property Codigos_Inseminacao() As String
        Get
            Return mCodigos_Inseminacao
        End Get
        Set(ByVal Value As String)
            mCodigos_Inseminacao = Value
        End Set
    End Property

    Public Property Valor_Bernicida() As Decimal
        Get
            Return mValor_Bernicida
        End Get
        Set(ByVal Value As Decimal)
            mValor_Bernicida = Value
        End Set
    End Property

    Public Property Valor_Fasciolicida() As Decimal
        Get
            Return mValor_Fasciolicida
        End Get
        Set(ByVal Value As Decimal)
            mValor_Fasciolicida = Value
        End Set
    End Property

    Public Property Valor_MaodeObra() As Decimal
        Get
            Return mValor_MaodeObra
        End Get
        Set(ByVal Value As Decimal)
            mValor_MaodeObra = Value
        End Set
    End Property

    Public Property Codigos_Animais() As String
        Get
            Return mCodigos_Animais
        End Get
        Set(ByVal Value As String)
            mCodigos_Animais = Value
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
 
    Public Function BuscarParametro() As Integer
         
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM C_Parametros  "
            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                mValor_Vermifugo = IIf(IsDBNull(wDataReader("Valor_Vermifugo")), 0, wDataReader("Valor_Vermifugo"))
                mValor_Bernicida = IIf(IsDBNull(wDataReader("Valor_Bernicida")), 0, wDataReader("Valor_Bernicida"))
                mValor_Fasciolicida = IIf(IsDBNull(wDataReader("Valor_Fasciolicida")), 0, wDataReader("Valor_Fasciolicida"))
                mValor_MaodeObra = IIf(IsDBNull(wDataReader("Valor_MaodeObra")), 0, wDataReader("Valor_MaodeObra"))
                mAssistencia_Languiru = IIf(IsDBNull(wDataReader("Assistencia_Languiru")), "", wDataReader("Assistencia_Languiru"))
                mCodigos_Inseminacao = IIf(IsDBNull(wDataReader("Codigos_Inseminacao")), "", wDataReader("Codigos_Inseminacao"))
                mCodigos_Animais = IIf(IsDBNull(wDataReader("Codigos_Animais")), "", wDataReader("Codigos_Animais"))
                mValor_Beneficio_Languiru = IIf(IsDBNull(wDataReader("Valor_Beneficio_Languiru")), 0, wDataReader("Valor_Beneficio_Languiru"))
                CaminhoBackup = NullBranco(wDataReader("CaminhoBackup"))
                ServidorFTP = NullBranco(wDataReader("ServidorFTP"))
                UsuarioFTP = NullBranco(wDataReader("UsuarioFTP"))
                SenhaFTP = NullBranco(wDataReader("SenhaFTP"))
                UsuarioServidor = NullBranco(wDataReader("UsuarioServidor"))
                SenhaServidor = NullBranco(wDataReader("SenhaServidor"))
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


    Public Function AlterarParametro() As Integer

        Dim wControle As Integer
  
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            '**** Inicio Id_Parametro Novo **************************************************
            Dim wSet As String = ""
            Dim wLog As String = ""

            wComando.CommandText = "SELECT * FROM C_Parametros  "

            wDataReader = wComando.ExecuteReader
            If Not wDataReader.Read() Then
                wDataReader.Close()
                Return 1
            End If


            If ZeroNull(mValor_Bernicida) <> ZeroNull(wDataReader("Valor_Bernicida")) Then
                wSet = wSet & ", Valor_Bernicida = " & ZeroNull(mValor_Bernicida) & ""
                wLog = wLog & "|Valor_Bernicida\" & ZeroNull(wDataReader("Valor_Bernicida"))
            End If
            If ZeroNull(mValor_Vermifugo) <> ZeroNull(wDataReader("Valor_Vermifugo")) Then
                wSet = wSet & ", Valor_Vermifugo = " & ZeroNull(mValor_Vermifugo) & ""
                wLog = wLog & "|Valor_Vermifugo\" & ZeroNull(wDataReader("Valor_Vermifugo"))
            End If
            If ZeroNull(mValor_Fasciolicida) <> ZeroNull(wDataReader("Valor_Fasciolicida")) Then
                wSet = wSet & ", Valor_Fasciolicida = " & ZeroNull(mValor_Fasciolicida) & ""
                wLog = wLog & "|Valor_Fasciolicida\" & ZeroNull(wDataReader("Valor_Fasciolicida"))
            End If
            If ZeroNull(mValor_MaodeObra) <> ZeroNull(wDataReader("Valor_MaodeObra")) Then
                wSet = wSet & ", Valor_MaodeObra = " & ZeroNull(mValor_MaodeObra) & ""
                wLog = wLog & "|Valor_MaodeObra\" & ZeroNull(wDataReader("Valor_MaodeObra"))
            End If
            If ZeroNull(mValor_Beneficio_Languiru) <> ZeroNull(wDataReader("Valor_Beneficio_Languiru")) Then
                wSet = wSet & ", Valor_Beneficio_Languiru = " & ZeroNull(mValor_Beneficio_Languiru) & ""
                wLog = wLog & "|Valor_Beneficio_Languiru\" & ZeroNull(wDataReader("Valor_Beneficio_Languiru"))
            End If
            If BrancoNull(mAssistencia_Languiru) <> BrancoNull(wDataReader("Assistencia_Languiru")) Then
                wSet = wSet & ", Assistencia_Languiru = " & BrancoNull(mAssistencia_Languiru) & ""
                wLog = wLog & "|Assistencia_Languiru\" & BrancoNull(wDataReader("Assistencia_Languiru"))
            End If
            If BrancoNull(mCodigos_Inseminacao) <> BrancoNull(wDataReader("Codigos_Inseminacao")) Then
                wSet = wSet & ", Codigos_Inseminacao = " & BrancoNull(mCodigos_Inseminacao) & ""
                wLog = wLog & "|Codigos_Inseminacao\" & BrancoNull(wDataReader("Codigos_Inseminacao"))
            End If

            If BrancoNull(mCodigos_Animais) <> BrancoNull(wDataReader("Codigos_Animais")) Then
                wSet = wSet & ", Codigos_Animais = " & BrancoNull(mCodigos_Animais) & ""
                wLog = wLog & "|Codigos_Animais\" & BrancoNull(wDataReader("Codigos_Animais"))
            End If

            If BrancoNull(mCaminhoBackup) <> BrancoNull(wDataReader("CaminhoBackup")) Then
                wSet = wSet & ", CaminhoBackup = " & BrancoNull(mCaminhoBackup) & ""
                wLog = wLog & "|CaminhoBackup\" & BrancoNull(wDataReader("CaminhoBackup"))
            End If

            If BrancoNull(mServidorFTP) <> BrancoNull(wDataReader("ServidorFTP")) Then
                wSet = wSet & ", ServidorFTP = " & BrancoNull(mServidorFTP) & ""
                wLog = wLog & "|ServidorFTP\" & BrancoNull(wDataReader("ServidorFTP"))
            End If

            If BrancoNull(mUsuarioFTP) <> BrancoNull(wDataReader("UsuarioFTP")) Then
                wSet = wSet & ", UsuarioFTP = " & BrancoNull(mUsuarioFTP) & ""
                wLog = wLog & "|UsuarioFTP\" & BrancoNull(wDataReader("UsuarioFTP"))
            End If

            If BrancoNull(mSenhaFTP) <> BrancoNull(wDataReader("SenhaFTP")) Then
                wSet = wSet & ", SenhaFTP = " & BrancoNull(mSenhaFTP) & ""
                wLog = wLog & "|SenhaFTP\" & BrancoNull(wDataReader("SenhaFTP"))
            End If

            If BrancoNull(mUsuarioServidor) <> BrancoNull(wDataReader("UsuarioServidor")) Then
                wSet = wSet & ", UsuarioServidor = " & BrancoNull(mUsuarioServidor) & ""
                wLog = wLog & "|UsuarioServidor\" & BrancoNull(wDataReader("UsuarioServidor"))
            End If

            If BrancoNull(mSenhaServidor) <> BrancoNull(wDataReader("SenhaServidor")) Then
                wSet = wSet & ", SenhaServidor = " & BrancoNull(mSenhaServidor) & ""
                wLog = wLog & "|SenhaServidor\" & BrancoNull(wDataReader("SenhaServidor"))
            End If


            wDataReader.Close()
            If Len(wSet) > 0 Then wSet = wSet.Substring(1, Len(wSet) - 1)
            If Len(wLog) > 0 Then wLog = wLog.Substring(1, Len(wLog) - 1)

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "AlterarParametro")
            wComando.Transaction = wTransacao

            Try
                If Len(wSet) > 0 Then
                    wComando.CommandText = _
                           " UPDATE C_Parametros SET " & wSet & "  "

                    wComando.ExecuteNonQuery()
                    Dim Log As String = "C_LOG"
                    Dim Tab As String = "C_Parametros"
                    Dim Chave As String = "Parametros"
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
                wTransacao.Rollback("AlterarParametro")
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
  
#End Region

End Class


