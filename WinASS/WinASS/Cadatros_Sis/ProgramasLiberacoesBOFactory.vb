Public Class ProgramasLiberacoesBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New ProgramasLiberacoesBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(ProgramasLiberacoes_Implem)
    End Function

    Public Function GetInstance() As ProgramasLiberacoes_Implem
        Return CType(GetInstanceAsObject(), ProgramasLiberacoes_Implem)
    End Function
    Public Shared Function GetFactory() As ProgramasLiberacoesBOFactory
        Return singleton
    End Function

End Class
