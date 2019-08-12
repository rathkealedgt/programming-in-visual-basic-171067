Module Component3

    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 1
    '''     Generate a token from a list and display it to a user 
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
    Sub Main()
        ' Housekeeping

        Const HOW_MUCH As Integer = 100
        Dim countHorse As Integer = 0
        Dim countZebra As Integer = 0
        Dim countDonkey As Integer = 0
        Dim countUnicorn As Integer = 0

        For counter As Integer = 0 To HOW_MUCH
            Dim token As String = GetToken()

            If token = "Unicorn" Then
                countUnicorn += 1

            ElseIf token = "Donkey" Then
                countDonkey += 1

            ElseIf token = "Horse" Then
                countHorse += 1
            Else
                countZebra += 1
            End If
            Console.WriteLine(token)
        Next counter
        Dim winnnings As Double = countUnicorn * 5 + (countZebra * 0.5)
        Console.WriteLine(vbNewLine & String.Format("you spent ${0}.", HOW_MUCH))
        Console.WriteLine("you go home wiht ${0}", winnnings)


        Console.WriteLine(vbNewLine & "**** win / loss calculations ****")
        Console.WriteLine("  Unicorns = {0}", countUnicorn)
        Console.WriteLine("  Zebra/Horse = {0}", countZebra)
        Console.WriteLine("  Donkey = {0}", countDonkey)
        Console.ReadLine()

    End Sub

    Function GetToken() As String
        Dim tokens() As String = {"Horse", "Zebra", "Donkey", "Unicorn"}
        Dim rand As Random = New Random()
        Dim index As Integer = rand.Next(0, 4)


        Return tokens(index)
    End Function

End Module
