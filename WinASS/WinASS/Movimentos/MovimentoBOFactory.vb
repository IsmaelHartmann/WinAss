Public Class MovimentoBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New MovimentoBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Movimento_Implem)
    End Function

    Public Function GetInstance() As Movimento_Implem
        Return CType(GetInstanceAsObject(), Movimento_Implem)
    End Function
    Public Shared Function GetFactory() As MovimentoBOFactory
        Return singleton
    End Function

End Class
