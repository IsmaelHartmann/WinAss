Public Class ParametrosBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New ParametrosBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Parametros_Implem)
    End Function

    Public Function GetInstance() As Parametros_Implem
        Return CType(GetInstanceAsObject(), Parametros_Implem)
    End Function
    Public Shared Function GetFactory() As ParametrosBOFactory
        Return singleton
    End Function

End Class
