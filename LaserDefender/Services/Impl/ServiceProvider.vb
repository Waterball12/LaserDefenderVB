Public Class ServiceProvider
    Implements IServiceProvider

    Private _serviceCollection As New Dictionary(Of Type, Object)

    Public Sub AddService(Of T)(Optional ByVal service As Object = Nothing) Implements IServiceProvider.AddService
        _serviceCollection.Add(GetType(T), service)
    End Sub

    Public Function GetService(Of T)() As T Implements IServiceProvider.GetService

        Dim Service = Nothing

        _serviceCollection.TryGetValue(GetType(T), value:=Service)

        Return Service
    End Function

    ' TODO improve args, since if a class require an arg not initializated is gonna fail, this mean each class should be initialized tadily
    Public Sub Initialize() Implements IServiceProvider.Initialize
        For index = 0 To _serviceCollection.Count - 1

            Dim element = _serviceCollection.ElementAt(index)

            If element.Value Is Nothing Then

                Dim args = New List(Of Object)

                Dim contstructor = element.Key.GetConstructors()(0)

                Dim constructorParams = contstructor.GetParameters().Select(Of Object)(Function(x) x.ParameterType).ToArray()

                For Each arg In constructorParams
                    Dim srv = Nothing
                    _serviceCollection.TryGetValue(arg, srv)
                    args.Add(srv)
                Next

                Dim instance = contstructor.Invoke(args.ToArray())

                _serviceCollection(element.Key) = instance

            End If
        Next
    End Sub
End Class
