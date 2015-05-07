Public Class FiliaisBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New FiliaisBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Filiais_Implem)
    End Function

    Public Function GetInstance() As Filiais_Implem
        Return CType(GetInstanceAsObject(), Filiais_Implem)
    End Function
    Public Shared Function GetFactory() As FiliaisBOFactory
        Return singleton
    End Function

End Class
