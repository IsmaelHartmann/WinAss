Public Class AssociadosBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New AssociadosBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Associados_Implem)
    End Function

    Public Function GetInstance() As Associados_Implem
        Return CType(GetInstanceAsObject(), Associados_Implem)
    End Function
    Public Shared Function GetFactory() As AssociadosBOFactory
        Return singleton
    End Function

End Class
