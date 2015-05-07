Public Class EstadosBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New EstadosBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Estados_Implem)
    End Function

    Public Function GetInstance() As Estados_Implem
        Return CType(GetInstanceAsObject(), Estados_Implem)
    End Function
    Public Shared Function GetFactory() As EstadosBOFactory
        Return singleton
    End Function

End Class
