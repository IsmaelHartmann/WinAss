Public Class PrefeiturasBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New PrefeiturasBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Prefeituras_Implem)
    End Function

    Public Function GetInstance() As Prefeituras_Implem
        Return CType(GetInstanceAsObject(), Prefeituras_Implem)
    End Function
    Public Shared Function GetFactory() As PrefeiturasBOFactory
        Return singleton
    End Function

End Class
