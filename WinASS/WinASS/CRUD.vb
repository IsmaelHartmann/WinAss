Public Class CRUD
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Me.Text = "CRUD"
    End Sub

#End Region


#Region "Atributos"
    Private nomeCRUD As String
    Private alterarCRUD As Boolean


#End Region
    	

#Region "Proprierties"



    Public Property Nome() As String
        Get
            Return nomeCRUD
        End Get
        Set(ByVal Value As String)
            nomeCRUD = Value
        End Set
    End Property
		
    Public Property Alterar() As Boolean
        Get
            Return alterarCRUD
        End Get
        Set(ByVal Value As Boolean)
            alterarCRUD = Value
        End Set
    End Property

#End Region

End Class
