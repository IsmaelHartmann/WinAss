Public Class TiposServicosBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New TiposServicosBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(TiposServicos_Implem)
    End Function

    Public Function GetInstance() As TiposServicos_Implem
        Return CType(GetInstanceAsObject(), TiposServicos_Implem)
    End Function
    Public Shared Function GetFactory() As TiposServicosBOFactory
        Return singleton
    End Function

End Class
