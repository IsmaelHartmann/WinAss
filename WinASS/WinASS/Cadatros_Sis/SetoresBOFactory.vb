Public Class SetoresBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New SetoresBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Setores_Implem)
    End Function

    Public Function GetInstance() As Setores_Implem
        Return CType(GetInstanceAsObject(), Setores_Implem)
    End Function
    Public Shared Function GetFactory() As SetoresBOFactory
        Return singleton
    End Function

End Class
