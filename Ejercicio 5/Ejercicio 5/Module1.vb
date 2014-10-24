Module Module1

    Dim hombre As Object

    Sub Main()
        Dim info(8) As String
        Dim dioses As String() =
            {"Zeus", "Hera", "Poseidon", "Dionisio", "Apolo", "Artemisa", "Hermes", "Atenea", "Ares"}

        Dim diosesGenero() As Boolean =
           {False, True, False, False, False, True, False, True, False}

        Dim diosesHijos As Integer() =
          {26, 28, 16, 34, 14, 26, 38, 12, 9}


        Console.WriteLine(generoPredominante(diosesGenero))
        Console.WriteLine()
        Console.WriteLine(diosaConMasHijos(dioses, diosesGenero, diosesHijos))
        Console.WriteLine()
        Console.WriteLine(promedioDeHijos(diosesHijos, diosesGenero))
        Console.WriteLine()
        info = infoDioses(dioses, diosesGenero, diosesHijos)
        For index = 0 To info.Length - 1
            Console.WriteLine(info(index))
        Next
        Console.WriteLine()
        masyFem(info, diosesGenero)

        Console.ReadLine()
    End Sub

    Function generoPredominante(ByVal pdiosesG() As Boolean) As String
        Dim hombre As Integer = 0
        Dim mujer As Integer = 0
        Dim result As String = ""
        For index = 0 To pdiosesG.Length - 1
            If pdiosesG(index) = True Then
                hombre = hombre + 1

            Else
                mujer = mujer + 1
            End If
        Next
        If hombre > mujer Then
            result = "El genero que predomina es masculino"
        Else
            result = "El genero que predomina es femenino"
        End If
        Return result

    End Function

    Function diosaConMasHijos(ByVal pdioses() As String, ByVal pdiosesG() As Boolean,
                                ByVal pdiosesH() As Integer) As String
        Dim mayor As Integer = 0
        Dim indiceM As Integer = 0
        Dim result As String = ""
        For index = 0 To pdiosesH.Length - 1
            If pdiosesG(index) = True Then
                If pdiosesH(index) > mayor Then
                    mayor = pdiosesH(index)
                    indiceM = index
                End If
            End If
            result = "La Diosa con mas hijos es: " & pdioses(indiceM)
        Next

        Return result
    End Function


    Function promedioDeHijos(ByVal pdiosesH() As Integer, ByVal pdiosesG() As Boolean) As String
        Dim sumaHijos As Integer = 0
        Dim promedio As Integer = 0
        Dim result As String = ""
        Dim contadorM As Integer = 0

        For index = 0 To pdiosesH.Length - 1
            If pdiosesG(index) = False Then
                sumaHijos = sumaHijos + pdiosesH(index)
                contadorM = contadorM + 1
            End If
        Next
        promedio = sumaHijos / contadorM
        result = "El promedio de los hijos de los Dioses es de: " & promedio
        Return result
    End Function
    Function infoDioses(ByVal pdioses() As String, ByVal pdiosesG() As Boolean,
                                ByVal pdiosesH() As Integer) As String()
        Dim info(8) As String
        Dim genero As String

        For index = 0 To pdiosesH.Length - 1
            If pdiosesG(index) = True Then
                genero = "femenino"
                info(index) = pdioses(index) & "," & genero & "," & pdiosesH(index)

            Else
                genero = "masculino"
                info(index) = pdioses(index) & "," & genero & "," & pdiosesH(index)
            End If
        Next

        Return info
    End Function

    Function masyFem(ByVal pinfo() As String, ByVal pdiosesG() As Boolean) As String
        Dim arrMas(5) As String
        Dim arrFem(5) As String
        Dim contF As Integer = 0
        Dim contM As Integer = 0
        For index = 0 To pinfo.Length - 1
            If pdiosesG(index) = True Then
                arrFem(contF) = pinfo(index)
                contF = contF + 1
            Else
                arrMas(contM) = pinfo(index)
                contM = contM + 1
            End If
        Next
        For index = 0 To arrFem.Length - 1
            Console.WriteLine(arrFem(index))
        Next
        For index = 0 To arrMas.Length - 1
            Console.WriteLine(arrMas(index))
        Next
        Return Nothing
    End Function

End Module