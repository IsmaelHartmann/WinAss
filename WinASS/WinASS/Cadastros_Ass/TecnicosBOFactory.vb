Public Class TecnicosBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New TecnicosBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Tecnicos_Implem)
    End Function

    Public Function GetInstance() As Tecnicos_Implem
        Return CType(GetInstanceAsObject(), Tecnicos_Implem)
    End Function
    Public Shared Function GetFactory() As TecnicosBOFactory
        Return singleton
    End Function

End Class
