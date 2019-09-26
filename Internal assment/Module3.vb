Module Module3

    Public Sub score()

        Dim totalscore As Double = 0 'seats the start score as 0 
        Dim questions As String = ""
        Dim Feedback As String = ""
        Dim keepgoing As String = ""

        While keepgoing = ""
            questions = Version1.Genaratequestions("Yes", "No")

            If questions = "q1" And userResponse = Y Then 'if the questioon is q1 and that the user response was Y then they get an extra score of 1 
                totalscore += 1
                Console.ReadLine()

            ElseIf userResponse = N Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If

            If questions = "q2" And userResponse = Y Then 'if the questioon is q3 and that the user response was Y then they get an extra score of 1 
                totalscore += 1
                Console.ReadLine()

            ElseIf userResponse = N Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If

            If questions = "q3" And userResponse = N Then 'if the questioon is q3 and that the user response was N then they get an extra score of 1 
                totalscore += 1

            ElseIf userResponse = Y Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If

            'diplays the messages written from the feed back 
            Console.WriteLine(Feedback)

            'Displays your new totalscore after the game  
            Console.WriteLine(String.Format("", totalscore.ToString("##0.00")))
            Console.WriteLine()

        End While
    End Sub

End Module
