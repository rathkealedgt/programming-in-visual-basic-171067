Module GenarateQandA


    Function Genaratequestions(Y As String, N As String) As String()

        Dim QandA(19) As String 'the questions that will be given to the user 


        QandA(0) = "Was the 50th President of the United Stats Donald Trump?"
        QandA(1) = N

        QandA(2) = "Are stars the same as suns?"
        QandA(3) = Y

        QandA(4) = "Is the earth moving?"
        QandA(5) = Y

        QandA(6) = "Is water reqired for life?"
        QandA(7) = Y

        QandA(8) = "did the secound world war start in 1939?"
        QandA(9) = N

        QandA(10) = "Was Hitler a bad guy ?"
        QandA(11) = Y

        QandA(12) = "Was the 50 President of the United Stats Donald Trump?"
        QandA(13) = N

        QandA(14) = "Was the 50 President of the United Stats Donald Trump?"
        QandA(15) = N

        QandA(16) = "Was the 50 President of the United Stats Donald Trump?"
        QandA(17) = N

        QandA(18) = "Was the 50 President of the United Stats Donald Trump?"
        QandA(19) = N

        Console.WriteLine()

        For counter As Integer = 0 To 19 'Gose through the questions 
            Console.WriteLine(QandA)
        Next counter
        Console.ReadLine()


        Return QandA 'gives a selected question
    End Function
End Module
