Public Class ProgramasBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New ProgramasBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Programas_Implem)
    End Function

    Public Function GetInstance() As Programas_Implem
        Return CType(GetInstanceAsObject(), Programas_Implem)
    End Function
    Public Shared Function GetFactory() As ProgramasBOFactory
        Return singleton
    End Function

End Class
