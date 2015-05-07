Public Class TiposAssistenciasBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New TiposAssistenciasBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(TiposAssistencias_Implem)
    End Function

    Public Function GetInstance() As TiposAssistencias_Implem
        Return CType(GetInstanceAsObject(), TiposAssistencias_Implem)
    End Function
    Public Shared Function GetFactory() As TiposAssistenciasBOFactory
        Return singleton
    End Function

End Class
