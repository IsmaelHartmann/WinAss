Imports System.Console
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Text.RegularExpressions


Public Class ConsultaLog
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required BY the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required BY the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required BY the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents gpDados As System.Windows.Forms.GroupBox
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents txtTabela As System.Windows.Forms.TextBox
    Friend WithEvents txtChave As System.Windows.Forms.TextBox
    Friend WithEvents dtgLog As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaLog))
        Me.dtgLog = New System.Windows.Forms.DataGrid
        Me.gpDados = New System.Windows.Forms.GroupBox
        Me.txtChave = New System.Windows.Forms.TextBox
        Me.btCancelar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTabela = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dtgLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDados.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgLog
        '
        Me.dtgLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgLog.CaptionBackColor = System.Drawing.Color.LightGray
        Me.dtgLog.CaptionText = "C_LOG"
        Me.dtgLog.DataMember = ""
        Me.dtgLog.FlatMode = True
        Me.dtgLog.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.dtgLog.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgLog.LinkColor = System.Drawing.Color.LightGray
        Me.dtgLog.Location = New System.Drawing.Point(24, 104)
        Me.dtgLog.Name = "dtgLog"
        Me.dtgLog.RowHeaderWidth = 5
        Me.dtgLog.Size = New System.Drawing.Size(744, 384)
        Me.dtgLog.TabIndex = 15
        '
        'gpDados
        '
        Me.gpDados.BackColor = System.Drawing.Color.Transparent
        Me.gpDados.Controls.Add(Me.txtChave)
        Me.gpDados.Controls.Add(Me.btCancelar)
        Me.gpDados.Controls.Add(Me.Label6)
        Me.gpDados.Controls.Add(Me.txtTabela)
        Me.gpDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpDados.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDados.ForeColor = System.Drawing.Color.Black
        Me.gpDados.Location = New System.Drawing.Point(24, 32)
        Me.gpDados.Name = "gpDados"
        Me.gpDados.Size = New System.Drawing.Size(744, 56)
        Me.gpDados.TabIndex = 0
        Me.gpDados.TabStop = False
        Me.gpDados.Text = "C_LOG"
        '
        'txtChave
        '
        Me.txtChave.Enabled = False
        Me.txtChave.Location = New System.Drawing.Point(376, 24)
        Me.txtChave.Name = "txtChave"
        Me.txtChave.Size = New System.Drawing.Size(248, 20)
        Me.txtChave.TabIndex = 29
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelar.Location = New System.Drawing.Point(648, 24)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 2
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Tabela"
        '
        'txtTabela
        '
        Me.txtTabela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTabela.Location = New System.Drawing.Point(72, 24)
        Me.txtTabela.MaxLength = 150
        Me.txtTabela.Name = "txtTabela"
        Me.txtTabela.Size = New System.Drawing.Size(288, 20)
        Me.txtTabela.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ConsultaLog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 508)
        Me.Controls.Add(Me.dtgLog)
        Me.Controls.Add(Me.gpDados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(150, 176)
        Me.Name = "ConsultaLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Log Alterações"
        CType(Me.dtgLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDados.ResumeLayout(False)
        Me.gpDados.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variáveis internas "
    Public objConsultaLog_Implem As ConsultaLog_Implem = ConsultaLogBOFactory.GetFactory().GetInstance()

    Public Enum enTipoPesquisa
        Nome
    End Enum
#End Region

#Region " Inicializações "
    Private Sub My_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        objConsultaLog_Implem.Close()
    End Sub

    Private Sub C_LOG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AjustaTela(Me)

            dtgLog.ReadOnly = True
  
            txtTabela.Text = objConsultaLog_Implem.Tabela
            txtChave.Text = objConsultaLog_Implem.Chave
            txtTabela.Enabled = False
            Pesquisar()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Me.Close()
        End Try
    End Sub

#End Region

#Region " Pesquisas "

    Private Sub dtgLog_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgLog.MouseUp

        Try
            '___________________________________________________________________
            '
            ' Seleciona toda linha da célula onde foi clicada
            '___________________________________________________________________

            Dim pt = New Point(e.X, e.Y)
            Dim hti As DataGrid.HitTestInfo = dtgLog.HitTest(pt)

            If hti.Type = DataGrid.HitTestType.Cell Then

                dtgLog.CurrentCell = New DataGridCell(hti.Row, hti.Column)
                dtgLog.Select(hti.Row)

                '
                ' Verifica se foi clicado no ícone de alteração

                'If hti.Column = 2 Then

                '    objC_LOG_Implem.Tabela = dtgLog(hti.Row, 0)
                '    objC_LOG_Implem.BuscarC_LOG()

                '    Me.Close()
                'End If
            End If
        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub dtgLog_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgLog.MouseMove

        Try
            '___________________________________________________________________
            '
            ' Coloca cursor:hand para ícones de alterar e excluir do Datagrid
            '___________________________________________________________________

            Dim hti As System.Windows.Forms.DataGrid.HitTestInfo
            hti = dtgLog.HitTest(e.X, e.Y)

            If hti.Type = System.Windows.Forms.DataGrid.HitTestType.Cell Then

                'If hti.Column = 2 Then
                '    Me.Cursor = System.Windows.Forms.Cursors.Hand
                '    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand
                'Else
                '    Me.Cursor = System.Windows.Forms.Cursors.Default
                '    Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                'End If

            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If

        Catch ex As Exception

            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()

        End Try

    End Sub


    Private Sub Pesquisar()
        Try
            Dim wControle As Integer
           
            Dim wSQL As String = _
            " SET DATEFORMAT dmy SELECT Tabela, Chave, " & _
            " CAST(LEFT('00', 2 - len(DATEPART(dd, DataHora))) AS VARCHAR)+" & _
            " CAST(DATEPART(dd, DataHora) AS VARCHAR) + '/' + " & _
            " CAST(LEFT('00', 2 - len(DATEPART(mm, DataHora))) AS VARCHAR)+" & _
            " CAST(DATEPART(mm, DataHora) AS VARCHAR) + '/' + " & _
            " CAST(DATEPART(yy, DataHora) AS VARCHAR) + ' ' + " & _
            " CAST(LEFT('00', 2 - len(DATEPART(hh, DataHora))) AS VARCHAR)+" & _
            " CAST(DATEPART(hh, DataHora) AS VARCHAR) + ':' + " & _
            " CAST(LEFT('00', 2 - len(DATEPART(mi, DataHora))) AS VARCHAR)+" & _
            " CAST(DATEPART(mi, DataHora) AS VARCHAR) + ':' + " & _
            " CAST(LEFT('00', 2 - len(DATEPART(ss, DataHora))) AS VARCHAR)+" & _
            " CAST(DATEPART(ss, DataHora) AS VARCHAR) AS DataHorax, " & _
            " Usuario,Campo,  " & _
            " case len(infoantigo) when 11 then isnull((select nome from Ass_Associados " & _
            " where codigo=infoantigo),infoantigo) " & _
            " when 14 then isnull((select nome from Ass_Associados " & _
            " where codigo=infoantigo),infoantigo) else infoantigo end InfoAntigo " & _
            " FROM " & objConsultaLog_Implem.Tabela & " WHERE " & _
            IIf(objConsultaLog_Implem.Tabela1 <> "", " Tabela like '" & objConsultaLog_Implem.Tabela1 & "%' AND ", "") & _
            " Chave LIKE '" & txtChave.Text & "%' ORDER BY Chave, DataHora DESC "

            wControle = objConsultaLog_Implem.MostraC_LOG(dtgLog, wSQL)
            If wControle <> 0 Then objVariaveisGlobais.MostraErro()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
        End Try
    End Sub

    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        'objConsultaLog_Implem.Tabela = ""
        Me.Close()
    End Sub
#End Region

End Class


