Module Module3V2


    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 1
    '''     Generate a token from a list and display it to a user 
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
    Sub Main()
        ' Housekeeping
        Dim totalscore As Double = 0 'seats the start score as 0 
        Dim questions As String = ""
        Dim Feedback As String = ""


        Dim countq1 As Integer = 0
        Dim countq2 As Integer = 0
        Dim countq3 As Integer = 0
        Dim countq4 As Integer = 0
        Dim countq5 As Integer = 0
        Dim countq6 As Integer = 0
        Dim countq7 As Integer = 0
        Dim countq8 As Integer = 0
        Dim countq9 As Integer = 0
        Dim countq10 As Integer = 0

        For counter As Integer = 0 To Totalscore
            Dim token As String = GetToken()


            If questions = "q1" And userResponse = Y Then 'if the questioon is q1 and that the user response was Y then they get an extra score of 1 
                Totalscore += 1
                Console.ReadLine()

            ElseIf userResponse = N Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If

            If questions = "q2" And userResponse = Y Then 'if the questioon is q3 and that the user response was Y then they get an extra score of 1 
                Totalscore += 1
                Console.ReadLine()

            ElseIf userResponse = N Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If

            If questions = "q3" And userResponse = N Then 'if the questioon is q3 and that the user response was N then they get an extra score of 1 
                Totalscore += 1

            ElseIf userResponse = Y Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If
            Console.WriteLine(token)
        Next counter

        Console.WriteLine(vbNewLine & String.Format(" {0}.", Totalscore))
        Console.WriteLine("you go home wiht ${0}", Totalscore)


        Console.WriteLine(vbNewLine & "**** win / loss calculations ****")
        Console.WriteLine("  q1 = {0}", countq1)
        Console.WriteLine("  q2 = {0}", countq2)
        Console.WriteLine(" q3 = {0}", countq3)
        Console.WriteLine(" q4 = {0}", countq4)
        Console.WriteLine(" q5 = {0}", countq5)
        Console.WriteLine(" q6 = {0}", countq6)
        Console.WriteLine(" q7 = {0}", countq7)
        Console.WriteLine(" q8 = {0}", countq8)
        Console.WriteLine(" q9 = {0}", countq8)
        Console.WriteLine(" q10 = {0}", countq10)
        Console.ReadLine()

    End Sub

    Function GetToken() As String
        Dim tokens() As String = {"Horse", "Zebra", "Donkey", "Unicorn"}
        Dim rand As Random = New Random()
        Dim index As Integer = rand.Next(0, 4)


        Return tokens(index)
    End Function

End Module

