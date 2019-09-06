Module Luckey_UnicornV1


    Sub Main()
        payout()




    End Sub

    ''' <summary>
    '''     Integer checking function. Checks if user input is an integer between the values given. 
    ''' </summary>
    ''' <param name="LowNumber"> Lower bound of the valid range. </param>
    ''' <param name="HighNumber"> Upper bound of the valid range. </param>
    ''' <returns> The valid user input as an integer. </returns>

    Function IntegerCheck(LowNumber As Integer, HighNumber As Integer) As Integer

        'Housekeeping
        Dim UserResponse As Integer
        Const ERROR_MESSAGE As String = "Whoops! Please enter an integer."
        Dim ValidInput As Boolean = False
        Dim OUTPUT_MESSAGE As String = String.Format("Please enter an integer between {0} and {1}.", LowNumber, HighNumber)

        While Not ValidInput
            Try
                ' Ask user for a number and store it.
                Console.WriteLine(OUTPUT_MESSAGE)
                UserResponse = Console.ReadLine()

                If LowNumber <= UserResponse And UserResponse <= HighNumber Then
                    ValidInput = True

                End If

            Catch ex As Exception
                Console.WriteLine(ERROR_MESSAGE)

            End Try

        End While

        ' Pause program to view output.
        Return UserResponse
    End Function

    '******************************************************************************************************************************************************************************************************************************************************************//


    Function GetToken() As String

        Dim tokens() As String =
            {"Horse", "Zebra", "Donkey", "Unicorn"}
        Dim rand As Random = New Random()
        Dim index As Integer = rand.Next(0, 4)


        Return tokens(index)
    End Function




    '*******************************************************************************************************************************************************************************************

    Public Sub payout()

        Dim Total As Double = 10 'Starting amount as $10
        Dim Token As String = ""
        Dim Feedback As String = ""
        Dim keepgoing As String = ""


        Console.WriteLine("howmuch would you like to play with?")
        Total = IntegerCheck(1, 10)

        While keepgoing = ""
            Token = GetToken()

            'Adjust total based on token 

            If Token = "Unicorn" Then 'if Unicorn then add $5 
                Total += 5
                Feedback = "Congrats you won $5" 'console writes line saying congrats 

            ElseIf Token = "Donkey " Then 'if donkey removes $1 
                Total -= 0.5
                Feedback = "Sorry you lost $1" 'console writes line saying sorry you lost 

            Else 'any thing other then Donkey or unicorn  
                Total -= 1
                Feedback = "Sorry you lost $0.50 " 'console writes line saying sorry you lost 
            End If

            'diplays the messages written from the feed back 
            Console.WriteLine(Feedback)

            'Displays your new total amount you have won or your new just 
            Console.WriteLine(String.Format("You have ${0} to play with.", Total.ToString("##0.00")))
            Console.WriteLine()

            If Total < 1 Then
                Console.WriteLine("sorry, you dont have enough money to play")
                keepgoing = "END"
            Else
                Console.WriteLine("press <Enter> key to play again or any key to quit")
            keepgoing = Console.ReadLine()

            End If

        End While

        Console.WriteLine("Thanks for playing :)")
        Console.ReadLine()
    End Sub
End Module
