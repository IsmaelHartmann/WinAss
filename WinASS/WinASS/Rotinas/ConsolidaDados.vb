Imports System.Data.SqlClient

Public Class ConsolidaDados

#Region " Variaveis Internas "

    Public objParametros_Implem As Parametros_Implem = ParametrosBOFactory.GetFactory().GetInstance()

    Private wComando As SqlCommand
    Private wDataSetBaixas As DataSet
    Private wDataSetBaixas2 As DataSet
    Private wDataSetBaixas3 As DataSet
    Private wDataSetXLS As DataSet
    Private wDataReader As SqlDataReader
    Private wBotaoPesquisa As String
    Private wTipoAssistência As String

#End Region

#Region " Inicializações "

    Private Sub ExportaDados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim autoriza As Boolean
        autoriza = VerificaPrograma("ExportaDados", VariaveisGlobais.gSetorUsuario, _
             VariaveisGlobais.gTipoUsuario, VariaveisGlobais.gLoginUsuario)

        If autoriza = False Then
            MessageBox.Show("Usuário não Autorizado ! " & Me.Name)
            Me.Enabled = False
            Me.Close()
            Exit Sub
        End If
        AjustaTela(Me)

        Try
            Dim wControle As Integer
            '__________ Verifica conexão com banco de dados
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Me.Close()
            End If
            wComando = New SqlCommand("", VariaveisGlobais.gConexao)

            'Tipo Assistencia
            objVariaveisGlobais.PreencheCheckedList(clTipoAssistencia, VariaveisGlobais.gConexao, _
                " SET DATEFORMAT DMY " & _
                " SELECT Codigo," & _
                " CAST(Codigo AS VARCHAR(3))+' '+CAST(Descricao AS VARCHAR)AS TipoAssistencia " & _
                " FROM Ass_TipoAssistencia " & _
                " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
                " ORDER BY Codigo ", True)

            txtDataInicio.Text = "01/" & Format(Today.Month, "00") & "/" & Format(Today.Year, "00")
            txtDataFinal.Text = Format(Date.DaysInMonth(CDate(Today.Date).Year, CDate(Today.Date).Month), "00") & "/" & _
                                CDate(Today.Date).Month & "/" & CDate(Today.Date).Year

            wControle = objParametros_Implem.BuscarParametro()
            If wControle <> 0 Then
                MsgBox(VariaveisGlobais.gDescricaoUltimoErro)
                Exit Sub
            End If
            txtDataInicio.Focus()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Me.Close()
        End Try

    End Sub

#End Region

    Private Sub tela_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F10 Then
            btFechar.PerformClick()
        End If

        If e.KeyCode = Keys.Escape Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
    End Sub
    Private Function ValidaPesquisa() As Integer
        Try
            'Monta Pesquisa Tipo Assistência
            wTipoAssistência = ""
            For i As Integer = 0 To clTipoAssistencia.Items.Count - 1
                If clTipoAssistencia.GetItemChecked(i) Then
                    If wTipoAssistência = "" Then
                        wTipoAssistência += "" & clTipoAssistencia.Items.Item(i).Value
                    Else
                        wTipoAssistência += "," & clTipoAssistencia.Items.Item(i).Value
                    End If
                End If
            Next
            If wTipoAssistência = "" Then
                Throw New Exception("Selecione um ou mais Tipo de Assistência!")
            End If
            If Not IsDate(txtDataInicio.Text) Or Not IsDate(txtDataFinal.Text) Then
                Throw New Exception("Preencha as datas corretamente!")
            Else
                If CDate(txtDataFinal.Text) < CDate(txtDataInicio.Text) Then
                    Throw New Exception("Data Final deve ser maior que a Data Inicio!")
                End If
            End If

        Catch ex As Exception 
            MsgBox("Erro em ValidaPesquisa !" & vbCrLf & ex.Message)
            Return -1
        End Try
        Return 0
    End Function
    Private Sub btBuscarSistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscarLancamentos.Click
        Dim wControle As Integer
        wControle = ValidaPesquisa()
        If wControle <> 0 Then
            Exit Sub
        End If
        wBotaoPesquisa = "L"
        BuscarLancamentos("L", dtgLancamentosLancados, txtCabecalho10, txtCabecalho11, wBotaoPesquisa)
        BuscarLancamentos("E", dtgLancamentosEnviados, txtCabecalho20, txtCabecalho21, wBotaoPesquisa)
        BuscarLancamentos("C", dtgLancamentosCobrados, txtCabecalho30, txtCabecalho31, wBotaoPesquisa)
    End Sub

    Private Sub btBuscarLancamentosValidados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscarLancamentosEnviados.Click
        Dim wControle As Integer
        wControle = ValidaPesquisa()
        If wControle <> 0 Then
            Exit Sub
        End If
        wBotaoPesquisa = ""
        BuscarLancamentos("L", dtgLancamentosLancados, txtCabecalho10, txtCabecalho11, wBotaoPesquisa)
        wBotaoPesquisa = "E"
        BuscarLancamentos("E", dtgLancamentosEnviados, txtCabecalho20, txtCabecalho21, wBotaoPesquisa)
        BuscarLancamentos("C", dtgLancamentosCobrados, txtCabecalho30, txtCabecalho31, wBotaoPesquisa)
    End Sub

    Private Sub brBuscarLancamentosCobrados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brBuscarLancamentosCobrados.Click
        Dim wControle As Integer
        wControle = ValidaPesquisa()
        If wControle <> 0 Then
            Exit Sub
        End If
        wBotaoPesquisa = ""
        BuscarLancamentos("L", dtgLancamentosLancados, txtCabecalho10, txtCabecalho11, wBotaoPesquisa)
        BuscarLancamentos("E", dtgLancamentosEnviados, txtCabecalho20, txtCabecalho21, wBotaoPesquisa)
        wBotaoPesquisa = "C"
        BuscarLancamentos("C", dtgLancamentosCobrados, txtCabecalho30, txtCabecalho31, wBotaoPesquisa)
    End Sub
    Private Sub Re_BuscarLancamentos()
        If wBotaoPesquisa = "L" Then
            BuscarLancamentos("L", dtgLancamentosLancados, txtCabecalho10, txtCabecalho11, wBotaoPesquisa)
        End If
        If wBotaoPesquisa = "L" OrElse wBotaoPesquisa = "E" Then
            BuscarLancamentos("E", dtgLancamentosEnviados, txtCabecalho20, txtCabecalho21, wBotaoPesquisa)
        End If
        BuscarLancamentos("C", dtgLancamentosCobrados, txtCabecalho30, txtCabecalho31, wBotaoPesquisa)
    End Sub

    Private Sub BuscarLancamentos(ByVal pSituacao As String, ByRef pDataGridView As DataGridView, _
        ByRef pCabecalho0 As TextBox, ByRef pCabecalho1 As TextBox, ByVal pBotaoData As String)
        pCabecalho0.Text = ""
        pCabecalho1.Text = ""
        pDataGridView.DataSource = Nothing
        pDataGridView.Refresh()
        If pBotaoData = "" Then
            Exit Sub
        End If
        Dim wControle As Integer
        Dim wSQLTipoPesquisa As String
        Dim pPesquisa As String = ""

        wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
        If wControle <> 0 Then
            objVariaveisGlobais.MostraErro()
            Me.Close()
        End If

        Try
            If wTipoAssistência <> "" Then
                pPesquisa = " AND M.TipoAssistencia IN (" & wTipoAssistência & ") "
            End If

            If pBotaoData = "L" Then
                wSQLTipoPesquisa = " M.Data "
                lbTipoPesquisa.Text = "Lançado de: " & txtDataInicio.Text & " a " & txtDataFinal.Text
                lbTipoPesquisa.BackColor = Color.Yellow
            ElseIf pBotaoData = "E" Then
                wSQLTipoPesquisa = " isnull(M.Data_Envio, '" & DateAdd(DateInterval.Day, 1, CDate(txtDataFinal.Text)) & "') "
                lbTipoPesquisa.Text = "Enviado de: " & txtDataInicio.Text & " a " & txtDataFinal.Text
                lbTipoPesquisa.BackColor = Color.LightGreen
            Else
                wSQLTipoPesquisa = " isnull(M.Data_Cobranca, '" & DateAdd(DateInterval.Day, 1, CDate(txtDataFinal.Text)) & "') "
                lbTipoPesquisa.Text = "Cobrado de: " & txtDataInicio.Text & " a " & txtDataFinal.Text
                lbTipoPesquisa.BackColor = Color.LightBlue
            End If
            Dim wSQL As String = "SET DATEFORMAT DMY " & _
                " SELECT M.IdMovimento, MData = M.Data, CAST(isnull(Matricula,0) AS INTEGER), Ass.Nome, isnull(Documento,0), " & _
                " Valor = (ISNULL(M.ValorConducao,0) + ISNULL(M.ValorMedicamento,0) + ISNULL(M.ValorServico,0) + " & _
                " ISNULL(M.ValorEquipamento,0) + ISNULL(M.ValorVisita,0) + " & _
                " ISNULL(M.ValorEverminacao,0) + ISNULL(M.ValorSemem,0) + ISNULL(M.ValorMaodeObra,0) + ISNULL(M.ValorOutros,0)), " & _
                " Data_Envio = isnull(CONVERT(VARCHAR(10), M.Data_Envio, 103), ''), " & _
                " Data_Cobranca = isnull(CONVERT(VARCHAR(10), M.Data_Cobranca, 103), '') " & _
                " FROM Ass_Tecnicos T, Ass_TipoAssistencia A, Ass_TipoServico S, Ass_Movimento M " & _
                " LEFT JOIN Ass_Animais An ON An.Codigo = M.Animal " & _
                " LEFT JOIN Ass_Associados Ass ON Ass.Codigo = M.Associado " & _
                " WHERE " & wSQLTipoPesquisa & " BETWEEN '" & txtDataInicio.Text & "' AND '" & txtDataFinal.Text & "'" & _
                " AND T.Codigo = M.Tecnico " & _
                " AND A.Codigo = M.TipoAssistencia " & _
                " AND S.Codigo = M.TipoServico " & _
                " AND isnull(M.Data_Hora_Exclusao,'') = '' " & _
                " AND isnull(M.Situacao,'') = '" & pSituacao & "' " & _
                pPesquisa & _
                " ORDER BY isnull(Documento,0) "
            wControle = MostraTabelaNova(pDataGridView, wSQL)
            If wControle < 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            ElseIf wControle = 1 Then
                MsgBox("Não foram encontrados registros!")
            End If
            CabecalhoGrid(pDataGridView, pCabecalho0, pCabecalho1, "")

            Dim wRows As Integer = pDataGridView.Rows.Count
            For i As Integer = 0 To wRows - 1
                pDataGridView.Item(3, i).ToolTipText = "Lançado:" & pDataGridView.Item(2, i).Value & Space(3) & _
                "Enviado:" & pDataGridView.Item(7, i).Value & Space(3) & _
                "Cobrado:" & pDataGridView.Item(8, i).Value
                pDataGridView.Item(4, i).ToolTipText = pDataGridView.Item(4, i).Value
            Next

        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao Pesquisar: " + ex.Message)
        End Try
    End Sub

    Public Function MostraTabelaNova(ByRef pObjTabela As System.Windows.Forms.DataGridView, _
                          ByVal pSQL As String) As Integer

        Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
        Dim wControle As Integer
        wDataSetBaixas = New DataSet

        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle < 0 Then
                Return wControle
            End If 

            wComando.CommandText = pSQL
            wDataAdapter.SelectCommand = wComando
            wDataAdapter.Fill(wDataSetBaixas, "TABLE")
            wDataAdapter.Dispose()

            wDataSetBaixas.Tables(0).Columns(0).ColumnName = "Mov"
            wDataSetBaixas.Tables(0).Columns(1).ColumnName = "Data"
            wDataSetBaixas.Tables(0).Columns(2).ColumnName = "Matrícula"
            wDataSetBaixas.Tables(0).Columns(3).ColumnName = "Nome"
            wDataSetBaixas.Tables(0).Columns(4).ColumnName = "Documento"
            wDataSetBaixas.Tables(0).Columns(5).ColumnName = "Valor"
            wDataSetBaixas.Tables(0).Columns(6).ColumnName = "Data_Envio"
            wDataSetBaixas.Tables(0).Columns(7).ColumnName = "Data_Cobranca"

            '*** O GridView já vem com a coluna MX então desloca 1 posição para a direita as demais
            pObjTabela.DataSource = wDataSetBaixas
            pObjTabela.DataMember = "TABLE"

            Dim wDataTable As New DataTable()
            wDataTable = wDataSetBaixas.Tables(0)

            Dim wDataView = New DataView(wDataTable, "", "", DataViewRowState.CurrentRows)
            pObjTabela.DataSource = wDataView

            If CDec(pObjTabela.Tag) = 0 Then pObjTabela.Tag = "1"
            pObjTabela.Columns(0).Width = 27 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(1).Width = 60 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(2).Width = 50 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(3).Width = 60 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(4).Width = 70 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(5).Width = 70 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(6).Width = 70 / CDec(pObjTabela.Tag)
            pObjTabela.Columns(1).Visible = False
            pObjTabela.Columns(2).Visible = False 
            pObjTabela.Columns(7).Visible = False
            pObjTabela.Columns(8).Visible = False
            If wDataSetBaixas.Tables(0).Rows.Count = 0 Then
                wDataSetBaixas = Nothing
            End If
            pObjTabela.RowHeadersWidth = 5

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Private Sub CabecalhoGrid(ByVal pObjTabela As DataGridView, ByVal pCabecalhoTxt0 As TextBox, _
     ByVal pCabecalhoTxt1 As TextBox, Optional ByVal pTipo As String = "")
        Dim wLinhas As Integer = 0
        Dim wLinhasMarcadas As Integer = 0
        Dim wTotal As Decimal = 0
        Dim wTotalMarcados As Decimal = 0

        For x As Integer = 0 To pObjTabela.RowCount - 1
            wLinhas += 1
            wTotal += NullDecimal(pObjTabela(6, x).Value)
            If pObjTabela(0, x).Value = True Then
                wLinhasMarcadas += 1
                wTotalMarcados += NullDecimal(pObjTabela(6, x).Value)
            End If
        Next

        pCabecalhoTxt0.Text = "Linhas: " & wLinhas & ", Total: R$ " & Format(wTotal, "###,###,##0.00") & ""
        pCabecalhoTxt1.Text = "Marcadas: " & wLinhasMarcadas & ", Total Marcado: R$ " & Format(wTotalMarcados, "###,###,##0.00") & ""

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

#Region " Variaveis de Impressao "

    Dim wAlturaPapel As Integer
    Dim sdb As System.Drawing.Brush
    Dim ContadorRegistro As Integer
    Dim blackPen As New Pen(Color.Black, 1)

    Dim Matricula_Beneficiario As String
    Dim Matricula_Beneficiario_Antigo As String
    Dim Nome_Beneficiario As String
    Dim Grau_Dependencia As String
    Dim Data_Vencimento As String
    Dim Valor As Decimal
    Dim Valor_Total As Decimal
    Dim Valor_Total_Geral As Decimal

    Dim xContador As Integer = 0
    Dim TotalRecords As Integer = 0
    Dim pagina As Integer = 0
    Dim dados As Integer = 0
    Dim dlg As PrintPreviewDialog

    Dim printFont1 As New Font("Courier New", 6, FontStyle.Bold, GraphicsUnit.Millimeter)
    Dim printFont21 As New Font("Courier New", 4, FontStyle.Bold, GraphicsUnit.Millimeter)
    Dim printFontP As New Font("Courier New", 2.5, FontStyle.Regular, GraphicsUnit.Millimeter)
    Dim printFont As New Font("Courier New", 3, FontStyle.Regular, GraphicsUnit.Millimeter)
    Dim printFontB As New Font("Courier New", 3, FontStyle.Bold, GraphicsUnit.Millimeter)

    Dim dFrl As New StringFormat
    Dim dFac As New StringFormat
    Dim mpreview As Boolean

    Private printFont3B As Font
    Private printFont3p5 As Font
    Private printFont2p5 As Font
    Private printFont2b As Font
    Private printFont2 As Font
    Private printFont4 As Font
    Private printFont4B As Font
    Private printFont5B As Font
    Private printFont2p5B As Font
    Private aPrinterSettings As Printing.PrinterSettings

#End Region

    Private Sub dtgLancamentos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgLancamentosLancados.MouseMove
        'Dim hti As DataGridView.HitTestInfo = dtgLancamentosLancados.HitTest(e.X, e.Y)
        'Dim wValor As Boolean = False
        'If hti.Type = DataGrid.HitTestType.ColumnHeader Then
        '    If hti.ColumnIndex = 0 Then
        '        Me.Cursor = System.Windows.Forms.Cursors.Hand
        '        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand
        '        ToolTip1.SetToolTip(dtgLancamentosLancados, "")
        '    Else
        '        Me.Cursor = System.Windows.Forms.Cursors.Default
        '        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        '        ToolTip1.SetToolTip(dtgLancamentosLancados, "")
        '    End If
        'End If 
    End Sub

    Private Sub dtgLancamentos_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgLancamentosLancados.MouseUp
        Dim hti As DataGridView.HitTestInfo = dtgLancamentosLancados.HitTest(e.X, e.Y)
        Dim wValor As Boolean = False

        If hti.Type = DataGrid.HitTestType.Cell Then
            If hti.ColumnIndex = 0 Then
                dtgLancamentosLancados.Item(0, hti.RowIndex).Value = IIf(dtgLancamentosLancados.Item(0, hti.RowIndex).Value, False, True)
            End If
        Else
            If dtgLancamentosLancados.RowCount > 0 Then
                If hti.ColumnIndex = 0 Then
                    wValor = IIf(dtgLancamentosLancados.Item(0, 0).Value, False, True)
                    For n As Integer = 0 To dtgLancamentosLancados.RowCount - 1
                        dtgLancamentosLancados.Item(0, n).Value = wValor
                    Next
                End If
            End If
        End If
        CabecalhoGrid(dtgLancamentosLancados, txtCabecalho10, txtCabecalho11)
    End Sub

    Private Sub dtgLancamentosEnviados_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgLancamentosEnviados.MouseMove
        'Dim hti As DataGridView.HitTestInfo = dtgLancamentosEnviados.HitTest(e.X, e.Y)
        'Dim wValor As Boolean = False
        'If hti.Type = DataGrid.HitTestType.ColumnHeader Then
        '    If hti.ColumnIndex = 0 Then
        '        Me.Cursor = System.Windows.Forms.Cursors.Hand
        '        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand
        '        ToolTip1.SetToolTip(dtgLancamentosEnviados, "")
        '    Else
        '        Me.Cursor = System.Windows.Forms.Cursors.Default
        '        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        '        ToolTip1.SetToolTip(dtgLancamentosEnviados, "")
        '    End If
        'ElseIf hti.Type = System.Windows.Forms.DataGrid.HitTestType.Cell Then
        '    If hti.ColumnIndex = 3 Then
        '        'ToolTip1.SetToolTip(dtgLancamentosEnviados, ConverteDataParaString(dtgLancamentosEnviados.Item(2, hti.RowIndex).Value.ToString))
        '    Else
        '        ToolTip1.SetToolTip(dtgLancamentosEnviados, "")
        '    End If
        'Else
        '    ToolTip1.SetToolTip(dtgLancamentosEnviados, "")
        'End If 
    End Sub

    Private Sub dtgLancamentosValidados_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgLancamentosEnviados.MouseUp
        Dim hti As DataGridView.HitTestInfo = dtgLancamentosEnviados.HitTest(e.X, e.Y)
        Dim wValor As Boolean = False

        If hti.Type = DataGrid.HitTestType.Cell Then
            If hti.ColumnIndex = 0 Then
                dtgLancamentosEnviados.Item(0, hti.RowIndex).Value = IIf(dtgLancamentosEnviados.Item(0, hti.RowIndex).Value, False, True)
            End If
        Else
            If dtgLancamentosEnviados.RowCount > 0 Then
                If hti.ColumnIndex = 0 Then
                    wValor = IIf(dtgLancamentosEnviados.Item(0, 0).Value, False, True)
                    For n As Integer = 0 To dtgLancamentosEnviados.RowCount - 1
                        dtgLancamentosEnviados.Item(0, n).Value = wValor
                    Next
                End If
            End If
        End If

        CabecalhoGrid(dtgLancamentosEnviados, txtCabecalho20, txtCabecalho21)
    End Sub

    Private Sub lblTipoAssistencia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTipoAssistencia.DoubleClick
        For i As Integer = 0 To clTipoAssistencia.Items.Count - 1
            If i = 0 AndAlso clTipoAssistencia.GetItemChecked(i) = True Then
                clTipoAssistencia.SetItemChecked(i, False)
            Else
                clTipoAssistencia.SetItemChecked(i, True)
            End If
            clTipoAssistencia.SetItemChecked(i, clTipoAssistencia.GetItemChecked(0))
        Next
    End Sub

    Private Sub btProcessarlancamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProcessarLancados.Click
        Dim wDR As DialogResult
        wDR = MessageBox.Show("Confirma ?", "Processar Envio para Cobrança !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Not wDR = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        Dim wControle As Integer
        Dim wIdMovimento As String
        Dim wCont As Integer = 0
        Dim wTransacao As SqlTransaction

        wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
        If wControle <> 0 Then
            objVariaveisGlobais.MostraErro()
            Me.Close()
        End If

        If Not IsDate(txtData_Envio.Text) OrElse CDate(txtData_Envio.Text) < CDate(txtDataFinal.Text) Then
            MessageBox.Show("Data de Envio precisa ser maior que a data final da pesquisa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        For i As Integer = 0 To dtgLancamentosEnviados.RowCount - 1
            If dtgLancamentosLancados(0, i).Value = True Then
                'If CDate(dtgLancamentosLancados(2, i).Value) > CDate(txtData_Cobranca.Text) Then
                If CDate(dtgLancamentosLancados(2, i).Value) > CDate(txtData_Envio.Text) Then
                    MessageBox.Show("Movimento: " & dtgLancamentosLancados(0, i).Value & Space(2) & _
                    "Data: " & dtgLancamentosLancados(1, i).Value & Space(2) & _
                    "Documento: " & dtgLancamentosLancados(4, i).Value & _
                    "tem data maior que a data de envio !")
                End If
            End If
        Next


        wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ProcessarLancamentos")
        wComando.Transaction = wTransacao

        pbProgresso.Minimum = 0
        pbProgresso.Maximum = dtgLancamentosLancados.RowCount

        Try
            For i As Integer = 0 To dtgLancamentosLancados.RowCount - 1
                If dtgLancamentosLancados(0, i).Value = True Then
                    wCont += 1
                    wIdMovimento = dtgLancamentosLancados(1, i).Value
                    wComando.CommandText = _
                       " UPDATE Ass_Movimento " & _
                       " SET Situacao = 'E', " & _
                       " Data_Envio = '" & ConverteDataParaString(txtData_Envio.Text) & "' " & _
                       " WHERE IdMovimento = '" & wIdMovimento & "' "
                    wControle = wComando.ExecuteNonQuery()
                    If wControle <= 0 Then
                        Throw New Exception("Erro ao gravar situação no movimento!")
                    End If
                    pbProgresso.Value = i
                End If
            Next
            wTransacao.Commit()

            If wCont > 0 Then
                MessageBox.Show("Lançamentos Atualizados com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                wCont = 0
            Else
                MessageBox.Show("Nunhum Lançamento foi Atualizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                wCont = 0
                Exit Sub
            End If
            pbProgresso.Value = 0

            Re_BuscarLancamentos()

        Catch ex As Exception
            pbProgresso.Value = 0
            Try
                wTransacao.Rollback()
            Catch

            End Try
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub btProcessarEnviados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProcessarEnviados.Click
        Dim wDR As DialogResult
        wDR = MessageBox.Show("Confirma ?", "Processar Cobrança Efetuada !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Not wDR = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        Dim wControle As Integer
        Dim wIdMovimento As String
        Dim wCont As Integer = 0
        Dim wTransacao As SqlTransaction

        wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
        If wControle <> 0 Then
            objVariaveisGlobais.MostraErro()
            Me.Close()
        End If

        If Not IsDate(txtData_Cobranca.Text) Then
            MessageBox.Show("Data de Cobrança precisa ser maior que a data final da pesquisa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        For i As Integer = 0 To dtgLancamentosEnviados.RowCount - 1
            If dtgLancamentosEnviados(0, i).Value = True Then
                If CDate(dtgLancamentosEnviados(2, i).Value) > CDate(txtData_Cobranca.Text) Then
                    MessageBox.Show("Movimento: " & dtgLancamentosEnviados(0, i).Value & Space(2) & _
                    "Data: " & dtgLancamentosEnviados(1, i).Value & Space(2) & _
                    "Documento: " & dtgLancamentosEnviados(4, i).Value & _
                    "tem data maior que a data de cobrança !")
                End If
            End If
        Next
        wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ValidarLancamentos")
        wComando.Transaction = wTransacao

        pbProgresso.Minimum = 0
        pbProgresso.Maximum = dtgLancamentosEnviados.RowCount

        Try

            For i As Integer = 0 To dtgLancamentosEnviados.RowCount - 1
                If dtgLancamentosEnviados(0, i).Value = True Then
                    wCont += 1
                    wIdMovimento = dtgLancamentosEnviados(1, i).Value
                    wComando.CommandText = _
                           " UPDATE Ass_Movimento " & _
                           " SET Situacao = 'C', " & _
                           " Data_Cobranca = '" & ConverteDataParaString(txtData_Cobranca.Text) & "' " & _
                           " WHERE IdMovimento = '" & wIdMovimento & "' "
                    wControle = wComando.ExecuteNonQuery()
                    If wControle <= 0 Then
                        Throw New Exception("Erro ao gravar situação no movimento!")
                    End If
                    pbProgresso.Value = i
                End If
            Next
            wTransacao.Commit()

            If wCont > 0 Then
                MessageBox.Show("Lançamentos Atualizados com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                wCont = 0
            Else
                MessageBox.Show("Nunhum Lançamento foi Atualizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                wCont = 0
                Exit Sub
            End If
            pbProgresso.Value = 0

            Re_BuscarLancamentos()

        Catch ex As Exception
            pbProgresso.Value = 0
            Try
                wTransacao.Rollback("ValidarLancamentos")
            Catch

            End Try
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub


    Private Sub btReverteLancamentosEnviados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReverteLancamentosEnviados.Click
        Dim wDR As DialogResult
        wDR = MessageBox.Show("Confirma ?", "Reverter Envio para Cobrança !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Not wDR = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        Dim wControle As Integer
        Dim wIdMovimento As String
        Dim wCont As Integer = 0
        Dim wTransacao As SqlTransaction

        wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
        If wControle <> 0 Then
            objVariaveisGlobais.MostraErro()
            Me.Close()
        End If

        wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ValidarLancamentos")
        wComando.Transaction = wTransacao

        pbProgresso.Minimum = 0
        pbProgresso.Maximum = dtgLancamentosEnviados.RowCount

        Try

            For i As Integer = 0 To dtgLancamentosEnviados.RowCount - 1
                If dtgLancamentosEnviados(0, i).Value = True Then
                    wCont += 1
                    wIdMovimento = dtgLancamentosEnviados(1, i).Value
                    wComando.CommandText = _
                           " UPDATE Ass_Movimento " & _
                           " SET Situacao = 'L', Data_Envio = Null " & _
                           " WHERE IdMovimento = '" & wIdMovimento & "' "
                    wControle = wComando.ExecuteNonQuery()
                    If wControle <= 0 Then
                        Throw New Exception("Erro ao gravar situação no movimento!")
                    End If
                End If
                pbProgresso.Value = i
            Next
            wTransacao.Commit()

            If wCont > 0 Then
                MessageBox.Show("Lançamentos Atualizados com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                wCont = 0
            Else
                MessageBox.Show("Nunhum Lançamento foi Atualizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                wCont = 0
                pbProgresso.Value = 0
                Exit Sub
            End If
            pbProgresso.Value = 0

            Re_BuscarLancamentos()

        Catch ex As Exception
            pbProgresso.Value = 0
            Try
                wTransacao.Rollback("ValidarLancamentos")
            Catch

            End Try
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub btReverteLancamentosCobrados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReverteLancamentosCobrados.Click
        Dim wDR As DialogResult
        wDR = MessageBox.Show("Confirma ?", "Reverter Cobrança Efetuada !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Not wDR = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        Dim wControle As Integer
        Dim wIdMovimento As String
        Dim wCont As Integer = 0
        Dim wTransacao As SqlTransaction

        wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
        If wControle <> 0 Then
            objVariaveisGlobais.MostraErro()
            Me.Close()
        End If

        wTransacao = VariaveisGlobais.gConexao.BeginTransaction(IsolationLevel.ReadCommitted, "ValidarLancamentos")
        wComando.Transaction = wTransacao

        pbProgresso.Minimum = 0
        pbProgresso.Maximum = dtgLancamentosCobrados.RowCount

        Try

            For i As Integer = 0 To dtgLancamentosCobrados.RowCount - 1
                If dtgLancamentosCobrados(0, i).Value = True Then
                    wCont += 1
                    wIdMovimento = dtgLancamentosCobrados(1, i).Value
                    wComando.CommandText = _
                           " UPDATE Ass_Movimento " & _
                           " SET Situacao = 'E', Data_Cobranca = Null " & _
                           " WHERE IdMovimento = '" & wIdMovimento & "' "
                    wControle = wComando.ExecuteNonQuery()
                    If wControle <= 0 Then
                        Throw New Exception("Erro ao gravar situação no movimento!")
                    End If
                End If
                pbProgresso.Value = i
            Next
            wTransacao.Commit()

            If wCont > 0 Then
                MessageBox.Show("Lançamentos Atualizados com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                wCont = 0
            Else
                MessageBox.Show("Nunhum Lançamento foi Atualizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                wCont = 0
                pbProgresso.Value = 0
                Exit Sub
            End If
            pbProgresso.Value = 0

            Re_BuscarLancamentos()

        Catch ex As Exception
            pbProgresso.Value = 0
            Try
                wTransacao.Rollback("ValidarLancamentos")
            Catch

            End Try
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgLancamentosCobrados_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgLancamentosCobrados.MouseMove
        'Dim hti As DataGridView.HitTestInfo = dtgLancamentosCobrados.HitTest(e.X, e.Y)
        'Dim wValor As Boolean = False
        'If hti.Type = DataGrid.HitTestType.ColumnHeader Then
        '    If hti.ColumnIndex = 0 Then
        '        Me.Cursor = System.Windows.Forms.Cursors.Hand
        '        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand
        '        ToolTip1.SetToolTip(dtgLancamentosCobrados, "")
        '    Else
        '        Me.Cursor = System.Windows.Forms.Cursors.Default
        '        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        '        ToolTip1.SetToolTip(dtgLancamentosCobrados, "")
        '    End If
        'ElseIf hti.Type = System.Windows.Forms.DataGrid.HitTestType.Cell Then
        '    If hti.ColumnIndex = 3 Then
        '        ToolTip1.SetToolTip(dtgLancamentosCobrados, ConverteDataParaString(dtgLancamentosCobrados.Item(2, hti.RowIndex).Value.ToString))
        '    Else
        '        ToolTip1.SetToolTip(dtgLancamentosCobrados, "")
        '    End If
        'End If 
    End Sub

    Private Sub dtgLancamentosCobrados_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgLancamentosCobrados.MouseUp
        Dim hti As DataGridView.HitTestInfo = dtgLancamentosCobrados.HitTest(e.X, e.Y)
        Dim wValor As Boolean = False

        If hti.Type = DataGrid.HitTestType.Cell Then
            If hti.ColumnIndex = 0 Then
                dtgLancamentosCobrados.Item(0, hti.RowIndex).Value = IIf(dtgLancamentosCobrados.Item(0, hti.RowIndex).Value, False, True)
            End If
        Else
            If dtgLancamentosCobrados.RowCount > 0 Then
                If hti.ColumnIndex = 0 Then
                    wValor = IIf(dtgLancamentosCobrados.Item(0, 0).Value, False, True)
                    For n As Integer = 0 To dtgLancamentosCobrados.RowCount - 1
                        dtgLancamentosCobrados.Item(0, n).Value = wValor
                    Next
                End If
            End If
        End If

        CabecalhoGrid(dtgLancamentosCobrados, txtCabecalho30, txtCabecalho31)
    End Sub

    Private Sub txtDataInicio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles txtDataInicio.Enter, txtDataFinal.Enter
        LimpaTela()
    End Sub
    Private Sub LimpaTela()
        lbTipoPesquisa.Text = "Movimento"
        lbTipoPesquisa.BackColor = Color.Gray
        dtgLancamentosLancados.DataSource = Nothing
        dtgLancamentosLancados.Refresh()
        dtgLancamentosEnviados.DataSource = Nothing
        dtgLancamentosEnviados.Refresh()
        dtgLancamentosCobrados.DataSource = Nothing
        dtgLancamentosCobrados.Refresh()
        txtCabecalho10.Text = ""
        txtCabecalho11.Text = ""
        txtCabecalho20.Text = ""
        txtCabecalho21.Text = ""
        txtCabecalho30.Text = ""
        txtCabecalho31.Text = ""
    End Sub

    Private Sub clTipoAssistencia_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles clTipoAssistencia.ItemCheck
        LimpaTela()
    End Sub
End Class
