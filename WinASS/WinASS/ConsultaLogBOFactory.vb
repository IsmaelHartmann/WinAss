Public Class ConsultaLogBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New ConsultaLogBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(ConsultaLog_Implem)
    End Function

    Public Function GetInstance() As ConsultaLog_Implem
        Return CType(GetInstanceAsObject(), ConsultaLog_Implem)
    End Function
    Public Shared Function GetFactory() As ConsultaLogBOFactory
        Return singleton
    End Function

End Class
