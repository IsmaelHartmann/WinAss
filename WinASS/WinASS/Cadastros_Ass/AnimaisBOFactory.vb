Public Class AnimaisBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New AnimaisBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Animais_Implem)
    End Function

    Public Function GetInstance() As Animais_Implem
        Return CType(GetInstanceAsObject(), Animais_Implem)
    End Function
    Public Shared Function GetFactory() As AnimaisBOFactory
        Return singleton
    End Function

End Class
