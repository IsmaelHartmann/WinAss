Public Class EmpresasBOFactory
    Inherits Fortaleza.Factory

    Private Shared singleton As New EmpresasBOFactory

    Public Overrides Function GetObjectType() As System.Type
        'typeof(Diagramas_Implem)
        Return GetType(Empresas_Implem)
    End Function

    Public Function GetInstance() As Empresas_Implem
        Return CType(GetInstanceAsObject(), Empresas_Implem)
    End Function
    Public Shared Function GetFactory() As EmpresasBOFactory
        Return singleton
    End Function

End Class
