Public Class UsuariosBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New UsuariosBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Usuarios_Implem)
    End Function

    Public Function GetInstance() As Usuarios_Implem
        Return CType(GetInstanceAsObject(), Usuarios_Implem)
    End Function
    Public Shared Function GetFactory() As UsuariosBOFactory
        Return singleton
    End Function

End Class
