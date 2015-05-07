Imports System.Data.SqlClient

Public Class SelecionaBanco
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
    Friend WithEvents btCTAASS_VA As System.Windows.Forms.Button
    Friend WithEvents btCTAASS As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelecionaBanco))
        Me.btCTAASS_VA = New System.Windows.Forms.Button
        Me.btCTAASS = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btCTAASS_VA
        '
        Me.btCTAASS_VA.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btCTAASS_VA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCTAASS_VA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCTAASS_VA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCTAASS_VA.ForeColor = System.Drawing.Color.Black
        Me.btCTAASS_VA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btCTAASS_VA.Location = New System.Drawing.Point(23, 22)
        Me.btCTAASS_VA.Name = "btCTAASS_VA"
        Me.btCTAASS_VA.Size = New System.Drawing.Size(85, 26)
        Me.btCTAASS_VA.TabIndex = 6
        Me.btCTAASS_VA.Text = "CTAASS_VA"
        Me.btCTAASS_VA.UseVisualStyleBackColor = False
        '
        'btCTAASS
        '
        Me.btCTAASS.BackColor = System.Drawing.SystemColors.Control
        Me.btCTAASS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCTAASS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCTAASS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCTAASS.ForeColor = System.Drawing.Color.Black
        Me.btCTAASS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btCTAASS.Location = New System.Drawing.Point(119, 22)
        Me.btCTAASS.Name = "btCTAASS"
        Me.btCTAASS.Size = New System.Drawing.Size(85, 26)
        Me.btCTAASS.TabIndex = 7
        Me.btCTAASS.Text = "CTAASS"
        Me.btCTAASS.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SelecionaBanco
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(225, 78)
        Me.ControlBox = False
        Me.Controls.Add(Me.btCTAASS_VA)
        Me.Controls.Add(Me.btCTAASS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SelecionaBanco"
        Me.Opacity = 0.85
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Senha Supervisor"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim wComando As SqlCommand = New SqlCommand("", VariaveisGlobais.gConexao)
    Dim wDataReader As SqlDataReader

    Dim wSetorUsuario As Integer
    Dim wFilialUsuario As Integer
    Dim wTipoUsuario As String
    Dim wLoginUsuario As String
    Dim wSituacao As String

#Region " Inicializações "

#End Region

#Region " Cancelar/Confirmar "

    Private Sub btCTAASS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCTAASS.Click
        VariaveisGlobais.gBD = "CTAASS"
        Fechar()
    End Sub

    Private Sub btCTAASS_VA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCTAASS_VA.Click
        VariaveisGlobais.gBD = "CTAASS_VA"
        Fechar()
    End Sub

    Public Function Fechar() As Integer
        Me.Close()
    End Function

#End Region

    Private Sub MyBase_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        Dim wControle As Integer
        wControle = objVariaveisGlobais.FechaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
        If wControle <> 0 Then
            objVariaveisGlobais.MostraErro()
        End If
    End Sub
End Class
