Imports Microsoft.Win32
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Module GenProc
    ' Public gMovendo As Boolean = False
    Public objVariaveisGlobais As New VariaveisGlobais
    Public objLeituras As New Leituras
    
    Public Function ConverteDataTipoDateStringSQL(ByVal pData As DateTime)

        Return ConverteDataStringSQL(ConverteDataParaString(pData))

    End Function

    Public Function UnMaskBS(ByVal pString As String) As String
        'Un Mask when string blank
        Return pString.Replace("/", "").Replace("-", "").Replace(":", "").Replace("(", "") _
                .Replace(")", "").Replace(" ", "").Replace(",", "").Replace("_", "") _
                .Replace(".", "")

    End Function

    Public Function VerificaDigitoBarra(ByVal pCodigoBarra As String) As Boolean
        If IsNumeric(pCodigoBarra) Then
            'And pCodigoBarra.Length <> 13
            If pCodigoBarra.Length <> 8 And pCodigoBarra.Length <> 12 _
                And pCodigoBarra.Length <> 13 And pCodigoBarra.Length <> 14 And pCodigoBarra.Length <> 18 Then
                Return False
            End If
            Dim Digito As String = pCodigoBarra.Substring(pCodigoBarra.Length - 1, 1)
            pCodigoBarra = pCodigoBarra.Substring(0, pCodigoBarra.Length - 1)
            Dim Fator As Integer = 3
            Dim Sum As Integer = 0

            While pCodigoBarra.Length > 0
                Sum = Sum + (pCodigoBarra.Substring(pCodigoBarra.Length - 1, 1) * Fator)
                Fator = 4 - Fator
                pCodigoBarra = pCodigoBarra.Substring(0, pCodigoBarra.Length - 1)
            End While
            If ((1000 - Sum) Mod 10) <> Digito Then
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If

    End Function

    Public Function IsCNPJ(ByVal pCnpj As String) As Boolean
        pCnpj = UnMaskBS(pCnpj)
        If pCnpj.Length <> 14 Then
            Return False
        End If
        Dim Numero(14) As Integer
        Dim x As Integer
        Dim soma As Double
        Dim resultado1 As Double
        Dim resultado2 As Double

        For x = 1 To 14
            Numero(x) = CInt(Mid(pCnpj, x, 1))
        Next

        soma = ((5 * Numero(1)) + (4 * Numero(2)) + (3 * Numero(3)) + (2 * Numero(4)) + (9 * Numero(5)) + (8 * Numero(6)) + (7 * Numero(7)) + (6 * Numero(8)) + (5 * Numero(9)) + (4 * Numero(10)) + (3 * Numero(11)) + (2 * Numero(12)))
        soma = soma - (11 * (Int(soma / 11)))

        If ((soma = 0) Or (soma = 1)) Then
            resultado1 = 0
        Else
            resultado1 = (11 - soma)
        End If

        If (resultado1 = Numero(13)) Then
            soma = ((6 * Numero(1)) + (5 * Numero(2)) + (4 * Numero(3)) + (3 * Numero(4)) + (2 * Numero(5)) + (9 * Numero(6)) + (8 * Numero(7)) + (7 * Numero(8)) + (6 * Numero(9)) + (5 * Numero(10)) + (4 * Numero(11)) + (3 * Numero(12)) + (2 * Numero(13)))
            soma = soma - (11 * (Int(soma / 11)))

            If ((soma = 0) Or (soma = 1)) Then
                resultado2 = 0
            Else
                resultado2 = (11 - soma)
            End If

            If (resultado2 = Numero(14)) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Public Function IsCPF(ByVal pCPf As String) As Boolean
        pCPf = UnMaskBS(pCPf)
        If pCPf.Length <> 11 Then
            Return False
        End If
        Dim Numero(11) As Integer
        Dim x As Integer
        Dim soma As Double
        Dim resultado1 As Double
        Dim resultado2 As Double

        For x = 1 To 11
            Numero(x) = CInt(Mid(pCPf, x, 1))
        Next

        soma = ((10 * Numero(1)) + (9 * Numero(2)) + (8 * Numero(3)) + (7 * Numero(4)) + (6 * Numero(5)) + (5 * Numero(6)) + (4 * Numero(7)) + (3 * Numero(8)) + (2 * Numero(9)))
        soma = soma - (11 * (Int(soma / 11)))

        If ((soma = 0) Or (soma = 1)) Then
            resultado1 = 0
        Else
            resultado1 = (11 - soma)
        End If

        If (resultado1 = Numero(10)) Then
            soma = ((Numero(1) * 11) + (Numero(2) * 10) + (Numero(3) * 9) + (Numero(4) * 8) + (Numero(5) * 7) + (Numero(6) * 6) + (Numero(7) * 5) + (Numero(8) * 4) + (Numero(9) * 3) + (Numero(10) * 2))
            soma = soma - (11 * (Int(soma / 11)))

            If ((soma = 0) Or (soma = 1)) Then
                resultado2 = 0
            Else
                resultado2 = (11 - soma)
            End If

            If (resultado2 = Numero(11)) Then
                Return True
            Else
                Return False
            End If

        Else
            Return False
        End If

    End Function

    Public Function ConverteDataStringSQL(ByVal pData As String)
        '
        ' Transforma string dd/mm/yyyy em string yyyy-mm-dd

        'UTILIZANDO SET DATEFORMAT=dmy nao precisa formatar a Data brasileira
        'Return pData

        Dim myArray()
        myArray = pData.Split("/")
        Dim iDay = IIf(Len(myArray(0)) = 1, "0", "") & myArray(0)
        Dim iMonth = IIf(Len(myArray(1)) = 1, "0", "") & myArray(1)
        Dim iYear = myArray(2)

        Return iYear & "/" & iMonth & "/" & iDay

    End Function

    Public Function ConverteStringParaData(ByVal pDataString As String)
        '
        ' Transforma string dd/mm/yyyy em Data do .NET
        If Len(pDataString) < 10 Then
            pDataString = ConverteDataParaString(Today)
        End If

        Dim myArray = pDataString.Split("/")

        Dim iDay = myArray(0)
        Dim iMonth = myArray(1)
        Dim iYear = myArray(2)

        ConverteStringParaData = New Date(iYear, iMonth, iDay)

    End Function

    Public Function ConverteDataParaString(ByVal pData As String)
        '
        ' Transforma string Data do .NET em string dd/mm/yyyy
        If Len(pData) = 0 OrElse pData = "Null" Then
            ConverteDataParaString = ""
        Else
            pData = CDate(pData)
            ConverteDataParaString = IIf(Len(CStr(Microsoft.VisualBasic.Day(pData))) = 1, "0" & CStr(Microsoft.VisualBasic.Day(pData)), CStr(Microsoft.VisualBasic.Day(pData))) & "/" & _
                                 IIf(Len(CStr(Month(pData))) = 1, "0" & CStr(Month(pData)), CStr(Month(pData))) & "/" & _
                                 IIf(Len(CStr(Year(pData))) = 2, "20" & CStr(Year(pData)), CStr(Year(pData)))
        End If
    End Function

    Public Function FormataFone(ByVal pFone As String)
        If Len(pFone) > 9 Then
            pFone = pFone.Insert(0, "(").Insert(3, ")").Insert(8, "-")
        ElseIf Len(pFone) > 8 Then
            pFone = pFone.Insert(0, "(").Insert(3, ")").Insert(7, "-")
        ElseIf Len(pFone) > 7 Then
            pFone = pFone.Insert(4, "-")
        ElseIf Len(pFone) > 6 Then
            pFone = pFone.Insert(3, "-")
        End If
        FormataFone = pFone
    End Function

    Public Function ConverteDataHoraParaString(ByVal pDataHora1 As String)
        '
        ' Transforma string Data do .NET em string dd/mm/yyyy
        If Len(pDataHora1) = 0 OrElse pDataHora1 = "Null" Then
            ConverteDataHoraParaString = ""
        Else
            Dim pDataHora As DateTime = pDataHora1
            ConverteDataHoraParaString = IIf(Len(CStr(Microsoft.VisualBasic.Day(pDataHora))) = 1, "0" & CStr(Microsoft.VisualBasic.Day(pDataHora)), CStr(Microsoft.VisualBasic.Day(pDataHora))) & "/" & _
                                 IIf(Len(CStr(Month(pDataHora))) = 1, "0" & CStr(Month(pDataHora)), CStr(Month(pDataHora))) & "/" & _
                                 IIf(Len(CStr(Year(pDataHora))) = 2, "20" & CStr(Year(pDataHora)), CStr(Year(pDataHora))) & " " & _
                                 IIf(Len(CStr(Hour(pDataHora))) = 1, "0" & CStr(Hour(pDataHora)), CStr(Hour(pDataHora))) & ":" & _
                                 IIf(Len(CStr(Minute(pDataHora))) = 1, "0" & CStr(Minute(pDataHora)), CStr(Minute(pDataHora)))
        End If
    End Function

    Public Function ConverteHoraParaString(ByVal pDataHora As String)
        If Len(pDataHora) = 0 OrElse pDataHora = "Null" Then
            ConverteHoraParaString = ""
        Else
            Dim pDataHora1 As DateTime = pDataHora

            ConverteHoraParaString = IIf(Len(CStr(Hour(pDataHora1))) = 1, "0" & CStr(Hour(pDataHora1)), CStr(Hour(pDataHora1))) & ":" & _
                         IIf(Len(CStr(Minute(pDataHora1))) = 1, "0" & CStr(Minute(pDataHora1)), CStr(Minute(pDataHora1)))
        End If
    End Function

    Public Function GetPapers(ByRef pCombo As ComboBox, ByRef pPd As PrintDocument) As Integer

        pCombo.Items.Clear()
        pCombo.Refresh()

        Dim wPName As String
        wPName = pPd.DefaultPageSettings.PaperSize.PaperName.ToString
        Dim cont As Integer = 0

        Dim c As New System.Web.UI.WebControls.ListItem
        Dim wPsz As PaperSize
        For Each wPsz In pPd.DefaultPageSettings.PrinterSettings.PaperSizes
            c = New System.Web.UI.WebControls.ListItem
            c.Value = wPsz.PaperName.ToString
            c.Text = wPsz.PaperName.ToString
            pCombo.Items.Add(c)

            If wPName = wPsz.PaperName.ToString Then
                cont = pCombo.Items.Count - 1
            End If
        Next
        pCombo.SelectedIndex = cont

    End Function

    Public Function ColocaNULLparaBanco(ByVal pString As String) As String
        '
        ' Coloca valor NULL na string se ela for ""

        If pString = "" Then
            ColocaNULLparaBanco = "NULL"
        Else
            ColocaNULLparaBanco = "'" & pString & "'"
        End If

    End Function

    Function NaoNull(ByVal pVar As String) As String
        NaoNull = IIf(pVar = "" OrElse pVar = "Null", "", "'" & pVar & "'")
    End Function

    Function BrancoNull(ByVal pVar) As String
        If IsDBNull(pVar) Then
            BrancoNull = "Null"
        Else
            pVar = CStr(pVar)
            BrancoNull = IIf(pVar = "" OrElse pVar = "Null", "Null", "'" & pVar & "'")
        End If
    End Function

    Function ZeroNull(ByVal pVar) As String
        If IsDBNull(pVar) Then
            pVar = 0
        ElseIf Not IsNumeric(pVar) Then
            pVar = 0
        End If
        ZeroNull = IIf(pVar = 0, "Null", " '" & ConverteDecBD(pVar) & "' ")
    End Function

    Function MoneyNull(ByVal pVar) As String
        If IsDBNull(pVar) Then
            pVar = 0
        ElseIf Not IsNumeric(pVar) Then
            pVar = 0
        End If
        MoneyNull = IIf(pVar = 0, "Null", "CAST('$" & ConverteDecBD(pVar) & "' AS MONEY)")
    End Function

    Function DataNull(ByVal pVar) As String
        If IsDBNull(pVar) Then
            DataNull = "Null"

        ElseIf IsDate(pVar) Then
            DataNull = "'" & CDate(pVar) & "'"
        Else
            DataNull = "Null"
        End If
    End Function

    Function HoraNull(ByVal pHora)
        If IsDBNull(pHora) Then
            HoraNull = "Null"
        ElseIf Len(pHora) = 0 OrElse pHora = "Null" Then
            HoraNull = "Null"
        Else
            Dim pDataHora1 As DateTime = pHora
            HoraNull = "'" & IIf(Len(CStr(Hour(pDataHora1))) = 1, "0" & CStr(Hour(pDataHora1)), CStr(Hour(pDataHora1))) & ":" & _
                         IIf(Len(CStr(Minute(pDataHora1))) = 1, "0" & CStr(Minute(pDataHora1)), CStr(Minute(pDataHora1))) & "'"
        End If
    End Function

    Function BooleanNull(ByVal pVar) As String
        If IsDBNull(pVar) Then
            BooleanNull = "Null"
        Else
            BooleanNull = IIf(pVar = False OrElse pVar = "" OrElse pVar = "Null" OrElse pVar = "0", "0", "1")
        End If
    End Function


    Function NullBranco(ByVal pVar) As String
        If IsDBNull(pVar) Then
            NullBranco = ""
        Else
            NullBranco = pVar
        End If
    End Function

    Function NullDecimal(ByVal pVar) As Decimal
        If IsDBNull(pVar) Then
            NullDecimal = 0
        Else
            NullDecimal = pVar
        End If
    End Function

    Function NullBoolean(ByVal pVar) As Boolean
        If IsDBNull(pVar) Then
            NullBoolean = False
        Else
            NullBoolean = IIf(pVar = 0, False, True)
        End If
    End Function



    Public Function ConverteValorFloatParaBancoDados(ByVal pValor As String) As String
        '
        ' Converte um valor tipo 1.334,21 para o formato correto
        ' de gravaçao no Banco de dados

        Dim wRetorno As String

        wRetorno = pValor.Replace(".", "")
        wRetorno = wRetorno.Replace(",", ".")

        Return wRetorno

    End Function

    Public Function ConverteDecBD(ByVal pValor As Decimal) As String
        Dim wRetorno As String

        Dim wValor As String = ConverteDecString(pValor)

        wRetorno = wValor.Replace(".", "")
        wRetorno = wRetorno.Replace(",", ".")

        Return wRetorno

    End Function

    Public Function ConverteDecimalPara2Dec(ByVal pValor As Decimal) As String

        Dim wRetorno As String = Format(pValor, "##########0.00")

        wRetorno = wRetorno.Replace(",", ".")

        Return wRetorno

    End Function

    Public Function FormataValoresEditText(ByVal pValor As String) As String

        Dim wRetorno As String

        If pValor.EndsWith(",00") Then
            wRetorno = pValor
        Else
            wRetorno = pValor & IIf(Strings.Right(pValor, 1) = "0" And InStr(pValor, ",") = 0, ",00", "")
        End If

        If wRetorno.StartsWith("R$") Then
            wRetorno = wRetorno.Substring(3)
        End If

        Return wRetorno

    End Function

    Public Function FormataValoresEditText3Casas(ByVal pValor As String) As String
        Dim wRetorno As String
        If pValor.EndsWith(",000") Then
            wRetorno = pValor
        Else
            wRetorno = pValor & IIf(Strings.Right(pValor, 1) = "0" And InStr(pValor, ",") = 0, ",000", "")
        End If

        If wRetorno.StartsWith("R$") Then
            wRetorno = wRetorno.Substring(3)
        End If
        Return wRetorno

    End Function

    Public Function ValidaCNPJ(ByVal pCnpj As String) As Boolean
        Dim Numero(14) As Integer
        Dim x As Integer
        Dim soma As Double
        Dim resultado1 As Double
        Dim resultado2 As Double

        For x = 1 To 14
            Numero(x) = CInt(Mid(pCnpj, x, 1))
        Next

        soma = ((5 * Numero(1)) + (4 * Numero(2)) + (3 * Numero(3)) + (2 * Numero(4)) + (9 * Numero(5)) + (8 * Numero(6)) + (7 * Numero(7)) + (6 * Numero(8)) + (5 * Numero(9)) + (4 * Numero(10)) + (3 * Numero(11)) + (2 * Numero(12)))
        soma = soma - (11 * (Int(soma / 11)))

        If ((soma = 0) Or (soma = 1)) Then
            resultado1 = 0
        Else
            resultado1 = (11 - soma)
        End If

        If (resultado1 = Numero(13)) Then
            soma = ((6 * Numero(1)) + (5 * Numero(2)) + (4 * Numero(3)) + (3 * Numero(4)) + (2 * Numero(5)) + (9 * Numero(6)) + (8 * Numero(7)) + (7 * Numero(8)) + (6 * Numero(9)) + (5 * Numero(10)) + (4 * Numero(11)) + (3 * Numero(12)) + (2 * Numero(13)))
            soma = soma - (11 * (Int(soma / 11)))

            If ((soma = 0) Or (soma = 1)) Then
                resultado2 = 0
            Else
                resultado2 = (11 - soma)
            End If

            If (resultado2 = Numero(14)) Then
                ValidaCNPJ = True
            Else
                ValidaCNPJ = False
            End If
        Else
            ValidaCNPJ = False
        End If

    End Function

    Public Function ValidaCPF(ByVal pCPf As String) As Boolean

        Dim Numero(11) As Integer
        Dim x As Integer
        Dim soma As Double
        Dim resultado1 As Double
        Dim resultado2 As Double

        For x = 1 To 11
            Numero(x) = CInt(Mid(pCPf, x, 1))
        Next

        soma = ((10 * Numero(1)) + (9 * Numero(2)) + (8 * Numero(3)) + (7 * Numero(4)) + (6 * Numero(5)) + (5 * Numero(6)) + (4 * Numero(7)) + (3 * Numero(8)) + (2 * Numero(9)))
        soma = soma - (11 * (Int(soma / 11)))

        If ((soma = 0) Or (soma = 1)) Then
            resultado1 = 0
        Else
            resultado1 = (11 - soma)
        End If

        If (resultado1 = Numero(10)) Then
            soma = ((Numero(1) * 11) + (Numero(2) * 10) + (Numero(3) * 9) + (Numero(4) * 8) + (Numero(5) * 7) + (Numero(6) * 6) + (Numero(7) * 5) + (Numero(8) * 4) + (Numero(9) * 3) + (Numero(10) * 2))
            soma = soma - (11 * (Int(soma / 11)))

            If ((soma = 0) Or (soma = 1)) Then
                resultado2 = 0
            Else
                resultado2 = (11 - soma)
            End If

            If (resultado2 = Numero(11)) Then
                ValidaCPF = True
            Else
                ValidaCPF = False
            End If

        Else
            ValidaCPF = False
        End If

    End Function

    Public Function ConverteStringParaDecimal(ByVal pString As String) As Decimal

        Dim wSeparadorVirgula As String = Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        Dim wSeparadorMilhar As String = Globalization.NumberFormatInfo.CurrentInfo.NumberGroupSeparator

        Dim wValor As String

        wValor = Decimal.Parse(pString.Replace(wSeparadorMilhar, "").Replace(",", wSeparadorVirgula))

        Return wValor

    End Function

    Public Function ConverteDecString(ByVal pDecimal As Decimal, Optional ByVal pFormato As String = "") As String

        Dim wSeparadorVirgula As String = Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        Dim wSeparadorMilhar As String = Globalization.NumberFormatInfo.CurrentInfo.NumberGroupSeparator

        Dim wValor As String

        wValor = pDecimal.ToString(pFormato).Replace(wSeparadorMilhar, "").Replace(",", wSeparadorVirgula)

        Return wValor
    End Function

    'Public Function CalculoDV10(ByVal strNumero As String) As String
    '    Dim intcontador, intNumero, intTotalNumero, intMultiplicador, intResto As Integer
    '    If Not IsNumeric(strNumero) Then
    '        CalculoDV10 = ""
    '        Exit Function
    '    End If

    '    intMultiplicador = 2
    '    For intcontador = Len(strNumero) To 1 Step -1
    '        intNumero = Val(Mid(strNumero, intcontador, 1)) * intMultiplicador
    '        If intNumero > 9 Then
    '            intNumero = Val(Left(intNumero, 1)) + Val(Right(intNumero, 1))
    '        End If

    '        intTotalNumero = intTotalNumero + intNumero
    '        intMultiplicador = IIf(intMultiplicador = 2, 1, 2)
    '    Next
    '    intResto = intTotalNumero Mod 10

    '    SELECT Case intResto
    '        Case 0
    '            CalculoDV10 = "0"
    '        Case Else
    '            CalculoDV10 = Str(intResto)
    '    End Select

    'End Function


    'Public Function CalculoDV11(ByVal strNumero As String) As String
    '    Dim intcontador, intNumero, intTotalNumero, intMultiplicador, intResto As Integer
    '    If Not IsNumeric(strNumero) Then
    '        CalculoDV11 = ""
    '        Exit Function
    '    End If

    '    intMultiplicador = 9
    '    For intcontador = Len(strNumero) To 1 Step -1
    '        intNumero = Val(Mid(strNumero, intcontador, 1)) * intMultiplicador
    '        intTotalNumero = intTotalNumero + intNumero
    '        intMultiplicador = IIf(intMultiplicador > 2, intMultiplicador - 1, 9)
    '    Next
    '    intResto = intTotalNumero Mod 11
    '    SELECT Case intResto
    '        Case 0
    '            CalculoDV11 = "0"
    '        Case 10
    '            CalculoDV11 = "X"
    '        Case Else
    '            CalculoDV11 = Str(intResto)
    '    End Select
    'End Function

    Public Function CalculoDV20(ByVal strNumero As String) As String
        Dim intcontador, intNumero, intTotalNumero, intMultiplicador, intResto, intResultado As Integer
        If Not IsNumeric(strNumero) Then
            CalculoDV20 = ""
            Exit Function
        End If

        intMultiplicador = 2
        For intcontador = Len(strNumero) To 1 Step -1
            intNumero = Val(Mid(strNumero, intcontador, 1)) * intMultiplicador
            intTotalNumero = intTotalNumero + intNumero
            intMultiplicador = IIf(intMultiplicador < 9, intMultiplicador + 1, 2)
        Next
        intResto = intTotalNumero Mod 11
        intResultado = 11 - intResto
        Select Case intResultado
            Case Is > 9
                CalculoDV20 = "0"
            Case Else
                CalculoDV20 = Str(intResultado).Trim
        End Select

    End Function

    Public Function CalculoDV23(ByVal strNumero As String) As String
        Dim intcontador, intNumero, intTotalNumero, intMultiplicador, intResto, intResultado As Integer
        If Not IsNumeric(strNumero) Then
            CalculoDV23 = ""
            Exit Function
        End If

        intMultiplicador = 2
        For intcontador = Len(strNumero) To 1 Step -1
            intNumero = Val(Mid(strNumero, intcontador, 1)) * intMultiplicador
            If intNumero > 9 Then
                intNumero -= 9
            End If
            intTotalNumero = intTotalNumero + intNumero
            intMultiplicador = IIf(intMultiplicador = 2, 1, 2)
        Next

        intResto = intTotalNumero Mod 10
        intResultado = 10 - intResto
        Select Case intResultado
            Case Is > 9
                CalculoDV23 = "0"
            Case Else
                CalculoDV23 = Str(intResultado).Trim
        End Select

    End Function

    Public Function CalculoDV24(ByVal strNumero As String, ByRef strDigito1 As String) As String
        Dim intcontador, intNumero, intTotalNumero, intMultiplicador, intResto, intResultado As Integer
        Dim strNumero1 As String
        If Not IsNumeric(strNumero) Then
            CalculoDV24 = ""
            Exit Function
        End If

        intMultiplicador = 2
        strNumero1 = strNumero & strDigito1
        For intcontador = Len(strNumero1) To 1 Step -1
            intNumero = Val(Mid(strNumero1, intcontador, 1)) * intMultiplicador
            intTotalNumero = intTotalNumero + intNumero
            intMultiplicador = IIf(intMultiplicador < 7, intMultiplicador + 1, 2)
        Next
        intResto = intTotalNumero Mod 11

        If intResto = "1" Then
            strDigito1 = Right((strDigito1 + 1), 1)
            intTotalNumero = 0
            intMultiplicador = 2
            strNumero1 = strNumero & strDigito1
            For intcontador = Len(strNumero1) To 1 Step -1
                intNumero = Val(Mid(strNumero1, intcontador, 1)) * intMultiplicador
                intTotalNumero = intTotalNumero + intNumero
                intMultiplicador = IIf(intMultiplicador < 7, intMultiplicador + 1, 2)
            Next
        End If

        intResto = intTotalNumero Mod 11
        intResultado = 11 - intResto

        Select Case intResultado
            Case Is > 9
                CalculoDV24 = "0"
            Case Else
                CalculoDV24 = Str(intResultado).Trim
        End Select

    End Function

    'Public Function CalculoNossoNumero(ByVal sequencia As String) As String
    '    Dim dv As Integer
    '    dv = CalculoDV11(sequencia)
    '    CalculoNossoNumero = Format(sequencia & dv, "00000000000000000")
    'End Function

    Public Function CalculoDVLinhaDigitavel(ByVal strNumero As String) As String
        Dim intcontador, intNumero, intTotalNumero, intMultiplicador, intResto, intResultado As Integer
        If Not IsNumeric(strNumero) Then
            CalculoDVLinhaDigitavel = ""
            Exit Function
        End If

        intMultiplicador = 2
        For intcontador = Len(strNumero) To 1 Step -1
            intNumero = Val(Mid(strNumero, intcontador, 1)) * intMultiplicador
            If intNumero > 9 Then
                intNumero = Val(Left(intNumero, 1)) + Val(Right(intNumero, 1))
            End If
            intTotalNumero = intTotalNumero + intNumero
            intMultiplicador = IIf(intMultiplicador = 2, 1, 2)
        Next
        intResto = intTotalNumero Mod 10
        intResultado = 10 - intResto

        Select Case intResultado
            Case 10
                CalculoDVLinhaDigitavel = "0"
            Case Else
                CalculoDVLinhaDigitavel = Str(intResultado)
        End Select

    End Function

    Public Function CalculoDVCodigoBarra(ByVal sequencia As String) As String
        Dim intcontador, intNumero, intTotalNumero, intMultiplicador, intResto, intResultado As Integer
        Dim caracter As String
        intMultiplicador = 2
        For intcontador = 1 To 43
            caracter = Mid(Right(sequencia, intcontador), 1, 1)
            If intMultiplicador > 9 Then
                intMultiplicador = 2
                intNumero = 0
            End If
            intNumero = caracter * intMultiplicador
            intTotalNumero = intTotalNumero + intNumero
            intMultiplicador = intMultiplicador + 1
        Next

        intResto = intTotalNumero Mod 11
        intResultado = 11 - intResto
        If intResultado = 10 Or intResultado = 11 Then
            CalculoDVCodigoBarra = 1
        Else
            CalculoDVCodigoBarra = intResultado
        End If

    End Function

    Public Function ValidaIE(ByVal sIE As String, ByVal sUF As String) As Integer
        Dim strIE As String, strUF As String, intRet As Integer
        strIE = SoNumero(sIE)
        strUF = UCase$(sUF)
        intRet = ConsisteInscricaoEstadual(strIE, strUF)

        If intRet = 0 Then
            Return intRet
        Else
            Return 1
        End If
    End Function

    Public Function SoNumero(ByVal sTexto As String) As String
        Dim l As Long, strRet As String = ""
        For l = 1 To Len(sTexto)
            If IsNumeric(Mid$(sTexto, l, 1)) Then strRet = strRet & Mid$(sTexto, l, 1)
        Next l
        SoNumero = strRet
    End Function

    Public Declare Function ConsisteInscricaoEstadual Lib "DllInscE32" (ByVal sIE As String, _
     ByVal sUF As String) As Integer

    Public Function VerificaPrograma(ByVal pPrograma As String, ByVal pSetor As String, _
         ByVal pTipo As String, ByVal pUsuario As String) As Boolean
        If pTipo = "A" Then
            VariaveisGlobais.gIncluir = True
            VariaveisGlobais.gAlterar = True
            VariaveisGlobais.gExcluir = True
            Return True
        End If

        Dim wComando As SqlCommand = New SqlCommand("", VariaveisGlobais.gConexao)
        Dim wDataReader As SqlDataReader
        '
        ' Valida login do usuario
        Dim wControle As Integer
        Try
            wControle = objVariaveisGlobais.VerificaConexaoBD(VariaveisGlobais.gConexao, VariaveisGlobais.gConnectionString)
            If wControle <> 0 Then Return wControle

            wComando.CommandText = "SELECT * FROM C_ProgramasLiberacoes " & _
                           " WHERE NomePrograma='" & pPrograma & "'" & _
                           " AND Usuario = '" & pUsuario & "'" & _
                           " AND CodigoSetor= '' " & _
                           " AND TipoUsuario= '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                VariaveisGlobais.gIncluir = IIf(IsDBNull(wDataReader("Incluir")), True, False)
                VariaveisGlobais.gAlterar = IIf(IsDBNull(wDataReader("Alterar")), True, False)
                VariaveisGlobais.gExcluir = IIf(IsDBNull(wDataReader("Excluir")), True, False)
                wDataReader.Close()
                Return True
            End If
            wDataReader.Close()

            wComando.CommandText = "SELECT * FROM C_ProgramasLiberacoes " & _
                " WHERE NomePrograma='" & pPrograma & "'" & _
                " AND CodigoSetor= '" & pSetor & "'" & _
                " AND TipoUsuario= '" & pTipo & "'" & _
                " AND Usuario = '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                VariaveisGlobais.gIncluir = IIf(IsDBNull(wDataReader("Incluir")), True, False)
                VariaveisGlobais.gAlterar = IIf(IsDBNull(wDataReader("Alterar")), True, False)
                VariaveisGlobais.gExcluir = IIf(IsDBNull(wDataReader("Excluir")), True, False)
                wDataReader.Close()
                Return True
            End If
            wDataReader.Close()

            wComando.CommandText = "SELECT * FROM C_ProgramasLiberacoes " & _
                           " WHERE NomePrograma='" & pPrograma & "'" & _
                           " AND Usuario = 'TODOS'" & _
                           " AND CodigoSetor= '' " & _
                           " AND TipoUsuario= '' "

            wDataReader = wComando.ExecuteReader
            If wDataReader.Read() Then
                VariaveisGlobais.gIncluir = IIf(IsDBNull(wDataReader("Incluir")), True, False)
                VariaveisGlobais.gAlterar = IIf(IsDBNull(wDataReader("Alterar")), True, False)
                VariaveisGlobais.gExcluir = IIf(IsDBNull(wDataReader("Excluir")), True, False)
                wDataReader.Close()
                Return True
            End If
            wDataReader.Close()

        Catch ex As Exception
            VariaveisGlobais.gUltimoSQL = wComando.CommandText
            VariaveisGlobais.gDescricaoUltimoErro = ex.Message
            VariaveisGlobais.gStackTraceErro = ex.StackTrace
            Return False
        End Try
        Return False
    End Function
    Public Function SetPaperSize(ByVal paper As String, ByVal pd As PrintDocument) As Boolean

        Dim paperalt1 As String = paper
        Dim paperalt2 As String = paper
        'If paper = "850 x 550" Then
        '    paperalt1 = "A5(148 x 210 mm)"
        '    paperalt2 = "A5"
        'End If
        Dim psd As New PageSetupDialog
        psd.AllowMargins = False
        psd.AllowOrientation = False
        psd.Document = pd
        Dim psz As PaperSize
        Dim dr As DialogResult
        For Each psz In pd.DefaultPageSettings.PrinterSettings.PaperSizes
            If psz.PaperName.ToString = paper OrElse psz.PaperName.ToString = paperalt1 _
                OrElse psz.PaperName.ToString = paperalt2 Then
                psd.Document.DefaultPageSettings.PaperSize = psz
                If psz.PaperName.ToString <> paper Then
                    '  psd.Document.DefaultPageSettings.Landscape = True
                End If
                dr = DialogResult.OK
                Return True
            End If
        Next

        ' No match? Simply return the 0th size.
        ErroPapel(paper)
        Return False
    End Function

    Public Function SetPrintDialog(ByRef pAlturaPapel As Integer, ByRef pd As PrintDocument) As Boolean
        pAlturaPapel = 0
        Dim psd As New PageSetupDialog
        psd.Document = pd
        Dim dr As DialogResult

        dr = DialogResult.OK
        Dim pdlg As New PrintDialog
        pd.PrinterSettings.PrintRange = PrintRange.AllPages
        pd.PrinterSettings.FromPage = 1
        pd.PrinterSettings.ToPage = 9999
        pdlg.Document = pd
        pdlg.AllowSomePages = True
        pdlg.AllowPrintToFile = True
        pdlg.UseEXDialog = True
        Dim pdr As System.Windows.Forms.DialogResult = pdlg.ShowDialog

        If pdr = System.Windows.Forms.DialogResult.OK Then
            If pd.DefaultPageSettings.Landscape = False Then
                pAlturaPapel = pd.DefaultPageSettings.PaperSize.Height
            Else
                pAlturaPapel = pd.DefaultPageSettings.PaperSize.Width
            End If
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub ErroPapel(ByVal ppapel As String)
        MessageBox.Show("Papel " & ppapel & " Não Configurado para esta Impressora ! ")
    End Sub

    Public Function VerTeclaInc(ByVal pEmpresa As String, ByVal pFilial As String) As Boolean
        If VariaveisGlobais.gTipoUsuario = "A" Then
            Return True
        ElseIf VariaveisGlobais.gConnectionStringServer.ToUpper = "GRU" _
            And pEmpresa = "1" And pFilial = "2" Then
            Return True
        ElseIf VariaveisGlobais.gConnectionStringServer.ToUpper = "ETA" _
            And pEmpresa = "1" And pFilial <> "2" Then
            Return True
        ElseIf VariaveisGlobais.gConnectionStringServer.ToUpper = "ETA" _
            And pEmpresa = "3" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function VerStatusImpressora(ByVal pPrinterName As String) As Boolean

        Dim strPrintServer As String
        strPrintServer = "localhost" 'VariaveisGlobais.gConnectionStringServer
        Dim WMIObject As String, PrinterSet As Object, Printer As Object
        WMIObject = "winmgmts://" & strPrintServer
        PrinterSet = GetObject(WMIObject).InstancesOf("win32_Printer")

        For Each Printer In PrinterSet
            If pPrinterName = Printer.Name.ToString Then

                Dim status As String = PrinterStatusToString(Printer.PrinterStatus)
                If status <> "" Then
                    'MsgBox(Printer.Name & ": Não está On Line ! ")
                    Return False
                Else
                    Return True
                End If
            End If
        Next Printer
        'MsgBox(Printer.Name & ": Não Encontrada ! ")
        Return False
    End Function

    Public Enum PrinterStatus
        Printer = 1
        PrinterUnknown = 2
        PrinterIdle = 3
        PrinterPrinting = 4
        PrinterWarmup = 5
        PrinterStopped = 6
        PrinterOffline = 7

        ' For more states see WMI docs.
    End Enum

    Public Function PrinterStatusToString(ByVal ps As PrinterStatus) As String
        Dim s As String
        Select Case ps
            Case PrinterStatus.PrinterIdle
                s = ""
            Case PrinterStatus.PrinterPrinting
                s = "printing"
            Case PrinterStatus.PrinterWarmup
                s = "warming up"
            Case Else   ' Vielleicht gibt es noch weitere Fälle...
                s = "unknown state"
        End Select
        PrinterStatusToString = s
    End Function

    Public Sub PosicionaDigito(ByVal psender As Object)
        Dim a As Object = psender
        Dim x As String = a.Text.Replace("/", "")
        If Len(x) > 1 Then
            a.Mask = "####################".Substring(0, Len(x) - 1) & "/#"
            If Len(x) + 1 < a.MaxLength Then
                a.Mask = a.Mask & "#"
            End If
        End If
        a.Text = x
        a.SelectionStart = Len(a.Text)
    End Sub

    Public Sub ConverteMin_DHM(ByVal pMinutos As Integer, ByRef wDias As Decimal, _
        ByRef wHoras As Integer, ByRef wMinutos As Integer)
        wMinutos = pMinutos Mod 60
        wHoras = Int(pMinutos / 60)
        wDias = Int(wHoras / 24)
        wHoras = wHoras Mod 24
    End Sub

    Sub ProtegeTela(ByVal pStatusMov As Integer, ByRef mycontrol As Object)

        If pStatusMov = 1 Then
            Dim x As Control
            Dim y As Control
            Dim z As Control
            For Each x In mycontrol.Controls
                If x.GetType.Name.ToUpper = "BUTTON" Then
                    If x.Name.ToUpper = "BTFECHAR" OrElse _
                       x.Name.ToUpper = "BTLIMPAR" OrElse _
                       (x.Name.Length > 2 AndAlso x.Name.Substring(0, 3).ToUpper = "DTG") Then
                        x.Enabled = True
                    Else
                        x.Enabled = False
                    End If
                End If
                If x.Controls.Count > 0 Then
                    For Each y In x.Controls
                        If y.GetType.Name.ToUpper = "BUTTON" Then
                            If y.Name.ToUpper = "BTFECHAR" OrElse _
                               y.Name.ToUpper = "BTLIMPAR" OrElse _
                               (y.Name.Length > 2 AndAlso y.Name.Substring(0, 3).ToUpper = "DTG") _
                               Then
                                y.Enabled = True
                            Else
                                y.Enabled = False
                            End If
                        End If
                        If y.Controls.Count > 0 Then
                            For Each z In y.Controls
                                If z.GetType.Name.ToUpper = "BUTTON" Then
                                    If z.Name.ToUpper = "BTFECHAR" OrElse _
                                       z.Name.ToUpper = "BTLIMPAR" OrElse _
                                       (z.Name.Length > 2 AndAlso z.Name.Substring(0, 3).ToUpper = "DTG") _
                                       Then
                                        z.Enabled = True
                                    Else
                                        z.Enabled = False
                                    End If
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        End If

    End Sub

    'Public Sub AjustaTela1(ByRef mf As Form, Optional ByVal pLocation As Boolean = False)
    '    Dim difW As Integer = mf.Size.Width - mf.ClientSize.Width
    '    Dim difH As Integer = mf.Size.Height - mf.ClientSize.Height
    '    If mf.IsMdiContainer = False Then
    '        difW += 16
    '        difH += 48
    '    End If
    '    If mf.Tag = "1" Then
    '        Exit Sub
    '    End If

    '    If Screen.PrimaryScreen.Bounds.Height <= 600 OrElse _
    '        Screen.PrimaryScreen.Bounds.Width <= 800 OrElse _
    '        mf.Size.Width >= Screen.PrimaryScreen.WorkingArea.Width - difW OrElse _
    '        mf.Size.Height >= Screen.PrimaryScreen.WorkingArea.Height - difH Then
    '        Dim mydg As New System.Windows.Forms.DataGrid
    '        For Each mCtrl3 As Control In mf.Controls
    '            If mCtrl3.GetType Is mydg.GetType Then mCtrl3.Tag = 1
    '            For Each mCtrl4 As Control In mCtrl3.Controls
    '                If mCtrl4.GetType Is mydg.GetType Then mCtrl4.Tag = 1
    '                For Each mCtrl5 As Control In mCtrl4.Controls
    '                    If mCtrl5.GetType Is mydg.GetType Then mCtrl5.Tag = 1
    '                    For Each mCtrl6 As Control In mCtrl5.Controls
    '                        If mCtrl6.GetType Is mydg.GetType Then mCtrl6.Tag = 1
    '                    Next
    '                Next
    '            Next
    '        Next
    '    Else
    '        mf.Tag = "1"
    '        Dim factorW As Decimal = (mf.ClientSize.Width + difW) / Screen.PrimaryScreen.WorkingArea.Width
    '        Dim factorH As Decimal = (mf.ClientSize.Height + difH) / Screen.PrimaryScreen.WorkingArea.Height
    '        Dim factor As Decimal = IIf(factorW > factorH, factorW, factorH)
    '        If factor < 0.5 Then
    '            factor = 0.5
    '        End If
    '        Dim factor1 As Decimal = factor * 1.04
    '        '? MOD(25.250,5.0)  && Displays 0.250

    '        If Not mf.IsMdiContainer Then
    '            For Each mCtrl3 As Control In mf.Controls
    '                AjustaControls(mCtrl3, factor, factor1)
    '                For Each mCtrl4 As Control In mCtrl3.Controls
    '                    AjustaControls(mCtrl4, factor, 1)
    '                    For Each mCtrl5 As Control In mCtrl4.Controls
    '                        AjustaControls(mCtrl5, factor, 1)
    '                        For Each mCtrl6 As Control In mCtrl5.Controls
    '                            AjustaControls(mCtrl6, factor, 1)
    '                            For Each mCtrl7 As Control In mCtrl6.Controls
    '                                AjustaControls(mCtrl7, factor, 1)
    '                            Next
    '                        Next
    '                    Next
    '                Next
    '            Next
    '        End If

    '        mf.Size = New Size(mf.Size.Width / factor, mf.Size.Height / factor)
    '        If pLocation = True Then
    '            mf.Location = New Point( _
    '            (Screen.PrimaryScreen.Bounds.Width - mf.Size.Width) / 2, _
    '            (Screen.PrimaryScreen.Bounds.Height - mf.Size.Height) / 2)
    '        End If
    '    End If

    'End Sub

    'Private Sub AjustaControls1(ByRef pCtrl As System.Windows.Forms.Control, _
    '    ByVal pfactor As Decimal, ByVal pfactor1 As Decimal)
    '    Dim mydg As New System.Windows.Forms.DataGrid
    '    Dim mydgvw As New System.Windows.Forms.DataGridView
    '    Dim mylbl As New System.Windows.Forms.Label
    '    Dim mytext As New System.Windows.Forms.TextBox

    '    Dim mFnt3 As Font = pCtrl.Font


    '    If pCtrl.GetType Is mylbl.GetType Then
    '        mytext.Font = New Font(mFnt3.FontFamily, pCtrl.Font.Size / pfactor1)
    '        Dim wAltura As String = mytext.Size.Height.ToString
    '        pCtrl.Size = New Size(pCtrl.Size.Width / pfactor, wAltura)
    '    Else
    '        pCtrl.Size = New Size(pCtrl.Size.Width / pfactor, pCtrl.Size.Height / pfactor)
    '    End If
    '    pCtrl.Font = New Font(mFnt3.FontFamily, pCtrl.Font.Size / pfactor1)

    '    pCtrl.Location = New Point(pCtrl.Location.X / pfactor, pCtrl.Location.Y / pfactor)
    '    If pCtrl.GetType Is mydg.GetType OrElse pCtrl.GetType Is mydgvw.GetType Then
    '        pCtrl.Tag = pfactor
    '    End If
    'End Sub

    Public Sub AjustaTela(ByRef mf As Form, Optional ByVal pLocation As Boolean = False)
        Dim difW As Integer = mf.Size.Width - mf.ClientSize.Width
        Dim difH As Integer = mf.Size.Height - mf.ClientSize.Height
        If mf.IsMdiContainer = False Then
            difW += 16
            'difH += 48
            difH += 78
        End If
        If mf.Tag = "1" Then
            Exit Sub
        End If

        If Screen.PrimaryScreen.Bounds.Height <= 600 OrElse _
            Screen.PrimaryScreen.Bounds.Width <= 800 OrElse _
            mf.Size.Width >= Screen.PrimaryScreen.WorkingArea.Width - difW OrElse _
            mf.Size.Height >= Screen.PrimaryScreen.WorkingArea.Height - difH Then
            Dim mydg As New System.Windows.Forms.DataGrid
            For Each mCtrl3 As Control In mf.Controls
                If mCtrl3.GetType Is mydg.GetType Then mCtrl3.Tag = 1
                For Each mCtrl4 As Control In mCtrl3.Controls
                    If mCtrl4.GetType Is mydg.GetType Then mCtrl4.Tag = 1
                    For Each mCtrl5 As Control In mCtrl4.Controls
                        If mCtrl5.GetType Is mydg.GetType Then mCtrl5.Tag = 1
                        For Each mCtrl6 As Control In mCtrl5.Controls
                            If mCtrl6.GetType Is mydg.GetType Then mCtrl6.Tag = 1
                        Next
                    Next
                Next
            Next
        Else
            mf.Tag = "1"
            Dim factorW As Decimal = (mf.ClientSize.Width + difW) / Screen.PrimaryScreen.WorkingArea.Width
            Dim factorH As Decimal = (mf.ClientSize.Height + difH) / Screen.PrimaryScreen.WorkingArea.Height
            Dim factor As Decimal = IIf(factorW > factorH, factorW, factorH)
            If factor < 0.5 Then
                factor = 0.5
            End If
            Dim factor1 As Decimal = factor * 1.04
            '? MOD(25.250,5.0)  && Displays 0.250

            If Not mf.IsMdiContainer Then
                For Each mCtrl3 As Control In mf.Controls
                    AjustaControls(mCtrl3, factor, factor1)
                    For Each mCtrl4 As Control In mCtrl3.Controls
                        AjustaControls(mCtrl4, factor, factor1)
                        For Each mCtrl5 As Control In mCtrl4.Controls
                            AjustaControls(mCtrl5, factor, factor1)
                            For Each mCtrl6 As Control In mCtrl5.Controls
                                AjustaControls(mCtrl6, factor, factor1)
                                For Each mCtrl7 As Control In mCtrl6.Controls
                                    AjustaControls(mCtrl7, factor, factor1)
                                Next
                            Next
                        Next
                    Next
                Next
                mf.Size = New Size(mf.Size.Width / factor, mf.Size.Height / factor)
            Else
                mf.Size = New Size(mf.Size.Width / factorW, mf.Size.Height / factorH)
            End If

            If pLocation = True Then
                mf.Location = New Point( _
                    (Screen.PrimaryScreen.Bounds.Width - difW - mf.Size.Width) / 2, _
                    (Screen.PrimaryScreen.Bounds.Height - difH - mf.Size.Height) / 2)
            Else
                mf.Location = New Point(0, 0)
            End If
        End If

    End Sub

    Private Sub AjustaControls(ByRef pCtrl As System.Windows.Forms.Control, _
        ByVal pfactor As Decimal, ByVal pfactor1 As Decimal)
        Dim mygb As New System.Windows.Forms.GroupBox
        Dim mytc As New System.Windows.Forms.TabControl
        Dim mytp As New System.Windows.Forms.TabPage
        Dim mydg As New System.Windows.Forms.DataGrid
        Dim mydgv As New System.Windows.Forms.DataGridView
        Dim mypn As New System.Windows.Forms.Panel
        Dim mycl As New System.Windows.Forms.CheckedListBox
        Dim mylbl As New System.Windows.Forms.Label
        Dim mytext As New System.Windows.Forms.TextBox
        Dim mypict As New System.Windows.Forms.PictureBox

        Dim mFnt3 As Font = pCtrl.Font
        mytext.Font = New Font(mFnt3.FontFamily, pCtrl.Font.Size / pfactor1)
        Dim wAltura As String = mytext.Size.Height.ToString

        If pCtrl.GetType Is mydg.GetType _
            OrElse pCtrl.GetType Is mydgv.GetType _
            OrElse pCtrl.GetType Is mypict.GetType _
            OrElse pCtrl.GetType Is mytext.GetType Then

            pCtrl.Size = New Size(pCtrl.Size.Width / pfactor, pCtrl.Size.Height / pfactor)
            pCtrl.Font = New Font(mFnt3.FontFamily, pCtrl.Font.Size / pfactor1)

        ElseIf Not (pCtrl.GetType Is mygb.GetType Or pCtrl.GetType Is mypn.GetType Or _
             pCtrl.GetType Is mytc.GetType Or pCtrl.GetType Is mytp.GetType Or _
             pCtrl.GetType Is mycl.GetType) Then

            If pCtrl.Width >= pCtrl.Height Then
                pCtrl.Size = New Size(pCtrl.Size.Width / pfactor, wAltura)
            Else
                pCtrl.Size = New Size(pCtrl.Size.Width / pfactor, pCtrl.Size.Height / pfactor)
            End If
            pCtrl.Font = New Font(mFnt3.FontFamily, pCtrl.Font.Size / pfactor1)

        Else
            pCtrl.Size = New Size(pCtrl.Size.Width / pfactor, pCtrl.Size.Height / pfactor)
        End If

        pCtrl.Location = New Point(pCtrl.Location.X / pfactor, pCtrl.Location.Y / pfactor)
        If pCtrl.GetType Is mydg.GetType OrElse pCtrl.GetType Is mydgv.GetType Then
            pCtrl.Tag = pfactor
        End If
    End Sub

    Public Function TempoRestanteEstimado(ByVal pbProgresso As Object, ByVal pDataInicio As Date) As String
        Try
            Dim tempoREstante As Decimal = 0
            Dim tempoDecorrido As Decimal = DateDiff(DateInterval.Second, pDataInicio, Date.Now)
            If pbProgresso.Value > 0 Then
                Dim tempoEstimado As Decimal = (tempoDecorrido * pbProgresso.Maximum) / pbProgresso.Value
                tempoREstante = tempoEstimado - tempoDecorrido
            End If

            Return "Tempo estimado restante: " & SToHHMMSS(Math.Truncate(tempoREstante))

        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Private Const HOURS_IN_DAY As Integer = 24
    Private Const MINUTES_IN_HOUR As Integer = 60
    Private Const SECONDS_IN_MINUTE As Integer = 60

    Public Function SToHHMMSS(ByVal mSegundos As Integer) As String
        Dim InSeconds As Long, InMinutes As Long, InHours As Long
        Dim seconds As Integer, minutes As Integer, hours As Integer
        Dim r As String
        InSeconds = mSegundos
        seconds = InSeconds Mod (SECONDS_IN_MINUTE)
        InMinutes = Math.Truncate(InSeconds / SECONDS_IN_MINUTE)
        minutes = InMinutes Mod (MINUTES_IN_HOUR)
        InHours = Math.Truncate(InMinutes / MINUTES_IN_HOUR)
        hours = InHours Mod (HOURS_IN_DAY)
        If hours > 0 Then
            r = hours & "h "
        Else
            r = Nothing
        End If
        If minutes > 0 And minutes < 10 Then
            r = r & "0" & minutes & "m "
        ElseIf minutes >= 10 Then
            r = r & minutes & "m "
        ElseIf minutes = 0 Then
            r = r & "00m "
        End If

        If seconds > 0 And seconds < 10 Then
            r = r & "0" & seconds & "s"
        ElseIf seconds >= 10 Then
            r = r & seconds & "s"
        ElseIf seconds = 0 Then
            r = r & "00s"
        End If

        Return r
    End Function

End Module

