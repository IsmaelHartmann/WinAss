Public Class MovPrefeiturasBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New MovPrefeiturasBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(MovPrefeituras_Implem)
    End Function

    Public Function GetInstance() As MovPrefeituras_Implem
        Return CType(GetInstanceAsObject(), MovPrefeituras_Implem)
    End Function
    Public Shared Function GetFactory() As MovPrefeiturasBOFactory
        Return singleton
    End Function

End Class
