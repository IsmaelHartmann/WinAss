Imports System.Data.SqlClient
Imports System.GlobalizatioN.DateTimeFormatInfo
Imports System.Drawing.Printing

Public Class RelatorioMovimentos

#Region " Variaveis Internas "

    Public objMovimentos_Implem As Movimento_Implem = MovimentoBOFactory.GetFactory().GetInstance()
    Public objAssociados_Implem As Associados_Implem = AssociadosBOFactory.GetFactory().GetInstance()
    Public objTiposServicos_Implem As TiposServicos_Implem = TiposServicosBOFactory.GetFactory().GetInstance()

    Dim sdb As System.Drawing.Brush
    Dim spen As New Pen(Color.Black, 1)

    Dim yPos As Integer
    Dim wAlturaPapel As Integer

    Private Data As String
    Private Matricula_Associado As String
    Private Matricula As Integer
    Private Nome_Associado As String
    Private Documento As String
    Private Tpg As String
    Private Talao As String
    Private Tecnico As String
    Private Dado_Novo As String
    Private Dado_Nome As String
    Private Dado_Antigo As String
    Private TipoServico As String
    Private Animal As String
    Private Numero As String
    Private Ger As String
    Private Nro As String
    Private Cabecas As String
    Private TipoAss As String
    Private MaoObra As String
    Private NTouro As String
    Private TipoAssCoolan As String
    Private Conducao As Decimal
    Private Medicamento As Decimal
    Private Equipamento As Decimal
    Private Beneficio As Decimal
    Private Servico As Decimal
    Private MaoDeObra As Decimal
    Private Everminacao As Decimal
    Private Semem As Decimal
    Private Visita As Decimal
    Private Outros As Decimal
    Private Total As Decimal
    Private SomaEverminacao As Decimal
    Private SomaMaoObra As Decimal
    Private SomaVisita As Decimal
    Private SomaConducao As Decimal
    Private SomaMedicamento As Decimal
    Private SomaServico As Decimal
    Private SomaEquipamento As Decimal
    Private SomaBeneficio As Decimal
    Private SomaSemem As Decimal
    Private SomaOutros As Decimal

    'BRF
    Private CdProdutor As String
    Private SPMON As String
    Private NrDoc As String
    Private VlConvenio As Decimal
    Private T_VlConvenio As Decimal

    Private TotalEverminacao As Decimal
    Private TotalMaoObra As Decimal
    Private TotalVisita As Decimal
    Private TotalConducao As Decimal
    Private TotalMedicamento As Decimal
    Private TotalServico As Decimal
    Private TotalEquipamento As Decimal
    Private TotalBeneficio As Decimal
    Private TotalSemem As Decimal
    Private TotalOutros As Decimal 
    Private TotalGeral As Decimal

    Private wAgrupamentoAss As String
    Private wAgrupamentoValorTotal As Decimal
    Private wAgrupamentoString As String

  
    Private mEmpresaAntigo As String
    Private mDiaAntigo As String
    Private mClienteAntigo As String
    Private wTipoAssistência As String

    Dim DataI1 As String
    Dim DataF1 As String

    Dim TotalRecords As Integer = 0
    Dim pagina As Integer = 0
    Dim dados As Integer = 0
    Dim paginasimpressas As Integer = 0
    Dim dlg As PrintPreviewDialog

    Dim printFont25 As New Font("Courier New", 2.5, FontStyle.Regular, GraphicsUnit.Millimeter)
    Dim printFont25B As New Font("Courier New", 2.5, FontStyle.Bold, GraphicsUnit.Millimeter)
    Dim printFont As New Font("Courier New", 2.5, FontStyle.Regular, GraphicsUnit.Millimeter)
    Dim printFont1 As New Font("Courier New", 4, FontStyle.Bold, GraphicsUnit.Millimeter)
    Dim printFontB As New Font("Courier New", 3, FontStyle.Bold, GraphicsUnit.Millimeter)
    Dim printFontC As New Font("Courier New", 4, FontStyle.Bold, GraphicsUnit.Millimeter)

    Dim dFrl As New StringFormat
    Dim dFac As New StringFormat
    Dim mpreview As Boolean


    Dim ContadorRegistro As Integer

    Private wComando As SqlCommand
    Private wDataReader As SqlDataReader
    Private wDataSetItens As DataSet
    Private wDataSetItensAgrupamento As DataSet
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

            'Associado
            'objVariaveisGlobais.PreencheComboBox(cbAssociado, VariaveisGlobais.gConexao, _
            '    " SELECT Codigo," & _
            '    " CAST(Codigo AS VARCHAR(3))+' '+CAST(Nome AS VARCHAR)AS Associados " & _
            '    " FROM Ass_Associados " & _
            '    " ORDER BY Codigo ", "")
            'cbAssociado.SelectedIndex = 0

            'Tecnico
            objVariaveisGlobais.PreencheComboBox(cbTecnico, VariaveisGlobais.gConexao, _
                " SELECT Codigo," & _
                " CAST(CRMV AS VARCHAR)+' '+CAST(Nome AS VARCHAR) AS Tecnico " & _
                " FROM Ass_Tecnicos  " & _
                " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
                " ORDER BY Codigo ", "")

            cbTecnico.SelectedIndex = 0

            'Tipo Assistencia
            objVariaveisGlobais.PreencheCheckedList(clTipoAssistencia, VariaveisGlobais.gConexao, _
                " SELECT Codigo," & _
                " CAST(Codigo AS VARCHAR(3))+' '+CAST(Descricao AS VARCHAR)AS TipoAssistencia " & _
                " FROM Ass_TipoAssistencia " & _
                " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
                " ORDER BY Codigo ", True)

            'Tipo Servico
            objVariaveisGlobais.PreencheComboBox(cbTipoServico, VariaveisGlobais.gConexao, _
                " SELECT Codigo," & _
                " CAST(Codigo AS VARCHAR(3))+' '+CAST(Descricao AS VARCHAR)AS TipoServico " & _
                " FROM Ass_TipoServico " & _
                " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
                " ORDER BY Codigo ", "")

            cbTipoServico.SelectedIndex = 0

            'Animal
            objVariaveisGlobais.PreencheComboBox(cbAnimal, VariaveisGlobais.gConexao, _
                " SELECT Codigo," & _
                " CAST(Codigo AS VARCHAR(3))+' '+CAST(Nome AS VARCHAR)AS Animais " & _
                " FROM Ass_Animais " & _
                " WHERE isnull(Data_Hora_Exclusao,'') = '' " & _
                " ORDER BY Codigo ", "")

            cbAnimal.SelectedIndex = 0

            txtDataInicio.Text = "01/01/" & Today.Year
            txtDataFinal.Text = Today

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Me.Close()
        End Try
    End Sub

#End Region


    Private Sub RelatorioMovimentos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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

        txtDataInicio.Text = "01/01/" & Today.Year
        txtDataFinal.Text = Today.Date
        cbTecnico.SelectedIndex = 0 
        txtCodigo_Associado.Text = ""
        txtMatricula_Associado.Text = ""
        txtNome_Associado.Text = ""
        cbTipoServico.SelectedIndex = 0
        cbAnimal.SelectedIndex = 0
        cbSemAnimal.Checked = False
        cbAnimal.SelectedIndex = 0
        cbAnimal.Enabled = True
        rbTecnico.Checked = True

    End Sub

    Public Function FazPesquisaAgrupamento() As Integer

        Dim wControle As Integer
        Dim pesquisa As String = ""
        Dim pesquisaSituacao As String = ""
        Dim wOrdem As String = ""
        Dim wStrErro As String = ""
        Dim wFiltro As String = ""
        Dim wSQL As String = "SET DATEFORMAT DMY  "
        Try

            If Not IsDate(txtDataInicio.Text) Or Not IsDate(txtDataFinal.Text) Then
                MsgBox("Informe Corretamente as Datas !")
                Return 1
            End If
            If CDate(txtDataFinal.Text).Year <= "1900" Or CDate(txtDataInicio.Text).Year <= "1900" Then
                MsgBox("Data Início e/ou Data Final não aparentam veracidade !")
                Return 1
            End If
            If CDate(txtDataInicio.Text) > CDate(txtDataFinal.Text) Then
                MsgBox("Data Final deve ser igual ou maior que a Data Inicial !")
                Return 1
            End If
            If rbCanhotos.Checked = True Then
                wFiltro = " AND isnull(M.Canhoto,0) <> 0 "
            ElseIf rbDocumentos.Checked = True Then
                wFiltro = " AND isnull(M.Documento,0) <> 0 AND isnull(M.Canhoto,0) = 0 "
            End If

            'Ordem da Pesquisa
            If rbTecnico.Checked = True Then
                wOrdem = " ORDER BY T.Nome "
            ElseIf rbData.Checked = True Then
                wOrdem = " ORDER BY M.Data "
            ElseIf rbAssistencia.Checked = True Then
                wOrdem = " ORDER BY A.Descricao"
            ElseIf rbServico.Checked = True Then
                wOrdem = " ORDER BY S.Descricao"
            End If

            DataI1 = CDate(txtDataInicio.Text)
            DataF1 = CDate(txtDataFinal.Text)

            pesquisa = " M.Data between '" & DataI1 & "' and '" & DataF1 & "'"

            If txtCodigo_Associado.Text <> "" Then
                pesquisa += " AND M.Associado = '" & txtCodigo_Associado.Text & "' "
                'ElseIf txtCodigo_Associado.Text = "" Then
                'wStrErro += "Preencha corretamente o Associado " & vbCrLf
            End If

            If cbTecnico.SelectedIndex > 0 Then
                pesquisa += " AND M.Tecnico = '" & cbTecnico.SelectedItem.value & "' "
            ElseIf cbTecnico.SelectedIndex < 0 Then
                wStrErro += "Preencha corretamente o Técnico " & vbCrLf
            End If

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
            If wTipoAssistência <> "" Then
                pesquisa += " AND M.TipoAssistencia IN (" & wTipoAssistência & ") "
            Else
                wStrErro += "Selecione um ou mais Tipo de Assistência " & vbCrLf
            End If

            If cbTipoServico.SelectedIndex > 0 Then
                pesquisa += " AND M.TipoServico = '" & cbTipoServico.SelectedItem.value & "' "
            ElseIf cbTipoServico.SelectedIndex < 0 Then
                wStrErro += "Preencha corretamente o Tipo de Serviço " & vbCrLf
            End If

            If cbAnimal.Enabled = True Then
                If cbAnimal.SelectedIndex > 0 Then
                    pesquisa += " AND M.Animal = '" & cbAnimal.SelectedItem.value & "' "
                ElseIf cbAnimal.SelectedIndex < 0 Then
                    wStrErro += "Preencha corretamente o Animal " & vbCrLf
                End If
            End If

            If rbSituacaoLancados.Checked = True Then
                pesquisaSituacao = " AND M.Situacao = 'L' "
            ElseIf rbSituacaoEnviados.Checked = True Then
                pesquisaSituacao = " AND M.Situacao = 'E' "
            ElseIf rbSituacaoCobrados.Checked = True Then
                pesquisaSituacao = " AND M.Situacao = 'C' "
            ElseIf rbTodos.Checked = True Then
                pesquisaSituacao = ""
            End If

            If wStrErro = "" Then

                wSQL += _
                " SELECT A.Descricao, Valor = SUM(isnull(ValorVisita,0))" & _
                " + SUM(isnull(ValorConducao, 0)) + SUM(isnull(ValorMedicamento,0))" & _
                " + SUM(isnull(ValorServico,0)) + SUM(isnull(ValorEquipamento,0))" & _
                " + SUM(isnull(ValorMaoDeObra, 0)) + SUM(isnull(ValorEverminacao,0))" & _
                " + SUM(isnull(ValorSemem,0))" & _
                " + SUM(isnull(ValorOutros,0)) " & _
                " FROM Ass_Tecnicos T, Ass_TipoAssistencia A, Ass_TipoServico S, Ass_Associados Ass, " & _
                " Ass_Movimento M  " & _
                " LEFT JOIN Ass_Animais An ON An.Codigo = M.Animal " & _
                " WHERE " & pesquisa & _
                pesquisaSituacao & _
                " AND T.Codigo = M.Tecnico " & _
                " AND Ass.Codigo = M.Associado " & _
                " AND A.Codigo = M.TipoAssistencia " & _
                " AND S.Codigo = M.TipoServico " & _
                " AND isnull(M.Data_Hora_Exclusao,'') = '' " & _
                wFiltro & _
                " GROUP BY A.Descricao " & _
                " ORDER BY A.Descricao "

                wControle = LerItensAgrupamento(wSQL)
                If wControle < 0 Then
                    objVariaveisGlobais.MostraErro()
                    Return wControle
                ElseIf wControle = 1 Then
                    Return wControle
                End If
            Else
                MsgBox(wStrErro, MsgBoxStyle.Critical, "A Busca Não Foi Realizada")
                Return 1
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
        Return 0
    End Function

    Public Function FazPesquisaParaTxt() As Integer

        Dim wControle As Integer
        Dim pesquisa As String
        Dim wOrdem As String = ""
        Dim wStrErro As String = ""
        Dim wFiltro As String = ""
        Dim wpesquisaSituacao As String = ""
        Dim wSQL As String = "SET DATEFORMAT DMY  "
        Try

            If Not IsDate(txtDataInicio.Text) Or Not IsDate(txtDataFinal.Text) Then
                MsgBox("Informe Corretamente as Datas !")
                Return 1
            End If
            If CDate(txtDataFinal.Text).Year <= "1900" Or CDate(txtDataInicio.Text).Year <= "1900" Then
                MsgBox("Data Início e/ou Data Final não aparentam veracidade !")
                Return 1
            End If
            If CDate(txtDataInicio.Text) > CDate(txtDataFinal.Text) Then
                MsgBox("Data Final deve ser igual ou maior que a Data Inicial !")
                Return 1
            End If
            If rbCanhotos.Checked = True Then
                wFiltro = " AND isnull(M.Documento,0) = 0 AND isnull(M.Canhoto,0) <> 0 "
            ElseIf rbDocumentos.Checked = True Then
                wFiltro = " AND isnull(M.Documento,0) <> 0 AND isnull(M.Canhoto,0) = 0 "
            End If

            'Ordem da Pesquisa
            If rbTecnico.Checked = True Then
                wOrdem = " ORDER BY T.Nome "
            ElseIf rbData.Checked = True Then
                wOrdem = " ORDER BY M.Data "
            ElseIf rbAssistencia.Checked = True Then
                wOrdem = " ORDER BY A.Descricao"
            ElseIf rbServico.Checked = True Then
                wOrdem = " ORDER BY S.Descricao"
            End If

            If rbSituacaoLancados.Checked = True Then
                wpesquisaSituacao = " AND M.Situacao = 'L' "
            ElseIf rbSituacaoEnviados.Checked = True Then
                wpesquisaSituacao = " AND M.Situacao = 'E' "
            ElseIf rbSituacaoCobrados.Checked = True Then
                wpesquisaSituacao = " AND M.Situacao = 'C' "
            ElseIf rbTodos.Checked = True Then
                wpesquisaSituacao = ""
            End If

            DataI1 = CDate(txtDataInicio.Text)
            DataF1 = CDate(txtDataFinal.Text)

            pesquisa = " M.Data between '" & DataI1 & "' and '" & DataF1 & "'"

            If txtCodigo_Associado.Text <> "" Then
                pesquisa += " AND M.Associado = '" & txtCodigo_Associado.Text & "' "
                'ElseIf txtCodigo_Associado.Text = "" Then
                'wStrErro += "Preencha corretamente o Associado " & vbCrLf
            End If

            If cbTecnico.SelectedIndex > 0 Then
                pesquisa += " AND M.Tecnico = '" & cbTecnico.SelectedItem.value & "' "
            ElseIf cbTecnico.SelectedIndex < 0 Then
                wStrErro += "Preencha corretamente o Técnico " & vbCrLf
            End If

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
            If wTipoAssistência <> "" Then
                pesquisa += " AND M.TipoAssistencia IN (" & wTipoAssistência & ") "
            Else
                wStrErro += "Selecione um ou mais Tipo de Assistência " & vbCrLf
            End If

            If cbTipoServico.SelectedIndex > 0 Then
                pesquisa += " AND M.TipoServico = '" & cbTipoServico.SelectedItem.value & "' "
            ElseIf cbTipoServico.SelectedIndex < 0 Then
                wStrErro += "Preencha corretamente o Tipo de Serviço " & vbCrLf
            End If

            If cbAnimal.Enabled = True Then
                If cbAnimal.SelectedIndex > 0 Then
                    pesquisa += " AND M.Animal = '" & cbAnimal.SelectedItem.value & "' "
                ElseIf cbAnimal.SelectedIndex < 0 Then
                    wStrErro += "Preencha corretamente o Animal " & vbCrLf
                End If
            End If

            If wStrErro = "" Then

                wSQL += _
                " SELECT Matricula = isnull(CAST(Ass.Matricula AS INTEGER),0), TipoAssistencia, " & _
                " Data = CONVERT(VARCHAR(10), M.Data, 103), M.Documento, " & _
                " Tecnico = '0168261', TipoServico = M.TipoServico, " & _
                " Animal = isnull(AN.CodigoCoolan, 0), " & _
                " Numero = '0000000', Ger = '  ', Cabecas = ISNULL(M.Cabecas, 0), " & _
                " isnull(ValorConducao, 0), " & _
                " isnull(ValorMedicamento,0), " & _
                " isnull(ValorServico,0), " & _
                " isnull(ValorEquipamento,0), " & _
                " isnull(ValorBeneficio,0), " & _
                " isnull(ValorOutros,0), " & _
                " Talao = '0000000000', " & _
                " isnull(ValorMaoDeObra, 0), " & _
                " isnull(ValorEverminacao,0), " & _
                " isnull(ValorSemem,0), " & _
                " isnull(ValorVisita,0) " & _
                " FROM Ass_Tecnicos T, Ass_TipoAssistencia A, Ass_TipoServico S, Ass_Associados Ass, " & _
                " Ass_Movimento M  " & _
                " LEFT JOIN Ass_Animais An ON An.Codigo = M.Animal " & _
                " WHERE " & pesquisa & _
                " AND T.Codigo = M.Tecnico " & _
                " AND Ass.Codigo = M.Associado " & _
                " AND A.Codigo = M.TipoAssistencia " & _
                " AND S.Codigo = M.TipoServico " & _
                " AND isnull(M.Data_Hora_Exclusao,'') = '' " & _
                wFiltro & _
                wpesquisaSituacao & _
                wOrdem

                wControle = LerItens(wSQL)
                If wControle < 0 Then
                    objVariaveisGlobais.MostraErro()
                    Return wControle
                ElseIf wControle = 1 Then
                    Return wControle
                End If
            Else
                MsgBox(wStrErro, MsgBoxStyle.Critical, "A Busca Não Foi Realizada")
                Return 1
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
        Return 0
    End Function

    Public Function FazPesquisaParaTxtBRF() As Integer

        Dim wControle As Integer
        Dim pesquisa As String
        Dim wOrdem As String = ""
        Dim wStrErro As String = ""
        Dim wFiltro As String = ""
        Dim wpesquisaSituacao As String = ""
        Dim wSQL As String = "SET DATEFORMAT DMY  "
        Try

            If Not IsDate(txtDataInicio.Text) Or Not IsDate(txtDataFinal.Text) Then
                MsgBox("Informe Corretamente as Datas !")
                Return 1
            End If
            If CDate(txtDataFinal.Text).Year <= "1900" Or CDate(txtDataInicio.Text).Year <= "1900" Then
                MsgBox("Data Início e/ou Data Final não aparentam veracidade !")
                Return 1
            End If
            If CDate(txtDataInicio.Text) > CDate(txtDataFinal.Text) Then
                MsgBox("Data Final deve ser igual ou maior que a Data Inicial !")
                Return 1
            End If

            If rbCanhotos.Checked = True Then
                wFiltro = " AND isnull(M.Documento,0) = 0 AND isnull(M.Canhoto,0) <> 0 "
            ElseIf rbDocumentos.Checked = True Then
                wFiltro = " AND isnull(M.Documento,0) <> 0 AND isnull(M.Canhoto,0) = 0 "
            End If

            'Ordem da Pesquisa
            If rbTecnico.Checked = True Then
                wOrdem = " ORDER BY T.Nome "
            ElseIf rbData.Checked = True Then
                wOrdem = " ORDER BY M.Data "
            ElseIf rbAssistencia.Checked = True Then
                wOrdem = " ORDER BY A.Descricao"
            ElseIf rbServico.Checked = True Then
                wOrdem = " ORDER BY S.Descricao"
            End If

            If rbSituacaoLancados.Checked = True Then
                wpesquisaSituacao = " AND M.Situacao = 'L' "
            ElseIf rbSituacaoEnviados.Checked = True Then
                wpesquisaSituacao = " AND M.Situacao = 'E' "
            ElseIf rbSituacaoCobrados.Checked = True Then
                wpesquisaSituacao = " AND M.Situacao = 'C' "
            ElseIf rbTodos.Checked = True Then
                wpesquisaSituacao = ""
            End If

            DataI1 = CDate(txtDataInicio.Text)
            DataF1 = CDate(txtDataFinal.Text)

            pesquisa = " M.Data BETWEEN '" & DataI1 & "' AND '" & DataF1 & "'"

            If txtCodigo_Associado.Text <> "" Then
                pesquisa += " AND M.Associado = '" & txtCodigo_Associado.Text & "' "
                'ElseIf txtCodigo_Associado.Text = "" Then
                'wStrErro += "Preencha corretamente o Associado " & vbCrLf
            End If

            If cbTecnico.SelectedIndex > 0 Then
                pesquisa += " AND M.Tecnico = '" & cbTecnico.SelectedItem.value & "' "
            ElseIf cbTecnico.SelectedIndex < 0 Then
                wStrErro += "Preencha corretamente o Técnico " & vbCrLf
            End If

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
            If wTipoAssistência <> "" Then
                pesquisa += " AND M.TipoAssistencia IN (" & wTipoAssistência & ") "
            Else
                wStrErro += "Selecione um ou mais Tipo de Assistência " & vbCrLf
            End If

            If cbTipoServico.SelectedIndex > 0 Then
                pesquisa += " AND M.TipoServico = '" & cbTipoServico.SelectedItem.value & "' "
            ElseIf cbTipoServico.SelectedIndex < 0 Then
                wStrErro += "Preencha corretamente o Tipo de Serviço " & vbCrLf
            End If

            If cbAnimal.Enabled = True Then
                If cbAnimal.SelectedIndex > 0 Then
                    pesquisa += " AND M.Animal = '" & cbAnimal.SelectedItem.value & "' "
                ElseIf cbAnimal.SelectedIndex < 0 Then
                    wStrErro += "Preencha corretamente o Animal " & vbCrLf
                End If
            End If

            If wStrErro = "" Then

                wSQL += _
                " SELECT CDPRODUTOR = isnull(CAST(Ass.MatriculaBRF AS INTEGER),0), " & _
                " SPMON = CONVERT(VARCHAR(10), M.Data, 103), NRDOC = M.Documento, " & _
                " VLCONVENIO = isnull(ValorConducao, 0) + " & _
                " isnull(ValorMedicamento,0) + " & _
                " isnull(ValorServico,0) + " & _
                " isnull(ValorEquipamento,0) - " & _
                " isnull(ValorBeneficio,0) + " & _
                " isnull(ValorOutros,0) + " & _
                " isnull(ValorMaoDeObra, 0) + " & _
                " isnull(ValorEverminacao,0) + " & _
                " isnull(ValorSemem,0) + " & _
                " isnull(ValorVisita,0) " & _
                " FROM Ass_Tecnicos T, Ass_TipoAssistencia A, Ass_TipoServico S, Ass_Associados Ass, " & _
                " Ass_Movimento M  " & _
                " LEFT JOIN Ass_Animais An ON An.Codigo = M.Animal " & _
                " WHERE " & pesquisa & _
                " AND T.Codigo = M.Tecnico " & _
                " AND Ass.Codigo = M.Associado " & _
                " AND A.Codigo = M.TipoAssistencia " & _
                " AND S.Codigo = M.TipoServico " & _
                " AND isnull(M.Data_Hora_Exclusao,'') = '' " & _
                wFiltro & _
                wpesquisaSituacao & _
                wOrdem

                wControle = LerItens(wSQL)
                If wControle < 0 Then
                    objVariaveisGlobais.MostraErro()
                    Return wControle
                ElseIf wControle = 1 Then
                    Return wControle
                End If
            Else
                MsgBox(wStrErro, MsgBoxStyle.Critical, "A Busca Não Foi Realizada")
                Return 1
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
        Return 0
    End Function


    Public Function FazPesquisa() As Integer

        Dim wControle As Integer
        Dim pesquisa As String = ""
        Dim pesquisaSituacao As String = ""
        Dim wOrdem As String = ""
        Dim wStrErro As String = ""
        Dim wFiltro As String = ""
        Dim wSituacao As String = ""
        Dim wSQL As String = "SET DATEFORMAT DMY  "
        Try

            If Not IsDate(txtDataInicio.Text) Or Not IsDate(txtDataFinal.Text) Then
                MsgBox("Informe Corretamente as Datas !")
                Return 1
            End If
            If CDate(txtDataFinal.Text).Year <= "1900" Or CDate(txtDataInicio.Text).Year <= "1900" Then
                MsgBox("Data Início e/ou Data Final não aparentam veracidade !")
                Return 1
            End If
            If CDate(txtDataInicio.Text) > CDate(txtDataFinal.Text) Then
                MsgBox("Data Final deve ser igual ou maior que a Data Inicial !")
                Return 1
            End If
            If rbCanhotos.Checked = True Then
                'wFiltro = " AND isnull(M.Documento,0) = 0 AND isnull(M.Canhoto,0) <> 0 "
                wFiltro = " AND isnull(M.Canhoto,0) <> 0 "
            ElseIf rbDocumentos.Checked = True Then
                wFiltro = " AND isnull(M.Documento,0) <> 0 AND isnull(M.Canhoto,0) = 0 "
            End If

            'Ordem da Pesquisa
            If rbTecnico.Checked = True Then
                wOrdem = " ORDER BY T.Nome "
                Dado_Nome = "Técnico: "
            ElseIf rbData.Checked = True Then
                wOrdem = " ORDER BY M.Data "
                Dado_Nome = "Data: "
            ElseIf rbAssistencia.Checked = True Then
                wOrdem = " ORDER BY A.Descricao"
                Dado_Nome = "Tipo Assist.: "
            ElseIf rbServico.Checked = True Then
                wOrdem = " ORDER BY S.Descricao"
                Dado_Nome = "Tipo Serviço: "
            End If

            If rbSituacaoLancados.Checked = True Then
                pesquisaSituacao = " AND M.Situacao = 'L' "
            ElseIf rbSituacaoEnviados.Checked = True Then
                pesquisaSituacao = " AND M.Situacao = 'E' "
            ElseIf rbSituacaoCobrados.Checked = True Then
                pesquisaSituacao = " AND M.Situacao = 'C' "
            ElseIf rbTodos.Checked = True Then
                pesquisaSituacao = ""
            End If

            DataI1 = CDate(txtDataInicio.Text)
            DataF1 = CDate(txtDataFinal.Text)

            pesquisa = " M.Data between '" & DataI1 & "' and '" & DataF1 & "'"

            If txtCodigo_Associado.Text <> "" Then
                pesquisa += " AND M.Associado = '" & txtCodigo_Associado.Text & "' "
            End If

            If cbTecnico.SelectedIndex > 0 Then
                pesquisa += " AND M.Tecnico = '" & cbTecnico.SelectedItem.value & "' "
            ElseIf cbTecnico.SelectedIndex < 0 Then
                wStrErro += "Preencha corretamente o Técnico " & vbCrLf
            End If

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
            If wTipoAssistência <> "" Then
                pesquisa += " AND M.TipoAssistencia IN (" & wTipoAssistência & ") "
            Else
                wStrErro += "Selecione um ou mais Tipo de Assistência " & vbCrLf
            End If

            If cbTipoServico.SelectedIndex > 0 Then
                pesquisa += " AND M.TipoServico = '" & cbTipoServico.SelectedItem.value & "' "
            ElseIf cbTipoServico.SelectedIndex < 0 Then
                wStrErro += "Preencha corretamente o Tipo de Serviço " & vbCrLf
            End If

            If cbAnimal.Enabled = True Then
                If cbAnimal.SelectedIndex > 0 Then
                    pesquisa += " AND M.Animal = '" & cbAnimal.SelectedItem.value & "' "
                ElseIf cbAnimal.SelectedIndex < 0 Then
                    wStrErro += "Preencha corretamente o Animal " & vbCrLf
                End If
            End If

            If wStrErro = "" Then

                wSQL += _
                " SELECT MData = M.Data, isnull(Ass.Matricula,''), Ass.Nome, isnull(Documento,0), " & _
                " isnull(T.CRMV,0), TipoAssistencia, isnull(Cabecas,0), " & _
                " isnull(ValorMaodeObra,0), isnull(ValorEverminacao,0)," & _
                " isnull(ValorVisita,0), isnull(ValorConducao,0), isnull(ValorMedicamento,0)," & _
                " isnull(ValorServico,0), isnull(ValorEquipamento,0), isnull(ValorSemem,0), " & _
                " isnull(NTouro,0), isnull(ValorBeneficio,0), isnull(ValorOutros,0), " & _
                " Total = isnull(ValorConducao,0) + isnull(ValorMedicamento,0) + isnull(ValorServico,0) + isnull(ValorEquipamento,0) + " & _
                " isnull(ValorSemem,0) + isnull(ValorEverminacao,0) + isnull(ValorOutros,0) + isnull(ValorMaoDeObra,0) + isnull(ValorVisita,0),  " & _
                " TNome = T.Nome, ADescricao = A.Descricao, SDescricao = S.Descricao " & _
                " FROM Ass_Tecnicos T, Ass_TipoAssistencia A, Ass_TipoServico S, Ass_Associados Ass, Ass_Movimento M  " & _
                " LEFT JOIN Ass_Animais An ON An.Codigo = M.Animal " & _
                " WHERE " & pesquisa & _
                pesquisaSituacao & _
                " AND T.Codigo = M.Tecnico " & _
                " AND Ass.Codigo = M.Associado " & _
                " AND A.Codigo = M.TipoAssistencia " & _
                " AND S.Codigo = M.TipoServico " & _
                " AND isnull(M.Data_Hora_Exclusao,'') = '' " & _
                wFiltro & _
                wOrdem

                wControle = LerItens(wSQL)
                If wControle < 0 Then
                    objVariaveisGlobais.MostraErro()
                    Return wControle
                ElseIf wControle = 1 Then
                    Return wControle
                End If
            Else
                MsgBox(wStrErro, MsgBoxStyle.Critical, "A Busca Não Foi Realizada")
                Return 1
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
            tf = SetPaperSize(cbPapel.SelectedItem.Value, PrintDocument1)
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
            tf = SetPaperSize(cbPapel.SelectedItem.Value, PrintDocument1)
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
            SomaMaoObra = 0
            SomaEverminacao = 0
            SomaVisita = 0
            SomaConducao = 0
            SomaMedicamento = 0
            SomaServico = 0
            SomaEquipamento = 0
            SomaBeneficio = 0
            SomaSemem = 0
            SomaOutros = 0 
            pagina = 0
            Dado_Antigo = ""
            '
            TotalMaoObra = 0
            TotalEverminacao = 0
            TotalVisita = 0
            TotalConducao = 0
            TotalMedicamento = 0
            TotalServico = 0
            TotalEquipamento = 0
            TotalBeneficio = 0
            TotalSemem = 0
            TotalOutros = 0
            TotalGeral = 0
        End If
        If wDataSetItens.Tables.Count > 0 Then
            TotalRecords = wDataSetItens.Tables(0).Rows.Count.ToString()
        End If
        Dim paginain As Integer = e.PageSettings.PrinterSettings.FromPage
        Dim paginafi As Integer = e.PageSettings.PrinterSettings.ToPage
        While pagina + 1 < paginain
            sdb = Brushes.White
            spen = Pens.White
            PrintDocument2_PrintPage(sender, e)
        End While
        sdb = Brushes.Black
        spen = Pens.Black
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

        For i = ContadorRegistro To TotalRecords - 1
            If cbResumido.Checked = False Then
                yPos += 15
            End If
            If yPos > wAlturaPapel - 100 Then
                e.HasMorePages = True
                ContadorRegistro = i
                Exit Sub
            End If

            Data = wDataSetItens.Tables(0).Rows(i)(0)
            Matricula_Associado = wDataSetItens.Tables(0).Rows(i)(1)
            Nome_Associado = wDataSetItens.Tables(0).Rows(i)(2)
            Documento = wDataSetItens.Tables(0).Rows(i)(3)
            Tecnico = wDataSetItens.Tables(0).Rows(i)(4)
            TipoAss = wDataSetItens.Tables(0).Rows(i)(5)
            Cabecas = wDataSetItens.Tables(0).Rows(i)(6)
            MaoDeObra = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(7)), 0, wDataSetItens.Tables(0).Rows(i)(7))
            Everminacao = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(8)), 0, wDataSetItens.Tables(0).Rows(i)(8))
            Visita = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(9)), 0, wDataSetItens.Tables(0).Rows(i)(9))
            Conducao = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(10)), 0, wDataSetItens.Tables(0).Rows(i)(10))
            Medicamento = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(11)), 0, wDataSetItens.Tables(0).Rows(i)(11))
            Servico = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(12)), 0, wDataSetItens.Tables(0).Rows(i)(12))
            Equipamento = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(13)), 0, wDataSetItens.Tables(0).Rows(i)(13))
            Semem = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(14)), 0, wDataSetItens.Tables(0).Rows(i)(14))
            NTouro = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(15)), 0, wDataSetItens.Tables(0).Rows(i)(15))
            Beneficio = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(16)), 0, wDataSetItens.Tables(0).Rows(i)(16))
            Outros = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(17)), 0, wDataSetItens.Tables(0).Rows(i)(17))
            Total = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(18)), 0, wDataSetItens.Tables(0).Rows(i)(18))

            If rbData.Checked = True Then
                Dado_Novo = wDataSetItens.Tables(0).Rows(i)(0)
            ElseIf rbTecnico.Checked = True Then
                Dado_Novo = wDataSetItens.Tables(0).Rows(i)(19)
            ElseIf rbAssistencia.Checked = True Then
                Dado_Novo = wDataSetItens.Tables(0).Rows(i)(20)
            ElseIf rbServico.Checked = True Then
                Dado_Novo = wDataSetItens.Tables(0).Rows(i)(21)
            End If

            If Dado_Novo <> Dado_Antigo Then
                ImprimeTotal_Dado(e)
                yPos += 20
                e.Graphics.DrawString(Dado_Nome & Dado_Novo, printFontB, sdb, 10, yPos)
                yPos += 15
                Dado_Antigo = Dado_Novo
            End If

            If cbResumido.Checked = False Then
                'e.Graphics.DrawString(Format(Data.Day, "00") & "/" & Format(Data.Month, "00") & "/" & Format(Data.Year, "00"), printFont, sdb, 10, yPos)
                e.Graphics.DrawString((Data.ToString & Space(10)).Replace("/20", "/"), printFont, sdb, 10, yPos)
                e.Graphics.DrawString(Matricula_Associado & " " & (Nome_Associado & Space(16)).Substring(0, 16), printFont, sdb, 70, yPos)
                e.Graphics.DrawString(Documento, printFont, sdb, 290, yPos, dFrl)
                e.Graphics.DrawString(Mid(Tecnico, 1, 7), printFont, sdb, 340, yPos, dFrl)
                e.Graphics.DrawString(TipoAss, printFont, sdb, 370, yPos, dFrl)
                e.Graphics.DrawString(Cabecas, printFont, sdb, 400, yPos, dFrl)
                e.Graphics.DrawString(Format(MaoDeObra, "#,###,##0.00"), printFont, sdb, 460, yPos, dFrl)
                e.Graphics.DrawString(Format(Everminacao, "#,###,##0.00"), printFont, sdb, 520, yPos, dFrl)
                e.Graphics.DrawString(Format(Visita, "#,###,##0.00"), printFont, sdb, 580, yPos, dFrl)
                e.Graphics.DrawString(Format(Conducao, "#,###,##0.00"), printFont, sdb, 650, yPos, dFrl)
                e.Graphics.DrawString(Format(Medicamento, "#,###,##0.00"), printFont, sdb, 720, yPos, dFrl)
                e.Graphics.DrawString(Format(Servico, "#,###,##0.00"), printFont, sdb, 790, yPos, dFrl)
                e.Graphics.DrawString(Format(Equipamento, "#,###,##0.00"), printFont, sdb, 850, yPos, dFrl)
                e.Graphics.DrawString(Format(Semem, "#,###,##0.00"), printFont, sdb, 910, yPos, dFrl)
                e.Graphics.DrawString(NTouro, printFont, sdb, 960, yPos, dFrl)
                e.Graphics.DrawString(Format(Beneficio, "#,###,##0.00"), printFont, sdb, 1020, yPos, dFrl)
                e.Graphics.DrawString(Format(Outros, "#,###,##0.00"), printFont, sdb, 1100, yPos, dFrl)
                'e.Graphics.DrawString(Format(Total, "#,###,##0.00"), printFont, sdb, 1100, yPos, dFrl)
            End If

            SomaMaoObra += MaoDeObra
            SomaEverminacao += Everminacao
            SomaVisita += Visita
            SomaConducao += Conducao
            SomaMedicamento += Medicamento
            SomaServico += Servico
            SomaEquipamento += Equipamento
            SomaBeneficio += Beneficio
            SomaSemem += Semem
            SomaOutros += Outros
            '
            TotalMaoObra += MaoDeObra
            TotalEverminacao += Everminacao
            TotalVisita += Visita
            TotalConducao += Conducao
            TotalMedicamento += Medicamento
            TotalServico += Servico
            TotalEquipamento += Equipamento
            TotalBeneficio += Beneficio
            TotalSemem += Semem
            TotalOutros += Outros

        Next

        yPos += 15
        If yPos > wAlturaPapel - 100 Then
            e.HasMorePages = True
            ContadorRegistro = i
            Exit Sub
        End If

        ImprimeTotal_Dado(e)

        ImprimeTotalGeral(e)
        mpreview = False

    End Sub

    Private Sub ImprimeTotal_Dado(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        If SomaMaoObra <> 0 OrElse SomaEverminacao <> 0 OrElse SomaVisita <> 0 OrElse SomaConducao <> 0 OrElse _
        SomaMedicamento <> 0 OrElse SomaServico <> 0 OrElse SomaEquipamento <> 0 OrElse SomaSemem <> 0 OrElse _
        SomaBeneficio <> 0 OrElse SomaOutros <> 0 Then
            e.Graphics.DrawLine(spen, 10, yPos, 1100, yPos)
            yPos += 5
            Dim xStr As String = "Soma " & Dado_Antigo & "_"
            TotalGeral = SomaMaoObra + SomaEverminacao + SomaVisita + SomaConducao + SomaMedicamento + _
                SomaServico + SomaEquipamento + SomaSemem + SomaOutros
            xStr &= "R$:" & Format(TotalGeral, "#####,##0.00")
            e.Graphics.DrawString(xStr, printFont25B, sdb, 10, yPos)
            e.Graphics.DrawString(Format(SomaMaoObra, "#,###,##0.00"), printFont25B, sdb, 460, yPos, dFrl)
            e.Graphics.DrawString(Format(SomaEverminacao, "#,###,##0.00"), printFont25B, sdb, 520, yPos, dFrl)
            e.Graphics.DrawString(Format(SomaVisita, "#,###,##0.00"), printFont25B, sdb, 580, yPos, dFrl)
            e.Graphics.DrawString(Format(SomaConducao, "#,###,##0.00"), printFont25B, sdb, 650, yPos, dFrl)
            e.Graphics.DrawString(Format(SomaMedicamento, "#,###,##0.00"), printFont25B, sdb, 720, yPos, dFrl)
            e.Graphics.DrawString(Format(SomaServico, "#,###,##0.00"), printFont25B, sdb, 790, yPos, dFrl)
            e.Graphics.DrawString(Format(SomaEquipamento, "#,###,##0.00"), printFont25B, sdb, 850, yPos, dFrl)
            e.Graphics.DrawString(Format(SomaSemem, "#,###,##0.00"), printFont25B, sdb, 910, yPos, dFrl)
            e.Graphics.DrawString(Format(SomaBeneficio, "#,###,##0.00"), printFont25B, sdb, 1020, yPos, dFrl)
            e.Graphics.DrawString(Format(SomaOutros, "#,###,##0.00"), printFont25B, sdb, 1100, yPos, dFrl)
            yPos += 15
            SomaMaoObra = 0
            SomaEverminacao = 0
            SomaVisita = 0
            SomaConducao = 0
            SomaMedicamento = 0
            SomaServico = 0
            SomaEquipamento = 0
            SomaSemem = 0
            SomaBeneficio = 0
            SomaOutros = 0
        End If
    End Sub
    Private Sub ImprimeTotalGeral(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        yPos += 5
        Dim xStr As String = "Total Geral "
        TotalGeral = TotalMaoObra + TotalEverminacao + TotalVisita + TotalConducao + TotalMedicamento + _
            TotalServico + TotalEquipamento + TotalSemem + TotalOutros
        xStr &= TotalRecords.ToString & " Regs_R$:" & Format(TotalGeral, "#####,##0.00")
        e.Graphics.DrawString(xStr, printFont25B, sdb, 10, yPos)

        e.Graphics.DrawString(Format(TotalMaoObra, "#,###,##0.00"), printFont25B, sdb, 460, yPos, dFrl)
        e.Graphics.DrawString(Format(TotalEverminacao, "#,###,##0.00"), printFont25B, sdb, 520, yPos, dFrl)
        e.Graphics.DrawString(Format(TotalVisita, "#,###,##0.00"), printFont25B, sdb, 580, yPos, dFrl)
        e.Graphics.DrawString(Format(TotalConducao, "#,###,##0.00"), printFont25B, sdb, 650, yPos, dFrl)
        e.Graphics.DrawString(Format(TotalMedicamento, "#,###,##0.00"), printFont25B, sdb, 720, yPos, dFrl)
        e.Graphics.DrawString(Format(TotalServico, "#,###,##0.00"), printFont25B, sdb, 790, yPos, dFrl)
        e.Graphics.DrawString(Format(TotalEquipamento, "#,###,##0.00"), printFont25B, sdb, 850, yPos, dFrl)
        e.Graphics.DrawString(Format(TotalSemem, "#,###,##0.00"), printFont25B, sdb, 910, yPos, dFrl)
        e.Graphics.DrawString(Format(TotalBeneficio, "#,###,##0.00"), printFont25B, sdb, 1020, yPos, dFrl)
        e.Graphics.DrawString(Format(TotalOutros, "#,###,##0.00"), printFont25B, sdb, 1100, yPos, dFrl)
        Dado_Antigo = ""

    End Sub

    Private Sub MontaCabecalho(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.DrawString("RELATÓRIO MOVIMENTOS " & "DE " & txtDataInicio.Text & " A " & txtDataFinal.Text, _
            printFontC, sdb, 550, 10, dFac)

        e.Graphics.DrawString("Folha: " & pagina, printFont, sdb, 1100, 15, dFrl)
        e.Graphics.DrawString("Dt/Hr Emitido:" & ConverteDataHoraParaString(Date.Now) & _
            Space(2) & VariaveisGlobais.gLoginUsuario, _
            printFont, Brushes.Black, 1100, 28, dFrl)

        yPos = 28

        Dim xTipoAssistencia As String = ""
        For i As Integer = 0 To clTipoAssistencia.Items.Count - 1
            If clTipoAssistencia.GetItemChecked(i) Then
                If xTipoAssistencia = "" Then
                    xTipoAssistencia += "" & clTipoAssistencia.Items.Item(i).ToString
                Else
                    xTipoAssistencia += "," & clTipoAssistencia.Items.Item(i).ToString
                End If
            End If
        Next
        xTipoAssistencia = "Tipo Assistências: " & xTipoAssistencia

        Do Until xTipoAssistencia = ""
            yPos += 12
            e.Graphics.DrawString((xTipoAssistencia & Space(180)).Substring(0, 180), printFont25, sdb, 10, yPos)
            If xTipoAssistencia.Length > 180 Then
                xTipoAssistencia = xTipoAssistencia.Substring(180, xTipoAssistencia.Length - 180)
            Else
                xTipoAssistencia = ""
            End If
        Loop

        If txtCodigo_Associado.Text <> "" Then
            yPos += 12
            e.Graphics.DrawString("Associado: " & txtCodigo_Associado.Text, printFont, sdb, 10, yPos)
        End If
        If cbTecnico.SelectedIndex > 0 Then
            yPos += 12
            e.Graphics.DrawString("Técnico: " & cbTecnico.Text, printFont, sdb, 10, yPos)
        End If
        If cbTipoServico.SelectedIndex > 0 Then
            yPos += 12
            e.Graphics.DrawString("Serviço: " & cbTipoServico.Text, printFont, sdb, 10, yPos)
        End If
        If cbAnimal.SelectedIndex > 0 Then
            yPos += 12
            e.Graphics.DrawString("Animal : " & cbAnimal.Text, printFont, sdb, 410, yPos)
        End If
        yPos += 12
        e.Graphics.DrawString("Data", printFontB, sdb, 10, yPos)
        e.Graphics.DrawString("Associado", printFontB, sdb, 70, yPos)
        e.Graphics.DrawString("Documento", printFontB, sdb, 290, yPos, dFrl)
        e.Graphics.DrawString("Tecnic", printFontB, sdb, 340, yPos, dFrl)
        e.Graphics.DrawString("TA", printFontB, sdb, 370, yPos, dFrl)
        e.Graphics.DrawString("Cab", printFontB, sdb, 400, yPos, dFrl)
        e.Graphics.DrawString("MaoObra", printFontB, sdb, 460, yPos, dFrl)
        e.Graphics.DrawString("Everm", printFontB, sdb, 520, yPos, dFrl)
        e.Graphics.DrawString("Visita", printFontB, sdb, 580, yPos, dFrl)
        e.Graphics.DrawString("Conduç", printFontB, sdb, 650, yPos, dFrl)
        e.Graphics.DrawString(".Medic", printFontB, sdb, 720, yPos, dFrl)
        e.Graphics.DrawString("Serviço", printFontB, sdb, 790, yPos, dFrl)
        e.Graphics.DrawString(".Equip", printFontB, sdb, 850, yPos, dFrl)
        e.Graphics.DrawString("Semen", printFontB, sdb, 910, yPos, dFrl)
        e.Graphics.DrawString("NTouro", printFontB, sdb, 960, yPos, dFrl)
        e.Graphics.DrawString("Benef", printFontB, sdb, 1020, yPos, dFrl)
        e.Graphics.DrawString("Outros", printFontB, sdb, 1100, yPos, dFrl)
        'e.Graphics.DrawString("Total", printFontB, sdb, 1100, yPos, dFrl)
        yPos += 18
        e.Graphics.DrawLine(spen, 10, yPos, 1100, yPos)

    End Sub

    Private Sub cbImpressoras_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbImpressoras.SelectedIndexChanged
        GetPapers(cbPapel, PrintDocument1)
        PrintDocument1.DefaultPageSettings.PrinterSettings.PrinterName = cbImpressoras.SelectedItem.Value
        PrintDocument1.DefaultPageSettings.Landscape = True
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

    Public Function LerItensAgrupamento(ByVal pSQL As String) As Integer

        Dim wDataAdapter As SqlDataAdapter = New SqlDataAdapter
        wDataSetItensAgrupamento = New DataSet
        Dim wControle As Integer


        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle < 0 Then
                Return wControle
            End If
            ' Preenche o DataSet com o resultado do SQL

            wComando.CommandText = pSQL
            wDataAdapter.SelectCommand = wComando
            wDataAdapter.Fill(wDataSetItensAgrupamento, "TABLE")
            wDataAdapter.Dispose()

            If wDataSetItensAgrupamento.Tables(0).Rows.Count = Nothing Then
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

    Private Sub btGeraArquivo_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGeraArquivo.Click

        Dim wControle As Integer
        wControle = FazPesquisaAgrupamento()
        If wControle <> 0 Then
            Exit Sub
        End If
        For f As Integer = 0 To wDataSetItensAgrupamento.Tables(0).Rows.Count.ToString() - 1
            wAgrupamentoAss = IIf(IsDBNull(wDataSetItensAgrupamento.Tables(0).Rows(f)(0)), "", wDataSetItensAgrupamento.Tables(0).Rows(f)(0))
            wAgrupamentoValorTotal = IIf(IsDBNull(wDataSetItensAgrupamento.Tables(0).Rows(f)(1)), 0, wDataSetItensAgrupamento.Tables(0).Rows(f)(1))

            wAgrupamentoString += wAgrupamentoAss & Space(5) & "Total R$ " & _
            ConverteDecString(wAgrupamentoValorTotal) & vbCrLf
        Next

        wControle = FazPesquisaParaTxt()
        If wControle <> 0 Then
            Exit Sub
        End If

        Dim saveFileDialog1 As New SaveFileDialog
        With saveFileDialog1
            .Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Selecione um Local Para Salvar o Arquivo "
            .FileName = "AssMox_" & CStr(ConverteDataParaString(txtDataInicio.Text)).Replace("/", "").Remove(4, 2) & "_" & CStr(ConverteDataParaString(txtDataFinal.Text)).Replace("/", "").Remove(4, 2) & ".txt"
        End With

        'saveFileDialog1.ShowDialog()

        If saveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim file_Name As String = saveFileDialog1.FileName

            Dim SW As New IO.StreamWriter(file_Name, False)
            Dim wDataInicio As String = "01/" & DatePart(DateInterval.Month, CDate(txtDataFinal.Text)) & _
                "/" & DatePart(DateInterval.Year, CDate(txtDataFinal.Text))
            Dim xx1 As String = ""

            TotalRecords = 0
            If wDataSetItens.Tables.Count > 0 Then
                TotalRecords = wDataSetItens.Tables(0).Rows.Count.ToString()
            End If
            ContadorRegistro = 0
            pagina = 0
            dados = 0

            'Variaveis
            Dim wTEqui As Decimal = 0
            Dim wTLeite As Decimal = 0
            Dim wTEverminacao As Decimal = 0
            Dim wTSuiSer As Decimal = 0
            Dim wTSuiCor As Decimal = 0
            Dim wTLote As Decimal = 0
            Dim wCorridasLeite As Decimal = 0
            Dim wCorridasOutros As Decimal = 0
            Dim wBeneficio As Decimal = 0
            Dim wConvLeite As Integer = 0
            Dim wConvOutros As Integer = 0

            Dim yConducao As Decimal = 0
            Dim yMedicamento As Decimal = 0
            Dim yServico As Decimal = 0
            Dim yEquipamento As Decimal = 0
            Dim yOutros As Decimal = 0
            Dim yBeneficio As Decimal = 0
            Dim wGeraLinha As Boolean = False
            Dim i As Integer
            For i = ContadorRegistro To TotalRecords - 1

                Matricula = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(0)), 0, wDataSetItens.Tables(0).Rows(i)(0))
                If Matricula.ToString.Length < 2 Then
                    Matricula = 168261
                Else
                    Matricula = Matricula.ToString.Substring(0, Matricula.ToString.Length - 1)
                    'Matricula = Matricula.ToString
                End If
                TipoAss = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(1)), "", wDataSetItens.Tables(0).Rows(i)(1))
                Data = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(2)), 0, wDataSetItens.Tables(0).Rows(i)(2))
                Documento = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(3)), 0, wDataSetItens.Tables(0).Rows(i)(3))
                Tecnico = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(4)), 0, wDataSetItens.Tables(0).Rows(i)(4))
                TipoServico = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(5)), 0, wDataSetItens.Tables(0).Rows(i)(5))
                Animal = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(6)), 0, wDataSetItens.Tables(0).Rows(i)(6))
                Numero = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(7)), 0, wDataSetItens.Tables(0).Rows(i)(7))
                Ger = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(8)), 0, wDataSetItens.Tables(0).Rows(i)(8))
                Nro = "0000"
                Conducao = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(10)), 0, wDataSetItens.Tables(0).Rows(i)(10))
                Medicamento = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(11)), 0, wDataSetItens.Tables(0).Rows(i)(11))
                Servico = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(12)), 0, wDataSetItens.Tables(0).Rows(i)(12))
                Equipamento = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(13)), 0, wDataSetItens.Tables(0).Rows(i)(13))
                Beneficio = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(14)), 0, wDataSetItens.Tables(0).Rows(i)(14))
                Outros = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(15)), 0, wDataSetItens.Tables(0).Rows(i)(15))
                Tpg = "0"
                Talao = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(16)), 0, wDataSetItens.Tables(0).Rows(i)(16))
                MaoDeObra = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(17)), 0, wDataSetItens.Tables(0).Rows(i)(17))
                Everminacao = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(18)), 0, wDataSetItens.Tables(0).Rows(i)(18))
                Semem = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(19)), 0, wDataSetItens.Tables(0).Rows(i)(19))
                Visita = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(20)), 0, wDataSetItens.Tables(0).Rows(i)(20))

                yConducao = 0
                yMedicamento = 0
                yServico = 0
                yEquipamento = 0
                yOutros = 0
                wGeraLinha = True
                'Soma dos Valores
                Talao = SoNumero(Talao)
                If Not IsNumeric(Talao) OrElse TipoServico = 10 OrElse _
                    (Animal <> "2" AndAlso Animal <> "3" AndAlso Animal <> "8") Then
                    Talao = "0000000000"
                End If

                If (MaoDeObra + Everminacao) > 0 Then
                    TipoAssCoolan = "12"
                Else
                    TipoAssCoolan = "01"
                End If

                yBeneficio = Beneficio
                If TipoServico = "11" Then 'Suino Integrado
                    yConducao = Conducao
                    yMedicamento = Medicamento + Everminacao + Semem + Outros
                    yServico = MaoDeObra + Visita + Servico
                    yEquipamento = Equipamento
                    wTLeite += yMedicamento
                    wTSuiCor += yConducao
                    wTSuiSer += yServico
                    wTEqui += yEquipamento
                ElseIf TipoServico = "10" Then 'Lote Contratado
                    yConducao = Conducao
                    yMedicamento = Medicamento + MaoDeObra + Visita + Servico + Everminacao + Semem + Equipamento + Outros
                    wTSuiCor += yConducao
                    wTLote += yMedicamento
                ElseIf TipoServico = "8" OrElse TipoServico = "9" Then 'Inseminação 8-Tec 9-Vet
                    yConducao = Conducao
                    yMedicamento = Medicamento + Everminacao + Semem + Equipamento + Outros
                    yServico = MaoDeObra + Visita + Servico
                    wTLeite += yConducao
                    wTLeite += yMedicamento
                    wTLeite += yServico
                Else
                    yConducao = Conducao
                    yMedicamento = Medicamento + Everminacao + Outros + Semem
                    yServico = MaoDeObra + Visita + Servico
                    yEquipamento = Equipamento
                    If TipoAssCoolan = "01" Then
                        wTLeite += yConducao
                        wTLeite += yMedicamento
                        wTLeite += yServico
                        wTEqui += yEquipamento
                    Else
                        wTEverminacao += yConducao + yMedicamento + yServico + yEquipamento
                    End If
                    If CLng(Talao) > 0 Then
                        wCorridasLeite += yConducao
                        wConvLeite += 1
                    End If
                End If
                wBeneficio += yBeneficio

                If TipoServico = 11 Then : TipoAss = 14
                ElseIf TipoServico = 10 Then : TipoAss = 12
                ElseIf TipoServico = 9 Then : TipoAss = 10 : Animal = 51
                ElseIf TipoServico = 8 Then : TipoAss = 10 : Animal = 50
                Else
                    TipoAss = 10
                End If

                If wGeraLinha = True Then
                    If CDate(Data) < CDate(wDataInicio) Then
                        Data = wDataInicio
                    End If
                    'Dados Fixos e Ajustes Formato---------------------------------------
                    Data = CStr(ConverteDataParaString(Data)).Replace("/", "").Remove(4, 2)
                    Data = Data.Substring(4, 2) & Data.Substring(2, 2) & Data.Substring(0, 2)
                    '--------------------------------------------------------------------
                    xx1 += _
                    Format(CInt(Matricula), "0000000") & _
                    TipoAssCoolan & _
                    Data & _
                    Format(CInt(Documento), "0000000") & _
                    Tecnico & _
                    Format(CInt(TipoAss), "00") & _
                    Format(CInt(Animal), "00") & _
                    Numero & _
                    Ger & _
                    Nro & _
                    Format(CLng(ConverteDecimalPara2Dec(yConducao).Replace(".", "")), "0000000000000") & _
                    Format(CLng(ConverteDecimalPara2Dec(yMedicamento).Replace(".", "")), "000000000000000") & _
                    Format(CLng(ConverteDecimalPara2Dec(yServico).Replace(".", "")), "000000000000000") & _
                    Format(CLng(ConverteDecimalPara2Dec(yEquipamento).Replace(".", "")), "000000000000000") & _
                    Format(CLng(ConverteDecimalPara2Dec(yBeneficio).Replace(".", "")), "000000000000000") & _
                    Tpg & _
                    Talao.Substring(3, 7)
                    xx1 += vbCrLf
                End If
            Next
            SW.WriteLine(xx1)
            SW.Close()
            Dim xTotais As String = ""
            xTotais += "Leite a Pagar   : " & wTLeite & vbCrLf
            xTotais += "Lote Contratado : " & wTLote & " Med.Serv.Lote(12)" & vbCrLf
            xTotais += "Equipamentos    : " & wTEqui & vbCrLf
            xTotais += "Suino Int.Serv. : " & wTSuiSer & " Serviços Integrado (14)" & vbCrLf
            xTotais += "Corridas Suinos : " & wTSuiCor & " Corrida Lote e Integrado (12-14)" & vbCrLf
            xTotais += "Everminacao     : " & wTEverminacao
            xTotais += vbCrLf
            xTotais += "Convênio Coolan : " & wCorridasLeite & vbCrLf
            xTotais += "Convênio Outros : " & wCorridasOutros & vbCrLf
            xTotais += "Benefício Coolan: " & wBeneficio & vbCrLf
            xTotais += "Qtd.Conv.Coolan : " & wConvLeite & vbCrLf
            xTotais += "Qtd.Conv.Outros : " & wConvOutros & vbCrLf
            xTotais += vbCrLf
            xTotais += wAgrupamentoString
            xTotais += vbCrLf
            xTotais += "Arquivo salvo com sucesso! "

            wAgrupamentoString = ""
            wAgrupamentoAss = ""
            wAgrupamentoValorTotal = 0

            MsgBox(xTotais)
        End If
    End Sub

    Private Sub btGeraExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGeraExcel.Click
        Try
            Dim wControle As Integer
            wControle = FazPesquisa()
            If wControle <> 0 Then
                Exit Sub
            End If

            Dim wTotal As Decimal = 0

            With SaveFileDialog1
                .Filter = "Text files (*.xls)|*.xls"
                .FilterIndex = 1
                .Title = "Selecione um Local Para Salvar o Arquivo "
                .FileName = "AssMox_" & CStr(ConverteDataParaString(txtDataInicio.Text)).Replace("/", "").Remove(4, 2) & "_" & CStr(ConverteDataParaString(txtDataFinal.Text)).Replace("/", "").Remove(4, 2) & ".xls"
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

                    With oSheet.Range("A1", "A3")
                        .Font.Size = 10
                        .Interior.ColorIndex = 6
                        .Font.Bold = True
                    End With
                    oSheet.Cells(1, 1).Value = "Nome da Conveniada:"
                    oSheet.Cells(2, 1).Value = "Codigo da Conveniada: "
                    oSheet.Cells(3, 1).Value = "Codigo do Convenio:"

                    'oSheet.Cells(5, 1).Value = "Tecnico: " & cbTecnico.Text
                    'oSheet.Cells(4, 1).Value = "Servico: " & cbTipoServico.Text
                    'oSheet.Cells(3, 5).Value = "Assist: : " & cbTipoAssistencia.Text
                    'oSheet.Cells(4, 5).Value = "Animal: " & cbAnimal.Text

                    With oSheet.Range("A5", "E5")
                        .Font.Size = 10
                        .Interior.ColorIndex = 8
                        .Font.Bold = True
                    End With
                    oSheet.Cells(5, 1).Value = "COD. PRODUTOR" 'A
                    oSheet.Cells(5, 2).Value = "NOME" 'B
                    'oSheet.Cells(5, 3).Value = "." 'C
                    oSheet.Cells(5, 3).Value = "VALOR DA COMPRA" 'C
                    oSheet.Cells(5, 4).Value = "Nº DOCUMENTO" 'D
                    'oSheet.Cells(5, 6).Value = "." 'F
                    'oSheet.Cells(5, 8).Value = "." 'G
                    oSheet.Cells(5, 5).Value = "DATA" 'E

                    oXL.Workbooks(1).Worksheets(1).Range("A:A").ColumnWidth = 20
                    oXL.Workbooks(1).Worksheets(1).Range("B:B").ColumnWidth = 20
                    oXL.Workbooks(1).Worksheets(1).Range("C:C").ColumnWidth = 20
                    oXL.Workbooks(1).Worksheets(1).Range("D:D").ColumnWidth = 20
                    oXL.Workbooks(1).Worksheets(1).Range("E:E").ColumnWidth = 20

                    Dim count As Integer = 5
                    Dim i As Integer
                    For i = 0 To wDataSetItens.Tables(0).Rows.Count - 1
                        count += 1

                        Data = wDataSetItens.Tables(0).Rows(i)(0)
                        Matricula_Associado = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(1)), "", wDataSetItens.Tables(0).Rows(i)(1))
                        Nome_Associado = wDataSetItens.Tables(0).Rows(i)(2)
                        Documento = wDataSetItens.Tables(0).Rows(i)(3)
                        'TipoAssistencia = wDataSetItens.Tables(0).Rows(i)(4)
                        'Conducao = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(5)), 0, wDataSetItens.Tables(0).Rows(i)(5))
                        'Medicamento = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(6)), 0, wDataSetItens.Tables(0).Rows(i)(6))
                        'Servico = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(7)), 0, wDataSetItens.Tables(0).Rows(i)(7))
                        'Equipamento = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(8)), 0, wDataSetItens.Tables(0).Rows(i)(8))
                        'Beneficio = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(9)), 0, wDataSetItens.Tables(0).Rows(i)(9))
                        'Semem = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(10)), 0, wDataSetItens.Tables(0).Rows(i)(10))
                        'Outros = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(11)), 0, wDataSetItens.Tables(0).Rows(i)(11))
                        Total = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(18)), 0, wDataSetItens.Tables(0).Rows(i)(18))

                        oSheet.Cells(count, 1).Value = Matricula_Associado
                        oSheet.Cells(count, 2).Value = Nome_Associado
                        oSheet.Cells(count, 3).Value = Format(CDec(Total), "#,###,##0.00")
                        oSheet.Cells(count, 4).Value = Documento
                        oSheet.Cells(count, 5).Value = Data
                        'oSheet.Cells(count, 5).Value = Format(CDec(Conducao), "#,###,##0.00")
                        'oSheet.Cells(count, 6).Value = Format(CDec(Medicamento), "#,###,##0.00")
                        'oSheet.Cells(count, 7).Value = Format(CDec(Servico), "#,###,##0.00")
                        'oSheet.Cells(count, 8).Value = Format(CDec(Equipamento), "#,###,##0.00")
                        'oSheet.Cells(count, 9).Value = Format(CDec(Beneficio), "#,###,##0.00")
                        'oSheet.Cells(count, 10).Value = Format(CDec(Outros), "#,###,##0.00")
                        'oSheet.Cells(count, 11).Value = Format(CDec(Semem), "#,###,##0.00")
                        'oSheet.Cells(count, 12).Value = Format(CDec(Total), "#,###,##0.00")

                        wTotal += Total

                    Next
                    count += 2
                   
                    'oSheet.Cells(count, 1).Value = "TOTAL"
                    'oSheet.Cells(count, 10).Value = SomaConducao
                    'oSheet.Cells(count, 11).Value = SomaMedicamento
                    'oSheet.Cells(count, 12).Value = SomaServico
                    'oSheet.Cells(count, 13).Value = SomaEquipamento
                    'oSheet.Cells(count, 14).Value = SomaBeneficio
                    'oSheet.Cells(count, 15).Value = SomaSemem
                    'count += 1
                    oSheet.Cells(count, 3).Value = Format(CDec(wTotal), "#,###,##0.00")
                    'oSheet.Cells(count, 11).Value = Format(CDec(SomaMedicamento), "#,###,##0.00")
                    'oSheet.Cells(count, 12).Value = Format(CDec(SomaServico), "#,###,##0.00")
                    'oSheet.Cells(count, 13).Value = Format(CDec(SomaEquipamento), "#,###,##0.00")
                    'oSheet.Cells(count, 14).Value = Format(CDec(SomaBeneficio), "#,###,##0.00")
                    'oSheet.Cells(count, 15).Value = Format(CDec(SomaOutros), "#,###,##0.00")
                    'oSheet.Cells(count, 16).Value = Format(CDec(SomaSemem), "#,###,##0.00")
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

    Private Sub btFechar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub cbSemAnimal_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSemAnimal.CheckedChanged
        If cbSemAnimal.Checked = True Then
            cbAnimal.SelectedIndex = 0
            cbAnimal.Enabled = False
        ElseIf cbSemAnimal.Checked = False Then
            cbAnimal.SelectedIndex = 0
            cbAnimal.Enabled = True
        End If
    End Sub


    Private Sub txtMatricula_Associado_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMatricula_Associado.Leave
        If (txtMatricula_Associado.Text <> objAssociados_Implem.Matricula AndAlso txtMatricula_Associado.Text <> "") OrElse _
           (txtCodigo_Associado.Text <> objAssociados_Implem.Codigo AndAlso _
           txtMatricula_Associado.Text <> "") Then

            Dim a As New Associados
            a.txtPesquisa.Text = txtMatricula_Associado.Text
            a.vSelecao = "Matricula"
            a.ShowDialog()
            a.Dispose()
            If objAssociados_Implem.Codigo <> "" Then
                txtMatricula_Associado.Text = objAssociados_Implem.Matricula
                txtCodigo_Associado.Text = objAssociados_Implem.Codigo
                txtNome_Associado.Text = objAssociados_Implem.NomeAssociado
            Else
                txtMatricula_Associado.Text = ""
                txtCodigo_Associado.Text = ""
                txtNome_Associado.Text = ""
            End If
        ElseIf txtMatricula_Associado.Text = "" Then
            txtMatricula_Associado.Text = ""
            txtCodigo_Associado.Text = ""
            txtNome_Associado.Text = ""
        End If
    End Sub

    Private Sub txtNome_Associado_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome_Associado.Leave
        If (txtNome_Associado.Text <> objAssociados_Implem.NomeAssociado AndAlso txtNome_Associado.Text <> "") OrElse _
           (txtCodigo_Associado.Text <> objAssociados_Implem.Codigo AndAlso _
           txtNome_Associado.Text <> "") Then
            Dim a As New Associados
            a.txtPesquisa.Text = txtNome_Associado.Text
            a.vSelecao = "Nome"
            a.ShowDialog()
            a.Dispose()
            If objAssociados_Implem.Codigo <> "" Then
                txtMatricula_Associado.Text = objAssociados_Implem.Matricula
                txtCodigo_Associado.Text = objAssociados_Implem.Codigo
                txtNome_Associado.Text = objAssociados_Implem.NomeAssociado
            Else
                txtMatricula_Associado.Text = ""
                txtCodigo_Associado.Text = ""
                txtNome_Associado.Text = ""
            End If
        ElseIf txtNome_Associado.Text = "" Then
            txtMatricula_Associado.Text = ""
            txtCodigo_Associado.Text = ""
            txtNome_Associado.Text = ""
        End If
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

    Private Sub btGerarArquivoBRF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGerarArquivoBRF.Click
        Try

            Dim wControle As Integer

            wControle = FazPesquisaParaTxtBRF()
            If wControle <> 0 Then
                Exit Sub
            End If

            Dim saveFileDialog1 As New SaveFileDialog
            With saveFileDialog1
                .Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
                .FilterIndex = 1
                .Title = "Selecione um Local Para Salvar o Arquivo"
                .FileName = "BRF_" & "304843-651" & _
                        CDate(txtDataInicio.Text).Year & CDate(txtDataInicio.Text).Month & ".txt"
            End With

            'saveFileDialog1.ShowDialog()

            If saveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim file_Name As String = saveFileDialog1.FileName

                Dim SW As New IO.StreamWriter(file_Name, False)
                Dim xx1 As String = ""

                TotalRecords = 0
                If wDataSetItens.Tables.Count > 0 Then
                    TotalRecords = wDataSetItens.Tables(0).Rows.Count.ToString()
                End If
                ContadorRegistro = 0
                pagina = 0
                dados = 0

                'Variaveis
                Dim wDataInicio As String = DatePart(DateInterval.Year, CDate(txtDataFinal.Text)) & _
                         Format(CInt(DatePart(DateInterval.Month, CDate(txtDataFinal.Text))), "00")

                For i As Integer = ContadorRegistro To TotalRecords - 1

                    CdProdutor = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(0)), 0, wDataSetItens.Tables(0).Rows(i)(0))
                    SPMON = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(1)), "", wDataSetItens.Tables(0).Rows(i)(1))
                    NrDoc = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(2)), "", wDataSetItens.Tables(0).Rows(i)(2))
                    VlConvenio = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(3)), 0, wDataSetItens.Tables(0).Rows(i)(3))

                    'Soma dos Valores
                    T_VlConvenio += VlConvenio

                    '--------------------------------------------------------------------
                    xx1 += "1" & ";" & _
                    "651" & ";" & _
                    wDataInicio & ";" & _
                    CdProdutor & ";" & _
                    "304843" & ";" & _
                    NrDoc & ";" & _
                    Format(VlConvenio, "######0.00")
                    xx1 += vbCrLf

                Next
                xx1 += "9" & ";" & _
                Format(T_VlConvenio, "######0.00")

                SW.WriteLine(xx1)
                SW.Close()

                wAgrupamentoString = ""
                wAgrupamentoAss = ""
                wAgrupamentoValorTotal = 0

                MsgBox("Arquivo Salvo com Sucesso!")
                T_VlConvenio = 0
            End If


        Catch ex As Exception
            Me.Cursor = Cursors.Default
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim wControle As Integer
        wControle = FazPesquisaParaTxt()
        If wControle <> 0 Then
            Exit Sub
        End If

        Dim saveFileDialog1 As New SaveFileDialog
        With saveFileDialog1
            .Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Selecione um Local Para Salvar o Arquivo "
            .FileName = "AssMvx_" & CStr(ConverteDataParaString(txtDataInicio.Text)).Replace("/", "").Remove(4, 2) & "_" & CStr(ConverteDataParaString(txtDataFinal.Text)).Replace("/", "").Remove(4, 2) & ".txt"
        End With

        If saveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim file_Name As String = saveFileDialog1.FileName

            Dim SW As New IO.StreamWriter(file_Name, False)
            Dim wDataInicio As String = "01/" & DatePart(DateInterval.Month, CDate(txtDataFinal.Text)) & _
                "/" & DatePart(DateInterval.Year, CDate(txtDataFinal.Text))
            Dim xx1 As String = ""

            TotalRecords = 0
            If wDataSetItens.Tables.Count > 0 Then
                TotalRecords = wDataSetItens.Tables(0).Rows.Count.ToString()
            End If
            ContadorRegistro = 0
            pagina = 0
            dados = 0

            'Variaveis
            Dim yValor As Decimal = 0
            Dim yNumero As Decimal = 0
            Dim wTValor As Decimal = 0
            Dim wTNumero As Decimal = 0
            Dim wGeraLinha As Boolean = False
            Dim i As Integer
            For i = ContadorRegistro To TotalRecords - 1

                TipoAss = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(1)), "", wDataSetItens.Tables(0).Rows(i)(1))
                'Gera somente dados de Vacinação Leitões
                If TipoAss = "16" Then
                    Matricula = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(0)), 0, wDataSetItens.Tables(0).Rows(i)(0))
                    If Matricula.ToString.Length < 2 Then
                        Matricula = 168261
                    Else
                        Matricula = Matricula.ToString.Substring(0, Matricula.ToString.Length - 1)
                    End If
                    Data = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(2)), 0, wDataSetItens.Tables(0).Rows(i)(2))
                    Documento = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(3)), 0, wDataSetItens.Tables(0).Rows(i)(3))
                    Tecnico = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(4)), 0, wDataSetItens.Tables(0).Rows(i)(4))
                    TipoServico = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(5)), 0, wDataSetItens.Tables(0).Rows(i)(5))
                    Animal = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(6)), 0, wDataSetItens.Tables(0).Rows(i)(6))
                    Numero = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(7)), 0, wDataSetItens.Tables(0).Rows(i)(7))
                    Ger = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(8)), 0, wDataSetItens.Tables(0).Rows(i)(8))
                    Cabecas = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(9)), 0, wDataSetItens.Tables(0).Rows(i)(9))
                    Conducao = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(10)), 0, wDataSetItens.Tables(0).Rows(i)(10))
                    Medicamento = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(11)), 0, wDataSetItens.Tables(0).Rows(i)(11))
                    Servico = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(12)), 0, wDataSetItens.Tables(0).Rows(i)(12))
                    Equipamento = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(13)), 0, wDataSetItens.Tables(0).Rows(i)(13))
                    Beneficio = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(14)), 0, wDataSetItens.Tables(0).Rows(i)(14))
                    Outros = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(15)), 0, wDataSetItens.Tables(0).Rows(i)(15))
                    Tpg = "0"
                    Talao = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(16)), 0, wDataSetItens.Tables(0).Rows(i)(16))
                    MaoDeObra = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(17)), 0, wDataSetItens.Tables(0).Rows(i)(17))
                    Everminacao = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(18)), 0, wDataSetItens.Tables(0).Rows(i)(18))
                    Semem = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(19)), 0, wDataSetItens.Tables(0).Rows(i)(19))
                    Visita = IIf(IsDBNull(wDataSetItens.Tables(0).Rows(i)(20)), 0, wDataSetItens.Tables(0).Rows(i)(20))

                    wGeraLinha = True

                    If TipoAss = "16" Then
                        TipoAssCoolan = "01"
                        Tecnico = "0132722"
                    ElseIf (MaoDeObra + Everminacao) > 0 Then
                        TipoAssCoolan = "12"
                    Else
                        TipoAssCoolan = "01"
                    End If
                    yValor = Conducao + Medicamento + Everminacao + Semem + Outros + _
                        MaoDeObra + Visita + Servico + Equipamento
                    yNumero = Cabecas
                    wTnumero += yNumero
                    wTValor += yValor

                    If wGeraLinha = True Then
                        If CDate(Data) < CDate(wDataInicio) Then
                            Data = wDataInicio
                        End If
                        'Dados Fixos e Ajustes Formato---------------------------------------
                        Data = CStr(ConverteDataParaString(Data)).Replace("/", "").Remove(4, 2)
                        Data = Data.Substring(4, 2) & Data.Substring(2, 2) & Data.Substring(0, 2)
                        '--------------------------------------------------------------------
                        xx1 += _
                        Format(CInt(Matricula), "0000000") & _
                        TipoAssCoolan & _
                        Data & _
                        Format(CInt(Documento), "0000000") & _
                        Tecnico & _
                        Format(CInt(TipoServico), "00") & _
                        Format(CInt(Animal), "00") & _
                        Format(CInt(yNumero), "00000") & _
                        Format(CLng(ConverteDecimalPara2Dec(yValor).Replace(".", "")), "0000000000000")
                        xx1 += vbCrLf
                    End If
                End If
            Next
            SW.WriteLine(xx1)
            SW.Close()
            Dim xTotais As String = ""
            xTotais += "Número Vacinas  : " & wTNumero & vbCrLf
            xTotais += "Total Valor     : " & wTValor & vbCrLf
            xTotais += "Arquivo salvo com sucesso! "

            MsgBox(xTotais)
        End If
    End Sub

End Class
 