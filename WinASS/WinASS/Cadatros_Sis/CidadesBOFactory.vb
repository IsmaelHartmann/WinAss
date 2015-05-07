Public Class CidadesBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New CidadesBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Cidades_Implem)
    End Function

    Public Function GetInstance() As Cidades_Implem
        Return CType(GetInstanceAsObject(), Cidades_Implem)
    End Function
    Public Shared Function GetFactory() As CidadesBOFactory
        Return singleton
    End Function

End Class
