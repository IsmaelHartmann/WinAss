<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelatorioPrefeituras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelatorioPrefeituras))
        Me.gpMovimentos = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbDocumentos = New System.Windows.Forms.RadioButton
        Me.rbTodos = New System.Windows.Forms.RadioButton
        Me.rbCanhotos = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbAssociado = New System.Windows.Forms.RadioButton
        Me.rbData = New System.Windows.Forms.RadioButton
        Me.cbPrefeitura = New FzComboBox.FzCombobox
        Me.Label2 = New System.Windows.Forms.Label
        Me.box1 = New System.Windows.Forms.GroupBox
        Me.txtDataFinal = New FzFlexBox.DateTextBox
        Me.txtDataInicio = New FzFlexBox.DateTextBox
        Me.lbDataInicial = New System.Windows.Forms.Label
        Me.lbDataFinal = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbImpressoras = New System.Windows.Forms.ComboBox
        Me.btLimpar = New System.Windows.Forms.Button
        Me.btFechar = New System.Windows.Forms.Button
        Me.btImprimir = New System.Windows.Forms.Button
        Me.btVerImpressão = New System.Windows.Forms.Button
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.btGeraExcel = New System.Windows.Forms.Button
        Me.gpMovimentos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.box1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpMovimentos
        '
        Me.gpMovimentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.gpMovimentos.Controls.Add(Me.GroupBox2)
        Me.gpMovimentos.Controls.Add(Me.GroupBox1)
        Me.gpMovimentos.Controls.Add(Me.cbPrefeitura)
        Me.gpMovimentos.Controls.Add(Me.Label2)
        Me.gpMovimentos.Controls.Add(Me.box1)
        Me.gpMovimentos.Controls.Add(Me.Label1)
        Me.gpMovimentos.Controls.Add(Me.cbImpressoras)
        Me.gpMovimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpMovimentos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpMovimentos.ForeColor = System.Drawing.Color.Black
        Me.gpMovimentos.Location = New System.Drawing.Point(27, 54)
        Me.gpMovimentos.Name = "gpMovimentos"
        Me.gpMovimentos.Size = New System.Drawing.Size(601, 274)
        Me.gpMovimentos.TabIndex = 0
        Me.gpMovimentos.TabStop = False
        Me.gpMovimentos.Text = "Relatório de Movimentos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbDocumentos)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbCanhotos)
        Me.GroupBox2.Location = New System.Drawing.Point(450, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 96)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro"
        '
        'rbDocumentos
        '
        Me.rbDocumentos.AutoSize = True
        Me.rbDocumentos.Location = New System.Drawing.Point(21, 43)
        Me.rbDocumentos.Name = "rbDocumentos"
        Me.rbDocumentos.Size = New System.Drawing.Size(101, 18)
        Me.rbDocumentos.TabIndex = 1
        Me.rbDocumentos.Text = "Só Documentos"
        Me.rbDocumentos.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(21, 19)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(54, 18)
        Me.rbTodos.TabIndex = 0
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbCanhotos
        '
        Me.rbCanhotos.AutoSize = True
        Me.rbCanhotos.Location = New System.Drawing.Point(21, 67)
        Me.rbCanhotos.Name = "rbCanhotos"
        Me.rbCanhotos.Size = New System.Drawing.Size(87, 18)
        Me.rbCanhotos.TabIndex = 2
        Me.rbCanhotos.Text = "Só Canhotos"
        Me.rbCanhotos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAssociado)
        Me.GroupBox1.Controls.Add(Me.rbData)
        Me.GroupBox1.Location = New System.Drawing.Point(266, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 50)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordem"
        '
        'rbAssociado
        '
        Me.rbAssociado.AutoSize = True
        Me.rbAssociado.Checked = True
        Me.rbAssociado.Location = New System.Drawing.Point(6, 19)
        Me.rbAssociado.Name = "rbAssociado"
        Me.rbAssociado.Size = New System.Drawing.Size(77, 18)
        Me.rbAssociado.TabIndex = 0
        Me.rbAssociado.TabStop = True
        Me.rbAssociado.Text = "Associado"
        Me.rbAssociado.UseVisualStyleBackColor = True
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Location = New System.Drawing.Point(95, 19)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(47, 18)
        Me.rbData.TabIndex = 1
        Me.rbData.Text = "Data"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'cbPrefeitura
        '
        Me.cbPrefeitura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPrefeitura.ItemHeight = 14
        Me.cbPrefeitura.Location = New System.Drawing.Point(108, 23)
        Me.cbPrefeitura.Name = "cbPrefeitura"
        Me.cbPrefeitura.Size = New System.Drawing.Size(144, 22)
        Me.cbPrefeitura.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Prefeitura"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'box1
        '
        Me.box1.Controls.Add(Me.txtDataFinal)
        Me.box1.Controls.Add(Me.txtDataInicio)
        Me.box1.Controls.Add(Me.lbDataInicial)
        Me.box1.Controls.Add(Me.lbDataFinal)
        Me.box1.Location = New System.Drawing.Point(266, 23)
        Me.box1.Name = "box1"
        Me.box1.Size = New System.Drawing.Size(178, 70)
        Me.box1.TabIndex = 2
        Me.box1.TabStop = False
        Me.box1.Text = "Por Período"
        '
        'txtDataFinal
        '
        Me.txtDataFinal.Flags = 65536
        Me.txtDataFinal.Location = New System.Drawing.Point(82, 43)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtDataFinal.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtDataFinal.Size = New System.Drawing.Size(83, 20)
        Me.txtDataFinal.TabIndex = 3
        '
        'txtDataInicio
        '
        Me.txtDataInicio.Flags = 65536
        Me.txtDataInicio.Location = New System.Drawing.Point(82, 19)
        Me.txtDataInicio.Name = "txtDataInicio"
        Me.txtDataInicio.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtDataInicio.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtDataInicio.Size = New System.Drawing.Size(83, 20)
        Me.txtDataInicio.TabIndex = 1
        '
        'lbDataInicial
        '
        Me.lbDataInicial.BackColor = System.Drawing.Color.Transparent
        Me.lbDataInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataInicial.ForeColor = System.Drawing.Color.Black
        Me.lbDataInicial.Location = New System.Drawing.Point(18, 20)
        Me.lbDataInicial.Name = "lbDataInicial"
        Me.lbDataInicial.Size = New System.Drawing.Size(65, 20)
        Me.lbDataInicial.TabIndex = 0
        Me.lbDataInicial.Text = "Data Inicial"
        '
        'lbDataFinal
        '
        Me.lbDataFinal.BackColor = System.Drawing.Color.Transparent
        Me.lbDataFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataFinal.ForeColor = System.Drawing.Color.Black
        Me.lbDataFinal.Location = New System.Drawing.Point(18, 43)
        Me.lbDataFinal.Name = "lbDataFinal"
        Me.lbDataFinal.Size = New System.Drawing.Size(65, 20)
        Me.lbDataFinal.TabIndex = 2
        Me.lbDataFinal.Text = "Data Final"
        Me.lbDataFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Impressora"
        '
        'cbImpressoras
        '
        Me.cbImpressoras.Location = New System.Drawing.Point(117, 155)
        Me.cbImpressoras.Name = "cbImpressoras"
        Me.cbImpressoras.Size = New System.Drawing.Size(327, 22)
        Me.cbImpressoras.TabIndex = 6
        '
        'btLimpar
        '
        Me.btLimpar.BackColor = System.Drawing.SystemColors.Control
        Me.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLimpar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.Image = CType(resources.GetObject("btLimpar.Image"), System.Drawing.Image)
        Me.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btLimpar.Location = New System.Drawing.Point(318, 11)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(64, 25)
        Me.btLimpar.TabIndex = 2
        Me.btLimpar.Text = "Limpar"
        Me.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btLimpar.UseVisualStyleBackColor = False
        '
        'btFechar
        '
        Me.btFechar.BackColor = System.Drawing.SystemColors.Control
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Image = Global.WinASS.My.Resources.Resources.porta16
        Me.btFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFechar.Location = New System.Drawing.Point(555, 11)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(67, 25)
        Me.btFechar.TabIndex = 5
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btFechar.UseVisualStyleBackColor = False
        '
        'btImprimir
        '
        Me.btImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btImprimir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImprimir.Image = Global.WinASS.My.Resources.Resources._778_16x16
        Me.btImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btImprimir.Location = New System.Drawing.Point(477, 11)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(72, 25)
        Me.btImprimir.TabIndex = 4
        Me.btImprimir.Text = "Imprimir"
        Me.btImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btImprimir.UseVisualStyleBackColor = False
        '
        'btVerImpressão
        '
        Me.btVerImpressão.BackColor = System.Drawing.SystemColors.Control
        Me.btVerImpressão.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btVerImpressão.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVerImpressão.Image = Global.WinASS.My.Resources.Resources._4035_16x16
        Me.btVerImpressão.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btVerImpressão.Location = New System.Drawing.Point(388, 11)
        Me.btVerImpressão.Name = "btVerImpressão"
        Me.btVerImpressão.Size = New System.Drawing.Size(83, 25)
        Me.btVerImpressão.TabIndex = 3
        Me.btVerImpressão.Text = "Visualizar"
        Me.btVerImpressão.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btVerImpressão.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btGeraExcel
        '
        Me.btGeraExcel.BackColor = System.Drawing.SystemColors.Control
        Me.btGeraExcel.Image = CType(resources.GetObject("btGeraExcel.Image"), System.Drawing.Image)
        Me.btGeraExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btGeraExcel.Location = New System.Drawing.Point(27, 10)
        Me.btGeraExcel.Name = "btGeraExcel"
        Me.btGeraExcel.Size = New System.Drawing.Size(89, 25)
        Me.btGeraExcel.TabIndex = 1
        Me.btGeraExcel.Text = "Gerar Excel"
        Me.btGeraExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btGeraExcel.UseVisualStyleBackColor = False
        '
        'RelatorioPrefeituras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(658, 340)
        Me.Controls.Add(Me.btGeraExcel)
        Me.Controls.Add(Me.btLimpar)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.btVerImpressão)
        Me.Controls.Add(Me.gpMovimentos)
        Me.Name = "RelatorioPrefeituras"
        Me.Text = "Relatório de Movimentos"
        Me.gpMovimentos.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.box1.ResumeLayout(False)
        Me.box1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents btVerImpressão As System.Windows.Forms.Button
    Friend WithEvents gpMovimentos As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAssociado As System.Windows.Forms.RadioButton
    Friend WithEvents rbData As System.Windows.Forms.RadioButton
    Friend WithEvents cbPrefeitura As FzComboBox.FzCombobox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents box1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbDataInicial As System.Windows.Forms.Label
    Friend WithEvents lbDataFinal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbImpressoras As System.Windows.Forms.ComboBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtDataFinal As FzFlexBox.DateTextBox
    Friend WithEvents txtDataInicio As FzFlexBox.DateTextBox
    Friend WithEvents btGeraExcel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDocumentos As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbCanhotos As System.Windows.Forms.RadioButton
End Class
