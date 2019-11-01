Module Main_Loop

    Sub Main()
        Console.WriteLine("Hello and welcome to my game.")
        Console.WriteLine("This game will ask you a series of 10 questions. Which if you chose to continue will ask you to
input your answers as ether Yes or No.Y and N are also acceptable answers meaning the same thing as Yes and NO. If you wish to continue please press enter")
        Console.ReadLine()

        Dim UserResponse As String = ""
        Dim OutPutMessage As String
        Dim QandA() As String = Genaratequestions("Yes", "No")

        For counter As Integer = 0 To 19

            'Asks Question 
            Console.WriteLine(QandA(counter))
            Console.WriteLine("Please enter your answer")
            UserResponse = Console.ReadLine()

            'computer Responce 
            OutPutMessage = String.Format("You entered {0}.", UserResponse)
            Console.WriteLine(OutPutMessage)

            counter += 1
            Console.WriteLine(QandA(counter))
            Console.WriteLine()
        Next counter



        'Answer to the question Responce 



        'end message 
        Dim replay As String
        Console.WriteLine("Thankyou for playing")
        Console.WriteLine("If you wish to play again then please press R. If not you can exit now.")
        replay = Console.ReadLine().ToString()
        If replay = "r" Then
            Main()
        End If



    End Sub

    Function Genaratequestions(Y As String, N As String) As String()

        Dim QandA(19) As String 'the questions that will be given to the user 


        QandA(0) = "Was the 50th President of the United Stats Donald Trump?"
        QandA(1) = N & ". the answer is No. He is not the 50th President"

        QandA(2) = "Are stars the same as our sun?"
        QandA(3) = Y & ". The answer is Yes. All stars are the same as a sun"

        QandA(4) = "Is the earth moving?"
        QandA(5) = Y & ". The anwer is Yes the earth is moving"

        QandA(6) = "Is water reqired for life?"
        QandA(7) = Y & ". The answer is yes. At this present time scientists belive that water is requried for life"

        QandA(8) = "Did the secound world war start in 1939?"
        QandA(9) = Y & ". The answer is Yes. The secound world war started on september the 1st 1939 When Germany invaded Poland"

        QandA(10) = "Was Hitler a bad guy ?"
        QandA(11) = Y & ". The answer is yes. This is a bit of a morel question but yes he was a bad guy"

        QandA(12) = "Was Putin part of the KGB?"
        QandA(13) = Y & ". The answer is yes. Putin was part of the KGB for much of his early life and Correa"

        QandA(14) = "Do you know a yes or no question?"
        QandA(15) = N & ". Or" & Y & ". Answer Yes or no dose not matter what your answer was. HA HA !"

        QandA(16) = "Dose Danial have a cool hair cut"
        QandA(17) = N & ". The Answer is No. he dose not "

        QandA(18) = "Are Vegins bad people"
        QandA(19) = Y & ".The answer us yes. They are bad people"


        Return QandA 'gives a selected question
    End Function



End Module



