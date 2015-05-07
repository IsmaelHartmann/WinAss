Imports TD.Eyefinder
Imports System.Xml
Imports System.Collections
Imports System.Collections.Specialized
Imports Fortaleza.BackOffice
Imports System.Data.SqlClient
Imports System
Imports Microsoft.Win32
Imports System.IO

Public Class Principal
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private WithEvents TopMenu As System.Windows.Forms.MainMenu
    Private WithEvents ImageListMenu As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents statusBar As System.Windows.Forms.StatusBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Public WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Me.TopMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.ImageListMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.statusBar = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopMenu
        '
        Me.TopMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = ""
        '
        'ImageListMenu
        '
        Me.ImageListMenu.ImageStream = CType(resources.GetObject("ImageListMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListMenu.Images.SetKeyName(0, "")
        Me.ImageListMenu.Images.SetKeyName(1, "")
        Me.ImageListMenu.Images.SetKeyName(2, "")
        Me.ImageListMenu.Images.SetKeyName(3, "")
        '
        'statusBar
        '
        Me.statusBar.Location = New System.Drawing.Point(0, 429)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.statusBar.ShowPanels = True
        Me.statusBar.Size = New System.Drawing.Size(648, 22)
        Me.statusBar.TabIndex = 3
        Me.statusBar.Visible = False
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = CType(configurationAppSettings.GetValue("StatusBarPanel1.Text", GetType(String)), String)
        Me.StatusBarPanel1.Width = 532
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Principal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(648, 451)
        Me.Controls.Add(Me.statusBar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.TopMenu
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Win Assistência Veterinária"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Private NavPaneMenu As TD.Eyefinder.NavigationBar
    'Controle dos forms abertos
    Private forms As ListDictionary
    Private xLocalMachineName As String
    Private xAppServerName As String
    Private xAppServerIp As String
    Private xVersaoDrive As String
    Private xLocalMachineIp As String
    Private xVersao As String
    Private newWidth As Integer = 1024
    Private newHeight As Integer = 768
    Private originalBitsPerPixel As Long
    Private originalWidth As Integer
    Private originalHeight As Integer
    Private wMudaResolution As Boolean = False
    Private wUltimoConnectionString As String

#Region "Constructores"
    Dim wComando As SqlCommand
    Private Sub InitializeListDictionary()
        forms = New ListDictionary
    End Sub
#End Region

#Region " Inicializações "

    Private Sub Principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim wControle As Integer
        Dim wTmp() As String
        Dim f As Integer

        Try
            AjustaTela(Me)
            Timer1.Start()

            Dim strSetting As New System.Configuration.AppSettingsReader
            VariaveisGlobais.gConnectionString = CStr(strSetting.GetValue("ConnectionString", GetType(System.String)))

            xLocalMachineName = System.Environment.MachineName
            Dim ipEntry As System.Net.IPHostEntry
            Dim IpAddr As System.Net.IPAddress()
            ipEntry = System.Net.Dns.GetHostEntry(xLocalMachineName)
            IpAddr = ipEntry.AddressList

            Dim X As Integer = 0
            xLocalMachineIp = ""
            For X = 0 To ipEntry.AddressList.Length - 1
                If ipEntry.AddressList(X).AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                    xLocalMachineIp += ipEntry.AddressList(X).ToString & "¯"
                End If
            Next
            'wMens = "IPs Maquina Local: " & xLocalMachineIp & vbCrLf
            If xLocalMachineIp = "" Then
                Throw New Exception("Máquina do usuário não tem endereço de IPV4 !")
            End If

            'Busca DataHora do programa que está instalado na máquina.
            Try
                Dim xProgramPath As String = _
                System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & _
                "\FortalezaTec\WinASS\WinASS.exe"
                Dim data1 As DateTime = IO.File.GetLastWriteTime(xProgramPath)
                xVersao = "Versão de: " & data1
            Catch ex As Exception
            End Try

            If xLocalMachineIp Like "*192.168.3*" Then
                xAppServerName = "ETA2"
            ElseIf xLocalMachineIp Like "*192.168.0*" Then
                xAppServerName = "localhost"
            Else
                xAppServerName = "localhost"
            End If

            ipEntry = System.Net.Dns.GetHostEntry(xAppServerName)
            IpAddr = ipEntry.AddressList
            If IpAddr(0).AddressFamily = System.Net.Sockets.AddressFamily.InterNetworkV6 Then
                xAppServerIp = IpAddr(1).ToString
            Else
                xAppServerIp = IpAddr(0).ToString
            End If
            xAppServerIp = IpAddr(0).ToString()

            VariaveisGlobais.gConnectionString = VariaveisGlobais.gConnectionString.Replace("ETA", xAppServerName)

            Dim xPath As String = System.Environment.SystemDirectory.Substring(0, 2)
            If File.Exists(xPath & "\infBancosASS.txt") Then
                Dim a As New SelecionaBanco
                a.ShowDialog()
                a.Dispose()

                VariaveisGlobais.gConnectionString = VariaveisGlobais.gConnectionString.Replace("CTAASS", VariaveisGlobais.gBD)
            End If

            wTmp = Split(VariaveisGlobais.gConnectionString, ";")
            For f = 0 To UBound(wTmp)
                If UCase(Mid(wTmp(f), 1, Len("Data Source="))) = "DATA SOURCE=" Then
                    VariaveisGlobais.gConnectionStringServer = Mid(wTmp(f), Len("Data Source=") + 1)
                End If
                If UCase(Mid(wTmp(f), 1, Len("User ID="))) = "USER ID=" Then
                    VariaveisGlobais.gConnectionStringUsername = Mid(wTmp(f), Len("User ID=") + 1)
                End If
                If UCase(Mid(wTmp(f), 1, Len("Password="))) = "PASSWORD=" Then
                    VariaveisGlobais.gConnectionStringPassword = Mid(wTmp(f), Len("Password=") + 1)
                End If
            Next f

            wComando = New SqlCommand("", VariaveisGlobais.gConexao)
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Me.Close()
            End If

            Login()
            AtualizaDadosUsuario()

            wControle = objLeituras.BuscaParametros(VariaveisGlobais.gConexao)
            If wControle <> 0 Then
                objVariaveisGlobais.MostraErro()
                Me.Close()
            End If

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = ""
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            objVariaveisGlobais.MostraErro()
            Me.Close()
        End Try
    End Sub

    Public Sub AtualizaDadosUsuario()
        Dim wBanco As String = ""

        If wUltimoConnectionString <> VariaveisGlobais.gConnectionString OrElse _
                    Me.Text <> "ASS        Usuario - Login: " & _
                    VariaveisGlobais.gLoginUsuario & "   Tipo: " & _
                    VariaveisGlobais.gTipoUsuario & "   " & wBanco Then

            Me.Text = "ASS        Usuario - Login: " & _
                    VariaveisGlobais.gLoginUsuario & "   Tipo: " & _
                    VariaveisGlobais.gTipoUsuario  & "   " & wBanco

            wUltimoConnectionString = VariaveisGlobais.gConnectionString

            TopMenu.MenuItems.Clear()
            Menu.MenuItems.Clear()
            Me.CreateMenu()
            Me.InitializeListDictionary()

            For i As Integer = Me.MdiChildren.Length - 1 To 0 Step -1
                Me.MdiChildren(i).Close()
            Next

            Dim tempMenu As MenuItem = Nothing
            If Menu.MenuItems.Count > 0 Then
                tempMenu = Nothing
                tempMenu = New MenuItem(xVersao)
                Me.Menu.MenuItems(Menu.MenuItems.Count - 2).MenuItems.Add(tempMenu)
            End If

        End If
    End Sub

#End Region

    Public Sub Login()
        Dim a As New TelaLogin
        a.ShowDialog()
        a.Dispose()
    End Sub


#Region "(ShowForm | CloseFormReference) Tratamento da abertura de forms"

    Private Sub ShowForm(ByVal item As Fortaleza.BackOffice.IFortalezaAccessForm)
        'Faz o teste se foi clicado no Menu SAIR
        If item.Target = "Finaliza" Then
            End 'Finaliza a Execução do Projeto
        End If
        Dim openForm As Boolean = True
        Cursor = Cursors.WaitCursor
        Dim formType As Type = Type.GetType(item.Target)
        If Not formType Is Nothing Then

            Dim formMenu As Form = Activator.CreateInstance(formType)
            formMenu.Location = New Point(0, 0)
            formMenu.StartPosition = FormStartPosition.Manual
            If formMenu.Text = "" Then
                Dim wTmp() As String = Split(item.Target, ".")
                If wTmp.Length > 1 Then
                    formMenu.Text = wTmp(1)
                Else
                    formMenu.Text = wTmp(0)
                End If
            Else
                'formMenu.Text = item.Name
            End If

            If TypeOf formMenu Is CRUD Then
                CType(formMenu, CRUD).Nome = item.Name
                If TypeOf item Is MenuItem Then
                    'Adicionado para quando for MenuItem e não TreeNodeItem
                    CType(formMenu, CRUD).Nome = CType(item, MenuItem).Text
                End If
            End If

            If item.IsMdiChild Then
                formMenu.MdiParent = Me
            End If

            If item.IsModal Then
                formMenu.ShowDialog()
            Else
                If item.IsOnlyInstance Then
                    If (Not forms(formType.FullName) Is Nothing) Then
                        openForm = False
                    End If
                End If
                If (openForm) Then
                    formMenu.Show()
                    AddHandler formMenu.Closed, AddressOf Me.CloseFormReference
                    forms(formType.FullName) = formMenu

                    AdicionaMenuJanelas(formMenu)

                Else
                    For i As Integer = 0 To Me.MdiChildren.Length - 1
                        Dim c As String = Me.MdiChildren(i).Name
                        Dim v As String = formMenu.Name
                        If Me.MdiChildren(i).Name = formMenu.Name Then
                            Me.MdiChildren(i).BringToFront()
                            i = -1
                            Exit For
                        End If
                    Next
                End If
            End If
            If formMenu.Enabled = False Then
                formMenu.Close()
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub CloseFormReference(ByVal sender As Object, ByVal e As System.EventArgs)

        'Remove Form do Menu 'Janelas'
        If Not IsNothing(forms(sender.GetType().FullName)) Then
            Dim textCompare As String = CType(forms(sender.GetType().FullName), Form).Text
            'Menu
            If Menu.MenuItems.Count > 0 Then
                For Each menuItem As MenuItem In Menu.MenuItems(Menu.MenuItems.Count - 3).MenuItems
                    If menuItem.Text.Equals(textCompare) Then
                        Me.Menu.MenuItems(Menu.MenuItems.Count - 3).MenuItems.Remove(menuItem)
                        Exit For
                    End If
                Next
            End If

            forms.Remove(sender.GetType().FullName)
        End If
        AtualizaDadosUsuario()

    End Sub

    Private Sub AdicionaMenuJanelas(ByVal newForm As Form)

        If Menu.MenuItems.Count > 0 Then
            Dim tempMenu As MenuItem = Nothing
            tempMenu = New MenuItem(newForm.Text, AddressOf ProcuraMenu)
            Me.Menu.MenuItems(Menu.MenuItems.Count - 3).MenuItems.Add(tempMenu)
        End If

    End Sub

    Private Sub ProcuraMenu(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim tempMenu As MenuItem = CType(sender, MenuItem)

        Dim enumerator As IDictionaryEnumerator = forms.GetEnumerator()
        While (enumerator.MoveNext())
            Dim f As Form = enumerator.Value
            If (f.Text.Equals(tempMenu.Text)) Then

                f.Focus()
                If f.WindowState.Equals(FormWindowState.Minimized) Then
                    f.WindowState = FormWindowState.Normal
                End If
                Exit While
            End If
        End While
    End Sub

    Private Sub ProcuraMenuToolStrip(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim tempMenu As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        Dim enumerator As IDictionaryEnumerator = forms.GetEnumerator()
        While (enumerator.MoveNext())
            Dim f As Form = enumerator.Value
            If (f.Text.Equals(tempMenu.Text)) Then

                f.Focus()
                If f.WindowState.Equals(FormWindowState.Minimized) Then
                    f.WindowState = FormWindowState.Normal
                End If
                Exit While
            End If
        End While
    End Sub

#End Region

#Region "Menus"

#Region "Events"

    Private Sub Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowForm(CType(sender, FortalezaMenuItem))
    End Sub

    Private Sub NavigatePane_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ShowForm(CType(CType(sender, TreeView).SelectedNode, FortalezaTreeNode))
    End Sub

#End Region

#Region "Top Menu"

    Private Sub CreateMenu()

        Dim myDocument As New XmlDocument
        myDocument.Load("Menu.xml")

        myDocument.GetElementsByTagName("Item")
        Dim Nodes As XmlNodeList = myDocument.GetElementsByTagName("Item")
        For Each node As XmlNode In Nodes(0).ChildNodes
            CreateMenuItem(node)
        Next

        For i As Integer = 0 To TopMenu.MenuItems.Count - 4
            Dim aaa As MenuItem = TopMenu.MenuItems(i)
            If aaa.MenuItems.Count = 0 Then
                TopMenu.MenuItems(i).Enabled = False
            End If
        Next
        'CreateStaticMenu()
    End Sub


    Private Sub JanelaCascata(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    'Private Sub CreateStaticMenu()

    '    Dim mnuMenuItem As New MenuItem("Cascata", AddressOf JanelaCascata)
    '    Me.Menu.MenuItems.Add(mnuMenuItem)

    'End Sub

    Private Sub CreateMenuItem(ByVal node As XmlNode)

        If (node.HasChildNodes) Then
            Dim menuItem As New Fortaleza.BackOffice.FortalezaMenuItem(node.Attributes("Name").Value, AddressOf Menu_Click)
            menuItem.FillMenuItem(node)
            TopMenu.MenuItems.Add(menuItem)
            For Each nodeChild As XmlNode In node.ChildNodes
                'If (UtilizadorLogado.Habilitado(nodeChild.Attributes("Name").Value)) Then
                CreateMenuItems(menuItem, nodeChild)
                'End If
            Next
        Else
            TopMenu.MenuItems.Add(New Fortaleza.BackOffice.FortalezaMenuItem(node.Attributes("Name").Value, _
            AddressOf Menu_Click).FillMenuItem(node))
        End If
    End Sub

    Private Sub CreateMenuItems(ByVal mnuItem As Fortaleza.BackOffice.FortalezaMenuItem, ByVal node As XmlNode)
        'Dim x As String = CStr(node.Attributes("Target").Value).Substring(7, CStr(node.Attributes("Target").Value).Length - 7)
        Dim xx As String() = CStr(node.Attributes("Target").Value).Split(".")
        Dim we As Integer = VariaveisGlobais.gEmpresa
        Dim wf As Integer = VariaveisGlobais.gFilial
        Dim ws As Integer = VariaveisGlobais.gSetorUsuario
        Dim wt As String = VariaveisGlobais.gTipoUsuario
        Dim wu As String = VariaveisGlobais.gLoginUsuario
        If xx.Length = 1 OrElse VerificaPrograma(xx(1), ws, wt, wu) = True _
          OrElse xx(1) = "Finaliza" Then
            If (node.HasChildNodes) Then
                Dim menuItem As New Fortaleza.BackOffice.FortalezaMenuItem(node.Attributes("Name").Value, AddressOf Me.Menu_Click)
                menuItem.FillMenuItem(node)
                mnuItem.MenuItems.Add(menuItem)
                Dim nodeChild As XmlNode
                For Each nodeChild In node.ChildNodes
                    CreateMenuItems(menuItem, nodeChild)
                Next
            Else
                mnuItem.MenuItems.Add(New Fortaleza.BackOffice.FortalezaMenuItem(node.Attributes("Name").Value, AddressOf Me.Menu_Click).FillMenuItem(node))
            End If
        End If
    End Sub

#End Region

#Region "NavigatePane Menu"

    Public Sub CreateNavigationPane()

        Dim navigatePane As NavigationPane
        Dim treeView As TreeView

        Dim myDocument As New XmlDocument
        myDocument.Load("Menu.xml")

        Dim Nodes As XmlNodeList = myDocument.GetElementsByTagName("Item")

        For Each node As XmlNode In Nodes(0).ChildNodes
            navigatePane = New NavigationPane
            navigatePane.Name = node.Attributes("Name").Value
            If navigatePane.Name <> "Janelas" AndAlso navigatePane.Name <> "Sair" Then
                navigatePane.Text = node.Attributes("Name").Value ' & " Text"
                'navigatePane.SmallImage = ImageListMenu.Images(Convert.ToInt32(node.Attributes("Image").Value))

                treeView = New TreeView
                treeView.Name = "Trv_" + node.Name
                treeView.Dock = System.Windows.Forms.DockStyle.Fill
                AddHandler treeView.DoubleClick, AddressOf Me.NavigatePane_Click
                navigatePane.Controls.Add(treeView)
                'NavPaneMenu.Controls.Add(navigatePane)

                For Each nodeChild As XmlNode In node.ChildNodes
                    'CreateNavigationPaneItem(treeView, nodeChild)
                Next
            End If
        Next
    End Sub

#End Region

#End Region

#Region "StatusBar"

    Public Sub SetaStatusMsg(ByVal msgPainel1 As String, ByVal msgPainel2 As String)
        statusBar.Panels(0).Text = msgPainel1
        statusBar.Panels(1).Text = msgPainel2
    End Sub
#End Region

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        statusBar.Panels(1).Text = ConverteDataHoraParaString(Date.Now)
    End Sub

End Class
