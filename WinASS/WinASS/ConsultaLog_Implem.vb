Imports System.Console
Imports System.Data
Imports System.Data.SqlClient

Public Class ConsultaLog_Implem
    Inherits Fortaleza.Business.BO

#Region " Variáveis internas "

    'Public objVariaveisGlobais As VariaveisGlobais

    Private wComando As SqlCommand
    Private wDataReader As SqlDataReader

    Private mBanco As String
    Private mTabela As String
    Private mTabela1 As String
    Private mChave As String


#End Region

#Region " Propriedades "
    Public Property Banco() As String
        Get
            Return mBanco
        End Get
        Set(ByVal Value As String)
            mBanco = Value
        End Set
    End Property

    Public Property Tabela() As String
        Get
            Return mTabela
        End Get
        Set(ByVal Value As String)
            mTabela = Value
        End Set
    End Property

    Public Property Tabela1() As String
        Get
            Return mTabela1
        End Get
        Set(ByVal Value As String)
            mTabela1 = Value
        End Set
    End Property

    Public Property Chave() As String
        Get
            Return mChave
        End Get
        Set(ByVal Value As String)
            mChave = Value
        End Set
    End Property
#End Region

#Region " Metodos "
    Public Sub New()
        wComando = New SqlCommand("", VariaveisGlobais.gConexao)
    End Sub

    Public Sub New(ByVal pobjVariaveisGlobais As VariaveisGlobais)

        objVariaveisGlobais = pobjVariaveisGlobais
        wComando = New SqlCommand("", VariaveisGlobais.gConexao)

    End Sub

    Public Function MostraC_LOG(ByRef pObjTabela As System.Windows.Forms.DataGrid, _
                                             ByVal pSQL As String) As Integer

        Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
        Dim wDataSet As DataSet = New DataSet
        Dim wControle As Integer
       
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)

            If wControle < 0 Then
                Return wControle
            End If

            wComando.CommandText = pSQL
            wDataAdapter.SelectCommand = wComando
            wDataAdapter.Fill(wDataSet, "TABLE")
            wDataAdapter.Dispose()

            wDataSet.Tables(0).Columns(0).ColumnName = "Tabela"
            wDataSet.Tables(0).Columns(1).ColumnName = "Chave"
            'wDataSet.Tables(0).Columns(2).ColumnName = "DataHora"
            wDataSet.Tables(0).Columns(3).ColumnName = "Usuario"
            wDataSet.Tables(0).Columns(4).ColumnName = "Campo"
            wDataSet.Tables(0).Columns(5).ColumnName = "InfoAntigo"


            pObjTabela.DataSource = wDataSet
            pObjTabela.DataMember = "TABLE"


            Dim oTblStyle As New DataGridTableStyle
            oTblStyle.HeaderBackColor = Color.FromArgb(129, 149, 185)
            oTblStyle.HeaderForeColor = Color.White
            oTblStyle.MappingName = "TABLE"

            Dim oGridColStyles As GridColumnStylesCollection
            oGridColStyles = oTblStyle.GridColumnStyles

            pObjTabela.TableStyles.Clear()
            pObjTabela.TableStyles.Add(oTblStyle)

            Dim oDGColStyle As GridColumnStylesCollection
            oDGColStyle = pObjTabela.TableStyles(0).GridColumnStyles

            If CDec(pObjTabela.Tag) = 0 Then pObjTabela.Tag = "1" '/ CDec(pObjTabela.Tag)
            oDGColStyle.Item(0).Width = 80 / CDec(pObjTabela.Tag)
            oDGColStyle.Item(1).Width = 55 / CDec(pObjTabela.Tag)
            oDGColStyle.Item(2).Width = 110 / CDec(pObjTabela.Tag)
            oDGColStyle.Item(3).Width = 60 / CDec(pObjTabela.Tag)
            oDGColStyle.Item(4).Width = 70 / CDec(pObjTabela.Tag)
            oDGColStyle.Item(5).Width = 325 / CDec(pObjTabela.Tag)

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Private WithEvents Icons As ImageList
    Private wIndiceIcone As Integer = 1

    Public Function MyGetImageIndexForRow(ByVal row As Integer) As Integer
        wIndiceIcone = 0
        Return wIndiceIcone
    End Function
#End Region

End Class

