Module Module1
    'ESTE EJEMPLO MUESTRA COMO SE DEBERIA CODIFICAR CADA UNA DE LAS ESTRUCTURAS
    'DE CONTROL
    Sub Main()
        Dim valor As String = ""
        Dim nombre As String = ""
        Dim edad As Integer = 0
        Dim estCivil As Char
        Dim estado As String = ""
        Dim condicion As String = ""
        Dim animales As String = ""
        Dim resul As String
        Dim resultado As String = ""

        '------------------------------------------------------------------
        'ESTRUCTURA WHILE.
        'CICLO CONDICIONAL, CONTROL APOYADO EN CENTINELA.
        'MIENTRAS EL USUARIO NO DIGITE LA LETRA q, SE PROCESAN MAS PERSONAS
        '------------------------------------------------------------------
        Console.WriteLine("Deme su nombre (presione la letra q para salir): ")
        nombre = Console.ReadLine()
        While (nombre <> "q")
            Console.WriteLine("Deme su edad:")
            edad = CType(Console.ReadLine(), Integer)
            Do 'ESTRUCTURA DO-LOOP. CICLO CONDICIONAL PARA CAPTURAR EL DATO s,c,d
                Console.WriteLine("Seleccione el estado civil (digite s,c,d)" & vbCrLf & "s->soltero " & vbCrLf & "c->casado" & vbCrLf & "d->divorciado")
                valor = Console.ReadLine()
                estCivil = valor.ElementAt(0)
            Loop Until (estCivil = "s" Or estCivil = "d" Or estCivil = "c")

            'ESTRUCTURA SELECT CASE 
            'SELECCION MULTIPLE SIN LA OPCION CASE ELSE.
            'SE GARANTIZA QUE SE EJECUTE ALGUNO DE LOS CASOS
            'GRACIAS AL DO-WHILE ANTERIOR

            Select Case estCivil
                Case "s"
                    estado = "solterito y sin compromiso"
                    condicion = "felicidad absoluta"
                Case "c"
                    estado = "casado y lleno de problemas"
                    condicion = "como estudiante de software, trabajando duro y sin horario"
                Case "d"
                    estado = "divorciado y contento"
                    condicion = "como desarrollador de software," & vbCrLf & vbTab & vbTab & "que ya salio de la U. " & vbCrLf & vbTab & "ganando plata y contento"
            End Select 'CIERRA EL SELECT
            '-------------------------------------------------------------------
            'ESTRUCTURA IF ELSE ANIDADO
            'SELECCION DOBLE CON ANIDAMIENTO DE OTRA SELECCION DOBLE
            'EN LA RAMA DEL NO
            '--------------------------------------------------------------------
            If edad >= 40 Then
                resul = "entraste a tu segunda juventud!!"
            Else
                If edad >= 18 Then
                    resul = "ya no queires jaranas con las pensiones"
                Else
                    resul = "estas de chupon"
                End If
            End If 'CIERRA EL IF-ELSE EXTERNO
            '---------------------------------------------------------------------
            'ESTRUCTURA FOR
            'CICLO CONDICIONAL PARA SOLICITAR 3 ANIMALES
            '---------------------------------------------------------------------
            animales = ""
            Console.WriteLine("Indica 3 animales que te agraden")
            For numAnimales As Integer = 1 To 3
                animales = animales & "Nombre del animal: " & Console.ReadLine()
                animales = animales & ", "
            Next
            resultado = resultado & vbCrLf & "============================================" & vbCrLf
            resultado = resultado & "Nombre:" & nombre & vbCrLf
            resultado = resultado & "Edad:" & edad & vbCrLf
            resultado = resultado & "Estado civil:" & estado & vbCrLf
            resultado = resultado & "Por tu edad:" & resul & vbCrLf
            resultado = resultado & "Por tu estado:" & condicion & vbCrLf
            resultado = resultado & "Animales que te agradan: " & vbCrLf
            resultado = resultado & animales & vbCrLf
            resultado = resultado & "============================================" & vbCrLf
            Console.WriteLine(resultado)
            Console.WriteLine("Deme su nombre (Presione la letra q para salir): ")
            nombre = Console.ReadLine()
        End While 'CIERRA EL WHILE
        Console.WriteLine("Terminamos, chao")
        Console.ReadLine()
    End Sub

End Module
