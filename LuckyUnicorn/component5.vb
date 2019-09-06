
Module component5


    Public Sub payout()

        Dim Total As Double = 0.00 'Starting amount as $10
        Dim Token As String = ""
        Dim Feedback As String = ""
        Dim keepgoing As String = ""


        Console.WriteLine("howmuch would you like to play with?")


        Total = Console.ReadLine
        'Inpot a token manualy 
        Console.WriteLine("please enter a token")
        Token = Console.ReadLine()

        While keepgoing = ""
            'Adjust total based on token 

            If Token = "Unicorn" Then 'if Unicorn then add $5 
                Total += 5
                Feedback = "Congrats you won $5" 'console writes line saying congrats 

            ElseIf Token = "Donkey " Then 'if donkey removes $1 
                Total -= 1
                Feedback = "Sorry you lost $1" 'console writes line saying sorry you lost 

            Else 'any thing other then 
                Total -= 0.5
                Feedback = "Sorry you lost $0.50 " 'console writes line saying sorry you lost 
            End If

            'diplays the messages written from the feed back 
            Console.WriteLine(Feedback)

            'Displays your new total amount you have won or your new just 
            Console.WriteLine(String.Format("You have ${0} to play with.", Total.ToString("##0.00")))
            Console.WriteLine()


            If Total < 1.0 Then
                Console.WriteLine("Sorry, you dont have enough money to play")
                keepgoing = "END"
            Else
                Console.WriteLine("Press <Enter> key to play again or any key to quit.")
                keepgoing = Console.ReadLine()

            End If

        End While

        Console.WriteLine("Thanks for playing :)")
        Console.ReadLine()
    End Sub
End Module

