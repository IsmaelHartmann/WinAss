Public Module ValoresPorExtenso

    Function unidades(ByVal num)
        Dim vet_unidades, str, aux
        vet_unidades = "Um,Dois,Tres,Quatro,Cinco,Seis,Sete,Oito,Nove,Dez,Onze,Doze,Treze,Quatorze,Quinze, Dezesseis,Dezessete,Dezoito,Dezenove".Split(",")
        aux = Right(num, 2)
        If Int(aux) < 20 Then
            If Int(aux) > 0 Then
                str = vet_unidades(Int(aux) - 1)
            Else
                str = ""
            End If
        Else
            str = vet_unidades(Int(Right(num, 1)) - 1)
        End If
        unidades = str
    End Function
    Function dezenas(ByVal num)
        Dim vet_dezenas, aux, str
        vet_dezenas = "vbNullString,Vinte,Trinta,Quarenta,Cinquenta,Sessenta,Setenta,Oitenta,Noventa".Split(",")

        aux = Right(num, 2)
        aux = Left(aux, 1)
        If Len(num) >= 2 Then
            If Int(aux) >= 2 Then
                str = vet_dezenas(Int(aux) - 1)
                If Right(num, 1) > 0 Then
                    str = str & " e " & unidades(num)
                End If
            Else
                str = unidades(num)
            End If
        Else
            str = unidades(num)
        End If
        dezenas = str
    End Function
    Function centenas(ByVal num, ByVal Numero)
        Dim vet_Centenas, aux, str
        vet_Centenas = "Cem,Duzentos,Trezentos,Quatrocentos,Quinhentos,Seiscentos,Setecentos,Oitocentos,Novecentos".Split(",")
        If Int(num) > 99 Then
            aux = Right(num, 3)
            aux = Left(aux, 1)
            If Int(Right(num, 2)) > 0 Then
                vet_Centenas(0) = "Cento"
            End If
            str = vet_Centenas(aux - 1)
            If Int(Right(num, 2)) > 0 Then
                str = str & " e "
            End If
        Else
            str = ""
        End If
        centenas = str & dezenas(num)
    End Function
    Function milhares(ByVal num, ByVal Numero)
        Dim str, aux, auxstr
        aux = Right(Numero, 3)
        aux = Left(aux, 1)
        If Int(Right(Numero, 3)) > 0 Then
            auxstr = " e "
        Else
            auxstr = ""
        End If
        If Int(num) <> 0 Then
            str = centenas(num, Numero) & " Mil" & auxstr
        Else
            str = ""
        End If
        milhares = str
    End Function
    Function milhoes(ByVal num, ByVal Numero)
        Dim str, aux, strmilhao
        aux = Int(num)
        If aux > 0 Then
            If aux = 1 Then
                strmilhao = "Milhao,"
            Else
                strmilhao = "Milhoes,"
            End If
            str = centenas(num, Numero) & " " & strmilhao & " "
        Else
            str = ""
        End If
        milhoes = str
    End Function
    Function bilhoes(ByVal num, ByVal Numero)
        Dim str, aux, strbilhao
        aux = Int(num)
        If aux > 0 Then
            If aux = 1 Then
                strbilhao = "Bilhao,"
            Else
                strbilhao = "Bilhoes,"
            End If
            str = centenas(num, Numero) & " " & strbilhao & " "
        Else
            str = ""
        End If
        bilhoes = str
    End Function
    Function centavos(ByVal num)
        Dim str, strcent
        num = "0" & num
        If Int(num) > 0 Then
            If Int(num) = 1 Then
                strcent = " Centavo"
            Else
                strcent = " Centavos"
            End If
            str = centenas(num, num) & strcent
        Else
            str = ""
        End If
        centavos = str
    End Function
    Function extenso(ByVal num, ByVal xmoney)
        Dim sizenum, strsinal, inteiro, cents, aux_array, aux, bilhar, milhao, milhar, centena
        Dim strreal, strvirgula
        Dim strextenso

        num = Replace(num, ".", "")
        aux_array = Split(num, ",")
        If num = "" Then
            extenso = ""
            Exit Function
        End If
        If UBound(aux_array) > 0 Then
            inteiro = aux_array(0)
            cents = Left(aux_array(1), 2)
        Else
            inteiro = aux_array(0)
            cents = "00"
        End If
        If InStr(1, inteiro, "-") > 0 Then
            inteiro = Right(inteiro, Len(inteiro) - 1)
            strsinal = "Menos "
        Else
            strsinal = ""
        End If
        sizenum = Len(inteiro)

        aux = Microsoft.VisualBasic.Format(inteiro, "000000000000").Substring(0, 12 - sizenum)
        inteiro = aux & inteiro
        bilhar = Mid(inteiro, 1, 3)
        milhao = Mid(inteiro, 4, 3)
        milhar = Mid(inteiro, 7, 3)
        centena = Mid(inteiro, 10, 3)
        If Mid(inteiro, 10, 3) = 1 Then
            strreal = " Real "
        Else
            If Int(inteiro) = 0 Then
                strreal = ""
            Else
                strreal = " Reais "
            End If
        End If
        If xmoney = "" Then
            If Int(cents) > 0 And Int(inteiro) > 0 Then
                strvirgula = "e "
            Else
                strvirgula = ""
            End If
        Else
            If Int(cents) > 9 Then
                strvirgula = " Virgula "
            ElseIf Int(cents) > 0 Then
                strvirgula = " Virgula Zero "
            Else
                strvirgula = ""
            End If
        End If

        strextenso = bilhoes(bilhar, inteiro)
        strextenso = strextenso & milhoes(milhao, inteiro)
        strextenso = strextenso & milhares(milhar, inteiro)
        strextenso = strextenso & centenas(centena, inteiro)
        strextenso = strsinal & strextenso
        If xmoney = "" Then
            strextenso = strextenso & strreal & strvirgula & centavos(cents)
        Else
            strextenso = strextenso & strvirgula & centenas("0" & cents, "0" & cents)
        End If
        extenso = strextenso
    End Function

End Module
