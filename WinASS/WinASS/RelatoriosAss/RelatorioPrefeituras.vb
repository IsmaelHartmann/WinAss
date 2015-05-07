Imports System.Data.SqlClient
Imports System.GlobalizatioN.DateTimeFormatInfo
Imports System.Drawing.Printing

Public Class RelatorioPrefeituras


#Region " Variaveis Internas "

    Public objMovimentos_Implem As Movimento_Implem = MovimentoBOFactory.GetFactory().GetInstance()
    Public objParametros_Implem As Parametros_Implem = ParametrosBOFactory.GetFactory().GetInstance()
    Public objTiposServicos_Implem As TiposServicos_Implem = TiposServicosBOFactory.GetFactory().GetInstance()

    Dim sdb As System.Drawing.Brush
    Dim yPos As Integer
    Dim wAlturaPapel As Integer

    Public Canhoto As String
    Public Nome_associado As String
    Public CRMV_Tecnico As String
    Public Localidade As String
    Public TalaoMovimento As String
    Public Total_Registros As String
    Public Data As String
    Public Valor As String

    Dim DataI1 As String
    Dim DataF1 As String

    Dim TotalRecords As Integer = 0
    Dim pagina As Integer = 0
    Dim dados As Integer = 0
    Dim paginasimpressas As Integer = 0
    Dim dlg As PrintPreviewDialog

    Dim printFontP As New Font("Courier New", 1.8, FontStyle.Regular, GraphicsUnit.Millimeter)
    Dim printFont As New Font("Courier New", 3, FontStyle.Regular, GraphicsUnit.Millimeter)
    Dim printFont1 As New Font("Courier New", 4, FontStyle.Bold, GraphicsUnit.Millimeter)
    Dim printFontB As New Font("Courier New", 3, FontStyle.Bold, GraphicsUnit.Millimeter)
    Dim printFontC As New Font("Courier New", 4, FontStyle.Bold, GraphicsUnit.Millimeter)

    Dim dFrl As New StringFormat
    Dim dFac As New StringFormat
    Dim mpreview As Boolean
    Dim blackPen As New Pen(Color.Black, 1)

    Dim ContadorRegistro As Integer

    Private wComando As SqlCommand
    Private wDataReader As SqlDataReader
    Private wDataSetItens As DataSet
#End Region

#Region " Inicializações "

    Private Sub RelatorioMovimentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim autoriza As Boolean
        autoriza = VerificaPrograma("RelacaoMovimentos", VariaveisGlobais.gSetorUsuario, _
            VariaveisGlobais.gTipoUsuario, VariaveisGlobais.gLoginUsuario)
        If autoriza = False Then
            MessageBox.Show("Usuário não Autorizado ! " & Me.Name)
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
            dFrl.FormatFlags = StringFormatFlags.DirectionRightToLeft
            dFac.Alignment = StringAlignment.Center

            ' Preenche combo de Impressoras
            '__________________________________________________________________________
            Dim strDefaultPrinter As String = PrintDocument1.PrinterSettings.PrinterName.ToString

            Dim aNomeImpressora As String

            Dim cont As Integer = 0
            Dim cont1 As Integer = 0

            For cont = 0 To PrinterSettings.InstalledPrinters.Count - 1
                aNomeImpressora = PrinterSettings.InstalledPrinters.Item(cont).ToString()

                Dim c As New System.Web.UI.WebControls.ListItem
                c.Value = aNomeImpressora
                c.Text = aNomeImpressora
                cbImpressoras.Items.Add(c)

                If aNomeImpressora = strDefaultPrinter Then
                    cont1 = cont
                End If
            Next

            cbImpressoras.SelectedIndex = cont1

            'Prefeituras
            objVariaveisGlobais.PreencheComboBox(cbPrefeitura, VariaveisGlobais.gConexao, _
                " SELECT Codigo," & _
                " Nome " & _
                " FROM Ass_Prefeituras ORDER BY Codigo ", "")
            cbPrefeitura.SelectedIndex = 0

            txtDataInicio.Text = "01/" & Today.Month & "/" & Today.Year
            txtDataFinal.Text = Today

            wControle = objParametros_Implem.BuscarParametro
            If wControle <> 0 Then
                MsgBox("Erro ao Buscar Parâmetros!")
                objVariaveisGlobais.MostraErro()
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Me.Close()
        End Try
    End Sub

#End Region

    Private Sub RelatorioPrefeituras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F6 Then
            btLimpar.PerformClick()
        End If
        If e.KeyCode = Keys.F10 Then
            btFechar.PerformClick()
        End If

        If e.KeyCode = Keys.Escape Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
    End Sub

    Private Sub btLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLimpar.Click
        Try

            LimpaTela()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Public Sub LimpaTela()

        objVariaveisGlobais.InicializaVetorErros()

        txtDataInicio.Text = "01/" & Today.Month & "/" & Today.Year
        txtDataFinal.Text = Today.Date
        cbPrefeitura.SelectedIndex = 0
        rbAssociado.Checked = True

    End Sub

    Public Function FazPesquisa() As Integer

        Dim wControle As Integer
        Dim wInseminacao As Array = objParametros_Implem.Codigos_Inseminacao.Split(",")
        Dim wStringInseminacao As String = ""
        Dim pesquisa As String
        Dim wOrdem As String = ""
        Dim wFiltro As String = ""
        Dim wSQL As String = "SET DATEFORMAT DMY  "
        Try
            'Não mostrar junto os movimentos de inseminação
            For x As Integer = 0 To wInseminacao.Length - 1
                wStringInseminacao += "'" & wInseminacao(x) & "',"
            Next
            wStringInseminacao = wStringInseminacao.Substring(0, wStringInseminacao.Length - 1)

            If Not IsDate(txtDataInicio.Text) Or Not IsDate(txtDataFinal.Text) Then
                MsgBox("Informe Corretamente as Datas !")
                Return 1
            End If
            If CDate(txtDataFinal.Text).Year <= "1900" Or CDate(txtDataInicio.Text).Year <= "1900" Then
                MsgBox("Data Início e/ou Data Final não aparentam veracidade !")
                Return 1
            End If
            If CDate(txtDataInicio.Text) > CDate(txtDataFinal.Text) Then
                MsgBox("Data Final deve ser maior ou igual que a Data Inicial !")
                Return 1
            End If
            If cbPrefeitura.SelectedIndex <= 0 Then
                MsgBox("Selecione uma Prefeitura para realizar a busca!")
                Return 1
            End If
            If rbCanhotos.Checked = True Then
                'wFiltro = " AND isnull(M.Documento,0) = 0 AND isnull(M.Canhoto,0) <> 0 "
                wFiltro = " AND isnull(M.Canhoto,0) <> 0 "
            ElseIf rbDocumentos.Checked = True Then
                wFiltro = " AND isnull(M.Documento,0) <> 0 AND isnull(M.Canhoto,0) = 0 "
            End If

            'Ordem da Pesquisa
            If rbAssociado.Checked = True Then
                wOrdem = " ORDER BY A.Nome "
            ElseIf rbData.Checked = True Then
                wOrdem = " ORDER BY M.Data "
            End If

            DataI1 = CDate(txtDataInicio.Text)
            DataF1 = CDate(txtDataFinal.Text)

            pesquisa = " M.Data BETWEEN '" & DataI1 & "' AND '" & DataF1 & "'"

            wSQL += _
                " SELECT isnull(M.Canhoto,0), Nome = CAST(isnull(A.Nome,'') AS VARCHAR(100)), " & _
                " Endereco = isnull(A.Endereco,''),  " & _
                " Talao = isnull(M.Talao,''), CONVERT(VARCHAR(10), M.Data, 103), isnull(T.CRMV,''), " & _
                " Valor = isnull(M.ValorConducao,0) " & _
                " FROM Ass_Movimento M, Ass_Associados A, Ass_Tecnicos T, " & _
                " Ass_prefeituras P, Ass_TipoAssistencia Ass " & _
                " WHERE M.Associado = A.Codigo " & _
                " AND Ass.Codigo = M.TipoAssistencia " & _
                " AND M.Tecnico = T.Codigo " & _
                " AND M.Prefeitura = P.Codigo " & _
                " AND M.Data BETWEEN '" & DataI1 & "' AND '" & DataF1 & "'" & _
                " AND P.Codigo = '" & cbPrefeitura.SelectedItem.value & "' " & _
                " AND Ass.Codigo NOT IN(" & wStringInseminacao & ") " & _
                wFiltro & _
                wOrdem

            wControle = LerItens(wSQL)
            If wControle < 0 Then
                objVariaveisGlobais.MostraErro()
                Return wControle
            ElseIf wControle = 1 Then
                Return wControle
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
        Return 0
    End Function

#Region " Impressão "

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click
        Dim wcontrole As Integer
        Try

            wcontrole = FazPesquisa()
            If wcontrole <> 0 Then
                Exit Sub
            End If

            Dim tf As Boolean
            tf = SetPaperSize("A4", PrintDocument1)
            If tf = False Then
                Exit Sub
            End If

            tf = SetPrintDialog(wAlturaPapel, PrintDocument1)
            If tf = False Then
                Exit Sub
            End If

            mpreview = False

            PrintDocument1.Print()


        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub btVerImpressão_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVerImpressão.Click
        Dim wcontrole As Integer
        Try
            wcontrole = FazPesquisa()
            If wcontrole <> 0 Then
                MsgBox("Não Foram Encontrados Registros!")
                Exit Sub
            End If

            Dim tf As Boolean
            tf = SetPaperSize("A4", PrintDocument1)
            If tf = False Then
                Exit Sub
            End If

            tf = SetPrintDialog(wAlturaPapel, PrintDocument1)
            If tf = False Then
                Exit Sub
            End If

            Dim dlg As New PrintPreviewDialog
            dlg.PrintPreviewControl.Zoom = 1.0
            dlg.WindowState = FormWindowState.Maximized

            mpreview = False
            dlg.Document = PrintDocument1
            dlg.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("An error occurred - " + ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
    Handles PrintDocument1.PrintPage
        If mpreview = False Then
            ContadorRegistro = 0
            Total_Registros = 0
            pagina = 0
        End If
        If wDataSetItens.Tables.Count > 0 Then
            TotalRecords = wDataSetItens.Tables(0).Rows.Count.ToString()
        End If
        Dim paginain As Integer = e.PageSettings.PrinterSettings.FromPage
        Dim paginafi As Integer = e.PageSettings.PrinterSettings.ToPage
        While pagina + 1 < paginain
            sdb = Brushes.White
            PrintDocument2_PrintPage(sender, e)
        End While
        sdb = Brushes.Black
        PrintDocument2_PrintPage(sender, e)
        If pagina + 1 > paginafi Then
            mpreview = False
            e.HasMorePages = False
        End If
        'Dim sdb As System.Drawing.Brush
    End Sub

    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        mpreview = True

        pagina += 1
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim rightMargin As Single = e.MarginBounds.Right
        Dim wControle As Integer
        wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
        If wControle < 0 Then
            objVariaveisGlobais.MostraErro()
            Exit Sub
        End If

        MontaCabecalho(e)

        Dim i As Integer

        yPos = 100

        For i = ContadorRegistro To TotalRecords - 1
            If yPos > wAlturaPapel - 100 Then
                e.HasMorePages = True
                ContadorRegistro = i
                Exit Sub
            End If

            Canhoto = wDataSetItens.Tables(0).Rows(i)(0)
            Nome_associado = wDataSetItens.Tables(0).Rows(i)(1)
            Localidade = wDataSetItens.Tables(0).Rows(i)(2)
            TalaoMovimento = wDataSetItens.Tables(0).Rows(i)(3)
            Data = wDataSetItens.Tables(0).Rows(i)(4)
            CRMV_Tecnico = wDataSetItens.Tables(0).Rows(i)(5)

            'e.Graphics.DrawString(Format(Data.Day, "00") & "/" & Format(Data.Month, "00"), printFont, sdb, 0, yPos)
            e.Graphics.DrawString(Canhoto, printFont, sdb, 10, yPos)
            e.Graphics.DrawString((Nome_associado & Space(40)).Substring(0, 40), printFont, sdb, 80, yPos)
            e.Graphics.DrawString((Localidade & Space(19)).Substring(0, 19), printFont, sdb, 350, yPos)
            e.Graphics.DrawString(TalaoMovimento, printFont, sdb, 600, yPos, dFrl)
            e.Graphics.DrawString(Data, printFont, sdb, 630, yPos)
            e.Graphics.DrawString(CRMV_Tecnico, printFont, sdb, 780, yPos, dFrl)
            yPos += 15

            Total_Registros += 1

        Next
        yPos += 25
        If yPos > wAlturaPapel - 100 Then
            e.HasMorePages = True
            ContadorRegistro = i
            Exit Sub
        End If

        e.Graphics.DrawString("TOTAL DE REGISTROS:", printFontB, Brushes.Black, 390, yPos)
        e.Graphics.DrawString(Total_Registros, printFontB, sdb, 780, yPos, dFrl)
        mpreview = False

    End Sub

    Private Sub MontaCabecalho(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        e.Graphics.DrawString(pagina, printFont, sdb, 780, 15, dFrl)
        e.Graphics.DrawString("PAG", printFontB, sdb, 700, 15, dFrl)
        e.Graphics.DrawString("Dt/Hr Emitido: " & Date.Now, printFont, Brushes.Black, 530, 30)
        'e.Graphics.DrawString(Date.Now, printFont, Brushes.Black, 780, 30)
        e.Graphics.DrawString("Usuário: " & VariaveisGlobais.gLoginUsuario, printFont, Brushes.Black, 780, 45, dFrl)

        e.Graphics.DrawString("RELATÓRIO SERVIÇOS VETERINÁRIOS", printFontC, sdb, 400, 10, dFac)
        e.Graphics.DrawString("Período de " & txtDataInicio.Text & " Até " & txtDataFinal.Text, printFont, sdb, 10, 30)
        e.Graphics.DrawString("PREFEITURA DE " & cbPrefeitura.Text, printFont, sdb, 10, 45)

        e.Graphics.DrawString("Canhoto", printFontB, sdb, 10, 70)
        e.Graphics.DrawString("Nome Associado", printFontB, sdb, 80, 70)
        e.Graphics.DrawString("Localidade", printFontB, sdb, 350, 70)
        e.Graphics.DrawString("Talão", printFontB, sdb, 600, 70, dFrl)
        e.Graphics.DrawString("Data", printFontB, sdb, 630, 70)
        e.Graphics.DrawString("CRMV", printFontB, sdb, 780, 70, dFrl)

        e.Graphics.DrawLine(blackPen, 10, 86, 1100, 86)

    End Sub

    Private Sub cbImpressoras_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbImpressoras.SelectedIndexChanged
        PrintDocument1.DefaultPageSettings.PrinterSettings.PrinterName = cbImpressoras.SelectedItem.Value
        'PrintDocument1.DefaultPageSettings.Landscape = True
    End Sub

    Public Function LerItens(ByVal pSQL As String) As Integer

        Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
        wDataSetItens = New DataSet
        Dim wControle As Integer


        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle < 0 Then
                Return wControle
            End If
            ' Preenche o DataSet com o resultado do SQL

            wComando.CommandText = pSQL
            wDataAdapter.SelectCommand = wComando
            wDataAdapter.Fill(wDataSetItens, "TABLE")
            wDataAdapter.Dispose()

            If wDataSetItens.Tables(0).Rows.Count = Nothing Then
                Return 1
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return -1
        End Try
        Return 0
    End Function

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

#End Region
    Private Sub btFechar_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub btGeraExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGeraExcel.Click
        Try
            Dim wControle As Integer
            wControle = FazPesquisa()
            If wControle < 0 Then
                objVariaveisGlobais.MostraErro()
                Exit Sub
            ElseIf wControle > 0 Then
                MsgBox("Não Existem Lançamentos para exportar!")
                Exit Sub
            End If

            Dim wTotal As Decimal = 0

            With SaveFileDialog1
                .Filter = "Text files (*.xls)|*.xls"
                .FilterIndex = 1
                .Title = "Selecione um Local Para Salvar o Arquivo "
                .FileName = cbPrefeitura.Text & "_" & CStr(ConverteDataParaString(txtDataInicio.Text)).Replace("/", "").Remove(4, 2) & "_" & CStr(ConverteDataParaString(txtDataFinal.Text)).Replace("/", "").Remove(4, 2) & ".xls"
            End With
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim strFileName As String
                strFileName = SaveFileDialog1.FileName
                If strFileName.Substring(strFileName.Length - 4, 4) = ".xls" Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim oXL As Excel.Application
                    Dim oWB As Excel.Workbook
                    Dim oSheet As Excel.Worksheet

                    ' Start Excel and get Application object.

                    oXL = CreateObject("Excel.Application", "\\localhost")
                    oWB = oXL.Workbooks.Add
                    oSheet = oWB.ActiveSheet

                    'oSheet.Cells(1, 1).Value = "RELATORIO DE MOVIMENTOS"

                    'With oSheet.Range("A1", "A3")
                    '    .Font.Size = 10
                    '    .Interior.ColorIndex = 6
                    '    .Font.Bold = True
                    'End With
                    oSheet.Cells(1, 1).Value = cbPrefeitura.Text
                    
                    'oSheet.Cells(5, 1).Value = "Tecnico: " & cbTecnico.Text
                    'oSheet.Cells(4, 1).Value = "Servico: " & cbTipoServico.Text
                    'oSheet.Cells(3, 5).Value = "Assist: : " & cbTipoAssistencia.Text
                    'oSheet.Cells(4, 5).Value = "Animal: " & cbAnimal.Text

                    With oSheet.Range("A3", "F3")
                        .Font.Size = 10
                        .Interior.ColorIndex = 8
                        .Font.Bold = True
                    End With
                    oSheet.Cells(3, 1).Value = "ASSOCIADO" 'A
                    oSheet.Cells(3, 2).Value = "LOCALIDADE" 'B
                    oSheet.Cells(3, 3).Value = "DOCUMENTO" 'C
                    oSheet.Cells(3, 4).Value = "DATA" 'D
                    oSheet.Cells(3, 5).Value = "CRMV" 'E
                    oSheet.Cells(3, 6).Value = "VALOR" 'E

                    oXL.Workbooks(1).Worksheets(1).Range("A:A").ColumnWidth = 20
                    oXL.Workbooks(1).Worksheets(1).Range("B:B").ColumnWidth = 20
                    oXL.Workbooks(1).Worksheets(1).Range("C:C").ColumnWidth = 20
                    oXL.Workbooks(1).Worksheets(1).Range("D:D").ColumnWidth = 20
                    oXL.Workbooks(1).Worksheets(1).Range("E:E").ColumnWidth = 20
                    oXL.Workbooks(1).Worksheets(1).Range("F:F").ColumnWidth = 20

                    Dim count As Integer = 3
                    Dim i As Integer
                    For i = 0 To wDataSetItens.Tables(0).Rows.Count - 1
                        count += 1

                        Nome_associado = wDataSetItens.Tables(0).Rows(i)(1)
                        Localidade = wDataSetItens.Tables(0).Rows(i)(2)
                        TalaoMovimento = wDataSetItens.Tables(0).Rows(i)(3)
                        Data = wDataSetItens.Tables(0).Rows(i)(4)
                        CRMV_Tecnico = wDataSetItens.Tables(0).Rows(i)(5)
                        Valor = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(6)), 0, wDataSetItens.Tables(0).Rows(i)(6))

                        oSheet.Cells(count, 1).Value = Nome_associado
                        oSheet.Cells(count, 2).Value = Localidade
                        oSheet.Cells(count, 3).Value = TalaoMovimento
                        oSheet.Cells(count, 4).Value = Data
                        oSheet.Cells(count, 5).Value = CRMV_Tecnico
                        oSheet.Cells(count, 6).Value = Format(CDec(Valor), "#,###,##0.00")

                        wTotal += Valor

                    Next
                    count += 2

                    oSheet.Cells(count, 3).Value = Format(CDec(wTotal), "#,###,##0.00")
                    oWB.SaveAs(strFileName)

                    '******************************************************
                    If Not oWB Is Nothing Then
                        Dim obj1 As Object = oSheet
                        EliminaReferencias(obj1)
                        oXL.Workbooks(1).Close(False)
                        obj1 = oWB
                        EliminaReferencias(obj1)
                        oXL.Quit()
                        obj1 = oXL
                        EliminaReferencias(obj1)
                    End If

                    Me.Cursor = Cursors.Default
                End If
                MsgBox("Arquivo Gerado com sucesso!")
            End If

            System.GC.Collect()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Exit Sub
        End Try
    End Sub

    Private Sub EliminaReferencias(ByRef Referencias As Object)
        Try
            'Bucle de eliminacion
            Do Until _
                 System.Runtime.InteropServices.Marshal.ReleaseComObject(Referencias) <= 0
            Loop
        Catch
        Finally
            Referencias = Nothing
        End Try
    End Sub

End Class
 