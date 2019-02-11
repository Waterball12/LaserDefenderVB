Public Interface IServiceProvider

    Sub AddService(Of T)(Optional ByVal service As Object = Nothing)
    Function GetService(Of T)() As T
    Sub Initialize()

End Interface
