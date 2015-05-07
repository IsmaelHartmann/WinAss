Public Class Valores_Prefeituras_TipoServicoBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New Valores_Prefeituras_TipoServicoBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Valores_Prefeituras_TipoServico_Implem)
    End Function

    Public Function GetInstance() As Valores_Prefeituras_TipoServico_Implem
        Return CType(GetInstanceAsObject(), Valores_Prefeituras_TipoServico_Implem)
    End Function
    Public Shared Function GetFactory() As Valores_Prefeituras_TipoServicoBOFactory
        Return singleton
    End Function

End Class
