Imports System.Data.SqlClient

Public Class Valores_Prefeituras_TipoServico_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    Private mData_Vigencia As Date
    Private mCod_Prefeitura As Integer
    Private mCod_Tipo_Servico As Integer
    Private mValor As Decimal

    Private wComando As SqlCommand
    Private wDataReader As SqlDataReader
    Public wDataSet As DataSet

#End Region

#Region " Propriedades "

    Public Property Cod_Tipo_Servico() As Integer
        Get
            Return mCod_Tipo_Servico
        End Get
        Set(ByVal Value As Integer)
            mCod_Tipo_Servico = Value
        End Set
    End Property

    Public Property Cod_Prefeitura() As Integer
        Get
            Return mCod_Prefeitura
        End Get
        Set(ByVal Value As Integer)
            mCod_Prefeitura = Value
        End Set
    End Property

    Public Property Data_Vigencia() As Date
        Get
            Return mData_Vigencia
        End Get
        Set(ByVal Value As Date)
            mData_Vigencia = Value
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

#End Region

#Region " Métodos "

    Public Sub New()
        wComando = New SqlCommand("", VariaveisGlobais.gConexao)
    End Sub

    Public Sub New(ByVal pobjVariaveisGlobais As VariaveisGlobais)
        objVariaveisGlobais = pobjVariaveisGlobais
        wComando = New SqlCommand("", VariaveisGlobais.gConexao)
    End Sub

    Public Function VerificaExistenciaValor() As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM Ass_Valores_Prefeituras_TipoServico WHERE Cod_TipoServico='" & mCod_Tipo_Servico & "'" & _
                                   " AND Cod_Prefeitura ='" & mCod_Prefeitura & "' AND Data_Vigencia ='" & mData_Vigencia & "'"

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

    Public Function BuscarValorAtual() As Integer

        Dim wTmp As Integer
        If mCod_Prefeitura = 0 Or Cod_Tipo_Servico = 0 Then
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para busca!"
            VariaveisGlobais.gStackTraceErro = "CadastroValores_Valores_TipoServico_Implem->BuscarValor()"
            Return -1
        End If

        'wTmp = VerificaExistenciaValor()
        'If wTmp <> 0 Then Return wTmp
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT TOP 1 * FROM Ass_Valores_Prefeituras_TipoServico WHERE Cod_Prefeitura='" & mCod_Prefeitura & "'" & _
                " AND Cod_TipoServico ='" & mCod_Tipo_Servico & "' AND Data_Vigencia < GETDATE() ORDER BY Data_Vigencia DESC "
            wDataReader = wComando.ExecuteReader

            If wDataReader.Read() Then
                mValor = NullDecimal(wDataReader("Valor"))
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

    Public Function IncluirValores() As Integer
        Try
            Dim wControle As Integer

            wControle = VerificaExistenciaValor()
            If wControle = 0 Then Return 1


            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "IncluirValor")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = "  SET DATEFORMAT DMY INSERT INTO Ass_Valores_Prefeituras_TipoServico (" & _
                        "                Cod_Prefeitura,                       " & _
                        "                Cod_TipoServico,                      " & _
                        "                Data_Vigencia,                      " & _
                        "                Valor                      " & _
                        "                 ) VALUES (" & _
                        " '" & mCod_Prefeitura & "'," & _
                        "'" & mCod_Tipo_Servico & "',           " & _
                        "'" & mData_Vigencia & "',   " & _
                        ZeroNull(mValor) & ")   "
                wComando.ExecuteNonQuery()
                wTransacao.Commit()

            Catch ex As Exception
                wTransacao.Rollback("IncluirValor")
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

    Public Function ExcluirValor() As Integer

        Try
            Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim wDataSet As DataSet = New DataSet

            If mCod_Prefeitura = 0 Or Cod_Tipo_Servico = 0 Or Not IsDate(Data_Vigencia) Then
                VariaveisGlobais.gUltimoSQL = ""
                VariaveisGlobais.gDescricaoUltimoErro = "Parâmetro incorreto para exclusão!"
                VariaveisGlobais.gStackTraceErro = "Valores_Valores_TipoServico_Implem->ExcluirValor()"
                Return -1
            End If

            Dim wControle As Integer
            'wControle = VerificaDependenciaValor()
            'If wControle <> 0 Then Return wControle

            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            Dim wTransacao As SqlTransaction
            wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ExcluirValor")
            wComando.Transaction = wTransacao

            Try
                wComando.CommandText = " DELETE FROM Ass_Valores_Prefeituras_TipoServico " & _
                                    " WHERE Cod_Prefeitura ='" & mCod_Prefeitura & "'" & _
                                    " AND Cod_TipoServico='" & mCod_Tipo_Servico & "'" & _
                                    " AND Data_Vigencia = '" & mData_Vigencia & "'"
                wComando.ExecuteNonQuery()
                wTransacao.Commit()
            Catch ex As Exception
                wTransacao.Rollback("ExcluirValor")
                Return -1
            End Try

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Public Function VerificaDependenciaValor(ByVal pCodigo As String) As Integer
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle
            wComando.CommandText = "SELECT * FROM Ass_Movimento " & _
                                   " WHERE Valor ='" & pCodigo & "'" & _
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

    Public Function MostraTabelaValores(ByRef pObjTabela As System.Windows.Forms.DataGridView, _
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

            wDataSet.Tables(0).Columns(0).ColumnName = "Cod_Prefeitura"
            wDataSet.Tables(0).Columns(1).ColumnName = "Prefeitura"
            wDataSet.Tables(0).Columns(2).ColumnName = "Cod_Tipo_Servico"
            wDataSet.Tables(0).Columns(3).ColumnName = "Tipo_Servico"
            wDataSet.Tables(0).Columns(4).ColumnName = "Data_Vigencia"
            wDataSet.Tables(0).Columns(5).ColumnName = "Valor"

            Dim wDataTable As New DataTable()
            wDataTable = wDataSet.Tables(0)

            wDataTable.Columns.Add("Excluir", GetType(Image))
            Dim wicon As Image = Image.FromFile(objVariaveisGlobais.gCaminhoImagem & "7884_16x16.png")
            For i As Integer = 0 To wDataTable.Rows.Count - 1
                wDataTable.Rows(i)(6) = wicon
            Next

            Dim wDataView = New DataView(wDataTable, "", "", DataViewRowState.CurrentRows)

            pObjTabela.Columns.Clear()
            pObjTabela.DataSource = wDataView

            If CDec(pObjTabela.Tag) = 0 Then pObjTabela.Tag = "1" '/ CDec(pObjTabela.Tag)
            pObjTabela.Columns(0).Visible = False
            pObjTabela.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            pObjTabela.Columns(2).Visible = False
            pObjTabela.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            pObjTabela.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            pObjTabela.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            pObjTabela.Columns(6).Width = 22 / CDec(pObjTabela.Tag)

            pObjTabela.RowHeadersWidth = 10

            For i As Integer = 0 To 6
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


