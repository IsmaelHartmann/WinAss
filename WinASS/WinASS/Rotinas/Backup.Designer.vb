<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Backup))
        Me.txtLocalDestino = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btSelecionaArquivo = New System.Windows.Forms.Button
        Me.btBKP = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNomeArquivo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Label19 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.pbProgresso = New System.Windows.Forms.ProgressBar
        Me.lblTempo = New System.Windows.Forms.Label
        Me.lblPercentual = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtLocalDestino
        '
        Me.txtLocalDestino.Location = New System.Drawing.Point(66, 141)
        Me.txtLocalDestino.Name = "txtLocalDestino"
        Me.txtLocalDestino.ReadOnly = True
        Me.txtLocalDestino.Size = New System.Drawing.Size(470, 20)
        Me.txtLocalDestino.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Local de Destino"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(589, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "_________________________________________________________________________________" & _
            "________________"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.LightGray
        Me.lbl4.Location = New System.Drawing.Point(473, 208)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(145, 15)
        Me.lbl4.TabIndex = 14
        Me.lbl4.Text = "4) Enviando para FTP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(589, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "_________________________________________________________________________________" & _
            "________________"
        '
        'btSelecionaArquivo
        '
        Me.btSelecionaArquivo.Image = CType(resources.GetObject("btSelecionaArquivo.Image"), System.Drawing.Image)
        Me.btSelecionaArquivo.Location = New System.Drawing.Point(542, 138)
        Me.btSelecionaArquivo.Name = "btSelecionaArquivo"
        Me.btSelecionaArquivo.Size = New System.Drawing.Size(29, 23)
        Me.btSelecionaArquivo.TabIndex = 18
        Me.btSelecionaArquivo.UseVisualStyleBackColor = True
        '
        'btBKP
        '
        Me.btBKP.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btBKP.Image = CType(resources.GetObject("btBKP.Image"), System.Drawing.Image)
        Me.btBKP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btBKP.Location = New System.Drawing.Point(470, 237)
        Me.btBKP.Name = "btBKP"
        Me.btBKP.Size = New System.Drawing.Size(102, 42)
        Me.btBKP.TabIndex = 0
        Me.btBKP.Text = "Backup"
        Me.btBKP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btBKP.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nome do Arquivo"
        '
        'txtNomeArquivo
        '
        Me.txtNomeArquivo.Enabled = False
        Me.txtNomeArquivo.Location = New System.Drawing.Point(66, 93)
        Me.txtNomeArquivo.Name = "txtNomeArquivo"
        Me.txtNomeArquivo.ReadOnly = True
        Me.txtNomeArquivo.Size = New System.Drawing.Size(470, 20)
        Me.txtNomeArquivo.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(542, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = ".Bak"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label19.Location = New System.Drawing.Point(25, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(236, 20)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Rotina Manual de Backup"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(509, 13)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Aconselha-se fazer um backup para dispositivos de armazenamento externo(Pen Drive" & _
            ", HD Externo. etc...)"
        '
        'pbProgresso
        '
        Me.pbProgresso.Location = New System.Drawing.Point(28, 252)
        Me.pbProgresso.Name = "pbProgresso"
        Me.pbProgresso.Size = New System.Drawing.Size(375, 23)
        Me.pbProgresso.TabIndex = 133
        '
        'lblTempo
        '
        Me.lblTempo.AutoSize = True
        Me.lblTempo.Location = New System.Drawing.Point(25, 236)
        Me.lblTempo.Name = "lblTempo"
        Me.lblTempo.Size = New System.Drawing.Size(16, 13)
        Me.lblTempo.TabIndex = 134
        Me.lblTempo.Text = "..."
        '
        'lblPercentual
        '
        Me.lblPercentual.AutoSize = True
        Me.lblPercentual.Location = New System.Drawing.Point(409, 257)
        Me.lblPercentual.Name = "lblPercentual"
        Me.lblPercentual.Size = New System.Drawing.Size(16, 13)
        Me.lblPercentual.TabIndex = 135
        Me.lblPercentual.Text = "..."
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.LightGray
        Me.lbl1.Location = New System.Drawing.Point(26, 208)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(148, 15)
        Me.lbl1.TabIndex = 136
        Me.lbl1.Text = "1) Realizando Backup"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.LightGray
        Me.lbl2.Location = New System.Drawing.Point(180, 208)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(169, 15)
        Me.lbl2.TabIndex = 137
        Me.lbl2.Text = "2) Copiando para destino"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.LightGray
        Me.lbl3.Location = New System.Drawing.Point(355, 208)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(112, 15)
        Me.lbl3.TabIndex = 138
        Me.lbl3.Text = "3) Compactando"
        '
        'Backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(639, 287)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lblPercentual)
        Me.Controls.Add(Me.lblTempo)
        Me.Controls.Add(Me.pbProgresso)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomeArquivo)
        Me.Controls.Add(Me.btSelecionaArquivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLocalDestino)
        Me.Controls.Add(Me.btBKP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Backup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realizar Backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btBKP As System.Windows.Forms.Button
    Friend WithEvents txtLocalDestino As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btSelecionaArquivo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomeArquivo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pbProgresso As System.Windows.Forms.ProgressBar
    Friend WithEvents lblTempo As System.Windows.Forms.Label
    Friend WithEvents lblPercentual As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label

End Class
